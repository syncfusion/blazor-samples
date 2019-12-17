using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> HeatMapChart { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "HeatMapChart",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                This sample visualizes the sales revenue of items sold by the employees in a week, where the revenue for the day is displayed in 1000 USD as cell data.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render a heat map with the provided data source. The palette color is applied to the items in heat map. The default legend is enabled in this example to represent the items.
                    </p>
                    <p>
                    Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over an item or tap an item in touch enabled devices.
                </p>"
                }
            }, 
            new Sample
            {
                Name = "Calendar Heatmap",
                Category = "HeatMapChart",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/CalendarHeatmap",
                FileName = "CalendarHeatmap.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the summary of user activities in GitLab account such as merge requests, push events and comments across 52 weeks in a year.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to display a calendar data using heatmap. You can make the axis labels to display at specific time intervals along the datetime axis using the <code>ShowLabelOn</code> property in both axis directives.&nbsp;
                    </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Bubble Types",
                Category = "Bubble HeatMap",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/BubbleTypes",
                FileName = "BubbleTypes.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the female participation rate of the total female population in the country’s work force. In Bubble Heatmap, the data points can be visualized using bubble size, bubble shade and sector view types.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to display the data points in bubble heatmap using multiple views such as bubble size, bubble shade and the sector. You can change the cell type to bubble by using the <code>TileType</code> property in <code>CellSettings</code>, and you can change the view of the bubble heatmap by using the <code>BubbleType</code> property in <code>CellSettings</code>.
            </p>
                    <p>Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Color and Size",
                Category = "Bubble HeatMap",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/ColorAndSize",
                FileName = "ColorAndSize.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                This sample illustrates the number of commercial air craft accidents and the fatalities across the world between 2012 and 2017. Each data point interprets the accident count and the fatality associated with the accident, the size of the bubble depicts the accident count and the shade of the bubble depicts the fatality count.
                </p>"
                },
                Description = new string[] {}
            },
                new Sample
            {
                Name = "Row",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/Row",
                FileName = "Row.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                @"<p>
                    This sample visualizes the GDP growth rate for the countries which are the world’s major economies over the years.
                </p>"
                },
                Description = new string[] {}
            },
            new Sample
            {
                Name = "Cell",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/Cell",
                FileName = "Cell.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                @"<p>
                    This sample visualizes the percentage growth rate of individuals using the internet in a country compared to the overall population to the country.
                </p>"
                }
            },
            new Sample
            {
                Name = "Json Row",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/JsonRow",
                FileName = "JsonRow.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                @"<p>
                    This sample visualizes the overall Olympic medals won by the countries in all the summer Olympic events from the year 2000 to 2016.
                </p>"
                }
            },
            new Sample
            {
                Name = "Json Cell",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/JsonCell",
                FileName = "JsonCell.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                @"<p>
                    This sample visualizes the number of international tourist arrivals in millions of the most visited destinations in the world.
                </p>"
                }
            },
            new Sample
            {
                Name = "Empty Points",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/Emptypoints",
                FileName = "Emptypoints.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the number of deffective product count per 1000 units coming out from a manufacturing unit
                    Data points are enhanced with labels and tooltip. Some data points were not marked with any values which indicates there are no deffective products and these data points are termed as empty points.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render empty points in the Heatmap. The empty points or the points with no data can be marked using <code>null</code> in the data source.
                    You can also customize the background color of the empty points by using the <code>EmptyPointColor</code> property in <code>HeatMapPaletteSettings</code>
                </p>
                <p>
                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample 
            {
                Name = "Inversed Axis",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/InversedAxis",
                FileName = "InversedAxis.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates the population growth rate of the most populous countries over the years. The data label is disabled in this sample, the tooltip displays the data point values.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to reverse the axis origin for both axes, once the axis origin has been reversed the axis data will be displayed inverted. You can reverse the axis origin by enabling the <code>IsInversed</code> property for each axis.

                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Opposed Axis",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/OpposedAxis",
                FileName = "OpposedAxis.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>This sample illustrates the monthly flight arrivals at JFK international airport, New York. The data label is disabled in this sample, the tooltip displays the data point values.</p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to change the display position of the axis. You can change the display position of axes by enabling the <code>OpposedPosition</code> property for each axis.

                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Legend Placement",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/LegendPlacement",
                FileName = "LegendPlacement.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the hourly weather forecast for some major European cities. The data label is disabled in this sample, the tooltip displays the data point values.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to change the display position of the Heatmap legend. You can change the display position of legend to left, right, bottom and top by using the <code>Position</code> property in <code>HeatMapLegendSettings</code>.

                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Large Data",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/LargeData",
                FileName = "LargeData.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the summary of user activities in GitLab account such as merge requests, push events and comments across 52 weeks in a year.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to switch the Heatmap to canvas rendering mode.The rendering performance will be better in <code>Canvas</code> rendering mode, while loading large datasets. You can switch the rendering mode for Heatmap between <code>SVG</code> and <code>Canvas</code> using the <code>RenderingMode</code> property. When the <code>RenderingMode</code> property is set to <code>Auto</code> the rendering mode will be switched automatically based of the size of data source to improve the rendering performance.

                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Palette Mode",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/PaletteMode",
                FileName = "PaletteMode.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the energy consumption in trillion British thermal units (btu) by the various public sectors in US government over the years. The data label is disabled in this sample, the tooltip displays the data point values.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to change the palette type between <code>Fixed</code> and <code>Gradient</code> types in Heatmap. The palette type can be defined using the <code>Type</code> property in <code>PaletteSettings</code> . Legend is enabled in this example, changing the palette mode the legend type will be automatically switched between gradient legend and list type legend.

                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Rendering Mode",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/RenderingMode",
                FileName = "RenderingMode.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the net migration rate for the northern European countries over the years. The data label is disabled in this sample, the tooltip displays the data point values.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    You can change the rendering mode using the <code>RenderingMode</code> property.

                    Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Tooltip Template",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "HeatMapChart/TooltipTemplate",
                FileName = "TooltipTemplate.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the crude oil production of the non-OPEC countries over the years. The data point values displayed are in million barrels per day units.
                </p>"
                },
                Description = new string[] {
                @"<p>
                        In this example, you can see how to customize the tooltip content in Heatmap. You can customize the tooltip content by using the <code>tooltipRender </code> event.
                    </p>
                <p>
                        Tooltip is enabled in this example, to see the tooltip in action, hover a point or tap on a point in touch enabled devices.
                    </p>
                    <br />
                    <p style='font-weight: 500'>Injecting Module</p>"
                }
            }
        };    
    }
}
