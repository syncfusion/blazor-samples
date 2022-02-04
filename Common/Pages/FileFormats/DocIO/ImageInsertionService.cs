#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Drawing;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace BlazorDemos.Data.FileFormats.DocIO
{
    public class ImageInsertionService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public ImageInsertionService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public MemoryStream ImageInsertion(string documentType)
        {
            string basePath = _hostingEnvironment.WebRootPath;
            string dataPath = basePath + @"\DocIO\rtf-to-doc.rtf";
            #region ImageInsertion

            //Create a new document
            WordDocument document = new WordDocument();
            //Adding a new section to the document.
            IWSection section = document.AddSection();
            section.PageSetup.Margins.All = 72;
            //Adding a paragraph to the section
            IWParagraph paragraph = section.AddParagraph();
            //Writing text.
            paragraph.AppendText("This sample demonstrates how to insert Vector and Scalar images inside a document.");
            //Adding a new paragraph
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            FileStream imageStream = new FileStream(basePath + @"/images/docio/yahoo.gif", FileMode.Open, FileAccess.Read);
            //Inserting .gif .
            WPicture picture = (WPicture)paragraph.AppendPicture(imageStream);
            //Adding Image caption
            picture.AddCaption("Figure", CaptionNumberingFormat.Roman, CaptionPosition.AfterImage);
            ApplyFormattingForCaption(document.LastParagraph);

            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            imageStream = new FileStream(basePath + @"/images/docio/reports.bmp", FileMode.Open, FileAccess.Read);
            //Inserting .bmp
            picture = (WPicture)paragraph.AppendPicture(imageStream);
            //Adding Image caption
            picture.AddCaption("Figure", CaptionNumberingFormat.Roman, CaptionPosition.AfterImage);
            ApplyFormattingForCaption(document.LastParagraph);

            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            imageStream = new FileStream(basePath + @"/images/docio/google.png", FileMode.Open, FileAccess.Read);
            //Inserting .png 
            picture = (WPicture)paragraph.AppendPicture(imageStream);
            //Adding Image caption
            picture.AddCaption("Figure", CaptionNumberingFormat.Roman, CaptionPosition.AfterImage);
            ApplyFormattingForCaption(document.LastParagraph);

            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            imageStream = new FileStream(basePath + @"/images/docio/square.tif", FileMode.Open, FileAccess.Read);
            //Inserting .tif 
            picture = (WPicture)paragraph.AppendPicture(imageStream);
            //Adding Image caption
            picture.AddCaption("Figure", CaptionNumberingFormat.Roman, CaptionPosition.AfterImage);
            ApplyFormattingForCaption(document.LastParagraph);

            //Adding a new paragraph.
            paragraph = section.AddParagraph();
            //Setting Alignment for the image.
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            imageStream = new FileStream(basePath + @"/images/docio/ess-chart.emf", FileMode.Open, FileAccess.Read);
            //Inserting .wmf Image to the document.
            WPicture mImage = (WPicture)paragraph.AppendPicture(imageStream);
            //Scaling Image
            mImage.HeightScale = 50f;
            mImage.WidthScale = 50f;

            //Adding Image caption
            mImage.AddCaption("Figure", CaptionNumberingFormat.Roman, CaptionPosition.AfterImage);
            ApplyFormattingForCaption(document.LastParagraph);


            //Updates the fields in Word document
            document.UpdateDocumentFields();

            FormatType type = FormatType.Docx;
            #region Document SaveOption
            //Save as .doc format
            if (documentType == "WordDoc")
            {
                type = FormatType.Doc;
            }
            //Save as .xml format
            else if (documentType == "WordML")
            {
                type = FormatType.WordML;
            }
            #endregion Document SaveOption

            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created Word document to MemoryStream
                document.Save(stream, type);
                document.Close();
                stream.Position = 0;
                return stream;
            }
        }
        /// <summary>
        /// Apply formattings for image caption paragraph
        /// </summary>
        private void ApplyFormattingForCaption(WParagraph paragraph)
        {
            //Align the caption
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            //Sets after spacing
            paragraph.ParagraphFormat.AfterSpacing = 1.5f;
            //Sets before spacing
            paragraph.ParagraphFormat.BeforeSpacing = 1.5f;
        }
        #endregion ImageInsertion
    }
}