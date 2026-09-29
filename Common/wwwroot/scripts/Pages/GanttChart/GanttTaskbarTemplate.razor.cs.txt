using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class GanttTaskbarTemplate
    {
        internal SfGantt<TaskbarTemplateData.TaskbarData>? GanttInstance { get; set; }
        internal List<TaskbarTemplateData.TaskbarData> TaskCollection { get; set; } = new List<TaskbarTemplateData.TaskbarData>();

        // Define EventDays as a collection for easier management
        private List<(DateTime Date, string Label)> EventDays { get; } = new List<(DateTime, string)>
        {
            (new DateTime(2021, 3, 5, 19, 9, 0), "Performance"),
            (new DateTime(2021, 3, 5, 19, 46, 0), "Moments"),
            (new DateTime(2021, 3, 5, 19, 59, 0), "Performance"),
            (new DateTime(2021, 3, 5, 20, 8, 0), "Moments"),
            (new DateTime(2021, 3, 5, 20, 24, 0), "Moments"),
            (new DateTime(2021, 3, 5, 20, 31, 0), "Performance"),
            (new DateTime(2021, 3, 5, 20, 47, 0), "Moments")
        };

        /// <summary>
        /// Initializes the sample by loading task data for the Gantt chart.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = TaskbarTemplateData.TaskTemplateData();
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}
