using System.Collections.Generic;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> CircularGauge { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "CircularGauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                TitleTag = "CircularGauge . Default . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor CircularGauge component illustrates the default rendering of circular gauge with Major Ticks, Minor Ticks and Pointer",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates the default rendering of circular gauge.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render a default circular gauge. The CircularGauge control visualizes the numerical values of scales in a circular manner. You can use <code>axes</code>, <code>ranges</code>, <code>pointers</code> properties to customize the default appearance of the gauge. In this sample, a axis with multiple ranges and a pointer has been used.
                    </p>
                    <p>
                        More information on the gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Range",
                Category = "CircularGauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/Range",
                FileName = "Range.razor",
                TitleTag = "CircularGauge . Range . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor CircularGauge component shows how to highlight specific regions in an axis by using ranges. Color and Width can be customized",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates how to highlight a region in an axis by using ranges in gauge. Start, end, color, width and corner radius of the range can be changed by using the options provided in the property panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to customize the ranges of an axis in the circular gauge. Ranges are used to group the axis values, you can use <code>start, end, color, startWidth, endWidth, radius and roundedCornerRadius</code> properties to customize the ranges. In this sample, an axis is shown with one range and options to customize the range properties with property panel.
                    </p>
                    <p>
                        More information on the gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Ticks and Labels",
                Category = "CircularGauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/Labels",
                FileName = "Labels.razor",
                TitleTag = "CircularGauge . Labels . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor CircularGauge component shows customizing options in ticks and labels of an axis. Position, Size and offset can be customized",
                Type = SampleType.None,
                 ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates how to customize the ticks and labels of an axis. Position, offset, and height of the tick and label can be changed by using the options provided in the property panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render and configure the ticks and labels of an axis in the circular gauge. Labels are
                        units that are used to display the values in the axis. You can customize <code>labels</code> with the properties
                        like <code>angle</code>, <code>font</code>,
                        <code>position</code>, etc. Ticks are used to mark some values on the axis. You can also customize the ticks using
                        <code>majorTicks</code>,
                        <code>minorTicks</code> properties.
                    </p>
                    <p>
                        More information on the labels can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section</a>.
                    </p>"
                }
            },
            //  new Sample
            // {
            //     Name = "Annotation",
            //     Category = "CircularGauge",
            //     Directory = "CircularGauge/CircularGauge",
            //     Url = "CircularGauge/Annotation",
            //     FileName = "Annotation.razor",
            //     TitleTag = "CircularGauge . Annotations . Syncfusion Blazor Components",
            //     MetaDescription = "This demo of Syncfusion Blazor CircularGauge component illustrates a clock by using annotation in the Circular Gauge",
            //     Type = SampleType.None
            // },
             new Sample
            {
                Name = "Gauge Customization",
                Category = "CircularGauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/Customization",
                FileName = "Customization.razor",
                TitleTag = "CircularGauge . Customization . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Circular Gauge component shows the customizing options of pointers. Colors of Pointer, Range and RangeBar can be customized",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates how to customize the gauge with pointers. Options to change the color and type of the pointer are available in the property panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to customize the gauge elements such as <code> pointers </code> and <code> range </code>. Here a needle and range bar are added to show the current value and its appearance can be customized here.
                    </p>
                    <p>
                        More information on the range and pointer customization can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Semi-Circular Gauge",
                Category = "CircularGauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/Semicirculargauge",
                FileName = "Semicirculargauge.razor",
                TitleTag = "CircularGauge . SemiCircularGauge . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor CircularGauge component depicts the circularGauge with customizing options.Radius, Angles and center positon can be customized",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the rendering of circular gauge with modified start and end angles. The radius, start angle, end angle, center X, and center Y of the circular gauge can be customized using the options in properties panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the circular gauge with modified start and end angles to form semi or quarter circular gauges. By enabling the radius based on angle option, the radius of circular gauge will be calculated based on the start and end angles.
                    </p>
                    <p>
                        More information on the gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section</a>.
                    </p>"
                }
            },	
			 new Sample
			{
			    Name = "Arc Gauge",
			    Category = "CircularGauge",
			    Directory = "CircularGauge/CircularGauge",
			    Url = "CircularGauge/ArcGauges",
			    FileName = "ArcGauges.razor",
                TitleTag = "CircularGauge . Arc Gauge . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor CircularGauge Component visualizes the progress of a work using the range bar pointer with rounded corners",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the progress of a work in the circular gauge using the range bar pointer with rounded corners.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the ranges and range bar pointer with rounded corners. The EJ2 Slider control is placed at the bottom of the gauge using annotation to change the range bar pointer value. Based on the value, color of the pointer can also be changed.
                    </p>
                    <p>
                        More information on the gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section</a>.
                    </p>"
                }
			},
              new Sample
            {
                Name = "Legend",
                Category = "CircularGauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/CircularGaugeLegend",
                FileName = "CircularGaugeLegend.razor",
                TitleTag = "CircularGauge . Legend . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor CircularGauge Components visualizes moving air types using legend. Legend shape, alignment, and position can be customized",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes moving air types in the legend based on their speed. The visibility, shape, alignment and position of the legend can be changed using the properties panel options.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render a legend in circular gauge. A legend item denotes the axis ranges. Any number of legend items can be added to a legend. You can bind the desired colors and legend text to the corresponding ranges.
                    </p>
                    <p>
                        More information on the gauge can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Direction Compass",
                Category = "CircularGauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/Compass",
                FileName = "Compass.razor",
                TitleTag = "CircularGauge . Direction Compass . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Circular Gauge component illustrates how to make a direction compass by using the circular Gauge",
                Type = SampleType.None,
                ActionDescription = new string[] {
                     @" <p>
                         This sample illustrates how to make a direction compass by using the features in gauge. Color of the needle and direction labels can be customized by using options.
                     </p>"
                 },
                 Description = new string[] {
                     @"<p>
                         Circular gauge can be customized as per a user requirement. In this example, a direction compass has been depicted by adding <code> needles </code> and by customizing the <code> labels</code> to show the direction.
                     </p>
                     <p>
                         More information on the gauge can be found in this
                         <a target=""_blank"" href=""http://ej2.syncfusion.com/documentation"">documentation section</a>.
                     </p>"
                }
            },			 
			 new Sample
            {
                Name = "Pointer Image",
                Category = "Pointer",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/PointerImage",
                FileName = "PointerImage.razor",
                TitleTag = "CircularGauge . Image Pointer . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor CircularGauge component visualizes the short-put distance covered by the athletes by using the image pointer",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample visualizes the short-put distance covered by the athletes by using the image pointer in gauge.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to use the pointer image for an axis in the circular gauge. Pointer value points out the
                        actual value set in the <b>Circular Gauge</b>. You can customize the <code>pointers</code> to improve the
                        appearance of <b>Gauge</b>.
                    </p>
                    <br>
                    <p>
                        In this sample, a pointer with image is used to show the short-put distance thrown by the player.
                    </p>
                    <p>
                        More information on the pointers can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Pointer Customization",
                Category = "Pointer",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/PointerCustomization",
                FileName = "PointerCustomization.razor",
                TitleTag = "CircularGauge . Pointer . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor CircularGauge component shows the pointers types available in CircularGauge. Marker, RangeBar and Needle are the pointer types",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the different types of pointers which are available in the gauge.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to customize the pointer for an axis in the circular gauge. Gauge supports different types of pointers like <code>marker</code>, <code>image</code>, <code>needle</code>, <code>rangeBar</code>.
                    </p>
                    <p>
                        More information on the gauge can be found in this
                        <a target=""_blank"" href=""http://ej2.syncfusion.com/documentation"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Multiple Axis",
                Category = "Axes",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/MultipleAxis",
                FileName = "MultipleAxis.razor",
                TitleTag = "CircularGauge . MultipleAxis . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor CircularGauge component visualizes the circular Gauge with multiple axes",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the multiple axes in the gauge and options are available to change the direction, start, and end angle of an axis.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render and configure multipe axes in gauge. Use axes collection to render multiple axis in gauge. Each axis can be customized with its own <code>pointer</code> and <code>scales</code>.
                    </p>
                    <p>
                        More information on the gauge can be found in this
                        <a target=""_blank"" href=""http://ej2.syncfusion.com/documentation"">documentation section</a>.
                    </p>"
                }

            },
            new Sample
            {
                Name = "Pointer Drag",
                Category = "User Interaction",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/PointerDrag",
                FileName = "PointerDrag.razor",
                TitleTag = "CircularGauge . PointerDrag . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor CircularGauge component visualizes the pointer drag and how to enable the pointer drag",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes pointer drag in circular gauge. Position of pointer value can be changed by using <code>Pointer Value</code> and we can drag the pointer by enabling drag option.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to move pointers in gauge using drag and drop. Use <code>enablePointerDrag</code> property, to achieve this behavior.
                    </p>
                    <p>
                        More information on the gauge can be found in this
                        <a target=""_blank"" href=""http://ej2.syncfusion.com/documentation"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Tooltip",
                Category = "User Interaction",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/Tooltip",
                FileName = "Tooltip.razor",
                TitleTag = "CircularGauge . Tooltip . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor CircularGauge component visualizes the tooltip for CircularGauge pointer and ranges",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample visualizes the tooltip of pointer value in gauge. To see the tooltip in action, hover pointer or tap the pointer.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to show the tooltip for pointer in gauge, to see the tooltip in action, hover pointer or tap on pointer in touch enabled devices.
                    </p>
                    <br>
                    <p>
                        More information on the tooltip can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Data Sample",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/DataSample",
                FileName = "DataSample.razor",
                TitleTag = "CircularGauge . Data Sample . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor CircularGauge component demonstrates live data, along with the data grid component",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                    This sample demonstrates the live data sample in circular gauge.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        Pointer values in the gauge can be updated dynamically by using <code>setPointerValue</code> method. In this example, a stock price changes over the countries, are showed by using a gauge.
                    </p>
                    <p>
                        More information on the range and pointer customization can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Apple Watch Rings",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/AppleWatchRings",
                FileName = "AppleWatchRings.razor",
                TitleTag = "CircularGauge . AppleWatchRings . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor CircularGauge Component resembles the appearance of Apple watch rings. It tracks the move, exercise and stand details",
                Type = SampleType.None,
                 ActionDescription = new string[] {
                    @" <p>
                        This sample resembles the appearance of Apple watch rings. This functions similar to an activity tracker that denotes the move, exercise, and stand details.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to make the circular gauge look like the Apple watch rings. Ranges are rendered with rounded corners and annotations are placed to denote the move, exercise, and stand values.
                    </p>
                    <p>
                        More information on the gauge can be found in this
                        <a target=""_blank"" href=""http://ej2.syncfusion.com/documentation"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Speedometer",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/Speedometer",
                FileName = "Speedometer.razor",
                TitleTag = "CircularGauge . Speedometer . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor CircularGauge component depicts the appearance of speedometer rendered using the circular gauge",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                    This sample depicts the appearance of speedometer rendered using the circular gauge. The pointer is changed with random values dynamically.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to make the look of circular gauge like a speedometer. The labels can be changed to text values, gap can be added between the ranges, or the ranges can be combined to form single range using the options in the properties panel.
                    </p>
                    <p>
                        More information on the range and pointer customization can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section</a>.
                    </p>"
                }

            }
        };
    }
}
