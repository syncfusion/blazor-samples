using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_samples
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
                Type = SampleType.None,
                Order = 01,
                UID = 002,
                Samples = DataGrid,
                ControllerName = "DataGrid"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Tree Grid",
                Category = "Grids",
                Directory = "TreeGrid/TreeGrid",
                UID = 006,
                Order = 02,
                Samples = TreeGrid,
                ControllerName = "TreeGrid"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Pivot Table",
                Category = "Grids",
                Directory = "PivotView/PivotTable",
                Type = SampleType.Updated,
                UID = 027,
                Order = 03,
                Samples = PivotTable,
                ControllerName = "PivotTable"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Chart",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.Updated,
                UID = 005,
                Order = 01,
                Samples = Chart,
                ControllerName = "Chart"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "StockChart",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.None,
                UID = 006,
                Order = 01,
                Samples = StockChart,
                ControllerName = "StockChart"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "BulletChart",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.Updated,
                UID = 029,
                Order = 01,
                Samples = BulletChart,
                ControllerName = "BulletChart"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Circular Gauge",
                Category = "Data Visualization",
                Directory = "CircularGauge",
                Type = SampleType.Updated,
                UID = 003,
                Order = 03,
                Samples = CircularGauge,
                ControllerName = "CircularGauge"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Linear Gauge",
                Category = "Data Visualization",
                Directory = "LinearGauge/LinearGauge",
                Type = SampleType.Updated,
                UID = 004,
                Order = 04,
                Samples = LinearGauge,
                ControllerName = "LinearGauge"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Diagram",
                Category = "Data Visualization",
                Directory = "Diagram",
                Type = SampleType.None,
                UID = 005,
                Order = 05,
                Samples = Diagram,
                ControllerName = "Diagram"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Sparkline Charts",
                Category = "Data Visualization",
                Directory = "Charts/Sparkline",
                Type = SampleType.None,
                UID = 010,
                Order = 10,
                Samples = SparklineCharts,
                ControllerName = "Sparkline"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TreeMap",
                Category = "Data Visualization",
                Directory = "TreeMap/TreeMap",
                Type = SampleType.None,
                UID = 011,
                Order = 11,
                Samples = TreeMap,
                ControllerName = "TreeMap"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Maps",
                Category = "Data Visualization",
                Directory = "Maps/Maps",
                Type = SampleType.Updated,
                UID = 007,
                Order = 07,
                Samples = Maps,
                ControllerName = "Maps"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "RangeNavigator",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.None,
                UID = 006,
                Order = 01,
                Samples = RangeNavigator,
                ControllerName = "RangeSelector"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Smith Chart",
                Category = "Data Visualization",
                Directory = "Charts/SmithChart",
                Type = SampleType.None,
                UID = 009,
                Order = 09,
                Samples = SmithChart,
                ControllerName = "SmithChart"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Barcode",
                Category = "Data Visualization",
                Directory = "Barcodes",
                Type = SampleType.None,
                UID = 005,
                Order = 05,
                Samples = Barcode,
                ControllerName = "Barcodes"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ProgressBar",
                Category = "Notifications",
                Directory = "ProgressBar",
                Type = SampleType.Preview,
                UID = 031,
                Order = 13,
                Samples = ProgressBar,
                ControllerName = "ProgressBar"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Button",
                Category = "Editors",
                Directory = "Buttons",
                Type = SampleType.None,
                UID = 003,
                Order = 03,
                Samples = Button,
                ControllerName = "Buttons"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Calendar",
                Category = "Calendars",
                Directory = "Calendars/Calendar",
                Type = SampleType.None,
                UID = 014,
                Order = 02,
                Samples = Calendar,
                ControllerName = "Calendar"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DatePicker",
                Category = "Calendars",
                Directory = "Calendars/DatePicker",
                Type = SampleType.None,
                UID = 015,
                Order = 03,
                Samples = DatePicker,
                ControllerName = "DatePicker"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DateTime Picker",
                Category = "Calendars",
                Directory = "Calendars/DateTimePicker",
                Type = SampleType.Preview,
                UID = 016,
                Order = 06,
                Samples = DateTimePicker,
                ControllerName = "DateTimePicker"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TimePicker",
                Category = "Calendars",
                Directory = "Calendars/TimePicker",
                Type = SampleType.None,
                UID = 017,
                Order = 17,
                Samples = TimePicker,
                ControllerName = "TimePicker"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DateRangePicker",
                Category = "Calendars",
                Directory = "Calendars/DateRangePicker",
                Type = SampleType.Preview,
                UID = 018,
                Order = 04,
                Samples = DateRangePicker,
                ControllerName = "DateRangePicker"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Dropdown List",
                Category = "DropDowns",
                Directory = "DropDowns/DropDownList",
                Type = SampleType.None,
                UID = 019,
                Order = 03,
                Samples = DropDownList,
                ControllerName = "DropDownList"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ComboBox",
                Category = "DropDowns",
                Directory = "DropDowns/ComboBox",
                Type = SampleType.None,
                UID = 020,
                Order = 02,
                Samples = ComboBox,
                ControllerName = "ComboBox"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "AutoComplete",
                Category = "DropDowns",
                Directory = "DropDowns/AutoComplete",
                Type = SampleType.None,
                UID = 021,
                Order = 01,
                Samples = AutoComplete,
                ControllerName = "AutoComplete"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "MultiSelect Dropdown",
                Category = "DropDowns",
                Directory = "DropDowns/MultiSelect",
                Type = SampleType.Preview,
                UID = 022,
                Order = 04,
                Samples = MultiSelectDropdown,
                ControllerName = "MultiSelectDropdown"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ListBox",
                Category = "DropDowns",
                Directory = "DropDowns/ListBox",
                Type = SampleType.None,
                UID = 028,
                Order = 05,
                Samples = ListBox,
                ControllerName = "ListBox"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Sidebar",
                Category = "Navigations",
                Directory = "Navigations/Sidebar",
                Type = SampleType.None,
                UID = 005,
                Order = 04,
                Samples = Sidebar,
                ControllerName = "Sidebar"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Accordion",
                Category = "Navigations",
                Directory = "Navigations/Accordion",
                Type = SampleType.None,
                UID = 005,
                Order = 01,
                Samples = Accordion,
                ControllerName = "Accordion"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Toolbar",
                Category = "Navigations",
                Directory = "Navigations/Toolbar",
                Type = SampleType.None,
                UID = 005,
                Order = 06,
                Samples = Toolbar,
                ControllerName = "Toolbar"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Tabs",
                Category = "Navigations",
                Directory = "Navigations/Tabs",
                Type = SampleType.None,
                UID = 005,
                Order = 05,
                Samples = Tabs,
                ControllerName = "Tabs"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Toast",
                Category = "Notifications",
                Directory = "Notifications/Toast",
                UID = 016,
                Order = 16,
                Samples = Toast,
                ControllerName = "Toast"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Spinner",
                Category = "Notifications",
                Directory = "Notifications/Spinner",
                Type = SampleType.None,
                UID = 011,
                Order = 02,
                Samples = Spinner,
                ControllerName = "Spinner"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TextBox",
                Category = "Inputs",
                Directory = "Inputs",
                Type = SampleType.None,
                UID = 004,
                Order = 01,
                Samples = TextBox,
                ControllerName = "TextBox"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Dashboard Layout",
                Category = "Layout",
                Directory = "Layouts/DashboardLayout",
                Type = SampleType.None,
                UID = 028,
                Order = 01,
                Samples = DashboardLayout,
                ControllerName = "DashboardLayout"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Dialog",
                Category = "Layout",
                Directory = "Popups/Dialog",
                Type = SampleType.None,
                UID = 008,
                Order = 02,
                Samples = Dialog,
                ControllerName = "Dialog"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ListView",
                Category = "Layout",
                Directory = "Layouts/ListView",
                Type = SampleType.None,
                UID = 005,
                Order = 01,
                Samples = ListView,
                ControllerName = "ListView"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Tooltip",
                Category = "Layout",
                Directory = "Layouts/Tooltip",
                Type = SampleType.None,
                UID = 022,
                Order = 22,
                Samples = Tooltip,
                ControllerName = "Tooltip"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Splitter",
                Category = "Layout",
                Directory = "Layouts/Splitter",
                UID = 010,
                Order = 10,
                Samples = Splitter,
                ControllerName = "Splitter"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Card",
                Category = "Layout",
                Directory = "Cards",
                Type = SampleType.Preview,
                UID = 230,
                Order = 01,
                Samples = Card,
                ControllerName = "Card"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Query Builder",
                Category = "Forms",
                Directory = "Forms/QueryBuilder",
                Type = SampleType.Preview,
                UID = 026,
                Order = 26,
                Samples = QueryBuilder,
                ControllerName = "QueryBuilder"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "PDF Viewer",
                Category = "Viewer",
                Directory = "Viewer/PdfViewer",
                UID = 006,
                Order = 04,
                Samples = PDFViewer,
                ControllerName = "PdfViewer"
            });

            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Document Editor",
                Category = "Editors",
                Directory = "DocumentEditor/DocumentEditor",
                Type = SampleType.Updated,
                UID = 004,
                Order = 02,
                Samples = DocumentEditor,
                ControllerName = "DocumentEditor"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "InPlace Editor",
                Category = "Editors",
                Directory = "Editors/InPlaceEditor",
                Type = SampleType.None,
                UID = 009,
                Order = 09,
                Samples = InPlaceEditor,
                ControllerName = "InPlaceEditor"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Scheduler",
                Category = "Calendars",
                Directory = "Schedule/Scheduler",
                Type = SampleType.Updated,
                UID = 005,
                Order = 01,
                Samples = Scheduler,
                ControllerName = "Scheduler"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Gantt Chart",
                Category = "Calendars",
                Directory = "GanttChart/GanttChart",
                Type = SampleType.Preview,
                UID = 005,
                Order = 01,
                Samples = GanttChart,
                ControllerName = "GanttChart"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Rich Text Editor",
                Category = "Editors",
                Directory = "RichTextEditor/RichTextEditor",
                Type = SampleType.None,
                UID = 005,
                Order = 01,
                Samples = RichTextEditor,
                ControllerName = "RichTextEditor"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Numeric Textbox",
                Category = "Inputs",
                Directory = "Inputs/NumericTextBox",
                Type = SampleType.None,
                UID = 011,
                Order = 03,
                Samples = NumericTextbox,
                ControllerName = "NumericTextBox"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Input Mask",
                Category = "Inputs",
                Directory = "Inputs/MaskedTextBox",
                Type = SampleType.Preview,
                UID = 012,
                Order = 02,
                Samples = InputMask,
                ControllerName = "InputMask"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "File Upload",
                Category = "Inputs",
                Directory = "Inputs/Uploader",
                Type = SampleType.None,
                UID = 013,
                Order = 05,
                Samples = FileUpload,
                ControllerName = "FileUpload"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Color Picker",
                Category = "Inputs",
                Directory = "Inputs/ColorPicker",
                Type = SampleType.Preview,
                UID = 023,
                Order = 04,
                Samples = ColorPicker,
                ControllerName = "ColorPicker"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Context Menu",
                Category = "Navigations",
                Directory = "Navigations/ContextMenu",
                Type = SampleType.Preview,
                UID = 024,
                Order = 02,
                Samples = ContextMenu,
                ControllerName = "ContextMenu"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "MenuBar",
                Category = "Navigations",
                Directory = "Navigations/MenuBar",
                Type = SampleType.Preview,
                UID = 025,
                Order = 03,
                Samples = MenuBar,
                ControllerName = "MenuBar"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "HeatMap Chart",
                Category = "Data Visualization",
                Directory = "HeatMapChart/HeatMapChart",
                Type = SampleType.None,
                UID = 006,
                Order = 06,
                Samples = HeatMapChart,
                ControllerName = "HeatMapChart"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Chips",
                Category = "Editors",
                Directory = "Buttons/Chips",
                Type = SampleType.None,
                UID = 004,
                Order = 03,
                Samples = Chips,
                ControllerName = "Chips"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TreeView",
                Category = "Navigations",
                Directory = "Navigations/TreeView",
                Type = SampleType.None,
                UID = 015,
                Order = 15,
                Samples = TreeView,
                ControllerName = "TreeView"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Slider",
                Category = "Inputs",
                Directory = "Inputs/Slider",
                Type = SampleType.None,
                UID = 014,
                Order = 14,
                Samples = Slider,
                ControllerName = "Slider"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "File Manager",
                Category = "Navigations",
                Directory = "Navigations/FileManager",
                Type = SampleType.Preview,
                UID = 016,
                Order = 04,
                Samples = FileManager,
                ControllerName = "FileManager"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Kanban",
                Category = "Data Visualization",
                Directory = "Kanban/Kanban",
                Type = SampleType.Preview,
                UID = 030,
                Order = 12,
                Samples = Kanban,
                ControllerName = "Kanban"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DocIO",
                Category = "File Formats",
                Directory = "FileFormats/DocIO",
                Type = SampleType.New,
                UID = 032,
                Order = 01,
                Samples = DocIO,
                ControllerName = "DocIO"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Presentation",
                Category = "File Formats",
                Directory = "FileFormats/Presentation",
                Type = SampleType.New,
                UID = 033,
                Order = 01,
                Samples = Presentation,
                ControllerName = "Presentation"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "XlsIO",
                Category = "File Formats",
                Directory = "FileFormats/XlsIO",
                Type = SampleType.New,
                UID = 009,
                Order = 09,
                Samples = XlsIO,
                ControllerName = "XlsIO"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "PDF",
                Category = "File Formats",
                Directory = "FileFormats/PDF",
                Type = SampleType.New,
                UID = 061,
                Order = 01,
                Samples = PDF,
                ControllerName = "PDF"
            });
        }
    }
}
