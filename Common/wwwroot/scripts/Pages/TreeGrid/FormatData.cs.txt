#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace ej2_blazor_formatdata
{
    public class TreeDataFormat
    {
        public TreeDataFormat() { }
        public int? OrderID { get; set; }
        public string OrderName { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public double Units { get; set; }
        public double Price { get; set; }
        public double UnitPrice { get; set; }
        public string Category { get; set; }
        public int? ParentID { get; set; }
        public static List<TreeDataFormat> GetDataFormat()
        {
            List<TreeDataFormat> data = new List<TreeDataFormat>()
            {
                new TreeDataFormat()
                {
                    OrderID= 1,
                    OrderName= "Order 1",
                    OrderDate= new DateTime(2021, 03, 02),
                    ShippedDate= new DateTime(2023, 10, 09),
                    Units= 1395,
                    UnitPrice= 47,
                    Price=133.66,
                    Category= "Seafood",
                    ParentID = null
                },
                new TreeDataFormat() {
                    OrderID = 11,
                    OrderName = "Mackerel",
                    Category = "Frozen seafood",
                    Units = 23,
                    OrderDate= new DateTime(2021, 03, 02),
                    ShippedDate = new DateTime(2023, 05, 13),
                    UnitPrice = 12,
                    Price = 28.20,
                    ParentID = 1
                },
                new TreeDataFormat() {
                    OrderID = 12,
                    OrderName = "Mackerel",
                    Category = "Frozen seafood",
                    Units = 23,
                    OrderDate= new DateTime(2021, 03, 05),
                    ShippedDate = new DateTime(2023, 05, 22),
                    UnitPrice = 11,
                    Price = 25.92,
                    ParentID = 1 },
                new TreeDataFormat() {
                    OrderID = 13,
                    OrderName = "Mackerel",
                    Category = "Frozen seafood",
                    Units = 23,
                    OrderDate= new DateTime(2021, 03, 10),
                    ShippedDate = new DateTime(2023, 10, 14),
                    UnitPrice = 8,
                    Price = 52.68,
                    ParentID = 1 },
                new TreeDataFormat()
                {
                    OrderID = 14,
                    OrderName = "Mackerel",
                    Category = "Edible",
                    Units = 23,
                    OrderDate= new DateTime(2021, 03, 08),
                    ShippedDate = new DateTime(2023, 08, 03),
                    UnitPrice = 9,
                    Price = 11.25,
                    ParentID = 1
                },
                new TreeDataFormat()
                {
                    OrderID = 15,
                    OrderName = "Mackerel",
                    Category = "Edible",
                    Units = 23,
                    OrderDate= new DateTime(2021, 03, 09),
                    ShippedDate = new DateTime(2023, 03, 09),
                    UnitPrice = 7, Price= 15.61,
                    ParentID = 1
                },
                new TreeDataFormat()
                {
                    OrderID= 2,
                    OrderName= "Order 2",
                    OrderDate= new DateTime(2021, 03, 05),
                    ShippedDate= new DateTime(2023, 05, 03),
                    Units= 1944,
                    UnitPrice= 58,
                    Price=212.33,
                    Category= "Seafood",
                    ParentID = null

                },
                 new TreeDataFormat()
                 {
                     OrderID = 16,
                     OrderName = "Tilapias",
                     Category = "Frozen seafood",
                     Units = 278,
                     OrderDate= new DateTime(2021, 03, 05),
                     ShippedDate = new DateTime(2023, 03, 15),
                     UnitPrice = 15,
                     Price = 55.50,
                     ParentID = 2
                 },
                 new TreeDataFormat()
                 {
                     OrderID = 17,
                     OrderName = "White Shrimp",
                     Category = "Frozen seafood",
                     Units = 560,
                     OrderDate= new DateTime(2021, 05, 07),
                     ShippedDate = new DateTime(2023, 09, 19),
                     UnitPrice = 7,
                     Price = 41.70,
                     ParentID = 2
                 },
                 new TreeDataFormat()
                 {
                     OrderID = 18,
                     OrderName = "Fresh Cheese",
                     Category = "Dairy",
                     Units = 323,
                     OrderDate= new DateTime(2021, 03, 09),
                     ShippedDate = new DateTime(2023, 11, 13),
                     UnitPrice = 8,
                     Price = 39.20,
                     ParentID = 2
                 },
                 new TreeDataFormat()
                 {
                     OrderID = 19,
                     OrderName = "Blue Veined Cheese",
                     Category = "Dairy",
                     Units = 373,
                     OrderDate= new DateTime(2021, 03, 11),
                     ShippedDate = new DateTime(2023, 11, 13),
                     UnitPrice = 9,
                     Price = 38.76,
                     ParentID = 2
                 },
                 new TreeDataFormat()
                 {
                     OrderID = 20,
                     OrderName = "Butter",
                     Category = "Dairy",
                     Units = 413,
                     OrderDate= new DateTime(2021, 12, 23),
                     ShippedDate = new DateTime(2023, 12, 23),
                     UnitPrice = 7,
                     Price = 37.17,
                     ParentID = 2
                 },
                new TreeDataFormat()
                {
                    OrderID= 3,
                    OrderName= "Order 3",
                    OrderDate= new DateTime(2021, 03, 10),
                    ShippedDate= new DateTime(2023, 05, 20),
                    Units = 1120,
                    UnitPrice = 33,
                    Price = 108.80,
                    Category= "Seafood",
                    ParentID = null
                },
                new TreeDataFormat()
                {
                    OrderID = 21,
                    OrderName = "Lead glassware",
                    Category = "Solid crystals",
                    Units = 542,
                    OrderDate= new DateTime(2021, 03, 05),
                    ShippedDate = new DateTime(2023, 03, 15),
                    UnitPrice = 6,
                    Price = 32.52,
                    ParentID = 3
                },
                new TreeDataFormat()
                {
                    OrderID = 22,
                    OrderName = "Glassware",
                    Category = "Solid crystals",
                    Units = 324,
                    OrderDate= new DateTime(2021, 05, 07),
                    ShippedDate = new DateTime(2023, 09, 19),
                    UnitPrice = 11,
                    Price = 35.64,
                    ParentID = 3
                },
                new TreeDataFormat()
                {
                    OrderID = 23,
                    OrderName = "Glass Beads",
                    Category = "Solid crystals",
                    Units = 254,
                    OrderDate= new DateTime(2021, 03, 09),
                    ShippedDate = new DateTime(2023, 11, 13),
                    UnitPrice = 16,
                    Price = 40.64
                },
            };
            return data;
        }
    }
}
