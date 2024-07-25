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
                NotificationDescription = new string[]{ @"Incorporated the sample to showcase how to make a PDF document secure in a read-only mode without the need for editing." }
            },

            new Sample
            {
                Name = "Document List",
                Category = "File Management",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/document-list",
                FileName = "DocumentList.razor",
                NotificationDescription = new string[]{ @"Included the example to demonstrate how to showcase a list of documents in a grid layout and open each document for viewing or editing utilizing the PDF Viewer component within a Dialog." }

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
                Type=SampleType.New,
                FileName = "Redaction.razor",
                NotificationDescription = new string[]{ @"We have included a demonstration on how to apply redaction to the PDF viewer document. This feature helps to hide sensitive or confidential information in PDF files with the assistance of the .NET PDF library." }
            },

            new Sample
            {
                Name = "Custom Toolbar",
                Category = "Toolbar",
                Directory = "Viewer2/PdfViewer2",             
                Url = "pdf-viewer-2/custom-toolbar",
                Type=SampleType.Updated,
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
                Type = SampleType.None,
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
                Type = SampleType.Updated,              
                FileName = "AnnotationsToolbar.razor",
                NotificationDescription = new string[]{ @"This sample illustrates adding all the annotation types programmatically. Previously there was no support to add annotations programmatically but now the annotations are added programmatically." }
            },
            new Sample
            {
                Name = "Programmatic Operations",
                Category = "Annotation",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/programmatical-annotations",
                Type=SampleType.New,
                FileName = "ProgrammaticalAnnotations.razor",
                NotificationDescription = new string[]{ @"This example demonstrates how to programmatically create or edit various types of annotations in the SfPdfViewer. You can also programmatically insert new annotations or update existing ones." }

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

