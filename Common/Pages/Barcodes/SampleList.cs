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
                MetaTitle = "Blazor Barcodes Examples - EAN-8 | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - EAN-8 Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor EAN-8 barcode generates compact retail codes with size options and check digit validation for reliable small-package scanning",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-barcode"
            },
            new Sample
            {
                Name = "EAN-13",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/ean-13",
                FileName = "Ean13.razor",
                MetaTitle = "Blazor Barcodes Examples - EAN-13 | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - EAN-13",
                MetaDescription = "See how the Syncfusion Blazor EAN-13 barcode creates standard product IDs with country codes and check digits to ensure compliant retail labeling and scanning"
            },
            new Sample
            {
                Name = "Code 32",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-32",
                FileName = "Code32.razor",
                MetaTitle = "Blazor Barcodes Examples - Code 32 | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - Code 32",
                MetaDescription = "See how the Syncfusion Blazor Code 32 barcode creates Italian pharma codes with check digit calculation and formatting options to meet regulatory needs"
            },
            new Sample
            {
                Name = "Code 39",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-39",
                FileName = "Code39.razor",
                MetaTitle = "Blazor Barcodes Examples - Code 39 | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - Code 39",
                MetaDescription = "See how the Syncfusion Blazor Code 39 barcode encodes alphanumeric data with full character support, sizing options, and checks for robust inventory labeling"
            },
            new Sample
            {
                Name = "Extended Code 39",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/extended-code-39",
                FileName = "Code39Extension.razor",
                MetaTitle = "Blazor Barcodes - Extended Code 39 | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - Extended Code 39",
                MetaDescription = "See how the Syncfusion Blazor Extended Code 39 encodes full ASCII with checksum support and customization to increase data density for complex labeling"
            },
            new Sample
            {
                Name = "Code 93",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-93",
                FileName = "Code93.razor",
                MetaTitle = "Blazor Barcodes Examples - Code 93 | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - Code 93",
                MetaDescription = "See how the Syncfusion Blazor Code 93 barcode delivers high-density alphanumeric encoding with checksum and compact layout for secure inventory tagging"
            },
            new Sample
            {
                Name = "Code 128",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128",
                FileName = "Code128.razor",
                MetaTitle = "Blazor Barcodes Examples - Code 128 | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - Code 128",
                MetaDescription = "See how the Syncfusion Blazor Code 128 barcode offers high-density numeric encoding with subset selection and check digit to improve logistics labeling"
            },
            new Sample
            {
                Name = "Code 128A",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128a",
                FileName = "Code128A.razor",
                MetaTitle = "Blazor Barcodes Examples - Code 128A | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - Code 128A",
                MetaDescription = "See how the Syncfusion Blazor Code 128A encodes uppercase and control codes with check digit support and formatting options for documentation barcodes"
            },
            new Sample
            {
                Name = "Code 128B",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128b",
                FileName = "Code128B.razor",
                MetaTitle = "Blazor Barcodes Examples - Code 128B | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - Code 128B",
                MetaDescription = "See how the Syncfusion Blazor Code 128B barcode encodes mixed-case text with compact sizing and error checking, ideal for retail and inventory labeling"
            },
            new Sample
            {
                Name = "Code 128C",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128c",
                FileName = "Code128C.razor",
                MetaTitle = "Blazor Barcodes Examples - Code 128C | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - Code 128C",
                MetaDescription = "See how the Syncfusion Blazor Code 128C barcode encodes paired digits for compact numeric storage with automatic check digit calculation for logistics"
            },
            new Sample
            {
                Name = "Codabar",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/codabar",
                FileName = "Codabar.razor",
                MetaTitle = "Blazor Barcodes Examples - Codabar | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - Codabar",
                MetaDescription = "See how the Syncfusion Blazor Codabar barcode supports healthcare encoding with customizable start/stop characters and self-checking for reliable scanning"
            },            
            new Sample
            {
                Name = "UPC-A",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/upc-a",
                FileName = "UpcA.razor",
                MetaTitle = "Blazor Barcodes Examples - UPC-A | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - UPC-A",
                MetaDescription = "See how the Syncfusion Blazor UPC-A barcode generates 12-digit barcodes with automatic check digit calculation and sizing to support point-of-sale scanning"
            },
            new Sample
            {
                Name = "UPC-E",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/upc-e",
                FileName = "UpcE.razor",
                MetaTitle = "Blazor Barcodes Examples - UPC-E | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - UPC-E",
                MetaDescription = "See how the Syncfusion Blazor UPC-E barcode generates compact 8 digit codes with zero suppression and check digit support for efficient small package labeling."
            },
            new Sample
            {
                Name = "QR Code",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/qr-code",
                FileName = "QRCode.razor",
                MetaTitle = "Blazor Barcodes Examples - QR Code | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - QR Code",
                MetaDescription = "See how the Syncfusion Blazor QR Code creates scannable codes with error correction and custom sizing to enable mobile access to links, contacts, or text"
            },
            new Sample
            {
                Name = "QR Code With Logo",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/qr-code-with-logo",
                FileName = "QRCodeWithLogo.razor",
                MetaTitle = "Blazor Barcodes - QR Code With Logo | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - QR Code With Logo",
                MetaDescription = "See how the Syncfusion Blazor QR Code With Logo embeds logos with error-tolerant encoding and styling options to boost brand recognition and stay scannable"
            },
            new Sample
            {
                Name = "Data Matrix",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/data-matrix",
                FileName = "DataMatrix.razor",
                MetaTitle = "Blazor Barcodes Examples - Data Matrix | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - Data Matrix",
                MetaDescription = "See how the Syncfusion Blazor Data Matrix generates compact 2D codes with strong error correction and sizing options for marking small items for robust scanning"
            }
        };
    }
}

