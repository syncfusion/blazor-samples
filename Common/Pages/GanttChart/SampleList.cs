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

        public List<Sample> GanttChart { get; set; } = new List<Sample>{
             new Sample{
                Name = "Overview",
                Category = "Gantt Chart",
                Directory = "GanttChart",
                Url = "gantt-chart/overview",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Overview | Project Management | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Overview",
                MetaDescription = "This Blazor Gantt Chart demo shows the comprehensive view of project tasks, timelines, dependencies, and resources. Perfect for visualizing project schedules.",
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
                        Id="Overview",
                        FileName="Overview.razor.css"
                    },
                    new SourceCollection
                    {
                        Id="OverviewRecord",
                        FileName="Data/OverviewData.cs"
                    }
                },
                IsHideInMobile= true
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Gantt Chart",
                Directory = "GanttChart",
                Url = "gantt-chart/default-functionalities",
                MetaTitle = "Gantt Chart Default Functionalities - Syncfusion Demos",
                HeaderText = "Blazor Gantt Chart Example - Default Functionalities",
                MetaDescription = "This Blazor Gantt Chart demo shows default functionalities. Click here to explore its features in detail and better understand its comprehensive capabilities.",
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
                        Id="Default",
                        FileName="DefaultFunctionalities.razor.css"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="Data/DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Editing",
                Category = "Gantt Chart",
                Directory = "GanttChart",
                Url = "gantt-chart/editing",
                MetaTitle = "Blazor Gantt Chart Editing | Task Modifications | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Task Editing Capabilities",
                MetaDescription = "This Blazor Gantt Chart example demonstrates the comprehensive task editing capabilities including add, edit, delete, and drag-and-drop functionalities.",
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
                        FileName="Data/GanttData.cs"
                    }
                },
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Sorting",
                Category = "Gantt Chart",
                Directory = "GanttChart",
                Url = "gantt-chart/sorting",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Sorting | Task Organization | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Column Sorting",
                MetaDescription = "This Blazor Gantt Chart example demonstrates task sorting capabilities including multi-column sorting, sort order customization, and programmatic sorting.",
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
                        FileName="Data/DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Selection",
                Category = "Gantt Chart",
                Directory = "GanttChart",
                Url = "gantt-chart/selection",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Selection | Task Focus | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Task Selection",
                MetaDescription = "Blazor Gantt Chart demo shows task selection capabilities including row selection, multiple selection and selection events and enables targeted task management.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Schedule",
                        FileName="Selection.razor"
                    },
					new SourceCollection
                    {
                        Id="Schedule",
                        FileName="Selection.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="SelectionRecord",
                        FileName="Data/SelectionData.cs"
                    }
                },
            },
            #if SERVER
            new Sample
            {
                Name = "Smart Progress Predictor",
                Category = "Smart AI Solutions",
                Directory = "AISamples/GanttChart",
                Url = "gantt-chart/ai-progress-predictor",
                FileName = "ProgressPrediction.razor",
                MetaTitle = "Gantt Chart Progress Predictor - Syncfusion AI Demos",
                HeaderText = "Blazor Gantt Chart Example - Smart Progress Predictor",
                MetaDescription = "This Blazor Gantt Chart demo uses AI to predict milestone completion and project end dates, also visualizing the future events to improve planning accuracy.",
                NotificationDescription = new string[]{ @" This demo shows the smart progress prediction in Gantt Chart." },
                Type = SampleType.AI
            },
            new Sample
            {
                Name = "Smart Resource Allocation",
                Category = "Smart AI Solutions",
                Directory = "AISamples/GanttChart",
                Url = "gantt-chart/ai-resource-manager",
                FileName = "ResourceOverallocation.razor",
                MetaTitle = "Gantt Chart Resource Allocation - Syncfusion AI Demos",
                HeaderText = "Blazor Gantt Chart Example - Smart Resource Allocation",
                MetaDescription = "This Blazor Gantt Chart demo showcases AI-powered resource reallocation that detects overallocation and optimizes task distribution for balanced workloads.",
                NotificationDescription = new string[]{ @" This demo shows the smart resource allocation AI feature in Gantt Chart." },
                Type = SampleType.AI
            },
#endif
            new Sample
            {
                Name = "Airline Tracker",
                Category = "Use Case",
                Directory = "GanttChart",
                Url = "gantt-chart/airline-tracker",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Airline Tracker | Flight Scheduling | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Airline Flight Scheduler",
                MetaDescription = "Blazor Gantt Chart demo shows an airline flight tracking system with scheduled departures, arrivals, flight durations. Ideal for visualizing airport operations.",
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
                        FileName="AirlineTracker.razor.css"
                    },
                    new SourceCollection
                    {
                        Id="AirlineTracker",
                        FileName="Data/AirlineTrackerData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Digital Marketing",
                Category = "Use Case",
                Directory = "GanttChart",
                Url = "gantt-chart/digital-marketing",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Marketing | Campaign Management | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Digital Marketing Campaign Tracker",
                MetaDescription = "This Blazor Gantt Chart example demonstrates a digital marketing campaign planner with task dependencies, milestones, and campaign timeline visualization.",
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
                       FileName="DigitalMarketing.razor.css"
                   },
                   new SourceCollection
                   {
                       Id="DigitalMarketing",
                       FileName="Data/DigitalMarketingData.cs"
                   }
                }
            },
            new Sample
            {
                Name = "Human Resource",
                Category = "Use Case",
                Directory = "GanttChart",
                Url = "gantt-chart/human-resource-management",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart HR Management | Resource Allocation | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Human Resource Management",
                MetaDescription = "This Blazor GanttChart demo shows HR project planning with employee allocation, onboarding processes, recruitment timelines and streamline workforce management.",
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
                        FileName="HumanResourceManagement.razor.css"
                    },
                    new SourceCollection
                    {
                        Id="HumanResourceManagement",
                        FileName="Data/HumanResourceData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Education Scheduler",
                Category = "Use Case",
                Directory = "GanttChart",
                Url = "gantt-chart/education-scheduler",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Education Planner | Course Scheduling | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Educational Program Scheduler",
                MetaDescription = "This Blazor Gantt Chart example demonstrates an educational program schedulers with the course timelines, semester plannings, and academic milestones.",
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
                        FileName="EducationScheduler.razor.css"
                    },
                    new SourceCollection
                    {
                        Id="EducationScheduler",
                        FileName="Data/EducationSchedulerData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "GanttChart",
                Url = "gantt-chart/remote-data",                
                MetaTitle = "Blazor Gantt Chart Remote Data | API Integration | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Remote Data Binding",
                MetaDescription = "Blazor Gantt Chart demo shows data binding with remote data sources like web APIs and services. Enables integration with backend systems for management data.",
                Type = SampleType.None,
				SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RemoteData",
                        FileName = "RemoteData.razor",
                    },
					new SourceCollection
                    {
                        Id="RemoteData",
                        FileName = "RemoteData.razor.cs",
                    },
				}
            },
            new Sample
            {
                Name = "DynamicObject Binding",
                Category = "Data Binding",
                Directory = "GanttChart",
                Url = "gantt-chart/dynamic-data",                
                MetaTitle = "Blazor Gantt Chart Dynamic Data | Flexible Binding | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - DynamicObject Data Binding",
                MetaDescription = "Blazor GanttChart demo shows binding with DynamicObject data type for flexible property access. Support dynamic data structure without fixed schema requirement.",
                Type = SampleType.None,
				SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DynamicData",
                        FileName = "DynamicData.razor",
                    },
					new SourceCollection
                    {
                        Id="DynamicData",
                        FileName = "DynamicData.razor.cs",
                    },
				}
            },
            new Sample
            {
                Name = "ExpandoObject Binding",
                Category = "Data Binding",
                Directory = "GanttChart",
                Url = "gantt-chart/expando-data",                
                MetaTitle = "Blazor Gantt ExpandoObject Binding | Dynamic Properties | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - ExpandoObject Data Binding",
                MetaDescription = "This sample demonstrates the usage of ExpandoObject (dynamic) data binding with CRUD operations and sorting functionalities in the Blazor Gantt component.",
                Type = SampleType.None,
				SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ExpandoData",
                        FileName = "ExpandoData.razor",
                    },
					new SourceCollection
                    {
                        Id="ExpandoData",
                        FileName = "ExpandoData.razor.cs",
                    },
				}
            },
            new Sample
            {
                Name = "Observable Collection",
                Category = "Data Binding",
                Directory = "GanttChart",
                Url = "gantt-chart/observable-collection",                
                MetaTitle = "Blazor Gantt Observable Collection | Real-time Updates | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Observable Collection Binding",
                MetaDescription = "Blazor GanttChart demo shows binding with ObservableCollection for automatic UI updates when data changes. Real-time project tracking with dynamic task updates.",
                Type = SampleType.None,
				SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ObservableBinding",
                        FileName = "ObservableBinding.razor",
                    },
                    new SourceCollection
                    {
                        Id="ObservableBinding",
                        FileName = "ObservableBinding.razor.cs",
                    },
                    new SourceCollection
                    {
                        Id="ObservableBinding",
                        FileName = "Data/ObservableBindingData.cs",
                    },
                }
            },
            new Sample
            {
                Name = "Big Data Set",
                Category = "Data Binding",
                Directory = "GanttChart",
                Url = "gantt-chart/load-on-demand",
                FileName="LoadOnDemand.razor",
                MetaTitle = "Blazor Gantt Chart Large Datasets | Virtualization | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Load On Demand for Large Datasets",
                MetaDescription = "This Blazor Gantt Chart demo shows efficient handling of large datasets using load-on-demand capabilities, enhancing performance by loading only needed data.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Scheduling Mode",
                Category = "Scheduling Concepts",
                Directory = "GanttChart",
                Url = "gantt-chart/scheduling-mode",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Scheduling Modes | Project Planning | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Task Scheduling Modes",
                MetaDescription = "Blazor Gantt Chart demo shows scheduling modes, such as automatic and manual. Seamlessly manage task schedule and dependencies for adaptable project planning.",
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
                        FileName="Data/ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Work Week",
                Category = "Scheduling Concepts",
                Directory = "GanttChart",
                Url = "gantt-chart/work-week",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Work Week | Custom Calendars | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Work Week Configuration",
                MetaDescription = "Blazor Gantt Chart demo shows how to set working days, non-working days, and custom work hours to accurately reflect team availability and project timelines.",
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
                        FileName="Data/WorkData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Work Time Range",
                Category = "Scheduling Concepts",
                Directory = "GanttChart",
                Url = "gantt-chart/working-time-range",
                MetaTitle = "Blazor Gantt Chart Working Hours | Time Configuration | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Working Time Range Settings",
                MetaDescription = "Blazor Gantt Chart demo configures working time ranges to define business hours for tasks, ensuring precise timeline calculations and resource allocation.",
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
                        FileName="Data/WorkTimeRangeData.cs"
                    }
                },
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Holidays",
                Category = "Scheduling Concepts",
                Directory = "GanttChart",
                Url = "gantt-chart/holidays",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Holidays | Calendar Exceptions | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Holiday Configuration",
                MetaDescription = "Blazor GanttChart demo shows how to define non-working days, special events, and company holidays to ensure realistic project timelines with automatic schedule.",
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
                        FileName="Data/DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Unscheduled Task",
                Category = "Scheduling Concepts",
                Directory = "GanttChart",
                Url = "gantt-chart/unscheduled-task",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Unscheduled Tasks | Pending Items | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Unscheduled Task Management",
                MetaDescription = "Blazor Gantt Chart demo handles unscheduled tasks with indefinite dates, allows to manage backlog item effectively before integrating into project timelines.",
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
                        FileName="Data/UnscheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Baseline",
                Category = "Scheduling Concepts",
                Directory = "GanttChart",
                Url = "gantt-chart/baseline",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Baseline | Schedule Comparison | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Baseline Comparison",
                MetaDescription = "This sample visualizes the complete service schedule for a car. Baselines are enabled to view the deviation between the planned dates and actual dates.",
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
                        FileName="Data/BaseData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Event Markers",
                Category = "Scheduling Concepts",
                Directory = "GanttChart",
                Url = "gantt-chart/eventmarkers",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Event Markers | Timeline Indicators | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Event Marker Visualization",
                MetaDescription = "Blazor GanttChart demo shows event markers for highlighting important dates and milestones. Add visual indicators for deadlines, reviews, key project events.",
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
                        FileName="Data/EventData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Timezone",
                Category = "Scheduling Concepts",
                Directory = "GanttChart",
                Url = "gantt-chart/timezone",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Timezone Support | Global Scheduling | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Timezone",
                MetaDescription = "This Syncfusion Blazor GanttChart Timezone Support example demonstrates precise task scheduling across regions, ensuring accurate timelines in global projects.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Timezone",
                        FileName = "Timezone.razor"
                    },
					new SourceCollection
                    {
                        Id = "Timezone",
                        FileName = "Timezone.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id = "TimezoneRecord",
                        FileName = "Data/TimezoneData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Critical Path",
                Category = "Scheduling Concepts",
                Directory = "GanttChart",
                Url = "gantt-chart/criticalpath",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Critical Path | Project Timeline | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Critical Path Analysis",
                MetaDescription = "Blazor GanttChart demo shows critical path analysis to identify the tasks that directly impact project completion and determine the minimum project duration.",
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
                        FileName="Data/CriticalPathData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Timeline API",
                Category = "Timeline",
                Directory = "GanttChart",
                Url = "gantt-chart/timeline",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Timeline API | Custom Date Range | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Timeline API Customization",
                MetaDescription = "Blazor GanttChart demo shows timeline API usage for customizing time scale and date ranges. Control timeline unit, date formatting, and time span visualization.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TimeTask",
                        FileName = "Timeline.razor",
                    },
					new SourceCollection
                    {
                        Id="TimeTask",
                        FileName = "Timeline.razor.cs",
                    },
                    new SourceCollection
                    {
                        Id="TimeRecord",
                        FileName="Data/TimelineData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Zooming",
                Category = "Timeline",
                Directory = "GanttChart",
                Url = "gantt-chart/zooming",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Zooming | Timeline Navigation | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Timeline Zooming",
                MetaDescription = "This Blazor Gantt Chart demo shows timeline zooming capabilities for flexible project. Switch between day, week, month, and year views to adjust detail levels.",
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
                        FileName="Data/ZoomingData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Column Validation",
                Category = "Columns",
                Directory = "GanttChart",
                Type = SampleType.New,
                Url = "gantt-chart/column-validation",
                MetaTitle = "Blazor Gantt Chart Column Validation | Data Validation | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Column Validation",
                MetaDescription = "This Blazor Gantt Chart demo shows column validation in cell editing and add/edit dialogs, enforcing required, range, and format rules with clear errors.",
                NotificationDescription = new string[]
                {
                    @"The sample has been added to demonstrate the Column Validation feature in the Gantt Chart."
                },
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "ColumnValidation",
                        FileName = "ColumnValidation.razor"
                    },
                    new SourceCollection
                    {
                        Id = "ColumnValidation",
                        FileName = "ColumnValidation.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id = "ColumnValidation",
                        FileName = "ColumnValidation.razor.css"
                    },
                    new SourceCollection
                    {
                        Id = "ColumnValidationRecord",
                        FileName ="Data/ColumnValidationData.cs"
                    },
                    new SourceCollection
                    {
                        Id = "ColumnValidator",
                        FileName ="Data/ColumnValidator.cs"
                    }
                },
            },
            new Sample
            {
                Name = "Column Template",
                Category = "Columns",
                Directory = "GanttChart",
                Url = "gantt-chart/column-template",
                MetaTitle = "Blazor Gantt Chart Column Templates | Custom Cells | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Custom Column Templates",
                MetaDescription = "This Blazor Gantt Chart demo shows column templates for custom cell content. Create rich column visualizations with icons, progress bars, and custom formatting.",
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
                        FileName="Data/ColumnTemplateData.cs"
                    }
                },
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Reorder",
                Category = "Columns",
                Directory = "GanttChart",
                Url = "gantt-chart/column-reordering",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Column Reordering | Custom Layout | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Column Reordering",
                MetaDescription = "Blazor Gantt Chart demo shows column reordering functionality. Drag and reposition columns to customize the grid layout and prioritize the most relevant task.",
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
                        FileName="Data/DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Resizing",
                Category = "Columns",
                Directory = "GanttChart",
                Url = "gantt-chart/column-resizing",
                FileName="ColumnResizing.razor",
                MetaTitle = "Blazor Gantt Chart Column Resizing | Width Adjustment | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Column Width Resizing",
                MetaDescription = "Blazor Gantt Chart demo shows column resizing capabilities. Adjust column widths to accommodate data, optimize space utilization, and personal view of project.",
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
                        FileName="Data/DefaultData.cs"
                    }
                },
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Column Menu",
                Category = "Columns",
                Directory = "GanttChart",
                Url = "gantt-chart/column-menu",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Column Menu | Quick Actions | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Column Menu Integration",
                MetaDescription = "This Blazor Gantt Chart example shows how to access sorting, filtering, and column visibility options through a convenient dropdown menu for efficient task.",
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
                        FileName="Data/DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Frozen Columns",
                Category = "Columns",
                Directory = "GanttChart",
                Url = "gantt-chart/frozen-column",
                MetaTitle = "Blazor Gantt Chart Frozen Columns | Pinned Fields | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Column Freezing",
                MetaDescription = "This Blazor Gantt Chart demo shows frozen columns functionality. Pin important columns to keep them visible while horizontally scrolling through extensive task.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FrozenColumn",
                        FileName="FrozenColumn.razor",
                    },
                    new SourceCollection
                    {
                        Id="FrozenColumn",
                        FileName="FrozenColumn.razor.cs",
                    },
                    new SourceCollection
                    {
                        Id="FrozenColumnRecord",
                        FileName="Data/GanttData.cs"
                    }
                },
                Type = SampleType.None,
                IsHideInMobile= true,
            },
            new Sample
			{
				Name = "WBS Column",
				Category = "Columns",
				Directory = "GanttChart",
				Url = "gantt-chart/wbs-column",
				Type = SampleType.None,
				MetaTitle = "Blazor Gantt Chart WBS Column | Auto-Generated Task Codes | Syncfusion",
				HeaderText = "Blazor Gantt Chart Example - Work Breakdown Structure (WBS) Column",
				MetaDescription = "Blazor Gantt Chart demo shows WBS and auto-generate hierarchical task codes, visualize dependencies, and ensure project clarity. optimized for large datasets.",
                SourceFiles = new List<SourceCollection>()
				{
					new SourceCollection
					{
						Id="WbsColumn",
						FileName="WbsColumn.razor"
					},
					new SourceCollection
					{
						Id="WbsColumnRecord",
						FileName="Data/WbsColumnData.cs"
					}
				}
			},
             new Sample
            {
                Name = "Resource Allocation",
                Category = "Resource",
                Directory = "GanttChart",
                Url = "gantt-chart/resource-allocation",
                Type = SampleType.None, 
                MetaTitle = "Blazor Gantt Chart Resource Allocation | Staff Assignment | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Resource Allocation Management",
                MetaDescription = "Blazor Gantt Chart demo shows resource allocation for tasks. Assign team members, track workloads, and visualize resource distribution across project tasks.",
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
                        FileName="Data/ResourceModel.cs"
                    }
                },
            },
            new Sample
            {
                Name = "Resource View",
                Category = "Resource",
                Directory = "GanttChart",
                Url = "gantt-chart/resource-view",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Resource View | Team Scheduling | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Resource-Centric View",
                MetaDescription = "Blazor Gantt Chart demo shows a resource-centric visualization of project tasks. View assignments by employee or resource to evaluate workload distribution.",
				SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ResourceView",
                        FileName = "ResourceView.razor",
                    },
					new SourceCollection
                    {
                        Id="ResourceView",
                        FileName = "ResourceView.razor.cs",
                    },new SourceCollection
                    {
                        Id="ResourceView",
                        FileName = "Data/ResourceViewData.cs",
                    },
				}
			},
             new Sample
            {
                Name = "Resource Multi Taskbar",
                Category = "Resource",
                Directory = "GanttChart",
                Url = "gantt-chart/multi-taskbar",
                MetaTitle = "Blazor Gantt Chart Multi-Taskbar | Resource Tasks | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Multiple Taskbars Per Resource",
                MetaDescription = "This Blazor Gantt Chart demo shows multiple taskbars per resource row, visualizing concurrent assignments and parallel tasks and identify overallocations.",
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
                        FileName="Data/MultiTaskbarData.cs"
                    }
                },
                
                Type = SampleType.None,
            },
             new Sample
            {
                Name = "Header Template",
                Category = "Templates",
                Directory = "GanttChart",
                Url = "gantt-chart/header-template",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Header Template | Custom Headers | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Custom Header Templates",
                MetaDescription = "Blazor Gantt Chart demo shows how to create rich header designs with custom format, graphics, and interactive elements for an enhanced timeline visualization.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="HeaderTemplate",
                        FileName="GanttHeaderTemplate.razor"
                    },
					new SourceCollection
                    {
                        Id="HeaderTemplate",
                        FileName="GanttHeaderTemplate.razor.css"
                    },
                    new SourceCollection
                    {
                        Id="TaskbarRecord",
                        FileName="Data/ResourceModel.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Taskbar Template",
                Category = "Templates",
                Directory = "GanttChart",
                Url = "gantt-chart/taskbar-template",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Taskbar Template | Custom Task Visuals | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Custom Taskbar Visualization",
                MetaDescription = "This Blazor Gantt Chart example shows taskbar template customization. Create visually distinct task representations with custom styling, progress indicators.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TaskbarTemplate",
                        FileName="GanttTaskbarTemplate.razor"
                    },
					new SourceCollection
                    {
                        Id="TaskbarTemplate",
                        FileName="GanttTaskbarTemplate.razor.css"
                    },
                    new SourceCollection
                    {
                        Id="TaskbarRecord",
                        FileName="Data/TaskbarTemplateData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Tooltip Template",
                Category = "Templates",
                Directory = "GanttChart",
                Url = "gantt-chart/tooltip-template",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Tooltip Template | Task Details | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Custom Tooltip Templates",
                MetaDescription = "Blazor GanttChart demo shows how to display rich task details with formatted content, progress indicator, and contextual information when hovering over tasks.",
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
                        FileName="Data/TooltipTemplateData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Scrolling",
                Directory = "GanttChart",
                Url = "gantt-chart/virtual-scroll",                
                MetaTitle = "Blazor Gantt Chart Virtual Scrolling | Performance | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Virtual Scrolling for Large Datasets",
                MetaDescription = "This Blazor Gantt Chart example shows how to render only visible rows for optimal performance while managing extensive project plans with numerous tasks.",
				SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="VirtualScroll",
                        FileName = "VirtualScroll.razor",
                    },
					new SourceCollection
                    {
                        Id="VirtualScroll",
                        FileName = "VirtualScroll.razor.cs",
                    },
					new SourceCollection
                    {
                        Id="VirtualScroll",
                        FileName = "Data/VirtualScrollData.cs",
                    },
				}
			},
            new Sample
            {
                Name = "Row Drag and Drop",
                Category = "Rows",
                Directory = "GanttChart",
                Url = "gantt-chart/row-drag-and-drop",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Row Reordering | Task Prioritization | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Row Drag and Drop",
                MetaDescription = "This Blazor Gantt Chart example shows row drag and drop functionality. Reorder tasks and subtasks through intuitive drag operations to prioritize work items.",
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
                        FileName="Data/DefaultData.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Row Height",
                Category = "Rows",
                Directory = "GanttChart",
                Url = "gantt-chart/row-height",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Row Height | Visual Density | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Row Height Customization",
                MetaDescription = "This Blazor Gantt Chart example demonstrates how to adjust task row heights to control visual density and optimize screen space based on project complexity.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowHeight",
                        FileName="RowHeight.razor"
                    },
					new SourceCollection
                    {
                        Id="RowHeight",
                        FileName="RowHeight.razor.cs"
                    },					
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="Data/DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = " Menu Filtering",
                Category = "Filtering",
                Directory = "GanttChart",
                Url = "gantt-chart/filtering",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Filtering | Task Filtering | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Basic Filtering",
                MetaDescription = "This Blazor Gantt Chart example demonstrates basic filtering capabilities. Filter tasks by various criteria to focus on specific aspects of your project.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Filtering",
                         FileName = "Filtering.razor",
                    },
					new SourceCollection
                    {
                        Id="Filtering",
                         FileName = "Filtering.razor.cs",
                    },
                    new SourceCollection
                    {
                        Id="Filter",
                        FileName="Data/FilterData.cs"
                    }
                }
            },           
            new Sample
            {
                Name = "Excel Filtering",
                Category = "Filtering",
                Directory = "GanttChart",
                Url = "gantt-chart/excel-filtering",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Filtering | Task Filtering | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Excel Filtering",
                MetaDescription = "This Blazor Gantt Chart example demonstrates Excel filtering capabilities. Filter tasks by various criteria to focus on specific aspects of your project.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Filtering",
                         FileName = "ExcelFiltering.razor",
                    },
					new SourceCollection
                    {
                        Id="Filtering",
                         FileName = "ExcelFiltering.razor.cs",
                    },
                    new SourceCollection
                    {
                        Id="Filter",
                        FileName="Data/FilterData.cs"
                    }
                }
            },
                new Sample
            {
                Name = "Advanced Filtering",
                Category = "Filtering",
                Directory = "GanttChart",
                Url = "gantt-chart/advanced-filtering",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Advanced Filtering | Complex Queries | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Advanced Filtering Options",
                MetaDescription = "Blazor GanttChart demo shows advanced filtering with complex conditions and operators. Create sophisticated filter expressions to isolate specific task subsets.",
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
                         FileName = "AdvancedFiltering.razor.cs",
                    },
					new SourceCollection
                    {
                         Id="AdvancedFiltering",
                         FileName = "AdvancedFiltering.razor.css",
                    },
                    new SourceCollection
                    {
                        Id="AdvancedFiltering",
                        FileName="Data/FilterData.cs"
                    }
                },
            },
            new Sample
            {
                Name = "Default Exporting",
                Category = "Exporting",
                Directory = "GanttChart",
                Url = "gantt-chart/exporting",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Exporting | Project Sharing | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Basic Export Options",
                MetaDescription = "Blazor Gantt Chart demo shows how to export project schedules to various formats like PDF, Excel and CSV for sharing, reporting, and documentation purposes.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ExportTask",
                        FileName = "Exporting.razor",
                    },
					new SourceCollection
                    {
                        Id="ExportTask",
                        FileName = "Exporting.razor.cs",
                    },
                    new SourceCollection
                    {
                        Id="ExportRecord",
                        FileName="Data/GanttData.cs"
                    }
                },
            },
            new Sample
            {
                Name = "Advanced Exporting",
                Category = "Exporting",
                Directory = "GanttChart",
                Url = "gantt-chart/advanced-exporting",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Advanced Export | Custom Options | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Advanced Export Customization",
                MetaDescription = "This Blazor Gantt Chart example demonstrates how to control page setup, header/footer content, and formatting options when exporting to various formats.",
				SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="AdvancedExporting",
                        FileName = "AdvancedExporting.razor",
                    },
					new SourceCollection
                    {
                        Id="AdvancedExporting",
                        FileName = "AdvancedExporting.razor.cs",
                    },
					new SourceCollection
                    {
                        Id="AdvancedExporting",
                        FileName = "AdvancedExporting.razor.css",
                    },
					new SourceCollection
                    {
                        Id="AdvancedExporting",
                        FileName = "Data/AdvancedExportingData.cs",
                    },
				}
			},
            new Sample
            {
                Name = "Undo Redo",
                Category = "Miscellaneous",
                Directory = "GanttChart",
                Url = "gantt-chart/undo-redo",
                Type = SampleType.New,
                MetaTitle = "Blazor Gantt Chart Undo and Redo | Revert and Reapply | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Undo and Redo",
                MetaDescription = "Blazor Gantt Chart demo showcases built-in undo and redo functionality, enabling quick reversal or reapplication of recent changes for precise project control.",
                NotificationDescription = new string[]
                {
                    @"The sample has been added to demonstrate the Undo Redo feature in the Gantt Chart."
                },
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "UndoRedo",
                        FileName = "UndoRedo.razor",
                    },
                    new SourceCollection
                    {
                        Id = "UndoRedo",
                        FileName = "Data/UndoRedoData.cs",
                    },
                }
            },
            new Sample
            {
                Name = "Split Tasks",
                Category = "Miscellaneous",
                Directory = "GanttChart",
                Url = "gantt-chart/split-tasks",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Split Tasks | Segmented Work | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Split Task Management",
                MetaDescription = "This Blazor Gantt Chart demo shows how to handle non-continuous work by dividing tasks into multiple segments to represent interruptions in project schedules.",
				SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="SplitTasks",
                        FileName = "SplitTasks.razor",
                    },					
					new SourceCollection
                    {
                        Id="SplitTasks",
                        FileName = "Data/SplitTasksData.cs",
                    },
				}
			},
			new Sample
            {
                Name = "Responsive",
                Category = "Miscellaneous",
                Directory = "GanttChart",
                Url = "gantt-chart/ganttresponsive",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Responsive Design | Mobile Friendly | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Responsive Layout",
                MetaDescription = "Blazor GanttChart demo shows how display to different screen sizes and devices while maintaining usage for project management on desktop and mobile platforms.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="GanttResponsive",
                        FileName="GanttResponsive.razor"
                    },
					new SourceCollection
                    {
                        Id="GanttResponsive",
                        FileName="GanttResponsive.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="GanttResponsiveRecord",
                        FileName="Data/WorkData.cs"
                    }
                },
            },
            
#if !(WASM)
            new Sample
            {
                Name = "Persist State",
                Category = "Miscellaneous",
                Directory = "GanttChart",
                Url = "gantt-chart/persistence",
                MetaTitle = "Blazor Gantt Chart State Persistence | User Preferences | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - State Persistence",
                MetaDescription = "This Blazor Gantt Chart demo shows how to save and restore user preferences like column width, sort order, and filtering to provide consistent user experience.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="PersistState",
                        FileName="Persistence.razor",
                    },
					new SourceCollection
                    {
                        Id="PersistState",
                        FileName="Persistence.razor.cs",
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="Data/DefaultData.cs"
                    }
                },
            },
#endif
            new Sample
            {
                Name = "Context Menu",
                Category = "Miscellaneous",
                Directory = "GanttChart",
                Url = "gantt-chart/context-menu",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Context Menu | Quick Actions | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Context Menu Integration",
                MetaDescription = "Blazor Gantt Chart demo shows context menu functionality. Access common operations like add, edit, delete through a right-click menu for faster task management.",
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
                        FileName="Data/GanttData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Clipboard",
                Category = "Miscellaneous",
                Directory = "GanttChart",
                Url = "gantt-chart/clipboard",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Clipboard | Copy Paste Tasks | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Clipboard Operations",
                MetaDescription = "This Blazor Gantt Chart example demonstrates how to copy and paste task data within the chart or to external applications for efficient task creations.",
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
                        FileName="Data/DefaultData.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Miscellaneous",
                Directory = "GanttChart",
                Url = "gantt-chart/keyboard-navigation",
                Type = SampleType.None,
                MetaTitle = "Blazor Gantt Chart Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Keyboard Navigation Support",
                MetaDescription = "This Blazor Gantt Chart example shows how to navigate, select, and edit project tasks using keyboard shortcuts for improved accessibility and productivity.",
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
                        FileName="Data/DefaultData.cs"
                    }
                }, 
                IsHideInMobile= true,
            }
        };
    }
}
