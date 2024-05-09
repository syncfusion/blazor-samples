#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.Collections.Generic;
using System.IO;
using Syncfusion.Presentation;

namespace BlazorDemos.Data.DocumentProcessing.PowerPoint
{
    public class ImageService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public ImageService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Create a simple Presentation document.
        /// </summary>
        /// <returns>Return the created Presentation document as stream</returns>
        public MemoryStream CreateImageSample()
        {
            ///New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].
            //Create an instance of PowerPoint.
            IPresentation pptxDoc = Presentation.Create();
            //Add a blank slide to Presentation.
            ISlide firstSlide = pptxDoc.Slides.Add(SlideLayoutType.Blank);

            //Add a title text box to the slide.
            IShape titleShape = firstSlide.Shapes.AddTextBox(55, 23, 853, 72);
            //Set vertical alignment to the text body.
            titleShape.TextBody.VerticalAlignment = VerticalAlignmentType.Bottom;
            //Add a title paragraph.
            IParagraph titleParagraph = titleShape.TextBody.AddParagraph();
            //Set the alignment properties for the paragraph.
            titleParagraph.HorizontalAlignment = HorizontalAlignmentType.Center;
            //Add a text part.
            ITextPart titleTextPart = titleParagraph.AddTextPart("Adventure Works Cycles");
            //Set the font properties for the text part.
            titleTextPart.Font.FontSize = 36;

            //Add a content text box to the slide.
            IShape textbox = firstSlide.Shapes.AddTextBox(66, 132, 543, 350);
            //Add the first paragraph.
            IParagraph paragraph1 = textbox.TextBody.AddParagraph();
            //Set bulleted list type.
            paragraph1.ListFormat.Type = ListType.Bulleted;
            //Set paragraph properties.
            paragraph1.LeftIndent = 22;
            paragraph1.FirstLineIndent = -22;
            paragraph1.LineSpacing = 38;
            paragraph1.SpaceBefore = 10;
            //Add a new text part.
            paragraph1.AddTextPart("Adventure Works Cycles, the fictitious company on which the Adventure Works sample databases are based, is a large, multinational manufacturing company.");

            //Add the second paragraph.
            IParagraph paragraph2 = textbox.TextBody.AddParagraph();
            //Set bulleted list type.
            paragraph2.ListFormat.Type = ListType.Bulleted;
            //Set paragraph properties.
            paragraph2.LeftIndent = 22;
            paragraph2.FirstLineIndent = -22;
            paragraph2.LineSpacing = 38;
            paragraph2.SpaceBefore = 10;
            //Add a new text part.
            paragraph2.AddTextPart("The company manufactures and sells metal and composite bicycles to North American, European, and Asian commercial markets. While its base operation is located in Bothell, Washington, with 290 employees, several regional sales teams are located throughout their market base.");

            //Add a picture to the shape collection.
            IPicture picture = firstSlide.Shapes.AddPicture(fileDataValue["cycle-logo.png"], 610, 246, 328, 123);
            //Add alternate text to the picture.
            picture.Description = "Adventure Works Cycles Logo";
            //Apply bounding box size and position.
            picture.Crop.ContainerWidth = 328f;
            picture.Crop.ContainerHeight = 123f;
            picture.Crop.ContainerLeft = 609f;
            picture.Crop.ContainerTop = 246f;
            //Apply cropping size and offsets.
            picture.Crop.Width = 370f;
            picture.Crop.Height = 151f;
            picture.Crop.OffsetX = -4.32f;
            picture.Crop.OffsetY = 1.44f;

            //Add a title-only slide to Presentation.
            ISlide secondSlide = pptxDoc.Slides.Add(SlideLayoutType.TitleOnly);
            //Retrieve the first shape of the slide.
            IShape titleShape2 = secondSlide.Shapes[0] as IShape;
            //Add a title paragraph.
            IParagraph titleParagraph2 = titleShape2.TextBody.AddParagraph();
            //Set the alignment properties for the paragraph.
            titleParagraph2.HorizontalAlignment = HorizontalAlignmentType.Center;
            //Add a text part.
            ITextPart titleTextPart2 = titleParagraph2.AddTextPart("About Adventure Works Cycles");
            //Set the font properties for the text part.
            titleTextPart2.Font.FontName = "Calibri";
            titleTextPart2.Font.FontSize = 40;

            //Get an SVG image as a stream.
            //Get a fallback image as a stream.
            //Add the SVG picture to a slide by specifying its size and position.
            IPicture svgPicture = secondSlide.Pictures.AddPicture(fileDataValue["about.svg"], fileDataValue["about.png"], 172, 155, 643, 256);
            //Add alternate text to the picture.
            svgPicture.Description = "About Adventure Works Cycles";

            //Save the document as a stream and return the stream.
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created PowerPoint document to MemoryStream.
                pptxDoc.Save(stream);
                return stream;
            }
        }
        /// <summary>
        /// Dispose the Dictionary.
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