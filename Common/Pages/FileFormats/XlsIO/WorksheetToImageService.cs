#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Microsoft.AspNetCore.Hosting;
using Syncfusion.XlsIO;
using Syncfusion.XlsIORenderer;
using System.IO;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class WorksheetToImageService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public WorksheetToImageService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// Convert the Excel document to image
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream WorksheetToImageXlsIO(string button, string imageFormat)
        {
            if (button == "Input Document")
            {
                //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    //Step 2 : Instantiate the excel application object
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Excel2016;

                    //An existing workbook is opened                    
                    FileStream inputStream = new FileStream(ResolveApplicationPath("expense-report.xlsx"), FileMode.Open, FileAccess.Read);
                    IWorkbook workbook = application.Workbooks.Open(inputStream);

                    //Save the document as a stream and retrun the stream
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
                //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    //Step 2 : Instantiate the excel application object
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Excel2016;

                    //An existing workbook is opened                    
                    FileStream inputStream = new FileStream(ResolveApplicationPath("expense-report.xlsx"), FileMode.Open, FileAccess.Read);
                    IWorkbook workbook = application.Workbooks.Open(inputStream);

                    //The first worksheet object in the worksheets collection is accessed
                    IWorksheet worksheet = workbook.Worksheets[0];                    
                        
                    application.XlsIORenderer = new XlsIORenderer();

                    ExportImageOptions imageOptions = new ExportImageOptions()
                    {
                        ImageFormat = ExportImageFormat.Jpeg
                    };

                    //Save the document as a stream and retrun the stream
                    using (MemoryStream stream = new MemoryStream())
                    {
                        if (imageFormat == "PNG")
                        {
                            imageOptions.ImageFormat = ExportImageFormat.Png;
                        }
                        //Save the converted image to MemoryStream
                        worksheet.ConvertToImage(worksheet.UsedRange, imageOptions, stream);
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