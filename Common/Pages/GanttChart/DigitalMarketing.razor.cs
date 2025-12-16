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
using Syncfusion.Blazor.Charts;
using Syncfusion.Blazor.Gantt;
using System;
using System.Collections.Generic;
using System.Linq;
using static BlazorDemos.Pages.GanttChart.Data.DigitalMarketingData;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class DigitalMarketing
    {
        [CascadingParameter]
        protected MainLayout? MainLayoutInstance { get; set; }
        public SfGantt<TaskInfoModel>? GanttInstance { get; set; }
        public List<BarChartModel> BarChartData { get; set; } = new List<BarChartModel>();
        public List<LineChartModel> LineChartData { get; set; } = new List<LineChartModel>();
        public List<Statistics> StatisticsDetails { get; set; } = new List<Statistics>();
        public List<TaskInfoModel> DigitalMarketingCollection { get; set; } = new List<TaskInfoModel>();
        public static string ChartBackgroundColor { get; set; } = string.Empty;
        public static string LabelTextColor { get; set; } = string.Empty;
        public static string LabelBackgroundColor { get; set; } = string.Empty;
        public static string TaskBackgroundColor { get; set; } = string.Empty;
        public static string ProgressBarColor { get; set; } = string.Empty;
        public static string ParentTaskBackgroundColor { get; set; } = string.Empty;
        public static string ParentProgressBarColor { get; set; } = string.Empty;
        public static string ChartFillColor { get; set; } = string.Empty;
        public Theme CurrentTheme { get; set; }
#pragma warning disable BL0005 // Component parameter should not be set outside of its component.
        public ChartAxisTitleStyle ChartTitleStyle { get; set; } = new ChartAxisTitleStyle { Color = LabelTextColor };
#pragma warning restore BL0005 // Component parameter should not be set outside of its component.        

        /// <summary>
        /// Determines the current theme based on the navigation URL and sets appropriate colors for chart and Gantt elements.
        /// </summary>
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