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
    public class UnscheduleData
    {
        public class TaskData
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; } = string.Empty;
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public string? Duration { get; set; }
            public int? ParentId { get; set; }
            public bool IsManual { get; set; }
            public string TaskMode { get; set; } = string.Empty;
        }
        /// <summary>
        /// Generates and returns a collection of Gantt task data.
        /// </summary>
        public static List<TaskData> GetTaskCollection()
        {
            List<TaskData> Tasks = new List<TaskData>() 
            {
                new TaskData() { TaskId = 1, TaskName = "Project initiation", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 06) },
                new TaskData() { TaskId = 2, TaskName = "Auto with duration only", Duration = "2", ParentId = 1 },
                new TaskData() { TaskId = 3, TaskName = "Auto with end date only", EndDate = new DateTime(2021, 04, 03), ParentId = 1 },
                new TaskData() { TaskId = 4, TaskName = "Auto with start date only", StartDate = new DateTime(2021, 04, 02), ParentId = 1 },
                new TaskData() { TaskId = 5, TaskName = "No Scheduling Task" },
                new TaskData() { TaskId = 6, TaskName = "Market research" },
                new TaskData() { TaskId = 7, TaskName = "Manual with duration only", Duration = "2", IsManual = true, ParentId = 6 },
                new TaskData() { TaskId = 8, TaskName = "Manual with end Date only", EndDate = new DateTime(2021, 04, 03), ParentId = 6, IsManual = true },
                new TaskData() { TaskId = 9, TaskName = "Manual with start date only", StartDate = new DateTime(2021, 04, 02), ParentId = 6, IsManual = true },
                new TaskData() { TaskId = 10, TaskName = "Product design and development", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 06) },
                new TaskData() { TaskId = 11, TaskName = "Auto with duration only", Duration = "2", ParentId = 10 },
                new TaskData() { TaskId = 12, TaskName = "Auto with end date only", EndDate = new DateTime(2021, 04, 03), ParentId = 10 },
                new TaskData() { TaskId = 13, TaskName = "Auto with start date only", StartDate = new DateTime(2021, 04, 02), ParentId = 10 },
                new TaskData() { TaskId = 14, TaskName = "No Scheduling Task" },
            };
            return Tasks;
        }
    }
}