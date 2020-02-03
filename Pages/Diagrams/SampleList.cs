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
                    This sample visualizes the processing of an order placed using credit card with built-in flow shapes in Syncfusion Blazor Diagram.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    This example shows how to create a simple flow chart using the diagram control. The <code>Nodes</code> property can
                    be used to define different stages of a process. To define the flow between different stages, the <code>Connectors</code>        property
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
                TitleTag = "Diagram . Shapes . Syncfusion Blazor Components - Preview",
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
                    <code>Style</code> property of the node can be used to customize the appearance of the nodes.
                </p>
                <br>"
                }
            },
            new Sample
            {
                Name = "Connectors",
                Category = "Getting started",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/Connectors",
                FileName = "Connectors.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . Connectors . Syncfusion Blazor Components - Preview",
                MetaDescription = "This sample visualizes the data flow in a marketing process using predefined shapes and connectors. Different types of connectors and decorators are used to customize the appearance, path, and direction of the data flow.",
                   ActionDescription = new string[] {
                    @"    <p>
                    This sample visualizes the data flow in a marketing process using predefined shapes and connectors. Different types of connectors and decorators are used to customize the appearance, path, and direction of the data flow.
                </p>"
                },
                Description = new string[] {
                 @"
                 <p>In this example, you can see how to add connectors to connect the shapes and how to customize the appearance of the connectors. You can use the style property of the connector to customize its stroke style. You can use the <code>CornerRadius</code> property to add connectors with rounded corners.</p>
                 <p>To change the appearance, click different styles in the property panel. Additionally, you can see how to lock the connectors to disable editing. The <code>Constraints</code> property of connector enables/disables editing. In this example, the shapes are automatically arranged using hierarchical tree layout.</p>
                 <p>To change the position of the descriptions, select a node and choose the template in the property panel.</p>
                 <br>"
                }
            },
            new Sample
            {
                Name = "Annotations",
                Category = "Getting started",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/Annotations",
                FileName = "Annotations.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . Annotations . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo for EJ2 ASP.NET Core Diagram control is illustrated by five forces chart. Customizing the position/appearance of the annotation is also illustrated.",
                 ActionDescription = new string[] {
               @" <p>
                   This sample illustrates the competitive environment of a business through five forces chart. The elements of the five force chart is described using nodes and annotations. Customizing the position and appearance of the annotation is illustrated in this example.
                 </p>"
                 },
    Description = new string[] {
       @"<p>
            This example shows how to add textual descriptions to shapes and how to position them over the shapes. The <code>annotations</code> property of the node can be used to add descriptions.

        </p>
        <p>
             The <code>Offset</code>, <code>HorizontalAlignment</code>, and<code>VerticalAlignment</code> properties of the
        annotation can be used to customize the position of the descriptions. The <code>Bold</code>,<code>Italic</code>,
        <code>FontSize</code>, and <code>FontFamily</code> properties can be used to customize the appearance of the
        descriptions.

        </p>
        <p>
            To change the position of the descriptions, select a node and choose the template in the property panel.
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
                        This example shows how to add connection ports to shapes. The <code>DiagramPorts</code> property of the node defines the static connection ports. The <code>Offset</code>, <code>HorizontalAlignment</code>, <code>VerticalAlignment</code> and <code>Margin</code> properties of the ports define its position.
                    </p>
                    <p>
                        The <code>Style</code> property of the port can be used to customize its appearance. The <code>Visibility</code> property can also be used to define when the connection ports should be visible.
                    </p>
                    <br>"
                }
            },

            new Sample
            {
                Name = "Complex Shapes",
                Category = "Getting started",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/ComplexShapes",
                FileName = "ComplexShapes.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . Complex Shapes . Syncfusion Blazor Components - Preview",
                MetaDescription = "This sample demonstrates how to host a HTML element inside a node. In this example, a Gauge control is hosted inside a HTML Node.",
                ActionDescription = new string[] {
                  @" <p>
                     This sample demonstrates how to host a HTML element inside a node. In this example, a Gauge control is hosted inside a HTML Node.
                    </p>"
                },
                Description = new string[]
                {
                    @"<p>
                    This example shows how to host a control inside a node. The <code>NodeTemplate</code> property of the diagramtemplates can be used to host HTML Content inside a node. The content property of the shape allows you to define the content to be hosted.
                   </p>

                    <br>"
                }
            },
            new Sample
            {
                Name = "History Manager",
                Category = "Getting started",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/HistoryManager",
                FileName = "HistoryManager.razor",
                TitleTag = "Diagram . History Manager . Syncfusion Blazor Components - Preview",
                MetaDescription = "This sample demonstrates viewing, deleting, limiting diagram history and groups diagram actions and stores it as a single entry in the history manager.",
                ActionDescription = new string[]
                {
                     @" <p>
                       This sample demonstrates viewing, deleting, limiting diagram history and groups diagram actions and stores it as a single entry in the history manager.
                      </p>"
                },
                Description = new string[] {
                @"<p>
                Diagram history are being handle all the diagram history. Using <code>SetStackLimit</code> method of the diagram
                we limit the no. of entries can be stored on the diagram history. Also, we can get the list of entries in the undo
                list and redo list using <code>GetHistoryStack(true)</code> and <code>GetHistoryStack(false)</code> method of the diagram. Also we have the
                option to group the action as the single entry by the help of the <code>StartGroupAction</code> and <code>EndGroupAction</code> of the diagram. Also, we can add the custom entries to the diagram history.
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
                TitleTag = "Diagram . Flow Execution . Syncfusion Blazor Components",
                MetaDescription = "This demo for EJ2 Blazor Diagram control sample visualizes the processing of an order placed using credit card payment and payment validation with built-in flow shapes.",
                ActionDescription = new string[] {
                    @" <p>
                        This sample demonstrates how we can process and get the consecutive nodes and connectors respectively.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        We can get the inward connections and outward connections of the node using <code>getEdges(nodeId,false)</code> and <code>getEdges(nodeId,true)</code>    methods of the diagram. By using this connector’s name collection, we can find the node using <code>GetNode</code>.
                        And also, we can get the nodes connected on the connector using <code>SourceNode</code> and <code>TargetNode</code>        properties of the connector.
                    </p>
                    <br>"
                }
            },
             new Sample
            {
                Name = "Line Routing",
                Category = "Getting started",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/Routing",
                FileName = "Routing.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . Line Routing . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo for EJ2 Blazor Diagram control visualizes the connectors that are automatically re-routing or moving away if any shape found on the connectors path.",
                ActionDescription = new string[] {
                           @" <p>
                              This sample visualizes the connectors that are automatically re-routing or moving away if any shape found on the connectors path.
                            </p>"
                 },
                Description = new string[] {
                  @"<p>
                    This example shows how the connectors are automatically re-routing or moving away on dragging a shape near it. This can be achieved by the constraints property of the diagram and connector.
                   </p>
                  <br>"
                }
            },
            //   new Sample
            //{
            //    Name = "Logic Circuit Diagram",
            //    Category = "Use Case Diagram",
            //    Directory = "Diagrams/Diagram",
            //    Url = "Diagrams/LogicCircuitDiagram",
            //    FileName = "LogicCircuitDiagram.razor",
            //    Type = SampleType.New,
            //    TitleTag = "Diagram . LogicCircuitDiagram . Syncfusion Blazor Components - Preview",
            //    MetaDescription = "This sample visualizes implementation of three input Boolean functions using universal logic gates. The shapes for logic gates are designed with node's path feature."

            //},
            //  new Sample
            //{
            //    Name = "UML Activity Diagram",
            //    Category = "Use Case Diagram",
            //    Directory = "Diagrams/Diagram",
            //    Url = "Diagrams/UMLActivity",
            //    FileName = "UMLActivity.razor",
            //    Type = SampleType.New,
            //    TitleTag = "Diagram . UMLActivity . Syncfusion Blazor Components - Preview",
            //    MetaDescription = "This sample represents the message flow from one activity to another in customer service using built-in UML activity shapes."
            //},
            new Sample
            {
                Name = "Hierarchical Tree",
                Category = "Automatic Layouts",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/hierarchical-tree",
                FileName = "HierarchicalModel.razor",
                TitleTag = "Diagram . Hierarchical Tree . Syncfusion Blazor Components",
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
                    <code>Orientation</code> property of <code>DiagramLayout</code> to change the orientation of the tree.
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

                TitleTag = "Diagram . Organization Chart . Syncfusion Blazor Components",
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
                    <code>Orientation</code> property of
                    <code>DiagramLayout</code> can be used to change the orientation of the chart. 

                </p>"
                }
            },
            new Sample
            {
                Name = "Mind Map",
                Category = "Automatic Layouts",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/MindMap",
                FileName = "MindMap.razor",
                TitleTag = "Diagram . Mind Map . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo for EJ2 ASP.NET Core Diagram control demonstrates the concept of creativity using mind map. User handles are used for extending it interactively.",
                ActionDescription = new string[] {
                  @"<p>
                    This sample demonstrates the concept of creativity using mind map layout algorithm. User handles are used to extend the mind map interactively.</p>"
                    },
                Description = new string[] {
                  @"<p>
                    This example shows how to generate an Mind map from an external data source. The spacing between the objects can also be customized in the chart. The
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
                Name = "Complex Hierarchical Tree",
                Category = "Automatic Layouts",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/ComplexHierarchicalTree",
                FileName = "ComplexHierarchicalTree.razor",
                TitleTag = "Diagram . Complex Hierarchical Tree . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo for EJ2 ASP.NET Core Diagram control demonstrates the concept of creativity using mind map. User handles are used for extending it interactively.",
                ActionDescription = new string[] {
                   @"<p>
                     This sample illustrates a simple business management structure that is built from an external data source. Hierarchical tree
                     layout algorithm is used to build organizational charts.</p>"
                 },
                Description = new string[] {
                  @"<p>
                    In this example, you can see how to generate a complex hierarchical tree from external data sources. You can also customize spacing between the objects in the tree. You can use the <code>HorizontalSpacing</code> and <code>VerticalSpacing</code> properties of <code>DiagramLayout</code> to customize the space between the objects in the tree. You can use the <code>Orientation</code> property of <code>DiagramLayout</code> to change the orientation of the tree.

                    To change the orientation of the tree, click the templates in the property panel.
                   </p>"

                }
            },
            new Sample
            {
                Name = "Drawing Tools",
                Category = "User Interaction",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/DrawingTool",
                FileName = "DrawingTool.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . Drawing Tool . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo for EJ2 Blazor Diagram control shows the flow of book publishing using connection points on the nodes for creating connections.",
                ActionDescription = new string[] {
                @" <p>
                   This sample visualizes how to build a diagram interactively using drawing tools. Continuous draw option, snapping, and undo/redo support are enabled to easily draw diagrams. Rulers, gridlines, and snapping options are enabled to easily align objects.
                  </p>"
                },
                Description = new string[] {
                  @"<p>
                   This example shows how to draw shapes and connections interactively. In addition to that, rulers, gridlines, and snapping options are enabled to assist drawing. The Tool property can be used to enable drawing. Add <code>DrawOnce</code> or <code>ContinousDraw</code> option to the <code>Tool</code> property of the diagram. The <code>DrawingObject</code> property can be used to define a shape/connector to be drawn.

                   Few shape and connector templates are added in the palette. To draw basic shapes and connectors, click the templates in the palette. For polygon shapes, a corner/point will be added to the polygon for each mouse left button click. Drawing will be completed either on mouse right button click or double click.
                   </p>"

                }
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "User Interaction",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/Keyboardinteraction",
                FileName = "Keyboardinteraction.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . Keyboard Interaction . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo for Essential JS2 Diagram control illustrates interaction with diagram control using shortcut keys. Command Manager support is used to manage keyboard interactions.",
                ActionDescription = new string[] {
                 @" <p>
                     This sample illustrates interaction with diagram control using shortcut keys. Command Manager support is used to manage keyboard interactions.
                   </p>"
                },
                 Description = new string[] {
                  @"<p>
                    This example shows how to interact with the diagram control using shortcut keys. The <code>CommandManager</code> property can be used to map the commands with key gestures. In this example, along with the built-in commands a few custom commands are added and a few built-in commands (nudge) are overridden. That is, when the arrow keys are pressed, selection will be navigated instead of moving the selected objects. The different kinds of interactions and the corresponding key gestures are listed in the property panel.
                    </p>"
                 }
            },
            new Sample
            {
                Name = "User Handles",
                Category = "User Interaction",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/UserHandles",
                FileName = "UserHandles.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . User Handles . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo for EJ2 Blazor Diagram control shows the flow of book publishing using connection points on the nodes for creating connections.",
                ActionDescription = new string[] {
                  @"<p>This sample visualizes a simple flow diagram along with options to execute the frequently used commands using user handles.</p>"
                },
                 Description = new string[] {
                   @"<p>User handles are icons that are placed around the node to run the frequently used commands. This example shows how to render and configure user handles and how to interact with the diagram using user handles. The <code>UserHandles</code> property of the <code>SelectedItems</code> can be used to add user handles to the diagram. Click the templates in the property panel, to customize the size, position, and appearance of the user handles.</p><br>"
                 }
            },
            new Sample
            {
                Name = "Symbol Palette",
                Category = "User Interaction",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/SymbolPalette",
                FileName = "SymbolPalette.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . Ports . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo for EJ2 Blazor Diagram control shows the flow of book publishing using connection points on the nodes for creating connections.",
                ActionDescription = new string[] {
                    @"<p>
                     This example illustrates predefining shapes in a palette that can be easily dragged and dropped into the
                    drawing area. Customizable options of the symbol palette are also illustrated in this example.
                    </p>
                    </p>
                    <p>
                     In this example, options to enable/disable animation, show/hide symbol descriptions, and show header icons are
                      provided.
                    </p>"
                },
                 Description = new string[] {
                    @"<p>
                       This example shows how to add shapes to symbol palette and how to customize it. The <code>Symbols</code>
                       property can be used to add shapes to the symbol palette. The <code>SymbolWidth</code> and <code>SymbolHeight</code>
                       properties allow you to define the size of the symbols.

                      </p>
                     <br>"
                 }
            },

            new Sample
            {
                Name = "Overview Panel",
                Category = "User Interaction",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/OverView",
                FileName = "OverView.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . Overview Panel . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo for EJ2 Blazor Diagram control shows the flow of book publishing using connection points on the nodes for creating connections.",
                ActionDescription = new string[] {
                  @" <p>
                     This sample visualizes an organizational structure along with an overview for easily navigating the large organizational structure using Overview Panel.
                     </p>"
                },
                Description = new string[] {
                  @"<p>
                    This example shows how to render the Overview Panel and how to display a preview (overall view) of the entire content of a diagram. This helps you look at the overall picture of a large diagram and also to navigate (pan or zoom) to a particular position of the page. The <code>SourceID</code> property can be used to map the diagram control with Overview Panel.
                   </p>
                   <br>"
                }
            },
            new Sample
            {
                Name = "Print and Export",
                Category = "User Interaction",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/PrintandExport",
                FileName = "PrintandExport.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . Print and Export . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo for EJ2 Blazor Diagram control shows the flow of book publishing using connection points on the nodes for creating connections.",
                ActionDescription = new string[] {
                 @" <p>
                    This sample demonstrates printing and exporting the diagram as images.

                    </p>"
                },
                Description = new string[] {
                 @"<p>
                   This example shows how to print the diagram and how to export the diagram as image (*.jpg, *.png, and *bmp) and
                    in SVG format. The <code>ExportDiagram</code> method can be used to export the diagram. The <code>ExportDiagram</code>
                    method takes the exporting options (file formats, mode of export, and the region to export) as input. The <code>Print</code>
                     method can be used to print the diagram.
                   </p>

                   <br>"
                }
            },
            new Sample
            {
                Name = "Save and Load",
                Category = "User Interaction",
                Directory = "Diagrams/Serialization",
                Url = "Diagrams/Serialization",
                FileName = "Serialization.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . Save and Load . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo for EJ2 Blazor Diagram control visualizes building diagrams interactively using symbol palette and editing the saved diagrams.",
                ActionDescription = new string[] {
                @" <p>
                  This sample visualizes building diagrams interactively and editing the saved diagrams. Symbol Palette is used
                  to easily build diagrams.
                 </p>"
                },
                Description = new string[] {
                 @"<p>
                    This example shows how to drag-and-drop shapes and connectors from symbol palette to build diagrams. You can
                    save the diagram as text files and edit the pre-saved diagrams. The
                    <code>SaveDiagram</code> method can be used to save the diagram as string. The
                    <code>LoadDiagram</code> method can be used to load the diagram from a string. In this example, context menu
                    and undo/redo features are enabled.
                  </p>
                 <br>"
                }
            },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Diagrams/Diagram",
                Url = "Diagrams/LocalData",
                FileName = "LocalData.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . Ports . Syncfusion Blazor Components - Preview",
                MetaDescription = "This demo for EJ2 Blazor Diagram control shows the flow of book publishing using connection points on the nodes for creating connections.",
                ActionDescription = new string[] {
                 @" <p>
                   This sample visualizes the classifications of species using hierarchical tree layout algorithm. Data Manager support is used to bind data with the diagram.
                   </p>"
                },
                Description = new string[] {
                @"<p>
                  This example shows how to generate a diagram from the saved data. The <code>DiagramDataSource</code> property can be used to map an external data source with the diagram control. The <code>Id</code> property of DiagramDataSource can be used to define a unique field of an external data. The <code>parentId</code> property can be used to define the relationship between the objects.
                 </p>
                 <br>"
                }
            },
            // new Sample
            //{
            //    Name = "VennDiagram",
            //    Category = "Static Diagram",
            //    Directory = "Diagrams/Diagram",
            //    Url = "Diagrams/VennDiagram",
            //    FileName = "VennDiagram.razor",
            //    Type = SampleType.New,
            //    TitleTag = "Diagram . VennDiagram . Syncfusion Blazor Components - Preview",
            //    MetaDescription = "This demo for Essential JS2 Diagram control visually represents the hotel booking reservation system. It is built with readymade BPMN shapes."
            //},
            // new Sample
            //{
            //    Name = "Fishbone Diagram",
            //    Category = "Static Diagram",
            //    Directory = "Diagrams/Diagram",
            //    Url = "Diagrams/FishboneDiagram",
            //    FileName = "FishboneDiagram.razor",
            //    Type = SampleType.New,
            //    TitleTag = "Diagram . FishboneDiagram . Syncfusion Blazor Components - Preview",
            //    MetaDescription = "This demo for EJ2 Blazor Diagram control visually represents a simple fishbone diagram (Ishikawa). Diagram nodes/annotations are used to define fishbone diagrams."
            //}
        };
    }
}
