#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AIAssistview.Service
{
    public class AzureOpenAIRequest
    {
        public string ApiKey { get; set; }
        public string Endpoint { get; set; }
        public string Deployment { get; set; }
        public string Prompt { get; set; }
        public string ApiVersion { get; set; } = "2024-07-01-preview";
    }

    public class AIService
    {
        private readonly HttpClient _httpClient;

        public AIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetAzureOpenAIAssist(AzureOpenAIRequest req)
        {
            var url = $"{req.Endpoint.TrimEnd('/')}/openai/deployments/{Uri.EscapeDataString(req.Deployment)}/chat/completions?api-version={Uri.EscapeDataString(req.ApiVersion)}";

            var content = new StringContent(JsonSerializer.Serialize(new
            {
                messages = new[] { new { role = "user", content = req.Prompt } },
                temperature = 0.7,
                max_tokens = 200
            }), Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Headers.Add("api-key", req.ApiKey);
            request.Content = content;

            var response = await _httpClient.SendAsync(request);
            var data = await response.Content.ReadFromJsonAsync<JsonElement>();

            if (!response.IsSuccessStatusCode)
            {
                var apiMsg = data.GetProperty("error").GetProperty("message").GetString() ?? $"HTTP {response.StatusCode}";
                throw new Exception(apiMsg);
            }

            return data.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString()?.Trim() ?? "No response received.";
        }

        public async Task<string> GetGeminiAIAssist(string apiKey, string model, string prompt)
        {
            var url = $"https://generativelanguage.googleapis.com/v1beta/models/{Uri.EscapeDataString(model)}:generateContent?key={Uri.EscapeDataString(apiKey)}";

            var content = new StringContent(JsonSerializer.Serialize(new
            {
                contents = new[] { new { parts = new[] { new { text = prompt } } } }
            }), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            var data = await response.Content.ReadFromJsonAsync<JsonElement>();
            return data.GetProperty("candidates")[0].GetProperty("content").GetProperty("parts")[0].GetProperty("text").GetString();
        }

        public async Task<string> GetDeepSeekAIAssist(string apiKey, string prompt)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.deepseek.com/chat/completions")
            {
                Content = new StringContent(JsonSerializer.Serialize(new
                {
                    model = "deepseek - reasoner",
                    messages = new[] { new { role = "user", content = prompt } }
                }), Encoding.UTF8, "application/json")
            };
            request.Headers.Add("Authorization", $"Bearer {apiKey}");

            var response = await _httpClient.SendAsync(request);
            var data = await response.Content.ReadFromJsonAsync<JsonElement>();

            if (!response.IsSuccessStatusCode)
            {
                var error = data.TryGetProperty("error", out var err) ? err.ToString() : "Unknown error.";
                throw new HttpRequestException($"DeepSeek API call failed: {error}");
            }

            if (data.TryGetProperty("choices", out var choices) &&
                choices.GetArrayLength() > 0 &&
                choices[0].TryGetProperty("message", out var message) &&
                message.TryGetProperty("content", out var contentElement))
            {
                return contentElement.GetString() ?? string.Empty;
            }

            return string.Empty;

        }
    }
}
