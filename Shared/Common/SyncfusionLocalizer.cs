using Syncfusion.Blazor;

namespace BlazorDemos.Shared
{
    /// <summary>
    /// Extends ISyncfusionStringLocalizer for applying localization to Syncfusion components.
    /// </summary>
    public class SyncfusionLocalizer : ISyncfusionStringLocalizer
    {
        /// <summary>
        /// Get locale value from the resource file.
        /// </summary>
        /// <param name="key">Locale key for getting the translated text.</param>
        public string GetText(string key)
        {
            return this.ResourceManager.GetString(key);
        }

        /// <summary>
        /// Access the resource file and get the exact value from the locale key.
        /// </summary>
        public System.Resources.ResourceManager ResourceManager
        {
            get
            {
                return BlazorDemos.Resources.SfResources.ResourceManager;
            }
        }
    }
}
