using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Navigations;
using GanttTaskData = BlazorDemos.Pages.GanttChart.Data.GanttDefaultTaskData;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class RowHeight
    {
        internal SfGantt<GanttTaskData>? GanttInstance { get; set; }
        internal List<GanttTaskData> TaskCollection { get; set; } = new List<GanttTaskData>();
        internal List<ToolbarItem> ToolbarItems { get; set; } = new List<ToolbarItem>();
        public int CurrentRowHeight { get; set; } = 40;        

        /// <summary>
        /// Adds toolbar items for selecting row height.
        /// </summary>
        private void InitializeToolbarItems()
        {
#pragma warning disable BL0005 // Component parameter should not be set outside of its component.
            ToolbarItems.Add(new ToolbarItem { PrefixIcon = "e-big-icon", Id = "small", Align = ItemAlign.Left, TooltipText = "Small" });
            ToolbarItems.Add(new ToolbarItem { PrefixIcon = "e-medium-icon", Id = "medium", Align = ItemAlign.Left, TooltipText = "Medium" });
            ToolbarItems.Add(new ToolbarItem { PrefixIcon = "e-small-icon", Id = "big", Align = ItemAlign.Left, TooltipText = "Big" });
#pragma warning restore BL0005 // Component parameter should not be set outside of its component.
        }

        /// <summary>
        /// Handles toolbar click events to change the row height.
        /// </summary>
        private void OnToolbarClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
        {
            CurrentRowHeight = args.Item.Id switch
            {
                "small" => 24,
                "medium" => 40,
                "big" => 60,
                _ => CurrentRowHeight
            };
        }

        /// <summary>
        /// Initializes the RowHeight sample with default task data and toolbar items.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = DefaultData.ProjectNewData();
            InitializeToolbarItems();
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}
