#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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
                FileName = "DefaultFunctionalities.razor",
                NotificationDescription = new string[] {
                    @"Showcases the basic rendering of the AI AssistView component and its Suggestions, BannerTemplate, PromptRequested, and AssistViewToolbar items."
                }
            },
            new Sample
            {
                Name = "Custom Views",
                Category = "AI AssistView",
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/custom-views",
                FileName = "Views.razor",
                NotificationDescription = new string[] {
                    @"Showcases the different views of the AI AssistView component for creating customized views in addition to the built-in assist view."
                }
            },
            new Sample
            {
                Name = "Template",
                Category = "AI AssistView",
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/template",
                FileName = "Template.razor",
                NotificationDescription = new string[] {
                    @"Showcases the customization of the AI AssistView component using various templates."
                }
            },
            new Sample
            {
                Name = "Dialog",
                Category = "Integration",
                Directory = "InteractiveChat/AIAssistView",
                Url = "ai-assistview/dialog",
                FileName = "Dialog.razor",
                NotificationDescription = new string[] {
                    @"Shows a use-case of the AI AssistView component in the dialog control."
                }
            }
        };        
    }

}
