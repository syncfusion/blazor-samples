using System;
using System.Collections.Generic;
namespace BlazorDemos.Pages.GanttChart.Data
{
    public class GanttDefaultTaskData
    {
        public int TaskId { get; set; }
        public string? TaskName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? BaselineStartDate { get; set; }
        public DateTime? BaselineEndDate { get; set; }
        public string? Duration { get; set; }
        public int Progress { get; set; }
        public string? Predecessor { get; set; }
        public object? ResourceId { get; set; }
        public string? Notes { get; set; }
        public string? TaskType { get; set; }
        public int? ParentId { get; set; }
    }
    public class HolidayModel
    {
        public DateTime HolidayDate { get; set; }
        public string? HolidayName { get; set; }
    }
    internal static class DefaultData
    {
        /// <summary>
        /// Generates and returns a collection of Gantt task data.
        /// </summary>
        internal static List<GanttDefaultTaskData> ProjectNewData()
        {
            List<GanttDefaultTaskData> Tasks = new List<GanttDefaultTaskData>() {
                new GanttDefaultTaskData() { TaskId = 1, TaskName = "Product concept", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 08), Duration = "5days" },
                new GanttDefaultTaskData() { TaskId = 2, TaskName = "Define the product usage", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 08), Duration = "3", Progress = 30, ParentId = 1, BaselineStartDate = new DateTime(2021, 04, 02), BaselineEndDate = new DateTime(2021, 04, 02) },
                new GanttDefaultTaskData() { TaskId = 3, TaskName = "Define the target audience", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 04), Progress = 40, Duration = "2Days", ParentId = 1 },
                new GanttDefaultTaskData() { TaskId = 4, TaskName = "Prepare product sketch and notes", StartDate = new DateTime(2021, 04, 05), Duration = "4", Progress = 30, ParentId = 1, Predecessor = "2" },
                new GanttDefaultTaskData() { TaskId = 5, TaskName = "Concept approval", StartDate = new DateTime(2021, 04, 08), EndDate = new DateTime(2021, 04, 08), Duration = "0", ParentId = 1, Predecessor = "3,4" },
                new GanttDefaultTaskData() { TaskId = 6, TaskName = "Market research", StartDate = new DateTime(2021, 04, 09), EndDate = new DateTime(2021, 04, 18), BaselineStartDate = new DateTime(2021, 04, 09), BaselineEndDate = new DateTime(2021, 04, 09), Duration = "4", Progress = 30 },
                new GanttDefaultTaskData() { TaskId = 7, TaskName = "Demand analysis", Duration = "4", Progress = 40, ParentId = 6 },
                new GanttDefaultTaskData() { TaskId = 8, TaskName = "Customer strength", StartDate = new DateTime(2021, 04, 09), EndDate = new DateTime(2021, 04, 12), Duration = "4", Progress = 30, ParentId = 7, Predecessor = "5", BaselineStartDate = new DateTime(2021, 04, 12), BaselineEndDate = new DateTime(2021, 04, 13) },
                new GanttDefaultTaskData() { TaskId = 9, TaskName = "Market opportunity analysis", StartDate = new DateTime(2021, 04, 09), EndDate = new DateTime(2021, 04, 12), Duration = "4", ParentId = 7, Predecessor = "5" },
                new GanttDefaultTaskData() { TaskId = 10, TaskName = "Competitor analysis", StartDate = new DateTime(2021, 04, 15), EndDate = new DateTime(2021, 04, 18), Duration = "4", Progress = 30, ParentId = 6, Predecessor = "7,8" },
                new GanttDefaultTaskData() { TaskId = 11, TaskName = "Product strength analysis", StartDate = new DateTime(2021, 04, 15), EndDate = new DateTime(2021, 04, 18), Duration = "4", Progress = 40, ParentId = 6, Predecessor = "9" },
                new GanttDefaultTaskData() { TaskId = 12, TaskName = "Research completed", StartDate = new DateTime(2021, 04, 18), EndDate = new DateTime(2021, 04, 18), Duration = "0", Progress = 30, ParentId = 6, Predecessor = "10" },
                new GanttDefaultTaskData() { TaskId = 13, TaskName = "Product design and development", StartDate = new DateTime(2021, 04, 19), EndDate = new DateTime(2021, 05, 16), Duration = "20" },
                new GanttDefaultTaskData() { TaskId = 14, TaskName = "Functionality design", StartDate = new DateTime(2021, 04, 19), EndDate = new DateTime(2021, 04, 23), Duration = "4", Progress = 30, ParentId = 13, Predecessor = "12" },
                new GanttDefaultTaskData() { TaskId = 15, TaskName = "Quality design", StartDate = new DateTime(2021, 04, 19), EndDate = new DateTime(2021, 04, 23), Duration = "3", Progress = 40, ParentId = 13, Predecessor = "12" },
                new GanttDefaultTaskData() { TaskId = 16, TaskName = "Define reliability", StartDate = new DateTime(2021, 04, 24), EndDate = new DateTime(2021, 04, 25), Duration = "4", Progress = 30, ParentId = 13, Predecessor = "15" },
                new GanttDefaultTaskData() { TaskId = 17, TaskName = "Identifying raw materials", StartDate = new DateTime(2021, 04, 24), EndDate = new DateTime(2021, 04, 25), Duration = "2", ParentId = 13, Predecessor = "15" },
                new GanttDefaultTaskData() { TaskId = 18, TaskName = "Define cost plan", StartDate = new DateTime(2021, 04, 26), EndDate = new DateTime(2021, 04, 29), Duration = "2", Progress = 30, ParentId = 13, Predecessor = "17" },
                new GanttDefaultTaskData() { TaskId = 19, TaskName = "Estimate manufacturing cost", StartDate = new DateTime(2021, 04, 26), EndDate = new DateTime(2021, 04, 29), Duration = "3", Progress = 40, ParentId = 18, Predecessor = "17" },
                new GanttDefaultTaskData() { TaskId = 20, TaskName = "Estimate selling cost", StartDate = new DateTime(2021, 04, 26), EndDate = new DateTime(2021, 04, 29), Duration = "3", Progress = 30, ParentId = 18, Predecessor = "17" },
                new GanttDefaultTaskData() { TaskId = 21, TaskName = "Development of final design", StartDate = new DateTime(2021, 04, 30), EndDate = new DateTime(2021, 05, 08), Duration="7", ParentId=13 },
                new GanttDefaultTaskData() { TaskId = 22, TaskName = "Develop dimensions and design", StartDate = new DateTime(2021, 04, 30), EndDate = new DateTime(2021, 05, 01), Duration = "4", Progress = 30, ParentId=21, Predecessor="19,20" },
                new GanttDefaultTaskData() { TaskId = 23, TaskName = "Develop designs to meet industry", StartDate = new DateTime(2021, 05, 02), EndDate = new DateTime(2021, 05, 03), Duration = "3", Progress = 40, ParentId = 21, Predecessor="22" },
                new GanttDefaultTaskData() { TaskId = 24, TaskName = "Include all the details", StartDate = new DateTime(2021, 05, 06), EndDate = new DateTime(2021, 05, 08), Duration = "4", Progress = 30, ParentId = 21, Predecessor="23" },
                new GanttDefaultTaskData() { TaskId = 25, TaskName = "CAD - Computer Aided Design", StartDate = new DateTime(2021, 05, 09), EndDate = new DateTime(2021, 05, 13), Duration="3", Predecessor="24" },
                new GanttDefaultTaskData() { TaskId = 26, TaskName = "CAM - Computer Aided Manufacturing", StartDate = new DateTime(2021, 05, 14), EndDate = new DateTime(2021, 05, 16), Duration = "4", Progress = 30, Predecessor="25" },
                new GanttDefaultTaskData() { TaskId = 27, TaskName = "Finalize the design", StartDate = new DateTime(2021, 04, 16), EndDate = new DateTime(2021, 04, 16), Duration = "0", Progress = 40, Predecessor="26" },
                new GanttDefaultTaskData() { TaskId = 28, TaskName = "Prototype testing", StartDate = new DateTime(2021, 05, 17), EndDate = new DateTime(2021, 05, 22), Duration = "4", Progress = 30, Predecessor="27" },
                new GanttDefaultTaskData() { TaskId = 29, TaskName = "Include feedback", StartDate = new DateTime(2021, 05, 17), EndDate = new DateTime(2021, 05, 22), Duration="4", Predecessor="28ss" },
                new GanttDefaultTaskData() { TaskId = 30, TaskName = "Manufacturing", StartDate = new DateTime(2021, 05, 23), EndDate = new DateTime(2021, 05, 29), Duration = "5", Progress = 30, Predecessor="28,29" },
                new GanttDefaultTaskData() { TaskId = 31, TaskName = "Assembling material into finished goods", StartDate = new DateTime(2021, 05, 30), EndDate = new DateTime(2021, 06, 05), Duration = "5", Progress = 40, Predecessor="30" },
                new GanttDefaultTaskData() { TaskId = 32, TaskName = "Final product development", StartDate = new DateTime(2021, 06, 06), EndDate = new DateTime(2021, 06, 13), Duration = "6", Progress = 30 },
                new GanttDefaultTaskData() { TaskId = 33, TaskName = "Important improvement", StartDate = new DateTime(2021, 06, 06), EndDate = new DateTime(2021, 06, 10), Duration="3", ParentId=32, Predecessor="31" },
                new GanttDefaultTaskData() { TaskId = 34, TaskName = "Customer testing and feedback", StartDate = new DateTime(2021, 06, 11), EndDate = new DateTime(2021, 06, 13), Duration = "4", Progress = 30, ParentId=32, Predecessor="33" },
                new GanttDefaultTaskData() { TaskId = 35, TaskName = "Final product development", StartDate = new DateTime(2021, 06, 14), EndDate = new DateTime(2021, 06, 19), Duration = "4", Progress = 40 },
                new GanttDefaultTaskData() { TaskId = 36, TaskName = "Important improvement", StartDate = new DateTime(2021, 06, 14), EndDate = new DateTime(2021, 06, 19), Duration = "4", Progress = 30, ParentId = 35, Predecessor="34" },
                new GanttDefaultTaskData() { TaskId = 37, TaskName = "Address any unforeseen issues", StartDate = new DateTime(2021, 06, 14), EndDate = new DateTime(2021, 06, 19), Duration = "4", Progress = 30, Predecessor="36ss", ParentId=35 },
                new GanttDefaultTaskData() { TaskId = 38, TaskName = "Finalize the product ", StartDate = new DateTime(2021, 06, 20), EndDate = new DateTime(2021, 07, 01), Duration = "8", Progress = 40 },
                new GanttDefaultTaskData() { TaskId = 39, TaskName = "Branding the product", StartDate = new DateTime(2021, 06, 20), EndDate = new DateTime(2021, 06, 25), Duration = "4", Progress = 30, ParentId = 38, Predecessor="37" },
                new GanttDefaultTaskData() { TaskId = 40, TaskName="Marketing and presales", StartDate=new DateTime(2021,06,26), EndDate=new DateTime(2021,07,01), ParentId=38, Duration="4", Predecessor="39" }
            };
            return Tasks;
        }
    }
}