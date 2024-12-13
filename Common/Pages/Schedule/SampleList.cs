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
        public List<Sample> Scheduler { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Scheduler",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/overview",
                FileName = "Overview.razor",
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Scheduler",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/default-functionalities",
                FileName = "Default.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Default.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Holiday Calendar",
                Category = "Product Use Case",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/holiday-Calendar",
                FileName = "HolidayCalendar.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="HolidayCalendar.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/local-data",
                FileName = "LocalData.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="LocalData.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/remote-data",
                FileName = "RemoteData.razor"
            },
            new Sample
            {
                Name = "Custom Binding",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/custom-binding",
                FileName = "CustomBinding.razor"
            },
            new Sample
            {
                Name = "Observable Collection",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/observable-binding",
                FileName = "ObservableCollection.razor"
            },
            new Sample
            {
                Name = "DynamicObject Binding",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/dynamicobject",
                FileName = "DynamicObject.razor"
            },
            new Sample
            {
                Name = "ExpandoObject Binding",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/expandoobject",
                FileName = "SchedulerExpandoObject.razor"
            },
            new Sample
            {
                Name = "Recurring Events",
                Category = "Appointments",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/recurrence-events",
                FileName = "RecurrenceEvents.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="RecurrenceEvents.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="BlockEvents.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ReadonlyEvents.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Timezone.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="SearchEvents.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="InlineEditing.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Overlap Events",
                Category = "Appointments",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/overlap-events",
                Type = SampleType.New,
                NotificationDescription = new string[]{ @"Demonstrated how to effectively restrict overlapping appointments within the same time range, ensuring a clear and organized schedule view for improved time management and user experience." },
                FileName = "OverlapEvents.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="OverlapEvents.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Reminder.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ExternalDragDrop.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="DragDrop.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Drag Between Schedulers",
                Category = "Drag and Drop",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/drag-between-schedulers",
                Type = SampleType.New,
                NotificationDescription = new string[]{ @"Showcased the ability to drag and drop events seamlessly between multiple Scheduler instances, enabling effortless event transfer and enhancing scheduling flexibility across different Schedulers." },
                IsHideInMobile = true,
                FileName = "DragBetweenSchedulers.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="DragBetweenSchedulers.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Drag Events From Grid",
                Category = "Drag and Drop",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/grid-to-schedule",
                Type = SampleType.New,
                NotificationDescription = new string[] { @"Demonstrated the seamless integration of DataGrid and Scheduler components by enabling drag-and-drop functionality between them, allowing for efficient event creation and management across different data visualization formats." },
                FileName = "GridToSchedule.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="GridToSchedule.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Scrolling",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/virtual-scrolling",
                FileName = "VirtualScrolling.razor"
            },
            new Sample
            {
                Name = "Virtual Mask",
                Category = "Scrolling",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/virtual-mask",
                FileName = "VirtualMask.razor"
            },
            new Sample
            {
                Name = "Data Virtualization",
                Category = "Scrolling",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/data-virtualization",
                FileName = "DataVirtualization.razor"
            },
            new Sample
            {
                Name = "Basic Views",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/basic-views",
                FileName = "Views.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Views.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Timeline.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Agenda.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="MonthAgenda.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="IndividualViewSettings.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ExtendedViews.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Year View",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/year-view",
                FileName = "Year.razor"
            },
            new Sample
            {
                Name = "Custom Month View",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/custom-month-view",
                FileName = "CustomMonthView.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="CustomMonthView.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="TimelineResource.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
            },
            new Sample
            {
                Name = "Resources",
                Category = "Multiple Resources",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/resource",
                FileName = "Resource.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Resource.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="GroupEditing.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="GroupCustomWorkdays.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
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
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="AddRemoveResources.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Adaptive Rows",
                Category = "Multiple Resources",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/adaptive-rows",
                FileName = "AdaptiveRows.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="AdaptiveRows.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Horizontal Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/horizontal-grouping",
                FileName = "Group.razor"
            },
            new Sample
            {
                Name = "Timeline Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/timeline-grouping",
                FileName = "TimelineResourceGroup.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="TimelineResourceGroup.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Date-wise Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/date-wise-grouping",
                FileName = "GroupByDate.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="GroupByDate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Hierarchical Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/hierarchical-grouping",
                FileName = "GroupByChild.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="GroupByChild.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
               Name = "Adaptive Grouping",
               Category = "Resource Grouping",
               Directory = "Schedule/Scheduler",
               Url = "scheduler/adaptive-grouping",
               FileName = "AdaptiveGrouping.razor",
               IsHideInMobile = true,
               SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="AdaptiveGrouping.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Date Header",
                Category = "Templates",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/date-header",
                FileName = "DateHeader.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="DateHeader.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Cell Template",
                Category = "Templates",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/cell-template",
                FileName = "CustomCell.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="CustomCell.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Event Template",
                Category = "Templates",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/event-template",
                FileName = "AppointmentTemplate.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="AppointmentTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Tooltip Template",
                Category = "Templates",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/tooltip-template",
                FileName = "Tooltip.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Tooltip.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Quick Info Template",
                Category = "Templates",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/quick-info-template",
                FileName = "QuickInfoTemplate.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="QuickInfoTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Field Validation",
                Category = "Editor Window",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/field-validation",
                FileName = "EditorValidation.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="EditorValidation.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Editor Template",
                Category = "Editor Window",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/editor-template",
                FileName = "EditorPopupTemplate.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="EditorPopupTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "External Form Editing",
                Category = "Editor Window",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/external-form-editing",
                FileName = "ExternalFormEditing.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ExternalFormEditing.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Header Rows",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/header-rows",
                FileName = "HeaderRows.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="HeaderRows.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Timescale",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/time-scale",
                FileName = "Timescale.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Timescale.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Context Menu",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/context-menu",
                FileName = "ContextMenu.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ContextMenu.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Header Bar",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/header-bar",
                FileName = "HeaderBar.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="HeaderBar.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
             new Sample
             {
                 Name = "Scroll Time",
                 Category = "Customization",
                 Directory = "Schedule/Scheduler",
                 Url = "scheduler/scroll-time",
                 FileName = "ScrollTime.razor",
                 SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ScrollTime.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
             },
            new Sample
            {
                Name = "Working Days",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/working-days",
                FileName = "WorkDays.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="WorkDays.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
               Name = "Working Hours",
               Category = "Customization",
               Directory = "Schedule/Scheduler",
               Url = "scheduler/working-hours",
               FileName = "WorkHours.razor",
               SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="WorkHours.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Hide Non-Working Hours",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/hide-non-working-hours",
                FileName = "DayHourLimit.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="DayHourLimit.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Cell Dimension",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/cell-dimensions",
                FileName = "CellDimensions.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="CellDimensions.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Export to Excel",
                Category = "Exporting",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/export-to-excel",
                FileName = "ExcelExport.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="ExcelExport.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
               Name = "Export and Import ICS",
               Category = "Exporting",
               Directory = "Schedule/Scheduler",
               Url = "scheduler/export-and-import-ics",
               FileName = "CalendarExportImport.razor",
               SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="CalendarExportImport.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
               Name = "Print",
               Category = "Exporting",
               Directory = "Schedule/Scheduler",
               Url = "scheduler/print",
               FileName = "Print.razor",
               IsHideInMobile = true,
               SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Print.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
               Name = "RRule Generator",
               Category = "Recurrence Editor",
               Directory = "Schedule/Scheduler",
               Url = "scheduler/recurrence-editor-rrule-generator",
               FileName = "RecurrenceRuleGenerator.razor"
            },
            new Sample
            {
                Name = "Recurrence Rules",
                Category = "Recurrence Editor",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/recurrence-rules",
                FileName = "RecurrenceEditorPopulateRule.razor"
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Miscellaneous",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/keyboard-interaction",
                FileName = "KeyboardInteraction.razor",
                IsHideInMobile = true,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="KeyboardInteraction.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Events",
                Category = "Miscellaneous",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/events",
                FileName = "Events.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="Events.razor"
                    },
                    new SourceCollection
                    {
                        Id="Data",
                        FileName="ScheduleData.cs"
                    }
                }
            }
        };
    }
}
