using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using BlazorDemos.Shared;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Navigations;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class Exporting
    {
        internal SfGantt<GanttData.TaskData>? GanttChartInstance { get; set; }
        internal List<GanttData.TaskData> TaskCollection { get; set; } = new List<GanttData.TaskData>();
        List<object> ToolbarItems { get; set; } = new List<object>
        {
            #pragma warning disable BL0005 // Component parameter should not be set outside of its component.
            "ZoomIn", "ZoomOut", "ZoomToFit", "ExcelExport", "CsvExport",
            new ToolbarItem { Text = "PDF Export", TooltipText = "PDF Export", Id = "PdfExport", PrefixIcon = "e-pdfexport" }
            #pragma warning restore BL0005 // Component parameter should not be set outside of its component.
        };

        /// <summary>
        /// Initializes the Default Exporting sample with Gantt task data.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = GanttData.EditingData();
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Handles toolbar click events to export Gantt data to Excel, CSV, or PDF formats.
        /// </summary>
        public async Task HandleToolbarClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
        {
            if (GanttChartInstance == null)
            {
                return;
            }
            if (args is null) return;
            if (args.Item.Id == "GanttExport_excelexport")
            {
                await GanttChartInstance.ExportToExcelAsync().ConfigureAwait(true);
            }
            else if (args.Item.Id == "GanttExport_csvexport")
            {
                await GanttChartInstance.ExportToCsvAsync().ConfigureAwait(true);
            }
            else if (args.Item.Id == "PdfExport")
            {
                await GanttChartInstance.ExportToPdfAsync().ConfigureAwait(true);
            }
        }
    }
}
