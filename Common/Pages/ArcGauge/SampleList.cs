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
        public List<Sample> ArcGauge { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default",
                Category = "Arc Gauge",
                Directory = "ArcGauge/ArcGauge",
                Url = "arc-gauge/default",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Arc Gauge Default | Basic Features | Syncfusion",
                HeaderText = "Blazor Arc Gauge Example - Default Functionalities",
                MetaDescription = "This Blazor Arc Gauge default example demonstrates basic gauge features with customizable ranges, pointers, and styling options for data visualization."
            },
            
            new Sample
            {
                Name = "Customer Satisfaction Score",
                Category = "Arc Gauge",
                Directory = "ArcGauge/ArcGauge",
                Url = "arc-gauge/customer-satisfaction-score",
                MetaTitle = "Arc Gauge Customer Satisfaction Score - Syncfusion Demos",
                FileName = "CustomerSatisfactionScore.razor",
                HeaderText = "Blazor Arc Gauge Example - Customer Satisfaction Score",
                MetaDescription = "This Arc Gauge demo showcases visualizing customer satisfaction using customizable scales, hues, and notes, aiding in effective tracking of feedback metrics."
            },
            new Sample
            {
                Name = "Key Performance Indicator",
                Category = "Arc Gauge",
                Directory = "ArcGauge/ArcGauge",
                Url = "arc-gauge/key-performance-indicator",
                FileName = "KeyPerformanceIndicator.razor",
                MetaTitle = "Blazor Arc Gauge KPI | Performance Indicators | Syncfusion",
                HeaderText = "Blazor Arc Gauge Example - Key Performance Indicator",
                MetaDescription = "This Blazor Arc Gauge KPI example illustrates creating KPIs with multiple gauges, thresholds, and tailored visuals for effective business metric visualization."
            },            
            new Sample
            {
                Name = "Patterns",
                Category = "Arc Gauge",
                Directory = "ArcGauge/ArcGauge",
                Url = "arc-gauge/patterns",
                FileName = "Patterns.razor",
                MetaTitle = "Blazor Arc Gauge Patterns | Multiple Styling Options | Syncfusion",
                HeaderText = "Blazor Arc Gauge Example - Pattern Styles",
                MetaDescription = "This Arc Gauge pattern demo showcases diverse styling options, including fill patterns, color schemes, and layouts, crafted to create visually appealing gauges."
            }
        };
    }
}