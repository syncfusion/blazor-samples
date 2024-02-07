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
        public List<Sample> ProgressBar { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Linear",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/linear",
                FileName = "Linear.razor",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Circular",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/circular",
                FileName = "Circular.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Angle",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/angle",
                FileName = "Angle.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Labels",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/labels",
                FileName = "Labels.razor",
                Type = SampleType.None
            },            
            new Sample
            {
                Name = "Radius",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/radius",
                FileName = "Radius.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Stripes",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/stripes",
                FileName = "Stripes.razor",
                Type = SampleType.None
            },
			new Sample
            {
                Name = "Progress Segment",
                Category = "Progress Bar",
                Directory = "ProgressBar/ProgressBar",
                Url = "progress-bar/progress-segment",
                FileName = "ProgressSegment.razor",
                Type = SampleType.None
            }
        };
    }
}
