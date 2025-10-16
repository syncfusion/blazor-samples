#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Shared;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static blazor_gantt_human_resource_data.HumanResourceData;

namespace BlazorDemos.Pages.GanttChart.GanttChart
{
    public partial class HumanResourceManagement
    {
        [CascadingParameter]
        protected MainLayout? MainLayoutInstance { get; set; }
        private SfGantt<RecruitmentPlanModel> GanttChartInstance { get; set; }= new SfGantt<RecruitmentPlanModel>();
        public string SelectedDepartment { get; set; } = "Recruitment Team";
        private List<RecruitmentPlanModel> GanttTaskCollection { get; set; } = new List<RecruitmentPlanModel>();
        public DateTime CurrentDate { get; set; } = new DateTime(2024, 06, 06);
        private List<RecruitmentPlanModel> ScheduleCollection { get; set; } = new List<RecruitmentPlanModel>();
        public bool IsGanttRendered { get; set; }
        public string CurrentUri { get; set; } = string.Empty;
        public List<string> HRDepartmentTypes => new List<string>() { "Recruitment Team", "Accounts Team", "Inventory Team" };
        private string ProgressBarColor  { get; set; } = string.Empty;
        protected async override Task OnInitializedAsync()
        {
            GanttTaskCollection = RecruitmentHrCollection;
            MainLayoutInstance.Collapse();
            CurrentUri = Navigation.Uri;
            UpdateTheme(CurrentUri);
            await Task.CompletedTask;
        }

        private async Task DataBoundHandler(object args)
        {
            if (!IsGanttRendered)
            {
                IsGanttRendered = true;
                return;
            }
            ScheduleCollection = new List<RecruitmentPlanModel>() { GanttChartInstance.GetCurrentViewRecords().ToList()[1] };
            CurrentDate = ScheduleCollection[0].StartTime;
            await Task.CompletedTask;
        }
        private async Task PopupHandler(PopupOpenEventArgs<RecruitmentPlanModel> args)
        {
            args.Cancel = true;
            await Task.CompletedTask;
        }

        private async Task RowSelectedHandler(RowSelectEventArgs<RecruitmentPlanModel> args)
        {
            ScheduleCollection = args.Datas;
            CurrentDate = ScheduleCollection[0].StartTime;
            await Task.CompletedTask;
        }
        private async void DepartmentChangedHandler(string value)
        {
            SelectedDepartment = value;
            if (value == "Recruitment Team")
            {
                GanttTaskCollection = RecruitmentHrCollection;

            }
            else if (value == "Accounts Team")
            {
                GanttTaskCollection = AccountingHrCollection;
            }
            else
            {
                GanttTaskCollection = InventoryHrCollection;
            }
            await Task.CompletedTask;
        }

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