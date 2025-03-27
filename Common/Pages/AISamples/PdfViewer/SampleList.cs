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
                NotificationDescription = new string[]{ @" This demo showcases the pdf viewer AI feature." }
            },
            new Sample
            {
                Name = "Smart Redact",
                Category = "PDF Viewer",
                Directory = "AISamples/PdfViewer",
                Url = "ai-pdfviewer-2/smartredact",
                FileName = "SmartRedact.razor",
                NotificationDescription = new string[]{ @" This demo showcases the pdf viewer AI feature." }
            },
            new Sample
            {
                Name = "Summarizer",
                Category = "PDF Viewer",
                Directory = "AISamples/PdfViewer",
                Url = "ai-pdfviewer-2/summarizer",
                FileName = "Summarizer.razor",
                NotificationDescription = new string[]{ @" This demo showcases the pdf viewer AI feature." }
            }
        };
    }
}