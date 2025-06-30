#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.Collections.Generic;
using Syncfusion.XlsIO;
using System.IO;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class ImportHTMLTableService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public ImportHTMLTableService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Imports the HTML table to Worksheet.
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream ImportHTMLTableXlsIO(string button, bool detectFormula)
        {
            if (button == "Input Template")
            {
                if (detectFormula)
                {
                    return fileDataValue["html-with-formula-to-excel.html"];
                }
                else
                {
                    return fileDataValue["html-to-excel.html"];
                }
            }
            else
            {
                //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    //Step 2 : Instantiate the excel application object
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Excel2016;

                    IWorkbook workbook = application.Workbooks.Create(1);

                    //The first worksheet object in the worksheets collection is accessed
                    IWorksheet worksheet = workbook.Worksheets[0];

                    //An existing html is opened                    
                    if (detectFormula)
                    {
                        worksheet.ImportHtmlTable(fileDataValue["html-with-formula-to-excel.html"], 1, 1, HtmlImportOptions.DetectFormulas);
                        worksheet.Range["E2:F25"].NumberFormat = "_($* #,##0.00_);_($* (#,##0.00)";
                        worksheet.Range["H2:I25"].NumberFormat = "_($* #,##0.00_);_($* (#,##0.00)";
                    }
                    else
                    {
                        worksheet.ImportHtmlTable(fileDataValue["html-to-excel.html"], 1, 1);
                    }

                    worksheet.UsedRange.AutofitColumns();
                    worksheet.UsedRange.AutofitRows();

                    //Save the document as a stream and return the stream
                    using (MemoryStream stream = new MemoryStream())
                    {
                        workbook.SaveAs(stream);
                        return stream;
                    }
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
