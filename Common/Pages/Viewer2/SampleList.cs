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
                Name = "Read-Only",
                Category = "Document Security",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/read-only",
                FileName = "ReadOnly.razor",
                Type=SampleType.New,
                NotificationDescription = new string[]{ @"Incorporated the sample to showcase how to make a PDF document secure in a read-only mode without the need for editing." }
            },

            new Sample
            {
                Name = "Document List",
                Category = "File Management",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/document-list",
                FileName = "DocumentList.razor",
                Type=SampleType.New,
                NotificationDescription = new string[]{ @"Included the example to demonstrate how to showcase a list of documents in a grid layout and open each document for viewing or editing utilizing the PDF Viewer component within a Dialog." }

            },
            new Sample
            {
                Name = "Custom Toolbar",
                Category = "Toolbar",
                Directory = "Viewer2/PdfViewer2",             
                Url = "pdf-viewer-2/custom-toolbar",
                FileName = "CustomToolbar.razor",
            },
            new Sample
            {
                Name = "Form Filling",
                Category = "PDF Form",
                Directory = "Viewer2/PdfViewer2",              
                Url = "pdf-viewer-2/form-filling",
                FileName = "FormFilling.razor"
            },
            new Sample
            {
                Name = "Annotations",
                Category = "Annotation",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/annotations-toolbar",              
                FileName = "AnnotationsToolbar.razor",
            },
            new Sample
            {
                Name = "Handwritten Signature",
                Category = "Signature",
                Directory = "Viewer2/PdfViewer2",              
                Url = "pdf-viewer-2/handwritten-signature",
                FileName = "HandwrittenSignature.razor"
            }
           
            
#if !(WASM || WEBAPP)
            ,
            new Sample
            {
                Name = "Invisible Digital Signature",
                Category = "Signature",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/invisible-digital-signature",
                FileName = "InvisibleDigitalSignature.razor",             
            }
           
#endif
            
        };
    };
        
    }

