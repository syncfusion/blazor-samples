#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

namespace BlazorDemos.Pages.GanttChart.Data
{
    public class WbsColumnData
    {
        public class TaskData
        {
            public int TaskId { get; set; }           
            public string? TaskName { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string? Duration { get; set; }
            public int Progress { get; set; }
            public int? ParentId { get; set; }
            public string? Predecessor { get; set; }
            public string? WbsCode { get; set; }
            public string? WbsPredecessor { get; set; }
        }

        /// <summary>
        /// Generates and returns a collection of Gantt task data.
        /// </summary>
        public static List<TaskData> WbsColumnRecord()
        {
            List<TaskData> Tasks = new List<TaskData>()
            {
                new TaskData { TaskId = 1, TaskName = "Product concept", StartDate = new DateTime(2025, 4, 2), EndDate = new DateTime(2025, 4, 21), },
                new TaskData { TaskId = 2, TaskName = "Defining the product and its usage", StartDate = new DateTime(2025, 4, 2), Duration = "3", Progress = 30, ParentId = 1, },
                new TaskData { TaskId = 3, TaskName = "Defining target audience", StartDate = new DateTime(2025, 4, 2), Duration = "3", ParentId = 1, },
                new TaskData { TaskId = 4, TaskName = "Prepare product sketch and notes", StartDate = new DateTime(2025, 4, 2), Duration = "2", Progress = 30, ParentId = 1, Predecessor = "2FS+1", },
                new TaskData { TaskId = 5, TaskName = "Manufacturing cost", StartDate = new DateTime(2025, 4, 4), Duration = "2", Progress = 30, ParentId = 4, },
                new TaskData { TaskId = 6, TaskName = "Selling cost", StartDate = new DateTime(2025, 4, 4), Duration = "2", ParentId = 4, },
                new TaskData { TaskId = 7, TaskName = "Selling items", StartDate = new DateTime(2025, 4, 4), Duration = "2", ParentId = 6, },
                new TaskData { TaskId = 8, TaskName = "Market research", StartDate = new DateTime(2025, 4, 2), EndDate = new DateTime(2025, 4, 21), },
                new TaskData { TaskId = 9, TaskName = "Demand analysis", StartDate = new DateTime(2025, 4, 4), EndDate = new DateTime(2025, 4, 21), ParentId = 8, },
                new TaskData { TaskId = 10, TaskName = "Customer strength", StartDate = new DateTime(2025, 4, 4), Duration = "4", Progress = 30, ParentId = 9, Predecessor = "5", },
                new TaskData { TaskId = 11, TaskName = "Market opportunity analysis", StartDate = new DateTime(2025, 4, 4), Duration = "4", ParentId = 9, Predecessor = "5", },
                new TaskData { TaskId = 12, TaskName = "Competitor analysis", StartDate = new DateTime(2025, 4, 4), Duration = "4", Progress = 30, ParentId = 8, Predecessor = "7, 8", },
                new TaskData { TaskId = 13, TaskName = "Product strength analsysis", StartDate = new DateTime(2025, 4, 4), Duration = "4", ParentId = 8, Predecessor = "9", },
                new TaskData { TaskId = 14, TaskName = "Research complete", StartDate = new DateTime(2025, 4, 4), Duration = "0", ParentId = 8, Predecessor = "10",         },
                new TaskData { TaskId = 15, TaskName = "Product design and development", StartDate = new DateTime(2025, 4, 4), EndDate = new DateTime(2025, 4, 21), },
                new TaskData { TaskId = 16, TaskName = "Functionality design", StartDate = new DateTime(2025, 4, 4), Duration = "3", Progress = 30, ParentId = 15, Predecessor = "12", },
                new TaskData { TaskId = 17, TaskName = "Quality design", StartDate = new DateTime(2025, 4, 4), Duration = "3", ParentId = 15, Predecessor = "12", },
                new TaskData { TaskId = 18, TaskName = "Define reliability", StartDate = new DateTime(2025, 4, 4), Duration = "2", Progress = 30, ParentId = 15, Predecessor = "15", },
                new TaskData { TaskId = 19, TaskName = "Identifying raw materials", StartDate = new DateTime(2025, 4, 4), Duration = "2", ParentId = 15, Predecessor = "14", },
                new TaskData { TaskId = 20, TaskName = "Define cost plan", StartDate = new DateTime(2025, 4, 4), EndDate = new DateTime(2025, 4, 21), ParentId = 15, },
                new TaskData { TaskId = 21, TaskName = "Manufacturing cost", StartDate = new DateTime(2025, 4, 4), Duration = "2", Progress = 30, ParentId = 20, Predecessor = "17", },
                new TaskData { TaskId = 22, TaskName = "Selling cost", StartDate = new DateTime(2025, 4, 4), Duration = "2", ParentId = 20, Predecessor = "17", },
                new TaskData { TaskId = 23, TaskName = "Development of the final design", StartDate = new DateTime(2025, 4, 4), EndDate = new DateTime(2025, 4, 21), ParentId = 15, },
                new TaskData { TaskId = 24, TaskName = "Defining dimensions and package volume", StartDate = new DateTime(2025, 4, 4), Duration = "2", Progress = 30, ParentId = 23, Predecessor = "19, 20", },
                new TaskData { TaskId = 25, TaskName = "Develop design to meet industry standards", StartDate = new DateTime(2025, 4, 4), Duration = "2", ParentId = 23, Predecessor = "22", },
                new TaskData { TaskId = 26, TaskName = "Include all the details", StartDate = new DateTime(2025, 4, 4), Duration = "3", ParentId = 23, Predecessor = "23", },
                new TaskData { TaskId = 27, TaskName = "CAD computer-aided design", StartDate = new DateTime(2025, 4, 4), Duration = "3", Progress = 30, ParentId = 15, Predecessor = "24", },
                new TaskData { TaskId = 28, TaskName = "CAM computer-aided manufacturing", StartDate = new DateTime(2025, 4, 4), Duration = "3", ParentId = 15, Predecessor = "25", },
                new TaskData { TaskId = 29, TaskName = "Design complete", StartDate = new DateTime(2025, 4, 4), Duration = "0", ParentId = 15, Predecessor = "26", },
                new TaskData { TaskId = 30, TaskName = "Prototype testing", StartDate = new DateTime(2025, 4, 4), Duration = "4", Progress = 30, Predecessor = "27", },
                new TaskData { TaskId = 31, TaskName = "Include feedback", StartDate = new DateTime(2025, 4, 4), Duration = "4", Predecessor = "28",         },
                new TaskData { TaskId = 32, TaskName = "Manufacturing", StartDate = new DateTime(2025, 4, 4), Duration = "5", Progress = 30, Predecessor = "28,29", },
                new TaskData { TaskId = 33, TaskName = "Assembling materials to finsihed goods", StartDate = new DateTime(2025, 4, 4), Duration = "5", Predecessor = "30", },
                new TaskData { TaskId = 34, TaskName = "Feedback and testing", StartDate = new DateTime(2025, 4, 4), EndDate = new DateTime(2025, 4, 21), },
                new TaskData { TaskId = 35, TaskName = "Internal testing and feedback", StartDate = new DateTime(2025, 4, 4), Duration = "3", Progress = 45, ParentId = 34, Predecessor = "31", },
                new TaskData { TaskId = 36, TaskName = "Customer testing and feedback", StartDate = new DateTime(2025, 4, 4), Duration = "3", Progress = 50, ParentId = 34, Predecessor = "33", },
                new TaskData { TaskId = 37, TaskName = "Final product development", StartDate = new DateTime(2025, 4, 4), EndDate = new DateTime(2025, 4, 21), },
                new TaskData { TaskId = 38, TaskName = "Important improvements", StartDate = new DateTime(2025, 4, 4), Duration = "4", Progress = 30, ParentId = 37, Predecessor = "34", },
                new TaskData { TaskId = 39, TaskName = "Address any unforeseen issues", StartDate = new DateTime(2025, 4, 4), Duration = "4", Progress = 30, ParentId = 37, Predecessor = "36", },
            };
            return Tasks;
        }
    }
}
