using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> TreeMap { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default Functionalities",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                TitleTag = "TreeMap . Default . Syncfusion Blazor Components",
                MetaDescription = "This demo demo of Syncfusion Blazor TreeMap component visualizes the sales of cars across various countries in 2017",
                Type = SampleType.None,
                ActionDescription = new string[] {
                 @"<p>
        This sample visualizes the car sales of various countries in 2017 by rendering the countries at top level and car manufacturing companies as leaf items.
    </p>"
                },
                Description = new string[] {
                   @"<p>
        In this example, you can see how to render a treemap with the provided data source. Palette color is applied for the items in treemap. Default legend is enabled in this example to represent the items in top level.
    </p>
    <p>
        Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch enabled devices.
    </p>"
                }
            },
            new Sample
            {
                Name = "Layout",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Layout",
                FileName = "Layout.razor",
                TitleTag = "TreeMap . Layout . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor TreeMap component illustrates the GDP nominal of top 10 countries. The layout of the TreeMap can also be changed",
                Type = SampleType.None,
                ActionDescription = new string[] {
                            @"<p>
                    This sample illustrates the GDP nominal of top 10 countries in the year 2015. The layout and rendering direction of the TreeMap can be changed by using the Layout Type and Render Direction in the properties panel.
                </p>"
                            },
                Description = new string[] {
                                @"<p>
                    In this example, you can change the layout of the TreeMap as desaturation color mapping has been applied to denote the weightage of the items by varying the fill color. The label's text also has been formatted and placed in multiple lines.
                </p>
                <p>
                    Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch enabled devices.
                </p> "
                            }
                        },
            new Sample
            {
                Name = "Drilldown",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Drilldown",
                FileName = "Drilldown.razor",
                TitleTag = "TreeMap . DrillDown . Syncfusion Blazor Components",
                MetaDescription = "This demo demo of Syncfusion Blazor TreeMap component demonstrates drill-down with the continents at the top level followed by regions and countries",
                Type = SampleType.None,
                ActionDescription = new string[] {
                  @"<p>
        This sample demonstrates drill-down with the continents at the top level followed by regions and countries. By clicking a continent, you can view all the countries available in that continent clearly. Customizations can be done in the treemap, by using the options in the properties panel
    </p>"
                },
                Description = new string[] {
                      @"<p>
        In this example, you can see how to render a TreeMap with multiple items and drill it further. Change the drill down view and enable the breadcrumb using the options available in the properties panel.
    </p>
    <p>
        Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch enabled devices.
    </p> "
                }
            },
            new Sample
            {
                Name = "Customization",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Customization",
                FileName = "Customization.razor",
                TitleTag = "TreeMap . Customization . Syncfusion Blazor Components",
                MetaDescription = "This demo demo of Syncfusion Blazor TreeMap component depicts the gold medal categories of US Summer Olympics. Each category is denoted with label template",
                Type = SampleType.None,
                ActionDescription = new string[] {
                            @"<p>
                        This sample depicts the gold medal categories of US in 2016 summer Olympics. Each categories are denoted with label template.
                    </p>"
                            },
                            Description = new string[] {
                                @"<p>
                        In this example, you can see how to place custom HTML templates in the treemap items. Also we have formatted the labels default text.
                    </p>
                    <p>
                        Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch enabled devices.
                        </p>"
                            }
            },
             new Sample
            {
                Name = "Data Label",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Label",
                FileName = "TreeMapLabel.razor",
                TitleTag = "TreeMap . DataLabel . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor TreeMap component depicts the population level of various countries in 2017 along with data labels",
                Type = SampleType.None,
                ActionDescription = new string[] {
                 @"<p>
       This sample illustrates the population level of various countries in 2017. The leaf item’s labels intersect action can be changed by using the Label Intersect Action in properties panel.
    </p>"
                },
                Description = new string[] {
                     @"<p>
        In this example, you can see the various label intersect actions available in TreeMap. Range color mapping has been specified, and the default legend has been enabled in this example.
    </p>
    <p>
        Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch enabled devices
    </p>"
                }
            },
              new Sample
            {
                Name = "Tooltip",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Tooltip",
                FileName = "Tooltip.razor",
                TitleTag = "TreeMap . Tooltip . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor TreeMap component depicts the number of international airports available in South America along with tooltip",
                Type = SampleType.None,
                ActionDescription = new string[] {
                 @"<p>
            This sample depicts the number of International airports in various countries in South America. On hover, the items details will be displayed in tooltip template.
        </p>"
                },
                Description = new string[] {
                     @"<p>
            In this example, you can see how to apply equal color mapping and apply colors for treemap items based on certain value.
        </p>
        <p>
            Tooltip template is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch enabled devices.
        </p>"
                }
            },
               new Sample
            {
                Name = "Legend",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Legend",
                FileName = "Legend.razor",
                TitleTag = "TreeMap . Legend . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor TreeMap component visualizes the U.S.A election results using legend. Default and interactive are the two types of legend",
                Type = SampleType.None,
                ActionDescription = new string[] {
                 @"<p>
        This sample visualizes the 2016 United States presidential election results. The type and position of the legends can be changed using the Type and Position options in the properties panel.
    </p>"
                },
                Description = new string[] {
                    @"<p>
        In this example, you can see the type of legend available in TreeMap. The equal color mapping is applied based on certain value.
    </p>
    <p>
        Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch enabled devices
    </p>"
                }
            },
            // new Sample
            // {
            //     Name = "Color Mapping",
            //     Category = "TreeMap",
            //     Directory = "TreeMap/TreeMap",
            //     Url = "TreeMap/ColorMapping",
            //     FileName = "ColorMapping.razor",
            //     TitleTag = "TreeMap . ColorMapping . Syncfusion Blazor Components",
            //     MetaDescription = "This demo demo of Syncfusion Blazor TreeMap component depicts the top 10 largest islands in the world based on area",
            //     Type = SampleType.None,
            //     ActionDescription = new string[] {
            //      @"<p>
            //         This sample depicts the gold medal categories of US in 2016 summer Olympics. Each categories are denoted with label template.
            //     </p>"
            //             },
            //             Description = new string[] {
            //             @"<p>
            //         In this example, you can see how to place custom HTML templates in the treemap items. Also we have formatted the labels default text.
            //     </p>"           
            //     }
            // },
            new Sample
            {
                Name = "Selection & Highlight",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Selection",
                FileName = "Selection.razor",
                TitleTag = "TreeMap . Selection . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor TreeMap component depicts the details of goods imported by Japan. Selection and highlight options have been enabled",
                Type = SampleType.None,
                ActionDescription = new string[] {
                  @"<p>
        This sample depicts the details of goods imported by Japan. Selection and highlight options have been enabled in this sample.
    </p>"
                },
                Description = new string[] {
                    @"<p>
        In this example, you can see the modes available for performing highlight and selection in TreeMap. It can be either enabled or disabled.
    </p>
    <br />
    <p style=""font-weight: 500"">Injecting Module</p>
    <p>
         TreeMap component features are segregated into individual feature-wise modules. To use highlight and selection, inject the <code>Selection</code> module using the <code>TreeMap.Inject(TreeMapSelection)</code>inject the <code>Highlight</code> module using the <code>TreeMap.Inject(TreeMapHighlight)</code> method.
    </ p > "
                }
            },
            new Sample
            {
                Name = "Print & Export",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Print",
                FileName = "Print.razor",
                TitleTag = "TreeMap . Print and Export . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor TreeMap component depicts the top 10 best-selling smartphone brands. Print and export options have been enabled",
                Type = SampleType.None,
                ActionDescription = new string[] {
                @"<p>
        This sample depicts the top 10 best-selling smartphone brands. Print and export options have been enabled in this sample.
    </p>"
                },
                Description = new string[] {
                      @"<p>
        In this example, you can see how to export and print the rendered TreeMap. The TreeMap can be exported to JPEG, PNG, SVG, and PDF formats.
    </p>
    <p>
        Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch enabled devices.
    </p> "
                }
            },
             // new Sample
             //{
             //    Name = "TreeMap with Pie",
             //    Category = "TreeMap",
             //    Directory = "TreeMap/TreeMap",
             //    Url = "TreeMap/TreeMapwithPie",
             //    FileName = "TreeMapwithPie.razor",
             //    TitleTag = "TreeMap . Treemap with Pie . Syncfusion Blazor Components",
             //    MetaDescription = "This demo of Syncfusion Blazor TreeMap component visualizes the population level of various continents in 2011 based on the gender and age group",
             //    Type = SampleType.None
             //},
                new Sample
            {
                Name = "RTL",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "TreeMap/Rtl",
                FileName = "Rtl.razor",
                TitleTag = "TreeMap . RTL . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor TreeMap component demonstrates drill-down with the continents at the top level from Right To Left",
                Type = SampleType.None,
                ActionDescription = new string[] {
                 @"<p>
           This sample orders the countries based on the unemployment rate by rendering TreeMap in the right-to-left (RTL) direction
        </p>"
                },
                Description = new string[] {
                     @"<p>
            In this example, you can see how to render a TreeMap from the right-to-left direction. The tooltip is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch-enabled devices.
        </p>"
                }
            }
        };      
    }

   


}
