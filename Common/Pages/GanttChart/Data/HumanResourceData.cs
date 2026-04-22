#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

namespace BlazorDemos.Pages.GanttChart.Data
{
    public class HumanResourceData
    {
        public class RecruitmentPlanModel
        {
            public int Id { get; set; }
            public string Subject { get; set; } = string.Empty;
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public int Duration { get; set; }
            public string Status { get; set; } = string.Empty;
            public string ResponsibleTeam { get; set; } = string.Empty;
            public int? ParentId { get; set; }
            public string DependentId { get; set; } = string.Empty;
            public int Progress { get; set; } = 0;
        }

        internal class HolidayModel
        {
            public int Id { get; set; }
            public string HolidayName { get; set; } = string.Empty;
            public DateTime Date { get; set; }
        }

        internal static List<RecruitmentPlanModel> RecruitmentHrCollection => new List<RecruitmentPlanModel>()
        {
            new RecruitmentPlanModel() { Id = 1, Subject = "Planning phase" },
            new RecruitmentPlanModel() { Id = 2, Subject = "Identify hiring needs", StartTime = new DateTime(2024, 06,03), Duration = 3, ParentId =1, ResponsibleTeam="HR Team", Status = "Completed", Progress=100 },
            new RecruitmentPlanModel() { Id = 3, Subject = "Job descriptions", StartTime = new DateTime(2024, 06,10), Duration = 2, ParentId =1, ResponsibleTeam="HR Team", Status = "Completed", DependentId="2", Progress=100 },
            new RecruitmentPlanModel() { Id = 4, Subject = "Develop recruitment strategy", StartTime = new DateTime(2024, 06,13), Duration = 2, ParentId =1, ResponsibleTeam="HR Team", Status = "Completed", DependentId = "3", Progress=100 },
            new RecruitmentPlanModel() { Id = 5, Subject = "Sourcing phase" },
            new RecruitmentPlanModel() { Id = 6, Subject = "Create job posting", StartTime = new DateTime(2024, 06,10), Duration = 3, ParentId =5, ResponsibleTeam="HR Team", Status = "Completed", Progress=100  },
            new RecruitmentPlanModel() { Id = 7, Subject = "Source candidates", Duration = 2, ParentId =5, ResponsibleTeam="HR Team", Status = "Completed", DependentId="6", Progress=100 },
            new RecruitmentPlanModel() { Id = 8, Subject = "Screening phase" },
            new RecruitmentPlanModel() { Id = 9, Subject = "Review applications", StartTime = new DateTime(2024, 06,23), Duration = 3, ParentId =8, ResponsibleTeam="HR Team", Status = "Completed", Progress=100 },
            new RecruitmentPlanModel() { Id = 10, Subject = "Conduct initial screenings", Duration = 2, ParentId =8, ResponsibleTeam="HR Team", Status = "Completed", DependentId="9", Progress=100 },
            new RecruitmentPlanModel() { Id = 11, Subject = "Interview phase" },
            new RecruitmentPlanModel() { Id = 12, Subject = "Schedule interviews", StartTime = new DateTime(2024, 06,30), Duration = 3, ParentId =11, ResponsibleTeam="HR Team", Status = "Completed", Progress=100},
            new RecruitmentPlanModel() { Id = 13, Subject = "Conduct interviews", Duration = 2, ParentId =11, ResponsibleTeam="HR Team", Status = "Completed" , Progress=100 },
            new RecruitmentPlanModel() { Id = 14, Subject = "Interview test 1", StartTime = new DateTime(2024, 07,04), Duration = 1, ParentId =13, ResponsibleTeam="HR Team", Status = "Completed", Progress=100 },
            new RecruitmentPlanModel() { Id = 15, Subject = "Interview test 2", Duration = 1, ParentId =13, ResponsibleTeam="HR Team", Status = "Completed", DependentId="14", Progress=100 },
            new RecruitmentPlanModel() { Id = 16, Subject = "Interview HR round", Duration = 1, ParentId =13, ResponsibleTeam="HR Team", Status = "Completed", DependentId="14", Progress=100 },
            new RecruitmentPlanModel() { Id = 17, Subject = "Selection phase" },
            new RecruitmentPlanModel() { Id = 18, Subject = "Evaluate candidates", Duration = 3, ParentId =17, ResponsibleTeam="HR Team", Status = "Completed", Progress=100 },
            new RecruitmentPlanModel() { Id = 19, Subject = "Make Job offers", StartTime = new DateTime(2024, 07,08), Duration = 2, ParentId =18, ResponsibleTeam="HR Team", Status = "Completed", Progress=100 },
            new RecruitmentPlanModel() { Id = 20, Subject = "Onboarding phase" },
            new RecruitmentPlanModel() { Id = 21, Subject = "Prepare onboarding materials", StartTime = new DateTime(2024, 07,11), Duration = 3, ParentId =20, ResponsibleTeam="HR Team", Status = "Completed", Progress=100 },
            new RecruitmentPlanModel() { Id = 22, Subject = "Onboard new hires", Duration = 2, ParentId =20, ResponsibleTeam="HR Team", Status = "Completed", DependentId="21", Progress=100 },
            new RecruitmentPlanModel() { Id = 23, Subject = "Document verification", Duration = 3, Status = "InProgress", ResponsibleTeam = "HR Department", DependentId="22", ParentId =20, Progress=50 },
            new RecruitmentPlanModel() { Id = 24, Subject = "Re-verification",  Duration = 2, Status = "Planned", ResponsibleTeam = "HR Department", DependentId="23", ParentId =20 },
            new RecruitmentPlanModel() { Id = 25, Subject = "Health insurance and bank details",Duration = 2, Status = "Planned", ResponsibleTeam = "Accounts Department", DependentId="24", ParentId =20 },
            new RecruitmentPlanModel() { Id = 26, Subject = "PF account setup",  Duration = 2, Status = "Planned", ResponsibleTeam = "HR Department", DependentId="25" , ParentId =20 },
            new RecruitmentPlanModel() { Id = 27, Subject = "Employee login ID assignment",Duration = 1, Status = "Planned", ResponsibleTeam = "IT Department", DependentId="26", ParentId =20 },
            new RecruitmentPlanModel() { Id = 28, Subject = "Provide accessories (laptop, mouse, etc.)", Duration = 2, Status = "Planned", ResponsibleTeam = "IT Department", DependentId="27", ParentId =20 },
            new RecruitmentPlanModel() { Id = 29, Subject = "Issue ID cards", Duration = 1, Status = "Planned", ResponsibleTeam = "HR Department", DependentId="28", ParentId =20 },
            new RecruitmentPlanModel() { Id = 30, Subject = "Schedule training period", Duration = 5, Status = "Planned", ResponsibleTeam = "Training Department", DependentId="29", ParentId =20 },
            new RecruitmentPlanModel() { Id = 31, Subject = "Provide gifts and food after training", Duration = 1, Status = "Planned", ResponsibleTeam = "HR Department", DependentId = "30", ParentId = 20},
            new RecruitmentPlanModel() { Id = 32, Subject = "Get feedback from new hires", Duration = 2, Status = "Planned", ResponsibleTeam = "HR Department", DependentId = "31", ParentId =20},
            new RecruitmentPlanModel() { Id = 33, Subject = "Upload employee details to system", Duration = 1, Status = "Planned", ResponsibleTeam = "HR Department", DependentId = "32", ParentId = 20}
        };

        internal static List<RecruitmentPlanModel> InventoryHrCollection => new List<RecruitmentPlanModel>()
        {
            new RecruitmentPlanModel { Id = 1, Subject = "Inventory management planning", StartTime = new DateTime(2024, 02, 01), EndTime = new DateTime(2024, 02, 10), Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 2, ParentId = 1, Subject = "Assess current inventory levels", StartTime = new DateTime(2024, 02, 01), Duration=2, Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 3, ParentId = 1, Subject = "Forecast inventory needs", StartTime = new DateTime(2024, 02, 04), Duration=2, Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 4, ParentId = 1, Subject = "Develop inventory management strategies", StartTime = new DateTime(2024, 02, 07), Duration=3, Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 5, Subject = "Procurement of supplies", StartTime = new DateTime(2024, 02, 11), EndTime = new DateTime(2024, 02, 20), Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 6, ParentId = 6, Subject = "Identify suppliers", StartTime = new DateTime(2024, 02, 11), Duration = 5, Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 7, ParentId = 6, Subject = "Request quotes", StartTime = new DateTime(2024, 02, 14), Duration = 2, Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 8, ParentId = 6, Subject = "Place orders", StartTime = new DateTime(2024, 02, 17), Duration = 3, Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 9, Subject = "Distribution of supplies", StartTime = new DateTime(2024, 02, 21), EndTime = new DateTime(2024, 02, 28), Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 10, ParentId = 9, Subject = "Receive supplies", StartTime = new DateTime(2024, 02, 21), Duration = 3, Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 11, ParentId = 9, Subject = "Check quality and quantity", StartTime = new DateTime(2024, 02, 23), Duration = 4, Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 12, ParentId = 9, Subject = "Distribute supplies", StartTime = new DateTime(2024, 02, 25), Duration = 2, Status = "Planned", ResponsibleTeam = "Inventory HR Team" }
        };


        internal static List<RecruitmentPlanModel> AccountingHrCollection => new List<RecruitmentPlanModel>()
        {
            new RecruitmentPlanModel { Id = 1, Subject = "Process employee salaries and Wages", StartTime = new DateTime(2024, 01, 01), Duration = 10, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 2, ParentId = 1, Subject = "Calculate deductions and benefits", StartTime = new DateTime(2024, 01, 01), Duration = 5, ResponsibleTeam = "Accounting HR Team", Progress=100 },
            new RecruitmentPlanModel { Id = 3, ParentId = 1, Subject = "Manage payroll records", StartTime = new DateTime(2024, 01, 06), Duration = 5, ResponsibleTeam = "Accounting HR Team", Progress=100 },
            new RecruitmentPlanModel { Id = 4, Subject = "Develop HR budgets", StartTime = new DateTime(2024, 01, 11), Duration = 15, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 5, ParentId = 4, Subject = "Forecast HR financial needs", StartTime = new DateTime(2024, 01, 11), Duration = 5, ResponsibleTeam = "Accounting HR Team", Progress=100 },
            new RecruitmentPlanModel { Id = 6, ParentId = 4, Subject = "Monitor and control HR expenditures", StartTime = new DateTime(2024, 01, 16), Duration = 10, ResponsibleTeam = "Accounting HR Team", Progress=70 },
            new RecruitmentPlanModel { Id = 7, ParentId = 4, Subject = "Prepare HR financial reports", StartTime = new DateTime(2024, 01, 26), Duration = 5, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 8, Subject = "Design compensation structures", StartTime = new DateTime(2024, 01, 26), Duration = 20, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 9, ParentId = 8, Subject = "Review and update payroll systems", StartTime = new DateTime(2024, 01, 26), Duration = 5, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 10, ParentId = 8, Subject = "Coordinate with auditors for HR financial audits", StartTime = new DateTime(2024, 01, 31), Duration = 10, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 11, Subject = "Manage employee benefits programs", StartTime = new DateTime(2024, 02, 01), Duration = 10, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 12, ParentId = 11, Subject = "Administer health insurance programs", StartTime = new DateTime(2024, 02, 01), Duration = 5, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 13, ParentId = 11, Subject = "Manage retirement plans", StartTime = new DateTime(2024, 02, 06), Duration = 5, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 14, Subject = "Annual budget planning", StartTime = new DateTime(2024, 01, 01), Duration = 30, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 15, ParentId = 14, Subject = "Collect departmental budget requests", StartTime = new DateTime(2024, 01, 01), Duration = 10, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 16, ParentId = 14, Subject = "Analyze budget requests", StartTime = new DateTime(2024, 01, 11), Duration = 10, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 17, ParentId = 14, Subject = "Prepare preliminary budget", StartTime = new DateTime(2024, 01, 21), Duration = 5, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 18, ParentId = 14, Subject = "Review budget with management", StartTime = new DateTime(2024, 01, 26), Duration = 4, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 19, ParentId = 14, Subject = "Finalize budget", StartTime = new DateTime(2024, 01, 30), Duration = 1, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 20, Subject = "Mid-year budget review", StartTime = new DateTime(2024, 06, 01), Duration = 15, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 21, ParentId = 20, Subject = "Collect mid-year financial data", StartTime = new DateTime(2024, 06, 01), Duration = 5, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 22, ParentId = 20, Subject = "Analyze mid-year performance", StartTime = new DateTime(2024, 06, 06), Duration = 5, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 23, ParentId = 20, Subject = "Adjust budget projections", StartTime = new DateTime(2024, 06, 11), Duration = 5, ResponsibleTeam = "Accounting HR Team" }
        };

        internal static List<HolidayModel> HolidayCollection = new List<HolidayModel>()
        {      
           new HolidayModel(){ Id = 9, HolidayName = "Independence Day", Date = new DateTime(2024, 07, 04) },
        };
    }
}
