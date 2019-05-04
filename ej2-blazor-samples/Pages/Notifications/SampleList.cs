using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Toast { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "Notifications/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            }
        };
        public List<Sample> Badge { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Badge",
                Directory = "Notifications/Badge",
                Url = "Badge/Default",
                FileName = "Default.razor",
                Type = SampleType.New,
            },
             new Sample
            {
                Name = "Types",
                Category = "Badge",
                Directory = "Notifications/Badge",
                Url = "Badge/Types",
                FileName = "Types.razor",
                Type = SampleType.New,
            }
        };
    }
}
