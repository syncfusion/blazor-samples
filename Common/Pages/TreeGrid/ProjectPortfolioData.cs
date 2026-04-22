#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
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

        // Static, deterministic data generator (no randomness)
        public static List<ProjectItem> Get()
        {
            var baseDate = new DateTime(2025, 01, 15); // fixed anchor date
            var statuses = new[] { "Planned", "Active", "At Risk", "On Hold", "Done" };
            var depts = new[] { "Product", "Design", "Platform", "Data", "Mobile", "Release", "Ops", "Marketing" };
            var owners = new[] { "Alicia Keys", "Brandon Lee", "Carla Gomez", "Daniel Park", "Ella Brown", "Fred Cole", "Grace Kim", "Henry Zhao", "Ivy Chen", "Jack Ryan" };
            var tags = new[] { "web", "ui", "ux", "tokens", "figma", "security", "oidc", "events", "kpis", "ios", "android", "release", "etl", "ci", "cd" };

            var list = new List<ProjectItem>();
            int rootCount = 50;
            int childPerRoot = 10;
            int idSeq = 1000;

            for (int r = 1; r <= rootCount; r++)
            {
                var rootId = idSeq;

                // Deterministic timeline and money using simple formulas on index
                var rStartOffset = 15 + (r % 76);              // 15..90
                var rDur = 45 + (r % 106);                     // 45..150
                var rStart = baseDate.AddDays(-rStartOffset);
                var rEnd = rStart.AddDays(rDur);

                var rBudget = 80_000 + ((r * 2) % 121) * 1000; // 80,000..200,000 step 1k
                var rSpentPct = 20 + (r % 70);                 // 20..89
                var rSpent = Math.Round((decimal)rSpentPct / 100m * rBudget, 2);

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
                    Progress = 5 + (r % 90),                    // 5..94
                    Tags = $"{tags[r % tags.Length]},{tags[(r + 3) % tags.Length]}"
                });

                for (int c = 1; c <= childPerRoot; c++)
                {
                    idSeq++;

                    var cStart = rStart.AddDays((-10 + (r + c) % 40)); // -10..29 days from rStart
                    var cDur = 20 + ((r * c) % 101);                   // 20..120
                    var cEnd = cStart.AddDays(cDur);

                    var cBudget = 10_000 + ((r + c) % 51) * 1_000;     // 10,000..60,000
                    var cSpentPct = (10 + ((r * 7 + c * 13) % 85));    // 10..94
                    var cSpent = Math.Round((decimal)cSpentPct / 100m * cBudget, 2);

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
                        Progress = (r * 3 + c * 7) % 101,            // 0..100
                        Tags = $"{tags[(r + c) % tags.Length]},{tags[(r + c + 5) % tags.Length]}"
                    });
                }

                // keep same ID spacing pattern
                idSeq += 100 - childPerRoot;
                idSeq++;
            }

            return list; // ~550 items
        }
    }
}
