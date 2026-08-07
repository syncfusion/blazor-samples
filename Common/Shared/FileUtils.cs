using Microsoft.JSInterop;
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
                      data).ConfigureAwait(true);
        }
    }
}
