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

namespace ej2_blazor_wrapdata
{
    public class WrapData
    {
        public int? TaskId { get; set; }
        public string TaskName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Duration { get; set; }
        public String Progress { get; set; }
        public string Priority { get; set; }
        public bool Approved { get; set; }
        public int Resources { get; set; }
        public int? ParentId { get; set; }
        public static List<WrapData> GetWrapData()
        {
            List<WrapData> BusinessObjectCollection = new List<WrapData>();

            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 1,
                TaskName = "Planning",
                StartDate = new DateTime(2021, 03, 02),
                EndDate = new DateTime(2021, 07, 03),
                Progress = "Open",
                Duration = 5,
                Priority = "Normal",
                Resources = 6,
                Approved = false,
                ParentId = null
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 2,
                TaskName = "Plan timeline",
                StartDate = new DateTime(2021, 03, 04),
                EndDate = new DateTime(2021, 07, 05),
                Progress = "In Progress",
                Duration = 5,
                Resources = 4,
                Priority = "Normal",
                Approved = false,
                ParentId = 1
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 3,
                TaskName = "Plan budget",
                StartDate = new DateTime(2021, 03, 06),
                EndDate = new DateTime(2021, 07, 07),
                Duration = 5,
                Progress = "Started",
                Approved = true,
                Resources = 6,
                Priority = "Low",
                ParentId = 1
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 4,
                TaskName = "Allocate resources",
                StartDate = new DateTime(2021, 03, 08),
                EndDate = new DateTime(2021, 07, 09),
                Duration = 5,
                Progress = "Open",
                Priority = "Critical",
                ParentId = 1,
                Resources = 3,
                Approved = false
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 5,
                TaskName = "Planning complete",
                StartDate = new DateTime(2021, 07, 10),
                EndDate = new DateTime(2021, 07, 11),
                Duration = 1,
                Progress = "Open",
                Priority = "Low",
                Resources = 5,
                ParentId = 1,
                Approved = true
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 6,
                TaskName = "Design",
                StartDate = new DateTime(2021, 10, 12),
                EndDate = new DateTime(2021, 02, 13),
                Progress = "In Progress",
                Duration = 3,
                Priority = "High",
                Resources = 4,
                Approved = false,
                ParentId = null
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 7,
                TaskName = "Software specification",
                StartDate = new DateTime(2021, 10, 14),
                EndDate = new DateTime(2021, 02, 15),
                Duration = 3,
                Progress = "Started",
                Resources = 3,
                Priority = "Normal",
                ParentId = 6,
                Approved = false
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 8,
                TaskName = "Develop prototype",
                StartDate = new DateTime(2021, 10, 16),
                EndDate = new DateTime(2021, 02, 17),
                Duration = 3,
                Progress = "In Progress",
                Resources = 2,
                Priority = "Critical",
                ParentId = 6,
                Approved = false
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 9,
                TaskName = "Get approval from customer",
                StartDate = new DateTime(2021, 02, 18),
                EndDate = new DateTime(2021, 02, 19),
                Duration = 2,
                Progress = "In Progress",
                Resources = 3,
                Priority = "Low",
                Approved = true,
                ParentId = 6
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 10,
                TaskName = "Design complete",
                StartDate = new DateTime(2021, 02, 20),
                EndDate = new DateTime(2021, 02, 21),
                Duration = 1,
                Progress = "In Progress",
                Resources = 6,
                Priority = "Normal",
                ParentId = 6,
                Approved = true
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 12,
                TaskName = "Implementation phase",
                StartDate = new DateTime(2021, 02, 22),
                EndDate = new DateTime(2021, 02, 23),
                Priority = "Normal",
                Approved = false,
                Duration = 11,
                Resources = 5,
                Progress = "Started",
                ParentId = null
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 13,
                TaskName = "Phase 1",
                StartDate = new DateTime(2021, 02, 24),
                EndDate = new DateTime(2021, 02, 25),
                Priority = "High",
                Approved = false,
                Duration = 11,
                Progress = "Open",
                Resources = 4,
                ParentId = 12
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 14,
                TaskName = "Implementation module 1",
                StartDate = new DateTime(2021, 02, 26),
                EndDate = new DateTime(2021, 02, 27),
                Priority = "Normal",
                Duration = 11,
                Progress = "Started",
                Resources = 3,
                Approved = false,
                ParentId = 13
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 15,
                TaskName = "Development task 1",
                StartDate = new DateTime(2021, 06, 18),
                EndDate = new DateTime(2021, 06, 19),
                Duration = 3,
                Progress = "In Progress",
                Priority = "High",
                Resources = 2,
                ParentId = 14,
                Approved = false
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 16,
                TaskName = "Development task 2",
                StartDate = new DateTime(2021, 02, 13),
                EndDate = new DateTime(2021, 03, 01),
                Duration = 3,
                Progress = "Closed",
                Priority = "Low",
                Resources = 5,
                ParentId = 14,
                Approved = true
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 17,
                TaskName = "Testing",
                StartDate = new DateTime(2021, 03, 02),
                EndDate = new DateTime(2021, 03, 03),
                Duration = 2,
                Progress = "Closed",
                Priority = "Normal",
                ParentId = 14,
                Resources = 1,
                Approved = true
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 18,
                TaskName = "Bug fix",
                StartDate = new DateTime(2021, 03, 04),
                EndDate = new DateTime(2021, 03, 05),
                Duration = 2,
                Progress = "Validated",
                Priority = "Critical",
                ParentId = 14,
                Resources = 6,
                Approved = false
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 19,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2021, 03, 06),
                EndDate = new DateTime(2021, 03, 07),
                Duration = 2,
                Progress = "Open",
                Priority = "High",
                ParentId = 14,
                Resources = 6,
                Approved = false
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 20,
                TaskName = "Phase 1 complete",
                StartDate = new DateTime(2021, 04, 27),
                EndDate = new DateTime(2021, 07, 27),
                Duration = 2,
                Progress = "Closed",
                Priority = "Low",
                ParentId = 14,
                Resources = 5,
                Approved = true
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 21,
                TaskName = "Phase 2",
                StartDate = new DateTime(2021, 07, 17),
                EndDate = new DateTime(2021, 09, 28),
                Priority = "High",
                Approved = false,
                Progress = "Open",
                ParentId = 12,
                Resources = 3,
                Duration = 12,
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 22,
                TaskName = "Implementation module 2",
                StartDate = new DateTime(2021, 01, 17),
                EndDate = new DateTime(2021, 02, 28),
                Priority = "Critical",
                Approved = false,
                Progress = "In Progress",
                ParentId = 21,
                Resources =3,
                Duration = 12
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 23,
                TaskName = "Development task 1",
                StartDate = new DateTime(2021, 08, 17),
                EndDate = new DateTime(2021, 09, 20),
                Duration = 4,
                Progress = "Closed",
                Priority = "Normal",
                ParentId = 22,
                Resources =2,
                Approved = true,
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 24,
                TaskName = "Development task 2",
                StartDate = new DateTime(2021, 04, 17),
                EndDate = new DateTime(2021, 03, 20),
                Duration = 4,
                Progress = "Closed",
                Priority = "Critical",
                ParentId = 22,
                Resources = 5,
                Approved = true,
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 25,
                TaskName = "Testing",
                StartDate = new DateTime(2021, 01, 21),
                EndDate = new DateTime(2021, 01, 24),
                Duration = 2,
                Progress = "Open",
                Priority = "High",
                ParentId = 22,
                Resources = 3,
                Approved = false,
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 26,
                TaskName = "Bug fix",
                StartDate = new DateTime(2021, 03, 25),
                EndDate = new DateTime(2021, 08, 26),
                Duration = 2,
                Progress = "Validated",
                Priority = "Low",
                Approved = false,
                Resources =6,
                ParentId = 22
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 27,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2021, 07, 27),
                EndDate = new DateTime(2021, 06, 28),
                Duration = 2,
                Progress = "In Progress",
                Priority = "Critical",
                ParentId = 22,
                Resources =4,
                Approved = true,
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 28,
                TaskName = "Phase 2 complete",
                StartDate = new DateTime(2021, 07, 19),
                EndDate = new DateTime(2021, 05, 28),
                Duration = 2,
                Priority = "Normal",
                Progress = "Open",
                ParentId = 22,
                Resources =3,
                Approved = false,
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 29,
                TaskName = "Phase 3",
                StartDate = new DateTime(2021, 07, 17),
                EndDate = new DateTime(2021, 02, 12),
                Priority = "Normal",
                Approved = false,
                Duration = 11,
                Progress = "In Progress",
                Resources =4,
                ParentId = 12
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 30,
                TaskName = "Implementation module 3",
                StartDate = new DateTime(2021, 08, 17),
                EndDate = new DateTime(2021, 09, 27),
                Priority = "High",
                Approved = false,
                Duration = 11,
                Resources =5,
                Progress = "Validated",
                ParentId = 29,
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 31,
                TaskName = "Development task 1",
                StartDate = new DateTime(2021, 11, 17),
                EndDate = new DateTime(2021, 12, 19),
                Duration = 3,
                Progress = "Closed",
                Priority = "Low",
                Approved = true,
                Resources =3,
                ParentId = 30
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 32,
                TaskName = "Development task 2",
                StartDate = new DateTime(2021, 12, 17),
                EndDate = new DateTime(2021, 02, 19),
                Duration = 3,
                Progress = "Closed",
                Priority = "Normal",
                Approved = false,
                Resources =2,
                ParentId = 30
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 33,
                TaskName = "Testing",
                StartDate = new DateTime(2021, 01, 01),
                EndDate = new DateTime(2021, 07, 21),
                Duration = 2,
                Progress = "Closed",
                Priority = "Critical",
                ParentId = 30,
                Resources =4,
                Approved = true,

            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 34,
                TaskName = "Bug fix",
                StartDate = new DateTime(2021, 01, 24),
                EndDate = new DateTime(2021, 01, 25),
                Duration = 2,
                Progress = "Open",
                Priority = "High",
                Approved = false,
                Resources =3,
                ParentId = 30
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 35,
                TaskName = "Customer review meeting",
                StartDate = new DateTime(2021, 12, 26),
                EndDate = new DateTime(2021, 12, 27),
                Duration = 2,
                Progress = "In Progress",
                Priority = "Normal",
                ParentId = 30,
                Resources = 6,
                Approved = true,
            });
            BusinessObjectCollection.Add(new WrapData()
            {
                TaskId = 36,
                TaskName = "Phase 3 complete",
                StartDate = new DateTime(2021, 05, 27),
                EndDate = new DateTime(2021, 05, 27),
                Duration = 2,
                Priority = "Critical",
                Progress = "Open",
                Resources = 5,
                ParentId = 30,
                Approved = false,
            });
            return BusinessObjectCollection;
        }
    }
}
