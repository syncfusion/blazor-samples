#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
namespace blazor_ordersdetails
{
    public class OrdersDetails
    {
        public OrdersDetails()
        {

        }
        public OrdersDetails(int OrderID, string CustomerId, int EmployeeId, double Freight, bool Verified, DateTime OrderDate, string ShipCity, string ShipName, string ShipCountry, DateTime ShippedDate, string ShipAddress, string Email)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerId;
            this.EmployeeID = EmployeeId;
            this.Freight = Freight;
            this.ShipCity = ShipCity;
            this.Verified = Verified;
            this.OrderDate = OrderDate;
            this.ShipName = ShipName;
            this.ShipCountry = ShipCountry;
            this.ShippedDate = ShippedDate;
            this.ShipAddress = ShipAddress;
            this.Email = Email;
        }

        public static List<OrdersDetails> GetAllRecords()
        {
            List<OrdersDetails> order = new List<OrdersDetails>();
            int code = 10000;
            for (int i = 1; i <= 15; i++)
            {
                order.Add(new OrdersDetails(code + 1, "ALFKI", i + 0, Math.Round((2.3 * i), 2), false, new DateTime(1991, 05, 15), "Berlin", "Simons bistro", "Denmark", new DateTime(1996, 7, 16), "Kirchgasse 6", "alfki@domain.com"));
                order.Add(new OrdersDetails(code + 2, "ANATR", i + 2, Math.Round((3.3 * i), 2), true, new DateTime(1990, 04, 04), "Madrid", "Queen Cozinha", "Brazil", new DateTime(1996, 9, 11), "Avda. Azteca 123", "anatr@domain.com"));
                order.Add(new OrdersDetails(code + 3, "ANTON", i + 1, Math.Round((4.3 * i), 2), false, new DateTime(1957, 11, 30), "Cholchester", "Frankenversand", "Germany", new DateTime(1996, 10, 7), "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "anton@domain.com"));
                order.Add(new OrdersDetails(code + 4, "BLONP", i + 3, Math.Round((5.3 * i), 2), true, new DateTime(1930, 10, 22), "Marseille", "Ernst Handel", "Austria", new DateTime(1996, 12, 30), "Magazinweg 7", "blonp@domain.com"));
                order.Add(new OrdersDetails(code + 5, "BOLID", i + 4, Math.Round((6.3 * i), 2), false, new DateTime(1953, 02, 18), "Tsawassen", "Hanari Carnes", "Switzerland", new DateTime(1997, 12, 3), "1029 - 12th Ave. S.", "bolid@domain.com"));
                code += 5;
            }
            return order;
        }

        public int? OrderID { get; set; }
        public string? CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public double? Freight { get; set; }
        public string? ShipCity { get; set; } 
        public bool Verified { get; set; }
        public DateTime? OrderDate { get; set; }

        public string? ShipName { get; set; }

        public string? ShipCountry { get; set; }

        public DateTime? ShippedDate { get; set; }
        public string? ShipAddress { get; set; }
        public string? Email { get; set; }
    }
}
