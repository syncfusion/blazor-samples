#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;

namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> AIQueryBuilder { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Natural Language Query",
                Category = "Query Builder",
                Directory = "AISamples/QueryBuilder",
                Url = "ai-querybuilder/natural-languagequery",
                FileName = "NaturalLanguageQuery.razor",
                NotificationDescription = new string[]{ @" This demo shows the natural language querying AI feature in Query Builder." }
            }
        };
    }
}
