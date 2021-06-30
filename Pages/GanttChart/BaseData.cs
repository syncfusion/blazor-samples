using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.GanttChart
{
    public class BaseData
    {
        public class TaskData
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public DateTime BaselineStartDate { get; set; }
            public DateTime BaselineEndDate { get; set; }
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
                BaselineStartDate= new DateTime(2019, 04, 02),
                BaselineEndDate= new DateTime(2019, 04, 04),
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 06),


            },
            new TaskData() {
                TaskId = 2,
                TaskName = "Identify Site location",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 02),
                Duration = "0",
                 BaselineStartDate= new DateTime(2019, 04, 02),
                BaselineEndDate= new DateTime(2019, 04, 02),
                Progress = 30,
                ParentId = 1,


            },
            new TaskData() {
                TaskId = 3,
                TaskName = "Perform soil test",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "5",
                Progress = 40,
                 BaselineStartDate= new DateTime(2019, 04, 02),
                BaselineEndDate= new DateTime(2019, 04, 06),
                ParentId = 1,

            },
            new TaskData() {
                TaskId = 4,
                TaskName = "Soil test approval",
                StartDate = new DateTime(2019, 04, 08),
                Duration = "0",
                  EndDate = new DateTime(2019, 04, 10),
                BaselineStartDate= new DateTime(2019, 04, 04),
                BaselineEndDate= new DateTime(2019, 04, 06),
                Progress = 30,
                ParentId = 1
            },
              new TaskData() {
                TaskId = 5,
                TaskName = "Project initiation",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 08),


            },
            new TaskData() {
                TaskId = 6,
                TaskName = "Identify Site location",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "2",
                Progress = 30,
                ParentId = 5,
                  BaselineStartDate= new DateTime(2019, 04, 02),
                BaselineEndDate= new DateTime(2019, 04, 02),

            },
            new TaskData() {
                TaskId = 7,
                TaskName = "Perform soil test",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "4",
                Progress = 40,
                ParentId = 5,
                BaselineStartDate= new DateTime(2019, 04, 02),
                BaselineEndDate= new DateTime(2019, 04, 03),

            },
            new TaskData() {
                TaskId = 8,
                TaskName = "Soil test approval",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "5",
                Progress = 30,
                ParentId = 5,
                BaselineStartDate= new DateTime(2019, 04, 02),
                BaselineEndDate= new DateTime(2019, 04, 04),
            },

        };
            return Tasks;
        }


    }
}

