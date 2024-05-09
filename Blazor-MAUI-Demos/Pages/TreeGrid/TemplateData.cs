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

namespace ej2_blazor_templatedata
{
    public class Employee
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public string Designation { get; set; }
        public string EmpID { get; set; }
        public int? EmployeeID { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public int? ParentId { get; set; }
        public static List<Employee> GetTemplateData()
        {
            List<Employee> DataCollection = new List<Employee>();

            DataCollection.Add(new Employee
            {
                Name = "Robert King",
                FullName = "RobertKing",
                Designation = "Chief Executive Officer",
                EmployeeID = 1,
                EmpID = "EMP001",
                Address = "507 - 20th Ave. E.Apt. 2A, Seattle",
                Contact = "(206) 555-9857",
                Country = "USA",
                DOB = new DateTime(1992, 2, 15),
                ParentId = null
            });
            DataCollection.Add(new Employee
            {
                Name = "David William",
                FullName = "DavidWilliam",
                Designation = "Vice President",
                EmployeeID = 2,
                EmpID = "EMP004",
                Address = "722 Moss Bay Blvd., Kirkland",
                Contact = "(206) 555-3412",
                Country = "USA",
                DOB = new DateTime(1990, 5, 20),
                ParentId = 1
            });
            DataCollection.Add(new Employee
            {
                Name = "Nancy Davolio",
                FullName = "NancyDavolio",
                Designation = "Marketing Executive",
                EmployeeID = 3,
                EmpID = "EMP035",
                Address = "4110 Old Redmond Rd., Redmond",
                Contact = "(206) 555-8122",
                Country = "USA",
                DOB = new DateTime(1988, 3, 19),
                ParentId = 1
            });
            DataCollection.Add(new Employee
            {
                Name = "Andrew Fuller",
                FullName = "AndrewFuller",
                Designation = "Sales Representative",
                EmployeeID = 4,
                EmpID = "EMP045",
                Address = "14 Garrett Hill, London",
                Contact = "(71) 555-4848",
                Country = "UK",
                DOB = new DateTime(1993, 9, 20),
                ParentId = 1
            });
            DataCollection.Add(new Employee
            {
                Name = "Anne Dodsworth",
                FullName = "AnneDodsworth",
                Designation = "Sales Representative",
                EmployeeID = 5,
                EmpID = "EMP091",
                Address = "4726 - 11th Ave. N.E., Seattle",
                Contact = "(206) 555-1189",
                Country = "USA",
                ParentId = null
            });
            DataCollection.Add(new Employee
            {
                Name = "Michael Suyama",
                FullName = "MichaelSuyama",
                Designation = "Sales Representative",
                EmployeeID = 6,
                EmpID = "EMP110",
                Address = "Coventry House Miner Rd., London",
                Contact = "(71) 555-3636",
                Country = "UK",
                ParentId = 5
            });
            DataCollection.Add(new Employee
            {
                Name = "Janet Leverling",
                FullName = "JanetLeverling",
                Designation = "Sales Coordinator",
                EmployeeID = 7,
                EmpID = "EMP131",
                Address = "Edgeham Hollow Winchester Way, London",
                Contact = "(71) 555-3636",
                Country = "UK",
                ParentId = 5
            });
            DataCollection.Add(new Employee
            {
                Name = "Romey Wilson",
                FullName = "RomeyWilson",
                Designation = "Sales Executive",
                EmployeeID = 8,
                EmpID = "EMP039",
                Address = "7 Houndstooth Rd., London",
                Contact = "(71) 555-3690",
                Country = "UK",
                DOB = new DateTime(1994, 2, 2),
                ParentId = null
            });
            DataCollection.Add(new Employee
            {
                Name = "Margaret Peacock",
                FullName = "MargaretPeacock",
                Designation = "Sales Representative",
                EmployeeID = 9,
                EmpID = "EMP213",
                Address = "4726 - 11th Ave. N.E., California",
                Contact = "(206) 555-1989",
                Country = "USA",
                ParentId = 8
            });
            DataCollection.Add(new Employee
            {
                Name = "Steven Buchanan",
                FullName = "StevenBuchanan",
                Designation = "Sales Representative",
                EmployeeID = 11,
                EmpID = "EMP197",
                Address = "200 Lincoln Ave, Salinas, CA 93901",
                Contact = "(831) 758-7408",
                Country = "USA",
                ParentId = 8
            });
            DataCollection.Add(new Employee
            {
                Name = "Tedd Lawson",
                FullName = "TeddLawson",
                Designation = "Sales Representative",
                EmployeeID = 12,
                EmpID = "EMP167",
                Address = "200 Lincoln Ave, Salinas, CA 93901",
                Contact = "(831) 758-7368",
                Country = "USA",
                ParentId = 8
            });

            return DataCollection;
        }
    }
}
