using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> RichTextEditor { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/overview",
                FileName = "Overview.razor",
                Type = SampleType.New,
                TitleTag = "RichTextEditor . Overview . Syncfusion Blazor Components",
                MetaDescription = "This demo describes basic and advanced features of the blazor rich text editor control (WYSIWYG HTML Editor) with all its tools and functionalities.",
                ActionDescription = new string[] {
                @"<p>This sample demonstrates the full features of Rich Text Editor that includes all the tools and functionalities.</p>"
            },
            Description = new string[] {
                @"<p>The editor’s toolbar contains commands to format the content. The toolbar consists of:</p>
                    <ul>
                        <li><code>Lists</code> - Ordered and unordered list types.</li>
                        <li><code>Links</code> - A hyperlink can be inserted into the editor for quick access to related information.</li>
                        <li><code>Image</code> - Inserts and manages images.</li>
                        <li><code>Table</code> - Inserts and manages Tables.</li>
                        <li><code>Alignment</code> - Aligns the content with left, center, and right margins.</li>
                        <li><code>Undo/Redo</code> - Allows undo/redo operations.</li>
                        <li><code>Indent/ Outdent</code> - Increases/decreases the indent level of the content.</li>
                        <li><code>Font</code> - Able to do styling on text like font family, size, fore color and background color.</li>
                        <li><code>Lower / Upper case</code> – Changes the casing of the selected text.</li>
                        <li><code>SubScript / SuperScript</code> - Makes the selected text as subscript (lower)/superscript(upper).</li>
                        <li><code>Format</code> – Formats the sentence in different ways such as heading level, quotation, and code snippet</li>
                        <li><code>Styles</code> – Allows you to apply inline styles to the selected content like bold, italic, and more.</li>
                    </ul>"
            }
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                TitleTag = "RichTextEditor . Default Functionalities . Syncfusion Blazor Components",
                MetaDescription = "This demo shows how to render blazor rich text editor (WYSIWYG HTML editor) control with a minimum configuration setting.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default rendering of the Rich Text Editor with minimum configuration in Razor application.</p>"
                },
                Description = new string[] {
                    @"<p>
                        The Rich Text Editor is WYSIWYG (""what you see is what you get"") editor that is used to create and
                        edit content, and return valid HTML markup. The editor provides a standard toolbar to format content using its commands.
                        The toolbar contains commands to align the text,
                        insert link, insert image, insert list, undo / redo the operation, HTML view, and more.
                    </ p > "
                }
            },
            new Sample
            {
                Name = "Image",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/image",
                FileName = "Image.razor",
                Type = SampleType.New,
                TitleTag = "RichTextEditor . Image . Syncfusion Blazor Components",
                MetaDescription = "This demo explains how to insert images with a blob or base64 format, link to the images, image upload, rotate left/right, and more in Blazor WYSIWYG HTML Editor.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the option to insert the image to the Rich Text Editor content. Click the image button from the toolbar item to insert the image.</p>"
                },
                Description = new string[] {
                    @"<p>
                        Image tools used to insert an image to the Rich Text Editor and click on the image to easily customize the image using quick toolbar. The quick toolbar has the following items
                        <ul>
                            <li><code>Replace</code> - can replace the image with some other image.</li>
                            <li><code>Align</code> -Align the image with left, right and justify.</li>
                            <li><code>Image captions</code> - set the captions for the image.</li>
                            <li><code>Change size</code> - modify width and height of image.</li>
                            <li><code>Delete</code> - delete the image.</li>
                            <li><code>Link </code> - provide the link to the image.</li>
                            <li><code>Display</code> - display the image as inline or with break.</li>
                            <li><code>Alternate text</code> - provide the alternative text for the image if the image is not present in the location.</li>
                            <li><code>Custom Tools</code> – 'rotation' related commands are added as custom commands to the image element</li>
                            <li><code>Resize</code> – can resize the image dimension with resize options.</li>
                        </ul>
                        Quick commands are opened as context-menu on clicking the corresponding element. The commands must be passed as string collection to image, text, and link attributes of the <code>QuickToolbarSettings</code> property.
                    </p> "
                }
            },
            new Sample
            {
                Name = "Inline",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/inline",
                FileName = "Inline.razor",
                Type = SampleType.New,
                TitleTag = "RichTextEditor . Inline . Syncfusion Blazor Components",
                MetaDescription = "This demo shows inline WYSIWYG HTML editor that is displayed when selecting the content or simply focusing on the content inside the Blazor Rich Text Editor.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the toolbar show on inline mode. Toolbar show while selection on the below editable content and
                        it hide on focus out from edit area.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The Rich Text Editor provides an option to display toolbar on demand using <code>InlineMode</code> property. Set mode as inline to enable
                        inline editor. The toolbar becomes visible only when the content is selected
                    </p>"
                }
            },
            new Sample
            {
                Name = "IFrame Functionalities",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/iframe-functionalities",
                FileName = "Iframe-Functionalities.razor",
                Type = SampleType.New,
                TitleTag = "RichTextEditor . IFrame Functionalities . Syncfusion Blazor Components",
                MetaDescription = "This demo shows how to render a classic blazor rich text editor (iframe editor) that was designed by using the iframe element covering all tool functionalities.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default rendering of the Rich Text Editor in <code>iframe</code>.</p>"
                },
                Description = new string[] {
                    @"<p>
                        The Rich Text Editor is WYSIWYG (""what you see is what you get"") editor that is used to create and edit content, and return valid HTML markup. The editor provides a standard toolbar to format content using its commands. The toolbar contains commands to align the text, insert link, insert image,
                        insert list, undo/redo the operation, HTML view, and more.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Print",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/print",
                FileName = "Print.razor",
                Type = SampleType.New,
                TitleTag = "RichTextEditor . Print . Syncfusion Blazor Components",
                MetaDescription = "This demo sample shows how to print the content of the blazor rich text editor (HTML editor) with styles and formatting using the print module.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates how to print the content of the Rich Text Editor. Click the print command which placed in toolbar of Rich Text Editor to print the editor's content.</p>"
                }
            },
             new Sample
            {
                Name = "Type",
                Category = "Toolbar",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/types",
                FileName = "Types.razor",
                Type = SampleType.New,
                TitleTag = "RichTextEditor . Type . Syncfusion Blazor Components",
                MetaDescription = "This demo demonstrates different types and behaviors of a toolbar used in the Blazor HTML Editor such as expand/collapse, multirow, and floating.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the different behavior of toolbar support in the Rich Text Editor. Change the toolbar type as multiRow or expand from the property panel to see its appearance . Check or uncheck the floating toolbar in property panel to look on its behavior.</p>"
                },
                Description = new string[] {
                    @"<p><code>Floating</code>: set boolean value to toolbarSettings.<code>enableFloating</code> property to enable or disable the floating toolbar.</p>
                <p> The Rich Text Editor allows you to configure different types of toolbar using <code>ToolbarSettings.Type</code> property. The types of
                    toolbar are: </p>
                <ul>
                    <li><code>Expand</code>: The toolbar hides the overflowing items in the next row. Click the expand arrow to view overflowing toolbar items</li>
                    <li><code>MultiRow</code>: The toolbar hides the overflowing items in the next row.</li>
                </ul>"
                }
            },
            new Sample
            {
                Name = "Markdown Overview",
                Category = "Markdown",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/markdown-overview",
                FileName = "Markdown-Overview.razor",
                Type = SampleType.New,
                TitleTag = "RichTextEditor . Markdown Overview . Syncfusion Blazor Components",
                MetaDescription = "This demo covers all supported features and functionalities of the blazor Markdown editor, which  is another mode of the Blazor Rich Text Editor.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates markdown editing in the Rich Text Editor with complete features.</p>"
                },
                Description = new string[] {
                    @"<p>The Rich Text Editor supports markdown editing when the <code>EditorMode</code> is set to mode property of the Rich Text Editor</p>
                   <ul>
                       <li><code>Lists</code> - Ordered and unordered list types.</li>
                        <li><code>Links</code> - A hyperlink can be inserted into the editor for quick access to related information.</li>
                        <li><code>Image</code> - Inserts and manages images.</li>
                        <li><code>Alignment</code> - Aligns the content with left, center, and right margins.</li>
                        <li><code>Format</code> – Formats the sentence in different ways such as heading level, quotation, and code snippet</li>
                        <li><code>Styles</code> – Allows you to apply inline styles to the selected content like bold, italic, and more.</li>
                        <li><code>Tables</code> – Allows you to insert a table with header.</li>
                    </ul>"
                }
            },
            new Sample
            {
                Name = "Custom Format",
                Category = "Markdown",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/markdown-custom-format",
                FileName = "Markdown-Custom-Format.razor",
                Type = SampleType.New,
                TitleTag = "RichTextEditor . Custom Format . Syncfusion Blazor Components",
                MetaDescription = "This demo explains how to convert markdown content (with the custom format) to valid HTML markup using Markdown-to-HTML of the markdown parser in Blazor.",
                ActionDescription = new string[] {
                    @"<p> This sample demonstrates how to customize tags of markdown formatting. Type or edit the text and apply the format to view customized markdown syntax. For example, apply “+” to Unordered list. </p>"
                },
                Description = new string[] {
                    @"    The Rich Text Editor allows you to customize the markdown syntax by overriding its default syntax. Configure the customized
                markdown syntax using the <code>Formatter</code>property"
                }
            },
            new Sample
            {
                Name = "Paste from MS Word",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/paste-cleanup",
                FileName = "Paste-Cleanup.razor",
                Type = SampleType.New,
                TitleTag = "RichTextEditor . Paste from MS Word . Syncfusion Blazor Components",
                MetaDescription = "This demo explains how to clean up HTML when pasting a content from Microsoft Word, Visual Studio Code, Visual Studio, or a web page in Blazor HTML Editor.",
                ActionDescription = new string[] {
                    @"<p>This example demonstrates the paste cleanup feature of the Rich Text Editor control. Copy your content from MS Word or other website, and paste it within the editor to cleanup.</p>"
                },
                Description = new string[] {
                    @"<p>The Rich Text Editor allows to paste the HTML content from MS Word or other websites. The editor cleanup the pasted HTML content by considering the following items.</p>
                <ul>
                    <li>The unformatted HTML element (MOS XML format) content to standard HTML elements.</li>
                    <li>The MS Office prefixed style properties is converted to proper CSS style properties.</li>
                    <li>The unwanted tags, CSS styles, and comments are removed from the copied content.</li>
                </ul>
                <p>The following settings are available to cleanup the content in pasteCleanup settings property:</p>
                <ul>
                    <li>Select any option in <code>Format Option</code> drop down list for the paste content.
                        <ul>
                            <li>Select the <code>Prompt</code> option to invoke prompt dialog with paste options on pasting the content in editor.</li>
                            <li>Select the <code>Plain Text</code> option to paste the content as plain text.</li>
                            <li>Select the <code>Keep Format</code> option to keep the same format in the copied content.</li>
                            <li>Select the <code>Clean Format</code> option to remove the style format in the copied content.</li>
                        </ul>
                    </li>
                    <li>Fill the <code>Denied Tags</code> text box to ignore the tags when pasting HTML content. For example:
                        <ul>
                            <li><b>['a[!href]']</b> - paste the content by filtering anchor tags that don’t have the 'href' attribute.</li>
                            <li><b>['a[href, target]']</b> - paste the content by filtering anchor tags that have the 'href' and 'target' attributes.</li>
                        </ul>
                    </li>
                    <br/>
                    <li>Fill the <code>Denied Attributes</code> to paste the content by filtering out these attributes from the content. For example:
                        <ul>
                            <b>['id', 'title']</b> - This will remove the attributes 'id' and 'title' from all tags.
                        </ul>
                    </li>
                    <br/>
                    <li>Fill the <code>Allowed Style properties</code> to paste the content by accepting these style attributes and removing other attributes. For example:
                        <ul>
                            <b>['color', 'margin']</b> - This will allow only the style properties 'color' and 'margin' in each pasted element.
                        </ul>
                    </li>
                </ul>"
                }
            },
            new Sample
            {
                Name = "Resizable Editor",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/resize-editor",
                FileName = "Resize-Editor.razor",
                Type = SampleType.New,
                TitleTag = "RichTextEditor . Resizable Editor . Syncfusion Blazor Components",
                MetaDescription = "This demo explains how to render a resizable Blazor Editor that allows resizing an editor and viewing its content with an enlarging or shrunk scale.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the resize operation of the Rich Text Editor control. To resize the rich text editor, select and resize the editor using its handle (grip) at the bottom right corner of the content panel.</p>"
                },
                Description = new string[] {
                    @"<p>Users can create resizable Rich Text Editor by setting the <code>EnableResize</code> property to true, which is used to change the size of the Rich Text Editor dynamically.</p>"
                }
            },
            new Sample
            {
                Name = "API",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/api",
                FileName = "Api.razor",
                Type = SampleType.New,
                TitleTag = "RichTextEditor . API . Syncfusion Blazor Components",
                MetaDescription = "This demo covers important APIs of the blazor rich text editor such as content length, HTML encoding, read-only, retrieve the selected content, and more.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrate the usage of API in Rich Text Editor, use the properties panel to change the maximum length, read
                    only mode, disable status, to get value, enable HTML encode, select all content and get selected HTML from the Rich Text Editor.</p>"
                },
                Description = new string[] {
                    @"<p>In this demos, Ensuring the API'S behavious by doing</p>
                <ul>
                    <li>Change the value of <code>MaxLength</code> textbox to change maximum Length of character.</li>
                    <li>Click the <code>ReadOnly</code> check box to enable/disable editable and non-editable mode of the RTE.</li>
                    <li>Click the <code>Enabled</code> check box to enable/disable the RTE component.</li>
                    <li>Click the <code>EnableHtmlEncode</code> check box to enableHtmlEncode/disableHtmlEncode the RTE component.</li>
                    <li>Click the <code>GetValue</code> button which shows the RTE values in the alert window.</li>
                    <li>Click the <code>SelectAll</code> button selecting all text content in the RTE.</li>
                </ul>"
                }

            },
            new Sample
            {
                Name = "Form Validation",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/form-validation",
                FileName = "Form-Validation.razor",
                Type = SampleType.New,
                TitleTag = "RichTextEditor . Form Validation . Syncfusion Blazor Components",
                MetaDescription = "This demo shows how to validate the content of the Blazor WYSIWYG editor using obtrusive validation  with the Form validation library.",
                ActionDescription = new string[] {
                    @"<p>This sample is used to validate form using the <code>Data Annotation</code>. Type the values in Rich Text Editor and
                    click the button to validate the form.</p>"
                },
                Description = new string[] {
                    @"<p>The form enables the validation with data annotation attributes by clicking on the submit externally. All rules are validated
                    by the <code>DataAnnotationsValidator</code>.</p>"
                }
            }
        };      
    }

}
