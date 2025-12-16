#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
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
                FileName = "Overview.razor",
                MetaTitle = "Blazor Markdown Editor Overview | Text Editing | Syncfusion",
                HeaderText = "Blazor Markdown Editor Example - Overview",
                MetaDescription = "This Blazor Markdown Editor overview shows markdown text editing with live preview, syntax highlighting, comprehensive formatting tools for content creation."
            },
            new Sample
            {
                Name = "Custom Format",
                Category = "Markdown Editor",
                Directory = "RichTextEditor/MarkdownEditor",
                Url = "markdown-editor/custom-format",
                FileName = "Custom-Format.razor",
                MetaTitle = "Blazor Markdown Custom Format | Custom Styling | Syncfusion",
                HeaderText = "Blazor Markdown Editor Example - Custom Format",
                MetaDescription = "This Blazor Markdown Editor Custom Format demonstrates the custom formatting options and styling capabilities for personalized markdown content creation."
            },
            new Sample
            {
                Name = "Mention Integration",
                Category = "Markdown Editor",
                Directory = "RichTextEditor/MarkdownEditor",
                Url = "markdown-editor/mention-integration",
                FileName = "Mention-Integration.razor",
                MetaTitle = "Blazor Markdown Mention | User Tagging | Syncfusion",
                HeaderText = "Blazor Markdown Editor Example - Mention Integration",
                MetaDescription = "This Blazor Markdown Editor Mention Integration demonstrates user tagging and mention functionality for collaborative content creation and social features."
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
                NotificationDescription = new string[]{@"The Rich Text Editor Overview sample has been updated to include a line-height feature, allowing users to adjust spacing between lines of text for better readability and formatting."},
                Type = SampleType.Updated,
                MetaTitle = "Blazor Rich Text Editor Overview | WYSIWYG Editor | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Overview",
                MetaDescription = "This Blazor Rich Text Editor overview shows comprehensive WYSIWYG editing with formatting tools, media insertion, and advanced features for content creation."
               },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Rich Text Editor Default Functionalities - Syncfusion Demos",
                HeaderText = "Blazor Rich Text Editor Example - Default Functionalities",
                MetaDescription = "This Blazor Rich Text Editor default demo shows essential WYSIWYG editing features with formatting tools, text styling, and basic content creation capabilities."
            },
            new Sample
            {
                Name = "IFrame Mode",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/iframe-functionalities",
                FileName = "Iframe-Functionalities.razor",
                Type = SampleType.Updated,
                MetaTitle = "Blazor Rich Text Editor IFrame | Isolated Editing | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - IFrame Mode",
                NotificationDescription = new string[]{@"The Rich Text Editor Iframe sample has been updated to include a line-height feature, allowing users to adjust spacing between lines of text for better readability and formatting."},
                MetaDescription = "This Blazor Rich Text Editor IFrame Mode demonstrates isolated editing environment with the iframe rendering for enhanced security and style isolation."
            },
            new Sample
            {
                Name = "Inline Editor",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/inline",
                FileName = "Inline.razor",
                MetaTitle = "Blazor Inline Rich Text Editor | In-Place Editing | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Inline Editor",
                MetaDescription = "This Blazor Inline Rich Text Editor demonstrates in-place editing capabilities with the contextual formatting tools for seamless content modification."
            },
            new Sample
            {
                Name = "Image Option",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/image",
                FileName = "Image.razor",
                MetaTitle = "Blazor Rich Text Editor Image | Media Insertion | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Image Option",
                MetaDescription = "This Blazor Rich Text Editor Image Option example demonstrates image insertion, resizing, and formatting capabilities for rich multimedia content creation."
            },
             new Sample
            {
                Name = "Insert Media",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url ="rich-text-editor/insert-media",
                FileName = "Insert-Media.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{@"The Rich Text Editor Insert Media sample now supports drag-and-drop for video and audio files, making it easier to add media directly into the editor."},
                MetaTitle = "Blazor Rich Text Editor Media | Multimedia Content | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Insert Media",
                MetaDescription = "This Blazor Rich Text Editor Insert Media demonstrates multimedia content insertion including images, videos, and audio for comprehensive content creation."
            },
            new Sample
            {
                Name = "Paste Cleanup",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/paste-cleanup",
                FileName = "Paste-Cleanup.razor",
                MetaTitle = "Blazor Rich Text Editor Paste Cleanup | Content Filter | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Paste Cleanup",
                MetaDescription = "This Blazor Rich Text Editor Paste Cleanup demonstrates content filtering and formatting cleanup when pasting from external sources for consistent styling."
            },
             new Sample
            {
                Name = "Format Painter",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/format-painter",
                FileName = "Format-Painter.razor",
                MetaTitle = "Blazor Rich Text Editor Format Painter | Style Copy | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Format Painter",
                MetaDescription = "This Blazor Rich Text Editor Format Painter demonstrates copying and applying formatting styles from one content to another for consistent text styling."
            },
              new Sample
            {
                Name = "Enter Key Configuration",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/enterKeyConfiguration",
                MetaTitle = "Rich Text Editor Enter Key Configuration - Syncfusion Demos",
                FileName = "EnterKey-Configuration.razor",
                HeaderText = "Blazor Rich Text Editor Example - Enter Key Configuration",
                MetaDescription = "This Blazor Rich Text Editor Enter Key Configuration example demonstrates customizable enter key behavior for paragraph creation and line break management."
            },
            new Sample
            {
                Name = "Resizable Editor",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/resize-editor",
                FileName = "Resize-Editor.razor",
                MetaTitle = "Blazor Resizable Rich Text Editor | Dynamic Sizing | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Resizable Editor",
                MetaDescription = "This Blazor Resizable Rich Text Editor demonstrates dynamic sizing with drag handles. Customize editing area dimensions for an optimal content creation."
            },
            new Sample
            {
                Name = "Autosave Editor",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/auto-save",
                FileName = "AutoSave.razor",
                MetaTitle = "Blazor Rich Text Editor Autosave | Content Backup | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Autosave Editor",
                MetaDescription = "This Blazor Rich Text Editor Autosave example demonstrates automatic content saving functionality to prevent data loss during content creation and editing."
            },
            new Sample
            {
                Name = "Form Validation",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/form-validation",
                FileName = "Form-Validation.razor",
                MetaTitle = "Blazor Rich Text Editor Validation | Form Integration | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Form Validation",
                MetaDescription = "This Blazor Rich Text Editor Form Validation example demonstrates integration with form validation systems for required content and data integrity checks."
            },
#if SERVER
            new Sample
            {
                Name = "AI Writing Assistant",
                Category = "Smart AI Solutions",
                Directory = "AISamples/RichTextEditor",
                Url = "rich-text-editor/ai-assistant",
                FileName = "AIAssistant.razor",
                MetaTitle = "Blazor Rich Text Editor AIAssistant - Syncfusion AI Demos",
                HeaderText = "Blazor Rich Text Editor Example - AI Writing Assistant",
                MetaDescription = "This demo shows intelligent content creation, text enhancement, contextual writing suggestions powered by artificial intelligence for improved content quality.",
                NotificationDescription = new string[]{ @" This demo showcases the Rich Text Editor AI feature." },
                Type = SampleType.AI
            },
#endif
             new Sample
            {
                Name = "Type",
                Category = "Toolbar",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/types",
                FileName = "Types.razor",
                MetaTitle = "Blazor Rich Text Editor Toolbar Types | UI Modes | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Type",
                MetaDescription = "This Blazor Rich Text Editor Type example demonstrates the different toolbar configurations and UI modes for the customizable editing interface layouts."
            },
            new Sample
            {
                Name = "Quick Format Toolbar",
                Category = "Toolbar",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/quick-format-toolbar",
                FileName = "Quick-Format-Toolbar.razor",
                MetaTitle = "Blazor RTE Quick Format Toolbar Example - Syncfusion Demos",
                HeaderText = "Blazor Rich Text Editor Example - Quick Format Toolbar",
                MetaDescription = "This Blazor Rich Text Editor Quick Format Toolbar demonstrates contextual formatting tools that appear on text selection for efficient content styling."
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
                },
                MetaTitle = "Blazor Rich Text Editor Mail Merge | Template System | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Mail Merge",
                MetaDescription = "This Blazor Rich Text Editor Mail Merge example demonstrates template-based content generation with dynamic data insertion for automated document creation."
            },
            new Sample
            {
                Name = "Import from Word",
                Category = "Export / Import",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/import-word",
                FileName = "Import.razor",
                MetaTitle = "Blazor Rich Text Editor Import Word | Document Import | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Import from Word",
                MetaDescription = "This Blazor Rich Text Editor Import example demonstrates importing Word documents with formatting preservation for seamless content migration and editing."
            },
            new Sample
            {
                Name = "Export to Word / PDF",
                Category = "Export / Import",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/export-word",
                MetaTitle = "Rich Text Editor Export to Word / PDF - Syncfusion Demos",
                FileName = "Export-Word.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{@"The Rich Text Editor export to Word/PDF sample has been updated to show a spinner on the export button while the file is being generated, giving users clear progress feedback until the download is complete."},
                HeaderText = "Blazor Rich Text Editor Example - Export to Word / PDF",
                MetaDescription = "This Blazor Rich Text Editor Export demonstrates exporting content to Word and PDF formats with formatting preservation for document sharing and distribution."
            },
            new Sample
            {
                Name = "@ Mention",
                Category = "Mention Integration",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/mention-integration",
                FileName = "Mention-Integration.razor",
                MetaTitle = "Blazor Rich Text Editor Mention | User Tagging | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - @ Mention",
                MetaDescription = "This Blazor Rich Text Editor @ Mention example demonstrates user tagging functionality with autocomplete suggestions for collaborative content creation."
            },
            new Sample
            {
                Name = "Smart Suggestion",
                Category = "Mention Integration",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/smart-suggestion",
                FileName = "Smart-Suggestion.razor",
                MetaTitle = "Blazor Rich Text Editor Smart Suggestion | AI Assist | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Smart Suggestion",
                MetaDescription = "This Blazor Rich Text Editor Smart Suggestion demonstrates intelligent content suggestions and slash menu commands for enhanced productivity and formatting."
            },
            new Sample
            {
                Name = "Custom Emoticons",
                Category = "Custom Toolbar Item",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/insert-emoticons",
                FileName = "InsertEmoticons.razor",
                MetaTitle = "Blazor Rich Text Editor Emoticons | Custom Icons | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Custom Emoticons",
                MetaDescription = "This Blazor Rich Text Editor Custom Emoticons demonstrates emoji and emoticon insertion with custom toolbar integration for expressive content creation."
            },
                 new Sample
            {
                Name = "Special Characters",
                Category = "Custom Toolbar Item",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/insert-special-characters",
                FileName = "InsertSpecialCharacters.razor",
                MetaTitle = "Blazor Rich Text Editor Special Characters | Symbols | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Special Characters",
                MetaDescription = "This Blazor Rich Text Editor Special Characters demonstrates symbol and special character insertion with custom toolbar for comprehensive text formatting."
            },
            new Sample
            {
                Name = "Print",
                Category = "Miscellaneous",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/print",
                FileName = "Print.razor",
                MetaTitle = "Blazor Rich Text Editor Print | Document Output | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Print",
                MetaDescription = "This Blazor Rich Text Editor Print demonstrates printing capabilities for generating hard copies of formatted content with customizable print settings."
            },
            new Sample
            {
                Name = "API",
                Category = "Miscellaneous",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/api",
                FileName = "Api.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{@"The Rich Text Editor API sample has been updated to include the new EnableMarkdownAutoFormat API, which automatically converts Markdown syntax to HTML for a smoother editing experience."},
                MetaTitle = "Blazor Rich Text Editor API | Programmatic Control | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - API",
                MetaDescription = "This Blazor Rich Text Editor API example demonstrates programmatic control and method usage for dynamic content manipulation and editor configuration."
            },
             new Sample
            {
                Name = "Events",
                Category = "Miscellaneous",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/events",
                FileName = "Events.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{@"The Rich Text Editor Events sample has been updated with the OnMediaDrop event, which is triggered whenever a media file—such as a video, audio, or image—is dragged and dropped into the editor."},
                MetaTitle = "Blazor Rich Text Editor Events | Event Handling | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Events",
                MetaDescription = "This Blazor Rich Text Editor Events example demonstrates an event handling for the user interactions, content changes, and editor lifecycle management."
            },
            new Sample
            {
                Name = "Forum Post Editor",
                Category = "Miscellaneous",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/usecase",
                FileName = "UseCase.razor",
                MetaTitle = "Blazor Rich Text Editor Forum | Use Case Example | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Forum Post Editor",
                MetaDescription = "This Blazor Rich Text Editor Forum Post example demonstrates the real-world use case implementation for community forums and the discussion platforms."
            },
             new Sample
            {
                Name = "Bottom Toolbar",
                Category = "Toolbar",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/bottom-toolbar",
                FileName = "Bottom-Toolbar.razor",
                MetaTitle = "Blazor Rich Text Editor Bottom Toolbar | UI Layout | Syncfusion",
                HeaderText = "Blazor Rich Text Editor Example - Bottom Toolbar",
                MetaDescription = "This Blazor Rich Text Editor Bottom Toolbar example demonstrates alternative toolbar positioning for customized editor layout and improved user experience."
            }
        };        
    }

}