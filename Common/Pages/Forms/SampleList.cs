#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;

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
                MetaDescription = "Blazor Query Builder demo shows the default rendering with features like rule building, condition selection, value filtering for creating structured queries."
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
                MetaDescription = "Blazor QueryBuilder complex data binding demo shows connecting to nested data structures and complex objects with hierarchical field mapping for query creation."
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
                MetaDescription = "Blazor Query Builder demo shows generation of MongoDB and SQL queries from the same interface. Convert visual conditions into database-specific query formats."
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
                MetaDescription = "Blazor QueryBuilder demo shows locking groups and rules to prevent modification. Secure critical query condition while editing to other part of query structure."
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
                MetaDescription = "Blazor QueryBuilder demo shows how to duplicate existing groups and rules.Create similar query conditions by cloning and modifying, avoiding a complete rebuild."
            },
            new Sample
            {
                Name = "Drag and Drop",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/drag-and-drop",
                FileName = "DragAndDrop.razor",
                MetaTitle = "Blazor Query Builder Example | Drag and Drop | Syncfusion",
                HeaderText = "Blazor Query Builder - Drag and Drop Functionality",
                MetaDescription = "Blazor QueryBuilder demo shows drag drop capabilities for query construction. Reposition rules and groups to restructure query with simple mouse interaction.",
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
                MetaDescription = "Blazor Query Builder demo shows using different logical operators between rules within the same group. Create complex mixed-logic conditions with connectors.",
                NotificationDescription = new string[]{ @"The separate connector feature in the Query Builder component enables users to integrate standalone connectors between rules or groups within the same group. This allows for greater flexibility, as users can connect rules or groups using different connectors, enhancing the complexity and precision of query construction." }
            },
#if SERVER
            new Sample
            {
                Name = "Natural Language Query",
                Category = "Smart AI Solutions",
                Directory = "AISamples/QueryBuilder",
                Url = "query-builder/ai-natural-languagequery",
                FileName = "NaturalLanguageQuery.razor",
                MetaTitle = "Blazor Natural Language Query - Syncfusion AI Demos",
                HeaderText = "Blazor Query Builder Example - Natural Language Query Processing",
                MetaDescription = "This demo shows how to convert plain English queries into structured filter conditions automatically for intuitive data filtering without complex syntax.",
                NotificationDescription = new string[]{ @" This demo shows the natural language querying AI feature in Query Builder." },
            },
#endif
            new Sample
            {
                Name = "Value Template",
                Category = "Templates",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor Query Builder | Value Templates | Syncfusion",
                HeaderText = "Blazor Query Builder - Value Templates",
                MetaDescription = "Blazor QueryBuilder value template demo shows custom value editor. Replace default input controls with special components like sliders, dropdowns, date pickers."
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
                MetaDescription = "Blazor QueryBuilder column template demo shows customizing column selection.Create advanced field selector with grouping, filtering, and enhanced visualization."
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
                MetaDescription = "Blazor Query Builder demo shows dynamic filtering of grid data. Apply complex query conditions to filter grid records in real-time with visual query building."
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
                MetaDescription = "This Blazor Query Builder header template demo shows customizing group headers. Create enhanced header designs with additional controls, information displays."
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
                MetaDescription = "This Blazor Data Form example showcases the default rendering of the form using minimal configurations, highlighting its simplicities and efficiencies.",
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
                MetaDescription = "This Blazor Data Form demo shows the component's rendering using a column layout, offering a structured and organized appearance for displaying form elements.",
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
                MetaDescription = "Blazor DataForm example highlights the template functionality within it, showcasing how to enhance form customization with tailored layouts and designs.",
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
                MetaDescription = "This example of Blazor Data Form example demonstrates the process of using custom editors instead of the default editors in a Blazor Data Form component.",
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
                MetaTitle = "Blazor Data Form Example | API Forms | Syncfusion Demos",
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
