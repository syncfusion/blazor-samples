using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> HeatMapChart { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "HeatMap Chart",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                ActionDescription = new string[] {
                    @"<p>
                This sample visualizes the sales revenue of items sold by the employees in a week, where the revenue for the day is displayed in 1000 USD as cell data.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render a Heatmap with the provided DataSource. The Palette color is applied to the items in Heatmap. The default Legend is enabled in this example to represent the items.
                    </p>
                    <p>
                    Tooltip is enabled in this example. To see the Tooltip in action, hover the mouse over an item or tap an item in touch enabled devices.
                </p>"
                }
            }, 
            new Sample
            {
                Name = "Calendar Heatmap",
                Category = "HeatMap Chart",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/calendar-heatmap",
                FileName = "CalendarHeatmap.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the summary of user activities in GitLab account such as merge requests, push events and comments across 52 weeks in a year.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to display a Calendar data using Heatmap. You can make the axis labels to display at specific time intervals along the datetime axis using the <code>ShowLabelOn</code> property in both axis directives.&nbsp;
                    </p>
                <p>
                    Tooltip is enabled in this example, to see the Tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Bubble Types",
                Category = "Bubble HeatMap",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/bubble-types",
                FileName = "BubbleTypes.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the female participation rate of the total female population in the country’s work force. In Bubble Heatmap, the data points can be visualized using Bubble Size, Bubble Shade and Sector view types.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to display the data points in Bubble Heatmap using multiple views such as Bubble Size, Bubble Shade and the Sector. You can change the cell type to Bubble by using the <code>TileType</code> property in <code>CellSettings</code>, and you can change the view of the Bubble Heatmap by using the <code>BubbleType</code> property in <code>CellSettings</code>.
            </p>
                    <p>Tooltip is enabled in this example, to see the Tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Color and Size",
                Category = "Bubble HeatMap",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/color-and-size",
                FileName = "ColorAndSize.razor",
                ActionDescription = new string[] {
                    @"<p>
                This sample illustrates the number of commercial air craft accidents and the fatalities across the world between 2012 and 2017. Each data point interprets the accident count and the fatality associated with the accident, the Size of the Bubble depicts the accident count and the shade of the Bubble depicts the fatality count.
                </p>"
                },
                 Description = new string[] {
                    @"<p>
                    In this example, you can see how to map more than one data for each data point or cell of the Bubble Heatmap. 
                    The Size and Color parameters of the Bubble is used to depict the DataSource values. The Legend will be displayed only for the Color parameter of the Bubble.
                    For JSON data, you can specify which DataSource value should be mapped to either Size or Shade of the Bubble parameters using the dataMapping property. 
                    The DataSource field should mapped to the Size and Color properties of the DataMapping property.In this example, you can see how to map more than one data for each data point or cell of the Bubble Heatmap. 
                    The <code>Size</code> and <code>Color</code> parameters of the Bubble is used to depict the DataSource values. The Legend will be displayed only for the <code>Color</code> parameter of the Bubble. 
                    For JSON data, you can specify which DataSource value should be mapped to either size or shade of the Bubble parameters using the DataMapping property. 
                    The DataSource field should mapped to the <code>Size</code> and <code>Color</code> properties of the DataMapping property.
                  </p>
                    <p>Tooltip is enabled in this example, to see the Tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
                new Sample
            {
                Name = "Row",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/row",
                FileName = "Row.razor",
                ActionDescription = new string[] {
                @"<p>
                    This sample visualizes the GDP growth rate for the countries which are the world’s major economies over the years.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                  In this example, you can see how to bind array object as DataSource for Heatmap and configure the Heatmap using the data adaptor support. You can directly bind the array object to the Heatmap DataSource with default property settings.
                 <p>
                  <p>Tooltip is enabled in this example, to see the Tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Cell",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/cell",
                FileName = "Cell.razor",
                ActionDescription = new string[] {
                @"<p>
                    This sample visualizes the percentage growth rate of individuals using the internet in a country compared to the overall population to the country.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                   In this example, you can see how to bind two-dimensional array object as DataSource for Heatmap and configure the Heatmap using the data adaptor support.
                <p>
                  <p>Tooltip is enabled in this example, to see the Tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Json Row",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/json-row",
                FileName = "JsonRow.razor",
                ActionDescription = new string[] {
                @"<p>
                    This sample visualizes the overall Olympic medals won by the countries in all the summer Olympic events from the year 2000 to 2016.
                </p>"
                },
                 Description = new string[] {
                    @"<p>
                   In this example, you can see how to bind JSON data and configure the Heatmap using the data adaptor support. You can bind the JSON data with information for each row to the Heatmap using <code>IsJsonData</code> and by defining the <code>AdaptorType</code> properties. 
                   In row JSON data, the row header is mapped using the <code>XDataMapping</code>.</p>
                <p>
                  <p>Tooltip is enabled in this example, to see the Tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Json Cell",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/json-cell",
                FileName = "JsonCell.razor",
                ActionDescription = new string[] {
                @"<p>
                    This sample visualizes the number of international tourist arrivals in millions of the most visited destinations in the world.
                </p>"
                },
                   Description = new string[] {
                    @"<p>
                    In this example, you can see how to bind JSON data and configure the Heatmap using the data adaptor support. You can bind the JSON data with information for each individual cell to the Heatmap using <code>IsJsonData</code> and by defining the <code>AdaptorType</code> properties. 
                    In cell JSON data, the value for each cell is mapped using the <code>XDataMapping</code> , <code>YDataMapping</code> and <code>ValueMapping</code> properties.
                </p>
                 <p>Tooltip is enabled in this example, to see the Tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Empty Points",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/empty-points",
                FileName = "Emptypoints.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the number of defective product count per 1000 units coming out from a manufacturing unit
                    Data points are enhanced with Labels and Tooltip. Some data points were not marked with any values which indicates there are no defective products and these data points are termed as empty points.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render empty points in the Heatmap. The empty points or the points with no data can be marked using <code>null</code> in the DataSource.
                    You can also customize the background color of the empty points by using the <code>EmptyPointColor</code> property in <code>HeatMapPaletteSettings</code>.
                </p>
                <p>
                    Tooltip is enabled in this example, to see the Tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample 
            {
                Name = "Inversed Axis",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/inversed-axis",
                FileName = "InversedAxis.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates the population growth rate of the most populous countries over the years. The data label is disabled in this sample, the Tooltip displays the data point values.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to reverse the axis origin for both axes, once the axis origin has been reversed the axis data will be displayed inverted. You can reverse the axis origin by enabling the <code>IsInversed</code> property for each axis.
                    </p>
                    <p>
                    Tooltip is enabled in this example, to see the Tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Opposed Axis",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/opposed-axis",
                FileName = "OpposedAxis.razor",
                ActionDescription = new string[] {
                    @"<p>This sample illustrates the monthly flight arrivals at JFK international airport, New York. The data label is disabled in this sample, the Tooltip displays the data point values.</p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to change the display position of the axis. You can change the display position of axes by enabling the <code>OpposedPosition</code> property for each axis.
                    </p>
                    <p>
                    Tooltip is enabled in this example, to see the Tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Legend Placement",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/legend-placement",
                FileName = "LegendPlacement.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the hourly weather forecast for some major European cities. The data label is disabled in this sample, the Tooltip displays the data point values.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to change the display position of the Heatmap Legend. You can change the display position of Legend to left, right, bottom and top by using the <code>Position</code> property in <code>HeatMapLegendSettings</code>.
                    </p>
                    <p>
                    Tooltip is enabled in this example, to see the Tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Large Data",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/large-data",
                FileName = "LargeData.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the annual traffic report of an airport with the number of flight arrivals in a year.The data label is disabled in this sample, the Tooltip displays the data point values.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                     In this example, you can see how to switch the Heatmap to Canvas Rendering Mode.The rendering performance will be better in <code>Canvas</code> Rendering Mode, while loading large datasets. 
                    </p>                    
                    <p>    
                    Tooltip is enabled in this example, to see the Tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Palette Mode",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/palette-mode",
                FileName = "PaletteMode.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the energy consumption in trillion British thermal units (btu) by the various public sectors in US government over the years. The data label is disabled in this sample, the Tooltip displays the data point values.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to change the Palette type between <code>Fixed</code> and <code>Gradient</code> types in Heatmap. The palette type can be defined using the <code>Type</code> property in <code>PaletteSettings</code> . Legend is enabled in this example, changing the palette mode the Legend Type will be automatically switched between Gradient Legend and list type Legend.
                    </p>
                    <p>Tooltip is enabled in this example, to see the Tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Rendering Mode",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/rendering-mode",
                FileName = "RenderingMode.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the net migration rate for the northern European countries over the years. The data label is disabled in this sample, the Tooltip displays the data point values.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    You can change the Rendering Mode using the <code>RenderingMode</code> property.You can switch the rendering mode for Heatmap between <code>SVG</code> and <code>Canvas</code> using the <code>RenderingMode</code> property. When the <code>RenderingMode</code> property is set to <code>Auto</code> the rendering mode will be switched automatically based of the size of DataSource to improve the rendering performance.
                    </p>
                    <p>Tooltip is enabled in this example, to see the Tooltip in action, hover a point or tap on a point in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Tooltip Template",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/tooltip-template",
                FileName = "TooltipTemplate.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the crude oil production of the non-OPEC countries over the years. The data point values displayed are in million barrels per day units.
                </p>"
                },
                Description = new string[] {
                @"<p>
                        In this example, you can see how to customize the Tooltip content in Heatmap. You can customize the Tooltip content by using the <code>TooltipRender </code> event.
                    </p>
                <p>
                        Tooltip is enabled in this example, to see the Tooltip in action, hover a point or tap on a point in touch enabled devices.
                    </p>
                    <br />"
                }
            }
        };    
    }
}
