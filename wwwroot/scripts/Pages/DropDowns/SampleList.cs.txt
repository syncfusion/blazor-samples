using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> DropDownList { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "DropDownList",
                Directory = "DropDowns/DropDownList",
                Url = "DropDownList/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "DropDownList",
                Directory = "DropDowns/DropDownList",
                Url = "DropDownList/DataBinding",
                FileName = "DataBinding.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Filtering",
                Category = "DropDownList",
                Directory = "DropDowns/DropDownList",
                Url = "DropDownList/Filtering",
                FileName = "Filtering.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Cascading",
                Category = "DropDownList",
                Directory = "DropDowns/DropDownList",
                Url = "DropDownList/Cascading",
                FileName = "Cascading.razor",
                Type = SampleType.New
            }
        };

        public List<Sample> ComboBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
            },
              new Sample
            {
                Name = "Data Binding",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/DataBinding",
                FileName = "DataBinding.razor",
                Type = SampleType.New,
            },
           new Sample
            {
                Name = "Cascading",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Cascading",
                FileName = "Cascading.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Filtering",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Filtering",
                FileName = "Filtering.razor",
                Type = SampleType.New,
            }
        };

        public List<Sample> AutoComplete { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/DataBinding",
                FileName = "DataBinding.razor",
                Type = SampleType.New,
            }
        };

        public List<Sample> MultiSelect { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "MultiSelect",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "MultiSelect",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect/DataBinding",
                FileName = "DataBinding.razor",
                Type = SampleType.New,
            },
             new Sample
            {
                Name = "Filtering",
                Category = "MultiSelect",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect/Filtering",
                FileName = "Filtering.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "CheckBox",
                Category = "MultiSelect",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect/CheckBox",
                FileName = "CheckBox.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "SelectionLimit",
                Category = "MultiSelect",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect/SelectionLimit",
                FileName = "SelectionLimit.razor",
                Type = SampleType.New,
            }
        };

        public List<Sample> ListBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "ListBox/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
            },
			new Sample
            {
                Name = "CheckBox",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "ListBox/Checkbox",
                FileName = "Checkbox.razor",
                Type = SampleType.New,
            },
			new Sample
            {
                Name = "API",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "ListBox/Api",
                FileName = "Api.razor",
                Type = SampleType.New,
            }
        };
    }
}
