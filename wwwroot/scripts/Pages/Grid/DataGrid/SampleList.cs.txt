using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> DataGrid { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Data Grid",
                Directory = "Grid/DataGrid",
                Url = "Grid/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "List Binding",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "Grid/LocalData",
                FileName = "LocalData.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "Grid/RemoteData",
                FileName = "RemoteData.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Custom Binding",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "Grid/CustomBinding",
                FileName = "CustomBinding.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Context Menu",
                Category = "Data Grid",
                Directory = "Grid/DataGrid",
                Url = "Grid/ContextMenu",
                FileName = "ContextMenu.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Default Scrolling",
                Category = "Scrolling",
                Directory = "Grid/DataGrid",
                Url = "Grid/DefaultScrolling",
                FileName = "DefaultScrolling.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Scrolling",
                Directory = "Grid/DataGrid",
                Url = "Grid/VirtualScrolling",
                FileName = "VirtualScrolling.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Grid Lines",
                Category = "Data Grid",
                Directory = "Grid/DataGrid",
                Url = "Grid/GridLines",
                FileName = "GridLines.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "AutoWrap Column Cells",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/AutoWrap",
                FileName = "AutoWrap.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Stacked Header",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/StackedHeader",
                FileName = "GridStackedHeader.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Column Reorder",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/Reorder",
                FileName = "Reorder.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Column Chooser",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/ColumnChooser",
                FileName = "ColumnChooser.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Column Resize",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/ColumnResize",
                FileName = "Columnresize.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Column Menu",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/ColumnMenu",
                FileName = "Columnmenu.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Row Hover",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "Grid/RowHover",
                FileName = "RowHover.razor",
                Type = SampleType.New
            },
             new Sample
             {
                 Name = "Row Drag And Drop",
                 Category = "Rows",
                 Directory = "Grid/DataGrid",
                 Url = "Grid/RowDragAndDrop",
                 FileName = "RowDragAndDrop.razor",
                 Type = SampleType.New
             },
            //new Sample
            //{
            //    Name = "Row Drag And Drop Within Grid",
            //    Category = "Rows",
            //    Directory = "Grid/DataGrid",
            //    Url = "Grid/DragAndDropWithinGrid",
            //    FileName = "DragAndDropWithinGrid.razor",
            //    Type = SampleType.New
            //},
            new Sample
            {
                Name = "Inline Editing",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "Grid/InlineEditing",
                FileName = "InlineEditing.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Dialog Editing",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "Grid/DialogEditing",
                FileName = "DialogEditing.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Dialog Template",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "Grid/GridDialogTemplate",
                FileName = "GridDialogTemplate.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Batch Editing",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "Grid/BatchEditing",
                FileName = "BatchEditing.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Command Column",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "Grid/CommandColumn",
                FileName = "CommandColumn.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Multi Sorting",
                Category = "Data Grid",
                Directory = "Grid/DataGrid",
                Url = "Grid/Sorting",
                FileName = "Sorting.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Default Filtering",
                Category = "Filtering",
                Directory = "Grid/DataGrid",
                Url = "Grid/Filtering",
                FileName = "Filtering.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Menu Filter",
                Category = "Filtering",
                Directory = "Grid/DataGrid",
                Url = "Grid/FilterMenu",
                FileName = "FilterMenu.razor",
                Type = SampleType.New
            },
            new Sample
            {
               Name = "Search",
               Category = "Filtering",
               Directory = "Grid/DataGrid",
               Url = "Grid/Search",
               FileName = "Search.razor",
               Type = SampleType.New
            },
            new Sample
            {
                Name = "Paging",
                Category = "Data Grid",
                Directory = "Grid/DataGrid",
                Url = "Grid/Paging",
                FileName = "Paging.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Default Selection",
                Category = "Selection",
                Directory = "Grid/DataGrid",
                Url = "Grid/Selection",
                FileName = "Selection.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Checkbox Selection",
                Category = "Selection",
                Directory = "Grid/DataGrid",
                Url = "Grid/CheckboxSelection",
                FileName = "CheckboxSelection.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Default Aggregate",
                Category = "Aggregates",
                Directory = "Grid/DataGrid",
                Url = "Grid/Aggregate",
                FileName = "Aggregate.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Group And Caption Aggregate",
                Category = "Aggregates",
                Directory = "Grid/DataGrid",
                Url = "Grid/GroupAndCaptionAggregate",
                FileName = "GroupAndCaptionAggregate.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Default Exporting",
                Category = "Exporting",
                Directory = "Grid/DataGrid",
                Url = "Grid/Exporting",
                FileName = "Exporting.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Print",
                Category = "Exporting",
                Directory = "Grid/DataGrid",
                Url = "Grid/Print",
                FileName = "Print.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Grouping",
                Category = "Data Grid",
                Directory = "Grid/DataGrid",
                Url = "Grid/Grouping",
                FileName = "Grouping.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Column Template",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/ColumnTemplate",
                FileName = "ColumnTemplate.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Row Template",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "Grid/RowTemplate",
                FileName = "GridRowTemplate.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Detail Template",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "Grid/DetailTemplate",
                FileName = "GridDetailTemplate.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Header Template",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/HeaderTemplate",
                FileName = "GridHeaderTemplate.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Clipboard",
                Category = "Data Grid",
                Directory = "Grid/DataGrid",
                Url = "Grid/Clipboard",
                FileName = "Clipboard.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Row Height",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "Grid/RowHeight",
                FileName = "RowHeight.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Frozen Rows and Columns",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/FrozenRows",
                FileName = "FrozenRowsAndColumns.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Show or Hide Column",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/ShoworHideColumn",
                FileName = "ShoworHideColumn.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Observable Collection",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "Grid/ObservableBinding",
                FileName="ObservableBinding.razor",
				Type = SampleType.New
            }
        };
    }
}
