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
        public List<Sample> AIRichTextEditor { get; set; } = new List<Sample>{

            new Sample
            {
                Name = "AIAssistant",
                Category = "Rich Text Editor",
                Directory = "AISamples/RichTextEditor",
                Url = "ai-richtexteditor/ai-assistant",
                FileName = "AIAssistant.razor",
                NotificationDescription = new string[]{ @" This demo showcases the Rich Text Editor AI feature." }
            }
        };
    }
}