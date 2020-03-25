using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_samples
{
    public static class FileUtils
    {        
        public static ValueTask<object> SaveAs(this IJSRuntime js, string filename, byte[] data)
        {
            return js.InvokeAsync<object>(
                      "saveAsFile",
                      filename,
                      Convert.ToBase64String(data));
        }
    }
}
