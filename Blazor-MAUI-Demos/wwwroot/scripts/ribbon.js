function bindRibbonPlaceHolderClick(dotNetHelper) {
    document.getElementById('ribbonPlaceHolder').addEventListener('click', function (event) {
        const targetNodeName = event.target.nodeName;
        dotNetHelper.invokeMethodAsync('HandleRibbonPlaceHolderClick', targetNodeName);
    });
}
