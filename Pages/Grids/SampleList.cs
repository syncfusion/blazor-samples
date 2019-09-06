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
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="DefaultFunctionalities.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Grid Lines",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/GridLines",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="GridLines",
                        FileName="GridLines.razor"
                    },
                    new SourceCollection
                    {
                        Id="LinesData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Context Menu",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/ContextMenu",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ContextMenu",
                        FileName="ContextMenu.razor"
                    },
                    new SourceCollection
                    {
                        Id="ContextData",
                        FileName="TreeData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/RemoteData",
                FileName = "RemoteData.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Column Formatting",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/ColumnFormatting",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Formatting",
                        FileName="ColumnFormatting.razor"
                    },
                    new SourceCollection
                    {
                        Id="FormatData",
                        FileName="FormatData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Column Template",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/ColumnTemplate",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnTemplate",
                        FileName="ColumnTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="ColumnData",
                        FileName="TemplateData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Auto Wrap Column Cells",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/AutoWrap",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="AutoWrap",
                        FileName="AutoWrap.razor"
                    },
                    new SourceCollection
                    {
                        Id="WrapData",
                        FileName="WrapData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Cell Alignment",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/CellAlignment",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CellAlignment",
                        FileName="CellAlignment.razor"
                    },
                    new SourceCollection
                    {
                        Id="CellData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Stacked Header",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/StackedHeader",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="StackedHeader",
                        FileName="StackedHeader.razor"
                    },
                    new SourceCollection
                    {
                        Id="StackedData",
                        FileName="ShipmentData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Column Menu",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/ColumnMenu",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnMenu",
                        FileName="ColumnMenu.razor"
                    },
                    new SourceCollection
                    {
                        Id="MenuData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Resizing",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Resizing",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Resizing",
                        FileName="Resizing.razor"
                    },
                    new SourceCollection
                    {
                        Id="ResizeData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Reorder",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Reorder",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Reorder",
                        FileName="Reorder.razor"
                    },
                    new SourceCollection
                    {
                        Id="ReorderData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Row Hover",
                Category = "Rows",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/RowHover",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowHover",
                        FileName="RowHover.razor"
                    },
                    new SourceCollection
                    {
                        Id="HoverData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Row Template",
                Category = "Rows",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/TreeGridRowTemplate",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowTemplate",
                        FileName="TreeGridRowTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="RowData",
                        FileName="TemplateData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Detail Template",
                Category = "Rows",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/TreeGridDetailTemplate",
                FileName = "TreeGridDetailTemplate.razor",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DetailTemplate",
                        FileName="TreeGridDetailTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="TemplateData",
                        FileName="TemplateData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Inline Editing",
                Category = "Editing",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Editing",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Editing",
                        FileName="Editing.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Dialog Editing",
                Category = "Editing",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/DialogEditing",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DialogEditing",
                        FileName="DialogEditing.razor"
                    },
                    new SourceCollection
                    {
                        Id="DialogData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Command Column",
                Category = "Editing",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/CommandColumn",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CommandColumn",
                        FileName="CommandColumn.razor"
                    },
                    new SourceCollection
                    {
                        Id="CommandData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Default Sorting",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Sorting",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Sorting",
                        FileName="Sorting.razor"
                    },
                    new SourceCollection
                    {
                        Id="SortData",
                        FileName="ShipmentData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Default Filtering",
                Category = "Filtering",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/DefaultFiltering",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Filtering",
                        FileName="DefaultFiltering.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="TreeData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Menu Filter",
                Category = "Filtering",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/MenuFilter",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="MenuFilter",
                        FileName="MenuFilter.razor"
                    },
                    new SourceCollection
                    {
                        Id="FilterData",
                        FileName="TreeData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Search",
                Category = "Filtering",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Search",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Search",
                        FileName="Search.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="TreeData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Default Paging",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Paging",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Paging",
                        FileName="Paging.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Default Selection",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Selection",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Selection",
                        FileName="Selection.razor"
                    },
                    new SourceCollection
                    {
                        Id="SelectionData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Checkbox Column",
                Category = "Columns",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/CheckboxColumn",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Checkbox",
                        FileName="CheckboxColumn.razor"
                    },
                    new SourceCollection
                    {
                        Id="CheckboxData",
                        FileName="SelfData.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Default Exporting",
                Category = "Exporting",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Exporting",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DefaultExporting",
                        FileName="Exporting.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultExportingData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Print",
                Category = "Exporting",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Print",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Print",
                        FileName="Print.razor"
                    },
                    new SourceCollection
                    {
                        Id="PrintData",
                        FileName="SelfData.cs"
                    }
                }
            }
        };
    }

   


}
