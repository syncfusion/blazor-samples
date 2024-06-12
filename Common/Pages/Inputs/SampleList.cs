#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> TextArea { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "TextArea",
                Directory = "Inputs/TextArea",
                Url = "TextArea/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor TextArea | Default Functionalities | Syncfusion Demos",
                HeaderText = "Blazor TextArea - Default Functionalities",
                MetaDescription = "This example of Blazor TextArea demonstrates the rendering of the textArea component using a default functionalities.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="DefaultFunctionalities",
                        FileName="DefaultFunctionalities.razor"
                    },
                },
            },
            new Sample
            {
                Name = "Floating Label",
                Category = "TextArea",
                Directory = "Inputs/TextArea",
                Url = "TextArea/FloatingLabel",
                FileName = "FloatingLabel.razor",
                MetaTitle = "Blazor TextArea | Floating Label | Syncfusion Demos",
                HeaderText = "Blazor TextArea - Floating Label",
                MetaDescription = "The example below demonstrates the floating label functionality in the Blazor textArea component.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Floating Label",
                        FileName="FloatingLabel.razor"
                    },
                },
            },
            new Sample
            {
                Name = "Resize",
                Category = "TextArea",
                Directory = "Inputs/TextArea",
                Url = "TextArea/Resize",
                FileName = "Resize.razor",
                MetaTitle = "Blazor TextArea | Resize | Syncfusion Demos",
                HeaderText = "Blazor TextArea - Resize",
                MetaDescription = "This Blazor TextArea example demonstrates how to adjust the size of the TextArea component dynamically using the ResizeMode property.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Resize",
                        FileName="Resize.razor"
                    },
                },
            },
            new Sample
            {
                Name = "Validation",
                Category = "TextArea",
                Directory = "Inputs/TextArea",
                Url = "TextArea/FormsValidation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor TextArea | Validation | Syncfusion Demos",
                HeaderText = "Blazor TextArea - Validation",
                MetaDescription = "This example of Blazor TextArea demonstrates the validation of the textArea component.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Validation",
                        FileName="FormsValidation.razor"
                    },
                },
            },
            new Sample
            {
                Name = "API",
                Category = "TextArea",
                Directory = "Inputs/TextArea",
                Url = "TextArea/Api",
                FileName = "Api.razor",
                MetaTitle = "Blazor TextArea | API | Syncfusion Demos",
                HeaderText = "Blazor TextArea - API",
                MetaDescription = "This example of Blazor TextArea demonstrates how to dynamically update the column count, row count, max-length, enable, read only mode and show clear button of the textArea component.",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="API",
                        FileName="Api.razor"
                    },
                },
            }
        };
        
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
                FileName = "KeyboardNavigation.razor"
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
                Type = SampleType.None
            },
              new Sample
            {
                Name = "Literals and Prompt",
                Category = "Input Mask",
                Directory = "Inputs/MaskedTextBox",
                Url = "Input-Mask/Literals-And-Prompt",
                FileName = "LiteralsAndPrompt.razor",
                Type = SampleType.None
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
                Type = SampleType.None
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
                Type = SampleType.None
            }
        };
        public List<Sample> RangeSlider { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
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
                FileName = "VerticalOrientation.razor",
                Type= SampleType.None
            },
             new Sample
            {
                Name = "Formatting",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/formatting",
                FileName = "Formatting.razor",
                Type = SampleType.None
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
                Type = SampleType.None
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
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Cloud Pricing",
                Category = "Use Case",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/cloud-pricing",
                FileName = "CloudPricing.razor",
                Type = SampleType.None
            },
        };
        public List<Sample> Signature { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Signature",
                Directory = "Inputs/Signature",
                Url = "Signature/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
             new Sample
             {
                Name = "Toolbar",
                Category = "Signature",
                Directory = "Inputs/Signature",
                Url = "Signature/Toolbar",
                FileName = "Toolbar.razor"
             }
        };
        public List<Sample> Rating { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Precision",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/precision",
                FileName = "Precision.razor"
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/tooltip",
                FileName = "Tooltip.razor"
            },
            new Sample
            {
                Name = "Label",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/label",
                FileName = "Label.razor"
            },
            new Sample
            {
                Name = "Template",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/template",
                FileName = "Template.razor"
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/navigation",
                FileName = "KeyboardNavigation.razor"
            }
        };
        public List<Sample> OtpInput { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "OtpInput",
                Directory = "Inputs/OtpInput",
                Url = "otp-input/default-functionalities",
                FileName = "Default.razor",
                NotificationDescription = new string[] {
                    @"Showcases the basic features of the OTP Input component with its available input types such as Number, Text and Password."
                }
            },
            new Sample
            {
                Name = "API",
                Category = "OtpInput",
                Directory = "Inputs/OtpInput",
                Url = "otp-input/api",
                FileName = "Api.razor",
                NotificationDescription = new string[] {
                    @"Showcases the usage of different API's available in the OTP Input component, such as StylingMode, Length, Placeholder, Separator, CssClass, and Disabled."
                }
            }
        };
  }

   


}
