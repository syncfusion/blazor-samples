#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Navigations;
using System.Collections.Generic;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class RowHeight
    {
        public SfGantt<DefaultData.TaskData>? GanttInstance { get; set; }
        public List<DefaultData.TaskData> TaskCollection { get; set; } = new List<DefaultData.TaskData>();
        public List<ToolbarItem> ToolbarItems { get; set; } = new List<ToolbarItem>();
        public int CurrentRowHeight { get; set; } = 40;        

        /// <summary>
        /// Adds toolbar items for selecting row height.
        /// </summary>
        private void InitializeToolbarItems()
        {
#pragma warning disable BL0005 // Component parameter should not be set outside of its component.
            ToolbarItems.Add(new ToolbarItem { PrefixIcon = "e-big-icon", Id = "small", Align = ItemAlign.Left, TooltipText = "Small" });
            ToolbarItems.Add(new ToolbarItem { PrefixIcon = "e-medium-icon", Id = "medium", Align = ItemAlign.Left, TooltipText = "Medium" });
            ToolbarItems.Add(new ToolbarItem { PrefixIcon = "e-small-icon", Id = "big", Align = ItemAlign.Left, TooltipText = "Big" });
#pragma warning restore BL0005 // Component parameter should not be set outside of its component.
        }

        /// <summary>
        /// Handles toolbar click events to change the row height.
        /// </summary>
        private void OnToolbarClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
        {
            CurrentRowHeight = args.Item.Id switch
            {
                "small" => 24,
                "medium" => 40,
                "big" => 60,
                _ => CurrentRowHeight
            };
        }
    }
}
