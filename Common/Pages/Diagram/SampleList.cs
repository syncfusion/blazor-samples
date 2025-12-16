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
        public List<Sample> Diagram { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Flow Chart",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/flowchart",
                FileName = "FlowChart.razor",
                HeaderText="Flow Chart using Blazor Diagram Component Example",
                MetaTitle = "Blazor Flow Chart | Process Visualization | Syncfusion",
                MetaDescription = "This Blazor Flow Chart demo shows process visualization with decision nodes, connectors, and flowchart symbols for business process mapping and workflow design.",
            },
            new Sample
            {
                Name = "Nodes",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/nodes",
                FileName = "Nodes.razor",
                HeaderText="Example of Nodes in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Nodes | Shape Elements | Syncfusion",
                MetaDescription = "This Blazor Diagram Nodes example demonstrates various node types, shapes, and styling options for creating visual elements in diagrams and flowcharts."
            },
            new Sample
            {
                Name = "Shapes",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/shapes",
                FileName = "Shapes.razor",
                HeaderText="Example of Shapes in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Shapes | Built-in Symbols | Syncfusion",
                MetaDescription = "This Blazor Diagram Shapes example demonstrates the built-in shape library with basic, flowchart, and BPMN symbols for comprehensive diagram creations."
            },
            new Sample
            {
                Name = "HTML Shapes",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/html-shapes",
                FileName = "NodeTemplateSample.razor",
                HeaderText="Example of NodeTemplate in Blazor Diagram Component",
                MetaTitle = "Blazor HTML Shapes | Custom Templates | Syncfusion",
                MetaDescription = "This Blazor HTML Shapes example demonstrates the custom node templates with HTML content for rich, interactive diagram elements and data visualization.",
            },
            new Sample
            {
                Name = "Connectors",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/connectors",
                FileName = "ConnectorSample.razor",
                HeaderText="Example of Connectors in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Connectors | Link Elements | Syncfusion",
                MetaDescription = "This Blazor Diagram Connectors example demonstrates the various connector types, routing, and styling options for linking diagram elements effectively.",
            },
            new Sample
            {
                Name = "Line Routing",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/linerouting",
                FileName = "Routing.razor",
                HeaderText="Example of Line Routing in Blazor Diagram Component",
                MetaTitle = "Blazor Line Routing | Smart Connections | Syncfusion",
                MetaDescription = "This Blazor Line Routing example shows automatic connector routing to avoid obstacles and create clean, organized diagram layouts. Explore to more details.",
            },
            new Sample
            {
                Name = "Avoid Connector Overlap",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/avoid-connector-overlap",
                FileName = "AvoidConnectorOverlap.razor",
                HeaderText="Example of Avoid Connector Overlap feature in Blazor Diagram Component",
                MetaTitle = "Blazor Avoid Connector Overlap | Clean Layout | Syncfusion",
                MetaDescription = "This Blazor Avoid Connector Overlap feature example demonstrates automatic connector adjustment to minimize visual overlap for cleaner diagram presentation.",
            },
            new Sample
            {
                Name = "Annotations",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/annotations",
                FileName = "Annotations.razor",
                HeaderText="Example of Annotations in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Annotations | Text Labels | Syncfusion",
                MetaDescription = "This Blazor Diagram Annotations example demonstrates text labels, positioning, and styling options for adding descriptive content to diagram elements."
            },
            new Sample
            {
                Name = "Ports",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/ports",
                FileName = "Ports.razor",
                HeaderText="Example of Ports in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Ports | Connection Points | Syncfusion",
                MetaDescription = "This Blazor Diagram Ports example demonstrates the connection points on nodes for precise connector attachment and the controlled diagram connectivity.",
            },
            new Sample
            {
                Name = "Rulers",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/rulers",
                FileName = "Rulers.razor",
                HeaderText="Example of Rulers in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Rulers | Measurement Guide | Syncfusion",
                MetaDescription = "This Blazor Diagram Rulers example shows measurement guides and alignment tools for precise diagram element positioning and sizing. Explore to more details.",
            },
            new Sample
            {
                Name = "Swimlanes",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/swimlane",
                FileName = "SwimlaneSample.razor",
                HeaderText="Example of Swimlanes in Blazor Diagram Component",
                MetaTitle = "Blazor Swimlanes Example | Process Lanes | Syncfusion",
                MetaDescription = "This Blazor Swimlanes example demonstrates the process lane organization for business process modeling and workflow visualization with role separation.",
            },
            new Sample
            {
                Name = "Container",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/container",
                FileName = "ContainerSample.razor",
                HeaderText="Example of Containers in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Container | Group Elements | Syncfusion",
                MetaDescription = "This Blazor Diagram Container example demonstrates the grouping and organizing diagram elements within containers for the structured layout management.",
            },
            new Sample
            {
                Name = "Events",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/events",
                FileName = "Events.razor",
                HeaderText="Example of Events in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Events | Interactive Handling | Syncfusion",
                MetaDescription = "This Blazor Diagram Events example demonstrates an event handling for the user interactions, selections, and diagram modifications for dynamic behavior.",
            },
            new Sample
            {
                 Name = "Constraints",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/constraints",
                FileName = "Constraintssample.razor",
                HeaderText="Example of Constraints in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Constraints | Behavior Control | Syncfusion",
                MetaDescription = "This Blazor Diagram Constraints example demonstrates behavior restrictions and permissions for controlling diagram element interactions and modifications."
            },
             new Sample
            {
                 Name = "Tooltip",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/tooltip",
                FileName = "TooltipSample.razor",
                HeaderText="Example of Tooltip in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Tooltip | Hover Information | Syncfusion",
                MetaDescription = "This Blazor Diagram Tooltip example shows hover information display for diagram elements with customizable content and positioning. Explore to more details.",
            },
              new Sample
            {
                Name = "Symbol Palette",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/symbolpalette",
                FileName = "SymbolPalette.razor",
                HeaderText="Example of Symbol Palette in Blazor Diagram Component",
                MetaTitle = "Blazor Symbol Palette | Drag-Drop Shapes | Syncfusion",
                MetaDescription = "This Blazor Symbol Palette example demonstrates drag-and-drop shape library for easy diagram creation with organized symbol categories. Explore to more details.",
            },
              new Sample
            {
                Name = "Z-Order",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/zorder",
                FileName = "ZOrder.razor",
                HeaderText="Example of ZOrder Commands in Blazor Diagram Component",
                MetaTitle = "Blazor Z-Order Example | Layer Management | Syncfusion",
                MetaDescription = "This Blazor Z-Order example shows layer management commands for controlling element stacking order and visual hierarchy in diagrams. Explore to more details.",
            },
            #if SERVER
            new Sample
            {
                Name = "Text to Flowchart",
                Category = "Smart AI Solutions",
                Directory = "AISamples/Diagram",
                Url = "diagram/ai-text-to-flowchart",
                FileName = "TextToFlowchart.razor",
                MetaTitle = "Blazor Diagram Text to Flowchart - Syncfusion AI Demos",
                HeaderText = "Blazor Diagram Example - Text to Flowchart Conversion",
                MetaDescription = "This Blazor Diagram AI converts text descriptions into professional flowcharts, creating visual diagrams with smart node arrangement and connection paths.",
                Type = SampleType.AI
            },
            new Sample
            {
                Name = "Text to MindMap",
                Category = "Smart AI Solutions",
                Directory = "AISamples/Diagram",
                Url = "diagram/ai-text-to-mindmap",
                FileName = "TextToMindMap.razor",
                MetaTitle = "Blazor Diagram Text to MindMap Example - Syncfusion AI Demos",
                HeaderText = "Blazor Diagram Example - Text to MindMap Generation",
                MetaDescription = "Blazor Diagram AI transforms text into interactive mind maps, visualizing hierarchical data with auto-layout and relationship mapping for better organization",
                Type = SampleType.AI
            },
            new Sample
            {
                Name = "Text to Sequence Diagram",
                Category = "Smart AI Solutions",
                Directory = "AISamples/Diagram",
                Url = "diagram/ai-text-to-sequence-diagram",
                FileName = "TextToSequence.razor",
                Type = SampleType.AI,
                MetaTitle = "Blazor Diagram Text to Sequence Example - Syncfusion AI Demos",
                HeaderText = "Blazor Diagram Example - Text to Sequence Diagram Conversion",
                MetaDescription = "This Blazor Diagram demo shows Visualize object interactions and message flows with intelligent interpretation of process sequences for better system design.",
                NotificationDescription = new string[]{ @" This sample shows how AI generates sequence diagrams from text using the diagram component and demonstrates seamless integration of natural language processing with diagram generation." }
            },
#endif
                new Sample
            {
                Name = "Zooming and Panning",
                Category = "Interactive Features",
                Directory = "Diagram/Diagram",
                Url = "diagram/zooming-panning",
                FileName = "ZoomingPanning.razor",
                HeaderText="Example of Zooming and Panning in Blazor Diagram Component",
                MetaTitle = "Blazor Zoom and Pan | Navigation Control | Syncfusion",
                MetaDescription = "This Blazor Zooming and Panning example shows navigation controls for exploring large diagrams with smooth zoom and pan interactions. Explore to more details.",
            },
                new Sample
            {
                Name = "Overview",
                Category = "Interactive Features",
                Directory = "Diagram/Diagram",
                Url = "diagram/overview",
                FileName = "Overview.razor",
                HeaderText="Example of Overview in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Overview | Navigation Panel | Syncfusion",
                MetaDescription = "This Blazor Diagram Overview example demonstrates miniature navigation panel for quick diagram exploration and viewport positioning. Explore to more details.",
            },
                new Sample
            {
                Name = "History Manager",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/historymanager",
                FileName = "HistoryManager.razor",
                HeaderText="Example of History Manager in Blazor Diagram Component",
                MetaTitle = "Blazor History Manager Example | Undo Redo | Syncfusion",
                MetaDescription = "This Blazor History Manager example demonstrates undo/redo functionality for tracking and reversing diagram changes and user actions. Explore to more details.",
            },
             new Sample
            {
                Name = "Drawing Tools",
                Category = "Interactive Features",
                Directory = "Diagram/Diagram",
                Url = "diagram/drawingtool",
                FileName = "DrawingToolSample.razor",
                HeaderText="Example of DrawingTools in Blazor Diagram Component",
                MetaTitle = "Blazor Drawing Tools | Interactive Creation | Syncfusion",
                MetaDescription = "This Blazor Drawing Tools example demonstrates interactive shape and connector creation tools for dynamic diagram building and editing. Explore to more details.",
            },
             new Sample
            {
                Name = "User Handles",
                Category = "Interactive Features",
                Directory = "Diagram/Diagram",
                Url = "diagram/userhandles",
                FileName = "UserHandles.razor",
                HeaderText="Example of User Handles in Blazor Diagram Component",
                MetaTitle = "Blazor User Handles | Custom Controls | Syncfusion",
                MetaDescription = "This Blazor User Handles example demonstrates the custom interactive controls around diagram elements for the specialized operations and quick actions.",
            },
              new Sample
            {
                Name = "Expand and Collapse",
                Category = "Interactive Features",
                Directory = "Diagram/Diagram",
                Url = "diagram/expandcollapse",
                FileName = "ExpandAndCollapse.razor",
                HeaderText="Example of Expand And Collapse in Blazor Diagram Component",
                MetaTitle = "Blazor Expand Collapse | Hierarchical View | Syncfusion",
                MetaDescription = "This Blazor Expand and Collapse example shows hierarchical diagram navigation with expandable nodes for managing complex structures. Explore to more details.",
            },
            new Sample
            {
                Name = "Snapping",
                Category = "Interactive Features",
                Directory = "Diagram/Diagram",
                Url = "diagram/Snapping",
                FileName = "Snapping.razor",
                HeaderText="Example of Snapping in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Snapping | Alignment Guide | Syncfusion",
                MetaDescription = "This Blazor Diagram Snapping example shows automatic alignment guides and snap-to-grid functionality for precise element positioning. Explore to more details.",
            },
             new Sample
            {
                Name = "Scrolling",
                Category = "Interactive Features",
                Directory = "Diagram/Diagram",
                Url = "diagram/scrollsettings",
                FileName = "Scrolling.razor",
                HeaderText="Example of Scrolling in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Scrolling | Viewport Navigation | Syncfusion",
                MetaDescription = "This Blazor Diagram Scrolling example shows viewport navigation and scrolling behavior for exploring large diagram content areas. Explore to more details.",
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Interactive Features",
                Directory = "Diagram/Diagram",
                Url = "diagram/keyboard-interaction",
                FileName = "KeyboardInteraction.razor",
                HeaderText="Example of Keyboard Interaction in Blazor Diagram Component",
                MetaTitle = "Blazor Keyboard Interaction | Accessibility | Syncfusion",
                MetaDescription = "This Blazor Keyboard Interaction example demonstrates an accessibility features with keyboard shortcuts for diagram navigation and element manipulation.",
            },
                new Sample
            {
                Name = "Node Content",
                Category = "Customization",
                Directory = "Diagram/Diagram",
                Url = "diagram/nodecontent",
                FileName = "NodeContent.razor",
                HeaderText="Example of Node content in Blazor Diagram Component",
                MetaTitle = "Blazor Node Content | Custom Elements | Syncfusion",
                MetaDescription = "This Blazor Node Content example demonstrates the custom content rendering within diagram nodes for a rich data visualization and interactive elements.",
            },
            new Sample
            {
                Name = "Flowchart Layout",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/flowchart-layout",
                FileName = "FlowchartLayout.razor",
                HeaderText="Example of Flowchart Layout in Blazor Diagram Component",
                MetaTitle = "Blazor Flowchart Layout | Auto Arrangement | Syncfusion",
                MetaDescription = "This Blazor Flowchart Layout example demonstrates an automatic arrangement of flowchart elements with the intelligent positioning and routing algorithms.",
            },
            new Sample
            {
                Name = "Organization Chart",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/organization-model",
                FileName = "OrganizationModel.razor",
                HeaderText="Organization Chart Example using Blazor Diagram Component",
                MetaTitle = "Blazor Organization Chart | Hierarchy Layout | Syncfusion",
                MetaDescription = "This Blazor Organization Chart example demonstrates hierarchical structure visualization with automatic layout for corporate and team organization mapping."
            },
            new Sample
            {
                Name = "Mindmap Layout",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/mindmap",
                FileName = "Mindmap.razor",
                HeaderText="Example of Mind Map Layout in Blazor Diagram Component",
                MetaTitle = "Blazor Mindmap Layout | Radial Structure | Syncfusion",
                MetaDescription = "This Blazor Mindmap Layout example demonstrates the radial tree structure for brainstorming, idea organization, and the knowledge mapping visualization.",
            },
            new Sample
            {
                Name = "Hierarchical Tree",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/hierarchical-tree",
                FileName = "HierarchicalTree.razor",
                HeaderText="Hierarchical Tree Example using Blazor Diagram Component",
                MetaTitle = "Blazor Hierarchical Tree | Tree Layout | Syncfusion",
                MetaDescription = "This Blazor Hierarchical Tree example demonstrates tree structure visualization with automatic layout for data hierarchy and decision tree representation.",
            },
             new Sample
            {
                Name = "Complex Hierarchical Tree",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/complexhierarchical",
                FileName = "ComplexHierarchicalTree.razor",
                HeaderText="ComplexHierarchical Tree Example using Blazor Diagram Component",
                MetaTitle = "Blazor Complex Hierarchical | Advanced Tree | Syncfusion",
                MetaDescription = "This Blazor Complex Hierarchical Tree demonstrates advanced tree layouts with multiple branches and complex relationships for detailed data structures.",
            },
             new Sample
            {
                Name = "Radial Tree",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/radialtree",
                FileName = "RadialTree.razor",
                HeaderText="Radial Tree Example using Blazor Diagram Component",
                MetaTitle = "Blazor Radial Tree Example | Circular Layout | Syncfusion",
                MetaDescription = "This Blazor Radial Tree demonstrates circular tree layout with central root node for network visualization and relationship mapping. Explore to more details.",
            },
            new Sample
            {
                Name = "Force Directed Tree",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/force-directed-layout",
                FileName = "ForceDirectedLayout.razor",
                HeaderText = "Force Directed Layout Example using Blazor Diagram Component",
                MetaTitle = "Blazor Force Directed Layout for Automatic Diagram Visualization",
                MetaDescription = "Explore Blazor Force Directed Layout to visualize networks and relationships. Automatically arrange nodes for clear, interactive, and organized diagrams.",
                Type = SampleType.New,
                NotificationDescription = new string[]
                {
                    @"Explore a force-directed network that auto-arranges nodes, minimizes crossings, reveals clusters, and supports drag, zoom, and hover to analyze relationships."
                },
            },
             new Sample
            {
                Name = "PERT Chart",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/pertchart",
                FileName = "PERTChart.razor",
                HeaderText="PERT Chart Example using Blazor Diagram Component",
                MetaTitle = "Blazor PERT Chart | Project Management | Syncfusion",
                MetaDescription = "This Blazor PERT Chart demonstrates project evaluation and review technique visualization for project management and timeline planning. Explore to more details.",
            },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Diagram/Diagram",
                Url = "diagram/local-data",
                FileName = "LocalData.razor",
                HeaderText="Example of Local Data in Blazor Diagram Component",
                MetaTitle = "Blazor Local Data Binding | Static Data | Syncfusion",
                MetaDescription = "This Blazor Local Data example demonstrates the binding diagram elements to local data sources for static content visualization and data-driven diagrams."
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Diagram/Diagram",
                Url = "diagram/remote-data",
                FileName = "RemoteData.razor",
                HeaderText="Example of Remote Data in Blazor Diagram Component",
                MetaTitle = "Blazor Remote Data Binding | API Integration | Syncfusion",
                MetaDescription = "This Blazor Remote Data example shows binding diagram elements to remote data sources and APIs for dynamic content visualization. Explore to more details."
            },
            new Sample
            {
               Name = "Serialization",
               Category = "Save and Restore",
                Directory = "Diagram/Diagram",
                Url = "diagram/serialization",
                FileName = "Serialization.razor",
               HeaderText="Example of Serialization in Blazor Diagram Component",
               MetaTitle = "Blazor Diagram Serialization | Save Load | Syncfusion",
               MetaDescription = "This Blazor Diagram Serialization example shows saving and loading diagram data for persistence and state management across sessions. Explore to more details."
            },
            new Sample
            {
                Name = "Export",
                Category = "Export and Print",
                Directory = "Diagram/Diagram",
                Url = "diagram/export",
                FileName = "ExportSample.razor",
                HeaderText="Example of Exporting in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Export | Multiple Formats | Syncfusion",
                MetaDescription = "This Blazor Diagram Export example demonstrates exporting diagrams to various formats including PNG, JPEG, SVG, and PDF for sharing and documentation."
            },
            new Sample
            {
                Name = "Print",
                Category = "Export and Print",
                Directory = "Diagram/Diagram",
                Url = "diagram/print",
                FileName = "PrintSample.razor",
                HeaderText="Example of Printing in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Print | Document Output | Syncfusion",
                MetaDescription = "This Blazor Diagram Print example shows printing capabilities for generating hard copies of diagrams with customizable print settings. Explore to more details."
            },
            new Sample
            {
                Name = "BPMN Editor",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/bpmn-editor",
                FileName = "BPMNEditor.razor",
                HeaderText ="Example of BPMN Design in Blazor Diagram Component",
                MetaTitle = "Blazor BPMN Editor | Business Process | Syncfusion",
                MetaDescription = "This Blazor BPMN Editor demonstrates the business process modeling notation for workflow designs and process documentation with standard BPMN symbols.",
            },
            new Sample
            {
                Name = "Circuit Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/Circuit-Diagram",
                FileName = "CircuitDiagram.razor",
                HeaderText ="Example of Electrical Circuit Design in Blazor Diagram Component",
                MetaTitle = "Blazor Circuit Diagram | Electrical Design | Syncfusion",
                MetaDescription = "This Blazor Circuit Diagram demonstrates electrical circuit design with electronic components and connections for engineering and educational applications.",
            },
            new Sample
            {
                Name = "Logic Circuit Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/logic-circuit",
                FileName = "LogicCircuitDiagram.razor",
                HeaderText ="Example of Logic Circuit Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Logic Circuit | Digital Design | Syncfusion",
                MetaDescription = "This Blazor Logic Circuit Diagram demonstrates the digital logic design with gates, inputs, and outputs for computer science and engineering education.",
            },
            new Sample
            {
                Name = "UML Activity Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/uml-activity",
                FileName = "UMLActivityDiagram.razor",
                HeaderText ="Example of UML Activity Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor UML Activity | Workflow Modeling | Syncfusion",
                MetaDescription = "This Blazor UML Activity Diagram demonstrates workflow and activity modeling with standard UML notation for software design and process documentation.",
            },
            new Sample
            {
                Name = "UML Sequence Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/uml-sequence",
                FileName = "UMLSequenceDiagram.razor",
                HeaderText ="Example of UML Sequence Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor UML Sequence | Interaction Flow | Syncfusion",
                MetaDescription = "This Blazor UML Sequence Diagram demonstrates object interaction flows and message sequences for software architecture and system design documentation.",
            },
            new Sample
            {
                Name = "Shortest Path Visualizer",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/shortest-path",
                FileName = "ShortestPath.razor",
                HeaderText = "Example of Shortest Path Visualization Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Shortest Path | Pathfinding Visualization | Syncfusion",
                MetaDescription = "Visualize shortest paths using Dijkstra’s algorithm in Syncfusion Blazor Diagram. Interactive graph with animated connectors and dynamic node styling.",
            },
            new Sample
            {
                Name = "Tournament Bracket",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/TournamentResult",
                FileName = "TournamentResult.razor",
                HeaderText = "Example of UEFA Tournament Bracket Diagram in Blazor Diagram Component",
                MetaTitle = "UEFA Bracket Diagram | Interactive Bracket Visualization | Syncfusion",
                MetaDescription = "Follow the UEFA Champions League journey with Syncfusion Blazor Diagram. Interactive bracket with match details, animated progression, and champion highlights.",
            },
            new Sample
            {
                Name = "Ticket Booking",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/ticket-booking",
                FileName = "TicketBooking.razor",
                HeaderText = "Interactive Cinema Seat Booking System with Real-time Selection and Multi-tier Pricing",
                MetaTitle = "Cinema Seat Booking | Theater Reservation | Syncfusion Blazor Diagram",
                MetaDescription = "Book movie seats with our interactive cinema booking system. This Syncfusion Blazor Diagram demo lets you select seats by tier and see real-time price updates.",
            },
            new Sample
            {
                Name = "Spiral Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/spiral-diagram",
                FileName = "SpiralDiagram.razor",
                MetaTitle = "Blazor Diagram Spiral Layout Example | Syncfusion Blazor demos",
                MetaDescription = "Visualize a software development lifecycle with an interactive spiral diagram in Blazor. See how nodes, icons, and tooltips represent each project stage.",
            },
            new Sample
            {
                Name = "Image Puzzle",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/puzzle",
                FileName = "Puzzle.razor",
                HeaderText = "Interactive Image Puzzle in Blazor",
                MetaTitle = "Blazor Diagram Interactive Puzzle Example | Syncfusion Blazor demos",
                MetaDescription = "Play an interactive sliding image puzzle built with the Syncfusion Blazor Diagram. Drag tiles to solve the puzzle, track your moves, and use clues to win.",
            },
            new Sample
            {
                Name = "History Timeline Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/history-timeline",
                FileName = "HistoryTimeLine.razor",
                HeaderText = "Example of Interactive Internet History Timeline in Blazor Diagram Component",
                MetaTitle = "Blazor Internet History Timeline | Interactive Chronology | Syncfusion",
                MetaDescription = "Explore Internet history with an interactive timeline built using Syncfusion Blazor Diagram. Add, edit, and visualize key milestones with color-coded segments.",
            },
            new Sample
            {
                Name = "Funnel Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/funnel-diagram",
                FileName = "FunnelDiagram.razor",
                HeaderText = "Example of a Marketing Funnel in Blazor Diagram Component",
                MetaTitle = "Blazor Funnel Diagram Example | Marketing Funnel | Syncfusion",
                MetaDescription = "Infographic funnel diagram with customizable node shapes and colors, showing stage-wise conversion and cumulative rates to assess marketing performance.",
                Type = SampleType.New,
                NotificationDescription = new string[]
                {
                    @"Explore an interactive marketing funnel that visualizes key campaign metrics. Hover over each stage to see detailed conversion rates and track the customer journey from initial exposure to final retention."
                },
            },            
            new Sample
            {
                Name = "Serpentine Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/serpentine-diagram",
                FileName = "SerpentineDiagram.razor",
                HeaderText = "Example of a Serpentine diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Serpentine Diagram | Medical Timeline | Syncfusion",
                MetaDescription = "Explore a serpentine layout visualizing 20 key medical research breakthroughs that revolutionized healthcare from 1796 to 1996 using Syncfusion® Blazor Diagram.",
                Type = SampleType.New,
                NotificationDescription = new string[]
                {
                    @"Discover a serpentine timeline that highlights 20 major medical research breakthroughs from 1796 to 1996, visualized using the Blazor Diagram component."
                },
            },
            new Sample
            {
                Name = "Solar Panel Angle",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/angle",
                FileName = "AngleSample.razor",
                HeaderText = "Example of Smart Solar Panel Tilt System in Blazor Diagram Component",
                MetaTitle = "Smart Solar Panel | Interactive Solar Panel Optimization | Syncfusion",
                MetaDescription = "Demonstrate a smart solar panel tilt system with Syncfusion® Blazor Diagram, allowing users to interactively adjust angles, track efficiency, and optimize.",
                Type = SampleType.New,
                NotificationDescription = new string[]
                {
                    @"Experience smart solar optimization! Adjust panel tilt angles, monitor real-time efficiency, and explore location-based solar performance in this interactive system."
                },
            },
            new Sample
            {
                Name = "P&ID Diagram",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/pipeline-instrumentation-diagram",
                FileName = "PipeLineDiagram.razor",
                HeaderText = "Example of Real-time Pipeline & Instrumentation Diagram (P&ID) in Blazor Diagram Component",
                MetaTitle = "Pipeline Instrumentation Diagram | Process Flow - Syncfusion demos",
                MetaDescription = "Simulate a real-time chemical reactor P&ID with Syncfusion Blazor Diagram. Control fluid flows, tank levels, and temps via interactive elements and animations.",
            },
            new Sample
            {
                Name = "Neural Network",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/neural-network",
                FileName = "NeuralNetwork.razor",
                HeaderText = "Example of Interactive Neural Network Architecture Visualizer in Blazor Diagram Component",
                MetaTitle = "Blazor Neural Network Diagram | AI Visualization | Syncfusion",
                MetaDescription = "Explore neural network architecture with Syncfusion Blazor Diagram. Visualize layers, weights, and data flow with interactive nodes and animated connections.",
            },
            new Sample
            {
                Name = "Venn Diagram",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/venn-diagram",
                FileName = "VennDiagram.razor",
                HeaderText="Example of Venn Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Venn Diagram | Set Relationships | Syncfusion",
                MetaDescription = "This Blazor Venn Diagram shows set relationships and overlapping data visualization for statistical analysis and logical comparisons. Explore to more details."
            },

            new Sample
            {
                Name = "Network Diagram",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/networkdiagram",
                FileName = "NetworkDiagram.razor",
                HeaderText="Example of Network Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Network Diagram | Infrastructure Map | Syncfusion",
                MetaDescription = "This Blazor Network Diagram demonstrates IT infrastructure visualization with network topology, connections, and device relationships for system documentation.",

            },
            new Sample
            {
                Name = "Ishikawa Diagram",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/ishikawadiagram",
                FileName = "IshikawaDiagram.razor",
                HeaderText="Example of Ishikawa Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Ishikawa Diagram | Cause Analysis | Syncfusion",
                MetaDescription = "This Blazor Ishikawa Diagram example demonstrates cause-and-effect analysis with fishbone structure for problem-solving and quality management processes.",
            },
            new Sample
            {
                Name = "Fishbone Diagram",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/fishbone-diagram",
                FileName = "FishboneDiagram.razor",
                HeaderText="Example of Fishbone Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Fishbone Diagram | Root Cause Analysis | Syncfusion",
                MetaDescription = "This Blazor Fishbone Diagram demonstrates root cause analysis visualization for quality control and problem-solving methodologies in business processes."
            },
            new Sample
            {
                Name = "Workflow Diagram",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/workflow-diagram",
                FileName = "WorkflowDiagram.razor",
                HeaderText="Example of Workflow Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Workflow Diagram | Process Flow | Syncfusion",
                MetaDescription = "This Blazor Workflow Diagram example demonstrates business process flow visualization with decision points and task sequences for operational documentation.",

            },
            new Sample
            {
                Name = "Flow Execution",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/flow-execution",
                FileName = "FlowExecution.razor",
                HeaderText="Example of Flow Execution in Blazor Diagram Component",
                MetaTitle = "Blazor Flow Execution | Dynamic Process | Syncfusion",
                MetaDescription = "This Blazor Flow Execution shows dynamic process execution visualization with real-time status updates and interactive flow control. Explore to more details."
            },
            new Sample
            {
                Name = "Diagram Binding With TreeView",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/diagramwithtreeview",
                FileName = "DiagramWithTreeView.razor",
                MetaTitle = "Diagram Diagram Binding With TreeView - Syncfusion Demos",
                HeaderText="Example of Treeview component in Blazor Diagram Component",
                MetaDescription = "This Blazor Diagram with TreeView demonstrates synchronized navigation between hierarchical tree view and diagram visualization for enhanced data exploration.",
            }
        };
    }
}