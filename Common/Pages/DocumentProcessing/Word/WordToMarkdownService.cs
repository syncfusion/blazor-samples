#region Copyright Syncfusion Inc. 2001 - 2022
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
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


namespace BlazorDemos.Pages.DocumentProcessing.Word
{
    public class WordToMarkdownService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public WordToMarkdownService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        /// <summary>
        /// Convert the Word document to Markdown
        /// </summary>
        /// <returns>Return the resultant WordML as stream</returns>
        public MemoryStream WordToMarkdown(string button)
        {
            string basePath = _hostingEnvironment.WebRootPath;
            string dataPath = basePath + @"/data/word/WordtoMD.docx";
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
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the Word document to MemoryStream
                document.Save(stream, FormatType.Markdown);
                document.Close();
                stream.Position = 0;
                return stream;
            }
            #endregion
        }
    }
}
