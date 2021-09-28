using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BlazorDemos;
namespace blazor_griddata
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


    public class BugData
    {
        public BugData(string Name, String Priority, string Status, String AssignedTo, String Description, DateTime OpenedDays, int DaysOld, String BugSource, String AssociatedFeature, String CreatedBy, String NotificationStatus)
        {
            this.Name = Name;
            this.Priority = Priority;
            this.Status = Status;
            this.AssignedTo = AssignedTo;
            this.Description = Description;
            this.OpenedDays = OpenedDays;
            this.DaysOld = DaysOld;
            this.BugSource = BugSource;
            this.AssociatedFeature = AssociatedFeature;
            this.CreatedBy = CreatedBy;
            this.NotificationStatus = NotificationStatus;
        }
        public static List<BugData> GetAllBugData()
        {
            List<BugData> Datas = new List<BugData>();
            {
                Datas.Add(new BugData("Harder to work during power-saving mode", "High", "In Progress", "Tana", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", new DateTime(2019, 06, 15), 505, "Shared by unsigned user", "Battery", "Flynn", "Need to Notify"));
                Datas.Add(new BugData("Application crash on clicking save button", "High", "In Progress", " Ken", "Nulla quis sem at nibh elementum imperdiet. Duis sagittis ipsum.", new DateTime(2019, 06, 16), 504, "Found during testing", "Security", "Gillian", "Need to Notify"));

                Datas.Add(new BugData("Transaction details are lost", "High", "Completed", "Roger", " Praesent mauris. Fusce nec tellus sed augue semper porta. Mauris massa.", new DateTime(2019, 06, 15), 505, "Email issued from William (wiliam@example.com)", "Security", " Michael", "Already Notified"));


                Datas.Add(new BugData("  Working speed differs with different networks", "Low", "By Design", "Lucy", "Vestibulum lacinia arcu eget nulla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", new DateTime(2019, 06, 10), 500, "Reported by unsigned user", "Network", "Anton", "Already Notified"));

                Datas.Add(new BugData(" Does not handle Interrupts Properly", "Critical", "Completed", "Smith", "Curabitur sodales ligula in libero. Sed dignissim lacinia nunc. Curabitur tortor. ", new DateTime(2019, 06, 10), 500, "Found during internal testing", "Notifications", "Anton", "Already Notified"));

                Datas.Add(new BugData(" Takes more than 30 seconds to start", "High", "In Progress", "Lucy", "Pellentesque nibh. Aenean quam. In scelerisque sem at dolor. ", new DateTime(2019, 06, 5), 495, "Shared by customer call", "Speed", " Gillian", "Need to Notify"));

                Datas.Add(new BugData(" No progress indicator", "Critical", "Completed", "Smith", "Maecenas mattis. Sed convallis tristique sem. Proin ut ligula vel nunc egestas porttitor.", new DateTime(2019, 06, 5), 495, "Posted in community forum", "Notification", "Anton", "Already Notified"));

                Datas.Add(new BugData(" Words break when changing screen resolution", "Normal", "In Progress", "Joe", "Morbi lectus risus, iaculis vel, suscipit quis, luctus non, massa.", new DateTime(2019, 06, 15), 505, "Email issued from Jack (jack@example.com)", "Screen", "Isaac", "Need to Notify"));

                Datas.Add(new BugData("Download files to a private data directory", "Critical", "In Progress", "Jack", "Fusce ac turpis quis ligula lacinia aliquet. Mauris ipsum.", new DateTime(2019, 06, 15), 504, "Email issued from John (john@example.com)", " Security", "Bold", "Need to Notify"));

                Datas.Add(new BugData("Asking permission to access gallery", "Low", "By Design", "Nick", "Nunc feugiat mi a tellus consequat imperdiet. Vestibulum sapien. Proin quam. Etiam ultrices. Suspendisse in justo eu magna luctus suscipit.", new DateTime(2019, 06, 5), 490, "Posted in forum", "Security", "George", "Already Notified"));


                Datas.Add(new BugData("Data Leakage", "Critical", "In Progress", "John", "Integer euismod lacus luctus magna. Quisque cursus, metus vitae pharetra auctor, sem massa mattis sem.", new DateTime(2019, 06, 10), 500, "Found internally during testing", "Security", "Anton", "Need to Notify"));

                Datas.Add(new BugData("Installation error for previous Android versions", "Normal", "By Design", " Lewis", " Nulla metus metus, ullamcorper vel, tincidunt sed, euismod in, nibh. Quisque volutpat condimentum velit.", new DateTime(2019, 06, 15), 504, "Found during testing", "Android", "Kahn", "Already Notified"));


                Datas.Add(new BugData("Opens after the location is accessed", "Low", "Won't Fix", "Gibson", "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nam nec ante.", new DateTime(2019, 06, 5), 495, "Reported by unsigned user", "Security", "Herbert", "Already Notified"));

                Datas.Add(new BugData("Memory-related issue", "Normal", "In Progress", "Julie", "Sed lacinia, urna non tincidunt mattis, tortor neque adipiscing diam, a cursus ipsum ante quis turpis. Nulla facilisi. Ut fringilla.", new DateTime(2019, 06, 1), 480, "Posted in forum", " Memory", "Isaac", "Need to Notify"));

                Datas.Add(new BugData("Security questions are not working properly", "High", "Completed", "Lucy", "Sed lacinia, urna non tincidunt mattis, tortor neque adipiscing diam, a cursus ipsum ante quis turpis. Nulla facilisi.", new DateTime(2019, 06, 1), 480, " Email from Andrew (andrew@example.com)", "Security", "Wells", "Already Notified"));

                Datas.Add(new BugData("Requires a login after the connection lost its strength", "Low", "Can't Reproduce", "Issac", "Suspendisse potenti. Nunc feugiat mi a tellus consequat imperdiet. Vestibulum sapien. ", new DateTime(2019, 06, 15), 505, "Reported by unsigned user", "Speed", "Mary", "Already Notified"));


                Datas.Add(new BugData("The app crashes", "High", "In Progress", "John", "Nulla metus metus, ullamcorper vel, tincidunt sed, euismod in, nibh. Quisque volutpat condimentum velit.", new DateTime(2019, 06, 1), 485, "Email issued from Jack (jack@example.com)", "Security", "Anton", "Need to Notify"));

                Datas.Add(new BugData("Showing wrong error message", "Normal", "Blocked", "William", " Proin quam. Etiam ultrices. Suspendisse in justo eu magna luctus suscipit.", new DateTime(2019, 06, 10), 500, " Posted in community forum", "Notification", " Gillian", "Need to Notify"));

                Datas.Add(new BugData("Consumes more power when in battery-saving mode", "Critical", "In Progress", "John", "Sed lectus. Integer euismod lacus luctus magna. Quisque cursus, metus vitae pharetra auctor, sem massa mattis sem.", new DateTime(2019, 06, 15), 505, "Email issued from Joe (joe@example.com)", "Battery", "Anton", "Need to Notify"));

                Datas.Add(new BugData("Security level is low", "Critical", "In Progress", "Lucy", "Quisque volutpat condimentum velit, Integer euismod lacus luctus magna. Quisque cursus, luctus non, massa.", new DateTime(2019, 06, 20), 505, "Email issued from Issac (issac@example.com)", "Security", "Mary", "Already Notified"));




            }
            return Datas;
        }


        public string Name { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string AssignedTo { get; set; }
        public string Description { get; set; }
        public DateTime? OpenedDays { get; set; }
        public int? DaysOld { get; set; }

        public string BugSource { get; set; }
        public string AssociatedFeature { get; set; }
        public string CreatedBy { get; set; }
        public string NotificationStatus { get; set; }
    }
   
    public class OrderDetails
    {
        public OrderDetails()
        {

        }
        public OrderDetails(int OrderID, string CustomerId, int EmployeeId, double Freight,  DateTime OrderDate, string ShipCity, string ShipName, string ShipCountry, DateTime ShippedDate, string ShipAddress)
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
            this.ShipAddress = ShipAddress;
        }
       
        public static List<OrderDetails> GetAllRecords()
        {
            List<OrderDetails> order = new List<OrderDetails>();
            int code = 10000;
            for (int i = 1; i < 15; i++)
            {
                order.Add(new OrderDetails(code + 1, "ALFKI", i + 0, 2.3 * i,  new DateTime(1991, 05, 15), "Berlin", "Simons bistro", "Denmark", new DateTime(1996, 7, 16), "Kirchgasse 6"));
                order.Add(new OrderDetails(code + 2, "ANATR", i + 2, 3.3 * i,  new DateTime(1990, 04, 04), "Madrid", "Queen Cozinha", "Brazil", new DateTime(1996, 9, 11), "Avda. Azteca 123"));
                order.Add(new OrderDetails(code + 3, "ANTON", i + 1, 4.3 * i, new DateTime(1957, 11, 30), "Cholchester", "Frankenversand", "Germany", new DateTime(1996, 10, 7), "Carrera 52 con Ave. Bolívar #65-98 Llano Largo"));
                order.Add(new OrderDetails(code + 4, "BLONP", i + 3, 5.3 * i,  new DateTime(1930, 10, 22), "Marseille", "Ernst Handel", "Austria", new DateTime(1996, 12, 30), "Magazinweg 7"));
                order.Add(new OrderDetails(code + 5, "BOLID", i + 4, 6.3 * i, new DateTime(1953, 02, 18), "Tsawassen", "Hanari Carnes", "Switzerland", new DateTime(1997, 12, 3), "1029 - 12th Ave. S."));
                code += 5;
            }
            return order;
        }
       
        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public double? Freight { get; set; }
        public string ShipCity { get; set; }
       
        public DateTime? OrderDate { get; set; }

        public string ShipName { get; set; }

        public string ShipCountry { get; set; }

        public DateTime? ShippedDate { get; set; }
        public string ShipAddress { get; set; }
    }
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
                order.Add(new OrdersDetails(code + 1, "ALFKI", i + 0, 2.3 * i,false, new DateTime(1991, 05, 15), "Berlin", "Simons bistro", "Denmark", new DateTime(1996, 7, 16), "Kirchgasse 6"));
                order.Add(new OrdersDetails(code + 2, "ANATR", i + 2, 3.3 * i,true, new DateTime(1990, 04, 04), "Madrid", "Queen Cozinha", "Brazil", new DateTime(1996, 9, 11), "Avda. Azteca 123"));
                order.Add(new OrdersDetails(code + 3, "ANTON", i + 1, 4.3 * i,false, new DateTime(1957, 11, 30), "Cholchester", "Frankenversand", "Germany", new DateTime(1996, 10, 7), "Carrera 52 con Ave. Bolívar #65-98 Llano Largo"));
                order.Add(new OrdersDetails(code + 4, "BLONP", i + 3, 5.3 * i,true, new DateTime(1930, 10, 22), "Marseille", "Ernst Handel", "Austria", new DateTime(1996, 12, 30), "Magazinweg 7"));
                order.Add(new OrdersDetails(code + 5, "BOLID", i + 4, 6.3 * i,false, new DateTime(1953, 02, 18), "Tsawassen", "Hanari Carnes", "Switzerland", new DateTime(1997, 12, 3), "1029 - 12th Ave. S."));
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
        public DateTime? OrderDate { get; set; }

        public string ShipName { get; set; }

        public string ShipCountry { get; set; }

        public DateTime? ShippedDate { get; set; }
        public string ShipAddress { get; set; }
    }
    public class OverviewData
    {
        public OverviewData()
        {

        }

        public static List<OverviewData> GetAllRecords(int DataCount)
        {
            string[] employees =  {
        "Michael", "Kathryn", "Tamer", "Martin", "Davolio", "Nancy", "Fuller", "Leverling", "Peacock",
        "Margaret", "Buchanan", "Janet", "Andrew", "Callahan", "Laura", "Dodsworth", "Anne",
        "Bergs", "Vinet", "Anton", "Fleet", "Zachery", "Van", "King", "Jack", "Rose"};



            string[] designation = { "Manager", "CFO", "Designer", "Developer", "Program Director", "System Analyst", "Project Lead" };



            string[] mail = { "sample.com", "arpy.com", "rpy.com", "mail.com", "jourrapide.com" };
            string[] location = { "UK", "USA", "Sweden", "France", "Canada", "Argentina", "Austria", "Germany", "Mexico" };
            string[] status = { "Active", "Inactive" };
            string[] trustworthiness = { "Perfect", "Sufficient", "Insufficient" };



            string[] address = {"59 rue de lAbbaye", "Luisenstr. 48", "Rua do Paço, 67", "2, rue du Commerce", "Boulevard Tirou, 255",
        "Rua do mailPaço, 67", "Hauptstr. 31", "Starenweg 5", "Rua do Mercado, 12",
        "Carrera 22 con Ave. Carlos Soublette #8-35", "Kirchgasse 6",
        "Sierras de Granada 9993", "Mehrheimerstr. 369", "Rua da Panificadora, 12", "2817 Milton Dr.", "Kirchgasse 6",
        "Åkergatan 24", "24, place Kléber", "Torikatu 38", "Berliner Platz 43", "5ª Ave. Los Palos Grandes", "1029 - 12th Ave. S.",
        "Torikatu 38", "P.O. Box 555", "2817 Milton Dr.", "Taucherstraße 10", "59 rue de lAbbaye", "Via Ludovico il Moro 22",
        "Avda. Azteca 123", "Heerstr. 22", "Berguvsvägen  8", "Magazinweg 7", "Berguvsvägen  8", "Gran Vía, 1", "Gran Vía, 1",
        "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Magazinweg 7", "Taucherstraße 10", "Taucherstraße 10",
        "Av. Copacabana, 267", "Strada Provinciale 124", "Fauntleroy Circus", "Av. dos Lusíadas, 23",
        "Rua da Panificadora, 12", "Av. Inês de Castro, 414", "Avda. Azteca 123", "2817 Milton Dr." };
            string[] employeeimg = { "usermale", "userfemale" };



            List<OverviewData> virtualData = new List<OverviewData>();
            for (var i = 0; i < DataCount; i++)
            {
                var EmpName = employees[new Random().Next(employees.Length)];
                virtualData.Add(new OverviewData()
                {
                    EmployeeID = 1000 + i,
                    Employees = EmpName,
                    Designation = designation[new Random().Next(designation.Length)],
                    Location = location[new Random().Next(location.Length)],
                    Status = status[new Random().Next(status.Length)],
                    Trustworthiness = trustworthiness[new Random().Next(trustworthiness.Length)],
                    Rating = new Random().Next(5),
                    Software = new Random().Next(25, 100),
                    EmployeeImg = employeeimg[new Random().Next(employeeimg.Length)],
                    CurrentSalary = new Random().Next(100000),
                    Mail = getMail(EmpName, mail),
                    Address = address[new Random().Next(address.Length)],
                });
            }
            return virtualData;
        }
        public static string getMail(string EmployeesName, string[] mailData)
        {
            string Mail = EmployeesName.ToLower() + (new Random().Next(100) + 10) + "@" + mailData[new Random().Next(mailData.Length)];
            return Mail;
        }


        public int EmployeeID { get; set; }
        public string Employees { get; set; }
        public string Designation { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string Trustworthiness { get; set; }
        public int Rating { get; set; }
        public int Software { get; set; }
        public string EmployeeImg { get; set; }
        public int CurrentSalary { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
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
            var count = 0;

            List<EmployeeOrders> order = new List<EmployeeOrders>();
            order.Add(new EmployeeOrders(10248, "VINET", 5, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 32.38, "Vins et alcools Chevalier", "59 rue de l'Abbaye", "Reims", "null", "51100", "France"));
            order.Add(new EmployeeOrders(10249, "TOMSP", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 11.61, "Toms Spezialitäten", "Luisenstr. 48", "Münster", "null", "44087", "Germany"));
            order.Add(new EmployeeOrders(10250, "HANAR", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 65.83, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
            order.Add(new EmployeeOrders(10251, "VICTE", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 41.34, "Victuailles en stock", "2, rue du Commerce", "Lyon", "null", "69004", "France"));
            order.Add(new EmployeeOrders(10252, "SUPRD", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 51.3, "Suprêmes délices", "Boulevard Tirou, 255", "Charleroi", "null", "B-6000", "Belgium"));
            order.Add(new EmployeeOrders(10253, "HANAR", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 58.17, "Hanari Carnes", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"));
            order.Add(new EmployeeOrders(10254, "CHOPS", 5, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 22.98, "Chop-suey Chinese", "Hauptstr. 31", "Bern", "null", "3012", "Switzerland"));
            order.Add(new EmployeeOrders(10255, "RICSU", 9, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 148.33, "Richter Supermarkt", "Starenweg 5", "Genève", "null", "1204", "Switzerland"));
            order.Add(new EmployeeOrders(10256, "WELLI", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 13.97, "Wellington Importadora", "Rua do Mercado, 12", "Resende", "SP", "08737-363", "Brazil"));
            order.Add(new EmployeeOrders(10257, "HILAA", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 81.91, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
            order.Add(new EmployeeOrders(10258, "ERNSH", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 140.51, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10259, "CENTC", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 3.25, "Centro comercial Moctezuma", "Sierras de Granada 9993", "México D.F.", "null", "05022", "Mexico"));
            order.Add(new EmployeeOrders(10260, "OTTIK", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 55.09, "Ottilies Käseladen", "Mehrheimerstr. 369", "Köln", "null", "50739", "Germany"));
            order.Add(new EmployeeOrders(10261, "QUEDE", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 3.05, "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"));
            order.Add(new EmployeeOrders(10262, "RATTC", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 48.29, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
            order.Add(new EmployeeOrders(10263, "ERNSH", 9, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 146.06, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10264, "FOLKO", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 3.67, "Folk och fä HB", "Åkergatan 24", "Bräcke", "null", "S-844 67", "Sweden"));
            order.Add(new EmployeeOrders(10265, "BLONP", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 55.28, "Blondel père et fils", "24, place Kléber", "Strasbourg", "null", "67000", "France"));
            order.Add(new EmployeeOrders(10266, "WARTH", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 25.73, "Wartian Herkku", "Torikatu 38", "Oulu", "null", "90110", "Finland"));
            order.Add(new EmployeeOrders(10267, "FRANK", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 208.58, "Frankenversand", "Berliner Platz 43", "München", "null", "80805", "Germany"));
            order.Add(new EmployeeOrders(10268, "GROSR", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 66.29, "GROSELLA-Restaurante", "5ª Ave. Los Palos Grandes", "Caracas", "DF", "1081", "Venezuela"));
            order.Add(new EmployeeOrders(10269, "WHITC", 5, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 4.56, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
            order.Add(new EmployeeOrders(10270, "WARTH", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 136.54, "Wartian Herkku", "Torikatu 38", "Oulu", "null", "90110", "Finland"));
            order.Add(new EmployeeOrders(10271, "SPLIR", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 4.54, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
            order.Add(new EmployeeOrders(10272, "RATTC", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 98.03, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
            order.Add(new EmployeeOrders(10273, "QUICK", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 76.07, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", "null", "01307", "Germany"));
            order.Add(new EmployeeOrders(10274, "VINET", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 6.01, "Vins et alcools Chevalier", "59 rue de l'Abbaye", "Reims", "null", "51100", "France"));
            order.Add(new EmployeeOrders(10275, "MAGAA", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 26.93, "Magazzini Alimentari Riuniti", "Via Ludovico il Moro 22", "Bergamo", "null", "24100", "Italy"));
            order.Add(new EmployeeOrders(10276, "TORTU", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 13.84, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", "null", "05033", "Mexico"));
            order.Add(new EmployeeOrders(10277, "MORGK", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 125.77, "Morgenstern Gesundkost", "Heerstr. 22", "Leipzig", "null", "04179", "Germany"));
            order.Add(new EmployeeOrders(10278, "BERGS", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 92.69, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", "null", "S-958 22", "Sweden"));
            order.Add(new EmployeeOrders(10279, "LEHMS", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 25.83, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", "null", "60528", "Germany"));
            order.Add(new EmployeeOrders(10280, "BERGS", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 8.98, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", "null", "S-958 22", "Sweden"));
            order.Add(new EmployeeOrders(10281, "ROMEY", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 2.94, "Romero y tomillo", "Gran Vía, 1", "Madrid", "null", "28001", "Spain"));
            order.Add(new EmployeeOrders(10282, "ROMEY", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 12.69, "Romero y tomillo", "Gran Vía, 1", "Madrid", "null", "28001", "Spain"));
            order.Add(new EmployeeOrders(10283, "LILAS", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 84.81, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
            order.Add(new EmployeeOrders(10284, "LEHMS", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 76.56, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", "null", "60528", "Germany"));
            order.Add(new EmployeeOrders(10285, "QUICK", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 76.83, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", "null", "01307", "Germany"));
            order.Add(new EmployeeOrders(10286, "QUICK", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 229.24, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", "null", "01307", "Germany"));
            order.Add(new EmployeeOrders(10287, "RICAR", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 12.76, "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil"));
            order.Add(new EmployeeOrders(10288, "REGGC", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 7.45, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", "null", "42100", "Italy"));
            order.Add(new EmployeeOrders(10289, "BSBEV", 7, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 22.77, "B's Beverages", "Fauntleroy Circus", "London", "null", "EC2 5NT", "UK"));
            order.Add(new EmployeeOrders(10290, "COMMI", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 79.7, "Comércio Mineiro", "Av. dos Lusíadas, 23", "Sao Paulo", "SP", "05432-043", "Brazil"));
            order.Add(new EmployeeOrders(10291, "QUEDE", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 6.4, "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"));
            order.Add(new EmployeeOrders(10292, "TRADH", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 1.35, "Tradiçao Hipermercados", "Av. Inês de Castro, 414", "Sao Paulo", "SP", "05634-030", "Brazil"));
            order.Add(new EmployeeOrders(10293, "TORTU", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 21.18, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", "null", "05033", "Mexico"));
            order.Add(new EmployeeOrders(10294, "RATTC", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 147.26, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
            order.Add(new EmployeeOrders(10295, "VINET", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 1.15, "Vins et alcools Chevalier", "59 rue de l'Abbaye", "Reims", "null", "51100", "France"));
            order.Add(new EmployeeOrders(10296, "LILAS", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 0.12, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
            order.Add(new EmployeeOrders(10297, "BLONP", 5, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 5.74, "Blondel père et fils", "24, place Kléber", "Strasbourg", "null", "67000", "France"));
            order.Add(new EmployeeOrders(10298, "HUNGO", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 168.22, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", "null", "Ireland"));
            order.Add(new EmployeeOrders(10299, "RICAR", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 29.76, "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil"));
            order.Add(new EmployeeOrders(10300, "MAGAA", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 17.68, "Magazzini Alimentari Riuniti", "Via Ludovico il Moro 22", "Bergamo", "null", "24100", "Italy"));
            order.Add(new EmployeeOrders(10301, "WANDK", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 45.08, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", "null", "70563", "Germany"));
            order.Add(new EmployeeOrders(10302, "SUPRD", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 6.27, "Suprêmes délices", "Boulevard Tirou, 255", "Charleroi", "null", "B-6000", "Belgium"));
            order.Add(new EmployeeOrders(10303, "GODOS", 7, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 107.83, "Godos Cocina Típica", "C/ Romero, 33", "Sevilla", "null", "41101", "Spain"));
            order.Add(new EmployeeOrders(10304, "TORTU", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 63.79, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", "null", "05033", "Mexico"));
            order.Add(new EmployeeOrders(10305, "OLDWO", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 257.62, "Old World Delicatessen", "2743 Bering St.", "Anchorage", "AK", "99508", "USA"));
            order.Add(new EmployeeOrders(10306, "ROMEY", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 7.56, "Romero y tomillo", "Gran Vía, 1", "Madrid", "null", "28001", "Spain"));
            order.Add(new EmployeeOrders(10307, "LONEP", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 0.56, "Lonesome Pine Restaurant", "89 Chiaroscuro Rd.", "Portland", "OR", "97219", "USA"));
            order.Add(new EmployeeOrders(10308, "ANATR", 7, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 1.61, "Ana Trujillo Emparedados y helados", "Avda. de la Constitución 2222", "México D.F.", "null", "05021", "Mexico"));
            order.Add(new EmployeeOrders(10309, "HUNGO", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 47.3, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", "null", "Ireland"));
            order.Add(new EmployeeOrders(10310, "THEBI", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 17.52, "The Big Cheese", "89 Jefferson Way Suite 2", "Portland", "OR", "97201", "USA"));
            order.Add(new EmployeeOrders(10311, "DUMON", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 24.69, "Du monde entier", "67, rue des Cinquante Otages", "Nantes", "null", "44000", "France"));
            order.Add(new EmployeeOrders(10312, "WANDK", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 40.26, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", "null", "70563", "Germany"));
            order.Add(new EmployeeOrders(10313, "QUICK", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 1.96, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", "null", "01307", "Germany"));
            order.Add(new EmployeeOrders(10314, "RATTC", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 74.16, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
            order.Add(new EmployeeOrders(10315, "ISLAT", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 41.76, "Island Trading", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK"));
            order.Add(new EmployeeOrders(10316, "RATTC", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 150.15, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
            order.Add(new EmployeeOrders(10317, "LONEP", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 12.69, "Lonesome Pine Restaurant", "89 Chiaroscuro Rd.", "Portland", "OR", "97219", "USA"));
            order.Add(new EmployeeOrders(10318, "ISLAT", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 4.73, "Island Trading", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK"));
            order.Add(new EmployeeOrders(10319, "TORTU", 7, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 64.5, "Tortuga Restaurante", "Avda. Azteca 123", "México D.F.", "null", "05033", "Mexico"));
            order.Add(new EmployeeOrders(10320, "WARTH", 5, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 34.57, "Wartian Herkku", "Torikatu 38", "Oulu", "null", "90110", "Finland"));
            order.Add(new EmployeeOrders(10321, "ISLAT", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 3.43, "Island Trading", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK"));
            order.Add(new EmployeeOrders(10322, "PERIC", 7, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 0.4, "Pericles Comidas clásicas", "Calle Dr. Jorge Cash 321", "México D.F.", "null", "05033", "Mexico"));
            order.Add(new EmployeeOrders(10323, "KOENE", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 4.88, "Königlich Essen", "Maubelstr. 90", "Brandenburg", "null", "14776", "Germany"));
            order.Add(new EmployeeOrders(10324, "SAVEA", 9, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 214.27, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
            order.Add(new EmployeeOrders(10325, "KOENE", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 64.86, "Königlich Essen", "Maubelstr. 90", "Brandenburg", "null", "14776", "Germany"));
            order.Add(new EmployeeOrders(10326, "BOLID", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 77.92, "Bólido Comidas preparadas", "C/ Araquil, 67", "Madrid", "null", "28023", "Spain"));
            order.Add(new EmployeeOrders(10327, "FOLKO", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 63.36, "Folk och fä HB", "Åkergatan 24", "Bräcke", "null", "S-844 67", "Sweden"));
            order.Add(new EmployeeOrders(10328, "FURIB", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 87.03, "Furia Bacalhau e Frutos do Mar", "Jardim das rosas n. 32", "Lisboa", "null", "1675", "Portugal"));
            order.Add(new EmployeeOrders(10329, "SPLIR", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 191.67, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
            order.Add(new EmployeeOrders(10330, "LILAS", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 12.75, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
            order.Add(new EmployeeOrders(10331, "BONAP", 9, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 10.19, "Bon app'", "12, rue des Bouchers", "Marseille", "null", "13008", "France"));
            order.Add(new EmployeeOrders(10332, "MEREP", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 52.84, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
            order.Add(new EmployeeOrders(10333, "WARTH", 5, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 0.59, "Wartian Herkku", "Torikatu 38", "Oulu", "null", "90110", "Finland"));
            order.Add(new EmployeeOrders(10334, "VICTE", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 8.56, "Victuailles en stock", "2, rue du Commerce", "Lyon", "null", "69004", "France"));
            order.Add(new EmployeeOrders(10335, "HUNGO", 7, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 42.11, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", "null", "Ireland"));
            order.Add(new EmployeeOrders(10336, "PRINI", 7, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 15.51, "Princesa Isabel Vinhos", "Estrada da saúde n. 58", "Lisboa", "null", "1756", "Portugal"));
            order.Add(new EmployeeOrders(10337, "FRANK", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 108.26, "Frankenversand", "Berliner Platz 43", "München", "null", "80805", "Germany"));
            order.Add(new EmployeeOrders(10338, "OLDWO", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 84.21, "Old World Delicatessen", "2743 Bering St.", "Anchorage", "AK", "99508", "USA"));
            order.Add(new EmployeeOrders(10339, "MEREP", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 15.66, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
            order.Add(new EmployeeOrders(10340, "BONAP", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 166.31, "Bon app'", "12, rue des Bouchers", "Marseille", "null", "13008", "France"));
            order.Add(new EmployeeOrders(10341, "SIMOB", 7, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 26.78, "Simons bistro", "Vinbæltet 34", "Kobenhavn", "null", "1734", "Denmark"));
            order.Add(new EmployeeOrders(10342, "FRANK", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 54.83, "Frankenversand", "Berliner Platz 43", "München", "null", "80805", "Germany"));
            order.Add(new EmployeeOrders(10343, "LEHMS", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 110.37, "Lehmanns Marktstand", "Magazinweg 7", "Frankfurt a.M.", "null", "60528", "Germany"));
            order.Add(new EmployeeOrders(10344, "WHITC", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 23.29, "White Clover Markets", "1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"));
            order.Add(new EmployeeOrders(10345, "QUICK", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 249.06, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", "null", "01307", "Germany"));
            order.Add(new EmployeeOrders(10346, "RATTC", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 142.08, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
            order.Add(new EmployeeOrders(10347, "FAMIA", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 3.1, "Familia Arquibaldo", "Rua Orós, 92", "Sao Paulo", "SP", "05442-030", "Brazil"));
            order.Add(new EmployeeOrders(10348, "WANDK", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 0.78, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", "null", "70563", "Germany"));
            order.Add(new EmployeeOrders(10349, "SPLIR", 7, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 8.63, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
            order.Add(new EmployeeOrders(10350, "LAMAI", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 64.19, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", "null", "31000", "France"));
            order.Add(new EmployeeOrders(10351, "ERNSH", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 162.33, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10352, "FURIB", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 1.3, "Furia Bacalhau e Frutos do Mar", "Jardim das rosas n. 32", "Lisboa", "null", "1675", "Portugal"));
            order.Add(new EmployeeOrders(10353, "PICCO", 7, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 360.63, "Piccolo und mehr", "Geislweg 14", "Salzburg", "null", "5020", "Austria"));
            order.Add(new EmployeeOrders(10354, "PERIC", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 53.8, "Pericles Comidas clásicas", "Calle Dr. Jorge Cash 321", "México D.F.", "null", "05033", "Mexico"));
            order.Add(new EmployeeOrders(10355, "AROUT", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 41.95, "Around the Horn", "Brook Farm Stratford St. Mary", "Colchester", "Essex", "CO7 6JX", "UK"));
            order.Add(new EmployeeOrders(10356, "WANDK", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 36.71, "Die Wandernde Kuh", "Adenauerallee 900", "Stuttgart", "null", "70563", "Germany"));
            order.Add(new EmployeeOrders(10357, "LILAS", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 34.88, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
            order.Add(new EmployeeOrders(10358, "LAMAI", 5, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 19.64, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", "null", "31000", "France"));
            order.Add(new EmployeeOrders(10359, "SEVES", 5, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 288.43, "Seven Seas Imports", "90 Wadhurst Rd.", "London", "null", "OX15 4NB", "UK"));
            order.Add(new EmployeeOrders(10360, "BLONP", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 131.7, "Blondel père et fils", "24, place Kléber", "Strasbourg", "null", "67000", "France"));
            order.Add(new EmployeeOrders(10361, "QUICK", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 183.17, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", "null", "01307", "Germany"));
            order.Add(new EmployeeOrders(10362, "BONAP", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 96.04, "Bon app'", "12, rue des Bouchers", "Marseille", "null", "13008", "France"));
            order.Add(new EmployeeOrders(10363, "DRACD", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 30.54, "Drachenblut Delikatessen", "Walserweg 21", "Aachen", "null", "52066", "Germany"));
            order.Add(new EmployeeOrders(10364, "EASTC", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 71.97, "Eastern Connection", "35 King George", "London", "null", "WX3 6FW", "UK"));
            order.Add(new EmployeeOrders(10365, "ANTON", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 22, "Antonio Moreno Taquería", "Mataderos  2312", "México D.F.", "null", "05023", "Mexico"));
            order.Add(new EmployeeOrders(10366, "GALED", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 10.14, "Galería del gastronómo", "Rambla de Cataluña, 23", "Barcelona", "null", "8022", "Spain"));
            order.Add(new EmployeeOrders(10367, "VAFFE", 7, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 13.55, "Vaffeljernet", "Smagsloget 45", "Århus", "null", "8200", "Denmark"));
            order.Add(new EmployeeOrders(10368, "ERNSH", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 101.95, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10369, "SPLIR", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 195.68, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
            order.Add(new EmployeeOrders(10370, "CHOPS", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 1.17, "Chop-suey Chinese", "Hauptstr. 31", "Bern", "null", "3012", "Switzerland"));
            order.Add(new EmployeeOrders(10371, "LAMAI", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 0.45, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", "null", "31000", "France"));
            order.Add(new EmployeeOrders(10372, "QUEEN", 5, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 890.78, "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil"));
            order.Add(new EmployeeOrders(10373, "HUNGO", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 124.12, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", "null", "Ireland"));
            order.Add(new EmployeeOrders(10374, "WOLZA", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 3.94, "Wolski Zajazd", "ul. Filtrowa 68", "Warszawa", "null", "01-012", "Poland"));
            order.Add(new EmployeeOrders(10375, "HUNGC", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 20.12, "Hungry Coyote Import Store", "City Center Plaza 516 Main St.", "Elgin", "OR", "97827", "USA"));
            order.Add(new EmployeeOrders(10376, "MEREP", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 20.39, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
            order.Add(new EmployeeOrders(10377, "SEVES", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 22.21, "Seven Seas Imports", "90 Wadhurst Rd.", "London", "null", "OX15 4NB", "UK"));
            order.Add(new EmployeeOrders(10378, "FOLKO", 5, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 5.44, "Folk och fä HB", "Åkergatan 24", "Bräcke", "null", "S-844 67", "Sweden"));
            order.Add(new EmployeeOrders(10379, "QUEDE", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 45.03, "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"));
            order.Add(new EmployeeOrders(10380, "HUNGO", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 35.03, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", "null", "Ireland"));
            order.Add(new EmployeeOrders(10381, "LILAS", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 7.99, "LILA-Supermercado", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela"));
            order.Add(new EmployeeOrders(10382, "ERNSH", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 94.77, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10383, "AROUT", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 34.24, "Around the Horn", "Brook Farm Stratford St. Mary", "Colchester", "Essex", "CO7 6JX", "UK"));
            order.Add(new EmployeeOrders(10384, "BERGS", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 168.64, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", "null", "S-958 22", "Sweden"));
            order.Add(new EmployeeOrders(10385, "SPLIR", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 30.96, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
            order.Add(new EmployeeOrders(10386, "FAMIA", 9, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 13.99, "Familia Arquibaldo", "Rua Orós, 92", "Sao Paulo", "SP", "05442-030", "Brazil"));
            order.Add(new EmployeeOrders(10387, "SANTG", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 93.63, "Santé Gourmet", "Erling Skakkes gate 78", "Stavern", "null", "4110", "Norway"));
            order.Add(new EmployeeOrders(10388, "SEVES", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 34.86, "Seven Seas Imports", "90 Wadhurst Rd.", "London", "null", "OX15 4NB", "UK"));
            order.Add(new EmployeeOrders(10389, "BOTTM", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 47.42, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
            order.Add(new EmployeeOrders(10390, "ERNSH", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 126.38, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10391, "DRACD", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 5.45, "Drachenblut Delikatessen", "Walserweg 21", "Aachen", "null", "52066", "Germany"));
            order.Add(new EmployeeOrders(10392, "PICCO", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 122.46, "Piccolo und mehr", "Geislweg 14", "Salzburg", "null", "5020", "Austria"));
            order.Add(new EmployeeOrders(10393, "SAVEA", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 126.56, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
            order.Add(new EmployeeOrders(10394, "HUNGC", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 30.34, "Hungry Coyote Import Store", "City Center Plaza 516 Main St.", "Elgin", "OR", "97827", "USA"));
            order.Add(new EmployeeOrders(10395, "HILAA", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 184.41, "HILARION-Abastos", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela"));
            order.Add(new EmployeeOrders(10396, "FRANK", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 135.35, "Frankenversand", "Berliner Platz 43", "München", "null", "80805", "Germany"));
            order.Add(new EmployeeOrders(10397, "PRINI", 5, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 60.26, "Princesa Isabel Vinhos", "Estrada da saúde n. 58", "Lisboa", "null", "1756", "Portugal"));
            order.Add(new EmployeeOrders(10398, "SAVEA", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 89.16, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
            order.Add(new EmployeeOrders(10399, "VAFFE", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 27.36, "Vaffeljernet", "Smagsloget 45", "Århus", "null", "8200", "Denmark"));
            order.Add(new EmployeeOrders(10400, "EASTC", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 83.93, "Eastern Connection", "35 King George", "London", "null", "WX3 6FW", "UK"));
            order.Add(new EmployeeOrders(10401, "RATTC", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 12.51, "Rattlesnake Canyon Grocery", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"));
            order.Add(new EmployeeOrders(10402, "ERNSH", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 67.88, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10403, "ERNSH", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 73.79, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10404, "MAGAA", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 155.97, "Magazzini Alimentari Riuniti", "Via Ludovico il Moro 22", "Bergamo", "null", "24100", "Italy"));
            order.Add(new EmployeeOrders(10405, "LINOD", 1, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 34.82, "LINO-Delicateses", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Nueva Esparta", "4980", "Venezuela"));
            order.Add(new EmployeeOrders(10406, "QUEEN", 7, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 108.04, "Queen Cozinha", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil"));
            order.Add(new EmployeeOrders(10407, "OTTIK", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 91.48, "Ottilies Käseladen", "Mehrheimerstr. 369", "Köln", "null", "50739", "Germany"));
            order.Add(new EmployeeOrders(10408, "FOLIG", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 11.26, "Folies gourmandes", "184, chaussée de Tournai", "Lille", "null", "59000", "France"));
            order.Add(new EmployeeOrders(10409, "OCEAN", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 29.83, "Océano Atlántico Ltda.", "Ing. Gustavo Moncada 8585 Piso 20-A", "Buenos Aires", "null", "1010", "Argentina"));
            order.Add(new EmployeeOrders(10410, "BOTTM", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 2.4, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
            order.Add(new EmployeeOrders(10411, "BOTTM", 9, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 23.65, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
            order.Add(new EmployeeOrders(10412, "WARTH", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 3.77, "Wartian Herkku", "Torikatu 38", "Oulu", "null", "90110", "Finland"));
            order.Add(new EmployeeOrders(10413, "LAMAI", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 95.66, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", "null", "31000", "France"));
            order.Add(new EmployeeOrders(10414, "FAMIA", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 21.48, "Familia Arquibaldo", "Rua Orós, 92", "Sao Paulo", "SP", "05442-030", "Brazil"));
            order.Add(new EmployeeOrders(10415, "HUNGC", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 0.2, "Hungry Coyote Import Store", "City Center Plaza 516 Main St.", "Elgin", "OR", "97827", "USA"));
            order.Add(new EmployeeOrders(10416, "WARTH", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 22.72, "Wartian Herkku", "Torikatu 38", "Oulu", "null", "90110", "Finland"));
            order.Add(new EmployeeOrders(10417, "SIMOB", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 70.29, "Simons bistro", "Vinbæltet 34", "Kobenhavn", "null", "1734", "Denmark"));
            order.Add(new EmployeeOrders(10418, "QUICK", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 17.55, "QUICK-Stop", "Taucherstraße 10", "Cunewalde", "null", "01307", "Germany"));
            order.Add(new EmployeeOrders(10419, "RICSU", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 137.35, "Richter Supermarkt", "Starenweg 5", "Genève", "null", "1204", "Switzerland"));
            order.Add(new EmployeeOrders(10420, "WELLI", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 44.12, "Wellington Importadora", "Rua do Mercado, 12", "Resende", "SP", "08737-363", "Brazil"));
            order.Add(new EmployeeOrders(10421, "QUEDE", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 99.23, "Que Delícia", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"));
            order.Add(new EmployeeOrders(10422, "FRANS", 2, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 3.02, "Franchi S.p.A.", "Via Monte Bianco 34", "Torino", "null", "10100", "Italy"));
            order.Add(new EmployeeOrders(10423, "GOURL", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 24.5, "Gourmet Lanchonetes", "Av. Brasil, 442", "Campinas", "SP", "04876-786", "Brazil"));
            order.Add(new EmployeeOrders(10424, "MEREP", 7, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 370.61, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
            order.Add(new EmployeeOrders(10425, "LAMAI", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 7.93, "La maison d'Asie", "1 rue Alsace-Lorraine", "Toulouse", "null", "31000", "France"));
            order.Add(new EmployeeOrders(10426, "GALED", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 18.69, "Galería del gastronómo", "Rambla de Cataluña, 23", "Barcelona", "null", "8022", "Spain"));
            order.Add(new EmployeeOrders(10427, "PICCO", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 31.29, "Piccolo und mehr", "Geislweg 14", "Salzburg", "null", "5020", "Austria"));
            order.Add(new EmployeeOrders(10428, "REGGC", 7, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 11.09, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", "null", "42100", "Italy"));
            order.Add(new EmployeeOrders(10429, "HUNGO", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 56.63, "Hungry Owl All-Night Grocers", "8 Johnstown Road", "Cork", "Co. Cork", "null", "Ireland"));
            order.Add(new EmployeeOrders(10430, "ERNSH", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 458.78, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10431, "BOTTM", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 44.17, "Bottom-Dollar Markets", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada"));
            order.Add(new EmployeeOrders(10432, "SPLIR", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 4.34, "Split Rail Beer & Ale", "P.O. Box 555", "Lander", "WY", "82520", "USA"));
            order.Add(new EmployeeOrders(10433, "PRINI", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 73.83, "Princesa Isabel Vinhos", "Estrada da saúde n. 58", "Lisboa", "null", "1756", "Portugal"));
            order.Add(new EmployeeOrders(10434, "FOLKO", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 17.92, "Folk och fä HB", "Åkergatan 24", "Bräcke", "null", "S-844 67", "Sweden"));
            order.Add(new EmployeeOrders(10435, "CONSH", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 9.21, "Consolidated Holdings", "Berkeley Gardens 12  Brewery", "London", "null", "WX1 6LT", "UK"));
            order.Add(new EmployeeOrders(10436, "BLONP", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 156.66, "Blondel père et fils", "24, place Kléber", "Strasbourg", "null", "67000", "France"));
            order.Add(new EmployeeOrders(10437, "WARTH", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 19.97, "Wartian Herkku", "Torikatu 38", "Oulu", "null", "90110", "Finland"));
            order.Add(new EmployeeOrders(10438, "TOMSP", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 8.24, "Toms Spezialitäten", "Luisenstr. 48", "Münster", "null", "44087", "Germany"));
            order.Add(new EmployeeOrders(10439, "MEREP", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 4.07, "Mère Paillarde", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada"));
            order.Add(new EmployeeOrders(10440, "SAVEA", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 86.53, "Save-a-lot Markets", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA"));
            order.Add(new EmployeeOrders(10441, "OLDWO", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 73.02, "Old World Delicatessen", "2743 Bering St.", "Anchorage", "AK", "99508", "USA"));
            order.Add(new EmployeeOrders(10442, "ERNSH", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 47.94, "Ernst Handel", "Kirchgasse 6", "Graz", "null", "8010", "Austria"));
            order.Add(new EmployeeOrders(10443, "REGGC", 8, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 13.95, "Reggiani Caseifici", "Strada Provinciale 124", "Reggio Emilia", "null", "42100", "Italy"));
            order.Add(new EmployeeOrders(10444, "BERGS", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 3.5, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", "null", "S-958 22", "Sweden"));
            order.Add(new EmployeeOrders(10445, "BERGS", 3, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 9.3, "Berglunds snabbköp", "Berguvsvägen  8", "Luleå", "null", "S-958 22", "Sweden"));
            order.Add(new EmployeeOrders(10446, "TOMSP", 6, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 14.68, "Toms Spezialitäten", "Luisenstr. 48", "Münster", "null", "44087", "Germany"));
            order.Add(new EmployeeOrders(10447, "RICAR", 4, DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), DateTime.Now.AddDays(++count), 68.66, "Ricardo Adocicados", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil"));
            return order;
        }

        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public double? Freight { get; set; }
        public string ShipCity { get; set; }    
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public string ShipName { get; set; }
        public string ShipCountry { get; set; }
        public string ShipPostalCode{ get; set; }
        public string ShipRegion{ get; set; }
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
        public Employee(int EmployeeID, string FirstName, string LastName, string Title, DateTime BirthDate, DateTime HireDate, int ReportsTo, string Address, string PostalCode, string Phone, string City, string Country, string mail)
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
            this.Email = mail;

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
        public string Email { get; set; }
        public static List<Employee> GetAllRecords()
        {
            List<Employee> Emp = new List<Employee>();
            Emp.Add(new Employee(1, "Nancy", "Davolio", "Sales Representative", new DateTime(1948, 12, 08), new DateTime(1992, 05, 01), 2, "507 - 20th Ave. E.Apt. 2A ", " 98122", "(206) 555-9857 ", "Seattle ", "USA", "nancy_davolio@gmail.com"));
            Emp.Add(new Employee(2, "Andrew", "Fuller", "Vice President, Sales", new DateTime(1952, 02, 19), new DateTime(1992, 08, 14), 4, "908 W. Capital Way", "98401 ", "(206) 555-9482 ", "Kirkland ", "USA", "andrew_fuller@gmail.com"));
            Emp.Add(new Employee(3, "Janet", "Leverling", "Sales Representative", new DateTime(1963, 08, 30), new DateTime(1992, 04, 01), 3, " 4110 Old Redmond Rd.", "98052 ", "(206) 555-8122", "Redmond ", "USA", "Janet_leverling@gmail.com"));
            Emp.Add(new Employee(4, "Margaret", "Peacock", "Sales Representative", new DateTime(1937, 09, 19), new DateTime(1993, 05, 03), 6, "14 Garrett Hill ", "SW1 8JR ", "(71) 555-4848 ", "London ", "UK", "margaret_peacock@gmail.com"));
            Emp.Add(new Employee(5, "Steven", "Buchanan", "Sales Manager", new DateTime(1955, 03, 04), new DateTime(1993, 10, 17), 8, "Coventry HouseMiner Rd. ", "EC2 7JR ", " (206) 555-8122", "Tacoma ", " USA", "steven_buchanan@gmail.com"));
            Emp.Add(new Employee(6, "Michael", "Suyama", "Sales Representative", new DateTime(1963, 07, 02), new DateTime(1993, 10, 17), 2, " 7 Houndstooth Rd.", " WG2 7LT", "(71) 555-4444 ", "London ", "UK", "michael_suyama@gmail.com"));
            Emp.Add(new Employee(7, "Robert", "King", "Sales Representative", new DateTime(1960, 05, 29), new DateTime(1994, 01, 02), 7, "Edgeham HollowWinchester Way ", "RG1 9SP ", "(71) 555-5598 ", "London", "UK", "robert_king@gmail.com"));
            Emp.Add(new Employee(8, "Laura", "Callahan", "Inside Sales Coordinator", new DateTime(1958, 01, 09), new DateTime(1994, 03, 05), 9, "722 Moss Bay Blvd. ", "98033 ", " (206) 555-3412", "Seattle ", "USA ", "laura_callahan@gmail.com"));
            Emp.Add(new Employee(9, "Anne", "Dodsworth", "Sales Representative", new DateTime(1966, 01, 27), new DateTime(1994, 11, 15), 5, "4726 - 11th Ave. N.E. ", "98105 ", "(71) 555-5598 ", " London", "UK", "anne_dodsworth@gmail.com"));
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
    public class Order
    {
        public Order()
        {

        }
        public Order(int OrderID, string CustomerId, int EmployeeId, double Freight, bool Verified, DateTime OrderDate, string ShipCity, string ShipName, string ShipCountry, DateTime ShippedDate, string ShipAddress)
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

        public static List<Order> GetAllRecords()
        {
            List<Order> orders = new List<Order>();
            int code = 1000;
            for (int i = 1; i < 10000; i++)
            {
                orders.Add(new Order(code + 1, "ALFKI", i + 0, 2.3 * i, false, new DateTime(1991, 05, 15), "Berlin", "Simons bistro", "Denmark", new DateTime(1996, 7, 16), "Kirchgasse 6"));
                orders.Add(new Order(code + 2, "ANATR", i + 2, 3.3 * i, true, new DateTime(1990, 04, 04), "Madrid", "Queen Cozinha", "Brazil", new DateTime(1996, 9, 11), "Avda. Azteca 123"));
                orders.Add(new Order(code + 3, "ANTON", i + 1, 4.3 * i, false, new DateTime(1957, 11, 30), "Cholchester", "Frankenversand", "Germany", new DateTime(1996, 10, 7), "Carrera 52 con Ave. Bolívar #65-98 Llano Largo"));
                orders.Add(new Order(code + 4, "BLONP", i + 3, 5.3 * i, true, new DateTime(1930, 10, 22), "Marseille", "Ernst Handel", "Austria", new DateTime(1996, 12, 30), "Magazinweg 7"));
                orders.Add(new Order(code + 5, "BOLID", i + 4, 6.3 * i, false, new DateTime(1953, 02, 18), "Tsawassen", "Hanari Carnes", "Switzerland", new DateTime(1997, 12, 3), "1029 - 12th Ave. S."));
                code += 5;
            }
            return orders;
        }

        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public double? Freight { get; set; }
        public string ShipCity { get; set; }
        public bool Verified { get; set; }
        public DateTime? OrderDate { get; set; }

        public string ShipName { get; set; }

        public string ShipCountry { get; set; }

        public DateTime? ShippedDate { get; set; }
        public string ShipAddress { get; set; }
    }
}
