using System.Collections.Generic;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> CircularGauge { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Circular Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates the default rendering of the circular gauge.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render a default circular gauge. The circular gauge component circularly visualizes the numerical scales values. In this sample, an axis with a pointer has been used. You can use <code>CircularGaugeAxes</code>, <code>CircularGaugeRanges</code>, <code>CircularGaugePointers</code> to customize the default appearance of the gauge.
                    </p>
                    <p>
                        More information on the circular gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/circular-gauge/getting-started/"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Range",
                Category = "Circular Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/range",
                FileName = "Range.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates how to highlight a region in an axis by using ranges in gauge. <b>Start value</b>, <b>end value</b>, <b>color</b>, <b>width</b> and <b>corner radius</b> of the range can be changed by using the options provided in the property panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to customize the ranges of an axis in the circular gauge. Ranges are used to group the axis values, you can use <code>Start</code>, <code>End</code>, <code>Color</code>, <code>StartWidth</code>, <code>EndWidth</code>, <code>Radius</code> and <code>RoundedCornerRadius</code> properties to customize the ranges. In this sample, an axis is shown with multiple ranges in the circular gauge component and options to customize the range properties with the property panel.
                    </p>
                    <p>
                        More information on the circular gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/circular-gauge/gauge-ranges/"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Ticks and Labels",
                Category = "Circular Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/labels",
                FileName = "Labels.razor",
                Type = SampleType.None,
                 ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates how to customize the ticks and labels of an axis. Position, offset, and height of the tick and label can be changed by using the options provided in the property panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>                         
                        In this example, you can see how to render and configure the ticks and labels of an axis in the circular gauge. Labels are units that are used to display the values in the axis.
                        You can customize the labels with the properties like <code>Angle</code>, <code>Font</code>,
                        <code>Position</code>, and more. Ticks are used to mark some values on the axis. You can also customize the ticks using
                        <code>CircularGaugeMajorTicks</code>,
                        <code>CircularGaugeMinorTicks</code> properties.
                    </p>
                    <p>
                        More information on the labels can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/circular-gauge/getting-started/"">documentation section</a>.
                    </p>"
                }
            },
            //  new Sample
            // {
            //     Name = "Annotation",
            //     Category = "Circular Gauge",
            //     Directory = "CircularGauge/CircularGauge",
            //     Url = "circular-gauge/Annotation",
            //     FileName = "Annotation.razor",
            //     TitleTag = "CircularGauge . Annotations . Syncfusion Blazor Components",
            //     MetaDescription = "This demo of Syncfusion Blazor CircularGauge component illustrates a clock by using annotation in the Circular Gauge",
            //     Type = SampleType.None
            // },
             new Sample
            {
                Name = "Gauge Customization",
                Category = "Circular Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/customization",
                FileName = "Customization.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates how to customize the gauge with pointers. Options to change the color, value, and type of the pointer are available in the property panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to customize the gauge elements such as pointers and range. Here a needle and range bar pointers are added to show the current value and its appearance can be customized here.
                    </p>
                    <p>
                        More information on the circular gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/circular-gauge/getting-started/"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Semi-circular Gauge",
                Category = "Circular Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/semi-circular-gauge",
                FileName = "Semicirculargauge.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the rendering of the circular gauge with modified start and end angles. The radius, start angle, end angle, and the center position of the circular gauge can be customized using the options in the properties panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the circular gauge with modified start and end angles to form the semi or quarter circular gauges. By enabling the <b>radius based on angle</b> option, the radius of circular gauge will be calculated based on the start and end angles.
                    </p>
                    <p>
                        More information on the circular gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/circular-gauge/getting-started/"">documentation section</a>.
                    </p>"
                }
            },	
			 new Sample
			{
			    Name = "Arc Gauge",
			    Category = "Circular Gauge",
			    Directory = "CircularGauge/CircularGauge",
			    Url = "circular-gauge/arc-gauges",
			    FileName = "ArcGauges.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the progress of work in the circular gauge using the range bar pointer with the rounded corners.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the ranges and range bar pointer with rounded corners. A slider is placed at the bottom of the gauge using annotation to change the range bar pointer value. Based on the value, the color of the pointer can also be changed.
                    </p>
                    <p>
                        More information on the circular gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/circular-gauge/getting-started/"">documentation section</a>.
                    </p>"
                }
			},
              new Sample
            {
                Name = "Legend",
                Category = "Circular Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/circular-gauge-legend",
                FileName = "CircularGaugeLegend.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes moving air types based on their speed in the legend of the circular gauge component. The visibility, shape, alignment, and position of the legend can be changed using the properties panel options.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render a legend in circular gauge. A legend item denotes the ranges in the axis. Any number of items can be added to a legend. You can bind the desired colors and legend text to the corresponding ranges.
                    </p>
                    <p>
                        More information on the circular gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/circular-gauge/legend/"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Direction Compass",
                Category = "Circular Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/compass",
                FileName = "Compass.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                     @" <p>
                         This sample illustrates how to make a direction compass by using the features in gauge. Color of the needle and direction labels can be customized by using options in the property panel.
                     </p>"
                 },
                 Description = new string[] {
                     @"<p>
                         The circular gauge can be customized as per the user requirement. In this example, a direction compass has been depicted by adding needle tail to the pointer of the circular gauge and by customizing the labels to show the direction.
                     </p>
                     <p>
                         More information on the circular gauge can be found in this
                         <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/circular-gauge/getting-started/"">documentation section</a>.
                     </p>"
                }
            },			 
			 new Sample
            {
                Name = "Pointer Image",
                Category = "Pointer",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/pointer-image",
                FileName = "PointerImage.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample visualizes the short-put distance covered by the athletes by using the image pointer in gauge.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to use the pointer image for an axis in the circular gauge. Pointer value points out the
                        the actual value set in the circular gauge. You can customize the <code>CircularGaugePointers</code> to improve the
                        the appearance of the gauge.
                    <br>
                    <p>
                        In this sample, a pointer with an image is used to show the short-put distance thrown by the player.
                    </p>
                    <p>
                        More information on the circular gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/circular-gauge/getting-started/"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Pointer Customization",
                Category = "Pointer",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/pointer-customization",
                FileName = "PointerCustomization.razor",
                Type = SampleType.Updated,
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the different types of pointers which are available in the gauge.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to customize the pointer for an axis in the circular gauge. Circular gauge supports different types of pointers like marker, image, needle, range bar.
                    </p>
                    <p>
                        More information on the circular gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/circular-gauge/getting-started/"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Multiple Axis",
                Category = "Axes",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/multiple-axis",
                FileName = "MultipleAxis.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the multiple axes in the gauge and options are available to change the direction, start, and end angle of an axis.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render and configure multiple axes in gauge. Use axes collection to render multiple axes in gauge. Each axis can be customized with its pointers and ticks.
                    </p>
                    <p>
                        More information on the circular gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/circular-gauge/gauge-axes/"">documentation section</a>.
                    </p>"
                }

            },
            new Sample
            {
                Name = "Pointer & Ranges Drag",
                Category = "User Interaction",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/pointer-drag",
                FileName = "PointerDrag.razor",
                Type = SampleType.Updated,
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes pointer and ranges drag in circular gauge. The position of pointer value can be changed by using pointer value and we can drag the pointer and ranges by enabling pointer drag and range drag options.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to move pointers and ranges in gauge using drag and drop. Use <code>EnablePointerDrag</code> property, to enable or disable the pointer drag functionality. Use <code>EnableRangeDrag</code> property, to enable or disable the range drag functionality.
                    </p>
                    <p>
                        More information on the circular gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/circular-gauge/getting-started/"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Tooltip",
                Category = "User Interaction",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/tooltip",
                FileName = "Tooltip.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample visualizes the tooltip of pointer value and range value in circular gauge.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to show the tooltip for a pointer in a circular gauge. To see the tooltip in action, hover pointer or tap on the pointer in touch-enabled devices.
                    </p>
                    <p>
                        More information on the tooltip can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/circular-gauge/gauge-user-interaction/"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Print & Export",
                Category = "Export",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/export",
                FileName = "Export.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the print and export functionality of circular gauge.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to export and print the rendered circular gauge. The circular gauge can be exported to <b>JPEG, PNG, SVG</b> and <b>PDF</b> formats.
                    </p>
                    <p>
                        More information on the tooltip can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/circular-gauge/getting-started/"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Data Sample",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/data-sample",
                FileName = "DataSample.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                    This sample demonstrates the live data sample in a circular gauge.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        Pointer values in the gauge can be updated dynamically by using <code>SetPointerValue</code> method. In this example, a stock price changes over the countries, are showed by using a circular gauge.
                    </p>
                    <p>
                        More information on the range and pointer customization can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/circular-gauge/getting-started/"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Apple Watch Rings",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/apple-watch-rings",
                FileName = "AppleWatchRings.razor",
                Type = SampleType.None,
                 ActionDescription = new string[] {
                    @" <p>
                        This sample resembles the appearance of Apple watch rings. This functions similarly to an activity tracker that denotes the move, exercise, and stand details.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to make the circular gauge look like the Apple watch rings. Ranges are rendered with rounded corners and annotations are placed to denote the move, exercise, and stand values.
                    </p>
                    <p>
                        More information on the circular gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/circular-gauge/getting-started/"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Speedometer",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/speedometer",
                FileName = "Speedometer.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                    This sample depicts the appearance of speedometer rendered using the circular gauge component. The pointer value is updated with random values dynamically.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to make circular gauge appear like a speedometer. The labels can be changed, gap can be added between the ranges, or the ranges can be combined to form single range using the options provided in the properties panel.
                    </p>
                    <p>
                        More information on the range and pointer customization can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/circular-gauge/getting-started/"">documentation section</a>.
                    </p>"
                }

            }
        };
    }
}
