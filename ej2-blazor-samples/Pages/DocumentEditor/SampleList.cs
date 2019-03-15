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
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Character Formatting",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/CharacterFormat",
                FileName = "CharacterFormat.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Paragraph Formatting",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/ParagraphFormat",
                FileName = "ParagraphFormat.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Styles",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/Styles",
                FileName = "Styles.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Bullets and Numbering",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/BulletsAndNumbering",
                FileName = "BulletsAndNumbering.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Hyperlinks and Bookmarks",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/HyperlinksAndBookmarks",
                FileName = "HyperlinksAndBookmarks.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Table Formatting",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/TableFormat",
                FileName = "TableFormat.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Section Formatting",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/SectionFormat",
                FileName = "SectionFormat.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Headers and Footers",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/HeadersAndFooters",
                FileName = "HeadersAndFooters.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Table of Contents",
                Category = "Editing Features",
                Directory = "DocumentEditor/DocumentEditor",
                Url = "DocumentEditor/TableOfContents",
                FileName = "TableOfContents.cshtml",
                Type = SampleType.New
            }

        };
    }


}
