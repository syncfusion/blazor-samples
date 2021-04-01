using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Button { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default Functionalities",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
           new Sample
            {
                Name = "Checkbox",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/checkbox",
                FileName = "CheckBox.razor",
                HeaderText = "Example of Default Sample in Blazor Checkbox Component"
            },
           new Sample
            {
                Name = "Radio Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/radio-button",
                FileName = "RadioButton.razor",
                HeaderText = "Example of Default Sample in Blazor Radio Button Component"
            },
           new Sample
            {
                Name = "Dropdown Menu",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/dropdown-menu",
                FileName = "DropDownButton.razor",
                HeaderText = "Example of Default Sample in Blazor Dropdown Menu Component",
            },
           new Sample
            {
                Name = "Split Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/split-button",
                FileName = "SplitButton.razor",
                HeaderText = "Example of Default Sample in Blazor Split Button Component"
            },
           new Sample
            {
                Name = "Toggle Switch Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/toggle-switch-button",
                FileName = "Switch.razor",
                HeaderText = "Example of Default Sample in Blazor Toggle Switch Button Component"
            },
           new Sample
            {
                Name = "Progress Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/progress-button",
                FileName = "ProgressButton.razor",
                 Type = SampleType.None,
                HeaderText = "Example of Default Sample in Blazor Progress Button Component"
            },
           new Sample
           {
               Name = "Button Group",
               Category = "Button",
               Directory = "Buttons/Button",
               Url = "buttons/button-group",
               FileName = "ButtonGroup.razor",
               HeaderText = "Example of Default Sample in Blazor Button Group Component"
           }
        };
        public List<Sample> Chips { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "chips/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "API",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "chips/api",
                FileName = "API.razor"
            }

        };
    }
}
