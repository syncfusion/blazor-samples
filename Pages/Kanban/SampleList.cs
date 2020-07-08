using System.Collections.Generic;
using blazor_samples;

namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Kanban { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/overview",
                FileName = "Overview.razor",
                TitleTag = "Kanban . Overview . Syncfusion Blazor Components",
                MetaDescription = "The example is designed to enable most essential features such as templating, swimlane, toggling columns, tooltip, and more in Blazor Kanban board.",
                ActionDescription = new string[] {
                    @"<p>
                        This example demonstrates the overview functionalities of Kanban component.
                        Enabled most features such as templating, toggle columns, drag-and-drop, swimlane, tooltip, and more in the Kanban board.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The sample is designed by enabling the major features in Kanban. The features enabled in the samples are:
                    </p>
                    <ul>
                        <li>Card template</li>
                        <li>Header template</li>
                        <li>Swimlane</li>
                        <li>Tooltip</li>
                        <li>Toggle columns</li>
                    </ul>"
                }
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                TitleTag = "Kanban . Default Functionalities . Syncfusion Blazor Components",
                MetaDescription = "The example demonstrates the default functionalities of Blazor Kanban with very minimal essential settings such as data source, columns, and card details.",
                ActionDescription = new string[] {
                    @"<p>
                        This example demonstrates the default functionalities of the Kanban component.
                        You can drag and drop the cards across multiple states of the Kanban board by default.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The sample is configured with a minimal setting that is mandatory to render Kanban layout and cards.
                        The <code>DataSource</code>, <code>KanbanColumns</code>, and <code>KanbanCardSettings</code> are essential fields to render the Kanban component.
                        By default, you can drag and drop the cards across all stages of Kanban.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Swimlane",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/swimlane",
                FileName = "Swimlane.razor",
                TitleTag = "Kanban . Swimlane . Syncfusion Blazor Components",
                MetaDescription = "The example explains how to configure swimlane and its related settings (sorting order, drag-and-drop, and more) in Blazor Kanban board.",
                ActionDescription = new string[] {
                    @"<p>
                        This example demonstrates the swimlane functionalities of Kanban component.
                        Provided options in the property panel to sort the cards, enable drag-and-drop across swimlanes, show or hide the empty row and the items count.
                        Also, you can expand/collapse the swimlane row in the Kanban board.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This sample renders the assignee field as a swimlane header using the <code>KanbanSwimlaneSettings</code> property.
                        The property provides the following options to change its related settings:
                    </p>
                    <ul>
                        <li>Sorting the swimlane cards using the <code>KanbanSwimlaneSettings.SortDirection</code> property</li>
                        <li>Component the drag-and-drop of the cards across swimlane using the <code>KanbanSwimlaneSettings.AllowDragAndDrop</code> property.</li>
                        <li>Show or hide the empty swimlane row using the <code>KanbanSwimlaneSettings.ShowEmptyRow</code> property.</li>
                        <li>Show or hide the items count in the swimlane header using the <code>KanbanSwimlaneSettings.ShowItemCount</code> property.</li>
                    </ul>"
                }
            },
            new Sample
            {
                Name = "Stacked Header",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/stacked-header",
                FileName = "StackedHeader.razor",
                TitleTag = "Kanban . Stacked Header . Syncfusion Blazor Components",
                MetaDescription = "The example explains how to add a stacked header to group logically related columns above a column header in Blazor Kanban.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the Kanban component with the stacked header feature.
                        In this sample, the Kanban is showcased with two headers aligned in a stacked manner.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The Kanban provides an option to add an additional header along with a column header in stacked manner.
                        This header groups the logically related columns.
                        This can be achieved by mapping <code>Text</code> and <code>KeyField</code> attribute of the <code>KanbanStackedHeader</code> property.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Dialog Editing",
                Category = "Kanban",
                Directory = "Kanban/Kanban",
                Url = "kanban/dialog-editing",
                FileName = "DialogEditing.razor",
                TitleTag = "Kanban . Dialog Editing . Syncfusion Blazor Components",
                MetaDescription = "The example explains how to handle the CRUD (Create, Read, Update, and Delete) actions on the JS Kanban cards from the application end.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample showcases the CRUD (Create, Read, Update, and Delete) operations of the Kanban component.
                        You can add a new card using the button from the property panel and read, update, or delete a card by opening the card details in dialog by double-clicking it.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The sample is designed to showcase the CRUD operations of the Kanban board.
                        The Kanban provides the essential methods to handle the CRUD operation from the application-end.
                    </p>
                    <ol>
                        <li>UpdateCard</li>
                        <li>AddCard</li>
                        <li>DeleteCard</li>
                    </ol>
                    <p>
                        The double click event of the card is used to open the card details in a dialog and read, edit, or delete a card.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Kanban/Kanban",
                Url = "kanban/local-data",
                FileName = "LocalData.razor",
                TitleTag = "Kanban . Local Data . Syncfusion Blazor Components",
                MetaDescription = "The example demonstrates how to bind data to the Blazor Kanban board from the array of objects (JSON) or instances of Data Manager.",
                ActionDescription = new string[] {
                    @" <p> This sample demonstrates the way of data binding to Kanban component with array of objects (local data source). </p>"
                },
                Description = new string[] {
                    @"<p>
                        The Kanban supports binding data source to the board using the <code>DataSource</code> property that can be assigned with the array of objects or instances of <code>DataManager</code>.
                    </p>
                    <p>In this demo, the array of objects is assigned as the data source to the Kanban board.</p>"
                }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Kanban/Kanban",
                Url = "kanban/remote-data",
                FileName = "RemoteData.razor",
                TitleTag = "Kanban . Remote Data . Syncfusion Blazor Components",
                MetaDescription = "The example demonstrates how to load data source from remote service to the Blazor Kanban board using data manager and Web API adaptor.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the way of data binding to Kanban component using remote service.
                        The data source of Kanban is fetched from remote service using SfDataManager component.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The Kanban supports data binding using the <code>DataSource</code> property that can be assigned with the instance of DataManager to bind remote data.
                    </p>
                    <p>
                        The DataManager, which acts as an interface between the service endpoint and the Kanban will require the below minimal information to interact with service endpoint properly.
                    </p>
                    <ul>
                        <li><code>SfDataManager.Url</code>: Defines the service endpoint to fetch the data.</li>
                        <li>
                            <code>SfDataManager.Adaptor</code>: Defines the adaptor option.
                            By default, <code> ODataAdaptor </code> is used for remote binding.
                        </li>
                    </ul>
                    <p>
                        The adaptor is responsible for processing response and request from/to the service endpoint.
                        The <code> Syncfusion.Blazor.Data </code> namespace provides some predefined adaptors which are designed to interact with particular service endpoints.
                        They are:
                    </p>
                    <ul>
                        <li><b>UrlAdaptor</b> - Use this to interact with any remote services. This is the base adaptor for all remote based adaptors.</li>
                        <li><b>ODataAdaptor</b> - Use this to interact with OData endpoints.</li>
                        <li><b>ODataV4Adaptor</b> - Use this to interact with OData V4 endpoints.</li>
                        <li><b>WebApiAdaptor</b> - Use this to interact with Web API created under OData standards.</li>
                        <li><b>WebMethodAdaptor</b> - Use this to interact with web methods.</li>
                    </ul>
                    <p>
                        In this demo, remote data is bound by assigning service data as an instance of <code>SfDataManager</code> to the
                        <code>DataSource</code> property.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Header Template",
                Category = "Templates",
                Directory = "Kanban/Kanban",
                Url = "kanban/header-template",
                FileName = "HeaderTemplate.razor",
                TitleTag = "Kanban . Header Template . Syncfusion Blazor Components",
                MetaDescription = "The example demonstrates how to customize the column headers of the Blazor Kanban board with text, images, badges, and count using HTML templates.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the header template feature of Kanban. The column headers of Kanban are customized with text + icons in this demo.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The Kanban provides an option to customize its column header using the <code>KanbanColumn</code> -> <code>Template</code> property.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Swimlane Template",
                Category = "Templates",
                Directory = "Kanban/Kanban",
                Url = "kanban/swimlane-template",
                FileName = "SwimlaneTemplate.razor",
                TitleTag = "Kanban . Swimlane Template . Syncfusion Blazor Components",
                MetaDescription = "The example demonstrates how to customize the swimlane headers of the Blazor Kanban board using HTML templates, which is applicable to all swimlane headers.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates how to customize the swimlane header of Kanban.
                        In this sample, the swimlane header is customized with icons and corresponding to the mapped key field's text.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The Kanban provides an option to customize its swimlane header using the <code>KanbanSwimlaneSettings</code> -> <code>Template</code> property.
                    </p>
                    <p>In this demo, all the swimlane headers are customized with templating as text and icons.</p>"
                }
            },
            new Sample
            {
                Name = "Card Template",
                Category = "Templates",
                Directory = "Kanban/Kanban",
                Url = "kanban/card-template",
                FileName = "CardTemplate.razor",
                TitleTag = "Kanban . Card Template . Syncfusion Blazor Components",
                MetaDescription = "The example demonstrates how to customize the Blazor Kanban cards using templates, which is used to design beautiful cards with text, images, and more.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates how to customize the Kanban cards using templates.
                        In this demo, the cards are customized with icons, images, and tags.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        You can customize the default design of the Kanban cards using templates.
                        This can be achieved using the <code>KanbanCardSettings</code> -> <code>Template</code> property.
                    </p>
                    <p>In this demo, all the cards are customized with templating as text, images, and tags.</p>"
                }
            },
            new Sample
            {
                Name = "Toggle Columns",
                Category = "Columns",
                Directory = "Kanban/Kanban",
                Url = "kanban/toggle-columns",
                FileName = "ToggleColumns.razor",
                TitleTag = "Kanban . Toggle Columns . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the toggle column of Blazor Kanban, which is helpful to expand and collapse the columns and can be collapsed on page load also.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the toggle column feature of Kanban. Each column of Kanban can be collapsible, and the testing column is collapsed on page load itself.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The Kanban components allows you to expand or collapse its columns to save space.
                        The remaining columns extend its width to occupy the hided column space.
                        This feature can be achieved by the following properties:
                    </p>
                    <ul>
                        <li><code>AllowToggle:</code> Enables the expand/collapse behavior in Kanban.</li>
                        <li><code>IsExpanded:</code> The property determines whether the column can be collapsed on the page load itself.</li>
                    </ul>"
                }
            }
        };
    }
}