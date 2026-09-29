using System;
using System.Collections.Generic;
using System.Globalization;

namespace BlazorDemos.Pages.Grid.InventoryDeviceNameSpace
{
    public enum ProductCategory
    {
        Laptop,
        Smartphone,
        HeadPhone,
        Wearables,
        Tablet,
        Monitor,
        Accessories,
        Camera,
        SmartTV,
        Gaming
    }

    public enum StockState
    {
        InStock,
        LowStock,
        OutOfStock
    }

    public class SalesPoint
    {
        public int Day { get; set; }
        public int Units { get; set; }
    }

    public class TechSpec
    {
        public string Label { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }

    public class Highlight
    {
        public string Text { get; set; } = string.Empty;
    }

    public class InventoryProduct
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Sku { get; set; } = string.Empty;
        public Uri? ImageUrl { get; set; }
        public string ImageColor { get; set; } = "#1f2937";
        public ProductCategory Category { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
        public int ReviewCount { get; set; }
        public StockState Status { get; set; }
        public decimal SalesTrendPercent { get; set; }
        public IReadOnlyList<SalesPoint>? SalesLast30Days { get; init; }
        public int SalesTotal { get; set; }
        public string LongDescription { get; set; } = string.Empty;
        public IReadOnlyList<Highlight>? Highlights { get; init; }
        public IReadOnlyList<TechSpec>? Specs { get; init; }
        public decimal OriginalPrice { get; set; }
        public decimal CostPrice { get; set; }

        public string CategoryLabel => Category switch
        {
            ProductCategory.Laptop => "Laptop",
            ProductCategory.Smartphone => "Smartphone",
            ProductCategory.HeadPhone => "HeadPhone",
            ProductCategory.Wearables => "Wearables",
            ProductCategory.Tablet => "Tablet",
            ProductCategory.Monitor => "Monitor",
            ProductCategory.Accessories => "Accessories",
            ProductCategory.Camera => "Camera",
            ProductCategory.SmartTV => "SmartTV",
            ProductCategory.Gaming => "Gaming",
            _ => Category.ToString()
        };

        public string CategoryIcon => Category switch
        {
            ProductCategory.Laptop => "🖥️",
            ProductCategory.Smartphone => "📱",
            ProductCategory.HeadPhone => "🎧",
            ProductCategory.Wearables => "⌚",
            ProductCategory.Tablet => "📲",
            ProductCategory.Monitor => "🖥️",
            ProductCategory.Accessories => "⌨️",
            ProductCategory.Camera => "📷",
            ProductCategory.SmartTV => "📺",
            ProductCategory.Gaming => "🎮",
            _ => "📦"
        };

        public string StatusLabel => Status switch
        {
            StockState.InStock => "In Stock",
            StockState.LowStock => "Low Stock",
            StockState.OutOfStock => "Out of Stock",
            _ => Status.ToString()
        };

        public string StatusCss => Status switch
        {
            StockState.InStock => "ig-status--ok",
            StockState.LowStock => "ig-status--low",
            StockState.OutOfStock => "ig-status--out",
            _ => string.Empty
        };

        public string StatusUnit => $"{Stock} units";
        public int DiscountPercent => OriginalPrice <= 0 ? 0 :
            (int)Math.Round((1m - Price / OriginalPrice) * 100m);
        public decimal ProfitMargin => Price <= 0 ? 0 :
            Math.Round((Price - CostPrice) / Price * 100m, 1);
        public int TotalRatings => ReviewCount;
        private decimal RatingClamped => Math.Clamp(Rating, 0m, 5m);
        public int RatingFullStars => (int)Math.Floor(RatingClamped);
        public decimal RatingPartial => RatingClamped - RatingFullStars;
        public decimal RatingPartialPercent =>
            Math.Round(RatingPartial * 100m, 1);
        public bool RatingHasPartialStar => RatingPartial > 0m;
        public string RatingDisplay => RatingClamped.ToString("0.0", CultureInfo.InvariantCulture);
        private int Percent5 => (int)Math.Round(Math.Clamp((RatingClamped - 0.5m) * 22m, 0m, 100m));
        private int Percent4 => (int)Math.Round(Math.Clamp(15m - Math.Abs(RatingClamped - 3.5m) * 5m, 0m, 30m));
        private int Percent3 => (int)Math.Round(Math.Clamp(12m - Math.Abs(RatingClamped - 2.5m) * 4m, 0m, 25m));
        private int Percent2 => (int)Math.Round(Math.Clamp(10m - Math.Abs(RatingClamped - 1.5m) * 3m, 0m, 20m));
        private int Percent1 => (int)Math.Round(Math.Clamp(30m - RatingClamped * 5m, 0m, 35m));
        public int Star5Percent => Percent5;
        public int Star4Percent => Percent4;
        public int Star3Percent => Percent3;
        public int Star2Percent => Percent2;
        public int Star1Percent => Math.Max(0, 100 - (Percent5 + Percent4 + Percent3 + Percent2));
    }

    public static class InventoryGridSeed
    {
        private static readonly List<SalesPoint> Trend101 = new()
        {
            new() { Day = 3, Units = 276 }, new() { Day = 6, Units = 271 }, new() { Day = 9, Units = 189 },
            new() { Day = 12, Units = 189 }, new() { Day = 15, Units = 307 }, new() { Day = 18, Units = 377 },
            new() { Day = 21, Units = 270 }, new() { Day = 24, Units = 145 }, new() { Day = 27, Units = 167 },
            new() { Day = 30, Units = 320 }
        };

        private static readonly List<SalesPoint> Trend202 = new()
        {
            new() { Day = 3, Units = 216 }, new() { Day = 6, Units = 261 }, new() { Day = 9, Units = 205 },
            new() { Day = 12, Units = 133 }, new() { Day = 15, Units = 176 }, new() { Day = 18, Units = 304 },
            new() { Day = 21, Units = 357 }, new() { Day = 24, Units = 240 }, new() { Day = 27, Units = 105 },
            new() { Day = 30, Units = 127 }
        };

        private static readonly List<SalesPoint> Trend303 = new()
        {
            new() { Day = 3, Units = 382 }, new() { Day = 6, Units = 413 }, new() { Day = 9, Units = 306 },
            new() { Day = 12, Units = 208 }, new() { Day = 15, Units = 248 }, new() { Day = 18, Units = 399 },
            new() { Day = 21, Units = 475 }, new() { Day = 24, Units = 352 }, new() { Day = 27, Units = 178 },
            new() { Day = 30, Units = 149 }
        };

        private static readonly List<SalesPoint> Trend404 = new()
        {
            new() { Day = 3, Units = 150 }, new() { Day = 6, Units = 180 }, new() { Day = 9, Units = 138 },
            new() { Day = 12, Units = 84 }, new() { Day = 15, Units = 96 }, new() { Day = 18, Units = 186 },
            new() { Day = 21, Units = 261 }, new() { Day = 24, Units = 221 }, new() { Day = 27, Units = 94 },
            new() { Day = 30, Units = 52 }
        };

        private static readonly List<SalesPoint> Trend505 = new()
        {
            new() { Day = 3, Units = 123 }, new() { Day = 6, Units = 149 }, new() { Day = 9, Units = 108 },
            new() { Day = 12, Units = 65 }, new() { Day = 15, Units = 88 }, new() { Day = 18, Units = 170 },
            new() { Day = 21, Units = 228 }, new() { Day = 24, Units = 186 }, new() { Day = 27, Units = 84 },
            new() { Day = 30, Units = 53 }
        };

        private static readonly List<SalesPoint> Trend606 = new()
        {
            new() { Day = 3, Units = 108 }, new() { Day = 6, Units = 134 }, new() { Day = 9, Units = 97 },
            new() { Day = 12, Units = 57 }, new() { Day = 15, Units = 79 }, new() { Day = 18, Units = 152 },
            new() { Day = 21, Units = 204 }, new() { Day = 24, Units = 168 }, new() { Day = 27, Units = 78 },
            new() { Day = 30, Units = 52 }
        };

        private static readonly List<SalesPoint> Trend707 = new()
        {
            new() { Day = 3, Units = 206 }, new() { Day = 6, Units = 246 }, new() { Day = 9, Units = 189 },
            new() { Day = 12, Units = 116 }, new() { Day = 15, Units = 142 }, new() { Day = 18, Units = 265 },
            new() { Day = 21, Units = 357 }, new() { Day = 24, Units = 304 }, new() { Day = 27, Units = 141 },
            new() { Day = 30, Units = 80 }
        };

        private static readonly List<SalesPoint> Trend808 = new()
        {
            new() { Day = 3, Units = 276 }, new() { Day = 6, Units = 271 }, new() { Day = 9, Units = 189 },
            new() { Day = 12, Units = 189 }, new() { Day = 15, Units = 307 }, new() { Day = 18, Units = 377 },
            new() { Day = 21, Units = 270 }, new() { Day = 24, Units = 145 }, new() { Day = 27, Units = 167 },
            new() { Day = 30, Units = 320 }
        };

        private static readonly List<SalesPoint> Trend909 = new()
        {
            new() { Day = 3, Units = 181 }, new() { Day = 6, Units = 216 }, new() { Day = 9, Units = 170 },
            new() { Day = 12, Units = 110 }, new() { Day = 15, Units = 135 }, new() { Day = 18, Units = 253 },
            new() { Day = 21, Units = 342 }, new() { Day = 24, Units = 304 }, new() { Day = 27, Units = 165 },
            new() { Day = 30, Units = 92 }
        };

        private static readonly List<SalesPoint> Trend1010 = new()
        {
            new() { Day = 3, Units = 137 }, new() { Day = 6, Units = 169 }, new() { Day = 9, Units = 129 },
            new() { Day = 12, Units = 77 }, new() { Day = 15, Units = 101 }, new() { Day = 18, Units = 203 },
            new() { Day = 21, Units = 266 }, new() { Day = 24, Units = 219 }, new() { Day = 27, Units = 100 },
            new() { Day = 30, Units = 63 }
        };

        private static List<SalesPoint> GetTrend(int seed)
        {
            return seed switch
            {
                101 => Trend101,
                202 => Trend202,
                303 => Trend303,
                404 => Trend404,
                505 => Trend505,
                606 => Trend606,
                707 => Trend707,
                808 => Trend808,
                909 => Trend909,
                1010 => Trend1010,
                _ => new List<SalesPoint>()
            };
        }


        public static IReadOnlyList<InventoryProduct> Build(string? webAssetsPath) => new List<InventoryProduct>
        {
            new()
            {
                Id = 1, Name = "MacBook Pro 14", Description = "M3 Pro Chip • 16GB RAM", Sku = "MBP14-M3",
                ImageUrl= new Uri("macbook", UriKind.Relative),
                ImageColor = "#0b1220", Category = ProductCategory.Laptop,
                Stock = 24, Price = 2499m, Rating = 4.9m, ReviewCount = 128,
                Status = StockState.InStock, SalesTrendPercent = 5.0m, SalesTotal = 420,
                SalesLast30Days = GetTrend(101),
                LongDescription = "The MacBook Pro 14-inch with M3 Pro chip delivers exceptional performance for demanding workflows.",
                Highlights = new List<Highlight>()
                {
                    new() { Text = "M3 Pro chip with 11-core CPU and 14-core GPU" },
                    new() { Text = "14.2-inch Liquid Retina XDR display" },
                    new() { Text = "16GB Unified Memory" },
                    new() { Text = "512GB SSD storage" },
                    new() { Text = "Up to 18 hours battery life" }
                },
                Specs = new List<TechSpec>()
                {
                    new() { Label = "Display",    Value = "14.2-inch Liquid Retina XDR" },
                    new() { Label = "Resolution", Value = "3024 x 1964 pixels" },
                    new() { Label = "Processor",  Value = "Apple M3 Pro chip" },
                    new() { Label = "Memory",     Value = "16GB Unified Memory" },
                    new() { Label = "Storage",    Value = "512GB SSD" },
                    new() { Label = "OS",         Value = "macOS Sonoma" }
                },
                OriginalPrice = 2799m, CostPrice = 2025m
            },
            new()
            {
                Id = 2, Name = "iPhone 15 Pro Max", Description = "256GB • Natural Titanium", Sku = "IP15PM-256",
                ImageUrl = new Uri("iphone", UriKind.Relative),
                ImageColor = "#1f2937", Category = ProductCategory.Smartphone,
                Stock = 12, Price = 1199m, Rating = 3.5m, ReviewCount = 96,
                Status = StockState.LowStock, SalesTrendPercent = -9.8m, SalesTotal = 275,
                SalesLast30Days = GetTrend(202),
                LongDescription = "iPhone 15 Pro Max features a strong and light aerospace-grade titanium design with a textured matte glass back.",
                Highlights = new List<Highlight>()
                {
                    new() { Text = "A17 Pro chip with 6-core GPU" },
                    new() { Text = "6.7-inch Super Retina XDR display" },
                    new() { Text = "Pro camera system (48MP Main)" },
                    new() { Text = "Titanium with textured matte glass" },
                    new() { Text = "USB-C connectivity" }
                },
                Specs = new List<TechSpec>()
                {
                    new() { Label = "Display",    Value = "6.7-inch Super Retina XDR" },
                    new() { Label = "Resolution", Value = "2796 x 1290 pixels" },
                    new() { Label = "Processor",  Value = "Apple A17 Pro" },
                    new() { Label = "Memory",     Value = "8GB RAM" },
                    new() { Label = "Storage",    Value = "256GB" },
                    new() { Label = "OS",         Value = "iOS 17" }
                },
                OriginalPrice = 1299m, CostPrice = 950m
            },
            new()
            {
                Id = 3, Name = "AirPods Pro", Description = "USB-C • Active Noise", Sku = "APP2-USB-C",
                ImageUrl = new Uri("airpods-pro", UriKind.Relative),
                ImageColor = "#f1f5f9", Category = ProductCategory.HeadPhone,
                Stock = 56, Price = 249m, Rating = 4.2m, ReviewCount = 210,
                Status = StockState.InStock, SalesTrendPercent = -7.0m, SalesTotal = 558,
                SalesLast30Days = GetTrend(303),
                LongDescription = "AirPods Pro feature the H2 chip for up to 2x more Active Noise Cancellation and Adaptive Audio.",
                Highlights = new List<Highlight>()
                {
                    new() { Text = "Active Noise Cancellation" },
                    new() { Text = "Adaptive Audio" },
                    new() { Text = "Personalized Spatial Audio" },
                    new() { Text = "USB-C charging case" },
                    new() { Text = "Up to 6 hours listening" }
                },
                Specs = new List<TechSpec>()
                {
                    new() { Label = "Chip",         Value = "Apple H2" },
                    new() { Label = "Battery Life", Value = "6 hrs (ANC on)" },
                    new() { Label = "Connectivity", Value = "Bluetooth 5.3" },
                    new() { Label = "Charging",     Value = "USB-C / MagSafe / Qi" },
                    new() { Label = "Water Rating", Value = "IP54" },
                    new() { Label = "Weight",       Value = "5.3 g (each bud)" }
                },
                OriginalPrice = 279m, CostPrice = 165m
            },
            new()
            {
                Id = 4, Name = "Apple Watch Series 9", Description = "45mm • Midnight Aluminum", Sku = "AW9-45-MID",
                ImageUrl = new Uri("apple-watch-series", UriKind.Relative),
                ImageColor = "#0f172a", Category = ProductCategory.Wearables,
                Stock = 31, Price = 429m, Rating = 2.7m, ReviewCount = 78,
                Status = StockState.InStock, SalesTrendPercent = 4.9m, SalesTotal = 215,
                SalesLast30Days = GetTrend(404),
                LongDescription = "Apple Watch Series 9 features the new S9 SiP and a magical new double tap gesture.",
                Highlights = new List<Highlight>()
                {
                    new() { Text = "S9 SiP with 4-core Neural Engine" },
                    new() { Text = "Double Tap gesture" },
                    new() { Text = "Always-On Retina display" },
                    new() { Text = "ECG and Blood Oxygen" },
                    new() { Text = "Up to 18 hours battery" }
                },
                Specs = new List<TechSpec>()
                {
                    new() { Label = "Display",    Value = "45mm Always-On Retina" },
                    new() { Label = "Chip",       Value = "Apple S9 SiP" },
                    new() { Label = "Storage",    Value = "64GB" },
                    new() { Label = "Connectivity", Value = "GPS + Cellular" },
                    new() { Label = "Battery",    Value = "Up to 18 hours" },
                    new() { Label = "OS",         Value = "watchOS 10" }
                },
                OriginalPrice = 499m, CostPrice = 320m
            },
            new()
            {
                Id = 5, Name = "iPad Air 5th Gen", Description = "256GB • Wi-Fi • Blue", Sku = "IPA5-256-BLU",
                ImageUrl = new Uri("ipad", UriKind.Relative),
                ImageColor = "#1e3a8a", Category = ProductCategory.Tablet,
                Stock = 8, Price = 749m, Rating = 3.8m, ReviewCount = 54,
                Status = StockState.LowStock, SalesTrendPercent = -11.3m, SalesTotal = 142,
                SalesLast30Days = GetTrend(505),
                LongDescription = "iPad Air with M1 chip delivers a powerful performance jump and an immersive 10.9-inch Liquid Retina display.",
                Highlights = new List<Highlight>()
                {
                    new() { Text = "Apple M1 chip" },
                    new() { Text = "10.9-inch Liquid Retina display" },
                    new() { Text = "12MP Wide camera" },
                    new() { Text = "Supports Apple Pencil (2nd gen)" },
                    new() { Text = "5G capable (cellular model)" }
                },
                Specs = new List<TechSpec>()
                {
                    new() { Label = "Display",    Value = "10.9-inch Liquid Retina" },
                    new() { Label = "Resolution", Value = "2360 x 1640 pixels" },
                    new() { Label = "Processor",  Value = "Apple M1" },
                    new() { Label = "Storage",    Value = "256GB" },
                    new() { Label = "Connectivity", Value = "Wi-Fi 6" },
                    new() { Label = "OS",         Value = "iPadOS 17" }
                },
                OriginalPrice = 799m, CostPrice = 590m
            },
            new()
            {
                Id = 6, Name = "LG UltraGear 27", Description = "QHD • 144Hz • IPS", Sku = "LG27-144",
                ImageUrl = new Uri("lg", UriKind.Relative),
                ImageColor = "#111827", Category = ProductCategory.Monitor,
                Stock = 18, Price = 329m, Rating = 4.5m, ReviewCount = 33,
                Status = StockState.InStock, SalesTrendPercent = 5.2m, SalesTotal = 142,
                SalesLast30Days = GetTrend(606),
                LongDescription = "LG UltraGear 27-inch QHD IPS gaming monitor with 144Hz refresh rate and 1ms response time.",
                Highlights = new List<Highlight>()
                {
                    new() { Text = "27-inch QHD (2560x1440) IPS display" },
                    new() { Text = "144Hz refresh rate, 1ms GtG" },
                    new() { Text = "NVIDIA G-SYNC Compatible" },
                    new() { Text = "HDR10 support" },
                    new() { Text = "3-side virtually borderless" }
                },
                Specs = new List<TechSpec>()
                {
                    new() { Label = "Display",    Value = "27-inch QHD IPS" },
                    new() { Label = "Resolution", Value = "2560 x 1440" },
                    new() { Label = "Refresh",    Value = "144 Hz" },
                    new() { Label = "Response",   Value = "1 ms GtG" },
                    new() { Label = "HDR",        Value = "HDR10" },
                    new() { Label = "Ports",      Value = "HDMI x2, DP x1" }
                },
                OriginalPrice = 399m, CostPrice = 240m
            },
            new()
            {
                Id = 7, Name = "Magic Keyboard", Description = "Mac • Wireless", Sku = "MK-ML/A22",
                ImageUrl = new Uri("magic-keyboard", UriKind.Relative),
                ImageColor = "#e2e8f0", Category = ProductCategory.Accessories,
                Stock = 72, Price = 99m, Rating = 3.2m, ReviewCount = 137,
                Status = StockState.InStock, SalesTrendPercent = -10.0m, SalesTotal = 261,
                SalesLast30Days = GetTrend(707),
                LongDescription = "Magic Keyboard delivers a remarkably comfortable and precise typing experience.",
                Highlights = new List<Highlight>()
                {
                    new() { Text = "Wireless Bluetooth connectivity" },
                    new() { Text = "Rechargeable internal battery" },
                    new() { Text = "Numeric keypad" },
                    new() { Text = "Lightning to USB cable included" },
                    new() { Text = "Pairs automatically with Mac" }
                },
                Specs = new List<TechSpec>()
                {
                    new() { Label = "Layout",    Value = "Full-size with Numeric Keypad" },
                    new() { Label = "Connection", Value = "Bluetooth, Lightning" },
                    new() { Label = "Battery",   Value = "Up to 1 month" },
                    new() { Label = "Weight",    Value = "390 g" },
                    new() { Label = "Compat",    Value = "macOS 10.12.4+" },
                    new() { Label = "Color",     Value = "White" }
                },
                OriginalPrice = 129m, CostPrice = 65m
            },
            new()
            {
                Id = 8, Name = "Galaxy S24 Ultra", Description = "512GB • Phantom Black", Sku = "GS24U-512",
                ImageUrl = new Uri("galaxy-ultra", UriKind.Relative),
                ImageColor = "#334155", Category = ProductCategory.Smartphone,
                Stock = 28, Price = 1299m, Rating = 4.7m, ReviewCount = 112,
                Status = StockState.InStock, SalesTrendPercent = 3.7m, SalesTotal = 420,
                SalesLast30Days = GetTrend(808),
                LongDescription = "Galaxy S24 Ultra with Galaxy AI, the most powerful Galaxy yet, featuring a titanium frame and 200MP camera.",
                Highlights = new List<Highlight>()
                {
                    new() { Text = "Snapdragon 8 Gen 3 for Galaxy" },
                    new() { Text = "200MP main camera" },
                    new() { Text = "6.8-inch Dynamic AMOLED 2X" },
                    new() { Text = "Built-in S Pen" },
                    new() { Text = "Galaxy AI features" }
                },
                Specs = new List<TechSpec>()
                {
                    new() { Label = "Display",    Value = "6.8\" Dynamic AMOLED 2X" },
                    new() { Label = "Resolution", Value = "3120 x 1440" },
                    new() { Label = "Processor",  Value = "Snapdragon 8 Gen 3" },
                    new() { Label = "Memory",     Value = "12GB RAM" },
                    new() { Label = "Storage",    Value = "512GB" },
                    new() { Label = "OS",         Value = "Android 14, One UI 6.1" }
                },
                OriginalPrice = 1419m, CostPrice = 1020m
            },
            new()
            {
                Id = 9, Name = "Sony WH-1000XM5", Description = "Noise Cancelling Headphones", Sku = "WH1000XM5",
                ImageUrl = new Uri("sony", UriKind.Relative),
                ImageColor = "#0f172a", Category = ProductCategory.HeadPhone,
                Stock = 34, Price = 349m, Rating = 4.0m, ReviewCount = 198,
                Status = StockState.InStock, SalesTrendPercent = -11.0m, SalesTotal = 218,
                SalesLast30Days = GetTrend(909),
                LongDescription = "Industry-leading noise canceling with Auto NC Optimizer and crystal-clear hands-free calling.",
                Highlights = new List<Highlight>()
                {
                    new() { Text = "Industry-leading noise cancellation" },
                    new() { Text = "30mm driver units" },
                    new() { Text = "8 mics, crystal-clear calls" },
                    new() { Text = "Up to 30 hours battery" },
                    new() { Text = "Multipoint connection" }
                },
                Specs = new List<TechSpec>()
                {
                    new() { Label = "Driver",     Value = "30mm dynamic" },
                    new() { Label = "Battery",    Value = "30 hrs (ANC on)" },
                    new() { Label = "Charging",   Value = "USB-C, 3 min = 3 hrs" },
                    new() { Label = "Codec",      Value = "LDAC, AAC, SBC" },
                    new() { Label = "Weight",     Value = "250 g" },
                    new() { Label = "Bluetooth",  Value = "5.2, Multipoint" }
                },
                OriginalPrice = 449m, CostPrice = 280m
            },
            new()
            {
                Id = 10, Name = "Nintendo Switch", Description = "Neon • Handheld Console", Sku = "NS-NEON",
                ImageUrl = new Uri("nintendo-switch", UriKind.Relative),
                ImageColor = "#e0e7ff", Category = ProductCategory.Gaming,
                Stock = 15, Price = 299m, Rating = 4.3m, ReviewCount = 89,
                Status = StockState.LowStock, SalesTrendPercent = 10.3m, SalesTotal = 215,
                SalesLast30Days = GetTrend(1010),
                LongDescription = "The Nintendo Switch is a hybrid console you can play at home on your TV or on the go in handheld mode.",
                Highlights = new List<Highlight>()
                {
                    new() { Text = "Hybrid home/portable gaming" },
                    new() { Text = "6.2-inch touchscreen" },
                    new() { Text = "Joy-Con detachable controllers" },
                    new() { Text = "Up to 9 hours battery life" },
                    new() { Text = "Multiplayer local and online" }
                },
                Specs = new List<TechSpec>()
                {
                    new() { Label = "Display",    Value = "6.2-inch LCD touchscreen" },
                    new() { Label = "Resolution", Value = "1280 x 720 (handheld)" },
                    new() { Label = "Processor",  Value = "NVIDIA Custom Tegra" },
                    new() { Label = "Storage",    Value = "32 GB internal" },
                    new() { Label = "Battery",    Value = "4.5-9 hrs" },
                    new() { Label = "Connectivity", Value = "Wi-Fi, Bluetooth 4.1, USB-C" }
                },
                OriginalPrice = 349m, CostPrice = 210m
            }
        };
    }
}