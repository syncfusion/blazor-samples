using System;
using System.Collections.Generic;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart.Data
{
    internal sealed class TaskConstraintsData
    {
        public sealed class TaskData
        {
            public int TaskId { get; set; }
            public string? TaskName { get; set; }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public string? Duration { get; set; }
            public int Progress { get; set; }
            public string? Predecessor { get; set; }
            public string? Notes { get; set; }
            public int? ParentId { get; set; }
            public TaskConstraintType ConstraintType { get; set; }
            public DateTime? ConstraintDate { get; set; }
        }
        public static List<TaskData> GetTaskConstraintsData() => new()
        {
            new() { TaskId = 1, TaskName = "Software product release", StartDate = new DateTime(2026, 1, 7), Duration = "22 days", Progress = 58 },
            new() { TaskId = 2, ParentId = 1, TaskName = "Requirements gathering", StartDate = new DateTime(2026, 1, 7), Duration = "2 days", Progress = 100, ConstraintType = TaskConstraintType.AsSoonAsPossible },
            new() { TaskId = 3, ParentId = 1, TaskName = "Stakeholder approval", StartDate = new DateTime(2026, 1, 9), Duration = "1 day", Progress = 100, Predecessor = "2FS", ConstraintType = TaskConstraintType.MustStartOn, ConstraintDate = new DateTime(2026, 1, 9) },
            new() { TaskId = 4, ParentId = 1, TaskName = "UI design", StartDate = new DateTime(2026, 1, 12), Duration = "2 days", Progress = 100, Predecessor = "3FS", ConstraintType = TaskConstraintType.StartNoEarlierThan, ConstraintDate = new DateTime(2026, 1, 12) },
            new() { TaskId = 5, ParentId = 1, TaskName = "Architecture design", StartDate = new DateTime(2026, 1, 14), Duration = "1 day", Progress = 100, Predecessor = "4FS", ConstraintType = TaskConstraintType.MustStartOn, ConstraintDate = new DateTime(2026, 1, 14) },
            new() { TaskId = 6, ParentId = 1, TaskName = "Backend development", StartDate = new DateTime(2026, 1, 15), Duration = "3 days", Progress = 75, Predecessor = "5FS", ConstraintType = TaskConstraintType.MustStartOn, ConstraintDate = new DateTime(2026, 1, 15) },
            new() { TaskId = 7, ParentId = 1, TaskName = "Frontend development", StartDate = new DateTime(2026, 1, 15), Duration = "3 days", Progress = 65, Predecessor = "5FS", ConstraintType = TaskConstraintType.StartNoEarlierThan, ConstraintDate = new DateTime(2026, 1, 15) },
            new() { TaskId = 8, ParentId = 1, TaskName = "API integration", StartDate = new DateTime(2026, 1, 20), Duration = "2 days", Progress = 0, Predecessor = "6FS,7FS", ConstraintType = TaskConstraintType.AsSoonAsPossible },
            new() { TaskId = 9, ParentId = 1, TaskName = "Database optimization", StartDate = new DateTime(2026, 1, 20), Duration = "2 days", Progress = 0, Predecessor = "6FS", ConstraintType = TaskConstraintType.StartNoLaterThan, ConstraintDate = new DateTime(2026, 1, 20) },
            new() { TaskId = 10, ParentId = 1, TaskName = "Unit testing", StartDate = new DateTime(2026, 1, 22), Duration = "1 day", Progress = 0, Predecessor = "8FS", ConstraintType = TaskConstraintType.AsSoonAsPossible },
            new() { TaskId = 11, ParentId = 1, TaskName = "Integration testing", StartDate = new DateTime(2026, 1, 23), Duration = "2 days", Progress = 0, Predecessor = "10FS", ConstraintType = TaskConstraintType.StartNoEarlierThan, ConstraintDate = new DateTime(2026, 1, 23) },
            new() { TaskId = 12, ParentId = 1, TaskName = "Security review", StartDate = new DateTime(2026, 1, 23), Duration = "1 day", Progress = 0, Predecessor = "9FS", ConstraintType = TaskConstraintType.StartNoLaterThan, ConstraintDate = new DateTime(2026, 1, 23) },
            new() { TaskId = 13, ParentId = 1, TaskName = "Performance testing", StartDate = new DateTime(2026, 1, 27), Duration = "2 days", Progress = 0, Predecessor = "11FS", ConstraintType = TaskConstraintType.FinishNoLaterThan, ConstraintDate = new DateTime(2026, 1, 28) },
            new() { TaskId = 14, ParentId = 1, TaskName = "QA signoff", StartDate = new DateTime(2026, 1, 29), Duration = "1 day", Progress = 0, Predecessor = "12FS,13FS", ConstraintType = TaskConstraintType.MustFinishOn, ConstraintDate = new DateTime(2026, 1, 29) },
            new() { TaskId = 15, ParentId = 1, TaskName = "Release preparation", StartDate = new DateTime(2026, 1, 30), Duration = "2 days", Progress = 0, Predecessor = "14FS", ConstraintType = TaskConstraintType.MustFinishOn, ConstraintDate = new DateTime(2026, 2, 2) },
            new() { TaskId = 16, ParentId = 1, TaskName = "User documentation", StartDate = new DateTime(2026, 1, 30), Duration = "2 days", Progress = 0, Predecessor = "14FS", ConstraintType = TaskConstraintType.AsLateAsPossible },
            new() { TaskId = 17, ParentId = 1, TaskName = "Production deployment", StartDate = new DateTime(2026, 2, 3), Duration = "1 day", Progress = 0, Predecessor = "15FS,16FS", ConstraintType = TaskConstraintType.MustStartOn, ConstraintDate = new DateTime(2026, 2, 3) },
            new() { TaskId = 18, ParentId = 1, TaskName = "Go-live validation", StartDate = new DateTime(2026, 2, 4), Duration = "1 day", Progress = 0, Predecessor = "17FS", ConstraintType = TaskConstraintType.StartNoLaterThan, ConstraintDate = new DateTime(2026, 2, 4) },
            new() { TaskId = 19, ParentId = 1, TaskName = "Production monitoring", StartDate = new DateTime(2026, 2, 5), Duration = "2 days", Progress = 0, Predecessor = "18FS", ConstraintType = TaskConstraintType.AsLateAsPossible },
            new() { TaskId = 20, ParentId = 1, TaskName = "Project closure", StartDate = new DateTime(2026, 2, 9), Duration = "1 day", Progress = 0, Predecessor = "19FS", ConstraintType = TaskConstraintType.FinishNoLaterThan, ConstraintDate = new DateTime(2026, 2, 9) }
        };
    }
    
}
