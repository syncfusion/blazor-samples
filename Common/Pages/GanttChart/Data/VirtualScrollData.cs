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
    public class VirtualScrollData
    {
        public class TaskData
        {
            public int ID { get; set; }
            public string TaskName { get; set; } = string.Empty;
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string? Duration { get; set; }
            public string Assignee { get; set; } = string.Empty;
            public string Reporter { get; set; } = string.Empty;
            public int Progress { get; set; }
            public int? ParentId { get; set; }
            public string Status { get; set; } = string.Empty;
            public double? Work { get; set; }
            public int WorkersCount { get; set; }
            public string TaskType { get; set; } = string.Empty;
            public string ApprovedBy { get; set; } = string.Empty;
            public string Shift { get; set; } = string.Empty;
            public string PlatForm { get; set; } = string.Empty;
            public int StoryPoint { get; set; }
            public string Priority { get; set; } = string.Empty;
            public string FixVerison { get; set; } = string.Empty;
            public DateTime ActualStartDate { get; set; }
            public DateTime ActualEndDate { get; set; }
            public string Predecessor { get; set; } = string.Empty;
        }
        /// <summary>
		/// Generates a hierarchical list of task data for virtual scrolling.
		/// </summary>
		public static List<TaskData> GetTreeVirtualData(int count)
        {
            List<TaskData> DataCollection = new List<TaskData>();
            var x = 0;
            int duration = 0;
            DateTime startDate = new DateTime(2000, 1, 5);
            DateTime endDate = new DateTime(2000, 1, 12);
            string[] assignee = { "Allison Janney", "Bryan Fogel", "Richard King", "Alex Gibson" };
            string[] reporter = { "James Ivory", "Jordan Peele", "Guillermo del Toro", "Gary Oldman" };
            string[] priority = { "Normal", "High", "Low", "Ultra Critical" };
            string[] status = { "Validated", "InProgress", "Approved", "Completed" };
            string[] tasktype = { "FixedDuration", "FixedWork", "FixedUnit" };
            string[] shift = { "Noon Shift", "Night Shift", "Regular" };
            int[] storypoint = { 1, 2, 3, 4 };
            string[] fixversion = { "19.1", "19.2", "20.1", "20.2" };
            string[] approvedby = { "Margaret Buchanan", "Van Jack", "Fuller King", "Rose Fuller" };
            string[] platform = { "Blazor", "Angular", "EJ2", "EJ1" };
            for (var i = 1; i <= count / 5; i++)
            {
                TaskData Parent = new TaskData()
                {
                    ID = ++x,
                    TaskName = "Task " + x,
                    StartDate = startDate,
                    EndDate = startDate.AddDays(26),
                    ActualStartDate = startDate,
                    ActualEndDate = endDate,
                    Duration = "20",
                    Assignee = "Mark Bridges",
                    Reporter = "Kobe Bryant",
                    Progress = 50,
                    Priority = "High",
                    TaskType = "FixedWork",
                    Status = "Open",
                    Work = 16 + x,
                    Shift = "Regular",
                    StoryPoint = 5,
                    WorkersCount = 4,
                    FixVerison = "20.2",
                    ApprovedBy = "Van Jack",
                    PlatForm = "Blazor",
                    Predecessor = null
                };
                DataCollection.Add(Parent);
                for (var j = 1; j <= 4; j++)
                {
                    startDate = startDate.AddDays(j == 1 ? 0 : duration + 2);
                    duration = 5;
                    DataCollection.Add(new TaskData()
                    {
                        ID = ++x,
                        TaskName = "Task " + x,
                        StartDate = startDate,
                        EndDate = startDate.AddDays(5),
                        ActualStartDate = startDate,
                        ActualEndDate = startDate.AddDays(5),
                        Duration = duration.ToString(),
                        Assignee = assignee[j - 1],
                        Reporter = reporter[j - 1],
                        Progress = 50,
                        ParentId = Parent.ID,
                        Priority = priority[j - 1],
                        Status = status[j - 1],
                        Work = 96 + x,
                        TaskType = tasktype[(j - 1) % 3],
                        Shift = shift[(j - 1) % 3],
                        StoryPoint = storypoint[j - 1],
                        WorkersCount = 1,
                        FixVerison = fixversion[j - 1],
                        ApprovedBy = approvedby[j - 1],
                        PlatForm = platform[j - 1],
                        Predecessor = j > 1 ? (x - 1) + "FS" : ""
                    });
                }
            }
            return DataCollection;
        }
    }
}
