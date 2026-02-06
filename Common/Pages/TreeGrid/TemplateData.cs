#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

namespace Templatedata
{
    public class Employee
    {
        public string? Name { get; set; }
        public string? FullName { get; set; }
        public DateTime DOB { get; set; }
        public string? Designation { get; set; }
        public string? EmpID { get; set; }
        public int? EmployeeID { get; set; }
        public string? Country { get; set; }
        public string? Address { get; set; }
        public string? Contact { get; set; }
        public int? ParentId { get; set; }
        public bool IsAvailable { get; set; }
        public int Rating { get; set; }
        public string? Email => $"{FullName.ToLower()}@abc.com";
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
                Country = "Seattle, WA",
                DOB = new DateTime(1978, 2, 15),
                ParentId = null,
                IsAvailable = true,
                Rating = 5
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
                Country = "Kirkland, WA",
                DOB = new DateTime(1990, 5, 20),
                ParentId = 1,
                IsAvailable = true,
                Rating = 4
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
                Country = "Redmond, WA",
                DOB = new DateTime(1988, 3, 19),
                ParentId = 1,
                IsAvailable = true,
                Rating = 4
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
                Country = "London, UK",
                DOB = new DateTime(1993, 9, 20),
                ParentId = 1,
                IsAvailable = false,
                Rating = 3
            });
            DataCollection.Add(new Employee
            {
                Name = "Anne Dodsworth",
                FullName = "AnneDodsworth",
                Designation = "Sales Executive",
                EmployeeID = 5,
                EmpID = "EMP091",
                Address = "4726 - 11th Ave. N.E., Seattle",
                Contact = "(206) 555-1189",
                Country = "Seattle, WA",
                DOB = new DateTime(1985, 7, 10),
                ParentId = null,
                IsAvailable = true,
                Rating = 4
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
                Country = "London, UK",
                DOB = new DateTime(1987, 11, 5),
                ParentId = 5,
                IsAvailable = true,
                Rating = 3
            });

            DataCollection.Add(new Employee
            {
                Name = "Janet Leverling",
                FullName = "JanetLeverling",
                Designation = "Marketing Representative",
                EmployeeID = 7,
                EmpID = "EMP131",
                Address = "Edgeham Hollow Winchester Way, London",
                Contact = "(71) 555-3636",
                Country = "London, UK",
                DOB = new DateTime(1989, 4, 12),
                ParentId = 5,
                IsAvailable = false,
                Rating = 2
            });



            DataCollection.Add(new Employee
            {
                Name = "Romey Wilson",
                FullName = "RomeyWilson",
                Designation = "Sales Coordinator",
                EmployeeID = 8,
                EmpID = "EMP039",
                Address = "7 Houndstooth Rd., London",
                Contact = "(71) 555-3690",
                Country = "London, UK",
                DOB = new DateTime(1994, 2, 2),
                ParentId = null,
                IsAvailable = true,
                Rating = 4
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
                Country = "Los Angeles, CA",
                DOB = new DateTime(1986, 8, 22),
                ParentId = 8,
                IsAvailable = true,
                Rating = 3
            });
            DataCollection.Add(new Employee
            {
                Name = "Steven Buchanan",
                FullName = "StevenBuchanan",
                Designation = "Sales Representative",
                EmployeeID = 10,
                EmpID = "EMP197",
                Address = "200 Lincoln Ave, Salinas, CA 93901",
                Contact = "(831) 758-7408",
                Country = "Salinas, CA",
                DOB = new DateTime(1984, 1, 30),
                ParentId = 8,
                IsAvailable = false,
                Rating = 2
            });
            DataCollection.Add(new Employee
            {
                Name = "Tedd Lawson",
                FullName = "TeddLawson",
                Designation = "Sales Representative",
                EmployeeID = 11,
                EmpID = "EMP167",
                Address = "200 Lincoln Ave, Salinas, CA 93901",
                Contact = "(831) 758-7368",
                Country = "Salinas, CA",
                DOB = new DateTime(1991, 6, 18),
                ParentId = 8,
                IsAvailable = true,
                Rating = 3
            });
            return DataCollection;
        }
    }
}
