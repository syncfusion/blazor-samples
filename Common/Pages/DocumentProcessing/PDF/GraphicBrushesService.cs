#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using System.IO;
using System;
using Syncfusion.Pdf.ColorSpace;
using Syncfusion.Pdf.Functions;
using System.Collections.Generic;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class GraphicBrushesService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public GraphicBrushesService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream CreatePdfDocument()
        {
            //Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.PageSettings = new PdfPageSettings(new SizeF(300, 400));

            # region Graphic Brushes
            PdfPage page = document.Pages.Add();
            PdfGraphics graphics = page.Graphics;

           
            PdfImage image = PdfImage.FromStream(fileDataValue["simple.jpg"]);

            PdfFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 8f, PdfFontStyle.Bold);
            PdfFont font1 = new PdfStandardFont(PdfFontFamily.TimesRoman, 7f, PdfFontStyle.Bold);

            graphics.DrawString("PDF Graphic Brushes", font, PdfBrushes.Black, new PointF(80, 20));

            graphics.DrawString("Solid Brush", font1, PdfBrushes.Black, new PointF(10, 40));

            //SolidBrush 
            RectangleF rectangle = new RectangleF(20, 60, 50, 50);
            PdfSolidBrush brush = new PdfSolidBrush(Color.Black);

            graphics.DrawEllipse(brush, rectangle);

            graphics.TranslateTransform(60, 0);
            brush = new PdfSolidBrush(Color.Green);
            graphics.DrawEllipse(brush, rectangle);

            graphics.TranslateTransform(60, 0);
            brush.Color = Color.Red;
            PdfBrush someBrush = brush.Clone();
            graphics.DrawEllipse(someBrush, rectangle);

            graphics.TranslateTransform(-120, 70);
            graphics.DrawString("Tiling Brush", font1, PdfBrushes.Black, new PointF(10, 60));

            //TillingBrush 
            graphics.TranslateTransform(0, 20);

            PdfTilingBrush tillingBrush = new PdfTilingBrush(new SizeF(10, 10));
            RectangleF rect = new RectangleF(0, 0, 10, 10);

            tillingBrush.Graphics.DrawImage(image, 0, 0, 10, 10);
            graphics.DrawEllipse(tillingBrush, rectangle);

            graphics.TranslateTransform(60, 0);
            tillingBrush = new PdfTilingBrush(rect);
            tillingBrush.Graphics.DrawEllipse(PdfPens.Yellow, rect);
            tillingBrush.Graphics.DrawLine(PdfPens.Green, 0, 0, 10, 10);
            tillingBrush.Graphics.DrawLine(PdfPens.Red, 0, 10, 10, 0);
            graphics.DrawEllipse(tillingBrush, rectangle);

            graphics.TranslateTransform(60, 0);

            rect = new RectangleF(0, 0, 20, 20);
            PdfTilingBrush tillingBrushNew = new PdfTilingBrush(rect);

            tillingBrushNew.Graphics.DrawEllipse(tillingBrush, rect);
            graphics.DrawEllipse(tillingBrushNew, rectangle);

            #endregion

            #region PdfColorSpace

            page = document.Pages.Add();
            PdfGraphics g = page.Graphics;

            g.DrawString("Color Space", font, PdfBrushes.Black, new PointF(120, 20));

            //Set DeviceRGB Colorspace.
            document.ColorSpace = PdfColorSpace.RGB;
            page.Graphics.DrawString("Device RGB", font, PdfBrushes.Black, new PointF(10, 50));
            PdfBrush brush1 = PdfBrushes.Green;
            g.DrawRectangle(brush1, new RectangleF(20, 70, 30, 30));

            //Set DeviceCMYK Colorspace.
            document.ColorSpace = PdfColorSpace.CMYK;
            page.Graphics.DrawString("Device CMYK", font, PdfBrushes.Black, new PointF(90, 50));
            g.DrawEllipse(brush1, new RectangleF(100, 70, 30, 30));

            //Set DeviceGray Colorspace.
            document.ColorSpace = PdfColorSpace.GrayScale;
            page.Graphics.DrawString("Device Gray", font, PdfBrushes.Black, new PointF(170, 50));
            g.DrawPie(brush1, new RectangleF(180, 70, 30, 30), 0, 45);
            # endregion

            # region CIE Based Color Space

            # region CalRGB Color
            document.ColorSpace = PdfColorSpace.RGB;
            //page = document.Pages.Add();
            g = page.Graphics;
            g.DrawString("CalRGB Color", font, PdfBrushes.Black, new PointF(10, 130));

            rect = new RectangleF(20, 140, 30, 30);

            // Instantiate CalRGB Color Space
            PdfCalRGBColorSpace calRgbCS = new PdfCalRGBColorSpace();
            calRgbCS.Gamma = new double[] { 1.6, 1.1, 2.5 };
            calRgbCS.Matrix = new double[] { 1, 0, 0, 0, 1, 0, 0, 0, 1 };
            calRgbCS.WhitePoint = new double[] { 0.2, 1, 0.8 };
            PdfCalRGBColor red = new PdfCalRGBColor(calRgbCS);
            red.Red = 0;
            red.Green = 1;
            red.Blue = 0;

            PdfBrush brush2 = new PdfSolidBrush(red);
            g.DrawRectangle(brush2, rect);
            # endregion

            # region CalGray Color
            g.DrawString("CalGray Color", font, PdfBrushes.Black, new PointF(90, 130));
            rect = new RectangleF(100, 140, 30, 30);

            PdfCalGrayColorSpace calGrayCS = new PdfCalGrayColorSpace();
            calGrayCS.Gamma = 0.7;
            calGrayCS.WhitePoint = new double[] { 0.2, 1, 0.8 };

            PdfCalGrayColor red1 = new PdfCalGrayColor(calGrayCS);
            red1.Gray = 0.1;
            brush2 = new PdfSolidBrush(red1);
            g.DrawRectangle(brush2, rect);
            # endregion

            # region Lab Color
            page.Graphics.DrawString("Lab Color", font, PdfBrushes.Black, new PointF(170, 130));

            rect = new RectangleF(180, 140, 30, 30);
            PdfLabColorSpace calGrayCS1 = new PdfLabColorSpace();
            calGrayCS1.Range = new double[] { 0.2, 1, 0.8, 23.5 };
            calGrayCS1.WhitePoint = new double[] { 0.2, 1, 0.8 };

            PdfLabColor red2 = new PdfLabColor(calGrayCS1);
            red2.L = 90;
            red2.A = 0.5;
            red2.B = 20;

            brush2 = new PdfSolidBrush(red2);
            g.DrawRectangle(brush2, rect);
            # endregion

            # region ICC Color
            g.DrawString("ICC Color", font, PdfBrushes.Black, new PointF(10, 200));
            rect = new RectangleF(20, 210, 30, 30);

            PdfCalRGBColorSpace calRgbCS3 = new PdfCalRGBColorSpace();
            calRgbCS3.Gamma = new double[] { 7.6, 5.1, 8.5 };
            calRgbCS3.Matrix = new double[] { 1, 0, 0, 0, 1, 0, 0, 0, 1 };
            calRgbCS3.WhitePoint = new double[] { 0.7, 1, 0.8 };

            // Read the ICC profile.
            MemoryStream fs = fileDataValue["rgb.icc"];
            byte[] profileData = new byte[fs.Length];
            fs.Read(profileData, 0, profileData.Length);
            fs.Dispose();

            PdfICCColorSpace IccBasedCS4 = new PdfICCColorSpace();
            IccBasedCS4.ProfileData = profileData;
            IccBasedCS4.AlternateColorSpace = calRgbCS3;
            IccBasedCS4.ColorComponents = 3;
            IccBasedCS4.Range = new double[] { 0.0, 1.0, 0.0, 1.0, 0.0, 1.0 };
            PdfICCColor red4 = new PdfICCColor(IccBasedCS4);
            red4.ColorComponents = new double[] { 1, 0, 1 };
            brush2 = new PdfSolidBrush(red4);

            g.DrawRectangle(brush2, rect);
            # endregion

            # region Separation Color
            g.DrawString("Separation Color", font, PdfBrushes.Black, new PointF(90, 200));
            rect = new RectangleF(100, 210, 30, 30);

            PdfExponentialInterpolationFunction function = new PdfExponentialInterpolationFunction(true);
            float[] numArray = new float[3];
            numArray[0] = 90f;
            numArray[1] = 0.5f;
            numArray[2] = 20f;
            function.C1 = numArray;

            PdfLabColorSpace calLabCS8 = new PdfLabColorSpace();
            calLabCS8.Range = new double[] { 0.2, 1, 0.8, 23.5 };
            calLabCS8.WhitePoint = new double[] { 0.2, 1, 0.8 };

            PdfSeparationColorSpace colorspace8 = new PdfSeparationColorSpace();
            colorspace8.AlternateColorSpaces = calLabCS8;
            colorspace8.TintTransform = function;
            colorspace8.Colorant = "PANTONE Orange 021 C";
            PdfSeparationColor color8 = new PdfSeparationColor(colorspace8);
            color8.Tint = 0.7;

            brush2 = new PdfSolidBrush(color8);
            g.DrawRectangle(brush2, rect);
            # endregion

            # region Indexed Color
            g.DrawString("Indexed Color", font, PdfBrushes.Black, new PointF(170, 200));
            rect = new RectangleF(180, 210, 30, 30);

            PdfIndexedColorSpace colorspace7 = new PdfIndexedColorSpace();
            colorspace7.BaseColorSpace = new PdfDeviceColorSpace(PdfColorSpace.RGB);
            colorspace7.MaxColorIndex = 3;
            colorspace7.IndexedColorTable = new byte[] { 150, 0, 222, 255, 0, 0, 0, 255, 0, 0, 0, 255 };

            PdfIndexedColor color7 = new PdfIndexedColor(colorspace7);
            color7.SelectColorIndex = 3;

            brush2 = new PdfSolidBrush(color7);
            g.DrawRectangle(brush2, rect);
            # endregion

            # endregion

            //Save the PDF to the MemoryStream
            MemoryStream ms = new MemoryStream();

            document.Save(ms);

            //If the position is not set to '0' then the PDF will be empty.
            ms.Position = 0;

            //Close the PDF document.
            document.Close(true);

            return ms;            
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
