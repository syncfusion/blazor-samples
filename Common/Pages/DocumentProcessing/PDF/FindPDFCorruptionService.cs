#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Pdf;
using System.IO;
using Syncfusion.Pdf.Parsing;
using System.Text;
using System.Collections.Generic;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class FindPDFCorruptionService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public FindPDFCorruptionService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }


        /// <summary>
        /// Find PDF document Corruption
        /// </summary>
        /// <returns>Return the corrupted document result as string</returns>
        public string FindPDFCorruptionPDF()
        {
            //Initialize the instance of FindPDFCorruptionMessage.
            FindPDFCorruptionMessage message = new FindPDFCorruptionMessage();           
            //Create a new instance for the PDF analyzer.
            PdfDocumentAnalyzer analyzer = new PdfDocumentAnalyzer(fileDataValue["corrupted-document.pdf"]);

            //Get the syntax errors.
            SyntaxAnalyzerResult result = analyzer.AnalyzeSyntax();

            //Check whether the document is corrupted or not.
            if (result.IsCorrupted)
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("The PDF document is corrupted.");
                int count = 1;
                foreach (PdfException exception in result.Errors)
                {
                    builder.AppendLine(count++.ToString() + ": " + exception.Message);
                }
                message.Message = builder.ToString();
            }
            Close();
            return message.Message;
        }

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
    /// <summary>
    /// To store and update the Corruption Message
    /// </summary>
    public class FindPDFCorruptionMessage
    {
        public string Message { get; set; }
    }
}
