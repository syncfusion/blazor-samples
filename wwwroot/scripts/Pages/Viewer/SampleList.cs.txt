using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> PdfViewer { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "PdfViewer",
                Directory = "Viewer/PdfViewer",
                Url = "Viewer/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.Updated,
                TitleTag = "PDFViewer . Default Functionalities .Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the default functionalities of the PDF viewer",
                ActionDescription = new string[] {
                @"<p>This sample demonstrates the default functionalities of the PDF viewer.</p>"
                },
                Description = new string[] {
                @"<p>
                The PDF viewer component is used to view, annotate (review), download and print the PDF documents.
                </p>
                <p>
                In this demo, the PDF viewer is rendered with default PDF file.
                </p>
                <p>
                More information about PDF viewer can be found in this
                <a target=""_blank""
                href=""https://ej2.syncfusion.com/aspnet-core-razor-components/documentation/pdfviewer/getting-started/"">
                documentation section
                </a>.
                </p>"
                }
            }, new Sample
            {
                Name = "RTL",
                Category = "PdfViewer",
                Directory = "Viewer/PdfViewer",
                Url = "Viewer/RightToLeft",
                FileName = "RightToLeft.razor",
                Type = SampleType.New,
                TitleTag = "PDFViewer . Right To Left .Syncfusion Blazor Components",
                MetaDescription = "RTL provides an option to switch the text direction and layout of the PDF Viewer from right to left. It improves the user experiences and accessibility for users who use right-to-left languages (Arabic, Farsi, Urdu, etc.). To enable RTL PDF Viewer, set the enableRtl to true.",
                ActionDescription = new string[] {
                @"<p>RTL provides an option to switch the text direction and layout of the PDF Viewer from right to left. It improves the user experiences and accessibility for users who use right-to-left languages (Arabic, Farsi, Urdu, etc.). To enable RTL PDF Viewer, set the enableRtl to true.</p>"
                },
                Description = new string[] {
                @"<p>
                In this example, you can see PDF Viewer right-to-left and the locale set in arabic[locale value is ar-AE]
                </p>
                <p>
                By default, locale value is en-US. If you want to change the en-US culture to a different culture, you have to change the locale accordingly.
                </p>
                <p>
                More information about PDF viewer can be found in this
                <a target=""_blank""
                href=""https://ej2.syncfusion.com/aspnet-core-razor-components/documentation/pdfviewer/getting-started/"">
                documentation section
                </a>.
                </p>"
                }
            },
            new Sample
            {
                Name = "Form Filling",
                Category = "PdfViewer",
                Directory = "Viewer/PdfViewer",
                Url = "Viewer/FormFilling",
                FileName = "FormFilling.razor",
                Type = SampleType.New,
                TitleTag = "PDFViewer . Form Filling .Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the form filling features of PDF Viewer and allows you to edit the form fields, download and print the edited form fields PDF documents",
                ActionDescription = new string[] {
                @"<p>This sample demonstrates the form filling features of PDF Viewer and allows you to edit the form fields, download and print the edited form fields PDF documents.</p>"
                },
                Description = new string[] {
                @"<p>
                The PDF viewer component is used to view, annotate (review), download and print the PDF documents.
                </p>
                <p>
                In this demo, the PDF viewer is rendered with PDF form file.
                </p>
                <p>
                More information about PDF viewer can be found in this
                <a target=""_blank""
                href=""https://ej2.syncfusion.com/aspnet-core-razor-components/documentation/pdfviewer/getting-started/"">
                documentation section
                </a>.
                </p>"
                }
            }
        };
    }
}
