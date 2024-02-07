#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.Presentation;
using Syncfusion.PresentationRenderer;
using Syncfusion.Pdf;
using System.IO;
using System.Collections.Generic;

namespace BlazorDemos.Data.DocumentProcessing.PowerPoint
{
    public class PPTXToPDFUAService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public PPTXToPDFUAService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple Presentation document
        /// </summary>
        /// <returns>Return the created Presentation document as stream</returns>
        public MemoryStream PDFConversion()
        {
            //Open the existing presentation
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(fileDataValue["template.pptx"]);           
            
            PresentationToPdfConverterSettings settings = new PresentationToPdfConverterSettings();
            //Sets true to preserve document structured tags in the converted PDF document.
            settings.AutoTag = true;

            //Convert the PowerPoint document to PDF/UA document.
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
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(fileDataValue["template.pptx"]);      
            
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created PowerPoint document to MemoryStream
                presentation.Save(stream);
                return stream;
            }
        }

        /// <summary>
        /// Dispose the Dictionary
        /// </summary>
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