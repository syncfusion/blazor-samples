namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        internal SampleConfig()
        {
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DataGrid",
                Category = "Grids",
                Directory = "Grid",
                Type = SampleType.Updated,
                Samples = DataGrid,
                ControllerName = "DataGrid",
                DemoPath = "datagrid/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Pivot Table",
                Category = "Grids",
                Directory = "PivotView/PivotTable",
                Type = SampleType.Updated,
                Samples = PivotTable,
                ControllerName = "PivotTable",
                DemoPath = "pivot-table/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Tree Grid",
                Category = "Grids",
                Directory = "TreeGrid/TreeGrid",
                Type = SampleType.Updated,
                Samples = TreeGrid,
                ControllerName = "TreeGrid",
                CustomDocLink = "treegrid/getting-started/",
                DemoPath = "tree-grid/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Charts",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.None,
                Samples = Chart,
                ControllerName = "Chart",
                DemoPath = "chart/line"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Barcode Generator",
                Category = "Data Visualization",
                Directory = "Barcodes",
                Type = SampleType.None,
                Samples = Barcode,
                ControllerName = "Barcodes",
                CustomDocLink = "barcode/getting-started",
                DemoPath = "barcodes/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "BulletChart",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.None,
                Samples = BulletChart,
                ControllerName = "BulletChart",
                DemoPath = "bullet-chart/default-functionalities"
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
                Name = "Diagram (Classic)",
                Category = "Data Visualization",
                Directory = "Diagram",
                Type = SampleType.None,
                Samples = Diagram,
                ControllerName = "Diagram",
                IsHideFromHomePageList = true,
                DemoPath = "diagram/flowchart"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Diagram",
                Category = "Data Visualization",
                Directory = "DiagramComponent",
                Type = SampleType.Preview,
                IsPreview = true,
                Samples = DiagramComponent,
                ControllerName = "DiagramComponent",
                DemoPath = "diagramcomponent/flowchart",
                InfoTooltip = "This diagram (preview), which is a new Blazor component, provides better performance than the existing diagram control in Blazor WebAssembly App."
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "HeatMap Chart",
                Category = "Data Visualization",
                Directory = "HeatMapChart/HeatMapChart",
                Type = SampleType.Updated,
                Samples = HeatMapChart,
                ControllerName = "HeatMapChart",
                DemoPath = "heatmap-chart/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Kanban",
                Category = "Data Visualization",
                Directory = "Kanban/Kanban",
                Type = SampleType.Updated,
                Samples = Kanban,
                ControllerName = "Kanban",
                DemoPath = "kanban/overview"
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
                Name = "Maps",
                Category = "Data Visualization",
                Directory = "Maps/Maps",
                Type = SampleType.None,
                Samples = Maps,
                ControllerName = "Maps",
                DemoPath = "maps/default-functionalities"
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
                Name = "Stock Chart",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.None,
                Samples = StockChart,
                ControllerName = "StockChart",
                DemoPath = "stock-chart/stock-chart"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TreeMap",
                Category = "Data Visualization",
                Directory = "TreeMap/TreeMap",
                Type = SampleType.None,
                Samples = TreeMap,
                ControllerName = "TreeMap",
                DemoPath = "treemap/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "InPlace Editor",
                Category = "File Viewers & Editors",
                Directory = "Editors/InPlaceEditor",
                Type = SampleType.None,
                Samples = InPlaceEditor,
                ControllerName = "InPlaceEditor",
                DemoPath = "in-place-editor/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Rich Text Editor",
                Category = "File Viewers & Editors",
                Directory = "RichTextEditor/RichTextEditor",
                Type = SampleType.None,
                Samples = RichTextEditor,
                ControllerName = "RichTextEditor",
                DemoPath = "rich-text-editor/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Word Processor",
                Category = "File Viewers & Editors",
                Directory = "DocumentEditor/DocumentEditor",
                Samples = DocumentEditor,
                Type = SampleType.Updated,
                ControllerName = "DocumentEditor",
                CustomDocLink = "document-editor/getting-started/features",
                DemoPath = "document-editor/default-functionalities",
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Scheduler",
                Category = "Calendars",
                Directory = "Schedule/Scheduler",
                Type = SampleType.Updated,
                Samples = Scheduler,
                ControllerName = "Scheduler",
                DemoPath = "scheduler/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Calendar",
                Category = "Calendars",
                Directory = "Calendars/Calendar",
                Type = SampleType.Updated,
                Samples = Calendar,
                ControllerName = "Calendar",
                DemoPath = "calendar/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DatePicker",
                Category = "Calendars",
                Directory = "Calendars/DatePicker",
                Type = SampleType.Updated,
                Samples = DatePicker,
                ControllerName = "DatePicker",
                DemoPath = "datepicker/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DateRangePicker",
                Category = "Calendars",
                Directory = "Calendars/DateRangePicker",
                Type = SampleType.Updated,
                Samples = DateRangePicker,
                ControllerName = "DateRangePicker",
                DemoPath = "daterangepicker/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DateTime Picker",
                Category = "Calendars",
                Directory = "Calendars/DateTimePicker",
                Type = SampleType.Updated,
                Samples = DateTimePicker,
                ControllerName = "DateTimePicker",
                DemoPath = "datetime-picker/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Gantt Chart",
                Category = "Calendars",
                Directory = "GanttChart/GanttChart",
                Type = SampleType.Updated,
                Samples = GanttChart,
                ControllerName = "GanttChart",
                DemoPath = "gantt-chart/default-functionalities",

            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TimePicker",
                Category = "Calendars",
                Directory = "Calendars/TimePicker",
                Type = SampleType.Updated,
                Samples = TimePicker,
                ControllerName = "TimePicker",
                DemoPath = "timepicker/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Button",
                Category = "Buttons",
                Directory = "Buttons",
                Samples = Button,
                Type = SampleType.Updated,
                ControllerName = "Buttons",
                CustomDocLink = "button/getting-started",
                DemoPath = "buttons/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Button Group",
                Category = "Buttons",
                Directory = "Buttons",
                Samples = Button,
                ControllerName = "Buttons",
                CustomDocLink = "button/getting-started",
                DemoPath = "buttons/button-group"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Keyboard Navigation",
                Category = "Buttons",
                Directory = "Buttons",
                Samples = Button,
                ControllerName = "Buttons",
                CustomDocLink = "button/getting-started",
                DemoPath = "buttons/keyboard-navigation",
                IsHideFromHomePageList = true
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Chips",
                Category = "Buttons",
                Directory = "Buttons/Chips",
                Type = SampleType.Updated,
                Samples = Chips,
                ControllerName = "Chips",
                CustomDocLink = "chip/getting-started",
                DemoPath = "chips/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Dropdown Menu",
                Category = "Buttons",
                Directory = "Buttons",
                Samples = Button,
                ControllerName = "Buttons",
                CustomDocLink = "button/getting-started",
                DemoPath = "buttons/dropdown-menu"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Progress Button",
                Category = "Buttons",
                Directory = "Buttons",
                Samples = Button,
                ControllerName = "Buttons",
                CustomDocLink = "button/getting-started",
                DemoPath = "buttons/progress-button"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Split Button",
                Category = "Buttons",
                Directory = "Buttons",
                Samples = Button,
                ControllerName = "Buttons",
                CustomDocLink = "button/getting-started",
                DemoPath = "buttons/split-button"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "AutoComplete",
                Category = "DropDowns",
                Directory = "DropDowns/AutoComplete",
                Type = SampleType.Updated,
                Samples = AutoComplete,
                ControllerName = "AutoComplete",
                DemoPath = "autocomplete/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ComboBox",
                Category = "DropDowns",
                Directory = "DropDowns/ComboBox",
                Type = SampleType.Updated,
                Samples = ComboBox,
                ControllerName = "ComboBox",
                DemoPath = "combobox/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Dropdown List",
                Category = "DropDowns",
                Directory = "DropDowns/DropDownList",
                Type = SampleType.Updated,
                Samples = DropDownList,
                ControllerName = "DropDownList",
                DemoPath = "dropdown-list/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ListBox",
                Category = "DropDowns",
                Directory = "DropDowns/ListBox",
                Type = SampleType.Updated,
                Samples = ListBox,
                ControllerName = "ListBox",
                DemoPath = "listbox/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "MultiSelect Dropdown",
                Category = "DropDowns",
                Directory = "DropDowns/MultiSelect",
                Type = SampleType.Updated,
                Samples = MultiSelectDropdown,
                ControllerName = "MultiSelectDropdown",
                DemoPath = "multiselect-dropdown/default-functionalities"
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
                Type = SampleType.Updated,
                Samples = ColorPicker,
                ControllerName = "ColorPicker",
                DemoPath = "color-picker/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Color Palette ",
                Category = "Inputs",
                Directory = "Inputs/ColorPicker",
                Type = SampleType.Updated,
                Samples = ColorPicker,
                ControllerName = "ColorPicker",
                DemoPath = "color-picker/inline"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "File Upload",
                Category = "Inputs",
                Directory = "Inputs/Uploader",
                Type = SampleType.Updated,
                Samples = FileUpload,
                ControllerName = "FileUpload",
                DemoPath = "file-upload/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Input Mask",
                Category = "Inputs",
                Directory = "Inputs/MaskedTextBox",
                Type = SampleType.Updated,
                Samples = InputMask,
                ControllerName = "InputMask",
                DemoPath = "input-mask/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Numeric Textbox",
                Category = "Inputs",
                Directory = "Inputs/NumericTextBox",
                Type = SampleType.Updated,
                Samples = NumericTextbox,
                ControllerName = "NumericTextBox",
                DemoPath = "numeric-textbox/default-functionalities"
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
                Name = "Range Slider",
                Category = "Inputs",
                Directory = "Inputs/RangeSlider",
                Type = SampleType.Updated,
                Samples = RangeSlider,
                ControllerName = "RangeSlider",
                DemoPath = "range-slider/default"
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
                Name = "Toggle Switch Button",
                Category = "Inputs",
                Directory = "Buttons",
                Type = SampleType.None,
                Samples = Button,
                ControllerName = "Buttons",
                DemoPath = "buttons/toggle-switch-button"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Accordion",
                Category = "Navigation",
                Directory = "Navigations/Accordion",
                Type = SampleType.Updated,
                Samples = Accordion,
                ControllerName = "Accordion",
                DemoPath = "accordion/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Breadcrumb",
                Category = "Navigation",
                Directory = "Navigations/Breadcrumb",
				IsPreview = true,
                Type = SampleType.Preview,
                Samples = BreadCrumb,
                ControllerName = "Breadcrumb",
                DemoPath = "breadcrumb/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Context Menu",
                Category = "Navigation",
                Directory = "Navigations/ContextMenu",
                Type = SampleType.Updated,
                Samples = ContextMenu,
                ControllerName = "ContextMenu",
                DemoPath = "context-menu/default-functionalities",
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "File Manager",
                Category = "Navigation",
                Directory = "Navigations/FileManager",
                Type = SampleType.Updated,
                Samples = FileManager,
                ControllerName = "FileManager",
                DemoPath = "file-manager/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "MenuBar",
                Category = "Navigation",
                Directory = "Navigations/MenuBar",
                Type = SampleType.Updated,
                Samples = MenuBar,
                ControllerName = "MenuBar",
                DemoPath = "menu-bar/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Sidebar",
                Category = "Navigation",
                Directory = "Navigations/Sidebar",
                Type = SampleType.Updated,
                Samples = Sidebar,
                ControllerName = "Sidebar",
                DemoPath = "sidebar/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Tabs",
                Category = "Navigation",
                Directory = "Navigations/Tabs",
                Type = SampleType.Updated,
                Samples = Tabs,
                ControllerName = "Tabs",
                DemoPath = "tabs/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Toolbar",
                Category = "Navigation",
                Directory = "Navigations/Toolbar",
                Type = SampleType.Updated,
                Samples = Toolbar,
                ControllerName = "Toolbar",
                DemoPath = "toolbar/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TreeView",
                Category = "Navigation",
                Directory = "Navigations/TreeView",
                Type = SampleType.Updated,
                Samples = TreeView,
                ControllerName = "TreeView",
                DemoPath = "treeview/default-functionalities"
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
                Name = "Dashboard Layout",
                Category = "Layout",
                Directory = "Layouts/DashboardLayout",
                Type = SampleType.Updated,
                Samples = DashboardLayout,
                ControllerName = "DashboardLayout",
                DemoPath = "dashboard-layout/overview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Dialog",
                Category = "Layout",
                Directory = "Popups/Dialog",
                Type = SampleType.None,
                Samples = Dialog,
                ControllerName = "Dialog",
                DemoPath = "dialog/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ListView",
                Category = "Layout",
                Directory = "Layouts/ListView",
                Type = SampleType.Updated,
                Samples = ListView,
                ControllerName = "ListView",
                DemoPath = "listview/default-functionalities"
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
                Name = "Tooltip",
                Category = "Layout",
                Directory = "Layouts/Tooltip",
                Type = SampleType.Updated,
                Samples = Tooltip,
                ControllerName = "Tooltip",
                DemoPath = "tooltip/default"
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
                Name = "Query Builder",
                Category = "Forms",
                Directory = "Forms/QueryBuilder",
                Type = SampleType.None,
                Samples = QueryBuilder,
                ControllerName = "QueryBuilder",
                DemoPath = "query-builder/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "PDF Viewer",
                Category = "File Viewers & Editors",
                Directory = "Viewer/PdfViewer",
                Samples = PDFViewer,
                ControllerName = "PdfViewer",
                CustomDocLink = "pdfviewer/getting-started",
                DemoPath = "pdf-viewer/default-functionalities"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DocIO",
                Category = "File Formats FrameWorks",
                Directory = "FileFormats/DocIO",
                Type = SampleType.Updated,
                Samples = DocIO,
                ControllerName = "DocIO",
                DemoPath = "docio/hello-world"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "PDF",
                Category = "File Formats FrameWorks",
                Directory = "FileFormats/PDF",
                Type = SampleType.None,
                Samples = PDF,
                ControllerName = "PDF",
                DemoPath = "pdf/hello-world"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Presentation",
                Category = "File Formats FrameWorks",
                Directory = "FileFormats/Presentation",
                Type = SampleType.Updated,
                Samples = Presentation,
                ControllerName = "Presentation",
                DemoPath = "presentation/getting-started"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "XlsIO",
                Category = "File Formats FrameWorks",
                Directory = "FileFormats/XlsIO",
                Samples = XlsIO,
                ControllerName = "XlsIO",
                DemoPath = "xlsio/create-excel"
            });

        }
    }
}
