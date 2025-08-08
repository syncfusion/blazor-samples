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
        public List<Sample> QueryBuilder { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/default-functionalities",
                MetaTitle = "Query Builder Default Functionalities - Syncfusion Demos",
                FileName = "DefaultFunctionalities.razor",
                HeaderText = "Blazor Query Builder - Default Functionalities",
                MetaDescription = "This Blazor Query Builder example demonstrates the default rendering with essential features like rule building, condition selection, and value filtering for creating structured queries."
            },
            new Sample
            {
                Name = "Complex DataBinding",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/complex-databinding",
                FileName = "ComplexDataBinding.razor",
                MetaTitle = "Blazor Query Builder | Complex Data Binding | Syncfusion",
                HeaderText = "Blazor Query Builder - Complex Data Binding",
                MetaDescription = "This Blazor Query Builder complex data binding example demonstrates connecting to nested data structures and complex objects with hierarchical field mapping for advanced query creation."
            },
            new Sample
            {
                Name = "Mongo and SQL Query",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/mongo-query",
                FileName = "MongoQuery.razor",
                MetaTitle = "Blazor Query Builder | MongoDB and SQL Queries | Syncfusion",
                HeaderText = "Blazor Query Builder - MongoDB and SQL Query Generation",
                MetaDescription = "This Blazor Query Builder example demonstrates generation of MongoDB and SQL queries from the same interface. Convert visual conditions into database-specific query formats for multiple platforms."
            },
            new Sample
            {
                Name = "Lock Group/Rule",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/lock-group",
                FileName = "LockGroup.razor",
                MetaTitle = "Blazor Query Builder | Lock Groups and Rules | Syncfusion",
                HeaderText = "Blazor Query Builder - Lock Groups and Rules",
                MetaDescription = "This Blazor Query Builder example demonstrates locking groups and rules to prevent modification. Secure critical query conditions while allowing edits to other parts of the query structure."
            },
            new Sample
            {
                Name = "Clone Group/Rule",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/clone-group",
                FileName = "CloneGroup.razor",
                MetaTitle = "Blazor Query Builder | Clone Groups and Rules | Syncfusion",
                HeaderText = "Blazor Query Builder - Clone Groups and Rules",
                MetaDescription = "This Blazor Query Builder example demonstrates duplicating existing groups and rules. Create similar query conditions quickly by cloning and modifying without rebuilding from scratch."
            },
            new Sample
            {
                Name = "Drag and Drop",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/drag-and-drop",
                FileName = "DragAndDrop.razor",
                MetaTitle = "Blazor Query Builder | Drag and Drop | Syncfusion",
                HeaderText = "Blazor Query Builder - Drag and Drop Functionality",
                MetaDescription = "This Blazor Query Builder example demonstrates drag and drop capabilities for query construction. Reposition rules and groups intuitively to restructure queries with simple mouse interactions.",
                NotificationDescription = new string[]{ @"The Query Builder component now includes a drag-and-drop feature, allowing users to reposition rules or groups within the component effortlessly. This enhancement provides a more intuitive and flexible way to construct and modify queries." }
            },
            new Sample
            {
                Name = "Separate Connector",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/separate-connector",
                FileName = "SeparateConnector.razor",
                MetaTitle = "Blazor Query Builder | Separate Connectors | Syncfusion",
                HeaderText = "Blazor Query Builder - Separate Connector Logic",
                MetaDescription = "This Blazor Query Builder example demonstrates using different logical operators (AND/OR) between rules within the same group. Create complex mixed-logic conditions with individualized connectors.",
                NotificationDescription = new string[]{ @"The separate connector feature in the Query Builder component enables users to integrate standalone connectors between rules or groups within the same group. This allows for greater flexibility, as users can connect rules or groups using different connectors, enhancing the complexity and precision of query construction." }
            },
            new Sample
            {
                Name = "Value Template",
                Category = "Templates",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor Query Builder | Value Templates | Syncfusion",
                HeaderText = "Blazor Query Builder - Value Templates",
                MetaDescription = "This Blazor Query Builder value template example demonstrates custom value editors. Replace default input controls with specialized components like sliders, dropdowns, or date pickers."
            },
            new Sample
            {
                Name = "Column Template",
                Category = "Templates",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/column-template",
                FileName = "ColumnTemplate.razor",
                MetaTitle = "Blazor Query Builder | Column Templates | Syncfusion",
                HeaderText = "Blazor Query Builder - Column Templates",
                MetaDescription = "This Blazor Query Builder column template example demonstrates customizing column selection UI. Create advanced field selectors with grouping, filtering, and enhanced visualization for available fields."
            },
             new Sample
            {
                Name = "Integration with Data Grid",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/grid",
                FileName = "Grid.razor",
                MetaTitle = "Blazor Query Builder | DataGrid Integration | Syncfusion",
                HeaderText = "Blazor Query Builder - Integration with Data Grid",
                MetaDescription = "This Blazor Query Builder and DataGrid integration example demonstrates dynamic filtering of grid data. Apply complex query conditions to filter grid records in real-time with visual query building."
            },
            new Sample
            {
                Name = "Header Template",
                Category = "Templates",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/header-template",
                FileName = "HeaderTemplate.razor",
                MetaTitle = "Blazor Query Builder | Header Templates | Syncfusion",
                HeaderText = "Blazor Query Builder - Header Templates",
                MetaDescription = "This Blazor Query Builder header template example demonstrates customizing group headers. Create enhanced header designs with additional controls, information displays, or styling options."
            }
        };

        public List<Sample> DataForm { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Data Form",
                Directory = "Forms/DataForm",
                Url = "data-form/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Data Form Example | Default Functionalities | Syncfusion Demos",
                HeaderText = "Blazor Data Form Example - Default Functionalities",
                MetaDescription = "This Blazor Data Form example demonstrates the default rendering of the Data Form with a minimum configuration.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="DefaultFunctionalities.razor"
                    },
                    new SourceCollection
                    {
                        Id="RegistrationData",
                        FileName="RegistrationData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Column Layout",
                Category = "Data Form",
                Directory = "Forms/DataForm",
                Url = "data-form/column-layout",
                FileName = "ColumnLayout.razor",
                MetaTitle = "Blazor Data Form Example | Column Layout | Syncfusion Demos",
                HeaderText = "Blazor Data Form Example - Column Layout",
                MetaDescription = "This example of Blazor Data Form demonstrates the rendering of the Data Form component using a column layout.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnLayout",
                        FileName="ColumnLayout.razor"
                    },
                    new SourceCollection
                    {
                        Id="PaymentDetails",
                        FileName="PaymentDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Form Groups",
                Category = "Data Form",
                Directory = "Forms/DataForm",
                Url = "data-form/form-group",
                FileName = "FormGroups.razor",
                MetaTitle = "Blazor Data Form Example | Form Groups | Syncfusion Demos",
                HeaderText = "Blazor Data Form Example - Form Groups",
                MetaDescription = "This Blazor Data Form example shows rendering form groups by organizing related form fields together within the Data Form component for better structure.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FormGroups",
                        FileName="FormGroups.razor"
                    },
                    new SourceCollection
                    {
                        Id="EmployeeDetails",
                        FileName="EmployeeDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Adaptive Layout",
                Category = "Data Form",
                Directory = "Forms/DataForm",
                Url = "data-form/adaptive-layout",
                FileName = "AdaptiveLayout.razor",
                MetaTitle = "Blazor Data Form Example | Adaptive Data Form | Syncfusion Demos",
                HeaderText = "Blazor Data Form Example - Adaptive Layout",
                MetaDescription = "This Blazor Data Form example demonstrates how form field sizes adjust dynamically when the screen size changes or on devices with varying screen dimensions.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="AdaptiveLayout",
                        FileName="AdaptiveLayout.razor"
                    },
                    new SourceCollection
                    {
                        Id="OrdersData",
                        FileName="OrdersData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Templates",
                Category = "Data Form",
                Directory = "Forms/DataForm",
                Url = "data-form/templates",
                FileName = "Templates.razor",
                MetaTitle = "Blazor Data Form Example | Data Form Templates | Syncfusion Demos",
                HeaderText = "Blazor Data Form Example - Data Form Templates",
                MetaDescription = "This example of Blazor Data Form demonstrates the template functionality in the Blazor Data Form component.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Templates",
                        FileName="Templates.razor"
                    },
                    new SourceCollection
                    {
                        Id="ProductDetails",
                        FileName="ProductDetails.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Custom Editors",
                Category = "Data Form",
                Directory = "Forms/DataForm",
                Url = "data-form/custom-editors",
                FileName = "CustomEditor.razor",
                MetaTitle = "Blazor Data Form Example | Custom Editors | Syncfusion Demos",
                HeaderText = "Blazor Data Form Example - Custom Editors",
                MetaDescription = "This example of Blazor Data Form demonstrates the process of using custom editors instead of the default editors in a Blazor Data Form component.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CustomEditor",
                        FileName="CustomEditor.razor"
                    },
                    new SourceCollection
                    {
                        Id="HotelBooking",
                        FileName="HotelBooking.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Floating Label",
                Category = "Data Form",
                Directory = "Forms/DataForm",
                Url = "data-form/floating-label",
                FileName = "FloatingLabel.razor",
                MetaTitle = "Blazor Data Form Example | Floating Label | Syncfusion Demos",
                HeaderText = "Blazor Data Form Example - Floating Label",
                MetaDescription = "The example demonstrates floating label functionality, DataType attribute, and display options custom attribute supported in the Blazor Data Form component.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FloatingLabel",
                        FileName="FloatingLabel.razor"
                    },
                    new SourceCollection
                    {
                        Id="BookingDetails",
                        FileName="RegistrationDetails.cs"
                    }
                },
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "API",
                Category = "Data Form",
                Directory = "Forms/DataForm",
                Url = "data-form/api",
                FileName = "Api.razor",
                MetaTitle = "Blazor Data Form Example | API | Syncfusion Demos",
                HeaderText = "Blazor Data Form Example - API",
                MetaDescription = "This Blazor Data Form example demonstrates how to dynamically adjust label position and button alignment in the Data Form component using its properties.",
                IsHideInMobile = true,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="API",
                        FileName="Api.razor"
                    },
                    new SourceCollection
                    {
                        Id="RegistrationData",
                        FileName="RegistrationData.cs"
                    }
                }
            }
        };
    }
}
