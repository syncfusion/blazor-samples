using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to create a simple Word document with text, image and table using Essential DocIO.</p>"
                },
               Description = new string[] {
                @"<p><ul><li>With the help of DocIO, you can create document with few lines of code.</li><li>
                Create Word document from Scratch.</li><li>
                Open the existing Word document from file system or stream, modify and save it back.</li><li>
                Transverse through the document, manipulate content and formatting with the help of intuitive document object model</li><li>
                Save the Word document to a local file, stream, or stream it to the client browser.</li></ul></p>&nbsp;<p>More information about the basics of DocIO can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/getting-started"">documentation</a> section.</p>"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates the generation of sales invoice from an input Word template using Mail Merge functionality of Essential DocIO.</p>"
                },
                Description = new string[] {
                @"<p>DocIO allows you to create, read, manipulate, and render Word documents. With the mail merge support, you can create a batch of personalized document or report very easily and fast.</p>
        <ul>
            <li>
                You can design reports in Microsoft Word and allow DocIO to populate documents with data from various data sources such as business objects, ADO.NET objects, arrays, XML, dynamic objects, and relational objects.
            </li>
            <li>
                You can create advanced reports by dynamically repeating a region of the document and by nesting mail merge region inside each other to populate hierarchical data.
            </li>
        </ul>
    <p>More information about the Mail Merge functionality can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-mailmerge"">documentation</a> section.</p>"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to update the fields available in the Word document using Essential DocIO. Here, in the example, merge fields and formula fields are used together to populate the net profit or loss.</p>"
                },
                Description = new string[] {
                @"<p>Fields in a Word document are like placeholders where the data can be populated or calculated dynamically based on various factors. Most commonly used fields are merge fields, Table of contents (TOC), page number related fields, IF fields, date fields etc.</p>&nbsp;
    <p>Another example: IF field compares two values and then inserts the text appropriate to the rest of the comparison. When used in a mail merge, the field can examine information in the merged data records, and populate appropriate text.</p>&nbsp;
    <p>More information about the fields and updating fields can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-fields"">documentation</a> section.</p>"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to replace a specific content in the Word document with another document using the Find and Replace functionality of Essential DocIO.</p>"
                },
                Description = new string[] {
                @"<p>DocIO allows you to find and replace a specific content in the Word document with another document.</p><p><ul><li>You can replace a specific content with another part of the document or another Word document.</li><li>
                You can replace the content by retaining the same formatting for the new content.</li><li>
                You can also replace it with any document elements like image, paragraph, table, etc.,</li></ul></p>&nbsp;<p>More information about the basics of DocIO can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-find-and-replace"">documentation</a> section.</p>"
                }
            },
            new Sample
            {
                Name = "Bookmark Navigation",
                Category = "Editing",
                Directory = "FileFormats/DocIO",
                Type = SampleType.Updated,
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to navigate between the bookmarks in a Word document and edit its content using Bookmark Navigation functionality of Essential DocIO.</p>"
                },
                Description = new string[] {
                @"<p>DocIO allows you to insert or delete bookmarks in the Word document and edit its content.</p><p><ul><li>You can easily identify a part of the document for future reference by adding bookmark.</li><li>
                Bookmark navigation lets you navigate to a specific bookmark and get its content as new document.</li><li>
                You can insert, replace or delete the contents of a specific bookmark in the Word document.</li><li>You can select the column range for bookmarks inside tables in Word documents using FirstColumn and LastColumn APIs.</li></ul></p>&nbsp;<p>More information about the bookmarks can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-bookmarks"">documentation</a> section.</p>"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to create a simple job application form and fill the form using Essential DocIO.</p>"
                },
                Description = new string[] {
                @"<p>DocIO allows you to create a simple form using legacy form fields in the Word document, which gives built-in form filling experience.</li><li>
                You can create form using legacy form fields like text, check box, and drop down.</li><li>
                You can open an existing Word document with form fields and fill them.</li><li>
                You can also set editing restriction that does not allow the users to edit the Word document, except filling the form fields.</li></ul></p>&nbsp;<p>More information about the forms can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-form-fields"">documentation</a> section.</p>"
                }
            },
            new Sample
            {
                Name = "Create Equation",
                Category = "Mathematical Equation",
                Directory = "FileFormats/DocIO",
                Url = "docio/create-equation",
                FileName = "CreateEquation.razor",
                Type = SampleType.Updated,
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to create a Word document with mathematical equations using Essential DocIO. </p>"
                },
               Description = new string[] {
                @"<p>With DocIO, you can create mathematical equations from scratch and insert it into Word documents (DOCX, DOTX, DOCM, DOTM, and XML). <p>
                <p>	<ul><li>You can insert an equation in line with text or floating within a line.</li>
				<li>You can create all types of mathematical equations such as fraction, summation, integral, matrix, and more.</li>
			</ul>
		</p>&nbsp;<p>More information about the headers and footers can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-sections?&_ga=2.47606244.2146113924.1583722381-1646022479.1561364938#working-with-headers-and-footers"">documentation</a> section.</p>"
                }
            },
            new Sample
            {
                Name = "Edit Equation",
                Category = "Mathematical Equation",
                Directory = "FileFormats/DocIO",
                Url = "docio/edit-equation",
                FileName = "EditEquation.razor",
                Type = SampleType.Updated,
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to modify a mathematical equation in a Word document using Essential DocIO.</p>"
                },
               Description = new string[] {
                @"<p>DocIO allows you to modify a mathematical equation in the Word document.<p>
                <p>	<ul><li>You can modify the text in the equation field.</li>
				<li>You can change the format of an equation. </li> 
			</ul>
		</p>&nbsp;<p>More information about the headers and footers can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-sections?&_ga=2.47606244.2146113924.1583722381-1646022479.1561364938#working-with-headers-and-footers"">documentation</a> section.</p>"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to insert bookmarks into the Word document using Essential DocIO.</p>"
                },
                Description = new string[] {
                @"<p>With the help of DocIO, you can create document with few lines of code.</p>
                <p>Bookmark helps to identify a part of the document for future reference. The document elements like paragraph, table, etc., can be marked with a bookmark and it can be accessed by its name.</p>
                <p><ul><li>With DocIO, you can insert and delete bookmarks in the Word document.</li>
                <li>Using bookmark navigator, you can navigate through the document elements and select a specific bookmark in the Word document.</li>
                <li>Once after selecting a bookmark, you can edit, modify or delete the contents within that bookmark.</li>
                </ul></p>
                <p>More information about the bookmarks can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-bookmarks"">documentation</a> section.</p>"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to insert headers and footers to the Word document using Essential DocIO.</p>"
                },
               Description = new string[] {
                @"<p>With DocIO, you can insert all possible types of header and footer in the Word document like first page, odd page and even page header and footer.<p>
                <p>	<ul><li>You can add text, tables, pictures, page numbers, fields etc., to the header and footer.</li>
				<li>Previous section header and footer contents can be linked and repeated for the next section.</li>    
				<li>You can define different header and footer for the first page, odd pages and even pages in the document.</li>
			</ul>
		</p>&nbsp;<p>More information about the headers and footers can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-sections?&_ga=2.47606244.2146113924.1583722381-1646022479.1561364938#working-with-headers-and-footers"">documentation</a> section.</p>"
                }
            },
            new Sample
            {
                Name = "Image Insertion",
                Category = "Insert Content",
                Directory = "FileFormats/DocIO",
                Type = SampleType.Updated,
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to insert images into the Word document using Essential DocIO.</p>"
                },
                Description = new string[] {
                @"<p>DocIO allows you to insert images into the Word document at desired location.</p>
                <p><ul><li>You can insert image as ""in line with text"" or ""position relative to the page"" in the Word document.</li>
                <li>Images in the Word document can be accessed by its name, title, etc., and resized to required size.</li>
                <li>You can make images in the Word document accessible by defining alternate text.</li>
                <li>You can add caption to an image and update the caption numbers (Sequence fields).</li>
                </ul></p>
                <p>More information about the images support can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-paragraph#working-with-images"">documentation</a> section.</p>"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to generate an employee report using Mail merge functionality of Essential DocIO.</p>"
                },
                Description = new string[] {
                @"<p>With the mail merge support of DocIO, you can create a batch of personalized document or report very easily and fast.</p><p><ul><li>You can design templates in Microsoft Word and allow DocIO to populate documents with data from various data sources such as business objects, ADO.NET objects, arrays, XML, dynamic objects, and relational objects.</li><li>
                Simple text, numeric data and image from data sources can be populated in Word documents using mail merge.</li></ul></p>&nbsp;<p>More information about the Mail merge can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-mailmerge"">documentation</a> section.</p>"
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
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to insert OLE Object into the Word document using Essential DocIO.</p>"
                },
                Description = new string[] {
                @"<p>With DocIO, you can insert an OLE Object as either link or embed into the Word document. You can extract the OLE Object data from the Word document and save as native file.</p>
                 <p>More information about the OLE Objects can be found on this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-paragraph#appending-ole-objects"">documentation</a> section.</p>"
                }
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to generate a letter using Mail merge functionality of Essential DocIO.</p>"
                },
                Description = new string[] {
                @"<p>With the mail merge support of DocIO, you can create a batch of personalized document or report very easily and fast.</p><p><ul><li>You can design templates in Microsoft Word and allow DocIO to populate documents with data from various data sources such as business objects, ADO.NET objects, arrays, XML, dynamic objects, and relational objects.</li><li>
                Simple text, numeric data and image from data sources can be populated in Word documents using mail merge.</li></ul></p>&nbsp;<p>More information about the Mail merge can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-mailmerge"">documentation</a> section.</p>"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to format the Mail merged data using Mail merge events of Essential DocIO.</p>"
                },
                Description = new string[] {
                @"<p>DocIO provides event support for text and image merge fields. With these events, you can format the text and the image merged in the Word document during mail merge.</p>&nbsp;
                <p><ul><li>Using event support, you can generate report with each record in new page by inserting page break.</li>
                <li>You can perform mail merge for a group of merge fields by defining group start and end fields in the template document.</li>
                <p>Using event support, you can generate report with each record in new page by inserting page break.</p>&nbsp;
                <p>More information about the Mail merge event can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-mailmerge#event-support-for-mail-merge"">documentation</a> section.</p>"
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
                },
                ActionDescription = new string[] {
                @"<p> This sample demonstrates how to perform Mail merge for nested groups in Word document using Essential DocIO.</p>"
                },
                Description = new string[] {
                @"<p>DocIO supports to perform mail merge between the nested groups in the Word document, to generate report with hierarchical data.</p>
                  <p><ul><li>You can create advanced reports by dynamically repeating a region of the document and by nesting mail merge region inside each other to populate hierarchical data.</li><li>
                  You can define relation between the data tables explicitly or directly use relational data for performing nested mail merge.</li></ul></p>
                  <p>More information about the nested Mail merge can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-mailmerge"">documentation</a> section.</p>"
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
                },
                ActionDescription = new string[] {
                @"<p> This sample illustrates how to convert Word document to PDF using Essential DocIO and Essential PDF.</p>"
                },
                Description = new string[] {
                @"<p>DocIO provides support to render Word document from flow to fixed page model and export as PDF or Image. With this support to render Word document,</p>
                  <p><ul><li>You can generate invoice and other reports in PDF, starting from Word document.</li><li>
                  You can view or print the contents of Word document by converting as PDF and loading generated PDF via PDF viewer.</li></ul></p>
                  <p>More information about the nested Mail merge can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/word-to-pdf"">documentation</a> section.</p>"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to convert the RTF file to Word document using Essential DocIO.</p>"
                },
                Description = new string[] {
                @"<p>With the help of DocIO, you can create document with few lines of code.</p>
                <p>More information about the basics of DocIO can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/rtf"">documentation</a> section.</p>"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to convert the Word document to Word processing XML using Essential DocIO.</p>"
                },
                Description = new string[] {
                @"<p>DocIO provides support to convert the Word document to Word processing XML document and vice versa.</p>
                 <p>More information about WordML conversion can be found on this  <a href=""https://help.syncfusion.com/file-formats/docio/word-file-formats#word-processing-xml-xml"">documentation</a> section.</p>"
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
                },
                ActionDescription = new string[] {
                @"<p> This sample demonstrates how to convert the Word processing XML to Word document using Essential DocIO.</p>"
                },
                Description = new string[] {
                @"<p>DocIO provides support to convert the Word processing 2003 XML and Word processing XML document to Word document.</p>&nbsp;
                  <p>More information about the nested Mail merge can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-mailmerge"">documentation</a> section.</p>"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to convert the Word document to ODT using Essential DocIO.</p>"
                },
                Description = new string[] {
                @"<p>DocIO provides support to convert the Word document to Open Document Text format.</p>&nbsp;<p>More information about ODT conversion can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/word-to-odt"">documentation</a> section.</p>"
                }
            },
            new Sample
            {
                Name = "Track Changes",
                Category = "Review",
                Directory = "FileFormats/DocIO",
                Type = SampleType.New,
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to accept or reject the tracked changes in the Word document using Essential DocIO.</p>"
                },
                Description = new string[] {
                @"<p>With DocIO, you can accept or reject the tracked changes from an existing Word document (DOCX).</p>
        <ul>
            <li>
                You can accept or reject the tracked changes based on author, date, and type of revision.
            </li>
            <li>
                You can accept or reject all the tracked changes in the Word document.
            </li>
        </ul>
    <p>More information about accepting or rejecting track changes can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/accepting-or-rejecting-track-changes"">documentation</a> section.</p>"
                }
            },
            new Sample
            {
                Name = "Table of Content",
                Category = "Reference",
                Directory = "FileFormats/DocIO",
                Type = SampleType.New,
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
                },
                ActionDescription = new string[] {
                @"<p>DocIO supports to insert Table of Contents based on custom and default heading styles, include page numbers, hyperlinks to easily navigate to specific topic or heading within the document, specify the outline levels..</p>"
                },
                Description = new string[] {
                @"<p>You can draft books in Word document with table of contents that provides outline of the book like chapter, section titles, sub titles with its commencing page number.</p><p><ul><li>You can update or rebuild the Table of Contents in an existing Word document.</li>
                </ul></p>&nbsp;<p>More information about the Table of Contents can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-table-of-contents"">documentation</a> section.</p>"
                }
            },
            new Sample
            {
                Name = "Encrypt and Decrypt",
                Category = "Security",
                Directory = "FileFormats/DocIO",
                Type = SampleType.New,
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
                },
                ActionDescription = new string[] {
                @"<p>DocIO supports to encrypt a Word document with password that restrict others from accessing or modifying confidential contents. You can also open an encrypted Word document using DocIO with valid password.</p>"
                },
                Description = new string[] {
                @"<p>More information about the encrypt and decrypt options can be found in this <a href=""https://help.syncfusion.com/file-formats/docio/working-with-security"">documentation</a> section.</p>"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to create slides with simple text in a PowerPoint presentation.</p>"
                },
                Description = new string[] {
                @"<b>Features:</b>
    <br />    
    <ul>
		    <li>Create a PowerPoint presentation from scratch with few lines of code.</li>
            <li>Open the existing PowerPoint presentation from file system or stream, modify and save it back.</li>
            <li>Save the PowerPoint presentation to a local file, stream, or stream it to the client browser.</li>
            <li>Create and edit shapes.</li>
			<li>Create and edit text.</li>
			<li>Add and manipulate single-level and multilevel lists equivalent to Microsoft PowerPoint.</li>
			<li>Create, edit and convert charts.</li>
			<li>Create and edit SmartArt diagrams.</li>
			<li>Create and edit tables with different styles.</li>
			<li>Copy and paste PowerPoint slides with source and destination paste options</li>
			<li>Create, reply and edit comments.</li>
			<li>Create and edit notes pages.</li>
			<li>Apply and edit formatting of slide elements.</li>
    </ul>
    <br />"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to convert the PowerPoint slide to an image.</p>"
                },
                Description = new string[] {
                @"<b>Features:</b>
    <br />
    <ul>	
	<li>Convert all slide elements like text, shape, SmartArt diagram, table, etc., along with its formatting.</li>
    <li>Charts in a slide can be converted to image.</li>
	<li>Slides can be converted to JPEG, PNG formats.</li>
    </ul>
    <br />"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to convert a PowerPoint presentation to PDF.</p>"
                },
                Description = new string[] {
                @"<b>Features:</b>
    <br />
    <ul>
		<li>Convert all slide elements like text, shape, SmartArt diagram, table, etc., along with its formatting.</li>
        <li>Convert with handouts option.</li>
        <li>Convert the notes pages to PDF.</li>
		<li>Charts in a slide can be converted to PDF.</li>
        <li>Converted PDF document size can be optimized.</li>
    </ul>
    <br />"
                }
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
                FileName = "WriteProtection.razor",
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to set write protection for a PowerPoint presentation with password.</p>"
                },
                Description = new string[] {
                @"<b>Features:</b>
    <br />
    <ul>
			<li>Set write protection for PowerPoint presentation with password.</li>
            <li>Remove write protection of PowerPoint presentation.</li>	
    </ul>
    <br />"
                }
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to create charts in a presentation using PowerPoint presentation.</p>"
                },
                Description = new string[] {
                @"<b>Features:</b>
    <br />
    <ul>
			<li>Create and edit more than 80 chart types.</li>
            <li>Create custom charts by adding combinations from different chart types.</li>
            <li>Modify, include and remove chart elements like axes, label, legend and chart title.</li>
            <li>Edit color for chart elements like chart area and plot area of an existing chart.</li>
    </ul>
    <br />"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to create slides with simple text, table and image in a PowerPoint presentation.</p>"
                },
                Description = new string[] {
                @"<b>Features:</b>
    <br />
    <ul>
			<li>Support for 9 pre-defined slide layouts while creating new slides.</li>
            <li>Add, rearrange, duplicate, and delete slides in PowerPoint presentation.</li>
            <li>Slides can be copied and pasted to the same or different PowerPoint presentation.</li>
            <li>Slides can be formatted with variety of formatting options equivalent to Microsoft PowerPoint.</li>
    </ul>
    <br />"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to create SmartArt diagram in a PowerPoint presentation.</p>"
                },
                Description = new string[] {
                @"<b>Features:</b>
    <br />
    <ul>
			<li>Create and edit 134 default SmartArt diagram equivalent to Microsoft PowerPoint.</li>
            <li>Add, modify and remove nodes of the SmartArt diagram.</li>
    </ul>
    <br />"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to add tables in a PowerPoint presentation.</p>"
                },
                Description = new string[] {
                @"<b>Features:</b>
    <br />
    <ul>
			<li>Format tables with 6 pre-defined table style options to format the entire rows and columns.</li>
            <li>Format tables with 74 pre-defined table styles to change the borders and shading of the table.</li>
            <li>Create, modify, and format tables to keep data organized.</li>
            <li>Cell and row-level operations like adding, inserting, deleting of rows are supported.</li>
			<li>Built-in table styles are available equivalent to Microsoft PowerPoint table styles.</li>
    </ul>
    <br />"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to add comments to a presentation slide.</p>"
                },
                Description = new string[] {
                @"<b>Features:</b>
    <br />
    <ul>
			<li>Support for adding, replying, editing comments in a PowerPoint slide.</li>            
    </ul>
    <br />"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to insert the connectors in a PowerPoint slide.</p>"
                },
                Description = new string[] {
                @"<b>Features:</b>
    <br />
    <ul>
			<li>Support for 'Straight', 'Bent', and 'Curve' connectors in a PowerPoint slide.</li>
            <li>Support for different connectors arrow styles.</li>
            <li>Support to insert, edit, remove, clone, and convert connectors.</li>
    </ul>
    <br />"
                }
            },
            new Sample
            {
                Name = "OLE Object",
                Category = "Slide Elements",
                Directory = "FileFormats/Presentation",
                Url = "presentation/ole-object",
                FileName = "OLEObject.razor",
                Type = SampleType.Updated,
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to insert and open a OLE Object in PowerPoint presentation.</p>"
                },
                Description = new string[] {
                @"<b>Features:</b>
    <br />
    <ul>
			<li>Add new OLE Object into a PowerPoint slide.</li>
            <li>Extract a embedded OLE Object data.</li>
            <li>Gets the file path of a linked OLE Object.</li>
			<li>Gets the file name of a OLE Object.</li>
    </ul>
    <br />"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to add different animation effect for shapes.</p>"
                },
                Description = new string[] {
                @"<b>Features:</b>
    <br />
    <div>
        The below animation effects are supported as equivalent to Microsoft PowerPoint:
        <ul>
            <li>Entrance</li>
            <li>Emphasis</li>
            <li>Exit</li>
             <li>Motion Paths</li>
        </ul>
    </div>
    <br />
    <div>
        The below animation options are supported as equivalent to Microsoft PowerPoint:
        <ul>
            <li>Effect options</li>
            <li>Add multiple animation</li>
            <li>Trigger</li>
            <li>Animation timing</li>
        </ul>
    </div>
    <br />"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to modify the animation effect for shapes.</p>"
                },
                Description = new string[] {
                @"<b>Features:</b>
    <br />
    <div>
        The below animation effects are supported as equivalent to Microsoft PowerPoint:
        <ul>
            <li>Entrance</li>
            <li>Emphasis</li>
            <li>Exit</li>
            <li>Motion Paths</li>
        </ul>
    </div>
    <br />
    <div>
        The below animation options are supported as equivalent to Microsoft PowerPoint:
        <ul>
            <li>Effect options</li>
            <li>Add multiple animation</li>
            <li>Trigger</li>
            <li>Animation timing</li>
        </ul>
    </div>
    <br />"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to create slide transition effects in PowerPoint presentation.</p>"
                },
                Description = new string[] {
                @"<b>Features:</b>
    <br />
    <div>
        The below transition effects are supported as equivalent to Microsoft PowerPoint:
        <ul>
          <li>Subtle</li>
          <li>Exciting</li>
          <li>Dynamic Content</li>
        </ul>
    </div>
    <br />
    <div>
        The below transition options are supported as equivalent to Microsoft PowerPoint:
        <ul>
          <li>Effect options</li>
          <li>Advance On Time</li>
          <li>Advance Mouse On Click</li>
          <li>Transition Duration</li>
        </ul>
    </div>
    <br />"
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to create a simple spreadsheet document using XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>In this sample, a new instance of XlsIO is created. This instance has no open workbooks. A workbook is created with the IWorkbook interface. This workbook has one worksheet by default and number of worksheets can be created based on the need. The IRange interface can be used to access the cell and write the content.</p>
<p style='display: block'><b>Features:</b></p>
<ul>
<li>Creating workbooks from scratch in various file formats</li>
<li>Creating more numbers of sheets</li>
<li>Writing text in the range of cells</li>
</ul>"
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
                },
				ActionDescription = new string[] {
                @"<p>This sample demonstrates how to use AttendanceTracker in spreadsheets using XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>Attendance Tracker or Attendance sheet is essential to any organization. This Attendance tracker is designed to keep one month data. In this application, Employee Name, Supervisor, Present Count, Absent Count, Leave Count, Unplanned%, Planned% and dates for a particular month are available.</p>
<p style='display: block'><b>Features:</b></p>
<p>Essential XlsIO supports Attendance Tracker application features. This sample demonstrates following features:</P>
<ul>
<li>Conditional formatting</li>
<li>Advanced options of Excel--such as color scales, data bars</li>
<li>Number formats</li>
<li>Formulas</li>
<li>Text styles (bold, italic, underline, font name, and font color)</li>
</ul>"
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
                },
				ActionDescription = new string[] {
                @"<p>This sample demonstrates how to apply formatting to the cells using XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>Formatting worksheets makes them more attractive and easier to use. Excel provides various options for setting font, font size, color, and background. The Format Cells dialog in Excel has six tabs, each with several characteristics that allow you to set various formats for a cell. You can set number formats, horizontal and vertical alignment, text control operations, font and font styles, and borders for the cells.</p>
<p style='display: block'><b>Features:</b></p>
<ul>
<li>Various styles such as colors, font settings, borders, and alignments</li>
<li>Number formats</li>
<li>Patterns</li>
<li>Conditional formatting</li>
<li>RTF</li>
<li>Image insertion</li>
</ul>"
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
                },
				ActionDescription = new string[] {
                @"<p>This sample demonstrates how to apply conditional formats using XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>Microsoft Excel provides enhanced conditional formatting support. Conditional formatting allows you to apply formatting to one or more cells based on the value of the cell or the value of a formula. XlsIO also supports applying more than three conditional formats to the same cell, similar to Excel 2007 and above.</p>
<p style='display: block'><b>Note:</b>It is not possible to apply more than three conditional formats in earlier versions of Excel.</p>
<p style='display: block'><b>Features:</b></p>
<ul>
<li>Writing conditional formatting on a range of cells</li>
<li>Advanced options of Excel, such as color scales, icon sets, and data bars</li>
</ul>"
                }
            },
			new Sample
            {
                Name = "Import HTML Table",
                Category = "Data Binding",
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/import-html-table",
                Type = SampleType.New,
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
                        FileName="ImportHTMLTable.cs"
                    }
                },
                ActionDescription = new string[] {
@"<p>This sample demonstrates how to import HTML table to worksheet using Essential XlsIO.</p>"
},
    Description = new string[] {
@"<p>Essential XlsIO supports importing HTML tables into Excel worksheets. The ImportHtmlTable method loads an HTML file and imports all the tables in the file to the worksheet.</p>
<p style='display: block'><b>Features:</b></p>
<p style='display: block'>This sample demonstrates following features:</p>
<ul>
<li>Imports HTML table</li>
<li>Imports with table formatting</li>
</ul>"
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
                },
				ActionDescription = new string[] {
                @"<p>This sample demonstrates how to create a simple chart sheet using XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>A chart sheet is a worksheet in a workbook that has its own sheet name. These are employed to give a clearer view when using a large chart with a large data. The chart is linked to worksheet data and is updated automatically when there are changes. The IChart interface is the in-memory representation of the chart worksheet in an Excel workbook. These are used to create charts and to set properties for those charts. The IChartSerie interface can be used to set various formats for a series.</p>
<p style='display: block'><b>Features:</b></p>
<ul>
<li>Axes</li>
<li>Labels</li>
<li>Titles</li>
<li>Gradients</li>
<li>Chart Types</li>
<li>Chart Filters</li>
</ul>"
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
                },
				ActionDescription = new string[] {
                @"<p>This sample demonstrates how to create a simple chart using XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>Essential XlsIO has APIs for creating an embedded chart. The <b>IChartShape</b> interface represents the embedded chart in memory. This object can be used to format and modify chart settings, which is similar to modifying chart properties using Excel.</p>
<p style='display: block'><b>Features:</b></p>
<ul>
<li>Creation of embedded chart types</li>
<li>Creation of chart from values in a template document</li>
</ul>"
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
                },
				ActionDescription = new string[] {
                @"<p>This sample demonstrates how to create sparkline charts using XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>Sparkline is a small chart in a worksheet cell that provides visual representation of data. Essential XlsIO has the APIs for creating and manipulating sparklines.</p>
<p style='display: block'><b>Features:</b></p>
<ul>
<li>Creation of Sparkline types</li>
<li>Sparkline creation from values fetched from a template document</li>
</ul>"
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
                },
				ActionDescription = new string[] {
                @"<p>This sample demonstrates how to use formulas in spreadsheets using XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>Formulas are entries in Excel that have an equation that calculates the value to be displayed. A typical formula might contain cells, constants, and even functions. Essential XlsIO has support for reading and writing formulas.</p>
<p style='display: block'><b>Features:</b></p>
<ul>
<li>Writing array formulas</li>
<li>Writing Excel built-in formulas</li>
<li>Reading formula strings using XlsIO</li>
<li>Reading evaluated formulas using XlsIO</li>
</ul>"
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
                },
				ActionDescription = new string[] {
                @"<p>This sample demonstrates how to use data validation in spreadsheets using XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>Data validation helps to control the kind of information that is entered in a worksheet cells. It provides users with the following options:</p>
<ul>
<li>A list of choices</li>
<li>Restriction of entries to specific type or size</li>
</ul>
<p style='display: block'>Essential XlsIO has support for reading and writing data validations. This sample focuses on writing a data validation in an Excel template.</p>
<p style='display: block'><b>Features:</b></p>
<ul>
<li>Text validation</li>
<li>Validating input text length based on the given constraints</li>
</ul>"
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
                },
				ActionDescription = new string[] {
                @"<p>This sample demonstrates how to use form controls in spreadsheet using XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>Essential XlsIO can read and write form controls such as text boxes, check boxes, combo boxes and option buttons.</p>
<p style='display: block'><b>Features:</b></p>
<ul>
<li>Creating rich reports with text boxes, check boxes, and combo boxes using XlsIO</li>
<li>Text box formatting</li>
<li>Check boxes with Cell Link</li>
<li>Combo boxes with formatting</li>
<li>Option button with formatting</li>
</ul>"
                }
            },
            new Sample
            {
                Name = "Excel To PDF",
                Category = "Export",
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/excel-to-pdf",
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
                },
				ActionDescription = new string[] {
                @"<p>This sample deomonstrates how to convert spreadsheets to PDF documents using XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>This sample illustrates the conversion of a MS Excel document to a PDF format.</p>
<p style='display: block'>Essential XlsIO allows to export the Excel document into PDF document. Use the Convert method of ExcelToPDFConverter class to convert the Excel to PDF and save the PDF document. This enabling user easily converts the Excel document to PDF document.</p>
<p style='display: block'><b>Features:</b></p>
<ul>
<li>Supports conversion of a Excel document to PDF document</li>
</ul>
<p style='display: block'><b>Note:</b>Installation of Essential PDF is necessary to run this sample</p>"
                }
            },
            new Sample
            {
                Name = "Worksheet To Image",
                Category = "Export",
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/worksheet-to-image",
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
                },
				ActionDescription = new string[] {
                @"<p>This sample demonstrates how to convert spreadsheets to image using XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>A worksheet can be converted to an image that is subject to few limitations. The image can be of any format, and it can also be saved as a memory stream.</p>
<p style='display: block'><b>Features:</b></p>
<ul>
<li>Worksheet to image conversion</li>
<li>Saving workbooks as images of Bitmaps and metafiles</li>
</ul>"
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
                },
				ActionDescription = new string[] {
                @"<p>This sample demonstrates how to convert Worksheets to html files using Essential XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>This sample demonstrates how a worksheet or workbook is converted to HTML. The output file can be saved to disc and also as a memory stream.</p>"
                }
            },
			new Sample
            {
                Name = "Excel To JSON",
                Category = "Export",
                Directory = "FileFormats/XlsIO",
                Url = "xlsio/excel-to-json",
                Type = SampleType.New,
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
                },
                ActionDescription = new string[] {
                @"<p>This sample demonstrates the conversion of Excel documents to JSON file using Essential XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>Essential XlsIO supports to convert Excel data to JSON files by simply saving the workbook using the SaveAsJson method.</p>
<p style='display: block'><b>Features:</b></p>
<ul>
<li>Save as a simple JSON file or a JSON file with XML schema</li>
<li>Save a workbook to JSON</li>
<li>Save a worksheet to JSON</li>
<li>Save a range to JSON</li>
<li>Save as a stream with the above features</li>
</ul>"
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
                },
				ActionDescription = new string[] {
                @"<p>This sample demonstrates how to encrypt and decrypt workbooks using XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>This sample focuses on the encryption and decryption of an Excel 2007, Excel 2010, Excel 2013 and Excel 2016 workbook using Essential XlsIO.</p>
<p style='display: block'>Encryption is a method of protecting workbook data.It is based on a password that converts the data into a form that cannot be understood; it also restricts anonymous users from accessing a document. Decryption is the process of converting encrypted data back into its original form so that data can be read from the workbook.</p>
<p style='display: block'>A password for encrypting a workbook can be set in Microsoft Excel 2007, Excel 2010 and Excel 2013 through the Office Menu->Prepare->Encrypt Document command.</p>
<p style='display: block'><b>Note:</b> Password protection of a workbook file is different from the workbook structure and window protection you can set in the <b>Review->Protect Workbook</b></p>
<p style='display: block'><b>Features:</b></p>
<ul>
<li>Encrypting with a password</li>
<li>Decrypting with a password</li>
</ul>"
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
                },
				ActionDescription = new string[] {
                @"<p>This sample deomonstrates how to use tables in spreadsheets using XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>Microsoft Office Excel 2007, Excel 2010 and Excel 2013 provides tables support that makes managing and analyzing data with ease and efficient. These tables come with specific style support.</p>
<p style='display: block'>XlsIO supports reading and writing tables in Excel 2007, Excel 2010 and Excel 2013 formats. Tables can be created from any input range of sheet data and the total row can be inserted into the table. Styles can also be applied to the tables.</p>
<p style='display: block'><b>Features:</b></p>
<ul>
<li>Adding tables to a spreadsheet</li>
<li>Advanced options of Excel tables such as Total Rows and Styles</li>
<li>Advanced options of Excel tables such as custom table style</li>
</ul>"
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
                },
				ActionDescription = new string[] {
                @"<p>This sample demonstrates how to use AutoShapes in spreadsheets using XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>AutoShapes help you to draw objects on your document. You can create various shapes using AutoShapeType enumeration. Once you insert an AutoShape, you can also put a text inside it and you can move or resize them as you wish.</p>
<p style='display: block'>The <b>IShape</b> interface is the in-memory representation of the AutoShapes in an Excel workbook. These are used to create Autoshapes and to set properties for those shapes. The <b>ITextFrame</b> interface can be used to set various shape text formats.</p>
<p style='display: block'><b>Features:</b></p>
<p style='display: block'>Essential XlsIO supports all major AutoShape features.This sample demonstrates following features:</p>
<ul>
<li>Shape Text</li>
<li>Text Alignment</li>
<li>SolidFill</li>
</ul>"
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
                },
				ActionDescription = new string[] {
                @"<p>This sample demonstrates how to use group shapes in spreadsheets using XlsIO.</p>"
                },
                Description = new string[] {
                @"<p>Essential XlsIO allows to group multiple shapes and ungroup the shapes in worksheet. The IGroupShape interface is the in-memory representation of the group shapes in an Excel workbook.</p>
<p style='display: block'><b>Features:</b></p>
<p style='display: block'>This sample demonstrates following features:</p>
<ul>
<li>Grouping multiple shapes into a single group shape.</li>
<li>Ungroup the group shape and all its inner shapes.</li>
</ul>"
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
                ActionDescription = new string[] { @"<p>This sample demonstrates the creation of simple PDF document. It draws the string <b>Hello world!</b> in the desired location using the <a target=""_blank""
href=""https://help.syncfusion.com/file-formats/pdf/working-with-text?&_ga=2.149538486.100770749.1568799953-377997431.1559046126#draw-text-using-standard-fonts"">
PDF standard font.
</a></p>" },
                Description = new string[]{
      @"<p>It is also possible to draw different language of text with different fonts using <a target=""_blank""
href=""https://help.syncfusion.com/file-formats/pdf/working-with-text?_ga=2.150187830.100770749.1568799953-377997431.1559046126#draw-text-using-truetype-fonts"">
TrueType fonts
</a> and <a target=""_blank""
href=""https://help.syncfusion.com/file-formats/pdf/working-with-text?_ga=2.150187830.100770749.1568799953-377997431.1559046126#draw-text-using-cjk-fonts"">
CJK fonts.
</a></p>"
    },
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
                ActionDescription = new string[] { @"<p>This sample demonstrates the creation of job application form from the scratch using the <a target=""_blank""
href=""https://help.syncfusion.com/file-formats/pdf/working-with-forms"">form fields</a>. The user can fill the online job application, then download as a PDF document.</p>" },
                Description = new string[]{
      @"This is a good example that illustrates how to use the Essential PDF in any requirements like invoice, job applications, pay slips, bank statements and more."
    },
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
                ActionDescription = new string[] { @"This sample demonstrates the creation of PDF document with large text that flows over multiple pages.You can also draw multiple paragraphs sequentially."
                },
                Description = new string[]{
      @"<p>This feature can be used to create a large text in the PDF document. More information about the text element can be found in this documentation <a target=""_blank"" href=""https://help.syncfusion.com/file-formats/pdf/working-with-text"">section.</a></p>"
    },
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
                ActionDescription = new string[] { @"This sample demonstrates how to list the content in ordered and unordered list. The ordered list can be number or alphabets and the unordered list can be bullets, circles, and images." },
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
                ActionDescription = new string[] { @"This sample demonstrates drawing right-to-left language text in the PDF document. It is possible to draw RTL languages such as Arabic, Hebrew, Persian, Urdu and more."},
                Description = new string[] { @"<p>It is also possible to draw<a target=""_blank"" href=""https://help.syncfusion.com/file-formats/pdf/working-with-text#embedding-fonts-and-working-with-unicode-text""> Unicode text</a>. More information about drawing text can be found in this documentation <a target=""_blank"" href=""https://help.syncfusion.com/file-formats/pdf/working-with-text"">section.</a></p>" },         
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
                ActionDescription = new string[] { @"This sample demonstrates how to draw a text with OpenType font in a PDF document."},
                Description = new string[] { @"<p>It is also possible to draw<a target=""_blank"" href=""https://help.syncfusion.com/file-formats/pdf/working-with-text#embedding-fonts-and-working-with-unicode-text""> Unicode text</a>. More information about drawing text can be found in this documentation <a target=""_blank"" href=""https://help.syncfusion.com/file-formats/pdf/working-with-text"">section.</a></p>" },          
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
                ActionDescription = new string[] { @"This sample demonstrates the creation of barcode in the PDF document and does not requires barcode font for creating barcode.It supports both 1D and 2D barcode with many customizing properties."},
                Description = new string[]{
      @"<p>This feature can be used in invoice, super markets, health care systems and more. More information about the barcode can be found in this documentation <a target=""_blank""
href=""https://help.syncfusion.com/file-formats/pdf/working-with-barcode"">
section.
</a></p>"
    },   
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
                ActionDescription = new string[] { @"<p>This sample demonstrates drawing of <a target=""_blank"" href=""https://help.syncfusion.com/file-formats/pdf/working-with-shapes"">shapes</a>
        such as Ellipse, Arcs, Polygon, Pie and Rectangle in the PDF document with gradient and <a target=""_blank"" href=""https://help.syncfusion.com/file-formats/pdf/working-with-colorspace"">color spaces.</a></p>"},
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
                ActionDescription = new string[] { @"<p>This sample demonstrates drawing of shapes with different brushes such as solid, tiling, Linear gradient, Radial gradient and with different<a target=""_blank"" href=""https://help.syncfusion.com/file-formats/pdf/working-with-colorspace""> color spaces</a>. such as Cal RGB, ICC, Exponential interpolation, pantone and indexed color space.</p>"},
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
                ActionDescription = new string[] { @"This sample demonstrates insertion of various raster and vector images (JPEG, PNG, TIFF, EMF, and GIF) in the PDF document. This sample also demonstrates the image masking capability in the Essential PDF library." },
                Description = new string[]{
      @"<p>It is also possible to rotate and paginate the images in the PDF document. More information about the images can be found in this documentation <a target=""_blank""
href=""https://help.syncfusion.com/file-formats/pdf/working-with-images?_ga=2.150744822.1703522802.1584005056-1302582622.1556169414"">
section.
</a></p>" },
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
                ActionDescription = new string[] { @"This sample demonstrates the creation of richly formatted table to keep your data organized for both basic and advanced operation on cells, rows and columns along with headers and footers."
    },
                Description = new string[]{
      @"<p>More information about the document settings can be found in this documentation <a target=""_blank""
href=""https://help.syncfusion.com/file-formats/pdf/working-with-tables?_ga=2.224412378.1703522802.1584005056-1302582622.1556169414"">
section.
</a></p>" },
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
                ActionDescription = new string[] { @"This sample demonstrates how to digitally sign the PDF document with the PFX certificate file. It is possible to digitally sign with X509 certificates such as .pfx files with private keys and support for Hardware Security Module (HSM), Online Certificate Status Protocol (OCSP), Certificate Revocation List (CRL), and Windows Certificate Store to offer authenticity and integrity." },
                Description = new string[]{
      @"<p>It is also possible to digitally sign with <a target=""_blank""
href=""https://help.syncfusion.com/file-formats/pdf/working-with-digitalsignature?&_ga=2.217597654.1703522802.1584005056-1302582622.1556169414#adding-a-timestamp-in-digital-signature"">
timestamp.
</a> More information about the digital signature and timestamp can be found in this documentation <a target=""_blank""
href=""https://help.syncfusion.com/file-formats/pdf/working-with-digitalsignature?_ga=2.45302628.1703522802.1584005056-1302582622.1556169414"">
section.
</a></p>" },
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
                ActionDescription = new string[] { @" This sample demonstrates adding layers (Optional Content Group) with different shapes in the PDF document.
        The Essential PDF also supports to create, merge, and toggle the layers."
    },
                 Description = new string[]{
      @"<p>This feature can be used in CAD drawings, maps, layered artworks, and multi-language documents. More information about the layers can be found in this documentation <a target=""_blank""
href=""https://help.syncfusion.com/file-formats/pdf/working-with-layers?_ga=2.254863048.1703522802.1584005056-1302582622.1556169414"">
section.
</a></p>" },
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
                ActionDescription = new string[] { @"This sample demonstrates to find PDF document corruption by using Essential PDF." },
                Description = new string[]{
      @"<p>This feature allows you to find only PDF syntax level corruptions.</p>"
    },
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
                ActionDescription = new string[] { @"<p>This sample demonstrates the creation of interactive invoice with <a target=""_blank""
href=""https://help.syncfusion.com/file-formats/pdf/working-with-attachments"">
attachment</a>, product total price calculation based on the quantity using <a target=""_blank""
href=""https://help.syncfusion.com/file-formats/pdf/working-with-action#javascript-action"">
PDF JavaScript</a>.</p>" },
                Description = new string[]{
      @"<p>This example can be used in the real-time invoice generation with print, submit online, or mail the order functionalities.</p>"
    },
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
                ActionDescription = new string[] { @"This sample demonstrates how to create registration form using XFA form fields. The Essential PDF supports to create dynamic and static XFA form fields."
    }, 
               Description = new string[]{
      @"<p>More information about the XFA can be found in this documentation <a target=""_blank"" href=""https://help.syncfusion.com/file-formats/pdf/working-with-xfa"">section.</a></p>"
    },
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
                ActionDescription = new string[] { @"This sample demonstrates how to fill and flatten XFA form fields. It is possible to edit and remove the existing XFA form fields."
    },
                 Description = new string[]{
      @"<p>This feature can be used in filling forms from the database or from user and read out form fields for transferring user data to database. More information about the XFA can be found in this documentation <a target=""_blank""
href=""https://help.syncfusion.com/file-formats/pdf/working-with-xfa?_ga=2.213467860.1703522802.1584005056-1302582622.1556169414"">
section.
</a></p>" },
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
                ActionDescription = new string[] { @"<p>This sample demonstrates how to create portfolio in the PDF document. You can also extract and remove files from the PDF portfolio. This feature allows the user to bring content together from variety of sources including documents, drawings, images, emails, spreadsheets, and web pages.</p>"
    }, 

                Description = new string[]{
      @"<p>More information about the portfolio can be found in this documentation <a target=""_blank"" href=""https://help.syncfusion.com/file-formats/pdf/working-with-portfolio"">section.</a></p>"
    },
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
                Type = SampleType.New,
                ActionDescription = new string[] { @"<p>This sample demonstrates the creation of different type of annotations such as ink, free text, pop up, text markup annotation and more. The Essential PDF supports <a target=""_blank"" href=""https://help.syncfusion.com/file-formats/pdf/working-with-annotations#supported-annotation-types"">20+ annotations</a> with create, edit, and delete support.</p>"
    },

                Description = new string[]{
      @"<p>This feature can be used for reviewing purpose. More information about the annotations can be found in this documentation <a target=""_blank"" href=""https://help.syncfusion.com/file-formats/pdf/working-with-annotations"">section.</a></p>"
    },
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
                ActionDescription = new string[] { @"<p>This sample demonstrates how to overlay two different PDF documents into a single PDF document.</p>" },
                 Description = new string[]{
      @"<p>This feature can be used to draw template pages from one document into another for easy designing.</p>"
    },
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
                ActionDescription = new string[] { @"<p>This sample demonstrates how to rearrange pages from an existing PDF document to make the document meaningful.</p>" },
                 Description = new string[]{
      @"<p>More information about rearrange pages can be found in this documentation <a target=""_blank""
href=""https://help.syncfusion.com/file-formats/pdf/working-with-pages?&_ga=2.170051104.1263492038.1583640979-864754409.1576043073#rearranging-pages-in-an-existing-document"">
section.
</a></p>"
    },
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
                ActionDescription = new string[] { @"<p>This sample demonstrates how to create tagged PDF or accessible PDF from the scratch using auto tag feature.The auto tag feature will tag the document based on PDF element created in the document.</p>" } ,
                Description = new string[]{
      @"<p>This feature can be used for the people who require assistive technologies when the electronic content is ready. The Essential PDF supports creating tagged PDF with Section 508 compliant. More information about the tagged PDF can be found in this documentation <a target=""_blank""
href=""https://help.syncfusion.com/file-formats/pdf/working-with-tagged-pdf?_ga=2.212929108.1703522802.1584005056-1302582622.1556169414"">
section.
</a></p>" },
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
                ActionDescription = new string[] { @"<p>This sample demonstrates how to create tagged PDF or accessible PDF from the scratch with custom tags.</p>" },
                Description = new string[]{
      @"<p>This feature can be used for the people who require assistive technologies when the electronic content is ready. The Essential PDF supports creating tagged PDF with Section 508 compliant. More information about the tagged PDF can be found in this documentation <a target=""_blank""
href=""https://help.syncfusion.com/file-formats/pdf/working-with-tagged-pdf?_ga=2.212929108.1703522802.1584005056-1302582622.1556169414"">
section.
</a></p>"
    },
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
