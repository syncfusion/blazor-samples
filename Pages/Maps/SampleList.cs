using System.Collections.Generic;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Maps { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "Maps/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                TitleTag = "Maps . Default . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component visualizes the continents in the world by rendering those in a map layer",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample visualizes the continents in the world by rendering these in a map layer. Also marks the office locations of YouTube in the world using markers.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render a map with the provided GeoJSON data. Group of shapes can be combined to form a layer of the map. You can bind the desired colors from the data source to the map shapes. The marker templates are used to display the names for shapes and mark specific locations. Legend is enabled in this example to represent each continent.
                    </p>
                    <p>
                        Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over a marker or tap a marker in touch enabled devices.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Projection",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "Maps/Projection",
                FileName = "Projection.razor",
                TitleTag = "Maps . Projection . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component shows the details of permanent and non-permanent countries using projection. Projection types can be changed",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                    In this example, you can see how to render a map with various projections. You can use the ColorMapping property to customize the color of the shapes.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render a map with various projections. You can use the <code>ColorMapping</code> property to customize the color of the shapes.
                    </p>
                    <p>
                    Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over a shape or tap a shape in touch enabled devices.
                </p>"
                }
            },
            new Sample
            {
                Name = "Multi-layers",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "Maps/Multilayer",
                FileName = "Multilayer.razor",
                TitleTag = "Maps . Multilayer . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component depicts the layer along with sublayers for California and Texas",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample depicts the layers along with sublayers. Countries in the African and Australian continents are rendered in the sublayers.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render a sublayer in map. Sublayers are used to render the desired shapes over the existing layers. Any number of sublayers can be added to a map. You can use the <code>fill</code>, <code>width</code>, and <code>color</code> properties in the border to customize the appearance of the shapes.

                    </p>"
                }
            },
            new Sample
            {
                Name = "Marker",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "Maps/Marker",
                FileName = "Marker.razor",
                TitleTag = "Maps . Marker . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component shows the top 25 populated cities in the world by displaying the markers in their locations",
                Type = SampleType.Updated,
                ActionDescription = new string[] {
                    @"<p>
                        This sample visualizes the top 25 populated cities in the world by displaying the markers in their locations.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the markers in a map. Markers are used to indicate or mark a particular location on the map with desired symbols.

                    </p>
                    <p>
                        Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over a marker or tap a marker in touch enabled devices.
                    </p>"
            }
            },
             new Sample
             {
                Name = "Marker template",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "Maps/MarkerTemplate",
                FileName = "MarkerTemplate.razor",
                TitleTag = "Maps . MarkerTemplate . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component shows the temperature of various cities of Australia in marker templates.",
                Type = SampleType.None,
                ActionDescription = new string[] {
                     @"<p>
                         This sample indicates the temperature of various cities of Australia in marker templates.
                     </p>"
                 },
                 Description = new string[] {
                     @"<p>
                         In this example, you can see how to place a template as a marker in the map. Any custom HTML elements can be used as a marker. You can use the palette property in the shapeSettings to apply desired fill colors for the shapes.

                     </p>
                     <p>
                         Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over a marker or tap a marker in touch enabled devices.
                     </p>
                 <br />
                 </ p > "
             }
             },
            new Sample
            {
                Name = "Marker clustering",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "Maps/MarkerCluster",
                FileName = "MarkerCluster.razor",
                TitleTag = "Maps . MarkerCluster . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component shows the top 50 cities by placing markers in their locations and clustering the markers to avoid intersecting",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample illustrates the world's top 50 cities by showing the markers in their locations and clustering the markers to avoid intersecting.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to display multiple markers in the same region without intersecting each other. If a marker intersects, it will be clustered and the total number of markers will be displayed over the cluster. When zooming in, the number of clusters will be decreased, and the individual marker will be displayed. When zooming out, markers that intersect will again be clustered. You can use the <code>MarkerClusterSettings</code> in 'MapsLayer' to enable marker clustering.
                        </p>
                        <p>
                            Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over a marker or tap a marker in touch-enabled devices.
                        </p>"
                }
            },
            new Sample
            {
                Name = "Labels",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "Maps/Label",
                FileName = "Label.razor",
                TitleTag = "Maps . DataLabel . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component shows the names of all the states in USA in data label. Intersect action and smart labels mode can be changed",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the names of all the states in USA in data labels. Options have been provided to change the intersect action and smart labels mode of the data labels.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the data labels for each shape in a map. Data labels are used to display the values of the shapes. You can use the <code>autoFill</code> property in the <code>shapeSettings</code> to apply the default palette colors to the shapes.
                    </p>
                    <p>
                    Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over a shape or tap a shape in touch enabled devices.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Bubble",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "Maps/Bubble",
                FileName = "Bubble.razor",
                TitleTag = "Maps . Bubble . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component illustrates the top 30 countries which has highest Internet users in the year 2016 using Bubbles",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates the top 30 countries which has highest Internet users in bubbles of the year 2016.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the bubbles for each shape in a map. Values of the shapes can be determined from the size and color of the bubbles. You can bind the desired colors from the data source to the bubbles.
                    </p>
                    <p>
                    Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over a bubble or tap a bubble in touch enabled devices.
                    </p>"
                }
            },
              new Sample
            {
                Name = "Navigation Lines",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "Maps/NavigationLines",
                FileName = "NavigationLines.razor",
                TitleTag = "Maps . NavigationLines . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component illustrates the top 30 countries which has highest Internet users in the year 2016 using Bubbles",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample illustrates the sea routes between various cities for shipping.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render lines between two points in map. You can use DashArray, Width and Color properties to customize the appearance of the navigation lines.
                    </p>
                    </p>
                    <br />
                    </ p > "
                }
            },
              new Sample
            {
                Name = "Legend",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "Maps/Legend",
                FileName = "Legend.razor",
                TitleTag = "Maps . Legend . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component visualizes grouping of countries in the legend based on their population density. The type and position of the legend can be changed using the Type and Position options in the properties panel.",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample visualizes grouping of countries in the legend based on their population density. The type and position of the legend can be changed using the Type and Position options in the properties panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render a legend in maps. A legend item denotes the value of a shape. Any number of legend items can be added to a legend. You can bind the desired colors to the shapes if its values are within the specified range using the ColorMapping property. You can also show or hide the legend items for the remaining items in the data source; they are not categorized in any color mapping. You can also show or hide color mapping related to population density while toggling the legend item
                    </p>
                    <p>
                        Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over a marker or tap a marker in touch enabled devices.
                    </p>
                    <br />
                    <p style=""font-weight: 500"">Injecting Module</p>
                    <p>
                        Maps component features are segregated into individual feature-wise modules. To use a marker, inject the <code>Marker</code> module using the < code > Maps.Inject(Marker) </ code > method, and use a legend by injecting the<code> Legend</ code > module.
                    </ p > "
                }
            },
            //  new Sample
            //  {
            //      Name = "Color Mapping",
            //      Category = "Features",
            //      Directory = "Maps/Maps",
            //      Url = "Maps/ColorMapping",
            //      FileName = "ColorMapping.razor",
            //      TitleTag = "Maps . ColorMapping . Syncfusion Blazor Components",
            //      MetaDescription = "This demo of Syncfusion Blazor Maps component shows the average amount of rainfall and snowfall in spring season of all the states in the United States. The color mapping is applied to the shapes to differentiate them from other shapes",
            //      Type = SampleType.None,
            //      ActionDescription = new string[] {
            //             @"<p>
            //             This sample shows the average amount of rainfall and snowfall in spring season of all the states in the United States. The color mapping is applied to the shapes to differentiate them from other shapes.
            //         </p>"
            //     },
            //     Description = new string[] {
            //         @"<p>
            //             In this example, you can see how to render a map with color mapping. The range color mapping and desaturation color mapping group the shapes based on the inches value, whereas the equal color mapping groups the shapes based on the category (low, moderate, or high) values. Legend is enabled in this example to represent each color mapping.
            //         </p>
            //         <p>
            //             Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over a marker or tap a marker in touch enabled devices.
            //         </p >"
            //     }
            //  },
             new Sample
            {
                Name = "Annotations",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "Maps/Annotation",
                FileName = "Annotation.razor",
                TitleTag = "Maps . Annotation . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component depicts the facts about Africa continent and a direction compass in an annotation",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample depicts the facts about Africa in an annotation. Africa shape is filled with gradient color.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to place a desired HTML element at desired location in the maps. Any number of annotation can be placed on the maps. In this sample, the gradient fill color has been applied for the shape.
                    </p>"
                }
            },

            new Sample
            {
                Name = "OpenStreetMap",
                Category = "Map Providers",
                Directory = "Maps/Maps",
                Url = "Maps/OpenStreetMap",
                FileName = "OpenStreetMap.razor",
                TitleTag = "Maps . OpenStreetMap . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component shows how to render the OpenStreetMap. It creates and distributes free geographic data for the world",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample visualizes the location of United Nations Headquarters in the OpenStreetMap with marker.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render the OpenStreetMap. The location of United Nations Headquarters is denoted using marker. The EJ2 Dialog is displayed on the top of the marker and the zooming feature is enabled to zoom and pan the map for detailed analysis.
                    </p>"
                }
            },
             new Sample
            {
                Name = "OSM with Navigation Lines",
                Category = "Map Providers",
                Directory = "Maps/Maps",
                Url = "Maps/OSMNavigation",
                FileName = "OSMNavigation.razor",
                TitleTag = "Maps . OSM with Navigation . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component shows how to render the geometric layers as sublayer on the OSM. The outline of Africa is rendered on the OSM",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                This sample illustrates the flight route from Los Angeles to Mexico City using navigation lines in the OpenStreetMap
            </p>"
                },
                Description = new string[] {
                    @"<p>
                In this example, you can see how to render the navigation lines in the OpenStreetMap. The source and destination locations have been denoted using the marker template.
                </p> "
                }
            },
            new Sample
            {
                Name = "OSM with Sublayer",
                Category = "Map Providers",
                Directory = "Maps/Maps",
                Url = "Maps/OSMSublayer",
                FileName = "OSMSublayer.razor",
                TitleTag = "Maps . OSM with Sublayer . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component shows how to render the geometric layers as sublayer on the OSM. The outline of Africa is rendered on the OSM",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample visualizes the location of Africa continent in the World map.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the geometric layers as sublayer on the OpenStreetMap. The outline of Africa continent is rendered using GeoJSON data on the top of the OpenStreetMap.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "Maps/Tooltip",
                FileName = "Tooltip.razor",
                TitleTag = "Maps . Tooltip . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component depicts the countries that were appeared in the finals of Cricket World Cup and their counts using Tooltip",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                    This sample depicts the countries that were appeared in the finals of Cricket World Cup and their counts. By hovering the mouse over the shapes, county name, finalist count, and winning count will be displayed in the tooltip template.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the custom HTML element as tooltip. To see the tooltip in action, hover the mouse over a shape or tap a shape in touch enabled devices. Also, the interactive legend has been placed at the left of the map.
                    </p>
                    <br/>
                    </ p > "
                }
            },
             new Sample
            {
                Name = "Selection & Highlight",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "Maps/Selection",
                FileName = "Selection.razor",
                TitleTag = "Maps . Tooltip . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component visualizes USA president election results in the year 2016. Vote details of a state will be displayed in a popup on clicking a state. Placed interactive legend at the top of the map.",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample visualizes USA president election results in the year 2016. Vote details of a state will be displayed in a popup on clicking a state. Placed interactive legend at the top of the map.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to apply various styles for a shape in the map, when it is clicked or mouse hovered.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Zooming & Panning",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "Maps/Zooming",
                FileName = "Zooming.razor",
                TitleTag = "Maps . Zooming and Panning . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component depicts the properties required to zoom and pan the rendered map. Types of Zooming can be selected",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample depicts the zooming and panning options in the maps. You can customize these options by changing the Zooming, Mouse wheel zoom, Pinch zoom, Single-click zoom, and Double-click zoom in the Properties panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to zoom and pan the map. The support has been provided for zooming with toolbar, rectangle zoom, pinch zoom, mouse wheel zoom, single-click and double-click zoom.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Zoom to fit all markers",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "Maps/ProgramaticZoom",
                FileName = "ProgramaticZoom.razor",
                TitleTag = "Maps . ProgramaticZoom . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component visualizes the capital cities in the south america by displaying the markers in their locations.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                @"<p>
                    This sample visualizes the capital cities in the south america by displaying the markers in their locations.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the markers in a map. Markers are used to indicate or mark a particular location on the map with desired symbols.
                    </p>
                    <p>
                        Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over a marker or tap a marker in touch enabled devices.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Drill Down",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "Maps/Drilldown",
                FileName = "Drilldown.razor",
                TitleTag = "Maps . Drill Down . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component demonstrates drill down with all the continents in the initial view and countries on drill",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample demonstrates drill down with all the continents in the initial view. By clicking a continent, you can view all the countries available in that continent.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                         In this example, you can see how to display an another layer by clicking a shape in previous layer.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Print",
                Category = "Print and Export",
                Directory = "Maps/Maps",
                Url = "Maps/Print",
                FileName = "Print.razor",
                TitleTag = "Maps . Print . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component illustrates the printing functionality in the maps control",
               Type = SampleType.None,
               ActionDescription = new string[] {
                @"<p>
                    This sample illustrates the print feature in Maps. By clicking the Print button, you can print the maps directly from the browser.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render and configure the print. The rendered maps can be printed directly from the browser by calling the public method print. Also this sample visualizes the State-wise US population in the year 2010.

                    </p>
                    <p>
                        Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over a marker or tap a marker in touch enabled devices.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Export",
                Category = "Print and Export",
                Directory = "Maps/Maps",
                Url = "Maps/Export",
                FileName = "Export.razor",
                TitleTag = "Maps . Export . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component illustrates the exporting functionality in the maps control. Extension type for file can be selected",
               Type = SampleType.None,
               ActionDescription = new string[] {
                        @"<p>
                        This sample illustrates the exporting feature in Maps. By clicking the Export button, you can export the map in PNG, JPEG, SVG or in PDF formats.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render and configure the export. The rendered map can be exported as either JPEG, PNG, SVG and PDF formats. It can be achieved using Blob and it is supported only in modern browsers. Also this sample visualizes the locations of the wonders in the world using markers.
                    </p>
                    <p>
                    Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over a marker or tap a marker in touch enabled devices.
                    </p> "
                }
            },
            new Sample
            {
                Name = "HeatMap",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "Maps/HeatMap",
                FileName = "HeatMap.razor",
                TitleTag = "Maps . HeatMap . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component visualizes the state wise population of India in 2011. Color for states will be applied based on its value",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                This sample visualizes the state wise population of India in the year 2011. Color for each state will be applied based on its value.
            </p>"
                },
                Description = new string[] {
                @"<p>
                In this example, you can see how to apply the desired colors for the shapes, if its value is within the specified range using the `MapsShapeColorMapping`. Also, the interactive legend has been placed at the bottom of the map.
                    </p>
                    Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over a shape or tap a shape in touch enabled devices.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Flight routes",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "Maps/FlightRoute",
                FileName = "FlightRoute.razor",
                TitleTag = "Maps . HeatMap . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component demonstrates the flight routes from India to China.",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample demonstrates the flight routes from India to China.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the curved lines between two points in a map. You can use the dashArray, width, and color properties to customize the appearance of the navigation lines.
                    </p>
                    <p>
                        Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over a marker or tap a marker in touch enabled devices.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Earthquake indication",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "Maps/Earthquake",
                FileName = "Earthquake.razor",
                TitleTag = "Maps . Earthquake . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component demonstrates the earth quack occurred in Sumatra, Indonesia in the year 2009",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample demonstrates the earth quack occurred in Sumatra, Indonesia in the year 2009.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render a custom HTML element as marker and place it on a specific location.
                    </p>        
                    </ p > "
                }
            },
            //  new Sample
            // {
            //     Name = "HighlightedRegion",
            //     Category = "Use Cases",
            //     Directory = "Maps/Maps",
            //     Url = "Maps/HighlightedRegion",
            //     FileName = "HighlightedRegion.razor",
            //     TitleTag = "Maps . HighlightedRegion . Syncfusion Blazor Components",
            //     MetaDescription = "This demo of Syncfusion Blazor Maps component depicts the ATM populated areas in Oklahoma by highlighting the regions",
            //     Type = SampleType.None,
            //     ActionDescription = new string[] {
            //             @"<p>
            //             This sample depicts the ATM populated areas in Oklahoma by highlighting the regions.
            //         </p>"
            //     },
            //     Description = new string[] {
            //         @"<p>
            //             In this example, you can see how to highlight some specific region by rendering circles. Any custom HTML element can be used as a marker.
            //         </p>
            //         </ p > "
            //     }
            // },
            //  new Sample
            // {
            //    Name = "Cyber Attack Map",
            //    Category = "Use Cases",
            //    Directory = "Maps/Maps",
            //    Url = "Maps/CyberAttackMap",
            //    FileName = "CyberAttackMap.razor",
            //    TitleTag = "Maps . CyberAttackMap . Syncfusion Blazor Components",
            //    MetaDescription = "This demo of Syncfusion Blazor Maps component depicts the ATM populated areas in Oklahoma by highlighting the regions",
            //    Type = SampleType.None,
            //    ActionDescription = new string[] {
            //         @"<p>
            //             This sample depicts the layers along with sublayers. Countries in the African and Australian continents are rendered in the sublayers.
            //         </p>"
            //     },
            //     Description = new string[] {
            //         @"<p>
            //             In this example, you can see how to render a sublayer in map. Sublayers are used to render the desired shapes over the existing layers. Any number of sublayers can be added to a map. You can use the <code>fill</code>, <code>width</code>, and <code>color</code> properties in the border to customize the appearance of the shapes.

            //         </p>"
            //     }
            // },               
            new Sample
            {
                Name = "Map with Pie chart",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "Maps/MapsWithPie",
                FileName = "MapsWithPie.razor",
                TitleTag = "Maps . MapsWithPie . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component visualizes the placing of pie charts on the maps using marker templates",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample visualizes the placing of pie charts on the maps. Pie chart is rendered with the age group detais of top 6 largest countries.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the pie chart as marker in map. Any custom HTML elements can be used as a marker.
                    </p>
                    <br />
                    </ p >"
                }
            },
            new Sample
            {
                Name = "Map with Slider",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "Maps/MapsWithSlider",
                FileName = "MapsWithSlider.razor",
                TitleTag = "Maps . MapsWithSlider . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component visualizes the population growth of the countries in North America continent",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample depicts the zooming and panning options in the maps. You can customize these options by changing the Zooming, Mouse wheel zoom, Pinch zoom, Single-click zoom, and Double-click zoom in the Properties panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to zoom and pan the map. The support has been provided for zooming with toolbar, rectangle zoom, pinch zoom, mouse wheel zoom, single-click and double-click zoom.
                    </p>
                    <br />
                    </ p >"
                }
            },
              new Sample
            {
                Name = "Sales map",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "Maps/SaleMaps",
                FileName = "SaleMaps.razor",
                TitleTag = "Maps . SaleMaps . Syncfusion Blazor Components",
                MetaDescription = "This demo of Syncfusion Blazor Maps component illustrates the world's top 50 cities by showing the markers in their locations and clustering the markers to avoid intersecting.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates the world's top 50 cities by showing the markers in their locations and clustering the markers to avoid intersecting.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to display multiple markers in the same region without intersecting each other. If a marker intersects, it will be clustered and the total number of markers will be displayed over the cluster. When zooming in, the number of clusters will be decreased, and the individual marker will be displayed. When zooming out, markers that intersect will again be clustered. You can use the clusterSettings property in layer to enable marker clustering.
                    </p>
                    <p>
                    Tooltip is enabled in this example. To see the tooltip in action, hover the mouse over a shape or tap a shape in touch enabled devices.
                </p>"
                }
            },
            //   new Sample
            // {
            //    Name = "Bus seat booking",
            //    Category = "Use Cases",
            //    Directory = "Maps/Maps",
            //    Url = "Maps/SeatSelection",
            //    FileName = "SeatSelection.razor",
            //    TitleTag = "Maps . SeatSelection . Syncfusion Blazor Components",
            //    MetaDescription = "This demo of Syncfusion Blazor Maps component depicts the ATM populated areas in Oklahoma by highlighting the regions",
            //    Type = SampleType.None,
            //    ActionDescription = new string[] {
            //             @"<p>
            //             This sample depicts the zooming and panning options in the maps. You can customize these options by changing the Zooming, Mouse wheel zoom, Pinch zoom, Single-click zoom, and Double-click zoom in the Properties panel.
            //         </p>"
            //     },
            //     Description = new string[] {
            //         @"<p>
            //             In this example, you can see how to zoom and pan the map. The support has been provided for zooming with toolbar, rectangle zoom, pinch zoom, mouse wheel zoom, single-click and double-click zoom.
            //         </p>
            //         <br />
            //         </ p >"
            //     }
            // }
        };
    }




}
