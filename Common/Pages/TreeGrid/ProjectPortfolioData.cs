#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

namespace ProjectPortfolioData
{
    public class ProjectItem
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Status { get; set; } = "Planned"; // Planned, Active, At Risk, On Hold, Done
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public decimal Budget { get; set; }
        public decimal Spent { get; set; }
        public int Progress { get; set; } // 0-100
        public string Tags { get; set; } = string.Empty; // comma-separated tags

        public static List<ProjectItem> Get()
        {
            var now = DateTime.Today;
            var rnd = new Random(42);
            var statuses = new[] { "Planned", "Active", "At Risk", "On Hold", "Done" };
            var depts = new[] { "Product", "Design", "Platform", "Data", "Mobile", "Release", "Ops", "Marketing" };
            var owners = new[] { "Alicia Keys", "Brandon Lee", "Carla Gomez", "Daniel Park", "Ella Brown", "Fred Cole", "Grace Kim", "Henry Zhao", "Ivy Chen", "Jack Ryan" };
            var tags = new[] { "web", "ui", "ux", "tokens", "figma", "security", "oidc", "events", "kpis", "ios", "android", "release", "etl", "ci", "cd" };

            var list = new List<ProjectItem>();

            int rootCount = 50;   // 50 root programs
            int childPerRoot = 10; // each with 10 features/tasks => 550+ total

            int idSeq = 1000;
            for (int r = 1; r <= rootCount; r++)
            {
                var rootId = idSeq;
                var rStart = now.AddDays(-rnd.Next(15, 90));
                var rEnd = rStart.AddDays(rnd.Next(45, 150));
                var rBudget = rnd.Next(80_000, 200_000);
                var rSpent = (decimal)rnd.Next(10_000, rBudget - 5_000);
                list.Add(new ProjectItem
                {
                    Id = rootId,
                    ParentId = null,
                    Name = $"Program {r}: {owners[r % owners.Length].Split(' ')[0]} Initiative",
                    Owner = owners[r % owners.Length],
                    Department = depts[r % depts.Length],
                    Status = statuses[r % statuses.Length],
                    Start = rStart,
                    End = rEnd,
                    Budget = rBudget,
                    Spent = rSpent,
                    Progress = rnd.Next(5, 95),
                    Tags = $"{tags[r % tags.Length]},{tags[(r+3) % tags.Length]}"
                });

                for (int c = 1; c <= childPerRoot; c++)
                {
                    idSeq++;
                    var cStart = rStart.AddDays(rnd.Next(-10, 30));
                    var cEnd = cStart.AddDays(rnd.Next(20, 120));
                    var cBudget = rnd.Next(10_000, 60_000);
                    var cSpent = rnd.Next(0, cBudget);
                    list.Add(new ProjectItem
                    {
                        Id = idSeq,
                        ParentId = rootId,
                        Name = $"Feature {r}.{c}",
                        Owner = owners[(r + c) % owners.Length],
                        Department = depts[(r + c) % depts.Length],
                        Status = statuses[(r + c) % statuses.Length],
                        Start = cStart,
                        End = cEnd,
                        Budget = cBudget,
                        Spent = cSpent,
                        Progress = rnd.Next(0, 100),
                        Tags = $"{tags[(r + c) % tags.Length]},{tags[(r + c + 5) % tags.Length]}"
                    });
                }

                idSeq += 100 - childPerRoot; // jump to next hundred block for visual Id grouping
                idSeq++;
            }

            return list; // ~550 items
        }
    }
}