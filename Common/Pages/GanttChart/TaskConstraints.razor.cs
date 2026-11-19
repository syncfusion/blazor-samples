using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class TaskConstraints
    {
        internal SfGantt<TaskConstraintsData.TaskData>? GanttInstance { get; set; }
        internal List<TaskConstraintsData.TaskData> TaskCollection { get; set; } = new List<TaskConstraintsData.TaskData>();

        /// <summary>
        /// Initializes the Task Constraints sample with task.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = TaskConstraintsData.GetTaskConstraintsData();
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}