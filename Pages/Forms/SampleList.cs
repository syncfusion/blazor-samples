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
                FileName = "DefaultFunctionalities.razor"
            }
        };
    }
}
