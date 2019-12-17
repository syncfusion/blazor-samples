using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ej2_blazor_samples
{

    internal partial class SampleConfig
    {
        public List<Sample> DocumentEditor { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "DocumentEditor",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                TitleTag = "Document Editor . Default Functionalities . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates how to create, edit, and print Word documents (DOCX) online using document editor",
                ActionDescription = new string[] {
                @"<p>This example demonstrates how to create, edit, and print Word documents (DOCX) online using document editor without any
                server-side dependencies.</p>"
                },
                Description = new string[] {
                @"<p>In this example, you can create and edit Word documents online much faster and easier using intuitive UI options of the
                document editor. All independent features of the document editor component are defined as separate modules to help
                build a lightweight Word editor with the features you require.</p>
                <p style='display: block'>Features of document editor:</p>
                <ul>
                <li>Create and edit: Opens and saves documents in native 'Syncfusion Document Text (*.sfdt)' file format without any
                    server-side dependencies. This helps build a purely client-side Word editor application.</li>
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
                Url = "DocumentEditor/CharacterFormat",
                FileName = "CharacterFormat.razor",
                TitleTag = "Document Editor . Character Format . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the character formatting options in DocumentEditor such as bold, italic, underline, strikethrough, subscript, superscript, font, font size, font color, and highlight color.",
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
                Url = "DocumentEditor/ParagraphFormat",
                FileName = "ParagraphFormat.razor",
                TitleTag = "Document Editor . Paragraph Formatting . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates paragraph formatting options in document editor such as indentation, spacing, and text alignment.",
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
                Url = "DocumentEditor/Styles",
                FileName = "Styles.razor",
                TitleTag = "Document Editor . Styles . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates character and paragraph formatting using styles in the document editor. Both built-in styles (for example, heading styles) and custom styles can be added.",
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
                Url = "DocumentEditor/BulletsAndNumbering",
                FileName = "BulletsAndNumbering.razor",
                TitleTag = "Document Editor . Bullets and Numbering . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates bullets and numbering support in document editor. Both single list and multi-level lists are supported.",
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
                Url = "DocumentEditor/HyperlinksAndBookmarks",
                FileName = "HyperlinksAndBookmarks.razor",
                TitleTag = "Document Editor . Hyperlinks and Bookmarks . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates hyperlinks and bookmarks support in document editor. A file, mail, webpage, or bookmark can be added as a link to the text.",
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
                Url = "DocumentEditor/TableFormat",
                FileName = "TableFormat.razor",
                TitleTag = "Document Editor . Table Formatting . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates table formatting options in document editor such as cell margins, cell spacing, horizontal merge, vertical merge, border styles, background color, and more.",
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
                Url = "DocumentEditor/SectionFormat",
                FileName = "SectionFormat.razor",
                TitleTag = "Document Editor . Section Formatting . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates section formatting options in document editor such as page margins, page size, header distance from top, and footer distance from bottom.",
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
                Url = "DocumentEditor/HeadersAndFooters",
                FileName = "HeadersAndFooters.razor",
                TitleTag = "Document Editor . Headers and Footers . Syncfusion Blazor Components",
                MetaDescription = "This, example demonstrates header and footer support in document editor. Different headers and footers can be added to the first page, odd pages, and even pages.",
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
                Url = "DocumentEditor/TableOfContents",
                FileName = "TableOfContents.razor",
                TitleTag = "Document Editor . Table of Contents . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates table of contents support in document editor. Many options are available for including table of contents such as hyperlink, page number, right-aligned tabs, and styles.",
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
            }

        };
    }

}