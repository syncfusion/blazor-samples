using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> QueryBuilder { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "QueryBuilder",
                Directory = "Forms/QueryBuilder",
                Url = "QueryBuilder/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
				TitleTag = "QueryBuilder . DefaultFunctionalities . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the default functionalities of the Query Builder component. Click the plus button to add group or conditions.",
                ActionDescription = new string[] {
                    @"This sample demonstrates the default functionalities of the Query Builder component. Click the plus button to add a group or conditions."
                },
                Description = new string[] {
                    @"The Query Builder component is used to create or edit filters. You can edit filters by changing the fields.",
                    @"In mobile mode, the component is shown vertically.",
                    @"More information about Query Builder can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/aspnet-core-blazor/documentation/query-builder/getting-started/"">
                            documentation section
                        </a>."
                }
            },
             new Sample
            {
                Name = "Integration with Data Grid",
                Category = "QueryBuilder",
                Directory = "Forms/Grid",
                Url = "QueryBuilder/Grid",
                FileName = "Grid.razor",
                TitleTag = "QueryBuilder . Integration with Data Grid . Syncfusion Blazor Components - Preview",
                MetaDescription = "This sample demonstrates the integration of the Data Grid component to showcase data population based on the created filters using the Query Builder component.",
                ActionDescription = new string[] {
                    @"This sample demonstrates the default functionalities of the Query Builder component. Click the plus button to add a group or conditions."
                },
                Description = new string[] {
                    @"This sample illustrates how to integrate the Data Grid component with the Query Builder.",
                    @"The Data Grid component will be refreshed while editing the filters in Query Builder.",
                    @"More information about Query Builder can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/aspnet-core-blazor/documentation/query-builder/getting-started/"">
                            documentation section
                        </a>."
                }
            }
        };
    }
}
