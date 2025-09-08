#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.PivotView.PivotTable
{
    public class PivotLargeData
    {
        public string ProductID { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public decimal Sold { get; set; }

        public static List<PivotLargeData> GetLargeData(int number)
        {
            List<PivotLargeData> VirtualData = new List<PivotLargeData>();

            for (int i = 1; i <= number; i++)
            {
                var round = string.Empty;
                var toString = i.ToString();
                if (toString.Length == 1)
                {
                    round = "0000" + i;
                }
                else if (toString.Length == 2)
                {
                    round = "000" + i;
                }
                else if (toString.Length == 3)
                {
                    round = "00" + i;
                }
                else if (toString.Length == 4)
                {
                    round = "0" + i;
                }
                else
                {
                    round = toString;
                }
                var rnd1 = new Random().NextDouble();
                var rnd2 = new Random().NextDouble();
                PivotLargeData p = new PivotLargeData
                {
                    ProductID = "PRO-" + (round),
                    Year = (new string[] { "FY 2022", "FY 2023", "FY 2024", "FY 2025" })[new Random().Next(4)],
                    Country = "USA",
                    City = "New York",
                    Price = Math.Round((decimal)rnd1 * 5000) + 5000,
                    Sold = Math.Round((decimal)rnd2 * 80) + 10
                };
                VirtualData.Add(p);
            }
            return VirtualData;
        }
    }
}
