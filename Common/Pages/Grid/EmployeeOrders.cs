#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

namespace blazor_employeeorders
{   
  public class EmployeeOrders
    {
        public EmployeeOrders()
        {

        }
        public EmployeeOrders(int OrderID, string CustomerId, int EmployeeId, DateTime OrderDate, DateTime RequiredDate, DateTime ShippedDate, double Freight, string ShipName, string ShipAddress, string ShipCity, string ShipRegion,string ShipPostalCode, string ShipCountry)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerId;
            this.EmployeeID = EmployeeId;
            this.Freight = Freight;
            this.ShipCity = ShipCity;            
            this.OrderDate = OrderDate;
            this.ShipName = ShipName;
            this.ShipCountry = ShipCountry;
            this.ShippedDate = ShippedDate;
            this.RequiredDate = RequiredDate;           
            this.ShipAddress = ShipAddress;
            this.ShipRegion = ShipRegion;
            this.ShipPostalCode = ShipPostalCode;
        }

        public static List<EmployeeOrders> GetAllRecords()
        {

            List<EmployeeOrders> order = new List<EmployeeOrders>();
            order.Add(new EmployeeOrders(10248, "VINET", 5, new DateTime(2023, 8, 1), new DateTime(2023, 4, 1), new DateTime(2023, 5, 1), 32.38, "Vins et alcools Chevalier", "59 rue de l'Abbaye", "Reims", "null", "51100", "France"));
            order.Add(new EmployeeOrders(10249, "TOMSP", 6, new DateTime(2023, 8, 2), new DateTime(2023, 4, 2), new DateTime(2023, 5, 2), 11.61, "Toms Spezialitäten", "Luisenstr. 48", "Münster", "null", "44087", "Germany"));
            order.Add(new EmployeeOrders(10250, "HANAR", 4, new DateTime(2023, 8, 3), new DateTime(2023, 4, 3), new DateTime(2023, 5, 3), 65.83, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
            order.Add(new EmployeeOrders(10251, "VICTE", 3, new DateTime(2023, 8, 4), new DateTime(2023, 4, 4), new DateTime(2023, 5, 4), 41.34, "Victuailles en stock", "2, rue du Commerce", "Lyon", "null", "69004", "France"));
            order.Add(new EmployeeOrders(10252, "SUPRD", 4, new DateTime(2023, 8, 5), new DateTime(2023, 4, 5), new DateTime(2023, 5, 5), 51.3, "Suprêmes délices", "Boulevard Tirou, 255", "Charleroi", "null", "B-6000", "Belgium"));
            order.Add(new EmployeeOrders(10253, "HANAR", 3, new DateTime(2023, 8, 6), new DateTime(2023, 4, 6), new DateTime(2023, 5, 6), 58.17, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
            order.Add(new EmployeeOrders(10254, "CHOPS", 5, new DateTime(2023, 8, 7), new DateTime(2023, 4, 7), new DateTime(2023, 5, 7), 22.98, "Chop-suey Chinese", "Hauptstr. 31", "Bern", "null", "3012", "Switzerland"));
            order.Add(new EmployeeOrders(10255, "RICSU", 9, new DateTime(2023, 8, 8), new DateTime(2023, 4, 8), new DateTime(2023, 5, 8), 148.33, "Richter Supermarkt", "Starenweg 5", "Genève", "null", "1204", "Switzerland"));
            order.Add(new EmployeeOrders(10256, "WELLI", 3, new DateTime(2023, 8, 9), new DateTime(2023, 4, 9), new DateTime(2023, 5, 9), 13.97, "Wellington Importadora", "Rua do Mercado, 12", "Resende", "SP", "08737-363", "Brazil"));
            order.Add(new EmployeeOrders(10257, "HILAA", 4, new DateTime(2023, 8, 10), new DateTime(2023, 4, 10), new DateTime(2023, 5, 11), 81.91, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
            order.Add(new EmployeeOrders(10258, "ERNSH", 1, new DateTime(2023, 8, 11), new DateTime(2023, 4, 11), new DateTime(2023, 5, 12), 140.51, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10259, "CENTC", 4, new DateTime(2023, 8, 12), new DateTime(2023, 4, 12), new DateTime(2023, 5, 12), 3.25, "Centro comercial Moctezuma", "Sierras de Granada 9993", "México D.F.", "null", "05022", "Mexico"));
            order.Add(new EmployeeOrders(10260, "OTTIK", 4, new DateTime(2023, 8, 13), new DateTime(2023, 4, 13), new DateTime(2023, 5, 13), 55.09, "Ottilies Käseladen", "Mehrheimerstr. 369", "Köln", "null", "50739", "Germany"));
            order.Add(new EmployeeOrders(10261, "QUEDE", 4, new DateTime(2023, 8, 14), new DateTime(2023, 4, 14), new DateTime(2023, 5, 14), 3.05, "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"));
            order.Add(new EmployeeOrders(10262, "RATTC", 8, new DateTime(2023, 8, 15), new DateTime(2023, 4, 15), new DateTime(2023, 5, 15), 48.29, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
            order.Add(new EmployeeOrders(10263, "ERNSH", 9, new DateTime(2023, 8, 16), new DateTime(2023, 4, 16), new DateTime(2023, 5, 16), 146.06, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10264, "FOLKO", 6, new DateTime(2023, 8, 17), new DateTime(2023, 4, 17), new DateTime(2023, 5, 17), 3.67, "Folk och fä HB", "Åkergatan 24", "Bräcke", "null", "S-844 67", "Sweden"));
            order.Add(new EmployeeOrders(10265, "BLONP", 2, new DateTime(2023, 8, 18), new DateTime(2023, 4, 18), new DateTime(2023, 5, 18), 55.28, "Blondel père et fils", "24, place Kléber", "Strasbourg", "null", "67000", "France"));
            order.Add(new EmployeeOrders(10266, "WARTH", 3, new DateTime(2023, 8, 19), new DateTime(2023, 4, 19), new DateTime(2023, 5, 19), 25.73, "Wartian Herkku", "Torikatu 38", "Oulu", "null", "90110", "Finland"));
            order.Add(new EmployeeOrders(10267, "FRANK", 4, new DateTime(2023, 8, 20), new DateTime(2023, 4, 20), new DateTime(2023, 5, 20), 208.58, "Frankenversand", "Berliner Platz 43", "München", "null", "80805", "Germany"));
            order.Add(new EmployeeOrders(10268, "GROSR", 8, new DateTime(2023, 8, 21), new DateTime(2023, 4, 21), new DateTime(2023, 5, 21), 66.29, "GROSELLA-Restaurante", "5ª Ave. Los Palos Grandes", "Caracas", "DF", "1081", "Venezuela"));
            order.Add(new EmployeeOrders(10269, "WHITC", 5, new DateTime(2023, 8, 22), new DateTime(2023, 4, 22), new DateTime(2023, 5, 22), 4.56, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
            order.Add(new EmployeeOrders(10270, "WARTH", 1, new DateTime(2023, 8, 23), new DateTime(2023, 4, 23), new DateTime(2023, 5, 23), 136.54, "Wartian Herkku", "Torikatu 38", "Oulu", "null", "90110", "Finland"));
            order.Add(new EmployeeOrders(10271, "SPLIR", 6, new DateTime(2023, 8, 24), new DateTime(2023, 4, 24), new DateTime(2023, 5, 24), 4.54, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
            order.Add(new EmployeeOrders(10272, "RATTC", 6, new DateTime(2023, 8, 25), new DateTime(2023, 4, 25), new DateTime(2023, 5, 25), 98.03, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
            order.Add(new EmployeeOrders(10273, "QUICK", 3, new DateTime(2023, 8, 26), new DateTime(2023, 4, 26), new DateTime(2023, 5, 26), 76.07, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", "null", "01307", "Germany"));
            order.Add(new EmployeeOrders(10274, "VINET", 6, new DateTime(2023, 8, 27), new DateTime(2023, 4, 27), new DateTime(2023, 5, 27), 6.01, "Vins et alcools Chevalier", "59 rue de l'Abbaye", "Reims", "null", "51100", "France"));
            order.Add(new EmployeeOrders(10275, "MAGAA", 1, new DateTime(2023, 8, 28), new DateTime(2023, 4, 28), new DateTime(2023, 5, 28), 26.93, "Magazzini Alimentari Riuniti", "Via Ludovico il Moro 22", "Bergamo", "null", "24100", "Italy"));
            order.Add(new EmployeeOrders(10276, "TORTU", 8, new DateTime(2023, 8, 29), new DateTime(2023, 4, 29), new DateTime(2023, 5, 29), 13.84, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", "null", "05033", "Mexico"));
            order.Add(new EmployeeOrders(10277, "MORGK", 2, new DateTime(2023, 8, 30), new DateTime(2023, 4, 30), new DateTime(2023, 5, 30), 125.77, "Morgenstern Gesundkost", "Heerstr. 22", "Leipzig", "null", "04179", "Germany"));
            order.Add(new EmployeeOrders(10278, "BERGS", 8, new DateTime(2023, 8, 31), new DateTime(2023, 4, 5), new DateTime(2023, 6, 1), 92.69, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", "null", "S-958 22", "Sweden"));
            order.Add(new EmployeeOrders(10279, "LEHMS", 8, new DateTime(2023, 8, 1), new DateTime(2023, 3, 4), new DateTime(2023, 6, 2), 25.83, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", "null", "60528", "Germany"));
            order.Add(new EmployeeOrders(10280, "BERGS", 2, new DateTime(2023, 8, 2), new DateTime(2023, 2, 3), new DateTime(2023, 6, 3), 8.98, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", "null", "S-958 22", "Sweden"));
            order.Add(new EmployeeOrders(10281, "ROMEY", 4, new DateTime(2023, 8, 3), new DateTime(2023, 1, 2), new DateTime(2023, 6, 4), 2.94, "Romero y tomillo", "Gran Vía, 1", "Madrid", "null", "28001", "Spain"));
            order.Add(new EmployeeOrders(10282, "ROMEY", 4, new DateTime(2023, 8, 4), new DateTime(2023, 2, 1), new DateTime(2023, 6, 5), 12.69, "Romero y tomillo", "Gran Vía, 1", "Madrid", "null", "28001", "Spain"));
            order.Add(new EmployeeOrders(10283, "LILAS", 3, new DateTime(2023, 8, 5), new DateTime(2023, 3, 2), new DateTime(2023, 6, 6), 84.81, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
            order.Add(new EmployeeOrders(10284, "LEHMS", 4, new DateTime(2023, 8, 6), new DateTime(2023, 4, 3), new DateTime(2023, 8, 7), 76.56, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", "null", "60528", "Germany"));
            order.Add(new EmployeeOrders(10285, "QUICK", 1, new DateTime(2023, 8, 7), new DateTime(2023, 5, 4), new DateTime(2023, 8, 8), 76.83, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", "null", "01307", "Germany"));
            order.Add(new EmployeeOrders(10286, "QUICK", 8, new DateTime(2023, 8, 8), new DateTime(2023, 6, 5), new DateTime(2023, 8, 9), 229.24, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", "null", "01307", "Germany"));
            order.Add(new EmployeeOrders(10287, "RICAR", 8, new DateTime(2023, 8, 9), new DateTime(2023, 7, 6), new DateTime(2023, 8, 10), 12.76, "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil"));
            order.Add(new EmployeeOrders(10288, "REGGC", 4, new DateTime(2023, 8, 10), new DateTime(2023, 8, 7), new DateTime(2023, 8, 11), 7.45, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", "null", "42100", "Italy"));
            order.Add(new EmployeeOrders(10289, "BSBEV", 7, new DateTime(2023, 8, 11), new DateTime(2023, 9, 8), new DateTime(2023, 8, 12), 22.77, "B's Beverages", "Fauntleroy Circus", "London", "null", "EC2 5NT", "UK"));
            order.Add(new EmployeeOrders(10290, "COMMI", 8, new DateTime(2023, 8, 12), new DateTime(2023, 10, 9), new DateTime(2023, 8, 13), 79.7, "Comércio Mineiro", "Av. dos Lusíadas, 23", "Sao Paulo", "SP", "05432-043", "Brazil"));
            order.Add(new EmployeeOrders(10291, "QUEDE", 6, new DateTime(2023, 8, 13), new DateTime(2023, 11, 10), new DateTime(2023, 8, 14), 6.4, "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"));
            order.Add(new EmployeeOrders(10292, "TRADH", 1, new DateTime(2023, 8, 14), new DateTime(2023, 12, 11), new DateTime(2023, 8, 15), 1.35, "Tradiçao Hipermercados", "Av. Inês de Castro, 414", "Sao Paulo", "SP", "05634-030", "Brazil"));
            order.Add(new EmployeeOrders(10293, "TORTU", 1, new DateTime(2023, 8, 15), new DateTime(2023, 1, 12), new DateTime(2023, 8, 16), 21.18, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", "null", "05033", "Mexico"));
            order.Add(new EmployeeOrders(10294, "RATTC", 4, new DateTime(2023, 8, 16), new DateTime(2023, 8, 13), new DateTime(2023, 8, 17), 147.26, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
            order.Add(new EmployeeOrders(10295, "VINET", 2, new DateTime(2023, 8, 17), new DateTime(2023, 5, 14), new DateTime(2023, 8, 18), 1.15, "Vins et alcools Chevalier", "59 rue de l'Abbaye", "Reims", "null", "51100", "France"));
            order.Add(new EmployeeOrders(10296, "LILAS", 6, new DateTime(2023, 8, 18), new DateTime(2023, 8, 15), new DateTime(2023, 8, 19), 0.12, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
            order.Add(new EmployeeOrders(10297, "BLONP", 5, new DateTime(2023, 8, 19), new DateTime(2023, 8, 16), new DateTime(2023, 8, 20), 5.74, "Blondel père et fils", "24, place Kléber", "Strasbourg", "null", "67000", "France"));
            order.Add(new EmployeeOrders(10298, "HUNGO", 6, new DateTime(2023, 8, 20), new DateTime(2023, 8, 17), new DateTime(2023, 8, 21), 168.22, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", "null", "Ireland"));
            order.Add(new EmployeeOrders(10299, "RICAR", 4, new DateTime(2023, 8, 21), new DateTime(2023, 8, 18), new DateTime(2023, 8, 22), 29.76, "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil"));
            order.Add(new EmployeeOrders(10300, "MAGAA", 2, new DateTime(2023, 8, 22), new DateTime(2023, 8, 19), new DateTime(2023, 8, 23), 17.68, "Magazzini Alimentari Riuniti", "Via Ludovico il Moro 22", "Bergamo", "null", "24100", "Italy"));
            order.Add(new EmployeeOrders(10301, "WANDK", 8, new DateTime(2023, 8, 23), new DateTime(2023, 8, 20), new DateTime(2023, 8, 24), 45.08, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", "null", "70563", "Germany"));
            order.Add(new EmployeeOrders(10302, "SUPRD", 4, new DateTime(2023, 8, 24), new DateTime(2023, 8, 21), new DateTime(2023, 8, 25), 6.27, "Suprêmes délices", "Boulevard Tirou, 255", "Charleroi", "null", "B-6000", "Belgium"));
            order.Add(new EmployeeOrders(10303, "GODOS", 7, new DateTime(2023, 8, 25), new DateTime(2023, 8, 22), new DateTime(2023, 8, 26), 107.83, "Godos Cocina Típica", "C/ Romero, 33", "Sevilla", "null", "41101", "Spain"));
            order.Add(new EmployeeOrders(10304, "TORTU", 1, new DateTime(2023, 8, 26), new DateTime(2023, 8, 24), new DateTime(2023, 8, 27), 63.79, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", "null", "05033", "Mexico"));
            order.Add(new EmployeeOrders(10305, "OLDWO", 8, new DateTime(2023, 8, 27), new DateTime(2023, 8, 23), new DateTime(2023, 8, 28), 257.62, "Old World Delicatessen", "2743 Bering St.", "Anchorage", "AK", "99508", "USA"));
            order.Add(new EmployeeOrders(10306, "ROMEY", 1, new DateTime(2023, 8, 28), new DateTime(2023, 8, 24), new DateTime(2023, 8, 29), 7.56, "Romero y tomillo", "Gran Vía, 1", "Madrid", "null", "28001", "Spain"));
            order.Add(new EmployeeOrders(10307, "LONEP", 2, new DateTime(2023, 8, 29), new DateTime(2023, 8, 25), new DateTime(2023, 8, 30), 0.56, "Lonesome Pine Restaurant", "89 Chiaroscuro Rd.", "Portland", "OR", "97219", "USA"));
            order.Add(new EmployeeOrders(10308, "ANATR", 7, new DateTime(2023, 8, 30), new DateTime(2023, 8, 26), new DateTime(2023, 8, 10), 1.61, "Ana Trujillo Emparedados y helados", "Avda. de la Constitución 2222", "México D.F.", "null", "05021", "Mexico"));
            order.Add(new EmployeeOrders(10309, "HUNGO", 3, new DateTime(2023, 9, 1), new DateTime(2023, 8, 27), new DateTime(2023, 2, 9), 47.3, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", "null", "Ireland"));
            order.Add(new EmployeeOrders(10310, "THEBI", 8, new DateTime(2023, 9, 2), new DateTime(2023, 8, 28), new DateTime(2023, 2, 8), 17.52, "The Big Cheese", "89 Jefferson Way Suite 2", "Portland", "OR", "97201", "USA"));
            order.Add(new EmployeeOrders(10311, "DUMON", 1, new DateTime(2023, 9, 3), new DateTime(2023, 8, 29), new DateTime(2023, 2, 7), 24.69, "Du monde entier", "67, rue des Cinquante Otages", "Nantes", "null", "44000", "France"));
            order.Add(new EmployeeOrders(10312, "WANDK", 2, new DateTime(2023, 9, 4), new DateTime(2023, 8, 30), new DateTime(2023, 2, 6), 40.26, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", "null", "70563", "Germany"));
            order.Add(new EmployeeOrders(10313, "QUICK", 2, new DateTime(2023, 9, 5), new DateTime(2023, 7, 5), new DateTime(2023, 2, 5), 1.96, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", "null", "01307", "Germany"));
            order.Add(new EmployeeOrders(10314, "RATTC", 1, new DateTime(2023, 9, 6), new DateTime(2023, 7, 4), new DateTime(2023, 2, 4), 74.16, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
            order.Add(new EmployeeOrders(10315, "ISLAT", 4, new DateTime(2023, 9, 7), new DateTime(2023, 7, 3), new DateTime(2023, 2, 3), 41.76, "Island Trading", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK"));
            order.Add(new EmployeeOrders(10316, "RATTC", 1, new DateTime(2023, 9, 8), new DateTime(2023, 7, 5), new DateTime(2023, 2, 2), 150.15, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
            order.Add(new EmployeeOrders(10317, "LONEP", 6, new DateTime(2023, 9, 9), new DateTime(2023, 7, 2), new DateTime(2023, 2, 1), 12.69, "Lonesome Pine Restaurant", "89 Chiaroscuro Rd.", "Portland", "OR", "97219", "USA"));
            order.Add(new EmployeeOrders(10318, "ISLAT", 8, new DateTime(2023, 9, 10), new DateTime(2023, 7, 15), new DateTime(2023, 3, 10), 4.73, "Island Trading", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK"));
            order.Add(new EmployeeOrders(10319, "TORTU", 7, new DateTime(2023, 9, 11), new DateTime(2023, 7, 1), new DateTime(2023, 4, 10), 64.5, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", "null", "05033", "Mexico"));
            order.Add(new EmployeeOrders(10320, "WARTH", 5, new DateTime(2023, 9, 12), new DateTime(2023, 7, 2), new DateTime(2023, 5, 10), 34.57, "Wartian Herkku", "Torikatu 38", "Oulu", "null", "90110", "Finland"));
            order.Add(new EmployeeOrders(10321, "ISLAT", 3, new DateTime(2023, 9, 13), new DateTime(2023, 7, 3), new DateTime(2023, 6, 10), 3.43, "Island Trading", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK"));
            order.Add(new EmployeeOrders(10322, "PERIC", 7, new DateTime(2023, 9, 14), new DateTime(2023, 7, 3), new DateTime(2023, 7, 10), 0.4, "Pericles Comidas clásicas", "Calle Dr. Jorge Cash 321", "México D.F.", "null", "05033", "Mexico"));
            order.Add(new EmployeeOrders(10323, "KOENE", 4, new DateTime(2023, 9, 15), new DateTime(2023, 7, 4), new DateTime(2023, 8, 10), 4.88, "Königlich Essen", "Maubelstr. 90", "Brandenburg", "null", "14776", "Germany"));
            order.Add(new EmployeeOrders(10324, "SAVEA", 9, new DateTime(2023, 9, 16), new DateTime(2023, 7, 5), new DateTime(2023, 9, 10), 214.27, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
            order.Add(new EmployeeOrders(10325, "KOENE", 1, new DateTime(2023, 9, 17), new DateTime(2023, 7, 6), new DateTime(2023, 10, 10), 64.86, "Königlich Essen", "Maubelstr. 90", "Brandenburg", "null", "14776", "Germany"));
            order.Add(new EmployeeOrders(10326, "BOLID", 4, new DateTime(2023, 9, 18), new DateTime(2023, 7, 7), new DateTime(2023, 11, 10), 77.92, "Bólido Comidas preparadas", "C/ Araquil, 67", "Madrid", "null", "28023", "Spain"));
            order.Add(new EmployeeOrders(10327, "FOLKO", 2, new DateTime(2023, 9, 19), new DateTime(2023, 7, 8), new DateTime(2023, 12, 10), 63.36, "Folk och fä HB", "Åkergatan 24", "Bräcke", "null", "S-844 67", "Sweden"));
            order.Add(new EmployeeOrders(10328, "FURIB", 4, new DateTime(2023, 9, 20), new DateTime(2023, 7, 9), new DateTime(2023, 1, 1), 87.03, "Furia Bacalhau e Frutos do Mar", "Jardim das rosas n. 32", "Lisboa", "null", "1675", "Portugal"));
            order.Add(new EmployeeOrders(10329, "SPLIR", 4, new DateTime(2023, 9, 21), new DateTime(2023, 7, 10), new DateTime(2023, 2, 10), 191.67, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
            order.Add(new EmployeeOrders(10330, "LILAS", 3, new DateTime(2023, 9, 22), new DateTime(2023, 7, 11), new DateTime(2023, 2, 11), 12.75, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
            order.Add(new EmployeeOrders(10331, "BONAP", 9, new DateTime(2023, 9, 23), new DateTime(2023, 7, 12), new DateTime(2023, 3, 12), 10.19, "Bon app'", "12, rue des Bouchers", "Marseille", "null", "13008", "France"));
            order.Add(new EmployeeOrders(10332, "MEREP", 3, new DateTime(2023, 9, 24), new DateTime(2023, 7, 13), new DateTime(2023, 4, 13), 52.84, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
            order.Add(new EmployeeOrders(10333, "WARTH", 5, new DateTime(2023, 9, 25), new DateTime(2023, 7, 14), new DateTime(2023, 5, 13), 0.59, "Wartian Herkku", "Torikatu 38", "Oulu", "null", "90110", "Finland"));
            order.Add(new EmployeeOrders(10334, "VICTE", 8, new DateTime(2023, 9, 26), new DateTime(2023, 7, 15), new DateTime(2023, 6, 14), 8.56, "Victuailles en stock", "2, rue du Commerce", "Lyon", "null", "69004", "France"));
            order.Add(new EmployeeOrders(10335, "HUNGO", 7, new DateTime(2023, 9, 27), new DateTime(2023, 7, 16), new DateTime(2023, 7, 15), 42.11, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", "null", "Ireland"));
            order.Add(new EmployeeOrders(10336, "PRINI", 7, new DateTime(2023, 9, 28), new DateTime(2023, 8, 11), new DateTime(2023, 8, 16), 15.51, "Princesa Isabel Vinhos", "Estrada da saúde n. 58", "Lisboa", "null", "1756", "Portugal"));
            order.Add(new EmployeeOrders(10337, "FRANK", 4, new DateTime(2023, 9, 29), new DateTime(2023, 8, 17), new DateTime(2023, 9, 17), 108.26, "Frankenversand", "Berliner Platz 43", "München", "null", "80805", "Germany"));
            order.Add(new EmployeeOrders(10338, "OLDWO", 4, new DateTime(2023, 9, 30), new DateTime(2023, 8, 18), new DateTime(2023, 10, 18), 84.21, "Old World Delicatessen", "2743 Bering St.", "Anchorage", "AK", "99508", "USA"));
            order.Add(new EmployeeOrders(10339, "MEREP", 2, new DateTime(2023, 8, 1), new DateTime(2023, 8, 19), new DateTime(2023, 8, 19), 15.66, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
            order.Add(new EmployeeOrders(10340, "BONAP", 1, new DateTime(2023, 8, 2), new DateTime(2023, 8, 20), new DateTime(2023, 8, 20), 166.31, "Bon app'", "12, rue des Bouchers", "Marseille", "null", "13008", "France"));
            order.Add(new EmployeeOrders(10341, "SIMOB", 7, new DateTime(2023, 8, 3), new DateTime(2023, 8, 5), new DateTime(2023, 8, 21), 26.78, "Simons bistro", "Vinbæltet 34", "Kobenhavn", "null", "1734", "Denmark"));
            order.Add(new EmployeeOrders(10342, "FRANK", 4, new DateTime(2023, 8, 4), new DateTime(2023, 8, 4), new DateTime(2023, 8, 22), 54.83, "Frankenversand", "Berliner Platz 43", "München", "null", "80805", "Germany"));
            order.Add(new EmployeeOrders(10343, "LEHMS", 4, new DateTime(2023, 8, 5), new DateTime(2023, 8, 3), new DateTime(2023, 8, 23), 110.37, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", "null", "60528", "Germany"));
            order.Add(new EmployeeOrders(10344, "WHITC", 4, new DateTime(2023, 8, 6), new DateTime(2023, 8, 2), new DateTime(2023, 8, 24), 23.29, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
            order.Add(new EmployeeOrders(10345, "QUICK", 2, new DateTime(2023, 8, 7), new DateTime(2023, 8, 15), new DateTime(2023, 8, 20), 249.06, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", "null", "01307", "Germany"));
            order.Add(new EmployeeOrders(10346, "RATTC", 3, new DateTime(2023, 8, 8), new DateTime(2023, 8, 23), new DateTime(2023, 8, 1), 142.08, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
            order.Add(new EmployeeOrders(10347, "FAMIA", 4, new DateTime(2023, 8, 9), new DateTime(2023, 8, 2), new DateTime(2023, 8, 12), 3.1, "Familia Arquibaldo", "Rua Orós, 92", "Sao Paulo", "SP", "05442-030", "Brazil"));
            order.Add(new EmployeeOrders(10348, "WANDK", 4, new DateTime(2023, 8, 10), new DateTime(2023, 8, 13), new DateTime(2023, 8, 13), 0.78, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", "null", "70563", "Germany"));
            order.Add(new EmployeeOrders(10349, "SPLIR", 7, new DateTime(2023, 8, 11), new DateTime(2023, 8, 12), new DateTime(2023, 8, 14), 8.63, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
            order.Add(new EmployeeOrders(10350, "LAMAI", 6, new DateTime(2023, 8, 12), new DateTime(2023, 8, 6), new DateTime(2023, 8, 16), 64.19, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", "null", "31000", "France"));
            order.Add(new EmployeeOrders(10351, "ERNSH", 1, new DateTime(2023, 8, 13), new DateTime(2023, 8, 1), new DateTime(2023, 8, 18), 162.33, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10352, "FURIB", 3, new DateTime(2023, 8, 14), new DateTime(2023, 8, 8), new DateTime(2023, 8, 12), 1.3, "Furia Bacalhau e Frutos do Mar", "Jardim das rosas n. 32", "Lisboa", "null", "1675", "Portugal"));
            order.Add(new EmployeeOrders(10353, "PICCO", 7, new DateTime(2023, 8, 15), new DateTime(2023, 8, 9), new DateTime(2023, 8, 15), 360.63, "Piccolo und mehr", "Geislweg 14", "Salzburg", "null", "5020", "Austria"));
            order.Add(new EmployeeOrders(10354, "PERIC", 8, new DateTime(2023, 8, 16), new DateTime(2023, 8, 11), new DateTime(2023, 8, 9), 53.8, "Pericles Comidas clásicas", "Calle Dr. Jorge Cash 321", "México D.F.", "null", "05033", "Mexico"));
            order.Add(new EmployeeOrders(10355, "AROUT", 6, new DateTime(2023, 8, 17), new DateTime(2023, 8, 12), new DateTime(2023, 8, 8), 41.95, "Around the Horn", "Brook Farm Stratford St. Mary", "Colchester", "Essex", "CO7 6JX", "UK"));
            order.Add(new EmployeeOrders(10356, "WANDK", 6, new DateTime(2023, 8, 18), new DateTime(2023, 8, 23), new DateTime(2023, 8, 7), 36.71, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", "null", "70563", "Germany"));
            order.Add(new EmployeeOrders(10357, "LILAS", 1, new DateTime(2023, 8, 19), new DateTime(2023, 8, 5), new DateTime(2023, 1, 1), 34.88, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
            order.Add(new EmployeeOrders(10358, "LAMAI", 5, new DateTime(2023, 8, 20), new DateTime(2023, 8, 6), new DateTime(2023, 1, 2), 19.64, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", "null", "31000", "France"));
            order.Add(new EmployeeOrders(10359, "SEVES", 5, new DateTime(2023, 8, 21), new DateTime(2023, 8, 7), new DateTime(2023, 1, 3), 288.43, "Seven Seas Imports", "90 Wadhurst Rd.", "London", "null", "OX15 4NB", "UK"));
            order.Add(new EmployeeOrders(10360, "BLONP", 4, new DateTime(2023, 8, 22), new DateTime(2023, 8, 8), new DateTime(2023, 1, 4), 131.7, "Blondel père et fils", "24, place Kléber", "Strasbourg", "null", "67000", "France"));
            order.Add(new EmployeeOrders(10361, "QUICK", 1, new DateTime(2023, 8, 23), new DateTime(2023, 8, 9), new DateTime(2023, 1, 5), 183.17, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", "null", "01307", "Germany"));
            order.Add(new EmployeeOrders(10362, "BONAP", 3, new DateTime(2023, 8, 24), new DateTime(2023, 8, 15), new DateTime(2023, 1, 6), 96.04, "Bon app'", "12, rue des Bouchers", "Marseille", "null", "13008", "France"));
            order.Add(new EmployeeOrders(10363, "DRACD", 4, new DateTime(2023, 8, 25), new DateTime(2023, 8, 18), new DateTime(2023, 1, 7), 30.54, "Drachenblut Delikatessen", "Walserweg 21", "Aachen", "null", "52066", "Germany"));
            order.Add(new EmployeeOrders(10364, "EASTC", 1, new DateTime(2023, 8, 26), new DateTime(2023, 8, 17), new DateTime(2023, 1, 8), 71.97, "Eastern Connection", "35 King George", "London", "null", "WX3 6FW", "UK"));
            order.Add(new EmployeeOrders(10365, "ANTON", 3, new DateTime(2023, 8, 27), new DateTime(2023, 8, 2), new DateTime(2023, 1, 9), 22, "Antonio Moreno Taquería", "Mataderos  2312", "México D.F.", "null", "05023", "Mexico"));
            order.Add(new EmployeeOrders(10366, "GALED", 8, new DateTime(2023, 8, 28), new DateTime(2023, 8, 3), new DateTime(2023, 1, 10), 10.14, "Galería del gastronómo", "Rambla de Cataluña, 23", "Barcelona", "null", "8022", "Spain"));
            order.Add(new EmployeeOrders(10367, "VAFFE", 7, new DateTime(2023, 8, 29), new DateTime(2023, 8, 4), new DateTime(2023, 1, 11), 13.55, "Vaffeljernet", "Smagsloget 45", "Århus", "null", "8200", "Denmark"));
            order.Add(new EmployeeOrders(10368, "ERNSH", 2, new DateTime(2023, 8, 30), new DateTime(2023, 8, 5), new DateTime(2023, 1, 12), 101.95, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10369, "SPLIR", 8, new DateTime(2023, 10, 11), new DateTime(2023, 8, 6), new DateTime(2023, 1, 13), 195.68, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
            order.Add(new EmployeeOrders(10370, "CHOPS", 6, new DateTime(2023, 11, 10), new DateTime(2023, 8, 7), new DateTime(2023, 1, 14), 1.17, "Chop-suey Chinese", "Hauptstr. 31", "Bern", "null", "3012", "Switzerland"));
            order.Add(new EmployeeOrders(10371, "LAMAI", 1, new DateTime(2023, 12, 21), new DateTime(2023, 8, 8), new DateTime(2023, 1, 15), 0.45, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", "null", "31000", "France"));
            order.Add(new EmployeeOrders(10372, "QUEEN", 5, new DateTime(2023, 1, 7), new DateTime(2023, 8, 9), new DateTime(2023, 9, 16), 890.78, "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil"));
            order.Add(new EmployeeOrders(10373, "HUNGO", 4, new DateTime(2023, 2, 6), new DateTime(2023, 8, 10), new DateTime(2023, 9, 17), 124.12, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", "null", "Ireland"));
            order.Add(new EmployeeOrders(10374, "WOLZA", 1, new DateTime(2023, 3, 5), new DateTime(2023, 8, 11), new DateTime(2023, 9, 18), 3.94, "Wolski Zajazd", "ul. Filtrowa 68", "Warszawa", "null", "01-012", "Poland"));
            order.Add(new EmployeeOrders(10375, "HUNGC", 3, new DateTime(2023, 4, 4), new DateTime(2023, 8, 12), new DateTime(2023, 9, 19), 20.12, "Hungry Coyote Import Store", "City Center Plaza 516 Main St.", "Elgin", "OR", "97827", "USA"));
            order.Add(new EmployeeOrders(10376, "MEREP", 1, new DateTime(2023, 5, 4), new DateTime(2023, 8, 13), new DateTime(2023, 9, 20), 20.39, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
            order.Add(new EmployeeOrders(10377, "SEVES", 1, new DateTime(2023, 6, 3), new DateTime(2023, 8, 14), new DateTime(2023, 9, 21), 22.21, "Seven Seas Imports", "90 Wadhurst Rd.", "London", "null", "OX15 4NB", "UK"));
            order.Add(new EmployeeOrders(10378, "FOLKO", 5, new DateTime(2023, 7, 2), new DateTime(2023, 8, 15), new DateTime(2023, 9, 22), 5.44, "Folk och fä HB", "Åkergatan 24", "Bräcke", "null", "S-844 67", "Sweden"));
            order.Add(new EmployeeOrders(10379, "QUEDE", 2, new DateTime(2023, 8, 1), new DateTime(2023, 8, 16), new DateTime(2023, 9, 23), 45.03, "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"));
            order.Add(new EmployeeOrders(10380, "HUNGO", 8, new DateTime(2023, 9, 11), new DateTime(2023, 8, 11), new DateTime(2023, 9, 24), 35.03, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", "null", "Ireland"));
            order.Add(new EmployeeOrders(10381, "LILAS", 3, new DateTime(2023, 10, 10), new DateTime(2023, 8, 15), new DateTime(2023, 9, 25), 7.99, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
            order.Add(new EmployeeOrders(10382, "ERNSH", 4, new DateTime(2023, 11, 9), new DateTime(2023, 8, 5), new DateTime(2023, 9, 26), 94.77, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10383, "AROUT", 8, new DateTime(2023, 12, 22), new DateTime(2023, 8, 3), new DateTime(2023, 9, 27), 34.24, "Around the Horn", "Brook Farm Stratford St. Mary", "Colchester", "Essex", "CO7 6JX", "UK"));
            order.Add(new EmployeeOrders(10384, "BERGS", 3, new DateTime(2023, 1, 2), new DateTime(2023, 2, 5), new DateTime(2023, 9, 28), 168.64, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", "null", "S-958 22", "Sweden"));
            order.Add(new EmployeeOrders(10385, "SPLIR", 1, new DateTime(2023, 4, 19), new DateTime(2023, 3, 5), new DateTime(2023, 9, 29), 30.96, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
            order.Add(new EmployeeOrders(10386, "FAMIA", 9, new DateTime(2023, 2, 1), new DateTime(2023, 4, 5), new DateTime(2023, 9, 30), 13.99, "Familia Arquibaldo", "Rua Orós, 92", "Sao Paulo", "SP", "05442-030", "Brazil"));
            order.Add(new EmployeeOrders(10387, "SANTG", 1, new DateTime(2023, 8, 2), new DateTime(2023, 5, 5), new DateTime(2023, 9, 1), 93.63, "Santé Gourmet", "Erling Skakkes gate 78", "Stavern", "null", "4110", "Norway"));
            order.Add(new EmployeeOrders(10388, "SEVES", 2, new DateTime(2023, 3, 3), new DateTime(2023, 6, 5), new DateTime(2023, 9, 2), 34.86, "Seven Seas Imports", "90 Wadhurst Rd.", "London", "null", "OX15 4NB", "UK"));
            order.Add(new EmployeeOrders(10389, "BOTTM", 4, new DateTime(2023, 4, 4), new DateTime(2023, 7, 5), new DateTime(2023, 9, 3), 47.42, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
            order.Add(new EmployeeOrders(10390, "ERNSH", 6, new DateTime(2023, 5, 5), new DateTime(2023, 8, 8), new DateTime(2023, 9, 4), 126.38, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10391, "DRACD", 3, new DateTime(2023, 6, 6), new DateTime(2023, 9, 9), new DateTime(2023, 9, 5), 5.45, "Drachenblut Delikatessen", "Walserweg 21", "Aachen", "null", "52066", "Germany"));
            order.Add(new EmployeeOrders(10392, "PICCO", 2, new DateTime(2023, 8, 7), new DateTime(2023, 10, 6), new DateTime(2023, 9, 6), 122.46, "Piccolo und mehr", "Geislweg 14", "Salzburg", "null", "5020", "Austria"));
            order.Add(new EmployeeOrders(10393, "SAVEA", 1, new DateTime(2023, 7, 8), new DateTime(2023, 3, 3), new DateTime(2023, 9, 7), 126.56, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
            order.Add(new EmployeeOrders(10394, "HUNGC", 1, new DateTime(2023, 9, 9), new DateTime(2023, 6, 2), new DateTime(2023, 9, 8), 30.34, "Hungry Coyote Import Store", "City Center Plaza 516 Main St.", "Elgin", "OR", "97827", "USA"));
            order.Add(new EmployeeOrders(10395, "HILAA", 6, new DateTime(2023, 1, 10), new DateTime(2023, 8, 5), new DateTime(2023, 9, 9), 184.41, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
            order.Add(new EmployeeOrders(10396, "FRANK", 1, new DateTime(2023, 2, 11), new DateTime(2023, 9, 5), new DateTime(2023, 9, 10), 135.35, "Frankenversand", "Berliner Platz 43", "München", "null", "80805", "Germany"));
            order.Add(new EmployeeOrders(10397, "PRINI", 5, new DateTime(2023, 3, 12), new DateTime(2023, 7, 10), new DateTime(2023, 9, 11), 60.26, "Princesa Isabel Vinhos", "Estrada da saúde n. 58", "Lisboa", "null", "1756", "Portugal"));
            order.Add(new EmployeeOrders(10398, "SAVEA", 2, new DateTime(2023, 4, 11), new DateTime(2023, 6, 9), new DateTime(2023, 8, 12), 89.16, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
            order.Add(new EmployeeOrders(10399, "VAFFE", 8, new DateTime(2023, 5, 13), new DateTime(2023, 5, 5), new DateTime(2023, 8, 13), 27.36, "Vaffeljernet", "Smagsloget 45", "Århus", "null", "8200", "Denmark"));
            order.Add(new EmployeeOrders(10400, "EASTC", 1, new DateTime(2023, 6, 14), new DateTime(2023, 4, 8), new DateTime(2023, 8, 14), 83.93, "Eastern Connection", "35 King George", "London", "null", "WX3 6FW", "UK"));
            order.Add(new EmployeeOrders(10401, "RATTC", 1, new DateTime(2023, 7, 15), new DateTime(2023, 3, 7), new DateTime(2023, 8, 15), 12.51, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
            order.Add(new EmployeeOrders(10402, "ERNSH", 8, new DateTime(2023, 8, 1), new DateTime(2023, 2, 6), new DateTime(2023, 8, 16), 67.88, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10403, "ERNSH", 4, new DateTime(2023, 9, 16), new DateTime(2023, 1, 5), new DateTime(2023, 8, 17), 73.79, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10404, "MAGAA", 2, new DateTime(2023, 10, 17), new DateTime(2023, 11, 5), new DateTime(2023, 8, 18), 155.97, "Magazzini Alimentari Riuniti", "Via Ludovico il Moro 22", "Bergamo", "null", "24100", "Italy"));
            order.Add(new EmployeeOrders(10405, "LINOD", 1, new DateTime(2023, 11, 11), new DateTime(2023, 10, 5), new DateTime(2023, 8, 19), 34.82, "LINO-Delicateses", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Nueva Esparta", "4980", "Venezuela"));
            order.Add(new EmployeeOrders(10406, "QUEEN", 7, new DateTime(2023, 12, 13), new DateTime(2023, 8, 5), new DateTime(2023, 8, 20), 108.04, "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil"));
            order.Add(new EmployeeOrders(10407, "OTTIK", 2, new DateTime(2023, 4, 1), new DateTime(2023, 4, 5), new DateTime(2023, 2, 21), 91.48, "Ottilies Käseladen", "Mehrheimerstr. 369", "Köln", "null", "50739", "Germany"));
            order.Add(new EmployeeOrders(10408, "FOLIG", 8, new DateTime(2023, 5, 2), new DateTime(2023, 4, 6), new DateTime(2023, 3, 22), 11.26, "Folies gourmandes", "184, chaussée de Tournai", "Lille", "null", "59000", "France"));
            order.Add(new EmployeeOrders(10409, "OCEAN", 3, new DateTime(2023, 6, 3), new DateTime(2023, 5, 4), new DateTime(2023, 4, 23), 29.83, "Océano Atlántico Ltda.", "Ing. Gustavo Moncada 8585 Piso 20-A", "Buenos Aires", "null", "1010", "Argentina"));
            order.Add(new EmployeeOrders(10410, "BOTTM", 3, new DateTime(2023, 7, 3), new DateTime(2023, 6, 8), new DateTime(2023, 5, 24), 2.4, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
            order.Add(new EmployeeOrders(10411, "BOTTM", 9, new DateTime(2023, 8, 4), new DateTime(2023, 7, 9), new DateTime(2023, 6, 25), 23.65, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
            order.Add(new EmployeeOrders(10412, "WARTH", 8, new DateTime(2023, 1, 5), new DateTime(2023, 8, 10), new DateTime(2023, 8, 26), 3.77, "Wartian Herkku", "Torikatu 38", "Oulu", "null", "90110", "Finland"));
            order.Add(new EmployeeOrders(10413, "LAMAI", 3, new DateTime(2023, 2, 6), new DateTime(2023, 9, 11), new DateTime(2023, 9, 27), 95.66, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", "null", "31000", "France"));
            order.Add(new EmployeeOrders(10414, "FAMIA", 2, new DateTime(2023, 3, 7), new DateTime(2023, 10, 12), new DateTime(2023, 1, 10), 21.48, "Familia Arquibaldo", "Rua Orós, 92", "Sao Paulo", "SP", "05442-030", "Brazil"));
            order.Add(new EmployeeOrders(10415, "HUNGC", 3, new DateTime(2023, 4, 7), new DateTime(2023, 11, 13), new DateTime(2023, 2, 15), 0.2, "Hungry Coyote Import Store", "City Center Plaza 516 Main St.", "Elgin", "OR", "97827", "USA"));
            order.Add(new EmployeeOrders(10416, "WARTH", 8, new DateTime(2023, 5, 8), new DateTime(2023, 12, 14), new DateTime(2023, 3, 12), 22.72, "Wartian Herkku", "Torikatu 38", "Oulu", "null", "90110", "Finland"));
            order.Add(new EmployeeOrders(10417, "SIMOB", 4, new DateTime(2023, 6, 9), new DateTime(2023, 1, 15), new DateTime(2023, 4, 6), 70.29, "Simons bistro", "Vinbæltet 34", "Kobenhavn", "null", "1734", "Denmark"));
            order.Add(new EmployeeOrders(10418, "QUICK", 4, new DateTime(2023, 7, 10), new DateTime(2023, 2, 16), new DateTime(2023, 4, 7), 17.55, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", "null", "01307", "Germany"));
            order.Add(new EmployeeOrders(10419, "RICSU", 4, new DateTime(2023, 8, 11), new DateTime(2023, 3, 5), new DateTime(2023, 6, 2), 137.35, "Richter Supermarkt", "Starenweg 5", "Genève", "null", "1204", "Switzerland"));
            order.Add(new EmployeeOrders(10420, "WELLI", 3, new DateTime(2023, 9, 12), new DateTime(2023, 4, 5), new DateTime(2023, 7, 10), 44.12, "Wellington Importadora", "Rua do Mercado, 12", "Resende", "SP", "08737-363", "Brazil"));
            order.Add(new EmployeeOrders(10421, "QUEDE", 8, new DateTime(2023, 10, 13), new DateTime(2023, 5, 5), new DateTime(2023, 7, 1), 99.23, "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"));
            order.Add(new EmployeeOrders(10422, "FRANS", 2, new DateTime(2023, 11, 14), new DateTime(2023, 6, 5), new DateTime(2023, 8, 16), 3.02, "Franchi S.p.A.", "Via Monte Bianco 34", "Torino", "null", "10100", "Italy"));
            order.Add(new EmployeeOrders(10423, "GOURL", 6, new DateTime(2023, 12, 15), new DateTime(2023, 8, 5), new DateTime(2023, 9, 14), 24.5, "Gourmet Lanchonetes", "Av. Brasil, 442", "Campinas", "SP", "04876-786", "Brazil"));
            order.Add(new EmployeeOrders(10424, "MEREP", 7, new DateTime(2023, 1, 16), new DateTime(2023, 1, 5), new DateTime(2023, 12, 15), 370.61, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
            order.Add(new EmployeeOrders(10425, "LAMAI", 6, new DateTime(2023, 2, 17), new DateTime(2023, 2, 5), new DateTime(2023, 11, 1), 7.93, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", "null", "31000", "France"));
            order.Add(new EmployeeOrders(10426, "GALED", 4, new DateTime(2023, 3, 18), new DateTime(2023, 3, 5), new DateTime(2023, 10, 5), 18.69, "Galería del gastronómo", "Rambla de Cataluña, 23", "Barcelona", "null", "8022", "Spain"));
            order.Add(new EmployeeOrders(10427, "PICCO", 4, new DateTime(2023, 4, 19), new DateTime(2023, 4, 5), new DateTime(2023, 9, 1), 31.29, "Piccolo und mehr", "Geislweg 14", "Salzburg", "null", "5020", "Austria"));
            order.Add(new EmployeeOrders(10428, "REGGC", 7, new DateTime(2023, 5, 11), new DateTime(2023, 5, 5), new DateTime(2023, 8, 3), 11.09, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", "null", "42100", "Italy"));
            order.Add(new EmployeeOrders(10429, "HUNGO", 3, new DateTime(2023, 7, 12), new DateTime(2023, 6, 5), new DateTime(2023, 7, 4), 56.63, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", "null", "Ireland"));
            order.Add(new EmployeeOrders(10430, "ERNSH", 4, new DateTime(2023, 6, 13), new DateTime(2023, 7, 5), new DateTime(2023, 6, 10), 458.78, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10431, "BOTTM", 4, new DateTime(2023, 5, 21), new DateTime(2023, 8, 5), new DateTime(2023, 5, 5), 44.17, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
            order.Add(new EmployeeOrders(10432, "SPLIR", 3, new DateTime(2023, 4, 22), new DateTime(2023, 9, 5), new DateTime(2023, 4, 16), 4.34, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
            order.Add(new EmployeeOrders(10433, "PRINI", 3, new DateTime(2023, 3, 1), new DateTime(2023, 10, 5), new DateTime(2023, 3, 13), 73.83, "Princesa Isabel Vinhos", "Estrada da saúde n. 58", "Lisboa", "null", "1756", "Portugal"));
            order.Add(new EmployeeOrders(10434, "FOLKO", 3, new DateTime(2023, 2, 2), new DateTime(2023, 11, 5), new DateTime(2023, 2, 18), 17.92, "Folk och fä HB", "Åkergatan 24", "Bräcke", "null", "S-844 67", "Sweden"));
            order.Add(new EmployeeOrders(10435, "CONSH", 8, new DateTime(2023, 8, 3), new DateTime(2023, 12, 5), new DateTime(2023, 10, 11), 9.21, "Consolidated Holdings", "Berkeley Gardens 12  Brewery", "London", "null", "WX1 6LT", "UK"));
            order.Add(new EmployeeOrders(10436, "BLONP", 3, new DateTime(2023, 12, 4), new DateTime(2023, 1, 5), new DateTime(2023, 1, 10), 156.66, "Blondel père et fils", "24, place Kléber", "Strasbourg", "null", "67000", "France"));
            order.Add(new EmployeeOrders(10437, "WARTH", 8, new DateTime(2023, 11, 5), new DateTime(2023, 2, 5), new DateTime(2023, 2, 2), 19.97, "Wartian Herkku", "Torikatu 38", "Oulu", "null", "90110", "Finland"));
            order.Add(new EmployeeOrders(10438, "TOMSP", 3, new DateTime(2023, 10, 6), new DateTime(2023, 3, 5), new DateTime(2023, 3, 3), 8.24, "Toms Spezialitäten", "Luisenstr. 48", "Münster", "null", "44087", "Germany"));
            order.Add(new EmployeeOrders(10439, "MEREP", 6, new DateTime(2023, 9, 7), new DateTime(2023, 4, 5), new DateTime(2023, 4, 4), 4.07, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
            order.Add(new EmployeeOrders(10440, "SAVEA", 4, new DateTime(2023, 7, 8), new DateTime(2023, 5, 5), new DateTime(2023, 5, 5), 86.53, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
            order.Add(new EmployeeOrders(10441, "OLDWO", 3, new DateTime(2023, 1, 9), new DateTime(2023, 6, 5), new DateTime(2023, 6, 10), 73.02, "Old World Delicatessen", "2743 Bering St.", "Anchorage", "AK", "99508", "USA"));
            order.Add(new EmployeeOrders(10442, "ERNSH", 3, new DateTime(2023, 2, 10), new DateTime(2023, 7, 5), new DateTime(2023, 7, 6), 47.94, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10443, "REGGC", 8, new DateTime(2023, 3, 11), new DateTime(2023, 8, 5), new DateTime(2023, 8, 7), 13.95, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", "null", "42100", "Italy"));
            order.Add(new EmployeeOrders(10444, "BERGS", 3, new DateTime(2023, 4, 12), new DateTime(2023, 9, 5), new DateTime(2023, 9, 11), 3.5, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", "null", "S-958 22", "Sweden"));
            order.Add(new EmployeeOrders(10445, "BERGS", 3, new DateTime(2023, 5, 13), new DateTime(2023, 10, 5), new DateTime(2023, 10, 20), 9.3, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", "null", "S-958 22", "Sweden"));
            order.Add(new EmployeeOrders(10446, "TOMSP", 6, new DateTime(2023, 6, 14), new DateTime(2023, 11, 5), new DateTime(2023, 11, 21), 14.68, "Toms Spezialitäten", "Luisenstr. 48", "Münster", "null", "44087", "Germany"));
            order.Add(new EmployeeOrders(10447, "RICAR", 4, new DateTime(2023, 7, 15), new DateTime(2023, 12, 5), new DateTime(2023, 12, 10), 68.66, "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil"));
            return order;
        }

        public int? OrderID { get; set; }
        public string? CustomerID { get; set; } 
        public int? EmployeeID { get; set; }
        public double? Freight { get; set; }
        public string? ShipCity { get; set; }   
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public string? ShipName { get; set; } 
        public string? ShipCountry { get; set; }
        public string? ShipPostalCode { get; set; }
        public string? ShipRegion { get; set; }
        public DateTime ShippedDate { get; set; }
        public string? ShipAddress { get; set; }
    }

}