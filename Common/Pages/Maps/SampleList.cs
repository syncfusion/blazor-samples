#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
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
        public List<Sample> Maps { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "maps/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Maps Component | Default Functionalities | Syncfusion",
                HeaderText = "Blazor Maps Example - Default Functionalities",
                MetaDescription = "This Maps demo shows the default functionality of the component. Explore geographic data visualization with customizable shapes, colors, interactive features.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Projection",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "maps/projection",
                FileName = "Projection.razor",
                MetaTitle = "Blazor Maps Projection Types | Geographic Rendering | Syncfusion",
                HeaderText = "Blazor Maps Example - Map Projections",
                MetaDescription = "This Blazor Maps demo shows how to display spherical earth data on a flat surface with various projection techniques like Mercator, Miller, Equirectangular.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multi-Layers",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "maps/multi-layers",
                FileName = "Multilayer.razor",
                MetaTitle = "Blazor Maps Multi-layer | Layered Visualization | Syncfusion",
                HeaderText = "Blazor Maps Example - Multiple Layers",
                MetaDescription = "Blazor Maps demo shows how to overlay multiple geographical layers with different data sets to create comprehensive visualizations with combined information.",
                Type = SampleType.None
            },
#if SERVER
            new Sample
            {
                Name = "Weather Prediction",
                Category = "Smart AI Solutions",
                Directory = "AISamples/Maps",
                Url = "maps/ai-weather-prediction",
                FileName = "WeatherPrediction.razor",
                MetaTitle = "Maps Forecasting Weather Condition - Syncfusion AI Demos",
                HeaderText = "Blazor Maps Example - Weather Prediction",
                MetaDescription = "This Blazor Maps demo uses AI to forecast five-day weather conditions across the United States, displaying predictions with intuitive marker templates.",
                NotificationDescription = new string[]{ @" This demo shows the weather prediction in Maps." },
                Type = SampleType.AI
            },
#endif
            new Sample
            {
                Name = "Marker",
                Category = "Marker",
                Directory = "Maps/Maps",
                Url = "maps/marker",
                FileName = "Marker.razor",
                MetaTitle = "Blazor Maps Markers | Point Indicators | Syncfusion",
                HeaderText = "Blazor Maps Example - Markers",
                MetaDescription = "This demo shows how to add markers to specific locations and highlight points of interest on maps with custom markers for visualizing location-specific data.",
                Type = SampleType.None,
            },
             new Sample
             {
                Name = "Marker Template",
                Category = "Marker",
                Directory = "Maps/Maps",
                Url = "maps/marker-template",
                FileName = "MarkerTemplate.razor",
                MetaTitle = "Blazor Maps Marker Templates | Custom Markers | Syncfusion",
                HeaderText = "Blazor Maps Example - Custom Marker Templates",
                MetaDescription = "This Blazor Maps example demonstrates how to create personalized markers with custom HTML content, images, interactive elements for enhanced map visualization.",
                Type = SampleType.None
             },
            new Sample
            {
                Name = "Marker Cluster",
                Category = "Marker",
                Directory = "Maps/Maps",
                Url = "maps/marker-cluster",
                FileName = "MarkerClustering.razor",
                MetaTitle = "Blazor Maps Marker Clustering | Grouped Indicators | Syncfusion",
                HeaderText = "Blazor Maps Example - Marker Clustering",
                MetaDescription = "This Blazor Maps demo shows how to group nearby markers into clusters for better visualization when dealing with large numbers of markers in close proximity.",
                Type = SampleType.None
            },
            
             new Sample
            {
                Name = "Bubbles",
                Category = "Indicators",
                Directory = "Maps/Maps",
                Url = "maps/bubbles",
                FileName = "Bubble.razor",
                MetaTitle = "Blazor Maps Bubbles | Size-based Visualization | Syncfusion",
                HeaderText = "Blazor Maps Example - Bubble Visualization",
                MetaDescription = "This demo shows how to represent data magnitude with sized bubbles on geographical regions, providing visual comparison of numerical values across locations.",
                Type = SampleType.None
            },
             new Sample
             {
                 Name = "Color Mapping",
                 Category = "Indicators",
                 Directory = "Maps/Maps",
                 Url = "maps/color-mapping",
                 FileName = "ColorMapping.razor",
                 MetaTitle = "Blazor Maps Color Mapping | Data-based Coloring | Syncfusion",
                 HeaderText = "Blazor Maps Example - Color Mapping",
                 MetaDescription = "This Blazor Maps demo shows dynamic regions color based on data values using range-based colors mapping to represent different data categories or intensities.",
                 Type = SampleType.None
             },
             new Sample
            {
                Name = "Annotations",
                Category = "Indicators",
                Directory = "Maps/Maps",
                Url = "maps/annotations",
                FileName = "Annotation.razor",
                MetaTitle = "Blazor Maps Annotations | Custom Overlays | Syncfusion",
                HeaderText = "Blazor Maps Example - Map Annotations",
                MetaDescription = "This Blazor Maps example shows how to add custom text, images, and HTML elements at specific positions on maps to provide additional context or information.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Data Labels",
                Category = "Indicators",
                Directory = "Maps/Maps",
                Url = "maps/data-labels",
                FileName = "Label.razor",
                MetaTitle = "Blazor Maps Data Labels | Region Identification | Syncfusion",
                HeaderText = "Blazor Maps Example - Data Labels",
                MetaDescription = "This Blazor Maps demo shows data label functionality. Learn to display names/values for map regions with customizable text formatting and positioning options.",
                Type = SampleType.None
            },
              new Sample
            {
                Name = "Navigation Lines",
                Category = "Navigation Lines",
                Directory = "Maps/Maps",
                Url = "maps/navigation-lines",
                FileName = "NavigationLines.razor",
                MetaTitle = "Blazor Maps Navigation Lines | Path Visualization | Syncfusion",
                HeaderText = "Blazor Maps Example - Navigation Lines",
                MetaDescription = "This demo shows navigation lines functionality. Learn to visualize routes, paths/connections between different geographical point with customizable line styles.",
                Type = SampleType.None
            },
           new Sample
           {
               Name = "Polygon",
               Category = "Polygon",
               Directory = "Maps/Maps",
               Url = "maps/polygon",
               FileName = "Polygon.razor",
               MetaTitle = "Blazor Maps Polygon Example | Custom Regions | Syncfusion",
               HeaderText = "Blazor Maps Example - Polygon Customization",
               MetaDescription = "This Blazor Maps example demonstrates how to create and customize polygons to highlight specific geographical regions or define custom areas on the map."
           },
           new Sample
            {
                Name = "Shapefile",
                Category = "Other Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/shapefile",
                FileName = "Shapefile.razor",
                MetaTitle = "Blazor Maps Shapefile | GIS Data Integration | Syncfusion",
                HeaderText = "Blazor Maps Example - Shapefile Integration",
                MetaDescription = "This Blazor Maps example demonstrates how to load and render geographic data from ESRI shapefiles for displaying custom geographical boundaries and regions.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "OpenStreetMap",
                Category = "Online Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/open-street-map",
                FileName = "OpenStreetMap.razor",
                MetaTitle = "Blazor Maps with OpenStreetMap | OSM Integration | Syncfusion",
                HeaderText = "Blazor Maps Example - OpenStreetMap Integration",
                MetaDescription = "This Blazor Maps demo shows how to incorporate detailed street-level map tiles from the OpenStreetMap service as a base layer for your geographic visualization.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "OSM With Sublayer",
                Category = "Online Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/osm-sublayer",
                FileName = "OSMSublayer.razor",
                MetaTitle = "Blazor Maps OSM with Sublayers | Layered Maps | Syncfusion",
                HeaderText = "Blazor Maps Example - OpenStreetMap with Sublayers",
                MetaDescription = "This demo shows adding sublayers to OpenStreetMap. Learn to overlay additional geographical data on top of OpenStreetMap base tiles for enhanced visualization.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "OSM With Marker Clustering",
                Category = "Online Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/osm-with-marker-clustering",
                FileName = "OSMWithMarkerClustering.razor",
                MetaTitle = "Blazor Maps OSM Marker Clustering | Grouped Locations | Syncfusion",
                HeaderText = "Blazor Maps Example - OpenStreetMap with Marker Clustering",
                MetaDescription = "This Blazor Maps example demonstrates how to efficiently display large numbers of markers by grouping nearby points into clusters on street-level maps.",
                Type = SampleType.None,
            },
             new Sample
            {
                Name = "OSM With Navigation Lines",
                Category = "Online Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/osm-navigation-lines",
                FileName = "OSMNavigationlines.razor",
                MetaTitle = "Blazor Maps OSM Navigation Lines | Route Display | Syncfusion",
                HeaderText = "Blazor Maps Example - OpenStreetMap with Navigation Lines",
                MetaDescription = "This demo shows adding navigation lines to OpenStreetMap and visualize routes, connections, or paths between different locations on a detailed street map.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "OSM With Legend",
                Category = "Online Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/osm-legend",
                FileName = "OSMLegend.razor",
                MetaTitle = "Blazor Maps OSM with Legend | Map Interpretation | Syncfusion",
                HeaderText = "Blazor Maps Example - OpenStreetMap with Legend",
                MetaDescription = "Blazor Maps demo shows adding legends to OpenStreetMap. Provide context and interpretation guides for data visualization elements overlaid on street-level maps.",
				 Type = SampleType.None
            },
            new Sample
            {
                Name = "Bing Maps",
                Category = "Online Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/bing-map",
                FileName = "BingMap.razor",
                MetaTitle = "Blazor Maps with Bing Maps | Microsoft Maps | Syncfusion",
                HeaderText = "Blazor Maps Example - Bing Maps Integration",
                MetaDescription = "This Blazor Maps demo shows how to incorporate Microsoft's detailed map tiles as a base layer for your geographic visualizations with satellite imagery options.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Legend",
                Category = "Legend",
                Directory = "Maps/Maps",
                Url = "maps/legend",
                FileName = "Legend.razor",
                MetaTitle = "Blazor Maps Legend | Data Interpretation | Syncfusion",
                HeaderText = "Blazor Maps Example - Legend Configuration",
                MetaDescription = "This Blazor Maps example shows how to add and customize map legends that help users interpret color-coded regions, bubbles, or other data visualizations.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Zooming & Panning",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "maps/zooming-panning",
                FileName = "ZoomingPanning.razor",
                MetaTitle = "Blazor Maps Zooming & Panning | Interactive Navigation | Syncfusion",
                HeaderText = "Blazor Maps Example - Zoom and Pan Controls",
                MetaDescription = "This Blazor Maps example demonstrates how to implement interactive map navigation with zoom controls and mouse/touch panning for exploring detailed areas.",
                Type = SampleType.None
            },            
             new Sample
            {
                Name = "Selection & Highlight",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "maps/selection-highlight",
                FileName = "Selection.razor",
                MetaTitle = "Blazor Maps Selection & Highlight | Interactive Regions | Syncfusion",
                HeaderText = "Blazor Maps Example - Region Selection and Highlighting",
                MetaDescription = "This demo shows selection and highlighting features. Learn to enable interactive selection of map regions with visual feedback for improved user engagement.",
                Type = SampleType.None
            },            
            // new Sample
            // {
                // Name = "Zoom to fit all markers",
                // Category = "User Interaction",
                // Directory = "Maps/Maps",
                // Url = "maps/programatic-zoom",
                // FileName = "ProgramaticZoom.razor",
                // Type = SampleType.None
            // },
            new Sample
            {
                Name = "Drill Down",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "maps/drill-down",
                FileName = "Drilldown.razor",
                MetaTitle = "Blazor Maps Drill Down | Hierarchical Navigation | Syncfusion",
                HeaderText = "Blazor Maps Example - Drill Down Navigation",
                MetaDescription = "This demo shows drill-down functionality. Learn to create interactive maps that allow users to click on regions to navigate to more detailed sub-region maps.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "maps/tooltip",
                FileName = "Tooltip.razor",
                MetaTitle = "Blazor Maps Tooltip | Information Display | Syncfusion",
                HeaderText = "Blazor Maps Example - Tooltip Configuration",
                MetaDescription = "This Blazor Maps example shows how to display additional information when users hover over map regions or markers with customizable content and formatting.",
                Type = SampleType.None
            },
            //new Sample
            //{
            //    Name = "Keyboard Navigation",
            //    Category = "User Interaction",
            //    Directory = "Maps/Maps",
            //    Url = "maps/keyboard-navigation",
            //    FileName = "KeyboardNavigation.razor",
            //    Type = SampleType.New
            //},
            new Sample
            {
                Name = "Print",
                Category = "Print and Export",
                Directory = "Maps/Maps",
                Url = "maps/print",
                FileName = "Print.razor",
                MetaTitle = "Blazor Maps Print Feature | Document Generation | Syncfusion",
                HeaderText = "Blazor Maps Example - Print Functionality",
                MetaDescription = "This Blazor Maps demo shows how to implement printing capabilities allowing users to generate physical or PDF copies of map visualizations for documentation.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Export",
                Category = "Print and Export",
                Directory = "Maps/Maps",
                Url = "maps/export",
                FileName = "Export.razor",
                MetaTitle = "Blazor Maps Export | Image Generation | Syncfusion",
                HeaderText = "Blazor Maps Example - Export Options",
                MetaDescription = "This Blazor Maps example shows export functionality. Learn to save maps as image files for use in presentations, reports, or sharing across various platforms.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "HeatMap",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/heat-map",
                FileName = "HeatMap.razor",
                MetaTitle = "Blazor Maps Heat Map | Density Visualization | Syncfusion",
                HeaderText = "Blazor Maps Example - Heat Map Visualization",
                MetaDescription = "This Blazor Maps example shows how to visualize data intensity across geographic areas using color gradients to represent data concentration or magnitude.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Flight Routes",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/flight-routes",
                FileName = "FlightRoute.razor",
                MetaTitle = "Blazor Maps Flight Routes | Air Travel Paths | Syncfusion",
                HeaderText = "Blazor Maps Example - Flight Route Visualization",
                MetaDescription = "This Blazor Maps demo shows how to display air travel paths between cities with curved navigation lines and customizable styling for transport network analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Earthquake Indication",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/earth-quake-indication",
                FileName = "EarthquakeIndication.razor",
                MetaTitle = "Blazor Maps Earthquake Data | Seismic Visualization | Syncfusion",
                HeaderText = "Blazor Maps Example - Earthquake Visualization",
                MetaDescription = "This Blazor Maps example shows how to plot seismic activities using bubbles with varying sizes to represent magnitude and custom colors to indicate intensity.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Highlighted Region",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/highlighted-region",
                FileName = "HighlightedRegion.razor",
                MetaTitle = "Blazor Maps Highlighted Regions | Focus Areas | Syncfusion",
                HeaderText = "Blazor Maps Example - Region Highlighting",
                MetaDescription = "This Blazor Maps demo shows how to emphasize specific geographical areas with custom colors or patterns to draw attention to particular regions of interest.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Map With Pie Chart",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/map-with-pie-chart",
                FileName = "MapsWithPie.razor",
                MetaTitle = "Blazor Maps with Pie Charts | Combined Visualization | Syncfusion",
                HeaderText = "Blazor Maps Example - Integrated Pie Charts",
                MetaDescription = "This Blazor Maps example demonstrates how to overlay pie charts on geographical locations to display proportional data distribution for specific regions.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Map With Slider",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/map-with-slider",
                FileName = "MapsWithSlider.razor",
                MetaTitle = "Blazor Maps with Slider | Temporal Data | Syncfusion",
                HeaderText = "Blazor Maps Example - Slider Integration",
                MetaDescription = "This Blazor Maps example demonstrates how to create interactive time-based visualizations that update map data based on slider position for temporal analysis."
            },
              new Sample
            {
                Name = "Sales Map",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/sale-map",
                FileName = "SaleMap.razor",
                MetaTitle = "Blazor Maps Sales Visualization | Business Analytics | Syncfusion",
                HeaderText = "Blazor Maps Example - Sales Data Visualization",
                MetaDescription = "This Blazor Maps demo shows how to represent regional sales performance with color-coded territories and data markers for business intelligence applications.",
                Type = SampleType.None
            },
              new Sample
              {
                  Name = "Bus Seat Selection",
                  Category = "Use Cases",
                  Directory = "Maps/Maps",
                  Url = "maps/bus-seat-selection",
                  FileName= "BusSeatSelection.razor",
                  MetaTitle = "Blazor Maps Seat Selection | Interactive Booking | Syncfusion",
                  HeaderText = "Blazor Maps Example - Bus Seat Selection Interface",
                  MetaDescription = "This Blazor Maps example demonstrates how to implement an interactive bus seating chart that allows users to select and book seats with visual feedback.",
                  Type = SampleType.None
              }
        };
    }
}
