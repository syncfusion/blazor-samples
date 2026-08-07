using System.Collections.Generic;
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
                MetaTitle = "Blazor Grid Demos - Overview Examples | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Overview",
                MetaDescription = "See how the Syncfusion Blazor Overview DataGrid handles large datasets with virtualization, API, and performance features for responsive data management.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-datagrid",
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
                MetaTitle = "Blazor Grid - Default Functionalities | Grid Demos | Syncfusion",
                HeaderText = "Blazor Grid Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Default Functionalities DataGrid renders data with sorting, paging, API, and events to quickly build efficient data interfaces.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-datagrid",
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
                        FileName="TransactionData.cs"
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
                MetaTitle = "Blazor Grid Examples - Adaptive Layout | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Adaptive Rendering",
                MetaDescription = "See how the Syncfusion Blazor Adaptive Layout DataGrid adjusts display across devices using API, responsive design, and events for consistent usability.",
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
                        FileName="ShipmentData.cs"
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
                MetaTitle = "Blazor Grid Examples - Semantic Filtering | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid - AI Powered Semantic Filtering with Embedding Example",
                MetaDescription = "See how the Syncfusion Blazor Semantic Filtering DataGrid enables AI queries with API, filtering, and events to deliver faster and context-aware data insights.",
                Type = SampleType.AI
            },
            new Sample
            {
                Name = "Anomaly Detection",
                Category = "Smart AI Solutions",
                Directory = "AISamples/DataGrid",
                Url = "datagrid/ai-anomaly-detection",
                FileName = "AnomalyData.razor",
                MetaTitle = "Blazor Grid Examples - Anomaly Detection | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid - AI Powered Anomaly Detection Example",
                MetaDescription = "See how the Syncfusion Blazor Anomaly Detection identifies unusual data patterns with AI models and visualization tools to support better decision making.",
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
                MetaTitle = "Blazor Grid Examples - FIFA Statistics | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - FIFA World Cup Statistics",
                MetaDescription = "See how the Syncfusion Blazor FIFA Statistics visualizes sports data with templates, icons, and tooltips to present engaging and interactive insights.",
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
                MetaTitle = "Blazor Grid Examples - List Binding | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - List Data Binding",
                MetaDescription = "See how the Syncfusion Blazor List Binding displays local data collections with CRUD operations and in-memory processing for fast and flexible updates.",
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
                        FileName="InventoryData.cs"
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
                MetaTitle = "Blazor Grid Examples - Remote Data | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Remote Data Binding",
                MetaDescription = "See how the Syncfusion Blazor Remote Data DataGrid connects to APIs with server-side processing, binding, and events to handle large datasets efficiently.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Flexible Data",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/flexible-data",
                FileName = "FlexibleData.razor",
                MetaTitle = "Blazor Grid Examples - Flexible Data | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Flexible Data Binding",
                MetaDescription = "See how the Syncfusion Blazor Flexible Data adapts to dynamic schemas with auto-generated columns and field mapping for handling varied data structures.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Custom Binding",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/custom-binding",
                FileName = "CustomBinding.razor",
                MetaTitle = "Blazor Grid Examples - Custom Binding | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Custom Data Binding",
                MetaDescription = "See how the Syncfusion Blazor Custom Binding DataGrid integrates data sources with API, manual operations, and events for flexible and advanced data handling.",
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
                        FileName="BookData.cs"
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
                MetaTitle = "Blazor Grid Examples - DataTable Binding | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - DataTable Binding",
                MetaDescription = "See how the Syncfusion Blazor DataTable Binding DataGrid displays ADO.NET data with auto columns, API, and events for seamless database usage and integration.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-datagrid"
            },
            new Sample
            {
                Name = "Data Annotation",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/data-annotation",
                FileName = "DataAnnotation.razor",
                MetaTitle = "Blazor Grid Examples - Data Annotation | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Data Annotations",
                MetaDescription = "See how the Syncfusion Blazor Data Annotation DataGrid applies validation and formatting with API and events to ensure consistent and accurate data entry.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Observable Collection",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/observable-binding",
                FileName="ObservableBinding.razor",
                MetaTitle = "Blazor Grid Demos - Observable Collection Examples | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Observable Collection Binding",
                MetaDescription = "See how the Syncfusion Blazor Observable Collection DataGrid updates UI automatically with API, change tracking, and events for smooth real-time data updates.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "ExpandoObject Binding",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/expandoobject",
                FileName = "GridExpandoObject.razor",
                MetaTitle = "Blazor Grid Demos - ExpandoObject Binding Examples | Syncfusion",
                HeaderText = "Blazor DataGrid Example - ExpandoObject Binding",
                MetaDescription = "See how the Syncfusion Blazor ExpandoObject Binding handles runtime properties with dynamic structures and CRUD operations for flexible and efficient data use.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "DynamicObject Binding",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/dynamicobject",
                FileName = "GridDynamicObject.razor",
                MetaTitle = "Blazor Grid Demos - DynamicObject Binding Examples | Syncfusion",
                HeaderText = "Blazor DataGrid Example - DynamicObject Binding",
                MetaDescription = "See how the Syncfusion Blazor DynamicObject Binding DataGrid supports custom dynamic types with API, property handling, and events for efficient data scenarios.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Column Template",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/column-template",
                FileName = "ColumnTemplate.razor",
                MetaTitle = "Blazor Grid Examples - Column Template | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Column Templates",
                MetaDescription = "See how the Syncfusion Blazor Column Template DataGrid creates custom cells using templates, API, and events to enhance presentation and interactivity.",
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
                        FileName="EmployeeData.cs"
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
                MetaTitle = "Blazor Grid Examples - Header Template | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Header Templates",
                MetaDescription = "See how the Syncfusion Blazor Header Template DataGrid customizes headers with API, templates, sorting, and events to improve usability and interaction.",
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
                MetaTitle = "Blazor Grid Examples - Stacked Header | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Stacked Headers",
                MetaDescription = "See how the Syncfusion Blazor Stacked Header DataGrid groups columns hierarchically with API and events to improve readability and structured data organization.",
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
                MetaTitle = "Blazor Grid Examples - Foreign Key Column | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Foreign Key Columns",
                MetaDescription = "See how the Syncfusion Blazor Foreign Key Column displays related values with lookup mapping and reference collections for clearer data relationships.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Column Reorder",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/reorder",
                FileName = "Reorder.razor",
                MetaTitle = "Blazor Grid Examples - Column Reorder | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Column Reordering",
                MetaDescription = "See how the Syncfusion Blazor Column Reorder DataGrid enables drag-and-drop column arrangement with API and events to personalize layouts and improve usability.",
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
                MetaTitle = "Blazor Grid Examples - AutoFit and Resizing | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Column Resizing and AutoFit",
                MetaDescription = "See how the Syncfusion Blazor AutoFit and Resizing DataGrid adjusts column widths with API, resizing, and events to improve layout clarity and readability.",
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
                MetaTitle = "Blazor Grid Examples - Column Menu | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Column Menu",
                MetaDescription = "See how the Syncfusion Blazor Column Menu DataGrid provides filtering, sorting, and visibility controls using API and events for better data interaction.",
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
                MetaTitle = "Blazor Grid Demos - Autowrap Column Cells Examples | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Autowrap Column Cells",
                MetaDescription = "See how the Syncfusion Blazor Autowrap Column Cells DataGrid wraps text automatically with API and events to improve readability and content visibility.",
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
                MetaTitle = "Blazor Grid Examples - Column Chooser | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Column Chooser",
                MetaDescription = "See how the Syncfusion Blazor Column Chooser DataGrid controls visibility with API, dialogs, and events to create personalized and flexible grid views.",
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
                MetaTitle = "Blazor Grid - Column Chooser Template | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Column Chooser Template",
                MetaDescription = "See how the Syncfusion Blazor Column Chooser Template DataGrid customizes dialogs using templates, API, and events for enhanced column selection usability.",
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
                MetaTitle = "Blazor Grid Examples - Show or Hide Column | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Show or Hide Columns",
                MetaDescription = "See how the Syncfusion Blazor Show or Hide Column DataGrid toggles visibility using API and events for flexible layout control and personalized user experience.",
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
                MetaTitle = "Blazor Grid Examples - Cell Formatting | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Cell Formatting",
                MetaDescription = "See how the Syncfusion Blazor Cell Formatting DataGrid applies styles, formats, and templates using API and events to improve data clarity and presentation.",
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
                MetaTitle = "Blazor Grid Examples - Custom Command | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Custom Command Buttons",
                MetaDescription = "See how the Syncfusion Blazor Custom Command DataGrid adds action buttons with API, templates, and events to enable flexible row operations and workflows.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Fixed Columns",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/fixed-column",
                FileName = "FixedColumn.razor",
                MetaTitle = "Blazor Grid Examples - Fixed Columns | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Fixed Columns",
                MetaDescription = "See how the Syncfusion Blazor Fixed Columns DataGrid keeps key fields visible using column freezing, API, and events for stable scrolling and navigation.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="FixedColumn.razor"
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
                Name = "Column Spanning",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/row-and-column-spanning",
                FileName = "RowAndColumnSpanning.razor",
                MetaTitle = "Blazor Grid Examples - Column Spanning | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Row and Column Spanning",
                MetaDescription = "See how the Syncfusion Blazor Column Spanning DataGrid merges cells using spans, API, and events to improve structure and readability of grouped data.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="RowAndColumnSpanning.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="EmployeeDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Row Template",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "datagrid/row-template",
                FileName = "GridRowTemplate.razor",
                MetaTitle = "Blazor Grid Examples - Row Template | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Row Templates",
                MetaDescription = "See how the Syncfusion Blazor Row Template DataGrid customizes layouts using templates, API, and events to display rich content and enhance data presentation.",
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
            // Ignore: From Build
            new Sample
            {
                Name = "Detail Template",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "datagrid/detail-template",
                FileName = "GridDetailTemplate.razor",
                MetaTitle = "Blazor Grid Examples - Detail Template | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Detail Templates",
                MetaDescription = "See how the Syncfusion Blazor Detail Template DataGrid shows expandable content using templates, API, and events to provide richer insights for each record.",
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
            // End: Ignore
            new Sample
             {
                 Name = "Drag and Drop",
                 Category = "Rows",
                 Directory = "Grid/DataGrid",
                 Url = "datagrid/row-drag-and-drop",
                 FileName = "RowDragAndDrop.razor",
                 MetaTitle = "Blazor Grid Examples - Drag and Drop | Grid Demos | Syncfusion",
                 HeaderText = "Blazor DataGrid Example - Drag and Drop Rows",
                 MetaDescription = "See how the Syncfusion Blazor Drag and Drop DataGrid moves rows across grids using API, drag actions, and events to improve data organization workflows.",
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
               MetaTitle = "Blazor Grid - Drag and Drop within Grid | Grid Demos | Syncfusion",
               HeaderText = "Blazor DataGrid Example - Drag and Drop within Grid",
               MetaDescription = "See how the Syncfusion Blazor Drag and Drop within Grid DataGrid reorders rows using API, drag actions, and events for intuitive positioning and data control.",
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
                MetaTitle = "Blazor Grid Demos - Row Hover Examples | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Row Hover Effects",
                MetaDescription = "See how the Syncfusion Blazor Row Hover DataGrid highlights rows using API, styling, and events to enhance interaction and improve navigation clarity.",
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
                MetaTitle = "Blazor Grid Demos - Row Height Examples | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Row Height Customization",
                MetaDescription = "See how the Syncfusion Blazor Row Height DataGrid adjusts row size using API, layout control, and events to enhance readability and visual presentation.",
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
                Name = "Row Spanning",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "datagrid/row-and-column-spanning",
                FileName = "RowAndColumnSpanning.razor",
                MetaTitle = "Blazor Grid Examples - Row Spanning | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Row and Column Spanning",
                MetaDescription = "See how the Syncfusion Blazor Row Spanning DataGrid merges adjacent cells using API, spans, and events for improved readability and structured data display.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="RowAndColumnSpanning.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="EmployeeDetails.cs"
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
                MetaTitle = "Blazor Grid Examples - Inline Editing | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Inline Editing",
                MetaDescription = "See how the Syncfusion Blazor Inline Editing DataGrid enables direct cell updates with keyboard navigation, validation, API, and events for faster editing.",
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
                MetaTitle = "Blazor Grid Examples - Dialog Editing | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Dialog Editing",
                MetaDescription = "See how the Syncfusion Blazor Dialog Editing DataGrid edits records in dialogs with API, validation, and events for structured multi-field data updates.",
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
                MetaTitle = "Blazor Grid Examples - Dialog Template | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Dialog Template",
                MetaDescription = "See how the Syncfusion Blazor Dialog Template DataGrid customizes edit forms using templates, API, validation, and events for flexible editing layouts.",
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
                MetaTitle = "Blazor Grid Examples - Batch Editing | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Batch Editing",
                MetaDescription = "See how the Syncfusion Blazor Batch Editing DataGrid updates multiple cells using API, validation, and events for efficient bulk data editing workflows.",
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
                MetaTitle = "Blazor Grid Examples - Command Column | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Command Column",
                MetaDescription = "See how the Syncfusion Blazor Command Column DataGrid adds edit, delete, and save buttons using API, templates, and events for efficient CRUD operations.",
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
                MetaTitle = "Blazor Grid Demos - External Form Editing Examples | Syncfusion",
                HeaderText = "Blazor DataGrid Example - External Form Editing",
                MetaDescription = "See how the Syncfusion Blazor External Form Editing DataGrid connects external forms using API, validation, and events for flexible data management and updates.",
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
                MetaTitle = "Blazor Grid Examples - Custom Validation | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Custom Validation",
                MetaDescription = "See how the Syncfusion Blazor Custom Validation DataGrid applies rules using API, validation logic, and events for accurate and reliable data editing.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multi Sorting",
                Category = "Sorting",
                Directory = "Grid/DataGrid",
                Url = "datagrid/sorting",
                FileName = "Sorting.razor",
                MetaTitle = "Blazor Grid Examples - Multi Sorting | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Multi-Column Sorting",
                MetaDescription = "See how the Syncfusion Blazor Multi Sorting DataGrid sorts multiple columns with API, events, and priority logic to support advanced data ordering and analysis.",
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
                MetaTitle = "Blazor Grid Examples - Custom Sorting | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Custom Sorting Logic",
                MetaDescription = "See how the Syncfusion Blazor Custom Sorting DataGrid applies custom logic with API and events to handle complex data types and unique sorting requirements.",
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
                MetaTitle = "Blazor Grid Examples - Default Filtering | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Default Filtering",
                MetaDescription = "See how the Syncfusion Blazor Default Filtering DataGrid applies filters using API, operators, and events for precise data filtering and refined results.",
                Type = SampleType.Updated,
                NotificationDescription = [@"Enhance filtering with operator dropdown support using the ShowFilterBarOperator property, enabling precise filtering without manual input. The filter bar also intelligently renders input controls such as TextBox, NumericTextBox, DatePicker, and CheckBox based on the column data type, ensuring accurate and user-friendly filtering."],
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
                MetaTitle = "Blazor Grid Examples - Menu Filter | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Menu Filter Interface",
                MetaDescription = "See how the Syncfusion Blazor Menu Filter DataGrid applies filtering through menus using API, UI controls, and events for flexible condition-based filtering.",
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
                MetaTitle = "Blazor Grid Examples - Checkbox Filter | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Checkbox Filtering",
                MetaDescription = "See how the Syncfusion Blazor Checkbox Filter DataGrid enables multi-select filtering using API, checkboxes, and events for efficient categorical data analysis.",
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
                MetaTitle = "Blazor Grid Examples - Excel like Filter | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Excel-like Filtering",
                MetaDescription = "See how the Syncfusion Blazor Excel like Filter DataGrid provides Excel-style filtering UI with API, conditions, and events for intuitive data filtering.",
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
               MetaTitle = "Blazor Grid Demos - Searching Examples | Grid Demos | Syncfusion",
               HeaderText = "Blazor DataGrid Example - Global Searching",
               MetaDescription = "See how the Syncfusion Blazor Searching DataGrid performs cross-column search using API, highlighting, and events for fast and accurate data discovery.",
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
                MetaTitle = "Blazor Grid Examples - Pager Dropdown | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Pager with Dropdown",
                MetaDescription = "See how the Syncfusion Blazor Pager Dropdown DataGrid changes page size using API, dropdown UI, and events for flexible and efficient data navigation.",
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
                MetaTitle = "Blazor Grid Examples - Pager Template | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Custom Pager Template",
                MetaDescription = "See how the Syncfusion Blazor Pager Template DataGrid customizes paging UI using API, templates, and events for flexible navigation and improved usability.",
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
                MetaTitle = "Blazor Grid Demos - Grouping Examples | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Row Grouping",
                MetaDescription = "See how the Syncfusion Blazor Grouping DataGrid groups rows with API, expand/collapse, and events to organize data efficiently for structured analysis.",
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
                new Sample
                {
                Name = "Lazy Load with Paging",
                Category = "Grouping",
                Directory = "Grid/DataGrid",
                Url = "datagrid/lazyload-paging",
                FileName = "LazyLoadPaging.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Grid Demos - Lazy Load with Paging Examples | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Lazy Load with Paging",
                MetaDescription = "See how the Syncfusion Blazor Lazy Load Paging DataGrid loads data on demand with API and events to enhance performance and optimize large dataset handling."
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
                MetaTitle = "Blazor Grid Demos - Lazy Load with Virtual Scrolling | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Lazy Load with Virtual Scrolling",
                MetaDescription = "See how the Syncfusion Blazor Lazy Load Virtual Scrolling DataGrid loads data on scroll with API and events for smooth large dataset rendering and performance."
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
                MetaTitle = "Blazor Grid Demos - Lazy Load with Infinite Scrolling | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Lazy Load with Infinite Scrolling",
                MetaDescription = "See how the Syncfusion Blazor Lazy Load Infinite Scrolling DataGrid loads records progressively using API and events for seamless browsing of large datasets."
            },
            new Sample 
            {
                Name = "Default Aggregate",
                Category = "Aggregates",
                Directory = "Grid/DataGrid",
                Url = "datagrid/aggregate",
                FileName = "Aggregate.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Grid Examples - Default Aggregate | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Default Aggregation",
                MetaDescription = "See how the Syncfusion Blazor Default Aggregate DataGrid calculates summaries using API, formatting, and events to provide quick statistical insights.",
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
                MetaTitle = "Blazor Grid - Group and Caption Aggregate | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Group and Caption Aggregates",
                MetaDescription = "See how the Syncfusion Blazor Group and Caption Aggregate DataGrid displays summaries with API and events for detailed grouped data insights and reporting.",
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
                MetaTitle = "Blazor Grid Examples - Reactive Aggregate | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Reactive Aggregation",
                MetaDescription = "See how the Syncfusion Blazor Reactive Aggregate DataGrid recalculates summaries with API, events, and live updates to deliver accurate real-time insights.",
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
                MetaTitle = "Blazor Grid Examples - Default Selection | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Default Selection",
                MetaDescription = "See how the Syncfusion Blazor Default Selection DataGrid supports row and cell selection with API, keyboard navigation, and events for efficient interaction.",
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
                MetaTitle = "Blazor Grid Examples - Checkbox Selection | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Checkbox Selection",
                MetaDescription = "See how the Syncfusion Blazor Checkbox Selection DataGrid enables row selection with API, persistence, and events for better control and flexible data handling.",
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
                MetaTitle = "Blazor Grid Examples - Drag Selection | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Drag Selection",
                MetaDescription = "See how the Syncfusion Blazor Drag Selection DataGrid selects ranges with API, mouse drag, and events for efficient multi-cell selection and data interaction.",
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
                MetaTitle = "Blazor Grid Examples - Hierarchy Grid | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Hierarchy Grid",
                MetaDescription = "See how the Syncfusion Blazor Hierarchy DataGrid displays nested data with API, templates, and events for structured multi-level analysis and relationships."
            },
            new Sample
            {
                Name = "Master Detail Grid",
                Category = "Relational Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/master-details",
                FileName = "MasterDetails.razor",
                MetaTitle = "Blazor Grid Examples - Master Detail Grid | Grid Demos | Syncfusion",
                HeaderText = "Blazor Master Detail Grid Example",
                MetaDescription = "See how the Syncfusion Blazor Master Detail DataGrid shows related records using API, templates, and events for synchronized and detailed data operations.",
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
                MetaTitle = "Blazor Grid Examples - Default Scrolling | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Default Scrolling",
                MetaDescription = "See how the Syncfusion Blazor Default Scrolling DataGrid enables navigation with API, layout settings, and events for smooth interaction with large datasets.",
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
                MetaTitle = "Blazor Grid Examples - Sticky Header | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Sticky Header",
                MetaDescription = "See how the Syncfusion Blazor Sticky Header DataGrid keeps column headers visible with API and events to maintain context while scrolling large datasets.",
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
                MetaTitle = "Blazor Grid - Frozen Rows and Columns | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Frozen Rows and Columns",
                MetaDescription = "See how the Syncfusion Blazor Frozen Rows and Columns DataGrid pins key data with API and events to improve navigation and visibility during scrolling.",
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
                MetaTitle = "Blazor Grid Examples - Virtual Scrolling | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Virtual Scrolling",
                MetaDescription = "See how the Syncfusion Blazor Virtual Scrolling DataGrid renders visible rows using API and events to improve performance when handling large datasets.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="VirtualScrolling.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="FlightBookingRecordDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Virtual Mask Row",
                Category = "Scrolling",
                Directory = "Grid/DataGrid",
                Url = "datagrid/virtual-mask-row",
                FileName = "VirtualMaskRow.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Grid Examples - Virtual Mask Row | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Virtual Mask Rows",
                MetaDescription = "See how the Syncfusion Blazor Virtual Mask Row DataGrid displays loading indicators with API and events for smoother user experience during data loading.",
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
                MetaTitle = "Blazor Grid Examples - Infinite Scrolling | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Infinite Scrolling",
                MetaDescription = "See how the Syncfusion Blazor Infinite Scrolling DataGrid loads records on demand using API, scrolling, and events to ensure smooth navigation and performance."
            },
            new Sample
            {
                Name = "Default Exporting",
                Category = "Exporting",
                Directory = "Grid/DataGrid",
                Url = "datagrid/exporting",
                FileName = "Exporting.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Grid Examples - Default Exporting | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Default Exporting",
                MetaDescription = "See how the Syncfusion Blazor Default Exporting DataGrid exports data using API, events, and formatting to Excel, PDF, and CSV for easy sharing and reporting.",
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
                MetaTitle = "Blazor Grid Examples - Advanced Exporting | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Advanced Exporting",
                MetaDescription = "See how the Syncfusion Blazor Advanced Exporting DataGrid customizes exports using API, styling, templates, and events for tailored Excel and PDF reports.",
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
                MetaTitle = "Blazor Grid - Detail Template Exporting | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Detail Template Exporting",
                MetaDescription = "See how the Syncfusion Blazor Detail Template Exporting DataGrid includes hierarchy data using API, templates, and events for complete and structured exports."
            },
            new Sample
            {
                Name = "Template Exporting",
                Category = "Exporting",
                Directory = "Grid/DataGrid",
                Url = "datagrid/template-exporting",
                FileName = "TemplateExporting.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Grid Examples - Template Exporting | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Template Column Exporting",
                MetaDescription = "See how the Syncfusion Blazor Template Exporting DataGrid converts templates using API, events, and mapping to preserve layout and data during export.",
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
                MetaTitle = "Blazor Grid Demos - Print Examples | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Print Functionality",
                MetaDescription = "See how the Syncfusion Blazor Print DataGrid generates printable output using API, layout options, and events for clean reports and consistent data presentation",
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
                MetaTitle = "Blazor Grid Examples - Context Menu | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Context Menu",
                MetaDescription = "See how the Syncfusion Blazor Context Menu DataGrid adds right-click actions using API, menu items, and events for enhanced user interaction and control.",
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
                MetaTitle = "Blazor Grid Demos - Clipboard Examples | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Clipboard Operations",
                MetaDescription = "See how the Syncfusion Blazor Clipboard DataGrid copies data using API, formatting, and events for seamless sharing across spreadsheets and applications.",
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
                Type = SampleType.None,
                MetaTitle = "Blazor Grid Demos - Tooltip Examples | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Tooltip",
                MetaDescription = "See how the Syncfusion Blazor Tooltip DataGrid displays rich content using API, templates, and events to enhance interactivity and improve data readability.",
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Miscellaneous",
                Directory = "Grid/DataGrid",
                Url = "datagrid/keyboard-navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Grid Examples - Keyboard Navigation | Grid Demos | Syncfusion",
                HeaderText = "Blazor DataGrid Example - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor Keyboard Navigation DataGrid enables shortcuts using API, focus control, and events for accessible and efficient data interaction.",
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
            //     NotificationDescription = new string[] { @"This example shows how to add or remove the frozen columns by moving the frozen line into the desired column position." }
            // },
        };
       
    }
}