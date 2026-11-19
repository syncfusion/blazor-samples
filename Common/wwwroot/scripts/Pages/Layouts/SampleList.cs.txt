using System.Collections.Generic;
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
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor ListView Demos - Default Functionalities Examples | Syncfusion",
                HeaderText = "Blazor ListView Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor ListView binds data, handles selection, and renders customizable list items for efficient and responsive data presentation.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-listview"
            },
            new Sample
            {
                Name = "Checklist",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/checklist",
                FileName = "Checklist.razor",
                MetaTitle = "Blazor ListView Examples - Checklist | Layouts Demos | Syncfusion",
                HeaderText = "Blazor ListView Example - Checkbox Selection",
                MetaDescription = "See how the Syncfusion Blazor ListView implements multiple item selection with checkboxes for bulk operations like select, deselect, and manage items."
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/remote-data",
                FileName = "RemoteData.razor",
                MetaTitle = "Blazor ListView Examples - Remote Data | Layouts Demos | Syncfusion",
                HeaderText = "Blazor ListView Example - Remote Data Binding",
                MetaDescription = "See how the Syncfusion Blazor ListView connects to remote RESTful services to fetch and display dynamic data in a ListView component with seamless integration"
            },
            new Sample
            {
                Name = "Nested List",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/nested-list",
                FileName = "NestedList.razor",
                MetaTitle = "Blazor ListView Examples - Nested List | Layouts Demos | Syncfusion",
                HeaderText = "Blazor ListView Example - Nested Lists",
                MetaDescription = "See how the Syncfusion Blazor ListView renders hierarchical data with nested lists to display parent-child relationships and multi-level structures in apps"
            },
            new Sample
            {
                Name = "Templates",
                Category = "Customization",
                Directory = "Layouts/ListView",
                Url = "listview/list-templates",
                FileName = "ListTemplates.razor",
                MetaTitle = "Blazor ListView Examples - Templates | Layouts Demos | Syncfusion",
                HeaderText = "Blazor ListView Example - Custom Templates",
                MetaDescription = "See how the Syncfusion Blazor ListView customizes item rendering with templates to create visually appealing lists with personalized layouts for each data item",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "ListTemplates",
                        FileName = "ListTemplates.razor"
                    },
                    new SourceCollection
                    {
                        Id = "ListViewDataSource",
                        FileName = "ListViewDataSource.cs"
                    },
                },
            },
            new Sample
            {
                Name = "Group Template",
                Category = "Customization",
                Directory = "Layouts/ListView",
                Url = "listview/group-template",
                FileName = "ListGroupTemplate.razor",
                MetaTitle = "Blazor ListView Demos - Group Template Examples | Syncfusion",
                HeaderText = "Blazor ListView Example - Group Templates",
                MetaDescription = "See how the Syncfusion Blazor ListView organizes items into categorized groups with custom headers to separate and visually group data into logical sections"
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/virtualization",
                FileName = "Virtualization.razor",
                MetaTitle = "Blazor ListView Demos - Virtualization Examples | Syncfusion",
                HeaderText = "Blazor ListView Example - UI Virtualization",
                MetaDescription = "See how the Syncfusion Blazor ListView loads large datasets with virtualization by rendering only visible items for optimal performance and smooth scrolling"
            },
            new Sample
            {
                Name = "Call History",
                Category = "Use Case",
                Directory = "Layouts/ListView",
                Url = "listview/call-history",
                FileName = "CallHistory.razor",
                MetaTitle = "Blazor ListView Examples - Call History | Layouts Demos | Syncfusion",
                HeaderText = "Blazor ListView Example - Call History Application",
                MetaDescription = "See how the Syncfusion Blazor ListView displays call logs with date, time, and contact details in a mobile like interface for managing contact history.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "CallHistory",
                        FileName = "CallHistory.razor"
                    },
                    new SourceCollection
                    {
                        Id = "ListViewDataSource",
                        FileName = "ListViewDataSource.cs"
                    },
                },
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/keyboard-navigation",
                Type = SampleType.None,
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor ListView - Keyboard Navigation | Layouts Demos | Syncfusion",
                HeaderText = "Blazor ListView Example - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor ListView supports keyboard navigation to move, select, and interact with list items using shortcuts for improved accessibility."
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
                FileName = "Overview.razor",
                MetaTitle = "Blazor Dashboard Layout - Overview | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Dashboard Layout Example - Overview",
                MetaDescription = "See how the Syncfusion Blazor Dashboard Layout creates flexible panel-based layouts for arranging, resizing, and organizing content in a responsive grid system",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-dashboard"
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Url = "dashboard-layout/default",
                MetaTitle = "Blazor Dashboard Layout - Default | Layouts Demos | Syncfusion",
                FileName = "Default.razor",
                HeaderText = "Blazor Dashboard Layout Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Dashboard Layout implements panels with drag-and-drop, resizing, and responsive behavior for creating interactive dashboards",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-dashboard"
            },
            new Sample
            {
                Name = "Predefined Layouts",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Type = SampleType.None,
                Url = "dashboard-layout/predefined-layouts",
                FileName = "PredefinedLayouts.razor",
                MetaTitle = "Blazor Dashboard Layout - Predefined Layouts Examples | Syncfusion",
                HeaderText = "Blazor Dashboard Layout Example - Predefined Templates",
                MetaDescription = "See how the Syncfusion Blazor Dashboard Layout applies ready to use templates to customize panel arrangements for common dashboard scenarios efficiently."
            },
            new Sample
            {
                Name = "API",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Url = "dashboard-layout/api",
                FileName = "API.razor",
                MetaTitle = "Blazor Dashboard Layout Examples - API | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Dashboard Layout Example - API Usage",
                MetaDescription = "See how the Syncfusion Blazor Dashboard Layout controls panels programmatically to add, remove, resize, and rearrange panels using code-based operations."
            },
            new Sample
            {
                Name = "Editable Dashboard",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Url = "dashboard-layout/editable-dashboard-layout",
                FileName = "EditableDashboardLayout.razor",
                MetaTitle = "Blazor Dashboard Layout - Editable Dashboard Examples | Syncfusion",
                HeaderText = "Blazor Dashboard Layout Example - Editable Dashboard",
                MetaDescription = "See how the Syncfusion Blazor Dashboard Layout provides a customizable interface with dynamic panel management to add and configure panels at runtime.",
            },
        };
        public List<Sample> Splitter { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Splitter",
                Directory = "Layouts/Splitter",
                Url = "splitter/default-functionalities",
                FileName = "Default.razor",
                MetaTitle = "Blazor Splitter Examples - Default | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Splitter Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Splitter divides screen space efficiently with resizable and collapsible panes using horizontal and vertical layouts easily.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-splitter"
            },
            new Sample
            {
                Name = "Expand and Collapse",
                Category = "Splitter",
                Directory = "Layouts/Splitter",
                Url = "splitter/expand-collapse",
                FileName = "ExpandandCollapse.razor",
                MetaTitle = "Blazor Splitter - Expand and Collapse | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Splitter Example - Expand and Collapse Panes",
                MetaDescription = "See how the Syncfusion Blazor Splitter toggles panel visibility using expand and collapse controls to maximize working space for important content easily."
            },
              new Sample
            {
                Name = "Accordion Navigation Menu",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "splitter/accordion-menu",
                FileName = "AccordionMenu.razor",
                MetaTitle = "Blazor Splitter - Accordion Navigation Menu Examples | Syncfusion",
                HeaderText = "Blazor Splitter Example - Accordion Navigation Menu",
                MetaDescription = "See how the Syncfusion Blazor Splitter integrates with Accordion to create a collapsible navigation menu with nested panels for modern application layouts."
            },
             new Sample
            {
                Name = "Details View",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "splitter/details-view",
                FileName = "DetailsView.razor",
                MetaTitle = "Blazor Splitter Examples - Details View | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Splitter Example - Details View Layout",
                MetaDescription = "See how the Syncfusion Blazor Splitter creates a master detail layout to browse lists and view information simultaneously for efficient data exploration."
            },
            // Ignore: From Build
            new Sample
            {
                Name = "Outlook-style Layout",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "splitter/outlook",
                FileName = "OutlookStyleLayout.razor",
                MetaTitle = "Blazor Splitter - Outlook-style Layout | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Splitter Example - Outlook-style Email Layout",
                MetaDescription = "See how the Syncfusion Blazor Splitter builds an Outlook style three panel interface with folders, message list, and reading pane using nested layouts."
            },
            // End: Ignore
             new Sample
            {
                Name = "Code Editor Layout",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "splitter/code-editor-layout",
                FileName = "CodeEditorLayout.razor",
                MetaTitle = "Blazor Splitter - Code Editor Layout | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Splitter Example - Code Editor Layout",
                MetaDescription = "See how the Syncfusion Blazor Splitter creates a code editor layout with file explorer, editor, and preview panes using nested panels for development."
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
                HeaderText = "Example of Default Functionalities in Blazor CSS Avatar Component",
                MetaTitle = "Blazor Avatar Examples - Default | Layouts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Avatar displays user profile images or initials with various sizes, types, and customization options for modern app interfaces",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-avatar"
            },
            new Sample
            {
                Name = "Types",
                Category = "Avatar",
                Directory = "Layouts/Avatar",
                Url = "avatar/types",
                FileName = "Types.razor",
                HeaderText = "Example of Types in Blazor CSS Avatar Component",
                MetaTitle = "Blazor Avatar Demos - Types Examples | Layouts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Avatar renders circle, square, and custom shaped avatars to display profile pictures, initials, or icons with flexible styling."
            },
            new Sample
            {
                Name = "ListView",
                Category = "Integration",
                Directory = "Layouts/Avatar",
                Url = "avatar/listview",
                FileName = "ListView.razor",
                HeaderText = "Example of Blazor CSS Avatar Component in ListView",
                MetaTitle = "Blazor Avatar Examples - ListView | Layouts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Avatar integrates within ListView items to create contact lists, user directories, and message threads with profile images"
            },
            new Sample
            {
                Name = "Badge",
                Category = "Integration",
                Directory = "Layouts/Avatar",
                Url = "avatar/badge",
                FileName = "Badge.razor",
                HeaderText = "Example of Blazor CSS Avatar Component with Badge",
                MetaTitle = "Blazor Avatar Demos - Badge Examples | Layouts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Avatar adds notification counts and online status indicators using badge integration for enhanced user profile communication"
            },
            new Sample
            {
                Name = "Card",
                Category = "Integration",
                Directory = "Layouts/Avatar",
                Url = "avatar/card",
                FileName = "Card.razor",
                HeaderText = "Example of Blazor CSS Avatar Component with Card",
                MetaTitle = "Blazor Avatar Demos - Card Examples | Layouts Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Avatar integrates with Card components to create profile cards, team listings, and contact displays with rich user information."
            }
        };

        public List<Sample> Timeline { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Timeline",
                Directory = "Layouts/Timeline",
                Url = "timeline/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Timeline Examples - Default | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Timeline Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Timeline visualizes chronological events with timestamps, content, and connecting lines for clear and structured event sequencing.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-timeline"
            },
            new Sample
            {
                Name = "API",
                Category = "Timeline",
                Directory = "Layouts/Timeline",
                Url = "timeline/api",
                FileName = "API.razor",
                MetaTitle = "Blazor Timeline Demos - API Examples | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Timeline Example - API Configuration",
                MetaDescription = "See how the Syncfusion Blazor Timeline controls orientation, item alignment, and dot customization through its API to support dynamic timeline layouts."
            },
            new Sample
            {
                Name = "Template",
                Category = "Timeline",
                Directory = "Layouts/Timeline",
                Url = "timeline/timeline-template",
                FileName = "Template.razor",
                MetaTitle = "Blazor Timeline Examples - Template | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Timeline Example - Custom Templates",
                MetaDescription = "See how the Syncfusion Blazor Timeline customizes item content with HTML, images, and interactive elements using templates to create visually engaging timeline."
            }
        };
    }
}
