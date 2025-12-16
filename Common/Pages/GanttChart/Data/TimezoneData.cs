#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

namespace BlazorDemos.Pages.GanttChart.Data
{
    public class TimezoneData
    {
        public class TaskData
        {
            public int TaskId { get; set; }
            public string? TaskName { get; set; }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public string? Duration { get; set; }
            public int Progress { get; set; }
            public string? Predecessor { get; set; }
            public int? ParentId { get; set; }
        }
        /// <summary>
        /// Generates and returns a collection of Gantt task data.
        /// </summary>
        public static List<TaskData> GetTimezoneData()
        {
            List<TaskData> Tasks = new List<TaskData>
            {
                new TaskData { TaskId = 1, TaskName = "Campaign strategy & planning", StartDate = new DateTime(2025, 10, 10, 9, 0, 0), EndDate = new DateTime(2025, 10, 11, 13, 0, 0), Duration = "8", Progress = 85 },
                new TaskData { TaskId = 2, TaskName = "Stakeholder alignment meeting", StartDate = new DateTime(2025, 10, 10, 10, 0, 0), EndDate = new DateTime(2025, 10, 10, 10, 30, 0), ParentId = 1, Duration = "1.5", Progress = 100 },
                new TaskData { TaskId = 3, TaskName = "Competitor analysis", StartDate = new DateTime(2025, 10, 10, 10, 30, 0), EndDate = new DateTime(2025, 10, 10, 13, 0, 0), ParentId = 1, Duration = "2.5", Progress = 90, Predecessor = "2FS" },
                new TaskData { TaskId = 4, TaskName = "Messaging and value propositions", StartDate = new DateTime(2025, 10, 11, 9, 0, 0), EndDate = new DateTime(2025, 10, 11, 13, 0, 0), ParentId = 1, Duration = "4", Progress = 65, Predecessor = "3FS" },
                new TaskData { TaskId = 5, TaskName = "Market research survey", StartDate = new DateTime(2025, 10, 10, 11, 0, 0), EndDate = new DateTime(2025, 10, 11, 11, 0, 0), ParentId = 1, Duration = "2", Progress = 55 },
                new TaskData { TaskId = 6, TaskName = "Customer persona workshop", StartDate = new DateTime(2025, 10, 10, 11, 30, 0), EndDate = new DateTime(2025, 10, 11, 12, 30, 0), ParentId = 1, Duration = "1.5", Progress = 60, Predecessor = "5FS" },
                new TaskData { TaskId = 7, TaskName = "Finalize campaign strategy", StartDate = new DateTime(2025, 10, 10, 12, 30, 0), EndDate = new DateTime(2025, 10, 11, 13, 0, 0), ParentId = 1, Duration = "2.5", Progress = 40, Predecessor = "6FS" },
                new TaskData { TaskId = 8, TaskName = "Creative production", StartDate = new DateTime(2025, 10, 11, 13, 0, 0), EndDate = new DateTime(2025, 10, 13, 15, 0, 0), Duration = "10", Progress = 60 },
                new TaskData { TaskId = 9, TaskName = "Produce digital assets", StartDate = new DateTime(2025, 10, 11, 13, 0, 0), EndDate = new DateTime(2025, 10, 12, 13, 0, 0), ParentId = 8, Duration = "6", Progress = 77 },
                new TaskData { TaskId = 10, TaskName = "Landing page development", StartDate = new DateTime(2025, 10, 12, 13, 0, 0), EndDate = new DateTime(2025, 10, 13, 11, 0, 0), ParentId = 8, Duration = "4", Progress = 45, Predecessor = "9FS" },
                new TaskData { TaskId = 11, TaskName = "Media & copy approval", StartDate = new DateTime(2025, 10, 13, 11, 0, 0), EndDate = new DateTime(2025, 10, 13, 15, 0, 0), ParentId = 8, Duration = "4", Progress = 30, Predecessor = "10FS" },
                new TaskData { TaskId = 12, TaskName = "Digital rollout", StartDate = new DateTime(2025, 10, 14, 9, 0, 0), EndDate = new DateTime(2025, 10, 14, 17, 0, 0), Duration = "8", Progress = 20 },
                new TaskData { TaskId = 13, TaskName = "Deploy landing pages", StartDate = new DateTime(2025, 10, 14, 9, 0, 0), EndDate = new DateTime(2025, 10, 14, 11, 0, 0), ParentId = 12, Duration = "2", Progress = 0, Predecessor = "11FS" },
                new TaskData { TaskId = 14, TaskName = "Email blast", StartDate = new DateTime(2025, 10, 14, 11, 0, 0), EndDate = new DateTime(2025, 10, 14, 13, 0, 0), ParentId = 12, Duration = "2", Progress = 0, Predecessor = "13FS" },
                new TaskData { TaskId = 15, TaskName = "Activate advertisement campaigns", StartDate = new DateTime(2025, 10, 14, 13, 0, 0), EndDate = new DateTime(2025, 10, 14, 17, 0, 0), ParentId = 12, Duration = "4", Progress = 0, Predecessor = "14FS" },
                new TaskData { TaskId = 16, TaskName = "Regional market launch", StartDate = new DateTime(2025, 10, 15, 9, 0, 0), EndDate = new DateTime(2025, 10, 17, 17, 0, 0), Duration = "16", Progress = 10 },
                new TaskData { TaskId = 17, TaskName = "United states launch", StartDate = new DateTime(2025, 10, 15, 9, 0, 0), EndDate = new DateTime(2025, 10, 15, 13, 0, 0), ParentId = 16, Duration = "4", Progress = 0, Predecessor = "15FS" },
                new TaskData { TaskId = 18, TaskName = "European union launch", StartDate = new DateTime(2025, 10, 16, 9, 0, 0), EndDate = new DateTime(2025, 10, 16, 13, 0, 0), ParentId = 16, Duration = "4", Progress = 0, Predecessor = "17FS" },
                new TaskData { TaskId = 19, TaskName = "Asia launch", StartDate = new DateTime(2025, 10, 17, 9, 0, 0), EndDate = new DateTime(2025, 10, 17, 13, 0, 0), ParentId = 16, Duration = "4", Progress = 0, Predecessor = "18FS" },
                new TaskData { TaskId = 20, TaskName = "Region rollout check-in", StartDate = new DateTime(2025, 10, 17, 15, 0, 0), EndDate = new DateTime(2025, 10, 17, 17, 0, 0), ParentId = 16, Duration = "2", Progress = 0, Predecessor = "19FS" },
                new TaskData { TaskId = 21, TaskName = "Campaign monitoring & closure", StartDate = new DateTime(2025, 10, 18, 9, 0, 0), EndDate = new DateTime(2025, 10, 18, 18, 0, 0), Duration = "9", Progress = 0 },
                new TaskData { TaskId = 22, TaskName = "Monitor key performance indicators & analytics", StartDate = new DateTime(2025, 10, 18, 9, 0, 0), EndDate = new DateTime(2025, 10, 18, 12, 0, 0), ParentId = 21, Duration = "3", Progress = 0, Predecessor = "20FS" },
                new TaskData { TaskId = 23, TaskName = "Optimize campaign spend", StartDate = new DateTime(2025, 10, 18, 12, 0, 0), EndDate = new DateTime(2025, 10, 18, 15, 0, 0), ParentId = 21, Duration = "3", Progress = 0, Predecessor = "22FS" },
                new TaskData { TaskId = 24, TaskName = "Review results & archive", StartDate = new DateTime(2025, 10, 18, 15, 0, 0), EndDate = new DateTime(2025, 10, 18, 18, 0, 0), ParentId = 21, Duration = "3", Progress = 0, Predecessor = "23FS" }
            };
            return Tasks;
        }
    }
}
