function saveAsFile(data) {
    if (window.navigator.msSaveBlob) {
        let blob = new Blob([data], { type: 'data:text/json;charset=utf-8,' });
        window.navigator.msSaveOrOpenBlob(blob, 'Diagram.json');
    } else {
        let dataStr = 'data:text/json;charset=utf-8,' + encodeURIComponent(data);
        let a = document.createElement('a');
        a.href = dataStr;
        a.download = 'Diagram.json';
        document.body.appendChild(a);
        a.click();
        a.remove();
    }
}

function setWaterLevel(value) {
    var slider = document.getElementById('slider')
    var percent = slider.value;
    document.getElementById('node1_content_linear').children[0].setAttribute("offset", percent + '%');
    document.getElementById('node1_content_linear').children[1].setAttribute("offset", percent + '%');
}

function click() {
    document.getElementById('UploadFiles').click();
}
function loadFile(file) {
 //   var blob = new File(file);

    var base64 = file.rawFile.replace("data:application/json;base64,", "");
    var json = atob(base64)
    return json;
}

function loadDiagram(event) {
    return event.target.result.toString();
}