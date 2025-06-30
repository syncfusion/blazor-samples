#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.Drawing;
using Syncfusion.XlsIO;
using System.IO;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class TablesService
    {
        /// <summary>
        /// Create an Excel document with table
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream TablesXlsIO(bool customStyle)
        {
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Step 2 : Instantiate the excel application object
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;

                //Creating new workbook
                IWorkbook workbook = application.Workbooks.Create(1);
                IWorksheet sheet = workbook.Worksheets[0];

                #region Table data
                //Create data
                sheet[1, 1].Text = "Products";
                sheet[1, 2].Text = "Qtr1";
                sheet[1, 3].Text = "Qtr2";
                sheet[1, 4].Text = "Qtr3";
                sheet[1, 5].Text = "Qtr4";

                sheet[2, 1].Text = "Alfreds Futterkiste";
                sheet[2, 2].Number = 744.6;
                sheet[2, 3].Number = 162.56;
                sheet[2, 4].Number = 5079.6;
                sheet[2, 5].Number = 1249.2;

                sheet[3, 1].Text = "Antonio Moreno Taqueria";
                sheet[3, 2].Number = 5079.6;
                sheet[3, 3].Number = 1249.2;
                sheet[3, 4].Number = 943.89;
                sheet[3, 5].Number = 349.6;

                sheet[4, 1].Text = "Around the Horn";
                sheet[4, 2].Number = 1267.5;
                sheet[4, 3].Number = 1062.5;
                sheet[4, 4].Number = 744.6;
                sheet[4, 5].Number = 162.56;

                sheet[5, 1].Text = "Bon app";
                sheet[5, 2].Number = 1418;
                sheet[5, 3].Number = 756;
                sheet[5, 4].Number = 1267.5;
                sheet[5, 5].Number = 1062.5;

                sheet[6, 1].Text = "Eastern Connection";
                sheet[6, 2].Number = 4728;
                sheet[6, 3].Number = 4547.92;
                sheet[6, 4].Number = 1418;
                sheet[6, 5].Number = 756;

                sheet[7, 1].Text = "Ernst Handel";
                sheet[7, 2].Number = 943.89;
                sheet[7, 3].Number = 349.6;
                sheet[7, 4].Number = 4728;
                sheet[7, 5].Number = 4547.92;
                #endregion

                //Create style for table number format
                IStyle style1 = workbook.Styles.Add("CurrencyFormat");
                style1.NumberFormat = "_($* #,##0.00_);_($* (#,##0.00);_($* \" - \"??_);_(@_)";

                //Apply number format
                sheet["B2:E8"].CellStyleName = "CurrencyFormat";

                //Create table
                IListObject table1 = sheet.ListObjects.Create("Table1", sheet["A1:E7"]);

                if (customStyle)
                {
                    //Apply custom table style
                    table1.TableStyleName = CreateCustomStyle(workbook).Name;
                }
                else
                {
                    //Apply built-in style
                    table1.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium9;
                }

                //Total row
                table1.ShowTotals = true;
                table1.ShowFirstColumn = true;
                table1.ShowTableStyleColumnStripes = true;
                table1.Columns[0].TotalsRowLabel = "Total";
                table1.Columns[1].TotalsCalculation = ExcelTotalsCalculation.Sum;
                table1.Columns[2].TotalsCalculation = ExcelTotalsCalculation.Sum;
                table1.Columns[3].TotalsCalculation = ExcelTotalsCalculation.Sum;
                table1.Columns[4].TotalsCalculation = ExcelTotalsCalculation.Sum;

                sheet.UsedRange.AutofitColumns();
                sheet.SetColumnWidth(2, 12.43);
                sheet.SetColumnWidth(4, 12.43);

                //Save the document as a stream and return the stream
                using (MemoryStream stream = new MemoryStream())
                {
                    //Save the created Excel document to MemoryStream
                    workbook.SaveAs(stream);
                    return stream;
                }
            }
        }
        private ITableStyle CreateCustomStyle(IWorkbook workbook)
        {
            #region Custom table style
            string tableStyleName = "Table Style 1";

            ITableStyles tableStyles = workbook.TableStyles;
            ITableStyle tableStyle = tableStyles.Add(tableStyleName);
            ITableStyleElements tableStyleElements = tableStyle.TableStyleElements;
            ITableStyleElement tableStyleElement = tableStyleElements.Add(ExcelTableStyleElementType.SecondColumnStripe);
            tableStyleElement.BackColorRGB = Color.FromArgb(217, 225, 242);

            ITableStyleElement tableStyleElement1 = tableStyleElements.Add(ExcelTableStyleElementType.FirstColumn);
            tableStyleElement1.FontColorRGB = Color.FromArgb(128, 128, 128);

            ITableStyleElement tableStyleElement2 = tableStyleElements.Add(ExcelTableStyleElementType.HeaderRow);
            tableStyleElement2.FontColor = ExcelKnownColors.White;
            tableStyleElement2.BackColorRGB = Color.FromArgb(0, 112, 192);

            ITableStyleElement tableStyleElement3 = tableStyleElements.Add(ExcelTableStyleElementType.TotalRow);
            tableStyleElement3.BackColorRGB = Color.FromArgb(0, 112, 192);
            tableStyleElement3.FontColor = ExcelKnownColors.White;
            #endregion

            return tableStyle;
        }
    }
}