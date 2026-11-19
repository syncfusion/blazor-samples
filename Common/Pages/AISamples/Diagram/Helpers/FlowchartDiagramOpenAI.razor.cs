using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextToFlowchartDiagram
{
    public partial class FlowchartDiagramOpenAI
    {
#pragma warning disable CS8618
        public bool ShowAIAssistDialog { get; set; }
        public string OpenAIPrompt { get; set; }
        public TextToFlowchart Parent { get; set; }
        string ShoppingPrompt = "Online Shopping Process";
        string TravelBookingPrompt = "Travel Booking System";
        string SoftwareLifecyclePrompt = "Software Development Lifecycle";
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
                await GenerateDiagramFromAI();
            }
        }
        public async void GenerateMindMap(string value)
        {
            OpenAIPrompt = value;
            await GenerateDiagramFromAI();
            StateHasChanged();
        }
        private static readonly string[] SplitStrings = new[] { "\n", "\r\n" };

        public async Task GenerateDiagramFromAI()
        {
            ShowAIAssistDialog = false;
            Parent.IsGeneratingFromAI = true;
            if (!string.IsNullOrWhiteSpace(OpenAIPrompt))
            {
                await Parent.SpinnerRef!.ShowAsync().ConfigureAwait(true);
                string result = string.Empty;
                string systemRole = "You are an expert assistant skilled in generating Mermaid flowchart diagram data based on user queries.";

                string userRole = $@"Create a Mermaid flowchart code for a process titled: {OpenAIPrompt}. The flowchart should include decision points with 'Yes' or 'No' branches.

Use the format provided in the example below, adapting the steps, conditions, and styles to match the new title:

**Example Title:** Bus Ticket Booking

**Example Mermaid Code:**

    graph TD
    A([Start]) --> B[Choose Destination]
    B --> C{{Already Registered?}}
    C -->|No| D[Sign Up]
    D --> E[Enter Details]
    E --> F[Search Buses]
    C --> |Yes| F
    F --> G{{Buses Available?}}
    G -->|Yes| H[Select Bus]
    H --> I[Enter Passenger Details]
    I --> J[Make Payment]
    J --> K[Booking Confirmed]
    G -->|No| L[Set Reminder]
    K --> M([End])
    L --> M
    style A fill:#90EE90,stroke:#333,stroke-width:2px;
    style B fill:#4682B4,stroke:#333,stroke-width:2px;
    style C fill:#32CD32,stroke:#333,stroke-width:2px;
    style D fill:#FFD700,stroke:#333,stroke-width:2px;
    style E fill:#4682B4,stroke:#333,stroke-width:2px;
    style F fill:#4682B4,stroke:#333,stroke-width:2px;
    style G fill:#32CD32,stroke:#333,stroke-width:2px;
    style H fill:#4682B4,stroke:#333,stroke-width:2px;
    style I fill:#4682B4,stroke:#333,stroke-width:2px;
    style J fill:#4682B4,stroke:#333,stroke-width:2px;
    style K fill:#FF6347,stroke:#333,stroke-width:2px;
    style L fill:#FFD700,stroke:#333,stroke-width:2px;
    style M fill:#FF6347,stroke:#333,stroke-width:2px;

**Instructions:** Ensure the generated flowchart code is specific to the title '{OpenAIPrompt}' and adheres to the provided format. Every node **must include a corresponding `style` line** to avoid default white backgrounds. Do not include any additional text, explanations, or comments—only the Mermaid flowchart code.";

                result = await ChatGptService.GetCompletionAsync(userRole, false, false, systemRole).ConfigureAwait(true);
                if (result != null)
                {
                    List<string> lines = result.Split(SplitStrings, StringSplitOptions.RemoveEmptyEntries).ToList();
                    lines = lines.Where(line => !line.Contains("```", StringComparison.Ordinal)).ToList();
                    int startIndex = lines.FindIndex(line => line.Trim().StartsWith("graph TD", StringComparison.Ordinal));
                    await InvokeAsync(async () =>
                    {
                        if (startIndex != -1)
                        {
                            List<string> validMermaidData = lines.Skip(startIndex).ToList();
                            result = string.Join(Environment.NewLine, validMermaidData);
                            await Parent.Diagram!.LoadDiagramFromMermaidAsync(result).ConfigureAwait(true);
                        }
                        else
                            await GenerateDiagramFromAI().ConfigureAwait(true);
                        StateHasChanged();
                    }).ConfigureAwait(true);
                }
                await Parent.SpinnerRef.HideAsync().ConfigureAwait(true);
            }
            Parent.IsGeneratingFromAI = false;
        }
    }
}
