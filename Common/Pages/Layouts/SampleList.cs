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
		public List<Sample> ListView { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Checklist",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/checklist",
                FileName = "Checklist.razor"
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/remote-data",
                FileName = "RemoteData.razor"
            },
            new Sample
            {
                Name = "Nested List",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/nested-list",
                FileName = "NestedList.razor"
            },
            new Sample
            {
                Name = "Templates",
                Category = "Customization",
                Directory = "Layouts/ListView",
                Url = "listview/list-templates",
                FileName = "ListTemplates.razor"
            },
            new Sample
            {
                Name = "Group Template",
                Category = "Customization",
                Directory = "Layouts/ListView",
                Url = "listview/group-template",
                FileName = "ListGroupTemplate.razor",
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/virtualization",
                FileName = "Virtualization.razor"
            },
            new Sample
            {
                Name = "Call History",
                Category = "Use Case",
                Directory = "Layouts/ListView",
                Url = "listview/call-history",
                FileName = "CallHistory.razor"
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/keyboard-navigation",
                Type = SampleType.None,
                FileName = "KeyboardNavigation.razor"
            },
        };
         public List<Sample> DashboardLayout { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Type = SampleType.None,
                Url = "dashboard-layout/overview",
                FileName = "Overview.razor"
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Url = "dashboard-layout/default",
                FileName = "Default.razor"
            },
            new Sample
            {
                Name = "Predefined Layouts",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Type = SampleType.None,
                Url = "dashboard-layout/predefined-layouts",
                FileName = "PredefinedLayouts.razor"
            },
            new Sample
            {
                Name = "API",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Url = "dashboard-layout/api",
                FileName = "API.razor"
            }
        };
        public List<Sample> Splitter { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Splitter",
                Directory = "Layouts/Splitter",
                Url = "splitter/default-functionalities",
                FileName = "Default.razor"
            },
            new Sample
            {
                Name = "Expand and Collapse",
                Category = "Splitter",
                Directory = "Layouts/Splitter",
                Url = "splitter/expand-collapse",
                FileName = "ExpandandCollapse.razor"
            },
              new Sample
            {
                Name = "Accordion Navigation Menu",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "splitter/accordion-menu",
                FileName = "AccordionMenu.razor"
            },
             new Sample
            {
                Name = "Details View",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "splitter/details-view",
                FileName = "DetailsView.razor"
            },
            new Sample
            {
                Name = "Outlook-style Layout",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "splitter/outlook",
                FileName = "OutlookStyleLayout.razor"
            },
             new Sample
            {
                Name = "Code Editor Layout",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "splitter/code-editor-layout",
                FileName = "CodeEditorLayout.razor"
            }
        };
        public List<Sample> Avatar { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default",
                Category = "Avatar",
                Directory = "Layouts/Avatar",
                Url = "avatar/defaultfunctionalities",
                FileName = "Default.razor",
                HeaderText = "Example of Default Functionalities in Blazor CSS Avatar Component"
            },
            new Sample
            {
                Name = "Types",
                Category = "Avatar",
                Directory = "Layouts/Avatar",
                Url = "avatar/types",
                FileName = "Types.razor",
                HeaderText = "Example of Types in Blazor CSS Avatar Component"
            },
            new Sample
            {
                Name = "ListView",
                Category = "Integration",
                Directory = "Layouts/Avatar",
                Url = "avatar/listview",
                FileName = "ListView.razor",
                HeaderText = "Example of Blazor CSS Avatar Component in ListView"
            },
            new Sample
            {
                Name = "Badge",
                Category = "Integration",
                Directory = "Layouts/Avatar",
                Url = "avatar/badge",
                FileName = "Badge.razor",
                HeaderText = "Example of Blazor CSS Avatar Component with Badge"
            },
            new Sample
            {
                Name = "Card",
                Category = "Integration",
                Directory = "Layouts/Avatar",
                Url = "avatar/card",
                FileName = "Card.razor",
                HeaderText = "Example of Blazor CSS Avatar Component with Card"
            }
        };

        public List<Sample> Timeline { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Timeline",
                Directory = "Layouts/Timeline",
                Url = "timeline/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "API",
                Category = "Timeline",
                Directory = "Layouts/Timeline",
                Url = "timeline/api",
                FileName = "API.razor"
            },
            new Sample
            {
                Name = "Template",
                Category = "Timeline",
                Directory = "Layouts/Timeline",
                Url = "timeline/timeline-template",
                FileName = "Template.razor"
            }
        };
    }
}