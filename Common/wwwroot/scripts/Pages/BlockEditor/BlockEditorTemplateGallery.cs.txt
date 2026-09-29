using System;
using System.Collections.Generic;
using Syncfusion.Blazor.BlockEditor;


namespace Syncfusion.Blazor.BlockEditorDemo
{
    public static class BlockEditorTemplateGallery
    {
          public static IReadOnlyList<TemplateCard> GetCards()
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

    public class TemplateCard
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Icon { get; set; } = "📄";
        public string Name { get; set; } = "";
        public string Subtitle { get; set; } = "";
        public IReadOnlyList<BlockModel> Blocks { get; init; } = new List<BlockModel>();
    }
}