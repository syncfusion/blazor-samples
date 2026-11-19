using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;


namespace BlazorDemos.Pages.TreeGrid
{
    public class EmployeeData
    {
        public string? Name { get; set; }
        public string? FullName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime JoinedDate { get; set; }
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
        public string Email => string.Concat((FullName ?? Name ?? "user").Select(char.ToLowerInvariant)) + "@example.com";

        public static IReadOnlyList<EmployeeData> GetTemplateData()
        {
            var data = new List<EmployeeData>(500);

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

            string[] firstNames = {
            "James","Sophia","William","Emma","Oliver","Isabella","Liam","Ava",
            "Noah","Mia","Lucas","Charlotte","Amelia","Ethan","Harper"
        };

            string[] lastNames = {
            "Carter","Turner","Brown","Davis","Wilson","Moore","Taylor","Anderson",
            "Thomas","Jackson","Walker","Harris","Martin","Lewis","Lee"
        };

            string[] addresses = {
            "123 Main St, New York","456 Oak Ave, Chicago","789 Pine Rd, London",
            "321 Elm St, Seattle","555 Maple Dr, Los Angeles",
            "22 King St, London","94 Lakeview Rd, Chicago"
        };

            string[] phones = {
            "(555) 123-4567","(206) 555-0198","(71) 555-4848",
            "(831) 758-7368","(213) 555-9012","(415) 555-7777"
        };

            string[] countries = {
            "New York, USA","London, UK","Seattle, WA",
            "Los Angeles, CA","Chicago, IL","San Francisco, CA"
        };

            // ✅ Deterministic helpers (NO RANDOM)

            string RandName(int i) =>
                $"{firstNames[i % firstNames.Length]} {lastNames[i % lastNames.Length]}";

            string RandAddr(int i) => addresses[i % addresses.Length];
            string RandPhone(int i) => phones[i % phones.Length];
            string RandCountry(int i) => countries[i % countries.Length];

            DateTime RandParentDOB(int i) =>
                new DateTime(1968 + (i % 18), (i % 12) + 1, (i % 27) + 1);

            DateTime RandChildDOB(int i) =>
                new DateTime(1978 + (i % 18), ((i + 3) % 12) + 1, ((i + 5) % 27) + 1);

            int id = 1;

            for (int p = 1; p <= 100; p++)
            {
                // ✅ Parent
                var pname = RandName(p);
                var pDob = RandParentDOB(p);
                int parentId = id++;

                data.Add(new EmployeeData
                {
                    Name = pname,
                    FullName = pname,
                    Designation = parentTitles[(p - 1) % parentTitles.Length],
                    EmployeeID = parentId,
                    EmpID = $"EMP{parentId:D3}",
                    Address = RandAddr(p),
                    Contact = RandPhone(p),
                    Country = RandCountry(p),
                    DOB = pDob,
                    JoinedDate = pDob.AddYears(22),
                    ParentId = null,
                    IsAvailable = true,
                    Availability = "Yes",
                    Rating = 4 + (p % 2) // 4 or 5
                });

                var group = childTitleGroups[(p - 1) % childTitleGroups.Length];

                // ✅ Children
                for (int c = 0; c < 4; c++)
                {
                    int idx = p * 10 + c;

                    var cname = RandName(idx);
                    var cDob = RandChildDOB(idx);
                    int childId = id++;

                    bool isAvailable = (idx % 4) != 0;

                    data.Add(new EmployeeData
                    {
                        Name = cname,
                        FullName = cname,
                        Designation = group[c],
                        EmployeeID = childId,
                        EmpID = $"EMP{childId:D3}",
                        Address = RandAddr(idx),
                        Contact = RandPhone(idx),
                        Country = RandCountry(idx),
                        DOB = cDob,
                        JoinedDate = cDob.AddYears(22),
                        ParentId = parentId,
                        IsAvailable = isAvailable,
                        Availability = isAvailable ? "Yes" : "No",
                        Rating = 2 + (idx % 4) // 2–5
                    });
                }
            }

            return data;
        }
    }
}