using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
		public List<Sample> Listview { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Listview",
                Directory = "Layouts/Listview",
                Url = "Listview/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Checklist",
                Category = "Listview",
                Directory = "Layouts/Listview",
                Url = "Listview/Checklist",
                FileName = "Checklist.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Nested List",
                Category = "Listview",
                Directory = "Layouts/Listview",
                Url = "Listview/NestedList",
                FileName = "NestedList.razor",
                Type = SampleType.New
            },
			new Sample
            {
                Name = "Template",
                Category = "Listview",
                Directory = "Layouts/Listview",
                Url = "Listview/GroupTemplate",
                FileName = "ListGroupTemplate.razor",
                Type = SampleType.New
            },
        };
         public List<Sample> DashboardLayout { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Url = "DashboardLayout/Default",
                FileName = "Default.razor"
            },
            new Sample
            {
                Name = "API",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Url = "DashboardLayout/API",
                FileName = "API.razor"
            }
        };
        public List<Sample> Splitter { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Splitter",
                Directory = "Layouts/Splitter",
                Url = "Splitter/Default",
                FileName = "Default.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Expand and Collapse",
                Category = "Splitter",
                Directory = "Layouts/Splitter",
                Url = "Splitter/ExpandandCollapse",
                FileName = "ExpandandCollapse.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Code Editor Layout",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "Splitter/CodeEditorLayout",
                FileName = "CodeEditorLayout.razor",
                Type = SampleType.New
            }
        };
    }

   


}
