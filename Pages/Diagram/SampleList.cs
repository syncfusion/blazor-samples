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
                    This example shows how to create a simple flow chart using the Diagram control. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/nodes/nodes/'>Nodes</a> property can be used to define different stages of a process. To define the flow among different stages, the <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/connectors/connectors/'>Connectors</a> property can be used.
                </p>

                <p>
                    To build flow diagrams easily, a few shapes are predefined and added to a symbol palette. You can drag predefined shapes into the drawing area. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/shapes/'>Symbols</a> property allows you to add predefined symbols to the palette.
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
                    This example shows how to define built-in shapes that are used to visualize geometric information, workflow, or business flow diagrams. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/bpmn-shapes/bpmn-shapes/'>Type</a> property of the <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/shapes/'>Shape</a> allows you to choose the type of shape.
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
                    This example shows how to add nodes to a diagram control and how to customize the appearance of the nodes. The <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramNode~Style.html'>Style</a> property of the node can be used to customize their appearance.
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
                 <p>In this example, you can see how to add connectors to connect shapes and how to customize the appearance of the connectors. You can use the style property of the connector to customize its stroke style. You can use the <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramConnector~CornerRadius.html'>CornerRadius</a> property to add connectors with rounded corners.</p>
                 <p>To change the appearance, click different styles in the property panel. Additionally, you can see how to lock the connectors to disable editing. The <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramConnector~Constraints.html'>Constraints</a> property of a connector enables or disables editing. In this example, the shapes are automatically arranged using a hierarchical tree layout.</p>
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
                This example shows how to add textual descriptions to shapes and how to position them over the shapes. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/annotations/labels/'>Annotations</a> property of the nodes can be used to add descriptions.

                </p>
                <p>
                The <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramNodeAnnotation~Offset.html'>Offset</a>, <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramNodeAnnotation~HorizontalAlignment.html'>HorizontalAlignment</a>, and <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramNodeAnnotation~VerticalAlignment.html'>VerticalAlignment</a> properties of the annotation can be used to customize the position of the descriptions. The <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.AnnotationStyle~Bold.html'>Bold</a>, <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.AnnotationStyle~Italic.html'>Italic</a>, <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.AnnotationStyle~FontSize.html'>FontSize</a>, and <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.AnnotationStyle~FontFamily.html'>FontFamily</a> properties can be used to customize the appearance of the descriptions.
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
                        This example shows how to add connection ports to shapes. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/ports/ports/'>DiagramPorts</a> property of the node defines the static connection ports. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/ports/positioning/'>Offset</a>, <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/ports/positioning/#horizontal-and-vertical-alignment'>HorizontalAlignment</a>, <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/ports/positioning/#horizontal-and-vertical-alignment'>VerticalAlignment</a>, and <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/ports/positioning/#margin'>Margin</a> properties of the port define its position.
                    </p>
                    <p>
                        The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/ports/appearance/'>Style</a> property of the port can be used to customize its appearance. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/ports/appearance/#visibility'>Visibility</a> property can also be used to define when the connection ports should be visible.
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
                    This example shows how to host a control inside a node. The <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramModel~NodeTemplate.html'>NodeTemplate</a> property of the diagram templates can be used to host HTML content inside a node. The content property of the shape allows you to define the content to be hosted.
                   </p>

                    <br>"
                }
            },
           //new Sample
            //{
            //    Name = "Events",
            //    Category = "Getting started",
            //    Directory = "Diagram/Diagram",
            //    Url = "diagram/events",
            //    FileName = "Events.razor",
            //    Type = SampleType.New,
            //    TitleTag = "Diagram . Events . Syncfusion Blazor Components - Preview",
            //    ActionDescription = new string[] {
            //     @"<p>
            //     This sample visualizes the Blazor events available in the Diagram control.
            //     </p>"
            //    },
            //    Description = new string[] {
            //    @"<p>
            //    Diagram events are the actions that can be detected by <a target='_blank' href='https://blazor.syncfusion.com/documentation/introduction/'>Blazor</a>.
            //    The event argument is the information about the event that has occurred.
            //    Sometimes, we want to execute some Blazor code when an event occurs, such as when the user clicks on the node.
            //    We can achieve this scenario using the Diagram's <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramModel~Click.html'>Click</a> event. So, this shows how to hook all the diagram events and how to handle its arguments.
            //    </p>"
            //    }
            //},
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
                Diagram history handles all the diagram history. Using the <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/methods/#set-stack-limit'>SetStackLimit</a> method of the diagram, we limit the number of entries that can be stored in the diagram history. We can get the entries in the undo and redo lists using the <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/methods/#get-history-stack'>GetHistoryStack(true)</a> and <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/methods/#get-history-stack'>GetHistoryStack(false)</a> methods. We can group actions as a single entry with the <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/methods/#group-action'>StartGroupAction</a> and <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/methods/#group-action'>EndGroupAction</a> methods. Also, we can add custom entries to the diagram history.
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
                        We can get the inward connections and outward connections of a node using the <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/methods/#get-the-edges'>GetEdges(nodeId,false)</a> and <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/methods/#get-the-edges'>GetEdges(nodeId,true)</a> methods of the diagram. By using the connector’s name collection, we can find the node using <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/methods/#get-the-node'>GetNode</a>. And also, we can get the nodes connected to the connector using the <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramConnector~SourceID.html'>SourceID</a> and <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramConnector~TargetID.html'>TargetID</a> properties of the connector.
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
            //new Sample
            //{
            //    Name = "Tooltip",
            //    Category = "Getting started",
            //    Directory = "Diagram/Diagram",
            //    Url = "diagram/tool-tip",
            //    FileName = "ToolTip.razor",
            //    Type = SampleType.New,
            //    TitleTag = "Diagram . ToolTip . Syncfusion Blazor Components - Preview",
            //    ActionDescription = new string[] {
            //     @"<p>
            //    This sample demonstrates how to add extra information to nodes and connectors and how to show the information through the common graphical user interface element.
            //     </p>"
            //    },
            //    Description = new string[] {
            //    @" <p>
            //    We can define a tooltip for diagram nodes and connectors.
            //    We can control the animation, position, and effects of the tooltip using the Tooltip property of the diagram.
            //    Also, we can define a custom tooltip as either text or an HTML element using the Content property of the tooltip.
            //    We can control the different tooltip settings to each connector and node.
            //    </p>
            //    <br>"
            //    }
            //},
            new Sample
            {
                Name = "Logic Circuit Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/logic-circuit-diagram",
                FileName = "LogicCircuitDiagram.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . LogicCircuitDiagram . Syncfusion Blazor Components - Preview",
               ActionDescription = new string[] {
                    @" <p>
                    This sample visualizes implementation of three input Boolean functions using universal logic gates.
                    The shapes for the logic gates were designed with Diagram's path node feature.
                </p>"
                },
                Description = new string[] {
                @"<p>
                This example shows how to create Boolean algebraic laws and theorems using diagram <a target = '_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.PathModel_members.html'>Path</a> shapes.
                The <a target='_blank' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.PathModel~Type.html'>Type</a> property of the can be used to create <a target = '_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.PathModel_members.html'>Path</a> nodes.
                The <a target='_blank' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.PathModel~Data.html'>Data</a> property of the shape allows you to define path data of the path shape.
                </p>
                <br>"
                }

            },
            new Sample
            {
                Name = "Uml Activity",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/uml-activity",
                FileName = "umlActivity.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . Uml Activity . Syncfusion Blazor Components - Preview",
                ActionDescription = new string[] {
                 @"  <p>
                    This sample represents the message flow from one activity to another in customer service using built-in UML activity shapes.
                    </p>"
                },
                Description = new string[] {
                @" <p>
                This example shows how to create activity shapes using diagram <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.UmlActivityShapeModel.html'>UMLActivity</a> shapes. 
                The <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramUmlClassAttribute~Type.html'>Type</a> property of the <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.UmlActivityShapeModel~Shape.html'>Shape</a> can be used to create <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.UmlActivityShapeModel.html'>UMLActivity</a> nodes. 
                The <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.UmlActivityShapeModel~Shape.html'>Shape</a> property of the shape allows you to create UML activity shapes.
                </p>
                <br>"
                }
            },
            new Sample
            {
                Name = "UML Class Diagram",
                Category = "Use Case Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/uml-class",
                FileName = "UmlClass.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . UML Class Diagram . Syncfusion Blazor Components - Preview",
                 ActionDescription = new string[] {
                 @"<p>
                 This sample represents a hospital management system using Diagram's built-in UML-class diagram shapes.
                  </p>"
                },
                Description = new string[] {
                @"<p>
                This example shows how to create class shapes using diagram <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.UmlClassModel.html'>UMLClass</a> shapes. 
                The <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.UmlClassifierShapeModel~Type.html'>Type</a> property of the <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.UmlClassifierShapeModel~ClassShape.html'>Shape</a> can be used to create UMLClass nodes. 
                The <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.UmlClassifierShapeModel~ClassShape.html'>Shape</a> property of the shape allows you to create UML Class shapes.
                 </p>
                 <br>"
                }
            },
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
                    In this example, you can see how to generate a hierarchical tree from external data sources. You can also customize the spacing among the objects in the tree. You can use the <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/hierarchical-layout/#spacing'>HorizontalSpacing</a> and <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/hierarchical-layout/#spacing'>VerticalSpacing</a> properties of <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/hierarchical-layout/#hierarchical-layout'>DiagramLayout</a> to customize the space among the objects in the tree. You can use the <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/hierarchical-layout/#orientation'>Orientation</a> property of <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/hierarchical-layout/#customizing-the-properties'>DiagramLayout</a> to change the orientation of the tree.
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
                    This example shows how to generate an organizational chart from an external data source. The spacing between the objects can also be customized in the chart. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/organizational-chart/#layout-spacing'>HorizontalSpacing</a> and <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/organizational-chart/#layout-spacing'>VerticalSpacing</a> properties of <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/organizational-chart/'>DiagramLayout</a> can be used to customize the space among objects in a tree. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/organizational-chart/#layout-orientation'>Orientation</a> property of <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/organizational-chart/'>DiagramLayout</a> can be used to change the orientation of the chart.

                </p>"
                }
            },
            new Sample
            {
                Name = "Radial Tree",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/radial-tree",
                FileName = "RadialTree.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . RadialTree . Syncfusion Blazor Components - Preview",
                ActionDescription = new string[] {
                    @" <p>
                This sample demonstrates a huge organizational structure using a compact layout model. A radial tree layout algorithm is used to build such a layout.
                    </p>"
                },
                Description = new string[] {
                @"<p>
                 This example shows how to visualize complex hierarchical data using a radial tree layout algorithm that arranges the nodes in a circular structure.
                 The <a target='_blank' href=''>Type</a> property of the layout can be used to enable the radial tree layout.
                 The spacing between the objects can also be customized in the tree.
                 The <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.ILayout~HorizontalSpacing.html'>HorizontalSpacing</a> and <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.ILayout~VerticalSpacing.html'>VerticalSpacing</a> properties of <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/radial-tree-layout/'>Layout</a> can be used to customize the space between the objects in a tree.
                </p>
                <br>"
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
                    This example shows how to generate a mind map from an external data source. The spacing among the objects can also be customized in the chart. The <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.ILayout~HorizontalSpacing.html'>HorizontalSpacing</a> and <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.ILayout~VerticalSpacing.html'>VerticalSpacing</a> properties of <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/mind-map/'>DiagramLayout</a> can be used to customize the space among objects in a tree. The <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramLayout~Orientation.html'>LayoutOrientation</a> property of <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramLayout.html'>DiagramLayout</a> can be used to change the orientation of the chart. The <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.ILayout~GetLayoutInfo.html'>GetLayoutInfo</a> property of <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramLayout.html'>DiagramLayout</a> can be used to customize the tree structure.
                    </p>"
                 }
              }, new Sample
            {
                Name = "Symmetric Layout",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/symmetric-layout",
                FileName = "SymmetricLayout.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . Symmetric Layout . Syncfusion Blazor Components - Preview",
                ActionDescription = new string[] {
                 @"<p>This sample visualizes a simple network template using a symmetrical layout algorithm.</p>"
                },
                Description = new string[] {
                @"<p>
                This view is well suited for large networks and is commonly used in network component diagrams. 
                It is typically used with simple straight line links. 
                This example shows how to arrange nodes in a symmetrical structure. 
                The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/symmetric-layout/'>Layout</a> property of the Diagram can be used to enable it.
                </p>
                <br>"
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
                    In this example, you can see how to generate a complex hierarchical tree from external data sources. You can also customize spacing among the objects in the tree. You can use the <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/hierarchical-layout/#spacing'>HorizontalSpacing</a> and <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/hierarchical-layout/#spacing'>VerticalSpacing</a> properties of <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/hierarchical-layout/#complex-hierarchical-tree'>DiagramLayout</a> to customize the space among the objects in the tree. You can use the <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/hierarchical-layout/#orientation'>Orientation</a> property of <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/hierarchical-layout/#complex-hierarchical-tree'>DiagramLayout</a> to change the orientation of the tree. To change the <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/hierarchical-layout/#orientation'>Orientation</a> of the tree, click the templates in the property panel.
                   </p>"

                }
            },
            new Sample
            {
                Name = "RTL Tree",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/rtl-tree",
                FileName = "RTLTree.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . RTLTree . Syncfusion Blazor Components - Preview",
                ActionDescription = new string[] {
                    @" <p>
                    This sample visualizes the concept of artificial intelligence using a hierarchical tree layout algorithm.
                </p>"
                },
                Description = new string[] {
                @"<p>
                This example shows how to generate an RTL (right to left) tree from an external data source. The Orientation property of the layout can be used to generate an RTL tree.
                </p>
                <br>"
                }
            },
            new Sample
            {
                Name = "Pert Chart",
                Category = "Automatic Layouts",
                Directory = "Diagram/Diagram",
                Url = "diagram/pert-chart",
                FileName = "PertChart.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . Pert Chart . Syncfusion Blazor Components - Preview",
                ActionDescription = new string[] {
                 @"<p>
                This sample visualizes a project development process using the Program Evaluation Review Technique (PERT). A complex hierarchical tree layout algorithm is used to automatically arrange the nodes.
                 </p>"
                },
                Description = new string[] {
                @" <p>
                This example shows how to generate a PERT chart from an external data source.
                The <a target='_blank' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.SfDiagram~DataSourceSettings.html'>DataSourceSettings</a> property can be used to map an external data source with the diagram control.
                The <a target='_blank' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.SfDiagram~Layout.html'>Layout</a> property can be used to automatically position the nodes.
                In this example, the nodes are arranged from left to right of the diagram.
                The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/layout/hierarchical-layout/#orientation'>Orientation</a> property can be used to define the orientation of the layouts.
                </p>
                <br>"
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
                   This example shows how to draw shapes and connections interactively. In addition to that, rulers, gridlines, and snapping options are enabled to assist drawing. The Tool property can be used to enable drawing. Add <a target='_blank' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramTools.html'>DrawOnce</a> or <a target='_blank' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramTools.html'>ContinuousDraw</a> options to the <a target='_blank' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.SfDiagram~Tool.html'>Tool</a> property of the diagram. The <a target='_blank' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.SfDiagram~DrawingObject.html'>DrawingObject</a> property can be used to define a shape or connector to be drawn. A few shape and connector templates are in the palette. To draw basic shapes and connectors, click the templates in the palette. For polygon shapes, a corner or point will be added to the polygon for each mouse left-click. Drawing will be completed either on mouse right-click or double-click.
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
                    This example shows how to interact with the Diagram control using shortcut keys. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/commands/'>CommandManager</a> property can be used to map the commands with key gestures. In this example, along with the built-in commands, a few custom commands have been added and a few built-in commands (nudge) are overridden. That is, when the arrow keys are pressed, selection will be navigated instead of moving the selected objects. The different kinds of interactions and the corresponding key gestures are listed in the property panel.
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
                   @"<p>User handles are icons that are placed around the node to run frequently used commands. This example shows how to render and configure user handles and how to interact with the Diagram control using user handles. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/user-handle/'>UserHandles</a> property of the <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.SfDiagram~SelectedItems.html'>SelectedItems</a> can be used to add user handles to a diagram. Click the templates in the property panel to customize the size, position, and appearance of the user handles.</p><br>"
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
                       This example shows how to add shapes to the symbol palette and how to customize it. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/symbol-palette/'>Symbols</a> property can be used to add shapes to the symbol palette. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/symbol-palette/#create-symbol-palette'>SymbolWidth</a> and <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/symbol-palette/#create-symbol-palette'>SymbolHeight</a> properties allow you to define the size of the symbols.

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
                    This example shows how to render the Overview Panel and how to display a preview (overall view) of the entire content of a diagram. This helps you look at the overall picture of a large diagram and also navigate (pan or zoom) to a particular position of the page. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/overview/#create-overview'>SourceID</a> property can be used to map the Diagram control with Overview Panel.
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
                    This example shows how to drag and drop shapes and connectors from the symbol palette to build diagrams. You can save the diagram as a JSON file and edit the pre-saved diagrams. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/serialization/#save'>SaveDiagram</a> method can be used to save the diagram as string. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/serialization/#load'>LoadDiagram</a> method can be used to load the diagram from a string. In this example, the context menu and undo and redo features are enabled.
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
                   This example shows how to print the diagram and how to export the diagram in image (*.jpg, *.png, and *bmp) and in SVG format. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/export/'>ExportDiagram</a> method can be used to export the diagram. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/export/'>ExportDiagram</a> method takes the exporting options (file formats, mode of export, and the region to export to) as input. The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/export/'>Print</a> method can be used to print the diagram.
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
                  This example shows how to generate a diagram from saved data. The <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramDataSource.html'>DiagramDataSource</a> property can be used to map an external data source with the Diagram control. The <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramDataSource~Id.html'>Id</a> property of DiagramDataSource can be used to define a unique field of external data. The <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Diagrams.DiagramDataSource~ParentId.html'>ParentId</a> property can be used to define the relationship between the objects.
                 </p>
                 <br>"
                }
            },
            new Sample
            {
                Name = "Venn Diagram",
                Category = "Static Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/venn-diagram",
                FileName = "VennDiagram.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . VennDiagram . Syncfusion Blazor Components - Preview",
                ActionDescription = new string[] {
                    @" <p>
                    This sample visualizes classifications of data science using Venn diagrams. Diagram nodes and annotations are used to define Venn diagrams. Read-only mode is enabled in this example.
                </p>"
                },
                Description = new string[] {
                @"<p>
                    This example shows how to create a Venn diagram using the Diagram control.
                    In this example, zoom and pan options are enabled.
                    The <a target='_blank' href='https://blazor.syncfusion.com/documentation/diagram/tools/'>Tool</a> property of the Diagram control allows you to enable and disable zoom and pan options.
                </p>
                <br>"
                }
            },
            new Sample
            {
                Name = "Fishbone Diagram",
                Category = "Static Diagram",
                Directory = "Diagram/Diagram",
                Url = "diagram/fishbone-diagram",
                FileName = "FishboneDiagram.razor",
                Type = SampleType.New,
                TitleTag = "Diagram . FishboneDiagram . Syncfusion Blazor Components - Preview",
                ActionDescription = new string[] {
                    @" <p>
                    This sample visually represents a simple fishbone diagram in Syncfusion Blazor. Diagram nodes and annotations are used to define fishbone diagrams.
                </p>"
                },
                Description = new string[] {
                @"<p>
                    This sample shows how to create a fishbone diagram (Ishikawa) using the Diagram control. 
                    Here, zoom and pan options are enabled. 
                    The Tool property of the Diagram control allows you to enable or disable zoom and pan options. Read-only mode is enabled here.
                <br>"
                }
            },
        };
    }
}
