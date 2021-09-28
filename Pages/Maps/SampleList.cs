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
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/projection",
                FileName = "Projection.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Multi-layers",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/multi-layer",
                FileName = "Multilayer.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Marker",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/marker",
                FileName = "Marker.razor",
                Type = SampleType.None,
            },
             new Sample
             {
                Name = "Marker Template",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/marker-template",
                FileName = "MarkerTemplate.razor",
                Type = SampleType.None
             },
            new Sample
            {
                Name = "Marker Clustering",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/marker-cluster",
                FileName = "MarkerCluster.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Data Labels",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/data-labels",
                FileName = "Label.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Bubble",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/bubble",
                FileName = "Bubble.razor",
                Type = SampleType.None
            },
              new Sample
            {
                Name = "Navigation Lines",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/navigation-lines",
                FileName = "NavigationLines.razor",
                Type = SampleType.None
            },
              new Sample
            {
                Name = "Legend",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/legend",
                FileName = "Legend.razor",
                Type = SampleType.None
            },
             new Sample
             {
                 Name = "Color Mapping",
                 Category = "Features",
                 Directory = "Maps/Maps",
                 Url = "maps/color-mapping",
                 FileName = "ColorMapping.razor",
                 Type = SampleType.None
             },
             new Sample
            {
                Name = "Annotations",
                Category = "Features",
                Directory = "Maps/Maps",
                Url = "maps/annotation",
                FileName = "Annotation.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "OpenStreetMap",
                Category = "Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/open-street-map",
                FileName = "OpenStreetMap.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "OSM with Navigation Lines",
                Category = "Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/osm-navigation",
                FileName = "OSMNavigation.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "OSM with Sublayer",
                Category = "Map Providers",
                Directory = "Maps/Maps",
                Url = "maps/osm-sublayer",
                FileName = "OSMSublayer.razor",
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
             new Sample
            {
                Name = "Selection & Highlight",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "maps/selection",
                FileName = "Selection.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Zooming & Panning",
                Category = "User Interaction",
                Directory = "Maps/Maps",
                Url = "maps/zooming",
                FileName = "Zooming.razor",
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
                Url = "maps/flight-route",
                FileName = "FlightRoute.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Earthquake Indication",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/earth-quake",
                FileName = "Earthquake.razor",
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
                Name = "Map with Pie chart",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/maps-with-pie",
                FileName = "MapsWithPie.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Map with Slider",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/maps-with-slider",
                FileName = "MapsWithSlider.razor"
            },
              new Sample
            {
                Name = "Sales Map",
                Category = "Use Cases",
                Directory = "Maps/Maps",
                Url = "maps/sale-maps",
                FileName = "SaleMaps.razor",
                Type = SampleType.None
            },
        };
    }
}
