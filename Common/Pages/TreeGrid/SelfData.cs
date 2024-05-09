#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace ej2_blazor_selfdata
{
    public class SelfReferenceData
    {
        public static List<SelfReferenceData> tree = new List<SelfReferenceData>();
        [Key]
        public int? TaskID { get; set; }
        public string TaskName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public String Progress { get; set; }
        public String Priority { get; set; }
        public double? Duration { get; set; }
        public int? ParentID { get; set; }
        public bool? IsParent { get; set; }
        public bool? Approved { get; set; }
        public int? ParentItem { get; set; }
        public SelfReferenceData() { }
        public static List<SelfReferenceData> GetTree()
        {
            tree.Clear();
            int root = -1;
            int TaskNameID = 0;
            int ChildCount = -1;
            int SubTaskCount = -1;
            for (var t = 1; t <= 60; t++)
            {
                DateTime start = new DateTime(2022, 08, 25);
                DateTime end = new DateTime(2027, 08, 25);
                DateTime startingDate = start.AddDays(t+2);
                DateTime endingDate = end.AddDays(t+20);
                string math = "";
                string progr = "";
                bool appr = true;
                int duration = 0;
                duration = (t % 2 == 0) ? 52 : (t % 5 == 0) ? 14 : (t % 3 == 0) ? 25 : 34;
                math = (t % 3) == 0 ? "High" : (t % 2) == 0 ? "Low" : "Critical";
                progr = (t % 3) == 0 ? "Started" : (t % 2) == 0 ? "Open" : "In Progress";
                appr = (t % 3) == 0 ? true : (t % 2) == 0 ? false : true;

                root++; TaskNameID++;
                int rootItem = root + 1;
                tree.Add(new SelfReferenceData() { TaskID = rootItem, TaskName = "Parent task " + TaskNameID.ToString(), StartDate = startingDate, EndDate = endingDate, IsParent = true, ParentID = null, Progress = progr, Priority = math, Duration = duration, Approved = appr });

                int parent = tree.Count;
                for (var c = 0; c < 2; c++)
                {
                    DateTime start1 = new DateTime(2022, 08, 25);
                    DateTime startingDate1 = start1.AddDays(c+4);
                    DateTime end1 = new DateTime(2025, 06, 16);
                    DateTime endingDate1 = end1.AddDays(c+15);
                    root++; ChildCount++;
                    int parn = parent + c + 1;
                    string val = "";
                    duration = (c % 3 == 0) ? 1 : (c % 2 == 0) ? 12 : 98;
                    val = ((parent + c + 1) % 3 == 0) ? "Low" : "Critical";
                    progr = ((c + 1) % 3) == 0 ? "In Progress" : ((c + 1) % 2) == 0 ? "Open" : "Validated";
                    appr = ((c + 1) % 3) == 0 ? true : ((c + 3) % 2) == 0 ? false : true;
                    int iD = root + 1;
                    tree.Add(new SelfReferenceData() { TaskID = iD, TaskName = "Child task " + (ChildCount + 1).ToString(), StartDate = startingDate1, EndDate = endingDate1, IsParent = (((parent + c + 1) % 3) == 0), ParentID = rootItem, Progress = progr, Priority = val, Duration = duration, Approved = appr });

                    if ((((parent + c + 1) % 3) == 0))
                    {
                        int immParent = tree.Count;
                        for (var s = 0; s < 3; s++)
                        {
                            DateTime start2 = new DateTime(2022, 08, 25);
                            DateTime startingDate2 = start2.AddDays(s+4);
                            DateTime end2 = new DateTime(2024, 06, 16);
                            DateTime endingDate2 = end2.AddDays(s+13);
                            root++; SubTaskCount++;
                            duration = (s % 2 == 0) ? 67 : 14;
                            string Prior = (immParent % 2 == 0) ? "Validated" : "Normal";
                            tree.Add(new SelfReferenceData() { TaskID = root + 1, TaskName = "Sub task " + (SubTaskCount + 1).ToString(), StartDate = startingDate2, EndDate = endingDate2, IsParent = false, ParentID = iD, Progress = (immParent % 2 == 0) ? "In Progress" : "Closed", Priority = Prior, Duration = duration, Approved = appr });
                        }
                    }
                }
            }
            return tree;
        }
    }
}
