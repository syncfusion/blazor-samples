#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

namespace blazor_orderdata
{   
  public class OrderData {
        public OrderData()
        {

        }
        public OrderData(int OrderID, string CustomerId, double Freight, DateTime OrderDate, string ShipCountry, bool Verified)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerId;            
            this.Freight = Freight;            
            this.OrderDate = OrderDate;           
            this.ShipCountry = ShipCountry;
            this.Verified = Verified;

        }

        public static List<OrderData> GetAllRecords()
        {
            List<OrderData> order = new List<OrderData>();
            int code = 10000;
            string[] customerID = new string[] { "VINET", "TOMSP", "HANAR", "VICTE", "SUPRD", "CHOPS", "RICSU", "WELLI", "HILAA", "ERNSH", "CENTC", "OTTIK", "QUEDE", "RATTC", "FOLKO", "BLONP", "WARTH", "FRANK", "GROSR", "WHITC", "SPLIR", "QUICK", "MAGAA", "TORTU", "MORGK", "BERGS", "LEHMS", "ROMEY", "LILAS", "RICAR", "REGGC", "BSBEV", "COMMI", "TRADH", "HUNGO", "WANDK", "GODOS", "OLDWO", "LONEP", "ANATR", "THEBI", "DUMON", "ISLAT", "PERIC", "KOENE", "SAVEA", "BOLID", "FURIB", "BONAP", "MEREP", "PRINI", "SIMOB", "FAMIA", "LAMAI", "PICCO", "AROUT", "SEVES", "DRACD", "EASTC", "ANTON", "GALED", "VAFFE", "QUEEN", "WOLZA", "HUNGC", "SANTG", "BOTTM", "LINOD", "FOLIG", "OCEAN", "FRANS", "GOURL", "CONSH", "RANCH", "LAZYK", "LAUGB", "BLAUS", "NORTS", "CACTU", "GREAL", "MAISD", "TRAIH", "LETSS", "WILMK", "THECR", "ALFKI", "FRANR", "SPECD", "LACOR" };
            string[] shipCountry = new string[] { "France", "Germany", "Brazil", "Belgium", "Switzerland", "Venezuela", "Austria", "Mexico", "USA", "Sweden", "Finland", "Italy", "Spain", "UK", "Ireland", "Portugal", "Canada", "Denmark", "Poland", "Norway", "Argentina" };
            DateTime[] OrderDate = { new DateTime(2023, 8, 1), new DateTime(2023, 8, 5), new DateTime(2023, 8, 10), new DateTime(2023, 8, 15), new DateTime(2023, 8, 20) };
            int i = 0; int k = 0; int j = 0;
            for (int x = 0; x < 850; x++)
            {
                i = i >= customerID.Length ? 0 : i;
                k = k >= shipCountry.Length ? 0 : k;
                j = j >= OrderDate.Length ? 0 : j;
                order.Add(new OrderData()
                {
                    OrderID = code + x,
                    CustomerID = customerID[i],
                    Freight = Math.Round((2.3 * x), 2),
                    OrderDate = OrderDate[j],
                    ShipCountry = shipCountry[k],
                    Verified = x % 2 == 0 ? true : false
                });
                i++; k++; j++;
            }
            return order;
        }
        public int? OrderID { get; set; }
        public string? CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? ShipCountry { get; set; }
        public double? Freight { get; set; }
        public bool Verified { get; set; }
    }
}