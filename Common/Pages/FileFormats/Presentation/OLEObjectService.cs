#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.IO;
using Microsoft.AspNetCore.Hosting;
using Syncfusion.Presentation;

namespace BlazorDemos.Data.FileFormats.Presentation
{
    public class OLEObjectService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public OLEObjectService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
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
            
            //Get the word file as stream
            Stream wordStream = new FileStream(ResolveApplicationPath("ole-template.docx"), FileMode.Open);
            
            //Image to be displayed, This can be any image
			string imagePath = _hostingEnvironment.WebRootPath + "//images//presentation//ole-picture.png";
            Stream imageStream = new FileStream(imagePath, FileMode.Open);

            IOleObject oleObject = slide.Shapes.AddOleObject(imageStream, "Word.Document.12", wordStream);
            //Set size and position of the ole object
            oleObject.Left = 4.53 * 72;
            oleObject.Top = 0.79 * 72;
            oleObject.Width = 4.26 * 72;
            oleObject.Height = 5.92 * 72;
            //Set DisplayAsIcon as true, to open the embedded document in separate (default) application.
            oleObject.DisplayAsIcon = true;
            //Save the document as a stream and retrun the stream
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
            FileStream fileStreamInput = new FileStream(ResolveApplicationPath("embedded-ole-object.pptx"), FileMode.Open, FileAccess.Read);
            IPresentation pptxDoc = Syncfusion.Presentation.Presentation.Open(fileStreamInput);
            //New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].  

            //Gets the first slide of the Presentation
            ISlide slide = pptxDoc.Slides[0];
            //Gets the Ole Object of the slide
            IOleObject oleObject = slide.Shapes[2] as IOleObject;
            //Gets the file data of embedded Ole Object.
            byte[] array = oleObject.ObjectData;
            //Gets the file Name of OLE Object
            string outputFile = oleObject.FileName;

            //Save the document as a stream and retrun the stream
            using (MemoryStream stream = new MemoryStream(array))
            {
                return stream;
            }
        }

        #region HelperMethod
        private string ResolveApplicationPath(string fileName)
        {
            return _hostingEnvironment.WebRootPath + "//data//presentation//" + fileName;
        }
        #endregion        
    }
}