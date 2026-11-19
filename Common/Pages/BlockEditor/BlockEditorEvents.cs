using System;
using System.Collections.Generic;
using Syncfusion.Blazor.BlockEditor;


namespace Syncfusion.Blazor.BlockEditorDemo
{
    public static class BlockEditorEvents
    {
         public static IReadOnlyList<BlockModel> GetBlockDataEvents()
        {
            var blockDataEvents = new List<BlockModel>
    {
        // H2: Block Editor Event Handling
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 2 },
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Block Editor Event Handling"
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
                    Content = "The Block Editor provides a comprehensive event system that allows developers to track user interactions and customize workflows. Events are essential for implementing real-time updates, analytics, and advanced features."
                }
            }
        },
        // H3: Why events matter
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Why events matter"
                }
            }
        },
        // CollapsibleHeading: Events enable you to:
        new BlockModel
        {
            BlockType = BlockType.CollapsibleHeading,
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Events enable you to:"
                }
            },
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
                            new ContentModel { ContentType = ContentType.Text, Content = "Respond to content changes instantly." }
                        }
                    },
                    new BlockModel
                    {
                        BlockType = BlockType.BulletList,
                        Content =
                        {
                            new ContentModel { ContentType = ContentType.Text, Content = "Track user focus and engagement." }
                        }
                    },
                    new BlockModel
                    {
                        BlockType = BlockType.BulletList,
                        Content =
                        {
                            new ContentModel { ContentType = ContentType.Text, Content = "Monitor block-level actions for better control." }
                        }
                    },
                    new BlockModel
                    {
                        BlockType = BlockType.BulletList,
                        Content =
                        {
                            new ContentModel { ContentType = ContentType.Text, Content = "Implement custom behaviors and analytics." }
                        }
                    }
                }
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
                                    Styles = new StyleModel
                                    {
                                        Bold = true,
                                        Color = "#047857"
                                    }
                                }
                            },
                            new ContentModel
                            {
                                ContentType = ContentType.Text,
                                Content = "Use events wisely — avoid unnecessary listeners to maintain optimal performance."
                            }
                        }
                    }
                }
            }
        },
        // H3: Core events
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Core events"
                }
            }
        },
        // Bullet List: blockChange
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "BlockChanged: ",
                    Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } }
                },
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Detect when blocks are added, removed, transformed or updated."
                }
            }
        },
        // Bullet List: focus
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Focus: ",
                    Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } }
                },
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Track active blocks when the editor gains focus."
                }
            }
        },
        // H3: Event Usage in the Block Editor
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Event usage in the Block Editor"
                }
            }
        },
        // Paragraph: Common use cases
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Events are commonly used for:"
                }
            }
        },
        // Bullet List: Autosave
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Autosave: ",
                    Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } }
                },
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Trigger BlockChanged to save content periodically."
                }
            }
        },
        // Bullet List: Collaboration
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Collaboration: ",
                    Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } }
                },
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Sync changes in real-time using BlockChanged."
                }
            }
        },
        // H3: Cases to avoid when binding events
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Cases to avoid when binding events"
                }
            }
        },
        // Numbered List: Anti-patterns
        new BlockModel
        {
            BlockType = BlockType.NumberedList,
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "High-frequency events without throttling Example: ",
                    Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } }
                },
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Binding heavy logic to blockChange without debouncing can cause performance issues."
                }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.NumberedList,
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Duplicate listeners: ",
                    Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } }
                },
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Adding multiple listeners for the same event can lead to memory leaks and unexpected behavior."
                }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.NumberedList,
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Unnecessary global listeners: ",
                    Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } }
                },
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Avoid binding events that are not relevant to your workflow."
                }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.NumberedList,
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Complex operations inside event callbacks: ",
                    Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } }
                },
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Heavy DOM manipulation or API calls inside frequent events can degrade the user experience."
                }
            }
        },
        // H3: Best practices
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Best practices"
                }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Use debouncing for frequent events like blockChange." } }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Remove listeners when they are no longer needed." } }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Keep event callbacks lightweight and efficient." } }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Combine events for analytics without impacting UX." } }
        },
        // Quote
        new BlockModel
        {
            BlockType = BlockType.Quote,
            Properties = new QuoteBlockSettings
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
                                Content = "“Every interaction tells a story — listen carefully.”",
                                Properties = new TextContentSettings { Styles = new StyleModel { Italic = true } }
                            }
                        }
                    }
                }
            }
        },
        // Trailing empty paragraph
        new BlockModel { BlockType = BlockType.Paragraph }
    };

            return blockDataEvents;
        }

    }
}