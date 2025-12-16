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
        public List<Sample> BlockEditor { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Overview",
                Category = "Block Editor",
                Directory = "BlockEditor/BlockEditor",
                Url = "block-editor/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor Block Editor Component | Features Overview | Syncfusion",
                HeaderText = "Blazor Block Editor Example - Overview",
                MetaDescription = "This demo shows the features of the Block Editor component. It showcases various block types, content formatting options, and interactive editing capabilities.",
                NotificationDescription = new string[] {
                    "Introduces the Block Editor’s modern block-based authoring experience, highlighting common block types, inline formatting, and quick insertion with slash commands."
                },
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "Overview.razor",
                        Id="Overview",
                    },
                    new SourceCollection
                    {
                        FileName = "EditorBlockData.cs",
                        Id="EditorBlockData",
                    }
                }
            },
            new Sample
            {
                Name = "Paste Cleanup",
                Category = "Block Editor",
                Directory = "BlockEditor/BlockEditor",
                Url = "block-editor/pastecleanup",
                FileName = "PasteCleanup.razor",
                MetaTitle = "Blazor Block Editor Component | Paste Cleanup | Syncfusion",
                HeaderText = "Blazor Block Editor Example - Paste Cleanup",
                MetaDescription = "This demo highlights the Block Editor component, showcasing its features and paste settings options to help you explore customization and editing capabilities.",
                NotificationDescription = new string[] {
                    "Demonstrates how the Block Editor manages pasted content to maintain consistent formatting and structure."
                },
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "PasteCleanup.razor",
                        Id="PasteCleanup",
                    },
                    new SourceCollection
                    {
                        FileName = "EditorBlockData.cs",
                        Id="EditorBlockData",
                    }
                }
            },
            new Sample
            {
                Name = "Events",
                Category = "Block Editor",
                Directory = "BlockEditor/BlockEditor",
                Url = "block-editor/events",
                FileName = "Events.razor",
                MetaTitle = "Blazor Block Editor Component | Events | Syncfusion",
                HeaderText = "Blazor Block Editor Example - Events",
                MetaDescription = "This demo highlights the Block Editor component and demonstrates the events it supports, helping you understand event handling and customization options.",
                NotificationDescription = new string[] {
                    "Illustrates how the Block Editor surfaces key events for observing changes and integrating custom logic."
                },
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "Events.razor",
                        Id="Events",
                    },
                    new SourceCollection
                    {
                        FileName = "EditorBlockData.cs",
                        Id="EditorBlockData",
                    }
                }
            },
            new Sample
            {
                Name = "Template Gallery",
                Category = "Use Cases",
                Directory = "BlockEditor/BlockEditor",
                Url = "block-editor/template",
                FileName = "TemplateGallery.razor",
                MetaTitle = "Blazor Block Editor Component | Template Gallery | Syncfusion",
                HeaderText = "Blazor Block Editor Example - Template Gallery",
                MetaDescription = "This demo showcases the integration of Template Gallery for Block Editor component: select a template, load blocks, and customize with slash commands.",
                NotificationDescription = new string[] {
                    "Shows a template gallery for the Block Editor: pick a template card to load a prebuilt document structure and start editing immediately with headings, lists, and inline styles."
                },
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "TemplateGallery.razor",
                        Id="TemplateGallery",
                    },
                    new SourceCollection
                    {
                        FileName = "EditorBlockData.cs",
                        Id="EditorBlockData",
                    }
                }
            }
        };
    }
}