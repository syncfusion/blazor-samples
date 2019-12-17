using System.Collections.Generic;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Chart { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Line Chart",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "Charts/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Line Chart . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the line series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the consumer price data with default line series in the chart.
                    Data points are enhanced with marker and tooltip
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the line type charts. Line type charts are used to represent time-dependent data, showing trends in data at equal intervals.
                    You can use <code>DashArray</code>, <code>Width</code>, <code>Fill</code> properties to customize the line. <code>Marker</code> and <code>DataLabel</code> are used to represent individual data and its value.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Spline Chart",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Spline",
                FileName = "Spline.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Spline Chart . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the spline series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the NC weather report for the year 2016 with default spline series in the chart. Low and high temperature of the year are indicated by using annotation.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the spline type charts. Spline chart connects each point in series through a curved line. You can use <code>DashArray</code>, <code>Width</code>, <code>Fill</code> properties to customize the spline. <code>Marker</code> and <code>DataLabel</code> are used to represent individual data and its value.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Step Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StepLine",
                FileName = "StepLine.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Step Line . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the step line series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the unemployment rate from 1975 to 2010 with default stepline series in the chart. Data points are enhanced with marker and tooltip.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the stepline type charts. This series forms the step line progress, by connecting points through vertical and horizontal lines.You can use <code>DashArray</code>, <code>Width</code>, <code>Fill</code> properties to customize the stepline. <code>Marker</code> and <code>DataLabel</code> are used to represent individual data and its value.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Dashed Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "Charts/DashedLine",
                FileName = "DashedLine.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Dashed Line . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the dashed line series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a line series with dash array. Dashed lines are animated by using css animation.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the line type charts. Line type charts are used to represent time-dependent
                    data, showing trends in data at equal intervals. You can use <code>DashArray</code>, <code>Width</code>, <code>Fill</code> properties to customize the line. <code>Marker</code> and
                    <code>DataLabel</code> are used to represent individual data and its value.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Inversed Spline",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "Charts/InversedSpline",
                FileName = "InversedSpline.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Inversed Spline . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the inversed spline series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a spline series by inversing X and Y Axis. Data points are enhanced with marker and tooltip.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the spline type charts. Spline chart connects each point in series through a curved line. You can use <code>DashArray</code>, <code>Width</code>, <code>Fill</code> properties to customize the spline. <code>Marker</code> and <code>DataLabel</code> are used to represent individual data and its value.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Line Zone",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "Charts/LineZone",
                FileName = "LineZone.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Line Zone . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Chart control shows how to render and configure the points in a particular range using MultiColoredLine series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the annual mean rainfall data with multi colored line series in the chart. Data points are enhanced with segments and tooltip.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the points in a particular range by using <code>MultiColoredLine</code> series type. Points under the range can be configured with <code>Color</code>, <code>Width</code>, and <code>DashArray</code>.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Multi Colored Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "Charts/MultiColoredLine",
                FileName = "MultiColoredLine.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Multi Colored Line . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the multi colored line series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the particulate levels in rainfall with multi colored line series in the chart. Data points are
                    enhanced with individual color and tooltip.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure each point in line type series. Multi colored line charts are used to represent time-dependent
                    data to show the trends at equal intervals with their individual colors by using <code>PointColorMapping</code>.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Stacked Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StackedLine",
                FileName = "StackedLine.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Stacked Line . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the stacked line series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the family expense data with stacked line series in the chart to identify who spent more money in each category. Data points are enhanced with marker and tooltip.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the stacked line type charts. Stacked Line type charts are used to represent time-dependent data, showing trends in data at equal intervals with stacked values of multiple series. You can use <code>DashArray</code>, <code>Width</code>, <code>Fill</code> properties to customize the line. <code>Marker</code> and <code>DataLabel</code> are used to represent individual data and its value.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "100% Stacked Line",
                Category = "Line Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StackedLine100",
                FileName = "StackedLine100.razor",
                Type = SampleType.New,
                TitleTag = "Chart . 100% Stacked Line . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the 100% stacked line series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the family expense data with stacked line series in the chart to identify who spent more money in each category. Data points are enhanced with marker and tooltip.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the stacked line type charts. 100% Stacked Line type charts are used to represent time-dependent data, showing trends in data at equal intervals with stacked values of multiple series. You can use <code>DashArray</code>, <code>Width</code>, <code>Fill</code> properties to customize the line. <code>Marker</code> and <code>DataLabel</code> are used to represent individual data and its value.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Area",
                FileName = "Area.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Area . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control shows how to render and configure the area series chart.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the data about average sales comparison of two products by using default area series in the chart. Legend in the sample shows the information about the series.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the area type charts. Similar to line type series, but the area get closed and filled with series color. You can use <code>DashArray</code>, <code>Width</code>, <code>Fill</code> properties to customize the spline. <code>Marker</code> and <code>DataLabel</code> are used to represent individual data and its value. Legend is enabled in this example with series type shape.
                </p>"
                }
            },
            new Sample
            {
                Name = "Spline Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "Charts/SplineArea",
                FileName = "SplineArea.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Spline Area . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the spline area series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the data about inflation rate comparision for three countries by using spline area series in the chart. Legend in the sample shows the information about the series.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the stacking area type charts. Stacks the series on top of another series to avoid the overlapping of series with one another, when rendering more than one area series in same chart. You can use <code>DashArray</code>, <code>Width</code>, <code>Fill</code> properties to customize the area. <code>Marker</code> and <code>DataLabel</code> are used to represent individual data and its value.
                </p>"
                }
            },
            new Sample
            {
                Name = "Step Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StepArea",
                FileName = "StepArea.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Step Area . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the step area series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the data about electricity production by using renewable and non-renewable resources by using default step area series in the chart.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the StepArea type charts. This series forms the step line progress, by connecting points through vertical and horizontal lines with area filled. You can use <code>DashArray</code>, <code>Width</code>, <code>Fill</code> properties to customize the area. <code>Marker</code> and <code>DataLabel</code> are used to represent individual data and its value.
                </p>"
                }
            },
            new Sample
            {
                Name = "Range Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "Charts/RangeArea",
                FileName = "RangeArea.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Range Area . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the range area series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the maximum and minimum temperatures of different months with default range area series in the chart. Zoom the chart to check the temperature for week or day.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the range area type chart. You can use <code>Border</code>, <code>Fill</code> properties to customize the area.
                </p>"
                }
            },
            new Sample
            {
                Name = "Stacked Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StackedArea",
                FileName = "StackedArea.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Stacked Area . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the stacking area series.",
                ActionDescription = new string[] {
                    @"<p>
                    Trend in the sales of ethical product is visualized with default stacked area series in chart. Legend in the sample shows the information about the series.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the stacking area type charts. Stacks the series on top of another series to avoid the overlapping of series with one another, when rendering more than one area series in same chart. You can use <code>DashArray</code>, <code>Width</code>, <code>Fill</code> properties to customize the spline. <code>Marker</code> and <code>DataLabel</code> are used to represent individual data and its value. Legend is enabled in this example with series type shape.
                </p>"
                }
            },
            new Sample
            {
                Name = "100% Stacked Area",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StackedArea100",
                FileName = "StackedArea100.razor",
                Type = SampleType.New,
                TitleTag = "Chart . 100% Stacked Area . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the 100 percent stacking area series.",
                ActionDescription = new string[] {
                    @"<p>
                    Percentage of sales for four ethical products are visualized with default 100% stacked area series in chart. Legend in the sample shows the information about the series.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the 100% stacking area type charts. You can use fill properties to customize the 100% stacking area.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Area Empty",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "Charts/AreaEmpty",
                FileName = "AreaEmpty.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Area Empty . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the area series chart with empty points.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates an area series with empty points. Data points with null points are dropped here.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    n this example, you can see how to render a area series with empty points. Similar to line type series, but the area get closed and filled with series color. You can use <code>DashArray</code>, <code>Width</code>, <code>Fill</code> properties to customize the spline. <code>Marker</code> and <code>DataLabel</code> are used to represent individual data and its value. Legend is enabled in this example with series type shape.
                </p>"
                }
            },
            new Sample
            {
                Name = "Area Zone",
                Category = "Area Charts",
                Directory = "Charts/Chart",
                Url = "Charts/AreaZone",
                FileName = "AreaZone.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Area Zone . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render the points in a particular range using MultiColoredArea series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the organic revenue data with multi colored area series in the chart. Data points are enhanced with segments and tooltip.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the points in a particular range by using MultiColoredArea series type. Points under the range can be configured with <code>Color</code>, <code>Width</code>, and <code>DashArray</code>.
                </p>
                    <p>
                    </p>"
                }
            },
            new Sample
            {
                Name = "Column Chart",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Column",
                FileName = "Column.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Column Chart . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the column series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the Olympic medal count in Rio with default column series in the chart.
                    Data points values are showed by using data label.

                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the column type charts. Column type charts are used for comparing
                    the frequency, count, total or average of data in different categories. You can use <code>Border</code>,
                    <code>Fill</code> properties to customize the vertical rectangle. <code>DataLabel</code> is used to represent individual
                    data and its value.

                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Rounded Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/RoundedColumn",
                FileName = "RoundedColumn.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Rounded Column . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the rounded column series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the Olympic medal count in Rio with default column series in the chart.
                    Data points values are showed by using data label.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the column type charts. Column type charts are used for comparing
                    the frequency, count, total or average of data in different categories. You can use <code>Border</code>,
                    <code>Fill</code> properties to customize the vertical rect. <code>DataLabel</code> is used to represent individual
                    data and its value.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Column Placement",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/ColumnPlacement",
                FileName = "ColumnPlacement.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Column Placement . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the column charts.",
                ActionDescription = new string[] {
                    @"<p>
                This sample illustrates four column series. Each column is rendered with different column width and it is placed  behind to another one.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the column type charts. Column type charts are used for comparing
                    the frequency, count, total or average of data in different categories. You can use <code>Border</code>,
                    <code>Fill</code> properties to customize the vertical rect. <code>DataLabel</code> is used to represent individual
                    data and its value. You can enable side by side position by <code>enableSideBySidePlacement</code> property.

                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Range Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/RangeColumn",
                FileName = "RangeColumn.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Range Column . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the range column series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the maximum and minimum temperatures for a week of different countries with default range column series in the chart. Tooltip shows the information about the data points.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the range column type chart. You can use <code>Border</code>,
                    <code>Fill</code> properties to customize the columns. <code>DataLabel</code> are used to represent individual data
                    and its value.
                    </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Range Bar",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/RangeBar",
                FileName = "RangeBar.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Range Bar . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the inversed range column series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a range column series by inversing its X and Y  Axes. Tooltip shows the information about the data points.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the range column type chart with inverted manner. You can use <code>Border</code>,
                    <code>Fill</code> properties to customize the columns. <code>DataLabel</code> are used to represent individual data
                    and its value.

                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Bar Chart",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Bar",
                FileName = "Bar.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Bar Chart . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the bar series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the data about UK trade in food groups of the year 2015 with default bar series in the chart.
                    Data points values are showed by using data label.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the bar type charts. Similar to column charts, but the orientation of y axis is horizontal instead of vertical.
                    You can use <code>Border</code>, <code>Fill</code> properties to customize the data appearance. <code>DataLabel</code> is used to represent individual data and its value.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Stacked Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StackedColumn",
                FileName = "StackedColumn.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Stacked Column . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the stacking column series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes mobile game market for different countries with default stacked column series in chart. Legend in the sample shows the information about those series.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the stacking column type charts. Stacks the points in the series vertically and also you can use <code>StackingGroup</code> property to group the stacking collection based on categories.
                    You can use <code>Border</code>, <code>Fill</code> properties to customize the vertical bar. <code>DataLabel</code> is used to represent individual data and its value.
                    </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "100% Stacked Column",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StackedColumn100",
                FileName = "StackedColumn100.razor",
                Type = SampleType.New,
                TitleTag = "Chart . 100% Stacked Column . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the 100 percent stacking column series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes percentage of domestic product growth of four different countries with default 100% stacked column series in chart. 
                    Legend in the sample shows the information about the series.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the 100% stacking column type charts. You can use <code>Border</code>,
                    <code>Fill</code> properties to customize the vertical bar.
                    </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Stacked Bar",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StackedBar",
                FileName = "StackedBar.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Stacked Bar . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the stacking bar series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes sales comparison of different fruits with default stacked bar series in chart. Legend in the sample shows the information about the series.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the stacking bar type charts. Stacks the points in the series horizontally and also you can use <code>StackingGroup</code> property to group the stacking collection based on categories.
                    You can use <code>Border</code>, <code>Fill</code> properties to customize the vertical bar. <code>DataLabel</code> is used to represent individual data and its value.

                    </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "100% Stacked Bar",
                Category = "Bar Charts",
                Directory = "Charts/Chart",
                Url = "Charts/StackedBar100",
                FileName = "StackedBar100.razor",
                Type = SampleType.New,
                TitleTag = "Chart . 100% Stacked Bar . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the 100 percent stacking bar series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes percentage of sales comparison for different fruits with default 100% stacked bar series in chart. Legend in the sample shows the information about the series.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the stacking bar type charts. Stacks the points in the series horizontally and also you can use <code>StackingGroup</code> property to group the stacking collection based on categories.
                    You can use <code>Border</code>, <code>Fill</code> properties to customize the vertical bar. <code>DataLabel</code> is used to represent individual data and its value.

                    </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
			// new Sample
			// {
			//    Name = "Negative Stack",
			//    Category = "Bar Charts",
			//    Directory = "Charts/Chart",
			//    Url = "Charts/NegativeStack",
			//    FileName = "NegativeStack.razor",
			//    Type = SampleType.New,
            //    ActionDescription = new string[] {
            //         @"<p>
            //         This sample illustrates stacked bar with negative data points. Data points values are showed by using data label.
            //     </p>"
            //     },
            //     Description = new string[] {
            //         @"<p>
            //     In this example, you can see how to render and configure the bar type charts. Similar to column charts, but the orientation of y axis is horizontal instead of vertical.
            //         You can use <code>Border</code>, <code>Fill</code> properties to customize the data appearance. <code>DataLabel</code> is used to represent individual data and its value.
            //     </p>
            //     <p>
            //         Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
            //     </p>"
            //     }
			// },
			 new Sample
            {
                Name = "Scatter Plot",
                Category = "Scatter and Bubble",
                Directory = "Charts/Chart",
                Url = "Charts/Scatter",
                FileName = "Scatter.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Scatter Plot . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the scatter series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample compares the height and weight of the genders by using default scatter series in the chart. Tooltip shows the information about the data.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the scatter type charts. Scatter charts are used to plot financial or scientific data. You can use shape property in the marker to change the scatter shape. dataLabel is used to represent individual data value.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Bubble",
                Category = "Scatter and Bubble",
                Directory = "Charts/Chart",
                Url = "Charts/Bubble",
                FileName = "Bubble.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Bubble . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the bubble series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the Literacy Rate and GDP Growth Rate of world countries by using bubble series in the chart. Tooltip shows the information about the countries.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the bubble type charts.A bubble chart is a type of chart that displays three dimensions of data. Each points is drawn as a bubble, where bubble's size depends on <code>Size</code> property. You can use <code>Fill</code> property to customize the data appearance.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Waterfall",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "Charts/Waterfall",
                FileName = "Waterfall.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Waterfall . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the waterfall series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the revenue and profits of a company by using default waterfall series in the chart. Tooltip shows the information about the profits earned by each department on the company.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Waterfall type chart. You can use <code>DashArray</code>, <code>Width</code>, <code>Fill</code> properties to customize the spline. <code>Marker</code> and <code>DataLabel</code> are used to represent individual data and its value.
                </p>
                <p>
                Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Histogram",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "Charts/Histogram",
                FileName = "Histogram.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Histogram . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the histogram series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the student's results of the final examination with histogram series in chart.
                    Number of students between each interval is shown by using the data label.

                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the histogram type charts. Histogram type charts can provide a visual
                    display of large amounts of data that are difficult to understand in a tabular or spreadsheet form. You can use the <code>Border</code> and <code>Fill</code>
                    properties to customize the vertical rectangle. The <code>DataLabel</code> property is used to represent individual data and its value.

                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Box and Whisker",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "Charts/BoxandWhisker",
                FileName = "BoxandWhisker.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Box and Whisker . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the box and whisker series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the employees’ age group in various departments of a country with box and whisker type series in the chart. Mode of box and whisker series can be changed by <code>Mode</code> in property panel. To display the <code>mean</code> value in a series, enable the Mean in the property panel.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                In this example, you can see how to render and configure the box and whisker type charts. Similar to line type series, but
                the area get closed and filled with series color. You can use <code>Border</code>, <code>Fill</code> properties
                to customize the area. <code>Marker</code> and <code>DataLabel</code> are used to represent individual data and its
                value. Legend is enabled in this example with series type shape.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Error Bar",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "Charts/ErrorBar",
                FileName = "ErrorBar.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Error Bar . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the error bars in charts.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the errors in sales distribution of a car for a certain period with error bar in the chart. In property panel, the options are available to change error bar type, drawing mode, and drawing direction of error bar by means of dropdown.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the error bar charts. Line type charts are used for cartesian type
                    series. You can use error bar by set
                    <code>visible</code> property to true. You can change the error bar rendering type using
                    <code>type</code> property like fixedValue, percentage, standardDeviation, standardError and custom option of errorBar. To change
                    the error bar line length you can use
                    <code>verticalError</code> property.
                </p>
                <p>
                    Chart supports the following error bar types.
                </p>
            <ul>
                    <li>
                        <code>Fixed</code> - Renders a fixed type error bar.
                    </li>
                    <li>
                        <code>Percentage</code> - Renders a percentage type error bar.
                    </li>
                    <li>
                        <code>StandardDeviation</code> - Renders a standard deviation type error bar.
                    </li>
                    <li>
                        <code>StandardError</code> - Renders a standard error type error bar.
                    </li>
                    <li>
                        <code>Custom</code> - Renders a custom type error bar.
                    </li>
                </ul>"
                }
            },
            new Sample
            {
                Name = "Trendlines",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "Charts/Trendlines",
                FileName = "Trendlines.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Trendlines . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the trend lines in charts.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the trend of Indian rupees and US dollar variation with trendline in the chart.
                    The type of trend line can be changed by using <code>TrendLine Type</code>, forward and backward forecasting of trendlines can be changed by <code>Forward Forecasting</code> and <code>Backward Forecast</code> respectively.
                    Polynomial and period for a trendlines can be changed by using <code>Polynomial order</code> and <code>Period</code>.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                In this example, you can see how to render and configure the Trend Lines. You can use
                    <code>Border</code>,
                    <code>Fill</code> properties to customize the area.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Multi Series Chart",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "Charts/MultiSeriesChart",
                FileName = "MultiSeriesChart.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Multi Series Chart . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to combine different types of charts.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a combination of line and stacked column series. Tooltip shows the information about the data point.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the different type of charts. You can render any combination of series in chart except bar.
                    </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Pareto",
                Category = "Other Types",
                Directory = "Charts/Chart",
                Url = "Charts/Pareto",
                FileName = "Pareto.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Pareto . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure pareto charts.",
                ActionDescription = new string[] {
                    @"<p>
                This sample illustrates a pareto chart with line and column series. Trackball shows the information about the data point closest to the mouse.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the pareto charts. Pareto charts are used to find the cumulative values of of data in different categories. 
                    You can use <code>Border</code>, <code>Fill</code> properties to customize the data appearance. <code>DataLabel</code> is used to represent individual data and its value.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Hilo",
                Category = "Stock Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Hilo",
                FileName = "Hilo.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Hilo . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the hilo series.",
                ActionDescription = new string[] {
                    @"This sample visualizes the AAPL historical data with default HILO series in the chart. Tooltip and crosshair show the information about the data and period."
                },
                Description = new string[] {
                    @"In this example, you can see how to render and configure the Hilo type series. You can use <code>Border</code>, <code>Fill</code> properties to customize the area.

                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices."
                }
            },
            new Sample
            {
                Name = "Hilo Open Close",
                Category = "Stock Charts",
                Directory = "Charts/Chart",
                Url = "Charts/HiloOpenClose",
                FileName = "HiloOpenClose.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Hilo Open Close . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the hilo open close series.",
                ActionDescription = new string[] {
                    @"This sample visualizes the AAPL historical data with default HILO Open Close series in the chart. Tooltip and crosshair show the information about the data and period."
                },
                Description = new string[] {
                    @"In this example, you can see how to render and configure the Hilo type series. You can use <code>Border</code>, <code>Fill</code> properties to customize the area.

                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices."
                }
            },
            new Sample
            {
                Name = "Candle Stick",
                Category = "Stock Charts",
                Directory = "Charts/Chart",
                Url = "Charts/CandleStick",
                FileName = "CandleStick.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Candle Stick . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the candle series.",
                ActionDescription = new string[] {
                    @"This sample visualizes the AAPL historical data with default candle series in the chart. Tooltip and crosshair show the information about the data and period."
                },
                Description = new string[] {
                    @"In this example, you can see how to render and configure the Hilo type series. You can use <code>Border</code>, <code>Fill</code> properties to customize the area.

                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices."
                }
            },
			new Sample
            {
                Name = "Accumulation Distributions",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/ADIChart",
                FileName = "ADIChart.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Accumulation Distributions . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the accumulation distribution indicator.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a stock chart with candle series and an accumulation distribution indicator. Trackball shows the information about the stock and signal value of a day.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Accumulation Distribution Indicator. You can use <code>Border</code>,
                        <code>Fill</code> properties to customize the area.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "ATR",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/ATRChart",
                FileName = "ATRChart.razor",
                Type = SampleType.New,
                TitleTag = "Chart . ATR . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the average true range indicator.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a stock chart with candle series and an average true range indicator.
                    Trackball shows the information about the stock and signal value of a day.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Average True Range Indicator. You can use <code>Border</code>,
                    <code>Fill</code> properties to customize the area.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Bollinger",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/BollingerChart",
                FileName = "BollingerChart.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Bollinger . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the bollinger band type indicator.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a stock chart with candle series and a Bollinger band indicator.
                    Trackball shows the information about the stock, signalline, upperline, and lowerline value of a day.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the BollingerBands type Indicator. You can use <code>Border</code>,
                    <code>Fill</code> properties to customize the area.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "EMA",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/EmaChart",
                FileName = "EmaChart.razor",
                Type = SampleType.New,
                TitleTag = "Chart . EMA . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the exponential moving average indicator.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a stock chart with candle series and an Exponential Moving Average indicator.
                    Trackball shows the information about the stock and signal value of a day.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the EMA Indicator. You can use
                    <code>Fill</code> properties to customize the indicator.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "MACD",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/MacdChart",
                FileName = "MacdChart.razor",
                Type = SampleType.New,
                TitleTag = "Chart . MACD . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the moving average convergence divergence indicator.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a stock chart with candle series and a Moving Average Convergence Divergence indicator. Trackball shows the information about the stock, signalline, Macdline, and Histogram value of a day.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the MACD Indicator. You can use <code>Border</code>,
                    <code>Fill</code> properties to customize the area.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Momentum",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/MomentumChart",
                FileName = "MomentumChart.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Momentum . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the momentum indicator.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a stock chart with candle series and a momentum indicator. Trackball shows the information about the stock, signalline, and upperline value of a day.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Momentum Indicator. You can use <code>Border</code>,
                    <code>Fill</code> properties to customize the area.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "RSI",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/RsiChart",
                FileName = "RsiChart.razor",
                Type = SampleType.New,
                TitleTag = "Chart . RSI . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the relative strength index indicator.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a stock chart with candle series and a Relative Strength Index indicator. Trackball shows the information about the stock, signalline, lowerline, and upperline value of a day.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the RSI Indicator. You can use <code>Border</code>,
                    <code>Fill</code> properties to customize the area.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "SMA",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/SmaChart",
                FileName = "SmaChart.razor",
                Type = SampleType.New,
                TitleTag = "Chart . SMA . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the simple moving average indicator.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a stock chart with candle series and a Simple Moving Average indicator. Trackball shows the information about the stock and signal value of a day.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the SMA Indicator. You can use <code>Border</code>,
                    <code>Fill</code> properties to customize the area.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Stochastic",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/StochasticChart",
                FileName = "StochasticChart.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Stochastic . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the stochastic indicator.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a stock chart with candle series and an Stochastic indicator. Trackball shows the information about the stock and indicator value of a day.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Stochastic Indicator.You can use <code>Border</code>,
                        <code>Fill</code> properties to customize the area.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "TMA",
                Category = "Technical Indicators",
                Directory = "Charts/Chart",
                Url = "Charts/TmaChart",
                FileName = "TmaChart.razor",
                Type = SampleType.New,
                TitleTag = "Chart . TMA . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the triangular moving average indicator.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a stock chart with candle series and a Triangle Moving Average indicator. Trackball shows the information about the stock and signal value of a day.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the TMA Indicator. You can use <code>Border</code>,
                    <code>Fill</code> properties to customize the area.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
             new Sample
            {
                Name = "Performance",
                Category = "BenchMark",
                Directory = "Charts/Chart",
                Url = "Charts/Performance",
                Type = SampleType.New,
                FileName = "Performance.razor",               
                TitleTag = "Chart . Performance . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to check performance in Chart.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the performance of EJ2 chart to render 100K points in canvas mode.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                   Chart includes several data rendering optimizations to achieve the best possible performance when plotting large volumes of data as well as handling high frequency real-time data.In this demo, chart is rendered with 100K points in canvas mode.
                </p>
               "
                }
            },
            new Sample
            {
                Name = "Pie Chart",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Pie",
                FileName = "Pie.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Pie Chart . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the pie charts.",
                ActionDescription = new string[] {
                    @"This sample demonstrates pie chart for mobile browser usage statistics. Datalabel shows the Information about the points."
                },
                Description = new string[] {
                    @"In this example, you can see how to render and configure the pie chart. You can use <code>Border</code>, <code>Fill</code> properties to customize the pie point. <code>DataLabel</code> is used to represent individual data and its value.

                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices."
                }
            },
            new Sample
            {
                Name = "Pie Radius",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "Charts/PieRadius",
                FileName = "PieRadius.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Pie Radius . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the various radius pie chart.",
                ActionDescription = new string[] {
                    @"This sample compares countries by population density and total area by using the various radius in pie series."
                },
                Description = new string[] {
                    @"In this example, you can see how to render doughnut chart with different radius. You can use <code>radius</code> mapping property to achieve this feature. <code>DataLabel</code> is used to represent individual data and its value.

                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices."
                }
            },
            new Sample
            {
                Name = "Donut Chart",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Donut",
                FileName = "Donut.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Donut Chart . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the doughnut charts.",
                ActionDescription = new string[] {
                    @"This sample visualizes the project cost breakdown statistics by using doughnut series. Datalabel shows the Information about the points."
                },
                Description = new string[] {
                    @"In this example, you can see how to render and configure the pyramid chart. You can use <code>Border</code>, <code>Fill</code> properties to customize the pie point. <code>DataLabel</code> is used to represent individual data and its value.

                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices."
                }
            },
            new Sample
            {
                Name = "Pyramid",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Pyramid",
                FileName = "Pyramid.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Pyramid . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the pyramid charts.",
                ActionDescription = new string[] {
                    @"This sample visualizes food comparison data by using pyramid series. Datalabel shows the Information about the points."
                },
                Description = new string[] {
                    @"In this example, you can see how to render and configure the pyramid chart. You can use <code>Border</code>, <code>Fill</code> properties to customize the pie point. <code>DataLabel</code> is used to represent individual data and its value.

                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices."
                }
            },
            new Sample
            {
                Name = "Funnel Chart",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Funnel",
                FileName = "Funnel.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Funnel Chart . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the funnel charts.",
                ActionDescription = new string[] {
                    @"This sample demonstrates funnel chart for Project Cost Breakdown. Datalabel shows the Information about the points."
                },
                Description = new string[] {
                    @"In this example, you can see how to render and configure the funnel chart. You can use <code>Border</code>, <code>Fill</code> properties to customize the pie point. <code>DataLabel</code> is used to represent individual data and its value.

                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices."
                }
            },
            new Sample
            {
                Name = "Pie With Legend",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "Charts/PieLegend",
                FileName = "PieLegend.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Pie With Legend . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the legends in pie charts.",
                ActionDescription = new string[] {
                    @"This sample demonstrates pie chart with legend. For pie chart, you can change start angle of chart by Pie Angle in properties panel. Outer radius for pie chart can be changed by Outer Radius. Explode Index and explode radius for chart can be changed by Explode Radius and Explode Index."
                },
                Description = new string[] {
                    @" In this example, you can see how to render and configure the pie chart. You can use border, fill properties to customize the pie point. dataLabel is used to represent individual data and its value.

                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices."
                }
            },
            new Sample
            {
                Name = "Semi Pie",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "Charts/SemiPie",
                FileName = "SemiPie.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Semi Pie . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render semi-pie and doughnut charts.",
                ActionDescription = new string[] {
                    @"This sample illustrates the agriculture land percentages of various countries by using a pie series. It has options to change the angle and radius of the series."
                },
                Description = new string[] {
                    @"<p> In this example, you can see how to render semi pie and doughnut chart. Using <code>startAngle</code>, <code>endAngle</code> properties, we can achieve this semi pie chart. Property panel to change the angle is provided with this sample.</p>

                    <p> <code>Tooltip</code> is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.</p>"
                }
            },
            new Sample
            {
                Name = "Smart Labels",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "Charts/SmartLabels",
                FileName = "SmartLabels.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Smart Labels . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to arrange the labels smartly without overlapping with each other.",
                ActionDescription = new string[] {
                    @"This sample illustrates the Rio Olympic’s gold medal count by using smart labels in the chart. The smart label placement for a series can be shown, when it contains more of points."
                },
                Description = new string[] {
                    @"<p> In this example, you can see how to arrange the labels smartly without overlapping with each other. You can use <code>EnableSmartLabels</code> property to enable or disable the action. Legend with paging is enabled in this sample.</p>

                    <p> <code>Tooltip</code> is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.</p>"
                }
            },
            new Sample
            {
                Name = "Grouping",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "Charts/Grouping",
                FileName = "Grouping.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Grouping . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to group points in pie charts.",
                ActionDescription = new string[] {
                    @"This sample illustrates the grouping functionality in pie series. The grouping value can be changed by using <code>GroupTo</code> property."
                },
                Description = new string[] {
                    @"<p> In this example, you can see how to <code>Group</code> points in pie chart.</p>

                    <p> <code>Tooltip</code> is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.</p>
                    <p>DataLabel is used to represent individual data and its value.</p>"
                }
            },
            new Sample
            {
                Name = "Empty Points",
                Category = "Accumulation Charts",
                Directory = "Charts/Chart",
                Url = "Charts/EmptyPoints",
                FileName = "EmptyPoints.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Empty Points . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the empty points.",
                ActionDescription = new string[] {
                    @"This sample illustrates an organization’s annual product-wise profit analysis with the empty point functionality in pie series."
                },
                Description = new string[] {
                    @"In this example, you can see how to render and configure the empty points. You can use <code>Border</code>, <code>Fill</code>, <code>Mode</code> properties to customize the empty points.

                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices."
                }
            },
            new Sample
            {
                Name = "Polar Line",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "Charts/PolarLine",
                FileName = "PolarLineChart.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Polar Line . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render line in polar and radar charts.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the data about Alaska Weather Statistics - 2016 with default polar line series in the chart.
                    Data points values are showed by using data label.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the polar line type charts. Similar to column charts, but the orientation of y axis is horizontal instead of vertical.
                    You can use <code>Border</code>, <code>Fill</code> properties to customize the data appearance. <code>DataLabel</code> is used to represent individual data and its value.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Polar Area",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "Charts/PolarArea",
                FileName = "PolarArea.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Polar Area . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render area in polar and radar charts.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates polar series with area type for average sales comparison of products in recent year.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the line type charts. Line type charts are used to represent time-dependent data, showing trends in data at equal intervals.
                    You can use <code>DashArray</code>, <code>Width</code>, <code>Fill</code> properties to customize the line. <code>Marker</code> and <code>DataLabel</code> are used to represent individual data and its value.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Polar StackedArea",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "Charts/PolarStackedArea",
                FileName = "PolarStackedArea.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Polar StackedArea . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render stacking area in polar and radar charts.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates polar series with stacking area type for GDP of different countries in recent years.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render and configure the stacking area type charts. Stacks the series on top of another series to avoid the overlapping of series with one another, when rendering more than one area series in same chart.
                        You can use <code>Fill</code> properties to customize the stacked area. <code>DataLabel</code> is used to represent individual data and its value.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Polar Scatter",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "Charts/PolarScatter",
                FileName = "PolarScatter.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Polar Scatter . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render scatter in polar and radar charts.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates polar series with scatter type for GDP for different countries in recent years.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render and configure the scatter type charts. Scatter charts are used to plot financial or scientific data. 
                        You can use <code>Shape</code> property in the marker to change the scatter shape. <code>DataLabel</code> is used to represent individual data value.
                    </p>
                    <p>
                        Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Polar Column",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "Charts/PolarColumn",
                FileName = "PolarColumn.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Polar Column . Syncfusion Blazor Components",
                MetaDescription = "This demo sample, for Essential Blazor Chart control demonstrates how to render column in polar and radar charts.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates polar series with column type for mobile market subscriptions in different countries.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render and configure the column type charts. Column type charts are used for comparing the frequency, 
                        count, total or average of data in different categories. You can use <code>Border</code>, <code>Fill</code> properties to customize the vertical rect. 
                        <code>DataLabel</code> is used to represent individual data and its value.
                    </p>
                    <p>
                        Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Wind Rose",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "Charts/Polar",
                FileName = "Polar.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Wind Rose . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render wind rose using stacking column in polar and radar charts.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates polar series with stacking column type. The switching between polar and radar series can be done by using <code>Series Type</code> in property panel.
                    </p>"
                },
                Description = new string[] {
                @"<p>
                        In this example, you can see how to render and configure the stacking column type charts. Stacks the points in the series
                        vertically and also you can use <code>StackingGroup</code> property to group the stacking collection based
                        on categories. You can use <code>Border</code>, <code>Fill</code> properties to customize the vertical bar. <code>DataLabel</code>        is used to represent individual data and its value.
                    </p>
                    <p>
                        Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                    </p>"
            }
            },
            new Sample
            {
                Name = "Polar RangeColumn",
                Category = "Polar and Radar",
                Directory = "Charts/Chart",
                Url = "Charts/PolarRangeColumn",
                FileName = "PolarRangeColumn.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Polar RangeColumn . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render range column in polar and radar charts.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates polar series with range column type for temperature variation.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the range column type chart You can use <code>Border</code>, 
                    <code>Fill</code> properties to customize the area. <code>DataLabel</code> are used to represent individual data and its value.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Charts/Chart",
                Url = "Charts/LocalData",
                FileName = "LocalData.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Local Data . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to bind JSON data to chart.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates plotting of local data about stock price analysis of two products for a certain period.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    For fetching data for chart, local data can be used.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Charts/Chart",
                Url = "Charts/RemoteData",
                FileName = "RemoteData.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Remote Data . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to consume data from remote data service.",
                ActionDescription = new string[] {
                    @"This sample illustrates how to retrieve remote the data for chart."
                },
                Description = new string[] {
                    @"<p>The Chart supports data binding. The <code>DataSource</code> property can be assigned with the instance of <code>DataManager</code> to bind remote data.</p>
                    <p>The DataManager, which will act as an interface between the service endpoint and the chart, will require the below minimal information to interact with service endpoint properly.</p>
                    <ul>
                        <li><code>DataManager->Url</code> - Defines the service endpoint to fetch data</li>
                        <li><code>DataManager->Adaptor</code> - Defines the adaptor option. By default, <code>ODataAdaptor</code> is used for remote binding.</li>
                    </ul>"
                }
            },
            new Sample
            {
                Name = "Numeric Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/NumericAxis",
                FileName = "NumericAxis.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Numeric Axis . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to plot numeric data with the help of numeric axis in charts.",ActionDescription = new string[] {
                    @"<p>
                This sample demonstrates the rendering of numeric axis in the chart with England and West indies cricket match data.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Numeric axis is used to plot numeric data in chart. To render numeric axis, set <code>ValueType</code> in axis to <code>Double</code>.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "DateTime Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/DateTimeAxis",
                FileName = "DateTimeAxis.razor",
                Type = SampleType.New,
                TitleTag = "Chart . DateTime Axis . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the date-time axis in charts.",
                ActionDescription = new string[] {
                    @"<p>
                This sample demonstrates the rendering of date time axis in the chart with weather statistics analysis of Alaska for a year.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    DateTime data is used in this sample and data values are represented using dataLabel. Date time axis uses date time scale and displays the date time values as axis labels. To render dateTime axis, set <code>ValueType</code> in axis to <code>DateTime</code>.
                        Format for the axis label will be calculated based on intervalType of axis or we can set the format through labelFormat property in axis.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "DateTime Category Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/DateTimeCategoryAxis",
                FileName = "DateTimeCategoryAxis.razor",
                Type = SampleType.New,
                TitleTag = "Chart . DateTime Category Axis . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the date-time category axis in charts.",
                ActionDescription = new string[] {
                    @"<p>
                This sample illustrates sales of a product in business days.
                        Data points in this sample are enhanced with tooltip.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this sample, you can see how to render and configure the date time category axis.
                        Date time category axis is used to represent only business days in datetime axis.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Category Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/CategoryAxis",
                FileName = "CategoryAxis.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Category Axis . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the category axis in charts.",
                ActionDescription = new string[] {
                    @"<p>
                This sample demonstrates the rendering of category axis in the chart with internet users of different countries.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Category axis is used to represent the categories in data. To render category axis, set <code>ValueType</code> in axis to <code>Category</code>.
                        Category label can placed between the ticks or on the ticks, based on <code>LabelPlacement</code> property.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Indexed category axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/IndexedCategoryAxis",
                FileName = "IndexedCategoryAxis.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Indexed category axis . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the indexed category axis in charts.",
                ActionDescription = new string[] {
                    @"<p>
                In this example, you can see how to indexed axis in chart. For indexed category axis you can use <code>IsIndexed</code> property.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to indexed axis in chart. For indexed category axis you can use <code>IsIndexed</code> property.
                </p>
                <p>
                    Hover the chart area to view trackball and its tooltip. Touch and hold to enable trackball in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Logarithmic Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/LogarithmicScale",
                FileName = "LogarithmicScale.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Logarithmic Axis . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the logarithmic axis in charts.",
                ActionDescription = new string[] {
                    @"<p>
                This sample demonstrates the rendering of logarithmic axis in the chart.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Logarithmic axis uses logarithmic scale and it is very useful in visualizing when the data has values with both lower order of magnitude (eg: 10^-6) and higher order of magnitude (eg: 10^6).
                        To render Logarithmic axis, set <code>ValueType</code> in axis to <b>Logarithmic</b>.
                </p>"
                }
            },
            new Sample
            {
                Name = "Multiple Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/MultipleAxis",
                FileName = "MultipleAxis.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Multiple Axis . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the mulitple axis in charts.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates multiple axis in chart to represent the temperature in Celsius in an axis and Fahrenheit in another axis.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure multipe axes. Use axes collection to render secondary axis to the chart and bind it to the specify series. You can also customize the axis line and its labels similar to primary axis.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Inversed Axis",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/InversedAxis",
                FileName = "InversedAxis.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Inversed Axis . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to invert the axis in charts.",
                ActionDescription = new string[] {
                    @"<p>
                This sample illustrates inversed axis in chart to plot exchange rate over a period.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to inverse an axis in chart. Here both the X and Y axis are inversed using <code>IsInversed</code> property.
                </p>
                <p> DataLabel are used to represent individual data and its value.</p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "StripLine",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/StripLine",
                FileName = "StripLine.razor",
                Type = SampleType.New,
                TitleTag = "Chart . StripLine . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the strip lines in charts.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample highlights certain range in an axis by using stripline feature.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the stripline charts. You can use stripline by enable the <code>Visible</code> property. Striplines are rendered in the specified 
                    <code>Start</code> and <code>End</code> range and you can add more than one stripline for an axis.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "StripLine Recurrence",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/StripLineRecurrence",
                FileName = "StripLineRecurrence.razor",
                Type = SampleType.New,
                TitleTag = "Chart . StripLine Recurrence . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the strip line recurrence in charts.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the World Population Report with default column series in the chart. Data points values are showed by using data label.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the stripline in chart. Striplines are used to annotate the highlighted region with some notes. You can use <code>Border</code>,
                    <code>Fill</code> <code>DashArray</code> properties to customize the striplines.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Smart Axis Labels",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/SmartAxisLabels",
                FileName = "SmartAxisLabels.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Smart Axis Labels . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to arrange the labels smartly without overlapping with each other.",
                ActionDescription = new string[] {
                    @"<p>
                This sample illustrates Internet users in millions by using smart labels in the chart. The smart label placement for a series can be shown, when it contains more of points.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to arrange the axis labels and how to trim the axis label smartly. When the Axis labels overlap with each other based on the chart dimensions and label size, you can use the <code>labelIntersectAction</code> property of the axis to avoid overlapping.
                </p>
                <p>
                    Chart supports the following by which can be set using <code>labelIntersectAction</code> property.
                </p>
                <ul>
                        <li><code>Hide</code> - Hide the label when it intersect.</li>
                        <li><code>Trim</code> - Trim the label when it intersect.</li>
                        <li><code>Wrap</code> - Wrap the label when it intersect.</li>
                        <li><code>MultipleRows</code> - Arrange the label in multiple row when it intersect.</li>
                        <li><code>Rotate45</code> - Rotate the label to 45 degree when it intersect.</li>
                        <li><code>Rotate90</code> - Rotate the label to 90 degree when it intersect.</li>
                        <li><code>None</code> - Shows all the labels.</li>
                    </ul>

                <br>
                <p>
                        Chart supports three types of edge labels placement which can be set using <code>edgeLabelPlacement</code> property.
                    </p>
                <ul>
                        <li><code>None</code> - No action will be performed.</li>
                        <li><code>Hide</code> - Edge label will be hidden .</li>
                        <li><code>Shift</code> - Shifts the edge labels.</li>
                </ul>"
                }
            },
            new Sample
            {
                Name = "Axis Crossing",
                Category = "Chart Axes",
                Directory = "Charts/Chart",
                Url = "Charts/AxisCrossing",
                FileName = "AxisCrossing.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Axis Crossing . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates the behaviour of the axis crossing in chart.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates an interpolation of data points between linear and cubic by using spline and line series.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    This sample demonstrates the axis crossing behavior in chart. Axis can be positioned anywhere in the chart area by using the crossesAt property of axis. This property specifies where the horizontal axis should intersect or cross the vertical axis and vice-versa.
                </p>
                <p>
                    Default value of crossesAt property is null. So, you can use placeNextToAxisLine property to place the axis labels and ticks next to axis line. When there are multiple axes, you can choose an axis to cross by using crossesInAxis property. If the axis name is not valid, primaryXAxis or primaryYAxis will be used for crossing, by default.
                </p>"
                }
            },
            new Sample
            {
                Name = "Marker Chart",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "Charts/MarkerChart",
                FileName = "MarkerChart.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Marker Chart . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the marker symbols for data points.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates the rendering of symbols in chart. In line based series, data points can be annotated by using symbols.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Each points in a series can be represented as a symbol through marker. We can also customize the shape, size and color of a symbol through <code>Marker</code> properties.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
			new Sample
            {
                Name = "Vertical Chart",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "Charts/VerticalChart",
                FileName = "VerticalChart.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Vertical Chart . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the vertical type charts.",
                ActionDescription = new string[] {
                    @"<p>
                This sample illustrates the vertical chart by changing the orientation of x-axis to vertical and y-axis to horizontal.

                </p>"
                },
                Description = new string[] {
                    @"<p>
                In this example, you can see how to render and configure the vertical type charts. To render a chart in vertical manner, you can use isTransposed in chart.
                </p>
                <p>
                More information on the vertical chart can be found in this
                    <a target='_blank' href='http://ej2.syncfusion.com/documentation/chart/api-series.html#type-chartseriestype'>documentation section</a>.

                </p>"
                }
            },
            new Sample
            {
                Name = "Empty Point",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "Charts/EmptyPoint",
                FileName = "EmptyPoint.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Empty Point . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the empty points.",
                ActionDescription = new string[] {
                    @"<p>
                This sample illustrates the empty point functionality in chart series. The mode of empty point can be changed by using Empty Point Mode in property panel.

                </p>"
                },
                Description = new string[] {
                    @"<p>
                In this example, you can see how to render and configure the empty points. You can use border, fill, mode properties to customize the empty points.

                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>
                <p>
                    More information on the empty points can be found in this documentation section.
                </p>"
                }
            },
            new Sample
            {
                Name = "Tooltip Template",
                Category = "Chart Customization",
                Directory = "Charts/Chart",
                Url = "Charts/TooltipTemplate",
                FileName = "TooltipTemplate.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Tooltip Template . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the Tooltip template.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the USA Wheat Production data with default line series in the chart. Data points are enhanced with marker and tooltip.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the BackgroundImage and Tooltip template for the charts.
                    You can use <code>BackgroundImage</code>, <code>Tooltip</code>, <code>Fill</code> properties to customize the line.
                    <code>Marker</code> is used to represent individual data and its value.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>
                <p>
                    More information on the Tooltip template can be found in this documentation section.
                </p>"
                }
            },
            new Sample
            {
                Name = "Print",
                Category = "Print and Export",
                Directory = "Charts/Chart",
                Url = "Charts/Print",
                FileName = "Print.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Print . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to print the entire chart.",
                ActionDescription = new string[] {
                    @"<p>
                This sample visualizes print feature in chart control.

                </p>"
                },
                Description = new string[] {
                    @"<p>
                This sample demonstrates the print feature in chart

                </p>"
                }
            },
            new Sample
            {
                Name = "Export",
                Category = "Print and Export",
                Directory = "Charts/Chart",
                Url = "Charts/Export",
                FileName = "Export.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Export . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Chart control shows how to export the charts to Excel, PDF, and image formats such as SVG, JPEG, and PNG at client-side.",
                ActionDescription = new string[] {
                    @"<p>
                This sample illustrates the export feature in chart. By clicking <code>Export</code>, you can export the chart in PNG or JPEG format.

                </p>"
                },
                Description = new string[] {
                    @"<p>
                In this example, you can see how to render and configure the export. The rendered chart can be exported as either JPEG, PNG and SVG format. It can be achieved using Blob and it's supported only in modern browsers.
                </p>
                <p>
                More information on the column series can be found in this
                    <a target='_blank' href='http://ej2.syncfusion.com/documentation/chart/api-series.html#type-chartseriestype'>documentation section</a>.

                </p>"
                }
            },
            new Sample
            {
                Name = "Selection",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "Charts/Selection",
                FileName = "Selection.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Selection . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates the selection behavior in chart.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates the selection feature in chart. To select a specific point, click the point.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    This sample demonstrates the selection behavior in a chart. Any point or a series can be selected in a chart by clicking or touching the point. 
                    We can also select the point while loading chart through <code>selectedDataIndexes</code> properties. Click to select a point or series, 
                    click and drag to enable rectangular selection. Rectangular selection will return the collection point that are selected under the region.
                </p>
                <p>
                    Tap to select a point or series, double tap and drag to enable rectangular selection in touch enabled devices.
                </p>
                <p>
                    Chart supports the following by which can be set using <code>SelectionMode</code> property.
                </p>
                <ul>
                        <li><code>Series</code> - Select the series in chart.</li>
                        <li><code>Point</code> - Select a point in the series.</li>
                        <li><code>Cluster</code> - Select a group of points in the chart.</li>
                        <li><code>DragXY</code> - Rectangular selection with respect to both axis.</li>
                        <li><code>DragX</code> - Rectangular selection with respect to horizontal axis.</li>
                        <li><code>DragY</code> - Rectangular selection with respect to vertical axis.</li>
                </ul>"
                }
            },
            new Sample
            {
                Name = "Range Selection",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "Charts/RangeSelection",
                FileName = "RangeSelection.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Range Selection . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates the range selection in chart.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates the range selection feature in chart.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    This sample demonstrates the selection behavior in a chart. Any point or a series can be selected in a chart by clicking 
                    or touching the point. We can also select the point while loading chart through <code>selectedDataIndexes</code> properties. 
                    Click to select a point or series, click and drag to enable rectangular selection. Rectangular selection will return 
                    the collection point that are selected under the region.
                </p>
                <p>
                    Tap to select a point or series, double tap and drag to enable rectangular selection in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Crosshair",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "Charts/Crosshair",
                FileName = "Crosshair.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Crosshair . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates the crosshair behavior in chart.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates crosshair feature in chart. To see crosshair, hover or long press the chart.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    This sample demonstrates the crosshair behavior in chart. Crosshair is used to inspect or focus on an individual data point. 
                    You can customize the axis tooltip using <code>crosshairTooltip</code> properties in axis.
                </p>
                <p>
                    Hover the chart area to view crosshair and its tooltip. Touch and hold to enable crosshair in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Trackball",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "Charts/Trackball",
                FileName = "Trackball.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Trackball . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates the trackball behavior in chart.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample illustrates trackball feature in chart. To show trackball, hover or long press the chart and you can see the point value near to the mouse point.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample demonstrates the trackball behavior in chart. Trackball is used to track a data point closer to the current mouse position or touch contact point.
                        You can show tooltip for individual point or group of points closer to mouse position using <code>shared</code> properties in tooltip.
                    </p>
                    <p>
                        Hover the chart area to view trackball and its tooltip. Touch and hold to enable trackball in touch enabled devices.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Zooming and Panning",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "Charts/ZoomingandPanning",
                FileName = "ZoomingandPanning.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Zooming and Panning . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates the zooming and panning behavior in chart.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates zooming feature in chart. The change can be zoomed by pinching or by mouse wheel.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    This sample demonstrates the zooming and panning behavior in chart.
                </p>
                <ul>
                        <li>Click and drag the mouse on a chart area to enable selection zooming.</li>
                        <li>Hover the mouse on the toolbar at the top right corner of chart area to switch between zooming and panning.</li>
                        <li>Pinch in and pinch out the chart area to zoom in or zoom out the chart in touch enabled devices.</li>
                        <li>Touch and drag to pan the chart.</li>
                        <li>Double tap to reset the zoomed chart.</li>
                </ul>
                <p>
                    Chart component supports four types of zooming which can be set using <code>EnableSelectionZooming</code>, <code>EnablePinchZooming</code>, <code>EnableMouseWheelZooming</code>, <code>EnableDeferredZooming</code> property.
                </p>
                <p>
                Chart supports two mode of zooming which can be set using <code>mode</code> property.
                </p>
                <ul>
                        <li><code>XY</code> - Zoom the chart with respect to both the axis.</li>
                        <li><code>X</code> - Zoom the chart with respect to horizontal axis.</li>
                        <li><code>Y</code> - Zoom the chart with respect to vertical axis.</li>
                </ul>"
                }
            },
            new Sample
            {
                Name = "Data Editing",
                Category = "User Interaction",
                Directory = "Charts/Chart",
                Url = "Charts/DataEditing",
                FileName = "DataEditing.razor",
                Type = SampleType.New,
                TitleTag = "Chart . Data Editing . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates the data editing behavior in chart.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates data editing feature in chart. Drag and drop the points to change the data values dynamically.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    The draggable-points allows data to be moved around the chart. In addition to this, the module fires events such as dragStart, drag and dragComplete.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>
                <p>
                    More information on the Data Editing can be found in this documentation section.
                </p>"
                }
            },
        };

        public List<Sample> RangeNavigator { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default",
                Category = "Range Selector",
                Directory = "Charts/RangeNavigator",
                Url = "RangeSelector/RangeNavigator",
                FileName = "RangeNavigator.razor",
                Type = SampleType.New,
                TitleTag = "RangeNavigator . Default . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Range Navigator control shows the default rendering of range navigator with range area series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the bitcoin price range with area series in the range navigator. Selected range values are enhanced with tooltip.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Range Navigator.
                    <code>AreaSeries</code> is used to represent selected data value.
                </p>"
                }
            },
			new Sample
			 {
			    Name = "LightWeight",
			    Category = "Range Selector",
			    Directory = "Charts/RangeNavigator",
			    Url = "RangeSelector/LightWeight",
			    FileName = "LightWeight.razor",
			    Type = SampleType.New,
                TitleTag = "RangeNavigator . LightWeight . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Range Navigator control shows the rendering of light-weight range navigator.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample represents the total number of business and weekend days in a selected period.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Light Weight Range Navigator.
                </p>"
                }
			},
			  new Sample
			  {
                Name = "DateTime Axis",
                Category = "Axis",
                Directory = "Charts/RangeNavigator",
                Url = "RangeSelector/DateTimeAxis",
                FileName = "DateTimeAxis.razor",
                Type = SampleType.New,
                TitleTag = "RangeNavigator . DateTime Axis . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Range Navigator control shows how to plot date-time values in range navigator.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample represent the exchange rate analysis for USD to EUR with datetime axis.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Date-time data is used in this sample, and the selected range values are showed with tooltip. Date-time axis uses date-time scale and displays date-time values as axis labels. To render date-time axis, set the valueType to <code>DateTime</code>. Format of the axis label will be calculated based on the <code>intervalType</code> of the range navigator. You can also directly set the format using the <code>labelFormat</code> property.
                </p>"
                }
			 },
			  new Sample
			  {
                Name = "Numeric Axis",
                Category = "Axis",
                Directory = "Charts/RangeNavigator",
                Url = "RangeSelector/NumericAxis",
                FileName = "NumericAxis.razor",
                Type = SampleType.New,
                TitleTag = "RangeNavigator . Numeric Axis . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Range Navigator control shows how to plot numeric data values in the range navigator.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample depicts the cricket match data between two countries with the help of numeric axis in range navigator.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Numeric axis is used to plot numeric data in range navigator. To render numeric axis, set valueType to Double. Tooltip is enabled in this example, to see the tooltip in action, while the selected range is changed.
                </p>"
                }
			 },
              new Sample
              {
                Name = "Logarithmic Axis",
                Category = "Axis",
                Directory = "Charts/RangeNavigator",
                Url = "RangeSelector/Logarithmic",
                FileName = "Logarithmic.razor",
                Type = SampleType.New,
                TitleTag = "RangeNavigator . Logarithmic Axis . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Range Navigator control shows how to visualize the logarithmic scale when data has wide range of values.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the rendering of logarithmic axis in the range navigator.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Logarithmic axis uses logarithmic scale and it is very useful in visualizing when the data has values with both lower order of magnitude (eg: 10^-6) and higher order of magnitude (eg: 10^6). To render Logarithmic axis, set valueType to Logarithmic. Tooltip is enabled in this example, to see the tooltip in action, while the selected range is changed.
                </p>"
                }
             },
              new Sample
			 {
			    Name = "Multilevel Labels",
			    Category = "Axis",
			    Directory = "Charts/RangeNavigator",
			    Url = "RangeSelector/Multilevel",
			    FileName = "Multilevel.razor",
			    Type = SampleType.New,
                TitleTag = "RangeNavigator . Multilevel Labels . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Range Navigator control shows how to display the second level labels in range navigator.",
                ActionDescription = new string[] {
                    @"<p>
                    Axis labels are placed based on the values of the start and end ranges. You can add higher level of labels to the range navigator using multilevel labels.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to group the axis labels. Here the interval for the second level labels can be customized using <code>groupBy</code>.
                </p>"
                }
			},
			   new Sample
			   {
			      Name = "Empty Points",
			      Category = "Customization",
			      Directory = "Charts/RangeNavigator",
			      Url = "RangeSelector/EmptyPoint",
			      FileName = "EmptyPoint.razor",
			      Type = SampleType.New,
                  TitleTag = "RangeNavigator . Empty Points . Syncfusion Blazor Components",
                  MetaDescription = "This demo for Essential Blazor Range Navigator control shows how to render the empty points in the range navigator.",
                  ActionDescription = new string[] {
                        @"<p>
                        This sample illustrates the functionality of empty points in the range navigator series.
                    </p>"
                    },
                  Description = new string[] {
                        @"<p>
                        In this example, you can see how to render empty points in range navigator. Tooltip is enabled in this example; to see the tooltip in action, while the selected range is changed.
                    </p>"
                    }
			    },
			   new Sample
			   {
			      Name = "Filter",
			      Category = "Customization",
			      Directory = "Charts/RangeNavigator",
			      Url = "RangeSelector/Filter",
			      FileName = "Filter.razor",
			      Type = SampleType.New,
                  TitleTag = "RangeNavigator . Filter . Syncfusion Blazor Components",
                  MetaDescription = "This demo for Essential Blazor Range Navigator control shows how to bind the filtered values of the range navigator to grid control.",
                  ActionDescription = new string[] {
                        @"<p>
                        This sample filters the data by hire date using date-time axis.
                    </p>"
                    },
                    Description = new string[] {
                        @"<p>
                        In this example, you can see how to bind the value of the range navigator to the grid control using the changed event.
                    </p>"
                    }
			  },
			   new Sample
			   {
			      Name = "Print and Export",
			      Category = "Export",
			      Directory = "Charts/RangeNavigator",
			      Url = "RangeSelector/PrintExport",
			      FileName = "PrintExport.razor",
			      Type = SampleType.New,
                  TitleTag = "RangeNavigator . Print and Export . Syncfusion Blazor Components",
                  MetaDescription = "This demo for Essential Blazor Range Navigator control shows how to print the charts and export the chart contents to various formats.",
                  ActionDescription = new string[] {
                        @"<p>
                        This sample represent the exchange rate analysis for USD to EUR with datetime axis.
                    </p>"
                    },
                    Description = new string[] {
                        @"<p>
                        Date-time data is used in this sample, and the selected range values are showed with tooltip. Date-time axis uses date-time scale and displays date-time values as axis labels. To render date-time axis, set the valueType to <code>DateTime</code>. Format of the axis label will be calculated based on the <code>intervalType</code> of the range navigator. You can also directly set the format using the <code>labelFormat</code> property.
                    </p>"
                    }
			  },
			  new Sample
			  {
			     Name = "RTL",
			     Category = "Right To Left",
			     Directory = "Charts/RangeNavigator",
			     Url = "RangeSelector/RTL",
			     FileName = "RTL.razor",
			     Type = SampleType.New,
                 TitleTag = "RangeNavigator . RTL . Syncfusion Blazor Components",
                 MetaDescription = "This demo for Essential Blazor Range Navigator control shows how to invert an axis in the range navigator.",
                 ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates RTL in the range navigator.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to inverse the axis in range navigator. Here both the X and Y axis are inversed using isInversed property. Tooltip is enabled in this example; to see the tooltip in action, while the selected range is changed.
                </p>"
                }
			 }
		};

        public List<Sample> Sparkline { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Sparkline Charts",
                Directory = "Charts/Sparkline",
                Url = "Sparkline/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                TitleTag = "Sparkline . Default . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Sparkline component visualizes the population details in Sparkline. Line, Column, WinLoss and Area are the types of Sparkline",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes population, population density, population growth rate, and birth rate of various countries from 2005 to 2014.
                </p>"
                },
                Description = new string[] {
                    @" <p>
                    In this example, you can see how to render a sparkline in a table. The color and type of the sparklines have been customized. Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over the data points or tap on a data point in touch enabled devices.
                </p>"
                }
            },
             new Sample
             {
                 Name = "Series Type",
                 Category = "Sparkline Charts",
                 Directory = "Charts/Sparkline",
                 Url = "Sparkline/SeriesType",
                 FileName = "SeriesType.razor",
                 TitleTag = "Sparkline . SeriesType . Syncfusion Blazor Components",
                 MetaDescription = "This demo of Syncfusion Blazor Sparkline component depicts the various series types available in the sparkline",
                 Type = SampleType.None,
                 ActionDescription = new string[] {
                    @"<p>
                        This sample depicts the various types of series available in Sparkline.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see the sparkline with various series types such as line, area, column, win loss and pie. Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over the data points or tap on a data point in touch enabled devices.
                    </p>"
                }
             },
             new Sample
            {
                Name = "Axis Value Types",
                Category = "Sparkline Charts",
                Directory = "Charts/Sparkline",
                Url = "Sparkline/AxisTypes",
                FileName = "AxisTypes.razor",
                TitleTag = "Sparkline . Axis Types . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Sparkline component depicts the axis types available in sparkline. DateTime, Category and Numeric are axis types in Sparkline",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                    This sample depicts the various types of axis value types available in sparkline.We have three types of axis.
                </p>"
                },
                Description = new string[] {
                    @" <p>
                    In this example, you can see the sparklines with various axis value types such as date-time, category, and numeric. Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over the data points or tap on a data point in touch enabled devices.
                </p> "
                }
            },
             new Sample
             {
                 Name = "Sparkline in Grid",
                 Category = "Sparkline Charts",
                 Directory = "Charts/Sparkline",
                 Url = "Sparkline/SparklineGrid",
                 FileName = "SparklineGrid.razor",TitleTag = "Sparkline . Sparkline in Grid . Syncfusion Blazor Components",
                 MetaDescription = "This sample depicts the range band feature and its customization options available in sparklines.",
                 Type = SampleType.None,
                 ActionDescription = new string[] {
                    @"<p>
                This sample demonstrates rendering sparklines in data grid control.
                </p>"
                },
                Description = new string[] {
                    @" <p>
                In this example, you can see how to render sparkline inside the data grid control.
                </p> "
                }
             },
                new Sample
              {
                  Name = "Customization",
                  Category = "Sparkline Charts",
                  Directory = "Charts/Sparkline",
                  Url = "Sparkline/Customization",
                  FileName = "Customization.razor",
                  TitleTag = "Sparkline . Customization . Syncfusion Blazor Components",
                  MetaDescription = "This demo of Syncfusion Blazor Sparkline component visualizes the various customization options available in sparklines.",
                  Type = SampleType.None,
                  ActionDescription = new string[] {
                        @"<p>
                    This sample depicts the various customization options available in sparklines.
                </p>"
                    },
                    Description = new string[] {
                        @" <p>
                    In this example, you can see various customization options available in sparklines. Tooltip is enabled in this example. To
                    see the tooltip in action, hover the mouse over the data points or tap on a data point in touch enabled devices.
                </p> "
                    }
              },
            //    new Sample
            //  {
            //      Name = "Live Update",
            //      Category = "Sparkline Charts",
            //      Directory = "Charts/Sparkline",
            //      Url = "Sparkline/Liveupdate",
            //      FileName = "Liveupdate.razor",
            //      Type = SampleType.New,
                    // ActionDescription = new string[] {
                    //     @"<p>
                    //     This sample depicts the various customization options available in sparklines.
                    // </p>"
                    // },
                    // Description = new string[] {
                    //     @" <p>
                    //     In this example, you can see various customization options available in sparklines. Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over the data points or tap on a data point in touch enabled devices.
                    // </p>"
                    // }
            //  },
              new Sample
              {
                  Name = "Range Band",
                  Category = "Sparkline Charts",
                  Directory = "Charts/Sparkline",
                  Url = "Sparkline/RangeBand",
                  FileName = "RangeBand.razor",
                  TitleTag = "Sparkline . Range Band . Syncfusion Blazor Components",
                  MetaDescription = "This sample depicts the range band feature and its customization options available in sparklines.",
                  Type = SampleType.None,
                  ActionDescription = new string[] {
                        @"<p>
                    This sample depicts the range band feature and its customization options available in sparklines.
                    </p>"
                    },
                    Description = new string[] {
                        @" <p>
                        In this example, you can see how to render sparkline with range band and the customization options available in range band. Here, the sparklines are placed inside the data grid control.
                    </p> "
                    }
              }
        };

        public List<Sample> SmithChart { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default Functionalities",
                Category = "SmithChart",
                Directory = "Charts/SmithChart",
                Url = "SmithChart/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                TitleTag = "Smithchart . Default . Syncfusion Blazor Components-Preview",
                MetaDescription = "This demo of Syncfusion Blazor SmithChart component visualizes the rendering of SmithChart. Impedance and admittance are the rendering types in smithChart",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                    This sample visualizes two transmissions in Smith chart. Rendering Smith chart can be changed by using the <code>Render Type</code> in properties panel.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render a Smith chart with multiple series. Legend has been enabled to denote the series in Smith chart.
                </p>
                <p>
                    Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over a data point or tap a data point in touch enabled devices
                </p>"
                }
            },
            new Sample
            {
                Name = "Customization",
                Category = "SmithChart",
                Directory = "Charts/SmithChart",
                Url = "SmithChart/Customization",
                FileName = "Customization.razor",
                TitleTag = "Smithchart . Customization . Syncfusion Blazor Components-Preview",
                MetaDescription = "This demo of Syncfusion Blazor SmithChart component visualizes the customizing options in SmithChart. Marker, DataLabel, Legend and Tooltip can be customized",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                    This sample visualizes two transmissions in a Smith chart along with <code>Data label, Marker</code> and <code>Legend</code> support.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render a Smith chart with multiple series. Legend has been enabled to denote the series in Smith chart.
                </p>"
                }
            },
            new Sample
            {
               Name = "Print and Export",
               Category = "SmithChart",
               Directory = "Charts/SmithChart",
               Url = "SmithChart/PrintAndExport",
               FileName = "PrintAndExport.razor",
               TitleTag = "Smithchart . Print and Export . Syncfusion Blazor Components-Preview",
               MetaDescription = "This demo of Syncfusion Blazor SmithChart component explores the print and export functionality of smithChart.",
               Type = SampleType.None,
               ActionDescription = new string[] {
                    @" <p>
                    This sample explores the exporting and printing functionality in Smith chart.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to export and print the rendered Smith chart. Smith chart can be exported to JPEG, PNG, SVG, and PDF formats.
                </p>
                "
                }
            }
        };

        public List<Sample> StockChart { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/StockChart",
                FileName = "Default.razor",
                Type = SampleType.New,
                TitleTag = "StockChart . Default . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Stock Chart control shows the default rendering of Stock with candle series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the Stock Chart
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Stock Chart
                </p>"
                }
            },
           new Sample
            {
                Name = "OHLC",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/OHLC",
                FileName = "OHLC.razor",
                Type = SampleType.New,
                TitleTag = "StockChart . OHLC . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Stock Chart control shows the default rendering of Stock with Hilo Open Close series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the Stock Chart with OHLC series.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Stock chart. HILO Open Close series is used to represent selected data value.
                </p>"
                }
            },
           new Sample
            {
                Name = "Candlestick and Volume",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/CandlestickandVolume",
                FileName = "Candlestick and Volume.razor",
                Type = SampleType.New,
                TitleTag = "StockChart . Candlestick and Volume . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Stock Chart control shows the default rendering of Stock with candle series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes stock chart with multiple pan.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Stock chart with volume. CandleSeries is used to represent selected data value and ColumnSeries is used to represent the volume.
                </p>"
                }
            },
           new Sample
            {
                Name = "Multiple Series",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/MultipleSeries",
                FileName = "Multiple Series.razor",
                Type = SampleType.New,
                TitleTag = "StockChart . Multiple Series . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Stock Chart control shows the default rendering of Stock with candle series.",
                ActionDescription = new string[] {
                    @"<p>
                This sample visualizes stock chart with multiple series.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Stock chart. LineSeries is used to represent selected data value.
                </p>"
                }
            },
           new Sample
            {
                Name = "Spline",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/StockChartSpline",
                FileName = "Spline.razor",
                Type = SampleType.New,
                TitleTag = "StockChart . Spline . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Stock Chart control shows the default rendering of Stock with Spline series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes stock data with spline series. Period and range selector help us to navigate different of data.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                In this example, you can see how to render and configure the Stock chart. SplineSeries is used to represent selected data value.
                </p>"
                }
            },
            new Sample
            {
                Name = "Area",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/StockChartArea",
                FileName = "Area.razor",
                Type = SampleType.New,
                TitleTag = "StockChart . Area . Syncfusion Blazor Components",
                MetaDescription = "This, demo for Essential Blazor Stock Chart control shows the default rendering of Stock with Area series.",
                ActionDescription = new string[] {
                    @"<p>
                This sample visualizes stock data with area. Period and range selector help us to navigate different of data.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Stock chart. AreaSeries is used to represent selected data value.
                </p>"
                }
            },
            new Sample
            {
                Name = "Spline Area",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/StockChartSplineArea",
                FileName = "SplineArea.razor",
                Type = SampleType.New,
                TitleTag = "StockChart . Spline Area . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Stock Chart control shows the default rendering of Stock with Spline Area series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes stock data with spline area. Period and range selector help us to navigate different of data.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Stock chart. SplineAreaSeries is used to represent selected data value.
                </p>"
                }
            },
            new Sample
            {
                Name = "Inversed Area",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/InversedArea",
                FileName = "Inversed Area.razor",
                Type = SampleType.New,
                TitleTag = "StockChart . Inversed Area . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Stock Chart control shows the default rendering of Stock with Area series inverted.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes stock data with inversed axis. Period and range selector help us to navigate different of data.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Stock chart. AreaSeries is used to represent selected data value.
                </p>"
                }
            },
           new Sample
            {
                Name = "Intraday",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/Intraday",
                FileName = "Intraday.razor",
                Type = SampleType.New,
                TitleTag = "StockChart . Intraday . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Stock Chart control shows the default rendering of Stock with period customization.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the Stock Chart
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Stock Chart
                </p>"
                }
            },
		    new Sample
		    {
		        Name = "Hide Period Selector",
		        Category = "Stock Chart",
		        Directory = "Charts/StockChart",
		        Url = "StockChart/HidePeriodSelector",
		        FileName = "Hide Period Selector.razor",
		        Type = SampleType.New,
                TitleTag = "StockChart . Hide Period Selector . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Stock Chart control shows the default rendering of Stock with period customization.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the Stock Chart
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Stock Chart
                </p>"
                }
		    },
            new Sample
            {
                Name = "Hide Range Selector",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/HideSelector",
                FileName = "Hide Selector.razor",
                Type = SampleType.New,
                TitleTag = "StockChart . Hide Range Selector . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Stock Chart control shows the default rendering of Stock with period customization.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the Stock Chart
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Stock Chart
                </p>"
                }
            },
            new Sample
            {
                Name = "Stock Events",
                Category = "Stock Chart",
                Directory = "Charts/StockChart",
                Url = "StockChart/StockEvents",
                FileName = "StockEvents.razor",
                Type = SampleType.New,
                TitleTag = "StockChart . Stock Events . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential Blazor Stock Chart control with stock events to highlight the special events in stock market.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the Stock Chart
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the Stock Chart
                </p>"
                }
            }
		};
		public List<Sample> BulletChart { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default Functionalities",
                Category = "BulletChart",
                Directory = "Charts/BulletChart",
                Url = "BulletChart/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                TitleTag = "BulletChart . Bullet Chart . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the default bullet chart.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a default bullet chart to compare the feature (value) bar with comparative (target) bar. It includes variety of configurations to change the look and feel of the chart.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a feature bar or comparative bar on the bullet chart.
                </p>"
                }
            },
           new Sample
            {
                Name = "Multiple Data",
                Category = "BulletChart",
                Directory = "Charts/BulletChart",
                Url = "BulletChart/MultipleData",
                FileName = "MultipleData.razor",
                Type = SampleType.New,
                TitleTag = "BulletChart . Multiple Data . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the Multiple Data.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a bullet chart with multiple data to compare different values.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a feature bar or comparative bar on the bullet chart.
                </p>"
                }
            },
           new Sample
            {
                Name = "RTL",
                Category = "BulletChart",
                Directory = "Charts/BulletChart",
                Url = "BulletChart/RightToLeft",
                FileName = "RightToLeft.razor",
                Type = SampleType.New,
                TitleTag = "BulletChart . RTL . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor BulletChart control demonstrates how to render and configure the RTL Chart.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates bullet chart with diferent mode of rendering such as right to left and left to right.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a feature bar or comparative bar on the bullet chart.
                </p>"
                }
            },
           new Sample
            {
                Name = "Feature and Target Bar",
                Category = "BulletChart",
                Directory = "Charts/BulletChart",
                Url = "BulletChart/BarCustomization",
                FileName = "BarCustomization.razor",
                Type = SampleType.New,
                TitleTag = "BulletChart . Feature and Target Bar . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the Feature and Target Bar.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a customization of feature bar and comparative bar type in terms of color and width.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a feature bar or comparative bar on the bullet chart.
                </p>"
                }
            },
           new Sample
            {
                Name = "Range and Label Settings",
                Category = "BulletChart",
                Directory = "Charts/BulletChart",
                Url = "BulletChart/Customization",
                FileName = "Customization.razor",
                Type = SampleType.New,
                TitleTag = "BulletChart . Range and Label Settings . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor BulletChart control demonstrates how to render and configure the Range and Label Settings.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a bullet chart with with different customization for ranges and labels in bullet chart.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a feature bar or comparative bar on the bullet chart.
                </p>"
                }
            }
        };
    }

}
