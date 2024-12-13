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

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class TiffToPdfService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public TiffToPdfService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream ConvertToPdf()
        {
            //Create a new PDF document
            PdfDocument document = new PdfDocument();
            //Set margin to the page
            document.PageSettings.Margins.All = 0;
            //Load multi-frame Tiff image
            PdfTiffImage tiffImage = new PdfTiffImage(fileDataValue["image.tiff"]);
            //Get the frame count
            int frameCount = tiffImage.FrameCount;
            //Access each frame and draw into the page
            for (int i = 0; i < frameCount; i++)
            {
                //Add new page for each frames
                PdfPage page = document.Pages.Add();
                //Get page graphics
                PdfGraphics graphics = page.Graphics;
                //Set active frame.
                tiffImage.ActiveFrame = i;
                //Draw Tiff image into page
                graphics.DrawImage(tiffImage, 0, 0, page.GetClientSize().Width, page.GetClientSize().Height);
            }
            //Save PDF document
            MemoryStream stream = new MemoryStream();
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
