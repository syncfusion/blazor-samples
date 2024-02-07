#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
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
                FileName = "DefaultFunctionalities.razor"
            }
        };
    }
}