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
                FileName = "DefaultFunctionalities.razor",
                TitleTag = "Diagram . DefaultFunctionalities . Syncfusion Blazor Components",
                MetaDescription = "This demo for EJ2 Blazor Diagram control sample visualizes the processing of an order placed using credit card payment and payment validation with built-in flow shapes.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the processing of an order placed using credit card with built-in flow shapes in Syncfusion EJ2 Typescript Diagram.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    This example shows how to create a simple flow chart using the diagram control. The <code>DiagramNodes</code> property can
                    be used to define different stages of a process. To define the flow between different stages, the <code>DiagramConnectors</code>        property
                    can be used.
                </p>

                <p>
                    To easily build flow diagrams, few shapes are predefined and added to symbol palette. You can drag-and-drop predefined shapes
                    into the drawing area. The <code>Symbols</code> property allows you to add predefined symbols to the palette.
                </p>

                <p>
                    In this example, undo and redo support is enabled.
                </p>
                <br>"
                }
            },
              new Sample
            {
                Name = "Shapes",
                Category = "Getting started",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/Shapes",
                FileName = "Shapes.razor",
                TitleTag = "Diagram . Shapes . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential JS2 Diagram control illustrates basic built-in shapes, such as basic shapes and flow shapes.",
                ActionDescription = new string[] {
                    @" <p>
                    This sample illustrates basic built-in shapes, such as basic shapes and flow shapes.
                </p>"
                },
                Description = new string[] {
                @"<p>
                    This example shows how to define built-in shapes that are used to visualize geometric information, work flow, or a business
                    flow diagrams. The
                    <code>Type</code> property of the
                    <code>Shape</code> allows you to choose the type of the shape.
                </p>
                <br>"
                }
            },
              new Sample
            {
                Name = "Nodes",
                Category = "Getting started",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/Nodes",
                FileName = "Nodes.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . Nodes . Syncfusion Blazor Components",
                MetaDescription = "This demo for EJ2 Blazor Diagram control shows the stages of a software development cycle using circular flow diagram with node customization options.",
                ActionDescription = new string[] {
                    @"    <p>
                    This sample visualizes the different stages of a software development life cycle using a circular flow diagram.
                </p>"
                },
                Description = new string[] {
                @"<p>
                    This example shows how to add nodes to a diagram control and how to customize the appearance of the nodes. The
                    <code>NodeShapeStyle</code> property of the node can be used to customize the appearance of the nodes.
                </p>
                <br>"
                }
            },
              new Sample
           {
                Name = "Ports",
                Category = "Getting started",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/Ports",
                FileName = "Ports.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . Ports . Syncfusion Blazor Components",
                MetaDescription = "This demo for EJ2 Blazor Diagram control shows the flow of book publishing using connection points on the nodes for creating connections.",
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the process flow of publishing a book using connection points. Connection points are static points over the shapes that allow creating connections to the shapes.
                    </p>"
                },
                Description = new string[] {
                @"<p>
                        This example shows how to add connection ports to shapes. The <code>DiagramPorts</code> property of the node defines the static connection ports. The <code>NodePortOffset</code>, <code>HorizontalAlignment</code>, <code>VerticalAlignment</code> and <code>NodePortMargin</code> properties of the ports define its position.
                    </p>
                    <p>
                        The <code>PortShapeStyle</code> property of the port can be used to customize its appearance. The <code>Visibility</code> property can also be used to define when the connection ports should be visible.
                    </p>
                    <br>"
                }
            },
               new Sample
            {
                Name = "Flow Execution",
                Category = "Getting started",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/FlowExecution",
                FileName = "FlowExecution.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . FlowExecution . Syncfusion Blazor Components",
                MetaDescription = "This demo for EJ2 Blazor Diagram control sample visualizes the processing of an order placed using credit card payment and payment validation with built-in flow shapes.",
                ActionDescription = new string[] {
                    @" <p>
                        This sample demonstrates how we can process and get the consecutive nodes and connectors respectively.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        We can get the inward connections and outward connections of the node using <code>InEdges</code> and <code>OutEdges</code>        properties of the node. By using this connector’s name collection, we can find the node using <code>GetObject</code>.
                        And also, we can get the nodes connected on the connector using <code>SourceNode</code> and <code>TargetNode</code>        properties of the connector.
                    </p>
                    <br>"
                }
            },
               new Sample
            {
                Name = "Logic Circuit Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/LogicCircuitDiagram",
                FileName = "LogicCircuitDiagram.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . LogicCircuitDiagram . Syncfusion Blazor Components",
                MetaDescription = "This sample visualizes implementation of three input Boolean functions using universal logic gates. The shapes for logic gates are designed with node's path feature.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes implementation of three input Boolean functions using universal logic gates. The shapes for logic gates are designed with diagram's path node feature.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    This example shows how to create Boolean algebraic laws and theorems using diagram <code>DiagramPath</code> shapes. The <code>Type</code>
                    property of the <code>Shape</code> can be used to create <code>DiagramPath</code> nodes. The <code>Data</code> property of the shape allows you to
                    define path data of the path shape.
                    </p>"
                }
            },
              new Sample
            {
                Name = "UML Activity Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/UMLActivity",
                FileName = "UMLActivity.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . UMLActivity . Syncfusion Blazor Components",
                MetaDescription = "This sample represents the message flow from one activity to another in customer service using built-in UML activity shapes.",
                ActionDescription = new string[] {
                    @" <p>
                        This sample represents the message flow from one activity to another in customer service using built-in UML activity shapes.

                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This example shows how to create activity shapes using diagram <code>DiagramUmlActivityShape</code> shapes. The <code>Type</code> property of the
                    <code>Shape</code> can be used to create <code>DiagramUmlActivityShape</code> nodes. The <code>Shape</code> property of the shape allows you to create UML
                    activity shapes.
                    </p>
                    <br>"
                }
            }, 
            new Sample
            {
                Name = "Hierarchical tree",
                Category = "Automatic Layouts",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/HierarchicalModel",
                FileName = "HierarchicalModel.razor",
                TitleTag = "Diagram . HierarchicalModel . Syncfusion Blazor Components",
                MetaDescription = "This demo for EJ2 Blazor Diagram control illustrates a simple hierarchical tree built from external data source with diagram customization options.",
                ActionDescription = new string[] {
                    @"<p>
                    Diagram component's features are segregated into individual feature-wise modules. To generate diagrams from
                    external data source,
                </p>
                <br>"
                },
                Description = new string[] {
                @"<p>
                    In this example, you can see how to generate a hierarchical tree from external data sources. You can also
                    customize the
                    spacing between the objects in the tree. You can use the
                    <code>HorizontalSpacing</code> and
                    <code>VerticalSpacing</code> properties of
                    <code>DiagramLayout</code> to customize the space between the objects in the tree. You can use the
                    <code>LayoutOrientation</code> property of
                    <code>DiagramLayout</code> to change the orientation of the tree.
                </p>
                <p>
                    To change the orientation of the tree, click the templates that are added to the property panel.
                </p>"

                }
            },
              new Sample
            {
                Name = "Organization Chart",
                Category = "Automatic Layouts",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/OrganizationModel",
                FileName = "OrganizationModel.razor",
                TitleTag = "Diagram . OrganizationModel . Syncfusion Blazor Components",
                MetaDescription = "This demo for EJ2 Blazor Diagram control illustrates a management structure built from external data. Customization of orientation/structure is also enabled.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a simple business management structure that is built from an external data source. Hierarchical tree
                    layout algorithm is used to build organizational charts.</p>"
                },
                Description = new string[] {
                    @"<p>
                    This example shows how to generate an organizational chart from an external data source. The spacing between the objects can also be customized in the chart. The
                    <code>HorizontalSpacing</code> and
                    <code>VerticalSpacing</code> properties of
                    <code>DiagramLayout</code> can be used to customize the space between objects in a tree. The
                    <code>LayoutOrientation</code> property of
                    <code>DiagramLayout</code> can be used to change the orientation of the chart. The
                    <code>GetLayoutInfo</code> property of
                    <code>DiagramLayout</code> can be used to customize the tree structure.

                </p>"
                }
            },
             new Sample
            {
                Name = "VennDiagram",
                Category = "Static Diagram",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/VennDiagram",
                FileName = "VennDiagram.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . VennDiagram . Syncfusion Blazor Components",
                MetaDescription = "This demo for Essential JS2 Diagram control visually represents the hotel booking reservation system. It is built with readymade BPMN shapes.",
                ActionDescription = new string[] {
                    @" <p>
                    This sample visualizes classifications of data science using Venn diagrams. Diagram nodes and annotations are used to define Venn diagrams. Read only mode is enabled in this example.
                    </p>"
                },
                Description = new string[] {
                @"<p>
                    This example shows how to create a Venn diagram using diagram control. In this example, zoom and pan options are enabled.
                    The <code>Tool</code> property of the diagram control allows you to enable/disable zoom and pan options.
                </p>
                <br>"
                }
            },
             new Sample
            {
                Name = "Fishbone Diagram",
                Category = "Static Diagram",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/FishboneDiagram",
                FileName = "FishboneDiagram.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . FishboneDiagram . Syncfusion Blazor Components",
                MetaDescription = "This demo for EJ2 Blazor Diagram control visually represents a simple fishbone diagram (Ishikawa). Diagram nodes/annotations are used to define fishbone diagrams.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample visually represents a simple fishbone diagram (Ishikawa). Diagram nodes and annotations are used to define fishbone diagrams. Read-only mode is enabled here.
                    </p>"
                },
                Description = new string[] {
                @"<p>
                    This sample shows how to create a fishbone diagram (Ishikawa) using diagram control. Here, zoom and pan options are enabled. The tool property of the diagram control allows you to enable or disable zoom and pan options.
                </p>
                <br>"
                }
            }
        };
    }
}
