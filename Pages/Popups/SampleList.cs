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
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Custom Dialogs",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/custom-dialogs",
                FileName = "CustomDialogs.razor"
            },
            new Sample
            {
                Name = "Modal",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/modal",
                FileName = "Modal.razor"
            },
            new Sample
            {
                Name = "Template",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/template",
                FileName = "Template.razor"
            },
            new Sample
            {
                Name = "Draggable",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/draggable",
                FileName = "Draggable.razor"
            },
            new Sample
            {
                Name = "Resizable",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/resizable",
                FileName = "Resizable.razor"
            },
            new Sample
            {
                Name = "Positioning",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/positioning",
                FileName = "Positioning.razor"
            },
             new Sample
            {
                Name = "Animation",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/animation",
                FileName = "Animation.razor"
            },
            new Sample
            {
                Name = "Multiple Dialogs",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/multiple-dialogs",
                FileName = "MultipleDialogs.razor"
            },
             new Sample
            {
                Name = "Components inside Dialog",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "dialog/components-inside-dialog",
                FileName = "ComponentsInsideDialog.razor"
            }
        };
        public List<Sample> Tooltip { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/default",
                FileName = "Default.razor"
            },
            new Sample
            {
                Name = "HTML Template",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/html-template",
                FileName = "HtmlTemplate.razor"
            },
            new Sample
            {
                Name = "Template",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/template",
                FileName = "Template.razor",
                Type = SampleType.New,
                NotificationDescription = new string[]
                {
                    @"Added a demo to demonstrate template functionalities of the Tooltip component."
                }
            },
            new Sample
            {
                Name = "Tooltip Menu",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/menu",
                FileName = "Menu.razor",
                Type = SampleType.New,
                NotificationDescription = new string[]
                {
                    @"Added a demo to demonstrate customization of the Tooltip component."
                }
            },
            new Sample
            {
                Name = "API",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/api",
                FileName = "Api.razor"
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/keyboard-navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.New,
                NotificationDescription = new string[]
                {
                    @"Added a demo to showcase keyboard accessibility of the Tooltip component."
                }
            }
        };   
    }
}
