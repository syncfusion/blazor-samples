using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public class Weeks
    {
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
    }
    public sealed partial class WorkWeek
    {
        internal SfGantt<WorkData.TaskData>? GanttInstance { get; set; }
        internal List<WorkData.TaskData> TaskCollection { get; set; } = new List<WorkData.TaskData>();

        /// <summary>
        /// Initializes the sample by loading task data for the Gantt chart.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = WorkData.GetTaskCollection();
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}
