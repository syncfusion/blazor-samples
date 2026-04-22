#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using BlazorDemos.Pages.GanttChart.Data;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Navigations;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class FrozenColumn
    {
        public SfGantt<GanttData.TaskData>? Gantt { get; set; }
        public List<GanttData.TaskData> TaskCollection { get; set; } = new List<GanttData.TaskData>();
        public List<Object> ToolbarItems { get; set; }
        public int FrozenColumnCount { get; set; } = 1;

        public bool IsTaskNameFrozen { get; set; } = true;
        public FreezeDirection TaskNameFreezeDirection { get; set; } = FreezeDirection.Left;

        public bool IsStartDateFrozen { get; set; } = false;
        public FreezeDirection StartDateFreezeDirection { get; set; }

        public bool IsDurationFrozen { get; set; } = false;
        public FreezeDirection DurationFreezeDirection { get; set; }

        public bool IsProgressFrozen { get; set; } = true;
        public FreezeDirection ProgressFreezeDirection { get; set; } = FreezeDirection.Right;

        public bool IsDependencyFrozen { get; set; } = true;
        public FreezeDirection DependencyFreezeDirection { get; set; } = FreezeDirection.Right;

        private static readonly List<string> rightFrozenColumns = new List<string> { "Duration", "Progress", "Dependency" };
        private static readonly List<string> leftFrozenColumns = new List<string> { "Job Name", "Start Date" };

        private string selectedLeftColumn = leftFrozenColumns[0];
        private string selectedRightColumn = rightFrozenColumns[1];        

        /// <summary>
        /// Handles the dropdown value change event for right frozen column selection.
        /// </summary>
        public async void OnRightFreezeChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, string> args)
        {
            switch (args.Value)
            {
                case "Dependency":
                    IsDependencyFrozen = true;
                    IsProgressFrozen = false;
                    IsDurationFrozen = false;
                    break;
                case "Progress":
                    IsDependencyFrozen = true;
                    IsProgressFrozen = true;
                    IsDurationFrozen = false;
                    break;
                default:
                    IsDependencyFrozen = true;
                    IsProgressFrozen = true;
                    IsDurationFrozen = true;
                    DurationFreezeDirection = FreezeDirection.Right;
                    break;
            }
            await Gantt.RefreshAsync();
			StateHasChanged();
        }

        /// <summary>
        /// Handles the dropdown value change event for left frozen column selection.
        /// </summary>
        public async void OnLeftFreezeChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, string> args)
        {
            if (args.Value == "Job Name")
            {
                IsTaskNameFrozen = true;
                IsStartDateFrozen = false;
            }
            else
            {
                IsTaskNameFrozen = true;
                IsStartDateFrozen = true;
                StartDateFreezeDirection = FreezeDirection.Left;
            }
            await Gantt.RefreshAsync();
			StateHasChanged();
        }
    }
}
