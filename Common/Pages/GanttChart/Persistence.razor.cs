#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using BlazorDemos.Pages.GanttChart.Data;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Navigations;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class Persistence
    {
        public SfGantt<DefaultData.TaskData>? GanttInstance ;
        public List<DefaultData.TaskData> TaskCollection { get; set; } = new List<DefaultData.TaskData>();
        // Toolbar items for the Gantt chart
#pragma warning disable BL0005 // Component parameter should not be set outside of its component.
        public List<object> ToolbarItems { get; } = new List<object>
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

        private string? persistedState = null;        

        /// <summary>
        /// Handles toolbar actions for saving, loading, clearing, and reloading the persisted Gantt state.
        /// </summary>
        private async void HandleToolbarClick(ClickEventArgs args)
        {
            switch (args.Item.Id)
            {
                case "GetPersistence":
                    persistedState = await GanttInstance.GetPersistDataAsync();
                    break;
                case "SetPersistence":
                    await GanttInstance.SetPersistDataAsync(persistedState);
                    break;
                case "ClearPersistence":
                    await GanttInstance.ResetPersistDataAsync();
                    break;
                case "ReloadPage":
                    await JsInterop.InvokeVoidAsync("window.location.reload");
                    break;
            }
        }
    }
}
