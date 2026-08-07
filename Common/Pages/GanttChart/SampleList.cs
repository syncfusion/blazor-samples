using System.Collections.Generic;
namespace BlazorDemos
{
    internal sealed partial class SampleConfig
    {
        public List<Sample> GanttChart { get; set; } = new List<Sample>
        {
             new Sample
             {
                Name = "Overview",
                Category = "Gantt Chart",
                Directory = "GanttChart",
                Url = "gantt-chart/overview",
                Type = SampleType.None,
                MetaTitle = "Blazor GanttChart Examples - Overview | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Overview",
                MetaDescription = "See how the Syncfusion Blazor Overview Gantt Chart visualizes tasks, timelines, dependencies, and milestones with resource mapping for clear project planning.",
                CustomCanonicalUrl = "https://www.syncfusion.com/gantt-sdk/blazor-gantt-chart",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Overview",
                        FileName="GanttOverview.razor"
                    },
                    new SourceCollection
                    {
                        Id="Overview",
                        FileName="GanttOverview.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="Overview",
                        FileName="GanttOverview.razor.css"
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
                MetaTitle = "Blazor GanttChart Examples - Default | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Default Functionalities Gantt Chart shows task hierarchy and dependencies with built-in tools for efficient project setup.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/gantt-sdk/blazor-gantt-chart",
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
                        FileName="DefaultFunctionalities.razor.cs"
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
                MetaTitle = "Blazor GanttChart Examples - Editing | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Task Editing Capabilities",
                MetaDescription = "See how the Syncfusion Blazor Editing Gantt Chart supports add, edit, delete, and drag-drop actions with API and events for flexible and faster task updates.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Editing",
                        FileName="Editing.razor"
                    },
                    new SourceCollection
                    {
                        Id="Editing",
                        FileName="Editing.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="Editing",
                        FileName="Editing.razor.css"
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
                MetaTitle = "Blazor GanttChart Examples - Sorting | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Column Sorting",
                MetaDescription = "See how the Syncfusion Blazor Sorting Gantt Chart organizes project data using multi-column sorting and custom orders with API and events for analysis.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Sorting",
                        FileName="Sorting.razor"
                    },
                    new SourceCollection
                    {
                        Id="Sorting",
                        FileName="Sorting.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="Sorting",
                        FileName="Sorting.razor.css"
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
                MetaTitle = "Blazor GanttChart Demos - Selection Examples | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Task Selection",
                MetaDescription = "See how the Syncfusion Blazor Selection supports row and multi selection with event handling, enabling precise task focus and better workflow control.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Selection",
                        FileName="Selection.razor"
                    },
                    new SourceCollection
                    {
                        Id="Selection",
                        FileName="Selection.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="Selection",
                        FileName="Selection.razor.css"
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
                MetaTitle = "Blazor AI Demos - Smart Progress Predictor Examples | Syncfusion",
                HeaderText = "Blazor Gantt Chart - AI Powered Progress Predictor Example",
                MetaDescription = "See how the Syncfusion Blazor Smart Progress Predictor Gantt Chart forecasts timelines using AI insights, API, and events to improve planning accuracy.",
                Type = SampleType.AI
            },
            new Sample
            {
                Name = "Smart Resource Allocation",
                Category = "Smart AI Solutions",
                Directory = "AISamples/GanttChart",
                Url = "gantt-chart/ai-resource-manager",
                FileName = "ResourceOverallocation.razor",
                MetaTitle = "Blazor AI Demos - Smart Resource Allocation Examples | Syncfusion",
                HeaderText = "Blazor Gantt Chart - AI Powered Resource Allocation Example",
                MetaDescription = "See how the Syncfusion Blazor Smart Resource Allocation balances workloads by detecting overuse and redistributing tasks for optimized team productivity.",
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
                MetaTitle = "Blazor GanttChart - Airline Tracker | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Airline Flight Scheduler",
                MetaDescription = "See how the Syncfusion Blazor Airline Tracker Gantt Chart visualizes flight schedules, durations, and timelines with tracking features for efficient operations.",
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
            // Ignore: From Build
            new Sample
            {
                Name = "Digital Marketing",
                Category = "Use Case",
                Directory = "GanttChart",
                Url = "gantt-chart/digital-marketing",
                Type = SampleType.None,
                MetaTitle = "Blazor GanttChart - Digital Marketing | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Digital Marketing Campaign Tracker",
                MetaDescription = "See how the Syncfusion Blazor Digital Marketing Gantt Chart manages campaigns, dependencies, and milestones with API and events for better execution tracking.",
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
            // End: Ignore
            // Ignore: From Build
            new Sample
            {
                Name = "Human Resource",
                Category = "Use Case",
                Directory = "GanttChart",
                Url = "gantt-chart/human-resource-management",
                Type = SampleType.None,
                MetaTitle = "Blazor GanttChart - Human Resource | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Human Resource Management",
                MetaDescription = "See how the Syncfusion Blazor Human Resource manages onboarding and hiring timelines with resource allocation and tracking to improve workforce planning.",
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
            // End: Ignore
            new Sample
            {
                Name = "Education Scheduler",
                Category = "Use Case",
                Directory = "GanttChart",
                Url = "gantt-chart/education-scheduler",
                Type = SampleType.None,
                MetaTitle = "Blazor GanttChart Demos - Education Scheduler Examples | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Educational Program Scheduler",
                MetaDescription = "See how the Syncfusion Blazor Education Scheduler Gantt Chart organizes courses, semesters, and timelines with API and events for structured academic planning.",
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
                MetaTitle = "Blazor GanttChart - Remote Data | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Remote Data Binding",
                MetaDescription = "See how the Syncfusion Blazor Remote Data connects to APIs and services with dynamic updates and integration support to manage project data seamlessly.",
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
                    new SourceCollection
                    {
                        Id="RemoteData",
                        FileName = "RemoteData.razor.css",
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
                MetaTitle = "Blazor GanttChart Demos - DynamicObject Binding Examples | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - DynamicObject Data Binding",
                MetaDescription = "See how the Syncfusion Blazor DynamicObject Binding Gantt Chart handles dynamic data with API, property mapping, and events for flexible project management.",
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
                    new SourceCollection
                    {
                        Id="DynamicData",
                        FileName = "DynamicData.razor.css",
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
                MetaTitle = "Blazor GanttChart Demos - ExpandoObject Binding Examples | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - ExpandoObject Data Binding",
                MetaDescription = "See how the Syncfusion Blazor ExpandoObject Binding Gantt Chart supports dynamic data with API, CRUD operations, and events for flexible task workflows.",
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
                    new SourceCollection
                    {
                        Id="ExpandoData",
                        FileName = "ExpandoData.razor.css",
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
                MetaTitle = "Blazor GanttChart Demos - Observable Collection Examples | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Observable Collection Binding",
                MetaDescription = "See how the Syncfusion Blazor Observable Collection updates task data automatically with real time UI refresh and binding for effective project tracking.",
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
                        FileName = "ObservableBinding.razor.css",
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
                MetaTitle = "Blazor GanttChart - Big Data Set | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Load On Demand for Large Datasets",
                MetaDescription = "See how the Syncfusion Blazor Big Data Set Gantt Chart handles large project data using virtualization, load on demand, API, and events for faster performance.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="LoadOnDemand",
                        FileName = "LoadOnDemand.razor",
                    },
                    new SourceCollection
                    {
                        Id="LoadOnDemand",
                        FileName = "LoadOnDemand.razor.cs",
                    },
                    new SourceCollection
                    {
                        Id="LoadOnDemand",
                        FileName = "LoadOnDemand.razor.css",
                    }
                }

            },
            new Sample
            {
                Name = "Scheduling Mode",
                Category = "Scheduling Concepts",
                Directory = "GanttChart",
                Url = "gantt-chart/scheduling-mode",
                Type = SampleType.None,
                MetaTitle = "Blazor GanttChart - Scheduling Mode | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Task Scheduling Modes",
                MetaDescription = "See how the Syncfusion Blazor Scheduling Mode Gantt Chart supports manual and auto scheduling with dependency control using API and events for workflows.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ScheduleMode",
                        FileName="SchedulingMode.razor"
                    },
                    new SourceCollection
                    {
                        Id="ScheduleMode",
                        FileName="SchedulingMode.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="ScheduleMode",
                        FileName="SchedulingMode.razor.css"
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
                MetaTitle = "Blazor GanttChart Demos - Work Week Examples | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Work Week Configuration",
                MetaDescription = "See how the Syncfusion Blazor Work Week defines working days, custom hours, and non working periods to align project schedules with team availability.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WorkWeek",
                        FileName="WorkWeek.razor"
                    },
                    new SourceCollection
                    {
                        Id="WorkWeek",
                        FileName="WorkWeek.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="WorkWeek",
                        FileName="WorkWeek.razor.css"
                    },
                    new SourceCollection
                    {
                        Id="WorkWeek",
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
                MetaTitle = "Blazor GanttChart - Work Time Range | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Working Time Range Configuration",
                MetaDescription = "See how the Syncfusion Blazor Work Time Range configures business hours and time slots to ensure precise scheduling and effective resource utilization.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WorkTimeRange",
                        FileName="WorkTimeRange.razor"
                    },
                    new SourceCollection
                    {
                        Id="WorkTimeRange",
                        FileName="WorkTimeRange.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="WorkTimeRange",
                        FileName="WorkTimeRange.razor.css"
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
                MetaTitle = "Blazor GanttChart Examples - Holidays | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Holiday Configuration",
                MetaDescription = "See how the Syncfusion Blazor Holidays Gantt Chart manages holidays, events, and non-working days with API and visualization tools for accurate scheduling.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Holidays",
                        FileName="Holidays.razor"
                    },
                    new SourceCollection
                    {
                        Id="Holidays",
                        FileName="Holidays.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="Holidays",
                        FileName="Holidays.razor.css"
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
                MetaTitle = "Blazor GanttChart - Unscheduled Task | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Unscheduled Task Management",
                MetaDescription = "See how the Syncfusion Blazor Unscheduled Task Gantt Chart manages tasks without fixed dates using API, events, and backlog tracking for flexible planning.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Unscheduled",
                        FileName = "UnscheduledTask.razor",
                    },
                    new SourceCollection
                    {
                        Id="Unscheduled",
                        FileName = "UnscheduledTask.razor.cs",
                    },
                    new SourceCollection
                    {
                        Id="Unscheduled",
                        FileName = "UnscheduledTask.razor.css",
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
                MetaTitle = "Blazor GanttChart Examples - Baseline | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Baseline Comparison",
                MetaDescription = "See how the Syncfusion Blazor Baseline compares planned versus actual timelines with visual indicators and tracking tools to monitor project deviations.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Baseline",
                        FileName="Baseline.razor"
                    },
                    new SourceCollection
                    {
                        Id="Baseline",
                        FileName="Baseline.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="Baseline",
                        FileName="Baseline.razor.css"
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
                MetaTitle = "Blazor GanttChart - Event Markers | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Event Marker Visualization",
                MetaDescription = "See how the Syncfusion Blazor Event Markers highlights milestones, deadlines, and key dates with visual cues to improve timeline awareness and tracking.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Events",
                        FileName="EventMarkers.razor"
                    },
                    new SourceCollection
                    {
                        Id="Events",
                        FileName="EventMarkers.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="Events",
                        FileName="EventMarkers.razor.css"
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
                MetaTitle = "Blazor GanttChart Examples - Timezone | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Timezone",
                MetaDescription = "See how the Syncfusion Blazor Timezone manages tasks across regions with accurate time conversions and scheduling tools for global project coordination.",
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
                        Id = "Timezone",
                        FileName = "Timezone.razor.css"
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
                MetaTitle = "Blazor GanttChart - Critical Path | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Critical Path Analysis",
                MetaDescription = "See how the Syncfusion Blazor Critical Path Gantt Chart highlights dependent tasks with analysis tools and events to optimize timelines and planning efficiency.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Critical",
                        FileName="CriticalPath.razor"
                    },
                    new SourceCollection
                    {
                        Id="Critical",
                        FileName="CriticalPath.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="Critical",
                        FileName="CriticalPath.razor.css"
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
                Type = SampleType.Updated,
                MetaTitle = "Blazor GanttChart - Timeline API | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Timeline API Customization",
                MetaDescription = "See how the Syncfusion Blazor Timeline API customizes time scales, date ranges, and formatting to provide flexible timeline visualization and control.",
                NotificationDescription =
                [
                    @"This sample demonstrates the configurable timeline units in the Blazor Gantt Chart, supporting standard units such as year, month, week, day, and hour, along with extended options such as half-year and quarter. These capabilities enable more granular visualization and improved planning across varying project durations."
                ],
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TimeTask",
                        FileName = "GanttTimeline.razor",
                    },
                    new SourceCollection
                    {
                        Id="TimeTask",
                        FileName = "GanttTimeline.razor.cs",
                    },
                    new SourceCollection
                    {
                        Id="TimeTask",
                        FileName = "GanttTimeline.razor.css",
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
                MetaTitle = "Blazor GanttChart Examples - Zooming | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Timeline Zooming",
                MetaDescription = "See how the Syncfusion Blazor Zooming Gantt Chart switches timeline views using API, scaling, and events to adjust detail levels and improve project visibility.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Zoom",
                        FileName = "Zooming.razor",
                    },
                    new SourceCollection
                    {
                        Id="Zoom",
                        FileName = "Zooming.razor.cs",
                    },
                    new SourceCollection
                    {
                        Id="Zoom",
                        FileName = "Zooming.razor.css",
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
                Url = "gantt-chart/column-validation",
                MetaTitle = "Blazor GanttChart - Column Validation | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Column Validation",
                MetaDescription = "See how the Syncfusion Blazor Column Validation enforces required rules, formats, and ranges with validation messages to ensure accurate task data entry.",
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
                MetaTitle = "Blazor GanttChart - Column Template | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Custom Column Templates",
                MetaDescription = "See how the Syncfusion Blazor Column Template customizes cell content with icons, templates, and formatting to create visually rich project data views.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnTemplate",
                        FileName="ColumnTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="ColumnTemplate",
                        FileName="ColumnTemplate.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="ColumnTemplate",
                        FileName="ColumnTemplate.razor.css"
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
                MetaTitle = "Blazor GanttChart Examples - Reorder | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Column Reordering",
                MetaDescription = "See how the Syncfusion Blazor Reorder enables drag and drop column positioning with layout control to prioritize and organize project data effectively.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnReordering",
                        FileName="ColumnReordering.razor"
                    },
                    new SourceCollection
                    {
                        Id="ColumnReordering",
                        FileName="ColumnReordering.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="ColumnReordering",
                        FileName="ColumnReordering.razor.css"
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
                MetaTitle = "Blazor GanttChart Examples - Resizing | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Column Width Resizing",
                MetaDescription = "See how the Syncfusion Blazor Resizing Gantt Chart adjusts column widths using API, layout control, and events for better space usage and readability.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnResizing",
                        FileName="ColumnResizing.razor"
                    },
                    new SourceCollection
                    {
                        Id="ColumnResizing",
                        FileName="ColumnResizing.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="ColumnResizing",
                        FileName="ColumnResizing.razor.css"
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
                MetaTitle = "Blazor GanttChart - Column Menu | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Column Menu Integration",
                MetaDescription = "See how the Syncfusion Blazor Column Menu Gantt Chart provides sorting, filtering, and visibility options using API and events to manage task data easily.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ColumnMenu",
                        FileName="ColumnMenu.razor"
                    },
                    new SourceCollection
                    {
                        Id="ColumnMenu",
                        FileName="ColumnMenu.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="ColumnMenu",
                        FileName="ColumnMenu.razor.css"
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
                MetaTitle = "Blazor GanttChart - Frozen Columns | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Column Freezing",
                MetaDescription = "See how the Syncfusion Blazor Frozen Columns Gantt Chart pins key columns using API, scrolling, and events to maintain visibility of important project data.",
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
                        Id="FrozenColumn",
                        FileName="FrozenColumn.razor.css",
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
                MetaTitle = "Blazor GanttChart - WBS Column | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Work Breakdown Structure (WBS) Column",
                MetaDescription = "See how the Syncfusion Blazor WBS Column Gantt Chart generates hierarchical codes with API and events to structure project tasks and improve planning clarity.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WbsColumn",
                        FileName="WbsColumn.razor"
                    },
                    new SourceCollection
                    {
                        Id="WbsColumn",
                        FileName="WbsColumn.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="WbsColumn",
                        FileName="WbsColumn.razor.css"
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
                MetaTitle = "Blazor GanttChart Demos - Resource Allocation Examples | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Resource Allocation Management",
                MetaDescription = "See how the Syncfusion Blazor Resource Allocation Gantt Chart assigns resources, tracks workloads, and uses API and events to balance projects effectively.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Resource",
                        FileName="ResourceAllocation.razor"
                    },
                    new SourceCollection
                    {
                        Id="Resource",
                        FileName="ResourceAllocation.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="Resource",
                        FileName="ResourceAllocation.razor.css"
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
                MetaTitle = "Blazor GanttChart - Resource View | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Resource-Centric View",
                MetaDescription = "See how the Syncfusion Blazor Resource View displays tasks grouped by resources with workload insights to enhance team planning and allocation decisions.",
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
                    },
                    new SourceCollection
                    {
                        Id="ResourceView",
                        FileName = "ResourceView.razor.css",
                    },
                    new SourceCollection
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
                MetaTitle = "Blazor GanttChart Demos - Resource Multi Taskbar | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Multiple Taskbars Per Resource",
                MetaDescription = "See how the Syncfusion Blazor Resource Multi Taskbar shows multiple tasks per resource with overlap detection to manage parallel work and avoid overuse.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ResourceMultiTaskbar",
                        FileName="MultiTaskbar.razor",
                    },
                    new SourceCollection
                    {
                        Id="ResourceMultiTaskbar",
                        FileName="MultiTaskbar.razor.cs",
                    },
                    new SourceCollection
                    {
                        Id="ResourceMultiTaskbar",
                        FileName="MultiTaskbar.razor.css",
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
                MetaTitle = "Blazor GanttChart - Header Template | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Custom Header Templates",
                MetaDescription = "See how the Syncfusion Blazor Header Template Gantt Chart customizes headers with templates, API, and events to enhance timeline visualization and usability.",
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
                        FileName="GanttHeaderTemplate.razor.cs"
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
                MetaTitle = "Blazor GanttChart - Taskbar Template | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Custom Taskbar Visualization",
                MetaDescription = "See how the Syncfusion Blazor Taskbar Template Gantt Chart customizes taskbars with API, styling, and events to clearly represent project progress and tasks.",
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
                        FileName="GanttTaskbarTemplate.razor.cs"
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
                MetaTitle = "Blazor GanttChart - Tooltip Template | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Custom Tooltip Templates",
                MetaDescription = "See how the Syncfusion Blazor Tooltip Template displays rich task details with formatting and progress indicators to provide clear contextual insights.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TooltipTemplate",
                        FileName="TooltipTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="TooltipTemplate",
                        FileName="TooltipTemplate.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="TooltipTemplate",
                        FileName="TooltipTemplate.razor.css"
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
                MetaTitle = "Blazor GanttChart - Virtual Scrolling | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Virtual Scrolling for Large Datasets",
                MetaDescription = "See how the Syncfusion Blazor Virtual Scrolling Gantt Chart renders rows using API, virtualization, and events to improve performance for large datasets.",
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
                        FileName = "VirtualScroll.razor.css",
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
                MetaTitle = "Blazor GanttChart - Row Drag and Drop | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Row Drag and Drop",
                MetaDescription = "See how the Syncfusion Blazor Row Drag and Drop Gantt Chart reorders tasks using API, drag actions, and events for better workflow and prioritization.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RowDragAndDrop",
                        FileName="RowDragAndDrop.razor"
                    },
                    new SourceCollection
                    {
                        Id="RowDragAndDrop",
                        FileName="RowDragAndDrop.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="RowDragAndDrop",
                        FileName="RowDragAndDrop.razor.css"
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
                MetaTitle = "Blazor GanttChart - Row Height | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Row Height Customization",
                MetaDescription = "See how the Syncfusion Blazor Row Height Gantt Chart adjusts spacing using API, layout control, and events to improve readability and data visibility.",
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
                        Id="RowHeight",
                        FileName="RowHeight.razor.css"
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
                MetaTitle = "Blazor GanttChart - Menu Filtering | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Menu Filtering",
                MetaDescription = "See how the Syncfusion Blazor Menu Filtering Gantt Chart applies filters with API, menu controls, and events to refine and analyze project task data easily.",
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
                        Id="Filtering",
                        FileName = "Filtering.razor.css",
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
                MetaTitle = "Blazor GanttChart - Excel Filtering | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Excel Filtering",
                MetaDescription = "See how the Syncfusion Blazor Excel Filtering enables advanced filter options like Excel with conditions and operators to refine task views efficiently.",
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
                        Id="Filtering",
                        FileName = "ExcelFiltering.razor.css",
                    },
                    new SourceCollection
                    {
                        Id="Filter",
                        FileName="Data/FilterData.cs"
                    }
                }
            },
            // Ignore: From Build
            new Sample
            {
                Name = "Advanced Filtering",
                Category = "Filtering",
                Directory = "GanttChart",
                Url = "gantt-chart/advanced-filtering",
                Type = SampleType.None,
                MetaTitle = "Blazor GanttChart Demos - Advanced Filtering Examples | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Advanced Filtering Options",
                MetaDescription = "See how the Syncfusion Blazor Advanced Filtering Gantt Chart supports complex filters using API, operators, and events for precise project data analysis.",
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
            // End: Ignore
            new Sample
            {
                Name = "Default Exporting",
                Category = "Exporting",
                Directory = "GanttChart",
                Url = "gantt-chart/exporting",
                Type = SampleType.None,
                MetaTitle = "Blazor GanttChart - Default Exporting | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Basic Export Options",
                MetaDescription = "See how the Syncfusion Blazor Default Exporting Gantt Chart exports data with API and events to PDF, Excel, and CSV formats for reporting and sharing.",
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
                        Id="ExportTask",
                        FileName = "Exporting.razor.css",
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
                MetaTitle = "Blazor GanttChart Demos - Advanced Exporting Examples | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Advanced Export Customization",
                MetaDescription = "See how the Syncfusion Blazor Advanced Exporting Gantt Chart customizes exports with API, templates, and events for detailed and professional reports.",
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
                MetaTitle = "Blazor GanttChart Demos - Undo Redo Examples | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Undo and Redo",
                MetaDescription = "See how the Syncfusion Blazor Undo Redo Gantt Chart tracks changes with API and events to quickly revert or reapply actions for better editing control.",
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
                        FileName = "UndoRedo.razor.cs",
                    },
                    new SourceCollection
                    {
                        Id = "UndoRedo",
                        FileName = "UndoRedo.razor.css",
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
                MetaTitle = "Blazor GanttChart - Split Tasks | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Split Task Management",
                MetaDescription = "See how the Syncfusion Blazor Split Tasks divides tasks into segments with timeline continuity to represent interruptions and improve schedule accuracy.",
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
                        FileName = "SplitTasks.razor.cs",
                    },
                    new SourceCollection
                    {
                        Id="SplitTasks",
                        FileName = "SplitTasks.razor.css",
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
                MetaTitle = "Blazor GanttChart - Responsive | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Responsive Layout",
                MetaDescription = "See how the Syncfusion Blazor Responsive adapts layouts across devices with flexible views and touch support to enable smooth project management anywhere.",
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
                        Id="GanttResponsive",
                        FileName="GanttResponsive.razor.css"
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
                MetaTitle = "Blazor GanttChart - Persist State | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - State Persistence",
                MetaDescription = "See how the Syncfusion Blazor Persist State Gantt Chart stores layout, sorting, and filters with API and events to maintain a consistent user experience.",
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
                MetaTitle = "Blazor GanttChart - Context Menu | GanttChart Demos | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Context Menu Integration",
                MetaDescription = "See how the Syncfusion Blazor Context Menu provides quick actions like add, edit, and delete through right click to speed up task management workflows.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ContextMenu",
                        FileName = "GanttContextMenu.razor",
                    },
                    new SourceCollection
                    {
                        Id="ContextMenu",
                        FileName = "GanttContextMenu.razor.cs",
                    },
                    new SourceCollection
                    {
                        Id="ContextMenu",
                        FileName = "GanttContextMenu.razor.css",
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
                MetaTitle = "Blazor GanttChart Demos - Clipboard Examples | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Clipboard Operations",
                MetaDescription = "See how the Syncfusion Blazor Clipboard Gantt Chart copies and pastes task data with API and events for efficient data transfer and management workflows.",
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
                        FileName = "Clipboard.razor.cs",
                    },
                    new SourceCollection
                    {
                        Id="Clipboard",
                        FileName = "Clipboard.razor.css",
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
                MetaTitle = "Blazor GanttChart Demos - Keyboard Navigation Examples | Syncfusion",
                HeaderText = "Blazor Gantt Chart Example - Keyboard Navigation Support",
                MetaDescription = "See how the Syncfusion Blazor Keyboard Navigation Gantt Chart enables shortcuts using API, focus control, and events for accessible project interaction.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Keyboard",
                        FileName="KeyboardNavigation.razor"
                    },
                    new SourceCollection
                    {
                        Id="Keyboard",
                        FileName="KeyboardNavigation.razor.cs"
                    },
                    new SourceCollection
                    {
                        Id="Keyboard",
                        FileName="KeyboardNavigation.razor.css"
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
