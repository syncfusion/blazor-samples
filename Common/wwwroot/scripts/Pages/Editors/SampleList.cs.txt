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

namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> InPlaceEditor { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "In-place Editor",
                Directory = "Editors/InPlaceEditor",
                Url = "in-place-editor/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor In-place Editor Overview | Edit-in-Place UI | Syncfusion",
                HeaderText = "Blazor In-place Editor Example - Overview",
                MetaDescription = "This Blazor In-place Editor example demonstrates how to edit text inline without navigating to separate edit forms. Enable seamless content editing directly within your Blazor applications."
            },
            new Sample
            {
                Name = "DropDown Components",
                Category = "In-place Editor",
                Directory = "Editors/InPlaceEditor",
                Url = "in-place-editor/drop-down",
                FileName = "DropDown.razor",
                MetaTitle = "Blazor In-place Editor with DropDown | Inline Selection | Syncfusion",
                HeaderText = "Blazor In-place Editor Example - DropDown Components",
                MetaDescription = "This Blazor In-place Editor example showcases integration with dropdown components like ComboBox, DropDownList, and AutoComplete for inline editing with selection options."
            },
            new Sample
            {
                Name = "Date Components",
                Category = "In-place Editor",
                Directory = "Editors/InPlaceEditor",
                Url = "in-place-editor/date-pickers",
                FileName = "DatePickers.razor",
                MetaTitle = "Blazor In-place Editor with DatePicker | Inline Calendar | Syncfusion",
                HeaderText = "Blazor In-place Editor Example - Date Components",
                MetaDescription = "This Blazor In-place Editor example demonstrates integration with date components like DatePicker, DateTimePicker, and TimePicker for seamless inline date and time selection."
            },
            new Sample
            {
                Name = "Edit Post",
                Category = "Use Case",
                Directory = "Editors/InPlaceEditor",
                Url = "in-place-editor/edit-post",
                FileName = "EditPost.razor",
                MetaTitle = "Blazor In-place Editor Blog Post Example | Content Editing | Syncfusion",
                HeaderText = "Blazor In-place Editor Example - Edit Blog Post",
                MetaDescription = "This Blazor In-place Editor use case demonstrates how to implement inline editing for blog posts with rich text editing capabilities, enabling seamless content management for blog applications."
            }
        };
    }
}
