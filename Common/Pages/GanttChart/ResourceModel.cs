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
using System.Threading.Tasks;
using BlazorDemos;
namespace ej2_blazor_defaultdata
{
    public class ResourceModel
    {
        public class ResourceInfoModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double MaxUnit { get; set; }
        }
        public static List<ResourceInfoModel> GetResources = new List<ResourceInfoModel>()
        {
            new ResourceInfoModel() { Id= 1, Name= "Martin Tamer" ,MaxUnit=70},
            new ResourceInfoModel() { Id= 2, Name= "Rose Fuller" },
            new ResourceInfoModel() { Id= 3, Name= "Margaret Buchanan" },
            new ResourceInfoModel() { Id= 4, Name= "Fuller King", MaxUnit = 100},
            new ResourceInfoModel() { Id= 5, Name= "Davolio Fuller" },
            new ResourceInfoModel() { Id= 6, Name= "Van Jack" },
            new ResourceInfoModel() { Id= 7, Name= "Fuller Buchanan" },
            new ResourceInfoModel() { Id= 8, Name= "Jack Davolio" },
            new ResourceInfoModel() { Id= 9, Name= "Tamer Vinet" },
            new ResourceInfoModel() { Id= 10, Name= "Vinet Fuller" },
            new ResourceInfoModel() { Id= 11, Name= "Bergs Anton" },
            new ResourceInfoModel() { Id= 12, Name= "Construction Supervisor" }
        };

        public class TaskInfoModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string TaskType { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public string Duration { get; set; }
            public int Progress { get; set; }
            public int? ParentId { get; set; }
            public double? Work { get; set; }
        }

        public class AssignmentModel
        {
            public int PrimaryId { get; set; }
            public int TaskId { get; set; }
            public int ResourceId { get; set; }
            public double Unit { get; set; }
        }

        public static List<TaskInfoModel> GetTaskCollection()
        {
            return new List<TaskInfoModel>()
            {
                new TaskInfoModel() { Id = 1, Name = "Project initiation", StartDate = new DateTime(2021, 03, 28), EndDate = new DateTime(2021, 07, 28), TaskType ="FixedDuration", Work=128, Duration="4" },
                new TaskInfoModel() { Id = 2, Name = "Identify site location", StartDate = new DateTime(2021, 03, 29), Progress = 30, ParentId = 1, Duration="2", TaskType ="FixedDuration", Work=16 },
                new TaskInfoModel() { Id = 3, Name = "Perform soil test", StartDate = new DateTime(2021, 03, 29), ParentId = 1, Work=96, Duration="4", TaskType="FixedWork" },
                new TaskInfoModel() { Id = 4, Name = "Soil test approval", StartDate = new DateTime(2021, 03, 29), Duration = "1", Progress = 30, ParentId = 1, Work=16, TaskType="FixedWork" },
                new TaskInfoModel() { Id = 5, Name = "Project estimation", StartDate = new DateTime(2021, 03, 29), EndDate = new DateTime(2021, 04, 2), TaskType="FixedDuration", Duration="4" },
                new TaskInfoModel() { Id = 6, Name = "Develop floor plan for estimation", StartDate = new DateTime(2021, 03, 29), Duration = "3", Progress = 30, ParentId = 5, Work=30, TaskType="FixedWork" },
                new TaskInfoModel() { Id = 7, Name = "List materials", StartDate = new DateTime(2021, 04, 01), Duration = "3", Progress = 30, ParentId = 5, TaskType="FixedWork", Work=48 },
                new TaskInfoModel() { Id = 8, Name = "Estimation approval", StartDate = new DateTime(2021, 04, 01), Duration = "2", ParentId = 5, Work=60, TaskType="FixedWork" },
                new TaskInfoModel() { Id = 9, Name = "Sign contract", StartDate = new DateTime(2021, 03, 31), EndDate = new DateTime(2021, 04, 01), Duration="1", TaskType="FixedWork", Work=24 },
            };
        }

        public static List<AssignmentModel> GetAssignmentCollection()
        {
            List<AssignmentModel> assignments = new List<AssignmentModel>()
            {
                new AssignmentModel(){ PrimaryId=1, TaskId = 2 , ResourceId=1, Unit=70},
                new AssignmentModel(){ PrimaryId=2, TaskId = 2 , ResourceId=6},
                new AssignmentModel(){ PrimaryId=3, TaskId = 3 , ResourceId=2},
                new AssignmentModel(){ PrimaryId=4, TaskId = 3 , ResourceId=3},
                new AssignmentModel(){ PrimaryId=5, TaskId = 3 , ResourceId=6},
                new AssignmentModel(){ PrimaryId=6, TaskId = 4 , ResourceId=8},
                new AssignmentModel(){ PrimaryId=7, TaskId = 4 , ResourceId=9},
                new AssignmentModel(){ PrimaryId=8, TaskId = 6 , ResourceId=4},
                new AssignmentModel(){ PrimaryId=9, TaskId = 7 , ResourceId=4},
                new AssignmentModel(){ PrimaryId=10, TaskId = 7 , ResourceId=8},
                new AssignmentModel(){ PrimaryId=11, TaskId = 8 , ResourceId=12},
                new AssignmentModel(){ PrimaryId=12, TaskId = 8 , ResourceId=5},
                new AssignmentModel(){ PrimaryId=13, TaskId = 9 , ResourceId=12},
                new AssignmentModel(){ PrimaryId=14, TaskId = 9 , ResourceId=5}
            };
            return assignments;
        }
    }
}