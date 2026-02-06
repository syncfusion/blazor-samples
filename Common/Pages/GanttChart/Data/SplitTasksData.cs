#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

namespace BlazorDemos.Pages.GanttChart.Data
{
    public class SplitTasksData
    {
        public class TaskData
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; } = string.Empty;
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public string? Duration { get; set; }
            public int Progress { get; set; }
            public int? ParentId { get; set; }
            public string Predecessor { get; set; } = string.Empty;
        }
        public class SegmentModel
        {
            public int id { get; set; }
            public int TaskId { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string? Duration { get; set; }
        }

        /// <summary>
        /// Returns a predefined list of tasks for the Gantt Chart.
        /// </summary>
        public static List<TaskData> GetTaskCollection()
        {
            List<TaskData> Tasks = new List<TaskData>() {
                new TaskData() { TaskId = 1, TaskName = "Project initiation", StartDate = new DateTime(2022, 03, 28), EndDate = new DateTime(2022, 07, 28), Duration="4" },
                new TaskData() { TaskId = 2, TaskName = "Identify site location", StartDate = new DateTime(2022, 03, 29), Progress = 30, ParentId = 1, Duration="8", },
                new TaskData() { TaskId = 3, TaskName = "Site analyze", StartDate = new DateTime(2022, 03, 29),  Progress = 50, ParentId = 1, Duration="8"},
                new TaskData() { TaskId = 4, TaskName = "Perform soil test", StartDate = new DateTime(2022, 03, 29), ParentId = 1, Duration="5", Predecessor="2FS", Progress=40, },
                new TaskData() { TaskId = 5, TaskName = "Soil test approval", StartDate = new DateTime(2022, 03, 29), Duration="4", Progress = 30 },
                new TaskData() { TaskId = 6, TaskName = "Project estimation", StartDate = new DateTime(2022, 04, 08), Duration="8", Progress=40, ParentId=1 },
                new TaskData() { TaskId = 7, TaskName = "Develop floor plan for estimation", StartDate = new DateTime(2022, 03, 29), Duration = "0", Progress = 30, ParentId = 5, Predecessor= "4FS" },
                new TaskData() { TaskId = 8, TaskName = "List materials", StartDate = new DateTime(2022, 04, 01), Duration = "6", Progress = 30, ParentId = 5 },
                new TaskData() { TaskId = 9, TaskName = "Estimation approval",Progress=30, StartDate = new DateTime(2022, 04, 01), Duration = "4", ParentId = 5, Predecessor="8FS" },
                new TaskData() { TaskId = 10, TaskName = "Building approval", StartDate = new DateTime(2022, 04, 12), Duration = "5", ParentId = 5 },
                new TaskData() { TaskId = 11, TaskName = "Construction initiation", StartDate = new DateTime(2022, 04, 01), Duration = "5", Progress=40 },
                new TaskData() { TaskId = 12, TaskName = "Ground floor initiation", StartDate = new DateTime(2022, 04, 05), Duration = "5", ParentId = 11, Progress=40},
                new TaskData() { TaskId = 13, TaskName = "First floor initiation", StartDate = new DateTime(2022, 04, 05), Duration = "7",ParentId = 11, Progress=40},
                new TaskData() { TaskId = 14, TaskName = "Electric work initiation", StartDate = new DateTime(2022, 04, 01), Duration = "5", ParentId = 11, Progress=40, },
                new TaskData() { TaskId = 15, TaskName = "Plumbing work", StartDate = new DateTime(2022, 04, 02), Duration = "5", ParentId = 11, Progress=40 },
            };
            return Tasks;
        }

        /// <summary>
        /// Returns a predefined list of task segments for split tasks in the Gantt Chart.
        /// </summary>
        public static List<SegmentModel> GetSegmentCollection()
        {
            List<SegmentModel> segments = new List<SegmentModel>();
            segments.Add(new SegmentModel() { id = 1, TaskId = 2, StartDate = new DateTime(2022, 04, 01), Duration = "1" });
            segments.Add(new SegmentModel() { id = 2, TaskId = 2, StartDate = new DateTime(2022, 03, 29), EndDate = new DateTime(2022, 03, 31) });
            segments.Add(new SegmentModel() { id = 3, TaskId = 3, StartDate = new DateTime(2022, 04, 01), Duration = "2" });
            segments.Add(new SegmentModel() { id = 4, TaskId = 3, StartDate = new DateTime(2022, 03, 29), EndDate = new DateTime(2022, 03, 31) });
            segments.Add(new SegmentModel() { id = 5, TaskId = 3, StartDate = new DateTime(2022, 04, 04), Duration = "3" });
            segments.Add(new SegmentModel() { id = 6, TaskId = 4, StartDate = new DateTime(2022, 04, 01), Duration = "1" });
            segments.Add(new SegmentModel() { id = 7, TaskId = 4, StartDate = new DateTime(2022, 03, 29), EndDate = new DateTime(2022, 03, 31) });
            segments.Add(new SegmentModel() { id = 8, TaskId = 8, StartDate = new DateTime(2022, 04, 01), EndDate = new DateTime(2022, 04, 03) });
            segments.Add(new SegmentModel() { id = 9, TaskId = 8, StartDate = new DateTime(2022, 04, 05), Duration = "1" });
            segments.Add(new SegmentModel() { id = 10, TaskId = 9, StartDate = new DateTime(2022, 03, 29), EndDate = new DateTime(2022, 03, 31) });
            segments.Add(new SegmentModel() { id = 11, TaskId = 9, StartDate = new DateTime(2022, 04, 01), Duration = "1" });
            segments.Add(new SegmentModel() { id = 12, TaskId = 12, StartDate = new DateTime(2022, 04, 05), Duration = "1" });
            segments.Add(new SegmentModel() { id = 13, TaskId = 12, StartDate = new DateTime(2022, 04, 07), Duration = "1" });
            segments.Add(new SegmentModel() { id = 14, TaskId = 14, StartDate = new DateTime(2022, 04, 01), EndDate = new DateTime(2022, 04, 02) });
            segments.Add(new SegmentModel() { id = 15, TaskId = 14, StartDate = new DateTime(2022, 04, 04), Duration = "2" });
            return segments;
        }
    }
}
