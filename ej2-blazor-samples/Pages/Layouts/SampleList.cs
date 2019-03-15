using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Card { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "BasicCard",
                Category = "Card",
                Directory = "Layouts/Card",
                FileName = "BasicCard.cshtml",
                Url = "Card/BasicCard",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "VerticalCard",
                Category = "Card",
                Directory = "Layouts/Card",
                FileName = "VerticalCard.cshtml",
                Url = "Card/VerticalCard",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "HorizontalCard",
                Category = "Card",
                Directory = "Layouts/Card",
                FileName = "HorizontalCard.cshtml",
                Url = "Card/HorizontalCard",
                Type = SampleType.New
            },
        };
		public List<Sample> Listview { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Listview",
                Directory = "Layouts/Listview",
                Url = "Listview/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New
            }
        };
        public List<Sample> Avatar { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Avatar",
                Directory = "Layouts/Avatar",
                Url = "Avatar/Default",
                FileName = "Default.cshtml",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Badge",
                Category = "Avatar",
                Directory = "Layouts/Avatar",
                Url = "Avatar/Types",
                FileName = "Types.cshtml",
                Type = SampleType.New,
            }
        };

    }

   


}
