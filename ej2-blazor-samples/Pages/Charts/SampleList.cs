using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Chart { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Line Chart",
                Category = "Chart",
                Directory = "Charts/Chart",
                Url = "Charts/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Bar Chart",
                Category = "Chart",
                Directory = "Charts/Chart",
                Url = "Charts/bar",
                FileName = "Bar.cshtml",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Pie Chart",
                Category = "Chart",
                Directory = "Charts/Chart",
                Url = "Charts/Pie",
                FileName = "Pie.cshtml",
                Type = SampleType.New
            },
              new Sample
            {
                Name = "Polar Chart",
                Category = "Chart",
                Directory = "Charts/Chart",
                Url = "Charts/polar",
                FileName = "Polar.cshtml",
                Type = SampleType.New
            },
               new Sample
            {
                Name = "Track ball",
                Category = "Chart",
                Directory = "Charts/Chart",
                Url = "Charts/Trackball",
                FileName = "Trackball.cshtml",
                Type = SampleType.New
            }
        };

        public List<Sample> RangeNavigator { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "RangeNavigator",
                Category = "Range Navigator",
                Directory = "Charts/RangeNavigator",
                Url = "Charts/RangeNavigator",
                FileName = "RangeNavigator.cshtml",
                Type = SampleType.New
            }
        };
		
		public List<Sample> Sparkline { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Sparkline",
                Directory = "Charts/Sparkline",
                Url = "Sparkline/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Series Type",
                Category = "Sparkline",
                Directory = "Charts/Sparkline",
                Url = "Sparkline/SeriesType",
                FileName = "SeriesType.cshtml",
                Type = SampleType.New,
            }
        };
		
		public List<Sample> SmithChart { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default Functionalities",
                Category = "SmithChart",
                Directory = "Charts/SmithChart",
                Url = "SmithChart/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Customization",
                Category = "SmithChart",
                Directory = "Charts/SmithChart",
                Url = "SmithChart/Customization",
                FileName = "Customization.cshtml",
                Type = SampleType.New
            }
        };

        public List<Sample> StockChart { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Stock Chart",
                Category = "StockChart",
                Directory = "Charts/StockChart",
                Url = "Charts/StockChart",
                FileName = "StockChart.cshtml",
                Type = SampleType.New
            }
        };		
    }   

}
