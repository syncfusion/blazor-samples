#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
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
            { "ai-assist-view", new() { CssDirectory = "ai-assistview", JsFiles = new[] { "sf-ai-assistview", "sf-textarea", "sf-drop-down-button", "sf-splitter", "sf-floating-action-button", "sf-sidebar", "sf-toolbar", "sf-listview", "sf-toast", "sf-dropdownlist" } } },
            { "ai-datagrid", new() { CssDirectory = "ai-datagrid", JsFiles = new[] { "sf-grid", "sf-toast" } } },
            { "ai-maps", new() { CssDirectory = "ai-maps", JsFiles = new[] { "sf-maps", "sf-spinner", "sf-toast" } } },
            { "ai-filemanager", new() { CssDirectory = "ai-filemanager", JsFiles = new[] { "sf-filemanager", "sf-dialog", "sf-toast" } } },
            { "ai-charts", new() { CssDirectory = "ai-charts", JsFiles = new[] { "sf-chart", "sf-drop-down-button", "sf-dropdownlist", "sf-spinner", "sf-sidebar", "sf-ai-assistview", "sf-toolbar", "sf-listview", "sf-toast", "sf-accumulation-chart" } } },
            { "ai-treegrid", new() { CssDirectory = "ai-treegrid", JsFiles = new[] { "sf-treegrid", "sf-toolbar", "sf-toast", "sf-drop-down-button" } } },
            { "ai-ganttchart", new() { CssDirectory = "ai-ganttchart", JsFiles = new[] { "sf-gantt", "sf-toolbar", "sf-toast" } } },
            { "ai-pivottable", new() { CssDirectory = "ai-pivottable", JsFiles = new[] { "sf-pivotview", "sf-dialog", "sf-toast", "sf-dropdownlist", "sf-textbox", "sf-multiselect" } } },
            { "datagrid", new() { CssDirectory = "grid", JsFiles = new[] { "sf-grid", "sf-chart", "sf-toast", "sf-switch" } } },
            { "pivot-table", new() { CssDirectory = "pivotview", JsFiles = new[] { "sf-pivotview", "sf-dropdownlist", "sf-numerictextbox", "sf-heatmap", "sf-multiselect", "sf-textbox", "sf-sidebar", "sf-toolbar", "sf-drop-down-button", "sf-sparkline", "sf-datepicker", "sf-toast", "sf-dialog", "sf-checkbox", "sf-switch", "sf-contextmenu", "sf-menu" } } },
            { "tree-grid", new() { CssDirectory = "treegrid", JsFiles = new[] { "sf-treegrid", "sf-dropdownlist", "sf-textbox", "sf-dialog", "sf-toast", "sf-switch" } } },
            { "chart", new() { CssDirectory = "chart", JsFiles = new[] { "sf-chart", "sf-dashboard-layout", "sf-dropdownlist", "sf-numerictextbox", "sf-textbox", "sf-colorpicker", "sf-accumulation-chart", "sf-drop-down-button", "sf-spinner", "sf-sidebar", "sf-ai-assistview", "sf-toolbar", "sf-listview", "sf-toast", "sf-checkbox" } } },
            { "chart-3d", new() { CssDirectory = "chart-3d", JsFiles = new[] { "sf-chart3D" } } },
            { "barcodes", new() { CssDirectory = "barcode", JsFiles = new[] { "sf-barcode", "sf-numerictextbox", "sf-colorpicker", "sf-textbox", "sf-dropdownlist", "sf-checkbox", "sf-switch" } } },
            { "bullet-chart", new() { CssDirectory = "bullet-chart", JsFiles = new[] { "sf-bullet-chart", "sf-dropdownlist", "sf-numerictextbox", "sf-colorpicker" } } },
            { "circular-gauge", new() { CssDirectory = "circular-gauge", JsFiles = new[] { "sf-circulargauge", "sf-dropdownlist", "sf-slider", "sf-textbox", "sf-grid", "sf-checkbox" } } },
            { "arc-gauge", new() { CssDirectory = "arc-gauge", JsFiles = new[] { "sf-circulargauge" } } },
            { "diagram", new() { CssDirectory = "diagram", JsFiles = new[] { "sf-diagramcomponent", "sf-uploader", "sf-numerictextbox", "sf-colorpicker", "sf-textbox", "sf-drop-down-button", "sf-toolbar", "sf-tab", "sf-treeview", "sf-grid", "sf-daterangepicker", "sf-chart", "sf-accumulation-chart", "sf-dropdownlist", "sf-dialog", "sf-textarea", "sf-lineargauge", "sf-toast", "sf-circulargauge", "sf-checkbox", "sf-switch", "sf-floating-action-button" } } },
			{ "heatmap-chart", new() { CssDirectory = "heatmap-chart", JsFiles = new[] { "sf-heatmap", "sf-dropdownlist", "sf-chart", "sf-checkbox" } } },
            { "kanban", new() { CssDirectory = "kanban", JsFiles = new[] { "sf-kanban", "sf-checkbox", "sf-treeview", "sf-toast", "sf-textbox", "sf-spinner", "sf-grid", "sf-numerictextbox", "sf-dialog", "sf-dropdownlist", "sf-datepicker" } } },
            { "linear-gauge", new() { CssDirectory = "linear-gauge", JsFiles = new[] { "sf-lineargauge", "sf-dropdownlist", "sf-tooltip" } } },
            { "maps", new() { CssDirectory = "maps", JsFiles = new[] { "sf-maps", "sf-dropdownlist", "sf-textbox", "sf-slider", "sf-accumulation-chart", "sf-spinner", "sf-toast", "sf-checkbox" } } },
            { "range-selector", new() { CssDirectory = "range-selector", JsFiles = new[] { "sf-range-navigator", "sf-grid", "sf-dropdownlist", "sf-textbox", "sf-chart" } } },
            { "sankey", new() { CssDirectory = "sankey", JsFiles = new[] { "sf-sankey" } } },
            { "smith-chart", new() { CssDirectory = "smith-chart", JsFiles = new[] { "sf-smith-chart", "sf-dropdownlist", "sf-numerictextbox", "sf-textbox", "sf-checkbox" } } },
            { "sparkline", new() { CssDirectory = "sparkline", JsFiles = new[] { "sf-sparkline", "sf-grid", "sf-checkbox" } } },
            { "stock-chart", new() { CssDirectory = "stock-chart", JsFiles = new[] { "sf-stock-chart" } } },
            { "treemap", new() { CssDirectory = "treemap", JsFiles = new[] { "sf-treemap", "sf-dropdownlist", "sf-textbox", "sf-checkbox" } } },
            { "rich-text-editor", new() { CssDirectory = "rich-text-editor", JsFiles = new[] { "sf-richtexteditor", "sf-checkbox", "sf-dropdownlist", "sf-mention", "sf-chat-ui", "sf-toast", "sf-dialog", "sf-drop-down-button" } } },
            { "markdown-editor", new() { CssDirectory = "markdown-editor", JsFiles = new[] { "sf-richtexteditor", "sf-mention" } } },
            { "image-editor", new() { CssDirectory = "image-editor", JsFiles = new[] { "sf-image-editor", "sf-toolbar", "sf-drop-down-button", "sf-textbox", "sf-uploader", "sf-colorpicker", "sf-slider", "sf-spinner", "sf-dialog", "sf-multiselect" } } },
            { "in-place-editor", new() { CssDirectory = "inplace-editor", JsFiles = new[] { "sf-inplaceeditor", "sf-dropdownlist", "sf-datepicker", "sf-timepicker", "sf-daterangepicker", "sf-checkbox", "sf-textarea", "sf-multiselect", "sf-numerictextbox", "sf-maskedtextbox" } } },
            { "scheduler", new() { CssDirectory = "schedule", JsFiles = new[] { "sf-schedule", "sf-uploader", "sf-drop-down-button", "sf-toolbar", "sf-contextmenu", "sf-multiselect", "sf-dropdownlist", "sf-timepicker", "sf-sidebar", "sf-grid", "sf-pager", "sf-calendar", "sf-listview", "sf-dialog", "sf-textbox", "sf-toast", "sf-treeview", "sf-colorpicker", "sf-tab", "sf-spinner", "sf-checkbox" } } },
            { "gantt-chart", new() { CssDirectory = "gantt", JsFiles = new[] { "sf-gantt", "sf-sidebar", "sf-listview", "sf-slider", "sf-multiselect", "sf-numerictextbox", "sf-dropdownlist", "sf-toolbar", "sf-querybuilder", "sf-textbox", "sf-daterangepicker", "sf-chart", "sf-accumulation-chart", "sf-schedule", "sf-toast", "sf-switch", "sf-checkbox" } } },
            { "calendar", new() { CssDirectory = "calendar", JsFiles = new[] { "sf-calendar", "sf-dropdownlist", "sf-checkbox" } } },
            { "datepicker", new() { CssDirectory = "datepicker", JsFiles = new[] { "sf-datepicker", "sf-dropdownlist", "sf-multiselect", "sf-checkbox" } } },
            { "daterangepicker", new() { CssDirectory = "daterangepicker", JsFiles = new[] { "sf-daterangepicker", "sf-dropdownlist", "sf-multiselect", "sf-checkbox" } } },
            { "datetime-picker", new() { CssDirectory = "datetimepicker", JsFiles = new[] { "sf-datepicker", "sf-timepicker", "sf-dropdownlist", "sf-multiselect", "sf-checkbox" } } },
            { "timepicker", new() { CssDirectory = "timepicker", JsFiles = new[] { "sf-timepicker", "sf-dropdownlist", "sf-multiselect", "sf-checkbox" } } },
            { "buttons", new() { CssDirectory = "button", JsFiles = new[] { "sf-drop-down-button", "sf-checkbox", "sf-switch" } } },
            { "button-group", new() { CssDirectory = "button-group" } },
            { "chips", new() { CssDirectory = "chips", JsFiles = new[] { "sf-dropdownlist", "sf-checkbox" } } },
            { "fab", new() { CssDirectory = "floating-action-button", JsFiles = new[] { "sf-floating-action-button", "sf-grid", "sf-tooltip" } } },
            { "dropdown-menu", new() { CssDirectory = "drop-down-button", JsFiles = new[] { "sf-drop-down-button" } } },
            { "progress-button", new() { CssDirectory = "progress-button", JsFiles = new[] { "sf-spinner" } } },
            { "split-button", new() { CssDirectory = "split-button", JsFiles = new[] { "sf-drop-down-button" } } },
            { "speeddial", new() { CssDirectory = "speed-dial", JsFiles = new[] { "sf-speeddial", "sf-textbox" } } },
            { "autocomplete", new() { CssDirectory = "auto-complete", JsFiles = new[] { "sf-dropdownlist", "sf-numerictextbox" } } },
            { "combobox", new() { CssDirectory = "combo-box", JsFiles = new[] { "sf-dropdownlist", "sf-numerictextbox" } } },
            { "dropdown-list", new() { CssDirectory = "drop-down-list", JsFiles = new[] { "sf-dropdownlist", "sf-numerictextbox" } } },
            { "dropdown-tree", new() { CssDirectory = "drop-down-tree", JsFiles = new[] { "sf-dropdowntree", "sf-drop-down-button", "sf-checkbox" } } },
            { "listbox", new() { CssDirectory = "list-box", JsFiles = new[] { "sf-listbox", "sf-dropdownlist", "sf-checkbox" } } },
            { "multiselect-dropdown", new() { CssDirectory = "multi-select", JsFiles = new[] { "sf-multiselect", "sf-numerictextbox", "sf-checkbox" } } },
            { "mention", new() { CssDirectory = "mention", JsFiles = new[] { "sf-mention" } } },
            { "multicolumn-combobox", new() { CssDirectory = "multicolumn-combobox", JsFiles = new[] { "sf-multicolumncombobox", "sf-dropdownlist", "sf-numerictextbox" } } },
            { "checkbox", new() { CssDirectory = "check-box", JsFiles = new[] { "sf-checkbox" } } },
            { "color-picker", new() { CssDirectory = "color-picker", JsFiles = new[] { "sf-colorpicker", "sf-textbox", "sf-dropdownlist", "sf-checkbox" } } },
            { "signature", new() { CssDirectory = "signature", JsFiles = new[] { "sf-signature", "sf-drop-down-button", "sf-colorpicker", "sf-dropdownlist", "sf-checkbox", "sf-tab" } } },
            { "file-upload", new() { CssDirectory = "uploader", JsFiles = new[] { "sf-uploader", "sf-checkbox" } } },
            { "input-mask", new() { CssDirectory = "maskedtextbox", JsFiles = new[] { "sf-maskedtextbox", "sf-dropdownlist", "sf-checkbox" } } },
            { "numeric-textbox", new() { CssDirectory = "numerictextbox", JsFiles = new[] { "sf-numerictextbox" } } },
            { "radio-button", new() { CssDirectory = "radio-button" } },
            { "range-slider", new() { CssDirectory = "slider", JsFiles = new[] { "sf-slider", "sf-numerictextbox", "sf-dialog", "sf-checkbox" } } },
            { "textarea", new() { CssDirectory = "textarea", JsFiles = new[] { "sf-textarea", "sf-numerictextbox", "sf-checkbox", "sf-textbox" } } },
            { "textbox", new() { CssDirectory = "textbox", JsFiles = new[] { "sf-textbox", "sf-dropdownlist", "sf-checkbox" } } },
            { "toggle-switch-button", new() { CssDirectory = "switch", JsFiles = new[] { "sf-switch" }  } },
            { "rating", new() { CssDirectory = "rating", JsFiles = new[] { "sf-rating" } } },
            { "otp-input", new() { CssDirectory = "otp-input", JsFiles = new[] { "sf-otp-input", "sf-toast", "sf-dropdownlist", "sf-textbox", "sf-numerictextbox", "sf-switch" } } },
            { "speech-to-text", new() { CssDirectory = "speech-to-text", JsFiles = new[] { "sf-speechtotext", "sf-textarea", "sf-dropdownlist", "sf-chat-ui", "sf-toast", "sf-ai-assistview", "sf-switch" } } },
            { "ai-assistview", new() { CssDirectory = "ai-assistview", JsFiles = new[] { "sf-ai-assistview", "sf-textarea", "sf-carousel", "sf-drop-down-button", "sf-splitter", "sf-dialog", "sf-floating-action-button", "sf-sidebar", "sf-toolbar", "sf-listview", "sf-speechtotext", "sf-toast", "sf-dropdownlist" } } },
            { "chat-ui", new() { CssDirectory = "chat-ui", JsFiles = new[] { "sf-chat-ui", "sf-drop-down-button", "sf-dropdownlist", "sf-multiselect", "sf-splitter", "sf-listview", "sf-switch" } } },
            { "accordion", new() { CssDirectory = "accordion", JsFiles = new[] { "sf-accordion" } } },
            { "breadcrumb", new() { CssDirectory = "breadcrumb", JsFiles = new[] { "sf-breadcrumb", "sf-menu" } } },
            { "carousel", new() { CssDirectory = "carousel", JsFiles = new[] { "sf-carousel", "sf-dropdownlist", "sf-switch" } } },
            { "context-menu", new() { CssDirectory = "context-menu", JsFiles = new[] { "sf-contextmenu" } } },
            { "file-manager", new() { CssDirectory = "file-manager", JsFiles = new[] { "sf-filemanager", "sf-dialog", "sf-toast", "sf-checkbox", "sf-dropdownlist" } } },
            { "menu-bar", new() { CssDirectory = "menu", JsFiles = new[] { "sf-menu", "sf-dropdownlist", "sf-multiselect", "sf-toolbar", "sf-drop-down-button", "sf-checkbox" } } },
            { "pager", new() { CssDirectory = "pager", JsFiles = new[] { "sf-pager", "sf-listview", "sf-numerictextbox", "sf-dropdownlist", "sf-grid" } } },
            { "sidebar", new() { CssDirectory = "sidebar", JsFiles = new[] { "sf-sidebar", "sf-treeview", "sf-toolbar", "sf-listview", "sf-dropdownlist", "sf-menu", "sf-textbox" } } },
            { "tabs", new() { CssDirectory = "tab", JsFiles = new[] { "sf-tab", "sf-grid", "sf-schedule", "sf-richtexteditor", "sf-dropdownlist", "sf-calendar", "sf-uploader", "sf-datepicker", "sf-numerictextbox", "sf-textbox", "sf-listview" } } },
            { "toolbar", new() { CssDirectory = "toolbar", JsFiles = new[] { "sf-toolbar", "sf-numerictextbox", "sf-dropdownlist", "sf-textbox" } } },
            { "treeview", new() { CssDirectory = "treeview", JsFiles = new[] { "sf-treeview", "sf-listview", "sf-spinner" } } },
            { "appbar", new() { CssDirectory = "appbar", JsFiles = new[] { "sf-drop-down-button", "sf-menu", "sf-textbox" } } },
            { "stepper", new() { CssDirectory = "stepper", JsFiles = new[] { "sf-stepper", "sf-textbox" } } },
            { "ribbon", new() { CssDirectory = "ribbon", JsFiles = new[] { "sf-ribbon", "sf-toast", "sf-slider" } } },            
            { "card", new() { CssDirectory = "card", JsFiles = new[] { "sf-textbox", "sf-dropdownlist", "sf-multiselect", "sf-listview", "sf-checkbox" } } },
            { "dashboard-layout", new() { CssDirectory = "dashboard-layout", JsFiles = new[] { "sf-dashboard-layout", "sf-chart", "sf-accumulation-chart", "sf-grid", "sf-dialog", "sf-checkbox" } } },
            { "dialog", new() { CssDirectory = "dialog", JsFiles = new[] { "sf-dialog", "sf-dropdownlist", "sf-textbox", "sf-grid", "sf-chart", "sf-datepicker", "sf-richtexteditor", "sf-schedule", "sf-checkbox" } } },
            { "predefined-dialogs", new() { CssDirectory = "predefined-dialog", JsFiles = new[] { "sf-dialog", "sf-textbox" } } },
            { "listview", new() { CssDirectory = "list-view", JsFiles = new[] { "sf-listview" } } },
            { "splitter", new() { CssDirectory = "splitter", JsFiles = new[] { "sf-splitter", "sf-accordion", "sf-treeview", "sf-listview", "sf-textbox", "sf-richtexteditor" } } },
            { "timeline", new() { CssDirectory = "timeline", JsFiles = new[] { "sf-dropdownlist", "sf-switch" } } },
            { "tooltip", new() { CssDirectory = "tooltip", JsFiles = new[] { "sf-tooltip", "sf-dropdownlist", "sf-listview", "sf-textbox", "sf-toolbar", "sf-checkbox" } } },
            { "media-query", new() { CssDirectory = "media-query", JsFiles = new[] { "sf-toolbar", "sf-menu" } } },
            { "avatar", new() { CssDirectory = "avatar", JsFiles = new[] { "sf-listview" } } },
            { "message", new() { CssDirectory = "message", JsFiles = new[] { "sf-checkbox" } } },
            { "progress-bar", new() { CssDirectory = "progress-bar", JsFiles = new[] { "sf-progressbar" } } },
            { "toast", new() { CssDirectory = "toast", JsFiles = new[] { "sf-toast", "sf-dropdownlist", "sf-textbox", "sf-checkbox", "sf-switch" } } },
            { "spinner", new() { CssDirectory = "spinner", JsFiles = new[] { "sf-spinner" } } },
            { "skeleton", new() { CssDirectory = "skeleton", JsFiles = new[] { "sf-listview" } } },
            { "badge", new() { CssDirectory = "badge", JsFiles = new[] { "sf-accordion", "sf-listview", "sf-toolbar" } } },
            { "query-builder", new() { CssDirectory = "query-builder", JsFiles = new[] { "sf-querybuilder", "sf-grid", "sf-toast", "sf-checkbox", "sf-dropdownlist", "sf-dialog", "sf-textbox", "sf-tooltip", "sf-tab", "sf-slider", "sf-drop-down-button" } } },
            { "data-form", new() { CssDirectory = "data-form", JsFiles = new[] { "sf-numerictextbox", "sf-maskedtextbox", "sf-datepicker", "sf-dropdownlist", "sf-stepper", "sf-textbox", "sf-timepicker", "sf-checkbox", "sf-switch" } } },
            { "block-editor", new() { CssDirectory = "blockeditor", JsFiles = new[] { "sf-blockeditor", "sf-dropdownlist" } } }
        };

        // For referencing the component’s individual script in local and staging environments.
        private readonly Dictionary<string, string> StaticAssetScriptPathMappings = new()
        {
            { "sf-accumulation-chart", "charts" },
            { "sf-accordion", "navigations" },
            { "sf-ai-assistview", "interactivechat" },
            { "sf-barcode", "barcodegenerator" },
            { "sf-breadcrumb", "navigations" },
            { "sf-bullet-chart", "bulletchart" },
            { "sf-calendar", "calendars" },
            { "sf-carousel", "navigations" },
            { "sf-chart", "charts" },
            { "sf-chart3D", "chart3d" },
            { "sf-chat-ui", "interactivechat" },
            {"sf-checkbox", "buttons" },
            { "sf-circulargauge", "circulargauge" },
            { "sf-colorpicker", "inputs" },
            { "sf-contextmenu", "navigations" },
            { "sf-dashboard-layout", "layouts" },
            { "sf-daterangepicker", "calendars" },
            { "sf-datepicker", "calendars" },
            { "sf-diagramcomponent", "diagram" },
            { "sf-dialog", "popups" },
            { "sf-drop-down-button", "splitbuttons" },
            { "sf-dropdownlist", "dropdowns" },
            { "sf-dropdowntree", "navigations" },
            { "sf-filemanager", "filemanager" },
            { "sf-floating-action-button", "buttons" },
            { "sf-gantt", "gantt" },
            { "sf-grid", "grid" },
            { "sf-heatmap", "heatmap" },
            { "sf-image-editor", "imageeditor" },
            { "sf-inplaceeditor", "inplaceeditor" },
            { "sf-kanban", "kanban" },
            { "sf-lineargauge", "lineargauge" },
            { "sf-listbox", "dropdowns" },
            { "sf-listview", "lists" },
            { "sf-maps", "maps" },
            { "sf-maskedtextbox", "inputs" },
            { "sf-mention", "dropdowns" },
            { "sf-menu", "navigations" },
            { "sf-multicolumncombobox", "multicolumncombobox" },
            { "sf-multiselect", "dropdowns" },
            { "sf-numerictextbox", "inputs" },
            { "sf-otp-input", "inputs" },
            { "sf-pager", "navigations" },
            { "sf-pivotview", "pivottable" },
            { "sf-progressbar", "progressbar" },
            { "sf-querybuilder", "querybuilder" },
            {"sf-range-navigator", "rangenavigator"},
            { "sf-rating", "inputs" },
            { "sf-ribbon", "ribbon" },
            { "sf-richtexteditor", "richtexteditor" },
            { "sf-sankey", "sankey" },
            { "sf-schedule", "schedule" },
            {"sf-speechtotext", "inputs"},
            { "sf-sidebar", "navigations" },
            { "sf-signature", "inputs" },
            { "sf-slider", "inputs" },
            { "sf-smith-chart", "smithchart" },
            { "sf-sparkline", "sparkline" },
            { "sf-speeddial", "buttons" },
            { "sf-splitter", "layouts" },
            { "sf-spinner", "spinner" },
            { "sf-stepper", "navigations" },
            { "sf-stock-chart", "stockchart" },
            { "sf-switch", "buttons" },
            { "sf-tab", "navigations" },
            { "sf-textarea", "inputs" },
            { "sf-textbox", "inputs" },
            { "sf-timepicker", "calendars" },
            { "sf-toast", "notifications" },
            {"sf-toolbar", "navigations"},
            { "sf-tooltip", "popups" },
            { "sf-treegrid", "treegrid" },
            { "sf-treeview", "navigations" },
            { "sf-treemap", "treemap" },
            { "sf-uploader", "inputs" },
            { "sf-blockeditor", "blockeditor" }
        };

        private string GetStaticAssetScriptPath(string jsFile)
        {
            return $"_content/syncfusion.blazor.{StaticAssetScriptPathMappings.GetValueOrDefault(jsFile)}/scripts/";
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, GetResourcesMarkup());
        }

        private string GetResourcesMarkup()
        {
            var theme = SampleUtils.GetThemeName(UriHelper.Uri);
            var isOldTheme = SampleService.IsOldTheme(theme);
            if (SampleService != null && SampleService.IsThemeChangeOnBrowserNav)
            {
                theme = SampleService.BrowserNavTheme;
                SampleService.IsThemeChangeOnBrowserNav = false;
            }
            StringBuilder sb = new StringBuilder();
#if RELEASE || (!DEBUG && STAGING)
        var minExtension = ".min";
#else
        var minExtension = "";
#endif
#if !STAGING && RELEASE
            // Use CDN links for Release builds
            var scriptPath = "https://cdn.syncfusion.com/blazor/32.1.19/";
            var stylePath = "https://cdn.syncfusion.com/blazor/sb/styles/32.1.19/";
            var overallStylePath = "https://cdn.syncfusion.com/blazor/32.1.19/styles/";
            var sbSamplesJsPath = "https://cdn.syncfusion.com/blazor/sb/scripts/32.1.19/";
            var sbCommonCssPath = stylePath;
            var sbDiagramCssPath = $"{stylePath}common/";
#else
            var scriptPath = "";
            var stylePath = $"{SampleService.AssetsPath}styles/component-samples/";
            var overallStylePath = "_content/Syncfusion.Blazor.Themes/";
            var sbSamplesJsPath = $"{SampleService.AssetsPath}scripts/";
            var sbCommonCssPath = $"{SampleService.AssetsPath}styles/";
            var sbDiagramCssPath = sbCommonCssPath; 
#endif
            var demoPageCompsScript = new string[] { "sf-tab", "sf-tooltip", "sf-toast" };
            var isErrorPage = UriHelper.Uri == UriHelper.BaseUri + "error";
            if (SampleUtils.IsHomePage(UriHelper))
            {
#if !STAGING && RELEASE
                sb.AppendLine($"<script src=\"{scriptPath}sf-drop-down-button.min.js\"></script>");
                sb.AppendLine($"<script src=\"{scriptPath}sf-listview.min.js\"></script>");
#else
                sb.AppendLine($"<script src=\"_content/syncfusion.blazor.splitbuttons/scripts/sf-drop-down-button.min.js\"></script>");
                sb.AppendLine($"<script src=\"_content/syncfusion.blazor.lists/scripts/sf-listview.min.js\"></script>");
#endif
            }
            else if (!isErrorPage)
            {
                if(!isOldTheme && !SampleService.IsBuild)
                {
                    sb.AppendLine($"<link rel=\"stylesheet\" href=\"{stylePath}demo-page-comps/{theme}.min.css\" onload=\"onCommonLayoutStylesLoaded('{theme}')\"/>");
                }
                // Get the current component page details
                var compKey = GetComponentKey()?.ToLower();
                // Retrieve the two values (e.g., CssDirectory and JsFiles) based on compName
                ComponentSamplesResources resources = CompSamplesResourcesMappings.GetValueOrDefault(compKey);
                // sf-tab, sf-toast, and sf-tooltip - Since these resources are loaded commonly in every page for the SB's common layout, they are not loaded during comp to comp navigation.
                resources.JsFiles = resources.JsFiles != null ? resources.JsFiles.Except(demoPageCompsScript).ToArray() : null;
                if (SampleService?.SampleName == null)
                {
                    if (!string.IsNullOrEmpty(resources.CssDirectory) && !isOldTheme && !SampleService.IsBuild)
                    {   
                        if (resources.CssDirectory == "overall")
                        {
                            sb.AppendLine($"<link rel=\"stylesheet\" href=\"{overallStylePath}{theme}.css\" />");
                        }
                        else
                        {
                            sb.AppendLine($"<link rel=\"stylesheet\" href=\"{stylePath}{resources.CssDirectory}/{theme}.min.css\" />");
                        }
                    }
                    if (resources.JsFiles != null)
                    {
                        foreach (var file in resources.JsFiles)
                        {
#if DEBUG || STAGING
                            scriptPath = GetStaticAssetScriptPath(file);
                            if(file == "syncfusion-blazor")
                            {
                                scriptPath = "_content/Syncfusion.Blazor.Core/scripts/";
                            }
#endif
                            var jsPath = file == "syncfusion-blazor" ? $"{scriptPath}syncfusion-blazor.min.js" : $"{scriptPath}{file}.min.js";
                            sb.AppendLine($"<script src=\"{jsPath}\"></script>");
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(resources.CssDirectory) && !isOldTheme && !SampleService.IsBuild)
                    {
                        if (resources.CssDirectory == "overall")
                        {
                            sb.AppendLine($"<link rel=\"stylesheet\" href=\"{overallStylePath}{theme}.css\" />");
                        }
                        else if (resources.JsFiles == null)
                        {
                            sb.AppendLine($"<link rel=\"stylesheet\" href=\"{stylePath}{resources.CssDirectory}/{theme}.min.css\" onload=\"onCompStylesLoaded(false)\" />");
                        }
                        else
                        {
                            sb.AppendLine($"<link rel=\"stylesheet\" href=\"{stylePath}{resources.CssDirectory}/{theme}.min.css\" onload=\"onCompStylesLoaded(true)\" />");
                        }
                    }
                    if (resources.JsFiles != null)
                    {
                        foreach (var file in resources.JsFiles)
                        {
#if DEBUG || STAGING
                            scriptPath = GetStaticAssetScriptPath(file);
                            if (file == "syncfusion-blazor")
                            {
                                scriptPath = "_content/Syncfusion.Blazor.Core/scripts/";
                            }
#endif
                            var jsPath = file == "syncfusion-blazor" ? $"{scriptPath}syncfusion-blazor.min.js" : $"{scriptPath}{file}.min.js";
                            if (resources.JsFiles[resources.JsFiles.Length - 1] == file)
                            {   if (isOldTheme || SampleService.IsBuild)
                                {
                                    SampleService.HideSpinnerOnScriptsLoad = true;
                                }
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
                    sb.AppendLine($"<script src=\"{sbSamplesJsPath}image-editor{minExtension}.js\"></script>");
                }
                if (compKey == "ribbon")
                {
                    sb.AppendLine($"<script src=\"{sbSamplesJsPath}ribbon{minExtension}.js\"></script>");
                }
                if (compKey == "rich-text-editor")
                {
                    sb.AppendLine($"<script src=\"{sbSamplesJsPath}richtexteditor{minExtension}.js\"></script>");
                }
                if (compKey == "speech-to-text" || compKey == "ai-assistview")
                {
                    sb.AppendLine($"<script src=\"{sbSamplesJsPath}speechtotext{minExtension}.js\"></script>");
                }
                if (compKey == "ai-assistview")
                {
                    sb.AppendLine($"<script src=\"{sbSamplesJsPath}texttospeech{minExtension}.js\"></script>");
                }
                if (compKey == "diagram" || compKey == "ai-diagram")
                {
                    sb.AppendLine($"<link rel=\"stylesheet\" href=\"{sbDiagramCssPath}diagram/syncfusion-blazor-icons{minExtension}.css\" />");
                }
                if (theme.Contains("dark") || theme.Contains("fluent2-highcontrast") || theme.Contains("highcontrast"))
                {
                    sb.AppendLine($"<link rel=\"stylesheet\" href=\"{sbCommonCssPath}common/highcontrast{minExtension}.css\" />");
                    sb.AppendLine($"<link rel=\"stylesheet\" href=\"{sbCommonCssPath}common/dark-theme{minExtension}.css\" />");
                }
                // Add sf-tab, sf-toast, and sf-tooltip for the SB's common layout if syncfusion-blazor.js is not already being loaded.
                if (resources.JsFiles == null || !resources.JsFiles.Contains("syncfusion-blazor"))
                {
#if DEBUG || STAGING
                    sb.AppendLine("<script src=\"_content/syncfusion.blazor.navigations/scripts/sf-tab.min.js\"></script>");
                    sb.AppendLine("<script src=\"_content/syncfusion.blazor.popups/scripts/sf-tooltip.min.js\"></script>");
                    sb.AppendLine("<script src=\"_content/syncfusion.blazor.notifications/scripts/sf-toast.min.js\"></script>");
#else
                    sb.AppendLine($"<script src=\"{scriptPath}sf-tab.min.js\"></script>");
                    sb.AppendLine($"<script src=\"{scriptPath}sf-tooltip.min.js\"></script>");
                    sb.AppendLine($"<script src=\"{scriptPath}sf-toast.min.js\"></script>");
#endif
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