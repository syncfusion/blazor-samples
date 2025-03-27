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
        public List<Sample> AITreeGrid { get; set; } = new List<Sample>{
             new Sample
            {
                Name = "Adaptive Data Structuring",
                Category = "Tree Grid",
                Directory = "AISamples/TreeGrid",
                Url = "ai-treegrid/adaptive-datastructuring",
                FileName = "AdaptiveDataStructuring.razor",
                NotificationDescription = new string[]{ @" This demo shows the adaptive data structuring AI feature in Tree Grid." }
            }
        };
    }
}
