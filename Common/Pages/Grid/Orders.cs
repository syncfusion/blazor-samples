#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BlazorDemos;
using System.ComponentModel.DataAnnotations;

namespace blazor_ordersdata
{   
    public class Orders
    {
        public Orders()
        {

        }
        public Orders(int OrderID, string CustomerId, int EmployeeId, double Freight, bool Verified, DateOnly OrderDate, TimeOnly OrderTime, string ShipCity, string ShipName, string ShipCountry, DateTime ShippedDate, string ShipAddress)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerId;
            this.EmployeeID = EmployeeId;
            this.Freight = Freight;
            this.ShipCity = ShipCity;
            this.Verified = Verified;
            this.OrderDate = OrderDate;
            this.OrderTime = OrderTime;
            this.ShipName = ShipName;
            this.ShipCountry = ShipCountry;
            this.ShippedDate = ShippedDate;
            this.ShipAddress = ShipAddress;
        }
        public static List<Orders> GetAllRecords()
        {
            List<Orders> orders = new List<Orders>();
            int code = 10000;
            for (int i = 1; i < 15; i++)
            {
                orders.Add(new Orders(code + 1, "ALFKI", i + 0, Math.Round((2.3 * i), 2) , false, new DateOnly(1991, 05, 15), new TimeOnly(10, 00, 00), "Berlin", "Simons bistro", "Denmark", new DateTime(1996, 7, 16), "Kirchgasse 6"));
                orders.Add(new Orders(code + 2, "ANATR", i + 2, Math.Round((3.3 * i), 2) , true, new DateOnly(1990, 04, 04), new TimeOnly(11, 30, 00), "Madrid", "Queen Cozinha", "Brazil", new DateTime(1996, 9, 11), "Avda. Azteca 123"));
                orders.Add(new Orders(code + 3, "ANTON", i + 1, Math.Round((4.3 * i), 2) , true, new DateOnly(1957, 11, 30), new TimeOnly(12, 00, 00), "Cholchester", "Frankenversand", "Germany", new DateTime(1996, 10, 7), "Carrera 52 con Ave. Bolívar #65-98 Llano Largo"));
                orders.Add(new Orders(code + 4, "BLONP", i + 3, Math.Round((5.3 * i), 2) , false, new DateOnly(1930, 10, 22), new TimeOnly(15, 30, 00), "Marseille", "Ernst Handel", "Austria", new DateTime(1996, 12, 30), "Magazinweg 7"));
                orders.Add(new Orders(code + 5, "BOLID", i + 4, Math.Round((6.3 * i), 2) , true, new DateOnly(1953, 02, 18), new TimeOnly(16, 30, 00), "Tsawassen", "Hanari Carnes", "Switzerland", new DateTime(1997, 12, 3), "1029 - 12th Ave. S."));
                code += 5;
            }
            return orders;
        }

        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public double? Freight { get; set; }
        public string ShipCity { get; set; }
        public bool Verified { get; set; }
        public DateOnly? OrderDate { get; set; }

        public TimeOnly? OrderTime { get; set; }

        public string ShipName { get; set; }

        public string ShipCountry { get; set; }

        public DateTime ShippedDate { get; set; }
        public string ShipAddress { get; set; }
    }
}