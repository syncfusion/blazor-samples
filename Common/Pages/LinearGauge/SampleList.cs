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
        public List<Sample> LinearGauge { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Linear Gauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Container",
                Category = "Axis",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/container",
                FileName = "Container.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Track",
                Category = "Axis",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/track",
                FileName = "Track.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Ticks",
                Category = "Axis",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/ticks",
                FileName = "Ticks.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Added animation support to the demo by providing appropriate animation duration for the gauge and its elements." }
            },
            new Sample
            {
                Name = "Labels",
                Category = "Axis",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/labels",
                FileName = "Labels.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Added animation support to the demo by providing appropriate animation duration for the gauge and its elements." }
            },
            new Sample
            {
                Name = "Range",
                Category = "Range",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/range",
                FileName = "Range.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Added animation support to the demo by providing appropriate animation duration for the gauge and its elements." }
            },
            new Sample
            {
                Name = "Marker Pointer",
                Category = "Pointer",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/marker-pointer",
                FileName = "MarkerPointer.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Added animation support to the demo by providing appropriate animation duration for the gauge and its elements." }
            },
            new Sample
            {
                Name = "Bar Pointer",
                Category = "Pointer",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/bar-pointer",
                FileName = "BarPointer.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Added animation support to the demo by providing appropriate animation duration for the gauge and its elements." }
            },
            new Sample
            {
                Name = "Custom Pointer",
                Category = "Pointer",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/custom-pointer",
                FileName = "CustomPointer.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Added animation support to the demo by providing appropriate animation duration for the gauge and its elements." }
            },
            new Sample
            {
               Name = "Tooltip",
               Category = "User Interaction",
               Directory = "LinearGauge/LinearGauge",
               Url = "linear-gauge/tooltip",
               FileName = "Tooltip.razor",
               Type = SampleType.None
            },
            new Sample
            {
                Name = "Print & Export",
                Category = "Print & Export",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/print-export",
                FileName = "PrintExport.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Progress Bar",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/progress-bar",
                FileName = "ProgressBar.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Added animation support to the demo by providing appropriate animation duration for the gauge and its elements." }
            },
            new Sample
            {
                Name = "Step Progress Bar",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/step-progress-bar",
                FileName = "StepProgressBar.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Slider",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/slider",
                FileName = "Slider.razor",
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
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Steps Counter",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/steps-counter",
                FileName = "StepsCounter.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"Added animation support to the demo by providing appropriate animation duration for the gauge and its elements." }
            },
            new Sample
            {
                Name = "Volume Settings",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/volume-settings",
                FileName = "VolumeSettings.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Battery Indicator",
                Category = "Use Cases",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/battery-indicator",
                FileName = "BatteryIndicator.razor",
                Type = SampleType.None
            }
         };
    }
}
