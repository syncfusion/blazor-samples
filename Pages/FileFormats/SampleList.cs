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
                Directory = "FileFormats/DocIO",
                Url = "docio/hello-world",
                FileName = "HelloWorld.razor",
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
                Directory = "FileFormats/DocIO",
                Url = "docio/sales-invoice",
                FileName = "SalesInvoice.razor",
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
                Directory = "FileFormats/DocIO",
                Url = "docio/update-fields",
                FileName = "UpdateFields.razor",
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
                Directory = "FileFormats/DocIO",
                Url = "docio/advanced-replace",
                FileName = "AdvancedReplace.razor",
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
                Directory = "FileFormats/DocIO",                
                Url = "docio/bookmark-navigation",
                FileName = "BookmarkNavigation.razor",
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
                Directory = "FileFormats/DocIO",
                Url = "docio/forms",
                FileName = "Forms.razor",
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
                Name = "Create Equation",
                Category = "Mathematical Equation",
                Directory = "FileFormats/DocIO",
                Url = "docio/create-equation",
                FileName = "CreateEquation.razor",
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
                Directory = "FileFormats/DocIO",
                Url = "docio/edit-equation",
                FileName = "EditEquation.razor",
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
                Name = "Bookmarks",
                Category = "Insert Content",
                Directory = "FileFormats/DocIO",
                Url = "docio/bookmarks",
                FileName = "Bookmarks.razor",
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
                Directory = "FileFormats/DocIO",
                Url = "docio/header-and-footer",
                FileName = "HeaderandFooter.razor",
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
                Directory = "FileFormats/DocIO",
                Url = "docio/image-insertion",
                FileName = "ImageInsertion.razor",
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
                Directory = "FileFormats/DocIO",
                Url = "docio/employee-report",
                FileName = "EmployeeReport.razor",
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
                Directory = "FileFormats/DocIO",
                Url = "docio/insert-ole-object",
                FileName = "InsertOLEObject.razor",
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
                Directory = "FileFormats/DocIO",
                Url = "docio/letter-format",
                FileName = "LetterFormat.razor",
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
                Directory = "FileFormats/DocIO",
                Url = "docio/mail-merge-event",
                FileName = "MailMergeEvent.razor",
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
                Directory = "FileFormats/DocIO",
                Url = "docio/nested-mail-merge",
                FileName = "NestedMailMerge.razor",
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
			new Sample
            {
                Name = "Word to PDF",
                Category = "Import and Export",
                Directory = "FileFormats/DocIO",
                Type = SampleType.Updated,
                Url = "docio/word-to-pdf",
                FileName = "WordToPDF.razor",
                NotificationDescription = new string[]
                {
                    @"Provided support to preserve comments while converting Word document to PDF."
                },
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
                Name = "RTF to Word",
                Category = "Import and Export",
                Directory = "FileFormats/DocIO",
                Url = "docio/rtf-to-doc",
                FileName = "RTFtoDOC.razor",
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
                Directory = "FileFormats/DocIO",
                Url = "docio/word-to-wordml",
                FileName = "WordToWordML.razor",
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
                Directory = "FileFormats/DocIO",
                Url = "docio/wordml-to-word",
                FileName = "WordMLtoWord.razor",
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
                Directory = "FileFormats/DocIO",
                Url = "docio/word-to-odt",
                FileName = "WordToODT.razor",
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
                Directory = "FileFormats/DocIO",
                Url = "docio/track-changes",
                FileName = "TrackChanges.razor",
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
                Name = "Table of Content",
                Category = "Reference",
                Directory = "FileFormats/DocIO",
                Url = "docio/table-of-content",
                FileName = "TableofContent.razor",
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
                Name = "Encrypt and Decrypt",
                Category = "Security",
                Directory = "FileFormats/DocIO",
                Url = "docio/encrypt-and-decrypt",
                FileName = "EncryptDecrypt.razor",
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
        };
        public List<Sample> Presentation { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Create Presentation",
                Category = "Getting Started",
                Directory = "FileFormats/Presentation",
                Url = "presentation/getting-started",
                FileName = "GettingStarted.razor",
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
            new Sample
            {
                Name = "PPTX To Image",
                Category = "Conversion",
                Directory = "FileFormats/Presentation",
                Url = "presentation/pptx-to-image",
                FileName = "PPTXToImage.razor",
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
                Directory = "FileFormats/Presentation",
                Url = "presentation/pptx-to-pdf",
                FileName = "PPTXToPDF.razor",
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
                Name = "Encrypt and Decrypt",
                Category = "Security",
                Directory = "FileFormats/Presentation",
                Type = SampleType.New,
                Url = "presentation/encrypt-and-decrypt",
                NotificationDescription = new string[]
                {
                    @"Added support for encrypting and decrypting a presentation document by using a password."
                },
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
                Directory = "FileFormats/Presentation",
                Url = "presentation/write-protection",
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
                FileName = "WriteProtection.razor"
            },
            new Sample
            {
                Name = "Chart",
                Category = "Slide Elements",
                Directory = "FileFormats/Presentation",
                Url = "presentation/chart",
                FileName = "Chart.razor",
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
                Directory = "FileFormats/Presentation",
                Url = "presentation/slide",
                FileName = "Slide.razor",
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
                Directory = "FileFormats/Presentation",
                Url = "presentation/smartart",
                FileName = "SmartArt.razor",
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
                Directory = "FileFormats/Presentation",
                Url = "presentation/table",
                FileName = "Table.razor",
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
                Directory = "FileFormats/Presentation",
                Url = "presentation/comment",
                FileName = "Comment.razor",
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
                Directory = "FileFormats/Presentation",
                Url = "presentation/connector",
                FileName = "Connector.razor",
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
                Directory = "FileFormats/Presentation",
                Url = "presentation/ole-object",
                FileName = "OLEObject.razor",
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
                Directory = "FileFormats/Presentation",
                Url = "presentation/create-animation",
                FileName = "CreateAnimation.razor",
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
                Directory = "FileFormats/Presentation",
                Url = "presentation/modify-animation",
                FileName = "ModifyAnimation.razor",
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
                Directory = "FileFormats/Presentation",
                Url = "presentation/slide-transition",
                FileName = "SlideTransition.razor",
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
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/create-excel",
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
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/attendance-tracker",
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
                Name = "Format Cells",
                Category = "Formatting",
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/format-cells",
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
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/conditional-formatting",
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
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/import-html-table",
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
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/chart-worksheet",
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
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/embedded-chart",
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
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/sparklines",
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
            new Sample
            {
                Name = "Formulas",
                Category = "Excel Formulas",
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/formulas",
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
            new Sample
            {
                Name = "Data Validation",
                Category = "Data Management",
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/data-validation",
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
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/form-controls",
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
                Name = "Worksheet To HTML",
                Category = "Export",
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/worksheet-to-html",
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
			new Sample
            {
                Name = "Excel To JSON",
                Category = "Export",
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/excel-to-json",
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
            new Sample
            {
                Name = "Encrypt and Decrypt",
                Category = "Settings",
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/encrypt-and-decrypt",
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
            new Sample
            {
                Name = "Tables",
                Category = "Business Intelligence",
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/tables",
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
                Name = "AutoShapes",
                Category = "Shapes",
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/autoshapes",
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
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/group-shapes",
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
            }
        };	
		
          public List<Sample> PDF { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Hello World",
                Category = "Getting Started",
                Directory = "FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
                Url="pdf/annotations",
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

                  new Sample
               {
                Name= "Overlay Documents",
                Category="Modify Documents",
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
                Directory="FileFormats/PDF",
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
               }
        };          
		
    }
}
