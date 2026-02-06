#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Components;
namespace BlazorDemos.Shared
{
    /// <summary>
    /// A base component to perform common functionalities.
    /// </summary>
    public class SampleBaseComponent: ComponentBase
    {
        [Inject]
        protected SampleService? SampleService { get; set; }
        protected bool isNET10_0 { get; set; }
        protected bool isNET9_0 { get;  set; }
        protected bool isNET8_0 { get; set; }
        protected bool isRELEASE { get; set; }
        protected bool isSTAGING { get; set; }
        protected bool isDEBUG { get; set; }
        protected bool isSERVER { get; set; }
        protected bool isWASM { get; set; }
        protected override void OnInitialized()
        {
#if NET10_0
            isNET10_0 = true;
#endif
#if NET9_0
        isNET9_0 = true;
#endif
#if NET8_0
        isNET8_0 = true;
#endif
#if SERVER
        isSERVER = true;
#endif
#if WASM
         isWASM = true;
#endif
#if DEBUG
            isDEBUG = true;
#endif
#if RELEASE
        isRELEASE = true;
#endif
#if STAGING
            isSTAGING = true;
#endif
        }

    }
}