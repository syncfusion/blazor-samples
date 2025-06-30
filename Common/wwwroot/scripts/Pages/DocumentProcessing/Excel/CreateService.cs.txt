#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
    public class CreateService
    {
        /// <summary>
        /// Create a simple Excel document
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream CreateXlsIO(string version)
        {
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Step 2 : Instantiate the excel application object
                IApplication application = excelEngine.Excel;

                //Set the default version
                if (version == "XLSX")
                    application.DefaultVersion = ExcelVersion.Excel2016;
                else
                    application.DefaultVersion = ExcelVersion.Excel97to2003;

                //Creating new workbook
                IWorkbook workbook = application.Workbooks.Create(3);
                IWorksheet sheet = workbook.Worksheets[0];

                #region Generate Excel
                sheet.Range["A2"].ColumnWidth = 30;
                sheet.Range["B2"].ColumnWidth = 30;
                sheet.Range["C2"].ColumnWidth = 30;
                sheet.Range["D2"].ColumnWidth = 30;

                sheet.Range["A2:D2"].Merge(true);

                //Inserting sample text into the first cell of the first sheet
                sheet.Range["A2"].Text = "EXPENSE REPORT";
                sheet.Range["A2"].CellStyle.Font.FontName = "Verdana";
                sheet.Range["A2"].CellStyle.Font.Bold = true;
                sheet.Range["A2"].CellStyle.Font.Size = 28;
                sheet.Range["A2"].CellStyle.Font.RGBColor = Color.FromArgb(0, 0, 112, 192);
                sheet.Range["A2"].HorizontalAlignment = ExcelHAlign.HAlignCenter;

                sheet.Range["A4"].Text = "Employee";
                sheet.Range["B4"].Text = "Roger Federer";
                sheet.Range["A4:B7"].CellStyle.Font.FontName = "Verdana";
                sheet.Range["A4:B7"].CellStyle.Font.Bold = true;
                sheet.Range["A4:B7"].CellStyle.Font.Size = 11;
                sheet.Range["A4:A7"].CellStyle.Font.RGBColor = Color.FromArgb(0, 128, 128, 128);
                sheet.Range["A4:A7"].HorizontalAlignment = ExcelHAlign.HAlignLeft;
                sheet.Range["B4:B7"].CellStyle.Font.RGBColor = Color.FromArgb(0, 174, 170, 170);
                sheet.Range["B4:B7"].HorizontalAlignment = ExcelHAlign.HAlignRight;

                sheet.Range["A9:D20"].CellStyle.Font.FontName = "Verdana";
                sheet.Range["A9:D20"].CellStyle.Font.Size = 11;

                sheet.Range["A5"].Text = "Department";
                sheet.Range["B5"].Text = "Administration";

                sheet.Range["A6"].Text = "Week Ending";
                sheet.Range["B6"].NumberFormat = "m/d/yyyy";
                sheet.Range["B6"].DateTime = DateTime.Parse("10/20/2012", CultureInfo.InvariantCulture);

                sheet.Range["A7"].Text = "Mileage Rate";
                sheet.Range["B7"].NumberFormat = "$#,##0.00";
                sheet.Range["B7"].Number = 0.70;

                sheet.Range["A10"].Text = "Miles Driven";
                sheet.Range["A11"].Text = "Miles Reimbursement";
                sheet.Range["A12"].Text = "Parking and Tolls";
                sheet.Range["A13"].Text = "Auto Rental";
                sheet.Range["A14"].Text = "Lodging";
                sheet.Range["A15"].Text = "Breakfast";
                sheet.Range["A16"].Text = "Lunch";
                sheet.Range["A17"].Text = "Dinner";
                sheet.Range["A18"].Text = "Snacks";
                sheet.Range["A19"].Text = "Others";
                sheet.Range["A20"].Text = "Total";
                sheet.Range["A20:D20"].CellStyle.Color = Color.FromArgb(0, 0, 112, 192);
                sheet.Range["A20:D20"].CellStyle.Font.Color = ExcelKnownColors.White;
                sheet.Range["A20:D20"].CellStyle.Font.Bold = true;

                IStyle style = sheet["B9:D9"].CellStyle;
                style.VerticalAlignment = ExcelVAlign.VAlignCenter;
                style.HorizontalAlignment = ExcelHAlign.HAlignRight;
                style.Color = Color.FromArgb(0, 0, 112, 192);
                style.Font.Bold = true;
                style.Font.Color = ExcelKnownColors.White;

                sheet.Range["A9"].Text = "Expenses";
                sheet.Range["A9"].CellStyle.Color = Color.FromArgb(0, 0, 112, 192);
                sheet.Range["A9"].CellStyle.Font.Color = ExcelKnownColors.White;
                sheet.Range["A9"].CellStyle.Font.Bold = true;
                sheet.Range["B9"].Text = "Day 1";
                sheet.Range["B10"].Number = 100;
                sheet.Range["B11"].NumberFormat = "$#,##0.00";
                sheet.Range["B11"].Formula = "=(B7*B10)";
                sheet.Range["B12"].NumberFormat = "$#,##0.00";
                sheet.Range["B12"].Number = 0;
                sheet.Range["B13"].NumberFormat = "$#,##0.00";
                sheet.Range["B13"].Number = 0;
                sheet.Range["B14"].NumberFormat = "$#,##0.00";
                sheet.Range["B14"].Number = 0;
                sheet.Range["B15"].NumberFormat = "$#,##0.00";
                sheet.Range["B15"].Number = 9;
                sheet.Range["B16"].NumberFormat = "$#,##0.00";
                sheet.Range["B16"].Number = 12;
                sheet.Range["B17"].NumberFormat = "$#,##0.00";
                sheet.Range["B17"].Number = 13;
                sheet.Range["B18"].NumberFormat = "$#,##0.00";
                sheet.Range["B18"].Number = 9.5;
                sheet.Range["B19"].NumberFormat = "$#,##0.00";
                sheet.Range["B19"].Number = 0;
                sheet.Range["B20"].NumberFormat = "$#,##0.00";
                sheet.Range["B20"].Formula = "=SUM(B11:B19)";

                sheet.Range["C9"].Text = "Day 2";
                sheet.Range["C10"].Number = 145;
                sheet.Range["C11"].NumberFormat = "$#,##0.00";
                sheet.Range["C11"].Formula = "=(B7*C10)";
                sheet.Range["C12"].NumberFormat = "$#,##0.00";
                sheet.Range["C12"].Number = 15;
                sheet.Range["C13"].NumberFormat = "$#,##0.00";
                sheet.Range["C13"].Number = 0;
                sheet.Range["C14"].NumberFormat = "$#,##0.00";
                sheet.Range["C14"].Number = 45;
                sheet.Range["C15"].NumberFormat = "$#,##0.00";
                sheet.Range["C15"].Number = 9;
                sheet.Range["C16"].NumberFormat = "$#,##0.00";
                sheet.Range["C16"].Number = 12;
                sheet.Range["C17"].NumberFormat = "$#,##0.00";
                sheet.Range["C17"].Number = 15;
                sheet.Range["C18"].NumberFormat = "$#,##0.00";
                sheet.Range["C18"].Number = 7;
                sheet.Range["C19"].NumberFormat = "$#,##0.00";
                sheet.Range["C19"].Number = 0;
                sheet.Range["C20"].NumberFormat = "$#,##0.00";
                sheet.Range["C20"].Formula = "=SUM(C11:C19)";

                sheet.Range["D9"].Text = "Day 3";
                sheet.Range["D10"].Number = 113;
                sheet.Range["D11"].NumberFormat = "$#,##0.00";
                sheet.Range["D11"].Formula = "=(B7*D10)";
                sheet.Range["D12"].NumberFormat = "$#,##0.00";
                sheet.Range["D12"].Number = 17;
                sheet.Range["D13"].NumberFormat = "$#,##0.00";
                sheet.Range["D13"].Number = 8;
                sheet.Range["D14"].NumberFormat = "$#,##0.00";
                sheet.Range["D14"].Number = 45;
                sheet.Range["D15"].NumberFormat = "$#,##0.00";
                sheet.Range["D15"].Number = 7;
                sheet.Range["D16"].NumberFormat = "$#,##0.00";
                sheet.Range["D16"].Number = 11;
                sheet.Range["D17"].NumberFormat = "$#,##0.00";
                sheet.Range["D17"].Number = 16;
                sheet.Range["D18"].NumberFormat = "$#,##0.00";
                sheet.Range["D18"].Number = 7;
                sheet.Range["D19"].NumberFormat = "$#,##0.00";
                sheet.Range["D19"].Number = 5;
                sheet.Range["D20"].NumberFormat = "$#,##0.00";
                sheet.Range["D20"].Formula = "=SUM(D11:D19)";
                #endregion

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