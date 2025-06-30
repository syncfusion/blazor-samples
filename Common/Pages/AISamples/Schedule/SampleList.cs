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
        public List<Sample> AIScheduler { get; set; } = new List<Sample>{

            new Sample
            {
                Name = "AIAssistant",
                Category = "Scheduler",
                Directory = "AISamples/Schedule",
                Url = "ai-scheduler/smartscheduler",
                FileName = "SchedulerSmartAi.razor",
                MetaTitle = "Blazor Scheduler AIAssistant Example - Syncfusion AI Demos",
                HeaderText = "Blazor Scheduler AI Assistant - Smart Scheduling with Natural Language",
                MetaDescription = "This Blazor Scheduler AI Assistant demo showcases intelligent appointment creation using natural language processing. Experience AI-powered event scheduling with automatic time slot suggestions and recurring pattern recognition.",
                NotificationDescription = new string[]{ @" This demo showcases the Scheduler AI feature." }
            }
        };
    }
}