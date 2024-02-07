#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemos.Pages
{

#pragma warning disable CA1052 // Static holder types should be Static or NotInheritable
    public class FileUtil
#pragma warning restore CA1052 // Static holder types should be Static or NotInheritable
    {
        public async static Task SaveAs(IJSRuntime js, string data, string fileName)
        {
            await js.InvokeAsync<object>(
                "saveDiagram",
#pragma warning disable CA1305 // Specify IFormatProvider
                Convert.ToString(data), fileName).ConfigureAwait(true);
#pragma warning restore CA1305 // Specify IFormatProvider
        }
        public async static Task Click(IJSRuntime js)
        {
            await js.InvokeAsync<object>(
                "click").ConfigureAwait(true);
        }
        public async static Task<string> LoadFile(IJSRuntime js, object data)
        {
            return await js.InvokeAsync<string>(
                  "loadFile", data).ConfigureAwait(true);
        }

        //public async static Task SetGradient(IJSRuntime js, int level)
        //{
        //    await js.InvokeAsync<object>("setWaterLevel", level).ConfigureAwait(true);
        //}
    }
}
