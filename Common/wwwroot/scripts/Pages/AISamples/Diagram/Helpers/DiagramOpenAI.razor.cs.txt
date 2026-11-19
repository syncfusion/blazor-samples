using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextToMindMapDiagram
{
    public partial class DiagramOpenAI
    {
#pragma warning disable CS8618
        public TextToMindMap Parent { get; set; }
        public bool ShowAIAssistDialog { get; set; }
        public string OpenAIPrompt { get; set; }
        string MobileBankingPrompt = "Mindmap diagram for Mobile banking registration";
        string OrganizationalResearchPrompt = "Mindmap diagram for Organizational research";
        string MeetingAgendaPrompt = "Mindmap diagram for Meeting agenda";
#pragma warning restore CS8618
        public void OnFabClicked()
        {
            ShowAIAssistDialog = !ShowAIAssistDialog;
        }
        private void DialogClose(Object args)
        {
            ShowAIAssistDialog = false;
        }
        private async void KeyUp(KeyboardEventArgs args)
        {
            if (args.Key == "Enter")
            {
                await GetResponseFromAI();
            }
        }
        public async void GenerateMindMap(string value)
        {
            OpenAIPrompt = value;
            await GetResponseFromAI();
            StateHasChanged();
        }

        public async Task GetResponseFromAI()
        {
            Parent.IsGeneratingFromAI = true;
            ShowAIAssistDialog = false;
            if (!string.IsNullOrWhiteSpace(OpenAIPrompt))
            {
                await Parent.SpinnerRef!.ShowAsync().ConfigureAwait(true);
                string result = string.Empty;
                string systemRole = "You are an expert in creating mind map diagram data sources. Generate a structured data source for a mind map based on the user's query, using tab indentation to indicate hierarchy. The root parent should have no indentation, while each subsequent child level should be indented by one tab space. Avoid using any symbols such as '+' or '-' before any level of data.";
                string userPrompt = $"Based on the following input, create a mind map diagram data source: {OpenAIPrompt}.";
                result = await ChatGptService.GetCompletionAsync(userPrompt, false, false, systemRole).ConfigureAwait(true);
                if (result != null)
                {
                    List<string> filteredData = result
                .Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .ToList();
                    if (filteredData[0].Trim() != "mindmap")
                        filteredData.Insert(0, "mindmap");
                    filteredData[1] = filteredData[1].TrimStart('-', '+');
                    result = string.Join("\n", filteredData);
                    await InvokeAsync(async () =>
                    {
                        Parent.Diagram!.BeginUpdate();
                        Parent.Diagram.StartGroupAction();
                        await Parent.Diagram.LoadDiagramFromMermaidAsync(result).ConfigureAwait(true);
                        Parent.Diagram.EndGroupAction();
                        await Parent.Diagram.EndUpdateAsync().ConfigureAwait(true);
                        StateHasChanged();
                    }).ConfigureAwait(true);
                }
                await Parent.SpinnerRef.HideAsync().ConfigureAwait(true);
            }
            Parent.IsGeneratingFromAI = false;
        }
    }
}
