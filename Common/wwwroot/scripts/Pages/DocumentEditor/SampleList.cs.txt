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

namespace BlazorDemos
{

    internal partial class SampleConfig
    {
        public List<Sample> DocumentEditor { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "DocumentEditor",
                Type = SampleType.Updated,
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                NotificationDescription = new string[]
                {
                    @"Updated the demo with alternate text for image."
                }
            },
            new Sample
            {
                Name = "Character Formatting",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/character-format",
                FileName = "CharacterFormat.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]
                {
                    @"Updated the demo with character spacing and scaling."
                }
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
                Type = SampleType.Updated,
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/styles",
                FileName = "Styles.razor",
                NotificationDescription = new string[]
                {
                    @"Updated the demo with character and linked styles in drop-down."
                }
            },
            new Sample
            {
                Name = "Bullets and Numbering",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/bullets-and-numbering",
                FileName = "BulletsAndNumbering.razor"
            },
            new Sample
            {
                Name = "Hyperlinks and Bookmarks",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/hyperlinks-and-bookmarks",
                FileName = "HyperlinksAndBookmarks.razor"
            },
            new Sample
            {
                Name = "Table Formatting",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/table-format",
                FileName = "TableFormat.razor"
            },
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
                Type = SampleType.Updated,
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/headers-and-footers",
                FileName = "HeadersAndFooters.razor",
                NotificationDescription = new string[]
                {
                    @"Updated the demo with a link to the previous header/footer."
                }
            },
            new Sample
            {
                Name = "Table of Contents",
                Category = "References",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/table-of-contents",
                FileName = "TableOfContents.razor"
            },
              new Sample
            {
                Name = "Form Fields",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/form-fields",
                FileName = "FormFields.razor"
            },
             new Sample
            {
                Name = "Custom Context Menu",
                Category = "Customization",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/custom-context-menu",
                FileName = "CustomContextMenu.razor"
            },
             new Sample
            {
                Name = "Toolbar Customization",
                Category = "Customization",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/toolbar-customization",
                FileName = "ToolbarCustomization.razor"
            },
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
                Name = "Document Protection",
                Category = "Security",
                Type = SampleType.Updated,
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/document-protection",
                FileName = "DocumentProtection.razor",
                NotificationDescription = new string[]
                {
                    @"Updated the demo to show square bracket for restricted edit range."
                }
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
                Name = "Comments",
                Category = "Review",
                Type = SampleType.Updated,
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/comments",
                FileName = "Comments.razor",
                NotificationDescription = new string[]
                {
                    @"Updated the demo with multiple comment navigation in the same line."
                }
            },
            new Sample
            {
                Name = "Track Changes",
                Category = "Review",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/track-changes",
                FileName = "TrackChanges.razor"
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
