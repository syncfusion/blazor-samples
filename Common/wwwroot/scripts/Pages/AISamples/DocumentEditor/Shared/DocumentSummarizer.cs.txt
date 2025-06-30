#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Service;
using Microsoft.Extensions.AI;
using SmartComponents.LocalEmbeddings;
using Syncfusion.Blazor.AI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.AISamples.DocumentEditor.Shared
{
    public class DocumentSummarizer
    {
        public Dictionary<string, EmbeddingF32> PageEmbeddings { get; set; }
        private List<string> extractedText = new List<string>();
        private string DocumentContent { get; set; } = string.Empty;

        private LocalEmbedder? Embedder;

        private AzureAIService? OpenAIService;

        public DocumentSummarizer(LocalEmbedder embedder, AzureAIService azureAIService)
        {
            Embedder = embedder;
            OpenAIService = azureAIService;
        }
        private void CreateEmbeddingChunks(string[] chunks)
        {
            PageEmbeddings = chunks.Select(x => KeyValuePair.Create(x, Embedder.Embed(x))).ToDictionary(k => k.Key, v => v.Value);
        }

        /// <summary>
        /// Get answer from GPT-4o
        /// </summary>
        /// <param name="systemPrompt"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task<string> GetAnswerFromGPT(string systemPrompt, string message, bool isSummary = false)
        {
            ChatParameters chatParameters = new ChatParameters();
            chatParameters.Messages = new()
            {
                new ChatMessage(ChatRole.System,systemPrompt)
            };
            if (isSummary)
            {
                var summaryResults = new List<string>();
                List<string> embed = PageEmbeddings.Keys.Take(PageEmbeddings.Keys.Count).ToList();
                foreach (var chunk in embed)
                {
                    chatParameters.Messages.Add(new ChatMessage(ChatRole.User, chunk));
                    var result = await OpenAIService.GetChatResponseAsync(chatParameters);
                    if (result != null)
                    {
                        summaryResults.Add(result.ToString());
                        chatParameters.Messages.RemoveAt(chatParameters.Messages.Count - 1);
                    }
                }
                return String.Join(" ", summaryResults);
            }
            else
            {
                chatParameters.Messages.Add(new ChatMessage(ChatRole.User, message));
                var result = await OpenAIService.GetChatResponseAsync(chatParameters);
                return result;
            }
        }

        public async Task LoadDocument(string document)
        {
            extractedText.Clear();
            this.DocumentContent = document;
            int chunkSize = 4000;
            int start = 0;

            while (start < document.Length)
            {
                int length = Math.Min(chunkSize, document.Length - start);
                int lastSpace = document.LastIndexOf('.', start + length - 1, length);
                if (lastSpace > start)
                {
                    string chunk = document.Substring(start, lastSpace - start);
                    extractedText.Add(chunk);
                    start = lastSpace + 1;
                }
                else
                {
                    string chunk = document.Substring(start, length);
                    extractedText.Add(chunk);
                    start += length;
                }
            }
            CreateEmbeddingChunks(extractedText.ToArray());
        }

        public async Task<string> GetDocumentSummary()
        {
            return await GetAnswerFromGPT("You are a helpful assistant. Your task is to analyze the provided text and generate short summary. Always respond in proper HTML format, but do not include <html>, <head>, or <body> tags.", "", true);
        }

        /// <summary>
        /// Fine closest page embedding and answer the question using GPT-4o
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public async Task<string> GetAnswer(string systemPrompt, string question)
        {
            var questionEmbedding = Embedder.Embed(question);
            var results = LocalEmbedder.FindClosest(questionEmbedding, PageEmbeddings.Select(x => (x.Key, x.Value)), 2);
            var answer = await GetAnswerFromGPT(systemPrompt + string.Join(" --- ", results), question);
            return answer;
        }

        /// <summary>
        /// Get the suggestions using GPT-4o and local embeddings
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetSuggestions()
        {
            string text = this.DocumentContent;
            return await GetAnswerFromGPT("You are a helpful assistant. Your task is to analyze the provided text and generate 3 short diverse questions and each question should not exceed 10 words", text);
        }
    }

}