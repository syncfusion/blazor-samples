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
                Url = "Toast/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Types",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "Toast/Types",
                FileName = "Types.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Position",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "Toast/Position",
                FileName = "Position.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "API",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "Toast/API",
                FileName = "API.razor",
                Type = SampleType.New
            }
        };
        public List<Sample> Spinner { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Spinner",
                Directory = "Notifications/Spinner",
                Url = "Spinner/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            }
        };
    }
}
