using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.Diagram.Diagram
{
    public static class FileUtil
    {
        public async static Task SaveAs(IJSRuntime js, string data)
        {
#pragma warning disable CA1305 // Specify IFormatProvider
            _ = await js.InvokeAsync<object>("sfBlazorSB.saveDiagram", Convert.ToString(data)).ConfigureAwait(false);
#pragma warning restore CA1305 // Specify IFormatProvider
        }
        public async static Task Click(IJSRuntime js)
        {
            await js.InvokeAsync<object>("sfBlazorSB.uploadFilesClick").ConfigureAwait(false);
        }
        public async static Task<string> LoadFile(IJSRuntime js, object data)
        {
            return await js.InvokeAsync<string>("sfBlazorSB.loadFile", data).ConfigureAwait(false);
        }
    }
}
