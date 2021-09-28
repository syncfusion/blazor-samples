#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
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

namespace BlazorDemos.Data.FileFormats.DocIO
{
    public class WordToPDFService
    {
        /// <summary>
        /// Generate a letter using Mail merge functionality of Essential DocIO
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream WordToPDF(string button, bool preserveStructureTags, bool preserveFormFields, bool preserveWordHeadingsToPDFBookmarks, bool showRevisions, bool showComments)
        {
            string basePath = @"wwwroot/";
            string dataPath = basePath + @"data/docio/doc-to-pdf.docx";
            FileStream fileStream = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            if (button == "View Template")
            {
                MemoryStream ms = new MemoryStream();
                fileStream.Position = 0;
                fileStream.CopyTo(ms);
                fileStream.Dispose();
                return ms;
            }
            fileStream = null;
            // Load the template.
            FileStream fileStreamPath = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            WordDocument document = new WordDocument(fileStreamPath, FormatType.Doc);
            fileStreamPath.Dispose();
            fileStreamPath = null;
            DocIORenderer render = new DocIORenderer();
            if (preserveStructureTags)
                render.Settings.AutoTag = true;
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
            //Save the document as a stream and retrun the stream
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
    }  
}