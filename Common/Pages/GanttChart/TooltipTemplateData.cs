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
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.GanttChart
{
    public class TooltipTemplateData
    {
        public class TaskData
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public string TaskType { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Duration { get; set; }
            public int Progress { get; set; }
            public int? ParentId { get; set; }
            public string ResourceName { get; set; }
        }
        public static List<TaskData> GetTaskCollection()
        {
            List<TaskData> Tasks = new List<TaskData>()
            {
                new TaskData() { TaskId = 1, TaskName = "Project initiation", StartDate = new DateTime(2021, 03, 28), EndDate = new DateTime(2021, 07, 28), TaskType = "FixedDuration", Duration = "4" },
                new TaskData() { TaskId = 2, TaskName = "Identify site location", StartDate = new DateTime(2021, 03, 29), Progress = 30, ParentId = 1, Duration = "2", ResourceName = "Rose Fuller" },
                new TaskData() { TaskId = 3, TaskName = "Perform soil test", StartDate = new DateTime(2021, 03, 29), ParentId = 1, Duration = "4", Progress = 30, TaskType = "FixedWork", ResourceName = "Margaret Buchanan" },
                new TaskData() { TaskId = 4, TaskName = "Soil test approval", StartDate = new DateTime(2021, 03, 29), Duration = "1", Progress = 30, ParentId = 1, ResourceName = "Fuller King", TaskType = "FixedWork" },
                new TaskData() { TaskId = 5, TaskName = "Market research", StartDate = new DateTime(2021, 03, 29), EndDate = new DateTime(2021, 04, 2), TaskType = "FixedDuration", Duration = "4" },
                new TaskData() { TaskId = 6, TaskName = "Demand analysis", StartDate = new DateTime(2021, 03, 29), Duration = "3", Progress = 30, ParentId = 5, ResourceName = "Van Jack", TaskType = "FixedWork" },
                new TaskData() { TaskId = 7, TaskName = "Customer strength", StartDate = new DateTime(2021, 04, 01), Duration = "3", Progress = 30, ParentId = 5, TaskType = "FixedWork", ResourceName = "Martin Tamer" },
                new TaskData() { TaskId = 8, TaskName = "Market opportunity analysis", StartDate = new DateTime(2021, 04, 01), Duration = "2", ParentId = 5, Progress = 30, TaskType = "FixedWork", ResourceName = "Jack Davolio" },
                new TaskData() { TaskId = 9, TaskName = "Project estimation", StartDate = new DateTime(2021, 03, 31), EndDate = new DateTime(2021, 04, 04), Duration = "5" },
                new TaskData() { TaskId = 10, TaskName = "Develop floor plan for estimation", StartDate = new DateTime(2021, 03, 31), Duration = "3", Progress = 30, ParentId = 9, ResourceName = "Fuller King", TaskType = "FixedWork" },
                new TaskData() { TaskId = 11, TaskName = "List materials", StartDate = new DateTime(2021, 04, 02), Duration = "2", Progress = 30, ParentId = 9, TaskType = "FixedWork", ResourceName = "Martin Tamer" },
                new TaskData() { TaskId = 12, TaskName = "Estimation approval", StartDate = new DateTime(2021, 04, 04), Duration = "2", ParentId = 9, Progress = 30, TaskType = "FixedWork", ResourceName = "Margaret Buchanan" }
            };

            return Tasks;
        }
    }
}
