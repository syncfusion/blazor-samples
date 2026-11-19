using System.Collections.Generic;
namespace BlazorDemos.Pages.PivotView.PivotTable
{
    public class RegionData
    {
        public IReadOnlyList<string>? Country { get; }
        public string Region { get; set; } = string.Empty;

        public RegionData()
        {
        }

        public RegionData(IReadOnlyList<string>? country, string region)
        {
            Country = country;
            Region = region;
        }

        private static readonly List<RegionData> DataList = new List<RegionData>()
        {
            new RegionData(new List<string> (){"Canada", "United States", "Mexico" }, "North America"),
            new RegionData(new List<string> (){"Turkey", "Saudi Arabia" }, "Middle East"),
            new RegionData(new List<string> (){"Russia", "Germany", "France", "United Kingdom", "Italy" }, "Europe"),
            new RegionData(new List<string> (){"South Africa" }, "Africa"),
            new RegionData(new List<string> () {"Australia", "China", "India", "Indonesia", "Japan", "South Korea" }, "Asia Pacific"),
            new RegionData(new List<string> () { "Brazil" }, "South America")
        };

        public static IEnumerable<RegionData> Data => DataList;
    }
}