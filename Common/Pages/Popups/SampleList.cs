using System.Collections.Generic;
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
                MetaTitle = "Blazor Dialog - Default Functionalities | Popups Demos | Syncfusion",
                HeaderText = "Blazor Dialog Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Dialog creates modal windows with headers, buttons, and templates to capture input and display messages with clarity and ease.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-modal-dialog"
            },
            new Sample
            {
                Name = "Modal",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/modal",
                FileName = "Modal.razor",
                MetaTitle = "Blazor Dialog Demos - Modal Examples | Popups Demos | Syncfusion",
                HeaderText = "Blazor Dialog Example - Modal Dialog",
                MetaDescription = "See how the Syncfusion Blazor Dialog Modal provides overlay behavior with focus control to enforce interaction and prevent actions outside the dialog."
            },
            new Sample
            {
                Name = "Template",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor Dialog Examples - Template | Popups Demos | Syncfusion",
                HeaderText = "Blazor Dialog Example - Content Templates",
                MetaDescription = "See how the Syncfusion Blazor Dialog Template customizes dialog content using HTML layouts and media elements to build rich and interactive user interfaces."
            },
            new Sample
            {
                Name = "Draggable",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/draggable",
                FileName = "Draggable.razor",
                MetaTitle = "Blazor Dialog Examples - Draggable | Popups Demos | Syncfusion",
                HeaderText = "Blazor Dialog Example - Draggable Functionality",
                MetaDescription = "See how the Syncfusion Blazor Dialog enables dragging with controls and boundary limits to reposition windows easily and improve usability in applications."
            },
            new Sample
            {
                Name = "Resizable",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/resizable",
                FileName = "Resizable.razor",
                MetaTitle = "Blazor Dialog Examples - Resizable | Popups Demos | Syncfusion",
                HeaderText = "Blazor Dialog Example - Resizable Functionality",
                MetaDescription = "See how the Syncfusion Blazor Dialog Resizable supports resizing with handles and constraints to adjust dialog size dynamically and improve layout flexibility."
            },
            new Sample
            {
                Name = "Positioning",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/positioning",
                FileName = "Positioning.razor",
                MetaTitle = "Blazor Dialog Examples - Positioning | Popups Demos | Syncfusion",
                HeaderText = "Blazor Dialog Example - Custom Positioning",
                MetaDescription = "See how the Syncfusion Blazor Dialog Positioning uses alignment options and offsets to control placement and enhance overall user interface experience."
            },
             new Sample
            {
                Name = "Animation",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/animation",
                FileName = "Animation.razor",
                MetaTitle = "Blazor Dialog Examples - Animation | Popups Demos | Syncfusion",
                HeaderText = "Blazor Dialog Example - Animation Effects",
                MetaDescription = "See how the Syncfusion Blazor Dialog Animation applies effects like fade, zoom, and slide with timing control to create smooth and engaging interactions."
            },
            new Sample
            {
                Name = "Multiple Dialogs",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/multiple-dialogs",
                FileName = "MultipleDialogs.razor",
                MetaTitle = "Blazor Dialog Examples - Multiple Dialogs | Popups Demos | Syncfusion",
                HeaderText = "Blazor Dialog Example - Multiple Dialog Management",
                MetaDescription = "See how the Syncfusion Blazor Dialog manages multiple dialogs with stacking, focus control, and z index handling for smooth and complex user interactions."
            },
            // Ignore: From Build
             new Sample
            {
                Name = "Components inside Dialog",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/components-inside-dialog",
                FileName = "ComponentsInsideDialog.razor",
                MetaTitle = "Blazor Dialog - Components inside Dialog | Popups Demos | Syncfusion",
                HeaderText = "Blazor Dialog Example - Components Inside Dialog",
                MetaDescription = "See how the Syncfusion Blazor Dialog integrates grids, forms, and charts within dialogs to build rich and interactive user interface experiences easily"
            }
            // End: Ignore
        };
        public List<Sample> PredefinedDialogs { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Predefined Dialogs",
                Directory = "Popups/PredefinedDialogs",
                Url = "predefined-dialogs/default-functionalities",
                MetaTitle = "Blazor Predefined Dialogs - Default | Popups Demos | Syncfusion",
                FileName = "DefaultFunctionalities.razor",
                HeaderText = "Blazor Predefined Dialogs Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Predefined Dialogs provide alert, confirm, and prompt dialogs with built in actions for quick and consistent user interaction.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-modal-dialog"
            },
             new Sample
            {
                Name = "Customization",
                Category = "Predefined Dialogs",
                Directory = "Popups/PredefinedDialogs",
                Url = "predefined-dialogs/customization",
                FileName = "Customization.razor",
                MetaTitle = "Blazor Predefined Dialogs - Customization | Popups Demos | Syncfusion",
                HeaderText = "Blazor Predefined Dialogs Example - Customization Options",
                MetaDescription = "See how the Syncfusion Blazor Predefined Dialogs support customization with themes, layouts, and animations to match branding and enhance user experience."
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
                MetaTitle = "Blazor Tooltip - Default Functionalities | Popups Demos | Syncfusion",
                HeaderText = "Blazor Tooltip Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Default Functionalities displays tooltips on hover or focus with positioning and delay settings to show contextual information.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-tooltip"
            },
            new Sample
            {
                Name = "HTML Template",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/html-template",
                FileName = "HtmlTemplate.razor",
                MetaTitle = "Blazor Tooltip Examples - HTML Template | Popups Demos | Syncfusion",
                HeaderText = "Blazor Tooltip Example - HTML Templates",
                MetaDescription = "See how the Syncfusion Blazor Tooltip uses HTML templates with images and formatted text to display rich and interactive content within tooltips easily."
            },
            new Sample
            {
                Name = "Template",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor Tooltip Demos - Template Examples | Popups Demos | Syncfusion",
                HeaderText = "Blazor Tooltip Example - Custom Templates",
                MetaDescription = "See how the Syncfusion Blazor Template customizes tooltip layouts with advanced styling and structure to improve visual presentation and user experience.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Tooltip Menu",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/menu",
                FileName = "Menu.razor",
                MetaTitle = "Blazor Tooltip Examples - Tooltip Menu | Popups Demos | Syncfusion",
                HeaderText = "Blazor Tooltip Example - Tooltip Menu",
                MetaDescription = "See how the Syncfusion Blazor Tooltip creates interactive menus with clickable actions to enable compact navigation and efficient user controls within tooltips.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "API",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/api",
                FileName = "Api.razor",
                MetaTitle = "Blazor Tooltip Demos - API Examples | Popups Demos | Syncfusion",
                HeaderText = "Blazor Tooltip Example - API Functionalities",
                MetaDescription = "See how the Syncfusion Blazor API manages tooltip behavior using programmatic controls for show, hide, and positioning to support dynamic UI interactions."
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/keyboard-navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor Tooltip - Keyboard Navigation | Popups Demos | Syncfusion",
                HeaderText = "Blazor Tooltip Example - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor Tooltip enables keyboard navigation with shortcuts and focus control to improve accessibility and enhance usability easily.",
                Type = SampleType.None
            }
        };   
    }
}