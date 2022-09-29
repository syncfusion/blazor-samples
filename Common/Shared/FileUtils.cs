#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
﻿using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemos
{
    public static class FileUtils
    {        
        public static async Task SaveAs(this IJSRuntime js, string filename, byte[] data)
        {
             await js.InvokeVoidAsync(
                      "sfBlazorSB.saveAsFile",
                      filename,
                      Convert.ToBase64String(data));
        }
    }
}
