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
        public List<Sample> BlockEditor { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Overview",
                Category = "Block Editor",
                Type = SampleType.Updated,
                Directory = "BlockEditor/BlockEditor",
                Url = "block-editor/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor Block Editor Component | Features Overview | Syncfusion",
                HeaderText = "Blazor Block Editor Example - Overview",
                NotificationDescription = new string[]{ @"Modern Block-Based Editor Update introduces the Table block now supports advanced multiple row and column selection for efficient editing, intuitive column resizing by dragging borders, and seamless dynamic row/column management. A new Code block has been added to the built-in block types for syntax-highlighted code snippets. Enjoy smooth block drag-and-drop reordering for flexible content arrangement." },
                MetaDescription = "This demo shows the features of the Block Editor component. It showcases various block types, content formatting options, and interactive editing capabilities.",
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