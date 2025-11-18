#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorDemos.Shared
{
    /// <summary>
    /// A component to dynamically load CSS styles and scripts based on the current sample.
    /// </summary>
    public class DynamicResourceLoader : ComponentBase
    {
        [Inject]
        protected NavigationManager? UriHelper { get; set; }

        [Inject]
        protected SampleService? SampleService { get; set; }

        // Defines the structure for holding resource information (CSS directory and JS files) for a component.
        private class ComponentSamplesResources
        {
            public string? CssDirectory { get; set; }
            public string[]? JsFiles { get; set; }
        }

        // A static dictionary that maps component names (keys) to their required resources (ComponentSamplesResources objects).
        // This allows for efficient lookup of CSS and JS dependencies for each component.
        private readonly Dictionary<string, ComponentSamplesResources> CompSamplesResourcesMappings = new()
        {
            { "ai-smartpaste", new() { CssDirectory = "smart-paste", JsFiles = new[] { "sf-textarea", "sf-dropdownlist", "sf-textbox", "sf-spinner", "sf-toast" } } },
            { "ai-smarttextarea", new() { CssDirectory = "smart-textarea", JsFiles = new[] { "sf-textarea", "sf-dropdownlist", "sf-toast" } } },
            { "ai-combobox", new() { CssDirectory = "combo-box", JsFiles = new[] { "sf-dropdownlist" } } },
            { "ai-scheduler", new() { CssDirectory = "ai-scheduler", JsFiles = new[] { "sf-schedule", "sf-dialog","sf-tab", "sf-spinner", "sf-toast" } } },
            { "ai-richtexteditor", new() { CssDirectory = "ai-richtexteditor", JsFiles = new[] { "sf-richtexteditor", "sf-toast", "sf-dropdownlist", "sf-dialog", "sf-drop-down-button" } } },
            { "ai-querybuilder", new() { CssDirectory = "ai-querybuilder", JsFiles = new[] { "sf-querybuilder", "sf-grid", "sf-toast" } } },
            { "ai-diagram", new() { CssDirectory = "ai-diagram", JsFiles = new[] { "sf-diagramcomponent", "sf-toolbar", "sf-dropdownlist", "sf-floating-action-button", "sf-spinner", "sf-dialog", "sf-drop-down-button", "sf-uploader", "sf-numerictextbox", "sf-textbox", "sf-toast" } } },
            { "ai-kanban", new() { CssDirectory = "ai-kanban", JsFiles = new[] { "sf-kanban", "sf-toast" } } },
            { "ai-datagrid", new() { CssDirectory = "ai-datagrid", JsFiles = new[] { "sf-grid", "sf-toast" } } },
            { "ai-maps", new() { CssDirectory = "ai-maps", JsFiles = new[] { "sf-maps", "sf-spinner", "sf-toast" } } },
            { "ai-filemanager", new() { CssDirectory = "ai-filemanager", JsFiles = new[] { "sf-filemanager", "sf-dialog", "sf-toast" } } },
            { "ai-charts", new() { CssDirectory = "ai-charts", JsFiles = new[] { "sf-chart", "sf-drop-down-button", "sf-dropdownlist", "sf-spinner", "sf-sidebar", "sf-ai-assistview", "sf-toolbar", "sf-listview", "sf-toast", "sf-accumulation-chart" } } },
            { "ai-treegrid", new() { CssDirectory = "ai-treegrid", JsFiles = new[] { "sf-treegrid", "sf-toolbar", "sf-toast", "sf-drop-down-button" } } },
            { "ai-ganttchart", new() { CssDirectory = "ai-ganttchart", JsFiles = new[] { "sf-gantt", "sf-toolbar", "sf-toast" } } },
            { "ai-pivottable", new() { CssDirectory = "ai-pivottable", JsFiles = new[] { "sf-pivotview", "sf-dialog", "sf-toast", "sf-dropdownlist", "sf-textbox", "sf-multiselect" } } },
            { "datagrid", new() { CssDirectory = "grid", JsFiles = new[] { "sf-grid", "sf-chart", "sf-toast" } } },
            { "pivot-table", new() { CssDirectory = "pivotview", JsFiles = new[] { "sf-pivotview", "sf-dropdownlist", "sf-numerictextbox", "sf-heatmap", "sf-multiselect", "sf-textbox", "sf-sidebar", "sf-toolbar", "sf-drop-down-button", "sf-sparkline", "sf-datepicker", "sf-toast", "sf-dialog" } } },
            { "tree-grid", new() { CssDirectory = "treegrid", JsFiles = new[] { "sf-treegrid", "sf-dropdownlist", "sf-textbox", "sf-dialog", "sf-toast" } } },
            { "chart", new() { CssDirectory = "chart", JsFiles = new[] { "sf-chart", "sf-dashboard-layout", "sf-dropdownlist", "sf-numerictextbox", "sf-textbox", "sf-colorpicker", "sf-accumulation-chart", "sf-drop-down-button", "sf-spinner", "sf-sidebar", "sf-ai-assistview", "sf-toolbar", "sf-listview", "sf-toast" } } },
            { "chart-3d", new() { CssDirectory = "chart-3d", JsFiles = new[] { "sf-chart3D" } } },
            { "barcodes", new() { CssDirectory = "barcode", JsFiles = new[] { "sf-barcode", "sf-numerictextbox", "sf-colorpicker", "sf-textbox", "sf-dropdownlist" } } },
            { "bullet-chart", new() { CssDirectory = "bullet-chart", JsFiles = new[] { "sf-bullet-chart", "sf-dropdownlist", "sf-numerictextbox", "sf-colorpicker" } } },
            { "circular-gauge", new() { CssDirectory = "circular-gauge", JsFiles = new[] { "sf-circulargauge", "sf-dropdownlist", "sf-slider", "sf-textbox", "sf-grid" } } },
            { "arc-gauge", new() { CssDirectory = "arc-gauge", JsFiles = new[] { "sf-circulargauge" } } },
            { "diagram", new() { CssDirectory = "diagram", JsFiles = new[] { "sf-diagramcomponent", "sf-uploader", "sf-numerictextbox", "sf-colorpicker", "sf-textbox", "sf-drop-down-button", "sf-toolbar", "sf-tab", "sf-treeview", "sf-grid", "sf-daterangepicker", "sf-chart", "sf-accumulation-chart", "sf-dropdownlist", "sf-dialog", "sf-textarea", "sf-lineargauge", "sf-toast" } } },
			{ "heatmap-chart", new() { CssDirectory = "heatmap-chart", JsFiles = new[] { "sf-heatmap", "sf-dropdownlist", "sf-chart" } } },
            { "kanban", new() { CssDirectory = "kanban", JsFiles = new[] { "sf-kanban", "sf-toast", "sf-textbox", "sf-spinner", "sf-grid", "sf-numerictextbox", "sf-dialog", "sf-dropdownlist", "sf-datepicker" } } },
            { "linear-gauge", new() { CssDirectory = "linear-gauge", JsFiles = new[] { "sf-lineargauge", "sf-dropdownlist", "sf-tooltip" } } },
            { "maps", new() { CssDirectory = "maps", JsFiles = new[] { "sf-maps", "sf-dropdownlist", "sf-textbox", "sf-slider", "sf-accumulation-chart", "sf-spinner", "sf-toast" } } },
            { "range-selector", new() { CssDirectory = "range-selector", JsFiles = new[] { "sf-range-navigator", "sf-grid", "sf-dropdownlist", "sf-textbox", "sf-chart" } } },
            { "sankey", new() { CssDirectory = "sankey", JsFiles = new[] { "sf-sankey" } } },
            { "smith-chart", new() { CssDirectory = "smith-chart", JsFiles = new[] { "sf-smith-chart", "sf-dropdownlist", "sf-numerictextbox", "sf-textbox" } } },
            { "sparkline", new() { CssDirectory = "sparkline", JsFiles = new[] { "sf-sparkline", "sf-grid" } } },
            { "stock-chart", new() { CssDirectory = "stock-chart", JsFiles = new[] { "sf-stock-chart" } } },
            { "treemap", new() { CssDirectory = "treemap", JsFiles = new[] { "sf-treemap", "sf-dropdownlist", "sf-textbox" } } },
            { "rich-text-editor", new() { CssDirectory = "rich-text-editor", JsFiles = new[] { "sf-richtexteditor", "sf-dropdownlist", "sf-mention", "sf-chat-ui", "sf-toast", "sf-dialog", "sf-drop-down-button" } } },
            { "markdown-editor", new() { CssDirectory = "markdown-editor", JsFiles = new[] { "sf-richtexteditor", "sf-mention" } } },
            { "image-editor", new() { CssDirectory = "image-editor", JsFiles = new[] { "sf-image-editor", "sf-toolbar", "sf-drop-down-button", "sf-textbox", "sf-uploader", "sf-colorpicker", "sf-slider", "sf-spinner", "sf-dialog", "sf-multiselect" } } },
            { "in-place-editor", new() { CssDirectory = "inplace-editor", JsFiles = new[] { "sf-inplaceeditor", "sf-dropdownlist", "sf-datepicker", "sf-timepicker", "sf-daterangepicker" } } },
            { "scheduler", new() { CssDirectory = "schedule", JsFiles = new[] { "sf-schedule", "sf-uploader", "sf-drop-down-button", "sf-toolbar", "sf-contextmenu", "sf-multiselect", "sf-dropdownlist", "sf-timepicker", "sf-sidebar", "sf-grid", "sf-pager", "sf-calendar", "sf-listview", "sf-dialog", "sf-textbox", "sf-toast", "sf-treeview", "sf-colorpicker", "sf-tab", "sf-spinner" } } },
            { "gantt-chart", new() { CssDirectory = "gantt", JsFiles = new[] { "sf-gantt", "sf-sidebar", "sf-listview", "sf-slider", "sf-multiselect", "sf-numerictextbox", "sf-dropdownlist", "sf-toolbar", "sf-querybuilder", "sf-textbox", "sf-daterangepicker", "sf-chart", "sf-accumulation-chart", "sf-schedule", "sf-toast" } } },
            { "calendar", new() { CssDirectory = "calendar", JsFiles = new[] { "sf-calendar", "sf-dropdownlist" } } },
            { "datepicker", new() { CssDirectory = "datepicker", JsFiles = new[] { "sf-datepicker", "sf-dropdownlist", "sf-multiselect" } } },
            { "daterangepicker", new() { CssDirectory = "daterangepicker", JsFiles = new[] { "sf-daterangepicker", "sf-dropdownlist", "sf-multiselect" } } },
            { "datetime-picker", new() { CssDirectory = "datetimepicker", JsFiles = new[] { "sf-datepicker", "sf-timepicker", "sf-dropdownlist", "sf-multiselect" } } },
            { "timepicker", new() { CssDirectory = "timepicker", JsFiles = new[] { "sf-timepicker", "sf-dropdownlist", "sf-multiselect" } } },
            { "buttons", new() { CssDirectory = "button", JsFiles = new[] { "sf-drop-down-button" } } },
            { "button-group", new() { CssDirectory = "button-group" } },
            { "chips", new() { CssDirectory = "chips", JsFiles = new[] { "sf-dropdownlist" } } },
            { "fab", new() { CssDirectory = "floating-action-button", JsFiles = new[] { "sf-floating-action-button", "sf-grid" } } },
            { "dropdown-menu", new() { CssDirectory = "drop-down-button", JsFiles = new[] { "sf-drop-down-button" } } },
            { "progress-button", new() { CssDirectory = "progress-button", JsFiles = new[] { "sf-spinner" } } },
            { "split-button", new() { CssDirectory = "split-button", JsFiles = new[] { "sf-drop-down-button" } } },
            { "speeddial", new() { CssDirectory = "speed-dial", JsFiles = new[] { "sf-speeddial", "sf-textbox" } } },
            { "autocomplete", new() { CssDirectory = "auto-complete", JsFiles = new[] { "sf-dropdownlist" } } },
            { "combobox", new() { CssDirectory = "combo-box", JsFiles = new[] { "sf-dropdownlist" } } },
            { "dropdown-list", new() { CssDirectory = "drop-down-list", JsFiles = new[] { "sf-dropdownlist" } } },
            { "dropdown-tree", new() { CssDirectory = "drop-down-tree", JsFiles = new[] { "sf-dropdowntree", "sf-drop-down-button" } } },
            { "listbox", new() { CssDirectory = "list-box", JsFiles = new[] { "sf-listbox", "sf-dropdownlist" } } },
            { "multiselect-dropdown", new() { CssDirectory = "multi-select", JsFiles = new[] { "sf-multiselect", "sf-numerictextbox" } } },
            { "mention", new() { CssDirectory = "mention", JsFiles = new[] { "sf-mention" } } },
            { "multicolumn-combobox", new() { CssDirectory = "multicolumn-combobox", JsFiles = new[] { "sf-multicolumncombobox" } } },
            { "checkbox", new() { CssDirectory = "check-box" } },
            { "color-picker", new() { CssDirectory = "color-picker", JsFiles = new[] { "sf-colorpicker", "sf-textbox", "sf-dropdownlist" } } },
            { "signature", new() { CssDirectory = "signature", JsFiles = new[] { "sf-signature", "sf-drop-down-button", "sf-colorpicker", "sf-dropdownlist" } } },
            { "file-upload", new() { CssDirectory = "uploader", JsFiles = new[] { "sf-uploader" } } },
            { "input-mask", new() { CssDirectory = "maskedtextbox", JsFiles = new[] { "sf-maskedtextbox", "sf-dropdownlist" } } },
            { "numeric-textbox", new() { CssDirectory = "numerictextbox", JsFiles = new[] { "sf-numerictextbox" } } },
            { "radio-button", new() { CssDirectory = "radio-button" } },
            { "range-slider", new() { CssDirectory = "slider", JsFiles = new[] { "sf-slider", "sf-numerictextbox", "sf-dialog" } } },
            { "textarea", new() { CssDirectory = "textarea", JsFiles = new[] { "sf-textarea", "sf-numerictextbox" } } },
            { "textbox", new() { CssDirectory = "textbox", JsFiles = new[] { "sf-textbox", "sf-dropdownlist" } } },
            { "toggle-switch-button", new() { CssDirectory = "switch" } },
            { "rating", new() { CssDirectory = "rating", JsFiles = new[] { "sf-rating" } } },
            { "otp-input", new() { CssDirectory = "otp-input", JsFiles = new[] { "sf-otp-input", "sf-toast", "sf-dropdownlist", "sf-textbox", "sf-numerictextbox" } } },
            { "speech-to-text", new() { CssDirectory = "speech-to-text", JsFiles = new[] { "sf-speechtotext", "sf-textarea", "sf-dropdownlist", "sf-chat-ui", "sf-toast", "sf-ai-assistview" } } },
            { "ai-assistview", new() { CssDirectory = "ai-assistview", JsFiles = new[] { "sf-ai-assistview", "sf-textarea", "sf-carousel", "sf-drop-down-button", "sf-splitter", "sf-dialog", "sf-floating-action-button", "sf-sidebar", "sf-toolbar", "sf-listview" } } },
            { "chat-ui", new() { CssDirectory = "chat-ui", JsFiles = new[] { "sf-chat-ui", "sf-drop-down-button", "sf-dropdownlist", "sf-multiselect", "sf-splitter", "sf-listview" } } },
            { "accordion", new() { CssDirectory = "accordion", JsFiles = new[] { "sf-accordion" } } },
            { "breadcrumb", new() { CssDirectory = "breadcrumb", JsFiles = new[] { "sf-breadcrumb", "sf-menu" } } },
            { "carousel", new() { CssDirectory = "carousel", JsFiles = new[] { "sf-carousel", "sf-dropdownlist" } } },
            { "context-menu", new() { CssDirectory = "context-menu", JsFiles = new[] { "sf-contextmenu" } } },
            { "file-manager", new() { CssDirectory = "file-manager", JsFiles = new[] { "sf-filemanager", "sf-dialog", "sf-toast" } } },
            { "menu-bar", new() { CssDirectory = "menu", JsFiles = new[] { "sf-menu", "sf-dropdownlist", "sf-multiselect", "sf-toolbar", "sf-drop-down-button" } } },
            { "pager", new() { CssDirectory = "pager", JsFiles = new[] { "sf-pager", "sf-listview", "sf-numerictextbox", "sf-dropdownlist", "sf-grid" } } },
            { "sidebar", new() { CssDirectory = "sidebar", JsFiles = new[] { "sf-sidebar", "sf-treeview", "sf-toolbar", "sf-listview", "sf-dropdownlist", "sf-menu", "sf-textbox" } } },
            { "tabs", new() { CssDirectory = "tab", JsFiles = new[] { "sf-tab", "sf-grid", "sf-schedule", "sf-richtexteditor", "sf-dropdownlist", "sf-calendar", "sf-uploader", "sf-datepicker", "sf-numerictextbox", "sf-textbox" } } },
            { "toolbar", new() { CssDirectory = "toolbar", JsFiles = new[] { "sf-toolbar", "sf-numerictextbox", "sf-dropdownlist", "sf-textbox" } } },
            { "treeview", new() { CssDirectory = "treeview", JsFiles = new[] { "sf-treeview", "sf-listview", "sf-spinner" } } },
            { "appbar", new() { CssDirectory = "appbar", JsFiles = new[] { "sf-drop-down-button", "sf-menu", "sf-textbox" } } },
            { "stepper", new() { CssDirectory = "stepper", JsFiles = new[] { "sf-stepper", "sf-textbox" } } },
            { "ribbon", new() { CssDirectory = "ribbon", JsFiles = new[] { "sf-ribbon", "sf-toast", "sf-slider" } } },            
            { "card", new() { CssDirectory = "card", JsFiles = new[] { "sf-textbox", "sf-dropdownlist", "sf-multiselect", "sf-listview" } } },
            { "dashboard-layout", new() { CssDirectory = "dashboard-layout", JsFiles = new[] { "sf-dashboard-layout", "sf-chart", "sf-accumulation-chart", "sf-grid", "sf-dialog" } } },
            { "dialog", new() { CssDirectory = "dialog", JsFiles = new[] { "sf-dialog", "sf-dropdownlist", "sf-textbox", "sf-grid", "sf-richtexteditor", "sf-schedule" } } },
            { "predefined-dialogs", new() { CssDirectory = "predefined-dialog", JsFiles = new[] { "sf-dialog", "sf-textbox" } } },
            { "listview", new() { CssDirectory = "list-view", JsFiles = new[] { "sf-listview" } } },
            { "splitter", new() { CssDirectory = "splitter", JsFiles = new[] { "sf-splitter", "sf-accordion", "sf-treeview", "sf-listview", "sf-textbox", "sf-richtexteditor" } } },
            { "timeline", new() { CssDirectory = "timeline", JsFiles = new[] { "sf-dropdownlist" } } },
            { "tooltip", new() { CssDirectory = "tooltip", JsFiles = new[] { "sf-tooltip", "sf-dropdownlist", "sf-listview", "sf-textbox" } } },
            { "media-query", new() { CssDirectory = "media-query", JsFiles = new[] { "sf-toolbar", "sf-menu" } } },
            { "avatar", new() { CssDirectory = "avatar", JsFiles = new[] { "sf-listview" } } },
            { "message", new() { CssDirectory = "message" } },
            { "progress-bar", new() { CssDirectory = "progress-bar", JsFiles = new[] { "sf-progressbar" } } },
            { "toast", new() { CssDirectory = "toast", JsFiles = new[] { "sf-toast", "sf-dropdownlist", "sf-textbox" } } },
            { "spinner", new() { CssDirectory = "spinner", JsFiles = new[] { "sf-spinner" } } },
            { "skeleton", new() { CssDirectory = "skeleton", JsFiles = new[] { "sf-listview" } } },
            { "badge", new() { CssDirectory = "badge", JsFiles = new[] { "sf-accordion", "sf-listview" } } },
            { "query-builder", new() { CssDirectory = "query-builder", JsFiles = new[] { "sf-querybuilder", "sf-grid", "sf-toast" } } },
            { "data-form", new() { CssDirectory = "data-form", JsFiles = new[] { "sf-numerictextbox", "sf-maskedtextbox", "sf-datepicker", "sf-dropdownlist", "sf-stepper", "sf-textbox", "sf-timepicker" } } }
        };

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, GetResourcesMarkup());
        }

        private string GetResourcesMarkup()
        {
            var theme = SampleUtils.GetThemeName(UriHelper.Uri);
            if (SampleService != null && SampleService.IsThemeChangeOnBrowserNav)
            {
                theme = SampleService.BrowserNavTheme;
                SampleService.IsThemeChangeOnBrowserNav = false;
            }
            StringBuilder sb = new StringBuilder();
            // Use CDN links for Release builds
            var cdnScriptPath = "https://cdn.syncfusion.com/blazor/31.1.17/";
            var cdnStylePath = "https://cdn.syncfusion.com/blazor/sb/styles/31.1.17/";
            var demoPageCompsScript = new string[] { "sf-tab", "sf-tooltip", "sf-toast" };
            if (SampleUtils.IsHomePage(UriHelper))
            {
                sb.AppendLine($"<script src=\"{cdnScriptPath}sf-drop-down-button.min.js\"></script>");
            }
            else 
            {
                if(theme != "fluent2")
                {
                    sb.AppendLine($"<link rel=\"stylesheet\" href=\"https://cdn.syncfusion.com/blazor/sb/styles/31.2.2/demo-page-comps/{theme}.min.css\" />");
                }
                // Get the current component page details
                var compKey = GetComponentKey()?.ToLower();
                // Retrieve the two values (e.g., CssDirectory and JsFiles) based on compName
                ComponentSamplesResources resources = CompSamplesResourcesMappings.GetValueOrDefault(compKey);
                // sf-tab, sf-toast, and sf-tooltip - Since these resources are loaded commonly in every page for the SB's common layout, they are not loaded during comp to comp navigation.
                resources.JsFiles = resources.JsFiles != null ? resources.JsFiles.Except(demoPageCompsScript).ToArray() : null;
                if (SampleService?.SampleName == null)
                {
                    if (!string.IsNullOrEmpty(resources.CssDirectory))
                    {
                        if (resources.CssDirectory == "overall")
                        {
                            sb.AppendLine($"<link rel=\"stylesheet\" href=\"https://cdn.syncfusion.com/blazor/31.1.17/styles/{theme}.css\" />");
                        }
                        else
                        {
                            sb.AppendLine($"<link rel=\"stylesheet\" href=\"{cdnStylePath}{resources.CssDirectory}/{theme}.min.css\" />");
                        }
                    }
                    if (resources.JsFiles != null)
                    {
                        foreach (var file in resources.JsFiles)
                        {
                            var jsPath = file == "syncfusion-blazor" ? $"{cdnScriptPath}syncfusion-blazor.min.js" : $"{cdnScriptPath}{file}.min.js";
                            sb.AppendLine($"<script src=\"{jsPath}\"></script>");
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(resources.CssDirectory))
                    {
                        if (resources.CssDirectory == "overall")
                        {
                            sb.AppendLine($"<link rel=\"stylesheet\" href=\"https://cdn.syncfusion.com/blazor/31.1.17/styles/{theme}.css\" />");
                        }
                        else if (resources.JsFiles == null)
                        {
                            sb.AppendLine($"<link rel=\"stylesheet\" href=\"{cdnStylePath}{resources.CssDirectory}/{theme}.min.css\" onload=\"onCompStylesLoaded(false)\" />");
                        }
                        else
                        {
                            sb.AppendLine($"<link rel=\"stylesheet\" href=\"{cdnStylePath}{resources.CssDirectory}/{theme}.min.css\" onload=\"onCompStylesLoaded(true)\" />");
                        }
                    }
                    if (resources.JsFiles != null)
                    {
                        foreach (var file in resources.JsFiles)
                        {
                            var jsPath = file == "syncfusion-blazor" ? $"{cdnScriptPath}syncfusion-blazor.min.js" : $"{cdnScriptPath}{file}.min.js";
                            if (resources.JsFiles[resources.JsFiles.Length - 1] == file)
                            {
                                sb.AppendLine($"<script src=\"{jsPath}\" onload=\"onCompScriptsLoaded()\"></script>");
                            }
                            else
                            {
                                sb.AppendLine($"<script src=\"{jsPath}\"></script>");
                            }
                        }
                    }
                }
                if (compKey == "image-editor")
                {
                    sb.AppendLine($"<script src=\"https://cdn.syncfusion.com/blazor/sb/scripts/31.1.17/image-editor.min.js\"></script>");
                }
                if (compKey == "ribbon")
                {
                    sb.AppendLine($"<script src=\"https://cdn.syncfusion.com/blazor/sb/scripts/31.1.17/ribbon.min.js\"></script>");
                }
                if (compKey == "rich-text-editor")
                {
                    sb.AppendLine($"<script src=\"https://cdn.syncfusion.com/blazor/sb/scripts/31.1.17/richtexteditor.min.js\"></script>");
                }
                if (compKey == "speech-to-text")
                {
                    sb.AppendLine($"<script src=\"https://cdn.syncfusion.com/blazor/sb/scripts/31.1.17/speechtotext.min.js\"></script>");
                }
                if (compKey == "diagram" || compKey == "ai-diagram")
                {
                    sb.AppendLine($"<link rel=\"stylesheet\" href=\"https://cdn.syncfusion.com/blazor/sb/styles/31.1.17/common/diagram/syncfusion-blazor-icons.min.css\" />");
                }
                if (theme.Contains("dark") || theme.Contains("fluent2-highcontrast") || theme.Contains("highcontrast"))
                {
                    sb.AppendLine($"<link rel=\"stylesheet\" href=\"https://cdn.syncfusion.com/blazor/sb/styles/31.2.2/common/highcontrast.min.css\" />");
                    sb.AppendLine($"<link rel=\"stylesheet\" href=\"https://cdn.syncfusion.com/blazor/sb/styles/31.2.2/common/dark-theme.min.css\" />");
                }
                // Add sf-tab, sf-toast, and sf-tooltip for the SB's common layout if syncfusion-blazor.js is not already being loaded.
                if (resources.JsFiles == null || !resources.JsFiles.Contains("syncfusion-blazor"))
                {
                    sb.AppendLine($"<script src=\"{cdnScriptPath}sf-tab.min.js\"></script>");
                    sb.AppendLine($"<script src=\"{cdnScriptPath}sf-tooltip.min.js\"></script>");
                    sb.AppendLine($"<script src=\"{cdnScriptPath}sf-toast.min.js\"></script>");
                }
            }
            return sb.ToString();
        }

        private string GetComponentKey()
        {
            string demoPath;
            // Url is often like "Component/SampleName" e.g., "datagrid/overview"
            if (SampleService?.SampleName == null) {
                demoPath = SampleService?.SampleInfo?.Url;
            }
            else
            {
                demoPath = SampleService.SampleName;
            }
            List<string> specialCaseComponents = new List<string>
                {
                    "split-button",
                    "button-group",
                    "dropdown-menu",
                    "progress-button",
                    "toggle-switch-button",
                    "checkbox",
                    "radio-button"
                };
            foreach (var component in specialCaseComponents)
            {
                if (demoPath.Contains("buttons/" + component))
                {
                    return component;
                }
            }
            var componentName = demoPath?.Split('/')[0];
            return componentName;
        }

        public void Refresh()
        {
            StateHasChanged();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            // Assign reference to sample service for outside usage.
            if (firstRender && SampleService != null)
            {
                SampleService.DynamicResourceLoader = this;
            }
        }
    }
}