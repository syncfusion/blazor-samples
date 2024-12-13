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
using Syncfusion.Pdf.Xfa;
using System;
using Syncfusion.Pdf.Interactive;
using System.Collections.Generic;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class PortfolioService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public PortfolioService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
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

           

            
            //Creating the attachment
            PdfAttachment pdfFile = new PdfAttachment("corporate-brochure.pdf", fileDataValue["corporate-brochure.pdf"]);
            pdfFile.FileName = "CorporateBrochure.pdf";

           
            //Creating the attachment
            PdfAttachment wordfile = new PdfAttachment("stock.docx", fileDataValue["stock.docx"]);
            wordfile.FileName = "Stock.docx";


            //Creating the attachment
            PdfAttachment excelfile = new PdfAttachment("chart.xlsx", fileDataValue["chart.xlsx"]);
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
