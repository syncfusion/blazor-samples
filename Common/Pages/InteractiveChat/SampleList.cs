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
                MetaDescription = "This Blazor AI AssistView example demonstrates the default features including conversational UI, markdown rendering, code highlighting, and AI response visualization for interactive chat applications.",
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
                MetaDescription = "This Blazor AI AssistView example demonstrates how to implement custom views with different layouts, styling options, and presentation formats to tailor the AI conversation experience to specific requirements.",
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
                MetaDescription = "This Blazor AI AssistView example demonstrates real-time streaming response capabilities to display AI-generated content as it's being created, providing an interactive and dynamic user experience.",
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
                Type = SampleType.New,
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/attachments",
                MetaTitle = "AI AssistView Default Functionalities - Syncfusion Demos",
                HeaderText = "Blazor AI AssistView Example - File Attachment Support",
                MetaDescription = "This Blazor AI AssistView example demonstrates file attachment capabilities, allowing users to upload and share various file types within AI conversations for enhanced context and communication.",
                FileName = "Attachments.razor",
                NotificationDescription = new string[] {
                    @"Showcases how users can enhance their AI conversations by uploading and sharing files directly within the chat, providing additional context and improving the overall communication experience."
                },
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
                MetaDescription = "This Blazor AI AssistView example demonstrates how to use custom templates to personalize the appearance of chat messages, AI responses, and user interface elements for a tailored conversational experience.",
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
                Name = "Dialog",
                Category = "Integration",
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/dialog",
                FileName = "Dialog.razor",
                MetaTitle = "Blazor AI AssistView Dialog Integration | Modal Chat | Syncfusion",
                HeaderText = "Blazor AI AssistView Example - Dialog Integration",
                MetaDescription = "This Blazor AI AssistView example demonstrates how to integrate AI conversation capabilities within a dialog component, providing a modal interface for AI interactions without disrupting the main application flow.",
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
                MetaDescription = "This Blazor ChatUI example demonstrates the default messaging interface with message history, user avatars, timestamps, and intuitive input options for building conversational applications.",
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
                MetaDescription = "This Blazor ChatUI example demonstrates efficient loading of large message histories on demand, optimizing performance by loading only visible messages and retrieving older messages as users scroll.",
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
                MetaDescription = "This Blazor ChatUI example demonstrates how to customize message appearance with templates, supporting rich content rendering including images, links, files, and interactive elements in chat conversations.",
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
                MetaDescription = "This Blazor ChatUI example demonstrates the component's API methods for programmatic control, including adding messages, scrolling to specific points, and managing the chat interface dynamically from code.",
                NotificationDescription = new string[] {
                    @"Highlights the latest ChatUI features including message options like reply, copy, pin, delete and forward for improved interaction, compact mode for streamlined layouts, and user status icons to indicate presence within the conversation."
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
                Category = "Integration",
                Directory = "InteractiveChat/ChatUI",
                Url = "chat-ui/chat-integration",
                FileName = "ChatIntegration.razor",
                MetaTitle = "Blazor ChatUI Integration | Real-world Implementation | Syncfusion",
                HeaderText = "Blazor ChatUI Example - Application Integration",
                MetaDescription = "This Blazor ChatUI example demonstrates a real-world implementation of the chat component integrated with other UI elements to create a complete messaging application with contacts list and conversation management.",
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
