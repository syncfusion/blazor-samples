using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;
using GanttTaskData = BlazorDemos.Pages.GanttChart.Data.GanttDefaultTaskData;
using Syncfusion.Blazor.Navigations;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class Clipboard
    {
        internal List<GanttTaskData> TaskCollection { get; private set; } = new List<GanttTaskData>();
        internal SfGantt<GanttTaskData>? GanttChartInstance { get; set; }
        List<Object> ToolbarItems = new List<Object>()
        {
            #pragma warning disable BL0005 // Component parameter should not be set outside of its component.
            new ToolbarItem() { Id = "copyHeader", Text = "Copy With Header", PrefixIcon = "e-copy"},
            new ToolbarItem() { Id = "copy", Text = "Copy", PrefixIcon = "e-copy"}
            #pragma warning restore BL0005 // Component parameter should not be set outside of its component.
        };

        /// <summary>
        /// Initializes the Clipboard sample with default Gantt task data.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = DefaultData.ProjectNewData();
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Handles toolbar click events to copy selected Gantt rows to the clipboard.
        /// </summary>
        public async Task ToolbarClickHandler(Syncfusion.Blazor.Navigations.ClickEventArgs args)
        {
            if (GanttChartInstance == null)
            {
                return;
            }
            var selectedRecords = await GanttChartInstance.GetSelectedRecordsAsync().ConfigureAwait(true);
            if (selectedRecords.Count != 0 && args != null)
            {
                bool copyWithHeader = args.Item.Id == "copyHeader";
                await GanttChartInstance.CopyAsync(copyWithHeader).ConfigureAwait(true);
            }
        }
    }
}
