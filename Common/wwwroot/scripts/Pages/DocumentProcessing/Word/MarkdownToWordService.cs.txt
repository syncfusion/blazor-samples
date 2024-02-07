#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
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
using System.IO;
using System.Xml;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class MarkdownToWordService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public MarkdownToWordService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Markdown to Word in the Word document
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream MarkdownToWord(string documentType, string button)
        {
            if (button == "View Input Template")
            {
                return fileDataValue["markdown-to-word.md"];
            }
            WordDocument document = new WordDocument(fileDataValue["markdown-to-word.md"], FormatType.Markdown);
            FormatType formatType = FormatType.Docx;
            //Save as HTML format
            if (documentType == "HTML")
                formatType = FormatType.Html;
/*Server:Block*/
#if !(WASM) && !WEBAPP
            //Save as PDF format
            else if(documentType == "PDF")
            {
               DocIORenderer render = new DocIORenderer();
               // Converts Word document into PDF document.
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
#endif
/*End:Server*/
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created Word document to MemoryStream
                document.Save(stream, formatType);
                document.Close();
                stream.Position = 0;
                return stream;
            }
        }
        /// <summary>
        /// Dispose the Dictionary
        /// </summary>
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