using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace ej2_blazor_defaultdata
{
    public class DefaultData
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
            public string TaskType { get; set; }
        }        
        public static List<TaskData> ProjectNewData()
        {
            List<TaskData> TaskDataCollection = new List<TaskData>();

            TaskData Record1 = new TaskData()
            {
                TaskId = 1,
                TaskName = "Product concept",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };

            TaskData Child11 = new TaskData()
            {
                TaskId = 2,
                TaskName = "Defining the product and its usage",
                StartDate = new DateTime(2019, 04, 02),
                Progress = 30,
                Duration = "3",
            };

            TaskData Child12 = new TaskData()
            {
                TaskId = 3,
                TaskName = "Defining target audience",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "3",
            };

            TaskData Child13 = new TaskData()
            {
                TaskId = 4,
                TaskName = "Prepare product sketch and notes",
                StartDate = new DateTime(2019, 04, 02),
                Progress = 30,
                Duration = "2",
                Predecessor = "2"
            };
            Record1.SubTasks.Add(Child11);
            Record1.SubTasks.Add(Child12);
            Record1.SubTasks.Add(Child13);

            TaskData Record2 = new TaskData()
            {
                TaskId = 5,
                TaskName = "Concept approval",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "0",
                Predecessor = "3, 4",
            };

            TaskData Record3 = new TaskData()
            {
                TaskId = 6,
                TaskName = "Market research",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };

            TaskData Record6Child1 = new TaskData()
            {
                TaskId = 7,
                TaskName = "Demand analysis",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };

            TaskData Record7Child1 = new TaskData()
            {
                TaskId = 8,
                TaskName = "Customer strength",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "4",
                Predecessor = "5",
                Progress = 30
            };

            TaskData Record7Child2 = new TaskData()
            {
                TaskId = 9,
                TaskName = "Market opportunity analysis",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "4",
                Predecessor = "5",
            };
            Record6Child1.SubTasks.Add(Record7Child1);
            Record6Child1.SubTasks.Add(Record7Child2);

            TaskData Record6Child2 = new TaskData()
            {
                TaskId = 10,
                TaskName = "Competitor analysis",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "4",
                Predecessor = "7, 8",
                Progress = 30,
            };
            TaskData Record6Child3 = new TaskData()
            {
                TaskId = 11,
                TaskName = "Product strength analsysis",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "4",
                Predecessor = "9",
            };
            TaskData Record6Child4 = new TaskData()
            {
                TaskId = 12,
                TaskName = "Research complete",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "0",
                Predecessor = "10",
            };
            Record3.SubTasks.Add(Record6Child1);
            Record3.SubTasks.Add(Record6Child2);
            Record3.SubTasks.Add(Record6Child3);
            Record3.SubTasks.Add(Record6Child4);

            TaskData Record4 = new TaskData()
            {
                TaskId = 13,
                TaskName = "Product design and development",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record13Child1 = new TaskData()
            {
                TaskId = 14,
                TaskName = "Functionality design",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "12"
            };
            TaskData Record13Child2 = new TaskData()
            {
                TaskId = 15,
                TaskName = "Quality design",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "12"
            };
            TaskData Record13Child3 = new TaskData()
            {
                TaskId = 16,
                TaskName = "Define reliability",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "2",
                Progress = 30,
                Predecessor = "15"
            };
            TaskData Record13Child4 = new TaskData()
            {
                TaskId = 17,
                TaskName = "Identifying raw materials",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "2",
                Predecessor = "15"
            };
            TaskData Record13Child5 = new TaskData()
            {
                TaskId = 18,
                TaskName = "Define cost plan",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record18Child1 = new TaskData()
            {
                TaskId = 19,
                TaskName = "Manufacturing cost",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "2",
                Predecessor = "17",
                Progress = 30
            };
            TaskData Record18Child2 = new TaskData()
            {
                TaskId = 20,
                TaskName = "Selling cost",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "2",
                Predecessor = "17",
            };
            Record13Child5.SubTasks.Add(Record18Child1);
            Record13Child5.SubTasks.Add(Record18Child2);

            TaskData Record13Child6 = new TaskData()
            {
                TaskId = 21,
                TaskName = "Development of the final design",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record21Child1 = new TaskData()
            {
                TaskId = 22,
                TaskName = "Defining dimensions and package volume",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "2",
                Predecessor = "19, 20",
                Progress = 30
            };
            TaskData Record21Child2 = new TaskData()
            {
                TaskId = 23,
                TaskName = "Develop design to meet industry standards",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "2",
                Predecessor = "22",
            };
            TaskData Record21Child3 = new TaskData()
            {
                TaskId = 24,
                TaskName = "Include all the details",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "23",
            };
            Record13Child6.SubTasks.Add(Record21Child1);
            Record13Child6.SubTasks.Add(Record21Child2);
            Record13Child6.SubTasks.Add(Record21Child3);
            TaskData Record13Child7 = new TaskData()
            {
                TaskId = 25,
                TaskName = "CAD Computer-aided design",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "24"
            };
            TaskData Record13Child8 = new TaskData()
            {
                TaskId = 26,
                TaskName = "CAM Computer-aided manufacturing",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "25"
            };
            TaskData Record13Child9 = new TaskData()
            {
                TaskId = 27,
                TaskName = "Design complete",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "0",
                Predecessor = "26",
            };
            TaskData Record5 = new TaskData()
            {
                TaskId = 28,
                TaskName = "Prototype testing",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "4",
                Progress = 30,
                Predecessor = "27"
            };
            TaskData Record6 = new TaskData()
            {
                TaskId = 29,
                TaskName = "Include feedback",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "4",
                Predecessor = "28ss"
            };
            TaskData Record7 = new TaskData()
            {
                TaskId = 30,
                TaskName = "Manufacturing",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "5",
                Progress = 30,
                Predecessor = "28, 29"
            };
            TaskData Record8 = new TaskData()
            {
                TaskId = 31,
                TaskName = "Assembling materials to finsihed goods",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "5",
                Predecessor = "30"
            };
            Record4.SubTasks.Add(Record13Child1);
            Record4.SubTasks.Add(Record13Child2);
            Record4.SubTasks.Add(Record13Child3);
            Record4.SubTasks.Add(Record13Child4);
            Record4.SubTasks.Add(Record13Child5);
            Record4.SubTasks.Add(Record13Child6);
            Record4.SubTasks.Add(Record13Child7);
            Record4.SubTasks.Add(Record13Child8);
            Record4.SubTasks.Add(Record13Child9);

            TaskData Record9 = new TaskData()
            {
                TaskId = 32,
                TaskName = "Feedback and testing",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record9Child1 = new TaskData()
            {
                TaskId = 33,
                TaskName = "Internal testing and feedback",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 45,
                Predecessor = "31",
            };
            TaskData Record9Child2 = new TaskData()
            {
                TaskId = 34,
                TaskName = "Customer testing and feedback",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 50,
                Predecessor = "33",
            };
            Record9.SubTasks.Add(Record9Child1);
            Record9.SubTasks.Add(Record9Child2);
            TaskData Record10 = new TaskData()
            {
                TaskId = 35,
                TaskName = "Final product development",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record10Child1 = new TaskData()
            {
                TaskId = 36,
                TaskName = "Important improvements",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "4",
                Progress = 30,
                Predecessor = "34",
            };
            TaskData Record10Child2 = new TaskData()
            {
                TaskId = 37,
                TaskName = "Address any unforeseen issues",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "4",
                Progress = 30,
                Predecessor = "36ss",
            };
            Record10.SubTasks.Add(Record10Child1);
            Record10.SubTasks.Add(Record10Child2);
            TaskData Record11 = new TaskData()
            {
                TaskId = 38,
                TaskName = "Final product",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record11Child1 = new TaskData()
            {
                TaskId = 39,
                TaskName = "Branding product",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "4",
                Predecessor = "37",
            };
            TaskData Record11Child2 = new TaskData()
            {
                TaskId = 40,
                TaskName = "Marketing and presales",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "4",
                Progress = 30,
                Predecessor = "39",
            };
            Record11.SubTasks.Add(Record11Child1);
            Record11.SubTasks.Add(Record11Child2);
            TaskDataCollection.Add(Record1);
            TaskDataCollection.Add(Record2);
            TaskDataCollection.Add(Record3);
            TaskDataCollection.Add(Record4);
            TaskDataCollection.Add(Record5);
            TaskDataCollection.Add(Record6);
            TaskDataCollection.Add(Record7);
            TaskDataCollection.Add(Record8);
            TaskDataCollection.Add(Record9);
            TaskDataCollection.Add(Record10);
            TaskDataCollection.Add(Record11);
            return TaskDataCollection;
        }
      
    }
}
