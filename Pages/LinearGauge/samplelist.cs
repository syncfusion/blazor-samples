using System.Collections.Generic;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> LinearGauge { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Linear Gauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates the default rendering of the linear gauge.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample demonstrates the default linear gauge. The linear gauge component indicates the values of scales in horizontal
                        or vertical sliding meter. You can use <code>LinearGaugeAxes</code>,
                        <code>LinearGaugeRanges</code>, <code>LinearGaugePointers</code> and <code>LinearGaugeContainer</code> properties to customize the appearance of the
                        linear gauge.
                    </p>
                    <p>
                        More information about linear gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/linear-gauge/getting-started"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Container",
                Category = "Linear Gauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/container",
                FileName = "Container.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the type of containers used in linear gauge. Orientation and container type of the linear gauge component can be changed by using orientation and container type options in the property panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample demonstrates the orientation and container customization in linear gauge. The gauge can be rendered either in
                        vertical or horizontal orientation. You can use <code>Type</code> property in <code>LinearGaugeContainer</code> property to change the
                        type of the container.
                    </p>
                    <p>
                        More information about container can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/linear-gauge/getting-started"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Ranges",
                Category = "Linear Gauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/ranges",
                FileName = "Ranges.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates how to highlight a region in an axis by using ranges in gauge. Start, end, color, and width of the range can be changed by using the options provided in the property panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render and configure the ranges in linear gauge. You can use <code>Start</code>,
                    <code>End</code>, <code>StartWidth</code>, <code>EndWidth</code> and <code>Position</code> properties of <code>LinearGaugeRange</code> to customize the ranges. You can also specify various colors for the ranges in the axis. If you enable
                    the <code>UseRangeColor</code> property, then the axis labels will be displayed based on its range color.
                    </p>
                    <p>
                    More information about linear gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/linear-gauge/ranges"">documentation section</a>.

                    </p>"
                }
            },
            new Sample
            {
               Name = "Data Sample",
               Category = "Linear Gauge",
               Directory = "LinearGauge/LinearGauge",
               Url = "linear-gauge/data-sample",
               FileName = "DataSample.razor",
               Type = SampleType.None,
               ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates exercise tracking of an athlete by using ranges, pointers, and annotation features available in linear gauge.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample demonstrates the exercise tracking using ranges, pointer and annotation features in linear gauge. We have rendered 3 linear gauges in this sample for indicating running, cycling and walking.
                    </p>
                    <p>
                        More information about linear gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/linear-gauge/getting-started"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Axes and Pointers",
                Category = "Linear Gauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/axes-and-pointers",
                FileName = "AxesandPointers.razor",
                Type = SampleType.Updated,
                ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates the axis and pointers feature in the linear gauge. Axis and pointers can be customized by using options available in the panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to customize the axes and pointers. Use format of labelStyle property to customize the <code>AxisLabel</code> and <code>Type, MarkerType</code> and <code>Placement</code> properties to customize the pointers in linear gauge.
                    </p>
                    <p>
                        More information about linear gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/linear-gauge/pointers"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Annotation",
                Category = "Linear Gauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/annotation",
                FileName = "Annotation.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates the CPU Utilization of a resource by using annotation feature.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this sample we have used annotations to indicate low, moderate and high ranges. Annotations are used to place the texts, shapes or images anywhere in the gauge. You can use <code>Content</code>, <code>X</code>, <code>Y</code>, <code>ZIndex</code> properties to customize the annotations.
                    </p>
                    <p>
                        More information about linear gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/linear-gauge/annotations"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
               Name = "Tooltip",
               Category = "Linear Gauge",
               Directory = "LinearGauge/LinearGauge",
               Url = "linear-gauge/tooltip",
               FileName = "Tooltip.razor",
               Type = SampleType.None,
               ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the tooltip for pointer in linear gauge.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample demonstrates the measuring scale by using the linear gauge. Tooltip is used to track the pointer value closer to the current mouse position or touch contact. You can show the tooltip for an individual marker or bar pointer by hover or tap on the pointer in touch-enabled devices.
                    </p>
                    <br>
                    <p>
                        More information about linear gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/linear-gauge/user-interaction"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Styles",
                Category = "Linear Gauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/styles",
                FileName = "Styles.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the available customizing options in linear gauge.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this sample, we have indicated a value in various styles using bar and marker pointers. You can display any number of pointers in an axis.
                    </p>
                    <p>
                        More information about linear gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/linear-gauge/getting-started"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Print & Export",
                Category = "Linear Gauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/export",
                FileName = "Export.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @" <p>
                        This sample demonstrates the print and export functionality of linear gauge.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to export and print the rendered linear gauge. The Linear Gauge can be exported to JPEG, PNG, SVG, and PDF formats.
                    </p>
                    <p>
                        More information about linear gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/linear-gauge/getting-started"">documentation section</a>.
                    </p>"
                }
            }
         };
    }
}
