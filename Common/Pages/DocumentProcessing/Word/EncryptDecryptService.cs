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
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class EncryptDecryptService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public EncryptDecryptService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Encrypt and decrypt in the Word document
        /// </summary>
        /// <returns>Return the resultant Word document as stream</returns>
        public MemoryStream EncryptDecryptDocument(string Group)
        {
            WordDocument document = null;
            if (Group == "Encrypt")
            {
                document = new WordDocument();

                document.EnsureMinimal();

                // Getting last section of the document.
                IWSection section = document.LastSection;

                // Adding a paragraph to the section.
                IWParagraph paragraph = section.AddParagraph();

                // Writing text
                IWTextRange text = paragraph.AppendText("This document was encrypted with password");
                text.CharacterFormat.FontSize = 16f;
                text.CharacterFormat.FontName = "Bitstream Vera Serif";

                // Encrypt the document by giving password
                document.EncryptDocument("syncfusion");
            }
            else
            {

                document = new WordDocument();
                //Open an existing template document.
                document.Open(fileDataValue["security-settings.docx"], FormatType.Docx, "syncfusion");
                // Getting last section of the document.
                IWSection section = document.LastSection;

                // Adding a paragraph to the section.
                IWParagraph paragraph = section.AddParagraph();

                // Writing text
                IWTextRange text = paragraph.AppendText("\nDemo For Document Decryption with Essential DocIO");
                text.CharacterFormat.FontSize = 16f;
                text.CharacterFormat.FontName = "Bitstream Vera Serif";

                text = paragraph.AppendText("\nThis document is Decrypted");
                text.CharacterFormat.FontSize = 16f;
                text.CharacterFormat.FontName = "Bitstream Vera Serif";
            }

            FormatType formatType = FormatType.Docx;
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created Word document to MemoryStream
                document.Save(stream, formatType);
                document.Close();
                stream.Position = 0;
                return stream;
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