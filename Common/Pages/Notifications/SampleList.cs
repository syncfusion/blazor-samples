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
        public List<Sample> Toast { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Types",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/types",
                FileName = "Types.razor"
            },
            new Sample
            {
                Name = "Template",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/template",
                FileName = "Template.razor"
            },
            new Sample
            {
                Name = "Position",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/position",
                FileName = "Position.razor"
            },
            new Sample
            {
                Name = "API",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/api",
                FileName = "API.razor"
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
                FileName = "Overview.razor"
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
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Variants",
                Category = "Message",
                Directory = "Notifications/Message",
                Url = "message/variants",
                FileName = "Variants.razor"
            },
            new Sample
            {
                Name = "Icons",
                Category = "Message",
                Directory = "Notifications/Message",
                Url = "message/icons",
                FileName = "Icons.razor"
            },
            new Sample
            {
                Name = "Customization",
                Category = "Message",
                Directory = "Notifications/Message",
                Url = "message/Customization",
                FileName = "Customization.razor"
            },
            new Sample
            {
                Name = "Template",
                Category = "Message",
                Directory = "Notifications/Message",
                Url = "message/Template",
                FileName = "Template.razor"
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
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Animation",
                Category = "Skeleton",
                Directory = "Notifications/Skeleton",
                Url = "skeleton/animation",
                FileName = "Animation.razor",
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
                HeaderText = "Example of Default Functionalities in Blazor CSS Badge Component"
            },
            new Sample
            {
                Name = "Types",
                Category = "Badge",
                Directory = "Notifications/Badge",
                Url = "badge/types",
                FileName = "Types.razor",
                HeaderText = "Example of Types in Blazor CSS Badge Component"
            },
            new Sample
            {
                Name = "Notification",
                Category = "Badge",
                Directory = "Notifications/Badge",
                Url = "badge/notification",
                FileName = "Notification.razor",
                HeaderText = "Example of Blazor CSS Badge Component as Notification"
            },
            new Sample
            {
                Name = "ListView",
                Category = "Integration",
                Directory = "Notifications/Badge",
                Url = "badge/listview",
                FileName = "ListView.razor",
                HeaderText = "Example of Blazor CSS Badge Component in ListView"
            },
            new Sample
            {
                Name = "Accordion",
                Category = "Integration",
                Directory = "Notifications/Badge",
                Url = "badge/accordion",
                FileName = "Accordion.razor",
                HeaderText = "Example of Blazor CSS Badge Component in Accordion"
            },
            new Sample
            {
                Name = "Toolbar",
                Category = "Integration",
                Directory = "Notifications/Badge",
                Url = "badge/toolbar",
                FileName = "Toolbar.razor",
                HeaderText = "Example of Blazor CSS Badge Component in Toolbar"
            }
        };
    }
}