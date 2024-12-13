#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Threading.Tasks;
using System;
using Syncfusion.Blazor.Charts.AccumulationChart.Internal;
using SmartComponents.LocalEmbeddings;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.AI;
using Syncfusion.Blazor.SmartComponents;

namespace BlazorDemos.Service
{
    public class AzureAIService
    {
        private OpenAIConfiguration _openAIConfiguration;
        //private readonly AzureOpenAIChatCompletionService _chatService;
        //private ChatHistory _chatHistories;
        private ChatParameters chatParameters_history = new ChatParameters();

        public AzureAIService(OpenAIConfiguration openAIConfiguration)
        {
            _openAIConfiguration = openAIConfiguration;
        }

        /// <summary>
        /// Gets a text completion from the Azure OpenAI service.
        /// </summary>
        /// <param name="prompt">The user prompt to send to the AI service.</param>
        /// <param name="returnAsJson">Indicates whether the response should be returned in JSON format.</param>
        /// <param name="appendPreviousResponse">Indicates whether to append previous responses to the conversation history.</param>
        /// <returns>The AI-generated completion as a string.</returns>
        public async Task<string> GetCompletionAsync(string prompt, bool returnAsJson = true, bool appendPreviousResponse = false, string systemRole = null)
        {
            string systemMessage = returnAsJson ? "You are a helpful assistant that only returns and replies with valid, iterable RFC8259 compliant JSON in your responses unless I ask for any other format. Do not provide introductory words such as 'Here is your result', etc. in the response" : !string.IsNullOrEmpty(systemRole) ? systemRole : "You are a helpful assistant";
            try
            {
                ChatParameters chatParameters = appendPreviousResponse ? chatParameters_history : new ChatParameters();
                if (appendPreviousResponse)
                {
                    if(chatParameters.Messages == null)
                    {
                        chatParameters.Messages = new List<ChatMessage>() {
                        new ChatMessage(ChatRole.System,systemMessage),
                        };
                    }
                    chatParameters.Messages.Add(new ChatMessage(ChatRole.User, prompt));
                }
                else
                {
                    chatParameters.Messages = new List<ChatMessage>(2) {
                    new ChatMessage (ChatRole.System, systemMessage),
                    new ChatMessage(ChatRole.User,prompt)
                    };
                }
                //chatParameters.MaxTokens = 20000;
                var completion = await _openAIConfiguration.GetChatResponseAsync(chatParameters);
                if (appendPreviousResponse)
                {
                    chatParameters_history?.Messages?.Add(new ChatMessage(ChatRole.Assistant, completion.ToString()));
                }
                return completion.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An exception has occurred: {ex.Message}");
                return "Something went wrong, Please try again!";
            }
        }
        public async Task<string> AnswerQuestion(string question, Dictionary<string, EmbeddingF32> PageEmbeddings)
        {
            var embedder = new LocalEmbedder();
            var questionEmbedding = embedder.Embed(question);
            var results = LocalEmbedder.FindClosestWithScore(questionEmbedding, PageEmbeddings.Select(x => (x.Key, x.Value)), 5, 0.5f);
            StringBuilder builder = new StringBuilder();
            foreach (var result in results)
            {
                builder.AppendLine(result.Item);
            }
            string message = builder.ToString();
            var answer = await GetCompletionAsync("You are a helpful assistant. Use the provided PDF document pages and pick a precise page to answer the user question, proivde a reference at the bottom of the content with page numbers like ex: Reference: [20,21,23]. Pages: " + message + question);

            return answer;
        }
    }
}
