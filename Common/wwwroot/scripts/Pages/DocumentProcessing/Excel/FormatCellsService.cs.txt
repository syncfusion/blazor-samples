#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.Collections.Generic;
using Syncfusion.Drawing;
using Syncfusion.XlsIO;
using System;
using System.Globalization;
using System.IO;
using static BlazorDemos.Pages.Navigations.TreeView.LazyLoading;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class FormatCellsService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public FormatCellsService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create an Excel document with formatting applied to the cells
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream FormatCellsXlsIO(string version)
        {
            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Step 2 : Instantiate the excel application object
                IApplication application = excelEngine.Excel;

                //Set the default version
                if (version == "XLSX")
                    application.DefaultVersion = ExcelVersion.Xlsx;
                else
                    application.DefaultVersion = ExcelVersion.Excel97to2003;

                //A new workbook is created.[Equivalent to creating a new workbook in Microsoft Excel]
                //The new workbook will have 3 worksheets
                IWorkbook workbook = application.Workbooks.Create(3);

                //The first worksheet object in the worksheets collection is accessed
                IWorksheet sheet = workbook.Worksheets[0];
                sheet.IsGridLinesVisible = false;

                #region RTF
                //Insert Rich Text
                IRange range = sheet.Range["D3"];
                range.Text = "Employee Report";
                IRichTextString rtf = range.RichText;

                //Formatting the text
                IFont redFont = workbook.CreateFont();
                redFont.Size = 16;
                redFont.Bold = true;
                redFont.Italic = true;
                redFont.RGBColor = Color.FromArgb(0x82, 0x2e, 0x1b);
                rtf.SetFont(0, 14, redFont);
                #endregion

                #region Number Formatting
                sheet.Range["H24"].Number = 5000;
                sheet.Range["H24"].NumberFormat = "$#,##0.00";
                sheet.Range["H14"].NumberFormat = "dd/mm/yyyy";
                sheet.Range["H14"].DateTime = DateTime.Parse(" 8/3/1963", CultureInfo.InvariantCulture);
                sheet.Range["H16"].NumberFormat = "mm/dd/yyyy";
                sheet.Range["H16"].DateTime = DateTime.Parse(" 4/1/1992", CultureInfo.InvariantCulture);
                #endregion

                #region Alignment settings
                #region Text alignment
                sheet.Range["F10:F24"].HorizontalAlignment = ExcelHAlign.HAlignRight;
                sheet.Range["D3"].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                sheet.Range["H10:H24"].HorizontalAlignment = ExcelHAlign.HAlignLeft;
                sheet.Range["F10:F24"].VerticalAlignment = ExcelVAlign.VAlignCenter;
                #endregion

                #region Text Control
                sheet.Range["F27"].WrapText = true;
                sheet.Range["F27"].Text = "Antony Jose graduated from St. Andrews University, Scotland, with a BSC degree in 1976.  Upon joining the company as a sales representative in 1992, he spent 6 months in an orientation program at the Seattle office and then returned to his permanent post in London.  He was promoted to sales manager in March 1993.";
                #endregion

                #region Cell merging
                sheet.Range["F27:H28"].Merge();
                sheet.Range["D3:F3"].Merge();
                sheet.Range["B7:J8"].Merge();
                sheet.Range["F27"].RowHeight = 66;
                sheet.Range["H10:H24"].ColumnWidth = 25;
                sheet.Range["C10:D28"].Merge();
                sheet.Range["B10:C28"].ColumnWidth = 1;
                sheet.Range["E10:E28"].ColumnWidth = 5;
                sheet.Range["D10:D28"].ColumnWidth = 15;
                #endregion

                #region Text Direction
                sheet.Range["B7"].Text = "Antony Jose";
                sheet.Range["B7"].CellStyle.ReadingOrder = Syncfusion.XlsIO.ExcelReadingOrderType.LeftToRight;
                sheet.Range["B7"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignLeft;
                sheet.Range["B7"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                #endregion

                #region Text Indent
                sheet.Range["D7"].CellStyle.IndentLevel = 6;
                #endregion
                #endregion

                #region Font settings
                //Setting Font Type
                sheet.Range["F10:F24"].CellStyle.Font.FontName = "Arial";
                sheet.Range["D3"].CellStyle.Font.FontName = "Arial";
                sheet.Range["B7"].CellStyle.Font.FontName = "Arial";
                sheet.Range["B7"].CellStyle.Font.Size = 12f;
                sheet.Range["B7"].CellStyle.Font.Bold = true;

                //Setting Font Styles
                sheet.Range["F10:F24"].CellStyle.Font.Bold = true;
                sheet.Range["D3"].CellStyle.Font.Bold = true;

                //Setting Font Size
                sheet.Range["F10:F24"].CellStyle.Font.Size = 10;
                sheet.Range["D3"].CellStyle.Font.Size = 14;
                sheet.Range["F27:H28"].CellStyle.Font.Size = 9f;

                //Setting Font Color
                sheet.Range["B7"].CellStyle.Font.RGBColor = Color.White;
                sheet.Range["D28"].CellStyle.Font.RGBColor = Color.White;

                //Setting UnderLine 
                sheet.Range["D3"].CellStyle.Font.Underline = ExcelUnderline.Double;

                sheet.Range["F10"].Text = "Name";
                sheet.Range["F12"].Text = "Title";
                sheet.Range["F14"].Text = "Birth Date";
                sheet.Range["F16"].Text = "Hire date";
                sheet.Range["F18"].Text = "Home phone";
                sheet.Range["F20"].Text = "Extension";
                sheet.Range["F22"].Text = "Home address";
                sheet.Range["F24"].Text = "Salary";

                sheet.Range["H10"].Text = "Antony Jose";
                sheet.Range["H12"].Text = "Sales Manager";
                sheet.Range["H18"].Text = "(206) 555-3412";
                sheet.Range["H20"].Number = 3355;
                sheet.Range["H22"].Text = "722 Moss Bay Blvd";
                #endregion

                #region Insert Image
                sheet.Pictures.AddPicture(11, 4, fileDataValue["empid1.png"], 55, 65);
                #endregion

                #region Border setting
                sheet.Range["H10"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
                sheet.Range["H10"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
                sheet.Range["H10"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

                sheet.Range["H12"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
                sheet.Range["H12"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
                sheet.Range["H12"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

                sheet.Range["H14"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
                sheet.Range["H14"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
                sheet.Range["H14"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

                sheet.Range["H16"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
                sheet.Range["H16"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
                sheet.Range["H16"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

                sheet.Range["H18"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
                sheet.Range["H18"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
                sheet.Range["H18"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

                sheet.Range["H20"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
                sheet.Range["H20"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
                sheet.Range["H20"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

                sheet.Range["H22"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
                sheet.Range["H22"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
                sheet.Range["H22"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

                sheet.Range["H24"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
                sheet.Range["H24"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
                sheet.Range["H24"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

                sheet.Range["F27:H28"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
                sheet.Range["F27:H28"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
                sheet.Range["F27:H28"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

                sheet.Range["C10:D28"].CellStyle.Borders.LineStyle = ExcelLineStyle.Thin;
                sheet.Range["C10:D28"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
                sheet.Range["C10:D28"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;
                #endregion

                #region Pattern settings
                sheet.Range["B9:I29"].CellStyle.Color = Color.FromArgb(198, 215, 239);
                sheet.Range["A7:J8"].CellStyle.Color = Color.FromArgb(57, 93, 148);

                sheet.Range["A7:A30"].CellStyle.Color = Color.FromArgb(57, 93, 148);
                sheet.Range["A7:A30"].ColumnWidth = 2.29;

                sheet.Range["J7:J30"].CellStyle.Color = Color.FromArgb(57, 93, 148);
                sheet.Range["J7:J30"].ColumnWidth = 2.29;

                sheet.Range["A30:J30"].CellStyle.Color = Color.FromArgb(57, 93, 148);

                sheet.Range["C10:D28"].CellStyle.Color = Color.FromArgb(231, 235, 247);
                sheet.Range["F27:H28"].CellStyle.Color = Color.FromArgb(231, 235, 247);
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
        #region HelperMethod
        public void Close()
        {
            foreach (KeyValuePair<string, MemoryStream> item in fileDataValue)
            {
                item.Value.Dispose();
            }
            fileDataValue.Clear();
        }
        #endregion
    }
}