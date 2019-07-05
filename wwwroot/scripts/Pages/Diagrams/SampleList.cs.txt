using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Diagram { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Getting started",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor"
            },
              new Sample
            {
                Name = "Shapes",
                Category = "Getting started",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/Shapes",
                FileName = "Shapes.razor"
            },
              new Sample
            {
                Name = "Nodes",
                Category = "Getting started",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/Nodes",
                FileName = "Nodes.razor",
                Type = SampleType.New
            },
              new Sample
           {
                Name = "Ports",
                Category = "Getting started",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/Ports",
                FileName = "Ports.razor",
                Type = SampleType.New
            },
               new Sample
            {
                Name = "Flow Execution",
                Category = "Getting started",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/FlowExecution",
                FileName = "FlowExecution.razor",
                Type = SampleType.New
            },
               new Sample
            {
                Name = "Logic Circuit Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/LogicCircuitDiagram",
                FileName = "LogicCircuitDiagram.razor",
                Type = SampleType.New
            },
              new Sample
            {
                Name = "UML Activity Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/UMLActivity",
                FileName = "UMLActivity.razor",
                Type = SampleType.New
            }, 
            new Sample
            {
                Name = "Hierarchical tree",
                Category = "Automatic Layouts",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/HierarchicalModel",
                FileName = "HierarchicalModel.razor"
            },
              new Sample
            {
                Name = "Organization Chart",
                Category = "Automatic Layouts",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/OrganizationModel",
                FileName = "OrganizationModel.razor"
            },
             new Sample
            {
                Name = "VennDiagram",
                Category = "Static Diagram",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/VennDiagram",
                FileName = "VennDiagram.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Fishbone Diagram",
                Category = "Static Diagram",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/FishboneDiagram",
                FileName = "FishboneDiagram.razor",
                Type = SampleType.New
            }
        };
    }
}
