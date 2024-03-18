#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
                Name = "Read-Only",
                Category = "Document Security",
                Directory = "Viewer/PdfViewer",
                Url = "pdf-viewer/read-only",
                FileName = "ReadOnly.razor",
            },
             new Sample
            {
                Name = "Document List",
                Category = "File Management",
                Directory = "Viewer/PdfViewer",
                Url = "pdf-viewer/document-list",
                FileName = "DocumentList.razor",
            },
            new Sample
            {
                Name = "Custom Toolbar",
                Category = "Toolbar",
                Directory = "Viewer/PdfViewer",
                Url = "pdf-viewer/custom-toolbar",
                FileName = "CustomToolbar.razor",
            },
            new Sample
            {
                Name = "Form Filling",
                Category = "PDF Form",
                Directory = "Viewer/PdfViewer",
                Url = "pdf-viewer/form-filling",
                FileName = "FormFilling.razor"
            },
            new Sample
            {
                Name = "Annotations",
                Category = "Annotation",
                Directory = "Viewer/PdfViewer",
                Url = "pdf-viewer/annotations-toolbar",
                FileName = "AnnotationsToolbar.razor",
            },
            new Sample
            {
                Name = "Handwritten Signature",
                Category = "Signature",
                Directory = "Viewer/PdfViewer",
                Url = "pdf-viewer/handwritten-signature",
                FileName = "HandwrittenSignature.razor"                
            }
           
           
#if !(WASM || WEBAPP)
            ,
            new Sample
            {
                Name = "Invisible Digital Signature",
                Category = "Signature",
                Directory = "Viewer/PdfViewer",
                Url = "pdf-viewer/invisible-digital-signature",
                FileName = "InvisibleDigitalSignature.razor",               
            }            
#endif
           
        };
    }
}
