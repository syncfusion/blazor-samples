#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class ExpandoData
    {
        public SfGantt<ExpandoObject>? GanttInstance { get; set; }
        public static List<ExpandoObject> GanttData { get; set; } = new List<ExpandoObject>();
        public List<ExpandoObject> GanttExpandoData { get; set; } = new List<ExpandoObject>();
        private static int parentRecordID;
        private static int childRecordID;        

        /// <summary>
        /// Generates a list of parent and child tasks using ExpandoObject for Gantt binding.
        /// </summary>
        public static List<ExpandoObject> GetData()
        {
            GanttData.Clear();
            parentRecordID = 0;
            childRecordID = 0;
            for (var i = 1; i <= 5; i++)
            {
                DateTime start = new DateTime(2021, 01, 10);
                int range = (DateTime.Today - start).Days;
                DateTime startingDate = start;
                DateTime endingDate = startingDate.AddDays(2);
                dynamic ParentRecord = new ExpandoObject();
                ParentRecord.TaskId = ++parentRecordID;
                ParentRecord.TaskName = "Parent task " + i;
                ParentRecord.StartDate = startingDate;
                ParentRecord.EndDate = endingDate;
                ParentRecord.Progress = 30;
                ParentRecord.Duration = parentRecordID % 2 == 0 ? (4).ToString() : (8).ToString();
                ParentRecord.ParentId = null;
                GanttData.Add(ParentRecord);
                AddChildRecords(parentRecordID);
            }
            return GanttData;
        }

        /// <summary>
        /// Adds child tasks to the specified parent task using ExpandoObject.
        /// </summary>
        public static void AddChildRecords(int ParentId)
        {
            for (var i = 1; i < 4; i++)
            {
                DateTime start = new DateTime(2021, 01, 10);
                int range = (DateTime.Today - start).Days;
                DateTime startingDate = start;
                DateTime endingDate = startingDate.AddDays(2);
                dynamic ChildRecord = new ExpandoObject();
                ChildRecord.TaskId = ++parentRecordID;
                ChildRecord.TaskName = "Child task " + ++childRecordID;
                ChildRecord.StartDate = startingDate;
                ChildRecord.EndDate = endingDate;
                ChildRecord.Progress = 40;
                ChildRecord.Duration = parentRecordID % 3 == 0 ? (3).ToString() : (6).ToString();
                ChildRecord.ParentId = ParentId;
                GanttData.Add(ChildRecord);
            }
        }
    }
}
