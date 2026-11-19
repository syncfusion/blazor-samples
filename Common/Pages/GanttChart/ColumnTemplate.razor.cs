using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class ColumnTemplate
    {
        internal List<ColumnTemplateData.TaskData> TaskCollection { get; set; } = new List<ColumnTemplateData.TaskData>();
        internal SfGantt<ColumnTemplateData.TaskData>? GanttInstance { get; set; }

        /// <summary>
        /// Initializes the sample by loading task data for the Gantt chart.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = ColumnTemplateData.GetTaskCollection();
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}
