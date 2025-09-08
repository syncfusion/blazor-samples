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
        public List<Sample> Scheduler { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Overview",
                Category = "Scheduler",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor Scheduler Overview | Event Management | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Overview",
                MetaDescription = "This demo shows comprehensive event management with multiple views, drag-drop functionality, customizable appearance for appointment scheduling applications."
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Scheduler",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/default-functionalities",
                FileName = "Default.razor",
                MetaTitle = "Blazor Scheduler Default | Basic Event Scheduling | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Default Functionalities",
                MetaDescription = "This Blazor Scheduler demo shows basic event scheduling with multiple view modes, appointment creation, editing, and navigation for calendar-based applications.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "Default.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
#if SERVER
            new Sample
            {
                Name = "Smart Scheduling",
                Category = "Smart AI Solutions",
                Directory = "AISamples/Schedule",
                Url = "scheduler/ai-smartscheduler",
                FileName = "SchedulerSmartAi.razor",
                MetaTitle = "Blazor Scheduler AIAssistant Example - Syncfusion AI Demos",
                HeaderText = "Blazor Scheduler AI Assistant - Smart Scheduling with Natural Language",
                MetaDescription = "This demo shows intelligent appointment creation using natural language processing. Experience AI-powered event scheduling with automatic time slot suggestions.",
                NotificationDescription = new string[]{ @" This demo showcases the Scheduler AI feature." },
                Type = SampleType.AI
            },
#endif
            new Sample
            {
                Name = "Event Calendar",
                Category = "Product Use Case",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/event-calendar",
                FileName = "EventCalendar.razor",
                MetaTitle = "Blazor Event Calendar | Comprehensive Event Management | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Event Calendar",
                MetaDescription = "This demo shows event management with intuitive user interactions, multiple view modes, advanced scheduling features for professional calendar applications.",
                NotificationDescription = new string[] { "Introduced a comprehensive event calendar showcasing various event management features and intuitive user interactions." }
            },
            new Sample
            {
                Name = "Holiday Calendar",
                Category = "Product Use Case",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/holiday-Calendar",
                FileName = "HolidayCalendar.razor",
                MetaTitle = "Blazor Holiday Calendar | Holiday Management System | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Holiday Calendar",
                MetaDescription = "This Holiday Calendar demo shows holiday management with special date highlighting, custom styling, holiday event tracking for organizational calendar systems.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "HolidayCalendar.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Shift Management",
                Category = "Product Use Case",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/employee-shift-management",
                FileName = "EmployeeShiftManagement.razor",
                MetaTitle = "Blazor Shift Management Example | Use case | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Shift Management",
                MetaDescription="This Shift Management demo shows employee shift management with seamless swapping, leave replacement, role or employee filtering for efficient shift tracking.",
                IsHideInMobile = true,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="EmployeeShiftManagement.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="EmployeeShiftManagementData.cs"
                    }
                },
                NotificationDescription = new string[]{ "Revolutionize employee shift management with seamless swapping, effortless leave replacement, and smart role or employee filtering for efficient shift tracking." }
            },
            new Sample
            {
                Name = "Tech Event Organizer",
                Category = "Product Use Case",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/tech-event-organizer",
                FileName = "TechEventOrganizer.razor",
                MetaTitle = "Blazor Tech Event Organizer | Use case | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Shift Management",
                MetaDescription = "This demo shows planning tech events like a Drag, drop, and assign sessions without conflicts, filter by room, and get a complete view of every session detail.",
                IsHideInMobile = true,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="TechEventOrganizer.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="TechEventOrganizerData.cs"
                    }
                },
                NotificationDescription = new string[]{ "Plan tech events like a pro! Drag, drop, and assign sessions without conflicts, filter by room, and get a complete view of every session detail." }
            },
            new Sample
            {
                Name = "Pagination Scheduler",
                Category = "Product Use Case",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/pagination-scheduler",
                FileName = "PaginationScheduler.razor",
                MetaTitle = "Blazor Pagination Scheduler | Large Resource Management | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Pagination Scheduler",
                MetaDescription = "This Pagination Scheduler shows navigation via large sets of resources with pagination support for seamless performance in enterprise scheduling applications.",
                NotificationDescription = new string[] { "Enhanced the Scheduler by adding pagination support, allowing for seamless and efficient navigation through large sets of resources." }
            },
            new Sample
            {
                Name = "Resource Filtering",
                Category = "Product Use Case",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/resource-filtering",
                FileName = "ResourceFiltering.razor",
                MetaTitle = "Blazor Resource Filtering | Dynamic Resource Display | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Resource Filtering",
                MetaDescription = "This Filtering demo shows dynamic filtering, display of specific resources in the Scheduler for improved resource management and focused view capabilities.",
                IsHideInMobile = true,
                NotificationDescription = new string[] { "Implemented resource filtering functionality, allowing users to dynamically filter and display specific resources in the Scheduler." }
            },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/local-data",
                FileName = "LocalData.razor",
                MetaTitle = "Blazor Scheduler Local Data | Client-Side Binding | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Local Data",
                MetaDescription = "This Blazor Scheduler local data demo shows client-side data binding with local collections for offline-capable scheduling applications, improved performance.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "LocalData.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/remote-data",
                FileName = "RemoteData.razor",
                MetaTitle = "Blazor Scheduler Remote Data | Server-Side Binding | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Remote Data",
                MetaDescription = "This Scheduler remote data demo shows server-side data binding with RESTful services for real-time synchronization and enterprise-level scheduling applications."
            },
            new Sample
            {
                Name = "Custom Binding",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/custom-binding",
                FileName = "CustomBinding.razor",
                MetaTitle = "Blazor Scheduler Custom Binding | Flexible Data Sources | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Custom Binding",
                MetaDescription = "This Blazor Scheduler custom binding demo shows flexible data source integration with custom adapters for specialized data formats, business logic requirements."
            },
            new Sample
            {
                Name = "Observable Collection",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/observable-binding",
                FileName = "ObservableCollection.razor",
                MetaTitle = "Blazor Scheduler Observable | Real-Time Data Updates | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Observable Collection",
                MetaDescription = "Blazor Scheduler observable collection demo shows real-time data updates with automatic UI synchronization for dynamic scheduling applications with live data."
            },
            new Sample
            {
                Name = "DynamicObject Binding",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/dynamicobject",
                FileName = "DynamicObject.razor",
                MetaTitle = "Blazor Scheduler Dynamic Object | Flexible Schema | Syncfusion",
                HeaderText = "Blazor Scheduler Example - DynamicObject Binding",
                MetaDescription = "This Blazor Scheduler DynamicObject binding example shows flexible schema handling with dynamic property binding for adaptable scheduling data structures."
            },
            new Sample
            {
                Name = "ExpandoObject Binding",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/expandoobject",
                FileName = "SchedulerExpandoObject.razor",
                MetaTitle = "Blazor Scheduler ExpandoObject | Dynamic Properties | Syncfusion",
                HeaderText = "Blazor Scheduler Example - ExpandoObject Binding",
                MetaDescription = "This Blazor Scheduler ExpandoObject binding example shows dynamic property handling with runtime schema modification for flexible scheduling data management."
            },
            new Sample
            {
                Name = "Recurring Events",
                Category = "Appointments",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/recurrence-events",
                FileName = "RecurrenceEvents.razor",
                MetaTitle = "Blazor Scheduler Recurring Events | Repeat Patterns | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Recurring Events",
                MetaDescription = "This Blazor Scheduler recurring events demo shows repeat pattern creation with daily, weekly, monthly, yearly recurrence rules for automated event scheduling.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "RecurrenceEvents.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Blockout Dates and Hours",
                Category = "Appointments",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/block-out-dates-and-hours",
                FileName = "BlockEvents.razor",
                MetaTitle = "Blazor Scheduler Block Events | Unavailable Time Slots | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Blockout Dates and Hours",
                MetaDescription = "This Blazor Scheduler block events example demonstrates blocking unavailable time slots and dates to prevent appointment scheduling during restricted periods.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "BlockEvents.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Read-only Events",
                Category = "Appointments",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/readonly-events",
                FileName = "ReadonlyEvents.razor",
                MetaTitle = "Blazor Scheduler Read-only Events | Appointments | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Read-only Events",
                MetaDescription = "This Scheduler read-only events demo shows protected appointments that cannot be edited or deleted, ensuring data integrity for critical scheduling information.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "ReadonlyEvents.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Timezone",
                Category = "Appointments",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/timezone",
                FileName = "Timezone.razor",
                MetaTitle = "Blazor Scheduler Timezone | Multi-Timezone Support | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Timezone",
                MetaDescription = "This Blazor Scheduler demo shows multi-timezone support with automatic time conversion for global scheduling applications and cross-timezone meeting management.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "Timezone.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Search Events",
                Category = "Appointments",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/search-events",
                FileName = "SearchEvents.razor",
                MetaTitle = "Blazor Scheduler Search Events | Event Discovery | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Search Events",
                MetaDescription = "This Blazor Scheduler search events demo shows event discovery with text-based search functionality for quick appointment location and filtering capabilities.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "SearchEvents.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Inline Editing",
                Category = "Appointments",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/inline-editing",
                FileName = "InlineEditing.razor",
                MetaTitle = "Blazor Scheduler Inline Editing | Quick Event Updates | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Inline Editing",
                MetaDescription = "This Blazor Scheduler demo shows quick event updates with direct text editing capabilities for efficient appointment modification without popup dialogs.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "InlineEditing.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Overlap Events",
                Category = "Appointments",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/overlap-events",
                FileName = "OverlapEvents.razor",
                MetaTitle = "Blazor Scheduler Overlap Events | Conflict Management | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Overlap Events",
                MetaDescription = "Blazor Scheduler overlap events demo shows conflict management with overlapping appointment handling and visual indicators for scheduling conflict resolution.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "OverlapEvents.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Reminder",
                Category = "Appointments",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/reminder",
                FileName = "Reminder.razor",
                MetaTitle = "Blazor Scheduler Reminder | Event Notifications | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Reminder",
                MetaDescription = "This Blazor Scheduler reminder example shows event notification system with customizable reminder alerts and notification timing for appointment management.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "Reminder.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "External Drag and Drop",
                Category = "Drag and Drop",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/external-drag-and-drop",
                FileName = "ExternalDragDrop.razor",
                MetaTitle = "Blazor Scheduler External Drag Drop | Event Creation | Syncfusion",
                HeaderText = "Blazor Scheduler Example - External Drag and Drop",
                MetaDescription = "This Blazor Scheduler drag and drop demo shows event creation by dragging items from external sources into the scheduler for intuitive appointment scheduling.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "ExternalDragDrop.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Multiple Events Drag",
                Category = "Drag and Drop",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/drag-and-drop",
                FileName = "DragDrop.razor",
                MetaTitle = "Blazor Scheduler Multiple Drag | Batch Event Moving | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Multiple Events Drag",
                MetaDescription = "This Blazor Scheduler multiple events drag demo shows batch event moving with multiselection and drag-drop functionality for efficient appointment rescheduling.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "DragDrop.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Drag Between Schedulers",
                Category = "Drag and Drop",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/drag-between-schedulers",
                IsHideInMobile = true,
                FileName = "DragBetweenSchedulers.razor",
                MetaTitle = "Blazor Scheduler Cross-Instance Drag | Multi-Calendar | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Drag Between Schedulers",
                MetaDescription = "This Blazor Scheduler cross-instance drag demo shows event transfer between multiple scheduler instances for multi-calendar management and resource allocation.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "DragBetweenSchedulers.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Drag Events From Grid",
                Category = "Drag and Drop",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/grid-to-schedule",
                FileName = "GridToSchedule.razor",
                MetaTitle = "Blazor Grid to Scheduler Drag | Data Integration | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Drag Events From Grid",
                MetaDescription = "Blazor Grid to Scheduler drag demo shows seamless data integration by dragging events from DataGrid to Scheduler for efficient appointment creation workflow.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "GridToSchedule.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Scrolling",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/virtual-scrolling",
                FileName = "VirtualScrolling.razor",
                MetaTitle = "Blazor Scheduler Virtual Scrolling | Performance | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Virtual Scrolling",
                MetaDescription = "Blazor Scheduler virtual scrolling demo shows high-performance rendering with virtualization for handling large datasets and improved scrolling performance."
            },
            new Sample
            {
                Name = "Virtual Mask",
                Category = "Scrolling",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/virtual-mask",
                FileName = "VirtualMask.razor",
                MetaTitle = "Blazor Scheduler Virtual Mask | Optimized Rendering | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Virtual Mask",
                MetaDescription = "This Blazor Scheduler virtual mask example shows optimized rendering with masked virtualization for enhanced performance in large-scale scheduling applications."
            },
            new Sample
            {
                Name = "Data Virtualization",
                Category = "Scrolling",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/data-virtualization",
                FileName = "DataVirtualization.razor",
                MetaTitle = "Blazor Scheduler Data Virtualization | Large Datasets | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Data Virtualization",
                MetaDescription = "Blazor Scheduler data virtualization demo shows efficient handling of large datasets with on-demand data loading for enterprise-scale scheduling applications."
            },
            new Sample
            {
                Name = "Basic Views",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/basic-views",
                FileName = "Views.razor",
                MetaTitle = "Blazor Scheduler Basic Views | Multiple View Modes | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Basic Views",
                MetaDescription = "This Blazor Scheduler basic views demo shows multiple view modes including day, week, month, agenda views for flexible calendar visualization and navigation.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "Views.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Timeline View",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/timeline-view",
                FileName = "Timeline.razor",
                MetaTitle = "Blazor Scheduler Timeline View | Horizontal Layout | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Timeline View",
                MetaDescription = "This Blazor Scheduler timeline view example shows horizontal layout with time-based visualization for project scheduling and resource management applications.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "Timeline.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Agenda View",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/agenda-view",
                FileName = "Agenda.razor",
                MetaTitle = "Blazor Scheduler Agenda View | List-Based Display | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Agenda View",
                MetaDescription = "This Blazor Scheduler agenda view example demonstrates list-based event display with chronological ordering for simplified appointment viewing and management.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "Agenda.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Month Agenda View",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/month-agenda-view",
                FileName = "MonthAgenda.razor",
                MetaTitle = "Blazor Scheduler Month Agenda | Hybrid View Mode | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Month Agenda View",
                MetaDescription = "This Blazor Scheduler month agenda view example demonstrates hybrid visualization combining monthly calendar with agenda list for comprehensive event overview.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "MonthAgenda.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Individual View Settings",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/individual-view-settings",
                FileName = "IndividualViewSettings.razor",
                MetaTitle = "Blazor Scheduler View Settings | Custom Configuration | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Individual View Settings",
                MetaDescription = "This Blazor Scheduler individual view settings example demonstrates custom configuration for each view mode with specific time intervals and display options.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "IndividualViewSettings.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Custom Views",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/custom-views",
                FileName = "ExtendedViews.razor",
                MetaTitle = "Blazor Scheduler Custom Views | Extended View Modes | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Custom Views",
                MetaDescription = "This Blazor Scheduler custom views example shows extended view modes with custom time intervals and specialized layouts for unique scheduling requirements.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "ExtendedViews.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Year View",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/year-view",
                FileName = "Year.razor",
                MetaTitle = "Blazor Scheduler Year View | Annual Calendar | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Year View",
                MetaDescription = "This Blazor Scheduler year view example demonstrates annual calendar visualization with 12-month overview for long-term planning and yearly event management."
            },
            new Sample
            {
                Name = "Custom Month View",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/custom-month-view",
                FileName = "CustomMonthView.razor",
                MetaTitle = "Blazor Scheduler Custom Month | Tailored Monthly View | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Custom Month View",
                MetaDescription = "This Blazor Scheduler custom month view example shows tailored monthly visualization with custom cell rendering and specialized month layout configurations.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "CustomMonthView.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Room Scheduler",
                Category = "Multiple Resources",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/room-scheduler",
                FileName = "TimelineResource.razor",
                MetaTitle = "Blazor Room Scheduler | Resource Booking System | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Room Scheduler",
                MetaDescription = "This Blazor Room Scheduler example demonstrates resource booking system with timeline view for meeting room management and facility scheduling applications.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "TimelineResource.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Fare Calendar",
                Category = "Multiple Resources",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/fare-calendar",
                FileName = "FareCalendar.razor",
                MetaTitle = "Blazor Fare Calendar | Price-Based Scheduling | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Fare Calendar",
                MetaDescription = "This Blazor Fare Calendar example demonstrates price-based scheduling with the fare visualization for travel booking and pricing calendar applications."
            },
            new Sample
            {
                Name = "Resources",
                Category = "Multiple Resources",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/resource",
                FileName = "Resource.razor",
                MetaTitle = "Blazor Scheduler Resources | Multi-Resource Management | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Resources",
                MetaDescription = "This Blazor Scheduler resources example demonstrates multi-resource management with resource allocation and scheduling across multiple entities and personnel.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "Resource.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Shared Events",
                Category = "Multiple Resources",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/shared-events",
                FileName = "GroupEditing.razor",
                MetaTitle = "Blazor Scheduler Shared Events | Cross-Resource Events | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Shared Events",
                MetaDescription = "This Blazor Scheduler shared events example demonstrates cross-resource event management with group editing capabilities for collaborative scheduling scenarios.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "GroupEditing.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Different Work Days",
                Category = "Multiple Resources",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/different-work-days",
                FileName = "GroupCustomWorkdays.razor",
                MetaTitle = "Blazor Scheduler Work Days | Custom Resource Schedules | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Different Work Days",
                MetaDescription = "This Blazor Scheduler different work days example shows custom resource schedules with individual working day configurations for flexible resource management.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "GroupCustomWorkdays.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Add or Remove Resources",
                Category = "Multiple Resources",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/add-remove-resources",
                FileName = "AddRemoveResources.razor",
                MetaTitle = "Blazor Scheduler Dynamic Resources | Resource Management | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Add or Remove Resources",
                MetaDescription = "This Blazor Scheduler dynamic resources example shows runtime resource management with add/remove capabilities for flexible scheduling system configuration.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "AddRemoveResources.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Adaptive Rows",
                Category = "Multiple Resources",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/adaptive-rows",
                FileName = "AdaptiveRows.razor",
                MetaTitle = "Blazor Scheduler Adaptive Rows | Dynamic Row Height | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Adaptive Rows",
                MetaDescription = "This Blazor Scheduler adaptive rows example demonstrates dynamic row height adjustment based on content for optimal space utilization in resource scheduling.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "AdaptiveRows.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Horizontal Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/horizontal-grouping",
                FileName = "Group.razor",
                MetaTitle = "Blazor Scheduler Horizontal Grouping | Resource Layout | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Horizontal Grouping",
                MetaDescription = "Blazor Scheduler horizontal grouping demo shows resource layout organization with horizontal arrangement for improved resource visualization and management."
            },
            new Sample
            {
                Name = "Timeline Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/timeline-grouping",
                FileName = "TimelineResourceGroup.razor",
                MetaTitle = "Blazor Scheduler Timeline Grouping | Resource Timeline | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Timeline Grouping",
                MetaDescription = "This Blazor Scheduler timeline grouping example shows resource timeline organization with grouped layout for comprehensive resource scheduling visualization.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "TimelineResourceGroup.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Date-wise Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/date-wise-grouping",
                FileName = "GroupByDate.razor",
                MetaTitle = "Blazor Scheduler Date Grouping | Date-Based Layout | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Date-wise Grouping",
                MetaDescription = "This Blazor Scheduler date-wise grouping example shows date-based layout organization with grouped date arrangement for chronological resource scheduling.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "GroupByDate.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Hierarchical Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/hierarchical-grouping",
                FileName = "GroupByChild.razor",
                MetaTitle = "Blazor Scheduler Hierarchical Grouping | Nested Resources | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Hierarchical Grouping",
                MetaDescription = "This Blazor Scheduler hierarchical grouping example demonstrates nested resource organization with parent-child relationships for complex resource structures.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "GroupByChild.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Adaptive Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/adaptive-grouping",
                FileName = "AdaptiveGrouping.razor",
                MetaTitle = "Blazor Scheduler Adaptive Grouping | Responsive Layout | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Adaptive Grouping",
                MetaDescription = "This Blazor Scheduler adaptive grouping example demonstrates responsive layout with automatic grouping adjustment based on screen size and available space.",
                IsHideInMobile = true,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "AdaptiveGrouping.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Date Header",
                Category = "Templates",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/date-header",
                FileName = "DateHeader.razor",
                MetaTitle = "Blazor Scheduler Date Header | Custom Header Template | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Date Header",
                MetaDescription = "This Blazor Scheduler date header example demonstrates custom header template with personalized date display and styling for enhanced calendar appearance.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "DateHeader.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Cell Template",
                Category = "Templates",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/cell-template",
                FileName = "CustomCell.razor",
                MetaTitle = "Blazor Scheduler Cell Template | Custom Cell Rendering | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Cell Template",
                MetaDescription = "This Blazor Scheduler cell template example demonstrates custom cell rendering with personalized content and styling for enhanced calendar cell appearance.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "CustomCell.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Event Template",
                Category = "Templates",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/event-template",
                FileName = "AppointmentTemplate.razor",
                MetaTitle = "Blazor Scheduler Event Template | Custom Event Display | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Event Template",
                MetaDescription = "This Blazor Scheduler event template example shows custom event display with personalized appointment rendering and styling for enhanced event visualization.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "AppointmentTemplate.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Tooltip Template",
                Category = "Templates",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/tooltip-template",
                FileName = "Tooltip.razor",
                MetaTitle = "Blazor Scheduler Tooltip Template | Custom Tooltips | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Tooltip Template",
                MetaDescription = "This Blazor Scheduler tooltip template example shows custom tooltip display with personalized content and styling for enhanced event information presentation.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "Tooltip.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Quick Info Template",
                Category = "Templates",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/quick-info-template",
                FileName = "QuickInfoTemplate.razor",
                MetaTitle = "Blazor Scheduler Quick Info | Custom Popup Template | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Quick Info Template",
                MetaDescription = "This Blazor Scheduler quick info template example demonstrates custom popup template with personalized event information display for enhanced user interaction.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "QuickInfoTemplate.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Field Validation",
                Category = "Editor Window",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/field-validation",
                FileName = "EditorValidation.razor",
                MetaTitle = "Blazor Scheduler Field Validation | Form Validation | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Field Validation",
                MetaDescription = "This Blazor Scheduler field validation demo shows form validation with custom rules and error handling for data integrity in appointment creation and editing.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "EditorValidation.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Editor Template",
                Category = "Editor Window",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/editor-template",
                FileName = "EditorPopupTemplate.razor",
                MetaTitle = "Blazor Scheduler Editor Template | Custom Edit Form | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Editor Template",
                MetaDescription = "This Blazor Scheduler editor template example demonstrates custom edit form with personalized fields and layout for enhanced appointment editing experience.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "EditorPopupTemplate.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "External Form Editing",
                Category = "Editor Window",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/external-form-editing",
                FileName = "ExternalFormEditing.razor",
                MetaTitle = "Blazor Scheduler External Form | Separate Edit Window | Syncfusion",
                HeaderText = "Blazor Scheduler Example - External Form Editing",
                MetaDescription = "This Blazor Scheduler external form editing example demonstrates separate edit window with custom form layout for advanced appointment editing capabilities.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "ExternalFormEditing.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Header Rows",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/header-rows",
                FileName = "HeaderRows.razor",
                MetaTitle = "Blazor Scheduler Header Rows | Multi-Level Headers | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Header Rows",
                MetaDescription = "This Blazor Scheduler header rows example demonstrates multi-level header configuration with custom row layouts for enhanced calendar header organization.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "HeaderRows.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Timescale",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/time-scale",
                FileName = "Timescale.razor",
                MetaTitle = "Blazor Scheduler Timescale | Custom Time Intervals | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Timescale",
                MetaDescription = "This Blazor Scheduler timescale example shows custom time interval configuration with flexible time slot settings for personalized scheduling granularity.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "Timescale.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Context Menu",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/context-menu",
                FileName = "ContextMenu.razor",
                MetaTitle = "Blazor Scheduler Context Menu | Right-Click Actions | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Context Menu",
                MetaDescription = "This Blazor Scheduler context menu example shows right-click actions with custom menu items for enhanced user interaction and quick appointment operations.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "ContextMenu.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Header Bar",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/header-bar",
                FileName = "HeaderBar.razor",
                MetaTitle = "Blazor Scheduler Header Bar | Custom Navigation | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Header Bar",
                MetaDescription = "This Blazor Scheduler header bar example demonstrates custom navigation with personalized toolbar and navigation controls for enhanced calendar interaction.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "HeaderBar.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Scroll Time",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/scroll-time",
                FileName = "ScrollTime.razor",
                MetaTitle = "Blazor Scheduler Scroll Time | Auto-Scroll Position | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Scroll Time",
                MetaDescription = "This Blazor Scheduler scroll time example shows auto-scroll positioning with customizable initial scroll time for improved user experience and navigation.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "ScrollTime.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Working Days",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/working-days",
                FileName = "WorkDays.razor",
                MetaTitle = "Blazor Scheduler Working Days | Custom Work Week | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Working Days",
                MetaDescription = "This Blazor Scheduler working days demo shows custom work week configuration with flexible working day settings for business-specific scheduling requirements.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "WorkDays.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Working Hours",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/working-hours",
                FileName = "WorkHours.razor",
                MetaTitle = "Blazor Scheduler Working Hours | Business Hours Setup | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Working Hours",
                MetaDescription = "This Blazor Scheduler working hours example demonstrates business hours configuration with custom time ranges for professional scheduling and time management.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "WorkHours.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Hide Non-Working Hours",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/hide-non-working-hours",
                FileName = "DayHourLimit.razor",
                MetaTitle = "Blazor Scheduler Hide Non-Working Hours | Time Filtering | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Hide Non-Working Hours",
                MetaDescription = "This Blazor Scheduler hide non-working hours demo shows time filtering with selective hour display for focused business hour scheduling and improved visibility.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "DayHourLimit.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Cell Dimension",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/cell-dimensions",
                FileName = "CellDimensions.razor",
                MetaTitle = "Blazor Scheduler Cell Dimension | Custom Cell Sizing | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Cell Dimension",
                MetaDescription = "This Blazor Scheduler cell dimension example shows custom cell sizing with adjustable width and height settings for personalized calendar layout and appearance.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "CellDimensions.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Export to Excel",
                Category = "Exporting",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/export-to-excel",
                FileName = "ExcelExport.razor",
                MetaTitle = "Blazor Scheduler Excel Export | Data Export Feature | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Export to Excel",
                MetaDescription = "This Blazor Scheduler Excel export example shows data export functionality with customizable Excel format output for reporting and data analysis purposes.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "ExcelExport.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Export and Import ICS",
                Category = "Exporting",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/export-and-import-ics",
                FileName = "CalendarExportImport.razor",
                MetaTitle = "Blazor Scheduler ICS Export Import | Calendar Integration | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Export and Import ICS",
                MetaDescription = "This Blazor Scheduler ICS export import demo shows calendar integration with standard ICS format for cross-platform calendar synchronization and data exchange.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "CalendarExportImport.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Print",
                Category = "Exporting",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/print",
                FileName = "Print.razor",
                MetaTitle = "Blazor Scheduler Print | Calendar Printing Feature | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Print",
                MetaDescription = "This Blazor Scheduler print example shows calendar printing functionality with customizable print layouts and formatting options for physical calendar output.",
                IsHideInMobile = true,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "Print.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "RRule Generator",
                Category = "Recurrence Editor",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/recurrence-editor-rrule-generator",
                FileName = "RecurrenceRuleGenerator.razor",
                MetaTitle = "Blazor RRule Generator | Recurrence Rule Creation | Syncfusion",
                HeaderText = "Blazor Scheduler Example - RRule Generator",
                MetaDescription = "This Blazor RRule Generator example shows recurrence rule creation with RFC standard compliance for generating complex recurring event patterns and schedules."
            },
            new Sample
            {
                Name = "Recurrence Rules",
                Category = "Recurrence Editor",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/recurrence-rules",
                FileName = "RecurrenceEditorPopulateRule.razor",
                MetaTitle = "Blazor Recurrence Rules | Pattern Configuration | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Recurrence Rules",
                MetaDescription = "This Blazor Recurrence Rules demo shows pattern configuration with comprehensive recurrence options for creating complex recurring event schedules and patterns."
            },
            new Sample
            {
                Name = "Clipboard",
                Category = "Miscellaneous",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/clipboard",
                FileName = "Clipboard.razor",
                MetaTitle = "Blazor Scheduler Clipboard | Cut Copy Paste Events | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Clipboard",
                MetaDescription = "This Blazor Scheduler clipboard example shows cut, copy, and paste functionality for seamless event manipulation and efficient appointment management workflows.",
                NotificationDescription = new string[]
                {
                    "Showcased the ability to cut, copy, and paste events seamlessly, enabling the addition and editing of events with ease."
                },
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "Clipboard.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Miscellaneous",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/keyboard-interaction",
                FileName = "KeyboardInteraction.razor",
                MetaTitle = "Blazor Scheduler Keyboard | Accessibility Navigation | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Keyboard Interaction",
                MetaDescription = "Blazor Scheduler keyboard interaction demo shows accessibility navigation with comprehensive keyboard shortcuts for efficient calendar operation and navigation.",
                IsHideInMobile = true,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "KeyboardInteraction.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            },
            new Sample
            {
                Name = "Events",
                Category = "Miscellaneous",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/events",
                FileName = "Events.razor",
                MetaTitle = "Blazor Scheduler Events | Event Handling System | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Events",
                MetaDescription = "Blazor Scheduler events demo shows comprehensive event handling system with lifecycle events and custom event processing for advanced scheduling applications.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "Events.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            }
        };
    }
}
