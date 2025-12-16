#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using ObservableCollectionProperties;
using System;
using System.Collections.ObjectModel;

namespace ObservableCollection
{
    public class SupportTicketService
    {
        // Generates a collection of support tickets for demonstration purposes.
        public static ObservableCollection<SupportTicketData> GetSupportTickets()
        {
            var tickets = new ObservableCollection<SupportTicketData>
            {
                // Server Infrastructure Issues (Category 1) - Pattern: 573XX
                new SupportTicketData(57301, "Server Infrastructure Issues", null, "Technical", "High", "In Progress", "John Smith", "Zorath Industries", DateTime.Now.AddDays(-15), DateTime.Now.AddHours(-1), 16),
                new SupportTicketData(57302, "Email Service Down", 57301, "Technical", "Critical", "Open", "John Smith", "Zorath Industries", DateTime.Now.AddDays(-12), DateTime.Now.AddHours(2), 4),
                new SupportTicketData(57303, "Database Connection Issues", 57301, "Technical", "High", "In Progress", "Sarah Johnson", "Zorath Industries", DateTime.Now.AddDays(-11), DateTime.Now.AddHours(6), 8),
                new SupportTicketData(57304, "Load Balancer Configuration", 57301, "Technical", "Medium", "Resolved", "John Smith", "Zorath Industries", DateTime.Now.AddDays(-10), DateTime.Now.AddDays(1), 6),
                new SupportTicketData(57305, "DNS Resolution Problems", 57301, "Technical", "High", "Open", "Mike Wilson", "Zorath Industries", DateTime.Now.AddDays(-9), DateTime.Now.AddDays(1), 5),
                new SupportTicketData(57306, "CDN Performance Issues", 57301, "Technical", "Medium", "In Progress", "Lisa Brown", "Zorath Industries", DateTime.Now.AddDays(-8), DateTime.Now.AddDays(2), 10),
                
                // Application Bug Reports (Category 2) - Pattern: 573XX
                new SupportTicketData(57307, "Application Bug Reports", null, "Software", "Medium", "Open", "Mike Wilson", "Keldrix Systems", DateTime.Now.AddDays(-14), DateTime.Now.AddDays(1), 12),
                new SupportTicketData(57308, "Login Authentication Error", 57307, "Software", "High", "Escalated", "Mike Wilson", "Keldrix Systems", DateTime.Now.AddDays(-13), DateTime.Now.AddHours(4), 6),
                new SupportTicketData(57309, "Data Export Functionality", 57307, "Software", "Low", "Open", "Lisa Brown", "Keldrix Systems", DateTime.Now.AddDays(-12), DateTime.Now.AddDays(3), 4),
                new SupportTicketData(57310, "UI Rendering Issues", 57307, "Software", "Medium", "In Progress", "Mike Wilson", "Keldrix Systems", DateTime.Now.AddDays(-11), DateTime.Now.AddDays(2), 8),
                new SupportTicketData(57311, "API Integration Problems", 57307, "Software", "Critical", "Open", "Tom Davis", "Keldrix Systems", DateTime.Now.AddDays(-10), DateTime.Now.AddHours(12), 15),
                new SupportTicketData(57312, "File Upload Memory Leak", 57307, "Software", "High", "In Progress", "Sarah Johnson", "Keldrix Systems", DateTime.Now.AddDays(-9), DateTime.Now.AddDays(1), 12),
                new SupportTicketData(57313, "Session Timeout Bug", 57307, "Software", "Medium", "Resolved", "Lisa Brown", "Keldrix Systems", DateTime.Now.AddDays(-8), DateTime.Now.AddDays(3), 7),
                
                // Network Connectivity Problems (Category 3) - Pattern: 573XX
                new SupportTicketData(57314, "Network Connectivity Problems", null, "Network", "Medium", "Open", "Tom Davis", "Quorvex Networks", DateTime.Now.AddDays(-13), DateTime.Now.AddDays(1), 8),
                new SupportTicketData(57315, "VPN Connection Timeout", 57314, "Network", "Medium", "In Progress", "Tom Davis", "Quorvex Networks", DateTime.Now.AddDays(-12), DateTime.Now.AddHours(8), 3),
                new SupportTicketData(57316, "Firewall Configuration", 57314, "Network", "Low", "Resolved", "John Smith", "Quorvex Networks", DateTime.Now.AddDays(-11), DateTime.Now.AddDays(2), 2),
                new SupportTicketData(57317, "WiFi Access Point Issues", 57314, "Network", "High", "Open", "Tom Davis", "Quorvex Networks", DateTime.Now.AddDays(-10), DateTime.Now.AddHours(12), 4),
                new SupportTicketData(57318, "Router Configuration Error", 57314, "Network", "Critical", "Escalated", "Mike Wilson", "Quorvex Networks", DateTime.Now.AddDays(-9), DateTime.Now.AddHours(6), 8),
                new SupportTicketData(57319, "Bandwidth Optimization", 57314, "Network", "Medium", "In Progress", "Sarah Johnson", "Quorvex Networks", DateTime.Now.AddDays(-8), DateTime.Now.AddDays(4), 6),
                
                // User Training & Support Requests (Category 4) - Pattern: 573XX
                new SupportTicketData(57320, "User Training Requests", null, "Support", "Low", "Open", "Sarah Johnson", "Mirath News", DateTime.Now.AddDays(-12), DateTime.Now.AddDays(5), 20),
                new SupportTicketData(57321, "Password Reset Issues", 57320, "Support", "Medium", "Resolved", "Sarah Johnson", "Mirath News", DateTime.Now.AddDays(-11), DateTime.Now.AddDays(1), 1),
                new SupportTicketData(57322, "Feature Request Training", 57320, "Support", "Low", "Open", "Lisa Brown", "Mirath News", DateTime.Now.AddDays(-10), DateTime.Now.AddDays(7), 8),
                new SupportTicketData(57323, "New Employee Onboarding", 57320, "Support", "Medium", "In Progress", "Sarah Johnson", "Mirath News", DateTime.Now.AddDays(-9), DateTime.Now.AddDays(3), 12),
                new SupportTicketData(57324, "System Access Training", 57320, "Support", "Low", "Open", "Tom Davis", "Mirath News", DateTime.Now.AddDays(-8), DateTime.Now.AddDays(5), 4),
                new SupportTicketData(57325, "Advanced Features Workshop", 57320, "Support", "Medium", "In Progress", "Mike Wilson", "Mirath News", DateTime.Now.AddDays(-7), DateTime.Now.AddDays(2), 16),
                
                // Hardware Maintenance (Category 5) - Pattern: 573XX
                new SupportTicketData(57326, "Hardware Maintenance", null, "Hardware", "Medium", "Open", "Mike Wilson", "Fluxor Hardware", DateTime.Now.AddDays(-11), DateTime.Now.AddDays(2), 16),
                new SupportTicketData(57327, "Printer Configuration", 57326, "Hardware", "Low", "Open", "Tom Davis", "Fluxor Hardware", DateTime.Now.AddDays(-10), DateTime.Now.AddDays(1), 2),
                new SupportTicketData(57328, "Server Memory Upgrade", 57326, "Hardware", "High", "In Progress", "Mike Wilson", "Fluxor Hardware", DateTime.Now.AddDays(-9), DateTime.Now.AddHours(12), 8),
                new SupportTicketData(57329, "Workstation Replacement", 57326, "Hardware", "Medium", "Closed", "Lisa Brown", "Fluxor Hardware", DateTime.Now.AddDays(-8), DateTime.Now.AddDays(4), 6),
                new SupportTicketData(57330, "UPS Battery Replacement", 57326, "Hardware", "High", "Open", "John Smith", "Fluxor Hardware", DateTime.Now.AddDays(-7), DateTime.Now.AddHours(24), 4),
                new SupportTicketData(57331, "Network Switch Upgrade", 57326, "Hardware", "Critical", "In Progress", "Sarah Johnson", "Fluxor Hardware", DateTime.Now.AddDays(-6), DateTime.Now.AddHours(8), 12),
                new SupportTicketData(57332, "Monitor Calibration", 57326, "Hardware", "Low", "Resolved", "Tom Davis", "Fluxor Hardware", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(3), 2),
                
                // Security Vulnerabilities (Category 6) - Pattern: 573XX
                new SupportTicketData(57333, "Security Vulnerabilities", null, "Security", "Critical", "Open", "John Smith", "Lumithar Mobility", DateTime.Now.AddDays(-10), DateTime.Now.AddHours(6), 24),
                new SupportTicketData(57334, "SSL Certificate Renewal", 57333, "Security", "High", "In Progress", "Sarah Johnson", "Lumithar Mobility", DateTime.Now.AddDays(-9), DateTime.Now.AddHours(8), 4),
                new SupportTicketData(57335, "Access Control Review", 57333, "Security", "Medium", "Open", "Mike Wilson", "Lumithar Mobility", DateTime.Now.AddDays(-8), DateTime.Now.AddDays(5), 16),
                new SupportTicketData(57336, "Penetration Test Findings", 57333, "Security", "Critical", "Escalated", "Lisa Brown", "Lumithar Mobility", DateTime.Now.AddDays(-7), DateTime.Now.AddHours(4), 20),
                new SupportTicketData(57337, "Two-Factor Auth Setup", 57333, "Security", "High", "In Progress", "Tom Davis", "Lumithar Mobility", DateTime.Now.AddDays(-6), DateTime.Now.AddDays(1), 8),
                new SupportTicketData(57338, "Compliance Audit Issues", 57333, "Security", "Medium", "Open", "John Smith", "Lumithar Mobility", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(7), 14),
                
                // Performance Optimization (Category 7) - Pattern: 573XX
                new SupportTicketData(57339, "Performance Optimization", null, "Performance", "High", "Open", "Lisa Brown", "Thrylon Dynamics", DateTime.Now.AddDays(-9), DateTime.Now.AddDays(1), 20),
                new SupportTicketData(57340, "Query Optimization", 57339, "Performance", "High", "In Progress", "Tom Davis", "Thrylon Dynamics", DateTime.Now.AddDays(-8), DateTime.Now.AddHours(10), 12),
                new SupportTicketData(57341, "Caching Implementation", 57339, "Performance", "Medium", "Open", "Lisa Brown", "Thrylon Dynamics", DateTime.Now.AddDays(-7), DateTime.Now.AddDays(3), 8),
                new SupportTicketData(57342, "Memory Usage Analysis", 57339, "Performance", "High", "In Progress", "Mike Wilson", "Thrylon Dynamics", DateTime.Now.AddDays(-6), DateTime.Now.AddHours(16), 15),
                new SupportTicketData(57343, "Load Testing Setup", 57339, "Performance", "Medium", "Open", "Sarah Johnson", "Thrylon Dynamics", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(2), 10),
                new SupportTicketData(57344, "CDN Configuration", 57339, "Performance", "Low", "Resolved", "John Smith", "Thrylon Dynamics", DateTime.Now.AddDays(-4), DateTime.Now.AddDays(5), 6),
                
                // Backup & Recovery Systems (Category 8) - Pattern: 573XX
                new SupportTicketData(57345, "Backup System Issues", null, "Backup", "High", "Open", "John Smith", "Resilvault Storage", DateTime.Now.AddDays(-8), DateTime.Now.AddHours(4), 14),
                new SupportTicketData(57346, "Daily Backup Failure", 57345, "Backup", "Critical", "Escalated", "Sarah Johnson", "Resilvault Storage", DateTime.Now.AddDays(-7), DateTime.Now.AddHours(2), 6),
                new SupportTicketData(57347, "Recovery Testing", 57345, "Backup", "Medium", "Open", "Mike Wilson", "Resilvault Storage", DateTime.Now.AddDays(-6), DateTime.Now.AddDays(2), 10),
                new SupportTicketData(57348, "Backup Storage Expansion", 57345, "Backup", "High", "In Progress", "Lisa Brown", "Resilvault Storage", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(1), 12),
                new SupportTicketData(57349, "Archive Policy Update", 57345, "Backup", "Medium", "Open", "Tom Davis", "Resilvault Storage", DateTime.Now.AddDays(-4), DateTime.Now.AddDays(3), 8),
                new SupportTicketData(57350, "Disaster Recovery Plan", 57345, "Backup", "Critical", "In Progress", "John Smith", "Resilvault Storage", DateTime.Now.AddDays(-3), DateTime.Now.AddHours(12), 20),
                
                // Mobile Application Issues (Category 9) - Pattern: 573XX
                new SupportTicketData(57351, "Mobile App Issues", null, "Mobile", "High", "Open", "Tom Davis", "Vexarion mobile", DateTime.Now.AddDays(-7), DateTime.Now.AddDays(8), 16),
                new SupportTicketData(57352, "iOS App Crashes", 57351, "Mobile", "Critical", "Escalated", "Sarah Johnson", "Vexarion mobile", DateTime.Now.AddDays(-6), DateTime.Now.AddHours(6), 10),
                new SupportTicketData(57353, "Android Push Notifications", 57351, "Mobile", "Medium", "In Progress", "Mike Wilson", "Vexarion mobile", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(2), 8),
                new SupportTicketData(57354, "App Store Deployment", 57351, "Mobile", "High", "Open", "Lisa Brown", "Vexarion mobile", DateTime.Now.AddDays(-4), DateTime.Now.AddDays(1), 12),
                new SupportTicketData(57355, "Offline Sync Issues", 57351, "Mobile", "Medium", "In Progress", "Tom Davis", "Vexarion mobile", DateTime.Now.AddDays(-3), DateTime.Now.AddDays(4), 14),
                new SupportTicketData(57356, "Mobile Performance Tuning", 57351, "Mobile", "Low", "Open", "John Smith", "Vexarion mobile", DateTime.Now.AddDays(-2), DateTime.Now.AddDays(6), 6),
                
                // Cloud Infrastructure (Category 10) - Pattern: 573XX
                new SupportTicketData(57357, "Cloud Infrastructure Issues", null, "Cloud", "High", "Open", "Sarah Johnson", "Elyndor Cloud", DateTime.Now.AddDays(-6), DateTime.Now.AddDays(2), 18),
                new SupportTicketData(57358, "AWS Lambda Timeouts", 57357, "Cloud", "Critical", "In Progress", "Mike Wilson", "Elyndor Cloud", DateTime.Now.AddDays(-5), DateTime.Now.AddHours(8), 10),
                new SupportTicketData(57359, "S3 Bucket Configuration", 57357, "Cloud", "Medium", "Open", "Lisa Brown", "Elyndor Cloud", DateTime.Now.AddDays(-4), DateTime.Now.AddDays(3), 6),
                new SupportTicketData(57360, "Auto-scaling Issues", 57357, "Cloud", "High", "Escalated", "Tom Davis", "Elyndor Cloud", DateTime.Now.AddDays(-3), DateTime.Now.AddHours(12), 15),
                new SupportTicketData(57361, "Container Orchestration", 57357, "Cloud", "Medium", "In Progress", "John Smith", "Elyndor Cloud", DateTime.Now.AddDays(-2), DateTime.Now.AddDays(5), 12),
                new SupportTicketData(57362, "Kubernetes Deployment", 57357, "Cloud", "Low", "Open", "Sarah Johnson", "Elyndor Cloud", DateTime.Now.AddDays(-1), DateTime.Now.AddDays(7), 8),
                
                // Integration & API Issues (Category 11) - Pattern: 573XX
                new SupportTicketData(57363, "Integration Problems", null, "Integration", "Medium", "Open", "Mike Wilson", "Alyndra Nexus", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(3), 14),
                new SupportTicketData(57364, "Third-party API Failures", 57363, "Integration", "Critical", "Escalated", "Lisa Brown", "Alyndra Nexus", DateTime.Now.AddDays(-4), DateTime.Now.AddHours(4), 8),
                new SupportTicketData(57365, "Webhook Configuration", 57363, "Integration", "High", "In Progress", "Tom Davis", "Alyndra Nexus", DateTime.Now.AddDays(-3), DateTime.Now.AddDays(1), 10),
                new SupportTicketData(57366, "Data Synchronization Issues", 57363, "Integration", "Medium", "Open", "John Smith", "Alyndra Nexus", DateTime.Now.AddDays(-2), DateTime.Now.AddDays(4), 12),
                new SupportTicketData(57367, "OAuth Authentication Setup", 57363, "Integration", "Low", "Resolved", "Sarah Johnson", "Alyndra Nexus", DateTime.Now.AddDays(-1), DateTime.Now.AddDays(6), 6),
                
                // Database Management (Category 12) - Pattern: 573XX
                new SupportTicketData(57368, "Database Management Issues", null, "Database", "High", "Open", "John Smith", "Vyrnax Data", DateTime.Now.AddDays(-4), DateTime.Now.AddDays(1), 16),
                new SupportTicketData(57369, "Index Optimization", 57368, "Database", "Medium", "In Progress", "Sarah Johnson", "Vyrnax Data", DateTime.Now.AddDays(-3), DateTime.Now.AddDays(2), 8),
                new SupportTicketData(57370, "Backup Corruption Recovery", 57368, "Database", "Critical", "Escalated", "Mike Wilson", "Vyrnax Data", DateTime.Now.AddDays(-2), DateTime.Now.AddHours(6), 20)
            };
            return tickets;
        }
    }
}