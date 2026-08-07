using System.Collections.Generic;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        private static readonly string[] NotificationDescChartLine = new[] { @"This sample demonstrates the newly introduced Series Label feature, which displays labels directly for each series in the chart. This improves data identification and enhances overall chart readability." };
        private static readonly string[] NotificationDescStepAreaNoRiser = new[] { @"Explore trends using a step area chart without risers, where data transitions smoothly between points. Assess variations over time with continuous step segments, and hover to view precise values in tooltips." };

        public List<Sample> Chart { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Charts",
                Directory = "Charts/Chart",
                Url = "chart/overview",
                FileName = "Overview.razor",
                HeaderText = "Blazor Chart Overview",
                MetaTitle = "Blazor Charts Examples - Overview | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Overview Chart renders interactive visualizations with chart types, tooltips, legends, zooming, and events for clear insights.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-charts"
            },
            #if SERVER
            new Sample
            {
                Name = "Stock Forecasting",
                Category = "Smart AI Solutions",
                Directory = "AISamples/Charts",
                Url = "chart/ai-stock-forecasting",
                FileName = "StockForecasting.razor",
                Type = SampleType.AI,
                MetaTitle = "Blazor Charts Demos - Stock Forecasting Examples | Syncfusion",
                HeaderText = "Blazor Charts - AI Powered Stock Forecasting Example",
                MetaDescription = "See how the Syncfusion Blazor Stock Forecasting Chart predicts trends using algorithms with API, tooltips, and events for better financial planning insights.",
            },
            new Sample
            {
                Name = "Data Preprocessing",
                Category = "Smart AI Solutions",
                Directory = "AISamples/Charts",
                Url = "chart/ai-data-preprocessing",
                FileName = "DataPreprocessing.razor",
                Type = SampleType.AI,
                MetaTitle = "Blazor Charts  - Data Preprocessing | Charts Demos | Syncfusion",
                HeaderText = "Blazor Charts - AI Powered Data Preprocessing Example",
                MetaDescription = "See how the Syncfusion Blazor Data Preprocessing Chart cleans and transforms data using API, filtering, and events to create accurate datasets for analysis.",
            },
            new Sample
            {
                Name = "Smart Chart",
                Category = "Smart AI Solutions",
                Directory = "AISamples/Charts",
                Url = "chart/ai-smart-chart",
                FileName = "SmartChart.razor",
                Type = SampleType.AI,
                MetaTitle = "Blazor Charts Examples - Smart Chart | Charts Demos | Syncfusion",
                HeaderText = "Blazor Charts - AI Powered Data Visualization Example",
                MetaDescription = "See how the Syncfusion Blazor Smart Chart uses AI to select the best chart type with API, data binding, and events for faster insights and clear visualization.",
            },
#endif
            new Sample
            {
                Name = "Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "chart/line",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Line Charts Examples - Line | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Line Chart renders time-series data with tooltips, markers, and events to support clear trend analysis in dashboards and reports.",
                HeaderText = "Blazor Line Chart Example",
                NotificationDescription = NotificationDescChartLine,
                Type = SampleType.Updated,
            },
            // new Sample
            // {
            //     Name = "Line Customization",
            //     Category = "Line Charts",
            //     Directory = "Charts/Chart",
            //     Url = "chart/line-layout",
            //     FileName = "LineLayout.razor",
            //     MetaTitle = "Blazor Chart Example - Line Customization | Charts Demos | Syncfusion",
            //     MetaDescription = "See how the Syncfusion Blazor Line Customization Chart example visualizes milk production and traffic data with interactive features and customization.",
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
                MetaTitle = "Blazor Line Charts Examples - Spline | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Spline Chart renders smooth curved lines with API, tooltips, and events for elegant visualization and clear trend analysis.",
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
                MetaTitle = "Blazor Line Charts Examples - Step Line | Charts Demos | Syncfusion",
                HeaderText = "Blazor Step Line Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Step Line Chart visualizes step-based data with API, tooltips, and events to compare categorical changes and transitions clearly.",
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
                MetaTitle = "Blazor Line Charts Examples - Dashed Line | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Dashed Line Chart renders styled dashed lines using API, tooltips, and events to compare multiple data series with clarity.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Custom Animation",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "chart/custom-animation",
                FileName = "CustomAnimation.razor",
		        MetaTitle = "Blazor Charts Examples - Custom Animation | Charts Demos | Syncfusion",
                HeaderText = "Blazor Custom Animation Chart Example.",
		        MetaDescription = "See how the Syncfusion Blazor Custom Animation Chart applies smooth transitions with API, tooltips, and events to create engaging and interactive data displays.",
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
                MetaTitle = "Blazor Charts Examples - Inversed Spline | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Inversed Spline Chart renders data with inverted axes using API, tooltips, and events for alternate views and trend analysis.",
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
                MetaTitle = "Blazor Charts Examples - Line Zone | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Line Zone Chart highlights regions using colored zones with API, tooltips, and events for clear trend and threshold analysis.",
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
                MetaTitle = "Blazor Charts - Multi Colored Line | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Multi Colored Line Chart applies segment colors with API, tooltips, and events for dynamic visualization and pattern analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stacked Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "chart/stacked-line",
                FileName = "StackedLine.razor",
                MetaTitle = "Blazor Charts Examples - Stacked Line | Charts Demos | Syncfusion",
                HeaderText = "Blazor Stacked Line Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Stacked Line Chart shows cumulative trends using API, tooltips, and events for comparing part-to-whole relationships clearly.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "100% Stacked Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "chart/percent-stacked-line",
                FileName = "StackedLine100.razor",
                MetaTitle = "Blazor Charts Demos - 100% Stacked Line Examples | Syncfusion",
                HeaderText = "Blazor 100% Stacked Line Chart Example",
                MetaDescription = "See how the Syncfusion Blazor 100% Stacked Line Chart example demonstrates rendering and configuring stacked series with percentage-based visualization.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/area",
                FileName = "Area.razor",
                MetaTitle = "Blazor Charts Demos - Area Examples | Charts Demos | Syncfusion",
                HeaderText = "Blazor Area Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Area Chart example demonstrates time-based trends and data visualization across different intervals with interactive features.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Spline Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/spline-area",
                FileName = "SplineArea.razor",
                MetaTitle = "Blazor Charts Examples - Spline Area | Charts Demos | Syncfusion",
                HeaderText = "Blazor Spline Area Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Spline Area Chart renders smooth curved fills with API, tooltips, and events for elegant trend visualization and analysis.",
                Type = SampleType.None
            }, 
            new Sample
            {
                Name = "Step Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/step-area",
                FileName = "StepArea.razor",
                MetaTitle = "Blazor Charts Examples - Step Area | Charts Demos | Syncfusion",
                HeaderText = "Blazor Step Area Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Step Area Chart displays stepped area fills with API, tooltips, and events for clear category comparison and threshold analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Step Without Riser",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/steparea-without-riser",
                FileName = "StepAreaNoRisers.razor",
                MetaTitle = "Blazor Step Area Without Riser Chart Example - Syncfusion Demos",
                HeaderText = "Blazor Step Area Without Riser Chart Example",
                MetaDescription = "Explore the Blazor Step Area chart without risers, featuring smooth transitions and clear trend visualization for accurate and effective time-series insights.",
                NotificationDescription = NotificationDescStepAreaNoRiser,
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Range Step Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/range-step-area",
                FileName = "RangeStepArea.razor",
                MetaTitle = "Blazor Charts Examples - Range Step Area | Charts Demos | Syncfusion",
                HeaderText = "Blazor Range Step Area Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Range Step Area Chart shows stepped ranges with API, tooltips, and events for effective min-max comparison and trend analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Range Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/range-area",
                FileName = "RangeArea.razor",
                MetaTitle = "Blazor Charts Examples - Range Area | Charts Demos | Syncfusion",
                HeaderText = "Blazor Range Area Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Range Area Chart displays high-low values with API, tooltips, and events to visualize variability and trends across data clearly.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Spline Range Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/spline-range-area",
                FileName = "SplineRangeArea.razor",
                MetaTitle = "Blazor Charts Demos - Spline Range Area Examples | Syncfusion",
                HeaderText = "Blazor Spline Range Area Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Spline Range Area Chart renders smooth range areas with API, tooltips, and events for advanced visualization and insights.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stacked Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/stacked-area",
                FileName = "StackedArea.razor",
                MetaTitle = "Blazor Charts Examples - Stacked Area | Charts Demos | Syncfusion",
                HeaderText = "Blazor Stacked Area Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Stacked Area Chart shows cumulative trends using API, tooltips, and events for comparing series contributions effectively.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "100% Stacked Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/percent-stacked-area",
                FileName = "StackedArea100.razor",
                MetaTitle = "Blazor Charts Demos - 100% Stacked Area Examples | Syncfusion",
                HeaderText = "Blazor 100% Stacked Area Chart Example",
                MetaDescription = "See how the Syncfusion Blazor 100% Stacked Area Chart shows percentage contributions with API, tooltips, and events for normalized comparison across categories.",
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
                MetaTitle = "Blazor Charts Demos - Area Empty Points Examples | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Area Chart handles empty points using API modes, tooltips, and events to ensure consistent and reliable data visualization.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Area Negative Points",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "chart/negative-area",
                FileName = "AreaNegat.razor",
                MetaTitle = "Blazor Charts - Area Negative Points | Charts Demos | Syncfusion",
                HeaderText = "Blazor Area with Negative Points in Area Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Area Negative Points Chart handles negative values with API, tooltips, and events for accurate financial and statistical analysis.",
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
                MetaTitle = "Blazor Charts Examples - Area Zone | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Area Zone Chart segments data into colored zones using API, tooltips, and events for threshold-based analysis and alerts.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/column",
                FileName = "Column.razor",
                MetaTitle = "Blazor Charts Demos - Column Examples | Charts Demos | Syncfusion",
                HeaderText = "Blazor Column Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Column Chart displays vertical bars using API, tooltips, and events for clear category comparison and data analysis insights.",
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
                MetaTitle = "Blazor Charts Examples - Grouped Column | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Grouped Column Chart displays multiple series side by side with API, tooltips, and events for direct comparison and analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Column Rotated Labels",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/column-rotated-labels",
                FileName = "ColumnRotatedLabels.razor",
                MetaTitle = "Blazor Charts - Column Rotated Labels | Charts Demos | Syncfusion",
                HeaderText = "Blazor Column Rotated Labels Chart Example.",
                MetaDescription = "See how the Syncfusion Blazor Column Rotated Labels Chart uses axis label rotation with API, tooltips, and events for better readability of long categories.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "ColumnRotatedLabels.razor", Id = "ColumnRotatedLabels" },
                    new SourceCollection { FileName = "PointColor.cs", Id = "PointColor" }
                }
            },
            new Sample
            {
                Name = "Column Drilldown",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/column-drilldown",
                FileName = "ColumnDrilldown.razor",
                MetaTitle = "Blazor Charts Examples - Column Drilldown | Charts Demos | Syncfusion",
                HeaderText = "Blazor Column Drilldown Chart Example.",
                MetaDescription = "See how the Syncfusion Blazor Column Drilldown Chart enables drilldown navigation with API, tooltips, and events for exploring detailed data from summary views.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "ColumnDrilldown.razor", Id = "ColumnDrilldown" },
                    new SourceCollection { FileName = "PointColor.cs", Id = "PointColor" }
                }
            },
            new Sample
            {
                Name = "Column Placement",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/column-placement",
                FileName = "ColumnPlacement.razor",
                HeaderText = "Blazor Column Placement Chart Example.",
                MetaTitle = "Blazor Charts Examples - Column Placement | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Column Placement Chart customizes spacing and positioning with API, tooltips, and events for better readability and layout design.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Range Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/range-column",
                FileName = "RangeColumn.razor",
                MetaTitle = "Blazor Charts Examples - Range Column | Charts Demos | Syncfusion",
                HeaderText = "Blazor Range Column Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Range Column Chart visualizes min-max ranges with API, tooltips, and events for clear statistical comparison and spread analysis.",
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
                MetaTitle = "Blazor Charts - Inversed Range Column | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Inversed Range Column Chart renders inverted ranges with API, tooltips, and events for alternate data perspective and analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Bar",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/bar",
                FileName = "Bar.razor",
                MetaTitle = "Blazor Charts Demos - Bar Examples | Charts Demos | Syncfusion",
                HeaderText = "Blazor Bar Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Bar Chart compares horizontal category data using API, tooltips, and events for clear ranking, distribution, and analysis.",
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
                MetaTitle = "Blazor Charts Examples - Rounded Bar | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Rounded Bar Chart displays smooth corner bars with API, tooltips, and events for modern design and improved data readability.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Bar with Gradient",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/bar-with-gradient",
                FileName = "BarWithGradient.razor",
                HeaderText = "Blazor Bar Chart with Gradient Example.",
                MetaTitle = "Blazor Charts Demos - Bar with Gradient Examples | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Bar with Gradient Chart uses color gradients with API, tooltips, and events for visually engaging data comparison and emphasis.",
            },
            new Sample
            {
                Name = "Stacked Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/stacked-column",
                FileName = "StackedColumn.razor",
                MetaTitle = "Blazor Charts Examples - Stacked Column | Charts Demos | Syncfusion",
                HeaderText = "Blazor Stacked Column Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Stacked Column Chart visualizes part-to-whole data using API, tooltips, and events for cumulative comparison across categories.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "100% Stacked Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/percent-stacked-column",
                FileName = "StackedColumn100.razor",
                MetaTitle = "Blazor Charts - 100% Stacked Column | Charts Demos | Syncfusion",
                HeaderText = "Blazor 100% Stacked Column Chart Example",
                MetaDescription = "See how the Syncfusion Blazor 100% Stacked Column Chart shows percentage contributions using API, tooltips, and events for normalized category comparison.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stacked Bar",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/stacked-bar",
                FileName = "StackedBar.razor",
                MetaTitle = "Blazor Charts Examples - Stacked Bar | Charts Demos | Syncfusion",
                HeaderText = "Blazor Stacked Bar Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Stacked Bar Chart displays cumulative horizontal values using API, tooltips, and events for part-to-whole data analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "100% Stacked Bar",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/percent-stacked-bar",
                FileName = "StackedBar100.razor",
                MetaTitle = "Blazor Charts Examples - 100% Stacked Bar | Charts Demos | Syncfusion",
                HeaderText = "Blazor 100% Stacked Bar Chart Example",
                MetaDescription = "See how the Syncfusion Blazor 100% Stacked Bar Chart presents proportional values using API, tooltips, and events for accurate comparison across categories.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Column Stacked And Grouped",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/column-stacked-and-grouped",
                FileName = "ColumnStackedAndGrouped.razor",
                MetaTitle = "Blazor Charts Demos - Column Stacked And Grouped | Syncfusion",
                HeaderText = "Blazor Column Stacked And Grouped Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Column Stacked and Grouped Chart combines stacked and grouped bars using API, tooltips, and events for multi-level comparison.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Column Negative Points",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/negative-column",
                FileName = "NegativeColumn.razor",
                MetaTitle = "Blazor Charts - Column Negative Points | Charts Demos | Syncfusion",
                HeaderText = "Blazor Column with Negative Points Bar Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Column Negative Points Chart handles negative values with API, tooltips, and events for accurate statistical and financial.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Negative Stack",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "chart/negative-stack",
                FileName = "NegativeStack.razor",
                MetaTitle = "Blazor Charts Examples - Negative Stack | Charts Demos | Syncfusion",
                HeaderText = "Blazor Negative Stacked Bar Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Negative Stack Chart visualizes positive and negative stacked values with API, tooltips, and events for balanced data analysis.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Scatter Plot",
                Category = "Scatter and Bubble",
                Directory = "Charts/Chart",
                Url = "chart/scatter",
                FileName = "Scatter.razor",
                MetaTitle = "Blazor Charts Examples - Scatter Plot | Charts Demos | Syncfusion",
                HeaderText = "Blazor Scatter Plot Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Scatter Plot Chart plots XY data with API, tooltips, and events for correlation analysis, pattern detection, and insights.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Bubble",
                Category = "Scatter and Bubble",
                Directory = "Charts/Chart",
                Url = "chart/bubble",
                FileName = "Bubble.razor",
                MetaTitle = "Blazor Charts Demos - Bubble Examples | Charts Demos | Syncfusion",
                HeaderText = "Blazor Bubble Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Bubble Chart visualizes three-dimensional data with varying sizes using API, tooltips, and events for multi-variable analysis.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "Bubble.razor", Id = "Bubble" },
                    new SourceCollection { FileName = "BubbelPointColor.cs", Id = "BubbelPointColor" }
                }
            },
            new Sample
            {
                Name = "Pie",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/pie",
                FileName = "Pie.razor",
                MetaTitle = "Blazor Charts Demos - Pie Examples | Charts Demos | Syncfusion",
                HeaderText = "Blazor Pie Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Pie Chart displays proportional slices using API, tooltips, and events for clear data composition and interactive analysis.",
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
                MetaTitle = "Blazor Charts - Pie with Various Radius | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Pie with Various Radius Chart uses varying inner radii with API, tooltips, and events for enhanced hierarchy and visual appeal.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Donut",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/donut",
                FileName = "Donut.razor",
                MetaTitle = "Blazor Charts Demos - Donut Examples | Charts Demos | Syncfusion",
                HeaderText = "Blazor Donut Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Donut Chart displays proportional segments with API, tooltips, and events for compact composition analysis and clear labeling.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Donut with Gradient",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/donut-with-gradient",
                FileName = "DonutWithGradient.razor",
                HeaderText = "Blazor Donut Chart with Gradient Example.",
                MetaTitle = "Blazor Charts - Donut with Gradient | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Donut with Gradient Chart applies gradient fills using API, tooltips, and events for visually rich and engaging data presentation.",
            },
            new Sample
            {
                Name = "Pyramid",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/pyramid",
                FileName = "Pyramid.razor",
                MetaTitle = "Blazor Charts Examples - Pyramid | Charts Demos | Syncfusion",
                HeaderText = "Blazor Pyramid Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Pyramid Chart visualizes hierarchical data using API, tooltips, and events for funnel analysis and stage-based insights.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Funnel",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/funnel",
                FileName = "Funnel.razor",
                MetaTitle = "Blazor Charts Demos - Funnel Examples | Charts Demos | Syncfusion",
                HeaderText = "Blazor Funnel Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Funnel Chart renders narrowing segments with API, tooltips, and events for conversion analysis and stage-by-stage data breakdown.",
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
                MetaTitle = "Blazor Charts Examples - Pie with Legend | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Pie with Legend Chart displays interactive legends using API, tooltips, and events to toggle visibility and explore data easily.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pie with Legend Template",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/pie-legend-template",
                FileName = "PieLegendTemplate.razor",
                HeaderText = "Blazor Pie with Legend Template Chart Example.",
                MetaTitle = "Blazor Charts - Pie with Legend Template | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Pie with Legend Template chart customizes legend items using templates, API, and events for branded and interactive data display.",
            },
            new Sample
            {
                Name = "Semi Pie",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "chart/semi-pie",
                FileName = "SemiPie.razor",
                HeaderText = "Blazor Semi Pie Chart Example.",
                MetaTitle = "Blazor Charts Examples - Semi Pie | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Semi Pie chart renders half-circle visuals with API, tooltips, and events for compact dashboards and efficient data presentation.",
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
                MetaTitle = "Blazor Charts Examples - Smart Labels | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Smart Labels Pie chart positions labels using API, tooltips, and events to prevent overlaps and ensure clean readable output.",
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
                MetaTitle = "Blazor Charts Examples - Drilldown | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Drilldown Pie Chart enables hierarchical data exploration using API, tooltips, and events for seamless navigation and insights.",
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
                MetaTitle = "Blazor Charts Examples - Grouping | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Grouping Pie Chart combines smaller slices using API, tooltips, and events for simplified visuals and improved readability.",
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
                MetaTitle = "Blazor Charts Examples - Empty Points | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Pie Chart Empty Points example handles missing or null data using empty point modes for clear data visualization and analysis.",
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
                MetaTitle = "Blazor Charts Examples - Rounded Corners | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Rounded Corners Pie chart applies smooth edges with API, styling, and events for modern UI design and appealing visuals.",
            },
            new Sample
            {
                Name = "Waterfall",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/waterfall",
                FileName = "Waterfall.razor",
                HeaderText = "Blazor Waterfall Chart Example.",
                MetaTitle = "Blazor Charts Examples - Waterfall | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Waterfall chart visualizes cumulative changes using API, tooltips, and events for tracking financial growth and decline clearly.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Horizontal Waterfall",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/horizontal-waterfall",
                FileName = "HorizontalWaterfall.razor",
                MetaTitle = "Blazor Charts - Horizontal Waterfall | Charts Demos | Syncfusion",
                HeaderText = "Blazor Horizontal Waterfall Chart Example.",
                MetaDescription = "See how the Syncfusion Blazor Horizontal Waterfall chart displays running totals using API, tooltips, and events for analyzing sequential data impacts.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Histogram",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/histogram",
                FileName = "Histogram.razor",
                MetaTitle = "Blazor Charts Examples - Histogram | Charts Demos | Syncfusion",
                HeaderText = "Blazor Histogram Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Histogram Chart displays frequency distribution using bins with API, tooltips, and events for statistical analysis and patterns.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Box and Whisker",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/box-and-whisker",
                FileName = "BoxandWhisker.razor",
                MetaTitle = "Blazor Charts Examples - Box and Whisker | Charts Demos | Syncfusion",
                HeaderText = "Blazor Box and Whisker Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Box and Whisker Chart displays quartiles, medians, and outliers with API, tooltips, and events for accurate statistical analysis.",
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
                MetaTitle = "Blazor Charts Examples - Error Bar | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Error Bar Chart represents data variation using API, tooltips, and events for accurate uncertainty visualization and analysis.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "ErrorBar.razor", Id = "ErrorBar" },
                    new SourceCollection { FileName = "PointColor.cs", Id = "PointColor" }
                }
            },
            new Sample
            {
                Name = "Trendlines",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/trendlines",
                FileName = "Trendlines.razor",
                HeaderText = "Blazor Trendlines Chart Example.",
                MetaTitle = "Blazor Charts Examples - Trendlines | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Trendlines Chart adds linear and polynomial trends using API, tooltips, and events for predictive analysis and data forecasting.",
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
                MetaTitle = "Blazor Charts - Multi Series Chart | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Multi Series Chart combines series types with API, tooltips, and events for comparing multiple datasets and advanced analysis.",
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
                MetaTitle = "Blazor Charts Demos - Pareto Examples | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Pareto Chart combines column and line series with API, tooltips, and events to highlight key factors for quality analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Combo Chart",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "chart/combo-chart",
                FileName = "ComboChart.razor",
                MetaTitle = "Blazor Charts Examples - Combo Chart | Charts Demos | Syncfusion",
                HeaderText = "Blazor Combo Chart Example.",
                MetaDescription = "See how the Syncfusion Blazor Combo Chart mixes column and line series using API, tooltips, and events for comparing multiple variables with dual-axis support.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Hilo",
                Category = "Stock Charts",
                Directory = "Charts/Chart",
                Url = "chart/hilo",
                FileName = "Hilo.razor",
                MetaTitle = "Blazor Charts Demos - Hilo Examples | Charts Demos | Syncfusion",
                HeaderText = "Blazor Hilo Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Hilo Chart displays high-low values with API, tooltips, and events for analyzing stock volatility and price range movements.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "Hilo.razor", Id = "Hilo" },
                    new SourceCollection { FileName = "PointColor.cs", Id = "PointColor" }
                }

            },
            new Sample
            {
                Name = "Hilo Open Close",
                Category = "Stock Charts",
                Directory = "Charts/Chart",
                Url = "chart/hilo-open-close",
                FileName = "HiloOpenClose.razor",
                HeaderText = "Blazor Hilo Open Close Chart Example.",
                MetaTitle = "Blazor Charts Examples - Hilo Open Close | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Hilo Open Close Chart shows OHLC values with API, tooltips, and events for detailed stock analysis and trading insights.",
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
                MetaTitle = "Blazor Charts Examples - Candle Stick | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Candlestick Chart renders OHLC patterns with API, tooltips, and events for tracking trends and supporting trading decisions.",
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
                MetaTitle = "Blazor Charts Demos - Accumulation Distributions | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Accumulation Distribution Chart uses volume and price with API, tooltips, and events to analyze buying and selling pressure.",
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
                MetaTitle = "Blazor Charts Demos - ATR Examples | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor ATR Chart measures market volatility using API, tooltips, and events for better risk evaluation and trading strategy decisions.",
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
                MetaTitle = "Blazor Charts Examples - Bollinger | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Bollinger Chart plots volatility bands with API, tooltips, and events to analyze price trends and market fluctuations effectively.",
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
                MetaTitle = "Blazor Charts Demos - EMA Examples | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor EMA Chart plots exponential moving averages using API, tooltips, and events to identify trends and generate trading signals.",
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
                MetaTitle = "Blazor Charts Demos - MACD Examples | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor MACD Chart visualizes momentum with API, tooltips, and events to track crossovers and support better market timing decisions.",
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
                MetaTitle = "Blazor Charts Examples - Momentum | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Momentum Chart measures price changes with API, tooltips, and events to identify trend strength and potential reversal signals.",
            },
            new Sample
            {
                Name = "RSI",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "chart/relative-strength-index-indicator",
                FileName = "RsiChart.razor",
                HeaderText = "Blazor RSI Chart Example.",
                MetaTitle = "Blazor Charts Demos - RSI Examples | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor RSI Chart shows relative strength using API, tooltips, and events to detect overbought and oversold market conditions accurately.",
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
                MetaTitle = "Blazor Charts Demos - SMA Examples | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor SMA Chart plots simple moving averages with API, tooltips, and events to smooth data trends and identify direction in time series.",
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
                MetaTitle = "Blazor Charts Examples - Stochastic | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Stochastic Chart visualizes momentum with API, tooltips, and events to identify overbought and oversold market conditions.",
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
                MetaTitle = "Blazor Charts Demos - TMA Examples | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor TMA Chart plots triangular moving averages with API, tooltips, and events to reduce noise and reveal clearer trend patterns.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Line",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "chart/polar-line",
                FileName = "PolarLineChart.razor",
                MetaTitle = "Blazor Charts Demos - Line Examples | Charts Demos | Syncfusion",
                HeaderText = "Blazor Polar Radar Line Chart Example",
                MetaDescription = "See how the Syncfusion Blazor Line Polar Chart renders circular plots with API, tooltips, and events to visualize cyclic data and analyze polar trends.",
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
                MetaTitle = "Blazor Charts Demos - Polar Area Examples | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Area Polar Chart fills circular regions with API, tooltips, and events to enhance visual impact and support polar data analysis.",
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
                MetaTitle = "Blazor Charts Demos - Polar Stacked Area | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Stacked Area Polar Chart displays cumulative circular data with API, tooltips, and events for effective multi-series comparison.",
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
                MetaTitle = "Blazor Charts Examples - Scatter | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Scatter Polar Chart plots points with API, tooltips, and events for distribution analysis in circular coordinate systems.",
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
                MetaTitle = "Blazor Charts Demos - Polar Column | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Column Polar Chart renders radial columns with API, tooltips, and events for clear circular data representation and insights.",
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
                MetaTitle = "Blazor Charts Examples - Wind Rose | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Wind Rose Chart visualizes wind direction and speed with API, tooltips, and events for accurate meteorological analysis.",
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
                MetaTitle = "Blazor Charts Demos - Polar Range Column | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Polar Range Column Chart visualizes min-max ranges with API, tooltips, and events for clear statistical comparison.",
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
                MetaTitle = "Blazor Charts Examples - Local Data | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Local Data Chart binds JSON and arrays with API, tooltips, and events for dynamic visualization and real-time data updates.",
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
                MetaTitle = "Blazor Charts Examples - Remote Data | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Remote Data Chart fetches API data with tooltips and events for live visualization and seamless external data integration.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "RemoteData.razor", Id = "RemoteData" },
                    new SourceCollection { FileName = "PointColor.cs", Id = "PointColor" }
                }
            },
            new Sample
            {
                Name = "Live Chart",
                Category = "Live Chart",
                Directory = "Charts/Chart",
                Url = "chart/live-chart",
                FileName = "LiveChart.razor",
                HeaderText = "Blazor Live Chart Example.",
                MetaTitle = "Blazor Chart Examples - Live Chart | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Live Chart updates automatically with API, tooltips, and events for real-time dashboards and continuous data monitoring.",
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
                MetaTitle = "Blazor Charts Examples - Numeric Axis | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Numeric Axis Chart scales values with API, intervals, and events for precise quantitative visualization and clear data insights.",
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
                MetaTitle = "Blazor Chart Examples - DateTime Axis | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor DateTime Axis Chart plots time series data with API, formatting, and events for accurate timelines and clear trend analysis.",
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
                MetaTitle = "Blazor Chart Demos - DateTime Category Axis | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor DateTime Category Axis Chart groups dates into intervals using API, tooltips, and events for structured time-based analysis.",
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
                MetaTitle = "Blazor Chart Examples - Category Axis | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Category Axis Chart plots string labels with API, tooltips, and events for clear qualitative comparison and grouped data insights.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "CategoryAxis.razor", Id = "CategoryAxis" },
                    new SourceCollection { FileName = "PointColor.cs", Id = "PointColor" }
                }
            },
            new Sample
            {
                Name = "Indexed Category Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/indexed-category-axis",
                FileName = "IndexedCategoryAxis.razor",
                HeaderText = "Blazor Chart with Indexed Category Axis Example.",
                MetaTitle = "Blazor Charts - Indexed Category Axis | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Indexed Category Axis Chart uses numeric indexing with API, tooltips, and events for sequential data plotting and analysis.",
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
                MetaTitle = "Blazor Charts Examples - Logarithmic Axis | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Logarithmic Axis Chart uses log scales with API, tooltips, and events to visualize wide-range data clearly and accurately.",
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
                MetaTitle = "Blazor Chart Examples - Multiple Axis | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Multiple Axis Chart displays multi-scale data using API, tooltips, and events for better comparison across different value ranges.",
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
                MetaTitle = "Blazor Chart Examples - Inversed Axis | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Inversed Axis Chart reverses axis direction using API, tooltips, and events to provide alternative perspectives and analysis.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "InversedAxis.razor", Id = "InversedAxis" },
                    new SourceCollection { FileName = "PointColor.cs", Id = "PointColor" }
                }
            },
            new Sample
            {
                Name = "Multiple Panes",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/multiple-panes",
                FileName = "MultiplePanes.razor",
                MetaTitle = "Blazor Charts Examples - Multiple Panes | Charts Demos | Syncfusion",
                HeaderText = "Blazor Multiple Panes Chart Example.",
                MetaDescription = "See how the Syncfusion Blazor Multiple Panes Chart renders multi-pane layouts with API, tooltips, and events for comparing correlated data series effectively.",
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
                MetaTitle = "Blazor Chart Examples - StripLine | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor StripLine Chart adds reference zones with API, tooltips, and events for improved threshold tracking and analysis insights.",
            },
            new Sample
            {
                Name = "StripLine Recurrence",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/recurrence-strip-line",
                FileName = "StripLineRecurrence.razor",
                HeaderText = "Blazor Chart with StripLine Recurrence Example.",
                MetaTitle = "Blazor Charts - StripLine Recurrence | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor StripLine Recurrence Chart creates repeating zones with API, tooltips, and events for analyzing cyclical data patterns clearly.",
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
                MetaTitle = "Blazor Charts Demos - Smart Axis Labels Examples | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Smart Axis Labels Chart manages label density with API, tooltips, and events to prevent overlap and ensure clean readability.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "SmartAxisLabels.razor", Id = "SmartAxisLabels" },
                    new SourceCollection { FileName = "PointColor.cs", Id = "PointColor" }
                }
            },
            new Sample
            {
                Name = "Axis Label Template",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/axis-label-template",
                FileName = "AxisLabelTemplate.razor",
                HeaderText = "Blazor Chart with Axis Label Template Example.",
                MetaTitle = "Blazor Charts - Axis Label Template | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Axis Label Template Chart uses custom labels with API, tooltips, and events to create styled and informative axis displays.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "AxisLabelTemplate.razor", Id = "AxisLabelTemplate" },
                    new SourceCollection { FileName = "PointColor.cs", Id = "PointColor" }
                }
            },
            new Sample
            {
                Name = "Multiple Level Labels",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/multiple-level",
                FileName = "MultiLevelLabel.razor",
                HeaderText = "Blazor Chart with Multiple Level Labels Example.",
                MetaTitle = "Blazor Charts - Multiple Level Labels | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Multiple Level Labels Chart shows hierarchical labels using API, tooltips, and events for organizing complex categorical data.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "MultiLevelLabel.razor", Id = "MultiLevelLabel" },
                    new SourceCollection { FileName = "PointColor.cs", Id = "PointColor" }
                }
            },
            new Sample
            {
                Name = "Axis Crossing",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "chart/axis-crossing",
                FileName = "AxisCrossing.razor",
                HeaderText = "Blazor Chart with Axis Crossing Example.",
                MetaTitle = "Blazor Chart Examples - Axis Crossing | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Axis Crossing Chart customizes axis intersections using API, tooltips, and events for flexible origin positioning and analysis.",
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
                MetaTitle = "Blazor Charts Examples - Marker Chart | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Marker Chart uses custom markers with API, tooltips, and events to highlight key data points and improve visibility clearly.",
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
                MetaTitle = "Blazor Charts - Synchronized Charts | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Synchronized Charts coordinate multiple charts using API, tooltips, and events for accurate cross-chart comparison and insights.",
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
                MetaTitle = "Blazor Charts Demos - RTL Examples | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Chart supports right to left layouts for Arabic, Hebrew, and other languages to ensure proper data visualization and alignment.",
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
                MetaTitle = "Blazor Charts Examples - Vertical Chart | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Chart rotates orientation to display data vertically and improve layout flexibility with space efficient visualization design.",
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
                MetaTitle = "Blazor Charts Examples - Empty Point | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Empty Point Chart handles missing data with API, styles, and events to ensure accurate and reliable visualization of datasets.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Legend Template",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "chart/chart-legend-template",
                FileName = "LegendTemplate.razor",
                HeaderText = "Blazor Legend Template Chart Example.",
                MetaTitle = "Blazor Charts Examples - Legend Template | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Chart uses legend templates to customize appearance with HTML content for branded and interactive legend presentation clearly.",
            },
            new Sample
            {
                Name = "No Data Template",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "chart/no-data-template",
                FileName = "NoDataTemplate.razor",
                HeaderText = "Blazor No Data Template Chart Example.",
                MetaTitle = "Blazor Charts Examples - No Data Template | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor No Data Template Chart displays custom messages using API and templates when datasets are empty to improve user feedback clearly.",
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
                MetaTitle = "Blazor Charts - Datalabel Template | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor DataLabel Template Chart example customizes data label formatting and styling to enhance clarity and display detailed data values.",
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
                MetaTitle = "Blazor Charts Examples - Tooltip Template | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Chart designs interactive tooltips using HTML templates to enhance user interaction and improve data exploration effectively.",
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
                MetaTitle = "Blazor Charts Examples - Sorting | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Chart sorts data points automatically to present organized visual output and improve readability with structured data arrangement.",
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
                MetaTitle = "Blazor Charts Examples - Annotation | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Annotation Chart adds text, images, and shapes using API, templates, and events to deliver contextual insights and storytelling.",
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
                MetaTitle = "Blazor Charts Examples - Adaptive Layout | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Adaptive Layout Chart adjusts layouts with API, responsive design, and events for consistent visualization across devices.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Print",
                Category = "Print and Export",
                Directory = "Charts/Chart",
                Url = "chart/print",
                FileName = "Print.razor",
                HeaderText = "Blazor Chart with Print Example.",
                MetaTitle = "Blazor Charts Demos - Print Examples | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Print Chart exports visuals with API, layout settings, and events for creating high-quality printed reports and documentation.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "Print.razor", Id = "Print" },
                    new SourceCollection { FileName = "PointColor.cs", Id = "PointColor" }
                }
            },
            new Sample
            {
                Name = "Export",
                Category = "Print and Export",
                Directory = "Charts/Chart",
                Url = "chart/export",
                FileName = "Export.razor",
                HeaderText = "Blazor Chart with Export Example.",
                MetaTitle = "Blazor Charts Demos - Export Examples | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Export Chart saves charts as PNG, JPEG, SVG, and PDF using API, settings, and events for easy sharing and publishing workflows.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "Export.razor", Id = "Export" },
                    new SourceCollection { FileName = "PointColor.cs", Id = "PointColor" }
                }
            },
            new Sample
            {
                Name = "Selection",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "chart/selection",
                FileName = "Selection.razor",
                HeaderText = "Blazor Chart with Selection Example.",
                MetaTitle = "Blazor Charts Examples - Selection | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Selection Chart enables point and series selection using API, events, and highlighting for focused data exploration and filtering.",
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
                MetaTitle = "Blazor Charts Examples - Range Selection | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Range Selection Chart lets users select data ranges using API, drag actions, and events for zooming and detailed analysis.",
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
                MetaTitle = "Blazor Charts - Keyboard Navigation | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Keyboard Navigation Chart supports accessibility using keyboard controls, API, and events for inclusive data interaction.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "KeyboardChart.razor", Id = "KeyboardChart" },
                    new SourceCollection { FileName = "PointColor.cs", Id = "PointColor" }
                }
            },
            new Sample
            {
                Name = "Crosshair",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "chart/crosshair",
                FileName = "Crosshair.razor",
                HeaderText = "Blazor Chart with Crosshair Example.",
                MetaTitle = "Blazor Charts Examples - Crosshair | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Crosshair Chart displays tracking lines using API, tooltips, and events for precise data reading and coordinate identification.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Trackball",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "chart/trackball",
                FileName = "Trackball.razor",
                HeaderText = "Blazor Chart with Trackball Example.",
                MetaTitle = "Blazor Charts Examples - Trackball | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Trackball Chart shows synchronized tooltips using API, markers, and events for accurate comparison of multiple data points.",
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
                MetaTitle = "Blazor Charts - Zooming and Panning | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Zooming and Panning Chart enables navigation using API, gestures, and events for detailed exploration of large datasets.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Dynamic Points",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "chart/add-a-point-on-click",
                FileName = "AddingPoint.razor",
                HeaderText = "Blazor Chart with Dynamic Points Example.",
                MetaTitle = "Blazor Charts Examples - Dynamic Points | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Dynamic Points Chart updates data in real time using API, events, and binding for interactive dashboards and live insights.",
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
                MetaTitle = "Blazor Charts Examples - Data Editing | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Data Editing Chart supports point editing using API, events, and interaction tools for flexible data updates and analysis.",
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
                HeaderText = "Blazor 3D Chart with Column Example",
                MetaTitle = "Blazor 3D Chart Examples - Column | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Column 3D chart renders vertical bars with depth, using features like tooltips, data labels, and events for clear insights.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "Column3D.razor", Id = "Column3D" },
                    new SourceCollection { FileName = "PointColor.cs", Id = "PointColor" }
                }
            },
            new Sample
            {
                Name = "Back to Back Column",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/back-to-back-column",
                FileName = "BackToBackColumn3D.razor",
                HeaderText = "Blazor 3D Chart with Back to Back Column Example",
                MetaTitle = "Blazor 3DCharts - Back to Back Columnn | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor 3D Back-to-Back Column Chart compares opposing series with mirrored bars for direct data benchmarking and comparative analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Cylindrical Column",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/cylinder",
                FileName = "CylindricalColumn3D.razor",
                HeaderText = "Blazor 3D Chart with Cylindrical Column Example",
                MetaTitle = "Blazor 3DCharts - Cylindrical Column | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Cylindrical Column 3D chart renders rounded bars with tooltips, data labels, and events for clear interactive data insights.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "CylindricalColumn3D.razor", Id = "CylindricalColumn3D" },
                    new SourceCollection { FileName = "PointColor.cs", Id = "PointColor" }
                }
            },
            new Sample
            {
                Name = "Bar",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/bar",
                FileName = "Bar3D.razor",
                HeaderText = "Blazor 3D Chart with Bar Example",
                MetaTitle = "Blazor 3D Chart Demos - Bar Examples | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Bar 3D chart renders horizontal bars with depth using features like tooltips, data labels, and events for better analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stacking Column with Grouping",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/stacked-column",
                FileName = "StackingColumnGrouping3D.razor",
                MetaTitle = "Blazor 3DCharts Demos- Stacking Column with Grouping | Syncfusion",
                HeaderText = "Blazor 3D Chart with Stacking Column Example",
                MetaDescription = "See how the Syncfusion Blazor Stacking Column with Grouping 3D chart uses grouping, stacking, tooltips, and events to compare multi-series data clearly.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "100% Stacked Column",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/stacked-column-100",
                FileName = "StackedColumn100.razor",
                HeaderText = "Blazor 3D Chart with Stacked Column Example",
                MetaTitle = "Blazor 3DCharts - 100% Stacked Column | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor 100% Stacked Column 3D chart displays percentage data with features like tooltips, legends, and events for clear comparisons.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stacked Bar",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/stacked-bar",
                FileName = "StackedBar3D.razor",
                HeaderText = "Blazor 3D Chart with Stacked Bar Example",
                MetaTitle = "Blazor 3D Chart Examples - Stacked Bar | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Stacked Bar 3D chart visualizes cumulative data with features like tooltips, legends, and events for easy category comparison.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "100% Stacked Bar",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/stacked-bar-100",
                FileName = "StackedBar100.razor",
                HeaderText = "Blazor 3D Chart with 100% Stacked Bar Example",
                MetaTitle = "Blazor 3DCharts - 100% Stacked Bar | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor 100% Stacked Bar 3D chart displays percentage distributions with tooltips, legends, and events for accurate comparisons.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Column with null and 0 values",
                Category = "3D Chart",
                Directory = "Charts/Chart3D",
                Url = "chart-3d/empty-point",
                FileName = "ColumnNullValues3D.razor",
                MetaTitle = "Blazor 3DCharts Demos- Column with null and 0 values | Syncfusion",
                HeaderText = "Blazor 3D Chart with Column Null Values Example",
                MetaDescription = "See how the Syncfusion Blazor 3D Chart handles null and zero values with configurable empty point modes for robust 3D data visualization in all scenarios.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "ColumnNullValues3D.razor", Id = "ColumnNullValues3D" },
                    new SourceCollection { FileName = "PointColor.cs", Id = "PointColor" }
                }
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
                MetaTitle = "Blazor Range Navigator Examples - Default | Charts Demos | Syncfusion",
                HeaderText = "Blazor Range Navigator Example",
                MetaDescription = "See how the Syncfusion Blazor Range Navigator enables interactive range selection with slider controls for filtering and zooming large datasets efficiently.",
                Type = SampleType.None
            },
			new Sample
			 {
			    Name = "Lightweight",
			    Category = "Range Selector",
			    Directory = "Charts/RangeNavigator",
			    Url = "range-selector/light-weight",
			    FileName = "LightWeight.razor",
			    MetaTitle = "Blazor Range Navigator - Lightweight | Charts Demos | Syncfusion",
			    HeaderText = "Blazor Lightweight Range Navigator Example",
			    MetaDescription = "See how the Syncfusion Blazor Lightweight Range Navigator renders optimized performance charts for large dataset interaction with minimal resource usage.",
			    Type = SampleType.None
			},
			  new Sample
			  {
                Name = "DateTime Axis",
                Category = "Axis",
                Directory = "Charts/RangeNavigator",
                Url = "range-selector/date-time-axis",
                FileName = "DateTimeAxis.razor",
                MetaTitle = "Blazor Range Navigator - DateTime Axis | Charts Demos | Syncfusion",
                HeaderText = "Blazor Range Navigator DateTime Axis Example",
                MetaDescription = "See how the Syncfusion Blazor Range Navigator with DateTime Axis filters time series data with intelligent date formatting and navigation controls easily.",
                Type = SampleType.None
			 },
			  new Sample
			  {
                Name = "Numeric Axis",
                Category = "Axis",
                Directory = "Charts/RangeNavigator",
                Url = "range-selector/numeric-axis",
                FileName = "NumericAxis.razor",
                MetaTitle = "Blazor Range Navigator - Numeric Axis | Charts Demos | Syncfusion",
                HeaderText = "Blazor Range Navigator Numeric Axis Example",
                MetaDescription = "See how the Syncfusion Blazor Numeric Axis Range Navigator filters numeric data with sliders, API controls, and events for precise range selection and analysis.",
                Type = SampleType.None
			 },
              new Sample
              {
                Name = "Logarithmic Axis",
                Category = "Axis",
                Directory = "Charts/RangeNavigator",
                Url = "range-selector/logarithmic",
                FileName = "Logarithmic.razor",
                MetaTitle = "Blazor Range Navigator - Logarithmic Axis | Charts Demos | Syncfusion",
                HeaderText = "Blazor Range Navigator Logarithmic Axis Example",
                MetaDescription = "See how the Syncfusion Blazor Range Navigator with Logarithmic Axis filters exponential data using logarithmic scaling for better distribution visualization.",
                Type = SampleType.None
             },
              new Sample
			 {
			    Name = "Multilevel Labels",
			    Category = "Axis",
			    Directory = "Charts/RangeNavigator",
			    Url = "range-selector/multilevel",
			    FileName = "Multilevel.razor",
			    MetaTitle = "Blazor Range Navigator - Multilevel Labels Examples | Syncfusion",
			    HeaderText = "Blazor Range Navigator Multilevel Labels Example",
			    MetaDescription = "See how the Syncfusion Blazor Range Navigator with Multilevel Labels displays hierarchical axis labels for complex categorical data during range selection.",
			    Type = SampleType.None
			},
			   new Sample
			   {
			      Name = "Empty Points",
			      Category = "Customization",
			      Directory = "Charts/RangeNavigator",
			      Url = "range-selector/empty-point",
			      FileName = "EmptyPoint.razor",
			      MetaTitle = "Blazor Range Navigator - Empty Points | Charts Demos | Syncfusion",
			      HeaderText = "Blazor Range Navigator Empty Points Example",
			      MetaDescription = "See how the Syncfusion Blazor Range Navigator with Empty Points handles missing data with configurable empty point modes for reliable range filtering.",
			      Type = SampleType.None
			    },
			   new Sample
			   {
			      Name = "Filter",
			      Category = "Customization",
			      Directory = "Charts/RangeNavigator",
			      Url = "range-selector/filter",
			      FileName = "Filter.razor",
			      MetaTitle = "Blazor Range Navigator Examples - Filter | Charts Demos | Syncfusion",
			      HeaderText = "Blazor Range Navigator Filter Example",
			      MetaDescription = "See how the Syncfusion Blazor Filter Range Navigator applies dynamic filtering with slider controls, API support, and events for focused data exploration.",
			      Type = SampleType.None
			  },
			   new Sample
			   {
			      Name = "Print and Export",
			      Category = "Export",
			      Directory = "Charts/RangeNavigator",
			      Url = "range-selector/print-export",
			      FileName = "PrintExport.razor",
			      MetaTitle = "Blazor Range Navigator - Print and Export | Charts Demos | Syncfusion",
			      HeaderText = "Blazor Range Navigator Print and Export Example",
			      MetaDescription = "See how the Syncfusion Blazor Range Navigator supports printing and exporting selected range visualizations for reporting and documentation efficiently.",
			      Type = SampleType.None
			  },
			  new Sample
			  {
			     Name = "RTL",
			     Category = "Right To Left",
			     Directory = "Charts/RangeNavigator",
			     Url = "range-selector/rtl",
			     FileName = "RTL.razor",
			     MetaTitle = "Blazor Range Navigator Examples - RTL | Charts Demos | Syncfusion",
			     HeaderText = "Blazor Range Navigator RTL Example",
			     MetaDescription = "See how the Syncfusion Blazor RTL Range Navigator supports right-to-left layouts using localization, API settings, and events for accurate regional filtering.",
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
                MetaTitle = "Blazor Sparkline Charts - Default | Charts Demos | Syncfusion",
                HeaderText = "Blazor Sparkline Charts Default Functionalities Example",
                MetaDescription = "See how the Syncfusion Blazor Sparkline Charts render compact inline charts with line, area, column, and win-loss types for space-efficient trend visualization.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-sparkline"
            },
             new Sample
             {
                 Name = "Series Type",
                 Category = "Sparkline Charts",
                 Directory = "Charts/Sparkline",
                 Url = "sparkline/series-type",
                 FileName = "SeriesType.razor",
                 MetaTitle = "Blazor Sparkline Charts - Series Type | Charts Demos | Syncfusion",
                 HeaderText = "Blazor Sparkline Series Type Example",
                 MetaDescription = "See how the Syncfusion Blazor Series Type Sparkline Chart switches between line, area, column, and win-loss with API, tooltips, and events for compact insights.",
                 Type = SampleType.None
             },
             new Sample
            {
                Name = "Axis Value Types",
                Category = "Sparkline Charts",
                Directory = "Charts/Sparkline",
                Url = "sparkline/axis-types",
                FileName = "AxisTypes.razor",
                MetaTitle = "Blazor Sparkline Charts Demos - Axis Value Types | Syncfusion",
                HeaderText = "Blazor Sparkline Axis Value Types Example",
                MetaDescription = "See how the Syncfusion Blazor Axis Value Types Sparkline Chart supports numeric, datetime, and category axes using API, tooltips, and events for clear data use.",
                Type = SampleType.None
            },
             new Sample
             {
                 Name = "Sparkline in Grid",
                 Category = "Sparkline Charts",
                 Directory = "Charts/Sparkline",
                 Url = "sparkline/sparkline-grid",
                 FileName = "SparklineGrid.razor",
                 MetaTitle = "Blazor Sparkline Charts Demos - Sparkline in Grid | Syncfusion",
                 HeaderText = "Blazor Sparkline in Grid Example",
                 MetaDescription = "See how the Syncfusion Blazor Sparkline in Grid embeds compact sparklines within data grid columns for enhanced tabular data visualization and trend analysis.",
                 Type = SampleType.None,
                 SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "SparklineGrid.razor", Id = "SparklineGrid" },
                    new SourceCollection { FileName = "SparkGridData.cs", Id = "SparkGridData" }
                }
             },
                new Sample
              {
                  Name = "Customization",
                  Category = "Sparkline Charts",
                  Directory = "Charts/Sparkline",
                  Url = "sparkline/customization",
                  FileName = "Customization.razor",
                  MetaTitle = "Blazor Sparkline Charts - Customization | Charts Demos | Syncfusion",
                  HeaderText = "Blazor Sparkline Customization Example",
                  MetaDescription = "See how the Syncfusion Blazor Sparkline Customization demo styles sparklines with custom colors, markers, and data labels for personalized data presentation.",
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
                MetaTitle = "Blazor Smith Chart Demos - Default | Charts Demos | Syncfusion",
                HeaderText = "Blazor Smith Chart Default Functionalities Example",
                MetaDescription = "See how the Syncfusion Blazor Default Functionalities Smith Chart renders RF impedance with reactance circles, tooltips, API, and events for accurate analysis.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-smith-chart"
            },
            new Sample
            {
                Name = "Customization",
                Category = "Smith Chart",
                Directory = "Charts/SmithChart",
                Url = "smith-chart/customization",
                FileName = "Customization.razor",
                MetaTitle = "Blazor Smith Chart - Customization | Charts Demos | Syncfusion",
                HeaderText = "Blazor Smith Chart Customization Example",
                MetaDescription = "See how the Syncfusion Blazor Smith Chart Customization demo styles impedance plots with custom colors and visual enhancements for professional presentations.",
                Type = SampleType.None
            },
            new Sample
            {
               Name = "Print and Export",
               Category = "Smith Chart",
               Directory = "Charts/SmithChart",
               Url = "smith-chart/print-and-export",
               FileName = "PrintAndExport.razor",
               MetaTitle = "Blazor Smith Chart - Print and Export | Charts Demos | Syncfusion",
               HeaderText = "Blazor Smith Chart Print and Export Example",
               MetaDescription = "See how the Syncfusion Blazor Print and Export Smith Chart generates reports with PDF, image export, and API features for efficient sharing and documentation.",
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
                MetaTitle = "Blazor Stock Chart Examples - Default | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Default Stock Chart visualizes market data using candlestick, volume, and range navigator with API, events, and analysis features.",
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
                MetaTitle = "Blazor Stock Chart Examples - OHLC | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor OHLC Stock Chart plots open, high, low, and close values with API, tooltips, and events for accurate financial analysis.",
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
                MetaTitle = "Blazor Stock Chart Demos - Candlestick and Volume | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Stock Chart combines candlestick patterns with volume analysis for comprehensive financial market visualization and insights.",
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
                MetaTitle = "Blazor Stock Chart - Multiple Series | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Multiple Series Stock Chart compares stocks with synchronized views, indicators, API, and events for comprehensive analysis.",
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
                MetaTitle = "Blazor Stock Chart Examples - Spline | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Spline Stock Chart renders smooth trend lines with tooltips, API, and events for clear financial data visualization and insights.",
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
                MetaTitle = "Blazor Stock Chart Examples - Area | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Area Stock Chart displays financial data with filled area under the curve for enhanced visual impact and trend emphasis.",
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
                MetaTitle = "Blazor Stock Chart Examples - Spline Area | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Spline Area Stock Chart renders smooth curved areas with API, tooltips, and events for clear financial trend visualization.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Inversed Area",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "stock-chart/inversed-area",
                FileName = "Inversed Area.razor",
                HeaderText = "Blazor Stock Chart with Inversed Area Example.",
                MetaTitle = "Blazor Stock Chart - Inversed Area | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Inversed Area Stock Chart inverts the area orientation for alternative financial data perspectives and reverse analysis.",
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
                MetaTitle = "Blazor Stock Chart - Hide Period Selector | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Hide Period Selector Stock Chart customizes navigation using API, UI controls, and events for a clean financial interface.",
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
                MetaTitle = "Blazor Stock Chart - Hide Range Selector | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Hide Range Selector Stock Chart customizes controls with API, events, and UI options for streamlined financial data interaction.",
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
                MetaTitle = "Blazor Stock Chart Demos - Stock Events Examples | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Stock Events Stock Chart highlights market events with annotations, tooltips, and API features to correlate price movements.",
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
                MetaTitle = "Blazor Stock Chart Demos - DateTime Category Axis | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Stock Chart with DateTime Category Axis groups time-series data into categorical intervals for structured financial analysis.",
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
                HeaderText = "Blazor Bullet Chart Examples - Default | Charts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Bullet Chart measures performance against targets with qualitative ranges for at-a-glance KPI evaluation and goal tracking.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-bullet-chart"
            },
           new Sample
            {
                Name = "Multiple Data",
                Category = "Bullet Chart",
                Directory = "Charts/BulletChart",
                Url = "bullet-chart/multiple-data",
                FileName = "MultipleData.razor",
                MetaTitle = "Blazor Bullet Chart - Multiple Data | Charts Demos | Syncfusion",
                HeaderText = "Blazor Bullet Chart Multiple Data Example",
                MetaDescription = "See how the Syncfusion Blazor Bullet Chart with Multiple Data compares multiple KPIs side-by-side for comprehensive performance benchmarking and analysis.",
                Type = SampleType.None
            },
           new Sample
            {
                Name = "RTL",
                Category = "Bullet Chart",
                Directory = "Charts/BulletChart",
                Url = "bullet-chart/right-to-left",
                FileName = "RightToLeft.razor",
                MetaTitle = "Blazor Bullet Chart Examples - RTL | Charts Demos | Syncfusion",
                HeaderText = "Blazor Bullet Chart RTL Example",
                MetaDescription = "See how the Syncfusion Blazor RTL Bullet Chart supports right-to-left layouts with API, labels, and events for accurate performance tracking in RTL languages.",
                Type = SampleType.None
            },
           new Sample
            {
                Name = "Feature and Target Bar",
                Category = "Bullet Chart",
                Directory = "Charts/BulletChart",
                Url = "bullet-chart/bar-customization",
                FileName = "BarCustomization.razor",
                MetaTitle = "Blazor Bullet Chart Demos - Feature and Target Bar | Syncfusion",
                HeaderText = "Blazor Bullet Chart Feature and Target Bar Example",
                MetaDescription = "See how the Syncfusion Blazor Feature and Target Bar Bullet Chart customizes bars using API, styling, and events to highlight goals and performance metrics.",
                Type = SampleType.None
            },
           new Sample
            {
                Name = "Range and Label Settings",
                Category = "Bullet Chart",
                Directory = "Charts/BulletChart",
                Url = "bullet-chart/customization",
                FileName = "Customization.razor",
                MetaTitle = "Blazor Bullet Chart Demos - Range and Label Settings | Syncfusion",
                HeaderText = "Blazor Bullet Chart Range and Label Settings Example",
                MetaDescription = "See how the Syncfusion Blazor Range and Label Settings Bullet Chart customizes ranges and labels with API, formatting, and events for clear performances.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Legend",
                Category = "Bullet Chart",
                Directory = "Charts/BulletChart",
                Url = "bullet-chart/legend",
                FileName = "Legend.razor",
                MetaTitle = "Blazor Bullet Chart Examples - Legend | Charts Demos | Syncfusion",
                HeaderText = "Blazor Bullet Chart Legend Example",
                MetaDescription = "See how the Syncfusion Blazor Legend Bullet Chart displays interactive legends with API, tooltips, and events to improve KPI understanding and navigation."
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
                MetaTitle = "Blazor Sankey Examples - Default | Charts Demos | Syncfusion",
                HeaderText = "Blazor Sankey Chart Default Example",
                MetaDescription = "See how the Syncfusion Blazor Sankey Chart visualizes flow data with weighted links between nodes for analyzing data pathways and network relationships.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-sankey"
            },
            new Sample
            {
                Name = "Vertical Mode",
                Category = "Sankey",
                Directory = "Charts/Sankey",
                Url = "sankey/vertical",
                FileName = "VerticalSankeySample.razor",
                MetaTitle = "Blazor Sankey Examples - Vertical Mode | Charts Demos | Syncfusion",
                HeaderText = "Blazor Sankey Chart Vertical Mode Example",
                MetaDescription = "See how the Syncfusion Blazor Sankey Chart in Vertical Mode renders top-to-bottom flow diagrams for hierarchical data visualization and process mapping.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "RTL",
                Category = "Sankey",
                Directory = "Charts/Sankey",
                Url = "sankey/Rtl",
                FileName = "RTLSankeySample.razor",
                MetaTitle = "Blazor Sankey Demos - RTL Examples | Charts Demos | Syncfusion",
                HeaderText = "Blazor Sankey Chart RTL Example",
                MetaDescription = "See how the Syncfusion Blazor RTL Sankey chart supports right-to-left layouts with API, nodes, and events for accurate flow visualization across RTL languages.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Print & Export",
                Category = "Sankey",
                Directory = "Charts/Sankey",
                Url = "sankey/print-export",
                FileName = "PrintExport.razor",
                MetaTitle = "Blazor Sankey Examples - Print & Export | Charts Demos | Syncfusion",
                HeaderText = "Blazor Sankey Chart Print & Export Example",
                MetaDescription = "See how the Syncfusion Blazor Print and Export Sankey chart exports flow diagrams to PNG, PDF, and SVG with API and events for easy sharing and reporting.",
                Type = SampleType.None,
            },
        };

        public List<Sample> ChartWizard { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Chart Wizard",
                Directory = "Charts/ChartWizard",
                Url = "chart-wizard/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Chart Wizard Examples - Default | Charts Demos | Syncfusion",
                HeaderText = "Blazor Chart Wizard - Interactive Chart Creation Tool",
                MetaDescription = "See how the Syncfusion Blazor Default Functionalities Chart Wizard creates charts step-by-step with API, data binding, and events for quick visualization setup.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-chart-wizard",
                Type = SampleType.None
            },

            new Sample
            {
                Name = "Integrated with Grid",
                Category = "Chart Wizard",
                Directory = "Charts/ChartWizard",
                Url = "chart-wizard/integrated-with-grid",
                FileName = "IntegratedWithGrid.razor",
                MetaTitle = "Blazor Chart Wizard Demos - Integrated with Grid | Syncfusion",
                HeaderText = "Blazor Chart Wizard - Integrated with Grid",
                MetaDescription = "See how the Syncfusion Blazor Integrated with Grid Chart Wizard builds charts from grid data using API, binding, and events for seamless visualization.",
                Type = SampleType.None
            },

            new Sample
            {
                Name = "Serialization",
                Category = "Chart Wizard",
                Directory = "Charts/ChartWizard",
                Url = "chart-wizard/serialization",
                FileName = "Serialization.razor",
                MetaTitle = "Blazor Chart Wizard - Serialization | Charts Demos | Syncfusion",
                HeaderText = "Blazor Chart Wizard - Serialization",
                MetaDescription = "See how the Syncfusion Blazor Serialization Chart Wizard saves and loads chart settings using JSON with API, persistence, and events for reusable configuration.",
                Type = SampleType.None
            }
        };
    }

}