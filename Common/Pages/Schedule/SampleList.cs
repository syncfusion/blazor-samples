using System.Collections.Generic;
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
                MetaTitle = "Blazor Schedule Examples - Overview | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Component Overview and Capabilities",
                MetaDescription = "See how the Syncfusion Blazor Scheduler manages events with multiple views, drag and drop features, and customization for efficient appointment scheduling.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler"
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Scheduler",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/default-functionalities",
                FileName = "Default.razor",
                MetaTitle = "Blazor Schedule Examples - Default | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Default Functionalities Feature Overview",
                MetaDescription = "See how the Syncfusion Blazor Scheduler enables event creation, editing, and multiple calendar views to handle scheduling tasks efficiently in applications.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule - Smart Scheduling | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler - AI Powered Natural Language Scheduling Example",
                MetaDescription = "See how the Syncfusion Blazor Scheduler uses AI powered natural language processing to create appointments with automatic time slot suggestions efficiently.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
                Type = SampleType.AI
            },
#endif
            // Ignore: From Build
            new Sample
            {
                Name = "Event Calendar",
                Category = "Product Use Case",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/event-calendar",
                FileName = "EventCalendar.razor",
                MetaTitle = "Blazor Schedule - Event Calendar | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Event Calendar Configuration Support",
                MetaDescription = "See how the Syncfusion Blazor Scheduler manages events with intuitive interactions, multiple views, and advanced features for professional scheduling.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler"
            },
            // End: Ignore
            new Sample
            {
                Name = "Holiday Calendar",
                Category = "Product Use Case",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/holiday-Calendar",
                FileName = "HolidayCalendar.razor",
                MetaTitle = "Blazor Schedule - Holiday Calendar | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Holiday Calendar Management Support",
                MetaDescription = "See how the Syncfusion Blazor Scheduler highlights holidays with custom styling and tracking features to manage organizational calendar events effectively.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule - Shift Management | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Shift Management Scheduling Configuration",
                MetaDescription = "See how the Syncfusion Blazor Scheduler manages employee shifts with swapping, filtering, and replacement features for efficient workforce scheduling.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                }
            },
            new Sample
            {
                Name = "Tech Event Organizer",
                Category = "Product Use Case",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/tech-event-organizer",
                FileName = "TechEventOrganizer.razor",
                MetaTitle = "Blazor Schedule - Tech Event Organizer | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Advanced Shift Management Configuration",
                MetaDescription = "See how the Syncfusion Blazor Scheduler organizes tech events with drag and drop sessions, filtering, and scheduling views for conflict free planning workflows.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                }
            },
            new Sample
            {
                Name = "Pagination Scheduler",
                Category = "Product Use Case",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/pagination-scheduler",
                FileName = "PaginationScheduler.razor",
                MetaTitle = "Blazor Schedule - Pagination Scheduler | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Pagination Based Scheduler Layout",
                MetaDescription = "See how the Syncfusion Blazor Scheduler supports pagination for handling large resource sets, enabling smooth navigation and high performance scheduling.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler"
            },
            new Sample
            {
                Name = "Resource Filtering",
                Category = "Product Use Case",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/resource-filtering",
                FileName = "ResourceFiltering.razor",
                MetaTitle = "Blazor Schedule - Resource Filtering | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Resource Based Event Filtering",
                MetaDescription = "See how the Syncfusion Blazor Scheduler filters resources dynamically to display focused views and improve efficiency in resource management workflows.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
                IsHideInMobile = true
            },
            // Ignore: From Build
            new Sample
            {
                Name = "Integration with Chart",
                Category = "Product Use Case",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/integration-with-chart",
                FileName = "SchedulerWithChart.razor",
                IsHideInMobile = true,
                MetaTitle = "Blazor Schedule - Integration With Chart | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Integration With Chart",
                Type = SampleType.New,
                MetaDescription = "See how the Syncfusion Blazor Scheduler integrates charts with scheduling data to visualize driver capacity and trip details for operational insights.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
                NotificationDescription = NotificationChart },
            // End: Ignore
            // Ignore: From Build
            new Sample
            {
                Name = "Task Progress Tracker",
                Category = "Product Use Case",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/task-progress-tracker",
                FileName = "TaskProgressTracker.razor",
                MetaTitle = "Blazor Schedule - Task Progress Tracker | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Task Progress Tracker",
                Type = SampleType.New,
                MetaDescription = "See how the Syncfusion Blazor Scheduler integrates task progress tracking scheduling data to visualize project timelines and milestones for task management.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
                NotificationDescription = NotificationTaskProgress,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "TaskProgressTracker.razor"
                    },
                    new SourceCollection
                    {
                        Id = "Data",
                        FileName = "TaskProgressTrackerData.cs"
                    }
                }
            },
            // End: Ignore
            new Sample
            {
                Name = "Action Event Buttons",
                Category = "Product Use Case",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/event-actions-button",
                FileName = "EventActionsButtons.razor",
                MetaTitle = "Blazor Schedule - Event Actions Buttons | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Event Action Buttons",
                MetaDescription = "See how the Syncfusion Blazor Scheduler provides action buttons for events to enable quick access like editing, deleting and viewing details of an event.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
                NotificationDescription = NotificationActionEvent,
                Type = SampleType.New,
                IsHideInMobile = true,
            },
            new Sample
            {
                Name = "Cascading Combos",
                Category = "Product Use Case",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/cascading-event-editor",
                FileName = "CascadingEventEditor.razor",
                MetaTitle = "Blazor Schedule - Cascading Event Editor | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Cascading Event Editor",
                Type = SampleType.New,
                MetaDescription = "See how the Syncfusion Blazor Scheduler provides a cascading event editor for managing appointments and dynamically dependent dropdown in editor window.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
                NotificationDescription = NotificationCascadingEvent },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/local-data",
                FileName = "LocalData.razor",
                MetaTitle = "Blazor Schedule Examples - Local Data | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Local Data Binding Configuration Support",
                MetaDescription = "See how the Syncfusion Blazor Scheduler binds local data collections for client side scheduling with improved performance and offline capable functionality.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Examples - Remote Data | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Remote Data Binding Configuration Support",
                MetaDescription = "See how the Syncfusion Blazor Scheduler connects to REST services for real time data updates, enabling scalable and synchronized scheduling applications.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler"
            },
            new Sample
            {
                Name = "Custom Binding",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/custom-binding",
                FileName = "CustomBinding.razor",
                MetaTitle = "Blazor Scheduler - Custom Binding | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Custom Data Binding Configuration",
                MetaDescription = "See how the Syncfusion Blazor Scheduler supports custom binding with flexible data integration, enabling tailored scheduling logic for business requirements.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler"
            },
            new Sample
            {
                Name = "Observable Collection",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/observable-binding",
                FileName = "ObservableCollection.razor",
                MetaTitle = "Blazor Schedule - Observable Collection | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Observable Collection Data Binding",
                MetaDescription = "See how the Syncfusion Blazor Scheduler uses observable collections to update UI automatically with real time changes for dynamic scheduling workflows.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler"
            },
            new Sample
            {
                Name = "DynamicObject Binding",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/dynamicobject",
                FileName = "DynamicObject.razor",
                MetaTitle = "Blazor Schedule - DynamicObject Binding | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - DynamicObject Data Binding Support",
                MetaDescription = "See how the Syncfusion Blazor Scheduler supports DynamicObject binding to handle flexible schemas and adaptable data structures for efficient scheduling.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler"
            },
            new Sample
            {
                Name = "ExpandoObject Binding",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/expandoobject",
                FileName = "SchedulerExpandoObject.razor",
                MetaTitle = "Blazor Schedule - ExpandoObject Binding | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - ExpandoObject Data Binding Support",
                MetaDescription = "See how the Syncfusion Blazor Scheduler supports ExpandoObject binding to handle dynamic properties and flexible data structures in scheduling applications.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler"
            },
            new Sample
            {
                Name = "Recurring Events",
                Category = "Appointments",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/recurrence-events",
                FileName = "RecurrenceEvents.razor",
                MetaTitle = "Blazor Scheduler - Recurring Events | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Recurring Event Configuration Support",
                MetaDescription = "See how the Syncfusion Blazor Scheduler manages recurring events with rules for daily, weekly, and yearly patterns to automate repetitive scheduling tasks.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Examples - Blockout Dates and Hours | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Blockout Date and Time Configuration",
                MetaDescription = "See how the Syncfusion Blazor Scheduler blocks unavailable dates and time slots to prevent scheduling conflicts and manage restricted periods effectively.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - Read-only Events | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Read Only Event Configuration Support",
                MetaDescription = "See how the Syncfusion Blazor Scheduler protects critical events with read only mode, preventing edits and ensuring data integrity in scheduling systems.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Examples - Timezone | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Timezone Handling Configuration Support",
                MetaDescription = "See how the Syncfusion Blazor Scheduler supports multiple timezones with automatic conversion for global scheduling and cross region meeting management.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
            // Ignore: From Build
            new Sample
            {
                Name = "Search Events",
                Category = "Appointments",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/search-events",
                FileName = "SearchEvents.razor",
                MetaTitle = "Blazor Schedule - Search Events | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Search Events",
                MetaDescription = "See how the Syncfusion Blazor Scheduler enables search across events with text-based filtering to quickly locate appointments and improve scheduling efficiency.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
            // End: Ignore
            new Sample
            {
                Name = "Inline Editing",
                Category = "Appointments",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/inline-editing",
                FileName = "InlineEditing.razor",
                MetaTitle = "Blazor Scheduler - Inline Editing | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Inline Event Editing Configuration",
                MetaDescription = "See how the Syncfusion Blazor Scheduler enables inline editing for quick event updates with direct input changes to improve scheduling workflow efficiency.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - Overlap Events | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Overlapping Event Handling Support",
                MetaDescription = "See how the Syncfusion Blazor Scheduler handles overlapping events with visual indicators and conflict management to ensure accurate and efficient scheduling.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Examples - Reminder | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Event Reminder and Notification Setup",
                MetaDescription = "See how the Syncfusion Blazor Scheduler provides reminders with customizable alerts and timing to manage appointments and ensure timely notifications.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Examples - External Drag and Drop | Syncfusion",
                HeaderText = "Blazor Scheduler Example - External Drag and Drop Support",
                MetaDescription = "See how the Syncfusion Blazor Scheduler enables drag and drop from external sources to create events, allowing intuitive and flexible scheduling workflows.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - Multiple Events Drag | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Multiple Event Drag and Drop",
                MetaDescription = "See how the Syncfusion Blazor Scheduler enables dragging multiple events with selection support to simplify bulk updates and efficient appointment rescheduling.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Demos - Drag Between Schedulers Examples | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Drag and Drop Between Schedulers",
                MetaDescription = "See how the Syncfusion Blazor Scheduler supports dragging events between multiple schedulers to manage shared calendars and resource allocation efficiently.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
            // Ignore: From Build
            new Sample
            {
                Name = "Drag Events From Grid",
                Category = "Drag and Drop",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/grid-to-schedule",
                FileName = "GridToSchedule.razor",
                MetaTitle = "Blazor Schedule - Drag Events From Grid | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Drag Events from Data Grid Support",
                MetaDescription = "See how the Syncfusion Blazor Scheduler enables dragging events from DataGrid to create appointments, ensuring seamless integration and efficient workflows.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
            // End: Ignore
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Scrolling",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/virtual-scrolling",
                FileName = "VirtualScrolling.razor",
                MetaTitle = "Blazor Scheduler - Virtual Scrolling | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Virtual Scrolling Configuration Support",
                MetaDescription = "See how the Syncfusion Blazor Scheduler uses virtual scrolling to render large datasets efficiently, ensuring smooth navigation and better performance.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler"
            },
            new Sample
            {
                Name = "Virtual Mask",
                Category = "Scrolling",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/virtual-mask",
                FileName = "VirtualMask.razor",
                MetaTitle = "Blazor Schedule Examples - Virtual Mask | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Virtual Mask Row Rendering Support",
                MetaDescription = "See how the Syncfusion Blazor Scheduler uses virtual masking to optimize rendering performance and handle large scale scheduling data smoothly and efficiently.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler"
            },
            new Sample
            {
                Name = "Data Virtualization",
                Category = "Scrolling",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/data-virtualization",
                FileName = "DataVirtualization.razor",
                MetaTitle = "Blazor Scheduler - Data Virtualization | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Data Virtualization Configuration",
                MetaDescription = "See how the Syncfusion Blazor Scheduler supports data virtualization to load datasets on demand, improving performance and scalability in scheduling systems.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler"
            },
            new Sample
            {
                Name = "Basic Views",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/basic-views",
                FileName = "Views.razor",
                MetaTitle = "Blazor Schedule Examples - Basic Views | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Basic Scheduler View Configuration",
                MetaDescription = "See how the Syncfusion Blazor Scheduler provides basic views like day, week, and month to enable flexible navigation and effective appointment scheduling.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - Timeline View | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Timeline View Configuration Support",
                MetaDescription = "See how the Syncfusion Blazor Scheduler supports timeline view with horizontal layout to manage time-based schedules and resource planning efficiently.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Examples - Agenda View | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Agenda View Configuration Support",
                MetaDescription = "See how the Syncfusion Blazor Scheduler provides agenda view with chronological event lists for simplified appointment viewing and efficient schedule tracking.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - Month Agenda View | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Month Agenda View",
                MetaDescription = "See how the Syncfusion Blazor Scheduler combines month and agenda views to deliver a comprehensive layout for event tracking and calendar overview efficiently.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - View Settings | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Individual View Settings",
                MetaDescription = "See how the Syncfusion Blazor Scheduler supports individual view settings with custom configurations to enable flexible scheduling layouts and controls.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - Custom Views | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Custom Views",
                MetaDescription = "See how the Syncfusion Blazor Custom Views Scheduler supports extended layouts with API, custom intervals, and events for flexible scheduling scenarios.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Examples - Year View | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Year View",
                MetaDescription = "See how the Syncfusion Blazor Year View Scheduler displays a 12-month calendar with API, navigation, and events for efficient long-term planning and tracking.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler"
            },
            new Sample
            {
                Name = "Custom Month View",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/custom-month-view",
                FileName = "CustomMonthView.razor",
                MetaTitle = "Blazor Scheduler - Custom Month View | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Custom Month View",
                MetaDescription = "See how the Syncfusion Blazor Custom Month View Scheduler renders layouts using API, templates, and events for flexible and enhanced monthly scheduling.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                Name = "Limit Concurrent Event",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/limit-concurrent-events",
                FileName = "LimitConcurrentEvent.razor",
                Type = SampleType.New,
                MetaTitle = "Blazor Scheduler - Limit Events | Schedule Demo | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Limit Concurrent Event",
                MetaDescription = "See how the Syncfusion Blazor Scheduler supports limit concurrent events with custom configurations to enable flexible scheduling layouts and controls.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
                NotificationDescription = NotificationLimitConcurrentEvent,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Default",
                        FileName = "LimitConcurrentEvent.razor"
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
                MetaTitle = "Blazor Scheduler - Room Scheduler | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Room Scheduler",
                MetaDescription = "See how the Syncfusion Blazor Room Scheduler manages bookings with resource grouping, timeline views, API, and events for efficient facility scheduling.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule - Fare Calendar | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Fare Calendar",
                MetaDescription = "See how the Syncfusion Blazor Fare Calendar Scheduler visualizes pricing data with API, templates, and events for travel planning and booking insights.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler"
            },
            new Sample
            {
                Name = "Resources",
                Category = "Multiple Resources",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/resource",
                FileName = "Resource.razor",
                MetaTitle = "Blazor Schedule Examples - Resources | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Resources",
                MetaDescription = "See how the Syncfusion Blazor Resources Scheduler manages multiple resources with API, grouping, and events for efficient allocation and scheduling workflows.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule - Shared Events | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Shared Events",
                MetaDescription = "See how the Syncfusion Blazor Shared Events Scheduler handles cross-resource events with API, editing, and events for collaborative scheduling workflows.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - Different Work Days | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Different Work Days",
                MetaDescription = "See how the Syncfusion Blazor Different Work Days Scheduler configures custom schedules with API, settings, and events for flexible resource management.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Demos - Add or Remove Resources Examples | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Add or Remove Resources",
                MetaDescription = "See how the Syncfusion Blazor Add or Remove Resources Scheduler updates resources dynamically with API, events, and controls for flexible scheduling tasks.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule - Adaptive Rows | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Adaptive Rows",
                MetaDescription = "See how the Syncfusion Blazor Adaptive Rows Scheduler adjusts row height with API, layout, and events to optimize space usage and improve scheduling clarity.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule - Horizontal Grouping | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Horizontal Grouping",
                MetaDescription = "See how the Syncfusion Blazor Horizontal Grouping Scheduler organizes resources with API, layout, and events for better visualization and task tracking.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler"
            },
            new Sample
            {
                Name = "Timeline Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/timeline-grouping",
                FileName = "TimelineResourceGroup.razor",
                MetaTitle = "Blazor Scheduler - Timeline Grouping | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Timeline Grouping",
                MetaDescription = "See how the Syncfusion Blazor Timeline Grouping Scheduler arranges resources with API, grouping, and events for detailed scheduling visualization and analysis.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - Date-wise Grouping | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Date-wise Grouping",
                MetaDescription = "See how the Syncfusion Blazor Date-wise Grouping Scheduler organizes events by date using API and events for clear and structured scheduling insights.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule - Hierarchical Grouping | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Hierarchical Grouping",
                MetaDescription = "See how the Syncfusion Blazor Hierarchical Grouping Scheduler structures resources with API and events to manage complex and nested scheduling scenarios.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - Adaptive Grouping | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Adaptive Grouping",
                MetaDescription = "See how the Syncfusion Blazor Scheduler Adaptive Grouping example adjusts layout dynamically with automatic grouping based on screen size and available space.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Examples - Date Header | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Date Header",
                MetaDescription = "See how the Syncfusion Blazor Date Header Scheduler customizes headers with templates, API, events, and formatting to enhance calendar display and usability.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule - Cell Template | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Cell Template",
                MetaDescription = "See how the Syncfusion Blazor Cell Template Scheduler customizes cells with templates, API, events, and styling to improve content display and flexibility.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - Event Template | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Event Template",
                MetaDescription = "See how the Syncfusion Blazor Event Template Scheduler customizes events with templates, API, events, and styling for clearer and improved visualization.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - Tooltip Template | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Tooltip Template",
                MetaDescription = "See how the Syncfusion Blazor Tooltip Template Scheduler shows event details using templates, API, and events to enhance user interaction and clarity.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - Quick Info Template | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Quick Info Template",
                MetaDescription = "See how the Syncfusion Blazor Quick Info Template Scheduler displays popups with templates, API, and events for quick access to event details and insights.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - Field Validation | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Field Validation",
                MetaDescription = "See how the Syncfusion Blazor Field Validation Scheduler applies validation rules with API, events, and error handling for consistent and accurate data entry.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - Editor Template | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Editor Template",
                MetaDescription = "See how the Syncfusion Blazor Editor Template Scheduler customizes forms with templates, API, and events to support flexible appointment editing workflows.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule - External Form Editing | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - External Form Editing",
                MetaDescription = "See how the Syncfusion Blazor External Form Editing Scheduler integrates forms with API, validation, and events for flexible and advanced scheduling workflows.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Examples - Header Rows | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Header Rows",
                MetaDescription = "See how the Syncfusion Blazor Header Rows Scheduler configures headers with API, layout options, and events to improve structure and data readability.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Examples - Timescale | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Timescale",
                MetaDescription = "See how the Syncfusion Blazor Timescale Scheduler customizes time intervals with API, settings, and events for flexible scheduling and better control.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Examples - Context Menu | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Context Menu",
                MetaDescription = "See how the Syncfusion Blazor Context Menu Scheduler adds right-click actions with API, customization, and events for quick event operations and interaction.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Examples - Header Bar | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Header Bar",
                MetaDescription = "See how the Syncfusion Blazor Header Bar Scheduler customizes navigation with API, toolbar controls, and events for intuitive and improved calendar interaction.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Examples - Scroll Time | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Scroll Time",
                MetaDescription = "See how the Syncfusion Blazor Scroll Time Scheduler sets initial scroll position with API and events for faster navigation and quick access to time slots.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Examples - Working Days | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Working Days",
                MetaDescription = "See how the Syncfusion Blazor Working Days Scheduler configures work patterns with API and events for flexible scheduling and efficient calendar management.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule - Working Hours | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Working Hours",
                MetaDescription = "See how the Syncfusion Blazor Working Hours Scheduler defines time ranges with API, settings, and events for accurate scheduling and better time control.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Examples - Hide Non-Working Hours | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Hide Non-Working Hours",
                MetaDescription = "See how the Syncfusion Blazor Hide Non-Working Hours Scheduler filters time slots with API and events for focused scheduling, clarity, and improved usability.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - Cell Dimension | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Cell Dimension",
                MetaDescription = "See how the Syncfusion Blazor Cell Dimension Scheduler customizes cell sizes with API and events to improve layout presentation, spacing, and readability.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - Export to Excel | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Export to Excel",
                MetaDescription = "See how the Syncfusion Blazor Export to Excel Scheduler exports data with API, formatting, and events for reporting, analysis, and efficient sharing workflows.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule - Export and Import ICS | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Export and Import ICS",
                MetaDescription = "See how the Syncfusion Blazor Export and Import ICS Scheduler supports ICS format with API and events for seamless calendar data exchange and integration.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Exporting Examples - Print | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Print",
                MetaDescription = "See how the Syncfusion Blazor Print Scheduler generates calendars with API, layout settings, and events for clean reporting, formatting, and output generation.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - RRule Generator | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - RRule Generator",
                MetaDescription = "See how the Syncfusion Blazor RRule Generator creates recurrence rules with API and events for defining repeating schedules and complex event patterns.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler"
            },
            new Sample
            {
                Name = "Recurrence Rules",
                Category = "Recurrence Editor",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/recurrence-rules",
                FileName = "RecurrenceEditorPopulateRule.razor",
                MetaTitle = "Blazor Scheduler - Recurrence Rules | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Recurrence Rules",
                MetaDescription = "See how the Syncfusion Blazor Recurrence Rules Scheduler configures repeating events with API and events for advanced scheduling and planning control.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler"
            },
            new Sample
            {
                Name = "Clipboard",
                Category = "Miscellaneous",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/clipboard",
                FileName = "Clipboard.razor",
                MetaTitle = "Blazor Schedule Examples - Clipboard | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Clipboard",
                MetaDescription = "See how the Syncfusion Blazor Clipboard Scheduler supports copy and paste with API and events for efficient event handling, updates, and workflow management.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Scheduler - Keyboard Interaction | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Keyboard Interaction",
                MetaDescription = "See how the Syncfusion Blazor Keyboard Interaction Scheduler enables shortcuts with API and events for accessible navigation, usability, and faster interaction.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
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
                MetaTitle = "Blazor Schedule Examples - Events | Schedule Demos | Syncfusion",
                HeaderText = "Blazor Scheduler Example - Events",
                MetaDescription = "See how the Syncfusion Blazor Events Scheduler handles lifecycle actions with API and events for advanced customization and flexible scheduling workflows.",
                CustomCanonicalUrl = "https://www.syncfusion.com/scheduler-sdk/blazor-scheduler",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection { Id = "Default", FileName = "Events.razor" },
                    new SourceCollection { Id = "Data", FileName = "ScheduleData.cs" }
                }
            }
        };

        private static readonly string[] NotificationLimitConcurrentEvent = new string[] { @"The Limit Concurrent Event sample demonstrates how to control the maximum number of events displayed within a single time slot using the MaxEventStack property. When multiple events overlap and exceed the specified limit, a '+N' indicator appears, allowing users to view additional events in a popup window. This feature enhances view clarity and provides flexible control over overlapping event displays in Day, Week, and WorkWeek views with TimeScale enabled." };
        private static readonly string[] NotificationCascadingEvent = new string[] { @"The Cascading Event Editor sample demonstrates how to create a dynamic event editor with dependent dropdowns for floor, room, and staff selections, enhancing the user experience by providing intuitive and accessible controls for managing appointments." };
        private static readonly string[] NotificationActionEvent = new string[] { @"The Event Action Buttons sample enhances the user experience by providing intuitive and accessible controls directly on each event within the scheduler. With clearly labeled buttons for editing, deleting, and viewing details, users can quickly manage their appointments without navigating through complex menus. This streamlined interaction design improves efficiency and usability, allowing users to perform common scheduling tasks with ease and confidence." };
        private static readonly string[] NotificationTaskProgress = new string[] { @"The Task Progress Tracker delivers a unified scheduling and project management experience by seamlessly combining a Timeline Scheduler with real time progress visualization. It enables users to manage tasks efficiently while instantly tracking key metrics such as completion percentage, upcoming deadlines, and overdue tasks through an interactive interface. With automatic synchronization between schedule updates and progress tracking, along with consistent resource based coloring and clear visual summaries, it provides quick insights and informed decision making in a single, cohesive interface." };
        private static readonly string[] NotificationChart = new string[] { @"The Scheduler with Chart delivers a unified planning and analytics experience by seamlessly combining a Timeline Scheduler with real-time data visualization. It enables users to manage schedules efficiently while instantly tracking key metrics such as trip count, vehicle capacity, and longest journeys through an interactive chart. With automatic synchronization between schedule updates and analytics, along with consistent resource-based coloring and clear visual summaries, it provides quick insights and informed decision-making in a single, cohesive interface." };
    }
}