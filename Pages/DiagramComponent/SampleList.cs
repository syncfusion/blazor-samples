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
                FileName = "FlowChart.razor",
                HeaderText="Flow Chart using Blazor Diagram Component Example"
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
                Name = "Node Template",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/nodetemplate",
                FileName = "NodeTemplateSample.razor",
                HeaderText="Example of NodeTemplate in Blazor Diagram Component",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Connectors",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/connectors",
                FileName = "ConnectorSample.razor",
                HeaderText="Example of Connectors in Blazor Diagram Component",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Annotations",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/annotations",
                Type=SampleType.New,
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
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Events",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/events",
                FileName = "Events.razor",
                HeaderText="Example of Events in Blazor Diagram Component",
                Type = SampleType.New
            },
            new Sample
            {
                 Name = "Constraints",
                Category = "Getting Started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/constraints",
                FileName = "Constraintssample.razor",
                Type=SampleType.New,
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
                Type = SampleType.New
            },              
             new Sample
            {
                Name = "Drawing Tools",
                Category = "Interactive Features",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/drawingtool",
                FileName = "DrawingToolSample.razor",
                Type=SampleType.New,
                HeaderText="Example of DrawingTools in Blazor Diagram Component"
            },
             new Sample
            {
                Name = "User Handles",
                Category = "Interactive Features",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/userhandles",
                FileName = "UserHandles.razor",
                HeaderText="Example of User Handles in Blazor Diagram Component",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Interactive Features",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/keyboard-interaction",
                FileName = "KeyboardInteraction.razor",
                HeaderText="Example of Keyboard Interaction in Blazor Diagram Component",
                Type = SampleType.New
            },                       
            new Sample
            {
                Name = "Organization Chart",
                Category = "Automatic Layouts",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/organization-model",
                FileName = "OrganizationModel.razor",
                Type=SampleType.Updated,
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
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Hierarchical Tree",
                Category = "Automatic Layouts",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/hierarchical-tree",
                FileName = "HierarchicalTree.razor",
                Type=SampleType.Updated,
                HeaderText="Hierarchical Tree Example using Blazor Diagram Component",
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
                Type=SampleType.Updated,
                HeaderText="Example of Remote Data in Blazor Diagram Component"
            },
            new Sample
            {
               Name = "Serialization",
               Category = "Save and Restore",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/serialization",
                FileName = "Serialization.razor",
                Type=SampleType.New,
               HeaderText="Example of Serialization in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Export",
                Category = "Export and Print",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/export",
                FileName = "ExportSample.razor",
                Type=SampleType.New,
                HeaderText="Example of Exporting in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Print",
                Category = "Export and Print",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/print",
                FileName = "PrintSample.razor",
                Type=SampleType.New,
                HeaderText="Example of Printing in Blazor Diagram Component"
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
        };
    }
}
