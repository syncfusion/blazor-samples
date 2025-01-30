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
                Category = "PDF Viewer",
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
                FileName = "ReadOnly.razor"
            },

            new Sample
            {
                Name = "Document List",
                Category = "File Management",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/document-list",
                FileName = "DocumentList.razor"

            },
#if !(WASM || WEBAPP)
             new Sample
            {
                Name = "Multi-Format Viewer",
                Category = "File Management",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/multi-format-viewer",
                FileName = "MultiFormatViewer.razor"
            },
#endif
             new Sample
            {
                Name = "Redaction",
                Category = "Editor",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/redaction",
                FileName = "Redaction.razor"
            },

            new Sample
            {
                Name = "Custom Toolbar",
                Category = "Toolbar",
                Directory = "Viewer2/PdfViewer2",             
                Url = "pdf-viewer-2/custom-toolbar",
                FileName = "CustomToolbar.razor",
                NotificationDescription = new string[]{ @"The custom toolbar demo has been updated with a new UI and additional functionalities, adding various annotations such as highlights, free text, shapes, stamps, drawings, and handwritten signatures. Users can also edit these annotations within the document." }
            },
            new Sample
            {
                Name = "Primary Toolbar Customization",
                Category = "Toolbar",
                Directory = "Viewer2/PdfViewer2",             
                Url = "pdf-viewer-2/primary-toolbar-customization",
                FileName = "PrimaryToolbarCustomization.razor",
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
                FileName = "AnnotationsToolbar.razor"
            },
            new Sample
            {
                Name = "Programmatic Operations",
                Category = "Annotation",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/programmatical-annotations",
                FileName = "ProgrammaticalAnnotations.razor"
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

