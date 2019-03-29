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
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "CustomToolbar",
                Category = "PdfViewer",
                Directory = "Viewer/PdfViewer",
                Url = "Viewer/CustomToolbar",
                FileName = "CustomToolbar.cshtml",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "RightToLeft",
                Category = "PdfViewer",
                Directory = "Viewer/PdfViewer",
                Url = "Viewer/RightToLeft",
                FileName = "RightToLeft.cshtml",
                Type = SampleType.New
            }
        };
    }
}
