#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Microsoft.AspNetCore.Hosting;
using Syncfusion.XlsIO;
using System.IO;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class ImportHTMLTableService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public ImportHTMLTableService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// Imports the HTML table to Worksheet.
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream ImportHTMLTableXlsIO(string button)
        {
            if(button == "Input Template")
            {
                FileStream inputStream = new FileStream(ResolveApplicationPath("html-to-excel.html"), FileMode.Open, FileAccess.Read);
                //Save the document as a stream and retrun the stream
                using (MemoryStream stream = new MemoryStream())
                {
                    inputStream.CopyTo(stream);
                    stream.Position = 0;
                    return stream;
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
                    FileStream inputStream = new FileStream(ResolveApplicationPath("html-to-excel.html"), FileMode.Open, FileAccess.Read);

                    worksheet.ImportHtmlTable(inputStream, 1, 1);

                    worksheet.UsedRange.AutofitColumns();
                    worksheet.UsedRange.AutofitRows();

                    //Save the document as a stream and retrun the stream
                    using (MemoryStream stream = new MemoryStream())
                    {
                        workbook.SaveAs(stream);
                        return stream;
                    }
                }
            }
        }
        #region HelperMethod
        private string ResolveApplicationPath(string fileName)
        {
            return _hostingEnvironment.WebRootPath + "//data//xlsio//" + fileName;
        }
        #endregion
    }
}
