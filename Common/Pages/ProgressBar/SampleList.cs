#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
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
        public List<Sample> ProgressBar { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Linear",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/linear",
                FileName = "Linear.razor",
                MetaTitle = "Blazor Progress Bar | Horizontal Progress Indicator | Syncfusion",
                HeaderText = "Blazor Progress Bar Example - Linear Progress",
                MetaDescription = "This demo shows horizontal progress visualization with customizable color, size, and animation. Track task completion or loading processes in web applications.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Circular",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/circular",
                FileName = "Circular.razor",
                MetaTitle = "Blazor Circular Progress Bar | Radial Progress Indicator | Syncfusion",
                HeaderText = "Blazor Progress Bar Example - Circular Progress",
                MetaDescription = "Blazor Circular ProgressBar demo shows how to display progress in circular format. Ideal for dashboards, compact UI layout requiring visual progress indicators.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Angle",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/angle",
                FileName = "Angle.razor",
                MetaTitle = "Blazor Progress Bar Angle | Semi-Circular Progress | Syncfusion",
                HeaderText = "Blazor Progress Bar Example - Angle Customization",
                MetaDescription = "This Blazor Progress Bar demo shows angle customization to create semi-circular progress indicator. Adjust start and end angles for unique visualization styles.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Labels",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/labels",
                FileName = "Labels.razor",
                MetaTitle = "Blazor Progress Bar Labels | Text Annotation | Syncfusion",
                HeaderText = "Blazor Progress Bar Example - Label Customization",
                MetaDescription = "This demo shows custom label options including format, position, and styling. Add informative text with percentage or value displays to progress indicators.",
                Type = SampleType.None
            },            
            new Sample
            {
                Name = "Radius",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/radius",
                FileName = "Radius.razor",
                MetaTitle = "Blazor Progress Bar Radius | Size Customization | Syncfusion",
                HeaderText = "Blazor Progress Bar Example - Radius Customization",
                MetaDescription = "This demo shows how to customize inner and outer radius values to create rings of various thicknesses. Adapt progress visualization to fit different UI spaces.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stripes",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/stripes",
                FileName = "Stripes.razor",
                MetaTitle = "Blazor Striped Progress Bar | Animated Patterns | Syncfusion",
                HeaderText = "Blazor Progress Bar Example - Striped Progress",
                MetaDescription = "This example demonstrates striped progress bars with optional animation effects. Add visual interest to progress indicators with diagonal patterns and motion.",
                Type = SampleType.None
            },
			new Sample
            {
                Name = "Progress Segment",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/progress-segment",
                FileName = "ProgressSegment.razor",
                MetaTitle = "Blazor Progress Bar Segments | Multi Progress Indicators | Syncfusion",
                HeaderText = "Blazor Progress Bar Example - Progress Segments",
                MetaDescription = "This demo shows segmented progress visualization for displaying multiple progress states in a single bar. Ideal for multi-stage processes or comparing values.",
                Type = SampleType.None
            }
        };
    }
}
