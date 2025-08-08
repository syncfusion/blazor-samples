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
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor PDF Viewer Component | View PDF Documents | Syncfusion",
                HeaderText = "Blazor PDF Viewer Example - Default Functionalities",
                MetaDescription = "This Blazor PDF Viewer example demonstrates viewing, zooming, searching, and navigating PDF documents. Easy document navigation with page thumbnails and integrated bookmarks."
            },
            new Sample
            {
                Name = "Read-Only",
                Category = "Document Security",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/read-only",
                FileName = "ReadOnly.razor",
                MetaTitle = "Blazor PDF Viewer Read-Only Mode | Document Security | Syncfusion",
                HeaderText = "Blazor PDF Viewer Example - Read-Only Mode",
                MetaDescription = "This Blazor PDF Viewer example demonstrates read-only mode for PDF documents. Prevent document modifications while allowing viewing and searching for secure document sharing."
            },

            new Sample
            {
                Name = "Document List",
                Category = "File Management",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/document-list",
                FileName = "DocumentList.razor",
                MetaTitle = "Blazor PDF Viewer Document List | Multiple Files | Syncfusion",
                HeaderText = "Blazor PDF Viewer Example - Document List Management",
                MetaDescription = "This Blazor PDF Viewer example demonstrates managing multiple PDF documents with a document list. Switch between documents easily while maintaining viewer state for efficient document management."
            },
#if !(WASM || WEBAPP)
             new Sample
            {
                Name = "Multi-Format Viewer",
                Category = "File Management",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/multi-format-viewer",
                FileName = "MultiFormatViewer.razor",
                MetaTitle = "Blazor Multi-Format Document Viewer | PDF & More | Syncfusion",
                HeaderText = "Blazor PDF Viewer Example - Multi-Format Document Viewer",
                MetaDescription = "This Blazor PDF Viewer example demonstrates viewing multiple document formats beyond PDF. Support for various file types with consistent interface and navigation features."
            },
#endif
             new Sample
            {
                Name = "Redaction",
                Category = "Editor",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/redaction",
                FileName = "Redaction.razor",
                MetaTitle = "Blazor PDF Viewer Redaction | Text & Image Removal | Syncfusion",
                HeaderText = "Blazor PDF Viewer Example - Content Redaction",
                MetaDescription = "This Blazor PDF Viewer example demonstrates permanent redaction of sensitive information from PDF documents. Permanently remove text and images to protect confidential information.",
                Type = SampleType.Updated
            },

            new Sample
            {
                Name = "Custom Toolbar",
                Category = "Toolbar",
                Directory = "Viewer2/PdfViewer2",             
                Url = "pdf-viewer-2/custom-toolbar",
                FileName = "CustomToolbar.razor",
                MetaTitle = "Blazor PDF Viewer Custom Toolbar | User Interface | Syncfusion",
                HeaderText = "Blazor PDF Viewer Example - Custom Toolbar",
                MetaDescription = "This Blazor PDF Viewer example demonstrates how to create a custom toolbar with annotation tools, shapes, stamps, and signature capabilities for enhanced document handling.",
                NotificationDescription = new string[]{ @"The custom toolbar demo has been updated with a new UI and additional functionalities, adding various annotations such as highlights, free text, shapes, stamps, drawings, and handwritten signatures. Users can also edit these annotations within the document." }
            },
            new Sample
            {
                Name = "Primary Toolbar Customization",
                Category = "Toolbar",
                Directory = "Viewer2/PdfViewer2",             
                Url = "pdf-viewer-2/primary-toolbar-customization",
                MetaTitle = "PDF Viewer Primary Toolbar Customization - Syncfusion Demos",
                FileName = "PrimaryToolbarCustomization.razor",
                HeaderText = "Blazor PDF Viewer Example - Primary Toolbar Customization",
                MetaDescription = "This Blazor PDF Viewer example demonstrates how to customize the primary toolbar with your own tools and UI. Add, remove, or modify toolbar items to match your application needs."
            },
            new Sample
            {
                Name = "Form Filling",
                Category = "PDF Form",
                Directory = "Viewer2/PdfViewer2",              
                Url = "pdf-viewer-2/form-filling",
                FileName = "FormFilling.razor",
                MetaTitle = "Blazor PDF Viewer Form Filling | Interactive Forms | Syncfusion",
                HeaderText = "Blazor PDF Viewer Example - PDF Form Filling",
                MetaDescription = "This Blazor PDF Viewer example demonstrates interactive PDF form filling capabilities. Complete, edit, and save form fields including text boxes, checkboxes, radio buttons, and dropdown lists."
            },
            new Sample
            {
                Name = "Form Designer",
                Category = "PDF Form",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/form-designer",
                FileName = "FormDesigner.razor",
                MetaTitle = "Blazor PDF Form Designer | Create & Edit Forms | Syncfusion",
                HeaderText = "Blazor PDF Viewer Example - PDF Form Designer",
                MetaDescription = "This Blazor PDF Viewer example demonstrates creating and designing interactive PDF forms. Add form fields, configure properties, and generate forms for data collection and user input."
            },
            new Sample
            {
                Name = "eSigning Form Designer",
                Category = "PDF Form",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/eSigning-form-designer",
                FileName = "ESigningFormDesigner.razor",
                MetaTitle = "Blazor PDF eSignature Form Designer | Digital Signing | Syncfusion",
                HeaderText = "Blazor PDF Viewer Example - eSigning Form Designer",
                MetaDescription = "This Blazor PDF Viewer example demonstrates creating forms with digital signature fields. Design forms ready for electronic signatures with customizable signature properties.",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "eSigning PDF Forms",
                Category = "PDF Form",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/eSigning-pdf-forms",
                FileName = "ESigningPdfForms.razor",
                MetaTitle = "Blazor PDF Form eSigning | Digital Signatures | Syncfusion",
                HeaderText = "Blazor PDF Viewer Example - eSigning PDF Forms",
                MetaDescription = "This Blazor PDF Viewer example demonstrates digitally signing PDF forms with electronic signatures. Apply, validate, and manage signatures in interactive PDF forms.",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Annotations",
                Category = "Annotation",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/annotations-toolbar",
                FileName = "AnnotationsToolbar.razor",
                MetaTitle = "Blazor PDF Viewer Annotations | Markup Tools | Syncfusion",
                HeaderText = "Blazor PDF Viewer Example - PDF Annotations",
                MetaDescription = "This Blazor PDF Viewer example demonstrates adding and managing annotations in PDF documents. Create highlights, comments, shapes, stamps, and other markup tools for document review."
            },
            new Sample
            {
                Name = "Programmatic Operations",
                Category = "Annotation",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/programmatical-annotations",
                FileName = "ProgrammaticalAnnotations.razor",
                MetaTitle = "Blazor PDF Viewer Programmatic Annotations | API Control | Syncfusion",
                HeaderText = "Blazor PDF Viewer Example - Programmatic Annotation Control",
                MetaDescription = "This Blazor PDF Viewer example demonstrates programmatically adding and managing annotations. Control annotation properties through code for automated document markup and review processes."
            },
            new Sample
            {
                Name = "Handwritten Signature",
                Category = "Signature",
                Directory = "Viewer2/PdfViewer2",              
                Url = "pdf-viewer-2/handwritten-signature",
                FileName = "HandwrittenSignature.razor",
                MetaTitle = "Blazor PDF Viewer Handwritten Signature | Sign Documents | Syncfusion",
                HeaderText = "Blazor PDF Viewer Example - Handwritten Signature",
                MetaDescription = "This Blazor PDF Viewer example demonstrates adding handwritten signatures to PDF documents. Create, place, and manage ink signatures with customizable appearance settings."
            }
           
            
#if !(WASM || WEBAPP)
            ,
            new Sample
            {
                Name = "Invisible Digital Signature",
                Category = "Signature",
                Directory = "Viewer2/PdfViewer2",
                Url = "pdf-viewer-2/invisible-digital-signature",
                MetaTitle = "PDF Viewer Invisible Digital Signature - Syncfusion Demos",
                FileName = "InvisibleDigitalSignature.razor",
                HeaderText = "Blazor PDF Viewer Example - Invisible Digital Signature",
                MetaDescription = "This Blazor PDF Viewer example demonstrates adding cryptographic digital signatures to PDF documents. Apply secure, standards-compliant signatures without visible markings for document authentication."             
            }
           
#endif
            
        };
    };
        
    }