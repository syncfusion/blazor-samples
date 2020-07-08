using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_samples
{

    internal partial class SampleConfig
    {
        public List<Sample> DocumentEditor { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "DocumentEditor",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                ActionDescription = new string[] {
                @"<p>This example demonstrates how to create, edit, and print Word documents (DOCX) online using document editor.</p>"
                },
                Description = new string[] {
                @"<p>In this example, you can create and edit Word documents online much faster and easier using intuitive UI options of the
                document editor. All independent features of the document editor component are defined as separate modules to help
                build a lightweight Word editor with the features you require.</p>
                <p style='display: block'>Features of document editor:</p>
                <ul>
                <li>Create and edit: Opens and saves documents.</li>
                <li>Supported elements: Document elements like text, images, hyperlinks, tables, bookmarks, page numbers, tables of contents,
                    headers, and footers.</li>
                <li>Formatting: Text levels, paragraph levels, bullets and numbering, table levels, page settings, and styles.</li>
                <li>Editing operations: Undo, redo, cut, copy, and paste.</li>
                <li>Find and replace text within the document.</li>
                <li>Interactions through touch, mouse, and keyboard.</li>
                </ul>
                <p style='display: block'> More information about the document editor features can be found in this
                <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                </p>"
                }
            },
            new Sample
            {
                Name = "Character Formatting",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/character-format",
                FileName = "CharacterFormat.razor",
                ActionDescription = new string[] {
                @"<p>This example demonstrates the character formatting options in DocumentEditor such as bold, italic, underline, strikethrough,
                    subscript, superscript, font, font size, font color, and highlight color.</p>"
                },
                Description = new string[] {
                @"<p>In this example, you can find character formatting features in the document editor.</p>
                    <ul>
                        <li>Bold and Italic.</li>
                        <li>Underline.</li>
                        <li>Single strike and double strikes.</li>
                        <li>Superscript and subscript.</li>
                        <li>Font and highlight colors.</li>
                        <li>Different fonts and sizes.</li>
                    </ul>
                    <p style='display:block'> More information about the document editor features can be found in this <a target=""_blank""
                            href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                    </p>"
                }
            },
            new Sample
            {
                Name = "Paragraph Formatting",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/paragraph-format",
                FileName = "ParagraphFormat.razor",
                ActionDescription = new string[] {
                @"<p>This example demonstrates paragraph formatting options in document editor such as indentation, spacing, and text
                alignment.</p>"
                },
                Description = new string[] {
                @"<p>In this example, paragraph formatting features in the document editor can be found.</p>
                <ul>
                <li>Indentation: Left, right, first line, and hanging.</li>
                <li>Text alignment: Left, right, center, and justified.</li>
                <li>Paragraph spacing: before and after the paragraph.</li>
                <li>Line spacing.</li>
                <li>List format.</li>
                </ul>
                <p style=""display: block""> More information about the document editor features can be found in this <a target=""_blank""
                    href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                </p>"
                }
            },
            new Sample
            {
                Name = "Styles",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/styles",
                FileName = "Styles.razor",
                ActionDescription = new string[] {
                @"<p>This example demonstrates character and paragraph formatting using styles in document editor. Both built-in
                    styles (for example, heading styles) and custom styles can be added. </p>"
                },
                Description = new string[] {
                @"<p>In this example, you can use, add, modify, or delete built-in and custom styles.</p>
                    <p style=""display: block""> More information about the document editor features can be found in this <a target=""_blank""
                            href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                    </p>"
                }
            },
            new Sample
            {
                Name = "Bullets and Numbering",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/bullets-and-numbering",
                FileName = "BulletsAndNumbering.razor",
                ActionDescription = new string[] {
                @"<p>This example demonstrates bullets and numbering support in document editor. Both single list and multi-level lists
                    are supported. </p>"
                },
                Description = new string[] {
                @" <p>In this example, you can use, add, or modify the list formatting in document editor.</p>
                    <p style='display:block'> More information about the document editor features can be found in this <a target=""_blank""
                            href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                    </p>"
                }
            },
            new Sample
            {
                Name = "Hyperlinks and Bookmarks",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/hyperlinks-and-bookmarks",
                FileName = "HyperlinksAndBookmarks.razor",
                ActionDescription = new string[] {
                @"<p>This example demonstrates hyperlinks and bookmarks support in document editor. A file, mail, webpage, or bookmark can
                    be added as link to the text. </p>"
                },
                Description = new string[] {
                @"<p>In this example, you can find all the link types that can be added to a text or portions of text in the document editor.</p>
                    <ul>
                        <li>Link that refers to a webpage.</li>
                        <li>Link that refers to a mail.</li>
                        <li>Link that refers to a bookmark.</li>
                    </ul>
                    <p style=""display: block""> More information about the document editor features can be found in this <a target=""_blank""
                            href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                    </p>"
                }
            },
            new Sample
            {
                Name = "Table Formatting",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/table-format",
                FileName = "TableFormat.razor",
                ActionDescription = new string[] {
                @" <p>This example demonstrates table formatting options in document editor such as cell margins, cell spacing, horizontal
                    merge, vertical merge, border styles, background color, and more. </p>"
                },
                Description = new string[] {
                @"<p>In this example, you can find all the table formatting features.</p>
                    <ul>
                        <li>Cell margins and cell spacing.</li>
                        <li>Horizontal and vertical cell merge.</li>
                        <li>Borders and shading.</li>
                    </ul>
                    <p style=""display: block""> More information about the document editor features can be found in this <a target=""_blank""
                            href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                    </p>"
                }
            },
            new Sample
            {
                Name = "Section Formatting",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/section-format",
                FileName = "SectionFormat.razor",
                ActionDescription = new string[] {
                @"<p>This example demonstrates section formatting options in document editor such as page margins, page size, header distance
                    from top, and footer distance from bottom. </p>"
                },
                Description = new string[] {
                @"<p>Section formatting features in the document editor.</p>
                    <ul>
                        <li>Page size and page margins.</li>
                        <li>Header distance from the top.</li>
                        <li>Footer distance from the bottom.</li>
                    </ul>
                    <p style=""display: block""> More information about the document editor features can be found in this <a target=""_blank""
                            href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                    </p>"
                }
            },
            new Sample
            {
                Name = "Headers and Footers",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/headers-and-footers",
                FileName = "HeadersAndFooters.razor",
                ActionDescription = new string[] {
                @"<p>This example demonstrates header and footer support in document editor. Different headers and footers can be added
                    to the first page, odd pages, and even pages. </p>"
                },
                Description = new string[] {
                @"<p>Header and footer features in the document editor.</p>
                    <ul>
                        <li>Header and footer for the first page of the document.</li>
                        <li>Header and footer for even pages of the document.</li>
                        <li>Header and footer for odd pages of the document.</li>
                    </ul>
                    <p style=""display: block""> More information about the document editor features can be found in this <a target=""_blank""
                            href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                    </p>"
                }
            },
            new Sample
            {
                Name = "Table of Contents",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/table-of-contents",
                FileName = "TableOfContents.razor",
                ActionDescription = new string[] {
                @"<p>This example demonstrates table of contents support in document editor. Many options are available for including in
                table of contents such as hyperlink, page number, right-aligned tabs, and styles. </p>"
                },
                Description = new string[] {
                @"<p>In this example, you can find table of content options in document editor.</p>
                <ul>
                <li>Include hyperlink: A link with bookmark reference to the content will be included.</li>
                <li>Include page number: The page number of the content will be included.</li>
                <li>Right-aligned tabs: The page number will be right-aligned to the content.</li>
                <li>Heading levels: The range of heading levels to be included in the table can be customized.</li>
                <li>Styles: The style for each level of the table can be customized.</li>
                </ul>
                <p style=""display: block""> More information about the document editor features can be found in this <a target=""_blank""
                    href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                </p>"
                }
            },
              new Sample
            {
                Name = "Form Fields",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/form-fields",
                FileName = "FormFields.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                @"<p>This example demonstrate the design and fill legacy form fields(text, check box, and drop down).To unprotect the document, use password '123'.</p>"
                },
                Description = new string[] {
                @"<p>In this example you can find legacy form fields.</p>
                <ul>
                    <li>Text form field.</li>
                    <li>Check box form field.</li>
                    <li>Drop down field .</li>
                </ul>
                <p style=""display: block""> More information about the document editor features can be found in this <a target=""_blank""
                    href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                </p>"
                }
            },
             new Sample
            {
                Name = "Right To Left",
                Category = "RTL",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/right-to-left",
                FileName = "RightToLeft.razor",
                ActionDescription = new string[] {
                @"<p>RTL provides an option to switch the text direction and layout of the editor component from right to left. It improves the user experiences and accessibility for users who use right-to-left languages (Arabic, Farsi, Urdu, etc.). To enable RTL document-editor, set the `EnableRtl` to true.</p>"
                },
                Description = new string[] {
                @"<p>In this example, you can see document-editor right-to-left and the locale set in arabic[Locale value is ar-AE].</p>
                <<li>By default, `Locale` value is en-US. If you want to change the en-US culture to a different culture, you have to change the locale accordingly.</li>
                <p style=""display: block""> More information about the document editor features can be found in this <a target=""_blank""
                    href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                </p>"
                }
            },
             new Sample
            {
                Name = "Custom Context Menu",
                Category = "Customization",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/custom-context-menu",
                FileName = "CustomContextMenu.razor",
                ActionDescription = new string[] {
                @"<p>This example demonstrates how to add custom option in context menu and some customization for context menu.</p>"
                },
                Description = new string[] {
                @" <p>In this example, custom options added to search the selected text in google. The custom options will be visible
                        after selecting the text.</p>
                    <p style='display: block'>Context Menu Customization Features</p>
                    <ul>
                        <li>Hide existing menu item and show custom menu item alone. It will be achieved by passing boolean value in
                            second parameter of AddCustomMenu() method</li>
                        <li>Show the custom menu item in bottom of the exisiting item. It will be achieved by passing boolean value in
                            third parameter of AddCustomMenu() method</li>
                        <li>Custom Option Functionality achieved by using the `ContextMenuItemSelected` Event</li>
                    </ul>
                <p style=""display: block""> More information about the document editor features can be found in this <a target=""_blank""
                    href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                </p>"
                }
            },
             new Sample
            {
                Name = "Toolbar Customization",
                Category = "Customization",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/toolbar-customization",
                FileName = "ToolbarCustomization.razor",                
                ActionDescription = new string[] {
                @"<p>This example explains how to show or hide existing items in the toolbar.</p>"
                },
                Description = new string[] {
                @"<p>Existing toolbar items can be hidden, shown, enabled, and disabled. Also, new items can be added to the toolbar.</p>
                <p style=""display: block""> More information about the document editor features can be found in this <a target=""_blank""
                    href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                </p>"
                }
            },
             new Sample
            {
                Name = "Chart Preservation",
                Category = "Charts",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/chart",
                FileName = "Chart.razor",
                ActionDescription = new string[] {
                @"<p>This example shows chart preservation support in document editor.</p>"
                },
                Description = new string[] {
                @"<p>With Document Editor, you can see the chart reports from your word document</p>
                <p style=""display: block""> More information about the document editor features can be found in this <a target=""_blank""
                    href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                </p>"
                }
            },
             new Sample
            {
                Name = "Document Protection",
                Category = "Security",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/document-protection",
                FileName = "DocumentProtection.razor",
                ActionDescription = new string[] {
                @"<p>This example demonstrates document protection support in document editor to restrict the types of changes can be
        made to the document by a user/user group.To unprotect the document, use password '123'.</p>"
                },
                Description = new string[] {
                @"<p>In this demo, the Document editor opens a protected document that includes permitted ranges for two users
                    identified by email: each user is authorized to edit a separate text area.</p>
                <p>You can switch between the current user to edit different parts by selecting dropdown list in User permissions
                    pane.</p>
                <p>User can add the user in dropdown who have editing permission in document by using addItem method.</p>
                <p>The range that is enabled for the current user is highlighted.</p>
                <p> You can disable the highlighting or customize its color using the corresponding demo’s elements.</p>
                <p style=""display: block""> More information about the document editor features can be found in this <a target=""_blank""
                    href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                </p>"
                }
            },
            new Sample
            {
                Name = "Web Layout",
                Category = "View",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/web-layout",
                FileName = "WebLayout.razor",
                ActionDescription = new string[] {
                @"<p>This example explains about the continuous layout type to display the document in a single page. </p>"
                },
                Description = new string[] {
                @"<p>In this example, you can view the documents in single page using the Continuous layout type.</p>
                <ul>
                    <li>Pages.</li>
                    <li>Continuous.</li>
                </ul>
                <p style=""display: block""> More information about the document editor features can be found in this <a target=""_blank""
                    href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                </p>"
                }
            },
             new Sample
            {
                Name = "Comments",
                Category = "Review",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/comments",
                FileName = "Comments.razor",
                Type = SampleType.Updated,
                ActionDescription = new string[] {
                @"<p>This example demonstrates how to add and edit comments in a Word document using DocumentEditor.</p>"
                },
                Description = new string[] {
                @"<p>In this example, comments features in the document editor can be found.</p>
                <ul>
                    <li>Add a comment.</li>
                    <li>Reply to a comment.</li>
                    <li>Resolving the comment discussion.</li>
                </ul>
                <p style=""display: block""> More information about the document editor features can be found in this <a target=""_blank""
                    href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                </p>"
                }
            },
            new Sample
            {
                Name = "Track Changes",
                Category = "Review",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/track-changes",
                FileName = "TrackChanges.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                @"<p>This example demonstrates the track changes in DocumentEditor to view, make and accept or reject the changes.</p>"
                },
                Description = new string[] {
                @"<p>In this example, you can find track changes feature in the document editor.</p>
                <ul>
                    <li>Accept changes.</li>
                    <li>Reject changes.</li>
                    <li>Accept all.</li>
                    <li>Reject all.</li>
                </ul>
                <p style=""display: block""> More information about the document editor features can be found in this <a target=""_blank""
                    href=""https://ej2.syncfusion.com/blazor/documentation/"">documentation section.</a>
                </p>"
                }
            }
        };
    }

}