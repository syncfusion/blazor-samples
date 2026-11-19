using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using BlazorDemos.Shared;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class UnscheduledTask
    {
        internal SfGantt<UnscheduleData.TaskData>? GanttInstance { get; set; }
        internal List<UnscheduleData.TaskData> TaskCollection { get; set; } = new List<UnscheduleData.TaskData>();

        /// <summary>
        /// Initializes the sample by loading task data for the Gantt chart.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = UnscheduleData.GetTaskCollection();
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}
