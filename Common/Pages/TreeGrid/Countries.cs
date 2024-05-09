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
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.TreeGrid
{
    public class OverViewObject
    {
        public OverViewObject() { }

        public string name { get; set; }

        public int? CountryId { get; set; }

        public int population { get; set; }

        public double area { get; set; }

        public double gdp { get; set; }

        public int rating { get; set; }

        public double unemployment { get; set; }

        public string coordinates { get; set; }

        public string timezone { get; set; }

        public string capital { get; set; }


        public int? ParentID { get; set; }


        public string Parentname { get; set; }

        public static List<OverViewObject> GetDatas()
        {
            List<OverViewObject> OverViewObjectCollections = new List<OverViewObject>()
            {
                new OverViewObject()
                {
                    CountryId=1,
                    name = "usa",
                    capital = "Washington, D.C.",
                    area = 9147590,
                    population = 327892000,
                    gdp = 2.2,
                    timezone = "UTC -5 to -10",
                    rating = 5,
                    unemployment = 3.9,
                    coordinates = "37.0902° N, 95.7129° W",
                   ParentID=null,
                },

                new OverViewObject()
                {
                    CountryId=2,
                    name = "Washington, D.C.",
                    area = 184827,
                    population = 693972,
                    gdp = 4.7,
                    timezone = "UTC -5",
                    unemployment = 4.3,
                    coordinates = "38.9072° N, 77.0369° W",
                    Parentname = "USA",
                    ParentID=1,
                },

                new OverViewObject()
                {
                    CountryId=3,
                    name = "New York",
                    area = 783.8,
                    capital = "Albany",
                    population = 8175133,
                    gdp = 1.9,
                    timezone = "UTC -5",
                    unemployment = 3.9,
                    coordinates = "40.7128° N, 74.0060° W",
                    Parentname = "USA",
                    ParentID=1,
                },

                new OverViewObject()
                {
                    CountryId=4,
                    name = "New Mexico",
                    area = 315194,
                    capital = "Santa Fe",
                    population = 2088070,
                    gdp = 0.1,
                    timezone = "UTC -7",
                    unemployment = 4.7,
                    coordinates = "34.5199° N, 105.8701° W",
                    Parentname = "USA",
                    ParentID=1,
                },

                new OverViewObject()
                {
                    CountryId=5,
                    name = "Alaska",
                    area = 1717856,
                    capital = "Juneau",
                    population = 297832,
                    gdp = -0.5,
                    timezone = "UTC -9",
                    unemployment = 6.3,
                    coordinates = "64.2008° N, 149.4937° W",
                    Parentname = "USA",
                    ParentID=1,
                },

                new OverViewObject()
                {
                    CountryId=6,
                    name = "greece",
                    capital = "Athens",
                    area = 131957,
                    population = 10783625,
                    gdp = 1.5,
                    timezone = "UTC +2.0",
                    rating = 3,
                    unemployment = 20.8,
                    coordinates = "39.0742° N, 21.8243° E",
                    ParentID=null,
                },

                new OverViewObject()
                {
                    CountryId=7,
                    name = "Athens",
                    area = 2929,
                    population = 664046,
                    gdp = 1,
                    timezone = "UTC +2.0",
                    unemployment = 7.7,
                    coordinates = "37.9838° N, 23.7275° E",
                    Parentname = "Greece",
                    ParentID=6,
                },

                new OverViewObject()
                {
                    CountryId=8,
                    name = "Arcadia",
                    capital = "Tripoli",
                    area = 28.83,
                    population = 58799,
                    gdp = 2.5,
                    timezone = "UTC +2.0",
                    unemployment = 3.0,
                    coordinates = "34.1397° N, 118.0353° W",
                    Parentname = "Greece",
                    ParentID=6,
                },

                new OverViewObject()
                {
                    CountryId=9,
                    name = "Argolis",
                    capital = "Nafplio",
                    area = 2154,
                    population = 97044,
                    gdp = 2.1,
                    timezone = "UTC +2.0",
                    unemployment = 6.2,
                    coordinates = "37.6525° N, 22.8582° E",
                    Parentname = "Greece",
                    ParentID=6,
                },

                new OverViewObject()
                {
                    CountryId=10,
                    name = "germany",
                    capital = "Berlin",
                    area = 357386,
                    population = 82293457,
                    gdp = 2.2,
                    timezone = "UTC +1.0",
                    rating = 5,
                    unemployment = 3.3,
                    coordinates = "51.1657° N, 10.4515° E",
                    ParentID=null,
                },

                new OverViewObject()
                {
                    CountryId=11,
                    name = "Berlin",
                    area = 891.8,
                    population = 3539234,
                    gdp = 4.1,
                    timezone = "UTC +1.0",
                    unemployment = 7.7,
                    coordinates = "52.5200° N, 13.4050° E",
                    Parentname = "Germany",
                    ParentID=10,
                },

                new OverViewObject()
                {
                    CountryId=12,
                    name = "Bavaria",
                    capital = "Munich",
                    area = 70550,
                    population = 12997204,
                    gdp = 3.1,
                    timezone = "UTC +1.0",
                    unemployment = 2.7,
                    coordinates = "48.7904° N, 11.4979° E",
                    Parentname = "Germany",
                    ParentID=10,
                },

                new OverViewObject()
                {
                     CountryId=13,
                    name = "Saxony",
                    capital = "Dresden",
                    area = 18416,
                    population = 4081308,
                    gdp = 3.8,
                    timezone = "UTC +1.0",
                    unemployment = 6.2,
                    coordinates = "51.1045° N, 13.2017° E",
                    Parentname = "Germany",
                    ParentID=10,
                },

                new OverViewObject()
                {
                    CountryId=14,
                    name = "bangladesh",
                    capital = "Dhaka",
                    area = 147570,
                    population = 185584811,
                    gdp = 7.3,
                    timezone = "UTC +6.0",
                    rating = 3,
                    unemployment = 4.3,
                    coordinates = "23.6850° N, 90.3563° E",
                    ParentID=null,
                },

                new OverViewObject()
                {
                    CountryId=15,
                    name = "Dhaka",
                    area = 306.4,
                    population = 10356500,
                    gdp = 7.28,
                    timezone = "UTC +6.0",
                    unemployment = 7.4,
                    coordinates = "23.8103° N, 90.4125° E",
                    Parentname = "Bangladesh",
                    ParentID=14,
                },

                new OverViewObject()
                {
                    CountryId=16,
                    name = "Barisal",
                    capital = "Barisal",
                    area = 16.37,
                    population = 202242,
                    gdp = 6.3,
                    timezone = "UTC +6.0",
                    unemployment = 5,
                    coordinates = "22.7010° N, 90.3535° E",
                    Parentname = "Bangladesh",
                    ParentID=14,
                },

                new OverViewObject()
                {
                    CountryId=17,
                    name = "Chittagong",
                    capital = "Chittagong",
                    area = 168.1,
                    population = 3920222,
                    gdp = 6.3,
                    timezone = "UTC +6.0",
                    unemployment = 4.7,
                    coordinates = "22.3569° N, 91.7832° E",
                    Parentname = "Bangladesh",
                    ParentID=14,
                },

                new OverViewObject()
                {
                    CountryId=18,
                    name = "egypt",
                    capital = "Cairo",
                    area = 1001449,
                    population = 99375741,
                    gdp = 4.2,
                    timezone = "UTC +2.0",
                    rating = 3,
                    unemployment = 9.9,
                    coordinates = "26.8206° N, 30.8025° E",
                   ParentID=null,
                },

                new OverViewObject()
                {
                    CountryId=19,
                    name = "Cairo",
                    area = 528,
                    population = 7734614,
                    gdp = 3.7,
                    timezone = "UTC +2.0",
                    unemployment = 11.3,
                    coordinates = "30.0444° N, 31.2357° E",
                    Parentname = "Egypt",
                    ParentID=18,
                },

                new OverViewObject()
                {
                    CountryId=20,
                    name = "Alexandria",
                    capital = "Bacos",
                    area = 46.42,
                    population = 3811516,
                    gdp = 4.2,
                    timezone = "UTC +2.0",
                    unemployment = 5.3,
                    coordinates = "31.2001° N, 29.9187° E",
                    Parentname = "Egypt",
                    ParentID=18,
                },

                new OverViewObject()
                {
                    CountryId=21,
                    name = "Giza",
                    capital = "Giza",
                    area = 1580,
                    population = 2443203,
                    gdp = 4.1,
                    timezone = "UTC +2.0",
                    unemployment = 4.7,
                    coordinates = "30.0131° N, 31.2089° E",
                    Parentname = "Egypt",
                    ParentID=18,
                },

                new OverViewObject()
                {
                    CountryId=22,
                    name = "canada",
                    capital = "Ottawa",
                    area = 9984670,
                    population = 36953765,
                    gdp = 3.0,
                    timezone = "UTC -3.3 to -8",
                    rating = 5,
                    unemployment = 5.8,
                    coordinates = "56.1304° N, 106.3468° W",
                    ParentID=null,
                },

                new OverViewObject()
                {
                    CountryId=23,
                    name = "Ontario",
                    capital = "Toronto",
                    area = 908607,
                    population = 14374084,
                    gdp = 2.8,
                    timezone = "UTC -5",
                    unemployment = 5.9,
                    coordinates = "51.2538° N, 85.3232° W",
                    Parentname = "Canada",
                    ParentID=22,
                },

                new OverViewObject()
                {
                    CountryId=24,
                    name = "Quebec",
                    capital = "Quebec",
                    area = 1542056,
                    population = 8455402,
                    gdp = 1.9,
                    timezone = "UTC -4 to -5",
                    unemployment = 5.6,
                    coordinates = "46.8139° N, 71.2080° W",
                    Parentname = "Canada",
                    ParentID=22,
                },

                new OverViewObject()
                {
                    CountryId=25,
                    name = "Alberta",
                    capital = "Edmonton",
                    area = 661848,
                    population = 4334025,
                    gdp = 1.6,
                    timezone = "UTC -7",
                    unemployment = 7.8,
                    coordinates = "53.9333° N, 116.5765° W",
                    Parentname = "Canada",
                    ParentID=22,
                },

                new OverViewObject()
                {
                    CountryId=26,
                    name = "Manitoba",
                    capital = "Winnipeg",
                    area = 647797,
                    population = 1348809,
                    gdp = 2.9,
                    timezone = "UTC -6",
                    unemployment = 6,
                    coordinates = "53.7609° N, 98.8139° W",
                    Parentname = "Canada",
                    ParentID=22,
                },

            };

            return OverViewObjectCollections;

        }
    }
}