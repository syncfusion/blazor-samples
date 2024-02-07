#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
