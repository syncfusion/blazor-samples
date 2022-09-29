#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
                NotificationDescription = new string[] {
                    @"Added a demo to illustrate all the variants of the Skeleton component and its customization."
                },
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Animation",
                Category = "Skeleton",
                Directory = "Notifications/Skeleton",
                Url = "skeleton/animation",
                FileName = "Animation.razor",
                NotificationDescription = new string[] {
                    @"Added a demo for individual Skeletons with fade and pulse animation effects.",
                },
                Type = SampleType.None
            }
        };
    }
}