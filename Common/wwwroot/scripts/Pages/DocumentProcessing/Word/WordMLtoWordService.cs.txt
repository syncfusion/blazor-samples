#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
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

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class WordMLtoWordService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public WordMLtoWordService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// WordML to Word in the Word document
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream WordMLtoWord(string documentType, string button)
        {
            if (button == "View Template")
            {
                return fileDataValue["wordml-to-doc.xml"];
            }
            WordDocument document = new WordDocument(fileDataValue["wordml-to-doc.xml"], FormatType.WordML);
            FormatType formatType = FormatType.Docx;
            //Save as .doc format
            if (documentType == "WordDoc")
                formatType = FormatType.Doc;           
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
        #region HelperMethod
        /// <summary>
        /// Dispose the Dictionary
        /// </summary>
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