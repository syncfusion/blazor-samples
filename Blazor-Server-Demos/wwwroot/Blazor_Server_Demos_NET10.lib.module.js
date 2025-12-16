//This file is for lazy loading styles and scripts that are not immediately needed for the initial rendering.
import { data } from './version.js';
var path = "_content/Blazor_Server_Common_net10";
const homepagepath = ["/demos/", "/development/net10/demos/", "/release/net10/demos/", "/hotfix/net10/demos/", "/"];

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
            '/favicon.ico',
            '/styles/common/roboto.min.css',
            '/scripts/common/highlight.min.js'
        ];
    }
    else {
        assetFiles = [
            '/favicon.ico',
            '/styles/common/roboto.css',
            '/scripts/common/highlight.min.js'
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