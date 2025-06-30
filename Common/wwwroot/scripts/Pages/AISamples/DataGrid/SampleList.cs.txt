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
        public List<Sample> AIDataGrid { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Semantic Filtering (Embedding)",
                Category = "DataGrid",
                Directory = "AISamples/DataGrid",
                Url = "ai-datagrid/semantic-filtering",
                FileName = "GridSemanticFiltering.razor",
                MetaTitle = "DataGrid Semantic Filtering Example - Syncfusion AI Demos",
                HeaderText = "Blazor DataGrid Example - Semantic Filtering with Embedding",
                MetaDescription = "This Blazor DataGrid semantic filtering example demonstrates advanced filtering using natural language processing. Users can filter data using context-aware queries to efficiently find relevant information.",
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
                MetaDescription = "This Blazor DataGrid anomaly detection example showcases AI integration to identify unusual patterns in your data. Quickly spot outliers and statistical anomalies for better data analysis and decision making.",
                NotificationDescription = new string[]{ @"This demo illustrates the integration of AI into a Data Grid to detect anomalies within the data set." }
            }
        };
    }
}
