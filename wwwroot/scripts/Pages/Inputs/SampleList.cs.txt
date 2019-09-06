using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> TextBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "TextBox",
                Directory = "Inputs/TextBox",
                Url = "TextBox/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Multiline TextBox",
                Category = "TextBox",
                Directory = "Inputs/TextBox",
                Url = "TextBox/Multiline",
                FileName = "Multiline.razor"
            }
        };

        public List<Sample> ColorPicker { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "ColorPicker",
                Directory = "Inputs/ColorPicker",
                Url = "ColorPicker/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Inline Mode",
                Category = "ColorPicker",
                Directory = "Inputs/ColorPicker",
                Url = "ColorPicker/Inline",
                FileName = "Inline.razor"
            },
            new Sample
            {
                Name = "Custom Palettes",
                Category = "ColorPicker",
                Directory = "Inputs/ColorPicker",
                Url = "ColorPicker/Custom",
                FileName = "Custom.razor"
            },
            new Sample
            {
                Name = "API",
                Category = "ColorPicker",
                Directory = "Inputs/ColorPicker",
                Url = "ColorPicker/Api",
                FileName = "Api.razor"
            }
        };

        public List<Sample> MaskedTextBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "MaskedTextBox",
                Directory = "Inputs/MaskedTextBox",
                Url = "MaskedTextBox/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor"
            },
             new Sample
            {
                Name = "Custom Mask",
                Category = "MaskedTextBox",
                Directory = "Inputs/MaskedTextBox",
                Url = "MaskedTextBox/CustomMask",
                FileName = "CustomMask.razor"
            }
        };

        public List<Sample> NumericTextBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "NumericTextBox",
                Directory = "Inputs/NumericTextBox",
                Url = "NumericTextBox/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Custom Format",
                Category = "NumericTextBox",
                Directory = "Inputs/NumericTextBox",
                Url = "NumericTextBox/CustomFormat",
                FileName = "CustomFormat.razor"
            },
            new Sample
            {
                Name = "Restrict Decimals",
                Category = "NumericTextBox",
                Directory = "Inputs/NumericTextBox",
                Url = "NumericTextBox/RestrictDecimals",
                FileName = "RestrictDecimals.razor"
            },
            new Sample
            {
                Name = "Range Validation",
                Category = "NumericTextBox",
                Directory = "Inputs/NumericTextBox",
                Url = "NumericTextBox/RangeValidation",
                FileName = "RangeValidation.razor"
            }
        };
        public List<Sample> FileUpload { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "FileUpload",
                Directory = "Inputs/Uploader",
                Url = "Uploader/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor"
            },
             new Sample
            {
                Name = "Chunk Upload",
                Category = "FileUpload",
                Directory = "Inputs/Uploader",
                Url = "Uploader/ChunkUpload",
                FileName = "ChunkUpload.razor"
            },
               new Sample
            {
                Name = "Preload Files",
                Category = "FileUpload",
                Directory = "Inputs/Uploader",
                Url = "Uploader/PreloadFiles",
                FileName = "PreloadFiles.razor"
            },
               new Sample
            {
                Name = "File Validation",
                Category = "FileUpload",
                Directory = "Inputs/Uploader",
                Url = "Uploader/FileValidation",
                FileName = "FileValidation.razor"
            }
        };
        public List<Sample> Slider { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/Default",
                FileName = "Default.razor"
            },
            new Sample
            {
                Name = "Ticks",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/Ticks",
                FileName = "Ticks.razor"
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/Tooltip",
                FileName = "Tooltip.razor"
            },
            new Sample
            {
                Name = "Vertical Orientation",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/VerticalOrientation",
                FileName = "VerticalOrientation.razor"
            },
            new Sample
            {
                Name = "Limits",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/Limits",
                FileName = "Limits.razor"
            },
            new Sample
            {
                Name = "API",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/API",
                FileName = "API.razor"
            },
            new Sample
            {
                Name = "Events",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/Events",
                FileName = "Events.razor"
            },
            new Sample
            {
                Name = "Thumb",
                Category = "Customization",
                Directory = "Inputs/Slider",
                Url = "Slider/CustomThumb",
                FileName = "CustomThumb.razor"
            },
            new Sample
            {
                Name = "Bar",
                Category = "Customization",
                Directory = "Inputs/Slider",
                Url = "Slider/CustomBar",
                FileName = "CustomBar.razor"
            },
        };
    }

   


}
