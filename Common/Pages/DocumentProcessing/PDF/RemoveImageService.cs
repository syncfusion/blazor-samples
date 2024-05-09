#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using Syncfusion.Pdf.Lists;
using System.IO;
using System.Collections.Generic;
using Syncfusion.Pdf.Exporting;
using Syncfusion.Pdf.Parsing;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class RemoveImageService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public RemoveImageService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream RemoveImage()
        {
            //Load the PDF document from stream.
            PdfLoadedDocument document = new PdfLoadedDocument(fileDataValue["RemoveImageTemplate.pdf"]);
            //Load the first page.
            PdfPageBase page = document.Pages[0];
            //Extract images from the first page.
            PdfImageInfo[] imageInfo = page.GetImagesInfo();
            //Remove the image.
            page.RemoveImage(imageInfo[0]);
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
