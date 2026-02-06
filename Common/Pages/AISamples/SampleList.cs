#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
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
        public List<Sample> SmartAISolutions { get; set; } = new List<Sample>{
            
            new Sample
            {
                Name = "Semantic Filtering (Embedding)",
                Category = "DataGrid",
                Directory = "AISamples/DataGrid",
                Url = "ai-datagrid/semantic-filtering",
                FileName = "GridSemanticFiltering.razor",
                MetaTitle = "DataGrid Semantic Filtering Example - Syncfusion AI Demos",
                HeaderText = "Blazor DataGrid Example - Semantic Filtering with Embedding",
                MetaDescription = "This Blazor DataGrid semantic filtering example demonstrates advanced filtering using natural language processing for efficiently finding relevant information.",
                NotificationDescription = new string[]{ @"This demo shows the semantic filtering AI feature in Data Grid." }
            },
            new Sample
            {
                Name = "Anomaly Detection",
                Category = "DataGrid",
                Directory = "AISamples/DataGrid",
                Url = "ai-datagrid/anomaly-detection",
                FileName = "AnomalyData.razor",
                MetaTitle = "Blazor DataGrid Anomaly Detection - Syncfusion AI Demos",
                HeaderText = "Blazor DataGrid Example - AI-Powered Anomaly Detection",
                MetaDescription = "This Blazor DataGrid anomaly detection example showcases AI integration to identify unusual patterns in your data for better analysis and decision making.",
                NotificationDescription = new string[]{ @"This demo illustrates the integration of AI into a Data Grid to detect anomalies within the data set." }
            },
            new Sample
            {
                Name = "Stock Forecasting",
                Category = "Charts",
                Directory = "AISamples/Charts",
                Url = "ai-charts/stock-forecasting",
                FileName = "StockForecasting.razor",
                MetaTitle = "Blazor Charts Stock Forecasting - Syncfusion AI Demos",
                HeaderText = "Blazor Charts Example - Stock Forecasting with AI",
                MetaDescription = "This demo showcases the AI feature in Charts, which analyzes historical stock data to intelligently forecast future trends and support informed decision-making."
            },
            new Sample
            {
                Name = "Data Preprocessing",
                Category = "Charts",
                Directory = "AISamples/Charts",
                Url = "ai-charts/data-preprocessing",
                FileName = "DataPreprocessing.razor",
                MetaTitle = "Blazor Charts Data Preprocessing - Syncfusion AI Demos",
                HeaderText = "Blazor Charts Example - Data Preprocessing with AI",
                MetaDescription = "This demo showcases the AI feature in Charts that intelligently fills missing values in datasets to ensure accurate, complete, and reliable visualizations."
            },
            new Sample
            {
                Name = "Smart Chart",
                Category = "Charts",
                Directory = "AISamples/Charts",
                Url = "ai-charts/smart-chart",
                FileName = "SmartChart.razor",
                MetaTitle = "Syncfusion blazor Charts Smart Charts - Syncfusion AI Demos",
                HeaderText = "Blazor Charts Example - Smart Charts with AI",
                MetaDescription = "This Blazor Smart Charts demo uses AI to dynamically render the relevant chart type from user prompts, enabling seamless, adaptive, intuitive data exploration."
            },
            new Sample
            {
                Name = "Smart Scheduling",
                Category = "Scheduler",
                Directory = "AISamples/Schedule",
                Url = "ai-scheduler/smartscheduler",
                FileName = "SchedulerSmartAi.razor",
                MetaTitle = "Blazor Scheduler AIAssistant Example - Syncfusion AI Demos",
                HeaderText = "Blazor Scheduler AI Assistant - Smart Scheduling with Natural Language",
                MetaDescription = "This Blazor Scheduler AI Assistant demo showcases intelligent appointment creation using natural language processing with automatic time slot suggestions.",
                NotificationDescription = new string[]{ @" This demo showcases the Scheduler AI feature." }
            },
            new Sample
            {
                Name = "AI Writing Assistant",
                Category = "Rich Text Editor",
                Directory = "AISamples/RichTextEditor",
                Url = "ai-richtexteditor/ai-assistant",
                FileName = "AIAssistant.razor",
                MetaTitle = "Blazor Rich Text Editor AIAssistant - Syncfusion AI Demos",
                HeaderText = "Blazor Rich Text Editor Example - AI Writing Assistant",
                MetaDescription = "This Blazor Rich Text Editor AI Assistant example demonstrates intelligent content creation and contextual writing suggestions for improved content quality.",
                NotificationDescription = new string[]{ @" This demo showcases the Rich Text Editor AI feature." }
            },
            new Sample
            {
                Name = "Multiple AI Models",
                Category = "AIAssistView",
                Directory = "AISamples/AIAssistView",
                Url = "ai-assist-view/ai-models",
                FileName = "MultiModelAI.razor",
                MetaTitle = "Blazor AI AssistView Multiple AI Models | Modal Chat | Syncfusion",
                HeaderText = "Blazor AI AssistView Example - Multiple AI Models",
                MetaDescription = "This Blazor AI AssistView example shows how to use a custom view that supports multiple AI models, including Gemini and Azure OpenAI, for seamless integration."
            },
            new Sample
            {
                Name = "Text to Flowchart",
                Category = "Diagram",
                Directory = "AISamples/Diagram",
                Url = "ai-diagram/text-to-flowchart",
                FileName = "TextToFlowchart.razor",
                MetaTitle = "Blazor Diagram Text to Flowchart - Syncfusion AI Demos",
                HeaderText = "Blazor Diagram Example - Text to Flowchart Conversion",
                MetaDescription = "This Blazor Diagram AI demo converts plain text descriptions into professional flowcharts. Transform textual process definitions into the visual diagrams."
            },
            new Sample
            {
                Name = "Text to MindMap",
                Category = "Diagram",
                Directory = "AISamples/Diagram",
                Url = "ai-diagram/text-to-mindmap",
                FileName = "TextToMindMap.razor",
                MetaTitle = "Blazor Diagram Text to MindMap Example - Syncfusion AI Demos",
                HeaderText = "Blazor Diagram Example - Text to MindMap Generation",
                MetaDescription = "This Blazor Diagram AI feature transforms text into interactive mind maps. Convert hierarchical information into visual knowledge structures for organization."
            },
            new Sample
            {
                Name = "Text to Sequence Diagram",
                Category = "Diagram",
                Directory = "AISamples/Diagram",
                Url = "ai-diagram/text-to-sequence-diagram",
                FileName = "TextToSequence.razor",
                MetaTitle = "Blazor Diagram Text to Sequence Example - Syncfusion AI Demos",
                HeaderText = "Blazor Diagram Example - Text to Sequence Diagram Conversion",
                MetaDescription = "This Blazor Diagram AI tool creates sequence diagrams from text descriptions. Visualize object interactions and message flows with intelligent interpretation.",
            },
            new Sample
            {
                Name = "Smart Progress Predictor",
                Category = "Gantt Chart",
                Directory = "AISamples/GanttChart",
                Url = "ai-ganttchart/progress-predictor",
                FileName = "ProgressPrediction.razor",
                MetaTitle = "Gantt Chart Progress Predictor - Syncfusion AI Demos",
                HeaderText = "Blazor Gantt Chart Example - Smart Progress Predictor",
                MetaDescription = "This Blazor Gantt Chart demo uses AI to predict milestone completion and project end dates, also visualizing the future events to improve planning accuracy.",
                NotificationDescription = new string[]{ @" This demo shows the smart progress prediction in Gantt Chart." }
            },
            new Sample
            {
                Name = "Smart Resource Allocation",
                Category = "Gantt Chart",
                Directory = "AISamples/GanttChart",
                Url = "ai-ganttchart/resource-manager",
                FileName = "ResourceOverallocation.razor",
                MetaTitle = "Gantt Chart Resource Allocation - Syncfusion AI Demos",
                HeaderText = "Blazor Gantt Chart Example - Smart Resource Allocation",
                MetaDescription = "This Blazor Gantt Chart demo showcases AI-powered resource reallocation that detects overallocation and optimizes task distribution for balanced workloads.",
                NotificationDescription = new string[]{ @" This demo shows the smart resource allocation AI feature in Gantt Chart." }
            },
            new Sample
            {
                Name = "Tag Search",
                Category = "File Manager",
                Directory = "AISamples/FileManager",
                Url = "ai-filemanager/tagsearch",
                FileName = "FileManagerTagSearch.razor",
                MetaTitle = "Blazor File Manager Tag Search - Syncfusion AI Demos",
                HeaderText = "Blazor FileManager Example - AI-driven Tag Search",
                MetaDescription = "This Blazor FileManager example demonstrates an AI-driven tag search and tagging features, enhancing its functionality and user experience efficiently."
            },
            new Sample
            {
                Name = "Smart File Operations",
                Category = "File Manager",
                Directory = "AISamples/FileManager",
                Url = "ai-filemanager/smart-filemanager",
                FileName = "SmartFileManager.razor",
                MetaTitle = "AI Operations with File Manager - Syncfusion AI Demos",
                HeaderText = "Blazor FileManager Example - Smart AI Operations",
                MetaDescription = "Utilize AI-driven processes to enhance file retrieval, management in Blazor FileManager. It improves efficiency, ensures seamless operations within application."
            },
            new Sample
            {
                Name = "Smart Pivot Table",
                Category = "Pivot Table",
                Directory = "AISamples/PivotTable",
                Url = "ai-pivottable/smart-pivot",
                FileName = "SmartPivot.razor",
                MetaTitle = "Pivot Table  Smart Data Analytics - Syncfusion AI Demos",
                HeaderText = "Blazor Pivot Table Example - AI-Powered Pivot Table",
                MetaDescription = "This Blazor Pivot Table demo showcases AI-powered data insights with smart aggregation, predictive modeling, and adaptive filtering for enhanced analytics.",
                NotificationDescription = new string[]{ @" This demo shows the smart pivot table in Pivot Table." }
            },
            new Sample
            {
                Name = "Adaptive Structuring",
                Category = "TreeGrid",
                Directory = "AISamples/TreeGrid",
                Url = "ai-treegrid/adaptive-datastructuring",
                FileName = "AdaptiveDataStructuring.razor",
                MetaTitle = "TreeGrid Adaptive Structuring - Syncfusion AI Demos",
                HeaderText = "Blazor TreeGrid Example - AI-Powered Adaptive Structuring",
                MetaDescription = "This Blazor TreeGrid demo uses AI to detect and repair erroneous hierarchical data, automatically organizing items into proper parent-child relationships.",
                NotificationDescription = new string[]{ @" This demo shows the adaptive structuring in Tree Grid." }
            },
            new Sample
            {
                Name = "Weather Prediction",
                Category = "Maps",
                Directory = "AISamples/Maps",
                Url = "ai-maps/weather-prediction",
                FileName = "WeatherPrediction.razor",
                MetaTitle = "Maps Forecasting Weather Condition - Syncfusion AI Demos",
                HeaderText = "Blazor Maps Example - Weather Prediction",
                MetaDescription = "This Blazor Maps demo uses AI to forecast five-day weather conditions across the United States, displaying predictions with intuitive marker templates.",
                NotificationDescription = new string[]{ @" This demo shows the weather prediction in Maps." }
            },
            new Sample
            {
                Name = "Natural Language Query",
                Category = "Query Builder",
                Directory = "AISamples/QueryBuilder",
                Url = "ai-querybuilder/natural-languagequery",
                FileName = "NaturalLanguageQuery.razor",
                MetaTitle = "Blazor Natural Language Query - Syncfusion AI Demos",
                HeaderText = "Blazor Query Builder Example - Natural Language Query Processing",
                MetaDescription = "This Blazor Query Builder AI demo converts plain English queries into structured filter conditions for intuitive data filtering without complex syntax.",
                NotificationDescription = new string[]{ @" This demo shows the natural language querying AI feature in Query Builder." }
            },
            new Sample
            {
                Name = "Smart Task Suggestion",
                Category = "Kanban",
                Directory = "AISamples/Kanban",
                Url = "ai-kanban/aitask-recommendation",
                FileName = "AITaskRecommendation.razor",
                MetaTitle = "Blazor Kanban AITask Recommendation - Syncfusion AI Demos",
                HeaderText = "Blazor Kanban Example - AI Task Recommendation",
                MetaDescription = "This Blazor Kanban AI demo showcases task recommendations through anomaly detection. Identify and highlight tasks requiring attention for better workflows.",
                NotificationDescription = new string[]{ @" This demo shows the anomaly detection AI feature in kanban" }
            },
            new Sample
            {
                Name = "Sentiment Analysis",
                Category = "Kanban",
                Directory = "AISamples/Kanban",
                Url = "ai-kanban/sentiment-analysis",
                FileName = "SentimentAnalysis.razor",
                MetaTitle = "Blazor Kanban Sentimental Analysis - Syncfusion AI Demos",
                HeaderText = "Blazor Kanban Example - AI Sentimental Analysis",
                MetaDescription = "This Blazor Kanban demo uses AI to analyze customer feedback and automatically generate emoticons that reflect sentiment, updating task cards with visual cues.",
                NotificationDescription = new string[]{ @" This demo shows the Sentimental Analysis feature in Kanban." }
            },
            new Sample
            {
                Name = "Semantic Searching (Embedding)",
                Category = "ComboBox",
                Directory = "AISamples/ComboBox",
                Url = "ai-combobox/embeddings",
                FileName = "ComboBoxEmbeddings.razor",
                MetaTitle = "Combo Box Semantic Searching - Syncfusion AI Demos",
                HeaderText = "Blazor ComboBox Example - Semantic Searching with Embeddings",
                MetaDescription = "This Blazor ComboBox semantic search demo showcases context-aware searching using AI. Find related items based on meaning for a more intuitive experience.",
                NotificationDescription = new string[]{ @" This demo shows the semantic search AI feature in Combo Box." }
            }
        };
    }
}