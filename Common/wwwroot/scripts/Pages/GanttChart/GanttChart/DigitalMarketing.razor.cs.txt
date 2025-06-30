#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Shared;
using Syncfusion.Blazor.Gantt;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using static blazor_gantt_digital_marketing_data.DigitalMarketingData;
using Syncfusion.Blazor;

namespace BlazorDemos.Pages.GanttChart.GanttChart
{
    public partial class DigitalMarketing
    {
        [CascadingParameter]
        protected MainLayout MainLayoutInstance { get; set; }
        private SfGantt<TaskInfoModel> GanttInstance { get; set; }
        private List<BarChartModel> BarChartData { get; set; } = new List<BarChartModel>();
        private List<LineChartModel> LineChartData { get; set; } = new List<LineChartModel>();
        private List<Statistics> StatisticsDetails { get; set; } = new List<Statistics>();
        private List<TaskInfoModel> DigitalMarketingCollection { get; set; }
        public static string ChartBackgroundColor { get; set; }
        public static string LabelTextColor { get; set; }
        public static string LabelBackgroundColor { get; set; }
        public static string TaskBackgroundColor { get; set; }
        public static string ProgressBarColor { get; set; }
        public static string ParentTaskBackgroundColor { get; set; }
        public static string ParentProgressBarColor { get; set; }
        public static string ChartFillColor { get; set; }
        public Theme CurrentTheme { get; set; }

        protected override void OnInitialized()
        {
            CurrentTheme = GetCurrentTheme(UriHelper.Uri);
            DigitalMarketingCollection = DigitalMarketCollection;
            MainLayoutInstance.Collapse();
            foreach (var data in DigitalMarketingCollection)
            {
                if (!data.ParentId.HasValue && data.Activity != "SEO")
                {
                    Statistics statistics = new Statistics();
                    LineChartModel LineChartData = new LineChartModel();
                    string activity2 = (LineChartData.X = data.Activity);
                    statistics.Activity = activity2;
                    statistics.Impressions = data.Impressions;
                    LineChartData.Y = data.ConversionRate * 100.0;
                    StatisticsDetails.Add(statistics);
                    this.LineChartData.Add(LineChartData);
                }
            }
            var childRecords = DigitalMarketingCollection.Where(t => t.ParentId.HasValue).ToList();

            var monthlyRevenue = new Dictionary<string, double>();

            foreach (var record in childRecords)
            {
                if (record.StartDate.HasValue && !string.IsNullOrEmpty(record.Duration))
                {
                    DateTime startDate = record.StartDate.Value;
                    int durationDays = int.Parse(record.Duration.Split(' ')[0]);
                    DateTime endDate = startDate.AddDays(durationDays);

                    while (startDate <= endDate)
                    {
                        string monthYear = startDate.ToString("MMM yy");

                        if (!monthlyRevenue.ContainsKey(monthYear))
                        {
                            monthlyRevenue[monthYear] = 0;
                        }

                        monthlyRevenue[monthYear] += record.Revenue;

                        startDate = startDate.AddMonths(1);
                        if (startDate.Day > 1)
                        {
                            startDate = new DateTime(startDate.Year, startDate.Month, 1);
                        }
                    }
                }
            }

            BarChartData = monthlyRevenue.Select(mr => new BarChartModel
            {
                Month = mr.Key,
                Revenue = mr.Value
            }).ToList();
        }


        private static Theme GetCurrentTheme(string navURL)
        {
            if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
            {
                LabelTextColor = "#FFFFFF";
                LabelBackgroundColor = "#292929";
                ProgressBarColor = "#107C10";
                TaskBackgroundColor = "#094509";
                ParentProgressBarColor = "#115EA3";
                ParentTaskBackgroundColor = "#0E4775";
                ChartFillColor = "#43B786";
            }
            else
            {
                LabelTextColor = "#242424";
                LabelBackgroundColor = "#FFFFFF";
                ProgressBarColor = "#107C10";
                TaskBackgroundColor = "#54B054";
                ParentProgressBarColor = "#0F6CBD";
                ParentTaskBackgroundColor = "#B4D6FA";
                ChartFillColor = "#0076E5";
            }

            if (navURL.IndexOf("material3") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    ChartBackgroundColor = "#292929";
                    return Theme.Material3Dark;
                }
                else
                {
                    ChartBackgroundColor = "#FFFFFF";
                    return Theme.Material3;
                }
            }
            else if (navURL.IndexOf("material") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    ChartBackgroundColor = "#292929";
                    return Theme.MaterialDark;
                }
                else
                {
                    ChartBackgroundColor = "#FFFFFF";
                    return Theme.Material;
                }
            }
            else if (navURL.IndexOf("fabric") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    ChartBackgroundColor = "#292929";
                    return Theme.FabricDark;
                }
                else
                {
                    ChartBackgroundColor = "#FFFFFF";
                    return Theme.Fabric;
                }
            }
            else if (navURL.IndexOf("bootstrap5") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    ChartBackgroundColor = "#292929";
                    return Theme.Bootstrap5Dark;
                }
                else
                {
                    ChartBackgroundColor = "#FFFFFF";
                    return Theme.Bootstrap5;
                }
            }
            else if (navURL.IndexOf("bootstrap4") > -1)
            {
                ChartBackgroundColor = "#292929";
                return Theme.Bootstrap4;
            }
            else if (navURL.IndexOf("bootstrap") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    ChartBackgroundColor = "#292929";
                    return Theme.BootstrapDark;
                }
                else
                {
                    ChartBackgroundColor = "#FFFFFF";
                    return Theme.Bootstrap;
                }
            }
            else if (navURL.IndexOf("tailwind") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    ChartBackgroundColor = "#292929";
                    return Theme.TailwindDark;
                }
                else
                {
                    ChartBackgroundColor = "#FFFFFF";
                    return Theme.Tailwind;
                }
            }
            else if (navURL.IndexOf("fluent2") > -1)
            {
                if (navURL.IndexOf("highcontrast") > -1)
                {
                    ChartBackgroundColor = "#292929";
                    return Theme.Fluent2Dark;
                }
                else if (navURL.IndexOf("dark") > -1)
                {
                    ChartBackgroundColor = "#292929";
                    return Theme.Fluent2Dark;
                }
                else
                {
                    ChartBackgroundColor = "#FFFFFF";
                    return Theme.Fluent2;
                }
            }
            else if (navURL.IndexOf("fluent") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    ChartBackgroundColor = "#292929";
                    return Theme.FluentDark;
                }
                else
                {
                    ChartBackgroundColor = "#FFFFFF";
                    return Theme.Fluent;
                }
            }
            else if (navURL.IndexOf("highcontrast") > -1)
            {
                ChartBackgroundColor = "#292929";
                return Theme.HighContrast;
            }
            else
            {
                ChartBackgroundColor = "#FFFFFF";
                return Theme.Bootstrap4;
            }
        }
    }
}