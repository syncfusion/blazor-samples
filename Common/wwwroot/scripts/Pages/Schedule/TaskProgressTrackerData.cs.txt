using System;
using System.Collections.Generic;

namespace taskprogresstracker.Data
{
    public class TaskProgressTrackerData
    {
        public int Id { get; set; }
        public string? Subject { get; set; }
        public string Location { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool IsAllDay { get; set; }
        public string? RecurrenceRule { get; set; }
        public string? RecurrenceException { get; set; }
        public int? RecurrenceID { get; set; }
        public int EmployeeId { get; set; }
        public string StatusType { get; set; } = "pending";
        public string? EmployeeName { get; set; }
        public int? Progress { get; set; }
        public static IReadOnlyCollection<TaskProgressTrackerData> GetTaskData()
        {
            List<TaskProgressTrackerData> taskData = new List<TaskProgressTrackerData>() 
            {
                new TaskProgressTrackerData {
                  Id=1,
                  Subject="Frontend Architecture Design",
                  StartTime=new DateTime(2026, 4, 21, 9, 00, 0),
                  EndTime=new DateTime(2026, 4, 21, 10, 30, 0),
                  Description="Design React component architecture",
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "done",
                  Progress= 100,
                }
                ,
                new TaskProgressTrackerData {
                  Id= 2,
                  Subject= "UI Component Development",
                  StartTime= new DateTime(2026, 4, 21, 11, 00, 0),
                  EndTime= new DateTime(2026, 4, 21, 13, 00, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Build reusable UI component library"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 3,
                  Subject= "API Gateway Configuration",
                  StartTime= new DateTime(2026, 4, 21, 9, 30, 0),
                  EndTime= new DateTime(2026, 4, 21, 11, 00, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Setup API gateway with authentication"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 4,
                  Subject= "Database Migration",
                  StartTime= new DateTime(2026, 4, 21, 11, 30, 0),
                  EndTime= new DateTime(2026, 4, 21, 13, 00, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Execute production database migration"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 5,
                  Subject= "Component Testing Suite",
                  StartTime= new DateTime(2026, 4, 21, 9, 00, 0),
                  EndTime= new DateTime(2026, 4, 21, 11, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Write unit tests for all components"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 6,
                  Subject= "E2E Integration Testing",
                  StartTime= new DateTime(2026, 4, 21, 12, 00, 0),
                  EndTime= new DateTime(2026, 4, 21, 13, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "review",
                  Progress= 99,
                  Description= "End-to-end test automation setup"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 7,
                  Subject= "Performance Optimization",
                  StartTime= new DateTime(2026, 4, 21, 9, 30, 0),
                  EndTime= new DateTime(2026, 4, 21, 12, 00, 0),
                  EmployeeId= 4,
                  EmployeeName= "Michael",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Optimize bundle size and loading"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 8,
                  Subject= "Documentation & Deployment",
                  StartTime= new DateTime(2026, 4, 21, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 21, 16, 00, 0),
                  EmployeeId= 4,
                  EmployeeName= "Michael",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Complete documentation and CI/CD setup"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 9,
                  Subject= "Security Audit & Review",
                  StartTime= new DateTime(2026, 4, 21, 9, 00, 0),
                  EndTime= new DateTime(2026, 4, 21, 11, 30, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "done",
                  Progress= 100,
                  Description= "OWASP security compliance review"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 10,
                  Subject= "Accessibility Compliance Check",
                  StartTime= new DateTime(2026, 4, 21, 12, 00, 0),
                  EndTime= new DateTime(2026, 4, 21, 13, 00, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "review",
                  Progress= 99,
                  Description= "WCAG 2.1 AA compliance verification"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 11,
                  Subject= "Sprint Planning & Coordination",
                  StartTime= new DateTime(2026, 4, 21, 10, 00, 0),
                  EndTime= new DateTime(2026, 4, 21, 11, 30, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Sprint planning and backlog refinement"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 12,
                  Subject= "Release Management & QA",
                  StartTime= new DateTime(2026, 4, 21, 12, 00, 0),
                  EndTime= new DateTime(2026, 4, 21, 13, 00, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Final QA and release coordination"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 13,
                  Subject= "Code Review & Testing",
                  StartTime= new DateTime(2026, 4, 21, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 21, 15, 30, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Peer code review and testing"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 14,
                  Subject= "Performance Monitoring",
                  StartTime= new DateTime(2026, 4, 21, 14, 30, 0),
                  EndTime= new DateTime(2026, 4, 21, 16, 00, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Setup monitoring and alerts"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 15,
                  Subject= "Test Documentation",
                  StartTime= new DateTime(2026, 4, 21, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 21, 16, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Document test cases and scenarios"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 16,
                  Subject= "Compliance Report",
                  StartTime= new DateTime(2026, 4, 21, 14, 30, 0),
                  EndTime= new DateTime(2026, 4, 21, 16, 00, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Generate compliance documentation"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 17,
                  Subject= "Team Sync & Standup",
                  StartTime= new DateTime(2026, 4, 21, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 21, 15, 00, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Daily standup and team sync"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 18,
                  Subject= "User Experience Testing",
                  StartTime= new DateTime(2026, 4, 21, 16, 00, 0),
                  EndTime= new DateTime(2026, 4, 21, 18, 00, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "review",
                  Progress= 99,
                  Description= "User acceptance testing phase"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 19,
                  Subject= "Production Deployment Review",
                  StartTime= new DateTime(2026, 4, 21, 16, 00, 0),
                  EndTime= new DateTime(2026, 4, 21, 17, 30, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Final production deployment review"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 20,
                  Subject= "Performance Analysis & Reporting",
                  StartTime= new DateTime(2026, 4, 21, 16, 30, 0),
                  EndTime= new DateTime(2026, 4, 21, 18, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Analyze performance metrics and generate reports"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 21,
                  Subject= "System Integration Testing",
                  StartTime= new DateTime(2026, 4, 21, 16, 30, 0),
                  EndTime= new DateTime(2026, 4, 21, 17, 30, 0),
                  EmployeeId= 4,
                  EmployeeName= "Michael",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Comprehensive system integration testing"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 22,
                  Subject= "Final Security Sign-off",
                  StartTime= new DateTime(2026, 4, 21, 17, 00, 0),
                  EndTime= new DateTime(2026, 4, 21, 18, 00, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Final security approval and sign-off"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 23,
                  Subject= "Release Deployment & Handoff",
                  StartTime= new DateTime(2026, 4, 21, 15, 00, 0),
                  EndTime= new DateTime(2026, 4, 21, 16, 30, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Production release deployment and team handoff"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 24,
                  Subject= "Post-Deployment Monitoring",
                  StartTime= new DateTime(2026, 4, 21, 17, 00, 0),
                  EndTime= new DateTime(2026, 4, 21, 18, 00, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Monitor system post-deployment"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 25,
                  Subject= "Project Scope Finalization",
                  StartTime= new DateTime(2026, 4, 20, 9, 00, 0),
                  EndTime= new DateTime(2026, 4, 20, 10, 30, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Finalize project scope and objectives"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 26,
                  Subject= "UI Design Sign-off",
                  StartTime= new DateTime(2026, 4, 20, 11, 00, 0),
                  EndTime= new DateTime(2026, 4, 20, 13, 00, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Approve final UI designs"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 27,
                  Subject= "UX Review Session",
                  StartTime= new DateTime(2026, 4, 20, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 20, 15, 30, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Review UX flow and interactions"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 28,
                  Subject= "Service Endpoint Finalization",
                  StartTime= new DateTime(2026, 4, 20, 9, 30, 0),
                  EndTime= new DateTime(2026, 4, 20, 11, 00, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Finalize backend service endpoints"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 29,
                  Subject= "Database Constraint Validation",
                  StartTime= new DateTime(2026, 4, 20, 11, 30, 0),
                  EndTime= new DateTime(2026, 4, 20, 13, 00, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Validate database constraints"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 30,
                  Subject= "Infrastructure Checklist Review",
                  StartTime= new DateTime(2026, 4, 20, 14, 30, 0),
                  EndTime= new DateTime(2026, 4, 20, 15, 30, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Review infrastructure readiness checklist"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 31,
                  Subject= "Unit Test Completion",
                  StartTime= new DateTime(2026, 4, 20, 9, 00, 0),
                  EndTime= new DateTime(2026, 4, 20, 11, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Complete unit test implementation"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 32,
                  Subject= "Automation Report Review",
                  StartTime= new DateTime(2026, 4, 20, 12, 00, 0),
                  EndTime= new DateTime(2026, 4, 20, 13, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Review automation execution report"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 33,
                  Subject= "Regression Planning",
                  StartTime= new DateTime(2026, 4, 20, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 20, 15, 30, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "pending",
                  Progress= 67,
                  Description= "Plan regression testing cycle"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 34,
                  Subject= "Build Optimization Completion",
                  StartTime= new DateTime(2026, 4, 20, 9, 30, 0),
                  EndTime= new DateTime(2026, 4, 20, 12, 00, 0),
                  EmployeeId= 4,
                  EmployeeName= "Michael",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Complete build optimization tasks"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 35,
                  Subject= "Deployment Script Validation",
                  StartTime= new DateTime(2026, 4, 20, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 20, 16, 00, 0),
                  EmployeeId= 4,
                  EmployeeName= "Michael",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Validate deployment scripts"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 36,
                  Subject= "Security Controls Verification",
                  StartTime= new DateTime(2026, 4, 20, 9, 00, 0),
                  EndTime= new DateTime(2026, 4, 20, 11, 30, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Verify implemented security controls"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 37,
                  Subject= "Compliance Evidence Submission",
                  StartTime= new DateTime(2026, 4, 20, 12, 00, 0),
                  EndTime= new DateTime(2026, 4, 20, 13, 00, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Submit compliance evidence"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 38,
                  Subject= "Audit Observation Review",
                  StartTime= new DateTime(2026, 4, 20, 14, 30, 0),
                  EndTime= new DateTime(2026, 4, 20, 15, 30, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Review audit observations"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 39,
                  Subject= "Sprint Closure Meeting",
                  StartTime= new DateTime(2026, 4, 20, 10, 0, 0),
                  EndTime= new DateTime(2026, 4, 20, 11, 30, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Conduct sprint closure meeting"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 40,
                  Subject= "Release Checklist Completion",
                  StartTime= new DateTime(2026, 4, 20, 12, 00, 0),
                  EndTime= new DateTime(2026, 4, 20, 13, 00, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Complete release checklist"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 41,
                  Subject= "Team Sync Preparation",
                  StartTime= new DateTime(2026, 4, 20, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 20, 15, 00, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "pending",
                  Progress= 12,
                  Description= "Prepare agenda for team sync"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 42,
                  Subject= "UAT Sign-off",
                  StartTime= new DateTime(2026, 4, 20, 16, 00, 0),
                  EndTime= new DateTime(2026, 4, 20, 18, 00, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "done",
                  Progress= 100,
                  Description= "User acceptance testing sign-off"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 43,
                  Subject= "Production Review",
                  StartTime= new DateTime(2026, 4, 20, 16, 00, 0),
                  EndTime= new DateTime(2026, 4, 20, 17, 30, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Production readiness review"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 44,
                  Subject= "Performance Validation",
                  StartTime= new DateTime(2026, 4, 20, 16, 30, 0),
                  EndTime= new DateTime(2026, 4, 20, 18, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Validate performance metrics"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 45,
                  Subject= "System Integration Approval",
                  StartTime= new DateTime(2026, 4, 20, 16, 00, 0),
                  EndTime= new DateTime(2026, 4, 20, 18, 00, 0),
                  EmployeeId= 4,
                  EmployeeName= "Michael",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Approve system integration"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 46,
                  Subject= "Final Security Clearance",
                  StartTime= new DateTime(2026, 4, 20, 17, 00, 0),
                  EndTime= new DateTime(2026, 4, 20, 18, 00, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Provide final security clearance"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 47,
                  Subject= "Release Execution",
                  StartTime= new DateTime(2026, 4, 20, 15, 00, 0),
                  EndTime= new DateTime(2026, 4, 20, 16, 30, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Execute production release"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 48,
                  Subject= "Post-release Monitoring Setup",
                  StartTime= new DateTime(2026, 4, 20, 17, 00, 0),
                  EndTime= new DateTime(2026, 4, 20, 18, 00, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Setup post-release monitoring"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 49,
                  Subject= "Feature Requirement Freeze",
                  StartTime= new DateTime(2026, 4, 22, 9, 00, 0),
                  EndTime= new DateTime(2026, 4, 22, 10, 30, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Freeze feature requirements for release"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 50,
                  Subject= "UI Consistency Verification",
                  StartTime= new DateTime(2026, 4, 22, 11, 00, 0),
                  EndTime= new DateTime(2026, 4, 22, 13, 00, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Verify UI consistency across modules"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 51,
                  Subject= "Design Review Validation",
                  StartTime= new DateTime(2026, 4, 22, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 22, 15, 30, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Validate final design changes"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 52,
                  Subject= "Service Health Check",
                  StartTime= new DateTime(2026, 4, 22, 9, 30, 0),
                  EndTime= new DateTime(2026, 4, 22, 11, 00, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Run backend service health checks"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 53,
                  Subject= "Data Integrity Confirmation",
                  StartTime= new DateTime(2026, 4, 22, 11, 30, 0),
                  EndTime= new DateTime(2026, 4, 22, 13, 00, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Confirm migrated data integrity"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 54,
                  Subject= "Metrics Review",
                  StartTime= new DateTime(2026, 4, 22, 14, 30, 0),
                  EndTime= new DateTime(2026, 4, 22, 16, 00, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Review collected performance metrics"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 55,
                  Subject= "Test Execution Closure",
                  StartTime= new DateTime(2026, 4, 22, 9, 00, 0),
                  EndTime= new DateTime(2026, 4, 22, 11, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Close remaining test executions"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 56,
                  Subject= "Automation Result Review",
                  StartTime= new DateTime(2026, 4, 22, 12, 00, 0),
                  EndTime= new DateTime(2026, 4, 22, 13, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Review automation test results"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 57,
                  Subject= "Test Report Finalization",
                  StartTime= new DateTime(2026, 4, 22, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 22, 16, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Finalize overall test report"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 58,
                  Subject= "Build Artifact Validation",
                  StartTime= new DateTime(2026, 4, 22, 9, 30, 0),
                  EndTime= new DateTime(2026, 4, 22, 12, 00, 0),
                  EmployeeId= 4,
                  EmployeeName= "Michael",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Validate generated build artifacts"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 59,
                  Subject= "Deployment Dry Run",
                  StartTime= new DateTime(2026, 4, 22, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 22, 16, 00, 0),
                  EmployeeId= 4,
                  EmployeeName= "Michael",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Perform deployment dry run"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 60,
                  Subject= "Security Control Confirmation",
                  StartTime= new DateTime(2026, 4, 22, 9, 00, 0),
                  EndTime= new DateTime(2026, 4, 22, 11, 30, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Confirm applied security controls"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 61,
                  Subject= "Compliance Evidence Review",
                  StartTime= new DateTime(2026, 4, 22, 12, 00, 0),
                  EndTime= new DateTime(2026, 4, 22, 13, 00, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Review submitted compliance evidence"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 62,
                  Subject= "Audit Closure Documentation",
                  StartTime= new DateTime(2026, 4, 22, 14, 30, 0),
                  EndTime= new DateTime(2026, 4, 22, 16, 00, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Prepare audit closure documents"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 63,
                  Subject= "Sprint Metrics Review",
                  StartTime= new DateTime(2026, 4, 22, 10, 00, 0),
                  EndTime= new DateTime(2026, 4, 22, 11, 30, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Review sprint performance metrics"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 64,
                  Subject= "Release Checklist Validation",
                  StartTime= new DateTime(2026, 4, 22, 12, 00, 0),
                  EndTime= new DateTime(2026, 4, 22, 13, 00, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Validate release readiness checklist"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 65,
                  Subject= "Team Sync Review",
                  StartTime= new DateTime(2026, 4, 22, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 22, 15, 00, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Review team sync outcomes"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 66,
                  Subject= "UAT Result Verification",
                  StartTime= new DateTime(2026, 4, 22, 16, 00, 0),
                  EndTime= new DateTime(2026, 4, 22, 18, 00, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Verify UAT results"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 67,
                  Subject= "Production Approval",
                  StartTime= new DateTime(2026, 4, 22, 16, 00, 0),
                  EndTime= new DateTime(2026, 4, 22, 17, 30, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Approve production deployment"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 68,
                  Subject= "Performance Summary Report",
                  StartTime= new DateTime(2026, 4, 22, 16, 30, 0),
                  EndTime= new DateTime(2026, 4, 22, 18, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Prepare performance summary report"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 69,
                  Subject= "Integration Sign-off",
                  StartTime= new DateTime(2026, 4, 22, 16, 30, 0),
                  EndTime= new DateTime(2026, 4, 22, 17, 30, 0),
                  EmployeeId= 4,
                  EmployeeName= "Michael",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Provide integration sign-off"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 70,
                  Subject= "Security Closure Approval",
                  StartTime= new DateTime(2026, 4, 22, 17, 00, 0),
                  EndTime= new DateTime(2026, 4, 22, 18, 00, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Approve security closure"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 71,
                  Subject= "Release Execution Review",
                  StartTime= new DateTime(2026, 4, 22, 15, 00, 0),
                  EndTime= new DateTime(2026, 4, 22, 16, 30, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Review release execution"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 72,
                  Subject= "Post-release Health Check",
                  StartTime= new DateTime(2026, 4, 22, 16, 30, 0),
                  EndTime= new DateTime(2026, 4, 22, 18, 00, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Perform post-release system health check"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 73,
                  Subject= "Architecture Validation Session",
                  StartTime= new DateTime(2026, 4, 23, 9, 00, 0),
                  EndTime= new DateTime(2026, 4, 23, 10, 30, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Validate overall system architecture"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 74,
                  Subject= "UI Regression Assessment",
                  StartTime= new DateTime(2026, 4, 23, 11, 00, 0),
                  EndTime= new DateTime(2026, 4, 23, 13, 00, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Assess UI regressions after fixes"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 75,
                  Subject= "UX Feedback Consolidation",
                  StartTime= new DateTime(2026, 4, 23, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 23, 15, 30, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "pending",
                  Progress= 22,
                  Description= "Consolidate UX feedback items"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 76,
                  Subject= "Gateway Performance Review",
                  StartTime= new DateTime(2026, 4, 23, 9, 30, 0),
                  EndTime= new DateTime(2026, 4, 23, 11, 00, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Review API gateway performance metrics"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 77,
                  Subject= "Data Consistency Audit",
                  StartTime= new DateTime(2026, 4, 23, 11, 30, 0),
                  EndTime= new DateTime(2026, 4, 23, 13, 00, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Audit data consistency across services"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 78,
                  Subject= "Alert Threshold Planning",
                  StartTime= new DateTime(2026, 4, 23, 14, 30, 0),
                  EndTime= new DateTime(2026, 4, 23, 16, 00, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "pending",
                  Progress= 0,
                  Description= "Plan alert threshold values"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 79,
                  Subject= "Test Result Review",
                  StartTime= new DateTime(2026, 4, 23, 9, 00, 0),
                  EndTime= new DateTime(2026, 4, 23, 11, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Review executed test results"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 80,
                  Subject= "Automation Gap Analysis",
                  StartTime= new DateTime(2026, 4, 23, 12, 00, 0),
                  EndTime= new DateTime(2026, 4, 23, 13, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Analyze gaps in test automation"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 81,
                  Subject= "Test Scenario Backlog",
                  StartTime= new DateTime(2026, 4, 23, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 23, 16, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "pending",
                  Progress= 35,
                  Description= "Prepare backlog of missing scenarios"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 82,
                  Subject= "Build Stability Verification",
                  StartTime= new DateTime(2026, 4, 23, 9, 30, 0),
                  EndTime= new DateTime(2026, 4, 23, 12, 00, 0),
                  EmployeeId= 4,
                  EmployeeName= "Michael",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Verify build stability"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 83,
                  Subject= "Deployment Risk Assessment",
                  StartTime= new DateTime(2026, 4, 23, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 23, 16, 00, 0),
                  EmployeeId= 4,
                  EmployeeName= "Michael",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Assess deployment risks"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 84,
                  Subject= "Security Finding Review",
                  StartTime= new DateTime(2026, 4, 23, 9, 00, 0),
                  EndTime= new DateTime(2026, 4, 23, 11, 30, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Review identified security findings"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 85,
                  Subject= "Compliance Gap Analysis",
                  StartTime= new DateTime(2026, 4, 23, 12, 00, 0),
                  EndTime= new DateTime(2026, 4, 23, 13, 00, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Analyze compliance gaps"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 86,
                  Subject= "Policy Update Draft",
                  StartTime= new DateTime(2026, 4, 23, 14, 30, 0),
                  EndTime= new DateTime(2026, 4, 23, 16, 00, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "pending",
                  Progress= 10,
                  Description= "Draft security policy updates"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 87,
                  Subject= "Sprint Review Meeting",
                  StartTime= new DateTime(2026, 4, 23, 10, 00, 0),
                  EndTime= new DateTime(2026, 4, 23, 11, 30, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Conduct sprint review meeting"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 88,
                  Subject= "Release Risk Evaluation",
                  StartTime= new DateTime(2026, 4, 23, 12, 00, 0),
                  EndTime= new DateTime(2026, 4, 23, 13, 00, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Evaluate release risks"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 89,
                  Subject= "Standup Action Items",
                  StartTime= new DateTime(2026, 4, 23, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 23, 15, 00, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "pending",
                  Progress= 0,
                  Description= "Track standup action items"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 90,
                  Subject= "UAT Defect Verification",
                  StartTime= new DateTime(2026, 4, 23, 16, 00, 0),
                  EndTime= new DateTime(2026, 4, 23, 18, 00, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Verify UAT reported defects"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 91,
                  Subject= "Production Rollback Readiness",
                  StartTime= new DateTime(2026, 4, 23, 16, 00, 0),
                  EndTime= new DateTime(2026, 4, 23, 17, 30, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Ensure rollback readiness"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 92,
                  Subject= "Performance Anomaly Review",
                  StartTime= new DateTime(2026, 4, 23, 16, 30, 0),
                  EndTime= new DateTime(2026, 4, 23, 18, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Review performance anomalies"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 93,
                  Subject= "Integration Approval Review",
                  StartTime= new DateTime(2026, 4, 23, 16, 30, 0),
                  EndTime= new DateTime(2026, 4, 23, 17, 30, 0),
                  EmployeeId= 4,
                  EmployeeName= "Michael",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Review integration approval status"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 94,
                  Subject= "Security Exception Closure",
                  StartTime= new DateTime(2026, 4, 23, 17, 00, 0),
                  EndTime= new DateTime(2026, 4, 23, 18, 00, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Close security exceptions"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 95,
                  Subject= "Release Decision Review",
                  StartTime= new DateTime(2026, 4, 23, 15, 00, 0),
                  EndTime= new DateTime(2026, 4, 23, 16, 30, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Review go/no-go release decision"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 96,
                  Subject= "Post-release Issue Tracking",
                  StartTime= new DateTime(2026, 4, 23, 16, 30, 0),
                  EndTime= new DateTime(2026, 4, 23, 18, 00, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Track post-release issues"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 97,
                  Subject= "Final Architecture Confirmation",
                  StartTime= new DateTime(2026, 4, 24, 9, 00, 0),
                  EndTime= new DateTime(2026, 4, 24, 10, 30, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "done",
                  Progress= 100,
                  Description= "Confirm final frontend architecture"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 98,
                  Subject= "UI Review Follow‑ups",
                  StartTime= new DateTime(2026, 4, 24, 11, 00, 0),
                  EndTime= new DateTime(2026, 4, 24, 13, 00, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Address UI review comments"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 99,
                  Subject= "UX Improvement Implementation",
                  StartTime= new DateTime(2026, 4, 24, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 24, 15, 30, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "in-progress",
                  Progress= 62,
                  Description= "Implement UX improvements"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 100,
                  Subject= "API Stability Validation",
                  StartTime= new DateTime(2026, 4, 24, 9, 30, 0),
                  EndTime= new DateTime(2026, 4, 24, 11, 00, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Validate API stability"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 101,
                  Subject= "Database Health Review",
                  StartTime= new DateTime(2026, 4, 24, 11, 30, 0),
                  EndTime= new DateTime(2026, 4, 24, 13, 00, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Review database health metrics"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 102,
                  Subject= "Runtime Monitoring Adjustment",
                  StartTime= new DateTime(2026, 4, 24, 14, 30, 0),
                  EndTime= new DateTime(2026, 4, 24, 16, 00, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "in-progress",
                  Progress= 55,
                  Description= "Adjust runtime monitoring thresholds"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 103,
                  Subject= "Regression Result Review",
                  StartTime= new DateTime(2026, 4, 24, 9, 00, 0),
                  EndTime= new DateTime(2026, 4, 24, 11, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Review regression test results"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 104,
                  Subject= "Automation Failure Analysis",
                  StartTime= new DateTime(2026, 4, 24, 12, 00, 0),
                  EndTime= new DateTime(2026, 4, 24, 13, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Analyze automation failures"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 105,
                  Subject= "Bug Verification Cycle",
                  StartTime= new DateTime(2026, 4, 24, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 24, 16, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "in-progress",
                  Progress= 48,
                  Description= "Verify fixed bugs"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 106,
                  Subject= "Build Consistency Check",
                  StartTime= new DateTime(2026, 4, 24, 9, 30, 0),
                  EndTime= new DateTime(2026, 4, 24, 12, 00, 0),
                  EmployeeId= 4,
                  EmployeeName= "Michael",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Check build consistency"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 107,
                  Subject= "Deployment Readiness Review",
                  StartTime= new DateTime(2026, 4, 24, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 24, 16, 00, 0),
                  EmployeeId= 4,
                  EmployeeName= "Michael",
                  StatusType= "in-progress",
                  Progress= 60,
                  Description= "Review deployment readiness"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 108,
                  Subject= "Security Verification Review",
                  StartTime= new DateTime(2026, 4, 24, 9, 00, 0),
                  EndTime= new DateTime(2026, 4, 24, 11, 30, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Review security verification results"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 109,
                  Subject= "Compliance Observation Review",
                  StartTime= new DateTime(2026, 4, 24, 12, 00, 0),
                  EndTime= new DateTime(2026, 4, 24, 13, 00, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Review compliance observations"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 110,
                  Subject= "Risk Mitigation Execution",
                  StartTime= new DateTime(2026, 4, 24, 14, 30, 0),
                  EndTime= new DateTime(2026, 4, 24, 16, 00, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "in-progress",
                  Progress= 44,
                  Description= "Execute risk mitigation steps"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 111,
                  Subject= "Sprint Outcome Review",
                  StartTime= new DateTime(2026, 4, 24, 10, 00, 0),
                  EndTime= new DateTime(2026, 4, 24, 11, 30, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Review sprint outcomes"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 112,
                  Subject= "Release Decision Discussion",
                  StartTime= new DateTime(2026, 4, 24, 12, 00, 0),
                  EndTime= new DateTime(2026, 4, 24, 13, 00, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "review",
                  Progress= 99,
                  Description= "Discuss release decision"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 113,
                  Subject= "Release Coordination",
                  StartTime= new DateTime(2026, 4, 24, 14, 00, 0),
                  EndTime= new DateTime(2026, 4, 24, 15, 00, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "in-progress",
                  Progress= 58,
                  Description= "Coordinate final release activities"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 114,
                  Subject= "UAT Follow‑up Planning",
                  StartTime= new DateTime(2026, 4, 24, 16, 00, 0),
                  EndTime= new DateTime(2026, 4, 24, 18, 00, 0),
                  EmployeeId= 1,
                  EmployeeName= "Sarah",
                  StatusType= "pending",
                  Progress= 0,
                  Description= "Plan UAT follow‑ups"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 115,
                  Subject= "Production Checklist Prep",
                  StartTime= new DateTime(2026, 4, 24, 16, 00, 0),
                  EndTime= new DateTime(2026, 4, 24, 17, 30, 0),
                  EmployeeId= 2,
                  EmployeeName= "John",
                  StatusType= "pending",
                  Progress= 0,
                  Description= "Prepare production checklist"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 116,
                  Subject= "Performance Review Notes",
                  StartTime= new DateTime(2026, 4, 24, 16, 30, 0),
                  EndTime= new DateTime(2026, 4, 24, 18, 00, 0),
                  EmployeeId= 3,
                  EmployeeName= "Emma",
                  StatusType= "pending",
                  Progress= 0,
                  Description= "Prepare performance review notes"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 117,
                  Subject= "Integration Follow‑ups",
                  StartTime= new DateTime(2026, 4, 24, 16, 30, 0),
                  EndTime= new DateTime(2026, 4, 24, 17, 30, 0),
                  EmployeeId= 4,
                  EmployeeName= "Michael",
                  StatusType= "pending",
                  Progress= 0,
                  Description= "Track integration follow‑ups"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 118,
                  Subject= "Security Closure Prep",
                  StartTime= new DateTime(2026, 4, 24, 17, 00, 0),
                  EndTime= new DateTime(2026, 4, 24, 18, 00, 0),
                  EmployeeId= 5,
                  EmployeeName= "Lisa",
                  StatusType= "pending",
                  Progress= 0,
                  Description= "Prepare security closure"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 119,
                  Subject= "Release Retrospective Planning",
                  StartTime= new DateTime(2026, 4, 24, 15, 00, 0),
                  EndTime= new DateTime(2026, 4, 24, 16, 30, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "pending",
                  Progress= 0,
                  Description= "Plan release retrospective"
                }
                ,
                new TaskProgressTrackerData {
                  Id= 120,
                  Subject= "Post‑release Monitoring Setup",
                  StartTime= new DateTime(2026, 4, 24, 17, 00, 0),
                  EndTime= new DateTime(2026, 4, 24, 18, 00, 0),
                  EmployeeId= 6,
                  EmployeeName= "David",
                  StatusType= "pending",
                  Progress= 0,
                  Description= "Setup post‑release monitoring"
                }
            };
          return taskData;
        }
    }
}
