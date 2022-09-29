#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.Drawing;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class YearlySalesService
    {
        /// <summary>
        /// Create a simple Excel document
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream YearlySalesXlsIO()
        {
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
			    
			    application.DefaultVersion = ExcelVersion.Xlsx;

                //Create a workbook
                IWorkbook workbook = application.Workbooks.Create(1);
                IWorksheet sheet = workbook.Worksheets[0];
			    
                sheet.Name = "Sales Report";
			    
                sheet.IsGridLinesVisible = false;
                IWorksheet sheet2 = workbook.Worksheets.Create("Data");
                sheet.EnableSheetCalculations();
			    
                sheet.Range[1, 1, 1, 7].Merge();
                IRange range = sheet.Range["A1"];
			    
                range.RowHeight = 22.5;
                range.Text = "Yearly Sales";
                range.CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                range.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                range.CellStyle.Font.Bold = true;
                range.CellStyle.Font.Size = 14;
                range.CellStyle.Color = Syncfusion.Drawing.Color.FromArgb(155, 194, 230);
			    
                sheet.Range["A1"].ColumnWidth = 3.44;
                sheet.Range["B1"].ColumnWidth = 11.0;
                sheet.Range["C1"].ColumnWidth = 11.0;
                sheet.Range["D1"].ColumnWidth = 0.92;
                sheet.Range["E1"].ColumnWidth = 11.0;
                sheet.Range["F1"].ColumnWidth = 11.0;
                sheet.Range["G1"].ColumnWidth = 3.44;
			    
                sheet.Range[1, 1, 1, 7].Merge();
			    
                sheet.Range["A13"].RowHeight = 12;
                sheet.Range["A14"].RowHeight = 21;
                sheet.Range["A15"].RowHeight = 15;
                sheet.Range["A16"].RowHeight = 3;
                sheet.Range["A17"].RowHeight = 21;
                sheet.Range["A18"].RowHeight = 15;
                sheet.Range["A19"].RowHeight = 12;
			    
                IRange range5 = sheet.Range["B14:C14"];
                IRange range6 = sheet.Range["B15:C15"];
                IRange range7 = sheet.Range["B17:C17"];
                IRange range8 = sheet.Range["B18:C18"];
                IRange range9 = sheet.Range["E14:F14"];
                IRange range10 = sheet.Range["E15:F15"];
                IRange range11 = sheet.Range["E17:F17"];
                IRange range12 = sheet.Range["E18:F18"];
			    
                range5.Text = "$ 4.51 M";
                range9.Formula = "=Data!D14";
                range7.Formula = "=Data!C19";
                range11.Formula = "=Data!E14";
			    
                range5.Merge();
                range6.Merge();
                range7.Merge();
                range8.Merge();
                range9.Merge();
                range10.Merge();
                range11.Merge();
                range12.Merge();
			    
                List<IStyle> styles = CreateStyles(workbook);
			    
                range5.CellStyle = styles[0];
                range9.CellStyle = styles[1];
                range7.CellStyle = styles[2];
                range11.CellStyle = styles[3];
			    
                range6.CellStyle = styles[4];
                range6.Text = "Sales Amount";
                range10.CellStyle = styles[5];
                range10.Text = "Average Unit Price";
                range8.CellStyle = styles[6];
                range8.Text = "Gross Profit Margin";
                range12.CellStyle = styles[7];
                range12.Text = "Customer Count";
			    
                sheet2.Range["B1"].ColumnWidth = 23;
                sheet2.Range["C1"].ColumnWidth = 23;
                sheet2.Range["D1"].ColumnWidth = 10;
                sheet2.Range["E1"].ColumnWidth = 10;
			    
                sheet2.Range["A1"].Text = "Months";
                sheet2.Range["B1"].Text = "Internet Sales Amount";
                sheet2.Range["C1"].Text = "Reseller Sales Amount";
                sheet2.Range["D1"].Text = "Unit Price";
                sheet2.Range["E1"].Text = "Customers";
			    
			    
                sheet2.Range["A2"].Text = "Jan";
                sheet2.Range["A3"].Text = "Feb";
                sheet2.Range["A4"].Text = "Mar";
                sheet2.Range["A5"].Text = "Apr";
                sheet2.Range["A6"].Text = "May";
                sheet2.Range["A7"].Text = "June";
                sheet2.Range["A8"].Text = "Jul";
                sheet2.Range["A9"].Text = "Aug";
                sheet2.Range["A10"].Text = "Sep";
                sheet2.Range["A11"].Text = "Oct";
                sheet2.Range["A12"].Text = "Nov";
                sheet2.Range["A13"].Text = "Dec";
                sheet2.Range["A14"].Text = "Total";
			    
                sheet2.Range["B2"].Number = 226170;
                sheet2.Range["B3"].Number = 212259;
                sheet2.Range["B4"].Number = 181079;
                sheet2.Range["B5"].Number = 188809;
                sheet2.Range["B6"].Number = 198195;
                sheet2.Range["B7"].Number = 235524;
                sheet2.Range["B8"].Number = 185786;
                sheet2.Range["B9"].Number = 196745;
                sheet2.Range["B10"].Number = 164897;
                sheet2.Range["B11"].Number = 175673;
                sheet2.Range["B12"].Number = 212896;
                sheet2.Range["B13"].Number = 325634;
                sheet2.Range["B14"].Formula = "=SUM(B2:B13)";
			    
                sheet2.Range["C2"].Number = 170234;
                sheet2.Range["C3"].Number = 189456;
                sheet2.Range["C4"].Number = 168795;
                sheet2.Range["C5"].Number = 143567;
                sheet2.Range["C6"].Number = 163567;
                sheet2.Range["C7"].Number = 163546;
                sheet2.Range["C8"].Number = 143787;
                sheet2.Range["C9"].Number = 149898;
                sheet2.Range["C10"].Number = 153784;
                sheet2.Range["C11"].Number = 164289;
                sheet2.Range["C12"].Number = 172453;
                sheet2.Range["C13"].Number = 223430;
                sheet2.Range["C14"].Formula = "=SUM(C2:C13)";
			    
                sheet2.Range["D2"].Number = 202;
                sheet2.Range["D3"].Number = 204;
                sheet2.Range["D4"].Number = 191;
                sheet2.Range["D5"].Number = 223;
                sheet2.Range["D6"].Number = 203;
                sheet2.Range["D7"].Number = 185;
                sheet2.Range["D8"].Number = 198;
                sheet2.Range["D9"].Number = 196;
                sheet2.Range["D10"].Number = 220;
                sheet2.Range["D11"].Number = 218;
                sheet2.Range["D12"].Number = 299;
                sheet2.Range["D13"].Number = 185;
                sheet2.Range["D14"].Formula = "=AVERAGE(D2:D13)";
			    
                sheet2.Range["E2"].Number = 1861;
                sheet2.Range["E3"].Number = 1522;
                sheet2.Range["E4"].Number = 1410;
                sheet2.Range["E5"].Number = 1488;
                sheet2.Range["E6"].Number = 1781;
                sheet2.Range["E7"].Number = 2155;
                sheet2.Range["E8"].Number = 1657;
                sheet2.Range["E9"].Number = 1767;
                sheet2.Range["E10"].Number = 1448;
                sheet2.Range["E11"].Number = 1556;
                sheet2.Range["E12"].Number = 1928;
                sheet2.Range["E13"].Number = 2956;
                sheet2.Range["E14"].Formula = "=SUM(E2:E13)";
			    
                sheet2.Range["B17"].Text = "2018 Sales";
                sheet2.Range["B18"].Text = "2018 Sales";
                sheet2.Range["B19"].Text = "Gain %";
                sheet2.Range["C17"].Number = 3845634;
                sheet2.Range["C18"].Formula = "=B14+C14";
                sheet2.Range["C19"].Formula = "=(C18-C17)/10000000";
			    
                sheet2.Range["C19"].NumberFormat = "0.00%";
                sheet2.Range["C17:C18"].NumberFormat = "_($ #,##0.00";
                sheet2.Range["B2:D14"].NumberFormat = "_($ #,##0.00";
			    
			    
                sheet2.Range["A1:E1"].CellStyle.Color = Syncfusion.Drawing.Color.FromArgb(198, 224, 180);
                sheet2.Range["A1:E1"].CellStyle.Font.Bold = true;
                sheet2.Range["A14:E14"].CellStyle.Color = Syncfusion.Drawing.Color.FromArgb(198, 224, 180);
                sheet2.Range["A14:E14"].CellStyle.Font.Bold = true;
                sheet.Range["G30"].Text = ".";
			    
                #region Chart Creation
                IChartShape chart1 = sheet.Charts.Add();
                chart1.ChartType = ExcelChartType.Column_Stacked;
                chart1.DataRange = sheet2.Range["A1:B13"];
                chart1.IsSeriesInRows = false;
                chart1.Legend.Position = ExcelLegendPosition.Bottom;
                chart1.PrimaryValueAxis.NumberFormat = "$#,###";
                chart1.PrimaryValueAxis.HasMajorGridLines = false;
                chart1.TopRow = 2;
                chart1.BottomRow = 13;
                chart1.LeftColumn = 1;
                chart1.RightColumn = 8;
                chart1.ChartArea.Border.LinePattern = ExcelChartLinePattern.None;
                chart1.PrimaryCategoryAxis.TextRotationAngle = -45;
			    
                IChartShape chart2 = sheet.Charts.Add();
                chart2.ChartType = ExcelChartType.Line;
                chart2.DataRange = sheet2.Range["A1:C13"];
                chart2.IsSeriesInRows = false;
                chart2.ChartTitleArea.Bold = true;
                chart2.ChartTitleArea.Size = 11;
                chart2.ChartTitleArea.Color = ExcelKnownColors.Grey_80_percent;
                chart2.ChartTitleArea.Text = "Internet Sales vs Reseller Sales";
                chart2.Legend.Position = ExcelLegendPosition.Bottom;
                chart2.Legend.TextArea.Size = 9;
                chart2.Legend.TextArea.Color = ExcelKnownColors.Grey_80_percent;
                chart2.TopRow = 20;
                chart2.BottomRow = 32;
                chart2.LeftColumn = 1;
                chart2.RightColumn = 8;
                chart2.PrimaryValueAxis.NumberFormat = "$#,###";
                chart2.PrimaryValueAxis.HasMajorGridLines = false;
                chart2.ChartArea.Border.LinePattern = ExcelChartLinePattern.None;
                #endregion

                workbook.Version = ExcelVersion.Xlsx;
                sheet.Calculate();

                //Save the document as a stream and return the stream
                using (MemoryStream stream = new MemoryStream())
                {
                    //Save the created Excel document to MemoryStream
                    workbook.SaveAs(stream);
                    return stream;
                }                
            }
        }
        #region HelperMethods
        /// <summary>
        ///Create styles using workbook
        /// </summary>
        /// <param name="workbook">workbook used to create the styles</param>
        List<IStyle> CreateStyles(IWorkbook workbook)
        {
            IStyle style1 = workbook.Styles.Add("style1");
            style1.Color = Syncfusion.Drawing.Color.FromArgb(155, 194, 230);
            style1.Font.Size = 18;
            style1.Font.Bold = true;
            style1.NumberFormat = "$#,##0.00";
            style1.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            style1.VerticalAlignment = ExcelVAlign.VAlignCenter;
            style1.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
            style1.Borders[ExcelBordersIndex.EdgeTop].Color = ExcelKnownColors.Grey_25_percent;
            style1.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
            style1.Borders[ExcelBordersIndex.EdgeRight].Color = ExcelKnownColors.Grey_25_percent;
            style1.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
            style1.Borders[ExcelBordersIndex.EdgeLeft].Color = ExcelKnownColors.Grey_25_percent;


            IStyle style2 = workbook.Styles.Add("style2");
            style2.Color = Syncfusion.Drawing.Color.FromArgb(244, 176, 132);
            style2.Font.Size = 18;
            style2.Font.Bold = true;
            style2.NumberFormat = "$#,##0.00";
            style2.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            style2.VerticalAlignment = ExcelVAlign.VAlignCenter;
            style2.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
            style2.Borders[ExcelBordersIndex.EdgeTop].Color = ExcelKnownColors.Grey_25_percent;
            style2.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
            style2.Borders[ExcelBordersIndex.EdgeRight].Color = ExcelKnownColors.Grey_25_percent;
            style2.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
            style2.Borders[ExcelBordersIndex.EdgeLeft].Color = ExcelKnownColors.Grey_25_percent;

            IStyle style3 = workbook.Styles.Add("style3");
            style3.Color = Syncfusion.Drawing.Color.FromArgb(255, 217, 102);
            style3.Font.Size = 18;
            style3.Font.Bold = true;
            style3.NumberFormat = "0.00%";
            style3.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            style3.VerticalAlignment = ExcelVAlign.VAlignCenter;
            style3.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
            style3.Borders[ExcelBordersIndex.EdgeTop].Color = ExcelKnownColors.Grey_25_percent;
            style3.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
            style3.Borders[ExcelBordersIndex.EdgeRight].Color = ExcelKnownColors.Grey_25_percent;
            style3.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
            style3.Borders[ExcelBordersIndex.EdgeLeft].Color = ExcelKnownColors.Grey_25_percent;

            IStyle style4 = workbook.Styles.Add("style4");
            style4.Color = Syncfusion.Drawing.Color.FromArgb(169, 208, 142);
            style4.Font.Size = 18;
            style4.Font.Bold = true;
            style4.NumberFormat = "#,###";
            style4.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            style4.VerticalAlignment = ExcelVAlign.VAlignCenter;
            style4.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
            style4.Borders[ExcelBordersIndex.EdgeTop].Color = ExcelKnownColors.Grey_25_percent;
            style4.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
            style4.Borders[ExcelBordersIndex.EdgeRight].Color = ExcelKnownColors.Grey_25_percent;
            style4.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
            style4.Borders[ExcelBordersIndex.EdgeLeft].Color = ExcelKnownColors.Grey_25_percent;

            IStyle style5 = workbook.Styles.Add("style5");
            style5.Color = Syncfusion.Drawing.Color.FromArgb(155, 194, 230);
            style5.Font.Color = ExcelKnownColors.Grey_50_percent;
            style5.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            style5.VerticalAlignment = ExcelVAlign.VAlignCenter;
            style5.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
            style5.Borders[ExcelBordersIndex.EdgeBottom].Color = ExcelKnownColors.Grey_25_percent;
            style5.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
            style5.Borders[ExcelBordersIndex.EdgeRight].Color = ExcelKnownColors.Grey_25_percent;
            style5.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
            style5.Borders[ExcelBordersIndex.EdgeLeft].Color = ExcelKnownColors.Grey_25_percent;


            IStyle style6 = workbook.Styles.Add("style6");
            style6.Color = Syncfusion.Drawing.Color.FromArgb(244, 176, 132);
            style6.Font.Color = ExcelKnownColors.Grey_50_percent;
            style6.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            style6.VerticalAlignment = ExcelVAlign.VAlignCenter;
            style6.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
            style6.Borders[ExcelBordersIndex.EdgeBottom].Color = ExcelKnownColors.Grey_25_percent;
            style6.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
            style6.Borders[ExcelBordersIndex.EdgeRight].Color = ExcelKnownColors.Grey_25_percent;
            style6.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
            style6.Borders[ExcelBordersIndex.EdgeLeft].Color = ExcelKnownColors.Grey_25_percent;


            IStyle style7 = workbook.Styles.Add("style7");
            style7.Color = Syncfusion.Drawing.Color.FromArgb(255, 217, 102);
            style7.Font.Color = ExcelKnownColors.Grey_50_percent;
            style7.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            style7.VerticalAlignment = ExcelVAlign.VAlignCenter;
            style7.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
            style7.Borders[ExcelBordersIndex.EdgeBottom].Color = ExcelKnownColors.Grey_25_percent;
            style7.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
            style7.Borders[ExcelBordersIndex.EdgeRight].Color = ExcelKnownColors.Grey_25_percent;
            style7.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
            style7.Borders[ExcelBordersIndex.EdgeLeft].Color = ExcelKnownColors.Grey_25_percent;

            IStyle style8 = workbook.Styles.Add("style8");
            style8.Color = Syncfusion.Drawing.Color.FromArgb(169, 208, 142);
            style8.Font.Color = ExcelKnownColors.Grey_50_percent;
            style8.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            style8.VerticalAlignment = ExcelVAlign.VAlignCenter;
            style8.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
            style8.Borders[ExcelBordersIndex.EdgeBottom].Color = ExcelKnownColors.Grey_25_percent;
            style8.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
            style8.Borders[ExcelBordersIndex.EdgeRight].Color = ExcelKnownColors.Grey_25_percent;
            style8.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
            style8.Borders[ExcelBordersIndex.EdgeLeft].Color = ExcelKnownColors.Grey_25_percent;


            List<IStyle> styles = new List<IStyle>();
            styles.Add(style1);
            styles.Add(style2);
            styles.Add(style3);
            styles.Add(style4);
            styles.Add(style5);
            styles.Add(style6);
            styles.Add(style7);
            styles.Add(style8);

            return styles;

        }
        #endregion
    }
}