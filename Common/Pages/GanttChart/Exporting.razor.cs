#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Navigations;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class Exporting
    {
        public SfGantt<GanttData.TaskData>? GanttChartInstance { get; set; }
        public List<GanttData.TaskData> TaskCollection { get; set; } = new List<GanttData.TaskData>();
        public List<object> ToolbarItems { get; set; } = new List<object>
        {
            #pragma warning disable BL0005 // Component parameter should not be set outside of its component.
            "ZoomIn", "ZoomOut", "ZoomToFit", "ExcelExport", "CsvExport",
            new ToolbarItem { Text = "PDF Export", TooltipText = "PDF Export", Id = "PdfExport", PrefixIcon = "e-pdfexport" }
            #pragma warning restore BL0005 // Component parameter should not be set outside of its component.
        };

        /// <summary>
        /// Handles toolbar click events to export Gantt data to Excel, CSV, or PDF formats.
        /// </summary>
        public async Task HandleToolbarClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
        {
            if (args.Item.Id == "GanttExport_excelexport")
            {
                await GanttChartInstance.ExportToExcelAsync();
            }
            else if (args.Item.Id == "GanttExport_csvexport")
            {
                await GanttChartInstance.ExportToCsvAsync();
            }
            else if (args.Item.Id == "PdfExport")
            {
                await GanttChartInstance.ExportToPdfAsync();
            }
        }
    }
}
