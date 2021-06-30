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
