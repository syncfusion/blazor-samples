using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Globalization;
using System.Text;

namespace BlazorDemos.Shared
{
    /// <summary>
    /// A component to render the application's meta data based on current component and sample information.
    /// </summary>
    public class SampleMetaData : ComponentBase
    {
        [Inject]
        protected NavigationManager? UriHelper { get; set; }

        [Inject]
        protected SampleService? SampleService { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            ArgumentNullException.ThrowIfNull(builder);
            builder.AddMarkupContent(0, GetContent());
            builder.AddMarkupContent(1, RenderCanonicalTag());
            builder.AddMarkupContent(2, RenderHrefLangTags());
        }

        private string GetContent()
        {

            string ogImage = "https://cdn.syncfusion.com/content/images/company-logos/Syncfusion_Logo_Image.png";
            if(UriHelper != null && UriHelper.Uri != UriHelper.BaseUri + "error")SampleService?.Update(UriHelper);
            StringBuilder sb = new StringBuilder();
            sb.Append(Environment.NewLine);
            // Meta data content generation for component demos.
            if (SampleService?.ComponentName != null && SampleService.SampleInfo != null)
            {
                var componentName = SampleService.SampleInfo.Directory == "Buttons/Button" ? "Button" : SampleService.ComponentName;
                componentName = (SampleService.SampleInfo.Directory)?.IndexOf("DocumentProcessing/", StringComparison.Ordinal) >= 0 ? componentName + " Library -" : componentName;
                var sampleInfo = SampleService.SampleInfo;
                var sampleName = sampleInfo.Name;
                sb.Append($"<title>");
                var metaTitle = string.IsNullOrEmpty(sampleInfo.MetaTitle) ? "Blazor " + componentName + SampleUtils.Space + sampleName + " Example - Syncfusion Demos" : sampleInfo.MetaTitle ;
                sb.Append(metaTitle);
                sb.Append($"</title>");
                sb.Append(Environment.NewLine);
                sb.Append($"<meta");
                sb.Append($" name =\"description\"");
                var metaDescription = string.IsNullOrEmpty(sampleInfo.MetaDescription) ? "This example demonstrates the essential features and functionalities of " + sampleName + " in Blazor " + componentName + " Component. Explore more details here for additional insights." : sampleInfo.MetaDescription;
                sb.Append(CultureInfo.InvariantCulture, $" content =\"{metaDescription}\"");
                sb.Append('>');
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
                sb.Append(CultureInfo.InvariantCulture, $" content =\"{metaDescription}\"");
                sb.Append('>');
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
            sb.Append(Environment.NewLine);
            sb.Append($"    <link");
            sb.Append($" rel=\"canonical\"");
            string href = UriHelper?.Uri ?? string.Empty;
            href = !string.IsNullOrEmpty(SampleService?.SampleInfo?.CustomCanonicalUrl) ? SampleService.SampleInfo.CustomCanonicalUrl : new Uri(href).GetLeftPart(UriPartial.Path);
            sb.Append(CultureInfo.InvariantCulture, $" href=\"{href}\"");
            sb.Append(" />");
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }

        /// <summary>
        /// Renders hreflang alternate link tags for multi-language SEO support.
        /// These tags indicate alternative language versions of the page to search engines.
        /// </summary>
        private string RenderHrefLangTags()
        {
            StringBuilder sb = new StringBuilder();
            string href = UriHelper?.Uri ?? string.Empty;
            
            if (!string.IsNullOrEmpty(href))
            {
                href = new Uri(href).GetLeftPart(UriPartial.Path);
                
                sb.Append(Environment.NewLine);
                sb.Append($"    <link");
                sb.Append($" rel=\"alternate\"");
                sb.Append($" hreflang=\"en\"");
                sb.Append(CultureInfo.InvariantCulture, $" href=\"{href}\"");
                sb.Append(" />");
                sb.Append(Environment.NewLine);
            }
            
            return sb.ToString();
        }

        /// <summary>
        /// Appends Open Graph meta tags for link previews on social media platforms like Facebook and LinkedIn.These tags define how the page title, description, URL, and image are displayed when shared.
        /// </summary>
        private void AppendOpenGraphTags(StringBuilder sb, string title, string description, string image)
        {
            sb.AppendLine(CultureInfo.InvariantCulture, $"<meta property=\"og:title\" content=\"{title}\" />");
            sb.AppendLine(CultureInfo.InvariantCulture, $"<meta property=\"og:description\" content=\"{description}\" />");
            sb.AppendLine(CultureInfo.InvariantCulture, $"<meta property=\"og:url\" content=\"{UriHelper?.Uri}\" />");
            sb.AppendLine($"<meta property=\"og:type\" content=\"website\" />");
            sb.AppendLine($"<meta property=\"og:site_name\" content=\"Syncfusion Blazor Demos\" />");
            sb.AppendLine(CultureInfo.InvariantCulture, $"<meta property=\"og:image\" content=\"{image}\" />");
        }

        /// <summary>
        /// Appends Twitter Card meta tags to control how the page appears when shared on Twitter for better visibility and branding.
        /// </summary>
        private void AppendTwitterCardTags(StringBuilder sb, string title, string description, string image)
        {
            sb.AppendLine($"<meta name=\"twitter:account_id\" content=\"41152441\" />");
            sb.AppendLine(CultureInfo.InvariantCulture, $"<meta name=\"twitter:url\" content=\"{UriHelper?.Uri}\" />");
            sb.AppendLine(CultureInfo.InvariantCulture, $"<meta name=\"twitter:title\" content=\"{title}\" />");
            sb.AppendLine($"<meta name=\"twitter:card\" content=\"summary\" />");
            sb.AppendLine(CultureInfo.InvariantCulture, $"<meta name=\"twitter:description\" content=\"{description}\" />");
            sb.AppendLine(CultureInfo.InvariantCulture, $"<meta name=\"twitter:image\" content=\"{image}\" />");
        }

        /// <summary>
        /// Generates structured data in JSON-LD format.This improves SEO by helping search engines understand the content and context of the page.
        /// </summary>
        private string GetSchemaJson()
        {
            if (SampleService?.ComponentName != null && SampleService.SampleInfo != null)
            {
                var sampleInfo = SampleService.SampleInfo;
                var headline = sampleInfo.MetaTitle ?? $"Blazor {SampleService.ComponentName} - {sampleInfo.Name}";
                var description = sampleInfo.MetaDescription ?? $"Explore how to use {sampleInfo.Name} in Blazor {SampleService.ComponentName}.";
                var canonicalUrl = UriHelper?.Uri ?? string.Empty;
                var baseUri = UriHelper?.BaseUri?.TrimEnd('/') ?? string.Empty;
                var componentSlug = sampleInfo.Directory?.Split('/')[0] ?? string.Empty;
                var componentDemosUrl = $"{baseUri}/{componentSlug}";

                return $@"
{{
  ""@context"": ""https://schema.org"",
  ""@graph"": [
    {{
      ""@type"": ""WebApplication"",
      ""@id"": ""{canonicalUrl}#webapp"",
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
    }},
    {{
      ""@type"": ""BreadcrumbList"",
      ""@id"": ""{canonicalUrl}#breadcrumb"",
      ""itemListElement"": [
        {{
          ""@type"": ""ListItem"",
          ""position"": 1,
          ""name"": ""Blazor Demos"",
          ""item"": ""{baseUri}/""
        }},
        {{
          ""@type"": ""ListItem"",
          ""position"": 2,
          ""name"": ""{SampleService.ComponentName}"",
          ""item"": ""{componentDemosUrl}""
        }},
        {{
          ""@type"": ""ListItem"",
          ""position"": 3,
          ""name"": ""{sampleInfo.Name}"",
          ""item"": ""{canonicalUrl}""
        }}
      ]
    }}
  ]
}}";
            }
            else
            {
                var canonicalUrl = UriHelper?.Uri ?? string.Empty;
                var baseUri = UriHelper?.BaseUri?.TrimEnd('/') ?? string.Empty;

                return $@"
{{
  ""@context"": ""https://schema.org"",
  ""@graph"": [
    {{
      ""@type"": ""WebApplication"",
      ""@id"": ""{canonicalUrl}#webapp"",
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
    }},
    {{
      ""@type"": ""BreadcrumbList"",
      ""@id"": ""{canonicalUrl}#breadcrumb"",
      ""itemListElement"": [
        {{
          ""@type"": ""ListItem"",
          ""position"": 1,
          ""name"": ""Blazor Demos"",
          ""item"": ""{baseUri}/""
        }}
      ]
    }}
  ]
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
            if (firstRender && SampleService != null)
            {
                SampleService.MetaData = this;
            }
        }

        public void Dispose()
        {
            if (SampleService != null) SampleService.MetaData = null;
        }
    }
}
