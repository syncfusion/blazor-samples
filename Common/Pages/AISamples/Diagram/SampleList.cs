#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;

namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> AIDiagram { get; set; } = new List<Sample>{

            new Sample
            {
                Name = "Text to Flowchart",
                Category = "Diagram",
                Directory = "AISamples/Diagram",
                Url = "ai-diagram/text-to-flowchart",
                FileName = "TextToFlowchart.razor",
                MetaTitle = "Blazor Diagram Text to Flowchart - Syncfusion AI Demos",
                HeaderText = "Blazor Diagram Example - Text to Flowchart Conversion",
                MetaDescription = "This Blazor Diagram AI demo converts plain text descriptions into professional flowcharts. Transform your textual process definitions into visual diagrams with intelligent node arrangement and connection paths."
            },
            new Sample
            {
                Name = "Text to MindMap",
                Category = "Diagram",
                Directory = "AISamples/Diagram",
                Url = "ai-diagram/text-to-mindmap",
                FileName = "TextToMindMap.razor",
                MetaTitle = "Blazor Diagram Text to MindMap Example - Syncfusion AI Demos",
                HeaderText = "Blazor Diagram Example - Text to MindMap Generation",
                MetaDescription = "This Blazor Diagram AI feature transforms text into interactive mind maps. Convert hierarchical information into visual knowledge structures with automatic layout and relationship mapping for improved information organization."
            },
            new Sample
            {
                Name = "Text to Sequence Diagram",
                Category = "Diagram",
                Directory = "AISamples/Diagram",
                Url = "ai-diagram/text-to-sequence-diagram",
                FileName = "TextToSequence.razor",
                Type = SampleType.New,
                MetaTitle = "Blazor Diagram Text to Sequence Example - Syncfusion AI Demos",
                HeaderText = "Blazor Diagram Example - Text to Sequence Diagram Conversion",
                MetaDescription = "This Blazor Diagram AI tool creates sequence diagrams from text descriptions. Visualize object interactions and message flows with intelligent interpretation of process sequences for better system design understanding.",
                NotificationDescription = new string[]{ @" This sample shows how AI generates sequence diagrams from text using the diagram component and demonstrates seamless integration of natural language processing with diagram generation." }
            }
        };
    }
}