using System.Collections.Generic;
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
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Range",
                Category = "CircularGauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/Range",
                FileName = "Range.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Ticks and Labels",
                Category = "CircularGauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/Labels",
                FileName = "Labels.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Gauge Customization",
                Category = "CircularGauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/Customization",
                FileName = "Customization.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Semi-Circular Gauge",
                Category = "CircularGauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/Semicirculargauge",
                FileName = "Semicirculargauge.razor",
                Type = SampleType.New
            },	
			//  new Sample
			// {
			//     Name = "Arc Gauge",
			//     Category = "CircularGauge",
			//     Directory = "CircularGauge/CircularGauge",
			//     Url = "CircularGauge/Arcgauge",
			//     FileName = "Arcgauge.razor",
			//     Type = SampleType.New
			// },			 
			 new Sample
            {
                Name = "Pointer Image",
                Category = "CircularGauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/PointerImage",
                FileName = "PointerImage.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Tooltip",
                Category = "CircularGauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "CircularGauge/Tooltip",
                FileName = "Tooltip.razor",
                Type = SampleType.New
            }
        };
    }
}
