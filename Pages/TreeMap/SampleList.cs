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
                Name = "Layout",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Layout",
                FileName = "Layout.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Drilldown",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Drilldown",
                FileName = "Drilldown.razor",
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
            },
            new Sample
            {
                Name = "Color Mapping",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/ColorMapping",
                FileName = "ColorMapping.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Selection & Highlight",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Selection",
                FileName = "Selection.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Print & Export",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Print",
                FileName = "Print.razor",
                Type = SampleType.New
            },
            //  new Sample
            // {
            //     Name = "TreeMap with Pie",
            //     Category = "TreeMap",
            //     Directory = "TreeMap/TreeMap",
            //     Url = "TreeMap/TreeMapwithPie",
            //     FileName = "TreeMapwithPie.razor",
            //     Type = SampleType.New
            // },
                new Sample
            {
                Name = "RTL",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Rtl",
                FileName = "Rtl.razor",
                Type = SampleType.New
            }
        };      
    }

   


}
