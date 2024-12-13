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
namespace ej2_blazor_timelinedata
{
    public class TimelineData
    {
        public class TaskData
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public DateTime? BaselineStartDate { get; set; }
            public DateTime? BaselineEndDate { get; set; }
            public string Duration { get; set; }
            public int Progress { get; set; }
            public string Predecessor { get; set; }
            public int?ParentId { get; set; }
            public object ResourceId { get; set; }
            public string Notes { get; set; }
            public string TaskType { get; set; }
        }
       
        public static List<TaskData> TimelineRecord()
        {
            List<TaskData> Tasks = new List<TaskData>() 
            {
                new TaskData() { TaskId = 1, TaskName = "Project initiation", StartDate = new DateTime(2021, 04, 03), EndDate = new DateTime(2021, 04, 21) },
                new TaskData() { TaskId = 2, TaskName = "Identify site location", StartDate = new DateTime(2021, 04, 03), Duration = "5", Progress = 70, ParentId=1 },
                new TaskData() { TaskId = 3, TaskName = "Perform soil test", StartDate = new DateTime(2021, 04, 03), Duration = "5", Progress = 50, ParentId = 1 },
                new TaskData() { TaskId = 4, TaskName = "Soil test approval", StartDate = new DateTime(2021, 04, 03), Duration = "5", Progress = 50, ParentId = 1, Predecessor="2" },
                new TaskData() { TaskId = 5, TaskName = "Project estimation", StartDate = new DateTime(2021, 04, 10), EndDate = new DateTime(2021, 04, 21) },
                new TaskData() { TaskId = 6, TaskName = "Develop floor plan for estimation", StartDate = new DateTime(2021, 04, 10), Duration = "5", ParentId=5 },
                new TaskData() { TaskId = 7, TaskName = "List materials", StartDate = new DateTime(2021, 04, 10), Duration = "5", Progress = 50, ParentId = 5 },
                new TaskData() { TaskId = 8, TaskName = "Development of final design", StartDate = new DateTime(2021, 04, 30), EndDate = new DateTime(2021, 05, 08), Duration="7" },
                new TaskData() { TaskId = 9, TaskName = "Develop dimensions and design", StartDate = new DateTime(2021, 04, 03), EndDate = new DateTime(2021, 04, 21), Duration = "2", Progress = 30, ParentId = 8 },
                new TaskData() { TaskId = 10, TaskName = "Develop designs to meet industry", StartDate = new DateTime(2021, 04, 03), Duration = "2", Progress = 40, ParentId = 8 },
                new TaskData() { TaskId = 11, TaskName = "Include all the details", StartDate = new DateTime(2021, 04, 03), Duration = "3", Progress = 30, ParentId = 8 },
                new TaskData() { TaskId = 12, TaskName = "CAD - Computer Aided Design", StartDate = new DateTime(2021, 04, 03), Duration = "3", ParentId = 8 },

            };
            return Tasks;
        }
    }
}