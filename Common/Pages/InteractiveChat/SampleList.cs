using System.Collections.Generic;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        private static readonly string[] StreamingResponseNotification = new string[]
        {
            @"AI AssistView brings real-time assistance to your Blazor editor experience by provided the built-in streaming responses for instant AI feedback as you type or query. It features seamless Markdown-to-HTML conversion powered by Syncfusion's robust Markdown handling (integrated with MarkdownCovertor for fast, accurate parsing and live preview), allowing clean rendering of formatted AI-generated content directly in the editor."
        };
        public List<Sample> AIAssistView { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "AI AssistView",
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/default-functionalities",
                MetaTitle = "Blazor AI AssistView - Default | InteractiveChat Demos | Syncfusion",
                HeaderText = "Blazor AI AssistView Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor AI AssistView delivers conversational UI with markdown rendering and code highlighting to build rich AI chat experiences.",
                FileName = "DefaultFunctionalities.razor",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-ai-assistview",
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
                MetaTitle = "Blazor AIAssistView Demo - Custom Views Examples | Syncfusion",
                HeaderText = "Blazor AI AssistView Example - Custom Views",
                MetaDescription = "See how the Syncfusion Blazor AI AssistView supports custom views with flexible templates to build tailored layouts and interactive AI conversation interfaces.",
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
                MetaTitle = "Blazor AIAssistView Demos - Streaming Response Examples | Syncfusion",
                HeaderText = "Blazor AI AssistView Example - Streaming Response",
                NotificationDescription = StreamingResponseNotification,
                MetaDescription = "See how the Syncfusion Blazor AI AssistView displays streaming responses in real time with progressive rendering to create smooth and dynamic interactions.",
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
                MetaTitle = "Blazor AIAssistView Demos - File Attachments Examples | Syncfusion",
                HeaderText = "Blazor AI AssistView Example - File Attachment Support",
                MetaDescription = "See how the Syncfusion Blazor AI AssistView supports file attachments with uploads and previews to add context and improve conversational workflows easily.",
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
                MetaTitle = "Blazor AIAssistView - Template | InteractiveChat Demo | Syncfusion",
                HeaderText = "Blazor AI AssistView Example - Template Customization",
                MetaDescription = "See how the Syncfusion Blazor AI AssistView uses templates to customize layouts with HTML and styling to enhance AI message presentation and responses",
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
                Category = "Use Cases",
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/dialog",
                FileName = "Dialog.razor",
                MetaTitle = "Blazor AIAssistView Demos - Notes Assistant Examples | Syncfusion",
                HeaderText = "Blazor AI AssistView Example - Dialog Integration",
                MetaDescription = "See how the Syncfusion Blazor AI AssistView integrates notes assistant in dialogs with structured layouts to provide seamless and guided user assistance.",
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
            },
    #if SERVER
            new Sample
            {
                Name = "Multiple AI Models",
                Category = "Use Cases",
                Type = SampleType.AI,
                Directory = "AISamples/AIAssistView",
                Url = "ai-assistview/ai-models",
                FileName = "MultiModelAI.razor",
                MetaTitle = "Blazor AIAssistView Demos - Multiple AI Models Examples | Syncfusion",
                HeaderText = "Blazor AI AssistView - AI Powered Multi-Model Example",
                MetaDescription = "See how the Syncfusion Blazor AI AssistView integrates multiple AI models with switching support to enable flexible and versatile AI driven workflows.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "MultiModelAI.razor",
                        Id="MultiModelAI",
                    },
                    new SourceCollection
                    {
                        FileName = "AIService.cs",
                        Id="AIService",
                    }
                }
            },
    #endif
             new Sample
            {
                Name = "Speech To Text",
                Category = "Speech",
                Type = SampleType.Updated,
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/ai-speechtotext",
                FileName = "SpeechToText.razor",
                MetaTitle = "Blazor AIAssistView Demos - Speech To Text Examples | Syncfusion",
                HeaderText = "Blazor AI AssistView Example - Speech To Text",
                NotificationDescription = [@"AI AssistView now supports built-in speech-to-text conversion, which helps to ask queries to AI through voice and allowing customizations."],
                MetaDescription = "See how the Syncfusion Blazor AI AssistView enables speech to text conversion with voice input and transcription to enhance conversational interactions.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "SpeechToText.razor",
                        Id="SpeechToText",
                    },
                    new SourceCollection
                    {
                        FileName = "OpenAIService.cs",
                        Id="OpenAIService",
                    }
                }
            },
            new Sample
            {
                Name = "Text To Speech",
                Category = "Speech",
                Type = SampleType.Updated,
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/ai-texttospeech",
                FileName = "TextToSpeech.razor",
                MetaTitle = "Blazor AIAssistView Demos - Text To Speech Examples | Syncfusion",
                HeaderText = "Blazor AI AssistView Example - Text To Speech",
                NotificationDescription = [@"AI AssistView now supports built-in text-to-speech conversion which reads AI responses aloud and also allows customizations."],
                MetaDescription = "See how the Syncfusion Blazor AI AssistView converts responses to audio with playback controls and AI voices to improve accessibility and engagement easily.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "TextToSpeech.razor",
                        Id="TextToSpeech",
                    },
                    new SourceCollection
                    {
                        FileName = "AzureOpenAIService.cs",
                        Id="AzureOpenAIService",
                    }
                }
            },
            new Sample
            {
                Name = "Claude AI-like",
                Category = "UI Customization",
                Type = SampleType.New,
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/claude-like",
                FileName = "ClaudeLike.razor",
                MetaTitle = "Blazor AIAssistView Demos - Claude Clone Examples | Syncfusion",
                HeaderText = "Blazor AI AssistView Example - Claude Clone",
                MetaDescription = "This Blazor AI AssistView demo integrates Claude line UI appearance with the AIAssistView control supported features with footer toolbar and banner template.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "claudeLike.razor",
                        Id="claudeLike",
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
                Name = "Gemini AI-like",
                Category = "UI Customization",
                Type = SampleType.New,
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/gemini-like",
                FileName = "GeminiLike.razor",
                MetaTitle = "Blazor AIAssistView Demos - Gemini Clone Examples | Syncfusion",
                HeaderText = "Blazor AI AssistView Example - Gemini Clone",
                MetaDescription = "This Blazor AI AssistView demo integrates Gemini-inspired UI appearance with AIAssistView control supported features with footer toolbar and banner template.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "GeminiLike.razor",
                        Id="GeminiLike",
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
                MetaTitle = "Blazor ChatUI - Default | InteractiveChat Demos | Syncfusion",
                HeaderText = "Blazor ChatUI Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Default Functionalities builds chat interfaces with message history, avatars, and timestamps to enable real time communication.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-chat-ui",
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
                MetaTitle = "Blazor ChatUI - Load On-Demand | InteractiveChat Demos | Syncfusion",
                HeaderText = "Blazor ChatUI Example - Load On-Demand Messages",
                MetaDescription = "See how the Syncfusion Blazor Chat UI loads chat history dynamically on demand using virtualization and lazy loading to improve performance and speed.",
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
                Name = "File Attachments",
                Category = "Chat UI",
                Directory = "InteractiveChat/ChatUI",
                Url = "chat-ui/attachments",
                FileName = "Attachments.razor",
                MetaTitle = "Blazor ChatUI - File Attachments | InteractiveChat Demos | Syncfusion",
                HeaderText = "Blazor ChatUI Example - File Attached Messages",
                MetaDescription = "See how the Syncfusion Blazor Chat UI supports file uploads and previews within chats to improve communication and enable efficient data sharing workflows.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "Attachments.razor",
                        Id="Attachments",
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
                MetaTitle = "Blazor ChatUI - Template | InteractiveChat Demos | Syncfusion",
                HeaderText = "Blazor ChatUI Example - Custom Message Templates",
                MetaDescription = "See how the Syncfusion Blazor Chat UI demonstrates real-world chat applications with integrations and UI components to build complete messaging solutions.",
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
                MetaTitle = "Blazor ChatUI Demos - API Sample | InteractiveChat Demos | Syncfusion",
                HeaderText = "Blazor ChatUI Example - API Methods Usage",
                MetaDescription = "See how the Syncfusion Blazor Chat UI provides API methods to control chat behavior with message handling and scrolling for dynamic chat applications.",
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
                MetaTitle = "Blazor ChatUI - Use Case | InteractiveChat Demos | Syncfusion",
                HeaderText = "Blazor ChatUI Example - Application Integration",
                MetaDescription = "See how the Syncfusion Blazor Chat UI demonstrates real world chat applications with integrations and UI components to build complete messaging solutions.",
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
                    },
                    new SourceCollection
                    {
                        FileName = "ChatIntegration.razor.css",
                        Id="ChatIntegrationStyle"
                    }
                }
            }

        };

        public List<Sample> InlineAIAssist { get; set; } = new List<Sample> {
        #if SERVER
            new Sample
            {
                Name = "Overview",
                Category = "Inline AI Assist",
                Directory = "AISamples/InlineAIAssist",
                Url = "inline-ai-assist/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor InlineAIAssist - Overview | InteractiveChat Demos | Syncfusion",
                HeaderText = "Blazor InlineAIAssist - AI Powered Overview Example",
                NotificationDescription = [@"The Blazor Inline AI Assist component streams AI responses inline and inserts AI-generated content directly into the editor; provides customizable commands for performing quick AI queries and exposes response actions to process generated outputs (for example: accept, edit, insert, or discard) and integrate them into the editing workflow."],
                MetaDescription = "Blazor InlineAIAssist demo shows default features such as command menu interacCtions and response menu actions with interactive AI response visualization.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "Overview.razor",
                        Id="Overview",
                    }
                }
            }
        #endif
        };
    }
}
