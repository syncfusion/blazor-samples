#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Drawing;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;


namespace BlazorDemos.Pages.FileFormats.DocIO
{
    public class WordToWordMLService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public WordToWordMLService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        /// <summary>
        /// Convert the Word document to Word processing XML
        /// </summary>
        /// <returns>Return the resultant WordML as stream</returns>
        public MemoryStream WordToWordML(string button)
        {
            string basePath = _hostingEnvironment.WebRootPath;
            string dataPath = basePath + @"/data/docio/doc-to-wordml.doc";
            FileStream fileStream = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            if (button == "View Template")
            {
                MemoryStream ms = new MemoryStream();
                fileStream.Position = 0;
                fileStream.CopyTo(ms);
                fileStream.Close();
                return ms;
            }
            //Loads the template Word document
            WordDocument document = new WordDocument(fileStream, FormatType.Automatic);
            fileStream.Dispose();

            #region Saving document
            //Save the document as a stream and retrun the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the Word document to MemoryStream
                document.Save(stream, FormatType.WordML);
                document.Close();
                stream.Position = 0;
                return stream;
            }
            #endregion
        }
    }
}
