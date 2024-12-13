#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.GanttChart
{
    public class MultiTaskbarData
    {
        public class ResourceInfoModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double MaxUnit { get; set; }
            public string? Group { get; set; }
        }
        public class AssignmentModel
        {
            public int Id { get; set; }
            public int TaskId { get; set; }
            public int ResourceId { get; set; }
            public double Unit { get; set; }
        }
        public static List<ResourceInfoModel> GetResources = new List<ResourceInfoModel>()
        {
            new ResourceInfoModel() { Id= 1, Name= "Martin Tamer", Group="Planning Team", },
            new ResourceInfoModel() { Id= 2, Name= "Rose Fuller", Group="Testing Team" },
            new ResourceInfoModel() { Id= 3, Name= "Margaret Buchanan", Group="Approval Team", },
            new ResourceInfoModel() { Id= 4, Name= "Fuller King", Group="Development Team",  },
            new ResourceInfoModel() { Id= 5, Name= "Davolio Fuller", Group="Approval Team", },
            new ResourceInfoModel() { Id= 6, Name= "Fuller Buchanan", Group="Development Team" },
            new ResourceInfoModel() { Id= 7, Name= "Jack Davolio", Group="Planning Team" },
            new ResourceInfoModel() { Id= 8, Name= "Tamer Vinet", Group="Testing Team" },
            new ResourceInfoModel() { Id= 9, Name= "Vinet Fuller", Group="Development Team" },
            new ResourceInfoModel() { Id= 10, Name= "Bergs Anton", Group="Testing Team" },
        };
        public class TaskInfoModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Duration { get; set; }
            public int Progress { get; set; }
            public int? ParentId { get; set; }
            public string Predecessor { get; set; }
            public string Notes { get; set; }
            public double? Work { get; set; }
            public string TaskType { get; set; }
        }
        public static List<TaskInfoModel> GetTaskCollection()
        {
            List<TaskInfoModel> Tasks = new List<TaskInfoModel>()
            {
                new TaskInfoModel() { Id = 1, Name = "Project initiation", StartDate = new DateTime(2019, 03, 29), EndDate = new DateTime(2019, 04, 21), TaskType = "FixedDuration", Work = 128, Duration = "4" },
                new TaskInfoModel() { Id = 2, Name = "Identify Site location", StartDate = new DateTime(2019, 03, 29), Progress = 30, ParentId = 1, Duration = "3" },
                new TaskInfoModel() { Id = 3, Name = "Perform soil test", StartDate = new DateTime(2019, 04, 03), Progress = 50, ParentId = 1, Duration = "5", Work = 16, Predecessor = "2" },
                new TaskInfoModel() { Id = 4, Name = "Soil test approval", StartDate = new DateTime(2019, 04, 09), ParentId = 1, Work = 96, Duration = "3", TaskType = "FixedWork", Predecessor = "3", Progress = 40 },
                new TaskInfoModel() { Id = 5, Name = "Project estimation", StartDate = new DateTime(2019, 03, 29), EndDate = new DateTime(2019, 04, 21), Progress = 30, Work = 16, TaskType = "FixedWork" },
                new TaskInfoModel() { Id = 6, Name = "Develop floor plan for estimation", StartDate = new DateTime(2019, 04, 01), TaskType = "FixedDuration", Duration = "5", Progress = 40, Work = 50 },
                new TaskInfoModel() { Id = 7, Name = "List materials", StartDate = new DateTime(2019, 04, 04), Duration = "4", Progress = 30, ParentId = 5, Work = 30, TaskType = "FixedDuration", Predecessor = "6FS-2" },
                new TaskInfoModel() { Id = 8, Name = "Estimation approval", StartDate = new DateTime(2019, 04, 09), Duration = "4", Progress = 30, ParentId = 5, TaskType = "FixedWork", Work = 48, Predecessor = "7FS-1" },
                new TaskInfoModel() { Id = 9, Name = "Site work", Progress = 30, StartDate = new DateTime(2019, 04, 04), EndDate = new DateTime(2019, 04, 21), Work = 60, TaskType = "FixedUnit" },
                new TaskInfoModel() { Id = 10, Name = "Install temporary power service", StartDate = new DateTime(2019, 04, 01), Duration = "14", ParentId = 9, Work = 60, Progress = 50, TaskType = "FixedWork" },
                new TaskInfoModel() { Id = 11, Name = "Clear the building site", StartDate = new DateTime(2019, 04, 08), Duration = "9", ParentId = 9, Work = 60, Progress = 40, TaskType = "FixedDuration", Predecessor = "10FS-9" },
                new TaskInfoModel() { Id = 12, Name = "Sign contract", StartDate = new DateTime(2019, 04, 12), Duration = "5", ParentId = 9, Work = 60, Progress = 40, TaskType = "FixedDuration", Predecessor = "11FS-5" },
                new TaskInfoModel() { Id = 13, Name = "Foundation", StartDate = new DateTime(2022, 04, 04), EndDate = new DateTime(2019, 04, 28), Work = 60, Progress = 40, TaskType = "FixedDuration" },
                new TaskInfoModel() { Id = 14, Name = "Excavate for foundations", StartDate = new DateTime(2019, 04, 01), Duration = "2", ParentId = 13, Work = 60, Progress = 40, TaskType = "FixedDuration" },
                new TaskInfoModel() { Id = 15, Name = "Dig footer", StartDate = new DateTime(2019, 04, 04), Duration = "2", ParentId = 13, Work = 60, Progress = 40, TaskType = "FixedDuration", Predecessor = "14FS+1" },
                new TaskInfoModel() { Id = 16, Name = "Install plumbing grounds", StartDate = new DateTime(2019, 04, 08), Duration = "2", ParentId = 13, Work = 60, Progress = 40, TaskType = "FixedDuration", Predecessor = "15FS" },
                new TaskInfoModel() { Id = 17, Name = "Framing", StartDate = new DateTime(2019, 04, 04), EndDate = new DateTime(2019, 04, 28), Work = 60, Progress = 40, TaskType = "FixedDuration" },
                new TaskInfoModel() { Id = 18, Name = "Add load-bearing structure", StartDate = new DateTime(2019, 04, 03), Duration = "2", ParentId = 17, Work = 60, Progress = 20, TaskType = "FixedDuration" },
                new TaskInfoModel() { Id = 19, Name = "Natural gas utilities", StartDate = new DateTime(2019, 04, 08), Duration = "5", ParentId = 17, Work = 60, Progress = 40, TaskType = "FixedDuration", Predecessor = "18" },
                new TaskInfoModel() { Id = 20, Name = "Electrical utilities", StartDate = new DateTime(2022, 04, 01), Duration = "4", ParentId = 17, Work = 60, Progress = 50, TaskType = "FixedWork", Predecessor = "19FS+1" },
                new TaskInfoModel() { Id = 21, Name = "Plumbing test", StartDate = new DateTime(2019, 04, 04), Duration = "4", Work = 60, Progress = 50, TaskType = "FixedWork" },
                new TaskInfoModel() { Id = 22, Name = "Electrical test", StartDate = new DateTime(2019, 04, 04), Duration = "4", Work = 60, Progress = 50, TaskType = "FixedWork", Predecessor = "21" },
                new TaskInfoModel() { Id = 23, Name = "First floor initiation", StartDate = new DateTime(2019, 04, 06), Duration = "4", Work = 60, Progress = 50, TaskType = "FixedWork" },
                new TaskInfoModel() { Id = 24, Name = "Interior work", StartDate = new DateTime(2019, 04, 04), Duration = "4", Work = 60, Progress = 50, TaskType = "FixedWork", Predecessor = "23" },
                new TaskInfoModel() { Id = 25, Name = "First floor tile work initiation", StartDate = new DateTime(2019, 04, 10), Duration = "4", Work = 60, Progress = 50, TaskType = "FixedWork" },
                new TaskInfoModel() { Id = 26, Name = "Tile test", StartDate = new DateTime(2019, 04, 04), Duration = "4", Work = 60, Progress = 50, TaskType = "FixedWork" },
                new TaskInfoModel() { Id = 27, Name = "Second floor initiation", StartDate = new DateTime(2019, 04, 10), Duration = "4", Work = 60, Progress = 50, TaskType = "FixedWork" },
                new TaskInfoModel() { Id = 28, Name = "Second floor tile work initiation", StartDate = new DateTime(2019, 04, 06), Duration = "4", Work = 60, Progress = 50, TaskType = "FixedWork", Predecessor = "27FS-1" },
                new TaskInfoModel() { Id = 29, Name = "Exterior work initiation", StartDate = new DateTime(2019, 04, 12), Duration = "4", Work = 60, Progress = 50, TaskType = "FixedWork" },
                new TaskInfoModel() { Id = 30, Name = "Building test", StartDate = new DateTime(2019, 04, 08), Duration = "4", Work = 60, Progress = 50, TaskType = "FixedWork" }
            };

            return Tasks;
        }

        public static List<AssignmentModel> GetAssignmentCollection()
        {
            List<AssignmentModel> assignments = new List<AssignmentModel>()
            {
                new AssignmentModel(){ Id=1, TaskId = 2 , ResourceId=1, Unit=70},
                new AssignmentModel(){ Id=2, TaskId = 3 , ResourceId=1, Unit=70},
                new AssignmentModel(){ Id=3, TaskId = 4 , ResourceId=1},
                new AssignmentModel(){ Id=4, TaskId = 6 , ResourceId=2},
                new AssignmentModel(){ Id=6, TaskId = 8 , ResourceId=2},
                new AssignmentModel(){ Id=7, TaskId = 10 , ResourceId=3},
                new AssignmentModel(){ Id=8, TaskId = 11, ResourceId=3},
                new AssignmentModel(){ Id=9, TaskId = 12 , ResourceId=3},
                new AssignmentModel(){ Id=10, TaskId = 14 , ResourceId=4},
                new AssignmentModel(){ Id=11, TaskId = 15 , ResourceId=4},
                new AssignmentModel(){ Id=12, TaskId = 16 , ResourceId=4},
                new AssignmentModel(){ Id=13, TaskId = 18 , ResourceId=5},
                new AssignmentModel(){ Id=14, TaskId = 19 , ResourceId=5},
                new AssignmentModel(){ Id=15, TaskId = 20 , ResourceId=5},
                new AssignmentModel(){ Id=16, TaskId = 21 , ResourceId=6},
                new AssignmentModel(){ Id=17, TaskId = 22 , ResourceId=6},
                new AssignmentModel(){ Id=18, TaskId = 23 , ResourceId=7},
                new AssignmentModel(){ Id=19, TaskId = 24 , ResourceId=7},
                new AssignmentModel(){ Id=20, TaskId = 25 , ResourceId=8},
                new AssignmentModel(){ Id=21, TaskId = 26 , ResourceId=8},
                new AssignmentModel(){ Id=22, TaskId = 27 , ResourceId=9},
                new AssignmentModel(){ Id=23, TaskId = 28 , ResourceId=9},
                new AssignmentModel(){ Id=24, TaskId = 29 , ResourceId=10},
            };
            return assignments;
        }
    }
}
