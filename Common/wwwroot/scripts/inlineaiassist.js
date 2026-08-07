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