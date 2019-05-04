using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> TreeMap { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Customization",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Customization",
                FileName = "Customization.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Data Label",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Label",
                FileName = "TreeMapLabel.razor",
                Type = SampleType.New
            },
              new Sample
            {
                Name = "Tooltip",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Tooltip",
                FileName = "Tooltip.razor",
                Type = SampleType.New
            },
               new Sample
            {
                Name = "Legend",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Legend",
                FileName = "Legend.razor",
                Type = SampleType.New
            }
        };      
    }

   


}
