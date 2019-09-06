using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_ganttdata
{
    public class GanttTemplateModel
    {
        public string TaskName { get; set; }
    }

    public class GanttData
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
            public int[] ResourceId { get; set; }
            public string Notes { get; set; }
            public string TaskType { get; set; }
        }
        public class TaskResources
        {
            public int ResourceId { get; set; }
            public string ResourceName { get; set; }
        }
        public class TaskbarData : TaskData
        {
            public string Performance { get; set; }
            public string Winner { get; set; }
            public string Movie { get; set; }

        }
        public static List<TaskData> ZoomingData()
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

        public static List<TaskData> TimelineData()
        {
            List<TaskData> GanttDataSourceCollection = new List<TaskData>();

            TaskData Record1 = new TaskData()
            {
                TaskId = 1,
                TaskName = "Project schedule",
                StartDate = new DateTime(2019, 02, 08),
                EndDate = new DateTime(2019, 03, 15),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record1Child1 = new TaskData()
            {
                TaskId = 2,
                TaskName = "Planning",
                StartDate = new DateTime(2019, 02, 08),
                EndDate = new DateTime(2019, 02, 12),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record2Child1 = new TaskData()
            {
                TaskId = 3,
                TaskName = "Plan timeline",
                StartDate = new DateTime(2019, 02, 08),
                EndDate = new DateTime(2019, 02, 12),
                Duration = "5",
                Progress = 100,
                ResourceId = new int[] { 1 }
            };
            TaskData Record2Child2 = new TaskData()
            {
                TaskId = 4,
                TaskName = "Plan budget",
                StartDate = new DateTime(2019, 02, 08),
                EndDate = new DateTime(2019, 02, 12),
                Duration = "5",
                Progress = 100,
                ResourceId = new int[] { 1 }
            };
            TaskData Record2Child3 = new TaskData()
            {
                TaskId = 5,
                TaskName = "Allocate resources",
                StartDate = new DateTime(2019, 02, 08),
                EndDate = new DateTime(2019, 02, 12),
                Duration = "5",
                Progress = 100,
                ResourceId = new int[] { 1 }
            };
            TaskData Record2Child4 = new TaskData()
            {
                TaskId = 6,
                TaskName = "Planning complete",
                StartDate = new DateTime(2019, 02, 10),
                EndDate = new DateTime(2019, 02, 10),
                Duration = "0",
                Progress = 100,
                Predecessor = "3, 4, 5"
            };

            Record1Child1.SubTasks.Add(Record2Child1);
            Record1Child1.SubTasks.Add(Record2Child2);
            Record1Child1.SubTasks.Add(Record2Child3);
            Record1Child1.SubTasks.Add(Record2Child4);

            TaskData Record1Child2 = new TaskData()
            {
                TaskId = 7,
                TaskName = "Design",
                StartDate = new DateTime(2019, 02, 15),
                EndDate = new DateTime(2019, 02, 19),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record7Child1 = new TaskData()
            {
                TaskId = 8,
                TaskName = "Software specification",
                StartDate = new DateTime(2019, 02, 15),
                EndDate = new DateTime(2019, 02, 17),
                Duration = "3",
                Progress = 60,
                Predecessor = "6",
                ResourceId = new int[] { 2 }
            };
            TaskData Record7Child2 = new TaskData()
            {
                TaskId = 9,
                TaskName = "Develop prototype",
                StartDate = new DateTime(2019, 02, 15),
                EndDate = new DateTime(2019, 02, 17),
                Duration = "3",
                Progress = 100,
                Predecessor = "6",
                ResourceId = new int[] { 3 }
            };
            TaskData Record7Child3 = new TaskData()
            {
                TaskId = 10,
                TaskName = "Get approval from customer",
                StartDate = new DateTime(2019, 02, 18),
                EndDate = new DateTime(2019, 02, 19),
                Duration = "2",
                Progress = 100,
                Predecessor = "9",
                ResourceId = new int[] { 1 }
            };
            TaskData Record7Child4 = new TaskData()
            {
                TaskId = 11,
                TaskName = "Design complete",
                StartDate = new DateTime(2019, 02, 17),
                EndDate = new DateTime(2019, 02, 17),
                Duration = "0",
                Predecessor = "10"
            };
            Record1Child2.SubTasks.Add(Record7Child1);
            Record1Child2.SubTasks.Add(Record7Child2);
            Record1Child2.SubTasks.Add(Record7Child3);
            Record1Child2.SubTasks.Add(Record7Child4);

            TaskData Record1Child3 = new TaskData()
            {
                TaskId = 12,
                TaskName = "Implementation phase",
                StartDate = new DateTime(2019, 02, 25),
                EndDate = new DateTime(2019, 03, 05),
                SubTasks = new List<TaskData>(),
            };

            TaskData Record12Child1 = new TaskData()
            {
                TaskId = 13,
                TaskName = "Phase 1",
                StartDate = new DateTime(2019, 02, 25),
                EndDate = new DateTime(2019, 03, 07),
                SubTasks = new List<TaskData>(),
            };

            TaskData Record13Child1 = new TaskData()
            {
                TaskId = 14,
                TaskName = "Implementation module 1",
                StartDate = new DateTime(2019, 02, 25),
                EndDate = new DateTime(2019, 03, 07),
                SubTasks = new List<TaskData>(),
            };
            Record12Child1.SubTasks.Add(Record13Child1);
            TaskData Record14Child1 = new TaskData()
            {
                TaskId = 15,
                TaskName = "Development task 1",
                StartDate = new DateTime(2019, 02, 22),
                EndDate = new DateTime(2019, 02, 24),
                Duration = "3",
                Progress = 50,
                Predecessor = "11",
                ResourceId = new int[] { 3 }
            };
            TaskData Record14Child6 = new TaskData()
            {
                TaskId = 16,
                TaskName = "Development task 2",
                StartDate = new DateTime(2019, 02, 22),
                EndDate = new DateTime(2019, 02, 24),
                Duration = "3",
                Progress = 50,
                Predecessor = "11",
                ResourceId = new int[] { 3 }
            };
            TaskData Record14Child2 = new TaskData()
            {
                TaskId = 17,
                TaskName = "Testing",
                StartDate = new DateTime(2019, 02, 25),
                EndDate = new DateTime(2019, 02, 26),
                Duration = "2",
                Progress = 0,
                Predecessor = "15, 16",
                ResourceId = new int[] { 4 }
            };
            TaskData Record14Child3 = new TaskData()
            {
                TaskId = 18,
                TaskName = "Bug fix",
                StartDate = new DateTime(2019, 03, 01),
                EndDate = new DateTime(2019, 03, 02),
                Duration = "2",
                Progress = 0,
                Predecessor = "17",
                ResourceId = new int[] { 3 }
            };
            TaskData Record14Child4 = new TaskData()
            {
                TaskId = 19,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2019, 03, 03),
                EndDate = new DateTime(2019, 03, 07),
                Duration = "2",
                Progress = 0,
                Predecessor = "18",
                ResourceId = new int[] { 1 }
            };
            TaskData Record14Child5 = new TaskData()
            {
                TaskId = 20,
                TaskName = "Phase 1 complete",
                StartDate = new DateTime(2019, 03, 05),
                EndDate = new DateTime(2019, 03, 05),
                Duration = "0",
                Predecessor = "19"
            };
            Record13Child1.SubTasks.Add(Record14Child1);
            Record13Child1.SubTasks.Add(Record14Child2);
            Record13Child1.SubTasks.Add(Record14Child3);
            Record13Child1.SubTasks.Add(Record14Child4);
            Record13Child1.SubTasks.Add(Record14Child5);

            TaskData Record12Child2 = new TaskData()
            {
                TaskId = 21,
                TaskName = "Phase 2",
                StartDate = new DateTime(2019, 02, 25),
                EndDate = new DateTime(2019, 03, 05),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record21 = new TaskData()
            {
                TaskId = 22,
                TaskName = "Implementation module 2",
                StartDate = new DateTime(2019, 02, 25),
                EndDate = new DateTime(2019, 03, 05),
                SubTasks = new List<TaskData>(),
            };
            Record12Child2.SubTasks.Add(Record21);

            TaskData Record22 = new TaskData()
            {
                TaskId = 23,
                TaskName = "Development task 1",
                StartDate = new DateTime(2019, 02, 22),
                EndDate = new DateTime(2019, 02, 25),
                Duration = "4",
                Progress = 50,
                ResourceId = new int[] { 3 }
            };
            TaskData Record22Child1 = new TaskData()
            {
                TaskId = 24,
                TaskName = "Development task 2",
                StartDate = new DateTime(2019, 02, 22),
                EndDate = new DateTime(2019, 02, 25),
                Duration = "4",
                Progress = 50,
                ResourceId = new int[] { 3 }
            };
            TaskData Record22Child2 = new TaskData()
            {
                TaskId = 25,
                TaskName = "Testing",
                StartDate = new DateTime(2019, 02, 26),
                EndDate = new DateTime(2019, 03, 01),
                Duration = "2",
                Progress = 0,
                Predecessor = "23, 24",
                ResourceId = new int[] { 4 }
            };
            TaskData Record22Child3 = new TaskData()
            {
                TaskId = 26,
                TaskName = "Bug fix",
                StartDate = new DateTime(2019, 03, 02),
                EndDate = new DateTime(2019, 03, 03),
                Duration = "2",
                Progress = 0,
                Predecessor = "25",
                ResourceId = new int[] { 4 }
            };
            TaskData Record22Child4 = new TaskData()
            {
                TaskId = 27,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2019, 03, 07),
                EndDate = new DateTime(2019, 03, 09),
                Duration = "2",
                Progress = 0,
                Predecessor = "26",
                ResourceId = new int[] { 1 }
            };
            TaskData Record22Child5 = new TaskData()
            {
                TaskId = 28,
                TaskName = "Phase 2 complete",
                StartDate = new DateTime(2019, 03, 03),
                EndDate = new DateTime(2019, 03, 03),
                Duration = "0",
                Predecessor = "27"
            };
            Record21.SubTasks.Add(Record22Child1);
            Record21.SubTasks.Add(Record22Child2);
            Record21.SubTasks.Add(Record22Child3);
            Record21.SubTasks.Add(Record22Child4);
            Record21.SubTasks.Add(Record22Child5);

            TaskData Record12Child3 = new TaskData()
            {
                TaskId = 29,
                TaskName = "Phase 3",
                StartDate = new DateTime(2019, 02, 25),
                EndDate = new DateTime(2019, 03, 07),
                SubTasks = new List<TaskData>(),
            };
            Record1Child3.SubTasks.Add(Record12Child1);
            Record1Child3.SubTasks.Add(Record12Child2);
            Record1Child3.SubTasks.Add(Record12Child3);

            TaskData Record30 = new TaskData()
            {
                TaskId = 30,
                TaskName = "Implementation module 3",
                StartDate = new DateTime(2019, 02, 25),
                EndDate = new DateTime(2019, 03, 07),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record30Child1 = new TaskData()
            {
                TaskId = 31,
                TaskName = "Development task 1",
                StartDate = new DateTime(2019, 02, 22),
                EndDate = new DateTime(2019, 02, 24),
                Duration = "3",
                Progress = 50,
                ResourceId = new int[] { 3 }
            };
            TaskData Record30Child2 = new TaskData()
            {
                TaskId = 32,
                TaskName = "Development task 2",
                StartDate = new DateTime(2019, 02, 22),
                EndDate = new DateTime(2019, 02, 24),
                Duration = "3",
                Progress = 50,
                ResourceId = new int[] { 3 }
            };
            TaskData Record30Child3 = new TaskData()
            {
                TaskId = 33,
                TaskName = "Testing",
                StartDate = new DateTime(2019, 02, 25),
                EndDate = new DateTime(2019, 02, 26),
                Duration = "2",
                Progress = 0,
                Predecessor = "31, 32",
                ResourceId = new int[] { 4 }
            };
            TaskData Record30Child4 = new TaskData()
            {
                TaskId = 34,
                TaskName = "Bug fix",
                StartDate = new DateTime(2019, 03, 01),
                EndDate = new DateTime(2019, 03, 05),
                Duration = "2",
                Progress = 0,
                Predecessor = "33",
                ResourceId = new int[] { 3 }
            };
            TaskData Record30Child5 = new TaskData()
            {
                TaskId = 35,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2019, 03, 03),
                EndDate = new DateTime(2019, 03, 04),
                Duration = "2",
                Progress = 0,
                Predecessor = "34",
                ResourceId = new int[] { 1 }
            };
            TaskData Record30Child6 = new TaskData()
            {
                TaskId = 36,
                TaskName = "Phase 3 complete",
                StartDate = new DateTime(2019, 03, 02),
                EndDate = new DateTime(2019, 03, 02),
                Duration = "0",
                Predecessor = "35"
            };

            Record30.SubTasks.Add(Record30Child1);
            Record30.SubTasks.Add(Record30Child2);
            Record30.SubTasks.Add(Record30Child3);
            Record30.SubTasks.Add(Record30Child4);
            Record30.SubTasks.Add(Record30Child5);
            Record30.SubTasks.Add(Record30Child6);

            TaskData Record1Child4 = new TaskData()
            {
                TaskId = 37,
                TaskName = "Integration",
                StartDate = new DateTime(2019, 03, 08),
                EndDate = new DateTime(2019, 03, 10),
                Duration = "3",
                Progress = 0,
                Predecessor = "20, 28, 36",
                ResourceId = new int[] { 3 }
            };
            TaskData Record1Child5 = new TaskData()
            {
                TaskId = 38,
                TaskName = "Final testing",
                StartDate = new DateTime(2019, 03, 11),
                EndDate = new DateTime(2019, 03, 12),
                Duration = "2",
                Progress = 0,
                Predecessor = "37",
                ResourceId = new int[] { 4 }
            };
            TaskData Record1Child6 = new TaskData()
            {
                TaskId = 39,
                TaskName = "Finald delivery",
                StartDate = new DateTime(2019, 03, 10),
                EndDate = new DateTime(2019, 03, 10),
                Duration = "0",
                Predecessor = "38",
            };
            Record1.SubTasks.Add(Record1Child1);
            Record1.SubTasks.Add(Record1Child2);
            Record1.SubTasks.Add(Record1Child3);
            GanttDataSourceCollection.Add(Record1);
            GanttDataSourceCollection.Add(Record13Child1);
            GanttDataSourceCollection.Add(Record1Child4);
            GanttDataSourceCollection.Add(Record1Child5);
            GanttDataSourceCollection.Add(Record1Child6);
            return GanttDataSourceCollection;
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
                TaskType = "",
            };
            TaskData record2 = new TaskData()
            {
                TaskId = 2,
                TaskName = "Task 2",
                Duration = "5",
                TaskType = "Task with duration only",
            };
            TaskData record3 = new TaskData()
            {
                TaskId = 3,
                TaskName = "Task 3",
                StartDate = new DateTime(2019, 01, 03),
                TaskType = "Task with start date only",

            };
            TaskData record4 = new TaskData()
            {
                TaskId = 4,
                TaskName = "Task 4",
                EndDate = new DateTime(2019, 01, 08),
                TaskType = "Task with end date only",
            };
            ganttData.Add(record1);
            ganttData.Add(record2);
            ganttData.Add(record3);
            ganttData.Add(record4);
            return ganttData;
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
        public static List<TaskResources> EditingResources()
        {
            List<TaskResources> TaskResourcesCollection = new List<TaskResources>();

            TaskResources Record1 = new TaskResources()
            {
                ResourceId = 1,
                ResourceName = "Martin Tamer"
            };
            TaskResources Record2 = new TaskResources()
            {
                ResourceId = 2,
                ResourceName = "Rose Fuller"
            };
            TaskResources Record3 = new TaskResources()
            {
                ResourceId = 3,
                ResourceName = "Margaret Buchanan"
            };
            TaskResources Record4 = new TaskResources()
            {
                ResourceId = 4,
                ResourceName = "Fuller King"
            };
            TaskResources Record5 = new TaskResources()
            {
                ResourceId = 5,
                ResourceName = "Davolio Fuller"
            };
            TaskResources Record6 = new TaskResources()
            {
                ResourceId = 6,
                ResourceName = "Van Jack"
            };
            TaskResources Record7 = new TaskResources()
            {
                ResourceId = 7,
                ResourceName = "Fuller Buchanan"
            };
            TaskResources Record8 = new TaskResources()
            {
                ResourceId = 8,
                ResourceName = "Jack Davolio"
            };
            TaskResources Record9 = new TaskResources()
            {
                ResourceId = 9,
                ResourceName = "Tamer Vinet"
            };
            TaskResources Record10 = new TaskResources()
            {
                ResourceId = 10,
                ResourceName = "Vinet Fuller"
            };
            TaskResources Record11 = new TaskResources()
            {
                ResourceId = 11,
                ResourceName = "Bergs Anton"
            };
            TaskResources Record12 = new TaskResources()
            {
                ResourceId = 12,
                ResourceName = "Construction Supervisor"
            };
            TaskResourcesCollection.Add(Record1);
            TaskResourcesCollection.Add(Record2);
            TaskResourcesCollection.Add(Record3);
            TaskResourcesCollection.Add(Record4);
            TaskResourcesCollection.Add(Record5);
            TaskResourcesCollection.Add(Record6);
            TaskResourcesCollection.Add(Record7);
            TaskResourcesCollection.Add(Record8);
            TaskResourcesCollection.Add(Record9);
            TaskResourcesCollection.Add(Record10);
            TaskResourcesCollection.Add(Record11);
            TaskResourcesCollection.Add(Record12);
            return TaskResourcesCollection;
        }
        public static List<TaskData> EditingData()
        {
            List<TaskData> TaskDataCollection = new List<TaskData>();

            TaskData Record1 = new TaskData()
            {
                TaskId = 1,
                TaskName = "Project initiation",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record1Child1 = new TaskData()
            {
                TaskId = 2,
                TaskName = "Identify Site location",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "0",
                Progress = 30,
                ResourceId = new int[] { 1 },
                Notes = "Measure the total property area alloted for construction"
            };
            TaskData Record1Child2 = new TaskData()
            {
                TaskId = 3,
                TaskName = "Perform soil test",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "4",
                Predecessor = "2",
                ResourceId = new int[] { 2, 3, 5 },
                Notes = "Obtain an engineered soil test of lot where construction is planned.From an engineer or company specializing in soil testing"
            };
            TaskData Record1Child3 = new TaskData()
            {
                TaskId = 4,
                TaskName = "Soil test approval",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "0",
                Progress = 30,
                Predecessor = "3"
            };
            Record1.SubTasks.Add(Record1Child1);
            Record1.SubTasks.Add(Record1Child2);
            Record1.SubTasks.Add(Record1Child3);

            TaskData Record2 = new TaskData()
            {
                TaskId = 5,
                TaskName = "Project estimation",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record2Child1 = new TaskData()
            {
                TaskId = 6,
                TaskName = "Develop floor plan for estimation",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "4",
                ResourceId = new int[] { 4 },
                Notes = "Develop floor plans and obtain a materials list for estimations"
            };
            TaskData Record2Child2 = new TaskData()
            {
                TaskId = 7,
                TaskName = "List materials",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "6",
                ResourceId = new int[] { 4, 8 },
                Notes = ""
            };
            TaskData Record2Child3 = new TaskData()
            {
                TaskId = 8,
                TaskName = "Estimation approval",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "0",
                Predecessor = "7",
                ResourceId = new int[] { 12, 5 },
                Notes = ""
            };
            Record2.SubTasks.Add(Record2Child1);
            Record2.SubTasks.Add(Record2Child2);
            Record2.SubTasks.Add(Record2Child3);

            TaskData Record3 = new TaskData()
            {
                TaskId = 9,
                TaskName = "Sign contract",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "1",
                Predecessor = "8",
                Progress = 30,
                ResourceId = new int[] { 12 },
                Notes = "If required obtain approval from HOA (homeowners association) or ARC (architectural review committee)"
            };

            TaskData Record4 = new TaskData()
            {
                TaskId = 10,
                TaskName = "Project approval and kick off",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                Duration = "0",
                Predecessor = "9",
            };

            TaskData Record5 = new TaskData()
            {
                TaskId = 11,
                TaskName = "Site wwork",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record5Child1 = new TaskData()
            {
                TaskId = 12,
                TaskName = "Clear the building site",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "2",
                Progress = 30,
                Predecessor = "9",
                ResourceId = new int[] { 6, 7 },
                Notes = "Clear the building site (demolition of existing home if necessary)"
            };
            TaskData Record5Child2 = new TaskData()
            {
                TaskId = 13,
                TaskName = "Install temporary power service",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "2",
                Predecessor = "12",
                ResourceId = new int[] { 6, 7 },
                Notes = ""
            };
            Record5.SubTasks.Add(Record5Child1);
            Record5.SubTasks.Add(Record5Child2);

            TaskData Record6 = new TaskData()
            {
                TaskId = 14,
                TaskName = "Foundation",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record6Child1 = new TaskData()
            {
                TaskId = 15,
                TaskName = "Excavate for foundations",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "13",
                ResourceId = new int[] { 2, 8 },
                Notes = "Excavate the foundation and dig footers (Scope of work is dependent of foundation designed by engineer)"
            };
            TaskData Record6Child2 = new TaskData()
            {
                TaskId = 16,
                TaskName = "Dig footer",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "2",
                Predecessor = "15FF",
                ResourceId = new int[] { 8 },
                Notes = ""
            };
            TaskData Record6Child3 = new TaskData()
            {
                TaskId = 17,
                TaskName = "Install plumbing grounds",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "4",
                Progress = 30,
                Predecessor = "15",
                ResourceId = new int[] { 9 },
                Notes = ""
            };
            TaskData Record6Child4 = new TaskData()
            {
                TaskId = 18,
                TaskName = "Pour a foundation and footer with concrete",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "1",
                Predecessor = "17",
                ResourceId = new int[] { 8, 9, 10 },
                Notes = ""
            };
            TaskData Record6Child5 = new TaskData()
            {
                TaskId = 19,
                TaskName = "Cure basement walls",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "4",
                Progress = 30,
                Predecessor = "18",
                ResourceId = new int[] { 10 },
                Notes = ""
            };
            Record6.SubTasks.Add(Record6Child1);
            Record6.SubTasks.Add(Record6Child2);
            Record6.SubTasks.Add(Record6Child3);
            Record6.SubTasks.Add(Record6Child4);
            Record6.SubTasks.Add(Record6Child5);


            TaskData Record7 = new TaskData()
            {
                TaskId = 20,
                TaskName = "Framing",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record7Child1 = new TaskData()
            {
                TaskId = 21,
                TaskName = "Add load-bearing structure",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "19",
                ResourceId = new int[] { 4, 5 },
                Notes = "Build the main load-bearing structure out of thick pieces of wood and possibly metal I-beams for large spans with few supports"
            };
            TaskData Record7Child2 = new TaskData()
            {
                TaskId = 22,
                TaskName = "Install floor joists",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "21",
                ResourceId = new int[] { 2, 3 },
                Notes = "Add floor and ceiling joists and install subfloor panels"
            };
            TaskData Record7Child3 = new TaskData()
            {
                TaskId = 23,
                TaskName = "Add ceiling joists",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "22SS",
                ResourceId = new int[] { 5 },
                Notes = ""
            };
            TaskData Record7Child4 = new TaskData()
            {
                TaskId = 24,
                TaskName = "Install subfloor panels",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "23",
                ResourceId = new int[] { 8, 9 },
                Notes = ""
            };
            TaskData Record7Child5 = new TaskData()
            {
                TaskId = 25,
                TaskName = "Frame floor walls",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "24",
                ResourceId = new int[] { 10 },
                Notes = ""
            };
            TaskData Record7Child6 = new TaskData()
            {
                TaskId = 26,
                TaskName = "Frame floor decking",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "25SS",
                ResourceId = new int[] { 4, 8 },
                Notes = ""
            };
            Record7.SubTasks.Add(Record7Child1);
            Record7.SubTasks.Add(Record7Child2);
            Record7.SubTasks.Add(Record7Child3);
            Record7.SubTasks.Add(Record7Child4);
            Record7.SubTasks.Add(Record7Child5);
            Record7.SubTasks.Add(Record7Child6);

            TaskData Record8 = new TaskData()
            {
                TaskId = 27,
                TaskName = "Exterior finishing",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record8Child1 = new TaskData()
            {
                TaskId = 28,
                TaskName = "Cover outer walls and roof in OSB",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "26",
                ResourceId = new int[] { 2, 8 },
                Notes = "Cover outer walls and roof in OSB or plywood and a water-resistive barrier"
            };
            TaskData Record8Child2 = new TaskData()
            {
                TaskId = 29,
                TaskName = "Add water resistive barrier",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "28",
                ResourceId = new int[] { 1, 10 },
                Notes = "Cover the walls with siding, typically vinyl, wood, or brick veneer but possibly stone or other materials"
            };
            TaskData Record8Child3 = new TaskData()
            {
                TaskId = 30,
                TaskName = "Install roof shingles",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "29",
                ResourceId = new int[] { 8, 9 },
                Notes = "Install roof shingles or other covering for flat roof"
            };
            TaskData Record8Child4 = new TaskData()
            {
                TaskId = 31,
                TaskName = "Install windows",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "29",
                ResourceId = new int[] { 7 },
                Notes = ""
            };
            Record8.SubTasks.Add(Record8Child1);
            Record8.SubTasks.Add(Record8Child2);
            Record8.SubTasks.Add(Record8Child3);
            Record8.SubTasks.Add(Record8Child4);

            TaskData Record9 = new TaskData()
            {
                TaskId = 32,
                TaskName = "Utilities",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record9Child1 = new TaskData()
            {
                TaskId = 33,
                TaskName = "Install internal plumbing",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "26",
                ResourceId = new int[] { 1, 10 },
            };
            TaskData Record9Child2 = new TaskData()
            {
                TaskId = 34,
                TaskName = "Install HVAC",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "33",
                ResourceId = new int[] { 4, 9 },
                Notes = "Add internal plumbing, HVAC, electrical, and natural gas utilities"
            };
            TaskData Record9Child3 = new TaskData()
            {
                TaskId = 35,
                TaskName = "Electrical utilities",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "34",
            };
            TaskData Record9Child4 = new TaskData()
            {
                TaskId = 36,
                TaskName = "Natural gas utilities",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "35",
                ResourceId = new int[] { 11 },
            };
            TaskData Record9Child5 = new TaskData()
            {
                TaskId = 37,
                TaskName = "Install bathroom fixtures",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "35",
                ResourceId = new int[] { 3, 7 },
            };
            Record9.SubTasks.Add(Record9Child1);
            Record9.SubTasks.Add(Record9Child2);
            Record9.SubTasks.Add(Record9Child3);
            Record9.SubTasks.Add(Record9Child4);
            Record9.SubTasks.Add(Record9Child5);

            TaskData Record10 = new TaskData()
            {
                TaskId = 38,
                TaskName = "Interior finsihing",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record10Child1 = new TaskData()
            {
                TaskId = 39,
                TaskName = "Install insulation",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "37",
                ResourceId = new int[] { 1, 8 },
                Notes = "Frame interior walls with wooden 2×4s"
            };
            TaskData Record10Child2 = new TaskData()
            {
                TaskId = 40,
                TaskName = "Install  drywall panels",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "39",
                ResourceId = new int[] { 5 },
                Notes = "Install insulation and interior drywall panels (cementboard for wet areas) and to complete walls and ceilings"
            };
            TaskData Record10Child3 = new TaskData()
            {
                TaskId = 41,
                TaskName = "Spackle",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "40",
                ResourceId = new int[] { 10 },
            };
            TaskData Record10Child4 = new TaskData()
            {
                TaskId = 42,
                TaskName = "Apply primer",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "41",
                ResourceId = new int[] { 10, 11 },
            };
            TaskData Record10Child5 = new TaskData()
            {
                TaskId = 43,
                TaskName = "Paint wall and ceilings",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "42",
                ResourceId = new int[] { 2, 9 },
            };
            TaskData Record10Child6 = new TaskData()
            {
                TaskId = 44,
                TaskName = "Install modular kitchen",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "43",
                ResourceId = new int[] { 5, 7 },
            };
            Record10.SubTasks.Add(Record10Child1);
            Record10.SubTasks.Add(Record10Child2);
            Record10.SubTasks.Add(Record10Child3);
            Record10.SubTasks.Add(Record10Child4);
            Record10.SubTasks.Add(Record10Child5);
            Record10.SubTasks.Add(Record10Child6);


            TaskData Record11 = new TaskData()
            {
                TaskId = 45,
                TaskName = "Flooring",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record11Child1 = new TaskData()
            {
                TaskId = 46,
                TaskName = "Tile kitchen, bathroom and entry walls",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "44",
                ResourceId = new int[] { 4, 9, 3 },
                Notes = "Additional tiling on top of cementboard for wet areas, such as the bathroom and kitchen backsplash"
            };
            TaskData Record11Child2 = new TaskData()
            {
                TaskId = 47,
                TaskName = "Tile floor",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "46SS",
                ResourceId = new int[] { 2, 8 },
                Notes = "Installation of final floor covering, such as floor tile, carpet, or wood flooring"
            };
            Record11.SubTasks.Add(Record11Child1);
            Record11.SubTasks.Add(Record11Child2);

            TaskData Record12 = new TaskData()
            {
                TaskId = 48,
                TaskName = "Final acceptance",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record12Child1 = new TaskData()
            {
                TaskId = 49,
                TaskName = "Final inspection",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "2",
                Progress = 30,
                Predecessor = "47",
                ResourceId = new int[] { 12 },
                Notes = "Ensure the contracted items"
            };
            TaskData Record12Child2 = new TaskData()
            {
                TaskId = 50,
                TaskName = "Cleanup for occupancy",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "2",
                Predecessor = "49",
                ResourceId = new int[] { 1, 5 },
                Notes = "Installation of major appliances"
            };
            TaskData Record12Child3 = new TaskData()
            {
                TaskId = 51,
                TaskName = "Property handover",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "0",
                Predecessor = "50",
                Notes = "Ending the contract"
            };
            Record12.SubTasks.Add(Record12Child1);
            Record12.SubTasks.Add(Record12Child2);
            Record12.SubTasks.Add(Record12Child3);

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
            TaskDataCollection.Add(Record12);
            return TaskDataCollection;
        }
        public static List<TaskData> RemoteData()
        {
            List<TaskData> TaskDataCollection = new List<TaskData>();

            TaskData Record1 = new TaskData()
            {
                TaskId = 1,
                TaskName = "Germination",
                StartDate = new DateTime(2019, 03, 01),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record1Child1 = new TaskData()
            {
                TaskId = 2,
                TaskName = "Dry seed (caryopsis)",
                StartDate = new DateTime(2019, 03, 01),
                Duration = "0",
            };
            TaskData Record1Child2 = new TaskData()
            {
                TaskId = 3,
                TaskName = "Seed imbibition complete",
                StartDate = new DateTime(2019, 03, 01),
                Duration = "3",
                Predecessor = "2"
            };
            TaskData Record1Child3 = new TaskData()
            {
                TaskId = 4,
                TaskName = "Radicle emerged from caryopsis",
                StartDate = new DateTime(2019, 03, 04),
                Duration = "2",
                Predecessor = "3"
            };
            TaskData Record1Child4 = new TaskData()
            {
                TaskId = 5,
                TaskName = "Coleoptile emerged from caryopsis",
                StartDate = new DateTime(2019, 03, 06),
                Duration = "2",
                Predecessor = "4"
            };
            TaskData Record1Child5 = new TaskData()
            {
                TaskId = 6,
                TaskName = "Emergence: coleoptile penetrates soil surface (cracking stage)",
                StartDate = new DateTime(2019, 03, 08),
                Duration = "2",
                Predecessor = "5"
            };
            Record1.SubTasks.Add(Record1Child1);
            Record1.SubTasks.Add(Record1Child2);
            Record1.SubTasks.Add(Record1Child3);
            Record1.SubTasks.Add(Record1Child4);
            Record1.SubTasks.Add(Record1Child5);


            TaskData Record2 = new TaskData()
            {
                TaskId = 7,
                TaskName = "Leaf development",
                StartDate = new DateTime(2019, 03, 10),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record2Child1 = new TaskData()
            {
                TaskId = 8,
                TaskName = "First leaf through coleoptile",
                StartDate = new DateTime(2019, 03, 10),
                Duration = "1",
                Predecessor = "6"
            };
            TaskData Record2Child2 = new TaskData()
            {
                TaskId = 9,
                TaskName = "First leaf unfolded",
                StartDate = new DateTime(2019, 03, 11),
                Duration = "1",
                Predecessor = "8"
            };
            TaskData Record2Child3 = new TaskData()
            {
                TaskId = 10,
                TaskName = "3 leaves unfolded",
                StartDate = new DateTime(2019, 03, 12),
                Duration = "2",
                Predecessor = "9"
            };
            TaskData Record2Child4 = new TaskData()
            {
                TaskId = 11,
                TaskName = "9 or more leaves unfolded",
                StartDate = new DateTime(2019, 03, 14),
                Duration = "5",
                Predecessor = "10"
            };
            Record2.SubTasks.Add(Record2Child1);
            Record2.SubTasks.Add(Record2Child2);
            Record2.SubTasks.Add(Record2Child3);
            Record2.SubTasks.Add(Record2Child4);

            TaskData Record3 = new TaskData()
            {
                TaskId = 12,
                TaskName = "Tillering",
                StartDate = new DateTime(2019, 03, 18),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record3Child1 = new TaskData()
            {
                TaskId = 13,
                TaskName = "Beginning of tillering: first tiller detectable",
                StartDate = new DateTime(2019, 03, 18),
                Duration = "0",
                Predecessor = "11"
            };
            TaskData Record3Child2 = new TaskData()
            {
                TaskId = 14,
                TaskName = "2 tillers detectable",
                StartDate = new DateTime(2019, 03, 19),
                Duration = "3",
                Predecessor = "13"
            };
            TaskData Record3Child3 = new TaskData()
            {
                TaskId = 15,
                TaskName = "3 tillers detectable",
                StartDate = new DateTime(2019, 03, 22),
                Duration = "3",
                Predecessor = "14"
            };
            TaskData Record3Child4 = new TaskData()
            {
                TaskId = 16,
                TaskName = "Maximum no. of tillers detectable",
                StartDate = new DateTime(2019, 03, 25),
                Duration = "6",
                Predecessor = "15"
            };
            TaskData Record3Child5 = new TaskData()
            {
                TaskId = 17,
                TaskName = "End of tillering",
                StartDate = new DateTime(2019, 03, 30),
                Duration = "0",
                Predecessor = "16"
            };
            Record3.SubTasks.Add(Record3Child1);
            Record3.SubTasks.Add(Record3Child2);
            Record3.SubTasks.Add(Record3Child3);
            Record3.SubTasks.Add(Record3Child4);
            Record3.SubTasks.Add(Record3Child5);

            TaskData Record4 = new TaskData()
            {
                TaskId = 18,
                TaskName = "Stem elongation",
                StartDate = new DateTime(2019, 03, 30),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record4Child1 = new TaskData()
            {
                TaskId = 19,
                TaskName = "Beginning of stem elongation: pseudostem and tillers erect, first internode begins to elongate, top of inflorescence at least 1 cm above tillering node",
                StartDate = new DateTime(2019, 03, 30),
                Duration = "0",
                Predecessor = "17"
            };
            TaskData Record4Child2 = new TaskData()
            {
                TaskId = 20,
                TaskName = "First node at least 1 cm above tillering node",
                StartDate = new DateTime(2019, 03, 31),
                Duration = "1",
                Predecessor = "19"
            };
            TaskData Record4Child3 = new TaskData()
            {
                TaskId = 21,
                TaskName = "Node 3 at least 2 cm above node 2",
                StartDate = new DateTime(2019, 04, 01),
                Duration = "2",
                Predecessor = "20"
            };
            TaskData Record4Child4 = new TaskData()
            {
                TaskId = 22,
                TaskName = "Flag leaf just visible, still rolled",
                StartDate = new DateTime(2019, 04, 03),
                Duration = "4",
                Predecessor = "21"
            };
            TaskData Record4Child5 = new TaskData()
            {
                TaskId = 23,
                TaskName = "Flag leaf stage: flag leaf fully unrolled, ligule just visible",
                StartDate = new DateTime(2019, 04, 07),
                Duration = "2",
                Predecessor = "22"
            };
            Record4.SubTasks.Add(Record4Child1);
            Record4.SubTasks.Add(Record4Child2);
            Record4.SubTasks.Add(Record4Child3);
            Record4.SubTasks.Add(Record4Child4);
            Record4.SubTasks.Add(Record4Child5);

            TaskData Record5 = new TaskData()
            {
                TaskId = 24,
                TaskName = "Booting",
                StartDate = new DateTime(2019, 04, 09),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record5Child1 = new TaskData()
            {
                TaskId = 25,
                TaskName = "Early boot stage: flag leaf sheath extending",
                StartDate = new DateTime(2019, 04, 09),
                Duration = "2",
                Predecessor = "23"
            };
            TaskData Record5Child2 = new TaskData()
            {
                TaskId = 26,
                TaskName = "Mid boot stage: flag leaf sheath just visibly swollen",
                StartDate = new DateTime(2019, 04, 11),
                Duration = "2",
                Predecessor = "25"
            };
            TaskData Record5Child3 = new TaskData()
            {
                TaskId = 27,
                TaskName = "Late boot stage: flag leaf sheath swollen",
                StartDate = new DateTime(2019, 04, 13),
                Duration = "2",
                Predecessor = "26"
            };
            TaskData Record5Child4 = new TaskData()
            {
                TaskId = 28,
                TaskName = "Flag leaf sheath opening",
                StartDate = new DateTime(2019, 04, 15),
                Duration = "2",
                Predecessor = "27"
            };
            TaskData Record5Child5 = new TaskData()
            {
                TaskId = 29,
                TaskName = "First awns visible (in awned forms only)",
                StartDate = new DateTime(2019, 04, 17),
                Duration = "2",
                Predecessor = "28"
            };
            Record5.SubTasks.Add(Record5Child1);
            Record5.SubTasks.Add(Record5Child2);
            Record5.SubTasks.Add(Record5Child3);
            Record5.SubTasks.Add(Record5Child4);
            Record5.SubTasks.Add(Record5Child5);


            TaskData Record6 = new TaskData()
            {
                TaskId = 30,
                TaskName = "Inflorescence emergence, heading",
                StartDate = new DateTime(2019, 04, 18),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record6Child1 = new TaskData()
            {
                TaskId = 31,
                TaskName = "Beginning of heading: tip of inflorescence emerged from sheath, first spikelet just visible",
                StartDate = new DateTime(2019, 04, 18),
                Duration = "0",
                Predecessor = "29"
            };
            TaskData Record6Child2 = new TaskData()
            {
                TaskId = 32,
                TaskName = "20% of inflorescence emerged",
                StartDate = new DateTime(2019, 04, 19),
                Duration = "3",
                Predecessor = "31"
            };
            TaskData Record6Child3 = new TaskData()
            {
                TaskId = 33,
                TaskName = "40% of inflorescence emerged",
                StartDate = new DateTime(2019, 04, 22),
                Duration = "2",
                Predecessor = "32"
            };
            TaskData Record6Child4 = new TaskData()
            {
                TaskId = 34,
                TaskName = "Middle of heading: half of inflorescence emerged",
                StartDate = new DateTime(2019, 04, 23),
                Duration = "0",
                Predecessor = "33"
            };
            TaskData Record6Child5 = new TaskData()
            {
                TaskId = 35,
                TaskName = "60% of inflorescence emerged",
                StartDate = new DateTime(2019, 04, 24),
                Duration = "2",
                Predecessor = "34"
            };
            TaskData Record6Child6 = new TaskData()
            {
                TaskId = 36,
                TaskName = "80% of inflorescence emerged",
                StartDate = new DateTime(2018, 04, 26),
                Duration = "3",
                Predecessor = "35"
            };
            TaskData Record6Child7 = new TaskData()
            {
                TaskId = 37,
                TaskName = "End of heading: inflorescence fully emerged",
                StartDate = new DateTime(2018, 04, 28),
                Duration = "0",
                Predecessor = "36"
            };
            Record6.SubTasks.Add(Record6Child1);
            Record6.SubTasks.Add(Record6Child2);
            Record6.SubTasks.Add(Record6Child3);
            Record6.SubTasks.Add(Record6Child4);
            Record6.SubTasks.Add(Record6Child5);
            Record6.SubTasks.Add(Record6Child6);
            Record6.SubTasks.Add(Record6Child7);

            TaskData Record7 = new TaskData()
            {
                TaskId = 38,
                TaskName = "Flowering, anthesis",
                StartDate = new DateTime(2019, 04, 28),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record7Child1 = new TaskData()
            {
                TaskId = 39,
                TaskName = "Beginning of flowering: first anthers visible",
                StartDate = new DateTime(2019, 04, 28),
                Duration = "0",
                Predecessor = "37"
            };
            TaskData Record7Child2 = new TaskData()
            {
                TaskId = 40,
                TaskName = "Full flowering: 50% of anthers mature",
                StartDate = new DateTime(2019, 04, 29),
                Duration = "5",
                Predecessor = "39"
            };
            TaskData Record7Child3 = new TaskData()
            {
                TaskId = 41,
                TaskName = "spikelet have completed flowering",
                StartDate = new DateTime(2019, 05, 04),
                Duration = "5",
                Predecessor = "40"
            };
            TaskData Record7Child4 = new TaskData()
            {
                TaskId = 42,
                TaskName = "End of flowering",
                StartDate = new DateTime(2019, 05, 08),
                Duration = "0",
                Predecessor = "41"
            };
            Record7.SubTasks.Add(Record7Child1);
            Record7.SubTasks.Add(Record7Child2);
            Record7.SubTasks.Add(Record7Child3);
            Record7.SubTasks.Add(Record7Child4);

            TaskData Record8 = new TaskData()
            {
                TaskId = 43,
                TaskName = "Development of fruit",
                StartDate = new DateTime(2019, 05, 08),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record8Child1 = new TaskData()
            {
                TaskId = 44,
                TaskName = "Watery ripe: first grains have reached half their final size",
                StartDate = new DateTime(2019, 05, 08),
                Duration = "0",
                Predecessor = "42"
            };
            TaskData Record8Child2 = new TaskData()
            {
                TaskId = 45,
                TaskName = "Early milk",
                StartDate = new DateTime(2019, 05, 09),
                Duration = "3",
                Predecessor = "44"
            };
            TaskData Record8Child3 = new TaskData()
            {
                TaskId = 46,
                TaskName = "Medium milk: grain content milky, grains reached final size,still green",
                StartDate = new DateTime(2019, 05, 12),
                Duration = "3",
                Predecessor = "45"
            };
            TaskData Record8Child4 = new TaskData()
            {
                TaskId = 47,
                TaskName = "Late milk",
                StartDate = new DateTime(2019, 05, 15),
                Duration = "2",
                Predecessor = "46"
            };
            Record8.SubTasks.Add(Record8Child1);
            Record8.SubTasks.Add(Record8Child2);
            Record8.SubTasks.Add(Record8Child3);
            Record8.SubTasks.Add(Record8Child4);

            TaskData Record9 = new TaskData()
            {
                TaskId = 48,
                TaskName = "Ripening",
                StartDate = new DateTime(2019, 05, 17),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record9Child1 = new TaskData()
            {
                TaskId = 49,
                TaskName = "Early dough",
                StartDate = new DateTime(2019, 05, 17),
                Duration = "6",
                Predecessor = "47"
            };
            TaskData Record9Child2 = new TaskData()
            {
                TaskId = 50,
                TaskName = "Soft dough: grain content soft but dry. Fingernail impression not held",
                StartDate = new DateTime(2019, 05, 23),
                Duration = "2",
                Predecessor = "49"
            };
            TaskData Record9Child3 = new TaskData()
            {
                TaskId = 51,
                TaskName = "Hard dough: grain content solid. Fingernail impression held",
                StartDate = new DateTime(2019, 05, 25),
                Duration = "2",
                Predecessor = "50"
            };
            TaskData Record9Child4 = new TaskData()
            {
                TaskId = 52,
                TaskName = "Fully ripe: grain hard, difficult to divide with thumbnail",
                StartDate = new DateTime(2019, 05, 27),
                Duration = "2",
                Predecessor = "51"
            };
            Record9.SubTasks.Add(Record9Child1);
            Record9.SubTasks.Add(Record9Child2);
            Record9.SubTasks.Add(Record9Child3);
            Record9.SubTasks.Add(Record9Child4);
            TaskData Record10 = new TaskData()
            {
                TaskId = 53,
                TaskName = "Senescence",
                StartDate = new DateTime(2019, 05, 29),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record10Child1 = new TaskData()
            {
                TaskId = 54,
                TaskName = "Over-ripe: grain very hard, cannot be dented by thumbnail",
                StartDate = new DateTime(2019, 05, 29),
                Duration = "3",
                Predecessor = "52"
            };
            TaskData Record10Child2 = new TaskData()
            {
                TaskId = 55,
                TaskName = "Grains loosening in day-time",
                StartDate = new DateTime(2019, 06, 01),
                Duration = "1",
                Predecessor = "54"
            };
            TaskData Record10Child3 = new TaskData()
            {
                TaskId = 56,
                TaskName = "Plant dead and collapsing",
                StartDate = new DateTime(2019, 06, 02),
                Duration = "4",
                Predecessor = "55"
            };
            TaskData Record10Child4 = new TaskData()
            {
                TaskId = 57,
                TaskName = "Harvested product",
                StartDate = new DateTime(2019, 06, 06),
                Duration = "2",
                Predecessor = "56"
            };
            Record10.SubTasks.Add(Record10Child1);
            Record10.SubTasks.Add(Record10Child2);
            Record10.SubTasks.Add(Record10Child3);
            Record10.SubTasks.Add(Record10Child4);

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
            //TaskDataCollection.Add(Record11);
            return TaskDataCollection;
        }
        public static List<TaskResources> TimelineResources()
        {
            List<TaskResources> TaskResourcesCollection = new List<TaskResources>();

            TaskResources Record1 = new TaskResources()
            {
                ResourceId = 1,
                ResourceName = "Project Manager"
            };
            TaskResources Record2 = new TaskResources()
            {
                ResourceId = 2,
                ResourceName = "Software Analyst"
            };
            TaskResources Record3 = new TaskResources()
            {
                ResourceId = 3,
                ResourceName = "Developer"
            };
            TaskResources Record4 = new TaskResources()
            {
                ResourceId = 4,
                ResourceName = "Testing Engineer"
            };
            TaskResourcesCollection.Add(Record1);
            TaskResourcesCollection.Add(Record2);
            TaskResourcesCollection.Add(Record3);
            TaskResourcesCollection.Add(Record4);
            return TaskResourcesCollection;
        }
        public static List<TaskData> BaselineData()
        {
            List<TaskData> TaskDataCollection = new List<TaskData>();

            TaskData Record1 = new TaskData()
            {
                TaskId = 1,
                TaskName = "Receive vehicle and create job card",
                BaselineStartDate = new DateTime(2018, 03, 05, 10, 0, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 10, 0, 0),
                StartDate = new DateTime(2018, 03, 05, 10, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 10, 0, 0),
            };
            TaskData Record2 = new TaskData()
            {
                TaskId = 2,
                TaskName = "Allot mechanic and send vehicle to service bay",
                BaselineStartDate = new DateTime(2018, 03, 05, 10, 0, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 10, 15, 0),
                StartDate = new DateTime(2018, 03, 05, 10, 15, 0),
                EndDate = new DateTime(2018, 03, 05, 10, 20, 0),
            };
            TaskData Record3 = new TaskData()
            {
                TaskId = 3,
                TaskName = "Change the receive vehicle and create job cardengine oil",
                BaselineStartDate = new DateTime(2018, 03, 05, 10, 15, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 10, 45, 0),
                StartDate = new DateTime(2018, 03, 05, 10, 20, 0),
                EndDate = new DateTime(2018, 03, 05, 10, 35, 0),
            };
            TaskData Record4 = new TaskData()
            {
                TaskId = 4,
                TaskName = "Replace the oil filter",
                BaselineStartDate = new DateTime(2018, 03, 05, 10, 45, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 11, 15, 0),
                StartDate = new DateTime(2018, 03, 05, 10, 35, 0),
                EndDate = new DateTime(2018, 03, 05, 11, 0, 0),
            };
            TaskData Record5 = new TaskData()
            {
                TaskId = 5,
                TaskName = "Replace the air filter",
                BaselineStartDate = new DateTime(2018, 03, 05, 10, 45, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 11, 15, 0),
                StartDate = new DateTime(2018, 03, 05, 10, 35, 0),
                EndDate = new DateTime(2018, 03, 05, 11, 0, 0),
            };
            TaskData Record6 = new TaskData()
            {
                TaskId = 6,
                TaskName = "Replace the fuel filter",
                BaselineStartDate = new DateTime(2018, 03, 05, 11, 15, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 11, 25, 0),
                StartDate = new DateTime(2018, 03, 05, 11, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 11, 20, 0),
            };
            TaskData Record7 = new TaskData()
            {
                TaskId = 7,
                TaskName = "Replace the cabin filter",
                BaselineStartDate = new DateTime(2018, 03, 05, 11, 0, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 11, 30, 0),
                StartDate = new DateTime(2018, 03, 05, 11, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 11, 25, 0),
            };
            TaskData Record8 = new TaskData()
            {
                TaskId = 8,
                TaskName = "Replace the spark plugs",
                BaselineStartDate = new DateTime(2018, 03, 05, 11, 0, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 11, 30, 0),
                StartDate = new DateTime(2018, 03, 05, 11, 25, 0),
                EndDate = new DateTime(2018, 03, 05, 11, 45, 0),
            };
            TaskData Record9 = new TaskData()
            {
                TaskId = 9,
                TaskName = "Check level and refill brake fluid/clutch fluid",
                BaselineStartDate = new DateTime(2018, 03, 05, 11, 20, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 11, 40, 0),
                StartDate = new DateTime(2018, 03, 05, 11, 30, 0),
                EndDate = new DateTime(2018, 03, 05, 11, 50, 0),
            };
            TaskData Record10 = new TaskData()
            {
                TaskId = 10,
                TaskName = "Check brake pads/liners, brake discs/drums, and replace if worn out",
                BaselineStartDate = new DateTime(2018, 03, 05, 11, 40, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 12, 0, 0),
                StartDate = new DateTime(2018, 03, 05, 11, 50, 0),
                EndDate = new DateTime(2018, 03, 05, 12, 20, 0),
            };
            TaskData Record11 = new TaskData()
            {
                TaskId = 11,
                TaskName = "Check level and refill power steering fluid",
                BaselineStartDate = new DateTime(2018, 03, 05, 11, 40, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 12, 0, 0),
                StartDate = new DateTime(2018, 03, 05, 12, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 12, 15, 0),
            };
            TaskData Record12 = new TaskData()
            {
                TaskId = 12,
                TaskName = "Check level and refill automatic/manual transmission fluid",
                BaselineStartDate = new DateTime(2018, 03, 05, 12, 0, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 12, 35, 0),
                StartDate = new DateTime(2018, 03, 05, 11, 50, 0),
                EndDate = new DateTime(2018, 03, 05, 12, 20, 0),
            };
            TaskData Record13 = new TaskData()
            {
                TaskId = 13,
                TaskName = "Grease and lubricate components",
                BaselineStartDate = new DateTime(2018, 03, 05, 12, 20, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 12, 35, 0),
                StartDate = new DateTime(2018, 03, 05, 12, 20, 0),
                EndDate = new DateTime(2018, 03, 05, 12, 45, 0),
            };
            TaskData Record14 = new TaskData()
            {
                TaskId = 14,
                TaskName = "Inspect and replace the timing belt or timing chain if needed",
                BaselineStartDate = new DateTime(2018, 03, 05, 12, 35, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 13, 0, 0),
                StartDate = new DateTime(2018, 03, 05, 12, 45, 0),
                EndDate = new DateTime(2018, 03, 05, 13, 0, 0),
            };
            TaskData Record15 = new TaskData()
            {
                TaskId = 15,
                TaskName = "Wheel balancing",
                BaselineStartDate = new DateTime(2018, 03, 05, 13, 0, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 13, 20, 0),
                StartDate = new DateTime(2018, 03, 05, 13, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 13, 45, 0),
            };
            TaskData Record16 = new TaskData()
            {
                TaskId = 16,
                TaskName = "Wheel alignment",
                BaselineStartDate = new DateTime(2018, 03, 05, 13, 20, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 13, 45, 0),
                StartDate = new DateTime(2018, 03, 05, 13, 45, 0),
                EndDate = new DateTime(2018, 03, 05, 14, 45, 0),
            };
            TaskData Record17 = new TaskData()
            {
                TaskId = 17,
                TaskName = "Check for proper operation of all lights, wipers etc",
                BaselineStartDate = new DateTime(2018, 03, 05, 13, 50, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 14, 30, 0),
                StartDate = new DateTime(2018, 03, 05, 14, 45, 0),
                EndDate = new DateTime(2018, 03, 05, 15, 30, 0),
            };
            TaskData Record18 = new TaskData()
            {
                TaskId = 18,
                TaskName = "Check for any error codes in the ECU and take corrective action",
                BaselineStartDate = new DateTime(2018, 03, 05, 14, 30, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 15, 30, 0),
                StartDate = new DateTime(2018, 03, 05, 15, 30, 0),
                EndDate = new DateTime(2018, 03, 05, 16, 15, 0),
            };
            TaskData Record19 = new TaskData()
            {
                TaskId = 19,
                TaskName = "Use scan tool read trouble code",
                BaselineStartDate = new DateTime(2018, 03, 05, 15, 30, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 16, 45, 0),
                StartDate = new DateTime(2018, 03, 05, 16, 15, 0),
                EndDate = new DateTime(2018, 03, 05, 16, 45, 0),
            };
            TaskData Record20 = new TaskData()
            {
                TaskId = 20,
                TaskName = "Exterior washing",
                BaselineStartDate = new DateTime(2018, 03, 05, 16, 45, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 17, 15, 0),
                StartDate = new DateTime(2018, 03, 05, 16, 45, 0),
                EndDate = new DateTime(2018, 03, 05, 17, 30, 0),
            };
            TaskData Record21 = new TaskData()
            {
                TaskId = 21,
                TaskName = "Interior vacuuming",
                BaselineStartDate = new DateTime(2018, 03, 05, 17, 15, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 17, 45, 0),
                StartDate = new DateTime(2018, 03, 05, 17, 30, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 0, 0),
            };
            TaskData Record22 = new TaskData()
            {
                TaskId = 21,
                TaskName = "Final service inspection",
                BaselineStartDate = new DateTime(2018, 03, 05, 17, 45, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 18, 0, 0),
                StartDate = new DateTime(2018, 03, 05, 18, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 30, 0),
            };
            TaskData Record23 = new TaskData()
            {
                TaskId = 23,
                TaskName = "Vehicle handover",
                BaselineStartDate = new DateTime(2018, 03, 05, 18, 0, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 18, 0, 0),
                StartDate = new DateTime(2018, 03, 05, 18, 30, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 30, 0),
            };
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
            TaskDataCollection.Add(Record13);
            TaskDataCollection.Add(Record14);
            TaskDataCollection.Add(Record15);
            TaskDataCollection.Add(Record16);
            TaskDataCollection.Add(Record17);
            TaskDataCollection.Add(Record18);
            TaskDataCollection.Add(Record19);
            TaskDataCollection.Add(Record20);
            TaskDataCollection.Add(Record21);
            TaskDataCollection.Add(Record22);
            TaskDataCollection.Add(Record23);
            return TaskDataCollection;
        }
        public static List<TaskbarData> TaskbarTemplateData()
        {
            List<TaskbarData> TaskDataCollection = new List<TaskbarData>();

            TaskbarData Record2 = new TaskbarData()
            {
                TaskId = 1,
                TaskName = "Oscar moments",
                StartDate = new DateTime(2018, 03, 05, 18, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 15, 0),
                Winner = "",
                Performance = "90th Academy awards kicks-off and Jimmy kimmel hosts the show"
            };
            TaskbarData Record3 = new TaskbarData()
            {
                TaskId = 2,
                TaskName = "Actor in a supporting role",
                StartDate = new DateTime(2018, 03, 05, 18, 16, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 25, 0),
                Predecessor = "1",
                Winner = "Sam Rockwell",
                Movie = "Three Billboards Outside Ebbing, Missouri."
            };
            TaskbarData Record4 = new TaskbarData()
            {
                TaskId = 3,
                TaskName = "Hair and makeup",
                StartDate = new DateTime(2018, 03, 05, 18, 26, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 32, 0),
                Predecessor = "2",
                Movie = "Darkest Hour"
            };
            TaskbarData Record5 = new TaskbarData()
            {
                TaskId = 4,
                TaskName = "Costume design",
                StartDate = new DateTime(2018, 03, 05, 18, 33, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 40, 0),
                Predecessor = "3",
                Winner = "Mark Bridges",
                Movie = "Phantom Thread"
            };
            TaskbarData Record6 = new TaskbarData()
            {
                TaskId = 5,
                TaskName = "Documentary feature",
                StartDate = new DateTime(2018, 03, 05, 18, 41, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 58, 0),
                Predecessor = "4",
                Winner = "Bryan Fogel",
                Movie = "Icarus"
            };
            TaskbarData Record7 = new TaskbarData()
            {
                TaskId = 6,
                TaskName = "Best sound editing and sound mixing",
                StartDate = new DateTime(2018, 03, 05, 18, 59, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 10, 0),
                Predecessor = "5",
                Winner = "Richard King and Alex Gibson",
                Movie = "Dunkirk"
            };
            TaskbarData Record8 = new TaskbarData()
            {
                TaskId = 7,
                TaskName = "Production design",
                StartDate = new DateTime(2018, 03, 05, 19, 11, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 15, 0),
                Predecessor = "6",
                Movie = "The Shape of Water"
            };
            TaskbarData Record9 = new TaskbarData()
            {
                TaskId = 8,
                TaskName = "Oscar performance",
                StartDate = new DateTime(2018, 03, 05, 19, 16, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 23, 0),
                Predecessor = "7",
                Performance = "Second performance of the night is 'Remember Me' from Coco",
            };
            TaskbarData Record10 = new TaskbarData()
            {
                TaskId = 9,
                TaskName = "Best foreign language film goes",
                StartDate = new DateTime(2018, 03, 05, 19, 24, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 29, 0),
                Predecessor = "8",
                Movie = "A Fantastic Woman"
            };
            TaskbarData Record11 = new TaskbarData()
            {
                TaskId = 10,
                TaskName = "Best supporting actress",
                StartDate = new DateTime(2018, 03, 05, 19, 30, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 35, 0),
                Predecessor = "9",
                Winner = "Allison Janney",
                Movie = "I, Tonya"
            };
            TaskbarData Record12 = new TaskbarData()
            {
                TaskId = 11,
                TaskName = "Best animated short",
                StartDate = new DateTime(2018, 03, 05, 19, 36, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 45, 0),
                Predecessor = "10",
                Winner = "Kobe Bryant",
                Movie = "Dear Basketball"
            };
            TaskbarData Record13 = new TaskbarData()
            {
                TaskId = 12,
                TaskName = "Award for best animated feature.",
                StartDate = new DateTime(2018, 03, 05, 19, 46, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 52, 0),
                Predecessor = "11",
                Movie = "Coco"
            };
            TaskbarData Record14 = new TaskbarData()
            {
                TaskId = 13,
                TaskName = "Best visual effects.",
                StartDate = new DateTime(2018, 03, 05, 19, 53, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 56, 0),
                Predecessor = "12",
                Movie = "Blade Runner 2049"
            };
            TaskbarData Record15 = new TaskbarData()
            {
                TaskId = 14,
                TaskName = "Achievement in film editing",
                StartDate = new DateTime(2018, 03, 05, 19, 57, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 59, 0),
                Predecessor = "13",
                Movie = "Dunkirk",
            };
            TaskbarData Record16 = new TaskbarData()
            {
                TaskId = 15,
                TaskName = "Oscar moments",
                StartDate = new DateTime(2018, 03, 05, 20, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 09, 0),
                Predecessor = "14",
                Performance = "Jimmy Kimmel surprises moviegoers along with celebrities"
            };
            TaskbarData Record17 = new TaskbarData()
            {
                TaskId = 16,
                TaskName = "Best documentary short",
                StartDate = new DateTime(2018, 03, 05, 20, 10, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 12, 0),
                Predecessor = "15",
                Movie = "Heaven is a traffic jam on the 405"
            };
            TaskbarData Record18 = new TaskbarData()
            {
                TaskId = 17,
                TaskName = "Best live action short film",
                StartDate = new DateTime(2018, 03, 05, 20, 13, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 15, 0),
                Predecessor = "16",
                Movie = "The Silent Child"
            };
            TaskbarData Record19 = new TaskbarData()
            {
                TaskId = 18,
                TaskName = "Oscar performance",
                StartDate = new DateTime(2018, 03, 05, 20, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 09, 0),
                Predecessor = "17",
                Performance = "Jimmy Kimmel surprCommon and Andra Day performs 'Stand Up for Something' by 'Marshall'"
            };
            TaskbarData Record20 = new TaskbarData()
            {
                TaskId = 19,
                TaskName = "Oscar moments",
                StartDate = new DateTime(2018, 03, 05, 20, 26, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 29, 0),
                Predecessor = "18",
                Performance = "The oscars are showcasing the #MeToo and #TimesUp movements with a montage and interviews with actors and filmmakers"
            };
            TaskbarData Record21 = new TaskbarData()
            {
                TaskId = 20,
                TaskName = "Oscar for best adapted screenplay",
                StartDate = new DateTime(2018, 03, 05, 20, 30, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 35, 0),
                Predecessor = "19",
                Winner = "James Ivory",
                Movie = "Call Me By Your Name"
            };
            TaskbarData Record22 = new TaskbarData()
            {
                TaskId = 21,
                TaskName = "Oscar for best original screenplay",
                StartDate = new DateTime(2018, 03, 05, 20, 36, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 44, 0),
                Predecessor = "20",
                Winner = "Jordan Peele",
                Movie = "Get Out"
            };
            TaskbarData Record23 = new TaskbarData()
            {
                TaskId = 22,
                TaskName = "Oscar moments",
                StartDate = new DateTime(2018, 03, 05, 20, 40, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 45, 0),
                Predecessor = "21",
                Performance = "Who’s trending on Twitter at the Oscars? Actors Timothée Chalamet, Chadwick Boseman,Tom Holland, Lupita Nyong’o and Adam Rippon."
            };
            TaskbarData Record24 = new TaskbarData()
            {
                TaskId = 23,
                TaskName = "Best cinematography",
                StartDate = new DateTime(2018, 03, 05, 20, 46, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 48, 0),
                Predecessor = "22",
                Winner = "Roger A. Deakins",
                Movie = "Blade Runner 2049"
            };

            TaskbarData Record25 = new TaskbarData()
            {
                TaskId = 24,
                TaskName = "Oscar performance",
                StartDate = new DateTime(2018, 03, 05, 20, 49, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 54, 0),
                Predecessor = "23",
                Performance = "Keala Settle performs the nominated song 'This is Me' from 'The Greatest Showman'."
            };
            TaskbarData Record26 = new TaskbarData()
            {
                TaskId = 25,
                TaskName = "Best original score",
                StartDate = new DateTime(2018, 03, 05, 20, 55, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 59, 0),
                Predecessor = "24",
                Movie = "The Shape of Water"
            };
            TaskbarData Record27 = new TaskbarData()
            {
                TaskId = 26,
                TaskName = "Award for original song",
                StartDate = new DateTime(2018, 03, 05, 21, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 21, 07, 0),
                Predecessor = "25",
                Winner = "Remember Me",
                Movie = "Coco"
            };
            TaskbarData Record28 = new TaskbarData()
            {
                TaskId = 27,
                TaskName = "Oscar moments",
                StartDate = new DateTime(2018, 03, 05, 21, 05, 0),
                EndDate = new DateTime(2018, 03, 05, 21, 11, 0),
                Predecessor = "26",
                Performance = "Time to pay tribute to those in the cinema world we lost last year"
            };
            TaskbarData Record29 = new TaskbarData()
            {
                TaskId = 28,
                TaskName = "Oscar for best director",
                StartDate = new DateTime(2018, 03, 05, 21, 12, 0),
                EndDate = new DateTime(2018, 03, 05, 21, 19, 0),
                Predecessor = "27",
                Winner = "Guillermo del Toro",
                Movie = "The Shape of Water"
            };
            TaskbarData Record30 = new TaskbarData()
            {
                TaskId = 29,
                TaskName = "Best actor in a leading role",
                StartDate = new DateTime(2018, 03, 05, 21, 20, 0),
                EndDate = new DateTime(2018, 03, 05, 21, 29, 0),
                Predecessor = "28",
                Winner = "Gary Oldman",
                Movie = "The Shape of Water"
            };
            TaskbarData Record31 = new TaskbarData()
            {
                TaskId = 30,
                TaskName = "Best leading actress",
                StartDate = new DateTime(2018, 03, 05, 21, 30, 0),
                EndDate = new DateTime(2018, 03, 05, 21, 44, 0),
                Predecessor = "29",
                Winner = "Frances McDormand",
                Movie = "Three Billboards Outside Ebbing, Missouri"
            };
            TaskbarData Record32 = new TaskbarData()
            {
                TaskId = 31,
                TaskName = "Oscar for best picture.",
                StartDate = new DateTime(2018, 03, 05, 21, 20, 0),
                EndDate = new DateTime(2018, 03, 05, 21, 29, 0),
                Predecessor = "30",
                Movie = "The Shape of Water"
            };
            TaskbarData Record33 = new TaskbarData()
            {
                TaskId = 32,
                TaskName = "90th Academy awards wind-up",
                StartDate = new DateTime(2018, 03, 05, 21, 30, 0),
                EndDate = new DateTime(2018, 03, 05, 21, 30, 0),
                Predecessor = "31",
                Duration = "0",
                Performance = "90th Academy awards wind-up"
            };


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
            TaskDataCollection.Add(Record12);
            TaskDataCollection.Add(Record13);
            TaskDataCollection.Add(Record14);
            TaskDataCollection.Add(Record15);
            TaskDataCollection.Add(Record16);
            TaskDataCollection.Add(Record17);
            TaskDataCollection.Add(Record18);
            TaskDataCollection.Add(Record19);
            TaskDataCollection.Add(Record20);
            TaskDataCollection.Add(Record21);
            TaskDataCollection.Add(Record22);
            TaskDataCollection.Add(Record23);
            TaskDataCollection.Add(Record24);
            TaskDataCollection.Add(Record25);
            TaskDataCollection.Add(Record26);
            TaskDataCollection.Add(Record27);
            TaskDataCollection.Add(Record28);
            TaskDataCollection.Add(Record29);
            TaskDataCollection.Add(Record30);
            TaskDataCollection.Add(Record31);
            TaskDataCollection.Add(Record32);
            TaskDataCollection.Add(Record33);
            return TaskDataCollection;
        }
        public static List<TaskData> FilteredData()
        {
            List<TaskData> TaskDataCollection = new List<TaskData>();
            TaskData Record1 = new TaskData()
            {
                TaskId = 1,
                TaskName = "Launch and flight to lunar orbit",
                StartDate = new DateTime(1969, 07, 16),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record1Child1 = new TaskData()
            {
                TaskId = 2,
                TaskName = "Apollo 11 blasts off from launch pad",
                StartDate = new DateTime(1969, 07, 16, 3, 32, 0),
                EndDate = new DateTime(1969, 07, 16, 3, 32, 0),
                Duration = "0"
            };
            TaskData Record1Child2 = new TaskData()
            {
                TaskId = 3,
                TaskName = "Entry to Earth’s orbit",
                StartDate = new DateTime(1969, 07, 16, 3, 32, 0),
                EndDate = new DateTime(1969, 07, 16, 3, 44, 0),
                Predecessor = "2"
            };
            TaskData Record1Child3 = new TaskData()
            {
                TaskId = 4,
                TaskName = "Travelling in earth’s orbit",
                StartDate = new DateTime(1969, 07, 16, 3, 44, 0),
                EndDate = new DateTime(1969, 07, 16, 4, 22, 13),
                Predecessor = "3"
            };
            TaskData Record1Child4 = new TaskData()
            {
                TaskId = 5,
                TaskName = "Trajectory change toward the Moon",
                StartDate = new DateTime(1969, 07, 16, 4, 22, 13),
                EndDate = new DateTime(1969, 07, 16, 4, 52, 0),
                Predecessor = "4"
            };
            TaskData Record1Child5 = new TaskData()
            {
                TaskId = 6,
                TaskName = "extraction maneuver performed",
                StartDate = new DateTime(1969, 07, 16, 4, 52, 0),
                EndDate = new DateTime(1969, 07, 16, 4, 52, 0),
                Predecessor = "5"
            };
            TaskData Record1Child6 = new TaskData()
            {
                TaskId = 7,
                TaskName = "Travelling toward moon and entering into lunar orbit",
                StartDate = new DateTime(1969, 07, 16, 4, 52, 0),
                EndDate = new DateTime(1969, 07, 16, 16, 21, 50),
                Predecessor = "6"
            };
            TaskData Record1Child7 = new TaskData()
            {
                TaskId = 8,
                TaskName = "Midcourse correction, sharpening the course and testing the engine",
                StartDate = new DateTime(1969, 07, 16, 23, 22, 0),
                EndDate = new DateTime(1969, 07, 17, 5, 21, 50)
            };
            TaskData Record1Child8 = new TaskData()
            {
                TaskId = 9,
                TaskName = "Reached half the distance spanning between earth and moon",
                StartDate = new DateTime(1969, 07, 17, 5, 22, 0),
                EndDate = new DateTime(1969, 07, 17, 08, 0, 50)
            };
            TaskData Record1Child9 = new TaskData()
            {
                TaskId = 10,
                TaskName = "Reached 3/4th distance spanning between earth and moon",
                StartDate = new DateTime(1969, 07, 17, 20, 02, 0),
                EndDate = new DateTime(1969, 07, 18, 16, 21, 50)
            };
            TaskData Record1Child10 = new TaskData()
            {
                TaskId = 11,
                TaskName = "Reached distance 45000 miles from moon",
                StartDate = new DateTime(1969, 07, 18, 23, 20, 0),
                EndDate = new DateTime(1969, 07, 19, 17, 21, 0)
            };

            Record1.SubTasks.Add(Record1Child1);
            Record1.SubTasks.Add(Record1Child2);
            Record1.SubTasks.Add(Record1Child3);
            Record1.SubTasks.Add(Record1Child4);
            Record1.SubTasks.Add(Record1Child5);
            Record1.SubTasks.Add(Record1Child6);
            Record1.SubTasks.Add(Record1Child7);
            Record1.SubTasks.Add(Record1Child8);
            Record1.SubTasks.Add(Record1Child9);
            Record1.SubTasks.Add(Record1Child10);
            Record1.SubTasks.Add(Record1Child1);

            TaskData Record2 = new TaskData()
            {
                TaskId = 12,
                TaskName = "Lunar descent",
                StartDate = new DateTime(1969, 07, 19, 17, 21, 50),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record2Child1 = new TaskData()
            {
                TaskId = 13,
                TaskName = "Lunar Orbiting (30 orbits)",
                StartDate = new DateTime(1969, 07, 19, 17, 21, 50),
                EndDate = new DateTime(1969, 07, 20, 12, 52, 0),
                Predecessor = "11"
            };
            TaskData Record2Child2 = new TaskData()
            {
                TaskId = 14,
                TaskName = "Landing site identified",
                StartDate = new DateTime(1969, 07, 20, 12, 52, 0),
                EndDate = new DateTime(1969, 07, 20, 12, 52, 0),
                Predecessor = "13"
            };
            TaskData Record2Child3 = new TaskData()
            {
                TaskId = 15,
                TaskName = "Eagle separated from Columbia",
                StartDate = new DateTime(1969, 07, 20, 17, 44, 0),
                EndDate = new DateTime(1969, 07, 20, 17, 44, 0)
            };
            TaskData Record2Child4 = new TaskData()
            {
                TaskId = 16,
                TaskName = "Eagle’s decent to Moon",
                StartDate = new DateTime(1969, 07, 20, 17, 44, 0),
                EndDate = new DateTime(1969, 07, 20, 20, 16, 40)
            };

            Record2.SubTasks.Add(Record2Child1);
            Record2.SubTasks.Add(Record2Child2);
            Record2.SubTasks.Add(Record2Child3);
            Record2.SubTasks.Add(Record2Child4);

            TaskData Record3 = new TaskData()
            {
                TaskId = 17,
                TaskName = "Landing",
                StartDate = new DateTime(1969, 07, 20, 20, 17, 40),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record3Child1 = new TaskData()
            {
                TaskId = 18,
                TaskName = "Eagle’s touch down",
                StartDate = new DateTime(1969, 07, 20, 20, 17, 40),
                EndDate = new DateTime(1969, 07, 20, 20, 17, 40)
            };
            TaskData Record3Child2 = new TaskData()
            {
                TaskId = 19,
                TaskName = "Radio communication and Performing post landing checklist",
                StartDate = new DateTime(1969, 07, 20, 20, 17, 40),
                EndDate = new DateTime(1969, 07, 20, 23, 43, 0)
            };
            TaskData Record3Child3 = new TaskData()
            {
                TaskId = 20,
                TaskName = "Preparations for EVA (Extra Vehicular Activity)",
                StartDate = new DateTime(1969, 07, 20, 23, 43, 0),
                EndDate = new DateTime(1969, 07, 21, 2, 39, 33)
            };
            TaskData Record3Child4 = new TaskData()
            {
                TaskId = 21,
                TaskName = "Hatch open and climbing down the moon",
                StartDate = new DateTime(1969, 07, 21, 2, 39, 33),
                EndDate = new DateTime(1969, 07, 21, 2, 56, 15)
            };
            TaskData Record3Child5 = new TaskData()
            {
                TaskId = 22,
                TaskName = "Armstrong stepped down on the moon",
                StartDate = new DateTime(1969, 07, 21, 2, 56, 15),
                EndDate = new DateTime(1969, 07, 21, 3, 11, 0)
            };
            Record3.SubTasks.Add(Record3Child1);
            Record3.SubTasks.Add(Record3Child2);
            Record3.SubTasks.Add(Record3Child3);
            Record3.SubTasks.Add(Record3Child4);
            Record3.SubTasks.Add(Record3Child5);

            TaskData Record4 = new TaskData()
            {
                TaskId = 23,
                TaskName = "Lunar surface operations",
                StartDate = new DateTime(1969, 07, 21, 2, 56, 15),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record4Child1 = new TaskData()
            {
                TaskId = 24,
                TaskName = "Soil sample collections",
                StartDate = new DateTime(1969, 07, 21, 2, 56, 15),
                EndDate = new DateTime(1969, 07, 21, 3, 11, 0)
            };
            TaskData Record4Child2 = new TaskData()
            {
                TaskId = 25,
                TaskName = "Aldrin joined Armstrong",
                StartDate = new DateTime(1969, 07, 21, 3, 11, 0),
                EndDate = new DateTime(1969, 07, 21, 3, 41, 0)
            };
            TaskData Record4Child3 = new TaskData()
            {
                TaskId = 26,
                TaskName = "planted the lunar flag assembly",
                StartDate = new DateTime(1969, 07, 21, 3, 41, 0),
                EndDate = new DateTime(1969, 07, 21, 3, 46, 0)
            };
            TaskData Record4Child4 = new TaskData()
            {
                TaskId = 27,
                TaskName = "President Richard Nixon’s telephone-radio transmission",
                StartDate = new DateTime(1969, 07, 21, 3, 48, 0),
                EndDate = new DateTime(1969, 07, 21, 3, 51, 0)
            };
            TaskData Record4Child5 = new TaskData()
            {
                TaskId = 28,
                TaskName = "Collect rock samples, photos and other mission controls",
                StartDate = new DateTime(1969, 07, 21, 3, 52, 0),
                EndDate = new DateTime(1969, 07, 21, 4, 50, 0)
            };
            Record4.SubTasks.Add(Record4Child1);
            Record4.SubTasks.Add(Record4Child2);
            Record4.SubTasks.Add(Record4Child3);
            Record4.SubTasks.Add(Record4Child4);
            Record4.SubTasks.Add(Record4Child5);
            TaskData Record5 = new TaskData()
            {
                TaskId = 29,
                TaskName = "Lunar ascent",
                StartDate = new DateTime(1969, 07, 21, 4, 51, 0),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record5Child1 = new TaskData()
            {
                TaskId = 30,
                TaskName = "Climbing the eagle to ascent",
                StartDate = new DateTime(1969, 07, 21, 4, 51, 0),
                EndDate = new DateTime(1969, 07, 21, 5, 0, 0)
            };
            TaskData Record5Child2 = new TaskData()
            {
                TaskId = 31,
                TaskName = "Hatch closing",
                StartDate = new DateTime(1969, 07, 21, 5, 1, 0),
                EndDate = new DateTime(1969, 07, 21, 5, 1, 0)
            };
            TaskData Record5Child3 = new TaskData()
            {
                TaskId = 32,
                TaskName = "Final housekeeping",
                StartDate = new DateTime(1969, 07, 21, 5, 2, 0),
                EndDate = new DateTime(1969, 07, 21, 8, 0, 0)
            };
            TaskData Record5Child4 = new TaskData()
            {
                TaskId = 33,
                TaskName = "Resting of astronauts",
                StartDate = new DateTime(1969, 07, 21, 8, 0, 0),
                EndDate = new DateTime(1969, 07, 21, 15, 0, 0)
            };
            TaskData Record5Child5 = new TaskData()
            {
                TaskId = 34,
                TaskName = "Preparation for lift off and Ascent engine started",
                StartDate = new DateTime(1969, 07, 21, 15, 0, 0),
                EndDate = new DateTime(1969, 07, 21, 17, 54, 0)
            };
            TaskData Record5Child6 = new TaskData()
            {
                TaskId = 35,
                TaskName = "Eagle lifted off",
                StartDate = new DateTime(1969, 07, 21, 17, 54, 0),
                EndDate = new DateTime(1969, 07, 21, 21, 23, 0)
            };
            TaskData Record5Child7 = new TaskData()
            {
                TaskId = 36,
                TaskName = "Eagle’s travel toward Columbia",
                StartDate = new DateTime(1969, 07, 21, 21, 24, 0),
                EndDate = new DateTime(1969, 07, 21, 21, 35, 0)
            };
            Record5.SubTasks.Add(Record5Child1);
            Record5.SubTasks.Add(Record5Child2);
            Record5.SubTasks.Add(Record5Child3);
            Record5.SubTasks.Add(Record5Child4);
            Record5.SubTasks.Add(Record5Child5);
            Record5.SubTasks.Add(Record5Child6);
            Record5.SubTasks.Add(Record5Child7);

            TaskData Record6 = new TaskData()
            {
                TaskId = 37,
                TaskName = "Return",
                StartDate = new DateTime(1969, 07, 21, 21, 24, 0),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record6Child1 = new TaskData()
            {
                TaskId = 38,
                TaskName = "Eagle docked with Columbia",
                StartDate = new DateTime(1969, 07, 16, 21, 24, 0),
                EndDate = new DateTime(1969, 07, 16, 21, 35, 0)
            };
            TaskData Record6Child2 = new TaskData()
            {
                TaskId = 39,
                TaskName = "Eagle’s ascent stage jettisoned into lunar orbit",
                StartDate = new DateTime(1969, 07, 21, 21, 35, 0),
                EndDate = new DateTime(1969, 07, 21, 23, 41, 0)
            };
            Record6.SubTasks.Add(Record6Child1);
            Record6.SubTasks.Add(Record6Child2);
            TaskData Record7 = new TaskData()
            {
                TaskId = 40,
                TaskName = "Decent toward earth  and Splashdown",
                StartDate = new DateTime(1969, 07, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record7Child1 = new TaskData()
            {
                TaskId = 41,
                TaskName = "Spacecraft reaches 1/4th distance spanning between moon and earth",
                StartDate = new DateTime(1969, 07, 21, 23, 50, 0),
                EndDate = new DateTime(1969, 07, 22, 16, 40, 0)
            };
            TaskData Record7Child2 = new TaskData()
            {
                TaskId = 42,
                TaskName = "Spacecraft travels to midway point of journey",
                StartDate = new DateTime(1969, 07, 22, 16, 0, 0),
                EndDate = new DateTime(1969, 07, 23, 16, 0, 0)
            };
            TaskData Record7Child3 = new TaskData()
            {
                TaskId = 43,
                TaskName = "Spacecraft travels to 3/4th point of journey",
                StartDate = new DateTime(1969, 07, 23, 16, 40, 0),
                EndDate = new DateTime(1969, 07, 24, 10, 0, 0)
            };
            TaskData Record7Child4 = new TaskData()
            {
                TaskId = 44,
                TaskName = "Crew prepares for splashdown",
                StartDate = new DateTime(1969, 07, 24, 11, 47, 0),
                EndDate = new DateTime(1969, 07, 24, 16, 20, 0)
            };
            TaskData Record7Child5 = new TaskData()
            {
                TaskId = 45,
                TaskName = "Command and service modules separates",
                StartDate = new DateTime(1969, 07, 24, 16, 20, 0),
                EndDate = new DateTime(1969, 07, 24, 16, 35, 0)
            };
            TaskData Record7Child6 = new TaskData()
            {
                TaskId = 46,
                TaskName = "Command module re-enters the Earth’s atmosphere",
                StartDate = new DateTime(1969, 07, 24, 16, 35, 0),
                EndDate = new DateTime(1969, 07, 24, 16, 50, 0)
            };
            TaskData Record7Child7 = new TaskData()
            {
                TaskId = 47,
                TaskName = "Spacecraft splashes near USS hornet",
                StartDate = new DateTime(1969, 07, 24, 16, 51, 0),
                EndDate = new DateTime(1969, 07, 24, 16, 51, 0)
            };

            Record7.SubTasks.Add(Record7Child1);
            Record7.SubTasks.Add(Record7Child2);
            Record7.SubTasks.Add(Record7Child3);
            Record7.SubTasks.Add(Record7Child4);
            Record7.SubTasks.Add(Record7Child5);
            Record7.SubTasks.Add(Record7Child6);
            Record7.SubTasks.Add(Record7Child7);

            TaskDataCollection.Add(Record1);
            TaskDataCollection.Add(Record2);
            TaskDataCollection.Add(Record3);
            TaskDataCollection.Add(Record4);
            TaskDataCollection.Add(Record5);
            TaskDataCollection.Add(Record6);
            TaskDataCollection.Add(Record7);
            return TaskDataCollection;
        }
    }
}
