#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
                MetaDescription = "This Blazor TextArea example showcases how to implement and validate the TextArea component, ensuring user input meets specified requirements and constraints.",
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
                MetaDescription = "This Blazor TextArea example shows how to dynamically update column count, row count, max-length, enable/disable, read-only mode, toggle the clear button.",
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
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor TextBox | Default Functionalities | Syncfusion",
                HeaderText = "Blazor TextBox - Default Functionalities",
                MetaDescription = "This Blazor TextBox example demonstrates the default functionalities including basic text input, placeholder support, floating labels, and value binding in a responsive interface."
            },
            new Sample
            {
                Name = "Multiline TextBox",
                Category = "TextBox",
                Directory = "Inputs/TextBox",
                Url = "TextBox/Multiline-TextBox",
                FileName = "Multiline.razor",
                MetaTitle = "Blazor TextBox | Multiline Text Input | Syncfusion",
                HeaderText = "Blazor TextBox - Multiline Input",
                MetaDescription = "This Blazor TextBox example demonstrates multiline text input functionality. The component adapts to display multiple lines of text with customizable rows, columns, and auto-resize capabilities."
            },
            new Sample
            {
                Name = "Validation",
                Category = "TextBox",
                Directory = "Inputs/TextBox",
                Url = "TextBox/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor TextBox | Form Validation | Syncfusion",
                HeaderText = "Blazor TextBox - Form Validation",
                MetaDescription = "This Blazor TextBox validation example demonstrates how to integrate with forms validation. Includes built-in validators for required fields, pattern matching, and custom validation rules."
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
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Color Picker | Default Functionalities | Syncfusion",
                HeaderText = "Blazor Color Picker - Default Functionalities",
                MetaDescription = "This Blazor Color Picker example demonstrates the default color selection capabilities with RGB, HSV, and hex color models. Features include color palettes, opacity control, and live preview."
            },
            new Sample
            {
                Name = "Inline Mode",
                Category = "Color Picker",
                Directory = "Inputs/ColorPicker",
                Url = "color-picker/inline",
                FileName = "Inline.razor",
                MetaTitle = "Blazor Color Picker | Inline Mode | Syncfusion",
                HeaderText = "Blazor Color Picker - Inline Mode",
                MetaDescription = "This Blazor Color Picker inline mode example shows how to embed the color selection interface directly in the page layout without a popup, providing immediate accessibility to all color options."
            },
            new Sample
            {
                Name = "Custom Palettes",
                Category = "Color Picker",
                Directory = "Inputs/ColorPicker",
                Url = "color-picker/custom",
                FileName = "Custom.razor",
                MetaTitle = "Blazor Color Picker | Custom Palettes | Syncfusion",
                HeaderText = "Blazor Color Picker - Custom Color Palettes",
                MetaDescription = "This Blazor Color Picker custom palettes example demonstrates how to define and use custom color collections. Create branded color themes or predefined color sets for consistent selection."
            },
            new Sample
            {
                Name = "API",
                Category = "Color Picker",
                Directory = "Inputs/ColorPicker",
                Url = "color-picker/api",
                FileName = "Api.razor",
                MetaTitle = "Blazor Color Picker | API Options | Syncfusion",
                HeaderText = "Blazor Color Picker - API Functionalities",
                MetaDescription = "This Blazor Color Picker API example showcases programmatic control over the component. Dynamically change modes, toggle features, set colors, and control the interface through code."
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Color Picker",
                Directory = "Inputs/ColorPicker",
                Url = "color-picker/keyboard-navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor Color Picker | Keyboard Navigation | Syncfusion",
                HeaderText = "Blazor Color Picker - Keyboard Navigation",
                MetaDescription = "This Blazor Color Picker keyboard navigation example demonstrates accessibility features for keyboard users. Navigate through color options, adjust values, and select colors using keyboard shortcuts."
            }
        };

        public List<Sample> InputMask { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Input Mask",
                Directory = "Inputs/MaskedTextBox",
                Url = "Input-Mask/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Input Mask | Default Functionalities | Syncfusion",
                HeaderText = "Blazor Input Mask - Default Functionalities",
                MetaDescription = "This Blazor Input Mask example demonstrates standard mask formats including phone numbers, social security numbers, and zip codes with automatic formatting as users type."
            },
             new Sample
            {
                Name = "Custom Mask",
                Category = "Input Mask",
                Directory = "Inputs/MaskedTextBox",
                Url = "Input-Mask/Custom-Mask",
                FileName = "CustomMask.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Input Mask | Custom Mask Patterns | Syncfusion",
                HeaderText = "Blazor Input Mask - Custom Mask Patterns",
                MetaDescription = "This Blazor Input Mask custom pattern example demonstrates creating specialized input formats with custom rules. Define precise data entry patterns for unique information types."
            },
              new Sample
            {
                Name = "Literals and Prompt",
                Category = "Input Mask",
                Directory = "Inputs/MaskedTextBox",
                Url = "Input-Mask/Literals-And-Prompt",
                FileName = "LiteralsAndPrompt.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Input Mask | Literals and Prompts | Syncfusion",
                HeaderText = "Blazor Input Mask - Literals and Prompt Characters",
                MetaDescription = "This Blazor Input Mask example shows how to configure literal characters and prompt symbols. Customize the visual indicators that guide users through proper data entry format."
            },
              new Sample
            {
                Name = "Validation",
                Category = "Input Mask",
                Directory = "Inputs/MaskedTextBox",
                Url = "Input-Mask/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor Input Mask | Form Validation | Syncfusion",
                HeaderText = "Blazor Input Mask - Form Validation Integration",
                MetaDescription = "This Blazor Input Mask validation example demonstrates integration with forms validation. Ensure properly formatted input with built-in validation features for masked data entry fields."
            }
        };

        public List<Sample> NumericTextbox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Default-Functionalities",
                MetaTitle = "Numeric Textbox Default Functionalities - Syncfusion Demos",
                FileName = "DefaultFunctionalities.razor",
                HeaderText = "Blazor Numeric TextBox - Default Functionalities",
                MetaDescription = "This Blazor Numeric TextBox example demonstrates the essential features including value binding, increment/decrement buttons, and numeric input validation with configurable step values."
            },
            new Sample
            {
                Name = "Custom Format",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Custom-Format",
                FileName = "CustomFormat.razor",
                MetaTitle = "Blazor Numeric TextBox | Custom Formatting | Syncfusion",
                HeaderText = "Blazor Numeric TextBox - Custom Format",
                MetaDescription = "This Blazor Numeric TextBox formatting example shows how to customize the display of numeric values with currency symbols, percentages, and custom number formats."
            },
            new Sample
            {
                Name = "Restrict Decimals",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Restrict-Decimals",
                FileName = "RestrictDecimals.razor",
                MetaTitle = "Blazor Numeric TextBox | Decimal Precision | Syncfusion",
                HeaderText = "Blazor Numeric TextBox - Restrict Decimals",
                MetaDescription = "This Blazor Numeric TextBox decimal precision example demonstrates how to control and limit decimal places in numeric input. Configure exact decimal precision for different data types."
            },
            new Sample
            {
                Name = "Range Validation",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Range-Validation",
                FileName = "RangeValidation.razor",
                MetaTitle = "Blazor Numeric TextBox | Range Validation | Syncfusion",
                HeaderText = "Blazor Numeric TextBox - Range Validation",
                MetaDescription = "This Blazor Numeric TextBox range validation example demonstrates setting minimum and maximum value constraints. Ensure numeric input falls within acceptable boundaries with visual feedback."
            },
            new Sample
            {
                Name = "Validation",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor Numeric TextBox | Forms Validation | Syncfusion",
                HeaderText = "Blazor Numeric TextBox - Form Validation",
                MetaDescription = "This Blazor Numeric TextBox validation example showcases integration with form validation. Implement required field validation, range checking, and custom validation rules for numeric input."
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Numeric TextBox | Keyboard Navigation | Syncfusion",
                HeaderText = "Blazor Numeric TextBox - Keyboard Navigation",
                MetaDescription = "This Blazor Numeric TextBox keyboard navigation example demonstrates accessibility features for keyboard users. Control and edit numeric values using arrow keys and keyboard shortcuts."
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
                MetaTitle = "File Upload default functionalities - Syncfusion Demos",
                HeaderText = "Blazor File Upload Example of default functionalities",
                MetaDescription = "This Blazor File Upload example demonstrates essential features including file selection, progress tracking, and upload/cancel operations. Handle single or multiple file uploads with intuitive UI."
            },
             new Sample
            {
                Name = "Chunk Upload",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/Chunk-Upload",
                FileName = "ChunkUpload.razor",
                MetaTitle = "Blazor File Upload | Chunk Upload | Syncfusion",
                HeaderText = "Blazor File Upload - Chunk Upload",
                MetaDescription = "This Blazor File Upload chunk upload example demonstrates how to upload large files in smaller pieces. Improve reliability and performance when handling large file uploads with pause/resume capability."
            },
               new Sample
            {
                Name = "Preload Files",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/Preload-Files",
                FileName = "PreloadFiles.razor",
                MetaTitle = "Blazor File Upload | Preload Files | Syncfusion",
                HeaderText = "Blazor File Upload - Preload Files",
                MetaDescription = "This Blazor File Upload preload example shows how to display previously uploaded files. Present existing files with options to view, download or remove them alongside new upload functionality."
            },
               new Sample
            {
                Name = "File Validation",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/File-Validation",
                FileName = "FileValidation.razor",
                MetaTitle = "Blazor File Upload | File Validation | Syncfusion",
                HeaderText = "Blazor File Upload - File Validation",
                MetaDescription = "This Blazor File Upload validation example demonstrates how to validate files before upload. Set restrictions for file types, size limits, and count with appropriate error messages."
            },
               new Sample
            {
                Name = "Custom Drop Area",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/Custom-DropArea",
                FileName = "CustomDropArea.razor",
                MetaTitle = "Blazor File Upload | Custom Drop Area | Syncfusion",
                HeaderText = "Blazor File Upload - Custom Drop Area",
                MetaDescription = "This Blazor File Upload custom drop area example shows how to create a personalized drag-and-drop zone. Design intuitive file drop regions with custom styling and behavior."
            },
                new Sample
            {
                Name = "Keyboard Navigation",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor File Upload | Keyboard Navigation | Syncfusion",
                HeaderText = "Blazor File Upload - Keyboard Navigation",
                MetaDescription = "This Blazor File Upload keyboard navigation example demonstrates accessibility features. Navigate through upload controls, select files, and manage uploads using keyboard shortcuts."
            }
        };
        public List<Sample> RangeSlider { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/default",
                FileName = "Default.razor",
                MetaTitle = "Blazor Range Slider | Default Functionalities | Syncfusion",
                HeaderText = "Blazor Range Slider - Default Functionalities",
                MetaDescription = "This Blazor Range Slider example demonstrates basic slider functionality with single and range selection modes. Easily select numeric values or ranges with an intuitive drag interface."
            },
            new Sample
            {
                Name = "Ticks",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/ticks",
                FileName = "Ticks.razor",
                MetaTitle = "Blazor Range Slider | Tick Marks | Syncfusion",
                HeaderText = "Blazor Range Slider - Tick Marks",
                MetaDescription = "This Blazor Range Slider ticks example demonstrates customizable tick marks for visual reference. Configure major and minor ticks with labels to indicate value positions along the slider."
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/tooltip",
                FileName = "Tooltip.razor",
                MetaTitle = "Blazor Range Slider | Tooltips | Syncfusion",
                HeaderText = "Blazor Range Slider - Tooltips",
                MetaDescription = "This Blazor Range Slider tooltip example shows how to display value tooltips during interaction. Configure tooltip positioning, formatting, and behavior for improved value visualization."
            },
            new Sample
            {
                Name = "Vertical Orientation",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/vertical-orientation",
                FileName = "VerticalOrientation.razor",
                Type= SampleType.None,
                MetaTitle = "Blazor Range Slider | Vertical Orientation | Syncfusion",
                HeaderText = "Blazor Range Slider - Vertical Orientation",
                MetaDescription = "This Blazor Range Slider vertical orientation example demonstrates top-to-bottom slider layout. Implement space-efficient vertical sliders with all the features of horizontal sliders."
            },
             new Sample
            {
                Name = "Formatting",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/formatting",
                FileName = "Formatting.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Range Slider | Value Formatting | Syncfusion",
                HeaderText = "Blazor Range Slider - Value Formatting",
                MetaDescription = "This Blazor Range Slider formatting example demonstrates custom value display formats. Apply currency, percentage, or custom formats to slider values and tooltips for intuitive representation."
            },
            new Sample
            {
                Name = "Limits",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/limits",
                FileName = "Limits.razor",
                MetaTitle = "Blazor Range Slider | Range Limits | Syncfusion",
                HeaderText = "Blazor Range Slider - Range Limits",
                MetaDescription = "This Blazor Range Slider limits example demonstrates setting constraints on selectable ranges. Define minimum and maximum selectable values, enforced limits, and minimum range spans."
            },
            new Sample
            {
                Name = "API",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/api",
                FileName = "API.razor",
                MetaTitle = "Blazor Range Slider | API Options | Syncfusion",
                HeaderText = "Blazor Range Slider - API Functionalities",
                MetaDescription = "This Blazor Range Slider API example showcases programmatic control over the component. Dynamically change values, ranges, steps, and other properties through code interaction."
            },
            new Sample
            {
                Name = "Events",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/events",
                FileName = "Events.razor",
                MetaTitle = "Blazor Range Slider | Events | Syncfusion",
                HeaderText = "Blazor Range Slider - Events",
                MetaDescription = "This Blazor Range Slider events example demonstrates handling various user interactions. Respond to value changes, drag start/end events, and user selection with custom event handlers."
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/keyboard-navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Range Slider | Keyboard Navigation | Syncfusion",
                HeaderText = "Blazor Range Slider - Keyboard Navigation",
                MetaDescription = "This Blazor Range Slider keyboard navigation example demonstrates accessibility features. Control slider values precisely using arrow keys and keyboard shortcuts for better accessibility."
            },
            new Sample
            {
                Name = "Thumb",
                Category = "Customization",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/custom-thumb",
                FileName = "CustomThumb.razor",
                MetaTitle = "Blazor Range Slider | Custom Thumb | Syncfusion",
                HeaderText = "Blazor Range Slider - Custom Thumb",
                MetaDescription = "This Blazor Range Slider custom thumb example shows how to create personalized slider handles. Replace default thumbs with custom designs, icons, or elements for unique slider appearance."
            },
            new Sample
            {
                Name = "Bar",
                Category = "Customization",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/custom-bar",
                FileName = "CustomBar.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Range Slider | Custom Bar | Syncfusion",
                HeaderText = "Blazor Range Slider - Custom Bar",
                MetaDescription = "This Blazor Range Slider custom bar example demonstrates how to style the slider track. Apply gradients, patterns, or segmented designs to the slider bar for visual enhancement."
            },          
                  new Sample
            {
                Name = "Tooltip",
                Category = "Customization",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/custom-tooltip",
                FileName = "CustomTooltip.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Range Slider | Custom Tooltip | Syncfusion",
                HeaderText = "Blazor Range Slider - Custom Tooltip",
                MetaDescription = "This Blazor Range Slider custom tooltip example demonstrates creating enhanced value tooltips. Display rich content in tooltips including formatting, icons, and additional context information."
            },
             new Sample
            {
                Name = "Cloud Pricing",
                Category = "Use Case",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/cloud-pricing",
                FileName = "CloudPricing.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Range Slider | Cloud Pricing Calculator | Syncfusion",
                HeaderText = "Blazor Range Slider - Cloud Pricing Calculator",
                MetaDescription = "This Blazor Range Slider cloud pricing example demonstrates a real-world application with interactive cost calculation. Adjust resource allocations and see dynamic pricing updates."
            },
        };
        public List<Sample> Signature { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Signature",
                Directory = "Inputs/Signature",
                Url = "Signature/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Signature | Digital Signing | Syncfusion",
                HeaderText = "Blazor Signature - Default Functionalities",
                MetaDescription = "This Blazor Signature example demonstrates basic digital signature capture with smooth drawing. Create, save, and clear handwritten signatures with built-in responsive drawing canvas."
            },
             new Sample
             {
                Name = "Toolbar",
                Category = "Signature",
                Directory = "Inputs/Signature",
                Url = "Signature/Toolbar",
                FileName = "Toolbar.razor",
                MetaTitle = "Blazor Signature | Toolbar Options | Syncfusion",
                HeaderText = "Blazor Signature - Toolbar",
                MetaDescription = "This Blazor Signature toolbar example showcases configurable drawing tools. Adjust stroke width, color, and opacity, with options to save, clear, and undo signature strokes."
             }
        };
        public List<Sample> Rating { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Rating | Default Functionalities | Syncfusion",
                HeaderText = "Blazor Rating - Default Functionalities",
                MetaDescription = "This Blazor Rating example demonstrates the basic star rating functionality. Collect user feedback with interactive rating selection, responsive hover effects, and value binding."
            },
            new Sample
            {
                Name = "Precision",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/precision",
                FileName = "Precision.razor",
                MetaTitle = "Blazor Rating | Precision Control | Syncfusion",
                HeaderText = "Blazor Rating - Precision",
                MetaDescription = "This Blazor Rating precision example demonstrates different rating granularity options. Configure full, half, or quarter-step ratings to collect feedback with varying levels of precision."
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/tooltip",
                FileName = "Tooltip.razor",
                MetaTitle = "Blazor Rating | Tooltips | Syncfusion",
                HeaderText = "Blazor Rating - Tooltips",
                MetaDescription = "This Blazor Rating tooltip example shows how to display descriptive text hints for each rating value. Add contextual information to guide users in selecting appropriate ratings."
            },
            new Sample
            {
                Name = "Label",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/label",
                FileName = "Label.razor",
                MetaTitle = "Blazor Rating | Labels | Syncfusion",
                HeaderText = "Blazor Rating - Labels",
                MetaDescription = "This Blazor Rating label example demonstrates adding descriptive text labels to the rating component. Provide context and meaning to rating values with custom label placement and styling."
            },
            new Sample
            {
                Name = "Template",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor Rating | Custom Templates | Syncfusion",
                HeaderText = "Blazor Rating - Custom Templates",
                MetaDescription = "This Blazor Rating template example shows how to customize the rating items' appearance. Replace default stars with custom icons, images, or content for themed rating experiences."
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor Rating | Keyboard Navigation | Syncfusion",
                HeaderText = "Blazor Rating - Keyboard Navigation",
                MetaDescription = "This Blazor Rating keyboard navigation example demonstrates accessibility features. Select ratings using arrow keys and keyboard shortcuts for better accessibility compliance."
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
                MetaTitle = "Blazor OTP Input | One-Time Password | Syncfusion",
                HeaderText = "Blazor OTP Input - Default Functionalities",
                MetaDescription = "This Blazor OTP Input example demonstrates one-time password entry with individual character boxes. Capture verification codes with automatic focus progression and validation feedback."
            },
            new Sample
            {
                Name = "API",
                Category = "OtpInput",
                Directory = "Inputs/OtpInput",
                Url = "otp-input/api",
                FileName = "Api.razor",
                MetaTitle = "Blazor OTP Input | API Options | Syncfusion",
                HeaderText = "Blazor OTP Input - API Functionalities",
                MetaDescription = "This Blazor OTP Input API example showcases programmatic control over the component. Configure input length, character masking, focus behavior, and value handling through code interaction."
            }
        };
        public List<Sample> SpeechToText { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "SpeechToText",
                Directory = "Inputs/SpeechToText",
                Url = "speech-to-text/default-functionalities",
                FileName = "Default.razor",
                MetaTitle = "Speech To Text Default Functionalities - Syncfusion Demos",
                HeaderText = "Blazor Speech To Text - Default Functionalities",
                MetaDescription = "This Blazor Speech To Text example demonstrates voice-to-text conversion with basic configurations. Capture spoken words in real-time with support for multiple languages and dialects."
            },
            new Sample
            {
                Name = "Use Case",
                Category = "Integration",
                Directory = "Inputs/SpeechToText",
                Url = "speech-to-text/use-case",
                FileName = "UseCase.razor",
                MetaTitle = "Blazor Speech To Text | Real-time Transcription | Syncfusion",
                HeaderText = "Blazor Speech To Text - Use Case Scenario",
                MetaDescription = "This Blazor Speech To Text use case demonstrates real-world implementation with user management and message display. Create voice-enabled interfaces for note-taking, dictation, and accessibility."
            },
            new Sample
            {
                Name = "AI AssistView",
                Category = "Integration",
                Directory = "Inputs/SpeechToText",
                Url = "speech-to-text/integration",
                FileName = "Integration.razor",
                MetaTitle = "Blazor Speech To Text | AI Assist Integration | Syncfusion",
                HeaderText = "Blazor Speech To Text - AI AssistView Integration",
                MetaDescription = "This Blazor Speech To Text AI integration example shows how to combine voice input with editable text areas. Create intelligent voice assistants with real-time transcription and text editing capabilities."
            }
        };
    }
}