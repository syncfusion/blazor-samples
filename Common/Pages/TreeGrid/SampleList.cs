#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> TreeGrid { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/overview",
                FileName = "Overview.razor"
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/default-functionalities",
                Type = SampleType.None,
                FileName="DefaultFunctionalities.razor",
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
                Name = "Adaptive Layout",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/adaptive",
                FileName = "Adaptive.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Sorting",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/sorting",
                Type = SampleType.None,
                FileName="Sorting.razor",
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
                Name = "Paging",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/paging",
                Type = SampleType.None,
                FileName="Paging.razor",
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
                Name = "Aggregates",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/aggregate",
                Type = SampleType.None,
                FileName="Aggregate.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Aggregate",
                        FileName="Aggregate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Aggregatedata",
                        FileName="ShipmentData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/remote-data",
                FileName = "RemoteData.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "ExpandoObject Binding",
                Category = "Data Binding",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/expando-object",
                FileName = "TreeGridExpandoObject.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "DynamicObject Binding",
                Category = "Data Binding",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/dynamic-object",
                FileName = "TreeGridDynamicObject.razor",
                Type = SampleType.None
            },
#if !(WASM)
            new Sample
            {
                Name = "List Binding",
                Category = "Virtual Scrolling",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/virtual-scrolling",
                Type = SampleType.None,
                FileName="VirtualScrolling.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "VirtualScrolling",
                        FileName = "VirtualScrolling.razor"
                    },
                    new SourceCollection
                    {
                        Id = "VirtualScrollData",
                        FileName = "VirtualData.cs"
                    }
                },
            },
#endif

#if (WASM)
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Virtual Scrolling",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/remote-data-with-virtualization",
                FileName = "RemoteDataWithVirtualization.razor",
            },
#endif
#if !(WASM)
            new Sample
            {
                Name = "Remote Data Binding",
                Category = "Virtual Scrolling",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/remote-data-with-virtualization",
                FileName = "RemoteDataWithVirtualization.razor",
            },
#endif

            new Sample
            {
                Name = "Column Template",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/column-template",
                Type = SampleType.None,
                FileName="ColumnTemplate.razor",
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
                Name = "Header Template",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/header-template",
                Type = SampleType.None,
                FileName="Headerstemplate.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Headertemplate",
                        FileName="Headerstemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="headertemplateData",
                        FileName="TemplateData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Reorder",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/reorder",
                Type = SampleType.None,
                FileName="Reorder.razor",
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
                Name = "Resizing",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/resizing",
                Type = SampleType.None,
                FileName="Resizing.razor",
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
                Name = "Column Menu",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/column-menu",
                Type = SampleType.None,
                FileName = "ColumnMenu.razor",
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
                Name = "Auto Wrap Column Cells",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/auto-wrap",
                Type = SampleType.None,
                FileName="AutoWrap.razor",
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
                Name = "Column Chooser",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/columnchooser",
                Type = SampleType.None,
                FileName="TreeColumnChooser.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnChooser",
                        FileName="TreeColumnChooser.razor"
                    },
                    new SourceCollection
                    {
                        Id="TreeData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Show or Hide Column",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/show-or-hide",
                Type = SampleType.None,
                FileName="ShowOrHide.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ShowHide",
                        FileName="ShowOrHide.razor"
                    },
                    new SourceCollection
                    {
                        Id="ShowOrHideData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Frozen Columns",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/frozen-column",
                Type = SampleType.None,
                FileName="FrozenColumn.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FrozenColumn",
                        FileName="FrozenColumn.razor"
                    },
                    new SourceCollection
                    {
                        Id="FrozenData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Row Template",
                Category = "Rows",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/tree-grid-row-template",
                Type = SampleType.None,
                FileName="TreeGridRowTemplate.razor",
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
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/tree-grid-detail-template",
                FileName = "TreeGridDetailTemplate.razor",
                Type = SampleType.None,
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
                Name = "Drag and Drop",
                Category = "Rows",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/row-drag-and-drop",
                FileName="RowDragAndDrop.razor",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowDragAndDrop",
                        FileName="RowDragAndDrop.razor"
                    },
                    new SourceCollection
                    {
                        Id="DragData",
                        FileName="WrapData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Drag and Drop within Tree Grid",
                Category = "Rows",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/draganddrop-within-grid",
                Type = SampleType.None,
                FileName="DragAndDropWithinGrid.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DragAndDropWithinGrid",
                        FileName="DragAndDropWithinGrid.razor"
                    },
                    new SourceCollection
                    {
                        Id="DropData",
                        FileName="WrapData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Row Hover",
                Category = "Rows",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/row-hover",
                Type = SampleType.None,
                FileName="RowHover.razor",
                IsHideInMobile = true,
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
                Name = "Row Height",
                Category = "Rows",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/row-height",
                Type = SampleType.None,
                FileName="RowHeight.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowHeight",
                        FileName="RowHeight.razor"
                    },
                    new SourceCollection
                    {
                        Id="RowHeightData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Inline Editing",
                Category = "Editing",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/inline-editing",
                FileName="InlineEditing.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="InlineEditing",
                        FileName="InlineEditing.razor"
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
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/dialog-editing",
                Type = SampleType.None,
                FileName="DialogEditing.razor",
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
                Name = "Batch Editing",
                Category = "Editing",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/batch-editing",
                FileName="BatchEditing.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="BatchEditing",
                        FileName="BatchEditing.razor"
                    },
                    new SourceCollection
                    {
                        Id="BatchData",
                        FileName="WrapData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Command Column",
                Category = "Editing",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/command-column",
                Type = SampleType.None,
                FileName="CommandColumn.razor",
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
                Name = "Cell Edit Type",
                Category = "Editing",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/cell-edit-type",
                Type = SampleType.None,
                FileName="CellEditType.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CellEditType",
                        FileName="CellEditType.razor"
                    },
                    new SourceCollection
                    {
                        Id="CellEditTypeData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Edit Template",
                Category = "Editing",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/cell-edit-template",
                Type = SampleType.None,
                FileName="CellEditTemplate.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                   {
                        Id="CellEditTemplate",
                        FileName="CellEditTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="EditTemplateData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Default Filtering",
                Category = "Filtering",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/default-filtering",
                Type = SampleType.None,
                FileName="DefaultFiltering.razor",
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
                Name = "Filterbar Template",
                Category = "Filtering",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/filter-bar-template",
                Type = SampleType.None,
                FileName="FilterBarTemplate.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Filtering",
                        FileName="FilterBarTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="FilterBarTemplateData",
                        FileName="TreeData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Menu Filter",
                Category = "Filtering",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/menu-filter",
                FileName="MenuFilter.razor",
                Type = SampleType.None,
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
                },
            },
             new Sample
            {
                Name = "Excel like Filter",
                Category = "Filtering",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/excel-filter",
                FileName="ExcelFilter.razor",
                Type = SampleType.New,
                NotificationDescription = new string[]{ @"This sample demonstrates the way of filtering tree grid columns using Excel-like filter UI. Which helps to create complex filter criteria for a column by allowing users to select possible filter values from a check box list" },
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ExcelFilter",
                        FileName="ExcelFilter.razor"
                    },
                    new SourceCollection
                    {
                        Id="FilterData",
                        FileName="TreeData.cs"
                    }
                },
            },
            new Sample
            {
                Name = "Search",
                Category = "Filtering",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/search",
                Type = SampleType.None,
                FileName="Search.razor",
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
                Name = "Default Selection",
                Category = "Selection",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/selection",
                Type = SampleType.None,
                FileName="Selection.razor",
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
                Name = "Selection API",
                Category = "Selection",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/selection-api",
                Type = SampleType.None,
                FileName="SelectionAPI.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="SelectionAPI",
                        FileName="SelectionAPI.razor"
                    },
                    new SourceCollection
                    {
                        Id="SelectionAPIData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Checkbox Selection",
                Category = "Selection",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/checkbox-selection",
                Type = SampleType.None,
                FileName="CheckboxSelection.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CheckBoxSelection",
                        FileName="CheckboxSelection.razor"
                    },
                    new SourceCollection
                    {
                        Id="CheckBoxData",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Default Exporting",
                Category = "Exporting",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/exporting",
                Type = SampleType.None,
                FileName="Exporting.razor",
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
               Directory = "TreeGrid/TreeGrid",
               Url = "tree-grid/print",
               Type = SampleType.None,
               FileName="Print.razor",
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
            },
            new Sample
            {
                Name = "Persist State",
                Category = "Miscellaneous",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/persistence",
                FileName = "Persistence.razor"
            },
            new Sample
            {
                Name = "Context Menu",
                Category = "Miscellaneous",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/context-menu",
                FileName="ContextMenu.razor",
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
                Name = "Events",
                Category = "Miscellaneous",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/event",
                FileName="Event.razor",
                Type = SampleType.New,
                NotificationDescription = new string[]{ @"This sample demonstrates the events that have been triggered on the Tree Grid operations with the help of Event Trace panel." },
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Events",
                        FileName="Event.razor"
                    },
                    new SourceCollection
                    {
                        Id="EventsData",
                        FileName="TreeData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Clipboard",
                Category = "Miscellaneous",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/clipboard",
                FileName="Clipboard.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Clipboard",
                        FileName="Clipboard.razor"
                    },
                    new SourceCollection
                    {
                        Id="Clipboard",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Conditional Formatting",
                Category = "Miscellaneous",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/conditional-formatting",
                Type = SampleType.None,
                FileName="ConditionalFormatting.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Formatting",
                        FileName="ConditionalFormatting.razor"
                    },
                    new SourceCollection
                    {
                        Id="formatdata",
                        FileName="Selfdata.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Toolbar Template",
                Category = "Miscellaneous",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/tool-bar-template",
                Type = SampleType.None,
                FileName="ToolBarTemplate.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ToolBartemplate",
                        FileName="ToolBarTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="ToolBarTemplateData",
                        FileName="TreeData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Miscellaneous",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/keyboard-interaction",
                Type = SampleType.None,
                FileName="KeyboardInteraction.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="KeyboardInteraction",
                        FileName="KeyboardInteraction.razor"
                    },
                    new SourceCollection
                    {
                        Id="KeyboardInteractionData",
                        FileName="WrapData.cs"
                    }
                }
            }
        };
    }
}
