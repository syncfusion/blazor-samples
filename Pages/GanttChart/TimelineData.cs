using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace ej2_blazor_timelinedata
{
    public class TimelineData
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
        public class TaskResources
        {
            public int ResourceId { get; set; }
            public string ResourceName { get; set; }
        }       
        public static List<TaskData> TimelineRecord()
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
    }
}
