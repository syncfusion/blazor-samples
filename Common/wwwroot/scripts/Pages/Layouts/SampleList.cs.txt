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
		public List<Sample> ListView { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor ListView Component | Default Functionalities | Syncfusion",
                HeaderText = "Blazor ListView Example - Default Functionalities",
                MetaDescription = "This Blazor ListView example demonstrates the default functionalities including data binding, selection, and rendering customizable list items for efficient data presentation."
            },
            new Sample
            {
                Name = "Checklist",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/checklist",
                FileName = "Checklist.razor",
                MetaTitle = "Blazor ListView with Checkbox | Checklist Example | Syncfusion",
                HeaderText = "Blazor ListView Example - Checkbox Selection",
                MetaDescription = "This Blazor ListView checklist example demonstrates multiple item selection with checkboxes, allowing users to select, deselect, and manage multiple items simultaneously."
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/remote-data",
                FileName = "RemoteData.razor",
                MetaTitle = "Blazor ListView with Remote Data | Data Binding | Syncfusion",
                HeaderText = "Blazor ListView Example - Remote Data Binding",
                MetaDescription = "This Blazor ListView example demonstrates binding to remote data sources using RESTful services. Learn how to fetch and display dynamic data in a ListView component."
            },
            new Sample
            {
                Name = "Nested List",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/nested-list",
                FileName = "NestedList.razor",
                MetaTitle = "Blazor Nested ListView | Hierarchical Data Display | Syncfusion",
                HeaderText = "Blazor ListView Example - Nested Lists",
                MetaDescription = "This Blazor ListView example demonstrates hierarchical data visualization with nested lists. Create multi-level lists to display parent-child relationships in your data."
            },
            new Sample
            {
                Name = "Templates",
                Category = "Customization",
                Directory = "Layouts/ListView",
                Url = "listview/list-templates",
                FileName = "ListTemplates.razor",
                MetaTitle = "Blazor ListView Templates | Custom Item Rendering | Syncfusion",
                HeaderText = "Blazor ListView Example - Custom Templates",
                MetaDescription = "This Blazor ListView template example demonstrates custom item rendering with templates. Create visually appealing lists with personalized layouts for each item."
            },
            new Sample
            {
                Name = "Group Template",
                Category = "Customization",
                Directory = "Layouts/ListView",
                Url = "listview/group-template",
                FileName = "ListGroupTemplate.razor",
                MetaTitle = "Blazor ListView Group Template | Categorized Lists | Syncfusion",
                HeaderText = "Blazor ListView Example - Group Templates",
                MetaDescription = "This Blazor ListView group template example demonstrates categorized list items with custom group headers. Organize and visually separate data into logical sections."
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/virtualization",
                FileName = "Virtualization.razor",
                MetaTitle = "Blazor ListView Virtualization | Performance Optimization | Syncfusion",
                HeaderText = "Blazor ListView Example - UI Virtualization",
                MetaDescription = "This Blazor ListView virtualization example demonstrates loading large datasets with optimal performance. Only visible items are rendered, improving rendering performance with large data."
            },
            new Sample
            {
                Name = "Call History",
                Category = "Use Case",
                Directory = "Layouts/ListView",
                Url = "listview/call-history",
                FileName = "CallHistory.razor",
                MetaTitle = "Blazor ListView Call History | Real-World Application | Syncfusion",
                HeaderText = "Blazor ListView Example - Call History Application",
                MetaDescription = "This Blazor ListView example demonstrates a practical call history application. Display call logs with date, time, and contact details in a mobile-like interface."
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/keyboard-navigation",
                Type = SampleType.None,
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor ListView Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor ListView Example - Keyboard Navigation",
                MetaDescription = "This Blazor ListView keyboard navigation example demonstrates accessibility features for keyboard users. Navigate and interact with list items using keyboard shortcuts."
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
                MetaTitle = "Blazor Dashboard Layout Component | Overview | Syncfusion",
                HeaderText = "Blazor Dashboard Layout Example - Overview",
                MetaDescription = "This Blazor Dashboard Layout overview demonstrates the flexible panel-based layout system for creating dashboards. Arrange, resize, and organize content in a responsive grid."
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Url = "dashboard-layout/default",
                MetaTitle = "Dashboard Layout Default Functionalities - Syncfusion Demos",
                FileName = "Default.razor",
                HeaderText = "Blazor Dashboard Layout Example - Default Functionalities",
                MetaDescription = "This Blazor Dashboard Layout example demonstrates the core features including panels, drag and drop functionality, resizing, and responsive behavior for creating interactive dashboards."
            },
            new Sample
            {
                Name = "Predefined Layouts",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Type = SampleType.None,
                Url = "dashboard-layout/predefined-layouts",
                FileName = "PredefinedLayouts.razor",
                MetaTitle = "Blazor Dashboard Layout Templates | Predefined Layouts | Syncfusion",
                HeaderText = "Blazor Dashboard Layout Example - Predefined Templates",
                MetaDescription = "This Blazor Dashboard Layout example demonstrates ready-to-use layout templates. Apply and customize predefined panel arrangements for common dashboard scenarios."
            },
            new Sample
            {
                Name = "API",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Url = "dashboard-layout/api",
                FileName = "API.razor",
                MetaTitle = "Blazor Dashboard Layout API | Programmatic Control | Syncfusion",
                HeaderText = "Blazor Dashboard Layout Example - API Usage",
                MetaDescription = "This Blazor Dashboard Layout API example demonstrates programmatic control over panels. Add, remove, resize, and rearrange panels with code-based operations and event handling."
            },
            new Sample
            {
                Name = "Editable Dashboard",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Url = "dashboard-layout/editable-dashboard-layout",
                FileName = "EditableDashboardLayout.razor",
                MetaTitle = "Blazor Editable Dashboard Layout | Dynamic Panels | Syncfusion",
                HeaderText = "Blazor Dashboard Layout Example - Editable Dashboard",
                MetaDescription = "This Blazor Dashboard Layout example demonstrates a fully customizable interface with dynamic panel management. Add and configure new panels with predefined content at runtime.",
		        NotificationDescription = new string[]{ "This demo showcases the editable Dashboard Layout which allows you to dynamically add panels with Blazor components rendered as predefined panel content." }
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
                MetaTitle = "Blazor Splitter Component | Default Functionalities | Syncfusion",
                HeaderText = "Blazor Splitter Example - Default Functionalities",
                MetaDescription = "This Blazor Splitter example demonstrates responsive pane management with resizable and collapsible panels. Divide screen space efficiently with horizontal and vertical splitters."
            },
            new Sample
            {
                Name = "Expand and Collapse",
                Category = "Splitter",
                Directory = "Layouts/Splitter",
                Url = "splitter/expand-collapse",
                FileName = "ExpandandCollapse.razor",
                MetaTitle = "Blazor Splitter Expand Collapse | Collapsible Panes | Syncfusion",
                HeaderText = "Blazor Splitter Example - Expand and Collapse Panes",
                MetaDescription = "This Blazor Splitter example demonstrates expandable and collapsible panes. Toggle panel visibility with expand/collapse buttons to maximize working space for important content."
            },
              new Sample
            {
                Name = "Accordion Navigation Menu",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "splitter/accordion-menu",
                FileName = "AccordionMenu.razor",
                MetaTitle = "Blazor Splitter Navigation Menu | Accordion Layout | Syncfusion",
                HeaderText = "Blazor Splitter Example - Accordion Navigation Menu",
                MetaDescription = "This Blazor Splitter example demonstrates creating an accordion-style navigation menu. Combine splitter with accordion for a collapsible, space-efficient navigation interface."
            },
             new Sample
            {
                Name = "Details View",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "splitter/details-view",
                FileName = "DetailsView.razor",
                MetaTitle = "Blazor Splitter Details View | Master-Detail Layout | Syncfusion",
                HeaderText = "Blazor Splitter Example - Details View Layout",
                MetaDescription = "This Blazor Splitter example demonstrates a master-detail view layout. Create an efficient interface for browsing lists and viewing detailed information simultaneously."
            },
            new Sample
            {
                Name = "Outlook-style Layout",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "splitter/outlook",
                FileName = "OutlookStyleLayout.razor",
                MetaTitle = "Blazor Splitter Outlook Layout | Email Interface | Syncfusion",
                HeaderText = "Blazor Splitter Example - Outlook-style Email Layout",
                MetaDescription = "This Blazor Splitter example demonstrates an Outlook-inspired email interface. Create a familiar three-panel layout with folders, message list, and reading pane using nested splitters."
            },
             new Sample
            {
                Name = "Code Editor Layout",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "splitter/code-editor-layout",
                FileName = "CodeEditorLayout.razor",
                MetaTitle = "Blazor Splitter Code Editor | Developer UI | Syncfusion",
                HeaderText = "Blazor Splitter Example - Code Editor Layout",
                MetaDescription = "This Blazor Splitter example demonstrates a code editor layout. Create a development environment with file explorer, code editor, and preview panes using nested splitters."
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
                MetaTitle = "Blazor Avatar Component | Default Functionalities | Syncfusion",
                MetaDescription = "This Blazor Avatar example demonstrates the default functionalities including various sizes, types, and customization options for displaying user profile images or initials."
            },
            new Sample
            {
                Name = "Types",
                Category = "Avatar",
                Directory = "Layouts/Avatar",
                Url = "avatar/types",
                FileName = "Types.razor",
                HeaderText = "Example of Types in Blazor CSS Avatar Component",
                MetaTitle = "Blazor Avatar Types | Circle, Square, Custom | Syncfusion",
                MetaDescription = "This Blazor Avatar example demonstrates different types including circle, square, and custom shapes. Display profile pictures, initials or icons with various style options."
            },
            new Sample
            {
                Name = "ListView",
                Category = "Integration",
                Directory = "Layouts/Avatar",
                Url = "avatar/listview",
                FileName = "ListView.razor",
                HeaderText = "Example of Blazor CSS Avatar Component in ListView",
                MetaTitle = "Blazor Avatar with ListView | Component Integration | Syncfusion",
                MetaDescription = "This Blazor Avatar integration example demonstrates using avatars within ListView items. Create contact lists, user directories, and message threads with profile images."
            },
            new Sample
            {
                Name = "Badge",
                Category = "Integration",
                Directory = "Layouts/Avatar",
                Url = "avatar/badge",
                FileName = "Badge.razor",
                HeaderText = "Example of Blazor CSS Avatar Component with Badge",
                MetaTitle = "Blazor Avatar with Badge | Status Indicators | Syncfusion",
                MetaDescription = "This Blazor Avatar example demonstrates integration with badges for status indicators. Add notification counts or online status indicators to user avatars for interactive interfaces."
            },
            new Sample
            {
                Name = "Card",
                Category = "Integration",
                Directory = "Layouts/Avatar",
                Url = "avatar/card",
                FileName = "Card.razor",
                HeaderText = "Example of Blazor CSS Avatar Component with Card",
                MetaTitle = "Blazor Avatar with Card | Profile Cards | Syncfusion",
                MetaDescription = "This Blazor Avatar integration example demonstrates using avatars within Card components. Create user profile cards, team member listings, and contact information displays."
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
                MetaTitle = "Blazor Timeline Component | Default Functionalities | Syncfusion",
                HeaderText = "Blazor Timeline Example - Default Functionalities",
                MetaDescription = "This Blazor Timeline example demonstrates chronological event visualization with default styling. Display sequential events with timestamps, content, and connecting lines."
            },
            new Sample
            {
                Name = "API",
                Category = "Timeline",
                Directory = "Layouts/Timeline",
                Url = "timeline/api",
                FileName = "API.razor",
                MetaTitle = "Blazor Timeline API | Programmatic Control | Syncfusion",
                HeaderText = "Blazor Timeline Example - API Configuration",
                MetaDescription = "This Blazor Timeline API example demonstrates programmatic control and configuration options. Customize orientation, item alignment, dot customization and responsive behavior."
            },
            new Sample
            {
                Name = "Template",
                Category = "Timeline",
                Directory = "Layouts/Timeline",
                Url = "timeline/timeline-template",
                FileName = "Template.razor",
                MetaTitle = "Blazor Timeline Templates | Custom Item Design | Syncfusion",
                HeaderText = "Blazor Timeline Example - Custom Templates",
                MetaDescription = "This Blazor Timeline template example demonstrates custom content rendering for timeline items. Create visually appealing timelines with rich content, images, and interactive elements."
            }
        };
    }
}
