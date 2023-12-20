#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_MAUI_Demos
{

    internal partial class SampleConfig
    {
        public List<Sample> DocumentEditor { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "DocumentEditor",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/default-functionalities",
                FileName = "DefaultFunctionalities.razor"

            },
            new Sample
            {
                Name = "Character Formatting",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/character-format",
                FileName = "CharacterFormat.razor"
            },
            new Sample
            {
                Name = "Paragraph Formatting",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/paragraph-format",
                FileName = "ParagraphFormat.razor"
            },
            new Sample
            {
                Name = "Styles",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/styles",
                FileName = "Styles.razor"
            },
            new Sample
            {
                Name = "Bullets and Numbering",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/bullets-and-numbering",
                FileName = "BulletsAndNumbering.razor"
            },
            //new Sample
            //{
            //    Name = "Table Formatting",
            //    Category = "Editing Features",
            //    Type = SampleType.Updated,
            //    Directory = "DocumentEditor/DocumentEditor",
            //    Url = "document-editor/table-format",
            //    FileName = "TableFormat.razor",
            //    NotificationDescription = new string[]
            //    {
            //        @"Updated the demo with table title and description "
            //    }
            //},
            new Sample
            {
                Name = "Section Formatting",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/section-format",
                FileName = "SectionFormat.razor"
            },
            new Sample
            {
                Name = "Headers and Footers",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/headers-and-footers",
                FileName = "HeadersAndFooters.razor"
            },
            new Sample
            {
                Name = "Table of Contents",
                Category = "References",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/table-of-contents",
                FileName = "TableOfContents.razor"
            },
            //  new Sample
            //{
            //    Name = "Form Fields",
            //    Category = "Editing Features",
            //    Directory = "DocumentEditor/DocumentEditor",
            //    Url = "document-editor/form-fields",
            //    FileName = "FormFields.razor"
            //},
             new Sample
            {
                Name = "Chart Preservation",
                Category = "Charts",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/chart",
                FileName = "Chart.razor"
            },
            new Sample
            {
                Name = "Web Layout",
                Category = "View",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/web-layout",
                FileName = "WebLayout.razor"
            },
            new Sample
            {
                Name = "Footnotes and Endnotes",
                Category = "References",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/notes",
                FileName = "Notes.razor"
            },
             new Sample
            {
                Name = "Multiple Columns",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/multiple-columns",
                FileName = "MultipleColumn.razor"
            }
        };
    }

}
