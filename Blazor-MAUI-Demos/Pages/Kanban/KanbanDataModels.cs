#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System;

namespace Syncfusion.Blazor.KanbanDemo
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


        public List<KanbanDataModel> GetTasks()
        {
            var taskDetails = new List<KanbanDataModel>
            {
                new KanbanDataModel { Id = "Task 1", Title = "Task  - 29001", Status = "Open", Summary = "Analyze the new requirements gathered from the customer", Type = "Story", Priority = "Low", CardTags = new List<string>() { "Analyze", "Customer" }, Estimate = 3.5, Assignee = "Nancy Davloio", AssigneeKey = "Nancy Davloio", RankId = 1, Color = "#8b447a", ClassName = new List<string>() { "e-story", "e-low", "e-nancy" } },
                new KanbanDataModel { Id = "Task 2", Title = "Task  - 29002", Status = "In Progress", Summary = "Improve application performance", Type = "Improvement", Priority = "Normal", CardTags = new List<string>() { "Improvement" }, Estimate = 6, Assignee = "Andrew Fuller", AssigneeKey = "Andrew Fuller", RankId = 1, Color = "#7d7297", ClassName = new List<string>() { "e-improvement", "e-normal", "e-andrew" } },
                new KanbanDataModel { Id = "Task 3", Title = "Task  - 29003", Status = "Open", Summary = "Arrange a web meeting with the customer to get new requirements", Type = "Others", Priority = "Critical", CardTags = new List<string>() { "Meeting" }, Estimate = 5.5, Assignee = "Janet Leverling", AssigneeKey = "Janet Leverling", RankId = 2, Color = "#27AE60", ClassName = new List<string>() { "e-others", "e-critical", "e-janet" } },
                new KanbanDataModel { Id = "Task 4", Title = "Task  - 29004", Status = "In Progress", Summary = "Fix the issues reported in the IE browser", Type = "Bug", Priority = "Release Breaker", CardTags = new List<string>() { "IE" }, Estimate = 2.5, Assignee = "Janet Leverling", AssigneeKey = "Janet Leverling", RankId = 2, Color = "#cc0000", ClassName = new List<string>() { "e-bug", "e-release", "e-janet" } },
                new KanbanDataModel { Id = "Task 5", Title = "Task  - 29005", Status = "Review", Summary = "Fix the issues reported by the customer", Type = "Bug", Priority = "Low", CardTags = new List<string>() { "Customer" }, Estimate = 3.5, Assignee = "Steven Walker", AssigneeKey = "Steven Walker", RankId = 1, Color = "#cc0000", ClassName = new List<string>() { "e-bug", "e-low", "e-steven" } },
                new KanbanDataModel { Id = "Task 6", Title = "Task  - 29007", Status = "Validate", Summary = "Validate new requirements", Type = "Improvement", Priority = "Low", CardTags = new List<string>() { "Validation" }, Estimate = 1.5, Assignee = "Robert King", AssigneeKey = "Robert King", RankId = 1, Color = "#7d7297", ClassName = new List<string>() { "e-improvement", "e-low", "e-robert" } },
                new KanbanDataModel { Id = "Task 7", Title = "Task  - 29009", Status = "Review", Summary = "Fix the issues reported in Safari browser", Type = "Bug", Priority = "Release Breaker", CardTags = new List<string>() { "Fix", "Safari" }, Estimate = 1.5, Assignee = "Nancy Davloio", AssigneeKey = "Nancy Davloio", RankId = 2, Color = "#cc0000", ClassName = new List<string>() { "e-bug", "e-release", "e-nancy" } },
                new KanbanDataModel { Id = "Task 8", Title = "Task  - 29010", Status = "Close", Summary = "Test the application in the IE browser", Type = "Story", Priority = "Low", CardTags = new List<string>() { "Review", "IE" }, Estimate = 5.5, Assignee = "Margaret Hamilt", AssigneeKey = "Margaret Hamilt", RankId = 3, Color = "#8b447a", ClassName = new List<string>() { "e-story", "e-low", "e-Margaret" } },
                new KanbanDataModel { Id = "Task 9", Title = "Task  - 29011", Status = "Validate", Summary = "Validate the issues reported by the customer", Type = "Story", Priority = "High", CardTags = new List<string>() { "Validation", "Fix" }, Estimate = 1, Assignee = "Steven Walker", AssigneeKey = "Steven Walker", RankId = 1, Color = "#8b447a", ClassName = new List<string>() { "e-story", "e-low", "e-nancy" } },
                new KanbanDataModel { Id = "Task 10", Title = "Task  - 29015", Status = "Open", Summary = "Show the retrieved data from the server in grid control", Type = "Story", Priority = "High", CardTags = new List<string>() { "Database", "SQL" }, Estimate = 5.5, Assignee = "Margaret Hamilt", AssigneeKey = "Margaret Hamilt", RankId = 4, Color = "#8b447a", ClassName = new List<string>() { "e-story", "e-high", "e-steven" } },
                new KanbanDataModel { Id = "Task 11", Title = "Task  - 29016", Status = "In Progress", Summary = "Fix cannot open user’s default database SQL error", Priority = "Critical", Type = "High", CardTags = new List<string>() { "Database", "Sql2008" }, Estimate = 2.5, Assignee = "Janet Leverling", AssigneeKey = "Janet Leverling", RankId = 4, Color = "#cc0000", ClassName = new List<string>() { "e-critical", "e-high", "e-janet" } },
                new KanbanDataModel { Id = "Task 12", Title = "Task  - 29017", Status = "Review", Summary = "Fix the issues reported in data binding", Type = "Story", Priority = "Normal", CardTags = new List<string>() { "Databinding" }, Estimate = 3.5, Assignee = "Janet Leverling", AssigneeKey = "Janet Leverling", RankId = 4, Color = "#8b447a", ClassName = new List<string>() { "e-story", "e-noraml", "e-janet" } },
                new KanbanDataModel { Id = "Task 13", Title = "Task  - 29018", Status = "Close", Summary = "Analyze SQL server 2008 connection", Type = "Story", Priority = "Release Breaker", CardTags = new List<string>() { "Grid", "Sql" }, Estimate = 2, Assignee = "Andrew Fuller", AssigneeKey = "Andrew Fuller", RankId = 4, Color = "#8b447a", ClassName = new List<string>() { "e-story", "e-release", "e-andrew" } },
                new KanbanDataModel { Id = "Task 14", Title = "Task  - 29019", Status = "Validate", Summary = "Validate databinding issues", Type = "Story", Priority = "Low", CardTags = new List<string>() { "Validation" }, Estimate = 1.5, Assignee = "Margaret Hamilt", AssigneeKey = "Margaret Hamilt", RankId = 1, Color = "#8b447a", ClassName = new List<string>() { "e-story", "e-low", "e-margaret" } },
                new KanbanDataModel { Id = "Task 15", Title = "Task  - 29020", Status = "Close", Summary = "Analyze grid control", Type = "Story", Priority = "High", CardTags = new List<string>() { "Analyze" }, Estimate = 2.5, Assignee = "Margaret Hamilt", AssigneeKey = "Margaret Hamilt", RankId = 5, Color = "#8b447a", ClassName = new List<string>() { "e-story", "e-high", "e-margaret" } },
                new KanbanDataModel { Id = "Task 16", Title = "Task  - 29021", Status = "Close", Summary = "Stored procedure for initial data binding of the grid", Type = "Others", Priority = "Release Breaker", CardTags = new List<string>() { "Databinding" }, Estimate = 1.5, Assignee = "Steven Walker", AssigneeKey = "Steven Walker", RankId = 6, Color = "#27AE60", ClassName = new List<string>() { "e-others", "e-release", "e-steven" } },
                new KanbanDataModel { Id = "Task 17", Title = "Task  - 29022", Status = "Close", Summary = "Analyze stored procedures", Type = "Story", Priority = "Release Breaker", CardTags = new List<string>() { "Procedures" }, Estimate = 5.5, Assignee = "Janet Leverling", AssigneeKey = "Janet Leverling", RankId = 7, Color = "#8b447a", ClassName = new List<string>() { "e-story", "e-release", "e-janet" } },
                new KanbanDataModel { Id = "Task 18", Title = "Task  - 29023", Status = "Validate", Summary = "Validate editing issues", Type = "Story", Priority = "Critical", CardTags = new List<string>() { "Editing" }, Estimate = 1, Assignee = "Nancy Davloio", AssigneeKey = "Nancy Davloio", RankId = 1, Color = "#8b447a", ClassName = new List<string>() { "e-story", "e-critical", "e-nancy" } },
                new KanbanDataModel { Id = "Task 19", Title = "Task  - 29024", Status = "Review", Summary = "Test editing functionality", Type = "Story", Priority = "Normal", CardTags = new List<string>() { "Editing", "Test" }, Estimate = 0.5, Assignee = "Nancy Davloio", AssigneeKey = "Nancy Davloio", RankId = 5, Color = "#8b447a", ClassName = new List<string>() { "e-story", "e-normal", "e-nancy" } },
                new KanbanDataModel { Id = "Task 20", Title = "Task  - 29025", Status = "Open", Summary = "Enhance editing functionality", Type = "Improvement", Priority = "Low", CardTags = new List<string>() { "Editing" }, Estimate = 3.5, Assignee = "Andrew Fuller", AssigneeKey = "Andrew Fuller", RankId = 5, Color = "#7d7297", ClassName = new List<string>() { "e-imrpovement", "e-low", "e-andrew" } },
                new KanbanDataModel { Id = "Task 21", Title = "Task  - 29026", Status = "In Progress", Summary = "Improve the performance of the editing functionality", Type = "Epic", Priority = "High", CardTags = new List<string>() { "Performance" }, Estimate = 6, Assignee = "Nancy Davloio", AssigneeKey = "Nancy Davloio", RankId = 5, Color = "#6d7492", ClassName = new List<string>() { "e-epic", "e-high", "e-nancy" } },
                new KanbanDataModel { Id = "Task 22", Title = "Task  - 29027", Status = "Open", Summary = "Arrange web meeting with the customer to show editing demo", Type = "Others", Priority = "High", CardTags = new List<string>() { "Meeting", "Editing" }, Estimate = 5.5, Assignee = "Steven Walker", AssigneeKey = "Steven Walker", RankId = 6, Color = "#27AE60", ClassName = new List<string>() { "e-others", "e-high", "e-steven" } },
                new KanbanDataModel { Id = "Task 23", Title = "Task  - 29029", Status = "Review", Summary = "Fix the editing issues reported by the customer", Type = "Bug", Priority = "Low", CardTags = new List<string>() { "Editing", "Fix" }, Estimate = 3.5, Assignee = "Janet Leverling", AssigneeKey = "Janet Leverling", RankId = 6, Color = "#cc0000", ClassName = new List<string>() { "e-story", "e-low", "e-nancy" } },
                new KanbanDataModel { Id = "Task 24", Title = "Task  - 29030", Status = "Testing", Summary = "Fix the issues reported by the customer", Type = "Bug", Priority = "Critical", CardTags = new List<string>() { "Customer" }, Estimate = 3.5, Assignee = "Steven Walker", AssigneeKey = "Steven Walker", RankId = 1, ClassName = new List<string>() { "e-bug", "e-low", "e-steven" } },
                new KanbanDataModel { Id = "Task 25", Title = "Task  - 29031", Status = "Testing", Summary = "Fix the issues reported in Safari browser", Type = "Bug", Priority = "Release Breaker", CardTags = new List<string>() { "Fix", "Safari" }, Estimate = 1.5, Assignee = "Nancy Davloio", AssigneeKey = "Nancy Davloio", RankId = 2, ClassName = new List<string>() { "e-bug", "e-release", "e-nancy" } },
                new KanbanDataModel { Id = "Task 26", Title = "Task  - 29032", Status = "Testing", Summary = "Check Login page validation", Type = "Story", Priority = "Release Breaker", CardTags = new List<string>() { "Testing" }, Estimate = 0.5, Assignee = "Michael Suyama", AssigneeKey = "Michael Suyama", RankId = 3, ClassName = new List<string>() { "e-story", "e-release", "e-nancy" } },
                new KanbanDataModel { Id = "Task 27", Title = "Task  - 29033", Status = "Testing", Summary = "Fix the issues reported in data binding", Type = "Story", Priority = "Normal", CardTags = new List<string>() { "Databinding" }, Estimate = 3.5, Assignee = "Janet Leverling", AssigneeKey = "Janet Leverling", RankId = 4, ClassName = new List<string>() { "e-story", "e-normal", "e-janet" } },
                new KanbanDataModel { Id = "Task 28", Title = "Task  - 29034", Status = "Testing", Summary = "Test editing functionality", Type = "Story", Priority = "Normal", CardTags = new List<string>() { "Editing", "Test" }, Estimate = 0.5, Assignee = "Nancy Davloio", AssigneeKey = "Nancy Davloio", RankId = 5, ClassName = new List<string>() { "e-story", "e-normal", "e-nancy" } },
                new KanbanDataModel { Id = "Task 29", Title = "Task  - 29035", Status = "Testing", Summary = "Fix editing issues reported in Firefox", Type = "Bug", Priority = "Critical", CardTags = new List<string>() { "Editing", "Fix" }, Estimate = 1.5, Assignee = "Robert King", AssigneeKey = "Robert King", RankId = 7, ClassName = new List<string>() { "e-bug", "e-critical", "e-robert" } },
                new KanbanDataModel { Id = "Task 30", Title = "Task  - 29036", Status = "Testing", Summary = "Test editing feature in the IE browser", Type = "Story", Priority = "Normal", CardTags = new List<string>() { "Testing" }, Estimate = 5.5, Assignee = "Janet Leverling", AssigneeKey = "Janet Leverling", RankId = 10, ClassName = new List<string>() { "e-story", "e-normal", "e-janet" } }
            };
            return taskDetails;
        }

        public List<KanbanDataModel> GetCardTasks()
        {
            var cardData = new List<KanbanDataModel>
            {
                new KanbanDataModel { Id = "Task 1", Title = "Task  - 29001", Status = "Open", Summary = "Analyze customer requirements", Priority = "High", CardTags = new List<string>() { "Bug", "Release Bug" }, RankId = 1, Assignee = "Nancy Davloio" },
                new KanbanDataModel { Id = "Task 2", Title = "Task  - 29002", Status = "In Progress", Summary = "Add responsive support to application", Priority = "Low", CardTags = new List<string>() { "Story", "Kanban" }, RankId = 1, Assignee = "Andrew Fuller" },
                new KanbanDataModel { Id = "Task 3", Title = "Task  - 29003", Status = "Open", Summary = "Show the retrieved data from the server in grid control", Priority = "High", CardTags = new List<string>() { "Bug", "Breaking Issue" }, RankId = 2, Assignee = "Janet Leverling" },
                new KanbanDataModel { Id = "Task 4", Title = "Task  - 29004", Status = "Open", Summary = "Fix the issues reported in the IE browser", Priority = "High", CardTags = new List<string>() { "Bug", "Customer" }, RankId = 3, Assignee = "Andrew Fuller" },
                new KanbanDataModel { Id = "Task 5", Title = "Task  - 29005", Status = "Review", Summary = "Improve application performance", Priority = "Normal", CardTags = new List<string>() { "Story", "Kanban" }, RankId = 1, Assignee = "Steven Walker" },
                new KanbanDataModel { Id = "Task 6", Title = "Task  - 29009", Status = "Review", Summary = "API Improvements", Priority = "Critical", CardTags = new List<string>() { "Bug", "Customer" }, RankId = 2, Assignee = "Nancy Davloio" },
                new KanbanDataModel { Id = "Task 7", Title = "Task  - 29010", Status = "Close", Summary = "Fix cannot open user's default database SQL error", Priority = "High", CardTags = new List<string>() { "Bug", "Internal" }, RankId = 8, Assignee = "Margaret Hamilt" },
                new KanbanDataModel { Id = "Task 8", Title = "Task  - 29015", Status = "Open", Summary = "Fix the filtering issues reported in safari", Priority = "Critical", CardTags = new List<string>() { "Bug", "Breaking Issue" }, RankId = 4, Assignee = "Margaret Hamilt" },
                new KanbanDataModel { Id = "Task 9", Title = "Task  - 29016", Status = "Review", Summary = "Fix the issues reported in IE browser", Priority = "High", CardTags = new List<string>() { "Bug", "Customer" }, RankId = 3, Assignee = "Andrew Fuller" },
                new KanbanDataModel { Id = "Task 10", Title = "Task  - 29017", Status = "Review", Summary = "Enhance editing functionality", Priority = "Normal", CardTags = new List<string>() { "Story", "Kanban" }, RankId = 4, Assignee = "Janet Leverling" },
                new KanbanDataModel { Id = "Task 11", Title = "Task  - 29018", Status = "Close", Summary = "Arrange web meeting with customer to get login page requirement", Priority = "High", CardTags = new List<string>() { "Feature" }, RankId = 1, Assignee = "Andrew Fuller" },
                new KanbanDataModel { Id = "Task 12", Title = "Task  - 29020", Status = "Close", Summary = "Login page validation", Priority = "Low", CardTags = new List<string>() { "Bug" }, RankId = 2, Assignee = "Margaret Hamilt" },
                new KanbanDataModel { Id = "Task 13", Title = "Task  - 29021", Status = "Close", Summary = "Test the application in IE browser", Priority = "Normal", CardTags = new List<string>() { "Bug" }, RankId = 3, Assignee = "Steven Walker" },
                new KanbanDataModel { Id = "Task 14", Title = "Task  - 29022", Status = "Close", Summary = "Analyze stored procedure", Priority = "Critical", CardTags = new List<string>() { "Custom sample", "Customer" }, RankId = 4, Assignee = "Janet Leverling" },
                new KanbanDataModel { Id = "Task 15", Title = "Task  - 29024", Status = "Review", Summary = "Check login page validation", Priority = "Low", CardTags = new List<string>() { "Story" }, RankId = 5, Assignee = "Nancy Davloio" },
                new KanbanDataModel { Id = "Task 16", Title = "Task  - 29025", Status = "Close", Summary = "Add input validation for editing", Priority = "Critical", CardTags = new List<string>() { "Bug", "Breaking Issue" }, RankId = 5, Assignee = "Andrew Fuller" },
                new KanbanDataModel { Id = "Task 17", Title = "Task  - 29026", Status = "In Progress", Summary = "Improve performance of editing functionality", Priority = "Critical", CardTags = new List<string>() { "Bug", "Customer" }, RankId = 2, Assignee = "Nancy Davloio" },
                new KanbanDataModel { Id = "Task 18", Title = "Task  - 29027", Status = "Open", Summary = "Arrange web meeting for customer requirement", Priority = "High", CardTags = new List<string>() { "Story" }, RankId = 5, Assignee = "Steven Walker" },
                new KanbanDataModel { Id = "Task 19", Title = "Task  - 29029", Status = "Review", Summary = "Fix the issues reported by the customer", Priority = "High", CardTags = new List<string>() { "Bug" }, RankId = 6, Assignee = "Janet Leverling" },
                new KanbanDataModel { Id = "Task 20", Title = "Task  - 29030", Status = "In Progress", Summary = "Test editing functionality", Priority = "Low", CardTags = new List<string>() { "Story" }, RankId = 3, Assignee = "Janet Leverling" },
                new KanbanDataModel { Id = "Task 21", Title = "Task  - 29031", Status = "In Progress", Summary = "Check filtering validation", Priority = "Normal", CardTags = new List<string>() { "Feature", "Release" }, RankId = 4, Assignee = "Janet Leverling" },
                new KanbanDataModel { Id = "Task 22", Title = "Task  - 29032", Status = "In Progress", Summary = "Arrange web meeting with customer to get login page requirement", Priority = "Critical", CardTags = new List<string>() { "Feature" }, RankId = 5, Assignee = "Margaret Hamilt" },
                new KanbanDataModel { Id = "Task 23", Title = "Task  - 29033", Status = "Open", Summary = "Arrange web meeting with customer to get editing requirements", Priority = "Critical", CardTags = new List<string>() { "Story", "Improvement" }, RankId = 6, Assignee = "Andrew Fuller" },
                new KanbanDataModel { Id = "Task 24", Title = "Task  - 29034", Status = "In Progress", Summary = "Fix the issues reported by the customer", Priority = "Critical", CardTags = new List<string>() { "Bug", "Customer" }, RankId = 6, Assignee = "Steven Walker" },
                new KanbanDataModel { Id = "Task 25", Title = "Task  - 29035", Status = "Close", Summary = "Fix the issues reported in Safari browser", Priority = "High", CardTags = new List<string>() { "Bug" }, RankId = 6, Assignee = "Nancy Davloio" },
                new KanbanDataModel { Id = "Task 26", Title = "Task  - 29036", Status = "Review", Summary = "Check Login page validation", Priority = "Critical", CardTags = new List<string>() { "Bug", "Customer" }, RankId = 7, Assignee = "Margaret Hamilt" },
                new KanbanDataModel { Id = "Task 27", Title = "Task  - 29037", Status = "Open", Summary = "Fix the issues reported in data binding", Priority = "Normal", CardTags = new List<string>() { "Bug" }, Estimate = 3.5, RankId = 7, Assignee = "Steven Walker" },
                new KanbanDataModel { Id = "Task 28", Title = "Task  - 29038", Status = "Close", Summary = "Test editing functionality", Priority = "Normal", CardTags = new List<string>() { "Story" }, Estimate = 0.5, RankId = 7, Assignee = "Steven Walker" }
            };
            return cardData;
        }

        public List<KanbanDataModel> GetPizzaData()
        {
            var pizzaData = new List<KanbanDataModel>
            {
                new KanbanDataModel { Id= "1", OrderID= "Order ID - #16365", Title= "Mexican Green Wave", Type= "Vegetarian", Size="Small", Category="Order", Description= "Stromboli sandwich with chili sauce", CardTags = new List<string>() { "Onions", "Pepper", "Cheese" }, ImageURL= "menu-01", Price= "$4.79",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "2", OrderID = "Order ID - #16366", Title = "Fresh Veggie", Type = "Vegetarian", Size = "Medium", Category = "Order", Description = "Veggie with Onions and Capsicum", CardTags = new List<string>() { "Onions", "Capsicum" }, ImageURL = "menu-01", Price = "$11.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "3", OrderID = "Order ID - #16367", Title = "Peppy Paneer", Type = "Vegetarian", Size = "Large", Category = "Ready to Serve", Description = "It's made using toppings of tomato, mozzarella cheese and fresh basil", CardTags = new List<string>() { "Onions", "Pepper", "Cheese" }, ImageURL = "menu-02", Price = "$14.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "4", OrderID = "Order ID - #16368", Title = "Margherita", Type = "Vegetarian", Size = "Small", Category = "Menu", Description = "Lebanese Pizza topped with tomato sauce", CardTags = new List<string>() { "Onions", "Pepper", "Cheese" }, ImageURL = "menu-03", Price = "$4.79",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "5", OrderID = "Order ID - #16369", Title = "Indian Tandoori Paneer", Type = "Vegetarian", Size = "Medium", Category = "Delivered", Description = "Tandoori Paneer with capsicum, red paprika and mint", CardTags = new List<string>() { "Paneer", "Capsicum" }, ImageURL = "menu-04", Price = "$11.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "6", OrderID = "Order ID - #16370", Title = "Pepper Barbecue Chicken", Type = "Non-Vegetarian", Size = "Medium", Category = "Ready to Serve", Description = "Pepper Barbecue Chicken with cheese", CardTags = new List<string>() { "Chicken", "Cheese" }, ImageURL = "menu-05", Price = "$11.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "7", OrderID = "Order ID - #16371", Title = "Chicken Sausage", Type = "Non-Vegetarian", Size = "Large", Category = "Ready to Serve", Description = "Chicken Sausage with cheese", CardTags = new List<string>() { "Cheese", "Chicken" }, ImageURL = "menu-06", Price = "$14.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "8", OrderID = "Order ID - #16372", Title = "Chicken Golden Delight", Type = "Non-Vegetarian", Size = "Large", Category = "Order", Description = "Barbeque chicken with a topping of golden corn loaded with extra cheese", CardTags = new List<string>() { "BBQ", "Prawn" }, ImageURL = "menu-07", Price = "$14.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "9", OrderID = "Order ID - #16373", Title = "Pepper Barbecue and Onion", Type = "Non-Vegetarian", Size = "Medium", Category = "Menu", Description = "Pepper Barbecue chicken with Onion", CardTags = new List<string>() { "Pepper", "Chicken" }, ImageURL = "menu-08", Price = "$11.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10)},
                new KanbanDataModel { Id = "10", OrderID = "Order ID - #16374", Title = "Chicken Fiesta", Type = "Non-Vegetarian", Size = "Small", Category = "Delivered", Description = "Grilled Chicken Rashers with Peri-Peri chicken, Onion and Capsicum", CardTags = new List<string>() { "Chicken", "Capsicum" }, ImageURL = "menu-13", Price = "$4.79",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "11", OrderID = "Order ID - #16375", Title = "Double Cheese Margherita", Type = "Vegetarian", Size = "Medium", Category = "Delivered", Description = "Margherita with chili sauce and double Cheese", CardTags = new List<string>() { "Onions", "Pepper" }, ImageURL = "menu-10", Price = "$11.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "12", OrderID = "Order ID - #16376", Title = "Veggie Paradise", Type = "Vegetarian", Size = "Large", Category = "Menu", Description = "Veggie Delight with Golden Corn, Black Olives, Capsicum and red Paprika", CardTags = new List<string>() { "Corn", "Capsicum" }, ImageURL = "menu-11", Price = "$14.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "13", OrderID = "Order ID - #16377", Title = "Cheese and Corn", Type = "Vegetarian", Size = "Large", Category = "Order", Description = "Cheese with golden corn", CardTags = new List<string>() {"Cheese", "Corn" }, ImageURL = "menu-12", Price = "$14.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "14", OrderID = "Order ID - #16378", Title = "Chicken Tikka", Type = "Non-Vegetarian", Size = "Medium", Category = "Ready to Serve", Description = "Tandoori masala with Chicken Tikka, Onion, red paprika and mint", CardTags = new List<string>() { "Chicken", "Tikka" }, ImageURL = "menu-14", Price = "$11.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "15", OrderID = "Order ID - #16379", Title = "Chicken Dominator", Type = "Non-Vegetarian", Size = "Small", Category = "Menu", Description = "Double Pepper Barbecue Chicken with Peri-Peri Chicken, Chicken Tikka, Grilled and Rashers", CardTags = new List<string>() { "Pepper", "Chicken" }, ImageURL = "menu-15", Price = "$4.79",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "16", OrderID = "Order ID - #16380", Title = "Deluxe Veggie", Type = "Vegetarian", Size = "Medium", Category = "Delivered", Description = "Onions and Capsicum those delectable mushrooms with paneer and golden corn to top it all", CardTags = new List<string>() {"Mushrooms", "Corn" }, ImageURL = "menu-16", Price = "$11.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "17", OrderID = "Order ID - #16381", Title = "Farm House", Type = "Vegetarian", Size = "Large", Category = "Menu", Description = "Crunchy, crisp capsicum, succulent mushrooms and fresh tomatoes", CardTags = new List<string>() { "Capsicum", "Mushrooms" }, ImageURL = "menu-17", Price = "$14.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "18", OrderID = "Order ID - #16382", Title = "Veg Extravaganza", Type = "Vegetarian", Size = "Large", Category = "Served", Description = "Pizza with corn, olives, onions, capsicum, tomatoes and jalapeno with cheese to go all around", CardTags = new List<string>() { "Corn", "Mushrooms" }, ImageURL = "menu-18", Price = "$14.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "19", OrderID = "Order ID - #16383", Title = "Margherita", Type = "Vegetarian", Size = "Large", Category = "Ready to Deliver", Description = "Lebanese Pizza topped with tomato sauce", CardTags = new List<string>() { "Pepper", "Cheese" }, ImageURL = "menu-19", Price = "$4.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "20", OrderID = "Order ID - #16384", Title = "Pepper Barbecue and Onion", Type = "Non-Vegetarian", Size = "Medium", Category = "Ready to Deliver", Description = "Pepper Barbecue chicken with Onion", CardTags = new List<string>() { "Onions", "Chicken" }, ImageURL = "menu-20", Price = "$11.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "21", OrderID = "Order ID - #16385", Title = "Veggie Paradise", Type = "Vegetarian", Size = "Large", Category = "Ready to Deliver", Description = "Veggie Delight with Golden Corn, Black Olives, Capsicum and red Paprika", CardTags = new List<string>() { "Corn", "Pepper" }, ImageURL = "menu-21", Price = "$14.99",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) },
                new KanbanDataModel { Id = "22", OrderID = "Order ID - #16386", Title = "Chicken Dominator", Type = "Non-Vegetarian", Size = "Small", Category = "Ready to Deliver", Description = "Double Pepper Barbecue Chicken with Peri-Peri Chicken, Chicken Tikka, Grilled and Rashers", CardTags = new List<string>() { "Pepper", "Chicken" }, ImageURL = "menu-22", Price = "$4.79",Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month,10) }
            };
            return pizzaData;
        }

        public List<KanbanDataModel> SortDropDowns()
        {
            var sortDropDown = new List<KanbanDataModel>
            {
                new KanbanDataModel { Value = "Ascending" },
                new KanbanDataModel { Value = "Descending" }
            };
            return sortDropDown;
        }

        public List<KanbanDataModel> ColumnDropDowns()
        {
            var columnDropDown = new List<KanbanDataModel>
            {
                new KanbanDataModel { Value = "Column" },
                new KanbanDataModel { Value = "Swimlane" }
            };
            return columnDropDown;
        }

        public List<KanbanDataModel> StatusData()
        {
            var statusDropDown = new List<KanbanDataModel>
            {
                new KanbanDataModel { ListId = 0, Value = "To Do" },
                new KanbanDataModel { ListId = 1, Value = "In Progress" },
                new KanbanDataModel { ListId = 2, Value = "Testing" }
            };
            return statusDropDown;
        }

        public List<KanbanDataModel> ApiData()
        {
            var apiDropdown = new List<KanbanDataModel>
            {
                new KanbanDataModel { Value = "Testing" },
                new KanbanDataModel { Value = "Review" },
                new KanbanDataModel { Value = "Validate" }
            };
            return apiDropdown;
        }

        public List<KanbanDataModel> DialogStatus()
        {
            var dialogdropDownStatus = new List<KanbanDataModel>
            {
                new KanbanDataModel { Value = "Open" },
                new KanbanDataModel { Value = "In Progress" },
                new KanbanDataModel { Value = "Testing" },
                new KanbanDataModel { Value = "Close" }
            };
            return dialogdropDownStatus;
        }

        public List<KanbanDataModel> AssigneeData()
        {
            var assigneeData = new List<KanbanDataModel>
            {
                new KanbanDataModel { Value = "Nancy Davloio" },
                new KanbanDataModel { Value = "Andrew Fuller" },
                new KanbanDataModel { Value = "Janet Leverling" },
                new KanbanDataModel { Value = "Steven Walker" },
                new KanbanDataModel { Value = "Robert King" },
                new KanbanDataModel { Value = "Margaret Hamilt" },
                new KanbanDataModel { Value = "Michael Suyama" }
            };
            return assigneeData;
        }

        public List<KanbanDataModel> PriorityData()
        {
            var priorityData = new List<KanbanDataModel>
            {
                new KanbanDataModel { Value = "Low" },
                new KanbanDataModel { Value = "Normal" },
                new KanbanDataModel { Value = "Critical" },
                new KanbanDataModel { Value = "High" },
                new KanbanDataModel { Value = "Release Breaker" }
            };
            return priorityData;
        }
    }
}
