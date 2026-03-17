#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Diagnostics;

namespace BlazorDemos.Components
{
    public partial class App
    {
        private bool isNET10_0 { get; set; }
        private bool isNET9_0 { get; set; }
        private bool isNET8_0 { get; set; }
        private bool isRELEASE { get; set; }
        private bool isSTAGING { get; set; }
        private bool isDEBUG { get; set; }
        private bool isBuild { get; set; }

#if NET8_0
        protected Dictionary<string, string> Assets { get; } = new()
        {
            { "Blazor_Server_Demos_NET9.styles.css", "Blazor_Server_Demos_NET9.styles.css" },
            { "Blazor_Server_Demos_NET10.styles.css", "Blazor_Server_Demos_NET10.styles.css" }
        };
#endif


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
#if DEBUG
            isDEBUG = true;
#endif
#if RELEASE
        isRELEASE = true;
#endif
#if STAGING
            isSTAGING = true;
#endif
#if BUILD_ENV
            isBuild = true;
#endif

        }
    }
}
