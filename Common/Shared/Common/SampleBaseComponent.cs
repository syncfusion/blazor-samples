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
        protected bool isNET10 { get; set; }
        protected bool isNET9 { get;  set; }
        protected bool isNET8 { get; set; }
        protected bool isRELEASE { get; set; }
        protected bool isSTAGING { get; set; }
        protected bool isDEBUG { get; set; }
        protected bool isSERVER { get; set; }
        protected bool isWASM { get; set; }
        protected override void OnInitialized()
        {
#if NET10_0
            isNET10 = true;
#endif
#if NET9_0
        isNET9 = true;
#endif
#if NET8_0
        isNET8 = true;
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