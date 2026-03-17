#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;

namespace blazor_celldata
{ 
    public class CellData
    {
        public CellData(string Symbol, double Open, double High, double Low, double Change, double WH, double WL, double YearDays, double MonthlyDays)
        {
            this.Symbol = Symbol;
            this.Open = Open;
            this.High = High;
            this.Low = Low;
            this.Change = Change;
            this.WH = WH;
            this.WL = WL;
            this.YearDays = YearDays;
            this.MonthDays = MonthlyDays;

        }
        public static List<CellData> GetAllCellData()
        {
            List<CellData> Datas = new List<CellData>();
            {
                Datas.Add(new CellData("DDNDKJ", 6088.20, 6114.5, 6084.15, 12.5, 6114.55, 4770.35, 14.37, 9.87));
                Datas.Add(new CellData("FKLND", 2042.00, 2108.40, 2042.00, 77.8, 2108.40, 1526.40, 23.7, 10.55));
                Datas.Add(new CellData("DSNNS", 740, 772.3, 740, 26.6, 772.3, 496.4, 47.28, 23.20));
                Datas.Add(new CellData("MLSSD", 939.5, 958.2, 939.5, 22.1, 998.85, 553, 47.28, 9.87));
                Datas.Add(new CellData("LKSNDL", 4641.10, 4749.75, 4641.10, 99.25, 5050.00, 3432.40, 61.24, 11.63));
                Datas.Add(new CellData("NKJSN", 445, 451.9, 442, 6.95, 578.4, 370.8, 229.67, 4.45));
                Datas.Add(new CellData("LNKNDS", 298.5, 303.95, 298.5, 4.25, 386.25, 289.4, -9.42, 3.13));
                Datas.Add(new CellData("NSDN", 400, 403, 397.95, 4.0, 435, 300, -5.40, -1.52));
                Datas.Add(new CellData("SDMSMD", 162.75, 164.85, 162.4, 1.85, 207.95, 140.3, 23.21, 0.79));
                Datas.Add(new CellData("SMMSDS", 75.4, 76.45, 75.2, 0.75, 106.7, 58, -6, 11.78));
                Datas.Add(new CellData("MSMDM", 2291.00, 2315.10, 2291.00, 20.4, 2551.70, 1802.30, 28.37, 15.28));
                Datas.Add(new CellData("MLKSDM", 329.7, 329.7, 327.2, 2.65, 355, 227.4, 25.55, 14.38));
                Datas.Add(new CellData("BDSBD", 730.5, 736.75, 727.15, 5.55, 736.75, 524.1, 26.87, 8.65));
                Datas.Add(new CellData("SKJDB", 421.5, 424.9, 416, 295, 789.35, 3.15, 35.80, 15.32));
                Datas.Add(new CellData("BDSDH", 505, 509, 503, 3.35, 509.5, 279, -40.65, 13.13));
                Datas.Add(new CellData("DSJBD", 1730.00, 1739.95, 1721.20, 10.05, 1739.95, 1051.00, 61.28, 31.47));
                Datas.Add(new CellData("BSBDBD", 1161.00, 1172.00, 1161.00, 6.25, 1232.00, 767.4, 37.73, 23.04));
                Datas.Add(new CellData("BDBSJ", 770, 776, 768.65, 4.05, 920, 659.2, 49.90, 16.66));
                Datas.Add(new CellData("NSDJN", 106, 106.8, 105.35, 0.55, 137.1, 86.9, 2.89, 9.53));
                Datas.Add(new CellData("NDSS", 3000.30, 3040.00, 3000.30, 14.9, 3510.00, 2210.00, -9.36, 17.10));
                Datas.Add(new CellData("NKDN", 126, 128, 126, 0.6, 202.8, 121.85, 22.41, 10.60));
            }
            return Datas;
        }
        public string Symbol { get; set; }
        public double? Open { get; set; }
        public double? High { get; set; }
        public double? Low { get; set; }
        public double? Change { get; set; }
        public double? WH { get; set; }
        public double? WL { get; set; }
        public double? MonthDays { get; set; }
        public double? YearDays { get; set; }
    }
}
