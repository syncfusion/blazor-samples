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

namespace BlazorDemos.Pages.GanttChart
{
    public class ScheduleData
    {
        public class TaskData
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public string Duration { get; set; }
            public int Progress { get; set; }
            public int? ParentId { get; set; }
            public bool IsManual { get; set; }
            public string TaskMode { get; set; }
        }

        public static List<TaskData> GetTaskCollection()
        {
            List<TaskData> Tasks = new List<TaskData>() 
            {
                new TaskData() { TaskId = 1, TaskName = "Parent task 1", StartDate = new DateTime(2021, 04, 04), EndDate = new DateTime(2021, 04, 06), IsManual= true },
                new TaskData() { TaskId = 2, TaskName = "Child task 1", StartDate = new DateTime(2021, 04, 02), Duration = "2", Progress = 30, ParentId = 1 },
                new TaskData() { TaskId = 3, TaskName = "Child task 2", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 06), Progress = 40, ParentId = 1, IsManual= true },
                new TaskData() { TaskId = 4, TaskName = "Child task 3", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 06), Progress = 30, ParentId = 1 },
                new TaskData() { TaskId = 5, TaskName = "Parent task 2", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 08), IsManual= true },
                new TaskData() { TaskId = 6, TaskName = "Child task 1", StartDate = new DateTime(2021, 04, 02), Duration = "2", Progress = 30, ParentId = 5 },
                new TaskData() { TaskId = 7, TaskName = "Child task 2", StartDate = new DateTime(2021, 04, 02), Duration = "4", Progress = 40, ParentId = 5 },
                new TaskData() { TaskId = 8, TaskName = "Child task 3", StartDate = new DateTime(2021, 04, 02), Duration = "5", Progress = 30, ParentId = 5, IsManual= true },
                new TaskData() { TaskId = 9, TaskName = "Child task 4", StartDate = new DateTime(2021, 04, 02), Duration = "2", Progress = 30, ParentId = 5, IsManual= true },
                new TaskData() { TaskId = 10, TaskName = "Parent task 3", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 06), Progress = 40 },
                new TaskData() { TaskId = 11, TaskName = "Child task 1", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 06), Progress = 30, ParentId = 10 },
                new TaskData() { TaskId = 12, TaskName = "Child task 2", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 08), ParentId=10 },
                new TaskData() { TaskId = 13, TaskName = "Child task 3", StartDate = new DateTime(2021, 04, 02), Duration = "2", Progress = 30, ParentId = 10 },
                new TaskData() { TaskId = 14, TaskName = "Child task 4", StartDate = new DateTime(2021, 04, 02), Duration = "4", Progress = 40, ParentId = 10, IsManual= true },
                new TaskData() { TaskId = 15, TaskName = "Child task 5", StartDate = new DateTime(2021, 04, 02), Duration = "5", Progress = 30, ParentId = 10 },

            };
            return Tasks;
        }
    }
}