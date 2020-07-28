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
                FileName = "Overview.razor"
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
                Name = "Image",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/image",
                FileName = "Image.razor"
            },
            new Sample
            {
                Name = "Inline",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/inline",
                FileName = "Inline.razor"
            },
            new Sample
            {
                Name = "IFrame Functionalities",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/iframe-functionalities",
                FileName = "Iframe-Functionalities.razor"
            },
            new Sample
            {
                Name = "Print",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/print",
                FileName = "Print.razor"
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
                Name = "Markdown Overview",
                Category = "Markdown",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/markdown-overview",
                FileName = "Markdown-Overview.razor"
            },
            new Sample
            {
                Name = "Custom Format",
                Category = "Markdown",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/markdown-custom-format",
                FileName = "Markdown-Custom-Format.razor"
            },
            new Sample
            {
                Name = "Paste from MS Word",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/paste-cleanup",
                FileName = "Paste-Cleanup.razor"
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
                Name = "API",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/api",
                FileName = "Api.razor"
            },
            new Sample
            {
                Name = "Form Validation",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/form-validation",
                FileName = "Form-Validation.razor"
            }
        };      
    }

}
