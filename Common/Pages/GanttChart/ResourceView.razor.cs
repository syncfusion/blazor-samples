#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Navigations;
using BlazorDemos.Pages.GanttChart.Data;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class ResourceView
    {
        public SfGantt<ResourceViewData.TaskData>? GanttInstance { get; set; }
        public List<ResourceViewData.TaskData> TaskCollection { get; set; } = new List<ResourceViewData.TaskData>();
        public List<ResourceViewData.ResourceInfoModel> ResourceCollection { get; set; } = new List<ResourceViewData.ResourceInfoModel>();
        public static List<ResourceViewData.AssignmentModel> AssignmentCollection { get; set; } = new List<ResourceViewData.AssignmentModel>();
        public List<Object>? ToolbarItems { get; set; }
        public bool ShowOverallocation { get; set; } = true;
        public bool IsCheck { get; set; } = true;
        private ViewType viewType = ViewType.ResourceView;        

        /// <summary>
        /// Handles toolbar button click events, toggling overallocation visibility.
        /// </summary>
        public void ToolbarClickHandler(ClickEventArgs args)
        {
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
