#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
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
                MetaDescription = "This Blazor Barcode example demonstrates EAN-8 symbology for retail product labeling. Create compact barcodes for small product packaging with customizable size and appearance."
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
                MetaDescription = "This Blazor Barcode EAN-13 example demonstrates standard retail product identification. Generate compliant barcodes with country code and check digit validation for international product labeling."
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
                MetaDescription = "This Blazor Barcode Code 32 example demonstrates pharmaceutical product identification coding. Create Italian pharma codes with proper check digit calculation and formatting for medication labeling."
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
                MetaDescription = "This Blazor Barcode Code 39 example demonstrates alphanumeric encoding for inventory tracking. Generate self-checking barcodes with support for uppercase letters, numbers, and special characters."
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
                MetaDescription = "This Blazor Extended Code 39 barcode example demonstrates full ASCII character encoding. Generate barcodes with all 128 ASCII characters for enhanced data encoding in inventory and document tracking systems."
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
                MetaDescription = "This Blazor Barcode Code 93 example demonstrates high-density alphanumeric encoding. Generate compact barcodes with full ASCII support and improved security through dual check digits."
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
                MetaDescription = "This Blazor Barcode Code 128 example demonstrates high-density data encoding with full ASCII support. Generate compact, reliable barcodes for logistics, inventory, and shipping applications."
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
                MetaDescription = "This Blazor Barcode Code 128A example demonstrates uppercase letters, numbers, and control code encoding. Generate specialized barcodes for technical documentation and system control applications."
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
                MetaDescription = "This Blazor Barcode Code 128B example demonstrates text encoding with upper and lowercase letters. Generate barcodes for general text data with efficient space utilization in retail and inventory applications."
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
                MetaDescription = "This Blazor Barcode Code 128C example demonstrates efficient paired-digit numeric encoding. Generate compact barcodes for numeric-only data used in logistics, shipping, and product identification."
            },
            new Sample
            {
                Name = "Codabar",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/codabar",
                FileName = "Codabar.razor",
                MetaTitle = "Blazor Barcode Codabar | Blood Bank & Library Applications | Syncfusion",
                HeaderText = "Blazor Barcode Example - Codabar",
                MetaDescription = "This Blazor Barcode Codabar example demonstrates specialized encoding for healthcare and library applications. Create self-checking barcodes with customizable start/stop characters for blood banks and logistics."
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
                MetaDescription = "This Blazor Barcode UPC-A example demonstrates standard US retail product identification. Generate 12-digit barcodes with automatic check digit calculation for point-of-sale scanning and inventory management."
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
                MetaDescription = "This Blazor Barcode UPC-E example demonstrates compressed retail product identification. Generate space-efficient 8-digit barcodes for small product packaging with zero suppression for retail applications."
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
                MetaDescription = "This Blazor QR Code example demonstrates high-capacity 2D barcode generation. Create scannable codes for URLs, text, and contact information with customizable error correction and sizing for mobile applications."
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
                MetaDescription = "This Blazor QR Code with logo example demonstrates brand-embedded 2D barcode generation. Create scannable codes with centered logo images for marketing, brand recognition, and enhanced user experience."
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
                MetaDescription = "This Blazor Data Matrix example demonstrates high-density 2D barcode generation. Create square or rectangular matrix codes for small item marking with robust error correction in industrial applications."
            }
        };
    }
}

