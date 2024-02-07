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
                FileName = "Overview.razor"
            },
            new Sample
            {
                Name = "DropDown Components",
                Category = "In-place Editor",
                Directory = "Editors/InPlaceEditor",
                Url = "in-place-editor/drop-down",
                FileName = "DropDown.razor"
            },
            new Sample
            {
                Name = "Date Components",
                Category = "In-place Editor",
                Directory = "Editors/InPlaceEditor",
                Url = "in-place-editor/date-pickers",
                FileName = "DatePickers.razor"
            },
            new Sample
            {
                Name = "Edit Post",
                Category = "Use Case",
                Directory = "Editors/InPlaceEditor",
                Url = "in-place-editor/edit-post",
                FileName = "EditPost.razor"
            }
        };
    }
}
