#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor_MAUI_Demos;
namespace Blazor_MAUI_Demos
{
    internal partial class SampleConfig
    {
        public List<Sample> PDFViewer2 { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "PDF Viewer (NextGen)",
                Directory = "Viewer2/PdfViewer2",              
                Url = "pdf-viewer-2/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Custom Toolbar",
                Category = "PDF Viewer (NextGen)",
                Directory = "Viewer2/PdfViewer2",             
                Url = "pdf-viewer-2/custom-toolbar",
                FileName = "CustomToolbar.razor",
            },
            new Sample
            {
                Name = "Form Filling",
                Category = "PDF Viewer (NextGen)",
                Directory = "Viewer2/PdfViewer2",              
                Url = "pdf-viewer-2/form-filling",
                FileName = "FormFilling.razor"
            },
            new Sample
            {
                Name = "Annotations",
                Category = "PDF Viewer (NextGen)",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/annotations-toolbar",              
                FileName = "AnnotationsToolbar.razor",
            },
            new Sample
            {
                Name = "Handwritten Signature",
                Category = "PDF Viewer (NextGen)",
                Directory = "Viewer2/PdfViewer2",              
                Url = "pdf-viewer-2/handwritten-signature",
                FileName = "HandwrittenSignature.razor"
            }
#if !(WASM || WASM_HOSTED || MAUI)
            ,
            new Sample
            {
                Name = "Invisible Digital Signature",
                Category = "PDF Viewer (NextGen)",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/invisible-digital-signature",
                FileName = "InvisibleDigitalSignature.razor",             
            },
#endif
        };
    };
        
    }

