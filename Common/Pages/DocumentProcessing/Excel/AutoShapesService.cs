#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.Drawing;
using Syncfusion.XlsIO;
using System.IO;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class AutoShapesService
    {
        /// <summary>
        /// Create the Excel document with auto shapes
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream AutoShapesXlsIO()
        {
            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Step 2 : Instantiate the excel application object
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;

                //A new workbook is created.[Equivalent to creating a new workbook in Microsoft Excel]
                //The new workbook will have 1 worksheet
                IWorkbook workbook = application.Workbooks.Create(1);

                //The first worksheet object in the worksheets collection is accessed
                IWorksheet worksheet = workbook.Worksheets[0];

                #region AddAutoShapes
                IShape shape;
                string text;
                IFont font;
                IFont font2;

                font = workbook.CreateFont();
                font.Color = ExcelKnownColors.White;
                font.FontName = "Segoe UI";
                font.Bold = true;
                font.Size = 12;

                font2 = workbook.CreateFont();
                font2.Color = ExcelKnownColors.White;
                font2.FontName = "Segoe UI";
                font2.Bold = true;
                font2.Size = 20;

                text = "Requirement";
                shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.RoundedRectangle, 2, 7, 60, 192);
                shape.TextFrame.TextRange.Text = text;
                shape.TextFrame.TextRange.RichText.SetFont(0, text.Length - 1, font);
                shape.TextFrame.TextRange.RichText.SetFont(0, 0, font2);
                shape.Fill.ForeColor = Color.FromArgb(245, 147, 30);
                shape.Line.Visible = false;
                shape.TextFrame.VerticalAlignment = ExcelVerticalAlignment.MiddleCentered;

                shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.DownArrow, 5, 8, 40, 64);
                shape.Fill.ForeColorIndex = ExcelKnownColors.White;
                shape.Line.ForeColorIndex = ExcelKnownColors.Blue;
                shape.Line.Weight = 1;

                font = workbook.CreateFont();
                font.Color = ExcelKnownColors.White;
                font.FontName = "Segoe UI";
                font.Size = 12;

                font2 = workbook.CreateFont();
                font2.Color = ExcelKnownColors.White;
                font2.FontName = "Segoe UI";
                font2.Size = 20;

                text = "Design";
                shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.RoundedRectangle, 7, 7, 60, 192);
                shape.TextFrame.TextRange.Text = text;
                shape.TextFrame.TextRange.RichText.SetFont(0, text.Length - 1, font);
                shape.TextFrame.TextRange.RichText.SetFont(0, 0, font2);
                shape.Line.Visible = false;
                shape.Fill.ForeColor = Color.FromArgb(153, 175, 60);
                shape.TextFrame.VerticalAlignment = ExcelVerticalAlignment.MiddleCentered;

                shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.DownArrow, 10, 8, 40, 64);
                shape.Fill.ForeColorIndex = ExcelKnownColors.White;
                shape.Line.ForeColorIndex = ExcelKnownColors.Blue;
                shape.Line.Weight = 1;

                font = workbook.CreateFont();
                font.Color = ExcelKnownColors.White;
                font.FontName = "Segoe UI";
                font.Italic = true;
                font.Size = 12;

                font2 = workbook.CreateFont();
                font2.Color = ExcelKnownColors.White;
                font2.FontName = "Segoe UI";
                font2.Size = 20;
                font2.Italic = true;

                text = "Execution";
                shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.RoundedRectangle, 12, 7, 60, 192);
                shape.TextFrame.TextRange.Text = text;
                shape.TextFrame.TextRange.RichText.SetFont(0, text.Length - 1, font);
                shape.TextFrame.TextRange.RichText.SetFont(0, 0, font2);
                shape.Line.Visible = false;
                shape.Fill.ForeColor = Color.FromArgb(236, 28, 36);
                shape.TextFrame.VerticalAlignment = ExcelVerticalAlignment.MiddleCentered;

                shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.DownArrow, 15, 8, 40, 64);
                shape.Fill.ForeColorIndex = ExcelKnownColors.White;
                shape.Line.ForeColorIndex = ExcelKnownColors.Blue;
                shape.Line.Weight = 1;

                font = workbook.CreateFont();
                font.Color = ExcelKnownColors.Dark_red;
                font.FontName = "Segoe UI";
                font.Size = 12;
                font.Underline = ExcelUnderline.Single;

                font2 = workbook.CreateFont();
                font2.Color = ExcelKnownColors.Dark_red;
                font2.FontName = "Segoe UI";
                font2.Size = 20;
                font2.Underline = ExcelUnderline.Single;

                text = "Testing";
                shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.RoundedRectangle, 17, 7, 60, 192);
                shape.TextFrame.TextRange.Text = text;
                shape.TextFrame.TextRange.RichText.SetFont(0, text.Length - 1, font);
                shape.TextFrame.TextRange.RichText.SetFont(0, 0, font2);
                shape.Line.Visible = false;
                shape.Fill.ForeColor = Color.FromArgb(248, 188, 25);
                shape.TextFrame.VerticalAlignment = ExcelVerticalAlignment.MiddleCentered;

                shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.DownArrow, 20, 8, 40, 64);
                shape.Fill.ForeColorIndex = ExcelKnownColors.White;
                shape.Line.ForeColorIndex = ExcelKnownColors.Blue;
                shape.Line.Weight = 1;

                font = workbook.CreateFont();
                font.Color = ExcelKnownColors.Black;
                font.FontName = "Segoe UI";
                font.Size = 12;

                font2 = workbook.CreateFont();
                font2.Color = ExcelKnownColors.Black;
                font2.FontName = "Segoe UI";
                font2.Size = 20;

                text = "Release";
                shape = worksheet.Shapes.AddAutoShapes(AutoShapeType.RoundedRectangle, 22, 7, 60, 192);
                shape.TextFrame.TextRange.Text = text;
                shape.TextFrame.TextRange.RichText.SetFont(0, text.Length - 1, font);
                shape.TextFrame.TextRange.RichText.SetFont(0, 0, font2);
                shape.Line.Visible = false;
                shape.Fill.ForeColor = Color.FromArgb(93, 193, 208);
                shape.TextFrame.VerticalAlignment = ExcelVerticalAlignment.MiddleCentered;
                #endregion

                //Save the document as a stream and return the stream
                using (MemoryStream stream = new MemoryStream())
                {
                    //Save the created Excel document to MemoryStream
                    workbook.SaveAs(stream);
                    return stream;
                }
            }
        }
    }
}