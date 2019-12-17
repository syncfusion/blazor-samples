using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace ej2_blazor_samples.Shared
{
    public class SampleBaseComponent: ComponentBase, IDisposable
    {
        [Inject]
        protected IJSRuntime jsRuntime { get; set; }

        internal SampleData SampleDetails { get; set; } = new SampleData();
        protected override void OnAfterRender(bool FirstRender)
        {
            if (FirstRender)
            {
                this.jsRuntime.InvokeVoidAsync("hideSpinner");
                //SampleBrowser.CurrentControl = SampleDetails.CurrentControl;
                //SampleBrowser.CurrentSampleName = SampleDetails.CurrentSampleName;
                //SampleBrowser.CurrentControlName = SampleDetails.CurrentControlName;
                //SampleBrowser.CurrentControlCategory = SampleDetails.CurrentControlCategory;
                //SampleBrowser.TitleTag = SampleDetails.TitleTag;
                //SampleBrowser.MetaDescription = SampleDetails.MetaDescription;
                //SampleBrowser.ActionDescription = SampleDetails.ActionDescription;
                //SampleBrowser.Description = SampleDetails.Description;
                //this.StateHasChanged();
            }
        }

        public void Dispose()
        {
           // jsRuntime.InvokeAsync<string>("contentDispose");
        }
    }
}
