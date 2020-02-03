using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Text;
using Microsoft.AspNetCore.Components.Routing;

namespace ej2_blazor_samples.Shared
{
    public class SampleMetaData : ComponentBase
    {

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.AddContent(0, new MarkupString(Environment.NewLine));
            builder.OpenComponent<SampleDocumentMetadataComponent>(1);
            builder.CloseComponent();            
        }
    }

    public class SampleDocumentMetadataComponent : ComponentBase
    {
        [Inject] public NavigationManager UriHelper { get; set; }

        [Inject]
        protected SampleService Service { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, GetContent());
        }

        string GetContent()
        {
            Service.Data.Update(UriHelper);
            StringBuilder sb = new StringBuilder();
            if (Service.Data.CurrentSample != null)
            {
                sb.Append($"<title>");
                sb.Append("Blazor " + Service.Data.CurrentControl.Name + " " + Service.Data.CurrentSample.Name + " Example - Syncfusion Demos");
                sb.Append($"</title>");
                sb.Append(Environment.NewLine);
                sb.Append($"<meta");
                sb.Append($" name =\"description\"");
                sb.Append($" content =\"{"This example demonstrates the " + Service.Data.CurrentSample.Name + " in Blazor " + Service.Data.CurrentControl.Name + " Component. Explore here for more details."}\"");
                //sb.Append($" content =\"{Service.Data.CurrentSample.MetaDescription}\"");
                sb.Append(">");

                sb.Append(Environment.NewLine);
            } else
            {
                sb.Append($"<title>");
                sb.Append("Blazor Data Grid Default Functionalities Example - Syncfusion Demos");
                sb.Append($"</title>");
                sb.Append(Environment.NewLine);
                sb.Append($"<meta");
                sb.Append($" name =\"description\"");
                sb.Append($" content =\"{"This example demonstrates the Default Functionalities in Blazor Data Grid Component. Explore here for more details."}\"");
                //sb.Append($" content =\"{Service.Data.CurrentSample.MetaDescription}\"");
                sb.Append(">");

                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
                
    }

}
