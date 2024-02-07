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
        public List<Sample> ArcGauge { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default",
                Category = "Arc Gauge",
                Directory = "ArcGauge/ArcGauge",
                Url = "arc-gauge/default",
                FileName = "DefaultFunctionalities.razor",
                NotificationDescription = new string[]{ @" This demo shows the Arc Gauge's basic rendering." }
            },
            
            new Sample
            {
                Name = "Customer Satisfaction Score",
                Category = "Arc Gauge",
                Directory = "ArcGauge/ArcGauge",
                Url = "arc-gauge/customer-satisfaction-score",
                FileName = "CustomerSatisfactionScore.razor",
                NotificationDescription = new string[]{ @" This demo shows how the Arc Gauge can be customized to represent a customer satisfaction score scenario." }
            },
            new Sample
            {
                Name = "Key Performance Indicator",
                Category = "Arc Gauge",
                Directory = "ArcGauge/ArcGauge",
                Url = "arc-gauge/key-performance-indicator",
                FileName = "KeyPerformanceIndicator.razor",
                NotificationDescription = new string[]{ @" This demo shows how the Arc Gauge can be customized to represent a key performance indicator scenario." }
            },            
            new Sample
            {
                Name = "Patterns",
                Category = "Arc Gauge",
                Directory = "ArcGauge/ArcGauge",
                Url = "arc-gauge/patterns",
                FileName = "Patterns.razor",
                NotificationDescription = new string[]{ @" This demo shows how the Arc Gauge can be rendered in different ways to demonstrate different user interfaces by customizing its axis, range, pointer, etc." }
            }
        };
    }
}
