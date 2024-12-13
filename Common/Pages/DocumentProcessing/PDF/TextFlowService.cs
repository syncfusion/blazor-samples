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

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class TextFlowService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public TextFlowService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream CreatePdfDocument()
        {
            //Create a new PDF document.
            PdfDocument doc = new PdfDocument();

            //Set compression level
            doc.Compression = PdfCompressionLevel.None;

            //Add a page to the document.
            PdfPage page = doc.Pages.Add();
                     
            //Read the text from the text file           
            StreamReader reader = new StreamReader(fileDataValue["manual.txt"], System.Text.Encoding.ASCII);
            string text = reader.ReadToEnd();
            reader.Dispose();

            //Set the font           
            PdfFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 12);

            //Set the formats for the text
            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Justify;
            format.LineAlignment = PdfVerticalAlignment.Top;
            format.ParagraphIndent = 15f;

            //Create a text element 
            PdfTextElement element = new PdfTextElement(text, font);
            element.Brush = new PdfSolidBrush(Color.Black);
            element.StringFormat = format;
            element.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 12);

            //Set the properties to paginate the text.
            PdfLayoutFormat layoutFormat = new PdfLayoutFormat();
            layoutFormat.Break = PdfLayoutBreakType.FitPage;
            layoutFormat.Layout = PdfLayoutType.Paginate;

            RectangleF bounds = new RectangleF(PointF.Empty, page.Graphics.ClientSize);

            //Raise the events to draw the graphic elements for each page.
            element.BeginPageLayout += new BeginPageLayoutEventHandler(BeginPageLayout);
            element.EndPageLayout += new EndPageLayoutEventHandler(EndPageLayout);

            //Draw the text element with the properties and formats set.
            PdfTextLayoutResult result = element.Draw(page, bounds, layoutFormat);

            //Save the PDF to the MemoryStream
            MemoryStream ms = new MemoryStream();
            doc.Save(ms);

            //If the position is not set to '0' then the PDF will be empty.
            ms.Position = 0;

            //Close the PDF document.
            doc.Close(true);
            return ms;            
        }

       
        private void EndPageLayout(object sender, EndPageLayoutEventArgs e)
        {
            EndTextPageLayoutEventArgs args = (EndTextPageLayoutEventArgs)e;
            PdfPage page = args.Result.Page;
            PdfPen pen = PdfPens.Black;
            page.Graphics.DrawRectangle(pen, new RectangleF(PointF.Empty, page.Graphics.ClientSize));
        }
        private void BeginPageLayout(object sender, BeginPageLayoutEventArgs e)
        {
            int index = e.Page.Section.Pages.IndexOf(e.Page);
            float offset = 50;
            PdfSolidBrush brush = new PdfSolidBrush(Color.LightBlue);

            if (index % 2 == 0)
            {
                RectangleF bounds = e.Bounds;
                e.Page.Graphics.DrawEllipse(brush, bounds.Width / 2 - offset, bounds.Height / 2 - offset, 2 * offset, 2 * offset);
            }
            else
            {
                RectangleF bounds = e.Bounds;
                e.Page.Graphics.DrawRectangle(brush, bounds.Width / 2 - offset, bounds.Height / 2 - offset, 2 * offset, 2 * offset);
            }           
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
