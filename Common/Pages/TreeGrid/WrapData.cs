#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
namespace TreeWrapdata
{
    public class WrapData
    {
        public int? TaskId { get; set; }
        public string? TaskName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Duration { get; set; }
        public string? Progress { get; set; }
        public string? Priority { get; set; }
        public bool Approved { get; set; }
        public int Resources { get; set; }
        public int? ParentId { get; set; }
        public static List<WrapData> GetWrapData()
        {
            List<WrapData> BusinessObjectCollection = new List<WrapData>();
            // === PLANNING (March - July 2025) ===
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4871,
                TaskName = "Planning",
                StartDate = new DateTime(2025, 3, 2),
                EndDate = new DateTime(2025, 7, 11),
                Progress = "Open",
                Duration = 132, // Mar 2 ? Jul 11
                Priority = "Normal",
                Resources = 6,
                Approved = false,
                ParentId = null
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4872,
                TaskName = "Plan timeline",
                StartDate = new DateTime(2025, 3, 4),
                EndDate = new DateTime(2025, 3, 8),
                Progress = "In Progress",
                Duration = 5,
                Resources = 4,
                Priority = "Normal",
                Approved = false,
                ParentId = 4871
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4873,
                TaskName = "Plan budget",
                StartDate = new DateTime(2025, 3, 6),
                EndDate = new DateTime(2025, 3, 10),
                Duration = 5,
                Progress = "Started",
                Approved = true,
                Resources = 6,
                Priority = "Low",
                ParentId = 4871
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4874,
                TaskName = "Allocate resources",
                StartDate = new DateTime(2025, 3, 8),
                EndDate = new DateTime(2025, 3, 12),
                Duration = 5,
                Progress = "Open",
                Priority = "Critical",
                Resources = 3,
                Approved = false,
                ParentId = 4871
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4875,
                TaskName = "Planning complete",
                StartDate = new DateTime(2025, 7, 10),
                EndDate = new DateTime(2025, 7, 11),
                Duration = 2,
                Progress = "Open",
                Priority = "Low",
                Resources = 5,
                ParentId = 4871,
                Approved = true
            });
            // === DESIGN (July - September 2025) ===
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4876,
                TaskName = "Design",
                StartDate = new DateTime(2025, 7, 15),
                EndDate = new DateTime(2025, 9, 20),
                Progress = "In Progress",
                Duration = 68,
                Priority = "High",
                Resources = 4,
                Approved = false,
                ParentId = null
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4877,
                TaskName = "Software specification",
                StartDate = new DateTime(2025, 7, 16),
                EndDate = new DateTime(2025, 7, 25),
                Duration = 10,
                Progress = "Started",
                Resources = 3,
                Priority = "Normal",
                ParentId = 4876,
                Approved = false
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4878,
                TaskName = "Develop prototype",
                StartDate = new DateTime(2025, 7, 26),
                EndDate = new DateTime(2025, 8, 10),
                Duration = 16,
                Progress = "In Progress",
                Resources = 2,
                Priority = "Critical",
                ParentId = 4876,
                Approved = false
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4879,
                TaskName = "Get approval from customer",
                StartDate = new DateTime(2025, 8, 11),
                EndDate = new DateTime(2025, 8, 15),
                Duration = 5,
                Progress = "In Progress",
                Resources = 3,
                Priority = "Low",
                Approved = true,
                ParentId = 4876
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4880,
                TaskName = "Design complete",
                StartDate = new DateTime(2025, 9, 18),
                EndDate = new DateTime(2025, 9, 20),
                Duration = 3,
                Progress = "In Progress",
                Resources = 6,
                Priority = "Normal",
                ParentId = 4876,
                Approved = true
            });
            // === IMPLEMENTATION (September - December 2025) ===
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4881,
                TaskName = "Implementation phase",
                StartDate = new DateTime(2025, 9, 21),
                EndDate = new DateTime(2025, 12, 31),
                Priority = "Normal",
                Approved = false,
                Duration = 102,
                Resources = 5,
                Progress = "Started",
                ParentId = null
            });
            // Phase 1
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4882,
                TaskName = "Phase 1",
                StartDate = new DateTime(2025, 9, 22),
                EndDate = new DateTime(2025, 10, 15),
                Priority = "High",
                Approved = false,
                Duration = 24,
                Progress = "Open",
                Resources = 4,
                ParentId = 4881
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4883,
                TaskName = "Implementation module 1",
                StartDate = new DateTime(2025, 9, 23),
                EndDate = new DateTime(2025, 10, 14),
                Priority = "Normal",
                Duration = 22,
                Progress = "Started",
                Resources = 3,
                Approved = false,
                ParentId = 4882
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4884,
                TaskName = "Development task 1",
                StartDate = new DateTime(2025, 9, 24),
                EndDate = new DateTime(2025, 9, 28),
                Duration = 5,
                Progress = "In Progress",
                Priority = "High",
                Resources = 2,
                ParentId = 4883,
                Approved = false
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4885,
                TaskName = "Development task 2",
                StartDate = new DateTime(2025, 9, 29),
                EndDate = new DateTime(2025, 10, 3),
                Duration = 5,
                Progress = "Closed",
                Priority = "Low",
                Resources = 5,
                ParentId = 4883,
                Approved = true
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4886,
                TaskName = "Testing",
                StartDate = new DateTime(2025, 10, 4),
                EndDate = new DateTime(2025, 10, 7),
                Duration = 4,
                Progress = "Closed",
                Priority = "Normal",
                ParentId = 4883,
                Resources = 1,
                Approved = true
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4887,
                TaskName = "Bug fix",
                StartDate = new DateTime(2025, 10, 8),
                EndDate = new DateTime(2025, 10, 10),
                Duration = 3,
                Progress = "Validated",
                Priority = "Critical",
                ParentId = 4883,
                Resources = 6,
                Approved = false
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4888,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2025, 10, 11),
                EndDate = new DateTime(2025, 10, 14),
                Duration = 4,
                Progress = "Open",
                Priority = "High",
                ParentId = 4883,
                Resources = 6,
                Approved = false
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4889,
                TaskName = "Phase 1 complete",
                StartDate = new DateTime(2025, 10, 14),
                EndDate = new DateTime(2025, 10, 15),
                Duration = 2,
                Progress = "Closed",
                Priority = "Low",
                ParentId = 4883,
                Resources = 5,
                Approved = true
            });
            // Phase 2
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4890,
                TaskName = "Phase 2",
                StartDate = new DateTime(2025, 10, 16),
                EndDate = new DateTime(2025, 11, 15),
                Priority = "High",
                Approved = false,
                Progress = "Open",
                ParentId = 4881,
                Resources = 3,
                Duration = 31
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4891,
                TaskName = "Implementation module 2",
                StartDate = new DateTime(2025, 10, 17),
                EndDate = new DateTime(2025, 11, 14),
                Priority = "Critical",
                Approved = false,
                Progress = "In Progress",
                ParentId = 4890,
                Resources = 3,
                Duration = 29
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4892,
                TaskName = "Development task 1",
                StartDate = new DateTime(2025, 10, 18),
                EndDate = new DateTime(2025, 10, 25),
                Duration = 8,
                Progress = "Closed",
                Priority = "Normal",
                ParentId = 4891,
                Resources = 2,
                Approved = true
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4893,
                TaskName = "Development task 2",
                StartDate = new DateTime(2025, 10, 26),
                EndDate = new DateTime(2025, 11, 2),
                Duration = 8,
                Progress = "Closed",
                Priority = "Critical",
                ParentId = 4891,
                Resources = 5,
                Approved = true
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4894,
                TaskName = "Testing",
                StartDate = new DateTime(2025, 11, 3),
                EndDate = new DateTime(2025, 11, 6),
                Duration = 4,
                Progress = "Open",
                Priority = "High",
                ParentId = 4891,
                Resources = 3,
                Approved = false
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4895,
                TaskName = "Bug fix",
                StartDate = new DateTime(2025, 11, 7),
                EndDate = new DateTime(2025, 11, 10),
                Duration = 4,
                Progress = "Validated",
                Priority = "Low",
                Approved = false,
                Resources = 6,
                ParentId = 4891
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4896,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2025, 11, 11),
                EndDate = new DateTime(2025, 11, 14),
                Duration = 4,
                Progress = "In Progress",
                Priority = "Critical",
                ParentId = 4891,
                Resources = 4,
                Approved = true
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4897,
                TaskName = "Phase 2 complete",
                StartDate = new DateTime(2025, 11, 14),
                EndDate = new DateTime(2025, 11, 15),
                Duration = 2,
                Priority = "Normal",
                Progress = "Open",
                ParentId = 4891,
                Resources = 3,
                Approved = false
            });
            // Phase 3
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4898,
                TaskName = "Phase 3",
                StartDate = new DateTime(2025, 11, 16),
                EndDate = new DateTime(2025, 12, 20),
                Priority = "Normal",
                Approved = false,
                Duration = 35,
                Progress = "In Progress",
                Resources = 4,
                ParentId = 4881
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4899,
                TaskName = "Implementation module 3",
                StartDate = new DateTime(2025, 11, 17),
                EndDate = new DateTime(2025, 12, 19),
                Priority = "High",
                Approved = false,
                Duration = 33,
                Resources = 5,
                Progress = "Validated",
                ParentId = 4898
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4900,
                TaskName = "Development task 1",
                StartDate = new DateTime(2025, 11, 18),
                EndDate = new DateTime(2025, 11, 25),
                Duration = 8,
                Progress = "Closed",
                Priority = "Low",
                Approved = true,
                Resources = 3,
                ParentId = 4899
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4901,
                TaskName = "Development task 2",
                StartDate = new DateTime(2025, 11, 26),
                EndDate = new DateTime(2025, 12, 3),
                Duration = 8,
                Progress = "Closed",
                Priority = "Normal",
                Approved = false,
                Resources = 2,
                ParentId = 4899
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4902,
                TaskName = "Testing",
                StartDate = new DateTime(2025, 12, 4),
                EndDate = new DateTime(2025, 12, 10),
                Duration = 7,
                Progress = "Closed",
                Priority = "Critical",
                ParentId = 4899,
                Resources = 4,
                Approved = true
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4903,
                TaskName = "Bug fix",
                StartDate = new DateTime(2025, 12, 11),
                EndDate = new DateTime(2025, 12, 15),
                Duration = 5,
                Progress = "Open",
                Priority = "High",
                Approved = false,
                Resources = 3,
                ParentId = 4899
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4904,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2025, 12, 16),
                EndDate = new DateTime(2025, 12, 19),
                Duration = 4,
                Progress = "In Progress",
                Priority = "Normal",
                ParentId = 4899,
                Resources = 6,
                Approved = true
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4905,
                TaskName = "Phase 3 complete",
                StartDate = new DateTime(2025, 12, 19),
                EndDate = new DateTime(2025, 12, 20),
                Duration = 2,
                Priority = "Critical",
                Progress = "Open",
                Resources = 5,
                ParentId = 4899,
                Approved = false
            });
            return BusinessObjectCollection;
        }
    }
}