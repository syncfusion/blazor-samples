using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class GanttContextMenu
    {
        internal SfGantt<GanttData.TaskData>? GanttInstance { get; set; }
        internal List<GanttData.TaskData> TaskCollection { get; set; } = new List<GanttData.TaskData>();

        /// <summary>
        /// Initializes the Context Menu sample with editable Gantt task data.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = GanttData.EditingData();
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Handles the row creation event in the Gantt Chart and sets a default task name when a new row is added.
        /// </summary>
        private static async Task HandleRowCreating(GanttRowCreatingEventArgs<GanttData.TaskData> args)
        {
            if (args?.Data is not null)
            {
                args.Data.TaskName = "New Task " + args.Data.TaskId;
            }
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}
