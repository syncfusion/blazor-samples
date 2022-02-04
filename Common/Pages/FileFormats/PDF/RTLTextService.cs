#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using Syncfusion.Pdf.Lists;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;
using Syncfusion.Pdf.ColorSpace;
using Syncfusion.Pdf.Functions;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class RTLTextService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public RTLTextService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
       
        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream CreatePdfDocument()
        {
            //Create a new PDF document
            PdfDocument document = new PdfDocument();

            //Add a page
            PdfPage page = document.Pages.Add();

            //Create font
            FileStream fontFileStream = new FileStream(ResolveApplicationPath("arial.ttf"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            PdfFont font = new PdfTrueTypeFont(fontFileStream, 14);

            //Read the text from text file
            FileStream rtlText = new FileStream(ResolveApplicationPath("arabic.txt"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(rtlText, System.Text.Encoding.Unicode);
            string text = reader.ReadToEnd();
            reader.Dispose();

            //Create a brush
            PdfBrush brush = new PdfSolidBrush(new PdfColor(0, 0, 0));
            PdfPen pen = new PdfPen(new PdfColor(0, 0, 0));
            SizeF clipBounds = page.Graphics.ClientSize;
            RectangleF rect = new RectangleF(0, 0, clipBounds.Width, clipBounds.Height);

            //Set the property for RTL text
            PdfStringFormat format = new PdfStringFormat();
            format.TextDirection = PdfTextDirection.RightToLeft;
            format.Alignment = PdfTextAlignment.Right;
            format.ParagraphIndent = 35f;

            //Draw text.
            page.Graphics.DrawString(text, font, brush, rect, format);
            MemoryStream stream = new MemoryStream();
            document.Save(stream);
            document.Close();
            stream.Position = 0;

            return stream;            
        }      


        #region HelperMethod
        private string ResolveApplicationPath(string fileName)
        {
            return _hostingEnvironment.WebRootPath + "//data//pdf//" + fileName;
        }
        #endregion
    }
}
