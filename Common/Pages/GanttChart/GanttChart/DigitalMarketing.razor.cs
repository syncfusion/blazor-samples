#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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
        protected MainLayout Layout { get; set; }
        SfGantt<TaskInfoModel> ganttInstance { get; set; }
        List<BarChartModel> barChartData = new List<BarChartModel>();
        List<LineChartModel> lineChartData = new List<LineChartModel>();
        List<Statistics> statisticsDetails = new List<Statistics>();
        List<TaskInfoModel> DigitalMarketingCollection { get; set; }
        static string chartBGColor;
        static string labelColor;
        static string labelBGColor;
        static string taskBGColor;
        static string progressColor;
        static string parentTaskBGColor;
        static string parentProgressColor;
        static string chartFillColor;
        Theme currentTheme;

        protected override void OnInitialized()
        {
            currentTheme = GetCurrentTheme(NavigationManager.Uri);
            DigitalMarketingCollection = DigitalMarketCollection;
            Layout.Collapse();
            foreach (var data in DigitalMarketingCollection)
            {
                if (!data.ParentId.HasValue && data.Activity != "SEO")
                {
                    Statistics statistics = new Statistics();
                    LineChartModel lineChartData = new LineChartModel();
                    string activity2 = (lineChartData.X = data.Activity);
                    statistics.Activity = activity2;
                    statistics.Impressions = data.Impressions;
                    lineChartData.Y = data.ConversionRate * 100.0;
                    statisticsDetails.Add(statistics);
                    this.lineChartData.Add(lineChartData);
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

            barChartData = monthlyRevenue.Select(mr => new BarChartModel
            {
                Month = mr.Key,
                Revenue = mr.Value
            }).ToList();
        }


        private static Theme GetCurrentTheme(string navURL)
        {
            if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
            {
                labelColor = "#FFFFFF";
                labelBGColor = "#292929";
                progressColor = "#107C10";
                taskBGColor = "#094509";
                parentProgressColor = "#115EA3";
                parentTaskBGColor = "#0E4775";
                chartFillColor = "#43B786";
            }
            else
            {
                labelColor = "#242424";
                labelBGColor = "#FFFFFF";
                progressColor = "#107C10";
                taskBGColor = "#54B054";
                parentProgressColor = "#0F6CBD";
                parentTaskBGColor = "#B4D6FA";
                chartFillColor = "#0076E5";
            }

            if (navURL.IndexOf("material3") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    chartBGColor = "#292929";
                    return Theme.Material3Dark;
                }
                else
                {
                    chartBGColor = "#FFFFFF";
                    return Theme.Material3;
                }
            }
            else if (navURL.IndexOf("material") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    chartBGColor = "#292929";
                    return Theme.MaterialDark;
                }
                else
                {
                    chartBGColor = "#FFFFFF";
                    return Theme.Material;
                }
            }
            else if (navURL.IndexOf("fabric") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    chartBGColor = "#292929";
                    return Theme.FabricDark;
                }
                else
                {
                    chartBGColor = "#FFFFFF";
                    return Theme.Fabric;
                }
            }
            else if (navURL.IndexOf("bootstrap5") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    chartBGColor = "#292929";
                    return Theme.Bootstrap5Dark;
                }
                else
                {
                    chartBGColor = "#FFFFFF";
                    return Theme.Bootstrap5;
                }
            }
            else if (navURL.IndexOf("bootstrap4") > -1)
            {
                chartBGColor = "#292929";
                return Theme.Bootstrap4;
            }
            else if (navURL.IndexOf("bootstrap") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    chartBGColor = "#292929";
                    return Theme.BootstrapDark;
                }
                else
                {
                    chartBGColor = "#FFFFFF";
                    return Theme.Bootstrap;
                }
            }
            else if (navURL.IndexOf("tailwind") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    chartBGColor = "#292929";
                    return Theme.TailwindDark;
                }
                else
                {
                    chartBGColor = "#FFFFFF";
                    return Theme.Tailwind;
                }
            }
            else if (navURL.IndexOf("fluent2") > -1)
            {
                if (navURL.IndexOf("highcontrast") > -1)
                {
                    chartBGColor = "#292929";
                    return Theme.Fluent2Dark;
                }
                else if (navURL.IndexOf("dark") > -1)
                {
                    chartBGColor = "#292929";
                    return Theme.Fluent2Dark;
                }
                else
                {
                    chartBGColor = "#FFFFFF";
                    return Theme.Fluent2;
                }
            }
            else if (navURL.IndexOf("fluent") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    chartBGColor = "#292929";
                    return Theme.FluentDark;
                }
                else
                {
                    chartBGColor = "#FFFFFF";
                    return Theme.Fluent;
                }
            }
            else if (navURL.IndexOf("highcontrast") > -1)
            {
                chartBGColor = "#292929";
                return Theme.HighContrast;
            }
            else
            {
                chartBGColor = "#FFFFFF";
                return Theme.Bootstrap4;
            }
        }
    }
}