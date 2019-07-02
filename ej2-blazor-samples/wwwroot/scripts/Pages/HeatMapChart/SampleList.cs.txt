using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> HeatMapChart { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "HeatMapChart",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Empty Points",
                Category = "HeatMapChart",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/Emptypoints",
                FileName = "Emptypoints.razor",
                Type = SampleType.New
            }
        };    
    }

   


}
