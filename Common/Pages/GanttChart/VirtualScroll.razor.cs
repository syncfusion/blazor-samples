#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class VirtualScroll
    {
        public SfGantt<VirtualScrollData.TaskData>? GanttInstance { get; set; }
        public List<VirtualScrollData.TaskData> TaskCollection { get; set; } = new List<VirtualScrollData.TaskData>();
        public string DateFormat { get; set; } = "MM/dd/yyyy";
        public bool AutoCalculateDateScheduling { get; set; } = false;
        public string LoadTime { get; set; } = string.Empty;
        public int? Index { get; set; } = 0;
        private DateTime startLoadTime;
        private DateTime endLoadTime;
        private int rowCount = 1000;
        private int? previousIndex = 0;      

        /// <summary>
        /// Handles the Gantt chart creation event and calculates the initial load time.
        /// </summary>
        private void OnGanttCreated(object sender)
        {
            AutoCalculateDateScheduling = true;
            endLoadTime = DateTime.Now;
            TimeSpan ts = (TimeSpan)(endLoadTime - startLoadTime);
            LoadTime = ts.TotalMilliseconds.ToString();
        }

        /// <summary>
        /// Handles the action complete event and updates the load time if the request type is refresh.
        /// </summary>
        public void ActionCompleteHandler(GanttActionEventArgs<VirtualScrollData.TaskData> args)
        {
            if (args.RequestType == Syncfusion.Blazor.Gantt.Action.Refresh)
            {
                endLoadTime = DateTime.Now;
                TimeSpan ts = (TimeSpan)(endLoadTime - startLoadTime);
                LoadTime = ts.TotalMilliseconds.ToString();
                AutoCalculateDateScheduling = true;
            }
        }

        /// <summary>
        /// Handles the dropdown close event and reloads data if the index has changed.
        /// </summary>
        private void DropdownClose(@Syncfusion.Blazor.DropDowns.ClosedEventArgs args)
        {
            if (previousIndex != Index)
            {
                startLoadTime = DateTime.Now;
                AutoCalculateDateScheduling = false;
                this.TaskCollection = VirtualScrollData.GetTreeVirtualData(rowCount);
                previousIndex = Index;
            }
        }

        /// <summary>
        /// Handles the dropdown value change event and updates the row count.
        /// </summary>
        public void OnDataChange(@Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, DropdownData> args)
        {
            rowCount = Int32.Parse(args.Value);
        }

        /// <summary>
        /// Represents a dropdown item used to select row count.
        /// </summary>
        public class DropdownData
        {
            public string Text { get; set; } = string.Empty;
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// A list of dropdown options for selecting the number of rows.
        /// </summary>
        public List<DropdownData> DLData = new List<DropdownData>() {
            new DropdownData(){ Text= "1,000 Rows", Value= "1000" },
            new DropdownData(){ Text= "2,500 Rows", Value= "2500" },
            new DropdownData(){ Text= "5,000 Rows", Value= "5000" },
        };
    }
}
