#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextToSequenceDiagram;

namespace TextToSequenceDiagram
{
    public partial class SequenceDiagramOpenAI
    {
#pragma warning disable CS8618
        public bool ShowAIAssistDialog = false;
        public string OpenAIPrompt;
        public TextToSequence Parent;
        string ATMPrompt = "ATM Transaction Process";
        string UserAuthendicationPrompt = "User Authentication and Authorization";
        string MedicalAppointementPrompt = "Medical Appointment Scheduling";
#pragma warning restore CS8618
        public void OnFabClicked()
        {
            ShowAIAssistDialog = !ShowAIAssistDialog;
        }
        private void DialogClose(Object args)
        {
            ShowAIAssistDialog = false;
        }
        public async void GenerateSequence(string value)
        {
            OpenAIPrompt = value;
            await GenerateDiagramFromAI();
            StateHasChanged();
        }
        public async Task GenerateDiagramFromAI()
        {
            ShowAIAssistDialog = false;
            Parent.IsGeneratingFromAI = true;
            if (!string.IsNullOrWhiteSpace(OpenAIPrompt))
            {
                await Parent.SpinnerRef.ShowAsync();
                string result = string.Empty;
                string systemRole = "You are an expert assistant skilled in generating Mermaid sequence diagram data based on user queries.";

                string userRole = $@"You are an assistant tasked with generating structured sequence diagram Mermaid data for the scenario {OpenAIPrompt} based on the guidelines below. The output should strictly adhere to these rules and must not include any markdown code fences or the string '```mermaid' at the beginning.

1.	Start with sequenceDiagram.
2.	Declare all participants with actor or participant; user types must be actor.
3.	Use specific arrows only: ->>, -), --), and for self-messages also ->>.
4.	Mark activations (activate) and deactivations (deactivate) for all interactions.
5.	Include at least one alt, opt, or loop block.
6.	Add at least one create and destroy message.
7.	Include at least 10 interaction steps, building a complex flow.
8.	Follow proper indentation and do not add extra comments or markdown syntax.

Basic simple examples for your context, but you try to create a complex diagram with all the given elements:

Example 1: All Types of Messages
sequenceDiagram
actor Client
participant Server
Client ->> Server: Sync Request
Server -) Client: Async Notification
Client -->> Server: Reply Message
Client ->> Client: Self Check
Server ->> Client: Delete Record

Example 2: With Activations
sequenceDiagram
participant User
participant Service
User ->> Service: Start Process
activate Service
Service -->> User: Process Acknowledged
deactivate Service

Example 3: With Fragments
sequenceDiagram
participant User
participant System
alt Successful Login
    User ->> System: Enter Credentials
    activate System
    System -->> User: Login Successful
    deactivate System
else Failed Login
    loop Retry up to 3 times
        User ->> System: Re-enter Credentials
    end
end

Example 4: With Create/Destroy Messages
sequenceDiagram
actor Admin
create participant Worker as DataProcessor
Admin -) Worker: Initialize Service
activate Worker
Worker ->> Admin: Service Ready
deactivate Worker
destroy Worker

Return only the structured Mermaid sequence diagram syntax.
";

                result = await ChatGptService.GetCompletionAsync(userRole, false, false, systemRole);
                if (result != null)
                {
                    List<string> lines = result.Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    lines = lines.Where(line => !line.Contains("```")).ToList();
                    int startIndex = lines.FindIndex(line => line.Trim().StartsWith("sequenceDiagram"));
                    if (startIndex != -1)
                    {
                        List<string> validMermaidData = lines.Skip(startIndex).ToList();
                        result = string.Join(Environment.NewLine, validMermaidData);
                        await Parent.Diagram.LoadDiagramFromMermaidAsync(result);
                    }
                    else
                        await GenerateDiagramFromAI();
                    StateHasChanged();
                }
                await Parent.SpinnerRef.HideAsync();
            }
            Parent.IsGeneratingFromAI = false;
        }
    }
}
