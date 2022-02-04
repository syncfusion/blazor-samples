#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Microsoft.AspNetCore.Hosting;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace BlazorDemos.Data.FileFormats.DocIO
{
    public class EncryptDecryptService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public EncryptDecryptService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
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
                string basePath = @"wwwroot/";
                string dataPath = basePath + @"data/docio/security-settings.docx";
                FileStream fileStream = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                document = new WordDocument();
                //Open an existing template document.
                document.Open(fileStream, FormatType.Docx, "syncfusion");
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
            //Save the document as a stream and retrun the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created Word document to MemoryStream
                document.Save(stream, formatType);
                document.Close();
                stream.Position = 0;
                return stream;
            }
        }

    }
}