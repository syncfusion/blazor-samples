//function onLoad() {
//    if (document.getElementById('pivotfieldlist')) {
//        var fieldlistObj = document.getElementById('pivotfieldlist').ej2_instances[0];
//        if (fieldlistObj) {
//            if (ej.base.Browser.isDevice) {
//                fieldlistObj.renderMode = 'Popup';
//                fieldlistObj.target = '.control-section';
//                ej.base.setStyleAttribute(document.getElementById('pivotfieldlist'), {
//                    'width': 0,
//                    'height': 0,
//                    'float': 'left',
//                    'display': 'none'
//                });
//            }
//        }
//    }
//}
function onGridEnginePopulate() {
    if (!ej.base.Browser.isDevice) {
        var pivotGridObj = document.getElementById('pivotview').ej2_instances[0];
        var fieldlistObj = document.getElementById('pivotfieldlist').ej2_instances[0];
        if (fieldlistObj) {
            fieldlistObj.update(pivotGridObj);
        }
    }
}
function onFieldListEnginePopulate() {
    if (document.getElementById('pivotview')) {
        var pivotGridObj = document.getElementById('pivotview').ej2_instances[0];
        var fieldlistObj = document.getElementById('pivotfieldlist').ej2_instances[0];
        fieldlistObj.updateView(pivotGridObj);
    }
}
function onAfterRender() {
    var pivotGridObj = document.getElementById('pivotview').ej2_instances[0];
    var fieldlistObj = document.getElementById('pivotfieldlist').ej2_instances[0];
    if (fieldlistObj) {
        fieldlistObj.updateView(pivotGridObj);
        fieldlistObj.update(pivotGridObj);
    }
    fieldlistObj.enginePopulated = onFieldListEnginePopulate.bind(this);
    pivotGridObj.enginePopulated = onGridEnginePopulate.bind(this);
    if (ej.base.Browser.isDevice) {
        pivotGridObj.element.style.width = "100%";
        pivotGridObj.allowCalculatedField = true;
        pivotGridObj.showFieldList = true;
    }
    if (pivotGridObj.dataSource.data) {
        pivotGridObj.refresh();
    }
}
//function onDataBound() {
//    if (document.getElementById('pivotview')) {
//        var pivotGridObj = document.getElementById('pivotview').ej2_instances[0];
//        var fieldlistObj = document.getElementById('pivotfieldlist').ej2_instances[0];
//        //pivotGridObj.tooltip.destroy();
//        if (ej.base.Browser.isDevice) {
//            pivotGridObj.element.style.width = "100%";
//            pivotGridObj.allowCalculatedField = true;
//            pivotGridObj.showFieldList = true;
//        }
//        if (pivotGridObj.dataSource.data) {
//            pivotGridObj.refresh();
//        }
//    }
//}


function trend() {
    var pivotGridObj = document.getElementById('pivotview').ej2_instances[0];
    var cTable = document.getElementsByClassName("e-table");
    var colLen = pivotGridObj.pivotValues[3].length;
    var cLen = cTable[3].children[0].children.length;
    var rLen = cTable[3].children[1].children.length;

    for (let k = 0; k < rLen; k++) {
        if (pivotGridObj.pivotValues[k] && pivotGridObj.pivotValues[k][0] !== undefined) {
            rowIndx = (pivotGridObj.pivotValues[k][0]).rowIndex;
            break;
        }
    }
    var rowHeaders = [].slice.call(cTable[2].children[1].querySelectorAll('td'));
    var rows = pivotGridObj.dataSource.rows;
    if (rowHeaders.length > 1) {
        for (var i = 0, Cnt = rows; i < Cnt.length; i++) {
            var fields = {};
            var fieldHeaders = [];
            for (var j = 0, Lnt = rowHeaders; j < Lnt.length; j++) {
                var header = rowHeaders[j];
                if (header.className.indexOf('e-gtot') === -1 && header.className.indexOf('e-rowsheader') > -1 && header.getAttribute('fieldname') === rows[i].name) {
                    var headerName = rowHeaders[j].getAttribute('fieldname') + '_' + rowHeaders[j].textContent;
                    fields[rowHeaders[j].textContent] = j;
                    fieldHeaders.push(rowHeaders[j].textContent);
                }
            }
            if (i === 0) {
                for (var rnt = 0, Lnt = fieldHeaders; rnt < Lnt.length; rnt++) {
                    if (rnt !== 0) {
                        var row = fields[fieldHeaders[rnt]];
                        var prevRow = fields[fieldHeaders[rnt - 1]];
                        for (var j = 0, ci = 1; j < cLen && ci < colLen; j++ , ci++) {
                            if (!cTable[3].children[1].children[row]) {
                                break;
                            }
                            var node = cTable[3].children[1].children[row].childNodes[j];
                            var prevNode = cTable[3].children[1].children[prevRow].childNodes[j];
                            var ri = undefined;
                            var prevRi = undefined;
                            if (node) {
                                ri = node.getAttribute('index');
                            }
                            if (prevNode) {
                                prevRi = prevNode.getAttribute('index');
                            }
                            if (ri && ri < pivotGridObj.pivotValues.length) {
                                if ((pivotGridObj.pivotValues[prevRi][ci]).value > (pivotGridObj.pivotValues[ri][ci]).value && node.querySelector('.tempwrap')) {
                                    var trendElement = node.querySelector('.tempwrap');
                                    trendElement.className = trendElement.className.replace('sb-icon-neutral', 'sb-icon-loss');
                                } else if ((pivotGridObj.pivotValues[prevRi][ci]).value < (pivotGridObj.pivotValues[ri][ci]).value && node.querySelector('.tempwrap')) {
                                    var trendElement = node.querySelector('.tempwrap');
                                    trendElement.className = trendElement.className.replace('sb-icon-neutral', 'sb-icon-profit');
                                }
                            }
                        }
                    }
                }
            } else {
                for (var rnt = 0, Lnt = fieldHeaders; rnt < Lnt.length; rnt++) {
                    var row = fields[fieldHeaders[rnt]];
                    for (var j = 0, ci = 1; j < cLen && ci < colLen; j++ , ci++) {
                        if (!cTable[3].children[1].children[row]) {
                            break;
                        }
                        var node = cTable[3].children[1].children[row].childNodes[j];
                        var prevNode = cTable[3].children[1].children[row - 1].childNodes[j];
                        var ri = undefined;
                        var prevRi = undefined;
                        if (node) {
                            ri = node.getAttribute('index');
                        }
                        if (prevNode) {
                            prevRi = prevNode.getAttribute('index');
                        }
                        if (ri && ri < pivotGridObj.pivotValues.length) {
                            var cRowFieldName = cTable[2].children[1].children[row].childNodes[0].getAttribute('fieldname');
                            var prevRowFieldName = cTable[2].children[1].children[row - 1].childNodes[0].getAttribute('fieldname');
                            if ((pivotGridObj.pivotValues[prevRi][ci]).value > (pivotGridObj.pivotValues[ri][ci]).value && node.querySelector('.tempwrap') &&
                                cRowFieldName === prevRowFieldName) {
                                var trendElement = node.querySelector('.tempwrap');
                                trendElement.className = trendElement.className.replace('sb-icon-neutral', 'sb-icon-loss');
                            } else if ((pivotGridObj.pivotValues[prevRi][ci]).value < (pivotGridObj.pivotValues[ri][ci]).value && node.querySelector('.tempwrap') &&
                                cRowFieldName === prevRowFieldName) {
                                var trendElement = node.querySelector('.tempwrap');
                                trendElement.className = trendElement.className.replace('sb-icon-neutral', 'sb-icon-profit');
                            }
                        }
                    }
                }
            }
        }
    }
}
