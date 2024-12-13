#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.IO;
using System.Collections.Generic;


namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class HeaderandFooterService
    {

        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public HeaderandFooterService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Create a simple Word document
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream HeaderandFooter(string documentType)
        {
            // Creating a new document.
            WordDocument doc = new WordDocument();
            // Add a new section to the document.
            IWSection section1 = doc.AddSection();
            // Set the header/footer setup.
            section1.PageSetup.DifferentFirstPage = true;
            // Inserting Header Footer to first page
            InsertFirstPageHeaderFooter(doc, section1);
            // Inserting Header Footer to all pages
            InsertPageHeaderFooter(doc, section1);

            // Add text to the document body section.
            IWParagraph par;
            par = section1.AddParagraph();

            //Insert Text into the word Document.
            StreamReader reader = new StreamReader(fileDataValue["win-faq.txt"], System.Text.Encoding.ASCII);
            string text = reader.ReadToEnd();
            par.AppendText(text);
            reader.Dispose();
            reader = null;

            FormatType formatType = FormatType.Docx;            
            //Save as .doc format
            if (documentType == "WordDoc")            
                formatType = FormatType.Doc;                
            //Save as .xml format
            else if (documentType == "WordML")
                formatType = FormatType.WordML;            
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created Word document to MemoryStream
                doc.Save(stream, formatType);
                doc.Close();
                stream.Position = 0;
                return stream;
            }
        }
        #region InsertFirstPageHeaderFooter
        private void InsertFirstPageHeaderFooter(WordDocument doc, IWSection section)
        {
            // Add a new paragraph for header to the document.
            IWParagraph headerPar = new WParagraph(doc);

            // Add a new table to the header.
            IWTable table = section.HeadersFooters.FirstPageHeader.AddTable();

            RowFormat format = new RowFormat();

            // Setting cleared table border style.
            format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Cleared;

            // Inserting table with a row and two columns.
            table.ResetCells(1, 2, format, 265);

            // Inserting logo image to the table first cell.
            headerPar = table[0, 0].AddParagraph() as WParagraph;
            headerPar.AppendPicture(fileDataValue["northwind-logo.png"]);
            //Set Image size
            (headerPar.Items[0] as WPicture).Width = 232.5f;
            (headerPar.Items[0] as WPicture).Height = 54.75f;
            // Inserting text to the table second cell.
            headerPar = table[0, 1].AddParagraph() as WParagraph;
            IWTextRange txt = headerPar.AppendText("Company Headquarters,\n2501 Aerial Center Parkway,\nSuite 110, Morrisville, NC 27560,\nTEL 1-888-936-8638.");
            txt.CharacterFormat.FontSize = 12;
            txt.CharacterFormat.CharacterSpacing = 1.7f;
            headerPar.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right;
            // Add a new paragraph to the header with address text.
            headerPar = new WParagraph(doc);
            headerPar.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            txt = headerPar.AppendText("\nFirst Page Header");
            txt.CharacterFormat.CharacterSpacing = 1.7f;
            section.HeadersFooters.FirstPageHeader.Paragraphs.Add(headerPar);

            // Add a footer paragraph text to the document.
            WParagraph footerPar = new WParagraph(doc);
            footerPar.ParagraphFormat.Tabs.AddTab(523f, TabJustification.Right, TabLeader.NoLeader);
            // Add text.
            footerPar.AppendText("Copyright Northwind Inc. 2001 - 2017");
            // Add page and Number of pages field to the document.
            footerPar.AppendText("\tFirst Page ");
            footerPar.AppendField("Page", FieldType.FieldPage);
            section.HeadersFooters.FirstPageFooter.Paragraphs.Add(footerPar);
            #region Page Number Settings
            section.PageSetup.RestartPageNumbering = true;
            section.PageSetup.PageStartingNumber = 1;
            section.PageSetup.PageNumberStyle = PageNumberStyle.Arabic;
            #endregion Page Number Settings
        }
        #endregion InsertFirstPageHeaderFooter

        #region InsertPageHeaderFooter
        private void InsertPageHeaderFooter(WordDocument doc, IWSection section1)
        {
            // Add a new paragraph for header to the document.
            IWParagraph headerPar = new WParagraph(doc);

            // Add a new table to the header
            IWTable table = section1.HeadersFooters.Header.AddTable();

            RowFormat format = new RowFormat();

            // Setting Single table border style.
            format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;

            // Inserting table with a row and two columns.
            table.ResetCells(1, 2, format, 265);

            // Inserting logo image to the table first cell.
            headerPar = table[0, 0].AddParagraph() as WParagraph;
            headerPar.AppendPicture(fileDataValue["northwind-logo.png"]);
            //Set Image size.
            (headerPar.Items[0] as WPicture).Width = 232.5f;
            (headerPar.Items[0] as WPicture).Height = 54.75f;
            // Inserting text to the table second cell.
            headerPar = table[0, 1].AddParagraph() as WParagraph;
            IWTextRange txt = headerPar.AppendText("Company Headquarters,\n2501 Aerial Center Parkway,\nSuite 110, Morrisville, NC 27560,\nTEL 1-888-936-8638.");
            txt.CharacterFormat.FontSize = 12;
            txt.CharacterFormat.CharacterSpacing = 1.7f;
            headerPar.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right;

            // Add a footer paragraph text to the document.
            WParagraph footerPar = new WParagraph(doc);
            footerPar.ParagraphFormat.Tabs.AddTab(523f, TabJustification.Right, TabLeader.NoLeader);
            // Add text.
            footerPar.AppendText("Copyright Northwind Inc. 2001 - 2017");
            // Add page and Number of pages field to the document.
            footerPar.AppendText("\tPage ");
            IWField ff = footerPar.AppendField("Page", FieldType.FieldPage);

            section1.HeadersFooters.Footer.Paragraphs.Add(footerPar);

            #region Page Number Settings
            section1.PageSetup.RestartPageNumbering = true;
            section1.PageSetup.PageStartingNumber = 1;
            section1.PageSetup.PageNumberStyle = PageNumberStyle.Arabic;
            #endregion Page Number Settings
        }
        #endregion InsertPageHeaderFooter
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