#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Pages.GanttChart.Data;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Buttons;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Navigations;
using System;
using System.Collections.Generic;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class Selection
    {
        public SfGantt<SelectionData.TaskData>? GanttInstance { get; set; }
        public List<SelectionData.TaskData> TaskCollection { get; set; } = new List<SelectionData.TaskData>();
        public List<Object> ToolbarItems { get; set; }
        public bool IsToggleEnabled { get; set; }
        public SfDropDownList<string, DropDownOption> ModeDropdown { get; set; }
        public SfDropDownList<string, DropDownOption> TypeDropdown { get; set; }
        public bool IsAutoScrollEnabled { get; set; }
        public bool IsRowHoverEnabled { get; set; }
        public int SelectedRowIndex { get; set; } = -1;
        public Syncfusion.Blazor.Grids.SelectionMode GanttSelectionMode { get; set; } = Syncfusion.Blazor.Grids.SelectionMode.Row;
        public Syncfusion.Blazor.Grids.SelectionType GanttSelectionType { get; set; } = Syncfusion.Blazor.Grids.SelectionType.Single;
        public bool IsSelectionEnabled { get; set; } = true;
        private string? selectedType;
        private string? selectedMode;

        /// <summary>
        /// Represents the available selection modes in the Gantt chart.
        /// </summary>
        private List<DropDownOption> SelectionModes { get; set; } = new List<DropDownOption>
        {
            new DropDownOption { ID = "Row", Mode = "Row" },
            new DropDownOption { ID = "Cell", Mode = "Cell" }
        };

        /// <summary>
        /// Represents the available selection types in the Gantt chart.
        /// </summary>
        private List<DropDownOption> SelectionTypes { get; set; } = new List<DropDownOption>
        {
            new DropDownOption { ID = "Single", Mode = "Single" },
            new DropDownOption { ID = "Multiple", Mode = "Multiple" }
        };

        /// <summary>
        /// Represents a dropdown option used for selection mode and type configuration.
        /// </summary>
        public class DropDownOption
        {
            public string ID { get; set; } = string.Empty;
            public string Mode { get; set; } = string.Empty;
        }

        /// <summary>
        /// Handles the toggle switch change event to enable or disable selection toggle.
        /// </summary>
        public void HandleToggleChange(Syncfusion.Blazor.Buttons.ChangeEventArgs<bool> args)
        {
            IsToggleEnabled = args.Checked;
        }

        /// <summary>
        /// Handles the auto-scroll switch change event to enable or disable scrolling to taskbar on row selection.
        /// </summary>
        public void HandleAutoScrollChange(Syncfusion.Blazor.Buttons.ChangeEventArgs<bool> args)
        {
            IsAutoScrollEnabled = args.Checked;
        }

        /// <summary>
        /// Handles the row hover switch change event to enable or disable row highlighting on hover.
        /// </summary>
        public void HandleRowHoverChange(Syncfusion.Blazor.Buttons.ChangeEventArgs<bool> args)
        {
            IsRowHoverEnabled = args.Checked;
        }

        /// <summary>
        /// Updates the Gantt selection mode based on dropdown selection.
        /// </summary>
        public void OnModeChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, DropDownOption> args)
        {
            GanttSelectionMode = args.Value == "Cell" ? Syncfusion.Blazor.Grids.SelectionMode.Cell : Syncfusion.Blazor.Grids.SelectionMode.Row;
        }

        /// <summary>
        /// Updates the Gantt selection type based on dropdown selection.
        /// </summary>
        public void OnTypeChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, DropDownOption> args)
        {
            GanttSelectionType = args.Value == "Single" ? Syncfusion.Blazor.Grids.SelectionType.Single : Syncfusion.Blazor.Grids.SelectionType.Multiple;
        }        
    }
}
