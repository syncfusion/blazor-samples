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
using System.IO;
using System.Collections.Generic;
using Syncfusion.Office;
using System;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class CreateUsingLaTeXService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public CreateUsingLaTeXService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        public MemoryStream CreateUsingLaTeX(string documentType, string LaTeX)
        {

            // Creates an empty Word document instance
            WordDocument document = new WordDocument();
            // Opens template document
            document.Open(fileDataValue["create-equation.docx"], FormatType.Docx);

            //Get the last section in the document
            WSection section = document.LastSection;
            //Set page margins
            section.PageSetup.Margins.All = 72;
            //Add new paragraph to the section
            IWParagraph paragraph = section.AddParagraph();

            //Append text to paragraph
            IWTextRange textRange = paragraph.AppendText("Mathematical equation");
            textRange.CharacterFormat.FontSize = 28;
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
            paragraph.ParagraphFormat.AfterSpacing = 12;

            //Add new paragraph to the section.
            paragraph = section.AddParagraph();
            //Append mathematical equation using LaTeX.
            if(!string.IsNullOrEmpty(LaTeX))
                paragraph.AppendMath(LaTeX);

            FormatType type = FormatType.Docx;
            /*Server:Block*/
            #region Document SaveOption
#if !(WASM) && !WEBAPP
            //Save as .pdf format
            if (documentType == "PDF")
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
            else
            {
#endif
            /*End:Server*/
            using (MemoryStream stream = new MemoryStream())
                {
                    //Save the created Word document to MemoryStream
                    document.Save(stream, type);
                    document.Close();
                    stream.Position = 0;
                    return stream;
                }
            /*Server:Block*/
#if !(WASM) && !WEBAPP
            }
#endif
            /*End:Server*/
            #endregion Document SaveOption            
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