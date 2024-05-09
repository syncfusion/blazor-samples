#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Drawing;
using System.IO;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class BookmarksService
    {
        public MemoryStream Bookmarks(string documentType)
        {
            #region BookmarkCreation
            // Creating a new document.
            WordDocument document = new WordDocument();
            // Adding a section to the document.
            IWSection section = document.AddSection();
            // Adding a new paragraph to the section.
            IWParagraph paragraph = section.AddParagraph();
            // Writing text
            paragraph.AppendText("This document demonstrates Essential DocIO's Bookmark functionality.").CharacterFormat.FontSize = 14f;
            // Adding paragraph to the section.
            section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.AppendText("1. Inserting Bookmark Text").CharacterFormat.FontSize = 12f;

            // Adding paragraph to the section.
            section.AddParagraph();
            paragraph = section.AddParagraph();

            // BookmarkStart.
            paragraph.AppendBookmarkStart("Bookmark");
            // Write bookmark
            paragraph.AppendText("Bookmark Text");
            // BookmarkEnd.
            paragraph.AppendBookmarkEnd("Bookmark");

            // Adding paragraph to the section.
            section.AddParagraph();
            paragraph = section.AddParagraph();
            // Indicating hidden bookmark text start.
            paragraph.AppendBookmarkStart("_HiddenText");
            // Writing bookmark text
            paragraph.AppendText("2. Hidden Bookmark Text").CharacterFormat.Font = new Syncfusion.Drawing.Font("Comic Sans MS", 10);
            // Indicating hidden bookmark text end.
            paragraph.AppendBookmarkEnd("_HiddenText");

            section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.AppendText("3. Nested Bookmarks").CharacterFormat.FontSize = 12f;

            // Writing nested bookmarks
            section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.AppendBookmarkStart("Main");
            paragraph.AppendText(" Main data ");
            paragraph.AppendBookmarkStart("Nested");
            paragraph.AppendText(" Nested data ");
            paragraph.AppendBookmarkStart("NestedNested");
            paragraph.AppendText(" Nested Nested ");
            paragraph.AppendBookmarkEnd("NestedNested");
            paragraph.AppendText(" data Nested ");
            paragraph.AppendBookmarkEnd("Nested");
            paragraph.AppendText(" Data Main ");
            paragraph.AppendBookmarkEnd("Main");
            #endregion BookmarkCreation
            FormatType type = FormatType.Docx;
            #region Document SaveOption
            //Save as .doc format
            if (documentType == "WordDoc")
            {
                type = FormatType.Doc;
            }
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
    }
}