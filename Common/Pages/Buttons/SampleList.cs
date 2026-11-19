using System.Collections.Generic;
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
                MetaTitle = "Blazor Buttons - Default Functionalities | Buttons Demos | Syncfusion",
                HeaderText = "Blazor Button Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Default Functionalities provides customizable buttons with icon support and keyboard accessibility to improve UX with ARIA roles.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-button"
            },
           new Sample
            {
                Name = "Checkbox",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/checkbox",
                FileName = "CheckBox.razor",
                MetaTitle = "Blazor Buttons Examples - Checkbox | Buttons Demos | Syncfusion",
                HeaderText = "Blazor Checkbox Component Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Checkbox enables checked and indeterminate states with validation and keyboard navigation to build accessible forms easily."
            },
           new Sample
            {
                Name = "Radio Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/radio-button",
                FileName = "RadioButton.razor",
                MetaTitle = "Blazor Buttons Examples - Radio Button | Buttons Demos | Syncfusion",
                HeaderText = "Blazor Radio Button Component Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Radio Button enables exclusive selection with grouping, validation, and keyboard support to improve accessible form inputs."
            },
           new Sample
            {
                Name = "Dropdown Menu",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/dropdown-menu",
                FileName = "DropDownButton.razor",
                MetaTitle = "Blazor Buttons Examples - Dropdown Menu | Buttons Demos | Syncfusion",
                HeaderText = "Blazor Dropdown Menu Component Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Dropdown Menu offers item lists, icons, and event handling with keyboard navigation to help users select options easily."
            },
           new Sample
            {
                Name = "Split Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/split-button",
                FileName = "SplitButton.razor",
                MetaTitle = "Blazor Buttons Examples - Split Button | Buttons Demos | Syncfusion",
                HeaderText = "Blazor Split Button Component Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Split Button combines primary action and dropdown features with icon templates and callbacks to streamline workflows and tasks."
            },
           new Sample
            {
                Name = "Toggle Switch Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/toggle-switch-button",
                FileName = "Switch.razor",
                MetaTitle = "Blazor Buttons - Toggle Switch Button | Buttons Demos | Syncfusion",
                HeaderText = "Blazor Toggle Switch Button Component Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Toggle Switch Button provides on off control with animations, styling options, and accessibility support for clear UI actions."
            },
           new Sample
            {
                Name = "Progress Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/progress-button",
                FileName = "ProgressButton.razor",
                MetaTitle = "Blazor Buttons Demos - Progress Button Examples | Syncfusion",
                HeaderText = "Blazor Progress Button Component Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Progress Button shows loading states with progress indicators and animations to provide user feedback during async operations.",
                Type = SampleType.None
            },
           new Sample
           {
               Name = "Button Group",
               Category = "Button",
               Directory = "Buttons/Button",
               Url = "buttons/button-group",
               FileName = "ButtonGroup.razor",
               MetaTitle = "Blazor Buttons Examples - Button Group | Buttons Demos | Syncfusion",
               HeaderText = "Blazor Button Group Component Example - Default Functionalities",
               MetaDescription = "See how the Syncfusion Blazor Button Group arranges related buttons with selection modes and responsive styling with keyboard support for streamlined actions."
           },
            new Sample
           {
               Name = "Keyboard Navigation",
               Category = "Button",
               Directory = "Buttons/Button",
               Url = "buttons/keyboard-navigation",
               FileName = "KeyboardNavigation.razor",
               MetaTitle = "Blazor Buttons - Keyboard Navigation | Buttons Demos | Syncfusion",
               HeaderText = "Blazor Button Example - Keyboard Navigation",
               MetaDescription = "See how the Syncfusion Blazor Keyboard Navigation enables focus management and shortcut keys with ARIA support to improve accessibility and user interaction."
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
                MetaTitle = "Blazor Chips - Default Functionalities | Buttons Demos | Syncfusion",
                HeaderText = "Blazor Chips Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Default Functionalities provides chips with selection, deletion, customizable styling, and keyboard navigation to organize items.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-chips"
            },
            new Sample
            {
                Name = "API",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "chips/api",
                FileName = "API.razor",
                MetaTitle = "Blazor Chips Demos - API Examples | Buttons Demos | Syncfusion",
                HeaderText = "Blazor Chips Example - API",
                MetaDescription = "See how the Syncfusion Blazor API exposes chip methods for programmatic control, enabling dynamic creation, selection, and state management to simplify UI."
            },
            new Sample
            {
                Name = "Events",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "chips/events",
                FileName = "Events.razor",
                MetaTitle = "Blazor Chips Demos - Events Examples | Buttons Demos | Syncfusion",
                HeaderText = "Blazor Chips Example - Events",
                MetaDescription = "See how the Syncfusion Blazor Events exposes chip events with click, delete, and selection callbacks, enabling custom handlers to boost interactivity with ARIA.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "chips/keyboard-interaction",
                FileName = "KeyboardInteraction.razor",
                MetaTitle = "Blazor Chips - Keyboard Navigation | Buttons Demos | Syncfusion",
                HeaderText = "Blazor Chips Example - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor Keyboard Navigation enables focus control and shortcut keys for chips, with ARIA support and tab order to improve accessibility.",
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
                MetaTitle = "Blazor FAB Demos - Overview Examples | Buttons Demos | Syncfusion",
                HeaderText = "Blazor Floating Action Button Example - Overview",
                MetaDescription = "See how the Syncfusion Blazor FAB displays primary actions with icons and positioning features to improve touch access and enhance mobile usability today.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-fab"
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Floating Action Button",
                Directory = "Buttons/FAB",
                Url = "fab/default-functionalities",
                MetaTitle = "Blazor FAB - Default Functionalities | Buttons Demos | Syncfusion",
                HeaderText = "Blazor Floating Action Button Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor FAB provides customizable icons, position presets, and click events to display primary actions clearly in mobile interfaces.",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-fab"
            },
            new Sample
            {
                Name = "Position",
                Category = "Floating Action Button",
                Directory = "Buttons/FAB",
                Url = "fab/position",
                FileName = "Position.razor",
                MetaTitle = "Blazor FAB Demos - Position Examples | Buttons Demos | Syncfusion",
                HeaderText = "Blazor Floating Action Button Example - Position",
                MetaDescription = "See how the Syncfusion Blazor FAB supports placement options with alignment and offsets to control display position and improve action accessibility easily.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Styles",
                Category = "Floating Action Button",
                Directory = "Buttons/FAB",
                Url = "fab/styles",
                FileName = "Styles.razor",
                MetaTitle = "Blazor FAB Demos - Styles Examples | Buttons Demos | Syncfusion",
                HeaderText = "Blazor Floating Action Button Example - Styles",
                MetaDescription = "See how the Syncfusion Blazor FAB supports styling with colors, sizes, shape variants, and elevation options to match branding and improve visual hierarchy.",
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
                MetaTitle = "Blazor SpeedDial Examples - Default | Buttons Demos | Syncfusion",
                HeaderText = "Blazor SpeedDial Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Default Functionalities offers expandable quick-action menus with animated buttons, icons, and actions to speed workflows.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-speeddial"
            },
            new Sample
            {
                Name = "Position (Linear)",
                Category = "SpeedDial",
                Directory = "Buttons/SpeedDial",
                Url = "speeddial/position",
                FileName = "Position.razor",
                MetaTitle = "Blazor SpeedDial Examples - Position | Buttons Demos | Syncfusion",
                HeaderText = "Blazor SpeedDial Example - Position (Linear)",
                MetaDescription = "See how the Syncfusion Blazor SpeedDial supports linear positioning with alignment options, spacing, and layouts to provide quick and flexible access.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Radial Menu",
                Category = "SpeedDial",
                Directory = "Buttons/SpeedDial",
                Url = "speeddial/radialmenu",
                FileName = "RadialMenu.razor",
                MetaTitle = "Blazor SpeedDial Examples - Radial Menu | Buttons Demos | Syncfusion",
                HeaderText = "Blazor SpeedDial Example - Radial Menu",
                MetaDescription = "See how the Syncfusion Blazor Radial Menu shows circular SpeedDial layouts with radial positioning, animated opening, and icons for compact discoverability.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Styles",
                Category = "SpeedDial",
                Directory = "Buttons/SpeedDial",
                Url = "speeddial/styles",
                FileName = "Styles.razor",
                MetaTitle = "Blazor SpeedDial Examples - Styles | Buttons Demos | Syncfusion",
                HeaderText = "Blazor SpeedDial Example - Styles",
                MetaDescription = "See how the Syncfusion Blazor SpeedDial supports styling with themes, icon sizing, and animation options to match branding and improve interface consistency.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Template",
                Category = "SpeedDial",
                Directory = "Buttons/SpeedDial",
                Url = "speeddial/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor SpeedDial Examples - Template | Buttons Demos | Syncfusion",
                HeaderText = "Blazor SpeedDial Example - Template",
                MetaDescription = "See how the Syncfusion Blazor Template enables custom SpeedDial templates with content slots, icon slots, and event bindings to create tailored action menus.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Modal",
                Category = "SpeedDial",
                Directory = "Buttons/SpeedDial",
                Url = "speeddial/modal",
                FileName = "Modal.razor",
                MetaTitle = "Blazor SpeedDial Examples - Modal | Buttons Demos | Syncfusion",
                HeaderText = "Blazor SpeedDial Example - Modal",
                MetaDescription = "See how the Syncfusion Blazor Modal handles SpeedDial inside overlays with backdrop control, focus trapping, and disabled scrolling to preserve modal UX.",
                Type = SampleType.None
            }
        };
    }
}