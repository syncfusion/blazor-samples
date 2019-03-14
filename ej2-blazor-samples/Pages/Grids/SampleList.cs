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
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Filtering",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/DefaultFiltering",
                FileName = "DefaultFiltering.cshtml",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Inline Editing",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/Editing",
                FileName = "Editing.cshtml",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Checkbox Column",
                Category = "TreeGrid",
                Directory = "Grids/TreeGrid",
                Url = "TreeGrid/CheckboxColumn",
                FileName = "CheckboxColumn.cshtml",
                Type = SampleType.New,
            }
        };
    }

   


}
