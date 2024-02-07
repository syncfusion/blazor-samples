#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.IO;
using System.Collections.Generic;
using Syncfusion.Pdf.Parsing;
using SkiaSharp;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class PdfToPdfAService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public PdfToPdfAService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream ConvertToPdfA()
        {
            //Load the PDF document from stream.
            PdfLoadedDocument document = new PdfLoadedDocument(fileDataValue["InvoiceTemplate.pdf"]);
            //Sample level font event handling
            document.SubstituteFont += LoadedDocument_SubstituteFont;
            //convert a document to PDF/A standard document.
            document.ConvertToPDFA(PdfConformanceLevel.Pdf_A1B);
            MemoryStream stream = new MemoryStream();
            //Saves the PDF to the memory stream.
            document.Save(stream);
            //Close the PDF document
            document.Close(true);
            stream.Position = 0;
            return stream;
        }
        public void LoadedDocument_SubstituteFont(object sender, PdfFontEventArgs args)
        {
            //get the font name
            string fontName = args.FontName.Split(',')[0];

            //get the font style
            PdfFontStyle fontStyle = args.FontStyle;

            SKFontStyle sKFontStyle = SKFontStyle.Normal;

            if (fontStyle != PdfFontStyle.Regular)
            {
                if (fontStyle == PdfFontStyle.Bold)
                {
                    sKFontStyle = SKFontStyle.Bold;
                }
                else if (fontStyle == PdfFontStyle.Italic)
                {
                    sKFontStyle = SKFontStyle.Italic;
                }
                else if (fontStyle == (PdfFontStyle.Italic | PdfFontStyle.Bold))
                {
                    sKFontStyle = SKFontStyle.BoldItalic;
                }
            }

            SKTypeface typeface = SKTypeface.FromFamilyName(fontName, sKFontStyle);

            SKStreamAsset typeFaceStream = typeface.OpenStream();

            MemoryStream memoryStream = null;

            if (typeFaceStream != null && typeFaceStream.Length > 0)
            {
                //Create the fontData from the type face stream.
                byte[] fontData = new byte[typeFaceStream.Length];

                typeFaceStream.Read(fontData, typeFaceStream.Length);
                typeFaceStream.Dispose();

                //Create the new memory stream from the font data.
                memoryStream = new MemoryStream(fontData);
            }

            //set the font stream to the event args.
            args.FontStream = memoryStream;
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
}
