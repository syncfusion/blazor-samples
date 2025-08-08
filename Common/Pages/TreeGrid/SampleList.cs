#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
                FileName = "Overview.razor",
                MetaTitle = "Blazor Tree Grid Overview | Hierarchical Data | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Overview",
                MetaDescription = "This Blazor Tree Grid overview demonstrates hierarchical data visualization with tree structure, expandable nodes, and comprehensive grid features for data management."
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/default-functionalities",
                Type = SampleType.None,
                FileName="DefaultFunctionalities.razor",
                MetaTitle = "Blazor Tree Grid Default | Basic Features | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Default Functionalities",
                MetaDescription = "This Blazor Tree Grid default example demonstrates basic hierarchical data features with tree structure, expand/collapse, and essential grid functionalities.",
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
                Type = SampleType.None,
                MetaTitle = "Blazor Tree Grid Adaptive | Responsive Design | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Adaptive Layout",
                MetaDescription = "This Blazor Tree Grid with Adaptive Layout demonstrates responsive design that automatically adjusts to different screen sizes and device orientations."
            },
            new Sample
            {
                Name = "Sorting",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/sorting",
                Type = SampleType.None,
                FileName="Sorting.razor",
                MetaTitle = "Blazor Tree Grid Sorting | Data Organization | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Sorting",
                MetaDescription = "This Blazor Tree Grid Sorting demonstrates hierarchical data organization with multi-column sorting while maintaining tree structure relationships.",
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
                MetaTitle = "Blazor Tree Grid Paging | Data Navigation | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Paging",
                MetaDescription = "This Blazor Tree Grid Paging demonstrates hierarchical data navigation with page-based browsing while preserving tree structure and relationships.",
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
                MetaTitle = "Blazor Tree Grid Aggregates | Summary Data | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Aggregates",
                MetaDescription = "This Blazor Tree Grid Aggregates demonstrates summary calculations and statistical data display for hierarchical data with parent-child relationships.",
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
                Type = SampleType.None,
                MetaTitle = "Blazor Tree Grid Remote Data | API Integration | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Remote Data",
                MetaDescription = "This Blazor Tree Grid with Remote Data demonstrates hierarchical data binding from external APIs and remote data sources for dynamic content."
            },
            new Sample
            {
                Name = "ExpandoObject Binding",
                Category = "Data Binding",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/expando-object",
                FileName = "TreeGridExpandoObject.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Tree Grid ExpandoObject | Dynamic Binding | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - ExpandoObject Binding",
                MetaDescription = "This Blazor Tree Grid ExpandoObject Binding demonstrates dynamic data binding with flexible object structures for hierarchical data visualization."
            },
            new Sample
            {
                Name = "DynamicObject Binding",
                Category = "Data Binding",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/dynamic-object",
                FileName = "TreeGridDynamicObject.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Tree Grid DynamicObject | Flexible Data | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - DynamicObject Binding",
                MetaDescription = "This Blazor Tree Grid DynamicObject Binding demonstrates flexible data binding with runtime object creation for dynamic hierarchical structures."
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
                MetaTitle = "Blazor Tree Grid Virtual Scrolling | Performance | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - List Binding",
                MetaDescription = "This Blazor Tree Grid Virtual Scrolling demonstrates high-performance rendering of large hierarchical datasets with optimized memory usage.",
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
                MetaTitle = "Blazor Tree Grid Virtual Scrolling | Performance | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Virtual Scrolling",
                MetaDescription = "This Blazor Tree Grid Virtual Scrolling demonstrates high-performance rendering of large hierarchical datasets with optimized memory usage.",
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
                MetaTitle = "Blazor Tree Grid Remote Virtual | API Performance | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Remote Data Binding",
                MetaDescription = "This Blazor Tree Grid Remote Data with Virtualization demonstrates high-performance hierarchical data loading from APIs with virtual scrolling.",
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
                MetaTitle = "Blazor Tree Grid Column Template | Custom Cells | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Column Template",
                MetaDescription = "This Blazor Tree Grid Column Template demonstrates custom cell rendering with HTML templates for enhanced data visualization in hierarchical grids.",
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
                MetaTitle = "Blazor Tree Grid Header Template | Custom Headers | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Header Template",
                MetaDescription = "This Blazor Tree Grid Header Template demonstrates custom column header design with HTML templates for enhanced grid presentation and branding.",
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
                MetaTitle = "Blazor Tree Grid Reorder | Column Management | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Reorder",
                MetaDescription = "This Blazor Tree Grid Reorder demonstrates drag-and-drop column reordering for customizable hierarchical data layout and user preferences.",
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
                MetaTitle = "Blazor Tree Grid Resizing | Column Width | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Resizing",
                MetaDescription = "This Blazor Tree Grid Resizing demonstrates interactive column width adjustment for optimal hierarchical data display and user customization.",
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
                MetaTitle = "Blazor Tree Grid Column Menu | Grid Options | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Column Menu",
                MetaDescription = "This Blazor Tree Grid Column Menu demonstrates contextual column operations including sorting, filtering, and column management for hierarchical data.",
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
                MetaTitle = "Blazor Tree Grid Auto Wrap | Text Wrapping | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Auto Wrap Column Cells",
                MetaDescription = "This Blazor Tree Grid Auto Wrap demonstrates automatic text wrapping in cells for better content visibility in hierarchical data grids.",
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
                MetaTitle = "Blazor Tree Grid Column Chooser | Visibility | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Column Chooser",
                MetaDescription = "This Blazor Tree Grid Column Chooser demonstrates interactive column visibility management for customizable hierarchical data presentation.",
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
                MetaTitle = "Blazor Tree Grid Show Hide | Column Control | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Show or Hide Column",
                MetaDescription = "This Blazor Tree Grid Show/Hide demonstrates programmatic column visibility control for dynamic hierarchical data presentation and user preferences.",
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
                MetaTitle = "Blazor Tree Grid Frozen Columns | Fixed Layout | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Frozen Columns",
                MetaDescription = "This Blazor Tree Grid Frozen Columns demonstrates fixed column positioning for improved navigation in wide hierarchical datasets.",
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
                MetaTitle = "Blazor Tree Grid Row Template | Custom Rows | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Row Template",
                MetaDescription = "This Blazor Tree Grid Row Template demonstrates custom row rendering with HTML templates for enhanced hierarchical data visualization.",
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
                MetaTitle = "Blazor Tree Grid Detail Template | Expandable Rows | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Detail Template",
                MetaDescription = "This Blazor Tree Grid Detail Template demonstrates expandable row details with custom templates for comprehensive hierarchical data display.",
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
                MetaTitle = "Blazor Tree Grid Drag Drop | Row Movement | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Drag and Drop",
                MetaDescription = "This Blazor Tree Grid Drag and Drop demonstrates interactive row movement between different grids while maintaining hierarchical relationships.",
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
                MetaTitle = "Tree Grid Drag and Drop within Tree Grid - Syncfusion Demos",
                HeaderText = "Blazor Tree Grid Example - Drag and Drop within Tree Grid",
                MetaDescription = "This Blazor Tree Grid internal drag and drop demonstrates row reordering within the same hierarchical grid while preserving tree structure.",
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
                MetaTitle = "Blazor Tree Grid Row Hover | Visual Feedback | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Row Hover",
                MetaDescription = "This Blazor Tree Grid Row Hover demonstrates visual feedback on mouse hover for enhanced user interaction in hierarchical data grids.",
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
                MetaTitle = "Blazor Tree Grid Row Height | Layout Control | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Row Height",
                MetaDescription = "This Blazor Tree Grid Row Height demonstrates customizable row sizing for optimal hierarchical data display and content accommodation.",
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
                MetaTitle = "Blazor Tree Grid Inline Editing | Data Modification | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Inline Editing",
                MetaDescription = "This Blazor Tree Grid Inline Editing demonstrates direct cell editing capabilities for efficient hierarchical data modification and updates.",
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
                MetaTitle = "Blazor Tree Grid Dialog Editing | Form Editor | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Dialog Editing",
                MetaDescription = "This Blazor Tree Grid Dialog Editing demonstrates popup form-based editing for comprehensive hierarchical data modification and validation.",
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
                MetaTitle = "Blazor Tree Grid Batch Editing | Bulk Updates | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Batch Editing",
                MetaDescription = "This Blazor Tree Grid Batch Editing demonstrates multiple row editing with bulk save operations for efficient hierarchical data management.",
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
                MetaTitle = "Blazor Tree Grid Command Column | Action Buttons | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Command Column",
                MetaDescription = "This Blazor Tree Grid Command Column demonstrates action buttons for edit, delete, and custom operations in hierarchical data grids.",
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
                MetaTitle = "Blazor Tree Grid Cell Edit Type | Input Controls | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Cell Edit Type",
                MetaDescription = "This Blazor Tree Grid Cell Edit Type demonstrates various input controls for different data types in hierarchical grid editing scenarios.",
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
                MetaTitle = "Blazor Tree Grid Edit Template | Custom Editors | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Edit Template",
                MetaDescription = "This Blazor Tree Grid Edit Template demonstrates custom editor templates for specialized data input in hierarchical grid editing.",
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
                MetaTitle = "Blazor Tree Grid Filtering | Data Search | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Default Filtering",
                MetaDescription = "This Blazor Tree Grid Filtering demonstrates data search and filter capabilities while maintaining hierarchical relationships and tree structure.",
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
                MetaTitle = "Blazor Tree Grid Filter Template | Custom Filters | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Filterbar Template",
                MetaDescription = "This Blazor Tree Grid Filter Template demonstrates custom filter controls and templates for advanced hierarchical data filtering capabilities.",
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
                MetaTitle = "Blazor Tree Grid Menu Filter | Advanced Search | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Menu Filter",
                MetaDescription = "This Blazor Tree Grid Menu Filter demonstrates advanced filtering options with dropdown menus for comprehensive hierarchical data search.",
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
                Type = SampleType.None,
                MetaTitle = "Blazor Tree Grid Excel Filter | Advanced Filtering | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Excel like Filter",
                MetaDescription = "This Blazor Tree Grid Excel Filter demonstrates Excel-style filtering with checkboxes and search for intuitive hierarchical data filtering.",
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
                MetaTitle = "Blazor Tree Grid Search | Global Search | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Search",
                MetaDescription = "This Blazor Tree Grid Search demonstrates global search functionality across all columns while preserving hierarchical data relationships.",
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
                MetaTitle = "Blazor Tree Grid Selection | Row Selection | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Default Selection",
                MetaDescription = "This Blazor Tree Grid Selection demonstrates row and cell selection capabilities with various selection modes for hierarchical data interaction.",
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
                MetaTitle = "Blazor Tree Grid Selection API | Programmatic | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Selection API",
                MetaDescription = "This Blazor Tree Grid Selection API demonstrates programmatic selection control with methods for managing hierarchical data selections.",
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
                MetaTitle = "Blazor Tree Grid Checkbox Selection | Multi-Select | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Checkbox Selection",
                MetaDescription = "This Blazor Tree Grid Checkbox Selection demonstrates multi-row selection with checkboxes for bulk operations in hierarchical data grids.",
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
                MetaTitle = "Blazor Tree Grid Export | Data Export | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Default Exporting",
                MetaDescription = "This Blazor Tree Grid Export demonstrates exporting hierarchical data to Excel and PDF formats while preserving tree structure and formatting.",
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
               MetaTitle = "Blazor Tree Grid Print | Document Output | Syncfusion",
               HeaderText = "Blazor Tree Grid Example - Print",
               MetaDescription = "This Blazor Tree Grid Print demonstrates printing capabilities for generating hard copies of hierarchical data with customizable print settings.",
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
                FileName = "Persistence.razor",
                MetaTitle = "Blazor Tree Grid Persist State | Save Settings | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Persist State",
                MetaDescription = "This Blazor Tree Grid Persist State demonstrates saving and restoring grid settings including column order, filters, and user preferences."
            },
            new Sample
            {
                Name = "Context Menu",
                Category = "Miscellaneous",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/context-menu",
                FileName="ContextMenu.razor",
                MetaTitle = "Blazor Tree Grid Context Menu | Right-Click Menu | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Context Menu",
                MetaDescription = "This Blazor Tree Grid Context Menu demonstrates right-click contextual operations for enhanced user interaction in hierarchical data grids.",
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
                Type = SampleType.None,
                MetaTitle = "Blazor Tree Grid Events | Event Handling | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Events",
                MetaDescription = "This Blazor Tree Grid Events demonstrates event handling for user interactions, data changes, and grid operations in hierarchical data grids.",
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
                MetaTitle = "Blazor Tree Grid Clipboard | Copy Paste | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Clipboard",
                MetaDescription = "This Blazor Tree Grid Clipboard demonstrates copy and paste operations for efficient data transfer in hierarchical grid applications.",
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
                MetaTitle = "Blazor Tree Grid Conditional Format | Visual Styling | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Conditional Formatting",
                MetaDescription = "This Blazor Tree Grid Conditional Formatting demonstrates dynamic cell styling based on data values for enhanced hierarchical data visualization.",
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
                MetaTitle = "Blazor Tree Grid Toolbar Template | Custom Toolbar | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Toolbar Template",
                MetaDescription = "This Blazor Tree Grid Toolbar Template demonstrates custom toolbar design with action buttons for enhanced hierarchical grid functionality.",
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
                MetaTitle = "Blazor Tree Grid Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Keyboard Navigation",
                MetaDescription = "This Blazor Tree Grid Keyboard Navigation demonstrates accessibility features with keyboard shortcuts for hierarchical data grid interaction.",
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