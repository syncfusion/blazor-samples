#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.IO;
using Syncfusion.Pdf.Parsing;
using System.Collections.Generic;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class RearrangePagesService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public RearrangePagesService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream CreatePdfDocument()
        {
            
            //Load the input PDF document
            PdfLoadedDocument ldoc = new PdfLoadedDocument(fileDataValue["syncfusion-brochure.pdf"]);

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
