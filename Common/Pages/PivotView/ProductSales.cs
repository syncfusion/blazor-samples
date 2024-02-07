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
    public class ProductSales
    {
        public string ProductType { get; set; }
        public string Product { get; set; }
        public int Year { get; set; }
        public double SoldAmount { get; set; }

        public static List<ProductSales> GetSalesData = new List<ProductSales>
        {
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2001,
                SoldAmount = 737
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2001,
                SoldAmount = 862
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2001,
                SoldAmount = 1160
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2001,
                SoldAmount = 715
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2001,
                SoldAmount = 1284
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2001,
                SoldAmount = 221
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2001,
                SoldAmount = 179
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2001,
                SoldAmount = 1872
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2001,
                SoldAmount = 1447
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2001,
                SoldAmount = 771
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2001,
                SoldAmount = 1510
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2001,
                SoldAmount = 1083
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2002,
                SoldAmount = 1654
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2002,
                SoldAmount = 1750
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2002,
                SoldAmount = 1622
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2002,
                SoldAmount = 1048
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2002,
                SoldAmount = 1714
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2002,
                SoldAmount = 15
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2002,
                SoldAmount = 779
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2002,
                SoldAmount = 1081
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2002,
                SoldAmount = 1741
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2002,
                SoldAmount = 1491
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2002,
                SoldAmount = 1740
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2002,
                SoldAmount = 1476
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2003,
                SoldAmount = 886
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2003,
                SoldAmount = 1323
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2003,
                SoldAmount = 1882
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2003,
                SoldAmount = 1557
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2003,
                SoldAmount = 1014
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2003,
                SoldAmount = 1381
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2003,
                SoldAmount = 1450
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2003,
                SoldAmount = 1684
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2003,
                SoldAmount = 1717
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2003,
                SoldAmount = 1918
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2003,
                SoldAmount = 648
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2003,
                SoldAmount = 439
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2004,
                SoldAmount = 950
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2004,
                SoldAmount = 843
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2004,
                SoldAmount = 1364
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2004,
                SoldAmount = 1453
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2004,
                SoldAmount = 461
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2004,
                SoldAmount = 1398
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2004,
                SoldAmount = 1178
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2004,
                SoldAmount = 879
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2004,
                SoldAmount = 1675
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2004,
                SoldAmount = 1785
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2004,
                SoldAmount = 1924
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2004,
                SoldAmount = 1370
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2005,
                SoldAmount = 671
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2005,
                SoldAmount = 377
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2005,
                SoldAmount = 794
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2005,
                SoldAmount = 1838
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2005,
                SoldAmount = 568
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2005,
                SoldAmount = 1619
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2005,
                SoldAmount = 590
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2005,
                SoldAmount = 163
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2005,
                SoldAmount = 104
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2005,
                SoldAmount = 1905
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2005,
                SoldAmount = 703
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2005,
                SoldAmount = 1935
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2006,
                SoldAmount = 1394
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2006,
                SoldAmount = 1111
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2006,
                SoldAmount = 153
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2006,
                SoldAmount = 1074
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2006,
                SoldAmount = 739
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2006,
                SoldAmount = 1394
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2006,
                SoldAmount = 1847
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2006,
                SoldAmount = 219
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2006,
                SoldAmount = 1748
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2006,
                SoldAmount = 1211
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2006,
                SoldAmount = 1510
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2006,
                SoldAmount = 1482
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2007,
                SoldAmount = 1191
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2007,
                SoldAmount = 1527
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2007,
                SoldAmount = 1896
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2007,
                SoldAmount = 1691
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2007,
                SoldAmount = 1265
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2007,
                SoldAmount = 1272
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2007,
                SoldAmount = 182
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2007,
                SoldAmount = 652
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2007,
                SoldAmount = 1021
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2007,
                SoldAmount = 949
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2007,
                SoldAmount = 1640
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2007,
                SoldAmount = 127
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2008,
                SoldAmount = 655
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2008,
                SoldAmount = 641
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2008,
                SoldAmount = 1568
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2008,
                SoldAmount = 1309
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2008,
                SoldAmount = 394
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2008,
                SoldAmount = 12
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2008,
                SoldAmount = 663
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2008,
                SoldAmount = 1099
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2008,
                SoldAmount = 1657
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2008,
                SoldAmount = 1806
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2008,
                SoldAmount = 918
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2008,
                SoldAmount = 1858
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2009,
                SoldAmount = 729
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2009,
                SoldAmount = 1459
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2009,
                SoldAmount = 1718
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2009,
                SoldAmount = 1773
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2009,
                SoldAmount = 433
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2009,
                SoldAmount = 1046
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2009,
                SoldAmount = 25
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2009,
                SoldAmount = 1410
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2009,
                SoldAmount = 256
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2009,
                SoldAmount = 1821
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2009,
                SoldAmount = 287
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2009,
                SoldAmount = 329
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2010,
                SoldAmount = 316
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2010,
                SoldAmount = 650
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2010,
                SoldAmount = 822
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2010,
                SoldAmount = 771
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2010,
                SoldAmount = 1306
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2010,
                SoldAmount = 1219
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2010,
                SoldAmount = 1989
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2010,
                SoldAmount = 926
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2010,
                SoldAmount = 1619
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2010,
                SoldAmount = 768
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2010,
                SoldAmount = 1062
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2010,
                SoldAmount = 1519
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2011,
                SoldAmount = 1656
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2011,
                SoldAmount = 153
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2011,
                SoldAmount = 1962
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2011,
                SoldAmount = 250
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2011,
                SoldAmount = 1433
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2011,
                SoldAmount = 1476
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2011,
                SoldAmount = 1242
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2011,
                SoldAmount = 1606
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2011,
                SoldAmount = 1082
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2011,
                SoldAmount = 1243
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2011,
                SoldAmount = 1914
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2011,
                SoldAmount = 1994
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2012,
                SoldAmount = 1359
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2012,
                SoldAmount = 426
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2012,
                SoldAmount = 1337
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2012,
                SoldAmount = 401
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2012,
                SoldAmount = 876
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2012,
                SoldAmount = 1340
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2012,
                SoldAmount = 1252
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2012,
                SoldAmount = 364
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2012,
                SoldAmount = 1133
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2012,
                SoldAmount = 485
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2012,
                SoldAmount = 1190
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2012,
                SoldAmount = 1845
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2013,
                SoldAmount = 1861
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2013,
                SoldAmount = 1825
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2013,
                SoldAmount = 1589
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2013,
                SoldAmount = 26
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2013,
                SoldAmount = 23
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2013,
                SoldAmount = 767
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2013,
                SoldAmount = 1294
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2013,
                SoldAmount = 1013
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2013,
                SoldAmount = 1386
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2013,
                SoldAmount = 1681
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2013,
                SoldAmount = 185
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2013,
                SoldAmount = 1749
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2014,
                SoldAmount = 1664
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2014,
                SoldAmount = 363
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2014,
                SoldAmount = 849
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2014,
                SoldAmount = 407
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2014,
                SoldAmount = 1865
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2014,
                SoldAmount = 1224
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2014,
                SoldAmount = 1805
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2014,
                SoldAmount = 1855
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2014,
                SoldAmount = 1387
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2014,
                SoldAmount = 872
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2014,
                SoldAmount = 46
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2014,
                SoldAmount = 1457
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2015,
                SoldAmount = 1244
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2015,
                SoldAmount = 478
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2015,
                SoldAmount = 1591
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2015,
                SoldAmount = 636
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2015,
                SoldAmount = 65
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2015,
                SoldAmount = 44
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2015,
                SoldAmount = 1673
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2015,
                SoldAmount = 355
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2015,
                SoldAmount = 634
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2015,
                SoldAmount = 289
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2015,
                SoldAmount = 1567
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2015,
                SoldAmount = 337
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2016,
                SoldAmount = 1389
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2016,
                SoldAmount = 1239
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2016,
                SoldAmount = 1760
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2016,
                SoldAmount = 838
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2016,
                SoldAmount = 191
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2016,
                SoldAmount = 1058
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2016,
                SoldAmount = 1785
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2016,
                SoldAmount = 1863
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2016,
                SoldAmount = 750
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2016,
                SoldAmount = 1515
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2016,
                SoldAmount = 778
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2016,
                SoldAmount = 1264
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2017,
                SoldAmount = 965
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2017,
                SoldAmount = 1920
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2017,
                SoldAmount = 721
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2017,
                SoldAmount = 588
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2017,
                SoldAmount = 841
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2017,
                SoldAmount = 1303
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2017,
                SoldAmount = 563
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2017,
                SoldAmount = 701
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2017,
                SoldAmount = 109
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2017,
                SoldAmount = 932
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2017,
                SoldAmount = 1620
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2017,
                SoldAmount = 685
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2018,
                SoldAmount = 675
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2018,
                SoldAmount = 568
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2018,
                SoldAmount = 528
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2018,
                SoldAmount = 1341
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2018,
                SoldAmount = 1487
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2018,
                SoldAmount = 1981
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2018,
                SoldAmount = 1323
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2018,
                SoldAmount = 438
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2018,
                SoldAmount = 442
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2018,
                SoldAmount = 830
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2018,
                SoldAmount = 625
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2018,
                SoldAmount = 883
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2019,
                SoldAmount = 183
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2019,
                SoldAmount = 377
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2019,
                SoldAmount = 1744
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2019,
                SoldAmount = 1964
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2019,
                SoldAmount = 1691
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2019,
                SoldAmount = 1340
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2019,
                SoldAmount = 445
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2019,
                SoldAmount = 1570
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2019,
                SoldAmount = 461
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2019,
                SoldAmount = 1022
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2019,
                SoldAmount = 530
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2019,
                SoldAmount = 237
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2020,
                SoldAmount = 1062
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2020,
                SoldAmount = 739
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2020,
                SoldAmount = 828
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2020,
                SoldAmount = 1642
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2020,
                SoldAmount = 227
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2020,
                SoldAmount = 923
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2020,
                SoldAmount = 684
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2020,
                SoldAmount = 377
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2020,
                SoldAmount = 162
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2020,
                SoldAmount = 554
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2020,
                SoldAmount = 126
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2020,
                SoldAmount = 652
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2001,
                SoldAmount = 410
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2001,
                SoldAmount = 897
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2001,
                SoldAmount = 317
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2001,
                SoldAmount = 1803
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2001,
                SoldAmount = 1077
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2001,
                SoldAmount = 1229
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2001,
                SoldAmount = 1655
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2001,
                SoldAmount = 684
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2001,
                SoldAmount = 335
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2001,
                SoldAmount = 1664
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2001,
                SoldAmount = 114
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2001,
                SoldAmount = 1579
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2002,
                SoldAmount = 1512
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2002,
                SoldAmount = 1023
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2002,
                SoldAmount = 905
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2002,
                SoldAmount = 618
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2002,
                SoldAmount = 1437
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2002,
                SoldAmount = 54
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2002,
                SoldAmount = 1151
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2002,
                SoldAmount = 1313
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2002,
                SoldAmount = 721
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2002,
                SoldAmount = 91
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2002,
                SoldAmount = 817
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2002,
                SoldAmount = 1400
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2003,
                SoldAmount = 1354
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2003,
                SoldAmount = 937
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2003,
                SoldAmount = 1387
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2003,
                SoldAmount = 1472
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2003,
                SoldAmount = 229
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2003,
                SoldAmount = 1087
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2003,
                SoldAmount = 450
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2003,
                SoldAmount = 635
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2003,
                SoldAmount = 733
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2003,
                SoldAmount = 1729
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2003,
                SoldAmount = 1900
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2003,
                SoldAmount = 1952
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2004,
                SoldAmount = 982
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2004,
                SoldAmount = 1612
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2004,
                SoldAmount = 564
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2004,
                SoldAmount = 1997
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2004,
                SoldAmount = 1488
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2004,
                SoldAmount = 1345
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2004,
                SoldAmount = 1816
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2004,
                SoldAmount = 325
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2004,
                SoldAmount = 1776
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2004,
                SoldAmount = 1182
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2004,
                SoldAmount = 77
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2004,
                SoldAmount = 1124
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2005,
                SoldAmount = 1762
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2005,
                SoldAmount = 1016
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2005,
                SoldAmount = 295
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2005,
                SoldAmount = 954
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2005,
                SoldAmount = 253
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2005,
                SoldAmount = 499
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2005,
                SoldAmount = 640
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2005,
                SoldAmount = 51
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2005,
                SoldAmount = 1082
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2005,
                SoldAmount = 1174
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2005,
                SoldAmount = 1730
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2005,
                SoldAmount = 391
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2006,
                SoldAmount = 1681
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2006,
                SoldAmount = 975
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2006,
                SoldAmount = 414
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2006,
                SoldAmount = 67
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2006,
                SoldAmount = 1146
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2006,
                SoldAmount = 1134
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2006,
                SoldAmount = 1286
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2006,
                SoldAmount = 1943
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2006,
                SoldAmount = 394
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2006,
                SoldAmount = 1293
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2006,
                SoldAmount = 477
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2006,
                SoldAmount = 1053
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2007,
                SoldAmount = 326
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2007,
                SoldAmount = 644
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2007,
                SoldAmount = 63
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2007,
                SoldAmount = 869
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2007,
                SoldAmount = 703
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2007,
                SoldAmount = 1559
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2007,
                SoldAmount = 1498
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2007,
                SoldAmount = 1230
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2007,
                SoldAmount = 530
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2007,
                SoldAmount = 549
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2007,
                SoldAmount = 130
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2007,
                SoldAmount = 1850
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2008,
                SoldAmount = 912
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2008,
                SoldAmount = 574
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2008,
                SoldAmount = 548
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2008,
                SoldAmount = 1743
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2008,
                SoldAmount = 1012
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2008,
                SoldAmount = 1951
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2008,
                SoldAmount = 728
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2008,
                SoldAmount = 1101
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2008,
                SoldAmount = 1445
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2008,
                SoldAmount = 806
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2008,
                SoldAmount = 921
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2008,
                SoldAmount = 82
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2009,
                SoldAmount = 561
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2009,
                SoldAmount = 631
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2009,
                SoldAmount = 1856
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2009,
                SoldAmount = 1936
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2009,
                SoldAmount = 416
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2009,
                SoldAmount = 544
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2009,
                SoldAmount = 1122
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2009,
                SoldAmount = 47
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2009,
                SoldAmount = 1962
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2009,
                SoldAmount = 1391
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2009,
                SoldAmount = 1421
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2009,
                SoldAmount = 333
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2010,
                SoldAmount = 32
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2010,
                SoldAmount = 485
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2010,
                SoldAmount = 1336
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2010,
                SoldAmount = 207
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2010,
                SoldAmount = 700
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2010,
                SoldAmount = 357
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2010,
                SoldAmount = 1295
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2010,
                SoldAmount = 1007
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2010,
                SoldAmount = 1843
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2010,
                SoldAmount = 1409
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2010,
                SoldAmount = 101
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2010,
                SoldAmount = 702
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2011,
                SoldAmount = 1833
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2011,
                SoldAmount = 1326
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2011,
                SoldAmount = 417
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2011,
                SoldAmount = 1693
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2011,
                SoldAmount = 660
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2011,
                SoldAmount = 1830
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2011,
                SoldAmount = 1632
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2011,
                SoldAmount = 1565
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2011,
                SoldAmount = 1500
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2011,
                SoldAmount = 684
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2011,
                SoldAmount = 1579
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2011,
                SoldAmount = 1294
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2012,
                SoldAmount = 1802
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2012,
                SoldAmount = 720
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2012,
                SoldAmount = 387
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2012,
                SoldAmount = 1549
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2012,
                SoldAmount = 286
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2012,
                SoldAmount = 1750
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2012,
                SoldAmount = 1436
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2012,
                SoldAmount = 1097
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2012,
                SoldAmount = 1733
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2012,
                SoldAmount = 1135
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2012,
                SoldAmount = 20
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2012,
                SoldAmount = 738
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2013,
                SoldAmount = 567
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2013,
                SoldAmount = 1546
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2013,
                SoldAmount = 1092
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2013,
                SoldAmount = 326
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2013,
                SoldAmount = 1794
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2013,
                SoldAmount = 1445
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2013,
                SoldAmount = 1837
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2013,
                SoldAmount = 1960
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2013,
                SoldAmount = 356
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2013,
                SoldAmount = 17
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2013,
                SoldAmount = 138
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2013,
                SoldAmount = 787
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2014,
                SoldAmount = 844
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2014,
                SoldAmount = 1346
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2014,
                SoldAmount = 278
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2014,
                SoldAmount = 1098
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2014,
                SoldAmount = 1392
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2014,
                SoldAmount = 178
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2014,
                SoldAmount = 1735
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2014,
                SoldAmount = 503
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2014,
                SoldAmount = 1038
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2014,
                SoldAmount = 1821
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2014,
                SoldAmount = 1203
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2014,
                SoldAmount = 827
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2015,
                SoldAmount = 687
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2015,
                SoldAmount = 1277
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2015,
                SoldAmount = 1922
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2015,
                SoldAmount = 987
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2015,
                SoldAmount = 1393
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2015,
                SoldAmount = 1360
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2015,
                SoldAmount = 591
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2015,
                SoldAmount = 1518
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2015,
                SoldAmount = 1443
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2015,
                SoldAmount = 1944
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2015,
                SoldAmount = 804
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2015,
                SoldAmount = 1510
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2016,
                SoldAmount = 1173
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2016,
                SoldAmount = 1432
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2016,
                SoldAmount = 745
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2016,
                SoldAmount = 975
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2016,
                SoldAmount = 190
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2016,
                SoldAmount = 40
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2016,
                SoldAmount = 1191
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2016,
                SoldAmount = 718
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2016,
                SoldAmount = 569
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2016,
                SoldAmount = 931
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2016,
                SoldAmount = 608
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2016,
                SoldAmount = 1963
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2017,
                SoldAmount = 686
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2017,
                SoldAmount = 1484
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2017,
                SoldAmount = 1746
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2017,
                SoldAmount = 887
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2017,
                SoldAmount = 1457
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2017,
                SoldAmount = 1500
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2017,
                SoldAmount = 1894
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2017,
                SoldAmount = 1364
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2017,
                SoldAmount = 1280
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2017,
                SoldAmount = 188
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2017,
                SoldAmount = 698
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2017,
                SoldAmount = 85
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2018,
                SoldAmount = 995
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2018,
                SoldAmount = 1572
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2018,
                SoldAmount = 1244
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2018,
                SoldAmount = 1577
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2018,
                SoldAmount = 1536
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2018,
                SoldAmount = 1600
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2018,
                SoldAmount = 208
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2018,
                SoldAmount = 471
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2018,
                SoldAmount = 876
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2018,
                SoldAmount = 1211
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2018,
                SoldAmount = 1093
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2018,
                SoldAmount = 1435
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2019,
                SoldAmount = 140
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2019,
                SoldAmount = 1690
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2019,
                SoldAmount = 906
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2019,
                SoldAmount = 1159
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2019,
                SoldAmount = 1243
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2019,
                SoldAmount = 1325
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2019,
                SoldAmount = 512
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2019,
                SoldAmount = 1365
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2019,
                SoldAmount = 1852
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2019,
                SoldAmount = 1903
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2019,
                SoldAmount = 1770
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2019,
                SoldAmount = 960
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2020,
                SoldAmount = 1660
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2020,
                SoldAmount = 1100
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2020,
                SoldAmount = 1578
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2020,
                SoldAmount = 197
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2020,
                SoldAmount = 941
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2020,
                SoldAmount = 1348
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2020,
                SoldAmount = 1229
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2020,
                SoldAmount = 503
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2020,
                SoldAmount = 554
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2020,
                SoldAmount = 1964
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2020,
                SoldAmount = 1300
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2020,
                SoldAmount = 1119
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2001,
                SoldAmount = 1890
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2001,
                SoldAmount = 946
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2001,
                SoldAmount = 144
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2001,
                SoldAmount = 840
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2001,
                SoldAmount = 1601
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2001,
                SoldAmount = 821
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2001,
                SoldAmount = 698
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2001,
                SoldAmount = 123
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2001,
                SoldAmount = 397
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2001,
                SoldAmount = 1276
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2001,
                SoldAmount = 974
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2001,
                SoldAmount = 1091
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2002,
                SoldAmount = 815
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2002,
                SoldAmount = 428
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2002,
                SoldAmount = 1572
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2002,
                SoldAmount = 91
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2002,
                SoldAmount = 604
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2002,
                SoldAmount = 1322
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2002,
                SoldAmount = 1189
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2002,
                SoldAmount = 1014
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2002,
                SoldAmount = 179
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2002,
                SoldAmount = 162
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2002,
                SoldAmount = 873
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2002,
                SoldAmount = 1882
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2003,
                SoldAmount = 1607
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2003,
                SoldAmount = 357
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2003,
                SoldAmount = 127
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2003,
                SoldAmount = 1458
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2003,
                SoldAmount = 750
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2003,
                SoldAmount = 5
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2003,
                SoldAmount = 1140
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2003,
                SoldAmount = 1008
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2003,
                SoldAmount = 1176
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2003,
                SoldAmount = 1261
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2003,
                SoldAmount = 533
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2003,
                SoldAmount = 559
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2004,
                SoldAmount = 1783
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2004,
                SoldAmount = 911
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2004,
                SoldAmount = 863
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2004,
                SoldAmount = 455
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2004,
                SoldAmount = 972
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2004,
                SoldAmount = 1844
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2004,
                SoldAmount = 114
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2004,
                SoldAmount = 1363
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2004,
                SoldAmount = 534
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2004,
                SoldAmount = 710
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2004,
                SoldAmount = 1559
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2004,
                SoldAmount = 1981
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2005,
                SoldAmount = 554
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2005,
                SoldAmount = 1037
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2005,
                SoldAmount = 1393
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2005,
                SoldAmount = 904
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2005,
                SoldAmount = 1880
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2005,
                SoldAmount = 1078
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2005,
                SoldAmount = 1059
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2005,
                SoldAmount = 1125
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2005,
                SoldAmount = 397
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2005,
                SoldAmount = 205
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2005,
                SoldAmount = 1225
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2005,
                SoldAmount = 1599
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2006,
                SoldAmount = 1072
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2006,
                SoldAmount = 1201
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2006,
                SoldAmount = 286
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2006,
                SoldAmount = 483
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2006,
                SoldAmount = 1716
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2006,
                SoldAmount = 1348
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2006,
                SoldAmount = 1241
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2006,
                SoldAmount = 945
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2006,
                SoldAmount = 1404
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2006,
                SoldAmount = 1106
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2006,
                SoldAmount = 1173
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2006,
                SoldAmount = 1602
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2007,
                SoldAmount = 1586
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2007,
                SoldAmount = 401
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2007,
                SoldAmount = 963
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2007,
                SoldAmount = 221
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2007,
                SoldAmount = 1732
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2007,
                SoldAmount = 193
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2007,
                SoldAmount = 1722
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2007,
                SoldAmount = 925
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2007,
                SoldAmount = 282
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2007,
                SoldAmount = 281
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2007,
                SoldAmount = 881
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2007,
                SoldAmount = 1616
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2008,
                SoldAmount = 538
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2008,
                SoldAmount = 1015
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2008,
                SoldAmount = 1998
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2008,
                SoldAmount = 540
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2008,
                SoldAmount = 1643
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2008,
                SoldAmount = 949
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2008,
                SoldAmount = 1440
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2008,
                SoldAmount = 553
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2008,
                SoldAmount = 1827
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2008,
                SoldAmount = 1946
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2008,
                SoldAmount = 298
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2008,
                SoldAmount = 1063
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2009,
                SoldAmount = 374
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2009,
                SoldAmount = 1691
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2009,
                SoldAmount = 1357
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2009,
                SoldAmount = 935
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2009,
                SoldAmount = 856
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2009,
                SoldAmount = 103
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2009,
                SoldAmount = 1771
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2009,
                SoldAmount = 911
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2009,
                SoldAmount = 106
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2009,
                SoldAmount = 434
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2009,
                SoldAmount = 1118
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2009,
                SoldAmount = 443
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2010,
                SoldAmount = 559
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2010,
                SoldAmount = 422
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2010,
                SoldAmount = 18
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2010,
                SoldAmount = 1280
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2010,
                SoldAmount = 1889
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2010,
                SoldAmount = 1246
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2010,
                SoldAmount = 147
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2010,
                SoldAmount = 1454
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2010,
                SoldAmount = 720
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2010,
                SoldAmount = 162
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2010,
                SoldAmount = 1132
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2010,
                SoldAmount = 1475
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2011,
                SoldAmount = 1666
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2011,
                SoldAmount = 505
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2011,
                SoldAmount = 1728
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2011,
                SoldAmount = 336
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2011,
                SoldAmount = 1031
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2011,
                SoldAmount = 579
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2011,
                SoldAmount = 229
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2011,
                SoldAmount = 483
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2011,
                SoldAmount = 502
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2011,
                SoldAmount = 114
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2011,
                SoldAmount = 1875
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2011,
                SoldAmount = 1438
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2012,
                SoldAmount = 702
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2012,
                SoldAmount = 517
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2012,
                SoldAmount = 589
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2012,
                SoldAmount = 655
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2012,
                SoldAmount = 1218
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2012,
                SoldAmount = 1292
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2012,
                SoldAmount = 988
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2012,
                SoldAmount = 101
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2012,
                SoldAmount = 147
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2012,
                SoldAmount = 1965
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2012,
                SoldAmount = 1836
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2012,
                SoldAmount = 503
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2013,
                SoldAmount = 304
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2013,
                SoldAmount = 62
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2013,
                SoldAmount = 1296
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2013,
                SoldAmount = 1173
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2013,
                SoldAmount = 792
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2013,
                SoldAmount = 202
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2013,
                SoldAmount = 80
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2013,
                SoldAmount = 372
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2013,
                SoldAmount = 16
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2013,
                SoldAmount = 1101
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2013,
                SoldAmount = 559
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2013,
                SoldAmount = 1672
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2014,
                SoldAmount = 1221
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2014,
                SoldAmount = 238
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2014,
                SoldAmount = 314
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2014,
                SoldAmount = 1272
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2014,
                SoldAmount = 1492
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2014,
                SoldAmount = 1485
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2014,
                SoldAmount = 182
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2014,
                SoldAmount = 1468
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2014,
                SoldAmount = 1719
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2014,
                SoldAmount = 1383
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2014,
                SoldAmount = 754
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2014,
                SoldAmount = 1000
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2015,
                SoldAmount = 1787
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2015,
                SoldAmount = 1619
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2015,
                SoldAmount = 1142
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2015,
                SoldAmount = 191
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2015,
                SoldAmount = 987
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2015,
                SoldAmount = 772
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2015,
                SoldAmount = 875
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2015,
                SoldAmount = 758
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2015,
                SoldAmount = 113
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2015,
                SoldAmount = 585
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2015,
                SoldAmount = 362
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2015,
                SoldAmount = 788
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2016,
                SoldAmount = 1193
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2016,
                SoldAmount = 1195
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2016,
                SoldAmount = 564
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2016,
                SoldAmount = 1314
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2016,
                SoldAmount = 345
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2016,
                SoldAmount = 1453
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2016,
                SoldAmount = 1958
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2016,
                SoldAmount = 75
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2016,
                SoldAmount = 1692
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2016,
                SoldAmount = 1134
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2016,
                SoldAmount = 50
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2016,
                SoldAmount = 1376
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2017,
                SoldAmount = 1330
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2017,
                SoldAmount = 1055
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2017,
                SoldAmount = 13
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2017,
                SoldAmount = 1521
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2017,
                SoldAmount = 1466
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2017,
                SoldAmount = 1010
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2017,
                SoldAmount = 1835
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2017,
                SoldAmount = 385
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2017,
                SoldAmount = 954
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2017,
                SoldAmount = 1649
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2017,
                SoldAmount = 525
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2017,
                SoldAmount = 1215
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2018,
                SoldAmount = 339
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2018,
                SoldAmount = 1078
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2018,
                SoldAmount = 1610
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2018,
                SoldAmount = 135
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2018,
                SoldAmount = 1580
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2018,
                SoldAmount = 1766
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2018,
                SoldAmount = 792
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2018,
                SoldAmount = 435
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2018,
                SoldAmount = 1204
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2018,
                SoldAmount = 1624
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2018,
                SoldAmount = 759
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2018,
                SoldAmount = 983
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2019,
                SoldAmount = 871
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2019,
                SoldAmount = 1361
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2019,
                SoldAmount = 1973
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2019,
                SoldAmount = 1588
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2019,
                SoldAmount = 1911
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2019,
                SoldAmount = 483
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2019,
                SoldAmount = 965
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2019,
                SoldAmount = 997
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2019,
                SoldAmount = 51
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2019,
                SoldAmount = 688
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2019,
                SoldAmount = 5
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2019,
                SoldAmount = 489
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2020,
                SoldAmount = 1508
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2020,
                SoldAmount = 881
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2020,
                SoldAmount = 902
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2020,
                SoldAmount = 980
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2020,
                SoldAmount = 645
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2020,
                SoldAmount = 875
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2020,
                SoldAmount = 1676
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2020,
                SoldAmount = 846
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2020,
                SoldAmount = 1271
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2020,
                SoldAmount = 294
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2020,
                SoldAmount = 300
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2020,
                SoldAmount = 283
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2001,
                SoldAmount = 728
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2001,
                SoldAmount = 1930
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2001,
                SoldAmount = 1026
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2001,
                SoldAmount = 371
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2001,
                SoldAmount = 722
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2001,
                SoldAmount = 84
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2001,
                SoldAmount = 1827
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2001,
                SoldAmount = 1470
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2001,
                SoldAmount = 672
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2001,
                SoldAmount = 1390
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2001,
                SoldAmount = 272
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2001,
                SoldAmount = 1490
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2002,
                SoldAmount = 214
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2002,
                SoldAmount = 1012
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2002,
                SoldAmount = 694
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2002,
                SoldAmount = 443
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2002,
                SoldAmount = 958
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2002,
                SoldAmount = 1939
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2002,
                SoldAmount = 312
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2002,
                SoldAmount = 1866
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2002,
                SoldAmount = 460
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2002,
                SoldAmount = 1650
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2002,
                SoldAmount = 1480
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2002,
                SoldAmount = 9
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2003,
                SoldAmount = 1080
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2003,
                SoldAmount = 111
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2003,
                SoldAmount = 1082
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2003,
                SoldAmount = 948
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2003,
                SoldAmount = 54
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2003,
                SoldAmount = 1299
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2003,
                SoldAmount = 1212
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2003,
                SoldAmount = 493
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2003,
                SoldAmount = 943
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2003,
                SoldAmount = 1336
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2003,
                SoldAmount = 1872
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2003,
                SoldAmount = 1281
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2004,
                SoldAmount = 1457
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2004,
                SoldAmount = 469
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2004,
                SoldAmount = 119
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2004,
                SoldAmount = 139
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2004,
                SoldAmount = 1738
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2004,
                SoldAmount = 143
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2004,
                SoldAmount = 946
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2004,
                SoldAmount = 1305
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2004,
                SoldAmount = 1608
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2004,
                SoldAmount = 1868
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2004,
                SoldAmount = 603
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2004,
                SoldAmount = 737
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2005,
                SoldAmount = 701
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2005,
                SoldAmount = 1032
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2005,
                SoldAmount = 980
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2005,
                SoldAmount = 595
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2005,
                SoldAmount = 838
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2005,
                SoldAmount = 1468
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2005,
                SoldAmount = 311
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2005,
                SoldAmount = 827
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2005,
                SoldAmount = 776
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2005,
                SoldAmount = 435
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2005,
                SoldAmount = 882
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2005,
                SoldAmount = 1141
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2006,
                SoldAmount = 1316
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2006,
                SoldAmount = 441
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2006,
                SoldAmount = 862
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2006,
                SoldAmount = 64
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2006,
                SoldAmount = 450
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2006,
                SoldAmount = 53
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2006,
                SoldAmount = 412
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2006,
                SoldAmount = 1136
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2006,
                SoldAmount = 398
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2006,
                SoldAmount = 965
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2006,
                SoldAmount = 339
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2006,
                SoldAmount = 525
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2007,
                SoldAmount = 1582
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2007,
                SoldAmount = 1400
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2007,
                SoldAmount = 937
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2007,
                SoldAmount = 304
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2007,
                SoldAmount = 1211
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2007,
                SoldAmount = 680
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2007,
                SoldAmount = 1379
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2007,
                SoldAmount = 331
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2007,
                SoldAmount = 1354
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2007,
                SoldAmount = 806
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2007,
                SoldAmount = 1281
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2007,
                SoldAmount = 1016
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2008,
                SoldAmount = 538
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2008,
                SoldAmount = 396
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2008,
                SoldAmount = 1644
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2008,
                SoldAmount = 1861
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2008,
                SoldAmount = 859
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2008,
                SoldAmount = 964
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2008,
                SoldAmount = 1257
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2008,
                SoldAmount = 112
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2008,
                SoldAmount = 174
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2008,
                SoldAmount = 1500
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2008,
                SoldAmount = 1626
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2008,
                SoldAmount = 1141
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2009,
                SoldAmount = 1325
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2009,
                SoldAmount = 128
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2009,
                SoldAmount = 612
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2009,
                SoldAmount = 456
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2009,
                SoldAmount = 1083
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2009,
                SoldAmount = 293
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2009,
                SoldAmount = 636
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2009,
                SoldAmount = 1227
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2009,
                SoldAmount = 1894
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2009,
                SoldAmount = 1455
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2009,
                SoldAmount = 1308
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2009,
                SoldAmount = 423
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2010,
                SoldAmount = 613
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2010,
                SoldAmount = 119
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2010,
                SoldAmount = 1435
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2010,
                SoldAmount = 1885
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2010,
                SoldAmount = 1156
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2010,
                SoldAmount = 368
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2010,
                SoldAmount = 1759
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2010,
                SoldAmount = 734
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2010,
                SoldAmount = 226
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2010,
                SoldAmount = 1761
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2010,
                SoldAmount = 97
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2010,
                SoldAmount = 529
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2011,
                SoldAmount = 1044
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2011,
                SoldAmount = 1159
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2011,
                SoldAmount = 970
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2011,
                SoldAmount = 1389
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2011,
                SoldAmount = 1625
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2011,
                SoldAmount = 1907
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2011,
                SoldAmount = 158
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2011,
                SoldAmount = 965
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2011,
                SoldAmount = 949
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2011,
                SoldAmount = 1942
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2011,
                SoldAmount = 1455
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2011,
                SoldAmount = 811
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2012,
                SoldAmount = 140
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2012,
                SoldAmount = 1181
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2012,
                SoldAmount = 1501
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2012,
                SoldAmount = 1139
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2012,
                SoldAmount = 260
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2012,
                SoldAmount = 1132
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2012,
                SoldAmount = 937
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2012,
                SoldAmount = 1764
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2012,
                SoldAmount = 987
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2012,
                SoldAmount = 1447
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2012,
                SoldAmount = 560
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2012,
                SoldAmount = 1521
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2013,
                SoldAmount = 245
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2013,
                SoldAmount = 1977
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2013,
                SoldAmount = 1909
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2013,
                SoldAmount = 676
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2013,
                SoldAmount = 829
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2013,
                SoldAmount = 535
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2013,
                SoldAmount = 577
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2013,
                SoldAmount = 321
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2013,
                SoldAmount = 705
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2013,
                SoldAmount = 1440
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2013,
                SoldAmount = 1578
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2013,
                SoldAmount = 1416
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2014,
                SoldAmount = 1812
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2014,
                SoldAmount = 1289
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2014,
                SoldAmount = 1398
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2014,
                SoldAmount = 899
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2014,
                SoldAmount = 1724
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2014,
                SoldAmount = 1596
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2014,
                SoldAmount = 685
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2014,
                SoldAmount = 598
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2014,
                SoldAmount = 1212
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2014,
                SoldAmount = 1657
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2014,
                SoldAmount = 147
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2014,
                SoldAmount = 1257
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2015,
                SoldAmount = 602
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2015,
                SoldAmount = 1595
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2015,
                SoldAmount = 835
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2015,
                SoldAmount = 242
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2015,
                SoldAmount = 1063
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2015,
                SoldAmount = 1830
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2015,
                SoldAmount = 1722
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2015,
                SoldAmount = 1342
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2015,
                SoldAmount = 665
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2015,
                SoldAmount = 1302
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2015,
                SoldAmount = 187
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2015,
                SoldAmount = 1037
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2016,
                SoldAmount = 1911
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2016,
                SoldAmount = 1626
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2016,
                SoldAmount = 82
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2016,
                SoldAmount = 781
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2016,
                SoldAmount = 917
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2016,
                SoldAmount = 1756
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2016,
                SoldAmount = 1667
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2016,
                SoldAmount = 1454
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2016,
                SoldAmount = 1230
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2016,
                SoldAmount = 1063
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2016,
                SoldAmount = 1792
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2016,
                SoldAmount = 1287
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2017,
                SoldAmount = 476
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2017,
                SoldAmount = 1027
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2017,
                SoldAmount = 1379
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2017,
                SoldAmount = 1217
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2017,
                SoldAmount = 1870
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2017,
                SoldAmount = 1161
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2017,
                SoldAmount = 1909
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2017,
                SoldAmount = 148
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2017,
                SoldAmount = 723
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2017,
                SoldAmount = 139
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2017,
                SoldAmount = 764
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2017,
                SoldAmount = 614
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2018,
                SoldAmount = 1146
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2018,
                SoldAmount = 529
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2018,
                SoldAmount = 1917
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2018,
                SoldAmount = 1042
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2018,
                SoldAmount = 1516
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2018,
                SoldAmount = 1695
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2018,
                SoldAmount = 1273
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2018,
                SoldAmount = 525
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2018,
                SoldAmount = 137
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2018,
                SoldAmount = 828
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2018,
                SoldAmount = 745
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2018,
                SoldAmount = 158
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2019,
                SoldAmount = 1524
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2019,
                SoldAmount = 1316
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2019,
                SoldAmount = 329
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2019,
                SoldAmount = 1466
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2019,
                SoldAmount = 1520
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2019,
                SoldAmount = 1625
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2019,
                SoldAmount = 1431
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2019,
                SoldAmount = 1614
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2019,
                SoldAmount = 477
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2019,
                SoldAmount = 1624
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2019,
                SoldAmount = 1328
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2019,
                SoldAmount = 1483
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2020,
                SoldAmount = 1101
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2020,
                SoldAmount = 1508
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2020,
                SoldAmount = 1912
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2020,
                SoldAmount = 572
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2020,
                SoldAmount = 1580
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2020,
                SoldAmount = 959
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2020,
                SoldAmount = 1006
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2020,
                SoldAmount = 1965
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2020,
                SoldAmount = 1231
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2020,
                SoldAmount = 501
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2020,
                SoldAmount = 1557
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2020,
                SoldAmount = 588
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2001,
                SoldAmount = 1450
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2001,
                SoldAmount = 1571
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2001,
                SoldAmount = 1758
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2001,
                SoldAmount = 390
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2001,
                SoldAmount = 1389
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2001,
                SoldAmount = 1295
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2001,
                SoldAmount = 1810
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2001,
                SoldAmount = 1678
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2001,
                SoldAmount = 1023
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2001,
                SoldAmount = 1079
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2001,
                SoldAmount = 1176
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2001,
                SoldAmount = 1932
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2002,
                SoldAmount = 1265
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2002,
                SoldAmount = 764
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2002,
                SoldAmount = 261
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2002,
                SoldAmount = 1969
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2002,
                SoldAmount = 1503
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2002,
                SoldAmount = 1191
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2002,
                SoldAmount = 478
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2002,
                SoldAmount = 640
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2002,
                SoldAmount = 87
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2002,
                SoldAmount = 956
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2002,
                SoldAmount = 673
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2002,
                SoldAmount = 458
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2003,
                SoldAmount = 1131
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Gaming Console",
                Year = 2003,
                SoldAmount = 1151
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2003,
                SoldAmount = 159
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2003,
                SoldAmount = 1886
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Handbag",
                Year = 2003,
                SoldAmount = 1707
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Mobile",
                Year = 2003,
                SoldAmount = 502
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2003,
                SoldAmount = 30
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Furniture",
                Year = 2003,
                SoldAmount = 1915
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Apparel",
                Year = 2003,
                SoldAmount = 458
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "PC",
                Year = 2003,
                SoldAmount = 1350
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Cosmetics",
                Year = 2003,
                SoldAmount = 197
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Home Decor",
                Year = 2003,
                SoldAmount = 912
            },
            new ProductSales {
                ProductType = "Fashion",
                Product = "Watch",
                Year = 2004,
                SoldAmount = 1184
            },
            new ProductSales {
                ProductType = "Electronics",
                Product = "Laptop",
                Year = 2004,
                SoldAmount = 1805
            },
            new ProductSales {
                ProductType = "Beauty and Personal Care",
                Product = "Fragrance",
                Year = 2004,
                SoldAmount = 1940
            },
            new ProductSales {
                ProductType = "Household",
                Product = "Kitchenware",
                Year = 2004,
                SoldAmount = 1188
            }
        };
    }
}
