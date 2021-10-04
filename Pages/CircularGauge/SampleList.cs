using System.Collections.Generic;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> CircularGauge { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Circular Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Ranges",
                Category = "Circular Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/range",
                FileName = "Range.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Ticks and Labels",
                Category = "Circular Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/labels",
                FileName = "Labels.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Gauge Customization",
                Category = "Circular Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/customization",
                FileName = "Customization.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Semi-circular Gauge",
                Category = "Circular Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/semi-circular-gauge",
                FileName = "Semicirculargauge.razor",
                Type = SampleType.None
            },	
			 new Sample
			{
			    Name = "Arc Gauge",
			    Category = "Circular Gauge",
			    Directory = "CircularGauge/CircularGauge",
			    Url = "circular-gauge/arc-gauges",
			    FileName = "ArcGauges.razor",
                Type = SampleType.None
			},
              new Sample
            {
                Name = "Legend",
                Category = "Circular Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/circular-gauge-legend",
                FileName = "CircularGaugeLegend.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Gradient Color",
                Category = "Circular Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/gradient-color",
                FileName = "GradientColor.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Direction Compass",
                Category = "Circular Gauge",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/compass",
                FileName = "Compass.razor",
                Type = SampleType.None
            },			 
			 new Sample
            {
                Name = "Pointer Image",
                Category = "Pointer",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/pointer-image",
                FileName = "PointerImage.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Pointer Customization",
                Category = "Pointer",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/pointer-customization",
                FileName = "PointerCustomization.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Multiple Axis",
                Category = "Axes",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/multiple-axis",
                FileName = "MultipleAxis.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pointer & Ranges Drag",
                Category = "User Interaction",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/pointer-drag",
                FileName = "PointerDrag.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Tooltip",
                Category = "User Interaction",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/tooltip",
                FileName = "Tooltip.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Print & Export",
                Category = "Export",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/export",
                FileName = "Export.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Data Sample",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/data-sample",
                FileName = "DataSample.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Apple Watch Rings",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/apple-watch-rings",
                FileName = "AppleWatchRings.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Speedometer",
                Category = "Use Cases",
                Directory = "CircularGauge/CircularGauge",
                Url = "circular-gauge/speedometer",
                FileName = "Speedometer.razor",
                Type = SampleType.None
            }
        };
    }
}
