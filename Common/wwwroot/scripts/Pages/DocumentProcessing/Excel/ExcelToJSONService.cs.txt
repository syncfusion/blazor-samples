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
using static BlazorDemos.Pages.Navigations.TreeView.LazyLoading;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class ExcelToJSONService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public ExcelToJSONService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Convert the Excel document to JSON
        /// </summary>
        /// <returns>Return the JSON document as stream</returns>
        public MemoryStream ExcelToJSONXlsIO(string button, string option, bool isSchema)
        {
            if (button == "Input Document")
            {
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    //Step 2 : Instantiate the excel application object
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Excel2016;

                    //Opening the encrypted Workbook
                    IWorkbook workbook = application.Workbooks.Open(fileDataValue["excel-to-json.xlsx"], ExcelParseOptions.Default);

                    //Save the document as a stream and return the stream
                    using (MemoryStream stream = new MemoryStream())
                    {
                        //Save the created Excel document to MemoryStream
                        workbook.SaveAs(stream);
                        return stream;
                    }
                }
            }
            else
            {
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    //Step 2 : Instantiate the excel application object
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Excel2016;

                    //Opening the encrypted Workbook
                    IWorkbook workbook = application.Workbooks.Open(fileDataValue["excel-to-json.xlsx"], ExcelParseOptions.Default);

                    //Accessing first worksheet in the workbook
                    IWorksheet worksheet = workbook.Worksheets[0];

                    IRange range = worksheet.Range["A2:B10"];

                    //Save the document as a stream and return the stream
                    using (MemoryStream stream = new MemoryStream())
                    {
                        //Save the created Excel document to MemoryStream
                        if (option == "Workbook")
                            workbook.SaveAsJson(stream, isSchema);
                        else if (option == "Worksheet")
                            workbook.SaveAsJson(stream, worksheet, isSchema);
                        else if (option == "Range")
                            workbook.SaveAsJson(stream, range, isSchema);
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