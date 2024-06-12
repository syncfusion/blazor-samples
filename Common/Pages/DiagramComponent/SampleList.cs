#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> DiagramComponent { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Flow Chart",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/flowchart",
                Type = SampleType.Updated,
                FileName = "FlowChart.razor",
                HeaderText="Flow Chart using Blazor Diagram Component Example",
                NotificationDescription = new string[]{ @"An added search option has been included in the Flow chart sample. Users can now search for symbols in the palette by entering the symbol ID (e.g., ""rectangle"") or by searching for tags in the search text box and clicking the search button. Additionally, users can utilize undo/redo support, z-order commands, zoom in/out actions, and print the diagram using the toolbar menu." },
            },
            new Sample
            {
                Name = "Nodes",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/nodes",
                FileName = "Nodes.razor",
                HeaderText="Example of Nodes in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Shapes",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/shapes",
                FileName = "Shapes.razor",
                HeaderText="Example of Shapes in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "HTML Shapes",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/html-shapes",
                FileName = "NodeTemplateSample.razor",
                HeaderText="Example of NodeTemplate in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Connectors",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/connectors",
                FileName = "ConnectorSample.razor",
                HeaderText="Example of Connectors in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Line Routing",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/linerouting",
                FileName = "Routing.razor",
                HeaderText="Example of Line Routing in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Annotations",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/annotations",
                FileName = "Annotations.razor",
                HeaderText="Example of Annotations in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Ports",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/ports",
                FileName = "Ports.razor",
                HeaderText="Example of Ports in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Rulers",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/rulers",
                FileName = "Rulers.razor",
                HeaderText="Example of Rulers in Blazor Diagram Component",
                Type = SampleType.New,
                NotificationDescription = new string[]{ @"Added a demo about rulers in the Diagram Component. This sample shows how to visualize and customize rulers used to measure and position diagram elements." },
            },
            new Sample
            {
                Name = "Swimlanes",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/swimlane",
                FileName = "SwimlaneSample.razor",
                HeaderText="Example of Swimlanes in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Events",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/events",
                FileName = "Events.razor",
                HeaderText="Example of Events in Blazor Diagram Component",
            },
            new Sample
            {
                 Name = "Constraints",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/constraints",
                FileName = "Constraintssample.razor",
                HeaderText="Example of Constraints in Blazor Diagram Component"
            },
              new Sample
            {
                Name = "Symbol Palette",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/symbolpalette",
                FileName = "SymbolPalette.razor",
                HeaderText="Example of Symbol Palette in Blazor Diagram Component",
                 Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Added an Animation and Search option in symbol palette sample. Now users can search for symbols in the palette by entering the symbol id  (e.g., ""rectangle"") or search tags text into the search text box and clicking the search button. Additionally, users can enable/disable animation." },
            },
              new Sample
            {
                Name = "Z-Order",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/zorder",
                FileName = "ZOrder.razor",
                HeaderText="Example of ZOrder Commands in Blazor Diagram Component",
            },
                new Sample
            {
                Name = "Zooming and Panning",
                Category = "Interactive Features",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/zooming-panning",
                FileName = "ZoomingPanning.razor",
                HeaderText="Example of Zooming and Panning in Blazor Diagram Component",
            },
                new Sample
            {
                Name = "Overview",
                Category = "Interactive Features",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/overview",
                FileName = "Overview.razor",
                HeaderText="Example of Overview in Blazor Diagram Component",
            },
                new Sample
            {
                Name = "History Manager",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/historymanager",
                FileName = "HistoryManager.razor",
                HeaderText="Example of History Manager in Blazor Diagram Component",
            },
             new Sample
            {
                Name = "Drawing Tools",
                Category = "Interactive Features",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/drawingtool",
                FileName = "DrawingToolSample.razor",
                HeaderText="Example of DrawingTools in Blazor Diagram Component",
            },
             new Sample
            {
                Name = "User Handles",
                Category = "Interactive Features",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/userhandles",
                FileName = "UserHandles.razor",
                HeaderText="Example of User Handles in Blazor Diagram Component",
            },
              new Sample
            {
                Name = "Expand and Collapse",
                Category = "Interactive Features",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/expandcollapse",
                FileName = "ExpandAndCollapse.razor",
                HeaderText="Example of Expand And Collapse in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Snapping",
                Category = "Interactive Features",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/Snapping",
                FileName = "Snapping.razor",
                HeaderText="Example of Snapping in Blazor Diagram Component",
            },
             new Sample
            {
                Name = "Scrolling",
                Category = "Interactive Features",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/scrollsettings",
                FileName = "Scrolling.razor",
                HeaderText="Example of Scrolling in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Interactive Features",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/keyboard-interaction",
                FileName = "KeyboardInteraction.razor",
                HeaderText="Example of Keyboard Interaction in Blazor Diagram Component",
            },
                new Sample
            {
                Name = "Node Content",
                Category = "Customization",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/nodecontent",
                FileName = "NodeContent.razor",
                HeaderText="Example of Node content in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Organization Chart",
                Category = "Automatic Layouts",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/organization-model",
                FileName = "OrganizationModel.razor",
                HeaderText="Organization Chart Example using Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Mindmap Layout",
                Category = "Automatic Layouts",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/mindmap",
                FileName = "Mindmap.razor",
                HeaderText="Example of Mind Map Layout in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Hierarchical Tree",
                Category = "Automatic Layouts",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/hierarchical-tree",
                FileName = "HierarchicalTree.razor",
                HeaderText="Hierarchical Tree Example using Blazor Diagram Component",
            },
             new Sample
            {
                Name = "Complex Hierarchical Tree",
                Category = "Automatic Layouts",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/complexhierarchical",
                FileName = "ComplexHierarchicalTree.razor",
                HeaderText="ComplexHierarchical Tree Example using Blazor Diagram Component",
            },
             new Sample
            {
                Name = "Radial Tree",
                Category = "Automatic Layouts",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/radialtree",
                FileName = "RadialTree.razor",
                HeaderText="Radial Tree Example using Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/local-data",
                FileName = "LocalData.razor",
                HeaderText="Example of Local Data in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/remote-data",
                FileName = "RemoteData.razor",
                HeaderText="Example of Remote Data in Blazor Diagram Component"
            },
            new Sample
            {
               Name = "Serialization",
               Category = "Save and Restore",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/serialization",
                FileName = "Serialization.razor",
               HeaderText="Example of Serialization in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Export",
                Category = "Export and Print",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/export",
                FileName = "ExportSample.razor",
                HeaderText="Example of Exporting in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Print",
                Category = "Export and Print",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/print",
                FileName = "PrintSample.razor",
                HeaderText="Example of Printing in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "BPMN Editor",
                Category = "Use Case Diagram",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/bpmn-editor",
                FileName = "BPMNEditor.razor",
                HeaderText ="Example of BPMN Design in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Circuit Diagram",
                Category = "Use Case Diagram",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/Circuit-Diagram",
                FileName = "CircuitDiagram.razor",
                HeaderText ="Example of Electrical Circuit Design in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Logic Circuit Diagram",
                Category = "Use Case Diagram",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/logic-circuit",
                FileName = "LogicCircuitDiagram.razor",
                HeaderText ="Example of Logic Circuit Diagram in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "UML Activity Diagram",
                Category = "Use Case Diagram",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/uml-activity",
                FileName = "UMLActivityDiagram.razor",
                HeaderText ="Example of UML Activity Diagram in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "UML Sequence Diagram",
                Category = "Use Case Diagram",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/uml-sequence",
                FileName = "UMLSequenceDiagram.razor",
                HeaderText ="Example of UML Sequence Diagram in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Venn Diagram",
                Category = "Real-time Diagrams",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/venn-diagram",
                FileName = "VennDiagram.razor",
                HeaderText="Example of Venn Diagram in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Network Diagram",
                Category = "Real-time Diagrams",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/networkdiagram",
                FileName = "NetworkDiagram.razor",
                HeaderText="Example of Network Diagram in Blazor Diagram Component",

            },
            new Sample
            {
                Name = "Ishikawa Diagram",
                Category = "Real-time Diagrams",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/ishikawadiagram",
                FileName = "IshikawaDiagram.razor",
                HeaderText="Example of Ishikawa Diagram in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Fishbone Diagram",
                Category = "Real-time Diagrams",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/fishbone-diagram",
                FileName = "FishboneDiagram.razor",
                HeaderText="Example of Fishbone Diagram in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Flow Execution",
                Category = "Real-time Diagrams",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/flow-execution",
                FileName = "FlowExecution.razor",
                HeaderText="Example of Flow Execution in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Diagram Binding With TreeView",
                Category = "Real-time Diagrams",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/diagramwithtreeview",
                FileName = "DiagramWithTreeView.razor",
                HeaderText="Example of Treeview component in Blazor Diagram Component",
            },

        };
    }
}
