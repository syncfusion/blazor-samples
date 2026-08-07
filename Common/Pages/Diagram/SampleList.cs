using System.Collections.Generic;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
		private static readonly string[] AnnotationNotification = new string[]
	    {
			@"Added support for annotation interactions in the Diagram component, allowing users to select, drag, resize, and rotate annotation text. Hyperlink support is also introduced through the HyperlinkSettings object, enabling navigation using the Url property and customization of display text with the Content property."
		};
		private static readonly string[] UMLClassNotification = new string[]
	    {
			@"Added support for UML Class Diagram elements in the Blazor Diagram component, enabling the creation of Class, Interface, and Enumeration shapes as nodes, along with enhanced connector capabilities to represent relationships between these elements, and integration with the Symbol Palette to allow users to easily drag, drop, and reuse UML shapes for efficient diagram modeling."
		};
		public List<Sample> Diagram { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Flow Chart",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/flowchart",
                FileName = "FlowChart.razor",
                HeaderText="Flow Chart using Blazor Diagram Component Example",
                MetaTitle = "Blazor Diagram Examples - Flow Chart | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Flow Chart visualizes business processes with decision nodes, connectors, and flowchart symbols for workflow design and mapping.",
            },
            new Sample
            {
                Name = "Nodes",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/nodes",
                FileName = "Nodes.razor",
                HeaderText="Example of Nodes in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Nodes | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram renders various node types, shapes, and styling options for creating visual elements in diagrams and flowcharts."
            },
            new Sample
            {
                Name = "Shapes",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/shapes",
                FileName = "Shapes.razor",
                HeaderText="Example of Shapes in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Shapes | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram showcases built-in shape libraries including basic, flowchart, and BPMN symbols for building rich and structured diagrams."
            },
            // Ignore: From Build
            new Sample
            {
                Name = "HTML Shapes",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/html-shapes",
                FileName = "NodeTemplateSample.razor",
                HeaderText="Example of NodeTemplate in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - HTML Shapes | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram renders custom node templates with HTML content for rich, interactive diagram elements and data visualization in web apps.",
            },
            // End: Ignore
            new Sample
            {
                Name = "Connectors",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/connectors",
                FileName = "ConnectorSample.razor",
                HeaderText="Example of Connectors in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Connectors | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram links elements with various connector types, routing options, and styling for effective diagram connections in workflows.",
            },
            new Sample
            {
                Name = "Line Routing",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/linerouting",
                FileName = "Routing.razor",
                HeaderText="Example of Line Routing in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Line Routing | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram automatically routes connectors to avoid obstacles and create clean, organized diagram layouts with smooth paths.",
            },
            new Sample
            {
                Name = "Avoid Connector Overlap",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/avoid-connector-overlap",
                FileName = "AvoidConnectorOverlap.razor",
                HeaderText="Example of Avoid Connector Overlap feature in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - Avoid Connector Overlap | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram automatically adjusts connectors to minimize visual overlap for cleaner, more professional diagram presentation.",
            },
            new Sample
            {
                Name = "Annotations",
                Category = "Getting Started",
                Type = SampleType.Updated,
                Directory = "Diagram/Diagram",
                Url = "diagram/annotations",
                FileName = "Annotations.razor",
                HeaderText="Example of Annotations in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Annotations | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram adds text labels with positioning and styling for descriptive annotations on diagram elements to enhance clarity.",
                NotificationDescription = AnnotationNotification
			},
            new Sample
            {
                Name = "Ports",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/ports",
                FileName = "Ports.razor",
                HeaderText="Example of Ports in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Ports | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram defines ports on nodes to enable precise connector attachment, improving control and accuracy in diagram connectivity.",
            },
            new Sample
            {
                Name = "Rulers",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/rulers",
                FileName = "Rulers.razor",
                HeaderText="Example of Rulers in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Rulers | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram shows measurement guides and alignment tools for precise element positioning and sizing in diagram layouts and designs.",
            },
            new Sample
            {
                Name = "Swimlanes",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/swimlane",
                FileName = "SwimlaneSample.razor",
                HeaderText="Example of Swimlanes in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Swimlanes | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram uses swimlanes to organize workflows, enabling role-based separation and clear visualization of business processes.",
            },
            new Sample
            {
                Name = "Container",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/container",
                FileName = "ContainerSample.razor",
                HeaderText="Example of Containers in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Container | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram groups and organizes elements within containers for structured layout management in complex diagram applications.",
            },
            new Sample
            {
                Name = "Events",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/events",
                FileName = "Events.razor",
                HeaderText="Example of Events in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Events | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram handles user interactions, selections, and modifications for dynamic, interactive diagram behavior in web app interfaces.",
            },
            new Sample
            {
                 Name = "Constraints",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/constraints",
                FileName = "Constraintssample.razor",
                HeaderText="Example of Constraints in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Constraints | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram restricts behaviors and permissions for controlling element interactions and modifications in diagram applications."
            },
             new Sample
            {
                 Name = "Tooltip",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/tooltip",
                FileName = "TooltipSample.razor",
                HeaderText="Example of Tooltip in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Tooltip | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram displays hover information with customizable content and positioning for diagram element details in dashboard views.",
            },
              new Sample
            {
                Name = "Symbol Palette",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/symbolpalette",
                FileName = "SymbolPalette.razor",
                HeaderText="Example of Symbol Palette in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Symbol Palette | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram provides drag-and-drop shape libraries with organized symbol categories for easy diagram creation in applications.",
            },
              new Sample
            {
                Name = "Z-Order",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/zorder",
                FileName = "ZOrder.razor",
                HeaderText="Example of ZOrder Commands in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Z-Order | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram manages layer commands for controlling element stacking order and visual hierarchy in diagram layouts and designs.",
            },
            #if SERVER
            // Ignore: From Build
            new Sample
            {
                Name = "Text to Flowchart",
                Category = "Smart AI Solutions",
                Directory = "AISamples/Diagram",
                Url = "diagram/ai-text-to-flowchart",
                FileName = "TextToFlowchart.razor",
                MetaTitle = "Blazor Diagram - Text to Flowchart | Diagram Demos | Syncfusion",
                HeaderText = "Blazor Diagram - AI Powered Text to Flowchart Example",
                MetaDescription = "See how the Syncfusion Blazor Diagram AI converts text descriptions into professional flowcharts with smart node arrangement and connection paths for diagrams.",
                Type = SampleType.AI
            },
            // End: Ignore
            // Ignore: From Build
            new Sample
            {
                Name = "Text to MindMap",
                Category = "Smart AI Solutions",
                Directory = "AISamples/Diagram",
                Url = "diagram/ai-text-to-mindmap",
                FileName = "TextToMindMap.razor",
                MetaTitle = "Blazor Diagram Demos - Text to MindMap Examples  | Syncfusion",
                HeaderText = "Blazor Diagram - AI Powered Text to MindMap Example",
                MetaDescription = "See how the Syncfusion Blazor Diagram converts text into interactive mind maps with auto layout and relationship mapping for structured data visualization.",
                Type = SampleType.AI
            },
            // End: Ignore
            // Ignore: From Build
            new Sample
            {
                Name = "Text to Sequence Diagram",
                Category = "Smart AI Solutions",
                Directory = "AISamples/Diagram",
                Url = "diagram/ai-text-to-sequence-diagram",
                FileName = "TextToSequence.razor",
                Type = SampleType.AI,
                MetaTitle = "Blazor Diagram Demos- Text to Sequence Diagram Examples  | Syncfusion",
                HeaderText = "Blazor Diagram - Text to Sequence Diagram Example",
                MetaDescription = "See how the Syncfusion Blazor Diagram visualizes object interactions and message flows with intelligent process sequence interpretation for system design.",
            },
            // End: Ignore
#endif
                new Sample
            {
                Name = "Zooming and Panning",
                Category = "Interactive Features",
                Directory = "Diagram/Diagram",
                Url = "diagram/zooming-panning",
                FileName = "ZoomingPanning.razor",
                HeaderText="Example of Zooming and Panning in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - Zooming and Panning | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram supports zooming and panning with smooth navigation controls, enabling easy exploration of large and complex diagrams.",
            },
                new Sample
            {
                Name = "Overview",
                Category = "Interactive Features",
                Directory = "Diagram/Diagram",
                Url = "diagram/overview",
                FileName = "Overview.razor",
                HeaderText="Example of Overview in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Overview | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram demonstrates a miniature navigation panel for quick diagram exploration and viewport positioning in applications.",
                CustomCanonicalUrl = "https://www.syncfusion.com/diagram-sdk/blazor-diagram"
            },
                new Sample
            {
                Name = "History Manager",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/historymanager",
                FileName = "HistoryManager.razor",
                HeaderText="Example of History Manager in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Demos - History Manager Examples  | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram tracks changes using undo and redo support, allowing users to easily reverse actions and manage edits efficiently.",
            },
             new Sample
            {
                Name = "Drawing Tools",
                Category = "Interactive Features",
                Directory = "Diagram/Diagram",
                Url = "diagram/drawingtool",
                FileName = "DrawingToolSample.razor",
                HeaderText="Example of DrawingTools in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Drawing Tools | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram provides interactive shape and connector creation tools for dynamic diagram building and editing in web app interfaces.",
            },
             new Sample
            {
                Name = "User Handles",
                Category = "Interactive Features",
                Directory = "Diagram/Diagram",
                Url = "diagram/userhandles",
                FileName = "UserHandles.razor",
                HeaderText="Example of User Handles in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - User Handles | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram adds custom interactive controls around elements for specialized operations and quick actions in diagram applications.",
            },
              new Sample
            {
                Name = "Expand and Collapse",
                Category = "Interactive Features",
                Directory = "Diagram/Diagram",
                Url = "diagram/expandcollapse",
                FileName = "ExpandAndCollapse.razor",
                HeaderText="Example of Expand And Collapse in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - Expand and Collapse | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram enables hierarchical navigation with expandable nodes for managing complex diagram structures in web app interfaces.",
            },
            new Sample
            {
                Name = "Snapping",
                Category = "Interactive Features",
                Directory = "Diagram/Diagram",
                Url = "diagram/Snapping",
                FileName = "Snapping.razor",
                HeaderText="Example of Snapping in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Snapping | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram provides automatic alignment guides and snap-to-grid functionality for precise element positioning in diagram layouts.",
            },
             new Sample
            {
                Name = "Scrolling",
                Category = "Interactive Features",
                Directory = "Diagram/Diagram",
                Url = "diagram/scrollsettings",
                FileName = "Scrolling.razor",
                HeaderText="Example of Scrolling in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Scrolling | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram enables viewport navigation for exploring large diagram content areas with smooth scrolling in diagram applications.",
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Interactive Features",
                Directory = "Diagram/Diagram",
                Url = "diagram/keyboard-interaction",
                FileName = "KeyboardInteraction.razor",
                HeaderText="Example of Keyboard Interaction in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - Keyboard Interaction | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram provides accessibility features with keyboard shortcuts for diagram navigation and element manipulation in apps.",
            },
                new Sample
            {
                Name = "Node Content",
                Category = "Customization",
                Directory = "Diagram/Diagram",
                Url = "diagram/nodecontent",
                FileName = "NodeContent.razor",
                HeaderText="Example of Node content in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Node Content | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram renders custom content within nodes for rich data visualization and interactive diagram elements for dashboards.",
            },
            new Sample
            {
                Name = "Flowchart Layout",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/flowchart-layout",
                FileName = "FlowchartLayout.razor",
                HeaderText="Example of Flowchart Layout in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - Flowchart Layout | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram automatically arranges flowchart elements with intelligent positioning and connector routing algorithms for layouts.",
            },
            new Sample
            {
                Name = "Organization Chart",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/organization-model",
                FileName = "OrganizationModel.razor",
                HeaderText="Organization Chart Example using Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - Organization Chart | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram visualizes hierarchical structures with automatic layout for corporate and team organization mapping in dashboards."
            },
            new Sample
            {
                Name = "Mindmap Layout",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/mindmap",
                FileName = "Mindmap.razor",
                HeaderText="Example of Mind Map Layout in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Mindmap Layout | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram displays radial tree structures for brainstorming, idea organization, and knowledge mapping visualization in web apps.",
            },
            new Sample
            {
                Name = "Hierarchical Tree",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/hierarchical-tree",
                FileName = "HierarchicalTree.razor",
                HeaderText="Hierarchical Tree Example using Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - Hierarchical Tree | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram visualizes tree structures with automatic layout for data hierarchy and decision tree representation in dashboards.",
            },
             new Sample
            {
                Name = "Complex Hierarchical Tree",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/complexhierarchical",
                FileName = "ComplexHierarchicalTree.razor",
                HeaderText="ComplexHierarchical Tree Example using Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Demos - Complex Hierarchical Tree | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram arranges advanced tree layouts with multiple branches and complex relationships for detailed data structure visualization.",
            },
             new Sample
            {
                Name = "Radial Tree",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/radialtree",
                FileName = "RadialTree.razor",
                HeaderText="Radial Tree Example using Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Radial Tree | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram displays circular tree layouts with central root nodes for network visualization and relationship mapping in apps.",
            },
            new Sample
            {
                Name = "Force Directed Tree",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/force-directed-layout",
                FileName = "ForceDirectedLayout.razor",
                HeaderText = "Force Directed Layout Example using Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - Force Directed Tree | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram visualizes networks with automatic node arrangement for clear, interactive, organized diagram layouts in web apps.",
            },
             new Sample
            {
                Name = "PERT Chart",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/pertchart",
                FileName = "PERTChart.razor",
                HeaderText="PERT Chart Example using Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - PERT Chart | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram visualizes project evaluation and review techniques for project management and timeline planning in diagram dashboards.",
            },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Diagram/Diagram",
                Url = "diagram/local-data",
                FileName = "LocalData.razor",
                HeaderText="Example of Local Data in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Local Data | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram binds elements to local data sources for static content visualization and data-driven diagrams in web applications."
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Diagram/Diagram",
                Url = "diagram/remote-data",
                FileName = "RemoteData.razor",
                HeaderText="Example of Remote Data in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Remote Data | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram connects to remote data sources and APIs, enabling dynamic updates and real-time visualization in diagram applications."
            },
            new Sample
            {
               Name = "Serialization",
               Category = "Save and Restore",
                Directory = "Diagram/Diagram",
                Url = "diagram/serialization",
                FileName = "Serialization.razor",
               HeaderText="Example of Serialization in Blazor Diagram Component",
               MetaTitle = "Blazor Diagram Examples - Serialization | Diagram Demos | Syncfusion",
               MetaDescription = "See how the Syncfusion Blazor Diagram saves and loads diagram data for persistence and state management across user sessions in web application projects."
            },
            new Sample
            {
                Name = "Export",
                Category = "Export and Print",
                Directory = "Diagram/Diagram",
                Url = "diagram/export",
                FileName = "ExportSample.razor",
                HeaderText="Example of Exporting in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Export | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram exports diagrams to PNG, JPEG, SVG, and PDF formats with customization options for sharing and documentation purposes."
            },
            new Sample
            {
                Name = "Print",
                Category = "Export and Print",
                Directory = "Diagram/Diagram",
                Url = "diagram/print",
                FileName = "PrintSample.razor",
                HeaderText="Example of Printing in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Print | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram prints diagrams with customizable print settings for generating hard copies, reports, and documentation in applications."
            },
            new Sample
            {
                Name = "BPMN Editor",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/bpmn-editor",
                FileName = "BPMNEditor.razor",
                HeaderText ="Example of BPMN Design in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - BPMN Editor | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram provides business process modeling notation with standard BPMN symbols for workflow design and process documentation.",
            },
            new Sample
            {
                Name = "Circuit Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/Circuit-Diagram",
                FileName = "CircuitDiagram.razor",
                HeaderText ="Example of Electrical Circuit Design in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Demos - Circuit Diagram Examples  | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram designs electrical circuits with electronic components and connections for engineering and educational applications.",
            },
            new Sample
            {
                Name = "Logic Circuit Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/logic-circuit",
                FileName = "LogicCircuitDiagram.razor",
                HeaderText ="Example of Logic Circuit Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - Logic Circuit Diagram | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram designs digital logic with gates, inputs, and outputs for computer science and engineering education applications.",
            },
            new Sample
            {
                Name = "UML Activity Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/uml-activity",
                FileName = "UMLActivityDiagram.razor",
                HeaderText ="Example of UML Activity Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - UML Activity Diagram | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram models workflows using UML activity diagrams, supporting software design and process documentation with standard notation.",
            },
            new Sample
            {
                Name = "UML Sequence Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/uml-sequence",
                FileName = "UMLSequenceDiagram.razor",
                HeaderText ="Example of UML Sequence Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - UML Sequence Diagram | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram visualizes UML sequence diagrams to represent object interactions and message flows in software architectures.",
            },
            new Sample
            {
                Name = "UML Class Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/uml-class",
                 Type = SampleType.New,
                FileName = "UMLClassShape.razor",
                HeaderText ="Example of UML Class Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - UML Class Diagram | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram renders UML class diagrams to model classes, attributes, operations, and relationships in object-oriented systems.",
                NotificationDescription = UMLClassNotification
			},
            new Sample
            {
                Name = "Shortest Path Visualizer",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/shortest-path",
                FileName = "ShortestPath.razor",
                HeaderText = "Example of Shortest Path Visualization Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Demos - Shortest Path Visualizer Examples | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram visualizes shortest paths using Dijkstra's algorithm with animated connectors and dynamic node styling in dashboards.",
            },
            new Sample
            {
                Name = "Tournament Bracket",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/TournamentResult",
                FileName = "TournamentResult.razor",
                HeaderText = "Example of UEFA Tournament Bracket Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - Tournament Bracket | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram displays interactive tournament brackets with match details, animated progression, and champion highlights in web apps.",
            },
            new Sample
            {
                Name = "Ticket Booking",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/ticket-booking",
                FileName = "TicketBooking.razor",
                HeaderText = "Interactive Cinema Seat Booking System with Real-time Selection and Multi-tier Pricing",
                MetaTitle = "Blazor Diagram Examples - Ticket Booking | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram builds interactive seat booking systems with tier selection and real-time price updates for cinema reservations.",
            },
            new Sample
            {
                Name = "Spiral Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/spiral-diagram",
                FileName = "SpiralDiagram.razor",
                MetaTitle = "Blazor Diagram Examples - Spiral Diagram | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram visualizes software development lifecycles with interactive nodes, icons, and tooltips for each project stage in web apps.",
            },
            new Sample
            {
                Name = "Image Puzzle",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/puzzle",
                FileName = "Puzzle.razor",
                HeaderText = "Interactive Image Puzzle in Blazor",
                MetaTitle = "Blazor Diagram Examples - Image Puzzle | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram creates interactive sliding image puzzles with draggable tiles, move tracking, and clue hints for winning games.",
            },
            new Sample
            {
                Name = "Periodic Table",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/periodic-table",
                FileName = "PeriodicTable.razor",
                HeaderText = "Interactive Periodic Table in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Periodic Table | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram explores interactive periodic tables with color-coded elements, hover details, and dynamic highlights for learning.",
            },
            new Sample
            {
                Name = "History Timeline Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/history-timeline",
                FileName = "HistoryTimeLine.razor",
                HeaderText = "Example of Interactive Internet History Timeline in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Demos - History Timeline Diagram Examples | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram visualizes internet history with interactive timelines, milestones, and color-coded segments for key events in history.",
            },
            new Sample
            {
                Name = "Funnel Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/funnel-diagram",
                FileName = "FunnelDiagram.razor",
                HeaderText = "Example of a Marketing Funnel in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Funnel Diagram | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram creates infographic funnels with customizable node shapes and colors showing stage-wise conversion and cumulative rates.",
            },            
            new Sample
            {
                Name = "Serpentine Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/serpentine-diagram",
                FileName = "SerpentineDiagram.razor",
                HeaderText = "Example of a Serpentine diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - Serpentine Diagram | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram visualizes medical research breakthroughs with serpentine layout for healthcare history from 1796 to 1996 in diagrams.",
            },
            // Ignore: From Build
            new Sample
            {
                Name = "Solar Panel Angle",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/angle",
                FileName = "AngleSample.razor",
                HeaderText = "Example of Smart Solar Panel Tilt System in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - Solar Panel Angle | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram demonstrates smart solar panel tilt systems with interactive angle adjustment and efficiency tracking for dashboards.",
            },
            // End: Ignore
            // Ignore: From Build
            new Sample
            {
                Name = "P&ID Diagram",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/pipeline-instrumentation-diagram",
                FileName = "PipeLineDiagram.razor",
                HeaderText = "Example of Real-time Pipeline & Instrumentation Diagram (P&ID) in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - P&ID Diagram | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram simulates chemical reactor P&IDs with interactive fluid flows, tank levels, and temperature controls via animations.",
            },
            // End: Ignore
            new Sample
            {
                Name = "Neural Network",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/neural-network",
                FileName = "NeuralNetwork.razor",
                HeaderText = "Example of Interactive Neural Network Architecture Visualizer in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Neural Network | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram visualizes neural network architectures with interactive layers, weights, and data flow with animated connections.",
            },
            new Sample
            {
                Name = "Venn Diagram",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/venn-diagram",
                FileName = "VennDiagram.razor",
                HeaderText="Example of Venn Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Venn Diagram | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram visualizes set relationships and overlapping data for statistical analysis and logical comparisons between groups."
            },

            new Sample
            {
                Name = "Network Diagram",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/networkdiagram",
                FileName = "NetworkDiagram.razor",
                HeaderText="Example of Network Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Demos - Network Diagram Examples  | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram documents IT infrastructure with network topology, connections, and device relationships for system documentation.",

            },
            new Sample
            {
                Name = "Ishikawa Diagram",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/ishikawadiagram",
                FileName = "IshikawaDiagram.razor",
                HeaderText="Example of Ishikawa Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - Ishikawa Diagram | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram performs cause-and-effect analysis with fishbone structures for problem-solving and quality management processes.",
            },
            new Sample
            {
                Name = "Fishbone Diagram",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/fishbone-diagram",
                FileName = "FishboneDiagram.razor",
                HeaderText="Example of Fishbone Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - Fishbone Diagram | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram visualizes root cause analysis for quality control and problem-solving methodologies in business process diagrams."
            },
            new Sample
            {
                Name = "Workflow Diagram",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/workflow-diagram",
                FileName = "WorkflowDiagram.razor",
                HeaderText="Example of Workflow Diagram in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram - Workflow Diagram | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram visualizes business processes with decision points and task sequences for operational documentation in web apps.",

            },
            new Sample
            {
                Name = "Flow Execution",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/flow-execution",
                FileName = "FlowExecution.razor",
                HeaderText="Example of Flow Execution in Blazor Diagram Component",
                MetaTitle = "Blazor Diagram Examples - Flow Execution | Diagram Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Diagram shows dynamic process execution with real-time status updates and interactive flow control for monitoring applications."
            },
            new Sample
            {
                Name = "Diagram Binding With TreeView",
                Category = "Real-time Diagrams",
                Directory = "Diagram/Diagram",
                Url = "diagram/diagramwithtreeview",
                FileName = "DiagramWithTreeView.razor",
                MetaTitle = "Blazor Diagram Demos - Diagram Binding With TreeView | Syncfusion",
                HeaderText="Example of Treeview component in Blazor Diagram Component",
                MetaDescription = "See how the Syncfusion Blazor Diagram synchronizes hierarchical tree view and diagram visualization for enhanced data exploration and navigation in web apps.",
            }
        };
    }
}