using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Button { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default Functionalities",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor"
            },
           new Sample
            {
                Name = "CheckBox",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/CheckBox",
                FileName = "CheckBox.razor"
            },
           new Sample
            {
                Name = "RadioButton",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/RadioButton",
                FileName = "RadioButton.razor"
            },
           new Sample
            {
                Name = "DropDownButton",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/DropDownButton",
                FileName = "DropDownButton.razor"
            },
           new Sample
            {
                Name = "SplitButton",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/SplitButton",
                FileName = "SplitButton.razor"
            },
           new Sample
            {
                Name = "Switch",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/Switch",
                FileName = "Switch.razor"
            },
           new Sample
            {
                Name = "ProgressButton",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/ProgressButton",
                FileName = "ProgressButton.razor"
            },
        };
        public List<Sample> Chips { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "Chips/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "API",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "Chips/API",
                FileName = "API.razor",
                Type = SampleType.New
            }

        };
    }

   


}
