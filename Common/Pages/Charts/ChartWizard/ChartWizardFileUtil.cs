using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.Charts.ChartWizard
{
    /// <summary>
    /// Provides JavaScript interop utilities for Chart Wizard file operations.
    /// Supports saving charts to files and loading chart configurations from files.
    /// </summary>
    public static class ChartWizardFileUtil
    {
        private const string JS_SAVE_DIAGRAM = "saveDiagram";
        private const string JS_CLICK = "click";
        private const string JS_LOAD_FILE = "loadFile";

        /// <summary>
        /// Saves chart data to a file using browser download functionality.
        /// </summary>
        /// <param name="js">The JavaScript runtime for interop.</param>
        /// <param name="data">The chart data to save (JSON format).</param>
        /// <param name="fileName">The name of the file to save (without extension).</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <exception cref="ArgumentNullException">Thrown when required parameters are null or empty.</exception>
        public static async Task SaveAsAsync(IJSRuntime js, string data, string fileName)
        {
            if (js == null)
                throw new ArgumentNullException(nameof(js), "Custom error message");
            if (string.IsNullOrWhiteSpace(data))
                throw new ArgumentNullException(nameof(data), "Custom error message");
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentNullException(nameof(fileName), "Custom error message");

            await js.InvokeVoidAsync(JS_SAVE_DIAGRAM, data, fileName).ConfigureAwait(true);
        }

        /// <summary>
        /// Triggers the file picker dialog to open a file.
        /// </summary>
        /// <param name="js">The JavaScript runtime for interop.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <exception cref="ArgumentNullException">Thrown when js is null.</exception>
        public static async Task OpenFilePickerAsync(IJSRuntime js)
        {
            if (js == null)
                throw new ArgumentNullException(nameof(js), "Custom error message");

            await js.InvokeVoidAsync(JS_CLICK).ConfigureAwait(true);
        }

        /// <summary>
        /// Loads file content from the browser file input.
        /// </summary>
        /// <param name="js">The JavaScript runtime for interop.</param>
        /// <param name="fileData">The file data object from the uploader component.</param>
        /// <returns>The file content as a string, or empty string if file cannot be read.</returns>
        /// <exception cref="ArgumentNullException">Thrown when js or fileData is null.</exception>
        public static async Task<string> LoadFileAsync(IJSRuntime js, object fileData)
        {
            if (js == null)
                throw new ArgumentNullException(nameof(js), "Custom error message");
            if (fileData == null)
                throw new ArgumentNullException(nameof(fileData), "Custom error message");

            string content = await js.InvokeAsync<string>(JS_LOAD_FILE, fileData).ConfigureAwait(true);
            return content ?? string.Empty;
        }
    }
}
