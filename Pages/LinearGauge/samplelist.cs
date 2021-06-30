using System.Collections.Generic;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> LinearGauge { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Linear Gauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Container",
                Category = "Linear Gauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/container",
                FileName = "Container.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Ranges",
                Category = "Linear Gauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/ranges",
                FileName = "Ranges.razor",
                Type = SampleType.None
            },
            new Sample
            {
               Name = "Data Sample",
               Category = "Linear Gauge",
               Directory = "LinearGauge/LinearGauge",
               Url = "linear-gauge/data-sample",
               FileName = "DataSample.razor",
               Type = SampleType.None
            },
            new Sample
            {
                Name = "Axes and Pointers",
                Category = "Linear Gauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/axes-and-pointers",
                FileName = "AxesandPointers.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Annotation",
                Category = "Linear Gauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/annotation",
                FileName = "Annotation.razor",
                Type = SampleType.None
            },
            new Sample
            {
               Name = "Gradient Color",
               Category = "Linear Gauge",
               Directory = "LinearGauge/LinearGauge",
               Url = "linear-gauge/gradient-color",
               FileName = "GradientColor.razor",
               Type = SampleType.None
            },
            new Sample
            {
                Name = "Styles",
                Category = "Linear Gauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/styles",
                FileName = "Styles.razor",
                Type = SampleType.None
            },
            new Sample
            {
               Name = "Tooltip",
               Category = "Linear Gauge",
               Directory = "LinearGauge/LinearGauge",
               Url = "linear-gauge/tooltip",
               FileName = "Tooltip.razor",
               Type = SampleType.None
            },
            new Sample
            {
                Name = "Print & Export",
                Category = "Linear Gauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "linear-gauge/export",
                FileName = "Export.razor",
                Type = SampleType.None
            }
         };
    }
}
