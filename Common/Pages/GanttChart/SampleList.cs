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

        public List<Sample> GanttChart { get; set; } = new List<Sample>{
             new Sample{
                Name = "Overview",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/overview",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Overview | Project Management | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Component Overview",
                MetaDescription = "This Blazor Gantt Chart example demonstrates the comprehensive view of project tasks, timelines, dependencies, and resources. Perfect for visualizing project schedules and tracking progress in an intuitive interface.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Overview",
                        FileName="Overview.razor"
                    },
                    new SourceCollection
                    {
                        Id="Overview",
                        FileName="Overview.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="OverviewRecord",
                        FileName="OverviewData.cs"
                    }
                },
                IsHideInMobile= true
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/default-functionalities",
                MetaTitle = "Gantt Chart Default Functionalities - Syncfusion Demos",
                HeaderText = "Blazor Gantt Chart Example - Default Functionalities",
                MetaDescription = "This example demonstrates the default functionalities in the Blazor Gantt Chart Component. Explore here for more details.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="DefaultFunctionalities.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Editing",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/editing",
                MetaTitle = "Blazor Gantt Chart Editing | Task Modifications | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Task Editing Capabilities",
                MetaDescription = "This Blazor Gantt Chart example demonstrates comprehensive task editing capabilities including add, edit, delete, and drag-and-drop functionalities. Enables real-time project updates with intuitive task management.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Editing",
                        FileName="Editing.razor"
                    },
                    new SourceCollection
                    {
                        Id="EditData",
                        FileName="GanttData.cs"
                    }
                },
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Sorting",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/sorting",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Sorting | Task Organization | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Column Sorting",
                MetaDescription = "This Blazor Gantt Chart example demonstrates task sorting capabilities including multi-column sorting, sort order customization, and programmatic sorting. Helps prioritize and organize project tasks efficiently.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Sorting",
                        FileName="Sorting.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Selection",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/selection",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Selection | Task Focus | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Task Selection",
                MetaDescription = "This Blazor Gantt Chart example demonstrates task selection capabilities including row selection, multiple selection, and selection events. Enables targeted task management and bulk operations on selected items.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Schedule",
                        FileName="Selection.razor"
                    },
                    new SourceCollection
                    {
                        Id="SelectionRecord",
                        FileName="SelectionData.cs"
                    }
                },
            },
            new Sample
            {
                Name = "Airline Tracker",
                Category = "Use Case",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/airline-tracker",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Airline Tracker | Flight Scheduling | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Airline Flight Scheduler",
                MetaDescription = "This Blazor Gantt Chart example demonstrates an airline flight tracking system with scheduled departures, arrivals, and flight durations. Ideal for visualizing airport operations and managing flight schedules.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="AirlineTracker",
                        FileName = "AirlineTracker.razor",
                    },
                    new SourceCollection
                    {
                        Id="AirlineTracker",
                        FileName="AirlineTracker.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="AirlineTracker",
                        FileName="AirlineTrackerData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Digital Marketing",
                Category = "Use Case",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/digital-marketing",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Marketing Planner | Campaign Management | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Digital Marketing Campaign Tracker",
                MetaDescription = "This Blazor Gantt Chart example demonstrates a digital marketing campaign planner with task dependencies, milestones, and campaign timeline visualization. Optimize marketing workflows with comprehensive timeline views.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DigitalMarketing",
                        FileName = "DigitalMarketing.razor",
                   },
                   new SourceCollection
                   {
                       Id="DigitalMarketing",
                       FileName="DigitalMarketing.razor.cs"
                   },
                   new SourceCollection
                   {
                       Id="DigitalMarketing",
                       FileName="DigitalMarketingData.cs"
                   }
                }
            },
            new Sample
            {
                Name = "Human Resource",
                Category = "Use Case",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/human-resource-management",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart HR Management | Resource Allocation | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Human Resource Management",
                MetaDescription = "This Blazor Gantt Chart example demonstrates HR project planning with employee allocation, onboarding processes, and recruitment timelines. Streamline workforce management through visual task assignment.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="HumanResourceManagement",
                        FileName = "HumanResourceManagement.razor",
                    },
                    new SourceCollection
                    {
                        Id="HumanResourceManagement",
                        FileName="HumanResourceManagement.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="HumanResourceManagement",
                        FileName="HumanResourceData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Education Scheduler",
                Category = "Use Case",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/education-scheduler",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Education Planner | Course Scheduling | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Educational Program Scheduler",
                MetaDescription = "This Blazor Gantt Chart example demonstrates an educational program scheduler with course timelines, semester planning, and academic milestones. Optimize academic resource allocation and curriculum planning.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EducationScheduler",
                        FileName = "EducationScheduler.razor",
                    },
                    new SourceCollection
                    {
                        Id="EducationScheduler",
                        FileName="EducationScheduler.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="EducationScheduler",
                        FileName="EducationSchedulerData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/remote-data",
                FileName="RemoteData.razor",
                MetaTitle = "Blazor Gantt Chart Remote Data | API Integration | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Remote Data Binding",
                MetaDescription = "This Blazor Gantt Chart example demonstrates data binding with remote data sources like web APIs and services. Enables integration with backend systems for dynamic project management data.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "DynamicObject Binding",
                Category = "Data Binding",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/dynamic-data",
                FileName="DynamicData.razor",
                MetaTitle = "Blazor Gantt Chart Dynamic Data | Flexible Binding | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - DynamicObject Data Binding",
                MetaDescription = "This Blazor Gantt Chart example demonstrates binding with DynamicObject data type for flexible property access. Support dynamic data structures without fixed schema requirements for versatile data handling.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "ExpandoObject Binding",
                Category = "Data Binding",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/expando-data",
                FileName="ExpandoData.razor",
                MetaTitle = "Blazor Gantt Chart ExpandoObject Binding | Dynamic Properties | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - ExpandoObject Data Binding",
                MetaDescription = "This Blazor Gantt Chart example demonstrates binding with ExpandoObject, enabling dynamic property addition at runtime. Ideal for scenarios where task properties need to be modified on-the-fly.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Observable Collection",
                Category = "Data Binding",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/observable-collection",
                FileName="ObservableBinding.razor",
                MetaTitle = "Blazor Gantt Chart Observable Collection | Real-time Updates | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Observable Collection Binding",
                MetaDescription = "This Blazor Gantt Chart example demonstrates binding with ObservableCollection for automatic UI updates when data changes. Ideal for real-time project tracking with dynamic task updates.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Big Data Set",
                Category = "Data Binding",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/load-on-demand",
                FileName="LoadOnDemand.razor",
                MetaTitle = "Blazor Gantt Chart Large Datasets | Virtualization | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Load On Demand for Large Datasets",
                MetaDescription = "This Blazor Gantt Chart example demonstrates efficient handling of large datasets with load-on-demand capabilities. Optimizes performance by loading only necessary data when scrolling through extensive project plans.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Scheduling Mode",
                Category = "Scheduling Concepts",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/scheduling-mode",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Scheduling Modes | Project Planning | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Task Scheduling Modes",
                MetaDescription = "This Blazor Gantt Chart example demonstrates different scheduling modes including automatic and manual scheduling. Control how tasks are scheduled and dependencies are managed for flexible project planning.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Schedule",
                        FileName="Schedulingmode.razor"
                    },
                    new SourceCollection
                    {
                        Id="ScheduleRecord",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Work Week",
                Category = "Scheduling Concepts",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/work-week",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Work Week | Custom Calendars | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Work Week Configuration",
                MetaDescription = "This Blazor Gantt Chart example demonstrates work week customization for project scheduling. Set working days, non-working days, and custom work hours to accurately reflect team availability and project timelines.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Resource",
                        FileName="WorkWeek.razor"
                    },
                    new SourceCollection
                    {
                        Id="ResourceRecord",
                        FileName="WorkData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Work Time Range",
                Category = "Scheduling Concepts",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/working-time-range",
                MetaTitle = "Blazor Gantt Chart Working Hours | Time Configuration | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Working Time Range Settings",
                MetaDescription = "This Blazor Gantt Chart example demonstrates working time range configuration to specify business hours for project tasks. Define work start and end times for accurate timeline calculations and resource allocation.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WorkTimeRange",
                        FileName="WorkTimeRange.razor"
                    },
                    new SourceCollection
                    {
                        Id="WorkTimeRangeRecord",
                        FileName="WorkTimeRangeData.cs"
                    }
                },
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Holidays",
                Category = "Scheduling Concepts",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/holidays",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Holidays | Calendar Exceptions | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Holiday Configuration",
                MetaDescription = "This Blazor Gantt Chart example demonstrates holiday configuration for project scheduling. Define non-working days, special events, and company holidays to ensure realistic project timelines with automatic schedule adjustments.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Holidays",
                        FileName="Holidays.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Unscheduled Task",
                Category = "Scheduling Concepts",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/unscheduled-task",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Unscheduled Tasks | Pending Items | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Unscheduled Task Management",
                MetaDescription = "This Blazor Gantt Chart example demonstrates handling unscheduled tasks with indefinite start or end dates. Manage pending or backlog items before assigning them to your project timeline for comprehensive task tracking.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Unscheduled",
                        FileName = "UnscheduledTask.razor",
                    },
                    new SourceCollection
                    {
                        Id="UnscheduledData",
                        FileName="UnscheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Baseline",
                Category = "Scheduling Concepts",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/baseline",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Baseline | Schedule Comparison | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Baseline Comparison",
                MetaDescription = "This Blazor Gantt Chart example demonstrates baseline task comparison to track project progress against planned schedules. Visualize schedule variances and easily identify delayed tasks for proactive project management.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Baseline",
                        FileName="Baseline.razor"
                    },
                    new SourceCollection
                    {
                        Id="BaseRecord",
                        FileName="BaseData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Event Markers",
                Category = "Scheduling Concepts",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/eventmarkers",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Event Markers | Timeline Indicators | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Event Marker Visualization",
                MetaDescription = "This Blazor Gantt Chart example demonstrates event markers for highlighting important dates and milestones. Add visual indicators for deadlines, reviews, and key project events for better timeline visualization.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Events",
                        FileName="EventMarkers.razor"
                    },
                    new SourceCollection
                    {
                        Id="EventRecord",
                        FileName="EventData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Critical Path",
                Category = "Scheduling Concepts",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/criticalpath",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Critical Path | Project Timeline | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Critical Path Analysis",
                MetaDescription = "This Blazor Gantt Chart example demonstrates critical path analysis to identify essential tasks that directly impact project completion. Visualize the sequence of tasks that determine the minimum project duration.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Critical",
                        FileName="CriticalPath.razor"
                    },
                    new SourceCollection
                    {
                        Id="CriticalRecord",
                        FileName="GanttData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Timeline API",
                Category = "Timeline",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/timeline",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Timeline API | Date Range Customization | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Timeline API Customization",
                MetaDescription = "This Blazor Gantt Chart example demonstrates timeline API usage for customizing time scales and date ranges. Control timeline units, date formatting, and time span visualization for optimized project views.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TimeTask",
                        FileName = "Timeline.razor",
                    },
                    new SourceCollection
                    {
                        Id="TimeRecord",
                        FileName="TimelineData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Zooming",
                Category = "Timeline",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/zooming",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Zooming | Timeline Navigation | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Timeline Zooming",
                MetaDescription = "This Blazor Gantt Chart example demonstrates timeline zooming capabilities for flexible project visualization. Switch between day, week, month, and year views to adjust detail levels based on project scope and duration.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Zoom",
                        FileName = "Zooming.razor",
                    },
                    new SourceCollection
                    {
                        Id="ZoomRecord",
                        FileName="ZoomingData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Column Template",
                Category = "Columns",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/column-template",
                MetaTitle = "Blazor Gantt Chart Column Templates | Custom Cells | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Custom Column Templates",
                MetaDescription = "This Blazor Gantt Chart example demonstrates column templates for custom cell content. Create rich column visualizations with icons, progress bars, and custom formatting for enhanced data presentation.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnTemplate",
                        FileName="ColumnTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="ColumnTemplateRecord",
                        FileName="ColumnTemplateData.cs"
                    }
                },
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Reorder",
                Category = "Columns",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/column-reordering",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Column Reordering | Layout Customization | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Column Reordering",
                MetaDescription = "This Blazor Gantt Chart example demonstrates column reordering functionality. Drag and reposition columns to customize the grid layout and prioritize the most relevant task information for your project view.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnReordering",
                        FileName="ColumnReordering.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Resizing",
                Category = "Columns",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/column-resizing",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnResizing",
                        FileName="ColumnResizing.razor"
                    },
                    new SourceCollection
                    {
                        Id="ColumnResizingRecord",
                        FileName="DefaultData.cs"
                    }
                },
                FileName="ColumnResizing.razor",
                MetaTitle = "Blazor Gantt Chart Column Resizing | Width Adjustment | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Column Width Resizing",
                MetaDescription = "This Blazor Gantt Chart example demonstrates column resizing capabilities. Adjust column widths to accommodate data, optimize space utilization, and create a personalized view of project information.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Column Menu",
                Category = "Columns",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/column-menu",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Column Menu | Quick Actions | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Column Menu Integration",
                MetaDescription = "This Blazor Gantt Chart example demonstrates column menu functionality. Access sorting, filtering, and column visibility options through a convenient dropdown menu for efficient task data management.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnMenu",
                        FileName="ColumnMenu.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Resource Allocation",
                Category = "Resource",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/resource-allocation",
                Type = SampleType.None, 
                MetaTitle = "Blazor Gantt Chart Resource Allocation | Staff Assignment | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Resource Allocation Management",
                MetaDescription = "This Blazor Gantt Chart example demonstrates resource allocation for tasks. Assign team members, track workloads, and visualize resource distribution across project tasks for optimal workforce management.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Resource",
                        FileName="Resourceallocation.razor"
                    },
                    new SourceCollection
                    {
                        Id="ResourceRecord",
                        FileName="ResourceModel.cs"
                    }
                },
            },
            new Sample
            {
                Name = "Resource View",
                Category = "Resource",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/resource-view",
                Type = SampleType.None,
                FileName="ResourceView.razor",
                MetaTitle = "Blazor Gantt Chart Resource View | Team Scheduling | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Resource-Centric View",
                MetaDescription = "This Blazor Gantt Chart example demonstrates a resource-centric visualization of project tasks. View assignments by employee or resource to evaluate workload distribution and identify resource conflicts.",
            },
             new Sample
            {
                Name = "Resource Multi Taskbar",
                Category = "Resource",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/multi-taskbar",
                MetaTitle = "Blazor Gantt Chart Multi-Taskbar | Resource Tasks | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Multiple Taskbars Per Resource",
                MetaDescription = "This Blazor Gantt Chart example demonstrates multiple taskbars per resource row. Visualize concurrent assignments and parallel tasks for each team member to identify overallocations and schedule conflicts.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ResourceMultiTaskbar",
                        FileName="MultiTaskbar.razor",
                    },
                    new SourceCollection
                    {
                        Id="MultiTaskbarRecord",
                        FileName="MultiTaskbarData.cs"
                    }
                },
                
                Type = SampleType.None,
            },
             new Sample
            {
                Name = "Header Template",
                Category = "Templates",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/header-template",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Header Template | Custom Headers | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Custom Header Templates",
                MetaDescription = "This Blazor Gantt Chart example demonstrates header template customization. Create rich header designs with custom formatting, graphics, and interactive elements for an enhanced timeline visualization.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="HeaderTemplate",
                        FileName="GanttHeaderTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="TaskbarRecord",
                        FileName="ResourceModel.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Taskbar Template",
                Category = "Templates",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/taskbar-template",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Taskbar Template | Custom Task Visuals | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Custom Taskbar Visualization",
                MetaDescription = "This Blazor Gantt Chart example demonstrates taskbar template customization. Create visually distinct task representations with custom styling, progress indicators, and content for clearer project visualization.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TaskbarTemplate",
                        FileName="GanttTaskbarTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="TaskbarRecord",
                        FileName="TaskbarTemplateData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Tooltip Template",
                Category = "Templates",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/tooltip-template",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Tooltip Template | Task Details | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Custom Tooltip Templates",
                MetaDescription = "This Blazor Gantt Chart example demonstrates tooltip template customization. Display rich task details with formatted content, progress indicators, and contextual information when hovering over tasks.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TooltipTemplate",
                        FileName="TooltipTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="TooltipTemplateRecord",
                        FileName="TooltipTemplateData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Scrolling",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/virtual-scroll",
                FileName="VirtualScroll.razor",
                MetaTitle = "Blazor Gantt Chart Virtual Scrolling | Performance Optimization | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Virtual Scrolling for Large Datasets",
                MetaDescription = "This Blazor Gantt Chart example demonstrates virtual scrolling for handling large datasets efficiently. Render only visible rows for optimal performance while managing extensive project plans with numerous tasks."
            },
            new Sample
            {
                Name = "Frozen Columns",
                Category = "Scrolling",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/frozen-column",
                MetaTitle = "Blazor Gantt Chart Frozen Columns | Pinned Fields | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Column Freezing",
                MetaDescription = "This Blazor Gantt Chart example demonstrates frozen columns functionality. Pin important columns to keep them visible while horizontally scrolling through extensive task data fields for improved usability.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FrozenColumn",
                        FileName="FrozenColumn.razor",
                    },
                    new SourceCollection
                    {
                        Id="FrozenColumnRecord",
                        FileName="GanttData.cs"
                    }
                },
                Type = SampleType.None,
                IsHideInMobile= true,
               
            },
            new Sample
            {
                Name = "Row Drag and Drop",
                Category = "Rows",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/row-drag-and-drop",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Row Reordering | Task Prioritization | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Row Drag and Drop",
                MetaDescription = "This Blazor Gantt Chart example demonstrates row drag and drop functionality. Reorder tasks and subtasks through intuitive drag operations to prioritize work items and reorganize your project structure.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowDragAndDrop",
                        FileName="RowDragAndDrop.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Row Height",
                Category = "Rows",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/row-height",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Row Height | Visual Density | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Row Height Customization",
                MetaDescription = "This Blazor Gantt Chart example demonstrates row height customization options. Adjust task row heights to control visual density and optimize screen space based on project complexity and display preferences.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowHeight",
                        FileName="RowHeight.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = " Default Filtering",
                Category = "Filtering",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/filtering",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Filtering | Task Filtering | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Basic Filtering",
                MetaDescription = "This Blazor Gantt Chart example demonstrates basic filtering capabilities. Filter tasks by various criteria to focus on specific aspects of your project and simplify complex project plans for targeted analysis.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Filtering",
                         FileName = "Filtering.razor",
                    },
                    new SourceCollection
                    {
                        Id="Filter",
                        FileName="FilterData.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Advanced Filtering",
                Category = "Filtering",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/advanced-filtering",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Advanced Filtering | Complex Queries | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Advanced Filtering Options",
                MetaDescription = "This Blazor Gantt Chart example demonstrates advanced filtering with complex conditions and operators. Create sophisticated filter expressions to isolate specific task subsets for detailed project analysis.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                         Id="AdvancedFiltering",
                         FileName = "AdvancedFiltering.razor",
                    },
                    new SourceCollection
                    {
                        Id="AdvancedFiltering",
                        FileName="FilterData.cs"
                    }
                },
            },
            new Sample
            {
                Name = "Default Exporting",
                Category = "Exporting",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/exporting",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Exporting | Project Sharing | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Basic Export Options",
                MetaDescription = "This Blazor Gantt Chart example demonstrates basic exporting capabilities. Export project schedules to various formats like PDF, Excel and CSV for sharing, reporting, and documentation purposes.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ExportTask",
                        FileName = "Exporting.razor",
                    },
                    new SourceCollection
                    {
                        Id="ExportRecord",
                        FileName="GanttData.cs"
                    }
                },
            },
            new Sample
            {
                Name = "Advanced Exporting",
                Category = "Exporting",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/advanced-exporting",
                Type = SampleType.None,
                FileName = "AdvancedExporting.razor",
                MetaTitle = "Blazor Gantt Chart Advanced Export | Customization Options | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Advanced Export Customization",
                MetaDescription = "This Blazor Gantt Chart example demonstrates advanced export customization. Control page setup, header/footer content, and formatting options when exporting to various formats for professional project documentation.",
            },
             new Sample
            {
                Name = "Split Tasks",
                Category = "Miscellaneous",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/split-tasks",
                Type = SampleType.None,
                FileName="SplitTasks.razor",
                MetaTitle = "Blazor Gantt Chart Split Tasks | Segmented Work | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Split Task Management",
                MetaDescription = "This Blazor Gantt Chart example demonstrates split task functionality. Handle non-continuous work by dividing tasks into multiple segments to represent interruptions or phased implementation in project schedules.",
            },
			new Sample
            {
                Name = "Responsive",
                Category = "Miscellaneous",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/ganttresponsive",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Responsive Design | Mobile Friendly | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Responsive Layout",
                MetaDescription = "This Blazor Gantt Chart example demonstrates responsive design capabilities. Automatically adapt to different screen sizes and devices while maintaining usability for project management on desktop and mobile platforms.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="GanttResponsive",
                        FileName="GanttResponsive.razor"
                    },
                    new SourceCollection
                    {
                        Id="GanttResponsiveRecord",
                        FileName="WorkData.cs"
                    }
                },
            },
            
#if !(WASM)
            new Sample
            {
                Name = "Persist State",
                Category = "Miscellaneous",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/persistence",
                MetaTitle = "Blazor Gantt Chart State Persistence | User Preferences | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - State Persistence",
                MetaDescription = "This Blazor Gantt Chart example demonstrates state persistence capabilities. Save and restore user preferences like column width, sort order, and filtering to provide consistent user experience across sessions.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="PersistState",
                        FileName="Persistence.razor",
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                },
            },
#endif
            new Sample
            {
                Name = "Context Menu",
                Category = "Miscellaneous",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/context-menu",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Context Menu | Quick Actions | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Context Menu Integration",
                MetaDescription = "This Blazor Gantt Chart example demonstrates context menu functionality. Access common operations like add, edit, delete through a right-click menu for faster task management and improved user experience.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ContextMenu",
                        FileName = "ContextMenu.razor",
                    },
                    new SourceCollection
                    {
                        Id="ContextMenuData",
                        FileName="GanttData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Clipboard",
                Category = "Miscellaneous",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/clipboard",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Clipboard | Copy Paste Tasks | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Clipboard Operations",
                MetaDescription = "This Blazor Gantt Chart example demonstrates clipboard functionality. Copy and paste task data within the chart or to external applications for efficient task creation and data transfer between projects.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Clipboard",
                        FileName = "Clipboard.razor",
                    },
                    new SourceCollection
                    {
                        Id="Clipboard",
                        FileName="DefaultData.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Miscellaneous",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/keyboard-navigation",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Keyboard Navigation Support",
                MetaDescription = "This Blazor Gantt Chart example demonstrates keyboard navigation capabilities. Navigate, select, and edit project tasks using keyboard shortcuts for improved accessibility and productivity.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Keyboard",
                        FileName="KeyboardNavigation.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }, 
                IsHideInMobile= true,
            },
        };
    }
}
