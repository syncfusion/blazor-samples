#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Horizontal Card",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/horizontal-card",
                FileName = "HorizontalCard.razor",
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
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Tile View",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/tile-view",
                FileName = "TileView.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multiple Content",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/multiple-content",
                FileName = "MultipleContent.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Card With Lists",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/card-with-list",
                FileName = "CardWithList.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Header Card",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/header-card",
                FileName = "HeaderCard.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Dynamic Update",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/dynamic-update",
                FileName = "DynamicUpdate.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Expand Card",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/expand-card",
                FileName = "ExpandCard.razor",
                Type = SampleType.None
            }
        };
    }
}