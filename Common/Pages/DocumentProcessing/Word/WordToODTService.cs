#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.Collections.Generic;
using System.IO;


namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class WordToODTService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public WordToODTService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Convert the Word document to ODT
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream WordToODT(string button)
        {
            if (button == "View Template")
            {
                return fileDataValue["word-to-odt.docx"];
            }
            WordDocument document = new WordDocument(fileDataValue["word-to-odt.docx"], FormatType.Automatic);
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