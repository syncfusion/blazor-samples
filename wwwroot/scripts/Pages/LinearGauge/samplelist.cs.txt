using System.Collections.Generic;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> LinearGauge { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "LinearGauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "LinearGauge/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Container",
                Category = "LinearGauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "LinearGauge/Container",
                FileName = "Container.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Ranges",
                Category = "LinearGauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "LinearGauge/Ranges",
                FileName = "Ranges.razor",
                Type = SampleType.New
            },
            new Sample
            {
               Name = "Data Sample",
               Category = "LinearGauge",
               Directory = "LinearGauge/LinearGauge",
               Url = "LinearGauge/DataSample",
               FileName = "DataSample.razor",
               Type = SampleType.New
            },
            new Sample
            {
                Name = "Axes and Pointers",
                Category = "LinearGauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "LinearGauge/AxesandPointers",
                FileName = "AxesandPointers.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Annotation",
                Category = "LinearGauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "LinearGauge/Annotation",
                FileName = "Annotation.razor",
                Type = SampleType.New
            },
            new Sample
            {
               Name = "Tooltip",
               Category = "LinearGauge",
               Directory = "LinearGauge/LinearGauge",
               Url = "LinearGauge/Tooltip",
               FileName = "Tooltip.razor",
               Type = SampleType.New
            },
            new Sample
            {
                Name = "Styles",
                Category = "LinearGauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "LinearGauge/Styles",
                FileName = "Styles.razor",
                Type = SampleType.New
            }
         };
    }
}
