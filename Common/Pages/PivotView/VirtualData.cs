#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
namespace BlazorDemos.Pages.PivotView.PivotTable
{
    public class PivotVirtualData
    {
        public string ProductID { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public  double Sold { get; set; }

        public static List<PivotVirtualData> GetVirtualData()
        {
            List<PivotVirtualData> VirtualData = new List<PivotVirtualData>();
            string[] years = new string[] { "FY 2021", "FY 2022", "FY 2023", "FY 2024", "FY 2025" };
            for (int i = 1; i <= 100000; i++)
            {
                int yearIndex = (i - 1) % years.Length;
                PivotVirtualData p = new PivotVirtualData
                {
                    ProductID = "PRO-" +(10000+i),
                    Year = years[yearIndex],
                    Country = "USA",
                    City = "New York",
                    Price = (3.4*i)+500,
                    Sold = (i*15)+10
                    //date = Convert.ToDateTime("2013/01/06")
                };
                VirtualData.Add(p);
            }
            return VirtualData;
        }
    }
}