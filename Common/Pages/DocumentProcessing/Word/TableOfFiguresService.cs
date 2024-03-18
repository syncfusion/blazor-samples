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
using System.Data;
using System.IO;
using System.Collections.Generic;
using Syncfusion.Office;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class TableOfFiguresService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public TableOfFiguresService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Generate update table of contents functionality of Essential DocIO
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream TableOfFigures(string documentType, string button, bool ExcludeLabelsAndNumbers)
        {
            if (button == "View Template")
            {
                return fileDataValue["table-of-figures-input.docx"];
            }
            //Open an existing word document.
            using (WordDocument document = new WordDocument(fileDataValue["table-of-figures-input.docx"], FormatType.Docx))
            {

                #region Add Table of Figures
                //Create a new paragraph.
                WParagraph paragraph = new WParagraph(document);
                paragraph.AppendText("List of Figures");
                //Apply Heading1 style for paragraph.
                paragraph.ApplyStyle(BuiltinStyle.Heading1);
                //Insert the paragraph. 
                document.LastSection.Body.ChildEntities.Insert(0, paragraph);

                //Create new paragraph and append TOC.
                paragraph = new WParagraph(document);
                TableOfContent tableOfContent = paragraph.AppendTOC(1, 3);
                //Disable a flag to exclude heading style paragraphs in TOC entries.
                tableOfContent.UseHeadingStyles = false;
                //Set the name of SEQ field identifier for table of figures.
                tableOfContent.TableOfFiguresLabel = "Figure";
                if (ExcludeLabelsAndNumbers)
                    //Disable the flag, to exclude caption's label and number in TOC entries.
                    tableOfContent.IncludeCaptionLabelsAndNumbers = false;

                //Insert the paragraph to the text body.
                document.LastSection.Body.ChildEntities.Insert(1, paragraph);
                #endregion

                #region Add caption for pictures
                //Find all pictures from the document.
                List<Entity> pictures = document.FindAllItemsByProperty(EntityType.Picture, null, null);
                // Iterate each picture and add caption.
                foreach (WPicture picture in pictures)
                {
                    //Set alternate text as caption for picture.
                    WParagraph captionPara = picture.AddCaption("Figure", CaptionNumberingFormat.Number, CaptionPosition.AfterImage) as WParagraph;
                    captionPara.AppendText(" " + picture.AlternativeText);
                    //Apply formatting to the caption.
                    captionPara.ApplyStyle(BuiltinStyle.Caption);
                    captionPara.ParagraphFormat.BeforeSpacing = 8;
                    captionPara.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
                }
                #endregion


                #region Add Table of Tables
                // Create a new paragraph.
                paragraph = new WParagraph(document);
                paragraph.AppendText("List of Tables");
                // Apply Heading1 style for paragraph.
                paragraph.ApplyStyle(BuiltinStyle.Heading1);
                // Insert the paragraph.
                document.LastSection.Body.ChildEntities.Insert(2, paragraph);

                //Create a new paragraph and append TOC.
                paragraph = new WParagraph(document);
                tableOfContent = paragraph.AppendTOC(1, 3);
                //Disable a flag to exclude heading style paragraphs in TOC entries.
                tableOfContent.UseHeadingStyles = false;
                //Set the name of SEQ field identifier for table of tables.
                tableOfContent.TableOfFiguresLabel = "Table";
                if (ExcludeLabelsAndNumbers)
                    //Disable the flag, to exclude caption's label and number in TOC entries.
                    tableOfContent.IncludeCaptionLabelsAndNumbers = false;
                // Insert the paragraph to the text body.
                document.LastSection.Body.ChildEntities.Insert(3, paragraph);
                #endregion

                #region Add caption for tables
                // Find all tables from the document.
                List<Entity> tables = document.FindAllItemsByProperty(EntityType.Table, null, null);
                //Iterate each table and add caption.
                foreach (WTable table in tables)
                {
                    //Gets the table index.
                    int tableIndex = table.OwnerTextBody.ChildEntities.IndexOf(table);
                    //Create a new paragraph and appends the sequence field to use as a caption.
                    WParagraph captionPara = new WParagraph(document);
                    captionPara.AppendText("Table ");
                    captionPara.AppendField("Table", FieldType.FieldSequence);
                    //Set alternate text as caption for table.
                    captionPara.AppendText(" " + table.Description);
                    // Apply formatting to the paragraph.
                    captionPara.ApplyStyle(BuiltinStyle.Caption);
                    captionPara.ParagraphFormat.BeforeSpacing = 8;
                    captionPara.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
                    //Insert the paragraph next to the table.
                    table.OwnerTextBody.ChildEntities.Insert(tableIndex + 1, captionPara);
                }
                #endregion

                #region Update
                //Update all document fields to update SEQ fields.
                document.UpdateDocumentFields();
                //Update the table of contents.
                document.UpdateTableOfContents();
                #endregion

                FormatType formatType = FormatType.Docx;
                //Save as .xml format.
                if (documentType == "WordML")
                    formatType = FormatType.WordML;
                else if (documentType == "DOC")
                    formatType = FormatType.Doc;

                /*Server:Block*/
                #region Document SaveOption
#if !(WASM) && !WEBAPP
                //Save as .pdf format.
                if (documentType == "PDF")
                {
                    DocIORenderer render = new DocIORenderer();
                    // Converts Word document into PDF document.
                    PdfDocument pdf = render.ConvertToPDF(document);
                    //Save the document as a stream and return the stream.
                    using (MemoryStream stream = new MemoryStream())
                    {
                        //Save the created PDF document to MemoryStream.
                        pdf.Save(stream);
                        render.Dispose();
                        pdf.Close();
                        stream.Position = 0;
                        return stream;
                    }
                }
                else
                {
#endif
                    /*End:Server*/
                    using (MemoryStream stream = new MemoryStream())
                    {
                        //Save the created Word document to MemoryStream.
                        document.Save(stream, formatType);
                        stream.Position = 0;
                        return stream;
                    }
                    /*Server:Block*/
#if !(WASM) && !WEBAPP
                }
#endif
                /*End:Server*/
                #endregion Document SaveOption

            }
        }
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