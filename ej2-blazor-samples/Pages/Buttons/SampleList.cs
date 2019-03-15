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
                FileName = "DefaultFunctionalities.cshtml"
            },
           new Sample
            {
                Name = "ButtonGroup",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/ButtonGroup",
                FileName = "ButtonGroup.cshtml"
            },
           new Sample
            {
                Name = "CheckBox",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/CheckBox",
                FileName = "CheckBox.cshtml"
            },
           new Sample
            {
                Name = "RadioButton",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/RadioButton",
                FileName = "RadioButton.cshtml"
            },
           new Sample
            {
                Name = "DropDownButton",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/DropDownButton",
                FileName = "DropDownButton.cshtml"
            },
           new Sample
            {
                Name = "SplitButton",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/SplitButton",
                FileName = "SplitButton.cshtml"
            },
           new Sample
            {
                Name = "Switch",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/Switch",
                FileName = "Switch.cshtml"
            },
           new Sample
            {
                Name = "ProgressButton",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/ProgressButton",
                FileName = "ProgressButton.cshtml"
            },
        };
        public List<Sample> Chips { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "Chips/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New
            }

        };
    }

   


}
