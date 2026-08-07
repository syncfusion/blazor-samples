using System.Collections.Generic;

namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> Kanban { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor Kanban Examples - Overview | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban Board Component - Overview",
                MetaDescription = "See how the Syncfusion Blazor Kanban visualizes workflows with columns, cards, and drag and drop support to manage tasks and improve team productivity.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-kanban-board",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Overview.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultCss",
                        FileName="Overview.razor.css"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="KanbanDataModels.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Kanban - Default Functionalities | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban Board - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Kanban manages tasks with drag and drop, column layouts, and card views to streamline workflows and track progress effectively.",
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
                        FileName="KanbanDataModels.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Swimlane",
                Category = "Kanban",
                Type = SampleType.None,
                Directory = "Kanban/Kanban",
                Url = "kanban/swimlane",
                FileName = "Swimlane.razor",
                MetaTitle = "Blazor Kanban Demos - Swimlane Visualization Examples | Syncfusion",
                HeaderText = "Blazor Kanban Board - Swimlane Visualization",
                MetaDescription = "See how the Syncfusion Blazor Kanban organizes tasks using swimlanes by team or priority with parallel tracks to improve clarity and workflow management.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Swimlane.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="KanbanDataModels.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Workflow",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/workflow",
                FileName = "Workflow.razor",
                MetaTitle = "Blazor Kanban Examples - Workflow | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban Board - Workflow Management",
                MetaDescription = "See how the Syncfusion Blazor Kanban defines workflows with custom states and transitions to visualize task progress and enforce structured process management.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Workflow.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="KanbanDataModels.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Stacked Header",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/stacked-header",
                FileName = "StackedHeader.razor",
                MetaTitle = "Blazor Kanban Examples - Stacked Header | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban Board - Stacked Headers",
                MetaDescription = "See how the Syncfusion Blazor Kanban groups columns using stacked headers to organize related stages and provide clear and structured workflow visualization.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="StackedHeader.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="KanbanDataModels.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Dialog Editing",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/dialog-editing",
                FileName = "DialogEditing.razor",
                MetaTitle = "Blazor Kanban Examples - Dialog Editing | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban Board - Dialog Editing",
                MetaDescription = "See how the Syncfusion Blazor Kanban enables dialog editing with built in forms, validation, and structured inputs to easily add and update task details.",
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
                        FileName="KanbanDataModels.cs"
                    }
                }
            },
#if SERVER
            new Sample
            {
                Name = "Smart Task Suggestion",
                Category = "Smart AI Solutions",
                Directory = "AISamples/Kanban",
                Url = "kanban/ai-task-recommendation",
                FileName = "AITaskRecommendation.razor",
                MetaTitle = "Blazor Kanban - Smart Task Suggestion | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban - AI Powered Task Recommendation Example",
                MetaDescription = "See how the Syncfusion Blazor Kanban uses AI based task suggestions and anomaly detection to highlight important tasks and improve workflow decision making.",
                Type = SampleType.AI,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="AITaskRecommendation.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultCss",
                        FileName="AITaskRecommendation.razor.css"
                    }
                }
            },
            new Sample
            {
                Name = "Sentiment Analysis",
                Category = "Smart AI Solutions",
                Directory = "AISamples/Kanban",
                Url = "kanban/ai-sentiment-analysis",
                FileName = "SentimentAnalysis.razor",
                MetaTitle = "Blazor Kanban - Sentiment Analysis | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban - AI Powered Sentimental Analysis Example",
                MetaDescription = "See how the Syncfusion Blazor Kanban uses AI sentiment analysis to evaluate feedback and display visual indicators on cards for better task understanding.",
                Type = SampleType.AI,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="SentimentAnalysis.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultCss",
                        FileName="SentimentAnalysis.razor.css"
                    }
                }
            },
#endif
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Kanban/Kanban",
                Url = "kanban/local-data",
                FileName = "LocalData.razor",
                MetaTitle = "Blazor Kanban Examples - Local Data | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban Board - Local Data Binding",
                MetaDescription = "See how the Syncfusion Blazor Kanban binds to local data sources like arrays and objects to manage tasks efficiently without relying on external services.",
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
                        FileName="KanbanDataModels.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Kanban/Kanban",
                Url = "kanban/remote-data",
                FileName = "RemoteData.razor",
                MetaTitle = "Blazor Kanban Examples - Remote Data | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban Board - Remote Data Binding",
                MetaDescription = "See how the Syncfusion Blazor Kanban connects to REST APIs and services to fetch and update tasks dynamically, enabling scalable real time workflow management."
            },
            new Sample
            {
                Name = "Observable Collection",
                Category = "Data Binding",
                Directory = "Kanban/Kanban",
                Url = "kanban/observable",
                FileName = "KanbanObservable.razor",
                MetaTitle = "Blazor Kanban - Observable Collection | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban Board - Observable Collection Binding",
                MetaDescription = "See how the Syncfusion Blazor Kanban uses observable collections for real time updates with automatic UI refresh, ensuring smooth handling of task changes."
            },
            new Sample
            {
                Name = "ExpandoObject Binding",
                Category = "Data Binding",
                Directory = "Kanban/Kanban",
                Url = "kanban/expando-object",
                FileName = "KanbanExpandoObject.razor",
                MetaTitle = "Blazor Kanban - ExpandoObject Binding | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban Board - ExpandoObject Binding",
                MetaDescription = "See how the Syncfusion Blazor Kanban binds to ExpandoObject for dynamic properties, enabling flexible task structures and adaptable workflow management."
            },
            new Sample
            {
                Name = "DynamicObject Binding",
                Category = "Data Binding",
                Directory = "Kanban/Kanban",
                Url = "kanban/dynamic-object",
                FileName = "KanbanDynamicObject.razor",
                MetaTitle = "Blazor Kanban - DynamicObject Binding | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban Board - DynamicObject Binding",
                MetaDescription = "See how the Syncfusion Blazor Kanban supports dynamic object binding with flexible schemas to create customizable and scalable task management solutions."
            },
            new Sample
            {
                Name = "Header Template",
                Category = "Templates",
                Directory = "Kanban/Kanban",
                Url = "kanban/header-template",
                FileName = "HeaderTemplate.razor",
                MetaTitle = "Blazor Kanban Examples - Header Template | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban Board - Header Template Customization",
                MetaDescription = "See how the Syncfusion Blazor Kanban customizes headers with templates, HTML, and components to enhance visuals and display useful column information.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="HeaderTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultCss",
                        FileName="HeaderTemplate.razor.css"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="KanbanDataModels.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Swimlane Template",
                Category = "Templates",
                Directory = "Kanban/Kanban",
                Url = "kanban/swimlane-template",
                FileName = "SwimlaneTemplate.razor",
                MetaTitle = "Blazor Kanban Demos - Swimlane Template Examples | Syncfusion",
                HeaderText = "Blazor Kanban Board - Swimlane Template Customization",
                MetaDescription = "See how the Syncfusion Blazor Kanban customizes swimlane headers with templates and rich content to improve categorization and visual clarity in workflows.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="SwimlaneTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="KanbanDataModels.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Card Template",
                Category = "Templates",
                Directory = "Kanban/Kanban",
                Url = "kanban/card-template",
                FileName = "CardTemplate.razor",
                MetaTitle = "Blazor Kanban Examples - Card Template | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban Board - Card Template Customization",
                MetaDescription = "See how the Syncfusion Blazor Kanban supports custom card templates with images and layouts to display detailed task information and enhance user interaction.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="CardTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultCss",
                        FileName="CardTemplate.razor.css"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="KanbanDataModels.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Tooltip Template",
                Category = "Templates",
                Directory = "Kanban/Kanban",
                Url = "kanban/tooltip-template",
                FileName = "TooltipTemplate.razor",
                MetaTitle = "Blazor Kanban Examples - Tooltip Template | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban Board - Tooltip Template Customization",
                MetaDescription = "See how the Syncfusion Blazor Kanban shows detailed tooltips with templates and rich content to provide additional task information on hover interactions.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="TooltipTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="KanbanDataModels.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Toggle Columns",
                Category = "Columns",
                Directory = "Kanban/Kanban",
                Url = "kanban/toggle-columns",
                FileName = "ToggleColumns.razor",
                MetaTitle = "Blazor Kanban Examples - Toggle Columns | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban Board - Toggle Columns",
                MetaDescription = "See how the Syncfusion Blazor Kanban toggles column visibility dynamically to focus on specific workflow stages and improve productivity in task management.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ToggleColumns.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="KanbanDataModels.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Show/Hide Columns",
                Category = "Columns",
                Directory = "Kanban/Kanban",
                Url = "kanban/showhide-columns",
                FileName = "ShowHideColumns.razor",
                MetaTitle = "Blazor Kanban Demos - Show/Hide Columns Examples | Syncfusion",
                HeaderText = "Blazor Kanban Board - Show/Hide Columns",
                MetaDescription = "See how the Syncfusion Blazor Kanban controls column visibility programmatically, allowing flexible board customization and adaptive workflows for user needs.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ShowHideColumns.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="KanbanDataModels.cs"
                    }
                }
            },
            new Sample
            {
                Name = "WIP Validation",
                Category = "Validation",
                Directory = "Kanban/Kanban",
                Url = "kanban/wip-validation",
                FileName = "WipValidation.razor",
                MetaTitle = "Blazor Kanban Examples - WIP Validation | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban Board - Work-In-Progress Validation",
                MetaDescription = "See how the Syncfusion Blazor Kanban enforces work in progress limits on columns to prevent overload, ensuring balanced task flow and efficient workflows.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="WipValidation.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="KanbanDataModels.cs"
                    }
                }
            },
            new Sample
            {
                Name = "API",
                Category = "Miscellaneous",
                Directory = "Kanban/Kanban",
                Url = "kanban/api",
                FileName = "Api.razor",
                MetaTitle = "Blazor Kanban Demos - API Examples | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban Board - API Reference",
                MetaDescription = "See how the Syncfusion Blazor Kanban provides API methods to control board behavior, manage tasks programmatically, and extend functionality in applications.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Api.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="KanbanDataModels.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Events",
                Category = "Miscellaneous",
                Directory = "Kanban/Kanban",
                Url = "kanban/events",
                FileName = "Events.razor",
                MetaTitle = "Blazor Kanban Demos - Events Examples | Kanban Demos | Syncfusion",
                HeaderText = "Blazor Kanban Board - Event Handling",
                MetaDescription = "See how the Syncfusion Blazor Kanban handles events like drag drop, selection, and updates to trigger custom logic and build interactive workflow applications.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Events.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="KanbanDataModels.cs"
                    }
                }
            }
        };
    }
}
