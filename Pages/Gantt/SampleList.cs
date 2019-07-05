using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {

        public List<Sample> Gantt { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Gantt",
                Directory = "Gantt/Gantt",
                Url = "Gantt/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Gantt",
                Directory = "Gantt/Gantt",
                Url = "Gantt/RemoteData",
                FileName = "RemoteData.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Baseline",
                Category = "Gantt",
                Directory = "Gantt/Gantt",
                Url = "Gantt/Baseline",
                FileName = "Baseline.razor",
                Type = SampleType.New
            },
			new Sample
            {
                Name = "Filtering",
                Category = "Gantt",
                Directory = "Gantt/Gantt",
                Url = "Gantt/Filtering",
                FileName = "Filtering.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Zooming",
                Category = "Gantt",
                Directory = "Gantt/Gantt",
                Url = "Gantt/Zooming",
                FileName = "Zooming.razor",
                Type = SampleType.New
            }
        };
    }
}
