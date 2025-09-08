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
        public List<Sample> DataGrid { get; set; } = new List<Sample>{
             new Sample
            {
                Name = "Overview",
                Category = "DataGrid",
                Directory = "Grid/DataGrid",
                Url = "datagrid/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor DataGrid Example | Grid Overview | Syncfusion Demos",
                HeaderText = "Blazor DataGrid Example - Overview",
                MetaDescription = "This Blazor DataGrid example provides an overview of its features, focusing on performance metrics calculated for managing large volumes of data efficiently.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Overview.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OverviewData.cs"
                    }
                }
            },
             
            new Sample
            {
                Name = "Default Functionalities",
                Category = "DataGrid",
                Directory = "Grid/DataGrid",
                Url = "datagrid/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Grid Example | Default Functionalities | Syncfusion Demos",
                HeaderText = "Blazor Grid Example - Default Functionalities",
                MetaDescription = "This demo highlights the default rendering of the Blazor Grid using minimal configuration, demonstrating its core functionalities with basic setup requirements.",
                Type = SampleType.None,
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
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Adaptive Layout",
                Category = "DataGrid",
                Directory = "Grid/DataGrid",
                Url = "datagrid/adaptive-rendering",
                FileName = "AdaptiveRendering.razor",
                MetaTitle = "Blazor DataGrid Adaptive Layout | Responsive Grid | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Adaptive Rendering",
                MetaDescription = "Blazor Grid adaptive layout demo shows design for various screen sizes. It dynamically adjusts its layout for optimal viewing on mobile and desktop devices.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="AdaptiveRendering.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetail.cs"
                    }
                }
            },
            #if SERVER
            new Sample
            {
                Name = "Semantic Filtering (Embedding)",
                Category = "Smart AI Solutions",
                Directory = "AISamples/DataGrid",
                Url = "datagrid/semantic-filtering",
                FileName = "GridSemanticFiltering.razor",
                MetaTitle = "DataGrid Semantic Filtering Example - Syncfusion AI Demos",
                HeaderText = "Blazor DataGrid Example - Semantic Filtering with Embedding",
                MetaDescription = "This semantic filtering demo shows advanced filtering using natural language processing. Users can filter data using context-aware queries to find information.",
                NotificationDescription = new string[]{ @"This demo shows the semantic filtering AI feature in Data Grid." },
                Type = SampleType.AI
            },
            new Sample
            {
                Name = "Anomaly Detection",
                Category = "Smart AI Solutions",
                Directory = "AISamples/DataGrid",
                Url = "datagrid/ai-anomaly-detection",
                FileName = "AnomalyData.razor",
                MetaTitle = "Blazor DataGrid Anomaly Detection - Syncfusion AI Demos",
                HeaderText = "Blazor DataGrid Example - AI-Powered Anomaly Detection",
                MetaDescription = "This demo shows AI integration to identify unusual pattern in your data. Quickly spot outliers, statistical anomalies for better data analysis, decision making.",
                Type = SampleType.AI
            },
#endif
            new Sample
            {
                Name = "FIFA Statistics",
                Category = "Product Use Case",
                Directory = "Grid/DataGrid",
                Url = "datagrid/fifa-statistics",
                FileName = "FifaStatistics.razor",
                MetaTitle = "Blazor DataGrid | FIFA World Cup Statistics | Syncfusion",
                HeaderText = "Blazor DataGrid Example - FIFA World Cup Statistics",
                MetaDescription = "Blazor DataGrid demo shows FIFA World Cup data with rich visuals including flags, icons, and tooltips. Display historical tournament data with custom templates.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="FifaStatistics.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="FifaData.cs"
                    }
                },
            },
            new Sample
            {
                Name = "List Binding",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/local-data",
                FileName = "LocalData.razor",
                MetaTitle = "Blazor DataGrid List Binding | Local Data Source | Syncfusion",
                HeaderText = "Blazor DataGrid Example - List Data Binding",
                MetaDescription = "This Blazor DataGrid list binding example shows how to bind local collection and display and manipulate in-memory data collections with full CRUD capabilities.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="LocalData.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/remote-data",
                FileName = "RemoteData.razor",
                MetaTitle = "Blazor DataGrid Remote Data | Web API Integration | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Remote Data Binding",
                MetaDescription = "Blazor Grid remote data demo shows fetching and binding data from web services. Connect to RESTful API with built-in data operations for server-side processing.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Flexible Data",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/flexible-data",
                FileName = "FlexibleData.razor",
                MetaTitle = "Blazor DataGrid Flexible Data | Dynamic Schema | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Flexible Data Binding",
                MetaDescription = "Blazor DataGrid flexible data demo shows handling dynamic data structures. Adapt to varying data schemas with auto-generated columns and dynamic field mapping.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Custom Binding",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/custom-binding",
                FileName = "CustomBinding.razor",
                MetaTitle = "Blazor DataGrid Custom Binding | Data Adapters | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Custom Data Binding",
                MetaDescription = "Blazor Grid custom binding demo shows connecting to specialized data sources. Implement custom data adapters for advanced scenarios with manual data operations.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="CustomBinding.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrderDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "DataTable Binding",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/datatable-binding",
                FileName = "DataTableBinding.razor",
                MetaTitle = "Blazor DataGrid DataTable Binding | ADO.NET | Syncfusion",
                HeaderText = "Blazor DataGrid Example - DataTable Binding",
                MetaDescription = "Blazor Grid DataTable binding demo shows connecting to DT objects. Easily display ADO.NET results with automatic column generation and full CRUD capabilities.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Data Annotation",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/data-annotation",
                FileName = "DataAnnotation.razor",
                MetaTitle = "Blazor DataGrid Data Annotation | Validation | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Data Annotations",
                MetaDescription = "Blazor DataGrid data annotation demo shows using model attributes for validation. Apply display, format, and validation rules directly via C# model annotations.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Observable Collection",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/observable-binding",
                FileName="ObservableBinding.razor",
                MetaTitle = "Blazor DataGrid Observable Collection | Real-time Updates | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Observable Collection Binding",
                MetaDescription = "Blazor Grid observable collection demo shows automatic UI updates when data changes. Track collection changes for real-time grid updates without manual refresh.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "ExpandoObject Binding",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/expandoobject",
                FileName = "GridExpandoObject.razor",
                MetaTitle = "Blazor DataGrid ExpandoObject Binding | Dynamic Property | Syncfusion",
                HeaderText = "Blazor DataGrid Example - ExpandoObject Binding",
                MetaDescription = "This Blazor Grid ExpandoObject binding demo shows working with dynamic objects. Bind to objects with runtime-defined properties for flexible data structures.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "DynamicObject Binding",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/dynamicobject",
                FileName = "GridDynamicObject.razor",
                MetaTitle = "Blazor DataGrid DynamicObject Binding | Custom Objects | Syncfusion",
                HeaderText = "Blazor DataGrid Example - DynamicObject Binding",
                MetaDescription = "Blazor Grid DynamicObject binding demo shows working with custom dynamic types. Display and edit objects with custom property resolution for advanced scenarios.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Column Template",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/column-template",
                FileName = "ColumnTemplate.razor",
                MetaTitle = "Blazor DataGrid Column Template | Custom Cell Content | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Column Templates",
                MetaDescription = "Blazor Grid column template demo shows custom cellcontent rendering. Create rich data visualization with images, buttons, and interactive elements within cells.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ColumnTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="Employee.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Header Template",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/header-template",
                FileName = "GridHeaderTemplate.razor",
                MetaTitle = "Blazor DataGrid Header Template | Custom Headers | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Header Templates",
                MetaDescription = "This Blazor DataGrid header template demo shows custom column header rendering. Create interactive headers with filters, sorting indicators, and custom styling.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="GridHeaderTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="Employee.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Stacked Header",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/stacked-header",
                FileName = "GridStackedHeader.razor",
                MetaTitle = "Blazor DataGrid Stacked Header | Grouped Columns | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Stacked Headers",
                MetaDescription = "Blazor DataGrid stacked header demo shows hierarchical column organization. Group related columns under common header titles for better data categorization.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="GridStackedHeader.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Foreign Key Column",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/foreign-key-column",
                FileName = "ForeignKeyColumn.razor",
                MetaTitle = "Blazor DataGrid Foreign Key Column | Lookup Values | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Foreign Key Columns",
                MetaDescription = "Blazor DataGrid foreign key column demo shows displaying lookup values from related tables. Convert ID values to their display text from reference collections.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Column Reorder",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/reorder",
                FileName = "Reorder.razor",
                MetaTitle = "Blazor DataGrid Column Reorder | Drag Columns | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Column Reordering",
                MetaDescription = "Blazor Grid column reorder demo shows drag and drop column rearrangement. Allows customize their view by changing column positions with intuitive interactions.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Reorder.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "AutoFit and Resizing",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/column-resize",
                FileName = "Columnresize.razor",
                MetaTitle = "Blazor DataGrid Column Resize | AutoFit Columns | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Column Resizing and AutoFit",
                MetaDescription = "This Blazor DataGrid column resize demo shows adjustable column widths and automatic sizing. Resize columns fit to content with built-in autofit capabilities.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ColumnResize.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Column Menu",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/column-menu",
                FileName = "Columnmenu.razor",
                MetaTitle = "Blazor DataGrid Column Menu | Header Options | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Column Menu",
                MetaDescription = "Blazor DataGrid column menu demo shows header-based operations menu. Access sorting, filtering, and column visibility options directly from each column header.",
                Type = SampleType.None,
		IsHideInMobile = true,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ColumnMenu.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Autowrap Column Cells",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/auto-wrap",
                FileName = "AutoWrap.razor",
                MetaTitle = "Blazor DataGrid Autowrap | Text Wrapping | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Autowrap Column Cells",
                MetaDescription = "Blazor Grid autowrap demo shows text wrapping in cells with long content. Handle large text values graceful with automatic line break and adjustable row height.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="AutoWrap.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="InventorData.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Column Chooser",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/column-chooser",
                FileName = "ColumnChooser.razor",
                MetaTitle = "Blazor DataGrid Column Chooser | Column Selection | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Column Chooser",
                MetaDescription = "This Blazor DataGrid column chooser demo shows dynamic column visibility control. Allow users to show or hide columns through an interactive dialog for views.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ColumnChooser.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Column Chooser Template",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/column-chooser-template",
                FileName = "ColumnChooserTemplate.razor",
                MetaTitle = "Blazor DataGrid Column Chooser Template | Custom UI | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Column Chooser Template",
                MetaDescription = "Blazor DataGrid column chooser template demo shows custom column selection. Design a tailored column visibility dialog with grouping, search, and other options.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ColumnChooserTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Show or Hide Column",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/show-or-hide-column",
                FileName = "ShoworHideColumn.razor",
                MetaTitle = "Blazor DataGrid Show Hide Columns | Dynamic Visibility | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Show or Hide Columns",
                MetaDescription = "Blazor Grid show/hide column demo shows programmatic column visibility control. Toggle column display at runtime with animation effects and retain grid layout.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ShoworHideColumn.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Cell Formatting",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/cell-formatting",
                FileName = "Cellformatting.razor",
                MetaTitle = "Blazor DataGrid Cell Formatting | Custom Display | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Cell Formatting",
                MetaDescription = "Blazor DataGrid cell formatting demo shows custom cell value presentation. Apply conditional formatting, number/date formats, and styling based on cell values.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="CellFormatting.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="CellData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Custom Command",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/custom-command",
                FileName = "CustomCommand.razor",
                MetaTitle = "Blazor DataGrid Custom Command | Action Buttons | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Custom Command Buttons",
                MetaDescription = "Blazor Grid custom command demo shows adding action buttons to rows. Create interactive operations like view details, edit or delete with custom button styling.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Fixed Columns",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/fixed-column",
                FileName = "FixedColumn.razor",
                MetaTitle = "Blazor DataGrid Fixed Columns | Freeze Columns | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Fixed Columns",
                MetaDescription = "Blazor DataGrid fixed columns demo shows freezing columns during horizontal scrolling. Keep important columns visible while navigating through wide datasets.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Row Template",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "datagrid/row-template",
                FileName = "GridRowTemplate.razor",
                MetaTitle = "Blazor DataGrid Row Template | Custom Row Layout | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Row Templates",
                MetaDescription = "Blazor DataGrid row template demo shows custom row rendering. Create highly customized row layouts with complex content, images, and mixed components per row.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="GridRowTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="Employee.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Detail Template",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "datagrid/detail-template",
                FileName = "GridDetailTemplate.razor",
                MetaTitle = "Blazor DataGrid Detail Template | Expandable Rows | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Detail Templates",
                MetaDescription = "This Blazor DataGrid detail template demo shows expandable row details. Display additional information or related data in collapsible sections within each row.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="GridDetailTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="Employee.cs"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="EmployeeOrders.cs"
                    }
                }
            },
            new Sample
             {
                 Name = "Drag and Drop",
                 Category = "Rows",
                 Directory = "Grid/DataGrid",
                 Url = "datagrid/row-drag-and-drop",
                 FileName = "RowDragAndDrop.razor",
                 MetaTitle = "Blazor DataGrid Drag Drop | Row Reordering | Syncfusion",
                 HeaderText = "Blazor DataGrid Example - Drag and Drop Rows",
                 MetaDescription = "This Blazor DataGrid drag and drop example demonstrates row reordering between grids. Move rows across different grids with drag handles and visual indicators.",
                 Type = SampleType.None,
                 SourceFiles = new List<SourceCollection>()
                 {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="RowDragAndDrop.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrderDetail.cs"
                    }
                 }
             },
            new Sample
            {
               Name = "Drag and Drop within Grid",
               Category = "Rows",
               Directory = "Grid/DataGrid",
               Url = "datagrid/draganddrop-within-grid",
               FileName = "DragAndDropWithinGrid.razor",
               MetaTitle = "Blazor DataGrid Row Reordering | Internal Drag Drop | Syncfusion",
               HeaderText = "Blazor DataGrid Example - Drag and Drop within Grid",
               MetaDescription = "Blazor DataGrid internal drag and drop demo shows row reordering within the same grid. Resequence rows with intuitive drag handles and visual drop indicators.",
               Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="DragAndDropWithinGrid.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }

            },
            new Sample
            {
                Name = "Row Hover",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "datagrid/row-hover",
                FileName = "RowHover.razor",
                MetaTitle = "Blazor DataGrid Row Hover | Interactive Rows | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Row Hover Effects",
                MetaDescription = "Blazor Grid row hover demo shows interactive row highlighting. Apply visual feedback when users hover over rows with customizable colors and transition effects.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="RowHover.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="Product.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Row Height",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "datagrid/row-height",
                FileName = "RowHeight.razor",
                MetaTitle = "Blazor DataGrid Row Height | Custom Row Sizing | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Row Height Customization",
                MetaDescription = "This Blazor DataGrid row height demo shows customizing row dimensions. Apply varying heights to rows for better content accommodation and visual presentation.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="RowHeight.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Inline Editing",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "datagrid/inline-editing",
                FileName = "InlineEditing.razor", 
                MetaTitle = "Blazor DataGrid Inline Editing | Cell Editing | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Inline Editing",
                MetaDescription = "Blazor Grid inline editing demo shows direct cell editing. Edit data without dialogs using keyboard navigation and built-in validation for quick data updates.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="InlineEditing.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="Orders.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Dialog Editing",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "datagrid/dialog-editing",
                FileName = "DialogEditing.razor",
                MetaTitle = "Blazor DataGrid Dialog Editing | Form Editing | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Dialog Editing",
                MetaDescription = "Blazor DataGrid dialog editing demo shows form-based data editing. Edit records in a modal dialog with validation, multi-field forms, and customizable layout.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="DialogEditing.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Dialog Template",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "datagrid/grid-dialog-template",
                FileName = "GridDialogTemplate.razor",
                MetaTitle = "Blazor DataGrid Dialog Template | Custom Edit Forms | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Dialog Template",
                MetaDescription = "This Blazor DataGrid dialog template example demonstrates custom edit form designs. Create specialized edit interfaces with complex layouts, validation.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="GridDialogTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Batch Editing",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "datagrid/batch-editing",
                FileName = "BatchEditing.razor",
                MetaTitle = "Blazor DataGrid Batch Editing | Multiple Cell Edits | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Batch Editing",
                MetaDescription = "Blazor Grid batch editing demo shows multiple cell editing with deferred saving. Edit multiple cells across rows and save all changes at once for data updates.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="BatchEditing.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Command Column",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "datagrid/command-column",
                FileName = "CommandColumn.razor",
                MetaTitle = "Blazor DataGrid Command Column | Action Buttons | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Command Column",
                MetaDescription = "Blazor Grid command column demo shows built-in action button for CRUD operations. Add edit, delete, save and cancel buttons with custom appearance and behavior.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="CommandColumn.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "External Form Editing",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "datagrid/external-form-editing",
                FileName = "ExternalFormEditing.razor",
                MetaTitle = "Blazor DataGrid External Form | Custom Form Editing | Syncfusion",
                HeaderText = "Blazor DataGrid Example - External Form Editing",
                MetaDescription = "Blazor Grid external form demo shows separate form-based editing. Create custom edit interface outside grid with full integration for adding & updating records.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ExternalFormEditing.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrderDetails.cs"
                    }
                }
                 
            },
            new Sample
            {
                Name = "Custom Validation",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "datagrid/custom-validation",
                FileName = "CustomValidation.razor",
                MetaTitle = "Blazor DataGrid Custom Validation | Edit Validation | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Custom Validation",
                MetaDescription = "Blazor Grid custom validation demo shows advanced input validation. Apply business rules, cross-field validation, and custom error messages during data editing.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multi Sorting",
                Category = "Sorting",
                Directory = "Grid/DataGrid",
                Url = "datagrid/sorting",
                FileName = "Sorting.razor",
                MetaTitle = "Blazor DataGrid Multi Sorting | Multiple Column Sort | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Multi-Column Sorting",
                MetaDescription = "Blazor Grid multisorting demo shows orders by multiple columns simultaneously. Create complex sorting scenarios with column precedence and mixed sort direction.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Sorting.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrderDetails.cs"
                    }
                 
                },
            },
            new Sample
            {
                Name = "Custom Sorting",
                Category = "Sorting",
                Directory = "Grid/DataGrid",
                Url = "datagrid/customsorting",
                FileName = "CustomSorting.razor",
                MetaTitle = "Blazor DataGrid Custom Sorting | Sort Comparer | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Custom Sorting Logic",
                MetaDescription = "Blazor DataGrid custom sorting demo shows specialized sorting algorithms. Implement custom comparison logic for complex data types/unique sorting requirements.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="CustomSorting.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="TaskDetails.cs"
                    }
                 
               },
            },
            new Sample
            {
                Name = "Default Filtering",
                Category = "Filtering",
                Directory = "Grid/DataGrid",
                Url = "datagrid/filtering",
                FileName = "Filtering.razor",
                MetaTitle = "Blazor DataGrid Filtering | Data Filters | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Default Filtering",
                MetaDescription = "Blazor Grid filtering demo shows built-in filter operations. Apply text, numeric, date, and boolean filters with various operators for precise data filtering.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Filtering.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="Category.cs"
                    }
                 
                },
            },
             new Sample
            {
                Name = "Menu Filter",
                Category = "Filtering",
                Directory = "Grid/DataGrid",
                Url = "datagrid/filter-menu",
                FileName = "FilterMenu.razor",
                MetaTitle = "Blazor DataGrid Menu Filter | Filter UI | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Menu Filter Interface",
                MetaDescription = "Blazor Grid menu filter demo shows dropdown-based filtering. Apply filters via a convenient menu interface with specific input controls and multiple conditions.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="FilterMenu.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="FilterOrderDetails.cs"
                    }
                 
                },
            },
             new Sample
            {
                Name = "Checkbox Filter",
                Category = "Filtering",
                Directory = "Grid/DataGrid",
                Url = "datagrid/checkbox-filter",
                FileName = "FilterCheckbox.razor",
                MetaTitle = "Blazor DataGrid Checkbox Filter | Multi-Select Filter | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Checkbox Filtering",
                MetaDescription = "Blazor Grid checkbox filter demo shows multi-select value filtering. Choose multiple values from checkboxes to create OR-combined filters for categorical data.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="FilterCheckbox.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                 
                },
            },
             new Sample
            {
                Name = "Excel like Filter",
                Category = "Filtering",
                Directory = "Grid/DataGrid",
                Url = "datagrid/excel-like-filter",
                FileName = "FilterExcel.razor",
                MetaTitle = "Blazor DataGrid Excel Filter | Excel-Style Filtering | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Excel-like Filtering",
                MetaDescription = "Blazor Grid Excel filter demo shows MS Excel-style filtering interface. Apply multiple value filters and custom conditions with an intuitive filter experience.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="FilterExcel.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                 
                },
            },
            new Sample
            {
               Name = "Searching",
               Category = "Filtering",
               Directory = "Grid/DataGrid",
               Url = "datagrid/search",
               FileName = "Search.razor",
               MetaTitle = "Blazor DataGrid Search | Global Data Search | Syncfusion",
               HeaderText = "Blazor DataGrid Example - Global Searching",
               MetaDescription = "Blazor Grid search demo shows cross-column text search process. Find matching data across all columns with highlighting, accent insensitivity, and case options.",
               Type = SampleType.None,
               SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Search.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="InventorDetails.cs"
                    }
                 
                },
            },
            new Sample
            {
                Name = "Pager Dropdown",
                Category = "Paging",
                Directory = "Grid/DataGrid",
                Url = "datagrid/pager-dropdown",
                FileName = "PagerDropdown.razor",
                MetaTitle = "Blazor DataGrid Pager Dropdown | Page Size Options | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Pager with Dropdown",
                MetaDescription = "This Blazor DataGrid pager dropdown demo shows selectable page sizes. Allow users to change records per page through a dropdown menu for flexible data viewing.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="PagerDropdown.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                 
                },
            },
            new Sample
            {
                Name = "Pager Template",
                Category = "Paging",
                Directory = "Grid/DataGrid",
                Url = "datagrid/pager-template",
                FileName = "PagerTemplate.razor",
                MetaTitle = "Blazor DataGrid Pager Template | Custom Pager | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Custom Pager Template",
                MetaDescription = "This Blazor DataGrid pager template demo shows how to design custom pager layouts with additional features like page size selectors and page information.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="PagerTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrderPage.cs"
                    }
                 
                },
            },
            new Sample
            {
                Name = "Grouping",
                Category = "Grouping",
                Directory = "Grid/DataGrid",
                Url = "datagrid/grouping",
                FileName = "Grouping.razor",
                MetaTitle = "Blazor DataGrid Grouping | Data Categorization | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Row Grouping",
                NotificationDescription = new string[]{ "This sample has been updated to demonstrate the persistence of group expand or collapse states across paging, sorting, filtering, and editing operations." },
                MetaDescription = "This Blazor DataGrid grouping example demonstrates how to group rows by one or more columns with expand or collapse capabilities and customizable group headers.",
                    Type = SampleType.Updated,
                    SourceFiles = new List<SourceCollection>()
                    {
                        new SourceCollection
                        {
                            Id="Default",
                            FileName="Grouping.razor"
                        },
                        new SourceCollection
                        {
                            Id="Data",
                            FileName="Orders.cs"
                        }
                    },
                },
                new Sample
                {
                Name = "Lazy Load with Paging",
                Category = "Grouping",
                Directory = "Grid/DataGrid",
                Url = "datagrid/lazyload-paging",
                FileName = "LazyLoadPaging.razor",
                Type = SampleType.New,
                NotificationDescription = new string[] {"This sample demonstrates lazy loading with paging in the Blazor DataGrid, enabling efficient display of grouped data by loading only page-sized records on demand."},
                MetaTitle = "Blazor DataGrid Lazy Loading | Paging | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Lazy Load with Paging",
                MetaDescription = "This Blazor DataGrid example showcases lazy loading with paging, rendering rows on-demand to enhance performance and provide a seamless user experience."
            },
#if !(WASM)
			new Sample
            {
                Name = "Lazy Load with Virtual Scrolling",
                Category = "Grouping",
                Directory = "Grid/DataGrid",
                Url = "datagrid/lazyload-virtualization",
                FileName = "LazyLoadVirtualization.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Lazy Loading | Virtual Scrolling | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Lazy Load with Virtual Scrolling",
                MetaDescription = "This Blazor DataGrid example demonstrates lazy load virtual scrolling with on-demand data loading as you scroll, progressively handling large datasets."
            },
#endif
            new Sample
            {
                Name = "Lazy Load with Infinite Scrolling",
                Category = "Grouping",
                Directory = "Grid/DataGrid",
                Url = "datagrid/lazyload-infinitescrolling",
                FileName = "LazyLoadGroupingInfiniteScrolling.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Lazy Loading | Infinite Scroll | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Lazy Load with Infinite Scrolling",
                MetaDescription = "Blazor Grid demo shows lazy load infinite scrolling for progressive data while during scroll. Automatically fetch more records when users reach the grid bottom."
            },
            new Sample 
            {
                Name = "Default Aggregate",
                Category = "Aggregates",
                Directory = "Grid/DataGrid",
                Url = "datagrid/aggregate",
                FileName = "Aggregate.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Aggregates | Summary Values | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Default Aggregation",
                MetaDescription = "Blazor Grid aggregation demo shows built-in summary calculations. Display sum, average, count, other statistical values in footer row with automatic formatting.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Aggregate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Group and Caption Aggregate",
                Category = "Aggregates",
                Directory = "Grid/DataGrid",
                Url = "datagrid/group-and-caption-aggregate",
                FileName = "GroupAndCaptionAggregate.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Group Aggregates | Group Summaries | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Group and Caption Aggregates",
                MetaDescription = "Blazor Grid group aggregate demo shows summary values within grouped data. Display statistics for each group with caption/footer summaries for multi insights.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="GroupAndCaptionAggregate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="Category.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Reactive Aggregate",
                Category= "Aggregates",
                Directory= "Grid/DataGrid",
                Url= "datagrid/reactive-aggregate",
                FileName= "ReactiveAggregate.razor",
                Type= SampleType.None,
                MetaTitle = "Blazor DataGrid Reactive Aggregates | Dynamic Summaries | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Reactive Aggregation",
                MetaDescription = "Blazor Grid reactive aggregate demo shows real-time summary updates. Automatically recalculate aggregate when data changes, filtering occurs or rows are edited.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ReactiveAggregate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrderData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Default Selection",
                Category = "Selection",
                Directory = "Grid/DataGrid",
                Url = "datagrid/selection",
                FileName = "Selection.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Selection | Row Selection | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Default Selection",
                MetaDescription = "Blazor Grid selection demo shows row, cell and column selection modes. Configure single/multiple selections with keyboard navigation and programmatic selection.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Selection.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Checkbox Selection",
                Category = "Selection",
                Directory = "Grid/DataGrid",
                Url = "datagrid/checkbox-selection",
                FileName = "CheckboxSelection.razor",
                MetaTitle = "Blazor DataGrid Checkbox Selection | Multi-Select | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Checkbox Selection",
                MetaDescription = "This Blazor DataGrid Checkbox selection example demonstrates how to select individual/all rows with header checkbox and persist selection across data changes.",
                NotificationDescription = new string[]{ "Updated the sample by enabling dynamic data source switching alongside persist selection in Blazor DataGrid." },
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="CheckboxSelection.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Drag Selection",
                Category = "Selection",
                Directory = "Grid/DataGrid",
                Url = "datagrid/drag-selection",
                FileName = "DragSelection.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Drag Selection | Range Select | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Drag Selection",
                MetaDescription = "This Blazor DataGrid drag selection example demonstrates how to select contiguous ranges of cells or rows with mouse drag for efficient multi-selection.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="DragSelection.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Hierarchy Grid",
                Category = "Relational Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/hierarchy-grid",
                FileName = "HierarchyGrid.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Hierarchy | Nested Grids | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Hierarchy Grid",
                MetaDescription = "This Blazor DataGrid hierarchy example demonstrates how to display related data in multi-level hierarchical structure with independent operations per level."
            },
            new Sample
            {
                Name = "Master Detail Grid",
                Category = "Relational Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/master-details",
                FileName = "MasterDetails.razor",
                MetaTitle = "Blazor Master Detail Grid Example - Syncfusion Demos",
                HeaderText = "Blazor Master Detail Grid Example",
                MetaDescription = "This Blazor DataGrid master-detail demo shows how to display detail records in a separate grid based on master row selection with synchronized data operations.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Default Scrolling",
                Category = "Scrolling",
                Directory = "Grid/DataGrid",
                Url = "datagrid/default-scrolling",
                FileName = "DefaultScrolling.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Scrolling | Grid Scroll Options | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Default Scrolling",
                MetaDescription = "Blazor Grid scrolling demo shows basic horizontal and vertical scrolling. Navigate via large dataset with configurable height, width, smooth scrolling behavior.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="DefaultScrolling.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Sticky Header",
                Category = "Scrolling",
                Directory = "Grid/DataGrid",
                Url = "datagrid/sticky-header",
                FileName = "StickyHeader.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Sticky Header | Fixed Headers | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Sticky Header",
                MetaDescription = "This Blazor DataGrid sticky header example demonstrates how to show column headers visible while scrolling through data rows for better context and usability.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="StickyHeader.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Frozen Rows and Columns",
                Category = "Scrolling",
                Directory = "Grid/DataGrid",
                Url = "datagrid/frozen-rows",
                FileName = "FrozenRowsAndColumns.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Frozen Rows & Columns | Pinned Content | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Frozen Rows and Columns",
                MetaDescription = "Blazor Grid frozen rows and columns demo shows pinning rows and columns during scrolling. Keep important data visible while navigating through large datasets.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="FrozenRowsAndColumns.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="TaskDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Scrolling",
                Directory = "Grid/DataGrid",
                Url = "datagrid/virtual-scrolling",
                FileName = "VirtualScrolling.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Virtual Scrolling | DOM Virtualization | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Virtual Scrolling",
                MetaDescription = "This Blazor DataGrid virtual scrolling example demonstrates how to render only visible rows in the DOM for optimal performance with large data volumes."
            },
            new Sample
            {
                Name = "Virtual Mask Row",
                Category = "Scrolling",
                Directory = "Grid/DataGrid",
                Url = "datagrid/virtual-mask-row",
                FileName = "VirtualMaskRow.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Virtual Mask Row | Scroll Placeholders | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Virtual Mask Rows",
                MetaDescription = "This Blazor DataGrid virtual mask row example demonstrates how to show loading indicators while asynchronously fetching data for smoother scrolling experience.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="VirtualMaskRow.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="Order.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Infinite Scrolling",
                Category = "Scrolling",
                Directory = "Grid/DataGrid",
                Url = "datagrid/infinite-scrolling",
                FileName = "InfiniteScrolling.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Infinite Scrolling | Progressive Loading | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Infinite Scrolling",
                MetaDescription = "This Blazor DataGrid infinite scrolling example demonstrates how to load additional records automatically as users scroll to the bottom for seamless browsing."
            },
            new Sample
            {
                Name = "Default Exporting",
                Category = "Exporting",
                Directory = "Grid/DataGrid",
                Url = "datagrid/exporting",
                FileName = "Exporting.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Export | PDF Excel Export | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Default Exporting",
                MetaDescription = "Blazor DataGrid exporting demo shows built-in data export capabilities. Export grid data to Excel, PDF, and CSV formats with configurable options and styling.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Exporting.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Advanced Exporting",
                Category = "Exporting",
                Directory = "Grid/DataGrid",
                Url = "datagrid/advanced-exporting",
                FileName = "AdvancedExporting.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Advanced Export | Custom Export | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Advanced Exporting",
                MetaDescription = "Blazor Grid advanced export demo shows how to configure headers, footers, file names, and styling for Excel and PDF exports with multiple customization options.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="AdvancedExporting.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="Product.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Detail Template Exporting",
                Category = "Exporting",
                Directory = "Grid/DataGrid",
                Url = "datagrid/detail-template-exporting",
                FileName = "DetailTemplateExporting.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Detail Export | Hierarchical Export | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Detail Template Exporting",
                MetaDescription = "Blazor Grid detail template export demo shows how to include expanded detail content in exports with parent-child relationships preserved in PDF and Excel file."
            },
            new Sample
            {
                Name = "Template Exporting",
                Category = "Exporting",
                Directory = "Grid/DataGrid",
                Url = "datagrid/template-exporting",
                FileName = "TemplateExporting.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Template Export | Rich Content Export | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Template Column Exporting",
                MetaDescription = "This Blazor DataGrid template export demo shows how to convert rich HTML content to appropriate formats in Excel and PDF while preserving visual information.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="TemplateExporting.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Print",
                Category = "Exporting",
                Directory = "Grid/DataGrid",
                Url = "datagrid/print",
                FileName = "Print.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Print | Grid Printing | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Print Functionality",
                MetaDescription = "Blazor DataGrid print demo shows grid printing capabilities. Print the entire grid or selected rows with customizable headers, footers and print media styles.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Print.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Context Menu",
                Category = "Miscellaneous",
                Directory = "Grid/DataGrid",
                Url = "datagrid/context-menu",
                FileName = "ContextMenu.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Context Menu | Right-Click Menu | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Context Menu",
                MetaDescription = "Blazor DataGrid context menu demo shows right-click menu integration. Add custom actions and commands through contextual menus for rows, cells, and headers.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ContextMenu.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Clipboard",
                Category = "Miscellaneous",
                Directory = "Grid/DataGrid",
                Url = "datagrid/clipboard",
                FileName = "Clipboard.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Clipboard | Copy Paste | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Clipboard Operations",
                MetaDescription = "Blazor Grid clipboard example shows how to copy selected cells/rows to clipboard with formatting preserved for pasting into spreadsheets/other applications.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Clipboard.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "Miscellaneous",
                Directory = "Grid/DataGrid",
                Url = "datagrid/tooltip",
                FileName = "Tooltip.razor",
                Type = SampleType.New,
                MetaTitle = "Blazor DataGrid Tooltip | Custom Tooltip | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Tooltip",
                NotificationDescription = new string[] {"This sample demonstrates tooltip support in the Blazor DataGrid, displaying both header and cell content with rich visuals like images and icons on hover."},
                MetaDescription = "This Blazor DataGrid example showcases tooltip support, displaying header and cell content with rich elements like images and icons for better interactivity.",
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Miscellaneous",
                Directory = "Grid/DataGrid",
                Url = "datagrid/keyboard-navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Keyboard Navigation",
                MetaDescription = "Blazor Grid keyboard navigation example shows how to navigate, select, and perform operations using keyboard shortcuts for improved accessibility compliance.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="KeyboardNavigation.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="OrdersDetails.cs"
                    }
                }
            }
            //new Sample
            //{
            //    Name = "Cell Edit Template",
            //    Category = "Editing",
            //    Directory = "Grid/DataGrid",
            //    Url = "datagrid/cell-edit-template",
            //    FileName = "CellEditTemplate.razor",
            //    Type = SampleType.New
            //},
            // new Sample
            // {
            //     Name = "Frozen Line Moving",
            //     Category = "Columns",
            //     Directory = "Grid/DataGrid",
            //     Url = "datagrid/frozenlinemoving",
            //     FileName = "FrozenLineMoving.razor",
            //     Type= SampleType.New,
            //     NotificationDescription = new string[] { @"This example shows how to add or remove the frozen columns by moving the frozen line into the desired column position." }
            // },
        };
       
    }
}