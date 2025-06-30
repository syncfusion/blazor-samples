#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;

namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> Kanban { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor Kanban Board Overview | Task Management | Syncfusion",
                HeaderText = "Blazor Kanban Board Component - Overview",
                MetaDescription = "This Blazor Kanban Board overview demonstrates essential features for task management. Visualize workflows with columns, cards, and drag-and-drop functionality for effective project organization."
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Kanban Default Functionalities | Task Boards | Syncfusion",
                HeaderText = "Blazor Kanban Board - Default Functionalities",
                MetaDescription = "This Blazor Kanban Board example showcases default functionalities including drag-and-drop, column definition, card layout, and status visualization for efficient workflow management."
            },
            new Sample
            {
                Name = "Swimlane",
                Category = "Kanban",
                Type = SampleType.None,
                Directory = "Kanban/Kanban",
                Url = "kanban/swimlane",
                FileName = "Swimlane.razor",
                MetaTitle = "Blazor Kanban Swimlane | Categorized Workflows | Syncfusion",
                HeaderText = "Blazor Kanban Board - Swimlane Visualization",
                MetaDescription = "This Blazor Kanban swimlane example demonstrates horizontal categorization of tasks by team, priority, or status. Organize workflows with multiple parallel tracks for better project visibility."
            },
            new Sample
            {
                Name = "Workflow",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/workflow",
                FileName = "Workflow.razor",
                MetaTitle = "Blazor Kanban Workflow | Process Management | Syncfusion",
                HeaderText = "Blazor Kanban Board - Workflow Management",
                MetaDescription = "This Blazor Kanban workflow example showcases process visualization with custom states and transitions. Define task progression rules and visualize work moving through different stages."
            },
            new Sample
            {
                Name = "Stacked Header",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/stacked-header",
                FileName = "StackedHeader.razor",
                MetaTitle = "Blazor Kanban Stacked Headers | Column Grouping | Syncfusion",
                HeaderText = "Blazor Kanban Board - Stacked Headers",
                MetaDescription = "This Blazor Kanban stacked header example demonstrates hierarchical column organization. Group related statuses under common headers for logical workflow visualization and improved board structure."
            },
            new Sample
            {
                Name = "Dialog Editing",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/dialog-editing",
                FileName = "DialogEditing.razor",
                MetaTitle = "Blazor Kanban Dialog Editing | Card Editing | Syncfusion",
                HeaderText = "Blazor Kanban Board - Dialog Editing",
                MetaDescription = "This Blazor Kanban dialog editing example demonstrates built-in dialogs for adding, editing, and managing cards. Modify task details with form validation and structured inputs."
            },
            new Sample
            {
                Name = "Search and Filter Cards",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/search-filter",
                FileName = "SearchFilter.razor",
                MetaTitle = "Blazor Kanban Search & Filter | Card Filtering | Syncfusion",
                HeaderText = "Blazor Kanban Board - Search and Filter Cards",
                MetaDescription = "This Blazor Kanban search and filter example demonstrates finding and filtering cards by keywords, status, assignee, and priority. Quickly locate relevant tasks in complex boards."
            },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Kanban/Kanban",
                Url = "kanban/local-data",
                FileName = "LocalData.razor",
                MetaTitle = "Blazor Kanban Local Data Binding | Client-Side Data | Syncfusion",
                HeaderText = "Blazor Kanban Board - Local Data Binding",
                MetaDescription = "This Blazor Kanban local data binding example demonstrates connecting the board to client-side data collections. Bind to arrays, lists, or objects to populate and manage tasks."
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Kanban/Kanban",
                Url = "kanban/remote-data",
                FileName = "RemoteData.razor",
                MetaTitle = "Blazor Kanban Remote Data | API Integration | Syncfusion",
                HeaderText = "Blazor Kanban Board - Remote Data Binding",
                MetaDescription = "This Blazor Kanban remote data binding example demonstrates connecting to REST APIs and web services. Fetch, display, and update task data from server-side endpoints."
            },
            new Sample
            {
                Name = "Observable Collection",
                Category = "Data Binding",
                Directory = "Kanban/Kanban",
                Url = "kanban/observable",
                FileName = "KanbanObservable.razor",
                MetaTitle = "Blazor Kanban Observable Collection | Real-time Updates | Syncfusion",
                HeaderText = "Blazor Kanban Board - Observable Collection Binding",
                MetaDescription = "This Blazor Kanban Observable Collection example demonstrates real-time data binding with automatic UI updates. Track and reflect changes to data sources for live board management."
            },
            new Sample
            {
                Name = "ExpandoObject Binding",
                Category = "Data Binding",
                Directory = "Kanban/Kanban",
                Url = "kanban/expando-object",
                FileName = "KanbanExpandoObject.razor",
                MetaTitle = "Blazor Kanban ExpandoObject Binding | Dynamic Properties | Syncfusion",
                HeaderText = "Blazor Kanban Board - ExpandoObject Binding",
                MetaDescription = "This Blazor Kanban ExpandoObject binding example demonstrates binding to dynamic objects with flexible properties. Create and modify task properties at runtime for adaptive workflows."
            },
            new Sample
            {
                Name = "DynamicObject Binding",
                Category = "Data Binding",
                Directory = "Kanban/Kanban",
                Url = "kanban/dynamic-object",
                FileName = "KanbanDynamicObject.razor",
                MetaTitle = "Blazor Kanban DynamicObject Binding | Dynamic Data | Syncfusion",
                HeaderText = "Blazor Kanban Board - DynamicObject Binding",
                MetaDescription = "This Blazor Kanban DynamicObject binding example demonstrates connecting to flexible data structures. Bind to dynamic objects with custom property resolution for adaptable task management."
            },
            new Sample
            {
                Name = "Header Template",
                Category = "Templates",
                Directory = "Kanban/Kanban",
                Url = "kanban/header-template",
                FileName = "HeaderTemplate.razor",
                MetaTitle = "Blazor Kanban Header Template | Custom Headers | Syncfusion",
                HeaderText = "Blazor Kanban Board - Header Template Customization",
                MetaDescription = "This Blazor Kanban header template example demonstrates customizing column headers with HTML, CSS, and components. Create visual indicators, counters, and rich column headers."
            },
            new Sample
            {
                Name = "Swimlane Template",
                Category = "Templates",
                Directory = "Kanban/Kanban",
                Url = "kanban/swimlane-template",
                FileName = "SwimlaneTemplate.razor",
                MetaTitle = "Blazor Kanban Swimlane Template | Custom Swimlanes | Syncfusion",
                HeaderText = "Blazor Kanban Board - Swimlane Template Customization",
                MetaDescription = "This Blazor Kanban swimlane template example demonstrates customizing swimlane headers with rich content. Add images, progress bars, and interactive elements to swimlane categories."
            },
            new Sample
            {
                Name = "Card Template",
                Category = "Templates",
                Directory = "Kanban/Kanban",
                Url = "kanban/card-template",
                FileName = "CardTemplate.razor",
                MetaTitle = "Blazor Kanban Card Template | Custom Task Cards | Syncfusion",
                HeaderText = "Blazor Kanban Board - Card Template Customization",
                MetaDescription = "This Blazor Kanban card template example demonstrates creating rich, customized task cards. Add images, progress indicators, custom layouts, and interactive elements to task cards."
            },
            new Sample
            {
                Name = "Tooltip Template",
                Category = "Templates",
                Directory = "Kanban/Kanban",
                Url = "kanban/tooltip-template",
                FileName = "TooltipTemplate.razor",
                MetaTitle = "Blazor Kanban Tooltip Template | Custom Tooltips | Syncfusion",
                HeaderText = "Blazor Kanban Board - Tooltip Template Customization",
                MetaDescription = "This Blazor Kanban tooltip template example demonstrates creating rich, informative card tooltips. Display additional task details, images, and formatted content when hovering over cards."
            },
            new Sample
            {
                Name = "Toggle Columns",
                Category = "Columns",
                Directory = "Kanban/Kanban",
                Url = "kanban/toggle-columns",
                FileName = "ToggleColumns.razor",
                MetaTitle = "Blazor Kanban Toggle Columns | Column Visibility | Syncfusion",
                HeaderText = "Blazor Kanban Board - Toggle Columns",
                MetaDescription = "This Blazor Kanban toggle columns example demonstrates dynamically showing and hiding columns. Control column visibility to focus on specific workflow stages as needed."
            },
            new Sample
            {
                Name = "Show/Hide Columns",
                Category = "Columns",
                Directory = "Kanban/Kanban",
                Url = "kanban/showhide-columns",
                FileName = "ShowHideColumns.razor",
                MetaTitle = "Blazor Kanban Show/Hide Columns | Column Management | Syncfusion",
                HeaderText = "Blazor Kanban Board - Show/Hide Columns",
                MetaDescription = "This Blazor Kanban show/hide columns example demonstrates programmatic column visibility control. Toggle specific columns on demand to customize the workflow view for different users or scenarios."
            },
            new Sample
            {
                Name = "WIP Validation",
                Category = "Validation",
                Directory = "Kanban/Kanban",
                Url = "kanban/wip-validation",
                FileName = "WipValidation.razor",
                MetaTitle = "Blazor Kanban WIP Validation | Work Limits | Syncfusion",
                HeaderText = "Blazor Kanban Board - Work-In-Progress Validation",
                MetaDescription = "This Blazor Kanban WIP validation example demonstrates setting limits on cards per column. Implement work-in-progress constraints to prevent workflow bottlenecks and maintain process efficiency."
            },
            new Sample
            {
                Name = "API",
                Category = "Miscellaneous",
                Directory = "Kanban/Kanban",
                Url = "kanban/api",
                FileName = "Api.razor",
                MetaTitle = "Blazor Kanban API | Component Methods | Syncfusion",
                HeaderText = "Blazor Kanban Board - API Reference",
                MetaDescription = "This Blazor Kanban API example demonstrates key component methods and properties. Control board behavior, manage cards programmatically, and interact with the component through its public interface."
            },
            new Sample
            {
                Name = "Events",
                Category = "Miscellaneous",
                Directory = "Kanban/Kanban",
                Url = "kanban/events",
                FileName = "Events.razor",
                MetaTitle = "Blazor Kanban Events | Event Handling | Syncfusion",
                HeaderText = "Blazor Kanban Board - Event Handling",
                MetaDescription = "This Blazor Kanban events example demonstrates responding to user interactions like drag-drop, card selection, and column changes. Create reactive workflows with custom logic based on board events."
            }
        };
    }
}
