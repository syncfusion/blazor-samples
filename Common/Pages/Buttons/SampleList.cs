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
        public List<Sample> Button { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default Functionalities",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Button Default | Basic Button Features | Syncfusion",
                HeaderText = "Blazor Button Example - Default Functionalities",
                MetaDescription = "This Blazor Button example demonstrates basic button features with customizable styling, events, and accessibility options for interactive web applications."
            },
           new Sample
            {
                Name = "Checkbox",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/checkbox",
                FileName = "CheckBox.razor",
                MetaTitle = "Blazor Checkbox | Selection Control Component | Syncfusion",
                HeaderText = "Blazor Checkbox Component Example - Default Functionalities",
                MetaDescription = "This Blazor Checkbox example demonstrates selection control with checked, indeterminate states, and form validation for effective user input collection."
            },
           new Sample
            {
                Name = "Radio Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/radio-button",
                FileName = "RadioButton.razor",
                MetaTitle = "Blazor Radio Button | Single Selection Control | Syncfusion",
                HeaderText = "Blazor Radio Button Component Example - Default Functionalities",
                MetaDescription = "This Blazor Radio Button example demonstrates single selection control, featuring grouped options and form validation for an exclusive choice scenarios."
            },
           new Sample
            {
                Name = "Dropdown Menu",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/dropdown-menu",
                FileName = "DropDownButton.razor",
                MetaTitle = "Blazor Dropdown Menu | Action Menu Component | Syncfusion",
                HeaderText = "Blazor Dropdown Menu Component Example - Default Functionalities",
                MetaDescription = "This Blazor Dropdown Menu example shows an action menu with customizable items, icons, and event handling to enhance user interaction and improve functionality."
            },
           new Sample
            {
                Name = "Split Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/split-button",
                FileName = "SplitButton.razor",
                MetaTitle = "Blazor Split Button | Dual Action Component | Syncfusion",
                HeaderText = "Blazor Split Button Component Example - Default Functionalities",
                MetaDescription = "This Blazor Split Button demo highlights dual action functionality, featuring a primary action with a dropdown menu, offering versatile interactions for users."
            },
           new Sample
            {
                Name = "Toggle Switch Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/toggle-switch-button",
                FileName = "Switch.razor",
                MetaTitle = "Blazor Toggle Switch | On/Off Control Component | Syncfusion",
                HeaderText = "Blazor Toggle Switch Button Component Example - Default Functionalities",
                MetaDescription = "This Blazor Toggle Switch example features on/off control with smooth animations and customizable styling, enabling efficient management of boolean states."
            },
           new Sample
            {
                Name = "Progress Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/progress-button",
                FileName = "ProgressButton.razor",
                MetaTitle = "Blazor Progress Button | Loading State Button | Syncfusion",
                HeaderText = "Blazor Progress Button Component Example - Default Functionalities",
                MetaDescription = "This Blazor Progress Button demo shows loading state visualization using progress indicators and spinner animations, optimized for async operation feedback.",
                Type = SampleType.None
            },
           new Sample
           {
               Name = "Button Group",
               Category = "Button",
               Directory = "Buttons/Button",
               Url = "buttons/button-group",
               FileName = "ButtonGroup.razor",
               MetaTitle = "Blazor Button Group | Grouped Button Controls | Syncfusion",
               HeaderText = "Blazor Button Group Component Example - Default Functionalities",
               MetaDescription = "This Blazor Button Group demo illustrates grouped button controls, featuring selection modes and customizable styling to facilitate related user interactions."
           },
            new Sample
           {
               Name = "Keyboard Navigation",
               Category = "Button",
               Directory = "Buttons/Button",
               Url = "buttons/keyboard-navigation",
               FileName = "KeyboardNavigation.razor",
               MetaTitle = "Blazor Button Keyboard Navigation | Accessibility | Syncfusion",
               HeaderText = "Blazor Button Example - Keyboard Navigation",
               MetaDescription = "This Blazor Button keyboard navigation example demonstrates accessibility features with keyboard shortcuts and focus management for enhanced usability."
           }
        };
        public List<Sample> Chips { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "chips/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Chips Default | Tag Component Features | Syncfusion",
                HeaderText = "Blazor Chips Example - Default Functionalities",
                MetaDescription = "This Blazor Chips default example demonstrates tag component with selection, deletion, and customizable styling for content categorization and filtering."
            },
            new Sample
            {
                Name = "API",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "chips/api",
                FileName = "API.razor",
                MetaTitle = "Blazor Chips API | Programmatic Control | Syncfusion",
                HeaderText = "Blazor Chips Example - API",
                MetaDescription = "This Blazor Chips API example demonstrates programmatic control with methods and properties for dynamic chip manipulation and optimizing state management."
            },
            new Sample
            {
                Name = "Events",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "chips/events",
                FileName = "Events.razor",
                MetaTitle = "Blazor Chips Events | Events Handling | Syncfusion",
                HeaderText = "Blazor Chips Example - Events",
                MetaDescription = "This Blazor Chips events example demonstrates event handling with click, delete, and selection events for interactive chip behavior and user feedback.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "chips/keyboard-interaction",
                FileName = "KeyboardInteraction.razor",
                MetaTitle = "Blazor Chips Keyboard | Accessibility Navigation | Syncfusion",
                HeaderText = "Blazor Chips Example - Keyboard Navigation",
                MetaDescription = "This Blazor Chips keyboard navigation example demonstrates accessibility features with keyboard shortcuts and focus management for enhanced chip interaction.",
                Type = SampleType.None
            }

        };
		public List<Sample> FAB { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Floating Action Button",
                Directory = "Buttons/FAB",
                Url = "fab/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor FAB Overview | Floating Action Button | Syncfusion",
                HeaderText = "Blazor Floating Action Button Example - Overview",
                MetaDescription = "This Blazor Floating Action Button overview demonstrates primary action button with material design styling and positioning for mobile-first interfaces.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Floating Action Button",
                Directory = "Buttons/FAB",
                Url = "fab/default-functionalities",
                MetaTitle = "Floating Action Button Default Example - Syncfusion Demos",
                HeaderText = "Blazor Floating Action Button Example - Default Functionalities",
                MetaDescription = "This Blazor Floating Action Button default example demonstrates basic FAB features with customizable icons, styling, and click events for primary actions.",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Position",
                Category = "Floating Action Button",
                Directory = "Buttons/FAB",
                Url = "fab/position",
                FileName = "Position.razor",
                MetaTitle = "Blazor FAB Position | Button Positioning Options | Syncfusion",
                HeaderText = "Blazor Floating Action Button Example - Position",
                MetaDescription = "This Blazor Floating Action Button position demo shows various positioning options including top, bottom, left, and right alignments for optimal placement.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Styles",
                Category = "Floating Action Button",
                Directory = "Buttons/FAB",
                Url = "fab/styles",
                FileName = "Styles.razor",
                MetaTitle = "Blazor FAB Styles | Custom Button Styling | Syncfusion",
                HeaderText = "Blazor Floating Action Button Example - Styles",
                MetaDescription = "This Blazor Floating Action Button styles example demonstrates custom styling options with colors, sizes, and visual effects for enhanced design integration.",
                Type = SampleType.None
            }
        };
		public List<Sample> SpeedDial { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "SpeedDial",
                Directory = "Buttons/SpeedDial",
                Url = "speeddial/defaultfunctionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor SpeedDial Default | Quick Action Menu | Syncfusion",
                HeaderText = "Blazor SpeedDial Example - Default Functionalities",
                MetaDescription = "This Blazor SpeedDial default example demonstrates quick action menu with an expandable buttons and customizable icons for efficient user interactions.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Position (Linear)",
                Category = "SpeedDial",
                Directory = "Buttons/SpeedDial",
                Url = "speeddial/position",
                FileName = "Position.razor",
                MetaTitle = "Blazor SpeedDial Position | Linear Layout Options | Syncfusion",
                HeaderText = "Blazor SpeedDial Example - Position (Linear)",
                MetaDescription = "This Blazor SpeedDial position example demonstrates the linear layout options with various positioning configurations for optimal action menu placement.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Radial Menu",
                Category = "SpeedDial",
                Directory = "Buttons/SpeedDial",
                Url = "speeddial/radialmenu",
                FileName = "RadialMenu.razor",
                MetaTitle = "Blazor SpeedDial Radial Menu | Circular Layout | Syncfusion",
                HeaderText = "Blazor SpeedDial Example - Radial Menu",
                MetaDescription = "This Blazor SpeedDial example showcases a radial menu layout featuring circular positioning. It provides intuitive, space-efficient access to action menus.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Styles",
                Category = "SpeedDial",
                Directory = "Buttons/SpeedDial",
                Url = "speeddial/styles",
                FileName = "Styles.razor",
                MetaTitle = "Blazor SpeedDial Styles | Custom Menu Styling | Syncfusion",
                HeaderText = "Blazor SpeedDial Example - Styles",
                MetaDescription = "This Blazor SpeedDial styles example demonstrates custom styling options with colors, dynamic animations, and visual effects for enhanced menu appearance.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Template",
                Category = "SpeedDial",
                Directory = "Buttons/SpeedDial",
                Url = "speeddial/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor SpeedDial Template | Custom Content Layout | Syncfusion",
                HeaderText = "Blazor SpeedDial Example - Template",
                MetaDescription = "This Blazor SpeedDial template demo shows custom content layout with personalized templates for flexible action menu design and branding with action menu.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Modal",
                Category = "SpeedDial",
                Directory = "Buttons/SpeedDial",
                Url = "speeddial/modal",
                FileName = "Modal.razor",
                MetaTitle = "Blazor SpeedDial Modal | Overlay Action Menu | Syncfusion",
                HeaderText = "Blazor SpeedDial Example - Modal",
                MetaDescription = "This Blazor SpeedDial modal example demonstrates an overlay action menu with featuring a backdrop and modal behavior for the focused user interactions.",
                Type = SampleType.None
            }
        };
    }
}