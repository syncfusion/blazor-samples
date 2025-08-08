#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorDemos.Shared
{
    /// <summary>
    /// A base component to perform common functionalities.
    /// </summary>
    public class SampleBaseComponent: ComponentBase
    {
        [Inject]
        protected SampleService SampleService { get; set; }

#if WASM && NET9_0
        protected override async Task OnAfterRenderAsync(bool firstRender)
#else
        protected override void OnAfterRender(bool firstRender)
#endif
        {
            base.OnAfterRender(firstRender);
            // await for mobile or desktop rendering.
            #if WASM && NET9_0
                await Task.Delay(500); 
            #endif
            SampleService.Spinner?.Hide();
            SampleService.Spinner?.ShowModalSpinner();
        }
    }
}
