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
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/flowchart",
                FileName = "DefaultFunctionalities.razor"
            },
              new Sample
            {
                Name = "Shapes",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/shapes",
                FileName = "Shapes.razor"
            },
              new Sample
            {
                Name = "Nodes",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/nodes",
                FileName = "Nodes.razor"
            },
            new Sample
            {
                Name = "Connectors",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/connectors",
                FileName = "Connectors.razor"
            },
            new Sample
            {
                Name = "Annotations",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/annotations",
                FileName = "Annotations.razor"
            },
            new Sample
            {
                Name = "Ports",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/ports",
                FileName = "Ports.razor"
            },

            new Sample
            {
                Name = "HTML Template",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/complex-shapes",
                FileName = "HTMLTemplate.razor"
            },
            new Sample
            {
                Name = "History Manager",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/history-manager",
                FileName = "HistoryManager.razor"
            },

               new Sample
            {
                Name = "Flow Execution",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/flow-execution",
                FileName = "FlowExecution.razor"
            },
                new Sample
            {
                Name = "Line Routing",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/routing",
                FileName = "Routing.razor"
            },
             new Sample
            {
                Name = "Virtualization",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/virtualization",
                FileName = "Virtualization.razor"
            },
            new Sample
            {
                Name = "Logic Circuit Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/logic-circuit-diagram",
                FileName = "LogicCircuitDiagram.razor"
            },
            new Sample
            {
                Name = "Uml Activity",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/uml-activity",
                FileName = "umlActivity.razor",
            },
            new Sample
            {
                Name = "UML Class Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/uml-class",
                FileName = "UmlClass.razor"
            },
            new Sample
            {
                Name = "Hierarchical Tree",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/hierarchical-tree",
                FileName = "HierarchicalModel.razor"
            },
            new Sample
            {
                Name = "Organization Chart",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/organization-model",
                FileName = "OrganizationModel.razor"
            },
            new Sample
            {
                Name = "Radial Tree",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/radial-tree",
                FileName = "RadialTree.razor"
            },
            new Sample
            {
                Name = "Mind Map",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/mind-map",
                FileName = "MindMap.razor"
              }, new Sample
            {
                Name = "Symmetric Layout",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/symmetric-layout",
                FileName = "SymmetricLayout.razor"
            },
            new Sample
            {
                Name = "Complex Hierarchical Tree",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/complex-hierarchical-tree",
                FileName = "ComplexHierarchicalTree.razor"
            },
            new Sample
            {
                Name = "RTL Tree",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/rtl-tree",
                FileName = "RTLTree.razor"
            },
            new Sample
            {
                Name = "Pert Chart",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/pert-chart",
                FileName = "PertChart.razor"
            },
            new Sample
            {
                Name = "Drawing Tools",
                Category = "User Interaction",
                Directory = "Diagram/Diagram",
                Url = "diagram/drawing-tool",
                FileName = "DrawingTool.razor"
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "User Interaction",
                Directory = "Diagram/Diagram",
                Url = "diagram/keyboard-interaction",
                FileName = "Keyboardinteraction.razor"
            },
            new Sample
            {
                Name = "User Handles",
                Category = "User Interaction",
                Directory = "Diagram/Diagram",
                Url = "diagram/user-handles",
                FileName = "UserHandles.razor"
            },
            new Sample
            {
                Name = "Symbol Palette",
                Category = "User Interaction",
                Directory = "Diagram/Diagram",
                Url = "diagram/symbol-palette",
                FileName = "SymbolPalette.razor"
            },

            new Sample
            {
                Name = "Overview Panel",
                Category = "User Interaction",
                Directory = "Diagram/Diagram",
                Url = "diagram/overview",
                FileName = "OverView.razor"
            },
             new Sample
            {
                Name = "Save and Load",
                Category = "User Interaction",
                Directory = "Diagram/Diagram",
                Url = "diagram/serialization",
                FileName = "Serialization.razor"
            },
            new Sample
            {
                Name = "Print and Export",
                Category = "User Interaction",
                Directory = "Diagram/Diagram",
                Url = "diagram/print-and-Export",
                FileName = "PrintandExport.razor"
            },

            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Diagram/Diagram",
                Url = "diagram/local-data",
                FileName = "LocalData.razor"
            },
            new Sample
            {
                Name = "Venn Diagram",
                Category = "Static Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/venn-diagram",
                FileName = "VennDiagram.razor"
            },
            new Sample
            {
                Name = "Fishbone Diagram",
                Category = "Static Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/fishbone-diagram",
                FileName = "FishboneDiagram.razor"
            },
        };
    }
}
