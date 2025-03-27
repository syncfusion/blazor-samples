#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

namespace blazor_gantt_human_resource_data
{
    public class HumanResourceData
    {
        internal class RecruitmentPlanModel
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
            public string HolidayName { get; set; }
            public DateTime Date { get; set; }
        }

        internal static List<RecruitmentPlanModel> RecruitmentHrCollection => new List<RecruitmentPlanModel>()
        {
            new RecruitmentPlanModel() { Id = 1, Subject = "Planning phase" },
            new RecruitmentPlanModel() { Id = 2, Subject = "Identify hiring needs", StartTime = new DateTime(2024, 06,03), Duration = 3, ParentId =1, ResponsibleTeam="HR Team", Status = "Completed", Progress=100 },
            new RecruitmentPlanModel() { Id = 3, Subject = "Job Descriptions", StartTime = new DateTime(2024, 06,10), Duration = 2, ParentId =1, ResponsibleTeam="HR Team", Status = "Completed", DependentId="2", Progress=100 },
            new RecruitmentPlanModel() { Id = 4, Subject = "Develop Recruitment Strategy", StartTime = new DateTime(2024, 06,13), Duration = 2, ParentId =1, ResponsibleTeam="HR Team", Status = "Completed", DependentId = "3", Progress=100 },
            new RecruitmentPlanModel() { Id = 5, Subject = "Sourcing Phase" },
            new RecruitmentPlanModel() { Id = 6, Subject = "Create Job Posting", StartTime = new DateTime(2024, 06,10), Duration = 3, ParentId =5, ResponsibleTeam="HR Team", Status = "Completed", Progress=100  },
            new RecruitmentPlanModel() { Id = 7, Subject = "Source Candidates", Duration = 2, ParentId =5, ResponsibleTeam="HR Team", Status = "Completed", DependentId="6", Progress=100 },
            new RecruitmentPlanModel() { Id = 8, Subject = "Screening Phase" },
            new RecruitmentPlanModel() { Id = 9, Subject = "Review Applications", StartTime = new DateTime(2024, 06,23), Duration = 3, ParentId =8, ResponsibleTeam="HR Team", Status = "Completed", Progress=100 },
            new RecruitmentPlanModel() { Id = 10, Subject = "Conduct Initial Screenings", Duration = 2, ParentId =8, ResponsibleTeam="HR Team", Status = "Completed", DependentId="9", Progress=100 },
            new RecruitmentPlanModel() { Id = 11, Subject = "Interview Phase" },
            new RecruitmentPlanModel() { Id = 12, Subject = "Schedule Interviews", StartTime = new DateTime(2024, 06,30), Duration = 3, ParentId =11, ResponsibleTeam="HR Team", Status = "Completed", Progress=100},
            new RecruitmentPlanModel() { Id = 13, Subject = "Conduct Interviews", Duration = 2, ParentId =11, ResponsibleTeam="HR Team", Status = "Completed" , Progress=100 },
            new RecruitmentPlanModel() { Id = 14, Subject = "Interview test 1", StartTime = new DateTime(2024, 07,04), Duration = 1, ParentId =13, ResponsibleTeam="HR Team", Status = "Completed", Progress=100 },
            new RecruitmentPlanModel() { Id = 15, Subject = "Interview test 2", Duration = 1, ParentId =13, ResponsibleTeam="HR Team", Status = "Completed", DependentId="14", Progress=100 },
            new RecruitmentPlanModel() { Id = 16, Subject = "Interview HR round", Duration = 1, ParentId =13, ResponsibleTeam="HR Team", Status = "Completed", DependentId="14", Progress=100 },
            new RecruitmentPlanModel() { Id = 17, Subject = "Selection Phase" },
            new RecruitmentPlanModel() { Id = 18, Subject = "Evaluate Candidates", Duration = 3, ParentId =17, ResponsibleTeam="HR Team", Status = "Completed", Progress=100 },
            new RecruitmentPlanModel() { Id = 19, Subject = "Make Job Offers", StartTime = new DateTime(2024, 07,08), Duration = 2, ParentId =18, ResponsibleTeam="HR Team", Status = "Completed", Progress=100 },
            new RecruitmentPlanModel() { Id = 20, Subject = "Onboarding Phase" },
            new RecruitmentPlanModel() { Id = 21, Subject = "Prepare Onboarding Materials", StartTime = new DateTime(2024, 07,11), Duration = 3, ParentId =20, ResponsibleTeam="HR Team", Status = "Completed", Progress=100 },
            new RecruitmentPlanModel() { Id = 22, Subject = "Onboard New Hires", Duration = 2, ParentId =20, ResponsibleTeam="HR Team", Status = "Completed", DependentId="21", Progress=100 },
            new RecruitmentPlanModel() { Id = 23, Subject = "Document Verification", Duration = 3, Status = "InProgress", ResponsibleTeam = "HR Department", DependentId="22", ParentId =20, Progress=50 },
            new RecruitmentPlanModel() { Id = 24, Subject = "Re-verification",  Duration = 2, Status = "Planned", ResponsibleTeam = "HR Department", DependentId="23", ParentId =20 },
            new RecruitmentPlanModel() { Id = 25, Subject = "Health Insurance and Bank Details",Duration = 2, Status = "Planned", ResponsibleTeam = "Accounts Department", DependentId="24", ParentId =20 },
            new RecruitmentPlanModel() { Id = 26, Subject = "PF Account Setup",  Duration = 2, Status = "Planned", ResponsibleTeam = "HR Department", DependentId="25" , ParentId =20 },
            new RecruitmentPlanModel() { Id = 27, Subject = "Employee Login ID Assignment",Duration = 1, Status = "Planned", ResponsibleTeam = "IT Department", DependentId="26", ParentId =20 },
            new RecruitmentPlanModel() { Id = 28, Subject = "Provide Accessories (Laptop, Mouse, etc.)", Duration = 2, Status = "Planned", ResponsibleTeam = "IT Department", DependentId="27", ParentId =20 },
            new RecruitmentPlanModel() { Id = 29, Subject = "Issue ID Cards", Duration = 1, Status = "Planned", ResponsibleTeam = "HR Department", DependentId="28", ParentId =20 },
            new RecruitmentPlanModel() { Id = 30, Subject = "Schedule Training Period", Duration = 5, Status = "Planned", ResponsibleTeam = "Training Department", DependentId="29", ParentId =20 },
            new RecruitmentPlanModel() { Id = 31, Subject = "Provide Gifts and Food after Training", Duration = 1, Status = "Planned", ResponsibleTeam = "HR Department", DependentId = "30", ParentId = 20},
            new RecruitmentPlanModel() { Id = 32, Subject = "Get Feedback from New Hires", Duration = 2, Status = "Planned", ResponsibleTeam = "HR Department", DependentId = "31", ParentId =20},
            new RecruitmentPlanModel() { Id = 33, Subject = "Upload Employee Details to System", Duration = 1, Status = "Planned", ResponsibleTeam = "HR Department", DependentId = "32", ParentId = 20}
        };

        internal static List<RecruitmentPlanModel> InventoryHrCollection => new List<RecruitmentPlanModel>()
        {
            new RecruitmentPlanModel { Id = 1, Subject = "Inventory Management Planning", StartTime = new DateTime(2024, 02, 01), EndTime = new DateTime(2024, 02, 10), Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 2, ParentId = 1, Subject = "Assess Current Inventory Levels", StartTime = new DateTime(2024, 02, 01), Duration=2, Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 3, ParentId = 1, Subject = "Forecast Inventory Needs", StartTime = new DateTime(2024, 02, 04), Duration=2, Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 4, ParentId = 1, Subject = "Develop Inventory Management Strategies", StartTime = new DateTime(2024, 02, 07), Duration=3, Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 5, Subject = "Procurement of Supplies", StartTime = new DateTime(2024, 02, 11), EndTime = new DateTime(2024, 02, 20), Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 6, ParentId = 6, Subject = "Identify Suppliers", StartTime = new DateTime(2024, 02, 11), Duration = 5, Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 7, ParentId = 6, Subject = "Request Quotes", StartTime = new DateTime(2024, 02, 14), Duration = 2, Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 8, ParentId = 6, Subject = "Place Orders", StartTime = new DateTime(2024, 02, 17), Duration = 3, Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 9, Subject = "Distribution of Supplies", StartTime = new DateTime(2024, 02, 21), EndTime = new DateTime(2024, 02, 28), Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 10, ParentId = 9, Subject = "Receive Supplies", StartTime = new DateTime(2024, 02, 21), Duration = 3, Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 11, ParentId = 9, Subject = "Check Quality and Quantity", StartTime = new DateTime(2024, 02, 23), Duration = 4, Status = "Planned", ResponsibleTeam = "Inventory HR Team" },
            new RecruitmentPlanModel { Id = 12, ParentId = 9, Subject = "Distribute Supplies", StartTime = new DateTime(2024, 02, 25), Duration = 2, Status = "Planned", ResponsibleTeam = "Inventory HR Team" }
        };


        internal static List<RecruitmentPlanModel> AccountingHrCollection => new List<RecruitmentPlanModel>()
        {
            new RecruitmentPlanModel { Id = 1, Subject = "Process Employee Salaries and Wages", StartTime = new DateTime(2024, 01, 01), Duration = 10, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 2, ParentId = 1, Subject = "Calculate Deductions and Benefits", StartTime = new DateTime(2024, 01, 01), Duration = 5, ResponsibleTeam = "Accounting HR Team", Progress=100 },
            new RecruitmentPlanModel { Id = 3, ParentId = 1, Subject = "Manage Payroll Records", StartTime = new DateTime(2024, 01, 06), Duration = 5, ResponsibleTeam = "Accounting HR Team", Progress=100 },
            new RecruitmentPlanModel { Id = 4, Subject = "Develop HR Budgets", StartTime = new DateTime(2024, 01, 11), Duration = 15, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 5, ParentId = 4, Subject = "Forecast HR Financial Needs", StartTime = new DateTime(2024, 01, 11), Duration = 5, ResponsibleTeam = "Accounting HR Team", Progress=100 },
            new RecruitmentPlanModel { Id = 6, ParentId = 4, Subject = "Monitor and Control HR Expenditures", StartTime = new DateTime(2024, 01, 16), Duration = 10, ResponsibleTeam = "Accounting HR Team", Progress=70 },
            new RecruitmentPlanModel { Id = 7, ParentId = 4, Subject = "Prepare HR Financial Reports", StartTime = new DateTime(2024, 01, 26), Duration = 5, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 8, Subject = "Design Compensation Structures", StartTime = new DateTime(2024, 01, 26), Duration = 20, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 9, ParentId = 8, Subject = "Review and Update Payroll Systems", StartTime = new DateTime(2024, 01, 26), Duration = 5, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 10, ParentId = 8, Subject = "Coordinate with Auditors for HR Financial Audits", StartTime = new DateTime(2024, 01, 31), Duration = 10, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 11, Subject = "Manage Employee Benefits Programs", StartTime = new DateTime(2024, 02, 01), Duration = 10, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 12, ParentId = 11, Subject = "Administer Health Insurance Programs", StartTime = new DateTime(2024, 02, 01), Duration = 5, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 13, ParentId = 11, Subject = "Manage Retirement Plans", StartTime = new DateTime(2024, 02, 06), Duration = 5, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 14, Subject = "Annual Budget Planning", StartTime = new DateTime(2024, 01, 01), Duration = 30, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 15, ParentId = 14, Subject = "Collect Departmental Budget Requests", StartTime = new DateTime(2024, 01, 01), Duration = 10, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 16, ParentId = 14, Subject = "Analyze Budget Requests", StartTime = new DateTime(2024, 01, 11), Duration = 10, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 17, ParentId = 14, Subject = "Prepare Preliminary Budget", StartTime = new DateTime(2024, 01, 21), Duration = 5, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 18, ParentId = 14, Subject = "Review Budget with Management", StartTime = new DateTime(2024, 01, 26), Duration = 4, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 19, ParentId = 14, Subject = "Finalize Budget", StartTime = new DateTime(2024, 01, 30), Duration = 1, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 20, Subject = "Mid-Year Budget Review", StartTime = new DateTime(2024, 06, 01), Duration = 15, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 21, ParentId = 20, Subject = "Collect Mid-Year Financial Data", StartTime = new DateTime(2024, 06, 01), Duration = 5, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 22, ParentId = 20, Subject = "Analyze Mid-Year Performance", StartTime = new DateTime(2024, 06, 06), Duration = 5, ResponsibleTeam = "Accounting HR Team" },
            new RecruitmentPlanModel { Id = 23, ParentId = 20, Subject = "Adjust Budget Projections", StartTime = new DateTime(2024, 06, 11), Duration = 5, ResponsibleTeam = "Accounting HR Team" }
        };

        internal static List<HolidayModel> HolidayCollection = new List<HolidayModel>()
        {      
           new HolidayModel(){ Id = 9, HolidayName = "Independence Day", Date = new DateTime(2024, 07, 04) },
        };
    }
}
