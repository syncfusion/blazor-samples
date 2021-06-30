using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.GanttChart
{
    public class ScheduleData
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
            public string IsManual { get; set; }
            public string TaskMode { get; set; }
        }


        public static List<TaskData> GetTaskCollection()
        {
            List<TaskData> Tasks = new List<TaskData>() {


            new TaskData() {
                TaskId = 1,
                TaskName = "Parent Task1",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 06),
                IsManual="true",




            },
            new TaskData() {
                TaskId = 2,
                TaskName = "Child Task1",
                 StartDate = new DateTime(2019, 04, 02),
                Duration = "2",





                Progress = 30,
                ParentId = 1,


            },
            new TaskData() {
                TaskId = 3,
                TaskName = "Child Task2",
                  StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 06),

                Progress = 40,

                ParentId = 1,

                 IsManual="true"


            },
            new TaskData() {
                TaskId = 4,
                TaskName = "Child Task3",
                StartDate = new DateTime(2019, 04, 02),

                 EndDate = new DateTime(2019, 04, 06),
                Progress = 30,
                ParentId = 1,



            },
              new TaskData() {
                TaskId = 5,
                TaskName = "Parent Task2",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 08),
                IsManual="true",



            },
            new TaskData() {
                TaskId = 6,
                TaskName = "Child Task1",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "2",
                Progress = 30,
                ParentId = 5,



            },
            new TaskData() {
                TaskId = 7,
                TaskName = "Child Task2",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "4",
                Progress = 40,
                ParentId = 5,







            },
            new TaskData() {
                TaskId = 8,
                TaskName = "Child Task3",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "5",
                Progress = 30,
                ParentId = 5,

                IsManual="true"
            },
            new TaskData() {
                TaskId = 9,
                TaskName = "Child Task4",
                 StartDate = new DateTime(2019, 04, 02),
                Duration = "2",



                Progress = 30,
                ParentId = 5,
                IsManual="true"


            },
            new TaskData() {
                TaskId = 10,
                TaskName = "Parent Task3",
                  StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 06),

                Progress = 40,




            },
            new TaskData() {
                TaskId = 11,
                TaskName = "Child Task1",
                StartDate = new DateTime(2019, 04, 02),

                 EndDate = new DateTime(2019, 04, 06),
                Progress = 30,
                ParentId = 10,

            },
              new TaskData() {
                TaskId = 12,
                TaskName = "Child Task2",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 08),
                ParentId=10,


            },
            new TaskData() {
                TaskId = 13,
                TaskName = "Child Task3",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "2",
                Progress = 30,
                ParentId = 10,



            },
            new TaskData() {
                TaskId = 14,
                TaskName = "Child Task4",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "4",
                Progress = 40,
                ParentId = 10,

                IsManual="true"


            },
            new TaskData() {
                TaskId = 15,
                TaskName = "Child Task5",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "5",
                Progress = 30,
                ParentId = 10,


            },



        };
            return Tasks;
        }


    }
}

