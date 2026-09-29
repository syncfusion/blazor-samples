using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class SplitTasks
    {
        internal SfGantt<SplitTasksData.TaskData>? GanttInstance { get; set; }
        internal List<SplitTasksData.TaskData> TaskCollection { get; set; } = new List<SplitTasksData.TaskData>();
        internal List<SplitTasksData.SegmentModel> SegmentCollection { get; set; } = new List<SplitTasksData.SegmentModel>();

        /// <summary>
        /// Initializes the Split Tasks sample with task and segment data.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = SplitTasksData.GetTaskCollection();
            SegmentCollection = SplitTasksData.GetSegmentCollection();
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}
