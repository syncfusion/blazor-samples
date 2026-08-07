using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;
using GanttTaskData = BlazorDemos.Pages.GanttChart.Data.GanttDefaultTaskData;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class Holidays
    {
        internal SfGantt<GanttTaskData>? GanttInstance { get; set; }
        internal List<GanttTaskData> TaskCollection { get; set; } = new List<GanttTaskData>();
        internal List<HolidayModel> HolidayCollection = new List<HolidayModel>()
        {
            new HolidayModel() { HolidayDate = new DateTime(2021, 4, 02), HolidayName = "Good Friday" },
            new HolidayModel() { HolidayDate = new DateTime(2021, 4, 04), HolidayName = "Easter Sunday" },
            new HolidayModel() { HolidayDate = new DateTime(2021, 5, 31), HolidayName = "Memorial Day" },
            new HolidayModel() { HolidayDate = new DateTime(2021, 7, 04), HolidayName = "Independence Day" }
        };

        /// <summary>
        /// Initializes the sample by loading task data for the Gantt chart.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = DefaultData.ProjectNewData();
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}
