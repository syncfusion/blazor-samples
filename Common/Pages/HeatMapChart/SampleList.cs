#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> HeatMapChart { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Heatmap Chart",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/default-functionalities",
                MetaTitle = "HeatMap Chart Default Functionalities - Syncfusion Demos",
                HeaderText = "Blazor HeatMap Chart Example - Default Functionalities",
                MetaDescription = "This Blazor HeatMap Chart demo shows the basic configuration and visualization of data intensity with a color gradient representation for identifying patterns.",
                FileName = "DefaultFunctionalities.razor"
            }, 
            new Sample
            {
                Name = "Calendar Heatmap",
                Category = "Heatmap Chart",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/calendar-heatmap",
                FileName = "CalendarHeatmap.razor",
                MetaTitle = "Blazor HeatMap Calendar Chart | Time-based Analysis | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Calendar Visualization",
                MetaDescription = "Blazor HeatMap Calendar demo shows date-based intensity patterns across days, weeks, and months, ideal for tracking activities or metrics over time effectively."
            },
            new Sample
            {
                Name = "Bubble Types",
                Category = "Bubble Heatmap",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/bubble-types",
                FileName = "BubbleTypes.razor",
                MetaTitle = "Blazor Bubble HeatMap Chart | Size Variations | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Bubble Type Visualization",
                MetaDescription = "This Blazor HeatMap demo shows various bubble types and configurations, where both color and size represent data values, enhancing the complex multiple data."
            },
            new Sample
            {
                Name = "Color and Size Attributes",
                Category = "Bubble Heatmap",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/color-and-size-attributes",
                MetaTitle = "HeatMap Chart Color and Size Attributes - Syncfusion Demos",
                HeaderText = "Blazor HeatMap Chart Example - Color and Size Attributes",
                MetaDescription = "Blazor Bubble HeatMap demo shows data visualization using color, size, enabling two different data dimensions to be represented simultaneously within a chart.",
                FileName = "ColorAndSizeAttributes.razor",
            },
            new Sample
            {
                Name = "Row",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/row",
                FileName = "Row.razor",
                MetaTitle = "Blazor HeatMap Row Data Binding | Array Binding | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Row Data Binding",
                MetaDescription = "Blazor HeatMap Chart demo shows row-wise data binding, showing how to map array or collection data to rows for creating heatmaps from structured data sources."
            },
            new Sample
            {
                Name = "Cell",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/cell",
                FileName = "Cell.razor",
                MetaTitle = "Blazor HeatMap Cell Data Binding | Per-Cell Data | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Cell Data Binding",
                MetaDescription = "This Blazor HeatMap Chart example demonstrates cell-level data binding, allowing direct mapping of individual data points to specific cells for precise control."
            },
            new Sample
            {
                Name = "JSON Row",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/json-row",
                FileName = "JsonRow.razor",
                MetaTitle = "Blazor HeatMap JSON Row Data | Web Data Integration | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - JSON Row Data Binding",
                MetaDescription = "This Blazor HeatMap Chart example shows how to bind JSON-formatted row data, ideal for integrating with web services and APIs that return data in JSON format."
            },
            new Sample
            {
                Name = "JSON Cell",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/json-cell",
                FileName = "JsonCell.razor",
                MetaTitle = "Blazor HeatMap JSON Cell Data | API Integration | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - JSON Cell Data Binding",
                MetaDescription = "This Blazor HeatMap Chart demo shows cell-level JSON data binding, allowing flexible integration with various data sources that provide cell-specific values."
            },
            new Sample
            {
                Name = "Empty Points",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/empty-points",
                FileName = "Emptypoints.razor",
                MetaTitle = "Blazor HeatMap Empty Points | Missing Data Handling | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Empty Points Handling",
                MetaDescription = "Blazor HeatMap Chart demo shows how to handle missing/empty data point with custom styling, allowing for clear visualization of incomplete datasets in your app."
            },
            new Sample 
            {
                Name = "Inversed Axis",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/inversed-axis",
                FileName = "InversedAxis.razor",
                MetaTitle = "Blazor HeatMap Inversed Axis | Reversed Direction | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Inversed Axis Configuration",
                MetaDescription = "This Blazor HeatMap Chart example shows inversed axis configuration, allowing visualization with reversed axis direction for specialized analytical views."
            },
            new Sample
            {
                Name = "Opposed Axis",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/opposed-axis",
                FileName = "OpposedAxis.razor",
                MetaTitle = "Blazor HeatMap Opposed Axis | Custom Positioning | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Opposed Axis Placement",
                MetaDescription = "Blazor HeatMap Chart demo shows opposed axis placement, allowing you to position axes on opposite sides for enhanced visualization, comparison of data patterns."
            },
            new Sample
            {
                Name = "Label Template",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/label-template",
                FileName = "LabelTemplate.razor",
                MetaTitle = "Blazor HeatMap Label Templates | Custom Formatting | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Label Template Customization",
                MetaDescription = "Blazor HeatMap Chart demo shows custom label templates for axis labels, data points, enabling rich format, conditional style, embedding HTML content in labels."
            }, 
             new Sample
            {
                Name = "Multi Level Labels",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/multi-level-labels",
                FileName = "MultiLevelLabels.razor",
                MetaTitle = "Blazor HeatMap Multi-Level Labels | Hierarchical Display | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Multi-Level Label Visualization",
                MetaDescription = "Blazor HeatMap Chart demo shows multi-level axis labels for displaying hierarchical categories, enabling complex data organization and easier interpretation.",
            },
             new Sample
            {
                Name = "Selection",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/cell-selection",
                FileName = "Selection.razor",
                MetaTitle = "Blazor HeatMap Selection | Interactive Cell Selection | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Cell Selection Capability",
                MetaDescription = "Blazor HeatMap Chart demo shows how to enable users to select individual cells/regions for detailed analysis, data export/triggering context-specific actions.",
            },
            new Sample
            {
                Name = "Legend Placement",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/legend-placement",
                FileName = "LegendPlacement.razor",
                MetaTitle = "Blazor HeatMap Legend Positioning | Layout Options | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Legend Placement Customization",
                MetaDescription = "Blazor HeatMap Chart demo shows different legend placement options, helping you optimally position the color scale for various layout needs and screen sizes."
            },
            new Sample
            {
                Name = "Palette Mode",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/palette-mode",
                FileName = "PaletteMode.razor",
                MetaTitle = "Blazor HeatMap Palette Modes | Color Schemes | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Color Palette Options",
                MetaDescription = "Blazor HeatMap Chart demo shows different palette modes and color schemes, enabling you to choose fixed/gradient color patterns that best represent your data."
            },
            new Sample
            {
                Name = "Color Range",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/color-range",
                Type = SampleType.None,
                FileName = "ColorRange.razor",
                MetaTitle = "Blazor HeatMap Color Range | Custom Color Scales | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Custom Color Range Definition",
                MetaDescription = "Blazor HeatMap Chart demo shows segment for custom color range configuration, enabling precise control over color distribution across various data value ranges."
            },
            new Sample
            {
                Name = "Tooltip Template",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/tooltip-template",
                FileName = "TooltipTemplate.razor",
                MetaTitle = "Blazor HeatMap Tooltip Templates | Interactive Data | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Custom Tooltip Templates",
                MetaDescription = "Blazor HeatMap Chart demo features custom tooltip templates, enables rich data previews, additional context, and embedded visualization when hovering over cell."
            }
        };    
    }
}
