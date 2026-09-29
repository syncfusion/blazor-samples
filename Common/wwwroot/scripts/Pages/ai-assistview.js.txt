window.toggleGeminiButtons = function (hasPrompt) {
    setTimeout(() => {
        const sendBtn = document.querySelector('.e-footer .e-assist-send')?.closest('.e-btn');
        const audioBtn = document.querySelector('.e-assistview-speech-to-text');
        if (hasPrompt) {
            if (sendBtn) sendBtn.style.display = 'flex';
            if (audioBtn) audioBtn.style.display = 'none';
        }
        else {
            if (sendBtn) sendBtn.style.display = 'none';
            if (audioBtn) audioBtn.style.display = 'flex';
        }
    }, 50);
};