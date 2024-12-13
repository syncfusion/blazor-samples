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
            public double Work { get; set; }
            public string Manager { get; set; }
            public int Progress { get; set; }
            public string Predecessor { get; set; }
            public string EmptyPredecessor { get; set; }
            public double StoryPoints { get; set; }
            public string Status { get; set; }
            public int? ParentId { get; set; }
            public string Priority { get; set; }
            public string Component { get; set; }
            public bool? IsManual { get; set; }
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
                new TaskData(){ TaskId = 1, TaskName="Q-1 Release", StartDate=new DateTime(2021,12,20), EndDate=new DateTime(2022,02,17), Manager="", DueDate= new DateTime(2022,04,4), Work=45, Progress=80, Status="In Progress", IsManual=false },
                new TaskData(){ TaskId = 2, TaskName="Roadmap", StartDate=new DateTime(2021,12,20), EndDate=new DateTime(2022,02,17), ParentId=1, IsManual=false },
                new TaskData(){ TaskId = 3, TaskName="Implementation", StartDate=new DateTime(2021,12,20), EndDate=new DateTime(2022,02,17), ParentId=2, IsManual=false },
                new TaskData(){ TaskId = 4, TaskName="Grid", StartDate=new DateTime(2021,12,20), EndDate=new DateTime(2022,2,20), DueDate=new DateTime(2022,04,4), TimeLog=34, Work=34, Progress=70, ParentId=3, IsManual=true },
                new TaskData(){ TaskId = 5, TaskName="Batch Editing", StartDate=new DateTime(2021,12,24), EndDate=new DateTime(2022,1,19), Manager="", DueDate=new DateTime(2022,2,17), TimeLog=20, Work=160, Progress=100, Status="Completed", ParentId=4, Priority="High", Component="Grid", IsManual=false },
                new TaskData(){ TaskId = 6, TaskName="PDF Export", StartDate=new DateTime(2021,12,28), EndDate=new DateTime(2022,2,04), Manager="", DueDate=new DateTime(2022,2,17), TimeLog=30, Work=210, Progress=10, Status="On Hold", ParentId=4, Priority="Normal", Component="Grid", IsManual=true },
                new TaskData(){ TaskId = 7, TaskName="Tree Grid", StartDate=new DateTime(2021,12,24), EndDate=new DateTime(2022,1,6), DueDate=new DateTime(2022,2,20), TimeLog=10, Work=80, Progress=80, ParentId=3, IsManual=false },
                new TaskData(){ TaskId = 8, TaskName="Drag Multi-selection", StartDate=new DateTime(2021,12,24), EndDate=new DateTime(2022,1,6), Manager="", DueDate=new DateTime(2022,2,20), TimeLog=10, Work=80, Progress=100, Status="Completed", ParentId=7, Priority="Critical", Component="Tree Grid", IsManual=false },
                new TaskData(){ TaskId = 9, TaskName="Gantt Chart", StartDate=new DateTime(2021,12,24), EndDate=new DateTime(2022,3,25), DueDate=DateTime.Now, Work=10, Progress=100, ParentId=3, IsManual=false },
                new TaskData(){ TaskId = 10, TaskName="Initial loading performance", StartDate=new DateTime(2021,12,24), EndDate=new DateTime(2022,1,3), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=7, Work=56, Progress=35, Status="In Progress", ParentId=9, Priority="Low", Component="Gantt Chart", IsManual=false },
                new TaskData(){ TaskId = 11, TaskName="Drag Multi-selection", StartDate=new DateTime(2022,1,7), EndDate=new DateTime(2022,1,24), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=7, Work=56, Progress=100, Predecessor="8FS", Status="Completed", ParentId=9, Priority="Normal", Component="Gantt Chart", IsManual=true },
                new TaskData(){ TaskId = 12, TaskName="ScrollToViewAsync Method", StartDate=new DateTime(2022,1,17), EndDate=new DateTime(2022,1,21), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=5, Work=40, Progress=100, Status="Completed", ParentId=9, Priority="High", Component="Gantt Chart", IsManual=false },
                new TaskData(){ TaskId = 13, TaskName="ScrollToTimelineAsync Method", StartDate=new DateTime(2022,1,20), EndDate=new DateTime(2022,1,26), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=5, Work=40, Progress=100, Status="On Hold", ParentId=9, Priority="Normal", Component="Gantt Chart", IsManual=true },
                new TaskData(){ TaskId = 14, TaskName="ScrollToTaskbarAsync Method", StartDate=new DateTime(2022,1,24), EndDate=new DateTime(2022,1,28), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=5, Work=40, Progress=40, Status="Completed", ParentId=9, Priority="Critical", Component="Gantt Chart", IsManual=false },
                new TaskData(){ TaskId = 15, TaskName="Web Accessibility", StartDate=new DateTime(2022,1,26), EndDate=new DateTime(2022,2,1), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=5, Work=40, Progress=35, Status="On Hold", ParentId=9, Priority="Normal", Component="Gantt Chart", IsManual=true },
                new TaskData(){ TaskId = 16, TaskName="Feature Completion", StartDate=new DateTime(2022,2,9), TimeLog=0, ParentId=3, IsManual=false, Predecessor = "6, 8, 15" },
                new TaskData(){ TaskId = 17, TaskName="Testing", Work=8, ParentId=3, IsManual=true,StartDate=new DateTime(2022,2,10), EndDate=new DateTime(2022,3,7), },
                new TaskData(){ TaskId = 18, TaskName="Phase-1", StartDate=new DateTime(2022,2,10), EndDate=new DateTime(2022,2,22), Work=80, Progress=0, ParentId=17, IsManual=false, Predecessor = "16" },
                new TaskData(){ TaskId = 19, TaskName="Phase-2", StartDate=new DateTime(2022,2,23), EndDate=new DateTime(2022,3,7), Work=80, Progress=0, Predecessor="18", ParentId=17, IsManual=true },
                new TaskData(){ TaskId = 20, TaskName="Build Confirmation", StartDate=new DateTime(2022,2,28), TimeLog=2, Work =16 ,ParentId=3, IsManual=false, Predecessor = "19" },
                new TaskData(){ TaskId = 21, TaskName="Release Roll-out", StartDate=new DateTime(2022,03,2), TimeLog=0, ParentId=2, IsManual=true, Predecessor = "20" },

                new TaskData(){ TaskId = 22, TaskName="Q-2 Release", StartDate=new DateTime(2022,03,3), EndDate=new DateTime(2022,06,30), Manager="", DueDate=new DateTime(2022,06,30), TimeLog=2, Work=2, Progress=90, Status="Completed", IsManual=false },
                new TaskData(){ TaskId = 23, TaskName = "Roadmap", StartDate = new DateTime(2022,03,3), EndDate = new DateTime(2022, 04, 4), ParentId = 22, IsManual = false},
                new TaskData(){ TaskId = 24, TaskName = "Implementation", StartDate = new DateTime(2022,03,3), EndDate = new DateTime(2022, 04, 4), ParentId = 23, IsManual = false},
                new TaskData(){ TaskId = 25, TaskName="Grid", StartDate=new DateTime(2022,03,3), EndDate=new DateTime(2022,05,3), DueDate=DateTime.Now, TimeLog=25, Work=2, Progress=100, ParentId=24, IsManual=false },
                new TaskData(){ TaskId = 26, TaskName="Adapative UI Mode", StartDate=new DateTime(2022,03,9), EndDate=new DateTime(2022,03,31), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=20, Work=160, Progress=100, Status="Completed", ParentId=25, Priority="Normal", Component="Grid", IsManual=true },
                new TaskData(){ TaskId = 27, TaskName="Sticky Header", StartDate=new DateTime(2022,03,11), EndDate=new DateTime(2022,03,15), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=7, Work=56, Progress=100, Status="Completed", ParentId=25, Priority="Normal", Component="Grid", IsManual=false },
                new TaskData(){ TaskId = 28, TaskName="Web Accessibility", StartDate=new DateTime(2022,03,15), EndDate=new DateTime(2022,03,22), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=6, Work=48, Progress=100, Status="Completed", ParentId=25, Priority="High", Component="Grid", IsManual=false },
                new TaskData(){ TaskId = 29, TaskName="Tree Grid", StartDate=new DateTime(2022,04,11), EndDate=new DateTime(2022,05,9), DueDate=new DateTime(2022,05,20), TimeLog=25, Work=200, Progress=100, ParentId=24, IsManual=true },
                new TaskData(){ TaskId = 30, TaskName="CRUD Operation for virtualization", StartDate=new DateTime(2022,03,9), EndDate=new DateTime(2022,04,8), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=26, Work=208, Progress=72, Status="In Progress", ParentId=29, Priority="Normal", Component="Tree Grid", IsManual=true },
                new TaskData(){ TaskId = 31, TaskName="Frozen Column", StartDate=new DateTime(2022,03,25), EndDate=new DateTime(2022,04,7), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=10, Work=80, Progress=80, Status="Completed", ParentId=29, Priority="High", Component="Tree Grid", IsManual=false },
                new TaskData(){ TaskId = 32, TaskName="Gantt Chart", StartDate=new DateTime(2022,05,05), EndDate=new DateTime(2022,6,20), DueDate=DateTime.Now, Work=2, Progress=50, ParentId=24, IsManual=true },
                new TaskData(){ TaskId = 33, TaskName="Touch Interaction ", StartDate=new DateTime(2022,03,9), EndDate=new DateTime(2022,4,6), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=25, Work=200, Progress=100, Status="Completed", ParentId=32, Priority="Normal", Component="Gantt Chart", IsManual=true },
                new TaskData(){ TaskId = 34, TaskName="Editing Tooltip Template", StartDate=new DateTime(2022,03,11), EndDate=new DateTime(2022,3,9), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=5, Work=40, Progress=100, Status="Completed", ParentId=32, Priority="Low", Component="Gantt Chart", IsManual=false },
                new TaskData(){ TaskId = 35, TaskName="Predecessor Drag Vertical Auto Scroll", StartDate=new DateTime(2022,03,14), EndDate=new DateTime(2022,3,14), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=5, Work=40, Progress=100, Status="Completed", ParentId=32, Priority="Normal", Component="Gantt Chart", IsManual=false },
                new TaskData(){ TaskId = 36, TaskName="Taskbar Drag Horizontal Auto Scroll", StartDate=new DateTime(2022,03,14), EndDate=new DateTime(2022,3,18), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=5, Work=40, Progress=100, Status="Completed", ParentId=32, Priority="Normal", Component="Gantt Chart", IsManual=false },

                new TaskData(){ TaskId = 37, TaskName="Observable Collection", StartDate=new DateTime(2022,03,17), EndDate=new DateTime(2022,03,23), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=5, Work=40, Progress=70, Status="On Hold", ParentId=32, Priority="Critical", Component="Gantt Chart", IsManual=false  },
                new TaskData(){ TaskId = 38, TaskName="INotifyPropertyChanged", StartDate=new DateTime(2022,03,21), EndDate=new DateTime(2022,03,29), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=7, Work=56, Progress=20, Status="On Hold", ParentId=32, Priority="Normal", Component="Gantt Chart", IsManual=false },
                new TaskData(){ TaskId = 39, TaskName="Customized Taskbar Editing", StartDate=new DateTime(2022,03,28), EndDate=new DateTime(2022,04,8), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=10, Work=80, Progress=10, Status="On Hold", ParentId=32, Priority="High", Component="Gantt Chart", IsManual=true },
                new TaskData(){ TaskId = 40, TaskName="Column Virtualization ", StartDate=new DateTime(2022,04,8), EndDate=new DateTime(2022,04,14), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=5, Work=40, Progress=80, Status="Completed", ParentId=32, Priority="Critical", Component="Gantt Chart", IsManual=false, Predecessor = "31" },
                
                new TaskData(){ TaskId = 41, TaskName="Predecessor Types Configure", StartDate=new DateTime(2022,04,12), EndDate=new DateTime(2022,4,19), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=6, Work=48, Progress=70, Status="On Hold", ParentId=32, Priority="Low", Component="Gantt Chart", IsManual=true },
                new TaskData(){ TaskId = 42, TaskName="Based on content height holiday, event markers, and weekend container rendering", StartDate=new DateTime(2022,04,18), EndDate=new DateTime(2022,4,25), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=6, Work=48, Progress=60, Status="In Progress", ParentId=32, Priority="Normal", Component="Gantt Chart", IsManual=false },
                new TaskData(){ TaskId = 43, TaskName="Feature Completion", StartDate=new DateTime(2022,4,25), TimeLog=0, ParentId=24, IsManual=false, Predecessor = "28, 31, 42" },
                new TaskData(){ TaskId = 44, TaskName="Testing", Work=8, ParentId=24, IsManual=true, StartDate=new DateTime(2022,04,26), EndDate=new DateTime(2022,05,23) },
                new TaskData(){ TaskId = 45, TaskName="Phase-1", StartDate=new DateTime(2022,4,26), EndDate=new DateTime(2022,5,6), Work=80, Progress=0, ParentId=44, IsManual=false, Predecessor = "43" },
                new TaskData(){ TaskId = 46, TaskName="Phase-2", StartDate=new DateTime(2022,5,9), EndDate=new DateTime(2022,5,19), Work=80, Predecessor="45", Progress=0, ParentId=44, IsManual=true },
                new TaskData(){ TaskId = 47, TaskName="Build Confirmation", StartDate=new DateTime(2022,5,19), TimeLog=2, Work= 16, ParentId=44, IsManual=true, Predecessor = "46" },
                new TaskData(){ TaskId = 48, TaskName="Release Roll-out", StartDate=new DateTime(2022,05,23), TimeLog=0, ParentId=23, IsManual=true, Predecessor = "47" },

                new TaskData(){ TaskId = 49, TaskName="Q-3 Release", StartDate=new DateTime(2022,05,25), EndDate=new DateTime(2022,09,29), Manager="", DueDate=DateTime.Now, TimeLog=2, Work=2, Progress=100, StoryPoints=100, Status="In Progress", IsManual=false },
                new TaskData(){ TaskId = 50, TaskName="Roadmap", ParentId=49, IsManual=true, StartDate=new DateTime(2022,5,25), EndDate=new DateTime(2022,04,4) },
                new TaskData(){ TaskId = 51, TaskName="Implementation", ParentId=50, IsManual=true, StartDate=new DateTime(2022,5,25), EndDate=new DateTime(2022,04,4) },
                new TaskData(){ TaskId = 52, TaskName="Grid", StartDate=new DateTime(2022,05,25), EndDate=new DateTime(2022,7,20), DueDate=new DateTime(2022,04,4), TimeLog=15, Work=120, Progress=100, ParentId=51, IsManual=false },
                new TaskData(){ TaskId = 53, TaskName="Lazy-Loading Grouping with Virtualization", StartDate=new DateTime(2022,05,25), EndDate=new DateTime(2022,06,7), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=10, Work=80, Progress=50, Status="In Progress", ParentId=52, Priority="Normal", Component="Grid", IsManual=false },
                new TaskData(){ TaskId = 54, TaskName="Filter Bar Keyboard Navigation", StartDate=new DateTime(2022,5,30), EndDate=new DateTime(2022,06,7), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=10, Work=80, Progress=20, Status="On Hold", ParentId=52, Priority="Low", Component="Grid", IsManual=false },
                new TaskData(){ TaskId = 55, TaskName="Keyboard Navigation Enhanced", StartDate=new DateTime(2022,06,3), EndDate=new DateTime(2022,06,2), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=5, Work=40, Progress=33, Status="In Progress", ParentId=52, Priority="High", Component="Grid", IsManual=true },
                new TaskData(){ TaskId = 56, TaskName="Tree Grid", StartDate=new DateTime(2022,07,01), EndDate=new DateTime(2022,7,20), DueDate=new DateTime(2022,04,4), TimeLog=15, Work=120, Progress=100, ParentId=51, IsManual=false },
                new TaskData(){ TaskId = 57, TaskName="Persistence State", StartDate=new DateTime(2022,05,25), EndDate=new DateTime(2022,06,28), Manager="", DueDate=new DateTime(2022,2,01), TimeLog=25, Work=200, Progress=20, Status="In Progress", ParentId=56, Priority="Normal", Component="Tree Grid", IsManual=true },
                new TaskData(){ TaskId = 58, TaskName="Add or Remove Frozen Columns", StartDate=new DateTime(2022,08,13), EndDate=new DateTime(2022,09,10), Manager="", DueDate=new DateTime(2022,08,01), TimeLog=4, Work=32, Progress=40, Status="In Progress", ParentId=56, Priority="Critical", Component="Tree Grid", IsManual=false, Predecessor = "40+28Days"  },
                new TaskData(){ TaskId = 59, TaskName="Gantt Chart", StartDate=new DateTime(2022,08,01), EndDate=new DateTime(2022,08,20), DueDate=new DateTime(2022,09,4), TimeLog=15, Work=120, Progress=100, ParentId=51, IsManual=false },
                new TaskData(){ TaskId = 60, TaskName="String and GUID Task Id type", StartDate=new DateTime(2022,08,05), EndDate=new DateTime(2022,09,01), Manager="", DueDate=new DateTime(2022,08,15), TimeLog=24, Work=192, Progress=10, Status="In Progress", ParentId=59, Priority="Normal", Component="Gantt Chart", IsManual=false },
                new TaskData(){ TaskId = 62, TaskName="Dependency and CRUD operation in row virtualization", StartDate=new DateTime(2022,08,10), EndDate=new DateTime(2022,08,30), Manager="", DueDate=new DateTime(2022,08,05), TimeLog=15, Work=120, Progress=78, Status="In Progress", ParentId=59, Predecessor="30+30Days", Priority="Normal", Component="Gantt Chart", IsManual=true },
                new TaskData(){ TaskId = 63, TaskName="Timeline Virtualization", StartDate=new DateTime(2022,08,16), EndDate=new DateTime(2022,08,18), Manager="", DueDate=new DateTime(2022,08,01), TimeLog=10, Work=80, Progress=80, Status="In Progress", ParentId=59, Priority="Normal", Component="Gantt Chart", IsManual=false },
                new TaskData(){ TaskId = 64, TaskName="External Key Events", StartDate=new DateTime(2022,08,13), EndDate=new DateTime(2022,08,23), Manager="", DueDate=new DateTime(2022,08,01), TimeLog=5, Work=40, Progress=100, Status="Completed", ParentId=59, Priority="High", Component="Gantt Chart", IsManual=false },

                new TaskData(){ TaskId = 65, TaskName="Rendering spinner for every Gantt action", StartDate=new DateTime(2022,08,15), EndDate=new DateTime(2022,08,31), Manager="", DueDate=new DateTime(2022,08,01), TimeLog=3, Work=24, Progress=35, Status="In Progress", ParentId=59, Priority="Normal", Component="Gantt Chart", IsManual=false },
                new TaskData(){ TaskId = 61, TaskName="AutoCalculateDateScheduling API", StartDate=new DateTime(2022,08,05), EndDate=new DateTime(2022,08,25), Manager="", DueDate=new DateTime(2022,08,01), TimeLog=15, Work=120, Progress=25, Status="On Hold", ParentId=59, Priority="Low", Component="Gantt Chart", IsManual=true },
                new TaskData(){ TaskId = 66, TaskName="Persistence State", StartDate=new DateTime(2022,08,01), EndDate=new DateTime(2022,08,20), Manager="", DueDate=new DateTime(2022,08,01), TimeLog=14, Work=112, Progress=70, Status="In Progress", ParentId=59, Predecessor="58FS", Priority="Critical", Component="Gantt Chart", IsManual=true },
                new TaskData(){ TaskId = 67, TaskName="Feature Completion", StartDate=new DateTime(2022,08,20), TimeLog=0, ParentId=51, IsManual=true, Predecessor = "55, 58, 66" },
                new TaskData(){ TaskId = 68, TaskName="Testing", Work=8, ParentId=51, IsManual=true, StartDate=new DateTime(2022,08,21), EndDate=new DateTime(2022,08,24) },
                new TaskData(){ TaskId = 69, TaskName="Phase-1", StartDate=new DateTime(2022,08,21), EndDate=new DateTime(2022,09,04), Work=80, Progress=0, ParentId=68, IsManual=false, Predecessor = "67" },
                new TaskData(){ TaskId = 70, TaskName="Phase-2", StartDate=new DateTime(2022,08,24), EndDate=new DateTime(2022,09,07), Work=80, Predecessor="69", Progress=0, ParentId=68, IsManual=true },
                new TaskData(){ TaskId = 71, TaskName="Testing Completion", StartDate=new DateTime(2022,09,07), TimeLog=2, Work=16, ParentId=51, IsManual=true, Predecessor = "70" },
                new TaskData(){ TaskId = 72, TaskName="Release Roll-out", StartDate=new DateTime(2022,09,08), TimeLog=0, ParentId=50, IsManual=true, Predecessor ="71" },


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
                new AssignmentModel(){ Id=5, TaskId = 11, ResourceId = 6},
                new AssignmentModel(){ Id=6, TaskId = 12, ResourceId = 1},
                new AssignmentModel(){ Id=7, TaskId = 13, ResourceId = 4},
                new AssignmentModel(){ Id=8, TaskId = 14, ResourceId = 1},
                new AssignmentModel(){ Id=9, TaskId = 15, ResourceId = 4},
                new AssignmentModel(){ Id=10, TaskId = 25, ResourceId = 1},
                new AssignmentModel(){ Id=11, TaskId = 26, ResourceId = 6},
                new AssignmentModel(){ Id=12, TaskId = 27, ResourceId = 2},
                new AssignmentModel(){ Id=13, TaskId = 29, ResourceId = 4},
                new AssignmentModel(){ Id=14, TaskId = 30, ResourceId = 1},
                new AssignmentModel(){ Id=15, TaskId = 32, ResourceId = 2},
                new AssignmentModel(){ Id=16, TaskId = 33, ResourceId = 4},
                new AssignmentModel(){ Id=17, TaskId = 34, ResourceId = 6},
                new AssignmentModel(){ Id=18, TaskId = 35, ResourceId = 1},
                new AssignmentModel(){ Id=19, TaskId = 36, ResourceId = 2},
                new AssignmentModel(){ Id=20, TaskId = 37, ResourceId = 6},
                new AssignmentModel(){ Id=21, TaskId = 38, ResourceId = 4},
                new AssignmentModel(){ Id=22, TaskId = 39, ResourceId = 2},
                new AssignmentModel(){ Id=23, TaskId = 40, ResourceId = 1},
                new AssignmentModel(){ Id=24, TaskId = 42, ResourceId = 4},
                new AssignmentModel(){ Id=25, TaskId = 53, ResourceId = 1},
                new AssignmentModel(){ Id=26, TaskId = 54, ResourceId = 6},
                new AssignmentModel(){ Id=27, TaskId = 55, ResourceId = 2},
                new AssignmentModel(){ Id=28, TaskId = 57, ResourceId = 2},
                new AssignmentModel(){ Id=29, TaskId = 58, ResourceId = 1},
                new AssignmentModel(){ Id=30, TaskId = 60, ResourceId = 6},
                new AssignmentModel(){ Id=31, TaskId = 61, ResourceId = 4},
                new AssignmentModel(){ Id=32, TaskId = 62, ResourceId = 2},
                new AssignmentModel(){ Id=33, TaskId = 63, ResourceId = 6},
                new AssignmentModel(){ Id=34, TaskId = 64, ResourceId = 1},
                new AssignmentModel(){ Id=35, TaskId = 65, ResourceId = 2},
                new AssignmentModel(){ Id=36, TaskId = 66, ResourceId = 2},
                new AssignmentModel(){ Id=37, TaskId = 43, ResourceId = 6},
            };
            return assignments;
        }

        public class SegmentModel
        {
            public int id { get; set; }
            public int TaskId { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Duration { get; set; }
        }

        public static List<SegmentModel> GetSegmentCollection()
        {
            List<SegmentModel> segments = new List<SegmentModel>();
            segments.Add(new SegmentModel() { id = 1, TaskId = 5, StartDate = new DateTime(2021, 12, 24), Duration = "10" });
            segments.Add(new SegmentModel() { id = 2, TaskId = 5, StartDate = new DateTime(2022, 01, 03), Duration = "10" });
            segments.Add(new SegmentModel() { id = 3, TaskId = 6, StartDate = new DateTime(2021, 12, 28), Duration = "16" });
            segments.Add(new SegmentModel() { id = 4, TaskId = 6, StartDate = new DateTime(2022, 01, 18), Duration = "5" });
            segments.Add(new SegmentModel() { id = 5, TaskId = 6, StartDate = new DateTime(2022, 01, 25), Duration = "21" });
            segments.Add(new SegmentModel() { id = 6, TaskId = 11, StartDate = new DateTime(2022, 01, 03), Duration = "21" });
            segments.Add(new SegmentModel() { id = 7, TaskId = 11, StartDate = new DateTime(2022, 01, 28), Duration = "12" });
            segments.Add(new SegmentModel() { id = 8, TaskId = 29, StartDate = new DateTime(2022, 04, 25), Duration = "13" });
            segments.Add(new SegmentModel() { id = 9, TaskId = 29, StartDate = new DateTime(2022, 05, 11), Duration = "13" });
            segments.Add(new SegmentModel() { id = 10, TaskId = 58, StartDate = new DateTime(2022, 07, 20), Duration = "15" });
            segments.Add(new SegmentModel() { id = 11, TaskId = 58, StartDate = new DateTime(2022, 08, 08), Duration = "9" });
            segments.Add(new SegmentModel() { id = 12, TaskId = 28, StartDate = new DateTime(2022, 04, 11), Duration = "9" });
            segments.Add(new SegmentModel() { id = 13, TaskId = 28, StartDate = new DateTime(2022, 04, 25), Duration = "11" });
            segments.Add(new SegmentModel() { id = 14, TaskId = 30, StartDate = new DateTime(2022, 04, 11), Duration = "20" });
            segments.Add(new SegmentModel() { id = 15, TaskId = 30, StartDate = new DateTime(2022, 05, 10), Duration = "6" });
            segments.Add(new SegmentModel() { id = 16, TaskId = 57, StartDate = new DateTime(2022, 05, 25), Duration = "8" });
            segments.Add(new SegmentModel() { id = 17, TaskId = 57, StartDate = new DateTime(2022, 06, 07), Duration = "17" });
            return segments;
        }
    }
}
