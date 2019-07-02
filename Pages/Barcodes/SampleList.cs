using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Barcode { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Ean8",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "Barcodes/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Code128",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "Barcodes/Code128",
                FileName = "Code128.razor"
            },
             new Sample
            {
                Name = "Code128A",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "Barcodes/Code128A",
                FileName = "Code128A.razor"
            },
              new Sample
            {
                Name = "Code128B",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "Barcodes/Code128B",
                FileName = "Code128B.razor"
            },
               new Sample
            {
                Name = "Code128C",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "Barcodes/Code128C",
                FileName = "Code128C.razor"
            },
                new Sample
            {
                Name = "Code93",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "Barcodes/Code93",
                FileName = "Code93.razor"
            },
                 new Sample
            {
                Name = "Code32",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "Barcodes/Code32",
                FileName = "Code32.razor"
            },
                  new Sample
            {
                Name = "Codabar",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "Barcodes/Codabar",
                FileName = "Codabar.razor"
            },
                   new Sample
            {
                Name = "Ean13",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "Barcodes/Ean13",
                FileName = "Ean13.razor"
            },
                   new Sample
            {
                Name = "UpcA",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "Barcodes/UpcA",
                FileName = "UpcA.razor"
            },new Sample
            {
                Name = "UpcE",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "Barcodes/UpcE",
                FileName = "UpcE.razor"
            },new Sample
            {
                Name = "Code39",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "Barcodes/Code39",
                FileName = "Code39.razor"
            },new Sample
            {
                Name = "Code39Extension",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "Barcodes/Code39Extension",
                FileName = "Code39Extension.razor"
            },new Sample
            {
                Name = "QRCode",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "Barcodes/QRCode",
                FileName = "QRCode.razor"
            },new Sample
            {
                Name = "DataMatrix",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "Barcodes/DataMatrix",
                FileName = "DataMatrix.razor"
            }
};
    }
}
