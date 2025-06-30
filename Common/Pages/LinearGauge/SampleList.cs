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
        public List<Sample> LinearGauge { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Linear Gauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Linear Gauge Component | Default Functionalities | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Default Functionalities",
                MetaDescription = "This Blazor Linear Gauge example demonstrates the default visualization of a linear gauge with essential elements like axis, range, and pointer to represent data in a linear scale.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Container",
                Category = "Axis",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/container",
                FileName = "Container.razor",
                MetaTitle = "Blazor Linear Gauge Container | Customization Options | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Container Customization",
                MetaDescription = "This Blazor Linear Gauge example demonstrates container customization options including background, border settings, and margin adjustments to enhance the visual presentation of the gauge.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Track",
                Category = "Axis",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/track",
                FileName = "Track.razor",
                MetaTitle = "Blazor Linear Gauge Track | Customization Features | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Track Customization",
                MetaDescription = "This Blazor Linear Gauge example demonstrates track customization options including color, width, and offset adjustments to create visually enhanced linear gauge displays.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Ticks",
                Category = "Axis",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/ticks",
                FileName = "Ticks.razor",
                MetaTitle = "Blazor Linear Gauge Ticks | Interval Customization | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Ticks Customization",
                MetaDescription = "This Blazor Linear Gauge example demonstrates tick mark customization including interval, position, height, color, and formatting options to create precisely calibrated visual scales.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Labels",
                Category = "Axis",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/labels",
                FileName = "Labels.razor",
                MetaTitle = "Blazor Linear Gauge Labels | Format Customization | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Label Customization",
                MetaDescription = "This Blazor Linear Gauge example demonstrates label customization including format, position, font, color, and offset adjustments to enhance readability and visual presentation.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Range",
                Category = "Range",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/range",
                FileName = "Range.razor",
                MetaTitle = "Blazor Linear Gauge Ranges | Visual Data Segments | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Range Customization",
                MetaDescription = "This Blazor Linear Gauge example demonstrates range customization with multiple color bands highlighting different data segments, enhancing visual data interpretation with custom start and end points.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Marker Pointer",
                Category = "Pointer",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/marker-pointer",
                FileName = "MarkerPointer.razor",
                MetaTitle = "Blazor Linear Gauge Marker Pointer | Shape Options | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Marker Pointer Customization",
                MetaDescription = "This Blazor Linear Gauge example demonstrates marker pointer customization options including shapes, colors, positioning, and animation effects for precise data value indication on linear scales.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Bar Pointer",
                Category = "Pointer",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/bar-pointer",
                FileName = "BarPointer.razor",
                MetaTitle = "Blazor Linear Gauge Bar Pointer | Progress Visualization | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Bar Pointer Customization",
                MetaDescription = "This Blazor Linear Gauge example demonstrates bar pointer customization options including width, color, and rounded corners for visualizing progress or level indicators in linear measurements.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Custom Pointer",
                Category = "Pointer",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/custom-pointer",
                FileName = "CustomPointer.razor",
                MetaTitle = "Blazor Linear Gauge Custom Pointer | Advanced Visualization | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Custom Pointer Designs",
                MetaDescription = "This Blazor Linear Gauge example demonstrates how to implement custom-designed pointers using SVG and image elements to create unique visual indicators for specific application requirements.",
                Type = SampleType.None
            },
            new Sample
            {
               Name = "Tooltip",
               Category = "User Interaction",
               Directory = "LinearGauge/LinearGauge",
               Url = "linear-gauge/tooltip",
               FileName = "Tooltip.razor",
               MetaTitle = "Blazor Linear Gauge Tooltip | Interactive Data Display | Syncfusion",
               HeaderText = "Blazor Linear Gauge Example - Tooltip Configuration",
               MetaDescription = "This Blazor Linear Gauge example demonstrates tooltip configuration options including custom templates, formatting, and interactive behaviors to display detailed information on pointer hover.",
               Type = SampleType.None
            },
            new Sample
            {
                Name = "Print & Export",
                Category = "Print & Export",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/print-export",
                FileName = "PrintExport.razor",
                MetaTitle = "Blazor Linear Gauge Print and Export | Document Options | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Print and Export Features",
                MetaDescription = "This Blazor Linear Gauge example demonstrates print and export functionality allowing users to print gauges or export them to various file formats including PNG, JPEG, and PDF.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Progress Bar",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/progress-bar",
                FileName = "ProgressBar.razor",
                MetaTitle = "Blazor Linear Gauge Progress Bar | Task Completion | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Progress Bar Implementation",
                MetaDescription = "This Blazor Linear Gauge example demonstrates how to create a progress bar using the linear gauge component with customizable colors, animation, and value display to track completion status.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Step Progress Bar",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/step-progress-bar",
                FileName = "StepProgressBar.razor",
                MetaTitle = "Blazor Linear Gauge Step Progress | Multi-Stage Tracking | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Step Progress Bar Implementation",
                MetaDescription = "This Blazor Linear Gauge example demonstrates a step progress bar implementation showing completion status across multiple stages with distinct visual indicators for completed and pending steps.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Slider",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/slider",
                FileName = "Slider.razor",
                MetaTitle = "Blazor Linear Gauge Slider | Interactive Value Selection | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Interactive Slider Implementation",
                MetaDescription = "This Blazor Linear Gauge example demonstrates how to create an interactive slider with draggable pointer, value display, and customizable appearance for user input and value selection scenarios.",
                Type = SampleType.None
            },
            //new Sample
            //{
            //    Name = "Range Slider",
            //    Category = "Use Cases",
            //    Directory = "LinearGauge/LinearGauge",
            //    Url = "linear-gauge/range-slider",
            //    FileName = "RangeSlider.razor",
            //    Type = SampleType.New
            //},
            new Sample
            {
                Name = "Thermometer",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/thermometer",
                FileName = "Thermometer.razor",
                MetaTitle = "Blazor Linear Gauge Thermometer | Temperature Visualization | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Thermometer Visualization",
                MetaDescription = "This Blazor Linear Gauge example demonstrates how to create a thermometer visualization with temperature scale, custom range colors, and realistic appearance for temperature monitoring applications.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Steps Counter",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/steps-counter",
                FileName = "StepsCounter.razor",
                MetaTitle = "Blazor Linear Gauge Steps Counter | Fitness Tracking | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Steps Counter Implementation",
                MetaDescription = "This Blazor Linear Gauge example demonstrates a step counter visualization for fitness applications, showing daily step targets with customizable appearance and progress indication features.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Volume Settings",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/volume-settings",
                FileName = "VolumeSettings.razor",
                MetaTitle = "Blazor Linear Gauge Volume Control | Audio Settings | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Volume Control Implementation",
                MetaDescription = "This Blazor Linear Gauge example demonstrates a volume control interface with interactive adjustment, visual feedback, and customizable appearance for audio control applications.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Battery Indicator",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/battery-indicator",
                FileName = "BatteryIndicator.razor",
                MetaTitle = "Blazor Linear Gauge Battery Indicator | Power Level Display | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Battery Level Indicator",
                MetaDescription = "This Blazor Linear Gauge example demonstrates a battery level indicator with color-coded ranges, custom shape, and realistic appearance for monitoring power status in device applications.",
                Type = SampleType.None
            }
         };
    }
}
