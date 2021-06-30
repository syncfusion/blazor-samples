using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace ej2_blazor_virtualdata
{
    public class PivotVirtualData
    {
        public string ProductID { get; set; }
        public string Year { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public  double Sold { get; set; }

        public static List<PivotVirtualData> GetVirtualData()
        {
            List<PivotVirtualData> VirtualData = new List<PivotVirtualData>();

            for (int i = 1; i <= 100000; i++)
            {
                PivotVirtualData p = new PivotVirtualData
                {
                    ProductID = "PRO-" +(10000+i),
                    Year = (new string[] { "FY 2015", "FY 2016", "FY 2017", "FY 2018", "FY 2019" })[new Random().Next(5)],
                    Country = "USA",
                    City = "New York",
                    Price = (3.4*i)+500,
                    Sold = (i*15)+10
                    //date = Convert.ToDateTime("2013/01/06")
                };
                VirtualData.Add(p);
            }
            return VirtualData;
        }
    }
}