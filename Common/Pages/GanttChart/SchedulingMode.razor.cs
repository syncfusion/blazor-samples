using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class SchedulingMode
    {
        internal SfGantt<ScheduleData.TaskData>? GanttInstance { get; set; }
        internal List<ScheduleData.TaskData> TaskCollection { get; set; } = new List<ScheduleData.TaskData>();

        /// <summary>
        /// Initializes the sample by loading task data for the Gantt chart.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = ScheduleData.GetTaskCollection();
            await Task.CompletedTask.ConfigureAwait(true);

        }
    }
}
