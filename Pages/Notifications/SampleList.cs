using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Toast { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Types",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/types",
                FileName = "Types.razor"
            },
            new Sample
            {
                Name = "Template",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/template",
                FileName = "Template.razor"
            },
            new Sample
            {
                Name = "Position",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/position",
                FileName = "Position.razor"
            },
            new Sample
            {
                Name = "API",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/api",
                FileName = "API.razor"
            }
        };
        public List<Sample> Spinner { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Spinner",
                Directory = "Notifications/Spinner",
                Url = "spinner/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            }
        };
    }
}
