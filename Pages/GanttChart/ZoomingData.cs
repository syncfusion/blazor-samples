using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace ej2_blazor_zoomingdata
{
    public class ZoomingData
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


        public static List<TaskData> ZoomData()
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
                Duration = "1",
                Predecessor = "10",
            };
            Record3.SubTasks.Add(Record6Child1);
            Record3.SubTasks.Add(Record6Child2);
            Record3.SubTasks.Add(Record6Child3);
            Record3.SubTasks.Add(Record6Child4);

            TaskDataCollection.Add(Record1);
            TaskDataCollection.Add(Record2);
            TaskDataCollection.Add(Record3);

            return TaskDataCollection;
        }

    }
}
