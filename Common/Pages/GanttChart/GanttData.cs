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
using System.Threading.Tasks;
using BlazorDemos;
namespace ej2_blazor_ganttdata
{
    public class GanttData
    {
        public class TaskData
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public string Duration { get; set; }
            public int Progress { get; set; }
            public string Predecessor { get; set; }
            public string Notes { get; set; }
            public int? ParentId { get; set; }
        }
        public static List<TaskData> EditingData()
        {
            List<TaskData> Tasks = new List<TaskData>() {
                new TaskData() { TaskId = 1, TaskName = "Planning and Permits", StartDate = new DateTime(2025, 04, 02), EndDate = new DateTime(2025, 04, 10), Duration = "7 days", Progress = 100 }, // Completed
                new TaskData() { TaskId = 2, TaskName = "Site Evaluation", StartDate = new DateTime(2025, 04, 02), EndDate = new DateTime(2025, 04, 04), Duration = "2 days", Progress = 100, ParentId = 1 }, // Completed
                new TaskData() { TaskId = 3, TaskName = "Obtain Permits", StartDate = new DateTime(2025, 04, 07), EndDate = new DateTime(2025, 04, 09), Duration = "3 days", Progress = 100, ParentId = 1, Predecessor = "2" }, // Completed
                new TaskData() { TaskId = 4, TaskName = "Finalize Planning", StartDate = new DateTime(2025, 04, 10), EndDate = new DateTime(2025, 04, 11), Duration = "2 days", Progress = 100, ParentId = 1, Predecessor = "3" }, // Completed
                new TaskData() { TaskId = 5, TaskName = "Site Preparation", StartDate = new DateTime(2025, 04, 14), EndDate = new DateTime(2025, 04, 18), Duration = "5 days", Progress = 100,  }, // Completed
                new TaskData() { TaskId = 6, TaskName = "Site Clearing", StartDate = new DateTime(2025, 04, 14), Duration = "0", Progress = 100, ParentId = 5, Predecessor = "4"}, // Completed
                new TaskData() { TaskId = 7, TaskName = "Grading and Excavation", StartDate = new DateTime(2025, 04, 15), EndDate = new DateTime(2025, 04, 17), Duration = "3 days", Progress = 100, ParentId = 5, Predecessor = "6" }, // Completed
                new TaskData() { TaskId = 8, TaskName = "Foundation Work", StartDate = new DateTime(2025, 04, 18), EndDate = new DateTime(2025, 04, 21), Duration = "4 days", Progress = 100, ParentId = 5, Predecessor = "7" }, // Completed
                new TaskData() { TaskId = 9, TaskName = "Foundation and Basement", StartDate = new DateTime(2025, 04, 22), EndDate = new DateTime(2025, 04, 28), Duration = "5 days", Progress = 100, ParentId = 5 }, // Completed
                new TaskData() { TaskId = 10, TaskName = "Pour Foundation", StartDate = new DateTime(2025, 04, 22), EndDate = new DateTime(2025, 04, 23), Duration = "2 days", Progress = 100, ParentId = 9, Predecessor = "8" }, // Completed
                new TaskData() { TaskId = 11, TaskName = "Cure Foundation", StartDate = new DateTime(2025, 04, 24), EndDate = new DateTime(2025, 04, 25), Duration = "2 days", Progress = 100, ParentId = 9, Predecessor = "10" }, // Completed
                new TaskData() { TaskId = 12, TaskName = "Basement Walls", StartDate = new DateTime(2025, 04, 28), EndDate = new DateTime(2025, 04, 30), Duration = "3 days", Progress = 100, ParentId = 9, Predecessor = "11" }, // Completed
                new TaskData() { TaskId = 13, TaskName = "Framing", StartDate = new DateTime(2025, 05, 01), EndDate = new DateTime(2025, 05, 07), Duration = "5 days", Progress = 100 }, // Completed
                new TaskData() { TaskId = 14, TaskName = "Frame Floors", StartDate = new DateTime(2025, 05, 01), EndDate = new DateTime(2025, 05, 02), Duration = "2 days", Progress = 100, ParentId = 13, Predecessor = "12" }, // Completed
                new TaskData() { TaskId = 15, TaskName = "Frame Walls", StartDate = new DateTime(2025, 05, 05), EndDate = new DateTime(2025, 05, 06), Duration = "2 days", Progress = 100, ParentId = 13, Predecessor = "14" }, // Completed
                new TaskData() { TaskId = 16, TaskName = "Install Trusses", StartDate = new DateTime(2025, 05, 07), EndDate = new DateTime(2025, 05, 08), Duration = "2 days", Progress = 100, ParentId = 13, Predecessor = "15" }, // Completed
                new TaskData() { TaskId = 17, TaskName = "Roofing", StartDate = new DateTime(2025, 05, 09), EndDate = new DateTime(2025, 05, 13), Duration = "3 days", Progress = 100, Predecessor = "16" }, // Completed
                new TaskData() { TaskId = 18, TaskName = "Mechanical, Electrical, Plumbing", StartDate = new DateTime(2025, 05, 14), EndDate = new DateTime(2025, 05, 24), Duration = "9 days", Progress = 50 }, // In progress
                new TaskData() { TaskId = 19, TaskName = "HVAC Installation", StartDate = new DateTime(2025, 05, 14), EndDate = new DateTime(2025, 05, 16), Duration = "3 days", Progress = 100, ParentId = 18, Predecessor = "17" }, // Completed
                new TaskData() { TaskId = 20, TaskName = "Plumbing Installation", StartDate = new DateTime(2025, 05, 19), EndDate = new DateTime(2025, 05, 21), Duration = "3 days", Progress = 50, ParentId = 18, Predecessor = "19" }, // In progress
                new TaskData() { TaskId = 21, TaskName = "Electrical Installation", StartDate = new DateTime(2025, 05, 22), EndDate = new DateTime(2025, 05, 24), Duration = "3 days", Progress = 0, ParentId = 18, Predecessor = "20" }, // Not started
                new TaskData() { TaskId = 22, TaskName = "Interior Finishing", StartDate = new DateTime(2025, 05, 26), EndDate = new DateTime(2025, 06, 17), Duration = "15 days", Progress = 0, Predecessor = "21" }, // Not started
                new TaskData() { TaskId = 23, TaskName = "Insulation and Drywall", StartDate = new DateTime(2025, 05, 26), EndDate = new DateTime(2025, 05, 30), Duration = "5 days", Progress = 0, ParentId = 22, Predecessor = "21" }, // Not started
                new TaskData() { TaskId = 24, TaskName = "Interior Painting", StartDate = new DateTime(2025, 06, 02), EndDate = new DateTime(2025, 06, 05), Duration = "4 days", Progress = 0, ParentId = 22, Predecessor = "23" }, // Not started
                new TaskData() { TaskId = 25, TaskName = "Flooring Installation", StartDate = new DateTime(2025, 06, 06), EndDate = new DateTime(2025, 06, 09), Duration = "4 days", Progress = 0, ParentId = 22, Predecessor = "24" }, // Not started
                new TaskData() { TaskId = 26, TaskName = "Cabinet and Fixture Setup", StartDate = new DateTime(2025, 06, 10), EndDate = new DateTime(2025, 06, 12), Duration = "3 days", Progress = 0, ParentId = 22, Predecessor = "25" }, // Not started
                new TaskData() { TaskId = 27, TaskName = "Final Fixture Installation", StartDate = new DateTime(2025, 06, 13), EndDate = new DateTime(2025, 06, 15), Duration = "3 days", Progress = 0, ParentId = 22, Predecessor = "26" }, // Not started
                new TaskData() { TaskId = 28, TaskName = "Exterior Finishing", StartDate = new DateTime(2025, 06, 16), EndDate = new DateTime(2025, 06, 19), Duration = "4 days", Progress = 0, Predecessor = "27" }, // Not started
                new TaskData() { TaskId = 29, TaskName = "Landscaping", StartDate = new DateTime(2025, 06, 20), EndDate = new DateTime(2025, 06, 25), Duration = "5 days", Progress = 0, Predecessor = "28" }, // Not started
                new TaskData() { TaskId = 30, TaskName = "Final Inspection", StartDate = new DateTime(2025, 06, 26), EndDate = new DateTime(2025, 06, 30), Duration = "3 days", Progress = 0, Predecessor = "29" }, // Not started
                new TaskData() { TaskId = 31, TaskName = "Correction of Issues", StartDate = new DateTime(2025, 07, 01), EndDate = new DateTime(2025, 07, 03), Duration = "3 days", Progress = 0, Predecessor = "30" }, // Not started
                new TaskData() { TaskId = 32, TaskName = "Final Walkthrough", StartDate = new DateTime(2025, 07, 04), EndDate = new DateTime(2025, 07, 07), Duration = "2 days", Progress = 0, Predecessor = "31" }, // Not started
                new TaskData() { TaskId = 33, TaskName = "Handover Preparation", StartDate = new DateTime(2025, 07, 08), EndDate = new DateTime(2025, 07, 10), Duration = "3 days", Progress = 0, Predecessor = "32" }, // Not started
                new TaskData() { TaskId = 34, TaskName = "Client Handover", StartDate = new DateTime(2025, 07, 11), EndDate = new DateTime(2025, 07, 12), Duration = "2 days", Progress = 0, Predecessor = "33" }, // Not started
                new TaskData() { TaskId = 35, TaskName = "Warranty Period Begins", StartDate = new DateTime(2025, 07, 14), EndDate = new DateTime(2025, 07, 15), Duration = "2 days", Progress = 0, Predecessor = "34" }, // Not started
                new TaskData() { TaskId = 36, TaskName = "Routine Maintenance Visits", StartDate = new DateTime(2025, 07, 16), EndDate = new DateTime(2025, 07, 25), Duration = "10 days", Progress = 0, Predecessor = "35" }, // Not started
                new TaskData() { TaskId = 37, TaskName = "First Year Warranty Review", StartDate = new DateTime(2025, 07, 28), EndDate = new DateTime(2025, 08, 01), Duration = "5 days", Progress = 0, Predecessor = "36" }, // Not started
                new TaskData() { TaskId = 38, TaskName = "Final Project Documentation", StartDate = new DateTime(2025, 08, 04), EndDate = new DateTime(2025, 08, 06), Duration = "3 days", Progress = 0, Predecessor = "37" }, // Not started
                new TaskData() { TaskId = 39, TaskName = "Celebrate Project Completion", StartDate = new DateTime(2025, 08, 07), EndDate = new DateTime(2025, 08, 09), Duration = "3 days", Progress = 0, Predecessor = "38" }, // Not started
                new TaskData() { TaskId = 40, TaskName = "Begin Next Project Planning", StartDate = new DateTime(2025, 08, 10), EndDate = new DateTime(2025, 08, 13), Duration = "4 days", Progress = 0, Predecessor = "39" } // Not started
            };
            return Tasks;
        }
        
    }
}