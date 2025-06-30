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
        public List<Sample> AIDocumentEditor { get; set; } = new List<Sample>{

            new Sample
            {
                Name = "Writing Assist",
                Category = "Document Editor",
                Directory = "AISamples/DocumentEditor",
                Url = "ai-documenteditor/writing-assist",
                FileName = "WritingAssist.razor",
                MetaTitle = "Blazor Word Processor Writing Assist - Syncfusion AI Demos",
                HeaderText = "Blazor Document Editor Example - AI-Powered Writing Assistant",
                MetaDescription = "This Blazor Document Editor AI demo showcases intelligent writing assistance with real-time suggestions for grammar, clarity, and style improvements to enhance document quality and professionalism.",
                NotificationDescription = new string[]{ @" This demo shows the smart AI feature in document editor component." }
            },
            new Sample
            {
                Name = "Document Summarization",
                Category = "Document Editor",
                Directory = "AISamples/DocumentEditor",
                Url = "ai-documenteditor/summarization",
                FileName = "Summarization.razor",
                MetaTitle = "Word Processor Document Summarization - Syncfusion AI Demos",
                HeaderText = "Blazor Document Editor Example - AI-Powered Document Summarization",
                MetaDescription = "This Blazor Document Editor AI feature automatically generates concise summaries of lengthy documents. Extract key points and main ideas from complex content for improved comprehension and efficient information review.",
                NotificationDescription = new string[]{ @" This demo shows the smart AI feature in document editor component." }
            },
             new Sample
            {
                Name = "Smart Editor",
                Category = "Document Editor",
                Directory = "AISamples/DocumentEditor",
                Url = "ai-documenteditor/smart-editor",
                FileName = "SmartEditor.razor",
                MetaTitle = "Blazor Word Processor Smart Editor - Syncfusion AI Demos",
                HeaderText = "Blazor Document Editor Example - AI-Powered Smart Editing",
                MetaDescription = "This Blazor Document Editor Smart Editor demo showcases AI-enhanced document editing capabilities. Create, edit and format content intelligently with automated suggestions, corrections, and contextual formatting recommendations.",
                NotificationDescription = new string[]{ @" This demo shows the smart AI feature in document editor component." }
            }
        };
    }
}