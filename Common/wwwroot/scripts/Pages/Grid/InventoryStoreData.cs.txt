using System;
using System.Collections.Generic;
using System.Globalization;
namespace BlazorDemos.Pages.Grid
{

    public sealed class InventoryStoreRecord
    {
        public int ID { get; set; }
        public string Product { get; set; } = string.Empty;
        public string Category { get; set; } = "IT Asset";
        public int VendorA { get; set; }
        public int VendorB { get; set; }
        public int VendorC { get; set; }
        public int VendorD { get; set; }
        public int TotalVendorUnits => VendorA + VendorB + VendorC + VendorD;
        public double UnitPrice { get; set; }
    }


    public static class InventoryStoreData
    {
     
        public static IReadOnlyList<InventoryStoreRecord> GetAllRecords()
        {
            var records = new List<InventoryStoreRecord>
            {
                new() { ID = 1001, Product = "MacBook Pro",        Category = "IT Asset",          VendorA = 55,  VendorB = 40,  VendorC = 60,  VendorD = 35,  UnitPrice = 1200.00 },
                new() { ID = 1002, Product = "Wireless Mouse",     Category = "IT Asset",          VendorA = 120, VendorB = 95,  VendorC = 110, VendorD = 80,  UnitPrice = 25.00 },
                new() { ID = 1003, Product = "4K Monitor",         Category = "IT Asset",          VendorA = 45,  VendorB = 50,  VendorC = 38,  VendorD = 42,  UnitPrice = 400.00 },
                new() { ID = 1004, Product = "WiFi Router",        Category = "IT Infrastructure", VendorA = 75,  VendorB = 68,  VendorC = 80,  VendorD = 72,  UnitPrice = 120.00 },
                new() { ID = 1005, Product = "SSD Drive",          Category = "IT Asset",          VendorA = 110, VendorB = 90,  VendorC = 105, VendorD = 88,  UnitPrice = 150.00 },
                new() { ID = 1006, Product = "Network Switch",     Category = "IT Infrastructure", VendorA = 30,  VendorB = 25,  VendorC = 40,  VendorD = 28,  UnitPrice = 220.00 },
                new() { ID = 1007, Product = "Laser Printer",      Category = "Admin",             VendorA = 18,  VendorB = 22,  VendorC = 15,  VendorD = 20,  UnitPrice = 500.00 },
                new() { ID = 1008, Product = "Conference Camera",  Category = "Security",          VendorA = 60,  VendorB = 55,  VendorC = 48,  VendorD = 52,  UnitPrice = 350.00 },
                new() { ID = 1009, Product = "Smart Door Lock",    Category = "Facilities",        VendorA = 40,  VendorB = 35,  VendorC = 32,  VendorD = 38,  UnitPrice = 180.00 },
                new() { ID = 1010, Product = "Biometric Scanner",  Category = "Security",          VendorA = 22,  VendorB = 18,  VendorC = 25,  VendorD = 20,  UnitPrice = 275.00 },
                new() { ID = 1011, Product = "POS Terminal",       Category = "Finance",           VendorA = 85,  VendorB = 78,  VendorC = 82,  VendorD = 80,  UnitPrice = 450.00 },
                new() { ID = 1012, Product = "Cash Drawer",        Category = "Finance",           VendorA = 50,  VendorB = 45,  VendorC = 48,  VendorD = 42,  UnitPrice = 95.00 },
                new() { ID = 1013, Product = "Barcode Scanner",    Category = "Sales",             VendorA = 95,  VendorB = 88,  VendorC = 90,  VendorD = 85,  UnitPrice = 110.00 },
                new() { ID = 1014, Product = "Label Printer",      Category = "Marketing",         VendorA = 28,  VendorB = 24,  VendorC = 30,  VendorD = 26,  UnitPrice = 320.00 },
                new() { ID = 1015, Product = "Projector",          Category = "Training",          VendorA = 16,  VendorB = 14,  VendorC = 18,  VendorD = 15,  UnitPrice = 600.00 },
                new() { ID = 1016, Product = "Interactive Display", Category = "Training",          VendorA = 12,  VendorB = 10,  VendorC = 14,  VendorD = 11,  UnitPrice = 1500.00 },
                new() { ID = 1017, Product = "Headset",            Category = "IT Asset",          VendorA = 140, VendorB = 120, VendorC = 135, VendorD = 115, UnitPrice = 55.00 },
                new() { ID = 1018, Product = "Webcam",             Category = "IT Asset",          VendorA = 70,  VendorB = 62,  VendorC = 68,  VendorD = 65,  UnitPrice = 75.00 },
                new() { ID = 1019, Product = "USB-C Hub",          Category = "IT Asset",          VendorA = 88,  VendorB = 80,  VendorC = 92,  VendorD = 82,  UnitPrice = 45.00 },
                new() { ID = 1020, Product = "External SSD",       Category = "IT Asset",          VendorA = 65,  VendorB = 58,  VendorC = 70,  VendorD = 60,  UnitPrice = 180.00 },
                new() { ID = 1021, Product = "Cable Organizer Kit", Category = "Facilities",        VendorA = 200, VendorB = 180, VendorC = 195, VendorD = 175, UnitPrice = 18.00 },
                new() { ID = 1022, Product = "Office Chair",       Category = "Facilities",        VendorA = 42,  VendorB = 38,  VendorC = 45,  VendorD = 40,  UnitPrice = 280.00 },
                new() { ID = 1023, Product = "Standing Desk",      Category = "Facilities",        VendorA = 24,  VendorB = 20,  VendorC = 28,  VendorD = 22,  UnitPrice = 550.00 },
                new() { ID = 1024, Product = "Document Shredder",  Category = "Admin",             VendorA = 36,  VendorB = 32,  VendorC = 38,  VendorD = 34,  UnitPrice = 175.00 },
                new() { ID = 1025, Product = "Whiteboard",         Category = "Training",          VendorA = 48,  VendorB = 42,  VendorC = 50,  VendorD = 45,  UnitPrice = 130.00 },
                new() { ID = 1026, Product = "Surge Protector",    Category = "IT Infrastructure", VendorA = 95,  VendorB = 88,  VendorC = 92,  VendorD = 85,  UnitPrice = 35.00 },
                new() { ID = 1027, Product = "Desk Lamp",          Category = "Facilities",        VendorA = 60,  VendorB = 54,  VendorC = 62,  VendorD = 58,  UnitPrice = 65.00 },
                new() { ID = 1028, Product = "Power Bank",         Category = "Sales",             VendorA = 110, VendorB = 98,  VendorC = 105, VendorD = 95,  UnitPrice = 40.00 },
                new() { ID = 1029, Product = "Digital Signage",    Category = "Marketing",         VendorA = 14,  VendorB = 12,  VendorC = 16,  VendorD = 13,  UnitPrice = 850.00 }
            };

            return records;
        }
    }
}