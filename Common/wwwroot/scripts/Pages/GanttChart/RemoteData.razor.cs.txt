using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public class RemoteTaskData
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
    public sealed partial class RemoteData
    {
        internal SfGantt<RemoteTaskData>? GanttInstance { get; set; }
        public string LoadTime { get; set; } = string.Empty;
        public int? DropDownIndex { get; set; } = 0;
        // Initialize URL in the code block to ensure it's updated dynamically
        private string AdapatorUrl => $"https://blazor.syncfusion.com/services/production/api/GanttRemoteData?count={recordCount}";
        private int? recordCount = 1000;
        private int? previousDropDownIndex = 0;
        private DateTime? startLoadTime;
        private DateTime? endLoadTime;

        /// <summary>
        /// Initializes the sample and records the start time for data load measurement.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            startLoadTime = DateTime.Now;
            await Task.CompletedTask.ConfigureAwait(true);
        }
        /// <summary>
        /// Handles the Gantt chart creation and calculates initial load time.
        /// </summary>
        private void OnGanttCreated(object sender)
        {
            if (startLoadTime is null)
            {
                return;
            }
            endLoadTime = DateTime.Now;
            TimeSpan ts = (TimeSpan)(endLoadTime - startLoadTime);
            LoadTime = ts.TotalMilliseconds.ToString("F3", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Handles action complete events to update load time.
        /// </summary>
        private void ActionCompleteHandler(GanttActionEventArgs<RemoteTaskData> args)
        {
            if (args.RequestType == Syncfusion.Blazor.Gantt.Action.Refresh)
            {
                if (startLoadTime is null)
                {
                    return;
                }
                endLoadTime = DateTime.Now;
                TimeSpan ts = (TimeSpan)(endLoadTime - startLoadTime);
                LoadTime = ts.TotalMilliseconds.ToString("F3", CultureInfo.InvariantCulture);
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
        private async Task OnDataChange(@Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, DropdownData> args)
        {
            if (GanttInstance == null)
            {
                return;
            }

            recordCount = Int32.Parse(args.Value, CultureInfo.InvariantCulture);
            await GanttInstance.RefreshAsync().ConfigureAwait(true);
        }

        internal sealed class DropdownData
        {
            public string Text { get; set; } = string.Empty;
            public string Value { get; set; } = string.Empty;
        }

        internal List<DropdownData> DLData = new List<DropdownData>() {
            new DropdownData(){ Text= "1,000 Rows", Value= "1000" },
            new DropdownData(){ Text= "2,500 Rows", Value= "2500" },
            new DropdownData(){ Text= "5,000 Rows", Value= "5000" },
        };
    }
}
