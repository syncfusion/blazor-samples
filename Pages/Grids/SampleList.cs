using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> TreeGrid { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/DefaultFunctionalities",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "DefaultFunctionalities.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "SelfData.cs"
                    },
                },
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Grid Lines",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/GridLines",
                FileName = "GridLines.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Context Menu",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/ContextMenu",
                FileName = "ContextMenu.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/RemoteData",
                FileName = "RemoteData.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Column Formatting",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/ColumnFormatting",
                FileName = "ColumnFormatting.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Column Template",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/ColumnTemplate",
                FileName = "ColumnTemplate.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Auto Wrap Column Cells",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/AutoWrap",
                FileName = "AutoWrap.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Cell Alignment",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/CellAlignment",
                FileName = "CellAlignment.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Stacked Header",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/StackedHeader",
                FileName = "StackedHeader.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Column Menu",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/ColumnMenu",
                FileName = "ColumnMenu.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Resizing",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Resizing",
                FileName = "Resizing.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Reorder",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Reorder",
                FileName = "Reorder.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Row Hover",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/RowHover",
                FileName = "RowHover.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Inline Editing",
                Category = "Editing",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Editing",
                FileName = "Editing.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Dialog Editing",
                Category = "Editing",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/DialogEditing",
                FileName = "DialogEditing.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Command Column",
                Category = "Editing",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/CommandColumn",
                FileName = "CommandColumn.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Default Sorting",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Sorting",
                FileName = "Sorting.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Default Filtering",
                Category = "Filtering",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/DefaultFiltering",
                FileName = "DefaultFiltering.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Menu Filter",
                Category = "Filtering",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/MenuFilter",
                FileName = "MenuFilter.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Search",
                Category = "Filtering",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Search",
                FileName = "Search.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Default Paging",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Paging",
                FileName = "Paging.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Default Selection",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Selection",
                FileName = "Selection.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Checkbox Column",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/CheckboxColumn",
                FileName = "CheckboxColumn.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Print",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Print",
                FileName = "Print.razor",
                Type = SampleType.New,
            }
        };
    }

   


}
