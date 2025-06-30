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
        public List<Sample> ProgressBar { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Linear",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/linear",
                FileName = "Linear.razor",
                MetaTitle = "Blazor Linear Progress Bar | Horizontal Progress Indicator | Syncfusion",
                HeaderText = "Blazor Progress Bar Example - Linear Progress",
                MetaDescription = "This Blazor Linear Progress Bar example demonstrates horizontal progress visualization with customizable color, size, and animation. Track task completion or loading processes in web applications.",
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
                MetaDescription = "This Blazor Circular Progress Bar example shows how to display progress in a circular format. Ideal for dashboards and compact UI layouts requiring visual progress indicators.",
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
                MetaDescription = "This Blazor Progress Bar example demonstrates angle customization to create semi-circular progress indicators. Adjust start and end angles for unique visualization styles.",
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
                MetaDescription = "This Blazor Progress Bar example demonstrates label customization options including format, position, and styling. Add informative text with percentage or value displays to progress indicators.",
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
                MetaDescription = "This Blazor Progress Bar example shows how to customize inner and outer radius values to create rings of various thicknesses. Adapt progress visualization to fit different UI spaces.",
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
                MetaDescription = "This Blazor Progress Bar example demonstrates striped progress bars with optional animation effects. Add visual interest to progress indicators with diagonal patterns and motion.",
                Type = SampleType.None
            },
			new Sample
            {
                Name = "Progress Segment",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/progress-segment",
                FileName = "ProgressSegment.razor",
                MetaTitle = "Blazor Progress Bar Segments | Multiple Progress Indicators | Syncfusion",
                HeaderText = "Blazor Progress Bar Example - Progress Segments",
                MetaDescription = "This Blazor Progress Bar example demonstrates segmented progress visualization for displaying multiple progress states in a single bar. Ideal for multi-stage processes or comparing values.",
                Type = SampleType.None
            }
        };
    }
}
