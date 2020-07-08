using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> PDFViewer { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "PDF Viewer",
                Directory = "Viewer/PdfViewer",
                Url = "pdf-viewer/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.Updated,
                ActionDescription = new string[] {
                @"<p>This sample explains the core features of PDF Viewer such as PDF viewing, printing, navigation, text search and selection, zooming, panning, reviewing, and more with their built-in toolbar.</p>"
                },
                Description = new string[] {
                @"<p>
                The PDF Viewer component allows you to view, review, and print the PDF files. This sample explains the following key features of PDF Viewer:
                </p>
 <ul>
        <li>View the PDF document</li>
        <li>Core interactions such as scrolling, zooming, panning, and page navigation.</li>
        <li>Annotations such as TextMarkup, Shape, Measure, Stamp, and Free Text.</li>
        <li>Built-in toolbar</li>
        <li>Select and copy text from a PDF file</li>
        <li>Search a text easily across a PDF document</li>
        <li>Easy navigation with the help of Bookmarks, thumbnails, hyperlinks and table of contents</li>
        <li>View modes such as fit to page and fit to width.</li>
        <li>Print the entire document or a specific page directly from the browser.</li>
    </ul>   
                <p>
                In this demo, the PDF Viewer is rendered with default a PDF file.
                </p>
                <p>
                More information about the PDF Viewer can be found in this
                <a target=""_blank""
                href=""https://ej2.syncfusion.com/blazor/documentation/pdfviewer/getting-started/server-side-application/"">
                documentation section
                </a>.
                </p>"
                }
            }, new Sample
            {
                Name = "Right To Left",
                Category = "PDF Viewer",
                Directory = "Viewer/PdfViewer",
                Url = "pdf-viewer/right-to-left",
                FileName = "RightToLeft.razor",
                ActionDescription = new string[] {
                @"<p>RTL provides an option to switch the text direction and layout of the PDF Viewer from right to left. It improves the user experiences and accessibility for users who use right-to-left languages (Arabic, Farsi, Urdu, etc.). To enable RTL PDF Viewer, set the enableRtl to true.</p>"
                },
                Description = new string[] {
                @"<p>
                In this example, you can see the RTL PDF Viewer and locale set in Arabic[locale value is ar-AE]
                </p>
                <p>
                By default, locale value is en-US. If you want to change the en-US culture to a different culture, you have to change the locale accordingly.
                </p>
                <p>
                More information about PDF Viewer can be found in this
                <a target=""_blank""
                href=""https://ej2.syncfusion.com/blazor/documentation/pdfviewer/getting-started/server-side-application/"">
                documentation section
                </a>.
                </p>"
                }
            },
            new Sample
            {
                Name = "Form Filling",
                Category = "PDF Viewer",
                Directory = "Viewer/PdfViewer",
                Url = "pdf-viewer/form-filling",
                FileName = "FormFilling.razor",
                ActionDescription = new string[] {
                @"<p>This sample explains the form filling features of PDF Viewer and allows you to edit the form fields, download and print the edited form fields PDF documents.</p>"
                },
                Description = new string[] {
                @"<p>
                The PDF Viewer component is used to edit the form fields, download and print the PDF documents with form fields data.
                </p>
                <p>
                In this demo, the PDF Viewer is rendered with PDF form file.
                </p>
                <p>
                More information about PDF Viewer can be found in this
                <a target=""_blank""
                href=""https://ej2.syncfusion.com/blazor/documentation/pdfviewer/getting-started/server-side-application/"">
                documentation section
                </a>.
                </p>"
                }
            }
        };
    }
}
