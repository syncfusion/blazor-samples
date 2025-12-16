#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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

namespace TicketData
{
    internal class SupportTicketData
    {
        public SupportTicketData() { }

        // Properties for support ticket data
        public int TicketID { get; set; }
        public string Title { get; set; } = string.Empty;
        public int? ParentTicketID { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Priority { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string AssignedAgent { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal EstimatedHours { get; set; }
        public string Description { get; set; } = string.Empty;

        public SupportTicketData(int ticketID, string title, int? parentTicketID, string category,
            string priority, string status, string assignedAgent, string customerName,
            DateTime createdDate, DateTime dueDate, decimal estimatedHours, string description = "")
        {
            this.TicketID = ticketID;
            this.Title = title;
            this.ParentTicketID = parentTicketID;
            this.Category = category;
            this.Priority = priority;
            this.Status = status;
            this.AssignedAgent = assignedAgent;
            this.CustomerName = customerName;
            this.CreatedDate = createdDate;
            this.DueDate = dueDate;
            this.EstimatedHours = estimatedHours;
            this.Description = description;
        }

        public static List<SupportTicketData> GetSupportTickets()
        {
            var tickets = new List<SupportTicketData>
            {
                // Server Infrastructure Issues (Category 1) - Pattern: 573XX
                new SupportTicketData(57301, "Server Infrastructure Issues", null, "Technical", "High", "In Progress", "Alex Rivera", "Zorath Industries", DateTime.Now.AddDays(-15), DateTime.Now.AddHours(-1), 16, "Server Infrastructure Issues"),
                new SupportTicketData(57302, "Email Service Down", 57301, "Technical", "Critical", "Open", "Alex Rivera", "Zorath Industries", DateTime.Now.AddDays(-12), DateTime.Now.AddHours(2), 4, "The email service has stopped functioning, impacting communication across the organization."),
                new SupportTicketData(57303, "Database Connection Issues", 57301, "Technical", "High", "In Progress", "Jordan Lee", "Zorath Industries", DateTime.Now.AddDays(-11), DateTime.Now.AddHours(6), 8, "Users experiencing intermittent errors when connecting to the primary database server."),
                new SupportTicketData(57304, "Load Balancer Configuration", 57301, "Technical", "Medium", "Resolved", "Alex Rivera", "Zorath Industries", DateTime.Now.AddDays(-10), DateTime.Now.AddDays(1), 6, "Misconfigured load balancer causing uneven distribution of incoming traffic."),
                new SupportTicketData(57305, "DNS Resolution Problems", 57301, "Technical", "High", "Open", "Casey Kim", "Zorath Industries", DateTime.Now.AddDays(-9), DateTime.Now.AddDays(1), 5, "DNS servers failing to resolve domain names, resulting in website access issues."),
                new SupportTicketData(57306, "CDN Performance Issues", 57301, "Technical", "Medium", "In Progress", "Taylor Morgan", "Zorath Industries", DateTime.Now.AddDays(-8), DateTime.Now.AddDays(2), 10, "Increased latency in the content delivery network, slowing down page load times."),

                // Application Bug Reports (Category 2) - Pattern: 573XX
                new SupportTicketData(57307, "Application Bug Reports", null, "Software", "Medium", "Open", "Casey Kim", "Keldrix Systems", DateTime.Now.AddDays(-14), DateTime.Now.AddDays(1), 12, "Application Bug Reports"),
                new SupportTicketData(57308, "Login Authentication Error", 57307, "Software", "High", "Escalated", "Casey Kim", "Keldrix Systems", DateTime.Now.AddDays(-13), DateTime.Now.AddHours(4), 6, "Users unable to authenticate due to token mismatch during login process."),
                new SupportTicketData(57309, "Data Export Functionality", 57307, "Software", "Low", "Open", "Taylor Morgan", "Keldrix Systems", DateTime.Now.AddDays(-12), DateTime.Now.AddDays(3), 4, "Export feature failing to generate accurate CSV files with all data."),
                new SupportTicketData(57310, "UI Rendering Issues", 57307, "Software", "Medium", "In Progress", "Casey Kim", "Keldrix Systems", DateTime.Now.AddDays(-11), DateTime.Now.AddDays(2), 8, "UI elements not rendering correctly on the latest browser versions."),
                new SupportTicketData(57311, "API Integration Problems", 57307, "Software", "Critical", "Open", "Riley Patel", "Keldrix Systems", DateTime.Now.AddDays(-10), DateTime.Now.AddHours(12), 15, "External API calls returning internal server errors (500)."),
                new SupportTicketData(57312, "File Upload Memory Leak", 57307, "Software", "High", "In Progress", "Jordan Lee", "Keldrix Systems", DateTime.Now.AddDays(-9), DateTime.Now.AddDays(1), 12, "Memory usage spikes after multiple file uploads, leading to crashes."),
                new SupportTicketData(57313, "Session Timeout Bug", 57307, "Software", "Medium", "Resolved", "Taylor Morgan", "Keldrix Systems", DateTime.Now.AddDays(-8), DateTime.Now.AddDays(3), 7, "User sessions expiring too early, causing unexpected logouts."),

                // Network Connectivity Problems (Category 3) - Pattern: 573XX
                new SupportTicketData(57314, "Network Connectivity Problems", null, "Network", "Medium", "Open", "Riley Patel", "Quorvex Networks", DateTime.Now.AddDays(-13), DateTime.Now.AddDays(1), 8, "Network Connectivity Problems"),
                new SupportTicketData(57315, "VPN Connection Timeout", 57314, "Network", "Medium", "In Progress", "Riley Patel", "Quorvex Networks", DateTime.Now.AddDays(-12), DateTime.Now.AddHours(8), 3, "VPN sessions dropping after short periods of inactivity."),
                new SupportTicketData(57316, "Firewall Configuration", 57314, "Network", "Low", "Resolved", "Alex Rivera", "Quorvex Networks", DateTime.Now.AddDays(-11), DateTime.Now.AddDays(2), 2, "Firewall rules incorrectly blocking HTTPS traffic."),
                new SupportTicketData(57317, "WiFi Access Point Issues", 57314, "Network", "High", "Open", "Riley Patel", "Quorvex Networks", DateTime.Now.AddDays(-10), DateTime.Now.AddHours(12), 4, "Several WiFi access points in the office are offline."),
                new SupportTicketData(57318, "Router Configuration Error", 57314, "Network", "Critical", "Escalated", "Casey Kim", "Quorvex Networks", DateTime.Now.AddDays(-9), DateTime.Now.AddHours(6), 8, "Router setup error creating network loops and instability."),
                new SupportTicketData(57319, "Bandwidth Optimization", 57314, "Network", "Medium", "In Progress", "Jordan Lee", "Quorvex Networks", DateTime.Now.AddDays(-8), DateTime.Now.AddDays(4), 6, "Adjust bandwidth allocation to prioritize VoIP and video calls."),

                // User Training & Support Requests (Category 4) - Pattern: 573XX
                new SupportTicketData(57320, "User Training Requests", null, "Support", "Low", "Open", "Jordan Lee", "Mirath News", DateTime.Now.AddDays(-12), DateTime.Now.AddDays(5), 20, "User Training Requests"),
                new SupportTicketData(57321, "Password Reset Issues", 57320, "Support", "Medium", "Resolved", "Jordan Lee", "Mirath News", DateTime.Now.AddDays(-11), DateTime.Now.AddDays(1), 1, "Password reset emails not arriving in user inboxes."),
                new SupportTicketData(57322, "Feature Request Training", 57320, "Support", "Low", "Open", "Taylor Morgan", "Mirath News", DateTime.Now.AddDays(-10), DateTime.Now.AddDays(7), 8, "Schedule training for the new analytics reporting features."),
                new SupportTicketData(57323, "New Employee Onboarding", 57320, "Support", "Medium", "In Progress", "Jordan Lee", "Mirath News", DateTime.Now.AddDays(-9), DateTime.Now.AddDays(3), 12, "Onboarding for new hires delayed by access provisioning problems."),
                new SupportTicketData(57324, "System Access Training", 57320, "Support", "Low", "Open", "Riley Patel", "Mirath News", DateTime.Now.AddDays(-8), DateTime.Now.AddDays(5), 4, "Provide training on secure system access for remote employees."),
                new SupportTicketData(57325, "Advanced Features Workshop", 57320, "Support", "Medium", "In Progress", "Casey Kim", "Mirath News", DateTime.Now.AddDays(-7), DateTime.Now.AddDays(2), 16, "Conduct workshop on advanced customization of dashboards."),

                // Hardware Maintenance (Category 5) - Pattern: 573XX
                new SupportTicketData(57326, "Hardware Maintenance", null, "Hardware", "Medium", "Open", "Casey Kim", "Fluxor Hardware", DateTime.Now.AddDays(-11), DateTime.Now.AddDays(2), 16, "Hardware Maintenance"),
                new SupportTicketData(57327, "Printer Configuration", 57326, "Hardware", "Low", "Open", "Riley Patel", "Fluxor Hardware", DateTime.Now.AddDays(-10), DateTime.Now.AddDays(1), 2, "Network printers failing to accept print jobs from workstations."),
                new SupportTicketData(57328, "Server Memory Upgrade", 57326, "Hardware", "High", "In Progress", "Casey Kim", "Fluxor Hardware", DateTime.Now.AddDays(-9), DateTime.Now.AddHours(12), 8, "Upgrade server RAM capacity from 64GB to 128GB for better performance."),
                new SupportTicketData(57329, "Workstation Replacement", 57326, "Hardware", "Medium", "Closed", "Taylor Morgan", "Fluxor Hardware", DateTime.Now.AddDays(-8), DateTime.Now.AddDays(4), 6, "Replace aging workstations for the development team."),
                new SupportTicketData(57330, "UPS Battery Replacement", 57326, "Hardware", "High", "Open", "Alex Rivera", "Fluxor Hardware", DateTime.Now.AddDays(-7), DateTime.Now.AddHours(24), 4, "Replace aging batteries in UPS units to ensure power backup."),
                new SupportTicketData(57331, "Network Switch Upgrade", 57326, "Hardware", "Critical", "In Progress", "Jordan Lee", "Fluxor Hardware", DateTime.Now.AddDays(-6), DateTime.Now.AddHours(8), 12, "Upgrade to faster gigabit network switches."),
                new SupportTicketData(57332, "Monitor Calibration", 57326, "Hardware", "Low", "Resolved", "Riley Patel", "Fluxor Hardware", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(3), 2, "Calibrate monitors for accurate color representation in design work."),

                // Security Vulnerabilities (Category 6) - Pattern: 573XX
                new SupportTicketData(57333, "Security Vulnerabilities", null, "Security", "Critical", "Open", "Alex Rivera", "Lumithar Mobility", DateTime.Now.AddDays(-10), DateTime.Now.AddHours(6), 24, "Security Vulnerabilities"),
                new SupportTicketData(57334, "SSL Certificate Renewal", 57333, "Security", "High", "In Progress", "Jordan Lee", "Lumithar Mobility", DateTime.Now.AddDays(-9), DateTime.Now.AddHours(8), 4, "Renew expiring SSL certificates to maintain secure connections."),
                new SupportTicketData(57335, "Access Control Review", 57333, "Security", "Medium", "Open", "Casey Kim", "Lumithar Mobility", DateTime.Now.AddDays(-8), DateTime.Now.AddDays(5), 16, "Conduct quarterly review of user access rights and permissions."),
                new SupportTicketData(57336, "Penetration Test Findings", 57333, "Security", "Critical", "Escalated", "Taylor Morgan", "Lumithar Mobility", DateTime.Now.AddDays(-7), DateTime.Now.AddHours(4), 20, "Remediate vulnerabilities discovered during penetration testing."),
                new SupportTicketData(57337, "Two-Factor Auth Setup", 57333, "Security", "High", "In Progress", "Riley Patel", "Lumithar Mobility", DateTime.Now.AddDays(-6), DateTime.Now.AddDays(1), 8, "Roll out two-factor authentication for administrative accounts."),
                new SupportTicketData(57338, "Compliance Audit Issues", 57333, "Security", "Medium", "Open", "Alex Rivera", "Lumithar Mobility", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(7), 14, "Address non-compliance items from the latest audit report."),

                // Performance Optimization (Category 7) - Pattern: 573XX
                new SupportTicketData(57339, "Performance Optimization", null, "Performance", "High", "Open", "Taylor Morgan", "Thrylon Dynamics", DateTime.Now.AddDays(-9), DateTime.Now.AddDays(1), 20, "Performance Optimization"),
                new SupportTicketData(57340, "Query Optimization", 57339, "Performance", "High", "In Progress", "Riley Patel", "Thrylon Dynamics", DateTime.Now.AddDays(-8), DateTime.Now.AddHours(10), 12, "Identify and optimize slow-performing SQL queries in reports."),
                new SupportTicketData(57341, "Caching Implementation", 57339, "Performance", "Medium", "Open", "Taylor Morgan", "Thrylon Dynamics", DateTime.Now.AddDays(-7), DateTime.Now.AddDays(3), 8, "Implement Redis-based caching for high-traffic data endpoints."),
                new SupportTicketData(57342, "Memory Usage Analysis", 57339, "Performance", "High", "In Progress", "Casey Kim", "Thrylon Dynamics", DateTime.Now.AddDays(-6), DateTime.Now.AddHours(16), 15, "Profile and reduce memory leaks in the Java application."),
                new SupportTicketData(57343, "Load Testing Setup", 57339, "Performance", "Medium", "Open", "Jordan Lee", "Thrylon Dynamics", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(2), 10, "Configure JMeter environment for comprehensive load testing."),
                new SupportTicketData(57344, "CDN Configuration", 57339, "Performance", "Low", "Resolved", "Alex Rivera", "Thrylon Dynamics", DateTime.Now.AddDays(-4), DateTime.Now.AddDays(5), 6, "Set up CDN for serving static assets to global users."),

                // Backup & Recovery Systems (Category 8) - Pattern: 573XX
                new SupportTicketData(57345, "Backup System Issues", null, "Backup", "High", "Open", "Alex Rivera", "Resilvault Storage", DateTime.Now.AddDays(-8), DateTime.Now.AddHours(4), 14, "Backup System Issues"),
                new SupportTicketData(57346, "Daily Backup Failure", 57345, "Backup", "Critical", "Escalated", "Jordan Lee", "Resilvault Storage", DateTime.Now.AddDays(-7), DateTime.Now.AddHours(2), 6, "Automated daily backups failing due to insufficient disk space."),
                new SupportTicketData(57347, "Recovery Testing", 57345, "Backup", "Medium", "Open", "Casey Kim", "Resilvault Storage", DateTime.Now.AddDays(-6), DateTime.Now.AddDays(2), 10, "Perform quarterly testing of disaster recovery procedures."),
                new SupportTicketData(57348, "Backup Storage Expansion", 57345, "Backup", "High", "In Progress", "Taylor Morgan", "Resilvault Storage", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(1), 12, "Increase backup storage capacity by an additional 50TB."),
                new SupportTicketData(57349, "Archive Policy Update", 57345, "Backup", "Medium", "Open", "Riley Patel", "Resilvault Storage", DateTime.Now.AddDays(-4), DateTime.Now.AddDays(3), 8, "Revise data retention and archiving policies for compliance."),
                new SupportTicketData(57350, "Disaster Recovery Plan", 57345, "Backup", "Critical", "In Progress", "Alex Rivera", "Resilvault Storage", DateTime.Now.AddDays(-3), DateTime.Now.AddHours(12), 20, "Update the disaster recovery plan to include cloud migration steps."),

                // Mobile Application Issues (Category 9) - Pattern: 573XX
                new SupportTicketData(57351, "Mobile App Issues", null, "Mobile", "High", "Open", "Riley Patel", "Vexarion Mobile", DateTime.Now.AddDays(-7), DateTime.Now.AddDays(8), 16, "Mobile App Issues"),
                new SupportTicketData(57352, "iOS App Crashes", 57351, "Mobile", "Critical", "Escalated", "Jordan Lee", "Vexarion Mobile", DateTime.Now.AddDays(-6), DateTime.Now.AddHours(6), 10, "Frequent crashes on iOS 17 specifically at the login screen."),
                new SupportTicketData(57353, "Android Push Notifications", 57351, "Mobile", "Medium", "In Progress", "Casey Kim", "Vexarion Mobile", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(2), 8, "Push notifications not being received on Android devices."),
                new SupportTicketData(57354, "App Store Deployment", 57351, "Mobile", "High", "Open", "Taylor Morgan", "Vexarion Mobile", DateTime.Now.AddDays(-4), DateTime.Now.AddDays(1), 12, "Prepare and deploy the latest app update to the App Store."),
                new SupportTicketData(57355, "Offline Sync Issues", 57351, "Mobile", "Medium", "In Progress", "Riley Patel", "Vexarion Mobile", DateTime.Now.AddDays(-3), DateTime.Now.AddDays(4), 14, "Data synchronization failing when the app is offline."),
                new SupportTicketData(57356, "Mobile Performance Tuning", 57351, "Mobile", "Low", "Open", "Alex Rivera", "Vexarion Mobile", DateTime.Now.AddDays(-2), DateTime.Now.AddDays(6), 6, "Tune app performance for better experience on budget Android devices."),

                // Cloud Infrastructure (Category 10) - Pattern: 573XX
                new SupportTicketData(57357, "Cloud Infrastructure Issues", null, "Cloud", "High", "Open", "Jordan Lee", "Elyndor Cloud", DateTime.Now.AddDays(-6), DateTime.Now.AddDays(2), 18, "Cloud Infrastructure Issues"),
                new SupportTicketData(57358, "AWS Lambda Timeouts", 57357, "Cloud", "Critical", "In Progress", "Casey Kim", "Elyndor Cloud", DateTime.Now.AddDays(-5), DateTime.Now.AddHours(8), 10, "Serverless functions in AWS Lambda exceeding timeout limits under load."),
                new SupportTicketData(57359, "S3 Bucket Configuration", 57357, "Cloud", "Medium", "Open", "Taylor Morgan", "Elyndor Cloud", DateTime.Now.AddDays(-4), DateTime.Now.AddDays(3), 6, "S3 bucket permissions misconfigured, causing access denied errors."),
                new SupportTicketData(57360, "Auto-scaling Issues", 57357, "Cloud", "High", "Escalated", "Riley Patel", "Elyndor Cloud", DateTime.Now.AddDays(-3), DateTime.Now.AddHours(12), 15, "EC2 auto-scaling group not provisioning instances during peak times."),
                new SupportTicketData(57361, "Container Orchestration", 57357, "Cloud", "Medium", "In Progress", "Alex Rivera", "Elyndor Cloud", DateTime.Now.AddDays(-2), DateTime.Now.AddDays(5), 12, "Debug Kubernetes pod evictions and resource limits."),
                new SupportTicketData(57362, "Kubernetes Deployment", 57357, "Cloud", "Low", "Open", "Jordan Lee", "Elyndor Cloud", DateTime.Now.AddDays(-1), DateTime.Now.AddDays(7), 8, "Optimize deployment strategies for microservices in Kubernetes."),

                // Integration & API Issues (Category 11) - Pattern: 573XX
                new SupportTicketData(57363, "Integration Problems", null, "Integration", "Medium", "Open", "Casey Kim", "Alyndra Nexus", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(3), 14, "Integration Problems"),
                new SupportTicketData(57364, "Third-party API Failures", 57363, "Integration", "Critical", "Escalated", "Taylor Morgan", "Alyndra Nexus", DateTime.Now.AddDays(-4), DateTime.Now.AddHours(4), 8, "Payment gateway API (Stripe) hitting rate limits frequently."),
                new SupportTicketData(57365, "Webhook Configuration", 57363, "Integration", "High", "In Progress", "Riley Patel", "Alyndra Nexus", DateTime.Now.AddDays(-3), DateTime.Now.AddDays(1), 10, "Set up secure webhooks for GitHub repository events."),
                new SupportTicketData(57366, "Data Synchronization Issues", 57363, "Integration", "Medium", "Open", "Alex Rivera", "Alyndra Nexus", DateTime.Now.AddDays(-2), DateTime.Now.AddDays(4), 12, "Nightly sync between CRM and ERP systems failing intermittently."),
                new SupportTicketData(57367, "OAuth Authentication Setup", 57363, "Integration", "Low", "Resolved", "Jordan Lee", "Alyndra Nexus", DateTime.Now.AddDays(-1), DateTime.Now.AddDays(6), 6, "Configure OAuth 2.0 flow for seamless Google login integration."),

                // Database Management (Category 12) - Pattern: 573XX
                new SupportTicketData(57368, "Database Management Issues", null, "Database", "High", "Open", "Alex Rivera", "Vyrnax Data", DateTime.Now.AddDays(-4), DateTime.Now.AddDays(1), 16, "Database Management Issues"),
                new SupportTicketData(57369, "Index Optimization", 57368, "Database", "Medium", "In Progress", "Jordan Lee", "Vyrnax Data", DateTime.Now.AddDays(-3), DateTime.Now.AddDays(2), 8, "Rebuild fragmented indexes on the high-traffic customer table."),
                new SupportTicketData(57370, "Backup Corruption Recovery", 57368, "Database", "Critical", "Escalated", "Casey Kim", "Vyrnax Data", DateTime.Now.AddDays(-2), DateTime.Now.AddHours(6), 20, "Recover database from a corrupted backup file and restore integrity.")
            };
            return tickets;
        }
    }
}