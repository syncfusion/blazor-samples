using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> QueryBuilder { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Template",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/template",
                FileName = "Template.razor"
            },
             new Sample
            {
                Name = "Integration with Data Grid",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/grid",
                FileName = "Grid.razor"
            }
        };
    }
}
