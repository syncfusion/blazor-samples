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
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Syncfusion.Pdf.Parsing;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class OverlayDocumentsService
    {
		private readonly IWebHostEnvironment _hostingEnvironment;
        public OverlayDocumentsService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
		
        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream CreatePdfDocument()
        {

            string dataPath1 = ResolveApplicationPath("border-template.pdf");
            string dataPath2 = ResolveApplicationPath("source-template.pdf");

            Stream stream1 = new FileStream(dataPath2, FileMode.Open, FileAccess.Read);
            FileStream file = new FileStream(dataPath1, FileMode.Open, FileAccess.Read, FileShare.Read);
            PdfLoadedDocument ldDoc1 = new PdfLoadedDocument(file);
            PdfLoadedDocument ldDoc2 = new PdfLoadedDocument(stream1);
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
        private string ResolveApplicationPath(string fileName)
        {
            return _hostingEnvironment.WebRootPath + "//data//pdf//" + fileName;
        }
        #endregion
    }
}
