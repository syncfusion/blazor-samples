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
        public List<Sample> AISmartTextArea { get; set; } = new List<Sample>{

            new Sample
            {
                Name = "Smart TextArea",
                Category = "SmartTextArea",
                Directory = "AISamples/SmartTextArea",
                Url = "ai-smarttextarea/default",
                FileName = "SmartTextArea.razor",
                MetaTitle = "Blazor Smart TextArea Smart TextArea - Syncfusion AI Demos",
                HeaderText = "Blazor Smart TextArea Example - AI-Powered Text Editing",
                MetaDescription = "This Blazor Smart TextArea example demonstrates AI-powered text input with intelligent suggestions and context-aware assistance to enhance writing experience."
            }
        };
    }
}
