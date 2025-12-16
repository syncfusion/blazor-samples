#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.GanttChart.Data
{
    public class ProjectManagementModel
    {
        public class TaskModel
        {
            public int Id { get; set; }
            public string? TaskName { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int Duration { get; set; }
            public int Progress { get; set; }
            public int? ParentId { get; set; }
            public string? Predecessor { get; set; } = string.Empty;
            public string? Description { get; set; }
            public string? OwnerEmail { get; set; }
            public string? TaskCode { get; set; }
            public int TeamSize { get; set; }
            public string? Tags { get; set; }
            public string? ContactPhone { get; set; }
            public decimal? Budget { get; set; }
            public decimal? ActualCost { get; set; }
            public string? Status { get; set; }
            public string? Priority { get; set; }
        }

        public static List<TaskModel> GetProjectManagementData()
        {
            List<TaskModel> Tasks = new List<TaskModel>()
            {
                new TaskModel { Id = 1, TaskName = "Website redesign – project plan", StartDate = new DateTime(2025, 1, 6), EndDate = new DateTime(2025, 3, 7), Duration = 45, Progress = 28, ParentId = null, Predecessor = null, Description = "Overall project coordination and delivery.", OwnerEmail = "pm.alex@acme.com", TaskCode = "PRJ-MST-001", TeamSize = 8, Tags = "#project,#web", ContactPhone = "+15553000000", Budget = 45000m, ActualCost = 9200m, Status = "In Progress", Priority = "Low" },
                new TaskModel { Id = 2, TaskName = "Initiation phase", StartDate = new DateTime(2025, 1, 6), EndDate = new DateTime(2025, 1, 8), Duration = 3, Progress = 100, ParentId = 1, Predecessor = null, Description = "Initial setup and alignment.", OwnerEmail = "pm.alex@acme.com", TaskCode = "PRJ-INI-000", TeamSize = 5, Tags = "#initiation", ContactPhone = "+15553000100", Budget = 800m, ActualCost = 760m, Status = "Completed", Priority = "Low" },
                new TaskModel { Id = 3, TaskName = "Project initiation meeting", StartDate = new DateTime(2025, 1, 6), EndDate = new DateTime(2025, 1, 6), Duration = 1, Progress = 100, ParentId = 2, Predecessor = null, Description = "Initial meeting with stakeholders and team.", OwnerEmail = "pm.alex@acme.com", TaskCode = "PRJ-INI-002", TeamSize = 5, Tags = "#meeting", ContactPhone = "+15553000101", Budget = 300m, ActualCost = 290m, Status = "Completed", Priority = "Low" },
                new TaskModel { Id = 4, TaskName = "Stakeholder alignment", StartDate = new DateTime(2025, 1, 7), EndDate = new DateTime(2025, 1, 8), Duration = 2, Progress = 100, ParentId = 2, Predecessor = "3FS", Description = "Agree on scope, success metrics, and governance.", OwnerEmail = "pm.alex@acme.com", TaskCode = "PRJ-INI-003", TeamSize = 4, Tags = "#stakeholders", ContactPhone = "+15553000102", Budget = 500m, ActualCost = 480m, Status = "Completed", Priority = "Low" },
                new TaskModel { Id = 5, TaskName = "Planning phase", StartDate = new DateTime(2025, 1, 9), EndDate = new DateTime(2025, 1, 22), Duration = 10, Progress = 85, ParentId = 1, Predecessor = "4FS", Description = "Requirements, solution design, and test planning.", OwnerEmail = "pm.alex@acme.com", TaskCode = "PRJ-PLN-000", TeamSize = 6, Tags = "#planning", ContactPhone = "+15553000103", Budget = 5000m, ActualCost = 4200m, Status = "In Progress", Priority = "Low" },
                new TaskModel { Id = 6, TaskName = "Requirements gathering", StartDate = new DateTime(2025, 1, 9), EndDate = new DateTime(2025, 1, 14), Duration = 5, Progress = 100, ParentId = 5, Predecessor = "4FS", Description = "Workshops and interviews to capture requirements.", OwnerEmail = "ba.nina@acme.com", TaskCode = "PRJ-REQ-003", TeamSize = 3, Tags = "#requirements,#ba", ContactPhone = "+15553000104", Budget = 3000m, ActualCost = 2950m, Status = "Completed", Priority = "Low" },
                new TaskModel { Id = 7, TaskName = "Solution design", StartDate = new DateTime(2025, 1, 15), EndDate = new DateTime(2025, 1, 20), Duration = 6, Progress = 70, ParentId = 5, Predecessor = "6FS", Description = "Information architecture, UI, and technical design.", OwnerEmail = "arch.sam@acme.com", TaskCode = "PRJ-DSN-004", TeamSize = 4, Tags = "#design,#architecture", ContactPhone = "+15553000105", Budget = 7000m, ActualCost = 4300m, Status = "In Progress", Priority = "Low" },
                new TaskModel { Id = 8, TaskName = "Test planning", StartDate = new DateTime(2025, 1, 21), EndDate = new DateTime(2025, 1, 22), Duration = 2, Progress = 0, ParentId = 5, Predecessor = "7FS", Description = "Define test strategy, scenarios, and data.", OwnerEmail = "qa.lead@acme.com", TaskCode = "PRJ-QA-008", TeamSize = 2, Tags = "#qa,#testplan", ContactPhone = "+15553000106", Budget = 1500m, ActualCost = 0m, Status = "Not Started", Priority = "Medium" },
                new TaskModel { Id = 9, TaskName = "Development phase", StartDate = new DateTime(2025, 1, 23), EndDate = new DateTime(2025, 2, 21), Duration = 22, Progress = 0, ParentId = 1, Predecessor = "7FS,8FS", Description = "Frontend, backend, contracts, and integration.", OwnerEmail = "dev.lead@acme.com", TaskCode = "PRJ-DEV-000", TeamSize = 7, Tags = "#development", ContactPhone = "+15553000107", Budget = 28000m, ActualCost = 0m, Status = "Not Started", Priority = "Medium" },
                new TaskModel { Id = 10, TaskName = "Frontend development", StartDate = new DateTime(2025, 1, 23), EndDate = new DateTime(2025, 2, 7), Duration = 12, Progress = 0, ParentId = 9, Predecessor = "7FS", Description = "Implement UI components and responsive layouts.", OwnerEmail = "dev.ui@acme.com", TaskCode = "PRJ-FE-005", TeamSize = 3, Tags = "#frontend,#ui", ContactPhone = "+15553000108", Budget = 12000m, ActualCost = 0m, Status = "Not Started", Priority = "Medium" },
                new TaskModel { Id = 11, TaskName = "Backend development", StartDate = new DateTime(2025, 1, 23), EndDate = new DateTime(2025, 2, 14), Duration = 16, Progress = 0, ParentId = 9, Predecessor = "7FS", Description = "API endpoints, business logic, and data access.", OwnerEmail = "dev.api@acme.com", TaskCode = "PRJ-BE-006", TeamSize = 3, Tags = "#backend,#api", ContactPhone = "+15553000109", Budget = 15000m, ActualCost = 0m, Status = "Not Started", Priority = "Medium" },
                new TaskModel { Id = 12, TaskName = "API contract finalization", StartDate = new DateTime(2025, 1, 21), EndDate = new DateTime(2025, 1, 22), Duration = 2, Progress = 0, ParentId = 9, Predecessor = "7FS", Description = "Finalize API schemas and versioning.", OwnerEmail = "dev.api@acme.com", TaskCode = "PRJ-API-007", TeamSize = 2, Tags = "#api,#contract", ContactPhone = "+15553000110", Budget = 1000m, ActualCost = 0m, Status = "Not Started", Priority = "Medium" },
                new TaskModel { Id = 13, TaskName = "Integration", StartDate = new DateTime(2025, 2, 10), EndDate = new DateTime(2025, 2, 14), Duration = 5, Progress = 0, ParentId = 9, Predecessor = "10FS,11FS,12FS", Description = "Integrate frontend with backend services.", OwnerEmail = "dev.int@acme.com", TaskCode = "PRJ-INT-008", TeamSize = 3, Tags = "#integration", ContactPhone = "+15553000111", Budget = 4000m, ActualCost = 0m, Status = "Not Started", Priority = "High" },
                new TaskModel { Id = 14, TaskName = "Quality assurance phase", StartDate = new DateTime(2025, 2, 17), EndDate = new DateTime(2025, 2, 28), Duration = 10, Progress = 0, ParentId = 1, Predecessor = "13FS", Description = "System testing, security review, and performance testing.", OwnerEmail = "qa.lead@acme.com", TaskCode = "PRJ-QA-000", TeamSize = 4, Tags = "#quality", ContactPhone = "+15553000112", Budget = 8000m, ActualCost = 0m, Status = "Not Started", Priority = "High" },
                new TaskModel { Id = 15, TaskName = "System testing", StartDate = new DateTime(2025, 2, 17), EndDate = new DateTime(2025, 2, 21), Duration = 5, Progress = 0, ParentId = 14, Predecessor = "13FS,8FS", Description = "Functional, integration, and regression testing.", OwnerEmail = "qa.team@acme.com", TaskCode = "PRJ-QA-009", TeamSize = 3, Tags = "#qa,#systemtest", ContactPhone = "+15553000113", Budget = 3500m, ActualCost = 0m, Status = "Not Started", Priority = "High" },
                new TaskModel { Id = 16, TaskName = "Security review", StartDate = new DateTime(2025, 2, 17), EndDate = new DateTime(2025, 2, 19), Duration = 3, Progress = 0, ParentId = 14, Predecessor = "13FS", Description = "Threat modeling and vulnerability assessment.", OwnerEmail = "sec.lead@acme.com", TaskCode = "PRJ-SEC-010", TeamSize = 3, Tags = "#security", ContactPhone = "+15553000114", Budget = 2500m, ActualCost = 0m, Status = "Not Started", Priority = "High" },
                new TaskModel { Id = 17, TaskName = "Performance testing", StartDate = new DateTime(2025, 2, 20), EndDate = new DateTime(2025, 2, 26), Duration = 5, Progress = 0, ParentId = 14, Predecessor = "13FS", Description = "Load, stress, and scalability testing.", OwnerEmail = "qa.perf@acme.com", TaskCode = "PRJ-PERF-011", TeamSize = 3, Tags = "#performance", ContactPhone = "+15553000115", Budget = 3000m, ActualCost = 0m, Status = "Not Started", Priority = "High" },
                new TaskModel { Id = 18, TaskName = "Readiness & release", StartDate = new DateTime(2025, 3, 3), EndDate = new DateTime(2025, 3, 10), Duration = 6, Progress = 0, ParentId = 1, Predecessor = "15FS,16FS,17FS", Description = "Docs, training, deployment, and stabilization.", OwnerEmail = "release.mgr@acme.com", TaskCode = "PRJ-REL-000", TeamSize = 4, Tags = "#release", ContactPhone = "+15553000116", Budget = 7000m, ActualCost = 0m, Status = "Not Started", Priority = "Critical" },
                new TaskModel { Id = 19, TaskName = "Documentation", StartDate = new DateTime(2025, 2, 17), EndDate = new DateTime(2025, 2, 21), Duration = 5, Progress = 0, ParentId = 18, Predecessor = "13FS", Description = "User guides, admin runbooks, and release notes.", OwnerEmail = "tech.writer@acme.com", TaskCode = "PRJ-DOC-012", TeamSize = 3, Tags = "#docs", ContactPhone = "+15553000117", Budget = 2000m, ActualCost = 0m, Status = "Not Started", Priority = "High" },
                new TaskModel { Id = 20, TaskName = "Training & handover", StartDate = new DateTime(2025, 2, 24), EndDate = new DateTime(2025, 2, 26), Duration = 3, Progress = 0, ParentId = 18, Predecessor = "19FS", Description = "Train support team and hand over materials.", OwnerEmail = "trainer@acme.com", TaskCode = "PRJ-TRN-013", TeamSize = 3, Tags = "#training", ContactPhone = "+15553000118", Budget = 1800m, ActualCost = 0m, Status = "Not Started", Priority = "High" },
                new TaskModel { Id = 21, TaskName = "Deployment preparation", StartDate = new DateTime(2025, 3, 3), EndDate = new DateTime(2025, 3, 5), Duration = 3, Progress = 0, ParentId = 18, Predecessor = "15FS,16FS,17FS,20FS", Description = "Release notes, rollback plan, approvals, and schedule.", OwnerEmail = "release.mgr@acme.com", TaskCode = "PRJ-REL-014", TeamSize = 4, Tags = "#deployment", ContactPhone = "+15553000119", Budget = 1200m, ActualCost = 0m, Status = "Not Started", Priority = "Critical" },
                new TaskModel { Id = 22, TaskName = "Production release", StartDate = new DateTime(2025, 3, 6), EndDate = new DateTime(2025, 3, 7), Duration = 2, Progress = 0, ParentId = 18, Predecessor = "21FS", Description = "Go-live and immediate post-release checks.", OwnerEmail = "release.mgr@acme.com", TaskCode = "PRJ-REL-015", TeamSize = 4, Tags = "#golive", ContactPhone = "+15553000120", Budget = 800m, ActualCost = 0m, Status = "Not Started", Priority = "Critical" },
                new TaskModel { Id = 23, TaskName = "Hypercare", StartDate = new DateTime(2025, 3, 8), EndDate = new DateTime(2025, 3, 10), Duration = 3, Progress = 0, ParentId = 18, Predecessor = "22FS", Description = "Stabilization, monitoring, and rapid fixes.", OwnerEmail = "support.lead@acme.com", TaskCode = "PRJ-SPT-016", TeamSize = 4, Tags = "#support,#hypercare", ContactPhone = "+15553000121", Budget = 2000m, ActualCost = 0m, Status = "Not Started", Priority = "Critical" },
                new TaskModel { Id = 24, TaskName = "Project retrospective", StartDate = new DateTime(2025, 3, 10), EndDate = new DateTime(2025, 3, 10), Duration = 1, Progress = 0, ParentId = 18, Predecessor = "23FS", Description = "Lessons learned and continuous improvement actions.", OwnerEmail = "pm.alex@acme.com", TaskCode = "PRJ-RET-017", TeamSize = 5, Tags = "#retrospective", ContactPhone = "+15553000122", Budget = 500m, ActualCost = 0m, Status = "Not Started", Priority = "Critical"}
            };
            return Tasks;
        }
    }
}