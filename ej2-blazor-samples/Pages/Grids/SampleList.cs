using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> TreeGrid { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Sorting",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Sorting",
                FileName = "Sorting.razor",
                Type = SampleType.New,
            }
        };
    }

   


}
