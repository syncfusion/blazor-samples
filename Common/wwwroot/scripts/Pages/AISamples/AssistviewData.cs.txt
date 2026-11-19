using Syncfusion.Blazor.InteractiveChat;
using System.Collections.Generic;
using System.Text.Json;

namespace Syncfusion.Blazor.InteractiveChatDemo
{

    public class AssistviewData
    {
        public static IReadOnlyList<string> GetGenerativeSuggestionData()
        {
            return new List<string> { "What is the weather in NewYork now?", "Can you show smartphone sales by region in a table?" };
        }

        public static List<AssistViewPrompt> chartPromptResponse = new List<AssistViewPrompt>()
        {
            new AssistViewPrompt
            {
                Prompt = "What are France's GDP growth trends?",
                Blocks = new List<IResponseBlock>
                {
                    new TextBlock
                    {
                        BlockType = BlockType.Text,
                        Content = "**GDP Growth and Economic Contribution Analysis**\n\nThe chart visualizes how different economic sectors contribute to overall GDP performance."
                    },
                    new ToolBlock
                    {
                        BlockType = BlockType.Tool,
                        ToolName = "chart-tool",
                        Props = new
                        {
                            chartData = new List<ChartDataPoint>
                            {
                                new ChartDataPoint{ X = "2005", Y = 1.5 },
                                new ChartDataPoint{ X = "2006", Y = 2.3 },
                                new ChartDataPoint{ X = "2007", Y = 2.0 },
                                new ChartDataPoint{ X = "2008", Y = 0.1 },
                                new ChartDataPoint{ X = "2009", Y = -2.7 },
                                new ChartDataPoint{ X = "2010", Y = 1.8 },
                                new ChartDataPoint{ X = "2011", Y = 2.0 },
                                new ChartDataPoint{ X = "2012", Y = 0.4 },
                                new ChartDataPoint{ X = "2013", Y = 0.9 },
                                new ChartDataPoint{ X = "2014", Y = 0.4 },
                                new ChartDataPoint{ X = "2015", Y = 1.3 }
                            },
                            xField = "x",
                            yField = "y",
                            chartType = "Line",
                            title = "GDP Growth",
                            xAxisTitle = "Years",
                            yAxisTitle = "Growth (in Billion)",
                            enableTooltip = true,
                            enableLegend = true
                        }
                    },
                    new TextBlock
                    {
                        BlockType = BlockType.Text,
                        Content = "The chart shows GDP growth trends from 2005 to 2015, including expansion, slowdown, and recovery phases. Growth was strong in the mid-2000s, dropped sharply during 2008–2009, and then gradually recovered. Overall, it reflects economic resilience with moderate fluctuations across the period."
                    }
                }
            }
        };

        public static string GetGenerativeUISystemPrompt()
        {
            return @"You are an AI assistant that generates Syncfusion AIAssistView blocks.

Return ONLY valid JSON.

Output format:

{
    ""blocks"": [
        {
            ""blockType"": ""text"",
            ""content"": ""Description""
        },
        {
            ""blockType"": ""tool"",
            ""toolName"": ""chart-tool"",
            ""props"": {
                ""chartType"": ""Line"",
                ""title"": ""Chart Title"",
                ""xAxisTitle"": """",
                ""yAxisTitle"": """",
                ""dataSource"": [],
                ""xField"": ""fieldName"",
                ""yField"": ""fieldName"",
                ""enableTooltip"": true,
                ""enableLegend"": true
            }
        }
    ]
}
Supported tools:
    - weather-card
    - grid-tool
    - chart-tool
Rules:
1. Always return a single ""blocks"" array.
2. Return ONLY valid JSON.
3. Never wrap JSON in markdown.
4. Never truncate JSON.
5. You may return ANY number of blocks.
6. You may mix blocks in ANY order:
    - text
    - tool
    - multiple tools
    - multiple text blocks
7. Always provide rich responses with:
    - At least 2 explanation block
    - At least 1 visualization/tool block when relevant
    - Additional insight text if useful
8. Never use property names:
    - data
    - xName
    - yName
    - type
9. For chart-tool ALWAYS use:
    {
        ""chartType"": ""Line|Column|Bar|Area|Spline"",
        ""title"": """",
        ""xAxisTitle"": """",
        ""yAxisTitle"": """",
        ""dataSource"": [],
        ""xField"": """",
        ""yField"": """",
        ""enableTooltip"": true,
        ""enableLegend"": true
    }
10. Always provide meaningful axis titles.

    Examples:

    GDP Growth:
    - xAxisTitle: ""Year""
    - yAxisTitle: ""GDP Growth (Billion USD)""

    Revenue:
    - xAxisTitle: ""Month""
    - yAxisTitle: ""Revenue (Million USD)""

    Population:
    - xAxisTitle: ""Country""
    - yAxisTitle: ""Population (Millions)""

    Growth Rate:
    - xAxisTitle: ""Year""
    - yAxisTitle: ""Growth Rate (%)""

    Temperature:
    - xAxisTitle: ""Month""
    - yAxisTitle: ""Temperature (°C)""
11. For grid-tool ALWAYS use:
    {
        ""data"": [],
        ""columns"": []
    }
12. For weather-card ALWAYS use:
    {
        ""location"": """",
        ""temperature"": """",
        ""condition"": """",
        ""humidity"": """",
        ""windSpeed"": """"
    }
13. Use realistic public/sample/demo data.
Return ONLY JSON.";
        }
    }

    // Classes for component props to be passed in response
    public class AiResponse
    {
        public List<AiBlock> Blocks { get; set; } = new();
    }

    public class AiBlock
    {
        public string BlockType { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public string ToolName { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public JsonElement Props { get; set; }
    }

    public class WeatherProps
    {
        public string Location { get; set; } = string.Empty;

        public string Temperature { get; set; } = string.Empty;

        public string Condition { get; set; } = string.Empty;

        public string Humidity { get; set; } = string.Empty;

        public string WindSpeed { get; set; } = string.Empty;
    }

    public class GridColumnDefinition
    {
        public string Field { get; set; } = string.Empty;

        public string HeaderText { get; set; } = string.Empty;

        public int? Width { get; set; }
    }

    public class GridToolProps
    {
        public JsonElement Data { get; set; }

        public JsonElement GridData { get; set; }

        public List<GridColumnDefinition>? Columns { get; set; }
    }

    public class ChartToolProps
    {
        public JsonElement DataSource { get; set; }

        public JsonElement Data { get; set; }

        public string XField { get; set; } = string.Empty;

        public string YField { get; set; } = string.Empty;

        public string XName { get; set; } = string.Empty;

        public string YName { get; set; } = string.Empty;

        public string ChartType { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string XAxisTitle { get; set; } = string.Empty;

        public string YAxisTitle { get; set; } = string.Empty;

        public bool? EnableTooltip { get; set; }

        public bool? EnableLegend { get; set; }
    }

    public class ChartDataPoint
    {
        public string X { get; set; } = string.Empty;

        public double Y { get; set; }
    }
}
