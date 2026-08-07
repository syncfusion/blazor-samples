// Initialize the speechSynthesisInterop object to store speech-related data if it doesn't exist.
window.speechSynthesisInterop = window.speechSynthesisInterop || {};

// Converts HTML content to plain text by stripping HTML tags.
function extractTextFromHtml(html) {
    const tempDiv = document.createElement('div');
    tempDiv.innerHTML = html;
    return (tempDiv.textContent || tempDiv.innerText || '').trim();
}

// Initiates text-to-speech synthesis to read the provided text aloud.
function speak(text, dotNetRef) {
    // Check if the browser supports the Web Speech API
    if ('speechSynthesis' in window) {
        // Create a new speech synthesis utterance with the provided text
        const utterance = new SpeechSynthesisUtterance(text);
        // Call the Blazor OnSpeechEnd method when speech ends
        utterance.onend = () => {
            dotNetRef.invokeMethodAsync('OnSpeechEnd');
        };
        utterance.onerror = (event) => {
            dotNetRef.invokeMethodAsync('OnSpeechEnd');
        };
        // Start speaking the utterance
        window.speechSynthesis.speak(utterance);
        // Store the utterance in the global interop object for cancellation
        window.speechSynthesisInterop.currentUtterance = utterance;
        return Promise.resolve(true);
    } else {
        return Promise.resolve(false);
    }
}

// Cancels any ongoing speech synthesis.
function cancel() {
    if ('speechSynthesis' in window) {
        // Stop any active speech synthesis
        window.speechSynthesis.cancel();
        // Clear the stored utterance reference
        window.speechSynthesisInterop.currentUtterance = null;
    }
}