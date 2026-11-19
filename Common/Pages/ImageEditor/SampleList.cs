using System.Collections.Generic;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> ImageEditor { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Image Editor",
                Directory = "ImageEditor/ImageEditor",
                Url = "image-editor/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor ImageEditor - Default| ImageEditor Demos | Syncfusion",
                HeaderText = "Blazor Image Editor Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Image Editor supports cropping, filtering, drawing, and exporting images, enabling complete and efficient image editing workflows.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-image-editor"
            },
            new Sample
            {
                Name = "Profile Picture",
                Category = "Image Editor",
                Directory = "ImageEditor/ImageEditor",
                Url = "image-editor/profile",
                FileName = "Profile.razor",
                MetaTitle = "Blazor ImageEditor - Profile Picture | ImageEditor Demos | Syncfusion",
                HeaderText = "Blazor Image Editor Example - Profile Picture Customization",
                MetaDescription = "See how the Syncfusion Blazor Image Editor creates profile pictures using cropping, zooming, format conversion, and preview support for optimized image outputs."
            },
            new Sample
            {
                Name = "File Restriction",
                Category = "Image Editor",
                Directory = "ImageEditor/ImageEditor",
                Url = "image-editor/file-restrict",
                FileName = "FileRestrict.razor",
                MetaTitle = "Blazor ImageEditor Demos - File Restriction Examples | Syncfusion",
                HeaderText = "Blazor Image Editor Example - File Format and Size Restrictions",
                MetaDescription = "See how the Syncfusion Blazor Image Editor enforces file size and type restrictions with validation and drag and drop support for secure image upload workflows.",
            }
        };        
    }

}
