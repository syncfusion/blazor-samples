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
                MetaTitle = "Blazor LinearGauge Demos - Default Examples | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor LinearGauge visualizes data on a linear scale with axes, ranges, and pointers to deliver clear and accurate value representation.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-linear-gauge"
            },
            new Sample
            {
                Name = "Container",
                Category = "Axis",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/container",
                FileName = "Container.razor",
                MetaTitle = "Blazor LinearGauge - Container | LinearGauge Demos | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Container Customization",
                MetaDescription = "See how the Syncfusion Blazor LinearGauge customizes container styles with background, borders, and margins to enhance visual presentation and layout control.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Track",
                Category = "Axis",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/track",
                FileName = "Track.razor",
                MetaTitle = "Blazor LinearGauge Examples - Track | LinearGauge Demos | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Track Customization",
                MetaDescription = "See how the Syncfusion Blazor LinearGauge customizes tracks with color, width, and offset settings to create clear and visually appealing linear gauge displays.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Ticks",
                Category = "Axis",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/ticks",
                FileName = "Ticks.razor",
                MetaTitle = "Blazor LinearGauge Examples - Ticks | LinearGauge Demos | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Ticks Customization",
                MetaDescription = "See how the Syncfusion Blazor LinearGauge configures ticks with interval, position, and styling to improve precision and readability in measurement displays.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Labels",
                Category = "Axis",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/labels",
                FileName = "Labels.razor",
                MetaTitle = "Blazor LinearGauge Examples - Labels | LinearGauge Demos | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Label Customization",
                MetaDescription = "See how the Syncfusion Blazor LinearGauge customizes labels with formatting, positioning, and styling to enhance readability and improve data interpretation.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Range",
                Category = "Range",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/range",
                FileName = "Range.razor",
                MetaTitle = "Blazor LinearGauge Examples - Range | LinearGauge Demos | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Range Customization",
                MetaDescription = "See how the Syncfusion Blazor LinearGauge highlights data ranges with multiple color bands and custom start and end values to improve visual data segmentation.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Marker Pointer",
                Category = "Pointer",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/marker-pointer",
                FileName = "MarkerPointer.razor",
                MetaTitle = "Blazor LinearGauge - Marker Pointer | LinearGauge Demos | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Marker Pointer Customization",
                MetaDescription = "See how the Syncfusion Blazor LinearGauge uses marker pointers with shapes, colors, and animations to precisely indicate values on linear measurement scales.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Bar Pointer",
                Category = "Pointer",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/bar-pointer",
                FileName = "BarPointer.razor",
                MetaTitle = "Blazor LinearGauge - Bar Pointer | LinearGauge Demos | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Bar Pointer Customization",
                MetaDescription = "See how the Syncfusion Blazor LinearGauge uses bar pointers with width, color, and rounded edges to represent progress and level indicators effectively.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Custom Pointer",
                Category = "Pointer",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/custom-pointer",
                FileName = "CustomPointer.razor",
                MetaTitle = "Blazor LinearGauge - Custom Pointer | LinearGauge Demos | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Custom Pointer Designs",
                MetaDescription = "See how the Syncfusion Blazor LinearGauge enables custom pointers using SVG and images to create unique indicators for specialized visualization needs.",
                Type = SampleType.None
            },
            new Sample
            {
               Name = "Tooltip",
               Category = "User Interaction",
               Directory = "LinearGauge/LinearGauge",
               Url = "linear-gauge/tooltip",
               FileName = "Tooltip.razor",
               MetaTitle = "Blazor LinearGauge Demos - Tooltip Examples | Syncfusion",
               HeaderText = "Blazor Linear Gauge Example - Tooltip Configuration",
               MetaDescription = "See how the Syncfusion Blazor LinearGauge displays tooltips with templates and formatting to provide detailed value insights during interactive user actions.",
               Type = SampleType.None
            },
            new Sample
            {
                Name = "Print & Export",
                Category = "Print & Export",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/print-export",
                FileName = "PrintExport.razor",
                MetaTitle = "Blazor LinearGauge - Print & Export | LinearGauge Demos | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Print and Export Features",
                MetaDescription = "See how the Syncfusion Blazor Linear Gauge Print and Export demo allows users to print gauges or export them to PNG, JPEG, and PDF formats easily and reliably.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Progress Bar",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/progress-bar",
                FileName = "ProgressBar.razor",
                MetaTitle = "Blazor LinearGauge - Progress Bar | LinearGauge Demos | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Progress Bar Implementation",
                MetaDescription = "See how the Syncfusion Blazor Linear Gauge Progress Bar demo creates a customizable progress indicator with colors, animation, and values to track completion.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Step Progress Bar",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/step-progress-bar",
                FileName = "StepProgressBar.razor",
                MetaTitle = "Blazor LinearGauge Demos - Step Progress Bar Examples | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Step Progress Bar Implementation",
                MetaDescription = "See how the Syncfusion Blazor Linear Gauge Step Progress Bar demo visualizes multi-stage progress with clear indicators for completed and pending steps.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Slider",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/slider",
                FileName = "Slider.razor",
                MetaTitle = "Blazor LinearGauge Examples - Slider | LinearGauge Demos | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Interactive Slider Implementation",
                MetaDescription = "See how the Syncfusion Blazor Linear Gauge Slider demo creates interactive sliders with draggable pointers, value display, and customization for user input.",
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
                MetaTitle = "Blazor LinearGauge - Thermometer | LinearGauge Demos | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Thermometer Visualization",
                MetaDescription = "See how the Syncfusion Blazor Linear Gauge Thermometer demo displays temperature values with scale ranges, colors, and realistic styling for monitoring.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Steps Counter",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/steps-counter",
                FileName = "StepsCounter.razor",
                MetaTitle = "Blazor LinearGauge Demos - Step Counter Examples | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Steps Counter Implementation",
                MetaDescription = "See how the Syncfusion Blazor Linear Gauge Steps Counter demo visualizes daily step tracking with targets, progress indication, and customizable appearance.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Volume Settings",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/volume-settings",
                FileName = "VolumeSettings.razor",
                MetaTitle = "Blazor LinearGauge - Volume Settings | LinearGauge Demos | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Volume Control Implementation",
                MetaDescription = "See how the Syncfusion Blazor Linear Gauge Volume Settings demo provides an interactive control with visual feedback and customization for audio adjustment.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Battery Indicator",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/battery-indicator",
                FileName = "BatteryIndicator.razor",
                MetaTitle = "Blazor LinearGauge Demos - Battery Indicator Examples | Syncfusion",
                HeaderText = "Blazor Linear Gauge Example - Battery Level Indicator",
                MetaDescription = "See how the Syncfusion Blazor Linear Gauge Battery Indicator demo displays power levels with color ranges, custom shapes, and realistic status monitoring.",
                Type = SampleType.None
            }
         };
    }
}
