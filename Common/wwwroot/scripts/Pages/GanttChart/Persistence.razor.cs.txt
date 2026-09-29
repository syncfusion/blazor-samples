using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Navigations;
using GanttTaskData = BlazorDemos.Pages.GanttChart.Data.GanttDefaultTaskData;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class Persistence
    {
        internal SfGantt<GanttTaskData>? GanttInstance;
        internal List<GanttTaskData> TaskCollection { get; set; } = new List<GanttTaskData>();
        // Toolbar items for the Gantt chart
#pragma warning disable BL0005 // Component parameter should not be set outside of its component.
        List<object> ToolbarItems { get; } = new List<object>
        {
            "ZoomIn",
            "ZoomOut",
            "ZoomToFit",
            new ToolbarItem { Text = "Save state", TooltipText = "Save state", Id = "GetPersistence", PrefixIcon = "e-savestate" },
            new ToolbarItem { Text = "Load state", TooltipText = "Load state", Id = "SetPersistence", PrefixIcon = "e-setstate" },
            new ToolbarItem { Text = "Reset state", TooltipText = "Reset state", Id = "ClearPersistence", PrefixIcon = "e-resetstate" },
            new ToolbarItem { Text = "Reload page", TooltipText = "Reload page", Id = "ReloadPage", PrefixIcon = "e-reloadpage" }
        };
#pragma warning restore BL0005 // Component parameter should not be set outside of its component.

        private string? persistedState;

        /// <summary>
        /// Handles toolbar actions for saving, loading, clearing, and reloading the persisted Gantt state.
        /// </summary>
        private async Task HandleToolbarClick(ClickEventArgs args)
        {
            if (GanttInstance == null)
            {
                return;
            }
            switch (args.Item.Id)
            {
                case "GetPersistence":
                    persistedState = await GanttInstance.GetPersistDataAsync().ConfigureAwait(true);
                    break;
                case "SetPersistence":
                    if (string.IsNullOrEmpty(persistedState))
                    {
                        return;
                    }
                    await GanttInstance.SetPersistDataAsync(persistedState).ConfigureAwait(true);
                    break;
                case "ClearPersistence":
                    await GanttInstance.ResetPersistDataAsync().ConfigureAwait(true);
                    break;
                case "ReloadPage":
                    await JsInterop.InvokeVoidAsync("window.location.reload").ConfigureAwait(true);
                    break;
            }
        }

        /// <summary>
        /// Initializes the Persistence sample with default Gantt task data.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = DefaultData.ProjectNewData();
        }
    }
}
