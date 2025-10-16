#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
namespace BlazorDemos.Pages.PivotView.PivotTable
{

    public class TemplateData
    {
        public string Sector { get; set; } = string.Empty;
        public int PowUnits { get; set; }
        public double ProCost { get; set; }
        public string EnerType { get; set; } = string.Empty;
        public string EneSource { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string Quarter { get; set; } = string.Empty;
        public string HalfYear { get; set; } = string.Empty;

        public static List<TemplateData> GetTemplateData()
        {
            List<TemplateData> templateData = new List<TemplateData>();
            {
                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 46, ProCost = 43, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });
                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 30, ProCost = 29, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });
                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 125, ProCost = 96, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });
                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 215, ProCost = 123, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });
                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 263, ProCost = 125, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });
                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 61, ProCost = 50, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });

                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 20, ProCost = 31, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 133, ProCost = 110, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 33, ProCost = 65, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 37, ProCost = 20, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 109, ProCost = 96, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 266, ProCost = 139, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 257, ProCost = 143, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 79, ProCost = 53, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 28, ProCost = 48, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 128, ProCost = 117, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 68, ProCost = 48, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 26, ProCost = 32, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 141, ProCost = 98, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 281, ProCost = 134, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 228, ProCost = 107, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 73, ProCost = 49, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 19, ProCost = 44, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 149, ProCost = 82, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 47, ProCost = 58, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 25, ProCost = 40, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 127, ProCost = 93, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 216, ProCost = 124, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 267, ProCost = 100, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 52, ProCost = 65, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 39, ProCost = 33, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 142, ProCost = 97, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 53, ProCost = 49, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 23, ProCost = 44, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 113, ProCost = 106, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 270, ProCost = 101, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 284, ProCost = 105, Year = "FY 2025", Quarter = "Q1 FY 2025", HalfYear = "H1 FY 2025" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 62, ProCost = 43, Year = "FY 2025", Quarter = "Q1 FY 2025", HalfYear = "H1 FY 2025" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 32, ProCost = 26, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 133, ProCost = 83, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 51, ProCost = 65, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 13, ProCost = 25, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 139, ProCost = 101, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 297, ProCost = 130, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 236, ProCost = 119, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 57, ProCost = 66, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 16, ProCost = 27, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 110, ProCost = 93, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 55, ProCost = 49, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 32, ProCost = 39, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 128, ProCost = 120, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 290, ProCost = 128, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 201, ProCost = 105, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 55, ProCost = 46, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 20, ProCost = 37, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 122, ProCost = 118, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 69, ProCost = 54, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 21, ProCost = 41, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 140, ProCost = 83, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 239, ProCost = 121, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 283, ProCost = 127, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 80, ProCost = 40, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 33, ProCost = 40, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 120, ProCost = 81, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 41, ProCost = 69, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 14, ProCost = 21, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 144, ProCost = 93, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 294, ProCost = 146, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 217, ProCost = 103, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 49, ProCost = 44, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 36, ProCost = 21, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 118, ProCost = 115, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 56, ProCost = 41, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 17, ProCost = 36, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 140, ProCost = 81, Year = "FY 2025", Quarter = "Q1 FY 2025", HalfYear = "H1 FY 2025" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 274, ProCost = 109, Year = "FY 2025", Quarter = "Q1 FY 2025", HalfYear = "H1 FY 2025" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 284, ProCost = 145, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 40, ProCost = 49, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 12, ProCost = 28, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 150, ProCost = 115, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 73, ProCost = 64, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 23, ProCost = 47, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 102, ProCost = 112, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 252, ProCost = 112, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 222, ProCost = 131, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 52, ProCost = 46, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 35, ProCost = 30, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 104, ProCost = 101, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 46, ProCost = 40, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 19, ProCost = 31, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 118, ProCost = 89, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 227, ProCost = 130, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 226, ProCost = 144, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 40, ProCost = 52, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 19, ProCost = 40, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 127, ProCost = 91, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 70, ProCost = 66, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 36, ProCost = 21, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 144, ProCost = 85, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 212, ProCost = 130, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 210, ProCost = 110, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 72, ProCost = 56, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 13, ProCost = 47, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 139, ProCost = 98, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 59, ProCost = 54, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 26, ProCost = 21, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 120, ProCost = 97, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 299, ProCost = 124, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 240, ProCost = 110, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 71, ProCost = 61, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 40, ProCost = 33, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 134, ProCost = 111, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 33, ProCost = 50, Year = "FY 2025", Quarter = "Q1 FY 2025", HalfYear = "H1 FY 2025" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 18, ProCost = 25, Year = "FY 2025", Quarter = "Q1 FY 2025", HalfYear = "H1 FY 2025" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 139, ProCost = 85, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 217, ProCost = 141, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 252, ProCost = 101, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 31, ProCost = 42, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 15, ProCost = 27, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 117, ProCost = 112, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 34, ProCost = 40, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 10, ProCost = 43, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 110, ProCost = 83, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 212, ProCost = 137, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 222, ProCost = 126, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 75, ProCost = 49, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 31, ProCost = 37, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 105, ProCost = 98, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 72, ProCost = 45, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 20, ProCost = 45, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 143, ProCost = 92, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 272, ProCost = 128, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 208, ProCost = 136, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 48, ProCost = 46, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 22, ProCost = 27, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 150, ProCost = 100, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 60, ProCost = 43, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 15, ProCost = 27, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 107, ProCost = 97, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 204, ProCost = 136, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 210, ProCost = 111, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 65, ProCost = 47, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 26, ProCost = 45, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 112, ProCost = 115, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 54, ProCost = 66, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 31, ProCost = 36, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 120, ProCost = 112, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 261, ProCost = 149, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 226, ProCost = 124, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 72, ProCost = 63, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 35, ProCost = 33, Year = "FY 2025", Quarter = "Q1 FY 2025", HalfYear = "H1 FY 2025" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 144, ProCost = 118, Year = "FY 2025", Quarter = "Q1 FY 2025", HalfYear = "H1 FY 2025" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 293, ProCost = 118, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 237, ProCost = 110, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 36, ProCost = 50, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 20, ProCost = 36, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 120, ProCost = 95, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 46, ProCost = 59, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 31, ProCost = 33, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 147, ProCost = 96, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 230, ProCost = 100, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 236, ProCost = 104, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 60, ProCost = 57, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 33, ProCost = 41, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 140, ProCost = 105, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 31, ProCost = 55, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 20, ProCost = 30, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 117, ProCost = 106, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 259, ProCost = 127, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 294, ProCost = 126, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 51, ProCost = 63, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 21, ProCost = 45, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 102, ProCost = 108, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 77, ProCost = 64, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 29, ProCost = 26, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 140, ProCost = 88, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 244, ProCost = 144, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 213, ProCost = 127, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 69, ProCost = 40, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 30, ProCost = 33, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 116, ProCost = 103, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 79, ProCost = 47, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 29, ProCost = 37, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 116, ProCost = 96, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 295, ProCost = 108, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 225, ProCost = 127, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 35, ProCost = 57, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 37, ProCost = 49, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 138, ProCost = 118, Year = "FY 2025", Quarter = "Q1 FY 2025", HalfYear = "H1 FY 2025" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 80, ProCost = 47, Year = "FY 2025", Quarter = "Q1 FY 2025", HalfYear = "H1 FY 2025" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 22, ProCost = 42, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 131, ProCost = 91, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 240, ProCost = 115, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 275, ProCost = 109, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 46, ProCost = 42, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 40, ProCost = 43, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 112, ProCost = 105, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 35, ProCost = 40, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 22, ProCost = 31, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 119, ProCost = 87, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 298, ProCost = 148, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 200, ProCost = 107, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 30, ProCost = 42, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 22, ProCost = 49, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 148, ProCost = 88, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 37, ProCost = 49, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 23, ProCost = 29, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 130, ProCost = 102, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 281, ProCost = 129, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 228, ProCost = 113, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 80, ProCost = 60, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 39, ProCost = 27, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 119, ProCost = 93, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 42, ProCost = 46, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 18, ProCost = 37, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 126, ProCost = 96, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 222, ProCost = 150, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 228, ProCost = 105, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 54, ProCost = 49, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 16, ProCost = 33, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 145, ProCost = 110, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 35, ProCost = 41, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 16, ProCost = 38, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 118, ProCost = 114, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 241, ProCost = 110, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 281, ProCost = 136, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 50, ProCost = 66, Year = "FY 2025", Quarter = "Q1 FY 2025", HalfYear = "H1 FY 2025" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 23, ProCost = 26, Year = "FY 2025", Quarter = "Q1 FY 2025", HalfYear = "H1 FY 2025" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 129, ProCost = 98, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 78, ProCost = 53, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 28, ProCost = 31, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 147, ProCost = 120, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 240, ProCost = 100, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 232, ProCost = 116, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 33, ProCost = 49, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 18, ProCost = 36, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 114, ProCost = 113, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 52, ProCost = 63, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 31, ProCost = 25, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 129, ProCost = 88, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 263, ProCost = 111, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 241, ProCost = 105, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 55, ProCost = 60, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 13, ProCost = 30, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 134, ProCost = 107, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Hydro-electric", PowUnits = 33, ProCost = 69, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Geo-thermal", PowUnits = 20, ProCost = 31, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Free Energy", EneSource = "Solar", PowUnits = 146, ProCost = 109, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Free Energy", EneSource = "Wind", PowUnits = 241, ProCost = 107, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Wood", PowUnits = 10, ProCost = 30, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 38, ProCost = 65, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 6, ProCost = 24, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 72, ProCost = 86, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 13, ProCost = 20, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 34, ProCost = 54, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 5, ProCost = 20, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Wood", PowUnits = 12, ProCost = 26, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 48, ProCost = 57, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 8, ProCost = 29, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 61, ProCost = 97, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 19, ProCost = 29, Year = "FY 2025", Quarter = "Q1 FY 2025", HalfYear = "H1 FY 2025" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 40, ProCost = 47, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 7, ProCost = 27, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Wood", PowUnits = 20, ProCost = 24, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 45, ProCost = 42, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 4, ProCost = 25, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 72, ProCost = 82, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 19, ProCost = 29, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 32, ProCost = 42, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 5, ProCost = 20, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Wood", PowUnits = 20, ProCost = 25, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 43, ProCost = 66, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 8, ProCost = 26, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 86, ProCost = 87, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 16, ProCost = 22, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 43, ProCost = 54, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 6, ProCost = 22, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Wood", PowUnits = 15, ProCost = 20, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 40, ProCost = 55, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 3, ProCost = 24, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 60, ProCost = 87, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 12, ProCost = 29, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 37, ProCost = 50, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 3, ProCost = 20, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Wood", PowUnits = 17, ProCost = 21, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 38, ProCost = 53, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 8, ProCost = 27, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 88, ProCost = 92, Year = "FY 2025", Quarter = "Q1 FY 2025", HalfYear = "H1 FY 2025" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 14, ProCost = 22, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 31, ProCost = 69, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 2, ProCost = 22, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Wood", PowUnits = 16, ProCost = 29, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 35, ProCost = 54, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 7, ProCost = 24, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 79, ProCost = 82, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 10, ProCost = 29, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 50, ProCost = 65, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 5, ProCost = 25, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Wood", PowUnits = 17, ProCost = 28, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 46, ProCost = 54, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 7, ProCost = 27, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 63, ProCost = 84, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 19, ProCost = 28, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 47, ProCost = 52, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 8, ProCost = 23, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Wood", PowUnits = 20, ProCost = 28, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 40, ProCost = 55, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 7, ProCost = 27, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 67, ProCost = 88, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 20, ProCost = 29, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 38, ProCost = 61, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 7, ProCost = 21, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Wood", PowUnits = 11, ProCost = 26, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 36, ProCost = 60, Year = "FY 2025", Quarter = "Q1 FY 2025", HalfYear = "H1 FY 2025" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 2, ProCost = 24, Year = "FY 2025", Quarter = "Q1 FY 2025", HalfYear = "H1 FY 2025" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 83, ProCost = 90, Year = "FY 2022", Quarter = "Q1 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 11, ProCost = 27, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 49, ProCost = 42, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 7, ProCost = 28, Year = "FY 2022", Quarter = "Q2 FY 2022", HalfYear = "H1 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Wood", PowUnits = 13, ProCost = 25, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 30, ProCost = 49, Year = "FY 2022", Quarter = "Q3 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 4, ProCost = 26, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 76, ProCost = 87, Year = "FY 2022", Quarter = "Q4 FY 2022", HalfYear = "H2 FY 2022" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 19, ProCost = 27, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 45, ProCost = 55, Year = "FY 2023", Quarter = "Q1 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 1, ProCost = 23, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Wood", PowUnits = 20, ProCost = 23, Year = "FY 2023", Quarter = "Q2 FY 2023", HalfYear = "H1 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 34, ProCost = 51, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 3, ProCost = 28, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 85, ProCost = 80, Year = "FY 2023", Quarter = "Q3 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 20, ProCost = 22, Year = "FY 2023", Quarter = "Q4 FY 2023", HalfYear = "H2 FY 2023" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 40, ProCost = 51, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 7, ProCost = 25, Year = "FY 2024", Quarter = "Q1 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Wood", PowUnits = 15, ProCost = 21, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 36, ProCost = 41, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 1, ProCost = 27, Year = "FY 2024", Quarter = "Q2 FY 2024", HalfYear = "H1 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 79, ProCost = 93, Year = "FY 2024", Quarter = "Q3 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Organic Waste", PowUnits = 11, ProCost = 28, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });


                templateData.Add(new TemplateData { Sector = "Public Sector", EnerType = "Biomass", EneSource = "Ethanol Fuel", PowUnits = 41, ProCost = 51, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });

                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Bio-diesel", PowUnits = 8, ProCost = 28, Year = "FY 2024", Quarter = "Q4 FY 2024", HalfYear = "H2 FY 2024" });
                templateData.Add(new TemplateData { Sector = "Private Sector", EnerType = "Biomass", EneSource = "Wood", PowUnits = 20, ProCost = 23, Year = "FY 2025", Quarter = "Q1 FY 2025", HalfYear = "H1 FY 2025" });


                return templateData;

            }
        }
    }
}