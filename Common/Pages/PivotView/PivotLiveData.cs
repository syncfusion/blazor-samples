#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
namespace BlazorDemos.Pages.PivotView.PivotTable
{
    public class PivotLiveData
    {
        public string Category { get; set; }
        public string Type { get; set; }
        public double Spread { get; set; }
        public double OpenPrice { get; set; }
        public double Price { get; set; }
        public double Buy { get; set; }
        public double Sell { get; set; }
        public double Change { get; set; }
        public double Change_Percentage { get; set; }
        public double Volume { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }

        public static List<PivotLiveData> GetPivotLiveData()
        {
            List<PivotLiveData> PivotLiveData = new List<PivotLiveData>
            {
                new PivotLiveData
                {
                    Category = "Agriculture",
                    Type = "Corn",
                    Spread = 0.01,
                    OpenPrice = 379.50,
                    Price = 379.8026,
                    Buy = 379.7976,
                    Sell = 379.8076,
                    Change = 0.3026,
                    Change_Percentage = 0.0797,
                    Volume = 11266
                },
                new PivotLiveData
                {
                    Category = "Agriculture",
                    Type = "Rice",
                    Spread = 0.01,
                    OpenPrice = 11.245,
                    Price = 10.4154,
                    Buy = 10.4104,
                    Sell = 10.4204,
                    Change = -0.8296,
                    Change_Percentage = -7.3779,
                    Volume = 220
                },
                new PivotLiveData
                {
                    Category = "Agriculture",
                    Type = "Wheat",
                    Spread = 0.01,
                    OpenPrice = 465.50,
                    Price = 465.52,
                    Buy = 465.50,
                    Sell = 465.50,
                    Change = 0.02,
                    Change_Percentage = 0.0043,
                    Volume = 4318
                },
                new PivotLiveData
                {
                    Category = "Agriculture",
                    Type = "Soybean",
                    Spread = 0.01,
                    OpenPrice = 1038.00,
                    Price = 1038.6171,
                    Buy = 1038.6121,
                    Sell = 1038.6221,
                    Change = 0.6171,
                    Change_Percentage = 0.0595,
                    Volume = 20356
                },
                new PivotLiveData
                {
                    Category = "Agriculture",
                    Type = "Coffee",
                    Spread = 0.01,
                    OpenPrice = 125.70,
                    Price = 125.69,
                    Buy = 125.70,
                    Sell = 125.70,
                    Change = -0.01,
                    Change_Percentage = -0.008,
                    Volume = 1654
                },
                new PivotLiveData
                {
                    Category = "Agriculture",
                    Type = "Cocoa",
                    Spread = 0.01,
                    OpenPrice = 376.00,
                    Price = 376.03,
                    Buy = 376.00,
                    Sell = 376.00,
                    Change = 0.03,
                    Change_Percentage = 0.001,
                    Volume = 978
                },                
          };
            return PivotLiveData;
        }
    }
}
