#region Copyright Syncfusion Inc. 2001 - 2022
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
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
    public class PPTXToPDFAService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public PPTXToPDFAService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// Create a simple Presentation document
        /// </summary>
        /// <returns>Return the created Presentation document as stream</returns>
        public MemoryStream PDFConversion()
        {
            //Open the existing presentation
            FileStream fileStreamInput = new FileStream(ResolveApplicationPath("template.pptx"), FileMode.Open, FileAccess.Read);
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(fileStreamInput);           
            
            PresentationToPdfConverterSettings settings = new PresentationToPdfConverterSettings();
            //Set the Pdf conformance level to Pdf_A3A.
            settings.PdfConformanceLevel = PdfConformanceLevel.Pdf_A3A;

            //Convert the PowerPoint document to PDF/A document.
            PdfDocument pdfDocument = PresentationToPdfConverter.Convert(presentation,settings);
			
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created PowerPoint document to MemoryStream
                pdfDocument.Save(stream);
                stream.Position = 0;
                return stream;
            }
        }
		
		/// <summary>
        /// Open a Presentation template document
        /// </summary>
        /// <returns>Return the input Presentation template document as stream</returns>
        public MemoryStream PDFInput()
        {
            //Open the existing presentation
            FileStream fileStreamInput = new FileStream(ResolveApplicationPath("template.pptx"), FileMode.Open, FileAccess.Read);
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(fileStreamInput);      
            
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created PowerPoint document to MemoryStream
                presentation.Save(stream);
                return stream;
            }
        }
        
        #region HelperMethod
        private string ResolveApplicationPath(string fileName)
        {
            return _hostingEnvironment.WebRootPath + "//data//powerpoint///" + fileName;
        }
        #endregion
    }
}