using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using BlazorDemos.Shared;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class EventMarkers
    {
        internal SfGantt<EventData.TaskData>? GanttInstance { get; set; }
        internal List<EventData.TaskData> TaskCollection { get; set; } = new List<EventData.TaskData>();
        public DateTime ResearchPhaseDate { get; set; } = new DateTime(2021, 04, 09);
        public DateTime DesignPhaseDate { get; set; } = new DateTime(2021, 04, 30);
        public DateTime ProductionPhaseDate { get; set; } = new DateTime(2021, 05, 22);
        public DateTime SalesMarketingPhaseDate { get; set; } = new DateTime(2021, 06, 19);

        /// <summary>
        /// Initializes the sample by loading task data for the Gantt chart.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = EventData.GetTaskCollection();
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}
