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
    public class CreateEquationService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public CreateEquationService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        public MemoryStream CreateEquation(string documentType)
        {

            // Creates an empty Word document instance
            WordDocument document = new WordDocument();
            // Opens template document
            document.Open(fileDataValue["create-equation.docx"], FormatType.Docx);
            //Gets the last section in the document
            WSection section = document.LastSection;
            //Sets page margins
            document.LastSection.PageSetup.Margins.All = 72;
            //Adds new paragraph to the section
            IWParagraph paragraph = section.AddParagraph();

            //Appends text to paragraph
            IWTextRange textRange = paragraph.AppendText("Mathematical equations");
            textRange.CharacterFormat.FontSize = 28;
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
            paragraph.ParagraphFormat.AfterSpacing = 12;

            #region Sum to the power of n
            //Adds new paragraph to the section
            paragraph = AddParagraph(section, "This is an expansion of the sum (1+X) to the power of n.");
            //Creates an equation with sum to the power of N
            CreateSumToThePowerOfN(paragraph);
            #endregion

            #region Fourier series
            //Adds new paragraph to the section
            paragraph = AddParagraph(section, "This is a Fourier series for the function of period 2L");
            //Creates a Fourier series equation
            CreateFourierseries(paragraph);
            #endregion

            #region Triple scalar product
            //Adds new paragraph to the section
            paragraph = AddParagraph(section, "This is an expansion of triple scalar product");
            //Creates a triple scalar product equation
            CreateTripleScalarProduct(paragraph);
            #endregion

            #region Gamma function
            //Adds new paragraph to the section
            paragraph = AddParagraph(section, "This is an expansion of gamma function");
            //Creates a gamma function equation
            CreateGammaFunction(paragraph);
            #endregion

            #region Vector relation
            //Adds new paragraph to the section
            paragraph = AddParagraph(section, "This is an expansion of vector relation ");
            //Creates a vector relation equation
            CreateVectorRelation(paragraph);
            #endregion
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

        #region Helper Methods
        /// <summary>
        /// Adds new paragraph into the section
        /// </summary>
        /// <param name="section">Represents a section in Word document</param>
        /// <param name="text">Represents a text to append in paragraph</param>
        /// <returns>Returns a paragraph to add equation</returns>
        private IWParagraph AddParagraph(IWSection section, string text)
        {
            //Adds new paragraph to the section
            IWParagraph paragraph = section.AddParagraph();
            //Adds new paragraph to add text
            paragraph = section.AddParagraph();
            //Appends text to paragraph
            paragraph.AppendText(text);
            paragraph.ParagraphFormat.AfterSpacing = 12;
            paragraph.ParagraphFormat.BeforeSpacing = 12;
            //Adds new paragraph to add equation
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.AfterSpacing = 12;
            return paragraph;
        }
        /// <summary>
        /// Creates an expansion of triple scalar product
        /// </summary>
        /// <param name="paragraph">Represents a paragraph to add MathML element</param>
        private void CreateTripleScalarProduct(IWParagraph paragraph)
        {
            WordDocument document = paragraph.Document;
            //Creates a MathML element
            WMath math = paragraph.AppendMath();
            //Adds an office math
            IOfficeMath officeMath = math.MathParagraph.Maths.Add();

            #region Math text
            //Unicode value of middle dot
            string middleDot = "\u00B7";
            string multiplicationSign = "\u00D7";
            string text = "A" + middleDot + "B" + multiplicationSign + "C";
            //Adds a math item
            IOfficeMathRunElement officeMathParaItem = AddMathText(document, officeMath, text);
            //Sets style for math text
            officeMathParaItem.MathFormat.Style = MathStyleType.Bold;

            //Adds math text
            officeMathParaItem = AddMathText(document, officeMath, "=");
            //Sets style for math text
            officeMathParaItem.MathFormat.Style = MathStyleType.Bold;

            //Adds math text
            text = "A" + multiplicationSign + "B" + middleDot + "C";
            officeMathParaItem = AddMathText(document, officeMath, text);
            //Sets style for math text
            officeMathParaItem.MathFormat.Style = MathStyleType.Bold;

            //Adds math text
            officeMathParaItem = AddMathText(document, officeMath, "=");
            #endregion

            #region Delimiter
            //Adds a delimiter 
            IOfficeMathDelimiter mathDelimiter = officeMath.Functions.Add(MathFunctionType.Delimiter) as IOfficeMathDelimiter;
            //Sets begin character for delimiter
            mathDelimiter.BeginCharacter = "|";
            //Sets end character for delimiter
            mathDelimiter.EndCharacter = "|";
            //Apply formats for delimiter
            mathDelimiter.ControlProperties = new WCharacterFormat(document);
            (mathDelimiter.ControlProperties as WCharacterFormat).Italic = true;

            //Adds arguments for delimiter
            officeMath = mathDelimiter.Equation.Add() as IOfficeMath;

            #region Matrix
            //Add matrix into delimiter
            IOfficeMathMatrix mathMatrix = officeMath.Functions.Add(MathFunctionType.Matrix) as IOfficeMathMatrix;
            //Add columns in matrix
            mathMatrix.Columns.Add();
            mathMatrix.Columns.Add();
            mathMatrix.Columns.Add();


            #region First row
            //Adds a new row
            IOfficeMathMatrixRow mathMatrixRow = mathMatrix.Rows.Add();
            ///Add values to row
            AddMatrixRowValues(document, mathMatrixRow, "A");
            #endregion

            #region Second row
            //Adds a new row
            mathMatrixRow = mathMatrix.Rows.Add();
            ///Add values to row
            AddMatrixRowValues(document, mathMatrixRow, "B");
            #endregion

            #region Third row
            //Adds a new row
            mathMatrixRow = mathMatrix.Rows.Add();
            ///Add values to row
            AddMatrixRowValues(document, mathMatrixRow, "C");
            #endregion
            #endregion

            #endregion
        }
        /// <summary>
        /// Creates an expansion of vector relation
        /// </summary>
        /// <param name="paragraph">Represents a paragraph to add MathML element</param>
        private void CreateVectorRelation(IWParagraph paragraph)
        {
            WordDocument document = paragraph.Document;
            //Creates a MathML element
            WMath math = paragraph.AppendMath();

            IOfficeMath officeMath = math.MathParagraph.Maths.Add();
            //Adds an accent equation
            AddMathAccent(document, officeMath, 8407, "A");

            //Adds a math text
            string middleDot = "\u00B7";
            officeMath = math.MathParagraph.Maths.Add();
            IOfficeMathRunElement officeMathParaItem = AddMathText(document, officeMath, middleDot);

            //Adds an accent equation
            officeMath = math.MathParagraph.Maths.Add();
            AddMathAccent(document, officeMath, 8407, "B");

            //Adds a math text
            officeMath = math.MathParagraph.Maths.Add();
            string multiplicationSign = "\u00D7";
            officeMathParaItem = AddMathText(document, officeMath, multiplicationSign);

            //Adds an accent equation
            officeMath = math.MathParagraph.Maths.Add();
            AddMathAccent(document, officeMath, 8407, "C");

            //Adds a math text
            officeMath = math.MathParagraph.Maths.Add();
            officeMathParaItem = AddMathText(document, officeMath, "=");

            //Adds an accent equation
            officeMath = math.MathParagraph.Maths.Add();
            AddMathAccent(document, officeMath, 8407, "A");

            //Adds a math text
            officeMath = math.MathParagraph.Maths.Add();
            officeMathParaItem = AddMathText(document, officeMath, multiplicationSign);

            //Adds an accent equation
            officeMath = math.MathParagraph.Maths.Add();
            AddMathAccent(document, officeMath, 8407, "B");

            //Adds a math text
            officeMath = math.MathParagraph.Maths.Add();
            officeMathParaItem = AddMathText(document, officeMath, middleDot);

            //Adds an accent equation
            officeMath = math.MathParagraph.Maths.Add();
            AddMathAccent(document, officeMath, 8407, "C");
        }
        /// <summary>
        /// Converts short value to string
        /// </summary>
        /// <param name="value">Represents a short value</param>
        private static string ConvertShortToString(short value)
        {
            char chrValue = Convert.ToChar(value);
            string strValue = Convert.ToString(chrValue);
            return strValue;
        }
        /// <summary>
        /// Creates an equation with sum to the power of N
        /// </summary>
        /// <param name="paragraph">Represents a paragraph to add MathML element</param>
        private void CreateSumToThePowerOfN(IWParagraph paragraph)
        {
            WordDocument document = paragraph.Document;
            //Creates a new MathML element
            WMath math = paragraph.AppendMath();

            IOfficeMath officeMath = math.MathParagraph.Maths.Add();
            //Adds a math script element
            IOfficeMathScript mathScript = AddMathScript(officeMath, MathScriptType.Superscript);

            #region Delimiter equation
            //Adds a delimiter
            IOfficeMathDelimiter mathDelimiter = mathScript.Equation.Functions.Add(MathFunctionType.Delimiter) as IOfficeMathDelimiter;
            //Adds an office math in the delimiter
            officeMath = mathDelimiter.Equation.Add() as IOfficeMath;
            //Adds a math text
            IOfficeMathRunElement mathParaItem = AddMathText(document, officeMath, "1+x");
            //Adds a math text
            mathParaItem = AddMathText(document, mathScript.Script, "n");
            #endregion

            //Adds a math text
            officeMath = math.MathParagraph.Maths.Add(1);
            mathParaItem = AddMathText(document, officeMath, "=1+");

            #region Fraction equation
            //Adds a math fraction
            IOfficeMathFraction mathFraction = math.MathParagraph.Maths.Add().Functions.Add(MathFunctionType.Fraction) as IOfficeMathFraction;
            //Adds a numerator text
            AddMathText(document, mathFraction.Numerator, "nx");
            //Adds a denominator text
            AddMathText(document, mathFraction.Denominator, "1!");
            #endregion

            //Adds a math text
            officeMath = math.MathParagraph.Maths.Add();
            mathParaItem = AddMathText(document, officeMath, "+");

            #region Fraction equation
            //Adds a math fraction
            mathFraction = math.MathParagraph.Maths.Add().Functions.Add(MathFunctionType.Fraction) as IOfficeMathFraction;

            #region Numerator
            //Adds a numerator text
            AddMathText(document, mathFraction.Numerator, "n");

            //Adds a delimiter
            mathDelimiter = mathFraction.Numerator.Functions.Add(MathFunctionType.Delimiter) as IOfficeMathDelimiter;
            //Adds a math text for delimiter
            officeMath = mathDelimiter.Equation.Add() as IOfficeMath;
            AddMathText(document, officeMath, "n-1");

            //Adds a math script
            mathScript = mathFraction.Numerator.Functions.Add(MathFunctionType.SubSuperscript) as IOfficeMathScript;
            //Adds a math text for Superscript
            AddMathText(document, mathScript.Equation, "x");
            AddMathText(document, mathScript.Script, "2");
            #endregion

            #region Denominator
            //Adds a math text for denominator
            AddMathText(document, mathFraction.Denominator, "2!");
            #endregion
            #endregion

            //Adds a math text
            officeMath = math.MathParagraph.Maths.Add();
            AddMathText(document, officeMath, "+...");
        }
        /// <summary>
        /// Creates an expansion of Gamma function
        /// </summary>
        /// <param name="paragraph">Represents a paragraph to add MathML element</param>
        private void CreateGammaFunction(IWParagraph paragraph)
        {
            WordDocument document = paragraph.Document;
            //Creates a new MathML element
            WMath math = paragraph.AppendMath();

            //Adds a math text
            IOfficeMath officeMath = math.MathParagraph.Maths.Add();
            //Unicode value of capital gamma
            string capitalGamma = "\u0393";
            IOfficeMathRunElement officeMathParaItem = AddMathText(document, officeMath, capitalGamma);
            //Sets MathML style format for the text
            officeMathParaItem.MathFormat.Style = MathStyleType.Regular;

            //Adds a delimiter equation
            IOfficeMathDelimiter mathDelimiter = math.MathParagraph.Maths.Add().Functions.Add(MathFunctionType.Delimiter) as IOfficeMathDelimiter;
            //Adds a equation to the delimiter
            officeMath = mathDelimiter.Equation.Add();
            //Adds a math text
            officeMathParaItem = AddMathText(document, officeMath, "z");

            //Adds a math text
            officeMath = math.MathParagraph.Maths.Add();
            officeMathParaItem = AddMathText(document, officeMath, "=");

            //Adds an n array element
            IOfficeMathNArray mathNAry = math.MathParagraph.Maths.Add().Functions.Add(MathFunctionType.NArray) as IOfficeMathNArray;
            //Adds a math text
            AddMathText(document, mathNAry.Subscript, "0");

            //Adds a math text
            string infinitySymbol = "\u221E";
            AddMathText(document, mathNAry.Superscript, infinitySymbol);

            //Adds a math superscript
            IOfficeMathScript mathScript = AddMathScript(mathNAry.Equation, MathScriptType.Superscript);
            //Adds a math text for Superscript
            AddMathText(document, mathScript.Equation, "t");
            AddMathText(document, mathScript.Script, "z-1");
            //Adds a Superscript
            mathScript = AddMathScript(mathNAry.Equation, MathScriptType.Superscript);

            AddMathText(document, mathScript.Equation, "e");
            AddMathText(document, mathScript.Script, "-t");

            //Adds a math text in n Array equation
            AddMathText(document, mathNAry.Equation, "dt");

            //Adds a math text
            AddMathText(document, math.MathParagraph.Maths.Add(), "=");

            //Adds a fraction equation
            IOfficeMathFraction mathFraction = math.MathParagraph.Maths.Add().Functions.Add(MathFunctionType.Fraction) as IOfficeMathFraction;
            //Adds a math script
            mathScript = AddMathScript(mathFraction.Numerator, MathScriptType.Superscript);

            //Adds a math text for Superscript
            AddMathText(document, mathScript.Equation, "e");
            AddMathText(document, mathScript.Script, "-");
            //Unicode of small gamma
            string smallGamma = "\u03B3";
            AddMathText(document, mathScript.Script, smallGamma);
            AddMathText(document, mathScript.Script, "z");


            //Adds a math text for denominator
            AddMathText(document, mathFraction.Denominator, "z");

            //Adds an n-array element
            mathNAry = math.MathParagraph.Maths.Add().Functions.Add(MathFunctionType.NArray) as IOfficeMathNArray;
            //Unicode value of n-array product
            string symbol = "\u220F";
            //Adds a n-array character
            mathNAry.NArrayCharacter = symbol;
            //Adds a math text
            AddMathText(document, mathNAry.Subscript, "k=1");
            //Adds a math text
            AddMathText(document, mathNAry.Superscript, infinitySymbol);

            //Adds a math script
            mathScript = AddMathScript(mathNAry.Equation, MathScriptType.Superscript);
            //Adds a math delimiter element
            mathDelimiter = mathScript.Equation.Functions.Add(MathFunctionType.Delimiter) as IOfficeMathDelimiter;
            //Adds a equation to the delimiter equation collection
            officeMath = mathDelimiter.Equation.Add();
            //Adds a math text
            AddMathText(document, officeMath, "1+");

            //Adds a fraction element
            mathFraction = officeMath.Functions.Add(MathFunctionType.Fraction) as IOfficeMathFraction;
            //Adds a math text for numerator
            AddMathText(document, mathFraction.Numerator, "z");
            //Adds a math text for denominator
            AddMathText(document, mathFraction.Denominator, "k");

            //Adds a math text
            AddMathText(document, mathScript.Script, "-1");
            //Adds a Superscript equation
            mathScript = AddMathScript(mathNAry.Equation, MathScriptType.Superscript);
            //Adds a math text for Superscript
            AddMathText(document, mathScript.Equation, "e");
            AddMathText(document, mathScript.Script, "z");
            officeMathParaItem = AddMathText(document, mathScript.Script, "/");
            officeMathParaItem.MathFormat.HasLiteral = true;
            AddMathText(document, mathScript.Script, "k");

            //Adds a math text
            AddMathText(document, math.MathParagraph.Maths.Add(), ",");

            //Adds a math text
            officeMathParaItem = AddMathText(document, math.MathParagraph.Maths.Add(), "  ");
            //Sets style for math text
            officeMathParaItem.MathFormat.Style = MathStyleType.Regular;

            //Adds a math text
            AddMathText(document, math.MathParagraph.Maths.Add(), smallGamma);
            string text = "\u2248" + "0.577216";
            AddMathText(document, math.MathParagraph.Maths.Add(), text);
        }
        /// <summary>
        /// Creates a Fourier series equation
        /// </summary>
        /// <param name="paragraph">Represents a paragraph to add MathML element</param>
        private void CreateFourierseries(IWParagraph paragraph)
        {
            WordDocument document = paragraph.Document;
            //Creates a new MathML element
            WMath math = paragraph.AppendMath();

            //Adds a math
            IOfficeMath officeMath = math.MathParagraph.Maths.Add();
            //Adds a math text
            AddMathText(document, officeMath, "f");

            //Adds a math delimiter
            IOfficeMathDelimiter mathDelimiter = math.MathParagraph.Maths.Add().Functions.Add(MathFunctionType.Delimiter) as IOfficeMathDelimiter;
            //Adds a math in the delimiter
            officeMath = mathDelimiter.Equation.Add() as IOfficeMath;
            //Adds a math text
            AddMathText(document, officeMath, "x");
            AddMathText(document, math.MathParagraph.Maths.Add(), "=");
            //Adds a Subscript equation
            IOfficeMathScript mathScript = AddMathScript(math.MathParagraph.Maths.Add(), MathScriptType.Subscript);
            //Adds a math text
            AddMathText(document, mathScript.Equation, "a");
            AddMathText(document, mathScript.Script, "0");

            //Adds a math text
            AddMathText(document, math.MathParagraph.Maths.Add(), "+");

            //Adds a math n-array
            IOfficeMathNArray mathNAry = math.MathParagraph.Maths.Add().Functions.Add(MathFunctionType.NArray) as IOfficeMathNArray;
            //Unicode value of n-array summation
            string sigma = "\u2211";
            //Sets the value as the n-array character
            mathNAry.NArrayCharacter = sigma;
            mathNAry.HasGrow = true;
            //Adds a math text
            AddMathText(document, mathNAry.Subscript, "n=1");

            //Adds a math text
            string infinitySymbol = "\u221E";
            AddMathText(document, mathNAry.Superscript, infinitySymbol);
            //Adds a math delimiter
            mathDelimiter = mathNAry.Equation.Functions.Add(MathFunctionType.Delimiter) as IOfficeMathDelimiter;
            //Adds an math in the delimiter equation collection
            officeMath = mathDelimiter.Equation.Add() as IOfficeMath;
            //Adds a math script
            mathScript = AddMathScript(officeMath, MathScriptType.Subscript);

            //Adds a math text
            AddMathText(document, mathScript.Equation, "a");

            //Adds a math text
            AddMathText(document, mathScript.Script, "n");

            //Adds a math function
            IOfficeMathFunction mathFunction = officeMath.Functions.Add(MathFunctionType.Function) as IOfficeMathFunction;
            //Adds a math text
            IOfficeMathRunElement mathParaItem = AddMathText(document, mathFunction.FunctionName, "cos");
            mathParaItem.MathFormat.Style = MathStyleType.Regular;

            //Adds a math fraction
            IOfficeMathFraction mathFraction = mathFunction.Equation.Functions.Add(MathFunctionType.Fraction) as IOfficeMathFraction;
            //Adds a math text
            //Unicode value of PI
            string pi = "\uD835\uDF0B";
            string text = "n" + pi + "x";
            AddMathText(document, mathFraction.Numerator, text);
            AddMathText(document, mathFraction.Denominator, "L");

            //Adds a math text
            AddMathText(document, officeMath, "+");
            //Adds a math script
            mathScript = AddMathScript(officeMath, MathScriptType.Subscript);
            //Adds a math text
            AddMathText(document, mathScript.Equation, "b");
            AddMathText(document, mathScript.Script, "n");

            //Adds a function
            mathFunction = officeMath.Functions.Add(MathFunctionType.Function) as IOfficeMathFunction;
            //Adds a math text
            mathParaItem = AddMathText(document, mathFunction.FunctionName, "sin");
            mathParaItem.MathFormat.Style = MathStyleType.Regular;

            //Adds a math fraction element
            mathFraction = mathFunction.Equation.Functions.Add(MathFunctionType.Fraction) as IOfficeMathFraction;
            //Adds a math text for numerator
            AddMathText(document, mathFraction.Numerator, text);
            //Adds a math text for denominator
            AddMathText(document, mathFraction.Denominator, "L");
        }
        /// <summary>
        /// Adds a math text
        /// </summary>
        /// <param name="document">Represents a Word document to add math text</param>
        /// <param name="officeMath">Represents an office math to add math text</param>
        /// <param name="text">Represents the text to set for math item</param>
        private IOfficeMathRunElement AddMathText(WordDocument document, IOfficeMath officeMath, string text)
        {
            //Adds math text
            IOfficeMathRunElement officeMathParaItem = officeMath.Functions.Add(MathFunctionType.RunElement) as IOfficeMathRunElement;
            officeMathParaItem.Item = new WTextRange(document);
            //Set math text value
            (officeMathParaItem.Item as WTextRange).Text = text;
            return officeMathParaItem;
        }
        /// <summary>
        /// Adds a math Subscript or Superscript equation
        /// </summary>
        private IOfficeMathScript AddMathScript(IOfficeMath officeMath, MathScriptType mathScriptType)
        {
            IOfficeMathScript mathScript = officeMath.Functions.Add(MathFunctionType.SubSuperscript) as IOfficeMathScript;
            //Sets the script type as Subscript or Superscript
            mathScript.ScriptType = mathScriptType;
            return mathScript;
        }
        /// <summary>
        /// Adds a accent equation
        /// </summary>
        /// <param name="document">Represents a Word document</param>
        /// <param name="officeMath">Represents a office math to add accent equation</param>
        /// <param name="accentCharValue">Represents a accent character</param>
        /// <param name="text">Represents a text for accent equation</param>
        private void AddMathAccent(WordDocument document, IOfficeMath officeMath, short accentCharValue, string text)
        {
            IOfficeMathAccent mathAccent = officeMath.Functions.Add(MathFunctionType.Accent) as IOfficeMathAccent;
            //Sets the accent character from short value
            mathAccent.AccentCharacter = ConvertShortToString(accentCharValue);
            //Adds a math text
            IOfficeMathRunElement officeMathParaItem = AddMathText(document, mathAccent.Equation, text);
        }
        /// <summary>
        /// Add values in matrix row
        /// </summary>
        /// <param name="document">Represents a Word document to add matrix</param>
        /// <param name="mathMatrixRow">Represents a matrix row to add values</param>
        /// <param name="text">Represents a base text value for Subscript and Superscript equation</param>
        private void AddMatrixRowValues(WordDocument document, IOfficeMathMatrixRow mathMatrixRow, string text)
        {
            //Adds arguments for matrix row
            IOfficeMath officeMath = mathMatrixRow.Arguments[0];
            //Adds a Subscript
            IOfficeMathScript mathScript = AddMathScript(officeMath, MathScriptType.Subscript);
            //Adds a math text
            IOfficeMathRunElement officeMathParaItem = AddMathText(document, mathScript.Equation, text);
            //Adds math text
            officeMathParaItem = AddMathText(document, mathScript.Script, "x");

            //Adds arguments for matrix row
            officeMath = mathMatrixRow.Arguments[1];
            //Adds a script
            mathScript = AddMathScript(officeMath, MathScriptType.Subscript);
            //Adds math text
            officeMathParaItem = AddMathText(document, mathScript.Equation, text);
            //Adds math text
            officeMathParaItem = AddMathText(document, mathScript.Script, "y");

            //Adds arguments for matrix row
            officeMath = mathMatrixRow.Arguments[2];
            //Adds a script
            mathScript = AddMathScript(officeMath, MathScriptType.Subscript);
            //Adds math text
            officeMathParaItem = AddMathText(document, mathScript.Equation, text);
            //Adds math text
            officeMathParaItem = AddMathText(document, mathScript.Script, "z");
        }
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