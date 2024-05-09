#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.IO;
using System.Collections.Generic;
using Syncfusion.Pdf.Parsing;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class CompressExistingPdfService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public CompressExistingPdfService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream CompressPdf()
        {
            //Load the PDF document from stream.
            PdfLoadedDocument document = new PdfLoadedDocument(fileDataValue["jQuery_Succinctly.pdf"]);
            //Initialize new instance of PdfCompressionOptions class.
            PdfCompressionOptions options = new PdfCompressionOptions();
            //set the compress images based on the image quality.
            options.CompressImages = true;
            options.ImageQuality = 50;
            //Enable the optimize font option
            options.OptimizeFont = true;
            //Enable the optimize page contents.
            options.OptimizePageContents = true;
            //Set to remove the metadata information.
            options.RemoveMetadata = true;
            //Assign the compression option to the document
            document.Compress(options);
            MemoryStream stream = new MemoryStream();
            //Saves the PDF to the memory stream.
            document.Save(stream);
            //Close the PDF document
            document.Close(true);
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
