#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;

namespace BlazorDemos.Model
{
    public class GanttDataModel
    {
        public class ResourceInfoModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double MaxUnit { get; set; }
        }
        public class TaskInfoModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string TaskType { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public string Duration { get; set; }
            public int Progress { get; set; }
            public string Predecessor { get; set; }
            public int? ParentId { get; set; }
            public double? Work { get; set; }
            public DateTime? BaselineStartDate { get; set; }
            public DateTime? BaselineEndDate { get; set; }
            public string Status { get; set; } = string.Empty;
        }
        public class AssignmentModel
        {
            public int PrimaryId { get; set; }
            public int TaskId { get; set; }
            public int ResourceId { get; set; }
            public double Unit { get; set; }
        }
        public class MessageContent
        {
            public string role { get; set; } = string.Empty;
            public string content { get; set; } = string.Empty;
        }
        public static List<ResourceInfoModel> GetResources = new List<ResourceInfoModel>()
        {
            new ResourceInfoModel() { Id= 1, Name= "Martin Tamer" ,MaxUnit=100},
            new ResourceInfoModel() { Id= 2, Name= "Rose Fuller", MaxUnit= 100 },
            new ResourceInfoModel() { Id= 3, Name= "Margaret Buchanan" },
            new ResourceInfoModel() { Id= 4, Name= "Fuller King", MaxUnit = 100},
            new ResourceInfoModel() { Id= 5, Name= "Davolio Fuller", MaxUnit = 100 },
            new ResourceInfoModel() { Id= 6, Name= "Van Jack", MaxUnit = 100 },
            new ResourceInfoModel() { Id= 7, Name= "Fuller Buchanan", MaxUnit = 100 },
            new ResourceInfoModel() { Id= 8, Name= "Jack Davolio", MaxUnit = 100 },
            new ResourceInfoModel() { Id= 9, Name= "Tamer Vinet", MaxUnit = 100 },
            new ResourceInfoModel() { Id= 10, Name= "Vinet Fuller",MaxUnit = 100 },
            new ResourceInfoModel() { Id= 11, Name= "Bergs Anton",MaxUnit = 100 },
            new ResourceInfoModel() { Id= 12, Name= "Construction Supervisor",MaxUnit = 100 }
        };
        
        public static List<TaskInfoModel> GetTaskCollection()
        {
            return new List<TaskInfoModel>()
            {
                new TaskInfoModel() { Id = 1, Name = "Project initiation", StartDate = new DateTime(2021, 03, 28), EndDate = new DateTime(2021, 07, 28), TaskType ="FixedUnit", Work=128, Duration="4" },
                new TaskInfoModel() { Id = 2, Name = "Identify site location", StartDate = new DateTime(2021, 03, 29), Progress = 100, ParentId = 1, Duration="2", TaskType ="FixedUnit", Work=16 },
                new TaskInfoModel() { Id = 3, Name = "Perform soil test", StartDate = new DateTime(2021, 03, 29), ParentId = 1, Work=96, Duration="4", TaskType="FixedUnit" },
                new TaskInfoModel() { Id = 4, Name = "Soil test approval", StartDate = new DateTime(2021, 03, 29), Duration = "1", Progress = 100, ParentId = 1, Work=16, TaskType="FixedUnit" },
                new TaskInfoModel() { Id = 5, Name = "Project estimation", StartDate = new DateTime(2021, 03, 29), EndDate = new DateTime(2021, 04, 2), TaskType="FixedUnit", Duration="4" },
                new TaskInfoModel() { Id = 6, Name = "Develop floor plan for estimation", StartDate = new DateTime(2021, 03, 29), Duration = "3", Progress = 100, ParentId = 5, Work=30, TaskType="FixedUnit" },
                new TaskInfoModel() { Id = 7, Name = "List materials", StartDate = new DateTime(2021, 04, 01), Duration = "3", Progress = 30, ParentId = 5, TaskType="FixedUnit", Work=48 },
                new TaskInfoModel() { Id = 8, Name = "Estimation approval", StartDate = new DateTime(2021, 04, 01), Duration = "2", ParentId = 5, Work=60, TaskType="FixedUnit" },
                new TaskInfoModel() { Id = 9, Name = "Sign contract", StartDate = new DateTime(2021, 03, 31), EndDate = new DateTime(2021, 04, 01), Duration="3", TaskType="FixedUnit", Work=24 },
            };
        }
        public static List<TaskInfoModel> DataSourceCollection()
        {
            List<TaskInfoModel> Tasks = new List<TaskInfoModel>() {
                new TaskInfoModel() { Id = 1, Name = "Product concept", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 08), Duration = "5 days" },
                new TaskInfoModel() { Id = 2, Name = "Defining the product usage", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 08), Duration = "3", Progress = 30, ParentId = 1 },
                new TaskInfoModel() { Id = 3, Name = "Defining the target audience", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 04), Duration = "3", Progress = 40, ParentId = 1 },
                new TaskInfoModel() { Id = 4, Name = "Prepare product sketch and notes", StartDate = new DateTime(2021, 04, 05), EndDate = new DateTime(2021, 04, 08), Duration = "2", Progress = 30, ParentId = 1, Predecessor = "2" },
                new TaskInfoModel() { Id = 5, Name = "Concept approval", StartDate = new DateTime(2021, 04, 08), EndDate = new DateTime(2021, 04, 08), Duration = "0", Predecessor = "3,4" },
                new TaskInfoModel() { Id = 6, Name = "Market research", StartDate = new DateTime(2021, 04, 09), EndDate = new DateTime(2021, 04, 18), Predecessor = "2", Duration = "4", Progress = 30 },
                new TaskInfoModel() { Id = 7, Name = "Demand analysis", StartDate = new DateTime(2021, 04, 09), EndDate = new DateTime(2021, 04, 12), Duration = "4", Progress = 40, ParentId = 6 },
                new TaskInfoModel() { Id = 8, Name = "Customer strength", StartDate = new DateTime(2021, 04, 09), EndDate = new DateTime(2021, 04, 12), Duration = "4", Progress = 30, ParentId = 7, Predecessor = "5" },
                new TaskInfoModel() { Id = 9, Name = "Market opportunity analysis", StartDate = new DateTime(2021, 04, 09), EndDate = new DateTime(2021, 04, 12), Duration = "4", ParentId = 7, Predecessor = "5" },
                new TaskInfoModel() { Id = 10, Name = "Competitor analysis", StartDate = new DateTime(2021, 04, 15), EndDate = new DateTime(2021, 04, 18), Duration = "4", Progress = 30, ParentId = 6, Predecessor = "7,8" },
                new TaskInfoModel() { Id = 11, Name = "Product strength analysis", StartDate = new DateTime(2021, 04, 15), EndDate = new DateTime(2021, 04, 18), Duration = "4", Progress = 40, ParentId = 6, Predecessor = "9" },
                new TaskInfoModel() { Id = 12, Name = "Research completed", StartDate = new DateTime(2021, 04, 18), EndDate = new DateTime(2021, 04, 18), Duration = "0", Progress = 30, ParentId = 6, Predecessor = "10" },
                new TaskInfoModel() { Id = 13, Name = "Product design and development", StartDate = new DateTime(2021, 04, 19), EndDate = new DateTime(2021, 05, 16), Duration = "20", Predecessor = "6" },
                new TaskInfoModel() { Id = 14, Name = "Functionality design", StartDate = new DateTime(2021, 04, 19), EndDate = new DateTime(2021, 04, 23), Duration = "3", Progress = 30, ParentId = 13, Predecessor = "12" },
                new TaskInfoModel() { Id = 15, Name = "Quality design", StartDate = new DateTime(2021, 04, 19), EndDate = new DateTime(2021, 04, 23), Duration = "3", Progress = 40, ParentId = 13, Predecessor = "12" },
                new TaskInfoModel() { Id = 16, Name = "Define reliability", StartDate = new DateTime(2021, 04, 24), EndDate = new DateTime(2021, 04, 25), Duration = "2", Progress = 30, ParentId = 13, Predecessor = "15" },
                new TaskInfoModel() { Id = 17, Name = "Identifying raw materials", StartDate = new DateTime(2021, 04, 24), EndDate = new DateTime(2021, 04, 25), Duration = "2", ParentId = 13, Predecessor = "15" },
                new TaskInfoModel() { Id = 18, Name = "Define cost plan", StartDate = new DateTime(2021, 04, 26), EndDate = new DateTime(2021, 04, 29), Duration = "2", Progress = 30, ParentId = 13, Predecessor = "17" },
                new TaskInfoModel() { Id = 19, Name = "Manufacturing cost", StartDate = new DateTime(2021, 04, 26), EndDate = new DateTime(2021, 04, 29), Duration = "2", Progress = 40, ParentId = 18, Predecessor = "17" },
                new TaskInfoModel() { Id = 20, Name = "Selling cost", StartDate = new DateTime(2021, 04, 26), EndDate = new DateTime(2021, 04, 29), Duration = "2", Progress = 30, ParentId = 18, Predecessor = "17" },
                new TaskInfoModel() { Id = 21, Name = "Development of final design", StartDate = new DateTime(2021, 04, 30), EndDate = new DateTime(2021, 05, 08), Duration = "7", ParentId = 13 },
                new TaskInfoModel() { Id = 22, Name = "Develop dimensions and design", StartDate = new DateTime(2021, 04, 30), EndDate = new DateTime(2021, 05, 01), Duration = "2", Progress = 30, ParentId = 21, Predecessor = "19,20" },
                new TaskInfoModel() { Id = 23, Name = "Develop designs to meet industry", StartDate = new DateTime(2021, 05, 02), EndDate = new DateTime(2021, 05, 03), Duration = "2", Progress = 40, ParentId = 21, Predecessor = "22" },
                new TaskInfoModel() { Id = 24, Name = "Include all the details", StartDate = new DateTime(2021, 05, 06), EndDate = new DateTime(2021, 05, 08), Duration = "3", Progress = 30, ParentId = 21, Predecessor = "23" },
                new TaskInfoModel() { Id = 25, Name = "CAD - Computer Aided Design", StartDate = new DateTime(2021, 05, 09), EndDate = new DateTime(2021, 05, 13), Duration = "3", Predecessor = "24" },
                new TaskInfoModel() { Id = 26, Name = "CAM - Computer Aided Manufacturing", StartDate = new DateTime(2021, 05, 14), EndDate = new DateTime(2021, 05, 16), Duration = "3", Progress = 30, Predecessor = "25" },
                new TaskInfoModel() { Id = 27, Name = "Finalize the design", StartDate = new DateTime(2021, 04, 16), EndDate = new DateTime(2021, 04, 16), Duration = "0", Progress = 40, Predecessor = "26" },
                new TaskInfoModel() { Id = 28, Name = "Prototype testing", StartDate = new DateTime(2021, 05, 17), EndDate = new DateTime(2021, 05, 22), Duration = "4", Progress = 30, Predecessor = "27" },
                new TaskInfoModel() { Id = 29, Name = "Include feedback", StartDate = new DateTime(2021, 05, 18), EndDate = new DateTime(2021, 05, 22), Duration = "2", Progress = 40, ParentId = 28, Predecessor = "27" },
                new TaskInfoModel() { Id = 30, Name = "Manufacturing", StartDate = new DateTime(2021, 05, 23), EndDate = new DateTime(2021, 05, 29), Duration = "7", Predecessor = "28" },
                new TaskInfoModel() { Id = 31, Name = "Assembling materials to finsihed goods", StartDate = new DateTime(2021, 05, 23), EndDate = new DateTime(2021, 05, 26), Duration = "3", Progress = 30, ParentId = 30 },
                new TaskInfoModel() { Id = 32, Name = "Feedback on testing", StartDate = new DateTime(2021, 05, 24), EndDate = new DateTime(2021, 05, 26), Duration = "3", Progress = 40, ParentId = 30 },
                new TaskInfoModel() { Id = 33, Name = "Product packing and shipping", StartDate = new DateTime(2021, 05, 27), EndDate = new DateTime(2021, 05, 29), Duration = "3", Progress = 30, ParentId = 30 },
                new TaskInfoModel() { Id = 34, Name = "Feedback analysis", StartDate = new DateTime(2021, 05, 30), EndDate = new DateTime(2021, 06, 01), Duration = "3", Predecessor = "30" },
                new TaskInfoModel() { Id = 35, Name = "Final review", StartDate = new DateTime(2021, 06, 02), EndDate = new DateTime(2021, 06, 05), Duration = "3", Progress = 20, Predecessor = "34" },
                new TaskInfoModel() { Id = 36, Name = "Implement changes", StartDate = new DateTime(2021, 06, 06), EndDate = new DateTime(2021, 06, 10), Duration = "4", Progress = 50, Predecessor = "35" },
                new TaskInfoModel() { Id = 37, Name = "Final approval", StartDate = new DateTime(2021, 06, 11), EndDate = new DateTime(2021, 06, 12), Duration = "2", Progress = 80, Predecessor = "36" },
                new TaskInfoModel() { Id = 38, Name = "Product launch", StartDate = new DateTime(2021, 06, 13), EndDate = new DateTime(2021, 06, 14), Duration = "2", Progress = 90, Predecessor = "37" },
                new TaskInfoModel() { Id = 39, Name = "Post-launch review", StartDate = new DateTime(2021, 06, 15), EndDate = new DateTime(2021, 06, 18), Duration = "4", Predecessor = "38" },
                new TaskInfoModel() { Id = 40, Name = "Project closure", StartDate = new DateTime(2021, 06, 19), EndDate = new DateTime(2021, 06, 20), Duration = "2", Progress = 100, Predecessor = "39" }
            };
            return Tasks;
        }
        public static List<TaskInfoModel> GetBaselineCollection()
        {
            List<TaskInfoModel> Tasks = new List<TaskInfoModel>() {
                new TaskInfoModel() { Id = 1, Name = "Project initiation", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 06) },
                new TaskInfoModel() { Id = 2, Name = "Identify site location", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 02), Duration = "1", BaselineStartDate = new DateTime(2021, 04, 02), BaselineEndDate = new DateTime(2021, 04, 02), Progress = 30, ParentId = 1 },
                new TaskInfoModel() { Id = 3, Name = "Perform soil test", StartDate = new DateTime(2021, 04, 02), Duration = "5", Progress = 40, BaselineStartDate = new DateTime(2021, 04, 02), BaselineEndDate = new DateTime(2021, 04, 10), ParentId = 1 },
                new TaskInfoModel() { Id = 4, Name = "Soil test approval", StartDate = new DateTime(2021, 04, 08), Duration = "2", EndDate = new DateTime(2021, 04, 09), BaselineStartDate = new DateTime(2021, 04, 08), BaselineEndDate = new DateTime(2021, 04, 12), Progress = 30, ParentId = 1 },
                new TaskInfoModel() { Id = 5, Name = "Project initiation", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 08) },
                new TaskInfoModel() { Id = 6, Name = "Identify site location", StartDate = new DateTime(2021, 04, 02), Duration = "6", Progress = 30, ParentId = 5, BaselineStartDate = new DateTime(2021, 04, 02), BaselineEndDate = new DateTime(2021, 04, 09) },
                new TaskInfoModel() { Id = 7, Name = "Perform soil test", StartDate = new DateTime(2021, 04, 02), Duration = "4", Progress = 40, ParentId = 5, BaselineStartDate = new DateTime(2021, 04, 02), BaselineEndDate = new DateTime(2021, 04, 07) },
                new TaskInfoModel() { Id = 8, Name = "Soil test approval", Status="Critical", StartDate = new DateTime(2021, 04, 02), Duration = "5", Progress = 30, ParentId = 5, BaselineStartDate = new DateTime(2021, 04, 02), BaselineEndDate = new DateTime(2021, 04, 04) },
                new TaskInfoModel() { Id = 9, Name = "Market opportunity analysis", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 06) },
                new TaskInfoModel() { Id = 10, Name = "Competitor analysis", Status="Critical", StartDate = new DateTime(2021, 04, 02), EndDate = new DateTime(2021, 04, 02), Duration = "3", BaselineStartDate = new DateTime(2021, 04, 02), BaselineEndDate = new DateTime(2021, 04, 05), Progress = 30, ParentId = 9 },
                new TaskInfoModel() { Id = 11, Name = "Product strength analysis", Status="Critical", StartDate = new DateTime(2021, 04, 02), Duration = "5", Progress = 40, BaselineStartDate = new DateTime(2021, 04, 02), BaselineEndDate = new DateTime(2021, 04, 06), ParentId = 9 },
                new TaskInfoModel() { Id = 12, Name = "Research completed", StartDate = new DateTime(2021, 04, 08), Duration = "10", EndDate = new DateTime(2021, 04, 08), Progress = 30, ParentId = 9 },
                new TaskInfoModel() { Id = 13, Name = "Product design and development", StartDate = new DateTime(2021, 04, 02), Duration = "5", Progress = 40, BaselineStartDate = new DateTime(2021, 04, 02), BaselineEndDate = new DateTime(2021, 04, 08), ParentId = 9 }
            };
            return Tasks;
        }

        public static List<TaskInfoModel> HistoricalTaskData => new()
        {
            new TaskInfoModel { Id = 1, Name = "Requirement Analysis", StartDate = new DateTime(2026, 1, 10), EndDate = new DateTime(2026, 1, 15), Duration = "5", Progress = 100, ParentId = null },
            new TaskInfoModel { Id = 2, Name = "UI/UX Design", StartDate = new DateTime(2026, 1, 15), EndDate = new DateTime(2026, 1, 17), Duration = "2", Progress = 0, ParentId = null },
            new TaskInfoModel { Id = 3, Name = "Backend Development", StartDate = new DateTime(2026, 1, 20), EndDate = new DateTime(2026, 1, 23), Duration = "3", Progress = 50, ParentId = null },
            new TaskInfoModel { Id = 4, Name = "Database Schema Design", StartDate = new DateTime(2026, 1, 18), EndDate = new DateTime(2026, 1, 24), Duration = "6", Progress = 0, ParentId = null },
            new TaskInfoModel { Id = 5, Name = "Frontend Development", StartDate = new DateTime(2026, 1, 22), EndDate = new DateTime(2026, 1, 27), Duration = "5", Progress = 80, ParentId = null },
            new TaskInfoModel { Id = 6, Name = "Testing Phase", StartDate = new DateTime(2026, 1, 25), EndDate = new DateTime(2026, 1, 30), Duration = "6", Progress = 20, ParentId = null },
            new TaskInfoModel { Id = 7, Name = "Deployment Preparation", StartDate = new DateTime(2026, 1, 28), EndDate = new DateTime(2026, 2, 5), Duration = "9", Progress = 10, ParentId = null },
            new TaskInfoModel { Id = 8, Name = "User Documentation", StartDate = new DateTime(2026, 2, 1), EndDate = new DateTime(2026, 2, 10), Duration = "10", Progress = 30, ParentId = null },
            new TaskInfoModel { Id = 9, Name = "Security Audit", StartDate = new DateTime(2026, 2, 5), EndDate = new DateTime(2026, 2, 15), Duration = "11", Progress = 40, ParentId = null },
            new TaskInfoModel { Id = 10, Name = "Performance Optimization", StartDate = new DateTime(2026, 2, 10), EndDate = new DateTime(2026, 2, 20), Duration = "11", Progress = 60, ParentId = null },
            new TaskInfoModel { Id = 11, Name = "Beta Testing", StartDate = new DateTime(2026, 2, 15), EndDate = new DateTime(2026, 2, 25), Duration = "11", Progress = 70, ParentId = null },
            new TaskInfoModel { Id = 12, Name = "Bug Fixing", StartDate = new DateTime(2026, 2, 20), EndDate = new DateTime(2026, 3, 5), Duration = "14", Progress = 80, ParentId = null }
        };

        public static List<AssignmentModel> GetAssignmentCollection()
        {
            List<AssignmentModel> assignments = new List<AssignmentModel>()
            {
                new AssignmentModel(){ PrimaryId=1, TaskId = 2, ResourceId=1, Unit=100},
                new AssignmentModel(){ PrimaryId=2, TaskId = 3, ResourceId=1, Unit=50},
                new AssignmentModel(){ PrimaryId=3, TaskId = 4, ResourceId=3, Unit=40},
                new AssignmentModel(){ PrimaryId=4, TaskId = 6, ResourceId=3, Unit = 100},
                new AssignmentModel(){ PrimaryId=5, TaskId = 7, ResourceId=8, Unit = 100},
                new AssignmentModel(){ PrimaryId=6, TaskId = 8, ResourceId=5, Unit = 70},
                new AssignmentModel(){ PrimaryId=7, TaskId = 9, ResourceId=5, Unit = 60}
            };
            return assignments;
        }

        public static List<AssignmentModel> ResourceAssignmentCollection()
        {
            List<AssignmentModel> assignments = new List<AssignmentModel>()
            {
                new AssignmentModel(){ PrimaryId=1, TaskId = 2, ResourceId=1},
                new AssignmentModel(){ PrimaryId=2, TaskId = 3, ResourceId=1},
                new AssignmentModel(){ PrimaryId=3, TaskId = 4, ResourceId=3},
                new AssignmentModel(){ PrimaryId=4, TaskId = 6, ResourceId=3},
                new AssignmentModel(){ PrimaryId=5, TaskId = 7, ResourceId=8},
                new AssignmentModel(){ PrimaryId=6, TaskId = 8, ResourceId=5},
                new AssignmentModel(){ PrimaryId=7, TaskId = 10, ResourceId=2},
                new AssignmentModel(){ PrimaryId=8, TaskId = 11, ResourceId=2},
            };
            return assignments;
        }

        public static List<TaskInfoModel> TaskDataCollection => new()
        {
            new TaskInfoModel() { Id = 1, Name = "Product concept", StartDate = new DateTime(2026, 04, 02), EndDate = new DateTime(2026, 04, 08), Duration = "5 days" },
            new TaskInfoModel() { Id = 2, Name = "Defining the product usage", StartDate = new DateTime(2026, 04, 02), EndDate = new DateTime(2026, 04, 08), Duration = "3", Progress = 30, ParentId = 1 },
            new TaskInfoModel() { Id = 3, Name = "Defining the target audience", StartDate = new DateTime(2026, 04, 02), EndDate = new DateTime(2026, 04, 04), Duration = "3", Progress = 40, ParentId = 1 },
            new TaskInfoModel() { Id = 4, Name = "Prepare product sketch and notes", StartDate = new DateTime(2026, 04, 05), EndDate = new DateTime(2026, 04, 08), Duration = "2", Progress = 30, ParentId = 1, Predecessor = "2" },
            new TaskInfoModel() { Id = 5, Name = "Concept approval", StartDate = new DateTime(2026, 04, 08), EndDate = new DateTime(2026, 04, 08), Duration = "0", Predecessor = "3,4", ParentId=1 },
            new TaskInfoModel() { Id = 6, Name = "Market research", StartDate = new DateTime(2026, 04, 09), EndDate = new DateTime(2026, 04, 18), Predecessor = "2", Duration = "4", Progress = 30 },
            new TaskInfoModel() { Id = 7, Name = "Demand analysis", StartDate = new DateTime(2026, 04, 09), EndDate = new DateTime(2026, 04, 12), Duration = "4", Progress = 40, ParentId = 6 },
            new TaskInfoModel() { Id = 8, Name = "Customer strength", StartDate = new DateTime(2026, 04, 09), EndDate = new DateTime(2026, 04, 12), Duration = "4", Progress = 30, ParentId = 7, Predecessor = "5" },
            new TaskInfoModel() { Id = 9, Name = "Market opportunity analysis", StartDate = new DateTime(2026, 04, 09), EndDate = new DateTime(2026, 04, 12), Duration = "4", ParentId = 7, Predecessor = "5" },
            new TaskInfoModel() { Id = 10, Name = "Competitor analysis", StartDate = new DateTime(2026, 04, 15), EndDate = new DateTime(2026, 04, 18), Duration = "4", Progress = 30, ParentId = 6, Predecessor = "7,8" }
        };
    }
}
