using System;
using System.Collections.Generic;
using Syncfusion.Blazor.BlockEditor;


namespace Syncfusion.Blazor.BlockEditorDemo
{
    public static class BlockEditorOverview
    {
         public static IReadOnlyList<BlockModel> GetBlockDataOverview()
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
        new BlockModel { BlockType = BlockType.Paragraph },
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
            Properties = new QuoteBlockSettings
            {
                Children = new List<BlockModel>
                {
                    new BlockModel
                    {
                        BlockType = BlockType.Paragraph,
                        Content = { new ContentModel { ContentType = ContentType.Text, Content = "“Quotes are perfect for highlighting key messages or testimonials.”" } }
                    }
                }
            }
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
        // Code Block section
        new BlockModel
        {
            BlockType = BlockType.Heading,
            Properties = new HeadingBlockSettings { Level = 3 },
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Code Block" } }
        },
        new BlockModel
        {
            BlockType = BlockType.Paragraph,
            Content = { new ContentModel { ContentType = ContentType.Text, Content = "Use code blocks to display syntax-highlighted code snippets for technical documentation or tutorials." } }
        },
        new BlockModel
        {
            BlockType = BlockType.Code,
            Content =
            {
                new ContentModel
                {
                    ContentType = ContentType.Text,
                    Content = "function greet(name) {\n return `Hello, ${name}!`;\n}"
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

        public static IReadOnlyList<UserModel> GetUniqueMentionUsers()
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

    }
}