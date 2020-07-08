﻿using System.Collections.Generic;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Maps { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "maps/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample visualizes the continents in the world by rendering in a map layer. Also marks the office locations of YouTube in the world using markers.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render a map with the provided GeoJSON data. You can bind the desired colors from the data source to the map shapes using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsShapeSettings~ColorValuePath.html'>ColorValuePath</a></code>. The marker templates are used to display the names for shapes. Legend is enabled in this example to represent each continent. Tooltip is enabled in this example. Title is provided in this example by using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsTitleSettings_properties.html'>MapsTitleSettings</a></code>.
                    </p>
                    <p>
                        More information about maps can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/getting-started"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Projection",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/projection",
                FileName = "Projection.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                    In this example, you can see how to render a map with various projections. This map depicts the members of the UN security council.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render a map with various projections. Projection type is set using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.SfMaps~ProjectionType.html'>ProjectionType</a></code>. You can use the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsShapeSettings~ColorMapping.html'>MapsShapeColorMapping</a></code> property to customize the color of the shapes. Tooltip is enabled in this example.
                    </p>
                    <p>
                        More information about projection type can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/customization/#change-maps-projection"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Multi-layers",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/multi-layer",
                FileName = "Multilayer.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample depicts the layers along with sublayers. Texas and California states are rendered as the sublayer of USA map.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render a sublayer in map. Sublayers are used to render the desired shapes over the existing layers. Any number of sublayers can be added to a map. You can use the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsShapeSettings~Fill.html'>Fill</a></code>, <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.BorderModel~Width.html'>Width</a></code>, and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.BorderModel~Color.html'>Color</a></code> properties in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsShapeSettings~_ctor.html'>MapsShapeSettings</a></code> property to customize the appearance of the shapes.

                    </p>
                    <p>
                        More information about multiple-layer can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/layers/"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Marker",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/marker",
                FileName = "Marker.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample visualizes the top 25 populated cities in the world by displaying the markers in their locations.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the markers in a map. Markers are used to indicate or mark a particular location on the map with desired symbols. Also, options have been provided to bind the shapes and colors to the markers based on the continent from the data source. This is achieved using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsMarker~ShapeValuePath.html'>ShapeValuePath</a></code> and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsMarker~ColorValuePath.html'>ColorValuePath</a></code> properties of the <code>MapsMarkerSettings</code>. Tooltip is enabled in this example.

                    </p>
                    <p>
                        More information about marker can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/markers"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
             {
                Name = "Marker template",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/marker-template",
                FileName = "MarkerTemplate.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                     @"<p>
                         This sample indicates the temperature of various cities of Australia in marker templates.
                     </p>"
                 },
                 Description = new string[] {
                     @"<p>
                         In this example, you can see how to place a template as a marker in the map. Any custom HTML elements can be used as a marker with help of <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsMarker~MarkerTemplate.html'>MarkerTemplate</a></code>. You can use the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.ShapeSettingsModel~Palette.html'>Palette</a></code> property in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.ShapeSettingsModel_properties.html'>MapsShapeSettings</a></code> to apply desired fill colors for the shapes.
                    </p>"
                }
             },
            new Sample
            {
                Name = "Marker clustering",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/marker-cluster",
                FileName = "MarkerCluster.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample illustrates the world's top 50 cities by showing the markers in their locations and clustering the markers to avoid intersection.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to display multiple markers in the same region without intersecting each other. If a marker intersects, it will be clustered and the total number of markers will be displayed over the cluster. When zooming in, the number of clusters will be decreased, and the individual marker will be displayed. When zooming out, markers that intersect will again be clustered. You can use the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsMarkerClusterSettings_properties.html'>MapsMarkerClusterSettings</a></code> in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsLayers~Layers.html'>MapsLayer</a></code> to enable marker clustering. Tooltip is enabled in this example.
                        </p>
                        <p>
                        More information about marker clustering can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/markers/#marker-clustering"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Labels",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/label",
                FileName = "Label.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the names of all the states in USA in data labels. Options have been provided to change the intersect action and smart labels mode of the data labels.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the data labels for each shape in a map. Data labels are used to display the values of the shapes. You can use the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsShapeSettings~Autofill.html'>AutoFill</a></code> property in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsShapeSettings_properties.html'>MapsShapeSettings</a></code> to apply the default palette colors to the shapes. Tooltip is enabled in this example.
                    </p>
                    <p>
                        More information about label can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/data-labels"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Bubble",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/bubble",
                FileName = "Bubble.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
                        This sample illustrates the top 30 countries which has highest Internet users in bubbles of the year 2016.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the bubbles for each shape in a map. <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsBubbleSettings~BubbleSettings.html'>MapsBubbleSettings</a></code> property is used to render the bubble in the maps. Values of the shapes can be visualized with the size and color of the bubbles. You can bind the desired colors from the data source to the bubbles. Tooltip is enabled in this example.
                    </p>
                    <p>
                        More information about bubbles can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/bubble"">documentation section</a>.
                    </p>"
                }
            },
              new Sample
            {
                Name = "Navigation Lines",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/navigation-lines",
                FileName = "NavigationLines.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample illustrates the sea routes between various cities for shipping.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render lines between two points in map using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsNavigationLine_properties.html'>MapsNavigationLine</a></code>. You can use <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsNavigationLine~DashArray.html'>DashArray</a></code>, <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsNavigationLine~Width.html'>Width</a></code> and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsNavigationLine~Color.html'>Color</a></code> properties to customize the appearance of the navigation lines.
                    </p>
                    <p>
                        More information about navigation-line can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/navigation-line"">documentation section</a>.
                    </p>"
                }
            },
              new Sample
            {
                Name = "Legend",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/legend",
                FileName = "Legend.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample visualizes grouping of countries in the legend based on their population density. The type and position of the legend can be changed using the Type and Position options in the properties panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render a legend in maps using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsLegendSettings_properties.html'>MapsLegendSettings</a></code> property. A legend item denotes the value of a shape. Any number of legend items can be added to a legend. You can bind the desired colors to the shapes if its values are within the specified range using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsShapeColorMappings_properties.html'>MapsShapeColorMappings</a></code> property. You can also show or hide color mapping related to population density while toggling the legend item. Tooltip is enabled in this example.
                    </p>
                    <p>
                        More information about legend can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/legend"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
             {
                 Name = "Color Mapping",
                 Category = "Features",
                 Directory = "Maps/Maps",
                 Url = "maps/color-mapping",
                 FileName = "ColorMapping.razor",
                 Type = SampleType.None,
                 ActionDescription = new string[] {
                        @"<p>
                        This sample shows the average amount of rainfall and snowfall in spring season of all the states in the United States. The color mapping is applied to the shapes to differentiate them from other shapes.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render a map with color mapping. To enable the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsShapeColorMappings_properties.html'>MapsShapeColorMapping</a></code> Property The range color mapping and desaturation color mapping group the shapes based on the inches value, whereas the equal color mapping groups the shapes based on the category (low, moderate, or high) values. Legend is enabled in this example to represent each color mapping. Tooltip is enabled in this example.
                    </p>
                    <p>
                        More information about colormapping can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/color-mapping/"">documentation section</a>.
                    </p>"
                }
             },
             new Sample
            {
                Name = "Annotations",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/annotation",
                FileName = "Annotation.razor",
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
                Url = "maps/open-street-map",
                FileName = "OpenStreetMap.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample visualizes the location of United Nations Headquarters in the OpenStreetMap with marker.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render the OpenStreetMap. The OpenStreetmaps is rendered by setting <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsLayer~LayerType.html'>layerType</a></code> as <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.ShapeLayerType.html'>OSM</a></code> in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsLayer_properties.html'>Mapslayer</a></code> property The location of United Nations Headquarters is denoted using marker.
                    </p>
                    <p>
                        More information about OpenStreetmaps can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/providers/openstreetmap"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "OSM with Navigation Lines",
                Category = "Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/osm-navigation",
                FileName = "OSMNavigation.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                This sample illustrates the flight route from Los Angeles to Mexico City using navigation lines in the OpenStreetMap
            </p>"
                },
                Description = new string[] {
                    @"<p>
                In this example, you can see how to render the navigation lines in the OpenStreetMap. The source and destination locations have been denoted using the marker template.
                </p>
                <p>
                        More information about OpenStreetmaps can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/providers/openstreetmap"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "OSM with Sublayer",
                Category = "Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/osm-sublayer",
                FileName = "OSMSublayer.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample visualizes the location of Africa continent in the World map.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the geometric layers as sublayer on the OpenStreetMap. The outline of Africa continent is rendered using GeoJSON data on the top of the OpenStreetMap.
                    </p>
                    <p>
                        More information about OpenStreetmaps can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/providers/openstreetmap"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "maps/tooltip",
                FileName = "Tooltip.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                    This sample depicts the countries that were appeared in the finals of Cricket World Cup and their counts. By hovering the mouse over the shapes, county name, finalist count, and winning count will be displayed in the tooltip format.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, to see the tooltip in action, hover the mouse over a shape or tap a shape in touch enabled devices. Tooltip is enabled in this sample using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsLayerTooltipSettings_properties.html'>MapsLayerTooltipSettings</a></code> Also, the interactive legend has been placed at the left of the map.
                    </p>
                    <p>
                        More information about tooltip can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/user-interactions/#tooltip"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Selection & Highlight",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "maps/selection",
                FileName = "Selection.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample visualizes USA president election results in the year 2016. Placed interactive legend at the top of the map.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to apply various styles for a shape in the map, when it is clicked or mouse hovered.
                    </p>
                    <p>
                        More information about selection and highlight can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/user-interactions/#shape-selection"">documentation section</a>. Selection is enabled by <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsLayerSelectionSettings_properties.html'>MapsLayerSelectionSettings</a></code> property and highlight is enabled by <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsLayerHighlightSettings_properties.html'>MapsLayerHighlightSettings</a></code> Property 
                    </p>"
                }
            },
            new Sample
            {
                Name = "Zooming & Panning",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "maps/zooming",
                FileName = "Zooming.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample depicts the zooming and panning options in the maps. You can customize these options by changing the Zooming, Panning, Mouse wheel zoom, Pinch zoom, Single-click zoom, and Double-click zoom in the Properties panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to zoom and pan the map. The support has been provided for zooming with the toolbar, rectangle zoom, pinch zoom, mouse wheel zoom, single-click, and double-click zoom.Panning can be enabled or disabled using
                        the Panning option. When it is disabled, the map will switch to zooming mode.
                    </p>
                    <p>
                        More information about zoom can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/user-interactions/#various-types-of-zooming"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Zoom to fit all markers",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "maps/programatic-zoom",
                FileName = "ProgramaticZoom.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                @"<p>
                    This sample visualizes the capital cities in the south america by displaying the markers in their locations.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to zoom the maps based on the markers using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsZoomSettings~ShouldZoomInitially.html'>ShouldZoomInitially</a></code> property in the maps <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsZoomSettings_properties.html'>MapsZoomSettings</a></code>. Markers are used to indicate or mark a particular location on the map with desired symbols.
                    </p>
                    <p>
                        More information about shouldZoomIntially can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/markers/#marker-zooming"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Drill Down",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "maps/drill-down",
                FileName = "Drilldown.razor",
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
                Url = "maps/print",
                FileName = "Print.razor",
                Type = SampleType.Updated,
                ActionDescription = new string[] {
                @"<p>
                    This sample illustrates the print feature in Maps. By clicking the Print button, you can print the maps directly from the browser.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render and configure the print functionality. Print functionality is done by <code><a target='_blank' class='code' href='https://blazor.syncfusion.com/documentation/maps/maps-method/?no-cache=1#print'>Print</a></code> method when <code><a target='_blank' class='code' href=''>AllowPrint</a></code> is set as true. Export functionality is done by <code><a target='_blank' class='code' href='https://blazor.syncfusion.com/documentation/maps/maps-method/?no-cache=1#export'>Export</a></code> method when <code><a target='_blank' class='code' href=''>AllowImageExport</a></code> and <code><a target='_blank' class='code' href=''>AllowPdfExport</a></code> is set as true. Also this sample visualizes the State-wise US population in the year 2010. 
                    </p>
                    <p>
                        More information about print functionality can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/print-and-export/#print"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Export",
                Category = "Print and Export",
                Directory = "Maps/Maps",
                Url = "maps/export",
                FileName = "Export.razor",
                Type = SampleType.Updated,
                ActionDescription = new string[] {
                        @"<p>
                        This sample illustrates the exporting feature in Maps. You can modify the map type to geometric or OSM using the Map type dropdown list in this sample. By clicking the Export button, you can export the map in PNG, JPEG, SVG or in PDF formats.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render and configure the export functionality. The rendered map can be exported as either JPEG, PNG, SVG and PDF formats. Also this sample visualizes the locations of the seven wonders in the world using markers. Export functionality is done by <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.SfMaps~Export.html'>Export</a></code> method when <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.SfMaps~AllowImageExport.html'>AllowImageExport</a></code> and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.SfMaps~AllowPdfExport.html'>AllowPdfExport</a></code> is set as true.
                    </p>
                    <p>
                        More information about export functionality can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/print-and-export/?no-cache=1#export"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "HeatMap",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/heat-map",
                FileName = "HeatMap.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                This sample visualizes the state wise population of India in the year 2011. Color for each state will be applied based on its value.
            </p>"
                },
                Description = new string[] {
                @"<p>
                In this example, you can see how to apply the desired colors for the shapes, if its value is within the specified range using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsShapeColorMapping_properties.html'>MapsShapeColorMappings</a></code>. Also, the interactive legend has been placed at the bottom of the map. Tooltip is enabled in this example.
                    </p>
                    <p>
                        More information about colormapping can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/color-mapping/"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Flight routes",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/flight-route",
                FileName = "FlightRoute.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample demonstrates the flight routes from India to China.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the curved lines between two points in a map using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsNavigationLine_properties.html'>MapsNavigationLine</a></code>. You can use the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsNavigationLine~DashArray.html'>DashArray</a></code>, <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsNavigationLine~Width.html'>Width</a></code>, and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsNavigationLine~Color.html'>Color</a></code> properties to customize the appearance of the navigation lines. Tooltip is enabled in this example.
                    </p>
                    <p>
                        More information about navigation line can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/navigation-line"">documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Earthquake indication",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/earth-quake",
                FileName = "Earthquake.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample demonstrates the earthquake occurred in Sumatra, Indonesia in the year 2009.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to render a custom HTML element as marker and place it on a specific location.
                    </p>
                    <p>
                        More information about marker can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/markers/#marker-shapes"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "HighlightedRegion",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/highlighted-region",
                FileName = "HighlightedRegion.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample depicts the ATM populated areas in Oklahoma by highlighting the regions.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to highlight some specific region by rendering circles. Any custom HTML element can be used as a marker.
                    </p>
                    <p>
                        More information about marker can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/markers/#marker-shapes"">documentation section</a>.
                    </p>"
                }
            },
            //  new Sample
            // {
            //    Name = "Cyber Attack Map",
            //    Category = "Use Cases",
            //    Directory = "Maps/Maps",
            //    Url = "maps/CyberAttackMap",
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
            //             In this example, you can see how to render a sublayer in map. Sublayers are used to render the desired shapes over the existing layers. Any number of sublayers can be added to a map. You can use the <code><a target='_blank' class='code' href=''>fill</a></code>, <code><a target='_blank' class='code' href=''>width</a></code>, and <code><a target='_blank' class='code' href=''>color</a></code> properties in the border to customize the appearance of the shapes.

            //         </p>"
            //     }
            // },               
            new Sample
            {
                Name = "Map with Pie chart",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/maps-with-pie",
                FileName = "MapsWithPie.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                        @"<p>
                        This sample visualizes the placing of pie charts on the maps. Pie chart is rendered with the age group detais of top 6 largest countries.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, you can see how to render the pie chart as marker in map. Any custom HTML elements can be used as a marker.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Map with Slider",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/maps-with-slider",
                FileName = "MapsWithSlider.razor",
                ActionDescription = new string[] {
                        @"<p>
                        This sample visualizes the average annual population growth of the countries in the North America continent.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample visualizes the average annual population growth of the countries in the North America continent. The range color mapping is applied to the shapes based on the population growth of the countries in percentage. Tooltip is enabled in this example.
                    </p>"
                }
            },
              new Sample
            {
                Name = "Sales map",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/sale-maps",
                FileName = "SaleMaps.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates the world's top 50 cities by showing the markers in their locations and clustering the markers to avoid intersecting.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, you can see how to display multiple markers in the same region without intersecting each other. If a marker intersects, it will be clustered and the total number of markers will be displayed over the cluster. When zooming in, the number of clusters will be decreased, and the individual marker will be displayed. When zooming out, markers that intersect will again be clustered. You can use the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Maps.MapsMarkerClusterSettings_properties.html'>MapsMarkerClusterSettings</a></code> property in layer to enable marker clustering. Tooltip is enabled in this example.
                    </p>
                    <p>
                        More information about marker clustering can be found in this
                        <a target=""_blank"" href=""https://blazor.syncfusion.com/documentation/maps/markers/#marker-cluster-expand"">documentation section</a>.
                    </p>"
                }
            },
            //   new Sample
            // {
            //    Name = "Bus seat booking",
            //    Category = "Use Cases",
            //    Directory = "Maps/Maps",
            //    Url = "maps/SeatSelection",
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
