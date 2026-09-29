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
                MetaTitle = "Blazor ArcGauge Examples - Default | ArcGauge Demos | Syncfusion",
                HeaderText = "Blazor Arc Gauge Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Default ArcGauge visualizes metrics with customizable ranges, pointers, and thresholds to provide clear KPIs & quick status checks",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-arc-gauge"
            },
            
            new Sample
            {
                Name = "Customer Satisfaction Score",
                Category = "Arc Gauge",
                Directory = "ArcGauge/ArcGauge",
                Url = "arc-gauge/customer-satisfaction-score",
                MetaTitle = "Blazor ArcGauge Demos - Customer Satisfaction Score | Syncfusion",
                FileName = "CustomerSatisfactionScore.razor",
                HeaderText = "Blazor Arc Gauge Example - Customer Satisfaction Score",
                MetaDescription = "See how the Syncfusion Blazor Customer Satisfaction Score gauge shows satisfaction with colored scales, thresholds, and alerts to enable fast feedback"
            },
            new Sample
            {
                Name = "Key Performance Indicator",
                Category = "Arc Gauge",
                Directory = "ArcGauge/ArcGauge",
                Url = "arc-gauge/key-performance-indicator",
                FileName = "KeyPerformanceIndicator.razor",
                MetaTitle = "Blazor ArcGauge Demos - Key Performance Indicator | Syncfusion",
                HeaderText = "Blazor Arc Gauge Example - Key Performance Indicator",
                MetaDescription = "See how the Syncfusion Blazor Key Performance Indicator gauge combines multiple gauges and thresholds with alerts and visuals to monitor metrics effectively"
            },            
            new Sample
            {
                Name = "Patterns",
                Category = "Arc Gauge",
                Directory = "ArcGauge/ArcGauge",
                Url = "arc-gauge/patterns",
                FileName = "Patterns.razor",
                MetaTitle = "Blazor ArcGauge Examples - Patterns | ArcGauge Demos | Syncfusion",
                HeaderText = "Blazor Arc Gauge Example - Pattern Styles",
                MetaDescription = "See how the Syncfusion Blazor Patterns ArcGauge shows styling options with fill patterns and color schemes to enhance dashboard aesthetics and readability"
            }
        };
    }
}