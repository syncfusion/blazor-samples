using System.Collections.Generic;

namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> AISmartRichTextEditor { get; set; } = new List<Sample>{

            new Sample
            {
                Name = "Overview",
                Category = "Smart Rich Text Editor",
                Directory = "AISamples/SmartRichTextEditor",
                Url = "ai-smart-rich-text-editor/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor AISamples Examples - Overview | AI Demos | Syncfusion",
                HeaderText = "Blazor Smart Rich Text Editor Example - AI-powered Writing Assistant",
                MetaDescription = "See how the Syncfusion Blazor Overview offers AI-assisted writing with contextual suggestions and formatting to speed content creation and improve quality",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-smart-rich-text-editor",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName = "Overview.razor"
                    },
                    new SourceCollection
                    {
                        Id="Program",
                        FileName = "Program.cs"
                    }
                }
            },
            new Sample
            {
                Name = "AI Email Assistant",
                Category = "Smart Rich Text Editor",
                Directory = "AISamples/SmartRichTextEditor",
                Url = "ai-smart-rich-text-editor/ai-email-assistant",
                FileName = "AIEmailAssistant.razor",
                MetaTitle = "Blazor AI Examples - AI Email Assistant | AI Demos | Syncfusion",
                HeaderText = "Blazor Smart Rich Text Editor Example - AI-powered Email Composition",
                MetaDescription = "See how the Syncfusion Blazor AI Email Assistant adjusts tone and condenses text with grammar fixes and templates to craft clearer, more professional emails",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName = "AIEmailAssistant.razor"
                    },
                    new SourceCollection
                    {
                        Id="Program",
                        FileName = "Program.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Smart Academic Writer",
                Category = "Smart Rich Text Editor",
                Directory = "AISamples/SmartRichTextEditor",
                Url = "ai-smart-rich-text-editor/smart-academic-writer",
                FileName = "SmartAcademicWriter.razor",
                MetaTitle = "Blazor AI Examples - Smart Academic Writer | AI Demos | Syncfusion",
                HeaderText = "Blazor Smart Rich Text Editor Example - AI-powered Academic Writing",
                MetaDescription = "See how the Syncfusion Blazor Smart Academic Writer drafts abstracts and formats citations with style guidance and reference management for manuscripts",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName = "SmartAcademicWriter.razor"
                    },
                    new SourceCollection
                    {
                        Id="Program",
                        FileName = "Program.cs"
                    }
                }
            }
        };
    }
}