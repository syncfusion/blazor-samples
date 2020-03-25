#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.Presentation;
using Syncfusion.PresentationToPdfConverter;
using Syncfusion.Pdf;
using System.IO;

namespace blazor_samples.Data.FileFormats.Presentation
{
    public class PPTXToPDFService
    {
        /// <summary>
        /// Create a simple Presentation document
        /// </summary>
        /// <returns>Return the created Presentation document as stream</returns>
        public MemoryStream PDFConversion()
        {
            //Open the existing presentation
            string basePath = @"wwwroot/Presentation/";
            FileStream fileStreamInput = new FileStream(basePath + @"Template.pptx", FileMode.Open, FileAccess.Read);
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(fileStreamInput);           
            
            //Convert the PowerPoint document to PDF document.
            PdfDocument pdfDocument = PresentationToPdfConverter.Convert(presentation);
			
            //Save the document as a stream and retrun the stream
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
            string basePath = @"wwwroot/Presentation/";
            FileStream fileStreamInput = new FileStream(basePath + @"Template.pptx", FileMode.Open, FileAccess.Read);
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(fileStreamInput);      
            
            //Save the document as a stream and retrun the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created PowerPoint document to MemoryStream
                presentation.Save(stream);
                return stream;
            }
        }        
    }
}