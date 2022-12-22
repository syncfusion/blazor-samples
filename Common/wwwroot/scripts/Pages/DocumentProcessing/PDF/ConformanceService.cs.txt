#region Copyright Syncfusion Inc. 2001 - 2022
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Mvc;
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using Syncfusion.Pdf.Parsing;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class ConformanceService
    {
		private readonly IWebHostEnvironment _hostingEnvironment;
        public ConformanceService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
		
        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream CreatePdfDocument( string conformance )
        {

            if (conformance == null)
            {
                conformance = "PDF/A-1a";
            }
            PdfDocument doc = null;

            if (conformance == "PDF/A-1a")
            {
                //Create a new document with PDF/A standard.
                doc = new PdfDocument(PdfConformanceLevel.Pdf_A1A);
            }
            else if (conformance == "PDF/A-1b")
            {
                doc = new PdfDocument(PdfConformanceLevel.Pdf_A1B);
            }
            else if (conformance == "PDF/A-2a")
            {
                doc = new PdfDocument(PdfConformanceLevel.Pdf_A2A);
            }
            else if (conformance == "PDF/A-2b")
            {
                doc = new PdfDocument(PdfConformanceLevel.Pdf_A2B);
            }
            else if (conformance == "PDF/A-2u")
            {
                doc = new PdfDocument(PdfConformanceLevel.Pdf_A2U);
            }
            else if (conformance == "PDF/A-4")
            {
                doc = new PdfDocument(PdfConformanceLevel.Pdf_A4);
            }
            else if (conformance == "PDF/A-4e")
            {
                doc = new PdfDocument(PdfConformanceLevel.Pdf_A4E);
            }
            else
            {
                if (conformance == "PDF/A-3a")
                {
                    doc = new PdfDocument(PdfConformanceLevel.Pdf_A3A);
                }
                else if (conformance == "PDF/A-3b")
                {
                    doc = new PdfDocument(PdfConformanceLevel.Pdf_A3B);
                }
                else if (conformance == "PDF/A-3u")
                {
                    doc = new PdfDocument(PdfConformanceLevel.Pdf_A3U);
                }
                else if (conformance == "PDF/A-4f")
                {
                    doc = new PdfDocument(PdfConformanceLevel.Pdf_A4F);
                }
                FileStream attachmentStream = new FileStream(ResolveApplicationPath("PDF_A.rtf"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                PdfAttachment attachment = new PdfAttachment("PDF_A.rtf", attachmentStream);
                attachment.Relationship = PdfAttachmentRelationship.Alternative;
                attachment.ModificationDate = DateTime.Now;

                attachment.Description = "PDF_A";

                attachment.MimeType = "application/xml";

                doc.Attachments.Add(attachment);
            }

            //Add a page
            PdfPage page = doc.Pages.Add();

            //Create Pdf graphics for the page
            PdfGraphics graphics = page.Graphics;
            //Load the image from the disk.
            FileStream imageStream = new FileStream(ResolveApplicationPath("adventure-cycle.jpg"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            PdfImage img = new PdfBitmap(imageStream);
            //Draw the image in the specified location and size.
            graphics.DrawImage(img, new RectangleF(150, 30, 200, 100));

            //Create font.
            FileStream fontStream = new FileStream(ResolveApplicationPath("arial.ttf"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            PdfFont font = new PdfTrueTypeFont(fontStream, true, PdfFontStyle.Regular, 14);

            PdfTextElement textElement = new PdfTextElement("Adventure Works Cycles, the fictitious company on which the AdventureWorks sample databases are based," +
                                " is a large, multinational manufacturing company. The company manufactures and sells metal and composite bicycles to North American, " +
                                "European and Asian commercial markets. While its base operation is located in Bothell, Washington with 290 employees, several regional" +
                                " sales teams are located throughout their market base.")
            {
                Font = font
            };
            PdfLayoutResult layoutResult = textElement.Draw(page, new RectangleF(0, 150, page.GetClientSize().Width, page.GetClientSize().Height));

            MemoryStream SourceStream = new MemoryStream();
            doc.Save(SourceStream);
            doc.Close(true);
            SourceStream.Position = 0;
            return SourceStream;
        }

        #region HelperMethod
        private string ResolveApplicationPath(string fileName)
        {
            return _hostingEnvironment.WebRootPath + "//data//pdf//" + fileName;
        }
        #endregion
    }
}
