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
        public List<Sample> AISmartPaste { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Annotations",
                Category = "Smart Paste",
                Directory = "AISamples/SmartPaste",
                Url = "ai-smartpaste/annotations",
                FileName = "SmartPasteWithAnnotations.razor"
            }
        };
    }
}
