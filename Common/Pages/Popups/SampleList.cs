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
        public List<Sample> PredefinedDialogs { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Predefined Dialogs",
                Directory = "Popups/PredefinedDialogs",
                Url = "predefined-dialogs/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
             new Sample
            {
                Name = "Customization",
                Category = "Predefined Dialogs",
                Directory = "Popups/PredefinedDialogs",
                Url = "predefined-dialogs/customization",
                FileName = "Customization.razor"
            }

        };
        public List<Sample> Tooltip { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
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
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Tooltip Menu",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "tooltip/menu",
                FileName = "Menu.razor",
                Type = SampleType.None
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
                Type = SampleType.None
            }
        };   
    }
}
