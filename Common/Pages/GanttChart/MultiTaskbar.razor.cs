using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class MultiTaskbar
    {
        internal SfGantt<MultiTaskbarData.TaskInfoModel>? GanttInstance { get; set; }
        internal List<MultiTaskbarData.TaskInfoModel> TaskCollection { get; set; } = new List<MultiTaskbarData.TaskInfoModel>();
        internal List<MultiTaskbarData.ResourceInfoModel> Resources { get; set; } = new List<MultiTaskbarData.ResourceInfoModel>();
        internal static List<MultiTaskbarData.AssignmentModel> Assignments { get; set; } = new List<MultiTaskbarData.AssignmentModel>();
        public bool IsTaskbarDragAndDropEnabled { get; set; } = true;

        /// <summary>
        /// Initializes the sample by loading task, resource, and assignment data, and configuring the toolbar.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = MultiTaskbarData.GetTaskCollection();
            Resources = MultiTaskbarData.GetResources;
            Assignments = MultiTaskbarData.GetAssignmentCollection();
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}
