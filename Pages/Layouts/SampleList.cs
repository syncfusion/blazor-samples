using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
		public List<Sample> ListView { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default functionalities of the ListView. Click any item from the list to select and highlight it.</p>"
                },
                Description = new string[] {
                    @"<p>The ListView component represents data in interactive hierarchical structure interface across different layouts or views, that also has the features such as data binding, template rendering, and grouping.</p>

                    <p>The group list allows you to group the relevant items under a logical category by mapping the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Lists.ListViewFieldSettings~GroupBy.html'>GroupBy</a></code> field.</p>

                    <p>In this sample, <b>Cars</b> are grouped based on their <b>Category</b>.</p>"
                }
            },
            new Sample
            {
                Name = "Checklist",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/checklist",
                FileName = "Checklist.razor",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the checkbox functionalities of the ListView. Click multiple list item to check or uncheck the items.</p>"
                },
                Description = new string[] {
                    @"<p>The ListView component has checkbox feature, which is used to select multiple items from the list. This feature can be enabled using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Lists.SfListView%601~ShowCheckBox.html'>ShowCheckBox</a></code>property.</p>
                    
                    <p>In this sample, the checkbox is enabled on default list and group list.</p>"
                }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/remote-data",
                FileName = "RemoteData.razor",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the remote data functionalities of the ListView. Click any item from the list to select and highlight it.</p>"
                },
                Description = new string[] {
                    @"
                        <p>The <code>DataManager</code> that acts as an interface between the service endpoint and ListView will require the following minimal information to interact with the service endpoint properly.</p>
                        <p>DataManager-&gt;url - Defines the service endpoint to fetch the data.</p>
                        <p>DataManager-&gt;adaptor - Defines the adaptor option. By default, the ODataAdaptor is used for remote binding.</p>
                        <p>Adaptor is responsible for processing response and request from/to the service endpoint. <code>Syncfusion.Blazor.Data</code> namespace provides some predefined adaptors that are designed to interact with the particular service endpoints. They are:</p>
                        <ul>
                            <li>UrlAdaptor - Used to interact with any remote services. This is the base adaptor for all remote based adaptors.</li>
                            <li>ODataAdaptor - Used to interact with OData endpoints.</li>
                            <li>ODataV4Adaptor - Used to interact with OData V4 endpoints.</li>
                            <li>WebApiAdaptor - Used to interact with Web API created under OData standards.</li>
                            <li>WebMethodAdaptor - Used to interact with web methods.</li>
                        </ul>
                        <p>In this sample, the remote data is bound to be a collection of <b>Products</b> data as an instance of <code>DataManager</code>.</p>
                    "
                }
            },
            new Sample
            {
                Name = "Nested List",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/nested-list",
                FileName = "NestedList.razor",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the nested list functionalities, which allows you to navigate to the sub list items by clicking any item and navigating back to the list item using the back icon at the top left.
                    </p>"
                },
                Description = new string[] {
                    @"<p>The ListView component supports nested list. To achieve list navigation, the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Lists.ListViewFieldSettings~Child.html'>Child</a></code> property should be defined for the nested list in the array of JSON.</p>
                    <p>This sample have nested folder with the sub folders or files.</p>"
                }
            },
            new Sample
            {
                Name = "Templates",
                Category = "Customization",
                Directory = "Layouts/ListView",
                Url = "listview/list-templates",
                FileName = "ListTemplates.razor",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the template functionalities of the ListView. Click any news header or thumbnail to open
                    the complete article. To navigate back to the news list, click the back icon at the top left area.
                </p>"
                },
                Description = new string[] {
                    @"<p>The above template represents the customizability of the ListView component. Here, list data is loaded and its value is directly mapped to your ListView datasource to load the content.</p>
                    <p>This sample also have the additional elements such as bookmark, comments, and share that can be customized to perform the appropriate action by adding your own events.</p>"
                }
            },
            new Sample
            {
                Name = "Group Template",
                Category = "Customization",
                Directory = "Layouts/ListView",
                Url = "listview/group-template",
                FileName = "ListGroupTemplate.razor",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the group template functionalities of ListView. Click any list item from the settings option to select and highlight an option.
                </p>"
                },
                Description = new string[] {
                    @"<p>The ListView component has an option to custom design the group header title with the help of <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Lists.SfListView%601~GroupTemplate.html'>GroupTemplate</a></code>
                    tag directive.</p>
                    <p>In this example, both the group header and list items are customized using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Lists.SfListView%601~GroupTemplate.html'>GroupTemplate</a></code>
                    and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Lists.SfListView%601~Template.html'>Template</a></code>
                    tag directives.</p>"
                }
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "ListView",
                Directory = "Layouts/ListView",
                Url = "listview/virtualization",
                FileName = "Virtualization.razor",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default functionalities of UI virtualization. Scroll list item to experience UI virtualization.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    UI virtualization is an optimization technique to avoid unnecessarily constructing and rendering objects for list items by loading only visible list items in a view port. This helps improve ListView performance when loading a large number of items. The
                    list items are updated dynamically while users scroll the list. The virtualization can be enabled by using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Lists.SfListView%601~EnableVirtualization.html'>EnableVirtualization</a></code> API in Listview.
                </p>"
                }
            },
            new Sample
            {
                Name = "Call History",
                Category = "Use Case",
                Directory = "Layouts/ListView",
                Url = "listview/call-history",
                FileName = "CallHistory.razor",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the call history application using ListView. Click the checklist to filter the data in contacts list. </p>"
                },
                Description = new string[] {
                    @"<p>This sample filters out the data from ListView based on the data selected from the checklist. Here, ListView utilizes the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Lists.SfListView%601~Template.html'>Template</a></code> and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Lists.SfListView%601~ShowIcon.html'>ShowIcon</a></code> properties to repesent the call history application. The Tab component is used in this sample for navigation purposes. </p>"
                }
            },
        };
         public List<Sample> DashboardLayout { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Url = "dashboard-layout/default",
                FileName = "Default.razor",
                ActionDescription = new string[] {
                    @"<p>
                    The following sample demonstrates the default functionalities of the Dashboard Layout component.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The Dashboard Layout component provides the capability to arrange, resize and reorder the panels within the dashboard layout.
                    </p>"
                }
            },
            new Sample
            {
                Name = "API",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Url = "dashboard-layout/api",
                FileName = "API.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the properties of Dashboard Layout component from the property pane. Select any combination of properties from the property pane to customize the Dashboard Layout.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample allows to configure the <code>AllowResizing</code>, <code>CellSpacing</code> and <code>AllowFloating</code> properties of the dashboard layout component.
                    </p>"
                }
            },
             new Sample
            {
                Name = "SEO Analytics Dashboard",
                Category = "Use Case",
                Directory = "Layouts/DashboardLayout",
                Url = "dashboard-layout/seo",
                FileName = "SEO.razor",
                ActionDescription = new string[] {
                    @"<p>
                    The following sample demonstrates the usecase of Dashboard Layout component in realtime SEO data analysis.
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
                Url = "splitter/default-functionalities",
                FileName = "Default.razor",
                TitleTag = "Splitter . Default Functionalities . Syncfusion Blazor Components",
                MetaDescription = "The example explains the default functionalities of the Blazor splitter with resizable panes, separator, and orientation (horizontal and vertical).",
                ActionDescription = new string[] {
                    @"<p>
                    This example demonstrates the default functionalities of the Splitter component. To resize panes and increase the dimension of a pane, drag a separator (divider) bar.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The split panes of the Splitter component can be oriented horizontally or vertically using the <code>Orientation</code> property.
                    <ul>
                        <li>Set Orientation property to <code>Horizontal</code> to create horizontal splitter, which align panels left-to-right.</li>
                        <li>Set Orientation property to <code>Vertical</code> to create vertical splitter, which align panels top-to-bottom.</li>
                    </ul>
                    </p>
                    <p> The splitter allows resizing its panes when the drag separator (divider) bar is used to increase its dimension.</p>"
                }
            },
            new Sample
            {
                Name = "Expand and Collapse",
                Category = "Splitter",
                Directory = "Layouts/Splitter",
                Url = "splitter/expand-collapse",
                FileName = "ExpandandCollapse.razor",
                TitleTag = "Splitter . Expand and Collapse . Syncfusion Blazor Components",
                MetaDescription = "The example presents collapsible Blazor Splitter that exposes expand and collapse action of panes with a different orientation and resizable panes.",
                ActionDescription = new string[] {
                    @"<p>
                This example demonstrates the expand and collapse functionalities of the Splitter component. To expand or collapse the panes, hover the mouse over the separator (divider) bar and click the corresponding icon to expand or collapse pane.
            </p>"
                },
                Description = new string[] {
                    @"<p>
            <p>The Splitter (split container) allows expanding and collapsing its split panes. You can configure this behavior using the <code>PaneSettings Collapsible</code> property. The collapsible behavior can be enabled for specific pane alone</p>
                        When you hover the mouse over the pane's separator (divider), the expand and collapse icons will be visible. While clicking the icon, the corresponding pane is expanded or collapsed. The remaining panes automatically adjust its dimension based on the expanded or collapsed panes. These icons are visible by default in mobile devices
                    </p>"
                }
            },
             new Sample
            {
                Name = "Details View",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "splitter/details-view",
                FileName = "DetailsView.razor",
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
                Url = "splitter/outlook",
                FileName = "OutlookStyleLayout.razor",
                TitleTag = "Splitter . Outlook-style Layout . Syncfusion Blazor Components",
                MetaDescription = "The example explains how to construct an outlook style layout using Blazor Splitter, TreeView, ListView, and Rich Text Editor with multiple panes.",
                ActionDescription = new string[] {
                    @"<p>
                This example demonstrates the Splitter component that is used to design outlook-like application using multiple horizontal panes. You can resize its panes horizontally to increase dimension.
            </p>"
                },
                Description = new string[] {
                    @"<p>
                The Splitter component is used to create outlook-like user interface application using multiple panes with horizontal orientation. To create outlook-style user interface, use TreeView, ListView, and RichTextEditor components within split panes. The TreeView component is used to display mail folders at left pane and ListView to display details of mail items, and RichTextEditor to create new mail.
            </p>"
                }
            },
             new Sample
            {
                Name = "Code Editor Layout",
                Category = "Use Case",
                Directory = "Layouts/Splitter",
                Url = "splitter/code-editor-layout",
                FileName = "CodeEditorLayout.razor",
                TitleTag = "Splitter . Code Editor Layout . Syncfusion Blazor Components",
                MetaDescription = "The example shows how to construct code editor layout (UI) using Blazor Splitter with multiple, nested, different oriented, and resizable panes.",
                ActionDescription = new string[] {
                    @"<p>
                        This example demonstrates the Splitter component that is used to design code editor-like application using multiple panes. You can resize its panes vertically as well as horizontally.
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

