using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Navigations;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class ResourceView
    {
        internal SfGantt<ResourceViewData.TaskData>? GanttInstance { get; set; }
        internal List<ResourceViewData.TaskData> TaskCollection { get; set; } = new List<ResourceViewData.TaskData>();
        internal List<ResourceViewData.ResourceInfoModel> ResourceCollection { get; set; } = new List<ResourceViewData.ResourceInfoModel>();
        internal static List<ResourceViewData.AssignmentModel> AssignmentCollection { get; set; } = new List<ResourceViewData.AssignmentModel>();
        internal List<Object>? ToolbarItems { get; set; }
        public bool ShowOverallocation { get; set; } = true;
        public bool IsCheck { get; set; } = true;
        private ViewType viewType = ViewType.ResourceView;

        /// <summary>
        /// Initializes the sample by loading task, resource, and assignment data, and configuring the toolbar.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = ResourceViewData.GetTaskCollection();
            ResourceCollection = ResourceViewData.GetResources;
            AssignmentCollection = ResourceViewData.GetAssignmentCollection();
            UpdateToolbar();
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Handles toolbar button click events, toggling overallocation visibility.
        /// </summary>
        public void ToolbarClickHandler(ClickEventArgs args)
        {
            if (args is null)
            {
                return;
            }
            if (args.Item.Id == "ShowHideBar")
            {
                ShowOverallocation = ShowOverallocation ? false : true;
            }
        }

        /// <summary>
        /// Toggles between project view and resource view in the Gantt chart.
        /// </summary>
        public void Resource()
        {
            UpdateToolbar();
            if (viewType == ViewType.ResourceView)
            {
                viewType = ViewType.ProjectView;
            }
            else
            {
                viewType = ViewType.ResourceView;
            }
            StateHasChanged();
        }

        /// <summary>
        /// Updates the toolbar items based on the current view and overallocation settings.
        /// </summary>
        private void UpdateToolbar()
        {
#pragma warning disable BL0005 // Component parameter should not be set outside of its component.
            ToolbarItems = new List<Object>() {
            "Add", "Cancel", "Update", "Delete", "Edit", "CollapseAll", "ExpandAll",
            new ToolbarItem() {
                Text = "Show/Hide Overallocation",
                TooltipText = "Show/Hide Overallocation",
                Id = "ShowHideBar",
                Visible = IsCheck,
                PrefixIcon = "e-icons e-eye"
            }
        };
#pragma warning restore BL0005 // Component parameter should not be set outside of its component.
        }
    }
}
