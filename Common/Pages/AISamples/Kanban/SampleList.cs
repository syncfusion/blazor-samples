#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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
        public List<Sample> AIKanban { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "AITask Recommendation",
                Category = "Kanban",
                Directory = "AISamples/Kanban",
                Url = "ai-kanban/aitask-recommendation",
                FileName = "AITaskRecommendation.razor",
                NotificationDescription = new string[]{ @" This demo shows the anomaly detection AI feature in kanban" }
            },
             new Sample
            {
                Name = "Sentiment Analysis",
                Category = "Kanban",
                Directory = "AISamples/Kanban",
                Url = "ai-kanban/sentiment-analysis",
                FileName = "SentimentAnalysis.razor",
                NotificationDescription = new string[]{ @" This demo shows the adaptive data structuring AI feature in Tree Grid." }
            }
        };
    }
}
