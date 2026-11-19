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
                MetaTitle = "Blazor QueryBuilder Demos - Default | Forms Demos | Syncfusion",
                FileName = "DefaultFunctionalities.razor",
                HeaderText = "Blazor Query Builder - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Query Builder allows users to create rules with conditions and filters to build structured queries for dynamic data processing.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-query-builder"
            },
            new Sample
            {
                Name = "Complex DataBinding",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/complex-databinding",
                FileName = "ComplexDataBinding.razor",
                MetaTitle = "Blazor QueryBuilder - Complex DataBinding | Forms Demos | Syncfusion",
                HeaderText = "Blazor Query Builder - Complex Data Binding",
                MetaDescription = "See how the Syncfusion Blazor Query Builder supports complex data binding with nested objects and fields to create flexible and advanced query conditions."
            },
            new Sample
            {
                Name = "Mongo and SQL Query",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/mongo-query",
                FileName = "MongoQuery.razor",
                MetaTitle = "Blazor QueryBuilder - Mongo and SQL Query | Forms Demos | Syncfusion",
                HeaderText = "Blazor Query Builder - MongoDB and SQL Query Generation",
                MetaDescription = "See how the Syncfusion Blazor Query Builder generates MongoDB and SQL queries from visual rules to convert conditions into database ready formats easily."
            },
            new Sample
            {
                Name = "Lock Group/Rule",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/lock-group",
                FileName = "LockGroup.razor",
                MetaTitle = "Blazor QueryBuilder - Lock Group/Rule | Forms Demos | Syncfusion",
                HeaderText = "Blazor Query Builder - Lock Groups and Rules",
                MetaDescription = "See how the Syncfusion Blazor Query Builder locks groups and rules to prevent changes and ensure critical query conditions remain secure during updates."
            },
            new Sample
            {
                Name = "Clone Group/Rule",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/clone-group",
                FileName = "CloneGroup.razor",
                MetaTitle = "Blazor QueryBuilder - Clone Group/Rule | Forms Demos | Syncfusion",
                HeaderText = "Blazor Query Builder - Clone Groups and Rules",
                MetaDescription = "See how the Syncfusion Blazor Query Builder clones groups and rules to quickly duplicate and modify conditions without rebuilding queries from scratch."
            },
            new Sample
            {
                Name = "Drag and Drop",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/drag-and-drop",
                FileName = "DragAndDrop.razor",
                MetaTitle = "Blazor QueryBuilder - Drag and Drop | Forms Demos | Syncfusion",
                HeaderText = "Blazor Query Builder - Drag and Drop Functionality",
                MetaDescription = "See how the Syncfusion Blazor Query Builder supports drag and drop to reorder rules and groups, enabling flexible query restructuring with simple interactions.",
            },
            new Sample
            {
                Name = "Separate Connector",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/separate-connector",
                FileName = "SeparateConnector.razor",
                MetaTitle = "Blazor QueryBuilder - Separate Connector | Forms Demos | Syncfusion",
                HeaderText = "Blazor Query Builder - Separate Connector Logic",
                MetaDescription = "See how the Syncfusion Blazor Query Builder supports different logical operators within groups to create flexible queries with multiple conditions easily.",
            },
#if SERVER
            new Sample
            {
                Name = "Natural Language Query",
                Category = "Smart AI Solutions",
                Directory = "AISamples/QueryBuilder",
                Url = "query-builder/ai-natural-languagequery",
                FileName = "NaturalLanguageQuery.razor",
                MetaTitle = "Blazor QueryBuilder Demos - Natural Language Query | Syncfusion",
                HeaderText = "Blazor Query Builder - AI Powered Natural Language Query Example",
                MetaDescription = "See how the Syncfusion Blazor Query Builder converts natural language queries into structured filters, enabling intuitive data filtering without complex syntax.",
            },
#endif
            new Sample
            {
                Name = "Value Template",
                Category = "Templates",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor QueryBuilder - Value Template | Forms Demos | Syncfusion",
                HeaderText = "Blazor Query Builder - Value Templates",
                MetaDescription = "See how the Syncfusion Blazor Query Builder supports value templates to customize editors with sliders, dropdowns, and pickers for better data input control."
            },
            new Sample
            {
                Name = "Column Template",
                Category = "Templates",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/column-template",
                FileName = "ColumnTemplate.razor",
                MetaTitle = "Blazor QueryBuilder - Column Template | Forms Demos | Syncfusion",
                HeaderText = "Blazor Query Builder - Column Templates",
                MetaDescription = "See how the Syncfusion Blazor Query Builder enables column templates for advanced field selection with grouping, filtering, and improved visualization options."
            },
             new Sample
            {
                Name = "Integration with Data Grid",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/grid",
                FileName = "Grid.razor",
                MetaTitle = "Blazor QueryBuilder Demos - Integration with Data Grid | Syncfusio",
                HeaderText = "Blazor Query Builder - Integration with Data Grid",
                MetaDescription = "See how the Syncfusion Blazor Query Builder integrates with DataGrid to apply filters dynamically and update data using simple and flexible visual query tools."
            },
            new Sample
            {
                Name = "Header Template",
                Category = "Templates",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/header-template",
                FileName = "HeaderTemplate.razor",
                MetaTitle = "Blazor QueryBuilder - Header Template | Forms Demos | Syncfusion",
                HeaderText = "Blazor Query Builder - Header Templates",
                MetaDescription = "See how the Syncfusion Blazor Query Builder supports header templates to customize group headers with additional controls and enhanced visual presentation."
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
                MetaTitle = "Blazor DataForms - Default Functionalities | Forms Demos | Syncfusion",
                HeaderText = "Blazor Data Form Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Data Form renders forms with minimal setup and configuration to enable fast form creation with flexible layout and input options.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-data-form",
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
                MetaTitle = "Blazor DataForm Examples - Column Layout | Forms Demos | Syncfusion",
                HeaderText = "Blazor Data Form Example - Column Layout",
                MetaDescription = "See how the Syncfusion Blazor Data Form uses a column layout to organize fields clearly, providing a structured interface for displaying form elements.",
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
                MetaTitle = "Blazor DataForm Examples - Form Groups | Forms Demos | Syncfusion",
                HeaderText = "Blazor Data Form Example - Form Groups",
                MetaDescription = "See how the Syncfusion Blazor Data Form groups related fields together to improve structure, readability, and usability for better form design and user input.",
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
                MetaTitle = "Blazor DataForm Examples - Adaptive Layout | Forms Demos | Syncfusion",
                HeaderText = "Blazor Data Form Example - Adaptive Layout",
                MetaDescription = "See how the Syncfusion Blazor Data Form supports adaptive layouts, adjusting field sizes automatically for different screens to ensure responsive design",
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
                MetaTitle = "Blazor DataForm Examples - Templates | Forms Demos | Syncfusion",
                HeaderText = "Blazor Data Form Example - Data Form Templates",
                MetaDescription = "See how the Syncfusion Blazor Data Form supports floating labels to improve usability and readability with better input visibility and form interaction.",
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
                MetaTitle = "Blazor DataForm Examples - Custom Editors | Forms Demos | Syncfusion",
                HeaderText = "Blazor Data Form Example - Custom Editors",
                MetaDescription = "See how the Syncfusion Blazor Data Form allows custom editors to replace default inputs, enabling tailored data entry experiences with specialized components.",
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
                MetaTitle = "Blazor DataForm Examples - Floating Label | Forms Demos | Syncfusion",
                HeaderText = "Blazor Data Form Example - Floating Label",
                MetaDescription = "See how the Syncfusion Blazor Data Form supports floating labels to improve usability and readability with clear input focus and better form interaction.",
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
                MetaTitle = "Blazor Data Form Demos - API Examples | Forms Demos | Syncfusion",
                HeaderText = "Blazor Data Form Example - API",
                MetaDescription = "See how the Syncfusion Blazor Data Form API provides control over layout, labels, and actions to customize behavior and manage form interactions efficiently.",
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
