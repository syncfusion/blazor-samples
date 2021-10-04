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
                Type = SampleType.New,
                FileName = "KeyboardNavigation.razor",
                NotificationDescription = new string[]
                {
                    @"Added a demo for keyboard accessibility of the ListView component."
                }
            },
        };
         public List<Sample> DashboardLayout { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Type = SampleType.New,
                Url = "dashboard-layout/overview",
                FileName = "Overview.razor",
                NotificationDescription = new string[]
                {
                    @"Added a overview sample to demonstrate most features of the DashboardLayout component."
                }
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
                Type = SampleType.New,
                Url = "dashboard-layout/predefined-layouts",
                FileName = "PredefinedLayouts.razor",
                NotificationDescription = new string[]
                {
                    @"Added a demo to demonstrates how to handle dynamic update on the DashboardLayout panels."
                }
            },
            new Sample
            {
                Name = "API",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Url = "dashboard-layout/api",
                FileName = "API.razor"
            },
            new Sample
            {
                Name = "SEO Dashboard",
                Category = "Use Case",
                Directory = "Layouts/DashboardLayout",
                Url = "dashboard-layout/seo",
                Type = SampleType.New,
                FileName = "SEODashboard.razor",
                NotificationDescription = new string[]
                {
                    @"Added a demo to showcase the SEO analytics using the DashboardLayout component."
                }
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
    }
}