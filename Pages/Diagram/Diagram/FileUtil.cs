using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_samples.Pages.Diagram.Diagram
{
    public class FileUtil
    {
        public async static Task SaveAs(IJSRuntime js, string data)
        {
            await js.InvokeAsync<object>(
                "saveDiagram",
                Convert.ToString(data));
        }
        public async static Task Click(IJSRuntime js)
        {
            await js.InvokeAsync<object>(
                "click");
        }
        public async static Task<string> LoadFile(IJSRuntime js, object data)
        {
            return await js.InvokeAsync<string>(
                  "loadFile", data);
        }

        public async static Task SetGradient(IJSRuntime js, int level)
        {
            await js.InvokeAsync<object>("setWaterLevel", level);
        }
    }
}
