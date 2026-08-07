using System.Collections.Generic;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        private static readonly string[] APINotification = new string[]
        {
            @"The Blazor Rich Text Editor now includes support for chunk messages feature, enabling seamless transmission of large HTML content by sending it in smaller chunks, eliminating the need to increase the SignalR hub’s MaximumReceiveMessageSize limit (32 KB)."
        };
        private static readonly string[] ImageNotification = new string[]
        {
            @"The Blazor Rich Text Editor now includes support for image wrap, allowing text to align seamlessly around images by positioning them to the left or right."
        };

        public List<Sample> MarkdownEditor { get; set; } = new List<Sample> { 
            new Sample
            {
                Name = "Overview",
                Category = "Markdown Editor",
                Directory = "RichTextEditor/MarkdownEditor",
                Url = "markdown-editor/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor MarkdownEditor - Overview | MarkdownEditor Demos | Syncfusion",
                HeaderText = "Blazor Markdown Editor Example - Overview",
                MetaDescription = "See how the Syncfusion Blazor Markdown Editor enables markdown editing with live preview, syntax highlighting, and formatting tools to create content easily.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components"
            },
            new Sample
            {
                Name = "Custom Format",
                Category = "Markdown Editor",
                Directory = "RichTextEditor/MarkdownEditor",
                Url = "markdown-editor/custom-format",
                FileName = "Custom-Format.razor",
                MetaTitle = "Blazor MarkdownEditor Demos - Custom Format Examples | Syncfusion",
                HeaderText = "Blazor Markdown Editor Example - Custom Format",
                MetaDescription = "See how the Syncfusion Blazor Markdown Editor supports custom formatting and styling options to create personalized markdown content with flexibility."
            },
            new Sample
            {
                Name = "Mention Integration",
                Category = "Markdown Editor",
                Directory = "RichTextEditor/MarkdownEditor",
                Url = "markdown-editor/mention-integration",
                FileName = "Mention-Integration.razor",
                MetaTitle = "Blazor MarkdownEditor Demos - Mention Integration | Syncfusion",
                HeaderText = "Blazor Markdown Editor Example - Mention Integration",
                MetaDescription = "See how the Syncfusion Blazor Markdown Editor enables user mentions and tagging features to support collaboration and improve content editing workflow smoothly."
            },
        };
        public List<Sample> RichTextEditor { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor RichTextEditor - Overview | RichTextEditor Demos | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Overview",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor enables WYSIWYG editing with formatting tools, media support, and features for efficient content creation.",
                CustomCanonicalUrl = "https://www.syncfusion.com/rich-text-editor-sdk/blazor-rich-text-editor"
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor RichTextEditor - Default | RichTextEditor Demos | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor provides core editing features with formatting tools, text styling, and efficient content creation capabilities.",
                CustomCanonicalUrl = "https://www.syncfusion.com/rich-text-editor-sdk/blazor-rich-text-editor"
            },
            new Sample
            {
                Name = "IFrame Mode",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/iframe-functionalities",
                FileName = "Iframe-Functionalities.razor",
                MetaTitle = "Blazor RichTextEditor Demos - IFrame Mode Examples | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - IFrame Mode",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor uses IFrame mode to provide isolated editing with secure rendering and improved style control for better editing."
            },
            new Sample
            {
                Name = "Inline Editor",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/inline",
                FileName = "Inline.razor",
                MetaTitle = "Blazor RichTextEditor Demos - Inline Editor Examples | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Inline Editor",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor supports inline editing with contextual formatting tools for seamless content updates and modification."
            },
            new Sample
            {
                Name = "Image Option",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/image",
                FileName = "Image.razor",
                MetaTitle = "Blazor RichTextEditor Demos - Image Option Examples | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Image Option",
                Type = SampleType.Updated,
                NotificationDescription = ImageNotification,
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor supports image insertion, resizing, and formatting to create rich multimedia content efficiently and effectively."
            },
             new Sample
            {
                Name = "Insert Media",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url ="rich-text-editor/insert-media",
                FileName = "Insert-Media.razor",
                MetaTitle = "Blazor RichTextEditor Demos - Insert Media Examples | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Insert Media",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor enables inserting images, audio, and video content to create rich and interactive content efficiently today."
            },
            new Sample
            {
                Name = "Paste Cleanup",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/paste-cleanup",
                FileName = "Paste-Cleanup.razor",
                MetaTitle = "Blazor RichTextEditor Demos - Paste Cleanup Examples | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Paste Cleanup",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor cleans pasted content by removing unwanted styles to ensure consistent formatting and clean layout structure."
            },
             new Sample
            {
                Name = "Format Painter",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/format-painter",
                FileName = "Format-Painter.razor",
                MetaTitle = "Blazor RichTextEditor Demos - Format Painter Examples | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Format Painter",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor uses format painter to copy and apply text styles for consistent formatting across different content sections."
            },
              new Sample
            {
                Name = "Enter Key Configuration",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/enterKeyConfiguration",
                MetaTitle = "Blazor RichTextEditor Demos - Enter Key Configuration | Syncfusion",
                FileName = "EnterKey-Configuration.razor",
                HeaderText = "Blazor Rich Text Editor Example - Enter Key Configuration",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor customizes enter key behavior for paragraph creation and line break control during editing workflow processes. "
            },
            new Sample
            {
                Name = "Resizable Editor",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/resize-editor",
                FileName = "Resize-Editor.razor",
                MetaTitle = "Blazor RichTextEditor Demos - Resizable Editor Examples | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Resizable Editor",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor supports resizing with drag handles to adjust editor dimensions for better content editing and layout control."
            },
            new Sample
            {
                Name = "Autosave Editor",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/auto-save",
                FileName = "AutoSave.razor",
                MetaTitle = "Blazor RichTextEditor Demos - Autosave Editor Examples | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Autosave Editor",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor automatically saves content to prevent data loss and ensure safe editing during content creation tasks.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="AutoSave.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultCss",
                        FileName="AutoSave.razor.css"
                    }
                }
            },
            new Sample
            {
                Name = "Form Validation",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/form-validation",
                FileName = "Form-Validation.razor",
                MetaTitle = "Blazor RichTextEditor Demos - Form Validation Examples | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Form Validation",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor integrates with form validation to enforce rules and ensure data integrity in content submission workflows."
            },
            new Sample
            {
                Name = "Type",
                Category = "Toolbar",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/types",
                FileName = "Types.razor",
                MetaTitle = "Blazor RichTextEditor - Type | RichTextEditor Demos | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Type",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor supports different toolbar modes and UI types to customize editing experience and layout configurations."
            },
            new Sample
            {
                Name = "Quick Format Toolbar",
                Category = "Toolbar",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/quick-format-toolbar",
                FileName = "Quick-Format-Toolbar.razor",
                MetaTitle = "Blazor RichTextEditor Demos - Quick Format Toolbar | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Quick Format Toolbar",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor shows quick format toolbar on selection to apply styles quickly and improve editing speed and efficiency."
            },
            new Sample
            {
                Name = "Mail Merge",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/mail-merge",
                FileName = "Mail-Merge.razor",
                MetaTitle = "Blazor RichTextEditor Demos - Mail Merge Examples | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Mail Merge",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor Mail Merge example demonstrates template-based content generation with dynamic data insertion for workflows."
            },
            new Sample
            {
                Name = "Import from Word",
                Category = "Export / Import",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/import-word",
                FileName = "Import.razor",
                MetaTitle = "Blazor RichTextEditor Demos - Import from Word Examples | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Import from Word",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor Import example demonstrates importing Word documents with formatting preservation for seamless editing."
            },
            new Sample
            {
                Name = "Export to Word / PDF",
                Category = "Export / Import",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/export-word",
                MetaTitle = "Blazor RichTextEditor Demos - Export to Word / PDF | Syncfusion",
                FileName = "Export-Word.razor",
                HeaderText = "Blazor Rich Text Editor Example - Export to Word / PDF",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor Export example demonstrates exporting content to Word and PDF formats with formatting preservation for sharing."
            },
            new Sample
            {
                Name = "@ Mention",
                Category = "Mention Integration",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/mention-integration",
                FileName = "Mention-Integration.razor",
                MetaTitle = "Blazor RichTextEditor - @ Mention | RichTextEditor Demos | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - @ Mention",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor @ Mention example demonstrates user tagging with autocomplete suggestions for collaborative content creation."
            },
            new Sample
            {
                Name = "Smart Suggestion",
                Category = "Mention Integration",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/smart-suggestion",
                FileName = "Smart-Suggestion.razor",
                MetaTitle = "Blazor RichTextEditor Demos - Mention Integration | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Smart Suggestion",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor Smart Suggestion demonstrates intelligent content suggestions and slash commands for improved productivity."
            },
            new Sample
            {
                Name = "Custom Emoticons",
                Category = "Custom Toolbar Item",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/insert-emoticons",
                FileName = "InsertEmoticons.razor",
                MetaTitle = "Blazor RichTextEditor Demos - Custom Emoticons Examples | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Custom Emoticons",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor Custom Emoticons example demonstrates emoji insertion with toolbar integration for expressive content creation."
            },
                 new Sample
            {
                Name = "Special Characters",
                Category = "Custom Toolbar Item",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/insert-special-characters",
                FileName = "InsertSpecialCharacters.razor",
                MetaTitle = "Blazor RichTextEditor Demos - Special Characters | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Special Characters",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor Special Characters example demonstrates symbol insertion with toolbar support for flexible text formatting."
            },
            new Sample
            {
                Name = "Print",
                Category = "Miscellaneous",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/print",
                FileName = "Print.razor",
                MetaTitle = "Blazor RichTextEditor - Print | RichTextEditor Demos | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Print",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor Print example demonstrates printing capabilities with layout options for generating formatted document outputs."
            },
            new Sample
            {
                Name = "API",
                Category = "Miscellaneous",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/api",
                FileName = "Api.razor",
                MetaTitle = "Blazor RichTextEditor - API | RichTextEditor Demos | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - API",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor API example demonstrates programmatic control and methods for dynamic content manipulation and configuration.",
                Type = SampleType.Updated,
                NotificationDescription = APINotification
            },
             new Sample
            {
                Name = "Events",
                Category = "Miscellaneous",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/events",
                FileName = "Events.razor",
                MetaTitle = "Blazor RichTextEditor - Events | RichTextEditor Demos | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Events",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor Events example demonstrates event handling for user interactions, content changes, and lifecycle management."
            },
            new Sample
            {
                Name = "Forum Post Editor",
                Category = "Miscellaneous",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/usecase",
                FileName = "UseCase.razor",
                MetaTitle = "Blazor RichTextEditor Demos - Forum Post Editor Examples | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Forum Post Editor",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor Forum Post example demonstrates real-world usage for forums and platforms with structured content editing."
            },
             new Sample
            {
                Name = "Bottom Toolbar",
                Category = "Toolbar",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/bottom-toolbar",
                FileName = "Bottom-Toolbar.razor",
                MetaTitle = "Blazor RichTextEditor Demos - Bottom Toolbar Examples | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Bottom Toolbar",
                MetaDescription = "See how the Syncfusion Blazor Rich Text Editor Bottom Toolbar example demonstrates toolbar positioning for customized layouts and improved user usability."
            }
        };        
    }

}