using System.Collections.Generic;
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
                MetaTitle = "Blazor TextArea Examples - Default | Inputs Demos | Syncfusion",
                HeaderText = "Blazor TextArea - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor TextArea captures multiline input with binding, placeholders, and resize support to simplify user text entry and data handling.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-textarea",
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
                MetaTitle = "Blazor TextArea Examples - Floating Label | Inputs Demos | Syncfusion",
                HeaderText = "Blazor TextArea - Floating Label",
                MetaDescription = "See how the Syncfusion Blazor Floating Label displays animated placeholders with focus transitions and value binding to improve form clarity and usability.",
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
                MetaTitle = "Blazor TextArea Examples - Resize | Inputs Demos | Syncfusion",
                HeaderText = "Blazor TextArea - Resize",
                MetaDescription = "See how the Syncfusion Blazor Resize adjusts textarea dimensions with horizontal, vertical, and both modes to fit content and enhance input flexibility.",
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
                MetaTitle = "Blazor TextArea Examples - Validation | Inputs Demos | Syncfusion",
                HeaderText = "Blazor TextArea - Validation",
                MetaDescription = "See how the Syncfusion Blazor TextArea validates input with rules and error messages to ensure accurate and reliable text entry in forms easily and clearly.",
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
                MetaTitle = "Blazor TextArea Demos - API Examples | Inputs Demos | Syncfusion",
                HeaderText = "Blazor TextArea - API",
                MetaDescription = "See how the Syncfusion Blazor TextArea controls rows, columns, max length, enable/disable, read-only, and clear button dynamically for adaptive form behavior.",
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
                MetaTitle = "Blazor TextBox Examples - Default | Inputs Demos | Syncfusion",
                HeaderText = "Blazor TextBox - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Default Functionalities captures text input with placeholders, floating labels, and binding to simplify user data entry.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-textbox"
            },
            new Sample
            {
                Name = "Multiline TextBox",
                Category = "TextBox",
                Directory = "Inputs/TextBox",
                Url = "TextBox/Multiline-TextBox",
                FileName = "Multiline.razor",
                MetaTitle = "Blazor TextBox - Multiline TextBox | Inputs Demos | Syncfusion",
                HeaderText = "Blazor TextBox - Multiline Input",
                MetaDescription = "See how the Syncfusion Blazor Multiline TextBox supports multi-line input with auto resize and layout control for handling longer content efficiently."
            },
            new Sample
            {
                Name = "Validation",
                Category = "TextBox",
                Directory = "Inputs/TextBox",
                Url = "TextBox/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor TextBox Examples - Validation | Inputs Demos | Syncfusion",
                HeaderText = "Blazor TextBox - Form Validation",
                MetaDescription = "See how the Syncfusion Blazor TextBox applies rules, patterns, and custom checks to ensure accurate text input and improve overall form reliability easily."
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
                MetaTitle = "Blazor Color Picker Examples - Default | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Color Picker - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Default Functionalities selects colors using RGB, HSV, and HEX models with palettes and preview for accurate color choice.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-color-picker"
            },
            new Sample
            {
                Name = "Inline Mode",
                Category = "Color Picker",
                Directory = "Inputs/ColorPicker",
                Url = "color-picker/inline",
                FileName = "Inline.razor",
                MetaTitle = "Blazor Color Picker Demos - Inline Mode Examples | Syncfusion",
                HeaderText = "Blazor Color Picker - Inline Mode",
                MetaDescription = "See how the Syncfusion Blazor ColorPicker embeds color selection inline with palettes, sliders, and live preview directly in page layouts for immediate access."
            },
            new Sample
            {
                Name = "Custom Palettes",
                Category = "Color Picker",
                Directory = "Inputs/ColorPicker",
                Url = "color-picker/custom",
                FileName = "Custom.razor",
                MetaTitle = "Blazor Color Picker - Custom Palettes | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Color Picker - Custom Color Palettes",
                MetaDescription = "See how the Syncfusion Blazor ColorPicker defines preset color sets with reusable options to ensure consistent theme selection across applications easily."
            },
            new Sample
            {
                Name = "API",
                Category = "Color Picker",
                Directory = "Inputs/ColorPicker",
                Url = "color-picker/api",
                FileName = "Api.razor",
                MetaTitle = "Blazor Color Picker Examples - API | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Color Picker - API Functionalities",
                MetaDescription = "See how the Syncfusion Blazor ColorPicker API updates color values, modes and UI states dynamically to control picker behavior programmatically and efficiently."
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Color Picker",
                Directory = "Inputs/ColorPicker",
                Url = "color-picker/keyboard-navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor Color Picker - Keyboard Navigation | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Color Picker - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor ColorPicker enables full keyboard control so users can browse, adjust, and select colors using shortcuts for better accessibility."
            },
            new Sample
            {
                Name = "Color Palettes",
                Category = "Color Picker",
                Directory = "Inputs/ColorPicker",
                Url = "color-picker/palette",
                FileName = "Inline.razor",
                MetaTitle = "Blazor Color Picker - Color Palettes | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Color Palttes - Inline Mode",
                MetaDescription = "See how the Syncfusion Blazor ColorPicker displays predefined and custom palettes with inline selection to simplify color picking and improve clarity."
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
                MetaTitle = "Blazor Input Mask Examples - Default | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Input Mask - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor InputMask formats inputs for phone, zip, and IDs with validation rules to ensure accurate and consistent user data entry.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-input-mask"
            },
             new Sample
            {
                Name = "Custom Mask",
                Category = "Input Mask",
                Directory = "Inputs/MaskedTextBox",
                Url = "Input-Mask/Custom-Mask",
                FileName = "CustomMask.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Input Mask Examples - Custom Mask | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Input Mask - Custom Mask Patterns",
                MetaDescription = "See how the Syncfusion Blazor InputMask defines custom input patterns with validation rules to support specialized formats and ensure precise data entry."
            },
              new Sample
            {
                Name = "Literals and Prompt",
                Category = "Input Mask",
                Directory = "Inputs/MaskedTextBox",
                Url = "Input-Mask/Literals-And-Prompt",
                FileName = "LiteralsAndPrompt.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Input Mask - Literals and Prompt| Inputs Demos | Syncfusion",
                HeaderText = "Blazor Input Mask - Literals and Prompt Characters",
                MetaDescription = "See how the Syncfusion Blazor InputMask displays guide characters and prompt symbols to help users enter correctly formatted input with clarity and consistency."
            },
              new Sample
            {
                Name = "Validation",
                Category = "Input Mask",
                Directory = "Inputs/MaskedTextBox",
                Url = "Input-Mask/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor Input Mask Examples - Validation | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Input Mask - Form Validation Integration",
                MetaDescription = "See how the Syncfusion Blazor InputMask enforces input rules with validation and error handling to ensure formatted data is accurate and acceptable easily."
            }
        };

        public List<Sample> NumericTextbox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Default-Functionalities",
                MetaTitle = "Blazor NumericTextbox Examples - Default | Inputs Demos | Syncfusion",
                FileName = "DefaultFunctionalities.razor",
                HeaderText = "Blazor Numeric TextBox - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Default Functionalities handles numeric input with increment controls, validation, and value binding for precise data entry.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-numeric-textbox"
            },
            new Sample
            {
                Name = "Custom Format",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Custom-Format",
                FileName = "CustomFormat.razor",
                MetaTitle = "Blazor NumericTextbox - Custom Format | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Numeric TextBox - Custom Format",
                MetaDescription = "See how the Syncfusion Blazor NumericTextBox displays currency, percentage, and custom formats to improve numeric readability and clarity in form inputs."
            },
            new Sample
            {
                Name = "Restrict Decimals",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Restrict-Decimals",
                FileName = "RestrictDecimals.razor",
                MetaTitle = "Blazor NumericTextbox - Restrict Decimals | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Numeric TextBox - Restrict Decimals",
                MetaDescription = "See how the Syncfusion Blazor NumericTextBox limits decimal precision using configurable settings to ensure accurate and consistent numeric input values."
            },
            new Sample
            {
                Name = "Range Validation",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Range-Validation",
                FileName = "RangeValidation.razor",
                MetaTitle = "Blazor NumericTextbox - Range Validation | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Numeric TextBox - Range Validation",
                MetaDescription = "See how the Syncfusion Blazor NumericTextBox enforces value limits with validation rules to maintain valid numeric ranges and prevent incorrect input."
            },
            new Sample
            {
                Name = "Validation",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor NumericTextbox - Validation | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Numeric TextBox - Form Validation",
                MetaDescription = "See how the Syncfusion Blazor NumericTextBox applies validation rules to ensure accurate numeric input and improve overall data integrity in forms easily."
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Numeric Textbox",
                Directory = "Inputs/NumericTextBox",
                Url = "Numeric-TextBox/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.None,
                MetaTitle = "lazor NumericTextbox - Keyboard Navigation | Inputs Demo | Syncfusion",
                HeaderText = "Blazor Numeric TextBox - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor NumericTextBox supports keyboard shortcuts and arrow keys to adjust values and improve accessibility and input controls."
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
                MetaTitle = "Blazor File Upload Examples - Default | Inputs Demos | Syncfusion",
                HeaderText = "Blazor File Upload Example of default functionalities",
                MetaDescription = "See how the Syncfusion Blazor Default Functionalities uploads files with progress tracking, multi-file support, and controls to manage file operations easily.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-upload"
            },
             new Sample
            {
                Name = "Chunk Upload",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/Chunk-Upload",
                FileName = "ChunkUpload.razor",
                MetaTitle = "Blazor File Upload Demos - Chunk Upload Examples | Syncfusion",
                HeaderText = "Blazor File Upload - Chunk Upload",
                MetaDescription = "See how the Syncfusion Blazor FileUpload handles large files with chunked upload, pause, resume, and retry to maximize upload reliability and performance."
            },
               new Sample
            {
                Name = "Preload Files",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/Preload-Files",
                FileName = "PreloadFiles.razor",
                MetaTitle = "Blazor File Upload - Preload Files | Inputs Demos | Syncfusion",
                HeaderText = "Blazor File Upload - Preload Files",
                MetaDescription = "See how the Syncfusion Blazor FileUpload displays existing uploaded files with preview and management options to improve file handling and control easily."
            },
               new Sample
            {
                Name = "File Validation",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/File-Validation",
                FileName = "FileValidation.razor",
                MetaTitle = "Blazor File Upload - File Validation | Inputs Demos | Syncfusion",
                HeaderText = "Blazor File Upload - File Validation",
                MetaDescription = "See how the Syncfusion Blazor FileUpload validates file type, size, and count with error messages to ensure only secure and valid uploads are accepted."
            },
               new Sample
            {
                Name = "Custom Drop Area",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/Custom-DropArea",
                FileName = "CustomDropArea.razor",
                MetaTitle = "Blazor File Upload - Custom Drop Area | Inputs Demos | Syncfusion",
                HeaderText = "Blazor File Upload - Custom Drop Area",
                MetaDescription = "See how the Syncfusion Blazor FileUpload creates custom drag and drop areas with styled UI to improve user experience and simplify file uploads easily."
            },
                new Sample
            {
                Name = "Keyboard Navigation",
                Category = "File Upload",
                Directory = "Inputs/Uploader",
                Url = "File-Upload/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor File Upload - Keyboard Navigation | Inputs Demos | Syncfusion",
                HeaderText = "Blazor File Upload - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor FileUpload supports keyboard navigation to manage file selection and upload actions efficiently and improve accessibility."
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
                MetaTitle = "Blazor Range Slider Demos - Default Functionalities | Syncfusion",
                HeaderText = "Blazor Range Slider - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor RangeSlider selects values with drag handles and range selection to support accurate and flexible numeric input operations.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-range-slider"
            },
            new Sample
            {
                Name = "Ticks",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/ticks",
                FileName = "Ticks.razor",
                MetaTitle = "Blazor Range Slider Examples - Ticks | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Range Slider - Tick Marks",
                MetaDescription = "See how the Syncfusion Blazor RangeSlider displays major and minor tick markers with labels to indicate values clearly and improve overall slider usability."
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/tooltip",
                FileName = "Tooltip.razor",
                MetaTitle = "Blazor Range Slider Examples - Tooltip | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Range Slider - Tooltips",
                MetaDescription = "See how the Syncfusion Blazor RangeSlider shows value details during interaction with formatting options to improve visibility and provide clear feedback."
            },
            new Sample
            {
                Name = "Vertical Orientation",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/vertical-orientation",
                FileName = "VerticalOrientation.razor",
                Type= SampleType.None,
                MetaTitle = "Blazor Range Slider Demos - Vertical Orientation | Syncfusion",
                HeaderText = "Blazor Range Slider - Vertical Orientation",
                MetaDescription = "See how the Syncfusion Blazor RangeSlider displays sliders vertically to save space and support compact layouts for modern application user interfaces."
            },
             new Sample
            {
                Name = "Formatting",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/formatting",
                FileName = "Formatting.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Range Slider Examples - Formatting | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Range Slider - Value Formatting",
                MetaDescription = "See how the Syncfusion Blazor RangeSlider applies custom formats like currency and percentage to display values clearly and improve readability in user inputs."
            },
            new Sample
            {
                Name = "Limits",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/limits",
                FileName = "Limits.razor",
                MetaTitle = "Blazor Range Slider Examples - Limits | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Range Slider - Range Limits",
                MetaDescription = "See how the Syncfusion Blazor RangeSlider enforces minimum and maximum selectable ranges with span constraints to restrict value selection to valid boundaries."
            },
            new Sample
            {
                Name = "API",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/api",
                FileName = "API.razor",
                MetaTitle = "Blazor Range Slider Examples - API | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Range Slider - API Functionalities",
                MetaDescription = "See how the Syncfusion Blazor RangeSlider API updates values and ranges dynamically to control slider behavior and enable interactive and responsive UI feature."
            },
            new Sample
            {
                Name = "Events",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/events",
                FileName = "Events.razor",
                MetaTitle = "Blazor Range Slider Examples - Events | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Range Slider - Events",
                MetaDescription = "See how the Syncfusion Blazor RangeSlider handles value changes and drag actions using events to build interactive and dynamic slider behavior efficiently."
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Range Slider",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/keyboard-navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Range Slider - Keyboard Navigation | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Range Slider - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor RangeSlider enables precise value control using keyboard shortcuts and arrow keys to improve accessibility and input efficiency."
            },
            new Sample
            {
                Name = "Thumb",
                Category = "Customization",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/custom-thumb",
                FileName = "CustomThumb.razor",
                MetaTitle = "Blazor Range Slider Examples - Thumb | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Range Slider - Custom Thumb",
                MetaDescription = "See how the Syncfusion Blazor RangeSlider customizes slider thumbs with icons and templates to create unique and visually engaging input designs easily."
            },
            new Sample
            {
                Name = "Bar",
                Category = "Customization",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/custom-bar",
                FileName = "CustomBar.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Range Slider Examples - Bar | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Range Slider - Custom Bar",
                MetaDescription = "See how the Syncfusion Blazor RangeSlider styles slider tracks with colors and gradients to enhance visual clarity and improve overall user experience."
            },          
                  new Sample
            {
                Name = "Tooltip",
                Category = "Customization",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/custom-tooltip",
                FileName = "CustomTooltip.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Range Slider Demo - Custom Tooltip | Inputs Demo | Syncfusion",
                HeaderText = "Blazor Range Slider - Custom Tooltip",
                MetaDescription = "See how the Syncfusion Blazor RangeSlider customizes tooltip content with formatting and icons to enhance interaction feedback and improve usability clearly."
            },
             new Sample
            {
                Name = "Cloud Pricing",
                Category = "Use Case",
                Directory = "Inputs/RangeSlider",
                Url = "range-slider/cloud-pricing",
                FileName = "CloudPricing.razor",
                Type = SampleType.None,
                MetaTitle = "Blazor Use Case Examples - Cloud Pricing | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Range Slider - Cloud Pricing Calculator",
                MetaDescription = "See how the Syncfusion Blazor RangeSlider calculates pricing dynamically using slider input updates to visualize cost variations and pricing scenarios clearly."
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
                MetaTitle = "Blazor Signature Examples - Default | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Signature - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Signature captures digital signatures with drawing tools, save and clear options to manage user input and improve usability.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-signature"
            },
             new Sample
             {
                Name = "Toolbar",
                Category = "Signature",
                Directory = "Inputs/Signature",
                Url = "Signature/Toolbar",
                FileName = "Toolbar.razor",
                MetaTitle = "Blazor Signature Examples - Toolbar | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Signature - Toolbar",
                MetaDescription = "See how the Syncfusion Blazor Signature toolbar controls stroke width, color, and actions to improve drawing precision and enhance signature creation clarity."
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
                MetaTitle = "Blazor Rating Examples - Default | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Rating - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Rating collects user feedback with interactive stars, hover effects, and data binding to support accurate and easy rating input.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-rating"
            },
            new Sample
            {
                Name = "Precision",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/precision",
                FileName = "Precision.razor",
                MetaTitle = "Blazor Rating Examples - Precision | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Rating - Precision",
                MetaDescription = "See how the Syncfusion Blazor Rating supports fractional and half ratings with precision settings to collect detailed and accurate user feedback values easily."
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/tooltip",
                FileName = "Tooltip.razor",
                MetaTitle = "Blazor Rating Examples - Tooltip | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Rating - Tooltips",
                MetaDescription = "See how the Syncfusion Blazor Rating displays tooltip hints with text labels to guide users during selection and improve clarity in rating interactions."
            },
            new Sample
            {
                Name = "Label",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/label",
                FileName = "Label.razor",
                MetaTitle = "Blazor Rating Demos - Label Examples | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Rating - Labels",
                MetaDescription = "See how the Syncfusion Blazor Rating shows descriptive labels with values to provide better context and improve clarity in rating display and user interaction."
            },
            new Sample
            {
                Name = "Template",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor Rating Examples - Template | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Rating - Custom Templates",
                MetaDescription = "See how the Syncfusion Blazor Rating uses templates to customize icons with images and styles to create branded and visually rich feedback experiences easily."
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Rating",
                Directory = "Inputs/Rating",
                Url = "rating/navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor Rating - Keyboard Navigation | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Rating - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor Rating supports keyboard navigation with keys and focus control to enable accessible and efficient rating interaction easily."
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
                MetaTitle = "Blazor OTP Input Examples - Default | Inputs Demos | Syncfusion",
                HeaderText = "Blazor OTP Input - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor OtpInput enables secure OTP entry with auto focus, validation support, and input fields to simplify user verification processes.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-otp-input"
            },
            new Sample
            {
                Name = "API",
                Category = "OtpInput",
                Directory = "Inputs/OtpInput",
                Url = "otp-input/api",
                FileName = "Api.razor",
                MetaTitle = "Blazor OTP Input Demos - API Examples | Inputs Demos | Syncfusion",
                HeaderText = "Blazor OTP Input - API Functionalities",
                MetaDescription = "See how the Syncfusion Blazor OtpInput API controls length, masking, and focus behavior to manage secure OTP input and improve validation handling easily."
            }
        };
        public List<Sample> SpeechToText { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Speech To Text",
                Directory = "Inputs/SpeechToText",
                Url = "speech-to-text/default-functionalities",
                FileName = "Default.razor",
                MetaTitle = "Blazor SpeechToText Examples - Default | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Speech To Text - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Default Functionalities converts speech to text with real time processing and multilingual support to enhance input methods.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-speech-to-text"
            },
            new Sample
            {
                Name = "Use Case",
                Category = "Integration",
                Directory = "Inputs/SpeechToText",
                Url = "speech-to-text/use-case",
                FileName = "UseCase.razor",
                MetaTitle = "Blazor SpeechToText Examples - Use Case | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Speech To Text - Use Case Scenario",
                MetaDescription = "See how the Syncfusion Blazor Speech To Text builds voice enabled apps with transcription, messaging, and interaction features to improve productivity easily."
            },
            new Sample
            {
                Name = "AI AssistView",
                Category = "Integration",
                Directory = "Inputs/SpeechToText",
                Url = "speech-to-text/integration",
                FileName = "Integration.razor",
                MetaTitle = "Blazor SpeechToText - AI AssistView | Inputs Demos | Syncfusion",
                HeaderText = "Blazor Speech To Text - AI AssistView Integration",
                MetaDescription = "See how the Syncfusion Blazor Speech To Text integrates voice input with editable text and suggestions to create intelligent assistant experiences easily."
            }
        };
    }
}