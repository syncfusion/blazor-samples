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
        public List<Sample> AISmartPaste { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Annotations",
                Category = "Smart Paste",
                Directory = "AISamples/SmartPaste",
                Url = "ai-smartpaste/annotations",
                FileName = "SmartPasteWithAnnotations.razor",
                MetaTitle = "Blazor Smart Paste Button Annotations - Syncfusion AI Demos",
                HeaderText = "Blazor Smart Paste Example - AI-powered Annotations",
                MetaDescription = "This Blazor Smart Paste demo showcases AI-powered annotation capabilities. Convert clipboard content into structured annotations automatically, enhancing document interaction with intelligent text recognition and formatting."
            }
        };
    }
}
