#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
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
                MetaTitle = "Dropdown List Default Functionalities - Syncfusion Demos",
                HeaderText = "Blazor Dropdown List Example - Default Functionalities",
                MetaDescription = "Blazor Dropdown List demo shows the default functionalities with various configuration options. Learn how to create a dropdown list with standard behaviors.",
                Type = SampleType.None,

            },
            new Sample
            {
                Name = "Data Binding",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Data-Binding",
                FileName = "DataBinding.razor",
                MetaTitle = "Blazor Dropdown List Data Binding | Remote Data | Syncfusion",
                HeaderText = "Blazor Dropdown List Example - Data Binding",
                MetaDescription = "This Blazor Dropdown List example demonstrates data binding capabilities with local and remote data sources. Learn how to bind arrays, object collections.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Disabled Items",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/DisabledItems",
                FileName = "DisabledItems.razor",
                MetaTitle = "Blazor Dropdown List Disabled Items | Item Disabling | Syncfusion",
                HeaderText = "Blazor Dropdown List Example - Disabled Items",
                MetaDescription = "Blazor Dropdown List demo shows how to disable specific items in dropdown and implement item-level disabling while maintaining selectability of other items.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Filtering",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Filtering",
                FileName = "Filtering.razor",
                MetaTitle = "Blazor Dropdown List Filtering | Search Options | Syncfusion",
                HeaderText = "Blazor Dropdown List Example - Filtering",
                MetaDescription = "Blazor Dropdown List example demonstrates how to implement search functionality with different filter types like contains, startsWith, and custom filtering.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Cascading",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Cascading",
                FileName = "Cascading.razor",
                MetaTitle = "Blazor Dropdown List Cascading | Dependent Dropdowns | Syncfusion",
                HeaderText = "Blazor Dropdown List Example - Cascading Dropdowns",
                MetaDescription = "This Blazor Dropdown List example shows cascading dropdowns. Learn how to filter the content of one dropdown based on the selection made in another dropdown.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Grouping and Icon",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Grouping-Icon",
                FileName = "GroupingIcon.razor",
                MetaTitle = "Blazor Dropdown List Grouping and Icons | Visual Cues | Syncfusion",
                HeaderText = "Blazor Dropdown List Example - Grouping and Icons",
                MetaDescription = "Blazor Dropdown List demo shows how to group items and add icons to dropdown options and create categorized lists with visual indicators for user experience.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Inline",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Inline",
                FileName = "Inline.razor",
                MetaTitle = "Blazor Dropdown List Inline | Integrated UI | Syncfusion",
                HeaderText = "Blazor Dropdown List Example - Inline Display",
                MetaDescription = "Blazor Dropdown List example demonstrates inline display mode. Learn how to integrate the dropdown seamlessly within your interface for more user experience.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Template",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Template",
                FileName = "Template.razor",
                MetaTitle = "Blazor Dropdown List Templates | Custom UI | Syncfusion",
                HeaderText = "Blazor Dropdown List Example - Custom Templates",
                MetaDescription = "This Blazor Dropdown List example demonstrates how to create rich dropdown items with custom HTML content, formatting and styles to enhance your user interface.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Popup Resize",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Resize",
                FileName = "Resize.razor",
                MetaTitle = "Blazor Dropdown List Popup Resize | Adaptive UI | Syncfusion",
                HeaderText = "Blazor Dropdown List Example - Popup Resize",
                MetaDescription = "This Blazor Dropdown List example demonstrates how to create dropdowns with customizable popup dimensions to better fit your content and layout needs.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Virtualization",
                FileName = "Virtualization.razor",
                MetaTitle = "Blazor Dropdown List Virtualization | Performance | Syncfusion",
                HeaderText = "Blazor Dropdown List Example - Virtualization",
                MetaDescription = "Blazor Dropdown List demo shows UI virtualization for large data sets. Learn how to load thousands of items with optimal performance by rendering visible items.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Validation",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor Dropdown List Validation | Form Integration | Syncfusion",
                HeaderText = "Blazor Dropdown List Example - Form Validation",
                MetaDescription = "This Blazor Dropdown List example demonstrates how to implement required field validation and custom validation rules with Blazor's form validation system.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Dropdown List",
                Directory = "DropDowns/DropDownList",
                Url = "DropDown-List/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor Dropdown List Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor Dropdown List Example - Keyboard Navigation",
                MetaDescription = "This Blazor Dropdown List example demonstrates how to navigate, select, and operate the dropdowns using keyboard shortcuts for enhanced accessibility.",
                Type = SampleType.None
            }
        };

        public List<Sample> DropDownTree { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Dropdown Tree",
                Directory = "DropDowns/DropDownTree",
                Url = "dropdown-tree/Default-Functionalities",
                MetaTitle = "Dropdown Tree Default Functionalities - Syncfusion Demos",
                HeaderText = "Blazor Dropdown Tree Example - Default Functionalities",
                MetaDescription = "Blazor Dropdown Tree example demonstrates hierarchical data selection. Learn how to create a tree-structured dropdown for intuitive navigation of nested data.",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Customization",
                Category = "Dropdown Tree",
                Directory = "DropDowns/DropDownTree",
                Url = "dropdown-tree/customization",
                FileName = "Customization.razor",
                MetaTitle = "Blazor Dropdown Tree Customization | UI Flexibility | Syncfusion",
                HeaderText = "Blazor Dropdown Tree Example - UI Customization",
                MetaDescription = "This Blazor Dropdown Tree example shows how to customize the appearance, behavior, and visual aspects of the dropdown tree to match your application design."
            },
            new Sample
            {
                Name = "Selection",
                Category = "Dropdown Tree",
                Directory = "DropDowns/DropDownTree",
                Url = "dropdown-tree/selection",
                FileName = "Selection.razor",
                MetaTitle = "Blazor Dropdown Tree Selection | Multi-select | Syncfusion",
                HeaderText = "Blazor Dropdown Tree Example - Selection Modes",
                MetaDescription = "This Blazor Dropdown Tree example shows different selection modes including single, multiple, checkbox selection and hierarchical data selection patterns."
            },
            new Sample
            {
                Name = "Filtering",
                Category = "Dropdown Tree",
                Directory = "DropDowns/DropDownTree",
                Url = "dropdown-tree/Filtering",
                FileName = "Filtering.razor",
                MetaTitle = "Blazor Dropdown Tree Filtering | Search Capability | Syncfusion",
                HeaderText = "Blazor Dropdown Tree Example - Filtering",
                MetaDescription = "This Blazor Dropdown Tree example shows filtering capabilities for hierarchical data. Learn how to implement search functionality within nested tree structures."
            },
            new Sample
            {
                Name = "Validation",
                Category = "Dropdown Tree",
                Directory = "DropDowns/DropDownTree",
                Url = "dropdown-tree/validation",
                FileName = "Validation.razor",
                MetaTitle = "Blazor Dropdown Tree Validation | Form Integration | Syncfusion",
                HeaderText = "Blazor Dropdown Tree Example - Form Validation",
                MetaDescription = "This Blazor Dropdown Tree example demonstrates how to implement required field validation and custom validation rules for hierarchical data selection."
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
                MetaTitle = "Blazor ComboBox Default Functionalities | Syncfusion",
                HeaderText = "Blazor ComboBox Example - Default Functionalities",
                MetaDescription = "This example shows default functionalities of Blazor ComboBox. Learn how to create a flexible input with autocomplete and dropdown selection capabilities.",
                Type = SampleType.None
            },
              new Sample
            {
                Name = "Data Binding",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Data-Binding",
                FileName = "DataBinding.razor",
                MetaTitle = "Blazor ComboBox Data Binding | Remote Data | Syncfusion",
                HeaderText = "Blazor ComboBox Example - Data Binding",
                MetaDescription = "This Blazor ComboBox example shows how to bind local arrays, object (dynamic and expando) collections, and remote data to enhance your input experiences.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Disabled Items",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/DisabledItems",
                FileName = "DisabledItems.razor",
                MetaTitle = "Blazor ComboBox Disabled Items | Selective Input | Syncfusion",
                HeaderText = "Blazor ComboBox Example - Disabled Items",
                MetaDescription = "This Blazor ComboBox example shows how to disable specific items and restrict selection of certain options while maintaining an interactive user interface.",
                Type = SampleType.None
            },
           new Sample
            {
                Name = "Cascading",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Cascading",
                FileName = "Cascading.razor",
                MetaTitle = "Blazor ComboBox Cascading | Dependent Selection | Syncfusion",
                HeaderText = "Blazor ComboBox Example - Cascading ComboBoxes",
                MetaDescription = "This Blazor ComboBox example shows how to filter the options of one ComboBox based on the selection made in another for creating hierarchical selection flows.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Filtering",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Filtering",
                FileName = "Filtering.razor",
                MetaTitle = "Blazor ComboBox Filtering | Search Options | Syncfusion",
                HeaderText = "Blazor ComboBox Example - Filtering",
                MetaDescription = "This Blazor ComboBox demo shows how to implement autocomplete search with different filter types like contains, startsWith, endsWith for better data discovery.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Custom Value",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Custom-Value",
                FileName = "CustomValue.razor",
                MetaTitle = "Blazor ComboBox Custom Value | Flexible Input | Syncfusion",
                HeaderText = "Blazor ComboBox Example - Custom Value Entry",
                MetaDescription = "Blazor ComboBox demo shows custom value entry capability. Learn how to allow user to input values not present in the predefined dropdown list for flexible data.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Grouping and Icon",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Grouping-Icon",
                FileName = "GroupingIcon.razor",
                MetaTitle = "Blazor ComboBox Grouping and Icons | Visual Cues | Syncfusion",
                HeaderText = "Blazor ComboBox Example - Grouping and Icons",
                MetaDescription = "This Blazor ComboBox demo shows item grouping and icon integration. Learn how to create categorized options with visual indicators for an enhanced selection.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Template",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Template",
                FileName = "Template.razor",
                MetaTitle = "Blazor ComboBox Templates | Custom Rendering | Syncfusion",
                HeaderText = "Blazor ComboBox Example - Custom Templates",
                MetaDescription = "This Blazor ComboBox example demonstrates how to create rich dropdown items with the custom HTML, formatting, and styling for enhanced user experience.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Popup Resize",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Resize",
                FileName = "Resize.razor",
                MetaTitle = "Blazor ComboBox Popup Resize | Adaptive Dropdown | Syncfusion",
                HeaderText = "Blazor ComboBox Example - Popup Resize",
                MetaDescription = "This Blazor ComboBox example demonstrates how to customize the dimensions of the dropdown popup to better accommodate your content and layout requirements.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Multi Column",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Multi-Column",
                FileName = "MultiColumn.razor",
                MetaTitle = "Blazor ComboBox Multi Column | Tabular Display | Syncfusion",
                HeaderText = "Blazor ComboBox Example - Multi-Column Layout",
                MetaDescription = "This Blazor ComboBox example demonstrates how to present complex data in a tabular format within the multi column dropdown for better information display.",
                Type = SampleType.None,
            },
             new Sample
            {
                Name = "Virtualization",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Virtualization",
                FileName = "Virtualization.razor",
                MetaTitle = "Blazor ComboBox Virtualization | Performance | Syncfusion",
                HeaderText = "Blazor ComboBox Example - UI Virtualization",
                MetaDescription = "This Blazor ComboBox example demonstrates how to load the thousands of items with optimal performance by rendering only visible items in the viewport.",
                Type = SampleType.None,
            },
             new Sample
            {
                Name = "Validation",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor ComboBox Validation | Form Integration | Syncfusion",
                HeaderText = "Blazor ComboBox Example - Form Validation",
                MetaDescription = "This Blazor ComboBox example demonstrates how to implement required field validation and custom validation rules within Blazor's form validation system.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor ComboBox Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor ComboBox Example - Keyboard Navigation",
                MetaDescription = "This Blazor ComboBox example demonstrates how to navigate, filter, and select items using keyboard shortcuts for improved accessibility and productivity.",
                Type = SampleType.None
            },
#if SERVER
            new Sample
            {
                Name = "Semantic Searching (Embedding)",
                Category = "Smart AI Solutions",
                Directory = "AISamples/ComboBox",
                Url = "combobox/embeddings",
                FileName = "ComboBoxEmbeddings.razor",
                MetaTitle = "Combo Box Semantic Searching - Syncfusion AI Demos",
                HeaderText = "Blazor ComboBox Example - Semantic Searching with Embeddings",
                MetaDescription = "This Blazor ComboBox semantic search example shows how to find related items based on meaning rather than exact keywords for a more intuitive user experience.",
                NotificationDescription = new string[]{ @" This demo shows the semantic search AI feature in Combo Box." }
            }
#endif
        };

        public List<Sample> AutoComplete { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor AutoComplete Default Functionalities | Syncfusion",
                HeaderText = "Blazor AutoComplete Example - Default Functionalities",
                MetaDescription = "Blazor AutoComplete demo shows default suggestion capabilities. Learn how to create an intuitive input field that provides real-time suggestions as users type.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Data-Binding",
                FileName = "DataBinding.razor",
                MetaTitle = "Blazor AutoComplete Data Binding | Dynamic Sources | Syncfusion",
                HeaderText = "Blazor AutoComplete Example - Data Binding",
                MetaDescription = "This Blazor AutoComplete example shows data binding with various data sources. Learn how to bind local and remote data to provide contextual suggestions.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Disabled Items",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/DisabledItems",
                FileName = "DisabledItems.razor",
                MetaTitle = "Blazor AutoComplete Disabled Items | Selective Input | Syncfusion",
                HeaderText = "Blazor AutoComplete Example - Disabled Items",
                MetaDescription = "This Blazor AutoComplete demo shows how to disable specific suggestion items. Learn to create a controlled input experience with selectively disabled options.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Grouping and Icon",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Grouping-Icon",
                FileName = "GroupingIcon.razor",
                MetaTitle = "Blazor AutoComplete Grouping and Icons | Syncfusion",
                HeaderText = "Blazor AutoComplete Example - Grouping and Icons",
                MetaDescription = "This Blazor AutoComplete example demonstrates suggestion grouping with icons. Learn how to organize suggestions into logical categories with visual indicators.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Template",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Template",
                FileName = "Template.razor",
                MetaTitle = "Blazor AutoComplete Templates | Custom Suggestions | Syncfusion",
                HeaderText = "Blazor AutoComplete Example - Custom Templates",
                MetaDescription = "This Blazor AutoComplete example demonstrates how to create rich suggestion items with custom HTML, formatting, and styling for enhanced visual presentation.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Popup Resize",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Resize",
                FileName = "Resize.razor",
                MetaTitle = "Blazor AutoComplete Popup Resize | Flexible UI | Syncfusion",
                HeaderText = "Blazor AutoComplete Example - Popup Resize",
                MetaDescription = "This Blazor AutoComplete example demonstrates how to customize the dimensions of the suggestions popup to better accommodate your content and layout needs.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Highlight",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Highlight",
                FileName = "Highlight.razor",
                MetaTitle = "Blazor AutoComplete Highlight | Search Matches | Syncfusion",
                HeaderText = "Blazor AutoComplete Example - Search Term Highlighting",
                MetaDescription = "This Blazor AutoComplete example demonstrates the search term highlighting in suggestions. Learn how to visually emphasize the matching portions of text.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Virtualization",
                FileName = "Virtualization.razor",
                MetaTitle = "Blazor AutoComplete Virtualization | Performance | Syncfusion",
                HeaderText = "Blazor AutoComplete Example - UI Virtualization",
                MetaDescription = "This Blazor AutoComplete demo shows UI virtualization for large datasets. Learn how to provide suggestions from thousands of records with optimal performance.",
                Type = SampleType.None,
            },
             new Sample
            {
                Name = "Custom Filtering",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Custom-Filtering",
                FileName = "CustomFiltering.razor",
                MetaTitle = "Blazor AutoComplete Custom Filtering | Advanced Search | Syncfusion",
                HeaderText = "Blazor AutoComplete Example - Custom Filtering",
                MetaDescription = "This Blazor AutoComplete example demonstrates custom filtering logic. Learn how to implement specialized filtering algorithms beyond the standard options.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Validation",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor AutoComplete Validation | Form Integration | Syncfusion",
                HeaderText = "Blazor AutoComplete Example - Form Validation",
                MetaDescription = "This Blazor AutoComplete example demonstrates how to implement required field validation and custom validation rules with Blazor's form validation system.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor AutoComplete Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor AutoComplete Example - Keyboard Navigation",
                MetaDescription = "Blazor AutoComplete demo shows keyboard navigation capabilities. Learn how to navigate suggestions, select items, operate the component using keyboard shortcut.",
                Type = SampleType.None
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
                MetaTitle = "MultiSelect Dropdown Default Example - Syncfusion Demos",
                HeaderText = "Blazor MultiSelect Dropdown Example - Default Functionalities",
                MetaDescription = "Blazor MultiSelectDropdown demo shows multiple selection capabilities. Learn how to create dropdown controls and allow users to select multiple items from list.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Data-Binding",
                FileName = "DataBinding.razor",
                MetaTitle = "Blazor MultiSelect Dropdown Binding | Multiple Sources | Syncfusion",
                HeaderText = "Blazor MultiSelect Dropdown Example - Data Binding",
                MetaDescription = "This Blazor MultiSelect Dropdown example shows data binding capabilities. Learn how to bind local and remote data sources to provide multiple selection options.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Disabled Items",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/DisabledItems",
                FileName = "DisabledItems.razor",
                MetaTitle = "Blazor MultiSelect Dropdown Disabled Items | Selective UI | Syncfusion",
                HeaderText = "Blazor MultiSelect Dropdown Example - Disabled Items",
                MetaDescription = "Blazor MultiSelect Dropdown demo shows disabled items functionality. Learn how to selectively disable specific options while maintaining others as selectable.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Filtering",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Filtering",
                FileName = "Filtering.razor",
                MetaTitle = "Blazor MultiSelect Dropdown Filtering | Search Options | Syncfusion",
                HeaderText = "Blazor MultiSelect Dropdown Example - Filtering",
                MetaDescription = "Blazor MultiSelect Dropdown demo shows filtering capabilities. Learn how to implement search within the dropdown to quickly find items in large option sets.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "CheckBox",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/CheckBox",
                FileName = "CheckBox.razor",
                MetaTitle = "Blazor MultiSelect Dropdown Checkbox | Visual Selection | Syncfusion",
                HeaderText = "Blazor MultiSelect Dropdown Example - Checkbox Selection",
                MetaDescription = "This Blazor MultiSelect Dropdown example demonstrates how to enhance the multiple selection with visual checkbox indicators for clearer selection states.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Custom Value",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Custom-Value",
                FileName = "CustomValue.razor",
                MetaTitle = "Blazor MultiSelect Dropdown Custom Values | User Input | Syncfusion",
                HeaderText = "Blazor MultiSelect Dropdown Example - Custom Value Entry",
                MetaDescription = "This Blazor MultiSelect Dropdown example shows custom value support. Learn how to allow users to add new values not present in the predefined options list.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Chip Customization",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Chip-Customization",
                MetaTitle = "MultiSelect Dropdown Chip Customization - Syncfusion Demos",
                FileName = "ChipCustomization.razor",
                HeaderText = "Blazor MultiSelect Dropdown Example - Chip Customization",
                MetaDescription = "This Blazor MultiSelect Dropdown example demonstrates how to style selected item chips with custom templates, colors, and behavior for enhanced visual feedback.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Grouping",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Grouping",
                FileName = "Grouping.razor",
                MetaTitle = "Blazor MultiSelect Dropdown Grouping | Categorized Option | Syncfusion",
                HeaderText = "Blazor MultiSelect Dropdown Example - Option Grouping",
                MetaDescription = "This Blazor MultiSelect Dropdown demo shows grouping capabilities. Learn how to organize selection options into logical categories for better information.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Selection Limit",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Selection-Limit",
                FileName = "SelectionLimit.razor",
                MetaTitle = "Blazor MultiSelect Dropdown Selection Limit | Input | Syncfusion",
                HeaderText = "Blazor MultiSelect Dropdown Example - Selection Limits",
                MetaDescription = "This Blazor MultiSelect Dropdown example shows selection limiting features. Learn how to set minimum and maximum selection constraints to control user input.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Template",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Template",
                FileName = "Template.razor",
                MetaTitle = "Blazor MultiSelect Dropdown Templates | Custom UI | Syncfusion",
                HeaderText = "Blazor MultiSelect Dropdown Example - Custom Templates",
                MetaDescription = "This Blazor MultiSelect Dropdown demo shows custom templating. Learn how to create rich dropdown items and selection chips with custom HTML content and styling.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Virtualization",
                FileName = "Virtualization.razor",
                MetaTitle = "Blazor MultiSelect Dropdown Virtualization | Performance | Syncfusion",
                HeaderText = "Blazor MultiSelect Dropdown Example - UI Virtualization",
                MetaDescription = "This Blazor MultiSelect Dropdown example demonstrates UI virtualization for large datasets. Learn how to handle thousands of options with optimal performance.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Validation",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor MultiSelect Dropdown Validation | Form Integration | Syncfusion",
                HeaderText = "Blazor MultiSelect Dropdown Example - Form Validation",
                MetaDescription = "Blazor MultiSelect Dropdown demo shows form validation integration. Learn how to implement required field validation and selection constraints in Blazor forms.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "MultiSelect Dropdown Keyboard Navigation - Syncfusion Demos",
                HeaderText = "Blazor MultiSelect Dropdown Example - Keyboard Navigation",
                MetaDescription = "Blazor MultiSelect Dropdown demo shows keyboard navigation capabilities. Learn how to navigate, select, and manage multiple selections using keyboard shortcuts.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Popup Resize",
                Category = "MultiSelect Dropdown",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect-Dropdown/Resize",
                FileName = "Resize.razor",
                MetaTitle = "Blazor MultiSelect Dropdown Popup Resize | Adaptive UI | Syncfusion",
                HeaderText = "Blazor MultiSelect Dropdown Example - Popup Resize",
                MetaDescription = "Blazor MultiSelect Dropdown demo shows popup resizing. Learn how to customize the dropdown dimensions to better accommodate your content and layout requirement.",
                Type = SampleType.None
            }
        };

        public List<Sample> MultiColumnComboBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/Default-Functionalities",
                MetaTitle = "MultiColumn ComboBox Default Example - Syncfusion Demos",
                HeaderText = "Blazor MultiColumn ComboBox Example - Default Functionalities",
                MetaDescription = "Blazor MultiColumn ComboBox demo shows default functionalities. Learn how to create a dropdown with multiple columns for displaying complex structured data.",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Remote Data Binding",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/Remote-Data-Binding",
                MetaTitle = "MultiColumn ComboBox Remote Data Binding - Syncfusion Demos",
                HeaderText = "Blazor MultiColumn ComboBox Example - Remote Data Binding",
                MetaDescription = "This Blazor MultiColumn ComboBox example shows remote data binding. Learn how to fetch and display data from server sources in a multi-column dropdown format.",
                FileName = "RemoteDataBinding.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Paging",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/Paging",
                FileName = "Paging.razor",
                MetaTitle = "Blazor MultiColumn ComboBox Paging | Paginated Data | Syncfusion",
                HeaderText = "Blazor MultiColumn ComboBox Example - Paging",
                MetaDescription = "Blazor MultiColumn ComboBox demo shows paging capabilities. Learn how to implement pagination for large datasets to improve user experience and performance.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Filtering",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/Filtering",
                FileName = "Filtering.razor",
                MetaTitle = "Blazor MultiColumn ComboBox Filtering | Search Features | Syncfusion",
                HeaderText = "Blazor MultiColumn ComboBox Example - Filtering",
                MetaDescription = "Blazor MultiColumn ComboBox demo shows filtering capabilities. Learn how to implement search across multiple columns of data to find relevant information.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/Virtualization",
                FileName = "Virtualization.razor",
                MetaTitle = "Blazor MultiColumn ComboBox Virtualization | Performance | Syncfusion",
                HeaderText = "Blazor MultiColumn ComboBox Example - Virtualization",
                MetaDescription = "Blazor MultiColumn ComboBox example demonstrates how to render thousands of records with optimal performance by displaying only visible rows in the viewport.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Grouping and Sorting",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/Grouping-Sorting",
                MetaTitle = "MultiColumn ComboBox Grouping & Sorting - Syncfusion Demos",
                HeaderText = "Blazor MultiColumn ComboBox Example - Grouping and Sorting",
                MetaDescription = "Blazor MultiColumnComboBox demo shows grouping and sorting capabilities. Learn how to organize multicolumn data into logical groups with custom sorting options.",
                FileName = "Grouping.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Template",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/Template",
                FileName = "Template.razor",
                MetaTitle = "Blazor MultiColumn ComboBox Templates | Custom UI | Syncfusion",
                HeaderText = "Blazor MultiColumn ComboBox Example - Custom Templates",
                MetaDescription = "This Blazor MultiColumn ComboBox demo shows custom cell templates. Learn how to create rich column content with custom HTML, formatting and conditional styling.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "MultiColumn ComboBox Keyboard Navigation - Syncfusion Demos",
                HeaderText = "Blazor MultiColumn ComboBox Example - Keyboard Navigation",
                MetaDescription = "This Blazor MultiColumn ComboBox example demonstrates how to navigate the multi-column data, change pages, and make selections using keyboard shortcuts.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Row Style",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/RowStyle",
                FileName = "RowStyle.razor",
                MetaTitle = "Blazor MultiColumn ComboBox Row Styling | Visual Cues | Syncfusion",
                HeaderText = "Blazor MultiColumn ComboBox Example - Row Styling",
                MetaDescription = "Blazor MultiColumnComboBox demo shows row styling capabilities. Learn how to apply custom CSS, conditional formatting, and visual indicator to data readability.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Form Support",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/FormSupport",
                FileName = "FormSupport.razor",
                MetaTitle = "Blazor MultiColumn ComboBox Form Support | Validation | Syncfusion",
                HeaderText = "Blazor MultiColumn ComboBox Example - Form Integration",
                MetaDescription = "Blazor MultiColumnComboBox demo shows form integration. Learn how to use the component in Blazor forms with validation support and data submission capabilities.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Text Wrap",
                Category = "MultiColumn ComboBox",
                Directory = "DropDowns/MultiColumnComboBox",
                Url = "MultiColumn-ComboBox/TextWrap",
                FileName = "TextWrap.razor",
                MetaTitle = "Blazor MultiColumn ComboBox Text Wrap | Content Layout | Syncfusion",
                HeaderText = "Blazor MultiColumn ComboBox Example - Text Wrapping",
                MetaDescription = "Blazor MultiColumnComboBox demo shows text wrapping capabilities. Learn how to handle long text content in columns with wrapping, clipping, and tooltip options.",
                Type = SampleType.None
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
                MetaTitle = "Blazor ListBox Default Functionalities | Selection UI | Syncfusion",
                HeaderText = "Blazor ListBox Example - Default Functionalities",
                MetaDescription = "Blazor ListBox demo shows default selection capabilities. Learn how to create a versatile listbox with various selection modes and built-in keyboard navigation.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Dual ListBox",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "listbox/dual-listbox",
                FileName = "DualListBox.razor",
                MetaTitle = "Blazor Dual ListBox Example | Transfer UI | Syncfusion",
                HeaderText = "Blazor ListBox Example - Dual ListBox Configuration",
                MetaDescription = "Blazor Dual ListBox demo shows item transfer between two lists. Learn how to implement a shuttle interface for moving items between source and target lists."
            },
            new Sample
            {
                Name = "Drag and Drop",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "listbox/drag-and-drop",
                FileName = "DragDrop.razor",
                MetaTitle = "Blazor ListBox Drag and Drop | Interactive Reordering | Syncfusion",
                HeaderText = "Blazor ListBox Example - Drag and Drop",
                MetaDescription = "Blazor ListBox demo shows drag and drop capabilities. Learn how to implement interactive item reordering and transfer between multiple lists via drag and drop.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Checkbox",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "listbox/checkbox",
                FileName = "Checkbox.razor",
                MetaTitle = "Blazor ListBox Checkbox Selection | Multiple Select | Syncfusion",
                HeaderText = "Blazor ListBox Example - Checkbox Selection",
                MetaDescription = "This Blazor ListBox demo shows checkbox selection mode. Learn how to implement multiple selection with visual checkbox indicators for clearer selection states.",
                Type = SampleType.None
            },
            new Sample
            {
               Name = "Template",
               Category = "ListBox",
               Directory = "DropDowns/ListBox",
               Url = "listbox/template",
               FileName = "Template.razor",
               MetaTitle = "Blazor ListBox Templates | Custom Item Rendering | Syncfusion",
               HeaderText = "Blazor ListBox Example - Custom Templates",
               MetaDescription = "This Blazor ListBox example demonstrates how to create rich list items with custom HTML layout, formatting, and styling for enhanced visual presentation.",
               Type = SampleType.None
            },
            new Sample
            {
               Name = "API",
               Category = "ListBox",
               Directory = "DropDowns/ListBox",
               Url = "listbox/api",
               FileName = "Api.razor",
               MetaTitle = "Blazor ListBox API Example | Method Showcase | Syncfusion",
               HeaderText = "Blazor ListBox Example - API Methods",
               MetaDescription = "Blazor ListBox demo shows API methods and properties. Learn how to programmatically control selection, manage items respond to events for complex interactions.",
               Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "listbox/keyboard-navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor ListBox Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor ListBox Example - Keyboard Navigation",
                MetaDescription = "Blazor ListBox demo shows keyboard navigation capabilities. Learn how to navigate items, make selections, and operate the component using keyboard shortcuts."
            }
        };

        public List<Sample> Mention { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Mention",
                Directory = "DropDowns/Mention",
                Url = "Mention/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Mention Component | @mention Feature | Syncfusion",
                HeaderText = "Blazor Mention Example - Default Functionalities",
                MetaDescription = "Blazor Mention component demo shows the default @mention functionality. Learn how to implement social media-style user tagging in text inputs and content areas.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multiple List",
                Category = "Mention",
                Directory = "DropDowns/Mention",
                Url = "Mention/Multiple-List",
                FileName = "MultipleList.razor",
                MetaTitle = "Blazor Mention Multiple Lists | Multi-category | Syncfusion",
                HeaderText = "Blazor Mention Example - Multiple Data Sources",
                MetaDescription = "This Blazor Mention example shows multiple data source integration. Learn how to implement different mention triggers for users, tags, and other content types.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Template",
                Category = "Mention",
                Directory = "DropDowns/Mention",
                Url = "Mention/Template",
                FileName = "Templates.razor",
                MetaTitle = "Blazor Mention Templates | Custom Suggestion UI | Syncfusion",
                HeaderText = "Blazor Mention Example - Custom Templates",
                MetaDescription = "This Blazor Mention example shows custom suggestion templates. Learn how to create rich mention suggestions with user avatars, metadata, and styled content.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Disabled Items",
                Category = "Mention",
                Directory = "DropDowns/Mention",
                Url = "Mention/DisabledItems",
                FileName = "DisabledItems.razor",
                MetaTitle = "Blazor Mention Disabled Items | Selective Tagging | Syncfusion",
                HeaderText = "Blazor Mention Example - Disabled Items",
                MetaDescription = "Blazor Mention demo shows disabled suggestion items. Learn how to selectively disable specific users/tags from being mentioned while keeping others available.",
                Type = SampleType.None,
            }
        };
    }
}
