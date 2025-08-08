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
        public List<Sample> Toast { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Toast Notification | Alert Messages | Syncfusion",
                HeaderText = "Blazor Toast Example - Default Functionalities",
                MetaDescription = "This Blazor Toast example demonstrates the basic notification features with customizable duration, position, and appearance. Display temporary non-intrusive alerts for user feedback."
            },
            new Sample
            {
                Name = "Types",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/types",
                FileName = "Types.razor",
                MetaTitle = "Blazor Toast Types | Success, Error, Warning Alerts | Syncfusion",
                HeaderText = "Blazor Toast Example - Notification Types",
                MetaDescription = "This Blazor Toast example demonstrates different notification types including success, error, warning, and information. Use color-coded alerts to convey message importance and context."
            },
            new Sample
            {
                Name = "Template",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor Toast Templates | Custom Notification Design | Syncfusion",
                HeaderText = "Blazor Toast Example - Custom Templates",
                MetaDescription = "This Blazor Toast example demonstrates custom notification templates with rich content. Create personalized toast notifications with images, formatted text, and interactive elements."
            },
            new Sample
            {
                Name = "Position",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/position",
                FileName = "Position.razor",
                MetaTitle = "Blazor Toast Position | Notification Placement | Syncfusion",
                HeaderText = "Blazor Toast Example - Notification Positioning",
                MetaDescription = "This Blazor Toast example demonstrates different notification placement options. Position toast messages at various screen locations including corners and edges for optimal user experience."
            },
            new Sample
            {
                Name = "API",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/api",
                FileName = "API.razor",
                MetaTitle = "Blazor Toast API | Programmatic Control | Syncfusion",
                HeaderText = "Blazor Toast Example - API Functionality",
                MetaDescription = "This Blazor Toast example demonstrates programmatic control of notifications using the API. Show, hide, and customize toast messages dynamically based on application events and user interactions."
            }
        };
        public List<Sample> Spinner { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Spinner",
                Directory = "Notifications/Spinner",
                Type = SampleType.None,
                Url = "spinner/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor Spinner Control | Loading Indicator | Syncfusion",
                HeaderText = "Blazor Spinner Example - Overview",
                MetaDescription = "This Blazor Spinner example demonstrates loading indicators for asynchronous operations. Display visual feedback during data loading, processing, and page transitions with customizable spinners."
            }
        };
        public List<Sample> Message { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Message",
                Directory = "Notifications/Message",
                Url = "message/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Message Component | Inline Notifications | Syncfusion",
                HeaderText = "Blazor Message Example - Default Functionalities",
                MetaDescription = "This Blazor Message example demonstrates inline notification banners with various severity levels. Display contextual information, warnings, errors, and success messages within the application content flow."
            },
            new Sample
            {
                Name = "Variants",
                Category = "Message",
                Directory = "Notifications/Message",
                Url = "message/variants",
                FileName = "Variants.razor",
                MetaTitle = "Blazor Message Variants | Filled, Outlined Styles | Syncfusion",
                HeaderText = "Blazor Message Example - Style Variants",
                MetaDescription = "This Blazor Message example demonstrates different visual styles including filled, outlined, and text variants. Choose appropriate styling to match your application design and message importance."
            },
            new Sample
            {
                Name = "Icons",
                Category = "Message",
                Directory = "Notifications/Message",
                Url = "message/icons",
                FileName = "Icons.razor",
                MetaTitle = "Blazor Message Icons | Visual Indicators | Syncfusion",
                HeaderText = "Blazor Message Example - Custom Icons",
                MetaDescription = "This Blazor Message example demonstrates customizing message icons for enhanced visual communication. Use predefined or custom icons to reinforce message context and improve user understanding."
            },
            new Sample
            {
                Name = "Customization",
                Category = "Message",
                Directory = "Notifications/Message",
                Url = "message/Customization",
                FileName = "Customization.razor",
                MetaTitle = "Blazor Message Customization | Styled Notifications | Syncfusion",
                HeaderText = "Blazor Message Example - Advanced Customization",
                MetaDescription = "This Blazor Message example demonstrates styling and layout customization options. Personalize messages with custom colors, borders, backgrounds, and dimensions to match your application theme."
            },
            new Sample
            {
                Name = "Template",
                Category = "Message",
                Directory = "Notifications/Message",
                Url = "message/Template",
                FileName = "Template.razor",
                MetaTitle = "Blazor Message Templates | Rich Content | Syncfusion",
                HeaderText = "Blazor Message Example - Custom Templates",
                MetaDescription = "This Blazor Message example demonstrates using templates for complex message content. Create rich notifications with structured layouts, interactive elements, and multimedia content."
            }
        };
        public List<Sample> Skeleton { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Skeleton",
                Directory = "Notifications/Skeleton",
                Url = "skeleton/defaultfunctionalities",
                FileName = "Default.razor",
                MetaTitle = "Blazor Skeleton Component | Content Placeholder | Syncfusion",
                HeaderText = "Blazor Skeleton Example - Default Functionalities",
                MetaDescription = "This Blazor Skeleton example demonstrates content placeholders during data loading. Display loading states with skeleton shapes that match the upcoming content's layout for improved perceived performance.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Animation",
                Category = "Skeleton",
                Directory = "Notifications/Skeleton",
                Url = "skeleton/animation",
                FileName = "Animation.razor",
                MetaTitle = "Blazor Skeleton Animation | Loading Effects | Syncfusion",
                HeaderText = "Blazor Skeleton Example - Animation Effects",
                MetaDescription = "This Blazor Skeleton example demonstrates animated loading placeholders. Apply pulse, wave, or fade animations to skeleton elements for enhanced visual indication of content loading processes.",
                Type = SampleType.None
            }
        };
        public List<Sample> Badge { get; set; } = new List<Sample>{
            new Sample 
            {
                Name = "Default",
                Category = "Badge",
                Directory = "Notifications/Badge",
                Url = "badge/defaultfunctionalities",
                FileName = "Default.razor",
                MetaTitle = "Blazor Badge Component | Status Indicators | Syncfusion",
                HeaderText = "Example of Default Functionalities in Blazor CSS Badge Component",
                MetaDescription = "This Blazor Badge example demonstrates notification counters and status indicators. Display counts, statuses, and highlights with customizable badges attached to various UI elements."
            },
            new Sample
            {
                Name = "Types",
                Category = "Badge",
                Directory = "Notifications/Badge",
                Url = "badge/types",
                FileName = "Types.razor",
                MetaTitle = "Blazor Badge Types | Status Styles | Syncfusion",
                HeaderText = "Example of Types in Blazor CSS Badge Component",
                MetaDescription = "This Blazor Badge example demonstrates different badge types including primary, success, warning, danger, and info variants. Use context-appropriate badges for visual communication."
            },
            new Sample
            {
                Name = "Notification",
                Category = "Badge",
                Directory = "Notifications/Badge",
                Url = "badge/notification",
                FileName = "Notification.razor",
                MetaTitle = "Blazor Badge Notifications | Count Indicators | Syncfusion",
                HeaderText = "Example of Blazor CSS Badge Component as Notification",
                MetaDescription = "This Blazor Badge example demonstrates implementing notification counters on icons and buttons. Show unread message counts, item quantities, and other numeric indicators with positioned badges."
            },
            new Sample
            {
                Name = "ListView",
                Category = "Integration",
                Directory = "Notifications/Badge",
                Url = "badge/listview",
                FileName = "ListView.razor",
                MetaTitle = "Blazor Badge with ListView | Status Integration | Syncfusion",
                HeaderText = "Example of Blazor CSS Badge Component in ListView",
                MetaDescription = "This Blazor Badge example demonstrates integration with ListView component. Display status indicators, counts, or labels alongside list items for enhanced information visualization."
            },
            new Sample
            {
                Name = "Accordion",
                Category = "Integration",
                Directory = "Notifications/Badge",
                Url = "badge/accordion",
                FileName = "Accordion.razor",
                MetaTitle = "Blazor Badge with Accordion | Section Status | Syncfusion",
                HeaderText = "Example of Blazor CSS Badge Component in Accordion",
                MetaDescription = "This Blazor Badge example demonstrates integration with Accordion component. Add status indicators or counters to accordion headers to show content state or quantity information."
            },
            new Sample
            {
                Name = "Toolbar",
                Category = "Integration",
                Directory = "Notifications/Badge",
                Url = "badge/toolbar",
                FileName = "Toolbar.razor",
                MetaTitle = "Blazor Badge with Toolbar | Button Indicators | Syncfusion",
                HeaderText = "Example of Blazor CSS Badge Component in Toolbar",
                MetaDescription = "This Blazor Badge example demonstrates integration with Toolbar component. Add notification counters or status indicators to toolbar buttons and items for contextual information."
            }
        };
    }
}