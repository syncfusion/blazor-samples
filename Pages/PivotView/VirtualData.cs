using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_virtualdata
{
    public class VirtualData
    {
        public string id { get; set; }
        public string year { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public double amount { get; set; }
        public DateTime date { get; set; }

        public static List<VirtualData> GetVirtualData()
        {
            List<VirtualData> VirtualData = new List<VirtualData>();

            for (int i = 1; i <= 50000; i++)
            {
                VirtualData p = new VirtualData
                {
                    id = "PRO-" +(10000+i),
                    year = (new string[] { "FY 2015", "FY 2016", "FY 2017", "FY 2018", "FY 2019" })[new Random().Next(5)],
                    country = "USA",
                    city = "New York",
                    amount = (3.4*i)+500,
                    //date = Convert.ToDateTime("2013/01/06")
                };
                VirtualData.Add(p);
            }
            return VirtualData;
        }
    }
}