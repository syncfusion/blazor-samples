using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Dialog { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "Dialog/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Draggable",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "Dialog/Draggable",
                FileName = "Draggable.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Resizable",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "Dialog/Resizable",
                FileName = "Resizable.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Multiple Dialogs",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "Dialog/MultipleDialogs",
                FileName = "MultipleDialogs.razor",
                Type = SampleType.New
            }
        };
        public List<Sample> Tooltip { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "Tooltip/Default",
                FileName = "Default.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "HtmlTemplate",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "Tooltip/HtmlTemplate",
                FileName = "HtmlTemplate.razor",
                Type = SampleType.New,
            }
        };   
    }
}
