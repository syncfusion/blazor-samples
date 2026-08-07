using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;

namespace BlazorDemos.Pages.TreeGrid
{
    public class TaskData
    {
        private static readonly List<TaskData> tree = new();
        public static IList<TaskData> TreeData => tree;

        public int TaskID { get; set; }
        public string? TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Progress { get; set; }
        public string? Priority { get; set; }
        public double? Duration { get; set; }
        public int? ParentID { get; set; }
        public bool? IsParent { get; set; }
        public bool? Approved { get; set; }
        public string? AssignedTo { get; set; }
        public string EstimatedCost { get; set; } = "0";
        public string RICEScore { get; set; } = "0";
        public string? BusinessValue { get; set; }
        public string StoryPoints { get; set; } = ""; // Now string, will be summed for parents

        public TaskData() { }

        // Helper: Returns story points as string based on task name
        private static string CalculateStoryPoints(string taskName)
        {
            if (string.IsNullOrWhiteSpace(taskName)) return "";
            string name = taskName.ToUpperInvariant();
            if (name.Contains("IMPLEMENT", StringComparison.Ordinal) && (name.Contains("FRONTEND", StringComparison.Ordinal) || name.Contains("BACKEND", StringComparison.Ordinal) ||
                name.Contains("INTEGRATION", StringComparison.Ordinal) || name.Contains("OAUTH", StringComparison.Ordinal) || name.Contains("PAYMENT", StringComparison.Ordinal)))
                return "30";
            if (name.Contains("IMPLEMENT", StringComparison.Ordinal) || name.Contains("IMPLEMENTATION", StringComparison.Ordinal))
                return "20";
            if (name.Contains("ANALYSIS", StringComparison.Ordinal) && taskName.Length > 20)
                return "3";
            if (name.Contains("ANALYSIS", StringComparison.Ordinal) || name.Contains("WIREFRAME", StringComparison.Ordinal) || name.Contains("AUDIT", StringComparison.Ordinal))
                return "2";
            if (name.Contains("ERROR HANDLING", StringComparison.Ordinal) && (name.Contains("FAILED", StringComparison.Ordinal) || name.Contains("FRAUD", StringComparison.Ordinal) || name.Contains("CONFLICT", StringComparison.Ordinal)))
                return "12";
            if (name.Contains("ERROR HANDLING", StringComparison.Ordinal) || name.Contains("VALIDATION", StringComparison.Ordinal))
                return "10";
            if (name.Contains("DEPLOY", StringComparison.Ordinal) || name.Contains("DEPLOYMENT", StringComparison.Ordinal) || name.Contains("OTA", StringComparison.Ordinal) || name.Contains("RELEASE", StringComparison.Ordinal))
                return "9";
            return "5"; // Default for tests, setup, etc.
        }

        public static IReadOnlyList<TaskData> GetTree()
        {
            tree.Clear();
            var modules = GetModules();
            var innerTasks = GetInnerTasks();
            int taskId = 1000;

            string[] parentProjects = {
        "Customer Portal Redesign", "Mobile App v2 Development", "Data Analytics Dashboard",
        "Admin Panel Revamp", "E-Commerce Platform Upgrade", "HR System Migration",
        "IoT Device Monitoring System", "Marketing Automation Suite"
    };

            // Temporary storage for tasks to calculate sums later
            var allTasks = new List<TaskData>();
            var parentToChildrenMap = new Dictionary<int, List<TaskData>>();

            int pIndex = 0;

            foreach (var parent in parentProjects)
            {
                // ✅ Deterministic parent dates
                DateTime parentStart = new DateTime(2025, 1 + (pIndex % 12), 1 + (pIndex % 28));
                DateTime parentEnd = parentStart.AddDays(60 + (pIndex % 60));

                string parentPriority = parent == "HR System Migration" ? "Normal" : "Critical";

                var parentTask = new TaskData
                {
                    TaskID = taskId++,
                    TaskName = parent,
                    ParentID = null,
                    IsParent = true,
                    Priority = parentPriority,
                    Progress = "In Progress",
                    AssignedTo = "Project Manager",
                    StartDate = parentStart,
                    EndDate = parentEnd,
                    Duration = (parentEnd - parentStart).Days,
                    EstimatedCost = "0",
                    RICEScore = "8000",
                    Approved = true,
                    StoryPoints = "" // Will be calculated later
                };
                allTasks.Add(parentTask);
                parentToChildrenMap[parentTask.TaskID] = new List<TaskData>();

                int mIndex = 0;

                foreach (var module in modules[parent])
                {
                    // ✅ Deterministic child scheduling
                    DateTime childStart = parentStart.AddDays(3 + (mIndex % 12));
                    DateTime childEnd = childStart.AddDays(20 + (mIndex % 25));

                    string childPriority = parent == "HR System Migration"
                        ? (mIndex % 2 == 0 ? "Low" : "Normal")
                        : module.Contains("Auth", StringComparison.Ordinal) ||
                          module.Contains("Payment", StringComparison.Ordinal) ||
                          module.Contains("Security", StringComparison.Ordinal)
                            ? "Critical"
                            : "High";

                    var childTask = new TaskData
                    {
                        TaskID = taskId++,
                        TaskName = module,
                        ParentID = parentTask.TaskID,
                        IsParent = true,
                        Priority = childPriority,
                        Progress = "Open",
                        AssignedTo = "Tech Lead",
                        StartDate = childStart,
                        EndDate = childEnd,
                        Duration = 0,
                        EstimatedCost = "0",
                        RICEScore = "2000",
                        Approved = true,
                        StoryPoints = "" // Will be summed
                    };
                    allTasks.Add(childTask);
                    parentToChildrenMap[parentTask.TaskID].Add(childTask);
                    parentToChildrenMap[childTask.TaskID] = new List<TaskData>();

                    if (innerTasks.TryGetValue(module, out var value))
                    {
                        int index = 0;
                        foreach (var inner in value)
                        {
                            // ✅ Deterministic inner values
                            int days = 3 + (index % 11);
                            DateTime innerStart = childStart.AddDays(index % 5);
                            DateTime innerEnd = innerStart.AddDays(days);
                            string innerPriority = parent == "HR System Migration"
                                ? (index % 2 == 0 ? "Low" : "Normal")
                                : GetInnerPriority(childPriority, index);

                            var innerTask = new TaskData
                            {
                                TaskID = taskId++,
                                TaskName = inner,
                                ParentID = childTask.TaskID,
                                IsParent = false,
                                Priority = innerPriority,
                                Progress = innerPriority == "Critical" ? "In Progress" : "Open",
                                AssignedTo = "Developer",
                                StartDate = innerStart,
                                EndDate = innerEnd,
                                Duration = days,
                                EstimatedCost = (days * 8 * 75).ToString(CultureInfo.InvariantCulture),
                                RICEScore = "1000",
                                BusinessValue = (index % 3) switch
                                {
                                    0 => "21",
                                    1 => "100",
                                    _ => "111"
                                },
                                Approved = true,
                                StoryPoints = CalculateStoryPoints(inner)
                            };
                            allTasks.Add(innerTask);
                            parentToChildrenMap[childTask.TaskID].Add(innerTask);

                            childTask.Duration += days;
                            childTask.EstimatedCost =
                                (double.Parse(childTask.EstimatedCost, CultureInfo.InvariantCulture) + days * 8 * 75)
                                .ToString(CultureInfo.InvariantCulture);

                            index++;
                        }
                    }

                    mIndex++;
                }

                pIndex++;
            }

            // Now calculate and assign StoryPoints sum for all parent tasks (bottom-up)
            foreach (var task in allTasks.Where(t => t.IsParent == true).OrderByDescending(t => t.TaskID))
            {
                var children = allTasks.Where(t => t.ParentID == task.TaskID).ToList();
                int totalSP = 0;
                foreach (var child in children)
                {
                    if (!string.IsNullOrEmpty(child.StoryPoints) && int.TryParse(child.StoryPoints, out int sp))
                    {
                        totalSP += sp;
                    }
                }
                task.StoryPoints = totalSP > 0 ? totalSP.ToString(CultureInfo.InvariantCulture) : "";
            }

            tree.AddRange(allTasks);
            return tree;
        }

        private static string GetInnerPriority(string parentPriority, int index)
        {
            return parentPriority switch
            {
                "Critical" => index % 2 == 0 ? "Critical" : "High",
                "High" => index % 3 == 0 ? "Critical" : "High",
                _ => "Normal"
            };
        }
        private static Dictionary<string, string[]> GetModules() => Modules;
        private static Dictionary<string, string[]> GetInnerTasks() => InnerTasks;

        private static readonly Dictionary<string, string[]> Modules = new()
        {
            { "Customer Portal Redesign", new[] { "Authentication & Login Flow", "User Profile Management", "Dashboard UI Layout", "Notification Center", "Accessibility Compliance" } },
            { "Mobile App v2 Development", new[] { "Push Notification Service", "Offline Data Sync", "Payment Gateway Integration", "App Security Enhancements" } },
            { "Data Analytics Dashboard", new[] { "Chart Rendering Engine", "Filter & Query Logic", "Export to Excel/PDF", "KPI Metrics Setup" } },
            { "Admin Panel Revamp", new[] { "Role Management Module", "Audit Log Tracking", "Settings UI Redesign", "Multi-Factor Authentication" } },
            { "E-Commerce Platform Upgrade", new[] { "Product Catalog Service", "Shopping Cart Flow", "Checkout & Payments", "Order Tracking" } },
            { "HR System Migration", new[] { "Employee Records Import", "Payroll Integration", "Leave Management", "Recruitment Module" } },
            { "IoT Device Monitoring System", new[] { "Device Registration", "Sensor Data Collection", "Real-Time Alerts", "Firmware Updates" } },
            { "Marketing Automation Suite", new[] { "Campaign Builder", "Email Templates", "Audience Segmentation", "Analytics Dashboard" } }
        };

        private static Dictionary<string, string[]> InnerTasks = new()
        {
            { "Authentication & Login Flow", new[] { "Analysis of login flow", "Implement OAuth2/SSO", "Unit Tests for Login", "Error Handling for Failed Login" } },
            { "User Profile Management", new[] { "Profile CRUD Operations", "Validation Rules", "Integration with DB" } },
            { "Dashboard UI Layout", new[] { "Wireframe Design", "Frontend Implementation", "Accessibility Review" } },
            { "Notification Center", new[] { "Email Alerts", "Push Notifications", "Error Logging" } },
            { "Accessibility Compliance", new[] { "WCAG Audit", "Keyboard Navigation", "Screen Reader Support" } },
            { "Push Notification Service", new[] { "Setup Firebase/APNS", "Integration Tests", "Retry Logic" } },
            { "Offline Data Sync", new[] { "Local Storage Setup", "Conflict Resolution", "Sync Scheduler" } },
            { "Payment Gateway Integration", new[] { "Integrate Stripe/PayPal", "Transaction Logging", "Fraud Detection" } },
            { "App Security Enhancements", new[] { "Encryption Setup", "Penetration Testing", "Secure Storage" } },
            { "Chart Rendering Engine", new[] { "Implement ChartJS", "Performance Optimization", "Unit Tests" } },
            { "Filter & Query Logic", new[] { "Dynamic Filters", "SQL Optimization", "Validation" } },
            { "Export to Excel/PDF", new[] { "Excel Export", "PDF Export", "Error Handling" } },
            { "KPI Metrics Setup", new[] { "Define KPIs", "Data Pipeline", "Validation" } },
            { "Role Management Module", new[] { "Role CRUD", "Permission Matrix", "Unit Tests" } },
            { "Audit Log Tracking", new[] { "Log Schema Design", "Integration with DB", "Export Reports" } },
            { "Settings UI Redesign", new[] { "UI Wireframe", "Frontend Implementation", "Accessibility Review" } },
            { "Multi-Factor Authentication", new[] { "OTP Setup", "SMS/Email Integration", "Error Handling" } },
            { "Product Catalog Service", new[] { "Catalog CRUD", "Search Optimization", "Validation" } },
            { "Shopping Cart Flow", new[] { "Add/Remove Items", "Discount Application", "Error Handling" } },
            { "Checkout & Payments", new[] { "Payment Gateway Integration", "Transaction Logging", "Fraud Detection" } },
            { "Order Tracking", new[] { "Order Status Updates", "Notifications", "Error Handling" } },
            { "Employee Records Import", new[] { "Data Migration", "Validation", "Error Handling" } },
            { "Payroll Integration", new[] { "Salary Calculation", "Bank API Integration", "Validation" } },
            { "Leave Management", new[] { "Leave Request Workflow", "Approval Rules", "Error Handling" } },
            { "Recruitment Module", new[] { "Job Posting", "Candidate Screening", "Interview Scheduling" } },
            { "Device Registration", new[] { "Device Onboarding", "Validation", "Error Handling" } },
            { "Sensor Data Collection", new[] { "Data Pipeline Setup", "Validation", "Error Handling" } },
            { "Real-Time Alerts", new[] { "Alert Rules", "Notification Setup", "Error Handling" } },
            { "Firmware Updates", new[] { "OTA Update Setup", "Validation", "Error Handling" } },
            { "Campaign Builder", new[] { "Template Design", "Workflow Setup", "Validation" } },
            { "Email Templates", new[] { "Design Templates", "Validation", "Error Handling" } },
            { "Audience Segmentation", new[] { "Segmentation Rules", "Validation", "Error Handling" } },
            { "Analytics Dashboard", new[] { "Metrics Setup", "Visualization", "Validation" } }
        };
        public static IReadOnlyList<TaskData> GetTreeStatic()
        {
            // Clear and rebuild deterministically
            tree.Clear();

            var modules = GetModules();
            var innerTasks = GetInnerTasks();
            int taskId = 1000;

            // Fixed order of parents (same as your current code)
            string[] parentProjects = {
        "Customer Portal Redesign", "Mobile App v2 Development", "Data Analytics Dashboard",
        "Admin Panel Revamp", "E-Commerce Platform Upgrade", "HR System Migration",
        "IoT Device Monitoring System", "Marketing Automation Suite"
    };

            // Deterministic schedules for parents
            DateTime[] parentStartDates = {
        new DateTime(2025, 01, 05),
        new DateTime(2025, 02, 10),
        new DateTime(2025, 03, 03),
        new DateTime(2025, 04, 07),
        new DateTime(2025, 05, 12),
        new DateTime(2025, 06, 02),
        new DateTime(2025, 07, 08),
        new DateTime(2025, 08, 04)
    };

            int[] parentDurationsDays = { 90, 75, 80, 70, 95, 85, 88, 92 }; // end = start + duration

            // Deterministic child offsets and durations (per module index)
            int[] childStartOffsets = { 5, 10, 15, 20, 12 };  // days from parent start
            int[] childDurations = { 35, 30, 28, 32, 26 };  // days for each module

            // Deterministic inner task offsets, durations, and business values
            int[] innerStartOffsetSeries = { 0, 1, 2, 3, 4 };
            int[] innerDurationsSeries = { 5, 7, 9, 6, 8, 10, 11 };
            string[] businessValueSeries = { "21", "100", "111" };

            var allTasks = new List<TaskData>();

            for (int p = 0; p < parentProjects.Length; p++)
            {
                string parent = parentProjects[p];
                DateTime parentStart = parentStartDates[p];
                DateTime parentEnd = parentStart.AddDays(parentDurationsDays[p]);
                string parentPriority = parent == "HR System Migration" ? "Normal" : "Critical";

                var parentTask = new TaskData
                {
                    TaskID = taskId++,
                    TaskName = parent,
                    ParentID = null,
                    IsParent = true,
                    Priority = parentPriority,
                    Progress = "In Progress",
                    AssignedTo = "Project Manager",
                    StartDate = parentStart,
                    EndDate = parentEnd,
                    Duration = (parentEnd - parentStart).Days,
                    EstimatedCost = "0",
                    RICEScore = "8000",
                    Approved = true,
                    StoryPoints = "" // will be computed bottom-up
                };
                allTasks.Add(parentTask);

                // Modules for this parent (order preserved)
                var parentModules = modules[parent];

                for (int m = 0; m < parentModules.Length; m++)
                {
                    string module = parentModules[m];

                    DateTime childStart = parentStart.AddDays(childStartOffsets[m % childStartOffsets.Length]);
                    DateTime childEnd = childStart.AddDays(childDurations[m % childDurations.Length]);

                    // Keep your priority logic for children
                    string childPriority =
                        parent == "HR System Migration"
                        ? (m % 2 == 0 ? "Low" : "Normal")
                        : (module.Contains("Auth", StringComparison.OrdinalIgnoreCase)
                           || module.Contains("Payment", StringComparison.OrdinalIgnoreCase)
                           || module.Contains("Security", StringComparison.OrdinalIgnoreCase)
                           || module.Contains("OTP", StringComparison.OrdinalIgnoreCase)
                           || module.Contains("MFA", StringComparison.OrdinalIgnoreCase))
                            ? "Critical"
                            : "High";

                    var childTask = new TaskData
                    {
                        TaskID = taskId++,
                        TaskName = module,
                        ParentID = parentTask.TaskID,
                        IsParent = true,
                        Priority = childPriority,
                        Progress = "Open",
                        AssignedTo = "Tech Lead",
                        StartDate = childStart,
                        EndDate = childEnd,
                        Duration = 0,          // will sum from inners
                        EstimatedCost = "0",   // will sum from inners
                        RICEScore = "2000",
                        Approved = true,
                        StoryPoints = ""       // will sum from inners
                    };
                    allTasks.Add(childTask);

                    // Inner tasks (order preserved)
                    if (innerTasks.TryGetValue(module, out var inners))
                    {
                        for (int i = 0; i < inners.Length; i++)
                        {
                            string inner = inners[i];

                            int startOffset = innerStartOffsetSeries[i % innerStartOffsetSeries.Length];
                            int days = innerDurationsSeries[i % innerDurationsSeries.Length];

                            DateTime innerStart = childStart.AddDays(startOffset);
                            DateTime innerEnd = innerStart.AddDays(days);

                            // Keep your inner priority logic
                            string innerPriority = GetInnerPriority(childPriority, i);

                            var innerTask = new TaskData
                            {
                                TaskID = taskId++,
                                TaskName = inner,
                                ParentID = childTask.TaskID,
                                IsParent = false,
                                Priority = innerPriority,
                                Progress = innerPriority == "Critical" ? "In Progress" : "Open",
                                AssignedTo = "Developer",
                                StartDate = innerStart,
                                EndDate = innerEnd,
                                Duration = days,
                                EstimatedCost = (days * 8 * 75).ToString(CultureInfo.InvariantCulture),
                                RICEScore = "1000",
                                BusinessValue = businessValueSeries[i % businessValueSeries.Length],
                                Approved = true,
                                StoryPoints = CalculateStoryPoints(inner)
                            };
                            allTasks.Add(innerTask);

                            // Roll up to child
                            childTask.Duration += days;
                            childTask.EstimatedCost = (double.Parse(childTask.EstimatedCost, CultureInfo.InvariantCulture) + days * 8 * 75).ToString(CultureInfo.InvariantCulture);
                        }
                    }
                }
            }

            // Bottom-up StoryPoints rollup for parents (unchanged logic)
            foreach (var task in allTasks.Where(t => t.IsParent == true).OrderByDescending(t => t.TaskID))
            {
                var children = allTasks.Where(t => t.ParentID == task.TaskID).ToList();
                int totalSP = 0;
                foreach (var child in children)
                {
                    if (!string.IsNullOrEmpty(child.StoryPoints) && int.TryParse(child.StoryPoints, out int sp))
                        totalSP += sp;
                }
                task.StoryPoints = totalSP > 0 ? totalSP.ToString(CultureInfo.InvariantCulture) : "";
            }

            tree.AddRange(allTasks);
            return tree;
        }
    }
}