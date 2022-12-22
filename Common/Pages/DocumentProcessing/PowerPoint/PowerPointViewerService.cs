#region Copyright Syncfusion Inc. 2001-2022
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.Presentation;
using Syncfusion.PresentationRenderer;
using Syncfusion.Pdf;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace BlazorDemos.Data.DocumentProcessing.PowerPoint
{
    public class PowerPointViewerService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public PowerPointViewerService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// Convert a PowerPoint Presentation to PDF.
        /// </summary>
        /// <returns>Return the converted PDF document as stream</returns>
        public MemoryStream PDFConversion(Stream inputStream)
        {            
            if (inputStream == null)
                inputStream = new FileStream(ResolveApplicationPath("template.pptx"), FileMode.Open, FileAccess.Read);
            //Create a MemoryStream.
            MemoryStream stream = new MemoryStream();

            try
            {
                //Open the PowerPoint document.
                IPresentation presentation = Syncfusion.Presentation.Presentation.Open(inputStream);
                //Convert the PowerPoint document to PDF document.
                PdfDocument pdfDocument = PresentationToPdfConverter.Convert(presentation);
                //Save the PDF document as a stream and return the stream
                pdfDocument.Save(stream);
                //Dispose the pdf and presentation instance.
                pdfDocument.Dispose();
                presentation.Dispose();
                stream.Position = 0;
            }
            catch
            {
                // Catch the exception here.
            }
            return stream;
        }
        
        #region HelperMethod
        /// <summary>
        /// Gets the hint path of a file in current application.
        /// </summary>
        /// <param name="fileName">Specifies the file name.</param>
        /// <returns></returns>
        private string ResolveApplicationPath(string fileName)
        {
            return _hostingEnvironment.WebRootPath + "//data//powerpoint///" + fileName;
        }
        #endregion
    }
}