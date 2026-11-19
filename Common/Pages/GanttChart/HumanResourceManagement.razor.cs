using BlazorDemos.Pages.GanttChart.Data;
using BlazorDemos.Shared;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BlazorDemos.Pages.GanttChart.Data.HumanResourceData;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class HumanResourceManagement
    {
        [CascadingParameter]
        private MainLayout? MainLayoutInstance { get; set; }
        public SfGantt<RecruitmentPlanModel> GanttChartInstance { get; set; } = new SfGantt<RecruitmentPlanModel>();
        internal List<RecruitmentPlanModel> TaskCollection { get; set; } = new List<RecruitmentPlanModel>();
        internal List<RecruitmentPlanModel> ScheduleCollection { get; set; } = new List<RecruitmentPlanModel>();
        public DateTime CurrentDate { get; set; } = new DateTime(2024, 06, 06);
        List<string> HRDepartmentTypes = new List<string>() { "Recruitment Team", "Accounts Team", "Inventory Team" };
        private string ProgressBarColor { get; set; } = string.Empty;
        private string selectedDepartment = "Recruitment Team";
        private bool isGanttRendered;
        private string currentUri = string.Empty;

        /// <summary>
        /// Initializes the component, prepares the initial Gantt data, collapses the main layout, captures the current URI, and applies the theme.
        /// </summary>
        protected async override Task OnInitializedAsync()
        {
            TaskCollection = RecruitmentHrCollection;
            MainLayoutInstance?.Collapse();
            currentUri = Navigation.Uri;
            UpdateTheme(currentUri);
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Handles the Gantt DataBound event; skips on first render, then updates the schedule and current date from the current view records.
        /// </summary>
        private async Task DataBoundHandler(object args)
        {
            if (!isGanttRendered)
            {
                isGanttRendered = true;
                return;
            }
            ScheduleCollection = new List<RecruitmentPlanModel>() { GanttChartInstance.GetCurrentViewRecords().ToList()[1] };
            CurrentDate = ScheduleCollection[0].StartTime;
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Cancels the default Gantt popup behavior.
        /// </summary>
        private static async Task PopupHandler(PopupOpenEventArgs<RecruitmentPlanModel> args)
        {
            args.Cancel = true;
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Updates the selected schedule and current date when a Gantt row is selected.
        /// </summary>
        private async Task RowSelectedHandler(RowSelectEventArgs<RecruitmentPlanModel> args)
        {
            ScheduleCollection = args.Datas ?? new List<RecruitmentPlanModel>();
            CurrentDate = ScheduleCollection[0].StartTime;
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Changes the active department and refreshes the Gantt task collection accordingly.
        /// </summary>
        private async void DepartmentChangedHandler(string value)
        {
            selectedDepartment = value;
            if (value == "Recruitment Team")
            {
                TaskCollection = RecruitmentHrCollection;

            }
            else if (value == "Accounts Team")
            {
                TaskCollection = AccountingHrCollection;
            }
            else
            {
                TaskCollection = InventoryHrCollection;
            }
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Sets the progress bar color based on the theme inferred from the current URI.
        /// </summary>
        private void UpdateTheme(string currentUri)
        {
            if (currentUri.Contains("fluent-dark", StringComparison.OrdinalIgnoreCase))
            {
                ProgressBarColor = "#036FC1";
            }
            if (currentUri.Contains("fluent2-dark", StringComparison.OrdinalIgnoreCase))
            {
                ProgressBarColor = "#135997";
            }
            else if (currentUri.Contains("fluent2-highcontrast", StringComparison.OrdinalIgnoreCase))
            {
                ProgressBarColor = "#1AEBFF";
            }
            else if (currentUri.Contains("fluent2", StringComparison.OrdinalIgnoreCase))
            {
                ProgressBarColor = "#277AC3";
            }
            else if (currentUri.Contains("fluent", StringComparison.OrdinalIgnoreCase))
            {
                ProgressBarColor = "#1985D8";
            }
            else if (currentUri.Contains("bootstrap5-dark", StringComparison.OrdinalIgnoreCase))
            {
                ProgressBarColor = "#0F67E8";
            }
            else if (currentUri.Contains("bootstrap5", StringComparison.OrdinalIgnoreCase))
            {
                ProgressBarColor = "#257CFD";
            }
            else if (currentUri.Contains("highcontrast", StringComparison.OrdinalIgnoreCase))
            {
                ProgressBarColor = "#3E047D";
            }
            else if (currentUri.Contains("tailwind-dark", StringComparison.OrdinalIgnoreCase))
            {
                ProgressBarColor = "#22C2DC";
            }
            else if (currentUri.Contains("tailwind", StringComparison.OrdinalIgnoreCase))
            {
                ProgressBarColor = "#6058E8";
            }
            else if (currentUri.Contains("material-dark", StringComparison.OrdinalIgnoreCase))
            {
                ProgressBarColor = "#BFADE9";
            }
            else if (currentUri.Contains("material", StringComparison.OrdinalIgnoreCase))
            {
                ProgressBarColor = "#7661AD";
            }
        }
    }
}