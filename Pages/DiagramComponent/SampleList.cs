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
                Category = "Getting started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/flowchart",
                FileName = "FlowChart.razor",
                HeaderText="Example of Flow Chart in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Shapes",
                Category = "Getting started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/shapes",
                FileName = "Shapes.razor",
                HeaderText="Example of Shapes in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Nodes",
                Category = "Getting started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/nodes",
                FileName = "Nodes.razor",
                HeaderText="Example of Nodes in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Flow Execution",
                Category = "Getting started",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/flow-execution",
                FileName = "FlowExecution.razor",
                HeaderText="Example of Flow Execution in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Hierarchical Tree",
                Category = "Automatic Layouts",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/hierarchical-tree",
                FileName = "HierarchicalTree.razor",
                HeaderText="Example of Hierarchical Tree in Blazor Diagram Component",
            },
            new Sample
            {
                Name = "Organization Chart",
                Category = "Automatic Layouts",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/organization-model",
                FileName = "OrganizationModel.razor",
                HeaderText="Example of Organization Chart in Blazor Diagram Component"
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
                Name = "Venn Diagram",
                Category = "Static Diagram",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/venn-diagram",
                FileName = "VennDiagram.razor",
                HeaderText="Example of Venn Diagram in Blazor Diagram Component"
            },
            new Sample
            {
                Name = "Fishbone Diagram",
                Category = "Static Diagram",
                Directory = "DiagramComponent/DiagramComponent",
                Url = "diagramcomponent/fishbone-diagram",
                FileName = "FishboneDiagram.razor",
                HeaderText="Example of Fishbone Diagram in Blazor Diagram Component"
            },
        };
    }
}
