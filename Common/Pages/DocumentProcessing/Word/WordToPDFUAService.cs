#region Copyright Syncfusion Inc. 2001 - 2022
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIORenderer;
using Syncfusion.Pdf;
using Syncfusion.Drawing;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Xml;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class WordToPDFUAService
    {
        /// <summary>
        /// Generate a letter using Mail merge functionality of Essential DocIO
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream WordToPDF(string button)
        {
            string basePath = @"wwwroot/";
            string dataPath = basePath + @"data/word/doc-to-pdf.docx";
            FileStream fileStream = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            if (button == "View Template")
            {
                MemoryStream ms = new MemoryStream();
                fileStream.Position = 0;
                fileStream.CopyTo(ms);
                fileStream.Dispose();
                return ms;
            }
            fileStream = null;
            // Load the template.
            FileStream fileStreamPath = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            WordDocument document = new WordDocument(fileStreamPath, FormatType.Doc);
            fileStreamPath.Dispose();
            fileStreamPath = null;
            DocIORenderer render = new DocIORenderer();
            //Sets true to preserve document structured tags in the converted PDF document.
            render.Settings.AutoTag = true;
            // Converts Word document into PDF/UA document.
            PdfDocument pdf = render.ConvertToPDF(document);
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created PDF document to MemoryStream
                pdf.Save(stream);
                render.Dispose();
                pdf.Close();
                document.Close();
                stream.Position = 0;
                return stream;
            }
        }
    }  
}