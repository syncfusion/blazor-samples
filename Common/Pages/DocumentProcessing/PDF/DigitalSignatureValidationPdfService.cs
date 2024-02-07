#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.IO;
using System.Collections.Generic;
using Syncfusion.Pdf.Parsing;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using Syncfusion.Pdf.Security;
using System;

namespace BlazorDemos.Data.FileFormats.PDF
{
    public class DigitalSignatureValidationPdfService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public DigitalSignatureValidationPdfService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public string DigitalSignatureValidation()
        {
            //Load an existing signed PDF document
            PdfLoadedDocument ldoc = new PdfLoadedDocument(fileDataValue["digitalSignature.pdf"]);

            //Get signature field.
            PdfLoadedSignatureField lSigFld = ldoc.Form.Fields[0] as PdfLoadedSignatureField;

            //X509Certificate2Collection to check the signer's identity using root certificates.
            X509CertificateCollection collection = new X509CertificateCollection();

            //Read the certificate file.
            string root = "MIIEKjCCAxKgAwIBAgIEOGPe+DANBgkqhkiG9w0BAQUFADCBtDEUMBIGA1UEChMLRW50cnVzdC5uZXQxQDA+BgNVBAsUN3d3dy5lbnRydXN0Lm5ldC9DUFNfMjA0OCBpbmNvcnAuIGJ5IHJlZi4gKGxpbWl0cyBsaWFiLikxJTAjBgNVBAsTHChjKSAxOTk5IEVudHJ1c3QubmV0IExpbWl0ZWQxMzAxBgNVBAMTKkVudHJ1c3QubmV0IENlcnRpZmljYXRpb24gQXV0aG9yaXR5ICgyMDQ4KTAeFw05OTEyMjQxNzUwNTFaFw0yOTA3MjQxNDE1MTJaMIG0MRQwEgYDVQQKEwtFbnRydXN0Lm5ldDFAMD4GA1UECxQ3d3d3LmVudHJ1c3QubmV0L0NQU18yMDQ4IGluY29ycC4gYnkgcmVmLiAobGltaXRzIGxpYWIuKTElMCMGA1UECxMcKGMpIDE5OTkgRW50cnVzdC5uZXQgTGltaXRlZDEzMDEGA1UEAxMqRW50cnVzdC5uZXQgQ2VydGlmaWNhdGlvbiBBdXRob3JpdHkgKDIwNDgpMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEArU1LqRKGsuqjIAcVFmQqK0vRvwtKTY7tgHalZ7d4QMBzQshowNtTK91euHaYNZOLGp18EzoOH1u3Hs/lJBQesYGpjX24zGtLA/ECDNyrpUAkAH90lKGdCCmziAv1h3edVc3kw37XamSrhRSGlVuXMlBvPci6Zgzj/L24ScF2iUkZ/cCovYmjZy/Gn7xxGWC4LeksyZB2ZnuU4q941mVTXTzWnLLPKQP5L6RQstRIzgUyVYr9smRMDuSYB3Xbf9+5CFVghTAp+XtIpGmG4zU/HoZdenoVve8AjhUiVBcAkCaTvA5JaJG/+EfTnZVCwQ5N328mz8MYIWJmQ3DW1cAH4QIDAQABo0IwQDAOBgNVHQ8BAf8EBAMCAQYwDwYDVR0TAQH/BAUwAwEB/zAdBgNVHQ4EFgQUVeSB0RGAvtiJuQijMfmhJAkWuXAwDQYJKoZIhvcNAQEFBQADggEBADubj1abMOdTmXx6eadNl9cZlZD7Bh/KM3xGY4+WZiT6QBshJ8rmcnPyT/4xmf3IDExoU8aAghOY+rat2l098c5u9hURlIIM7j+VrxGrD9cv3h8Dj1csHsm7mhpElesYT6YfzX1XEC+bBAlahLVu2B064dae0Wx5XnkcFMXj0EyTO2U87d89vqbllRrDtRnDvV5bu/8j72gZyxKTJ1wDLW8w0B62GqzeWvfRqqgnpv55gcR5mTNXuhKwqeBCbJPKVt7+bYQLCIt+jerXmCHG8+c8eS9enNFMFY3h7CI3zJpDC5fcgJCNs2ebb0gIFVbPv/ErfF6adulZkMV8gzURZVE=";
            byte[] pfxFile = Convert.FromBase64String(root);

            X509Certificate2 certificate = new X509Certificate2(pfxFile);

            //Add the certificate to the collection.
            collection.Add(certificate);

            string intermediate0 = "MIIFOTCCBCGgAwIBAgIMVRYVFQAAAABRzhYOMA0GCSqGSIb3DQEBCwUAMIG0MRQwEgYDVQQKEwtFbnRydXN0Lm5ldDFAMD4GA1UECxQ3d3d3LmVudHJ1c3QubmV0L0NQU18yMDQ4IGluY29ycC4gYnkgcmVmLiAobGltaXRzIGxpYWIuKTElMCMGA1UECxMcKGMpIDE5OTkgRW50cnVzdC5uZXQgTGltaXRlZDEzMDEGA1UEAxMqRW50cnVzdC5uZXQgQ2VydGlmaWNhdGlvbiBBdXRob3JpdHkgKDIwNDgpMB4XDTE2MDIyNTE4MDgxNloXDTI5MDYyNTE4MzgxNlowgbcxCzAJBgNVBAYTAlVTMRYwFAYDVQQKEw1FbnRydXN0LCBJbmMuMSgwJgYDVQQLEx9TZWUgd3d3LmVudHJ1c3QubmV0L2xlZ2FsLXRlcm1zMTkwNwYDVQQLEzAoYykgMjAxNSBFbnRydXN0LCBJbmMuIC0gZm9yIGF1dGhvcml6ZWQgdXNlIG9ubHkxKzApBgNVBAMTIkVudHJ1c3QgQ2xhc3MgMyBDbGllbnQgQ0EgLSBTSEEyNTYwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDGnEvBT0qd2X3TO1eRq83pdhUtwCAvLDGGxQk9sB+RhJhDlS7UnqraVeLgYOi7B+/Lg+0uXxny0CjtOmQ/y64wYCHmZqtYTmJndk5SjNx7mEQODi2QULUh+42xza8hByWXz7oPGEcZTnHLabj6I20aBhE1wVa6n2Ih8bDxAY9ez/EiosFCDvXNMugrJ/SSbwsVXvz6aVKwjn6ky3W5RYS1kwMLcitAs25DQqETGRhkRNSmIAlFsDpkD1b95IUojrjUOCPHLuKw+5r7GjiBkzLnLR+ujjcXzvzCFD993yTsseygqo4jBIEce68pztTn1OFm6W5k6eEFsiqRmHBY2PILAgMBAAGjggFEMIIBQDAOBgNVHQ8BAf8EBAMCAQYwNAYDVR0lBC0wKwYIKwYBBQUHAwIGCCsGAQUFBwMEBgorBgEEAYI3CgMMBglghkgBhvprKAswOwYDVR0gBDQwMjAwBgRVHSAAMCgwJgYIKwYBBQUHAgEWGmh0dHA6Ly93d3cuZW50cnVzdC5uZXQvcnBhMBIGA1UdEwEB/wQIMAYBAf8CAQAwMwYIKwYBBQUHAQEEJzAlMCMGCCsGAQUFBzABhhdodHRwOi8vb2NzcC5lbnRydXN0Lm5ldDAyBgNVHR8EKzApMCegJaAjhiFodHRwOi8vY3JsLmVudHJ1c3QubmV0LzIwNDhjYS5jcmwwHQYDVR0OBBYEFAafb06iKU4PDK4Xv7aYRu+tuDtyMB8GA1UdIwQYMBaAFFXkgdERgL7YibkIozH5oSQJFrlwMA0GCSqGSIb3DQEBCwUAA4IBAQB8eBvEzfG7ciGMiBdPtSqio/2dh+DXHDyC2Z6Vkzd305spuLwA0olAKJKZgKFM804XffTDY4zCTvY3sX9gMvHUk1utlt2Kt8KPDfFLrfxL21sNyj79WG99p7vrzVlsO+8AFZU2AdTLPLVjz9/Tmqr5RRKyq4IPZg0uaAM4+m6VIOceWnYEI2A9S+XpEHWqF9vbCevuF0iLnZalaqPdTBkfYkAuD/T6AOZabkbolo2bjssLzYsHOZExFCFu37kJZTw/JaDlC7o6A0r0QaZojaXqYM0jSfppwIWH58keRNVFyBIApO0GmIpBSieh8hZlo1X6K0yukH+M53cikOr4IS/F";
            pfxFile = Convert.FromBase64String(intermediate0);
            certificate = new X509Certificate2(pfxFile);

            //Add the certificate to the collection.
            collection.Add(certificate);
            string inermediate1 = "MIIFrzCCBJegAwIBAgIQE1SFieefXgaCeXS2kp3isDANBgkqhkiG9w0BAQsFADCBtzELMAkGA1UEBhMCVVMxFjAUBgNVBAoTDUVudHJ1c3QsIEluYy4xKDAmBgNVBAsTH1NlZSB3d3cuZW50cnVzdC5uZXQvbGVnYWwtdGVybXMxOTA3BgNVBAsTMChjKSAyMDE1IEVudHJ1c3QsIEluYy4gLSBmb3IgYXV0aG9yaXplZCB1c2Ugb25seTErMCkGA1UEAxMiRW50cnVzdCBDbGFzcyAzIENsaWVudCBDQSAtIFNIQTI1NjAeFw0yMTAyMDMxMjM0NDFaFw0yNDAxMjkxMjM0NDBaMIGmMQswCQYDVQQGEwJVUzEXMBUGA1UECBMOTm9ydGggQ2Fyb2xpbmExFDASBgNVBAcTC01vcnJpc3ZpbGxlMRgwFgYDVQQKEw9TeW5jZnVzaW9uLCBJbmMxETAPBgNVBAsTCEJvbGRTaWduMRgwFgYDVQQDEw9TeW5jZnVzaW9uLCBJbmMxITAfBgkqhkiG9w0BCQEWEmFkbWluQGJvbGRzaWduLmNvbTCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBAMTBnBrPMciFhOtAlViXNGEKjx3sKF66KFX1b1LK4LuqCz4EOLdqbRaGBHFW57D6E1D+1HdCQElQVH6PFKEkDYWsJ9eOtQKr8pjuIwr3T4o2btuvKTBpiDSOSydGh6E0xBxPATjtMptHNK4sYxgMIqjHUO8kXFNfVWkXC8g1u243t6S43Y+0ZkZ+kYcXG4ai4lnxzQfvm8r9hbP+bLZZs0qmEQI84SLmMFK/ComhXf5lioFDwe/dUH9acAsolbbA+LqhUckvwelqKrflrrdeZhenOKPzK5no8PVeztD0tHPjwnPtNJeErOMQiDdpnTvGkAzFQXSQVzBeTaBLbjs+yvECAwEAAaOCAcQwggHAMAwGA1UdEwEB/wQCMAAwHQYDVR0OBBYEFDqFrxr3A/zkFOnKea9cw6ZX8N9YMB8GA1UdIwQYMBaAFAafb06iKU4PDK4Xv7aYRu+tuDtyMGcGCCsGAQUFBwEBBFswWTAjBggrBgEFBQcwAYYXaHR0cDovL29jc3AuZW50cnVzdC5uZXQwMgYIKwYBBQUHMAKGJmh0dHA6Ly9haWEuZW50cnVzdC5uZXQvY2xhc3MzLTIwNDguY2VyMDcGA1UdHwQwMC4wLKAqoCiGJmh0dHA6Ly9jcmwuZW50cnVzdC5uZXQvY2xhc3MzLXNoYTIuY3JsMA4GA1UdDwEB/wQEAwIGwDAgBgNVHSUEGTAXBglghkgBhvprKAsGCisGAQQBgjcKAwwwQwYKKoZIhvcvAQEJAQQ1MDMCAQGGLmh0dHA6Ly90aW1lc3RhbXAuZW50cnVzdC5uZXQvVFNTL1JGQzMxNjFzaGEyVFMwEwYKKoZIhvcvAQEJAgQFMAMCAQEwQgYDVR0gBDswOTA3BgpghkgBhvpsCgEGMCkwJwYIKwYBBQUHAgEWG2h0dHBzOi8vd3d3LmVudHJ1c3QubmV0L3JwYTANBgkqhkiG9w0BAQsFAAOCAQEAe2nzeGxQRXvhWglUdioAzGulNqy4RhKCXuQ8KH00gXuj+AcYNy19ROsT7kXRWq7hX7fIoR1VveyFNN+rOCHLcaVa76NWFiUoqLm8g105bnkMROn/X2g8Rm46d+y2F/0kcMMheeb+IqzfgmwNCipACD2qXQJOgmZqLHKhtVt1tVbvmbDNmjX6nyPJzqbdqhzvI8Ez1sDi4sM/gZHkQvPDOcBSxHYWZ8tQwTscCxlrB34mvC3AUm6kR2QrG3lfT4K7X8TTgW7AEeMxHSGiqvKEFJcy04JW6okD3r+o8+RSwq0Or0mfv2IlOcv+yVZ0n834irCNJAZ/1u4KL6yZ661G+Q=="; 
            pfxFile = Convert.FromBase64String(inermediate1);

            certificate = new X509Certificate2(pfxFile);

            //Add the certificate to the collection.
            collection.Add(certificate);

            //Validate signature and get the validation result
            PdfSignatureValidationResult result = lSigFld.ValidateSignature(collection);

            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Signature is " + result.SignatureStatus);

            builder.AppendLine("----------Validation Summary----------");

            //Checks whether the document is modified or not
            bool isModified = result.IsDocumentModified;
            if (isModified)
                builder.AppendLine("The document has been altered or corrupted since the signature was applied.");
            else
                builder.AppendLine("The document has not been modified since the signature was applied.");

            //Signature details
            builder.AppendLine("Digitally signed by " + lSigFld.Signature.Certificate.IssuerName);
            builder.AppendLine("Valid From : " + lSigFld.Signature.Certificate.ValidFrom);
            builder.AppendLine("Valid To : " + lSigFld.Signature.Certificate.ValidTo);
            builder.AppendLine("Signature Algorithm : " + result.SignatureAlgorithm);
            builder.AppendLine("Hash Algorithm : " + result.DigestAlgorithm);

            //Revocation validation details
            builder.AppendLine("OCSP revocation status : " + result.RevocationResult.OcspRevocationStatus);
            if (result.RevocationResult.OcspRevocationStatus == RevocationStatus.None && result.RevocationResult.IsRevokedCRL)
                builder.AppendLine("CRL is revoked.");

            builder.AppendLine();
            builder.AppendLine("--------Revocation Information---------");
            builder.AppendLine();

            foreach (PdfSignerCertificate signerCertificate in result.SignerCertificates)
            {
                if (signerCertificate.OcspCertificate != null)
                {
                    builder.AppendLine("------------OCSP Certificate-------------");
                    builder.AppendLine();
                    foreach (X509Certificate2 item in signerCertificate.OcspCertificate.Certificates)
                    {
                        builder.AppendLine("The OCSP Response was signed by " + item.SubjectName.Name);
                    }
                    builder.AppendLine("Is Embedded: " + signerCertificate.OcspCertificate.IsEmbedded);
                    builder.AppendLine("ValidFrom: " + signerCertificate.OcspCertificate.ValidFrom);
                    builder.AppendLine("ValidTo: " + signerCertificate.OcspCertificate.ValidTo);
                    builder.AppendLine();
                    continue;
                }
                if (signerCertificate.CrlCertificate != null)
                {
                    builder.AppendLine("------------CRL Certificate--------------");
                    builder.AppendLine();
                    foreach (X509Certificate2 item in signerCertificate.CrlCertificate.Certificates)
                    {
                        builder.AppendLine("The CRL was signed by " + item.SubjectName.Name);
                    }
                    builder.AppendLine("Is Embedded: " + signerCertificate.CrlCertificate.IsEmbedded);
                    builder.AppendLine("ValidFrom: " + signerCertificate.CrlCertificate.ValidFrom);
                    builder.AppendLine("ValidTo: " + signerCertificate.CrlCertificate.ValidTo);
                    break;
                }
            }

            //Close the document
            ldoc.Close(true);
            Close();
            return builder.ToString();
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
