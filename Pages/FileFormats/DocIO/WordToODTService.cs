#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace BlazorDemos.Data.FileFormats.DocIO
{
    public class WordToODTService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public WordToODTService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        /// <summary>
        /// Convert the Word document to ODT
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream WordToODT(string button)
        {
            string basePath = _hostingEnvironment.WebRootPath;
            //Loads the template document.
            string dataPath = basePath + @"/data/docio/word-to-odt.docx";
            FileStream fileStream = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            if (button == "View Template")
            {
                MemoryStream ms = new MemoryStream();
                fileStream.Position = 0;
                fileStream.CopyTo(ms);
                fileStream.Dispose();
                return ms;
            }
            WordDocument document = new WordDocument(fileStream, FormatType.Automatic);
            fileStream.Dispose();
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created Word document to MemoryStream
                document.Save(stream, FormatType.Odt);
                document.Close();
                stream.Position = 0;
                return stream;
            }
        }
    }
}