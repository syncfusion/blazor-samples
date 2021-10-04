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
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                NotificationDescription = new string[]
                {
                    @"Improved the sample with text measuring logic to get Microsoft Word application like document pagination."
                }
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
                FileName = "ParagraphFormat.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]
                {
                    @"Updated the demo with paragraph pagination properties (Keep with next, Keep lines together, and widow/orphan control)."
                }
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
                FileName = "TableFormat.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[]
                {
                    @"Updated the demo with support to preserve table position properties."
                }
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
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/document-protection",
                FileName = "DocumentProtection.razor"
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
                Directory = "DocumentEditor/DocumentEditor",
                Url = "document-editor/comments",
                FileName = "Comments.razor"
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
            }
        };
    }

}