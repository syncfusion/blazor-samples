#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Text;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorDemos.Shared
{
    /// <summary>
    /// A component to render the application's meta data based on current component and sample information.
    /// </summary>
    public class SampleMetaData : ComponentBase, IDisposable
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected SampleService SampleService { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, GetContent());
            builder.AddMarkupContent(1, RenderCanonicalTag());
        }

        private string GetContent()
        {

            string ogImage = "https://cdn.syncfusion.com/content/images/company-logos/Syncfusion_Logo_Image.png";
            SampleService.Update(UriHelper);
            StringBuilder sb = new StringBuilder();
            sb.Append(Environment.NewLine);
            // Meta data content generation for component demos.
            if (SampleService.ComponentName != null && SampleService.SampleInfo != null)
            {
                var componentName = SampleService.SampleInfo.Directory == "Buttons/Button" ? "Button" : SampleService.ComponentName;
                componentName = (SampleService.SampleInfo.Directory).IndexOf("DocumentProcessing/") >= 0 ? componentName + " Library -" : componentName;
                var sampleInfo = SampleService.SampleInfo;
                var sampleName = sampleInfo.MappingSampleName != null && !UriHelper.Uri.Contains(sampleInfo.Url) ? sampleInfo.MappingSampleName : sampleInfo.Name;
                sb.Append($"<title>");
                var metaTitle = string.IsNullOrEmpty(sampleInfo.MetaTitle) ? "Blazor " + componentName + SampleUtils.SPACE + sampleName + " Example - Syncfusion Demos" : sampleInfo.MetaTitle ;
                sb.Append(metaTitle);
                sb.Append($"</title>");
                sb.Append(Environment.NewLine);
                sb.Append($"<meta");
                sb.Append($" name =\"description\"");
                var metaDescription = string.IsNullOrEmpty(sampleInfo.MetaDescription) ? "This example demonstrates the essential features and functionalities of " + sampleName + " in Blazor " + componentName + " Component. Explore more details here for additional insights." : sampleInfo.MetaDescription;
                sb.Append($" content =\"{metaDescription}\"");
                sb.Append(">");
                sb.Append(Environment.NewLine);

                // Open Graph and Twitter tags
                AppendOpenGraphTags(sb, metaTitle, metaDescription, ogImage);
                AppendTwitterCardTags(sb, metaTitle, metaDescription, ogImage);


            }
            // Meta data content generation for home page.
            else
            {
                var metaTitle = "Blazor Components Examples & Demos | Syncfusion";
                var metaDescription = "Explore and learn Syncfusion Blazor components using large collection of demos, example applications and tutorial samples.";
                sb.Append($"<title>");
                sb.Append(metaTitle);
                sb.Append($"</title>");
                sb.Append(Environment.NewLine);
                sb.Append($"<meta");
                sb.Append($" name =\"description\"");
                sb.Append($" content =\"{metaDescription}\"");
                sb.Append(">");
                sb.Append(Environment.NewLine);

                //Appends Open Graph and Twitter tags
                AppendOpenGraphTags(sb, metaTitle, metaDescription, ogImage);
                AppendTwitterCardTags(sb, metaTitle, metaDescription, ogImage);

            }

            //Appends schema.org structured data
            string schemaJson = GetSchemaJson();
            if (!string.IsNullOrWhiteSpace(schemaJson))
            {
                sb.AppendLine("<script type=\"application/ld+json\">");
                sb.AppendLine(schemaJson);
                sb.AppendLine("</script>");
            }

            return sb.ToString();       
        }

        private string RenderCanonicalTag()
        {
            StringBuilder sb = new StringBuilder();
            string[] canonicalUrl = UriHelper.Uri.Split("?");
            sb.Append(Environment.NewLine);
            sb.Append($"    <link");
            sb.Append($" rel=\"canonical\"");
            sb.Append($" href=\"{canonicalUrl[0]}\"");
            sb.Append(" />");
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }

        /// <summary>
        /// Appends Open Graph meta tags for link previews on social media platforms like Facebook and LinkedIn.These tags define how the page title, description, URL, and image are displayed when shared.
        /// </summary>
        private void AppendOpenGraphTags(StringBuilder sb, string title, string description, string image)
        {
            sb.AppendLine($"<meta property=\"og:title\" content=\"{title}\" />");
            sb.AppendLine($"<meta property=\"og:description\" content=\"{description}\" />");
            sb.AppendLine($"<meta property=\"og:url\" content=\"{UriHelper.Uri}\" />");
            sb.AppendLine($"<meta property=\"og:type\" content=\"website\" />");
            sb.AppendLine($"<meta property=\"og:site_name\" content=\"Syncfusion Blazor Demos\" />");
            sb.AppendLine($"<meta property=\"og:image\" content=\"{image}\" />");
        }

        /// <summary>
        /// Appends Twitter Card meta tags to control how the page appears when shared on Twitter for better visibility and branding.
        /// </summary>
        private void AppendTwitterCardTags(StringBuilder sb, string title, string description, string image)
        {
            sb.AppendLine($"<meta name=\"twitter:account_id\" content=\"41152441\" />");
            sb.AppendLine($"<meta name=\"twitter:url\" content=\"{UriHelper.Uri}\" />");
            sb.AppendLine($"<meta name=\"twitter:title\" content=\"{title}\" />");
            sb.AppendLine($"<meta name=\"twitter:card\" content=\"summary\" />");
            sb.AppendLine($"<meta name=\"twitter:description\" content=\"{description}\" />");
            sb.AppendLine($"<meta name=\"twitter:image\" content=\"{image}\" />");
        }

        /// <summary>
        /// Generates structured data in JSON-LD format.This improves SEO by helping search engines understand the content and context of the page.
        /// </summary>
        private string GetSchemaJson()
        {
            if (SampleService.ComponentName != null && SampleService.SampleInfo != null)
            {
                var sampleInfo = SampleService.SampleInfo;
                var headline = sampleInfo.MetaTitle ?? $"Blazor {SampleService.ComponentName} - {sampleInfo.Name}";
                var description = sampleInfo.MetaDescription ?? $"Explore how to use {sampleInfo.Name} in Blazor {SampleService.ComponentName}.";

                return $@"
{{
  ""@context"": ""https://schema.org"",
  ""@type"": ""WebApplication"",
  ""headline"": ""{headline}"",
  ""description"": ""{description}"",
  ""author"": {{
    ""@type"": ""Organization"",
    ""name"": ""Syncfusion""
  }},
  ""publisher"": {{
    ""@type"": ""Organization"",
    ""name"": ""Syncfusion"",
    ""logo"": {{
      ""@type"": ""ImageObject"",
      ""url"": ""https://cdn.syncfusion.com/content/images/company-logos/Syncfusion_Logo_Image.png""
    }}
  }}
}}";
            }
            else
            {
                return $@"
{{
  ""@context"": ""https://schema.org"",
  ""@type"": ""WebApplication"",
  ""headline"": ""Blazor Components Examples & Demos | Syncfusion"",
  ""description"": ""Explore and learn Syncfusion Blazor components using large collection of demos, example applications and tutorial samples."",
  ""author"": {{
    ""@type"": ""Organization"",
    ""name"": ""Syncfusion""
  }},
  ""publisher"": {{
    ""@type"": ""Organization"",
    ""name"": ""Syncfusion"",
    ""logo"": {{
      ""@type"": ""ImageObject"",
      ""url"": ""https://cdn.syncfusion.com/blazor/images/demos/syncfusion-logo.svg""
    }}
  }}
}}";
            }
        }


        /// <summary>
        /// Re-rendering the component with current sample's meta data.
        /// </summary>
        public void Refresh()
        {
            StateHasChanged();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            
            // Assign meta data ref to sample service for outside usage.
            if (firstRender)
            {
                SampleService.MetaData = this;
            }
        }

        public void Dispose()
        {
            SampleService.MetaData = null;
        }
    }
}
