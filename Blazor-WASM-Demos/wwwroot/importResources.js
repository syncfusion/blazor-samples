import {data} from './version.js';
if (data.version == "net6.0") {
    var path = "_content/Blazor_WASM_Common_NET6";
    var css = "/Blazor_WASM_Common_NET6.bundle.scp.css";
}
else {
    var path = "_content/Blazor_WASM_Common_NET8";
    var css = "/Blazor_WASM_Common_NET8.bundle.scp.css";
}

const homepagepath = ["/staging/wasm/demos/" ,"/wasm/demos/", "/development/wasm/net6/demos/", "/development/wasm/net8/demos/", "/release/wasm/net6/demos/", "/release/wasm/net8/demos/", "/hotfix/wasm/net6/demos/", "/hotfix/wasm/net8/demos/","/cloudtesting/net8-wasm/","/"];


function dynamicResources() {
    if (window.location.href.indexOf('pdf-viewer') != -1 && window.location.href.indexOf('pdf-viewer-2') == -1) {
        let newScript = document.createElement('script');
        newScript.setAttribute('src', "_content/Syncfusion.Blazor.PdfViewer/scripts/syncfusion-blazor-pdfviewer.min.js");
        document.getElementsByClassName('dynamic-resources')[0].appendChild(newScript);
    }
    if (window.location.href.indexOf('pdf-viewer-2') != -1) {
        let newScript = document.createElement('script');
        newScript.setAttribute('src', "_content/Syncfusion.Blazor.SfPdfViewer/scripts/syncfusion-blazor-sfpdfviewer.min.js");
        document.getElementsByClassName('dynamic-resources')[0].appendChild(newScript);
    }
    if (window.location.href.indexOf('document-editor') != -1) {
        let newScript = document.createElement('script');
        newScript.setAttribute('src', "_content/Syncfusion.Blazor.WordProcessor/scripts/syncfusion-blazor-documenteditor.min.js");
        document.getElementsByClassName('dynamic-resources')[0].appendChild(newScript);
    }
}

function loadAssets(file) {
    if (file.indexOf(".css") >= 0) {
        const link = document.createElement('link');
        link.setAttribute('rel', 'stylesheet');
        link.setAttribute('type', 'text/css');
        link.setAttribute('href', file);
        if (file.indexOf("device") >= 0) {
            link.setAttribute('media', "(max-width: 1024px)");
        }
        document.head.appendChild(link);
    }
    else if (file.indexOf(".js") >= 0) {
        const script = document.createElement('script');
        script.setAttribute('src', file);
        document.body.appendChild(script);
    }
    else {
        const link = document.createElement('link');
        link.setAttribute('rel', 'shortcut icon');
        link.setAttribute('type', 'image/x-icon');
        link.setAttribute('href', file);
        document.head.appendChild(link);
    }
}

function homePageAssets() {
    var assetFiles;
    if (data.configuration == "Release") {
        assetFiles = [
            '/styles/bootstrap.min.css',
            '/favicon.ico',
            '/styles/site.css',
            '/styles/common/home.min.css',
            '/styles/common/devices.min.css',
            '/scripts/common/index.min.js',
            css
        ];
    } else {
        assetFiles = [
            '/styles/bootstrap.min.css',
            '/favicon.ico',
            '/styles/site.css',
            '/styles/common/home.css',
            '/styles/common/devices.css',
            '/scripts/common/index.js',
            css
        ];
    }
    assetFiles.forEach((file) => {
        loadAssets(path + file);
    });

}

function samplePageAssets() {
    var assetFiles;
    if (data.configuration == "Release") {
        assetFiles = [
            '/favicon.ico',
            css,
            '/styles/bootstrap.min.css',
            '/styles/common/demos.min.css',
            '/styles/common/devices.min.css',
            '/scripts/common/highlight.min.js',
            '/scripts/common/index.min.js',
            '/scripts/image-editor.min.js',
            '/styles/common/dark-theme.min.css',
        ];
    } else {
        assetFiles = [
            '/styles/common/highcontrast.css',
            '/favicon.ico',
            css,
            '/styles/common/roboto.css',
            '/styles/bootstrap.min.css',
            '/styles/common/highlight.css',
            '/styles/common/demos.css',
            '/styles/common/devices.css',
            '/scripts/common/highlight.min.js',
            '/scripts/common/index.js',
            '/scripts/image-editor.js',
            '/styles/common/dark-theme.css',
        ]; }
    assetFiles.forEach((file) => {
        loadAssets(path + file);
    });

}


if (homepagepath.indexOf(window.location.pathname) !== -1) {
    homePageAssets();
    loadAssets('_content/Syncfusion.Blazor.Core/scripts/syncfusion-blazor.min.js');
}
else {
    samplePageAssets();
}
dynamicResources();
setTimeout(LoadingText, 400);
function LoadingText() {
    document.getElementById("Loading-Text").innerHTML = "Loading Syncfusion Blazor Web Assembly Demos…"
}
