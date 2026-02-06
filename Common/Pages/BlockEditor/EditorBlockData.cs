#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using Syncfusion.Blazor.BlockEditor;


namespace Syncfusion.Blazor.BlockEditorDemo
{
    public class EditorBlockData
    {
        public List<BlockModel> GetBlockDataOverview()
        {
            List<BlockModel> blockDataOverview = new List<BlockModel>
    {
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 2 },
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Welcome to the Block Editor Demo!"
                }
            }
        },
        // Intro paragraph with bold inline
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content =
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Welcome to the " },
                new ContentModel { ContentType = ContentType.Text, Content = "Block Editor", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = "! This demo highlights all supported block types and inline formatting options. Each section below explains the purpose of the block and shows how it appears in the editor." }
            }
        },
        // Paragraph section heading
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Paragraph" } }
        },
        // Paragraph description
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "Paragraph blocks are used for writing regular text. They are the most common block type and support inline formatting to enhance readability and emphasis."
                }
            }
        },
        // Inline Formatting heading
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Inline Formatting" } }
        },
        // Emphasis styles paragraph
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content =
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Use " },
                new ContentModel { ContentType = ContentType.Text, Content = "bold", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = ", " },
                new ContentModel { ContentType = ContentType.Text, Content = "italic", Properties = new TextContentSettings { Styles = new StyleModel { Italic = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = ", and " },
                new ContentModel { ContentType = ContentType.Text, Content = "underline", Properties = new TextContentSettings { Styles = new StyleModel { Underline = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = " for emphasis; or " },
                new ContentModel { ContentType = ContentType.Text, Content = "strikethrough", Properties = new TextContentSettings { Styles = new StyleModel { Strikethrough = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = " to indicate removals or outdated text." }
            }
        },
        // Technical/semantic styles paragraph with inline code and link
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content =
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Math and chemistry: E = mc" },
                new ContentModel { ContentType = ContentType.Text, Content = "2", Properties = new TextContentSettings { Styles = new StyleModel { Superscript = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = ", H" },
                new ContentModel { ContentType = ContentType.Text, Content = "2", Properties = new TextContentSettings { Styles = new StyleModel { Subscript = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = "O - with superscript and subscript. Add inline code " },
                new ContentModel { ContentType = ContentType.Text, Content = "const x = 10;", Properties = new TextContentSettings { Styles = new StyleModel { InlineCode = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = " and helpful " },
                new ContentModel { ContentType = ContentType.Link, Content = "links", Properties = new LinkContentSettings { Url = "https://ej2.syncfusion.com/documentation/block-editor/getting-started" } },
                new ContentModel { ContentType = ContentType.Text, Content = " for quick references." }
            }
        },
        // Transform/color/mention/label paragraph
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content =
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Transform text to " },
                new ContentModel { ContentType = ContentType.Text, Content = "uppercase", Properties = new TextContentSettings { Styles = new StyleModel { Uppercase = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = " or " },
                new ContentModel { ContentType = ContentType.Text, Content = "LOWERCASE", Properties = new TextContentSettings { Styles = new StyleModel { Lowercase = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = ". Add " },
                new ContentModel { ContentType = ContentType.Text, Content = "color", Properties = new TextContentSettings { Styles = new StyleModel { Color = "green" } } },
                new ContentModel { ContentType = ContentType.Text, Content = " or " },
                new ContentModel { ContentType = ContentType.Text, Content = "background highlights", Properties = new TextContentSettings { Styles = new StyleModel { BackgroundColor = "#FEF3C7", Color = "#92400E" } } },
                new ContentModel { ContentType = ContentType.Text, Content = " as needed. Mention " },
                new ContentModel { ContentType = ContentType.Mention, Properties = new MentionContentSettings { UserID = "user1" } },
                new ContentModel { ContentType = ContentType.Text, Content = " and tag with " },
                new ContentModel { ContentType = ContentType.Label, Properties = new LabelContentSettings { LabelID = "progress" } },
                new ContentModel { ContentType = ContentType.Text, Content = " to add context." }
            }
        },
        // Table heading (level 3 with placeholder)
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3, Placeholder = "Heading 3" },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Table" } },
            Indent = 0
        },
        // Table description
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content =
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Table blocks organize data in rows and columns for easy comparison or presentation. They support headers and basic styling" }
            }
        },
        // Spacer paragraph
        new BlockModel
        {
            BlockType = BlockType.Table,
            Properties = new TableBlockSettings
            {
                Columns = new List<TableColumnModel>
                {
                    new TableColumnModel {  HeaderText = "Name" },
                    new TableColumnModel {  HeaderText = "Age" },
                    new TableColumnModel {  HeaderText = "Gender" },
                    new TableColumnModel {  HeaderText = "Occupation" },
                    new TableColumnModel {  HeaderText = "Mode of Transport" }
                },
                Rows = new List<TableRowModel>
                {
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "Selma Rose" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "30" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "Female" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "Engineer" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "🚴" }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "Robert" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "28" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "Male" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "Graphic Designer" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "🚗" }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "William" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "35" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "Male" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "Teacher" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "🚗" }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "Laura Grace" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "42" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "Female" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "Doctor" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "🚌" }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "Andrew James" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "45" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "Male" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "Lawyer" }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text, Content = "🚕" }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        },
        // Image section
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Image Block" } }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content =
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Image blocks allow you to insert visuals to support or enhance your content." }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Image,
            Properties = new ImageBlockSettings
            {
                Src = "https://cdn.syncfusion.com/ej2/richtexteditor-resources/RTE-Overview.png",
                AltText = "Block Editor Image"
            }
        },
        // Checklist section
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Checklist" } }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Checklists help track tasks or steps:" } }
        },
        new BlockModel
        {
            BlockType = BlockType.Checklist,
            Properties = new ChecklistBlockSettings { IsChecked = true },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Apply inline formatting" } }
        },
        new BlockModel
        {
            BlockType = BlockType.Checklist,
            Content =
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Invite reviewer " },
                new ContentModel { ContentType = ContentType.Mention, Properties = new MentionContentSettings { UserID = "user2" } }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Checklist,
            Content =
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Publish guide and share " },
                new ContentModel { ContentType = ContentType.Link, Content = "the link", Properties = new LinkContentSettings { Url = "https://ej2.syncfusion.com/documentation/block-editor/getting-started" } }
            }
        },
        // Lists section
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Lists" } }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Lists organize information clearly:" } }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Unordered List", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } } }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Indent = 1,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Concise points for quick scanning" } }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Indent = 1,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Great for features or tips" } }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Indent = 1,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Easy to reorder and nest" } }
        },
        new BlockModel
        {
            BlockType = BlockType.NumberedList,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Ordered List", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } } }
        },
        new BlockModel
        {
            BlockType = BlockType.NumberedList,
            Indent = 1,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Start a new document" } }
        },
        new BlockModel
        {
            BlockType = BlockType.NumberedList,
            Indent = 1,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Add structure with headings" } }
        },
        new BlockModel
        {
            BlockType = BlockType.NumberedList,
            Indent = 1,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Fill in content and review" } }
        },
        // Headings section heading
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Headings" } }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content =
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Headings help organize content into sections. Use different levels " },
                new ContentModel { ContentType = ContentType.Text, Content = "(h1, h2, h3 or h4)", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = " to create a hierarchy:" }
            }
        },
        // Quote section
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Quote" } }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Use quote blocks to emphasize important statements or references." } }
        },
        new BlockModel
        {
            BlockType = BlockType.Quote,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "“Quotes are perfect for highlighting key messages or testimonials.”" } }
        },
        // Callout section
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Callout" } }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Callouts are great for tips, warnings, or notes that need attention." } }
        },
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
                            new ContentModel { ContentType = ContentType.Text, Content = "Tip: ", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } },
                            new ContentModel { ContentType = ContentType.Text, Content = "Use the " },
                            new ContentModel { ContentType = ContentType.Text, Content = "/ ", Properties = new TextContentSettings { Styles = new StyleModel { InlineCode = true } } },
                            new ContentModel { ContentType = ContentType.Text, Content = "command to quickly insert blocks like headings, lists, or code." }
                        }
                    }
                }
            }
        },
        // Toggle (collapsible paragraph) section
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Toggle Block" } }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Toggle blocks are interactive and help manage long or optional content." } }
        },
        new BlockModel
        {
            BlockType = BlockType.CollapsibleParagraph,
            Content =
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Click to expand", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } }
            },
            Properties = new CollapsibleParagraphBlockSettings
            {
                IsExpanded = false,
                Children = new List<BlockModel>
                {
                    new BlockModel
                    {
                        BlockType = BlockType.Paragraph,
                        Content = { new ContentModel { ContentType = ContentType.Text, Content = "This is a toggle block. You can hide or show content as needed. Useful for FAQs or detailed sections." } }
                    }
                }
            }
        },
        // Divider section
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Divider" } }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Dividers are horizontal lines used to separate sections or indicate a break in content." } }
        },
        new BlockModel { BlockType = BlockType.Divider },
        // Trailing empty paragraph
        new BlockModel { BlockType = BlockType.Paragraph }
    };
            return blockDataOverview;
        }

        public List<UserModel> GetUniqueMentionUsers()
        {
            return new List<UserModel>
                {
                    new UserModel
                    {
                        ID = "user1",
                        User = "Andrews",
                        AvatarUrl = "https://cdn.syncfusion.com/blazor/images/demos/avatar/pic01.webp",
                    },
                    new UserModel
                    {
                        ID = "user2",
                        User = "Charlie",
                        AvatarUrl = "https://cdn.syncfusion.com/blazor/images/demos/avatar/pic04.webp",
                    }
                };
        }

        public List<BlockModel> GetBlockDataEvents()
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
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "“Every interaction tells a story — listen carefully.”",
                    Properties = new TextContentSettings { Styles = new StyleModel { Italic = true } }
                }
            }
        },
        // Trailing empty paragraph
        new BlockModel { BlockType = BlockType.Paragraph }
    };

            return blockDataEvents;
        }

        public List<BlockModel> GetBlockDataPaste()
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

        public class TemplateCard
        {
            public string Id { get; set; } = Guid.NewGuid().ToString();
            public string Icon { get; set; } = "📄";
            public string Name { get; set; } = "";
            public string Subtitle { get; set; } = "";
            public List<BlockModel> Blocks { get; set; } = new();
        }

        public static List<TemplateCard> GetCards()
        {
            return new List<TemplateCard>
        {
            new TemplateCard
            {
                Id = "Blank_Page",
                Icon = "📃",
                Name = "Blank Page",
                Subtitle = "Start from scratch",
                Blocks = GetBlankPageBlocks()
            },
            new TemplateCard
            {
                Id = "Project_Brief",
                Icon = "📝️",
                Name = "Project Brief",
                Subtitle = "Plan, organize, and track",
                Blocks = GetProjectBriefBlocks()
            },
            new TemplateCard
            {
                Id = "Team_Decisions",
                Icon = "🦄",
                Name = "Team Decisions",
                Subtitle = "Ideate and decide",
                Blocks = GetTeamDecisionsBlocks()
            },
            new TemplateCard
            {
                Id = "Project_Planning",
                Icon = "💎",
                Name = "Project Planning",
                Subtitle = "Collaborate",
                Blocks = GetProjectPlanningBlocks()
            },
            new TemplateCard
            {
                Id = "Meeting_Notes",
                Icon = "✏️",
                Name = "Meeting Notes",
                Subtitle = "Sync and share",
                Blocks = GetMeetingNotesBlocks()
            }
        };
        }

        private static List<BlockModel> GetBlankPageBlocks()
        {
            return new List<BlockModel>
        {
            new BlockModel
            {
                BlockType = BlockType.Paragraph,
                Content = new List<ContentModel>()
            }
        };
        }

        private static List<BlockModel> GetProjectBriefBlocks()
        {
            return new List<BlockModel>
            {
                // Overview
                new BlockModel
                {
                    BlockType = BlockType.Heading,
                    Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
                    Content = new List<ContentModel>
                    {
                        new ContentModel { ContentType = ContentType.Text, Content = "💫 Overview" }
                    }
                },
                new BlockModel
                {
                    BlockType = BlockType.Paragraph,
                    Content = new List<ContentModel>
                    {
                        new ContentModel { ContentType = ContentType.Text, Content = "Provide project background, core objectives, key stakeholders, and proposed timeline here — include an inspiring quote to set the tone." }
                    }
                },
                new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
                // Goals
                new BlockModel
                {
                    BlockType = BlockType.Heading,
                    Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
                    Content = new List<ContentModel>
                    {
                        new ContentModel { ContentType = ContentType.Text, Content = "🎯 Goals" }
                    }
                },
                new BlockModel
                {
                    BlockType = BlockType.Paragraph,
                    Content = new List<ContentModel>
                    {
                        new ContentModel { ContentType = ContentType.Text, Content = "List the primary project goals and desired outcomes." }
                    }
                },
                new BlockModel
                {
                    BlockType = BlockType.NumberedList,
                    Properties = new NumberedListBlockSettings { Placeholder = "Add item" },
                    Content = new List<ContentModel>()
                },
                new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
                // Team Members
                new BlockModel
                {
                    BlockType = BlockType.Heading,
                    Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
                    Content = new List<ContentModel>
                    {
                        new ContentModel { ContentType = ContentType.Text, Content = "🧑‍💻 Team Members" }
                    }
                },
                new BlockModel
                {
                    BlockType = BlockType.Table,
                    Properties = new TableBlockSettings
                    {
                        Columns = new List<TableColumnModel>
                        {
                            new TableColumnModel { HeaderText = "Name" },
                            new TableColumnModel { HeaderText = "Role" },
                            new TableColumnModel { HeaderText = "Location" },
                            new TableColumnModel { HeaderText = "Core working hours" }
                        },
                        Rows = new List<TableRowModel>
                        {
                            new TableRowModel
                            {
                                Cells =
                                {
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "Full Name" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "Designation" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "City, Country" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "Timezone / Hours" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    }
                                }
                            },
                            new TableRowModel
                            {
                                Cells =
                                {
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "Full Name" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "Designation" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "City, Country" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "Timezone / Hours" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    }
                                }
                            },
                            new TableRowModel
                            {
                                Cells =
                                {
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "Full Name" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "Designation" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "City, Country" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "Timezone / Hours" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
                // Project Deliverables
                new BlockModel
                {
                    BlockType = BlockType.Heading,
                    Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
                    Content = new List<ContentModel>
                    {
                        new ContentModel { ContentType = ContentType.Text, Content = "🛠️ Project Deliverables" }
                    }
                },
                new BlockModel
                {
                    BlockType = BlockType.Table,
                    Properties = new TableBlockSettings
                    {
                        Columns = new List<TableColumnModel>
                        {
                            new TableColumnModel {  HeaderText = "Task / Deliverable" },
                            new TableColumnModel {  HeaderText = "Assigned to" },
                            new TableColumnModel {  HeaderText = "Due date" },
                            new TableColumnModel {  HeaderText = "Bucket / Status" }
                        },
                        Rows = new List<TableRowModel>
                        {
                            new TableRowModel
                            {
                                Cells =
                                {
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "e.g., Finalize user flows" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "e.g., Lead Designer" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "e.g., 15 Dec" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "e.g., Design" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    }
                                }
                            },
                            new TableRowModel
                            {
                                Cells =
                                {
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "Add deliverable..." },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "Owner" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "Due date" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "Bucket" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    }
                                }
                            },
                            new TableRowModel
                            {
                                Cells =
                                {
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "Add deliverable..." },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "Owner" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "Due date" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    },
                                    new TableCellModel
                                    {
                                        Blocks =
                                        {
                                            new BlockModel
                                            {
                                                BlockType = BlockType.Paragraph,
                                                Properties = new ParagraphBlockSettings { Placeholder = "Bucket" },
                                                Content = { new ContentModel { ContentType = ContentType.Text } }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
                // Relevant Links & Resources
                new BlockModel
                {
                    BlockType = BlockType.Heading,
                    Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
                    Content = new List<ContentModel>
                    {
                        new ContentModel { ContentType = ContentType.Text, Content = "🔗 Relevant Links & Resources" }
                    }
                },
                new BlockModel
                {
                    BlockType = BlockType.BulletList,
                    Properties = new BulletListBlockSettings { Placeholder = "Add item" },
                    Content = new List<ContentModel>()
                },
                new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
            };
                }

        private static List<BlockModel> GetTeamDecisionsBlocks()
        {
            return new List<BlockModel>
    {
        // Stakeholders
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "List relevant stakeholders here." }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Question
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "🐘 Question" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Add question for the group decision here." }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Background context
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "✨ Background context" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Provide concise background and why this decision matters now." }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Constraints
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "🧊 Constraints" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "List known limitations, risks, dependencies, or non-negotiables." }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Properties = new BulletListBlockSettings { Placeholder = "Add item" },
            Content = new List<ContentModel>()
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Assumptions
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "🤔 Assumptions" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "List anything we’re assuming to be true (or false) for this decision." }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Properties = new BulletListBlockSettings { Placeholder = "Add item" },
            Content = new List<ContentModel>()
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Compare ideas
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "🏓 Compare ideas" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Table,
            Properties = new TableBlockSettings
            {
                Columns = new List<TableColumnModel>
                {
                    new TableColumnModel {  HeaderText = "Idea" },
                    new TableColumnModel {  HeaderText = "Pros" },
                    new TableColumnModel {  HeaderText = "Cons" },
                    new TableColumnModel {  HeaderText = "Votes" }
                },
                Rows = new List<TableRowModel>
                {
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "e.g., Launch with MVP in 6 weeks" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "e.g., Faster feedback, lower cost" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "e.g., Missing key features" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "0" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            }
                        }
                    }
                }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Next Steps
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "👟 Next Steps" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Table,
            Properties = new TableBlockSettings
            {
                Columns = new List<TableColumnModel>
                {
                    new TableColumnModel {  HeaderText = "Task" },
                    new TableColumnModel {  HeaderText = "Assigned to" },
                    new TableColumnModel {  HeaderText = "Due date" },
                    new TableColumnModel {  HeaderText = "Bucket" }
                },
                Rows = new List<TableRowModel>
                {
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Task description" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Assignee" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Date" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "To do" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Task description" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Assignee" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Date" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "To do" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Final decision
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "🎉 Final decision" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Add final decision here." }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
    };
        }

        private static List<BlockModel> GetProjectPlanningBlocks()
        {
            return new List<BlockModel>
    {
        // Progress Label
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Label, Properties = new LabelContentSettings { LabelID = "progress" } },
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Roles
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "🏆 Roles" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Table,
            Properties = new TableBlockSettings
            {
                Columns = new List<TableColumnModel>
                {
                    new TableColumnModel {  HeaderText = "Roles" },
                    new TableColumnModel {  HeaderText = "Assignees" }
                },
                Rows = new List<TableRowModel>
                {
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Designation" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Name" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Designation" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Name" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Background context
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "⭐ Background context" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Briefly explain the business need, user problem, or opportunity this project addresses — include key industry context or triggers." }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Add an inspiring or strategic quote here to set the tone." }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Opportunity statement
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "☁️ Opportunity statement" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Clearly state the user/business problem, why it matters now, and the value or impact of solving it." }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Assignments
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "✏️ Assignments" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Table,
            Properties = new TableBlockSettings
            {
                Columns = new List<TableColumnModel>
                {
                    new TableColumnModel {  HeaderText = "Job/feature" },
                    new TableColumnModel {  HeaderText = "When customers" },
                    new TableColumnModel {  HeaderText = "They should" },
                    new TableColumnModel {  HeaderText = "So that" }
                },
                Rows = new List<TableRowModel>
                {
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Feature or task name" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Trigger or user context" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Desired action or behavior" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Business/user value or outcome" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            }
                        }
                    }
                }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Goals
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "🥅 Goals" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Define the measurable outcomes we want to achieve." }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Table,
            Properties = new TableBlockSettings
            {
                Columns = new List<TableColumnModel>
                {
                    new TableColumnModel { HeaderText = "High priority" },
                    new TableColumnModel { HeaderText = "Medium priority" },
                    new TableColumnModel { HeaderText = "Low priority" }
                },
                Rows = new List<TableRowModel>
                {
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "List critical must-achieve outcomes" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "List important but non-urgent outcomes" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "List nice-to-have or future outcomes" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            }
                        }
                    }
                }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Milestones
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "🚀 Milestones" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Table,
            Properties = new TableBlockSettings
            {
                Columns = new List<TableColumnModel>
                {
                    new TableColumnModel { HeaderText = "Work area" },
                    new TableColumnModel { HeaderText = "Owner" },
                    new TableColumnModel { HeaderText = "Progress" },
                    new TableColumnModel { HeaderText = "End date" },
                    new TableColumnModel { HeaderText = "Obstacles" }
                },
                Rows = new List<TableRowModel>
                {
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "List major phase or deliverable" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Assign responsible person" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Current status or % complete" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Target completion date" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Note any blockers or risks" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            }
                        }
                    }
                }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Team temp check
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "🌡️ Team temp check" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Quick pulse: On a scale of 1–5, how confident are you right now with our direction, workload, and collaboration? Plus one thing that’s working well and one thing we should adjust." }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Table,
            Properties = new TableBlockSettings
            {
                Columns = new List<TableColumnModel>
                {
                    new TableColumnModel { HeaderText = "Feelings" },
                    new TableColumnModel { HeaderText = "Reflection" },
                    new TableColumnModel { HeaderText = "Votes" }
                },
                Rows = new List<TableRowModel>
                {
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "How you feel (e.g. Happy Thumbs Up Worried)" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "One sentence on what’s driving that feeling" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "0" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
                                }
                            }
                        }
                    }
                }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Relevant links
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "🔗 Relevant links" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Add relevant links here." }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
    };
        }

        private static List<BlockModel> GetMeetingNotesBlocks()
        {
            return new List<BlockModel>
    {
        // Meeting Date
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Add meeting date here." }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Topic
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "📌 Topic" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Add meeting topic here." }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Attendees
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "👥 Attendees" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Table,
            Properties = new TableBlockSettings
            {
                Columns = new List<TableColumnModel>
                {
                    new TableColumnModel { HeaderText = "Name" },
                    new TableColumnModel { HeaderText = "Role" }
                },
                Rows = new List<TableRowModel>
                {
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Full Name" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Designation" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Full Name" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Designation" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Agenda
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "📃 Agenda" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "The agenda outlines the topics to be discussed and ensures the meeting stays focused and productive. Each item should have a clear purpose and expected outcome." }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Example Agenda Structure:", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } }
            }
        },
        // Welcome & Objectives
        new BlockModel
        {
            BlockType = BlockType.NumberedList,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Welcome & Objectives", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = " – Brief introduction and purpose of the meeting." }
            }
        },
        // Project Updates
        new BlockModel
        {
            BlockType = BlockType.NumberedList,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Project Updates", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = " – Status reports from team members." }
            }
        },
        // Discussion Topics
        new BlockModel
        {
            BlockType = BlockType.NumberedList,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Discussion Topics", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = " – Key issues or decisions to address." }
            }
        },
        // Action Items Review
        new BlockModel
        {
            BlockType = BlockType.NumberedList,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Action Items Review", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = " – Check progress on previous tasks." }
            }
        },
        // Next Steps & Closing
        new BlockModel
        {
            BlockType = BlockType.NumberedList,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Next Steps & Closing", Properties = new TextContentSettings { Styles = new StyleModel { Bold = true } } },
                new ContentModel { ContentType = ContentType.Text, Content = " – Summarize decisions and assign new tasks." }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Notes
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "✏️ Notes" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Use this section to capture additional details, observations, or important remarks that do not fall under specific agenda items." }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Examples" }
            }
        },
        // Clarifications
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Clarifications provided during discussion" }
            }
        },
        // Risks
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Risks or concerns raised" }
            }
        },
        // Suggestions
        new BlockModel
        {
            BlockType = BlockType.BulletList,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Suggestions for improvement" }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Tasks
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "🎊 Tasks" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Table,
            Properties = new TableBlockSettings
            {
                Columns = new List<TableColumnModel>
                {
                    new TableColumnModel { HeaderText = "Task" },
                    new TableColumnModel { HeaderText = "Assigned to" },
                    new TableColumnModel { HeaderText = "Due date" },
                    new TableColumnModel { HeaderText = "Bucket" }
                },
                Rows = new List<TableRowModel>
                {
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Task description" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Assignee" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Date" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "To do" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new TableRowModel
                    {
                        Cells =
                        {
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Task description" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Assignee" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "Date" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            },
                            new TableCellModel
                            {
                                Blocks =
                                {
                                    new BlockModel
                                    {
                                        BlockType = BlockType.Paragraph,
                                        Properties = new ParagraphBlockSettings { Placeholder = "To do" },
                                        Content = new List<ContentModel>
                                        {
                                            new ContentModel { ContentType = ContentType.Text }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() },
        // Relevant links
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 4, Placeholder = "Heading 4" },
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "🔗 Relevant links" }
            }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = new List<ContentModel>
            {
                new ContentModel { ContentType = ContentType.Text, Content = "Add relevant links here." }
            }
        },
        new BlockModel { BlockType = BlockType.Paragraph, Content = new List<ContentModel>() }
    };
        }

    }
}
