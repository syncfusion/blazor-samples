#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemos
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
                Name = "Complex DataBinding",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/complex-databinding",
                FileName = "ComplexDataBinding.razor",
                NotificationDescription = new string []{@"Added the demo for binding nested columns in the QueryBuilder component."},
            },
            new Sample
            {
                Name = "Value Template",
                Category = "Templates",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/template",
                FileName = "Template.razor"
            },
            new Sample
            {
                Name = "Column Template",
                Category = "Templates",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/column-template",
                FileName = "ColumnTemplate.razor"
            },
             new Sample
            {
                Name = "Integration with Data Grid",
                Category = "Query Builder",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/grid",
                FileName = "Grid.razor"
            },
            new Sample
            {
                Name = "Header Template",
                Category = "Templates",
                Directory = "Forms/QueryBuilder",
                Url = "query-builder/header-template",
                FileName = "HeaderTemplate.razor"
            }
        };
    }
}
