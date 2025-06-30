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
        public List<Sample> AIPdfViewer { get; set; } = new List<Sample>{

            new Sample
            {
                Name = "Smart Fill",
                Category = "PDF Viewer",
                Directory = "AISamples/PdfViewer",
                Url = "ai-pdfviewer-2/smartfill",
                FileName = "SmartFill.razor",
                MetaTitle = "Blazor PDF Viewer Smart Fill Example - Syncfusion AI Demos",
                HeaderText = "Blazor PDF Viewer Example - AI-Powered Smart Fill",
                MetaDescription = "This Blazor PDF Viewer Smart Fill demo showcases AI-powered form completion. Automatically detect and populate form fields with relevant information, saving time and reducing errors in document workflows.",
                NotificationDescription = new string[]{ @" This demo showcases the pdf viewer AI feature." }
            },
            new Sample
            {
                Name = "Smart Redact",
                Category = "PDF Viewer",
                Directory = "AISamples/PdfViewer",
                Url = "ai-pdfviewer-2/smartredact",
                FileName = "SmartRedact.razor",
                MetaTitle = "Blazor PDF Viewer Smart Redact Example - Syncfusion AI Demos",
                HeaderText = "Blazor PDF Viewer Example - AI-Powered Smart Redaction",
                MetaDescription = "This Blazor PDF Viewer Smart Redact demo showcases intelligent document redaction. Automatically identify and obscure sensitive information like names, addresses, and identification numbers for enhanced document security.",
                NotificationDescription = new string[]{ @" This demo showcases the pdf viewer AI feature." }
            },
            new Sample
            {
                Name = "Summarizer",
                Category = "PDF Viewer",
                Directory = "AISamples/PdfViewer",
                Url = "ai-pdfviewer-2/summarizer",
                FileName = "Summarizer.razor",
                MetaTitle = "Blazor PDF Viewer Summarizer Example - Syncfusion AI Demos",
                HeaderText = "Blazor PDF Viewer Example - AI-Powered Document Summarization",
                MetaDescription = "This Blazor PDF Viewer Summarizer demo showcases intelligent document summarization. Extract key points and generate concise overviews of lengthy documents, improving comprehension and saving review time.",
                NotificationDescription = new string[]{ @" This demo showcases the pdf viewer AI feature." }
            }
        };
    }
}