#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Pdf.Parsing;
using System.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using BlazorDemos.Service;
using SmartComponents.LocalEmbeddings;
using System.Linq;

namespace BlazorDemos.Model
{
    internal class DocumentSummarizer
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
        internal async Task<List<String>> LoadDocument(Stream stream, string mimeType)
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

                PageEmbeddings = Initialize(extractedText.ToArray());
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
        /// Get the summary of the document using first 10 pages content
        /// </summary>
        /// <returns></returns>
        internal async Task<string> GetDocumentSummary()
        {
            List<string> message = PageEmbeddings.Keys.Take(10).ToList();
            return await openAIService.GetCompletionAsync("You are a helpful assistant. Your task is to analyze the provided text and generate short summary." + String.Join(" ", message), false);
        }

        /// <summary>
        /// Get the answer for the question using GPT-4o and local embeddings
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        internal async Task<string> GetAnswer(string question)
        {
            return await openAIService.AnswerQuestion(question,PageEmbeddings);
        }

        /// <summary>
        /// Get the suggestions using GPT-4o and local embeddings
        /// </summary>
        /// <returns></returns>
        internal async Task<string> GetSuggestions()
        {
            List<string> message = PageEmbeddings.Keys.Take(10).ToList();
            return await openAIService.GetCompletionAsync("You are a helpful assistant. Your task is to analyze the provided text and generate 3 short diverse questions and each question should not exceed 10 words" +  String.Join(" ", message), false);
        }
    }
}
