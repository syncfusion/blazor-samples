#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
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
    public partial class DynamicData
    {
        public SfGantt<DynamicDictionary>? GanttInstance { get; set; }
        public static List<DynamicDictionary> GanttData { get; set; } = new List<DynamicDictionary>();
        public List<DynamicDictionary> GanttDynamicData { get; set; } = new List<DynamicDictionary>();
        private static int parentRecordID;
        private static int childRecordID;

        /// <summary>
        /// Generates the dynamic data for the Gantt chart.
        /// </summary>
        public static List<DynamicDictionary> GetData()
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
                dynamic ParentRecord = new DynamicDictionary();
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
        /// Adds child records to the specified parent task.
        /// </summary>
        public static void AddChildRecords(int ParentId)
        {
            for (var i = 1; i < 4; i++)
            {
                DateTime start = new DateTime(2021, 01, 10);
                int range = (DateTime.Today - start).Days;
                DateTime startingDate = start;
                DateTime endingDate = startingDate.AddDays(2);
                dynamic ChildRecord = new DynamicDictionary();
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

        /// <summary>
        /// Represents a dynamic dictionary used for binding data to the Gantt chart.
        /// </summary
        public class DynamicDictionary : DynamicObject
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();

            /// <summary>
            /// Retrieves the value of a dynamic member.
            /// </summary>
            public override bool TryGetMember(GetMemberBinder binder, out object result)
            {
                string name = binder.Name;
                return dictionary.TryGetValue(name, out result);
            }

            /// <summary>
            /// Sets the value of a dynamic member.
            /// </summary>
            public override bool TrySetMember(SetMemberBinder binder, object? value)
            {
                dictionary[binder.Name] = value!;
                return true;
            }

            /// <summary>
            /// Returns the names of all dynamic members in the dictionary.
            /// </summary>
            public override System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames()
            {
                return dictionary?.Keys;
            }
        }
    }
}
