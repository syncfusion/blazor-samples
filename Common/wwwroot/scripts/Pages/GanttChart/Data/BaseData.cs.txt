using System;
using System.Collections.Generic;

namespace BlazorDemos.Pages.GanttChart.Data
{
    public static class BaseData
    {
        internal sealed class TaskData
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; } = string.Empty;
            public DateTime? BaselineStartDate { get; set; }
            public DateTime? BaselineEndDate { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public string? Duration { get; set; }
            public int Progress { get; set; }
            public int? ParentId { get; set; }
        }

        /// <summary>
        /// Generates and returns a collection of Gantt task data.
        /// </summary>
        internal static List<TaskData> GetTaskCollection()
        {
            List<TaskData> Tasks = new List<TaskData>() {
                new TaskData() { TaskId = 1, TaskName = "Project initiation", BaselineStartDate= new DateTime(2021, 04, 02), BaselineEndDate= new DateTime(2021, 04, 04), StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 06) }, 
                new TaskData() { TaskId = 2, TaskName = "Identify site location", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 02), Duration = "0", BaselineStartDate= new DateTime(2021, 04, 02, 08, 00, 00), BaselineEndDate= new DateTime(2021, 04, 02, 08, 00, 00), Progress = 30, ParentId = 1 }, 
                new TaskData() { TaskId = 3, TaskName = "Perform soil test", StartDate = new DateTime(2021, 04, 02), Duration = "5", Progress = 40, BaselineStartDate= new DateTime(2021, 04, 02), BaselineEndDate= new DateTime(2021, 04, 06), ParentId = 1 }, 
                new TaskData() { TaskId = 4, TaskName = "Soil test approval", StartDate = new DateTime(2021, 04, 08), Duration = "0", EndDate = new DateTime(2021, 04, 08), BaselineStartDate= new DateTime(2021, 04, 08, 08, 00, 00), BaselineEndDate= new DateTime(2021, 04, 08, 08, 00, 00), Progress = 30, ParentId = 1 }, 
                new TaskData() { TaskId = 5, TaskName = "Project initiation", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 08) },
                new TaskData() { TaskId = 6, TaskName = "Identify site location", StartDate = new DateTime(2021, 04, 02), Duration = "2", Progress = 30, ParentId = 5, BaselineStartDate= new DateTime(2021, 04, 02), BaselineEndDate= new DateTime(2021, 04, 02) }, 
                new TaskData() { TaskId = 7, TaskName = "Perform soil test", StartDate = new DateTime(2021, 04, 02), Duration = "4", Progress = 40, ParentId = 5, BaselineStartDate= new DateTime(2021, 04, 02), BaselineEndDate= new DateTime(2021, 04, 03) }, 
                new TaskData() { TaskId = 8, TaskName = "Soil test approval", StartDate = new DateTime(2021, 04, 02), Duration = "5", Progress = 30, ParentId = 5, BaselineStartDate= new DateTime(2021, 04, 02), BaselineEndDate= new DateTime(2021, 04, 04) }, 
                new TaskData() { TaskId = 9, TaskName = "Market opportunity analysis", BaselineStartDate= new DateTime(2021, 04, 02), BaselineEndDate= new DateTime(2021, 04, 04), StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 06) }, 
                new TaskData() { TaskId = 10, TaskName = "Competitor analysis", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 02), Duration = "0", BaselineStartDate= new DateTime(2021, 04, 02, 08, 00, 00), BaselineEndDate= new DateTime(2021, 04, 02, 08, 00, 00), Progress = 30, ParentId= 9 }, 
                new TaskData() { TaskId = 11, TaskName = "Product strength analysis", StartDate = new DateTime(2021, 04, 02), Duration = "5", Progress = 40, BaselineStartDate= new DateTime(2021, 04, 02), BaselineEndDate= new DateTime(2021, 04, 06), ParentId = 9 }, 
                new TaskData() { TaskId = 12, TaskName = "Research completed", StartDate = new DateTime(2021, 04, 08), Duration = "0", EndDate = new DateTime(2021, 04, 08), BaselineStartDate= new DateTime(2021, 04, 08, 08, 00, 00), BaselineEndDate= new DateTime(2021, 04, 08, 08, 00, 00), Progress = 30, ParentId = 9 }, 
                new TaskData() { TaskId = 13, TaskName = "Product design and development", StartDate = new DateTime(2021, 04, 02), Duration = "5", Progress = 40, BaselineStartDate= new DateTime(2021, 04, 02), BaselineEndDate= new DateTime(2021, 04, 06), ParentId = 9 }
            };
            return Tasks;
        }
    }
}