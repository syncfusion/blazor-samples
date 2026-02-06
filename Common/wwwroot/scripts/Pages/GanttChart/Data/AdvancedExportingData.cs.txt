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
    public class AdvancedExportingData
    {
        public class TaskData
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; } = string.Empty;
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public string? Duration { get; set; }
            public int Progress { get; set; }
            public string Predecessor { get; set; } = string.Empty;
            public string Notes { get; set; } = string.Empty;
            public int? ParentId { get; set; }
            public string ResourceName { get; set; } = string.Empty;

        }
        /// <summary>
        /// Returns the task data for the Advanced Exporting sample.
        /// </summary>
        public static List<TaskData> GetTaskCollection()
        {
            List<TaskData> Tasks = new List<TaskData>()
            {
                new TaskData() { TaskId = 1, TaskName = "Product concept", StartDate = new DateTime(2025, 04, 02), EndDate = new DateTime(2025, 04, 08), Duration = "5 days" },
                new TaskData() { TaskId = 2, TaskName = "Defining the product usage", StartDate = new DateTime(2025, 03, 29), EndDate = new DateTime(2025, 04, 08), Duration = "3", Progress = 30, ResourceName = "Rose Fuller", ParentId = 1 },
                new TaskData() { TaskId = 3, TaskName = "Defining the target audience", StartDate = new DateTime(2025, 3, 29), EndDate = new DateTime(2025, 04, 04), Duration = "3", Progress = 40, ResourceName = "Margaret Buchanan", ParentId = 1 },
                new TaskData() { TaskId = 4, TaskName = "Prepare product sketch and notes", StartDate = new DateTime(2025, 04, 05), EndDate = new DateTime(2025, 04, 08), Duration = "2", Progress = 30, ResourceName = "Fuller King", ParentId = 1, Predecessor = "2" },
                new TaskData() { TaskId = 5, TaskName = "Concept approval", StartDate = new DateTime(2025, 04, 08), EndDate = new DateTime(2025, 04, 08), Duration = "0", Predecessor = "4" },
                new TaskData() { TaskId = 6, TaskName = "Market research", StartDate = new DateTime(2025, 04, 09), EndDate = new DateTime(2025, 04, 18), Duration = "4", Progress = 30 },
                new TaskData() { TaskId = 7, TaskName = "Demand analysis", StartDate = new DateTime(2025, 04, 09), EndDate = new DateTime(2025, 04, 12), Duration = "4", Progress = 40, ParentId = 6 },
                new TaskData() { TaskId = 8, TaskName = "Customer strength", StartDate = new DateTime(2025, 04, 09), EndDate = new DateTime(2025, 04, 12), Duration = "4", Progress = 30, ResourceName = "Martin Tamer", ParentId = 7, Predecessor = "5" },
                new TaskData() { TaskId = 9, TaskName = "Market opportunity analysis", StartDate = new DateTime(2025, 04, 09), EndDate = new DateTime(2025, 04, 12), Duration = "4", ResourceName = "Jack Davolio", ParentId = 7, Predecessor = "5" },
                new TaskData() { TaskId = 10, TaskName = "Competitor analysis", StartDate = new DateTime(2025, 04, 15), EndDate = new DateTime(2025, 04, 18), Duration = "4", Progress = 30, ResourceName = "Margaret Buchanan", ParentId = 6 },
                new TaskData() { TaskId = 11, TaskName = "Product strength analysis", StartDate = new DateTime(2025, 04, 15), EndDate = new DateTime(2025, 04, 18), Duration = "4", Progress = 40, ResourceName = "Jos", ParentId = 6, Predecessor = "9" },
                new TaskData() { TaskId = 12, TaskName = "Research completed", StartDate = new DateTime(2025, 04, 18), EndDate = new DateTime(2025, 04, 18), Duration = "0", Progress = 30, ParentId = 6, Predecessor = "10" },
                new TaskData() { TaskId = 13, TaskName = "Product design and development", StartDate = new DateTime(2025, 04, 19), EndDate = new DateTime(2025, 05, 16), Duration = "20", Predecessor = "6" },
                new TaskData() { TaskId = 14, TaskName = "Functionality design", StartDate = new DateTime(2025, 04, 19), EndDate = new DateTime(2025, 04, 23), Duration = "3", Progress = 30, ResourceName = "Fuller King", ParentId = 13, Predecessor = "12" },
                new TaskData() { TaskId = 15, TaskName = "Quality design", StartDate = new DateTime(2025, 04, 19), EndDate = new DateTime(2025, 04, 23), Duration = "4", Progress = 40, ResourceName = "Van Jack", ParentId = 13, Predecessor = "12" },
                new TaskData() { TaskId = 16, TaskName = "Define reliability", StartDate = new DateTime(2025, 04, 24), EndDate = new DateTime(2025, 04, 25), Duration = "2", Progress = 30, ResourceName = "Margaret Buchanan", ParentId = 13, Predecessor = "15" },
                new TaskData() { TaskId = 17, TaskName = "Identifying raw materials", StartDate = new DateTime(2025, 04, 24), EndDate = new DateTime(2025, 04, 25), Duration = "2", ResourceName = "Martin Tamer", ParentId = 13, Predecessor = "15" },
                new TaskData() { TaskId = 18, TaskName = "Define cost plan", StartDate = new DateTime(2025, 04, 26), EndDate = new DateTime(2025, 04, 29), Duration = "2", Progress = 30, ParentId = 13, Predecessor = "17" },
                new TaskData() { TaskId = 19, TaskName = "Manufacturing cost", StartDate = new DateTime(2025, 04, 26), EndDate = new DateTime(2025, 04, 29), Duration = "3", Progress = 40, ResourceName = "Jack Davolio", ParentId = 18, Predecessor = "17" },
                new TaskData() { TaskId = 20, TaskName = "Selling cost", StartDate = new DateTime(2025, 04, 26), EndDate = new DateTime(2025, 04, 29), Duration = "3", Progress = 30, ResourceName = "Rose Fuller", ParentId = 18, Predecessor = "17" },
                new TaskData() { TaskId = 21, TaskName = "Development of final design", StartDate = new DateTime(2025, 04, 30), EndDate = new DateTime(2025, 05, 08), Duration = "7", ParentId = 13 },
                new TaskData() { TaskId = 22, TaskName = "Develop dimensions and design", StartDate = new DateTime(2025, 04, 30), EndDate = new DateTime(2025, 05, 01), Duration = "2", Progress = 30, ResourceName = "Jos", ParentId = 21, Predecessor = "19,20" },
                new TaskData() { TaskId = 23, TaskName = "Develop designs to meet industry", StartDate = new DateTime(2025, 05, 02), EndDate = new DateTime(2025, 05, 03), Duration = "3", Progress = 40, ResourceName = "Kalin", ParentId = 21, Predecessor = "22" },
                new TaskData() { TaskId = 24, TaskName = "Include all the details", StartDate = new DateTime(2025, 05, 06), EndDate = new DateTime(2025, 05, 08), Duration = "3", Progress = 30, ResourceName = "Fuller King", ParentId = 21, Predecessor = "23" },
            };
            return Tasks;
        }
    }
}
