import {data} from './version.js';
if (data.version == "net6.0") {
    var path = "_content/Blazor_WASM_Common_NET6";
    var css = "/Blazor_WASM_Common_NET6.bundle.scp.css";
}
else {
    var path = "_content/Blazor_WASM_Common_NET7";
    var css = "/Blazor_WASM_Common_NET7.bundle.scp.css";
}

const homepagepath = ["/development/wasm/net6/demos/", "/development/wasm/net7/demos/", "/release/wasm/net6/demos/", "/release/wasm/net7/demos/", "/hotfix/wasm/net6/demos/", "/hotfix/wasm/net7/demos/","/"];

function themeSwitch() {
    let url = window.location.href.split("?theme=");
    if (url.length > 1) {
        let synclink = document.getElementById('theme');
        synclink.href = '_content/Syncfusion.Blazor.Themes/' + url[1] + '.css';
    }
}

function dynamicResources() {
    if (window.location.href.indexOf('pdf-viewer') != -1) {
        let newScript = document.createElement('script');
        newScript.setAttribute('src', "_content/Syncfusion.Blazor.PdfViewer/scripts/syncfusion-blazor-pdfviewer.min.js");
        document.getElementById('dynamic-resources').appendChild(newScript);
    }
    if (window.location.href.indexOf('document-editor') != -1) {
        let newScript = document.createElement('script');
        newScript.setAttribute('src', "_content/Syncfusion.Blazor.WordProcessor/scripts/syncfusion-blazor-documenteditor.min.js");
        document.getElementById('dynamic-resources').appendChild(newScript);
    }
}

function loadCSS(file) {
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

function homepageCSS() {
    const cssFiles = [
        '/styles/bootstrap.min.css',
        '/favicon.ico',
        '/styles/site.css',
        '/styles/common/home.css',
        '/styles/common/devices.css',
        '/scripts/common/index.js',
        css
    ];
    cssFiles.forEach((file) => {
        loadCSS(path + file);
    });

}

function samplesPageCSS() {
    const cssFiles = [
        '/styles/common/highcontrast.css',
        '/favicon.ico',
        '/styles/site.css',
        '/styles/common/roboto.css',
        '/styles/bootstrap.min.css',
        '/styles/common/highlight.css',
        '/styles/common/demos.css',
        '/styles/common/devices.css',
        '/scripts/common/highlight.min.js',
        '/scripts/common/index.js',
        '/styles/common/dark-theme.css'
    ];
    cssFiles.forEach((file) => {
        loadCSS(path + file);
    });
}


if (homepagepath.indexOf(window.location.pathname) !== -1) {
    homepageCSS();
}
else {
    samplesPageCSS();
}
themeSwitch();
dynamicResources();
setTimeout(LoadingText, 400);
function LoadingText() {
    document.getElementById("Loading-Text").innerHTML = "Loading Syncfusion Blazor Web Assembly Demos…"
}


