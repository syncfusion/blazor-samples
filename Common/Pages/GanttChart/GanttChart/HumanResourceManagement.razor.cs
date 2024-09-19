#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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
        protected MainLayout Layout { get; set; }
        SfGantt<RecruitmentPlanModel> ganttInstance = new SfGantt<RecruitmentPlanModel>();
        string department = "Recruitment Team";
        List<RecruitmentPlanModel> GanttTaskCollection = new List<RecruitmentPlanModel>();
        DateTime currentDate = new DateTime(2024, 06, 06);
        List<RecruitmentPlanModel> ScheduleCollection = new List<RecruitmentPlanModel>();
        bool ganttIsRendered;
        public string currentUri;
        List<string> typesOfHR => new List<string>() { "Recruitment Team", "Accounts Team", "Inventory Team" };
        private string progressColor = string.Empty;
        protected async override Task OnInitializedAsync()
        {
            GanttTaskCollection = RecruitmentHrCollection;
            Layout.Collapse();
            currentUri = Navigation.Uri;
            UpdateTheme(currentUri);
            await Task.CompletedTask;
        }

        private async Task DataBoundHandler(object args)
        {
            if (!ganttIsRendered)
            {
                ganttIsRendered = true;
                return;
            }
            ScheduleCollection = new List<RecruitmentPlanModel>() { ganttInstance.GetCurrentViewRecords().ToList()[1] };
            currentDate = ScheduleCollection[0].StartTime;
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
            currentDate = ScheduleCollection[0].StartTime;
            await Task.CompletedTask;
        }
        private async void DepartmentChangedHandler(string value)
        {
            department = value;
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
                progressColor = "#036FC1";
            }
            if (currentUri.Contains("fluent2-dark"))
            {
                progressColor = "#135997";
            }
            else if (currentUri.Contains("fluent2-highcontrast"))
            {
                progressColor = "#1AEBFF";
            }
            else if (currentUri.Contains("fluent2"))
            {
                progressColor = "#277AC3";
            }
            else if (currentUri.Contains("fluent"))
            {
                progressColor = "#1985D8";
            }
            else if (currentUri.Contains("bootstrap5-dark"))
            {
                progressColor = "#0F67E8";
            }
            else if (currentUri.Contains("bootstrap5"))
            {
                progressColor = "#257CFD";
            }
            else if (currentUri.Contains("highcontrast"))
            {
                progressColor = "#3E047D";
            }
            else if (currentUri.Contains("tailwind-dark"))
            {
                progressColor = "#22C2DC";
            }
            else if (currentUri.Contains("tailwind"))
            {
                progressColor = "#6058E8";
            }
            else if (currentUri.Contains("material-dark"))
            {
                progressColor = "#BFADE9";
            }
            else if (currentUri.Contains("material"))
            {
                progressColor = "#7661AD";
            }
        }
    }
}