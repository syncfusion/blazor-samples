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
                MetaTitle = "Blazor BlockEditor - Overview | BlockEditor Demos | Syncfusion",
                HeaderText = "Blazor Block Editor Example - Overview",
                MetaDescription = "See how the Syncfusion Blazor Overview BlockEditor provides block-based editing with templates and slash commands to speed content creation and reuse.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-block-editor",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "Overview.razor",
                        Id="Overview",
                    },
                    new SourceCollection
                    {
                        FileName = "BlockEditorOverview.cs",
                        Id="BlockEditorOverview",
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
                MetaTitle = "Blazor BlockEditor - Paste Cleanup | BlockEditor Demos | Syncfusion",
                HeaderText = "Blazor Block Editor Example - Paste Cleanup",
                MetaDescription = "See how the Syncfusion Blazor Paste Cleanup BlockEditor sanitizes pasted content with style mapping and cleanup options, preserving format for consistent docs",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "PasteCleanup.razor",
                        Id="PasteCleanup",
                    },
                    new SourceCollection
                    {
                        FileName = "BlockEditorPasteCleanUp.cs",
                        Id="BlockEditorPasteCleanUp",
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
                MetaTitle = "Blazor BlockEditor Examples - Events | BlockEditor Demos | Syncfusion",
                HeaderText = "Blazor Block Editor Example - Events",
                MetaDescription = "See how the Syncfusion Blazor Events BlockEditor exposes hooks and callbacks with customization and validation to integrate editing into workflows seamlessly",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "Events.razor",
                        Id="Events",
                    },
                    new SourceCollection
                    {
                        FileName = "BlockEditorEvents.cs",
                        Id="BlockEditorEvents",
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
                MetaTitle = "Blazor BlockEditor Demos - Template Gallery Examples | Syncfusion",
                HeaderText = "Blazor Block Editor Example - Template Gallery",
                MetaDescription = "See how the Syncfusion Blazor Block Editor Gallery simplifies template selection, block loading, and slash command customization for faster content workflows.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "TemplateGallery.razor",
                        Id="TemplateGallery",
                    },
                    new SourceCollection
                    {
                        FileName = "BlockEditorTemplateGallery.cs",
                        Id="BlockEditorTemplateGallery",
                    }
                }
            }
        };
    }
}