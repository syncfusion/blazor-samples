#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> AIAssistView { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "AI AssistView",
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/default-functionalities",
                MetaTitle = "AI AssistView Default Functionalities - Syncfusion Demos",
                HeaderText = "Blazor AI AssistView Example - Default Functionalities",
                MetaDescription = "This Blazor AI AssistView demo shows default features with conversational UI, markdown rendering, code highlighting, interactive AI response visualization.",
                FileName = "DefaultFunctionalities.razor",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "DefaultFunctionalities.razor",
                        Id="DefaultFunctionalities",
                    },
                    new SourceCollection
                    {
                        FileName = "PromptResponseData.cs",
                        Id="PromptResponseData",
                    }
                }
            },
            new Sample
            {
                Name = "Custom Views",
                Category = "AI AssistView",
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/custom-views",
                FileName = "Views.razor",
                MetaTitle = "Blazor AI AssistView Custom Views | UI Customization | Syncfusion",
                HeaderText = "Blazor AI AssistView Example - Custom Views",
                MetaDescription = "This AI AssistView demo shows how to implement custom views with different layouts, style options, presentation format to tailor the AI conversation experience.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "Views.razor",
                        Id="Views",
                    },
                    new SourceCollection
                    {
                        FileName = "PromptResponseData.cs",
                        Id="PromptResponseData",
                    }
                }
            },
            new Sample
            {
                Name = "Streaming Response",
                Category = "AI AssistView",
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/assist-streaming",
                FileName = "StreamingResponse.razor",
                MetaTitle = "Blazor AI AssistView Streaming | Real-time Responses | Syncfusion",
                HeaderText = "Blazor AI AssistView Example - Streaming Response",
                MetaDescription = "This Blazor AI AssistView example demonstrates how to display AI-generated content as it's being created, providing an interactive and dynamic user experience.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "StreamingResponse.razor",
                        Id="StreamingResponse",
                    },
                    new SourceCollection
                    {
                        FileName = "PromptResponseData.cs",
                        Id="PromptResponseData",
                    }
                }
            },
            new Sample
            {
                Name = "File Attachments",
                Category = "AI AssistView",
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/attachments",
                MetaTitle = "AI AssistView Default Functionalities - Syncfusion Demos",
                HeaderText = "Blazor AI AssistView Example - File Attachment Support",
                MetaDescription = "Blazor AI AssistView demo shows file attachment capabilities, allowing users to upload, share various file types within AI conversations for enhanced context.",
                NotificationDescription = new string[] {
                    @"Showcases how users can enhance their AI conversations by uploading and sharing files directly within the chat, providing additional context and improving the overall communication experience."
                },
                FileName = "Attachments.razor",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "Attachments.razor",
                        Id="Attachments",
                    },
                    new SourceCollection
                    {
                        FileName = "PromptResponseData.cs",
                        Id="PromptResponseData",
                    }
                }
            },
            new Sample
            {
                Name = "Template",
                Category = "AI AssistView",
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor AI AssistView Templates | Custom Formatting | Syncfusion",
                HeaderText = "Blazor AI AssistView Example - Template Customization",
                MetaDescription = "This Blazor AI AssistView example shows how to use custom templates to personalize the appearance of chat messages, AI responses, and user interface elements.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "Template.razor",
                        Id="Template",
                    },
                    new SourceCollection
                    {
                        FileName = "PromptResponseData.cs",
                        Id="PromptResponseData",
                    }
                }
            },
            new Sample
            {
                Name = "Notes Assistant",
                Category = "Integration",
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/dialog",
                FileName = "Dialog.razor",
                MetaTitle = "Blazor AI AssistView Dialog Integration | Modal Chat | Syncfusion",
                HeaderText = "Blazor AI AssistView Example - Dialog Integration",
                MetaDescription = "This demo shows AI conversation integration within dialog control, creating a modal interface for AI interactions that maintains application without disruption.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "Dialog.razor",
                        Id="Dialog",
                    },
                    new SourceCollection
                    {
                        FileName = "PromptResponseData.cs",
                        Id="PromptResponseData",
                    }
                }
            }
        };

        public List<Sample> ChatUI { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Chat UI",
                Directory = "InteractiveChat/ChatUI",
                Url = "chat-ui/default-functionalities",
                FileName = "Default.razor",
                MetaTitle = "Blazor ChatUI Component | Default Features | Syncfusion",
                HeaderText = "Blazor ChatUI Example - Default Functionalities",
                MetaDescription = "Blazor ChatUI demo shows default messaging interface with message history, user avatars, timestamps, intuitive input options for building conversational apps.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "Default.razor",
                        Id="DefaultFunctionalities",
                    },
                    new SourceCollection
                    {
                        FileName = "ChatMessagesData.cs",
                        Id="ChatMessagesData",
                    }
                }
            },
            new Sample
            {
                Name = "Load On-Demand",
                Category = "Chat UI",
                Directory = "InteractiveChat/ChatUI",
                Url = "chat-ui/loadondemand",
                FileName = "LoadOnDemand.razor",
                MetaTitle = "Blazor ChatUI Load On-Demand | Lazy Loading | Syncfusion",
                HeaderText = "Blazor ChatUI Example - Load On-Demand Messages",
                MetaDescription = "This Blazor ChatUI example demonstrates efficient loading of large message histories on demand, optimizing performance by loading only visible messages.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "LoadOnDemand.razor",
                        Id="LoadOnDemand",
                    },
                    new SourceCollection
                    {
                        FileName = "ChatMessagesData.cs",
                        Id="ChatMessagesData",
                    }
                }
            },
            new Sample
            {
                Name = "Template",
                Category = "Chat UI",
                Directory = "InteractiveChat/ChatUI",
                Url = "chat-ui/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor ChatUI Templates | Message Customization | Syncfusion",
                HeaderText = "Blazor ChatUI Example - Custom Message Templates",
                MetaDescription = "This demo shows how to customize message appearance with templates. Supports rich content rendering including images, links, files, interactive elements.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "Template.razor",
                        Id="ChatTemplate",
                    },
                    new SourceCollection
                    {
                        FileName = "ChatMessagesData.cs",
                        Id="ChatMessagesData",
                    }
                }
            },
            new Sample
            {
                Name = "API",
                Category = "Chat UI",
                Directory = "InteractiveChat/ChatUI",
                Url = "chat-ui/api",
                FileName = "Api.razor",
                Type = SampleType.Updated,
                MetaTitle = "Blazor ChatUI API Methods | Programmatic Control | Syncfusion",
                HeaderText = "Blazor ChatUI Example - API Methods Usage",
                MetaDescription = "This Blazor ChatUI example demonstrates the component's API methods for programmatic control, including adding messages, scrolling to specific points.",
                NotificationDescription = new string[] {
                    @"Highlights the Chat UI's mention users feature that enables tagging participants with '@' symbol in messages, for building interactive chat experiences."
                },
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "Api.razor",
                        Id="API",
                    },
                    new SourceCollection
                    {
                        FileName = "ChatMessagesData.cs",
                        Id="ChatMessagesData",
                    }
                }
            },
            new Sample
            {
                Name = "Use Case",
                Category = "Chat UI",
                Directory = "InteractiveChat/ChatUI",
                Url = "chat-ui/chat-integration",
                FileName = "ChatIntegration.razor",
                MetaTitle = "Blazor ChatUI Integration | Real-world Implementation | Syncfusion",
                HeaderText = "Blazor ChatUI Example - Application Integration",
                MetaDescription = "This Blazor ChatUI demo shows a real-world implementation of the chat component integrated with other UI elements to create a complete messaging application.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "ChatIntegration.razor",
                        Id="ChatIntegration",
                    },
                    new SourceCollection
                    {
                        FileName = "ChatMessagesData.cs",
                        Id="ChatMessagesData",
                    }
                }
            }

        };
    }

}
