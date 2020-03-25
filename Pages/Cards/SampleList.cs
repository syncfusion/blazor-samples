using System.Collections.Generic;
namespace blazor_samples
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
                Type = SampleType.New,
                TitleTag = "Card . Basic Card . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the line series.",
                ActionDescription = new string[] {
                    @"<p>
                   This sample demonstrates rendering of vertical layout card with business and profile card information.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    The card is a small content display area in which specific structure of the content can be shown. This sample demonstrates the defined structure and predefined classes for adding basic cards with header, and content elements. are used to represent individual data and its value.
                </p>
                "
                }
            },
                new Sample
            {
                Name = "Horizontal Card",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/horizontal-card",
                FileName = "HorizontalCard.razor",
                Type = SampleType.New,
                TitleTag = "Card . Basic Card . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the line series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates card rendering with horizontal layout. Based on the horizontal structure, product card is shown with detailed information.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    By default, card elements are stacked one after another vertically. You can customize the card with specific direction by adding e-card-horizontal to align elements horizontally. Using e-card-stacked class, you can split the horizontal layout with a stacked element on left or right of the card.
                </p>
               "
                }
                },
                new Sample
            {
                Name = "Reveal Card",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/reveal-card",
                FileName = "RevealCard.razor",
                Type = SampleType.New,
                TitleTag = "Card . Basic Card . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the line series.",
                ActionDescription = new string[] {
                    @"<p>
                   This sample demonstrates rendering the card with reveal layouts. Hidden information of card can be revealed to see while clicking “Know more”.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Cards in this sample have a hidden content within the DOM which is available behind the visible element.
                </p>
               "
                }
                },
                new Sample
            {
                Name = "Tile View",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/tile-view",
                FileName = "TileView.razor",
                Type = SampleType.New,
                TitleTag = "Card . Basic Card . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the line series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates cards in Tile view.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Card is a small container in which user can show defined content in specific structure and it is flexible and extensible.
                </p>
               "
                }
                },
                new Sample
            {
                Name = "Multiple Content",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/multiple-content",
                FileName = "MultipleContent.razor",
                Type = SampleType.New,
                TitleTag = "Card . Basic Card . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the line series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates card with multiple contents.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Card is a small container in which user can show defined content in specific structure and it is flexible and extensible.
                </p>
               "
                }
                },
                 new Sample
            {
                Name = "Card With Lists",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/card-with-list",
                FileName = "CardWithList.razor",
                Type = SampleType.New,
                TitleTag = "Card . Basic Card . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the line series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates rendering of List in Card component.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Card is a small container in which user can show defined content in specific structure and it is flexible and extensible. In this sample we can render the list component in card component as template
                </p>
               "
                }
                },
                
                 new Sample
            {
                Name = "Header Card",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/header-card",
                FileName = "HeaderCard.razor",
                Type = SampleType.New,
                TitleTag = "Card . Basic Card . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the line series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the customization of card headers.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                   Card Header can be customized for image position and image in the sample
                </p>
               "
                }
                },
                 new Sample
            {
                Name = "Dynamic Update",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/dynamic-update",
                FileName = "DynamicUpdate.razor",
                Type = SampleType.New,
                TitleTag = "Card . Basic Card . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the line series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates dynamic update for card component.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                   Card Header, Image and Footers can be customized in this sample.
                </p>
               "
                }
                },
                 new Sample
            {
                Name = "Expand Card",
                Category = "Cards",
                Directory = "Cards/Card",
                Url = "card/expand-card",
                FileName = "ExpandCard.razor",
                Type = SampleType.New,
                TitleTag = "Card . Basic Card . Syncfusion Blazor Components",
                MetaDescription = "This demo sample for Essential Blazor Chart control demonstrates how to render and configure the line series.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates Expansion of card.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                   This card show the whether details of a city.
                </p>
               "
                }
                }

        };
        }

}
