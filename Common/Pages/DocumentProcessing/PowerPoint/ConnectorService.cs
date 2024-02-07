#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.IO;
using Syncfusion.Presentation;

namespace BlazorDemos.Data.DocumentProcessing.PowerPoint
{
    public class ConnectorService
    {
        /// <summary>
        /// Create a simple Presentation document
        /// </summary>
        /// <returns>Return the created Presentation document as stream</returns>
        public MemoryStream CreateConnectorPresentation()
        {
            //Create an instance for PowerPoint
            IPresentation presentation = Syncfusion.Presentation.Presentation.Create();

            //Add a blank slide to Presentation
            ISlide slide = presentation.Slides.Add(SlideLayoutType.Blank);

            //Add header shape
            IShape headerTextBox = slide.Shapes.AddTextBox(58.44, 53.85, 221.93, 81.20);
            //Add a paragraph into the text box
            IParagraph paragraph = headerTextBox.TextBody.AddParagraph("Flow chart with ");
            //Add a textPart
            ITextPart textPart = paragraph.AddTextPart("Connector");
            //Change the color of the font
            textPart.Font.Color = ColorObject.FromArgb(44, 115, 230);
            //Make the textpart bold
            textPart.Font.Bold = true;
            //Set the font size of the paragraph
            paragraph.Font.FontSize = 28;

            //Add start shape to slide
            IShape startShape = slide.Shapes.AddShape(AutoShapeType.FlowChartTerminator, 420.45, 36.35, 133.93, 50.39);
            //Add a paragraph into the start shape text body
            AddParagraph(startShape, "Start", ColorObject.FromArgb(255, 149, 34));

            //Add alarm shape to slide
            IShape alarmShape = slide.Shapes.AddShape(AutoShapeType.FlowChartProcess, 420.45, 126.72, 133.93, 50.39);
            //Add a paragraph into the alarm shape text body
            AddParagraph(alarmShape, "Alarm Rings", ColorObject.FromArgb(255, 149, 34));

            //Add condition shape to slide
            IShape conditionShape = slide.Shapes.AddShape(AutoShapeType.FlowChartDecision, 420.45, 222.42, 133.93, 97.77);
            //Add a paragraph into the condition shape text body
            AddParagraph(conditionShape, "Ready to Get Up ?", ColorObject.FromArgb(44, 115, 213));

            //Add wake up shape to slide
            IShape wakeUpShape = slide.Shapes.AddShape(AutoShapeType.FlowChartProcess, 420.45, 361.52, 133.93, 50.39);
            //Add a paragraph into the wake up shape text body
            AddParagraph(wakeUpShape, "Wake Up", ColorObject.FromArgb(44, 115, 213));

            //Add end shape to slide
            IShape endShape = slide.Shapes.AddShape(AutoShapeType.FlowChartTerminator, 420.45, 453.27, 133.93, 50.39);
            //Add a paragraph into the end shape text body
            AddParagraph(endShape, "End", ColorObject.FromArgb(44, 115, 213));

            //Add snooze shape to slide
            IShape snoozeShape = slide.Shapes.AddShape(AutoShapeType.FlowChartProcess, 624.85, 245.79, 159.76, 50.02);
            //Add a paragraph into the snooze shape text body
            AddParagraph(snoozeShape, "Hit Snooze button", ColorObject.FromArgb(255, 149, 34));

            //Add relay shape to slide
            IShape relayShape = slide.Shapes.AddShape(AutoShapeType.FlowChartDelay, 624.85, 127.12, 159.76, 49.59);
            //Add a paragraph into the relay shape text body
            AddParagraph(relayShape, "Relay", ColorObject.FromArgb(255, 149, 34));

            //Connect the start shape with alarm shape using connector
            IConnector connector1 = slide.Shapes.AddConnector(ConnectorType.Straight, startShape, 2, alarmShape, 0);
            //Set the arrow style for the connector
            connector1.LineFormat.EndArrowheadStyle = ArrowheadStyle.Arrow;

            //Connect the alarm shape with condition shape using connector
            IConnector connector2 = slide.Shapes.AddConnector(ConnectorType.Straight, alarmShape, 2, conditionShape, 0);
            //Set the arrow style for the connector
            connector2.LineFormat.EndArrowheadStyle = ArrowheadStyle.Arrow;

            //Connect the condition shape with snooze shape using connector
            IConnector connector3 = slide.Shapes.AddConnector(ConnectorType.Straight, conditionShape, 3, snoozeShape, 1);
            //Set the arrow style for the connector
            connector3.LineFormat.EndArrowheadStyle = ArrowheadStyle.Arrow;

            //Connect the snooze shape with relay shape using connector
            IConnector connector4 = slide.Shapes.AddConnector(ConnectorType.Straight, snoozeShape, 0, relayShape, 2);
            //Set the arrow style for the connector
            connector4.LineFormat.EndArrowheadStyle = ArrowheadStyle.Arrow;

            //Connect the relay shape with alarm shape using connector
            IConnector connector5 = slide.Shapes.AddConnector(ConnectorType.Straight, relayShape, 1, alarmShape, 3);
            //Set the arrow style for the connector
            connector5.LineFormat.EndArrowheadStyle = ArrowheadStyle.Arrow;

            //Connect the condition shape with wake up shape using connector
            IConnector connector6 = slide.Shapes.AddConnector(ConnectorType.Straight, conditionShape, 2, wakeUpShape, 0);
            //Set the arrow style for the connector
            connector6.LineFormat.EndArrowheadStyle = ArrowheadStyle.Arrow;

            //Connect the wake up shape with end shape using connector
            IConnector connector7 = slide.Shapes.AddConnector(ConnectorType.Straight, wakeUpShape, 2, endShape, 0);
            //Set the arrow style for the connector
            connector7.LineFormat.EndArrowheadStyle = ArrowheadStyle.Arrow;

            //Add No textbox to slide
            IShape noTextBox = slide.Shapes.AddTextBox(564.02, 245.43, 51.32, 26.22);
            //Add a paragraph into the text box
            noTextBox.TextBody.AddParagraph("No");

            //Add Yes textbox to slide
            IShape yesTextBox = slide.Shapes.AddTextBox(487.21, 327.99, 50.09, 26.23);
            //Add a paragraph into the text box
            yesTextBox.TextBody.AddParagraph("Yes");
			
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created PowerPoint document to MemoryStream
                presentation.Save(stream);
                return stream;
            }
        }
		
        /// <summary>
        /// Add a paragraph into the specified shape with specified text
        /// </summary>
        /// <param name="shape">Represent the shape</param>
        /// <param name="text">Represent the text to be added</param>
        /// <param name="fillColor">Represent the color to fill the shape</param>
        private void AddParagraph(IShape shape, string text, IColor fillColor)
        {
            //set the fill type as solid
            shape.Fill.FillType = FillType.Solid;
            //Set the color of the solid fill
            shape.Fill.SolidFill.Color = fillColor;
            //set the fill type of line format as solid
            shape.LineFormat.Fill.FillType = FillType.Solid;
            //set the fill color of line format
            if (fillColor.R == 255)
                shape.LineFormat.Fill.SolidFill.Color = ColorObject.FromArgb(190, 100, 39);
            else
                shape.LineFormat.Fill.SolidFill.Color = ColorObject.FromArgb(54, 91, 157);
            //Add a paragraph into the specified shape with specified text
            IParagraph paragraph = shape.TextBody.AddParagraph(text);
            //Set the vertical alignment as center
            shape.TextBody.VerticalAlignment = VerticalAlignmentType.Middle;
            //Set horizontal alignment as center
            paragraph.HorizontalAlignment = HorizontalAlignmentType.Center;
            //Set font color as white
            paragraph.Font.Color = ColorObject.White;
            //Change the font size
            paragraph.Font.FontSize = 16;
        }
    }
}