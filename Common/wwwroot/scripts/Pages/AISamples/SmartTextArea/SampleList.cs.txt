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
                MetaTitle = "Blazor AI Demos - Smart TextArea Examples | AI Demos | Syncfusion",
                HeaderText = "Blazor Smart TextArea Example - AI-Powered Text Editing",
                MetaDescription = "See how the Syncfusion Blazor Smart TextArea offers context-aware suggestions, autocomplete, and real-time validation to speed typing and improve accuracy",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-smart-textarea"
            }
        };
    }
}
