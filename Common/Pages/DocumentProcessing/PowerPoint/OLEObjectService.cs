#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.IO;
using System.Collections.Generic;
using Syncfusion.Presentation;

namespace BlazorDemos.Data.DocumentProcessing.PowerPoint
{
    public class OLEObjectService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public OLEObjectService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple Presentation document with OLE object
        /// </summary>
        /// <returns>Return the created Presentation document as stream</returns>
        public MemoryStream InsertOleObject()
        {            
            //New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].
            IPresentation presentation = Syncfusion.Presentation.Presentation.Create();

            ISlide slide = presentation.Slides.Add(SlideLayoutType.TitleOnly);

            IShape titleShape = slide.Shapes[0] as IShape;
            titleShape.Left = 0.65 * 72;
            titleShape.Top = 0.24 * 72;
            titleShape.Width = 11.5 * 72;
            titleShape.Height = 1.45 * 72;
            titleShape.TextBody.AddParagraph("Ole Object");
            titleShape.TextBody.Paragraphs[0].Font.Bold = true;
            titleShape.TextBody.Paragraphs[0].HorizontalAlignment = HorizontalAlignmentType.Left;

            IShape heading = slide.Shapes.AddTextBox(100, 100, 100, 100);
            heading.Left = 0.84 * 72;
            heading.Top = 1.65 * 72;
            heading.Width = 2.23 * 72;
            heading.Height = 0.51 * 72;
            heading.TextBody.AddParagraph("MS Word Object");
            heading.TextBody.Paragraphs[0].Font.Italic = true;
            heading.TextBody.Paragraphs[0].Font.Bold = true;
            heading.TextBody.Paragraphs[0].Font.FontSize = 18;
            
            

            IOleObject oleObject = slide.Shapes.AddOleObject(fileDataValue["ole-picture.png"], "Word.Document.12", fileDataValue["ole-template.docx"]);
            //Set size and position of the ole object
            oleObject.Left = 4.53 * 72;
            oleObject.Top = 0.79 * 72;
            oleObject.Width = 4.26 * 72;
            oleObject.Height = 5.92 * 72;
            //Set DisplayAsIcon as true, to open the embedded document in separate (default) application.
            oleObject.DisplayAsIcon = true;
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created PowerPoint document to MemoryStream
                presentation.Save(stream);
                return stream;
            }
        }

        /// <summary>
        /// Get extracted OLE document
        /// </summary>
        /// <returns>Return the ole document as stream</returns>
        public MemoryStream ExtractOleObject()
        {
            //Opens the presentation document as stream
            IPresentation pptxDoc = Syncfusion.Presentation.Presentation.Open(fileDataValue["embedded-ole-object.pptx"]);
            //New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].  

            //Gets the first slide of the Presentation
            ISlide slide = pptxDoc.Slides[0];
            //Gets the Ole Object of the slide
            IOleObject oleObject = slide.Shapes[2] as IOleObject;
            //Gets the file data of embedded Ole Object.
            byte[] array = oleObject.ObjectData;
            //Gets the file Name of OLE Object
            string outputFile = oleObject.FileName;

            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream(array))
            {
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