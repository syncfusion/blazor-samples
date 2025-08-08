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
using BlazorDemos;
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
                MetaDescription = "This Blazor Flow Chart demonstrates process visualization with decision nodes, connectors, and flowchart symbols for business process mapping and workflow design.",
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
                MetaDescription = "This Blazor Diagram Shapes example demonstrates built-in shape library with basic, flowchart, and BPMN symbols for comprehensive diagram creation."
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
                MetaDescription = "This Blazor HTML Shapes example demonstrates custom node templates with HTML content for rich, interactive diagram elements and data visualization.",
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
                MetaDescription = "This Blazor Diagram Connectors example demonstrates various connector types, routing, and styling options for linking diagram elements effectively.",
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
                MetaDescription = "This Blazor Line Routing example demonstrates automatic connector routing to avoid obstacles and create clean, organized diagram layouts.",
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
                MetaDescription = "This Blazor Avoid Connector Overlap feature demonstrates automatic connector adjustment to minimize visual overlap for cleaner diagram presentation.",
                Type = SampleType.New,
                NotificationDescription = new string[]{ @"This sample demonstrates how connectors are automatically adjust to minimize visual overlap in Syncfusion Blazor Diagram."},
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
                MetaDescription = "This Blazor Diagram Ports example demonstrates connection points on nodes for precise connector attachment and controlled diagram connectivity.",
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
                MetaDescription = "This Blazor Diagram Rulers example demonstrates measurement guides and alignment tools for precise diagram element positioning and sizing.",
            },
            new Sample
            {
                Name = "Swimlanes",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/swimlane",
                FileName = "SwimlaneSample.razor",
                HeaderText="Example of Swimlanes in Blazor Diagram Component",
                MetaTitle = "Blazor Swimlanes | Process Lanes | Syncfusion",
                MetaDescription = "This Blazor Swimlanes example demonstrates process lane organization for business process modeling and workflow visualization with role separation.",
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
                MetaDescription = "This Blazor Diagram Container example demonstrates grouping and organizing diagram elements within containers for structured layout management.",
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"Updated the sample by enabling the Symbol Palette, allowing users to create customized diagrams with ease. This feature provides a flexible and user-friendly way to drag and drop predefined symbols onto the diagram surface, streamlining the diagram creation process."},
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
                MetaDescription = "This Blazor Diagram Events example demonstrates event handling for user interactions, selections, and diagram modifications for dynamic behavior.",
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
                MetaDescription = "This Blazor Diagram Tooltip example demonstrates hover information display for diagram elements with customizable content and positioning.",
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
                MetaDescription = "This Blazor Symbol Palette example demonstrates drag-and-drop shape library for easy diagram creation with organized symbol categories.",
            },
              new Sample
            {
                Name = "Z-Order",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/zorder",
                FileName = "ZOrder.razor",
                HeaderText="Example of ZOrder Commands in Blazor Diagram Component",
                MetaTitle = "Blazor Z-Order | Layer Management | Syncfusion",
                MetaDescription = "This Blazor Z-Order example demonstrates layer management commands for controlling element stacking order and visual hierarchy in diagrams.",
            },
                new Sample
            {
                Name = "Zooming and Panning",
                Category = "Interactive Features",
                Directory = "Diagram/Diagram",
                Url = "diagram/zooming-panning",
                FileName = "ZoomingPanning.razor",
                HeaderText="Example of Zooming and Panning in Blazor Diagram Component",
                MetaTitle = "Blazor Zoom Pan | Navigation Control | Syncfusion",
                MetaDescription = "This Blazor Zooming and Panning example demonstrates navigation controls for exploring large diagrams with smooth zoom and pan interactions.",
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
                MetaDescription = "This Blazor Diagram Overview example demonstrates miniature navigation panel for quick diagram exploration and viewport positioning.",
            },
                new Sample
            {
                Name = "History Manager",
                Category = "Getting Started",
                Directory = "Diagram/Diagram",
                Url = "diagram/historymanager",
                FileName = "HistoryManager.razor",
                HeaderText="Example of History Manager in Blazor Diagram Component",
                MetaTitle = "Blazor History Manager | Undo Redo | Syncfusion",
                MetaDescription = "This Blazor History Manager example demonstrates undo/redo functionality for tracking and reversing diagram changes and user actions.",
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
                MetaDescription = "This Blazor Drawing Tools example demonstrates interactive shape and connector creation tools for dynamic diagram building and editing.",
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
                MetaDescription = "This Blazor User Handles example demonstrates custom interactive controls around diagram elements for specialized operations and quick actions.",
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
                MetaDescription = "This Blazor Expand and Collapse example demonstrates hierarchical diagram navigation with expandable nodes for managing complex structures.",
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
                MetaDescription = "This Blazor Diagram Snapping example demonstrates automatic alignment guides and snap-to-grid functionality for precise element positioning.",
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
                MetaDescription = "This Blazor Diagram Scrolling example demonstrates viewport navigation and scrolling behavior for exploring large diagram content areas.",
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
                MetaDescription = "This Blazor Keyboard Interaction example demonstrates accessibility features with keyboard shortcuts for diagram navigation and element manipulation.",
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
                MetaDescription = "This Blazor Node Content example demonstrates custom content rendering within diagram nodes for rich data visualization and interactive elements.",
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
                MetaDescription = "This Blazor Flowchart Layout example demonstrates automatic arrangement of flowchart elements with intelligent positioning and routing algorithms.",
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
                MetaDescription = "This Blazor Organization Chart demonstrates hierarchical structure visualization with automatic layout for corporate and team organization mapping."
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
                MetaDescription = "This Blazor Mindmap Layout example demonstrates radial tree structure for brainstorming, idea organization, and knowledge mapping visualization.",
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
                MetaDescription = "This Blazor Hierarchical Tree demonstrates tree structure visualization with automatic layout for data hierarchy and decision tree representation.",
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
                MetaTitle = "Blazor Radial Tree | Circular Layout | Syncfusion",
                MetaDescription = "This Blazor Radial Tree demonstrates circular tree layout with central root node for network visualization and relationship mapping.",
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
                MetaDescription = "This Blazor PERT Chart demonstrates project evaluation and review technique visualization for project management and timeline planning.",
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
                MetaDescription = "This Blazor Local Data example demonstrates binding diagram elements to local data sources for static content visualization and data-driven diagrams."
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
                MetaDescription = "This Blazor Remote Data example demonstrates binding diagram elements to remote data sources and APIs for dynamic content visualization."
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
               MetaDescription = "This Blazor Diagram Serialization example demonstrates saving and loading diagram data for persistence and state management across sessions."
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
                MetaDescription = "This Blazor Diagram Print example demonstrates printing capabilities for generating hard copies of diagrams with customizable print settings."
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
                MetaDescription = "This Blazor BPMN Editor demonstrates business process modeling notation for workflow design and process documentation with standard BPMN symbols.",
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
                MetaDescription = "This Blazor Logic Circuit Diagram demonstrates digital logic design with gates, inputs, and outputs for computer science and engineering education.",
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
                Type = SampleType.Updated,
                NotificationDescription = new string[]{ @"This UML Sequence Diagram represents the flow of a transaction through a processing system. It shows a user initiating a transaction, followed by validation through a fraud detection system. Depending on the validation result, the transaction is either completed or canceled. This visualization helps demonstrate how systems handle conditional logic and interactions between components in a transactional flow."},
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
                MetaDescription = "This Blazor Venn Diagram demonstrates set relationships and overlapping data visualization for statistical analysis and logical comparisons."
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
                MetaDescription = "This Blazor Ishikawa Diagram demonstrates cause-and-effect analysis with fishbone structure for problem-solving and quality management processes.",
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
                MetaDescription = "This Blazor Workflow Diagram demonstrates business process flow visualization with decision points and task sequences for operational documentation.",
                
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
                MetaDescription = "This Blazor Flow Execution demonstrates dynamic process execution visualization with real-time status updates and interactive flow control."
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
            },

        };
    }
}