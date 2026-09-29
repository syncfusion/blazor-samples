using System;
using System.Collections.Generic;
using Syncfusion.Blazor.BlockEditor;


namespace Syncfusion.Blazor.BlockEditorDemo
{
    public static class BlockEditorPasteCleanUp
    {
          public static IReadOnlyList<BlockModel> GetBlockDataPaste()
        {
            var blockDataPaste = new List<BlockModel>
    {
        // H2: Smart Paste Cleanup
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 2 },
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Smart Paste Cleanup"
                }
            }
        },
        // Paragraph: Introduction
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Pasting content from external sources often introduces unwanted styles and inconsistent formatting. The Block Editor provides a powerful cleanup mechanism with customization options to maintain consistency and security."
                }
            }
        },
        // H3: Features
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Features" } }
        },
        // Bullet List: Features
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Removes inline styles for cleaner markup." } }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Preserves semantic structure like headings and paragraphs." } }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Converts rich text into clean blocks for easy editing." } }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Extracts links and mentions without clutter." } }
        },
        // H3: Customization options
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Customization options" } }
        },
        // Paragraph: Config intro
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "You can configure paste cleanup behavior using the following settings:" } }
        },
        new BlockModel
                {
                    BlockType = BlockType.BulletList,
                    Indent = 1,
                    Content = { new ContentModel { ContentType = ContentType.Text, Content = "PlainText" } }
                },
        new BlockModel
                {
                    BlockType = BlockType.BulletList,
                    Indent = 1,
                    Content = { new ContentModel { ContentType = ContentType.Text, Content = "KeepFormat" } }
                },
        new BlockModel
                {
                    BlockType = BlockType.BulletList,
                    Indent = 1,
                    Content = { new ContentModel { ContentType = ContentType.Text, Content = "AllowedStyles" } }
                },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Indent = 1,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "DeniedTags" } }
        },
        // H3: Events
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Events" } }
        },
        // Paragraph: Event hooks
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Hooks for before and after paste actions:" } }
        },
        // Collapsible Heading: Paste modes
        new BlockModel
        {
            BlockType = BlockType.CollapsibleHeading,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Paste modes" } },
            Properties = new CollapsibleHeadingBlockSettings
            {
                Level = 4,
                IsExpanded = true,
                Children = new List<BlockModel>
                {
                    new BlockModel
                    {
                        BlockType = BlockType.BulletList,
                        Content =
                        {
                            new ContentModel { ContentType = ContentType.Text, Content = "Keep Format: ", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } },
                            new ContentModel { ContentType = ContentType.Text, Content = "Retains allowed styles and structure." }
                        }
                    },
                    new BlockModel
                    {
                        BlockType = BlockType.BulletList,
                        Content =
                        {
                            new ContentModel { ContentType = ContentType.Text, Content = "Plain Paste: ", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } },
                            new ContentModel { ContentType = ContentType.Text, Content = "Strips all styles and converts to plain text." }
                        }
                    }
                }
            }
        },
        // H3: Why cleanup matters
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Why cleanup matters" } }
        },
        // Paragraph: Benefits intro
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Clean content improves:" } }
        },
        // Bullet List: Benefits
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content =
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Readability: ", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = "No distracting styles." }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content =
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Accessibility: ", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = "Proper semantic tags." }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content =
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Consistency: ", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = "Uniform styling across platforms." }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content =
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Security: ", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = "Prevents malicious scripts or embeds." }
            }
        },
        // Callout: Tip
        new BlockModel
        {
            BlockType = BlockType.Callout,
            Properties = new CalloutBlockSettings
            {
                Children = new List<BlockModel>
                {
                    new BlockModel
                    {
                        BlockType = BlockType.Paragraph,
                        Content =
                        {
                            new ContentModel
                            {
                                ContentType = ContentType.Text,
                                Content = "Tip: ",
                                Properties = new TextContentSettings
                                {
                                    Styles = new StyleModel { Bold = true, Color = "#047857" }
                                }
                            },
                            new ContentModel
                            {
                                ContentType = ContentType.Text,
                                Content = "Use paste cleanup to remove inline styles while retaining semantic structure."
                            }
                        }
                    },
                    new BlockModel
                    {
                        BlockType = BlockType.Paragraph,
                        Content =
                        {
                            new ContentModel
                            {
                                ContentType = ContentType.Text,
                                Content = "Clean content is clear content.",
                                Properties = new TextContentSettings { Styles = new StyleModel { Italic = true } }
                            }
                        }
                    }
                }
            }
        },
        // H3: Workflow
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Workflow" } }
        },
        // Numbered List: Paste Workflow
        new BlockModel
        {
            BlockType = BlockType.NumberedList,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Paste content from external sources." } }
        },
        new BlockModel
        {
            BlockType = BlockType.NumberedList,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Review the cleaned output." } }
        },
        new BlockModel
        {
            BlockType = BlockType.NumberedList,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Apply additional formatting if needed." } }
        },
        new BlockModel
        {
            BlockType = BlockType.NumberedList,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Save and publish." } }
        },
        // Trailing empty paragraph
        new BlockModel
        {
            BlockType = BlockType.Paragraph
        }
    };

            return blockDataPaste;
        }

    }
}