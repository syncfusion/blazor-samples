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
        public List<Sample> ImageEditor { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Image Editor",
                Directory = "ImageEditor/ImageEditor",
                Url = "image-editor/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                NotificationDescription = new string[]{ @"The Image Editor component includes a redact feature that is useful for hiding sensitive information in images by covering or obscuring specific areas to make the information unreadable or unidentifiable." }
            },
            new Sample
            {
                Name = "Profile Picture",
                Category = "Image Editor",
                Directory = "ImageEditor/ImageEditor",
                Url = "image-editor/profile",
                FileName = "Profile.razor"
            },
            new Sample
            {
                Name = "File Restriction",
                Category = "Image Editor",
                Directory = "ImageEditor/ImageEditor",
                Url = "image-editor/file-restrict",
                FileName = "FileRestrict.razor",
                NotificationDescription = new string[]{ "This demo showcases the image file restriction feature of the Blazor Image Editor, which allows for customization of image extensions, size limits, and drag-and-drop functionality." }
            }
        };        
    }

}
