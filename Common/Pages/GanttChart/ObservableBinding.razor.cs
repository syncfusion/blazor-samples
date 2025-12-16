#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Grids;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class ObservableBinding
    {
        public SfGantt<ObservableBindingData.TaskData>? GanttInstance { get; set; }
        public ObservableCollection<ObservableBindingData.TaskData> ObservableData { get; set; }
        private int recordId = 0;
        private int taskId;       

        /// <summary>
        /// Handles the row update event and stores the updated task ID.
        /// </summary>
        public async Task RowUpdated(RowUpdatedEventArgs<ObservableBindingData.TaskData> args)
        {
            taskId = args.Data.TaskId;
            await Task.CompletedTask;
        }

        /// <summary>
        /// Adds a new task record to the observable collection.
        /// </summary>
        public void AddRecord()
        {
            if (ObservableData.Count() != 0)
            {
                recordId = ObservableData.Max(data => data.TaskId);
                recordId = Math.Max(recordId, taskId);
            }
            recordId++;
            ObservableData.Insert(0, new ObservableBindingData.TaskData() { TaskId = recordId, TaskName = "New Task", StartDate = new DateTime(2021, 04, 04), Duration = "4" });
        }

        /// <summary>
        /// Deletes the first task record and its child records from the observable collection.
        /// </summary>
        public void DeleteRecord()
        {
            if (ObservableData.Count() != 0)
            {
                int deleteRecordTaskId = ObservableData.First().TaskId;
                ObservableData.Remove(ObservableData.First());
                RemoveChild(deleteRecordTaskId);
            }
        }

        /// <summary>
        /// Recursively removes child records associated with the specified parent task ID.
        /// </summary>
        public void RemoveChild(int id)
        {
            ObservableCollection<ObservableBindingData.TaskData> childRecords = new ObservableCollection<ObservableBindingData.TaskData>();
            for (int j = 0; j < ObservableData.Count(); j++)
            {
                if (id == ObservableData[j].ParentId)
                    childRecords.Add(ObservableData[j]);
            }

            for (int i = childRecords.Count() - 1; i >= 0; i--)
            {
                int deleteRcordid = childRecords[i].TaskId;
                RemoveChild(deleteRcordid);
                ObservableData.Remove(childRecords[i]);
            }
        }

        /// <summary>
        /// Updates the name of the first task record in the observable collection.
        /// </summary>
        public void UpdateRecord()
        {
            if (ObservableData.Count() != 0)
            {
                var name = ObservableData.First();
                name.TaskName = "Record Updated";
            }
        }
    }
}
