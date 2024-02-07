#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
namespace BlazorDemos.Pages.PivotView.PivotTable
{
    public class RegionData
    {
        public List<string> Country { get; set; }
        public string Region { get; set; }

        public static List<RegionData> Data = new List<RegionData>()
        {
            new RegionData { Country = new List<string> (){"Canada", "United States", "Mexico" }, Region = "North America" },
            new RegionData { Country= new List<string> (){"Turkey", "Saudi Arabia" }, Region = "Middle East" },
            new RegionData { Country= new List<string> (){"Russia", "Germany", "France", "United Kingdom", "Italy" }, Region = "Europe" },
            new RegionData { Country= new List<string> (){"South Africa" }, Region = "Africa" },
            new RegionData { Country = new List<string> () {"Australia", "China", "India", "Indonesia",
              "Japan", "South Korea" }, Region = "Asia Pacific" },
              new RegionData { Country = new List<string> () { "Brazil" }, Region = "South America" }
        };
    }
}