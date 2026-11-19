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
                MetaTitle = "Blazor ProgressBar Examples - Linear | ProgressBar Demos | Syncfusion",
                HeaderText = "Blazor Progress Bar Example - Linear Progress",
                MetaDescription = "See how the Syncfusion Blazor Linear displays horizontal progress with animation, color customization, and value tracking to monitor task completion clearly.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Circular",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/circular",
                FileName = "Circular.razor",
                MetaTitle = "Blazor ProgressBar - Circular | ProgressBar Demos | Syncfusion",
                HeaderText = "Blazor Progress Bar Example - Circular Progress",
                MetaDescription = "See how the Syncfusion Blazor Circular shows progress using radial indicators with animation and styling options to suit dashboards and compact layouts.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Angle",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/angle",
                FileName = "Angle.razor",
                MetaTitle = "Blazor ProgressBar Examples - Angle | ProgressBar Demos | Syncfusion",
                HeaderText = "Blazor Progress Bar Example - Angle Customization",
                MetaDescription = "See how the Syncfusion Blazor Angle customizes start and end angles with arc rendering to create semi circular progress indicators for unique designs.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Labels",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/labels",
                FileName = "Labels.razor",
                MetaTitle = "Blazor ProgressBar Examples - Labels | ProgressBar Demos | Syncfusion",
                HeaderText = "Blazor Progress Bar Example - Label Customization",
                MetaDescription = "See how the Syncfusion Blazor Labels adds text indicators with formatting and positioning to display percentage or values clearly in progress visuals.",
                Type = SampleType.None
            },            
            new Sample
            {
                Name = "Radius",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/radius",
                FileName = "Radius.razor",
                MetaTitle = "Blazor ProgressBar Examples - Radius | ProgressBar Demos | Syncfusion",
                HeaderText = "Blazor Progress Bar Example - Radius Customization",
                MetaDescription = "See how the Syncfusion Blazor Radius adjusts inner and outer radius with sizing controls to create rings and fit progress visuals into different layouts.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stripes",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/stripes",
                FileName = "Stripes.razor",
                MetaTitle = "Blazor ProgressBar Demos - Stripes Examples | Syncfusion",
                HeaderText = "Blazor Progress Bar Example - Striped Progress",
                MetaDescription = "See how the Syncfusion Blazor ProgressBar enhances progress bars with striped patterns and animation to improve visual appeal and highlight progress states.",
                Type = SampleType.None
            },
			new Sample
            {
                Name = "Progress Segment",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/progress-segment",
                FileName = "ProgressSegment.razor",
                MetaTitle = "Blazor ProgressBar Demos - Progress Segment Examples | Syncfusion",
                HeaderText = "Blazor Progress Bar Example - Progress Segments",
                MetaDescription = "See how the Syncfusion Blazor Progress Segment displays multiple values in segments with color differentiation to track multi stage progress efficiently.",
                Type = SampleType.None
            }
        };
    }
}
