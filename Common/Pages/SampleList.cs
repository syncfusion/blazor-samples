#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        internal SampleConfig()
        {
#if SERVER
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Smart Paste Button",
                Category = "Smart Components",
                Directory = "AISamples",
                Samples = AISmartPaste,
                ControllerName = "AISmartPaste",
                DemoPath = "ai-smartpaste/annotations",
                ComponentIconName = "data_form"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Smart TextArea",
                Category = "Smart Components",
                Directory = "AISamples",
                Samples = AISmartTextArea,
                ControllerName = "AISmartTextArea",
                DemoPath = "ai-smarttextarea/default",
                ComponentIconName = "textarea"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "AI-Powered Samples",
                Category = "Smart AI Solutions",
                Directory = "AISamples",
                Samples = SmartAISolutions,
                ControllerName = "AI",
                DemoPath = "ai-datagrid/semantic-filtering",
                ComponentIconName = "combobox",
                IsHideFromHomePageList = true
            });
#endif
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DataGrid",
                Category = "Data Management",
                Directory = "Grid",
                Type = SampleType.Updated,
                Samples = DataGrid,
                ControllerName = "DataGrid",
                DemoPath = "datagrid/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Pivot Table",
                Category = "Data Management",
                Directory = "PivotView/PivotTable",
                Type = SampleType.Updated,
                Samples = PivotTable,
                ControllerName = "PivotTable",
                DemoPath = "pivot-table/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Tree Grid",
                Category = "Data Management",
                Directory = "TreeGrid/TreeGrid",
                Samples = TreeGrid,
                Type = SampleType.Updated,
                ControllerName = "TreeGrid",
                CustomDocLink = "treegrid/getting-started/",
                DemoPath = "tree-grid/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Query Builder",
                Category = "Data Management",
                Directory = "Forms/QueryBuilder",
                Samples = QueryBuilder,
                ControllerName = "QueryBuilder",
#if SERVER
                Type = SampleType.Updated,
#endif
                DemoPath = "query-builder/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Pager",
                Category = "Data Management",
                Directory = "Navigation/Pager",
                Type = SampleType.None,
                Samples = Pager,
                ControllerName = "Pager",
                DemoPath = "pager/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ListView",
                Category = "Data Management",
                Directory = "Layouts/ListView",
                Type = SampleType.None,
                Samples = ListView,
                ControllerName = "ListView",
                DemoPath = "listview/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Charts",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.Updated,
                Samples = Chart,
                ControllerName = "Chart",
                DemoPath = "chart/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "3D Chart",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.None,
                Samples = Chart3D,
                ControllerName = "Chart3D",
                DemoPath = "chart-3d/column"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Stock Chart",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.Updated,
                Samples = StockChart,
                ControllerName = "StockChart",
                DemoPath = "stock-chart/stock-chart"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Circular Gauge",
                Category = "Data Visualization",
                Directory = "CircularGauge",
                Type = SampleType.None,
                Samples = CircularGauge,
                ControllerName = "CircularGauge",
                DemoPath = "circular-gauge/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Linear Gauge",
                Category = "Data Visualization",
                Directory = "LinearGauge/LinearGauge",
                Type = SampleType.None,
                Samples = LinearGauge,
                ControllerName = "LinearGauge",
                DemoPath = "linear-gauge/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "HeatMap Chart",
                Category = "Data Visualization",
                Directory = "HeatMapChart/HeatMapChart",
                Samples = HeatMapChart,
                ControllerName = "HeatMapChart",
                Type = SampleType.None,
                DemoPath = "heatmap-chart/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Range Selector",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.None,
                Samples = RangeNavigator,
                ControllerName = "RangeSelector",
                DemoPath = "range-selector/range-navigator"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Smith Chart",
                Category = "Data Visualization",
                Directory = "Charts/SmithChart",
                Type = SampleType.None,
                Samples = SmithChart,
                ControllerName = "SmithChart",
                DemoPath = "smith-chart/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Sparkline Charts",
                Category = "Data Visualization",
                Directory = "Charts/Sparkline",
                Type = SampleType.None,
                Samples = SparklineCharts,
                ControllerName = "Sparkline",
                DemoPath = "sparkline/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Barcode Generator",
                Category = "Data Visualization",
                Directory = "Barcodes",
                Samples = Barcode,
                ControllerName = "Barcodes",
                CustomDocLink = "barcode/getting-started",
                DemoPath = "barcodes/default-functionalities",
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Sankey",
                Category = "Data Visualization",
                Directory = "Charts/Sankey",
                Type = SampleType.None,
                Samples = Sankey,
                ControllerName = "Sankey",
                DemoPath = "sankey/default"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Bullet Chart",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.None,
                Samples = BulletChart,
                ControllerName = "BulletChart",
                DemoPath = "bullet-chart/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Arc Gauge",
                Category = "Data Visualization",
                Directory = "ArcGauge",
                Samples = ArcGauge,
                ControllerName = "ArcGauge",
                DemoPath = "arc-gauge/default"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Diagram",
                Category = "Diagrams and Maps",
                Directory = "Diagram",
                Samples = Diagram,
                Type = SampleType.Updated,
                ControllerName = "Diagram",
                DemoPath = "diagram/flowchart",
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Maps",
                Category = "Diagrams and Maps",
                Directory = "Maps/Maps",
                Samples = Maps,
                ControllerName = "Maps",
                DemoPath = "maps/default-functionalities",
#if SERVER
                Type = SampleType.Updated
#else
                Type = SampleType.None
#endif
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TreeMap",
                Category = "Diagrams and Maps",
                Directory = "TreeMap/TreeMap",
                Type = SampleType.None,
                Samples = TreeMap,
                ControllerName = "TreeMap",
                DemoPath = "treemap/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Rich Text Editor",
                Category = "File Viewers & Editors",
                Directory = "RichTextEditor/RichTextEditor",
                Samples = RichTextEditor,
                ControllerName = "RichTextEditor",
                DemoPath = "rich-text-editor/overview",
                Type = SampleType.Updated
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Image Editor",
                Category = "File Viewers & Editors",
                Directory = "ImageEditor/ImageEditor",
                Samples = ImageEditor,
                ControllerName = "ImageEditor",
                DemoPath = "image-editor/default-functionalities",
                ComponentIconName = "image_editor"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Markdown Editor",
                Category = "File Viewers & Editors",
                Directory = "RichTextEditor/MarkdownEditor",
                Samples = MarkdownEditor,
                ControllerName = "MarkdownEditor",
                DemoPath = "markdown-editor/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Scheduler",
                Category = "Scheduling & Calendars",
                Directory = "Schedule/Scheduler",
                Samples = Scheduler,
                ControllerName = "Scheduler",
#if SERVER
                Type = SampleType.Updated,
#endif
                DemoPath = "scheduler/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Gantt Chart",
                Category = "Scheduling & Calendars",
                Directory = "GanttChart/GanttChart",
                Type = SampleType.Updated,
                Samples = GanttChart,
                ControllerName = "GanttChart",
                DemoPath = "gantt-chart/overview",
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Calendar",
                Category = "Scheduling & Calendars",
                Directory = "Calendars/Calendar",
                Type = SampleType.None,
                Samples = Calendar,
                ControllerName = "Calendar",
                DemoPath = "calendar/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DatePicker",
                Category = "Scheduling & Calendars",
                Directory = "Calendars/DatePicker",
                Type = SampleType.None,
                Samples = DatePicker,
                ControllerName = "DatePicker",
                DemoPath = "datepicker/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DateRangePicker",
                Category = "Scheduling & Calendars",
                Directory = "Calendars/DateRangePicker",
                Type = SampleType.None,
                Samples = DateRangePicker,
                ControllerName = "DateRangePicker",
                DemoPath = "daterangepicker/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DateTime Picker",
                Category = "Scheduling & Calendars",
                Directory = "Calendars/DateTimePicker",
                Type = SampleType.None,
                Samples = DateTimePicker,
                ControllerName = "DateTimePicker",
                DemoPath = "datetime-picker/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TimePicker",
                Category = "Scheduling & Calendars",
                Directory = "Calendars/TimePicker",
                Type = SampleType.None,
                Samples = TimePicker,
                ControllerName = "TimePicker",
                DemoPath = "timepicker/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "File Manager",
                Category = "File Management",
                Directory = "Navigations/FileManager",
                Samples = FileManager,
                ControllerName = "FileManager",
#if SERVER
                Type = SampleType.Updated,
#endif
                DemoPath = "file-manager/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "File Upload",
                Category = "File Management",
                Directory = "Inputs/Uploader",
                Type = SampleType.None,
                Samples = FileUpload,
                ControllerName = "FileUpload",
                DemoPath = "file-upload/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TreeView",
                Category = "Navigation",
                Directory = "Navigations/TreeView",
                Samples = TreeView,
                ControllerName = "TreeView",
                DemoPath = "treeview/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Sidebar",
                Category = "Navigation",
                Directory = "Navigations/Sidebar",
                Type = SampleType.None,
                Samples = Sidebar,
                ControllerName = "Sidebar",
                DemoPath = "sidebar/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Tabs",
                Category = "Navigation",
                Directory = "Navigations/Tabs",
                Samples = Tabs,
                ControllerName = "Tabs",
                DemoPath = "tabs/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Toolbar",
                Category = "Navigation",
                Directory = "Navigations/Toolbar",
                Samples = Toolbar,
                ControllerName = "Toolbar",
                DemoPath = "toolbar/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Context Menu",
                Category = "Navigation",
                Directory = "Navigations/ContextMenu",
                Samples = ContextMenu,
                ControllerName = "ContextMenu",
                DemoPath = "context-menu/default-functionalities",
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Ribbon",
                Category = "Navigation",
                Directory = "Navigations/Ribbon",
                Samples = Ribbon,
                ControllerName = "Ribbon",
                DemoPath = "ribbon/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Accordion",
                Category = "Navigation",
                Directory = "Navigations/Accordion",
                Samples = Accordion,
                ControllerName = "Accordion",
                DemoPath = "accordion/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "AppBar",
                Category = "Navigation",
                Directory = "Navigations/AppBar",
                Samples = AppBar,
                ControllerName = "AppBar",
                DemoPath = "appbar/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Breadcrumb",
                Category = "Navigation",
                Directory = "Navigations/Breadcrumb",
                Samples = BreadCrumb,
                ControllerName = "Breadcrumb",
                DemoPath = "breadcrumb/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Carousel",
                Category = "Navigation",
                Directory = "Navigations/Carousel",
                Samples = Carousel,
                ControllerName = "Carousel",
                DemoPath = "carousel/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "MenuBar",
                Category = "Navigation",
                Directory = "Navigations/MenuBar",
                Samples = MenuBar,
                ControllerName = "MenuBar",
                DemoPath = "menu-bar/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Stepper",
                Category = "Navigation",
                Directory = "Navigations/Stepper",
                Samples = Stepper,
                ControllerName = "Stepper",
                DemoPath = "stepper/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Range Slider",
                Category = "Inputs",
                Directory = "Inputs/RangeSlider",
                Type = SampleType.None,
                Samples = RangeSlider,
                ControllerName = "RangeSlider",
                DemoPath = "range-slider/default"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Numeric Textbox",
                Category = "Inputs",
                Directory = "Inputs/NumericTextBox",
                Type = SampleType.None,
                Samples = NumericTextbox,
                ControllerName = "NumericTextBox",
                DemoPath = "numeric-textbox/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "OTP Input",
                Category = "Inputs",
                Directory = "Inputs/OtpInput",
                Samples = OtpInput,
                ControllerName = "OtpInput",
                DemoPath = "otp-input/default-functionalities",
                ComponentIconName = "otpinput"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TextBox",
                Category = "Inputs",
                Directory = "Inputs",
                Type = SampleType.None,
                Samples = TextBox,
                ControllerName = "TextBox",
                DemoPath = "textbox/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TextArea",
                Category = "Inputs",
                Directory = "Inputs",
                Type = SampleType.None,
                Samples = TextArea,
                ControllerName = "TextArea",
                DemoPath = "textarea/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Input Mask",
                Category = "Inputs",
                Directory = "Inputs/MaskedTextBox",
                Type = SampleType.None,
                Samples = InputMask,
                ControllerName = "InputMask",
                DemoPath = "input-mask/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Radio Button",
                Category = "Inputs",
                Directory = "Buttons",
                Type = SampleType.None,
                Samples = Button,
                ControllerName = "Buttons",
                DemoPath = "buttons/radio-button"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Checkbox",
                Category = "Inputs",
                Directory = "Buttons",
                Type = SampleType.None,
                Samples = Button,
                ControllerName = "Buttons",
                DemoPath = "buttons/checkbox"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Color Picker",
                Category = "Inputs",
                Directory = "Inputs/ColorPicker",
                Samples = ColorPicker,
                ControllerName = "ColorPicker",
                DemoPath = "color-picker/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Color Palette ",
                Category = "Inputs",
                Directory = "Inputs/ColorPicker",
                Samples = ColorPicker,
                ControllerName = "ColorPicker",
                DemoPath = "color-picker/inline"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Signature",
                Category = "Inputs",
                Directory = "Inputs/Signature",
                Samples = Signature,
                ControllerName = "Signature",
                DemoPath = "signature/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Rating",
                Category = "Inputs",
                Directory = "Inputs/Rating",
                Type = SampleType.None,
                Samples = Rating,
                ControllerName = "Rating",
                DemoPath = "rating/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Speech To Text",
                Category = "Inputs",
                Directory = "Inputs/SpeechToText",
                Samples = SpeechToText,
                ControllerName = "SpeechToText",
                DemoPath = "speech-to-text/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "InPlace Editor",
                Category = "Inputs",
                Directory = "Editors/InPlaceEditor",
                Type = SampleType.None,
                Samples = InPlaceEditor,
                ControllerName = "InPlaceEditor",
                DemoPath = "in-place-editor/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Dropdown List",
                Category = "DropDowns",
                Directory = "DropDowns/DropDownList",
                Type = SampleType.None,
                Samples = DropDownList,
                ControllerName = "DropDownList",
                DemoPath = "dropdown-list/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Dropdown Tree",
                Category = "DropDowns",
                Directory = "DropDowns/DropDownTree",
                Type = SampleType.None,
                Samples = DropDownTree,
                ControllerName = "DropDownTree",
                DemoPath = "dropdown-tree/default-functionalities",
                ComponentIconName = "dropdowntree"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "MultiSelect Dropdown",
                Category = "DropDowns",
                Directory = "DropDowns/MultiSelect",
                Type = SampleType.None,
                Samples = MultiSelectDropdown,
                ControllerName = "MultiSelectDropdown",
                DemoPath = "multiselect-dropdown/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ListBox",
                Category = "DropDowns",
                Directory = "DropDowns/ListBox",
                Samples = ListBox,
                ControllerName = "ListBox",
                DemoPath = "listbox/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ComboBox",
                Category = "DropDowns",
                Directory = "DropDowns/ComboBox",
                Type = SampleType.None,
                Samples = ComboBox,
                ControllerName = "ComboBox",
                DemoPath = "combobox/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "AutoComplete",
                Category = "DropDowns",
                Directory = "DropDowns/AutoComplete",
                Type = SampleType.None,
                Samples = AutoComplete,
                ControllerName = "AutoComplete",
                DemoPath = "autocomplete/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Mention",
                Category = "DropDowns",
                Directory = "DropDowns/Mention",
                Type = SampleType.None,
                Samples = Mention,
                ControllerName = "Mention",
                DemoPath = "mention/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "MultiColumn ComboBox",
                Category = "DropDowns",
                Directory = "DropDowns/MultiColumnComboBox",
                Type = SampleType.None,
                Samples = MultiColumnComboBox,
                ControllerName = "MultiColumnComboBox",
                DemoPath = "multicolumn-combobox/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Dialog",
                Category = "Layout",
                Directory = "Popups/Dialog",
                Samples = Dialog,
                ControllerName = "Dialog",
                DemoPath = "dialog/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Tooltip",
                Category = "Layout",
                Directory = "Layouts/Tooltip",
                Type = SampleType.None,
                Samples = Tooltip,
                ControllerName = "Tooltip",
                DemoPath = "tooltip/default"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Splitter",
                Category = "Layout",
                Directory = "Layouts/Splitter",
                Samples = Splitter,
                Type = SampleType.None,
                ControllerName = "Splitter",
                DemoPath = "splitter/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Dashboard Layout",
                Category = "Layout",
                Directory = "Layouts/DashboardLayout",
                Type = SampleType.None,
                Samples = DashboardLayout,
                ControllerName = "DashboardLayout",
                DemoPath = "dashboard-layout/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Card",
                Category = "Layout",
                Directory = "Cards",
                Type = SampleType.None,
                Samples = Card,
                ControllerName = "Card",
                DemoPath = "card/basic-card"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Media Query",
                Category = "Layout",
                Directory = "MediaQuery",
                Type = SampleType.None,
                Samples = MediaQuery,
                ControllerName = "MediaQuery",
                DemoPath = "media-query/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Timeline",
                Category = "Layout",
                Directory = "Layouts/Timeline",
                Samples = Timeline,
                ControllerName = "Timeline",
                DemoPath = "timeline/default-functionalities",
                ComponentIconName = "timeline"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Avatar",
                Category = "Layout",
                Directory = "Layouts/Avatar",
                Type = SampleType.None,
                Samples = Avatar,
                ControllerName = "Avatar",
                DemoPath = "avatar/defaultfunctionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Predefined Dialogs",
                Category = "Layout",
                Directory = "Popups/PredefinedDialogs",
                Samples = PredefinedDialogs,
                ControllerName = "PredefinedDialogs",
                DemoPath = "predefined-dialogs/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Dropdown Menu",
                Category = "Buttons & Actions",
                Directory = "Buttons",
                Samples = Button,
                ControllerName = "Buttons",
                CustomDocLink = "button/getting-started",
                DemoPath = "buttons/dropdown-menu"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Split Button",
                Category = "Buttons & Actions",
                Directory = "Buttons",
                Samples = Button,
                ControllerName = "Buttons",
                CustomDocLink = "button/getting-started",
                DemoPath = "buttons/split-button"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Toggle Switch Button",
                Category = "Buttons & Actions",
                Directory = "Buttons",
                Type = SampleType.None,
                Samples = Button,
                ControllerName = "Buttons",
                DemoPath = "buttons/toggle-switch-button"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Button Group",
                Category = "Buttons & Actions",
                Directory = "Buttons",
                Samples = Button,
                ControllerName = "Buttons",
                CustomDocLink = "button/getting-started",
                DemoPath = "buttons/button-group"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Button",
                Category = "Buttons & Actions",
                Directory = "Buttons",
                Samples = Button,
                ControllerName = "Buttons",
                CustomDocLink = "button/getting-started",
                DemoPath = "buttons/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Progress Button",
                Category = "Buttons & Actions",
                Directory = "Buttons",
                Samples = Button,
                ControllerName = "Buttons",
                CustomDocLink = "button/getting-started",
                DemoPath = "buttons/progress-button"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Chips",
                Category = "Buttons & Actions",
                Directory = "Buttons/Chips",
                Type = SampleType.None,
                Samples = Chips,
                ControllerName = "Chips",
                CustomDocLink = "chip/getting-started",
                DemoPath = "chips/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Floating Action Button",
                Category = "Buttons & Actions",
                Directory = "Buttons/FAB",
                Type = SampleType.None,
                Samples = FAB,
                ControllerName = "FAB",
                DemoPath = "fab/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Speed Dial",
                Category = "Buttons & Actions",
                Directory = "Buttons/SpeedDial",
                Type = SampleType.None,
                Samples = SpeedDial,
                ControllerName = "SpeedDial",
                DemoPath = "speeddial/defaultfunctionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "AI AssistView",
                Category = "Interactive Chat",
                Directory = "InteractiveChat/AIAssistView",
                Samples = AIAssistView,
                ControllerName = "AIAssistView",
                DemoPath = "ai-assistview/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Chat UI",
                Category = "Interactive Chat",
                Directory = "InteractiveChat/ChatUI",
                Samples = ChatUI,
                ControllerName = "ChatUI",
                DemoPath = "chat-ui/default-functionalities",
                Type = SampleType.Preview,
                IsPreview = true
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Data Form",
                Category = "Forms",
                Directory = "Forms/DataForm",
                Samples = DataForm,
                ControllerName = "DataForm",
                DemoPath = "data-form/default-functionalities",
                Type = SampleType.None,
                ComponentIconName = "data_form",
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Progress Bar",
                Category = "Notifications",
                Directory = "ProgressBar",
                Type = SampleType.None,
                Samples = ProgressBar,
                ControllerName = "ProgressBar",
                DemoPath = "progress-bar/linear"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Toast",
                Category = "Notifications",
                Directory = "Notifications/Toast",
                Type = SampleType.None,
                Samples = Toast,
                ControllerName = "Toast",
                DemoPath = "toast/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Badge",
                Category = "Notifications",
                Directory = "Notifications/Badge",
                Type = SampleType.None,
                Samples = Badge,
                ControllerName = "Badge",
                DemoPath = "badge/defaultfunctionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Message",
                Category = "Notifications",
                Directory = "Notifications/Message",
                Samples = Message,
                ControllerName = "Message",
                DemoPath = "message/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Spinner",
                Category = "Notifications",
                Directory = "Notifications/Spinner",
                Type = SampleType.None,
                Samples = Spinner,
                ControllerName = "Spinner",
                DemoPath = "spinner/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Skeleton",
                Category = "Notifications",
                Directory = "Notifications/Skeleton",
                Type = SampleType.None,
                Samples = Skeleton,
                ControllerName = "Skeleton",
                DemoPath = "skeleton/defaultfunctionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Kanban",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Samples = Kanban,
                ControllerName = "Kanban",
#if SERVER
                Type = SampleType.Updated,
#endif
                DemoPath = "kanban/overview"
            });
        }
    }
}

