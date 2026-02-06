#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;


namespace TreeFieldServiceScheduleData
{
    public class FieldServiceScheduleData
    {
        // Unique identifier for each task/node
        public int TaskId { get; set; }

        // Parent task identifier; null for root items
        public int? ParentId { get; set; }

        // Display name of the task or phase
        public string TaskName { get; set; } = string.Empty;

        // Calendar date of the task start (DateOnly for date precision)
        public DateOnly StartDate { get; set; }

        // Calendar date of the task end (DateOnly for date precision)
        public DateOnly EndDate { get; set; }

        // Time of day the task starts (TimeOnly for time precision)
        public TimeOnly StartTime { get; set; }

        // Duration in days for simplicity
        public int Duration { get; set; }

        // Simple progress/status text (e.g., Planned, In Progress, Completed)
        public string Progress { get; set; } = string.Empty;

        // Minimal stub to keep backward compatibility with samples calling GetWrapData()
        // InlineEditing.razor now builds a realistic dataset via BuildProjectWbsData(),
        // but this method prevents compile failures for other samples.
        public static IEnumerable<FieldServiceScheduleData> GetWrapData()
        {
            return new List<FieldServiceScheduleData>
            {
                new FieldServiceScheduleData
                {
                    TaskId = 1000,
                    ParentId = null,
                    TaskName = "Sample Root",
                    StartDate = DateOnly.FromDateTime(DateTime.Today),
                    EndDate = DateOnly.FromDateTime(DateTime.Today).AddDays(1),
                    StartTime = new TimeOnly(9, 0, 0),
                    Duration = 1,
                    Progress = "Planned"
                }
            };
        }

        // Real-world Field Service schedule: Region -> Technician -> Work Order -> Task
        public static IEnumerable<FieldServiceScheduleData> GetFieldServiceScheduleData()
        {
            var start = new DateOnly(2025, 2, 3);
            TimeOnly t0800 = new TimeOnly(8, 0, 0);
            TimeOnly t1000 = new TimeOnly(10, 0, 0);

            int id = 1000;
            var list = new List<FieldServiceScheduleData>();

            // Helper local function to add a work order with two tasks under a technician
            void AddWO(int techId, string woCode, DateOnly day)
            {
                var woId = ++id;
                list.Add(new FieldServiceScheduleData { TaskId = woId, ParentId = techId, TaskName = woCode, StartDate = day, EndDate = day.AddDays(1), StartTime = t0800, Duration = 1, Progress = "Assigned" });
                // Mark some tasks as Completed to reflect progress
                list.Add(new FieldServiceScheduleData { TaskId = ++id, ParentId = woId, TaskName = "Initial check & safety", StartDate = day, EndDate = day.AddDays(1), StartTime = t0800, Duration = 1, Progress = "Completed" });
                list.Add(new FieldServiceScheduleData { TaskId = ++id, ParentId = woId, TaskName = "Task execution", StartDate = day, EndDate = day.AddDays(1), StartTime = t1000, Duration = 1, Progress = "In Progress" });
            }

            // Regions
            var northId = id++;
            list.Add(new FieldServiceScheduleData { TaskId = northId, ParentId = null, TaskName = "North Region", StartDate = start, EndDate = start.AddDays(5), StartTime = t0800, Duration = 5, Progress = "Scheduled" });
            var southId = id++;
            list.Add(new FieldServiceScheduleData { TaskId = southId, ParentId = null, TaskName = "South Region", StartDate = start, EndDate = start.AddDays(5), StartTime = t0800, Duration = 5, Progress = "Scheduled" });

            // Technicians (4 per region)
            var techs = new List<int>();
            string[] northTechNames = { "Tech: Alice Chen", "Tech: Mark Diaz", "Tech: Victor Lee", "Tech: Sara Park" };
            string[] southTechNames = { "Tech: Priya Singh", "Tech: John Miller", "Tech: Emily Stone", "Tech: Omar Haddad" };

            foreach (var name in northTechNames)
            {
                var tid = id++;
                techs.Add(tid);
                list.Add(new FieldServiceScheduleData { TaskId = tid, ParentId = northId, TaskName = name, StartDate = start, EndDate = start.AddDays(5), StartTime = t0800, Duration = 5, Progress = "On Duty" });
            }
            foreach (var name in southTechNames)
            {
                var tid = id++;
                techs.Add(tid);
                list.Add(new FieldServiceScheduleData { TaskId = tid, ParentId = southId, TaskName = name, StartDate = start, EndDate = start.AddDays(5), StartTime = t0800, Duration = 5, Progress = "On Duty" });
            }

            // For each technician, create 3 work orders across 3 days, each with 2 tasks
            int woNumber = 10010;
            foreach (var tid in techs)
            {
                AddWO(tid, $"WO-{woNumber++} - HVAC Maintenance", start);
                AddWO(tid, $"WO-{woNumber++} - Thermostat Install", start.AddDays(1));
                AddWO(tid, $"WO-{woNumber++} - Seasonal Tune-up", start.AddDays(2));
            }

            // Ensure we have at least 60 records; this setup yields 2 regions + 8 techs + 24 WOs + 48 tasks = 82
            return list;
        }
    }
}
