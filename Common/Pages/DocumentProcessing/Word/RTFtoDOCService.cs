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

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class RTFtoDOCService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public RTFtoDOCService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        public MemoryStream RTFtoDOC(string documentType, string Button)
        {
            if (Button == "View Template")
            {
                return fileDataValue["rtf-to-word.rtf"];
            }
            WordDocument document = new WordDocument(fileDataValue["rtf-to-word.rtf"], FormatType.Rtf);
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