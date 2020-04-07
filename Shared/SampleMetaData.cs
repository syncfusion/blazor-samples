using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Text;
using Microsoft.AspNetCore.Components.Routing;

namespace blazor_samples.Shared
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
            string path = UriHelper.Uri;
            var length = UriHelper.BaseUri.Length;
            string fileName = path.Remove(0, length);
            if (fileName.IndexOf("?") >= 0)
            {
                fileName = fileName.Substring(0, fileName.IndexOf("?"));
            }
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
                var CategoryName = "Data Grid";
                var SampleName = "Overview";
                string[] ControlName = fileName.Split("/");
                if (!string.IsNullOrEmpty(fileName))
                {
                    
                    CategoryName = ControlName[ControlName.Length - 2];
                    SampleName = ControlName[ControlName.Length - 1].Replace("-","");
                   // CategoryName = char.ToUpper(CategoryName[0]) + CategoryName.Substring(1);
                    var CurrentControl = SampleBrowser.SampleList.First<SampleList>(control => control.ControllerName.ToLower().Equals(CategoryName));
                    var CurrentSample = CurrentControl?.Samples.Where((sample) => sample.FileName.ToLower() == (SampleName + ".razor")).First();
                    SampleName = CurrentSample?.MappingSampleName != null ? CurrentSample?.MappingSampleName : SampleName;
                }

                sb.Append($"<title>");
                sb.Append("Blazor " + CategoryName + " " + SampleName + " Example - Syncfusion Demos");
                sb.Append($"</title>");
                sb.Append(Environment.NewLine);
                sb.Append($"<meta");
                sb.Append($" name =\"description\"");
                sb.Append($" content =\"{"This example demonstrates the " + SampleName + " in Blazor " + CategoryName + " Component. Explore here for more details."}\"");
                //sb.Append($" content =\"{Service.Data.CurrentSample.MetaDescription}\"");
                sb.Append(">");

                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
