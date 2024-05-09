#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion


using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System;
using System.Collections.Generic;
using System.IO;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class CompareDocumentsService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public CompareDocumentsService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Compare Word Documents.
        /// </summary>
        /// <returns>Return the resultant Word document as stream</returns>
        public MemoryStream CompareDocuments(bool isDetectFormat)
        {
            //Loads the original template document.
            using (WordDocument originalDocument = new WordDocument(fileDataValue["original-document.docx"], FormatType.Docx))
            {
                //Loads the revised template document.
                using (WordDocument revisedDocument = new WordDocument(fileDataValue["revised-document.docx"], FormatType.Docx))
                {
                    if (isDetectFormat)
                    {
                        //Compares the original document with revised document
                        originalDocument.Compare(revisedDocument, "Nancy Davolio", DateTime.Now.AddDays(-1));
                    }
                    else
                    {
                        //Disable the flag to ignore the formatting changes while comparing the documents
                        ComparisonOptions comparisonOptions = new ComparisonOptions();
                        comparisonOptions.DetectFormatChanges = false;
                        originalDocument.Compare(revisedDocument, "Nancy Davolio", DateTime.Now.AddDays(-1), comparisonOptions);
                    }
                    //Save the document as a stream and return the stream
                    using (MemoryStream stream = new MemoryStream())
                    {
                        //Save the created Word document to MemoryStream
                        originalDocument.Save(stream, FormatType.Docx);
                        originalDocument.Close();
                        stream.Position = 0;
                        return stream;
                    }
                } 
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