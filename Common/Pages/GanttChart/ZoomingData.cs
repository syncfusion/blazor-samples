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
namespace ej2_blazor_zoomingdata
{
    public class ZoomingData
    {
        public class TaskData
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; } = string.Empty;
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public DateTime? BaselineStartDate { get; set; }
            public DateTime? BaselineEndDate { get; set; }
            public string? Duration { get; set; }
            public int Progress { get; set; }
            public string Predecessor { get; set; } = string.Empty;
            public List<TaskData>? SubTasks { get; set; }
            public object? ResourceId { get; set; }
            public int? ParentId { get; set; }
            public string? Notes { get; set; }
            public string TaskType { get; set; } = string.Empty;
        }
        public static List<TaskData> ZoomData()
        {
            List<TaskData> Tasks = new List<TaskData>()
            {
                new TaskData() { TaskId = 1, TaskName = "Product concept", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 08), Duration = "5days" },
                new TaskData() { TaskId = 2, TaskName = "Defining the product usage", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 08), Duration = "3", Progress = 30, ParentId = 1 },
                new TaskData() { TaskId = 3, TaskName = "Defining the target audience", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 04), Duration = "3", Progress = 40, ParentId = 1 },
                new TaskData() { TaskId = 4, TaskName = "Prepare product sketch and notes", StartDate = new DateTime(2021, 04, 05), EndDate = new DateTime(2021, 04, 08), Duration = "2", Progress = 30, ParentId = 1, Predecessor = "2" },
                new TaskData() { TaskId = 5, TaskName = "Concept approval", StartDate = new DateTime(2021, 04, 08), EndDate = new DateTime(2021, 04, 08), Duration = "0", Predecessor = "3,4" },
                new TaskData() { TaskId = 6, TaskName = "Market research", StartDate = new DateTime(2021, 04, 09), EndDate = new DateTime(2021, 04, 18), Duration = "4", Progress = 30 },
                new TaskData() { TaskId = 7, TaskName = "Demand analysis", StartDate = new DateTime(2021, 04, 09), EndDate = new DateTime(2021, 04, 12), Duration = "4", Progress = 40, ParentId = 6 },
                new TaskData() { TaskId = 8, TaskName = "Customer strength", StartDate = new DateTime(2021, 04, 09), EndDate = new DateTime(2021, 04, 12), Duration = "4", Progress = 30, ParentId = 7, Predecessor = "5" },
                new TaskData() { TaskId = 9, TaskName = "Market opportunity analysis", StartDate = new DateTime(2021, 04, 09), EndDate = new DateTime(2021, 04, 12), Duration = "4", ParentId = 7, Predecessor = "5" },
                new TaskData() { TaskId = 10, TaskName = "Competitor analysis", StartDate = new DateTime(2021, 04, 15), EndDate = new DateTime(2021, 04, 18), Duration = "4", Progress = 30, ParentId = 6, Predecessor = "7,8" },
                new TaskData() { TaskId = 11, TaskName = "Product strength analysis", StartDate = new DateTime(2021, 04, 15), EndDate = new DateTime(2021, 04, 18), Duration = "4", Progress = 40, ParentId = 6, Predecessor = "9" },
                new TaskData() { TaskId = 12, TaskName = "Research completed", StartDate = new DateTime(2021, 04, 18), EndDate = new DateTime(2021, 04, 18), Duration = "0", Progress = 30, ParentId = 6, Predecessor = "10" }
            };
            return Tasks;
        }
    }
}