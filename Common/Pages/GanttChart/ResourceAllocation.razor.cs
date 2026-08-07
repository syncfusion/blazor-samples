using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class ResourceAllocation
    {
        internal SfGantt<ResourceModel.TaskInfoModel>? GanttInstance { get; set; }
        internal List<ResourceModel.TaskInfoModel> TaskCollection { get; set; } = new List<ResourceModel.TaskInfoModel>();
        internal List<ResourceModel.ResourceInfoModel> ResourceCollection { get; set; } = new List<ResourceModel.ResourceInfoModel>();
        internal static List<ResourceModel.AssignmentModel> AssignmentCollection { get; set; } = new List<ResourceModel.AssignmentModel>();

        /// <summary>
        /// Initializes the sample by loading task, resource, and assignment data for resource allocation.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = ResourceModel.GetTaskCollection();
            ResourceCollection = ResourceModel.GetResources;
            AssignmentCollection = ResourceModel.GetAssignmentCollection();
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}
