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
        public List<Sample> AIGanttChart { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Smart Task Prioritizer",
                Category = "Gantt Chart",
                Directory = "AISamples/GanttChart",
                Url = "ai-ganttchart/task-prioritizer",
                FileName = "PrioritizeTask.razor",
                NotificationDescription = new string[]{ @" This demo shows the semantic filtering AI feature in Data Grid." }
            },
            new Sample
            {
                Name = "Smart Progress Predictor",
                Category = "Gantt Chart",
                Directory = "AISamples/GanttChart",
                Url = "ai-ganttchart/progress-predictor",
                FileName = "ProgressPrediction.razor",
                NotificationDescription = new string[]{ @" This demo shows the semantic filtering AI feature in Data Grid." }
            },
            new Sample
            {
                Name = "Smart Resource Allocation",
                Category = "Gantt Chart",
                Directory = "AISamples/GanttChart",
                Url = "ai-ganttchart/resource-manager",
                FileName = "ResourceOverallocation.razor",
                NotificationDescription = new string[]{ @" This demo shows the semantic filtering AI feature in Data Grid." }
            },
            new Sample
            {
                Name = "Smart Risk Assessor",
                Category = "Gantt Chart",
                Directory = "AISamples/GanttChart",
                Url = "ai-ganttchart/risk-assessor",
                FileName = "RiskAnalysis.razor",
                NotificationDescription = new string[]{ @" This demo shows the semantic filtering AI feature in Data Grid." }
            },
            new Sample
            {
                Name = "Smart Predictive Scheduling",
                Category = "Gantt Chart",
                Directory = "AISamples/GanttChart",
                Url = "ai-ganttchart/predictive-schedule",
                FileName = "TaskSchedule.razor",
                NotificationDescription = new string[]{ @" This demo shows the semantic filtering AI feature in Data Grid." }
            }
        };
    }
}
