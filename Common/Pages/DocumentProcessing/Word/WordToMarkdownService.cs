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
using System.IO;
using System.Collections.Generic;



namespace BlazorDemos.Pages.DocumentProcessing.Word
{
    public class WordToMarkdownService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public WordToMarkdownService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Convert the Word document to Markdown
        /// </summary>
        /// <returns>Return the resultant WordML as stream</returns>
        public MemoryStream WordToMarkdown(string button)
        {
            if (button == "View Template")
            {
                return fileDataValue["word-to-md.docx"];
            }
            //Loads the template Word document
            WordDocument document = new WordDocument(fileDataValue["word-to-md.docx"], FormatType.Automatic);

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
