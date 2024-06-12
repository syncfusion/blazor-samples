#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Text;


namespace BlazorDemos.Shared
{
    public class AddHeaderTag : ComponentBase, IDisposable
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected SampleService SampleService { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, AddHeadingTag());

        }

        private string AddHeadingTag()
        {
            SampleService.Update(UriHelper);
            StringBuilder sb = new StringBuilder();
            sb.Append(Environment.NewLine);
            //creating h1 tag using Meta data content generation for component demos
            if (SampleService.ComponentName != null && SampleService.SampleInfo != null)
            {
                var componentName = SampleService.SampleInfo.Directory == "Buttons/Button" ? "Button" : SampleService.ComponentName;
                componentName = SampleService.SampleInfo.Directory.IndexOf("DocumentProcessing/") >= 0 ? componentName + " Library -" : componentName;
                var sampleInfo = SampleService.SampleInfo;
                var sampleName = sampleInfo.MappingSampleName != null && !UriHelper.Uri.Contains(sampleInfo.Url) ? sampleInfo.MappingSampleName : sampleInfo.Name;
                sb.Append($"<h1");
                sb.Append($" style=\"display:none;\"");
                sb.Append(">");
                var metaTitle = string.IsNullOrEmpty(sampleInfo.MetaTitle) ? "Blazor " + componentName + SampleUtils.SPACE + sampleName + " Example - Syncfusion Demos" : sampleInfo.MetaTitle;
                sb.Append(metaTitle);
                sb.Append($"</h1>");
                sb.Append(Environment.NewLine);
            }
            //creating h1 tag using Meta data content generation for home page.
            else
            {
                sb.Append($"<h1");
                sb.Append($" style=\"display:none;\"");
                sb.Append(">");
                sb.Append("Blazor Components Examples & Demos | Syncfusion");
                sb.Append($"</h1>");
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }



        /// <summary>
        /// Re-rendering the component with current sample's meta data.
        /// </summary>
        public void Refresh()
        {
            StateHasChanged();
        }


        public void Dispose()
        {
            SampleService.MetaData = null;
        }

    }

}

