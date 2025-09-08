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
                MetaDescription = "This Blazor TextArea example shows the rendering of the TextArea component using a default functionalities. It allows users to input multiple lines of text.",
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
                MetaDescription = "This example shows the floating label functionality of TextArea control. The placeholder text while the user enters text/focus on textarea element with a value.",
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
                MetaTitle = "Blazor TextArea Example | Resize | Syncfusion Demos",
                HeaderText = "Blazor TextArea - Resize",
                MetaDescription = "This Blazor TextArea demo shows how to adjust the size of TextArea dynamically using ResizeMode property such as Both, Vertical, Horizontal, or None options.",
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
                MetaTitle = "Blazor TextArea Example | Validation | Syncfusion Demos",
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
                MetaTitle = "Blazor TextArea Example | API Feature | Syncfusion Demos",
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
                MetaDescription = "Blazor TextBox demo shows the default functionalities including basic text input, placeholder support, floating labels, value binding in a responsive interface."
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
                MetaDescription = "Blazor TextBox demo shows multiline text input functionality. It adapts to display multiple lines of text with custom rows, columns, auto-resize capabilities."
            },
            new Sample
            {
                Name = "Validation",
                Category = "TextBox",
                Directory = "Inputs/TextBox",
                Url = "TextBox/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor TextBox Example | Form Validation | Syncfusion",
                HeaderText = "Blazor TextBox - Form Validation",
                MetaDescription = "Blazor TextBox validation demo shows how to integrate with forms validation. Built-in validators for required fields, pattern matching, custom validation rules."
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
                MetaDescription = "Blazor Color Picker demo shows default color selection capabilities with RGB, HSV, Hex color models. It include color palettes, opacity control, live preview."
            },
            new Sample
            {
                Name = "Inline Mode",
                Category = "Color Picker",
                Directory = "Inputs/ColorPicker",
                Url = "color-picker/inline",
                FileName = "Inline.razor",
                MetaTitle = "Blazor Color Picker Example | Inline Mode | Syncfusion",
                HeaderText = "Blazor Color Picker - Inline Mode",
                MetaDescription = "Blazor Color Picker inline mode demo shows embedding color selection interface directly into page layout without a popup, allowing access to all color options."
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
                MetaDescription = "Blazor ColorPicker custom palettes demo shows how to define and use custom color collections.Create color themes/predefined color sets for consistent selection."
            },
            new Sample
            {
                Name = "API",
                Category = "Color Picker",
                Directory = "Inputs/ColorPicker",
                Url = "color-picker/api",
                FileName = "Api.razor",
                MetaTitle = "Blazor Color Picker Example | API Options | Syncfusion",
                HeaderText = "Blazor Color Picker - API Functionalities",
                MetaDescription = "Blazor Color Picker API demo shows programmatic control over the contorl. Dynamically change modes, toggle features, set colors, control the interface via code."
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
                MetaDescription = "This Blazor Color Picker keyboard navigation example demonstrates how to use browse color options, adjust values, and select colors using keyboard shortcuts."
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
                MetaDescription = "This Blazor Input Mask demo shows standard mask formats including phone numbers, social security numbers, and zip codes with automatic formatting as users type."
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
                MetaDescription = "Blazor InputMask custom pattern demo shows creating specialized input formats with custom rules. Define precise data entry pattern for unique information types."
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
                MetaDescription = "Blazor InputMask demo shows how to configure literal characters and prompt symbols. Customize visual indicators that guide users via proper data entry format."
            },
              new Sample
            {
                Name = "Validation",
                Category = "Input Mask",
                Directory = "Inputs/MaskedTextBox",
                Url = "Input-Mask/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor Input Mask Example | Form Validation | Syncfusion",
                HeaderText = "Blazor Input Mask - Form Validation Integration",
                MetaDescription = "Blazor InputMask validation demo shows integration with forms validation. Ensure formatted input with built-in validation features for masked data entry fields."
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
                MetaDescription = "Blazor Numeric TextBox demo shows the features including value binding, increment/decrement buttons, numeric input validation with configurable step values."
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
                MetaDescription = "This Blazor Numeric TextBox formatting demo shows how to customize the display of numeric values with currency symbols, percentages, and custom number formats."
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
                MetaDescription = "Blazor NumericTextBox decimal precision demo shows how to control and limit decimal places in input. Configure exact decimal precision for different data types."
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
                MetaDescription = "This Blazor Numeric TextBox range validation demo shows setting minimum and maximum value constraints. Ensure numeric input falls within acceptable boundaries."
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
                MetaDescription = "Blazor Numeric TextBox validation demo shows integration with form validation. Implement required field validation, range checking, and custom validation rules."
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
                MetaDescription = "This Blazor Numeric TextBox example shows accessibility features for keyboard users. Control and edit numeric values using arrow keys and keyboard shortcuts."
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
                MetaDescription = "This Blazor File Upload demo shows how to include file selection, progress tracking, upload/cancel operations. Handle single/multiple file uploads with UI."
            },
             new Sample
            {
                Name = "Chunk Upload",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/Chunk-Upload",
                FileName = "ChunkUpload.razor",
                MetaTitle = "Blazor File Upload Example | Chunk Upload | Syncfusion",
                HeaderText = "Blazor File Upload - Chunk Upload",
                MetaDescription = "This demo shows chunk upload functionalities of the File Upload component. Browse or drag-and-drop a large file to upload with pause, resume, and retry options."
            },
               new Sample
            {
                Name = "Preload Files",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/Preload-Files",
                FileName = "PreloadFiles.razor",
                MetaTitle = "Blazor File Upload Example | Preload Files | Syncfusion",
                HeaderText = "Blazor File Upload - Preload Files",
                MetaDescription = "Blazor File Upload preload demo shows displaying existing uploaded files with view, download, remove options while maintaining the ability to upload new files."
            },
               new Sample
            {
                Name = "File Validation",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/File-Validation",
                FileName = "FileValidation.razor",
                MetaTitle = "Blazor File Upload Example | File Validation | Syncfusion",
                HeaderText = "Blazor File Upload - File Validation",
                MetaDescription = "Blazor FileUpload validation demo shows how to validate files before upload. Set restriction for file types, size limits, count with appropriate error messages."
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
                MetaDescription = "Blazor FileUpload custom drop area demo shows how to create a personalized drag-and-drop zone. Design intuitive file drop region with custom style and behavior."
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
                MetaDescription = "Blazor FileUpload keyboard navigation demo shows accessibility features.Navigate through upload controls, select files, manage uploads using keyboard shortcuts."
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
                MetaDescription = "Blazor RangeSlider demo shows basic slider functionality with single and range selection modes. Easily select numeric values with an intuitive drag interface."
            },
            new Sample
            {
                Name = "Ticks",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/ticks",
                FileName = "Ticks.razor",
                MetaTitle = "Blazor Range Slider Example | Tick Marks | Syncfusion",
                HeaderText = "Blazor Range Slider - Tick Marks",
                MetaDescription = "Blazor Range Slider ticks demo shows customizable visual reference. Configure major and minor ticks with labels to indicate value positions along the slider."
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/tooltip",
                FileName = "Tooltip.razor",
                MetaTitle = "Blazor Range Slider Example | Tooltips | Syncfusion",
                HeaderText = "Blazor Range Slider - Tooltips",
                MetaDescription = "Blazor Range Slider tooltip example shows value tooltips during user interaction. Customize tooltip position, format, behavior to enhance value visualization."
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
                MetaDescription = "Blazor RangeSlider vertical orientation demo shows top-to-bottom slider layout. Implement space-efficient vertical sliders with features of horizontal slider."
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
                MetaDescription = "Blazor Range Slider formatting demo shows custom value display formats. Apply currency, percentage/custom formats to slider values, tooltips for representation."
            },
            new Sample
            {
                Name = "Limits",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/limits",
                FileName = "Limits.razor",
                MetaTitle = "Blazor Range Slider Example | Range Limits | Syncfusion",
                HeaderText = "Blazor Range Slider - Range Limits",
                MetaDescription = "Blazor RangeSlider limits demo shows setting constraint on selectable ranges. Define minimum and maximum selectable value, enforced limit, minimum range spans."
            },
            new Sample
            {
                Name = "API",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/api",
                FileName = "API.razor",
                MetaTitle = "Blazor Range Slider Example | API Options | Syncfusion",
                HeaderText = "Blazor Range Slider - API Functionalities",
                MetaDescription = "Blazor Range Slider API demo shows programmatic control over the component. Dynamically change values, ranges, steps, other properties through code interaction."
            },
            new Sample
            {
                Name = "Events",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/events",
                FileName = "Events.razor",
                MetaTitle = "Blazor Range Slider Example | Handle Events | Syncfusion",
                HeaderText = "Blazor Range Slider - Events",
                MetaDescription = "Blazor RangeSlider events demo shows handling more user interactions.Respond to value changes, drag start/end events, user selection with custom event handlers."
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
                MetaDescription = "This Blazor Range Slider keyboard navigation example shows accessibility features. Control slider values precisely using arrow keys and keyboard shortcuts."
            },
            new Sample
            {
                Name = "Thumb",
                Category = "Customization",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/custom-thumb",
                FileName = "CustomThumb.razor",
                MetaTitle = "Blazor Range Slider Example | Custom Thumb | Syncfusion",
                HeaderText = "Blazor Range Slider - Custom Thumb",
                MetaDescription = "This Blazor Range Slider custom thumb example shows how to replace default thumbs with custom designs, icons, or elements for unique slider appearance."
            },
            new Sample
            {
                Name = "Bar",
                Category = "Customization",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/custom-bar",
                FileName = "CustomBar.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Range Slider Example | Custom Bar | Syncfusion",
                HeaderText = "Blazor Range Slider - Custom Bar",
                MetaDescription = "Blazor Range Slider custom bar demo shows how to style the slider track. Apply gradients, patterns/segmented designs to the slider bar for visual enhancement."
            },          
                  new Sample
            {
                Name = "Tooltip",
                Category = "Customization",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/custom-tooltip",
                FileName = "CustomTooltip.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Range Slider Example | Custom Tooltip | Syncfusion",
                HeaderText = "Blazor Range Slider - Custom Tooltip",
                MetaDescription = "This Blazor Range Slider custom tooltip example shows how to display rich content in tooltips including formatting, icons, and additional context information."
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
                MetaDescription = "Blazor RangeSlider cloud pricing demo shows a real-world application with interactive cost calculation. Adjust resource allocation and dynamic pricing update."
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
                MetaTitle = "Blazor Signature Example | Digital Signing | Syncfusion",
                HeaderText = "Blazor Signature - Default Functionalities",
                MetaDescription = "This Blazor Signature example demonstrates basic digital signature capture with smooth drawing. Users can create, save, and clear handwritten signatures."
            },
             new Sample
             {
                Name = "Toolbar",
                Category = "Signature",
                Directory = "Inputs/Signature",
                Url = "Signature/Toolbar",
                FileName = "Toolbar.razor",
                MetaTitle = "Blazor Signature Example | Toolbar Options | Syncfusion",
                HeaderText = "Blazor Signature - Toolbar",
                MetaDescription = "Blazor Signature toolbar demo shows configurable drawing tools. Adjust stroke width, color, and opacity, with options to save, clear, undo signature strokes."
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
                MetaDescription = "Blazor Rating demo shows the basic star rating functionality. Collect user feedback with interactive rating selection, responsive hover effects, value binding."
            },
            new Sample
            {
                Name = "Precision",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/precision",
                FileName = "Precision.razor",
                MetaTitle = "Blazor Rating Example | Precision Control | Syncfusion",
                HeaderText = "Blazor Rating - Precision",
                MetaDescription = "Blazor Rating precision demo shows different rating granularity options. Configure full, half, or quarter-step ratings to collect feedback with varying levels."
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/tooltip",
                FileName = "Tooltip.razor",
                MetaTitle = "Blazor Rating Example | Display Tooltip | Syncfusion",
                HeaderText = "Blazor Rating - Tooltips",
                MetaDescription = "Blazor Rating tooltip example shows how to display text hints for each rating value. Add contextual information to guide users in selecting appropriate ratings."
            },
            new Sample
            {
                Name = "Label",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/label",
                FileName = "Label.razor",
                MetaTitle = "Blazor Rating Example | Text Label Options | Syncfusion",
                HeaderText = "Blazor Rating - Labels",
                MetaDescription = "Blazor Rating label demo shows adding text labels to the rating component. Provide context and meaning to rating values with custom label placement and styling."
            },
            new Sample
            {
                Name = "Template",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor Rating Example | Custom Templates | Syncfusion",
                HeaderText = "Blazor Rating - Custom Templates",
                MetaDescription = "This Blazor Rating demo shows how to customize the rating items appearance. Replace default stars with custom icon, image/content for themed rating experiences."
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor Rating Example | Keyboard Navigation | Syncfusion",
                HeaderText = "Blazor Rating - Keyboard Navigation",
                MetaDescription = "Blazor Rating keyboard navigation demo shows accessibility features. Select ratings using arrow keys and keyboard shortcuts for better accessibility compliance."
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
                MetaTitle = "Blazor OTP Input Example | One-Time Password | Syncfusion",
                HeaderText = "Blazor OTP Input - Default Functionalities",
                MetaDescription = "This Blazor OTP Input demo shows OTP entry with individual character boxes. Capture verification codes with automatic focus progression, validation feedback."
            },
            new Sample
            {
                Name = "API",
                Category = "OtpInput",
                Directory = "Inputs/OtpInput",
                Url = "otp-input/api",
                FileName = "Api.razor",
                MetaTitle = "Blazor OTP Input Example | API Options | Syncfusion",
                HeaderText = "Blazor OTP Input - API Functionalities",
                MetaDescription = "Blazor OTP Input demo shows programmatic control over the component. Configure length, character masking, focus behavior, value handling via code interaction."
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
                MetaDescription = "Blazor SpeechToText demo shows voice-to-text conversion with basic configuration.Capture spoken words in real-time with support for multiple languages, dialect."
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
                MetaDescription = "This use case shows real-world implementation with user management, message display. Create voice-enabled interfaces for note-taking, dictation, accessibility."
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
                MetaDescription = "This Blazor Speech To Text AI demo shows how to combine voice input with editable text areas. Create intelligent voice assistant with real-time transcription."
            }
        };
    }
}