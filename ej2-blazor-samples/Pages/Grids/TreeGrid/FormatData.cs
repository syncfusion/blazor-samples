using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_formatdata
{
    public class TreeDataFormat
    {
        public TreeDataFormat() { }
        public string orderID { get; set; }
        public string orderName { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime shippedDate { get; set; }
        public int units { get; set; }
        public double price { get; set; }
        public int unitPrice { get; set; }
        public string category { get; set; }
        public List<TreeDataFormat> subTasks { get; set; }
        public static List<TreeDataFormat> GetDataFormat()
        {
            List<TreeDataFormat> data = new List<TreeDataFormat>()
            {
                new TreeDataFormat()
                {
                    orderID= "1",
                    orderName= "Order 1",
                    orderDate= new DateTime(2017, 03, 02),
                    shippedDate= new DateTime(2019, 10, 09),
                    units= 1395,
                    unitPrice= 47,
                    price=133.66,
                    category= "Seafood",
                    subTasks= new List<TreeDataFormat>() {
                        new TreeDataFormat() { orderID= "1.1", orderName= "Mackerel", category= "Frozen seafood", units= 23,
                            orderDate= new DateTime(2017, 03, 02), shippedDate= new DateTime(2019, 05, 13), unitPrice= 12, price= 28.20 },
                        new TreeDataFormat() { orderID= "1.2", orderName= "Mackerel", category= "Frozen seafood", units= 23,
                            orderDate= new DateTime(2017, 03, 05), shippedDate= new DateTime(2019, 05, 22), unitPrice= 11, price= 25.92 },
                        new TreeDataFormat() { orderID= "1.3", orderName= "Mackerel", category= "Frozen seafood", units= 23,
                            orderDate= new DateTime(2017, 03, 10), shippedDate= new DateTime(2019, 10, 14), unitPrice= 8, price= 52.68 },
                        new TreeDataFormat() { orderID= "1.4", orderName= "Mackerel", category= "Edible", units= 23,
                            orderDate= new DateTime(2017, 03, 08), shippedDate= new DateTime(2019, 08, 03), unitPrice= 9, price= 11.25 },
                        new TreeDataFormat() { orderID= "1.5", orderName= "Mackerel", category= "Edible", units= 23,
                            orderDate= new DateTime(2017, 03, 09), shippedDate= new DateTime(2019, 03, 09), unitPrice= 7, price= 15.61 }
                    }
                },
                new TreeDataFormat()
                {
                    orderID= "2",
                    orderName= "Order 2",
                    orderDate= new DateTime(2017, 03, 05),
                    shippedDate= new DateTime(2019, 05, 03),
                    units= 1944,
                    unitPrice= 58,
                    price=212.33,
                    category= "Seafood",
                    subTasks= new List<TreeDataFormat>() {
                        new TreeDataFormat() { orderID= "2.1", orderName= "Tilapias", category= "Frozen seafood", units= 278,
                            orderDate= new DateTime(2017, 03, 05), shippedDate= new DateTime(2019, 03, 15), unitPrice= 15, price= 55.50 },
                        new TreeDataFormat() { orderID= "2.2", orderName= "White Shrimp", category= "Frozen seafood", units= 560,
                            orderDate= new DateTime(2017, 05, 07), shippedDate= new DateTime(2019, 09, 19), unitPrice= 7, price= 41.70 },
                        new TreeDataFormat() { orderID= "2.3", orderName= "Fresh Cheese", category= "Dairy", units= 323,
                            orderDate= new DateTime(2017, 03, 09), shippedDate= new DateTime(2019, 11, 13), unitPrice= 8, price= 39.20 },
                        new TreeDataFormat() { orderID= "2.4", orderName= "Blue Veined Cheese", category= "Dairy", units= 373,
                            orderDate= new DateTime(2017, 03, 11), shippedDate= new DateTime(2019, 11, 13), unitPrice= 9, price= 38.76 },
                        new TreeDataFormat() { orderID= "2.5", orderName= "Butter", category= "Dairy", units= 413,
                            orderDate= new DateTime(2017, 12, 23), shippedDate= new DateTime(2019, 12, 23), unitPrice= 7, price= 37.17 }
                    }
                },
                new TreeDataFormat()
                {
                    orderID= "3",
                    orderName= "Order 3",
                    orderDate= new DateTime(2017, 03, 10),
                    shippedDate= new DateTime(2019, 05, 20),
                    units = 1120,
                    unitPrice = 33,
                    price = 108.80,
                    category= "Seafood",
                    subTasks= new List<TreeDataFormat>() {
                        new TreeDataFormat() { orderID= "2.1", orderName= "Lead glassware", category= "Solid crystals", units= 542,
                            orderDate= new DateTime(2017, 03, 05), shippedDate= new DateTime(2019, 03, 15), unitPrice= 6, price= 32.52 },
                        new TreeDataFormat() { orderID= "2.2", orderName= "Glassware", category= "Solid crystals", units= 324,
                            orderDate= new DateTime(2017, 05, 07), shippedDate= new DateTime(2019, 09, 19), unitPrice= 11, price= 35.64 },
                        new TreeDataFormat() { orderID= "2.3", orderName= "Glass beads", category= "Solid crystals", units= 254,
                            orderDate= new DateTime(2017, 03, 09), shippedDate= new DateTime(2019, 11, 13), unitPrice= 16, price= 40.64 },
                        }
                }
            };
            return data;
        }
    }
}
