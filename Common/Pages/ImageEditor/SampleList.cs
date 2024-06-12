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
        public List<Sample> ImageEditor { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Image Editor",
                Directory = "ImageEditor/ImageEditor",
                Url = "image-editor/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"The Image Editor component has an enhanced annotation feature. Users can now draw multiple annotations simultaneously, enhancing creative flexibility. Furthermore, every action, including customizations, will be tracked in the undo/redo collection, ensuring a seamless user experience and making it easier to experiment with different designs. The Image Editor component also provides z-order support, allowing users to adjust the positioning of annotations. This feature is particularly useful for designing personalized templates like greeting cards or posters, where managing the layering of multiple annotations is crucial for a polished final product. Additionally, the Image Editor component has an enhanced save feature. Users can now save an image with a specified file name, file type, and image quality, providing more control over the output and ensuring that users can save their work exactly as they need it." }
            },
            new Sample
            {
                Name = "Profile Picture",
                Category = "Image Editor",
                Directory = "ImageEditor/ImageEditor",
                Url = "image-editor/profile",
                FileName = "Profile.razor"
            }
        };        
    }

}
