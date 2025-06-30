import { data } from './version.js';

var path = "_content/Blazor_Server_Common_NET8";

const homepagepath = ["/demos/", "/development/net8/demos/", "/release/net8/demos/", "/hotfix/net8/demos/", "/"];

// Predefined mappings for component names to their corresponding values
const compNameMappings = {
    'ai-smartpaste': { cssDirectory: 'overall', jsFile: ['sf-textarea', 'sf-dropdownlist', 'sf-textbox', 'sf-spinner', 'sf-toast'] },
    'ai-smarttextarea': { cssDirectory: 'overall', jsFile: ['sf-textarea', 'sf-dropdownlist', 'sf-toast'] },
    'ai-combobox': { cssDirectory: 'combo-box', jsFile: ['sf-dropdownlist'] },
    'ai-scheduler': { cssDirectory: 'overall', jsFile: ['syncfusion-blazor'] },
    'ai-richtexteditor': { cssDirectory: 'overall', jsFile: ['syncfusion-blazor'] },
    'ai-querybuilder': { cssDirectory: 'overall', jsFile: ['syncfusion-blazor'] },
    'ai-diagram': { cssDirectory: 'overall', jsFile: ['syncfusion-blazor']},
    'ai-pdfviewer-2': { cssDirectory: 'overall', jsFile: ['syncfusion-blazor-sfpdfviewer','syncfusion-blazor'] },
    'ai-documenteditor': { cssDirectory: 'overall', jsFile: ['syncfusion-blazor-documenteditor','syncfusion-blazor'] },
    'ai-kanban': { cssDirectory: 'overall', jsFile: ['sf-kanban', 'sf-toast'] },
    'ai-datagrid': { cssDirectory: 'overall', jsFile: ['sf-grid', 'sf-toast'] },
    'datagrid': { cssDirectory: 'overall', jsFile: ['syncfusion-blazor'] },
    'pivot-table': { cssDirectory: 'pivotview', jsFile: ['sf-pivotview','sf-dropdownlist','sf-numerictextbox','sf-heatmap','sf-multiselect', 'sf-textbox'] },
    'spreadsheet': { cssDirectory: 'overall', jsFile: ['syncfusion-blazor-spreadsheet', 'syncfusion-blazor'] },
    'tree-grid': { cssDirectory: 'treegrid', jsFile: ['sf-treegrid', 'sf-dropdownlist'] },
    'chart': { cssDirectory: 'chart', jsFile: ['sf-chart', 'sf-dashboard-layout', 'sf-dropdownlist', 'sf-numerictextbox', 'sf-textbox', 'sf-colorpicker','sf-accumulation-chart'] },
    'chart-3d': { cssDirectory: 'chart-3d', jsFile: ['syncfusion-blazor'] },
    'barcodes': { cssDirectory: 'barcode', jsFile: ['sf-barcode', 'sf-numerictextbox', 'sf-colorpicker', 'sf-textbox', 'sf-dropdownlist'] },
    'bullet-chart': { cssDirectory: 'bullet-chart', jsFile: ['sf-bullet-chart', 'sf-dropdownlist', 'sf-numerictextbox', 'sf-colorpicker'] },
    'circular-gauge': { cssDirectory: 'circular-gauge', jsFile: ['sf-circulargauge', 'sf-dropdownlist', 'sf-slider', 'sf-textbox','sf-grid'] },
    'arc-gauge': { cssDirectory: 'arc-gauge', jsFile: ['sf-circulargauge'] },
    'diagram': { cssDirectory: 'overall', jsFile: ['sf-diagramcomponent','sf-uploader','sf-numerictextbox', 'sf-colorpicker', 'sf-textbox', 'sf-drop-down-button','sf-toolbar','sf-tab','sf-treeview','sf-grid','sf-daterangepicker','sf-chart','sf-accumulation-chart','sf-dropdownlist'] },
    'heatmap-chart': { cssDirectory: 'heatmap-chart', jsFile: ['sf-heatmap', 'sf-dropdownlist', 'sf-chart'] },
    'kanban': { cssDirectory: 'kanban', jsFile: ['sf-kanban'] },
    'linear-gauge': { cssDirectory: 'linear-gauge', jsFile: ['sf-lineargauge', 'sf-dropdownlist', 'sf-tooltip'] },
    'maps': { cssDirectory: 'maps', jsFile: ['sf-maps', 'sf-dropdownlist', 'sf-textbox','sf-slider','sf-accumulation-chart'] },
    'range-selector': { cssDirectory: 'range-selector', jsFile: ['sf-range-navigator','sf-grid', 'sf-dropdownlist', 'sf-textbox','sf-chart'] },
    'sankey': { cssDirectory: 'sankey', jsFile: ['sf-sankey'] },
    'smith-chart': { cssDirectory: 'smith-chart', jsFile: ['sf-smith-chart', 'sf-dropdownlist', 'sf-numerictextbox', 'sf-textbox'] },
    'sparkline': { cssDirectory: 'sparkline', jsFile: ['sf-sparkline', 'sf-grid'] },
    'stock-chart': { cssDirectory: 'stock-chart', jsFile: ['sf-stock-chart'] },
    'treemap': { cssDirectory: 'treemap', jsFile: ['sf-treemap', 'sf-dropdownlist', 'sf-textbox'] },
    'pdf-viewer-2': { cssDirectory: 'pdfviewer', jsFile: ['syncfusion-blazor-sfpdfviewer','sf-grid','sf-uploader','sf-multiselect','sf-accordion'] },
    'document-editor': { cssDirectory: 'overall', jsFile: ['syncfusion-blazor-documenteditor','sf-grid', 'sf-dialog','sf-multiselect','sf-treeview','sf-spinner'] },
    'rich-text-editor': { cssDirectory: 'rich-text-editor', jsFile: ['sf-richtexteditor', 'sf-dropdownlist','sf-mention'] },
    'markdown-editor': { cssDirectory: 'markdown-editor', jsFile: ['sf-richtexteditor','sf-mention'] },
    'image-editor': { cssDirectory: 'image-editor', jsFile: ['sf-image-editor','sf-toolbar', 'sf-drop-down-button', 'sf-textbox', 'sf-uploader','sf-colorpicker','sf-slider','sf-spinner', 'sf-dialog','sf-multiselect'] },
    'in-place-editor': { cssDirectory: 'inplace-editor', jsFile: ['sf-inplaceeditor','sf-dropdownlist','sf-datepicker','sf-timepicker','sf-daterangepicker'] },
    'scheduler': { cssDirectory: 'schedule', jsFile: ['sf-schedule', 'sf-uploader','sf-drop-down-button','sf-toolbar','sf-contextmenu','sf-multiselect','sf-dropdownlist','sf-timepicker','sf-sidebar','sf-grid','sf-pager','sf-calendar','sf-listview','sf-dialog', 'sf-textbox','sf-toast','sf-treeview'] },
    'gantt-chart': { cssDirectory: 'gantt', jsFile: ['syncfusion-blazor'] },
    'calendar': { cssDirectory: 'calendar', jsFile: ['sf-calendar','sf-dropdownlist'] },
    'datepicker': { cssDirectory: 'datepicker', jsFile: ['sf-datepicker','sf-dropdownlist','sf-multiselect'] },
    'daterangepicker': { cssDirectory: 'daterangepicker', jsFile: ['sf-daterangepicker','sf-dropdownlist','sf-multiselect'] },
    'datetime-picker': { cssDirectory: 'datetimepicker',jsFile: ['sf-datepicker','sf-timepicker','sf-dropdownlist','sf-multiselect'] },
    'timepicker': { cssDirectory: 'timepicker', jsFile: ['sf-timepicker','sf-dropdownlist','sf-multiselect'] },
    'buttons': { cssDirectory: 'button', jsFile: ['sf-drop-down-button'] },
    'button-group': { cssDirectory: 'button-group' },
    'chips': { cssDirectory: 'chips', jsFile: ['sf-dropdownlist'] },
    'fab': { cssDirectory: 'overall', jsFile: ['syncfusion-blazor'] },
    'dropdown-menu': { cssDirectory: 'drop-down-button', jsFile: ['sf-drop-down-button']},
    'progress-button': { cssDirectory: 'progress-button', jsFile: ['sf-spinner'] },
    'split-button': { cssDirectory: 'split-button', jsFile: ['sf-drop-down-button'] },
    'speeddial': { cssDirectory: 'speed-dial', jsFile: ['sf-speeddial', 'sf-textbox'] },
    'autocomplete': { cssDirectory: 'auto-complete', jsFile: ['sf-dropdownlist'] },
    'combobox': { cssDirectory: 'combo-box', jsFile: ['sf-dropdownlist'] },
    'dropdown-list': { cssDirectory: 'drop-down-list', jsFile: ['sf-dropdownlist'] },
    'dropdown-tree': { cssDirectory: 'drop-down-tree', jsFile: ['sf-dropdowntree','sf-drop-down-button'] },
    'listbox': { cssDirectory: 'list-box', jsFile: ['sf-listbox','sf-dropdownlist'] },
    'multiselect-dropdown': { cssDirectory: 'multi-select', jsFile: ['sf-multiselect','sf-numerictextbox'] },
    'mention': { cssDirectory: 'mention', jsFile: ['sf-mention'] },
    'multicolumn-combobox': { cssDirectory: 'multicolumn-combobox', jsFile: ['sf-multicolumncombobox'] },
    'checkbox': { cssDirectory: 'check-box' },
    'color-picker': { cssDirectory: 'color-picker', jsFile: ['sf-colorpicker', 'sf-textbox', 'sf-dropdownlist'] },
    'signature': { cssDirectory: 'signature', jsFile: ['sf-signature','sf-drop-down-button','sf-colorpicker','sf-dropdownlist'] },
    'file-upload': { cssDirectory: 'uploader', jsFile: ['sf-uploader'] },
    'input-mask': { cssDirectory: 'maskedtextbox', jsFile: ['sf-maskedtextbox','sf-dropdownlist'] },
    'numeric-textbox': { cssDirectory: 'numerictextbox', jsFile: ['sf-numerictextbox'] },
    'radio-button': { cssDirectory: 'radio-button' },
    'range-slider': { cssDirectory: 'slider', jsFile: ['sf-slider','sf-numerictextbox', 'sf-dialog'] },
    'textarea': { cssDirectory: 'textarea', jsFile: ['sf-textarea','sf-numerictextbox'] },
    'textbox': { cssDirectory: 'textbox', jsFile: ['sf-textbox','sf-dropdownlist'] },
    'toggle-switch-button': { cssDirectory: 'switch' },
    'rating': { cssDirectory: 'rating', jsFile: ['sf-rating'] },
    'otp-input': { cssDirectory: 'otp-input', jsFile: ['sf-otp-input','sf-toast','sf-dropdownlist', 'sf-textbox','sf-numerictextbox'] },
    'speech-to-text': { cssDirectory: 'overall', jsFile: ['syncfusion-blazor']},
    'ai-assistview': { cssDirectory: 'overall', jsFile: ['syncfusion-blazor'] },
    'chat-ui': { cssDirectory: 'chat-ui', jsFile: ['sf-chat-ui', 'sf-drop-down-button', 'sf-dropdownlist','sf-multiselect','sf-splitter','sf-listview'] },
    'accordion': { cssDirectory: 'accordion', jsFile: ['sf-accordion'] },
    'breadcrumb': { cssDirectory: 'breadcrumb', jsFile: ['sf-breadcrumb', 'sf-menu'] },
    'carousel': { cssDirectory: 'carousel', jsFile: ['sf-carousel','sf-dropdownlist'] },
    'context-menu': { cssDirectory: 'context-menu', jsFile: ['sf-contextmenu'] },
    'file-manager': { cssDirectory: 'file-manager', jsFile: ['sf-filemanager'] },
    'menu-bar': { cssDirectory: 'menu', jsFile: ['sf-menu','sf-dropdownlist','sf-multiselect','sf-toolbar', 'sf-drop-down-button'] },
    'pager': { cssDirectory: 'pager', jsFile: ['sf-pager','sf-listview', 'sf-numerictextbox','sf-dropdownlist','sf-grid'] },
    'sidebar': { cssDirectory: 'sidebar', jsFile: ['sf-sidebar','sf-treeview','sf-toolbar','sf-listview','sf-dropdownlist','sf-menu', 'sf-textbox'] },
    'tabs': { cssDirectory: 'tab', jsFile: ['sf-tab','sf-grid','sf-schedule','sf-richtexteditor', 'sf-dropdownlist','sf-calendar','sf-uploader','sf-datepicker','sf-numerictextbox','sf-textbox'] },
    'toolbar': { cssDirectory: 'toolbar', jsFile: ['sf-toolbar','sf-numerictextbox','sf-dropdownlist','sf-textbox'] },
    'treeview': { cssDirectory: 'treeview', jsFile: ['sf-treeview','sf-listview','sf-spinner'] },
    'appbar': { cssDirectory: 'appbar', jsFile: ['sf-drop-down-button','sf-menu', 'sf-textbox'] },
    'stepper': { cssDirectory: 'stepper', jsFile: ['sf-stepper','sf-textbox'] },
    'ribbon': { cssDirectory: 'overall', jsFile: ['syncfusion-blazor'] },
    'card': { cssDirectory: 'card', jsFile: ['sf-textbox','sf-dropdownlist','sf-multiselect','sf-listview']  },
    'dashboard-layout': { cssDirectory: 'dashboard-layout', jsFile: ['sf-dashboard-layout','sf-chart','sf-accumulation-chart','sf-grid', 'sf-dialog'] },
    'dialog': { cssDirectory: 'dialog', jsFile: ['sf-dialog','sf-dropdownlist','sf-textbox','sf-grid'] },
    'predefined-dialogs': { cssDirectory: 'predefined-dialog', jsFile: ['sf-dialog', 'sf-textbox'] },
    'listview': { cssDirectory: 'list-view', jsFile: ['sf-listview'] },
    'splitter': { cssDirectory: 'splitter', jsFile: ['sf-splitter','sf-accordion','sf-treeview','sf-listview','sf-textbox','sf-richtexteditor'] },
    'timeline': { cssDirectory: 'timeline', jsFile: ['sf-dropdownlist'] },
    'tooltip': { cssDirectory: 'tooltip', jsFile: ['sf-tooltip','sf-dropdownlist','sf-listview','sf-textbox'] },
    'media-query': { cssDirectory: 'media-query', jsFile: ['sf-toolbar','sf-menu'] },
    'avatar': { cssDirectory: 'avatar', jsFile: ['sf-listview'] },
    'message': { cssDirectory: 'message' },
    'progress-bar': { cssDirectory: 'progress-bar', jsFile: ['sf-progressbar'] },
    'toast': { cssDirectory: 'overall', jsFile: ['sf-toast', 'sf-dropdownlist', 'sf-textbox'] },
    'spinner': { cssDirectory: 'spinner', jsFile: ['sf-spinner'] },
    'skeleton': { cssDirectory: 'skeleton', jsFile: ['sf-listview'] },
    'badge': { cssDirectory: 'badge', jsFile: ['sf-accordion','sf-listview']  },
    'query-builder': { cssDirectory: 'query-builder', jsFile: ['syncfusion-blazor'] },
    'data-form': { cssDirectory: 'data-form', jsFile: ['sf-numerictextbox','sf-maskedtextbox','sf-datepicker','sf-dropdownlist','sf-stepper','sf-textbox','sf-datepicker','sf-timepicker'] },
    'word': { cssDirectory: 'word', jsFile: ['sf-dropdownlist', 'sf-textbox'] },
    'pdf': { cssDirectory: 'pdf', jsFile: ['sf-dropdownlist'] },
    'powerpoint': { cssDirectory: 'powerpoint', jsFile: ['sf-dropdownlist', 'sf-uploader', 'sf-toolbar', 'syncfusion-blazor-sfpdfviewer'] },
    'excel': { cssDirectory: 'excel', jsFile: ['sf-grid','sf-dropdownlist'] }
};

let theme = new URL(window.location.href).searchParams.get("theme");
theme = theme ? theme : "fluent2";
theme = theme === "bootstrap5" ? "bootstrap5.3" : theme === "bootstrap5-dark" ? "bootstrap5.3-dark" : theme;

function getCompNameFromURL() {
    var pathSegments = window.location.pathname;
    pathSegments = pathSegments.split('?')[0];
    pathSegments = pathSegments.split('/')
        .filter(segment => segment.length > 0);
    const specialCaseComponents = ['split-button', 'button-group', 'dropdown-menu', 'progress-button', 'toggle-switch-button', 'checkbox','radio-button'];
    for (const componentName of specialCaseComponents) {
        if (pathSegments.includes(componentName)) {
            return componentName;
        }
    }
    return pathSegments[pathSegments.length - 2];
}

window.sfBlazorSBStaticAssets = {
    dynamicResources: function () {
        if (data.configuration == "Release") {
            //Get the current component page details
            var compName = getCompNameFromURL();
            // Retrieve the two values (e.g., cssDirectory and jsFile) based on compName
            const values = compNameMappings[compName];
            //Dynamically patch the resources to the DOM
            if (values.cssDirectory === "overall") {
                loadAssets("https://cdn.syncfusion.com/blazor/29.2.4/styles/" + theme + ".css");
            }
            else {
                loadAssets("https://cdn.syncfusion.com/blazor/sb/styles/" + values.cssDirectory + "/" + theme + ".min.css");
            }
            if (!values.jsFile || !values.jsFile.includes('syncfusion-blazor')) {
                // Dynamically import necessary scripts for the common layout components
                import("https://cdn.syncfusion.com/blazor/29.2.4/sf-tab.min.js");
                import("https://cdn.syncfusion.com/blazor/29.2.4/sf-tooltip.min.js");
            }
            if (values.jsFile) {
                for (const file of values.jsFile) {
                    if (file === "syncfusion-blazor") {
                        import("https://cdn.syncfusion.com/blazor/29.2.4/syncfusion-blazor.min.js");
                    }
                    else {
                        import("https://cdn.syncfusion.com/blazor/29.2.4/" + file + ".min.js");
                    }
                }
            }

            if (window.location.href.indexOf('image-editor') != -1) {
                loadAssets("https://cdn.syncfusion.com/blazor/sb/scripts/image-editor.min.js");
            }
            if (window.location.href.indexOf('ribbon') != -1) {
                loadAssets("https://cdn.syncfusion.com/blazor/sb/scripts/ribbon.min.js");
            }
            if (window.location.href.indexOf('rich-text-editor') != -1) {
                loadAssets("https://cdn.syncfusion.com/blazor/sb/scripts/richtexteditor.min.js");
            }
            if (window.location.href.indexOf('speech-to-text') != -1) {
                loadAssets("https://cdn.syncfusion.com/blazor/sb/scripts/speechtotext.min.js");
            }
            if (window.location.href.indexOf('diagram') != -1) {
                loadAssets("https://cdn.syncfusion.com/blazor/sb/styles/common/diagram/syncfusion-blazor-icons.min.css");
            }
            if (window.location.href.indexOf('dark') != -1 || window.location.href.indexOf('fluent2-highcontrast') != -1 || window.location.href.indexOf('highcontrast') != -1) {
                loadAssets("https://cdn.syncfusion.com/blazor/sb/styles/common/dark-theme.min.css");
            }
        }
        else {
            loadAssets("_content/Syncfusion.Blazor.Themes/" + theme + ".css");
            loadAssets("_content/Syncfusion.Blazor.Core/scripts/syncfusion-blazor.min.js");
            if (window.location.href.indexOf('pdf-viewer-2') != -1 || window.location.href.indexOf('powerpoint') != -1 || window.location.href.indexOf('ai-pdfviewer-2') != -1) {
	            loadAssets("_content/Syncfusion.Blazor.SfPdfViewer/scripts/syncfusion-blazor-sfpdfviewer.min.js");
	        }
	        if (window.location.href.indexOf('document-editor') != -1 || window.location.href.indexOf('ai-documenteditor') != -1) {
	            loadAssets("_content/Syncfusion.Blazor.WordProcessor/scripts/syncfusion-blazor-documenteditor.min.js");
	        }
	        if (window.location.href.indexOf('spreadsheet') != -1) {
	            loadAssets("_content/Syncfusion.Blazor.Spreadsheet/scripts/syncfusion-blazor-spreadsheet.min.js");
	        }
        }
    }
};
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
            'https://cdn.syncfusion.com/blazor/sb/styles/home-page/fluent2.min.css',
            'https://cdn.syncfusion.com/blazor/sb/styles/common/bootstrap.min.css',
            'https://cdn.syncfusion.com/blazor/sb/favicon.ico',
            'https://cdn.syncfusion.com/blazor/sb/styles/common/site.min.css',
            'https://cdn.syncfusion.com/blazor/sb/styles/common/home.min.css',
            'https://cdn.syncfusion.com/blazor/sb/styles/common/devices.min.css'
        ];
    } 
    else if(data.configuration == "Staging"){
        assetFiles = [
            '_content/Syncfusion.Blazor.Themes/fluent2.css',
            '/styles/bootstrap.min.css',
            '/favicon.ico',
            '/styles/site.min.css',
            '/styles/common/home.min.css',
            '/styles/common/devices.min.css'
        ];
    }
    else {
        assetFiles = [
			'_content/Syncfusion.Blazor.Themes/fluent2.css',
            '/styles/bootstrap.min.css',
            '/favicon.ico',
            '/styles/site.css',
            '/styles/common/home.css',
            '/styles/common/devices.css'
        ];
    }
    assetFiles.forEach((file) => {
        if (data.configuration == "Release") {
            loadAssets(file);
        }
        else {
			if (file.includes('_content')) {
                loadAssets(file);
            }
            else {
                loadAssets(path + file);
            }
        }
    });
}

function samplePageAssets() {
    var assetFiles;
    if (data.configuration == "Release") {
        assetFiles = [
            'https://cdn.syncfusion.com/blazor/sb/favicon.ico',
            'https://cdn.syncfusion.com/blazor/sb/styles/common/bootstrap.min.css',
            'https://cdn.syncfusion.com/blazor/sb/styles/common/demos.min.css',
            'https://cdn.syncfusion.com/blazor/sb/styles/common/devices.min.css',
            'https://cdn.syncfusion.com/blazor/sb/scripts/highlight.min.js'
        ];
    } 
    else if(data.configuration == "Staging"){
        assetFiles = [
            '/styles/common/highcontrast.min.css',
            '/favicon.ico',
            '/styles/common/roboto.min.css',
            '/styles/bootstrap.min.css',
            '/styles/common/highlight.min.css',
            '/styles/common/demos.min.css',
            '/styles/common/devices.min.css',
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
            '/styles/bootstrap.min.css',
            '/styles/common/highlight.css',
            '/styles/common/demos.css',
            '/styles/common/devices.css',
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
    if (data.configuration == "Release") {
        // Dynamically import necessary scripts for the homepage
        import("https://cdn.syncfusion.com/blazor/29.2.4/sf-carousel.min.js");
        import("https://cdn.syncfusion.com/blazor/29.2.4/sf-drop-down-button.min.js");
    }
    else {
        loadAssets("_content/Syncfusion.Blazor.Core/scripts/syncfusion-blazor.min.js");
    }
}
else {
    loadAssets("Blazor_Server_Demos_NET8.styles.css");
    sfBlazorSBStaticAssets.dynamicResources();
    samplePageAssets();
}