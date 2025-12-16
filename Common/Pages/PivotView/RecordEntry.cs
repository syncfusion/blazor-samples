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
    public class RecordEntry
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string Country { get; set; } = string.Empty;
        public string Product { get; set; } = string.Empty;
        public double Amount { get; set; }
        public int Sold { get; set; }

        public static List<RecordEntry> GenerateFullData()
        {
            var data = new List<RecordEntry>();
            var countries = new[] { "USA", "UK", "France", "Germany", "Canada" };
            var products = new[] { "Laptop", "Monitor", "Tablet" };
            var years = new[] { 2019, 2020, 2021, 2022, 2023, 2024 };
            int orderId = 2000;

            foreach (var country in countries)
            {
                foreach (var year in years)
                {
                    for (int month = 1; month <= 12; month++)
                    {
                        foreach (var product in products)
                        {
                            data.Add(new RecordEntry
                            {
                                OrderID = orderId++,
                                OrderDate = new DateTime(year, month, 1),
                                Country = country,
                                Product = product,
                                Amount = new Random().Next(100, 1100),
                                Sold = new Random().Next(1, 6)
                            });
                        }
                    }
                }
            }
            return data;
        }
    }
}