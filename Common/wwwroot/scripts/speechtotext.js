function isFooterContainsValue(elementref) {
    // Remove <br>
    if (!elementref.innerText.trim() !== '') {
        if ((elementref.innerHTML === '<br>' || elementref.innerHTML.trim() === '')) {
            elementref.innerHTML = '';
        }
    }
    return elementref.innerText || "";
}
function emptyFooterValue(elementref) {
    if (elementref) {
        elementref.innerText = "";
    }
}
function updateContentEditableDiv(element, value) {
    if (element) {
        element.innerText = value;
    }
};