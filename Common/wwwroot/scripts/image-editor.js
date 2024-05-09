﻿﻿﻿﻿window.canvasInterop = {
    imgSrc: "",
    onInitialized: function () {
        document.getElementById('img-upload').onchange = function (args) {
            const URL = window.URL; const url = URL.createObjectURL((args.target).files[0]);
            (document.getElementById('img-upload')).value = null;
            canvasInterop.imgSrc = url.toString();
            return window.objRef.invokeMethodAsync('FileSelected', url.toString());
        };
        return true;
    },
    getImageSource: function () {
        var img = document.querySelector('#custom-img'); // Add
        return img.src;
    },
    imageLoaded: function (objRef) {
        window.objRef = objRef;
        if (canvasInterop.imgSrc === '') {
            let canvas = document.querySelector('#img-canvas');
            let image = document.querySelector('#custom-img');
            let ctx = canvas.getContext('2d');
            canvas.width = image.width < image.height ? image.width : image.height;
            canvas.height = canvas.width;
            ctx.drawImage(image, 0, 0, canvas.width, canvas.height);
            document.querySelector('.e-profile').classList.remove('e-hide');
        }
        return true;
    },
    fileSelect: function () {
        var inputFile = document.getElementById('img-upload');
        inputFile.click();
        return true;
    },
    applyImage: function (a) {
        var dataId = document.querySelector('.e-image-editor').getAttribute('dataId');
        var inst = window.sfBlazor.getCompInstance(dataId);
        var croppedData = inst.getImageData();
        var canvas = document.querySelector('#img-canvas');
        var ctx = canvas.getContext('2d');
        var parentDiv = document.querySelector('.e-profile');
        var tempCanvas = parentDiv.appendChild(document.createElement('canvas'));
        var tempContext = tempCanvas.getContext('2d');
        tempCanvas.width = croppedData.width; tempCanvas.height = croppedData.height;
        tempContext.putImageData(croppedData, 0, 0);
        ctx.clearRect(0, 0, canvas.width, canvas.height);
        ctx.drawImage(tempCanvas, 0, 0, canvas.width, canvas.height);
        tempCanvas.remove();
        if (canvasInterop.imgSrc !== '') {
            const img = document.querySelector('#custom-img');
            img.src = canvasInterop.imgSrc;
        }
        return true;
    }
};

window.customToolbarInterop = {
    toolbarPosition: function () {
        setTimeout(() => {
            let toolbarArea = document.getElementById('top-toolbar');
            if (toolbarArea) {
                toolbarArea.style.left = (toolbarArea.parentElement.parentElement.clientWidth / 2) - (toolbarArea.clientWidth / 2) + 'px';
            }
            toolbarArea = document.getElementById('bottom-toolbar');
            if (toolbarArea) {
                toolbarArea.style.left = (toolbarArea.parentElement.parentElement.clientWidth / 2) - (toolbarArea.clientWidth / 2) + 'px';
            }
        }, 20);
    },
    loadBase64ImageIntoCanvas: function (canvasId, filter, base64Url) {
        var img = new Image();
        img.onload = function () {
            for (var i = 0; i < canvasId.length; i++) {
                var canvas = document.getElementById(canvasId[i]);
                var context = canvas.getContext('2d');
                context.filter = filter[i];
                context.drawImage(img, 0, 0, canvas.width, canvas.height);
            }
            };
        img.src = base64Url;
    },
    dropdownPosition: function (element) {
        if (window.innerWidth <= 768) {
            var btnElem = document.querySelector('#bottom-toolbar .e-dropdown-btn.e-active');
            if (btnElem) {
                element.style.top = btnElem.getBoundingClientRect().top - element.offsetHeight + 'px';
                element.style.left = element.offsetLeft + 'px';
            }
        }
    },
    updateColorpicker: function (elemId, type, value) {
        var btnElem = document.querySelector(`.e-dropdownbtn-preview.${elemId}`);
        if (type == "shape-fill" && btnElem) {
            if (value == "") {
                btnElem.classList.add('e-nocolor-item');
            } else {
                btnElem.classList.remove('e-nocolor-item');
                btnElem.style.backgroundColor = value;
            }
        } else if (btnElem) {
            btnElem.style.backgroundColor = value;
        }
    }
}
