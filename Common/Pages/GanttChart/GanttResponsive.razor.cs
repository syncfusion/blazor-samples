#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Pages.GanttChart.Data;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Navigations;
using System;
using System.Collections.Generic;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class GanttResponsive
    {
        public SfGantt<WorkData.TaskData>? GanttInstance { get; set; }
        public List<WorkData.TaskData> TaskCollection { get; set; } = new List<WorkData.TaskData>();
        public List<Object> ToolbarItems;
        public string Width { get; set; } = "100%";
        private string selectedDropDownValue = "None";

        /// <summary>
        /// Represents a dropdown option used to control the responsive width of the Gantt Chart.
        /// </summary>
        public class DropDownValueModel
        {
            public string Name { get; set; } = string.Empty;
        }

        /// <summary>
        /// Gets the list of predefined dropdown options used to control the responsive width of the Gantt Chart.
        /// </summary>
        private List<DropDownValueModel> DropDownNames { get; } = new List<DropDownValueModel>
        {
            new DropDownValueModel { Name = "Small" },
            new DropDownValueModel { Name = "Medium" },
            new DropDownValueModel { Name = "Large" },
            new DropDownValueModel { Name = "None" }
        };

        /// <summary>
        /// Handles the dropdown value change event to update the Gantt Chart's width responsively.
        /// </summary>
        public void OnDropDownValueChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, DropDownValueModel> args)
        {
            Width = args.ItemData.Name switch
            {
                "Small" => "40%",
                "Medium" => "60%",
                "Large" => "80%",
                "None" => "100%",
                _ => Width // Default to current width
            };
        }        
    }
}
