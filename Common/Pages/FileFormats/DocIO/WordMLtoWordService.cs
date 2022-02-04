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
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace BlazorDemos.Data.FileFormats.DocIO
{
    public class WordMLtoWordService
    {
        /// <summary>
        /// WordML to Word in the Word document
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream WordMLtoWord(string documentType, string button)
        {
            string basePath = @"wwwroot/";
            string dataPath = basePath + @"data/docio/wordml-to-doc.xml";
            FileStream fileStream = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            if (button == "View Template")
            {
                MemoryStream ms = new MemoryStream();
                fileStream.Position = 0;
                fileStream.CopyTo(ms);
                fileStream.Close();
                return ms;
            }
            WordDocument document = new WordDocument(fileStream, FormatType.WordML);
            fileStream.Dispose();
            fileStream = null;
            FormatType formatType = FormatType.Docx;
            //Save as .doc format
            if (documentType == "WordDoc")
                formatType = FormatType.Doc;           
            //Save the document as a stream and retrun the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created Word document to MemoryStream
                document.Save(stream, formatType);
                document.Close();
                stream.Position = 0;
                return stream;
            }
        }
    }    
}