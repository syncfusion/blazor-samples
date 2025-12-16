#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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

namespace BlazorDemos.Pages.GanttChart.Data
{
    public class ResourceViewData
    {
        public class TaskData
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public DateTime StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public string? Duration { get; set; }
            public int Progress { get; set; }
            public int? ParentId { get; set; }
            public string Predecessor { get; set; } = string.Empty;
            public string Notes { get; set; } = string.Empty;
            public double? Work { get; set; }
            public string TaskType { get; set; } = string.Empty;
            public DateTime BaselineStartDate { get; set; }
            public DateTime BaselineEndDate { get; set; }
            public string? Details { get; set; }
        }
        public class ResourceInfoModel
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public double MaxUnit { get; set; }
            public string? Group { get; set; }
        }
        public class AssignmentModel
        {
            public int Id { get; set; }
            public int TaskId { get; set; }
            public int ResourceId { get; set; }
            public double? Unit { get; set; }
        }
        public static List<ResourceInfoModel> GetResources = new List<ResourceInfoModel>()
        {
            new ResourceInfoModel() { Id= 1, Name= "Martin Tamer", Group="Planning Team"},
            new ResourceInfoModel() { Id= 2, Name= "Rose Fuller", Group="Testing Team" },
            new ResourceInfoModel() { Id= 3, Name= "Margaret Buchanan", Group="Approval Team" },
            new ResourceInfoModel() { Id= 4, Name= "Fuller King", Group="Development Team" },
            new ResourceInfoModel() { Id= 5, Name= "Davolio Fuller", Group="Approval Team" },
            new ResourceInfoModel() { Id= 6, Name= "Fuller Buchanan", Group="Development Team" },
            new ResourceInfoModel() { Id= 7, Name= "Jack Davolio", Group="Planning Team" },
            new ResourceInfoModel() { Id= 8, Name= "Tamer Vinet", Group="Testing Team" },
            new ResourceInfoModel() { Id= 9, Name= "Vinet Fuller", Group="Development Team" },
            new ResourceInfoModel() { Id= 10, Name= "Bergs Anton", Group="Testing Team" },
            new ResourceInfoModel() { Id= 11, Name= "Construction Supervisor", Group="Testing Team" },
        };

        /// <summary>
        /// Returns a list of predefined tasks for the resource view sample.
        /// </summary>
        public static List<TaskData> GetTaskCollection()
        {
            List<TaskData> Tasks = new List<TaskData>() {
                new TaskData() { Id = 1, Name = "Project initiation", StartDate = new DateTime(2022, 03, 28), EndDate = new DateTime(2022, 07, 28), TaskType ="FixedDuration", Work=128, Duration="4" },
                new TaskData() { Id = 2, Name = "Identify Site location", StartDate = new DateTime(2022, 03, 29), BaselineStartDate = new DateTime(2022, 03, 29), BaselineEndDate= new DateTime(2022, 03, 31),  Progress = 30, ParentId = 1, Duration="5", Work=16 },
                new TaskData() { Id = 3, Name = "Site analyze", StartDate = new DateTime(2022, 03, 29), BaselineStartDate = new DateTime(2022, 03, 29), BaselineEndDate= new DateTime(2022, 03, 31),  Progress = 50, ParentId = 1, Duration="5", Work=16 },
                new TaskData() { Id = 4, Name = "Perform soil test", StartDate = new DateTime(2022, 03, 29), ParentId = 1, Work=96, Duration="6", TaskType="FixedWork", Predecessor="2FS", Progress=40 },
                new TaskData() { Id = 5, Name = "Soil test approval", StartDate = new DateTime(2022, 03, 29), BaselineStartDate= new DateTime(2022, 03, 29), BaselineEndDate= new DateTime(2022, 03, 31), Duration="4", Progress = 30, ParentId = 1, Work=16, TaskType="FixedWork" },
                new TaskData() { Id = 6, Name = "Project estimation", StartDate = new DateTime(2022, 03, 29), EndDate = new DateTime(2022, 04, 2), TaskType="FixedDuration", Duration="7", Progress=40, Work=50 },
                new TaskData() { Id = 7, Name = "Develop floor plan for estimation", StartDate = new DateTime(2022, 03, 29), Duration = "9", Progress = 30, ParentId = 5, Work=30, TaskType="FixedDuration",  Predecessor= "4FS" },
                new TaskData() { Id = 8, Name = "List materials", StartDate = new DateTime(2022, 04, 01), Duration = "6", Progress = 30, ParentId = 5, TaskType="FixedWork", Work=48 },
                new TaskData() { Id = 9, Name = "Estimation approval",Progress=30, StartDate = new DateTime(2022, 04, 01), Duration = "8", ParentId = 5, BaselineStartDate= new DateTime(2022, 03, 29), BaselineEndDate= new DateTime(2022, 03, 31), Work=60, TaskType="FixedUnit", Predecessor="8FS" },
                new TaskData() { Id = 10, Name = "Building approval", StartDate = new DateTime(2022, 04, 01), Duration = "4", ParentId = 5, Work=60, Progress=50, TaskType="FixedWork", },
                new TaskData() { Id = 11, Name = "Construction initiation", StartDate = new DateTime(2022, 04, 01), Duration = "5", ParentId = 5, Work=60,Progress=40, TaskType="FixedDuration" },
                new TaskData() { Id = 12, Name = "Ground floor initiation", StartDate = new DateTime(2022, 04, 05), Duration = "5", ParentId = 11, Work=60,Progress=40, TaskType="FixedDuration"},
                new TaskData() { Id = 13, Name = "First floor initiation", StartDate = new DateTime(2022, 04, 01), Duration = "5", ParentId = 11, Work=60,Progress=40, TaskType="FixedDuration" },
                new TaskData() { Id = 14, Name = "Electric work initiation", StartDate = new DateTime(2022, 04, 01), Duration = "5", ParentId = 11, Work=60,Progress=40, TaskType="FixedDuration"},
                new TaskData() { Id = 15, Name = "Plumbing work", StartDate = new DateTime(2022, 04, 02), Duration = "5", ParentId = 11, Work=60,Progress=40, TaskType="FixedDuration" },
                new TaskData() { Id = 16, Name = "Interior work", StartDate = new DateTime(2022, 04, 01), Duration = "5", ParentId = 11, Work=60,Progress=40, TaskType="FixedDuration" },
                new TaskData() { Id = 17, Name = "Wiring test", StartDate = new DateTime(2022, 04, 04), Duration = "5", ParentId = 11, Work=60,Progress=40, TaskType="FixedDuration"},
                new TaskData() { Id = 18, Name = "Tile test", StartDate = new DateTime(2022, 04, 06), Duration = "5", ParentId = 11, Work=60,Progress=100, TaskType="FixedDuration"},
                new TaskData() { Id = 19, Name = "Tile work initation", StartDate = new DateTime(2022, 04, 09), Duration = "5", ParentId = 11, Work=60,Progress=40, TaskType="FixedDuration"},
                new TaskData() { Id = 20, Name = "Building test", StartDate = new DateTime(2022, 04, 01), Duration = "4", ParentId = 5, Work=60, Progress=50, TaskType="FixedWork", },

            };
            return Tasks;
        }

        /// <summary>
        /// Returns a list of predefined resource assignments.
        /// </summary>
        public static List<AssignmentModel> GetAssignmentCollection()
        {
            List<AssignmentModel> assignments = new List<AssignmentModel>()
            {
                new AssignmentModel(){ Id=1, TaskId = 2 , ResourceId=1, Unit=70},
                new AssignmentModel(){ Id=2, TaskId = 3 , ResourceId=1, Unit=70},
                new AssignmentModel(){ Id=3, TaskId = 4 , ResourceId=3},
                new AssignmentModel(){ Id=4, TaskId = 5 , ResourceId=8},
                new AssignmentModel(){ Id=5, TaskId = 6 , ResourceId=2},
                new AssignmentModel(){ Id=6, TaskId = 7 , ResourceId=4, Unit=30},
                new AssignmentModel(){ Id=7, TaskId = 8 , ResourceId=8},
                new AssignmentModel(){ Id=8, TaskId = 9 , ResourceId=11},
                new AssignmentModel(){ Id=9, TaskId = 12 , ResourceId=2},
                new AssignmentModel(){ Id=10, TaskId = 13 , ResourceId=6},
                new AssignmentModel(){ Id=11, TaskId = 14 , ResourceId=7},
                new AssignmentModel(){ Id=12, TaskId = 15 , ResourceId=9},
                new AssignmentModel(){ Id=13, TaskId = 16 , ResourceId=10},
                new AssignmentModel(){ Id=14, TaskId = 17 , ResourceId=7},
                new AssignmentModel(){ Id=15, TaskId = 18 , ResourceId=5},
                new AssignmentModel(){ Id=16, TaskId = 19 , ResourceId=5}
            };
            return assignments;
        }
    }
}
