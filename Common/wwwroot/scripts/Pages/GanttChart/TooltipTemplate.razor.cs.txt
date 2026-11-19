using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class TooltipTemplate
    {
        internal SfGantt<TooltipTemplateData.TaskData>? GanttInstance { get; set; }
        internal List<TooltipTemplateData.TaskData> TaskCollection { get; set; } = new List<TooltipTemplateData.TaskData>();
        public string TaskbarEditAction { get; set; } = string.Empty;

        /// <summary>
        /// Initializes the task collection for the Gantt Chart tooltip template sample.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = TooltipTemplateData.GetTaskCollection();
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Captures the taskbar editing action and updates the tooltip display accordingly.
        /// </summary>
        private void TaskbarEditingHandler(TaskbarEditingEventArgs<TooltipTemplateData.TaskData> args)
        {
            TaskbarEditAction = args.Action;
        }
    }
}
