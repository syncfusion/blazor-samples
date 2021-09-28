using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> TextBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "TextBox",
                Directory = "Inputs/TextBox",
                Url = "TextBox/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Multiline TextBox",
                Category = "TextBox",
                Directory = "Inputs/TextBox",
                Url = "TextBox/Multiline-TextBox",
                FileName = "Multiline.razor"
            },
            new Sample
            {
                Name = "Validation",
                Category = "TextBox",
                Directory = "Inputs/TextBox",
                Url = "TextBox/Forms-Validation",
                FileName = "FormsValidation.razor",
            }
        };

        public List<Sample> ColorPicker { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Color Picker",
                Directory = "Inputs/ColorPicker",
                Url = "color-picker/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Inline Mode",
                Category = "Color Picker",
                Directory = "Inputs/ColorPicker",
                Url = "color-picker/inline",
                FileName = "Inline.razor"
            },
            new Sample
            {
                Name = "Custom Palettes",
                Category = "Color Picker",
                Directory = "Inputs/ColorPicker",
                Url = "color-picker/custom",
                FileName = "Custom.razor"
            },
            new Sample
            {
                Name = "API",
                Category = "Color Picker",
                Directory = "Inputs/ColorPicker",
                Url = "color-picker/api",
                FileName = "Api.razor"
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Color Picker",
                Directory = "Inputs/ColorPicker",
                Url = "color-picker/keyboard-navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.New
            }
        };

        public List<Sample> InputMask { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Input Mask",
                Directory = "Inputs/MaskedTextBox",
                Url = "Input-Mask/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
             new Sample
            {
                Name = "Custom Mask",
                Category = "Input Mask",
                Directory = "Inputs/MaskedTextBox",
                Url = "Input-Mask/Custom-Mask",
                FileName = "CustomMask.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[] {
                    @"Updated the demo by including an option to change the prompt character of the masked textbox."
                }
            },
              new Sample
            {
                Name = "Validation",
                Category = "Input Mask",
                Directory = "Inputs/MaskedTextBox",
                Url = "Input-Mask/Forms-Validation",
                FileName = "FormsValidation.razor",
            }
        };

        public List<Sample> NumericTextbox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Custom Format",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Custom-Format",
                FileName = "CustomFormat.razor"
            },
            new Sample
            {
                Name = "Restrict Decimals",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Restrict-Decimals",
                FileName = "RestrictDecimals.razor"
            },
            new Sample
            {
                Name = "Range Validation",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Range-Validation",
                FileName = "RangeValidation.razor"
            },
            new Sample
            {
                Name = "Validation",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Forms-Validation",
                FileName = "FormsValidation.razor",
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.New
            }
        };
        public List<Sample> FileUpload { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor File Upload Example of default functionalities - Syncfusion Demos",
                HeaderText = "Blazor File Upload Example of default functionalities"
            },
             new Sample
            {
                Name = "Chunk Upload",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/Chunk-Upload",
                FileName = "ChunkUpload.razor"
            },
               new Sample
            {
                Name = "Preload Files",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/Preload-Files",
                FileName = "PreloadFiles.razor"
            },
               new Sample
            {
                Name = "File Validation",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/File-Validation",
                FileName = "FileValidation.razor"
            },
               new Sample
            {
                Name = "Custom Drop Area",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/Custom-DropArea",
                FileName = "CustomDropArea.razor",
            },
                new Sample
            {
                Name = "Keyboard Navigation",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.New
            }
        };
        public List<Sample> RangeSlider { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/default",
                FileName = "Default.razor"
            },
            new Sample
            {
                Name = "Ticks",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/ticks",
                FileName = "Ticks.razor"
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/tooltip",
                FileName = "Tooltip.razor"
            },
            new Sample
            {
                Name = "Vertical Orientation",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/vertical-orientation",
                FileName = "VerticalOrientation.razor"
            },
             new Sample
            {
                Name = "Formatting",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/formatting",
                FileName = "Formatting.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Limits",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/limits",
                FileName = "Limits.razor"
            },
            new Sample
            {
                Name = "API",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/api",
                FileName = "API.razor"
            },
            new Sample
            {
                Name = "Events",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/events",
                FileName = "Events.razor"
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/keyboard-navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.New,
                NotificationDescription = new string[]
                {
                    @"Added a demo for keyboard accessibility of the Slider component."
                }
            },
            new Sample
            {
                Name = "Thumb",
                Category = "Customization",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/custom-thumb",
                FileName = "CustomThumb.razor"
            },
            new Sample
            {
                Name = "Bar",
                Category = "Customization",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/custom-bar",
                FileName = "CustomBar.razor"
            },          
                  new Sample
            {
                Name = "Tooltip",
                Category = "Customization",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/custom-tooltip",
                FileName = "CustomTooltip.razor",
                Type = SampleType.New,
                NotificationDescription = new string[]
                {
                    @"Added a demo to showcase the tooltip customization sample in the Slider component."
                }
            },
             new Sample
            {
                Name = "Cloud Pricing",
                Category = "Use Case",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/cloud-pricing",
                FileName = "CloudPricing.razor",
                Type = SampleType.New,
                NotificationDescription = new string[]
                {
                    @"Added a demo to demonstrates how to use the Slider component to calculate cloud budget."
                }
            },
        };
    }

   


}
