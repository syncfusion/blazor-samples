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
using Syncfusion.Pdf.Parsing;
using System.Collections.Generic;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class OverlayDocumentsService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public OverlayDocumentsService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream CreatePdfDocument()
        {
            
            PdfLoadedDocument ldDoc1 = new PdfLoadedDocument(fileDataValue["border-template.pdf"]);
            PdfLoadedDocument ldDoc2 = new PdfLoadedDocument(fileDataValue["source-template.pdf"]);
            PdfDocument doc = new PdfDocument();

            for (int i = 0, count = ldDoc2.Pages.Count; i < count; ++i)
            {
                PdfPage page = doc.Pages.Add();
                PdfGraphics g = page.Graphics;

                PdfPageBase lpage = ldDoc2.Pages[i];
                PdfTemplate template = lpage.CreateTemplate();

                g.DrawPdfTemplate(template, PointF.Empty, page.GetClientSize());

                lpage = ldDoc1.Pages[0];
                template = lpage.CreateTemplate();

                g.DrawPdfTemplate(template, PointF.Empty, page.GetClientSize());
            }
            MemoryStream stream = new MemoryStream();

            //Save the PDF document
            doc.Save(stream);
			doc.Close();
			
            //If the position is not set to '0' then the PDF will be empty.
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
