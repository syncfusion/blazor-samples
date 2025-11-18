import { data } from './version.js';
var path = "_content/Blazor_WASM_Common_NET8";
const homepagepath = ["/", "/wasm/demos/", "/development/wasm/net8/demos/", "/release/wasm/net8/demos/", "/hotfix/wasm/net8/demos/"];

function loadAssets(file) {
    if (file.indexOf(".css") >= 0) {
        const link = document.createElement('link');
        link.setAttribute('rel', 'stylesheet');
        link.setAttribute('type', 'text/css');
        link.setAttribute('href', file);
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
            'https://cdn.syncfusion.com/blazor/sb/favicon.ico'
        ];
    }
    else if(data.configuration == "Staging"){
        assetFiles = [
            '/favicon.ico'
        ];
    } 
    else {
        assetFiles = [
            '/favicon.ico'
        ];
    }
    assetFiles.forEach((file) => {
        if (data.configuration == "Release") {
            loadAssets(file);
        }
        else {
            loadAssets(path + file);
        }
    });
}

function samplePageAssets() {
    var assetFiles;
    if (data.configuration == "Release") {
        assetFiles = [
            'https://cdn.syncfusion.com/blazor/sb/favicon.ico',
            'https://cdn.syncfusion.com/blazor/sb/styles/31.1.17/common/roboto.min.css',
            'https://cdn.syncfusion.com/blazor/sb/scripts/31.1.17/highlight.min.js'
        ];
    } 
    else if(data.configuration == "Staging"){
        assetFiles = [
            '/styles/common/highcontrast.min.css',
            '/favicon.ico',
            '/styles/common/roboto.min.css',
            '/scripts/common/highlight.min.js',
            '/scripts/image-editor.min.js',
            '/scripts/richtexteditor.min.js',
            '/styles/common/dark-theme.min.css',
            '/scripts/ribbon.min.js',
            '/scripts/speechtotext.min.js',
            '/styles/diagram/syncfusion-blazor-icons.min.css',
        ];
    }
    else {
        assetFiles = [
            '/styles/common/highcontrast.css',
            '/favicon.ico',
            '/styles/common/roboto.css',
            '/scripts/common/highlight.min.js',
            '/scripts/image-editor.js',
            '/scripts/richtexteditor.js',
            '/styles/common/dark-theme.css',
            '/scripts/ribbon.js',
            '/scripts/speechtotext.js',
            '/styles/diagram/syncfusion-blazor-icons.css',
        ];
    }
    assetFiles.forEach((file) => {
        if (data.configuration == "Release") {
            loadAssets(file);
        }
        else {
            loadAssets(path + file);
        }
    });
}

if (homepagepath.indexOf(window.location.pathname) !== -1) {
    homePageAssets();
}
else {
    samplePageAssets();
}