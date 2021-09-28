using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> DropDownList { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Data-Binding",
                FileName = "DataBinding.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[] {
                    @"Updated the demo with dynamic data binding (ExpandoObject and Dynamic Object) and Observable collections."
                }
            },
            new Sample
            {
                Name = "Filtering",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Filtering",
                FileName = "Filtering.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Cascading",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Cascading",
                FileName = "Cascading.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Grouping and Icon",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Grouping-Icon",
                FileName = "GroupingIcon.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Inline",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Inline",
                FileName = "Inline.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Template",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Template",
                FileName = "Template.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Virtualization",
                FileName = "Virtualization.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Validation",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Forms-Validation",
                FileName = "FormsValidation.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.New
            }
        };

        public List<Sample> ComboBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None
            },
              new Sample
            {
                Name = "Data Binding",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Data-Binding",
                FileName = "DataBinding.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[] {
                    @"Updated the demo with dynamic data binding (ExpandoObject and Dynamic Object) and Observable collections."
                }
            },
           new Sample
            {
                Name = "Cascading",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Cascading",
                FileName = "Cascading.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Filtering",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Filtering",
                FileName = "Filtering.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Custom Value",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Custom-Value",
                FileName = "CustomValue.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Grouping and Icon",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Grouping-Icon",
                FileName = "GroupingIcon.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Template",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Template",
                FileName = "Template.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Multi Column",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Multi-Column",
                FileName = "MultiColumn.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Virtualization",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Virtualization",
                FileName = "Virtualization.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Validation",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Forms-Validation",
                FileName = "FormsValidation.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.New
            }
        };

        public List<Sample> AutoComplete { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Data-Binding",
                FileName = "DataBinding.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[] {
                    @"Updated the demo with dynamic data binding (ExpandoObject and Dynamic Object) and Observable collections."
                }
            },
            new Sample
            {
                Name = "Grouping and Icon",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Grouping-Icon",
                FileName = "GroupingIcon.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Template",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Template",
                FileName = "Template.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Highlight",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Highlight",
                FileName = "Highlight.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Virtualization",
                FileName = "Virtualization.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Custom Filtering",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Custom-Filtering",
                FileName = "CustomFiltering.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Validation",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Forms-Validation",
                FileName = "FormsValidation.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.New
            }
        };

        public List<Sample> MultiSelectDropdown { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Data-Binding",
                FileName = "DataBinding.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[] {
                    @"Updated the demo with dynamic data binding (ExpandoObject and Dynamic Object) and Observable collections."
                }
            },
             new Sample
            {
                Name = "Filtering",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Filtering",
                FileName = "Filtering.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "CheckBox",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/CheckBox",
                FileName = "CheckBox.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Custom Value",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Custom-Value",
                FileName = "CustomValue.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Chip Customization",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Chip-Customization",
                FileName = "ChipCustomization.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Grouping",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Grouping",
                FileName = "Grouping.razor",
                Type = SampleType.Updated
            },
            new Sample
            {
                Name = "Selection Limit",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Selection-Limit",
                FileName = "SelectionLimit.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Template",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Template",
                FileName = "Template.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Virtualization",
                FileName = "Virtualization.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Validation",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Forms-Validation",
                FileName = "FormsValidation.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.New
            }
        };

        public List<Sample> ListBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "listbox/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Dual ListBox",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "listbox/dual-listbox",
                FileName = "DualListBox.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[] {
                    @"Updated the demo with no records template option, which shown when the ListBox is empty."
                }
            },
            new Sample
            {
                Name = "Drag and Drop",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "listbox/drag-and-drop",
                FileName = "DragDrop.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Checkbox",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "listbox/checkbox",
                FileName = "Checkbox.razor",
                Type = SampleType.None
            },
            new Sample
            {
               Name = "Template",
               Category = "ListBox",
               Directory = "DropDowns/ListBox",
               Url = "listbox/template",
               FileName = "Template.razor",
               Type = SampleType.None
            },
            new Sample
            {
               Name = "API",
               Category = "ListBox",
               Directory = "DropDowns/ListBox",
               Url = "listbox/api",
               FileName = "Api.razor",
               Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "listbox/keyboard-navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.New
            }
        };
    }
}
