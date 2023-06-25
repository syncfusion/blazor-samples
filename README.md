# Syncfusion Blazor Component Examples

This repository contains the demos of [Syncfusion Blazor Components](https://www.syncfusion.com/blazor-components). This is the best place to check the controls to get more insight into the usage of APIs.

The following topics can help you to use the Syncfusion Blazor Components and run this application in your local.

* [Requirements to run the demo](#requirements-to-run-the-demo)
* [How to run the demo](#how-to-run-the-demo)
* [Blazor documentation](https://blazor.syncfusion.com/documentation/)
* [Blazor Components Catalog](#blazor-components-catalog)
* [License](#license)
* [Support and feedback](#support-and-feedback)

## Requirements to run the demo

* [System requirements](https://blazor.syncfusion.com/documentation/system-requirements/)

* Nodejs Version : [10.24.* or above](https://nodejs.org/download/release/v8.1.0/)

## How to run the demo

Clone the repository. This repository contains both Blazor Server demos and Blazor WASM demos with .NET Core 3.1 and .NET 6 project and solution files. This repository has Common, Blazor Server Demos and Blazor WASM Demos folder.
* `Blazor-Server-Demos` folder has solution and project files to run Blazor server demos.
* `Blazor-WASM-Demos` folder has solution and project files to run Blazor WebAssembly demos.
* `Blazor-WASM-Hosted-Demos` folder has solution and project files to run Blazor WebAssembly Hosted demos.
* The Common folder contains all the common files (i.e., samples, static web assets, resources) which are applicable for Blazor Server Demos, Blazor WebAssembly Demos and Blazor WebAssembly Hosted Demos.

### Run the demo using .NET CLI

* Open the command prompt from the demo's directory.
* Run the demo using the following command.
   
   To run .NET 6 Blazor Server Demos project
   > `dotnet run --project Blazor-Server-Demos/Blazor_Server_Demos_NET6.csproj`

   To run .NET 7 Blazor Server Demos project
   > `dotnet run --project Blazor-Server-Demos/Blazor_Server_Demos_NET7.csproj`

   To run .NET 6 Blazor WASM Demos project
   > `dotnet run --project Blazor-WASM-Demos/Blazor_WASM_Demos_NET6.csproj`

    To run .NET 7 Blazor WASM Demos project
   > `dotnet run --project Blazor-WASM-Demos/Blazor_WASM_Demos_NET7.csproj`

    To run .NET 6 Blazor WASM-Hosted Demos project
   > `dotnet run --project Blazor-WASM-Hosted-Demos/Server/Blazor_WASM_Hosted_Demos_NET6.Server.csproj`

    To run .NET 7 Blazor WASM-Hosted Demos project
   > `dotnet run --project Blazor-WASM-Hosted-Demos/Server/Blazor_WASM_Hosted_Demos_NET7.Server.csproj`

### Run the demo using Visual Studio

* Open the solution file using Visual Studio.
* Press `Ctrl + F5` to run the demo.

### Run the demo using Visual Studio code

* Open the Visual Studio code from the demos directory where the project file is present.

    > Ensure the [C# for Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) extension is installed in your Visual Studio code before running the Blazor demos.

* Press `Ctrl + F5` to run the demo.


## Blazor Components Catalog

<table id="table">
    <tbody>
        <colgroup>
            <col style="width: 220px">
            <col style="width: 260px">
            <col style="width: 220px">
            <col style="width: 220px">
        </colgroup>
    </tbody>
    <tr>
        <td> 
            <div><p class="controlcategory">GRIDS</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/datagrid/getting-started">DataGrid</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/pivot-table/getting-started">Pivot Table</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/treegrid/getting-started">TreeGrid</a></div>
            <p></p>
            <div><p class="controlcategory">FILE VIEWERS & EDITORS</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/in-place-editor/getting-started">InPlace Editor</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/rich-text-editor/getting-started">RichTextEditor</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/image-editor/getting-started">Image Editor</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/document-editor/getting-started/features">Word Processor</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/pdfviewer/getting-started/features">PDF Viewer</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/pdfviewer-2/getting-started/features">PDF Viewer (NextGen)</a></div>     
            <p></p> 
            <div><p class="controlcategory">Document Processing Libraries</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://help.syncfusion.com/file-formats/docio/create-word-document-in-blazor">Word (DocIO)</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://help.syncfusion.com/file-formats/pdf/create-pdf-document-in-blazor">PDF</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://help.syncfusion.com/file-formats/presentation/create-read-edit-powerpoint-files-in-blazor">PowerPoint (Presentation)</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://help.syncfusion.com/file-formats/xlsio/create-read-edit-excel-files-in-blazor-c-sharp">Excel (XlsIO)</a></div>
            <p></p>
            <div><p class="controlcategory">LAYOUT</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/card/getting-started">Card</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/dashboard-layout/getting-started">Dashboard Layout</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/dialog/getting-started">Dialog</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/predefined-dialogs/getting-started">Predefined Dialogs</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/listview/getting-started">ListView</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/splitter/getting-started">Splitter</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/tooltip/getting-started">Tooltip</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/media-query/getting-started">Media Query</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/avatar/getting-started">Avatar</a></div>
        </td>
        <td>
            <div><p class="controlcategory">DATA VISUALIZATION</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/chart/getting-started-server">Charts</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/barcode/getting-started">Barcode Generator</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/bullet-chart/getting-started">Bullet Chart</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/circular-gauge/getting-started">Circular Gauge</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/circular-gauge/getting-started">Arc Gauge</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/diagram-component/getting-started">Diagram Component</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/heatmap-chart/getting-started">HeatMap Chart</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/kanban/getting-started">Kanban</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/linear-gauge/getting-started">Linear Gauge</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/maps/getting-started">Maps</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/range-selector/getting-started">Range Selector</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/smith-chart/getting-started">Smith Chart</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/sparkline/getting-started">Sparkline Charts</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/stock-chart/getting-started">Stock Chart</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/treemap/getting-started">TreeMap</a></div>
            <p></p>
            <div><p class="controlcategory">BUTTONS</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/button/getting-started">Button</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/button-group/getting-started">ButtonGroup</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/chip/getting-started">Chips</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/floating-action-button/getting-started">Floating Action Button</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/drop-down-menu/getting-started">Dropdown Menu</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/progress-button/getting-started">Progress Button</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/split-button/getting-started">SplitButton</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/appearance/icons">Icons</a></div>
            <div><p>&nbsp;</p></div>
            <div><p>&nbsp;</p></div>
        </td>
        <td>
            <div><p class="controlcategory">CALENDARS</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/scheduler/getting-started">Scheduler</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/gantt-chart/getting-started">Gantt Chart</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/calendar/getting-started">Calendar</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/datepicker/getting-started">DatePicker</a></div>
            <div class="controlanchorlink"><a target="_self" href="">DateRangePicker</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/datetime-picker/getting-started">DateTime Picker</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/timepicker/getting-started">TimePicker</a></div>
            <p></p>
            <div><p class="controlcategory">INPUTS</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/check-box/getting-started">CheckBox</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/color-picker/getting-started">Color Picker</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/color-picker/mode-and-value#rendering-palette-at-initial-load">Color Palette</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/signature/getting-started">Signature</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/file-upload/getting-started">File Upload</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/input-mask/getting-started">Input Mask</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/numeric-textbox/getting-started">Numeric TextBox</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/radio-button/getting-started">RadioButton</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/range-slider/getting-started">Range Slider</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/textbox/getting-started">TextBox</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/toggle-switch-button/getting-started">Toggle Switch Button</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/rating/getting-started">Rating</a></div>
            <p></p>
            <div><p class="controlcategory">FORMS</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/query-builder/getting-started">Query Builder</a></div>
            <div><p>&nbsp;</p></div>
            <div><p>&nbsp;</p></div>
        </td>
        <td>
            <div><p class="controlcategory">DROPDOWNS</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/autocomplete/getting-started">AutoComplete</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/combobox/getting-started">ComboBox</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/dropdown-list/getting-started">Dropdown List</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/listbox/getting-started">ListBox</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/multiselect-dropdown/getting-started">Multiselect DropDown</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/mention/getting-started">Mention</a></div>
            <p></p>
            <div><p class="controlcategory">NAVIGATION</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/accordion/getting-started">Accordion</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/breadcrumb/getting-started">Breadcrumb</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/carousel/getting-started">Carousel (Preview)</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/context-menu/getting-started">Context Menu</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/file-manager/getting-started">File Manager</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/menu-bar/getting-started">Menu Bar</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/pager/getting-started">Pager</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/sidebar/getting-started">Sidebar</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/tabs/getting-started">Tabs</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/toolbar/getting-started">Toolbar</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/treeview/getting-started">TreeView</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/appbar/getting-started">AppBar</a></div>
            <p></p>
            <div><p class="controlcategory">NOTIFICATION</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/message/getting-started">Message</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/progress-bar/getting-started">Progress Bar</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/toast/getting-started">Toast</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/spinner/getting-started">Spinner</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/skeleton/getting-started">Skeleton</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/badge/getting-started">Badge</a></div>
        </td>
    </tr>
</table>

## License

Syncfusion Blazor Components is available under the Syncfusion Essential Studio program, and can be licensed either under the Syncfusion Community License Program or the Syncfusion commercial license.

To be qualified for the Syncfusion Community License Program, you must have gross revenue of less than one (1) million U.S. dollars (USD 1,000,000.00) per year and have less than five (5) developers in your organization, and agree to be bound by Syncfusion’s terms and conditions.

Customers who do not qualify for the community license can contact sales@syncfusion.com for commercial licensing options.

You may not use this product without first purchasing a Community License or a Commercial License, as well as agreeing to and complying with Syncfusion's license terms and conditions.

The Syncfusion license that contains the terms and conditions can be found at
[https://www.syncfusion.com/content/downloads/syncfusion_license.pdf](https://www.syncfusion.com/content/downloads/syncfusion_license.pdf)

## Support and feedback

* For any other queries, reach the [Syncfusion support team](https://support.syncfusion.com/) or post the queries through the [community forums](https://www.syncfusion.com/forums?utm_source=github&utm_medium=listing&utm_campaign=blazor-samples).

* To renew the subscription, click [here](https://www.syncfusion.com/sales/products?utm_source=github&utm_medium=listing&utm_campaign=blazor-samples) or contact our sales team at <salessupport@syncfusion.com>.

* Don't see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/blazor-components).

## See also

* [Blazor documentation](https://blazor.syncfusion.com/documentation/introduction)
* [Blazor components](https://www.syncfusion.com/blazor-components)
* [Blazor live demos](https://blazor.syncfusion.com/demos/)
* [Blazor Playground](https://blazorplayground.syncfusion.com/)
