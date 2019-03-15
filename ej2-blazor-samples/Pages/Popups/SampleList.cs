using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Tooltip { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "Tooltip/Default",
                FileName = "Default.cshtml",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Html Template",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "Tooltip/HtmlTemplate",
                FileName = "HtmlTemplate.cshtml",
                Type = SampleType.New,
            },
        };   
    }
}
