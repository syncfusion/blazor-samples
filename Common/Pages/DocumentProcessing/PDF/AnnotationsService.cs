#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using System.IO;
using System;
using System.Collections.Generic;
using Syncfusion.Pdf.Parsing;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class AnnotationsService
    {
		private readonly Dictionary<string, MemoryStream> fileDataValue;
        public AnnotationsService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
		
        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream CreatePdfDocument( bool flatten)
        {
            
            //Create a new PDF document.

             PdfDocument document = new PdfDocument();

            //Creates a new page 
            PdfPage page = document.Pages.Add();
            document.PageSettings.SetMargins(0);

            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 10f);
            PdfBrush brush = new PdfSolidBrush(Color.Black);
            string text = "Adventure Works Cycles, the fictitious company on which the AdventureWorks sample databases are based, is a large, multinational manufacturing company. The company manufactures and sells metal and composite bicycles to North American, European and Asian commercial markets. While its base operation is located in Washington with 290 employees, several regional sales teams are located throughout their market base.";

            page.Graphics.DrawString("Annotation with Comments and Reviews", font, brush, new PointF(30, 10));
            page.Graphics.DrawString(text, font, brush, new RectangleF(30, 40, page.GetClientSize().Width - 60, 60));

            string markupText = "North American, European and Asian commercial markets";
            PdfTextMarkupAnnotation textMarkupAnnot = new PdfTextMarkupAnnotation("sample", "Highlight", markupText, new PointF(147, 63.5f), font);
            textMarkupAnnot.Author = "Annotation";
            textMarkupAnnot.Opacity = 1.0f;
            textMarkupAnnot.Subject = "Comments and Reviews";
            textMarkupAnnot.ModifiedDate = new DateTime(2015, 1, 18);
            textMarkupAnnot.TextMarkupAnnotationType = PdfTextMarkupAnnotationType.Highlight;
            textMarkupAnnot.TextMarkupColor = new PdfColor(Color.Yellow);
            textMarkupAnnot.InnerColor = new PdfColor(Color.Red);
            textMarkupAnnot.Color = new PdfColor(Color.Yellow);
			textMarkupAnnot.AnnotationFlags = PdfAnnotationFlags.Print;
            if (flatten)
            {
                textMarkupAnnot.Flatten = true;
            }
            //Create a new comment.
            PdfPopupAnnotation userQuery = new PdfPopupAnnotation();
            userQuery.Author = "John";
            userQuery.Text = "Can you please change South Asian to Asian?";
            userQuery.ModifiedDate = new DateTime(2015, 1, 18);
            //Add comment to the annotation
            textMarkupAnnot.Comments.Add(userQuery);

            //Creates a new comment
            PdfPopupAnnotation userAnswer = new PdfPopupAnnotation();
            userAnswer.Author = "Smith";
            userAnswer.Text = "South Asian has changed as Asian";
            userAnswer.ModifiedDate = new DateTime(2015, 1, 18);
            //Add comment to the annotation
            textMarkupAnnot.Comments.Add(userAnswer);

            //Creates a new review
            PdfPopupAnnotation userAnswerReview = new PdfPopupAnnotation();
            userAnswerReview.Author = "Smith";
            userAnswerReview.State = PdfAnnotationState.Completed;
            userAnswerReview.StateModel = PdfAnnotationStateModel.Review;
            userAnswerReview.ModifiedDate = new DateTime(2015, 1, 18);
            //Add review to the comment
            userAnswer.ReviewHistory.Add(userAnswerReview);

            //Creates a new review
            PdfPopupAnnotation userAnswerReviewJohn = new PdfPopupAnnotation();
            userAnswerReviewJohn.Author = "John";
            userAnswerReviewJohn.State = PdfAnnotationState.Accepted;
            userAnswerReviewJohn.StateModel = PdfAnnotationStateModel.Review;
            userAnswerReviewJohn.ModifiedDate = new DateTime(2015, 1, 18);
            //Add review to the comment
            userAnswer.ReviewHistory.Add(userAnswerReviewJohn);

            //Add annotation to the page
            page.Annotations.Add(textMarkupAnnot);

            RectangleF bounds = new RectangleF(350, 170, 80, 80);
            //Creates a new Circle annotation.
            PdfCircleAnnotation circleannotation = new PdfCircleAnnotation(bounds);
            circleannotation.InnerColor = new PdfColor(Color.Yellow);
            circleannotation.Color = new PdfColor(Color.Red);
            circleannotation.AnnotationFlags = PdfAnnotationFlags.Default | PdfAnnotationFlags.Print;
            circleannotation.Author = "Syncfusion";
            circleannotation.Subject = "CircleAnnotation";
            circleannotation.ModifiedDate = new DateTime(2015, 1, 18);
            page.Annotations.Add(circleannotation);
            page.Graphics.DrawString("Circle Annotation", font, brush, new PointF(350, 130));

            //Creates a new Ellipse annotation.
            PdfEllipseAnnotation ellipseannotation = new PdfEllipseAnnotation(new RectangleF(30, 150, 50, 100), "Ellipse Annotation");
            ellipseannotation.Color = new PdfColor(Color.Red);
            ellipseannotation.InnerColor = new PdfColor(Color.Yellow);
            ellipseannotation.AnnotationFlags = PdfAnnotationFlags.Print;
            page.Graphics.DrawString("Ellipse Annotation", font, brush, new PointF(30, 130));
            page.Annotations.Add(ellipseannotation);

            //Creates a new Square annotation.
            PdfSquareAnnotation squareannotation = new PdfSquareAnnotation(new RectangleF(30, 300, 80, 80));
            squareannotation.Text = "SquareAnnotation";
            squareannotation.InnerColor = new PdfColor(Color.Red);
            squareannotation.Color = new PdfColor(Color.Yellow);
            squareannotation.AnnotationFlags = PdfAnnotationFlags.Print;
            page.Graphics.DrawString("Square Annotation", font, brush, new PointF(30, 280));
            page.Annotations.Add(squareannotation);

            //Creates a new Rectangle annotation.
            RectangleF rectannot = new RectangleF(350, 320, 100, 50);
            PdfRectangleAnnotation rectangleannotation = new PdfRectangleAnnotation(rectannot, "RectangleAnnotation");
            rectangleannotation.InnerColor = new PdfColor(Color.Red);
            rectangleannotation.Color = new PdfColor(Color.Yellow);
            rectangleannotation.AnnotationFlags = PdfAnnotationFlags.Print;
            page.Graphics.DrawString("Rectangle Annotation", font, brush, new PointF(350, 280));
            page.Annotations.Add(rectangleannotation);

            //Creates a new Line annotation.
            int[] points = new int[] { 400, 350, 550, 350 };
            PdfLineAnnotation lineAnnotation = new PdfLineAnnotation(points, "Line Annoation is the one of the annotation type...");
            lineAnnotation.Author = "Syncfusion";
            lineAnnotation.Subject = "LineAnnotation";
            lineAnnotation.ModifiedDate = new DateTime(2015, 1, 18);
            lineAnnotation.Text = "PdfLineAnnotation";
            lineAnnotation.BackColor = new PdfColor(Color.Red);
            lineAnnotation.AnnotationFlags = PdfAnnotationFlags.Print;
            page.Graphics.DrawString("Line Annotation", font, brush, new PointF(400, 420));
            page.Annotations.Add(lineAnnotation);

            //Creates a new Polygon annotation.
            int[] polypoints = new int[] { 50, 298, 100, 325, 200, 355, 300, 230, 180, 230 };
            PdfPolygonAnnotation polygonannotation = new PdfPolygonAnnotation(polypoints, "PolygonAnnotation");
            polygonannotation.Bounds = new RectangleF(30, 210, 300, 200);
            PdfPen pen = new PdfPen(Color.Red);
            polygonannotation.Text = "polygon";
            polygonannotation.Color = new PdfColor(Color.Red);
            polygonannotation.InnerColor = new PdfColor(Color.LightPink);
            polygonannotation.AnnotationFlags = PdfAnnotationFlags.Print;
            page.Graphics.DrawString("Polygon Annotation", font, brush, new PointF(50, 420));
            page.Annotations.Add(polygonannotation);

            //Creates a new Freetext annotation.
            RectangleF freetextrect = new RectangleF(405, 645, 80, 30);
            PdfFreeTextAnnotation freeText = new PdfFreeTextAnnotation(freetextrect);
            freeText.MarkupText = "Free Text with Callouts";
            freeText.TextMarkupColor = new PdfColor(Color.Green);
            freeText.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 7f);
            freeText.BorderColor = new PdfColor(Color.Blue);
            freeText.Border = new PdfAnnotationBorder(.5f);
            freeText.AnnotationFlags = PdfAnnotationFlags.Default | PdfAnnotationFlags.Print;
            freeText.Text = "Free Text";
            freeText.Color = new PdfColor(Color.Yellow);
            PointF[] Freetextpoints = { new PointF(365, 700), new PointF(379, 654), new PointF(405, 654) };
            freeText.CalloutLines = Freetextpoints;
            page.Graphics.DrawString("FreeText Annotation", font, brush, new PointF(400, 610));
            page.Annotations.Add(freeText);

            //Creates a new Ink annotation.
            List<float> linePoints = new List<float> { 72.919f, 136.376f, 72.264f, 136.376f, 62.446f, 142.922f, 61.137f, 142.922f, 55.901f, 139.649f, 55.246f, 138.34f, 54.592f, 132.449f, 54.592f, 127.867f, 55.901f, 125.904f, 59.828f, 121.976f, 63.101f, 121.322f, 65.719f, 122.631f, 68.992f, 125.249f, 70.301f, 130.485f, 71.61f, 133.104f, 72.264f, 136.376f, 72.919f, 140.304f, 74.883f, 144.885f, 76.192f, 150.776f, 76.192f, 151.431f, 76.192f, 152.085f, 76.192f, 158.631f, 76.192f, 159.94f, 75.537f, 155.358f, 74.228f, 150.122f, 74.228f, 146.195f, 73.574f, 141.613f, 73.574f, 137.685f, 74.228f, 132.449f, 74.883f, 128.522f, 75.537f, 124.594f, 76.192f, 123.285f, 76.846f, 122.631f, 80.774f, 122.631f, 82.737f, 123.285f, 85.355f, 125.249f, 88.628f, 129.831f, 89.283f, 133.104f, 89.937f, 137.031f, 90.592f, 140.958f, 89.937f, 142.267f, 86.665f, 141.613f, 85.355f, 140.304f, 84.701f, 138.34f, 84.701f, 137.685f, 85.355f, 137.031f, 87.974f, 135.722f, 90.592f, 136.376f, 92.555f, 137.031f, 96.483f, 139.649f, 98.446f, 140.958f, 101.719f, 142.922f, 103.028f, 142.922f, 100.41f, 138.34f, 99.756f, 134.413f, 99.101f, 131.14f, 99.101f, 128.522f, 99.756f, 127.213f, 101.065f, 125.904f, 102.374f, 123.94f, 103.683f, 123.94f, 107.61f, 125.904f, 110.228f, 129.831f, 114.156f, 135.067f, 117.428f, 140.304f, 119.392f, 143.576f, 121.356f, 144.231f, 122.665f, 144.231f, 123.974f, 142.267f, 126.592f, 139.649f, 127.247f, 140.304f, 126.592f, 142.922f, 124.628f, 143.576f, 122.01f, 142.922f, 118.083f, 141.613f, 114.81f, 136.376f, 114.81f, 131.14f, 113.501f, 127.213f, 114.156f, 125.904f, 118.083f, 125.904f, 120.701f, 126.558f, 123.319f, 130.485f, 125.283f, 136.376f, 125.937f, 140.304f, 125.937f, 142.922f, 126.592f, 143.576f, 125.937f, 135.722f, 125.937f, 131.794f, 125.937f, 131.14f, 127.247f, 129.176f, 129.21f, 127.213f, 131.828f, 127.213f, 134.447f, 128.522f, 136.41f, 136.376f, 139.028f, 150.122f, 141.647f, 162.558f, 140.992f, 163.213f, 138.374f, 160.595f, 135.756f, 153.395f, 135.101f, 148.158f, 134.447f, 140.304f, 134.447f, 130.485f, 133.792f, 124.594f, 133.792f, 115.431f, 133.792f, 110.194f, 133.792f, 105.612f, 134.447f, 105.612f, 137.065f, 110.194f, 137.719f, 116.74f, 139.028f, 120.013f, 139.028f, 123.94f, 137.719f, 127.213f, 135.756f, 130.485f, 134.447f, 130.485f, 133.792f, 130.485f, 137.719f, 131.794f, 141.647f, 135.722f, 146.883f, 142.922f, 152.774f, 153.395f, 153.428f, 159.286f, 150.156f, 159.94f, 147.537f, 156.667f, 146.883f, 148.813f, 146.883f, 140.958f, 146.883f, 134.413f, 146.883f, 125.904f, 145.574f, 118.703f, 145.574f, 114.776f, 145.574f, 112.158f, 146.228f, 111.503f, 147.537f, 111.503f, 148.192f, 112.158f, 150.156f, 112.812f, 150.81f, 113.467f, 152.119f, 114.776f, 154.083f, 117.394f, 155.392f, 119.358f, 156.701f, 120.667f, 157.356f, 121.976f, 156.701f, 121.322f, 156.047f, 120.013f, 155.392f, 119.358f, 154.083f, 117.394f, 154.083f, 116.74f, 152.774f, 114.776f, 152.119f, 114.121f, 150.81f, 113.467f, 149.501f, 113.467f, 147.537f, 112.158f, 146.883f, 112.158f, 145.574f, 111.503f, 144.919f, 112.158f, 144.265f, 114.121f, 144.265f, 115.431f, 144.265f, 116.74f, 144.265f, 117.394f, 144.265f, 118.049f, 144.919f, 118.703f, 145.574f, 120.667f, 146.228f, 122.631f, 147.537f, 123.285f, 147.537f, 124.594f, 148.192f, 125.904f, 147.537f, 128.522f, 147.537f, 129.176f, 147.537f, 130.485f, 147.537f, 132.449f, 147.537f, 134.413f, 147.537f, 136.376f, 147.537f, 138.34f, 147.537f, 138.994f, 145.574f, 138.994f, 142.956f, 138.252f };
            RectangleF rectangle = new RectangleF(30, 580, 300, 400);
            PdfInkAnnotation inkAnnotation = new PdfInkAnnotation(rectangle, linePoints);
            inkAnnotation.Bounds = rectangle;
            inkAnnotation.Color = new PdfColor(Color.Red);
            inkAnnotation.AnnotationFlags = PdfAnnotationFlags.Print;
            page.Graphics.DrawString("Ink Annotation", font, brush, new PointF(30, 610));
            page.Annotations.Add(inkAnnotation);

            PdfPage secondPage = document.Pages.Add();

            //Creates a new TextMarkup annotation.
            string s = "This is TextMarkup annotation!!!";
            secondPage.Graphics.DrawString(s, font, brush, new PointF(30, 70));
            PdfTextMarkupAnnotation textannot = new PdfTextMarkupAnnotation("sample", "Strikeout", s, new PointF(30, 70), font);
            textannot.Author = "Annotation";
            textannot.Opacity = 1.0f;
            textannot.Subject = "pdftextmarkupannotation";
            textannot.ModifiedDate = new DateTime(2015, 1, 18);
            textannot.TextMarkupAnnotationType = PdfTextMarkupAnnotationType.StrikeOut;
            textannot.TextMarkupColor = new PdfColor(Color.Yellow);
            textannot.InnerColor = new PdfColor(Color.Red);
            textannot.Color = new PdfColor(Color.Yellow);
            textannot.AnnotationFlags = PdfAnnotationFlags.Print;
            if (flatten)
            {
                textannot.Flatten = true;
            }
            secondPage.Graphics.DrawString("TextMarkup Annotation", font, brush, new PointF(30, 40));
            secondPage.Annotations.Add(textannot);

            //Creates a new popup annotation.
            RectangleF popupRect = new RectangleF(430, 70, 30, 30);
            PdfPopupAnnotation popupAnnotation = new PdfPopupAnnotation();
            popupAnnotation.Border.Width = 4;
            popupAnnotation.Border.HorizontalRadius = 20;
            popupAnnotation.Border.VerticalRadius = 30;
            popupAnnotation.Opacity = 1;
            popupAnnotation.Open = true;
            popupAnnotation.Text = "Popup Annotation";
            popupAnnotation.Color = Color.Green;
            popupAnnotation.InnerColor = Color.Blue;
            popupAnnotation.Bounds = popupRect;
            popupAnnotation.AnnotationFlags = PdfAnnotationFlags.Print;
            if (flatten)
            {
                popupAnnotation.FlattenPopUps = true;
                popupAnnotation.Flatten = true;
            }
            secondPage.Graphics.DrawString("Popup Annotation", font, brush, new PointF(400, 40));
            secondPage.Annotations.Add(popupAnnotation);

            //Creates a new Line measurement annotation.
            points = new int[] { 400, 630, 550, 630 };
            PdfLineMeasurementAnnotation lineMeasureAnnot = new PdfLineMeasurementAnnotation(points);
            lineMeasureAnnot.Author = "Syncfusion";
            lineMeasureAnnot.Subject = "LineAnnotation";
            lineMeasureAnnot.ModifiedDate = new DateTime(2015, 1, 18);
            lineMeasureAnnot.Unit = PdfMeasurementUnit.Inch;
            lineMeasureAnnot.lineBorder.BorderWidth = 2;
            lineMeasureAnnot.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 10f, PdfFontStyle.Regular);
            lineMeasureAnnot.Color = new PdfColor(Color.Red);
            lineMeasureAnnot.AnnotationFlags = PdfAnnotationFlags.Print;
            if (flatten)
            {
                lineMeasureAnnot.Flatten = true;
            }
            secondPage.Graphics.DrawString("Line Measurement Annotation", font, brush, new PointF(370, 130));
            secondPage.Annotations.Add(lineMeasureAnnot);

            //Creates a new Freetext annotation.
            RectangleF freetextrect0 = new RectangleF(80, 160, 100, 50);
            PdfFreeTextAnnotation freeText0 = new PdfFreeTextAnnotation(freetextrect0);
            freeText0.MarkupText = "Free Text with Callouts";
            freeText0.TextMarkupColor = new PdfColor(Color.Green);
            freeText0.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 7f);
            freeText0.BorderColor = new PdfColor(Color.Blue);
            freeText0.Border = new PdfAnnotationBorder(.5f);
            freeText0.AnnotationFlags = PdfAnnotationFlags.Default | PdfAnnotationFlags.Print;
            freeText0.Text = "Free Text";
            freeText0.Rotate = PdfAnnotationRotateAngle.RotateAngle90;
            freeText0.Color = new PdfColor(Color.Yellow);
            PointF[] Freetextpoints0 = { new PointF(45, 220), new PointF(60, 175), new PointF(80, 175) };
            freeText0.CalloutLines = Freetextpoints0;
            secondPage.Graphics.DrawString("Rotated FreeText Annotation", font, brush, new PointF(40, 130));
            if (flatten)
            {
                freeText0.Flatten = true;
            }
            secondPage.Annotations.Add(freeText0);

            PdfRectangleAnnotation cloudannotation = new PdfRectangleAnnotation(new RectangleF(30, 300, 100, 50), "Rectangle Cloud Annoatation");
            cloudannotation.Border.BorderWidth = 1;
            cloudannotation.Color = Color.Red;
            cloudannotation.InnerColor = Color.Blue;
            cloudannotation.AnnotationFlags = PdfAnnotationFlags.Print;
            PdfBorderEffect bordereffect = new PdfBorderEffect();
            bordereffect.Intensity = 2;
            bordereffect.Style = PdfBorderEffectStyle.Cloudy;
            cloudannotation.BorderEffect = bordereffect;
            secondPage.Graphics.DrawString("Cloud Annotation", font, brush, new PointF(40, 260));
            secondPage.Annotations.Add(cloudannotation);
            if (!flatten)
            {
                PdfRedactionAnnotation redactionannot = new PdfRedactionAnnotation();
                redactionannot.Bounds = new RectangleF(350, 300, 100, 50);
                redactionannot.Text = "Redaction Annotation";
                redactionannot.InnerColor = Color.Orange;
                redactionannot.BorderColor = Color.Red;
                redactionannot.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 13);
                redactionannot.TextColor = Color.Green;
                redactionannot.OverlayText = "REDACTED";
                redactionannot.RepeatText = true;
                redactionannot.TextAlignment = PdfTextAlignment.Left;
                redactionannot.SetAppearance(true);
                secondPage.Graphics.DrawString("Redaction Annotation", font, brush, new PointF(350, 260));
                secondPage.Annotations.Add(redactionannot);
            }
	    //Creates a new RubberStamp annotation
            PdfRubberStampAnnotation rubberStampAnnotation = new PdfRubberStampAnnotation(new RectangleF(40, 600, 100, 50));
            rubberStampAnnotation.Text = "Rubber Stamp Annotation";
            rubberStampAnnotation.Author = "Syncfusion";
            rubberStampAnnotation.ModifiedDate = new DateTime(2015, 1, 18);
            rubberStampAnnotation.Color = new PdfColor(Color.Red);
            rubberStampAnnotation.AnnotationFlags = PdfAnnotationFlags.Print;
            secondPage.Graphics.DrawString("Rubber Stamp Annotation", font, brush, new PointF(40, 570));
            secondPage.Annotations.Add(rubberStampAnnotation);
			
			secondPage.Graphics.DrawString("Rich Media Annotation (Video)", font, brush, new PointF(40, 390));

            //Create rich media annotation
            PdfRichMediaAnnotation richMediaAnnotation = new PdfRichMediaAnnotation(new RectangleF(30, 420, 160, 100));
            //Set activation mode
            richMediaAnnotation.ActivationMode = PdfRichMediaActivationMode.Click;
            //Set presentation style
            richMediaAnnotation.PresentationStyle = PdfRichMediaPresentationStyle.Embedded;
            richMediaAnnotation.AnnotationFlags = PdfAnnotationFlags.Print;
            //Create rich media content with video file  
            string path = "Syncfusion.PdfDemos.WinUI.";
           
			//Create rich media content with video file
            PdfRichMediaContent videoContent = new PdfRichMediaContent("video", fileDataValue["Video.mp4"], "mp4");
            //Set the content type
            videoContent.ContentType = PdfRichMediaContentType.Video;
            //Add content to the rich media
            richMediaAnnotation.Content = videoContent;
           
            PdfBitmap image = new PdfBitmap(fileDataValue["richmedia.jpg"]);
            //Draw image to the appearance
            richMediaAnnotation.Appearance.Normal.Graphics.DrawImage(image, new RectangleF(0, 0, richMediaAnnotation.Bounds.Width, richMediaAnnotation.Bounds.Height));
            //Add annotation to the page
            secondPage.Annotations.Add(richMediaAnnotation);

            secondPage.Graphics.DrawString("Rich Media Annotation (Sound)", font, brush, new PointF(350, 390));

            //Create rich media annotation
            PdfRichMediaAnnotation richMediaAnnotationSound = new PdfRichMediaAnnotation(new RectangleF(340, 420, 160, 100));
            //Set activation mode
            richMediaAnnotationSound.ActivationMode = PdfRichMediaActivationMode.Click;
            //Set presentation style
            richMediaAnnotationSound.PresentationStyle = PdfRichMediaPresentationStyle.Embedded;
            richMediaAnnotationSound.AnnotationFlags = PdfAnnotationFlags.Print;
            
			PdfRichMediaContent soundContent = new PdfRichMediaContent("Sound", fileDataValue["Sound.mp3"], "mp3");
            //Set the content type
            soundContent.ContentType = PdfRichMediaContentType.Sound;
            //Add content to the rich media
            richMediaAnnotationSound.Content = soundContent;
           
            PdfBitmap soundImage = new PdfBitmap(fileDataValue["richmedia_sound.jpg"]);

            //Draw image to the appearance
            richMediaAnnotationSound.Appearance.Normal.Graphics.DrawImage(soundImage, new RectangleF(0, 0, richMediaAnnotationSound.Bounds.Width, richMediaAnnotationSound.Bounds.Height));
            //Add annotation to the page
            secondPage.Annotations.Add(richMediaAnnotationSound);

            AddWatermarkAnnotation(document, path);
			
            MemoryStream SourceStream = new MemoryStream();
            document.Save(SourceStream);
            document.Close(true);
            SourceStream.Position = 0;
            if (flatten)
            {
                //Creates a new Loaded document.
                PdfLoadedDocument lDoc = new PdfLoadedDocument(SourceStream);
                foreach (PdfLoadedPage lpage in lDoc.Pages)
                {
                    lpage.Annotations.Flatten = true;
                }
                //Save the PDF to the MemoryStream
                MemoryStream ms = new MemoryStream();
                lDoc.Save(ms);
                //If the position is not set to '0' then the PDF will be empty.
                ms.Position = 0;
                lDoc.Close(true);
                return ms;
            }
            else
            {
                return SourceStream;
            }
        }
		private void AddWatermarkAnnotation(PdfDocument document, string path)
        {
            PdfPage page = document.Pages.Add();
            SizeF pageClientSize = page.GetClientSize();            
            //Load the image from the disk.
            PdfImage img = PdfImage.FromStream(fileDataValue["adventure-cycle.jpg"]);
            //Draw the image in the specified location and size.
            page.Graphics.DrawImage(img, new RectangleF(150, 40, 250, 150));

            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 15);

            page.Graphics.DrawString("Watermark Annotation", font, PdfBrushes.Black, new PointF(30, 0));

            PdfTextElement textElement = new PdfTextElement("Adventure Works Cycles, the fictitious company on which the AdventureWorks sample databases are based," +
                                " is a large, multinational manufacturing company. The company manufactures and sells metal and composite bicycles to North American, " +
                                "European and Asian commercial markets. While its base operation is located in Bothell, Washington with 290 employees, several regional" +
                                " sales teams are located throughout their market base.")
            {
                Font = font
            };
            PdfLayoutResult layoutResult = textElement.Draw(page, new RectangleF(0, 220, pageClientSize.Width, pageClientSize.Height));

            textElement = new PdfTextElement("In 2000, Adventure Works Cycles bought a small manufacturing plant, Importadores Neptuno, located in Mexico." +
                " Importadores Neptuno manufactures several critical subcomponents for the Adventure Works Cycles product line." +
                " These subcomponents are shipped to the Bothell location for final product assembly. In 2001, Importadores Neptuno," +
                " became the sole manufacturer and distributor of the touring bicycle product group.")
            {
                Font = font
            };
            layoutResult = textElement.Draw(page, new RectangleF(0, layoutResult.Bounds.Bottom + 20, pageClientSize.Width, pageClientSize.Height));

            //Create watermark annotation.
            PdfWatermarkAnnotation watermarkAnnotation = new PdfWatermarkAnnotation(new RectangleF(0, 0, pageClientSize.Width, pageClientSize.Height));
            //Set opacity.
            watermarkAnnotation.Opacity = 0.25F;
            watermarkAnnotation.AnnotationFlags = PdfAnnotationFlags.Print;
            //Get the appearance graphics.
            PdfGraphics graphics = watermarkAnnotation.Appearance.Normal.Graphics;
            string watermarkText = "Confidential";
            PdfFont watermarkFont = new PdfStandardFont(PdfFontFamily.Helvetica, 40);
            SizeF textSize = watermarkFont.MeasureString(watermarkText);
            //Find the center position.
            float x = pageClientSize.Width / 2 - textSize.Width / 2;
            float y = pageClientSize.Height / 2;
            graphics.Save();
            graphics.TranslateTransform(x, y);
            graphics.RotateTransform(-45);
            //Draw the watermark content.
            graphics.DrawString(watermarkText, watermarkFont, PdfBrushes.Red, PointF.Empty);
            graphics.Restore();
            //Add the watermark annotation to the PDF page.
            page.Annotations.Add(watermarkAnnotation);
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
