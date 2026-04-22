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
using System.Text;
using System.Threading.Tasks;

namespace ProjectTaskData
{
    public class ProjectTask
    {
        public string ActivityName { get; set; } = string.Empty;
        public string LevelId { get; set; } = string.Empty;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Supervisor { get; set; } = string.Empty;
        public string Team { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int Progress { get; set; }
        public decimal TotalBudget { get; set; }
        public decimal PaidToDate { get; set; }
        public string Currency { get; set; } = string.Empty;
        public string CostCode { get; set; } = string.Empty;
        public string PermitStatus { get; set; } = string.Empty;
        public DateTime? InspectionDate { get; set; }
        public string InspectionStatus { get; set; } = string.Empty;
        public string FollowUpActions { get; set; } = string.Empty;
        public decimal InspectionCost { get; set; }
        public string PunchListStatus { get; set; } = string.Empty;
        public string DocumentReference { get; set; } = string.Empty;
        public string MaterialUsed { get; set; } = string.Empty;
        public decimal MaterialCost { get; set; }
        public string MaterialStockRemaining { get; set; } = string.Empty;
        public List<ProjectTask> Children { get; set; } = new();

        public static List<ProjectTask> GetRowSpanData()
        {
            return new List<ProjectTask>
            {
                new ProjectTask
                {
                    ActivityName = "Tower",
                    LevelId = "L1-001",
                    StartDate = new DateTime(2025, 7, 1),
                    EndDate = new DateTime(2025, 12, 29),
                    Supervisor = "John Carter",
                    Team = "Executive Oversight",
                    Status = "Active",
                    Progress = 70,
                    TotalBudget = 1500000m,
                    PaidToDate = 1050000m,
                    Currency = "USD",
                    CostCode = "01-00-00",
                    PermitStatus = "Approved",
                    InspectionDate = new DateTime(2025, 12, 30),
                    InspectionStatus = "Active",
                    FollowUpActions = "Monitor progress",
                    InspectionCost = 600m,
                    PunchListStatus = "Open",
                    DocumentReference = "DOC-TWR-OVR",
                    MaterialUsed = "Project Planning Kits",
                    MaterialCost = 75000m,
                    MaterialStockRemaining = "N/A",
                    Children = new List<ProjectTask>
                    {
                        new ProjectTask
                        {
                            ActivityName = "Design Stage",
                            LevelId = "L2-001",
                            StartDate = new DateTime(2025, 7, 1),
                            EndDate = new DateTime(2025, 8, 15),
                            Supervisor = "Ethan Park",
                            Team = "Design Division",
                            Status = "Completed",
                            Progress = 100,
                            TotalBudget = 305000m,
                            PaidToDate = 350000m,
                            Currency = "USD",
                            CostCode = "02-01-00",
                            PermitStatus = "Issued",
                            InspectionDate = new DateTime(2025, 8, 16),
                            InspectionStatus = "Passed",
                            FollowUpActions = "None",
                            InspectionCost = 200m,
                            PunchListStatus = "Cleared",
                            DocumentReference = "DOC-TWR-DES-STG",
                            MaterialUsed = "Design Blueprints",
                            MaterialCost = 50000m,
                            MaterialStockRemaining = "N/A",
                            Children = new List<ProjectTask>
                            {
                                new ProjectTask { ActivityName = "Architectural Design Task", LevelId = "L3-001", StartDate = new DateTime(2025, 7, 2), EndDate = new DateTime(2025, 7, 10), Supervisor = "David Lin", Team = "Architecture Unit", Status = "Scheduled", Progress = 100, TotalBudget = 100000m, PaidToDate = 0m, Currency = "USD", CostCode = "02-02-01", PermitStatus = "Scheduled", InspectionDate = new DateTime(2025, 7, 11), InspectionStatus = "Passed", FollowUpActions = "None", InspectionCost = 100m, PunchListStatus = "Cleared", DocumentReference = "DOC-TWR-ARC-TSK", MaterialUsed = "CAD Drawings", MaterialCost = 15000m, MaterialStockRemaining = "N/A" },
                                new ProjectTask { ActivityName = "Structural Design Task", LevelId = "L3-002", StartDate = new DateTime(2025, 7, 11), EndDate = new DateTime(2025, 7, 25), Supervisor = "Sarah Patel", Team = "Structural Unit", Status = "Scheduled", Progress = 100, TotalBudget = 120000m, PaidToDate = 0m, Currency = "USD", CostCode = "02-02-02", PermitStatus = "Scheduled", InspectionDate = new DateTime(2025, 7, 26), InspectionStatus = "Passed", FollowUpActions = "None", InspectionCost = 100m, PunchListStatus = "Cleared", DocumentReference = "DOC-TWR-STR-TSK", MaterialUsed = "Structural Plans", MaterialCost = 15000m, MaterialStockRemaining = "N/A" },
                                new ProjectTask { ActivityName = "MEP Design Task", LevelId = "L3-003", StartDate = new DateTime(2025, 7, 26), EndDate = new DateTime(2025, 8, 15), Supervisor = "Carlos Rivera", Team = "MEP Unit", Status = "Scheduled", Progress = 100, TotalBudget = 100000m, PaidToDate = 0m, Currency = "USD", CostCode = "02-02-03", PermitStatus = "Scheduled", InspectionDate = new DateTime(2025, 8, 16), InspectionStatus = "Passed", FollowUpActions = "None", InspectionCost = 100m, PunchListStatus = "Cleared", DocumentReference = "DOC-TWR-MEP-TSK", MaterialUsed = "Electrical Schematics", MaterialCost = 20000m, MaterialStockRemaining = "N/A" }
                            }
                        },
                        new ProjectTask
                        {
                            ActivityName = "Construction Stage",
                            LevelId = "L2-002",
                            StartDate = new DateTime(2025, 8, 16),
                            EndDate = new DateTime(2025, 10, 20),
                            Supervisor = "James Patel",
                            Team = "Construction Division",
                            Status = "In Progress",
                            Progress = 75,
                            TotalBudget = 900000m,
                            PaidToDate = 675000m,
                            Currency = "USD",
                            CostCode = "03-01-00",
                            PermitStatus = "Issued",
                            InspectionDate = new DateTime(2025, 10, 21),
                            InspectionStatus = "Passed with Notes",
                            FollowUpActions = "Reinforce structure",
                            InspectionCost = 300m,
                            PunchListStatus = "Open",
                            DocumentReference = "DOC-TWR-CON-STG",
                            MaterialUsed = "Construction Materials",
                            MaterialCost = 50000m,
                            MaterialStockRemaining = "300 tons",
                            Children = new List<ProjectTask>
                            {
                                new ProjectTask { ActivityName = "Foundation Construction Task", LevelId = "L3-004", StartDate = new DateTime(2025, 8, 16), EndDate = new DateTime(2025, 8, 25), Supervisor = "Robert Singh", Team = "Foundation Crew", Status = "Completed", Progress = 100, TotalBudget = 305000m, PaidToDate = 350000m, Currency = "USD", CostCode = "03-02-01", PermitStatus = "Approved", InspectionDate = new DateTime(2025, 8, 26), InspectionStatus = "Passed", FollowUpActions = "None", InspectionCost = 100m, PunchListStatus = "Cleared", DocumentReference = "DOC-TWR-FND-TSK", MaterialUsed = "Concrete", MaterialCost = 15000m, MaterialStockRemaining = "N/A" },
                                new ProjectTask { ActivityName = "Structural Construction Task", LevelId = "L3-005", StartDate = new DateTime(2025, 8, 26), EndDate = new DateTime(2025, 9, 20), Supervisor = "Nathan Blake", Team = "Structural Team", Status = "In Progress", Progress = 80, TotalBudget = 300000m, PaidToDate = 240000m, Currency = "USD", CostCode = "03-02-02", PermitStatus = "Approved", InspectionDate = new DateTime(2025, 9, 21), InspectionStatus = "Passed with Notes", FollowUpActions = "Reinforce beams", InspectionCost = 100m, PunchListStatus = "Open", DocumentReference = "DOC-TWR-STR-TSK", MaterialUsed = "Steel Beams", MaterialCost = 20000m, MaterialStockRemaining = "200 tons" },
                                new ProjectTask { ActivityName = "Exterior Construction Task", LevelId = "L3-006", StartDate = new DateTime(2025, 9, 21), EndDate = new DateTime(2025, 10, 20), Supervisor = "Thomas Reed", Team = "Exterior Crew", Status = "In Progress", Progress = 40, TotalBudget = 300000m, PaidToDate = 120000m, Currency = "USD", CostCode = "03-02-03", PermitStatus = "Approved", InspectionDate = new DateTime(2025, 10, 21), InspectionStatus = "Passed with Notes", FollowUpActions = "Continue exterior work", InspectionCost = 100m, PunchListStatus = "Open", DocumentReference = "DOC-TWR-EXT-TSK", MaterialUsed = "Metal Panels", MaterialCost = 15000m, MaterialStockRemaining = "300 panels" }
                            }
                        },
                        new ProjectTask
                        {
                            ActivityName = "Safety Stage",
                            LevelId = "L2-003",
                            StartDate = new DateTime(2025, 10, 21),
                            EndDate = new DateTime(2025, 11, 5),
                            Supervisor = "Nathan Blake",
                            Team = "Safety Division",
                            Status = "In Progress",
                            Progress = 60,
                            TotalBudget = 50000m,
                            PaidToDate = 30000m,
                            Currency = "USD",
                            CostCode = "04-01-00",
                            PermitStatus = "Issued",
                            InspectionDate = new DateTime(2025, 11, 6),
                            InspectionStatus = "Scheduled",
                            FollowUpActions = "Complete safety audit",
                            InspectionCost = 0m,
                            PunchListStatus = "Open",
                            DocumentReference = "DOC-TWR-SAF-STG",
                            MaterialUsed = "Safety Equipment",
                            MaterialCost = 10000m,
                            MaterialStockRemaining = "50 units",
                            Children = new List<ProjectTask>
                            {
                                new ProjectTask { ActivityName = "OSHA Compliance Task", LevelId = "L3-007", StartDate = new DateTime(2025, 10, 21), EndDate = new DateTime(2025, 10, 27), Supervisor = "Laura Bennett", Team = "Safety Inspectors", Status = "In Progress", Progress = 70, TotalBudget = 20000m, PaidToDate = 14000m, Currency = "USD", CostCode = "04-02-01", PermitStatus = "Issued", InspectionDate = new DateTime(2025, 10, 28), InspectionStatus = "In Progress", FollowUpActions = "Complete briefing", InspectionCost = 0m, PunchListStatus = "Open", DocumentReference = "DOC-TWR-OSHA-TSK", MaterialUsed = "Safety Gear", MaterialCost = 4000m, MaterialStockRemaining = "40 helmets" },
                                new ProjectTask { ActivityName = "Fire Safety Task", LevelId = "L3-008", StartDate = new DateTime(2025, 10, 28), EndDate = new DateTime(2025, 11, 1), Supervisor = "Melissa Tran", Team = "Fire Safety Team", Status = "Scheduled", Progress = 30, TotalBudget = 15000m, PaidToDate = 0m, Currency = "USD", CostCode = "04-02-02", PermitStatus = "Issued", InspectionDate = new DateTime(2025, 11, 2), InspectionStatus = "Scheduled", FollowUpActions = "Install exits", InspectionCost = 0m, PunchListStatus = "Open", DocumentReference = "DOC-TWR-FIRE-TSK", MaterialUsed = "Extinguishers", MaterialCost = 3000m, MaterialStockRemaining = "15 units" },
                                new ProjectTask { ActivityName = "Structural Audit Task", LevelId = "L3-009", StartDate = new DateTime(2025, 11, 2), EndDate = new DateTime(2025, 11, 5), Supervisor = "David Lin", Team = "Audit Engineers", Status = "Scheduled", Progress = 20, TotalBudget = 15000m, PaidToDate = 0m, Currency = "USD", CostCode = "04-02-03", PermitStatus = "Issued", InspectionDate = new DateTime(2025, 11, 6), InspectionStatus = "Scheduled", FollowUpActions = "Verify integrity", InspectionCost = 0m, PunchListStatus = "Open", DocumentReference = "DOC-TWR-AUD-TSK", MaterialUsed = "Inspection Tools", MaterialCost = 3000m, MaterialStockRemaining = "N/A" }
                            }
                        },
                        new ProjectTask
                        {
                            ActivityName = "Finishing Stage",
                            LevelId = "L2-004",
                            StartDate = new DateTime(2025, 11, 6),
                            EndDate = new DateTime(2025, 12, 10),
                            Supervisor = "Melissa Tran",
                            Team = "Finishing Division",
                            Status = "Planning",
                            Progress = 30,
                            TotalBudget = 250000m,
                            PaidToDate = 75000m,
                            Currency = "USD",
                            CostCode = "05-01-00",
                            PermitStatus = "Under Review",
                            InspectionDate = new DateTime(2025, 12, 11),
                            InspectionStatus = "Scheduled",
                            FollowUpActions = "Begin interior work",
                            InspectionCost = 0m,
                            PunchListStatus = "Pending",
                            DocumentReference = "DOC-TWR-FIN-STG",
                            MaterialUsed = "Finishing Supplies",
                            MaterialCost = 25000m,
                            MaterialStockRemaining = "200 units",
                            Children = new List<ProjectTask>
                            {
                                new ProjectTask { ActivityName = "Interior Drywall Task", LevelId = "L3-010", StartDate = new DateTime(2025, 11, 6), EndDate = new DateTime(2025, 11, 20), Supervisor = "Hannah Kim", Team = "Drywall Crew", Status = "In Progress", Progress = 50, TotalBudget = 80000m, PaidToDate = 40000m, Currency = "USD", CostCode = "05-02-01", PermitStatus = "Issued", InspectionDate = new DateTime(2025, 11, 21), InspectionStatus = "In Progress", FollowUpActions = "Check alignment", InspectionCost = 0m, PunchListStatus = "Open", DocumentReference = "DOC-TWR-DRY-TSK", MaterialUsed = "Drywall Sheets", MaterialCost = 8000m, MaterialStockRemaining = "150 panels" },
                                new ProjectTask { ActivityName = "Flooring Installation Task", LevelId = "L3-011", StartDate = new DateTime(2025, 11, 21), EndDate = new DateTime(2025, 12, 1), Supervisor = "Sarah Patel", Team = "Flooring Team", Status = "Scheduled", Progress = 10, TotalBudget = 80000m, PaidToDate = 0m, Currency = "USD", CostCode = "05-02-02", PermitStatus = "Issued", InspectionDate = new DateTime(2025, 12, 2), InspectionStatus = "Scheduled", FollowUpActions = "Verify level", InspectionCost = 0m, PunchListStatus = "Open", DocumentReference = "DOC-TWR-FLR-TSM", MaterialUsed = "Concrete Flooring", MaterialCost = 10000m, MaterialStockRemaining = "200 bags" },
                                new ProjectTask { ActivityName = "Fixture Setup Task", LevelId = "L3-012", StartDate = new DateTime(2025, 12, 2), EndDate = new DateTime(2025, 12, 10), Supervisor = "Lucas Nguyen", Team = "Fit-Out Crew", Status = "Scheduled", Progress = 10, TotalBudget = 90000m, PaidToDate = 0m, Currency = "USD", CostCode = "05-02-03", PermitStatus = "Issued", InspectionDate = new DateTime(2025, 12, 11), InspectionStatus = "Scheduled", FollowUpActions = "Install fixtures", InspectionCost = 0m, PunchListStatus = "Open", DocumentReference = "DOC-TWR-FIX-TSK", MaterialUsed = "Lighting Fixtures", MaterialCost = 7000m, MaterialStockRemaining = "50 units" }
                            }
                        },
                        new ProjectTask
                        {
                            ActivityName = "Closeout Stage",
                            LevelId = "L2-005",
                            StartDate = new DateTime(2025, 12, 11),
                            EndDate = new DateTime(2025, 12, 29),
                            Supervisor = "Emma Wilson",
                            Team = "Closeout Division",
                            Status = "Planning",
                            Progress = 20,
                            TotalBudget = 50000m,
                            PaidToDate = 10000m,
                            Currency = "USD",
                            CostCode = "06-01-00",
                            PermitStatus = "Under Review",
                            InspectionDate = new DateTime(2025, 12, 30),
                            InspectionStatus = "Scheduled",
                            FollowUpActions = "Finalize handover",
                            InspectionCost = 0m,
                            PunchListStatus = "Open",
                            DocumentReference = "DOC-TWR-CLO-STG",
                            MaterialUsed = "Closeout Documents",
                            MaterialCost = 5000m,
                            MaterialStockRemaining = "N/A",
                            Children = new List<ProjectTask>
                            {
                                new ProjectTask { ActivityName = "Punch List Review Task", LevelId = "L3-013", StartDate = new DateTime(2025, 12, 11), EndDate = new DateTime(2025, 12, 15), Supervisor = "John Carter", Team = "Closeout Team", Status = "Scheduled", Progress = 20, TotalBudget = 15000m, PaidToDate = 0m, Currency = "USD", CostCode = "06-02-01", PermitStatus = "Scheduled", InspectionDate = new DateTime(2025, 12, 16), InspectionStatus = "Not Started", FollowUpActions = "Resolve issues", InspectionCost = 0m, PunchListStatus = "Pending", DocumentReference = "DOC-TWR-PLR-TSK", MaterialUsed = "Punch List Forms", MaterialCost = 2000m, MaterialStockRemaining = "N/A" },
                                new ProjectTask { ActivityName = "Final Documentation Task", LevelId = "L3-014", StartDate = new DateTime(2025, 12, 16), EndDate = new DateTime(2025, 12, 22), Supervisor = "Emily Foster", Team = "Documentation Team", Status = "Scheduled", Progress = 20, TotalBudget = 15000m, PaidToDate = 0m, Currency = "USD", CostCode = "06-02-02", PermitStatus = "Scheduled", InspectionDate = new DateTime(2025, 12, 23), InspectionStatus = "Not Started", FollowUpActions = "Prepare reports", InspectionCost = 0m, PunchListStatus = "Pending", DocumentReference = "DOC-TWR-FD-TSK", MaterialUsed = "As-Built Drawings", MaterialCost = 2000m, MaterialStockRemaining = "N/A" },
                                new ProjectTask { ActivityName = "Client Handover Task", LevelId = "L3-015", StartDate = new DateTime(2025, 12, 23), EndDate = new DateTime(2025, 12, 29), Supervisor = "Emma Wilson", Team = "Client Relations", Status = "Scheduled", Progress = 20, TotalBudget = 20000m, PaidToDate = 0m, Currency = "USD", CostCode = "06-02-03", PermitStatus = "Scheduled", InspectionDate = new DateTime(2025, 12, 30), InspectionStatus = "Not Started", FollowUpActions = "Conduct walkthrough", InspectionCost = 0m, PunchListStatus = "Pending", DocumentReference = "DOC-TWR-CH-TSK", MaterialUsed = "Handover Kits", MaterialCost = 1000m, MaterialStockRemaining = "Delivered" }
                            }
                        }
                    }
                },
                new ProjectTask
                {
                    ActivityName = "Warehouse",
                    LevelId = "L1-004",
                    StartDate = new DateTime(2025, 8, 1),
                    EndDate = new DateTime(2025, 12, 28),
                    Supervisor = "Emma Wilson",
                    Team = "Executive Oversight",
                    Status = "Active",
                    Progress = 55,
                    TotalBudget = 1030000m,
                    PaidToDate = 566500m,
                    Currency = "USD",
                    CostCode = "01-00-00",
                    PermitStatus = "Approved",
                    InspectionDate = new DateTime(2025, 12, 29),
                    InspectionStatus = "Passed with Notes",
                    FollowUpActions = "Address structural concerns",
                    InspectionCost = 400m,
                    PunchListStatus = "Open",
                    DocumentReference = "DOC-WH-OVR",
                    MaterialUsed = "Project Planning Kits",
                    MaterialCost = 50000m,
                    MaterialStockRemaining = "N/A",
                    Children = new List<ProjectTask>
                    {
                        new ProjectTask
                        {
                            ActivityName = "Design Stage",
                            LevelId = "L2-016",
                            StartDate = new DateTime(2025, 8, 1),
                            EndDate = new DateTime(2025, 9, 10),
                            Supervisor = "Ethan Park",
                            Team = "Design Division",
                            Status = "Completed",
                            Progress = 100,
                            TotalBudget = 202000m,
                            PaidToDate = 220000m,
                            Currency = "USD",
                            CostCode = "02-01-00",
                            PermitStatus = "Issued",
                            InspectionDate = new DateTime(2025, 9, 11),
                            InspectionStatus = "Passed",
                            FollowUpActions = "None",
                            InspectionCost = 300m,
                            PunchListStatus = "Cleared",
                            DocumentReference = "DOC-WH-DES-STG",
                            MaterialUsed = "Design Blueprints",
                            MaterialCost = 30000m,
                            MaterialStockRemaining = "N/A",
                            Children = new List<ProjectTask>
                            {
                                new ProjectTask { ActivityName = "Architectural Design Task", LevelId = "L3-046", StartDate = new DateTime(2025, 8, 2), EndDate = new DateTime(2025, 8, 12), Supervisor = "David Lin", Team = "Architecture Unit", Status = "Completed", Progress = 100, TotalBudget = 70000m, PaidToDate = 70200m, Currency = "USD", CostCode = "02-02-01", PermitStatus = "Approved", InspectionDate = new DateTime(2025, 8, 13), InspectionStatus = "Passed", FollowUpActions = "None", InspectionCost = 100m, PunchListStatus = "Cleared", DocumentReference = "DOC-WH-ARC-TSK", MaterialUsed = "CAD Drawings", MaterialCost = 10000m, MaterialStockRemaining = "N/A" },
                                new ProjectTask { ActivityName = "Structural Design Task", LevelId = "L3-047", StartDate = new DateTime(2025, 8, 13), EndDate = new DateTime(2025, 8, 28), Supervisor = "Sarah Patel", Team = "Structural Unit", Status = "Completed", Progress = 100, TotalBudget = 72000m, PaidToDate = 70000m, Currency = "USD", CostCode = "02-02-02", PermitStatus = "Approved", InspectionDate = new DateTime(2025, 8, 29), InspectionStatus = "Passed", FollowUpActions = "None", InspectionCost = 100m, PunchListStatus = "Cleared", DocumentReference = "DOC-WH-STR-TSK", MaterialUsed = "Structural Plans", MaterialCost = 10000m, MaterialStockRemaining = "N/A" },
                                new ProjectTask { ActivityName = "MEP Design Task", LevelId = "L3-048", StartDate = new DateTime(2025, 8, 29), EndDate = new DateTime(2025, 9, 10), Supervisor = "Carlos Rivera", Team = "MEP Unit", Status = "Completed", Progress = 100, TotalBudget = 62000m, PaidToDate = 60000m, Currency = "USD", CostCode = "02-02-03", PermitStatus = "Approved", InspectionDate = new DateTime(2025, 9, 11), InspectionStatus = "Passed", FollowUpActions = "None", InspectionCost = 100m, PunchListStatus = "Cleared", DocumentReference = "DOC-WH-MEP-TSK", MaterialUsed = "Electrical Schematics", MaterialCost = 10000m, MaterialStockRemaining = "N/A" }
                            }
                        },
                        new ProjectTask
                        {
                            ActivityName = "Construction Stage",
                            LevelId = "L2-017",
                            StartDate = new DateTime(2025, 9, 11),
                            EndDate = new DateTime(2025, 11, 20),
                            Supervisor = "James Patel",
                            Team = "Construction Division",
                            Status = "In Progress",
                            Progress = 50,
                            TotalBudget = 800000m,
                            PaidToDate = 400000m,
                            Currency = "USD",
                            CostCode = "03-01-00",
                            PermitStatus = "Issued",
                            InspectionDate = new DateTime(2025, 11, 21),
                            InspectionStatus = "Passed with Notes",
                            FollowUpActions = "Address structural issues",
                            InspectionCost = 400m,
                            PunchListStatus = "Open",
                            DocumentReference = "DOC-WH-CON-STG",
                            MaterialUsed = "Construction Materials",
                            MaterialCost = 200000m,
                            MaterialStockRemaining = "500 tons",
                            Children = new List<ProjectTask>
                            {
                                new ProjectTask { ActivityName = "Foundation Construction Task", LevelId = "L3-049", StartDate = new DateTime(2025, 9, 11), EndDate = new DateTime(2025, 9, 25), Supervisor = "Robert Singh", Team = "Foundation Crew", Status = "Completed", Progress = 100, TotalBudget = 300000m, PaidToDate = 320000m, Currency = "USD", CostCode = "03-02-01", PermitStatus = "Approved", InspectionDate = new DateTime(2025, 9, 26), InspectionStatus = "Passed", FollowUpActions = "None", InspectionCost = 100m, PunchListStatus = "Cleared", DocumentReference = "DOC-WH-FND-TSK", MaterialUsed = "Concrete Mix", MaterialCost = 80000m, MaterialStockRemaining = "N/A" },
                                new ProjectTask { ActivityName = "Framing Construction Task", LevelId = "L3-050", StartDate = new DateTime(2025, 9, 26), EndDate = new DateTime(2025, 10, 25), Supervisor = "Angela Moore", Team = "Structural Crew", Status = "In Progress", Progress = 60, TotalBudget = 300000m, PaidToDate = 180000m, Currency = "USD", CostCode = "03-02-02", PermitStatus = "Approved", InspectionDate = new DateTime(2025, 10, 26), InspectionStatus = "Passed with Notes", FollowUpActions = "Continue framing", InspectionCost = 200m, PunchListStatus = "Open", DocumentReference = "DOC-WH-FRM-TSK", MaterialUsed = "Steel Beams", MaterialCost = 60000m, MaterialStockRemaining = "200 tons" },
                                new ProjectTask { ActivityName = "Exterior Construction Task", LevelId = "L3-051", StartDate = new DateTime(2025, 10, 26), EndDate = new DateTime(2025, 11, 20), Supervisor = "Thomas Reed", Team = "Exterior Crew", Status = "In Progress", Progress = 20, TotalBudget = 200000m, PaidToDate = 40000m, Currency = "USD", CostCode = "03-02-03", PermitStatus = "Issued", InspectionDate = new DateTime(2025, 11, 21), InspectionStatus = "In Progress", FollowUpActions = "Continue exterior work", InspectionCost = 0m, PunchListStatus = "Open", DocumentReference = "DOC-WH-EXT-TSK", MaterialUsed = "Metal Panels", MaterialCost = 60000m, MaterialStockRemaining = "300 panels" }
                            }
                        },
                        new ProjectTask
                        {
                            ActivityName = "Safety Stage",
                            LevelId = "L2-018",
                            StartDate = new DateTime(2025, 11, 21),
                            EndDate = new DateTime(2025, 12, 10),
                            Supervisor = "Nathan Blake",
                            Team = "Safety Division",
                            Status = "Planning",
                            Progress = 30,
                            TotalBudget = 30000m,
                            PaidToDate = 9000m,
                            Currency = "USD",
                            CostCode = "04-01-00",
                            PermitStatus = "Under Review",
                            InspectionDate = new DateTime(2025, 12, 11),
                            InspectionStatus = "Scheduled",
                            FollowUpActions = "Schedule safety audit",
                            InspectionCost = 0m,
                            PunchListStatus = "Scheduled",
                            DocumentReference = "DOC-WH-SAF-STG",
                            MaterialUsed = "Safety Equipment",
                            MaterialCost = 5000m,
                            MaterialStockRemaining = "50 units",
                            Children = new List<ProjectTask>
                            {
                                new ProjectTask { ActivityName = "OSHA Compliance Task", LevelId = "L3-052", StartDate = new DateTime(2025, 11, 21), EndDate = new DateTime(2025, 11, 28), Supervisor = "Laura Bennett", Team = "Safety Inspectors", Status = "Scheduled", Progress = 30, TotalBudget = 10000m, PaidToDate = 0m, Currency = "USD", CostCode = "04-02-01", PermitStatus = "Scheduled", InspectionDate = new DateTime(2025, 11, 29), InspectionStatus = "Not Started", FollowUpActions = "Conduct briefing", InspectionCost = 0m, PunchListStatus = "Not Started", DocumentReference = "DOC-WH-OSHA-TSK", MaterialUsed = "Safety Gear", MaterialCost = 2000m, MaterialStockRemaining = "40 helmets" },
                                new ProjectTask { ActivityName = "Fire Safety Task", LevelId = "L3-053", StartDate = new DateTime(2025, 11, 29), EndDate = new DateTime(2025, 12, 5), Supervisor = "Melissa Tran", Team = "Fire Safety Team", Status = "Scheduled", Progress = 20, TotalBudget = 10000m, PaidToDate = 0m, Currency = "USD", CostCode = "04-02-02", PermitStatus = "Scheduled", InspectionDate = new DateTime(2025, 12, 6), InspectionStatus = "Not Started", FollowUpActions = "Install exits", InspectionCost = 0m, PunchListStatus = "Not Started", DocumentReference = "DOC-WH-FIRE-TSK", MaterialUsed = "Extinguishers", MaterialCost = 1500m, MaterialStockRemaining = "15 units" },
                                new ProjectTask { ActivityName = "Structural Audit Task", LevelId = "L3-054", StartDate = new DateTime(2025, 12, 6), EndDate = new DateTime(2025, 12, 10), Supervisor = "David Lin", Team = "Audit Engineers", Status = "Scheduled", Progress = 20, TotalBudget = 10000m, PaidToDate = 0m, Currency = "USD", CostCode = "04-02-03", PermitStatus = "Scheduled", InspectionDate = new DateTime(2025, 12, 11), InspectionStatus = "Not Started", FollowUpActions = "Verify integrity", InspectionCost = 0m, PunchListStatus = "Not Started", DocumentReference = "DOC-WH-AUD-TSK", MaterialUsed = "Inspection Tools", MaterialCost = 1500m, MaterialStockRemaining = "N/A" }
                            }
                        }
                    }
                }
            };
        }
    }
}