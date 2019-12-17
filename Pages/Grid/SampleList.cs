using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> DataGrid { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Data Grid",
                Directory = "Grid/DataGrid",
                Url = "Grid/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Default DefaultFunctionalities . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows the default rendering of the grid control with minimum configuration.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default rendering of the Grid with minimum configuration.</p>"
                },
                Description = new string[]{
                    @"<p>The Grid is used to display and manipulate tabular data with configuration options to control the way the data is presented and manipulated. It can pull the data from data sources, like IEnumerable, OData web services, or <code>DataManager</code> and bind the data fields to columns. It also displays a column header to identify the field with support for grouped records.</p>
                    <p>In this demo, the Grid is populated with its minimum default settings.</p>"
                }
            },
            new Sample
            {
                Name = "List Binding",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "Grid/LocalData",
                FileName = "LocalData.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . List Binding . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component demonstrates the way of binding a local data source to grid.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the way of data binding Grid component with List object(list binding data source).</p>"
                },
                Description = new string[]{
                    @"<p>The Grid supports data binding. The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~DataSource.html'>DataSource</a></code>  property can be assigned either as list of objects or with instance of <code>DataManager</code>.</p>
                    <p>In this demo, the list of objects is assigned as the data source to the Grid.</p>"
                }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "Grid/RemoteData",
                FileName = "RemoteData.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Remote Data . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows the way of binding remote service to grid through DataManager.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the way of data binding Grid component with remote service. The Grid data source is bound to
                    remote data using DataManager.</p>"
                },
                Description = new string[]{
                    @"<p>The Grid supports data binding. The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~DataSource.html'>DataSource</a></code> property can be assigned with the instance of <code>DataManager</code> to bind remote data.</p>
                    <p>The DataManager, which will act as an interface between the service endpoint and the Grid, will require the below minimal information to interact with service endpoint properly,</p>
                    <ul>
                        <li><code>DataManager.Url</code> - Defines the service endpoint to fetch the data</li>
                        <li><code>DataManager.Adaptor</code> - Defines the adaptor option. By default, <code>ODataAdaptor</code> is used for remote binding.</li>
                    </ul>
                    <p>Adaptor is responsible for processing the response and request from/to the service endpoint. The <code>@syncfusion/ej2-data</code> package provides some predefined adaptors which are designed to interact with particular service endpoints. The predefined adaptors are,</p>
                    <ul>
                        <li><code>UrlAdaptor</code> - Use this to interact with any remote service. This is the base adaptor for all remote based adaptors.</li>
                        <li><code>ODataAdaptor</code> - Use this to interact with OData endpoints.</li>
                        <li><code>ODataV4Adaptor</code> - Use this to interact with OData V4 endpoints.</li>
                        <li><code>WebApiAdaptor</code> - Use this to interact with Web API created under OData standards.</li>
                        <li><code>WebMethodAdaptor</code> - Use this to interact with web methods.</li>
                    </ul>
                    <p>In this demo, remote data is bound by assigning service data as an instance of <code>DataManager</code> to the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~DataSource.html'>DataSource</a></code> property.</p>
                    <p>More information on the data binding can be found in this <a target='_blank' href='https://ej2.syncfusion.com/blazor/documentation/grid/data-binding/#remote-data'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Custom Binding",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "Grid/CustomBinding",
                FileName = "CustomBinding.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Custom Binding . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component demonstrates how to bind the data with custom service/custom methods/custom component.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the usage of custom data binding in Grid component.
                    </p>"
                },
                Description = new string[]{
                    @"<p>
                        The custom data binding can be performed in the Grid component by providing the custom adaptor class
                        and overriding the <code>Read or ReadAsync</code> method of the DataAdaptor abstract class.
                        The CRUD operations for the custom bounded data in the Grid component can be
                        implemented by overriding the following CRUD methods of the DataAdaptor abstract class,
                        <br>
                    </p>
                    <ul>
                        <li><code>Insert/InsertAsync</code> - Performs Insert operation.</li>
                        <li><code>Remove/RemoveAsync</code> - Performs Remove operation.</li>
                        <li><code>Update/UpdateAsync</code> - Performs Update operation.</li>
                        <li><code>BatchUpdate/BatchUpdateAsync</code> - Performs BatchUpdate operation.</li>
                    </ul>

                    <p>In this demo, CRUD operations for the custom bounded data is performed using the methods of DataAdaptor abstract class.
                    Similarly, you can perform Batch Update operations using <code>BatchUpdate/BatchUpdateAsync</code> methods.</p>"
                }
            },
            new Sample
            {
                Name = "Context Menu",
                Category = "Data Grid",
                Directory = "Grid/DataGrid",
                Url = "Grid/ContextMenu",
                FileName = "ContextMenu.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Context Menu . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows the usage of context menu in grid. Right click anywhere on the grid (header, content, pager) to view context menu.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the usage of context menu in Grid component. Right click anywhere on the Grid to view context
                    menu.
                    </p>"
                },
                Description = new string[]{
                    @"<p>Grid has options to show the context menu when right clicking on it. To configure the items in context menu, you should define either default or custom item in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~ContextMenuItems.html'>ContextMenuItems</a></code> property. Each item will be shown based on its target. The default context menu items are,</p>
                    <ul>
                        <li><code>Edit</code> - Edit the current record.</li>
                        <li><code>Delete</code> - Delete the current record.</li>
                        <li><code>Save</code> - Save the edited record.</li>
                        <li><code>Cancel</code> - Cancel the edited state.</li>
                        <li><code>Copy</code> - Copy the selected records.</li>
                        <li><code>PdfExport</code> - Export the grid as Pdf format.</li>
                        <li><code>ExcelExport</code> - Export the grid as Excel format.</li>
                        <li><code>CsvExport</code> - Export the grid as CSV format.</li>
                        <li><code>SortAscending</code> - Sort the current column in ascending order.</li>
                        <li><code>SortDescending</code> - Sort the current column in descending order.</li>
                        <li><code>FirstPage</code> - Go to the first page.</li>
                        <li><code>PrevPage</code> - Go to the previous page.</li>
                        <li><code>LastPage</code> - Go to the last page.</li>
                        <li><code>NextPage</code> - Go to the next page.</li>
                    </ul>
                    <p>While using the Grid in a touch environment, touch and hold the Grid row cell to show the context menu.</p>
                    <p>In this demo, Context Menu feature is enabled by defining the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~ContextMenuItems.html'>ContextMenuItems</a></code> property with the default items.</p>"
                }
            },
            new Sample
            {
                Name = "Default Scrolling",
                Category = "Scrolling",
                Directory = "Grid/DataGrid",
                Url = "Grid/DefaultScrolling",
                FileName = "DefaultScrolling.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Default Scrolling . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows the usage of the horizontal and vertical scrollbar to view the grid content which exceeds the grid area.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Grid component with the horizontal and vertical scrollbars to view the exceeded grid content.</p>"
                },
                Description = new string[]{
                    @"<p>The Grid will show scrollbar when the content exceeds the element width or height. The vertical and horizontal scrollbar will be displayed based on the following criteria,</p>
                    <ul>
                        <li>The vertical scrollbar appears when the total height of rows present in Grid exceeds its element height.</li>
                        <li>The horizontal scrollbar appears when the total width of columns present in Grid exceeds its element width.</li>
                    </ul>
                    <p>The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~Height.html'>Height </a></code> and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~Width.html'>Width </a></code> properties are used to set the Grid height and width respectively. The value of these properties can be numeric value, pixel(<code>px</code>) or percentage (<code>%</code>).</p>
                    <p>In this demo, the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~Height.html'>Height </a></code> and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~Width.html'>Width </a></code> properties of the Grid are set to <strong><em>410</em></strong> and <strong><em>auto</em></strong> respectively. Now, the Grid will render with vertical scrollbar when the total height of rows exceeds its element height and horizontal scrollbar will appear when the total column width exceeds the element width.</p>"
                }
            },
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Scrolling",
                Directory = "Grid/DataGrid",
                Url = "Grid/VirtualScrolling",
                FileName = "VirtualScrolling.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Virtual Scrolling . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component to view a large data without performance degradation by rendering only the required rows and columns.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Grid component with the horizontal and vertical scrollbars to view the exceeded grid content.</p>"
                },
                Description = new string[]{
                    @"<p>The Grid UI virtualization allows it to render only rows and columns visible within the view-port without buffering the entire datasource. Grid supports both row and column virtualization. To enable row virtualization, set <code><a target='_blank' class='code' href= 'https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~EnableVirtualization.html'>EnableVirtualization</a></code> property as true. For column virtualization, set <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~EnableColumnVirtualization.html'>EnableColumnVirtualization</a></code> property as true.</p>
                    <p>The height property must be defined when enabling <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~EnableVirtualization.html'>EnableVirtualization</a></code> property.</p>
                    <p>In this demo, Grid is rendered with row and column virtualization. Grid is binded with 10000 rows and 20 columns</p>"
                }
            },
            // new Sample
            // {
            //     Name = "Grid Lines",
            //     Category = "Data Grid",
            //     Directory = "Grid/DataGrid",
            //     Url = "Grid/GridLines",
            //     FileName = "GridLines.razor",
            //     Type = SampleType.New,
            //     TitleTag = "DataGrid . Grid Lines . Syncfusion Blazor Components",
            //     MetaDescription = "This demo for Syncfusion Blazor DataGrid component demonstrates the visibility of the grid lines that separate the rows and columns.",
            //     ActionDescription = new string[] {
            //         @"<p>This sample demonstrates visibility of the grid lines that separates the rows and columns.</p>"
            //     },
            //     Description = new string[]{
            //         @"<p>The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~GridLines.html'>GridLines</a></code> property is used to control the line visibility that separates the rows and columns. The following grid lines can be displayed in the grid,</p>
            //         <ul>
            //             <li><code>Default</code> - Shows the Horizontal line.</li>
            //             <li><code>None</code> - Shows no line.</li>
            //             <li><code>Both</code> - Shows both Horizontal and Vertical lines.</li>
            //             <li><code>Horizontal</code> - Shows the Horizontal line.</li>
            //             <li><code>Vertical</code> - Shows the Vertical line.</li>
            //         </ul>
            //         <p> In this demo, we have set the GridLines value as Both.</p>
            //         <p>More information on the GridLines configuration can be found in this<a target='_blank' href='https://ej2.syncfusion.com/blazor/documentation/grid/cell/#grid-lines'>documentation section</a>.</p>"
            //     }
            // },
            new Sample
            {
                Name = "AutoWrap Column Cells",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/AutoWrap",
                FileName = "AutoWrap.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . AutoWrap Column Cells . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows how the grid cell content is autowrapped to show large cell content.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Grid component with the auto wrap column cell. In this sample, you can see that the <strong>main fields of invention</strong> column cell content exceeded the available width hence it has been wrapped into multiple lines.
                    </p>"
                },
                Description = new string[]{
                    @"<p>Auto wrap cell content can be enabled using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.EjsGrid%601~AllowTextWrap.html'>AllowTextWrap</a></code> property of the Grid. Enabling this property will wrap the cell text in multiple lines. When the cell content exceeds the cell width this feature is useful to view the content.</p>
                    <p>Enabling this property will wrap both the content cell and header cell text.</p>
                    <p>In this demo, the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.EjsGrid%601~AllowTextWrap.html'>AllowTextWrap</a></code> property is enabled which can be seen in the <strong>Main fields of invention</strong> column whose content is wrapped into multiple lines as it exceeds the cell width.</p>"
                }
            },
            new Sample
            {
                Name = "Stacked Header",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/StackedHeader",
                FileName = "GridStackedHeader.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Stacked Header . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows the stacked header and resize feature. In this sample, we have shown multiple level of column headers.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Grid component with the stacked header and resize feature. In this sample, we have shown multiple level of column headers.
                    </p>"
                },
                Description = new string[]{
                    @"<p>The Grid columns can be stacked/grouped in order to show multiple levels of column headers. It can be done by using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn~Columns.html'>Columns </a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn.html'>GridColumn</a></code> component.</p>
                    <p>The Grid columns can be resized by clicking at the right end of the column header and dragging it. To enable column resize behavior, set <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~AllowResizing.html'>AllowResizing</a></code> property as true. You can also prevent the resize of particular columns by setting <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn~AllowResizing.html'>AllowResizing</a></code> property as false in the column definition.</p>
                    <p>In this demo, the columns <strong>OrderDate, Freight</strong> are grouped under <strong>Order Details</strong> and the columns <strong>ShippedDate, ShipCountry</strong> are grouped under <strong>Shipped Details</strong>.</p>"
                }
            },
            new Sample
            {
                Name = "Column Reorder",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/Reorder",
                FileName = "Reorder.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Column Reorder . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component explains the way of reordering the columns using column name and index.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates reordering of the Grid columns.You can reorder columns by simply drag and drop in the desired column position.
                    </p>"
                },
                Description = new string[]{
                    @"<p>Reordering can be enabled by setting <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~AllowReordering.html'>AllowReordering</a></code> property as true. Reordering can be done by dragging and dropping the column header from one index to another index within the Grid.</p>
                    <p>The location where the column will be placed is indicated by two arrow symbols.</p>
                    <p>In this demo, you can either reorder columns by drag and drop or by selecting column name and column index to reorder from the dropdown.</p>"
                }
            },
            new Sample
            {
                Name = "Column Chooser",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/ColumnChooser",
                FileName = "ColumnChooser.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Column Chooser . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows how the column chooser feature can be used to show or hide columns dynamically.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Grid column chooser feature. Click the column chooser
                    icon in the toolbar to open column chooser and you can select columns to hide/show from the checkbox list. 
                    </p>"
                },
                Description = new string[]{
                    @"<p>The Grid columns can be shown/hidden dynamically by using column chooser functionality. To enable column chooser, set <code><a target='_blank' class='code' href=' https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~ShowColumnChooser.html l'>ShowColumnChooser</a></code> property as true. You can also prevent the display of a column in column chooser by setting <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn~ShowInColumnChooser.html'>ShowInColumnChooser</a></code> as false in the columns definition.</p>
                    <p>In this demo, when the user clicks column chooser icon from the toolbar, the column chooser menu will open. Here the user can show or hide the columns by changing the state of the checkbox.</p>"
                }
            },
            new Sample
            {
                Name = "Column Resize",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/ColumnResize",
                FileName = "Columnresize.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Column Resize . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows how the column resizing feature can be used to change width dynamically.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Grid column resizing feature. Click and drag at the right corner of each column header to
                    resize the column.</p>"
                },
                Description = new string[]{
                    @"<p>The Grid columns can be resized by clicking the right corner of column header and dragging it. To enable column resize behavior, set <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~AllowResizing.html'>AllowResizing</a></code> property as true. You can also prevent the resize of the particular column by setting <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn~AllowResizing.html'>AllowResizing</a></code> property as false in the columns definition. And, by double clicking at the right corner of column header, the respective column width will get auto adjusted by the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.EjsGrid%601~AutoFitColumns.html'>AutoFitColumns</a></code> method.</p>
                    <p>In this demo, AllowResizing feature has been enabled by setting the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~AllowResizing.html'>AllowResizing</a></code> property to true and <b>Order ID</b> column can be resized between the range of <code>MinWidth (120px)</code> and <code>MaxWidth (300px).</code> Also, column resizing has been disabled for the <b>Shipped Date</b> column.</p>"
                }
            },
            new Sample
            {
                Name = "Column Menu",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/ColumnMenu",
                FileName = "Columnmenu.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Column Menu . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows the usage of the various column functionalities of the column menu feature.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default functionalities of the ColumnMenu. Click on multiple icon of each column to open the column menu.</p>"
                },
                Description = new string[]{
                    @"<p>Grid has option to show column menu on clicking the multiple icon in each column. The column menu has integrated options which allows the user to interact with features like sorting, grouping, filtering, column chooser and autofit. The column menu can be enabled by setting the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~ShowColumnMenu.html'>ShowColumnMenu</a></code> property value as <b>true</b>. The default items in the column menu are, </p>
                    <ul>
                        <li><code>SortAscending</code> - Sort the current column in ascending order.</li>
                        <li><code>SortDescending</code> - Sort the current column in descending order.</li>
                        <li><code>Group</code> - Group the current column.</li>
                        <li><code>Ungroup</code> - Ungroup the current column.</li>
                        <li><code>AutoFit</code> - Auto fit current column.</li>
                        <li><code>AutoFitAll</code> - Auto fit all columns.</li>
                        <li><code>ColumnChooser</code> - Choose the column visibility.</li>
                        <li><code>Filter</code> - Show the filter option as given in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridFilterSettings~Type.html'>Type</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridFilterSettings.html'>GridFilterSettings</a></code> component.</li>
                    </ul>
                    <p>In this demo, column menu functionality is enabled by defining <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~ShowColumnMenu.html'>ShowColumnMenu</a></code> as <b>true</b> with sorting, grouping, filtering, column chooser and autofit options.</p>"
                }
            },
            new Sample
            {
                Name = "Row Hover",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "Grid/RowHover",
                FileName = "RowHover.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Row Hover . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows the Grid with the row hover feature. Move the mouse over the Grid rows to see the hover effect.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Grid component with the row hover feature. Move the mouse over the Grid rows to see the
                    hover effect.</p>"
                },
                Description = new string[]{
                    @"<p>Row Hover feature enables us to identify the current row by highlighting them on hovering the mouse over them. This can be enabled by setting the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~EnableHover.html'>EnableHover</a></code> property as true.</p>
                    <p>In this demo, you can move the mouse over Grid rows to see the hover effect.</p>"
                }
            },
             new Sample
             {
                 Name = "Row Drag And Drop",
                 Category = "Rows",
                 Directory = "Grid/DataGrid",
                 Url = "Grid/RowDragAndDrop",
                 FileName = "RowDragAndDrop.razor",
                 Type = SampleType.New,
                 TitleTag = "DataGrid . Row Drag And Drop . Syncfusion Blazor Components",
                 MetaDescription = "This demo for Syncfusion Blazor DataGrid component demonstrates how the rows can be dragged between grids using the row drag-and-drop feature.",
                 ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Grid component with the row drag and drop feature. Drag and drop rows between Grids
                        to move rows.</p>"
                },
                Description = new string[]{
                    @"<p>Grid rows can be dragged and dropped to another Grid by enabling <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~AllowRowDragAndDrop.html'>AllowRowDragAndDrop</a></code> property. The target control on which the Grid rows has to be dropped can be set by using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridRowDropSettings~TargetID.html'>TargetID</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridRowDropSettings.html'>GridRowDropSettings</a></code> component.</p>
                    <p>The Selection feature should be enabled to select the rows.  Multiple rows can be selected by simply clicking and dragging them inside the Grid.</p>
                    <p>In this demo, the Row drag and drop feature is enabled in both the Grids. To drag and drop rows between Grids select rows, drag and drop them to the adjacent Grid.</p>"
                }
             },
            // new Sample
            // {
            //    Name = "Row Drag And Drop Within Grid",
            //    Category = "Rows",
            //    Directory = "Grid/DataGrid",
            //    Url = "Grid/DragAndDropWithinGrid",
            //    FileName = "DragAndDropWithinGrid.razor",
            //    Type = SampleType.New,
            //    ActionDescription = new string[] {
            //         @"<p>This sample demonstrates the Grid component with the row drag and drop feature within same grid. You can rearrange the grid rows by using drag icon in left side of grid column.Here you can drag and drop the grid rows between the decided rows.</p>"
            //     },
            //     Description = new string[]{
            //         @"<p>Row drag and drop can be enabled by setting <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~AllowRowDragAndDrop.html'>AllowRowDragAndDrop</a></code> property as true.</p>"
            //     }
            // },
            new Sample
            {
                Name = "Inline Editing",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "Grid/InlineEditing",
                FileName = "InlineEditing.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Inline Editing . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component demonstrates the inline editing mode to perform CRUD operations in grid.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates CRUD operations in Grid. You can perform CRUD operations as follows,</p>
                    <ul>
                        <li><code>Add</code> -  To add new record, click Add toolbar button </li>
                        <li><code>Edit</code> - To edit record, double click a row or click toolbar Edit button after selected a row </li>
                        <li><code>Delete</code> - To delete record, click toolbar Delete button after selected a row </li>
                        <li><code>Update</code>,<code>Cancel</code> - You can save or discard changes by click toolbar Update and Cancel button respectively</li>
                    </ul>
                    <p>By default, a new row will be added at the top of the grid. You can change it by setting <code>editSettings.newRowPosition</code> as <code>Bottom</code></p>"
                },
                Description = new string[]{
                    @"<p>The Grid supports CRUD operations. The CRUD operations can be configured in Grid using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component. It also has different modes to manipulate the datasource.</p>
                    <p>The available modes are,</p>
                    <ul>
                        <li><code>Inline</code></li>
                        <li><code>Dialog</code></li>
                        <li><code>Batch</code></li>
                    </ul>
                    <p>In this demo, Inline mode is enabled for editing by defining <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridEditSettings~Mode.html'>Mode</a></code> as <code>Inline</code> in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component. You can start editing by double clicking a row or clicking on toolbar’s <code>Edit</code> button which will change the row to editing state. You can change the row values and save the edited data to the datasource.  You can use the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn~EditTemplate.html'>EditTemplate</a></code> of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn.html'>GridColumn</a></code> component to render the cell edit template.</p>
                    <p>In this demo, AutoComplete Component is rendered inside the Customer ID column using EditTemplate.</p>"
                }
            },
            new Sample
            {
                Name = "Dialog Editing",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "Grid/DialogEditing",
                FileName = "DialogEditing.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Dialog Editing . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows how to edit grid rows using the Syncfusion Blazor Dialog component.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates CRUD operations in Grid. You can perform CRUD operations as follows,</p>
                    <ul>
                        <li><code>Add</code> -  To add new record, click Add toolbar button </li>
                        <li><code>Edit</code> - To edit record, double click a row or click toolbar Edit button after selected a row </li>
                        <li><code>Delete</code> - To delete record, click toolbar Delete button after selected a row </li>
                        <li><code>Update</code>,<code>Cancel</code> - You can save or discard changes by click toolbar Update and Cancel button respectively</li>
                    </ul>."
                },
                Description = new string[]{
                    @"<p>The Grid supports CRUD operations. The CRUD operations can be configured in Grid using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component. It also has different modes to manipulate the datasource.</p>
                    <p>The available modes are,</p>
                    <ul>
                        <li><code>Inline</code></li>
                        <li><code>Dialog</code></li>
                        <li><code>Batch</code></li>
                    </ul>
                    <p>In this demo, Dialog mode is enabled for editing by defining <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridEditSettings~Mode.html'>Mode</a></code> in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component as <code>Dialog</code>. You can start editing by double clicking a row or clicking on toolbar’s <code>Edit</code> button. The currently selected row will be shown on a dialog and you can change the row values and save edited data to the datasource.</p>"
                }
            },
            new Sample
            {
                Name = "Dialog Template",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "Grid/GridDialogTemplate",
                FileName = "GridDialogTemplate.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Dialog Template . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows how to edit the grid rows using Syncfusion Blazor dialog-template.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates CRUD operations in Grid. You can perform CRUD operations as follows,</p>
            <ul>
                <li><code>Add</code> -  To add new record, click Add toolbar button </li>
                <li><code>Edit</code> - To edit record, double click a row or click toolbar Edit button after selected a row </li>
                <li><code>Delete</code> - To delete record, click toolbar Delete button after selected a row </li>
                <li><code>Update</code>,<code>Cancel</code> - You can save or discard changes by click toolbar Update and Cancel button respectively</li>
            </ul>."
                },
                Description = new string[]{
                    @"<p>The Grid supports CRUD operations. This CRUD operations can be configured in Grid using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component.</p>
                    <p>In this demo, Dialog template is enabled for editing by defining <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridEditSettings~Mode.html'>Mode</a></code> as <code>Dialog</code> in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component. You can use the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridEditSettings~Template.html'>Template</a></code> component. property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component to render the custom Dialog.</p>"
                }
            },
            new Sample
            {
                Name = "Batch Editing",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "Grid/BatchEditing",
                FileName = "BatchEditing.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Batch Editing . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows how to perform bulk changes to the data grid content using batch edit mode.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates CRUD operations in Grid. You can perform CRUD operations as follows,</p>
                    <ul>
                        <li><code>Add</code> -  To add new record, click Add toolbar button </li>
                        <li><code>Edit</code> - To edit record, double click a row or click toolbar Edit button after selected a row </li>
                        <li><code>Delete</code> - To delete record, click toolbar Delete button after selected a row </li>
                        <li><code>Update</code>,<code>Cancel</code> - You can save or discard changes by click toolbar Update and Cancel button respectively</li>
                    </ul>
                    <p>By default, a new row will be added at the top of the grid. You can change it by setting <code>editSettings.newRowPosition</code> as <code>Bottom</code></p>"
                },
                Description = new string[]{
                    @"<p>The Grid supports CRUD operations. The CRUD operations can be configured in Grid using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component. It also has different modes to manipulate the datasource.</p>
                    <p>The available modes are,</p>
                    <ul>
                        <li><code>Inline</code></li>
                        <li><code>Dialog</code></li>
                        <li><code>Batch</code></li>
                    </ul>
                    <p>In this demo, Batch mode is enabled for editing by defining <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridEditSettings~Mode.html'>Mode</a></code> in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridEditSettings.html'>GridEditSettings</a></code> component as <code>Batch</code>. You can start editing by double clicking a cell and change the cell value. The edited cell will be highlighted while navigating to a new cell, so that you know which cells had been edited. You can then bulk save the edited data to the datasource by click on the toolbar's <code>update</code> button.</p>"
                }
            },
            new Sample
            {
                Name = "Command Column",
                Category = "Editing",
                Directory = "Grid/DataGrid",
                Url = "Grid/CommandColumn",
                FileName = "CommandColumn.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Command Column . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows how to edit and delete records using a command column.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates CRUD operations in Grid using command column. You can perform CRUD operations as follows,</p>
                    <ul>
                        <li><code>Edit</code> - To edit record, double click a row or click Edit button from command column after selected a row </li>
                        <li><code>Delete</code> - To delete record, click Delete button from command column after selected a row </li>
                        <li><code>Update</code>,<code>Cancel</code> - You can save or discard changes by click Update and Cancel button from command column respectively</li>
                    </ul>"
                },
                Description = new string[]{
                    @"<p>The Grid provides an option to render CRUD action buttons in a column by using the CommandColumn feature. The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn~Commands.html'>Commands</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn.html'>GridColumn</a></code> component accepts array of <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.CommandModel.html'>CommandModel</a></code> object. The predefined command button can be defined by using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.CommandModel~Type.html'>Type</a></code> property of the CommandModel.</p>
                    <p>The built-in command buttons are,</p>
                    <ul>
                        <li><code>Edit</code></li>
                        <li><code>Delete</code></li>
                        <li><code>Cancel</code></li>
                        <li><code>Save</code></li>
                    </ul>"
                }
            },
            new Sample
            {
                Name = "Multi Sorting",
                Category = "Data Grid",
                Directory = "Grid/DataGrid",
                Url = "Grid/Sorting",
                FileName = "Sorting.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Multi Sorting . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows the grid multisorting feature. Using this feature, grid rows can be sorted by two or more columns.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the Grid multi sorting feature. To sort two or more columns, hold the CTRL key and click the column header.
                    </p>"
                },
                Description = new string[]{
                    @"<p>Sorting feature enables us to order the data in a particular direction. It can be enabled by setting the <code><a target='_blank' class='code' href=' https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridSelectionSettings~Mode.html '>AllowSorting</a></code> property as true.</p>
                    <p>To sort a Grid column simply click the column header. The icons <span class=""e-icons e-icon-ascending""></span>(ascending) and <span class=""e-icons e-icon-descending""></span>(descending) specifies the sort direction of a column.</p>
                    <p>By default, multi-sorting is enabled in Grid, to sort multiple columns hold the <strong> CTRL</strong> key and click the column header. To clear sort for a column, hold the <strong> SHIFT</strong> key and click the column header.</p>
                    <p>While using Grid in a touch device, you have an option for multi sorting in single tap on the grid header. By tapping on the grid header, it will show the toggle button in small popup with sort icon. Now tap the button to enable the multi-sorting in a single tap.</p>
                    <p>In this demo, simply click the column header to sort them.</p>"
                }
            },
            new Sample
            {
                Name = "Default Filtering",
                Category = "Filtering",
                Directory = "Grid/DataGrid",
                Url = "Grid/Filtering",
                FileName = "Filtering.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Default Filtering . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component demonstrates how default Filtering feature works.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the Grid Default Filtering feature. In this sample, type the value in the filterbar and press enter
                        to filter particular column.
                    </p>"
                },
                Description = new string[]{
                    @"<p>The filtering feature enables the user to view reduced amount of records based on the filter criteria. It can be enabled by setting <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~AllowFiltering.html'>AllowFiltering</a></code> property as true.</p>
                    <p>Grid supports the following filter types,</p>
                    <ul>
                        <li><code>FilterBar</code></li>
                        <li><code>Menu</code></li>
                        <li><code>CheckBox</code></li>
                        <li><code>Excel</code></li>
                    </ul>
                    <p>You can change the filter type by using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridFilterSettings~Type.html'>Type</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridFilterSettings.html'>GridFilterSettings</a></code> component.</p>
                    <p>In this demo, filter menu is enabled by default, you can switch to other filter types by using the dropdown.</p>"
                }
            },
            new Sample
            {
                Name = "Menu Filter",
                Category = "Filtering",
                Directory = "Grid/DataGrid",
                Url = "Grid/FilterMenu",
                FileName = "FilterMenu.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Menu Filtering. Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component explains the way of filtering rows using a menu, check box, and Excel filter UI.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the way of filtering Grid columns using menu, checkbox and excel filter UI. In this sample, click the filtering
                    icon from column header to show filter UI for a particular column. You can change the filter type from the properties
                    panel.
                    </p>"
                },
                Description = new string[]{
                    @"<p>The filtering feature enables the user to view the reduced amount of records based on filter criteria. It can be enabled by setting <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~AllowFiltering.html'>AllowFiltering</a></code> property as true. A filter bar row will be rendered next to header which allows the users to filter data by entering text within its cells.</p>
                    <p>Filterbar uses two modes which specifies how to start filtering. They are,</p>
                    <ul>
                        <li><code>OnEnter</code> - Enabled by default, filter will be initiated after pressing <code>Enter</code> key.</li>
                        <li><code>Immediate</code> - Filter will start after user stops typing. This uses a time delay of <i>1500ms</i> to initiate the filter after user has stopped typing. It can be overridden using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridFilterSettings~ImmediateModeDelay.html'>ImmediateModeDelay</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridFilterSettings.html'>GridFilterSettings</a></code> component.</li>
                    </ul>
                    <p>In this demo, you can type the text in the filter bar cells to filter the Grid. </p>
                    <p>More information on the filter configuration can be found in this <a target='_blank' href='https://ej2.syncfusion.com/blazor/documentation/grid/filtering'>documentation section</a></p>" 
                }
            },
            new Sample
            {
               Name = "Search",
               Category = "Filtering",
               Directory = "Grid/DataGrid",
               Url = "Grid/Search",
               FileName = "Search.razor",
               Type = SampleType.New,
               TitleTag = "DataGrid . Search . Syncfusion Blazor Components",
               MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows the content searching feature. Use the search box from toolbar to search for records in grid.",
               ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the Grid searching feature. In this sample, use the search box from toolbar to search Grid records.
                    </p>"
                },
                Description = new string[]{
                    @"<p>The Grid has option to search its content using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.EjsGrid%601~Search.html'>Search</a></code> method with search key as the parameter.</p>
                    <p>In this demo, the Grid toolbar provides an option to search the Grid's records. The user can type the search key in the text box of the toolbar and click search button or press Enter key to perform the search operation. The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.EjsGrid%601~Search.html'>Search</a></code> method will be initiated to perform the search here.</p>"
                }
            },
            new Sample
            {
                Name = "Paging",
                Category = "Data Grid",
                Directory = "Grid/DataGrid",
                Url = "Grid/Paging",
                FileName = "Paging.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Paging . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows the usage of the pager",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Grid paging feature.</p>"
                },
                Description = new string[]{
                    @"<p>Paging allows you to display the contents of the Grid in page segments. By default, paging is disabled. To enable paging, set <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~AllowPaging.html'>AllowPaging</a></code> property to true.</p>
                    <p>The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridPageSettings~PageSizes.html'>PageSizes</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridPageSettings.html'>GridPageSettings</a></code> component enables a dropdown in pager which allows you to change the number of records displayed in the page dynamically.</p>
                    <p>In this demo, the Grid is rendered with paging enabled and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridPageSettings~PageSizes.html'>PageSizes</a></code> set as true and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridPageSettings~PageCount.html'>PageCount</a></code> set to 2.</p>"
                }
            },
            new Sample
            {
                Name = "Default Selection",
                Category = "Selection",
                Directory = "Grid/DataGrid",
                Url = "Grid/Selection",
                FileName = "Selection.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Default Selection . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows how to select rows or cells through simple mouse down or keyboard interaction using the selection feature.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the selection feature in Grid, which allows you to select row or cell through simple mouse down or keyboard interaction.
                    </p>"
                },
                Description = new string[]{
                    @"<p>Selection provides an interactive support to highlight the row or cell that you select. Selection can be done through a simple mouse down or keyboard interaction. To enable selection, set <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~AllowSorting.html'>AllowSelection</a></code> property as true.</p>
                    <p>Grid supports two types of selection which can be set using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridSelectionSettings~Type.html'>Type</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridSelectionSettings.html'>GridSelectionSettings</a></code> component. They are,</p>
                    <ul>
                        <li><code>Single</code> - Enabled by default. Allows the user to select single row/cell at a time.</li>
                        <li><code>Multiple</code> - Allows the user to select more than one row/cell at a time.</li>
                    </ul>
                    <p>Also, three modes of selection are supported which can be set using <code><a target='_blank' class='code' href=' https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridSelectionSettings~Mode.html '>Mode</a></code> property. They are,</p>
                    <ul>
                        <li><code>Row</code> - Enabled by default. Enables the row selection in Grid.</li>
                        <li><code>Cell</code> - Enables the cell selection in Grid.</li>
                        <li><code>Both</code> - Enables both the row and cell selection in Grid. Clicking any cell will select the both row and cell simultaneously.</li>
                    </ul>
                    <p>To perform the multi-selection, hold <strong>CTRL</strong> key and click the desired rows/cells. To select range of rows/cells, hold <strong>SHIFT</strong> key and click the rows/cells.</p>
                    <p>While using the Grid in a touch environment, there is an option for multi-selection through single tap on the row and it will show a popup with the multi-selection symbol. Tap the icon to select all the records in a single tap.</p>
                    <p>More information on the selection configuration can be found in this <a target='_blank' href='https://ej2.syncfusion.com/blazor/documentation/grid/selection'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Checkbox Selection",
                Category = "Selection",
                Directory = "Grid/DataGrid",
                Url = "Grid/CheckboxSelection",
                FileName = "CheckboxSelection.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Checkbox Selection. Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows how the check box selection feature can be used to select grid rows.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the selection functionality of the Grid using checkbox selection, To select and unselect all rows use header checkbox.
                        To select/unselect particular row, click the desired row.
                    </p>"
                },
                Description = new string[]{
                    @"<p>Grid multi-selection can be achieved with the help of checkbox in each row. To render checkbox in each grid row, you need to define column type as <code>checkbox</code> in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn~Type.html'>Type</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn.html'>GridColumn</a></code> component.</p>
                    <p>Selection can be persisted on all the operations using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridSelectionSettings~PersistSelection.html'>PersistSelection</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridSelectionSettings.html'>GridSelectionSettings</a></code> component. For persisting selection on the Grid, any one of the column should be defined as a primary key using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn~IsPrimaryKey.html'>IsPrimaryKey</a></code> property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn.html'>GridColumn</a></code> component.</p>
                    <p>In this demo, Grid multi-selection is enabled with the selection persistence.</p>"
                }
            },
            new Sample
            {
                Name = "Default Aggregate",
                Category = "Aggregates",
                Directory = "Grid/DataGrid",
                Url = "Grid/Aggregate",
                FileName = "Aggregate.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Default Aggregate . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows how the row values can be aggregated and shown in a column footer.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates aggregate functionality of the Grid. In this sample, the aggregate value for the column Freight is displayed in column footer.</p>"
                },
                Description = new string[]{
                    @"<p>The Grid supports aggregates which will be displayed at the footer, group footer and group caption of the Grid. The aggregate configurations can be provided in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridAggregates.html'>GridAggregates</a></code> component</p>
                    <p>The built-in aggregates are, </p>
                    <ul>
                    <li><code>Sum</code></li>     
                    <li><code>Average</code></li>     
                    <li><code>Min</code></li>     
                    <li><code>Max</code></li>     
                    <li><code>Count</code></li>     
                    <li><code>TrueCount</code></li>     
                    <li><code>FalseCount</code></li>
                    </ul>   
                    <p>In this demo, the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.AggregateColumnModel~FooterTemplate.html'>FooterTemplate</a></code> is used to display four different aggregates in the Grid footer. In the first aggregate row, the <code>Sum</code> aggregate type is used by setting it in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.AggregateColumnModel~Type.html'>Type</a></code> and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.AggregateColumnModel~Field.html'>Field</a></code> property is set as <strong><i>Freight</i></strong> which will be used to perform the aggregation. The aggregate value is accessed inside the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.AggregateColumnModel~FooterTemplate.html'>FooterTemplate</a></code> using its <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.AggregateColumnModel~Type.html'>Type</a></code> name (<code>@sumvalue.Sum</code>) where <b>sumvalue</b> is an implicit named parameter - <b>context</b>. The aggregate value will be formatted based on its <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.AggregateColumnModel~Format.html'>Format</a></code> value(<strong><i>C2</i></strong>) before being displayed.</p>"
                }
            },
            new Sample
            {
                Name = "Group And Caption Aggregate",
                Category = "Aggregates",
                Directory = "Grid/DataGrid",
                Url = "Grid/GroupAndCaptionAggregate",
                FileName = "GroupAndCaptionAggregate.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Group And Caption Aggregate . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows how the row values can be aggregated for each group of items and shown in a group caption and individual group row (group footer).",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates Aggregate functionality of the Grid. In this sample, both Unit In Stock column are displayed their aggregate value in group footer.
                        Unit In Stock column displayed its aggregate value in group caption also.</p>"
                },
                Description = new string[]{
                    @"<p>The Grid supports aggregates which will be displayed at the footer, group footer and group caption of the Grid. The aggregate configurations can be provided by using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridAggregates.html'>GridAggregates</a></code> component.</p>
                    <p>The built-in aggregates are,</p>
                    <ul>
                        <li><code>Sum</code></li>     
                        <li><code>Average</code></li>     
                        <li><code>Min</code></li>     
                        <li><code>Max</code></li>     
                        <li><code>Count</code></li>     
                        <li><code>TrueCount</code></li>     
                        <li><code>FalseCount</code></li>
                    </ul>    
                    <p>In this demo, the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridAggregateColumn~GroupFooterTemplate.html'>GroupFooterTemplate</a></code> is used for displaying the group footer aggregation for the <strong><i>Unit In Stocks</i></strong> and <strong><i>Discontinued</i></strong> columns and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridAggregateColumn~GroupCaptionTemplate.html'>GroupCaptionTemplate</a></code> is used for displaying the group caption aggregation for the <strong><i>Unit In Stocks</i></strong> column.</p>    
                    <p>To enable group footer aggregation for <strong><i>Unit In Stocks</i></strong> column, the <code>Sum</code> aggregate type is used by setting it in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.AggregateColumnModel~Type.html'>Type</a></code> property and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.AggregateColumnModel~Field.html'>Field</a></code> property is set as <strong><i>UnitsInStock</i></strong> which will be used to perform the aggregation. The aggregate value is accessed inside the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridAggregateColumn~GroupFooterTemplate.html'>GroupFooterTemplate</a></code> using its <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.AggregateColumnModel~Type.html'>Type</a></code> name (<code>@unit.Sum</code>) where <b>unit</b> is an implicit named parameter - <b>context</b>.</p>
                    <p>To enable group caption aggregation for <strong><i>Unit In Stocks</i></strong> column, the <code>Max</code> aggregate type is used by setting it in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.AggregateColumnModel~Type.html'>Type</a></code> property and the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.AggregateColumnModel~Field.html'>Field</a></code> property is set as <strong><i>UnitsInStock</i></strong> which will be used to perform the aggregation. The aggregate value is accessed inside the<code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridAggregateColumn~GroupCaptionTemplate.html'>GroupCaptionTemplate</a></code> using its <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.AggregateColumnModel~Type.html'>Type</a></code> name (<code>@unit.Max</code>) where <b>unit</b> is an implicit named parameter - <b>context</b>.</p>"
                }
            },
            new Sample
            {
                Name = "Default Exporting",
                Category = "Exporting",
                Directory = "Grid/DataGrid",
                Url = "Grid/Exporting",
                FileName = "Exporting.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Default Exporting . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component explains the way of exporting grid content to Excel, PDF, and CSV formats.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the client-side exporting of the Grid, which allows you to export its data to the Excel, Pdf and CSV formats. Use the toolbar buttons to export Grid data to desired format.</p>"
                },
                Description = new string[]{
                    @"<p>Grid supports client-side exporting which allows you to export its data to Excel, Pdf and CSV formats.</p>
                    <p>In this demo, we have defined actions for the exporting toolbar items, in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~ToolbarClick.html'>ToolbarClick</a></code> event to export the Grid data using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.EjsGrid%601~ExcelExport.html'>ExcelExport</a></code>, <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.EjsGrid%601~PdfExport.html'>PdfExport</a></code> and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.EjsGrid%601~CsvExport.html'>CsvExport</a></code> methods.</p>
                    <p>More information about Exporting can be found in the documentation section.</p>"
                }
            },
            new Sample
            {
                Name = "Print",
                Category = "Exporting",
                Directory = "Grid/DataGrid",
                Url = "Grid/Print",
                FileName = "Print.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Print . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows how to print the grid content. Click the print button from the toolbar item to print Grid.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the different options to print the hierarchy Grid.</p>"
                },
                Description = new string[]{
                    @"<p>The Grid can be printed using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.EjsGrid%601~Print.html'>Print</a></code> method. While printing the pager and scrollbar will be removed if they are enabled in Grid. By default, all pages will be printed. We can print current page alone by setting the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~PrintMode.html'>PrintMode</a></code> property value as <code>currentpage</code>. The child grid allows us to print the grid with following options,</p>
                    <ul>
                        <li><code>Expanded</code> - Prints the master grid with expanded child grids.</li>
                        <li><code>All</code> - Prints the master grid with all the child grids.</li>
                        <li><code>None</code> - Prints the master grid alone.</li>
                    </ul>
                    <p>We can change the child grid's print option by using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~HierarchyPrintMode.html'>HierarchyPrintMode</a></code> property.</p>"
                }
            },
            new Sample
            {
                Name = "Grouping",
                Category = "Data Grid",
                Directory = "Grid/DataGrid",
                Url = "Grid/Grouping",
                FileName = "Grouping.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Grouping . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component demonstrates the grouping feature of the grid control. The grid control has an option to group records based on columns.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates grouping feature of the Grid component. In this sample, the Grid data is grouped against
                        Customer Name column. To group any other column simply drag the column header and drop on the group drop area.
                    </p>"
                },
                Description = new string[]{
                    @"<p>The Grid control has options to group the records based on the required column. When grouping is applied, grouped records are organized into a hierarchical structure to facilitate easier expansion and collapsing of the records. To enable grouping, set <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~AllowGrouping.html'>AllowGrouping</a></code> property as true.</p>
                    <p>Columns can be grouped by simply dragging the column header and dropping it on the group drop area.</p>
                    <p>In this demo, to group a specify column, drag and drop the column in the group drop area.</p>"
                }
            },
            new Sample
            {
                Name = "Column Template",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/ColumnTemplate",
                FileName = "ColumnTemplate.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Column Template . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component demonstrates the usage of template columns in Grid to show custom image in the Employee Image column.",
                ActionDescription = new string[] {
                    @"<p>This demo for Essential JS 2 grid control shows the usage of template columns in grid.</p>"
                },
                Description = new string[]{
                    @"<p>The Grid provides a way to use custom layout to display custom element value or content for each column using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn~Template.html'>Template</a></code> property. You can use the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn~Template.html'>Template</a></code>property of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn.html'>GridColumn</a></code> component to specify the custom content. Inside the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn~Template.html'>Template</a></code>, you can access the data using the implicit named parameter <strong>Context</strong>.</p>
                    <p>In this demo, using column template, we have displayed <strong>Employee Image</strong> column with Employee Photo.</p>"
                }
            },
            new Sample
            {
                Name = "Row Template",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "Grid/RowTemplate",
                FileName = "GridRowTemplate.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Row Template . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows the usage of the row template feature. We have rendered each DataGrid row using template.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Grid component with the row template feature. In this sample, we have rendered each Grid
                        row using the template.</p>"
                },
                Description = new string[]{
                    @"<p>The RowTemplate has option to customize the look and behavior of the grid rows. The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~RowTemplate.html'>RowTemplate</a></code> should be wrapped around the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridTemplates.html'>GridTemplates</a></code> component. The RowTemplate content must be <strong>TD</strong> elements and the number of <strong>TD</strong> elements should match the number of grid columns.</p>
                    <p>In this demo, we have presented Employee Information with Employee Photo in the first column and employee details like Name, Address etc. in the second column.</p>"
                }
            },
            new Sample
            {
                Name = "Detail Template",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "Grid/DetailTemplate",
                FileName = "GridDetailTemplate.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Detail Template . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component demonstrates how the detailed information about a row can be displayed in template using detail template feature.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Grid component with the detail template feature. Click the expand button
                        in each Grid row to show the detailed information about a row.</p>"
                },
                Description = new string[]{
                    @"<p>The detail template provides additional information about a particular row on expanding or collapsing the detail content. The <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~DetailTemplate.html'>DetailTemplate</a></code> should be wrapped around the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridTemplates.html'>GridTemplates</a></code> component with the required content.</p>
                    <p>In this demo, we have presented Employee Information with image in the detail row.</p>"
                }
            },
            new Sample
            {
                Name = "Header Template",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/HeaderTemplate",
                FileName = "GridHeaderTemplate.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Header Template . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component explains the way of showing custom icon in the column header using header template feature of grid.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Grid component with the detail template feature. Click the expand button
                        in each Grid row to show the detailed information about a row.</p>"
                },
                Description = new string[]{
                    @"<p>The Header Template has options to display custom element value or content in the header area. You can use the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn~HeaderTemplate.html'>HeaderTemplate</a></code> of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridColumn.html'>GridColumn</a></code> component to specify the custom content to be displayed in the header section.</p>
                    <p>In this demo, we have presented Employee Information with image using the header template.</p>"
                }
            },
            new Sample
            {
                Name = "Clipboard",
                Category = "Data Grid",
                Directory = "Grid/DataGrid",
                Url = "Grid/Clipboard",
                FileName = "Clipboard.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Clipboard . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows copy to clipboard functionality of grid. Select rows and click Copy button from toolbar to copy content.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates copy to clipboard functionality of the Grid component. Select rows and click Copy button from
                        toolbar to copy content. To copy with header click Copy with header button from toolbar.
                    </p>"
                },
                Description = new string[]{
                    @"<p>Selected row or cell data in the Grid can be copied into the clipboard using the Keyboard shortcuts and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.EjsGrid%601~Copy.html'>Copy</a></code> method.</p>
                    <p>In this demo, selected rows data can be copied into the clipboard using the below Keyboard shortcuts or toolbar interactions.</p>
                    <ul>
                        <li><code>Ctrl + C</code> - Selected rows or cells data without header.</li>
                        <li><code>Ctrl + Shift + H</code> - Selected rows or cells data with header.</li>
                    </ul>"
                }
            },
            new Sample
            {
                Name = "Row Height",
                Category = "Rows",
                Directory = "Grid/DataGrid",
                Url = "Grid/RowHeight",
                FileName = "RowHeight.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Row Height . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows the row height feature. Click on the toolbar icons to change row's height.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the row height feature of the Grid. In this demo, the <b>rowHeight</b> for all the Grid rows can be
                changed as <b>20px</b>, <b>40px</b> and <b>60px</b> on ToolBar button click.</p>"
                },
                Description = new string[]{
                    @"<p>The row height for the Grid rows can be set using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~RowHeight.html'>RowHeight</a></code> property.</p>"
                }
            },
            new Sample
            {
                Name = "Frozen Rows and Columns",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/FrozenRows",
                FileName = "FrozenRowsAndColumns.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Frozen Rows and Columns . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component shows frozen rows/columns feature of grid. Scroll the movable content to view the frozen rows/columns.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the frozen rows and columns feature of the Grid. Scroll the movable content vertically/horizontally to view the frozen rows/columns
                    with the content.</p>"
                },
                Description = new string[]{
                    @"<p>Grid provides support to freeze certain rows/columns from being scrolled thus allowing only the remaining content scrollable. This can be achieved by using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~FrozenRows.html'>FrozenRows</a></code> and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Grids.GridModel%601~FrozenColumns.html'>FrozenColumns</a></code> property.</p>
                    <p>In this demo sample, the first column and two rows are set to frozen by using these properties.</p>"
                }
            },
            new Sample
            {
                Name = "Show or Hide Column",
                Category = "Columns",
                Directory = "Grid/DataGrid",
                Url = "Grid/ShoworHideColumn",
                FileName = "ShoworHideColumn.razor",
                Type = SampleType.New,
                TitleTag = "DataGrid . Show or Hide Column . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component demonstrates how the columns are show and hide dynamically.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates dynamic show hide columns feature of Grid. 
            Click the switch to toggle visibility for columns.
                    .</p>"
                },
                Description = new string[]{
                    @"<p>The Grid column can be showed/hidden dynamically using <code>showColumns </code> and <code>hideColumns</code> method of the Grid.</p>
                <p>In this demo, the columns can be showed and hidden by clicking the 
                    Switch buttons to toggle visibility. And the column`s visibility is toggled based on the
                    <code>columns->headerText</code> value.</p>
                <br/>
                <p>The <code>columns->visible</code> property specifies the visibility of a column. To hide a column at the initial rendering, set the <code>columns->visible
                </code> property to false.</p>"
                }
            },
            new Sample
            {
                Name = "Observable Collection",
                Category = "Data Binding",
                Directory = "Grid/DataGrid",
                Url = "Grid/ObservableBinding",
                FileName="ObservableBinding.razor",
				Type = SampleType.New,
                TitleTag = "DataGrid . Observable Collection . Syncfusion Blazor Components",
                MetaDescription = "This demo for Syncfusion Blazor DataGrid component demonstrates the way of binding Observable collection to grid.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the usage of Observable data binding in Grid component.
                    </p>"
                },
                Description = new string[]{
                    @"<p> Using Observable Collections Objects can be added, removed or be updated with an automatic notification of actions. 
                The UI is automatically updated, when an object is added to or removed from an <strong>observable collection<strong>.</p>"
                }
            }
        };
    }
}
