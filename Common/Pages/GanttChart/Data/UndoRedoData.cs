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
    public class UndoRedoData
    {
        public class TaskModel
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
        public static List<TaskModel> GetUndoRedoData()
        {
            List<TaskModel> Tasks = new List<TaskModel>
            {
                new TaskModel { TaskId = 1, TaskName = "Vision and alignment meeting", StartDate = new DateTime(2025, 11, 01), EndDate = new DateTime(2025, 11, 02), Duration = "2", Progress = 100 },
                new TaskModel { TaskId = 2, TaskName = "Stakeholder interviews", StartDate = new DateTime(2025, 11, 01), EndDate = new DateTime(2025, 11, 01), Duration = "1", Progress = 100, ParentId = 1 },
                new TaskModel { TaskId = 3, TaskName = "Business case approval", StartDate = new DateTime(2025, 11, 02), EndDate = new DateTime(2025, 11, 02), Duration = "1", Progress = 90, ParentId = 1, Predecessor = "2" },
                new TaskModel { TaskId = 4, TaskName = "Requirements workshop", StartDate = new DateTime(2025, 11, 03), EndDate = new DateTime(2025, 11, 05), Duration = "3", Progress = 0, Predecessor = "3" },
                new TaskModel { TaskId = 5, TaskName = "Risk assessment", StartDate = new DateTime(2025, 11, 03), EndDate = new DateTime(2025, 11, 04), Duration = "2", Progress = 0, ParentId = 4 },
                new TaskModel { TaskId = 6, TaskName = "Solution blueprint", StartDate = new DateTime(2025, 11, 05), EndDate = new DateTime(2025, 11, 05), Duration = "1", Progress = 0, ParentId = 4, Predecessor = "5" },
                new TaskModel { TaskId = 7, TaskName = "Application architecture", StartDate = new DateTime(2025, 11, 06), EndDate = new DateTime(2025, 11, 09), Duration = "4", Progress = 0, Predecessor = "6" },
                new TaskModel { TaskId = 8, TaskName = "Wireframe prototypes", StartDate = new DateTime(2025, 11, 06), EndDate = new DateTime(2025, 11, 07), Duration = "2", Progress = 0, ParentId = 7 },
                new TaskModel { TaskId = 9, TaskName = "Data model design", StartDate = new DateTime(2025, 11, 08), EndDate = new DateTime(2025, 11, 09), Duration = "2", Progress = 0, ParentId = 7, Predecessor = "8" },
                new TaskModel { TaskId = 10, TaskName = "Sprint development", StartDate = new DateTime(2025, 11, 10), EndDate = new DateTime(2025, 11, 16), Duration = "7", Progress = 0, Predecessor = "9" },
                new TaskModel { TaskId = 11, TaskName = "UI components build", StartDate = new DateTime(2025, 11, 10), EndDate = new DateTime(2025, 11, 12), Duration = "3", Progress = 0, ParentId = 10 },
                new TaskModel { TaskId = 12, TaskName = "API development", StartDate = new DateTime(2025, 11, 13), EndDate = new DateTime(2025, 11, 16), Duration = "4", Progress = 0, ParentId = 10, Predecessor = "11" },
                new TaskModel { TaskId = 13, TaskName = "System testing", StartDate = new DateTime(2025, 11, 17), EndDate = new DateTime(2025, 11, 20), Duration = "4", Progress = 0, Predecessor = "12" },
                new TaskModel { TaskId = 14, TaskName = "Functional test cases", StartDate = new DateTime(2025, 11, 17), EndDate = new DateTime(2025, 11, 18), Duration = "2", Progress = 0, ParentId = 13 },
                new TaskModel { TaskId = 15, TaskName = "Regression testing", StartDate = new DateTime(2025, 11, 19), EndDate = new DateTime(2025, 11, 20), Duration = "2", Progress = 0, ParentId = 13, Predecessor = "14" },
                new TaskModel { TaskId = 16, TaskName = "Release preparation", StartDate = new DateTime(2025, 11, 21), EndDate = new DateTime(2025, 11, 22), Duration = "2", Progress = 0, Predecessor = "15" },
                new TaskModel { TaskId = 17, TaskName = "Production deployment", StartDate = new DateTime(2025, 11, 23), EndDate = new DateTime(2025, 11, 23), Duration = "1", Progress = 0, ParentId = 16 },
                new TaskModel { TaskId = 18, TaskName = "Go-live support", StartDate = new DateTime(2025, 11, 24), EndDate = new DateTime(2025, 11, 24), Duration = "1", Progress = 0, ParentId = 16, Predecessor = "17" },
                new TaskModel { TaskId = 19, TaskName = "Post-implementation review", StartDate = new DateTime(2025, 11, 25), EndDate = new DateTime(2025, 11, 26), Duration = "2", Progress = 0, Predecessor = "18" },
                new TaskModel { TaskId = 20, TaskName = "Project sign-off", StartDate = new DateTime(2025, 11, 26), EndDate = new DateTime(2025, 11, 26), Duration = "1", Progress = 0, ParentId = 19 }
            };
            return Tasks;
        }
    }
}
