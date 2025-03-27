#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;


namespace BlazorDemos.Model
{

    public class PivotProductDetails
    {
        public int Sold { get; set; }
        public double Amount { get; set; }
        public string Country { get; set; }
        public string Product_Categories { get; set; }
        public string Products { get; set; }
        public string Year { get; set; }

        public static List<PivotProductDetails> GetProductData()
        {
            List<PivotProductDetails> productData = new List<PivotProductDetails>();
            productData.Add(new PivotProductDetails { Sold = 413, Amount = 3493.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Year = "FY 2022" });
            productData.Add(new PivotProductDetails { Sold = 160, Amount = 2604.8, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Year = "FY 2023" });
            productData.Add(new PivotProductDetails { Sold = 199, Amount = 7696, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Year = "FY 2024" });
            productData.Add(new PivotProductDetails { Sold = 36, Amount = 568.08, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Year = "FY 2021" });
            productData.Add(new PivotProductDetails { Sold = 140, Amount = 1050, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Year = "FY 2024" });
            productData.Add(new PivotProductDetails { Sold = 166, Amount = 1245, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Year = "FY 2021" });
            productData.Add(new PivotProductDetails { Sold = 45, Amount = 202.5, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Year = "FY 2024" });
            productData.Add(new PivotProductDetails { Sold = 414, Amount = 4554, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Year = "FY 2021" });
            productData.Add(new PivotProductDetails { Sold = 38, Amount = 1168.5, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Year = "FY 2021" });
            productData.Add(new PivotProductDetails { Sold = 189, Amount = 5906.25, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Year = "FY 2022" });
            productData.Add(new PivotProductDetails { Sold = 236, Amount = 4484, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Year = "FY 2021" });
            productData.Add(new PivotProductDetails { Sold = 49, Amount = 955.5, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Year = "FY 2022" });
            productData.Add(new PivotProductDetails { Sold = 273, Amount = 5460, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Year = "FY 2023" });
            productData.Add(new PivotProductDetails { Sold = 280, Amount = 5390, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Year = "FY 2024" });
            productData.Add(new PivotProductDetails { Sold = 76, Amount = 113929, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Year = "FY 2022" });
            productData.Add(new PivotProductDetails { Sold = 67, Amount = 402.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Year = "FY 2024" });
            productData.Add(new PivotProductDetails { Sold = 103, Amount = 824, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Year = "FY 2021" });
            productData.Add(new PivotProductDetails { Sold = 247, Amount = 1543.75, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Year = "FY 2022" });
            productData.Add(new PivotProductDetails { Sold = 63, Amount = 1795.5, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Year = "FY 2023" });
            productData.Add(new PivotProductDetails { Sold = 463, Amount = 738485, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Year = "FY 2024" });
            productData.Add(new PivotProductDetails { Sold = 90, Amount = 143572.5, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Year = "FY 2021" });
            productData.Add(new PivotProductDetails { Sold = 165, Amount = 4785, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Year = "FY 2021" });
            productData.Add(new PivotProductDetails { Sold = 228, Amount = 3876, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Year = "FY 2022" });
            productData.Add(new PivotProductDetails { Sold = 93, Amount = 1488, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Year = "FY 2023" });
            productData.Add(new PivotProductDetails { Sold = 298, Amount = 9089, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Year = "FY 2023" });
            productData.Add(new PivotProductDetails { Sold = 261, Amount = 2871, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Year = "FY 2022" });
            productData.Add(new PivotProductDetails { Sold = 426, Amount = 1704, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Year = "FY 2022" });

            return productData;
        }
    }
}