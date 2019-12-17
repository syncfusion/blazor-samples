using System.Collections.Generic;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> LinearGauge { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "LinearGauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "LinearGauge/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                TitleTag = "LinearGauge . Default . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo of Syncfusion Blazor LinearGauge component illustrates the default rendering of linear gauge",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates the default rendering of linear gauge.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample demonstrates the default linear gauge. The linear gauge component indicates the values of scales in horizontal
                        or vertical sliding meter. You can use <code>axes</code>,
                        <code>ranges</code>, <code>pointers</code> and <code>container</code> properties to customize the appearance of the
                        gauge. an axis, annotation and a pointer has been used.
                    </p>
                    <br>
                    <p>
                        More information about linear gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Container",
                Category = "LinearGauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "LinearGauge/Container",
                FileName = "Container.razor",
                TitleTag = "LinearGauge . Container . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo of Syncfusion Blazor LinearGauge component shows the container types in LinearGauge. Normal, RoundedRectangle and Thermometer are the types of container",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the type of containers used in linear gauge. Orientation and container type of linear gauge can be changed by using <code>Orientation</code> and <code>Container Type</code> options
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample demonstrates the orientation and container customization in linear gauge. The gauge can be rendered either in
                        vertical or horizontal orientation. And you can use <code>type</code> property in container to change the
                        type of the container.
                    </p>
                    <br>
                    <p>
                        More information about container can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Ranges",
                Category = "LinearGauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "LinearGauge/Ranges",
                FileName = "Ranges.razor",
                TitleTag = "LinearGauge . Ranges . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo of Syncfusion Blazor LinearGauge component shows how to highlight specific regions in an axis using ranges. Range Color and Width can be customized",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates how to highlight a region in an axis by using ranges in gauge. Start, end, color, and width of the range can be changed by using the options provided in the property panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render and configure the ranges in linear gauge. You can use <code>start</code>,
                    <code>end</code>, <code>startWidth</code>, <code>endWidth</code> and <code>position</code> properties to customize the ranges. You can also specify various colors for the ranges in the axis. If you enable
                    the <code>useRangeColor</code> property, then the axis labels will be displayed based on its range color.
                    </p>
                    <br>
                    <p>
                    More information about linear gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation"">documentation section</a>.

                    </p>"
                }
            },
            new Sample
            {
               Name = "Data Sample",
               Category = "LinearGauge",
               Directory = "LinearGauge/LinearGauge",
               Url = "LinearGauge/DataSample",
               FileName = "DataSample.razor",
               TitleTag = "LinearGauge . Data . Syncfusion Blazor Components - Preview",
               MetaDescription = "This demo of Syncfusion Blazor LinearGauge component illustrates exercise tracking of an athlete by using ranges, pointers, and annotation",
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
                    <br>
                    <p>
                        More information about linear gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Axes and Pointers",
                Category = "LinearGauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "LinearGauge/AxesandPointers",
                FileName = "AxesandPointers.razor",
                TitleTag = "LinearGauge . Axes and pointer . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo of Syncfusion Blazor LinearGauge component shows customizing options in axes and pointers. Pointer types, tick position can be customized",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates the axis and pointers feature in the linear gauge. Axis and pointers can be customized by using options available in the panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to customize the axes and pointers. Use format of labelStyle property to customize the <code>axis labels and use type, markerType and placement</code> properties to customize the pointers in linear gauge.
                    </p>
                    <br>
                    <p>
                        More information about linear gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Annotation",
                Category = "LinearGauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "LinearGauge/Annotation",
                FileName = "Annotation.razor",
                TitleTag = "LinearGauge . Annotation . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo of Syncfusion Blazor LinearGauge component illustrates the CPU Utilization of a resource by using annotation",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates the CPU Utilization of a resource by using annotation feature.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this sample we have used annotations to indicate low, moderate and high ranges. Annotations are used to place the texts, shapes or images anywhere in the gauge. You can use <code>content, x, y, zIndex</code> properties to customize the annotations. And you can specify the id of the element that needs to be displayed, in the content property.
                    </p>
                    <br>
                    <p>
                        More information about linear gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
               Name = "Tooltip",
               Category = "LinearGauge",
               Directory = "LinearGauge/LinearGauge",
               Url = "LinearGauge/Tooltip",
               FileName = "Tooltip.razor",
               TitleTag = "LinearGauge . Tooltip . Syncfusion Blazor Components - Preview",
               MetaDescription = "This demo of Syncfusion Blazor LinearGauge component visualizes the tooltip functionality for bar pointer",
               Type = SampleType.None,
               ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the tooltip for pointer in gauge. To see tooltip in action, hover pointer or tap the pointer.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample demonstrates the measuring scale by using the linear gauge. Tooltip is used to track the pointer value closer to the current mouse position or touch contact. You can show the tooltip for an individual marker or bar pointer by hover or tap on the pointer in touch enabled devices.
                    </p>
                    <br>
                    <p>
                        More information about linear gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Styles",
                Category = "LinearGauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "LinearGauge/Styles",
                FileName = "Styles.razor",
                TitleTag = "LinearGauge . Styles . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo of Syncfusion Blazor LinearGauge component visualizes the available options for customization",
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
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation"">documentation section</a>.
                    </p>"
                }
            }
         };
    }
}
