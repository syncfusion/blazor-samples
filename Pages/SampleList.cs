﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ej2_blazor_samples
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
                Type = SampleType.New,
                UID = 002,
                Order = 01,
                Samples = DataGrid
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TreeGrid",
                Category = "Grids",
                Directory = "TreeGrid/TreeGrid",
                Type = SampleType.New,
                UID = 006,
                Order = 02,
                Samples = TreeGrid
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "PivotTable",
                Category = "Grids",
                Directory = "PivotView/PivotTable",
                Type = SampleType.New,
                UID = 027,
                Order = 03,
                Samples = PivotTable
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Chart",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.New,
                UID = 005,
                Order = 01,
                Samples = Chart
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "StockChart",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.New,
                UID = 006,
                Order = 01,
                Samples = StockChart
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "CircularGauge",
                Category = "Data Visualization",
                Directory = "CircularGauge",
                Type = SampleType.New,
                UID = 003,
                Order = 03,
                Samples = CircularGauge
            });
			SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "LinearGauge",
                Category = "Data Visualization",
                Directory = "LinearGauge/LinearGauge",
                Type = SampleType.New,
                UID = 004,
                Order = 04,
                Samples = LinearGauge
            });
			SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Diagram",
                Category = "Data Visualization",
                Directory = "Diagrams",
                Type = SampleType.New,
                UID = 005,
                Order = 05,
                Samples = Diagram
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Sparkline",
                Category = "Data Visualization",
                Directory = "Charts/Sparkline",
                Type = SampleType.New,
                UID = 010,
                Order = 10,
                Samples = Sparkline
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TreeMap",
                Category = "Data Visualization",
                Directory = "TreeMap/TreeMap",
                Type = SampleType.New,
                UID = 011,
                Order = 11,
                Samples = TreeMap
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Maps",
                Category = "Data Visualization",
                Directory = "Maps/Maps",
                Type = SampleType.New,
                UID = 007,
                Order = 07,
                Samples = Maps
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "RangeNavigator",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.New,
                UID = 006,
                Order = 01,
                Samples = RangeNavigator
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "SmithChart",
                Category = "Data Visualization",
                Directory = "Charts/RangeNavigator",
                Type = SampleType.New,
                UID = 009,
                Order = 09,
                Samples = SmithChart
            });
			SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Barcode",
                Category = "Data Visualization",
                Directory = "Barcodes",
                Type = SampleType.New,
                UID = 005,
                Order = 05,
                Samples = Barcode
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Button",
                Category = "Editors",
                Directory = "Buttons",
                Type = SampleType.New,
                UID = 003,
                Order = 03,
                Samples = Button
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Calendar",
                Category = "Calendars",
                Directory = "Calendars/Calendar",
                Type = SampleType.New,
                UID = 014,
                Order = 02,
                Samples = Calendar
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DatePicker",
                Category = "Calendars",
                Directory = "Calendars/DatePicker",
                Type = SampleType.New,
                UID = 015,
                Order = 03,
                Samples = DatePicker
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DateTimePicker",
                Category = "Calendars",
                Directory = "Calendars/DateTimePicker",
                Type = SampleType.New,
                UID = 016,
                Order = 06,
                Samples = DateTimePicker
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TimePicker",
                Category = "Calendars",
                Directory = "Calendars/TimePicker",
                Type = SampleType.New,
                UID = 017,
                Order = 17,
                Samples = TimePicker
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DateRangePicker",
                Category = "Calendars",
                Directory = "Calendars/DateRangePicker",
                Type = SampleType.New,
                UID = 018,
                Order = 04,
                Samples = DateRangePicker
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DropDownList",
                Category = "DropDowns",
                Directory = "DropDowns/DropDownList",
                Type = SampleType.New,
                UID = 019,
                Order = 03,
                Samples = DropDownList
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ComboBox",
                Category = "DropDowns",
                Directory = "DropDowns/ComboBox",
                Type = SampleType.New,
                UID = 020,
                Order = 02,
                Samples = ComboBox
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "AutoComplete",
                Category = "DropDowns",
                Directory = "DropDowns/AutoComplete",
                Type = SampleType.New,
                UID = 021,
                Order = 01,
                Samples = AutoComplete
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "MultiSelect",
                Category = "DropDowns",
                Directory = "DropDowns/MultiSelect",
                Type = SampleType.New,
                UID = 022,
                Order = 04,
                Samples = MultiSelect
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ListBox",
                Category = "DropDowns",
                Directory = "DropDowns/ListBox",
                Type = SampleType.New,
                UID = 028,
                Order = 05,
                Samples = ListBox
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Sidebar",
                Category = "Navigations",
                Directory = "Navigations/Sidebar",
                Type = SampleType.New,
                UID = 005,
                Order = 04,
                Samples = Sidebar
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Accordion",
                Category = "Navigations",
                Directory = "Navigations/Accordion",
                Type = SampleType.New,
                UID = 005,
                Order = 01,
                Samples = Accordion
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Toolbar",
                Category = "Navigations",
                Directory = "Navigations/Toolbar",
                Type = SampleType.New,
                UID = 005,
                Order = 06,
                Samples = Toolbar
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Tab",
                Category = "Navigations",
                Directory = "Navigations/Tab",
                Type = SampleType.New,
                UID = 005,
                Order = 05,
                Samples = Tab
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Toast",
                Category = "Notifications",
                Directory = "Notifications/Toast",
                Type = SampleType.New,
                UID = 016,
                Order = 16,
                Samples = Toast
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Spinner",
                Category = "Notifications",
                Directory = "Notifications/Spinner",
                Type = SampleType.New,
                UID = 011,
                Order = 02,
                Samples = Spinner
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TextBox",
                Category = "Inputs",
                Directory = "Inputs",
                Type = SampleType.New,
                UID = 004,
                Order = 01,
                Samples = TextBox
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DashboardLayout",
                Category = "Layout",
                Directory = "Layouts/DashboardLayout",
                Type = SampleType.New,
                UID = 028,
                Order = 01,
                Samples = DashboardLayout
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Dialog",
                Category = "Layout",
                Directory = "Popups/Dialog",
                Type = SampleType.New,
                UID = 008,
                Order = 02,
                Samples = Dialog
            });
			SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Listview",
                Category = "Layout",
                Directory = "Layouts/Listview",
                Type = SampleType.New,
                UID = 005,
                Order = 01,
                Samples = Listview
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Tooltip",
                Category = "Layout",
                Directory = "Layouts/Tooltip",
                Type = SampleType.New,
                UID = 022,
                Order = 22,
                Samples = Tooltip
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Splitter",
                Category = "Layout",
                Directory = "Layouts/Splitter",
                Type = SampleType.New,
                UID = 010,
                Order = 10,
                Samples = Splitter
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "QueryBuilder",
                Category = "Forms",
                Directory = "Forms/QueryBuilder",
                Type = SampleType.New,
                UID = 026,
                Order = 26,
                Samples = QueryBuilder
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "PdfViewer",
                Category = "Viewer",
                Directory = "Viewer",
                Type = SampleType.New,
                UID = 006,
                Order = 04,
                Samples = PdfViewer
            });

            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DocumentEditor",
                Category = "Editors",
                Directory = "DocumentEditor/DocumentEditor",
                Type = SampleType.New,
                UID = 004,
                Order = 02,
                Samples = DocumentEditor
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "InPlaceEditor",
                Category = "Editors",
                Directory = "Editors/InPlaceEditor",
                Type = SampleType.New,
                UID = 009,
                Order = 09,
                Samples = InPlaceEditor
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Schedule",
                Category = "Calendars",
                Directory = "Schedule/Schedule",
                Type = SampleType.New,
                UID = 005,
                Order = 01,
                Samples = Schedule
            });

            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Gantt",
                Category = "Calendars",
                Directory = "Gantt/Gantt",
                Type = SampleType.New,
                UID = 005,
                Order = 01,
                Samples = Gantt
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "RichTextEditor",
                Category = "Editors",
                Directory = "RichTextEditor/RichTextEditor",
                Type = SampleType.New,
                UID = 005,
                Order = 01,
                Samples = RichTextEditor
            });
              SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "NumericTextBox",
                Category = "Inputs",
                Directory = "Inputs/NumericTextBox",
                Type = SampleType.New,
                UID = 011,
                Order = 03,
                Samples = NumericTextBox
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "MaskedTextBox",
                Category = "Inputs",
                Directory = "Inputs/MaskedTextBox",
                Type = SampleType.New,
                UID = 012,
                Order = 02,
                Samples = MaskedTextBox
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "FileUpload",
                Category = "Inputs",
                Directory = "Inputs/Uploader",
                Type = SampleType.New,
                UID = 013,
                Order = 05,
                Samples = FileUpload
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ColorPicker",
                Category = "Inputs",
                Directory = "Inputs/ColorPicker",
                Type = SampleType.New,
                UID = 023,
                Order = 04,
                Samples = ColorPicker
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ContextMenu",
                Category = "Navigations",
                Directory = "Navigations/ContextMenu",
                Type = SampleType.New,
                UID = 024,
                Order = 02,
                Samples = ContextMenu
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "MenuBar",
                Category = "Navigations",
                Directory = "Navigations/MenuBar",
                Type = SampleType.New,
                UID = 025,
                Order = 03,
                Samples = MenuBar
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "HeatMapChart",
                Category = "Data Visualization",
                Directory = "HeatMapChart/HeatMapChart",
                Type = SampleType.New,
                UID = 006,
                Order = 06,
                Samples = HeatMapChart
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Chips",
                Category = "Editors",
                Directory = "Buttons/Chips",
                Type = SampleType.New,
                UID = 004,
                Order = 03,
                Samples = Chips
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TreeView",
                Category = "Navigations",
                Directory = "Navigations/TreeView",
                Type = SampleType.New,
                UID = 015,
                Order = 15,
                Samples = TreeView
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Slider",
                Category = "Inputs",
                Directory = "Inputs/Slider",
                Type = SampleType.New,
                UID = 014,
                Order = 14,
                Samples = Slider
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "FileManager",
                Category = "Navigations",
                Directory = "Navigations/FileManager",
                Type = SampleType.New,
                UID = 016,
                Order = 04,
                Samples = FileManager
            });
        }
    }
}
