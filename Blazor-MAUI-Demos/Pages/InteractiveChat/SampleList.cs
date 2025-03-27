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
using Blazor_MAUI_Demos;
namespace Blazor_MAUI_Demos
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
                Name = "Template",
                Category = "AI AssistView",
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/template",
                FileName = "Template.razor",
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
                NotificationDescription = new string[] {
                    @"Showcases the basic functionality of the Chat UI component, showcasing how to integrate and use it for chat interactions with simple configurations."
                },
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
                Name = "Template",
                Category = "Chat UI",
                Directory = "InteractiveChat/ChatUI",
                Url = "chat-ui/template",
                FileName = "Template.razor",
                NotificationDescription = new string[] {
                    @"Highlights the template functionality in the Chat UI, allowing customization of chat message appearances, including different templates for messages, empty chats, and time breaks."
                },
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
                NotificationDescription = new string[] {
                    @"Demonstrates how to customize the Chat UI component using its API, including properties like timestamp format, visibility of headers/footers, and time breaks."
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
                NotificationDescription = new string[] {
                    @"Showcases how to design a chat application with a multi-user interface, where pre-loaded messages for different users are displayed and managed, along with dynamic message responses."
                },
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
