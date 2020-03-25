using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> DataGrid { get; set; } = new List<Sample>{
             new Sample
            {
                Name = "Overview",
                Category = "DataGrid",
                Directory = "Grid/DataGrid",
                Url = "datagrid/overview",
                FileName = "Overview.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the overview of Blazor DataGrid features with its performance metrics of large data. To change datasource count, select rows and columns count from dropdown.</p>"
                },
                Description = new string[]{
                    @"<p>The Blazor DataGrid is used to display and manipulate tabular data with configuration options to control the way the data is presented and manipulated. It can pull the data from data sources, like IEnumerable, OData web services, or <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.DataManager.html'>DataManager</a></code> Component and bind the data fields to columns. It also displays a column header to identify the field with support for grouped records.</p>
                    <p>In this demo, Blazor DataGrid features such as <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/virtual/'>Virtual Scrolling</a>, <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/filtering/'>Filtering</a>, <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/sorting/'>Sorting</a>, <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/columns/#column-template'>Column Template</a>, etc... are used along with large data source</p>
                    <p>More information on the Blazor DataGrid infinite scrolling can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/virtual/'>Virtualization</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "DataGrid",
                Directory = "Grid/DataGrid",
                Url = "datagrid/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None,                
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default rendering of the DataGrid with minimum configuration.</p>"
                },
                Description = new string[]{
                    @"<p>The DataGrid is used to display and manipulate tabular data with configuration options to control the way the data is presented and manipulated. It can pull the data from data sources, like IEnumerable, OData web services, or <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.DataManager.html'>DataManager</a></code> and bind the data fields to columns. It also displays a column header to identify the field with support for grouped records.</p>
                    <p>In this demo, the DataGrid is populated with its minimum default settings.</p>
                    <p>More information on the Blazor DataGrid can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/getting-started/?no-cache=1'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "List Binding",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/local-data",
                FileName = "LocalData.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the way of data binding DataGrid component with List object(list binding data source).</p>"
                },
                Description = new string[]{
                    @"<p>The DataGrid supports data binding. The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~DataSource.html'>DataSource</a></code>  property can be assigned either as list of objects or with instance of <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.DataManager.html'>DataManager</a></code>.</p>
                    <p>In this demo, the list of objects is assigned as the data source to the DataGrid. DataGrid can be bound to IEnumerable, IQueryable and ObservableCollection type data sources.</p>
                    <p>More information on the List data binding can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/data-binding/#list-binding'>documentation section</a>.</p>"
                }
            },
             new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/remote-data",
                FileName = "RemoteData.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the way of data binding DataGrid component with remote service. The DataGrid data source is bound to remote data using DataManager component.</p>"
                },
                Description = new string[]{
                    @"<p>The DataGrid supports data binding. The DataManager component can be used to configure DataGrid to bind remote data.</p>
                    <p>The DataManager, which will act as an interface between the service endpoint and the DataGrid, will require the below minimal information to interact with service endpoint properly,</p>
                    <ul>
                        <li><code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.DataManager~Url.html'>DataManager.Url</a></code> - Defines the service endpoint to fetch the data</li>
                        <li><code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.DataManager~Adaptor.html'>DataManager.Adaptor</a></code> - Defines the adaptor option. By default, <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Data.UrlAdaptor.html'>ODataAdaptor</a></code> is used for remote binding.</li>
                    </ul>
                    <p>Adaptor is responsible for processing the response and request from/to the service endpoint. The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Data_namespace.html'>Syncfusion.Blazor.Data</a></code> namespace provides some predefined adaptors which are designed to interact with particular service endpoints. The predefined adaptors are,</p>
                    <ul>
                        <li><strong>UrlAdaptor</strong> - Use this to interact with any remote service. This is the base adaptor for all remote based adaptors.</li>
                        <li><strong>ODataAdaptor</strong>- Use this to interact with OData endpoints.</li>
                        <li><strong>ODataV4Adaptor</strong> - Use this to interact with OData V4 endpoints.</li>
                        <li><strong>WebApiAdaptor</strong> - Use this to interact with Web API created under OData standards.</li>                    </ul>
                    <p>In this demo, remote data is bound by assigning service data as an instance of <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.DataManager.html'>DataManager </a></code> component.
                    <p>More information on the remote data binding can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/data-binding/#remote-data'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Custom Binding",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/custom-binding",
                FileName = "CustomBinding.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the usage of custom data binding in DataGrid component.
                    </p>"
                },
                Description = new string[]{
                    @"<p>
                        The custom data binding can be performed in the DataGrid component by providing the custom adaptor class
                        and overriding the <strong>Read or ReadAsync</strong> method of the DataAdaptor abstract class.
                        The CRUD operations for the custom bounded data in the DataGrid component can be
                        implemented by overriding the following CRUD methods of the DataAdaptor abstract class,
                        <br>
                    </p>
                    <ul>
                        <li><strong>Insert/InsertAsync</strong> - Performs Insert operation.</li>
                        <li><strong>Remove/RemoveAsync</strong> - Performs Remove operation.</li>
                        <li><strong>Update/UpdateAsync</strong> - Performs Update operation.</li>
                        <li><strong>BatchUpdate/BatchUpdateAsync</strong> - Performs BatchUpdate operation.</li>
                    </ul>

                    <p>In this demo, CRUD operations for the custom bounded data is performed using the methods of DataAdaptor abstract class.
                    Similarly, you can perform Batch Update operations using <strong>BatchUpdate/BatchUpdateAsync</strong> methods.</p>
                    <p>More information on the custom data binding can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/custom-binding/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Context Menu",
                Category = "DataGrid",
                Directory = "Grid/DataGrid",
                Url = "datagrid/context-menu",
                FileName = "ContextMenu.razor",
                Type = SampleType.None,               
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the usage of context menu in DataGrid component. Right click anywhere on the DataGrid to view context menu.
                    </p>"
                },
                Description = new string[]{
                    @"<p>DataGrid has options to show the context menu when right clicking on it. To configure the items in context menu, you should define either default or custom item in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~ContextMenuItems.html'>ContextMenuItems</a></code> property. Each item will be shown based on its target. The default context menu items are,</p>
                    <ul>
                        <li><strong>Edit</strong> - Edit the current record.</li>
                        <li><strong>Delete</strong> - Delete the current record.</li>
                        <li><strong>Save</strong> - Save the edited record.</li>
                        <li><strong>Cancel</strong> - Cancel the edited state.</li>
                        <li><strong>Copy</strong> - Copy the selected records.</li>
                        <li><strong>PdfExport</strong> - Export the DataGrid as Pdf format.</li>
                        <li><strong>ExcelExport</strong> - Export the DataGrid as Excel format.</li>
                        <li><strong>CsvExport</strong> - Export the DataGrid as CSV format.</li>
                        <li><strong>SortAscending</strong> - Sort the current column in ascending order.</li>
                        <li><strong>SortDescending</strong> - Sort the current column in descending order.</li>
                        <li><strong>FirstPage</strong> - Go to the first page.</li>
                        <li><strong>PrevPage</strong> - Go to the previous page.</li>
                        <li><strong>LastPage</strong> - Go to the last page.</li>
                        <li><strong>NextPage</strong> - Go to the next page.</li>
                    </ul>
                    <p>While using the DataGrid in a touch environment, touch and hold the DataGrid row cell to show the context menu.</p>
                    <p>In this demo, Context Menu feature is enabled by defining the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~ContextMenuItems.html'>ContextMenuItems</a></code> property with the default items.</p>
                    <p>More information on the context menu feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/context-menu/'>documentation section</a>.</p>"

                }
            },
            new Sample
            {
                Name = "Default Scrolling",
                Category = "Scrolling",
                Directory = "Grid/DataGrid",
                Url = "datagrid/default-scrolling",
                FileName = "DefaultScrolling.razor",
                Type = SampleType.None,               
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the DataGrid component with the horizontal and vertical scrollbars to view the exceeded DataGrid content.</p>"
                },
                Description = new string[]{
                    @"<p>The DataGrid will show scrollbar when the content exceeds the element width or height. The vertical and horizontal scrollbar will be displayed based on the following criteria,</p>
                    <ul>
                        <li>The vertical scrollbar appears when the total height of rows present in DataGrid exceeds its element height.</li>
                        <li>The horizontal scrollbar appears when the total width of columns present in DataGrid exceeds its element width.</li>
                    </ul>
                    <p>The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~Height.html'>Height </a></code> and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~Width.html'>Width </a></code> properties are used to set theDataGrid height and width respectively. The value of these properties can be numeric value, pixel(<code>px</code>) or percentage (<code>%</code>).</p>
                    <p>In this demo, the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~Height.html'>Height </a></code> and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~Width.html'>Width </a></code> properties of theDataGrid are set to <strong><em>410</em></strong> and <strong><em>auto</em></strong> respectively. Now, the DataGrid will render with vertical scrollbar when the total height of rows exceeds its element height and horizontal scrollbar will appear when the total column width exceeds the element width.</p>
                    <p>More information on the scrolling in Blazor DataGrid can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/scrolling/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Scrolling",
                Directory = "Grid/DataGrid",
                Url = "datagrid/virtual-scrolling",
                FileName = "VirtualScrolling.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the DataGrid component with the horizontal and vertical scrollbars to view the exceeded DataGrid content.</p>"
                },
                Description = new string[]{
                    @"<p>The DataGrid UI virtualization allows it to render only rows and columns visible within the view-port without buffering the entire datasource. DataGrid supports both row and column virtualization. To enable row virtualization, set <code><a target='_blank' class='code' href= 'https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~EnableVirtualization.html'>EnableVirtualization</a></code> property as true. For column virtualization, set <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~EnableColumnVirtualization.html'>EnableColumnVirtualization</a></code> property as true.</p>
                    <p>The height property must be defined when enabling <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~EnableVirtualization.html'>EnableVirtualization</a></code> property and width property must be defined when enabling <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~EnableColumnVirtualization.html'>EnableColumnVirtualization</a></code>.</p>
                    <p>In this demo, DataGrid is rendered with row and column virtualization. DataGrid is binded with 10000 rows and 20 columns</p>
                    <p>More information on the Virtual Scrolling can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/virtual/'>documentation section</a>.</p>"
                }
            },
            // new Sample
            // {
            //     Name = "Grid Lines",
            //     Category = "DataGrid",
            //     Directory = "Grid/DataGrid",
            //     Url = "datagrid/grid-lines",
            //     FileName = "GridLines.razor",
            //     Type = SampleType.New,
            //     TitleTag = "DataGrid . Grid Lines . Syncfusion Blazor Components",
            //     MetaDescription = "This demo for Syncfusion Blazor DataGrid component demonstrates the visibility of the grid lines that separate the rows and columns.",
            //     ActionDescription = new string[] {
            //         @"<p>This sample demonstrates visibility of the grid lines that separates the rows and columns.</p>"
            //     },
            //     Description = new string[]{
            //         @"<p>The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~GridLines.html'>GridLines</a></code> property is used to control the line visibility that separates the rows and columns. The following grid lines can be displayed in the grid,</p>
            //         <ul>
            //             <li><code>Default</code> - Shows the Horizontal line.</li>
            //             <li><code>None</code> - Shows no line.</li>
            //             <li><code>Both</code> - Shows both Horizontal and Vertical lines.</li>
            //             <li><code>Horizontal</code> - Shows the Horizontal line.</li>
            //             <li><code>Vertical</code> - Shows the Vertical line.</li>
            //         </ul>
            //         <p> In this demo, we have set the GridLines value as Both.</p>
            //         <p>More information on the GridLines configuration can be found in this<a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/cell/#grid-lines'>documentation section</a>.</p>"
            //     }
            // },
            new Sample
            {
                Name = "AutoWrap Column Cells",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/auto-wrap",
                FileName = "AutoWrap.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the DataGrid component with the auto wrap column cell. In this sample, you can see that the <strong>Main fields of invention</strong> column cell content exceeded the available width hence it has been wrapped into multiple lines.
                    </p>"
                },
                Description = new string[]{
                    @"<p>Auto wrap cell content can be enabled using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.EjsGrid%601~AllowTextWrap.html'>AllowTextWrap</a></code> property of theDataGrid. Enabling this property will wrap the cell text in multiple lines. When the cell content exceeds the cell width this feature is useful to view the content.</p>
                    <p>Enabling this property will wrap both the content cell and header cell text.</p>
                    <p>In this demo, the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.EjsGrid%601~AllowTextWrap.html'>AllowTextWrap</a></code> property is enabled which can be seen in the <strong>Main fields of invention</strong> column whose content is wrapped into multiple lines as it exceeds the cell width.</p>
                    <p>More information on AutoWrap feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/cell/#auto-wrap'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Stacked Header",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/stacked-header",
                FileName = "GridStackedHeader.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the DataGrid component with the stacked header and resize feature. In this sample, we have shown multiple level of column headers.
                    </p>"
                },
                Description = new string[]{
                    @"<p>The DataGrid columns can be stacked/grouped in order to show multiple levels of column headers. It can be done by nesting the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn~Columns.html'>GridColumn</a></code> component within another <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn.html'>GridColumn</a></code> component.</p>
                    <p>The DataGrid columns can be resized by clicking at the right end of the column header and dragging it. To enable column resize behavior, set <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~AllowResizing.html'>AllowResizing</a></code> property as true. You can also prevent the resize of particular columns by setting <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn~AllowResizing.html'>AllowResizing</a></code> property as false in the column definition.</p>
                    <p>In this demo, the columns <strong>OrderDate, Freight</strong> are grouped under <strong>Order Details</strong> and the columns <strong>ShippedDate, ShipCountry</strong> are grouped under <strong>Shipped Details</strong>.</p>
                    <p>More information on column stacked header can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/columns/#resize-stacked-column'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Column Reorder",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/reorder",
                FileName = "Reorder.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates reordering of the DataGrid columns.You can reorder columns by simply drag and drop in the desired column position.
                    </p>"
                },
                Description = new string[]{
                    @"<p>Reordering can be enabled by setting <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~AllowReordering.html'>AllowReordering</a></code> property as true. Reordering can be done by dragging and dropping the column header from one index to another index within the DataGrid.</p>
                    <p>The location where the column will be placed is indicated by two arrow symbols.</p>
                    <p>In this demo, you can reorder the columns by drag and drop.</p>
                    <p>More information on the column reorder can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/columns/#reorder'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Column Chooser",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/column-chooser",
                FileName = "ColumnChooser.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the DataGrid column chooser feature. Click the column chooser
                    icon in the toolbar to open column chooser and you can select columns to hide/show from the checkbox list. 
                    </p>"
                },
                Description = new string[]{
                    @"<p>The DataGrid columns can be shown/hidden dynamically by using column chooser functionality. To enable column chooser, set <code><a target='_blank' class='code' href=' https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.EjsGrid%601~ShowColumnChooser.html'>ShowColumnChooser</a></code> property as true. You can also prevent the display of a column in column chooser by setting <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.EjsGrid%601~ShowColumnChooser.html'>ShowInColumnChooser</a></code> as false in the columns definition.</p>
                    <p>In this demo, when the user clicks column chooser icon from the toolbar, the column chooser menu will open. Here the user can show or hide the columns by changing the state of the checkbox.</p>
                    <p>More information on the column chooser can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/columns/#column-chooser'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Column Resize",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/column-resize",
                FileName = "Columnresize.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the DataGrid column resizing feature. Click and drag at the right corner of each column header to
                    resize the column.</p>"
                },
                Description = new string[]{
                    @"<p>The DataGrid columns can be resized by clicking the right corner of column header and dragging it. To enable column resize behavior, set <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~AllowResizing.html'>AllowResizing</a></code> property as true. You can also prevent the resize of the particular column by setting <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn~AllowResizing.html'>AllowResizing</a></code> property as false in the columns definition. And, by double clicking at the right corner of column header, the respective column width will get auto adjusted by the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.EjsGrid%601~AutoFitColumns.html'>AutoFitColumns</a></code> method.</p>
                    <p>In this demo, AllowResizing feature has been enabled by setting the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~AllowResizing.html'>AllowResizing</a></code> property to true and <b>Order ID</b> column can be resized between the range of <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn~MinWidth.html'>MinWidth (120px)</a></code> and <code><a target='_blank' class='code' href= https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn~MaxWidth.html'>MaxWidth (300px)</a>.</code> Also, column resizing has been disabled for the <b>Shipped Date</b> column.</p>
                    <p>More information on the custom data binding can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/custom-binding/'>documentation section</a>.</p>"
                }

            },
            new Sample
            {
                Name = "Column Menu",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/column-menu",
                FileName = "Columnmenu.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default functionalities of the ColumnMenu. Click on multiple icon of each column to open the column menu.</p>"
                },
                Description = new string[]{
                    @"<p>DataGrid has option to show column menu on clicking the multiple icon in each column. The column menu has integrated options which allows the user to interact with features like sorting, grouping, filtering, column chooser and autofit. The column menu can be enabled by setting the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~ShowColumnMenu.html'>ShowColumnMenu</a></code> property value as <b>true</b>. The default items in the column menu are, </p>
                    <ul>
                        <li><strong>SortAscending</strong> - Sort the current column in ascending order.</li>
                        <li><strong>SortDescending</strong> - Sort the current column in descending order.</li>
                        <li><strong>Group</strong> - Group the current column.</li>
                        <li><strong>Ungroup</strong> - Ungroup the current column.</li>
                        <li><strong>AutoFit</strong> - Auto fit current column.</li>
                        <li><strong>AutoFitAll</strong> - Auto fit all columns.</li>
                        <li><strong>ColumnChooser</strong> - Choose the column visibility.</li>
                        <li><strong>Filter</strong> - Show the filter option as given in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridFilterSettings~Type.html'>Type</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridFilterSettings.html'>GridFilterSettings</a></code> component.</li>
                    </ul>
                    <p>In this demo, column menu functionality is enabled by defining <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~ShowColumnMenu.html'>ShowColumnMenu</a></code> as <b>true</b> with sorting, grouping, filtering, column chooser and autofit options.</p>
                    <p>More information on the column menu can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/columns/#column-menu'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Row Hover",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "datagrid/row-hover",
                FileName = "RowHover.razor",
                Type = SampleType.None,                
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the DataGrid component with the row hover feature. Move the mouse over the DataGrid rows to see the
                    hover effect.</p>"
                },
                Description = new string[]{
                    @"<p>Row Hover feature enables us to identify the current row by highlighting them on hovering the mouse over them. This can be enabled by setting the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~EnableHover.html'>EnableHover</a></code> property as true.</p>
                    <p>In this demo, you can move the mouse over DataGrid rows to see the hover effect.</p>"                    
                }
            },
             new Sample
             {
                 Name = "Row Drag And Drop",
                 Category = "Rows",
                 Directory = "Grid/DataGrid",
                 Url = "datagrid/row-drag-and-drop",
                 FileName = "RowDragAndDrop.razor",
                 Type = SampleType.None,                 
                 ActionDescription = new string[] {
                    @"<p>This sample demonstrates the DataGrid component with the row drag and drop feature. Drag and drop rows between DataGrids
                        to move rows.</p>"
                },
                Description = new string[]{
                    @"<p>DataGrid rows can be dragged and dropped to another DataGrid by enabling <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~AllowRowDragAndDrop.html'>AllowRowDragAndDrop</a></code> property. The target control on which the DataGrid rows has to be dropped can be set by using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridRowDropSettings~TargetID.html'>TargetID</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridRowDropSettings.html'>GridRowDropSettings</a></code> component.</p>
                    <p>The Selection feature should be enabled to select the rows.  Multiple rows can be selected by simply clicking and dragging them inside the DataGrid.</p>
                    <p>In this demo, the Row drag and drop feature is enabled in both the DataGrids. To drag and drop rows between DataGrids select rows, drag and drop them to the adjacent DataGrid.</p>"                 
                }
             },
            // new Sample
            // {
            //    Name = "Row Drag And Drop Within Grid",
            //    Category = "Rows",
            //    Directory = "Grid/DataGrid",
            //    Url = "datagrid/draganddrop-within-grid",
            //    FileName = "DragAndDropWithinGrid.razor",
            //    Type = SampleType.New,
            //    ActionDescription = new string[] {
            //         @"<p>This sample demonstrates the Grid component with the row drag and drop feature within same grid. You can rearrange the grid rows by using drag icon in left side of grid column.Here you can drag and drop the grid rows between the decided rows.</p>"
            //     },
            //     Description = new string[]{
            //         @"<p>Row drag and drop can be enabled by setting <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~AllowRowDragAndDrop.html'>AllowRowDragAndDrop</a></code> property as true.</p>"
            //     }
            // },
            new Sample
            {
                Name = "Inline Editing",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "datagrid/inline-editing",
                FileName = "InlineEditing.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates CRUD operations in DataGrid. You can perform CRUD operations as follows,</p>
                    <ul>
                        <li><strong>Add</strong> -  To add new record, click Add toolbar button </li>
                        <li><strong>Edit</strong> - To edit record, double click a row or click toolbar Edit button after selected a row </li>
                        <li><strong>Delete</strong> - To delete record, click toolbar Delete button after selected a row </li>
                        <li><strong>Update</strong>,<strong>Cancel</strong> - You can save or discard changes by click toolbar Update and Cancel button respectively</li>
                    </ul>
                    <p>By default, a new row will be added at the top of the DataGrid. You can change it by defining the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings~NewRowPosition.html'>NewRowPosition</a></code> in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> as <strong>Bottom</strong></p>"
                },
                Description = new string[]{
                    @"<p>The DataGrid supports CRUD operations. The CRUD operations can be configured in DataGrid using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component. It also has different modes to manipulate the datasource.</p>
                    <p>The available modes are,</p>
                    <ul>
                        <li><strong>Inline</strong></li>
                        <li><strong>Dialog</strong></li>
                        <li><strong>Batch</strong></li>
                    </ul>
                    <p>In this demo, Inline mode is enabled for editing by defining <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings~Mode.html'>Mode</a></code> as <strong>Inline</strong> in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component. You can start editing by double clicking a row or clicking on toolbar’s <strong>Edit</strong> button which will change the row to editing state. You can change the row values and save the edited data to the datasource.  You can use the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn~EditTemplate.html'>EditTemplate</a></code> of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn.html'>GridColumn</a></code> component to render the cell edit template.</p>
                    <p>In this demo, AutoComplete Component is rendered inside the Customer ID column using EditTemplate.</p>
                    <p>More information on the inline editing can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/editing/#normal'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Dialog Editing",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "datagrid/dialog-editing",
                FileName = "DialogEditing.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates CRUD operations in DataGrid. You can perform CRUD operations as follows,</p>
                    <ul>
                        <li><strong>Add</strong> -  To add new record, click Add toolbar button </li>
                        <li><strong>Edit</strong> - To edit record, double click a row or click toolbar Edit button after selected a row </li>
                        <li><strong>Delete</strong> - To delete record, click toolbar Delete button after selected a row </li>
                        <li><strong>Update</strong>,<strong>Cancel</strong> - You can save or discard changes by click toolbar Update and Cancel button respectively</li>
                    </ul>."
                },
                Description = new string[]{
                    @"<p>The DataGrid supports CRUD operations. The CRUD operations can be configured in DataGrid using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component. It also has different modes to manipulate the datasource.</p>
                    <p>The available modes are,</p>
                    <ul>
                        <li><strong>Inline</strong></li>
                        <li><strong>Dialog</strong></li>
                        <li><strong>Batch</strong></li>
                    </ul>
                    <p>In this demo, Dialog mode is enabled for editing by defining <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings~Mode.html'>Mode</a></code> in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component as <strong>Dialog</strong>. You can start editing by double clicking a row or clicking on toolbar’s <strong>Edit</strong> button. The currently selected row will be shown on a dialog and you can change the row values and save edited data to the datasource.</p>
                    <p>More information on the dialog editing can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/editing/#dialog'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Dialog Template",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "datagrid/grid-dialog-template",
                FileName = "GridDialogTemplate.razor",
                Type = SampleType.None,
                   ActionDescription = new string[] {
                    @"<p>This sample demonstrates CRUD operations in DataGrid. You can perform CRUD operations as follows,</p>
            <ul>
                <li><strong>Add</strong> -  To add new record, click Add toolbar button </li>
                <li><strong>Edit</strong> - To edit record, double click a row or click toolbar Edit button after selected a row </li>
                <li><strong>Delete</strong> - To delete record, click toolbar Delete button after selected a row </li>
                <li><strong>Update</strong>,<strong>Cancel</strong> - You can save or discard changes by click toolbar Update and Cancel button respectively</li>
            </ul>."
                },
                Description = new string[]{
                    @"<p>The DataGrid supports CRUD operations. This CRUD operations can be configured in DataGrid using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component.</p>
                    <p>In this demo, Dialog template is enabled for editing by defining <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings~Mode.html'>Mode</a></code> as <strong>Dialog</strong> in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component. You can use the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings~Template.html'>Template</a></code> component. property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component to render the custom Dialog.</p>
                    <p>More information on the dialog template editing can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/editing/#dialog-template'>documentation section</a>.</p>"

                }
            },
            new Sample
            {
                Name = "Batch Editing",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "datagrid/batch-editing",
                FileName = "BatchEditing.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates CRUD operations in DataGrid. You can perform CRUD operations as follows,</p>
                    <ul>
                        <li><strong>Add</strong> -  To add new record, click Add toolbar button </li>
                        <li><strong>Edit</strong> - To edit record, double click a row or click toolbar Edit button after selected a row </li>
                        <li><strong>Delete</strong> - To delete record, click toolbar Delete button after selected a row </li>
                        <li><strong>Update</strong>,<strong>Cancel</strong> - You can save or discard changes by click toolbar Update and Cancel button respectively</li>
                    </ul>
                    <p>By default, a new row will be added at the top of the DataGrid. You can change it by defining the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings~NewRowPosition.html'>NewRowPosition</a></code> in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> as <strong>Bottom</strong></p>"
                },
                Description = new string[]{
                    @"<p>The DataGrid supports CRUD operations. The CRUD operations can be configured in DataGrid using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component. It also has different modes to manipulate the datasource.</p>
                    <p>The available modes are,</p>
                    <ul>
                        <li><strong>Inline</strong></li>
                        <li><strong>Dialog</strong></li>
                        <li><strong>Batch</strong></li>
                    </ul>
                    <p>In this demo, Batch mode is enabled for editing by defining <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings~Mode.html'>Mode</a></code> in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component as <strong>Batch</strong>. You can start editing by double clicking a cell and change the cell value. The edited cell will be highlighted while navigating to a new cell, so that you know which cells had been edited. You can then bulk save the edited data to the datasource by click on the toolbar's <strong>Update</strong> button.</p>
                    <p>More information on the batch editing can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/editing/#batch'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Command Column",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "datagrid/command-column",
                FileName = "CommandColumn.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates CRUD operations in DataGrid using command column. You can perform CRUD operations as follows,</p>
                    <ul>
                        <li><strong>Edit</strong> - To edit record, double click a row or click Edit button from command column after selected a row </li>
                        <li><strong>Delete</strong> - To delete record, click Delete button from command column after selected a row </li>
                        <li><strong>Update</strong>,<strong>Cancel</strong> - You can save or discard changes by click Update and Cancel button from command column respectively</li>
                    </ul>"
                },
                Description = new string[]{
                    @"<p>The DataGrid provides an option to render CRUD action buttons in a column by using the CommandColumn feature. The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn~Commands.html'>GridCommandColumns</a></code>  of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn.html'>GridColumn</a></code> component accepts array of <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.CommandModel.html'>GridCommandColumn</a></code> components. The predefined command button can be defined by using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.CommandModel~Type.html'>Type</a></code> property of the GridCommandColumn component.</p>
                    <p>The built-in command buttons are,</p>
                    <ul>
                        <li><strong>Edit</strong></li>
                        <li><strong>Delete</strong></li>
                        <li><strong>Cancel</strong></li>
                        <li><strong>Save</strong></li>
                    </ul>
                    <p>More information on the Command column editing can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/editing/#command-column'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Multi Sorting",
                Category = "DataGrid",
                Directory = "Grid/DataGrid",
                Url = "datagrid/sorting",
                FileName = "Sorting.razor",
                Type = SampleType.None,                
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the DataGrid multi sorting feature. To sort two or more columns, hold the CTRL key and click the column header.
                    </p>"
                },
                Description = new string[]{
                    @"<p>Sorting feature enables us to order the data in a particular direction. It can be enabled by setting the <code><a target='_blank' class='code' href=' https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.EjsGrid%601~AllowSorting.html '>AllowSorting</a></code> property as true.</p>
                    <p>To sort a DataGrid column simply click the column header. The icons <span class=""e-icons e-icon-ascending""></span>(ascending) and <span class=""e-icons e-icon-descending""></span>(descending) specifies the sort direction of a column.</p>
                    <p>By default, multi-sorting is enabled in DataGrid, to sort multiple columns hold the <strong> CTRL</strong> key and click the column header. To clear sort for a column, hold the <strong> SHIFT</strong> key and click the column header.</p>
                    <p>While using DataGrid in a touch device, you have an option for multi sorting in single tap on the DataGrid header. By tapping on the DataGrid header, it will show the toggle button in small popup with sort icon. Now tap the button to enable the multi-sorting in a single tap.</p>
                    <p>In this demo, simply click the column header to sort them.</p>
                    <p>More information on the multi sorting feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/sorting/#multi-column-sorting'>documentation section</a>.</p>"

                }
            },
            new Sample
            {
                Name = "Default Filtering",
                Category = "Filtering",
                Directory = "Grid/DataGrid",
                Url = "datagrid/filtering",
                FileName = "Filtering.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the DataGrid Default Filtering feature. In this sample, type the value in the filterbar and press enter
                        to filter particular column.
                    </p>"
                },
                Description = new string[]{
                    @"<p>The filtering feature enables the user to view reduced amount of records based on the filter criteria. It can be enabled by setting <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~AllowFiltering.html'>AllowFiltering</a></code> property as true.</p>

                    <p>A filter bar row will be rendered next to header which allows the users to filter data by entering text within its cells.</p>

                    <p>Filterbar uses two modes which specifies how to start filtering. They are,</p>
                    <ul>
                        <li><strong>OnEnter</strong> - Enabled by default, filter will be initiated after pressing Enter key.</li>
                        <li><strong>Immediate </strong> - Filter will start after user stops typing. This uses a time delay of 1500ms to initiate the filter after user has stopped typing. It can be overridden using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridFilterSettings~ImmediateModeDelay.html'>ImmediateModeDelay </a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridFilterSettings.html'>GridFilterSettings</a></code> component. </li>                       
                    </ul>
                    <p>In this demo, you can type the text in the filter bar cells to filter the DataGrid.</p>
                    <p>More information on the Filtering can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/filtering/#filter-bar'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Menu Filter",
                Category = "Filtering",
                Directory = "Grid/DataGrid",
                Url = "datagrid/filter-menu",
                FileName = "FilterMenu.razor",
                Type = SampleType.None,
                 ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the way of filtering DataGrid columns using menu, checkbox and excel filter UI. In this sample, click the filtering icon from column header to show filter UI for a particular column.
                    </p>"
                },
                Description = new string[]{
                    @"<p>The filtering feature enables the user to view the reduced amount of records based on filter criteria. It can be enabled by setting <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~AllowFiltering.html'>AllowFiltering</a></code> property as true.</p>
                    <p>DataGrid supports the following filter types,</p>
                    <ul>
                        <li><strong>FilterBar</strong></li>
                        <li><strong>Menu</strong></li>
                        <li><strong>CheckBox</strong></li>
                        <li><strong>Excel</strong></li>
                    </ul>
                     <p>You can change the filter type by using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridFilterSettings~Type.html'>Type</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridFilterSettings.html'>GridFilterSettings</a></code> component.</p>
                    
                    <p>More information on the filter configuration can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/filtering'>documentation section</a></p>"
                }
            },
            new Sample
            {
               Name = "Search",
               Category = "Filtering",
               Directory = "Grid/DataGrid",
               Url = "datagrid/search",
               FileName = "Search.razor",
               Type = SampleType.None,
               ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the DataGrid searching feature. In this sample, use the search box from toolbar to search DataGrid records.
                    </p>"
                },
                Description = new string[]{
                    @"<p>The DataGrid has option to search its content using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.EjsGrid%601~Search.html'>Search</a></code> method with search key as the parameter.</p>
                    <p>In this demo, the DataGrid toolbar provides an option to search the DataGrid's records. The user can type the search key in the text box of the toolbar and click search button or press Enter key to perform the search operation. The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.EjsGrid%601~Search.html'>Search</a></code> method will be initiated to perform the search here.</p>
                    <p>More information on the search feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/searching/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Paging",
                Category = "DataGrid",
                Directory = "Grid/DataGrid",
                Url = "datagrid/paging",
                FileName = "Paging.razor",
                Type = SampleType.None,                
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the DataGrid paging feature.</p>"
                },
                Description = new string[]{
                    @"<p>Paging allows you to display the contents of the DataGrid in page segments. By default, paging is disabled. To enable paging, set <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~AllowPaging.html'>AllowPaging</a></code> property to true.</p>
                    <p>The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridPageSettings~PageSizes.html'>PageSizes</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridPageSettings.html'>GridPageSettings</a></code> component enables a dropdown in pager which allows you to change the number of records displayed in the page dynamically.</p>
                    <p>In this demo, the DataGrid is rendered with paging enabled and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridPageSettings~PageSizes.html'>PageSizes</a></code> set as true and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridPageSettings~PageCount.html'>PageCount</a></code> set to 5.</p>
                    <p>More information on the Paging can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/custom-binding/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Default Selection",
                Category = "Selection",
                Directory = "Grid/DataGrid",
                Url = "datagrid/selection",
                FileName = "Selection.razor",
                Type = SampleType.None,
                  ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the selection feature in DataGrid, which allows you to select row or cell through simple mouse down or keyboard interaction.
                    </p>"
                },
                Description = new string[]{
                    @"<p>Selection provides an interactive support to highlight the row or cell that you select. Selection can be done through a simple mouse down or keyboard interaction. To enable selection, set <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~AllowSorting.html'>AllowSelection</a></code> property as true.</p>
                    <p>DataGrid supports two types of selection which can be set using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridSelectionSettings~Type.html'>Type</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridSelectionSettings.html'>GridSelectionSettings</a></code> component. They are,</p>
                    <ul>
                        <li><strong>Single</strong> - Enabled by default. Allows the user to select single row/cell at a time.</li>
                        <li><strong>Multiple</strong> - Allows the user to select more than one row/cell at a time.</li>
                    </ul>
                    <p>Also, three modes of selection are supported which can be set using <code><a target='_blank' class='code' href=' https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridSelectionSettings~Mode.html '>Mode</a></code> property. They are,</p>
                    <ul>
                        <li><strong>Row</strong> - Enabled by default. Enables the row selection in DataGrid.</li>
                        <li><strong>Cell</strong> - Enables the cell selection in DataGrid.</li>
                        <li><strong>Both</strong> - Enables both the row and cell selection in DataGrid. Clicking any cell will select the both row and cell simultaneously.</li>
                    </ul>
                    <p>To perform the multi-selection, hold <strong>CTRL</strong> key and click the desired rows/cells. To select range of rows/cells, hold <strong>SHIFT</strong> key and click the rows/cells.</p>
                    <p>While using the DataGrid in a touch environment, there is an option for multi-selection through single tap on the row and it will show a popup with the multi-selection symbol. Tap the icon to select all the records in a single tap.</p>
                    <p>More information on the selection configuration can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/selection'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Checkbox Selection",
                Category = "Selection",
                Directory = "Grid/DataGrid",
                Url = "datagrid/checkbox-selection",
                FileName = "CheckboxSelection.razor",
                Type = SampleType.None,
                 ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the selection functionality of the DataGrid using checkbox selection, To select and unselect all rows use header checkbox.
                        To select/unselect particular row, click the desired row.
                    </p>"
                },
                Description = new string[]{
                    @"<p>DataGrid multi-selection can be achieved with the help of checkbox in each row. To render checkbox in each DataGrid row, you need to define column type as <strong>CheckBox</strong> in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn~Type.html'>Type</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn.html'>GridColumn</a></code> component.</p>
                    <p>Selection can be persisted on all the operations using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridSelectionSettings~PersistSelection.html'>PersistSelection</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridSelectionSettings.html'>GridSelectionSettings</a></code> component. For persisting selection on the DataGrid, any one of the column should be defined as a primary key using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn~IsPrimaryKey.html'>IsPrimaryKey</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn.html'>GridColumn</a></code> component.</p>
                    <p>In this demo, DataGrid multi-selection is enabled with the selection persistence.</p>
                    <p>More information on the checkbox selection configuration can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/selection/#checkbox-selection'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Default Aggregate",
                Category = "Aggregates",
                Directory = "Grid/DataGrid",
                Url = "datagrid/aggregate",
                FileName = "Aggregate.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates aggregate functionality of the DataGrid. In this sample, the aggregate value for the column Freight is displayed in column footer.</p>"
                },
                Description = new string[]{
                    @"<p>The DataGrid supports aggregates which will be displayed at the footer, group footer and group caption of the DataGrid. The aggregate configurations can be provided in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridAggregates.html'>GridAggregates</a></code> component</p>
                    <p>The built-in aggregates are, </p>
                    <ul>
                    <li><strong>Sum</strong></li>    
                    <li><strong>Average</strong></li>    
                    <li><strong>Min</strong></li>    
                    <li><strong>Max</strong></li>    
                    <li><strong>Count</strong></li>    
                    <li><strong>TrueCount</strong></li>    
                    <li><strong>FalseCount</strong></li>
                    </ul>  
                    <p>In this demo, the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.AggregateColumnModel~FooterTemplate.html'>FooterTemplate</a></code> is used to display four different aggregates in the DataGrid footer. In the first aggregate row, the <strong>Sum</strong> aggregate type is used by setting it in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.AggregateColumnModel~Type.html'>Type</a></code> and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.AggregateColumnModel~Field.html'>Field</a></code> property is set as <strong><i>Freight</i></strong> which will be used to perform the aggregation. The aggregate value is accessed inside the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.AggregateColumnModel~FooterTemplate.html'>FooterTemplate</a></code> using its <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.AggregateColumnModel~Type.html'>Type</a></code> name (<strong>@SumValue.Sum</strong>) where <b>SumValue</b> is an implicit named parameter - <b>Context</b>. The aggregate value will be formatted based on its <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.AggregateColumnModel~Format.html'>Format</a></code> value(<strong><i>C2</i></strong>) before being displayed.</p>
                    <p>More information on the Aggregates can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/aggregates/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Group And Caption Aggregate",
                Category = "Aggregates",
                Directory = "Grid/DataGrid",
                Url = "datagrid/group-and-caption-aggregate",
                FileName = "GroupAndCaptionAggregate.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates Aggregate functionality of the DataGrid. In this sample, both Unit In Stock column are displayed their aggregate value in group footer.
                        Unit In Stock column displayed its aggregate value in group caption also.</p>"
                },
                Description = new string[]{
                    @"<p>The DataGrid supports aggregates which will be displayed at the footer, group footer and group caption of the DataGrid. The aggregate configurations can be provided by using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridAggregates.html'>GridAggregates</a></code> component.</p>
                    <p>The built-in aggregates are,</p>
                    <ul>
                        <li><strong>Sum</strong></li>    
                        <li><strong>Average</strong></li>    
                        <li><strong>Min</strong></li>    
                        <li><strong>Max</strong></li>    
                        <li><strong>Count</strong></li>    
                        <li><strong>TrueCount</strong></li>    
                        <li><strong>FalseCount</strong></li>
                    </ul>   
                    <p>In this demo, the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridAggregateColumn~GroupFooterTemplate.html'>GroupFooterTemplate</a></code> is used for displaying the group footer aggregation for the <strong><i>Unit In Stocks</i></strong> and <strong><i>Discontinued</i></strong> columns and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridAggregateColumn~GroupCaptionTemplate.html'>GroupCaptionTemplate</a></code> is used for displaying the group caption aggregation for the <strong><i>Unit In Stocks</i></strong> column.</p>   
                    <p>To enable group footer aggregation for <strong><i>Unit In Stocks</i></strong> column, the <strong>Sum</strong> aggregate type is used by setting it in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.AggregateColumnModel~Type.html'>Type</a></code> property and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.AggregateColumnModel~Field.html'>Field</a></code> property is set as <strong><i>UnitsInStock</i></strong> which will be used to perform the aggregation. The aggregate value is accessed inside the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridAggregateColumn~GroupFooterTemplate.html'>GroupFooterTemplate</a></code> using its <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.AggregateColumnModel~Type.html'>Type</a></code> name (<strong>@Unit.Sum</strong>) where <b>Unit</b> is an implicit named parameter - <b>Context</b>.</p>
                    <p>To enable group caption aggregation for <strong><i>Unit In Stocks</i></strong> column, the <strong>Max</strong> aggregate type is used by setting it in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.AggregateColumnModel~Type.html'>Type</a></code> property and the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.AggregateColumnModel~Field.html'>Field</a></code> property is set as <strong><i>UnitsInStock</i></strong> which will be used to perform the aggregation. The aggregate value is accessed inside the<code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridAggregateColumn~GroupCaptionTemplate.html'>GroupCaptionTemplate</a></code> using its <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.AggregateColumnModel~Type.html'>Type</a></code> name (<strong>@Unit.Max</strong>) where <b>Unit</b> is an implicit named parameter - <b>Context</b>.</p>
                    <p>More information on the group caption aggregate can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/aggregates/#group-and-caption-aggregate'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Default Exporting",
                Category = "Exporting",
                Directory = "Grid/DataGrid",
                Url = "datagrid/exporting",
                FileName = "Exporting.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the client-side exporting of the DataGrid, which allows you to export its data to the Excel, Pdf and CSV formats. Use the toolbar buttons to export DataGrid data to desired format.</p>"
                },
                Description = new string[]{
                    @"<p>DataGrid supports client-side exporting which allows you to export its data to Excel, Pdf and CSV formats.</p>
                    <p>In this demo, we have defined actions for the exporting toolbar items, in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~ToolbarClick.html'>ToolbarClick</a></code> event to export the DataGrid data using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.EjsGrid%601~ExcelExport.html'>ExcelExport</a></code>, <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.EjsGrid%601~PdfExport.html'>PdfExport</a></code> and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.EjsGrid%601~CsvExport.html'>CsvExport</a></code> methods.</p>
                    <p>More information about Exporting can be found in the <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/excel-exporting/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Print",
                Category = "Exporting",
                Directory = "Grid/DataGrid",
                Url = "datagrid/print",
                FileName = "Print.razor",
                Type = SampleType.None,
                 ActionDescription = new string[] {
                    @"<p>This sample demonstrates the different options to print the hierarchy DataGrid.</p>"
                },
                Description = new string[]{
                    @"<p>The DataGrid can be printed using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.EjsGrid%601~Print.html'>Print</a></code> method. While printing the pager and scrollbar will be removed if they are enabled in DataGrid. By default, all pages will be printed. We can print current page alone by setting the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~PrintMode.html'>PrintMode</a></code> property value as <strong>CurrentPage</strong>. The childDataGrid allows us to print theDataGrid with following options,</p>
                    <ul>
                        <li><strong>Expanded</strong> - Prints the master DataGrid with expanded child DataGrids.</li>
                        <li><strong>All</strong> - Prints the master DataGrid with all the child DataGrids.</li>
                        <li><strong>None</strong> - Prints the master DataGrid alone.</li>
                    </ul>
                    <p>We can change the child DataGrid's print option by using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~HierarchyPrintMode.html'>HierarchyPrintMode</a></code> property.</p>
                    <p>More information on the print feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/print/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Grouping",
                Category = "DataGrid",
                Directory = "Grid/DataGrid",
                Url = "datagrid/grouping",
                FileName = "Grouping.razor",
                Type = SampleType.None,                
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates grouping feature of the DataGrid component. In this sample, the DataGrid data is grouped against
                        Customer Name column. To group any other column simply drag the column header and drop on the group drop area.
                    </p>"
                },
                Description = new string[]{
                    @"<p>The DataGrid control has options to group the records based on the required column. When grouping is applied, grouped records are organized into a hierarchical structure to facilitate easier expansion and collapsing of the records. To enable grouping, set <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~AllowGrouping.html'>AllowGrouping</a></code> property as true.</p>
                    <p>Columns can be grouped by simply dragging the column header and dropping it on the group drop area.</p>
                    <p>In this demo, DataGrid is rendered with grouping enabled and initial grouped by <b>CustomerName</b> column.</p>
                    <p>More information on the group data binding can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/grouping/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Column Template",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/column-template",
                FileName = "ColumnTemplate.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This demo for Blazor DataGrid control shows the usage of template columns in DataGrid.</p>"
                },
                Description = new string[]{
                    @"<p>The DataGrid provides a way to use custom layout to display custom element value or content for each column using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn~Template.html'>Template</a></code> property. You can use the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn~Template.html'>Template component</a></code> of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn.html'>GridColumn</a></code> component to specify the custom content. Inside the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn~Template.html'>Template</a></code>, you can access the data using the implicit named parameter <strong>Context</strong>.</p>
                    <p>In this demo, using column template, we have displayed <strong>Employee Image</strong> column with Employee Photo.</p>
                    <p>More information on the Templates feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/templates/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Row Template",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "datagrid/row-template",
                FileName = "GridRowTemplate.razor",
                Type = SampleType.None,
                 ActionDescription = new string[] {
                    @"<p>This sample demonstrates the DataGrid component with the row template feature. In this sample, we have rendered each DataGrid
                        row using the template.</p>"
                },
                Description = new string[]{
                    @"<p>The RowTemplate has option to customize the look and behavior of the DataGrid rows. The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~RowTemplate.html'>RowTemplate</a></code> should be wrapped around the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridTemplates.html'>GridTemplates</a></code> component. The RowTemplate content must be <strong>TD</strong> elements and the number of <strong>TD</strong> elements should match the number of DataGrid columns.</p>
                    <p>In this demo, we have presented Employee Information with Employee Photo in the first column and Employee details like Name, Address etc. in the second column.</p>
                    <p>More information on the Templates feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/templates/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Detail Template",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "datagrid/detail-template",
                FileName = "GridDetailTemplate.razor",
                Type = SampleType.Updated,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the DataGrid component with the detail template feature. Click the expand button
                        in each DataGrid row to show the detailed information about a row.</p>"
                },
                Description = new string[]{
                    @"<p>The detail template provides additional information about a particular row on expanding or collapsing the detail content. The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~DetailTemplate.html'>DetailTemplate</a></code> should be wrapped around the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridTemplates.html'>GridTemplates</a></code> component with the required content. This expand row used to visualize the hierarchy statistical data.</p>
                    <p>In this demo, we have presented Employee Information with image in the detail row.</p>
                    <p>More information about the Details Template can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/row/#detail-template'>documentation section</a></p>"
                }
            },
            new Sample
            {
                Name = "Header Template",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/header-template",
                FileName = "GridHeaderTemplate.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Blazor DataGrid header template feature. In this sample, we have shown custom icons in the column headers..</p>"
                },
                Description = new string[]{
                    @"<p>The Header Template has options to display custom element value or content in the header area. You can use the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn~HeaderTemplate.html'>HeaderTemplate</a></code> of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridColumn.html'>GridColumn</a></code> component to specify the custom content to be displayed in the header section.</p>
                    <p>In this demo, we have presented Employee Information with image using the header template.</p>
                    <p>More information on the header template can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/columns/#header-template'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Clipboard",
                Category = "DataGrid",
                Directory = "Grid/DataGrid",
                Url = "datagrid/clipboard",
                FileName = "Clipboard.razor",
                Type = SampleType.None,                
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates copy to clipboard functionality of the DataGrid component. Select rows and click Copy button from
                        toolbar to copy content. To copy with header click Copy with header button from toolbar.
                    </p>"
                },
                Description = new string[]{
                    @"<p>Selected row or cell data in the DataGrid can be copied into the clipboard using the Keyboard shortcuts and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.EjsGrid%601~Copy.html'>Copy</a></code> method.</p>
                    <p>In this demo, selected rows data can be copied into the clipboard using the below Keyboard shortcuts or toolbar interactions.</p>
                    <ul>
                        <li><strong>Ctrl + C</strong> - Selected rows or cells data without header.</li>
                        <li><strong>Ctrl + Shift + H</strong> - Selected rows or cells data with header.</li>
                    </ul>
                    <p>More information on the clipboard feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/clipboard/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Row Height",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "datagrid/row-height",
                FileName = "RowHeight.razor",
                Type = SampleType.None,
                 ActionDescription = new string[] {
                    @"<p>This sample demonstrates the row height feature of the DataGrid. In this demo, the <b>RowHeight</b> for all the DataGrid rows can be
                changed as <b>20px</b>, <b>40px</b> and <b>60px</b> on ToolBar button click.</p>"
                },
                Description = new string[]{
                    @"<p>The row height for the DataGrid rows can be set using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~RowHeight.html'>RowHeight</a></code> property.</p>
                    <p>More information on the row height feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/row/#row-height'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Frozen Rows and Columns",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/frozen-rows",
                FileName = "FrozenRowsAndColumns.razor",
                Type = SampleType.None,
                 ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Frozen Rows and Columns feature of the DataGrid. Scroll the movable content vertically/horizontally to view the frozen rows/columns
                    with the content.</p>"
                },
                Description = new string[]{
                    @"<p>DataGrid provides support to freeze certain rows/columns from being scrolled thus allowing only the remaining content scrollable. This can be achieved by using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~FrozenRows.html'>FrozenRows</a></code> and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.Blazor~Syncfusion.Blazor.Grids.GridModel%601~FrozenColumns.html'>FrozenColumns</a></code> property.</p>
                    <p>In this demo sample, the first column and two rows are set to frozen by using these properties.</p>
                    <p>More information on the Frozen column feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/scrolling/#frozen-rows-and-columns'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Show or Hide Column",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "datagrid/show-or-hide-column",
                FileName = "ShoworHideColumn.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates dynamic show hide columns feature of DataGrid.
            Click the switch to toggle visibility for columns.
                    .</p>"
                },
                Description = new string[]{
                    @"<p>The DataGrid column can be showed/hidden dynamically using <strong>ShowColumns </strong> and <strong>HideColumns</strong> method of the DataGrid.</p>
                <p>In this demo, the columns can be showed and hidden by clicking the
                    Switch buttons to toggle visibility. And the column`s visibility is toggled based on the
                    <strong>Columns->HeaderText</strong> value.</p>
                <br/>
                <p>The <strong>Columns->Visible</strong> property specifies the visibility of a column. To hide a column at the initial rendering, set the <strong>Columns->Visible
                </strong> property to false.</p>
                <p>More information on the Show/Hide column can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/columns/#showhide-columns-by-external-button'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Observable Collection",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "datagrid/observable-binding",
                FileName="ObservableBinding.razor",
				Type = SampleType.None,                
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the usage of Observable data binding in DataGrid component.
                    </p>"
                },
                Description = new string[]{
                    @"<p> Using Observable Collections Objects can be added, removed or be updated with an automatic notification of actions. 
                The UI is automatically updated, when an object is added to or removed from an observable collection. To refresh UI for single property update, the setter of the corresponding property must be configured as shown in the sample.</p>
                    <p>More information on the observable data binding can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/data-binding/#observable-collection'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Hierarchy Grid",
                Category = "DataGrid",
                Directory = "Grid/DataGrid",
                Url = "datagrid/hierarchy-grid",
                FileName = "HierarchyGrid.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the usage of DataGrid to show parent child relation data in a hierarchy structure using details template feature.</p>"
                },
                Description = new string[]{
                    @"<p>The Hierarchy DataGrid is used to display table data in hierarchical structure which can show or hide by clicking on expand or collapse button.
                     Hierarchy DataGrid feature can be achieved by defining <strong>Details Template</strong> in a DataGrid.</p>

                     <p>In this demo, three level hierarchy is demonstrated with hierarchical structure <strong>Employee -&gt; Orders -&gt; Customers</strong>.</p>
                
                    <p>More information about the Details Template can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/grid/row/#detail-template'>documentation section</a></p>"
                }
            },
            new Sample
            {
                Name = "Master Detail",
                Category = "DataGrid",
                Directory = "Grid/DataGrid",
                Url = "datagrid/master-details",
                FileName = "MasterDetails.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the usage of DataGrid to visualize details of record in another DataGrid in master and detail manner. By simply clicking the master DataGrid row, the detail DataGrid will be populated with the corresponding data.</p>"
                },
                Description = new string[]{
                    @"<p>Master-Detail DataGrid is a use case scenario, in which the details of a Master DataGrid record, is viewed in a separate DataGrid(Detail DataGrid) by clicking the particular row.</p>
                    <p>The steps to achieve this scenario is as follows,</p>
                    <ul>
                        <li>Get the selected record of Master DataGrid in the<code>RowSelected</code>event.</li>
                        <li>Filter the data based on the selected record and bind the result to the Detail DataGrid`s <code>dataSource</code>property.</li>
                    </ul>
                   <p>In this demo, simply click the row in master DataGrid, which shows the details in another(Detail) DataGrid.</p>"
                }
            },
        };
    }
}
