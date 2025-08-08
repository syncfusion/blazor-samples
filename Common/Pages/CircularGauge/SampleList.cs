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
        public List<Sample> CircularGauge { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Circular Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Circular Gauge Default Functionalities - Syncfusion Demos",
                HeaderText = "Blazor Circular Gauge Example - Default Functionalities",
                MetaDescription = "This Blazor Circular Gauge default example demonstrates basic gauge features with customizable ranges, pointers, and styling options for data visualization.",
                Type = SampleType.None
            },
            
            new Sample
            {
                Name = "Ticks and Labels",
                Category = "Axis",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/ticks-and-labels",
                FileName = "TicksLabels.razor",
                MetaTitle = "Blazor Circular Gauge Ticks Labels | Axis Styling | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Ticks and Labels",
                MetaDescription = "This Blazor Circular Gauge demonstrates customizable tick marks and labels with various positioning, styling, and formatting options for enhanced readability.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multiple Axes",
                Category = "Axis",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/multiple-axes",
                FileName = "MultipleAxes.razor",
                MetaTitle = "Blazor Circular Gauge Multiple Axes | Multi-Scale | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Multiple Axes",
                MetaDescription = "This Blazor Circular Gauge with Multiple Axes demonstrates multi-scale visualization with different ranges and units for comprehensive data display.",
                Type = SampleType.None
            },            
            new Sample
            {
                Name = "Custom Labels",
                Category = "Axis",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/custom-labels",
                FileName = "CustomLabels.razor",
                MetaTitle = "Blazor Circular Gauge Custom Labels | Label Format | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Custom Labels",
                MetaDescription = "This Blazor Circular Gauge with Custom Labels demonstrates personalized label formatting and positioning for enhanced data presentation and branding.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Range Color for Axis",
                Category = "Axis",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/range-color-for-axis",
                FileName = "RangeColorsForAxis.razor",
                MetaTitle = "Blazor Circular Gauge Range Colors | Color Coding | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Range Color for Axis",
                MetaDescription = "This Blazor Circular Gauge demonstrates range-based color coding for axis elements to provide visual indicators and improved data interpretation.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Axis Background",
                Category = "Axis",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/axis-background",
                FileName = "AxisBackground.razor",
                MetaTitle = "Blazor Circular Gauge Axis Background | Visual Design | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Axis Background",
                MetaDescription = "This Blazor Circular Gauge with Axis Background demonstrates customizable background styling for enhanced visual appeal and professional presentation.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pointer Types",
                Category = "Pointer",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/pointer-types",
                FileName = "PointerTypes.razor",
                MetaTitle = "Blazor Circular Gauge Pointer Types | Value Indicators | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Pointer Types",
                MetaDescription = "This Blazor Circular Gauge demonstrates various pointer types including needle, marker, and range bar for flexible value indication and visualization.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Text Pointer",
                Category = "Pointer",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/text-pointer",
                FileName = "TextPointer.razor",
                MetaTitle = "Blazor Circular Gauge Text Pointer | Text Values | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Text Pointer",
                MetaDescription = "This Blazor Circular Gauge with Text Pointer demonstrates textual value display with customizable fonts, colors, and positioning for clear data presentation.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Image Pointer",
                Category = "Pointer",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/image-pointer",
                FileName = "ImagePointer.razor",
                MetaTitle = "Blazor Circular Gauge Image Pointer | Custom Icons | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Image Pointer",
                MetaDescription = "This Blazor Circular Gauge with Image Pointer demonstrates custom icon-based value indicators for enhanced visual appeal and brand customization.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Range Customization",
                Category = "Range",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/range-customization",
                FileName = "RangeCustomization.razor",
                MetaTitle = "Blazor Circular Gauge Range Custom | Visual Zones | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Range Customization",
                MetaDescription = "This Blazor Circular Gauge demonstrates range customization with colors, gradients, and styling for creating visual zones and data categorization.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multiple Ranges",
                Category = "Range",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/multiple-ranges",
                FileName = "MultipleRanges.razor",
                MetaTitle = "Blazor Circular Gauge Multiple Ranges | Data Zones | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Multiple Ranges",
                MetaDescription = "This Blazor Circular Gauge with Multiple Ranges demonstrates overlapping data zones with different colors for comprehensive value categorization.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Legend",
                Category = "Range",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/legend",
                FileName = "Legend.razor",
                MetaTitle = "Blazor Circular Gauge Legend | Range Guide | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Legend",
                MetaDescription = "This Blazor Circular Gauge with Legend demonstrates interactive range identification and guidance for enhanced data interpretation and user understanding.",
                Type = SampleType.None
            },            
            new Sample
            {
                Name = "Arc Gauge",
                Category = "Arc Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/arc-gauge",
                FileName = "Arcgauge.razor",
                MetaTitle = "Blazor Arc Gauge | Partial Circle View | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Arc Gauge",
                MetaDescription = "This Blazor Arc Gauge demonstrates partial circular visualization with customizable arc angles for space-efficient data display and modern design.",
                Type = SampleType.None
            },	
			new Sample
			{
			    Name = "Semi-circular Gauge",
			    Category = "Arc Gauge",
			    Directory = "CircularGauge/CircularGauge",
			    Url = "circular-gauge/semi-circular-gauge",
			    FileName = "Semicirculargauge.razor",
			    MetaTitle = "Blazor Semi-Circular Gauge | Half Circle | Syncfusion",
			    HeaderText = "Blazor Circular Gauge Example - Semi-circular Gauge",
			    MetaDescription = "This Blazor Semi-circular Gauge demonstrates half-circle data visualization for compact layouts and dashboard applications with space constraints.",
                Type = SampleType.None
			},
            new Sample
            {
                Name = "Pointer & Ranges Drag",
                Category = "User Interaction",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/pointer-ranges-drag",
                FileName = "PointerRangesDrag.razor",
                MetaTitle = "Blazor Circular Gauge Drag | Interactive Control | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Pointer & Ranges Drag",
                MetaDescription = "This Blazor Circular Gauge demonstrates interactive drag functionality for pointers and ranges, enabling real-time value adjustment and user control.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "User Interaction",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/tooltip",
                FileName = "Tooltip.razor",
                MetaTitle = "Blazor Circular Gauge Tooltip | Hover Information | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Tooltip",
                MetaDescription = "This Blazor Circular Gauge with Tooltip demonstrates interactive hover information display for enhanced data exploration and detailed value insights.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Print & Export",
                Category = "Print & Export",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/print-export",
                FileName = "PrintExport.razor",
                MetaTitle = "Blazor Circular Gauge Export | Document Output | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Print & Export",
                MetaDescription = "This Blazor Circular Gauge demonstrates printing and export capabilities for generating reports and sharing gauge visualizations in multiple formats.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Clock",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/clock",
                FileName = "Clock.razor",
                MetaTitle = "Blazor Circular Gauge Clock | Time Display | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Clock",
                MetaDescription = "This Blazor Circular Gauge Clock demonstrates real-time clock functionality with customizable hour, minute, and second hands for time visualization.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Radial Slider",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/radial-slider",
                FileName = "RadialSlider.razor",
                MetaTitle = "Blazor Radial Slider | Circular Control | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Radial Slider",
                MetaDescription = "This Blazor Radial Slider demonstrates circular input control with smooth value selection and interactive user interface for modern applications.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Direction Compass",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/direction-compass",
                FileName = "DirectionCompass.razor",
                MetaTitle = "Blazor Direction Compass | Navigation Tool | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Direction Compass",
                MetaDescription = "This Blazor Direction Compass demonstrates navigation visualization with directional indicators and cardinal points for location-based applications.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Speedometer",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/speedometer",
                FileName = "Speedometer.razor",
                MetaTitle = "Blazor Speedometer | Speed Measurement | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Speedometer",
                MetaDescription = "This Blazor Speedometer demonstrates speed measurement visualization with realistic gauge design for automotive and performance monitoring applications.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Sleep Tracker",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/sleep-tracker",
                FileName = "SleepTracker.razor",
                MetaTitle = "Blazor Sleep Tracker | Health Monitoring | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Sleep Tracker",
                MetaDescription = "This Blazor Sleep Tracker demonstrates health monitoring visualization with sleep pattern analysis and progress tracking for wellness applications.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Data Sample",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/data-sample",
                FileName = "DataSample.razor",
                MetaTitle = "Blazor Circular Gauge Data Sample | Real Data | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Data Sample",
                MetaDescription = "This Blazor Circular Gauge Data Sample demonstrates real-world data integration with dynamic updates and practical business use case scenarios.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Apple Watch Rings",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/apple-watch-rings",
                FileName = "AppleWatchRings.razor",
                MetaTitle = "Blazor Apple Watch Rings | Activity Tracker | Syncfusion",
                HeaderText = "Blazor Circular Gauge Example - Apple Watch Rings",
                MetaDescription = "This Blazor Apple Watch Rings demonstrates activity tracking visualization with multiple progress rings for fitness and health monitoring applications.",
                Type = SampleType.None
            }
        };
    }
}