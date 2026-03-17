#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
namespace EmployeeData
{
    public class EmployeeData
    {
        public string? Name { get; set; }
        public string? FullName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime JoinedDate { get; set; } // DOB + 22 years
        public string? Designation { get; set; }
        public string? EmpID { get; set; }
        public int EmployeeID { get; set; }
        public string? Country { get; set; }
        public string? Address { get; set; }
        public string? Contact { get; set; }
        public int? ParentId { get; set; }
        public bool IsAvailable { get; set; }
        public string? Availability { get; set; }
        public int Rating { get; set; }
        public string? Email => $"{(FullName ?? Name ?? "user").ToLowerInvariant()}@example.com";
        public static List<EmployeeData> GetTemplateData()
        {
            var data = new List<EmployeeData>(500);
            var rng = new Random(123);
            string[] parentTitles = {
                "Chief Executive Officer","Chief Technology Officer","Chief Marketing Officer","Chief Financial Officer",
                "VP Sales - North America","VP Sales - Europe","VP Engineering","Director of Human Resources",
                "Director of Operations","Director of Product Management"
            };
            string[][] childTitleGroups = {
                new[] { "VP Engineering", "VP Marketing", "VP Sales", "Chief of Staff" },
                new[] { "Lead Developer", "Senior Architect", "DevOps Manager", "QA Lead" },
                new[] { "Digital Marketing Head", "Brand Manager", "Content Strategist", "PR Manager" },
                new[] { "Financial Controller", "Senior Accountant", "Tax Specialist", "Data Analyst" },
                new[] { "Regional Sales Manager", "Account Executive", "Sales Coordinator", "Business Development" },
                new[] { "Engineering Manager", "Tech Lead", "Senior Developer", "Scrum Master" },
                new[] { "Talent Acquisition Lead", "HR Business Partner", "Compensation Analyst", "Facilities Manager" },
                new[] { "Supply Chain Manager", "Logistics Head", "Procurement Lead", "Operations Analyst" },
                new[] { "UX Lead", "Product Designer", "User Researcher", "UX Writer" },
                new[] { "Support Manager", "L2 Support Engineer", "Customer Success", "Implementation Specialist" }
            };
            string[] firstNames = { "James", "Sophia", "William", "Emma", "Oliver", "Isabella", "Liam", "Ava", "Noah", "Mia", "Lucas", "Charlotte", "Amelia", "Ethan", "Harper" };
            string[] lastNames = { "Carter", "Turner", "Brown", "Davis", "Wilson", "Moore", "Taylor", "Anderson", "Thomas", "Jackson", "Walker", "Harris", "Martin", "Lewis", "Lee" };
            string[] addresses = { "123 Main St, New York", "456 Oak Ave, Chicago", "789 Pine Rd, London", "321 Elm St, Seattle", "555 Maple Dr, Los Angeles", "22 King St, London", "94 Lakeview Rd, Chicago" };
            string[] phones = { "(555) 123-4567", "(206) 555-0198", "(71) 555-4848", "(831) 758-7368", "(213) 555-9012", "(415) 555-7777" };
            string[] countries = { "New York, USA", "London, UK", "Seattle, WA", "Los Angeles, CA", "Chicago, IL", "San Francisco, CA" };
            string RandName() => $"{firstNames[rng.Next(firstNames.Length)]} {lastNames[rng.Next(lastNames.Length)]}";
            string RandAddr() => addresses[rng.Next(addresses.Length)];
            string RandPhone() => phones[rng.Next(phones.Length)];
            string RandCountry() => countries[rng.Next(countries.Length)];
            DateTime RandParentDOB() => new DateTime(1968 + rng.Next(18), rng.Next(1, 13), rng.Next(1, 28)); // 1968-1985
            DateTime RandChildDOB() => new DateTime(1978 + rng.Next(18), rng.Next(1, 13), rng.Next(1, 28)); // 1978-1995
            int id = 1;
            for (int p = 1; p <= 100; p++)
            {
                // Parent
                var pname = RandName();
                var pDob = RandParentDOB();
                int parentId = id++;
                data.Add(new EmployeeData
                {
                    Name = pname,
                    FullName = pname.Replace(" ", " "),
                    Designation = parentTitles[(p - 1) % parentTitles.Length],
                    EmployeeID = parentId,
                    EmpID = $"EMP{parentId:D3}",
                    Address = RandAddr(),
                    Contact = RandPhone(),
                    Country = RandCountry(),
                    DOB = pDob,
                    JoinedDate = pDob.AddYears(22),
                    ParentId = null,
                    IsAvailable = true,
                    Availability = "Yes",
                    Rating = rng.Next(4, 6)
                });
                // 4 Children for this parent
                var group = childTitleGroups[(p - 1) % childTitleGroups.Length];
                for (int c = 0; c < 4; c++)
                {
                    var cname = RandName();
                    var cDob = RandChildDOB();
                    int childId = id++;
                    data.Add(new EmployeeData
                    {
                        Name = cname,
                        FullName = cname.Replace(" ", " "),
                        Designation = group[c],
                        EmployeeID = childId,
                        EmpID = $"EMP{childId:D3}",
                        Address = RandAddr(),
                        Contact = RandPhone(),
                        Country = RandCountry(),
                        DOB = cDob,
                        JoinedDate = cDob.AddYears(22),
                        ParentId = parentId,
                        IsAvailable = rng.Next(0, 4) != 0,
                        Availability = (rng.Next(0, 4) != 0) ? "Yes" : "No",
                        Rating = rng.Next(2, 6)
                    });
                }
            }
            return data;
        }
    }
}