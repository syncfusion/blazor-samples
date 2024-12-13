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
        public List<Sample> AIDocumentEditor { get; set; } = new List<Sample>{

            new Sample
            {
                Name = "Writing Assist",
                Category = "Document Editor",
                Directory = "AISamples/DocumentEditor",
                Url = "ai-documenteditor/writing-assist",
                FileName = "WritingAssist.razor",
                NotificationDescription = new string[]{ @" This demo shows the smart AI feature in document editor component." }
            },
            new Sample
            {
                Name = "Document Summarization",
                Category = "Document Editor",
                Directory = "AISamples/DocumentEditor",
                Url = "ai-documenteditor/summarization",
                FileName = "Summarization.razor",
                NotificationDescription = new string[]{ @" This demo shows the smart AI feature in document editor component." }
            },
             new Sample
            {
                Name = "Smart Editor",
                Category = "Document Editor",
                Directory = "AISamples/DocumentEditor",
                Url = "ai-documenteditor/smart-editor",
                FileName = "SmartEditor.razor",
                NotificationDescription = new string[]{ @" This demo shows the smart AI feature in document editor component." }
            }
        };
    }
}