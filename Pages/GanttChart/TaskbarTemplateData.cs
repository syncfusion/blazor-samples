using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace ej2_blazor_taskbartemplatedata
{
    public class TaskbarTemplateData
    {
        public class TaskData
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Duration { get; set; }
            public int Progress { get; set; }
            public string Predecessor { get; set; }
            public int? ParentId { get; set; }
        }
        public class TaskProperties
        {
            public string TaskName { get; set; }
            public double Duration { get; set; }
        }
        public class TaskbarData : TaskData
        {
            public string Performance { get; set; }
            public string Winner { get; set; }
            public string Movie { get; set; }
            public TaskProperties GanttProperties { get; set; }

        }
        public static List<TaskbarData> TaskTemplateData()
        {
            List<TaskbarData> TaskDataCollection = new List<TaskbarData> {

             new TaskbarData()
            {
                TaskId = 1,
                TaskName = "Product concept",
                StartDate = new DateTime(2018, 03, 05, 18, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 15, 0),

            },
             new TaskbarData()
            {
                TaskId = 2,
                TaskName = "Oscar moments",
                StartDate = new DateTime(2018, 03, 05, 18, 30, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 45, 0),
                Winner = "",
                Performance = "90th Academy awards kicks-off and Jimmy kimmel hosts the show",
                ParentId=1
            },
            new TaskbarData()
            {
                TaskId = 3,
                TaskName = "Actor in a supporting role",
                StartDate = new DateTime(2018, 03, 05, 18, 36, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 42, 0),
                Predecessor = "1",
                Winner = "Sam Rockwell",
                Movie = "Three Billboards Outside Ebbing, Missouri.",
                ParentId=1
            },
             new TaskbarData()
            {
                TaskId = 4,
                TaskName = "Hair and makeup",
                StartDate = new DateTime(2018, 03, 05, 18, 33, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 40, 0),
                Predecessor = "2",
                Movie = "Darkest Hour",
                ParentId=1
            },

            new TaskbarData()
            {
                 TaskId = 5,
                TaskName = "Product release",
                StartDate = new DateTime(2018, 03, 05, 18, 41, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 52, 0),

            },
            new TaskbarData()
            {
                TaskId = 6,
                TaskName = "Costume design",
                StartDate = new DateTime(2018, 03, 05, 18, 59, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 10, 0),
                Predecessor = "3",
                Winner = "Mark Bridges",
                Movie = "Phantom Thread",
                ParentId = 5
            },
            new TaskbarData()
            {
                TaskId = 7,
                TaskName = "Documentary feature",
                StartDate = new DateTime(2018, 03, 05, 19, 11, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 15, 0),
                Predecessor = "4",
                Winner = "Bryan Fogel",
                Movie = "Icarus",
                ParentId = 5
            },
             new TaskbarData()
             {
                 TaskId = 8,
                 TaskName = "Best sound editing and sound mixing",
                  StartDate = new DateTime(2018, 03, 05, 19, 16, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 23, 0),
                 Predecessor = "5",
                 Winner = "Richard King and Alex Gibson",
                 Movie = "Dunkirk",
                 ParentId = 5
             },
             };



            return TaskDataCollection;
        }
    }
}
