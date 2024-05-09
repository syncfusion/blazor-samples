#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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
        public List<Sample> CircularGauge { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Circular Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Added animation support to the demo by providing appropriate animation duration for the gauge and its elements." }
            },
            
            new Sample
            {
                Name = "Ticks and Labels",
                Category = "Axis",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/ticks-and-labels",
                FileName = "TicksLabels.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multiple Axes",
                Category = "Axis",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/multiple-axes",
                FileName = "MultipleAxes.razor",
                Type = SampleType.None
            },            
            new Sample
            {
                Name = "Custom Labels",
                Category = "Axis",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/custom-labels",
                FileName = "CustomLabels.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Added animation support to the demo by providing appropriate animation duration for the gauge and its elements." }
            },
            new Sample
            {
                Name = "Range Color for Axis",
                Category = "Axis",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/range-color-for-axis",
                FileName = "RangeColorsForAxis.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Added animation support to the demo by providing appropriate animation duration for the gauge and its elements." }
            },
            new Sample
            {
                Name = "Axis Background",
                Category = "Axis",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/axis-background",
                FileName = "AxisBackground.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pointer Types",
                Category = "Pointer",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/pointer-types",
                FileName = "PointerTypes.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Text Pointer",
                Category = "Pointer",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/text-pointer",
                FileName = "TextPointer.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Image Pointer",
                Category = "Pointer",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/image-pointer",
                FileName = "ImagePointer.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Range Customization",
                Category = "Range",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/range-customization",
                FileName = "RangeCustomization.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multiple Ranges",
                Category = "Range",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/multiple-ranges",
                FileName = "MultipleRanges.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Added animation support to the demo by providing appropriate animation duration for the gauge and its elements." }
            },
            new Sample
            {
                Name = "Legend",
                Category = "Range",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/legend",
                FileName = "Legend.razor",
                Type = SampleType.None
            },            
            new Sample
            {
                Name = "Arc Gauge",
                Category = "Arc Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/arc-gauge",
                FileName = "Arcgauge.razor",
                Type = SampleType.None
            },	
			new Sample
			{
			    Name = "Semi-circular Gauge",
			    Category = "Arc Gauge",
			    Directory = "CircularGauge/CircularGauge",
			    Url = "circular-gauge/semi-circular-gauge",
			    FileName = "Semicirculargauge.razor",
                Type = SampleType.None
			},
            new Sample
            {
                Name = "Pointer & Ranges Drag",
                Category = "User Interaction",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/pointer-ranges-drag",
                FileName = "PointerRangesDrag.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "User Interaction",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/tooltip",
                FileName = "Tooltip.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Added animation support to the demo by providing appropriate animation duration for the gauge and its elements." }
            },
            new Sample
            {
                Name = "Print & Export",
                Category = "Print & Export",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/print-export",
                FileName = "PrintExport.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Clock",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/clock",
                FileName = "Clock.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Radial Slider",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/radial-slider",
                FileName = "RadialSlider.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Direction Compass",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/direction-compass",
                FileName = "DirectionCompass.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Speedometer",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/speedometer",
                FileName = "Speedometer.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Sleep Tracker",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/sleep-tracker",
                FileName = "SleepTracker.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Data Sample",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/data-sample",
                FileName = "DataSample.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Apple Watch Rings",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/apple-watch-rings",
                FileName = "AppleWatchRings.razor",
                Type = SampleType.None
            }
        };
    }
}
