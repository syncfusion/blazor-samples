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
                MetaTitle = "Blazor AI Demos - Annotations Examples | AI Demos | Syncfusion",
                HeaderText = "Blazor Smart Paste Example - AI-powered Annotations",
                MetaDescription = "See how the Syncfusion Blazor Annotations converts clipboard content into structured annotations with OCR and parsing to speed docs and improve accuracy",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="SmartPasteWithAnnotations.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="CommonData.cs"
                    }
                }
            }
        };
    }
}
