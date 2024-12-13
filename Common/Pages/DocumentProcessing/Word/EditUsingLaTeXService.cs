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
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class EditUsingLaTeXService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public EditUsingLaTeXService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Markdown to Word in the Word document
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream EditUsingLaTeX(string documentType, string button, string laTeX)
        {
            if (button == "View Template")
            {
                return fileDataValue["edit-equation-latex-input.docx"];
            }
            WordDocument document = new WordDocument(fileDataValue["edit-equation-latex-input.docx"], FormatType.Docx);
			
            //Find all the equations in the Word document.
            List<Entity> entities = document.FindAllItemsByProperty(EntityType.Math, null, null);

            WMath math = entities[0] as WMath;
            if (!string.IsNullOrEmpty(laTeX))
               //Update the modified laTeX code to the equation.
               math.MathParagraph.LaTeX = laTeX;
			
            FormatType formatType = FormatType.Docx;
/*Server:Block*/
#if !(WASM) && !WEBAPP
            //Save as PDF format
            if(documentType == "PDF")
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
#endif
/*End:Server*/
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