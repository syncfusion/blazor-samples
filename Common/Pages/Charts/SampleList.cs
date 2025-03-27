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
        public List<Sample> Chart { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Charts",
                Directory = "Charts/Chart",
                Url = "chart/overview",
                FileName = "Overview.razor",
                HeaderText = "Blazor Chart Overview",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "chart/line",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Line Chart Example - Syncfusion Demos",
                MetaDescription = "The Blazor Line Chart example visualizes the consumer price data using line series. Explore here for more details.",
                HeaderText = "Blazor Line Chart Example",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Updated the line chart sample to display interactive tooltips that appear for the data points nearest to the mouse pointer." }               
            },
            // new Sample
            // {
            //     Name = "Line Customization",
            //     Category = "Line Charts",
            //     Directory = "Charts/Chart",
            //     Url = "chart/line-layout",
            //     FileName = "LineLayout.razor",
            //     MetaTitle = "Blazor Line Layout Chart Example - Syncfusion Demos",
            //     MetaDescription = "The Blazor Line Layout Chart example visualizes annual milk production and monthly traffic data using default line series. Explore customization options and interactive features here.",
            //     HeaderText = "Blazor Line Layout Chart Example",
            //     Type = SampleType.New
            // },
            new Sample
            {
                Name = "Spline",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "chart/spline",
                FileName = "Spline.razor",
                MetaTitle = "Blazor Spline Chart Example - Syncfusion Demos",
                MetaDescription = "This example demonstrates the default functionalities of Blazor Spline Chart. Explore here for more details.",
                HeaderText = "Blazor Spline Chart Example",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Updated the spline chart sample with an interactive feature that highlights the entire background of a data point when hovering." }
            },
            new Sample
            {
                Name = "Step Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "chart/step-line",
                FileName = "StepLine.razor",
                MetaTitle = "Blazor Step Line Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Step Line Chart Example",
                MetaDescription = "This example demonstrates the Blazor Step Line Chart component. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Dashed Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "chart/dashed-line",
                FileName = "DashedLine.razor",
                HeaderText = "Blazor Dashed Line Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Custom Animation",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "chart/custom-animation",
                FileName = "CustomAnimation.razor",
		        MetaTitle = "Blazor Custom Animation Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Custom Animation Chart Example.",
		        MetaDescription = "Blazor Custom Animation Chart example demonstrates how to render and configure a spline chart with custom animation effects, visualizing smooth data trends for almond yield across different countries.",
                Type = SampleType.New,
                NotificationDescription = new string[]{ @"Showcases a demo featuring a spline chart with multiple data series, incorporating smooth animations for enhanced visual representation. The chart includes a shared tooltip to improve user interaction, allowing for simultaneous data point comparisons across different series." }
            },
            new Sample
            {
                Name = "Inversed Spline",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "chart/inversed-spline",
                FileName = "InversedSpline.razor",
                HeaderText = "Blazor Inversed Spline Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Line Zone",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "chart/line-zone",
                FileName = "LineZone.razor",
                HeaderText = "Blazor Line Zone Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multi Colored Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "chart/multi-colored-line",
                FileName = "MultiColoredLine.razor",
                HeaderText = "Blazor Multi Colored Line Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stacked Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "chart/stacked-line",
                FileName = "StackedLine.razor",
                MetaTitle = "Blazor Stacked Line Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Stacked Line Chart Example",
                MetaDescription = "The Blazor Stacked Line Chart represents time-dependent data, showing trends in data at equal intervals with stacked values of multiple series.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "100% Stacked Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "chart/percent-stacked-line",
                FileName = "StackedLine100.razor",
                MetaTitle = "Blazor 100% Stacked Line Chart Example - Syncfusion Demos",
                HeaderText = "Blazor 100% Stacked Line Chart Example",
                MetaDescription = "Blazor 100% Stacked Line Chart example shows how to render and configure the 100% stacked line type chart.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/area",
                FileName = "Area.razor",
                MetaTitle = "Blazor Area Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Area Chart Example",
                MetaDescription = "Blazor Area Chart example demonstrates how to represent time-dependent data and to show the trends at equal intervals.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Spline Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/spline-area",
                FileName = "SplineArea.razor",
                MetaTitle = "Blazor Spline Area Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Spline Area Chart Example",
                MetaDescription = "This example demonstrates the Blazor Spline Area Chart component. Explore here for more details.",
                Type = SampleType.None
            }, 
            new Sample
            {
                Name = "Step Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/step-area",
                FileName = "StepArea.razor",
                MetaTitle = "Blazor Step Area Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Step Area Chart Example",
                MetaDescription = "This example demonstrates the Blazor Step Area Chart component. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Range Step Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/range-step-area",
                FileName = "RangeStepArea.razor",
                MetaTitle = "Blazor Range Step Area Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Range Step Area Chart Example",
                MetaDescription = "This example demonstrates the Blazor Range Step Area Chart component. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Range Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/range-area",
                FileName = "RangeArea.razor",
                MetaTitle = "Blazor Range Area Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Range Area Chart Example",
                MetaDescription = "This example demonstrates the Blazor Range Area Chart component. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Spline Range Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/spline-range-area",
                FileName = "SplineRangeArea.razor",
                MetaTitle = "Blazor Spline Range Area Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Spline Range Area Chart Example",
                MetaDescription = "This example demonstrates the Blazor Spline Range Area Chart component. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stacked Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/stacked-area",
                FileName = "StackedArea.razor",
                MetaTitle = "Blazor Stacked Area Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Stacked Area Chart Example",
                MetaDescription = "Blazor Stacked Area Chart example shows the relation between individual values and the total sum of the points.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "100% Stacked Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/percent-stacked-area",
                FileName = "StackedArea100.razor",
                MetaTitle = "Blazor 100% Stacked Area Chart Example - Syncfusion Demos",
                HeaderText = "Blazor 100% Stacked Area Chart Example",
                MetaDescription = "Blazor 100% Stacked Area Chart example shows how to render and configure the 100% stacking area type chart.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Area Empty Points",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/area-empty",
                FileName = "AreaEmpty.razor",
                HeaderText = "Blazor Area with Empty Points Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Area Negative Points",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/negative-area",
                FileName = "AreaNegat.razor",
                MetaTitle = "Blazor Area with Negative Points in Area Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Area with Negative Points in Area Chart Example",
                MetaDescription = "Blazor Area with Negative Points in Area Chart example shows how to render and configure the area with negative points area type chart.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Area Zone",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/area-zone",
                FileName = "AreaZone.razor",
                HeaderText = "Blazor Area Zone Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/column",
                FileName = "Column.razor",
                MetaTitle = "Blazor Column Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Column Chart Example",
                MetaDescription = "Blazor Column Chart example demonstrates how to compare frequency, count, total, or average of data in different categories with a vertical bar.",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Updated the column chart by enabling series highlighting on the tooltip." }              
            },
            new Sample
            {
                Name = "Grouped Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/grouped-column",
                FileName = "GroupedColumn.razor",
                HeaderText = "Blazor Grouped Column Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Column Rotated Labels",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/column-rotated-labels",
                FileName = "ColumnRotatedLabels.razor",
                MetaTitle = "Blazor Column Rotated Labels Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Column Rotated Labels Chart Example.",
                MetaDescription = "Blazor Column Rotated Labels Chart example demonstrates how to render and configure a column chart with rotated labels for analyzing the company's profits.",
                Type = SampleType.New,
                NotificationDescription = new string[]{ @"Presents a demo that showcases a column chart with distinct colors, rotated axis labels for improved readability, and data labels for enhanced clarity. The chart also includes tooltips for interactive data exploration." }
            },
            new Sample
            {
                Name = "Column Drilldown",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/column-drilldown",
                FileName = "ColumnDrilldown.razor",
                MetaTitle = "Blazor Column Drilldown Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Column Drilldown Chart Example.",
                MetaDescription ="Blazor Column Drilldown Chart example demonstrates how to render and configure drilldown charts for analyzing population data by continent and country interactively.",
                Type = SampleType.New,
                NotificationDescription = new string[]{ @"Showcases a column chart with a clickable event feature. Clicking on a column or its x-axis label triggers an interactive event, revealing related data for the specific category, offering deeper insights and an enhanced user experience." }
            },
            new Sample
            {
                Name = "Column Placement",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/column-placement",
                FileName = "ColumnPlacement.razor",
                HeaderText = "Blazor Column Placement Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Range Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/range-column",
                FileName = "RangeColumn.razor",
                MetaTitle = "Blazor Range Column Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Range Column Chart Example",
                MetaDescription = "This example demonstrates the Range Column in Blazor Charts component. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Inversed Range Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/inversed-range-column",
                FileName = "InversedRangeColumn.razor",
                HeaderText = "Blazor Inversed Range Column Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Bar",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/bar",
                FileName = "Bar.razor",
                MetaTitle = "Blazor Bar Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Bar Chart Example",
                MetaDescription = "Blazor Bar Chart example demonstrates how to compare frequency, count, total, or average of data in different categories with a horizontal bar.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Rounded Bar",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/rounded-bar",
                FileName = "RoundedBar.razor",
                HeaderText = "Blazor Rounded Bar Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stacked Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/stacked-column",
                FileName = "StackedColumn.razor",
                MetaTitle = "Blazor Stacked Column Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Stacked Column Chart Example",
                MetaDescription = "Blazor Stacked Column Chart example shows the relation between individual values and the total sum of the points.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "100% Stacked Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/percent-stacked-column",
                FileName = "StackedColumn100.razor",
                MetaTitle = "Blazor 100% Stacked Column Chart Example - Syncfusion Demos",
                HeaderText = "Blazor 100% Stacked Column Chart Example",
                MetaDescription = "Blazor 100% Stacked Column Chart example shows how to render and configure the 100% stacking column type chart.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stacked Bar",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/stacked-bar",
                FileName = "StackedBar.razor",
                MetaTitle = "Blazor Stacked Bar Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Stacked Bar Chart Example",
                MetaDescription = "Blazor Stacked Bar Chart visualizes sales comparison of different data with default stacked bar series.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "100% Stacked Bar",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/percent-stacked-bar",
                FileName = "StackedBar100.razor",
                MetaTitle = "Blazor 100% Stacked Bar Chart Example - Syncfusion Demos",
                HeaderText = "Blazor 100% Stacked Bar Chart Example",
                MetaDescription = "Blazor 100% Stacked Bar Chart example shows how to render and configure the 100% stacking bar type chart.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Column Stacked And Grouped",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/column-stacked-and-grouped",
                FileName = "ColumnStackedAndGrouped.razor",
                MetaTitle = "Blazor Column Stacked And Grouped Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Column Stacked And Grouped Chart Example",
                MetaDescription = "Blazor Column Stacked and Grouped Chart example demonstrates how to visualize coffee production data for Vietnam, India, Colombia, and Brazil interactively from 2021 to 2023 using tooltips and legends.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Column Negative Points",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/negative-column",
                FileName = "NegativeColumn.razor",
                MetaTitle = "Blazor Column with Negative Points in Bar Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Column with Negative Points Bar Chart Example",
                MetaDescription = "Blazor Column with Negative Points Bar Chart example shows how to render and configure the column with negative points bar type chart.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Negative Stack",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/negative-stack",
                FileName = "NegativeStack.razor",
                MetaTitle = "Blazor Negative Stacked Bar Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Negative Stacked Bar Chart Example",
                MetaDescription = "Blazor Negative Stacked Bar Chart example shows how to render and configure the negative stacking bar type chart.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Scatter Plot",
                Category = "Scatter and Bubble",
                Directory = "Charts/Chart",
                Url = "chart/scatter",
                FileName = "Scatter.razor",
                MetaTitle = "Blazor Scatter Plot Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Scatter Plot Chart Example",
                MetaDescription = "This example demonstrates the Blazor Scatter Plot Chart component. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Bubble",
                Category = "Scatter and Bubble",
                Directory = "Charts/Chart",
                Url = "chart/bubble",
                FileName = "Bubble.razor",
                MetaTitle = "Blazor Bubble Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Bubble Chart Example",
                MetaDescription = "This example demonstrates the Blazor Bubble Chart component. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pie",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/pie",
                FileName = "Pie.razor",
                MetaTitle = "Blazor Pie Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Pie Chart Example",
                MetaDescription = "This example demonstrates the Blazor Pie Chart component. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pie with Various Radius",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/pie-radius",
                FileName = "PieRadius.razor",
                HeaderText = "Blazor Pie with Various Radius Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Donut",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/donut",
                FileName = "Donut.razor",
                MetaTitle = "Blazor Donut Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Donut Chart Example",
                MetaDescription = "This example demonstrates the Blazor Donut Chart component. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pyramid",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/pyramid",
                FileName = "Pyramid.razor",
                MetaTitle = "Blazor Pyramid Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Pyramid Chart Example",
                MetaDescription = "This example demonstrates the Blazor Pyramid Chart component. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Funnel",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/funnel",
                FileName = "Funnel.razor",
                MetaTitle = "Blazor Funnel Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Funnel Chart Example",
                MetaDescription = "This example demonstrates the Blazor Funnel Chart component. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pie with Legend",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/pie-legend",
                FileName = "PieLegend.razor",
                HeaderText = "Blazor Pie with Legend Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Semi Pie",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/semi-pie",
                FileName = "SemiPie.razor",
                HeaderText = "Blazor Semi Pie Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Smart Labels",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/smart-labels",
                FileName = "SmartLabels.razor",
                HeaderText = "Blazor Pie with Smart Labels Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Drilldown",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/drilldown",
                FileName = "Drilldown.razor",
                HeaderText = "Blazor Pie with Drilldown Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Grouping",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/grouping",
                FileName = "Grouping.razor",
                HeaderText = "Blazor Pie with Grouping Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Empty Points",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/pie-empty-points",
                FileName = "EmptyPoints.razor",
                HeaderText = "Blazor Pie with Empty Points Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Waterfall",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/waterfall",
                FileName = "Waterfall.razor",
                HeaderText = "Blazor Waterfall Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Horizontal Waterfall",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/horizontal-waterfall",
                FileName = "HorizontalWaterfall.razor",
                MetaTitle = "Blazor Horizontal Waterfall Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Horizontal Waterfall Chart Example.",
                MetaDescription = "Blazor Horizontal Waterfall Chart example demonstrates how to render and configure a horizontal waterfall chart to visualize gradual changes in revenue or profit through increments and decrements.",
                Type = SampleType.New,
                NotificationDescription = new string[]{ @"Displays a horizontal waterfall chart to visualize revenue variations over time, with distinct colors representing increases, decreases, and total values. Data labels enhance readability, and interactive tooltips provide detailed insights when hovering over data points." }
            },
            new Sample
            {
                Name = "Histogram",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/histogram",
                FileName = "Histogram.razor",
                MetaTitle = "Blazor Histogram Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Histogram Chart Example",
                MetaDescription = "This example demonstrates the Blazor Histogram Chart component. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Box and Whisker",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/box-and-whisker",
                FileName = "BoxandWhisker.razor",
                MetaTitle = "Blazor Box and Whisker Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Box and Whisker Chart Example",
                MetaDescription = "This example demonstrates the Blazor Box and Whisker Chart component. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Error Bar",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/error-bar",
                FileName = "ErrorBar.razor",
                HeaderText = "Blazor Error Bar Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Trendlines",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/trendlines",
                FileName = "Trendlines.razor",
                HeaderText = "Blazor Trendlines Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multi Series Chart",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/multi-series-chart",
                FileName = "MultiSeriesChart.razor",
                HeaderText = "Blazor Multi Series Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pareto",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/pareto",
                FileName = "Pareto.razor",
                HeaderText = "Blazor Pareto Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Combo Chart",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/combo-chart",
                FileName = "ComboChart.razor",
                MetaTitle = "Blazor Combo Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Combo Chart Example.",
                MetaDescription = "Blazor chart example demonstrating how to render and configure a combo chart to visualize wages, benefits, and total compensation across worker sectors in September 2024, using column, line, and pie series for comparative analysis.",
                Type = SampleType.New,
                NotificationDescription = new string[]{ @"Introduces a combination chart featuring a doughnut chart alongside column and line series. This chart effectively represents data trends with annotations for clarity, while interactive tooltips enhance data exploration and understanding." }
            },
            new Sample
            {
                Name = "Hilo",
                Category = "Stock Charts",
                Directory = "Charts/Chart",
                Url = "chart/hilo",
                FileName = "Hilo.razor",
                MetaTitle = "Blazor Hilo Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Hilo Chart Example",
                MetaDescription = "This example demonstrates the Blazor Hilo Chart component. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Hilo Open Close",
                Category = "Stock Charts",
                Directory = "Charts/Chart",
                Url = "chart/hilo-open-close",
                FileName = "HiloOpenClose.razor",
                HeaderText = "Blazor Hilo Open Close Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Candle Stick",
                Category = "Stock Charts",
                Directory = "Charts/Chart",
                Url = "chart/candle-stick",
                FileName = "CandleStick.razor",
                HeaderText = "Blazor Candle Stick Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Accumulation Distributions",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "chart/accumulation-distribution-indicator",
                FileName = "ADIChart.razor",
                HeaderText = "Blazor Accumulation Distributions Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "ATR",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "chart/average-true-range-indicator",
                FileName = "ATRChart.razor",
                HeaderText = "Blazor ATR Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Bollinger",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "chart/bollinger",
                FileName = "BollingerChart.razor",
                HeaderText = "Blazor Bollinger Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "EMA",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "chart/exponential-moving-average-indicator",
                FileName = "EmaChart.razor",
                HeaderText = "Blazor EMA Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "MACD",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "chart/moving-average-convergence-divergence-indicator",
                FileName = "MacdChart.razor",
                HeaderText = "Blazor MACD Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Momentum",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "chart/momentum",
                FileName = "MomentumChart.razor",
                HeaderText = "Blazor Momentum Chart Example.",
            },
            new Sample
            {
                Name = "RSI",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "chart/relative-strength-index-indicator",
                FileName = "RsiChart.razor",
                HeaderText = "Blazor RSI Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "SMA",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "chart/simple-moving-average-indicator",
                FileName = "SmaChart.razor",
                HeaderText = "Blazor SMA Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stochastic",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "chart/stochastic",
                FileName = "StochasticChart.razor",
                HeaderText = "Blazor Stochastic Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "TMA",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "chart/triangular-moving-average-indicator",
                FileName = "TmaChart.razor",
                HeaderText = "Blazor TMA Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Line",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "chart/polar-line",
                FileName = "PolarLineChart.razor",
                MetaTitle = "Blazor Polar Radar Line Example - Syncfusion Demos",
                HeaderText = "Blazor Polar Radar Line Chart Example",
                MetaDescription = "This example demonstrates the Blazor Polar Radar Line Chart component. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Area",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "chart/polar-area",
                FileName = "PolarArea.razor",
                HeaderText = "Blazor Polar Radar Area Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stacked Area",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "chart/polar-stacked-area",
                FileName = "PolarStackedArea.razor",
                HeaderText = "Blazor Polar Radar Stacked Area Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Scatter",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "chart/polar-scatter",
                FileName = "PolarScatter.razor",
                HeaderText = "Blazor Polar Radar Scatter Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Column",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "chart/polar-column",
                FileName = "PolarColumn.razor",
                HeaderText = "Blazor Polar Radar Column Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Wind Rose",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "chart/polar-stacking-column",
                FileName = "Polar.razor",
                HeaderText = "Blazor Wind Rose Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Range Column",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "chart/polar-range-column",
                FileName = "PolarRangeColumn.razor",
                HeaderText = "Blazor Polar Radar Range Column Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Charts/Chart",
                Url = "chart/local-data",
                FileName = "LocalData.razor",
                HeaderText = "Blazor Chart with Local Data Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Charts/Chart",
                Url = "chart/remote-data",
                FileName = "RemoteData.razor",
                HeaderText = "Blazor Chart with Remote Data Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Live Chart",
                Category = "Live Chart",
                Directory = "Charts/Chart",
                Url = "chart/live-chart",
                FileName = "LiveChart.razor",
                HeaderText = "Blazor Live Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Numeric Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/numeric-axis",
                FileName = "NumericAxis.razor",
                HeaderText = "Blazor Chart with Numeric Axis Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "DateTime Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/date-time-axis",
                FileName = "DateTimeAxis.razor",
                HeaderText = "Blazor Chart with DateTime Axis Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "DateTime Category Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/date-time-category-axis",
                FileName = "DateTimeCategoryAxis.razor",
                HeaderText = "Blazor Chart with DateTime Category Axis Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Category Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/category-axis",
                FileName = "CategoryAxis.razor",
                HeaderText = "Blazor Chart with Category Axis Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Indexed Category Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/indexed-category-axis",
                FileName = "IndexedCategoryAxis.razor",
                HeaderText = "Blazor Chart with Indexed Category Axis Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Logarithmic Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/logarithmic-scale",
                FileName = "LogarithmicScale.razor",
                HeaderText = "Blazor Chart with Logarithmic Axis Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multiple Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/multiple-axis",
                FileName = "MultipleAxis.razor",
                HeaderText = "Blazor Chart with Multiple Axis Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Inversed Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/inversed-axis",
                FileName = "InversedAxis.razor",
                HeaderText = "Blazor Chart with Inversed Axis Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multiple Panes",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/multiple-panes",
                FileName = "MultiplePanes.razor",
                MetaTitle = "Blazor Multiple Panes Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Multiple Panes Chart Example.",
                MetaDescription = "Blazor chart example demonstrates how to render and configure a multiple panes chart for visualizing the annual weather in New York, comparing temperature and precipitation trends with multiple series.",
                Type = SampleType.New,
                NotificationDescription = new string[]{ @"Introduces a chart with multiple panes, featuring range area, spline, and column series. The spline series is combined with the range area to provide better clarity of low and high values, while the column series offers a clear visual comparison. Data labels have been added for improved readability and precise value representation." }
            },
            new Sample
            {
                Name = "StripLine",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/strip-line",
                FileName = "StripLine.razor",
                HeaderText = "Blazor Chart with StripLine Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "StripLine Recurrence",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/recurrence-strip-line",
                FileName = "StripLineRecurrence.razor",
                HeaderText = "Blazor Chart with StripLine Recurrence Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Smart Axis Labels",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/smart-axis-labels",
                FileName = "SmartAxisLabels.razor",
                HeaderText = "Blazor Chart with Smart Axis Labels Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multiple Level Labels",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/multiple-level",
                FileName = "MultiLevelLabel.razor",
                HeaderText = "Blazor Chart with Multiple Level Labels Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Axis Crossing",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/axis-crossing",
                FileName = "AxisCrossing.razor",
                HeaderText = "Blazor Chart with Axis Crossing Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Marker Chart",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "chart/marker-chart",
                FileName = "MarkerChart.razor",
                HeaderText = "Blazor Marker Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Synchronized Charts",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "chart/synchronized-charts",
                FileName = "SynchronizedCharts.razor",
                HeaderText = "Blazor Synchronized Charts Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "RTL",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "chart/rtl",
                FileName = "RTL.razor",
                HeaderText = "Blazor RTL Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Vertical Chart",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "chart/vertical-chart",
                FileName = "VerticalChart.razor",
                HeaderText = "Blazor Vertical Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Empty Point",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "chart/empty-point",
                FileName = "EmptyPoint.razor",
                HeaderText = "Blazor Empty Point Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Datalabel Template",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "chart/datalabel-template",
                FileName = "DataLabelTemplate.razor",
                HeaderText = "Blazor Chart with Datalabel Template Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Tooltip Template",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "chart/tooltip-template",
                FileName = "TooltipTemplate.razor",
                HeaderText = "Blazor Chart with Tooltip Template Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Sorting",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "chart/dataSorting",
                FileName = "DataSorting.razor",
                HeaderText = "DataSorting Chart Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Annotation",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "chart/annotation",
                FileName = "Annotation.razor",
                HeaderText = "Blazor Chart with Annotation Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Adaptive Layout",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "chart/adaptive-layout",
                FileName = "AdaptiveLayout.razor",
                HeaderText = "Blazor Chart with Adaptive Layout Example.",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"This sample showcases how to dynamically adjust a chart's design and element positions to seamlessly fit different screen sizes." }
            },
            new Sample
            {
                Name = "Print",
                Category = "Print and Export",
                Directory = "Charts/Chart",
                Url = "chart/print",
                FileName = "Print.razor",
                HeaderText = "Blazor Chart with Print Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Export",
                Category = "Print and Export",
                Directory = "Charts/Chart",
                Url = "chart/export",
                FileName = "Export.razor",
                HeaderText = "Blazor Chart with Export Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Selection",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "chart/selection",
                FileName = "Selection.razor",
                HeaderText = "Blazor Chart with Selection Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Range Selection",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "chart/range-selection",
                FileName = "RangeSelection.razor",
                HeaderText = "Blazor Chart with Range Selection Example.",
                Type = SampleType.None
            },
			new Sample
            {
                Name = "Keyboard Navigation",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "chart/keyboard",
                FileName = "KeyboardChart.razor",
                HeaderText = "Blazor Chart with Keyboard Navigation Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Crosshair",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "chart/crosshair",
                FileName = "Crosshair.razor",
                HeaderText = "Blazor Chart with Crosshair Example.",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Enhanced the demo to snap the crosshair to the nearest data point instead of tracking the exact cursor position, ensuring a more accurate and professional focus on the data." }
            },
            new Sample
            {
                Name = "Trackball",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "chart/trackball",
                FileName = "Trackball.razor",
                HeaderText = "Blazor Chart with Trackball Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Zooming and Panning",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "chart/zooming",
                FileName = "ZoomingandPanning.razor",
                HeaderText = "Blazor Chart with Zooming and Panning Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Dynamic Points",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "chart/add-a-point-on-click",
                FileName = "AddingPoint.razor",
                HeaderText = "Blazor Chart with Dynamic Points Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Data Editing",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "chart/data-editing",
                FileName = "DataEditing.razor",
                HeaderText = "Blazor Chart with Data Editing Example.",
                Type = SampleType.None
            }
        };

        public List<Sample> Chart3D { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Column",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/column",
                FileName = "Column3D.razor",
                HeaderText = "Blazor 3D Chart",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Back to Back Column",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/back-to-back-column",
                FileName = "BackToBackColumn3D.razor",
                HeaderText = "Blazor 3D Chart",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Cylindrical Column",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/cylinder",
                FileName = "CylindricalColumn3D.razor",
                HeaderText = "Blazor 3D Chart",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Bar",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/bar",
                FileName = "Bar3D.razor",
                HeaderText = "Blazor 3D Chart",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stacking Column with Grouping",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/stacked-column",
                FileName = "StackingColumnGrouping3D.razor",
                HeaderText = "Blazor 3D Chart",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "100% Stacked Column",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/stacked-column-100",
                FileName = "StackedColumn100.razor",
                HeaderText = "Blazor 3D Chart",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stacked Bar",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/stacked-bar",
                FileName = "StackedBar3D.razor",
                HeaderText = "Blazor 3D Chart",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "100% Stacked Bar",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/stacked-bar-100",
                FileName = "StackedBar100.razor",
                HeaderText = "Blazor 3D Chart",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Column with null and 0 values",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/empty-point",
                FileName = "ColumnNullValues3D.razor",
                HeaderText = "Blazor 3D Chart",
                Type = SampleType.None
            }
        };

        public List<Sample> RangeNavigator { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default",
                Category = "Range Selector",
                Directory = "Charts/RangeNavigator",
                Url = "range-selector/range-navigator",
                FileName = "RangeNavigator.razor",
                Type = SampleType.None
            },
			new Sample
			 {
			    Name = "Lightweight",
			    Category = "Range Selector",
			    Directory = "Charts/RangeNavigator",
			    Url = "range-selector/light-weight",
			    FileName = "LightWeight.razor",
			    Type = SampleType.None
			},
			  new Sample
			  {
                Name = "DateTime Axis",
                Category = "Axis",
                Directory = "Charts/RangeNavigator",
                Url = "range-selector/date-time-axis",
                FileName = "DateTimeAxis.razor",
                Type = SampleType.None
			 },
			  new Sample
			  {
                Name = "Numeric Axis",
                Category = "Axis",
                Directory = "Charts/RangeNavigator",
                Url = "range-selector/numeric-axis",
                FileName = "NumericAxis.razor",
                Type = SampleType.None
			 },
              new Sample
              {
                Name = "Logarithmic Axis",
                Category = "Axis",
                Directory = "Charts/RangeNavigator",
                Url = "range-selector/logarithmic",
                FileName = "Logarithmic.razor",
                Type = SampleType.None
             },
              new Sample
			 {
			    Name = "Multilevel Labels",
			    Category = "Axis",
			    Directory = "Charts/RangeNavigator",
			    Url = "range-selector/multilevel",
			    FileName = "Multilevel.razor",
			    Type = SampleType.None
			},
			   new Sample
			   {
			      Name = "Empty Points",
			      Category = "Customization",
			      Directory = "Charts/RangeNavigator",
			      Url = "range-selector/empty-point",
			      FileName = "EmptyPoint.razor",
			      Type = SampleType.None
			    },
			   new Sample
			   {
			      Name = "Filter",
			      Category = "Customization",
			      Directory = "Charts/RangeNavigator",
			      Url = "range-selector/filter",
			      FileName = "Filter.razor",
			      Type = SampleType.None
			  },
			   new Sample
			   {
			      Name = "Print and Export",
			      Category = "Export",
			      Directory = "Charts/RangeNavigator",
			      Url = "range-selector/print-export",
			      FileName = "PrintExport.razor",
			      Type = SampleType.None
			  },
			  new Sample
			  {
			     Name = "RTL",
			     Category = "Right To Left",
			     Directory = "Charts/RangeNavigator",
			     Url = "range-selector/rtl",
			     FileName = "RTL.razor",
			     Type = SampleType.None
			 }
		};

        public List<Sample> SparklineCharts { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Sparkline Charts",
                Directory = "Charts/Sparkline",
                Url = "sparkline/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None
            },
             new Sample
             {
                 Name = "Series Type",
                 Category = "Sparkline Charts",
                 Directory = "Charts/Sparkline",
                 Url = "sparkline/series-type",
                 FileName = "SeriesType.razor",                 
                 Type = SampleType.None
             },
             new Sample
            {
                Name = "Axis Value Types",
                Category = "Sparkline Charts",
                Directory = "Charts/Sparkline",
                Url = "sparkline/axis-types",
                FileName = "AxisTypes.razor",
                Type = SampleType.None
            },
             new Sample
             {
                 Name = "Sparkline in Grid",
                 Category = "Sparkline Charts",
                 Directory = "Charts/Sparkline",
                 Url = "sparkline/sparkline-grid",
                 FileName = "SparklineGrid.razor",
                 Type = SampleType.None
             },
                new Sample
              {
                  Name = "Customization",
                  Category = "Sparkline Charts",
                  Directory = "Charts/Sparkline",
                  Url = "sparkline/customization",
                  FileName = "Customization.razor",
                  Type = SampleType.None
              },
            //    new Sample
            //  {
            //      Name = "Live Update",
            //      Category = "Sparkline Charts",
            //      Directory = "Charts/Sparkline",
            //      Url = "sparkline/Liveupdate",
            //      FileName = "Liveupdate.razor",
            //      Type = SampleType.None
            //  },
              //new Sample
              //{
              //    Name = "Range Band",
              //    Category = "Sparkline Charts",
              //    Directory = "Charts/Sparkline",
              //    Url = "sparkline/range-band",
              //    FileName = "RangeBand.razor",
              //    Type = SampleType.None
              //}
        };

        public List<Sample> SmithChart { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default Functionalities",
                Category = "Smith Chart",
                Directory = "Charts/SmithChart",
                Url = "smith-chart/default-functionalities",
                FileName = "DefaultFunctionalities.razor",                
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Customization",
                Category = "Smith Chart",
                Directory = "Charts/SmithChart",
                Url = "smith-chart/customization",
                FileName = "Customization.razor",
                Type = SampleType.None
            },
            new Sample
            {
               Name = "Print and Export",
               Category = "Smith Chart",
               Directory = "Charts/SmithChart",
               Url = "smith-chart/print-and-export",
               FileName = "PrintAndExport.razor",
               Type = SampleType.None
            }
        };

        public List<Sample> StockChart { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "stock-chart/stock-chart",
                FileName = "Default.razor",
                HeaderText = "Blazor Stock Chart Example.",
                Type = SampleType.None
            },
           new Sample
            {
                Name = "OHLC",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "stock-chart/ohlc",
                FileName = "OHLC.razor",
                HeaderText = "Blazor Stock Chart with OHLC Example.",
                Type = SampleType.None
            },
           new Sample
            {
                Name = "Candlestick and Volume",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "stock-chart/candlestick-volume",
                FileName = "Candlestick and Volume.razor",
                HeaderText = "Blazor Stock Chart with Candlestick and Volume Example.",
                Type = SampleType.None
            },
           new Sample
            {
                Name = "Multiple Series",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "stock-chart/multiple-series",
                FileName = "Multiple Series.razor",
                HeaderText = "Blazor Stock Chart with Multiple Series Example.",
                Type = SampleType.None
            },
           new Sample
            {
                Name = "Spline",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "stock-chart/stock-chart-spline",
                FileName = "Spline.razor",
                HeaderText = "Blazor Stock Chart with Spline Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Area",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "stock-chart/stock-chart-area",
                FileName = "Area.razor",
                HeaderText = "Blazor Stock Chart with Area Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Spline Area",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "stock-chart/stock-chart-spline-area",
                FileName = "SplineArea.razor",
                HeaderText = "Blazor Stock Chart with Spline Area Example.",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Enhanced the demo to snap the crosshair to the nearest data point instead of tracking the exact cursor position, ensuring a more accurate and professional focus on the data." }
            },
            new Sample
            {
                Name = "Inversed Area",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "stock-chart/inversed-area",
                FileName = "Inversed Area.razor",
                HeaderText = "Blazor Stock Chart with Inversed Area Example.",
                Type = SampleType.None
            },
		    new Sample
		    {
		        Name = "Hide Period Selector",
		        Category = "Stock Chart",
		        Directory = "Charts/StockChart",
		        Url = "stock-chart/hide-period-selector",
		        FileName = "Hide Period Selector.razor",
                HeaderText = "Blazor Stock Chart with Hide Period Selector Example.",
                Type = SampleType.None
		    },
            new Sample
            {
                Name = "Hide Range Selector",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "stock-chart/hide-selector",
                FileName = "Hide Selector.razor",
                HeaderText = "Blazor Stock Chart with Hide Range Selector Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stock Events",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "stock-chart/stock-events",
                FileName = "StockEvents.razor",
                HeaderText = "Blazor Stock Chart with Stock Events Example.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "DateTime Category Axis",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "stock-chart/date-time-category-axis",
                FileName = "DateTimeCategoryAxis.razor",
                HeaderText = "Blazor Stock Chart with DateTime Category Axis Example.",
                Type = SampleType.None
            }
		};
		public List<Sample> BulletChart { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default Functionalities",
                Category = "Bullet Chart",
                Directory = "Charts/BulletChart",
                Url = "bullet-chart/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None
            },
           new Sample
            {
                Name = "Multiple Data",
                Category = "Bullet Chart",
                Directory = "Charts/BulletChart",
                Url = "bullet-chart/multiple-data",
                FileName = "MultipleData.razor",
                Type = SampleType.None
            },
           new Sample
            {
                Name = "RTL",
                Category = "Bullet Chart",
                Directory = "Charts/BulletChart",
                Url = "bullet-chart/right-to-left",
                FileName = "RightToLeft.razor",
                Type = SampleType.None
            },
           new Sample
            {
                Name = "Feature and Target Bar",
                Category = "Bullet Chart",
                Directory = "Charts/BulletChart",
                Url = "bullet-chart/bar-customization",
                FileName = "BarCustomization.razor",
                Type = SampleType.None
            },
           new Sample
            {
                Name = "Range and Label Settings",
                Category = "Bullet Chart",
                Directory = "Charts/BulletChart",
                Url = "bullet-chart/customization",
                FileName = "Customization.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Legend",
                Category = "Bullet Chart",
                Directory = "Charts/BulletChart",
                Url = "bullet-chart/legend",
                FileName = "Legend.razor"
            }
        };
        public List<Sample> Sankey { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default",
                Category = "Sankey",
                Directory = "Charts/Sankey",
                Url = "sankey/default",
                FileName = "DefaultSankeyChart.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Explore the basic features of a Sankey chart, including node and link customization, layout adjustment, and interactivity." }
            },
            new Sample
            {
                Name = "Vertical Mode",
                Category = "Sankey",
                Directory = "Charts/Sankey",
                Url = "sankey/vertical",
                FileName = "VerticalSankeySample.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Demonstrates the vertical layout of a Sankey chart, optimizing the arrangement of nodes and links for specific use cases." }
            },
            new Sample
            {
                Name = "RTL",
                Category = "Sankey",
                Directory = "Charts/Sankey",
                Url = "sankey/Rtl",
                FileName = "RTLSankeySample.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Showcases support for right-to-left (RTL) text and layout adaptation, ensuring compatibility with RTL languages." }
            },
            new Sample
            {
                Name = "Print & Export",
                Category = "Sankey",
                Directory = "Charts/Sankey",
                Url = "sankey/print-export",
                FileName = "PrintExport.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Illustrates print and export functionalities, enabling users to save charts as images or PDF for reporting purposes." }
            },
        };
    }

}
