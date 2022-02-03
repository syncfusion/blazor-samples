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

namespace BlazorDemos.Data.FileFormats.DocIO
{
    public class RTFtoDOCService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public RTFtoDOCService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public MemoryStream RTFtoDOC(string documentType, string Button)
        {
            string basePath = @"wwwroot/";
            string dataPath = basePath + @"data/docio/rtf-to-word.rtf";
            FileStream fileStream = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            if (Button == "View Template")
            {
                MemoryStream ms = new MemoryStream();
                fileStream.Position = 0;
                fileStream.CopyTo(ms);
                fileStream.Close();
                return ms;
            }
            WordDocument document = new WordDocument(fileStream, FormatType.Rtf);
            fileStream.Dispose();
            FormatType type = FormatType.Docx;
            #region Document SaveOption
            //Save as .doc format
            if (documentType == "WordDoc")
            {
                type = FormatType.Doc;
            }
            //Save as .xml format
            else if (documentType == "WordML")
            {
                type = FormatType.WordML;
            }
            #endregion Document SaveOption
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created Word document to MemoryStream
                document.Save(stream, type);
                document.Close();
                stream.Position = 0;
                return stream;
            }
        }
    }
}