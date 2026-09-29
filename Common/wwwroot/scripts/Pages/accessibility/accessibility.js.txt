// Accessibility scanning helper for the Blazor Sample Browser.
// Loads the Axe-Core library on demand and runs a scan against the
// currently visible sample area. Returns a JSON payload to the caller.
(function (global) {
    'use strict';

    var axePromise = null;

    function getAxeScriptUrl() {
        const script = document.querySelector(
            'script[src*="/accessibility/"][src*="accessibility"]'
        );
        if (!script) {
            throw new Error("accessibility.js not found");
        }
        const fileName = script.src.split('/').pop();
        return script.src.replace(fileName, 'axe.min.js');
    }

    function tryLoadFromList(candidates) {
        if (!candidates || candidates.length === 0) {
            return Promise.reject(new Error('No candidate URLs available to load axe.min.js'));
        }
        var url = candidates[0];
        return new Promise(function (resolve, reject) {
            var script = document.createElement('script');
            script.src = url;
            script.async = true;
            script.setAttribute('data-blazor-accessibility', 'axe');
            script.onload = function () {
                if (global.axe && typeof global.axe.run === 'function') {
                    resolve(global.axe);
                } else {
                    // Script loaded but doesn't expose axe.
                    reject(new Error('Loaded script does not provide axe (url: ' + url + ')'));
                }
            };
            script.onerror = function () {
                // Remove the failed script tag and try the next URL.
                if (script.parentNode) {
                    script.parentNode.removeChild(script);
                }
                tryLoadFromList(candidates.slice(1)).then(resolve, reject);
            };
            document.head.appendChild(script);
        });
    }

    async function loadAxe() {
        if (global.axe && typeof global.axe.run === 'function') {
            return global.axe;
        }
        if (axePromise) {
            return axePromise;
        }
        try {
            var axeUrl = await getAxeScriptUrl();

            axePromise = tryLoadFromList([
                axeUrl
            ]);

            return axePromise;
        }
        catch (err) {
            console.error('Unable to resolve axe script path', err);
            throw err;
        }
    }

    // The most-specific element matches first.  We deliberately exclude
    // broad fallbacks like 'main' / '#sb-content' / '.control-fluid'
    // because at narrow viewports they can wrap the whole document
    // (header, sidebars, etc.) and cause the report to vary as the
    // user resizes.  The first element in the list is the canonical
    // Sample Browser "current sample" wrapper and is preferred on
    // every viewport.
    var SCAN_TARGET_CANDIDATES = [
        '.sb-demo-section'
    ];

    // Cache the resolved target so subsequent scans re-use the same
    // element instead of resolving again.  This keeps the report
    // stable across viewport resizes between scans.
    var resolvedTarget = null;
    var resolvedTargetKey = null;

    function resolveTarget() {
        if (resolvedTarget && resolvedTarget.isConnected) {
            // Re-use the previously resolved element if it's still in
            // the document and is the same candidate selector.
            var node = document.querySelector(resolvedTargetKey);
            if (node && node === resolvedTarget) {
                return resolvedTarget;
            }
        }
        for (var i = 0; i < SCAN_TARGET_CANDIDATES.length; i++) {
            var sel = SCAN_TARGET_CANDIDATES[i];
            var node = document.querySelector(sel);
            if (node) {
                resolvedTarget = node;
                resolvedTargetKey = sel;
                return node;
            }
        }
        // Fallback to document.body, but mark the cache so we know
        // it's the broad case and the next scan still uses it.
        resolvedTarget = document.body || document.documentElement;
        resolvedTargetKey = null;
        return resolvedTarget;
    }

    function runScan() {
        return loadAxe().then(function (axe) {
            if (!axe || typeof axe.run !== 'function') {
                throw new Error('Axe-Core is unavailable.');
            }
            var target = resolveTarget();
            return axe.run(target, {
                runOnly: {
                    type: 'tag',
                    values: [
                        'wcag2a',
                        'wcag2aa',
                        'wcag2aaa',
                        'wcag21a',
                        'wcag21aa',
                        'wcag21aaa',
                        'wcag22a',
                        'wcag22aa',
                        'section508',
                        'best-practice'
                    ]
                },
                resultTypes: ['passes', 'violations', 'incomplete', 'inapplicable']
            }).then(function (results) {
                return JSON.stringify(results);
            });
        });
    }

    // ----------------------------------------------------------------
    // Helpers that mirror the C# service logic used in the original
    // AccessibilityService implementation.  They allow the new-window
    // report to be produced entirely on the client side so the
    // Blazor component does not need a registered C# service.
    // ----------------------------------------------------------------

    function scoreCss(score) {
        if (score >= 90) return 'a11y-score-green';
        if (score >= 70) return 'a11y-score-orange';
        return 'a11y-score-red';
    }

    // Map individual success-criterion tags (wcagNNN / wcagNNNN) to a simplified
    // A / AA / AAA label.  Covers WCAG 2.0, 2.1, and 2.2 success criteria.
    // Any tag not present in this map is dropped from the report.
    var WCAG_CRITERION_LABELS = {
        // WCAG 2.0
        'wcag111': 'WCAG A',
        'wcag121': 'WCAG A', 'wcag122': 'WCAG A', 'wcag123': 'WCAG A', 'wcag124': 'WCAG A', 'wcag125': 'WCAG AA',
        'wcag131': 'WCAG A', 'wcag132': 'WCAG A', 'wcag133': 'WCAG A',
        'wcag141': 'WCAG A', 'wcag142': 'WCAG A', 'wcag143': 'WCAG AA',
        'wcag144': 'WCAG AAA', 'wcag145': 'WCAG AA', 'wcag146': 'WCAG AAA', 'wcag147': 'WCAG AAA', 'wcag148': 'WCAG AAA', 'wcag149': 'WCAG AAA',
        'wcag211': 'WCAG A', 'wcag212': 'WCAG A', 'wcag221': 'WCAG A', 'wcag222': 'WCAG A',
        'wcag231': 'WCAG A', 'wcag232': 'WCAG AAA',
        'wcag241': 'WCAG A', 'wcag242': 'WCAG A', 'wcag243': 'WCAG A', 'wcag244': 'WCAG A',
        'wcag245': 'WCAG AA', 'wcag246': 'WCAG AA', 'wcag247': 'WCAG AA',
        'wcag248': 'WCAG AAA', 'wcag249': 'WCAG AAA', 'wcag2410': 'WCAG AAA',
        'wcag311': 'WCAG A', 'wcag312': 'WCAG AA',
        'wcag313': 'WCAG AAA', 'wcag314': 'WCAG AAA', 'wcag315': 'WCAG AAA', 'wcag316': 'WCAG AAA',
        'wcag321': 'WCAG A', 'wcag322': 'WCAG A', 'wcag323': 'WCAG AAA',
        'wcag324': 'WCAG AA', 'wcag325': 'WCAG AAA',
        'wcag331': 'WCAG A', 'wcag332': 'WCAG A', 'wcag333': 'WCAG AA', 'wcag334': 'WCAG AA',
        'wcag335': 'WCAG AAA', 'wcag336': 'WCAG AAA',
        'wcag411': 'WCAG A', 'wcag412': 'WCAG A',
        // WCAG 2.1
        'wcag134': 'WCAG AA', 'wcag135': 'WCAG AA', 'wcag136': 'WCAG AAA',
        'wcag1410': 'WCAG AA', 'wcag1411': 'WCAG AA', 'wcag1412': 'WCAG AA', 'wcag1413': 'WCAG AA',
        'wcag213': 'WCAG AAA', 'wcag214': 'WCAG A',
        'wcag251': 'WCAG A', 'wcag252': 'WCAG A', 'wcag253': 'WCAG A', 'wcag254': 'WCAG A',
        'wcag255': 'WCAG AAA', 'wcag256': 'WCAG AAA',
        'wcag413': 'WCAG AA',
        // WCAG 2.2
        'wcag2411': 'WCAG AA', 'wcag2412': 'WCAG AA', 'wcag2413': 'WCAG AAA',
        'wcag257': 'WCAG AA', 'wcag258': 'WCAG AA',
        'wcag326': 'WCAG A', 'wcag337': 'WCAG A', 'wcag338': 'WCAG AA'
    };

    // WCAG conformance level tag -> simplified label.
    var WCAG_LEVEL_LABELS = {
        'wcag2a': 'WCAG A',
        'wcag2.0-a': 'WCAG A',
        'wcag21a': 'WCAG A',
        'wcag2.1-a': 'WCAG A',
        'wcag22a': 'WCAG A',
        'wcag2.2-a': 'WCAG A',
        'wcag2aa': 'WCAG AA',
        'wcag2.0-aa': 'WCAG AA',
        'wcag21aa': 'WCAG AA',
        'wcag2.1-aa': 'WCAG AA',
        'wcag22aa': 'WCAG AA',
        'wcag2.2-aa': 'WCAG AA',
        'wcag2aaa': 'WCAG AAA',
        'wcag21aaa': 'WCAG AAA'
    };

    // Build a compact, deduped label list for a rule's tag set.
    // Order: WCAG A, WCAG AA, WCAG AAA, Section 508, Best Practice.
    var WCAG_DISPLAY_ORDER = ['WCAG A', 'WCAG AA', 'WCAG AAA'];

    function formatWcag(tags) {
        if (!tags || !tags.length) return '';
        var presentLevels = {};
        var presentStandards = {};
        for (var i = 0; i < tags.length; i++) {
            var tag = (tags[i] || '').toLowerCase();
            // Conformance level tags - map to simple A / AA / AAA.
            if (WCAG_LEVEL_LABELS[tag]) {
                presentLevels[WCAG_LEVEL_LABELS[tag]] = true;
                continue;
            }
            // Success criterion tags (wcagNNN or wcagNNNN).
            if (/^wcag\d{3,4}$/.test(tag)) {
                if (WCAG_CRITERION_LABELS[tag]) {
                    presentLevels[WCAG_CRITERION_LABELS[tag]] = true;
                }
                // Tags not in the map are dropped (no "WCAG x.y.z" fallback).
                continue;
            }
            // Best practice and standards tags.  EN 301 549 is intentionally
            // not displayed in the report.
            if (tag === 'best-practice') presentStandards['Best Practice'] = true;
            else if (tag === 'section508' || tag.indexOf('section508.') === 0) presentStandards['Section 508'] = true;
        }

        // Emit WCAG levels in a fixed order, each only once.
        var out = [];
        for (var k = 0; k < WCAG_DISPLAY_ORDER.length; k++) {
            if (presentLevels[WCAG_DISPLAY_ORDER[k]]) out.push(WCAG_DISPLAY_ORDER[k]);
        }
        // Emit remaining standards in a stable order.
        var stdOrder = ['Section 508', 'Best Practice'];
        for (var s = 0; s < stdOrder.length; s++) {
            if (presentStandards[stdOrder[s]]) out.push(stdOrder[s]);
        }
        return out.join(', ');
    }

    function extractElement(nodes) {
        if (!nodes || nodes.length === 0) return '';
        for (var i = 0; i < nodes.length; i++) {
            var n = nodes[i];
            if (n && n.html) {
                return n.html.length > 200 ? n.html.substring(0, 200) + '...' : n.html;
            }
            if (n && n.target && n.target.length) return n.target[0];
        }
        return '';
    }

    function buildReportModel(scan) {
        var findings = [];
        var passed = 0, failed = 0, bestPractice = 0;
        var id = 1;

        (scan.passes || []).forEach(function (node) {
            findings.push({
                id: id++,
                ruleId: node.id || '',
                description: node.description || node.help || '',
                element: extractElement(node.nodes),
                wcag: formatWcag(node.tags),
                nodes: (node.nodes || []).length,
                status: 'Passed'
            });
            passed++;
        });
        (scan.violations || []).forEach(function (node) {
            findings.push({
                id: id++,
                ruleId: node.id || '',
                description: node.description || node.help || '',
                element: extractElement(node.nodes),
                wcag: formatWcag(node.tags),
                nodes: (node.nodes || []).length,
                status: 'Failed'
            });
            failed++;
        });
        (scan.incomplete || []).forEach(function (node) {
            findings.push({
                id: id++,
                ruleId: node.id || '',
                description: node.description || node.help || '',
                element: extractElement(node.nodes),
                wcag: formatWcag(node.tags),
                nodes: (node.nodes || []).length,
                status: 'Best Practice'
            });
            bestPractice++;
        });

        // Score calculation: only count passed vs failed (inapplicable rules are not counted)
        var total = passed + failed;
        var score = total === 0 ? 100 : Math.round((passed / total) * 100);
        return {
            summary: { score: score, passedRules: passed, failedRules: failed, bestPractices: bestPractice },
            findings: findings
        };
    }

    function buildSummarySection(summary) {
        var css = scoreCss(summary.score);
        var html = '';
        html += '<section class="a11y-report-summary" aria-label="Quick metrics">';
        html += '  <div class="a11y-score-card ' + css + '">';
        html += '    <span class="a11y-score-label">Accessibility Score</span>';
        html += '    <span class="a11y-score-value">' + summary.score + '%</span>';
        html += '  </div>';
        html += '  <div class="a11y-metric-card">';
        html += '    <span class="a11y-metric-label">Passed Rules</span>';
        html += '    <span class="a11y-metric-value a11y-passed">' + summary.passedRules + '</span>';
        html += '  </div>';
        html += '  <div class="a11y-metric-card">';
        html += '    <span class="a11y-metric-label">Failed Rules</span>';
        html += '    <span class="a11y-metric-value a11y-failed">' + summary.failedRules + '</span>';
        html += '  </div>';
        html += '  <div class="a11y-metric-card">';
        html += '    <span class="a11y-metric-label">Best Practices</span>';
        html += '    <span class="a11y-metric-value a11y-best">' + summary.bestPractices + '</span>';
        html += '  </div>';
        html += '</section>';
        return html;
    }

    // Returns a unique element id for the report (one per report window).
    function pagerContainerId() {
        if (!global.__a11yPagerId) {
            global.__a11yPagerId = 0;
        }
        global.__a11yPagerId++;
        return 'a11y-pager-' + global.__a11yPagerId;
    }

    // Returns the HTML placeholder for the pager; the live DOM is
    // populated by client-side scripts in the report window.
    function buildFindingsSection(findings) {
        var html = '';
        html += '<section class="a11y-report-findings" aria-label="Accessibility findings">';
        html += '  <h2 class="a11y-section-title">Accessibility Findings</h2>';
        if (!findings || findings.length === 0) {
            html += '  <div class="a11y-empty-state">No findings to display.</div>';
        } else {
            var containerId = pagerContainerId();
            // Embed the findings as a JSON <script> tag so the runtime
            // can read them in the new window.  Using application/json
            // ensures the browser does not try to execute it.
            html += '  <script type="application/json" data-a11y-findings="' + containerId + '">' +
                    JSON.stringify(findings) + '<\/script>';
            html += '  <div class="a11y-table-wrapper">';
            html += '  <table class="a11y-findings-table" data-a11y-table="' + containerId + '">';
            html += '    <thead><tr>';
            html += '      <th scope="col">#</th>';
            html += '      <th scope="col">Description</th>';
            html += '      <th scope="col">Axe Rule</th>';
            html += '      <th scope="col">WCAG</th>';
            html += '      <th scope="col">Nodes</th>';
            html += '      <th scope="col">Status</th>';
            html += '      <th scope="col">Element</th>';
            html += '    </tr></thead>';
            html += '    <tbody data-a11y-tbody="' + containerId + '"></tbody>';
            html += '  </table>';
            html += '  </div>';
            html += '  <div data-a11y-pager="' + containerId + '"></div>';
            // Inline init - reads findings from the JSON script tag.
            html += '  <script>window.__a11yPagerInit("' + containerId + '");<\/script>';
        }
        html += '</section>';
        return html;
    }

    var REPORT_CSS = '' +
        '* { box-sizing: border-box; }' +
        'body.a11y-window-body { margin: 0; font-family: "Segoe UI","GeezaPro","DejaVu Serif",sans-serif; background:#f5f7fa; color:#222; }' +
        '.a11y-window-header { position: sticky; top: 0; display: flex; align-items: center; justify-content: space-between; padding: 12px 20px; background: #066bc9; color: #fff; box-shadow: 0 2px 4px rgba(0,0,0,0.1); z-index: 10; }' +
        '.a11y-window-header h1 { margin: 0; font-size: 18px; font-weight: 600; }' +
        '.a11y-window-close { background: transparent; border: none; color: #fff; font-size: 24px; line-height: 1; cursor: pointer; padding: 4px 8px; }' +
        '.a11y-window-close:hover { background: rgba(255,255,255,0.15); border-radius: 4px; }' +
        '.a11y-window-main { padding: 20px; max-width: 1280px; margin: 0 auto; }' +
        '.a11y-report-summary { display: grid; grid-template-columns: 1.4fr 1fr 1fr 1fr; gap: 12px; margin-bottom: 20px; }' +
        '.a11y-score-card, .a11y-metric-card { background: #fff; border-radius: 8px; padding: 18px 12px; box-shadow: 0 1px 4px rgba(0,0,0,0.08); display: flex; flex-direction: column; align-items: center; justify-content: center; }' +
        '.a11y-score-label, .a11y-metric-label { font-size: 13px; color: #555; text-transform: uppercase; letter-spacing: 0.5px; margin-bottom: 6px; }' +
        '.a11y-score-value { font-size: 38px; font-weight: 700; line-height: 1; }' +
        '.a11y-metric-value { font-size: 28px; font-weight: 600; }' +
        '.a11y-score-green .a11y-score-value { color: #2e7d32; }' +
        '.a11y-score-orange .a11y-score-value { color: #ef6c00; }' +
        '.a11y-score-red .a11y-score-value { color: #c62828; }' +
        '.a11y-passed { color: #2e7d32; }' +
        '.a11y-failed { color: #c62828; }' +
        '.a11y-best { color: #0277bd; }' +
        '.a11y-section-title { margin: 4px 0 12px; font-size: 16px; font-weight: 600; color: #333; }' +
        '.a11y-table-wrapper { overflow-x: auto; background: #fff; border-radius: 8px; box-shadow: 0 1px 4px rgba(0,0,0,0.08); }' +
        '.a11y-findings-table { width: 100%; border-collapse: collapse; }' +
        '.a11y-findings-table th, .a11y-findings-table td { padding: 10px 12px; text-align: left; border-bottom: 1px solid #eee; vertical-align: top; font-size: 13px; }' +
        '.a11y-findings-table th { background: #f4f6f9; font-weight: 600; color: #444; }' +
        '.a11y-findings-table tr:hover td { background: #fafbfc; }' +
        '.a11y-col-id { text-align: center; width: 80px; }' +
        '.a11y-col-wcag { min-width: 140px; word-break: break-word; white-space: normal; }' +
        '.a11y-element { font-family: "SFMono-Regular", Consolas, monospace; font-size: 12px; word-break: break-all; background: #f4f6f9; padding: 2px 4px; border-radius: 3px; }' +
        '.a11y-status { display: inline-flex; align-items: center; justify-content: center; width: 22px; height: 22px; border-radius: 50%; font-size: 13px; font-weight: 700; line-height: 1; color: #fff; }' +
        '.a11y-status-passed { background: #2e7d32; }' +
        '.a11y-status-failed { background: #c62828; }' +
        '.a11y-status-best { background: #0277bd; }' +
        '.a11y-status-best::before { content: "!"; }' +
        '.a11y-status-passed::before { content: "\\2713"; }' +
        '.a11y-status-failed::before { content: "\\2715"; }' +
        '.a11y-status-passed, .a11y-status-failed, .a11y-status-best { font-family: "Segoe UI Symbol","Apple Symbols",sans-serif; }' +
        '.a11y-node { display: inline-flex; align-items: center; justify-content: center; min-width: 26px; height: 26px; padding: 0 10px; border-radius: 50%; background: #fff; color: #2e7d32; border: 2px solid #2e7d32; font-size: 12px; font-weight: 700; line-height: 1; }' +
        '.a11y-empty-state { padding: 40px; text-align: center; color: #888; }' +
        '.a11y-pager { display: flex; align-items: center; gap: 8px; padding: 12px 8px 4px; flex-wrap: wrap; color: #444; font-size: 13px; }' +
        '.a11y-pager-size { display: inline-flex; align-items: center; gap: 6px; margin-right: auto; }' +
        '.a11y-pager-size select { padding: 4px 6px; border: 1px solid #cfd4dc; border-radius: 4px; background: #fff; color: #333; font-size: 13px; cursor: pointer; }' +
        '.a11y-pager-info { color: #666; margin-right: 4px; }' +
        '.a11y-pager-btn { min-width: 32px; height: 32px; padding: 0 8px; border: 1px solid #cfd4dc; background: #fff; color: #333; border-radius: 4px; cursor: pointer; font-size: 14px; line-height: 1; }' +
        '.a11y-pager-btn:hover:not(:disabled) { background: #f1f4f8; }' +
        '.a11y-pager-btn:disabled { opacity: 0.45; cursor: not-allowed; }' +
        '.a11y-pager-active { background: #066bc9 !important; color: #fff !important; border-color: #066bc9 !important; }' +
        '.a11y-pager-ellipsis { padding: 0 4px; color: #888; }' +
        '.a11y-pager-pages { display: inline-flex; gap: 4px; }' +
        '@media (max-width: 900px) { .a11y-report-summary { grid-template-columns: 1fr 1fr; } }' +
        '@media (max-width: 480px) { .a11y-report-summary { grid-template-columns: 1fr; } }';

    function buildReportHtml(report) {
        var html = '';
        html += '<!DOCTYPE html>';
        html += '<html lang="en">';
        html += '<head>';
        html += '<meta charset="utf-8" />';
        html += '<meta name="viewport" content="width=device-width, initial-scale=1.0" />';
        html += '<title>Accessibility Report</title>';
        html += '<style>' + REPORT_CSS + '</style>';
        html += '</head>';
        html += '<body class="a11y-window-body">';
        html += '  <header class="a11y-window-header">';
        html += '    <h1>Accessibility Report</h1>';
        html += '    <button type="button" class="a11y-window-close" onclick="window.close()" aria-label="Close report">&times;</button>';
        html += '  </header>';
        html += '  <main class="a11y-window-main">';
        html += buildSummarySection(report.summary);
        html += buildFindingsSection(report.findings);
        html += '  </main>';
        html += '  <script>' + PAGER_RUNTIME + '<\/script>';
        html += '</body>';
        html += '</html>';
        return html;
    }

    // ----------------------------------------------------------------
    // Client-side pagination runtime.  These functions are emitted
    // into the report window as a <script> tag and operate on the
    // DOM that buildFindingsSection produced.
    // ----------------------------------------------------------------
    var PAGER_RUNTIME = '' +
        'window.__a11yPagerState = window.__a11yPagerState || {};' +
        'window.__a11yPagerChange = function (id, value) {' +
        '  var p = window.__a11yPagerState[id]; if (!p) return;' +
        '  p.pageSize = parseInt(value, 10);' +
        '  p.current = 1;' +
        '  window.__a11yPagerRender(id);' +
        '};' +
        'window.__a11yPagerPrev = function (id) {' +
        '  var p = window.__a11yPagerState[id]; if (!p) return;' +
        '  if (p.current > 1) { p.current--; window.__a11yPagerRender(id); }' +
        '};' +
        'window.__a11yPagerNext = function (id) {' +
        '  var p = window.__a11yPagerState[id]; if (!p) return;' +
        '  var total = Math.max(1, Math.ceil(p.totalItems / (p.pageSize || p.totalItems)));' +
        '  if (p.current < total) { p.current++; window.__a11yPagerRender(id); }' +
        '};' +
        'window.__a11yPagerGo = function (id, page) {' +
        '  var p = window.__a11yPagerState[id]; if (!p) return;' +
        '  p.current = page; window.__a11yPagerRender(id);' +
        '};' +
        'window.__a11yPagerInit = function (id) {' +
        '  var dataEl = document.querySelector("[data-a11y-findings=\\"" + id + "\\"]");' +
        '  var findings = [];' +
        '  if (dataEl) { try { findings = JSON.parse(dataEl.textContent) || []; } catch (e) { findings = []; } }' +
        '  window.__a11yPagerState[id] = { current: 1, pageSize: Math.min(10, findings.length), totalItems: findings.length, findings: findings };' +
        '  window.__a11yPagerRender(id);' +
        '};' +
        // Auto-init any unfinalized pagers once the DOM is ready.
        'document.addEventListener("DOMContentLoaded", function () {' +
        '  var dataEls = document.querySelectorAll("script[type=\\"application/json\\"][data-a11y-findings]");' +
        '  for (var i = 0; i < dataEls.length; i++) {' +
        '    var id = dataEls[i].getAttribute("data-a11y-findings");' +
        '    if (id && (!window.__a11yPagerState || !window.__a11yPagerState[id])) {' +
        '      window.__a11yPagerInit(id);' +
        '    }' +
        '  }' +
        '});' +
        'window.__a11yPagerRender = function (id) {' +
        '  var p = window.__a11yPagerState[id]; if (!p) return;' +
        '  var tbody = document.querySelector("[data-a11y-tbody=\\"" + id + "\\"]");' +
        '  var pagerEl = document.querySelector("[data-a11y-pager=\\"" + id + "\\"]");' +
        '  if (!tbody || !pagerEl) return;' +
        '  var pageSize = p.pageSize > 0 ? p.pageSize : p.totalItems;' +
        '  var totalPages = Math.max(1, Math.ceil(p.totalItems / pageSize));' +
        '  if (p.current > totalPages) p.current = totalPages;' +
        '  var start = (p.current - 1) * pageSize;' +
        '  var end = Math.min(start + pageSize, p.totalItems);' +
        '  var rows = "";' +
        '  var findings = p.findings;' +
        '  for (var i = start; i < end; i++) {' +
        '    var f = findings[i]; var css = f.status === "Passed" ? "a11y-status-passed" : (f.status === "Failed" ? "a11y-status-failed" : (f.status === "Best Practice" ? "a11y-status-best" : ""));' +
        '    var statusLabel = f.status === "Passed" ? "Pass" : (f.status === "Failed" ? "Fail" : "Info");' +
        '    rows += "<tr>" +' +
        '      "<td class=\\"a11y-col-id\\">" + esc(f.id) + "</td>" +' +
        '      "<td>" + esc(f.description) + "</td>" +' +
        '      "<td>" + esc(f.ruleId) + "</td>" +' +
        '      "<td class=\\"a11y-col-wcag\\">" + esc(f.wcag) + "</td>" +' +
        '      "<td class=\\"a11y-col-id\\"><span class=\\"a11y-node\\" title=\\"" + esc(f.nodes) + " node(s)\\">" + esc(f.nodes) + "</span></td>" +' +
        '      "<td><span class=\\"a11y-status " + css + "\\" role=\\"img\\" aria-label=\\"" + esc(statusLabel) + "\\" title=\\"" + esc(f.status) + "\\"></span></td>" +' +
        '      "<td><code class=\\"a11y-element\\">" + esc(f.element) + "</code></td>" +' +
        '      "</tr>";' +
        '  }' +
        '  tbody.innerHTML = rows;' +
        '  var from = p.totalItems === 0 ? 0 : start + 1;' +
        '  var to = end;' +
        '  var sizes = [10, 25, 50, 100];' +
        '  var sizeOpts = sizes.map(function (s) { return "<option value=\\"" + s + "\\"" + (s === p.pageSize ? " selected" : "") + ">" + s + "</option>"; }).join("");' +
        '  sizeOpts += "<option value=\\"0\\"" + (p.pageSize === 0 ? " selected" : "") + ">All</option>";' +
        '  var pages = computePageRange(p.current, totalPages);' +
        '  var pageBtns = pages.map(function (pg) {' +
        '    if (pg === -1) return "<span class=\\"a11y-pager-ellipsis\\" aria-hidden=\\"true\\">\u2026</span>";' +
        '    var active = pg === p.current ? " a11y-pager-active" : "";' +
        '    var current = pg === p.current ? " aria-current=\\"page\\"" : "";' +
        '    return "<button type=\\"button\\" class=\\"a11y-pager-btn" + active + "\\" onclick=\\"window.__a11yPagerGo(\x27" + id + "\x27, " + pg + ")\\"" + current + ">" + pg + "</button>";' +
        '  }).join("");' +
        '  var prevDisabled = p.current <= 1 ? " disabled" : "";' +
        '  var nextDisabled = p.current >= totalPages ? " disabled" : "";' +
        '  pagerEl.innerHTML =' +
        '    "<div class=\\"a11y-pager\\" role=\\"navigation\\" aria-label=\\"Findings pagination\\">" +' +
        '    "<label class=\\"a11y-pager-size\\"><span>Rows per page</span>" +' +
        '    "<select onchange=\\"window.__a11yPagerChange(\x27" + id + "\x27, this.value)\\">" + sizeOpts + "</select></label>" +' +
        '    "<span class=\\"a11y-pager-info\\">Showing " + from + "\u2013" + to + " of " + p.totalItems + "</span>" +' +
        '    "<button type=\\"button\\" class=\\"a11y-pager-btn\\" onclick=\\"window.__a11yPagerPrev(\x27" + id + "\x27)\\"" + prevDisabled + " aria-label=\\"Previous page\\">\u2039</button>" +' +
        '    "<span class=\\"a11y-pager-pages\\">" + pageBtns + "</span>" +' +
        '    "<button type=\\"button\\" class=\\"a11y-pager-btn\\" onclick=\\"window.__a11yPagerNext(\x27" + id + "\x27)\\"" + nextDisabled + " aria-label=\\"Next page\\">\u203a</button>" +' +
        '    "</div>";' +
        '};' +
        'function esc(v) {' +
        '  if (v === null || v === undefined) return "";' +
        '  return String(v).replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;").replace(/"/g, "&quot;").replace(/\'/g, "&#39;");' +
        '}' +
        'function computePageRange(current, totalPages) {' +
        '  if (totalPages <= 7) { var all = []; for (var i = 1; i <= totalPages; i++) all.push(i); return all; }' +
        '  var range = [1];' +
        '  var start = Math.max(2, current - 1);' +
        '  var end = Math.min(totalPages - 1, current + 1);' +
        '  if (start > 2) range.push(-1);' +
        '  for (var s = start; s <= end; s++) range.push(s);' +
        '  if (end < totalPages - 1) range.push(-1);' +
        '  range.push(totalPages);' +
        '  return range;' +
        '}';

    var lastSummary = {
        score: 0,
        passedRules: 0,
        failedRules: 0,
        bestPractices: 0,
        hasRun: false,
        targetUrl: null
    };

    function captureSummary(report) {
        lastSummary = {
            score: report && report.summary ? report.summary.score : 0,
            passedRules: report && report.summary ? report.summary.passedRules : 0,
            failedRules: report && report.summary ? report.summary.failedRules : 0,
            bestPractices: report && report.summary ? report.summary.bestPractices : 0,
            hasRun: true,
            targetUrl: report && report.targetUrl ? report.targetUrl : currentTargetUrl()
        };
        // Broadcast to anything listening (the WCAG badge is the
        // primary consumer) so the tooltip task-summary can refresh
        // without the badge having to poll the global.
        try {
            if (typeof global.CustomEvent === 'function') {
                global.dispatchEvent(new global.CustomEvent('accessibility:summary-updated', {
                    detail: Object.assign({}, lastSummary)
                }));
            } else if (typeof global.document !== 'undefined' && global.document.createEvent) {
                var ev = global.document.createEvent('CustomEvent');
                ev.initCustomEvent('accessibility:summary-updated', false, false, Object.assign({}, lastSummary));
                global.dispatchEvent(ev);
            }
            if (summarySubscribers && summarySubscribers.length) {
                for (var i = 0; i < summarySubscribers.length; i++) {
                    try {
                        summarySubscribers[i]
                            .invokeMethodAsync('OnSummaryUpdated')
                            .catch(err => console.error("OnSummaryUpdated failed", err));
                    } catch (e) {
                        // Ignore stale subscribers; they will be GC'd
                        // when Blazor disposes their owning component.
                    }
                }
            }
        } catch (e) {
            // Broadcast failure must not break the scan / capture path.
        }
    }

    // Returns the URL currently displayed in the right pane if we
    // can resolve it; otherwise the document location href.
    function currentTargetUrl() {
        try {
            var demo = document.querySelector('.sb-demo-section');
            if (demo) {
                return global.location ? global.location.pathname + global.location.search : '';
            }
        } catch (e) {
            /* ignore */
        }
        return global.location ? global.location.pathname + global.location.search : '';
    }

    // Marks the cached summary as stale.  Callers use this when they
    // start a fresh scan so consumers (the WCAG badge tooltip) know
    // to drop the previous sample's metrics until the new scan
    // commits.
    function beginScan() {
        lastSummary = Object.assign({}, lastSummary, {
            hasRun: false
        });
        // Re-broadcast the same custom event so the badge drops its
        // pill immediately even if no fresh data has landed yet.
        try {
            if (typeof global.CustomEvent === 'function') {
                global.dispatchEvent(new global.CustomEvent('accessibility:summary-updated', {
                    detail: Object.assign({}, lastSummary)
                }));
            }
            if (summarySubscribers && summarySubscribers.length) {
                for (var i = 0; i < summarySubscribers.length; i++) {
                    try {
                        summarySubscribers[i]
                            .invokeMethodAsync('OnSummaryUpdated')
                            .catch(console.error);
                    } catch (e) {
                        /* ignore */
                    }
                }
            }
        } catch (e) {
            /* ignore */
        }
    }

    // Returns a frozen snapshot of the last axe scan.  Components that
    // want to label UI (for instance the tooltip on the WCAG badge)
    // call this instead of re-running the scan.  If no scan has run in
    // this session `hasRun` is false and the caller should fall back to
    // its placeholder copy rather than presenting misleading zeros.
    function getLastSummary() {
        return Object.assign({}, lastSummary);
    }

    // Subscribers receive a callback invocation every time captureSummary
    // commits a fresh scan. Blazor uses DotNetObjectReference.Create so
    // the same module-level list works across every badge instance.
    var summarySubscribers = [];

   function subscribeSummary(dotnetRef) {

    if (!dotnetRef) {
        console.log("dotnetRef null");
        return;
    }
    summarySubscribers.push(dotnetRef);
    try {
        dotnetRef.invokeMethodAsync("OnSummaryUpdated")
            .then(() => console.log("callback success"))
            .catch(err => console.error("callback failed", err));
    }
    catch (e) {
        console.error(e);
    }
}

    // Maximum time the auto-scan helper will wait for the demo DOM to
    // settle.  Most samples render synchronously once Syncfusion
    // component scripts finish loading, but a small grace window keeps
    // the helper resilient to component-level RAF/SfTab animations
    // that may add nodes immediately after first paint.
    var DEFAULT_SCAN_READY_TIMEOUT_MS = 1500;
    var pendingAutoScans = [];

    // Trigger an axe scan once the supplied selector appears in the
    // DOM, or after the readiness timeout elapses - whichever comes
    // first.  The scan never opens a report window; it only refreshes
    // the cached summary.  We retry the scan until axe-core is fully
    // loaded - on first sample paint the script may not be in cache
    // yet, and we do not want the scan to silently fail.
    function scheduleScanWhenReady(selector, timeoutMs) {
        if (!selector || typeof document.querySelector !== 'function') return;
        var ready = document.querySelector(selector);
        // Mark the previously cached summary as stale so the tooltip
        // pill disappears immediately while we wait for the fresh
        // scan to land.
        beginScan();

        // First scan attempt - if the demo DOM is not in place yet
        // we wait via DOM observer + poll + hard timeout.
        if (!ready) {
            queueScanWhenReady(selector, timeoutMs, /* attempt */ 0);
            return;
        }
        queueScanWhenReady(selector, timeoutMs, /* attempt */ 0);
    }

    function queueScanWhenReady(selector, timeoutMs, attempt) {
        var guard = typeof timeoutMs === 'number' && timeoutMs > 0
            ? timeoutMs
            : DEFAULT_SCAN_READY_TIMEOUT_MS;
        var token = pendingAutoScans.length + 1;
        pendingAutoScans.push(token);
        var pollTimer = null;
        var hardTimer = null;
        var observer = null;

        function cancel() {
            if (pollTimer) clearInterval(pollTimer);
            if (hardTimer) clearTimeout(hardTimer);
            if (observer) { try { observer.disconnect(); } catch (e) { /* ignore */ } }
            pollTimer = null;
            hardTimer = null;
            observer = null;
            var idx = pendingAutoScans.indexOf(token);
            if (idx !== -1) pendingAutoScans.splice(idx, 1);
        }

        function fire() {
            cancel();
            runScanSilentlyWithRetry(selector, attempt);
        }

        hardTimer = setTimeout(function () { fire(); }, guard);

        pollTimer = setInterval(function () {
            if (!document.querySelector(selector)) return;
            fire();
        }, 50);

        try {
            observer = new MutationObserver(function () {
                if (!document.querySelector(selector)) return;
                fire();
            });
            observer.observe(document.documentElement, { childList: true, subtree: true });
            setTimeout(function () { try { observer.disconnect(); } catch (e) { /* ignore */ } }, guard + 250);
        } catch (e) {
            // MutationObserver unavailable
        }
    }

    // Runs the scan but retries if axe-core has not finished loading
    // yet.  This is the key fix for "report details not shown on
    // initialization" - the previous implementation fired the scan
    // exactly once and silently dropped the result when loadAxe()
    // had not yet resolved.
    function runScanSilentlyWithRetry(selector, attempt) {
        attempt = typeof attempt === 'number' ? attempt : 0;
        var maxAttempts = 6;
        var delayMs = 250;
        runScanSilently()
            .then(function (ok) {
                if (ok) return;
                if (attempt >= maxAttempts) return;
                // Axe-core is probably still loading - schedule a
                // poll that retries the scan as soon as it becomes
                // available.  We use exponential back-off to avoid a
                // hot loop.
                setTimeout(function () {
                    if (!document.querySelector(selector)) return;
                    runScanSilentlyWithRetry(selector, attempt + 1);
                }, delayMs * (attempt + 1));
            })
            .catch(function () {
                if (attempt >= maxAttempts) return;
                setTimeout(function () {
                    runScanSilentlyWithRetry(selector, attempt + 1);
                }, delayMs * (attempt + 1));
            });
    }

    // Like runScan() but only updates the cached summary; never opens
    // a report window.  Used by the "auto scan on sample load" hook.
    function runScanSilently() {
        return runScan()
            .then(function (json) {
                var scan = JSON.parse(json);
                var report = buildReportModel(scan);
                captureSummary(report);
                return true;
            })
            .catch(function () {
                return false;
            });
    }

    function runAndOpenReport() {
        // Synchronously open the report window first so the call is
        // treated as a user-initiated gesture (browsers otherwise
        // block popups from async chains).
        var win = openReportWindow(null);
        return runScan()
            .then(function (json) {
                var scan = JSON.parse(json);
                var report = buildReportModel(scan);
                captureSummary(report);
                var html = buildReportHtml(report);
                writeReportToWindow(win, html);
                return true;
            })
            .catch(function (err) {
                var errorReport = {
                    summary: { score: 0, passedRules: 0, failedRules: 0, bestPractices: 0 },
                    findings: [{
                        id: 1,
                        ruleId: 'scan-error',
                        description: 'The accessibility scan could not be completed. ' + (err && err.message ? err.message : err),
                        element: '',
                        wcag: '',
                        nodes: 0,
                        status: 'Failed'
                    }]
                };
                captureSummary(errorReport);
                writeReportToWindow(win, buildReportHtml(errorReport));
                return false;
            });
    }

    function openReportWindow(html) {
        // Pop a new tab synchronously so the popup is registered
        // within the user gesture.  Returns the window handle (or
        // null if popups are blocked - the caller handles that).
        var win = global.open('', '_blank');
        if (!win) {
            // Fallback: when blocked, append a placeholder so we can
            // pick it up later.  This handles the popup-blocked case
            // and is the easiest path for tests.
            return null;
        }
        // If the caller already supplied full HTML, write it now.
        if (html) {
            try {
                win.document.open();
                win.document.write(html);
                win.document.close();
            } catch (e) {
                /* If the new window blocks writes (cross-origin edge
                 * cases), discard it - the caller will retry inline. */
                try { win.close(); } catch (_) { /* ignore */ }
                return null;
            }
        }
        return win;
    }

    // Writes the report HTML into a previously-opened window, falling
    // back to the inline container when popups are blocked.
    function writeReportToWindow(win, html) {
        if (win) {
            try {
                win.document.open();
                win.document.write(html);
                win.document.close();
                return true;
            } catch (e) {
                try { win.close(); } catch (_) { /* ignore */ }
            }
        }
        // Inline fallback: render the report inside the current page
        // so the user still has access to the data.
        var container = document.createElement('div');
        container.className = 'a11y-inline-report';
        container.innerHTML = html;
        document.body.appendChild(container);
        return false;
    }

    global.blazorAccessibility = {
        runScan: runScan,
        loadAxe: function () { return loadAxe(); },
        runAndOpenReport: runAndOpenReport,
        openReportWindow: openReportWindow,
        getLastSummary: getLastSummary,
        scheduleScanWhenReady: scheduleScanWhenReady,
        subscribeSummary: subscribeSummary
    };
})(window);
