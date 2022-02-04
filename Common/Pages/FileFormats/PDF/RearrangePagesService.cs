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
    public class RearrangePagesService
    {
		private readonly IWebHostEnvironment _hostingEnvironment;
        public RearrangePagesService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
		
        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream CreatePdfDocument()
        {
            //Read the file
            FileStream file = new FileStream(ResolveApplicationPath("syncfusion-brochure.pdf"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            //Load the input PDF document
            PdfLoadedDocument ldoc = new PdfLoadedDocument(file);

            //Rearrange the page by index
            ldoc.Pages.ReArrange(new int[] { 2, 0, 1 });

            //Save the PDF to the MemoryStream
            MemoryStream ms = new MemoryStream();

            ldoc.Save(ms);

            //If the position is not set to '0' then the PDF will be empty.
            ms.Position = 0;

            //Close the PDF document.
            ldoc.Close(true);
				
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
