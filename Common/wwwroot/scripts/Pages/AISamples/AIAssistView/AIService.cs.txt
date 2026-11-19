using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorDemos.Service;

namespace AIAssistview.Service
{
    public class AzureOpenAIRequest
    {
        public string ApiKey { get; set; } = string.Empty;
        public string Endpoint { get; set; } = string.Empty;
        public string Deployment { get; set; } = string.Empty;
        public string Prompt { get; set; } = string.Empty;
        public string ApiVersion { get; set; } = "2024-07-01-preview";
    }

    public class FileContent
    {
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string FileType { get; set; } = string.Empty; // "text", "image", or "binary"
        public string Content { get; set; } = string.Empty;
    }

    public class AIService
    {
        private readonly HttpClient _httpClient;
        private readonly AzureAIService _azureAIService;
        private static readonly string[] TextExtensions = { "txt", "md", "css", "html", "json", "xml", "js", "ts", "jsx", "tsx", "py", "java", "cpp", "c", "h", "cs", "rb", "php", "csv", "readme", "doc", "docx" };
        private static readonly string[] ImageExtensions = { "jpg", "jpeg", "png", "gif", "bmp", "webp", "svg" };

        public AIService(HttpClient httpClient, AzureAIService azureAIService = null)
        {
            _httpClient = httpClient;
            _azureAIService = azureAIService;
        }

        public async Task<string> GetAzureOpenAIAssist(AzureOpenAIRequest req)
        {
            ArgumentNullException.ThrowIfNull(req);

            var url = $"{req.Endpoint.TrimEnd('/')}/openai/deployments/{Uri.EscapeDataString(req.Deployment)}/chat/completions?api-version={Uri.EscapeDataString(req.ApiVersion)}";

            using (var content = new StringContent(JsonSerializer.Serialize(new
            {
                messages = new[] { new { role = "user", content = req.Prompt } },
                temperature = 0.7,
                max_tokens = 200
            }), Encoding.UTF8, "application/json"))
            {
                using (var request = new HttpRequestMessage(HttpMethod.Post, url))
                {
                    request.Headers.Add("api-key", req.ApiKey);
                    request.Content = content;

                    var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
                    var data = await response.Content.ReadFromJsonAsync<JsonElement>().ConfigureAwait(false);

                    if (!response.IsSuccessStatusCode)
                    {
                        var apiMsg = data.GetProperty("error").GetProperty("message").GetString() ?? $"HTTP {response.StatusCode}";
                        throw new HttpRequestException(apiMsg);
                    }

                    return data.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString()?.Trim() ?? "No response received.";
                }
            }
        }

        public async Task<string> GetGeminiAIAssist(string apiKey, string model, string prompt)
        {
            var url = $"https://generativelanguage.googleapis.com/v1beta/models/{Uri.EscapeDataString(model)}:generateContent?key={Uri.EscapeDataString(apiKey)}";

            using (var content = new StringContent(JsonSerializer.Serialize(new
            {
                contents = new[] { new { parts = new[] { new { text = prompt } } } }
            }), Encoding.UTF8, "application/json"))
            {
                var response = await _httpClient.PostAsync(new Uri(url), content).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                var data = await response.Content.ReadFromJsonAsync<JsonElement>().ConfigureAwait(false);
                return data.GetProperty("candidates")[0].GetProperty("content").GetProperty("parts")[0].GetProperty("text").GetString() ?? string.Empty;
            }
        }

        public async Task<string> GetDeepSeekAIAssist(string apiKey, string prompt)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Post, "https://api.deepseek.com/chat/completions")
            {
                Content = new StringContent(JsonSerializer.Serialize(new
                {
                    model = "deepseek - reasoner",
                    messages = new[] { new { role = "user", content = prompt } }
                }), Encoding.UTF8, "application/json")
            })
            {
                request.Headers.Add("Authorization", $"Bearer {apiKey}");

                var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
                var data = await response.Content.ReadFromJsonAsync<JsonElement>().ConfigureAwait(false);

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

        private static string GetFileType(string fileName)
        {
            var extension = fileName.Split('.').Last().ToLowerInvariant();
            
            if (TextExtensions.Contains(extension))
                return "text";
            if (ImageExtensions.Contains(extension))
                return "image";
            return "binary";
        }

        private static string ConstructPromptWithFileContext(string userPrompt, List<FileContent> fileContents)
        {
            if (fileContents == null || fileContents.Count == 0)
                return userPrompt;

            var attachedFileContext = new StringBuilder();
            attachedFileContext.AppendLine("Attached Files:");

            foreach (var file in fileContents)
            {
                attachedFileContext.AppendLine($"\n--- File: {file.Name} (Type: {file.Type}, File Type: {file.FileType}) ---");

                if (file.FileType == "text")
                {
                    attachedFileContext.AppendLine(file.Content);
                }
                else if (file.FileType == "image")
                {
                    attachedFileContext.AppendLine($"[Image file: {file.Name} - Base64 encoded data available]");
                    attachedFileContext.AppendLine(file.Content);
                }
                else
                {
                    attachedFileContext.AppendLine($"[Binary file: {file.Name} - Please process this file]");
                    var preview = file.Content.Length > 500 ? file.Content.Substring(0, 500) + "..." : file.Content;
                    attachedFileContext.AppendLine(preview);
                }
            }

            return $"{attachedFileContext}\n\nUser Prompt: {userPrompt}";
        }

        private async Task<List<FileContent>> ReadAttachedFiles(dynamic attachedFiles)
        {
            var fileContents = new List<FileContent>();

            try
            {
                var filesEnumerable = attachedFiles as System.Collections.IEnumerable;
                if (filesEnumerable == null)
                    return fileContents;

                foreach (dynamic file in filesEnumerable)
                {
                    try
                    {
                        string fileName = file.Name?.ToString() ?? "Unknown";
                        string fileType = file.Type?.ToString() ?? "application/octet-stream";
                        string fileContent = null;
                        try
                        {
                            fileContent = await ReadFileStreamContent(file.RawFile);
                        }
                        catch (Exception readEx)
                        {
                            // catch exceptions
                        }

                        if (!string.IsNullOrEmpty(fileContent))
                        {
                            var contentType = GetFileType(fileName);
                            fileContents.Add(new FileContent
                            {
                                Name = fileName,
                                Type = fileType,
                                FileType = contentType,
                                Content = fileContent
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        // Catch exception
                    }
                }
            }
            catch (Exception ex)
            {
                // Catch exception
            }

            return fileContents;
        }

        private static async Task<string> ReadFileStreamContent(object rawFile)
        {
            try
            {
                if (rawFile == null)
                    return string.Empty;
                if (rawFile is System.IO.Stream stream)
                {
                    using (var reader = new System.IO.StreamReader(stream))
                    {
                        return await reader.ReadToEndAsync().ConfigureAwait(false);
                    }
                }

                var rawFileType = rawFile.GetType();
                
                var openReadMethod = rawFileType.GetMethod("OpenReadStream", 
                    System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance,
                    null, Type.EmptyTypes, null);
                
                if (openReadMethod != null)
                {
                    try
                    {
                        var streamedContent = await (dynamic)openReadMethod.Invoke(rawFile, null);
                        if (streamedContent is System.IO.Stream resultStream)
                        {
                            using (var reader = new System.IO.StreamReader(resultStream))
                            {
                                return await reader.ReadToEndAsync().ConfigureAwait(false);
                            }
                        }
                    }
                    catch (Exception methodEx)
                    {
                        //Catch Exception
                    }
                }
            }
            catch (Exception ex)
            {
                //Catch Exception
            }

            return string.Empty;
        }

        public async Task<string> GetAIResponse(dynamic args)
        {
            try
            {
                if (_azureAIService == null)
                {
                    return "Azure AI service is not configured. Please check your dependencies.";
                }

                string userPrompt = args.Prompt?.ToString() ?? string.Empty;
                List<FileContent> fileContents = new List<FileContent>();

                try
                {
                    dynamic attachedFiles = args.AttachedFiles;
                    if (attachedFiles != null && attachedFiles.Count > 0)
                    {
                        fileContents = await ReadAttachedFiles(attachedFiles).ConfigureAwait(false);
                    }
                }
                catch
                {
                    // If there's an issue reading attached files, continue without them
                }
                var finalPrompt = ConstructPromptWithFileContext(userPrompt, fileContents.Count > 0 ? fileContents : null);
                var response = await _azureAIService.GetCompletionAsync(finalPrompt, false).ConfigureAwait(false);

                if (string.IsNullOrEmpty(response))
                {
                    return "We could not reach the AI service; please try again later.";
                }
                return response.Replace("END_INSERTION", "").Trim();
            }
            catch (HttpRequestException ex)
            {
                if (ex.Message.Contains("token limit"))
                {
                    return ex.Message;
                }
                return "We could not reach the AI service; please try again later.";
            }
            catch (TaskCanceledException)
            {
                return "Request was cancelled. Please try again.";
            }
            catch (Exception ex)
            {
                return "We could not reach the AI service; please try again later.";
            }
        }
    }
}
