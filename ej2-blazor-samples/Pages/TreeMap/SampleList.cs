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
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Customization",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Customization",
                FileName = "Customization.cshtml",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Data Label",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Label",
                FileName = "TreeMapLabel.cshtml",
                Type = SampleType.New
            },
              new Sample
            {
                Name = "Tooltip",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Tooltip",
                FileName = "Tooltip.cshtml",
                Type = SampleType.New
            },
               new Sample
            {
                Name = "Legend",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Legend",
                FileName = "Legend.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "ColorMapping",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/ColorMapping",
                FileName = "ColorMapping.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Layout",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/layerData",
                FileName = "layerData.cshtml",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Print",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Print",
                FileName = "print.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Selection",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Selection",
                FileName = "selection.cshtml",
                Type = SampleType.New
            }

        };      
    }

   


}
