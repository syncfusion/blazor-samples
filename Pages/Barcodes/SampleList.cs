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
                Name = "Ean8",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Code128",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128",
                FileName = "Code128.razor"
            },
            new Sample
            {
                Name = "Code128A",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128a",
                FileName = "Code128A.razor"
            },
            new Sample
            {
                Name = "Code128B",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128b",
                FileName = "Code128B.razor"
            },
            new Sample
            {
                Name = "Code128C",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128c",
                FileName = "Code128C.razor"
            },
            new Sample
            {
                Name = "Code93",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-93",
                FileName = "Code93.razor"
            },
            new Sample
            {
                Name = "Code32",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-32",
                FileName = "Code32.razor"
            },
            new Sample
            {
                Name = "Codabar",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/codabar",
                FileName = "Codabar.razor"
            },
            new Sample
            {
                Name = "Ean13",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/ean-13",
                FileName = "Ean13.razor"
            },
            new Sample
            {
                Name = "UpcA",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/upc-a",
                FileName = "UpcA.razor"
            },
            new Sample
            {
                Name = "UpcE",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/upc-e",
                FileName = "UpcE.razor"
            },
            new Sample
            {
                Name = "Code39",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-39",
                FileName = "Code39.razor"
            },
            new Sample
            {
                Name = "Code39Extension",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-39-extension",
                FileName = "Code39Extension.razor"
            },
            new Sample
            {
                Name = "QRCode",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/qr-code",
                FileName = "QRCode.razor"
            },
            new Sample
            {
                Name = "DataMatrix",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/data-matrix",
                FileName = "DataMatrix.razor"
            }
        };
    }
}
