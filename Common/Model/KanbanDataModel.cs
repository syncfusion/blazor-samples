#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System;

namespace BlazorDemos.Model
{
    public class KanbanDataModel
    {
        public string Id { get; set; }
        public int ListId { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Summary { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }
        public List<string> CardTags { get; set; }
        public string Tags { get; set; }
        public double Estimate { get; set; }
        public string Assignee { get; set; }
        public int RankId { get; set; }
        public string Color { get; set; }
        public string Value { get; set; }
        public string OrderID { get; set; }
        public string Size { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string AssigneeKey { get; set; }
        public List<string> ClassName { get; set; }
        public DateTime? Date { get; set; }
        public string Timeline { get; set; }
        public bool AssigneeAvailability { get; set; }
        public DateTime? DueDate { get; set; }

        public List<KanbanDataModel> GetKanbanTasks()
        {
            DateTime today = DateTime.Now;
            // Calculate due dates
            DateTime dueDateYesterday = today.AddDays(-1);
            DateTime dueDateTomorrow = today.AddDays(1);
            DateTime dueDateNext2Days = today.AddDays(2);
            DateTime dueDateNext5Days = today.AddDays(5);
            var taskDetails = new List<KanbanDataModel>
            {
                new KanbanDataModel {
                    Id = "Task 1",
                    Title = "Task  - 29001",
                    Status = "Open",
                    Summary = "Analyze the new requirements gathered from the customer",
                    Type = "Story",
                    Priority = "Low",
                    CardTags = new List<string>() { "Analyze", "Customer" },
                    Color = "#8b447a",
                    ClassName = new List<string>() { "e-story", "e-low", "e-nancy" },
                    DueDate = dueDateYesterday,
                    Assignee = "Nancy"
                },
                new KanbanDataModel
                {
                    Id = "Task 2",
                    Title = "Task  - 29002",
                    Status = "InProgress",
                    Summary = "Improve application performance",
                    Type = "Improvement",
                    Priority = "Normal",
                    CardTags = new List<string>() { "Improvement" },
                    Color = "#7d7297",
                    ClassName = new List<string>() { "e-improvement", "e-normal", "e-andrew" },
                    DueDate = dueDateTomorrow,
                    Assignee = "Andrew"
                },
                new KanbanDataModel
                {
                    Id = "Task 3",
                    Title = "Task  - 29003",
                    Status = "Open",
                    Summary = "Arrange a web meeting with the customer to get new requirements",
                    Type = "Others",
                    Priority = "Critical",
                    CardTags = new List<string>() { "Meeting" },
                    Color = "#27AE60",
                    ClassName = new List<string>() { "e-others", "e-critical", "e-janet" },
                    DueDate =dueDateNext5Days,
                    Assignee = "Andrew"
                },
                new KanbanDataModel
                {
                    Id = "Task 4",
                    Title = "Task  - 29004",
                    Status = "InProgress",
                    Summary = "Fix the issues reported in the IE browser",
                    Type = "Bug",
                    Priority = "Release Breaker",
                    CardTags = new List<string>() { "IE" },
                    Color = "#cc0000",
                    ClassName = new List<string>() { "e-bug", "e-release", "e-janet" },
                    DueDate = dueDateTomorrow,
                    Assignee = "Janet"
                },
                new KanbanDataModel
                {
                    Id = "Task 5",
                    Title = "Task  - 29005",
                    Status = "Review",
                    Summary = "Fix the issues reported by the customer",
                    Type = "Bug",
                    Priority = "Low",
                    CardTags = new List<string>() { "Customer" },
                    Color = "#cc0000",
                    ClassName = new List<string>() { "e-bug", "e-low", "e-steven" },
                    DueDate = dueDateNext2Days,
                    Assignee = "Nancy"
                },
                new KanbanDataModel
                {
                    Id = "Task 6",
                    Title = "Task  - 29007",
                    Status = "Validate",
                    Summary = "Validate new requirements",
                    Type = "Improvement",
                    Priority = "Low",
                    CardTags = new List<string>() { "Validation" },
                    Color = "#7d7297",
                    ClassName = new List<string>() { "e-improvement", "e-low", "e-robert" },
                    DueDate = dueDateNext2Days,
                    Assignee = "Andrew"
                },
                new KanbanDataModel
                {
                    Id = "Task 7",
                    Title = "Task  - 29009",
                    Status = "Review",
                    Summary = "Fix the issues reported in Safari browser",
                    Type = "Bug",
                    Priority = "Release Breaker",
                    CardTags = new List<string>() { "Fix", "Safari" },
                    Color = "#cc0000",
                    ClassName = new List<string>() { "e-bug", "e-release", "e-nancy" },
                    DueDate = dueDateNext5Days,
                    Assignee = "Nancy"
                },
                new KanbanDataModel
                {
                    Id = "Task 8",
                    Title = "Task  - 29010",
                    Status = "Close",
                    Summary = "Test the application in the IE browser",
                    Type = "Story",
                    Priority = "Low",
                    CardTags = new List<string>() { "Review", "IE" },
                    Color = "#8b447a",
                    ClassName = new List<string>() { "e-story", "e-low", "e-Margaret" },
                    DueDate = dueDateNext5Days,
                    Assignee = "Andrew"
                },
                new KanbanDataModel
                {
                    Id = "Task 9",
                    Title = "Task  - 29011",
                    Status = "Validate",
                    Summary = "Validate the issues reported by the customer",
                    Type = "Story",
                    Priority = "High",
                    CardTags = new List<string>() { "Validation", "Fix" },
                    Color = "#8b447a",
                    ClassName = new List<string>() { "e-story", "e-low", "e-nancy" },
                    DueDate = dueDateTomorrow,
                    Assignee = "Nancy"
                },
                new KanbanDataModel
                {
                    Id = "Task 10",
                    Title = "Task  - 29015",
                    Status = "Open",
                    Summary = "Show the retrieved data from the server in grid control",
                    Type = "Story",
                    Priority = "High",
                    CardTags = new List<string>() { "Database", "SQL" },
                    Color = "#8b447a",
                    ClassName = new List<string>() { "e-story", "e-high", "e-steven" },
                    DueDate = dueDateTomorrow,
                    Assignee = "Janet"
                },
                new KanbanDataModel
                {
                    Id = "Task 11",
                    Title = "Task  - 29016",
                    Status = "InProgress",
                    Summary = "Fix cannot open user’s default database SQL error.",
                    Type = "Critical Bug",
                    Priority = "High",
                    CardTags = new List<string>() { "Fix", "SQL" },
                    Color = "#cc0000",
                    ClassName = new List<string>() { "e-bug", "e-release", "e-nancy" },
                    DueDate = dueDateNext5Days,
                    Assignee = "Nancy"
                },
                new KanbanDataModel
                {
                    Id = "Task 12",
                    Title = "Task  - 29017",
                    Status = "Review",
                    Summary = "Fix the issues reported in data binding.",
                    Type = "Story",
                    Priority = "Normal",
                    CardTags = new List<string>() { "Validation", "Fix" },
                    Color = "#8b447a",
                    ClassName = new List<string>() { "e-story", "e-normal", "e-steven" },
                    DueDate = dueDateNext5Days,
                    Assignee = "Andrew"
                },
                new KanbanDataModel
                {
                    Id = "Task 13",
                    Title = "Task  - 29018",
                    Status = "Close",
                    Summary = "Analyze stored procedures.",
                    Type = "Others",
                    Priority = "Critical",
                    CardTags = new List<string>() { "Database", "SQL" },
                    Color = "#27AE60",
                    ClassName = new List<string>() { "e-others", "e-critical", "e-nancy" },
                    DueDate = dueDateNext5Days,
                    Assignee = "Andrew"
                },
                new KanbanDataModel
                {
                    Id = "Task 14",
                    Title = "Task  - 29019",
                    Status = "Validate",
                    Summary = "Validate editing issues.",
                    Type = "Story",
                    Priority = "Critical",
                    CardTags = new List<string>() { "Fix" },
                    Color = "#8b447a",
                    ClassName = new List<string>() { "e-story", "e-low", "e-steven" },
                    DueDate = dueDateYesterday,
                    Assignee = "Nancy"
                },
                new KanbanDataModel
                {
                    Id = "Task 15",
                    Title = "Task  - 29020",
                    Status = "Review",
                    Summary = "Test editing functionality.",
                    Type = "Story",
                    Priority = "Normal",
                    CardTags = new List<string>() { "Testing" },
                    Color = "#8b447a",
                    ClassName = new List<string>() { "e-story", "e-normal", "e-andrew" },
                    DueDate = dueDateNext2Days,
                    Assignee = "Janet"
                },
                new KanbanDataModel
                {
                    Id = "Task 16",
                    Title = "Task  - 29021",
                    Status = "InProgress",
                    Summary = "Implement login functionality.",
                    Type = "Feature",
                    Priority = "High",
                    CardTags = new List<string>() { "Authentication" },
                    Color = "#7d7297",
                    ClassName = new List<string>() { "e-feature", "e-high", "e-andrew" },
                    DueDate = dueDateNext5Days,
                    Assignee = "Janet"
                },
                new KanbanDataModel
                {
                    Id = "Task 17",
                    Title = "Task  - 29022",
                    Status = "Validate",
                    Summary = "Update user profile page.",
                    Type = "Improvement",
                    Priority = "Normal",
                    CardTags = new List<string>() { "UI" },
                    Color = "#7d7297",
                    ClassName = new List<string>() { "e-improvement", "e-normal", "e-janet" },
                    DueDate = dueDateNext5Days,
                    Assignee = "Janet"
                },
                new KanbanDataModel
                {
                    Id = "Task 18",
                    Title = "Task  - 29023",
                    Status = "Close",
                    Summary = "Refactor codebase for better performance.",
                    Type = "Improvement",
                    Priority = "Critical",
                    CardTags = new List<string>() { "Refactor" },
                    Color = "#27AE60",
                    ClassName = new List<string>() { "e-improvement", "e-critical", "e-margaret" },
                    DueDate = dueDateNext5Days,
                    Assignee = "Nancy"
                },
                new KanbanDataModel
                {
                    Id = "Task 19",
                    Title = "Task  - 29024",
                    Status = "Validate",
                    Summary = "Test performance improvements.",
                    Type = "Story",
                    Priority = "High",
                    CardTags = new List<string>() { "Testing" },
                    Color = "#8b447a",
                    ClassName = new List<string>() { "e-story", "e-high", "e-steven" },
                    DueDate = dueDateYesterday,
                    Assignee = "Andrew"
                },
                new KanbanDataModel
                {
                    Id = "Task 20",
                    Title = "Task  - 29025",
                    Status = "Done",
                    Summary = "Implement dark mode feature.",
                    Type = "Feature",
                    Priority = "Normal",
                    CardTags = new List<string>() { "UI" },
                    Color = "#7d7297",
                    ClassName = new List<string>() { "e-feature", "e-normal", "e-robert" },
                    DueDate = dueDateNext5Days,
                    Assignee = "Janet"
                },
            };
            return taskDetails;
        }

        public List<KanbanDataModel> GetTasks()
        {
            var taskDetails = new List<KanbanDataModel>
            { 
                new KanbanDataModel {
                    Id = "Task 1",
                    Title = "Task  - 29001",
                    Status = "Open",
                    Summary = "Analyze the new requirements gathered from the customer",
                    Type = "Story",
                    Priority = "Low",
                    CardTags = new List<string>() { "Analyze", "Customer" },
                    Estimate = 3.5,
                    Assignee = "Nancy Davloio",
                    AssigneeKey = "Nancy Davloio",
                    RankId = 1,
                    Color = "#8b447a",
                    ClassName = new List<string>() { "e-story", "e-low", "e-nancy" },
                    Timeline = "2024-06-20 to 2024-06-25",
                    AssigneeAvailability = true
                },
                new KanbanDataModel
                {
                    Id = "Task 2",
                    Title = "Task  - 29002",
                    Status = "In Progress",
                    Summary = "Improve application performance",
                    Type = "Improvement",
                    Priority = "Normal",
                    CardTags = new List<string>() { "Improvement" },
                    Estimate = 6,
                    Assignee = "Andrew Fuller",
                    AssigneeKey = "Andrew Fuller",
                    RankId = 1,
                    Color = "#7d7297",
                    ClassName = new List<string>() { "e-improvement", "e-normal", "e-andrew" },
                    Timeline = "2024-06-20 to 2024-06-26",
                    AssigneeAvailability = true
                },
                new KanbanDataModel
                {
                    Id = "Task 3",
                    Title = "Task  - 29003",
                    Status = "Open",
                    Summary = "Arrange a web meeting with the customer to get new requirements",
                    Type = "Others",
                    Priority = "Critical",
                    CardTags = new List<string>() { "Meeting" },
                    Estimate = 5.5,
                    Assignee = "Janet Leverling",
                    AssigneeKey = "Janet Leverling",
                    RankId = 2,
                    Color = "#27AE60",
                    ClassName = new List<string>() { "e-others", "e-critical", "e-janet" },
                    Timeline = "2024-06-20 to 2024-06-25",
                    AssigneeAvailability = false
                },
                new KanbanDataModel
                {
                    Id = "Task 4",
                    Title = "Task  - 29004",
                    Status = "In Progress",
                    Summary = "Fix the issues reported in the IE browser",
                    Type = "Bug",
                    Priority = "Release Breaker",
                    CardTags = new List<string>() { "IE" },
                    Estimate = 2.5,
                    Assignee = "Janet Leverling",
                    AssigneeKey = "Janet Leverling",
                    RankId = 2,
                    Color = "#cc0000",
                    ClassName = new List<string>() { "e-bug", "e-release", "e-janet" },
                    Timeline = "2024-06-21 to 2024-06-23",
                    AssigneeAvailability = false
                },
                new KanbanDataModel
                {
                    Id = "Task 5",
                    Title = "Task  - 29005",
                    Status = "Review",
                    Summary = "Fix the issues reported by the customer",
                    Type = "Bug",
                    Priority = "Low",
                    CardTags = new List<string>() { "Customer" },
                    Estimate = 3.5,
                    Assignee = "Steven Walker",
                    AssigneeKey = "Steven Walker",
                    RankId = 1,
                    Color = "#cc0000",
                    ClassName = new List<string>() { "e-bug", "e-low", "e-steven" },
                    Timeline = "2024-06-22 to 2024-06-25",
                    AssigneeAvailability = true
                },
                new KanbanDataModel
                {
                    Id = "Task 6",
                    Title = "Task  - 29007",
                    Status = "Validate",
                    Summary = "Validate new requirements",
                    Type = "Improvement",
                    Priority = "Low",
                    CardTags = new List<string>() { "Validation" },
                    Estimate = 1.5,
                    Assignee = "Robert King",
                    AssigneeKey = "Robert King",
                    RankId = 1,
                    Color = "#7d7297",
                    ClassName = new List<string>() { "e-improvement", "e-low", "e-robert" },
                    Timeline = "2024-06-23 to 2024-06-24",
                    AssigneeAvailability = false
                },
                new KanbanDataModel
                {
                    Id = "Task 7",
                    Title = "Task  - 29009",
                    Status = "Review",
                    Summary = "Fix the issues reported in Safari browser",
                    Type = "Bug",
                    Priority = "Release Breaker",
                    CardTags = new List<string>() { "Fix", "Safari" },
                    Estimate = 1.5,
                    Assignee = "Nancy Davloio",
                    AssigneeKey = "Nancy Davloio",
                    RankId = 2,
                    Color = "#cc0000",
                    ClassName = new List<string>() { "e-bug", "e-release", "e-nancy" },
                    Timeline = "2024-06-23 to 2024-06-24",
                    AssigneeAvailability = true
                },
                new KanbanDataModel
                {
                    Id = "Task 8",
                    Title = "Task  - 29010",
                    Status = "Close",
                    Summary = "Test the application in the IE browser",
                    Type = "Story",
                    Priority = "Low",
                    CardTags = new List<string>() { "Review", "IE" },
                    Estimate = 5.5,
                    Assignee = "Margaret Hamilt",
                    AssigneeKey = "Margaret Hamilt",
                    RankId = 3,
                    Color = "#8b447a",
                    ClassName = new List<string>() { "e-story", "e-low", "e-Margaret" },
                    Timeline = "2024-06-20 to 2024-06-25",
                    AssigneeAvailability = false
                },
                new KanbanDataModel
                {
                    Id = "Task 9",
                    Title = "Task  - 29011",
                    Status = "Validate",
                    Summary = "Validate the issues reported by the customer",
                    Type = "Story",
                    Priority = "High",
                    CardTags = new List<string>() { "Validation", "Fix" },
                    Estimate = 1,
                    Assignee = "Steven Walker",
                    AssigneeKey = "Steven Walker",
                    RankId = 1,
                    Color = "#8b447a",
                    ClassName = new List<string>() { "e-story", "e-low", "e-nancy" },
                    Timeline = "2024-06-23 to 2024-06-24",
                    AssigneeAvailability = true
                },
                new KanbanDataModel
                {
                    Id = "Task 10",
                    Title = "Task  - 29015",
                    Status = "Open",
                    Summary = "Show the retrieved data from the server in grid control",
                    Type = "Story",
                    Priority = "High",
                    CardTags = new List<string>() { "Database", "SQL" },
                    Estimate = 5.5,
                    Assignee = "Margaret Hamilt",
                    AssigneeKey = "Margaret Hamilt",
                    RankId = 4,
                    Color = "#8b447a",
                    ClassName = new List<string>() { "e-story", "e-high", "e-steven" },
                    Timeline = "2024-06-22 to 2024-06-27",
                    AssigneeAvailability = false
                },
                new KanbanDataModel
                {
                    Id = "Task 11",
                    Title = "Task  - 29016",
                    Status = "In Progress",
                    Summary = "Fix cannot open user’s default database SQL error.",
                    Type = "Critical Bug",
                    Priority = "High",
                    CardTags = new List<string>() { "Fix", "SQL" },
                    Estimate = 2.5,
                    Assignee = "Margaret Hamilt",
                    AssigneeKey = "Margaret Hamilt",
                    RankId = 4,
                    Color = "#cc0000",
                    ClassName = new List<string>() { "e-bug", "e-release", "e-nancy" },
                    Timeline = "2024-06-20 to 2024-06-23",
                    AssigneeAvailability = false
                },
                new KanbanDataModel
                {
                    Id = "Task 12",
                    Title = "Task  - 29017",
                    Status = "Review",
                    Summary = "Fix the issues reported in data binding.",
                    Type = "Story",
                    Priority = "Normal",
                    CardTags = new List<string>() { "Validation", "Fix" },
                    Estimate = 3.5,
                    Assignee = "Margaret Hamilt",
                    AssigneeKey = "Margaret Hamilt",
                    RankId = 4,
                    Color = "#8b447a",
                    ClassName = new List<string>() { "e-story", "e-normal", "e-steven" },
                    Timeline = "2024-06-22 to 2024-06-25",
                    AssigneeAvailability = false
                },
                new KanbanDataModel
                {
                    Id = "Task 13",
                    Title = "Task  - 29018",
                    Status = "Close",
                    Summary = "Analyze stored procedures.",
                    Type = "Others",
                    Priority = "Critical",
                    CardTags = new List<string>() { "Database", "SQL" },
                    Estimate = 2,
                    Assignee = "Andrew Fuller",
                    AssigneeKey = "Andrew Fuller",
                    RankId = 3,
                    Color = "#27AE60",
                    ClassName = new List<string>() { "e-others", "e-critical", "e-nancy" },
                    Timeline = "2024-06-20 to 2024-06-23",
                    AssigneeAvailability = true
                },
                new KanbanDataModel
                {
                    Id = "Task 14",
                    Title = "Task  - 29019",
                    Status = "Validate",
                    Summary = "Validate editing issues.",
                    Type = "Story",
                    Priority = "Critical",
                    CardTags = new List<string>() { "Fix" },
                    Estimate = 1,
                    Assignee = "Robert King",
                    AssigneeKey = "Robert King",
                    RankId = 2,
                    Color = "#8b447a",
                    ClassName = new List<string>() { "e-story", "e-low", "e-steven" },
                    Timeline = "2024-06-21 to 2024-06-23",
                    AssigneeAvailability = false
                },
                new KanbanDataModel
                {
                    Id = "Task 15",
                    Title = "Task  - 29020",
                    Status = "Review",
                    Summary = "Test editing functionality.",
                    Type = "Story",
                    Priority = "Normal",
                    CardTags = new List<string>() { "Testing" },
                    Estimate = 0.5,
                    Assignee = "Janet Leverling",
                    AssigneeKey = "Janet Leverling",
                    RankId = 4,
                    Color = "#8b447a",
                    ClassName = new List<string>() { "e-story", "e-normal", "e-andrew" },
                    Timeline = "2024-06-22 to 2024-06-23",
                    AssigneeAvailability = false
                },
                new KanbanDataModel
                {
                    Id = "Task 16",
                    Title = "Task  - 29021",
                    Status = "In Progress",
                    Summary = "Implement login functionality.",
                    Type = "Feature",
                    Priority = "High",
                    CardTags = new List<string>() { "Authentication" },
                    Estimate = 4.5,
                    Assignee = "Andrew Fuller",
                    AssigneeKey = "Andrew Fuller",
                    RankId = 1,
                    Color = "#7d7297",
                    ClassName = new List<string>() { "e-feature", "e-high", "e-andrew" },
                    Timeline = "2024-06-20 to 2024-06-24",
                    AssigneeAvailability = true
                },
                new KanbanDataModel
                {
                    Id = "Task 17",
                    Title = "Task  - 29022",
                    Status = "Open",
                    Summary = "Update user profile page.",
                    Type = "Improvement",
                    Priority = "Normal",
                    CardTags = new List<string>() { "UI" },
                    Estimate = 3,
                    Assignee = "Janet Leverling",
                    AssigneeKey = "Janet Leverling",
                    RankId = 2,
                    Color = "#7d7297",
                    ClassName = new List<string>() { "e-improvement", "e-normal", "e-janet" },
                    Timeline = "2024-06-20 to 2024-06-25",
                    AssigneeAvailability = false
                },
                new KanbanDataModel
                {
                    Id = "Task 18",
                    Title = "Task  - 29023",
                    Status = "Close",
                    Summary = "Refactor codebase for better performance.",
                    Type = "Improvement",
                    Priority = "Critical",
                    CardTags = new List<string>() { "Refactor" },
                    Estimate = 6,
                    Assignee = "Margaret Hamilt",
                    AssigneeKey = "Margaret Hamilt",
                    RankId = 2,
                    Color = "#27AE60",
                    ClassName = new List<string>() { "e-improvement", "e-critical", "e-margaret" },
                    Timeline = "2024-06-20 to 2024-06-26",
                    AssigneeAvailability = false
                },
                new KanbanDataModel
                {
                    Id = "Task 19",
                    Title = "Task  - 29024",
                    Status = "Validate",
                    Summary = "Test performance improvements.",
                    Type = "Story",
                    Priority = "High",
                    CardTags = new List<string>() { "Testing" },
                    Estimate = 1.5,
                    Assignee = "Steven Walker",
                    AssigneeKey = "Steven Walker",
                    RankId = 3,
                    Color = "#8b447a",
                    ClassName = new List<string>() { "e-story", "e-high", "e-steven" },
                    Timeline = "2024-06-20 to 2024-06-21",
                    AssigneeAvailability = true
                },
                new KanbanDataModel
                {
                    Id = "Task 20",
                    Title = "Task  - 29025",
                    Status = "In Progress",
                    Summary = "Implement dark mode feature.",
                    Type = "Feature",
                    Priority = "Normal",
                    CardTags = new List<string>() { "UI" },
                    Estimate = 5,
                    Assignee = "Robert King",
                    AssigneeKey = "Robert King",
                    RankId = 2,
                    Color = "#7d7297",
                    ClassName = new List<string>() { "e-feature", "e-normal", "e-robert" },
                    Timeline = "2024-06-21 to 2024-06-26",
                    AssigneeAvailability = false
                }
            };
            return taskDetails;
        }
    }    

    public class SmartSuggestionDataModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Assignee { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public int StoryPoints { get; set; }
    }

    public class PizzaDataModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public List<string> CardTags { get; set; }
        public string OrderID { get; set; }
        public string Size { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public DateTime? Date { get; set; }
        public string Feedback { get; set; }
        public int? SentimentScore { get; set; }
        public string Emoji { get; set; }


        public List<PizzaDataModel> GetPizzaData()
        {
            var pizzaData = new List<PizzaDataModel>
            {
                new PizzaDataModel { Id= "1", OrderID= "Order ID - #16365", Title= "Mexican Green Wave", Type= "Vegetarian", Size="Small", Category="Order", Description= "Stromboli sandwich with chili sauce", CardTags = new List<string>() { "Onions", "Pepper", "Cheese" }, ImageURL= "menu-01", Price= "$4.79",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new PizzaDataModel { Id = "2", OrderID = "Order ID - #16367", Title = "Peppy Paneer", Type = "Vegetarian", Size = "Large", Category = "Ready to Serve", Description = "It's made using toppings of tomato, mozzarella cheese and fresh basil", CardTags = new List<string>() { "Onions", "Pepper", "Cheese" }, ImageURL = "menu-02", Price = "$14.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new PizzaDataModel { Id = "3", OrderID = "Order ID - #16372", Title = "Chicken Golden Delight", Type = "Non-Vegetarian", Size = "Large", Category = "Order", Description = "Barbeque chicken with a topping of golden corn loaded with extra cheese", CardTags = new List<string>() { "BBQ", "Prawn" }, ImageURL = "menu-07", Price = "$14.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new PizzaDataModel { Id = "4", OrderID = "Order ID - #16374", Title = "Chicken Fiesta", Type = "Non-Vegetarian", Size = "Small", Category = "Delivered", Feedback = "Good", Description = "Grilled Chicken Rashers with Peri-Peri chicken, Onion and Capsicum", CardTags = new List<string>() { "Chicken", "Capsicum" }, ImageURL = "menu-13", Price = "$4.79",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new PizzaDataModel { Id = "5", OrderID = "Order ID - #16375", Title = "Double Cheese Margherita", Type = "Vegetarian", Size = "Medium", Category = "Delivered", Feedback = "Best", Description = "Margherita with chili sauce and double Cheese", CardTags = new List<string>() { "Onions", "Pepper" }, ImageURL = "menu-10", Price = "$11.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new PizzaDataModel { Id = "6", OrderID = "Order ID - #16379", Title = "Chicken Dominator", Type = "Non-Vegetarian", Size = "Small", Category = "Menu", Description = "Double Pepper Barbecue Chicken with Peri-Peri Chicken, Chicken Tikka, Grilled and Rashers", CardTags = new List<string>() { "Pepper", "Chicken" }, ImageURL = "menu-15", Price = "$4.79",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new PizzaDataModel { Id = "9", OrderID = "Order ID - #16383", Title = "Margherita", Type = "Vegetarian", Size = "Large", Category = "Ready to Deliver", Description = "Lebanese Pizza topped with tomato sauce", CardTags = new List<string>() { "Pepper", "Cheese" }, ImageURL = "menu-18", Price = "$4.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new PizzaDataModel { Id = "10", OrderID = "Order ID - #16384", Title = "Pepper Barbecue and Onion", Type = "Non-Vegetarian", Size = "Medium", Category = "Ready to Deliver", Description = "Pepper Barbecue chicken with Onion", CardTags = new List<string>() { "Onions", "Chicken" }, ImageURL = "menu-20", Price = "$11.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                
            };
            return pizzaData;
        }
    }
}