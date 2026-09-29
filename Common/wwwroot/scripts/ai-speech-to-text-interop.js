window.initSpeechToTextAssistant = function(dotNetRef) {
    var isPopupOpen = false;
    var isAccepted = false;
    var originalContentHTML = '';
    var savedRange = null;
    var selectedSpan = null;
    var originalSpanHTML = '';
    var targetContent = document.getElementById('targetContent');
    if (!targetContent) {
        return;
    }
    targetContent.addEventListener('mouseup', function() {
        if (saveSelection()) {
            var selection = window.getSelection();
            var range = selection && selection.rangeCount ? selection.getRangeAt(0) : null;
            if (range && !range.collapsed) {
                originalContentHTML = targetContent.innerHTML;
            var oldSelection = document.getElementById('inline-ai-selected-text');
            if (oldSelection) {
                oldSelection.removeAttribute('id');
            }
            var wrapper = document.createElement('span');
            wrapper.className = 'e-inlineaiassist-selected-text';
            wrapper.id = 'inline-ai-selected-text';
            var selectedContent = range.extractContents();
            wrapper.appendChild(selectedContent);
            range.insertNode(wrapper);
            selectedSpan = wrapper;
            originalSpanHTML = wrapper.innerHTML;
            savedRange = document.createRange();
            savedRange.selectNodeContents(selectedSpan);
            isPopupOpen = true;
            dotNetRef.invokeMethodAsync('SelectionElementReady', '#inline-ai-selected-text');
            }
        }
    });
    targetContent.addEventListener('keyup', function() {
        if (saveSelection() && isPopupOpen) {
        }
    });

    function saveSelection() {
        var selection = window.getSelection();
        if (selection.rangeCount > 0 && !selection.isCollapsed) {
            savedRange = selection.getRangeAt(0).cloneRange();
            return true;
        }
        return false;
    }

    function createFragmentFromHTML(html) {
        var tempDiv = document.createElement('div');
        tempDiv.innerHTML = html || '';
        var fragment = document.createDocumentFragment();
        while (tempDiv.firstChild) {
            fragment.appendChild(tempDiv.firstChild);
        }
        return fragment;
    }

    function restoreOriginalSpan() {
        if (!selectedSpan || !selectedSpan.parentNode) {
            return;
        }
        var parent = selectedSpan.parentNode;
        var fragment = createFragmentFromHTML(originalSpanHTML);
        parent.replaceChild(fragment, selectedSpan);
        selectedSpan = null;
        originalSpanHTML = '';
    }

    function getSelectedText() {
        return savedRange ? savedRange.toString() : '';
    }

    window.getSelectedTextContent = function() {
        return getSelectedText();
    };

    function getPlainText(response) {
        var temp = document.createElement('div');
        temp.innerHTML = response || '';
        return temp.textContent || '';
    }

    function unwrapSelectedSpan() {
        if (!selectedSpan || !selectedSpan.parentNode) {
            return;
        }
        var parent = selectedSpan.parentNode;
        var textNode = document.createTextNode(selectedSpan.textContent || '');
        parent.replaceChild(textNode, selectedSpan);
        selectedSpan = null;
        originalSpanHTML = '';
    }

    window.previewAIResponse = function(response) {
        if (selectedSpan && selectedSpan.parentNode) {
            selectedSpan.textContent = getPlainText(response);
        }
    };

    window.acceptAIResponse = function(response) {
        isAccepted = true;
        if (selectedSpan && selectedSpan.parentNode) {
            selectedSpan.textContent = getPlainText(response);
            unwrapSelectedSpan();
        }
        selectedSpan = null;
        savedRange = null;
        originalContentHTML = '';
        isPopupOpen = false;
        window.getSelection().removeAllRanges();
    };

    window.discardAIResponse = function() {
        isAccepted = false;
        if (originalContentHTML) {
            targetContent.innerHTML = originalContentHTML;
        }
        selectedSpan = null;
        originalSpanHTML = '';
        savedRange = null;
        originalContentHTML = '';
        isPopupOpen = false;
        window.getSelection().removeAllRanges();
    };

    window.cleanupSelection = function() {
        if (!isAccepted && originalContentHTML) {
            targetContent.innerHTML = originalContentHTML;
        }
        var oldSelection = document.getElementById('inline-ai-selected-text');
        if (oldSelection) {
            oldSelection.removeAttribute('id');
        }
        selectedSpan = null;
        originalSpanHTML = '';
        savedRange = null;
        originalContentHTML = '';
        isAccepted = false;
        isPopupOpen = false;
        window.getSelection().removeAllRanges();
    };
};