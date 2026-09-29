using System.Text.Json;
using Markdig;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System;
using System.Net.Http.Json;

namespace AIAssistViewAzureAI.Components.Services
{
    public class AzureOpenAIService
    {
        private readonly HttpClient _httpClient;
        private readonly string _endpoint;
        private readonly string _apiKey;
        private readonly string _deploymentName;

        public AzureOpenAIService(HttpClient httpClient, string endpoint, string apiKey, string deploymentName)
        {
            _httpClient = httpClient;
            _endpoint = endpoint;
            _apiKey = apiKey;
            _deploymentName = deploymentName;
        }

        public async IAsyncEnumerable<string> GetChatResponseStreamAsync(string prompt)
        {
            var request = new
            {
                messages = new[] { new { role = "user", content = prompt } },
                max_tokens = 500,
            };

            var url = $"{_endpoint}/openai/deployments/{_deploymentName}/chat/completions?api-version=2024-02-15-preview";
            _httpClient.DefaultRequestHeaders.Add("api-key", _apiKey);

            List<string> results = new List<string>();

            try
            {
                var response = await _httpClient.PostAsJsonAsync(url, request).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    {
                        using var jsonDocument = await JsonDocument.ParseAsync(responseStream).ConfigureAwait(false);
                        var choices = jsonDocument.RootElement.GetProperty("choices");
                        if (choices.GetArrayLength() > 0)
                        {
                            var content = choices[0].GetProperty("message").GetProperty("content").GetString();
                            var htmlContent = Markdown.ToHtml(content ?? string.Empty);
                            htmlContent = Regex.Replace(htmlContent, @"\s+", " ").Trim();
                            // Collect each character to the results list before yielding
                            foreach (var chunk in htmlContent)
                            {
                                results.Add(chunk.ToString());
                            }
                        }
                        else
                        {
                            results.Add("Error: No choices returned in the response.");
                        }
                    }
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    results.Add($"Error: {error}");
                }
            }
            catch (HttpRequestException)
            {
                // Collect the error message to be yielded later
                results.Add( "⚠️ Something went wrong while connecting to the OpenAI service. Please check your API key or try again later.") ;
            }
            catch (JsonException)
            {
                // Collect the error message to be yielded later
                results.Add( "⚠️ Something went wrong while connecting to the OpenAI service. Please check your API key or try again later.") ;
            }

            // Now yield each collected result
            foreach (var result in results)
            {
                yield return result;
            }
        }
    }
}