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
using System.Collections.Generic;


namespace BlazorDemos.Data.DocumentProcessing.PowerPoint
{
    public class PowerPointViewerService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public PowerPointViewerService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Convert a PowerPoint Presentation to PDF.
        /// </summary>
        /// <returns>Return the converted PDF document as stream</returns>
        public MemoryStream PDFConversion(Stream inputStream)
        {            
            if (inputStream == null)
                inputStream = fileDataValue["template.pptx"];
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