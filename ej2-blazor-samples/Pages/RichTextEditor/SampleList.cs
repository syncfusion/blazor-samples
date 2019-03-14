using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> RichTextEditor { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "RichTextEditor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "RichTextEditor/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Inline",
                Category = "RichTextEditor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "RichTextEditor/Inline",
                FileName = "Inline.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "IFrame Functionalities",
                Category = "RichTextEditor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "RichTextEditor/Iframe-Functionalities",
                FileName = "Iframe-Functionalities.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Markdown Functionalities",
                Category = "RichTextEditor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "RichTextEditor/Markdown-Overview",
                FileName = "Markdown-Overview.cshtml",
                Type = SampleType.New
            }
        };      
    }

}
