#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.AI;
using Syncfusion.Blazor.AI;
using OpenAI;


namespace BlazorDemos.Service
{
    public class AzureAIService
    {
        private readonly UserTokenService _userTokenService;
        private ChatParameters chatParameters_history = new ChatParameters();
        private IChatClient _azureAIClient;

        public AzureAIService(UserTokenService userTokenService, AIServiceCredentials credentials)
        {
            _userTokenService = userTokenService;
            _azureAIClient = new OpenAIClient(credentials.ApiKey).GetChatClient(credentials.DeploymentName).AsIChatClient();
        }


        /// <summary>
        /// Gets a text completion from the Azure OpenAI service.
        /// </summary>
        /// <param name="prompt">The user prompt to send to the AI service.</param>
        /// <param name="returnAsJson">Indicates whether the response should be returned in JSON format. Defaults to <c>true</c></param>
        /// <param name="appendPreviousResponse">Indicates whether to append previous responses to the conversation history. Defaults to <c>false</c></param>
        /// <param name="systemRole">Specifies the systemRole that is sent to AI Clients. Defaults to <c>null</c></param>
        /// <returns>The AI-generated completion as a string.</returns>
        public async Task<string> GetCompletionAsync(string prompt, bool returnAsJson = true, bool appendPreviousResponse = false, string systemRole = null)
        {
            string systemMessage = returnAsJson ? "You are a helpful assistant that only returns and replies with valid, iterable RFC8259 compliant JSON in your responses unless I ask for any other format. Do not provide introductory words such as 'Here is your result' or '```json', etc. in the response" : !string.IsNullOrEmpty(systemRole) ? systemRole : "You are a helpful assistant";
            try
            {
                ChatParameters chatParameters = appendPreviousResponse ? chatParameters_history : new ChatParameters();
                if (appendPreviousResponse)
                {
                    if (chatParameters.Messages == null)
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
                var completion = await GetChatResponseAsync(chatParameters);
                if (appendPreviousResponse)
                {
                    chatParameters_history?.Messages?.Add(new ChatMessage(ChatRole.Assistant, completion));
                }
                return completion;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An exception has occurred: {ex.Message}");
                return "";
            }
        }

        public async Task<string> GetChatResponseAsync(ChatParameters options)
        {
            string userCode = await _userTokenService.GetUserFingerprintAsync();
            int remainingTokens = await _userTokenService.GetRemainingTokensAsync(userCode);
            int inputTokens = options.Messages.Sum(message => message.Text.Length/4);

            if (remainingTokens <= inputTokens)
            {
                await _userTokenService.ShowAlert(userCode);
                return null;
            }
            // Create a completion request with the provided parameters
            var completionRequest = new ChatOptions
            {
                Temperature = options.Temperature ?? 0.5f,
                TopP = options.TopP ?? 1.0f,
                MaxOutputTokens = options.MaxTokens ?? 2000,
                FrequencyPenalty = options.FrequencyPenalty ?? 0.0f,
                PresencePenalty = options.PresencePenalty ?? 0.0f,
                StopSequences = options.StopSequences
            };
            try
            {
                ChatResponse completion = await _azureAIClient.GetResponseAsync(options.Messages, completionRequest);
                await _userTokenService.UpdateTokensAsync(userCode, (int)(remainingTokens - completion.Usage.TotalTokenCount));
                return completion.Text.ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
