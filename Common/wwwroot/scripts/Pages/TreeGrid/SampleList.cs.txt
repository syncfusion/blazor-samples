using System.Collections.Generic;
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
                MetaTitle = "Blazor TreeGrid Examples - Overview | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Overview",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid displays hierarchical data with expandable nodes, sorting, and filtering to efficiently manage structured datasets.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-tree-grid",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="OverviewData",
                        FileName="Overview.razor"
                    }
                }
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/default-functionalities",
                Type = SampleType.None,
                FileName="DefaultFunctionalities.razor",
                MetaTitle = "Blazor TreeGrid Examples - Default | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Default Functionalities",
                MetaDescription = "Explore the default features of the Syncfusion Blazor TreeGrid including data binding, sorting, paging, and hierarchical row rendering for structured data.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-tree-grid",
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
                        FileName="TaskData.cs"
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
                MetaTitle = "Blazor TreeGrid - Adaptive Layout | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Adaptive Layout",
                MetaDescription = "See how the Syncfusion Blazor Adaptive Layout adjusts tree grid views across screen sizes with responsive layout and touch support for better usability.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="AdaptiveData",
                        FileName="Adaptive.razor"
                    },
                    new SourceCollection
                    {
                        Id="AdaptiveDataSource",
                        FileName="SelfData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Empty Record Template",
                Category = "Tree Grid",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/empty-record-template",
                Type = SampleType.None,
                FileName="EmptyRecordTemplate.razor",
                MetaTitle = "Blazor TreeGrid - Empty Record Template | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Empty Record Template",
                MetaDescription = "See how the Syncfusion Blazor Empty Record Template displays custom messages or templates when no data is available to improve user guidance and clarity.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EmptyRecordTemplate",
                        FileName="EmptyRecordTemplate.razor"
                    }
                }
            },
#if SERVER
            new Sample
            {
                Name = "Adaptive Structuring",
                Category = "Smart AI Solutions",
                Directory = "AISamples/TreeGrid",
                Url = "tree-grid/ai-adaptive-datastructuring",
                FileName = "AdaptiveDataStructuring.razor",
                MetaTitle = "Blazor TreeGrid - Adaptive Structuring | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor TreeGrid - AI Powered Adaptive Structuring Example",
                MetaDescription = "See how the Syncfusion Blazor Adaptive Structuring uses AI to fix hierarchy errors and organize parent child data to ensure accurate and reliable structures.",
                Type = SampleType.AI
            },
#endif
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/remote-data",
                FileName = "RemoteData.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor TreeGrid Examples - Remote Data | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Remote Data Binding",
                MetaDescription = "See how the Syncfusion Blazor Remote Data binds hierarchical data from APIs with server processing and dynamic updates to manage external data efficiently."
            },
            new Sample
            {
                Name = "Observable Collection",
                Category = "Data Binding",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/observable-binding",
                FileName = "ObservableCollection.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor TreeGrid - Observable Collection | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Observable Collection Binding",
                MetaDescription = "See how the Syncfusion Blazor Observable Collection updates UI automatically with change tracking and binding for real time hierarchical data updates.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ObservableCollection",
                        FileName="ObservableBinding.razor"
                    },
                    new SourceCollection
                    {
                        Id="ObservableCollectionCode",
                        FileName="ObservableBinding.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="ObservableDataProperties",
                        FileName="ObservableCollectionProperties.cs"
                    },
                    new SourceCollection
                    {
                        Id="ObservableData",
                        FileName="ObservableCollectionData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "ExpandoObject Binding",
                Category = "Data Binding",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/expando-object",
                FileName = "TreeGridExpandoObject.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor TreeGrid - ExpandoObject Binding | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - ExpandoObject Binding",
                MetaDescription = "See how the Syncfusion Blazor ExpandoObject Binding supports dynamic objects with flexible schemas and CRUD operations for hierarchical data handling."
            },
            new Sample
            {
                Name = "DynamicObject Binding",
                Category = "Data Binding",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/dynamic-object",
                FileName = "TreeGridDynamicObject.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor TreeGrid - DynamicObject Binding | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - DynamicObject Binding",
                MetaDescription = "See how the Syncfusion Blazor DynamicObject Binding handles runtime object creation and editing with custom properties for flexible hierarchical data scenarios."
            },

            new Sample
            {
                Name = "Column Template",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/column-template",
                Type = SampleType.None,
                FileName="ColumnTemplate.razor",
                MetaTitle = "Blazor TreeGrid - Column Template | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Column Template",
                MetaDescription = "See how the Syncfusion Blazor Column Template customizes hierarchical cells with templates, HTML content, and UI elements to enhance data presentation.",
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
                MetaTitle = "Blazor TreeGrid - Header Template | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Header Template",
                MetaDescription = "See how the Syncfusion Blazor Header Template customizes column headers with HTML templates, styling, and controls to improve grid appearance and usability.",
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
                        FileName="WrapData.cs"
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
                MetaTitle = "Blazor TreeGrid Examples - Reorder | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Reorder",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid enables drag and drop column reordering with flexible layout control to customize hierarchical data views effectively.",
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
                        FileName="EmployeeData.cs"
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
                MetaTitle = "Blazor TreeGrid Examples - Resizing | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Resizing",
                MetaDescription = "See how the Syncfusion Blazor Resizing adjusts column widths interactively with layout control to improve readability and optimize hierarchical data display.",
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
                        FileName="SupportTicketData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Stacked Header",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/stacked-header",
                FileName="Resizing.razor",
                MetaTitle = "Blazor TreeGrid - Stacked Header | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Stacked Header",
                MetaDescription = "See how the Syncfusion Blazor Stacked Header groups columns under shared headers with hierarchy and organization to improve readability of complex data.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="StackedHeader",
                        FileName="StackedHeader.razor"
                    },
                    new SourceCollection
                    {
                        Id="StackedHeaderData",
                        FileName="SupportTicketData.cs"
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
                MetaTitle = "Blazor TreeGrid Examples - Column Menu | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Column Menu",
                MetaDescription = "See how the Syncfusion Blazor Column Menu provides sorting, filtering, and visibility controls through menus to simplify interaction with hierarchical data.",
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
                        FileName="SupportTicketData.cs"
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
                MetaTitle = "Blazor TreeGrid Examples - Auto Wrap Column Cells | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Auto Wrap Column Cells",
                MetaDescription = "See how the Syncfusion Blazor Auto Wrap Column Cells wraps long text with automatic line breaks and row adjustments to enhance readability of nested data.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="AutoWrap",
                        FileName="AutoWrap.razor"
                    },
                    new SourceCollection
                    {
                        Id="SupportTicketData",
                        FileName="SupportTicketData.cs"
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
                MetaTitle = "Blazor TreeGrid - Column Chooser | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Column Chooser",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid provides a column chooser to show or hide fields dynamically, helping customize and manage hierarchical layouts easily.",
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
                        FileName="SupportTicketData.cs"
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
                MetaTitle = "Blazor TreeGrid - Show or Hide Column | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Show or Hide Column",
                MetaDescription = "See how the Syncfusion Blazor Show or Hide Column toggles visibility programmatically with layout retention and flexibility for dynamic data presentation.",
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
                        FileName="TaskData.cs"
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
                MetaTitle = "Blazor TreeGrid - Frozen Columns | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Frozen Columns",
                MetaDescription = "See how the Syncfusion Blazor Frozen Columns keeps important columns visible during scrolling with pinning features to improve navigation in wide datasets.",
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
                        FileName="TaskData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Sticky Header",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/sticky-header",
                Type = SampleType.None,
                FileName="StickyHeader.razor",
                MetaTitle = "Blazor TreeGrid - Sticky Header | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Sticky Header",
                MetaDescription = "See how the Syncfusion Blazor Sticky Header keeps column headers visible while scrolling with positioning features to improve navigation and context clarity.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="StickyHeader",
                        FileName="StickyHeader.razor"
                    }
                }
            },
            new Sample
            {
                Name = "Column Spanning",
                Category = "Columns",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/row-and-column-spanning",
                FileName="StickyHeader.razor",
                MetaTitle = "Blazor TreeGrid - Column Spanning | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Row and Column Spanning",
                MetaDescription = "See how the Syncfusion Blazor Column Spanning merges cells across rows and columns with span logic to improve readability and structure in hierarchical grids.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowandColumnSpanning",
                        FileName="TreeGridAutoSpanMode.razor"
                    },
                    new SourceCollection
                    {
                        Id="RowandColumnSpanningData",
                        FileName="ProjectTask.cs"
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
                MetaTitle = "Blazor TreeGrid Examples - Row Template | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Row Template",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid supports row templates with custom layouts, images, and components to create rich hierarchical data presentations.",
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
                        FileName="ProjectPortfolioData.cs"
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
                MetaTitle = "Blazor TreeGrid - Detail Template | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Detail Template",
                MetaDescription = "See how the Syncfusion Blazor Detail Template expands rows with nested templates and additional data to provide deeper insights into hierarchical records.",
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
                MetaTitle = "Blazor TreeGrid - Drag and Drop | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Drag and Drop",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid supports drag and drop between grids with hierarchy support, simplifying data movement and organization across datasets.",
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
                        FileName="TaskData.cs"
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
                MetaTitle = "Blazor TreeGrid - Drag and Drop within Tree Grid | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Drag and Drop within Tree Grid",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid allows drag and drop within the grid to reorder rows while preserving hierarchy and improving data organization workflow.",
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
                        FileName="TaskData.cs"
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
                MetaTitle = "Blazor TreeGrid Examples - Row Hover | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Row Hover",
                MetaDescription = "See how the Syncfusion Blazor Row Hover highlights rows with interactive styles and effects to improve user feedback and navigation in hierarchical grids.",
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
                        FileName="ShipmentData.cs"
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
                MetaTitle = "Blazor TreeGrid Examples - Row Height | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Row Height",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid allows row height adjustment with layout flexibility to improve readability and spacing in hierarchical data displays.",
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
                        FileName="WrapData.cs"
                    }
                }
            },
            new Sample
            {
                Name ="Row Spanning",
                Category = "Rows",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/row-and-column-spanning",
                FileName="TreeGridAutoSpanMode.razor",
                MetaTitle = "Blazor TreeGrid Examples - Row Spanning | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Row and Column Spanning",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid supports row spanning to merge adjacent cells, improving readability and presentation of grouped hierarchical data.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowandColumnSpanning",
                        FileName="TreeGridAutoSpanMode.razor"
                    },
                    new SourceCollection
                    {
                        Id="RowandColumnSpanning",
                        FileName="ProjectTask.cs"
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
                MetaTitle = "Blazor TreeGrid - Inline Editing | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Inline Editing",
                MetaDescription = "See how the Syncfusion Blazor Inline Editing enables direct cell updates with validation and keyboard support to quickly edit hierarchical data records.",
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
                        FileName="FieldServiceScheduleData.cs"
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
                MetaTitle = "Blazor TreeGrid - Dialog Editing | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Dialog Editing",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid uses dialog editing with forms and validation support to update hierarchical data in a structured and user friendly way.",
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
                        FileName="EmployeeData.cs"
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
                MetaTitle = "Blazor TreeGrid - Batch Editing | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Batch Editing",
                MetaDescription = "See how the Syncfusion Blazor Batch Editing allows editing multiple rows with deferred saving and validation to improve efficiency in hierarchical updates.",
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
                MetaTitle = "Blazor TreeGrid - Command Column | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Command Column",
                MetaDescription = "See how the Syncfusion Blazor Command Column adds action buttons for edit delete and custom operations to streamline hierarchical data management tasks.",
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
                        FileName="TaskData.cs"
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
                MetaTitle = "Blazor TreeGrid - Cell Edit Type | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Cell Edit Type",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid supports different cell edit types with various input controls to handle multiple data formats in hierarchical editing.",
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
                        FileName="WrapData.cs"
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
                MetaTitle = "Blazor TreeGrid - Edit Template | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Edit Template",
                MetaDescription = "See how the Syncfusion Blazor Edit Template customizes editors with templates and controls to provide tailored interfaces for hierarchical data editing.",
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
                        FileName="WrapData.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Default Sorting",
                Category = "Sorting",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/sorting",
                Type = SampleType.None,
                FileName="Sorting.razor",
                MetaTitle = "Blazor TreeGrid - Default Sorting | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Sorting",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid enables multi column sorting while preserving hierarchy, helping organize structured data efficiently for analysis.",
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
                Name = "Custom Sorting",
                Category = "Sorting",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/customsorting",
                FileName="CustomSorting.razor",
                MetaTitle = "Blazor TreeGrid - Custom Sorting | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor TreeGrid Example - Custom Sorting",
                MetaDescription = "See how the Syncfusion Blazor Custom Sorting applies custom logic and comparison rules to sort hierarchical data based on specific business requirements.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CustomSorting",
                        FileName="CustomSorting.razor"
                    },
                    new SourceCollection
                    {
                        Id="CustomSorting",
                        FileName="TaskData.cs"
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
                MetaTitle = "Blazor TreeGrid - Default Filtering | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Default Filtering",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid applies filtering with operators while preserving hierarchy, enabling accurate refinement of structured data results.",
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
                        FileName="EmployeeData.cs"
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
                MetaTitle = "Blazor TreeGrid - Filterbar Template | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Filterbar Template",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid supports filter bar templates to customize filtering UI and enable advanced data filtering in hierarchical columns.",
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
                        FileName="SupportTicketData.cs"
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
                MetaTitle = "Blazor TreeGrid Examples - Menu Filter | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Menu Filter",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid provides menu based filtering with multiple conditions to refine hierarchical data efficiently using structured options.",
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
                        FileName="SupportTicketData.cs"
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
                MetaTitle = "Blazor TreeGrid - Excel like Filter | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Excel like Filter",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid enables Excel like filtering with checkbox and search options to refine hierarchical data quickly and intuitively.",
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
                        FileName="EmployeeData.cs"
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
                MetaTitle = "Blazor TreeGrid Examples - Search | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Search",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid enable search across columns with highlighting, allowing quick discovery of hierarchical data while preserving structure.",
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
                        FileName="EmployeeData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Default Paging",
                Category = "Paging",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/paging",
                Type = SampleType.None,
                FileName="Paging.razor",
                MetaTitle = "Blazor TreeGrid - Default Paging | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Paging",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid supports paging to navigate hierarchical data efficiently while maintaining structure and improving browsing experience.",
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
                        FileName="ShipmentData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Default Aggregates",
                Category = "Aggregates",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/aggregate",
                Type = SampleType.None,
                FileName="Aggregate.razor",
                MetaTitle = "Blazor TreeGrid - Default Aggregates | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Aggregates",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid calculates aggregates like sum and average with grouping support to summarize hierarchical datasets effectively.",
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
                        FileName="SummaryRowData.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Custom Aggregates",
                Category = "Aggregates",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/custom-aggregate",
                FileName="CustomAggregates.razor",
                MetaTitle = "Blazor TreeGrid - Custom Aggregates | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Custom Aggregates",
                MetaDescription = "See how the Syncfusion Blazor Custom Aggregates applies user defined summary logic with grouping to support advanced hierarchical data reporting needs.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CustomAggregate",
                        FileName="CustomAggregates.razor"
                    },
                    new SourceCollection
                    {
                        Id="CustomAggregatedata",
                        FileName="ShipmentData.cs"
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
                MetaTitle = "Blazor TreeGrid - Default Selection | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Default Selection",
                MetaDescription = "See how the Syncfusion Blazor Default Selection supports row and cell selection with modes and keyboard navigation for better hierarchical interaction.",
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
                        FileName="SupportTicketData.cs"
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
                MetaTitle = "Blazor TreeGrid - Checkbox Selection | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Checkbox Selection",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid enables checkbox row selection with persistence support to perform efficient bulk operations on hierarchical data.",
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
                        FileName="EmployeeData.cs"
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
                MetaTitle = "Blazor TreeGrid - Selection API | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Selection API",
                MetaDescription = "See how the Syncfusion Blazor Selection API provides programmatic control of selections with methods and events for managing hierarchical data actions.",
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
                        FileName="SupportTicketData.cs"
                    }
                }
            },

            new Sample
            {
                Name = "List Binding",
                Category = "Virtual Scrolling",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/virtual-scrolling",
                Type = SampleType.None,
                FileName="VirtualScrolling.razor",
                MetaTitle = "Blazor TreeGrid Examples - List Binding | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Virtual Scrolling with List Binding",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid supports clipboard copy and paste operations with formatting to transfer hierarchical data efficiently across apps.",
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

            new Sample
            {
                Name = "Remote Data Binding",
                Category = "Virtual Scrolling",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/remote-data-with-virtualization",
                FileName = "RemoteDataWithVirtualization.razor",
                MetaTitle = "Blazor TreeGrid - Remote Data Binding | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Virtual Scrolling with Remote Data Binding",
                MetaDescription = "See how the Syncfusion Blazor Remote Data Binding loads hierarchical data from APIs with virtualization and server processing for efficient performance.",
            },

            new Sample
            {
                Name = "Default Exporting",
                Category = "Exporting",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/exporting",
                Type = SampleType.None,
                FileName="Exporting.razor",
                MetaTitle = "Blazor TreeGrid - Default Exporting | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Default Exporting",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid exports hierarchical data to Excel and PDF with formatting and structure preserved for reliable reporting and sharing.",
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
                        FileName="BillOfMaterials.cs"
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
               MetaTitle = "Blazor TreeGrid Examples - Print | TreeGrid Demos | Syncfusion",
               HeaderText = "Blazor Tree Grid Example - Print",
               MetaDescription = "See how the Syncfusion Blazor TreeGrid supports printing with formatting and layout customization to generate clear and structured hierarchical data reports.",
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
                       FileName="ShipmentData.cs"
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
                MetaTitle = "Blazor TreeGrid - Persist State | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Persist State",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid persists state for filters, sorting, and layouts, ensuring consistent hierarchical grid behavior across sessions.",
                SourceFiles = new List<SourceCollection>()
               {
                   new SourceCollection
                   {
                       Id="PersistState",
                       FileName="Persistence.razor"
                   },
                   new SourceCollection
                   {
                       Id="PersistenceData",
                       FileName="WrapData.cs"
                   }
               }
            },
            new Sample
            {
                Name = "Context Menu",
                Category = "Miscellaneous",
                Directory = "TreeGrid/TreeGrid",
                Url = "tree-grid/context-menu",
                FileName="ContextMenu.razor",
                MetaTitle = "Blazor TreeGrid Examples - Context Menu | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Context Menu",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid provides context menu actions with commands and options to simplify hierarchical data operations and improve usability.",
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
                        FileName="SupportTicketData.cs"
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
                MetaTitle = "Blazor TreeGrid Examples - Events | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Events",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid handles events for user actions and data updates, enabling dynamic control over hierarchical grid interactions.",
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
                        FileName="SelfData.cs"
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
                MetaTitle = "Blazor TreeGrid Examples - Clipboard | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Clipboard",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid supports clipboard copy and paste with formatting, enabling efficient transfer of hierarchical data across applications.",
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
                        FileName="TaskData.cs"
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
                MetaTitle = "Blazor TreeGrid Examples - Conditional Formatting Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Conditional Formatting",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid applies conditional formatting based on values to highlight key data and improve readability in hierarchical grid views.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Formatting",
                        FileName="ConditionalFormatting.razor"
                    },
                    new SourceCollection
                    {
                        Id="TaskData",
                        FileName="TaskData.cs"
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
                MetaTitle = "Blazor TreeGrid - Toolbar Template | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Toolbar Template",
                MetaDescription = "See how the Syncfusion Blazor TreeGrid supports toolbar templates to customize actions with buttons and layouts, enhancing usability and functionality.",
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
                        FileName="TaskData.cs"
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
                MetaTitle = "Blazor TreeGrid - Keyboard Navigation | TreeGrid Demos | Syncfusion",
                HeaderText = "Blazor Tree Grid Example - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor Keyboard Navigation supports shortcuts for selection editing and navigation to improve accessibility in hierarchical grids.",
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
                        FileName="TaskData.cs"
                    }
                }
            }
        };
    }
}