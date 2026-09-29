using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class WorkTimeRange
    {
        internal SfGantt<WorkTimeRangeData.TaskData>? GanttInstance { get; set; }
        internal List<WorkTimeRangeData.TaskData> TaskCollection { get; set; } = new List<WorkTimeRangeData.TaskData>();

        /// <summary>
        /// Initializes the sample by loading task data for the Gantt chart.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = WorkTimeRangeData.ProjectNewData();
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}
