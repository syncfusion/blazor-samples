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
    public class TableService
    {        
        /// <summary>
        /// Create a simple Presentation document
        /// </summary>
        /// <returns>Return the created Presentation document as stream</returns>
        public MemoryStream CreateTableSample()
        {
            ///New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].
            IPresentation presentation = Syncfusion.Presentation.Presentation.Create();
            //Method call to create slides in presentation.
            CreateSlide(presentation);

            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created PowerPoint document to MemoryStream
                presentation.Save(stream);
                return stream;
            }
        }
		
		# region Slide
        private void CreateSlide(IPresentation presentation)
        {
            //Adding Title Slide to the first slide of the Presentation.
            ISlide slide2 = presentation.Slides.Add(SlideLayoutType.TitleOnly);
            IShape shape1 = slide2.Shapes[0] as IShape;
            shape1.Left = 1.17 * 72;
            shape1.Top = 0;
            shape1.Width = 11 * 72;
            shape1.Height = 1.76 * 72;
            ITextBody textFrame1 = shape1.TextBody;
            IParagraphs paragraphs1 = textFrame1.Paragraphs;
            paragraphs1.Add();
            IParagraph paragraph1 = paragraphs1[0];
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;

            //Instance to hold textparts in paragraph.
            ITextParts textParts1 = paragraph1.TextParts;
            textParts1.Add();
            ITextPart textPart1 = textParts1[0];
            textPart1.Text = "Target "; ;
            IFont font1 = textPart1.Font;
            font1.FontName = "Arial";
            font1.FontSize = 28;
            font1.Bold = true;
            font1.CapsType = TextCapsType.All;
            textParts1.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart2 = textParts1[1];
            textPart2.Text = "VS ";
            IFont font2 = textPart2.Font;
            font2.FontName = "Arial";
            font2.FontSize = 18;
            textParts1.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart3 = textParts1[2];

            textPart3.Text = "PERFORMANCE";
            IFont font3 = textPart3.Font;
            font3.FontName = "Arial";
            font3.FontSize = 28;
            font3.Bold = true;

            //To add a new table in slide and set its stylepreset
            ITable table = slide2.Shapes.AddTable(10, 9, 0.86 * 72, 1.33 * 72, 11.90 * 72, 5.26 * 72);
            table.BuiltInStyle = BuiltInTableStyle.MediumStyle2Accent6;


            //Instance to hold rows in table
            IRows rows = table.Rows;
            IRow row1 = rows[0];
            row1.Height = 81.44;

            //To set text alignment type inside cell
            ICell cell11 = row1.Cells[0];
            cell11.TextBody.VerticalAlignment = VerticalAlignmentType.Middle;

            //To add a paragraph inside cell
            IParagraphs paragraphs11 = cell11.TextBody.Paragraphs;
            paragraphs11.Add();
            IParagraph paragraph11 = paragraphs11[0];
            paragraph11.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextParts textParts11 = paragraph11.TextParts;
            textParts11.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart11 = textParts11[0];
            textPart11.Text = "Month";
            IFont font11 = textPart11.Font;
            font11.FontName = "Arial";
            font11.FontSize = 14;
            font11.Bold = true;

            ICell cell12 = row1.Cells[1];
            cell12.TextBody.VerticalAlignment = VerticalAlignmentType.Middle;

            //To add a paragraph inside cell
            IParagraphs paragraphs12 = cell12.TextBody.Paragraphs;
            paragraphs12.Add();
            IParagraph paragraph12 = paragraphs12[0];
            paragraph12.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextParts textParts12 = paragraph12.TextParts;
            textParts12.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart12 = textParts12[0];
            textPart12.Text = "Product A";
            IFont font12 = textPart12.Font;
            font12.FontName = "Arial";
            font12.FontSize = 14;
            font12.Bold = true;

            //To set text alignment type inside cell
            ICell cell13 = row1.Cells[2];
            cell13.TextBody.VerticalAlignment = VerticalAlignmentType.Middle;

            //To add a paragraph inside cell
            IParagraphs paragraphs13 = cell13.TextBody.Paragraphs;
            paragraphs13.Add();
            IParagraph paragraph13 = paragraphs13[0];
            paragraph13.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextParts textParts13 = paragraph13.TextParts;
            textParts13.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart13 = textParts13[0];
            textPart13.Text = "Product B";
            IFont font13 = textPart13.Font;
            font13.FontName = "Arial";
            font13.FontSize = 14;
            font13.Bold = true;

            ICell cell14 = row1.Cells[3];
            cell14.TextBody.VerticalAlignment = VerticalAlignmentType.Middle;

            //To add a paragraph inside cell
            IParagraphs paragraphs14 = cell14.TextBody.Paragraphs;
            paragraphs14.Add();
            IParagraph paragraph14 = paragraphs14[0];
            paragraph14.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextParts textParts14 = paragraph14.TextParts;
            textParts14.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart14 = textParts14[0];
            textPart14.Text = "Product C";
            IFont font14 = textPart14.Font;
            font14.FontName = "Arial";
            font14.FontSize = 14;
            font14.Bold = true;

            ICell cell15 = row1.Cells[4];
            cell15.TextBody.VerticalAlignment = VerticalAlignmentType.Middle;

            //To add a paragraph inside cell
            IParagraphs paragraphs15 = cell15.TextBody.Paragraphs;
            paragraphs15.Add();
            IParagraph paragraph15 = paragraphs15[0];
            paragraph15.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextParts textParts15 = paragraph15.TextParts;
            textParts15.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart15 = textParts15[0];
            textPart15.Text = "Product D";
            IFont font15 = textPart15.Font;
            font15.FontName = "Arial";
            font15.FontSize = 14;
            font15.Bold = true;

            ICell cell16 = row1.Cells[5];
            cell16.TextBody.VerticalAlignment = VerticalAlignmentType.Middle;

            //To add a paragraph inside cell
            IParagraphs paragraphs16 = cell16.TextBody.Paragraphs;
            paragraphs16.Add();
            IParagraph paragraph16 = paragraphs16[0];
            paragraph16.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextParts textParts16 = paragraph16.TextParts;
            textParts16.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart16 = textParts16[0];
            textPart16.Text = "Product E";
            IFont font16 = textPart16.Font;
            font16.FontName = "Arial";
            font16.FontSize = 14;
            font16.Bold = true;

            ICell cell17 = row1.Cells[6];
            cell17.TextBody.VerticalAlignment = VerticalAlignmentType.Middle;

            //To add a paragraph inside cell
            IParagraphs paragraphs17 = cell17.TextBody.Paragraphs;
            paragraphs17.Add();
            IParagraph paragraph17 = paragraphs17[0];
            paragraph17.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextParts textParts17 = paragraph17.TextParts;
            textParts17.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart17 = textParts17[0];
            textPart17.Text = "Product F";
            IFont font17 = textPart17.Font;
            font17.FontName = "Arial";
            font17.FontSize = 14;
            font17.Bold = true;

            ICell cell18 = row1.Cells[7];
            cell18.TextBody.VerticalAlignment = VerticalAlignmentType.Middle;

            //To add a paragraph inside cell
            IParagraphs paragraphs18 = cell18.TextBody.Paragraphs;
            paragraphs18.Add();
            IParagraph paragraph18 = paragraphs18[0];
            paragraph18.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts18 = paragraph18.TextParts;
            textParts18.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart18 = textParts18[0];
            textPart18.Text = "Average ";
            IFont font18 = textPart18.Font;
            font18.FontName = "Arial";
            font18.FontSize = 14;
            font18.Bold = true;

            ICell cell19 = row1.Cells[8];
            cell19.TextBody.VerticalAlignment = VerticalAlignmentType.Middle;

            //To add a paragraph inside cell
            IParagraphs paragraphs19 = cell19.TextBody.Paragraphs;
            paragraphs19.Add();
            IParagraph paragraph19 = paragraphs19[0];
            paragraph19.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextParts textParts19 = paragraph19.TextParts;
            textParts19.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart19 = textParts19[0];
            textPart19.Text = "Target";
            IFont font19 = textPart19.Font;
            font19.FontName = "Arial";
            font19.FontSize = 14;
            font19.Bold = true;

            IRow row2 = table.Rows[1];
            row2.Height = 34.90;

            ICell cell21 = row2.Cells[0];
            IParagraphs paragraphs21 = cell21.TextBody.Paragraphs;

            //To add a paragraph inside cell
            paragraphs21.Add();
            IParagraph paragraph21 = paragraphs21[0];
            paragraph21.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts21 = paragraph21.TextParts;
            textParts21.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart21 = textParts21[0];
            textPart21.Text = "Jan";
            IFont font21 = textPart21.Font;
            font21.FontName = "Arial";
            font21.FontSize = 14;

            ICell cell22 = row2.Cells[1];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs22 = cell22.TextBody.Paragraphs;
            paragraphs22.Add();
            IParagraph paragraph22 = paragraphs22[0];
            paragraph22.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts22 = paragraph22.TextParts;
            textParts22.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart22 = textParts22[0];
            textPart22.Text = "20000";
            IFont font22 = textPart22.Font;
            font22.FontName = "Arial";
            font22.FontSize = 14;

            ICell cell23 = row2.Cells[2];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs23 = cell23.TextBody.Paragraphs;
            paragraphs23.Add();
            IParagraph paragraph23 = paragraphs23[0];
            paragraph23.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts23 = paragraph23.TextParts;
            textParts23.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart23 = textParts23[0];
            textPart23.Text = "4200";
            IFont font23 = textPart23.Font;
            font23.FontName = "Arial";
            font23.FontSize = 14;

            ICell cell24 = row2.Cells[3];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs24 = cell24.TextBody.Paragraphs;
            paragraphs24.Add();
            IParagraph paragraph24 = paragraphs24[0];
            paragraph24.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts24 = paragraph24.TextParts;
            textParts24.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart24 = textParts24[0];
            textPart24.Text = "8000";
            IFont font24 = textPart24.Font;
            font24.FontName = "Arial";
            font24.FontSize = 14;

            ICell cell25 = row2.Cells[4];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs25 = cell25.TextBody.Paragraphs;
            paragraphs25.Add();
            IParagraph paragraph25 = paragraphs25[0];
            paragraph25.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts25 = paragraph25.TextParts;
            textParts25.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart25 = textParts25[0];
            textPart25.Text = "12000";
            IFont font25 = textPart25.Font;
            font25.FontName = "Arial";
            font25.FontSize = 14;

            ICell cell26 = row2.Cells[5];


            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs26 = cell26.TextBody.Paragraphs;
            paragraphs26.Add();
            IParagraph paragraph26 = paragraphs26[0];
            paragraph26.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts26 = paragraph26.TextParts;
            textParts26.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart26 = textParts26[0];
            textPart26.Text = "4700";
            IFont font26 = textPart26.Font;
            font26.FontName = "Arial";
            font26.FontSize = 14;


            ICell cell27 = row2.Cells[6];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs27 = cell27.TextBody.Paragraphs;
            paragraphs27.Add();
            IParagraph paragraph27 = paragraphs27[0];
            paragraph27.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts27 = paragraph27.TextParts;
            textParts27.Add();
            //Creates a textpart and assigns value to it.
            ITextPart textPart27 = textParts27[0];
            textPart27.Text = "15000";
            IFont font27 = textPart27.Font;
            font27.FontName = "Arial";
            font27.FontSize = 14;

            ICell cell28 = row2.Cells[7];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs28 = cell28.TextBody.Paragraphs;
            paragraphs28.Add();
            IParagraph paragraph28 = paragraphs28[0];
            paragraph28.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts28 = paragraph28.TextParts;
            textParts28.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart28 = textParts28[0];
            textPart28.Text = "3500";
            IFont font28 = textPart28.Font;
            font28.FontName = "Arial";
            font28.FontSize = 14;

            ICell cell29 = row2.Cells[8];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs29 = cell29.TextBody.Paragraphs;
            paragraphs29.Add();
            IParagraph paragraph29 = paragraphs29[0];
            paragraph29.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts29 = paragraph29.TextParts;
            textParts29.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart29 = textParts29[0];
            textPart29.Text = "35000";
            IFont font29 = textPart29.Font;
            font29.FontName = "Arial";
            font29.FontSize = 14;

            //To set height of the row.
            IRow row3 = table.Rows[2];
            row2.Height = 34.90;

            ICell cell31 = row3.Cells[0];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs31 = cell31.TextBody.Paragraphs;
            paragraphs31.Add();
            IParagraph paragraph31 = paragraphs31[0];
            paragraph31.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts31 = paragraph31.TextParts;
            textParts31.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart31 = textParts31[0];
            textPart31.Text = "Feb";
            IFont font31 = textPart31.Font;
            font31.FontName = "Arial";
            font31.FontSize = 14;

            ICell cell32 = row3.Cells[1];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs32 = cell32.TextBody.Paragraphs;
            paragraphs32.Add();
            IParagraph paragraph32 = paragraphs32[0];
            paragraph32.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts32 = paragraph32.TextParts;
            textParts32.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart32 = textParts32[0];
            textPart32.Text = "8300";
            IFont font32 = textPart32.Font;
            font32.FontName = "Arial";
            font32.FontSize = 14;

            ICell cell33 = row3.Cells[2];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs33 = cell33.TextBody.Paragraphs;
            paragraphs33.Add();
            IParagraph paragraph33 = paragraphs33[0];
            paragraph33.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts33 = paragraph33.TextParts;
            textParts33.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart33 = textParts33[0];
            textPart33.Text = "19000";
            IFont font33 = textPart33.Font;
            font33.FontName = "Arial";
            font33.FontSize = 14;

            ICell cell34 = row3.Cells[3];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs34 = cell34.TextBody.Paragraphs;
            paragraphs34.Add();
            IParagraph paragraph34 = paragraphs34[0];
            paragraph34.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts34 = paragraph34.TextParts;
            textParts34.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart34 = textParts34[0];
            textPart34.Text = "21000";
            IFont font34 = textPart34.Font;
            font34.FontName = "Arial";
            font34.FontSize = 14;

            ICell cell35 = row3.Cells[4];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs35 = cell35.TextBody.Paragraphs;
            paragraphs35.Add();
            IParagraph paragraph35 = paragraphs35[0];
            paragraph35.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts35 = paragraph35.TextParts;
            textParts35.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart35 = textParts35[0];
            textPart35.Text = "15230";
            IFont font35 = textPart35.Font;
            font35.FontName = "Arial";
            font35.FontSize = 14;

            ICell cell36 = row3.Cells[5];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs36 = cell36.TextBody.Paragraphs;
            paragraphs36.Add();
            IParagraph paragraph36 = paragraphs36[0];
            paragraph36.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts36 = paragraph36.TextParts;
            textParts36.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart36 = textParts36[0];
            textPart36.Text = "7230";
            IFont font36 = textPart36.Font;
            font36.FontName = "Arial";
            font36.FontSize = 14;

            ICell cell37 = row3.Cells[6];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs37 = cell37.TextBody.Paragraphs;
            paragraphs37.Add();
            IParagraph paragraph37 = paragraphs37[0];
            paragraph37.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts37 = paragraph37.TextParts;
            textParts37.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart37 = textParts37[0];
            textPart37.Text = "1800";
            IFont font37 = textPart37.Font;
            font37.FontName = "Arial";
            font37.FontSize = 14;

            ICell cell38 = row3.Cells[7];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs38 = cell38.TextBody.Paragraphs;
            paragraphs38.Add();
            IParagraph paragraph38 = paragraphs38[0];
            paragraph38.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts38 = paragraph38.TextParts;
            textParts38.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart38 = textParts38[0];
            textPart38.Text = "13000";
            IFont font38 = textPart38.Font;
            font38.FontName = "Arial";
            font38.FontSize = 14;

            ICell cell39 = row3.Cells[8];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs39 = cell39.TextBody.Paragraphs;
            paragraphs39.Add();
            IParagraph paragraph39 = paragraphs39[0];
            paragraph39.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts39 = paragraph39.TextParts;
            textParts39.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart39 = textParts39[0];
            textPart39.Text = "18000";
            IFont font39 = textPart39.Font;
            font39.FontName = "Arial";
            font39.FontSize = 14;

            IRow row4 = table.Rows[3];
            row2.Height = 34.90;

            ICell cell41 = row4.Cells[0];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs41 = cell41.TextBody.Paragraphs;
            paragraphs41.Add();
            IParagraph paragraph41 = paragraphs41[0];
            paragraph41.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts41 = paragraph41.TextParts;
            textParts41.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart41 = textParts41[0];
            textPart41.Text = "Mar";
            IFont font41 = textPart41.Font;
            font41.FontName = "Arial";
            font41.FontSize = 14;

            ICell cell42 = row4.Cells[1];

            IParagraphs paragraphs42 = cell42.TextBody.Paragraphs;
            paragraphs42.Add();
            IParagraph paragraph42 = paragraphs42[0];
            paragraph42.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts42 = paragraph42.TextParts;
            textParts42.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart42 = textParts42[0];
            textPart42.Text = "4600";
            IFont font42 = textPart42.Font;
            font42.FontName = "Arial";
            font42.FontSize = 14;

            ICell cell43 = row4.Cells[2];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs43 = cell43.TextBody.Paragraphs;
            paragraphs43.Add();
            IParagraph paragraph43 = paragraphs43[0];
            paragraph43.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts43 = paragraph43.TextParts;
            textParts43.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart43 = textParts43[0];
            textPart43.Text = "9000";
            IFont font43 = textPart43.Font;
            font43.FontName = "Arial";
            font43.FontSize = 14;

            ICell cell44 = row4.Cells[3];

            IParagraphs paragraphs44 = cell44.TextBody.Paragraphs;
            paragraphs44.Add();
            IParagraph paragraph44 = paragraphs44[0];
            paragraph44.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts44 = paragraph44.TextParts;
            textParts44.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart44 = textParts44[0];
            textPart44.Text = "7500";
            IFont font44 = textPart44.Font;
            font44.FontName = "Arial";
            font44.FontSize = 14;

            ICell cell45 = row4.Cells[4];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs45 = cell45.TextBody.Paragraphs;
            paragraphs45.Add();
            IParagraph paragraph45 = paragraphs45[0];
            paragraph45.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts45 = paragraph45.TextParts;
            textParts45.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart45 = textParts45[0];
            textPart45.Text = "8000";
            IFont font45 = textPart45.Font;
            font45.FontName = "Arial";
            font45.FontSize = 14;

            ICell cell46 = row4.Cells[5];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs46 = cell46.TextBody.Paragraphs;
            paragraphs46.Add();
            IParagraph paragraph46 = paragraphs46[0];
            paragraph46.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts46 = paragraph46.TextParts;
            textParts46.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart46 = textParts46[0];
            textPart46.Text = "30000";
            IFont font46 = textPart46.Font;
            font46.FontName = "Arial";
            font46.FontSize = 14;

            ICell cell47 = row4.Cells[6];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs47 = cell47.TextBody.Paragraphs;
            paragraphs47.Add();
            IParagraph paragraph47 = paragraphs47[0];
            paragraph47.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts47 = paragraph47.TextParts;
            textParts47.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart47 = textParts47[0];
            textPart47.Text = "22000";
            IFont font47 = textPart47.Font;
            font47.FontName = "Arial";
            font47.FontSize = 14;

            ICell cell48 = row4.Cells[7];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs48 = cell48.TextBody.Paragraphs;
            paragraphs48.Add();
            IParagraph paragraph48 = paragraphs48[0];
            paragraph48.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts48 = paragraph48.TextParts;
            textParts48.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart48 = textParts48[0];
            textPart48.Text = "4500";
            IFont font48 = textPart48.Font;
            font48.FontName = "Arial";
            font48.FontSize = 14;

            ICell cell49 = row4.Cells[8];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs49 = cell49.TextBody.Paragraphs;
            paragraphs49.Add();
            IParagraph paragraph49 = paragraphs49[0];
            paragraph49.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts49 = paragraph49.TextParts;
            textParts49.Add();
            ITextPart textPart49 = textParts49[0];

            textPart49.Text = "13200";
            IFont font49 = textPart49.Font;
            font49.FontName = "Arial";
            font49.FontSize = 14;

            IRow row5 = table.Rows[4];
            row2.Height = 34.90;

            ICell cell51 = row5.Cells[0];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs51 = cell51.TextBody.Paragraphs;
            paragraphs51.Add();
            IParagraph paragraph51 = paragraphs51[0];
            paragraph51.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts51 = paragraph51.TextParts;
            textParts51.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart51 = textParts51[0];
            textPart51.Text = "Apr";
            IFont font51 = textPart51.Font;
            font51.FontName = "Arial";
            font51.FontSize = 14;

            ICell cell52 = row5.Cells[1];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs52 = cell52.TextBody.Paragraphs;
            paragraphs52.Add();
            IParagraph paragraph52 = paragraphs52[0];
            paragraph52.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts52 = paragraph52.TextParts;
            textParts52.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart52 = textParts52[0];
            textPart52.Text = "3530";
            IFont font52 = textPart52.Font;
            font52.FontName = "Arial";
            font52.FontSize = 14;

            ICell cell53 = row5.Cells[2];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs53 = cell53.TextBody.Paragraphs;
            paragraphs53.Add();
            IParagraph paragraph53 = paragraphs53[0];
            paragraph53.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts53 = paragraph53.TextParts;
            textParts53.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart53 = textParts53[0];
            textPart53.Text = "13430";
            IFont font53 = textPart53.Font;
            font53.FontName = "Arial";
            font53.FontSize = 14;

            ICell cell54 = row5.Cells[3];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs54 = cell54.TextBody.Paragraphs;
            paragraphs54.Add();
            IParagraph paragraph54 = paragraphs54[0];
            paragraph54.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts54 = paragraph54.TextParts;
            textParts54.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart54 = textParts54[0];
            textPart54.Text = "3550";
            IFont font54 = textPart54.Font;
            font54.FontName = "Arial";
            font54.FontSize = 14;

            ICell cell55 = row5.Cells[4];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs55 = cell55.TextBody.Paragraphs;
            paragraphs55.Add();
            IParagraph paragraph55 = paragraphs55[0];
            paragraph55.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts55 = paragraph55.TextParts;
            textParts55.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart55 = textParts55[0];
            textPart55.Text = "10670";
            IFont font55 = textPart55.Font;
            font55.FontName = "Arial";
            font55.FontSize = 14;

            ICell cell56 = row5.Cells[5];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs56 = cell56.TextBody.Paragraphs;
            paragraphs56.Add();
            IParagraph paragraph56 = paragraphs56[0];
            paragraph56.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts56 = paragraph56.TextParts;
            textParts56.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart56 = textParts56[0];
            textPart56.Text = "27860";
            IFont font56 = textPart56.Font;
            font56.FontName = "Arial";
            font56.FontSize = 14;

            ICell cell57 = row5.Cells[6];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs57 = cell57.TextBody.Paragraphs;
            paragraphs57.Add();
            IParagraph paragraph57 = paragraphs57[0];
            paragraph57.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts57 = paragraph57.TextParts;
            textParts57.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart57 = textParts57[0];
            textPart57.Text = "5414";
            IFont font57 = textPart57.Font;
            font57.FontName = "Arial";
            font57.FontSize = 14;

            ICell cell58 = row5.Cells[7];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs58 = cell58.TextBody.Paragraphs;
            paragraphs58.Add();
            IParagraph paragraph58 = paragraphs58[0];
            paragraph58.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts58 = paragraph58.TextParts;
            textParts58.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart58 = textParts58[0];
            textPart58.Text = "5600";
            IFont font58 = textPart58.Font;
            font58.FontName = "Arial";
            font58.FontSize = 14;

            ICell cell59 = row5.Cells[8];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs59 = cell59.TextBody.Paragraphs;
            paragraphs59.Add();
            IParagraph paragraph59 = paragraphs59[0];
            paragraph59.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts59 = paragraph59.TextParts;
            textParts59.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart59 = textParts59[0];
            textPart59.Text = "50000";
            IFont font59 = textPart59.Font;
            font59.FontName = "Arial";
            font59.FontSize = 14;

            //To set row height
            IRow row6 = table.Rows[5];
            row6.Height = 34.90;

            ICell cell61 = row6.Cells[0];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs61 = cell61.TextBody.Paragraphs;
            paragraphs61.Add();
            IParagraph paragraph61 = paragraphs61[0];
            paragraph61.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts61 = paragraph61.TextParts;
            textParts61.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart61 = textParts61[0];
            textPart61.Text = "May";
            IFont font61 = textPart61.Font;
            font61.FontName = "Arial";
            font61.FontSize = 14;

            ICell cell62 = row6.Cells[1];


            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs62 = cell62.TextBody.Paragraphs;
            paragraphs62.Add();
            IParagraph paragraph62 = paragraphs62[0];
            paragraph62.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts62 = paragraph62.TextParts;
            textParts62.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart62 = textParts62[0];
            textPart62.Text = "10293";
            IFont font62 = textPart62.Font;
            font62.FontName = "Arial";
            font62.FontSize = 14;

            ICell cell63 = row6.Cells[2];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs63 = cell63.TextBody.Paragraphs;
            paragraphs63.Add();
            IParagraph paragraph63 = paragraphs63[0];
            paragraph63.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts63 = paragraph63.TextParts;
            textParts63.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart63 = textParts63[0];
            textPart63.Text = "23760";
            IFont font63 = textPart63.Font;
            font63.FontName = "Arial";
            font63.FontSize = 14;

            ICell cell64 = row6.Cells[3];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs64 = cell64.TextBody.Paragraphs;
            paragraphs64.Add();
            IParagraph paragraph64 = paragraphs64[0];
            paragraph64.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts64 = paragraph64.TextParts;
            textParts64.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart64 = textParts64[0];
            textPart64.Text = "10378";
            IFont font64 = textPart64.Font;
            font64.FontName = "Arial";
            font64.FontSize = 14;

            ICell cell65 = row6.Cells[4];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs65 = cell65.TextBody.Paragraphs;
            paragraphs65.Add();
            IParagraph paragraph65 = paragraphs65[0];
            paragraph65.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts65 = paragraph65.TextParts;
            textParts65.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart65 = textParts65[0];
            textPart65.Text = "24857";
            IFont font65 = textPart65.Font;
            font65.FontName = "Arial";
            font65.FontSize = 14;

            ICell cell66 = row6.Cells[5];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs66 = cell66.TextBody.Paragraphs;
            paragraphs66.Add();
            IParagraph paragraph66 = paragraphs66[0];
            paragraph66.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts66 = paragraph66.TextParts;
            textParts66.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart66 = textParts66[0];
            textPart66.Text = "12104";
            IFont font66 = textPart66.Font;
            font66.FontName = "Arial";
            font66.FontSize = 14;

            ICell cell67 = row6.Cells[6];


            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs67 = cell67.TextBody.Paragraphs;
            paragraphs67.Add();
            IParagraph paragraph67 = paragraphs67[0];
            paragraph67.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts67 = paragraph67.TextParts;
            textParts67.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart67 = textParts67[0];
            textPart67.Text = "21350";
            IFont font67 = textPart67.Font;
            font67.FontName = "Arial";
            font67.FontSize = 14;

            ICell cell68 = row6.Cells[7];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs68 = cell68.TextBody.Paragraphs;
            paragraphs68.Add();
            IParagraph paragraph68 = paragraphs68[0];
            paragraph68.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts68 = paragraph68.TextParts;
            textParts68.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart68 = textParts68[0];
            textPart68.Text = "17023";
            IFont font68 = textPart68.Font;
            font68.FontName = "Arial";
            font68.FontSize = 14;

            ICell cell69 = row6.Cells[8];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs69 = cell69.TextBody.Paragraphs;
            paragraphs69.Add();
            IParagraph paragraph69 = paragraphs69[0];
            paragraph69.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts69 = paragraph69.TextParts;
            textParts69.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart69 = textParts69[0];
            textPart69.Text = "25460";
            IFont font69 = textPart69.Font;
            font69.FontName = "Arial";
            font69.FontSize = 14;

            //To set row height
            IRow row7 = table.Rows[6];
            row7.Height = 34.90;

            ICell cell71 = row7.Cells[0];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs71 = cell71.TextBody.Paragraphs;
            paragraphs71.Add();
            IParagraph paragraph71 = paragraphs71[0];
            paragraph71.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts71 = paragraph71.TextParts;
            textParts71.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart71 = textParts71[0];
            textPart71.Text = "Jun";
            IFont font71 = textPart71.Font;
            font71.FontName = "Arial";
            font71.FontSize = 14;

            ICell cell72 = row7.Cells[1];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs72 = cell72.TextBody.Paragraphs;
            paragraphs72.Add();
            IParagraph paragraph72 = paragraphs72[0];
            paragraph72.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts72 = paragraph72.TextParts;
            textParts72.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart72 = textParts72[0];
            textPart72.Text = "9070";
            IFont font72 = textPart72.Font;
            font72.FontName = "Arial";
            font72.FontSize = 14;

            ICell cell73 = row7.Cells[2];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs73 = cell73.TextBody.Paragraphs;
            paragraphs73.Add();
            IParagraph paragraph73 = paragraphs73[0];
            paragraph73.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts73 = paragraph73.TextParts;
            textParts73.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart73 = textParts73[0];
            textPart73.Text = "8218";
            IFont font73 = textPart73.Font;
            font73.FontName = "Arial";
            font73.FontSize = 14;

            ICell cell74 = row7.Cells[3];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs74 = cell74.TextBody.Paragraphs;
            paragraphs74.Add();
            IParagraph paragraph74 = paragraphs74[0];
            paragraph74.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts74 = paragraph74.TextParts;
            textParts74.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart74 = textParts74[0];
            textPart74.Text = "23480";
            IFont font74 = textPart74.Font;
            font74.FontName = "Arial";
            font74.FontSize = 14;

            ICell cell75 = row7.Cells[4];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs75 = cell75.TextBody.Paragraphs;
            paragraphs75.Add();
            IParagraph paragraph75 = paragraphs75[0];
            paragraph75.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts75 = paragraph75.TextParts;
            textParts75.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart75 = textParts75[0];
            textPart75.Text = "20492";
            IFont font75 = textPart75.Font;
            font75.FontName = "Arial";
            font75.FontSize = 14;

            ICell cell76 = row7.Cells[5];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs76 = cell76.TextBody.Paragraphs;
            paragraphs76.Add();
            IParagraph paragraph76 = paragraphs76[0];
            paragraph76.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts76 = paragraph76.TextParts;
            textParts76.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart76 = textParts76[0];
            textPart76.Text = "9103";
            IFont font76 = textPart76.Font;
            font76.FontName = "Arial";
            font76.FontSize = 14;

            ICell cell77 = row7.Cells[6];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs77 = cell77.TextBody.Paragraphs;
            paragraphs77.Add();
            IParagraph paragraph77 = paragraphs77[0];
            paragraph77.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts77 = paragraph77.TextParts;
            textParts77.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart77 = textParts77[0];
            textPart77.Text = "12300";
            IFont font77 = textPart77.Font;
            font77.FontName = "Arial";
            font77.FontSize = 14;

            ICell cell78 = row7.Cells[7];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs78 = cell78.TextBody.Paragraphs;
            paragraphs78.Add();
            IParagraph paragraph78 = paragraphs78[0];
            paragraph78.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts78 = paragraph78.TextParts;
            textParts78.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart78 = textParts78[0];
            textPart78.Text = "14590";
            IFont font78 = textPart78.Font;
            font78.FontName = "Arial";
            font78.FontSize = 14;

            ICell cell79 = row7.Cells[8];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs79 = cell79.TextBody.Paragraphs;
            paragraphs79.Add();
            IParagraph paragraph79 = paragraphs79[0];
            paragraph79.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts79 = paragraph79.TextParts;
            textParts79.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart79 = textParts79[0];
            textPart79.Text = "21600";
            IFont font79 = textPart79.Font;
            font79.FontName = "Arial";
            font79.FontSize = 14;

            IRow row8 = table.Rows[7];
            row8.Height = 34.90;

            ICell cell81 = row8.Cells[0];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs81 = cell81.TextBody.Paragraphs;
            paragraphs81.Add();
            IParagraph paragraph81 = paragraphs81[0];
            paragraph81.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts81 = paragraph81.TextParts;
            textParts81.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart81 = textParts81[0];
            textPart81.Text = "Jul";
            IFont font81 = textPart81.Font;
            font81.FontName = "Arial";
            font81.FontSize = 14;

            ICell cell82 = row8.Cells[1];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs82 = cell82.TextBody.Paragraphs;
            paragraphs82.Add();
            IParagraph paragraph82 = paragraphs82[0];
            paragraph82.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts82 = paragraph82.TextParts;
            textParts82.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart82 = textParts82[0];
            textPart82.Text = "23500";
            IFont font82 = textPart82.Font;
            font82.FontName = "Arial";
            font82.FontSize = 14;

            ICell cell83 = row8.Cells[2];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs83 = cell83.TextBody.Paragraphs;
            paragraphs83.Add();
            IParagraph paragraph83 = paragraphs83[0];
            paragraph83.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts83 = paragraph83.TextParts;
            textParts83.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart83 = textParts83[0];
            textPart83.Text = "19230";
            IFont font83 = textPart83.Font;
            font83.FontName = "Arial";
            font83.FontSize = 14;

            ICell cell84 = row8.Cells[3];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs84 = cell84.TextBody.Paragraphs;
            paragraphs84.Add();
            IParagraph paragraph84 = paragraphs84[0];
            paragraph84.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts84 = paragraph84.TextParts;
            textParts84.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart84 = textParts84[0];
            textPart84.Text = "87390";
            IFont font84 = textPart84.Font;
            font84.FontName = "Arial";
            font84.FontSize = 14;

            ICell cell85 = row8.Cells[4];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs85 = cell85.TextBody.Paragraphs;
            paragraphs85.Add();
            IParagraph paragraph85 = paragraphs85[0];
            paragraph85.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts85 = paragraph85.TextParts;
            textParts85.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart85 = textParts85[0];
            textPart85.Text = "25030";
            IFont font85 = textPart85.Font;
            font85.FontName = "Arial";
            font85.FontSize = 14;

            ICell cell86 = row8.Cells[5];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs86 = cell86.TextBody.Paragraphs;
            paragraphs86.Add();
            IParagraph paragraph86 = paragraphs86[0];
            paragraph86.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts86 = paragraph86.TextParts;
            textParts86.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart86 = textParts86[0];
            textPart86.Text = "28000";
            IFont font86 = textPart86.Font;
            font86.FontName = "Arial";
            font86.FontSize = 14;

            ICell cell87 = row8.Cells[6];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs87 = cell87.TextBody.Paragraphs;
            paragraphs87.Add();
            IParagraph paragraph87 = paragraphs87[0];
            paragraph87.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts87 = paragraph87.TextParts;
            textParts87.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart87 = textParts87[0];
            textPart87.Text = "11890";
            IFont font87 = textPart87.Font;
            font87.FontName = "Arial";
            font87.FontSize = 14;

            ICell cell88 = row8.Cells[7];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs88 = cell88.TextBody.Paragraphs;
            paragraphs88.Add();
            IParagraph paragraph88 = paragraphs88[0];
            paragraph88.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts88 = paragraph88.TextParts;
            textParts88.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart88 = textParts88[0];
            textPart88.Text = "16000";
            IFont font88 = textPart88.Font;
            font88.FontName = "Arial";
            font88.FontSize = 14;

            ICell cell89 = row8.Cells[8];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs89 = cell89.TextBody.Paragraphs;
            paragraphs89.Add();
            IParagraph paragraph89 = paragraphs89[0];
            paragraph89.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts89 = paragraph89.TextParts;
            textParts89.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart89 = textParts89[0];
            textPart89.Text = "37800";
            IFont font89 = textPart89.Font;
            font89.FontName = "Arial";
            font89.FontSize = 14;


            //To set row height.
            IRow row9 = table.Rows[8];
            row9.Height = 34.90;

            ICell cell91 = row9.Cells[0];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs91 = cell91.TextBody.Paragraphs;
            paragraphs91.Add();
            IParagraph paragraph91 = paragraphs91[0];
            paragraph91.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts91 = paragraph91.TextParts;
            textParts91.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart91 = textParts91[0];
            textPart91.Text = "Aug";
            IFont font91 = textPart91.Font;
            font91.FontName = "Arial";
            font91.FontSize = 14;

            ICell cell92 = row9.Cells[1];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs92 = cell92.TextBody.Paragraphs;
            paragraphs92.Add();
            IParagraph paragraph92 = paragraphs92[0];
            paragraph92.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts92 = paragraph92.TextParts;
            textParts92.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart92 = textParts92[0];
            textPart92.Text = "39000";
            IFont font92 = textPart92.Font;
            font92.FontName = "Arial";
            font92.FontSize = 14;

            ICell cell93 = row9.Cells[2];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs93 = cell93.TextBody.Paragraphs;
            paragraphs93.Add();
            IParagraph paragraph93 = paragraphs93[0];
            paragraph93.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts93 = paragraph93.TextParts;
            textParts93.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart93 = textParts93[0];
            textPart93.Text = "30301";
            IFont font93 = textPart93.Font;
            font93.FontName = "Arial";
            font93.FontSize = 14;

            ICell cell94 = row9.Cells[3];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs94 = cell94.TextBody.Paragraphs;
            paragraphs94.Add();
            IParagraph paragraph94 = paragraphs94[0];
            paragraph94.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts94 = paragraph94.TextParts;
            textParts94.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart94 = textParts94[0];
            textPart94.Text = "78356";
            IFont font94 = textPart94.Font;
            font94.FontName = "Arial";
            font94.FontSize = 14;

            ICell cell95 = row9.Cells[4];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs95 = cell95.TextBody.Paragraphs;
            paragraphs95.Add();
            IParagraph paragraph95 = paragraphs95[0];
            paragraph95.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts95 = paragraph95.TextParts;
            textParts95.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart95 = textParts95[0];
            textPart95.Text = "21121";
            IFont font95 = textPart95.Font;
            font95.FontName = "Arial";
            font95.FontSize = 14;

            ICell cell96 = row9.Cells[5];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs96 = cell96.TextBody.Paragraphs;
            paragraphs96.Add();
            IParagraph paragraph96 = paragraphs96[0];
            paragraph96.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts96 = paragraph96.TextParts;
            textParts96.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart96 = textParts96[0];
            textPart96.Text = "30443";
            IFont font96 = textPart96.Font;
            font96.FontName = "Arial";
            font96.FontSize = 14;

            ICell cell97 = row9.Cells[6];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs97 = cell97.TextBody.Paragraphs;
            paragraphs97.Add();
            IParagraph paragraph97 = paragraphs97[0];
            paragraph97.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts97 = paragraph97.TextParts;
            textParts97.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart97 = textParts97[0];
            textPart97.Text = "23230";
            IFont font97 = textPart97.Font;
            font97.FontName = "Arial";
            font97.FontSize = 14;

            ICell cell98 = row9.Cells[7];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs98 = cell98.TextBody.Paragraphs;
            paragraphs98.Add();
            IParagraph paragraph98 = paragraphs98[0];
            paragraph98.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts98 = paragraph98.TextParts;
            textParts98.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart98 = textParts98[0];
            textPart98.Text = "25000";
            IFont font98 = textPart98.Font;
            font98.FontName = "Arial";
            font98.FontSize = 14;

            ICell cell99 = row9.Cells[8];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs99 = cell99.TextBody.Paragraphs;
            paragraphs99.Add();
            IParagraph paragraph99 = paragraphs99[0];
            paragraph99.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts99 = paragraph99.TextParts;
            textParts99.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart99 = textParts99[0];
            textPart99.Text = "40900";
            IFont font99 = textPart99.Font;
            font99.FontName = "Arial";
            font99.FontSize = 14;

            //To set row height
            IRow row10 = table.Rows[9];
            row10.Height = 34.90;

            ICell cell101 = row10.Cells[0];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs101 = cell101.TextBody.Paragraphs;
            paragraphs101.Add();
            IParagraph paragraph101 = paragraphs101[0];
            paragraph101.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts101 = paragraph101.TextParts;
            textParts101.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart101 = textParts101[0];
            textPart101.Text = "Sep";
            IFont font101 = textPart101.Font;
            font101.FontName = "Arial";
            font101.FontSize = 14;

            ICell cell102 = row10.Cells[1];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs102 = cell102.TextBody.Paragraphs;
            paragraphs102.Add();
            IParagraph paragraph102 = paragraphs102[0];
            paragraph102.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts102 = paragraph102.TextParts;
            textParts102.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart102 = textParts102[0];
            textPart102.Text = "14340";
            IFont font102 = textPart102.Font;
            font102.FontName = "Arial";
            font102.FontSize = 14;

            ICell cell103 = row10.Cells[2];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs103 = cell103.TextBody.Paragraphs;
            paragraphs103.Add();
            IParagraph paragraph103 = paragraphs103[0];
            paragraph103.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts103 = paragraph103.TextParts;
            textParts103.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart103 = textParts103[0];
            textPart103.Text = "19403";
            IFont font103 = textPart103.Font;
            font103.FontName = "Arial";
            font103.FontSize = 14;

            ICell cell104 = row10.Cells[3];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs104 = cell104.TextBody.Paragraphs;
            paragraphs104.Add();
            IParagraph paragraph104 = paragraphs104[0];
            paragraph104.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts104 = paragraph104.TextParts;
            textParts104.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart104 = textParts104[0];
            textPart104.Text = "89024";
            IFont font104 = textPart104.Font;
            font104.FontName = "Arial";
            font104.FontSize = 14;

            ICell cell105 = row10.Cells[4];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs105 = cell105.TextBody.Paragraphs;
            paragraphs105.Add();
            IParagraph paragraph105 = paragraphs105[0];
            paragraph105.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts105 = paragraph105.TextParts;
            textParts105.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart105 = textParts105[0];
            textPart105.Text = "1230";
            IFont font105 = textPart105.Font;
            font105.FontName = "Arial";
            font105.FontSize = 14;

            ICell cell106 = row10.Cells[5];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs106 = cell106.TextBody.Paragraphs;
            paragraphs106.Add();
            IParagraph paragraph106 = paragraphs106[0];
            paragraph106.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts106 = paragraph106.TextParts;
            textParts106.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart106 = textParts106[0];
            textPart106.Text = "12561";
            IFont font106 = textPart106.Font;
            font106.FontName = "Arial";
            font106.FontSize = 14;

            ICell cell107 = row10.Cells[6];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs107 = cell107.TextBody.Paragraphs;
            paragraphs107.Add();
            IParagraph paragraph107 = paragraphs107[0];
            paragraph107.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts107 = paragraph107.TextParts;
            textParts107.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart107 = textParts107[0];
            textPart107.Text = "29000";
            IFont font107 = textPart107.Font;
            font107.FontName = "Arial";
            font107.FontSize = 14;
            font106.Color = ColorObject.FromArgb(1055, 1102, 0);

            ICell cell108 = row10.Cells[7];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs108 = cell108.TextBody.Paragraphs;
            paragraphs108.Add();
            IParagraph paragraph108 = paragraphs108[0];
            paragraph108.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts108 = paragraph108.TextParts;
            textParts108.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart108 = textParts108[0];
            textPart108.Text = "33400";
            IFont font108 = textPart108.Font;
            font108.FontName = "Arial";
            font108.FontSize = 14;

            ICell cell109 = row10.Cells[8];

            //Instance to hold paragraphs in cell.
            IParagraphs paragraphs109 = cell109.TextBody.Paragraphs;
            paragraphs109.Add();
            IParagraph paragraph109 = paragraphs109[0];
            paragraph109.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts109 = paragraph109.TextParts;
            textParts109.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart109 = textParts109[0];
            textPart109.Text = "29800";
            IFont font109 = textPart109.Font;
            font109.FontName = "Arial";
            font109.FontSize = 14;
        }
        #endregion       
    }
}