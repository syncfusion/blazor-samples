#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace blazor_employeedatasource
{
    public sealed class EmployeeRecord
    {
        public string EmployeeImage { get; set; } = string.Empty;
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Team { get; set; } = string.Empty;
        public DateTime LastLoginAt { get; set; }
        public string Shift { get; set; } = string.Empty;
    }

    public static class EmployeeData
    {
        public static string GetMail(string first, string last, int index)
        {
            int number = (index * 7 + 40) % 100;
            string local = $"{first}.{last}".ToLowerInvariant().Replace(" ", "");
            return $"{local}{number}@sample.com";
        }

        public static List<EmployeeRecord> GetAllRecords()
        {
            // Departments: selected subset
            string[] departments =
            {
                "Development","Human Resources","Accounting","Marketing","Documentation","Legal",
                "Training","UX","Facilities","Network",
                "Client Services","Content Development","Inventory","Finance & Compliance",
                "Administration","Digital Marketing","Coordinator"
            };

            var rolesByDepartment = new Dictionary<string, string[]>
            {
                ["Development"] = new[] { "Software Engineer", "Sr. Software Engineer", "Software Developer", "Product Manager", "Sr. Product Manager" },
                ["Human Resources"] = new[] { "HR Specialist", "HR Generalist", "Talent Acquisition Partner" },
                ["Accounting"] = new[] { "Accounts Executive", "Accounts Payable Specialist", "Financial Accountant" },
                ["Documentation"] = new[] { "Technical Writer", "Senior Technical Writer", "Doc Tooling Specialist", "Information Architect" },
                ["Marketing"] = new[] { "Marketing Associate", "Marketing Manager", "Brand Strategist", "Campaign Analyst" },
                ["Legal"] = new[] { "Legal Associate", "Compliance Counsel" },                
                ["Training"] = new[] { "L&D Coordinator", "Corporate Trainer" },
                ["UX"] = new[] { "UX Designer", "Senior UX Designer", "UX Researcher" },
                ["Facilities"] = new[] { "Facilities Coordinator", "Facilities Supervisor" },
                ["Network"] = new[] { "Network Engineer", "Network Operations Analyst" },
                ["Client Services"] = new[] { "Client Services Associate", "Client Services Manager", "Support Engineer" },
                ["Content Development"] = new[] { "Content Writer", "Content Editor" },
                ["Inventory"] = new[] { "Inventory Analyst", "Warehouse Coordinator" },
                ["Finance & Compliance"] = new[] { "Finance Analyst", "Compliance Analyst" },
                ["Administration"] = new[] { "Office Administrator", "Administrative Executive" },
                ["Digital Marketing"] = new[] { "SEO Specialist" },
                ["Coordinator"] = new[] { "Project Coordinator", "Program Coordinator" }
            };

            string[] firstNames =
            {
                "Aarav","Aditi","Akash","Alisha","Ananya","Anika","Arjun","Arnav","Benjamin","Celine",
                "Daniel","Ethan","Fatima","Grace","Ayra","Hrithik","Ishaan","Isha","James",
                "Jay","Karan","Liam","Lina","Maya","Meera","Michael","Naveen","Nikhil",
                "Noah","Olivia","Pranav","Rahul","Raj","Rhea","Riya","Rohit","Saanvi","Sanjay","Sara","Siddharth","Sneha","Vikram","Zara","Kavin","Aarushi","Ibrahim"
            };
            string[] lastNames =
            {
                "Agarwal","Baskaran","Bose","Chandra","Dixit","Fernandez","Gopal","Gupta","Iyer","Jain",
                "Joseph","Khan","Kumar","Mahesh","Mehta","Menon","Mukherjee","Nair","Naidu","Patel",
                "Prasad","Raghavan","Rai","Rajendran","Rao","Reddy","Seth","Shah","Sharma","Singh",
                "Thomas","Varma","Verma","Vijay","Williams","Wright","Yadav","Zachariah","Boyle","Collins",
                "Frost","Stewart","Turner","Brooks","Adams","Rogers","Foster","Reeves","Harris","Collins"
            };
            string[] teams = { "Frontend", "Backend", "DevOps", "QA", "Analytics", "Design", "Product" };
            string[] shifts = { "Regular Shift", "Night Shift", "Rotational Shift" };
            var baseStamp = new DateTime(2025, 10, 21, 10, 00, 0);
            var list = new List<EmployeeRecord>();
            var femaleFirstNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "Aditi","Alisha","Ananya","Anika","Celine","Fatima","Grace","Isha","Ayra",
                "Lina","Maya","Meera","Olivia","Priya","Rhea","Riya","Saanvi",
                "Sara","Sneha","Zara","Aarushi"
            };

            // Choose which CDN images to use for each gender
            int[] femaleAvatarPool = { 1, 3, 4, 5, 8, 9 };
            int[] maleAvatarPool = { 2, 5, 6, 7};

            for (int i = 0; i < 200; i++)
            {
                int id = 4001 + i;

                string first = firstNames[(i * 7 + 3) % firstNames.Length];
                string last = lastNames[(i * 11 + 5) % lastNames.Length];
                string name = $"{first} {last}";
                string dept = departments[(i * 5 + i / 9) % departments.Length];
                var rolePool = rolesByDepartment[dept];
                string role = rolePool[(i * 3 + i / 4) % rolePool.Length];
                string team = teams[i * i % teams.Length];
                int minutesDelta = (i * 9 % 61) + (i % 7) + 7;
                DateTime lastLogin = baseStamp.AddMinutes(minutesDelta * (i % 13 + 1));
                string shift = shifts[(i * 11 + i / 7) % shifts.Length];
                bool isFemale = femaleFirstNames.Contains(first);

                int imageIndex = isFemale
                    ? femaleAvatarPool[i % femaleAvatarPool.Length]
                    : maleAvatarPool[i % maleAvatarPool.Length];
                string imageUrl = $"https://cdn.syncfusion.com/blazor/images/data-grid/{imageIndex}.png";

                list.Add(new EmployeeRecord
                {
                    EmployeeID = id,
                    EmployeeName = name,
                    Email = GetMail(first, last, i),
                    Department = dept,
                    Role = role,
                    Team = team,
                    LastLoginAt = lastLogin,
                    Shift = shift,
                    EmployeeImage = imageUrl
                });
            }
            return list;
        }
    }
}
