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
                FileName = "DefaultFunctionalities.cshtml"
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
                FileName = "DefaultFunctionalities.cshtml"
            }
        };

        public List<Sample> MaskedTextBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "MaskedTextBox",
                Directory = "Inputs/MaskedTextBox",
                Url = "MaskedTextBox/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml"
            },
             new Sample
            {
                Name = "Custom Mask",
                Category = "MaskedTextBox",
                Directory = "Inputs/MaskedTextBox",
                Url = "MaskedTextBox/CustomMask",
                FileName = "CustomMask.cshtml"
            }
        };

        public List<Sample> NumericTextBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "NumericTextBox",
                Directory = "Inputs/NumericTextBox",
                Url = "NumericTextBox/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml"
            },
            new Sample
            {
                Name = "Custom Format",
                Category = "NumericTextBox",
                Directory = "Inputs/NumericTextBox",
                Url = "NumericTextBox/CustomFormat",
                FileName = "CustomFormat.cshtml"
            },
            new Sample
            {
                Name = "Restrict Decimals",
                Category = "NumericTextBox",
                Directory = "Inputs/NumericTextBox",
                Url = "NumericTextBox/RestrictDecimals",
                FileName = "RestrictDecimals.cshtml"
            }
        };
        public List<Sample> FileUpload { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "FileUpload",
                Directory = "Inputs/Uploader",
                Url = "Uploader/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml"
            },
             new Sample
            {
                Name = "Chunk Upload",
                Category = "FileUpload",
                Directory = "Inputs/Uploader",
                Url = "Uploader/ChunkUpload",
                FileName = "ChunkUpload.cshtml"
            },
               new Sample
            {
                Name = "File Validation",
                Category = "FileUpload",
                Directory = "Inputs/Uploader",
                Url = "Uploader/FileValidation",
                FileName = "FileValidation.cshtml"
            }
        };
        public List<Sample> Slider { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/Default",
                FileName = "Default.cshtml"
            },
            new Sample
            {
                Name = "Ticks",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/Ticks",
                FileName = "Ticks.cshtml"
            },
        };
    }

   


}
