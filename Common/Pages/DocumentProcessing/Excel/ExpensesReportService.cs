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
using System.Globalization;
using System.IO;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class ExpensesReportService
    {
        /// <summary>
        /// Create a simple Excel document
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream ExpensesReportXlsIO()
        {
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
			    
			    //Set the default version
                application.DefaultVersion = ExcelVersion.Excel2016;
			    
                #region Generate Excel
                // Creating new workbook
                IWorkbook workbook = application.Workbooks.Create(1);
                IWorksheet sheet1 = workbook.Worksheets[0];
                sheet1.Name = "Budget";
                sheet1.IsGridLinesVisible = false;
                sheet1.EnableSheetCalculations();
			    
                sheet1.Range[1, 1].ColumnWidth = 19.86;
                sheet1.Range[1, 2].ColumnWidth = 14.38;
                sheet1.Range[1, 3].ColumnWidth = 12.98;
                sheet1.Range[1, 4].ColumnWidth = 12.08;
                sheet1.Range[1, 5].ColumnWidth = 8.82;
                sheet1.Range["A1:A18"].RowHeight = 20.2;
			    
                //Adding cell style.               
                IStyle style1 = workbook.Styles.Add("style1");
                style1.Color = Syncfusion.Drawing.Color.FromArgb(217, 225, 242);
                style1.HorizontalAlignment = ExcelHAlign.HAlignLeft;
                style1.VerticalAlignment = ExcelVAlign.VAlignCenter;
                style1.Font.Bold = true;
			    
                IStyle style2 = workbook.Styles.Add("style2");
                style2.Color = Syncfusion.Drawing.Color.FromArgb(142, 169, 219);
                style2.VerticalAlignment = ExcelVAlign.VAlignCenter;
                style2.NumberFormat = "[Red]($#,###)";
                style2.Font.Bold = true;
			    
                sheet1.Range["A10"].CellStyle = style1;
                sheet1.Range["B10:D10"].CellStyle.Color = Syncfusion.Drawing.Color.FromArgb(217, 225, 242);
                sheet1.Range["B10:D10"].HorizontalAlignment = ExcelHAlign.HAlignRight;
                sheet1.Range["B10:D10"].VerticalAlignment = ExcelVAlign.VAlignCenter;
                sheet1.Range["B10:D10"].CellStyle.Font.Bold = true;
			    
                sheet1.Range["A11:A17"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                sheet1.Range["A11:D17"].Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;
                sheet1.Range["A11:D17"].Borders[ExcelBordersIndex.EdgeBottom].Color = ExcelKnownColors.Grey_25_percent;
			    
                sheet1.Range["D18"].CellStyle = style2;
                sheet1.Range["D18"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                sheet1.Range["A18:C18"].CellStyle.Color = Syncfusion.Drawing.Color.FromArgb(142, 169, 219);
                sheet1.Range["A18:C18"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                sheet1.Range["A18:C18"].CellStyle.Font.Bold = true;
                sheet1.Range["A18:C18"].NumberFormat = "$#,###";
			    
                sheet1.Range[10, 1].Text = "Category";
                sheet1.Range[10, 2].Text = "Expected cost";
                sheet1.Range[10, 3].Text = "Actual Cost";
                sheet1.Range[10, 4].Text = "Difference";
                sheet1.Range[11, 1].Text = "Venue";
                sheet1.Range[12, 1].Text = "Seating & Decor";
                sheet1.Range[13, 1].Text = "Technical team";
                sheet1.Range[14, 1].Text = "Performers";
                sheet1.Range[15, 1].Text = "Performer\'s transport";
                sheet1.Range[16, 1].Text = "Performer\'s stay";
                sheet1.Range[17, 1].Text = "Marketing";
                sheet1.Range[18, 1].Text = "Total";
			    
                sheet1.Range["B11:D17"].NumberFormat = "$#,###";
                sheet1.Range["D11"].NumberFormat = "[Red]($#,###)";
                sheet1.Range["D12"].NumberFormat = "[Red]($#,###)";
                sheet1.Range["D14"].NumberFormat = "[Red]($#,###)";
			    
                sheet1.Range["B11"].Number = 16250;
                sheet1.Range["B12"].Number = 1600;
                sheet1.Range["B13"].Number = 1000;
                sheet1.Range["B14"].Number = 12400;
                sheet1.Range["B15"].Number = 3000;
                sheet1.Range["B16"].Number = 4500;
                sheet1.Range["B17"].Number = 3000;
                sheet1.Range["B18"].Formula = "=SUM(B11:B17)";
			    
                sheet1.Range["C11"].Number = 17500;
                sheet1.Range["C12"].Number = 1828;
                sheet1.Range["C13"].Number = 800;
                sheet1.Range["C14"].Number = 14000;
                sheet1.Range["C15"].Number = 2600;
                sheet1.Range["C16"].Number = 4464;
                sheet1.Range["C17"].Number = 2700;
                sheet1.Range["C18"].Formula = "=SUM(C11:C17)";
			    
                sheet1.Range["D11"].Formula = "=IF(C11>B11,C11-B11,B11-C11)";
                sheet1.Range["D12"].Formula = "=IF(C12>B12,C12-B12,B12-C12)";
                sheet1.Range["D13"].Formula = "=IF(C13>B13,C13-B13,B13-C13)";
                sheet1.Range["D14"].Formula = "=IF(C14>B14,C14-B14,B14-C14)";
                sheet1.Range["D15"].Formula = "=IF(C15>B15,C15-B15,B15-C15)";
                sheet1.Range["D16"].Formula = "=IF(C16>B16,C16-B16,B16-C16)";
                sheet1.Range["D17"].Formula = "=IF(C17>B17,C17-B17,B17-C17)";
                sheet1.Range["D18"].Formula = "=IF(C18>B18,C18-B18,B18-C18)";
			    
                IChartShape chart = sheet1.Charts.Add();
                chart.ChartType = ExcelChartType.Pie;
                chart.DataRange = sheet1.Range["A11:B17"];
                chart.IsSeriesInRows = false;
                chart.ChartTitle = "Event Expenses";
                chart.ChartTitleArea.Bold = true;
                chart.ChartTitleArea.Size = 16;
                chart.TopRow = 1;
                chart.BottomRow = 10;
                chart.LeftColumn = 1;
                chart.RightColumn = 5;
                chart.ChartArea.Border.LinePattern = ExcelChartLinePattern.None;
                #endregion

                workbook.Version = ExcelVersion.Excel2016;
                //Save the document as a stream and return the stream
                using (MemoryStream stream = new MemoryStream())
                {
                    //Save the created Excel document to MemoryStream
                    workbook.SaveAs(stream);
                    return stream;
                }                
            }
        }
    }
}