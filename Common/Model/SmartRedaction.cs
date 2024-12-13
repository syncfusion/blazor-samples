#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Pdf.Parsing;
using System.Text;
using Syncfusion.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using BlazorDemos.Service;
using Microsoft.AspNetCore.Components;
using SmartComponents.LocalEmbeddings;

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
    public class SmartRedaction
    {
        private AzureAIService? openAIService { get; set; }
        public Dictionary<string, EmbeddingF32>? PageEmbeddings { get; set; }
        public void InitializeOpenAI(AzureAIService azureService)
        {
            openAIService = azureService;
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

                PageEmbeddings =  Initialize(extractedText.ToArray());
                   
            }
        
           return extractedText;
           
        }
        public Dictionary<string, EmbeddingF32> Initialize(string[] chunks)
        {
            var embedder = new LocalEmbedder();
            Dictionary<string, EmbeddingF32> PageEmbeddings = chunks.Select(x => KeyValuePair.Create(x, embedder.Embed(x))).ToDictionary(k => k.Key, v => v.Value);
            return PageEmbeddings;
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

            if (openAIService != null)
            {
                List<string> message = PageEmbeddings.Keys.Take(10).ToList();
                var answer = await openAIService.GetCompletionAsync(prompt + String.Join(" ", message), false);

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
    }
}
