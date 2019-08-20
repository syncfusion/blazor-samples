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
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Projection",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "Maps/Projection",
                FileName = "Projection.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Marker",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "Maps/Marker",
                FileName = "Marker.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Marker clustering",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "Maps/MarkerCluster",
                FileName = "MarkerCluster.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Labels",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "Maps/Label",
                FileName = "Label.razor",
                Type = SampleType.New
            },                   
            //new Sample
            //{
            //    Name = "Legend",
            //    Category = "Maps",
            //    Directory = "Maps/Maps",
            //    Url = "Maps/Legend",
            //    FileName = "Legend.razor",
            //    Type = SampleType.New
            //},     
            new Sample
            {
                Name = "OpenStreetMap",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "Maps/OpenStreetMap",
                FileName = "OpenStreetMap.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "OSM with Sublayer",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "Maps/OSMSublayer",
                FileName = "OSMSublayer.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Print",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "Maps/Print",
                FileName = "Print.razor",
               Type = SampleType.New
            },
            new Sample
            {
                Name = "HeatMap",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "Maps/HeatMap",
                FileName = "HeatMap.razor",
                Type = SampleType.New
            }
        };
    }




}
