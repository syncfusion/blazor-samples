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
using Syncfusion.Office;
using Syncfusion.DocIORenderer;
using Syncfusion.Pdf;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class EditEquationService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public EditEquationService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        public MemoryStream EditEquation(string documentType)
        {

            // Creates an empty Word document instance         
            WordDocument document = new WordDocument();
            // Opens template document
            document.Open(fileDataValue["mathematical-equation.docx"], FormatType.Docx);
            //Gets the last section in the document
            WSection section = document.LastSection;
            //Gets paragraph from Word document
            WParagraph paragraph = document.LastSection.Body.ChildEntities[3] as WParagraph;

            //Gets MathML from the paragraph
            WMath math = paragraph.ChildEntities[0] as WMath;
            //Gets the radical equation
            IOfficeMathRadical mathRadical = math.MathParagraph.Maths[0].Functions[1] as IOfficeMathRadical;
            //Gets the fraction equation in radical
            IOfficeMathFraction mathFraction = mathRadical.Equation.Functions[0] as IOfficeMathFraction;
            //Gets the n-array in fraction
            IOfficeMathNArray mathNAry = mathFraction.Numerator.Functions[0] as IOfficeMathNArray;
            //Gets the math script in n-array
            IOfficeMathScript mathScript = mathNAry.Equation.Functions[0] as IOfficeMathScript;
            //Gets the delimiter in math script
            IOfficeMathDelimiter mathDelimiter = mathScript.Equation.Functions[0] as IOfficeMathDelimiter;
            //Gets the math script in delimiter
            mathScript = mathDelimiter.Equation[0].Functions[0] as IOfficeMathScript;
            //Gets the math run element in math script
            IOfficeMathRunElement mathParaItem = mathScript.Equation.Functions[0] as IOfficeMathRunElement;
            //Modifies the math text value
            (mathParaItem.Item as WTextRange).Text = "x";

            //Gets the math bar in delimiter
            IOfficeMathBar mathBar = mathDelimiter.Equation[0].Functions[2] as IOfficeMathBar;
            //Gets the math run element in bar
            mathParaItem = mathBar.Equation.Functions[0] as IOfficeMathRunElement;
            //Modifies the math text value
            (mathParaItem.Item as WTextRange).Text = "x";

            //Gets the paragraph from Word document
            paragraph = document.LastSection.Body.ChildEntities[6] as WParagraph;
            //Gets MathML from the paragraph
            math = paragraph.ChildEntities[0] as WMath;
            //Gets the math script equation
            mathScript = math.MathParagraph.Maths[0].Functions[0] as IOfficeMathScript;
            //Gets the math run element in math script
            mathParaItem = mathScript.Equation.Functions[0] as IOfficeMathRunElement;
            //Modifies the math text value
            (mathParaItem.Item as WTextRange).Text = "x";

            //Gets the paragraph from Word document
            paragraph = document.LastSection.Body.ChildEntities[7] as WParagraph;
            //Gets MathML from the paragraph
            WMath math2 = paragraph.ChildEntities[0] as WMath;
            //Gets bar equation
            mathBar = math2.MathParagraph.Maths[0].Functions[0] as IOfficeMathBar;
            //Gets the math run element in bar
            mathParaItem = mathBar.Equation.Functions[0] as IOfficeMathRunElement;
            //Gets the math text
            (mathParaItem.Item as WTextRange).Text = "x";
            
            
            FormatType type = FormatType.Docx;
            /*Server:Block*/
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