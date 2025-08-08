#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion


using Syncfusion.Blazor.Grids;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class DocumentProtectionService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public DocumentProtectionService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Encrypt and decrypt in the Word document
        /// </summary>
        /// <returns>Return the resultant Word document as stream</returns>
        public MemoryStream DocumentProtection(string Protection_Type, string Password1, bool EditableRangeOption)
        {
            // return View();
            WordDocument document;
            ProtectionType protectionType;
            //Loads the template document.
            if (Protection_Type == "AllowOnlyFormFields")
            {
                document = new WordDocument(fileDataValue["template-form-fields.docx"], FormatType.Docx);
                // Sets the protection type as allow only Form Fields.
                protectionType = ProtectionType.AllowOnlyFormFields;
            }
            else if (Protection_Type == "AllowOnlyComments")
            {
                document = new WordDocument(fileDataValue["template-comments.docx"], FormatType.Docx);
                // If the "Make part of the document editable for everyone" checkbox is checked,
                // add editable ranges to allow unrestricted editing in specific sections.
                if (EditableRangeOption)
                    AddEditableRange(document);
                // Sets the protection type as allow only Comments.
                protectionType = ProtectionType.AllowOnlyComments;
            }
            else if (Protection_Type == "AllowOnlyRevisions")
            {
                document = new WordDocument(fileDataValue["template-revisions.docx"], FormatType.Docx);
                // Enables track changes in the document.
                document.TrackChanges = true;
                // Sets the protection type as allow only Revisions.
                protectionType = ProtectionType.AllowOnlyRevisions;
            }
            else if (Protection_Type == "AllowOnlyReading")
            {
                document = new WordDocument(fileDataValue["template-reading.docx"], FormatType.Docx);
                // If the "Make part of the document editable for everyone" checkbox is checked,
                // add editable ranges to allow unrestricted editing in specific sections.
                if (EditableRangeOption)
                    AddEditableRange(document);
                // Sets the protection type as allow only Reading.
                protectionType = ProtectionType.AllowOnlyReading;
            }
            else
            {
                document = new WordDocument(fileDataValue["template-form-fields.docx"], FormatType.Docx);
                // Sets the protection type as allow only Form Fields.
                protectionType = ProtectionType.AllowOnlyFormFields;
            }

            // Enforces protection of the document.
            if (string.IsNullOrEmpty(Password1))
                document.Protect(protectionType);
            else
                document.Protect(protectionType, Password1);

            FormatType type = FormatType.Docx;

            using (MemoryStream ms = new MemoryStream())
            {
                document.Save(ms, type);
                document.Close();
                ms.Position = 0;
                return ms;
            }
        }

        private void AddEditableRange(WordDocument document)
        {
            // Access the paragraph
            WParagraph paragraph = document.Sections[0].Body.ChildEntities[5] as WParagraph;
            // Create a new editable range start
            EditableRangeStart editableRangeStart = new EditableRangeStart(document);
            // Insert the editable range start at the beginning of the selected paragraph
            paragraph.ChildEntities.Insert(0, editableRangeStart);
            // Set the editor group for the editable range to allow everyone to edit
            editableRangeStart.EditorGroup = EditorType.Everyone;
            // Append an editable range end to close the editable region
            paragraph.AppendEditableRangeEnd();

            // Access the first table in the first section of the document
            WTable table = document.Sections[0].Tables[0] as WTable;
            // Access the paragraph in the third row and third column of the table
            paragraph = table[2, 2].ChildEntities[0] as WParagraph;
            // Create a new editable range start for the table cell paragraph
            editableRangeStart = new EditableRangeStart(document);
            // Insert the editable range start at the beginning of the paragraph
            paragraph.ChildEntities.Insert(0, editableRangeStart);
            // Set the editor group for the editable range to allow everyone to edit
            editableRangeStart.EditorGroup = EditorType.Everyone;
            // Apply editable range to second column only
            editableRangeStart.FirstColumn = 1;
            editableRangeStart.LastColumn = 1;
            // Access the paragraph
            paragraph = table[5, 2].ChildEntities[0] as WParagraph;
            // Append an editable range end to close the editable region
            paragraph.AppendEditableRangeEnd();
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