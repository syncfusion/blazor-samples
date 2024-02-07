#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ej2_blazor_shipmentdata
{
    public class ShipmentData
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public int Units { get; set; }
        public string Category { get; set; }
        public int UnitPrice { get; set; }
        public int Price { get; set; }
        public string ShipmentCategory { get; set; }
        public DateTime ShippedDate { get; set; }
        public DateTime OrderDate { get; set; }
        public int? ParentID { get; set; }

        public static List<ShipmentData> GetShipmentData()
        {
            List<ShipmentData> DataCollection = new List<ShipmentData>();

            DataCollection.Add(new ShipmentData()
            {
                ID = 1,
                Name = "Order 1",
                Category = "Seafood",
                Units = 1395,
                UnitPrice = 47,
                Price = 65565,
                OrderDate = new DateTime(2021, 3, 2),
                ShippedDate = new DateTime(2021, 9, 2),
                ShipmentCategory = "Seafood",
                ParentID = null
            });

            DataCollection.Add(new ShipmentData()
            {
                ID = 11,
                Name = "Mackerel",
                Category = "Frozen seafood",
                Units = 235,
                UnitPrice = 12,
                Price = 2820,
                OrderDate = new DateTime(2021, 3, 3),
                ShippedDate = new DateTime(2021, 10, 3),
                ShipmentCategory = "Frozen seafood",
                ParentID = 1
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 12,
                Name = "Yellowfin Tuna",
                Category = "Frozen seafood",
                Units = 324,
                UnitPrice = 8,
                Price = 2592,
                OrderDate = new DateTime(2021, 3, 5),
                ShippedDate = new DateTime(2021, 10, 5),
                ShipmentCategory = "Frozen seafood",
                ParentID = 3
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 13,
                Name = "Herrings",
                Category = "Frozen seafood",
                Units = 488,
                UnitPrice = 11,
                Price = 5368,
                OrderDate = new DateTime(2021, 8, 5),
                ShippedDate = new DateTime(2021, 5, 15),
                ShipmentCategory = "Frozen seafood",
                ParentID = 1
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 14,
                Name = "Preserved Olives",
                Category = "Edible",
                Units = 125,
                UnitPrice = 9,
                Price = 1125,
                OrderDate = new DateTime(2021, 6, 10),
                ShippedDate = new DateTime(2021, 6, 17),
                ShipmentCategory = "Edible",
                ParentID = 1
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 15,
                Name = "Sweet corn",
                Category = "Edible",
                Units = 223,
                UnitPrice = 7,
                Price = 1561,
                OrderDate = new DateTime(2021, 7, 12),
                ShippedDate = new DateTime(2021, 7, 19),
                ShipmentCategory = "Edible",
                ParentID = 1
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 2,
                Name = "Order 2",
                Category = "Products",
                Units = 1944,
                UnitPrice = 58,
                Price = 21233,
                OrderDate = new DateTime(2021, 1, 10),
                ShippedDate = new DateTime(2021, 1, 16),
                ShipmentCategory = "Seafood",
                ParentID = null
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 21,
                Name = "Tilapias",
                Category = "Frozen seafood",
                Units = 278,
                UnitPrice = 15,
                Price = 4170,
                OrderDate = new DateTime(2021, 2, 5),
                ShippedDate = new DateTime(2021, 2, 12),
                ShipmentCategory = "Frozen seafood",
                ParentID = 2
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 22,
                Name = "White Shrimp",
                Category = "Frozen seafood",
                Units = 560,
                UnitPrice = 7,
                Price = 3920,
                OrderDate = new DateTime(2021, 5, 22),
                ShippedDate = new DateTime(2021, 5, 29),
                ShipmentCategory = "Frozen seafood",
                ParentID = 2
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 23,
                Name = "Fresh Cheese",
                Category = "Dairy",
                Units = 323,
                UnitPrice = 12,
                Price = 3876,
                OrderDate = new DateTime(2021, 6, 8),
                ShippedDate = new DateTime(2021, 6, 15),
                ShipmentCategory = "Dairy",
                ParentID = 2
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 24,
                Name = "Blue Veined Cheese",
                Category = "Dairy",
                Units = 370,
                UnitPrice = 15,
                Price = 5550,
                OrderDate = new DateTime(2021, 7, 10),
                ShippedDate = new DateTime(2021, 7, 17),
                ShipmentCategory = "Dairy",
                ParentID = 2
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 25,
                Name = "Butter",
                Category = "Dairy",
                Units = 413,
                UnitPrice = 9,
                Price = 3717,
                OrderDate = new DateTime(2021, 9, 18),
                ShippedDate = new DateTime(2021, 9, 25),
                ShipmentCategory = "Dairy",
                ParentID = 2
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 3,
                Name = "Order 3",
                Category = "Crystals",
                Units = 1944,
                UnitPrice = 58,
                Price = 21233,
                OrderDate = new DateTime(2021, 9, 10),
                ShippedDate = new DateTime(2021, 9, 20),
                ShipmentCategory = "Seafood",
                ParentID = null
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 31,
                Name = "Lead glassware",
                Category = "Solid crystals",
                Units = 542,
                UnitPrice = 6,
                Price = 3252,
                OrderDate = new DateTime(2021, 2, 7),
                ShippedDate = new DateTime(2021, 2, 14),
                ShipmentCategory = "Solid crystals",
                ParentID = 3
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 32,
                Name = "Pharmaceutical glass",
                Category = "Solid crystals",
                Units = 324,
                UnitPrice = 11,
                Price = 3564,
                OrderDate = new DateTime(2021, 4, 19),
                ShippedDate = new DateTime(2021, 4, 26),
                ShipmentCategory = "Solid crystals",
                ParentID = 3
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 33,
                Name = "Glass beads",
                Category = "Solid crystals",
                Units = 254,
                UnitPrice = 16,
                Price = 4064,
                OrderDate = new DateTime(2021, 5, 22),
                ShippedDate = new DateTime(2021, 3, 22),
                ShipmentCategory = "Solid crystals",
                ParentID = 3
            });
            return DataCollection;
        }
    }
}
