using System.Collections.Generic;

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
                MetaTitle = "Blazor Editors Examples - Overview | Editors Demos | Syncfusion",
                HeaderText = "Blazor In-place Editor Example - Overview",
                MetaDescription = "See how the Syncfusion Blazor In-place Editor enables inline text editing without separate forms, improving usability with seamless and efficient updates.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-in-place-editor"
            },
            new Sample
            {
                Name = "DropDown Components",
                Category = "In-place Editor",
                Directory = "Editors/InPlaceEditor",
                Url = "in-place-editor/drop-down",
                FileName = "DropDown.razor",
                MetaTitle = "Blazor Editors - DropDown Components | Editors Demos | Syncfusion",
                HeaderText = "Blazor In-place Editor Example - DropDown Components",
                MetaDescription = "See how the Syncfusion Blazor In-place Editor integrates with ComboBox, DropDownList, and AutoComplete for flexible inline editing with rich selection options. "
            },
            new Sample
            {
                Name = "Date Components",
                Category = "In-place Editor",
                Directory = "Editors/InPlaceEditor",
                Url = "in-place-editor/date-pickers",
                FileName = "DatePickers.razor",
                MetaTitle = "Blazor Editors Demos - Date Components Examples | Syncfusion",
                HeaderText = "Blazor In-place Editor Example - Date Components",
                MetaDescription = "See how the Syncfusion Blazor In-place Editor works with DatePicker, DateTimePicker, and TimePicker to provide smooth inline date and time selection in forms."
            },
            new Sample
            {
                Name = "Edit Post",
                Category = "Use Case",
                Directory = "Editors/InPlaceEditor",
                Url = "in-place-editor/edit-post",
                FileName = "EditPost.razor",
                MetaTitle = "Blazor Editors Examples - Edit Post | Editors Demos | Syncfusion",
                HeaderText = "Blazor In-place Editor Example - Edit Blog Post",
                MetaDescription = "See how the Syncfusion Blazor In-place Editor supports inline blog editing with rich text features, enabling efficient updates and better content workflows."
            }
        };
    }
}
