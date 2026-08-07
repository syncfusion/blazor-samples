using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class DynamicData
    {
        internal SfGantt<DynamicDictionary>? GanttInstance { get; set; }
        internal static List<DynamicDictionary> GanttData { get; set; } = new List<DynamicDictionary>();
        internal List<DynamicDictionary> GanttDynamicData { get; set; } = new List<DynamicDictionary>();
        private static int parentRecordID;
        private static int childRecordID;

        /// <summary>
        /// Initializes the sample by generating dynamic Gantt data.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            GanttDynamicData = GetData().ToList();
            await Task.CompletedTask.ConfigureAwait(true);

        }
        /// <summary>
        /// Generates the dynamic data for the Gantt chart.
        /// </summary>
        private static List<DynamicDictionary> GetData()
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
                ParentRecord.Duration = parentRecordID % 2 == 0 ? (4).ToString(CultureInfo.InvariantCulture) : (8).ToString(CultureInfo.InvariantCulture);
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
                ChildRecord.Duration = parentRecordID % 3 == 0 ? (3).ToString(CultureInfo.InvariantCulture) : (6).ToString(CultureInfo.InvariantCulture);
                ChildRecord.ParentId = ParentId;
                GanttData.Add(ChildRecord);
            }
        }

        /// <summary>
        /// Represents a dynamic dictionary used for binding data to the Gantt chart.
        /// </summary
        internal sealed class DynamicDictionary : DynamicObject
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();

            /// <summary>
            /// Retrieves the value of a dynamic member.
            /// </summary>
            public override bool TryGetMember(GetMemberBinder binder, out object? result)
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
                return dictionary.Keys;
            }
        }
    }
}
