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
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.Buttons
    {
    public class OrderDetails
        {
        public OrderDetails()
            {

            }
        public OrderDetails(int OrderID, string CustomerId, double Freight, string ShipCountry)
            {
            this.OrderID = OrderID;
            this.CustomerID = CustomerId;
            this.Freight = Freight;
            this.ShipCountry = ShipCountry;
            }
        public static List<OrderDetails> GetAllRecords()
            {
            List<OrderDetails> order = new List<OrderDetails>();
            for (int i = 1; i < 3; i++)
                {
                order.Add(new OrderDetails(10248, "VINET", 32.38, "France"));
                order.Add(new OrderDetails(10249, "TOMSP", 11.61, "Germany"));
                order.Add(new OrderDetails(10250, "HANAR", 65.83, "Brazil"));
                order.Add(new OrderDetails(10251, "VICTE", 41.34, "France"));
                order.Add(new OrderDetails(10252, "SUPRD", 51.3, "Belgium"));
                order.Add(new OrderDetails(10253, "HANAR", 58.17, "Brazil"));
                }
            return order;
            }

        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public double? Freight { get; set; }
        public string ShipCountry { get; set; }
        }
    }