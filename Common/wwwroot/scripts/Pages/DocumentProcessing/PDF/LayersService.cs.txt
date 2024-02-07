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
using System.IO;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class LayersService
    {       
        public LayersService()
        {            
        }
       
        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream LayersPDF()
        {
            //Create a new PDF document
            PdfDocument doc = new PdfDocument();
            doc.PageSettings = new PdfPageSettings(new SizeF(350, 300));

            PdfPage page = doc.Pages.Add();

            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 16);

            page.Graphics.DrawString("Layers", font, PdfBrushes.DarkBlue, new PointF(150, 10));

            //Add the first layer
            PdfPageLayer layer = page.Layers.Add("Layer1");

            PdfGraphics graphics = layer.Graphics;
            graphics.TranslateTransform(100, 60);

            //Draw Arc 
            PdfPen pen = new PdfPen(Color.Red, 50);
            RectangleF rect = new RectangleF(0, 0, 50, 50);
            graphics.DrawArc(pen, rect, 360, 360);

            pen = new PdfPen(Color.Blue, 30);
            graphics.DrawArc(pen, 0, 0, 50, 50, 360, 360);

            pen = new PdfPen(Color.Yellow, 20);
            graphics.DrawArc(pen, rect, 360, 360);

            pen = new PdfPen(Color.Green, 10);
            graphics.DrawArc(pen, 0, 0, 50, 50, 360, 360);

            //Add another layer on the page
            layer = page.Layers.Add("Layer2");

            graphics = layer.Graphics;
            graphics.TranslateTransform(100, 180);
            graphics.SkewTransform(0, 50);

            //Draw another set of elements
            pen = new PdfPen(Color.Red, 50);
            graphics.DrawArc(pen, rect, 360, 360);
            pen = new PdfPen(Color.Blue, 30);
            graphics.DrawArc(pen, 0, 0, 50, 50, 360, 360);
            pen = new PdfPen(Color.Yellow, 20);
            graphics.DrawArc(pen, rect, 360, 360);
            pen = new PdfPen(Color.Green, 10);
            graphics.DrawArc(pen, 0, 0, 50, 50, 360, 360);

            //Add another layer
            layer = page.Layers.Add("Layer3");
            graphics = layer.Graphics;
            graphics.TranslateTransform(160, 120);

            //Draw another set of elements.
            pen = new PdfPen(Color.Red, 50);
            graphics.DrawArc(pen, rect, -60, 60);
            pen = new PdfPen(Color.Blue, 30);
            graphics.DrawArc(pen, 0, 0, 50, 50, -60, 60);
            pen = new PdfPen(Color.Yellow, 20);
            graphics.DrawArc(pen, rect, -60, 60);
            pen = new PdfPen(Color.Green, 10);
            graphics.DrawArc(pen, 0, 0, 50, 50, -60, 60);

            MemoryStream stream = new MemoryStream();

            //Save the PDF document
            doc.Save(stream);

            stream.Position = 0;

            //Close the PDF document
            doc.Close(true);
            return stream;
        }
    }
}
