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
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class RemoteData
    {
        public SfGantt<TaskData> GanttInstance { get; set; }
        public string LoadTime { get; set; } = string.Empty;
        public int? DropDownIndex { get; set; } = 0;
        // Initialize URL in the code block to ensure it's updated dynamically
        public string AdapatorUrl => $"https://blazor.syncfusion.com/services/production/api/GanttRemoteData?count={recordCount}";
        private int? recordCount = 1000;
        private int? previousDropDownIndex = 0;
        private DateTime? startLoadTime;
        private DateTime? endLoadTime;
        
        /// <summary>
        /// Handles the Gantt chart creation and calculates initial load time.
        /// </summary>
        private void OnGanttCreated(object sender)
        {
            endLoadTime = DateTime.Now;
            TimeSpan ts = (TimeSpan)(endLoadTime - startLoadTime);
            LoadTime = ts.TotalMilliseconds.ToString("F3");
        }

        /// <summary>
        /// Handles action complete events to update load time.
        /// </summary>
        public void ActionCompleteHandler(GanttActionEventArgs<TaskData> args)
        {
            if (args.RequestType == Syncfusion.Blazor.Gantt.Action.Refresh)
            {
                endLoadTime = DateTime.Now;
                TimeSpan ts = (TimeSpan)(endLoadTime - startLoadTime);
                LoadTime = ts.TotalMilliseconds.ToString("F3");
            }
        }

        /// <summary>
        /// Records start time when dropdown is closed and selection changes.
        /// </summary>
        private void DropdownClose(@Syncfusion.Blazor.DropDowns.ClosedEventArgs args)
        {
            if (previousDropDownIndex != DropDownIndex)
            {
                startLoadTime = DateTime.Now;
                previousDropDownIndex = DropDownIndex;
            }
        }

        /// <summary>
        /// Updates record count and refreshes the Gantt chart based on dropdown selection.
        /// </summary>
        public async Task OnDataChange(@Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, DropdownData> args)
        {
            recordCount = Int32.Parse(args.Value);
            await GanttInstance.RefreshAsync();
        }

        public class DropdownData
        {
            public string Text { get; set; } = string.Empty;
            public string Value { get; set; } = string.Empty;
        }

        public List<DropdownData> DLData = new List<DropdownData>() {
            new DropdownData(){ Text= "1,000 Rows", Value= "1000" },
            new DropdownData(){ Text= "2,500 Rows", Value= "2500" },
            new DropdownData(){ Text= "5,000 Rows", Value= "5000" },
        };

        public class TaskData
        {
            public int Id { get; set; }

            public string Name { get; set; } = string.Empty;

            public DateTime StartDate { get; set; }

            public DateTime EndDate { get; set; }

            public int DurationInDays { get; set; }

            public int CompletionPercent { get; set; }

            public int? ParentTaskId { get; set; }

            public string Dependency { get; set; } = string.Empty;
        }
    }
}
