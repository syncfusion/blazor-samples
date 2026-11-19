using System.Collections.Generic;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
		public List<Sample> MediaQuery { get; set; } = new List<Sample>{
             new Sample
            {
                Name = "Default Functionalities",
                Category = "Media Query",
                Directory = "MediaQuery",
                Url = "media-query/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Media Query Examples - Default | MediaQuery Demos | Syncfusion",
                HeaderText = "Blazor Media Query Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor MediaQuery detects viewport changes with responsive breakpoints and conditional rendering to build adaptive layouts across devices",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-media-query"
            }
        };
    }
}