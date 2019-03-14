using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> InPlaceEditor { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "InPlaceEditor",
                Directory = "Editors/InPlaceEditor",
                Url = "Editors/Overview",
                FileName = "Overview.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Dropdown components",
                Category = "InPlaceEditor",
                Directory = "Editors/InPlaceEditor",
                Url = "Editors/DropDownComponents",
                FileName = "DropDownComponents.cshtml",
                Type = SampleType.New
            }
        };
    }
}
