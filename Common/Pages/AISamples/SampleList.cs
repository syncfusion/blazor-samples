using System.Collections.Generic;

namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> SmartAISolutions { get; set; } = new List<Sample>{
            
            new Sample
            {
                Name = "Semantic Filtering (Embedding)",
                Category = "DataGrid",
                Directory = "AISamples/DataGrid",
                Url = "ai-datagrid/semantic-filtering",
                FileName = "GridSemanticFiltering.razor",
                MetaTitle = "Blazor AI Examples - Semantic Filtering | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor DataGrid Semantic Filtering with Embedding Example",
                MetaDescription = "See how the Syncfusion Blazor Semantic Filtering (Embedding) enables context-aware search with embeddings, ranking and filters to help teams find result faster.",
            },
            new Sample
            {
                Name = "Anomaly Detection",
                Category = "DataGrid",
                Directory = "AISamples/DataGrid",
                Url = "ai-datagrid/anomaly-detection",
                FileName = "AnomalyData.razor",
                MetaTitle = "Blazor AI Examples - Anomaly Detection | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor DataGrid Anomaly Detection Example",
                MetaDescription = "See how the Syncfusion Blazor Anomaly Detection finds unusual patterns with threshold alerts and clustering, enabling faster issue detection and less downtime.",
            },
            new Sample
            {
                Name = "Stock Forecasting",
                Category = "Charts",
                Directory = "AISamples/Charts",
                Url = "ai-charts/stock-forecasting",
                FileName = "StockForecasting.razor",
                MetaTitle = "Blazor AI Examples - Stock Forecasting | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor Charts Stock Market Forecasting Example",
                MetaDescription = "See how the Syncfusion Blazor Stock Forecasting processes past market data with trend analysis and confidence ranges to provide accurate and actionable future price insights."
            },
            new Sample
            {
                Name = "Data Preprocessing",
                Category = "Charts",
                Directory = "AISamples/Charts",
                Url = "ai-charts/data-preprocessing",
                FileName = "DataPreprocessing.razor",
                MetaTitle = "Blazor AI Examples - Data Preprocessing | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor Charts Data Preprocessing Example",
                MetaDescription = "See how the Syncfusion Blazor Data Preprocessing cleans raw data by filling gaps, adjusting scales, and removing anomalies to produce more meaningful chart results."
            },
            new Sample
            {
                Name = "Smart Chart",
                Category = "Charts",
                Directory = "AISamples/Charts",
                Url = "ai-charts/smart-chart",
                FileName = "SmartChart.razor",
                MetaTitle = "Blazor AI Demos - Smart Chart Examples | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor Charts Interactive Visualization Example",
                MetaDescription = "See how the Syncfusion Blazor Smart Chart simplifies visualization by auto-selecting chart types, enabling rich interactivity, and delivering responsive designs for clearer insights."
            },
            new Sample
            {
                Name = "Smart Scheduling",
                Category = "Scheduler",
                Directory = "AISamples/Schedule",
                Url = "ai-scheduler/smartscheduler",
                FileName = "SchedulerSmartAi.razor",
                MetaTitle = "Blazor AI Examples - Smart Scheduling | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor Scheduler AI Assistant with Natural Language Example",
                MetaDescription = "See how the Syncfusion Blazor Smart Scheduling uses NLP for appointment creation and auto-suggested time slots with conflict detection to streamline planning.",
            },
            new Sample
            {
                Name = "Multiple AI Models",
                Category = "AIAssistView",
                Directory = "AISamples/AIAssistView",
                Url = "ai-assistview/ai-models",
                FileName = "MultiModelAI.razor",
                MetaTitle = "Blazor AI Examples - Multiple AI Models | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor AI AssistView Multiple AI Models Example",
                MetaDescription = "See how the Syncfusion Blazor Multiple AI Models demo integrates Gemini and Azure OpenAI with model selection and unified responses for flexible AI workflows."
            },
            new Sample
            {
                Name = "Overview",
                Category = "Inline AI Assist",
                Directory = "AISamples/InlineAIAssist",
                Url = "inline-ai-assist/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor InlineAIAssist - Overview | InteractiveChat Demos | Syncfusion",
                HeaderText = "Smart Blazor InlineAIAssist Overview Example",
                MetaDescription = "Blazor InlineAIAssist demo shows default features such as command menu interactions and response menu actions with interactive AI response visualization.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components"
            },
            new Sample
            {
                Name = "Text to Flowchart",
                Category = "Diagram",
                Directory = "AISamples/Diagram",
                Url = "ai-diagram/text-to-flowchart",
                FileName = "TextToFlowchart.razor",
                MetaTitle = "Blazor AI Examples - Text to Flowchart | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor Diagram Text to Flowchart Example",
                MetaDescription = "See how the Syncfusion Blazor Text to Flowchart converts text into flowcharts with auto-layout and editable nodes so teams visualize processes instantly."
            },
            new Sample
            {
                Name = "Text to MindMap",
                Category = "Diagram",
                Directory = "AISamples/Diagram",
                Url = "ai-diagram/text-to-mindmap",
                FileName = "TextToMindMap.razor",
                MetaTitle = "Blazor AI Examples - Text to MindMap | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor Diagram Text to MindMap Example",
                MetaDescription = "See how the Syncfusion Blazor Text to MindMap converts text into interactive mind maps with drag-and-drop and hierarchical layouts to organize ideas visually."
            },
            new Sample
            {
                Name = "Text to Sequence Diagram",
                Category = "Diagram",
                Directory = "AISamples/Diagram",
                Url = "ai-diagram/text-to-sequence-diagram",
                FileName = "TextToSequence.razor",
                MetaTitle = "Blazor AI Examples - Text to Sequence Diagram | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor Diagram Text to Sequence Diagram Example",
                MetaDescription = "See how the Syncfusion Blazor Text to Sequence Diagram converts descriptions into sequence diagrams with lifelines and message flows to clarify interactions.",
            },
            new Sample
            {
                Name = "Smart Progress Predictor",
                Category = "Gantt Chart",
                Directory = "AISamples/GanttChart",
                Url = "ai-ganttchart/progress-predictor",
                FileName = "ProgressPrediction.razor",
                MetaTitle = "Blazor AI Examples - Smart Progress Predictor | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor Gantt Chart Progress Predictor Example",
                MetaDescription = "See how the Syncfusion Blazor Smart Progress Predictor forecasts milestones and end dates with trend modeling and confidence metrics to improve planning.",
            },
            new Sample
            {
                Name = "Smart Resource Allocation",
                Category = "Gantt Chart",
                Directory = "AISamples/GanttChart",
                Url = "ai-ganttchart/resource-manager",
                FileName = "ResourceOverallocation.razor",
                MetaTitle = "Blazor AI Example - Smart Resource Allocation | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor Gantt Chart Resource Allocation Example",
                MetaDescription = "See how the Syncfusion Blazor Smart Resource Allocation detects overallocation and optimizes resources with workload balancing to improve team efficiency.",
            },
            new Sample
            {
                Name = "Tag Search",
                Category = "File Manager",
                Directory = "AISamples/FileManager",
                Url = "ai-filemanager/tagsearch",
                FileName = "FileManagerTagSearch.razor",
                MetaTitle = "Blazor AI Demos - Tag Search Examples | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor FileManager Tag Search Example",
                MetaDescription = "See how the Syncfusion Blazor Tag Search adds AI-driven tagging and semantic search with autocomplete and filters to help users find files and content faster."
            },
            new Sample
            {
                Name = "Smart File Operations",
                Category = "File Manager",
                Directory = "AISamples/FileManager",
                Url = "ai-filemanager/smart-filemanager",
                FileName = "SmartFileManager.razor",
                MetaTitle = "Blazor AI Examples - Smart File Operations | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor FileManager File Operations Example",
                MetaDescription = "See how the Syncfusion Blazor Smart File Operations improves file retrieval and batch actions with AI tagging and quick filters to streamline workflows."
            },
            new Sample
            {
                Name = "Smart Pivot Table",
                Category = "Pivot Table",
                Directory = "AISamples/PivotTable",
                Url = "ai-pivottable/smart-pivot",
                FileName = "SmartPivot.razor",
                MetaTitle = "Blazor AI Examples - Smart Pivot Table | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor Pivot Table for Intelligent Data Analysis Example",
                MetaDescription = "See how the Syncfusion Blazor Smart Pivot Table provides AI aggregation and insights with drag-and-drop fields and adaptive filters for faster analysis.",
            },
            new Sample
            {
                Name = "Adaptive Structuring",
                Category = "TreeGrid",
                Directory = "AISamples/TreeGrid",
                Url = "ai-treegrid/adaptive-datastructuring",
                FileName = "AdaptiveDataStructuring.razor",
                MetaTitle = "Blazor AI Examples - Adaptive Structuring | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor TreeGrid Adaptive Structuring Example",
                MetaDescription = "See how the Syncfusion Blazor Adaptive Structuring repairs hierarchies and auto-assigns parent-child links with validation and merge tools for cleaner data.",
            },
            new Sample
            {
                Name = "Weather Prediction",
                Category = "Maps",
                Directory = "AISamples/Maps",
                Url = "ai-maps/weather-prediction",
                FileName = "WeatherPrediction.razor",
                MetaTitle = "Blazor AI Examples - Weather Prediction | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor Maps Weather Prediction Example",
                MetaDescription = "See how the Syncfusion Blazor Weather Prediction presents weather data on maps with localized forecasts and alerts to support smarter planning.",
            },
            new Sample
            {
                Name = "Natural Language Query",
                Category = "Query Builder",
                Directory = "AISamples/QueryBuilder",
                Url = "ai-querybuilder/natural-languagequery",
                FileName = "NaturalLanguageQuery.razor",
                MetaTitle = "Blazor AI Examples - Natural Language Query | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor Query Builder Natural Language Query Example",
                MetaDescription = "See how the Syncfusion Blazor Natural Language Query converts plain English into structured filters with suggestions and quick apply to simplify querying.",
            },
            new Sample
            {
                Name = "Smart Task Suggestion",
                Category = "Kanban",
                Directory = "AISamples/Kanban",
                Url = "ai-kanban/aitask-recommendation",
                FileName = "AITaskRecommendation.razor",
                MetaTitle = "Blazor AI Examples - Smart Task Suggestion | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor Kanban Task Recommendation Example",
                MetaDescription = "See how the Syncfusion Blazor Smart Task Suggestion recommends tasks using anomaly detection and priority scoring with notifications to keep teams focused.",
            },
            new Sample
            {
                Name = "Sentiment Analysis",
                Category = "Kanban",
                Directory = "AISamples/Kanban",
                Url = "ai-kanban/sentiment-analysis",
                FileName = "SentimentAnalysis.razor",
                MetaTitle = "Blazor AI Examples - Sentiment Analysis | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor Kanban Sentimental Analysis Example",
                MetaDescription = "See how the Syncfusion Blazor Sentiment Analysis scores feedback and adds emoticon badges with trend summaries so teams can prioritize customer issues.",
            },
            new Sample
            {
                Name = "Semantic Searching (Embedding)",
                Category = "ComboBox",
                Directory = "AISamples/ComboBox",
                Url = "ai-combobox/embeddings",
                FileName = "ComboBoxEmbeddings.razor",
                MetaTitle = "Blazor AI Examples - Semantic Searching | AI Demos | Syncfusion",
                HeaderText = "Smart Blazor ComboBox Semantic Searching Example",
                MetaDescription = "See how the Syncfusion Blazor Semantic Searching (Embedding) provides meaning-based suggestions and similarity ranking with ranked results to improve discovery.",
            }
        };
    }
}