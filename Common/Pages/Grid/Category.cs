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
namespace blazor_categorydata
{
    public class Category
    {

        public Category()
        {

        }
        public Category(string CategoryName, string ProductName, string QuantityPerUnit, bool Discontinued, short UnitsInStock)
        {

            this.CategoryName = CategoryName;
            this.ProductName = ProductName;
            this.QuantityPerUnit = QuantityPerUnit;
            this.UnitsInStock = UnitsInStock;
            this.Discontinued = Discontinued;
        }

        public static List<Category> GetAllRecords()
        {
            List<Category> category = new List<Category>();
            category.Add(new Category("Beverages", "Chai", "10 boxes x 20 bags", true, 39));
            category.Add(new Category("Beverages", "Chang", "24 - 12 oz bottles", true, 17));
            category.Add(new Category("Beverages", "Chartreuse verte", "750 cc per bottle", true, 69));
            category.Add(new Category("Beverages", "Cte de Blaye", "12 - 75 cl bottles", false, 17));
            category.Add(new Category("Beverages", "Ipoh Coffee", "16 - 500 g tins", true, 17));
            category.Add(new Category("Beverages", "Lakkalikri", "500 ml", true, 57));
            category.Add(new Category("Beverages", "Laughing Lumberjack Lager", "24 - 12 oz bottles", false, 52));
            category.Add(new Category("Beverages", "Outback Lager", "24 - 355 ml bottles", false, 15));
            category.Add(new Category("Beverages", "Rhnbru Klosterbier", "24 - 0.5 l bottles", false, 125));
            category.Add(new Category("Beverages", "Sasquatch Ale", "24 - 12 oz bottles", true, 111));
            category.Add(new Category("Beverages", "Steeleye Stout", "24 - 12 oz bottles", true, 20));
            category.Add(new Category("Condiments", "Aniseed Syrup", "12 - 550 ml bottles", true, 13));
            category.Add(new Category("Condiments", "Chef Anton's Cajun Seasoning", "48 - 6 oz jars", false, 53));
            category.Add(new Category("Condiments", "Genen Shouyu", "24 - 250 ml bottles", false, 39));
            category.Add(new Category("Condiments", "Grandma's Boysenberry Spread", "12 - 8 oz jars", false, 120));
            category.Add(new Category("Condiments", "Gula Malacca", "20 - 2 kg bags", true, 27));
            category.Add(new Category("Condiments", "Louisiana Fiery Hot Pepper Sauce", "32 - 8 oz bottles", false, 76));
            category.Add(new Category("Condiments", "Louisiana Hot Spiced Okra", "24 - 8 oz jars", false, 4));
            category.Add(new Category("Condiments", "Northwoods Cranberry Sauce", "12 - 12 oz jars", true, 6));
            category.Add(new Category("Condiments", "Original Frankfurter grne Soe", "12 boxes", false, 32));
            category.Add(new Category("Condiments", "Sirop d'rable", "24 - 500 ml bottles", false, 113));
            category.Add(new Category("Condiments", "Vegie-spread", "15 - 625 g jars", false, 24));
            category.Add(new Category("Confections", "Chocolade", "10 pkgs.", true, 15));
            category.Add(new Category("Confections", "Gumbr Gummibrchen", "100 - 250 g bags", false, 15));
            category.Add(new Category("Confections", "Maxilaku", "24 - 50 g pkgs.", false, 10));
            category.Add(new Category("Confections", "NuNuCa Nu-Nougat-Creme", "20 - 450 g glasses", true, 76));
            category.Add(new Category("Confections", "Pavlova", "32 - 500 g boxes", true, 29));
            category.Add(new Category("Confections", "Schoggi Schokolade", "100 - 100 g pieces", true, 49));
            category.Add(new Category("Confections", "Scottish Longbreads", "10 boxes x 8 pieces", true, 6));
            category.Add(new Category("Confections", "Sir Rodney's Marmalade", "30 gift boxes", true, 40));
            category.Add(new Category("Confections", "Sir Rodney's Scones", "24 pkgs. x 4 pieces", true, 3));
            category.Add(new Category("Confections", "Tarte au sucre", "48 pies", false, 17));
            category.Add(new Category("Confections", "Teatime Chocolate Biscuits", "10 boxes x 12 pieces", false, 25));
            category.Add(new Category("Confections", "Valkoinen suklaa", "12 - 100 g bars", false, 65));
            category.Add(new Category("Confections", "Zaanse koeken", "10 - 4 oz boxes", true, 36));
            category.Add(new Category("Dairy Categories", "Camembert Pierrot", "15 - 300 g rounds", false, 19));
            category.Add(new Category("Dairy Categories", "Flotemysost", "10 - 500 g pkgs.", false, 26));
            category.Add(new Category("Dairy Categories", "Geitost", "500 g", false, 112));
            category.Add(new Category("Dairy Categories", "Gorgonzola Telino", "12 - 100 g pkgs", true, 0));
            category.Add(new Category("Dairy Categories", "Gudbrandsdalsost", "10 kg pkg.", true, 26));
            category.Add(new Category("Dairy Categories", "Mascarpone Fabioli", "24 - 200 g pkgs.", true, 9));
            category.Add(new Category("Dairy Categories", "Mozzarella di Giovanni", "24 - 200 g pkgs.", true, 14));
            category.Add(new Category("Dairy Categories", "Queso Cabrales", "1 kg pkg.", true, 22));
            category.Add(new Category("Dairy Categories", "Queso Manchego La Pastora", "10 - 500 g pkgs.", true, 86));
            category.Add(new Category("Dairy Categories", "Raclette Courdavault", "5 kg pkg.", false, 79));
            category.Add(new Category("Grains/Cereals", "Filo Mix", "16 - 2 kg boxes", false, 38));
            category.Add(new Category("Grains/Cereals", "Gnocchi di nonna Alice", "24 - 250 g pkgs.", false, 21));
            category.Add(new Category("Grains/Cereals", "Gustaf's Knckebrd", "24 - 500 g pkgs.", true, 104));
            category.Add(new Category("Grains/Cereals", "Ravioli Angelo", "24 - 250 g pkgs.", true, 36));
            category.Add(new Category("Grains/Cereals", "Tunnbrd", "12 - 250 g pkgs.", true, 61));
            category.Add(new Category("Grains/Cereals", "Wimmers gute Semmelkndel", "20 bags x 4 pieces", true, 22));
            category.Add(new Category("Meat/Poultry", "Pt chinois", "24 boxes x 2 pies", false, 115));
            category.Add(new Category("Meat/Poultry", "Tourtire", "16 pies", false, 21));
            category.Add(new Category("Produce", "Longlife Tofu", "5 kg pkg.", false, 4));
            category.Add(new Category("Produce", "Manjimup Dried Apples", "50 - 300 g pkgs.", false, 20));
            category.Add(new Category("Produce", "Tofu", "40 - 100 g pkgs.", true, 35));
            category.Add(new Category("Produce", "Uncle Bob's Organic Dried Pears", "12 - 1 lb pkgs.", true, 15));
            category.Add(new Category("Seafood", "Boston Crab Meat", "24 - 4 oz tins", true, 123));
            category.Add(new Category("Seafood", "Carnarvon Tigers", "16 kg pkg.", true, 42));
            category.Add(new Category("Seafood", "Escargots de Bourgogne", "24 pieces", true, 62));
            category.Add(new Category("Seafood", "Gravad lax", "12 - 500 g pkgs.", true, 11));
            category.Add(new Category("Seafood", "Ikura", "12 - 200 ml jars", false, 31));
            category.Add(new Category("Seafood", "Inlagd Sill", "24 - 250 g  jars", false, 112));
            category.Add(new Category("Seafood", "Jack's New England Clam Chowder", "12 - 12 oz cans", false, 85));
            category.Add(new Category("Seafood", "Konbu", "2 kg box", false, 24));
            category.Add(new Category("Seafood", "Nord-Ost Matjeshering", "10 - 200 g glasses", false, 10));
            category.Add(new Category("Seafood", "Rd Kaviar", "24 - 150 g jars", false, 101));
            category.Add(new Category("Seafood", "Rogede sild", "1k pkg.", false, 5));
            category.Add(new Category("Seafood", "Spegesild", "4 - 450 g glasses", true, 95));
            return category;
        }

        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public short UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
    }
}
