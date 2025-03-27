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
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Property panel updated! Barcode customization is now available. You can modify its style, adjust settings, and download it effortlessly." }
            },
            new Sample
            {
                Name = "EAN-13",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/ean-13",
                FileName = "Ean13.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Property panel updated! Barcode customization is now available. You can modify its style, adjust settings, and download it effortlessly." }
            },
            new Sample
            {
                Name = "Code 32",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-32",
                FileName = "Code32.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Property panel updated! Barcode customization is now available. You can modify its style, adjust settings, and download it effortlessly." }
            },
            new Sample
            {
                Name = "Code 39",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-39",
                FileName = "Code39.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Property panel updated! Barcode customization is now available. You can modify its style, adjust settings, and download it effortlessly." }
            },
            new Sample
            {
                Name = "Extended Code 39",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/extended-code-39",
                FileName = "Code39Extension.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Property panel updated! Barcode customization is now available. You can modify its style, adjust settings, and download it effortlessly." }
            },
            new Sample
            {
                Name = "Code 93",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-93",
                FileName = "Code93.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Property panel updated! Barcode customization is now available. You can modify its style, adjust settings, and download it effortlessly." }
            },
            new Sample
            {
                Name = "Code 128",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128",
                FileName = "Code128.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Property panel updated! Barcode customization is now available. You can modify its style, adjust settings, and download it effortlessly." }
            },
            new Sample
            {
                Name = "Code 128A",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128a",
                FileName = "Code128A.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Property panel updated! Barcode customization is now available. You can modify its style, adjust settings, and download it effortlessly." }
            },
            new Sample
            {
                Name = "Code 128B",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128b",
                FileName = "Code128B.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Property panel updated! Barcode customization is now available. You can modify its style, adjust settings, and download it effortlessly." }
            },
            new Sample
            {
                Name = "Code 128C",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128c",
                FileName = "Code128C.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Property panel updated! Barcode customization is now available. You can modify its style, adjust settings, and download it effortlessly." }
            },
            new Sample
            {
                Name = "Codabar",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/codabar",
                FileName = "Codabar.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Property panel updated! Barcode customization is now available. You can modify its style, adjust settings, and download it effortlessly." }
            },            
            new Sample
            {
                Name = "UPC-A",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/upc-a",
                FileName = "UpcA.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Property panel updated! Barcode customization is now available. You can modify its style, adjust settings, and download it effortlessly" }
            },
            new Sample
            {
                Name = "UPC-E",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/upc-e",
                FileName = "UpcE.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Property panel updated! Barcode customization is now available. You can modify its style, adjust settings, and download it effortlessly." }
            },
            new Sample
            {
                Name = "QR Code",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/qr-code",
                FileName = "QRCode.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Property panel updated! QR Code customization is now available. You can modify its style, adjust settings, and download it effortlessly." }
            },
            new Sample
            {
                Name = "QR Code With Logo",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/qr-code-with-logo",
                FileName = "QRCodeWithLogo.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Property panel updated! QR Code customization is now available. You can modify its style, adjust settings, and download it effortlessly." }
            },
            new Sample
            {
                Name = "Data Matrix",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/data-matrix",
                FileName = "DataMatrix.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Property panel updated! Data Matrix customization is now available. You can modify its style, adjust settings, and download it effortlessly." }
            }
        };
    }
}
