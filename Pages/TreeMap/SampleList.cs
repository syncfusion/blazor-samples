using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> TreeMap { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default Functionalities",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
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
    </p>
    <p>
                        More information about TreeMap can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/treemap/layout"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Layout",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/layout",
                FileName = "Layout.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                            @"<p>
                    This sample illustrates the GDP nominal of top 10 countries in the year 2015. The layout and rendering direction of the TreeMap can be changed by using the layout type and render direction in the properties panel.
                </p>"
                            },
                Description = new string[] {
                                @"<p>
                    In this example, you can change the layout of the TreeMap as desaturation color mapping has been applied to denote the weightage of the items by varying the fill color. The label text also has been formatted and placed in multiple lines.
                </p>
                <p>
                    Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch enabled devices.
                </p>
                <p>
                        More information about TreeMap can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/treemap/layout"">documentation section</a>.
                    </p>"
                            }
                        },
            new Sample
            {
                Name = "Drilldown",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/drill-down",
                FileName = "Drilldown.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                  @"<p>
        This sample demonstrates drill-down with the continents at the top level followed by regions and countries. By clicking a continent in the treemap item, you can view all the countries available in that continent clearly. Customizations can be done in the treemap, by using the options in the properties panel
    </p>"
                },
                Description = new string[] {
                      @"<p>
        In this example, you can see how to render a treemap with multiple items and drill it further. You can change the drill down view and enable the breadcrumb using the options available in the properties panel.
    </p>
    <p>
        Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch enabled devices.
    </p>
    <p>
                        More information about TreeMap can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/treemap/drill-down"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Customization",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/customization",
                FileName = "Customization.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                            @"<p>
                        This sample depicts the gold medal categories of US in 2016 summer Olympics. Each categories are denoted with label template.
                    </p>"
                            },
                            Description = new string[] {
                                @"<p>
                        In this example, you can see how to place custom templates in the treemap items. Also we have formatted the label text.
                    </p>
                    <p>
                        Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch enabled devices.
                        </p>
                        <p>
                        More information about TreeMap can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/treemap/getting-started"">documentation section</a>.
                    </p>"
                            }
            },
             new Sample
            {
                Name = "Data Label",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/label",
                FileName = "TreeMapLabel.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                 @"<p>
       This sample illustrates the population level of various countries in 2017. The intersect action of leaf item labels can be changed by using the label intersect action in properties panel.
    </p>"
                },
                Description = new string[] {
                     @"<p>
        In this example, you can see the various label intersect actions available in treemap component. Range color mapping has been specified, and the default legend has been enabled in this example.
    </p>
    <p>
        Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch enabled devices
    </p>
    <p>
                        More information about TreeMap can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/treemap/labels"">documentation section</a>.
                    </p>"
                }
            },
              new Sample
            {
                Name = "Tooltip",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/tooltip",
                FileName = "Tooltip.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                 @"<p>
            This sample depicts the number of international airports in various countries in South America. On hover, the items details will be displayed in tooltip.
        </p>"
                },
                Description = new string[] {
                     @"<p>
            In this example, you can see how to apply equal color mapping and apply colors for treemap items based on certain value.
        </p>
        <p>
            Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch enabled devices.
        </p>
        <p>
                        More information about TreeMap can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/treemap/getting-started"">documentation section</a>.
                    </p>"
                }
            },
               new Sample
            {
                Name = "Legend",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/legend",
                FileName = "Legend.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                 @"<p>
        This sample visualizes the 2016 United States presidential election results. The type and position of the legends can be changed using the type and position options in the properties panel.
    </p>"
                },
                Description = new string[] {
                    @"<p>
        In this example, you can see the type of legend available in treemap. The equal color mapping is applied based on certain value.
    </p>
    <p>
        Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch enabled devices
    </p>
    <p>
                        More information about TreeMap can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/treemap/legend"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Color Mapping",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/color-mapping",
                FileName = "ColorMapping.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                 @"<p>
                    This sample visualizes the top 10 largest islands in the world based on area. The color mapping is applied to the items to differentiate them from other items.
                </p>"
                        },
                        Description = new string[] {
                        @"<p>
                    In this example, you can see how to render a tree map with color mapping. The range color mapping and desaturation color mapping group the shapes based on the area size, whereas the equal color mapping groups the shapes based on the continent value. The legend is enabled in this example to represent each color mapping.
                </p>
                <p>
                        More information about TreeMap can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/treemap/color-mapping"">documentation section</a>.
                    </p>"           
                }
            },
            new Sample
            {
                Name = "Selection & Highlight",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/selection",
                FileName = "Selection.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                  @"<p>
        This sample depicts the details of goods imported by Japan. Selection and highlight options have been enabled in this sample.
    </p>"
                },
                Description = new string[] {
                    @"<p>
        In this example, you can see the modes available for performing highlight and selection in treemap component. It can be either enabled or disabled.
    </p> 
    <p>
                        More information about TreeMap can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/treemap/selection-and-highlight"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Print & Export",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/print",
                FileName = "Print.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                @"<p>
        This sample depicts the top 10 best-selling smartphone brands. Print and export options have been enabled in this sample.
    </p>"
                },
                Description = new string[] {
                      @"<p>
        In this example, you can see how to export and print the rendered treemap. The treemap component can be exported to JPEG, PNG, SVG, and PDF formats.
    </p>
    <p>
        Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch enabled devices.
    </p>
    <p>
                        More information about TreeMap can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/treemap/print-and-export"">documentation section</a>.
                    </p>"
                }
            },
             // new Sample
             //{
             //    Name = "TreeMap with Pie",
             //    Category = "TreeMap",
             //    Directory = "TreeMap/TreeMap",
             //    Url = "treemap/TreeMapwithPie",
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
                Url = "treemap/rtl",
                FileName = "Rtl.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                 @"<p>
           This sample orders the countries based on the unemployment rate by rendering treemap in the right-to-left (RTL) direction
        </p>"
                },
                Description = new string[] {
                     @"<p>
            In this example, you can see how to render a treemap from the right-to-left direction. The tooltip is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch-enabled devices.
        </p>
        <p>
                        More information about TreeMap can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/treemap/getting-started"">documentation section</a>.
                    </p>"
                }
            }
        };      
    }

   


}
