using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Blazor;

namespace blazor_samples.Shared
{
    public class SyncfusionLocalizer : ISyncfusionStringLocalizer
    {

        public string GetText(string key)
        {
            return this.ResourceManager.GetString(key);
         }

    // To access the resource file and get the exact value for locale key

    public System.Resources.ResourceManager ResourceManager
    {
        get
        {
            // Replace the ApplicationNamespace with your application name.
            return blazor_samples.Resources.SfResources.ResourceManager;
        }
    }

}
}
