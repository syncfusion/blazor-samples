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
    public class ImageInsertionService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public ImageInsertionService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream ImageInsertionPDF()
        {
            //Create a new PDF document
            PdfDocument document = new PdfDocument();

            // Add a new page to the newly created document.
            PdfPage page = document.Pages.Add();

            PdfStandardFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 12, PdfFontStyle.Bold);

            PdfGraphics g = page.Graphics;

            g.DrawString("JPEG Image", font, PdfBrushes.Blue, new Syncfusion.Drawing.PointF(0, 40));

           
            //Load the JPEG image
            PdfImage jpgImage = new PdfBitmap(fileDataValue["xamarin-jpeg.jpg"]);

            //Draw the JPEG image
            g.DrawImage(jpgImage, new Syncfusion.Drawing.RectangleF(0, 70, 515, 215));

            g.DrawString("PNG Image", font, PdfBrushes.Blue, new Syncfusion.Drawing.PointF(0, 355));

            
            //Load the PNG image
            PdfImage pngImage = new PdfBitmap(fileDataValue["xamarin-png.png"]);

            g.DrawImage(pngImage, new Syncfusion.Drawing.RectangleF(0, 365, 199, 300));

            MemoryStream stream = new MemoryStream();

            //Save the PDF document
            document.Save(stream);

            stream.Position = 0;

            //Close the PDF document
            document.Close(true);
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
