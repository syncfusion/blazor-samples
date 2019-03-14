using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> CircularGauge { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "CircularGauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Ticks and Labels",
                Category = "CircularGauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/Labels",
                FileName = "Labels.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Direction Compass",
                Category = "CircularGauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/Compass",
                FileName = "Compass.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Pointer Image",
                Category = "Pointer",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/PointerImage",
                FileName = "PointerImage.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "User Interaction",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/Tooltip",
                FileName = "Tooltip.cshtml",
                Type = SampleType.New
            }
        };      
    }
}
