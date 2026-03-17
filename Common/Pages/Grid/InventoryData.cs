#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

namespace blazor_inventorydata
{
    /// <summary>
    /// Represents the stock availability classification for an item.
    /// </summary>
    public enum StockStatus
    {
        /// <summary>
        /// No quantity is available.
        /// </summary>
        OutOfStock = 0,

        /// <summary>
        /// Quantity is less than half of the reorder level.
        /// </summary>
        Critical = 1,

        /// <summary>
        /// Quantity is below the reorder level but at least half of it.
        /// </summary>
        Low = 2,

        /// <summary>
        /// Quantity meets or exceeds the reorder level.
        /// </summary>
        InStock = 3
    }

    /// <summary>
    /// Defines an inventory record with computed status and percentage helpers.
    /// </summary>
    public sealed class InventoryItem
    {
        private int _stockOnHand;
        private int _reorderLevel;

        /// <summary>
        /// Unique product identifier in the format <c>SKU-{CAT}-{####}</c>.
        /// </summary>
        public string ProductCode { get; set; } = string.Empty;

        /// <summary>
        /// Descriptive name of the product.
        /// </summary>
        public string ProductName { get; set; } = string.Empty;

        /// <summary>
        /// Category name assigned to the product.
        /// </summary>
        public string Category { get; set; } = string.Empty;

        /// <summary>
        /// Supplier name associated with the product.
        /// </summary>
        public string SupplierName { get; set; } = string.Empty;

        /// <summary>
        /// Current available quantity.
        /// </summary>
        public int StockOnHand
        {
            get => _stockOnHand;
            set
            {
                _stockOnHand = value;
                UpdateRestockNeeded();
            }
        }

        /// <summary>
        /// Target quantity at which replenishment is required.
        /// </summary>
        public int ReorderLevel
        {
            get => _reorderLevel;
            set
            {
                _reorderLevel = value;
                UpdateRestockNeeded();
            }
        }

        /// <summary>
        /// Indicates whether the available quantity is less than or equal to the reorder level.
        /// </summary>
        public bool RestockNeeded { get; private set; }

        /// <summary>
        /// Stock availability classification derived from quantity relative to the reorder level.
        /// </summary>
        public StockStatus StockStatus
        {
            get
            {
                if (StockOnHand <= 0) return StockStatus.OutOfStock;
                if (ReorderLevel <= 0) return StockStatus.InStock;
                if ((2 * StockOnHand) < ReorderLevel) return StockStatus.Critical;
                if (StockOnHand < ReorderLevel) return StockStatus.Low;
                return StockStatus.InStock;
            }
        }

        /// <summary>
        /// Most recent restock date.
        /// </summary>
        public DateTime LastRestockedDate { get; set; }

        /// <summary>
        /// Percentage value that represents how much of the reorder level is currently available.
        /// </summary>
        public int PercentOfReorder
        {
            get
            {
                if (ReorderLevel <= 0) return StockOnHand > 0 ? 100 : 0;

                long numerator = ((long)StockOnHand * 100L) + (ReorderLevel / 2);
                int pct = (int)(numerator / ReorderLevel);

                if (pct < 0) return 0;
                if (pct > 200) return 200;
                return pct;
            }
        }

        /// <summary>
        /// Updates the <see cref="RestockNeeded"/> flag.
        /// </summary>
        private void UpdateRestockNeeded()
        {
            RestockNeeded = _stockOnHand <= _reorderLevel;
        }
    }

    /// <summary>
    /// Provides access to inventory records used in the application.
    /// </summary>
    public static class InventoryData
    {
        /// <summary>
        /// Reference date used to compute recent restock dates.
        /// </summary>
        private static readonly DateTime ReferenceDate = new DateTime(2026, 02, 26);

        /// <summary>
        /// Returns a collection of inventory items.
        /// </summary>
        /// <returns>
        /// A collection of <see cref="InventoryItem"/> objects.
        /// </returns>
        public static List<InventoryItem> GetAllRecords()
        {
            const int recordCount = 200;
            var data = new List<InventoryItem>(recordCount);

            // Category, supplier, and product name sources.
            string[] categories =
            {
                "Electronics", "Home & Kitchen", "Office Supplies", "Personal Care",
                "Sports & Outdoors", "Automotive", "Grocery", "Toys & Games",
                "Pet Supplies", "Health & Wellness", "Garden & Outdoor", "Books & Stationery",
                "Baby Products", "Tools & Hardware", "Beauty & Grooming", "Household Essentials"
            };

            string[] suppliers =
            {
                "Acme Distributors", "Nova Wholesale", "GreenLeaf Supply Co.", "BluePeak Traders",
                "UrbanMart Partners", "Sunrise Imports", "Coastal Supply House", "PrimeLogix Retail",
                "Everest Global Trade", "Silverline Merchants", "Maple Ridge Supply", "Nimbus Distribution",
                "Orchid Exports", "Vertex Commerce", "Horizon Retail Links", "Summit Source Ltd.",
                "Ironwood Trading", "Crescent Wholesale", "Starlight Distributors", "Harbor & Hill Supply",
                "Canyon Creek Traders", "Pioneer Retail Group", "NorthStar Outlets", "MetroBridge Imports"
            };

            string[] productNames =
            {
                "Adapter", "Backpack", "Blender", "Cable", "Office Chair", "Phone Charger", "Desk Lamp",
                "Wireless Earbuds", "Extension Board", "Fitness Band", "Hair Dryer", "Electric Kettle",
                "Keyboard", "LED Light Bulb", "Lunch Box", "Mechanical Pencil", "Monitor Stand",
                "Mouse Pad", "Notebook", "Power Bank", "Printer Paper", "Safety Gloves", "Shampoo Bottle",
                "Sports Bottle", "Stapler", "Toothbrush", "Toy Car", "USB Drive",
                "Vacuum Bags", "Wiper Blade", "Air Pump", "Baby Monitor", "Bottle Warmer",
                "Cable Clips", "Caliper", "Coffee Grinder", "Cotton Swabs", "Cutting Mat",
                "Desk Organizer", "Dumbbell", "Face Wash", "Garden Shears", "Gift Wrap",
                "Glue Gun", "Hose Nozzle", "Label Maker", "Pliers", "Razor Pack",
                "Screwdriver", "Thermos", "Tissue Box", "Tool Box", "Building Blocks",
                "Trimmer", "Filter Cartridge", "Yoga Mat"
            };

            // Reorder level values spread in [5, 124], then reordered deterministically.
            var reorderLevels = new List<int>(recordCount);
            for (int n = 0; n < recordCount; n++)
            {
                int level = 5 + ((n * 11 + 25) % 120);
                reorderLevels.Add(level);
            }
            for (int n = recordCount - 1; n > 0; n--)
            {
                int j = (n * 37) % recordCount;
                (reorderLevels[n], reorderLevels[j]) = (reorderLevels[j], reorderLevels[n]);
            }

            // Stock values spread in [0, 149], independently reordered.
            var stocks = new List<int>(recordCount);
            for (int n = 0; n < recordCount; n++)
            {
                int stock = (n * 19 + 7) % 150;
                stocks.Add(stock);
            }
            for (int n = recordCount - 1; n > 0; n--)
            {
                int j = (n * 53) % recordCount;
                (stocks[n], stocks[j]) = (stocks[j], stocks[n]);
            }

            // Build the items.
            for (int i = 0; i < recordCount; i++)
            {
                string category = categories[(i * 5) % categories.Length];
                string supplier = suppliers[(i * 3) % suppliers.Length];
                string productName = productNames[(i * 7) % productNames.Length];

                int reorderLevel = reorderLevels[i];
                int stockOnHand = stocks[i];

                if (reorderLevel < 1) reorderLevel = 1;
                if (stockOnHand < 0) stockOnHand = 0;

                // Most recent restock date within the previous 90 days.
                int dayBack = (i % 90) + 1;   // 1..90
                int earlier = i % 6;          // 0..5
                int restockBack = dayBack + earlier;
                if (restockBack > 90) restockBack = 90;

                // Product code format: SKU-{CAT}-{####}
                // CAT = first three characters from Category (spaces removed, uppercased, padded if needed)
                string cat = category.Replace(" ", string.Empty);
                if (cat.Length < 3) cat = cat.PadRight(3, 'X');
                string productCode = $"SKU-{cat[..3].ToUpperInvariant()}-{(i + 1):0000}";

                data.Add(new InventoryItem
                {
                    ProductCode = productCode,
                    ProductName = productName,
                    Category = category,
                    SupplierName = supplier,
                    ReorderLevel = reorderLevel,
                    StockOnHand = stockOnHand,
                    LastRestockedDate = ReferenceDate.AddDays(-restockBack)
                });
            }

            return data;
        }
    }
}