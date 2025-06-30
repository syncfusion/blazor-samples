#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
                MetaTitle = "Blazor Natural Language Query - Syncfusion AI Demos",
                HeaderText = "Blazor Query Builder Example - Natural Language Query Processing",
                MetaDescription = "This Blazor Query Builder AI demo demonstrates natural language query processing capabilities. Convert plain English queries into structured filter conditions automatically for intuitive data filtering without complex syntax.",
                NotificationDescription = new string[]{ @" This demo shows the natural language querying AI feature in Query Builder." }
            }
        };
    }
}
