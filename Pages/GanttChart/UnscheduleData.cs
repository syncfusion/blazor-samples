using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace ej2_blazor_unscheduledata
{
    public class UnscheduleData
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
            public List<TaskData> SubTasks { get; set; }
            public object ResourceId { get; set; }
            public string Notes { get; set; }
            public string TasksType { get; set; }
        }       
        public static List<TaskData> UnscheduledData()
        {
            List<TaskData> ganttData = new List<TaskData>();
            TaskData record1 = new TaskData()
            {
                TaskId = 1,
                TaskName = "Task 1",
                StartDate = new DateTime(2019, 01, 03),
                EndDate = new DateTime(2019, 01, 08),
                Duration = "5",
                TasksType = "",
            };
            TaskData record2 = new TaskData()
            {
                TaskId = 2,
                TaskName = "Task 2",
                Duration = "5",
                TasksType = "Task with duration only",
            };
            TaskData record3 = new TaskData()
            {
                TaskId = 3,
                TaskName = "Task 3",
                StartDate = new DateTime(2019, 01, 03),
                TasksType = "Task with start date only",

            };
            TaskData record4 = new TaskData()
            {
                TaskId = 4,
                TaskName = "Task 4",
                EndDate = new DateTime(2019, 01, 08),
                TasksType = "Task with end date only",
            };
            ganttData.Add(record1);
            ganttData.Add(record2);
            ganttData.Add(record3);
            ganttData.Add(record4);
            return ganttData;
        }
       
    }
}
