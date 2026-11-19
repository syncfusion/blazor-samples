using System;
using System.Collections.Generic;
using System.Globalization;

namespace BlazorDemos.Pages.Grid
{
    public class EmployeeDetails
    {
        public EmployeeDetails()
        {
        }
        public EmployeeDetails(int employeeid, string employeename, string time09AM, string time0930AM, string time10AM, string time1030AM, string time11AM, string time1130AM,
            string time12PM, string time1230PM, string time01PM, string time0130PM, string time02PM, string time0230PM, string time03PM, string time0330PM, string time04PM, string time0430PM,
            string time05PM)
        { 
            this.EmployeeID = employeeid;
            this.EmployeeName = employeename;
            this.Time09AM = time09AM;
            this.Time09AM = time0930AM;
            this.Time10AM= time10AM;
            this.Time1030AM = time1030AM;
            this.Time11AM = time11AM;
            this.Time1130AM = time1130AM;
            this.Time12PM = time12PM;
            this.Time1230PM= time1230PM;
            this.Time01PM = time01PM;
            this.Time0130PM = time0130PM;
            this.Time02PM = time02PM;
            this.Time0230PM = time0230PM;
            this.Time03PM = time03PM;
            this.Time0330PM = time0330PM;
            this.Time04PM = time04PM;
            this.Time0430PM = time0430PM;
            this.Time05PM = time05PM;
        }
       
            public int EmployeeID { get; set; }
            public string? EmployeeName { get; set; }
            public string? Time09AM { get; set; }
            public string? Time0930AM { get; set; }
            public string? Time10AM{ get; set; }
            public string? Time1030AM { get; set; }
            public string? Time11AM { get; set; }
            public string? Time1130AM { get; set; }
            public string? Time12PM{ get; set; }
            public string? Time1230PM{ get; set; }
            public string? Time01PM { get; set; }
            public string? Time0130PM { get; set; }
            public string? Time02PM { get; set; }
            public string? Time0230PM { get; set; }
            public string? Time03PM { get; set; }
            public string? Time0330PM { get; set; }
            public string? Time04PM { get; set; }
            public string? Time0430PM { get; set; }
            public string? Time05PM { get; set; }

        public static IReadOnlyList<EmployeeDetails> GetAllRecords()
        {
            List<EmployeeDetails> data = new List<EmployeeDetails>();

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10001,
                EmployeeName = "Nancy Davolio",
                Time09AM = "Analysis Tasks",
                Time0930AM = "Analysis Tasks",
                Time10AM= "Team Meeting",
                Time1030AM = "Testing",
                Time11AM = "Development",
                Time1130AM = "Code Review",
                Time12PM= "Development",
                Time1230PM= "Support",
                Time01PM = "Lunch Break",
                Time0130PM = "Lunch Break",
                Time02PM = "Lunch Break",
                Time0230PM = "Testing",
                Time03PM = "Testing",
                Time0330PM = "Development",
                Time04PM = "Conference",
                Time0430PM = "Team Meeting",
                Time05PM = "Team Meeting"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10002,
                EmployeeName = "Steven Buchanan",
                Time09AM = "Analysis Tasks",
                Time0930AM = "Support",
                Time10AM= "Support",
                Time1030AM = "Support",
                Time11AM = "Testing",
                Time1130AM = "Testing",
                Time12PM= "Testing",
                Time1230PM= "Testing",
                Time01PM = "Lunch Break",
                Time0130PM = "Lunch Break",
                Time02PM = "Lunch Break",
                Time0230PM = "Code Review",
                Time03PM = "Development",
                Time0330PM = "Documentation",
                Time04PM = "Documentation",
                Time0430PM = "Team Meeting",
                Time05PM = "Team Meeting"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10003,
                EmployeeName = "Andrew Fuller",
                Time09AM = "Documentation",
                Time0930AM = "Documentation",
                Time10AM= "Documentation",
                Time1030AM = "Analysis Tasks",
                Time11AM = "Analysis Tasks",
                Time1130AM = "Support",
                Time12PM= "Support",
                Time1230PM= "Support",
                Time01PM = "Lunch Break",
                Time0130PM = "Lunch Break",
                Time02PM = "Lunch Break",
                Time0230PM = "Development",
                Time03PM = "Development",
                Time0330PM = "Team Meeting",
                Time04PM = "Team Meeting",
                Time0430PM = "Development",
                Time05PM = "Development"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10004,
                EmployeeName = "Janet Leverling",
                Time09AM = "Testing",
                Time0930AM = "Documentation",
                Time10AM= "Documentation",
                Time1030AM = "Support",
                Time11AM = "Testing",
                Time1130AM = "Testing",
                Time12PM= "Testing",
                Time1230PM= "Testing",
                Time01PM = "Lunch Break",
                Time0130PM = "Lunch Break",
                Time02PM = "Lunch Break",
                Time0230PM = "Development",
                Time03PM = "Code Review",
                Time0330PM = "Documentation",
                Time04PM = "Conference",
                Time0430PM = "Conference",
                Time05PM = "Team Meeting"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10005,
                EmployeeName = "Margaret Parker",
                Time09AM = "Task Assign",
                Time0930AM = "Task Assign",
                Time10AM= "Task Assign",
                Time1030AM = "Task Assign",
                Time11AM = "Documentation",
                Time1130AM = "Support",
                Time12PM= "Support",
                Time1230PM= "Support",
                Time01PM = "Lunch Break",
                Time0130PM = "Lunch Break",
                Time02PM = "Lunch Break",
                Time0230PM = "Development",
                Time03PM = "Development",
                Time0330PM = "Team Meeting",
                Time04PM = "Team Meeting",
                Time0430PM = "Testing",
                Time05PM = "Testing"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10006,
                EmployeeName = "Janet King",
                Time09AM = "Testing",
                Time0930AM = "Testing",
                Time10AM= "Support",
                Time1030AM = "Support",
                Time11AM = "Support",
                Time1130AM = "Team Meeting",
                Time12PM= "Team Meeting",
                Time1230PM= "Team Meeting",
                Time01PM = "Lunch Break",
                Time0130PM = "Lunch Break",
                Time02PM = "Lunch Break",
                Time0230PM = "Development",
                Time03PM = "Code Review",
                Time0330PM = "Team Meeting",
                Time04PM = "Team Meeting",
                Time0430PM = "Development",
                Time05PM = "Development"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10007,
                EmployeeName = "Michael Suyama",
                Time09AM = "Analysis Tasks",
                Time0930AM = "Analysis Tasks",
                Time10AM= "Testing",
                Time1030AM = "Development",
                Time11AM = "Development",
                Time1130AM = "Testing",
                Time12PM= "Testing",
                Time1230PM= "Testing",
                Time01PM = "Lunch Break",
                Time0130PM = "Lunch Break",
                Time02PM = "Lunch Break",
                Time0230PM = "Support",
                Time03PM = "Build",
                Time0330PM = "Build",
                Time04PM = "Documentation",
                Time0430PM = "Documentation",
                Time05PM = "Documentation"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10008,
                EmployeeName = "Robert King",
                Time09AM = "Task Assign",
                Time0930AM = "Task Assign",
                Time10AM= "Task Assign",
                Time1030AM = "Development",
                Time11AM = "Development",
                Time1130AM = "Development",
                Time12PM= "Testing",
                Time1230PM= "Support",
                Time01PM = "Lunch Break",
                Time0130PM = "Lunch Break",
                Time02PM = "Lunch Break",
                Time0230PM = "Documentation",
                Time03PM = "Documentation",
                Time0330PM = "Documentation",
                Time04PM = "Team Meeting",
                Time0430PM = "Team Meeting",
                Time05PM = "Build"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10009,
                EmployeeName = "Andrew Callahan",
                Time09AM = "Documentation",
                Time0930AM = "Team Meeting",
                Time10AM= "Team Meeting",
                Time1030AM = "Support",
                Time11AM = "Testing",
                Time1130AM = "Development",
                Time12PM= "Development",
                Time1230PM= "Development",
                Time01PM = "Lunch Break",
                Time0130PM = "Lunch Break",
                Time02PM = "Lunch Break",
                Time0230PM = "Documentation",
                Time03PM = "Documentation",
                Time0330PM = "Documentation",
                Time04PM = "Team Meeting",
                Time0430PM = "Development",
                Time05PM = "Development"
            });

            data.Add(new EmployeeDetails
            {
                EmployeeID = 10010,
                EmployeeName = "Michael Dodsworth",
                Time09AM = "Task Assign",
                Time0930AM = "Task Assign",
                Time10AM= "Task Assign",
                Time1030AM = "Analysis Tasks",
                Time11AM = "Analysis Tasks",
                Time1130AM = "Testing",
                Time12PM= "Build",
                Time1230PM= "Task Assign",
                Time01PM = "Lunch Break",
                Time0130PM = "Lunch Break",
                Time02PM = "Lunch Break",
                Time0230PM = "Testing",
                Time03PM = "Testing",
                Time0330PM = "Testing",
                Time04PM = "Build",
                Time0430PM = "Build",
                Time05PM = "Testing"
            });

            return data;
        }
    }
}
