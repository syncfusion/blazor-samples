#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Globalization;

namespace blazor_employeedetails
{
    public class EmployeeDetails
    {
        public EmployeeDetails()
        {
        }
        public EmployeeDetails(int employeeid, string employeename, string time_9_00, string time_9_30, string time_10_00, string time_10_30, string time_11_00, string time_11_30,
            string time_12_00, string time_12_30, string time_1_00, string time_1_30, string time_2_00, string time_2_30, string time_3_00, string time_3_30, string time_4_00, string time_4_30,
            string time_5_00)
        { 
            this.EmployeeID = employeeid;
            this.EmployeeName = employeename;
            this.Time_9_00 = time_9_00;
            this.Time_9_00 = time_9_30;
            this.Time_10_00 = time_10_00;
            this.Time_10_30 = time_10_30;
            this.Time_11_00 = time_11_00;
            this.Time_11_30 = time_11_30;
            this.Time_12_00 = time_12_00;
            this.Time_12_30 = time_12_30;
            this.Time_1_00 = time_1_00;
            this.Time_1_30 = time_1_30;
            this.Time_2_00 = time_2_00;
            this.Time_2_30 = time_2_30;
            this.Time_3_00 = time_3_00;
            this.Time_3_30 = time_3_30;
            this.Time_4_00 = time_4_00;
            this.Time_4_30 = time_4_30;
            this.Time_5_00 = time_5_00;
        }
       
            public int EmployeeID { get; set; }
            public string? EmployeeName { get; set; }
            public string? Time_9_00 { get; set; }
            public string? Time_9_30 { get; set; }
            public string? Time_10_00 { get; set; }
            public string? Time_10_30 { get; set; }
            public string? Time_11_00 { get; set; }
            public string? Time_11_30 { get; set; }
            public string? Time_12_00 { get; set; }
            public string? Time_12_30 { get; set; }
            public string? Time_1_00 { get; set; }
            public string? Time_1_30 { get; set; }
            public string? Time_2_00 { get; set; }
            public string? Time_2_30 { get; set; }
            public string? Time_3_00 { get; set; }
            public string? Time_3_30 { get; set; }
            public string? Time_4_00 { get; set; }
            public string? Time_4_30 { get; set; }
            public string? Time_5_00 { get; set; }

        public static List<EmployeeDetails> GetAllRecords()
        {
            List<EmployeeDetails> data = new List<EmployeeDetails>();

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10001,
                EmployeeName = "Nancy Davolio",
                Time_9_00 = "Analysis Tasks",
                Time_9_30 = "Analysis Tasks",
                Time_10_00 = "Team Meeting",
                Time_10_30 = "Testing",
                Time_11_00 = "Development",
                Time_11_30 = "Code Review",
                Time_12_00 = "Development",
                Time_12_30 = "Support",
                Time_1_00 = "Lunch Break",
                Time_1_30 = "Lunch Break",
                Time_2_00 = "Lunch Break",
                Time_2_30 = "Testing",
                Time_3_00 = "Testing",
                Time_3_30 = "Development",
                Time_4_00 = "Conference",
                Time_4_30 = "Team Meeting",
                Time_5_00 = "Team Meeting"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10002,
                EmployeeName = "Steven Buchanan",
                Time_9_00 = "Analysis Tasks",
                Time_9_30 = "Support",
                Time_10_00 = "Support",
                Time_10_30 = "Support",
                Time_11_00 = "Testing",
                Time_11_30 = "Testing",
                Time_12_00 = "Testing",
                Time_12_30 = "Testing",
                Time_1_00 = "Lunch Break",
                Time_1_30 = "Lunch Break",
                Time_2_00 = "Lunch Break",
                Time_2_30 = "Code Review",
                Time_3_00 = "Development",
                Time_3_30 = "Documentation",
                Time_4_00 = "Documentation",
                Time_4_30 = "Team Meeting",
                Time_5_00 = "Team Meeting"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10003,
                EmployeeName = "Andrew Fuller",
                Time_9_00 = "Documentation",
                Time_9_30 = "Documentation",
                Time_10_00 = "Documentation",
                Time_10_30 = "Analysis Tasks",
                Time_11_00 = "Analysis Tasks",
                Time_11_30 = "Support",
                Time_12_00 = "Support",
                Time_12_30 = "Support",
                Time_1_00 = "Lunch Break",
                Time_1_30 = "Lunch Break",
                Time_2_00 = "Lunch Break",
                Time_2_30 = "Development",
                Time_3_00 = "Development",
                Time_3_30 = "Team Meeting",
                Time_4_00 = "Team Meeting",
                Time_4_30 = "Development",
                Time_5_00 = "Development"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10004,
                EmployeeName = "Janet Leverling",
                Time_9_00 = "Testing",
                Time_9_30 = "Documentation",
                Time_10_00 = "Documentation",
                Time_10_30 = "Support",
                Time_11_00 = "Testing",
                Time_11_30 = "Testing",
                Time_12_00 = "Testing",
                Time_12_30 = "Testing",
                Time_1_00 = "Lunch Break",
                Time_1_30 = "Lunch Break",
                Time_2_00 = "Lunch Break",
                Time_2_30 = "Development",
                Time_3_00 = "Code Review",
                Time_3_30 = "Documentation",
                Time_4_00 = "Conference",
                Time_4_30 = "Conference",
                Time_5_00 = "Team Meeting"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10005,
                EmployeeName = "Margaret Parker",
                Time_9_00 = "Task Assign",
                Time_9_30 = "Task Assign",
                Time_10_00 = "Task Assign",
                Time_10_30 = "Task Assign",
                Time_11_00 = "Documentation",
                Time_11_30 = "Support",
                Time_12_00 = "Support",
                Time_12_30 = "Support",
                Time_1_00 = "Lunch Break",
                Time_1_30 = "Lunch Break",
                Time_2_00 = "Lunch Break",
                Time_2_30 = "Development",
                Time_3_00 = "Development",
                Time_3_30 = "Team Meeting",
                Time_4_00 = "Team Meeting",
                Time_4_30 = "Testing",
                Time_5_00 = "Testing"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10006,
                EmployeeName = "Janet King",
                Time_9_00 = "Testing",
                Time_9_30 = "Testing",
                Time_10_00 = "Support",
                Time_10_30 = "Support",
                Time_11_00 = "Support",
                Time_11_30 = "Team Meeting",
                Time_12_00 = "Team Meeting",
                Time_12_30 = "Team Meeting",
                Time_1_00 = "Lunch Break",
                Time_1_30 = "Lunch Break",
                Time_2_00 = "Lunch Break",
                Time_2_30 = "Development",
                Time_3_00 = "Code Review",
                Time_3_30 = "Team Meeting",
                Time_4_00 = "Team Meeting",
                Time_4_30 = "Development",
                Time_5_00 = "Development"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10007,
                EmployeeName = "Michael Suyama",
                Time_9_00 = "Analysis Tasks",
                Time_9_30 = "Analysis Tasks",
                Time_10_00 = "Testing",
                Time_10_30 = "Development",
                Time_11_00 = "Development",
                Time_11_30 = "Testing",
                Time_12_00 = "Testing",
                Time_12_30 = "Testing",
                Time_1_00 = "Lunch Break",
                Time_1_30 = "Lunch Break",
                Time_2_00 = "Lunch Break",
                Time_2_30 = "Support",
                Time_3_00 = "Build",
                Time_3_30 = "Build",
                Time_4_00 = "Documentation",
                Time_4_30 = "Documentation",
                Time_5_00 = "Documentation"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10008,
                EmployeeName = "Robert King",
                Time_9_00 = "Task Assign",
                Time_9_30 = "Task Assign",
                Time_10_00 = "Task Assign",
                Time_10_30 = "Development",
                Time_11_00 = "Development",
                Time_11_30 = "Development",
                Time_12_00 = "Testing",
                Time_12_30 = "Support",
                Time_1_00 = "Lunch Break",
                Time_1_30 = "Lunch Break",
                Time_2_00 = "Lunch Break",
                Time_2_30 = "Documentation",
                Time_3_00 = "Documentation",
                Time_3_30 = "Documentation",
                Time_4_00 = "Team Meeting",
                Time_4_30 = "Team Meeting",
                Time_5_00 = "Build"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10009,
                EmployeeName = "Andrew Callahan",
                Time_9_00 = "Documentation",
                Time_9_30 = "Team Meeting",
                Time_10_00 = "Team Meeting",
                Time_10_30 = "Support",
                Time_11_00 = "Testing",
                Time_11_30 = "Development",
                Time_12_00 = "Development",
                Time_12_30 = "Development",
                Time_1_00 = "Lunch Break",
                Time_1_30 = "Lunch Break",
                Time_2_00 = "Lunch Break",
                Time_2_30 = "Documentation",
                Time_3_00 = "Documentation",
                Time_3_30 = "Documentation",
                Time_4_00 = "Team Meeting",
                Time_4_30 = "Development",
                Time_5_00 = "Development"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10010,
                EmployeeName = "Michael Dodsworth",
                Time_9_00 = "Task Assign",
                Time_9_30 = "Task Assign",
                Time_10_00 = "Task Assign",
                Time_10_30 = "Analysis Tasks",
                Time_11_00 = "Analysis Tasks",
                Time_11_30 = "Testing",
                Time_12_00 = "Build",
                Time_12_30 = "Task Assign",
                Time_1_00 = "Lunch Break",
                Time_1_30 = "Lunch Break",
                Time_2_00 = "Lunch Break",
                Time_2_30 = "Testing",
                Time_3_00 = "Testing",
                Time_3_30 = "Testing",
                Time_4_00 = "Build",
                Time_4_30 = "Build",
                Time_5_00 = "Testing"
            });

            return data;
        }
    }
}
