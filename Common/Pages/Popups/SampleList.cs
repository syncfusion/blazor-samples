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
        public List<Sample> Dialog { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Dialog Component | Modal Popup Window | Syncfusion",
                HeaderText = "Blazor Dialog Example - Default Functionalities",
                MetaDescription = "This Blazor Dialog example demonstrates the basic features of a modal popup including header, content, and button configurations. Easily display information or capture user input with customizable dialogs."
            },
            new Sample
            {
                Name = "Modal",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/modal",
                FileName = "Modal.razor",
                MetaTitle = "Blazor Modal Dialog | Background Overlay | Syncfusion",
                HeaderText = "Blazor Dialog Example - Modal Dialog",
                MetaDescription = "This Blazor Dialog example demonstrates modal behavior with background overlay that blocks interaction with the page beneath. Configure modal dialogs to require user attention and response."
            },
            new Sample
            {
                Name = "Template",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor Dialog Templates | Custom Content Layout | Syncfusion",
                HeaderText = "Blazor Dialog Example - Content Templates",
                MetaDescription = "This Blazor Dialog example demonstrates using templates to customize dialog content with complex layouts and rich media. Create appealing dialog interfaces with custom templates and styling options."
            },
            new Sample
            {
                Name = "Draggable",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/draggable",
                FileName = "Draggable.razor",
                MetaTitle = "Blazor Draggable Dialog | Movable Popups | Syncfusion",
                HeaderText = "Blazor Dialog Example - Draggable Functionality",
                MetaDescription = "This Blazor Dialog example demonstrates draggable functionality that allows users to reposition dialogs on screen. Enable drag-and-drop behavior for movable dialog windows with customizable drag area restrictions."
            },
            new Sample
            {
                Name = "Resizable",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/resizable",
                FileName = "Resizable.razor",
                MetaTitle = "Blazor Resizable Dialog | Adjustable Size Windows | Syncfusion",
                HeaderText = "Blazor Dialog Example - Resizable Functionality",
                MetaDescription = "This Blazor Dialog example demonstrates resizable dialogs that users can adjust to their preferred size. Enable corner and edge resizing handles with min/max size constraints for flexible dialog dimensions."
            },
            new Sample
            {
                Name = "Positioning",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/positioning",
                FileName = "Positioning.razor",
                MetaTitle = "Blazor Dialog Positioning | Custom Placement | Syncfusion",
                HeaderText = "Blazor Dialog Example - Custom Positioning",
                MetaDescription = "This Blazor Dialog example demonstrates various positioning options for dialog windows. Configure dialogs to appear at predefined locations or relative positions with customizable offsets and alignment."
            },
             new Sample
            {
                Name = "Animation",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/animation",
                FileName = "Animation.razor",
                MetaTitle = "Blazor Dialog Animations | Transition Effects | Syncfusion",
                HeaderText = "Blazor Dialog Example - Animation Effects",
                MetaDescription = "This Blazor Dialog example demonstrates various animation effects for dialog opening and closing. Apply smooth transitions like zoom, slide, or fade with customizable duration and timing functions."
            },
            new Sample
            {
                Name = "Multiple Dialogs",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/multiple-dialogs",
                FileName = "MultipleDialogs.razor",
                MetaTitle = "Blazor Multiple Dialogs | Nested Popups | Syncfusion",
                HeaderText = "Blazor Dialog Example - Multiple Dialog Management",
                MetaDescription = "This Blazor Dialog example demonstrates handling multiple dialogs with proper stacking and z-index management. Create nested dialogs, dialog chains, or independent dialogs with proper focus management."
            },
             new Sample
            {
                Name = "Components inside Dialog",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/components-inside-dialog",
                FileName = "ComponentsInsideDialog.razor",
                MetaTitle = "Blazor Dialog with Components | Complex UI Integration | Syncfusion",
                HeaderText = "Blazor Dialog Example - Components Inside Dialog",
                MetaDescription = "This Blazor Dialog example demonstrates hosting other components within dialogs. Integrate forms, grids, charts and other Blazor components inside dialog content for rich interactive experiences."
            }
        };
        public List<Sample> PredefinedDialogs { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Predefined Dialogs",
                Directory = "Popups/PredefinedDialogs",
                Url = "predefined-dialogs/default-functionalities",
                MetaTitle = "Predefined Dialogs Default Example - Syncfusion Demos",
                FileName = "DefaultFunctionalities.razor",
                HeaderText = "Blazor Predefined Dialogs Example - Default Functionalities",
                MetaDescription = "This Blazor Predefined Dialogs example demonstrates built-in alert, confirm, and prompt dialogs with ready-to-use configurations. Create standard dialog interactions without custom template development."
            },
             new Sample
            {
                Name = "Customization",
                Category = "Predefined Dialogs",
                Directory = "Popups/PredefinedDialogs",
                Url = "predefined-dialogs/customization",
                FileName = "Customization.razor",
                MetaTitle = "Blazor Predefined Dialogs Customization | Styled Alerts | Syncfusion",
                HeaderText = "Blazor Predefined Dialogs Example - Customization Options",
                MetaDescription = "This Blazor Predefined Dialogs example demonstrates customizing built-in dialogs with different themes, positions, animations and content. Style alert, confirm and prompt dialogs with your application design."
            }

        };
        public List<Sample> Tooltip { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/default",
                FileName = "Default.razor",
                MetaTitle = "Blazor Tooltip Component | Information Popups | Syncfusion",
                HeaderText = "Blazor Tooltip Example - Default Functionalities",
                MetaDescription = "This Blazor Tooltip example demonstrates basic tooltip functionality for displaying additional information on hover or focus. Create informative tooltips with customizable delays and positions."
            },
            new Sample
            {
                Name = "HTML Template",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/html-template",
                FileName = "HtmlTemplate.razor",
                MetaTitle = "Blazor Tooltip HTML Content | Rich Tooltips | Syncfusion",
                HeaderText = "Blazor Tooltip Example - HTML Templates",
                MetaDescription = "This Blazor Tooltip example demonstrates using HTML content in tooltips for rich formatted information. Create tooltips with images, links, formatted text, and other HTML elements."
            },
            new Sample
            {
                Name = "Template",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor Tooltip Templates | Custom Content | Syncfusion",
                HeaderText = "Blazor Tooltip Example - Custom Templates",
                MetaDescription = "This Blazor Tooltip example demonstrates custom content templates for enhanced tooltip designs. Create visually appealing tooltips with complex layouts using Blazor templating capabilities.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Tooltip Menu",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/menu",
                FileName = "Menu.razor",
                MetaTitle = "Blazor Tooltip Menu | Interactive Tooltips | Syncfusion",
                HeaderText = "Blazor Tooltip Example - Tooltip Menu",
                MetaDescription = "This Blazor Tooltip example demonstrates creating interactive tooltip menus with clickable options. Implement compact navigation menus or action lists using tooltips with interactive elements.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "API",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/api",
                FileName = "Api.razor",
                MetaTitle = "Blazor Tooltip API | Programmatic Control | Syncfusion",
                HeaderText = "Blazor Tooltip Example - API Functionalities",
                MetaDescription = "This Blazor Tooltip example demonstrates programmatic control of tooltips through API methods. Show, hide, and position tooltips dynamically based on application logic and user interactions."
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/keyboard-navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor Tooltip Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor Tooltip Example - Keyboard Navigation",
                MetaDescription = "This Blazor Tooltip example demonstrates keyboard-accessible tooltip interactions for improved accessibility. Navigate and trigger tooltips using keyboard shortcuts for better usability and WCAG compliance.",
                Type = SampleType.None
            }
        };   
    }
}