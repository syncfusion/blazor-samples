using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
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
                FileName = "DefaultFunctionalities.razor",
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the 8-digit Global Trade Identification Numbers. It was introduced for use on small
                            packages where an EAN-8 barcode would be too large.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample shows how to create the EAN-8 barcode. The `Type` property can be used to set the barcode type as
                        `Ean8`
                    </p>
                    <br>"
                }
            },
            new Sample
            {
                Name = "Code128",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128",
                FileName = "Code128.razor",
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes a barcode image that presents alphanumeric combinations. Code 128 barcode consists of a start character, data digits, a modulo 103 check digit, and a stop character.

                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample shows how to create the Code 128 barcode type with alphanumeric characters. The `Type` property can be used to set the barcode type as `Code128`.
                    </p>
                    <br>"
                }

            },
            new Sample
            {
                Name = "Code128A",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128a",
                FileName = "Code128A.razor",
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes a barcode image that presents information with a combination of numbers, uppercase letters, and control characters such as tab and new line.

                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample shows how to create the Code 128A barcode type with alphanumeric characters. The `Type` property can be used to set the barcode type as ` Code128A`.
                    </p>
                    <br>"
                }
            },
            new Sample
            {
                Name = "Code128B",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128b",
                FileName = "Code128B.razor",
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes a barcode image that presents information with a combination of numbers, uppercase letters, and control characters such as tab and new line.

                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample shows how to create the Code 128B barcode type with alphanumeric characters. The `Type` property can be used to set the barcode type as `Code128B`.
                    </p>
                    <br>"
                }
            },
            new Sample
            {
                Name = "Code128C",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-128c",
                FileName = "Code128C.razor",
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes a barcode image that presents information with a combination of numbers, uppercase and lowercase letters, and some additional characters.

                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample shows how to create the Code 128C barcode type with alphanumeric characters. The `Type` property can be used to set the barcode type as `Code128C`.
                    </p>
                    <br>"
                }
            },
            new Sample
            {
                Name = "Code93",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-93",
                FileName = "Code93.razor",
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes how to present a model number with higher density and data security enhancements compared to Code 39. Code 93 has a native character set of 26 uppercase letters, 10 digits, and 7 special characters.

                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample shows how to create the Code 93 barcode with two check characters. The `Type` property can be used to set the barcode type as `Code93`. By default, `enableCheckSum` is set as true, but the checksum can be disabled by assigning false to it.
                    </p>
                    <br>"
                }
            },
            new Sample
            {
                Name = "Code32",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-32",
                FileName = "Code32.razor",
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the pharmaceutical code that encodes numeric data in a compressed format. This type of barcode supports all numeric digits and all uppercase letters.

                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample shows how to create the Code 32 barcode with five bars and four spaces for encoding each character. The `Type` property can be used to set the barcode type as `Code32`.
                    </p>
                    <br>"
                }
            },
            new Sample
            {
                Name = "Codabar",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/codabar",
                FileName = "Codabar.razor",
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes a barcode that is designed to be accurately read even when printed with dot matrix printers. This type of barcode is widely used in applications that require serial numbers, such as blood bank management, slips for door-to door delivery services, and member cards.

                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample shows a codabar with a character set of 16 letters with four start and stop characters. The `Type` property can be used to set the barcode type as `Codabar`.
                    </p>
                    <br>"
                }
            },
            new Sample
            {
                Name = "Ean13",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/ean-13",
                FileName = "Ean13.razor",
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the 13-digit Global Trade Identification Numbers. These 13 digits comprise the following components: GS1 company prefix, manufacturer code, product code, and check digit.

                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample shows how to create the EAN-13 barcode. The `Type` property can be used to set the barcode type as `Ean13`.
                    </p>
                    <br>"
                }
            },
            new Sample
            {
                Name = "UpcA",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/upc-a",
                FileName = "UpcA.razor",
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes a consumer good identification number. A UPC-A barcode consists of four areas: number system, manufacturer code, product code, and check digit.

                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample shows how to create the UPC-A barcode. The `Type` property can be used to set the barcode type as `UpcA`. By default, `EnableCheckSum` is set as true, but the checksum can be disabled by assigning false to it.
                    </p>
                    <br>"
                }
            },
            new Sample
            {
                Name = "UpcE",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/upc-e",
                FileName = "UpcE.razor",
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes a barcode image that presents information with a combination of numbers, uppercase letters, and control characters such as tab and new line. 

                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample shows how to create the Code 128A barcode type with alphanumeric characters. The `Type` property can be used to set the barcode type as ` Code128A`.
                    </p>
                    <br>"
                }
            },
            new Sample
            {
                Name = "Code39",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-39",
                FileName = "Code39.razor",
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes Code 39, a self-checking barcode symbology that consists of uppercase letters, numeric digits, and several special characters. It is often used to present model numbers. Code 39 is widely used in the automotive and defense industries as a standard label.

                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample shows how to create the Code 39 self-checking symbology type barcode image. The `Type` property can be used to set the barcode type as `Code39`.
                    </p>
                    <br>"
                }
            },
            new Sample
            {
                Name = "Code39Extension",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/code-39-extension",
                FileName = "Code39Extension.razor",
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the model number of an item in the automotive industry. This barcode supports both standard and extended Code 39 barcodes. The extended mode gives access to the full set of ASCII letters.

                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample shows how to create the extended Code 39 barcode with an added checksum. The `Type` property can be used to set the barcode type as `Code39Extension`. By default, `enableCheckSum` is set as true, but the checksum can be disabled by assigning false to it.
                    </p>
                    <br>"
                }
            },
            new Sample
            {
                Name = "QRCode",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/qr-code",
                FileName = "QRCode.razor",
                ActionDescription = new string[] {
                    @" <p>
                        This sample displays a machine-readable optical label that contains information about the item to which it is
                            attached. The information may be a location, a URL, an address book, etc.

                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This example shows how to display a URL as the optical label using the Barcode component. The `Type` property
                        can be used to set the barcode type as one-dimensional or two-dimensional.
                        The `Version` property is used to set the version of the QR barcode. Also, the Barcode component provides
                         support to set the error correction level on a QR-type barcode by using the `ErrorCorrectionLevel` property.
                    </p>
                    <br>"
                }
            },
            new Sample
            {
                Name = "DataMatrix",
                Category = "Getting started",
                Directory = "Barcodes/Barcode",
                Url = "barcodes/data-matrix",
                FileName = "DataMatrix.razor",
                ActionDescription = new string[] {
                    @" <p>
                        This sample displays encoded numerals or text as an optical label using solid adjacent borders in an L-shape and two other borders consisting of alternating dark and light cells or modules. Within these borders are rows and columns of cells that encode information.

                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This example shows how to display encoded text or numerical values as the label using the Barcode component. The `Type` property can be used to set the barcode type as data matrix. The data matrix encoding type can be set using the `encoding` property of the Barcode component and the data matrix size can be defined using the `size` property of the component.
                    </p>
                    <br>"
                }
            }
        };
    }
}
