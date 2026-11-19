using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class VirtualScroll
    {
        internal SfGantt<VirtualScrollData.TaskData>? GanttInstance { get; set; }
        internal List<VirtualScrollData.TaskData> TaskCollection { get; set; } = new List<VirtualScrollData.TaskData>();
        public string DateFormat { get; set; } = "MM/dd/yyyy";
        public bool AutoCalculateDateScheduling { get; set; }
        public string LoadTime { get; set; } = string.Empty;
        public int? Index { get; set; } = 0;
        private DateTime startLoadTime;
        private DateTime endLoadTime;
        private int rowCount = 1000;
        private int? previousIndex = 0;

        /// <summary>
        /// A list of dropdown options for selecting the number of rows.
        /// </summary>
        internal List<DropdownData> DLData = new List<DropdownData>() {
            new DropdownData(){ Text= "1,000 Rows", Value= "1000" },
            new DropdownData(){ Text= "2,500 Rows", Value= "2500" },
            new DropdownData(){ Text= "5,000 Rows", Value= "5000" },
        };

        /// <summary>
        /// Initializes the sample by loading virtual scroll data and recording the start time.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            startLoadTime = DateTime.Now;
            this.TaskCollection = VirtualScrollData.GetTreeVirtualData(1000);
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Handles the Gantt chart creation event and calculates the initial load time.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        private void OnGanttCreated(object sender)
        {
            AutoCalculateDateScheduling = true;
            endLoadTime = DateTime.Now;
            TimeSpan ts = (TimeSpan)(endLoadTime - startLoadTime);
            LoadTime = ts.TotalMilliseconds.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Handles the action complete event and updates the load time if the request type is refresh.
        /// </summary>
        /// <param name="args">The Gantt action event arguments.</param>
        internal void ActionCompleteHandler(GanttActionEventArgs<VirtualScrollData.TaskData> args)
        {
            if (args.RequestType == Syncfusion.Blazor.Gantt.Action.Refresh)
            {
                endLoadTime = DateTime.Now;
                TimeSpan ts = (TimeSpan)(endLoadTime - startLoadTime);
                LoadTime = ts.TotalMilliseconds.ToString(CultureInfo.InvariantCulture);
                AutoCalculateDateScheduling = true;
            }
        }

        /// <summary>
        /// Handles the dropdown close event and reloads data if the index has changed.
        /// </summary>
        /// <param name="args">The dropdown close event arguments.</param>
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
        /// <param name="args">The dropdown change event arguments.</param>
        internal void OnDataChange(@Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, DropdownData> args)
        {
            if (args is null)
            {
                return;
            }
            rowCount = Int32.Parse(args.Value,CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Represents a dropdown item used to select row count.
        /// </summary>
        internal sealed class DropdownData
        {
            public string Text { get; set; } = string.Empty;
            public string Value { get; set; } = string.Empty;
        }
    }
}
