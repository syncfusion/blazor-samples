using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace ej2_blazor_defaultdata
{
    public class ResourceData
    {
        public class ResourceAlloacteData
        {
            public int ResourceId { get; set; }
            public string ResourceName { get; set; }
            public double Unit { get; set; }

        }
        public static List<ResourceAlloacteData> GetResources = new List<ResourceAlloacteData>()
        {

            new ResourceAlloacteData() { ResourceId= 1, ResourceName= "Martin Tamer" ,Unit=70},
    new ResourceAlloacteData() { ResourceId= 2, ResourceName= "Rose Fuller" },
    new ResourceAlloacteData() { ResourceId= 3, ResourceName= "Margaret Buchanan" },
   new ResourceAlloacteData() { ResourceId= 4, ResourceName= "Fuller King" },
    new ResourceAlloacteData() { ResourceId= 5, ResourceName= "Davolio Fuller" },
    new ResourceAlloacteData() { ResourceId= 6, ResourceName= "Van Jack" },
    new ResourceAlloacteData() { ResourceId= 7, ResourceName= "Fuller Buchanan" },
    new ResourceAlloacteData() { ResourceId= 8, ResourceName= "Jack Davolio" },
    new ResourceAlloacteData() { ResourceId= 9, ResourceName= "Tamer Vinet" },
    new ResourceAlloacteData() { ResourceId= 10, ResourceName= "Vinet Fuller" },
    new ResourceAlloacteData() { ResourceId= 11, ResourceName= "Bergs Anton" },
    new ResourceAlloacteData() { ResourceId= 12, ResourceName= "Construction Supervisor" }
                };

        public class TaskData
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public string TaskType { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Duration { get; set; }
            public int Progress { get; set; }
            public int? ParentId { get; set; }
            public double? Work { get; set; }
            public List<ResourceAlloacteData> Resources { get; set; }

        }
        public static List<TaskData> GetTaskCollection()
        {
            List<TaskData> Tasks = new List<TaskData>() {

        new TaskData() {
            TaskId = 1,
            TaskName = "Project initiation",
            StartDate = new DateTime(2019, 03, 28),
            EndDate = new DateTime(2019, 07, 28),
            TaskType ="FixedDuration",
            Work=128,
            Duration="4"
        },
        new TaskData() {
            TaskId = 2,
            TaskName = "Identify Site location",
            StartDate = new DateTime(2019, 03, 29),
            Progress = 30,
            ParentId = 1,
            Duration="2",
            TaskType ="FixedDuration",
            Work=16,
            Resources = new List<ResourceAlloacteData>(){ new ResourceAlloacteData() { ResourceId=1,Unit=70} ,new ResourceAlloacteData() { ResourceId=6} }
        },
        new TaskData() {
            TaskId = 3,
            TaskName = "Perform soil test",
            StartDate = new DateTime(2019, 03, 29),
            Resources = new List<ResourceAlloacteData>(){ new ResourceAlloacteData() { ResourceId=2} ,new ResourceAlloacteData() { ResourceId=3} ,new ResourceAlloacteData() { ResourceId=5} },
            ParentId = 1,
            Work=96,
            Duration="4",
            TaskType="FixedWork"
        },
        new TaskData() {
            TaskId = 4,
            TaskName = "Soil test approval",
            StartDate = new DateTime(2019, 03, 29),
            Duration = "1",
            Progress = 30,
            ParentId = 1,
            Resources = new List<ResourceAlloacteData>(){ new ResourceAlloacteData() { ResourceId=8} ,new ResourceAlloacteData() { ResourceId=9} },
            Work=16,
            TaskType="FixedWork"
        },
        new TaskData() {
            TaskId = 5,
            TaskName = "Project estimation",
            StartDate = new DateTime(2019, 03, 29),
            EndDate = new DateTime(2019, 04, 2),

            TaskType="FixedDuration",
            Duration="4"
        },
        new TaskData() {
            TaskId = 6,
            TaskName = "Develop floor plan for estimation",
            StartDate = new DateTime(2019, 03, 29),
            Duration = "3",
            Progress = 30,
            ParentId = 5,
            Resources = new List<ResourceAlloacteData>(){ new ResourceAlloacteData() { ResourceId=4} },
            Work=30,
            TaskType="FixedWork"
        },
        new TaskData() {
            TaskId = 7,
            TaskName = "List materials",
            StartDate = new DateTime(2019, 04, 01),
            Duration = "3",
            Progress = 30,
            ParentId = 5,
            TaskType="FixedWork",
            Work=48,
                        Resources = new List<ResourceAlloacteData>(){ new ResourceAlloacteData() { ResourceId=4},new ResourceAlloacteData() { ResourceId=8} },

        },
        new TaskData() {
            TaskId = 8,
            TaskName = "Estimation approval",
            StartDate = new DateTime(2019, 04, 01),
            Duration = "2",
            ParentId = 5,
            Work=60,
            TaskType="FixedWork",
            Resources = new List<ResourceAlloacteData>(){ new ResourceAlloacteData() { ResourceId= 12},new ResourceAlloacteData() { ResourceId= 5} },

        },
        new TaskData() {
            TaskId = 9,
            TaskName = "Sign contract",
            StartDate = new DateTime(2019, 03, 31),
            EndDate = new DateTime(2019, 04, 01),
            Duration="1",
            TaskType="FixedWork",
            Work=24,

             Resources = new List<ResourceAlloacteData>(){ new ResourceAlloacteData() { ResourceId= 12},new ResourceAlloacteData() { ResourceId= 5} }
        },

    };
            return Tasks;
        }
    }
}