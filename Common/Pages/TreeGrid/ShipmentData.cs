#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeShipmentdata
{
    public class ShipmentData
    {
        public int? ID { get; set; }
        public int? ShipID { get; set; }
        public string? Name { get; set; }
        public int? Units { get; set; }
        public string? Category { get; set; }
        public int? UnitPrice { get; set; }
        public int? Price { get; set; }
        public int? TotalPrice { get; set; } // Added for total price calculation (sum for parents, individual for items)
        public string? ShipmentCategory { get; set; }
        public DateTime? ShippedDate { get; set; } = null;
        public DateTime? OrderDate { get; set; } = null;
        public string? OrderReached { get; set; } = null;
        public int? ParentID { get; set; }

        private static void CalculateTotalPrices(List<ShipmentData> data)
        {
            // For items (non-parents), TotalPrice = Price
            // For parents, TotalPrice = sum of children's TotalPrice
            var parents = data.Where(d => d.ParentID == null).ToList();
            foreach (var parent in parents)
            {
                var children = data.Where(d => d.ParentID == parent.ID).ToList();
                parent.TotalPrice = children.Sum(c => c.Price ?? 0);
                // Recursively set for children if nested, but here it's flat tree
            }
            // Set for items
            foreach (var item in data.Where(d => d.ParentID != null))
            {
                item.TotalPrice = item.Price;
            }
        }

        public static List<ShipmentData> GetShipmentData()
        {
            List<ShipmentData> DataCollection = new List<ShipmentData>();
            DataCollection.Add(new ShipmentData()
            {
                ID = 0,
                Name = "Order 1",
                ParentID = null
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 1,
                ShipID = 4789,
                Name = "Mackerel",
                Category = "Seafood",
                Units = 25,
                UnitPrice = 12,
                Price = 300,
                OrderDate = new DateTime(2025, 3, 3),
                ShippedDate = new DateTime(2025, 3, 10),
                ShipmentCategory = "Seafood",
                OrderReached = "No",
                ParentID = 0
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 2,
                ShipID = 4833,
                Name = "Herrings",
                Category = "Seafood",
                Units = 28,
                UnitPrice = 11,
                Price = 308,
                OrderDate = new DateTime(2025, 8, 5),
                ShippedDate = new DateTime(2025, 8, 15),
                ShipmentCategory = "Seafood",
                OrderReached = "Yes",
                ParentID = 0
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 3,
                ShipID = 4567,
                Name = "Preserved Olives",
                Category = "Edible",
                Units = 22,
                UnitPrice = 9,
                Price = 198,
                OrderDate = new DateTime(2025, 6, 10),
                ShippedDate = new DateTime(2025, 6, 17),
                ShipmentCategory = "Edible",
                OrderReached = "Yes",
                ParentID = 0
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 4,
                ShipID = 4899,
                Name = "Sweet corn",
                Category = "Edible",
                Units = 27,
                UnitPrice = 7,
                Price = 189,
                OrderDate = new DateTime(2025, 7, 12),
                ShippedDate = new DateTime(2025, 7, 19),
                ShipmentCategory = "Edible",
                OrderReached = "No",
                ParentID = 0
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 5,
                Name = "Order 2",
                ParentID = null
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 6,
                ShipID = 5678,
                Name = "Tilapias",
                Category = "Seafood",
                Units = 24,
                UnitPrice = 15,
                Price = 360,
                OrderDate = new DateTime(2025, 2, 5),
                ShippedDate = new DateTime(2025, 2, 12),
                ShipmentCategory = "Seafood",
                OrderReached = "Yes",
                ParentID = 5
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 7,
                ShipID = 5990,
                Name = "White Shrimp",
                Category = "Seafood",
                Units = 30,
                UnitPrice = 7,
                Price = 210,
                OrderDate = new DateTime(2025, 5, 22),
                ShippedDate = new DateTime(2025, 5, 29),
                ShipmentCategory = "Seafood",
                OrderReached = "Yes",
                ParentID = 5
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 8,
                ShipID = 5476,
                Name = "Fresh Cheese",
                Category = "Dairy",
                Units = 26,
                UnitPrice = 12,
                Price = 312,
                OrderDate = new DateTime(2025, 6, 8),
                ShippedDate = new DateTime(2025, 6, 15),
                ShipmentCategory = "Dairy",
                OrderReached = "Yes",
                ParentID = 5
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 9,
                ShipID = 5788,
                Name = "Blue Veined Cheese",
                Category = "Dairy",
                Units = 29,
                UnitPrice = 15,
                Price = 435,
                OrderDate = new DateTime(2025, 7, 10),
                ShippedDate = new DateTime(2025, 7, 17),
                ShipmentCategory = "Dairy",
                OrderReached = "No",
                ParentID = 5
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 10,
                ShipID = 5896,
                Name = "Butter",
                Category = "Dairy",
                Units = 21,
                UnitPrice = 9,
                Price = 189,
                OrderDate = new DateTime(2025, 9, 18),
                ShippedDate = new DateTime(2025, 9, 25),
                ShipmentCategory = "Dairy",
                OrderReached = "Yes",
                ParentID = 5
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 11,
                Name = "Order 3",
                ParentID = null
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 12,
                ShipID = 6993,
                Name = "Lead glassware",
                Category = "Crystals",
                Units = 23,
                UnitPrice = 6,
                Price = 138,
                OrderDate = new DateTime(2025, 2, 7),
                ShippedDate = new DateTime(2025, 2, 14),
                ShipmentCategory = "Crystals",
                OrderReached = "No",
                ParentID = 11
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 13,
                ShipID = 6453,
                Name = "Pharmaceutical glass",
                Category = "Crystals",
                Units = 25,
                UnitPrice = 11,
                Price = 275,
                OrderDate = new DateTime(2025, 4, 19),
                ShippedDate = new DateTime(2025, 4, 26),
                ShipmentCategory = "Crystals",
                OrderReached = "Yes",
                ParentID = 11
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 14,
                ShipID = 6554,
                Name = "Glass beads",
                Category = "Crystals",
                Units = 28,
                UnitPrice = 16,
                Price = 448,
                OrderDate = new DateTime(2025, 5, 22),
                ShippedDate = new DateTime(2025, 5, 29),
                ShipmentCategory = "Crystals",
                OrderReached = "Yes",
                ParentID = 11
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 15,
                ShipID = 6780,
                Name = "Yellowfin Tuna",
                Category = "Seafood",
                Units = 20,
                UnitPrice = 8,
                Price = 160,
                OrderDate = new DateTime(2025, 3, 5),
                ShippedDate = new DateTime(2025, 3, 15),
                ShipmentCategory = "Seafood",
                OrderReached = "No",
                ParentID = 11
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 16,
                Name = "Order 4",
                ParentID = null
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 17,
                ShipID = 7890,
                Name = "Broccoli",
                Category = "Fresh Vegetables",
                Units = 27,
                UnitPrice = 8,
                Price = 216,
                OrderDate = new DateTime(2025, 2, 5),
                ShippedDate = new DateTime(2025, 2, 10),
                ShipmentCategory = "Fresh Vegetables",
                OrderReached = "No",
                ParentID = 16
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 18,
                ShipID = 7633,
                Name = "Spinach",
                Category = "Leafy Greens",
                Units = 24,
                UnitPrice = 6,
                Price = 144,
                OrderDate = new DateTime(2025, 2, 18),
                ShippedDate = new DateTime(2025, 2, 24),
                ShipmentCategory = "Leafy Greens",
                OrderReached = "Yes",
                ParentID = 16
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 19,
                ShipID = 7799,
                Name = "Carrots",
                Category = "Root Vegetables",
                Units = 30,
                UnitPrice = 5,
                Price = 150,
                OrderDate = new DateTime(2025, 3, 10),
                ShippedDate = new DateTime(2025, 3, 16),
                ShipmentCategory = "Root Vegetables",
                OrderReached = "Yes",
                ParentID = 16
            });

            CalculateTotalPrices(DataCollection);
            return DataCollection;
        }

        public static List<ShipmentData> GetData()
        {
            var data = new List<ShipmentData>(capacity: 150);
            var rnd = new Random(42); // deterministic
            var baseOrderDate = new DateTime(2025, 1, 1);
            // pools for categories/items - standardized to Title Case
            var categories = new[]
            {
                ("Seafood", new[] { "Mackerel", "Herrings", "Tilapias", "White Shrimp", "Yellowfin Tuna" }),
                ("Dairy", new[] { "Fresh Cheese", "Blue Veined Cheese", "Butter", "Milk", "Yogurt" }),
                ("Edible", new[] { "Preserved Olives", "Sweet corn", "Pickles", "Tomato Puree", "Olive Oil" }),
                ("Crystals", new[] { "Lead glassware", "Pharmaceutical glass", "Glass beads", "Crystal vials", "Borosilicate glass" }),
                ("Fresh Vegetables", new[] { "Broccoli", "Spinach", "Carrots", "Lettuce", "Cabbage" }),
                ("Leafy Greens", new[] { "Kale", "Arugula", "Chard", "Collards", "Mustard Greens" }),
                ("Root Vegetables", new[] { "Beets", "Radish", "Parsnip", "Turnip", "Rutabaga" }),
                ("Paper", new[] { "Printer Paper", "Photo Paper", "Sticky Notes", "Card Stock", "Plotter Rolls" }),
                ("Consumables", new[] { "Ink Cartridges", "Toner", "Markers", "Glue Sticks", "Tape Rolls" }),
                ("Tools", new[] { "Staplers", "Hole Punch", "Cutters", "Rulers", "Scissors" }),
                ("Stationery", new[] { "Notebooks", "Pens", "Pencils", "Folders", "Envelopes" })
            };
            int id = 0;
            int shipSeed = 4500;
            for (int p = 1; p <= 40; p++)
            {
                int parentId = id++;
                data.Add(new ShipmentData
                {
                    ID = parentId,
                    Name = $"Order {p}",
                    ParentID = null
                });
                for (int c = 0; c < 4; c++)
                {
                    // pick a category and item name
                    var (cat, items) = categories[(p + c) % categories.Length];
                    var itemName = items[(p * 3 + c) % items.Length];
                    // numbers
                    int units = 20 + rnd.Next(11); // 20..30
                    int unitPrice = 5 + rnd.Next(20); // 5..24
                    int price = units * unitPrice;
                    // dates
                    var orderDate = baseOrderDate.AddDays(p * 7 + c * 3);
                    var shipLag = 3 + rnd.Next(10); // 3..12 days
                    var shippedDate = orderDate.AddDays(shipLag);
                    // reached?
                    var reached = shippedDate >= orderDate.AddDays(7) && rnd.Next(100) > 30 ? "Yes" : "No";
                    data.Add(new ShipmentData
                    {
                        ID = id,
                        ShipID = shipSeed + id,
                        Name = itemName,
                        Category = cat,
                        Units = units,
                        UnitPrice = unitPrice,
                        Price = price,
                        OrderDate = orderDate,
                        ShippedDate = shippedDate,
                        ShipmentCategory = cat,
                        OrderReached = reached,
                        ParentID = parentId
                    });
                    id++;
                }
            }
            CalculateTotalPrices(data);
            return data;
        }
    }
}