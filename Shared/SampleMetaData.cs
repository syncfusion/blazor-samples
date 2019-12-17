using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Text;

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

    public class SampleDocumentMetadataComponent : ComponentBase, IDisposable
    {
        [Inject] public NavigationManager UriHelper { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, GetContent());
        }

        string GetContent()
        {
            SampleBrowser.UpdateSampleData(UriHelper.Uri);
            StringBuilder sb = new StringBuilder();
            sb.Append($"<title>");
            sb.Append(SampleBrowser.TitleTag);
            sb.Append($"</title>");
            sb.Append(Environment.NewLine);
            sb.Append($"<meta");
            sb.Append($" name =\"description\"");
            sb.Append($" content =\"{SampleBrowser.MetaDescription}\"");
            sb.Append(">");           
          
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }

        public void Dispose()
        {
            UriHelper = null;
        }

        
    }

}
