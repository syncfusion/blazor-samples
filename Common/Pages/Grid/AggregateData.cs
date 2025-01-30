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
namespace blazor_aggredateData
{
    public class AggregateData
    {
        public AggregateData()
        {

        }
        public AggregateData(int OrderID, string CustomerId, int EmployeeId, double Freight, DateTime OrderDate, string ShipCity, string ShipName, string ShipCountry, DateTime ShippedDate, string ShipAddress, double AdvanceAmount, double TotalAmount, long PhoneNumber)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerId;
            this.EmployeeID = EmployeeId;
            this.Freight = Freight;
            this.ShipCity = ShipCity;
            this.OrderDate = OrderDate;
            this.ShipName = ShipName;
            this.ShipCountry = ShipCountry;
            this.ShippedDate = ShippedDate;
            this.ShipAddress = ShipAddress;
            this.AdvanceAmount = AdvanceAmount;
            this.TotalAmount = TotalAmount;
            this.PhoneNumber = PhoneNumber;
        }
        public static List<AggregateData> GetData()
        {
            List<AggregateData> order = new List<AggregateData>();
            int code = 10000;
            for (int i = 1; i < 4; i++)
            {
                order.Add(new AggregateData(code + 1, "ALFKI", i + 0, Math.Round((2.3 * i), 2), new DateTime(1991, 05, 15), "Berlin", "Simons bistro", "Denmark", new DateTime(1996, 7, 16), "Kirchgasse 6", Math.Round((double)(20 * i), 2), Math.Round((double)(40 * i), 2), 9982223864));
                order.Add(new AggregateData(code + 2, "ANATR", i + 2, Math.Round((3.3 * i), 2), new DateTime(1990, 04, 04), "Madrid", "Queen Cozinha", "Brazil", new DateTime(1996, 9, 11), "Avda. Azteca 123", Math.Round((double)(30 * i), 2), Math.Round((double)(60 * i), 2), 9972236764));
                order.Add(new AggregateData(code + 3, "ANTON", i + 1, Math.Round((4.3 * i), 2), new DateTime(1957, 11, 30), "Cholchester", "Frankenversand", "Germany", new DateTime(1996, 10, 7), "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", Math.Round((double)(25 * i), 2), Math.Round((double)(50 * i), 2), 9922388124));
                order.Add(new AggregateData(code + 4, "BLONP", i + 3, Math.Round((5.3 * i), 2), new DateTime(1930, 10, 22), "Marseille", "Ernst Handel", "Austria", new DateTime(1996, 12, 30), "Magazinweg 7", Math.Round((double)(40 * i), 2), Math.Round((double)(80 * i), 2), 9922388904));
                order.Add(new AggregateData(code + 5, "BOLID", i + 4, Math.Round((6.3 * i), 2), new DateTime(1953, 02, 18), "Tsawassen", "Hanari Carnes", "Switzerland", new DateTime(1997, 12, 3), "1029 - 12th Ave. S.", Math.Round((double)(45 * i), 2), Math.Round((double)(90 * i), 2), 9922377644));
                code += 5;
            }
            return order;
        }

        public int? OrderID { get; set; }
        [Required(ErrorMessage = "Customer ID required")]
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public double? Freight { get; set; }
        public string ShipCity { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ShipName { get; set; }
        public string ShipCountry { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string ShipAddress { get; set; }
        public long PhoneNumber { get; set; }
        public double? AdvanceAmount { get; set; }
        public double? TotalAmount { get; set; }
    }
}
