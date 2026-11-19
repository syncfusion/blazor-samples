using System.Collections.Generic;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        private static readonly string[] Gs1Code128NotificationDescription =
        {
            "Added support for GS1 Code 128 barcode, enabling high-density encoding of GS1 Application Identifiers (AIs) for retail, healthcare, and supply chain applications."
        };

        private static readonly string[] Gs1DatabarStackedNotificationDescription =
        {
            "Added support for GS1 DataBar Stacked barcode, providing compact encoding of GTIN data for space-constrained retail and labeling applications."
        };

        private static readonly string[] Gs1DatabarOmniDirectionalNotificationDescription =
        {
            "Added support for GS1 DataBar Omnidirectional barcode, designed for reliable omnidirectional scanning in retail point-of-sale environments."
        };

        private static readonly string[] Gs1DatabarStackedOmniDirectionalNotificationDescription =
        {
            "Added support for GS1 DataBar Stacked Omnidirectional barcode, combining compact encoding with omnidirectional scanning for retail applications."
        };

        private static readonly string[] Gs1DataBarLimitedNotificationDescription =
        {
            "Added support for GS1 DataBar Limited barcode, optimized for small-item labeling and space-constrained product identification."
        };

        private static readonly string[] Gs1DataBarExpandedNotificationDescription =
        {
            "Added support for GS1 DataBar Expanded barcode, enabling the encoding of extended GS1 Application Identifier (AI) data for traceability and product information."
        };

        private static readonly string[] Gs1DataBarExpandedStackedNotificationDescription =
        {
            "Added support for GS1 DataBar Expanded Stacked barcode, providing compact encoding of extended GS1 Application Identifier (AI) data in limited label space."
        };

        private static readonly string[] Gs1Itf14NotificationDescription =
        {
            "Added support for ITF-14 barcode, widely used for carton and logistics labeling in supply chain and distribution systems."
        };

        private static readonly string[] GS1QRCode4NotificationDescription =
        {
            "Added support for GS1 QR Code, enabling the encoding of structured business data using GS1 Application Identifiers (AIs) in a two-dimensional barcode."
        };

        private static readonly string[] GS1DataMatrixNotificationDescription =
        {
            "Added support for GS1 Data Matrix barcode, enabling compact encoding of GS1 Application Identifiers (AIs) for healthcare, manufacturing, and traceability applications."
        };

        private static readonly string[] DotCodeNotificationDescription =
        {
            "Added support for DotCode barcode, a compact two-dimensional symbology designed for product identification and high-speed printing applications."
        };

        private static readonly string[] GS1DotCodeNotificationDescription =
        {
            "Added support for GS1 DotCode barcode, enabling compact encoding of GS1 Application Identifiers (AIs) for healthcare, pharmaceutical, and logistics applications."
        };

        public List<Sample> Barcode { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "EAN-8",
                Category = "Linear Barcodes",
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
                Category = "Linear Barcodes",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/ean-13",
                FileName = "Ean13.razor",
                MetaTitle = "Blazor Barcodes Examples - EAN-13 | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - EAN-13",
                MetaDescription = "See how the Syncfusion Blazor EAN-13 barcode creates standard product IDs with country codes and check digits to ensure compliant retail labeling and scanning"
            },
            new Sample
            {
                Name = "Code 128",
                Category = "Linear Barcodes",
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
                Category = "Linear Barcodes",
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
                Category = "Linear Barcodes",
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
                Category = "Linear Barcodes",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128c",
                FileName = "Code128C.razor",
                MetaTitle = "Blazor Barcodes Examples - Code 128C | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - Code 128C",
                MetaDescription = "See how the Syncfusion Blazor Code 128C barcode encodes paired digits for compact numeric storage with automatic check digit calculation for logistics"
            },
             new Sample
            {
                Name = "UPC-A",
                Category = "Linear Barcodes",
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
                Category = "Linear Barcodes",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/upc-e",
                FileName = "UpcE.razor",
                MetaTitle = "Blazor Barcodes Examples - UPC-E | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - UPC-E",
                MetaDescription = "See how the Syncfusion Blazor UPC-E barcode generates compact 8 digit codes with zero suppression and check digit support for efficient small package labeling."
            },
            new Sample
            {
                Name = "Code 32",
                Category = "Linear Barcodes",
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
                Category = "Linear Barcodes",
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
                Category = "Linear Barcodes",
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
                Category = "Linear Barcodes",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-93",
                FileName = "Code93.razor",
                MetaTitle = "Blazor Barcodes Examples - Code 93 | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - Code 93",
                MetaDescription = "See how the Syncfusion Blazor Code 93 barcode delivers high-density alphanumeric encoding with checksum and compact layout for secure inventory tagging"
            },
            
            new Sample
            {
                Name = "Codabar",
                Category = "Linear Barcodes",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/codabar",
                FileName = "Codabar.razor",
                MetaTitle = "Blazor Barcodes Examples - Codabar | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - Codabar",
                MetaDescription = "See how the Syncfusion Blazor Codabar barcode supports healthcare encoding with customizable start/stop characters and self-checking for reliable scanning"
            },            
           
            new Sample
            {
                Name = "GS1 Code128",
                Category = "GS1 Barcodes",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/gs1-code128",
                FileName = "GS1Code128.razor",
                MetaTitle = "Blazor Barcodes Examples - GS1 Code128 | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - GS1 Code128",
                MetaDescription = "See how the Syncfusion Blazor Data Matrix generates compact 2D codes with strong error correction and sizing options for marking small items for robust scanning",
                Type = SampleType.New,
                NotificationDescription = Gs1Code128NotificationDescription
            },
            new Sample
            {
                Name = "ITF-14",
                Category = "GS1 Barcodes",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/itf-14",
                FileName = "GS1ITF14.razor",
                MetaTitle = "Blazor Barcodes Examples - GS1 ITF 14 | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - GS1 ITF 14",
                MetaDescription = "See how the Syncfusion Blazor Data Matrix generates compact 2D codes with strong error correction and sizing options for marking small items for robust scanning",
                Type = SampleType.New,
                NotificationDescription = Gs1Itf14NotificationDescription
            },
            new Sample
            {
                Name = "GS1 DataBar Omnidirectional",
                Category = "GS1 Barcodes",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/gs1-databar-omnidirectional",
                FileName = "GS1DatabarOmnidirectional.razor",
                MetaTitle = "Blazor GS1 DataBar Omnidirectional Examples | Barcodes | Syncfusion",
                HeaderText = "Blazor Barcode Example - GS1 DataBar Omnidirectional",
                MetaDescription = "See how the Syncfusion Blazor Data Matrix generates compact 2D codes with strong error correction and sizing options for marking small items for robust scanning",
                Type = SampleType.New,
                NotificationDescription = Gs1DatabarOmniDirectionalNotificationDescription
            },
             new Sample
            {
                Name = "GS1 DataBar Stacked",
                Category = "GS1 Barcodes",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/gs1-databar-stacked",
                FileName = "GS1DatabarStacked.razor",
                MetaTitle = "Blazor GS1 DataBar Stacked Examples | Barcodes | Syncfusion",
                HeaderText = "Blazor Barcode Example - GS1 DataBar Stacked",
                MetaDescription = "See how the Syncfusion Blazor Data Matrix generates compact 2D codes with strong error correction and sizing options for marking small items for robust scanning",
                Type = SampleType.New,
                NotificationDescription = Gs1DatabarStackedNotificationDescription
            },
            new Sample
            {
                Name = "GS1 DataBar Stacked Omnidirectional",
                Category = "GS1 Barcodes",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/gs1-databar-stacked-omnidirectional",
                FileName = "GS1DatabarStackedOmniDirectional.razor",
                MetaTitle = "Blazor GS1 DataBar Stacked Omnidirectional | Syncfusion",
                HeaderText = "Blazor Barcode Example - GS1 DataBar Stacked Omnidirectional",
                MetaDescription = "See how the Syncfusion Blazor Data Matrix generates compact 2D codes with strong error correction and sizing options for marking small items for robust scanning",
                Type = SampleType.New,
                NotificationDescription = Gs1DatabarStackedOmniDirectionalNotificationDescription
            },
            new Sample
            {
                Name = "GS1 DataBar Limited",
                Category = "GS1 Barcodes",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/gs1-databar-limited",
                FileName = "GS1DataBarLimited.razor",
                MetaTitle = "Blazor GS1 DataBar Limited Examples | Barcodes | Syncfusion",
                HeaderText = "Blazor Barcode Example - GS1 DataBar Limited",
                MetaDescription = "See how the Syncfusion Blazor Data Matrix generates compact 2D codes with strong error correction and sizing options for marking small items for robust scanning",
                Type = SampleType.New,
                NotificationDescription = Gs1DataBarLimitedNotificationDescription
            },
            new Sample
            {
                Name = "GS1 DataBar Expanded",
                Category = "GS1 Barcodes",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/gs1-databar-expanded",
                FileName = "GS1DataBarExpanded.razor",
                MetaTitle = "Blazor GS1 DataBar Expanded Examples | Barcodes | Syncfusion",
                HeaderText = "Blazor Barcode Example - GS1 DataBar Expanded",
                MetaDescription = "See how the Syncfusion Blazor Data Matrix generates compact 2D codes with strong error correction and sizing options for marking small items for robust scanning",
                Type = SampleType.New,
                NotificationDescription = Gs1DataBarExpandedNotificationDescription
            }, 
            new Sample
            {
                Name = "GS1 DataBar Expanded Stacked",
                Category = "GS1 Barcodes",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/gs1-databar-expanded-stacked",
                FileName = "GS1DataBarExpandedStacked.razor",
                MetaTitle = "Blazor GS1 DataBar Expanded Stacked | Barcodes | Syncfusion",
                HeaderText = "Blazor Barcode Example - GS1 DataBar Expanded Stacked",
                MetaDescription = "See how the Syncfusion Blazor Data Matrix generates compact 2D codes with strong error correction and sizing options for marking small items for robust scanning",
                Type = SampleType.New,
                NotificationDescription = Gs1DataBarExpandedStackedNotificationDescription
            }
        };

        public List<Sample> BarcodeQRCode { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "QR Code",
                Directory = "Barcodes/QRCodeGenerator",
                Url = "barcodes/qr-code",
                FileName = "QRCode.razor",
                MetaTitle = "Blazor Barcodes Examples - QR Code | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - QR Code",
                MetaDescription = "See how the Syncfusion Blazor QR Code generates high-capacity 2D codes with error correction for URLs, text, and data encoding with customizable sizing"
            },
            new Sample
            {
                Name = "QR Code with Logo",
                Directory = "Barcodes/QRCodeGenerator",
                Url = "barcodes/qr-code-with-logo",
                FileName = "QRCodeWithLogo.razor",
                MetaTitle = "Blazor Barcodes Examples - QR Code with Logo | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - QR Code with Logo",
                MetaDescription = "See how the Syncfusion Blazor QR Code with embedded logo maintains scannability while adding branding to 2D codes with customizable logo positioning"
            },
            new Sample
            {
                Name = "GS1 QR Code",
				Type = SampleType.New,
				Directory = "Barcodes/QRCodeGenerator",
                Url = "barcodes/gs1-qr-code",
                FileName = "GS1QRCode.razor",
                MetaTitle = "Blazor Barcodes Examples - GS1 QR Code | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - GS1 QR Code",
                MetaDescription = "See how the Syncfusion Blazor GS1 QR Code encodes GS1 application identifiers in 2D format for enhanced supply chain traceability",
                NotificationDescription = GS1QRCode4NotificationDescription
            }
        };

        public List<Sample> BarcodeDataMatrix { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Data Matrix",
                Directory = "Barcodes/DataMatrixGenerator",
                Url = "barcodes/data-matrix",
                FileName = "DataMatrix.razor",
                MetaTitle = "Blazor Barcodes Examples - Data Matrix | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - Data Matrix",
                MetaDescription = "See how the Syncfusion Blazor Data Matrix generates compact 2D codes with strong error correction and sizing options for marking small items for robust scanning"
            },
            new Sample
            {
                Name = "GS1 Data Matrix",
				Type = SampleType.New,
				Directory = "Barcodes/DataMatrixGenerator",
                Url = "barcodes/gs1-data-matrix",
                FileName = "GS1DataMatrix.razor",
                MetaTitle = "Blazor Barcodes Examples - GS1 Data Matrix | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - GS1 Data Matrix",
                MetaDescription = "See how the Syncfusion Blazor GS1 Data Matrix encodes GS1 application identifiers in 2D format with strong error correction for supply chain tracking",
                NotificationDescription = GS1DataMatrixNotificationDescription
            }
        };

        public List<Sample> BarcodeDotCode { get; set; } = new List<Sample>{
			  new Sample
			{
				Name = "DotCode",
                Type = SampleType.New,
                Directory = "Barcodes/DotCodeGenerator",
				Url = "barcodes/dot-code",
				FileName = "DotCode.razor",
				MetaTitle = "Blazor Barcodes Examples - DotCode | Barcodes Demos | Syncfusion",
				HeaderText = "Blazor Barcode Example - DotCode",
				MetaDescription = "See how the Syncfusion Blazor DotCode encodes data in compact dot matrix format for high-density product and regulatory labeling",
                NotificationDescription = DotCodeNotificationDescription
			},
			new Sample
            {
                Name = "GS1 DotCode",
				Type = SampleType.New,
				Directory = "Barcodes/DotCodeGenerator",
                Url = "barcodes/gs1-dotcode",
                FileName = "GS1DotCode.razor",
                MetaTitle = "Blazor Barcodes Examples - GS1 DotCode | Barcodes Demos | Syncfusion",
                HeaderText = "Blazor Barcode Example - GS1 DotCode",
                MetaDescription = "See how the Syncfusion Blazor GS1 DotCode encodes GS1 data in compact dot matrix format for high-density product and regulatory labeling",
                NotificationDescription = GS1DotCodeNotificationDescription
            }
        };
    }
}

