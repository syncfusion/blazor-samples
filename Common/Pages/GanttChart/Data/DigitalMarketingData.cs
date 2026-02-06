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
    public class DigitalMarketingData
    {
        public class LineChartModel
        {
            public string X { get; set; } = string.Empty;
            public double Y { get; set; }
        }

        public class BarChartModel
        {
            public string? Month { get; set; }
            public double Revenue { get; set; }
        }

        public class Statistics
        {
            public string? Activity { get; set; }
            public double Impressions { get; set; }
        }

        public class TaskInfoModel
        {
            public int Id { get; set; }
            public string Activity { get; set; } = string.Empty;
            public DateTime? StartDate { get; set; }
            public string? Duration { get; set; }
            public int Progress { get; set; }
            public string? Predecessor { get; set; }
            public int? ParentId { get; set; }
            public string Metrics { get; set; } = string.Empty;
            public string AudienceReach { get; set; } = string.Empty;
            public string Improvement { get; set; } = string.Empty;
            public double? Budget { get; set; }
            public string Channels { get; set; } = string.Empty;
            public int? Year { get; set; }
            public string Month { get; set; } = string.Empty;
            public int Impressions { get; set; }
            public double ConversionRate { get; set; }
            public double Revenue { get; set; }
        }
        public class HolidayModel
        {
            public int Id { get; set; }
            public string? HolidayName { get; set; }
            public DateTime Date { get; set; }
        }
        internal static List<TaskInfoModel> DigitalMarketCollection => new List<TaskInfoModel>()
        {
            new TaskInfoModel { Id = 1, Activity = "SEO", Progress = 50, Impressions = 210000, ConversionRate = 0.375, Revenue = 26000.0 },
            new TaskInfoModel { Id = 2, Activity = "Keyword research & on-page SEO", Progress = 95, ParentId = 1, AudienceReach = "Organic Reach: 10,000", Improvement = "+10%", Impressions = 95000, ConversionRate = 0.375, Revenue = 12000.0 },
            new TaskInfoModel { Id = 3, Activity = "Keyword analysis", StartDate = new DateTime(2024, 1, 1), Duration = "30 days", Progress = 100, ParentId = 2, Metrics = "Keywords Analyzed: 100", AudienceReach = "Organic Reach: 10,000", Improvement = "+10%", Impressions = 50000, ConversionRate = 0.4, Revenue = 5000.0 },
            new TaskInfoModel { Id = 4, Activity = "On-Page optimization", StartDate = new DateTime(2024, 2, 1), Duration = "28 days", Progress = 90, ParentId = 2, Predecessor = "3", Metrics = "Pages Optimized: 20", AudienceReach = "Organic Reach: 10,000", Improvement = "+10%", Impressions = 45000, ConversionRate = 0.35, Revenue = 7000.0 },
            new TaskInfoModel { Id = 5, Activity = "Backlink building", Progress = 70, ParentId = 1, AudienceReach = "Organic Reach: 12,000", Improvement = "+20%", Impressions = 115000, ConversionRate = 0.37, Revenue = 14000.0 },
            new TaskInfoModel { Id = 6, Activity = "Outreach to bloggers", StartDate = new DateTime(2024, 3, 1), Duration = "32 days", Progress = 80, ParentId = 5, Metrics = "Emails Sent: 100", AudienceReach = "Organic Reach: 12,000", Improvement = "+20%", Impressions = 55000, ConversionRate = 0.38, Revenue = 6000.0 },
            new TaskInfoModel { Id = 7, Activity = "Guest posting", StartDate = new DateTime(2024, 3, 21), Duration = "33 days", Progress = 60, ParentId = 5, Predecessor = "6", Metrics = "Guest Posts: 5", AudienceReach = "Organic Reach: 12,000", Improvement = "+20%", Impressions = 60000, ConversionRate = 0.37, Revenue = 8000.0 },
            new TaskInfoModel { Id = 8, Activity = "Social media marketing", Progress = 60, Impressions = 95000, ConversionRate = 0.4225, Revenue = 18000.0 },
            new TaskInfoModel { Id = 9, Activity = "Content calendar creation", Progress = 85, ParentId = 8, AudienceReach = "Social Media Reach: 5,000", Improvement = "+5%", Impressions = 42000, ConversionRate = 0.455, Revenue = 7000.0 },
            new TaskInfoModel { Id = 10, Activity = "Content planning", StartDate = new DateTime(2024, 4, 1), Duration = "23 days", Progress = 100, ParentId = 9, Metrics = "Posts Planned: 20", AudienceReach = "Social Media Reach: 5,000", Improvement = "+5%", Impressions = 20000, ConversionRate = 0.45, Revenue = 3000.0 },
            new TaskInfoModel { Id = 11, Activity = "Content design", StartDate = new DateTime(2024, 4, 11), Duration = "28 days", Progress = 70, ParentId = 9, Predecessor = "10", Metrics = "Visuals Created: 20", AudienceReach = "Social Media Reach: 5,000", Improvement = "+5%", Impressions = 22000, ConversionRate = 0.42, Revenue = 4000.0 },
            new TaskInfoModel { Id = 12, Activity = "Engagement campaign", Progress = 70, ParentId = 8, AudienceReach = "Social Media Reach: 6,000", Improvement = "+20%", Impressions = 53000, ConversionRate = 0.39, Revenue = 11000.0 },
            new TaskInfoModel { Id = 13, Activity = "Hashtag campaign", StartDate = new DateTime(2024, 5, 1), Duration = "31 days", Progress = 100, ParentId = 12, Metrics = "Hashtags Created: 10", AudienceReach = "Social Media Reach: 6,000", Improvement = "+20%", Impressions = 25000, ConversionRate = 0.4, Revenue = 5000.0 },
            new TaskInfoModel { Id = 14, Activity = "Influencer collaboration", StartDate = new DateTime(2024, 5, 11), Duration = "35 days", Progress = 80, ParentId = 12, Predecessor = "13", Metrics = "Collaborations: 3", AudienceReach = "Social Media Reach: 6,000", Improvement = "+20%", Impressions = 28000, ConversionRate = 0.38, Revenue = 6000.0 },
            new TaskInfoModel { Id = 15, Activity = "Content marketing", Progress = 60, Impressions = 71000, ConversionRate = 0.515, Revenue = 9000.0 },
            new TaskInfoModel { Id = 16, Activity = "Blog post series launch", Progress = 95, ParentId = 15, AudienceReach = "Blog Reach: 4,000", Improvement = "+15%", Impressions = 38000, ConversionRate = 0.49, Revenue = 5000.0 },
            new TaskInfoModel { Id = 17, Activity = "Topic research", StartDate = new DateTime(2024, 6, 1), Duration = "26 days", Progress = 100, ParentId = 16, Metrics = "Topics Researched: 10", AudienceReach = "Blog Reach: 4,000", Improvement = "+15%", Impressions = 18000, ConversionRate = 0.5, Revenue = 2000.0 },
            new TaskInfoModel { Id = 18, Activity = "Writing & editing", StartDate = new DateTime(2024, 6, 16), Duration = "29 days", Progress = 90, ParentId = 16, Predecessor = "17", Metrics = "Articles Written: 10", AudienceReach = "Blog Reach: 4,000", Improvement = "+15%", Impressions = 20000, ConversionRate = 0.48, Revenue = 3000.0 },
            new TaskInfoModel { Id = 19, Activity = "Video content creation", Progress = 85, ParentId = 15, AudienceReach = "Video Reach: 3,000", Improvement = "+10%", Impressions = 33000, ConversionRate = 0.54, Revenue = 4000.0 },
            new TaskInfoModel { Id = 20, Activity = "Script writing", StartDate = new DateTime(2024, 7, 1), Duration = "20 days", Progress = 100, ParentId = 19, Metrics = "Scripts Written: 5", AudienceReach = "Video Reach: 3,000", Improvement = "+10%", Impressions = 15000, ConversionRate = 0.55, Revenue = 1500.0 },
            new TaskInfoModel { Id = 21, Activity = "Video production", StartDate = new DateTime(2024, 7, 11), Duration = "36 days", Progress = 80, ParentId = 19, Predecessor = "20", Metrics = "Videos Produced: 5", AudienceReach = "Video Reach: 3,000", Improvement = "+10%", Impressions = 18000, ConversionRate = 0.53, Revenue = 2500.0 },
            new TaskInfoModel { Id = 22, Activity = "Email marketing", Progress = 70, Impressions = 60000, ConversionRate = 0.3125, Revenue = 11000.0 },
            new TaskInfoModel { Id = 23, Activity = "Newsletter campaign", Progress = 95, ParentId = 22, AudienceReach = "Open Rate: 25%", Improvement = "+5%", Impressions = 26000, ConversionRate = 0.335, Revenue = 4500.0 },
            new TaskInfoModel { Id = 24, Activity = "Content creation", StartDate = new DateTime(2024, 8, 1), Duration = "19 days", Progress = 100, ParentId = 23, Metrics = "Newsletters Created: 4", AudienceReach = "Open Rate: 25%", Improvement = "+5%", Impressions = 12000, ConversionRate = 0.35, Revenue = 2000.0 },
            new TaskInfoModel { Id = 25, Activity = "Segmentation & targeting", StartDate = new DateTime(2024, 8, 20), Duration = "22 days", Progress = 90, ParentId = 23, Predecessor = "24", Metrics = "Segments Targeted: 5", AudienceReach = "Open Rate: 25%", Improvement = "+5%", Impressions = 14000, ConversionRate = 0.33, Revenue = 2500.0 },
            new TaskInfoModel { Id = 26, Activity = "Lead generation campaign", Progress = 80, ParentId = 22, AudienceReach = "Leads Generated: 500", Improvement = "+15%", Impressions = 40000, ConversionRate = 0.29, Revenue = 7500.0 },
            new TaskInfoModel { Id = 27, Activity = "Landing page optimization", StartDate = new DateTime(2024, 9, 1), Duration = "25 days", Progress = 100, ParentId = 26, Metrics = "Pages Optimized: 3", AudienceReach = "Leads Generated: 500", Improvement = "+15%", Impressions = 15000, ConversionRate = 0.3, Revenue = 3000.0 },
            new TaskInfoModel { Id = 28, Activity = "A/B testing", StartDate = new DateTime(2024, 9, 26), Duration = "24 days", Progress = 90, ParentId = 26, Predecessor = "27", Metrics = "Tests Conducted: 5", AudienceReach = "Leads Generated: 500", Improvement = "+15%", Impressions = 20000, ConversionRate = 0.28, Revenue = 4500.0 },
            new TaskInfoModel { Id = 29, Activity = "PPC advertising", Progress = 65, Impressions = 55000, ConversionRate = 0.225, Revenue = 9000.0 },
            new TaskInfoModel { Id = 30, Activity = "Campaign setup", Progress = 100, ParentId = 29, AudienceReach = "Click-through Rate: 10%", Improvement = "+5%", Impressions = 25000, ConversionRate = 0.24, Revenue = 4000.0 },
            new TaskInfoModel { Id = 31, Activity = "Ad creation", StartDate = new DateTime(2024, 10, 1), Duration = "18 days", Progress = 100, ParentId = 30, Metrics = "Ads Created: 10", AudienceReach = "Click-through Rate: 10%", Improvement = "+5%", Impressions = 12000, ConversionRate = 0.23, Revenue = 2000.0 },
            new TaskInfoModel { Id = 32, Activity = "Campaign management", StartDate = new DateTime(2024, 10, 19), Duration = "21 days", Progress = 80, ParentId = 30, Predecessor = "31", Metrics = "Campaigns Managed: 5", AudienceReach = "Click-through Rate: 10%", Improvement = "+5%", Impressions = 15000, ConversionRate = 0.22, Revenue = 3000.0 },
            new TaskInfoModel { Id = 33, Activity = "Analytics & reporting", Progress = 75, Impressions = 48000, ConversionRate = 0.15, Revenue = 8000.0 },
            new TaskInfoModel { Id = 34, Activity = "Data analysis", Progress = 100, StartDate=new DateTime(2023,10,26), Duration="5 days", ParentId = 33, Metrics = "Data Points Analyzed: 500", AudienceReach = "Traffic Sources Analyzed: 5", Improvement = "+10%", Impressions = 25000, ConversionRate = 0.18, Revenue = 3000.0 },
            new TaskInfoModel { Id = 35, Activity = "Reporting", StartDate = new DateTime(2023, 11, 1), Duration = "15 days", Progress = 90, ParentId = 33, Predecessor = "34", Metrics = "Reports Generated: 20", AudienceReach = "Traffic Sources Analyzed: 5", Improvement = "+10%", Impressions = 12000, ConversionRate = 0.16, Revenue = 2000.0 },
            new TaskInfoModel { Id = 36, Activity = "Strategy review", StartDate = new DateTime(2023, 11, 16), Duration = "10 days", Progress = 80, ParentId = 33, Predecessor = "35", Metrics = "Strategies Reviewed: 3", AudienceReach = "Traffic Sources Analyzed: 5", Improvement = "+10%", Impressions = 13000, ConversionRate = 0.14, Revenue = 3000.0 },
            new TaskInfoModel { Id = 37, Activity = "Performance review", Progress = 85, Impressions = 38000, ConversionRate = 0.32, Revenue = 7000.0 },
            new TaskInfoModel { Id = 38, Activity = "Campaign performance", StartDate = new DateTime(2024, 12, 1), Duration = "12 days", Progress = 100, ParentId = 37, Metrics = "Campaigns Evaluated: 5", AudienceReach = "ROI: 20%", Improvement = "+15%", Impressions = 18000, ConversionRate = 0.3, Revenue = 3000.0 },
            new TaskInfoModel { Id = 39, Activity = "ROI analysis", StartDate = new DateTime(2024, 12, 13), Duration = "8 days", Progress = 90, ParentId = 37, Predecessor = "38", Metrics = "ROI Calculated: 5", AudienceReach = "ROI: 20%", Improvement = "+15%", Impressions = 9000, ConversionRate = 0.28, Revenue = 2000.0 },
            new TaskInfoModel { Id = 40, Activity = "Strategy adjustment", StartDate = new DateTime(2024, 12, 21), Duration = "7 days", Progress = 80, ParentId = 37, Predecessor = "39", Metrics = "Strategies Adjusted: 3", AudienceReach = "ROI: 20%", Improvement = "+15%", Impressions = 10000, ConversionRate = 0.26, Revenue = 2000.0 }
        };

        internal static List<HolidayModel> HolidayCollection = new List<HolidayModel>()
        {
           new HolidayModel(){ Id = 10, HolidayName = "Labor Day", Date = new DateTime(2024, 09, 02) },
           new HolidayModel(){ Id = 11, HolidayName = "Fall Break", Date = new DateTime(2024, 10, 14) },
           new HolidayModel(){ Id = 12, HolidayName = "Thanksgiving Break", Date = new DateTime(2024, 11, 28) },
           new HolidayModel(){ Id = 13, HolidayName = "Winter Break Start", Date = new DateTime(2024, 12, 18) },      
        };
    }
}
