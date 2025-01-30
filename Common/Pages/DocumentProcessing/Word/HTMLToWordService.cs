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
using System.Collections.Generic;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class HTMLToWordService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public HTMLToWordService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        public MemoryStream HTMLToWord(string Button)
        {
            if (Button == "View Template")
            {
                return fileDataValue["html-to-word.html"];
            }
            WordDocument document = new WordDocument(fileDataValue["html-to-word.html"], FormatType.Html);
            FormatType type = FormatType.Docx;
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the converted Word document to MemoryStream
                document.Save(stream, type);
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