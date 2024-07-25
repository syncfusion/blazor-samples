#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

namespace Overview.Pages
{
    public class OverviewData
    {
        public class TaskData
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public DateTime? DueDate { get; set; }
            public double? TimeLog { get; set; }
            public string Work { get; set; }
            public string Manager { get; set; }
            public int Progress { get; set; }
            public string Predecessor { get; set; }
            public string EmptyPredecessor { get; set; }
            public double StoryPoints { get; set; }
            public string Status { get; set; }
            public int? ParentId { get; set; }
            public string Priority { get; set; }
            public string Component { get; set; }
        }
        public class ResourceInfoModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double MaxUnit { get; set; }

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
            new ResourceInfoModel() { Id= 1, Name= "Martin Tamer" ,},
            new ResourceInfoModel() { Id= 2, Name= "Rose Fuller" },
            new ResourceInfoModel() { Id= 3, Name= "Margaret Buchanan" },
            new ResourceInfoModel() { Id= 4, Name= "Fuller King" },
            new ResourceInfoModel() { Id= 5, Name= "Van Jack" },
            new ResourceInfoModel() { Id= 6, Name= "Jack Davolio" }, 
        };
        public static List<TaskData> DataCollection()
        {
            List<TaskData> Tasks = new List<TaskData>()
            {
                new TaskData(){ TaskId = 1, TaskName="Q-1 Release", StartDate=new DateTime(2021,12,20), EndDate=new DateTime(2022,04,4), Manager="", DueDate= new DateTime(2022,04,4), TimeLog=2, Work="2", Progress=80, Status="In Progress", },
                new TaskData(){ TaskId = 2, TaskName="Roadmap", ParentId=1, },
                new TaskData(){ TaskId = 3, TaskName="Implementation", ParentId=2, },
                new TaskData(){ TaskId = 4, TaskName="Grid", StartDate=new DateTime(2021,12,20), EndDate=new DateTime(2022,2,20), DueDate=new DateTime(2022,04,4), TimeLog=44, Work="45", Progress=70, ParentId=3, },
                new TaskData(){ TaskId = 5, TaskName="Batch Editing", StartDate=new DateTime(2021,12,24), EndDate=new DateTime(2022,2,21), Manager="", DueDate=new DateTime(2022,2,17), TimeLog=42, Work="43", Progress=100, Status="Completed", ParentId=4, Priority="High", Component="Grid", },
                new TaskData(){ TaskId = 6, TaskName="PDF Export", StartDate=new DateTime(2021,12,28), EndDate=new DateTime(2022,2,25), Manager="", DueDate=new DateTime(2022,2,17), TimeLog=42, Work="45", Progress=10, Status="On Hold", ParentId=4, Priority="Normal", Component="Grid", },
                new TaskData(){ TaskId = 7, TaskName="Tree Grid", StartDate=new DateTime(2022,1,2), EndDate=new DateTime(2022,2,20), DueDate=new DateTime(2022,2,20), TimeLog=33, Work="30", Progress=80, ParentId=3, },
                new TaskData(){ TaskId = 8, TaskName="Drag Multi-selection", StartDate=new DateTime(2022,1,2), EndDate=new DateTime(2022,2,20), Manager="", DueDate=new DateTime(2022,2,20), TimeLog=33, Work="32", Progress=100, Status="Completed", ParentId=7, Priority="Critical", Component="Tree Grid", },
                new TaskData(){ TaskId = 9, TaskName="Gantt Chart", StartDate=new DateTime(2022,2,20), EndDate=new DateTime(2022,4,28), DueDate=DateTime.Now, TimeLog=2, Work="2", Progress=100, ParentId=3, },
                new TaskData(){ TaskId = 10, TaskName="Initial loading performance", StartDate=new DateTime(2022,2,24), EndDate=new DateTime(2022,3,14), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=13, Work="15", Progress=35, Status="In Progress", ParentId=9, Priority="Low", Component="Gantt Chart", },
                new TaskData(){ TaskId = 11, TaskName="Drag Multi-selection", StartDate=new DateTime(2022,2,22), EndDate=new DateTime(2022,3,14), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=13, Work="14", Progress=100, Predecessor="8FS", Status="Completed", ParentId=9, Priority="Normal", Component="Gantt Chart", },
                new TaskData(){ TaskId = 12, TaskName="ScrollToViewAsync Method", StartDate=new DateTime(2022,2,20), EndDate=new DateTime(2022,3,10), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=13, Work="10", Progress=100, Status="Completed", ParentId=9, Priority="High", Component="Gantt Chart", },
                new TaskData(){ TaskId = 13, TaskName="ScrollToTimelineAsync Method", StartDate=new DateTime(2022,2,20), EndDate=new DateTime(2022,3,10), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=13, Work="10", Progress=40, Status="On Hold", ParentId=9, Priority="Normal", Component="Gantt Chart", },
                new TaskData(){ TaskId = 14, TaskName="ScrollToTaskbarAsync Method", StartDate=new DateTime(2022,3,10), EndDate=new DateTime(2022,3,25), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=11, Work="15", Progress=100, Status="Completed", ParentId=9, Priority="Critical", Component="Gantt Chart", },
                new TaskData(){ TaskId = 15, TaskName="Web Accessibility", StartDate=new DateTime(2022,3,10), EndDate=new DateTime(2022,3,25), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=11, Work="12", Progress=35, Status="On Hold", ParentId=9, Priority="Normal", Component="Gantt Chart", },
                new TaskData(){ TaskName="Feature Completion", StartDate=new DateTime(2022,3,25), TimeLog=0, ParentId=3, },
                new TaskData(){ TaskId = 16, TaskName="Testing", Work="8", ParentId=3, },
                new TaskData(){ TaskId = 17, TaskName="Phase-1", StartDate=new DateTime(2022,3,20), EndDate=new DateTime(2022,3,24), Work="2", Progress=0, ParentId=16, },
                new TaskData(){ TaskId = 18, TaskName="Phase-2", StartDate=new DateTime(2022,3,22), EndDate=new DateTime(2022,3,26), Work="1", Progress=0, Predecessor="17FS", ParentId=16, },
                new TaskData(){ TaskId = 19, TaskName="Testing Completion", StartDate=new DateTime(2022,3,27), TimeLog=0, ParentId=3, },
                new TaskData(){ TaskId = 20, TaskName="Release Roll-out", StartDate=new DateTime(2022,04,4), TimeLog=0, ParentId=2, },
                new TaskData(){ TaskId = 21, TaskName="Q-2 Release", StartDate=new DateTime(2022,04,5), EndDate=new DateTime(2022,06,30), Manager="", DueDate=new DateTime(2022,06,30), TimeLog=2, Work="2", Progress=90, Status="Completed", },
                new TaskData(){ TaskId = 22, TaskName="Roadmap", ParentId=21, },
                new TaskData(){ TaskId = 23, TaskName="Implementation", ParentId=22, },
                new TaskData(){ TaskId = 24, TaskName="Grid", StartDate=new DateTime(2022,04,5), EndDate=new DateTime(2022,05,30), DueDate=DateTime.Now, TimeLog=2, Work="2", Progress=100, ParentId=23, },
                new TaskData(){ TaskId = 25, TaskName="Web Accessibility", StartDate=new DateTime(2022,04,5), EndDate=new DateTime(2022,04,30), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=19, Work="15", Progress=100, Status="Completed", ParentId=24, Priority="High", Component="Grid", },
                new TaskData(){ TaskId = 26, TaskName="Sticky Header", StartDate=new DateTime(2022,04,15), EndDate=new DateTime(2022,05,10), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=19, Work="20", Progress=100, Status="Completed", ParentId=24, Priority="Normal", Component="Grid", },
                new TaskData(){ TaskId = 27, TaskName="Adapative UI Mode", StartDate=new DateTime(2022,04,20), EndDate=new DateTime(2022,05,20), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=19, Work="25", Progress=100, Status="Completed", ParentId=24, Priority="Normal", Component="Grid", },
                new TaskData(){ TaskId = 28, TaskName="Tree Grid", StartDate=new DateTime(2022,04,25), EndDate=new DateTime(2022,5,30), DueDate=DateTime.Now, TimeLog=2, Work="2", Progress=50, ParentId=23, },
                new TaskData(){ TaskId = 29, TaskName="CRUD Opreation for virtualization", StartDate=new DateTime(2022,04,25), EndDate=new DateTime(2022,05,30), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=26, Work="28", Progress=72, Status="In Progress", ParentId=28, Priority="Normal", Component="Tree Grid", },
                new TaskData(){ TaskId = 30, TaskName="Frozen Column", StartDate=new DateTime(2022,04,28), EndDate=new DateTime(2022,05,30), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=26, Work="28", Progress=100, Status="Completed", ParentId=28, Priority="High", Component="Tree Grid", },
                new TaskData(){ TaskId = 31, TaskName="Gantt Chart", StartDate=new DateTime(2022,05,5), EndDate=new DateTime(2022,6,20), DueDate=DateTime.Now, TimeLog=2, Work="2", Progress=50, ParentId=23, },
                new TaskData(){ TaskId = 32, TaskName="Observable Collection", StartDate=new DateTime(2022,05,15), EndDate=new DateTime(2022,06,10), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=19, Work="15", Progress=70, Status="On Hold", ParentId=31, Priority="Critical", Component="Gantt Chart", },
                new TaskData(){ TaskId = 33, TaskName="INotifyPropertyChanged", StartDate=new DateTime(2022,05,18), EndDate=new DateTime(2022,05,30), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=19, Work="18", Progress=20, Status="On Hold", ParentId=31, Priority="Normal", Component="Gantt Chart", },
                new TaskData(){ TaskId = 34, TaskName="INotifyPropertyChanged", StartDate=new DateTime(2022,05,25), EndDate=new DateTime(2022,06,15), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=19, Work="25", Progress=50, Status="In Progress", ParentId=31, Priority="Normal", Component="Gantt Chart", },
                new TaskData(){ TaskId = 35, TaskName="Customized Taskbar Editing", StartDate=new DateTime(2022,05,25), EndDate=new DateTime(2022,06,30), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=15, Work="20", Progress=10, Status="On Hold", ParentId=31, Priority="High", Component="Gantt Chart", },
                new TaskData(){ TaskId = 36, TaskName="Column Virtualization ", StartDate=new DateTime(2022,05,5), EndDate=new DateTime(2022,05,30), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=18, Work="22", Progress=100, Status="Completed", ParentId=31, Priority="Critical", Component="Gantt Chart", },
                new TaskData(){ TaskId = 37, TaskName="Touch Interaction ", StartDate=new DateTime(2022,05,27), EndDate=new DateTime(2022,6,17), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=18, Work="14", Progress=100, Status="Completed", ParentId=31, Priority="Normal", Component="Gantt Chart", },
                new TaskData(){ TaskId = 38, TaskName="Editing Tooltip Template", StartDate=new DateTime(2022,05,29), EndDate=new DateTime(2022,6,19), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=18, Work="20", Progress=100, Status="Completed", ParentId=31, Priority="Low", Component="Gantt Chart", },
                new TaskData(){ TaskId = 39, TaskName="Predecessor Drag Vertical Auto Scroll", StartDate=new DateTime(2022,05,25), EndDate=new DateTime(2022,6,15), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=18, Work="15", Progress=100, Status="Completed", ParentId=31, Priority="Normal", Component="Gantt Chart", },
                new TaskData(){ TaskId = 40, TaskName="Taskbar Drag Horizontal Auto Scroll", StartDate=new DateTime(2022,05,27), EndDate=new DateTime(2022,6,17), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=18, Work="14", Progress=100, Status="Completed", ParentId=31, Priority="Normal", Component="Gantt Chart", },
                new TaskData(){ TaskId = 41, TaskName="Predecessor Types Configure", StartDate=new DateTime(2022,05,28), EndDate=new DateTime(2022,6,18), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=18, Work="15", Progress=70, Status="On Hold", ParentId=31, Priority="Low", Component="Gantt Chart", },
                new TaskData(){ TaskId = 42, TaskName="Based on content height holiday, event markers, and weekend container rendering", StartDate=new DateTime(2022,05,28), EndDate=new DateTime(2022,6,15), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=18, Work="17", Progress=60, Status="In Progress", ParentId=31, Priority="Normal", Component="Gantt Chart", },
                new TaskData(){ TaskId = 43, TaskName="Feature Completion", StartDate=new DateTime(2022,6,15), TimeLog=0, ParentId=23, },
                new TaskData(){ TaskId = 44, TaskName="Testing", Work="8", ParentId=23, },
                new TaskData(){ TaskId = 45, TaskName="Phase-1", StartDate=new DateTime(2022,6,15), EndDate=new DateTime(2022,6,20), Work="3", Progress=0, ParentId=44, },
                new TaskData(){ TaskId = 46, TaskName="Phase-2", StartDate=new DateTime(2022,6,18), EndDate=new DateTime(2022,6,23), Work="2", Predecessor="45FS", Progress=0, ParentId=44, },
                new TaskData(){ TaskId = 47, TaskName="Testing Completion", StartDate=new DateTime(2022,6,24), TimeLog=0, ParentId=24, },
                new TaskData(){ TaskId = 48, TaskName="Release Roll-out", StartDate=new DateTime(2022,06,30), TimeLog=0, ParentId=22, },
                new TaskData(){ TaskId = 49, TaskName="Q-3 Release", StartDate=new DateTime(2022,07,01), EndDate=new DateTime(2022,09,29), Manager="", DueDate=DateTime.Now, TimeLog=2, Work="2", Progress=100, StoryPoints=100, Status="In Progress", },
                new TaskData(){ TaskId = 50, TaskName="Roadmap", ParentId=49, },
                new TaskData(){ TaskId = 51, TaskName="Implementation", ParentId=50, },
                new TaskData(){ TaskId = 52, TaskName="Grid", StartDate=new DateTime(2022,07,01), EndDate=new DateTime(2022,7,20), DueDate=new DateTime(2022,04,4), TimeLog=15, Work="120", Progress=100, ParentId=51, },
                new TaskData(){ TaskId = 53, TaskName="Lazy-Loading Grouping with Virtualization", StartDate=new DateTime(2022,07,01), EndDate=new DateTime(2022,07,15), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=11, Work="12", Progress=50, Status="In Progress", ParentId=52, Priority="Normal", Component="Grid", },
                new TaskData(){ TaskId = 54, TaskName="Filter Bar Keyboard Navigation", StartDate=new DateTime(2022,07,04), EndDate=new DateTime(2022,07,18), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=11, Work="15", Progress=20, Status="On Hold", ParentId=52, Priority="Low", Component="Grid", },
                new TaskData(){ TaskId = 55, TaskName="Keyboard Navigation Enhanced", StartDate=new DateTime(2022,07,07), EndDate=new DateTime(2022,07,20), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=11, Work="12", Progress=33, Status="In Progress", ParentId=52, Priority="High", Component="Grid", },
                new TaskData(){ TaskId = 56, TaskName="Tree Grid", StartDate=new DateTime(2022,07,01), EndDate=new DateTime(2022,7,20), DueDate=new DateTime(2022,04,4), TimeLog=15, Work="12", Progress=100, ParentId=51, },
                new TaskData(){ TaskId = 57, TaskName="Persistence State", StartDate=new DateTime(2022,07,15), EndDate=new DateTime(2022,08,15), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=24, Work="20", Progress=20, Status="In Progress", ParentId=56, Priority="Normal", Component="Tree Grid", },
                new TaskData(){ TaskId = 58, TaskName="Add or Remove Frozen Columns", StartDate=new DateTime(2022,07,18), EndDate=new DateTime(2022,08,15), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=24, Work="20", Progress=40, Status="In Progress", ParentId=56, Priority="Critical", Component="Tree Grid", },
                new TaskData(){ TaskId = 59, TaskName="Gantt Chart", StartDate=new DateTime(2022,07,01), EndDate=new DateTime(2022,7,20), DueDate=new DateTime(2022,04,4), TimeLog=15, Work="120", Progress=100, ParentId=51, },
                new TaskData(){ TaskId = 60, TaskName="Timeline Virtualization", StartDate=new DateTime(2022,07,18), EndDate=new DateTime(2022,08,15), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=24, Work="21", Progress=80, Status="In Progress", ParentId=59, Priority="Normal", Component="Gantt Chart", },
                new TaskData(){ TaskId = 61, TaskName="String and GUID Task Id type", StartDate=new DateTime(2022,07,25), EndDate=new DateTime(2022,08,20), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=24, Work="19", Progress=10, Status="In Progress", ParentId=59, Priority="Normal", Component="Gantt Chart", },
                new TaskData(){ TaskId = 62, TaskName="Rendering spinner for every Gantt action", StartDate=new DateTime(2022,07,27), EndDate=new DateTime(2022,08,20), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=24, Work="20", Progress=35, Status="In Progress", ParentId=59, Priority="Normal", Component="Gantt Chart", },
                new TaskData(){ TaskId = 63, TaskName="External Key Events", StartDate=new DateTime(2022,07,27), EndDate=new DateTime(2022,08,15), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=24, Work="18", Progress=100, Status="Completed", ParentId=59, Priority="High", Component="Gantt Chart", },
                new TaskData(){ TaskId = 64, TaskName="Dependency and CRUD operation in row virtualization", StartDate=new DateTime(2022,07,25), EndDate=new DateTime(2022,08,15), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=24, Work="17", Progress=78, Status="In Progress", ParentId=59, Predecessor="30FS+40Days", Priority="Normal", Component="Gantt Chart", },
                new TaskData(){ TaskId = 65, TaskName="AutoCalculateDateScheduling API", StartDate=new DateTime(2022,07,27), EndDate=new DateTime(2022,08,20), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=24, Work="19", Progress=25, Status="On Hold", ParentId=59, Priority="Low", Component="Gantt Chart", },
                new TaskData(){ TaskId = 66, TaskName="Persistence State", StartDate=new DateTime(2022,08,15), EndDate=new DateTime(2022,09,15), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=24, Work="18", Progress=70, Status="In Progress", ParentId=59, Predecessor="58FS", Priority="Normal", Component="Gantt Chart", },
                new TaskData(){ TaskId = 67, TaskName="Feature Completion", StartDate=new DateTime(2022,9,15), TimeLog=0, ParentId=51, },
                new TaskData(){ TaskId = 68, TaskName="Testing", Work="8", ParentId=51, },
                new TaskData(){ TaskId = 69, TaskName="Phase-1", StartDate=new DateTime(2022,09,15), EndDate=new DateTime(2022,09,19), Work="3", Progress=0, ParentId=68, },
                new TaskData(){ TaskId = 70, TaskName="Phase-2", StartDate=new DateTime(2022,09,18), EndDate=new DateTime(2022,09,23), Work="4", Predecessor="69FS", Progress=0, ParentId=68, },
                new TaskData(){ TaskId = 71, TaskName="Testing Completion", StartDate=new DateTime(2022,9,24), TimeLog=0, ParentId=51, },
                new TaskData(){ TaskId = 72, TaskName="Release Roll-out", StartDate=new DateTime(2022,09,29), TimeLog=0, ParentId=50, },

            };
            return Tasks;
        }

        public static List<AssignmentModel> GetAssignmentCollection()
        {
            List<AssignmentModel> assignments = new List<AssignmentModel>()
            {
                new AssignmentModel(){ Id=1, TaskId = 5, ResourceId = 1},
                new AssignmentModel(){ Id=2, TaskId = 6, ResourceId = 2},
                new AssignmentModel(){ Id=3, TaskId = 8, ResourceId = 4},
                new AssignmentModel(){ Id=4, TaskId = 10, ResourceId = 1},
                new AssignmentModel(){ Id=6, TaskId = 11, ResourceId = 6},
                new AssignmentModel(){ Id=7, TaskId = 12, ResourceId = 1},
                new AssignmentModel(){ Id=8, TaskId = 13, ResourceId = 4},
                new AssignmentModel(){ Id=9, TaskId = 14, ResourceId = 1},
                new AssignmentModel(){ Id=10, TaskId = 15, ResourceId = 4},
                new AssignmentModel(){ Id=11, TaskId = 25, ResourceId = 1},
                new AssignmentModel(){ Id=12, TaskId = 26, ResourceId = 6},
                new AssignmentModel(){ Id=13, TaskId = 27, ResourceId = 2},
                new AssignmentModel(){ Id=14, TaskId = 29, ResourceId = 4},
                new AssignmentModel(){ Id=15, TaskId = 30, ResourceId = 1},
                new AssignmentModel(){ Id=16, TaskId = 32, ResourceId = 2},
                new AssignmentModel(){ Id=17, TaskId = 33, ResourceId = 4},
                new AssignmentModel(){ Id=18, TaskId = 34, ResourceId = 6},
                new AssignmentModel(){ Id=19, TaskId = 35, ResourceId = 1},
                new AssignmentModel(){ Id=20, TaskId = 36, ResourceId = 2},
                new AssignmentModel(){ Id=21, TaskId = 37, ResourceId = 6},
                new AssignmentModel(){ Id=22, TaskId = 38, ResourceId = 4},
                new AssignmentModel(){ Id=23, TaskId = 39, ResourceId = 2},
                new AssignmentModel(){ Id=24, TaskId = 40, ResourceId = 1},
                new AssignmentModel(){ Id=25, TaskId = 42, ResourceId = 4},
                new AssignmentModel(){ Id=26, TaskId = 53, ResourceId = 1},
                new AssignmentModel(){ Id=27, TaskId = 54, ResourceId = 6},
                new AssignmentModel(){ Id=28, TaskId = 55, ResourceId = 2},
                new AssignmentModel(){ Id=29, TaskId = 57, ResourceId = 2},
                new AssignmentModel(){ Id=30, TaskId = 58, ResourceId = 1},
                new AssignmentModel(){ Id=31, TaskId = 60, ResourceId = 6},
                new AssignmentModel(){ Id=32, TaskId = 61, ResourceId = 4},
                new AssignmentModel(){ Id=33, TaskId = 62, ResourceId = 2},
                new AssignmentModel(){ Id=34, TaskId = 63, ResourceId = 6},
                new AssignmentModel(){ Id=35, TaskId = 64, ResourceId = 1},
                new AssignmentModel(){ Id=36, TaskId = 65, ResourceId = 2},
                new AssignmentModel(){ Id=37, TaskId = 66, ResourceId = 2},
                new AssignmentModel(){ Id=37, TaskId = 43, ResourceId = 6},
            };
            return assignments;
        }
    }
}
