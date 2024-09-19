#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Shared;
using Syncfusion.Blazor.Gantt;
using System.Collections.Generic;
using System.Threading.Tasks;
using Syncfusion.Blazor.Data;
using Syncfusion.Blazor.Calendars;
using System;
using Microsoft.AspNetCore.Components;
using static blazor_gantt_airline_data.AirlineTrackerData;
using Syncfusion.Blazor;
using blazor_gantt_airline_data;
using Syncfusion.Blazor.Navigations;

namespace BlazorDemos.Pages.GanttChart.GanttChart
{
    public partial class AirlineTracker
    {
        [CascadingParameter]
        protected MainLayout Layout { get; set; }
        SfGantt<AirlineInfoModel> ganttInstance { get; set; } = new SfGantt<AirlineInfoModel>();
        List<AirlineInfoModel> AirlineInformations { get; set; } = new List<AirlineInfoModel>();
        string[] airlines { get; set; } = new string[] { "Delta Airlines", "United Airlines", "American Airlines", "Southwest Airlines", "JetBlue Airways", "Alaska Airlines", "British Airways", "Lufthansa" };
        string[] startPlaces { get; set; } = new string[] { "JFK", "LAS", "ATL", "ORD", "DFW", "MCO", "SEA", "LHR", "FRA", "DOH" };
        string[] destinationPlaces { get; set; } = new string[] { "LAS", "ATL", "BWI", "SFO", "LHR", "JFK", "LAX", "MIA", "ORD" };
        string flightNumber = string.Empty;
        string airlineName = string.Empty;
        DateTime departureDate;
        DateTime arrivalDate;
        string flightOrigin = string.Empty;
        string flightDestination = string.Empty;
        Query queryCollection = new Query();
        static string searchBtnColor;
        static string clearBtnColor;
        static string clearBtnBgColor;
        static string labelColor;
        static string clearBtnBorderColor;
        static string searchInputBgColor;
        Theme currentTheme;
        SidebarPosition Position { get; set; } = SidebarPosition.Left;
        bool SidebarToggle = false;
        public bool IsSideBar = false;
        // Specifies the event handler for Clicked event in Toolbar component. It's used to open/close the Sidebar component. 
        protected override async Task OnInitializedAsync()
        {
            currentTheme = GetCurrentTheme(NavigationManager.Uri);
            Layout.Collapse();
            AirlineInformations = FlightProcessCollection;
            await Task.CompletedTask;
        }

        private string GetStatusContentStyles(string status)
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
        private void FlightNumberHandler(string value)
        {
            flightNumber = value;
        }

        private void DateValueChangeHandler(RangePickerEventArgs<DateTime?> args)
        {
            departureDate = args.StartDate != null ? args.StartDate.Value : new DateTime();
            arrivalDate = args.EndDate != null ? args.EndDate.Value : new DateTime();
        }
        private void FlightAirlineHandler(string value)
        {
            airlineName = value;
        }
        private void FlightOriginHandler(string value)
        {
            flightOrigin = value;
        }
        private void FlightDestinationHandler(string value)
        {
            flightDestination = value;
        }

        private async Task FilterHandler()
        {
            List<WhereFilter> predicateList = new List<WhereFilter>();
            if (!string.IsNullOrEmpty(flightNumber))
            {
                predicateList.Add(new WhereFilter()
                {
                    Field = "FlightId",
                    Operator = "contains",
                    Condition = "and",
                    value = flightNumber,
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

            if (!string.IsNullOrEmpty(airlineName))
            {
                predicateList.Add(new WhereFilter()
                {
                    Field = "Airline",
                    Operator = "contains",
                    Condition = "and",
                    value = airlineName,
                    IgnoreCase = true,
                });
            }

            if (!string.IsNullOrEmpty(flightOrigin))
            {
                predicateList.Add(new WhereFilter()
                {
                    Field = "Origin",
                    Operator = "contains",
                    Condition = "and",
                    value = flightOrigin,
                    IgnoreCase = true,
                });
            }
            if (!string.IsNullOrEmpty(flightDestination))
            {
                predicateList.Add(new WhereFilter()
                {
                    Field = "Destination",
                    Operator = "contains",
                    Condition = "and",
                    value = flightDestination,
                    IgnoreCase = true,
                });
            }
            queryCollection = new Query().Where(WhereFilter.And(predicateList));
            await Task.CompletedTask;
        }
        private async Task ClearFilterHandler()
        {
            flightNumber = string.Empty;
            flightOrigin = string.Empty;
            flightDestination = string.Empty;
            airlineName = string.Empty;
            departureDate = new DateTime();
            arrivalDate = new DateTime();
            queryCollection = new Query();
            await Task.CompletedTask;
        }
        private static Theme GetCurrentTheme(string navURL)
        {
            if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
            {
                searchBtnColor = "#FFFFFF";
                clearBtnColor = "#FFFFFF";
                clearBtnBgColor = "#292929";
                labelColor = "#FFFFFF";
                clearBtnBorderColor = "#D1D1D1";
                searchInputBgColor = "#141414";
            }
            else
            {
                searchBtnColor = "#FFFFFF";
                clearBtnColor = "#242424";
                clearBtnBgColor = "#FFFFFF";
                labelColor = "#242424";
                clearBtnBorderColor = "#666666";
                searchInputBgColor = "#F5F5F5";
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

        private void onToggleClick()
        {
            SidebarToggle = !SidebarToggle;
            IsSideBar = true;
        }
        public void Close()
        {
            SidebarToggle = false;
        }
    }
}