using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using BlazorDemos.Shared;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class ExpandoData
    {
        public SfGantt<ExpandoObject>? GanttInstance { get; set; }
        internal static List<ExpandoObject> GanttData { get; set; } = new List<ExpandoObject>();
        internal List<ExpandoObject> GanttExpandoData { get; set; } = new List<ExpandoObject>();
        private static int parentRecordID;
        private static int childRecordID;

        /// <summary>
        /// Initializes the sample by generating ExpandoObject-based Gantt data.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            GanttExpandoData = GetData().ToList();
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Generates a list of parent and child tasks using ExpandoObject for Gantt binding.
        /// </summary>
        private static List<ExpandoObject> GetData()
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
                ParentRecord.Duration = parentRecordID % 2 == 0 ? (4).ToString(CultureInfo.InvariantCulture) : (8).ToString(CultureInfo.InvariantCulture);
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
                ChildRecord.Duration = parentRecordID % 3 == 0 ? (3).ToString(CultureInfo.InvariantCulture) : (6).ToString(CultureInfo.InvariantCulture);
                ChildRecord.ParentId = ParentId;
                GanttData.Add(ChildRecord);
            }
        }
    }
}
