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
using Syncfusion.Pdf.Xfa;
using System;
using Syncfusion.Pdf.Interactive;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class PortfolioService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public PortfolioService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
      
        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream CreatePdfDocument()
        {
            PdfDocument document = new PdfDocument();

            //Creating new portfolio
            document.PortfolioInformation = new PdfPortfolioInformation();

            //setting the view mode of the portfolio
            document.PortfolioInformation.ViewMode = PdfPortfolioViewMode.Tile;

           

            //Read the file
            FileStream file = new FileStream(ResolveApplicationPath("corporate-brochure.pdf"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            //Creating the attachment
            PdfAttachment pdfFile = new PdfAttachment("corporate-brochure.pdf", file);
            pdfFile.FileName = "CorporateBrochure.pdf";

            file = new FileStream(ResolveApplicationPath("stock.docx"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            //Creating the attachement
            PdfAttachment wordfile = new PdfAttachment("stock.docx",file);
            wordfile.FileName = "Stock.docx";

            file = new FileStream(ResolveApplicationPath("chart.xlsx"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            //Creating the attachement
            PdfAttachment excelfile = new PdfAttachment("chart.xlsx",file);
            excelfile.FileName = "Chart.xlsx";

            //Setting the startup document to view
            document.PortfolioInformation.StartupDocument = pdfFile;

            //Adding the attachment into document
            document.Attachments.Add(pdfFile);
            document.Attachments.Add(wordfile);
            document.Attachments.Add(excelfile);

            //Adding new page into the document
            document.Pages.Add();

            //Save the PDF to the MemoryStream
            MemoryStream ms = new MemoryStream();
            document.Save(ms);

            //If the position is not set to '0' then the PDF will be empty.
            ms.Position = 0;

            //Close the PDF document.
            document.Close(true);
			
            return ms;
        }
        #region HelperMethod
        private string ResolveApplicationPath(string fileName)
        {
            return _hostingEnvironment.WebRootPath + "//data//pdf//" + fileName;
        }
        #endregion
    }
}
