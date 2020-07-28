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
                Type = SampleType.Updated
            }, new Sample
            {
                Name = "Right To Left",
                Category = "PDF Viewer",
                Directory = "Viewer/PdfViewer",
                Url = "pdf-viewer/right-to-left",
                FileName = "RightToLeft.razor"
            },
            new Sample
            {
                Name = "Form Filling",
                Category = "PDF Viewer",
                Directory = "Viewer/PdfViewer",
                Url = "pdf-viewer/form-filling",
                FileName = "FormFilling.razor"
            }
        };
    }
}
