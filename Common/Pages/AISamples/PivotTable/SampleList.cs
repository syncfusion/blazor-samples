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
        public List<Sample> AIPivotTable { get; set; } = new List<Sample>{

            new Sample
            {
                Name = "Smart Pivot",
                Category = "Pivot Table",
                Directory = "AISamples/PivotTable",
                Url = "ai-pivottable/smartpivot",
                FileName = "SmartPivot.razor",
                NotificationDescription = new string[]{ @" This demo showcases the Pivot Table AI feature." }
            }
        };
    }
}