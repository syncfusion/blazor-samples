using System;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace blazor_samples.Shared
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
        protected IHttpContextAccessor HttpContextAccessor { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, RenderStyles());
            if(IsIE())
            {
                builder.AddMarkupContent(1, RenderPolyfill());
            }
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
            sb.Append($"    <link");
            sb.Append($" href=\"styles/common/index.css\"");
            sb.Append($" rel=\"stylesheet\"");
            sb.Append(" />");
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }
        private string RenderPolyfill()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Environment.NewLine);
            sb.Append($"    <script");
            sb.Append($" src=\"scripts/common/blazor.polyfill.min.js\"");
            sb.Append(">");
            sb.Append($"</script>");
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }

        private bool IsIE()
        {
            var userAgent = HttpContextAccessor.HttpContext.Request.Headers["User-Agent"].ToString();
            return userAgent.Contains("MSIE") || userAgent.Contains("Trident");
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
