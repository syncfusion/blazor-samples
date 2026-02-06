#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskData
{
    public class TaskData
    {
        public static List<TaskData> tree = new List<TaskData>();
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
            string name = taskName.ToLowerInvariant();
            if (name.Contains("implement") && (name.Contains("frontend") || name.Contains("backend") ||
                name.Contains("integration") || name.Contains("oauth") || name.Contains("payment")))
                return "30";
            if (name.Contains("implement") || name.Contains("implementation"))
                return "20";
            if (name.Contains("analysis") && taskName.Length > 20)
                return "3";
            if (name.Contains("analysis") || name.Contains("wireframe") || name.Contains("audit"))
                return "2";
            if (name.Contains("error handling") && (name.Contains("failed") || name.Contains("fraud") || name.Contains("conflict")))
                return "12";
            if (name.Contains("error handling") || name.Contains("validation"))
                return "10";
            if (name.Contains("deploy") || name.Contains("deployment") || name.Contains("ota") || name.Contains("release"))
                return "9";
            return "5"; // Default for tests, setup, etc.
        }

        public static List<TaskData> GetTree()
        {
            tree.Clear();
            var modules = GetModules();
            var innerTasks = GetInnerTasks();
            int taskId = 1000;
            var rand = new Random();

            string[] parentProjects = {
                "Customer Portal Redesign", "Mobile App v2 Development", "Data Analytics Dashboard",
                "Admin Panel Revamp", "E-Commerce Platform Upgrade", "HR System Migration",
                "IoT Device Monitoring System", "Marketing Automation Suite"
            };

            // Temporary storage for tasks to calculate sums later
            var allTasks = new List<TaskData>();
            var parentToChildrenMap = new Dictionary<int, List<TaskData>>();

            foreach (var parent in parentProjects)
            {
                DateTime parentStart = new DateTime(2025, rand.Next(1, 12), rand.Next(1, 28));
                DateTime parentEnd = parentStart.AddDays(rand.Next(60, 120));
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

                foreach (var module in modules[parent])
                {
                    DateTime childStart = parentStart.AddDays(rand.Next(3, 15));
                    DateTime childEnd = childStart.AddDays(rand.Next(20, 45));
                    string childPriority = parent == "HR System Migration"
                        ? (rand.Next(0, 2) == 0 ? "Low" : "Normal")
                        : module.Contains("Auth") || module.Contains("Payment") || module.Contains("Security") ? "Critical" : "High";

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

                    if (innerTasks.ContainsKey(module))
                    {
                        int index = 0;
                        foreach (var inner in innerTasks[module])
                        {
                            int days = rand.Next(3, 14);
                            DateTime innerStart = childStart.AddDays(rand.Next(0, 5));
                            DateTime innerEnd = innerStart.AddDays(days);
                            string innerPriority = parent == "HR System Migration"
                                ? (rand.Next(0, 2) == 0 ? "Low" : "Normal")
                                : GetInnerPriority(childPriority, index++);

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
                                EstimatedCost = (days * 8 * 75).ToString(),
                                RICEScore = "1000",
                                BusinessValue = rand.Next(1, 4) switch { 1 => "21", 2 => "100", _ => "111" },
                                Approved = true,
                                StoryPoints = CalculateStoryPoints(inner)
                            };
                            allTasks.Add(innerTask);
                            parentToChildrenMap[childTask.TaskID].Add(innerTask);

                            childTask.Duration += days;
                            childTask.EstimatedCost = (double.Parse(childTask.EstimatedCost) + days * 8 * 75).ToString();
                        }
                    }
                }
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
                task.StoryPoints = totalSP > 0 ? totalSP.ToString() : "";
            }

            tree = allTasks;
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

        private static Dictionary<string, string[]> GetModules() => new()
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

        private static Dictionary<string, string[]> GetInnerTasks() => new()
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
    }
}