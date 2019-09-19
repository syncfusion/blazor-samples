using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ej2_blazor_samples;
namespace ej2_blazor_griddata
{
    public class OrdersDetails
    {
        public OrdersDetails()
        {

        }
        public OrdersDetails(int OrderID, string CustomerId, int EmployeeId, double Freight, bool Verified, DateTime OrderDate, string ShipCity, string ShipName, string ShipCountry, DateTime ShippedDate, string ShipAddress)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerId;
            this.EmployeeID = EmployeeId;
            this.Freight = Freight;
            this.ShipCity = ShipCity;
            this.Verified = Verified;
            this.OrderDate = OrderDate;
            this.ShipName = ShipName;
            this.ShipCountry = ShipCountry;
            this.ShippedDate = ShippedDate;
            this.ShipAddress = ShipAddress;
        }
        public static List<OrdersDetails> GetAllRecords()
        {
            List<OrdersDetails> order = new List<OrdersDetails>();
            int code = 10000;
            for (int i = 1; i < 15; i++)
            {
                order.Add(new OrdersDetails(code + 1, "ALFKI", i + 0, 2.3 * i, false, new DateTime(1991, 05, 15), "Berlin", "Simons bistro", "Denmark", new DateTime(1996, 7, 16), "Kirchgasse 6"));
                order.Add(new OrdersDetails(code + 2, "ANATR", i + 2, 3.3 * i, true, new DateTime(1990, 04, 04), "Madrid", "Queen Cozinha", "Brazil", new DateTime(1996, 9, 11), "Avda. Azteca 123"));
                order.Add(new OrdersDetails(code + 3, "ANTON", i + 1, 4.3 * i, true, new DateTime(1957, 11, 30), "Cholchester", "Frankenversand", "Germany", new DateTime(1996, 10, 7), "Carrera 52 con Ave. Bolívar #65-98 Llano Largo"));
                order.Add(new OrdersDetails(code + 4, "BLONP", i + 3, 5.3 * i, false, new DateTime(1930, 10, 22), "Marseille", "Ernst Handel", "Austria", new DateTime(1996, 12, 30), "Magazinweg 7"));
                order.Add(new OrdersDetails(code + 5, "BOLID", i + 4, 6.3 * i, true, new DateTime(1953, 02, 18), "Tsawassen", "Hanari Carnes", "Switzerland", new DateTime(1997, 12, 3), "1029 - 12th Ave. S."));
                code += 5;
            }
            return order;
        }

        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public double? Freight { get; set; }
        public string ShipCity { get; set; }
        public bool Verified { get; set; }
        public DateTime OrderDate { get; set; }

        public string ShipName { get; set; }

        public string ShipCountry { get; set; }

        public DateTime ShippedDate { get; set; }
        public string ShipAddress { get; set; }
    }
    public class Orders
    {
        public Orders()
        {

        }
        public Orders(int OrderID, string CustomerId, int EmployeeId, decimal Freight, bool Verified, DateTime OrderDate, string ShipCity, string ShipName, string ShipCountry, DateTime ShippedDate, string ShipAddress)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerId;
            this.EmployeeID = EmployeeId;
            this.Freight = Freight;
            this.ShipCity = ShipCity;
            this.Verified = Verified;
            this.OrderDate = OrderDate;
            this.ShipName = ShipName;
            this.ShipCountry = ShipCountry;
            this.ShippedDate = ShippedDate;
            this.ShipAddress = ShipAddress;
        }
        public static List<Orders> GetAllRecords()
        {
            List<Orders> orders = new List<Orders>();
            int code = 10000;
            for (int i = 1; i < 15; i++)
            {
                orders.Add(new Orders(code + 1, "ALFKI", i + 0, 2.32m * i, false, new DateTime(1991, 05, 15), "Berlin", "Simons bistro", "Denmark", new DateTime(1996, 7, 16), "Kirchgasse 6"));
                orders.Add(new Orders(code + 2, "ANATR", i + 2, 3.32m * i, true, new DateTime(1990, 04, 04), "Madrid", "Queen Cozinha", "Brazil", new DateTime(1996, 9, 11), "Avda. Azteca 123"));
                orders.Add(new Orders(code + 3, "ANTON", i + 1, 4.35m * i, true, new DateTime(1957, 11, 30), "Cholchester", "Frankenversand", "Germany", new DateTime(1996, 10, 7), "Carrera 52 con Ave. Bolívar #65-98 Llano Largo"));
                orders.Add(new Orders(code + 4, "BLONP", i + 3, 5.38m * i, false, new DateTime(1930, 10, 22), "Marseille", "Ernst Handel", "Austria", new DateTime(1996, 12, 30), "Magazinweg 7"));
                orders.Add(new Orders(code + 5, "BOLID", i + 4, 6.35m * i, true, new DateTime(1953, 02, 18), "Tsawassen", "Hanari Carnes", "Switzerland", new DateTime(1997, 12, 3), "1029 - 12th Ave. S."));
                code += 5;
            }
            return orders;
        }

        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public decimal? Freight { get; set; }
        public string ShipCity { get; set; }
        public bool Verified { get; set; }
        public DateTime OrderDate { get; set; }

        public string ShipName { get; set; }

        public string ShipCountry { get; set; }

        public DateTime ShippedDate { get; set; }
        public string ShipAddress { get; set; }
    }

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
            category.Add(new Category("Dairy Categorys", "Camembert Pierrot", "15 - 300 g rounds", false, 19));
            category.Add(new Category("Dairy Categorys", "Flotemysost", "10 - 500 g pkgs.", false, 26));
            category.Add(new Category("Dairy Categorys", "Geitost", "500 g", false, 112));
            category.Add(new Category("Dairy Categorys", "Gorgonzola Telino", "12 - 100 g pkgs", true, 0));
            category.Add(new Category("Dairy Categorys", "Gudbrandsdalsost", "10 kg pkg.", true, 26));
            category.Add(new Category("Dairy Categorys", "Mascarpone Fabioli", "24 - 200 g pkgs.", true, 9));
            category.Add(new Category("Dairy Categorys", "Mozzarella di Giovanni", "24 - 200 g pkgs.", true, 14));
            category.Add(new Category("Dairy Categorys", "Queso Cabrales", "1 kg pkg.", true, 22));
            category.Add(new Category("Dairy Categorys", "Queso Manchego La Pastora", "10 - 500 g pkgs.", true, 86));
            category.Add(new Category("Dairy Categorys", "Raclette Courdavault", "5 kg pkg.", false, 79));
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

    public class Employee
    {
        public Employee()
        {

        }
        public Employee(int EmployeeID, string FirstName, string LastName, string Title, DateTime BirthDate, DateTime HireDate, int ReportsTo, string Address, string PostalCode, string Phone, string City, string Country)
        {
            this.EmployeeID = EmployeeID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Title = Title;
            this.BirthDate = BirthDate;
            this.HireDate = HireDate;
            this.ReportsTo = ReportsTo;
            this.Address = Address;
            this.PostalCode = PostalCode;
            this.Phone = Phone;
            this.City = City;
            this.Country = Country;

        }
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }

        public int ReportsTo { get; set; }

        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public static List<Employee> GetAllRecords()
        {
            List<Employee> Emp = new List<Employee>();
            Emp.Add(new Employee(1, "Nancy", "Davolio", "Sales Representative", new DateTime(1948, 12, 08), new DateTime(1992, 05, 01), 2, "507 - 20th Ave. E.Apt. 2A ", " 98122", "(206) 555-9857 ", "Seattle ", "USA"));
            Emp.Add(new Employee(2, "Andrew", "Fuller", "Vice President, Sales", new DateTime(1952, 02, 19), new DateTime(1992, 08, 14), 4, "908 W. Capital Way", "98401 ", "(206) 555-9482 ", "Kirkland ", "USA"));
            Emp.Add(new Employee(3, "Janet", "Leverling", "Sales Representative", new DateTime(1963, 08, 30), new DateTime(1992, 04, 01), 3, " 4110 Old Redmond Rd.", "98052 ", "(206) 555-8122", "Redmond ", "USA "));
            Emp.Add(new Employee(4, "Margaret", "Peacock", "Sales Representative", new DateTime(1937, 09, 19), new DateTime(1993, 05, 03), 6, "14 Garrett Hill ", "SW1 8JR ", "(71) 555-4848 ", "London ", "UK "));
            Emp.Add(new Employee(5, "Steven", "Buchanan", "Sales Manager", new DateTime(1955, 03, 04), new DateTime(1993, 10, 17), 8, "Coventry HouseMiner Rd. ", "EC2 7JR ", " (206) 555-8122", "Tacoma ", " USA"));
            Emp.Add(new Employee(6, "Michael", "Suyama", "Sales Representative", new DateTime(1963, 07, 02), new DateTime(1993, 10, 17), 2, " 7 Houndstooth Rd.", " WG2 7LT", "(71) 555-4444 ", "London ", "UK "));
            Emp.Add(new Employee(7, "Robert", "King", "Sales Representative", new DateTime(1960, 05, 29), new DateTime(1994, 01, 02), 7, "Edgeham HollowWinchester Way ", "RG1 9SP ", "(71) 555-5598 ", "London ", " UK"));
            Emp.Add(new Employee(8, "Laura", "Callahan", "Inside Sales Coordinator", new DateTime(1958, 01, 09), new DateTime(1994, 03, 05), 9, "722 Moss Bay Blvd. ", "98033 ", " (206) 555-3412", "Seattle ", "USA "));
            Emp.Add(new Employee(9, "Anne", "Dodsworth", "Sales Representative", new DateTime(1966, 01, 27), new DateTime(1994, 11, 15), 5, "4726 - 11th Ave. N.E. ", "98105 ", "(71) 555-5598 ", " London", "UK "));
            return Emp;
        }
    }

    public class VirtualData
    {
        public string Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
        public int Field8 { get; set; }
        public int Field9 { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field20 { get; set; }

        public VirtualData(string Field1, int Field2, int Field3, int Field4, int Field5, int Field6, int Field7
            , int Field8, int Field9, int Field10, int Field11, int Field12, int Field13, int Field14, int Field15,
            int Field16, int Field17, int Field18, int Field19, int Field20)
        {
            this.Field1 = Field1;
            this.Field2 = Field2;
            this.Field3 = Field3;
            this.Field4 = Field4;
            this.Field5 = Field5;
            this.Field6 = Field6;
            this.Field7 = Field7;
            this.Field8 = Field8;
            this.Field9 = Field9;
            this.Field10 = Field10;
            this.Field11 = Field11;
            this.Field12 = Field12;
            this.Field13 = Field13;
            this.Field14 = Field14;
            this.Field15 = Field15;
            this.Field16 = Field16;
            this.Field17 = Field17;
            this.Field18 = Field18;
            this.Field19 = Field19;
            this.Field20 = Field20;
        }

    }
}
