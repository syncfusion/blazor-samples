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
using BlazorDemos;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {

        public List<Sample> DocIO { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Hello World",
                Category = "Getting Started",
                Directory = "DocumentProcessing/Word",
                Url = "word/hello-world",
                FileName = "HelloWorld.razor",
                MetaDescription = "This sample demonstrates how to create a simple Word document with text, image and table using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="HelloWorld",
                        FileName="HelloWorld.razor"
                    },
                    new SourceCollection
                    {
                        Id="HelloWorldService",
                        FileName="HelloWorldService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Sales Invoice",
                Category = "Product Showcase",
                Directory = "DocumentProcessing/Word",
                Url = "word/sales-invoice",
                FileName = "SalesInvoice.razor",
                MetaDescription = "This sample demonstrates the generation of sales invoice from an input Word template using Mail Merge functionality of Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="SalesInvoice",
                        FileName="SalesInvoice.razor"
                    },
                    new SourceCollection
                    {
                        Id="SalesInvoiceService",
                        FileName="SalesInvoiceService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Update Fields",
                Category = "Product Showcase",
                Directory = "DocumentProcessing/Word",
                Url = "word/update-fields",
                FileName = "UpdateFields.razor",
                MetaDescription = "This sample demonstrates how to update the fields available in the Word document using Essential DocIO. Here, in the example, merge fields and formula fields are used together to populate the net profit or loss.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="UpdateFields",
                        FileName="UpdateFields.razor"
                    },
                    new SourceCollection
                    {
                        Id="UpdateFieldsService",
                        FileName="UpdateFieldsService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Advanced Replace",
                Category = "Editing",
                Directory = "DocumentProcessing/Word",
                Url = "word/advanced-replace",
                FileName = "AdvancedReplace.razor",
                MetaDescription = "This sample demonstrates how to replace a specific content in the Word document with another document using the Find and Replace functionality of Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="AdvancedReplace",
                        FileName="AdvancedReplace.razor"
                    },
                    new SourceCollection
                    {
                        Id="AdvancedReplaceService",
                        FileName="AdvancedReplaceService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Bookmark Navigation",
                Category = "Editing",
                Directory = "DocumentProcessing/Word",                
                Url = "word/bookmark-navigation",
                FileName = "BookmarkNavigation.razor",
                MetaDescription = "This sample demonstrates how to navigate between the bookmarks in a Word document and edit its content using Bookmark Navigation functionality of Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="BookmarkNavigation",
                        FileName="BookmarkNavigation.razor"
                    },
                    new SourceCollection
                    {
                        Id="BookmarkNavigationService",
                        FileName="BookmarkNavigationService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Forms",
                Category = "Editing",
                Directory = "DocumentProcessing/Word",
                Url = "word/forms",
                FileName = "Forms.razor",
                MetaDescription = "This sample demonstrates how to create a simple job application form and fill the form using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Forms",
                        FileName="Forms.razor"
                    },
                    new SourceCollection
                    {
                        Id="FormsService",
                        FileName="FormsService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Form filling and Protection",
                Category = "Content Control",
                Directory = "DocumentProcessing/Word",
                Url = "word/formfillingandprotection",
                FileName = "FormFillingAndProtection.razor",
                MetaDescription = "This sample demonstrates how to fill a form and protect the content controls in an existing Word document using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FormFillingAndProtection",
                        FileName="FormFillingAndProtection.razor"
                    },
                    new SourceCollection
                    {
                        Id="FormFillingAndProtectionService",
                        FileName="FormFillingAndProtectionService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Create Equation",
                Category = "Mathematical Equation",
                Directory = "DocumentProcessing/Word",
                Url = "word/create-equation",
                FileName = "CreateEquation.razor",
                MetaDescription = "This sample demonstrates how to create a Word document with mathematical equations using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CreateEquation",
                        FileName="CreateEquation.razor"
                    },
                    new SourceCollection
                    {
                        Id="CreateEquationService",
                        FileName="CreateEquationService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Edit Equation",
                Category = "Mathematical Equation",
                Directory = "DocumentProcessing/Word",
                Url = "word/edit-equation",
                FileName = "EditEquation.razor",
                MetaDescription = "This sample demonstrates how to modify a mathematical equation in a Word document using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EditEquation",
                        FileName="EditEquation.razor"
                    },
                    new SourceCollection
                    {
                        Id="EditEquationService",
                        FileName="EditEquationService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Create using LaTeX",
                Category = "Mathematical Equation",
                Directory = "DocumentProcessing/Word",
                Url = "word/create-using-latex",
                FileName = "CreateUsingLaTeX.razor",
                MetaDescription = "This example demonstrates the create equation using LaTeX in Blazor Word (DocIO) library. Explore here for more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CreateUsingLaTeX",
                        FileName="CreateUsingLaTeX.razor"
                    },
                    new SourceCollection
                    {
                        Id="CreateUsingLaTeXService",
                        FileName="CreateUsingLaTeXService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Edit using LaTeX",
                Category = "Mathematical Equation",
                Directory = "DocumentProcessing/Word",
                Url = "word/edit-using-latex",
                Type = SampleType.New,
                FileName = "EditUsingLaTeX.razor",
                MetaDescription = "This example demonstrates the edit equation using LaTeX in Blazor Word (DocIO) library. Explore here for more details.",
                NotificationDescription = new string[]
                {
                    @"Provided support to edit equation using LaTeX in Word document."
                },
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EditUsingLaTeX",
                        FileName="EditUsingLaTeX.razor"
                    },
                    new SourceCollection
                    {
                        Id="EditUsingLaTeXService",
                        FileName="EditUsingLaTeXService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Bookmarks",
                Category = "Insert Content",
                Directory = "DocumentProcessing/Word",
                Url = "word/bookmarks",
                FileName = "Bookmarks.razor",
                MetaDescription = "This sample demonstrates how to insert bookmarks into the Word document using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Bookmarks",
                        FileName="Bookmarks.razor"
                    },
                    new SourceCollection
                    {
                        Id="BookmarksService",
                        FileName="BookmarksService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Header and Footer",
                Category = "Insert Content",
                Directory = "DocumentProcessing/Word",
                Url = "word/header-and-footer",
                FileName = "HeaderandFooter.razor",
                MetaDescription = "This sample demonstrates how to insert headers and footers to the Word document using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="HeaderandFooter",
                        FileName="HeaderandFooter.razor"
                    },
                    new SourceCollection
                    {
                        Id="HeaderandFooterService",
                        FileName="HeaderandFooterService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Image Insertion",
                Category = "Insert Content",
                Directory = "DocumentProcessing/Word",
                Url = "word/image-insertion",
                FileName = "ImageInsertion.razor",
                MetaDescription = "This sample demonstrates how to insert images into the Word document using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ImageInsertion",
                        FileName="ImageInsertion.razor"
                    },
                    new SourceCollection
                    {
                        Id="ImageInsertionService",
                        FileName="ImageInsertionService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Employee Report",
                Category = "Mail Merge",
                Directory = "DocumentProcessing/Word",
                Url = "word/employee-report",
                FileName = "EmployeeReport.razor",
                MetaDescription = "This sample demonstrates how to generate an employee report using Mail merge functionality of Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EmployeeReport",
                        FileName="EmployeeReport.razor"
                    },
                    new SourceCollection
                    {
                        Id="EmployeeReportService",
                        FileName="EmployeeReportService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Insert OLE Object",
                Category = "Insert Content",
                Directory = "DocumentProcessing/Word",
                Url = "word/insert-ole-object",
                FileName = "InsertOLEObject.razor",
                MetaDescription = "This sample demonstrates how to insert OLE Object into the Word document using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="InsertOLEObject",
                        FileName="InsertOLEObject.razor"
                    },
                    new SourceCollection
                    {
                        Id="InsertOLEObjectService",
                        FileName="InsertOLEObjectService.cs"
                    }
                },
            },
            new Sample
            {
                Name = "Letter Format",
                Category = "Mail Merge",
                Directory = "DocumentProcessing/Word",
                Url = "word/letter-format",
                FileName = "LetterFormat.razor",
                MetaDescription = "This sample demonstrates how to generate a letter using Mail merge functionality of Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="LetterFormat",
                        FileName="LetterFormat.razor"
                    },
                    new SourceCollection
                    {
                        Id="LetterFormatService",
                        FileName="LetterFormatService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Mail Merge Event",
                Category = "Mail Merge",
                Directory = "DocumentProcessing/Word",
                Url = "word/mail-merge-event",
                FileName = "MailMergeEvent.razor",
                MetaDescription = "This sample demonstrates how to format the Mail merged data using Mail merge events of Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="MailMergeEvent",
                        FileName="MailMergeEvent.razor"
                    },
                    new SourceCollection
                    {
                        Id="MailMergeEventService",
                        FileName="MailMergeEventService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Nested Mail Merge",
                Category = "Mail Merge",
                Directory = "DocumentProcessing/Word",
                Url = "word/nested-mail-merge",
                FileName = "NestedMailMerge.razor",
                MetaDescription = "This sample demonstrates how to perform Mail merge for nested groups in Word document using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="NestedMailMerge",
                        FileName="NestedMailMerge.razor"
                    },
                    new SourceCollection
                    {
                        Id="NestedMailMergeService",
                        FileName="NestedMailMergeService.cs"
                    }
                }
            },
#if !(WASM) && !WEBAPP
            new Sample
            {
                Name = "Word to PDF",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/word-to-pdf",
                FileName = "WordToPDF.razor",
                MetaDescription = "This sample illustrates how to convert Word document to PDF using Essential DocIO and Essential PDF.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WordToPDF",
                        FileName="WordToPDF.razor"
                    },
                    new SourceCollection
                    {
                        Id="WordToPDFService",
                        FileName="WordToPDFService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Word to PDF/A",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/word-to-pdfa",
                FileName = "WordToPDFA.razor",
                MetaDescription = "This sample illustrates how to set the Pdf conformance level while converting Word to PDF using Essential DocIO and Essential PDF.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WordToPDFA",
                        FileName="WordToPDFA.razor"
                    },
                    new SourceCollection
                    {
                        Id="WordToPDFAService",
                        FileName="WordToPDFAService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Word to PDF/UA",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/word-to-pdfua",
                FileName = "WordToPDFUA.razor",
                MetaDescription = "This sample illustrates how to preserve document structured tags in the converted PDF using Essential DocIO and Essential PDF.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WordToPDFUA",
                        FileName="WordToPDFUA.razor"
                    },
                    new SourceCollection
                    {
                        Id="WordToPDFUAService",
                        FileName="WordToPDFUAService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Word to Image",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/word-to-image",
                FileName = "WordToImage.razor",
                MetaDescription = "This sample illustrates how to convert Word document to Image using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WordToImage",
                        FileName="WordToImage.razor"
                    },
                    new SourceCollection
                    {
                        Id="WordToImageService",
                        FileName="WordToImageService.cs"
                    }
                }
            },
#endif
            new Sample
            {
                Name = "Word to Markdown",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/word-to-markdown",
                FileName = "WordToMarkdown.razor",
                MetaDescription = "This sample demonstrates how to convert the Word document to Markdown using .NET Word (DocIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WordToMarkdown",
                        FileName="WordToMarkdown.razor"
                    },
                    new SourceCollection
                    {
                        Id="WordToMarkdownTService",
                        FileName="WordToMarkdownService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Markdown to Word",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/markdown-to-word",
                FileName = "MarkdownToWord.razor",
                MetaDescription = "This sample demonstrates how to convert the Markdown file to Word document using .NET Word (DocIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="MarkdownToWord",
                        FileName="MarkdownToWord.razor"
                    },
                    new SourceCollection
                    {
                        Id="MarkdownToWordService",
                        FileName="MarkdownToWordService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "RTF to Word",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/rtf-to-doc",
                FileName = "RTFtoDOC.razor",
                MetaDescription = "This sample demonstrates how to convert the RTF file to Word document using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RTFtoDOC",
                        FileName="RTFtoDOC.razor"
                    },
                    new SourceCollection
                    {
                        Id="RTFtoDOCService",
                        FileName="RTFtoDOCService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Word to WordML",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/word-to-wordml",
                FileName = "WordToWordML.razor",
                MetaDescription = "This sample demonstrates how to convert the Word document to Word processing XML using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WordToWordML",
                        FileName="WordToWordML.razor"
                    },
                    new SourceCollection
                    {
                        Id="WordToWordMLService",
                        FileName="WordToWordMLService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "WordML to Word",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/wordml-to-word",
                FileName = "WordMLtoWord.razor",
                MetaDescription = "This sample demonstrates how to convert the Word processing XML to Word document using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WordMLtoWord",
                        FileName="WordMLtoWord.razor"
                    },
                    new SourceCollection
                    {
                        Id="WordMLtoWordService",
                        FileName="WordMLtoWordService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Word to ODT",
                Category = "Import and Export",
                Directory = "DocumentProcessing/Word",
                Url = "word/word-to-odt",
                FileName = "WordToODT.razor",
                MetaDescription = "This sample demonstrates how to convert the Word document to ODT using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WordToODT",
                        FileName="WordToODT.razor"
                    },
                    new SourceCollection
                    {
                        Id="WordToODTService",
                        FileName="WordToODTService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Track Changes",
                Category = "Review",
                Directory = "DocumentProcessing/Word",
                Url = "word/track-changes",
                FileName = "TrackChanges.razor",
                MetaDescription = "This sample demonstrates how to accept or reject the tracked changes in the Word document using Essential DocIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TrackChanges",
                        FileName="TrackChanges.razor"
                    },
                    new SourceCollection
                    {
                        Id="TrackChangesService",
                        FileName="TrackChangesService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Compare Documents",
                Category = "Review",
                Directory = "DocumentProcessing/Word",
                Url = "word/compare-documents",
                FileName = "CompareDocuments.razor",
                MetaDescription = "This example demonstrates comparing two Word documents in Blazor Word (DocIO) Library. Explore here for more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CompareDocuments",
                        FileName="CompareDocuments.razor"
                    },
                    new SourceCollection
                    {
                        Id="CompareDocumentsService",
                        FileName="CompareDocumentsService.cs"
                    }
                }
            },
#if !(WASM) && !WEBAPP
            new Sample
            {
                Name = "Table of Content",
                Category = "Reference",
                Directory = "DocumentProcessing/Word",
                Url = "word/table-of-content",
                FileName = "TableofContent.razor",
                MetaDescription = "DocIO supports to insert Table of Contents based on custom and default heading styles, include page numbers, hyperlinks to easily navigate to specific topic or heading within the document, specify the outline levels.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TableofContent",
                        FileName="TableofContent.razor"
                    },
                    new SourceCollection
                    {
                        Id="TableofContentService",
                        FileName="TableofContentService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Table of Figures",
                Category = "Reference",
                Directory = "DocumentProcessing/Word",
                Url = "word/table-of-figures",
                FileName = "TableOfFigures.razor",
                MetaDescription = "This example demonstrates the Table of Figures in Blazor Word Library (DocIO). Explore here for more details.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TableOfFigures",
                        FileName="TableOfFigures.razor"
                    },
                    new SourceCollection
                    {
                        Id="TableOfFiguresService",
                        FileName="TableOfFiguresService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Encrypt and Decrypt",
                Category = "Security",
                Directory = "DocumentProcessing/Word",
                Url = "word/encrypt-and-decrypt",
                FileName = "EncryptDecrypt.razor",
                MetaDescription = "DocIO supports to encrypt a Word document with password that restrict others from accessing or modifying confidential contents. You can also open an encrypted Word document using DocIO with valid password.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EncryptDecrypt",
                        FileName="EncryptDecrypt.razor"
                    },
                    new SourceCollection
                    {
                        Id="EncryptDecryptService",
                        FileName="EncryptDecryptService.cs"
                    }
                }
            }
#endif
        };
        public List<Sample> Presentation { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Create Presentation",
                Category = "Getting Started",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/getting-started",
                FileName = "GettingStarted.razor",
                MetaDescription = "This sample demonstrates how to create slides with simple text in a PowerPoint presentation.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="GettingStarted",
                        FileName="GettingStarted.razor"
                    },
                    new SourceCollection
                    {
                        Id="GettingStartedService",
                        FileName="GettingStartedService.cs"
                    }
                }
            },
#if !(WASM) && !WEBAPP
            new Sample
            {
                Name = "PowerPoint Viewer",
                Category = "Showcase Presentation",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/powerpoint-viewer",
                FileName = "PowerPointViewer.razor",
                MetaDescription = "This sample demonstrates how to view the PowerPoint presentation through PdfViewer by converting it as PDF using Syncfusion Presentation library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="PowerPointViewer",
                        FileName="PowerPointViewer.razor"
                    },
                    new SourceCollection
                    {
                        Id="PowerPointViewerService",
                        FileName="PowerPointViewerService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "PPTX To Image",
                Category = "Conversion",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/pptx-to-image",
                FileName = "PPTXToImage.razor",
                Type = SampleType.Updated,
                MetaDescription = "This sample demonstrates how to convert the PowerPoint slide to an image.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="PPTXToImage",
                        FileName="PPTXToImage.razor"
                    },
                    new SourceCollection
                    {
                        Id="PPTXToImageService",
                        FileName="PPTXToImageService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "PPTX To PDF",
                Category = "Conversion",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/pptx-to-pdf",
                FileName = "PPTXToPDF.razor",
                Type = SampleType.Updated,
                MetaDescription = "This sample demonstrates how to convert a PowerPoint presentation to PDF.",
                NotificationDescription = new string[]
                {
                    @"Provided support to preserve the highlight color in PowerPoint Presentation to PDF and image conversions."
                },
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="PPTXToPDF",
                        FileName="PPTXToPDF.razor"
                    },
                    new SourceCollection
                    {
                        Id="PPTXToPDFService",
                        FileName="PPTXToPDFService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "PPTX To PDF/A",
                Category = "Conversion",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/pptx-to-pdfa",
                FileName = "PPTXToPDFA.razor",
                MetaDescription = "This sample demonstrates how to set the PDF conformance level while converting PowerPoint presentation to PDF.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="PPTXToPDFA",
                        FileName="PPTXToPDFA.razor"
                    },
                    new SourceCollection
                    {
                        Id="PPTXToPDFAService",
                        FileName="PPTXToPDFAService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "PPTX To PDF/UA",
                Category = "Conversion",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/pptx-to-pdfua",
                FileName = "PPTXToPDFUA.razor",
                MetaDescription = "This sample demonstrates how to preserve document structured tags in the converted PDF.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="PPTXToPDFUA",
                        FileName="PPTXToPDFUA.razor"
                    },
                    new SourceCollection
                    {
                        Id="PPTXToPDFUAService",
                        FileName="PPTXToPDFUAService.cs"
                    }
                }
            },
#endif
	    new Sample
            {
                Name = "Find and Replace",
                Category = "Editing",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/find-and-replace",
                FileName = "FindAndReplace.razor",
                MetaDescription = "This sample demonstrates how to replace a specific text in the PowerPoint presentation with another text using Find and Replace functionality of .NET PowerPoint  library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FindToReplace",
                        FileName="FindAndReplace.razor"
                    },
                    new SourceCollection
                    {
                        Id="FindAndReplaceService",
                        FileName="FindAndReplaceService.cs"
                    }
                }
            },
	    new Sample
            {
                Name = "Find and Highlight",
                Category = "Editing",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/find-and-highlight",
                FileName = "FindAndHighlight.razor",
#if !(WASM) && !WEBAPP
                Type = SampleType.Updated,
#endif
                MetaDescription = "This sample demonstrates how to find a specific text and highlight it in an existing PowerPoint presentation using Find functionality of .NET PowerPoint library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FindToHighlight",
                        FileName="FindAndHighlight.razor"
                    },
                    new SourceCollection
                    {
                        Id="FindAndHighlightService",
                        FileName="FindAndHighlightService.cs"
                    }
                }
            },
#if !(WASM) && !WEBAPP
            new Sample
            {
                Name = "Encrypt and Decrypt",
                Category = "Security",
                Directory = "DocumentProcessing/PowerPoint",
                Type = SampleType.None,
                Url = "powerpoint/encrypt-and-decrypt",
                MetaDescription = "This sample demonstrates how to encrypt and decrypt the PowerPoint document using Essential Presentation.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EncryptAndDecrypt",
                        FileName="EncryptAndDecrypt.razor"
                    },
                    new SourceCollection
                    {
                        Id="EncryptAndDecryptService",
                        FileName="EncryptAndDecryptService.cs"
                    }
                },
                FileName = "EncryptAndDecrypt.razor"
            },
            new Sample
            {
                Name = "Write Protection",
                Category = "Security",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/write-protection",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WriteProtection",
                        FileName="WriteProtection.razor"
                    },
                    new SourceCollection
                    {
                        Id="WriteProtectionService",
                        FileName="WriteProtectionService.cs"
                    }
                },
                FileName = "WriteProtection.razor",
                MetaDescription = "This sample demonstrates how to set write protection for a PowerPoint presentation with password."
            },
#endif
            new Sample
            {
                Name = "Image",
                Category = "Slide Elements",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/image",
                FileName = "Image.razor",
                MetaDescription = "This sample demonstrates how to add and format images in PowerPoint Presentation.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Image",
                        FileName="Image.razor"
                    },
                    new SourceCollection
                    {
                        Id="ImageService",
                        FileName="ImageService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Chart",
                Category = "Slide Elements",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/chart",
                FileName = "Chart.razor",
                MetaDescription = "This sample demonstrates how to create charts in a presentation using PowerPoint presentation.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Chart",
                        FileName="Chart.razor"
                    },
                    new SourceCollection
                    {
                        Id="ChartService",
                        FileName="ChartService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Slide",
                Category = "Slide Elements",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/slide",
                FileName = "Slide.razor",
                MetaDescription = "This sample demonstrates how to create slides with simple text, table and image in a PowerPoint presentation.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Slide",
                        FileName="Slide.razor"
                    },
                    new SourceCollection
                    {
                        Id="SlideService",
                        FileName="SlideService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "SmartArt",
                Category = "Slide Elements",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/smartart",
                FileName = "SmartArt.razor",
                MetaDescription = "This sample demonstrates how to create SmartArt diagram in a PowerPoint presentation.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="SmartArt",
                        FileName="SmartArt.razor"
                    },
                    new SourceCollection
                    {
                        Id="SmartArtService",
                        FileName="SmartArtService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Table",
                Category = "Slide Elements",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/table",
                FileName = "Table.razor",
                MetaDescription = "This sample demonstrates how to add tables in a PowerPoint presentation.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Table",
                        FileName="Table.razor"
                    },
                    new SourceCollection
                    {
                        Id="TableService",
                        FileName="TableService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Comment",
                Category = "Slide Elements",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/comment",
                FileName = "Comment.razor",
                MetaDescription = "This sample demonstrates how to add comments to a presentation slide.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Comment",
                        FileName="Comment.razor"
                    },
                    new SourceCollection
                    {
                        Id="CommentService",
                        FileName="CommentService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Connector",
                Category = "Slide Elements",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/connector",
                FileName = "Connector.razor",
                MetaDescription = "This sample demonstrates how to insert the connectors in a PowerPoint slide.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Connector",
                        FileName="Connector.razor"
                    },
                    new SourceCollection
                    {
                        Id="ConnectorService",
                        FileName="ConnectorService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "OLE Object",
                Category = "Slide Elements",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/ole-object",
                FileName = "OLEObject.razor",
                MetaDescription = "This sample demonstrates how to insert and open a OLE Object in PowerPoint presentation.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="OLEObject",
                        FileName="OLEObject.razor"
                    },
                    new SourceCollection
                    {
                        Id="OLEObjectService",
                        FileName="OLEObjectService.cs"
                    }
                }
            },            
            new Sample
            {
                Name = "Create Animation",
                Category = "Animation",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/create-animation",
                FileName = "CreateAnimation.razor",
                MetaDescription = "This sample demonstrates how to add different animation effect for shapes.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CreateAnimation",
                        FileName="CreateAnimation.razor"
                    },
                    new SourceCollection
                    {
                        Id="CreateAnimationService",
                        FileName="CreateAnimationService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Modify Animation",
                Category = "Animation",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/modify-animation",
                FileName = "ModifyAnimation.razor",
                MetaDescription = "This sample demonstrates how to modify the animation effect for shapes.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ModifyAnimation",
                        FileName="ModifyAnimation.razor"
                    },
                    new SourceCollection
                    {
                        Id="ModifyAnimationService",
                        FileName="ModifyAnimationService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Slide Transition",
                Category = "Transition",
                Directory = "DocumentProcessing/PowerPoint",
                Url = "powerpoint/slide-transition",
                FileName = "SlideTransition.razor",
                MetaDescription = "This sample demonstrates how to create slide transition effects in PowerPoint presentation.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="SlideTransition",
                        FileName="SlideTransition.razor"
                    },
                    new SourceCollection
                    {
                        Id="SlideTransitionService",
                        FileName="SlideTransitionService.cs"
                    }
                }
            }		
        };

        public List<Sample> XlsIO { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Create",
                Category = "Getting Started",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/create-excel",
                MetaDescription = "This sample demonstrates how to create a simple spreadsheet document using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Create",
                        FileName="Create.razor"
                    },
                    new SourceCollection
                    {
                        Id="CreateService",
                        FileName="CreateService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Attendance Tracker",
                Category = "Product Showcase",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/attendance-tracker",
                MetaDescription = "This sample demonstrates how to use AttendanceTracker in spreadsheets using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="AttendanceTracker",
                        FileName="AttendanceTracker.razor"
                    },
                    new SourceCollection
                    {
                        Id="AttendanceTrackerService",
                        FileName="AttendanceTrackerService.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Call Center Dashboard",
                Category = "Product Showcase",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/call-center-dashboard",
                MetaDescription = "This sample demonstrates how to use CallCenterDashboard in spreadsheets using XlsIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CallCenterDashboard",
                        FileName="CallCenterDashboard.razor"
                    },
                    new SourceCollection
                    {
                        Id="CallCenterDashboardService",
                        FileName="CallCenterDashboardService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Expenses Report",
                Category = "Product Showcase",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/expenses-report",
                MetaDescription = "This sample demonstrates how to create a simple Excel report for expenses with data, chart, formula, and cell formatting using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ExpensesReport",
                        FileName="ExpensesReport.razor"
                    },
                    new SourceCollection
                    {
                        Id="ExpensesReportService",
                        FileName="ExpensesReportService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Yearly Sales",
                Category = "Product Showcase",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/yearly-sales",
                MetaDescription = "This sample demonstrates how to create a simple Excel report for yearly sales with data, charts, formulas, and cell formatting using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="YearlySales",
                        FileName="YearlySales.razor"
                    },
                    new SourceCollection
                    {
                        Id="YearlySalesService",
                        FileName="YearlySalesService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Format Cells",
                Category = "Formatting",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/format-cells",
                MetaDescription = "This sample demonstrates how to apply formatting to the cells using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FormatCells",
                        FileName="FormatCells.razor"
                    },
                    new SourceCollection
                    {
                        Id="FormatCellsService",
                        FileName="FormatCellsService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Conditional Formatting",
                Category = "Formatting",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/conditional-formatting",
                MetaDescription = "This sample demonstrates how to apply conditional formats using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ConditionalFormatting",
                        FileName="ConditionalFormatting.razor"
                    },
                    new SourceCollection
                    {
                        Id="ConditionalFormattingService",
                        FileName="ConditionalFormattingService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Import HTML Table",
                Category = "Data Binding",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/import-html-table",
                MetaDescription = "This sample demonstrates how to import HTML table to worksheet using Essential XlsIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ImportHTMLTable",
                        FileName="ImportHTMLTable.razor"
                    },
                    new SourceCollection
                    {
                        Id="ImportHTMLTable",
                        FileName="ImportHTMLTableService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Chart Worksheet",
                Category = "Charts",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/chart-worksheet",
                MetaDescription = "This sample demonstrates how to create a simple chart sheet using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ChartWorksheet",
                        FileName="ChartWorksheet.razor"
                    },
                    new SourceCollection
                    {
                        Id="ChartWorksheetService",
                        FileName="ChartWorksheetService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Embedded Chart",
                Category = "Charts",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/embedded-chart",
                MetaDescription = "This sample demonstrates how to create a simple chart using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EmbeddedChart",
                        FileName="EmbeddedChart.razor"
                    },
                    new SourceCollection
                    {
                        Id="EmbeddedChartService",
                        FileName="EmbeddedChartService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Sparklines",
                Category = "Charts",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/sparklines",
                MetaDescription = "This sample demonstrates how to create sparkline charts using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Sparklines",
                        FileName="Sparklines.razor"
                    },
                    new SourceCollection
                    {
                        Id="SparklinesService",
                        FileName="SparklinesService.cs"
                    }
                }
            },
#if !WASM && !WEBAPP
            new Sample
            {
                Name = "Formulas",
                Category = "Excel Formulas",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/formulas",
                MetaDescription = "This sample demonstrates how to use formulas in spreadsheets using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Formulas",
                        FileName="Formulas.razor"
                    },
                    new SourceCollection
                    {
                        Id="FormulasService",
                        FileName="FormulasService.cs"
                    }
                }
            },
#endif
            new Sample
            {
                Name = "Data Validation",
                Category = "Data Management",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/data-validation",
                MetaDescription = "This sample demonstrates how to use data validation in spreadsheets using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DataValidation",
                        FileName="DataValidation.razor"
                    },
                    new SourceCollection
                    {
                        Id="DataValidationService",
                        FileName="DataValidationService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Form Controls",
                Category = "Data Management",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/form-controls",
                MetaDescription = "This sample demonstrates how to use form controls in spreadsheet using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FormControls",
                        FileName="FormControls.razor"
                    },
                    new SourceCollection
                    {
                        Id="FormControlsService",
                        FileName="FormControlsService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Slicer",
                Category = "Data Management",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/slicer",
                MetaDescription = "This sample shows how to create and use slicers using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Slicer",
                        FileName="Slicer.razor"
                    },
                    new SourceCollection
                    {
                        Id="SlicerService",
                        FileName="SlicerService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "What-If Analysis" ,
                Category = "Data Management",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/WhatIfAnalysis",
                MetaDescription = "The sample shows how to create different scenarios of What-If Analysis in Blazor using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WhatIfAnalysis",
                        FileName="WhatIfAnalysis.razor"
                    },
                    new SourceCollection
                    {
                        Id="WhatIfAnalysisService",
                        FileName="WhatIfAnalysisService.cs"
                    }
                }
            },
#if !WASM && !WEBAPP
            new Sample
            {
                Name = "Worksheet To Image",
                Category = "Conversions",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/worksheet-to-image",
                MetaDescription = "This sample demonstrates how to convert worksheets to image using .NET Excel (XlsIO) library.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WorksheetToImage",
                        FileName="WorksheetToImage.razor"
                    },
                    new SourceCollection
                    {
                        Id="WorksheetToImageService",
                        FileName="WorksheetToImageService.cs"
                    }
                }
            },
#endif
            new Sample
            {
                Name = "Worksheet To HTML",
                Category = "Conversions",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/worksheet-to-html",
                MetaDescription = "This sample demonstrates how to convert Worksheets to html files using Essential XlsIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="WorksheetToHTML",
                        FileName="WorksheetToHTML.razor"
                    },
                    new SourceCollection
                    {
                        Id="WorksheetToHTMLService",
                        FileName="WorksheetToHTMLService.cs"
                    }
                }
            },
#if !WASM && !WEBAPP
            new Sample
            {
                Name = "Excel To PDF",
                Category = "Conversions",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/excel-to-pdf",
                MetaDescription = "This sample demonstrates the conversion of Excel documents to pdf file using Essential XlsIO.",
                Type = SampleType.Updated,
	        NotificationDescription = new string[]
		{
		     @"Provided error bar support in chart to image conversion and gradient fill support for conditional formatting in Excel to PDF conversion."
		},
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ExcelToPDF",
                        FileName="ExcelToPDF.razor"
                    },
                    new SourceCollection
                    {
                        Id="ExcelToPDFService",
                        FileName="ExcelToPDFService.cs"
                    }
                }
            },
#endif
			new Sample
            {
                Name = "Excel To JSON",
                Category = "Conversions",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/excel-to-json",
                MetaDescription = "This sample demonstrates the conversion of Excel documents to JSON file using Essential XlsIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ExcelToJSON",
                        FileName="ExcelToJSON.razor"
                    },
                    new SourceCollection
                    {
                        Id="ExcelToJSONService",
                        FileName="ExcelToJSONService.cs"
                    }
                }
            },
#if !WASM && !WEBAPP
            new Sample
            {
                Name = "Encrypt and Decrypt",
                Category = "Settings",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/encrypt-and-decrypt",
                MetaDescription  = "This sample demonstrates how to encrypt and decrypt workbooks using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EncryptAndDecrypt",
                        FileName="EncryptAndDecrypt.razor"
                    },
                    new SourceCollection
                    {
                        Id="EncryptAndDecryptService",
                        FileName="EncryptAndDecryptService.cs"
                    }
                }
            },
#endif 
            new Sample
            {
                Name = "Tables",
                Category = "Business Intelligence",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/tables",
                MetaDescription = "This sample deomonstrates how to use tables in spreadsheets using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Tables",
                        FileName="Tables.razor"
                    },
                    new SourceCollection
                    {
                        Id="TablesService",
                        FileName="TablesService.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Pivot Table",
                Category = "Business Intelligence",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/PivotTable",
                MetaDescription = " Click the \"Create Document\" button to view the created Excel document and click the \"Customize Pivot Table\" button to view the Excel document created with customized pivot table. Please note that the Microsoft Excel viewer or Microsoft Excel is required to view the Excel document..",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="PivotTable",
                        FileName="PivotTable.razor"
                    },
                    new SourceCollection
                    {
                        Id="PivotTableService",
                        FileName="PivotTableService.cs"
                    }
                }
            },
			new Sample
            {
                Name = "Pivot Table Layout",
                Category = "Business Intelligence",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/PivotTableLayout",
                MetaDescription = " Click the \"Create Document\" button to view the created Excel document and click the \"Customize Pivot Table\" button to view the Excel document created with customized pivot table. Please note that the Microsoft Excel viewer or Microsoft Excel is required to view the Excel document..",
                Type = SampleType.Updated,
                NotificationDescription = new string[]
		{
		     @"Provided support for show values row in pivot table layout."
		},
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="PivotTableLayout",
                        FileName="PivotTableLayout.razor"
                    },
                    new SourceCollection
                    {
                        Id="PivotTableLayoutService",
                        FileName="PivotTableLayoutService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "AutoShapes",
                Category = "Shapes",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/autoshapes",
                MetaDescription = "This sample demonstrates how to use AutoShapes in spreadsheets using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="AutoShapes",
                        FileName="AutoShapes.razor"
                    },
                    new SourceCollection
                    {
                        Id="AutoShapesService",
                        FileName="AutoShapesService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Group Shapes",
                Category = "Shapes",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/group-shapes",
                MetaDescription = "This sample demonstrates how to use group shapes in spreadsheets using .NET Excel (XlsIO) library.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="GroupShapes",
                        FileName="GroupShapes.razor"
                    },
                    new SourceCollection
                    {
                        Id="GroupShapesService",
                        FileName="GroupShapesService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Comments",
                Category = "Shapes",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/Comments",
                MetaDescription = "This sample demonstrates how to use comments in spreadsheets using .NET Excel (XlsIO) library.",                
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Comments",
                        FileName="Comments.razor"
                    },
                    new SourceCollection
                    {
                        Id="CommentsService",
                        FileName="CommentsService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Create Macro",
                Category = "Macros",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/create-macros",
                MetaDescription = "This sample demonstrates how to create macros using XlsIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="CreateMacros",
                        FileName="CreateMacros.razor"
                    },
                    new SourceCollection
                    {
                        Id="CreateMacrosService",
                        FileName="CreateMacrosService.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Edit Macro",
                Category = "Macros",
                Directory = "DocumentProcessing/Excel",
                Url = "excel/edit-macros",
                MetaDescription = "This sample demonstrates how to create macros using XlsIO.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="EditMacro",
                        FileName="EditMacro.razor"
                    },
                    new SourceCollection
                    {
                        Id="EditMacroService",
                        FileName="EditMacroService.cs"
                    }
                }
            },
        };	

          public List<Sample> PDF { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Hello World",
                Category = "Getting Started",
                Directory = "DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates the creation of simple PDF document. It draws the string Hello world! in the desired location using the PDF standard font.",
                Url = "pdf/hello-world",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="HelloWorldPDF",
                        FileName="HelloWorldPDF.razor"
                    },
                    new SourceCollection
                    {
                        Id="HelloWorldPDFService",
                        FileName="HelloWorldPDFService.cs"
                    }
                }
            },
            new Sample
            {
                Name= "Job Application",
                Category="Product Showcase",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates the creation of job application form from the scratch using the form fields.",
                Url="pdf/job-application",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="JobApplication",
                        FileName="JobApplication.razor"
                    },
                    new SourceCollection
                    {
                        Id="JobApplicationService",
                        FileName="JobApplicationService.cs"
            }
                }
            },
             new Sample
            {
                Name= "Text Flow",
                Category="Drawing Text",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates the creation of PDF document with large text that flows over multiple pages.",
                Url="pdf/text-flow",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TextFlow",
                        FileName="TextFlow.razor"
                    },
                    new SourceCollection
                    {
                        Id="TextFlow",
                        FileName="TextFlowService.cs"
                    }
                }
            },
             new Sample
            {
                Name= "Bullets and Lists",
                Category="Drawing Text",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates how to list the content in ordered and unordered list. The ordered list can be number or alphabets and the unordered list can be bullets, circles, and images.",
                Url="pdf/bullets-and-lists",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="BulletsAndList",
                        FileName="BulletsAndList.razor"
                    },
                    new SourceCollection
                    {
                        Id="BulletsAndList",
                        FileName="BulletsAndListService.cs"
                    }
                }
            },           
                new Sample
            {
                Name= "RTL Text",
                Category="Drawing Text",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates drawing right-to-left language text in the PDF document. It is possible to draw RTL languages such as Arabic, Hebrew, Persian, Urdu and more.",
                Url="pdf/rtl-text",
                Type=SampleType.None,     
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RTLText",
                        FileName="RTLText.razor"
                    },
                    new SourceCollection
                    {
                        Id="RTLText",
                        FileName="RTLTextService.cs"
                    }
                }
            },
                    new Sample
            {
                Name= "OpenType Font",
                Category="Drawing Text",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates how to draw a text with OpenType font in a PDF document.",	
                Url="pdf/open-type-font",
                Type=SampleType.None,      
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="OpenTypeFont",
                        FileName="OpenTypeFont.razor"
                    },
                    new SourceCollection
                    {
                        Id="OpenTypeFont",
                        FileName="OpenTypeFontService.cs"
                    }
                }
            },
                      new Sample
            {
                Name= "Barcode",
                Category="Graphics",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates the creation of barcode in the PDF document and does not requires barcode font for creating barcode.It supports both 1D and 2D barcode with many customizing properties.",
                Url="pdf/barcode",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Barcode",
                        FileName="Barcode.razor"
                    },
                    new SourceCollection
                    {
                        Id="Barcode",
                        FileName="BarcodeService.cs"
                    }
                }
              },
              new Sample
            {
                Name= "Drawing Shapes",
                Category="Graphics",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates drawing of shapes such as Ellipse, Arcs, Polygon, Pie and Rectangle in the PDF document with gradient and color spaces.",
                Url="pdf/drawing-shapes",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DrawingShapes",
                        FileName="DrawingShapes.razor"
                    },
                    new SourceCollection
                    {
                        Id="DrawingShapes",
                        FileName="DrawingShapesService.cs"
                    }
                }
              },
              new Sample
            {
                Name= "Graphic Brushes",
                Category="Graphics",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates drawing of shapes with different brushes such as solid, tiling, Linear gradient, Radial gradient and with different color spaces. such as Cal RGB, ICC, Exponential interpolation, pantone and indexed color space.",
                Url="pdf/graphics-brushes",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="GraphicBrushes",
                        FileName="GraphicBrushes.razor"
                    },
                    new SourceCollection
                    {
                        Id="GraphicBrushes",
                        FileName="GraphicBrushesService.cs"
                    }
                }
              },
                 new Sample
            {
                Name= "Image Insertion",
                Category="Graphics",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates insertion of various raster and vector images (JPEG, PNG, TIFF, EMF, and GIF) in the PDF document. This sample also demonstrates the image masking capability in the Essential PDF library.",
                Url="pdf/image-insertion",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ImageInsertion",
                        FileName="ImageInsertion.razor"
                    },
                    new SourceCollection
                    {
                        Id="ImageInsertion",
                        FileName="ImageInsertionService.cs"
                    }
                }
              },
               new Sample
               {
                Name= "Table Features",
                Category="Tables",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates the creation of richly formatted table to keep your data organized for both basic and advanced operation on cells, rows and columns along with headers and footers.",
                Url="pdf/table-features",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TableFeatures",
                        FileName="TableFeatures.razor"
                    },
                    new SourceCollection
                    {
                        Id="TableFeatures",
                        FileName="TableFeaturesService.cs"
                    }
                }
               },
               new Sample
               {
                Name= "Digital Signature",
                Category="Security",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates how a PDF document can be secured with certificates and signed with either standard or author signatures. Now added the support for Elliptic Curve Digital Signature Algorithm (ECDSA) to sign the PDF document.",
                Url="pdf/digital-signature",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DigitalSignature",
                        FileName="DigitalSignature.razor"
                    },
                    new SourceCollection
                    {
                        Id="DigitalSignature",
                        FileName="DigitalSignatureService.cs"
                    }
                }
               },
                new Sample
               {
                Name= "Layers",
                Category="Settings",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates adding layers (Optional Content Group) with different shapes in the PDF document. The Essential PDF also supports to create, merge, and toggle the layers.",
                Url="pdf/layers",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Layers",
                        FileName="Layers.razor"
                    },
                    new SourceCollection
                    {
                        Id="Layers",
                        FileName="LayersService.cs"
                    }
                }
               },
                 new Sample
               {
                Name= "Find PDF Corruption",
                Category="Analyze Documents",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates to find PDF document corruption by using Essential PDF.",
                Url="pdf/find-pdf-corruption",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="FindPDFCorruption",
                        FileName="FindPDFCorruption.razor"
                    },
                    new SourceCollection
                    {
                        Id="FindPDFCorruption",
                        FileName="FindPDFCorruptionService.cs"
                    }
                }
               },
                     new Sample
               {
                Name= "Interactive Features",
                Category="User Interaction",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates the creation of interactive invoice with attachment, product total price calculation based on the quantity using PDF JavaScript.",
                Url="pdf/interactive-features",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="InteractiveFeatures",
                        FileName="InteractiveFeatures.razor"
                    },
                    new SourceCollection
                    {
                        Id="InteractiveFeatures",
                        FileName="InteractiveFeaturesService.cs"
                    }
                }
               },
                      new Sample
               {
                Name= "XFA Form Creation",
                Category="User Interaction",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates how to create registration form using XFA form fields. The Essential PDF supports to create dynamic and static XFA form fields.",
                Url="pdf/xfa-form-creation",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="XFAFormCreation",
                        FileName="XFAFormCreation.razor"
                    },
                    new SourceCollection
                    {
                        Id="XFAFormCreation",
                        FileName="XFAFormCreationService.cs"
                    }
                }
               },
                  new Sample
               {
                Name= "XFA Form Filling",
                Category="User Interaction",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates how to fill and flatten XFA form fields. It is possible to edit and remove the existing XFA form fields.",
                Url="pdf/xfa-form-filling",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="XFAFormFilling",
                        FileName="XFAFormFilling.razor"
                    },
                    new SourceCollection
                    {
                        Id="XFAFormFilling",
                        FileName="XFAFromFillingService.cs"
                    }
                }
               },
                   new Sample
               {
                Name= "Portfolio",
                Category="User Interaction",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates how to create portfolio in the PDF document. You can also extract and remove files from the PDF portfolio. This feature allows the user to bring content together from variety of sources including documents, drawings, images, emails, spreadsheets, and web pages.",
                Url="pdf/portfolio",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Portfolio",
                        FileName="Portfolio.razor"
                    },
                    new SourceCollection
                    {
                        Id="Portfolio",
                        FileName="PortfolioService.cs"
                    }
                }
               },
			   new Sample
               {
                Name= "Annotations",
                Category="User Interaction",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates the creation of different type of annotations such as ink, free text, pop up, text markup annotation and more. The Essential PDF supports 20+ annotations with create, edit, and delete support.",
                Url="pdf/annotations",
				NotificationDescription = new string[]
                {
                    @"Updated the demo with rich media and watermark annotation support."
                },
                Type = SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Annotations",
                        FileName="Annotations.razor"
                    },
                    new SourceCollection
                    {
                        Id="Annotations",
                        FileName="AnnotationsService.cs"
                    }
                }
               },
#if !WASM && !WEBAPP
              new Sample
              {
                  Name = "Compress Existing PDF",
                  Category = "Compression",
                  Directory = "DocumentProcessing/PDF",
                  MetaDescription = "This sample demonstrates how to compress the existing PDF document using Essential PDF.",
                  Url = "pdf/compress-existing-pdf",
                  Type = SampleType.None,
                  SourceFiles = new List<SourceCollection>()
                  {
                        new SourceCollection
                        {
                            Id="CompressExistingPdf",
                            FileName="CompressExistingPdf.razor"
                        },
                        new SourceCollection
                        {
                            Id="CompressExistingPdf",
                            FileName="CompressExistingPdfService.cs"
                        }
                    }
              },
#endif
              new Sample
               {
                Name= "PDF Conformance",
                Category="Conformance",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates various PDF conformance support in Essential PDF.",
                Url="pdf/conformance",
				NotificationDescription = new string[]
                {
                    @"Updated the demo with PDF/A-4, PDF/A-4E, and PDF/A-4F conformance support."
                },
                Type = SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Conformance",
                        FileName="Conformance.razor"
                    },
                    new SourceCollection
                    {
                        Id="Conformance",
                        FileName="ConformanceService.cs"
                    }
                }
               },

                  new Sample
               {
                Name= "Overlay Documents",
                Category="Modify Documents",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates how to overlay two different PDF documents into a single PDF document.",
                Url="pdf/overlay-documents",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="OverlayDocuments",
                        FileName="OverlayDocuments.razor"
                    },
                    new SourceCollection
                    {
                        Id="OverlayDocuments",
                        FileName="OverlayDocumentsService.cs"
                    }
                }
               },
                     new Sample
               {
                Name= "Rearrange Pages",
                Category="Modify Documents",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates how to rearrange pages from an existing PDF document to make the document meaningful.",
                Url="pdf/rearrange-pages",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="RearrangePages",
                        FileName="RearrangePages.razor"
                    },
                    new SourceCollection
                    {
                        Id="RearrangePages",
                        FileName="RearrangePagesService.cs"
                    }
                }
               },
                    new Sample
               {
                Name= "Autotag",
                Category="Accessibility",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates how to create tagged PDF or accessible PDF from the scratch using auto tag feature.The auto tag feature will tag the document based on PDF element created in the document.",
                Url="pdf/auto-tag",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Autotag",
                        FileName="Autotag.razor"
                    },
                    new SourceCollection
                    {
                        Id="Autotag",
                        FileName="AutotagService.cs"
                    }
                }
               },
                      new Sample
               {
                Name= "Customtag",
                Category="Accessibility",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates how to create tagged PDF or accessible PDF from the scratch with custom tags.",
                Url="pdf/custom-tag",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Customtag",
                        FileName="Customtag.razor"
                    },
                    new SourceCollection
                    {
                        Id="Customtag",
                        FileName="CustomtagService.cs"
                    }
                }
               },
#if !WASM && !WEBAPP
              new Sample
                      {
                          Name = "TIFF to PDF",
                          Category = "Graphics",
                          Directory = "DocumentProcessing/PDF",
                          MetaDescription = "This sample demonstrates how to convert single or multi frame TIFF images to PDF document.",
                          Url = "pdf/tiff-to-pdf",
                          Type = SampleType.None,
                          SourceFiles = new List<SourceCollection>()
                          {
                              new SourceCollection
                              {
                                  Id="TiffToPdf",
                                  FileName="TiffToPdf.razor"
                              },
                              new SourceCollection
                              {
                                  Id="TiffToPdf",
                                  FileName="TiffToPdfService.cs"
                              }
                          }
                      },
              new Sample
              {
                  Name = "Redaction",
                  Category = "Security",
                  Directory = "DocumentProcessing/PDF",
                  MetaDescription = "This sample demonstrates redacting a text from the PDF document. It is also possible to redact the images. The redaction is a process of removing sensitive or unwanted information from the PDF document.",
                  Url = "pdf/redaction",
                  Type = SampleType.None,
                  SourceFiles = new List<SourceCollection>()
                  {
                        new SourceCollection
                        {
                            Id="Redaction",
                            FileName="Redaction.razor"
                        },
                        new SourceCollection
                        {
                            Id="Redaction",
                            FileName="RedactionService.cs"
                        }
                    }
              },
              new Sample
              {
                  Name = "Remove Image",
                  Category = "Modify Documents",
                  Directory = "DocumentProcessing/PDF",
                  MetaDescription = "This sample demonstrates how to remove an image from the PDF document.",
                  Url = "pdf/remove-image",
                  Type = SampleType.None,
                  SourceFiles = new List<SourceCollection>()
                  {
                        new SourceCollection
                        {
                            Id="RemoveImage",
                            FileName="RemoveImage.razor"
                        },
                        new SourceCollection
                        {
                            Id="RemoveImage",
                            FileName="RemoveImageService.cs"
                        }
                    }
              },
              new Sample
              {
                  Name = "PDF to PDF/A",
                  Category = "Conformance",
                  Directory = "DocumentProcessing/PDF",
                  MetaDescription = "This sample demonstrates how to convert an existing PDF document to PDF/A-1b compliant PDF document.",
                  Url = "pdf/pdf-to-pdfa",
                  Type = SampleType.None,
                  SourceFiles = new List<SourceCollection>()
                  {
                        new SourceCollection
                        {
                            Id="PdfToPdfA",
                            FileName="PdfToPdfA.razor"
                        },
                        new SourceCollection
                        {
                            Id="PdfToPdfA",
                            FileName="PdfToPdfAService.cs"
                        }
                    }
              },
               new Sample
               {
                Name= "Digital Signature Validation",
                Category="Security",
                Directory="DocumentProcessing/PDF",
                MetaDescription="This sample demonstrates how to validate the digital signatures in existing PDF document.",
                Url="pdf/validation-signature-pdf",
                Type=SampleType.None,
                SourceFiles=new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DigitalSignatureValidation",
                        FileName="DigitalSignatureValidation.razor"
                    },
                    new SourceCollection
                    {
                        Id="DigitalSignatureValidationPdfService",
                        FileName="DigitalSignatureValidationPdfService.cs"
                    }
                }
               }
#endif
          };          
		
    }
}
