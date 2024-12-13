#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
namespace BlazorDemos.Pages.PivotView.PivotTable
{
    public class AggregateData
        {
            public int Id { get; set; }
            public string GroupDate { get; set; }
            public string Sector { get; set; }
            public string EnerType { get; set; }
            public string EneSource { get; set; }
            public int PowUnits { get; set; }
            public int ProCost { get; set; }
            public string Year { get; set; }
            public string Quarter { get; set; }
            public string HalfYear { get; set; }
        public static List<AggregateData> GetAggregateData()
        {
            List<AggregateData> aggData = new List<AggregateData>();
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 46,
                ProCost = 43
            });
            aggData.Add(new AggregateData
            {
                Id = 1002,
                GroupDate = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 30,
                ProCost = 29
            });
            aggData.Add(new AggregateData
            {
                Id = 1003,
                GroupDate = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 125,
                ProCost = 96
            });
            aggData.Add(new AggregateData
            {
                Id = 1004,
                GroupDate = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 215,
                ProCost = 123
            });
            aggData.Add(new AggregateData
            {
                Id = 1005,
                GroupDate = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 263,
                ProCost = 125
            });
            aggData.Add(new AggregateData
            {
                Id = 1006,
                GroupDate = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 61,
                ProCost = 50
            });
            aggData.Add(new AggregateData
            {
                Id = 1007,
                GroupDate = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 31
            });
            aggData.Add(new AggregateData
            {
                Id = 1008,
                GroupDate = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 133,
                ProCost = 110
            });
            aggData.Add(new AggregateData
            {
                Id = 1009,
                GroupDate = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 33,
                ProCost = 65
            });
            aggData.Add(new AggregateData
            {
                Id = 1010,
                GroupDate = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 37,
                ProCost = 20
            });
            aggData.Add(new AggregateData
            {
                Id = 1011,
                GroupDate = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 109,
                ProCost = 96
            });
            aggData.Add(new AggregateData
            {
                Id = 1012,
                GroupDate = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 266,
                ProCost = 139
            });
            aggData.Add(new AggregateData
            {
                Id = 1013,
                GroupDate = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 257,
                ProCost = 143
            });
            aggData.Add(new AggregateData
            {
                Id = 1014,
                GroupDate = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 79,
                ProCost = 53
            });
            aggData.Add(new AggregateData
            {
                Id = 1015,
                GroupDate = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 28,
                ProCost = 48
            });
            aggData.Add(new AggregateData
            {
                Id = 1016,
                GroupDate = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 128,
                ProCost = 117
            });
            aggData.Add(new AggregateData
            {
                Id = 1017,
                GroupDate = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 68,
                ProCost = 48
            });
            aggData.Add(new AggregateData
            {
                Id = 1018,
                GroupDate = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 26,
                ProCost = 32
            });
            aggData.Add(new AggregateData
            {
                Id = 1019,
                GroupDate = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 141,
                ProCost = 98
            });
            aggData.Add(new AggregateData
            {
                Id = 1020,
                GroupDate = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 281,
                ProCost = 134
            });
            aggData.Add(new AggregateData
            {
                Id = 1021,
                GroupDate = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 228,
                ProCost = 107
            });
            aggData.Add(new AggregateData
            {
                Id = 1022,
                GroupDate = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 73,
                ProCost = 49
            });
            aggData.Add(new AggregateData
            {
                Id = 1023,
                GroupDate = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 19,
                ProCost = 44
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 149,
                ProCost = 82
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 47,
                ProCost = 58
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 25,
                ProCost = 40
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 127,
                ProCost = 93
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 216,
                ProCost = 124
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 267,
                ProCost = 100
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 52,
                ProCost = 65
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 39,
                ProCost = 33
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 142,
                ProCost = 97
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 53,
                ProCost = 49
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 23,
                ProCost = 44
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 113,
                ProCost = 106
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 270,
                ProCost = 101
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 284,
                ProCost = 105
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 62,
                ProCost = 43
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 32,
                ProCost = 26
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 133,
                ProCost = 83
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 51,
                ProCost = 65
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 13,
                ProCost = 25
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 139,
                ProCost = 101
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 297,
                ProCost = 130
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 236,
                ProCost = 119
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 57,
                ProCost = 66
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 16,
                ProCost = 27
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 110,
                ProCost = 93
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 55,
                ProCost = 49
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 32,
                ProCost = 39
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 128,
                ProCost = 120
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 290,
                ProCost = 128
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 201,
                ProCost = 105
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 55,
                ProCost = 46
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 37
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 122,
                ProCost = 118
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 69,
                ProCost = 54
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 21,
                ProCost = 41
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 140,
                ProCost = 83
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 239,
                ProCost = 121
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 283,
                ProCost = 127
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 80,
                ProCost = 40
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 33,
                ProCost = 40
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 120,
                ProCost = 81
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 41,
                ProCost = 69
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 14,
                ProCost = 21
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 144,
                ProCost = 93
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 294,
                ProCost = 146
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 217,
                ProCost = 103
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 49,
                ProCost = 44
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 36,
                ProCost = 21
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 118,
                ProCost = 115
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 56,
                ProCost = 41
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 17,
                ProCost = 36
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 140,
                ProCost = 81
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 274,
                ProCost = 109
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 284,
                ProCost = 145
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 40,
                ProCost = 49
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 12,
                ProCost = 28
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 150,
                ProCost = 115
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 73,
                ProCost = 64
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 23,
                ProCost = 47
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 102,
                ProCost = 112
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 252,
                ProCost = 112
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 222,
                ProCost = 131
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 52,
                ProCost = 46
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 35,
                ProCost = 30
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 104,
                ProCost = 101
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 46,
                ProCost = 40
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 19,
                ProCost = 31
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 118,
                ProCost = 89
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 227,
                ProCost = 130
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 226,
                ProCost = 144
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 40,
                ProCost = 52
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 19,
                ProCost = 40
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 127,
                ProCost = 91
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 70,
                ProCost = 66
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 36,
                ProCost = 21
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 144,
                ProCost = 85
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 212,
                ProCost = 130
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 210,
                ProCost = 110
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 72,
                ProCost = 56
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 13,
                ProCost = 47
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 139,
                ProCost = 98
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 59,
                ProCost = 54
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 26,
                ProCost = 21
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 120,
                ProCost = 97
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 299,
                ProCost = 124
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 240,
                ProCost = 110
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 71,
                ProCost = 61
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 40,
                ProCost = 33
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 134,
                ProCost = 111
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 33,
                ProCost = 50
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 18,
                ProCost = 25
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 139,
                ProCost = 85
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 217,
                ProCost = 141
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 252,
                ProCost = 101
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 31,
                ProCost = 42
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 15,
                ProCost = 27
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 117,
                ProCost = 112
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 34,
                ProCost = 40
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 10,
                ProCost = 43
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 110,
                ProCost = 83
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 212,
                ProCost = 137
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 222,
                ProCost = 126
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 75,
                ProCost = 49
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 31,
                ProCost = 37
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 105,
                ProCost = 98
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 72,
                ProCost = 45
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 45
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 143,
                ProCost = 92
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 272,
                ProCost = 128
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 208,
                ProCost = 136
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 48,
                ProCost = 46
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 22,
                ProCost = 27
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 150,
                ProCost = 100
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 60,
                ProCost = 43
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 15,
                ProCost = 27
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 107,
                ProCost = 97
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 204,
                ProCost = 136
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 210,
                ProCost = 111
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 65,
                ProCost = 47
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 26,
                ProCost = 45
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 112,
                ProCost = 115
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 54,
                ProCost = 66
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 31,
                ProCost = 36
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 120,
                ProCost = 112
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 261,
                ProCost = 149
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 226,
                ProCost = 124
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 72,
                ProCost = 63
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 35,
                ProCost = 33
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 144,
                ProCost = 118
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 293,
                ProCost = 118
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 237,
                ProCost = 110
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 36,
                ProCost = 50
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 36
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 120,
                ProCost = 95
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 46,
                ProCost = 59
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 31,
                ProCost = 33
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 147,
                ProCost = 96
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 230,
                ProCost = 100
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 236,
                ProCost = 104
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 60,
                ProCost = 57
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 33,
                ProCost = 41
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 140,
                ProCost = 105
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 31,
                ProCost = 55
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 30
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 117,
                ProCost = 106
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 259,
                ProCost = 127
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 294,
                ProCost = 126
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 51,
                ProCost = 63
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 21,
                ProCost = 45
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 102,
                ProCost = 108
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 77,
                ProCost = 64
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 29,
                ProCost = 26
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 140,
                ProCost = 88
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 244,
                ProCost = 144
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 213,
                ProCost = 127
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 69,
                ProCost = 40
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 30,
                ProCost = 33
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 116,
                ProCost = 103
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 79,
                ProCost = 47
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 29,
                ProCost = 37
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 116,
                ProCost = 96
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 295,
                ProCost = 108
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 225,
                ProCost = 127
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 35,
                ProCost = 57
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 37,
                ProCost = 49
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 138,
                ProCost = 118
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 80,
                ProCost = 47
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 22,
                ProCost = 42
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 131,
                ProCost = 91
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 240,
                ProCost = 115
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 275,
                ProCost = 109
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 46,
                ProCost = 42
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 40,
                ProCost = 43
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 112,
                ProCost = 105
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 35,
                ProCost = 40
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 22,
                ProCost = 31
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 119,
                ProCost = 87
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 298,
                ProCost = 148
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 200,
                ProCost = 107
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 30,
                ProCost = 42
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 22,
                ProCost = 49
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 148,
                ProCost = 88
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 37,
                ProCost = 49
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 23,
                ProCost = 29
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 130,
                ProCost = 102
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 281,
                ProCost = 129
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 228,
                ProCost = 113
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 80,
                ProCost = 60
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 39,
                ProCost = 27
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 119,
                ProCost = 93
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 42,
                ProCost = 46
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 18,
                ProCost = 37
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 126,
                ProCost = 96
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 222,
                ProCost = 150
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 228,
                ProCost = 105
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 54,
                ProCost = 49
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 16,
                ProCost = 33
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 145,
                ProCost = 110
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 35,
                ProCost = 41
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 16,
                ProCost = 38
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 118,
                ProCost = 114
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 241,
                ProCost = 110
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 281,
                ProCost = 136
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 50,
                ProCost = 66
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 23,
                ProCost = 26
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 129,
                ProCost = 98
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 78,
                ProCost = 53
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 28,
                ProCost = 31
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 147,
                ProCost = 120
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 240,
                ProCost = 100
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 232,
                ProCost = 116
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 33,
                ProCost = 49
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 18,
                ProCost = 36
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 114,
                ProCost = 113
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 52,
                ProCost = 63
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 31,
                ProCost = 25
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 129,
                ProCost = 88
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 263,
                ProCost = 111
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 241,
                ProCost = 105
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 55,
                ProCost = 60
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 13,
                ProCost = 30
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 134,
                ProCost = 107
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 33,
                ProCost = 69
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 31
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 146,
                ProCost = 109
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 241,
                ProCost = 107
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 10,
                ProCost = 30
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 38,
                ProCost = 65
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 6,
                ProCost = 24
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 72,
                ProCost = 86
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 13,
                ProCost = 20
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 34,
                ProCost = 54
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 5,
                ProCost = 20
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 12,
                ProCost = 26
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 48,
                ProCost = 57
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 8,
                ProCost = 29
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 61,
                ProCost = 97
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 19,
                ProCost = 29
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 40,
                ProCost = 47
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 7,
                ProCost = 27
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 20,
                ProCost = 24
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 45,
                ProCost = 42
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 4,
                ProCost = 25
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 72,
                ProCost = 82
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 19,
                ProCost = 29
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 32,
                ProCost = 42
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 5,
                ProCost = 20
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 20,
                ProCost = 25
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 43,
                ProCost = 66
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 8,
                ProCost = 26
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 86,
                ProCost = 87
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 16,
                ProCost = 22
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 43,
                ProCost = 54
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 6,
                ProCost = 22
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 15,
                ProCost = 20
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 40,
                ProCost = 55
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 3,
                ProCost = 24
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 60,
                ProCost = 87
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 12,
                ProCost = 29
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 37,
                ProCost = 50
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 3,
                ProCost = 20
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 17,
                ProCost = 21
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 38,
                ProCost = 53
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 8,
                ProCost = 27
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 88,
                ProCost = 92
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 14,
                ProCost = 22
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 31,
                ProCost = 69
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 2,
                ProCost = 22
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 16,
                ProCost = 29
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 35,
                ProCost = 54
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 7,
                ProCost = 24
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 79,
                ProCost = 82
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 10,
                ProCost = 29
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 50,
                ProCost = 65
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 5,
                ProCost = 25
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 17,
                ProCost = 28
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 46,
                ProCost = 54
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 7,
                ProCost = 27
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 63,
                ProCost = 84
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 19,
                ProCost = 28
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 47,
                ProCost = 52
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 8,
                ProCost = 23
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 20,
                ProCost = 28
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 40,
                ProCost = 55
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 7,
                ProCost = 27
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 67,
                ProCost = 88
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 20,
                ProCost = 29
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 38,
                ProCost = 61
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 7,
                ProCost = 21
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 11,
                ProCost = 26
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 36,
                ProCost = 60
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 2,
                ProCost = 24
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 83,
                ProCost = 90
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 11,
                ProCost = 27
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 49,
                ProCost = 42
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 7,
                ProCost = 28
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 13,
                ProCost = 25
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 30,
                ProCost = 49
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 4,
                ProCost = 26
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 76,
                ProCost = 87
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 19,
                ProCost = 27
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 45,
                ProCost = 55
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 1,
                ProCost = 23
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 20,
                ProCost = 23
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 34,
                ProCost = 51
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 3,
                ProCost = 28
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 85,
                ProCost = 80
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 20,
                ProCost = 22
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 40,
                ProCost = 51
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 7,
                ProCost = 25
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 15,
                ProCost = 21
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 36,
                ProCost = 41
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 1,
                ProCost = 27
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 79,
                ProCost = 93
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 11,
                ProCost = 28
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 41,
                ProCost = 51
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 8,
                ProCost = 28
            });
            aggData.Add(new AggregateData
            {
                Id = 1001,
                GroupDate = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 20,
                ProCost = 23
            });
            return aggData;
        }

        }
}