window.initEmailParagraphHover = (dotNetRef, emailContentId, sparkleBtnId) => {
    const container = document.getElementById(emailContentId);
    if (!container) return;

    const sparkle = document.getElementById(sparkleBtnId);

    const attach = (el) => {
        if (!el || el.nodeType !== 1 || el.tagName === "BUTTON" || el.hasAttribute('data-para-id')) {
            return;
        }
        const id = 'para-' + Math.random().toString(36).substring(2, 10);
        el.setAttribute('data-para-id', id);
        el.setAttribute('contenteditable', 'true');
        el.spellcheck = true;

        el.addEventListener('mouseenter', () => {
            if (window.isPopupOpen) return;

            const rect = el.getBoundingClientRect();
            const contRect = container.getBoundingClientRect();
            const topPos = (rect.top - contRect.top) + (rect.height / 2) - 16;
            const selector = `[data-para-id="${id}"]`;
            dotNetRef.invokeMethodAsync('OnParagraphHover', selector, topPos);
        });
    };

    Array.from(container.children).forEach(attach);
    new MutationObserver((mutations) => {
        mutations.forEach(mutation => {
            mutation.addedNodes.forEach(node => {
                attach(node);
            });
        });
    }).observe(container, { childList: true });

    // Sparkle button events
    if (sparkle) {
        sparkle.addEventListener('mouseenter', () => {
            sparkle.style.display = 'block';
        });

        sparkle.addEventListener('mouseleave', () => {
            if (!window.isPopupOpen) sparkle.style.display = 'none';
        });
    }
    container.addEventListener('mouseleave', (e) => {
        if (sparkle && !sparkle.matches(':hover') && !window.isPopupOpen) {
            sparkle.style.display = 'none';
            if (dotNetRef) dotNetRef.invokeMethodAsync('OnEmailBodyLeave');
        }
    });
    container.addEventListener('input', () => {
        if (sparkle && !window.isPopupOpen) {
            sparkle.style.display = 'none';
        }
    });
};

// Re-attach after reset
window.reattachParagraphHover = (dotNetRef, emailContentId, sparkleBtnId) => {
    const container = document.getElementById(emailContentId);
    if (container) {
        Array.from(container.querySelectorAll('[data-para-id]')).forEach(el => {
            el.removeAttribute('data-para-id');
        });
    }
    window.initEmailParagraphHover(dotNetRef, emailContentId, sparkleBtnId);
};

window.setPopupState = (open) => {
    window.isPopupOpen = open;
};

window.getElementInnerText = (selector) => {
    const el = document.querySelector(selector);
    return el ? el.innerText : '';
};

window.updateParagraphContent = (selector, newContent) => {
    const el = document.querySelector(selector);
    if (el) el.innerHTML = newContent;
};
window.aiAssistRteInterop = {
    dotnetRef: null,
    selectedText: '',
    selectedSpan: null,
    currentRange: null,
    relateToElement: null,
    originalFragment: null,
    initialize(dotnetRef) {
        this.dotnetRef = dotnetRef;
        this.registerOutsideClick(dotnetRef);
    },
    unwrapOrReplaceSpan(html, selectionId, replacement) {
    if (!html || !selectionId) {
        return html;
    }
    const escapedSelectionId = selectionId.replace(/[.*+?^${}()|[\]\\]/g, '\\$&');
    const regex = new RegExp(
        '<span\\b[^>]*\\bclass\\s*=\\s*"e-inlineaiassist-selected-text"[^>]*\\bdata-aiassist-selection\\s*=\\s*"?'
        + escapedSelectionId +
        '[^>]*>.*?<\\/span>',
        'is'
    );
    return html.replace(regex, replacement || '');
    },
    unwrapHighlightSpanWithOriginal(html, selectionId, originalContent) {
    return this.unwrapOrReplaceSpan(html, selectionId, originalContent);
    },
    stripParagraphTag(html, paragraphId) {
    if (!html || !paragraphId) {
        return html;
    }
    const escapedParagraphId = paragraphId.replace(/[.*+?^${}()|[\]\\]/g, '\\$&');
    const regex = new RegExp(
        '\\s+data-aiassist-paragraph="' +
        escapedParagraphId +
        '"',
        'i'
    );
    return html.replace(regex, '');
    },
    getSelectedText() {
    if (this.selectedSpan) {
        return this.selectedSpan.innerText;
    }
    const selection =
        window.getSelection();
    return selection
        ? selection.toString()
        : '';
    },
    highlightCurrentSelection() {
    const selection = window.getSelection();
    if (!selection ||
        selection.rangeCount === 0 ||
        selection.isCollapsed) {
        return false;
    }
    const range =
        selection.getRangeAt(0);
    if (
        range.commonAncestorContainer
            .parentElement
            ?.closest('.e-inlineaiassist-selected-text')
    ) {
        return true;
    }
    try {
        const wrapper = document.createElement('span');
        wrapper.className = 'e-inlineaiassist-selected-text';
        wrapper.id = 'aiassist-selection-' + Date.now();
        const selection = window.getSelection();
        const selectedContent = range.extractContents();
            this.originalFragment =selectedContent.cloneNode(true);
        wrapper.appendChild(selectedContent);
        range.insertNode(wrapper);
        this.selectedSpan = wrapper;
        this.selectedText = wrapper.innerText;
        selection.removeAllRanges();
        const newRange = document.createRange();
        newRange.selectNodeContents(wrapper);
        selection.addRange(newRange);
        this.currentRange = newRange;
        return true;
    }
    catch(e) {
        console.error(e);
        return false;
    }
    },
    closePopupCleanup() {
    this.selectedText = '';
    this.currentRange = null;
    this.relateToElement = null;
    this.selectedSpan = null;
    this.originalFragment = null;
    const selection = window.getSelection();
    if(selection) {
        selection.removeAllRanges();
    }
    },
    getWrappedText() {
    if (this.selectedSpan) {
        return this.selectedSpan.innerText;
    }
    return '';
    }, 
    updateSelectionText(text) {
    if (!this.selectedSpan)
        return;
    this.selectedSpan.innerText = text;
    const selection = window.getSelection();
    selection.removeAllRanges();
    const range = document.createRange();
    range.selectNodeContents(this.selectedSpan);
    selection.addRange(range);
    setTimeout(() => {
        const popup = document.querySelector('.e-inline-ai-assist');
        if (popup) {
            popup.style.visibility = 'visible';
        }
    }, 10);
    },
   getPopupTarget() {
   if (this.selectedSpan) {
        return "#" + this.selectedSpan.id;
    }
    return null;
    },
    acceptResponse() {
    if (!this.selectedSpan || !this.selectedSpan.parentNode) {
    window.getSelection()?.removeAllRanges();
        this.closePopupCleanup();
        return;
    }
    const parent = this.selectedSpan.parentNode;
    const textNode = document.createTextNode(this.selectedSpan.innerText);
    parent.replaceChild(textNode,this.selectedSpan);
    const rteContent = document.querySelector('.e-rte-content');
    if (rteContent) {
    rteContent.dispatchEvent(
        new Event('input',{ bubbles: true })
    );
    }
    this.closePopupCleanup();
    },
    discardResponse() {
    if (!this.selectedSpan || !this.selectedSpan.parentNode) {
        this.closePopupCleanup();
        return;
    }
    const parent = this.selectedSpan.parentNode;
    parent.replaceChild(this.originalFragment.cloneNode(true),this.selectedSpan);
    const rteContent = document.querySelector('.e-rte-content');
    if (rteContent) { rteContent.dispatchEvent(new Event('input',{ bubbles: true }));
    }
    this.closePopupCleanup();
    },
    clearSelection() {
        const sel = window.getSelection();
        if (sel)
            sel.removeAllRanges();
    },
    registerOutsideClick(dotnetRef) {
    document.addEventListener('mousedown', (e) => {
        if (!this.selectedSpan) {
            return;
        }
        const target = e.target;
        const insideAiAssist =
            target.closest('.e-inline-ai-assist') ||
            target.closest('.e-popup') ||
            target.closest('.e-dialog');
        const insideSelection =
            target.closest('.e-inlineaiassist-selected-text');
        if (insideAiAssist || insideSelection) {
            return;
        }
        dotnetRef
            .invokeMethodAsync('OnOutsideClick')
            .catch(() => {});
    });
}
};