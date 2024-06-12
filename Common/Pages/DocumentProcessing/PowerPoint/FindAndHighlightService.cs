#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.IO;
using Syncfusion.Presentation;
using Syncfusion.PresentationRenderer;
using Syncfusion.Pdf;
using System.Collections.Generic;

namespace BlazorDemos.Data.DocumentProcessing.PowerPoint
{
    public class FindAndHighlightService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public FindAndHighlightService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a Find and Hightlight Presentation document
        /// </summary>
        /// <returns>Return the created Presentation document as stream</returns>
        public MemoryStream FindAndHighlightPresentation(string documentType, string button)
        {
            if (button == "View Input Template")
            {
                return fileDataValue["find-and-highlight-input.pptx"];
            }

            //Open a existing PowerPoint presentation.
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(fileDataValue["find-and-highlight-input.pptx"]);

            //Finds all the occurrences of a particular text
            ITextSelection[] textSelections = presentation.FindAll("product", true, true);
            foreach (ITextSelection textSelection in textSelections)
            {
                //Gets the found text containing text parts
                foreach (ITextPart textPart in textSelection.GetTextParts())
                {
                    //Sets highlight color
                    textPart.Font.HighlightColor = ColorObject.Yellow;
                }
            }
            /*Server:Block*/
#if !(WASM) && !WEBAPP
            //Save as .pdf format
            if (documentType == "PDF")
            {
                // Create new instance for PresentationToPdfConverterSettings
                PresentationToPdfConverterSettings settings = new PresentationToPdfConverterSettings();
                //Convert the PowerPoint document to PDF document.
                using (PdfDocument pdfDocument = PresentationToPdfConverter.Convert(presentation, settings))
                {
                    //Save the document as a stream and return the stream
                    using (MemoryStream stream = new MemoryStream())
                    {
                        //Save the converted PDF document to Memory stream.
                        pdfDocument.Save(stream);
                        //Set the position of the stream to beginning.
                        stream.Position = 0;
                        //Close the PowerPoint Presentation.
                        presentation.Close();
                        return stream;
                    }
                }
            }
            else
            {
#endif
                /*End:Server*/
                //Save the document as a stream and return the stream
                using (MemoryStream stream = new MemoryStream())
                {
                    //Save the created PowerPoint document to MemoryStream
                    presentation.Save(stream);
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