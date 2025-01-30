#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
        public List<Sample> MarkdownEditor { get; set; } = new List<Sample> { 
            new Sample
            {
                Name = "Overview",
                Category = "Markdown Editor",
                Directory = "RichTextEditor/MarkdownEditor",
                Url = "markdown-editor/overview",
                FileName = "Overview.razor"
            },
            new Sample
            {
                Name = "Custom Format",
                Category = "Markdown Editor",
                Directory = "RichTextEditor/MarkdownEditor",
                Url = "markdown-editor/custom-format",
                FileName = "Custom-Format.razor"
            },
            new Sample
            {
                Name = "Mention Integration",
                Category = "Markdown Editor",
                Directory = "RichTextEditor/MarkdownEditor",
                Url = "markdown-editor/mention-integration",
                FileName = "Mention-Integration.razor"
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
                NotificationDescription = new string[] { @"The Rich Text Editor overview sample has been updated to configure the import/export feature directly within the Rich Text Editor. Previously, this was achieved at the application level, but now this support is provided at the source level." }
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "IFrame Mode",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/iframe-functionalities",
                FileName = "Iframe-Functionalities.razor"
            },
            new Sample
            {
                Name = "Inline Editor",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/inline",
                FileName = "Inline.razor"
            },
            new Sample
            {
                Name = "Image Option",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/image",
                FileName = "Image.razor"
            },
             new Sample
            {
                Name = "Insert Media",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url ="rich-text-editor/insert-media",
                FileName = "Insert-Media.razor",
            },
            new Sample
            {
                Name = "Paste Cleanup",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/paste-cleanup",
                FileName = "Paste-Cleanup.razor"
            },
              new Sample
            {
                Name = "Enter Key Configuration",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/enterKeyConfiguration",
                FileName = "EnterKey-Configuration.razor"
            },
            new Sample
            {
                Name = "Resizable Editor",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/resize-editor",
                FileName = "Resize-Editor.razor"
            },
            new Sample
            {
                Name = "Autosave Editor",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/auto-save",
                FileName = "AutoSave.razor"
            },
            new Sample
            {
                Name = "Form Validation",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/form-validation",
                FileName = "Form-Validation.razor"
            },
             new Sample
            {
                Name = "Type",
                Category = "Toolbar",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/types",
                FileName = "Types.razor"
            },
            new Sample
            {
                Name = "Quick Format Toolbar",
                Category = "Toolbar",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/quick-format-toolbar",
                FileName = "Quick-Format-Toolbar.razor",
            },
            new Sample
            {
                Name = "Mail Merge",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/mail-merge",
                FileName = "Mail-Merge.razor",
                NotificationDescription = new string[] {
                    @"Added a demo to showcase Mail Merge configuration of the Rich Text Editor component."
                }
            },
            new Sample
            {
                Name = "Import from Word",
                Category = "Export / Import",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/import-word",
                FileName = "Import.razor",
                NotificationDescription = new string[] { @"The Rich Text Editor import from word sample has been updated to configure the import feature directly within the Rich Text Editor. Previously, this was achieved at the application level, but now this support is provided at the source level." }
            },
            new Sample
            {
                Name = "Export to Word / PDF",
                Category = "Export / Import",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/export-word",
                FileName = "Export-Word.razor",
                NotificationDescription = new string[] { @"The Rich Text Editor export to pdf/word sample has been updated to configure the export feature directly within the Rich Text Editor. Previously, this was achieved at the application level, but now this support is provided at the source level." }
            },
            new Sample
            {
                Name = "@ Mention",
                Category = "Mention Integration",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/mention-integration",
                FileName = "Mention-Integration.razor"
            },
            new Sample
            {
                Name = "Smart Suggestion",
                Category = "Mention Integration",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/smart-suggestion",
                FileName = "Smart-Suggestion.razor"
            },
            new Sample
            {
                Name = "Custom Emoticons",
                Category = "Custom Toolbar Item",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/insert-emoticons",
                FileName = "InsertEmoticons.razor"
            },
                 new Sample
            {
                Name = "Special Characters",
                Category = "Custom Toolbar Item",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/insert-special-characters",
                FileName = "InsertSpecialCharacters.razor"
            },
            new Sample
            {
                Name = "Print",
                Category = "Miscellaneous",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/print",
                FileName = "Print.razor"
            },
            new Sample
            {
                Name = "API",
                Category = "Miscellaneous",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/api",
                FileName = "Api.razor"
            },
             new Sample
            {
                Name = "Events",
                Category = "Miscellaneous",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/events",
                FileName = "Events.razor"
            },
            new Sample
            {
                Name = "Forum Post Editor",
                Category = "Miscellaneous",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/usecase",
                FileName = "UseCase.razor"
            }
        };        
    }

}
