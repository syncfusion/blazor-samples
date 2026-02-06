#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
namespace blazor_orderpagedata
{
   public class OrderPage
    {
        public OrderPage()
        {

        }
        public OrderPage(int OrderID, string CustomerId, double Freight, string ShipCountry, DateTime OrderDate)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerId;
            this.Freight = Freight;
            this.ShipCountry = ShipCountry;
            this.OrderDate = OrderDate;
        }

        public static List<OrderPage> GetAllRecords()
        {
            List<OrderPage> students = new List<OrderPage>();
            int Code = 0;
            for (int i = 1; i <= 20; i++)
            {
                students.Add(new OrderPage(Code + 1, "ALFKI", Math.Round((2.3 * i), 2) , "Denmark", new DateTime(1991, 05, 15)));
                students.Add(new OrderPage(Code + 2, "ANATR", Math.Round((3.3 * i), 2) , "Germany", new DateTime(1990, 04, 04)));
                students.Add(new OrderPage(Code + 3, "ANTON", Math.Round((4.3 * i), 2) , "Austria", new DateTime(1957, 11, 30)));
                students.Add(new OrderPage(Code + 4, "BLONP", Math.Round((5.3 * i), 2) , "Brazil", new DateTime(1930, 10, 22)));
                students.Add(new OrderPage(Code + 5, "BOLID", Math.Round((6.3 * i), 2) , "Switzerland", new DateTime(1953, 02, 18)));
                Code += 5;
            }
            return students;
        }

        public int? OrderID { get; set; }
        public string? CustomerID { get; set; }
        public double? Freight { get; set; }
        public string? ShipCountry { get; set; }
        public DateTime? OrderDate { get; set; }
    }

}
