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
        public List<Sample> AISmartRichTextEditor { get; set; } = new List<Sample>{

            new Sample
            {
                Name = "Overview",
                Category = "Smart Rich Text Editor",
                Directory = "AISamples/SmartRichTextEditor",
                Url = "ai-smart-rich-text-editor/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor Smart Rich Text Editor Overview - Syncfusion AI Demos",
                HeaderText = "Blazor Smart Rich Text Editor Example - AI-powered Writing Assistant",
                MetaDescription = "This Blazor Smart Rich Text Editor example demonstrates intelligent content creation with contextual writing suggestions for enhanced content quality.",
                Type = SampleType.New,
                NotificationDescription = new string[]{ @"Smart Rich Text Editor Overview demonstrates AI-powered content editing with predefined smart actions like improve, shorten, elaborate, simplify, summarize, translate, and grammar check. Access AI assistant via Alt + Enter or toolbar, apply actions to selected text with streamed responses, and seamlessly insert results into the document." },
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
                MetaTitle = "Blazor AI Email Assistant Example - Syncfusion AI Demos",
                HeaderText = "Blazor Smart Rich Text Editor Example - AI-powered Email Composition",
                MetaDescription = "AI Email Assistant composes emails by adjusting tone, condensing or expanding content, fixing grammar, and polishing formatting for clearer, better messages.",
                Type = SampleType.New,
                NotificationDescription = new string[]{ @"AI Email Assistant transforms professional email composition with tone adjustments including professional, friendly, formal, concise, and empathetic modes. Convert content into business, legal, journalistic, or technical styles, automatically review and correct grammar and spelling, and apply instant transformations via Alt + Enter or AI Commands menu." },
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
                MetaTitle = "Blazor Smart Academic Writer Example - Syncfusion AI Demos",
                HeaderText = "Blazor Smart Rich Text Editor Example - AI-powered Academic Writing",
                MetaDescription = "Smart Academic Writer helps to generate abstracts, format citations, adjust scholarly tone, draft sections, organize references, and prepare manuscripts.",
                Type = SampleType.New,
                NotificationDescription = new string[]{ @"Smart Academic Writer accelerates academic writing with flexible document type selection, multiple citation style support, and customizable academic levels. Generate abstracts with quick actions, transform tone for scholarly and technical writing, assist with section drafting including introductions and methodology, and receive AI guidance tailored to academic disciplines and research stages." },
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