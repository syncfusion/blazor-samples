using System;
using System.Text;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorDemos.Shared
{
    /// <summary>
    /// A component to render the dynamic resources like themes, polyfill.
    /// </summary>
    public class DynamicResources : ComponentBase
    {
        private string stylePath { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }
        [Inject]
        protected SampleService SampleService { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, RenderStyles());
            builder.AddMarkupContent(1, RenderResources());
        }

        private string RenderStyles()
        {
            var themeName = SampleUtils.GetThemeName(UriHelper.Uri);
            StringBuilder sb = new StringBuilder();
            sb.Append(Environment.NewLine);
            sb.Append($"    <link");
            sb.Append($" href=\"{ stylePath + themeName + ".css"}\"");
            sb.Append($" rel=\"stylesheet\"");
            sb.Append(" />");
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }

        private string RenderResources()
        {
            StringBuilder sb = new StringBuilder();
            var resources = SampleUtils.GetDynamicResources(UriHelper, SampleService);
            foreach (var resource in resources)
            {
                sb.Append(Environment.NewLine);
                if (resource.EndsWith(".css"))
                {
                    sb.Append($"    <link");
                    sb.Append($" href=\"" + resource + "\"");
                    sb.Append($" rel=\"stylesheet\"");
                    sb.Append(" />");
                }
                else
                {
                    sb.Append($"    <script");
                    sb.Append($" src=\"" + resource + "\"");
                    sb.Append($" async");
                    sb.Append(" ></script>");
                }
            }
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
#if (DEBUG || STAGING)
            stylePath = "_content/Syncfusion.Blazor.Themes/";
#else
            stylePath = "https://cdn.syncfusion.com/blazor/styles/";
#endif
        }
    }
}
