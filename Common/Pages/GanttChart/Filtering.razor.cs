#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class Filtering
    {
        public SfGantt<FilterData.TaskData>? GanttInstance { get; set; }
        public List<FilterData.TaskData> TaskCollection { get; set; } = new List<FilterData.TaskData>();
        public List<Object>? ToolbarItems { get; set; }
        public FilterHierarchyMode CurrentHierarchyMode { get; set; } = FilterHierarchyMode.Both;
        private string selectedHierarchyMode = "Both";

        /// <summary>
        /// Represents a filtering hierarchy mode option with an ID and display text.
        /// </summary>
        public class HierarchyModeFields
        {
            public string? Id { get; set; }
            public string? Text { get; set; }
        }

        /// <summary>
        /// Defines the available hierarchy mode options for filtering in the Gantt Chart.
        /// </summary>
        private static List<HierarchyModeFields> HierarchyModes = new List<HierarchyModeFields>
        {
            new HierarchyModeFields { Id = "Parent", Text = "Parent" },
            new HierarchyModeFields { Id = "Child", Text = "Child" },
            new HierarchyModeFields { Id = "Both", Text = "Both" },
            new HierarchyModeFields { Id = "None", Text = "None" }
        };        

        /// <summary>
        /// Handles the change event for hierarchy mode dropdown.
        /// Updates the Gantt filter settings based on selected mode.
        /// </summary>
        public async void OnHierarchyModeChanged(ChangeEventArgs<string, HierarchyModeFields> args)
        {
            if (!string.IsNullOrEmpty(args.Value))
            {
                selectedHierarchyMode = args.Value;
                CurrentHierarchyMode = args.Value == "Parent" ? FilterHierarchyMode.Parent :
                                                args.Value == "Child" ? FilterHierarchyMode.Child :
                                                args.Value == "None" ? FilterHierarchyMode.None :
                                                FilterHierarchyMode.Both;
            }
            await Task.CompletedTask;
        }
    }
}
