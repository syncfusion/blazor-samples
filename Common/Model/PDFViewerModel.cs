#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SmartComponents.LocalEmbeddings;
using Syncfusion.Drawing;
using Syncfusion.Pdf.Parsing;
using System.Text;
using System.Collections.Generic;
using BlazorDemos.Service;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.IO;
using Syncfusion.DocIO.DLS;

namespace BlazorDemos.Model
{
    public class TextBounds
    {
        public string SensitiveInformation { get; set; } = string.Empty;
        public RectangleF Bounds { get; set; }
    }
    public class TreeItem
    {
        public string NodeId { get; set; } = string.Empty;
        public string NodeText { get; set; } = string.Empty;
        public int pageNumber { get; set; }
        public RectangleF Bounds { get; set; }
        public bool? IsChecked { get; set; }
        public bool Expanded { get; set; }
        public List<TreeItem> Child = new List<TreeItem>();
    }
    public class PDFViewerModel
    {
        public Dictionary<string, EmbeddingF32>? PageEmbeddings { get; set; }

        private LocalEmbedder? Embedder;

        private AzureAIService? OpenAIService;

        public PDFViewerModel(LocalEmbedder embedder, AzureAIService azureAIService)
        {
            Embedder = embedder;
            OpenAIService = azureAIService;
        }

        private void CreateEmbeddingChunks(string[] chunks)
        {
            PageEmbeddings = chunks.Select(x => KeyValuePair.Create(x, Embedder.Embed(x))).ToDictionary(k => k.Key, v => v.Value);
        }

        public async Task<string> FetchResponseFromAIService(string systemPrompt)
        {
            List<string> message = PageEmbeddings.Keys.Take(2).ToList();
            var result = await OpenAIService.GetCompletionAsync(String.Join(" ", message), false, false, systemPrompt);
            return result;
        }

        /// <summary>
        /// Load the document and extract text page by page and save it in List
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="mimeType"></param>
        /// <returns></returns>
        public async Task<List<String>> LoadDocument(Stream stream, string mimeType)
        {
            List<string> extractedText = new List<string>();

            if (mimeType == "application/pdf")
            {
                using (PdfLoadedDocument loadedDocument = new PdfLoadedDocument(stream))
                {
                    // Loading page collections

                    PdfLoadedPageCollection loadedPages = loadedDocument.Pages;

                    // Extract annotations to a memory stream and convert to string
                    using (MemoryStream annotationStream = new MemoryStream())
                    {
                        loadedDocument.ExportAnnotations(annotationStream, AnnotationDataFormat.Json);
                        string annotations = ConvertToString(annotationStream);
                        if (!String.IsNullOrEmpty(annotations))
                        {
                            extractedText.Add("Annotations: " + annotations);
                        }
                    }

                    // Extract form fields to a memory stream and convert to string
                    using (MemoryStream formStream = new MemoryStream())
                    {
                        if (loadedDocument.Form != null)
                        {
                            loadedDocument.Form.ExportData(formStream, DataFormat.Json, "form");
                            string formFields = ConvertToString(formStream);
                            if (!String.IsNullOrEmpty(formFields))
                            {
                                extractedText.Add("Form fields: " + formFields);
                            }
                        }
                    }


                    // Extract text from existing PDF document pages
                    for (int i = 0; i < loadedPages.Count; i++)
                    {
                        string text = $"... Page {i + 1} ...\n";
                        text += loadedPages[i].ExtractText();
                        extractedText.Add(text);
                    }
                }

                if (Embedder != null)
                {
                    CreateEmbeddingChunks(extractedText.ToArray());
                }
            }

            return extractedText;

        }
        private string ConvertToString(MemoryStream memoryStream)
        {
            // Reset the position of the MemoryStream to the beginning
            memoryStream.Position = 0;

            using (StreamReader reader = new StreamReader(memoryStream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        /// <summary>
        /// Get the Text Bounds of the text to be searched
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="sensitiveInformations"></param>
        /// <returns></returns>
        public Dictionary<int, List<TextBounds>> FindTextBounds(Stream stream, List<string> sensitiveInformations)
        {
            Dictionary<int, List<TextBounds>> accumulatedBounds = new Dictionary<int, List<TextBounds>>();

            using (PdfLoadedDocument loadedDocument = new PdfLoadedDocument(stream))
            {
                foreach (var info in sensitiveInformations)
                {
                    if (!string.IsNullOrEmpty(info))
                    {
                        Dictionary<int, List<RectangleF>> bounds;

                        // Find the text bounds
                        loadedDocument.FindText(info, out bounds);

                        // Merge bounds into accumulatedBounds
                        foreach (var pair in bounds)
                        {
                            if (!accumulatedBounds.ContainsKey(pair.Key))
                            {
                                accumulatedBounds[pair.Key] = new List<TextBounds>();
                            }

                            // Add the bounds with the corresponding sensitive information
                            accumulatedBounds[pair.Key].AddRange(pair.Value.Select(rect => new TextBounds
                            {
                                SensitiveInformation = info,
                                Bounds = rect
                            }));
                        }
                    }
                }

                foreach (KeyValuePair<int, List<TextBounds>> pair in accumulatedBounds)
                {
                    // Create a dictionary to store the maximum width bounds for each (X, Y) value pair
                    Dictionary<(float X, float Y), TextBounds> maxWidthBounds = new Dictionary<(float X, float Y), TextBounds>();

                    for (int i = 0; i < pair.Value.Count; i++)
                    {
                        // Convert Point to Pixels for Programmatically Add Support
                        var textBound = pair.Value[i];
                        var rect = textBound.Bounds;
                        rect.X = ConvertPointToPixel(rect.X) - 2;
                        rect.Y = ConvertPointToPixel(rect.Y) - 2;
                        rect.Height = ConvertPointToPixel(rect.Height) + 2;
                        rect.Width = ConvertPointToPixel(rect.Width) + 2;

                        var key = (rect.X, rect.Y);

                        if (maxWidthBounds.TryGetValue(key, out var existingTextBound))
                        {
                            // If the existing rectangle has a smaller width, replace it
                            if (rect.Width > existingTextBound.Bounds.Width)
                            {
                                maxWidthBounds[key] = new TextBounds
                                {
                                    SensitiveInformation = textBound.SensitiveInformation,
                                    Bounds = rect
                                };
                            }
                        }
                        else
                        {
                            maxWidthBounds[key] = new TextBounds
                            {
                                SensitiveInformation = textBound.SensitiveInformation,
                                Bounds = rect
                            };
                        }
                    }
                    pair.Value.Clear();
                    pair.Value.AddRange(maxWidthBounds.Values);
                }
            }
            return accumulatedBounds;
        }


        /// <summary>
        /// Used to convert the Point to Pixels for Programmatically Add Support
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private float ConvertPointToPixel(float number)
        {
            return (number * 96f / 72f);
        }

        /// <summary>
        /// Get the Sensitive Data with the selected patterns from the PDF using OpenAI 
        /// </summary> 
        /// <param name="text"></param>
        /// <param name="selectedItems"></param>
        /// <returns></returns>
        internal async Task<List<string>> GetSensitiveDataFromPDF(string text, List<string> selectedItems)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("I have a block of text containing various pieces of information. Please help me identify and extract any Personally Identifiable Information (PII) present in the text. The PII categories I am interested in are:");

            foreach (var item in selectedItems)
            {
                stringBuilder.AppendLine(item);
            }

            stringBuilder.AppendLine("Please provide the extracted information as a plain list, separated by commas, without any prefix or numbering or extra content.");

            string prompt = stringBuilder.ToString();

            if (OpenAIService != null)
            {
                var answer = await FetchResponseFromAIService(prompt);

                if (!string.IsNullOrEmpty(answer))
                {
                    var output = answer.Trim();

                    // Use a HashSet to remove duplicates
                    var namesSet = new HashSet<string>(output
                        ?.Split(new[] { '\n', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(name => name.Trim())
                        .Where(name => !string.IsNullOrEmpty(name)) ?? Enumerable.Empty<string>());

                    return namesSet.ToList();
                }
            }
            return new List<string>();
        }

        public async Task<string> AnswerQuestion(string userPrompt)
        {
            var embedder = new LocalEmbedder();
            var questionEmbedding = embedder.Embed(userPrompt);
            var results = LocalEmbedder.FindClosestWithScore(questionEmbedding, PageEmbeddings.Select(x => (x.Key, x.Value)), 5, 0.5f);
            StringBuilder builder = new StringBuilder();
            foreach (var result in results)
            {
                builder.AppendLine(result.Item);
            }
            string message = builder.ToString();
            string systemPrompt = "You are a helpful assistant. Use the provided PDF document pages and pick a precise page to answer the user question, proivde a reference at the bottom of the content with page numbers like ex: Reference: [20,21,23]. Pages: " + message;
            var answer = await OpenAIService.GetCompletionAsync(userPrompt, false, false, systemPrompt);

            return answer;
        }

        /// <summary>
        /// Get the answer for the question using GPT-4o and local embeddings
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        internal async Task<string> GetAnswer(string question)
        {
            var answer = await AnswerQuestion(question);
            var suggestions = await GetSuggestions();
            var result = answer + "\nsuggestions" + suggestions;
            return result;
        }

        /// <summary>
        /// Get the suggestions using GPT-4o and local embeddings
        /// </summary>
        /// <returns></returns>
        internal async Task<string> GetSuggestions()
        {
            return await FetchResponseFromAIService("You are a helpful assistant. Your task is to analyze the provided text and generate 3 short diverse questions and each question should not exceed 10 words");
        }
    }
}

