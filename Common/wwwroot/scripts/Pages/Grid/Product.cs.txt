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
using BlazorDemos;
namespace blazor_productdata
{
    public partial class Product
    {

        public Product()
        {

        }
        public Product(string QuantityPerUnit, string ProductName, int ProductID, int SupplierID, double UnitPrice, bool Discontinued, short UnitsInStock)
        {

            this.ProductID = ProductID;
            this.SupplierID = SupplierID;
            this.ProductName = ProductName;
            this.QuantityPerUnit = QuantityPerUnit;
            this.UnitsInStock = UnitsInStock;
            this.Discontinued = Discontinued;
            this.UnitPrice = UnitPrice;
        }

        public static List<Product> GetAllRecords()
        {
            List<Product> product = new List<Product>();
            product.Add(new Product("10 boxes x 20 bags", "Chai", 1, 1, 18, true, 39));
            product.Add(new Product("24 - 12 oz bottles", "Chang", 2, 1, 19, true, 17));
            product.Add(new Product("12 - 550 ml bottles", "Aniseed Syrup", 3, 1, 10, true, 13));
            product.Add(new Product("48 - 6 oz jars", "Chef Anton's Cajun Seasoning", 4, 2, 22, true, 53));
            product.Add(new Product("36 boxes", "Chef Anton's Gumbo Mix", 5, 2, 21.35, true, 0));
            product.Add(new Product("12 - 8 oz jars", "Grandma's Boysenberry Spread", 6, 3, 25, false, 120));
            product.Add(new Product("12 - 1 lb pkgs.", "Uncle Bob's Organic Dried Pears", 7, 3, 30, false, 15));
            product.Add(new Product("12 - 12 oz jars", "Northwoods Cranberry Sauce", 8, 3, 40, false, 6));
            product.Add(new Product("18 - 500 g pkgs.", "Mishi Kobe Niku", 9, 4, 97, true, 29));
            product.Add(new Product("12 - 200 ml jars", "Ikura", 10, 4, 31, false, 31));
            product.Add(new Product("1 kg pkg.", "Queso Cabrales", 11, 5, 21, false, 22));
            product.Add(new Product("10 - 500 g pkgs.", "Queso Manchego La Pastora", 12, 5, 38, false, 86));
            product.Add(new Product("2 kg box", "Konbu", 13, 6, 6, true, 24));
            product.Add(new Product("40 - 100 g pkgs.", "Tofu", 14, 6, 23.25, true, 35));
            product.Add(new Product("24 - 250 ml bottles", "Genen Shouyu", 15, 6, 15.5, true, 39));
            product.Add(new Product("32 - 500 g boxes", "Pavlova", 16, 7, 17.45, true, 29));
            product.Add(new Product("20 - 1 kg tins", "Alice Mutton", 17, 7, 39, true, 0));
            product.Add(new Product("16 kg pkg.", "Carnarvon Tigers", 18, 7, 62.5, false, 42));
            product.Add(new Product("10 boxes x 12 pieces", "Teatime Chocolate Biscuits", 19, 8, 9.2, false, 25));
            product.Add(new Product("30 gift boxes", "Sir Rodney's Marmalade", 20, 8, 81, false, 40));
            product.Add(new Product("24 pkgs. x 4 pieces", "Sir Rodney's Scones", 21, 8, 10, false, 3));
            product.Add(new Product("24 - 500 g pkgs.", "Gustaf's Knasdackebr", 22, 9, 21, false, 104));
            product.Add(new Product("12 - 250 g pkgs.", "Tunnbr", 23, 9, 9, false, 61));
            product.Add(new Product("12 - 355 ml cans", "Guaran¡ Fantstica", 24, 10, 4.5, true, 20));
            product.Add(new Product("20 - 450 g glasses", "NuNuCa NuNougat-Creme", 25, 11, 14, false, 76));
            product.Add(new Product("100 - 250 g bags", "Gumbr Gummibrchen", 26, 11, 31.23, true, 15));
            product.Add(new Product("100 - 100 g pieces", "Schoggi Schokolade", 27, 11, 43.9, true, 49));
            product.Add(new Product("25 - 825 g cans", "Rssle Sauerkraut", 28, 12, 45.6, true, 26));
            product.Add(new Product("50 bags x 30 sausages", "Thringer Rostbratwurst", 29, 12, 123.79, true, 0));
            product.Add(new Product("10 - 200 g glasses", "Nord-Ost Matjeshering", 30, 13, 25.89, true, 10));
            product.Add(new Product("12 - 100 g pkgs", "Gorgonzola Telino", 31, 14, 12.5, true, 0));
            product.Add(new Product("24 - 200 g pkgs.", "Mascarpone Fabioli", 32, 14, 32, false, 9));
            product.Add(new Product("500 g", "Geitost", 33, 15, 2.5, false, 112));
            product.Add(new Product("24 - 12 oz bottles", "Sasquatch Ale", 34, 16, 14, false, 111));
            product.Add(new Product("24 - 12 oz bottles", "Steeleye Stout", 35, 16, 18, false, 20));
            product.Add(new Product("24 - 250 g  jars", "Inlagd Sill", 36, 17, 19, false, 112));
            product.Add(new Product("12 - 500 g pkgs.", "Gravad lax", 37, 17, 26, false, 11));
            product.Add(new Product("12 - 75 cl bottles", "Cte de Blaye", 38, 18, 263.5, false, 17));
            product.Add(new Product("750 cc per bottle", "Chartreuse verte", 39, 18, 18, true, 69));
            product.Add(new Product("24 - 4 oz tins", "Boston Crab Meat", 40, 19, 18.4, true, 123));
            product.Add(new Product("12 - 12 oz cans", "Jack's New England Clam Chowder", 41, 19, 9.65, false, 85));
            product.Add(new Product("32 - 1 kg pkgs.", "Singaporean Hokkien Fried Mee", 42, 20, 14, true, 26));
            product.Add(new Product("16 - 500 g tins", "Ipoh Coffee", 43, 20, 46, false, 17));
            product.Add(new Product("20 - 2 kg bags", "Gula Malacca", 44, 20, 19.45, false, 27));
            product.Add(new Product("1k pkg.", "Rogede sild", 45, 21, 9.5, true, 5));
            product.Add(new Product("4 - 450 g glasses", "Spegesild", 46, 21, 12, true, 95));
            product.Add(new Product("10 - 4 oz boxes", "Zaanse koeken", 47, 22, 9.5, true, 36));
            product.Add(new Product("10 pkgs.", "Chocolade", 48, 22, 12.75, true, 15));
            product.Add(new Product("24 - 50 g pkgs.", "Maxilaku", 49, 23, 20, false, 10));
            product.Add(new Product("12 - 100 g bars", "Valkoinen suklaa", 50, 23, 16.25, false, 65));
            product.Add(new Product("50 - 300 g pkgs.", "Manjimup Dried Apples", 51, 24, 53, false, 20));
            product.Add(new Product("16 - 2 kg boxes", "Filo Mix", 52, 24, 7, true, 38));
            product.Add(new Product("48 pieces", "Perth Pasties", 53, 24, 32.8, true, 0));
            product.Add(new Product("16 pies", "Tourtire", 54, 25, 7.45, true, 21));
            product.Add(new Product("24 boxes x 2 pies", "Psda chinois", 55, 25, 24, true, 115));
            product.Add(new Product("24 - 250 g pkgs.", "Gnocchi di nonna Alice", 56, 26, 38, false, 21));
            product.Add(new Product("24 - 250 g pkgs.", "Ravioli Angelo", 57, 26, 19.5, false, 36));
            product.Add(new Product("24 pieces", "Escargots de Bourgogne", 58, 27, 13.25, false, 62));
            product.Add(new Product("5 kg pkg.", "Raclette Courdavault", 59, 28, 55, false, 79));
            product.Add(new Product("15 - 300 g rounds", "Camembert Pierrot", 60, 28, 34, false, 19));
            product.Add(new Product("24 - 500 ml bottles", "Sirop dable", 61, 29, 28.5, false, 113));
            product.Add(new Product("48 pies", "Tarte au sucre", 62, 29, 49.3, false, 17));
            product.Add(new Product("15 - 625 g jars", "Vegie-spread", 63, 7, 43.9, true, 24));
            product.Add(new Product("20 bags x 4 pieces", "Wimmers gute Semmelkdel", 64, 12, 33.25, true, 22));
            product.Add(new Product("32 - 8 oz bottles", "Louisiana Fiery Hot Pepper Sauce", 65, 2, 21.05, true, 76));
            product.Add(new Product("24 - 8 oz jars", "Louisiana Hot Spiced Okra", 66, 2, 17, false, 4));
            product.Add(new Product("24 - 12 oz bottles", "Laughing Lumberjack Lager", 67, 16, 14, false, 52));
            product.Add(new Product("10 boxes x 8 pieces", "Scottish Longbreads", 68, 8, 12.5, false, 6));
            product.Add(new Product("10 kg pkg.", "Gudbrandsdalsost", 69, 15, 36, false, 26));
            product.Add(new Product("24 - 355 ml bottles", "Outback Lager", 70, 7, 15, false, 15));
            product.Add(new Product("10 - 500 g pkgs.", "Flotemysost", 71, 15, 21.5, true, 26));
            product.Add(new Product("24 - 200 g pkgs.", "Mozzarella di Giovanni", 72, 14, 34.8, true, 14));
            product.Add(new Product("24 - 150 g jars", "Rsad Kaviar", 73, 17, 15, true, 101));
            product.Add(new Product("5 kg pkg.", "Longlife Tofu", 74, 4, 10, true, 4));
            product.Add(new Product("24 - 0.5 l bottles", "Rasas Klosterbier", 75, 12, 7.75, true, 125));
            product.Add(new Product("500 ml", "Lakkalikri", 76, 23, 18, true, 57));
            product.Add(new Product("12 boxes", "Original Frankfurter grasne Soe", 77, 12, 13, false, 32));
            return product;
        }

        public int SupplierID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public short UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
        public double UnitPrice { get; set; }
    }

}