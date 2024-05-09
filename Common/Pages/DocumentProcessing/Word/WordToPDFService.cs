#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIORenderer;
using Syncfusion.Pdf;
using Syncfusion.Drawing;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Xml;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class WordToPDFService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public WordToPDFService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Generate a letter using Mail merge functionality of Essential DocIO
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream WordToPDF(string button, bool preserveFormFields, bool preserveWordHeadingsToPDFBookmarks, bool showRevisions, bool showComments)
        {
            if (button == "View Template")
            {
                return fileDataValue["doc-to-pdf.docx"];
            }
            // Load the template.
            WordDocument document = new WordDocument(fileDataValue["doc-to-pdf.docx"], FormatType.Doc);
            DocIORenderer render = new DocIORenderer();
            if (preserveFormFields)
                render.Settings.PreserveFormFields = true;
            render.Settings.ExportBookmarks = preserveWordHeadingsToPDFBookmarks ? Syncfusion.DocIO.ExportBookmarkType.Headings : Syncfusion.DocIO.ExportBookmarkType.Bookmarks;
            if (showRevisions)
                //Enables to show the revision marks in the generated PDF for tracked changes or revisions in the Word document.
                document.RevisionOptions.ShowMarkup = RevisionType.Deletions | RevisionType.Formatting | RevisionType.Insertions;
            if (showComments)
            {
                //Sets ShowInBalloons to render a document comments in converted PDF document.
                document.RevisionOptions.CommentDisplayMode = CommentDisplayMode.ShowInBalloons;
                //Sets the color to be used for Comment Balloon
                document.RevisionOptions.CommentColor = RevisionColor.Blue;
            }
            // Converts Word document into PDF document.
            PdfDocument pdf = render.ConvertToPDF(document);
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created PDF document to MemoryStream
                pdf.Save(stream);
                render.Dispose();
                pdf.Close();
                document.Close();
                stream.Position = 0;
                return stream;
            }
        }
        #region HelperMethod
        /// <summary>
        /// Dispose the Dictionary
        /// </summary>
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