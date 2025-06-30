#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Blazor.Notifications;
using System;
using System.Collections.Generic;

namespace Overview.Pages
{
    public class OverviewData
    {
        public class TaskData
        {
            public int Id { get; set; }
            public int? ParentId { get; set; }
            public string Task { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int Progress { get; set; }
            public string Department { get; set; }
            public string Assignee { get; set; }
            public string Priority { get; set; }
            public double? Budget { get; set; }
            public double? ActualCost { get; set; }
            public string Status { get; set; }
            public string Dependencies { get; set; }
            public string Risks { get; set; }
            public string Notes { get; set; }
            public string Category { get; set; }
            public string Location { get; set; }
            public string TechStack { get; set; }
            public int? EstimatedStoryPoints { get; set; }
            public string Initiative { get; set; }
            public string PriorityLevel { get; set; }
            public bool IsManual { get; set; }
        }

        public class ResourceInfoModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class AssignmentModel
        {
            public int Id { get; set; }
            public int TaskId { get; set; }
            public int ResourceId { get; set; }
            public double? Unit { get; set; }
        }

        public static List<ResourceInfoModel> GetResources = new List<ResourceInfoModel>()
        {
            new ResourceInfoModel() { Id= 1, Name= "Martin Tamer" ,},
            new ResourceInfoModel() { Id= 2, Name= "Rose Fuller" },
            new ResourceInfoModel() { Id= 3, Name= "Margaret Buchanan" },
            new ResourceInfoModel() { Id= 4, Name= "Fuller King" },
            new ResourceInfoModel() { Id= 5, Name= "Van Jack" },
            new ResourceInfoModel() { Id= 6, Name= "Jack Davolio" },
        };

        public static List<TaskData> DataCollection()
        {
            return new List<TaskData>
            { 
                new TaskData { Id = 1, ParentId = null, Task = "E-commerce Platform Redesign", StartDate = new DateTime(2025, 2, 1), EndDate = new DateTime(2025, 9, 30), Progress = 35, Department = "IT", Assignee = "Sarah Lee", Priority = "High", Budget = 1200000, ActualCost = 420000, Status = "On Track", Dependencies = "", Risks = "Medium", Notes = "Agile methodology, 2-week sprints", Category = "Web Development", Location = "Remote", TechStack = "React, Node.js, MongoDB, AWS", EstimatedStoryPoints = 800, Initiative = "Strategic Initiative", PriorityLevel = "Q3-Q4 Priority" },
                new TaskData { Id = 2, ParentId = 1, Task = "Project Initiation", StartDate = new DateTime(2025, 2, 1), EndDate = new DateTime(2025, 2, 15), Progress = 100, Department = "Project Management", Assignee = "John Smith", Priority = "High", Budget = 30000, ActualCost = 28500, Status = "Completed", Dependencies = "", Risks = "Low", Notes = "Kickoff meeting held", Category = "Planning", Location = "Remote", TechStack = "N/A", EstimatedStoryPoints = 13, Initiative = "Foundational", PriorityLevel = "Executive Sponsored", IsManual = true },
                new TaskData { Id = 3, ParentId = 2, Task = "Stakeholder Identification", StartDate = new DateTime(2025, 2, 1), EndDate = new DateTime(2025, 2, 7), Progress = 100, Department = "Project Management", Assignee = "John Smith", Priority = "High", Budget = 8000, ActualCost = 7800, Status = "Completed", Dependencies = "", Risks = "Low", Notes = "Identified key stakeholders across departments", Category = "Planning", Location = "Remote", TechStack = "N/A", EstimatedStoryPoints = 5, Initiative = "Internal", PriorityLevel = "Cross-functional" },
                new TaskData { Id = 4, ParentId = 2, Task = "Project Charter Creation", StartDate = new DateTime(2025, 2, 4), EndDate = new DateTime(2025, 2, 10), Progress = 100, Department = "Project Management", Assignee = "Emily Chen", Priority = "High", Budget = 15000, ActualCost = 14700, Status = "Completed", Dependencies = "3", Risks = "Low", Notes = "Project charter approved by steering committee", Category = "Documentation", Location = "Remote", TechStack = "N/A", EstimatedStoryPoints = 8, Initiative = "Governance", PriorityLevel = "Baseline Document", IsManual = true },
                new TaskData { Id = 5, ParentId = 2, Task = "Kickoff Meeting", StartDate = new DateTime(2025, 2, 11), EndDate = new DateTime(2025, 2, 18), Progress = 100, Department = "Project Management", Assignee = "John Smith", Priority = "High", Budget = 7000, ActualCost = 6000, Status = "Completed", Dependencies = "4", Risks = "Low", Notes = "All team members and key stakeholders attended", Category = "Meeting", Location = "Remote", TechStack = "N/A", EstimatedStoryPoints = 3, Initiative = "Team Building", PriorityLevel = "Alignment" },
                new TaskData { Id = 6, ParentId = 1, Task = "Requirements Gathering", StartDate = new DateTime(2025, 2, 19), EndDate = new DateTime(2025, 3, 21), Progress = 100, Department = "Business Analysis", Assignee = "Emily Chen", Priority = "High", Budget = 80000, ActualCost = 78500, Status = "Completed", Dependencies = "2", Risks = "Low", Notes = "Stakeholder interviews completed", Category = "Analysis", Location = "Remote", TechStack = "Jira, Confluence", EstimatedStoryPoints = 55, Initiative = "Business Critical", PriorityLevel = "User-Centric" },
                new TaskData { Id = 7, ParentId = 6, Task = "User Interviews", StartDate = new DateTime(2025, 2, 19), EndDate = new DateTime(2025, 2, 28), Progress = 100, Department = "Business Analysis", Assignee = "Emily Chen", Priority = "High", Budget = 30000, ActualCost = 29200, Status = "Completed", Dependencies = "", Risks = "Low", Notes = "Interviewed 20 key users across departments", Category = "Research", Location = "Remote", TechStack = "Zoom, Miro", EstimatedStoryPoints = 21, Initiative = "User Insight", PriorityLevel = "Qualitative Data" },
                new TaskData { Id = 8, ParentId = 6, Task = "Competitor Analysis", StartDate = new DateTime(2025, 2, 19), EndDate = new DateTime(2025, 2, 28), Progress = 100, Department = "Business Analysis", Assignee = "Alex Johnson", Priority = "Medium", Budget = 25000, ActualCost = 24800, Status = "Completed", Dependencies = "", Risks = "Low", Notes = "Analyzed top 5 competitors in the market", Category = "Research", Location = "Remote", TechStack = "N/A", EstimatedStoryPoints = 13, Initiative = "Market Intelligence", PriorityLevel = "Benchmarking" },
                new TaskData { Id = 9, ParentId = 6, Task = "Requirements Documentation", StartDate = new DateTime(2025, 3, 1), EndDate = new DateTime(2025, 3, 15), Progress = 100, Department = "Business Analysis", Assignee = "Emily Chen", Priority = "High", Budget = 25000, ActualCost = 24500, Status = "Completed", Dependencies = "7,8", Risks = "Low", Notes = "Created comprehensive requirements document", Category = "Documentation", Location = "Remote", TechStack = "Confluence, Jira", EstimatedStoryPoints = 21, Initiative = "Specification", PriorityLevel = "Traceability" },
                new TaskData { Id = 10, ParentId = 1, Task = "Design Phase", StartDate = new DateTime(2025, 3, 16), EndDate = new DateTime(2025, 5, 15), Progress = 90, Department = "UX/UI Design", Assignee = "Michael Wong", Priority = "High", Budget = 150000, ActualCost = 135000, Status = "In Progress", Dependencies = "6", Risks = "Medium", Notes = "Final design review scheduled for 2025-05-10", Category = "Design", Location = "Remote", TechStack = "Figma, Adobe XD", EstimatedStoryPoints = 89, Initiative = "Creative", PriorityLevel = "User Experience" },
                new TaskData { Id = 11, ParentId = 10, Task = "Information Architecture", StartDate = new DateTime(2025, 3, 16), EndDate = new DateTime(2025, 3, 30), Progress = 100, Department = "UX/UI Design", Assignee = "Lisa Park", Priority = "High", Budget = 35000, ActualCost = 34000, Status = "Completed", Dependencies = "", Risks = "Low", Notes = "Site map and user flows approved", Category = "UX Design", Location = "Remote", TechStack = "Figma, Miro", EstimatedStoryPoints = 21, Initiative = "Structure", PriorityLevel = "Navigation" },
                new TaskData { Id = 12, ParentId = 10, Task = "Wireframing", StartDate = new DateTime(2025, 4, 1), EndDate = new DateTime(2025, 4, 21), Progress = 100, Department = "UX/UI Design", Assignee = "David Lee", Priority = "High", Budget = 45000, ActualCost = 44000, Status = "Completed", Dependencies = "", Risks = "Low", Notes = "Wireframes approved by stakeholders", Category = "UX Design", Location = "Remote", TechStack = "Figma", EstimatedStoryPoints = 34, Initiative = "Layout", PriorityLevel = "Functionality" },
                new TaskData { Id = 13, ParentId = 10, Task = "Visual Design", StartDate = new DateTime(2025, 4, 22), EndDate = new DateTime(2025, 5, 15), Progress = 80, Department = "UX/UI Design", Assignee = "Michael Wong", Priority = "High", Budget = 70000, ActualCost = 57000, Status = "In Progress", Dependencies = "12", Risks = "Medium", Notes = "Design system being finalized", Category = "UI Design", Location = "Remote", TechStack = "Figma, Adobe XD", EstimatedStoryPoints = 55, Initiative = "Branding", PriorityLevel = "Aesthetics", IsManual = true },
                new TaskData { Id = 14, ParentId = 1, Task = "Development Phase", StartDate = new DateTime(2025, 5, 16), EndDate = new DateTime(2025, 8, 29), Progress = 20, Department = "Engineering", Assignee = "Alex Johnson", Priority = "High", Budget = 600000, ActualCost = 120000, Status = "In Progress", Dependencies = "10", Risks = "Medium", Notes = "Agile sprints ongoing", Category = "Development", Location = "Remote", TechStack = "React, Node.js, MongoDB, AWS", EstimatedStoryPoints = 377, Initiative = "Core Development", PriorityLevel = "Scalability" },
                new TaskData { Id = 15, ParentId = 14, Task = "Sprint 1: User Authentication", StartDate = new DateTime(2025, 5, 16), EndDate = new DateTime(2025, 5, 29), Progress = 100, Department = "Engineering", Assignee = "Rachel Green", Priority = "High", Budget = 60000, ActualCost = 58000, Status = "Completed", Dependencies = "", Risks = "Low", Notes = "Implemented user registration and login", Category = "Backend Development", Location = "Remote", TechStack = "Node.js, MongoDB, JWT", EstimatedStoryPoints = 34, Initiative = "Security", PriorityLevel = "User Management" },
                new TaskData { Id = 16, ParentId = 14, Task = "Sprint 2: Product Catalog", StartDate = new DateTime(2025, 6, 13), EndDate = new DateTime(2025, 6, 24), Progress = 100, Department = "Engineering", Assignee = "Mike Ross", Priority = "High", Budget = 65000, ActualCost = 62000, Status = "Completed", Dependencies = "", Risks = "Low", Notes = "Developed product listing and detail pages", Category = "Frontend Development", Location = "Remote", TechStack = "React, Redux", EstimatedStoryPoints = 55, Initiative = "E-commerce", PriorityLevel = "Product Management" },
                new TaskData { Id = 17, ParentId = 14, Task = "Sprint 3: Shopping Cart", StartDate = new DateTime(2025, 6, 25), EndDate = new DateTime(2025, 7, 08), Progress = 100, Department = "Engineering", Assignee = "Phoebe Buffay", Priority = "High", Budget = 70000, ActualCost = 68000, Status = "Completed", Dependencies = "", Risks = "Medium", Notes = "Implemented shopping cart functionality", Category = "Full Stack Development", Location = "Remote", TechStack = "React, Node.js, MongoDB", EstimatedStoryPoints = 55, Initiative = "E-commerce", PriorityLevel = "User Experience" },
                new TaskData { Id = 18, ParentId = 14, Task = "Sprint 4: Checkout Process", StartDate = new DateTime(2025, 7, 9), EndDate = new DateTime(2025, 7, 18), Progress = 90, Department = "Engineering", Assignee = "Chandler Bing", Priority = "High", Budget = 80000, ActualCost = 72000, Status = "In Progress", Dependencies = "", Risks = "High", Notes = "Integrating secure payment gateway", Category = "Backend Development", Location = "Remote", TechStack = "Node.js, Stripe API", EstimatedStoryPoints = 89, Initiative = "Financial", PriorityLevel = "Security" },
                new TaskData { Id = 19, ParentId = 14, Task = "Sprint 5: User Profile and Orders", StartDate = new DateTime(2025, 7, 21), EndDate = new DateTime(2025, 7, 29), Progress = 0, Department = "Engineering", Assignee = "Joey Tribbiani", Priority = "Medium", Budget = 65000, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "Low", Notes = "Implement user profile and order history", Category = "Full Stack Development", Location = "Remote", TechStack = "React, Node.js, MongoDB", EstimatedStoryPoints = 55, Initiative = "User Management", PriorityLevel = "E-commerce" },
                new TaskData { Id = 20, ParentId = 14, Task = "Sprint 6: Search and Filtering", StartDate = new DateTime(2025, 7, 30), EndDate = new DateTime(2025, 8, 11), Progress = 0, Department = "Engineering", Assignee = "Monica Geller", Priority = "Medium", Budget = 70000, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "Medium", Notes = "Implement advanced search and filtering functionality", Category = "Full Stack Development", Location = "Remote", TechStack = "React, Node.js, Elasticsearch", EstimatedStoryPoints = 55, Initiative = "Performance", PriorityLevel = "User Experience" },
                new TaskData { Id = 21, ParentId = 14, Task = "Sprint 7: Admin Dashboard", StartDate = new DateTime(2025, 8, 12), EndDate = new DateTime(2025, 8, 22), Progress = 0, Department = "Engineering", Assignee = "Ross Geller", Priority = "Medium", Budget = 60000, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "Low", Notes = "Develop admin dashboard for product and order management", Category = "Frontend Development", Location = "Remote", TechStack = "React, Redux", EstimatedStoryPoints = 34, Initiative = "Administration", PriorityLevel = "Reporting" },
                new TaskData { Id = 22, ParentId = 14, Task = "Sprint 8: Performance Optimization", StartDate = new DateTime(2025, 8, 25), EndDate = new DateTime(2025, 9, 05), Progress = 0, Department = "Engineering", Assignee = "Chandler Bing", Priority = "High", Budget = 50000, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "Medium", Notes = "Optimize application performance and scalability", Category = "Full Stack Development", Location = "Remote", TechStack = "React, Node.js, MongoDB, Redis", EstimatedStoryPoints = 34, Initiative = "Optimization", PriorityLevel = "Scalability" },
                new TaskData { Id = 23, ParentId = 1, Task = "Quality Assurance", StartDate = new DateTime(2025, 5, 30), EndDate = new DateTime(2025, 9, 15), Progress = 40, Department = "Quality Assurance", Assignee = "Emma Watson", Priority = "High", Budget = 180000, ActualCost = 72000, Status = "In Progress", Dependencies = "14", Risks = "Medium", Notes = "Ongoing testing throughout development", Category = "Testing", Location = "Remote", TechStack = "Jest, Cypress, Selenium", EstimatedStoryPoints = 144, Initiative = "Quality Control", PriorityLevel = "Bug Prevention" },
                new TaskData { Id = 24, ParentId = 23, Task = "Unit Testing", StartDate = new DateTime(2025, 5, 30), EndDate = new DateTime(2025, 6, 15), Progress = 0, Department = "Engineering", Assignee = "Chris Evans", Priority = "High", Budget = 70000, ActualCost = 42000, Status = "In Progress", Dependencies = "", Risks = "Low", Notes = "Ongoing unit tests for all components", Category = "Testing", Location = "Remote", TechStack = "Jest", EstimatedStoryPoints = 55, Initiative = "Code Quality", PriorityLevel = "Automated Testing" },
                new TaskData { Id = 25, ParentId = 23, Task = "Integration Testing", StartDate = new DateTime(2025, 6, 14), EndDate = new DateTime(2025, 7, 10), Progress = 0, Department = "Quality Assurance", Assignee = "Scarlett Johnson", Priority = "High", Budget = 65000, ActualCost = 19500, Status = "In Progress", Dependencies = "24", Risks = "Medium", Notes = "Testing API integrations and component interactions", Category = "Testing", Location = "Remote", TechStack = "Postman, Cypress", EstimatedStoryPoints = 55, Initiative = "System Integrity", PriorityLevel = "API Testing" },
                new TaskData { Id = 26, ParentId = 23, Task = "User Acceptance Testing", StartDate = new DateTime(2025, 9, 1), EndDate = new DateTime(2025, 9, 15), Progress = 0, Department = "Quality Assurance", Assignee = "Robert Downey", Priority = "High", Budget = 45000, ActualCost = 0, Status = "Not Started", Dependencies = "25", Risks = "Medium", Notes = "Final UAT with key stakeholders", Category = "Testing", Location = "Remote", TechStack = "TestRail", EstimatedStoryPoints = 34, Initiative = "Stakeholder Approval", PriorityLevel = "Final Validation", IsManual = true },
                new TaskData { Id = 27, ParentId = 1, Task = "Performance Optimization", StartDate = new DateTime(2025, 9, 2), EndDate = new DateTime(2025, 11, 10), Progress = 0, Department = "Engineering", Assignee = "Tony Stark", Priority = "High", Budget = 80000, ActualCost = 0, Status = "Not Started", Dependencies = "14", Risks = "Medium", Notes = "Optimize application performance and scalability", Category = "Development", Location = "Remote", TechStack = "React, Node.js, MongoDB, Redis", EstimatedStoryPoints = 89, Initiative = "Optimization", PriorityLevel = "Scalability" },
                new TaskData { Id = 28, ParentId = 27, Task = "Frontend Optimization", StartDate = new DateTime(2025, 9, 2), EndDate = new DateTime(2025, 9, 11), Progress = 0, Department = "Engineering", Assignee = "Peter Parker", Priority = "High", Budget = 35000, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "Low", Notes = "Optimize React components and state management", Category = "Frontend Development", Location = "Remote", TechStack = "React, Redux", EstimatedStoryPoints = 34, Initiative = "Performance", PriorityLevel = "User Experience" },
                new TaskData { Id = 29, ParentId = 27, Task = "Backend Optimization", StartDate = new DateTime(2025, 9, 12), EndDate = new DateTime(2025, 9, 22), Progress = 0, Department = "Engineering", Assignee = "Steve Rogers", Priority = "High", Budget = 45000, ActualCost = 0, Status = "Not Started", Dependencies = "28", Risks = "Medium", Notes = "Optimize database queries and implement caching", Category = "Backend Development", Location = "Remote", TechStack = "Node.js, MongoDB, Redis", EstimatedStoryPoints = 55, Initiative = "Database", PriorityLevel = "Caching" },
                new TaskData { Id = 30, ParentId = 1, Task = "Security Audit", StartDate = new DateTime(2025, 9, 23), EndDate = new DateTime(2025, 9, 29), Progress = 0, Department = "Information Security", Assignee = "Natasha Romanoff", Priority = "High", Budget = 40000, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "High", Notes = "Conduct comprehensive security audit", Category = "Security", Location = "Remote", TechStack = "Various security tools", EstimatedStoryPoints = 34, Initiative = "Compliance", PriorityLevel = "Risk Management" },
                new TaskData { Id = 31, ParentId = 1, Task = "Deployment", StartDate = new DateTime(2025, 11, 17), EndDate = new DateTime(2025, 11, 23), Progress = 0, Department = "DevOps", Assignee = "Nick Fury", Priority = "High", Budget = 50000, ActualCost = 0, Status = "Not Started", Dependencies = "27", Risks = "High", Notes = "Final deployment to production", Category = "Operations", Location = "Remote", TechStack = "AWS, Docker, Kubernetes", EstimatedStoryPoints = 21, Initiative = "Production Release", PriorityLevel = "Go-Live" },
                new TaskData { Id = 32, ParentId = 31, Task = "Infrastructure Setup", StartDate = new DateTime(2025, 11, 17), EndDate = new DateTime(2025, 11, 19), Progress = 0, Department = "DevOps", Assignee = "Maria Hill", Priority = "High", Budget = 25000, ActualCost = 0, Status = "Not Started", Dependencies = "30", Risks = "Medium", Notes = "Set up production infrastructure on AWS", Category = "Operations", Location = "Remote", TechStack = "AWS, Terraform", EstimatedStoryPoints = 13, Initiative = "Cloud Infrastructure", PriorityLevel = "Scalability" },
                new TaskData { Id = 33, ParentId = 31, Task = "Data Migration", StartDate = new DateTime(2025, 11, 19), EndDate = new DateTime(2025, 11, 25), Progress = 0, Department = "Data Management", Assignee = "Phil Coulson", Priority = "High", Budget = 15000, ActualCost = 0, Status = "Not Started", Dependencies = "32", Risks = "High", Notes = "Migrate existing data to new platform", Category = "Data", Location = "Remote", TechStack = "MongoDB, Custom scripts", EstimatedStoryPoints = 8, Initiative = "Data Integrity", PriorityLevel = "Legacy System" },
                new TaskData { Id = 34, ParentId = 31, Task = "Final Deployment", StartDate = new DateTime(2025, 11, 22), EndDate = new DateTime(2025, 11, 23), Progress = 0, Department = "DevOps", Assignee = "Nick Fury", Priority = "High", Budget = 10000, ActualCost = 0, Status = "Not Started", Dependencies = "33", Risks = "High", Notes = "Deploy application to production environment", Category = "Operations", Location = "Remote", TechStack = "AWS, Docker, Kubernetes", EstimatedStoryPoints = 5, Initiative = "Go-Live", PriorityLevel = "Production Release" },
                new TaskData { Id = 35, ParentId = 15, Task = "Test User Authentication", StartDate = new DateTime(2025, 5, 20), EndDate = new DateTime(2025, 5, 28), Progress = 0, Department = "QA", Assignee = "Paul Harris", Priority = "High", Budget = 8000, ActualCost = 0, Status = "Not Started", Dependencies = "15", Risks = "Low", Notes = "Test login and registration workflows", Category = "Testing", Location = "Remote", TechStack = "Jest, Cypress", EstimatedStoryPoints = 10, Initiative = "Security Verification", PriorityLevel = "Critical Path", IsManual = true },
                new TaskData { Id = 36, ParentId = 15, Task = "Enhance Security Measures", StartDate = new DateTime(2025, 5, 23), EndDate = new DateTime(2025, 5, 31), Progress = 0, Department = "Engineering", Assignee = "Linda Green", Priority = "Medium", Budget = 9000, ActualCost = 0, Status = "Not Started", Dependencies = "35", Risks = "Medium", Notes = "Investigate and patch any vulnerabilities found", Category = "Security", Location = "Remote", TechStack = "Node.js, MongoDB", EstimatedStoryPoints = 8, Initiative = "Strengthening Security", PriorityLevel = "Risk Mitigation" },
                new TaskData { Id = 37, ParentId = 16, Task = "UI Design Review", StartDate = new DateTime(2025, 6, 3), EndDate = new DateTime(2025, 6, 11), Progress = 0, Department = "UX/UI Design", Assignee = "Kevin White", Priority = "High", Budget = 7000, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "Low", Notes = "Review and update UI based on feedback", Category = "Design", Location = "Remote", TechStack = "Figma", EstimatedStoryPoints = 7, Initiative = "User Feedback Incorporation", PriorityLevel = "Improvement" },
                new TaskData { Id = 38, ParentId = 16, Task = "Product Page Optimization", StartDate = new DateTime(2025, 6, 6), EndDate = new DateTime(2025, 6, 11), Progress = 0, Department = "Frontend Development", Assignee = "Alice Jones", Priority = "Medium", Budget = 6000, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "Medium", Notes = "Optimize page load speed and user interaction", Category = "Frontend Development", Location = "Remote", TechStack = "React, Redux", EstimatedStoryPoints = 12, Initiative = "Performance Enhancement", PriorityLevel = "Optimization" },
                new TaskData { Id = 39, ParentId = 17, Task = "Cart Functionality Testing", StartDate = new DateTime(2025, 6, 20), EndDate = new DateTime(2025, 6, 25), Progress = 0, Department = "QA", Assignee = "Tom Brown", Priority = "High", Budget = 10000, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "Low", Notes = "Test all cart features including adding/removing items", Category = "Testing", Location = "Remote", TechStack = "Selenium", EstimatedStoryPoints = 12, Initiative = "Functionality Assurance", PriorityLevel = "Verification" },
                new TaskData { Id = 40, ParentId = 17, Task = "Cart Performance Optimization", StartDate = new DateTime(2025, 6, 23), EndDate = new DateTime(2025, 6, 28), Progress = 0, Department = "Engineering", Assignee = "Bruce Wayne", Priority = "Medium", Budget = 9500, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "Medium", Notes = "Improve load time when updating cart items", Category = "Performance", Location = "Remote", TechStack = "React, Node.js", EstimatedStoryPoints = 14, Initiative = "Performance Optimization", PriorityLevel = "Efficiency" },
                new TaskData { Id = 41, ParentId = 18, Task = "Payment Gateway Integration Testing", StartDate = new DateTime(2025, 7, 5), EndDate = new DateTime(2025, 7, 13), Progress = 0, Department = "QA", Assignee = "Clark Kent", Priority = "High", Budget = 12000, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "High", Notes = "Test payment process integration with multiple methods", Category = "Testing", Location = "Remote", TechStack = "Stripe API, Postman", EstimatedStoryPoints = 15, Initiative = "Security Validation", PriorityLevel = "High Stakes", IsManual = true },
                new TaskData { Id = 42, ParentId = 18, Task = "Secure Payment Integration", StartDate = new DateTime(2025, 7, 8), EndDate = new DateTime(2025, 7, 16), Progress = 0, Department = "Engineering", Assignee = "Diana Prince", Priority = "High", Budget = 11000, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "High", Notes = "Ensure PCI compliance and strengthen secure transactions", Category = "Security", Location = "Remote", TechStack = "Node.js, Stripe API", EstimatedStoryPoints = 20, Initiative = "PCI Compliance", PriorityLevel = "Mandatory" },
                new TaskData { Id = 43, ParentId = 19, Task = "User Profile UI Update", StartDate = new DateTime(2025, 7, 15), EndDate = new DateTime(2025, 7, 21), Progress = 0, Department = "UX/UI Design", Assignee = "John Clark", Priority = "Medium", Budget = 6500, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "Low", Notes = "Revise UI design for user profiles", Category = "Design", Location = "Remote", TechStack = "Figma", EstimatedStoryPoints = 9, Initiative = "User Experience", PriorityLevel = "Enhancement" },
                new TaskData { Id = 44, ParentId = 19, Task = "Order History Backend", StartDate = new DateTime(2025, 7, 18), EndDate = new DateTime(2025, 7, 23), Progress = 0, Department = "Engineering", Assignee = "Lisa Lane", Priority = "High", Budget = 7500, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "Medium", Notes = "Implement backend for order history retrieval", Category = "Backend Development", Location = "Remote", TechStack = "Node.js, MongoDB", EstimatedStoryPoints = 11, Initiative = "Functionality Expansion", PriorityLevel = "Integration", IsManual = true },
                new TaskData { Id = 45, ParentId = 20, Task = "Advanced Search Testing", StartDate = new DateTime(2025, 7, 28), EndDate = new DateTime(2025, 8, 2), Progress = 0, Department = "QA", Assignee = "Lucy West", Priority = "High", Budget = 8000, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "Medium", Notes = "Verify new search algorithms and filters", Category = "Testing", Location = "Remote", TechStack = "Cypress", EstimatedStoryPoints = 10, Initiative = "Feature Release", PriorityLevel = "Verification" },
                new TaskData { Id = 46, ParentId = 20, Task = "Filtering Enhancement", StartDate = new DateTime(2025, 7, 31), EndDate = new DateTime(2025, 8, 5), Progress = 0, Department = "Engineering", Assignee = "Barry Allen", Priority = "Medium", Budget = 7000, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "Low", Notes = "Refine filter options for better user experience", Category = "Frontend Development", Location = "Remote", TechStack = "React", EstimatedStoryPoints = 8, Initiative = "UX Enhancement", PriorityLevel = "Usability" },
                new TaskData { Id = 47, ParentId = 21, Task = "Admin Dashboard Design", StartDate = new DateTime(2025, 8, 10), EndDate = new DateTime(2025, 8, 15), Progress = 0, Department = "UX/UI Design", Assignee = "Bruce Banner", Priority = "Medium", Budget = 6000, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "Low", Notes = "Create wireframes for admin dashboard", Category = "Design", Location = "Remote", TechStack = "Figma", EstimatedStoryPoints = 7, Initiative = "Admin Tools", PriorityLevel = "Design" },
                new TaskData { Id = 48, ParentId = 21, Task = "Dashboard Analytics Module", StartDate = new DateTime(2025, 8, 13), EndDate = new DateTime(2025, 8, 18), Progress = 0, Department = "Engineering", Assignee = "Arthur Curry", Priority = "High", Budget = 8500, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "Medium", Notes = "Develop analytics module for insights", Category = "Backend Development", Location = "Remote", TechStack = "Node.js, MongoDB", EstimatedStoryPoints = 12, Initiative = "Data Insights", PriorityLevel = "Critical" },
                new TaskData { Id = 49, ParentId = 22, Task = "Review Existing Optimizations", StartDate = new DateTime(2025, 8, 24), EndDate = new DateTime(2025, 8, 29), Progress = 0, Department = "QA", Assignee = "Hal Jordan", Priority = "Medium", Budget = 6000, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "Low", Notes = "Assess current optimization efforts", Category = "Review", Location = "Remote", TechStack = "N/A", EstimatedStoryPoints = 9, Initiative = "Code Review", PriorityLevel = "Review" },
                new TaskData { Id = 50, ParentId = 22, Task = "Implement New Optimizations", StartDate = new DateTime(2025, 8, 26), EndDate = new DateTime(2025, 9, 02), Progress = 0, Department = "Engineering", Assignee = "Oliver Queen", Priority = "High", Budget = 9000, ActualCost = 0, Status = "Not Started", Dependencies = "", Risks = "Medium", Notes = "Apply new strategies for speed and efficiency", Category = "Optimization", Location = "Remote", TechStack = "React, Node.js", EstimatedStoryPoints = 14, Initiative = "Scalability", PriorityLevel = "Enhancement", IsManual = true }
            };
        }

        public static List<AssignmentModel> GetAssignmentCollection()
        {
            List<AssignmentModel> assignments = new List<AssignmentModel>()
            {
                new AssignmentModel(){ Id=1, TaskId = 5, ResourceId = 1},
                new AssignmentModel(){ Id=2, TaskId = 6, ResourceId = 2},
                new AssignmentModel(){ Id=3, TaskId = 8, ResourceId = 4},
                new AssignmentModel(){ Id=4, TaskId = 10, ResourceId = 1},
                new AssignmentModel(){ Id=5, TaskId = 11, ResourceId = 6},
                new AssignmentModel(){ Id=6, TaskId = 12, ResourceId = 1},
                new AssignmentModel(){ Id=7, TaskId = 13, ResourceId = 4},
                new AssignmentModel(){ Id=8, TaskId = 14, ResourceId = 1},
                new AssignmentModel(){ Id=9, TaskId = 15, ResourceId = 4},
                new AssignmentModel(){ Id=10, TaskId = 25, ResourceId = 1},
                new AssignmentModel(){ Id=11, TaskId = 26, ResourceId = 6},
                new AssignmentModel(){ Id=12, TaskId = 27, ResourceId = 2},
                new AssignmentModel(){ Id=13, TaskId = 29, ResourceId = 4},
                new AssignmentModel(){ Id=14, TaskId = 30, ResourceId = 1},
                new AssignmentModel(){ Id=15, TaskId = 32, ResourceId = 2},
                new AssignmentModel(){ Id=16, TaskId = 33, ResourceId = 4},
                new AssignmentModel(){ Id=17, TaskId = 34, ResourceId = 6},
                new AssignmentModel(){ Id=18, TaskId = 35, ResourceId = 1},
                new AssignmentModel(){ Id=19, TaskId = 36, ResourceId = 2},
                new AssignmentModel(){ Id=20, TaskId = 37, ResourceId = 6},
                new AssignmentModel(){ Id=21, TaskId = 38, ResourceId = 4},
                new AssignmentModel(){ Id=22, TaskId = 39, ResourceId = 2},
                new AssignmentModel(){ Id=23, TaskId = 40, ResourceId = 1},
                new AssignmentModel(){ Id=24, TaskId = 42, ResourceId = 4},
                new AssignmentModel(){ Id=25, TaskId = 53, ResourceId = 1},
                new AssignmentModel(){ Id=26, TaskId = 54, ResourceId = 6},
                new AssignmentModel(){ Id=27, TaskId = 55, ResourceId = 2},
                new AssignmentModel(){ Id=28, TaskId = 57, ResourceId = 2},
                new AssignmentModel(){ Id=29, TaskId = 58, ResourceId = 1},
                new AssignmentModel(){ Id=30, TaskId = 60, ResourceId = 6},
                new AssignmentModel(){ Id=31, TaskId = 61, ResourceId = 4},
                new AssignmentModel(){ Id=32, TaskId = 62, ResourceId = 2},
                new AssignmentModel(){ Id=33, TaskId = 63, ResourceId = 6},
                new AssignmentModel(){ Id=34, TaskId = 64, ResourceId = 1},
                new AssignmentModel(){ Id=35, TaskId = 65, ResourceId = 2},
                new AssignmentModel(){ Id=36, TaskId = 66, ResourceId = 2},
                new AssignmentModel(){ Id=37, TaskId = 43, ResourceId = 6},
            };
            return assignments;
        }

        public class SegmentModel
        {
            public int id { get; set; }
            public int TaskId { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Duration { get; set; }
        }

        public static List<SegmentModel> GetSegmentCollection()
        {
            List<SegmentModel> segments = new List<SegmentModel>();
            segments.Add(new SegmentModel() { id = 1, TaskId = 5, StartDate = new DateTime(2021, 12, 24), Duration = "10" });
            segments.Add(new SegmentModel() { id = 2, TaskId = 5, StartDate = new DateTime(2022, 01, 03), Duration = "10" });
            segments.Add(new SegmentModel() { id = 3, TaskId = 6, StartDate = new DateTime(2021, 12, 28), Duration = "16" });
            segments.Add(new SegmentModel() { id = 4, TaskId = 6, StartDate = new DateTime(2022, 01, 18), Duration = "5" });
            segments.Add(new SegmentModel() { id = 5, TaskId = 6, StartDate = new DateTime(2022, 01, 25), Duration = "21" });
            segments.Add(new SegmentModel() { id = 6, TaskId = 11, StartDate = new DateTime(2022, 01, 03), Duration = "21" });
            segments.Add(new SegmentModel() { id = 7, TaskId = 11, StartDate = new DateTime(2022, 01, 28), Duration = "12" });
            segments.Add(new SegmentModel() { id = 8, TaskId = 29, StartDate = new DateTime(2022, 04, 25), Duration = "13" });
            segments.Add(new SegmentModel() { id = 9, TaskId = 29, StartDate = new DateTime(2022, 05, 11), Duration = "13" });
            segments.Add(new SegmentModel() { id = 10, TaskId = 58, StartDate = new DateTime(2022, 07, 20), Duration = "15" });
            segments.Add(new SegmentModel() { id = 11, TaskId = 58, StartDate = new DateTime(2022, 08, 08), Duration = "9" });
            segments.Add(new SegmentModel() { id = 12, TaskId = 28, StartDate = new DateTime(2022, 04, 11), Duration = "9" });
            segments.Add(new SegmentModel() { id = 13, TaskId = 28, StartDate = new DateTime(2022, 04, 25), Duration = "11" });
            segments.Add(new SegmentModel() { id = 14, TaskId = 30, StartDate = new DateTime(2022, 04, 11), Duration = "20" });
            segments.Add(new SegmentModel() { id = 15, TaskId = 30, StartDate = new DateTime(2022, 05, 10), Duration = "6" });
            segments.Add(new SegmentModel() { id = 16, TaskId = 57, StartDate = new DateTime(2022, 05, 25), Duration = "8" });
            segments.Add(new SegmentModel() { id = 17, TaskId = 57, StartDate = new DateTime(2022, 06, 07), Duration = "17" });
            return segments;
        }
        internal class HolidayModel
        {
            public int Id { get; set; }
            public string HolidayName { get; set; }
            public DateTime Date { get; set; }
        }
        internal static List<HolidayModel> HolidayCollection = new List<HolidayModel>()
        {
            new HolidayModel() { Id = 1, HolidayName = "Presidents' Day", Date = new DateTime(2025, 02, 17) }, 
            new HolidayModel() { Id = 2, HolidayName = "Memorial Day", Date = new DateTime(2025, 05, 26) },  
            new HolidayModel() { Id = 3, HolidayName = "Independence Day", Date = new DateTime(2025, 07, 04) }, 
            new HolidayModel() { Id = 4, HolidayName = "Labor Day", Date = new DateTime(2025, 09, 01) }, 
            new HolidayModel() { Id = 5, HolidayName = "Columbus Day", Date = new DateTime(2025, 10, 13) },
            new HolidayModel() { Id = 6, HolidayName = "Veterans Day", Date = new DateTime(2025, 11, 11) }
        };
    }
}
