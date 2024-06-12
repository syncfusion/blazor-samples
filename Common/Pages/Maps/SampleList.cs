#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
﻿using System.Collections.Generic;
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
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Projection",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "maps/projection",
                FileName = "Projection.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multi-Layers",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "maps/multi-layers",
                FileName = "Multilayer.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Marker",
                Category = "Marker",
                Directory = "Maps/Maps",
                Url = "maps/marker",
                FileName = "Marker.razor",
                Type = SampleType.None,
            },
             new Sample
             {
                Name = "Marker Template",
                Category = "Marker",
                Directory = "Maps/Maps",
                Url = "maps/marker-template",
                FileName = "MarkerTemplate.razor",
                Type = SampleType.None
             },
            new Sample
            {
                Name = "Marker Cluster",
                Category = "Marker",
                Directory = "Maps/Maps",
                Url = "maps/marker-cluster",
                FileName = "MarkerClustering.razor",
                Type = SampleType.None
            },
            
             new Sample
            {
                Name = "Bubbles",
                Category = "Indicators",
                Directory = "Maps/Maps",
                Url = "maps/bubbles",
                FileName = "Bubble.razor",
                Type = SampleType.None
            },
             new Sample
             {
                 Name = "Color Mapping",
                 Category = "Indicators",
                 Directory = "Maps/Maps",
                 Url = "maps/color-mapping",
                 FileName = "ColorMapping.razor",
                 Type = SampleType.None
             },
             new Sample
            {
                Name = "Annotations",
                Category = "Indicators",
                Directory = "Maps/Maps",
                Url = "maps/annotations",
                FileName = "Annotation.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Data Labels",
                Category = "Indicators",
                Directory = "Maps/Maps",
                Url = "maps/data-labels",
                FileName = "Label.razor",
                Type = SampleType.None
            },
              new Sample
            {
                Name = "Navigation Lines",
                Category = "Navigation Lines",
                Directory = "Maps/Maps",
                Url = "maps/navigation-lines",
                FileName = "NavigationLines.razor",
                Type = SampleType.None
            },
           new Sample
           {
               Name = "Polygon",
               Category = "Polygon",
               Directory = "Maps/Maps",
               Url = "maps/polygon",
               FileName = "Polygon.razor"
           },
           new Sample
            {
                Name = "Shapefile",
                Category = "Other Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/shapefile",
                FileName = "Shapefile.razor",
                Type = SampleType.None,
                NotificationDescription = new string[]{ @"A demo of shapefile (*.shp) loading and rendering, a new data source introduced in the component, has been added." }
            },
            new Sample
            {
                Name = "OpenStreetMap",
                Category = "Online Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/open-street-map",
                FileName = "OpenStreetMap.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "OSM With Sublayer",
                Category = "Online Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/osm-sublayer",
                FileName = "OSMSublayer.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "OSM With Navigation Lines",
                Category = "Online Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/osm-navigation-lines",
                FileName = "OSMNavigationlines.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "OSM With Legend",
                Category = "Online Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/osm-legend",
                FileName = "OSMLegend.razor",
				 Type = SampleType.None
            },
            new Sample
            {
                Name = "Bing Maps",
                Category = "Online Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/bing-map",
                FileName = "BingMap.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Legend",
                Category = "Legend",
                Directory = "Maps/Maps",
                Url = "maps/legend",
                FileName = "Legend.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Zooming & Panning",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "maps/zooming-panning",
                FileName = "ZoomingPanning.razor",
                Type = SampleType.None
            },            
             new Sample
            {
                Name = "Selection & Highlight",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "maps/selection-highlight",
                FileName = "Selection.razor",
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
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "maps/tooltip",
                FileName = "Tooltip.razor",
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
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Export",
                Category = "Print and Export",
                Directory = "Maps/Maps",
                Url = "maps/export",
                FileName = "Export.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "HeatMap",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/heat-map",
                FileName = "HeatMap.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Flight Routes",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/flight-routes",
                FileName = "FlightRoute.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Earthquake Indication",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/earth-quake-indication",
                FileName = "EarthquakeIndication.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Highlighted Region",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/highlighted-region",
                FileName = "HighlightedRegion.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Map With Pie Chart",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/map-with-pie-chart",
                FileName = "MapsWithPie.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Map With Slider",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/map-with-slider",
                FileName = "MapsWithSlider.razor"
            },
              new Sample
            {
                Name = "Sales Map",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/sale-map",
                FileName = "SaleMap.razor",
                Type = SampleType.None
            },
              new Sample
              {
                  Name = "Bus Seat Selection",
                  Category = "Use Cases",
                  Directory = "Maps/Maps",
                  Url = "maps/bus-seat-selection",
                  FileName= "BusSeatSelection.razor",
                  Type = SampleType.None
              }
        };
    }
}
