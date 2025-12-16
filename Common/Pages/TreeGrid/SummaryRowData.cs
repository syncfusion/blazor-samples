#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Linq;

namespace Summarydata
{
    public class SalesNode
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; } = string.Empty; // displayed hierarchy text
        public string Region { get; set; } = string.Empty;
        public string Store { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Product { get; set; } = string.Empty;
        public int Units { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Sales { get; set; }
        public decimal Profit { get; set; }
        public decimal MarginPct => Sales == 0 ? 0 : Profit / Sales;
    }

    // Sample data (realistic, hierarchical, and suitable for TreeGrid) - self-referential flat list
    static class RetailDataFactory
    {
        public static List<SalesNode> CreateFlat()
        {
            var list = new List<SalesNode>();

            // Region: North America
            list.Add(new SalesNode { Id = 1, ParentId = null, Name = "North America", Region = "North America" });
            list.Add(new SalesNode { Id = 2, ParentId = 1, Name = "Store - Seattle", Region = "North America", Store = "Seattle" });
            list.Add(new SalesNode { Id = 3, ParentId = 1, Name = "Store - Chicago", Region = "North America", Store = "Chicago" });

            list.Add(new SalesNode { Id = 4, ParentId = 2, Name = "Category - Beverages", Region = "North America", Store = "Seattle", Category = "Beverages" });
            list.Add(new SalesNode { Id = 5, ParentId = 4, Name = "Latte", Region = "North America", Store = "Seattle", Category = "Beverages", Product = "Latte", Units = 820, UnitPrice = 4.25m, Sales = 3485m, Profit = 980m });
            list.Add(new SalesNode { Id = 6, ParentId = 4, Name = "Espresso", Region = "North America", Store = "Seattle", Category = "Beverages", Product = "Espresso", Units = 640, UnitPrice = 3.50m, Sales = 2240m, Profit = 620m });

            list.Add(new SalesNode { Id = 7, ParentId = 2, Name = "Category - Snacks", Region = "North America", Store = "Seattle", Category = "Snacks" });
            list.Add(new SalesNode { Id = 8, ParentId = 7, Name = "Blueberry Muffin", Region = "North America", Store = "Seattle", Category = "Snacks", Product = "Blueberry Muffin", Units = 520, UnitPrice = 2.75m, Sales = 1430m, Profit = 390m });
            list.Add(new SalesNode { Id = 9, ParentId = 7, Name = "Chocolate Cookie", Region = "North America", Store = "Seattle", Category = "Snacks", Product = "Chocolate Cookie", Units = 690, UnitPrice = 1.80m, Sales = 1242m, Profit = 330m });

            list.Add(new SalesNode { Id = 10, ParentId = 3, Name = "Category - Beverages", Region = "North America", Store = "Chicago", Category = "Beverages" });
            list.Add(new SalesNode { Id = 11, ParentId = 10, Name = "Cappuccino", Region = "North America", Store = "Chicago", Category = "Beverages", Product = "Cappuccino", Units = 710, UnitPrice = 4.00m, Sales = 2840m, Profit = 760m });
            list.Add(new SalesNode { Id = 12, ParentId = 10, Name = "Iced Coffee", Region = "North America", Store = "Chicago", Category = "Beverages", Product = "Iced Coffee", Units = 560, UnitPrice = 3.00m, Sales = 1680m, Profit = 420m });

            list.Add(new SalesNode { Id = 13, ParentId = 3, Name = "Category - Bakery", Region = "North America", Store = "Chicago", Category = "Bakery" });
            list.Add(new SalesNode { Id = 14, ParentId = 13, Name = "Bagel", Region = "North America", Store = "Chicago", Category = "Bakery", Product = "Bagel", Units = 880, UnitPrice = 1.50m, Sales = 1320m, Profit = 210m });
            list.Add(new SalesNode { Id = 15, ParentId = 13, Name = "Croissant", Region = "North America", Store = "Chicago", Category = "Bakery", Product = "Croissant", Units = 450, UnitPrice = 2.20m, Sales = 990m, Profit = 120m });

            // Region: Europe
            list.Add(new SalesNode { Id = 21, ParentId = null, Name = "Europe", Region = "Europe" });
            list.Add(new SalesNode { Id = 22, ParentId = 21, Name = "Store - Berlin", Region = "Europe", Store = "Berlin" });
            list.Add(new SalesNode { Id = 23, ParentId = 21, Name = "Store - Madrid", Region = "Europe", Store = "Madrid" });

            list.Add(new SalesNode { Id = 24, ParentId = 22, Name = "Category - Beverages", Region = "Europe", Store = "Berlin", Category = "Beverages" });
            list.Add(new SalesNode { Id = 25, ParentId = 24, Name = "Americano", Region = "Europe", Store = "Berlin", Category = "Beverages", Product = "Americano", Units = 600, UnitPrice = 3.20m, Sales = 1920m, Profit = 480m });
            list.Add(new SalesNode { Id = 26, ParentId = 24, Name = "Mocha", Region = "Europe", Store = "Berlin", Category = "Beverages", Product = "Mocha", Units = 540, UnitPrice = 3.80m, Sales = 2052m, Profit = 500m });

            list.Add(new SalesNode { Id = 27, ParentId = 22, Name = "Category - Snacks", Region = "Europe", Store = "Berlin", Category = "Snacks" });
            list.Add(new SalesNode { Id = 28, ParentId = 27, Name = "Pretzel", Region = "Europe", Store = "Berlin", Category = "Snacks", Product = "Pretzel", Units = 700, UnitPrice = 1.60m, Sales = 1120m, Profit = 160m });
            list.Add(new SalesNode { Id = 29, ParentId = 27, Name = "Apple Strudel", Region = "Europe", Store = "Berlin", Category = "Snacks", Product = "Apple Strudel", Units = 420, UnitPrice = 2.50m, Sales = 1050m, Profit = 150m });

            list.Add(new SalesNode { Id = 30, ParentId = 23, Name = "Category - Beverages", Region = "Europe", Store = "Madrid", Category = "Beverages" });
            list.Add(new SalesNode { Id = 31, ParentId = 30, Name = "Cortado", Region = "Europe", Store = "Madrid", Category = "Beverages", Product = "Cortado", Units = 480, UnitPrice = 3.10m, Sales = 1488m, Profit = 360m });
            list.Add(new SalesNode { Id = 32, ParentId = 30, Name = "Iced Latte", Region = "Europe", Store = "Madrid", Category = "Beverages", Product = "Iced Latte", Units = 510, UnitPrice = 3.60m, Sales = 1836m, Profit = 420m });

            list.Add(new SalesNode { Id = 33, ParentId = 23, Name = "Category - Bakery", Region = "Europe", Store = "Madrid", Category = "Bakery" });
            list.Add(new SalesNode { Id = 34, ParentId = 33, Name = "Magdalena", Region = "Europe", Store = "Madrid", Category = "Bakery", Product = "Magdalena", Units = 560, UnitPrice = 1.40m, Sales = 784m, Profit = 112m });
            list.Add(new SalesNode { Id = 35, ParentId = 33, Name = "Churros", Region = "Europe", Store = "Madrid", Category = "Bakery", Product = "Churros", Units = 630, UnitPrice = 1.90m, Sales = 1197m, Profit = 160m });

            // Negative-profit example to show conditional styling
            list.Add(new SalesNode { Id = 40, ParentId = null, Name = "Special - Promotions", Region = "Promotions" });
            list.Add(new SalesNode { Id = 41, ParentId = 40, Name = "Store - Clearance", Region = "Promotions", Store = "Clearance" });
            list.Add(new SalesNode { Id = 42, ParentId = 41, Name = "Category - Seasonal", Region = "Promotions", Store = "Clearance", Category = "Seasonal" });
            list.Add(new SalesNode { Id = 43, ParentId = 42, Name = "Discounted Beans", Region = "Promotions", Store = "Clearance", Category = "Seasonal", Product = "Discounted Beans", Units = 300, UnitPrice = 2.00m, Sales = 600m, Profit = -150m });

            // Compact values for parents: aggregate their children in-place (bottom-up)
            var ordered = list.OrderByDescending(n => Depth(n, list)).ToList();
            foreach (var n in ordered)
            {
                var children = list.Where(c => c.ParentId == n.Id).ToList();
                if (children.Count == 0) continue;
                n.Units = children.Sum(c => c.Units);
                n.Sales = children.Sum(c => c.Sales);
                n.Profit = children.Sum(c => c.Profit);
                n.UnitPrice = children.Sum(c => c.UnitPrice);
            }

            return list;

            static int Depth(SalesNode node, List<SalesNode> all)
            {
                int d = 0; var current = node;
                while (current.ParentId != null)
                {
                    d++;
                    current = all.First(a => a.Id == current.ParentId);
                }
                return d;
            }
        }
    }
}