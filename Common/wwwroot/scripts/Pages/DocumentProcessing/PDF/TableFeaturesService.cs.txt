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
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf.Interactive;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using Syncfusion.Pdf.Tables;
using System.Data;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class TableFeaturesService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public TableFeaturesService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        #region fields
        PdfPen borderPen;
        PdfPen transparentPen;
        float cellSpacing = 7f;
        float margin = 40f;
        PdfFont smallFont;
        #endregion
        public TableFeaturesService() { }
        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream TableFeaturesPDF()
        {
            # region Field Definitions
            //Create a new PDF standard font
            PdfStandardFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 8f);
            smallFont = new PdfStandardFont(font, 5f);
            PdfFont bigFont = new PdfStandardFont(font, 16f);

            //Create a new PDF solid brush
            PdfBrush orangeBrush = new PdfSolidBrush(new PdfColor(247, 148, 29));
            PdfBrush grayBrush = new PdfSolidBrush(new PdfColor(170, 171, 171));

            //Create a new PDF pen
            borderPen = new PdfPen(new PdfColor(Color.FromArgb(Color.DarkGray.A, Color.DarkGray.R, Color.DarkGray.G, Color.DarkGray.B)), .3f);
            borderPen.LineCap = PdfLineCap.Square;
            transparentPen = new PdfPen(new PdfColor(Color.FromArgb(Color.Transparent.A, Color.Transparent.R, Color.Transparent.G, Color.Transparent.B)), .3f);
            transparentPen.LineCap = PdfLineCap.Square;
            #endregion

            //Create a new PDF document
            PdfDocument document = new PdfDocument();
            //Set the margins
            document.PageSettings.Margins.All = 0;

            #region Footer
            //Create a new footer template
            PdfPageTemplateElement footer = new PdfPageTemplateElement(new RectangleF(new PointF(0, document.PageSettings.Height - 40), new SizeF(document.PageSettings.Width, 40)));
            footer.Graphics.DrawRectangle(new PdfSolidBrush(new PdfColor(77, 77, 77)), footer.Bounds);
            footer.Graphics.DrawString("//www.syncfusion.com", font, grayBrush, new PointF(footer.Width - (footer.Width / 4), 15));
            footer.Graphics.DrawString("Copyright � 2001 - 2015 Syncfusion Inc.", font, grayBrush, new PointF(0, 15));
            //Add the footer template at the bottom of the page
            document.Template.Bottom = footer;
            #endregion

            //Add a new PDF page
            PdfPage page = document.Pages.Add();

            //Draw the text to the PDF page
            page.Graphics.DrawRectangle(orangeBrush, new RectangleF(PointF.Empty, new SizeF(page.Graphics.ClientSize.Width, margin)));
            page.Graphics.DrawString("Essential Studio Reporting Edition", bigFont, PdfBrushes.White, new PointF(10, 10));

            #region PdfLightTable
            //Create a PDF light table
            PdfLightTable pdfLightTable = new PdfLightTable();
            pdfLightTable.DataSource = GetProductsDataSet();
            pdfLightTable.Style.DefaultStyle.BorderPen = transparentPen;

            for (int i = 0; i < pdfLightTable.Columns.Count; i++)
            {
                if (i % 2 == 0)
                    pdfLightTable.Columns[i].Width = 16.5f;
            }

            pdfLightTable.Style.CellSpacing = cellSpacing;
            pdfLightTable.BeginRowLayout += new BeginRowLayoutEventHandler(pdfLightTable_BeginRowLayout);
            pdfLightTable.BeginCellLayout += new BeginCellLayoutEventHandler(pdfLightTable_BeginCellLayout);
            pdfLightTable.Style.DefaultStyle.Font = font;
            PdfLayoutResult result = pdfLightTable.Draw(page, new RectangleF(new PointF(margin, 70), new SizeF(page.Graphics.ClientSize.Width - (2 * margin), page.Graphics.ClientSize.Height - margin)));

            # endregion

            page.Graphics.DrawString("What You Get with Syncfusion", bigFont, orangeBrush, new PointF(margin, result.Bounds.Bottom + 50));

            #region PdfGrid
            //Create a new PDF grid
            PdfGrid pdfGrid = new PdfGrid();
            pdfGrid.DataSource = GetReportsDataSet();
            pdfGrid.Headers.Clear();
            pdfGrid.Columns[0].Width = 80;
            pdfGrid.Style.Font = font;
            pdfGrid.Style.CellSpacing = 15f;

            for (int i = 0; i < pdfGrid.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    PdfGridCell cell = pdfGrid.Rows[i].Cells[0];
                    cell.RowSpan = 2;                    
                   
                    cell.Value = "";

                    cell = pdfGrid.Rows[i].Cells[1];
                    cell.Style.Font = bigFont;
                }
                for (int j = 0; j < pdfGrid.Columns.Count; j++)
                {
                    pdfGrid.Rows[i].Cells[j].Style.Borders.All = transparentPen;
                }
            }
            //Create a PDF grid layout format
            PdfGridLayoutFormat gridLayoutFormat = new PdfGridLayoutFormat();
            //Set pagination
            gridLayoutFormat.Layout = PdfLayoutType.Paginate;

            //Draw the grid to the PDF document
            pdfGrid.Draw(page, new RectangleF(new PointF(margin, result.Bounds.Bottom + 75), new SizeF(page.Graphics.ClientSize.Width - (2 * margin), page.Graphics.ClientSize.Height - margin)), gridLayoutFormat);

            # endregion
            MemoryStream stream = new MemoryStream();

            //Save the PDF document 
            document.Save(stream);

            //Close the PDF document
            document.Close(true);

            stream.Position = 0;
            return stream;
        }
        #region PdfLightTable Events

        void pdfLightTable_BeginRowLayout(object sender, BeginRowLayoutEventArgs args)
        {
            if (args.RowIndex % 2 == 0)
                args.MinimalHeight = 20;
            else
                args.MinimalHeight = 30;
        }

        void pdfLightTable_BeginCellLayout(object sender, BeginCellLayoutEventArgs args)
        {
            if (args.RowIndex > -1 && args.CellIndex > -1)
            {
                float x = args.Bounds.X;
                float y = args.Bounds.Y;
                float width = args.Bounds.Right;
                float height = args.Bounds.Bottom;

                if (args.Value == "dummy")
                {
                    args.Skip = true;
                    return;
                }

                if (args.CellIndex % 2 == 0 && !string.IsNullOrEmpty(args.Value))
                {
                    args.Skip = true;
                }

                if (args.Value.Contains("http"))
                {
                    args.Skip = true;

                    // Create the Text Web Link
                    PdfTextWebLink textLink = new PdfTextWebLink();
                    textLink.Url = args.Value;
                    textLink.Text = "Know more...";
                    textLink.Brush = PdfBrushes.Black;
                    textLink.Font = smallFont;
                    textLink.DrawTextWebLink(args.Graphics, new PointF(args.Bounds.X + 2 * args.Bounds.Width / 3, args.Bounds.Y));
                }

                # region Draw manual borders
                if (args.RowIndex % 3 == 0)//top
                {
                    if (args.CellIndex % 2 == 0)
                        width += cellSpacing;
                    args.Graphics.DrawLine(borderPen, new PointF(x, y), new PointF(width, y));
                }
                else if (args.RowIndex % 3 == 2)//bottom
                {
                    if (args.CellIndex % 2 == 0)
                        width += cellSpacing;
                    args.Graphics.DrawLine(borderPen, new PointF(x, height), new PointF(width, height));
                }

                if (args.CellIndex % 2 == 0)//left
                {
                    if (args.RowIndex % 3 != 2)
                        height += cellSpacing;
                    args.Graphics.DrawLine(borderPen, new PointF(x, y), new PointF(x, height));
                }
                else if (args.CellIndex % 2 != 0)//right
                {
                    if (args.RowIndex % 3 != 2)
                        height += cellSpacing;
                    args.Graphics.DrawLine(borderPen, new PointF(width, y), new PointF(width, height));
                }
                # endregion
            }
        }
        # endregion  

        internal sealed class DataProvider
        {
            public static IEnumerable<Products> GetProducts(string webRootPath)
            {
                string dataPath = webRootPath + @"/PDF/";
                //Read the file
                FileStream xmlStream = new FileStream(dataPath + "Products.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                using (StreamReader reader = new StreamReader(xmlStream, true))
                {
                    return XElement.Parse(reader.ReadToEnd())
                        .Elements("Products")
                        .Select(c => new Products
                        {
                            Image1 = c.Element("Image1").Value,
                            Description1 = c.Element("Description1").Value,
                            Image2 = c.Element("Image2").Value,
                            Description2 = c.Element("Description2").Value,
                            Image3 = (c.Element("Image3") != null) ? c.Element("Image3").Value : "dummy",
                            Description3 = (c.Element("Description3") != null) ? c.Element("Description3").Value : "dummy",
                        });
                }
            }

            public static IEnumerable<Report> GetReport(string webRootPath)
            {
                string dataPath = webRootPath + @"/PDF/";
                //Read the file
                FileStream xmlStream = new FileStream(dataPath + "Report.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                using (StreamReader reader = new StreamReader(xmlStream, true))
                {
                    return XElement.Parse(reader.ReadToEnd())
                        .Elements("Report")
                        .Select(c => new Report
                        {
                            Image = c.Element("Image").Value,
                            Description = c.Element("Description").Value,
                        });
                }
            }
        }

        #region Products
        public class Products
        {
            public string Image1 { get; set; }
            public string Description1 { get; set; }
            public string Image2 { get; set; }
            public string Description2 { get; set; }
            public string Image3 { get; set; }
            public string Description3 { get; set; }
        }
        #endregion
        /// <summary>
        /// Returns dataset.
        /// </summary>
        private DataSet GetProductsDataSet()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(fileDataValue["products.xml"]);
            return dataSet;
        }
        /// <summary>
        /// Returns dataset.
        /// </summary>
        private DataSet GetReportsDataSet()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(fileDataValue["report.xml"]);
            return dataSet;
        }
        #region Report
        public class Report
        {
            public string Image { get; set; }
            public string Description { get; set; }
        }
        #endregion
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
