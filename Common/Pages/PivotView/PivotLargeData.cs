using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;

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

        private static double GetSecureRandomDouble(RandomNumberGenerator rng)
        {
            byte[] data = new byte[4];
            rng.GetBytes(data);
            int value = BitConverter.ToInt32(data, 0) & int.MaxValue;
            return value / (double)int.MaxValue;
        }

        private static int GetSecureRandomInt(RandomNumberGenerator rng, int maxValue)
        {
            byte[] data = new byte[4];
            rng.GetBytes(data);
            return Math.Abs(BitConverter.ToInt32(data, 0)) % maxValue;
        }

        public static IEnumerable<PivotLargeData> GetLargeData(int number)
        {
            List<PivotLargeData> VirtualData = new List<PivotLargeData>();
            using (var random = RandomNumberGenerator.Create())
            {
                for (int i = 1; i <= number; i++)
                {
                    var round = string.Empty;
                    var toString = i.ToString(CultureInfo.InvariantCulture);
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
                    var rnd1 = GetSecureRandomDouble(random);
                    var rnd2 = GetSecureRandomDouble(random);
                    PivotLargeData p = new PivotLargeData
                    {
                        ProductID = "PRO-" + (round),
                        Year = (new string[] { "FY 2022", "FY 2023", "FY 2024", "FY 2025" })[GetSecureRandomInt(random, 4)],
                        Country = "USA",
                        City = "New York",
                        Price = (decimal)(Math.Round(rnd1 * 5000) + 5000),
                        Sold = (decimal)(Math.Round(rnd2 * 80) + 10)
                    };
                    VirtualData.Add(p);
                }
            }
            return VirtualData;
        }
    }
}
