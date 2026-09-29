using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;
using GanttTaskData = BlazorDemos.Pages.GanttChart.Data.GanttDefaultTaskData;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class ColumnReordering
    {
        internal SfGantt<GanttTaskData>? GanttInstance { get; set; }
        internal List<GanttTaskData> TaskCollection { get; set; } = new List<GanttTaskData>();

        /// <summary>
        /// Initializes the sample by loading task data for the Gantt chart.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = DefaultData.ProjectNewData();
            await Task.CompletedTask.ConfigureAwait(true);

        }
    }
}
