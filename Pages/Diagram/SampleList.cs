using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
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
                FileName = "DefaultFunctionalities.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample visualizes the processing of an order placed using a credit card with built-in flow shapes in Syncfusion Blazor Diagram.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    This example shows how to create a simple flow chart using the Diagram control. The <code>Nodes</code> property can be used to define different stages of a process. To define the flow among different stages, the <code>Connectors</code> property can be used.
                </p>

                <p>
                    To build flow diagrams easily, a few shapes are predefined and added to a symbol palette. You can drag predefined shapes into the drawing area. The <code>Symbols</code> property allows you to add predefined symbols to the palette.
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
                Directory = "Diagram/Diagram",
                Url = "diagram/shapes",
                FileName = "Shapes.razor",
                ActionDescription = new string[] {
                    @" <p>
                    This sample illustrates basic built-in shapes, such as basic shapes and flow shapes.
                </p>"
                },
                Description = new string[] {
                @"<p>
                    This example shows how to define built-in shapes that are used to visualize geometric information, workflow, or business flow diagrams. The <code>Type</code> property of the <code>Shape</code> allows you to choose the type of shape.
                </p>
                <br>"
                }
            },
              new Sample
            {
                Name = "Nodes",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/nodes",
                FileName = "Nodes.razor",
                ActionDescription = new string[] {
                    @"    <p>
                    This sample visualizes the different stages of a software development life cycle using a circular flow diagram.
                </p>"
                },
                Description = new string[] {
                @"<p>
                    This example shows how to add nodes to a diagram control and how to customize the appearance of the nodes. The <code>Style</code> property of the node can be used to customize their appearance.
                </p>
                <br>"
                }
            },
            new Sample
            {
                Name = "Connectors",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/connectors",
                FileName = "Connectors.razor",
                ActionDescription = new string[] {
                    @"    <p>
                    This sample visualizes the data flow in a marketing process using predefined shapes and connectors. Different types of connectors and decorators are used to customize the appearance, path, and direction of the data flow.
                </p>"
                },
                Description = new string[] {
                 @"
                 <p>In this example, you can see how to add connectors to connect shapes and how to customize the appearance of the connectors. You can use the style property of the connector to customize its stroke style. You can use the <code>CornerRadius</code> property to add connectors with rounded corners.</p>
                 <p>To change the appearance, click different styles in the property panel. Additionally, you can see how to lock the connectors to disable editing. The <code>Constraints</code> property of a connector enables or disables editing. In this example, the shapes are automatically arranged using a hierarchical tree layout.</p>
                 <p>To change the position of the descriptions, select a node and choose the template in the property panel.</p>
                 <br>"
                }
            },
            new Sample
            {
                Name = "Annotations",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/annotations",
                FileName = "Annotations.razor",
                ActionDescription = new string[] {
               @" <p>
                   This sample illustrates the competitive environment of a business through a five-force chart. The elements of a five-force chart are described using nodes and annotations. Customizing the position and appearance of the annotations is illustrated in this example.
                 </p>"
                 },
    Description = new string[] {
       @"<p>
            This example shows how to add textual descriptions to shapes and how to position them over the shapes. The <code>Annotations</code> property of the nodes can be used to add descriptions.

        </p>
        <p>
             The <code>Offset</code>, <code>HorizontalAlignment</code>, and <code>VerticalAlignment</code> properties of the annotation can be used to customize the position of the descriptions. The <code>Bold</code>, <code>Italic</code>, <code>FontSize</code>, and <code>FontFamily</code> properties can be used to customize the appearance of the descriptions.
To change the position of the descriptions, select a node and choose the template in the property panel.
        </p>
        <br>"
    }
            },
            new Sample
            {
                Name = "Ports",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/ports",
                FileName = "Ports.razor",
                ActionDescription = new string[] {
                    @" <p>
                        This sample visualizes the process flow of publishing a book using connection points. Connection points are static points over the shapes that allow you to create connections among the shapes.
                    </p>"
                },
                Description = new string[] {
                @"<p>
                        This example shows how to add connection ports to shapes. The <code>DiagramPorts</code> property of the node defines the static connection ports. The <code>Offset</code>, <code>HorizontalAlignment</code>, <code>VerticalAlignment</code>, and <code>Margin</code> properties of the port define its position.
                    </p>
                    <p>
                        The <code>Style</code> property of the port can be used to customize its appearance. The <code>Visibility</code> property can also be used to define when the connection ports should be visible.
                    </p>
                    <br>"
                }
            },

            new Sample
            {
                Name = "HTML Template",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/complex-shapes",
                FileName = "HTMLTemplate.razor",
                ActionDescription = new string[] {
                  @" <p>
                     This sample demonstrates how to host an HTML element inside a node. In this example, a Gauge control and a calender control are hosted inside a HTML Node.
                    </p>"
                },
                Description = new string[]
                {
                    @"<p>
                    This example shows how to host a control inside a node. The <code>NodeTemplate</code> property of the diagram templates can be used to host HTML content inside a node. The content property of the shape allows you to define the content to be hosted.
                   </p>

                    <br>"
                }
            },
            new Sample
            {
                Name = "History Manager",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/history-manager",
                FileName = "HistoryManager.razor",
                ActionDescription = new string[]
                {
                     @" <p>
                       This sample demonstrates viewing, deleting, and limiting diagram history as well as grouping diagram actions and storing them as a single entry in the history manager.
                      </p>"
                },
                Description = new string[] {
                @"<p>
                Diagram history handles all the diagram history. Using the <code>SetStackLimit</code> method of the diagram, we limit the number of entries that can be stored in the diagram history. We can get the entries in the undo and redo lists using the <code>GetHistoryStack(true)</code> and <code>GetHistoryStack(false)</code> methods. We can group actions as a single entry with the <code>StartGroupAction</code> and <code>EndGroupAction</code> methods. Also, we can add custom entries to the diagram history.
                  </p>
                 <br>"
                }
            },

               new Sample
            {
                Name = "Flow Execution",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/flow-execution",
                FileName = "FlowExecution.razor",
                ActionDescription = new string[] {
                    @" <p>
                        This sample demonstrates how we can process and get consecutive nodes and connectors.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        We can get the inward connections and outward connections of a node using the <code>GetEdges(nodeId,false)</code> and <code>GetEdges(nodeId,true)</code> methods of the diagram. By using the connector’s name collection, we can find the node using <code>GetNode</code>. And also, we can get the nodes connected to the connector using the <code>SourceNode</code> and <code>TargetNode</code> properties of the connector.
                    </p>
                    <br>"
                }
            },
             new Sample
            {
                Name = "Line Routing",
                Category = "Getting started",
                Directory = "Diagram/Diagram",
                Url = "diagram/routing",
                FileName = "Routing.razor",
                ActionDescription = new string[] {
                           @" <p>
                              This sample visualizes the connectors that are automatically re-routed or move away if any shape is found on the connector's paths.
                            </p>"
                 },
                Description = new string[] {
                  @"<p>
                    This example shows how the connectors are automatically re-routed on dragging a shape near it. This can be achieved by the constraints property of the diagram and connector.
                   </p>
                  <br>"
                }
            },
            //   new Sample
            //{
            //    Name = "Logic Circuit Diagram",
            //    Category = "Use Case Diagram",
            //    Directory = "Diagram/Diagram",
            //    Url = "Diagram/LogicCircuitDiagram",
            //    FileName = "LogicCircuitDiagram.razor",
            //    Type = SampleType.New,
            //    TitleTag = "Diagram . LogicCircuitDiagram . Syncfusion Blazor Components - Preview",
            //    MetaDescription = "This sample visualizes implementation of three input Boolean functions using universal logic gates. The shapes for logic gates are designed with node's path feature."

            //},
            //  new Sample
            //{
            //    Name = "UML Activity Diagram",
            //    Category = "Use Case Diagram",
            //    Directory = "Diagram/Diagram",
            //    Url = "Diagram/UMLActivity",
            //    FileName = "UMLActivity.razor",
            //    Type = SampleType.New,
            //    TitleTag = "Diagram . UMLActivity . Syncfusion Blazor Components - Preview",
            //    MetaDescription = "This sample represents the message flow from one activity to another in customer service using built-in UML activity shapes."
            //},
            new Sample
            {
                Name = "Hierarchical Tree",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/hierarchical-tree",
                FileName = "HierarchicalModel.razor",
                ActionDescription = new string[] {
                    @"<p>
                    Diagram component's features are segregated into individual feature modules. To generate diagrams from
                    external data source.
                </p>
                <br>"
                },
                Description = new string[] {
                @"<p>
                    In this example, you can see how to generate a hierarchical tree from external data sources. You can also customize the spacing among the objects in the tree. You can use the <code>HorizontalSpacing</code> and <code>VerticalSpacing</code> properties of <code>DiagramLayout</code> to customize the space among the objects in the tree. You can use the <code>Orientation</code> property of <code>DiagramLayout</code> to change the orientation of the tree.
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
                Directory = "Diagram/Diagram",
                Url = "diagram/organization-model",
                FileName = "OrganizationModel.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample illustrates a simple business management structure built from an external data source. A hierarchical tree layout algorithm is used to build organizational charts.</p>"
                },
                Description = new string[] {
                    @"<p>
                    This example shows how to generate an organizational chart from an external data source. The spacing between the objects can also be customized in the chart. The <code>HorizontalSpacing</code> and <code>VerticalSpacing</code> properties of <code>DiagramLayout</code> can be used to customize the space among objects in a tree. The <code>Orientation</code> property of <code>DiagramLayout</code> can be used to change the orientation of the chart.

                </p>"
                }
            },
            new Sample
            {
                Name = "Mind Map",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/mind-map",
                FileName = "MindMap.razor",
                ActionDescription = new string[] {
                  @"<p>
                    This sample demonstrates the concept of creatively using a mind map layout algorithm.</p>"
                    },
                Description = new string[] {
                  @"<p>
                    This example shows how to generate a mind map from an external data source. The spacing among the objects can also be customized in the chart. The <code>HorizontalSpacing</code> and <code>VerticalSpacing</code> properties of <code>DiagramLayout</code> can be used to customize the space among objects in a tree. The <code>LayoutOrientation</code> property of <code>DiagramLayout</code> can be used to change the orientation of the chart. The <code>GetLayoutInfo</code> property of <code>DiagramLayout</code> can be used to customize the tree structure.
                    </p>"
                 }
              },
            new Sample
            {
                Name = "Complex Hierarchical Tree",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/complex-hierarchical-tree",
                FileName = "ComplexHierarchicalTree.razor",
                ActionDescription = new string[] {
                   @"<p>
                     This sample illustrates a simple business management structure built from an external data source. A hierarchical tree layout algorithm is used to build organizational charts.</p>"
                 },
                Description = new string[] {
                  @"<p>
                    In this example, you can see how to generate a complex hierarchical tree from external data sources. You can also customize spacing among the objects in the tree. You can use the <code>HorizontalSpacing</code> and <code>VerticalSpacing</code> properties of <code>DiagramLayout</code> to customize the space among the objects in the tree. You can use the <code>Orientation</code> property of <code>DiagramLayout</code> to change the orientation of the tree. To change the <code>Orientation</code> of the tree, click the templates in the property panel.
                   </p>"

                }
            },
            new Sample
            {
                Name = "Drawing Tools",
                Category = "User Interaction",
                Directory = "Diagram/Diagram",
                Url = "diagram/drawing-tool",
                FileName = "DrawingTool.razor",
                ActionDescription = new string[] {
                @" <p>
                   This sample visualizes how to build a diagram interactively using drawing tools. A continuous draw option, snapping, undo, and redo support are enabled to easily draw diagrams. Rulers, gridlines, and snapping options are enabled to easily align objects.
                  </p>"
                },
                Description = new string[] {
                  @"<p>
                   This example shows how to draw shapes and connections interactively. In addition to that, rulers, gridlines, and snapping options are enabled to assist drawing. The Tool property can be used to enable drawing. Add <code>DrawOnce</code> or <code>ContinuousDraw</code> options to the <code>Tool</code> property of the diagram. The <code>DrawingObject</code> property can be used to define a shape or connector to be drawn. A few shape and connector templates are in the palette. To draw basic shapes and connectors, click the templates in the palette. For polygon shapes, a corner or point will be added to the polygon for each mouse left-click. Drawing will be completed either on mouse right-click or double-click.
                   </p>"

                }
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "User Interaction",
                Directory = "Diagram/Diagram",
                Url = "diagram/keyboard-interaction",
                FileName = "Keyboardinteraction.razor",
                ActionDescription = new string[] {
                 @" <p>
                     This sample illustrates interaction with the Diagram control using shortcut keys. Command manager support is used to manage keyboard interactions.
                   </p>"
                },
                 Description = new string[] {
                  @"<p>
                    This example shows how to interact with the Diagram control using shortcut keys. The <code>CommandManager</code> property can be used to map the commands with key gestures. In this example, along with the built-in commands, a few custom commands have been added and a few built-in commands (nudge) are overridden. That is, when the arrow keys are pressed, selection will be navigated instead of moving the selected objects. The different kinds of interactions and the corresponding key gestures are listed in the property panel.
                    </p>"
                 }
            },
            new Sample
            {
                Name = "User Handles",
                Category = "User Interaction",
                Directory = "Diagram/Diagram",
                Url = "diagram/user-handles",
                FileName = "UserHandles.razor",
                ActionDescription = new string[] {
                  @"<p>This sample visualizes a simple flow diagram along with options to execute frequently used commands using user handles.</p>"
                },
                 Description = new string[] {
                   @"<p>User handles are icons that are placed around the node to run frequently used commands. This example shows how to render and configure user handles and how to interact with the Diagram control using user handles. The <code>UserHandles</code> property of the <code>SelectedItems</code> can be used to add user handles to a diagram. Click the templates in the property panel to customize the size, position, and appearance of the user handles.</p><br>"
                 }
            },
            new Sample
            {
                Name = "Symbol Palette",
                Category = "User Interaction",
                Directory = "Diagram/Diagram",
                Url = "diagram/symbol-palette",
                FileName = "SymbolPalette.razor",
                ActionDescription = new string[] {
                    @"<p>
                     This example illustrates predefining shapes in a palette that can be easily dragged into the drawing area. Customizable options of the symbol palette are also illustrated in this example.
                    </p>
                    </p>
                    <p>
                     In this example, options to enable or disable animation, show or hide symbol descriptions, and show header icons are provided.
                    </p>"
                },
                 Description = new string[] {
                    @"<p>
                       This example shows how to add shapes to the symbol palette and how to customize it. The <code>Symbols</code> property can be used to add shapes to the symbol palette. The <code>SymbolWidth</code> and <code>SymbolHeight</code> properties allow you to define the size of the symbols.

                      </p>
                     <br>"
                 }
            },

            new Sample
            {
                Name = "Overview Panel",
                Category = "User Interaction",
                Directory = "Diagram/Diagram",
                Url = "diagram/overview",
                FileName = "OverView.razor",
                ActionDescription = new string[] {
                  @" <p>
                     This sample visualizes an organizational structure along with an overview for easily navigating a large organizational structure using the Overview Panel.
                     </p>"
                },
                Description = new string[] {
                  @"<p>
                    This example shows how to render the Overview Panel and how to display a preview (overall view) of the entire content of a diagram. This helps you look at the overall picture of a large diagram and also navigate (pan or zoom) to a particular position of the page. The <code>SourceID</code> property can be used to map the Diagram control with Overview Panel.
                   </p>
                   <br>"
                }
            },
             new Sample
            {
                Name = "Save and Load",
                Category = "User Interaction",
                Directory = "Diagram/Diagram",
                Url = "diagram/serialization",
                FileName = "Serialization.razor",
                ActionDescription = new string[] {
                @" <p>
                  This sample demonstrates building diagrams interactively and editing the saved diagrams. The symbol palette is used to build diagrams easily.
                 </p>"
                },
                Description = new string[] {
                 @"<p>
                    This example shows how to drag and drop shapes and connectors from the symbol palette to build diagrams. You can save the diagram as a JSON file and edit the pre-saved diagrams. The <code>SaveDiagram</code> method can be used to save the diagram as string. The <code>LoadDiagram</code> method can be used to load the diagram from a string. In this example, the context menu and undo and redo features are enabled.
                  </p>
                 <br>"
                }
            },
            new Sample
            {
                Name = "Print and Export",
                Category = "User Interaction",
                Directory = "Diagram/Diagram",
                Url = "diagram/print-and-Export",
                FileName = "PrintandExport.razor",
                ActionDescription = new string[] {
                 @" <p>
                    This sample demonstrates printing and exporting the Diagram control as an image.

                    </p>"
                },
                Description = new string[] {
                 @"<p>
                   This example shows how to print the diagram and how to export the diagram in image (*.jpg, *.png, and *bmp) and in SVG format. The <code>ExportDiagram</code> method can be used to export the diagram. The <code>ExportDiagram</code> method takes the exporting options (file formats, mode of export, and the region to export to) as input. The <code>Print</code> method can be used to print the diagram.
                   </p>

                   <br>"
                }
            },

            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Diagram/Diagram",
                Url = "diagram/local-data",
                FileName = "LocalData.razor",
                ActionDescription = new string[] {
                 @" <p>
                   This sample visualizes the classifications of species using a hierarchical tree layout algorithm. Data Manager support is used to bind data with the diagram.
                   </p>"
                },
                Description = new string[] {
                @"<p>
                  This example shows how to generate a diagram from saved data. The <code>DiagramDataSource</code> property can be used to map an external data source with the Diagram control. The <code>Id</code> property of DiagramDataSource can be used to define a unique field of external data. The <code>parentId</code> property can be used to define the relationship between the objects.
                 </p>
                 <br>"
                }
            },
            // new Sample
            //{
            //    Name = "VennDiagram",
            //    Category = "Static Diagram",
            //    Directory = "Diagram/Diagram",
            //    Url = "Diagram/VennDiagram",
            //    FileName = "VennDiagram.razor",
            //    Type = SampleType.New,
            //    TitleTag = "Diagram . VennDiagram . Syncfusion Blazor Components - Preview",
            //    MetaDescription = "This demo for Essential JS2 Diagram control visually represents the hotel booking reservation system. It is built with readymade BPMN shapes."
            //},
            // new Sample
            //{
            //    Name = "Fishbone Diagram",
            //    Category = "Static Diagram",
            //    Directory = "Diagram/Diagram",
            //    Url = "Diagram/FishboneDiagram",
            //    FileName = "FishboneDiagram.razor",
            //    Type = SampleType.New,
            //    TitleTag = "Diagram . FishboneDiagram . Syncfusion Blazor Components - Preview",
            //    MetaDescription = "This demo for EJ2 Blazor Diagram control visually represents a simple fishbone diagram (Ishikawa). Diagram nodes/annotations are used to define fishbone diagrams."
            //}
        };
    }
}
