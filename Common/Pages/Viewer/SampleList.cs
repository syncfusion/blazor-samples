#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
                Name = "Custom Toolbar",
                Category = "PDF Viewer",
                Directory = "Viewer/PdfViewer",
                Url = "pdf-viewer/custom-toolbar",
                FileName = "CustomToolbar.razor",
                Type=SampleType.New
            },
            new Sample
            {
                Name = "Right to Left",
                Category = "PDF Viewer",
                Directory = "Viewer/PdfViewer",
                Url = "pdf-viewer/right-to-left",
                FileName = "RightToLeft.razor",
                Type = SampleType.New
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
                Name = "Annotations",
                Category = "PDF Viewer",
                Directory = "Viewer/PdfViewer",
                Url = "pdf-viewer/annotations-toolbar",
                FileName = "AnnotationsToolbar.razor",
                Type=SampleType.New
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
