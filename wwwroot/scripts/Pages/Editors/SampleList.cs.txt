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
                Category = "In-place Editor",
                Directory = "Editors/InPlaceEditor",
                Url = "Editors/Overview",
                FileName = "Overview.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "DropDown Components",
                Category = "In-place Editor",
                Directory = "Editors/InPlaceEditor",
                Url = "Editors/DropDown",
                FileName = "DropDown.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Date Components",
                Category = "In-place Editor",
                Directory = "Editors/InPlaceEditor",
                Url = "Editors/DatePickers",
                FileName = "DatePickers.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Edit Post",
                Category = "Use Case",
                Directory = "Editors/InPlaceEditor",
                Url = "Editors/EditPost",
                FileName = "EditPost.razor",
                Type = SampleType.New
            }
        };
    }
}
