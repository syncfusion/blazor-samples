#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Shared;
using Microsoft.AspNetCore.Components;
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Pdf.Security;
using static System.Net.WebRequestMethods;

namespace BlazorDemos.Pages.DocumentProcessing.PDF
{
    internal class EncryptionService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public EncryptionService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        public MemoryStream EncryptPDF(string encryptionType, string encryptOptionType)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.Pages.Add();
            PdfGraphics graphics = page.Graphics;

            PdfStandardFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 14f, PdfFontStyle.Bold);
            PdfBrush brush = PdfBrushes.Black;
            PdfForm form = document.Form;

            //Document security
            PdfSecurity security = document.Security;

            //Specify key size and encryption algorithm
            if (encryptionType == "40 Bit RC4")
            {
                //use 40 bits key in RC4 mode
                security.KeySize = PdfEncryptionKeySize.Key40Bit;
            }
            else if (encryptionType == "128 Bit RC4")
            {
                //use 128 bits key in RC4 mode
                security.KeySize = PdfEncryptionKeySize.Key128Bit;
                security.Algorithm = PdfEncryptionAlgorithm.RC4;
            }
            else if (encryptionType == "128 Bit AES")
            {
                //use 128 bits key in AES mode
                security.KeySize = PdfEncryptionKeySize.Key128Bit;
                security.Algorithm = PdfEncryptionAlgorithm.AES;
            }
            else if (encryptionType == "256 Bit AES")
            {
                //use 256 bits key in AES mode
                security.KeySize = PdfEncryptionKeySize.Key256Bit;
                security.Algorithm = PdfEncryptionAlgorithm.AES;
            }
            else if (encryptionType == "256 Bit AES Revision 6")
            {
                security.KeySize = PdfEncryptionKeySize.Key256BitRevision6;
                security.Algorithm = PdfEncryptionAlgorithm.AES;
            }
            else if (encryptionType == "256 Bit AES GCM")
            {
                security.KeySize = PdfEncryptionKeySize.Key256Bit;
                security.Algorithm = PdfEncryptionAlgorithm.AESGCM;
                document.FileStructure.Version = PdfVersion.Version2_0;
            }
            //set Encryption options
            if (encryptOptionType == "Encrypt only attachments [For AES and AES-GCM only]")
            {
                PdfAttachment attachment = new PdfAttachment("adventure-work-cycle.xml", fileDataValue["adventure-work-cycle.xml"]);

                attachment.ModificationDate = DateTime.Now;

                attachment.Description = "About Syncfusion";

                attachment.MimeType = "application/txt";

                document.Attachments.Add(attachment);

                security.EncryptionOptions = PdfEncryptionOptions.EncryptOnlyAttachments;
            }

            else if (encryptOptionType == "Encrypt all contents except metadata")
                security.EncryptionOptions = PdfEncryptionOptions.EncryptAllContentsExceptMetadata;
            else
                security.EncryptionOptions = PdfEncryptionOptions.EncryptAllContents;

            security.OwnerPassword = "syncfusion";
            security.Permissions = PdfPermissionsFlags.Print | PdfPermissionsFlags.FullQualityPrint;
            security.UserPassword = "password";

            string text = "Security options:\n\n" + String.Format("KeySize: {0}\n\nEncryption Algorithm: {4}\n\nOwner Password: {1}\n\nPermissions: {2}\n\n" +
                "User Password: {3}", security.KeySize, security.OwnerPassword, security.Permissions, security.UserPassword, security.Algorithm);
            if (encryptionType == "256 Bit AES Revision 6")
            {
                text += String.Format("\n\nRevision: {0}", "Revision 6");
            }
            else if (encryptionType == "256 Bit AES")
            {
                text += String.Format("\n\nRevision: {0}", "Revision 5");
            }
            else if (encryptionType == "256 Bit AES GCM")
            {
                text += String.Format("\n\nRevision: {0}", "Revision 7");
            }
            graphics.DrawString("Document is Encrypted with following settings", font, brush, PointF.Empty);
            font = new PdfStandardFont(PdfFontFamily.TimesRoman, 11f, PdfFontStyle.Bold);
            graphics.DrawString(text, font, brush, new PointF(0, 40));

            // Save the pdf document to the Stream.
            MemoryStream stream = new MemoryStream();

            document.Save(stream);

            //Close document
            document.Close(true);

            stream.Position = 0;
            return stream;
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
