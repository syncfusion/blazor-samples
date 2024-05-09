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
    public class WordToWordMLService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public WordToWordMLService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Convert the Word document to Word processing XML
        /// </summary>
        /// <returns>Return the resultant WordML as stream</returns>
        public MemoryStream WordToWordML(string button)
        {
            if (button == "View Template")
            {
                return fileDataValue["doc-to-wordml.doc"];
            }
            //Loads the template Word document
            WordDocument document = new WordDocument(fileDataValue["doc-to-wordml.doc"], FormatType.Automatic);

            #region Saving document
            //Save the document as a stream and return the stream
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
