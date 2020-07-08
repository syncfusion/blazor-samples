using System.Collections.Generic;
namespace blazor_samples
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
                Type = SampleType.Updated,
                ActionDescription = new string[] {
                    @"<p>
                  This sample illustrates a linear progress bar with track color customization, segments and animation.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                   In this example, you can see how to render and configure the linear progress bar. Progress bar is used to visualize the progression of an extended operation. The sample shows the determinate and indeterminate states, buffer and segments of linear progress bar.
                </p>
                "
                }
            },
            new Sample
            {
                Name = "Circular",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/circular",
                FileName = "Circular.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                  This sample illustrates a circular progress bar with track color customization, segments and animation.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                   In this example, you can see how to render and configure the circular progress bar. Progress bar is used to visualize the progression of an extended operation. The sample shows the determinate and indeterminate states, buffer and segments of circular progress bar.
                </p>
                "
                }
            },
            new Sample
            {
                Name = "Angle",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/angle",
                FileName = "Angle.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                  This sample illustrates a circular progress with customizing options for start and end angle.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                   This demo for Blazor Progress Bar control shows the customizing options for angle in circular progress bar. Annotation is enabled in the sample to represent the progress value.
                </p>
                "
                }
            },
            new Sample
            {
                Name = "Labels",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/labels",
                FileName = "Labels.razor",
                Type = SampleType.Updated,
                ActionDescription = new string[] {
                    @"<p>
                  This sample illustrates a linear progress bar to demonstrate different types of labels rendering.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                   This demo for Blazor Progress Bar control shows the linear progress bar with different labels format.
                </p>
                "
                }
            },            
            new Sample
            {
                Name = "Radius",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/radius",
                FileName = "Radius.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
         This sample illustrates a circular progress bar with customization options like radius, inner-radius, pie progress, track and progress thickness.
    </p>"
                },
                Description = new string[] {
                    @"<p>
                   This demo for Blazor Progress Bar control shows the customizing options for radius, inner-radius, pie progress, track and progress thickness customization.
                </p>
                "
                }
            },
            new Sample
            {
                Name = "Stripes",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/stripes",
                FileName = "Stripes.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
         This sample illustrates a striped linear progress bar with animation.
    </p>"
                },
                Description = new string[] {
                    @"<p>
                   This demo for Blazor Progress Bar control shows the linear striped progress bar with help of IsStriped property.
                </p>
                "
                }
            },
			new Sample
            {
                Name = "Progress Segment",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/progress-segment",
                FileName = "ProgressSegment.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
         This sample illustrates a segmented progress of a task.
    </p>"
                },
                Description = new string[] {
                    @"<p>
                   This demo for Blazor Progress Bar control shows the segmented progress of the progressa task using segmentCount and gapWidth property.
                </p>
                "
                }
            }
        };
    }
}
