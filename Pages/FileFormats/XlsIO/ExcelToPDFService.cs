#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Microsoft.AspNetCore.Hosting;
using Syncfusion.XlsIORenderer;
using Syncfusion.Pdf;
using System.IO;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class ExcelToPDFService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public ExcelToPDFService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// Create an Excel document
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream ExceltoPDFXlsIO(string option)
        {
            XlsIORenderer renderer = new XlsIORenderer();
            FileStream inputStream = new FileStream(ResolveApplicationPath("excel-to-pdf.xlsx"), FileMode.Open, FileAccess.Read);
            inputStream.Position = 0;

            //Intialize the PdfDocument Class
            PdfDocument document = new PdfDocument();

            //Intialize the ExcelToPdfConverterSettings class
            XlsIORendererSettings settings = new XlsIORendererSettings();
            settings.IsConvertBlankPage = false;

            //Set the Layout Options for the output Pdf page
            if (option == "NoScaling")
                settings.LayoutOptions = LayoutOptions.NoScaling;
            else if (option == "FitAllRowsOnOnePage")
                settings.LayoutOptions = LayoutOptions.FitAllRowsOnOnePage;
            else if (option == "FitAllColumnsOnOnePage")
                settings.LayoutOptions = LayoutOptions.FitAllColumnsOnOnePage;
            else
                settings.LayoutOptions = LayoutOptions.FitSheetOnOnePage;

            //Assign the output PdfDocument to the TemplateDocument property of ExcelToPdfConverterSettings 
            settings.TemplateDocument = document;
            settings.DisplayGridLines = GridLinesDisplayStyle.Invisible;

            //Convert the Excel document to PDf
            document = renderer.ConvertToPDF(inputStream, settings);
            inputStream.Dispose();

            //Save the document as a stream and retrun the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created PDF document to MemoryStream
                document.Save(stream);
                return stream;
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