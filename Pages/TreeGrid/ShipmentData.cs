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
                OrderDate = new DateTime(2017, 3, 2),
                ShippedDate = new DateTime(2017, 9, 2),
                ShipmentCategory = "Seafood",
                ParentID = null
            });

            DataCollection.Add(new ShipmentData()
            {
                ID = 11,
                Name = "Mackerel",
                Category = "Frozen Seafood",
                Units = 235,
                UnitPrice = 12,
                Price = 2820,
                OrderDate = new DateTime(2017, 3, 3),
                ShippedDate = new DateTime(2017, 10, 3),
                ShipmentCategory = "Frozen Seafood",
                ParentID = 1
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 12,
                Name = "Yellowfin Tuna",
                Category = "Frozen Seafood",
                Units = 324,
                UnitPrice = 8,
                Price = 2592,
                OrderDate = new DateTime(2017, 3, 5),
                ShippedDate = new DateTime(2017, 10, 5),
                ShipmentCategory = "Frozen Seafood"
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 13,
                Name = "Herrings",
                Category = "Frozen Seafood",
                Units = 488,
                UnitPrice = 11,
                Price = 5368,
                OrderDate = new DateTime(2017, 8, 5),
                ShippedDate = new DateTime(2017, 5, 15),
                ShipmentCategory = "Frozen Seafood",
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
                OrderDate = new DateTime(2017, 6, 10),
                ShippedDate = new DateTime(2017, 6, 17),
                ShipmentCategory = "Edible",
                ParentID = 1
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 15,
                Name = " Sweet corn Frozen ",
                Category = "Edible",
                Units = 223,
                UnitPrice = 7,
                Price = 1561,
                OrderDate = new DateTime(2017, 7, 12),
                ShippedDate = new DateTime(2017, 7, 19),
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
                OrderDate = new DateTime(2017, 1, 10),
                ShippedDate = new DateTime(2017, 1, 16),
                ShipmentCategory = "Seafood",
                ParentID = null
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 21,
                Name = "Tilapias",
                Category = "Frozen Seafood",
                Units = 278,
                UnitPrice = 15,
                Price = 4170,
                OrderDate = new DateTime(2017, 2, 5),
                ShippedDate = new DateTime(2017, 2, 12),
                ShipmentCategory = "Frozen Seafood",
                ParentID = 2
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 22,
                Name = "White Shrimp",
                Category = "Frozen Seafood",
                Units = 560,
                UnitPrice = 7,
                Price = 3920,
                OrderDate = new DateTime(2017, 5, 22),
                ShippedDate = new DateTime(2017, 5, 29),
                ShipmentCategory = "Frozen Seafood",
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
                OrderDate = new DateTime(2017, 6, 8),
                ShippedDate = new DateTime(2017, 6, 15),
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
                OrderDate = new DateTime(2017, 7, 10),
                ShippedDate = new DateTime(2017, 7, 17),
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
                OrderDate = new DateTime(2017, 9, 18),
                ShippedDate = new DateTime(2017, 9, 25),
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
                OrderDate = new DateTime(2017, 9, 10),
                ShippedDate = new DateTime(2017, 9, 20),
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
                OrderDate = new DateTime(2017, 2, 7),
                ShippedDate = new DateTime(2017, 2, 14),
                ShipmentCategory = "Solid crystals",
                ParentID = 3
            });
            DataCollection.Add(new ShipmentData()
            {
                ID = 32,
                Name = "Pharmaceutical Glass",
                Category = "Solid crystals",
                Units = 324,
                UnitPrice = 11,
                Price = 3564,
                OrderDate = new DateTime(2017, 4, 19),
                ShippedDate = new DateTime(2017, 4, 26),
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
                OrderDate = new DateTime(2017, 5, 22),
                ShippedDate = new DateTime(2017, 3, 22),
                ShipmentCategory = "Solid crystals",
                ParentID = 3
            });
            return DataCollection;
        }
    }
}
