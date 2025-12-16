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
using Syncfusion.Blazor.Calendars;
using Syncfusion.Blazor.Data;
using Syncfusion.Blazor.Gantt;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static BlazorDemos.Pages.GanttChart.Data.AirlineTrackerData;  

namespace BlazorDemos.Pages.GanttChart
{
    public partial class AirlineTracker
    {
        [CascadingParameter]
        protected MainLayout? Layout { get; set; }
        public SfGantt<AirlineInfoModel> GanttInstance { get; set; } = new SfGantt<AirlineInfoModel>();
        public List<AirlineInfoModel> AirlineInformations { get; set; } = new List<AirlineInfoModel>();
        public string[] Airlines { get; set; } = new string[] { "Delta Airlines", "United Airlines", "American Airlines", "Southwest Airlines", "JetBlue Airways", "Alaska Airlines", "British Airways", "Lufthansa" };
        public string[] StartPlaces { get; set; } = new string[] { "JFK", "LAS", "ATL", "ORD", "DFW", "MCO", "SEA", "LHR", "FRA", "DOH" };
        public string[] DestinationPlaces { get; set; } = new string[] { "LAS", "ATL", "BWI", "SFO", "LHR", "JFK", "LAX", "MIA", "ORD" };
        public string FlightNumber { get; set; } = string.Empty;
        public string AirlineName { get; set; } = string.Empty;        
        public string FlightOrigin { get; set; } = string.Empty;
        public string FlightDestination { get; set; } = string.Empty;
        public Query QueryCollection { get; set; } = new Query();
        public static string SearchButtonColor { get; set; } = string.Empty;
        public static string ClearButtonColor { get; set; } = string.Empty;
        public static string ClearButtonBackgroundColor { get; set; } = string.Empty;
        public static string LabelColor { get; set; } = string.Empty;
        public static string ClearButtonBorderColor { get; set; } = string.Empty;
        public static string SearchInputBackgroundColor { get; set; } = string.Empty;
        public Theme CurrentTheme { get; set; }
        public bool IsSidebarVisible { get; set; } = false;
        public bool SidebarToggle { get; set; } = false;
        private DateTime departureDate;
        private DateTime arrivalDate;        
       
        /// <summary>
        /// Returns the CSS style string based on the flight status and current theme.
        /// </summary>
        private string GetStatusContentStyles(string? status)
        {
            string statusContentstyleColor = string.Empty;
            var navURL = NavigationManager.Uri;
            string color = string.Empty;
            if (string.IsNullOrEmpty(status))
            {
                return string.Empty;
            }
            switch (status)
            {
                case "ON TIME":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        statusContentstyleColor = "#218C21";
                        color = "#FFFFFF";
                    }
                    else
                    {
                        statusContentstyleColor = "#107C10";
                        color = "#FFFFFF";
                    }
                    break;
                case "SCHEDULED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        statusContentstyleColor = "#F87528";
                        color = "#242424";
                    }
                    else
                    {
                        statusContentstyleColor = "#F7630C";
                        color = "#242424";
                    }
                    break;
                case "DELAYED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        statusContentstyleColor = "#CC2635";
                        color = "#FFFFFF";
                    }
                    else
                    {
                        statusContentstyleColor = "#C50F1F";
                        color = "#FFFFFF";
                    }
                    break;
                case "LANDED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        statusContentstyleColor = "#218C21";
                        color = "#FFFFFF";
                    }
                    else
                    {
                        statusContentstyleColor = "#107C10";
                        color = "#FFFFFF";
                    }
                    break;
                case "CANCELLED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        statusContentstyleColor = "#CC2635";
                        color = "#FFFFFF";
                    }
                    else
                    {
                        statusContentstyleColor = "#C50F1F";
                        color = "#FFFFFF";
                    }
                    break;
            }
            return $"background:{statusContentstyleColor};color: {color};padding: 5px 8px;border-radius: 4px;font-size: 12px !important; font-weight: 500 !important;";
        }

        /// <summary>
        /// Updates the flight number based on the given input.
        /// </summary>
        private void FlightNumberHandler(string value)
        {
            FlightNumber = value;
        }

        /// <summary>
        /// Updates the departure and arrival dates based on the selected range.
        /// </summary>
        private void DateValueChangeHandler(RangePickerEventArgs<DateTime?> args)
        {
            departureDate = args.StartDate != null ? args.StartDate.Value : new DateTime();
            arrivalDate = args.EndDate != null ? args.EndDate.Value : new DateTime();
        }

        /// <summary>
        /// Updates the airline name based on the given input.
        /// </summary>
        private void FlightAirlineHandler(string value)
        {
            AirlineName = value;
        }

        /// <summary>
        /// Updates the flight origin based on the given input.
        /// </summary>
        private void FlightOriginHandler(string value)
        {
            FlightOrigin = value;
        }

        /// <summary>
        /// Updates the flight destination based on the given input.
        /// </summary>
        private void FlightDestinationHandler(string value)
        {
            FlightDestination = value;
        }

        /// <summary>
        /// Applies filters to the Gantt chart based on flight details and updates the query collection.
        /// </summary>
        private async Task FilterHandler()
        {
            List<WhereFilter> predicateList = new List<WhereFilter>();
            if (!string.IsNullOrEmpty(FlightNumber))
            {
                predicateList.Add(new WhereFilter()
                {
                    Field = "FlightId",
                    Operator = "contains",
                    Condition = "and",
                    value = FlightNumber,
                    IgnoreCase = true,
                });
            }
            if (arrivalDate.Ticks != 0 && arrivalDate.Date.Ticks != DateTime.Now.Date.Ticks)
            {
                predicateList.Add(new WhereFilter()
                {
                    Field = "Arrival",
                    Operator = "contains",
                    Condition = "lessthanorequal",
                    value = arrivalDate,
                    IgnoreCase = true,
                });
            }
            if (departureDate.Ticks != 0 && departureDate.Date.Ticks != DateTime.Now.Date.Ticks)
            {
                predicateList.Add(new WhereFilter()
                {
                    Field = "Departure",
                    Operator = "greaterthanorequal",
                    Condition = "and",
                    value = departureDate,
                    IgnoreCase = true,
                });
            }

            if (!string.IsNullOrEmpty(AirlineName))
            {
                predicateList.Add(new WhereFilter()
                {
                    Field = "Airline",
                    Operator = "contains",
                    Condition = "and",
                    value = AirlineName,
                    IgnoreCase = true,
                });
            }

            if (!string.IsNullOrEmpty(FlightOrigin))
            {
                predicateList.Add(new WhereFilter()
                {
                    Field = "Origin",
                    Operator = "contains",
                    Condition = "and",
                    value = FlightOrigin,
                    IgnoreCase = true,
                });
            }
            if (!string.IsNullOrEmpty(FlightDestination))
            {
                predicateList.Add(new WhereFilter()
                {
                    Field = "Destination",
                    Operator = "contains",
                    Condition = "and",
                    value = FlightDestination,
                    IgnoreCase = true,
                });
            }
            QueryCollection = new Query().Where(WhereFilter.And(predicateList));
            await Task.CompletedTask;
        }

        /// <summary>
        /// Clears all applied filters and resets the query collection.
        /// </summary>
        private async Task ClearFilterHandler()
        {
            FlightNumber = string.Empty;
            FlightOrigin = string.Empty;
            FlightDestination = string.Empty;
            AirlineName = string.Empty;
            departureDate = new DateTime();
            arrivalDate = new DateTime();
            QueryCollection = new Query();
            await Task.CompletedTask;
        }

        /// <summary>
        /// Determines the current theme based on the navigation URL and returns the corresponding Theme enum.
        /// Also sets global color values for UI elements based on the theme.
        /// </summary>
        private static Theme GetCurrentTheme(string navURL)
        {
            if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
            {
                SearchButtonColor = "#FFFFFF";
                ClearButtonColor = "#FFFFFF";
                ClearButtonBackgroundColor = "#292929";
                LabelColor = "#FFFFFF";
                ClearButtonBorderColor = "#D1D1D1";
                SearchInputBackgroundColor = "#141414";
            }
            else
            {
                SearchButtonColor = "#FFFFFF";
                ClearButtonColor = "#242424";
                ClearButtonBackgroundColor = "#FFFFFF";
                LabelColor = "#242424";
                ClearButtonBorderColor = "#666666";
                SearchInputBackgroundColor = "#F5F5F5";
            }

            if (navURL.IndexOf("material3") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    return Theme.Material3Dark;
                }
                else
                {
                    return Theme.Material3;
                }
            }
            else if (navURL.IndexOf("material") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    return Theme.MaterialDark;
                }
                else
                {
                    return Theme.Material;
                }
            }
            else if (navURL.IndexOf("fabric") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    return Theme.FabricDark;
                }
                else
                {
                    return Theme.Fabric;
                }
            }
            else if (navURL.IndexOf("bootstrap5") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    return Theme.Bootstrap5Dark;
                }
                else
                {
                    return Theme.Bootstrap5;
                }
            }
            else if (navURL.IndexOf("bootstrap4") > -1)
            {
                return Theme.Bootstrap4;
            }
            else if (navURL.IndexOf("bootstrap") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    return Theme.BootstrapDark;
                }
                else
                {
                    return Theme.Bootstrap;
                }
            }
            else if (navURL.IndexOf("tailwind") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    return Theme.TailwindDark;
                }
                else
                {
                    return Theme.Tailwind;
                }
            }
            else if (navURL.IndexOf("fluent2") > -1)
            {
                if (navURL.IndexOf("highcontrast") > -1)
                {
                    return Theme.Fluent2HighContrast;
                }
                else if (navURL.IndexOf("dark") > -1)
                {
                    return Theme.Fluent2Dark;
                }
                else
                {
                    return Theme.Fluent2;
                }
            }
            else if (navURL.IndexOf("fluent") > -1)
            {
                if (navURL.IndexOf("dark") > -1)
                {
                    return Theme.FluentDark;
                }
                else
                {
                    return Theme.Fluent;
                }
            }
            else if (navURL.IndexOf("highcontrast") > -1)
            {
                return Theme.HighContrast;
            }
            else
            {
                return Theme.Bootstrap4;
            }
        }

        /// <summary>
        /// Returns the background color for parent tasks based on the current theme.
        /// </summary>
        private string GetParentBgColor()
        {
            var navURL = NavigationManager.Uri;
            string color = string.Empty;
            if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
            {
                color = "#0E4775";
            }
            else
            {
                color = "#B4D6FA";
            }
            return color;
        }

        /// <summary>
        /// Returns the progress bar color for parent tasks based on the current theme.
        /// </summary>
        private string GetParentProgressColor()
        {
            var navURL = NavigationManager.Uri;
            string color = string.Empty;
            if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
            {
                color = "#115EA3";
            }
            else
            {
                color = "#0F6CBD";
            }
            return color;
        }

        /// <summary>
        /// Returns the background color for child tasks based on flight status and theme.
        /// </summary>
        private string GetChildBgColor(AirlineInfoModel record)
        {
            var navURL = NavigationManager.Uri;
            string color = string.Empty;
            string status = record.Status;
            switch (status)
            {
                case "ON TIME":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        color = "#107C10";
                    }
                    else
                    {
                        color = "#107C10";
                    }
                    break;
                case "SCHEDULED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        color = "#4A1E04";
                    }
                    else
                    {
                        color = "#FEE5D7";
                    }
                    break;
                case "DELAYED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        color = "#6E0811";
                    }
                    else
                    {
                        color = "#EEACB2";
                    }
                    break;
                case "LANDED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        color = "#107C10";
                    }
                    else
                    {
                        color = "#107C10";
                    }
                    break;
                case "CANCELLED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        color = "#6E0811";
                    }
                    else
                    {
                        color = "#EEACB2";
                    }
                    break;
            }
            return color;
        }

        /// <summary>
        /// Returns the progress bar color for child tasks based on flight status and theme.
        /// </summary>
        private string GetChildProgressColor(AirlineInfoModel record)
        {
            var navURL = NavigationManager.Uri;
            string color = string.Empty;
            string status = record.Status;
            switch (status)
            {
                case "ON TIME":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        color = "#107C10";
                    }
                    else
                    {
                        color = "#107C10";
                    }
                    break;
                case "SCHEDULED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        color = "#FAA06B";
                    }
                    else
                    {
                        color = "#BC4B09";
                    }
                    break;
                case "DELAYED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        color = "#6E0811";
                    }
                    else
                    {
                        color = "#EEACB2";
                    }
                    break;
                case "LANDED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        color = "#107C10";
                    }
                    else
                    {
                        color = "#107C10";
                    }
                    break;
                case "CANCELLED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        color = "#6E0811";
                    }
                    else
                    {
                        color = "#EEACB2";
                    }
                    break;
            }
            return color;
        }

        /// <summary>
        /// Returns the image name for parent tasks based on the current theme.
        /// </summary>
        private string GetParentImageName()
        {
            var navURL = NavigationManager.Uri;
            string imgName = string.Empty;
            if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
            {
                imgName = "flight-blue-dark.png";
            }
            else
            {
                imgName = "flight-blue-icon.png";
            }
            return imgName;
        }

        /// <summary>
        /// Returns the image name for child tasks based on flight status and theme.
        /// </summary>
        private string GetImageName(AirlineInfoModel record)
        {
            var navURL = NavigationManager.Uri;
            string imgName = string.Empty;
            string status = record.Status;
            switch (status)
            {
                case "ON TIME":
                    imgName = "flight-green-icon.png";
                    break;
                case "SCHEDULED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        imgName = "flight-orange-dark.png";
                    }
                    else
                    {
                        imgName = "flight-orange-icon.png";
                    }
                    break;
                case "DELAYED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        imgName = "flight-red-dark.png";
                    }
                    else
                    {
                        imgName = "flight-red-icon.png";
                    }
                    break;
                case "LANDED":
                    imgName = "flight-green-icon.png";
                    break;
                case "CANCELLED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        imgName = "flight-red-dark.png";
                    }
                    else
                    {
                        imgName = "flight-red-icon.png";
                    }
                    break;
            }
            return imgName;
        }
        /// <summary>
        /// Returns the color for the left label on the taskbar based on flight status and theme.
        /// </summary>
        private string GetTaskbarLeftLabelColor(AirlineInfoModel record)
        {
            var navURL = NavigationManager.Uri;
            string color = string.Empty;
            string status = record.Status;
            switch (status)
            {
                case "ON TIME":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        color = "#107C10";
                    }
                    else
                    {
                        color = "#107C10";
                    }
                    break;
                case "SCHEDULED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        color = "#FAA06B";
                    }
                    else
                    {
                        color = "#BC4B09";
                    }
                    break;
                case "DELAYED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        color = "#DC626D";
                    }
                    else
                    {
                        color = "#D13438";
                    }
                    break;
                case "LANDED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        color = "#107C10";
                    }
                    else
                    {
                        color = "#107C10";
                    }
                    break;
                case "CANCELLED":
                    if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
                    {
                        color = "#DC626D";
                    }
                    else
                    {
                        color = "#D13438";
                    }
                    break;
            }
            return color;
        }

        /// <summary>
        /// Toggles the sidebar visibility when the toolbar button is clicked.
        /// </summary>
        private void OnToggleClick()
        {
            SidebarToggle = !SidebarToggle;
            IsSidebarVisible = true;
        }

        /// <summary>
        /// Closes the sidebar by setting the toggle state to false.
        /// </summary>
        public void Close()
        {
            SidebarToggle = false;
        }
    }
}