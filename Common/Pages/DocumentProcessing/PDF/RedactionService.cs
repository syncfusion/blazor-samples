#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Pdf;
using System.IO;
using System.Collections.Generic;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Redaction;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class RedactionService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public RedactionService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Redact the PDF document contents.
        /// </summary>
        /// <returns>Return the redacted PDF document as stream</returns>
        public MemoryStream RedactPdf()
        {
            //Load the PDF document from stream.
            PdfLoadedDocument loadedDocument = new PdfLoadedDocument(fileDataValue["RedactionTemplate.pdf"]);

            //Get the first page of the document.
            PdfLoadedPage lPage = loadedDocument.Pages[0] as PdfLoadedPage;

            //Create a redaction object and add to the page.
            lPage.AddRedaction(new PdfRedaction(new Syncfusion.Drawing.RectangleF(477f, 154f, 62.709f, 16.802f), Syncfusion.Drawing.Color.Black));
            lPage.AddRedaction(new PdfRedaction(new Syncfusion.Drawing.RectangleF(70, 240, 65.709f, 16.802f), Syncfusion.Drawing.Color.Black));
            lPage.AddRedaction(new PdfRedaction(new Syncfusion.Drawing.RectangleF(52.14447f, 712.1465f, 126.10835f, 81.45297f), Syncfusion.Drawing.Color.Black));
            
            //Start the redaction process.
            loadedDocument.Redact();

            MemoryStream stream = new MemoryStream();
            //Saves the PDF to the memory stream.
            loadedDocument.Save(stream);
            loadedDocument.Close(true);
            stream.Position = 0;

            return stream;
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
