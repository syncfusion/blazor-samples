using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace ej2_blazor_unscheduledata
{
    public class UnscheduleData
    {
        public class TaskData
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Duration { get; set; }
            public int Progress { get; set; }
            public int? ParentId { get; set; }
        }

        public static List<TaskData> GetTaskCollection()
        {
            List<TaskData> Tasks = new List<TaskData>() {

            new TaskData() {
                TaskId = 1,
                TaskName = "Project initiation",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 06),
            },
            new TaskData() {
                TaskId = 2,
                TaskName = "Task with duration only",
                Duration = "2",
                Progress = 30,
                ParentId = 1,
            },
            new TaskData() {
                TaskId = 3,
                TaskName = "Task with end date only",
                EndDate = new DateTime(2019, 04, 03),
                Progress = 40,
                ParentId = 1,
            },
            new TaskData() {
                TaskId = 4,
                TaskName = "Task with start date only",
                StartDate = new DateTime(2019, 04, 02),
                Progress = 30,
                ParentId = 1
            },
        };
            return Tasks;
        }
    }
}
