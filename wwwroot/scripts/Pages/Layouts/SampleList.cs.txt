using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
		public List<Sample> Listview { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Listview",
                Directory = "Layouts/Listview",
                Url = "Listview/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default functionalities of the ListView. Click any list item to select and highlight an item.</p>"
                },
                Description = new string[] {
                    @"<p>ListView component represent data in interactive hierarchical structure interface across different layouts or views, that also has the features of data-binding, template rendering, and grouping.</p>

                    <p>The group list allows to group the relevant items under a logical category by mapping the <code>GroupBy</code> field.</p>

                    <p>In this sample, <b>Cars</b> are grouped based on their <b>Category</b>.</p>"
                }
            },
            new Sample
            {
                Name = "Checklist",
                Category = "Listview",
                Directory = "Layouts/Listview",
                Url = "Listview/Checklist",
                FileName = "Checklist.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the checkbox functionalities of the ListView. Click multiple list item to check or uncheck the items.</p>"
                },
                Description = new string[] {
                    @"<p>ListView component support checkbox feature which used to select multiple items from the list. This feature can be
                    enabled by the property <code>ShowCheckBox</code>.</p>
                    
                    <p>In this sample, the checkbox is enabled on default list and group list.</p>"
                }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Listview",
                Directory = "Layouts/Listview",
                Url = "Listview/RemoteData",
                FileName = "RemoteData.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Remote-data functionalities of the ListView. Click any list item to select and highlight an item.</p>"
                },
                Description = new string[] {
                    @"
                        <p>The <code>DataManager</code> that act as an interface between the service endpoint, and ListView will require the following minimal information to interact with the service endpoint properly.</p>
                        <p>DataManager-&gt;url - Defines the service endpoint to fetch data.</p>
                        <p>DataManager-&gt;adaptor - Defines the adaptor option. By default, ODataAdaptor is used for remote binding.</p>
                        <p>Adaptor is responsible for processing response and request from/to the service endpoint. <code>Syncfusion.EJ2.Blazor.Data</code> namespace provides some predefined adaptors that are designed to interact with the particular service endpoints. They are,</p>
                        <ul>
                            <li>UrlAdaptor - Use this to interact any remote services. This is the base adaptor for all remote based adaptors.</li>
                            <li>ODataAdaptor - Use this to interact with OData endpoints.</li>
                            <li>ODataV4Adaptor - Use this to interact with OData V4 endpoints.</li>
                            <li>WebApiAdaptor - Use this to interact with Web API created under OData standards.</li>
                            <li>WebMethodAdaptor - Use this to interact with web methods.</li>
                        </ul>
                        <p>In this sample, the remote data is bound to be a collection of <b>Products</b> data as an instance of <code>DataManager</code>.</p>
                    "
                }
            },
            new Sample
            {
                Name = "Nested List",
                Category = "Listview",
                Directory = "Layouts/Listview",
                Url = "Listview/NestedList",
                FileName = "NestedList.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the nested list functionalities, which allows to navigate
                    to the sub list-items by clicking on any item and navigate back to list-item by using top left back icon.
                    </p>"
                },
                Description = new string[] {
                    @"<p>ListView component supports Nested list. To achieve list navigation, the <code>Child</code> property should be defined for the nested list in the array of JSON.</p>
                    <p>This sample have Nested folder with the sub folders/files.</p>"
                }
            },
            new Sample
            {
                Name = "Templates",
                Category = "Customization",
                Directory = "Layouts/Listview",
                Url = "Listview/ListTemplates",
                FileName = "ListTemplates.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Template functionalities of the ListView. Click any news header or thumbnail to open
                    the complete article. To navigate back to the news list, click the back icon at the top left area.
                </p>"
                },
                Description = new string[] {
                    @"<p>The above template represents the customizability of the ListView component. Here, List data is loaded and
                    its value is directly mapped to our ListView datasource to load the content.</p>
                    <p>This sample, also have the additional elements like bookmark, comments, and share that can be customized to
                    perform the appropriate action by adding our own events.</p>"
                }
            },
            new Sample
            {
                Name = "Group Template",
                Category = "Customization",
                Directory = "Layouts/Listview",
                Url = "Listview/GroupTemplate",
                FileName = "ListGroupTemplate.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Group Templates functionalities of ListView. Click any list item from the settings option to select and highlight an option.
                </p>"
                },
                Description = new string[] {
                    @"<p>ListView component has an option to custom design the group header title with the help of
                    <code>GroupTemplate</code> tag directive.</p>
                    <p>In this example, both the group header and list items are customized using the
                    <code>GroupTemplate</code> and
                    <code>Template</code> tag directives.</p>"
                }
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "Listview",
                Directory = "Layouts/Listview",
                Url = "Listview/Virtualization",
                FileName = "Virtualization.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default functionalities of UI virtualization. Scroll list item to experience UI virtualization.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    UI virtualization is an optimization technique to avoid unnecessarily constructing and rendering objects for list items by loading only visible list items in a view port. This helps improve list view performance when loading a large number of items. The
                    list items are updated dynamically while users scroll the list. The virtualization can be enabled by using <code>Enablevirtualization</code> API in Listview.
                </p>"
                }
            },
            new Sample
            {
                Name = "Call History",
                Category = "Use Case",
                Directory = "Layouts/Listview",
                Url = "Listview/CallHistory",
                FileName = "CallHistory.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the call history application using listview. Click on the checklist to filter the data in contacts list. </p>"
                },
                Description = new string[] {
                    @"<p>This sample filters out the data from listview based on the data selected from the checklist. Here, listview utilizes the <code>Template</code> and <code>ShowIcon</code> properties to repesent the call history application. The Tab component is used in this sample for navigation purposes. </p>"
                }
            },
        };
         public List<Sample> DashboardLayout { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Url = "DashboardLayout/Default",
                FileName = "Default.razor",
                ActionDescription = new string[] {
                    @"<p>
                    The following sample demonstrates the default functionalities of the DashboardLayout component.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The DashboardLayout component provides the capability to arrange, resize and reorder the panels within the dashboard layout.
                    </p>"
                }
            },
            new Sample
            {
                Name = "API",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Url = "DashboardLayout/API",
                FileName = "API.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the properties of DashboardLayout component from the property pane. Select any combination of properties from the property pane to customize the DashboardLayout.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample allows to configure the <code>cellSize</code>, <code>cellSpacing</code>, <code>allowFloating</code> and <code>allowPushing</code> properties of the dashboard layout component.
                    </p>"
                }
            },
             new Sample
            {
                Name = "SEO Analytics Dashboard",
                Category = "Use Case",
                Directory = "Layouts/DashboardLayout",
                Url = "DashboardLayout/SEO",
                FileName = "SEO.razor",
                ActionDescription = new string[] {
                    @"<p>
                    The following sample demonstrates the usecase of DashboardLayout component in realtime SEO data analysis.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The sample demonstrates the realtime SEO data analytics dashboard layout.
                    </p>"
                }
            }
        };
        public List<Sample> Splitter { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Splitter",
                Directory = "Layouts/Splitter",
                Url = "Splitter/Default",
                FileName = "Default.razor",
                Type = SampleType.New,
                TitleTag = "Splitter . Default Functionalities . Syncfusion Blazor Components",
                MetaDescription = "The example explains the default functionalities of the Blazor splitter with resizable panes, separator, and orientation (horizontal and vertical).",
                ActionDescription = new string[] {
                    @"<p>
                    This example demonstrates the default functionalities of the Splitter component. To resize panes and increase the dimension of a pane, drag a separator (divider) bar.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The split panes of the Splitter component can be oriented horizontally or vertically using the Orientation property.
                    <ul>
                        <li>Set orientation property to Horizontal to create horizontal splitter, which align panels left-to-right.</li>
                        <li>Set orientation property to Vertical to create vertical splitter, which align panels top-to-bottom.</li>
                    </ul>
                    </p>"
                }
            },
            new Sample
            {
                Name = "Expand and Collapse",
                Category = "Splitter",
                Directory = "Layouts/Splitter",
                Url = "Splitter/ExpandandCollapse",
                FileName = "ExpandandCollapse.razor",
                Type = SampleType.New,
                TitleTag = "Splitter . Expand and Collapse . Syncfusion Blazor Components",
                MetaDescription = "The example presents collapsible Blazor Splitter that exposes expand and collapse action of panes with a different orientation and resizable panes.",
                ActionDescription = new string[] {
                    @"<p>
                This example demonstrates the expand and collapse functionalities of the Splitter component. To expand or collapse the panes, hover the mouse over the separator (divider) bar and click the corresponding icon to expand or collapse pane.
            </p>"
                },
                Description = new string[] {
                    @"<p>
            <p>The splitter (split container) allows expanding and collapsing its split panes. You can component this behavior using the paneSettings Collapsible property. The collapsible behavior can be enabled for specific pane alone</p>
                        When you hover the mouse over the pane's separator (divider), the expand and collapse icons will be visible. While clicking the icon, the corresponding pane is expanded or collapsed. The remaining panes automatically adjust its dimension based on the expanded or collapsed panes. These icons are visible by default in mobile devices
                    </p>"
                }
            },
             new Sample
            {
                Name = "Details View",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "Splitter/DetailsView",
                FileName = "DetailsView.razor",
                Type = SampleType.New,
                TitleTag = "Splitter . Details View . Syncfusion Blazor Components",
                MetaDescription = "The example demonstrates how to create employee details view layout using panes of Blazor Splitter and ListView with navigation.",
                ActionDescription = new string[] {
                    @"<p>
                    This example demonstrates the Splitter component that is used to design details view page. Select the employee from left pane to display the corresponding employee details on the right pane.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The Splitter is the layout user interface (UI) component, which integrates other UI components within its pane. In this sample, the ListView component is integrated within left pane to display the employee list and right pane to display the corresponding employee details.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Outlook-style Layout",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "Splitter/Outlook",
                FileName = "OutlookStyleLayout.razor",
                Type = SampleType.New,
                TitleTag = "Splitter . Outlook-style Layout . Syncfusion Blazor Components",
                MetaDescription = "The example explains how to construct an outlook style layout using Blazor Splitter, TreeView, ListView, and Rich Text Editor with multiple panes.",
                ActionDescription = new string[] {
                    @"<p>
                This example demonstrates the splitter component that is used to design outlook-like application using multiple horizontal panes. You can resize its panes horizontally to increase dimension.
            </p>"
                },
                Description = new string[] {
                    @"<p>
                The splitter component is used to create outlook-like user interface application using multiple panes with horizontal orientation. To create outlook-style user interface, use TreeView, ListView, and RichTextEditor components within split panes. The TreeView component is used to display mail folders at left pane and ListView to display details of mail items, and RichTextEditor to create new mail.
            </p>"
                }
            },
             new Sample
            {
                Name = "Code Editor Layout",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "Splitter/CodeEditorLayout",
                FileName = "CodeEditorLayout.razor",
                Type = SampleType.New,
                TitleTag = "Splitter . Code Editor Layout . Syncfusion Blazor Components",
                MetaDescription = "The example shows how to construct code editor layout (UI) using Blazor Splitter with multiple, nested, different oriented, and resizable panes.",
                ActionDescription = new string[] {
                    @"<p>
                        This example demonstrates the splitter component that is used to design code editor-like application using multiple panes. You can resize its panes vertically as well as horizontally.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The Splitter is used to design code editor-like application using multiple panes. In this code editor layout, display HTML, CSS, and JavaScript (JS) code as horizontal panes at the top and output of sample at the bottom pane.
                    </p>"
                }
            }
        };
    }


}

