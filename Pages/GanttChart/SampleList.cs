using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
{
    internal partial class SampleConfig
    {

        public List<Sample> GanttChart { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/default-functionalities",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="DefaultFunctionalities.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>This sample visualizes the various phases involved in the manufacturing process of a product, which transforms from a conceptual model to a sellable product.</p>"
                },
                Description = new string[]{
                    @"<p>
                    In this example, you can see how to render a Gantt Chart with the provided data source. The default timeline
                    view week-day mode is applied to Gantt Chart. The dependency lines are enabled in this example to represent the
                    execution order or the hierarchy between the phases.
                    </p>
                    <p>
                    Tooltip is enabled for all the UI in this example. To see the tooltip in action, hover the mouse over or tap
                    taskbars, timeline units and dependency lines in touch enabled devices.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/remote-data",
                FileName="RemoteData.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the way of binding data to Gantt Chart with a remote service. The Gantt Chart data source is bound to remote data using the DataManager. The data in this sample shows the various phases of barley harvesting.</p>"
                },
                Description = new string[]{
                    @"<p>
                        The <code>DataSource</code> property in Gantt Chart can be assigned with the instance of
                        <code>DataManager</code> to bind remote data.
                        The DataManager, which will act as an interface between the service endpoint and the Gantt Chart, will require
                        the below minimal information to interact with service endpoint properly.
                        <ol>
                            <li><code>DataManager->Url</code> - Defines the service endpoint to fetch data</li>
                            <li>
                                <code>DataManager->Adaptor</code> - Defines the adaptor option. By default, ODataAdaptor is used for remote
                                binding.
                            </li>
                            Adaptor is responsible for processing response and request from/to the service endpoint.
                            <code>'@syncfusion/ej2-data</code>
                            package provides some predefined adaptors which are designed to interact with particular service endpoints. They
                            are,
                            <li>
                                <code>UrlAdaptor</code> - Use this to interact any remote services. This is the base adaptor for all remote
                                based adaptors.
                            </li>
                            <li><code>ODataAdaptor</code> - Use this to interact with OData endpoints.</li>
                            <li><code>ODataV4Adaptor</code> - Use this to interact with OData V4 endpoints.</li>
                            <li><code>WebApiAdaptor</code> - Use this to interact with Web API created under OData standards.</li>
                            <li><code>WebMethodAdaptor</code> - Use this to interact with web methods.</li>
                            In this demo, remote data is bound by assigning service data as an instance of
                            <code>DataManager</code> to the
                            <code>DataSource</code>
                            property.
                            More information on the data binding can be found in this <a href='https://blazor.syncfusion.com/documentation/gantt-chart/data-binding/#remote-data' target='_blank'>documentation</a> section.
                        </ol>
                    </p>"
                }
            },
              new Sample
            {
                Name = "Editing",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/editing",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Editing",
                        FileName="Editing.razor"
                    },
                    new SourceCollection
                    {
                        Id="EditData",
                        FileName="GanttData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @" <p>
                    This sample demonstrates the various phases involved in constructing a residential house, from testing the soil to handing over the fully constructed property to the owner. This also demonstrates CRUD operations in a Gantt Chart.
                    You can perform CRUD operations as follows,
                    <li><code>Add</code> - To add new task, click Add toolbar button</li>
                    <li>
                    <code>Edit </code>- To edit a task, double click a row or double click a taskbar or click toolbar Edit
                    button after
                    selected a row
                    </li>
                    <li><code>Delete</code> - To delete a task, click toolbar Delete button after selected a row</li>
                    <li>
                    <code>Update,Cancel</code> - You can save or discard changes by click toolbar Update and Cancel button
                    respectively
                    </li>
                    </p>"
                },
                Description = new string[]{
                    @"<p>
                    This CRUD operations can be configured in Gantt Chart using <code>EditSettings</code> and
                    <code>AllowTaskbarEditing</code>. Gantt Chart
                    has two modes to manipulate the datasource
                    <li><code>Auto</code></li>
                    <li><code>Dialog</code></li>
                    In this demo, <code>Auto</code> mode is enabled for editing. On the TreeGrid side, you can start editing any row
                    by double
                    clicking on it or clicking on toolbar’s Edit button, then the currently selected row will be changed to edited
                    state. On the Chart side, you can edit the tasks using edit dialog by double clicking on the taskbars and you
                    can edit the dependency connector lines using drag and drop action with connector line points available on the
                    either side of taskbar.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Baseline",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/baseline",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Baseline",
                        FileName="Baseline.razor"
                    },
                    new SourceCollection
                    {
                        Id="BaseRecord",
                        FileName="BaseData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample visualizes the complete service schedule for a car. Baselines are enabled to view the deviation between the planned dates and actual dates.
                    </p>"
                },
                Description = new string[]{
                    @"<p>
                        The baseline feature enables the user to view the deviation between the planned dates and the actual dates of
                        the tasks in a project. Baselines can be enabled in Gantt Chart by enabling the <code>RenderBaseline</code>
                        property along
                        with mapping the data source values for <code>BaselineStartDate</code> and <code>BaselineEndDate</code>
                        properties.
                        The baseline will appear for all type of tasks in the project such as child tasks, parent tasks and also for
                        milestones. You can change the color for the baselines using <code>BaselineColor</code> property.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Taskbar Template",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/taskbar-template",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TaskbarTemplate",
                        FileName="GanttTaskbarTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="TaskbarRecord",
                        FileName="TaskbarTemplateData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample visualizes the complete event schedule of the 90th Academy awards.
                        Taskbars are customized using template support and timeline header is customized for a better view of the data.
                    </p>"
                },
                Description = new string[]{
                    @" <p>
                        The Gantt Chart provides support for customizing taskbar UI using taskbar template feature. The
                        <code>TaskbarTemplate</code>
                        property accepts either string or HTML element`s ID value, which will be used as the template for the taskbars.
                        The summary tasks and the milestone items can also customized using the <code>ParentTaskbarTemplate</code> and
                        <code>MilestoneTemplate</code> properties.
                        In this demo, we have customized the taskbar UI by using the HTML elements between the template tags and displays the data from custom columns.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Filtering",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/filtering",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Filtering",
                         FileName = "Filtering.razor",
                    },
                    new SourceCollection
                    {
                        Id="Filter",
                        FileName="FilterData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample visualizes the manned lunar mission, which landed the first human on the Moon using the Apollo 11 spacecraft in the year 1969. It also demonstrates the filtering feature available in the Gantt Chart. You can filter a particular column using the filter menu available in the columns. This sample is also enabled with the toolbar searching option to filter the Gantt content across all the columns.
                    </p>"
                },
                Description = new string[]{
                    @"<p>
                        The filtering feature enables the user to view reduced amount of records based on filter criteria. The column menu filtering can be enabled by setting <code>AllowFiltering</code> property as <code>true</code> and toolbar search box can be enabled by including the search item in the <code>Toolbar</code> property. Gantt Chart also provides support for a set of filtering modes with <code>HierarchyMode</code> property. The below are the type of filter mode available in Gantt Chart.
                        <li><code> Parent </code> - This is the default filter hierarchy mode in Gantt Chart. The filtered records are displayed with its parent records, if the filtered records not have any parent record then the filtered record alone will be displayed.</li>
                        <li><code> Child </code> - The filtered records are displayed with its child record, if the filtered records do not have any child record then only the filtered records are displayed.</li>
                        <li><code> Both </code> - The filtered records are displayed with its both parent and child record. If the filtered records do not have any parent and child record then only the filtered records are displayed.</li>
                        <li><code> None </code> - Only the filtered records are displayed.</li>
                    </p>"
                }
            },
            new Sample
            {
                Name = "Zooming",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/zooming",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Zoom",
                        FileName = "Zooming.razor",
                    },
                    new SourceCollection
                    {
                        Id="ZoomRecord",
                        FileName="ZoomingData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @" <p>
                    This sample visualizes the various phases involved in the manufacturing process of a product, 
                    which transforms from a conceptual model to a sellable product.
                    </p>"
                },
                Description = new string[]{
                    @"<p>
                The sample demonstrates the zooming support in Gantt Chart.
                    You can zoom in or zoom out the project timeline dynamically with following toolbar buttons.

                    <li><code>ZoomIn</code> - To perform zoom in action on Gantt timeline.</li>
                    <li><code>ZoomOut </code> - To perform zoom out action on Gantt timeline.</li>
                    <li><code>ZoomToFit </code> - To show all tasks with timeline fit into available Chart width.</li>
                    <br>
                    The zooming feature enables you to view the tasks in the project clearly from minute to year timespan. You need
                    to include
                    <code>ZoomIn</code>, <code>ZoomOut </code> and <code>ZoomToFit </code> buttons in the toolbar for performing
                    zooming actions in Gantt Chart.
                    <li><code>ZoomIn</code> - If the user clicks on the <code>ZoomIn</code> icon we have increased the timeline cell
                        width,
                        when the cell size exceeds the specified range then we have changed the timeline view mode.</li>
                    <li><code>ZoomOut </code> - If the user clicks on the <code>ZoomOut</code> icon we have decrease the timeline
                        cell width, when the cell size falls
                        behind the specified range then we have changed the timeline view mode based on the zooming levels.</li>
                    <li><code>ZoomToFit </code> - In project, if the tasks are rendered in different time ranges, when the user
                        clicks on the <code>ZoomToFit</code> icon,
                        then all the tasks are rendered within the current viewable Chart container width.</li>
                    </p>"
                }
            },
            new Sample
            {
                Name = "Context Menu",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/context-menu",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ContextMenu",
                        FileName = "ContextMenu.razor",
                    },
                    new SourceCollection
                    {
                        Id="ContextMenuData",
                        FileName="GanttData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @" <p>
                    This sample demonstrates the various phases involved in constructing a residential house, from testing
                    the soil to handing over the fully constructed property to the owner. This also demonstrates the usage of
                    default context menu in Gantt component.
                    </p>"
                },
                Description = new string[]{
                    @"<p>
                    Gantt has an option to show the context menu while performing right click on it. You can configure the default
                    and custom menu items in the context menu using the <code>ContextMenuItems</code> property.
                    Each menu item will be displayed contextually based on its target. In this demo we have rendered following
                    default items
                    </p>
                <p>Default items:</p>
                <ul>
                    <li><code>AutoFitAll</code> - Auto fit all columns.</li>
                    <li><code>AutoFit</code> - Auto fit the current column.</li>
                    <li><code>TaskInformation</code> - Edit the current record.</li>
                    <li><code>DeleteTask</code> - Delete the current record.</li>
                    <li><code>Save</code> - Save the edited record.</li>
                    <li><code>Cancel</code> - Cancel the edited state.</li>
                    <li><code>SortAscending </code> - Sort the current column in ascending order.</li>
                    <li><code>SortDescending </code> - Sort the current column in descending order.</li>
                    <li><code>DeleteDependency </code> - Delete the dependency of the current record.</li>
                    <li><code>Convert </code> - Convert the normal task in to milestone task and vice versa.</li>
                    <li><code>Add</code>
                        <ul>
                            <li><code>Above</code> - Add a new row above the selected row </li>
                            <li><code>Below</code> - Add a new row below the selected row</li>
                            <li><code>Child</code> - Add a new row as child to the selected row</li>
                            <li><code>Milestone</code> - Add a milestone task below to selected row</li>
                        </ul>
                    </li>
                </ul>"
                
                }
            },
			new Sample
            {
                Name = "Unscheduled Task",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/unscheduled-task",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Unscheduled",
                        FileName = "UnscheduledTask.razor",
                    },
                    new SourceCollection
                    {
                        Id="UnscheduledData",
                        FileName="UnscheduleData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>This sample visualize the various types of unscheduled taskbars in Gantt with quick add support of task with custom toolbar in Gantt.</p>"
                },
                Description = new string[]{
                    @"<p>
                    Unscheduled tasks are tasks in a project that are not scheduled with proper dates or duration at the commencement
                    of the project.  These tasks can be scheduled properly at any time during project implementation based on factors
                    such as resource availability, dependent tasks, and more.
                    </p>
                    <p>
                    This example shows how to display the unscheduled tasks in Gantt by enabling the <code>AllowUnscheuldedTask</code> property.
                    This also shows how to add an empty row in Gantt by using a custom toolbar button click action.
                    </p>
                    <p>
                    By using the <code>OnToolbarClick</code> event and <code>AddRecord</code> method, an empty row can be added at the
                    top of the rows with undefined task details.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Timeline",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/timeline",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TimeTask",
                        FileName = "Timeline.razor",
                    },
                    new SourceCollection
                    {
                        Id="TimeRecord",
                        FileName="TimelineData.cs"
                    }
                },
                ActionDescription = new string[] {
                    @"<p>
                        This sample illustrates the different phases from planning to delivery, involved in a software development lifecycle. It demonstrates the different timeline modes available in the Gantt Chart. Options are available to change the unit, format, and count of the header texts for both top and bottom timeline headers
                    </p>"
                },
                Description = new string[]{
                    @"<p>
                        In this example, you can see how to change the timeline settings in Gantt Chart. The top and bottom timeline
                        header texts can be customized by using the <code>TimelineSettings.TopTier</code> and <code>TimelineSettings.BottomTier</code> properties.
                        Using these properties, you can change the format, count, and units of the timeline header texts.
                    </p>
                    <p></p>
                    Gantt Chart has built-in support for many timeline modes such as minutes, hour, day, week, month and year.
                    </p>
                    <p>
                        Tooltip is enabled by default for the timeline headers, to see the tooltip in action, hover a point or tap on a
                        point in touch enabled devices.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Exporting",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/exporting",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ExportTask",
                        FileName = "Exporting.razor",
                    },
                    new SourceCollection
                    {
                        Id="ExportRecord",
                        FileName="GanttData.cs"
                    }
                },
                Type = SampleType.New,                
                ActionDescription = new string[] {
                    @" <p> This sample demonstrates client-side exporting of the Gantt, which allows you to export Gantt data to Excel and
                    CSV formats. Using the Gantt toolbar buttons, you can export Gantt data to the desired format.
                    </p>"
                },
                Description = new string[]{
                    @"<p>Gantt supports client-side exporting, which allows you to export its data to the Excel and CSV formats.</p>
                    <p>In this demo, we have defined actions in the <code>ToolbarClick</code> event to export the Gantt data using the
                    <code>ExcelExport</code> and <code>CsvExport</code> methods.</p>"
                }
            }
        };
    }
}
