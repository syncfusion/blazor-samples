#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.XlsIO;
using System;
using System.IO;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class DataValidationService
    {
        /// <summary>
        /// Create the Excel document with data validation
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream DataValidationXlsIO(string version)
        {
            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Step 2 : Instantiate the excel application object
                IApplication application = excelEngine.Excel;

                //Set the default version
                if (version == "XLS")
                    application.DefaultVersion = ExcelVersion.Excel97to2003;
                else
                    application.DefaultVersion = ExcelVersion.Excel2016;

                //A new workbook is created.[Equivalent to creating a new workbook in Microsoft Excel]
                //The new workbook will have 3 worksheets
                IWorkbook workbook = application.Workbooks.Create(3);

                //The first worksheet object in the worksheets collection is accessed.
                IWorksheet sheet = workbook.Worksheets[0];

                //Data validation to list the values in the first cell
                IDataValidation validation = sheet.Range["C7"].DataValidation;
                sheet.Range["B7"].Text = "Select an item from the validation list";
                validation.ListOfValues = new string[] { "PDF", "XlsIO", "DocIO" };
                validation.PromptBoxText = "Data Validation list";
                validation.IsPromptBoxVisible = true;
                validation.ShowPromptBox = true;

                sheet.Range["C7"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
                sheet.Range["C7"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
                sheet.Range["C7"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

                //Data Validation for Numbers
                IDataValidation validation1 = sheet.Range["C9"].DataValidation;
                sheet.Range["B9"].Text = "Enter a Number to validate";
                validation1.AllowType = ExcelDataType.Integer;
                validation1.CompareOperator = ExcelDataValidationComparisonOperator.Between;
                validation1.FirstFormula = "0";
                validation1.SecondFormula = "10";
                validation1.ShowErrorBox = true;
                validation1.ErrorBoxText = "Enter Value between 0 to 10";
                validation1.ErrorBoxTitle = "ERROR";
                validation1.PromptBoxText = "Data Validation using Condition for Numbers";
                validation1.ShowPromptBox = true;
                sheet.Range["C9"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
                sheet.Range["C9"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
                sheet.Range["C9"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

                //Data Validation for Date
                IDataValidation validation2 = sheet.Range["C11"].DataValidation;
                sheet.Range["B11"].Text = "Enter the Date to validate";
                validation2.AllowType = ExcelDataType.Date;
                validation2.CompareOperator = ExcelDataValidationComparisonOperator.Between;
                validation2.FirstDateTime = new DateTime(2003, 5, 10);
                validation2.SecondDateTime = new DateTime(2004, 5, 10);
                validation2.ShowErrorBox = true;
                validation2.ErrorBoxText = "Enter Value between 5/10/2003 to 5/10/2004";
                validation2.ErrorBoxTitle = "ERROR";
                validation2.PromptBoxText = "Data Validation using Condition for Date";
                validation2.ShowPromptBox = true;
                sheet.Range["C11"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
                sheet.Range["C11"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
                sheet.Range["C11"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

                //Data Validation for TextLength
                IDataValidation validation3 = sheet.Range["C13"].DataValidation;
                sheet.Range["B13"].Text = "Enter the Text to validate";
                validation3.AllowType = ExcelDataType.TextLength;
                validation3.CompareOperator = ExcelDataValidationComparisonOperator.Between;
                validation3.FirstFormula = "1";
                validation3.SecondFormula = "6";
                validation3.ShowErrorBox = true;
                validation3.ErrorBoxText = "Retype text length to 6 characters";
                validation3.ErrorBoxTitle = "ERROR";
                validation3.PromptBoxText = "Data Validation using Condition for TextLength";
                validation3.ShowPromptBox = true;
                sheet.Range["C13"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
                sheet.Range["C13"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
                sheet.Range["C13"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;

                //Data Validation for Time
                IDataValidation validation4 = sheet.Range["C15"].DataValidation;
                sheet.Range["B15"].Text = "Enter the Time to validate";
                validation4.AllowType = ExcelDataType.Time;
                validation4.CompareOperator = ExcelDataValidationComparisonOperator.Between;
                validation4.FirstFormula = "10";
                validation4.SecondFormula = "12";
                validation4.ShowErrorBox = true;
                validation4.ErrorBoxText = "Enter the correct time between 10 to 12";
                validation4.ErrorBoxTitle = "ERROR";
                validation4.PromptBoxText = "Data Validation using Condition for Time";
                validation4.ShowPromptBox = true;
                sheet.Range["C15"].CellStyle.Borders.LineStyle = ExcelLineStyle.Medium;
                sheet.Range["C15"].CellStyle.Borders[ExcelBordersIndex.DiagonalDown].ShowDiagonalLine = false;
                sheet.Range["C15"].CellStyle.Borders[ExcelBordersIndex.DiagonalUp].ShowDiagonalLine = false;
                sheet.Range["B2:C2"].Merge();
                sheet.Range["B2"].Text = "Simple Data validation";
                sheet.Range["B5"].Text = "Validation criteria";
                sheet.Range["C5"].Text = "Validation";
                sheet.Range["B5"].CellStyle.Font.Bold = true;
                sheet.Range["C5"].CellStyle.Font.Bold = true;
                sheet.Range["B2"].CellStyle.Font.Bold = true;
                sheet.Range["B2"].CellStyle.Font.Size = 16;
                sheet.Range["B2"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                sheet.UsedRange.AutofitColumns();
                sheet.UsedRange.AutofitRows();

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