using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ej2_blazor_samples
{

    internal partial class SampleConfig
    {
        public List<Sample> DocumentEditor { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "DocumentEditor",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Character Formatting",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/CharacterFormat",
                FileName = "CharacterFormat.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Paragraph Formatting",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/ParagraphFormat",
                FileName = "ParagraphFormat.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Styles",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/Styles",
                FileName = "Styles.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Bullets and Numbering",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/BulletsAndNumbering",
                FileName = "BulletsAndNumbering.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Hyperlinks and Bookmarks",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/HyperlinksAndBookmarks",
                FileName = "HyperlinksAndBookmarks.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Table Formatting",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/TableFormat",
                FileName = "TableFormat.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Section Formatting",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/SectionFormat",
                FileName = "SectionFormat.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Headers and Footers",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/HeadersAndFooters",
                FileName = "HeadersAndFooters.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Table of Contents",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/TableOfContents",
                FileName = "TableOfContents.razor",
                Type = SampleType.New
            }

        };
    }


}
