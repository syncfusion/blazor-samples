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
    public class CriticalPathData
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
        }
        /// <summary>
        /// Generates and returns a collection of Gantt task data.
        /// </summary>
        public static List<TaskData> CriticalData()
        {
            List<TaskData> Tasks = new List<TaskData>() {
                new TaskData() { TaskId = 1, TaskName = "Planning and permits", StartDate = new DateTime(2025, 03, 03), EndDate = new DateTime(2025, 04, 01), Duration = "20 days", Progress = 100 }, // Completed
                new TaskData() { TaskId = 2, TaskName = "Site evaluation", StartDate = new DateTime(2025, 04, 02), EndDate = new DateTime(2025, 04, 04), Duration = "2 days", Progress = 100, ParentId = 1 }, // Completed
                new TaskData() { TaskId = 3, TaskName = "Obtain permits", StartDate = new DateTime(2025, 04, 07), EndDate = new DateTime(2025, 04, 09), Duration = "3 days", Progress = 100, ParentId = 1, Predecessor = "2" }, // Completed
                new TaskData() { TaskId = 4, TaskName = "Site preparation", StartDate = new DateTime(2025, 04, 14), EndDate = new DateTime(2025, 04, 18), Duration = "5 days", Progress = 100 }, // Completed
                new TaskData() { TaskId = 5, TaskName = "Grading and excavation", StartDate = new DateTime(2025, 04, 15), EndDate = new DateTime(2025, 04, 17), Duration = "3 days", Progress = 100, ParentId = 4, Predecessor = "3" }, // Completed
                new TaskData() { TaskId = 6, TaskName = "Foundation and basement", StartDate = new DateTime(2025, 04, 22), EndDate = new DateTime(2025, 04, 28), Duration = "5 days", Progress = 100, ParentId = 4 }, // Completed
                new TaskData() { TaskId = 7, TaskName = "Basement walls", StartDate = new DateTime(2025, 04, 28), EndDate = new DateTime(2025, 04, 30), Duration = "3 days", Progress = 50, ParentId = 6, Predecessor = "5" }, // In Progress
                new TaskData() { TaskId = 8, TaskName = "Framing", StartDate = new DateTime(2025, 05, 01), EndDate = new DateTime(2025, 05, 07), Duration = "5 days", Progress = 0 }, // Not started
                new TaskData() { TaskId = 9, TaskName = "Frame floors", StartDate = new DateTime(2025, 05, 01), EndDate = new DateTime(2025, 05, 02), Duration = "2 days", Progress = 0, ParentId = 8, Predecessor = "7" }, // Not started
                new TaskData() { TaskId = 10, TaskName = "Install trusses", StartDate = new DateTime(2025, 05, 07), EndDate = new DateTime(2025, 05, 08), Duration = "2 days", Progress = 0, ParentId = 8, Predecessor = "9" }, // Not started
                new TaskData() { TaskId = 11, TaskName = "Roofing", StartDate = new DateTime(2025, 05, 09), EndDate = new DateTime(2025, 05, 13), Duration = "3 days", Progress = 0, Predecessor = "10" }, // Not started
                new TaskData() { TaskId = 12, TaskName = "Mechanical, electrical, plumbing", StartDate = new DateTime(2025, 05, 14), EndDate = new DateTime(2025, 05, 24), Duration = "9 days", Progress = 0 }, // Not started
                new TaskData() { TaskId = 13, TaskName = "HVAC installation", StartDate = new DateTime(2025, 05, 14), EndDate = new DateTime(2025, 05, 16), Duration = "3 days", Progress = 0, ParentId = 12, Predecessor = "11" }, // Not started
                new TaskData() { TaskId = 14, TaskName = "Electrical installation", StartDate = new DateTime(2025, 05, 22), EndDate = new DateTime(2025, 05, 24), Duration = "3 days", Progress = 0, ParentId = 12, Predecessor = "13" }, // Not started
                new TaskData() { TaskId = 15, TaskName = "Interior finishing", StartDate = new DateTime(2025, 05, 26), EndDate = new DateTime(2025, 06, 17), Duration = "15 days", Progress = 0, Predecessor = "14" }, // Not started
                new TaskData() { TaskId = 16, TaskName = "Insulation and drywall", StartDate = new DateTime(2025, 05, 26), EndDate = new DateTime(2025, 05, 30), Duration = "5 days", Progress = 0, ParentId = 15, Predecessor = "14" }, // Not started
                new TaskData() { TaskId = 17, TaskName = "Final fixture installation", StartDate = new DateTime(2025, 06, 13), EndDate = new DateTime(2025, 06, 15), Duration = "3 days", Progress = 0, ParentId = 15, Predecessor = "16" }, // Not started
                new TaskData() { TaskId = 18, TaskName = "Final inspection", StartDate = new DateTime(2025, 06, 26), EndDate = new DateTime(2025, 06, 30), Duration = "3 days", Progress = 0, Predecessor = "17" }, // Not started
                new TaskData() { TaskId = 19, TaskName = "Client handover", StartDate = new DateTime(2025, 07, 11), EndDate = new DateTime(2025, 07, 12), Duration = "2 days", Progress = 0, Predecessor = "18" }, // Not started
                new TaskData() { TaskId = 20, TaskName = "Celebrate project completion", StartDate = new DateTime(2025, 08, 07), EndDate = new DateTime(2025, 08, 09), Duration = "3 days", Progress = 0, Predecessor = "19" } // Not started
            };
            return Tasks;
        }
    }
}
