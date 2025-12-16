#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

namespace Virtualdata
{

    public class SelfReferenceData
    {
        public static List<SelfReferenceData> tree = new List<SelfReferenceData>();
        public int TaskID { get; set; }
        public string? TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String? Progress { get; set; }
        public String? Priority { get; set; }
        public int Duration { get; set; }
        public int? ParentItem { get; set; }
        public bool? IsParent { get; set; }
        public SelfReferenceData() { }
        public static List<SelfReferenceData> GetTree()
        {
            if (tree.Count == 0)
            {
                int root = -1;
                for (var t = 1; t <= 10000; t++)
                {
                    int duration = (t % 2 == 0) ? 52 : (t % 5 == 0) ? 14 : (t % 3 == 0) ? 25 : 34;
                    string math = (t % 3) == 0 ? "High" : (t % 2) == 0 ? "Release Breaker" : "Critical";
                    string progr = (t % 3) == 0 ? "Started" : (t % 2) == 0 ? "Open" : "In Progress";
                    root++;
                    int rootItem = tree.Count + root + 1;
                    tree.Add(new SelfReferenceData() { TaskID = rootItem, TaskName = "Parent task " + rootItem.ToString(), StartDate = new DateTime(2021, 06, 07), EndDate = new DateTime(2023, 08, 25), IsParent = true, ParentItem = null, Progress = progr, Priority = math, Duration = duration});
                    int parent = tree.Count;
                    for (var c = 0; c < 2; c++)
                    {
                        root++;
                        string val = ((parent + c + 1) % 3 == 0) ? "Low" : "Critical";
                        int parn = parent + c + 1;
                        progr = (t % 3) == 0 ? "In Progress" : (t % 2) == 0 ? "Open" : "Validated";
                        int iD = tree.Count + root + 1;
                        tree.Add(new SelfReferenceData() { TaskID = iD, TaskName = "Child task " + iD.ToString(), StartDate = new DateTime(2021, 06, 07), EndDate = new DateTime(2023, 08, 25), IsParent = (((parent + c + 1) % 3) == 0), ParentItem = rootItem, Progress = progr, Priority = val, Duration = duration });
                        if ((((parent + c + 1) % 3) == 0))
                        {
                            int immParent = tree.Count;
                            for (var s = 0; s < 2; s++)
                            {
                                root++;
                                string Prior = (immParent % 2 == 0) ? "Validated" : "Normal";
                                tree.Add(new SelfReferenceData() { TaskID = tree.Count + root + 1, TaskName = "Sub task " + (tree.Count + root + 1).ToString(), StartDate = new DateTime(2021, 06, 07), EndDate = new DateTime(2023, 08, 25), IsParent = false, ParentItem = iD, Progress = (immParent % 2 == 0) ? "In Progress" : "Closed", Priority = Prior, Duration = duration });
                            }
                        }
                    }
                }
            }
            return tree;
        }
    }
    public class VirtualData
    {
        // Keep Id/ParentId mapping like the first sample
        public int TaskID { get; set; }
        public int? ParentID { get; set; }

        public string? ResourceId { get; set; }
        public string? Name { get; set; }
        public string? ServiceFamily { get; set; }
        public string? Status { get; set; }
        public string? Region { get; set; }
        public string? ResourceGroup { get; set; }
        public string? Owner { get; set; }
        public string? Environment { get; set; }
        public int MonthlyCost { get; set; }
        public int Cpu { get; set; }
        public int Memory { get; set; }
        public int Disk { get; set; }
        public int NetworkMbps { get; set; }
        public int RequestsPerSec { get; set; }
        public int ErrorRatePpm { get; set; }
        public int StorageGb { get; set; }
        public int InstanceCount { get; set; }
        public int UptimeDays { get; set; }
        public int TagsCount { get; set; }
        public int ComplianceScore { get; set; }
        public int Priority { get; set; }
        public int SecurityFindings { get; set; }

        public static List<VirtualData> GetTreeVirtualData()
        {
            string[] Names = new string[]
            {
        "Production West US - Resource Group",
        "Production East US - Resource Group",
        "Staging West US - Resource Group",
        "Development East US - Resource Group",
        "Analytics EU West - Resource Group",
        "Security Global - Resource Group",
        "Finance EU Central - Resource Group",
        "Marketing US East - Resource Group",
        "Sales Asia Pacific - Resource Group",
        "Shared Core - Resource Group",
        "API Server 01",
        "API Server 02",
        "Web Server 01",
        "Web Server 02",
        "Batch Worker 01",
        "ETL Worker 01",
        "ETL Worker 02",
        "Redis Cache 01",
        "Redis Cache 02",
        "Background Worker 01",
        "PostgreSQL Primary",
        "PostgreSQL Replica",
        "MySQL Orders",
        "SQL Server BI",
        "MongoDB Catalog",
        "Redis Session Store",
        "Cosmos DB User Profile",
        "Analytics Warehouse",
        "Time Series Metrics DB",
        "Secrets Vault",
        "Logs Archive Storage",
        "Daily Backups Storage",
        "Images CDN Storage",
        "Data Lake Raw Zone",
        "Data Lake Curated Zone",
        "Temporary Scratch Storage",
        "CI Artifacts Storage",
        "Shared Documents Storage",
        "Export Dumps Storage",
        "ML Models Storage",
        "Core Hub Virtual Network",
        "Applications Spoke Virtual Network",
        "Data Spoke Virtual Network",
        "Frontend Subnet",
        "Backend Subnet",
        "Data Services Subnet",
        "Frontend Network Security Group",
        "Backend Network Security Group",
        "Data Network Security Group",
        "Perimeter Firewall",
        "Production Kubernetes Cluster",
        "Staging Kubernetes Cluster",
        "Analytics Kubernetes Cluster",
        "System Node Pool",
        "General Node Pool",
        "GPU Node Pool",
        "Apps Namespace",
        "Operations Namespace",
        "Observability Namespace",
        "Ingress Gateway",
        "Public Web Load Balancer",
        "Internal API Load Balancer",
        "Frontend Application Gateway",
        "Backend Application Gateway",
        "Core API Gateway",
        "Service Mesh Gateway",
        "Edge Gateway",
        "Global Traffic Manager",
        "Private Link Endpoint",
        "NAT Gateway",
        "Image Resize Function",
        "Data Transform Function",
        "Webhook Handler Function",
        "Scheduled Cleanup Function",
        "ETL Trigger Function",
        "PDF Generator Function",
        "Notification Dispatcher Function",
        "Thumbnail Generator Function",
        "CSV Import Function",
        "Anomaly Detector Function",
        "Web Portal Application",
        "Admin Console Application",
        "Partner API Service",
        "Customer API Service",
        "Mobile Backend Service",
        "Campaign Service",
        "Notification Service",
        "Payment Service",
        "Reporting Service",
        "Search Service",
        "Log Analytics Workspace",
        "Metrics Workspace",
        "Alert Rules Collection",
        "Uptime Probes",
        "APM Insights",
        "Grafana Dashboard",
        "Prometheus Server",
        "Trace Collector",
        "Synthetic Tests Suite",
        "SIEM Platform"
            };

            string[] Types = new[] { "VM", "Database", "Storage", "Network", "Kubernetes", "Gateway", "Serverless", "Application", "Monitoring", "Security" };
            string[] Families = new[] { "Compute", "Data", "Storage", "Networking", "Containers", "Gateway", "Serverless", "Application", "Observability", "Security" };
            string[] Statuses = new[] { "Running", "Stopped", "Degraded", "Maintenance" };
            string[] Regions = new[] { "West US", "East US", "EU West", "EU Central", "Asia Pacific", "South America", "Canada Central", "Australia East" };
            string[] Groups = new[] { "RG-Production", "RG-Staging", "RG-Development", "RG-Shared", "RG-Analytics", "RG-Security", "RG-Finance", "RG-Apps" };
            string[] Owners = new[] { "Alice", "Bob", "Carlos", "Diana", "Ethan", "Fatima", "Gina", "Hiro", "Ivan", "Julia" };
            string[] Envs = new[] { "Production", "Staging", "Development" };

            List<VirtualData> DataCollection = new List<VirtualData>();
            var RecordID = 1220;

            for (var i = 1; i <= 2000; i++)
            {
                var nameIndex = (i % 100);

                var parent = new VirtualData()
                {
                    TaskID = ++RecordID,
                    ParentID = null,
                    ResourceId = Names[nameIndex],
                    Name = Types[i % Types.Length],
                    ServiceFamily = Families[i % Families.Length],
                    Status = Statuses[i % Statuses.Length],
                    Region = Regions[i % Regions.Length],
                    ResourceGroup = Groups[i % Groups.Length],
                    Owner = Owners[i % Owners.Length],
                    Environment = Envs[i % Envs.Length],
                    StorageGb = (i % 2 == 0) ? 410 + 2 : (i % 5 == 0) ? 410 + 1 : 410 + 45,
                    NetworkMbps = (i % 2 == 0) ? 67 + 2 : (i % 5 == 0) ? 67 + 1 : 67 + 6,
                    MonthlyCost = (i % 2 == 0) ? 100 + 2 : (i % 5 == 0) ? 100 + 1 : 100 + 12,
                    ErrorRatePpm = (i % 2 == 0) ? 35 + 2 : (i % 5 == 0) ? 24 + 1 : 45 + 12,
                    RequestsPerSec = (i % 2 == 0) ? 46 + 2 : (i % 5 == 0) ? 46 + 1 : 64 + 6,
                    TagsCount = (i % 2 == 0) ? 67 + 2 : (i % 5 == 0) ? 67 + 1 : 67 + 6,
                    InstanceCount = (i % 2 == 0) ? 2 + 2 : (i % 5 == 0) ? 1 + 1 : 1 + 6,
                    UptimeDays = (i % 2 == 0) ? 46 + 2 : (i % 5 == 0) ? 46 + 1 : 64 + 6,
                    Cpu = (i % 2 == 0) ? 210 + 23 : (i % 5 == 0) ? 210 + 12 : 210 + 621,
                    Memory = (i % 2 == 0) ? 300 + 533 : (i % 5 == 0) ? 300 + 321 : 300 + 699,
                    Disk = (i % 2 == 0) ? 400 + 232 : (i % 5 == 0) ? 400 + 153 : 400 + 342,
                    SecurityFindings = (i % 2 == 0) ? 40 + 12 : (i % 5 == 0) ? 40 + 24 : 40 + 25,
                    ComplianceScore = ((i % 2 == 0) ? 1000 + 112 : (i % 5 == 0) ? 1000 + 153 : 1000 + 412) % 101,
                    Priority = (i % 5) + 1
                };
                DataCollection.Add(parent);

                for (var j = 1; j <= 4; j++)
                {
                    var childIndex = ((i + j) % 100);
                    DataCollection.Add(new VirtualData()
                    {
                        TaskID = ++RecordID,
                        ParentID = parent.TaskID,
                        ResourceId = Names[childIndex],
                        Name = Types[j % Types.Length],
                        ServiceFamily = Families[(i + j) % Families.Length],
                        Status = Statuses[(i + j) % Statuses.Length],
                        Region = Regions[(i + j) % Regions.Length],
                        ResourceGroup = Groups[(i + j) % Groups.Length],
                        Owner = Owners[(i + j) % Owners.Length],
                        Environment = Envs[(i + j) % Envs.Length],
                        StorageGb = (j % 3 == 0) ? 410 + (j + 2) : (j % 4 == 0) ? 410 + (j + 1) : 410 + (j + 14),
                        NetworkMbps = (j % 3 == 0) ? 67 + (j + 2) : (j % 4 == 0) ? 67 + (j + 1) : 67 + (j + 7),
                        MonthlyCost = (j % 3 == 0) ? 76 + (j + 2) : (j % 4 == 0) ? 23 + (j + 1) : 45 + (j + 7),
                        ErrorRatePpm = (j % 3 == 0) ? 87 + (j + 2) : (j % 4 == 0) ? 87 + (j + 1) : 87 + (j + 12),
                        RequestsPerSec = (j % 3 == 0) ? 54 + (j + 2) : (j % 4 == 0) ? 54 + (j + 1) : 54 + (j + 12),
                        TagsCount = (j % 3 == 0) ? 280 + (j + 2) : (j % 4 == 0) ? 280 + (j + 1) : 280 + (j + 12),
                        InstanceCount = (j % 3 == 0) ? 12 + (j + 2) : (j % 4 == 0) ? 12 + (j + 1) : 12 + (j + 12),
                        UptimeDays = (j % 3 == 0) ? 54 + (j + 2) : (j % 4 == 0) ? 53 + (j + 1) : 23 + (j + 12),
                        Cpu = (j % 3 == 0) ? 210 + (j + 2) : (j % 4 == 0) ? 237 + (j + 1) : 290 + (j + 12),
                        Memory = (j % 3 == 0) ? 300 + (j + 2) : (j % 4 == 0) ? 300 + (j + 1) : 300 + (j + 12),
                        Disk = (j % 3 == 0) ? 400 + (j + 2) : (j % 4 == 0) ? 400 + (j + 1) : 400 + (j + 12),
                        SecurityFindings = (j % 3 == 0) ? 40 + (j + 2) : (j % 4 == 0) ? 40 + (j + 1) : 40 + (j + 12),
                        ComplianceScore = ((j % 3 == 0) ? 1003 + (j + 2) : (j % 4 == 0) ? 1100 + (j + 1) : 1000 + (j + 12)) % 101,
                        Priority = ((i + j) % 5) + 1
                    });
                }
            }

            return DataCollection;
        }
    }
}
