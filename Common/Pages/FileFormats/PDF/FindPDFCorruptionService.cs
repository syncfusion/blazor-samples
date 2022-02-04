#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Pdf;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Syncfusion.Pdf.Parsing;
using System.Text;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class FindPDFCorruptionService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public FindPDFCorruptionService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        
        /// <summary>
        /// Find PDF document Corruption
        /// </summary>
        /// <returns>Return the corrupted document result as string</returns>
        public string FindPDFCorruptionPDF()
        {
            //Initialize the instance of  FindPDFCorruptionMessage.
            FindPDFCorruptionMessage message = new FindPDFCorruptionMessage();
            FileStream pdfFile = new FileStream(ResolveApplicationPath("corrupted-document.pdf"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            //Create a new instance for the PDF analyzer.
            PdfDocumentAnalyzer analyzer = new PdfDocumentAnalyzer(pdfFile);

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

            return message.Message;
        }
        
        #region HelperMethod
        private string ResolveApplicationPath(string fileName)
        {
            return _hostingEnvironment.WebRootPath + "//data//pdf//" + fileName;
        }
        #endregion
    }
    /// <summary>
    /// To store and update the  Corruption Message
    /// </summary>
    public class FindPDFCorruptionMessage
    {
        public string Message { get; set; }
    }
}
