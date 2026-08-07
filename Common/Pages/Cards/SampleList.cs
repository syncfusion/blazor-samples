using System.Collections.Generic;

namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> Card { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Basic Card",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/basic-card",
                FileName = "BasicCard.razor",
                MetaTitle = "Blazor Cards Examples - Basic Card | Cards Demos | Syncfusion",
                HeaderText = "Blazor Card Example - Basic Card",
                MetaDescription = "See how the Syncfusion Blazor Basic Card displays structured content with headers, images, and actions using responsive layouts to organize information clearly.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Horizontal Card",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/horizontal-card",
                FileName = "HorizontalCard.razor",
                MetaTitle = "Blazor Cards Examples - Horizontal Card | Cards Demos | Syncfusion",
                HeaderText = "Blazor Card Example - Horizontal Card",
                MetaDescription = "See how the Syncfusion Blazor Horizontal Card arranges content and images side by side with responsive layout, styling, and actions to improve UI clarity.",
                Type = SampleType.None
            },
            //new Sample
            //{
            //    Name = "Swipeable Card",
            //    Category = "Cards",
            //    Directory = "Cards/Card",
            //    Url = "card/swipeable",
            //    FileName = "SwipeableCard.razor",
            //    Type = SampleType.New
            //},
            new Sample
            {
                Name = "Reveal Card",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/reveal-card",
                FileName = "RevealCard.razor",
                MetaTitle = "Blazor Cards Examples - Reveal Card | Cards Demos | Syncfusion",
                HeaderText = "Blazor Card Example - Reveal Card",
                MetaDescription = "See how the Syncfusion Blazor Reveal Card provides interactive hover reveals, transitions, and hidden content areas to engage users and surface details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Tile View",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/tile-view",
                FileName = "TileView.razor",
                MetaTitle = "Blazor Cards Examples - Tile View | Cards Demos | Syncfusion",
                HeaderText = "Blazor Card Example - Tile View",
                MetaDescription = "See how the Syncfusion Blazor Tile View displays cards in a responsive grid with paging, selection, and layout options to support quick scanning and comparison.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multiple Content",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/multiple-content",
                FileName = "MultipleContent.razor",
                MetaTitle = "Blazor Cards Examples - Multiple Content | Cards Demos | Syncfusion",
                HeaderText = "Blazor Card Example - Multiple Content",
                MetaDescription = "See how the Syncfusion Blazor Multiple Content card supports multi section layouts with media, actions, and responsive design to present content clearly.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Card With Lists",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/card-with-list",
                FileName = "CardWithList.razor",
                MetaTitle = "Blazor Cards Examples - Card With Lists | Cards Demos | Syncfusion",
                HeaderText = "Blazor Card Example - Card With Lists",
                MetaDescription = "See how the Syncfusion Blazor Card With Lists presents structured lists inside cards with headers, actions, and compact styling to enhance data readability.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Header Card",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/header-card",
                FileName = "HeaderCard.razor",
                MetaTitle = "Blazor Cards Examples - Header Card | Cards Demos | Syncfusion",
                HeaderText = "Blazor Card Example - Header Card",
                MetaDescription = "See how the Syncfusion Blazor Header Card features customizable headers, badges, and actions with responsive layout to highlight key information and status.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Dynamic Update",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/dynamic-update",
                FileName = "DynamicUpdate.razor",
                MetaTitle = "Blazor Cards Examples - Dynamic Update | Cards Demos | Syncfusion",
                HeaderText = "Blazor Card Example - Dynamic Update",
                MetaDescription = "See how the Syncfusion Blazor Dynamic Update card supports real time data binding, live updates, and smooth transitions to keep content current and relevant.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Expand Card",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/expand-card",
                FileName = "ExpandCard.razor",
                MetaTitle = "Blazor Cards Examples - Expand Card | Cards Demos | Syncfusion",
                HeaderText = "Blazor Card Example - Expand Card",
                MetaDescription = "See how the Syncfusion Blazor Expand Card enables collapsible sections, animated expansion, and action controls to reveal details while saving screen space.",
                Type = SampleType.None
            }
        };
    }
}