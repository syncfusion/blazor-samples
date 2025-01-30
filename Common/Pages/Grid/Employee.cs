#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BlazorDemos;
using System.ComponentModel.DataAnnotations;

namespace blazor_employeedata
{   
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
}