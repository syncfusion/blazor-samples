import { data } from './version.js';
if (data.version == "net8.0") {
    var path = "_content/Blazor_WASM_Common_NET8";
    var isolatedCss = "Blazor_WASM_Demos_NET8.styles.css";
}
else {
    var path = "_content/Blazor_WASM_Common_NET9";
    var isolatedCss = "Blazor_WASM_Demos_NET9.styles.css";
}

const homepagepath = ["/", "/wasm/demos/","/development/wasm/net8/demos/","/development/wasm/net9/demos/", "/release/wasm/net8/demos/","/release/wasm/net9/demos/", "/hotfix/wasm/net8/demos/","/hotfix/wasm/net9/demos/"];

function dynamicResources() {
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
    if (window.location.href.indexOf('spreadsheet') != -1) {
        let newScript = document.createElement('script');
        newScript.setAttribute('src', "_content/Syncfusion.Blazor.Spreadsheet/scripts/syncfusion-blazor-spreadsheet.min.js");
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
            '/styles/site.min.css',
            '/styles/common/home.min.css',
            '/styles/common/devices.min.css',
            '/scripts/common/index.min.js'
        ];
    } else {
        assetFiles = [
            '/styles/bootstrap.min.css',
            '/favicon.ico',
            '/styles/site.css',
            '/styles/common/home.css',
            '/styles/common/devices.css',
            '/scripts/common/index.js'
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
            '/styles/common/highcontrast.min.css',
            '/favicon.ico',
            '/styles/common/roboto.min.css',
            '/styles/bootstrap.min.css',
            '/styles/common/highlight.min.css',
            '/styles/common/demos.min.css',
            '/styles/common/devices.min.css',
            '/scripts/common/highlight.min.js',
            '/scripts/common/index.min.js',
            '/scripts/image-editor.min.js',
            '/scripts/richtexteditor.min.js',
            '/styles/common/dark-theme.min.css',
            '/scripts/ribbon.min.js',
            '/scripts/speechtotext.min.js',
        ];
    } else {
        assetFiles = [
            '/styles/common/highcontrast.css',
            '/favicon.ico',
            '/styles/common/roboto.css',
            '/styles/bootstrap.min.css',
            '/styles/common/highlight.css',
            '/styles/common/demos.css',
            '/styles/common/devices.css',
            '/scripts/common/highlight.min.js',
            '/scripts/common/index.js',
            '/scripts/image-editor.js',
            '/scripts/richtexteditor.js',
            '/styles/common/dark-theme.css',
            '/scripts/ribbon.js',
            '/scripts/speechtotext.js',
        ]; 
    }
    assetFiles.forEach((file) => {
        loadAssets(path + file);
    });

}


if (homepagepath.indexOf(window.location.pathname) !== -1) {
    loadAssets(isolatedCss);
    homePageAssets();
}
else {
    samplePageAssets();
    loadAssets(isolatedCss);
}
dynamicResources();
