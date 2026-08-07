using System;
using System.Collections.Generic;
using System.Security.Cryptography;
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

        private static int GetSecureRandomInt(RandomNumberGenerator rng, int minValue, int maxValue)
        {
            byte[] data = new byte[4];
            rng.GetBytes(data);
            int value = Math.Abs(BitConverter.ToInt32(data, 0)) % (maxValue - minValue);
            return value + minValue;
        }

        public static IEnumerable<RecordEntry> GenerateFullData()
        {
            var data = new List<RecordEntry>();
            var countries = new[] { "USA", "UK", "France", "Germany", "Canada" };
            var products = new[] { "Laptop", "Monitor", "Tablet" };
            var years = new[] { 2019, 2020, 2021, 2022, 2023, 2024 };
            int orderId = 2000;
            using (var random = RandomNumberGenerator.Create())
            {
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
                                    Amount = GetSecureRandomInt(random, 100, 1100),
                                    Sold = GetSecureRandomInt(random, 1, 6)
                                });
                            }
                        }
                    }
                }
            }
            return data;
        }
    }
}