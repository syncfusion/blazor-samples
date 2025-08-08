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
                MetaDescription = "This Blazor DataGrid example is an overview of the Blazor DataGrid features with its performance metrics calculated for huge volume of data.",
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
                MetaDescription = "This Blazor Grid example demonstrates the default rendering of the DataGrid with a minimum configuration.",
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
                MetaDescription = "This Blazor DataGrid adaptive layout example demonstrates responsive design for various screen sizes. The grid dynamically adjusts its layout for optimal viewing on mobile and desktop devices.",
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
                        FileName="OrdersDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "FIFA Statistics",
                Category = "Product Use Case",
                Directory = "Grid/DataGrid",
                Url = "datagrid/fifa-statistics",
                FileName = "FifaStatistics.razor",
                MetaTitle = "Blazor DataGrid | FIFA World Cup Statistics | Syncfusion",
                HeaderText = "Blazor DataGrid Example - FIFA World Cup Statistics",
                MetaDescription = "This Blazor DataGrid example showcases FIFA World Cup data with rich visuals including flags, icons, and tooltips. Display historical tournament data with customized templates and interactive elements.",
                Type = SampleType.New,
                NotificationDescription = new string[]{ @"Display FIFA World Cup statistics using the Syncfusion Blazor DataGrid and Tooltip. Present the year, host, champion, top scorer, best player, and coach details with rich visuals like flags, icons, and quick-access links."},
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
                MetaDescription = "This Blazor DataGrid list binding example demonstrates how to bind local collection data to the grid. Display and manipulate in-memory data collections with full CRUD capabilities.",
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
                MetaDescription = "This Blazor DataGrid remote data example demonstrates fetching and binding data from web services. Connect to RESTful APIs with built-in data operations for server-side processing.",
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
                MetaDescription = "This Blazor DataGrid flexible data example demonstrates handling dynamic data structures. Adapt to varying data schemas with auto-generated columns and dynamic field mapping.",
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
                MetaDescription = "This Blazor DataGrid custom binding example demonstrates connecting to specialized data sources. Implement custom data adapters for advanced scenarios with manual data operations.",
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
                MetaDescription = "This Blazor DataGrid DataTable binding example demonstrates connecting to System.Data.DataTable objects. Easily display ADO.NET results with automatic column generation and full CRUD capabilities.",
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
                MetaDescription = "This Blazor DataGrid data annotation example demonstrates using model attributes for validation. Apply display, format, and validation rules directly through C# model annotations.",
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
                MetaDescription = "This Blazor DataGrid observable collection example demonstrates automatic UI updates when data changes. Track collection modifications for real-time grid updates without manual refresh.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "ExpandoObject Binding",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/expandoobject",
                FileName = "GridExpandoObject.razor",
                MetaTitle = "Blazor DataGrid ExpandoObject Binding | Dynamic Properties | Syncfusion",
                HeaderText = "Blazor DataGrid Example - ExpandoObject Binding",
                MetaDescription = "This Blazor DataGrid ExpandoObject binding example demonstrates working with dynamic objects. Bind to objects with runtime-defined properties for flexible data structures.",
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
                MetaDescription = "This Blazor DataGrid DynamicObject binding example demonstrates working with custom dynamic types. Display and edit objects with custom property resolution for advanced scenarios.",
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
                MetaDescription = "This Blazor DataGrid column template example demonstrates custom cell content rendering. Create rich data visualizations with images, buttons, and interactive elements within cells.",
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
                MetaDescription = "This Blazor DataGrid header template example demonstrates custom column header rendering. Create interactive headers with filters, sorting indicators, and custom styling.",
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
                MetaDescription = "This Blazor DataGrid stacked header example demonstrates hierarchical column organization. Group related columns under common header titles for better data categorization.",
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
                MetaDescription = "This Blazor DataGrid foreign key column example demonstrates displaying lookup values from related tables. Convert ID values to their meaningful display text from reference collections.",
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
                MetaDescription = "This Blazor DataGrid column reorder example demonstrates drag and drop column rearrangement. Let users customize their view by changing column positions with intuitive interactions.",
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
                MetaDescription = "This Blazor DataGrid column resize example demonstrates adjustable column widths and automatic sizing. Resize columns manually or fit to content with built-in autofit capabilities.",
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
                MetaDescription = "This Blazor DataGrid column menu example demonstrates header-based operations menu. Access sorting, filtering, and column visibility options directly from each column header.",
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
                MetaDescription = "This Blazor DataGrid autowrap example demonstrates text wrapping in cells with long content. Handle large text values gracefully with automatic line breaks and adjustable row heights.",
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
                MetaDescription = "This Blazor DataGrid column chooser example demonstrates dynamic column visibility control. Allow users to show or hide columns through an interactive dialog for personalized views.",
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
                MetaDescription = "This Blazor DataGrid column chooser template example demonstrates custom column selection interface. Design a tailored column visibility dialog with grouping, search, and additional options.",
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
                MetaDescription = "This Blazor DataGrid show/hide column example demonstrates programmatic column visibility control. Toggle column display at runtime with animation effects and retain grid layout.",
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
                MetaDescription = "This Blazor DataGrid cell formatting example demonstrates custom cell value presentation. Apply conditional formatting, number/date formats, and styling based on cell values.",
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
                MetaDescription = "This Blazor DataGrid custom command example demonstrates adding action buttons to rows. Create interactive operations like view details, edit, or delete with customizable button styling.",
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
                MetaDescription = "This Blazor DataGrid fixed columns example demonstrates freezing columns during horizontal scrolling. Keep important columns visible while navigating through wide datasets.",
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
                MetaDescription = "This Blazor DataGrid row template example demonstrates custom row rendering. Create highly customized row layouts with complex content, images, and mixed components per row.",
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
                MetaDescription = "This Blazor DataGrid detail template example demonstrates expandable row details. Display additional information or related data in collapsible sections within each row.",
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
                 MetaDescription = "This Blazor DataGrid drag and drop example demonstrates row reordering between grids. Move rows across different grids with drag handles and visual indicators for intuitive data management.",
                 Type = SampleType.Updated,
                 NotificationDescription = new string[]{ "Updated the samples by enabling the AllowEmptyAreaDrop feature, which allows the DataGrid to drop rows onto the empty area of the grid." },
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
               MetaDescription = "This Blazor DataGrid internal drag and drop example demonstrates row reordering within the same grid. Resequence rows with intuitive drag handles and visual drop indicators.",
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
                MetaDescription = "This Blazor DataGrid row hover example demonstrates interactive row highlighting. Apply visual feedback when users hover over rows with customizable colors and transition effects.",
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
                MetaDescription = "This Blazor DataGrid row height example demonstrates customizing row dimensions. Apply uniform or varying heights to rows for better content accommodation and visual presentation.",
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
                MetaDescription = "This Blazor DataGrid inline editing example demonstrates direct cell editing. Edit data without dialogs using keyboard navigation and built-in validation for quick data updates.",
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
                MetaDescription = "This Blazor DataGrid dialog editing example demonstrates form-based data editing. Edit records in a modal dialog with validation, multi-field forms, and customizable layout.",
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
                MetaDescription = "This Blazor DataGrid dialog template example demonstrates custom edit form designs. Create specialized edit interfaces with complex layouts, validation, and advanced input controls.",
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
                MetaDescription = "This Blazor DataGrid batch editing example demonstrates multiple cell editing with deferred saving. Edit multiple cells across rows and save all changes at once for efficient data updates.",
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
                MetaDescription = "This Blazor DataGrid command column example demonstrates built-in action buttons for CRUD operations. Add edit, delete, save, and cancel buttons with customizable appearance and behavior.",
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
                MetaDescription = "This Blazor DataGrid external form example demonstrates separate form-based editing. Create custom edit interfaces outside the grid with full integration for adding and updating records.",
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
                MetaDescription = "This Blazor DataGrid custom validation example demonstrates advanced input validation. Apply business rules, cross-field validation, and custom error messages during data editing.",
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
                MetaDescription = "This Blazor DataGrid multi-sorting example demonstrates ordering by multiple columns simultaneously. Create complex sorting scenarios with column precedence and mixed sort directions.",
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
                MetaDescription = "This Blazor DataGrid custom sorting example demonstrates specialized sorting algorithms. Implement custom comparison logic for complex data types or unique sorting requirements.",
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
                MetaDescription = "This Blazor DataGrid filtering example demonstrates built-in filter operations. Apply text, numeric, date, and boolean filters with various operators for precise data filtering.",
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
                MetaDescription = "This Blazor DataGrid menu filter example demonstrates dropdown-based filtering. Apply filters through a convenient menu interface with type-specific input controls and multiple conditions.",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ "The samples have been updated to demonstrate the use of the FilterEditorSettings property in GridColumn components, enabling customization of filter components such as NumericTextBox, AutoComplete, and TimePicker within the DataGrid filter menu." },
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
                MetaDescription = "This Blazor DataGrid checkbox filter example demonstrates multi-select value filtering. Choose multiple values from checkboxes to create OR-combined filters for categorical data.",
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
                MetaDescription = "This Blazor DataGrid Excel filter example demonstrates Microsoft Excel-style filtering interface. Apply multiple value filters and custom conditions with an intuitive filtering experience.",
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
               MetaDescription = "This Blazor DataGrid search example demonstrates cross-column text search functionality. Find matching data across all columns with highlighting, accent insensitivity, and case options.",
               Type = SampleType.Updated,
               NotificationDescription = new string[]{ "The sample has been updated to enable the IgnoreAccent feature, allowing the DataGrid to ignore accent marks and diacritic characters during search operations." },
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
                MetaDescription = "This Blazor DataGrid pager dropdown example demonstrates selectable page sizes. Allow users to change records per page through a dropdown menu for flexible data viewing.",
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
                MetaDescription = "This Blazor DataGrid pager template example demonstrates customized pagination interface. Design custom pager layouts with additional features like page size selectors and page information.",
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
                MetaDescription = "This Blazor DataGrid grouping example demonstrates hierarchical data organization. Group rows by one or more columns with expand/collapse capabilities and customizable group headers.",
                Type = SampleType.None,
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
#if !(WASM)
			new Sample
            {
                Name = "Lazy Load with Virtual Scrolling",
                Category = "Grouping",
                Directory = "Grid/DataGrid",
                Url = "datagrid/lazyload-virtualization",
                FileName = "LazyLoadVirtualization.razor",
                Type = SampleType.None,
                MetaTitle = "Lazy Load Infinite Scroll Example - Syncfusion Demos",
                HeaderText = "Blazor DataGrid Example - Lazy Load with Virtual Scrolling",
                MetaDescription = "This Blazor DataGrid lazy load virtual scrolling example demonstrates on-demand data loading during scroll. Load large datasets progressively with virtualized rendering for optimal performance."
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
                MetaDescription = "This Blazor DataGrid lazy load infinite scrolling example demonstrates progressive data loading when scrolling. Fetch additional records automatically when users reach the bottom of the grid."
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
                MetaDescription = "This Blazor DataGrid aggregation example demonstrates built-in summary calculations. Display sum, average, count, and other statistical values in footer rows with automatic formatting.",
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
                MetaDescription = "This Blazor DataGrid group aggregate example demonstrates summary values within grouped data. Display statistics for each group with caption and footer summaries for multi-level insights.",
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
                MetaDescription = "This Blazor DataGrid reactive aggregate example demonstrates real-time summary updates. Automatically recalculate aggregates when data changes, filtering occurs, or rows are edited.",
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
                MetaDescription = "This Blazor DataGrid selection example demonstrates row, cell, and column selection modes. Configure single or multiple selections with keyboard navigation and programmatic selection.",
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
                Type = SampleType.Updated,
                MetaTitle = "Blazor DataGrid Checkbox Selection | Multi-Select | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Checkbox Selection",
                MetaDescription = "This Blazor DataGrid checkbox selection example demonstrates multi-row selection with checkboxes. Select individual or all rows with header checkbox and persist selection across data changes.",
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
                MetaDescription = "This Blazor DataGrid drag selection example demonstrates selecting multiple rows or cells by dragging. Select contiguous ranges of cells or rows with mouse drag for efficient multi-selection.",
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
                MetaDescription = "This Blazor DataGrid hierarchy example demonstrates nested child grids within expandable parent rows. Display related data in multi-level hierarchical structure with independent operations per level."
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
                MetaDescription = "This Blazor DataGrid master-detail example shows parent-child related data views. Display detail records in a separate grid based on master row selection with synchronized data operations.",
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
                MetaDescription = "This Blazor DataGrid scrolling example demonstrates basic horizontal and vertical scrolling. Navigate through large datasets with configurable height, width and smooth scrolling behavior.",
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
                MetaDescription = "This Blazor DataGrid sticky header example demonstrates fixed headers during scrolling. Keep column headers visible while scrolling through data rows for better context and usability.",
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
                MetaDescription = "This Blazor DataGrid frozen rows and columns example demonstrates pinning rows and columns during scrolling. Keep important data visible while navigating through large datasets.",
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
                MetaDescription = "This Blazor DataGrid virtual scrolling example demonstrates efficient rendering of large datasets. Render only visible rows in the DOM for optimal performance with large data volumes."
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
                MetaDescription = "This Blazor DataGrid virtual mask row example demonstrates placeholder rows during scrolling. Show loading indicators while asynchronously fetching data for smoother scrolling experience.",
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
                MetaDescription = "This Blazor DataGrid infinite scrolling example demonstrates loading data on demand during scrolling. Load additional records automatically as users scroll to the bottom for seamless browsing."
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
                MetaDescription = "This Blazor DataGrid exporting example demonstrates built-in data export capabilities. Export grid data to Excel, PDF, and CSV formats with configurable options and styling.",
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
                MetaDescription = "This Blazor DataGrid advanced export example demonstrates customized export options. Configure headers, footers, file names, and styling for Excel and PDF exports with multiple customization options.",
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
                MetaDescription = "This Blazor DataGrid detail template export example demonstrates hierarchical data exporting. Include expanded detail content in exports with parent-child relationships preserved in PDF and Excel formats."
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
                MetaDescription = "This Blazor DataGrid template export example demonstrates exporting custom-templated columns. Convert rich HTML content to appropriate formats in Excel and PDF while preserving visual information.",
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
                MetaDescription = "This Blazor DataGrid print example demonstrates grid printing capabilities. Print the entire grid or selected rows with customizable headers, footers and print media styles.",
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
                MetaDescription = "This Blazor DataGrid context menu example demonstrates right-click menu integration. Add custom actions and commands through contextual menus for rows, cells, and headers.",
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
                MetaDescription = "This Blazor DataGrid clipboard example demonstrates copy and paste functionality. Copy selected cells or rows to clipboard with formatting preserved for pasting into spreadsheets or other applications.",
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
                Name = "Keyboard Navigation",
                Category = "Miscellaneous",
                Directory = "Grid/DataGrid",
                Url = "datagrid/keyboard-navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor DataGrid Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Keyboard Navigation",
                MetaDescription = "This Blazor DataGrid keyboard navigation example demonstrates accessibility features. Navigate, select, and perform operations using keyboard shortcuts for improved accessibility compliance.",
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
            },
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