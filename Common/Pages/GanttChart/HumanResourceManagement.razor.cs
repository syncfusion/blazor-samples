#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
    public partial class HumanResourceManagement
    {
        [CascadingParameter]
        protected MainLayout? MainLayoutInstance { get; set; }
        public SfGantt<RecruitmentPlanModel> GanttChartInstance { get; set; } = new SfGantt<RecruitmentPlanModel>();
        public List<RecruitmentPlanModel> TaskCollection { get; set; } = new List<RecruitmentPlanModel>();
        public List<RecruitmentPlanModel> ScheduleCollection { get; set; } = new List<RecruitmentPlanModel>();
        public DateTime CurrentDate { get; set; } = new DateTime(2024, 06, 06);
        public List<string> HRDepartmentTypes => new List<string>() { "Recruitment Team", "Accounts Team", "Inventory Team" };
        private string ProgressBarColor { get; set; } = string.Empty;
        private string selectedDepartment = "Recruitment Team";
        private bool isGanttRendered;
        private string currentUri = string.Empty;       

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
            await Task.CompletedTask;
        }

        /// <summary>
        /// Cancels the default Gantt popup behavior.
        /// </summary>
        private async Task PopupHandler(PopupOpenEventArgs<RecruitmentPlanModel> args)
        {
            args.Cancel = true;
            await Task.CompletedTask;
        }

        /// <summary>
        /// Updates the selected schedule and current date when a Gantt row is selected.
        /// </summary>
        private async Task RowSelectedHandler(RowSelectEventArgs<RecruitmentPlanModel> args)
        {
            ScheduleCollection = args.Datas;
            CurrentDate = ScheduleCollection[0].StartTime;
            await Task.CompletedTask;
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
            await Task.CompletedTask;
        }

        /// <summary>
        /// Sets the progress bar color based on the theme inferred from the current URI.
        /// </summary>
        private void UpdateTheme(string currentUri)
        {
            if (currentUri.Contains("fluent-dark"))
            {
                ProgressBarColor = "#036FC1";
            }
            if (currentUri.Contains("fluent2-dark"))
            {
                ProgressBarColor = "#135997";
            }
            else if (currentUri.Contains("fluent2-highcontrast"))
            {
                ProgressBarColor = "#1AEBFF";
            }
            else if (currentUri.Contains("fluent2"))
            {
                ProgressBarColor = "#277AC3";
            }
            else if (currentUri.Contains("fluent"))
            {
                ProgressBarColor = "#1985D8";
            }
            else if (currentUri.Contains("bootstrap5-dark"))
            {
                ProgressBarColor = "#0F67E8";
            }
            else if (currentUri.Contains("bootstrap5"))
            {
                ProgressBarColor = "#257CFD";
            }
            else if (currentUri.Contains("highcontrast"))
            {
                ProgressBarColor = "#3E047D";
            }
            else if (currentUri.Contains("tailwind-dark"))
            {
                ProgressBarColor = "#22C2DC";
            }
            else if (currentUri.Contains("tailwind"))
            {
                ProgressBarColor = "#6058E8";
            }
            else if (currentUri.Contains("material-dark"))
            {
                ProgressBarColor = "#BFADE9";
            }
            else if (currentUri.Contains("material"))
            {
                ProgressBarColor = "#7661AD";
            }
        }
    }
}