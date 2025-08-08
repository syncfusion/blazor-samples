#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
        public List<Sample> Card { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Basic Card",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/basic-card",
                FileName = "BasicCard.razor",
                MetaTitle = "Blazor Card Basic | Content Container Component | Syncfusion",
                HeaderText = "Blazor Card Example - Basic Card",
                MetaDescription = "This Blazor Card basic example demonstrates content container with customizable styling, headers, and content areas for organized information display.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Horizontal Card",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/horizontal-card",
                FileName = "HorizontalCard.razor",
                MetaTitle = "Blazor Card Horizontal | Side-by-Side Layout | Syncfusion",
                HeaderText = "Blazor Card Example - Horizontal Card",
                MetaDescription = "This Blazor Card horizontal example demonstrates side-by-side layout with image and content arrangement for enhanced visual presentation and space utilization.",
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
                MetaTitle = "Blazor Card Reveal | Interactive Content Display | Syncfusion",
                HeaderText = "Blazor Card Example - Reveal Card",
                MetaDescription = "This Blazor Card reveal example demonstrates interactive content display with hover effects and hidden content reveal for engaging user experiences.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Tile View",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/tile-view",
                FileName = "TileView.razor",
                MetaTitle = "Blazor Card Tile View | Grid Layout Display | Syncfusion",
                HeaderText = "Blazor Card Example - Tile View",
                MetaDescription = "This Blazor Card tile view example demonstrates grid layout display with multiple cards arranged in responsive tile format for dashboard-style interfaces.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multiple Content",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/multiple-content",
                FileName = "MultipleContent.razor",
                MetaTitle = "Blazor Card Multiple Content | Rich Content Areas | Syncfusion",
                HeaderText = "Blazor Card Example - Multiple Content",
                MetaDescription = "This Blazor Card multiple content example demonstrates rich content areas with various content types including text, images, and actions for comprehensive information display.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Card With Lists",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/card-with-list",
                FileName = "CardWithList.razor",
                MetaTitle = "Blazor Card With Lists | Structured Data Display | Syncfusion",
                HeaderText = "Blazor Card Example - Card With Lists",
                MetaDescription = "This Blazor Card with lists example demonstrates structured data display with list items inside cards for organized content presentation and data visualization.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Header Card",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/header-card",
                FileName = "HeaderCard.razor",
                MetaTitle = "Blazor Card Header | Titled Content Container | Syncfusion",
                HeaderText = "Blazor Card Example - Header Card",
                MetaDescription = "This Blazor Card header example demonstrates titled content container with customizable header sections and content areas for structured information layout.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Dynamic Update",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/dynamic-update",
                FileName = "DynamicUpdate.razor",
                MetaTitle = "Blazor Card Dynamic Update | Real-Time Content | Syncfusion",
                HeaderText = "Blazor Card Example - Dynamic Update",
                MetaDescription = "This Blazor Card dynamic update example demonstrates real-time content updates with data binding and state management for live information display.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Expand Card",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/expand-card",
                FileName = "ExpandCard.razor",
                MetaTitle = "Blazor Card Expand | Collapsible Content Display | Syncfusion",
                HeaderText = "Blazor Card Example - Expand Card",
                MetaDescription = "This Blazor Card expand example demonstrates collapsible content display with expand/collapse functionality for space-efficient information presentation.",
                Type = SampleType.None
            }
        };
    }
}