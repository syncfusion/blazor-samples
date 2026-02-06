#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
                MetaTitle = "Blazor Image Editor Component | Photo Editing | Syncfusion",
                HeaderText = "Blazor Image Editor Example - Default Functionalities",
                MetaDescription = "Blazor Image Editor demo shows core editing capabilities including crop, rotate, flip, draw, filters, redaction features for comprehensive image manipulation.",
                NotificationDescription = new string[]{ @"The Image Editor component includes a redact feature that is useful for hiding sensitive information in images by covering or obscuring specific areas to make the information unreadable or unidentifiable." }
            },
            new Sample
            {
                Name = "Profile Picture",
                Category = "Image Editor",
                Directory = "ImageEditor/ImageEditor",
                Url = "image-editor/profile",
                FileName = "Profile.razor",
                MetaTitle = "Blazor Image Editor Profile Picture | Avatar Editing | Syncfusion",
                HeaderText = "Blazor Image Editor Example - Profile Picture Customization",
                MetaDescription = "This Blazor Image Editor demo shows editing profile picture like cropping with aspect ratio constraints, zooming, format conversion to create optimized avatars."
            },
            new Sample
            {
                Name = "File Restriction",
                Category = "Image Editor",
                Directory = "ImageEditor/ImageEditor",
                Url = "image-editor/file-restrict",
                FileName = "FileRestrict.razor",
                MetaTitle = "Blazor Image Editor File Restrictions | Format Control | Syncfusion",
                HeaderText = "Blazor Image Editor Example - File Format and Size Restrictions",
                MetaDescription = "Blazor Image Editor demo shows how to customizable format limitation, file size constraints, configurable drag-and-drop functionality for secure image handling.",
                NotificationDescription = new string[]{ "This demo showcases the image file restriction feature of the Blazor Image Editor, which allows for customization of image extensions, size limits, and drag-and-drop functionality." }
            }
        };        
    }

}
