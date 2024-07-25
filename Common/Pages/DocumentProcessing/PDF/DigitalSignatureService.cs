
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
using Syncfusion.Pdf.Lists;
using System.IO;
using Syncfusion.Pdf.Security;
using Syncfusion.Pdf.Parsing;
using System.Collections.Generic;

namespace BlazorDemos.Data.FileFormats.PDF
{
    public class DigitalSignatureService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public DigitalSignatureService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream DigitalSignaturePDF(string RadioButtonList2, string NewPDF, string Cryptographic, string Digest_Algorithm)
        {
            MemoryStream stream_Empty = new MemoryStream();

           
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.Pages.Add();
            PdfSolidBrush brush = new PdfSolidBrush(Color.Black);
            PdfPen pen = new PdfPen(brush, 0.2f);
            PdfFont font = new PdfStandardFont(PdfFontFamily.Courier, 12, PdfFontStyle.Regular);
            PdfCertificate pdfCert = new PdfCertificate(fileDataValue["pdf.pfx"], "password123");
            PdfSignature signature = new PdfSignature(page, pdfCert, "Signature");
            
            PdfBitmap bmp = new PdfBitmap(fileDataValue["logo.png"]);
            signature.Bounds = new RectangleF(new PointF(20, 20), new SizeF(500, 170));
            signature.ContactInfo = "johndoe@owned.us";
            signature.LocationInfo = "Honolulu, Hawaii";
            signature.Reason = "I am author of this document.";
            SetCryptographicStandard(Cryptographic, signature);
            SetDigest_Algorithm(Digest_Algorithm, signature);
            if (RadioButtonList2 == "Standard")
                signature.Certificated = false;
            else
                signature.Certificated = true;
            PdfGraphics graphics = signature.Appearance.Normal.Graphics;

            string validto = " Valid To: " + signature.Certificate.ValidTo.ToString();
            string validfrom = " Valid From: " + signature.Certificate.ValidFrom.ToString();

            graphics.DrawImage(bmp, 0, 0);

            doc.Pages[0].Graphics.DrawString(validfrom, font, pen, brush, 20, 90);
            doc.Pages[0].Graphics.DrawString(validto, font, pen, brush, 20, 110);

            doc.Pages[0].Graphics.DrawString(" Protected Document. Digitally signed Document.", font, pen, brush, 20, 130);
            doc.Pages[0].Graphics.DrawString(" * To validate Signature click on the signature on this page \n * To check Document Status \n click document status icon on the bottom left of the acrobat reader.", font, pen, brush, 20, 150);

            // Save the pdf document to the Stream.
            MemoryStream stream = new MemoryStream();

            doc.Save(stream);

            //Close document
            doc.Close(true);

            stream.Position = 0;
            return stream;

        }

        private void SetCryptographicStandard(string cryptographic, PdfSignature signature)
        {
            if (cryptographic != null)
            {
                if (cryptographic == "CAdES")
                    signature.Settings.CryptographicStandard = CryptographicStandard.CADES;
                else
                    signature.Settings.CryptographicStandard = CryptographicStandard.CMS;
            }
        }

        private void SetDigest_Algorithm(string digest_Algorithm, PdfSignature signature)
        {
            if (digest_Algorithm != null)
            {
                switch (digest_Algorithm)
                {
                    case "SHA1":
                        signature.Settings.DigestAlgorithm = DigestAlgorithm.SHA1;
                        break;
                    case "SHA384":
                        signature.Settings.DigestAlgorithm = DigestAlgorithm.SHA384;
                        break;
                    case "SHA512":
                        signature.Settings.DigestAlgorithm = DigestAlgorithm.SHA512;
                        break;
                    case "RIPEMD160":
                        signature.Settings.DigestAlgorithm = DigestAlgorithm.RIPEMD160;
                        break;
                    default:
                        signature.Settings.DigestAlgorithm = DigestAlgorithm.SHA256;
                        break;
                }
            }
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
    
