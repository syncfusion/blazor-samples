using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public class LoadOnDemandTaskData
    {
        public int ID { get; set; }
        public string TaskName { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Duration { get; set; }
        public int? ParentId { get; set; }
        public string Predecessor { get; set; } = string.Empty;
        public bool? IsParent { get; set; }
    }
    public sealed partial class LoadOnDemand
    {
        public SfGantt<LoadOnDemandTaskData>? GanttInstance { get; set; }
    }
}
