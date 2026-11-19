using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class Zooming
    {
        internal SfGantt<ZoomingData.TaskData>? GanttInstance { get; set; }
        internal List<ZoomingData.TaskData> TaskCollection { get; set; } = new List<ZoomingData.TaskData>();

        /// <summary>
        /// Initializes the sample by loading task data for the critical path Gantt chart.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = ZoomingData.ZoomData();
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}
