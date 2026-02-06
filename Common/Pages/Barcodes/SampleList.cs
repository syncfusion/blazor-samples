#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> Barcode { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "EAN-8",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Barcode EAN-8 | Retail Product Labeling | Syncfusion",
                HeaderText = "Blazor Barcode Example - EAN-8 Default Functionalities",
                MetaDescription = "This Blazor Barcode example demonstrates EAN-8 symbology for retail labeling. Create compact barcodes for small packages with customizable size and appearance."
            },
            new Sample
            {
                Name = "EAN-13",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/ean-13",
                FileName = "Ean13.razor",
                MetaTitle = "Blazor Barcode EAN-13 | International Product Labeling | Syncfusion",
                HeaderText = "Blazor Barcode Example - EAN-13",
                MetaDescription = "This Blazor Barcode EAN-13 demo showcases standard product ID for retail. Create compliant barcodes with country code and check digit for global labeling."
            },
            new Sample
            {
                Name = "Code 32",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-32",
                FileName = "Code32.razor",
                MetaTitle = "Blazor Barcode Code 32 | Pharmaceutical Identification | Syncfusion",
                HeaderText = "Blazor Barcode Example - Code 32",
                MetaDescription = "This Blazor Barcode Code 32 example showcases pharmaceutical product coding. Create Italian pharma codes with proper check digit calculation and formatting."
            },
            new Sample
            {
                Name = "Code 39",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-39",
                FileName = "Code39.razor",
                MetaTitle = "Blazor Barcode Code 39 | Alphanumeric Encoding | Syncfusion",
                HeaderText = "Blazor Barcode Example - Code 39",
                MetaDescription = "This Blazor Barcode Code 39 example demonstrates alphanumeric encoding for inventory tracking. It supports uppercase letters, numbers, and special characters."
            },
            new Sample
            {
                Name = "Extended Code 39",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/extended-code-39",
                FileName = "Code39Extension.razor",
                MetaTitle = "Blazor Barcode Extended Code 39 | Full ASCII Encoding | Syncfusion",
                HeaderText = "Blazor Barcode Example - Extended Code 39",
                MetaDescription = "This Blazor Extended Code 39 barcode demo encodes 128 ASCII characters, enhancing data encoding in inventory and document tracking systems with ASCII support."
            },
            new Sample
            {
                Name = "Code 93",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-93",
                FileName = "Code93.razor",
                MetaTitle = "Blazor Barcode Code 93 | High-Density Encoding | Syncfusion",
                HeaderText = "Blazor Barcode Example - Code 93",
                MetaDescription = "This Blazor Barcode Code 93 example shows high-density alphanumeric encoding. It generates compact barcodes with full ASCII support and enhanced security."
            },
            new Sample
            {
                Name = "Code 128",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128",
                FileName = "Code128.razor",
                MetaTitle = "Blazor Barcode Code 128 | High-Density Data Encoding | Syncfusion",
                HeaderText = "Blazor Barcode Example - Code 128",
                MetaDescription = "This Blazor Barcode Code 128 demo offers high-density data encoding with ASCII support. Create compact and reliable barcodes ideal for logistics and inventory."
            },
            new Sample
            {
                Name = "Code 128A",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128a",
                FileName = "Code128A.razor",
                MetaTitle = "Blazor Barcode Code 128A | Uppercase & Control Codes | Syncfusion",
                HeaderText = "Blazor Barcode Example - Code 128A",
                MetaDescription = "This Blazor Barcode Code 128A example encodes uppercase letters, numbers, and control codes. Generate specialized barcodes for documentation and control tasks."
            },
            new Sample
            {
                Name = "Code 128B",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128b",
                FileName = "Code128B.razor",
                MetaTitle = "Blazor Barcode Code 128B | Alphanumeric Text Encoding | Syncfusion",
                HeaderText = "Blazor Barcode Example - Code 128B",
                MetaDescription = "This Blazor Barcode Code 128B demo shows text encoding with upper and lowercase letters. Generate barcodes for general text with space utilization in retail."
            },
            new Sample
            {
                Name = "Code 128C",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128c",
                FileName = "Code128C.razor",
                MetaTitle = "Blazor Barcode Code 128C | Numeric Paired Digit Encoding | Syncfusion",
                HeaderText = "Blazor Barcode Example - Code 128C",
                MetaDescription = "This Blazor Barcode Code 128C demo shows numeric encoding using paired digits, creating compact barcodes for logistics, shipping, and product ID applications."
            },
            new Sample
            {
                Name = "Codabar",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/codabar",
                FileName = "Codabar.razor",
                MetaTitle = "Blazor Barcode Codabar | Blood Bank Applications | Syncfusion",
                HeaderText = "Blazor Barcode Example - Codabar",
                MetaDescription = "This Blazor Barcode Codabar example showcases specialized encoding for healthcare. Create self-checking barcodes with customizable start/stop characters."
            },            
            new Sample
            {
                Name = "UPC-A",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/upc-a",
                FileName = "UpcA.razor",
                MetaTitle = "Blazor Barcode UPC-A | US Retail Product Identification | Syncfusion",
                HeaderText = "Blazor Barcode Example - UPC-A",
                MetaDescription = "This Blazor Barcode UPC-A demo shows how to generate 12-digit barcodes with automatic check digit calculation for point-of-sale scanning and management."
            },
            new Sample
            {
                Name = "UPC-E",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/upc-e",
                FileName = "UpcE.razor",
                MetaTitle = "Blazor Barcode UPC-E | Compact Retail Identification | Syncfusion",
                HeaderText = "Blazor Barcode Example - UPC-E",
                MetaDescription = "This Blazor Barcode UPC-E sample demo compressed retail product identification. Generate 8-digit barcodes for small product packaging with zero suppression."
            },
            new Sample
            {
                Name = "QR Code",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/qr-code",
                FileName = "QRCode.razor",
                MetaTitle = "Blazor QR Code Generator | Mobile-Scannable Codes | Syncfusion",
                HeaderText = "Blazor Barcode Example - QR Code",
                MetaDescription = "This Blazor QR Code example demonstrate how to generate scannable codes, text, and contacts with customizable error correction, sizing for mobile applications."
            },
            new Sample
            {
                Name = "QR Code With Logo",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/qr-code-with-logo",
                FileName = "QRCodeWithLogo.razor",
                MetaTitle = "Blazor QR Code With Logo | Branded Scannable Codes | Syncfusion",
                HeaderText = "Blazor Barcode Example - QR Code With Logo",
                MetaDescription = "This Blazor QR Code with logo demo shows how to create scannable codes with centered logo images for marketing, brand recognition, and enhanced user experience."
            },
            new Sample
            {
                Name = "Data Matrix",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/data-matrix",
                FileName = "DataMatrix.razor",
                MetaTitle = "Blazor Data Matrix Barcode | High-Density 2D Encoding | Syncfusion",
                HeaderText = "Blazor Barcode Example - Data Matrix",
                MetaDescription = "This Blazor Data Matrix example demonstrates how to create square or rectangular matrix codes for small item marking with the robust error correction."
            }
        };
    }
}

