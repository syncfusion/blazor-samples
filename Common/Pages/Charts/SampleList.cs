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
                MetaTitle = "Blazor Chart Overview | Interactive Features | Syncfusion",
                MetaDescription = "This Blazor Chart overview demo comprehensive charting capabilities with multiple chart types, interactive features, and custom options for data visualization.",
                Type = SampleType.None
            },
            #if SERVER
            new Sample
            {
                Name = "Stock Forecasting",
                Category = "Smart AI Solutions",
                Directory = "AISamples/Chart",
                Url = "chart/ai-stock-forecasting",
                FileName = "StockForecasting.razor",
                Type = SampleType.AI,
                MetaTitle = "Blazor Charts Stock Forecasting - Syncfusion AI Demos",
                HeaderText = "Blazor Charts Example - Stock Forecasting with AI",
                MetaDescription = "This demo shows context-aware searching using AI embeddings. Find related items based on meaning rather than exact keywords for more intuitive user experience.",
                NotificationDescription = new string[]{ @" This demo shows the Stock ForeCasting AI feature in Charts." }
            },
            new Sample
            {
                Name = "Data Preprocessing",
                Category = "Smart AI Solutions",
                Directory = "AISamples/Chart",
                Url = "chart/ai-data-preprocessing",
                FileName = "DataPreprocessing.razor",
                Type = SampleType.AI,
                MetaTitle = "Blazor Charts Data Preprocessing - Syncfusion AI Demos",
                HeaderText = "Blazor Charts Example - Data Preprocessing with AI",
                MetaDescription = "This demo shows context-aware searching using AI embeddings. Find related items based on meaning rather than exact keywords for more intuitive user experience.",
                NotificationDescription = new string[]{ @" This demo shows the data preprocessing AI feature in Charts." }
            },
            new Sample
            {
                Name = "Smart Chart",
                Category = "Smart AI Solutions",
                Directory = "AISamples/Chart",
                Url = "chart/ai-smart-chart",
                FileName = "SmartChart.razor",
                Type = SampleType.AI,
                MetaTitle = "Syncfusion blazor Charts Smart Charts - Syncfusion AI Demos",
                HeaderText = "Blazor Charts Example - Smart Charts with AI",
                MetaDescription = "This Blazor Smart Charts demo uses AI to dynamically render the relevant chart type from user prompts, enabling seamless, adaptive, intuitive data exploration.",
                NotificationDescription = new string[]{ @" This demo shows the Smart Charts AI feature in Charts." }
            },
#endif
            new Sample
            {
                Name = "Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "chart/line",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Line Chart Example | Line Chart | Syncfusion",
                MetaDescription = "The Blazor Line Chart example effectively visualizes the consumer price data with a line series, offering insights into trends. Explore here for more details.",
                HeaderText = "Blazor Line Chart Example",
                Type = SampleType.None,
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
                MetaTitle = "Blazor Spline Chart Example | Line Charts | Syncfusion",
                MetaDescription = "This example showcases the standard features of the Blazor Spline Chart, highlighting its default functionalities. Click here for more comprehensive details.",
                HeaderText = "Blazor Spline Chart Example",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Step Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "chart/step-line",
                FileName = "StepLine.razor",
                MetaTitle = "Blazor Step Line Chart Example | Line Charts | Syncfusion",
                HeaderText = "Blazor Step Line Chart Example",
                MetaDescription = "This example presents the Blazor Step Line Chart component, illustrating its features for effective data representation. Click here to explore further details.",
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
                MetaTitle = "Blazor Dashed Line Chart | Stylized Lines | Syncfusion",
                MetaDescription = "This Blazor Dashed Line Chart shows how to create stylized line charts with dashed patterns for enhanced visual distinction and professional data presentation.",
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
		        MetaDescription = "Blazor Custom Animation Chart shows a spline chart with custom animations, visualizing smooth almond yield trends across various countries for clear insights.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Inversed Spline",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "chart/inversed-spline",
                FileName = "InversedSpline.razor",
                HeaderText = "Blazor Inversed Spline Chart Example.",
                MetaTitle = "Blazor Inversed Spline Chart | Inverted Axis | Syncfusion",
                MetaDescription = "This Blazor Inversed Spline Chart shows spline visualization with inverted axis orientation for unique data presentation and enhanced analytical perspectives.",
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
                MetaTitle = "Blazor Line Zone Chart | Multi-Color Zones | Syncfusion",
                MetaDescription = "This Blazor Line Zone Chart demonstrates how to create line charts with different colored zones based on data values for enhanced visual data analysis.",
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
                MetaTitle = "Blazor Multi Colored Line | Dynamic Colors | Syncfusion",
                MetaDescription = "This Blazor Multi Colored Line Chart demonstrates how to apply different colors to line segments based on data values for enhanced visual data representation.",
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
                MetaDescription = "The Blazor Stacked Line Chart effectively visualizes time-dependent data, showing trends in data at equal intervals with stacked values of multiple series.",
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
                MetaDescription = "This Blazor 100% Stacked Line Chart example demonstrates how to render and configure the 100% stacked line type chart. Click here to explore further details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/area",
                FileName = "Area.razor",
                MetaTitle = "Blazor Area Chart Example | Area Charts | Syncfusion",
                HeaderText = "Blazor Area Chart Example",
                MetaDescription = "This Blazor Area Chart example demonstrates how to represent time-dependent data and to show the trends at equal intervals. Click here to explore more details.",
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
                MetaDescription = "The Blazor Spline Area Chart component, showcasing its powerful capabilities for detailed data visualization. Click here to delve deeper into its features.",
                Type = SampleType.None
            }, 
            new Sample
            {
                Name = "Step Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/step-area",
                FileName = "StepArea.razor",
                MetaTitle = "Blazor Step Area Chart Example | Area Charts | Syncfusion",
                HeaderText = "Blazor Step Area Chart Example",
                MetaDescription = "The Blazor Step Area Chart component, showcasing its powerful capabilities for detailed data visualization. Click here to delve deeper into its features.",
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
                MetaDescription = "The Blazor Range Step Area Chart component, showcasing its powerful capabilities for detailed data visualization. Click here to delve deeper into its features.",
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
                MetaDescription = "The Blazor Range Area Chart component, showcasing its powerful capabilities for detailed data visualization. Click here to delve into more extensive details.",
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
                MetaDescription = "The Blazor Spline Range Area Chart component, showcasing its powerful capabilities for detailed data visualization. Click here to explore more details.",
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
                MetaDescription = "This Blazor Stacked Area Chart example shows the relationship between individual values and their cumulative total, providing insights into data distribution.",
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
                MetaDescription = "This Blazor 100% Stacked Area Chart example demonstrates how to implement and customize a chart where areas are stacked to show percentage contribution.",
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
                MetaTitle = "Blazor Area Empty Points | Missing Data | Syncfusion",
                MetaDescription = "This Blazor Area Chart with Empty Points demonstrates how to handle missing data points in area charts with various empty point modes and customization options.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Area Negative Points",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/negative-area",
                FileName = "AreaNegat.razor",
                MetaTitle = "Area with Negative Points in Area Chart - Syncfusion Demos",
                HeaderText = "Blazor Area with Negative Points in Area Chart Example",
                MetaDescription = "This Blazor Area with Negative Points in Area Chart example demonstrates how to implement and configure the area with negative points area type chart.",
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
                MetaTitle = "Blazor Area Zone Chart | Multi-Color Areas | Syncfusion",
                MetaDescription = "This Blazor Area Zone Chart demonstrates how to create area charts with different colored zones based on data values for enhanced visual data analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/column",
                FileName = "Column.razor",
                MetaTitle = "Blazor Column Chart Example | Bar Charts | Syncfusion",
                HeaderText = "Blazor Column Chart Example",
                MetaDescription = "This Blazor Column Chart example demonstrates how to compare the frequency, count, total, or average of data in different categories with a vertical bar.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Grouped Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/grouped-column",
                FileName = "GroupedColumn.razor",
                HeaderText = "Blazor Grouped Column Chart Example.",
                MetaTitle = "Blazor Grouped Column Chart | Data Comparison | Syncfusion",
                MetaDescription = "This Blazor Grouped Column Chart demonstrates how to compare multiple data series side by side using grouped columns for effective data comparison and analysis.",
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
                Type = SampleType.None,
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
                MetaDescription ="This Blazor Column Drilldown Chart example demonstrates how to render drilldown charts for interactive analysis of population data by continent and country.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Column Placement",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/column-placement",
                FileName = "ColumnPlacement.razor",
                HeaderText = "Blazor Column Placement Chart Example.",
                MetaTitle = "Blazor Column Placement | Custom Positioning | Syncfusion",
                MetaDescription = "This Blazor Column Placement Chart demonstrates how to customize column positioning and spacing for optimal data visualization and improved chart readability.",
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
                MetaDescription = "This example shows the Range Column feature in Blazor Charts component, displaying data ranges with minimum and maximum values. Explore here for more details.",
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
                MetaTitle = "Blazor Inversed Range Column | Inverted Axis | Syncfusion",
                MetaDescription = "This Blazor Inversed Range Column Chart demonstrates range column visualization with inverted axis orientation for unique data presentation perspectives.",
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
                MetaDescription = "This Blazor Bar Chart example demonstrates how to compare frequency, count, total, or average of data in the different categories with a horizontal bar.",
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
                MetaTitle = "Blazor Rounded Bar Chart | Stylized Bars | Syncfusion",
                MetaDescription = "This Blazor Rounded Bar Chart demonstrates how to create horizontal bar charts with rounded corners for enhanced visual appeal and modern design aesthetics.",
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
                MetaDescription = "This Blazor Stacked Column Chart example illustrates how individual data values to the cumulative total, visually representing the part to whole relationships.",
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
                MetaDescription = "This Blazor 100% Stacked Column Chart example demonstrates how to create and configure the charts to visualize relative percentage contributions in a category.",
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
                MetaDescription = "This Blazor Stacked Bar Chart allows for visualizing sales comparisons across various datasets using default stacked bar series, highlighting differences.",
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
                MetaDescription = "This Blazor 100% Stacked Bar Chart example shows how to render and configure the 100% stacking bar type chart to depict data as proportional segments of a bar.",
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
                MetaDescription = "This Blazor Column Stacked and Grouped Chart visualizes coffee production data for Vietnam, India, Colombia, and Brazil (2021–2023) using tooltips, legends.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Column Negative Points",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/negative-column",
                FileName = "NegativeColumn.razor",
                MetaTitle = "Column with Negative Points in Bar Chart - Syncfusion Demos",
                HeaderText = "Blazor Column with Negative Points Bar Chart Example",
                MetaDescription = "Blazor Column with Negative Points Bar Chart example shows how to render and configure the column with negative points, visualizing both data gains and losses.",
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
                MetaDescription = "Blazor Negative Stacked Bar Chart demo shows how to render and configure the bar with negative points, helping to visualize contrasting data trends effectively.",
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
                MetaDescription = "This demo shows the Blazor Scatter Plot Chart component, showcasing its capabilities for displaying relationships between datasets using coordinates plotting.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Bubble",
                Category = "Scatter and Bubble",
                Directory = "Charts/Chart",
                Url = "chart/bubble",
                FileName = "Bubble.razor",
                MetaTitle = "Blazor Bubble Chart Example | Scatter and Bubble | Syncfusion",
                HeaderText = "Blazor Bubble Chart Example",
                MetaDescription = "This example shows the Blazor Bubble Chart component capabilities for visualizing multi-dimensional data with varying bubble sizes. Click here to more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pie",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/pie",
                FileName = "Pie.razor",
                MetaTitle = "Blazor Pie Chart Example | Accumulation Chart | Syncfusion",
                HeaderText = "Blazor Pie Chart Example",
                MetaDescription = "This example demonstrates the Blazor Pie Chart component, showcasing its capabilities for visualizing data of a circular graph. Explore here for more details.",
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
                MetaTitle = "Blazor Pie Various Radius | Custom Sizing | Syncfusion",
                MetaDescription = "This Blazor Pie Chart with Various Radius demonstrates how to create pie charts with different radius sizes for enhanced visual hierarchy and data emphasis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Donut",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/donut",
                FileName = "Donut.razor",
                MetaTitle = "Blazor Donut Chart Example | Accumulation Chart | Syncfusion",
                HeaderText = "Blazor Donut Chart Example",
                MetaDescription = "This example demonstrates the Blazor Donut Chart component, showcasing its circular visualization with a central hole for displaying proportional data.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Pyramid",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/pyramid",
                FileName = "Pyramid.razor",
                MetaTitle = "Blazor Pyramid Chart Example | Accumulation Chart | Syncfusion",
                HeaderText = "Blazor Pyramid Chart Example",
                MetaDescription = "This demo shows the Blazor Pyramid Chart component, illustrating triangular data visualization for hierarchical information. Click here to explore more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Funnel",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/funnel",
                FileName = "Funnel.razor",
                MetaTitle = "Blazor Funnel Chart Example | Accumulation Chart | Syncfusion",
                HeaderText = "Blazor Funnel Chart Example",
                MetaDescription = "This demo illustrates the Blazor Funnel Chart component, showcasing its capabilities for visualizing sequential data through progressively narrowing segments.",
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
                MetaTitle = "Blazor Pie Chart Legend | Interactive Labels | Syncfusion",
                MetaDescription = "This Blazor Pie Chart with Legend demonstrates how to display interactive legends with pie charts for enhanced data identification and user interaction.",
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
                MetaTitle = "Blazor Semi Pie Chart | Half Circle View | Syncfusion",
                MetaDescription = "This Blazor Semi Pie Chart demonstrates how to create half-circle pie charts for space-efficient data visualization with customizable start and end angles.",
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
                MetaTitle = "Blazor Smart Labels Pie | Auto Positioning | Syncfusion",
                MetaDescription = "This Blazor Pie Chart with Smart Labels demonstrates automatic label positioning to prevent the overlapping and ensure optimal readability in pie charts.",
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
                MetaTitle = "Blazor Pie Drilldown | Interactive Navigation | Syncfusion",
                MetaDescription = "This Blazor Pie Chart with Drilldown example demonstrates interactive navigation from summary to detailed data views. Click here to explore more details.",
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
                MetaTitle = "Blazor Pie Chart Grouping | Data Consolidation | Syncfusion",
                MetaDescription = "This Blazor Pie Chart with Grouping demonstrates how to group small data segments into a single slice for cleaner visualization and better readability.",
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
                MetaTitle = "Blazor Pie Empty Points | Missing Data | Syncfusion",
                MetaDescription = "This Blazor Pie Chart with Empty Points example demonstrates how to handle the missing or null data points in pie charts with various empty point modes.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Rounded Corners",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/pie-rounded-corners",
                FileName = "PieWithRoundedCorners.razor",
                HeaderText = "Blazor Pie with Rounded Corners Chart Example.",
                MetaTitle = "Blazor Pie Rounded Corners | Modern Design | Syncfusion",
                MetaDescription = "This Blazor Pie Chart with Rounded Corners example demonstrates how to create modern-looking pie charts with rounded slice edges for enhanced visual appeal.",
            },
            new Sample
            {
                Name = "Waterfall",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/waterfall",
                FileName = "Waterfall.razor",
                HeaderText = "Blazor Waterfall Chart Example.",
                MetaTitle = "Blazor Waterfall Chart | Cumulative Analysis | Syncfusion",
                MetaDescription = "This Blazor Waterfall Chart example demonstrates how to visualize cumulative effects of positive and negative values for financial and performance analysis.",
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
                MetaDescription = "This Blazor Horizontal Waterfall Chart demonstrates how to render a chart visualizing gradual changes in revenue or profit through increments and decrements.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Histogram",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/histogram",
                FileName = "Histogram.razor",
                MetaTitle = "Blazor Histogram Chart Example | Other Types | Syncfusion",
                HeaderText = "Blazor Histogram Chart Example",
                MetaDescription = "This demo shows the Blazor Histogram Chart component, illustrating distribution patterns through rectangular bars representing data frequency within intervals.",
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
                MetaDescription = "This example illustrates the Blazor Box and Whisker Chart component, displaying statistical data distribution with quartiles, medians. Explore details here.",
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
                MetaTitle = "Blazor Error Bar Chart | Statistical Analysis | Syncfusion",
                MetaDescription = "This Blazor Error Bar Chart demo shows how to display statistical uncertainty and variability in data measurements for scientific and analytical visualization.",
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
                MetaTitle = "Blazor Trendlines Chart | Data Trends | Syncfusion",
                MetaDescription = "This Blazor Trendlines Chart example demonstrates how to add trend analysis with linear, exponential, and polynomial trendlines for predictive data insights.",
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
                MetaTitle = "Blazor Multi Series Chart | Multiple Data Sets | Syncfusion",
                MetaDescription = "This Blazor Multi Series Chart demonstrates how to visualize multiple data series with different chart types for comprehensive data comparison and analysis.",
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
                MetaTitle = "Blazor Pareto Chart Example | 80-20 Analysis | Syncfusion",
                MetaDescription = "This Blazor Pareto Chart demonstrates the 80-20 principle visualization combining column and line charts for quality control and decision-making analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Combo Chart",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/combo-chart",
                FileName = "ComboChart.razor",
                MetaTitle = "Blazor Combo Chart Example | Other Types | Syncfusion",
                HeaderText = "Blazor Combo Chart Example.",
                MetaDescription = "Blazor chart shows combo chart visualizing wages, benefits, and total compensation across worker sectors in Sept 2024 using column, line, and pie series.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Hilo",
                Category = "Stock Charts",
                Directory = "Charts/Chart",
                Url = "chart/hilo",
                FileName = "Hilo.razor",
                MetaTitle = "Blazor Hilo Chart Example | Stock Chart | Syncfusion",
                HeaderText = "Blazor Hilo Chart Example",
                MetaDescription = "This example shows Blazor Hilo Chart component for visualizing financial data with high-low price movements and market trends. Explore here for more details.",
                NotificationDescription = new string[]{ @" This sample highlights how the last data label in the chart is emphasized, making it easier to identify the final value in the chart series." },
                Type = SampleType.Updated
            },
            new Sample
            {
                Name = "Hilo Open Close",
                Category = "Stock Charts",
                Directory = "Charts/Chart",
                Url = "chart/hilo-open-close",
                FileName = "HiloOpenClose.razor",
                HeaderText = "Blazor Hilo Open Close Chart Example.",
                MetaTitle = "Blazor Hilo Open Close | Stock Analysis | Syncfusion",
                MetaDescription = "This Blazor Hilo Open Close Chart demonstrates stock price visualization with high, low, open, and close values for comprehensive financial market analysis.",
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
                MetaTitle = "Blazor Candlestick Chart | Trading Analysis | Syncfusion",
                MetaDescription = "This Blazor Candlestick Chart example demonstrates traditional stock market visualization with OHLC data for technical analysis and trading decision support.",
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
                MetaTitle = "Blazor ADI Indicator | Volume Analysis | Syncfusion",
                MetaDescription = "This Blazor Accumulation Distribution Indicator example demonstrates volume-price analysis for identifying buying and selling pressure in financial markets.",
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
                MetaTitle = "Blazor ATR Indicator | Volatility Analysis | Syncfusion",
                MetaDescription = "This Blazor Average True Range (ATR) indicator example demonstrates market volatility measurement for risk assessment and trading strategy development.",
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
                MetaTitle = "Blazor Bollinger Bands | Price Volatility | Syncfusion",
                MetaDescription = "This Blazor Bollinger Bands indicator example demonstrates the price volatility and overbought or oversold the conditions for technical trading analysis.",
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
                MetaTitle = "Blazor EMA Indicator | Trend Analysis | Syncfusion",
                MetaDescription = "This Blazor Exponential Moving Average (EMA) indicator example demonstrates the trend identification and signal generation for technical market analysis.",
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
                MetaTitle = "Blazor MACD Indicator | Momentum Analysis | Syncfusion",
                MetaDescription = "This Blazor MACD indicator demonstrates momentum analysis and trend changes for technical trading signals and market timing decisions. Explore details here.",
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
                MetaTitle = "Blazor Momentum Indicator | Price Velocity | Syncfusion",
                MetaDescription = "This Blazor Momentum indicator example demonstrates price velocity measurement for identifying trend strength and potential reversal points in trading.",
            },
            new Sample
            {
                Name = "RSI",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "chart/relative-strength-index-indicator",
                FileName = "RsiChart.razor",
                HeaderText = "Blazor RSI Chart Example.",
                MetaTitle = "Blazor RSI Indicator | Overbought Oversold | Syncfusion",
                MetaDescription = "This Blazor Relative Strength Index (RSI) indicator example demonstrates the overbought and oversold conditions for market timing and reversal analysis.",
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
                MetaTitle = "Blazor SMA Indicator | Trend Smoothing | Syncfusion",
                MetaDescription = "This Blazor Simple Moving Average (SMA) indicator example demonstrates the trend smoothing and direction identification for technical market analysis.",
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
                MetaTitle = "Blazor Stochastic Indicator | Momentum Oscillator | Syncfusion",
                MetaDescription = "This Blazor Stochastic indicator example demonstrates momentum oscillation for identifying overbought/oversold conditions and potential trend reversals.",
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
                MetaTitle = "Blazor TMA Indicator Example | Smooth Trends | Syncfusion",
                MetaDescription = "This Blazor Triangular Moving Average (TMA) indicator example demonstrates the double-smoothed trend analysis for reduced the noise and clearer signals.",
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
                MetaDescription = "This Blazor Polar Radar Line Chart example demonstrates how to render and configure polar and radar charts with a line series. Explore here for more details.",
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
                MetaTitle = "Blazor Polar Area Chart | Circular Visualization | Syncfusion",
                MetaDescription = "This Blazor Polar Area Chart example demonstrates the circular data visualization with area series for multi-dimensional data analysis and comparison.",
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
                MetaTitle = "Blazor Polar Stacked Area | Multi-Series | Syncfusion",
                MetaDescription = "This Blazor Polar Stacked Area Chart example demonstrates the multi-series circular visualization with stacked areas for comprehensive data comparison.",
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
                MetaTitle = "Blazor Polar Scatter Chart | Circular Points | Syncfusion",
                MetaDescription = "This Blazor Polar Scatter Chart example demonstrates the circular scatter plot visualization for analyzing data distribution in polar coordinate systems.",
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
                MetaTitle = "Blazor Polar Column Chart | Radial Bars | Syncfusion",
                MetaDescription = "This Blazor Polar Column Chart example demonstrates the radial column visualization for circular data representations with enhanced the visual impact.",
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
                MetaTitle = "Blazor Wind Rose Chart | Weather Analysis | Syncfusion",
                MetaDescription = "This Blazor Wind Rose Chart example demonstrates the meteorological data visualization for wind direction and speed analysis using polar stacking columns.",
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
                MetaTitle = "Blazor Polar Range Column | Radial Ranges | Syncfusion",
                MetaDescription = "This Blazor Polar Range Column Chart example demonstrates the radial range visualization for displaying data intervals in circular coordinate systems.",
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
                MetaTitle = "Blazor Chart Local Data | Data Binding | Syncfusion",
                MetaDescription = "This Blazor Chart with Local Data example demonstrates how to bind the charts to local data sources for dynamic visualization and real-time data updates.",
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
                MetaTitle = "Blazor Chart Remote Data | API Integration | Syncfusion",
                MetaDescription = "This Blazor Chart with Remote Data demonstrates how to bind charts to remote data sources and APIs for dynamic data visualization. Explore here to more details.",
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
                MetaTitle = "Blazor Live Chart | Real-Time Updates | Syncfusion",
                MetaDescription = "This Blazor Live Chart example demonstrates the real-time data visualization with automatic updates for monitoring live data streams and dynamic content.",
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
                MetaTitle = "Blazor Numeric Axis Chart | Number Scaling | Syncfusion",
                MetaDescription = "This Blazor Chart with Numeric Axis demo shows numerical data scaling and formatting for precise quantitative data visualization. Explore here to more details.",
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
                MetaTitle = "Blazor DateTime Axis Chart | Time Series | Syncfusion",
                MetaDescription = "This Blazor Chart with DateTime Axis example demonstrates time-series data visualization with automatic date formatting and intelligent label placement.",
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
                MetaTitle = "Blazor DateTime Category Axis | Time Categories | Syncfusion",
                MetaDescription = "This Blazor Chart with DateTime Category Axis demonstrates categorical time-based data visualization with grouped date intervals. Explore here to more details.",
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
                MetaTitle = "Blazor Category Axis Chart | Categorical Data | Syncfusion",
                MetaDescription = "This Blazor Chart with Category Axis example demonstrates the categorical data visualization with the string-based labels for qualitative data analysis.",
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
                MetaTitle = "Blazor Indexed Category Axis | Sequential Data | Syncfusion",
                MetaDescription = "This Blazor Chart with Indexed Category Axis demonstrates sequential categorical data visualization with indexed positioning. Explore here to more details.",
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
                MetaTitle = "Blazor Logarithmic Axis Example | Log Scale | Syncfusion",
                MetaDescription = "This Blazor Chart with Logarithmic Axis example demonstrates logarithmic scaling for visualizing data with wide value ranges and exponential growth patterns.",
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
                MetaTitle = "Blazor Multiple Axis Chart | Multi-Scale | Syncfusion",
                MetaDescription = "This Blazor Chart with Multiple Axis demonstrates multi-scale data visualization with different units and ranges on separate axes. Explore here to more details.",
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
                MetaTitle = "Blazor Inversed Axis Chart | Flipped Scale | Syncfusion",
                MetaDescription = "This Blazor Chart with Inversed Axis example demonstrates inverted axis orientation for alternative data perspectives and specialized visualization needs.",
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
                MetaDescription = "This Blazor chart example demonstrates how to create a multi-pane chart visualizing New York's annual weather, comparing temperature and precipitation trends.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "StripLine",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/strip-line",
                FileName = "StripLine.razor",
                HeaderText = "Blazor Chart with StripLine Example.",
                MetaTitle = "Blazor StripLine Chart | Reference Lines | Syncfusion",
                MetaDescription = "This Blazor Chart with StripLine example demonstrates how to add reference lines and zones for highlighting specific values and ranges in data visualization.",
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
                MetaTitle = "Blazor StripLine Recurrence | Recurring Zones | Syncfusion",
                MetaDescription = "This Blazor Chart with StripLine Recurrence demo shows recurring reference zones for periodic data patterns and cyclical analysis. Explore here to more details.",
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
                MetaTitle = "Blazor Smart Axis Labels | Auto Formatting | Syncfusion",
                MetaDescription = "This Blazor Chart with Smart Axis Labels example demonstrates intelligent label formatting and positioning to prevent overlapping and improve readability.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Axis Label Template",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/axis-label-template",
                FileName = "AxisLabelTemplate.razor",
                HeaderText = "Blazor Chart with Axis Label Template Example.",
                MetaTitle = "Blazor Axis Label Template | Customization  | Syncfusion",
                MetaDescription = "Customize axis labels in Blazor Charts using templates that support emojis, styled text, and advanced formatting for clearer, more engaging data visuals.",
                NotificationDescription = new string[]{ @" This sample demonstrates the axis label template in Charts, allowing custom HTML elements like images, emojis, and styled text to be used as axis labels." },
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Multiple Level Labels",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/multiple-level",
                FileName = "MultiLevelLabel.razor",
                HeaderText = "Blazor Chart with Multiple Level Labels Example.",
                MetaTitle = "Blazor Multi-Level Labels | Hierarchical Axes | Syncfusion",
                MetaDescription = "This Blazor Chart with Multiple Level Labels example demonstrates the hierarchical axis labeling for complex categorical data organization and grouping.",
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
                MetaTitle = "Blazor Axis Crossing Chart | Custom Origin | Syncfusion",
                MetaDescription = "This Blazor Chart with Axis Crossing example demonstrates the custom axis intersection points for specialized data visualization and origin positioning.",
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
                MetaTitle = "Blazor Marker Chart Example | Data Points | Syncfusion",
                MetaDescription = "This Blazor Marker Chart example demonstrates customizable data point markers for enhanced data point identification and visual emphasis in line charts.",
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
                MetaTitle = "Blazor Synchronized Charts | Linked Views | Syncfusion",
                MetaDescription = "This Blazor Synchronized Charts example demonstrates the linked chart interactions for coordinated data exploration across multiple chart visualizations.",
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
                MetaTitle = "Blazor RTL Chart Example | Right-to-Left | Syncfusion",
                MetaDescription = "This Blazor RTL Chart example demonstrates right-to-left layout support for Arabic, Hebrew, and other RTL languages with proper text and chart orientation.",
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
                MetaTitle = "Blazor Vertical Chart | Rotated Layout | Syncfusion",
                MetaDescription = "This Blazor Vertical Chart example demonstrates the rotated chart orientation for alternative data presentation and space-efficient visualization layouts.",
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
                MetaTitle = "Blazor Empty Point Chart | Missing Data | Syncfusion",
                MetaDescription = "This Blazor Empty Point Chart shows handling missing data points with various empty point modes for robust data visualization. Explore here to more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "No Data Template",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "chart/no-data-template",
                FileName = "NoDataTemplate.razor",
                HeaderText = "Blazor No Data Template Chart Example.",
                MetaTitle = "Blazor No Data Template Chart | Missing Data | Syncfusion",
                MetaDescription = "This Blazor No Data Template Chart shows how to handle an empty chart by displaying a custom HTML template with an error message. Explore more details here.",
                Type = SampleType.New,
                NotificationDescription = new string[]{ @"This sample demonstrates how to handle an empty chart by displaying a custom message and image using the No Data Template." }
            },
            new Sample
            {
                Name = "Datalabel Template",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "chart/datalabel-template",
                FileName = "DataLabelTemplate.razor",
                HeaderText = "Blazor Chart with Datalabel Template Example.",
                MetaTitle = "Blazor DataLabel Template | Custom Labels | Syncfusion",
                MetaDescription = "This Blazor Chart with DataLabel Template example demonstrates the custom data label formatting and styling for enhanced data point information display.",
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
                MetaTitle = "Blazor Tooltip Template | Custom Tooltips | Syncfusion",
                MetaDescription = "This Blazor Chart with Tooltip Template demonstrates custom tooltip design and content for enhanced interactive data exploration. Explore to more details.",
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
                MetaTitle = "Blazor Data Sorting Chart | Ordered Data | Syncfusion",
                MetaDescription = "This Blazor Data Sorting Chart example demonstrates the automatic data sorting capabilities for organized data presentation and improved data analysis.",
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
                MetaTitle = "Blazor Chart Annotation | Custom Overlays | Syncfusion",
                MetaDescription = "This Blazor Chart with Annotation demonstrates custom text, shapes, and image overlays for enhanced data storytelling and insights. Explore to more details.",
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
                MetaTitle = "Blazor Adaptive Layout Chart | Responsive Design | Syncfusion",
                MetaDescription = "This Blazor Chart with Adaptive Layout example demonstrates the responsive design that automatically adjusts to different screen sizes and orientations.",
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
                MetaTitle = "Blazor Chart Print Example | Document Output | Syncfusion",
                MetaDescription = "This Blazor Chart with Print demonstrates printing capabilities for generating hard copies of charts for reports and documentation. Explore to more details.",
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
                MetaTitle = "Blazor Chart Export | Multiple Formats | Syncfusion",
                MetaDescription = "This Blazor Chart with Export example demonstrates the exporting charts to various formats including PNG, JPEG, SVG, and PDF for sharing and reporting.",
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
                MetaTitle = "Blazor Chart Selection | Interactive Data | Syncfusion",
                MetaDescription = "This Blazor Chart with Selection demonstrates interactive data point and series selection for detailed data exploration and analysis. Explore to more details.",
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
                MetaTitle = "Blazor Range Selection Chart | Data Filtering | Syncfusion",
                MetaDescription = "This Blazor Chart with Range Selection example demonstrates the interactive data range selection for focused analysis and data filtering capabilities.",
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
                MetaTitle = "Blazor Keyboard Navigation | Accessibility | Syncfusion",
                MetaDescription = "This Blazor Chart with Keyboard Navigation demonstrates accessibility features with keyboard controls for inclusive data visualization and interaction.",
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
                MetaTitle = "Blazor Crosshair Chart | Precise Tracking | Syncfusion",
                MetaDescription = "This Blazor Chart with Crosshair demonstrates precise data point tracking with crosshair lines for accurate value reading and analysis. Explore to more details.",
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
                MetaTitle = "Blazor Trackball Chart | Multi-Series Tracking | Syncfusion",
                MetaDescription = "This Blazor Chart with Trackball shows multi-series data tracking with synchronized tooltips for comprehensive data point analysis. Explore to more details.",
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
                MetaTitle = "Blazor Zoom Pan Chart | Interactive Navigation | Syncfusion",
                MetaDescription = "This Blazor Chart with Zooming and Panning example demonstrates interactive chart navigation for detailed data exploration and analysis of large datasets.",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"In this sample, the position of the zooming toolbar has been customized using the ChartZoomToolbarPosition property, and the scrollbar is customized to be placed at the bottom of the chart using the Position property of ChartAxisScrollbarSettings." }
            },
            new Sample
            {
                Name = "Dynamic Points",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "chart/add-a-point-on-click",
                FileName = "AddingPoint.razor",
                HeaderText = "Blazor Chart with Dynamic Points Example.",
                MetaTitle = "Blazor Dynamic Points Chart | Interactive Data | Syncfusion",
                MetaDescription = "This Blazor Chart with Dynamic Points example demonstrates real-time data point addition and modification for interactive data visualization and editing.",
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
                MetaTitle = "Blazor Data Editing Chart | Interactive Editing | Syncfusion",
                MetaDescription = "This Blazor Chart with Data Editing shows interactive data point editing capabilities for real-time data modification and analysis. Explore to more details.",
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
                MetaTitle = "Blazor 3D Column Chart | 3D Visualization | Syncfusion",
                MetaDescription = "This Blazor 3D Column Chart example demonstrates the three-dimensional column visualization for enhanced depth perception and engaging data presentation.",
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
                MetaTitle = "Blazor 3D Back-to-Back Column | Comparison | Syncfusion",
                MetaDescription = "This Blazor 3D Back-to-Back Column Chart example demonstrates comparative data visualization with opposing column arrangements for effective data comparison.",
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
                MetaTitle = "Blazor 3D Cylindrical Column | Custom Shapes | Syncfusion",
                MetaDescription = "This Blazor 3D Cylindrical Column Chart demonstrates custom cylindrical shapes for unique and visually appealing data representation. Explore to more details.",
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
                MetaTitle = "Blazor 3D Bar Chart | Horizontal 3D Bars | Syncfusion",
                MetaDescription = "This Blazor 3D Bar Chart example demonstrates three-dimensional horizontal bar visualization for enhanced depth and visual impact in data presentation.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stacking Column with Grouping",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/stacked-column",
                FileName = "StackingColumnGrouping3D.razor",
                MetaTitle = "3D Chart Stacking Column with Grouping -Syncfusion Demos",
                HeaderText = "Blazor 3D Chart",
                MetaDescription = "This Blazor 3D Stacking Column with Grouping example demonstrates complex data relationships with grouped and stacked 3D columns for comprehensive analysis.",
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
                MetaTitle = "Blazor 3D 100% Stacked Column | Proportional View | Syncfusion",
                MetaDescription = "This Blazor 3D 100% Stacked Column Chart demonstrates proportional data visualization with three-dimensional stacked columns showing percentage distribution.",
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
                MetaTitle = "Blazor 3D Stacked Bar | Horizontal Stacking | Syncfusion",
                MetaDescription = "This Blazor 3D Stacked Bar Chart example demonstrates the horizontal stacked data visualization with three-dimensional depth for enhanced visual impact.",
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
                MetaTitle = "Blazor 3D 100% Stacked Bar | Proportional Bars | Syncfusion",
                MetaDescription = "This Blazor 3D 100% Stacked Bar Chart demonstrates proportional horizontal bar visualization with three-dimensional perspective for percentage analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Column with null and 0 values",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/empty-point",
                FileName = "ColumnNullValues3D.razor",
                MetaTitle = "3D Chart Column with null and 0 values - Syncfusion Demos",
                HeaderText = "Blazor 3D Chart",
                MetaDescription = "This Blazor 3D Column Chart with null and 0 values demonstrates handling missing data points in three-dimensional visualization with various empty point modes.",
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
                MetaTitle = "Blazor Range Navigator | Data Selection | Syncfusion",
                HeaderText = "Blazor Range Navigator Example",
                MetaDescription = "This Blazor Range Navigator example demonstrates interactive data range selection for filtering and zooming large datasets with intuitive slider controls.",
                Type = SampleType.None
            },
			new Sample
			 {
			    Name = "Lightweight",
			    Category = "Range Selector",
			    Directory = "Charts/RangeNavigator",
			    Url = "range-selector/light-weight",
			    FileName = "LightWeight.razor",
			    MetaTitle = "Blazor Lightweight Range Navigator | Performance | Syncfusion",
			    HeaderText = "Blazor Lightweight Range Navigator Example",
			    MetaDescription = "This Blazor Lightweight Range Navigator example demonstrates the optimized performance for large datasets with minimal resource usage and fast rendering.",
			    Type = SampleType.None
			},
			  new Sample
			  {
                Name = "DateTime Axis",
                Category = "Axis",
                Directory = "Charts/RangeNavigator",
                Url = "range-selector/date-time-axis",
                FileName = "DateTimeAxis.razor",
                MetaTitle = "Blazor Range Navigator DateTime | Time Selection | Syncfusion",
                HeaderText = "Blazor Range Navigator DateTime Axis Example",
                MetaDescription = "This Blazor Range Navigator with DateTime Axis demonstrates time-based data selection with intelligent date formatting and navigation. Explore to more details.",
                Type = SampleType.None
			 },
			  new Sample
			  {
                Name = "Numeric Axis",
                Category = "Axis",
                Directory = "Charts/RangeNavigator",
                Url = "range-selector/numeric-axis",
                FileName = "NumericAxis.razor",
                MetaTitle = "Blazor Range Navigator Numeric | Number Selection | Syncfusion",
                HeaderText = "Blazor Range Navigator Numeric Axis Example",
                MetaDescription = "This Blazor Range Navigator with Numeric Axis demonstrates numerical data range selection with precise value-based filtering. Explore to more details.",
                Type = SampleType.None
			 },
              new Sample
              {
                Name = "Logarithmic Axis",
                Category = "Axis",
                Directory = "Charts/RangeNavigator",
                Url = "range-selector/logarithmic",
                FileName = "Logarithmic.razor",
                MetaTitle = "Blazor Range Navigator Logarithmic | Log Scale | Syncfusion",
                HeaderText = "Blazor Range Navigator Logarithmic Axis Example",
                MetaDescription = "This Blazor Range Navigator with Logarithmic Axis example demonstrates logarithmic scale data selection for wide-range datasets with exponential values.",
                Type = SampleType.None
             },
              new Sample
			 {
			    Name = "Multilevel Labels",
			    Category = "Axis",
			    Directory = "Charts/RangeNavigator",
			    Url = "range-selector/multilevel",
			    FileName = "Multilevel.razor",
			    MetaTitle = "Blazor Range Navigator Multilevel | Hierarchical Labels | Syncfusion",
			    HeaderText = "Blazor Range Navigator Multilevel Labels Example",
			    MetaDescription = "This Blazor Range Navigator with Multilevel Labels demonstrates hierarchical axis labeling for complex categorical data organization. Explore to more details.",
			    Type = SampleType.None
			},
			   new Sample
			   {
			      Name = "Empty Points",
			      Category = "Customization",
			      Directory = "Charts/RangeNavigator",
			      Url = "range-selector/empty-point",
			      FileName = "EmptyPoint.razor",
			      MetaTitle = "Blazor Range Navigator Empty Points | Missing Data | Syncfusion",
			      HeaderText = "Blazor Range Navigator Empty Points Example",
			      MetaDescription = "This Blazor Range Navigator with Empty Points shows handling missing data points in range selection with various empty point modes. Explore to more details.",
			      Type = SampleType.None
			    },
			   new Sample
			   {
			      Name = "Filter",
			      Category = "Customization",
			      Directory = "Charts/RangeNavigator",
			      Url = "range-selector/filter",
			      FileName = "Filter.razor",
			      MetaTitle = "Blazor Range Navigator Filter | Data Filtering | Syncfusion",
			      HeaderText = "Blazor Range Navigator Filter Example",
			      MetaDescription = "This Blazor Range Navigator Filter shows advanced data filtering capabilities with range-based selection for focused data analysis. Explore to more details.",
			      Type = SampleType.None
			  },
			   new Sample
			   {
			      Name = "Print and Export",
			      Category = "Export",
			      Directory = "Charts/RangeNavigator",
			      Url = "range-selector/print-export",
			      FileName = "PrintExport.razor",
			      MetaTitle = "Blazor Range Navigator Export | Document Output | Syncfusion",
			      HeaderText = "Blazor Range Navigator Print and Export Example",
			      MetaDescription = "This Blazor Range Navigator example demonstrates printing and exporting capabilities for generating reports and sharing range selection visualizations.",
			      Type = SampleType.None
			  },
			  new Sample
			  {
			     Name = "RTL",
			     Category = "Right To Left",
			     Directory = "Charts/RangeNavigator",
			     Url = "range-selector/rtl",
			     FileName = "RTL.razor",
			     MetaTitle = "Blazor Range Navigator RTL | Right-to-Left | Syncfusion",
			     HeaderText = "Blazor Range Navigator RTL Example",
			     MetaDescription = "This Blazor Range Navigator RTL example demonstrates right-to-left layout support for Arabic, Hebrew, and other RTL languages with proper orientation.",
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
                MetaTitle = "Blazor Sparkline Charts Default Example - Syncfusion Demos",
                HeaderText = "Blazor Sparkline Charts Default Functionalities Example",
                MetaDescription = "This Blazor Sparkline Charts default example demonstrates compact data visualization with line, area, column, and win-loss chart types for trend analysis.",
                Type = SampleType.None
            },
             new Sample
             {
                 Name = "Series Type",
                 Category = "Sparkline Charts",
                 Directory = "Charts/Sparkline",
                 Url = "sparkline/series-type",
                 FileName = "SeriesType.razor",
                 MetaTitle = "Blazor Sparkline Series Types | Multiple Charts | Syncfusion",
                 HeaderText = "Blazor Sparkline Series Type Example",
                 MetaDescription = "This Blazor Sparkline Series Type example demonstrates different chart types including line, area, column, and win-loss for compact data visualization.",
                 Type = SampleType.None
             },
             new Sample
            {
                Name = "Axis Value Types",
                Category = "Sparkline Charts",
                Directory = "Charts/Sparkline",
                Url = "sparkline/axis-types",
                FileName = "AxisTypes.razor",
                MetaTitle = "Blazor Sparkline Axis Types | Data Scaling | Syncfusion",
                HeaderText = "Blazor Sparkline Axis Value Types Example",
                MetaDescription = "This Blazor Sparkline Axis Types example demonstrates different axis value types including numeric, datetime, and category for flexible data representation.",
                Type = SampleType.None
            },
             new Sample
             {
                 Name = "Sparkline in Grid",
                 Category = "Sparkline Charts",
                 Directory = "Charts/Sparkline",
                 Url = "sparkline/sparkline-grid",
                 FileName = "SparklineGrid.razor",
                 MetaTitle = "Blazor Sparkline in Grid | Tabular Charts | Syncfusion",
                 HeaderText = "Blazor Sparkline in Grid Example",
                 MetaDescription = "This Blazor Sparkline in Grid example demonstrates the embedding compact charts within data grids for enhanced tabular data visualization and analysis.",
                 Type = SampleType.None
             },
                new Sample
              {
                  Name = "Customization",
                  Category = "Sparkline Charts",
                  Directory = "Charts/Sparkline",
                  Url = "sparkline/customization",
                  FileName = "Customization.razor",
                  MetaTitle = "Blazor Sparkline Customization | Styling Options | Syncfusion",
                  HeaderText = "Blazor Sparkline Customization Example",
                  MetaDescription = "This Blazor Sparkline Customization example demonstrates styling options including colors, markers, and data labels for personalized chart appearance.",
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
                MetaTitle = "Blazor Smith Chart Default | RF Analysis | Syncfusion",
                HeaderText = "Blazor Smith Chart Default Functionalities Example",
                MetaDescription = "This Blazor Smith Chart default example demonstrates RF impedance analysis and transmission line calculations for electrical engineering applications.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Customization",
                Category = "Smith Chart",
                Directory = "Charts/SmithChart",
                Url = "smith-chart/customization",
                FileName = "Customization.razor",
                MetaTitle = "Blazor Smith Chart Customization | RF Styling | Syncfusion",
                HeaderText = "Blazor Smith Chart Customization Example",
                MetaDescription = "This Blazor Smith Chart Customization example demonstrates styling options and visual enhancements for professional RF impedance analysis presentations.",
                Type = SampleType.None
            },
            new Sample
            {
               Name = "Print and Export",
               Category = "Smith Chart",
               Directory = "Charts/SmithChart",
               Url = "smith-chart/print-and-export",
               FileName = "PrintAndExport.razor",
               MetaTitle = "Blazor Smith Chart Export | RF Documentation | Syncfusion",
               HeaderText = "Blazor Smith Chart Print and Export Example",
               MetaDescription = "This Blazor Smith Chart shows printing and exporting capabilities for generating RF analysis reports and technical documentation. Explore to more details.",
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
                MetaTitle = "Blazor Stock Chart Default | Financial Analysis | Syncfusion",
                MetaDescription = "This Blazor Stock Chart demonstrates comprehensive financial data visualization with the candlestick patterns, volume analysis, and technical indicators.",
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
                MetaTitle = "Blazor OHLC Stock Chart | Price Analysis | Syncfusion",
                MetaDescription = "This Blazor OHLC Stock Chart example demonstrates open, high, low, close price visualization for detailed financial market analysis and trading insights.",
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
                MetaTitle = "Blazor Candlestick Volume | Trading Analysis | Syncfusion",
                MetaDescription = "This Blazor Candlestick and Volume Chart shows combined price and volume analysis for comprehensive stock market trading insights. Explore to more details.",
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
                MetaTitle = "Blazor Multi-Series Stock Chart | Comparison | Syncfusion",
                MetaDescription = "This Blazor Multiple Series Stock Chart example demonstrates comparative analysis of multiple stocks with synchronized time navigation and indicators.",
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
                MetaTitle = "Blazor Spline Stock Chart | Smooth Trends | Syncfusion",
                MetaDescription = "This Blazor Spline Stock Chart example demonstrates the smooth trend visualization for financial data with curved line interpolation and trend analysis.",
                NotificationDescription = new string[]{ @" This sample highlights how the last data label in the stock chart series is emphasized, making it easier for users to identify and interpret the final value." },
                Type = SampleType.Updated
            },
            new Sample
            {
                Name = "Area",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "stock-chart/stock-chart-area",
                FileName = "Area.razor",
                HeaderText = "Blazor Stock Chart with Area Example.",
                MetaTitle = "Blazor Area Stock Chart | Filled Trends | Syncfusion",
                MetaDescription = "This Blazor Area Stock Chart demonstrates filled area visualization for financial trends with enhanced visual impact and data emphasis. Explore to more details.",
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
                MetaTitle = "Blazor Spline Area Stock Chart | Smooth Areas | Syncfusion",
                MetaDescription = "This Blazor Spline Area Stock Chart example demonstrates smooth filled area visualization for financial data with curved interpolation and trend emphasis.",
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
                MetaTitle = "Blazor Inversed Area Stock Chart | Inverted View | Syncfusion",
                MetaDescription = "This Blazor Inversed Area Stock Chart demo shows inverted area visualization for alternative financial data perspectives and analysis. Explore to more details.",
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
                MetaTitle = "Blazor Stock Chart Hide Period | Custom Navigation | Syncfusion",
                MetaDescription = "This Blazor Stock Chart with Hidden Period Selector example demonstrates custom navigation controls for streamlined financial data visualization interface.",
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
                MetaTitle = "Blazor Stock Chart Hide Range | Simplified View | Syncfusion",
                MetaDescription = "This Blazor Stock Chart with Hidden Range Selector example demonstrates simplified interface for focused financial data analysis without range navigation.",
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
                MetaTitle = "Blazor Stock Events Chart | Market Events | Syncfusion",
                MetaDescription = "This Blazor Stock Chart with Events example demonstrates the market event annotations for correlating price movements with significant financial events.",
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
                MetaTitle = "Blazor Stock DateTime Category | Time Grouping | Syncfusion",
                MetaDescription = "This Blazor Stock Chart with DateTime Category Axis example demonstrates time-based data grouping for financial analysis with categorical time intervals.",
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
                MetaTitle = "Bullet Chart Range Label Settings Example - Syncfusion Demos",
                HeaderText = "Blazor Bullet Chart Default Functionalities Example",
                MetaDescription = "This Blazor Bullet Chart default example demonstrates the performance measurement visualization with target comparison and qualitative range indicators.",
                Type = SampleType.None
            },
           new Sample
            {
                Name = "Multiple Data",
                Category = "Bullet Chart",
                Directory = "Charts/BulletChart",
                Url = "bullet-chart/multiple-data",
                FileName = "MultipleData.razor",
                MetaTitle = "Blazor Bullet Chart Multiple Data | Performance KPIs | Syncfusion",
                HeaderText = "Blazor Bullet Chart Multiple Data Example",
                MetaDescription = "This Blazor Bullet Chart with Multiple Data example demonstrates comparative performance analysis across multiple KPIs and metrics in a compact format.",
                Type = SampleType.None
            },
           new Sample
            {
                Name = "RTL",
                Category = "Bullet Chart",
                Directory = "Charts/BulletChart",
                Url = "bullet-chart/right-to-left",
                FileName = "RightToLeft.razor",
                MetaTitle = "Blazor Bullet Chart RTL | Right-to-Left | Syncfusion",
                HeaderText = "Blazor Bullet Chart RTL Example",
                MetaDescription = "This Blazor Bullet Chart RTL example demonstrates the right-to-left layout support for Arabic, Hebrew, and other RTL languages with proper orientation.",
                Type = SampleType.None
            },
           new Sample
            {
                Name = "Feature and Target Bar",
                Category = "Bullet Chart",
                Directory = "Charts/BulletChart",
                Url = "bullet-chart/bar-customization",
                FileName = "BarCustomization.razor",
                MetaTitle = "Blazor Bullet Chart Bar Customization | Visual Styling | Syncfusion",
                HeaderText = "Blazor Bullet Chart Feature and Target Bar Example",
                MetaDescription = "This Blazor Bullet Chart demonstrates feature and target bar customization for enhanced visual distinction in performance measurement. Explore to more details.",
                Type = SampleType.None
            },
           new Sample
            {
                Name = "Range and Label Settings",
                Category = "Bullet Chart",
                Directory = "Charts/BulletChart",
                Url = "bullet-chart/customization",
                FileName = "Customization.razor",
                MetaTitle = "Blazor Bullet Chart Customization | Range Settings | Syncfusion",
                HeaderText = "Blazor Bullet Chart Range and Label Settings Example",
                MetaDescription = "This Blazor Bullet Chart demo shows range and label customization for personalized performance measurement visualization and branding. Explore to more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Legend",
                Category = "Bullet Chart",
                Directory = "Charts/BulletChart",
                Url = "bullet-chart/legend",
                FileName = "Legend.razor",
                MetaTitle = "Blazor Bullet Chart Legend | Performance Guide | Syncfusion",
                HeaderText = "Blazor Bullet Chart Legend Example",
                MetaDescription = "This Blazor Bullet Chart with Legend example demonstrates the performance measurement guidance with interactive legends for enhanced data interpretation."
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
                MetaTitle = "Blazor Sankey Chart Default | Flow Visualization | Syncfusion",
                HeaderText = "Blazor Sankey Chart Default Example",
                MetaDescription = "This Blazor Sankey Chart example demonstrates the flow visualization with node and link customization for analyzing data flow patterns and relationships.",
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
                MetaTitle = "Blazor Sankey Vertical Mode | Vertical Flow | Syncfusion",
                HeaderText = "Blazor Sankey Chart Vertical Mode Example",
                MetaDescription = "This Blazor Sankey Chart in Vertical Mode shows top-to-bottom flow visualization for hierarchical data analysis and process mapping. Explore to more details.",
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
                MetaTitle = "Blazor Sankey RTL | Right-to-Left Flow | Syncfusion",
                HeaderText = "Blazor Sankey Chart RTL Example",
                MetaDescription = "This Blazor Sankey Chart RTL demonstrates right-to-left flow visualization with proper text and layout adaptation for RTL languages. Explore to more details.",
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
                MetaTitle = "Blazor Sankey Export | Flow Documentation | Syncfusion",
                HeaderText = "Blazor Sankey Chart Print & Export Example",
                MetaDescription = "This Blazor Sankey Chart example demonstrates printing and export capabilities for generating flow analysis reports and documentation in multiple formats.",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Illustrates print and export functionalities, enabling users to save charts as images or PDF for reporting purposes." }
            },
        };
    }

}