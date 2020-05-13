using System.Collections.Generic;

namespace ej2_blazor_kanban_data_models
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

        public List<KanbanDataModel> GetTasks()
        {
            List<KanbanDataModel> TaskDetails = new List<KanbanDataModel>();
            TaskDetails.Add(new KanbanDataModel { Id = "Task 1", Title = "Task  - 29001", Status = "Open", Summary = "Analyze the new requirements gathered from the customer.", Type = "Story", Priority = "Low", Tags = "Analyze,Customer", Estimate = 3.5, Assignee = "Nancy Davloio", RankId = 1, Color = "#8b447a" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 2", Title = "Task  - 29002", Status = "InProgress", Summary = "Improve application performance", Type = "Improvement", Priority = "Normal", Tags = "Improvement", Estimate = 6, Assignee = "Andrew Fuller", RankId = 1, Color = "#7d7297" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 3", Title = "Task  - 29003", Status = "Open", Summary = "Arrange a web meeting with the customer to get new requirements.", Type = "Others", Priority = "Critical", Tags = "Meeting", Estimate = 5.5, Assignee = "Janet Leverling", RankId = 2, Color = "#27AE60" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 4", Title = "Task  - 29004", Status = "InProgress", Summary = "Fix the issues reported in the IE browser.", Type = "Bug", Priority = "Release Breaker", Tags = "IE", Estimate = 2.5, Assignee = "Janet Leverling", RankId = 2, Color = "#cc0000" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 5", Title = "Task  - 29005", Status = "Review", Summary = "Fix the issues reported by the customer.", Type = "Bug", Priority = "Low", Tags = "Customer", Estimate = 3.5, Assignee = "Steven walker", RankId = 1, Color = "#cc0000" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 6", Title = "Task  - 29007", Status = "Validate", Summary = "Validate new requirements", Type = "Improvement", Priority = "Low", Tags = "Validation", Estimate = 1.5, Assignee = "Robert King", RankId = 1, Color = "#7d7297" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 7", Title = "Task  - 29009", Status = "Review", Summary = "Fix the issues reported in Safari browser.", Type = "Bug", Priority = "Release Breaker", Tags = "Fix,Safari", Estimate = 1.5, Assignee = "Nancy Davloio", RankId = 2, Color = "#cc0000" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 8", Title = "Task  - 29010", Status = "Close", Summary = "Test the application in the IE browser.", Type = "Story", Priority = "Low", Tags = "Review,IE", Estimate = 5.5, Assignee = "Margaret hamilt", RankId = 3, Color = "#8b447a" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 9", Title = "Task  - 29011", Status = "Validate", Summary = "Validate the issues reported by the customer.", Type = "Story", Priority = "High", Tags = "Validation,Fix", Estimate = 1, Assignee = "Steven walker", RankId = 1, Color = "#8b447a" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 10", Title = "Task  - 29015", Status = "Open", Summary = "Show the retrieved data from the server in grid control.", Type = "Story", Priority = "High", Tags = "Database,SQL", Estimate = 5.5, Assignee = "Margaret hamilt", RankId = 4, Color = "#8b447a" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 11", Title = "Task  - 29016", Status = "InProgress", Summary = "Fix cannot open user’s default database SQL error.", Priority = "Critical", Type = "Bug", Tags = "Database,Sql2008", Estimate = 2.5, Assignee = "Janet Leverling", RankId = 4, Color = "#cc0000" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 12", Title = "Task  - 29017", Status = "Review", Summary = "Fix the issues reported in data binding.", Type = "Story", Priority = "Normal", Tags = "Databinding", Estimate = 3.5, Assignee = "Janet Leverling", RankId = 4, Color = "#8b447a" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 13", Title = "Task  - 29018", Status = "Close", Summary = "Analyze SQL server 2008 connection.", Type = "Story", Priority = "Release Breaker", Tags = "Grid,Sql", Estimate = 2, Assignee = "Andrew Fuller", RankId = 4, Color = "#8b447a" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 14", Title = "Task  - 29019", Status = "Validate", Summary = "Validate databinding issues.", Type = "Story", Priority = "Low", Tags = "Validation", Estimate = 1.5, Assignee = "Margaret hamilt", RankId = 1, Color = "#8b447a" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 15", Title = "Task  - 29020", Status = "Close", Summary = "Analyze grid control.", Type = "Story", Priority = "High", Tags = "Analyze", Estimate = 2.5, Assignee = "Margaret hamilt", RankId = 5, Color = "#8b447a" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 16", Title = "Task  - 29021", Status = "Close", Summary = "Stored procedure for initial data binding of the grid.", Type = "Others", Priority = "Release Breaker", Tags = "Databinding", Estimate = 1.5, Assignee = "Steven walker", RankId = 6, Color = "#27AE60" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 17", Title = "Task  - 29022", Status = "Close", Summary = "Analyze stored procedures.", Type = "Story", Priority = "Release Breaker", Tags = "Procedures", Estimate = 5.5, Assignee = "Janet Leverling", RankId = 7, Color = "#8b447a" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 18", Title = "Task  - 29023", Status = "Validate", Summary = "Validate editing issues.", Type = "Story", Priority = "Critical", Tags = "Editing", Estimate = 1, Assignee = "Nancy Davloio", RankId = 1, Color = "#8b447a" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 19", Title = "Task  - 29024", Status = "Review", Summary = "Test editing functionality.", Type = "Story", Priority = "Normal", Tags = "Editing,Test", Estimate = 0.5, Assignee = "Nancy Davloio", RankId = 5, Color = "#8b447a" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 20", Title = "Task  - 29025", Status = "Open", Summary = "Enhance editing functionality.", Type = "Improvement", Priority = "Low", Tags = "Editing", Estimate = 3.5, Assignee = "Andrew Fuller", RankId = 5, Color = "#7d7297" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 21", Title = "Task  - 29026", Status = "InProgress", Summary = "Improve the performance of the editing functionality.", Type = "Epic", Priority = "High", Tags = "Performance", Estimate = 6, Assignee = "Nancy Davloio", RankId = 5, Color = "#6d7492" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 22", Title = "Task  - 29027", Status = "Open", Summary = "Arrange web meeting with the customer to show editing demo.", Type = "Others", Priority = "High", Tags = "Meeting,Editing", Estimate = 5.5, Assignee = "Steven walker", RankId = 6, Color = "#27AE60" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 23", Title = "Task  - 29029", Status = "Review", Summary = "Fix the editing issues reported by the customer.", Type = "Bug", Priority = "Low", Tags = "Editing,Fix", Estimate = 3.5, Assignee = "Janet Leverling", RankId = 6, Color = "#cc0000" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 24", Title = "Task  - 29030", Status = "Testing", Summary = "Fix the issues reported by the customer.", Type = "Bug", Priority = "Critical", Tags = "Customer", Estimate = 3.5, Assignee = "Steven walker", RankId = 1 });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 25", Title = "Task  - 29031", Status = "Testing", Summary = "Fix the issues reported in Safari browser.", Type = "Bug", Priority = "Release Breaker", Tags = "Fix,Safari", Estimate = 1.5, Assignee = "Nancy Davloio", RankId = 2 });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 26", Title = "Task  - 29032", Status = "Testing", Summary = "Check Login page validation.", Type = "Story", Priority = "Release Breaker", Tags = "Testing", Estimate = 0.5, Assignee = "Michael Suyama", RankId = 3 });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 27", Title = "Task  - 29033", Status = "Testing", Summary = "Fix the issues reported in data binding.", Type = "Story", Priority = "Normal", Tags = "Databinding", Estimate = 3.5, Assignee = "Janet Leverling", RankId = 4 });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 28", Title = "Task  - 29034", Status = "Testing", Summary = "Test editing functionality.", Type = "Story", Priority = "Normal", Tags = "Editing,Test", Estimate = 0.5, Assignee = "Nancy Davloio", RankId = 5 });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 29", Title = "Task  - 29035", Status = "Testing", Summary = "Fix editing issues reported in Firefox.", Type = "Bug", Priority = "Critical", Tags = "Editing,Fix", Estimate = 1.5, Assignee = "Robert King", RankId = 7 });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 30", Title = "Task  - 29036", Status = "Testing", Summary = "Test editing feature in the IE browser.", Type = "Story", Priority = "Normal", Tags = "Testing", Estimate = 5.5, Assignee = "Janet Leverling", RankId = 10 });
            return TaskDetails;
        }

        public List<KanbanDataModel> GetCardTasks()
        {
            List<KanbanDataModel> CardData = new List<KanbanDataModel>();
            CardData.Add(new KanbanDataModel { Id = "Task 1", Title = "Task  - 29001", Status = "Open", Summary = "Analyze customer requirements.", Priority = "High", Tags = "Bug, Release Bug", RankId = 1, Assignee = "Nancy Davloio" });
            CardData.Add(new KanbanDataModel { Id = "Task 2", Title = "Task  - 29002", Status = "InProgress", Summary = "Add responsive support to applicaton", Priority = "Low", Tags = "Story, Kanban", RankId = 1, Assignee = "Andrew Fuller" });
            CardData.Add(new KanbanDataModel { Id = "Task 3", Title = "Task  - 29003", Status = "Open", Summary = "Show the retrived data from the server in grid control.", Priority = "High", Tags = "Bug, Breaking Issue", RankId = 2, Assignee = "Janet Leverling" });
            CardData.Add(new KanbanDataModel { Id = "Task 4", Title = "Task  - 29004", Status = "Open", Summary = "Fix the issues reported in the IE browser.", Priority = "High", Tags = "Bug, Customer", RankId = 3, Assignee = "Andrew Fuller" });
            CardData.Add(new KanbanDataModel { Id = "Task 5", Title = "Task  - 29005", Status = "Review", Summary = "Improve application performance.", Priority = "Normal", Tags = "Story, Kanban", RankId = 1, Assignee = "Steven walker" });
            CardData.Add(new KanbanDataModel { Id = "Task 6", Title = "Task  - 29009", Status = "Review", Summary = "API Improvements.", Priority = "Critical", Tags = "Bug, Customer", RankId = 2, Assignee = "Nancy Davloio" });
            CardData.Add(new KanbanDataModel { Id = "Task 7", Title = "Task  - 29010", Status = "Close", Summary = "Fix cannot open user's default database sql error.", Priority = "High", Tags = "Bug, Internal", RankId = 8, Assignee = "Margaret hamilt" });
            CardData.Add(new KanbanDataModel { Id = "Task 8", Title = "Task  - 29015", Status = "Open", Summary = "Fix the filtering issues reported in safari.", Priority = "Critical", Tags = "Bug, Breaking Issue", RankId = 4, Assignee = "Margaret hamilt" });
            CardData.Add(new KanbanDataModel { Id = "Task 9", Title = "Task  - 29016", Status = "Review", Summary = "Fix the issues reported in IE browser.", Priority = "High", Tags = "Bug, Customer", RankId = 3, Assignee = "Andrew Fuller" });
            CardData.Add(new KanbanDataModel { Id = "Task 10", Title = "Task  - 29017", Status = "Review", Summary = "Enhance editing functionality.", Priority = "Normal", Tags = "Story, Kanban", RankId = 4, Assignee = "Janet Leverling" });
            CardData.Add(new KanbanDataModel { Id = "Task 11", Title = "Task  - 29018", Status = "Close", Summary = "Arrange web meeting with customer to get login page requirement.", Priority = "High", Tags = "Feature", RankId = 1, Assignee = "Andrew Fuller" });
            CardData.Add(new KanbanDataModel { Id = "Task 12", Title = "Task  - 29020", Status = "Close", Summary = "Login page validation.", Priority = "Low", Tags = "Bug", RankId = 2, Assignee = "Margaret hamilt" });
            CardData.Add(new KanbanDataModel { Id = "Task 13", Title = "Task  - 29021", Status = "Close", Summary = "Test the application in IE browser.", Priority = "Normal", Tags = "Bug", RankId = 3, Assignee = "Steven walker" });
            CardData.Add(new KanbanDataModel { Id = "Task 14", Title = "Task  - 29022", Status = "Close", Summary = "Analyze stored procedure.", Priority = "Critical", Tags = "CustomSample, Customer", RankId = 4, Assignee = "Janet Leverling" });
            CardData.Add(new KanbanDataModel { Id = "Task 15", Title = "Task  - 29024", Status = "Review", Summary = "Check login page validation.", Priority = "Low", Tags = "Story", RankId = 5, Assignee = "Nancy Davloio" });
            CardData.Add(new KanbanDataModel { Id = "Task 16", Title = "Task  - 29025", Status = "Close", Summary = "Add input validation for editing.", Priority = "Critical", Tags = "Bug, Breaking Issue", RankId = 5, Assignee = "Andrew Fuller" });
            CardData.Add(new KanbanDataModel { Id = "Task 17", Title = "Task  - 29026", Status = "InProgress", Summary = "Improve performance of editing functionality.", Priority = "Critical", Tags = "Bug, Customer", RankId = 2, Assignee = "Nancy Davloio" });
            CardData.Add(new KanbanDataModel { Id = "Task 18", Title = "Task  - 29027", Status = "Open", Summary = "Arrange web meeting for cutomer requirement.", Priority = "High", Tags = "Story", RankId = 5, Assignee = "Steven walker" });
            CardData.Add(new KanbanDataModel { Id = "Task 19", Title = "Task  - 29029", Status = "Review", Summary = "Fix the issues reported by the customer.", Priority = "High", Tags = "Bug", RankId = 6, Assignee = "Janet Leverling" });
            CardData.Add(new KanbanDataModel { Id = "Task 20", Title = "Task  - 29030", Status = "InProgress", Summary = "Test editing functionality", Priority = "Low", Tags = "Story", RankId = 3, Assignee = "Janet Leverling" });
            CardData.Add(new KanbanDataModel { Id = "Task 21", Title = "Task  - 29031", Status = "InProgress", Summary = "Check filtering validation", Priority = "Normal", Tags = "Feature, Release", RankId = 4, Assignee = "Janet Leverling" });
            CardData.Add(new KanbanDataModel { Id = "Task 22", Title = "Task  - 29032", Status = "InProgress", Summary = "Arrange web meeting with customer to get login page requirement", Priority = "Critical", Tags = "Feature", RankId = 5, Assignee = "Margaret hamilt" });
            CardData.Add(new KanbanDataModel { Id = "Task 23", Title = "Task  - 29033", Status = "Open", Summary = "Arrange web meeting with customer to get editing requirements", Priority = "Critical", Tags = "Story, Improvement", RankId = 6, Assignee = "Andrew Fuller" });
            CardData.Add(new KanbanDataModel { Id = "Task 24", Title = "Task  - 29034", Status = "InProgress", Summary = "Fix the issues reported by the customer.", Priority = "Critical", Tags = "Bug, Customer", RankId = 6, Assignee = "Steven walker" });
            CardData.Add(new KanbanDataModel { Id = "Task 25", Title = "Task  - 29035", Status = "Close", Summary = "Fix the issues reported in Safari browser.", Priority = "High", Tags = "Bug", RankId = 6, Assignee = "Nancy Davloio" });
            CardData.Add(new KanbanDataModel { Id = "Task 26", Title = "Task  - 29036", Status = "Review", Summary = "Check Login page validation.", Priority = "Critical", Tags = "Bug, Customer", RankId = 7, Assignee = "Margaret hamilt" });
            CardData.Add(new KanbanDataModel { Id = "Task 27", Title = "Task  - 29037", Status = "Open", Summary = "Fix the issues reported in data binding.", Priority = "Normal", Tags = "Bug", Estimate = 3.5, RankId = 7, Assignee = "Steven walker" });
            CardData.Add(new KanbanDataModel { Id = "Task 28", Title = "Task  - 29038", Status = "Close", Summary = "Test editing functionality.", Priority = "Normal", Tags = "Story", Estimate = 0.5, RankId = 7, Assignee = "Steven walker" });
            return CardData;
        }

        public List<KanbanDataModel> GetPizzaData()
        {
            List<KanbanDataModel> PizzaData = new List<KanbanDataModel>();
            PizzaData.Add(new KanbanDataModel { Id = "1", OrderID = "Order ID - #16365", Title = "Mexican Green Wave", Type = "Vegetarian", Size = "Small", Category = "Order", Description = "Stromboli sandwich with chili sauce.", Tags = "Onions Pepper Cheese", ImageURL = "menu_01" });
            PizzaData.Add(new KanbanDataModel { Id = "2", OrderID = "Order ID - #16366", Title = "Milan Veg Fantasy", Type = "Vegetarian", Size = "Medium", Category = "Order", Description = "Zucchini wrapped in spicy grilled seasoning along with tomato and jalapeno.", Tags = "Onions Pepper Tomato Zucchini", ImageURL = "menu_01" });
            PizzaData.Add(new KanbanDataModel { Id = "3", OrderID = "Order ID - #16367", Title = "Peppy Paneer", Type = "Vegetarian", Size = "Large", Category = "Ready to Serve", Description = "It's made using toppings of tomato mozzarella cheese and fresh basil which represent the red white and green of the Italian flag.", Tags = "Onions Pepper Cheese", ImageURL = "menu_02" });
            PizzaData.Add(new KanbanDataModel { Id = "4", OrderID = "Order ID - #16368", Title = "Margherita", Type = "Vegetarian", Size = "Small", Category = "Menu", Description = "Lebanese Pizza topped with tomato sauce.", Tags = "Onions Pepper Cheese", ImageURL = "menu_03", Price = "$4.79" });
            PizzaData.Add(new KanbanDataModel { Id = "5", OrderID = "Order ID - #16369", Title = "Farm House", Type = "Vegetarian", Size = "Small", Category = "Delivered", Description = "Stromboli sandwich with chili sauce.", Tags = "Onions Pepper Cheese", ImageURL = "menu_04" });
            PizzaData.Add(new KanbanDataModel { Id = "6", OrderID = "Order ID - #16370", Title = "BBQ Chicken", Type = "Non-Vegetarian", Size = "Medium", Category = "Ready to Serve", Description = "BBQ Chicken with chili sauce.", Tags = "Onions Pepper Chicken BBQ", ImageURL = "menu_05", Price = "$4.79" });
            PizzaData.Add(new KanbanDataModel { Id = "7", OrderID = "Order ID - #16371", Title = "Tandoori Chicken", Type = "Non-Vegetarian", Size = "Large", Category = "Ready to Serve", Description = "Tandoori Chicken with chili sauce.", Tags = "Onions Tandoori Pepper Chicken", ImageURL = "menu_06" });
            PizzaData.Add(new KanbanDataModel { Id = "8", OrderID = "Order ID - #16372", Title = "BBQ Prawn", Type = "Non-Vegetarian", Size = "Large", Category = "Order", Description = "BBQ Prawn with chili sauce.", Tags = "Onions BBQ Pepper Prawn", ImageURL = "menu_07" });
            PizzaData.Add(new KanbanDataModel { Id = "9", OrderID = "Order ID - #16373", Title = "Italian Chicken", Type = "Non-Vegetarian", Size = "Medium", Category = "Menu", Description = "Italian Chicken with White sauce.", Tags = "Onions Pepper Italian Chicken", ImageURL = "menu_08", Price = "$11.99" });
            PizzaData.Add(new KanbanDataModel { Id = "10", OrderID = "Order ID - #16374", Title = "Garlic Prawn", Type = "Non-Vegetarian", Size = "Small", Category = "Delivered", Description = "Prawn with chili sauce.", Tags = "Onions Garlic Pepper Prawn", ImageURL = "menu_13" });
            PizzaData.Add(new KanbanDataModel { Id = "11", OrderID = "Order ID - #16375", Title = "Double Cheese Margherita", Type = "Vegetarian", Size = "Medium", Category = "Delivered", Description = "Margherita with chili sauce and double Cheese.", Tags = "Onions, Pepper, Cheese", ImageURL = "menu_10", Price = "$11.99" });
            PizzaData.Add(new KanbanDataModel { Id = "12", OrderID = "Order ID - #16376", Title = "Veggie Delight", Type = "Vegetarian", Size = "Large", Category = "Menu", Description = "Veggie Delight with chili sauce and extra toppings.", Tags = "Onions, Capsicum, Pepper, Cheese", ImageURL = "menu_11", Price = "$14.99" });
            PizzaData.Add(new KanbanDataModel { Id = "13", OrderID = "Order ID - #16377", Title = "Paneer Tikka", Type = "Vegetarian", Size = "Large", Category = "Order", Description = "Paneer Tikka with chili sauce.", Tags = "Onions, Paneer, Pepper, Tikka", ImageURL = "menu_12", Price = "$14.99" });
            PizzaData.Add(new KanbanDataModel { Id = "14", OrderID = "Order ID - #16378", Title = "Chicken Tikka", Type = "Non-Vegetarian", Size = "Medium", Category = "Ready to Serve", Description = "Chicken Tikka with White sauce.", Tags = "Onions, Pepper, Chicken, Tikka, Boneless", ImageURL = "menu_14", Price = "$11.99" });
            PizzaData.Add(new KanbanDataModel { Id = "15", OrderID = "Order ID - #16379", Title = "Kadai Chicken", Type = "Non-Vegetarian", Size = "Small", Category = "Menu", Description = "Kadai Chicken with chili sauce.", Tags = "Onions, Pepper, Chicken", ImageURL = "menu_15", Price = "$4.79" });
            PizzaData.Add(new KanbanDataModel { Id = "16", OrderID = "Order ID - #16380", Title = "Hot Vege", Type = "Vegetarian", Size = "Medium", Category = "Delivered", Description = "Capsicum with chili sauce and Double Cheese with extra toppings.", Tags = "Onions, Pepper, Capsicum, Cheese", ImageURL = "menu_16", Price = "$11.99" });
            PizzaData.Add(new KanbanDataModel { Id = "17", OrderID = "Order ID - #16381", Title = "Kadai Paneer", Type = "Vegetarian", Size = "Large", Category = "Menu", Description = "Kadai Paneer with chili sauce and extra toppings.", Tags = "Onions, Capsicum, Pepper, Paneer", ImageURL = "menu_17", Price = "$14.99" });
            PizzaData.Add(new KanbanDataModel { Id = "18", OrderID = "Order ID - #16382", Title = "Tomato Pizza", Type = "Vegetarian", Size = "Large", Category = "Served", Description = "Tomato Pizza with chili sauce and extra toppings.", Tags = "Onions, Tomato, Pepper, Capsicum", ImageURL = "menu_18", Price = "$14.99" });
            return PizzaData;
        }

        public List<KanbanDataModel> SortDropDowns()
        {
            List<KanbanDataModel> SortDropDown = new List<KanbanDataModel>();
            SortDropDown.Add(new KanbanDataModel { Value = "Ascending" });
            SortDropDown.Add(new KanbanDataModel { Value = "Descending" });
            return SortDropDown;
        }

        public List<KanbanDataModel> ColumnDropDowns()
        {
            List<KanbanDataModel> ColumnDropDown = new List<KanbanDataModel>();
            ColumnDropDown.Add(new KanbanDataModel { Value = "Column" });
            ColumnDropDown.Add(new KanbanDataModel { Value = "Swimlane" });
            return ColumnDropDown;
        }

        public List<KanbanDataModel> StatusData()
        {
            List<KanbanDataModel> StatusDropDown = new List<KanbanDataModel>();
            StatusDropDown.Add(new KanbanDataModel { ListId = 0, Value = "To Do" });
            StatusDropDown.Add(new KanbanDataModel { ListId = 1, Value = "In Progress" });
            StatusDropDown.Add(new KanbanDataModel { ListId = 2, Value = "Testing" });
            return StatusDropDown;
        }
        public List<KanbanDataModel> ApiData()
        {
            List<KanbanDataModel> ApiDropdown = new List<KanbanDataModel>();
            ApiDropdown.Add(new KanbanDataModel { Value = "Testing" });
            ApiDropdown.Add(new KanbanDataModel { Value = "Review" });
            ApiDropdown.Add(new KanbanDataModel { Value = "Validate" });
            return ApiDropdown;
        }

        public List<KanbanDataModel> DialogStatus()
        {
            List<KanbanDataModel> DialogdropDownStatus = new List<KanbanDataModel>();
            DialogdropDownStatus.Add(new KanbanDataModel { Value = "Open" });
            DialogdropDownStatus.Add(new KanbanDataModel { Value = "InProgress" });
            DialogdropDownStatus.Add(new KanbanDataModel { Value = "Testing" });
            DialogdropDownStatus.Add(new KanbanDataModel { Value = "Close" });
            return DialogdropDownStatus;
        }

        public List<KanbanDataModel> AssigneeData()
        {
            List<KanbanDataModel> assigneeData = new List<KanbanDataModel>();
            assigneeData.Add(new KanbanDataModel { Value = "Nancy Davloio" });
            assigneeData.Add(new KanbanDataModel { Value = "Andrew Fuller" });
            assigneeData.Add(new KanbanDataModel { Value = "Janet Leverling" });
            assigneeData.Add(new KanbanDataModel { Value = "Steven walker" });
            assigneeData.Add(new KanbanDataModel { Value = "Robert King" });
            assigneeData.Add(new KanbanDataModel { Value = "Margaret hamilt" });
            assigneeData.Add(new KanbanDataModel { Value = "Michael Suyama" });
            return assigneeData;
        }

        public List<KanbanDataModel> PriorityData()
        {
            List<KanbanDataModel> priorityData = new List<KanbanDataModel>();
            priorityData.Add(new KanbanDataModel { Value = "Low" });
            priorityData.Add(new KanbanDataModel { Value = "Normal" });
            priorityData.Add(new KanbanDataModel { Value = "Critical" });
            priorityData.Add(new KanbanDataModel { Value = "High" });
            priorityData.Add(new KanbanDataModel { Value = "Release Breaker" });
            return priorityData;
        }
    }
}