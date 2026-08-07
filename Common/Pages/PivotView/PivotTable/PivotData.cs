using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace BlazorDemos.Pages.PivotView.PivotTable
{
    public static class PivotViewData
    {
        public static IEnumerable<PivotData> GetPivotData()
        {
            List<PivotData> pivotData = new List<PivotData>();
            pivotData.Add(new PivotData { InStock = 34, Sold = 51, Amount = 383, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 4, Sold = 423, Amount = 3595.5, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 38, Sold = 234, Amount = 1813.5, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 42, Sold = 127, Amount = 952.5, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 36, Sold = 89, Amount = 668, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 12, Sold = 140, Amount = 1050, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 9, Sold = 31, Amount = 233, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 49, Sold = 402, Amount = 3417, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 30, Sold = 254, Amount = 1968.5, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 28, Sold = 314, Amount = 2355, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 43, Sold = 91, Amount = 683, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 44, Sold = 202, Amount = 1717, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 11, Sold = 298, Amount = 2309.5, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 39, Sold = 166, Amount = 1245, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 7, Sold = 11, Amount = 83, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 33, Sold = 416, Amount = 3536, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 39, Sold = 55, Amount = 426.25, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 510, Amount = 3825, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 4, Sold = 199, Amount = 1691.5, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 4, Sold = 103, Amount = 798.25, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 42, Sold = 227, Amount = 1702.5, Country = "France", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 36, Sold = 16, Amount = 72, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 18, Sold = 250, Amount = 1250, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 19, Sold = 386, Amount = 1640.5, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 40, Sold = 165, Amount = 660, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 45, Sold = 83, Amount = 373.5, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 11, Sold = 221, Amount = 1105, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 17, Sold = 249, Amount = 1058.25, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 50, Sold = 418, Amount = 1672, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 34, Sold = 55, Amount = 247.5, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 3, Sold = 415, Amount = 2075, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 42, Sold = 57, Amount = 242.25, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 5, Sold = 252, Amount = 1008, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 11, Sold = 19, Amount = 85.5, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 10, Sold = 64, Amount = 320, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 42, Sold = 66, Amount = 280.5, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 33, Sold = 263, Amount = 1052, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 41, Sold = 61, Amount = 274.5, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 33, Sold = 257, Amount = 1285, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 386, Amount = 1640.5, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 10, Sold = 503, Amount = 2012, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 7, Sold = 43, Amount = 193.5, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 30, Sold = 322, Amount = 1610, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 40, Sold = 305, Amount = 1296.25, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 46, Sold = 171, Amount = 684, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 8, Sold = 22, Amount = 99, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 18, Sold = 254, Amount = 1270, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 19, Sold = 72, Amount = 306, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 37, Sold = 286, Amount = 1144, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 15, Sold = 95, Amount = 427.5, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 48, Sold = 271, Amount = 1355, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 7, Sold = 67, Amount = 284.75, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 92, Amount = 368, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 18, Sold = 86, Amount = 387, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 15, Sold = 320, Amount = 1600, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 5, Sold = 244, Amount = 1037, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 45, Sold = 403, Amount = 1612, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 3, Sold = 45, Amount = 202.5, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 41, Sold = 323, Amount = 1615, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 11, Sold = 256, Amount = 1088, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 24, Sold = 361, Amount = 1444, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 47, Sold = 57, Amount = 256.5, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 2, Sold = 269, Amount = 1345, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 45, Sold = 448, Amount = 1904, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 10, Sold = 376, Amount = 1504, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 41, Sold = 15, Amount = 67.5, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 12, Sold = 157, Amount = 785, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 35, Sold = 170, Amount = 722.5, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 32, Sold = 542, Amount = 2168, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 13, Sold = 96, Amount = 432, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 41, Sold = 212, Amount = 1060, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 5, Sold = 342, Amount = 1453.5, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 40, Sold = 84, Amount = 336, Country = "France", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 20, Sold = 42, Amount = 483, Country = "France", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 15, Sold = 287, Amount = 3444, Country = "France", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 14, Sold = 371, Amount = 4173.75, Country = "France", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 48, Sold = 414, Amount = 4554, Country = "France", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 36, Sold = 60, Amount = 946.8, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 15, Sold = 470, Amount = 7651.6, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 27, Sold = 448, Amount = 6957.44, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 17, Sold = 118, Amount = 1803.04, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 7, Sold = 15, Amount = 236.7, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 45, Sold = 95, Amount = 1546.6, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 35, Sold = 191, Amount = 2966.23, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 426, Amount = 6509.28, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 35, Sold = 78, Amount = 1230.84, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 3, Sold = 69, Amount = 1123.32, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 221, Amount = 3432.13, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 13, Sold = 285, Amount = 4354.8, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 26, Sold = 56, Amount = 883.68, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 17, Sold = 303, Amount = 4932.84, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 34, Sold = 419, Amount = 6507.07, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 26, Sold = 397, Amount = 6066.16, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 14, Sold = 90, Amount = 1420.2, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 7, Sold = 337, Amount = 5486.36, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 47, Sold = 74, Amount = 1149.22, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 26, Sold = 203, Amount = 3101.84, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 10, Sold = 83, Amount = 1309.74, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 29, Sold = 152, Amount = 2474.56, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 30, Sold = 144, Amount = 2236.32, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 25, Sold = 231, Amount = 3529.68, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 47, Amount = 741.66, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 29, Sold = 464, Amount = 7553.92, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 3, Sold = 460, Amount = 7143.8, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 27, Sold = 343, Amount = 5241.04, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 6, Sold = 22, Amount = 347.16, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 20, Sold = 161, Amount = 2621.08, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 4, Sold = 188, Amount = 2919.64, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 26, Sold = 233, Amount = 3560.24, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 26, Sold = 17, Amount = 268.26, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 39, Sold = 121, Amount = 1969.88, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 49, Sold = 469, Amount = 7283.57, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 297, Amount = 4538.16, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 4, Sold = 30, Amount = 473.4, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 11, Sold = 288, Amount = 4688.64, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 8, Sold = 155, Amount = 2407.15, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 7, Sold = 121, Amount = 1848.88, Country = "France", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 46, Amount = 1414.5, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 3, Sold = 328, Amount = 10250, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 32, Sold = 393, Amount = 11986.5, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 49, Sold = 415, Amount = 12553.75, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 37, Sold = 63, Amount = 1937.25, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 6, Sold = 411, Amount = 12843.75, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 19, Sold = 106, Amount = 3233, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 10, Sold = 222, Amount = 6715.5, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 43, Sold = 98, Amount = 3013.5, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 27, Sold = 59, Amount = 1843.75, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 18, Sold = 355, Amount = 10827.5, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 12, Sold = 76, Amount = 2299, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 38, Amount = 1168.5, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 47, Sold = 189, Amount = 5906.25, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 458, Amount = 13969, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 19, Sold = 436, Amount = 13189, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 38, Sold = 19, Amount = 584.25, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 2, Sold = 444, Amount = 13875, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 33, Sold = 186, Amount = 5673, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 3, Sold = 225, Amount = 6806.25, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 26, Sold = 11, Amount = 338.25, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 61, Amount = 1906.25, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 24, Sold = 272, Amount = 8296, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 44, Sold = 150, Amount = 4537.5, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 11, Sold = 51, Amount = 1568.25, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 32, Sold = 490, Amount = 15312.5, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 41, Sold = 487, Amount = 14853.5, Country = "France", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 12, Sold = 277, Amount = 5332.25, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 236, Amount = 4484, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 7, Sold = 49, Amount = 955.5, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 24, Sold = 191, Amount = 3820, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 32, Sold = 165, Amount = 3176.25, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 28, Sold = 185, Amount = 3515, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 5, Sold = 92, Amount = 1794, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 44, Sold = 128, Amount = 2560, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 33, Sold = 258, Amount = 4966.5, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 24, Sold = 274, Amount = 5206, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 25, Sold = 58, Amount = 1131, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 7, Sold = 322, Amount = 6440, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 44, Sold = 168, Amount = 3234, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 7, Sold = 120, Amount = 2280, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 8, Sold = 18, Amount = 351, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 23, Sold = 142, Amount = 2840, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 4, Sold = 133, Amount = 2560.25, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 10, Sold = 377, Amount = 7163, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 1, Sold = 56, Amount = 1092, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 22, Sold = 318, Amount = 6360, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 8, Sold = 456, Amount = 8778, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 21, Sold = 408, Amount = 7752, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 33, Sold = 34, Amount = 663, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 47, Sold = 226, Amount = 4520, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 4, Sold = 355, Amount = 6833.75, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 45, Sold = 237, Amount = 4503, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 34, Sold = 94, Amount = 1833, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 41, Sold = 273, Amount = 5460, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 2, Sold = 280, Amount = 5390, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 146, Amount = 2774, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 17, Sold = 37, Amount = 721.5, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 40, Sold = 219, Amount = 4380, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 29, Sold = 497, Amount = 9567.25, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 378, Amount = 7182, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 15, Sold = 83, Amount = 1618.5, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 24, Sold = 211, Amount = 4220, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 42, Sold = 372, Amount = 7161, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 8, Sold = 537, Amount = 10203, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 8, Sold = 58, Amount = 1131, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 25, Sold = 155, Amount = 3100, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 17, Sold = 211, Amount = 4061.75, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 1, Sold = 134, Amount = 2546, Country = "France", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 18, Sold = 58, Amount = 98832, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 8, Sold = 474, Amount = 810066, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 43, Sold = 447, Amount = 762582, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 12, Sold = 289, Amount = 491011, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 43, Sold = 60, Amount = 102240, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 29, Sold = 93, Amount = 158937, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 11, Sold = 96, Amount = 163776, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 29, Sold = 401, Amount = 681299, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 42, Sold = 83, Amount = 141432, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 21, Sold = 427, Amount = 729743, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 33, Sold = 396, Amount = 675576, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 11, Sold = 98, Amount = 166502, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 29, Sold = 48, Amount = 81792, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 288, Amount = 492192, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 68, Amount = 115872, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 2, Sold = 406, Amount = 693854, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 10, Sold = 50, Amount = 85300, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 40, Sold = 231, Amount = 392469, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 31, Amount = 52824, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 34, Sold = 254, Amount = 434086, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 38, Sold = 455, Amount = 776230, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 39, Sold = 304, Amount = 516496, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 50, Sold = 40, Amount = 68160, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 23, Sold = 204, Amount = 348636, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 26, Sold = 231, Amount = 394086, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 30, Sold = 531, Amount = 902169, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 35, Sold = 45, Amount = 76680, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 8, Sold = 275, Amount = 469975, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 42, Sold = 292, Amount = 498152, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 25, Sold = 197, Amount = 334703, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 8, Sold = 35, Amount = 59640, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 234, Amount = 399906, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 34, Sold = 127, Amount = 216662, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 44, Sold = 377, Amount = 640523, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 40, Amount = 68160, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 33, Sold = 474, Amount = 810066, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 49, Sold = 168, Amount = 286608, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 43, Sold = 521, Amount = 885179, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 32, Sold = 55, Amount = 93720, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 39, Sold = 309, Amount = 528081, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 8, Sold = 466, Amount = 794996, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 34, Sold = 296, Amount = 502904, Country = "France", ProductCategories = "Bikes", Products = "Mountain Bikes", OrderSource = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 14, Sold = 76, Amount = 113929, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 202, Amount = 304818, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 19, Sold = 285, Amount = 429210, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 1, Sold = 345, Amount = 571119, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 61, Amount = 91444, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 1, Sold = 94, Amount = 141846, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 27, Sold = 241, Amount = 362946, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 17, Sold = 186, Amount = 795969, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 4, Sold = 79, Amount = 118426, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 341, Amount = 514569, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 27, Sold = 401, Amount = 603906, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 24, Sold = 204, Amount = 517155, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 37, Sold = 71, Amount = 106434, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 32, Sold = 368, Amount = 555312, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 14, Sold = 500, Amount = 753000, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 44, Sold = 275, Amount = 278814, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 32, Sold = 41, Amount = 61464, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 49, Sold = 172, Amount = 259548, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 8, Sold = 432, Amount = 650592, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 25, Sold = 241, Amount = 305796, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 40, Sold = 40, Amount = 59965, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 50, Sold = 350, Amount = 528150, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 30, Sold = 468, Amount = 704808, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 6, Sold = 250, Amount = 412225, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 30, Sold = 98, Amount = 146907, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 6, Sold = 81, Amount = 121424, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 4, Sold = 80, Amount = 120720, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 24, Sold = 314, Amount = 472884, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 1, Sold = 495, Amount = 274317, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 83, Amount = 124422, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 48, Sold = 380, Amount = 573420, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 1, Sold = 157, Amount = 236442, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 44, Sold = 450, Amount = 640073, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 14, Sold = 10, Amount = 14995, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 2, Sold = 330, Amount = 497970, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 27, Sold = 324, Amount = 487944, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 25, Sold = 346, Amount = 742005, Country = "France", ProductCategories = "Bikes", Products = "Road Bikes", OrderSource = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 10, Sold = 83, Amount = 132426.5, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 45, Sold = 51, Amount = 81396, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 1, Sold = 483, Amount = 770505.75, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 17, Sold = 233, Amount = 371635, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 42, Sold = 46, Amount = 73393, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 5, Sold = 306, Amount = 488376, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 22, Sold = 124, Amount = 197811, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 45, Sold = 409, Amount = 652355, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 27, Sold = 66, Amount = 105303, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 27, Sold = 172, Amount = 274512, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 193, Amount = 307883.25, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 11, Sold = 510, Amount = 813450, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 42, Sold = 56, Amount = 89348, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 10, Sold = 61, Amount = 97356, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 51, Amount = 81357.75, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 44, Sold = 360, Amount = 574200, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 38, Sold = 51, Amount = 81370.5, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 37, Sold = 176, Amount = 280896, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 372, Amount = 593433, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 32, Sold = 473, Amount = 754435, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 27, Sold = 85, Amount = 135617.5, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 18, Sold = 457, Amount = 729372, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 15, Sold = 305, Amount = 486551.25, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 29, Sold = 513, Amount = 818235, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 49, Sold = 89, Amount = 141999.5, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 12, Sold = 87, Amount = 138852, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 24, Sold = 378, Amount = 603004.5, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 10, Sold = 65, Amount = 103675, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 35, Sold = 84, Amount = 134022, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 41, Sold = 118, Amount = 188328, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 29, Sold = 242, Amount = 386050.5, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 5, Sold = 396, Amount = 631620, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 6, Sold = 85, Amount = 135617.5, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 14, Sold = 98, Amount = 156408, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 50, Sold = 251, Amount = 400407.75, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 144, Amount = 229680, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 7, Sold = 85, Amount = 135617.5, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 14, Sold = 465, Amount = 742140, Country = "France", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 18, Sold = 227, Amount = 1362, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 20, Sold = 52, Amount = 312.5, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 24, Sold = 107, Amount = 856, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 457, Amount = 2856.25, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 38, Sold = 122, Amount = 732, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 38, Sold = 28, Amount = 168.5, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 36, Sold = 490, Amount = 3920, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 15, Sold = 464, Amount = 2900, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 18, Sold = 329, Amount = 1974, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 38, Sold = 81, Amount = 486.5, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 19, Sold = 94, Amount = 752, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 43, Sold = 230, Amount = 1437.5, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 47, Sold = 404, Amount = 2424, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 45, Sold = 27, Amount = 162.5, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 42, Sold = 106, Amount = 848, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 9, Sold = 358, Amount = 2237.5, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 25, Sold = 140, Amount = 840, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 28, Sold = 48, Amount = 288.5, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 11, Sold = 155, Amount = 1240, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 39, Sold = 176, Amount = 1100, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 22, Sold = 501, Amount = 3006, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 28, Sold = 14, Amount = 84.5, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 45, Sold = 98, Amount = 784, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 6, Sold = 280, Amount = 1750, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 36, Sold = 285, Amount = 1710, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 5, Sold = 67, Amount = 402.5, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 1, Sold = 103, Amount = 824, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 20, Sold = 247, Amount = 1543.75, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 3, Sold = 153, Amount = 918, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 40, Sold = 49, Amount = 294.5, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 39, Sold = 348, Amount = 2784, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 28, Sold = 461, Amount = 2881.25, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 23, Sold = 536, Amount = 3216, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 3, Sold = 83, Amount = 498.5, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 4, Sold = 68, Amount = 544, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 11, Sold = 390, Amount = 2437.5, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 49, Sold = 154, Amount = 924, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 47, Sold = 38, Amount = 228.5, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 37, Sold = 413, Amount = 3304, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 38, Sold = 380, Amount = 2375, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 46, Sold = 226, Amount = 1356, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 41, Sold = 65, Amount = 390.5, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 29, Sold = 176, Amount = 1408, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 39, Sold = 217, Amount = 1356.25, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 32, Sold = 318, Amount = 1908, Country = "France", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 47, Sold = 21, Amount = 598.5, Country = "France", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 44, Sold = 68, Amount = 1972, Country = "France", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 38, Sold = 277, Amount = 7825.25, Country = "France", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 5, Sold = 191, Amount = 5348, Country = "France", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 8, Sold = 63, Amount = 1795.5, Country = "France", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 14, Sold = 463, Amount = 738485, Country = "United States", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 15, Sold = 90, Amount = 143595, Country = "United Kingdom", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 19, Sold = 365, Amount = 582540, Country = "United Kingdom", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 4, Sold = 244, Amount = 389424, Country = "United States", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 9, Sold = 90, Amount = 143572.5, Country = "United States", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 13, Sold = 477, Amount = 760815, Country = "United States", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 17, Sold = 73, Amount = 116471.5, Country = "United Kingdom", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 24, Sold = 390, Amount = 622440, Country = "United Kingdom", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 49, Sold = 392, Amount = 625338, Country = "United Kingdom", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 5, Sold = 412, Amount = 657140, Country = "United Kingdom", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 13, Sold = 33, Amount = 52651.5, Country = "United States", ProductCategories = "Bikes", Products = "Touring Bikes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 26, Sold = 80, Amount = 640, Country = "United States", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 12, Sold = 86, Amount = 2494, Country = "United States", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 1, Sold = 63, Amount = 1071, Country = "United States", ProductCategories = "Clothing", Products = "Shorts", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 37, Sold = 75, Amount = 8400, Country = "United States", ProductCategories = "Clothing", Products = "Vests", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 29, Sold = 123, Amount = 768.75, Country = "United States", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 35, Sold = 219, Amount = 6186.75, Country = "United States", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 7, Sold = 274, Amount = 4452.5, Country = "United States", ProductCategories = "Clothing", Products = "Shorts", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 47, Sold = 57, Amount = 6341.25, Country = "United States", ProductCategories = "Clothing", Products = "Vests", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 259, Amount = 1554, Country = "United States", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 2, Sold = 266, Amount = 7448, Country = "United States", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 20, Sold = 246, Amount = 3936, Country = "United States", ProductCategories = "Clothing", Products = "Shorts", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 7, Sold = 70, Amount = 8880, Country = "United States", ProductCategories = "Clothing", Products = "Vests", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 26, Sold = 34, Amount = 204.5, Country = "United States", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 29, Sold = 40, Amount = 1140, Country = "United States", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 44, Sold = 47, Amount = 1010.5, Country = "United States", ProductCategories = "Clothing", Products = "Shorts", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 13, Sold = 49, Amount = 5439.5, Country = "United States", ProductCategories = "Clothing", Products = "Vests", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 22, Sold = 206, Amount = 1648, Country = "United States", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 1, Sold = 169, Amount = 4901, Country = "United States", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 19, Sold = 385, Amount = 6545, Country = "United States", ProductCategories = "Clothing", Products = "Shorts", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 38, Sold = 358, Amount = 40096, Country = "United States", ProductCategories = "Clothing", Products = "Vests", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 36, Sold = 148, Amount = 925, Country = "United States", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 24, Sold = 128, Amount = 3616, Country = "United States", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 17, Sold = 376, Amount = 6110, Country = "United States", ProductCategories = "Clothing", Products = "Shorts", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 27, Sold = 462, Amount = 3696, Country = "United States", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 35, Sold = 165, Amount = 4785, Country = "United States", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 14, Sold = 228, Amount = 3876, Country = "United States", ProductCategories = "Clothing", Products = "Shorts", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 46, Sold = 89, Amount = 9968, Country = "United States", ProductCategories = "Clothing", Products = "Vests", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 10, Sold = 157, Amount = 981.25, Country = "United States", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 4, Sold = 115, Amount = 3248.75, Country = "United States", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 15, Sold = 420, Amount = 6825, Country = "United States", ProductCategories = "Clothing", Products = "Shorts", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 20, Sold = 490, Amount = 54512.5, Country = "United States", ProductCategories = "Clothing", Products = "Vests", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 44, Sold = 459, Amount = 2754, Country = "United States", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 23, Sold = 332, Amount = 9296, Country = "United States", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 6, Sold = 93, Amount = 1488, Country = "United States", ProductCategories = "Clothing", Products = "Shorts", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 61, Amount = 51282, Country = "United States", ProductCategories = "Clothing", Products = "Vests", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 9, Sold = 81, Amount = 486.5, Country = "United States", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 19, Sold = 81, Amount = 2308.5, Country = "United States", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 29, Sold = 73, Amount = 1569.5, Country = "United States", ProductCategories = "Clothing", Products = "Shorts", OrderSource = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 3, Sold = 62, Amount = 6882.5, Country = "United States", ProductCategories = "Clothing", Products = "Vests", OrderSource = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 38, Sold = 125, Amount = 1000, Country = "United States", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 14, Sold = 274, Amount = 7946, Country = "United States", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 26, Sold = 348, Amount = 5916, Country = "United States", ProductCategories = "Clothing", Products = "Shorts", OrderSource = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 22, Sold = 489, Amount = 54768, Country = "United States", ProductCategories = "Clothing", Products = "Vests", OrderSource = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 5, Sold = 144, Amount = 900, Country = "United States", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 42, Sold = 155, Amount = 4378.75, Country = "United States", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 6, Sold = 134, Amount = 2177.5, Country = "United States", ProductCategories = "Clothing", Products = "Shorts", OrderSource = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 393, Amount = 43721.25, Country = "United States", ProductCategories = "Clothing", Products = "Vests", OrderSource = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 44, Sold = 423, Amount = 2538, Country = "United States", ProductCategories = "Clothing", Products = "Gloves", OrderSource = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 11, Sold = 178, Amount = 4984, Country = "United States", ProductCategories = "Clothing", Products = "Jerseys", OrderSource = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 26, Sold = 439, Amount = 7024, Country = "United States", ProductCategories = "Clothing", Products = "Shorts", OrderSource = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 23, Sold = 220, Amount = 13875, Country = "United States", ProductCategories = "Clothing", Products = "Vests", OrderSource = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 47, Sold = 53, Amount = 1033.5, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 33, Sold = 70, Amount = 525.5, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 45, Sold = 61, Amount = 1875.75, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 46, Sold = 61, Amount = 458, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 47, Sold = 81, Amount = 1278.18, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 1, Sold = 94, Amount = 1081, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 12, Sold = 395, Amount = 7900, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 29, Sold = 400, Amount = 3400, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 25, Sold = 306, Amount = 9562.5, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 49, Sold = 200, Amount = 1000, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 2, Sold = 477, Amount = 7765.56, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 339, Amount = 4068, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 46, Sold = 111, Amount = 2136.75, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 1, Sold = 384, Amount = 2976, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 23, Sold = 384, Amount = 11712, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 32, Sold = 228, Amount = 969, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 50, Sold = 355, Amount = 5513.15, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 11, Sold = 150, Amount = 1687.5, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 37, Sold = 459, Amount = 8721, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 44, Sold = 481, Amount = 3607.5, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 17, Sold = 243, Amount = 7350.75, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 26, Sold = 520, Amount = 2080, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 9, Sold = 250, Amount = 3820, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 25, Sold = 141, Amount = 1551, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 23, Sold = 85, Amount = 1657.5, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 2, Sold = 14, Amount = 105.5, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 11, Sold = 96, Amount = 2952, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 11, Sold = 76, Amount = 342, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 6, Sold = 93, Amount = 1467.54, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 13, Sold = 75, Amount = 862.5, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 18, Sold = 181, Amount = 3620, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 34, Sold = 63, Amount = 535.5, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 94, Amount = 2937.5, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 41, Sold = 290, Amount = 1450, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 28, Sold = 495, Amount = 8058.6, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 34, Sold = 455, Amount = 5460, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 39, Sold = 487, Amount = 9374.75, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 45, Sold = 446, Amount = 3456.5, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 41, Sold = 298, Amount = 9089, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 45, Sold = 291, Amount = 1236.75, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 6, Sold = 291, Amount = 4519.23, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 49, Sold = 128, Amount = 1440, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 6, Sold = 321, Amount = 6099, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 45, Sold = 515, Amount = 3862.5, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 35, Sold = 534, Amount = 16153.5, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 7, Sold = 467, Amount = 1868, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 36, Sold = 322, Amount = 4920.16, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 22, Sold = 258, Amount = 2838, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 20, Sold = 59, Amount = 1150.5, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 22, Sold = 57, Amount = 428, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 27, Sold = 27, Amount = 830.25, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 41, Sold = 76, Amount = 342, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 11, Sold = 16, Amount = 252.48, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 14, Sold = 87, Amount = 1000.5, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 388, Amount = 7760, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 48, Sold = 327, Amount = 2779.5, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivotData.Add(new PivotData { InStock = 4, Sold = 388, Amount = 7469, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 20, Sold = 498, Amount = 3859.5, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 7, Sold = 400, Amount = 12200, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 21, Sold = 500, Amount = 2125, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 49, Sold = 457, Amount = 7097.21, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 18, Sold = 216, Amount = 2430, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 3, Sold = 90, Amount = 1710, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 7, Sold = 344, Amount = 2580, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 49, Sold = 188, Amount = 5687, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 49, Sold = 488, Amount = 1952, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 35, Sold = 468, Amount = 7151.04, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 20, Sold = 454, Amount = 4994, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 12, Sold = 42, Amount = 819, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 45, Sold = 89, Amount = 668, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 84, Amount = 2583, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 5, Sold = 41, Amount = 184.5, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 10, Sold = 77, Amount = 1215.06, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 25, Sold = 97, Amount = 1115.5, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 27, Sold = 169, Amount = 3380, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 17, Sold = 494, Amount = 4199, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 1, Sold = 127, Amount = 3968.75, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 34, Sold = 459, Amount = 2295, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 9, Sold = 466, Amount = 7586.48, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 64, Amount = 768, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 18, Sold = 417, Amount = 8027.25, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 24, Sold = 73, Amount = 565.75, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 42, Sold = 482, Amount = 14701, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 30, Sold = 367, Amount = 1559.75, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 8, Sold = 303, Amount = 4705.59, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 25, Sold = 176, Amount = 1980, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 34, Sold = 436, Amount = 8284, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 36, Sold = 203, Amount = 1522.5, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 39, Sold = 95, Amount = 2873.75, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 10, Sold = 381, Amount = 1524, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 85, Amount = 1298.8, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 4, Sold = 74, Amount = 814, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 9, Sold = 13, Amount = 253.5, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 1, Sold = 15, Amount = 113, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 13, Sold = 46, Amount = 1414.5, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 18, Sold = 69, Amount = 310.5, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 47, Sold = 34, Amount = 536.52, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 41, Sold = 38, Amount = 437, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 45, Sold = 480, Amount = 9600, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 32, Sold = 434, Amount = 3689, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 27, Sold = 181, Amount = 5656.25, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 25, Sold = 500, Amount = 2500, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 46, Sold = 63, Amount = 1025.64, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 28, Sold = 238, Amount = 2856, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 38, Sold = 257, Amount = 4947.25, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 13, Sold = 178, Amount = 1379.5, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 41, Sold = 264, Amount = 8052, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 16, Sold = 441, Amount = 1874.25, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 48, Sold = 243, Amount = 3773.79, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 30, Sold = 131, Amount = 1473.75, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 47, Sold = 402, Amount = 7638, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 14, Sold = 488, Amount = 3660, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 237, Amount = 7169.25, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 36, Sold = 251, Amount = 1004, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 9, Sold = 151, Amount = 2307.28, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 44, Sold = 387, Amount = 4257, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivotData.Add(new PivotData { InStock = 13, Sold = 10, Amount = 195, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 49, Sold = 77, Amount = 578, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 13, Sold = 70, Amount = 2152.5, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 23, Sold = 90, Amount = 405, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 37, Sold = 58, Amount = 915.24, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 91, Amount = 1046.5, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 42, Sold = 497, Amount = 9940, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 31, Sold = 411, Amount = 3493.5, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 34, Sold = 285, Amount = 8906.25, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 48, Sold = 261, Amount = 2871, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 4, Sold = 57, Amount = 1111.5, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 14, Sold = 12, Amount = 90.5, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 2, Sold = 48, Amount = 1476, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 1, Sold = 68, Amount = 306, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 26, Sold = 42, Amount = 662.76, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 41, Sold = 82, Amount = 943, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 50, Sold = 312, Amount = 6240, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 9, Sold = 206, Amount = 1751, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 9, Sold = 393, Amount = 12281.25, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 48, Sold = 354, Amount = 1770, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 45, Sold = 160, Amount = 2604.8, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivotData.Add(new PivotData { InStock = 34, Sold = 199, Amount = 796, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 38, Sold = 454, Amount = 6937.12, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 19, Sold = 138, Amount = 1518, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 6, Sold = 32, Amount = 624, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 19, Sold = 80, Amount = 600.5, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 25, Sold = 33, Amount = 1014.75, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 38, Sold = 48, Amount = 216, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 8, Sold = 36, Amount = 568.08, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 4, Sold = 18, Amount = 207, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 32, Sold = 125, Amount = 2500, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 28, Sold = 481, Amount = 4088.5, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 22, Sold = 287, Amount = 8968.75, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 10, Sold = 302, Amount = 1510, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 20, Sold = 264, Amount = 4297.92, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 23, Sold = 107, Amount = 1284, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 17, Sold = 219, Amount = 4215.75, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 20, Sold = 384, Amount = 2976, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 27, Sold = 231, Amount = 7045.5, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 24, Sold = 409, Amount = 1738.25, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 24, Sold = 204, Amount = 3168.12, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 22, Sold = 301, Amount = 3386.25, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 14, Sold = 535, Amount = 10165, Country = "United States", ProductCategories = "Accessories", Products = "Tires and Tubes", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 47, Sold = 405, Amount = 3037.5, Country = "United States", ProductCategories = "Accessories", Products = "Bottles and Cages", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 14, Sold = 385, Amount = 11646.25, Country = "United States", ProductCategories = "Accessories", Products = "Hydration Packs", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 11, Sold = 426, Amount = 1704, Country = "United States", ProductCategories = "Accessories", Products = "Cleaners", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 13, Sold = 392, Amount = 5989.76, Country = "United States", ProductCategories = "Accessories", Products = "Helmets", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivotData.Add(new PivotData { InStock = 9, Sold = 426, Amount = 4686, Country = "United States", ProductCategories = "Accessories", Products = "Fenders", OrderSource = "App Store", Year = "FY 2017", Quarter = "Q4" });
            return pivotData;
        }

        public static IEnumerable<RData> GetRData()
        {
            List<RData> rData = new List<RData>();
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 46,
                ProCost = 43
            });
            rData.Add(new RData
            {
                Id = 1002,
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 30,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Id = 1003,
                Date = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 125,
                ProCost = 96
            });
            rData.Add(new RData
            {
                Id = 1004,
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 215,
                ProCost = 123
            });
            rData.Add(new RData
            {
                Id = 1005,
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 263,
                ProCost = 125
            });
            rData.Add(new RData
            {
                Id = 1006,
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 61,
                ProCost = 50
            });
            rData.Add(new RData
            {
                Id = 1007,
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 31
            });
            rData.Add(new RData
            {
                Id = 1008,
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 133,
                ProCost = 110
            });
            rData.Add(new RData
            {
                Id = 1009,
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 33,
                ProCost = 65
            });
            rData.Add(new RData
            {
                Id = 1010,
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 37,
                ProCost = 20
            });
            rData.Add(new RData
            {
                Id = 1011,
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 109,
                ProCost = 96
            });
            rData.Add(new RData
            {
                Id = 1012,
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 266,
                ProCost = 139
            });
            rData.Add(new RData
            {
                Id = 1013,
                Date = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 257,
                ProCost = 143
            });
            rData.Add(new RData
            {
                Id = 1014,
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 79,
                ProCost = 53
            });
            rData.Add(new RData
            {
                Id = 1015,
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 28,
                ProCost = 48
            });
            rData.Add(new RData
            {
                Id = 1016,
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 128,
                ProCost = 117
            });
            rData.Add(new RData
            {
                Id = 1017,
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 68,
                ProCost = 48
            });
            rData.Add(new RData
            {
                Id = 1018,
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 26,
                ProCost = 32
            });
            rData.Add(new RData
            {
                Id = 1019,
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 141,
                ProCost = 98
            });
            rData.Add(new RData
            {
                Id = 1020,
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 281,
                ProCost = 134
            });
            rData.Add(new RData
            {
                Id = 1021,
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 228,
                ProCost = 107
            });
            rData.Add(new RData
            {
                Id = 1022,
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 73,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Id = 1023,
                Date = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 19,
                ProCost = 44
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 149,
                ProCost = 82
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 47,
                ProCost = 58
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 25,
                ProCost = 40
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 127,
                ProCost = 93
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 216,
                ProCost = 124
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 267,
                ProCost = 100
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 52,
                ProCost = 65
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 39,
                ProCost = 33
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 142,
                ProCost = 97
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 53,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 23,
                ProCost = 44
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 113,
                ProCost = 106
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 270,
                ProCost = 101
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 284,
                ProCost = 105
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 62,
                ProCost = 43
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 32,
                ProCost = 26
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 133,
                ProCost = 83
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 51,
                ProCost = 65
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 13,
                ProCost = 25
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 139,
                ProCost = 101
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 297,
                ProCost = 130
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 236,
                ProCost = 119
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 57,
                ProCost = 66
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 16,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 110,
                ProCost = 93
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 55,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 32,
                ProCost = 39
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 128,
                ProCost = 120
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 290,
                ProCost = 128
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 201,
                ProCost = 105
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 55,
                ProCost = 46
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 37
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 122,
                ProCost = 118
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 69,
                ProCost = 54
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 21,
                ProCost = 41
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 140,
                ProCost = 83
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 239,
                ProCost = 121
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 283,
                ProCost = 127
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 80,
                ProCost = 40
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 33,
                ProCost = 40
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 120,
                ProCost = 81
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 41,
                ProCost = 69
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 14,
                ProCost = 21
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 144,
                ProCost = 93
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 294,
                ProCost = 146
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 217,
                ProCost = 103
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 49,
                ProCost = 44
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 36,
                ProCost = 21
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 118,
                ProCost = 115
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 56,
                ProCost = 41
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 17,
                ProCost = 36
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 140,
                ProCost = 81
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 274,
                ProCost = 109
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 284,
                ProCost = 145
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 40,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 12,
                ProCost = 28
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 150,
                ProCost = 115
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 73,
                ProCost = 64
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 23,
                ProCost = 47
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 102,
                ProCost = 112
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 252,
                ProCost = 112
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 222,
                ProCost = 131
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 52,
                ProCost = 46
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 35,
                ProCost = 30
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 104,
                ProCost = 101
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 46,
                ProCost = 40
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 19,
                ProCost = 31
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 118,
                ProCost = 89
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 227,
                ProCost = 130
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 226,
                ProCost = 144
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 40,
                ProCost = 52
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 19,
                ProCost = 40
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 127,
                ProCost = 91
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 70,
                ProCost = 66
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 36,
                ProCost = 21
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 144,
                ProCost = 85
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 212,
                ProCost = 130
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 210,
                ProCost = 110
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 72,
                ProCost = 56
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 13,
                ProCost = 47
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 139,
                ProCost = 98
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 59,
                ProCost = 54
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 26,
                ProCost = 21
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 120,
                ProCost = 97
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 299,
                ProCost = 124
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 240,
                ProCost = 110
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 71,
                ProCost = 61
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 40,
                ProCost = 33
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 134,
                ProCost = 111
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 33,
                ProCost = 50
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 18,
                ProCost = 25
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 139,
                ProCost = 85
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 217,
                ProCost = 141
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 252,
                ProCost = 101
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 31,
                ProCost = 42
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 15,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 117,
                ProCost = 112
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 34,
                ProCost = 40
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 10,
                ProCost = 43
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 110,
                ProCost = 83
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 212,
                ProCost = 137
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 222,
                ProCost = 126
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 75,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 31,
                ProCost = 37
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 105,
                ProCost = 98
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 72,
                ProCost = 45
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 45
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 143,
                ProCost = 92
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 272,
                ProCost = 128
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 208,
                ProCost = 136
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 48,
                ProCost = 46
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 22,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 150,
                ProCost = 100
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 60,
                ProCost = 43
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 15,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 107,
                ProCost = 97
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 204,
                ProCost = 136
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 210,
                ProCost = 111
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 65,
                ProCost = 47
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 26,
                ProCost = 45
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 112,
                ProCost = 115
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 54,
                ProCost = 66
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 31,
                ProCost = 36
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 120,
                ProCost = 112
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 261,
                ProCost = 149
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 226,
                ProCost = 124
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 72,
                ProCost = 63
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 35,
                ProCost = 33
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 144,
                ProCost = 118
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 293,
                ProCost = 118
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 237,
                ProCost = 110
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 36,
                ProCost = 50
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 36
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 120,
                ProCost = 95
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 46,
                ProCost = 59
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 31,
                ProCost = 33
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 147,
                ProCost = 96
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 230,
                ProCost = 100
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 236,
                ProCost = 104
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 60,
                ProCost = 57
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 33,
                ProCost = 41
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 140,
                ProCost = 105
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 31,
                ProCost = 55
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 30
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 117,
                ProCost = 106
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 259,
                ProCost = 127
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 294,
                ProCost = 126
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 51,
                ProCost = 63
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 21,
                ProCost = 45
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 102,
                ProCost = 108
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 77,
                ProCost = 64
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 29,
                ProCost = 26
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 140,
                ProCost = 88
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 244,
                ProCost = 144
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 213,
                ProCost = 127
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 69,
                ProCost = 40
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 30,
                ProCost = 33
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 116,
                ProCost = 103
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 79,
                ProCost = 47
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 29,
                ProCost = 37
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 116,
                ProCost = 96
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 295,
                ProCost = 108
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 225,
                ProCost = 127
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 35,
                ProCost = 57
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 37,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 138,
                ProCost = 118
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 80,
                ProCost = 47
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 22,
                ProCost = 42
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 131,
                ProCost = 91
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 240,
                ProCost = 115
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 275,
                ProCost = 109
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 46,
                ProCost = 42
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 40,
                ProCost = 43
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 112,
                ProCost = 105
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 35,
                ProCost = 40
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 22,
                ProCost = 31
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 119,
                ProCost = 87
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 298,
                ProCost = 148
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 200,
                ProCost = 107
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 30,
                ProCost = 42
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 22,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 148,
                ProCost = 88
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 37,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 23,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 130,
                ProCost = 102
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 281,
                ProCost = 129
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 228,
                ProCost = 113
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 80,
                ProCost = 60
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 39,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 119,
                ProCost = 93
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 42,
                ProCost = 46
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 18,
                ProCost = 37
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 126,
                ProCost = 96
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 222,
                ProCost = 150
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 228,
                ProCost = 105
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 54,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 16,
                ProCost = 33
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 145,
                ProCost = 110
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 35,
                ProCost = 41
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 16,
                ProCost = 38
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 118,
                ProCost = 114
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 241,
                ProCost = 110
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 281,
                ProCost = 136
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 50,
                ProCost = 66
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 23,
                ProCost = 26
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 129,
                ProCost = 98
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 78,
                ProCost = 53
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 28,
                ProCost = 31
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 147,
                ProCost = 120
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 240,
                ProCost = 100
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 232,
                ProCost = 116
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 33,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 18,
                ProCost = 36
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 114,
                ProCost = 113
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 52,
                ProCost = 63
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 31,
                ProCost = 25
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 129,
                ProCost = 88
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 263,
                ProCost = 111
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 241,
                ProCost = 105
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 55,
                ProCost = 60
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 13,
                ProCost = 30
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 134,
                ProCost = 107
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 33,
                ProCost = 69
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 31
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 146,
                ProCost = 109
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 241,
                ProCost = 107
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 10,
                ProCost = 30
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 38,
                ProCost = 65
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 6,
                ProCost = 24
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 72,
                ProCost = 86
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 13,
                ProCost = 20
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 34,
                ProCost = 54
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 5,
                ProCost = 20
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 12,
                ProCost = 26
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 48,
                ProCost = 57
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 8,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 61,
                ProCost = 97
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 19,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 40,
                ProCost = 47
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 7,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 20,
                ProCost = 24
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 45,
                ProCost = 42
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 4,
                ProCost = 25
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 72,
                ProCost = 82
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 19,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 32,
                ProCost = 42
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 5,
                ProCost = 20
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 20,
                ProCost = 25
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 43,
                ProCost = 66
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 8,
                ProCost = 26
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 86,
                ProCost = 87
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 16,
                ProCost = 22
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 43,
                ProCost = 54
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 6,
                ProCost = 22
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 15,
                ProCost = 20
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 40,
                ProCost = 55
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 3,
                ProCost = 24
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 60,
                ProCost = 87
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 12,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 37,
                ProCost = 50
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 3,
                ProCost = 20
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 17,
                ProCost = 21
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 38,
                ProCost = 53
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 8,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 88,
                ProCost = 92
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 14,
                ProCost = 22
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 31,
                ProCost = 69
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 2,
                ProCost = 22
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 16,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 35,
                ProCost = 54
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 7,
                ProCost = 24
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 79,
                ProCost = 82
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 10,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 50,
                ProCost = 65
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 5,
                ProCost = 25
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 17,
                ProCost = 28
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 46,
                ProCost = 54
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 7,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 63,
                ProCost = 84
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 19,
                ProCost = 28
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 47,
                ProCost = 52
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 8,
                ProCost = 23
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 20,
                ProCost = 28
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 40,
                ProCost = 55
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 7,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 67,
                ProCost = 88
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 20,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 38,
                ProCost = 61
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 7,
                ProCost = 21
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 11,
                ProCost = 26
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 36,
                ProCost = 60
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 2,
                ProCost = 24
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 83,
                ProCost = 90
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 11,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 49,
                ProCost = 42
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 7,
                ProCost = 28
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 13,
                ProCost = 25
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 30,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 4,
                ProCost = 26
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 76,
                ProCost = 87
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 19,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 45,
                ProCost = 55
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 1,
                ProCost = 23
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 20,
                ProCost = 23
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 34,
                ProCost = 51
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 3,
                ProCost = 28
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 85,
                ProCost = 80
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 20,
                ProCost = 22
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 40,
                ProCost = 51
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 7,
                ProCost = 25
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 15,
                ProCost = 21
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 36,
                ProCost = 41
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 1,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 79,
                ProCost = 93
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 11,
                ProCost = 28
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 41,
                ProCost = 51
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 8,
                ProCost = 28
            });
            rData.Add(new RData
            {
                Id = 1001,
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 20,
                ProCost = 23
            });
            return rData;
        }

        public static IEnumerable<RenewableData> GetRenewableEnergy()
        {
            List<RenewableData> renewableEnergy = RenewableEnergyData().ToList();
            return renewableEnergy;
        }

        public static IEnumerable<RenewableData> RenewableEnergyData()
        {
            List<RenewableData> renewableEnergy = new List<RenewableData>();
            List<RData> data = GetRData().ToList();
            for (int ln = 0; ln < data.Count; ln++)
            {
                DateTime date = Convert.ToDateTime(data[ln].Date.ToString(), CultureInfo.InvariantCulture);
                int dtYr = date.Year;
                int dtMn = date.Month;
                int dtdv = (dtMn) / 3;
                data[ln].Year = "FY " + dtYr;
                data[ln].Quarter = dtdv <= 1 ? "Q1 " + ("FY " + dtYr) : dtdv <= 2 ? "Q2 " + ("FY " + dtYr) :
                dtdv <= 3 ? "Q3 " + ("FY " + dtYr) : "Q4 " + ("FY " + dtYr);
                data[ln].HalfYear = (dtMn) / 6 <= 1 ? "H1 " + ("FY " + dtYr) : "H2 " + ("FY " + dtYr);
                renewableEnergy.Add(new RenewableData
                {
                    Sector = data[ln].Sector,
                    EnerType = data[ln].EnerType,
                    EneSource = data[ln].EneSource,
                    PowUnits = data[ln].PowUnits,
                    ProCost = data[ln].ProCost,
                    Year = data[ln].Year,
                    Quarter = data[ln].Quarter,
                    HalfYear = data[ln].HalfYear
                });
            }
            return renewableEnergy;
        }


        public static IEnumerable<GroupDataPivot> GetGroupData()
        {
            List<GroupDataPivot> GroupData = new List<GroupDataPivot>();

            for (int i = 1; i <= 10; i++)
            {
                GroupDataPivot p = new GroupDataPivot
                {
                    id = i + 1000,
                    region = "North America",
                    country = "USA",
                    city = "New York",
                    amount = 2000,
                    date = new DateTime(2014, 01, 06)
                };
                GroupData.Add(p);
            }
            for (int i = 1; i <= 10; i++)
            {
                GroupDataPivot p = new GroupDataPivot
                {
                    id = i + 1011,
                    region = "North America",
                    country = "USA",
                    city = "New York",
                    amount = 2000,
                    date = new DateTime(2012, 06, 07)
                };
                GroupData.Add(p);
            }
            for (int i = 1; i <= 10; i++)
            {
                GroupDataPivot p = new GroupDataPivot
                {
                    id = i + 1021,
                    region = "North America",
                    country = "USA",
                    city = "New York",
                    amount = 2000,
                    date = new DateTime(2014, 04, 01)
                };
                GroupData.Add(p);
            }
            for (int i = 1; i <= 10; i++)
            {
                GroupDataPivot p = new GroupDataPivot
                {
                    id = i + 1031,
                    region = "North America",
                    country = "USA",
                    city = "New York",
                    amount = 2000,
                    date = new DateTime(2015, 04, 01)
                };
                GroupData.Add(p);
            }
            for (int i = 1; i <= 10; i++)
            {
                GroupDataPivot p = new GroupDataPivot
                {
                    id = i + 1041,
                    region = "North America",
                    country = "USA",
                    city = "New York",
                    amount = 2000,
                    date = new DateTime(2016, 04, 01)
                };
                GroupData.Add(p);
            }
            return GroupData;
        }


        

    }

    public class RData
    {
        public int Id { get; set; }
        public string Date { get; set; } = string.Empty;
        public string Sector { get; set; } = string.Empty;
        public string EnerType { get; set; } = string.Empty;
        public string EneSource { get; set; } = string.Empty;
        public int PowUnits { get; set; }
        public int ProCost { get; set; }
        public string Year { get; set; } = string.Empty;
        public string Quarter { get; set; } = string.Empty;
        public string HalfYear { get; set; } = string.Empty;
    }

    public class RenewableData
    {
        public string Sector { get; set; } = string.Empty;
        public string EnerType { get; set; } = string.Empty;
        public string EneSource { get; set; } = string.Empty;
        public int PowUnits { get; set; }
        public int ProCost { get; set; }
        public string Year { get; set; } = string.Empty;
        public string Quarter { get; set; } = string.Empty;
        public string HalfYear { get; set; } = string.Empty;
    }

    public class GroupDataPivot
    {
        public int id { get; set; }
        public string region { get; set; } = string.Empty;
        public string country { get; set; } = string.Empty;
        public string city { get; set; } = string.Empty;
        public int amount { get; set; }
        public DateTime date { get; set; }
    }

    public class PivotData
    {
        public int InStock { get; set; }
        public int Sold { get; set; }
        public double Amount { get; set; }
        public string Country { get; set; } = string.Empty;
        public string ProductCategories { get; set; } = string.Empty;
        public string Products { get; set; } = string.Empty;
        public string OrderSource { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string Quarter { get; set; } = string.Empty;
    }
}


