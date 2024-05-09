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
using System.Threading.Tasks;

namespace ej2_blazor_summarydata
{
    public class SummaryRowData
    {
        public int ID { get; set; }
        public string FreightID { get; set; }
        public string FreightName { get; set; }
        public int TotalUnits { get; set; }
        public int TotalCosts { get; set; }
        public int UnitWeight { get; set; }
        public int? ParentID { get; set; }

        public static List<SummaryRowData> GetSummaryData()
        {
            List<SummaryRowData> DataCollection = new List<SummaryRowData>();

            DataCollection.Add(new SummaryRowData
            { 
                ID = 1,
                FreightID = "CX2389NK",
                FreightName ="Maersk Edibles Co.",
                TotalUnits = 59,
                TotalCosts = 278,
                UnitWeight = 241,
                ParentID = null
            });

            DataCollection.Add(new SummaryRowData
            {
                ID = 11,
                FreightID = "QW4567OP",
                FreightName = "Maersk Edibles Co.",
                TotalUnits = 12,
                TotalCosts = 140,
                UnitWeight = 50,
                ParentID = 1
            });

            DataCollection.Add(new SummaryRowData
            {
                ID = 12,
                FreightID = "QW3458BH",
                FreightName = "Aniseed Syrup",
                TotalUnits = 89,
                TotalCosts = 590,
                UnitWeight = 87,
                ParentID = 1
            });

            DataCollection.Add(new SummaryRowData
            {
                ID = 13,
                FreightID = "QW8967OH",
                FreightName = "Chef Anton",
                TotalUnits = 46,
                TotalCosts = 460,
                UnitWeight = 54,
                ParentID = 1
            });
            DataCollection.Add(new SummaryRowData
            {
                ID = 14,
                FreightID = "QW6549NJ",
                FreightName = "Chef Anton's Gumbo Mix",
                TotalUnits = 34,
                TotalCosts = 590,
                UnitWeight = 50,
                ParentID =1
            });
            DataCollection.Add(new SummaryRowData
            {
                ID = 2,
                FreightID = "DW8954IO",
                FreightName = "Aeon fitness inc.",
                TotalUnits = 172,
                TotalCosts = 24,
                UnitWeight = 296,
                ParentID = null
            });
            DataCollection.Add(new SummaryRowData
            {
                ID = 21,
                FreightID = "UF5647YH",
                FreightName = "Reebok CrossFit Back Bay",
                TotalUnits = 60,
                TotalCosts = 870,
                UnitWeight = 73,
                ParentID =2
            });
            DataCollection.Add(new SummaryRowData
            {
                ID = 22,
                FreightID = "UF1290LK",
                FreightName = "The Green Microgym",
                TotalUnits = 56,
                TotalCosts = 876,
                UnitWeight = 90,
                ParentID = 2
            });

            DataCollection.Add(new SummaryRowData
            {
                ID = 23,
                FreightID = "UF8956KU",
                FreightName = "DeFranco",
                TotalUnits = 45,
                TotalCosts = 458,
                UnitWeight = 68,
                ParentID = 2
            });

            DataCollection.Add(new SummaryRowData
            {
                ID = 24,
                FreightID = "UF7464JK",
                FreightName = "Westside Barbell",
                TotalUnits = 25,
                TotalCosts = 231,
                UnitWeight = 65,
                ParentID =2
            });

            DataCollection.Add(new SummaryRowData
            {
                ID = 3,
                FreightID = "EJ9456KN",
                FreightName = "Sun technologies Inc.",
                TotalUnits = 33,
                TotalCosts = 229,
                UnitWeight = 192,
                ParentID = null
            });

            DataCollection.Add(new SummaryRowData
            {
                ID = 31,
                FreightID = "GH2367OP",
                FreightName = "Haier Group",
                TotalUnits = 78,
                TotalCosts = 678,
                UnitWeight = 23,
                ParentID = 3
            });

            DataCollection.Add(new SummaryRowData
            {
                ID = 32,
                FreightID = "GH4309TH",
                FreightName = "Panda Electronics",
                TotalUnits = 90,
                TotalCosts = 790,
                UnitWeight = 48,
                ParentID =3
            });

            DataCollection.Add(new SummaryRowData
            {
                ID = 33,
                FreightID = "GH3494SD",
                FreightName = "Jiangsu Etern",
                TotalUnits = 36,
                TotalCosts = 435,
                UnitWeight = 56,
                ParentID = 3
            });


            DataCollection.Add(new SummaryRowData
            {
                ID =34,
                FreightID = "GH3213FR",
                FreightName = "Zhejiang Fuchunjiang",
                TotalUnits = 12,
                TotalCosts = 278,
                UnitWeight = 65,
                ParentID = 3
            });

            return DataCollection;
        }
    }
}
