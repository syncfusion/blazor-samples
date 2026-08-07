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
                MetaTitle = "Blazor Maps - Default Functionalities | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Maps visualizes geographic data with customizable shapes, colors, and interactions to create clear and engaging map views.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-map"
            },
            new Sample
            {
                Name = "Projection",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "maps/projection",
                FileName = "Projection.razor",
                MetaTitle = "Blazor Maps Demos - Projection Examples | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Map Projections",
                MetaDescription = "See how the Syncfusion Blazor Maps supports projection types like Mercator and Miller to display geographic data accurately on flat surfaces for mapping.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multi-Layers",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "maps/multi-layers",
                FileName = "Multilayer.razor",
                MetaTitle = "Blazor Maps Examples - Multi-Layers | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Multiple Layers",
                MetaDescription = "See how the Syncfusion Blazor Maps overlays multiple layers with different datasets to create rich, detailed, and comprehensive geographic visualizations.",
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
                MetaTitle = "Blazor Maps Examples - Weather Prediction | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps - AI Powered Weather Prediction Example",
                MetaDescription = "See how the Syncfusion Blazor Maps displays AI based weather forecasts with markers and templates to visualize future conditions across regions effectively.",
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
                MetaTitle = "Blazor Maps Demos - Marker Examples | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Markers",
                MetaDescription = "See how the Syncfusion Blazor Maps adds markers with custom icons and positioning to highlight locations and visualize point based geographic data clearly.",
                Type = SampleType.None,
            },
             new Sample
             {
                Name = "Marker Template",
                Category = "Marker",
                Directory = "Maps/Maps",
                Url = "maps/marker-template",
                FileName = "MarkerTemplate.razor",
                MetaTitle = "Blazor Maps Examples - Marker Template | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Custom Marker Templates",
                MetaDescription = "See how the Syncfusion Blazor Maps uses marker templates with HTML and images to create interactive elements for enhanced map visualization and engagement.",
                Type = SampleType.None
             },
            new Sample
            {
                Name = "Marker Cluster",
                Category = "Marker",
                Directory = "Maps/Maps",
                Url = "maps/marker-cluster",
                FileName = "MarkerClustering.razor",
                MetaTitle = "Blazor Maps Examples - Marker Cluster | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Marker Clustering",
                MetaDescription = "See how the Syncfusion Blazor Maps groups nearby markers into clusters to improve clarity and performance while displaying large volumes of geographic data.",
                Type = SampleType.None
            },
            
             new Sample
            {
                Name = "Bubbles",
                Category = "Indicators",
                Directory = "Maps/Maps",
                Url = "maps/bubbles",
                FileName = "Bubble.razor",
                MetaTitle = "Blazor Maps Demos - Bubbles Examples | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Bubble Visualization",
                MetaDescription = "See how the Syncfusion Blazor Maps uses bubbles sized by values to represent data magnitude and enable clear comparison across geographic locations effectively.",
                Type = SampleType.None
            },
             new Sample
             {
                 Name = "Color Mapping",
                 Category = "Indicators",
                 Directory = "Maps/Maps",
                 Url = "maps/color-mapping",
                 FileName = "ColorMapping.razor",
                 MetaTitle = "Blazor Maps Examples - Color Mapping | Maps Demos | Syncfusion",
                 HeaderText = "Blazor Maps Example - Color Mapping",
                 MetaDescription = "See how the Syncfusion Blazor Maps applies color mapping with data ranges to categorize regions visually and highlight variations in intensity across maps.",
                 Type = SampleType.None
             },
             new Sample
            {
                Name = "Annotations",
                Category = "Indicators",
                Directory = "Maps/Maps",
                Url = "maps/annotations",
                FileName = "Annotation.razor",
                MetaTitle = "Blazor Maps Examples - Annotations | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Map Annotations",
                MetaDescription = "See how the Syncfusion Blazor Maps adds annotations with text, images, and HTML elements to provide context and enrich geographic data visualization effectively",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Data Labels",
                Category = "Indicators",
                Directory = "Maps/Maps",
                Url = "maps/data-labels",
                FileName = "Label.razor",
                MetaTitle = "Blazor Maps Examples - Data Labels | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Data Labels",
                MetaDescription = "See how the Syncfusion Blazor Data Labels Maps displays region names and values with API, formatting, and events for clear geographic data visualization.",
                Type = SampleType.None
            },
              new Sample
            {
                Name = "Navigation Lines",
                Category = "Navigation Lines",
                Directory = "Maps/Maps",
                Url = "maps/navigation-lines",
                FileName = "NavigationLines.razor",
                MetaTitle = "Blazor Maps Examples - Navigation Lines | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Navigation Lines",
                MetaDescription = "See how the Syncfusion Blazor Navigation Lines Maps visualizes routes with API, styling, and events to show clear connections between geographic locations.",
                Type = SampleType.None
            },
           new Sample
           {
               Name = "Polygon",
               Category = "Polygon",
               Directory = "Maps/Maps",
               Url = "maps/polygon",
               FileName = "Polygon.razor",
               MetaTitle = "Blazor Maps Demos - Polygon Examples | Maps Demos | Syncfusion",
               HeaderText = "Blazor Maps Example - Polygon Customization",
               MetaDescription = "See how the Syncfusion Blazor Polygon Maps creates custom regions with API, shapes, and events to highlight areas and improve geographic data visualization."
           },
           new Sample
            {
                Name = "Shapefile",
                Category = "Other Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/shapefile",
                FileName = "Shapefile.razor",
                MetaTitle = "Blazor Maps Demos - Shapefile Examples | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Shapefile Integration",
                MetaDescription = "See how the Syncfusion Blazor Shapefile Maps renders geographic data with API, layers, and events for accurate display of custom boundaries and regions.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "OpenStreetMap",
                Category = "Online Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/open-street-map",
                FileName = "OpenStreetMap.razor",
                MetaTitle = "Blazor Maps Examples - OpenStreetMap | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - OpenStreetMap Integration",
                MetaDescription = "See how the Syncfusion Blazor OpenStreetMap Maps uses map tiles with API, layers, and events to build detailed and interactive geographic visualizations.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "OSM With Sublayer",
                Category = "Online Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/osm-sublayer",
                FileName = "OSMSublayer.razor",
                MetaTitle = "Blazor Maps Examples - OSM With Sublayer | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - OpenStreetMap with Sublayers",
                MetaDescription = "See how the Syncfusion Blazor OSM With Sublayer Maps overlays additional layers with API, data binding, and events for enhanced geographic visualization.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "OSM With Marker Clustering",
                Category = "Online Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/osm-with-marker-clustering",
                FileName = "OSMWithMarkerClustering.razor",
                MetaTitle = "Blazor Maps - OSM With Marker Clustering | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - OpenStreetMap with Marker Clustering",
                MetaDescription = "See how the Syncfusion Blazor OSM Marker Clustering Maps groups markers using API, clustering, and events to optimize performance and improve readability.",
                Type = SampleType.None,
            },
             new Sample
            {
                Name = "OSM With Navigation Lines",
                Category = "Online Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/osm-navigation-lines",
                FileName = "OSMNavigationlines.razor",
                MetaTitle = "Blazor Maps - OSM With Navigation Lines | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - OpenStreetMap with Navigation Lines",
                MetaDescription = "See how the Syncfusion Blazor OSM Navigation Lines Maps connects locations with styled paths using API and events for clear route visualization insights.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "OSM With Legend",
                Category = "Online Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/osm-legend",
                FileName = "OSMLegend.razor",
                MetaTitle = "Blazor Maps Examples - OSM With Legend | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - OpenStreetMap with Legend",
                MetaDescription = "See how the Syncfusion Blazor OSM With Legend Maps displays legends using API, styling, and events to help users interpret geographic data effectively.",
				 Type = SampleType.None
            },
            new Sample
            {
                Name = "Bing Maps",
                Category = "Online Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/bing-map",
                FileName = "BingMap.razor",
                MetaTitle = "Blazor Maps Demos - Bing Maps Examples | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Bing Maps Integration",
                MetaDescription = "See how the Syncfusion Blazor Bing Maps integrates map tiles with API, layers, and events to render detailed and interactive geographic visualizations.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Legend",
                Category = "Legend",
                Directory = "Maps/Maps",
                Url = "maps/legend",
                FileName = "Legend.razor",
                MetaTitle = "Blazor Maps Demos - Legend Examples | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Legend Configuration",
                MetaDescription = "See how the Syncfusion Blazor Legend Maps provides context using API, styling, and events to explain regions and improve overall visualization clarity.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Zooming & Panning",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "maps/zooming-panning",
                FileName = "ZoomingPanning.razor",
                MetaTitle = "Blazor Maps Examples - Zooming & Panning | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Zoom and Pan Controls",
                MetaDescription = "See how the Syncfusion Blazor Zooming and Panning Maps enables navigation with API, controls, and events for exploring and analyzing map details easily.",
                Type = SampleType.None
            },            
             new Sample
            {
                Name = "Selection & Highlight",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "maps/selection-highlight",
                FileName = "Selection.razor",
                MetaTitle = "Blazor Maps Demos - Selection & Highlight Examples | Syncfusion",
                HeaderText = "Blazor Maps Example - Region Selection and Highlighting",
                MetaDescription = "See how the Syncfusion Blazor Selection and Highlight Maps enables interaction with API, styling, and events to select and emphasize regions effectively.",
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
                MetaTitle = "Blazor Maps Demos - Drill Down Examples | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Drill Down Navigation",
                MetaDescription = "See how the Syncfusion Blazor Drill Down Maps enables layered navigation with API and events to explore detailed sub-regions from high-level geographic views.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "maps/tooltip",
                FileName = "Tooltip.razor",
                MetaTitle = "Blazor Maps Demos - Tooltip Examples | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Tooltip Configuration",
                MetaDescription = "See how the Syncfusion Blazor Tooltip Maps displays additional details with API, templates, and events to enhance interactivity and improve data understanding.",
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
                MetaTitle = "Blazor Maps Demos - Print Examples | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Print Functionality",
                MetaDescription = "See how the Syncfusion Blazor Print Maps generates printable output using API, layout settings, and events to support reporting and clear map documentation.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Export",
                Category = "Print and Export",
                Directory = "Maps/Maps",
                Url = "maps/export",
                FileName = "Export.razor",
                MetaTitle = "Blazor Maps Demos - Export Examples | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Export Options",
                MetaDescription = "See how the Syncfusion Blazor Export Maps saves maps using API, settings, and events to image formats for easy sharing, reporting, and presentation workflows.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "HeatMap",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/heat-map",
                FileName = "HeatMap.razor",
                MetaTitle = "Blazor Maps Demos - HeatMap Examples | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Heat Map Visualization",
                MetaDescription = "See how the Syncfusion Blazor HeatMap Maps visualizes geographic intensity using gradients, API, and events for analyzing patterns and spatial data clearly.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Flight Routes",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/flight-routes",
                FileName = "FlightRoute.razor",
                MetaTitle = "Blazor Maps Examples - Flight Routes | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Flight Route Visualization",
                MetaDescription = "See how the Syncfusion Blazor Flight Routes Maps displays air paths using API, navigation lines, and events for analyzing transport connectivity clearly.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Earthquake Indication",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/earth-quake-indication",
                FileName = "EarthquakeIndication.razor",
                MetaTitle = "Blazor Maps Demos - Earthquake Indication Examples | Syncfusion",
                HeaderText = "Blazor Maps Example - Earthquake Visualization",
                MetaDescription = "See how the Syncfusion Blazor Earthquake Maps plots seismic data using API, bubbles, and events to represent magnitude and intensity for analysis clearly.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Highlighted Region",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/highlighted-region",
                FileName = "HighlightedRegion.razor",
                MetaTitle = "Blazor Maps Examples - Highlighted Region | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Region Highlighting",
                MetaDescription = "See how the Syncfusion Blazor Highlighted Region Maps emphasizes areas using API, styling, and events to highlight key regions for better geographic insights.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Map With Pie Chart",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/map-with-pie-chart",
                FileName = "MapsWithPie.razor",
                MetaTitle = "Blazor Maps Examples - Map With Pie Chart | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Integrated Pie Charts",
                MetaDescription = "See how the Syncfusion Blazor Map With Pie Chart overlays pie charts using API, templates, and events to visualize regional data distribution clearly.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Map With Slider",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/map-with-slider",
                FileName = "MapsWithSlider.razor",
                MetaTitle = "Blazor Maps Examples - Map With Slider | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Slider Integration",
                MetaDescription = "See how the Syncfusion Blazor Map With Slider updates data using API, controls, and events to enable interactive time-based geographic analysis clearly."
            },
              new Sample
            {
                Name = "Sales Map",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/sale-map",
                FileName = "SaleMap.razor",
                MetaTitle = "Blazor Maps Demos - Sales Map Examples | Maps Demos | Syncfusion",
                HeaderText = "Blazor Maps Example - Sales Data Visualization",
                MetaDescription = "See how the Syncfusion Blazor Sales Maps visualizes regional performance using API, markers, and events to support business analysis and decision-making.",
                Type = SampleType.None
            },
              new Sample
              {
                  Name = "Bus Seat Selection",
                  Category = "Use Cases",
                  Directory = "Maps/Maps",
                  Url = "maps/bus-seat-selection",
                  FileName= "BusSeatSelection.razor",
                  MetaTitle = "Blazor Maps Examples - Bus Seat Selection | Maps Demos | Syncfusion",
                  HeaderText = "Blazor Maps Example - Bus Seat Selection Interface",
                  MetaDescription = "See how the Syncfusion Blazor Bus Seat Selection Maps provides interactive layouts with API, selection, and events for intuitive seat booking visualization.",
                  Type = SampleType.None
              }
        };
    }
}
