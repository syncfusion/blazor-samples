#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Gantt;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class Timeline
    {
        public SfGantt<TimelineData.TaskData>? GanttInstance { get; set; }
        public List<TimelineData.TaskData> TaskCollection { get; set; } = new List<TimelineData.TaskData>();
        public int DefaultUnitWidth { get; set; } = 33;
        public int TopTierCount { get; set; } = 1;
        public int BottomTierCount { get; set; } = 1;
        public bool EnableTopNumericBox { get; set; } = true;
        public bool EnableTopUnitDropDown { get; set; } = true;
        public bool EnableTopFormatDropDown { get; set; } = true;
        public bool EnableBottomNumericBox { get; set; } = true;
        public bool EnableBottomUnitDropDown { get; set; } = true;
        public bool EnableBottomFormatDropDown { get; set; } = true;
        public string TopTierFormat { get; set; } = "MMM dd, yyyy";
        public string BottomTierFormat { get; set; } = "";
        public TimelineViewMode TopTierUnit { get; set; } = TimelineViewMode.Week;
        public TimelineViewMode BottomTierUnit { get; set; } = TimelineViewMode.Day;

        /// <summary>
        /// A list of year-level date formats used for timeline display customization.
        /// </summary>
        private List<DayFormat> YearFormats = new List<DayFormat>()
        {
            new DayFormat { Id = "MMM yy", Format = "Jan 18" },
            new DayFormat { Id = "yyyy", Format = "2018" },
            new DayFormat { Id = "MMMM, y", Format = "January, 18" },
        };

        /// <summary>
        /// A list of month-level date formats used for timeline display customization.
        /// </summary>
        private List<DayFormat> MonthFormats = new List<DayFormat>()
        {
            new DayFormat { Id = "MMM dd, yyyy", Format = "Jan 01, 2018" },
            new DayFormat { Id = "MMMM", Format = "January" },
            new DayFormat { Id = "MMM", Format = "Jan" },
        };

        /// <summary>
        /// A list of week-level date formats used for timeline display customization.
        /// </summary>
        private List<DayFormat> WeekFormats = new List<DayFormat>()
        {
            new DayFormat { Id = "MMM dd, yyyy", Format = "Jan 01, 2021" },
            new DayFormat { Id = "ddd MMM dd, yy", Format = "Mon Jan 01, 19" },
            new DayFormat { Id = "ddd MMM dd", Format = "Mon Jan 01" },
        };

        /// <summary>
        /// A list of day-level date formats used for timeline display customization.
        /// </summary>
        private List<DayFormat> DayFormats = new List<DayFormat>()
        {
            new DayFormat { Id = "", Format = "M" },
            new DayFormat { Id = "ddd", Format = "Mon" },
            new DayFormat { Id = "dd", Format = "01" },
        };

        /// <summary>
        /// A list of hour-level time formats used for timeline display customization.
        /// </summary>
        private List<DayFormat> HourFormats = new List<DayFormat>()
        {
            new DayFormat { Id = "hh", Format = "00" },
            new DayFormat { Id = "hh : mm tt", Format = "00 : 00 AM" },
            new DayFormat { Id = "h : mm tt", Format = "0 : 00 AM" },
        };

        /// <summary>
        /// A list of available timeline units used for configuring the Gantt chart tiers.
        /// </summary>
        private List<TimelineUnit> TimelineUnits = new List<TimelineUnit>()
        {
            new TimelineUnit { Id = "Year", Unit = "Year" },
            new TimelineUnit { Id = "Month", Unit = "Month" },
            new TimelineUnit { Id = "Week", Unit = "Week" },
            new TimelineUnit { Id = "Day", Unit = "Day" },
            new TimelineUnit { Id = "Hour", Unit = "Hour" }
        };

        /// <summary>
        /// A list of week-level formats currently selected for the top tier format dropdown.
        /// </summary>
        private List<DayFormat> WeekFormatValue = new List<DayFormat>()
        {
            new DayFormat { Id = "MMM dd, yyyy", Format = "Jan 01, 2021" },
            new DayFormat { Id = "ddd MMM dd, yy", Format = "Mon Jan 01, 19" },
            new DayFormat { Id = "ddd MMM dd", Format = "Mon Jan 01" },
        };

        /// <summary>
        /// A list of day-level formats currently selected for the bottom tier format dropdown.
        /// </summary>
        private List<DayFormat> DayFormatValue = new List<DayFormat>()
        {
            new DayFormat { Id = "", Format = "M" },
            new DayFormat { Id = "ddd", Format = "Mon" },
            new DayFormat { Id = "dd", Format = "01" }
        };

        /// <summary>
        /// Represents a timeline unit option used in dropdowns.
        /// </summary>
        public class TimelineUnit
        {
            public string Id { get; set; } = string.Empty;
            public string Unit { get; set; } = string.Empty;
        }

        /// <summary>
        /// Represents a day format option used in dropdowns.
        /// </summary>
        public class DayFormat
        {
            public string Id { get; set; } = string.Empty;
            public string Format { get; set; } = string.Empty;
        }        

        /// <summary>
        /// Handles the change event for the top tier unit dropdown.
        /// Updates the format and unit width accordingly.
        /// </summary>
        public void TopUnitChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, TimelineUnit> args)
        {
            TimelineViewMode changedTopUnit;
            switch (args.Value)
            {
                case "Year":
                    changedTopUnit = TimelineViewMode.Year;
                    WeekFormatValue = YearFormats;
                    TopTierFormat = "MMM yy";
                    break;
                case "Month":
                    changedTopUnit = TimelineViewMode.Month;
                    WeekFormatValue = MonthFormats;
                    TopTierFormat = "MMM dd, yyyy";
                    break;
                case "Week":
                    changedTopUnit = TimelineViewMode.Week;
                    WeekFormatValue = WeekFormats;
                    TopTierFormat = "MMM dd,yyyy";
                    break;
                case "Day":
                    changedTopUnit = TimelineViewMode.Day;
                    WeekFormatValue = DayFormats;
                    TopTierFormat = "ddd";
                    break;
                case "Hour":
                    changedTopUnit = TimelineViewMode.Hour;
                    WeekFormatValue = HourFormats;
                    TopTierFormat = "hh : mm tt";
                    break;
                default:
                    changedTopUnit = TimelineViewMode.Week;
                    WeekFormatValue = WeekFormats;
                    TopTierFormat = "MMM dd, yyyy";
                    break;
            }
            this.UpdateUnitWidth(args.Value, "top");
            TopTierUnit = changedTopUnit;
        }

        /// <summary>
        /// Handles the change event for the bottom tier unit dropdown.
        /// Updates the format and unit width accordingly.
        /// </summary>
        public void BottomUnitChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, TimelineUnit> args)
        {
            TimelineViewMode changedBottomUnit;
            switch (args.Value)
            {
                case "Year":
                    changedBottomUnit = TimelineViewMode.Year;
                    DayFormatValue = YearFormats;
                    BottomTierFormat = "yyyy";
                    break;
                case "Month":
                    changedBottomUnit = TimelineViewMode.Month;
                    DayFormatValue = MonthFormats;
                    BottomTierFormat = "MMM";
                    break;
                case "Week":
                    changedBottomUnit = TimelineViewMode.Week;
                    DayFormatValue = WeekFormats;
                    BottomTierFormat = "MMM dd, yyyy";
                    break;
                case "Day":
                    changedBottomUnit = TimelineViewMode.Day;
                    DayFormatValue = DayFormats;
                    BottomTierFormat = "dd";
                    break;
                case "Hour":
                    changedBottomUnit = TimelineViewMode.Hour;
                    DayFormatValue = HourFormats;
                    BottomTierFormat = "hh";
                    break;
                default:
                    changedBottomUnit = TimelineViewMode.Day;
                    DayFormatValue = DayFormats;
                    BottomTierFormat = "dd";
                    break;
            }
            this.UpdateUnitWidth(args.Value, "bottom");
            BottomTierUnit = changedBottomUnit;
        }

        /// <summary>
        /// Handles the change event for the top tier format dropdown.
        /// Updates the format string for the top tier.
        /// </summary>
        public void TopFormatChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, DayFormat> args)
        {
            TopTierFormat = TopTierFormat != null ? args.Value != null ? args.Value : "MMM dd" : "MMM dd, yyyy";
        }

        /// <summary>
        /// Handles the change event for the bottom tier format dropdown.
        /// Updates the format string for the bottom tier.
        /// </summary>
        public void BottomFormatChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, DayFormat> args)
        {
            BottomTierFormat = BottomTierFormat != null ? args.Value != null ? args.Value : "ddd MMM dd" : "MMM dd";
        }

        /// <summary>
        /// Updates the unit width based on the selected timeline unit and tier.
        /// </summary
        void UpdateUnitWidth(string unit, string tier)
        {
            int unitWidth;
            string topUnit = tier == "top" ? unit : TopTierUnit.ToString();
            string bottomUnit = tier == "bottom" ? unit : BottomTierUnit.ToString();
            string[] units = new string[6] { "None", "Hour", "Day", "Week", "Month", "Year" };
            string bootomCellUnit;
            if (Array.IndexOf(units, topUnit) == 0 && Array.IndexOf(units, bottomUnit) == 0)
            {
                bootomCellUnit = "Day";
            }
            else if (Array.IndexOf(units, topUnit) == 0 && Array.IndexOf(units, bottomUnit) > 0)
            {
                bootomCellUnit = bottomUnit;
            }
            else if (Array.IndexOf(units, topUnit) > 0 && Array.IndexOf(units, bottomUnit) == 0)
            {
                bootomCellUnit = topUnit;
            }
            else if (Array.IndexOf(units, topUnit) <= Array.IndexOf(units, bottomUnit))
            {
                bootomCellUnit = topUnit;
            }
            else
            {
                bootomCellUnit = bottomUnit;
            }

            switch (bootomCellUnit)
            {
                case "Year":
                    unitWidth = 2000;
                    break;
                case "Month":
                    unitWidth = 300;
                    break;
                case "Week":
                    unitWidth = 150;
                    break;
                case "Day":
                    unitWidth = 33;
                    break;
                case "Hour":
                    unitWidth = 25;
                    break;
                default:
                    unitWidth = 33;
                    break;
            }

            DefaultUnitWidth = unitWidth;
        }
    }
}
