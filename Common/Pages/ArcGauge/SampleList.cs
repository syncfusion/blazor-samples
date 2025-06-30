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
                MetaDescription = "This Blazor Arc Gauge example shows how to visualize customer satisfaction scores with customizable ranges, colors, and annotations to help track customer feedback metrics effectively."
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
                MetaDescription = "This Blazor Arc Gauge KPI example demonstrates how to create key performance indicators with multiple gauges, threshold marks, and customizable appearance for business metric visualization."
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
                MetaDescription = "This Blazor Arc Gauge patterns example showcases various styling options including different fill patterns, color schemes, and layout configurations for creating visually appealing gauges."
            }
        };
    }
}