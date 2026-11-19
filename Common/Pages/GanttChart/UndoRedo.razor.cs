using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class UndoRedo
    {
        internal SfGantt<UndoRedoData.TaskModel>? GanttInstance { get; set; }
        internal List<UndoRedoData.TaskModel> TaskCollection { get; set; } = new();

        /// <summary>
        /// Initializes the component by setting up the task collection and toolbar items.
        /// </summary>
        private List<GanttUndoRedoAction> undoRedoActions = new List<GanttUndoRedoAction> {
        GanttUndoRedoAction.Sort, GanttUndoRedoAction.Add, GanttUndoRedoAction.ColumnReorder, GanttUndoRedoAction.TaskbarEdit,
        GanttUndoRedoAction.ColumnState, GanttUndoRedoAction.Edit, GanttUndoRedoAction.Filter, GanttUndoRedoAction.NextTimeSpan, GanttUndoRedoAction.PreviousTimeSpan, GanttUndoRedoAction.Search,GanttUndoRedoAction.Delete,
        GanttUndoRedoAction.ZoomIn, GanttUndoRedoAction.ZoomOut, GanttUndoRedoAction.ZoomToFit,GanttUndoRedoAction.Collapse,GanttUndoRedoAction.Expand,GanttUndoRedoAction.SplitterResize
    };

        /// <summary>
        /// Initializes the UndoRedo sample with Gantt task data.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            this.TaskCollection = UndoRedoData.GetUndoRedoData();
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}
