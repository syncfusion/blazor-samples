using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace BlazorDemos
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
                FileName = "DefaultFunctionalities.razor"
            }, 
            new Sample
            {
                Name = "Form Filling",
                Category = "PDF Viewer",
                Directory = "Viewer/PdfViewer",
                Url = "pdf-viewer/form-filling",
                FileName = "FormFilling.razor"
            },
            new Sample
            {
                Name = "Handwritten Signature",
                Category = "PDF Viewer",
                Directory = "Viewer/PdfViewer",
                Url = "pdf-viewer/handwritten-signature",
                FileName = "HandwrittenSignature.razor"                
            }
        };
    }
}
