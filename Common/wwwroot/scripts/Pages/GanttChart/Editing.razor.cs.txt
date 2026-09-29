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
    public sealed partial class Editing
    {
        internal SfGantt<GanttData.TaskData>? GanttInstance { get; set; }
        internal List<GanttData.TaskData> TaskCollection { get; set; } = new List<GanttData.TaskData>();

        /// <summary>
        /// Initializes the Gantt chart with Editing task data.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = GanttData.EditingData().ToList();
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}
