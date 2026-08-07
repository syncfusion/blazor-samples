using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class CriticalPath
    {
        internal SfGantt<CriticalPathData.TaskData>? GanttInstance { get; set; }
        internal List<CriticalPathData.TaskData> TaskCollection { get; set; } = new List<CriticalPathData.TaskData>();
        public bool EnableCriticalPath { get; set; } = true;
        public bool IsCriticalPathEnabled { get; set; } = true;

        /// <summary>
        /// Initializes the sample by loading task data for the critical path Gantt chart.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = CriticalPathData.CriticalData();
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Handles the checkbox toggle event to enable or disable the critical path feature.
        /// </summary>
        private void OnCriticalPathToggle(Microsoft.AspNetCore.Components.ChangeEventArgs args)
        {
            EnableCriticalPath = IsCriticalPathEnabled;
        }
    }
}
