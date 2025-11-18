[![.NET](https://github.com/syncfusion/blazor-samples/actions/workflows/dotnet.yml/badge.svg)](https://github.com/syncfusion/blazor-samples/actions/workflows/dotnet.yml)

# Syncfusion® Blazor Component Examples            

This repository contains the demos of [Syncfusion Blazor Components](https://www.syncfusion.com/blazor-components). This is the best place to check the controls to get more insight into the usage of APIs.

The following topics can help you to use the Syncfusion Blazor Components and run this application in your local. 

* [Requirements to run the demo](#requirements-to-run-the-demo)
* [How to run the demo](#how-to-run-the-demo)
* [Blazor Documentation](https://blazor.syncfusion.com/documentation/)
* [Blazor Components Catalog](#blazor-components-catalog)
* [License](#license)
* [Support and feedback](#support-and-feedback)

## Requirements to run the demo

* [System requirements](https://blazor.syncfusion.com/documentation/system-requirements/)

* [NET 8 WebAssembly Workload / NET 9 WebAssembly Workload](https://learn.microsoft.com/en-us/aspnet/core/blazor/webassembly-build-tools-and-aot?view=aspnetcore-8.0#net-webassembly-build-tools)

* Nodejs Version : [10.24.* or above](https://nodejs.org/download/release/v8.1.0/)

## How to run the demo

Clone the repository. This repository contains Blazor Web App Server demos, Blazor Web App WASM demos and solution files for .NET 8 and .NET 9. This repository has Common, Blazor Web App Server Demos and Blazor Web App WASM Demos folders.
* `Blazor-Server-Demos` folder has solution and project files to run Blazor server demos.
* `Blazor-WASM-Demos` folder has solution and project files to run Blazor WebAssembly demos.
* The Common folder contains all the common files (i.e., samples, static web assets, resources) which are applicable for Blazor Web App Server demos and Blazor Web App WASM demos.

### Run the demo using .NET CLI

* Open the command prompt from the demo's directory.
* Run the demo using the following command.
   
   To run .NET 8 Blazor Web App Server Demos project
   > `dotnet run --project Blazor-Server-Demos/Blazor_Server_Demos_NET8.csproj`

   To run .NET 9 Blazor Web App Server Demos project
   > `dotnet run --project Blazor-Server-Demos/Blazor_Server_Demos_NET9.csproj`

   To run .NET 8 Blazor Web App WASM Demos project
   > `dotnet run --project Blazor-WASM-Demos/Blazor_WASM_Demos/Blazor_WASM_Demos_NET8.csproj`

   To run .NET 9 Blazor Web App WASM Demos project
   > `dotnet run --project Blazor-WASM-Demos/Blazor_WASM_Demos/Blazor_WASM_Demos_NET9.csproj`

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
            <p></p>
            <div><p class="controlcategory">SMART COMPONENTS</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/demos/ai-smartpaste/annotations">Smart Paste Button</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/demos/ai-smarttextarea/default">Smart TextArea</a></div>
            <p>&nbsp;</p>
            <div><p class="controlcategory">INTERACTIVE CHAT</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/ai-assistview/getting-started-webapp">AI AssistView</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/chat-ui/getting-started">Chat UI - Preview</a></div>
            <p>&nbsp;</p>
            <div><p class="controlcategory">DATA MANAGEMENT</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/datagrid/getting-started">DataGrid</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/pivot-table/getting-started">Pivot Table</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/treegrid/getting-started">TreeGrid</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/query-builder/getting-started">Query Builder</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/pager/getting-started">Pager</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/listview/getting-started">ListView</a></div>
            <p>&nbsp;</p>
            <div><p class="controlcategory">FILE VIEWERS & EDITORS</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/rich-text-editor/getting-started">Rich Text Editor</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/image-editor/getting-started">Image Editor</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/dialog/getting-started">Dialog</a></div>
            <p>&nbsp;</p>
            <div><p class="controlcategory">LAYOUT</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/card/getting-started">Card</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/dashboard-layout/getting-started">Dashboard Layout</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/dialog/getting-started">Dialog</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/predefined-dialogs/getting-started">Predefined Dialogs</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/splitter/getting-started">Splitter</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/timeline/getting-started">Timeline</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/tooltip/getting-started">Tooltip</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/media-query/getting-started">Media Query</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/avatar/getting-started">Avatar</a></div>
        </td>
        <td>
            <p></p>
            <div><p class="controlcategory">DATA VISUALIZATION</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/chart/getting-started-server">Charts</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/3d-chart/getting-started-with-web-app">3D Chart</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/barcode/getting-started">Barcode Generator</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/bullet-chart/getting-started">Bullet Chart</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/circular-gauge/getting-started">Circular Gauge</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/circular-gauge/getting-started">Arc Gauge</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/heatmap-chart/getting-started">HeatMap Chart</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/linear-gauge/getting-started">Linear Gauge</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/range-selector/getting-started">Range Selector</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/smith-chart/getting-started">Smith Chart</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/sparkline/getting-started">Sparkline Charts</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/stock-chart/getting-started">Stock Chart</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/stock-chart/getting-started">Sankey</a></div>
            <p>&nbsp;</p>
            <p></p>
            <div><p class="controlcategory">DIAGRAMS AND MAPS</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/diagram-component/getting-started">Diagram</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/treemap/getting-started">TreeMap</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/maps/getting-started">Maps</a></div>
            <p>&nbsp;</p>
            <div><p class="controlcategory">BUTTONS & ACTIONS</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/button/getting-started">Button</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/button-group/getting-started">ButtonGroup</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/chip/getting-started">Chips</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/floating-action-button/getting-started">Floating Action Button</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/drop-down-menu/getting-started">Dropdown Menu</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/progress-button/getting-started">Progress Button</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/split-button/getting-started">SplitButton</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/speeddial/getting-started">Speed Dial</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/toggle-switch-button/getting-started">Toggle Switch Button</a></div>
            <p>&nbsp;</p>
            <br>
        </td>
        <td>
            <div><p class="controlcategory">SCHEDULING & CALENDARS</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/scheduler/getting-started">Scheduler</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/gantt-chart/getting-started">Gantt Chart</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/calendar/getting-started">Calendar</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/datepicker/getting-started">DatePicker</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/daterangepicker/getting-started">DateRangePicker</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/datetime-picker/getting-started">DateTime Picker</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/timepicker/getting-started">TimePicker</a></div>
            <p>&nbsp;</p>
            <div><p class="controlcategory">INPUTS</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/check-box/getting-started">CheckBox</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/color-picker/getting-started">Color Picker</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/color-picker/mode-and-value#rendering-palette-at-initial-load">Color Palette</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/signature/getting-started">Signature</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/input-mask/getting-started">Input Mask</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/numeric-textbox/getting-started">Numeric TextBox</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/radio-button/getting-started">RadioButton</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/range-slider/getting-started">Range Slider</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/textarea/getting-started">TextArea</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/textbox/getting-started">TextBox</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/rating/getting-started">Rating</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/otp-input/getting-started">OTP Input</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/speech-to-text/getting-started-web-app">Speech To Text</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/in-place-editor/getting-started">InPlace Editor</a></div>
            <p>&nbsp;</p>
            <div><p class="controlcategory">FILE MANAGEMENT</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/file-upload/getting-started">File Upload</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/file-manager/getting-started">File Manager</a></div>
            <p>&nbsp;</p>
            <div><p class="controlcategory">FORMS</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/data-form/getting-started">Data Form</a></div>
            <p>&nbsp;</p>
            <div><p class="controlcategory">KANBAN</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/kanban/getting-started">Kanban</a></div>
            <p>&nbsp;</p>
        </td>
        <td>
            <p></p>
            <div><p class="controlcategory">DROPDOWNS</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/autocomplete/getting-started">AutoComplete</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/combobox/getting-started">ComboBox</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/dropdown-list/getting-started">Dropdown List</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/dropdown-tree/getting-started-with-web-app">Dropdown Tree</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/listbox/getting-started">ListBox</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/multiselect-dropdown/getting-started">Multiselect DropDown</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/mention/getting-started">Mention</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/multicolumn-combobox/getting-started-with-web-app">MultiColumn ComboBox</a></div>
            <p>&nbsp;</p>
            <div><p class="controlcategory">NAVIGATION</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/accordion/getting-started">Accordion</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/breadcrumb/getting-started">Breadcrumb</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/carousel/getting-started">Carousel</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/context-menu/getting-started">Context Menu</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/ribbon/getting-started">Ribbon</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/menu-bar/getting-started">Menu Bar</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/sidebar/getting-started">Sidebar</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/tabs/getting-started">Tabs</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/toolbar/getting-started">Toolbar</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/treeview/getting-started">TreeView</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/appbar/getting-started">AppBar</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/stepper/getting-started">Stepper</a></div>
            <p>&nbsp;</p>
            <div><p class="controlcategory">NOTIFICATION</p></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/message/getting-started">Message</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/progress-bar/getting-started">Progress Bar</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/toast/getting-started">Toast</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/spinner/getting-started">Spinner</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/skeleton/getting-started">Skeleton</a></div>
            <div class="controlanchorlink"><a target="_self" href="https://blazor.syncfusion.com/documentation/badge/getting-started">Badge</a></div>
            <p>&nbsp;</p>
        </td>
    </tr>
</table>

## License

Syncfusion® Blazor Components is available under the Syncfusion® Essential Studio program, and can be licensed either under the Syncfusion® Community License Program or the Syncfusion commercial license.

To be qualified for the Syncfusion® Community License Program, you must have gross revenue of less than one (1) million U.S. dollars (USD 1,000,000.00) per year and have less than five (5) developers in your organization, and agree to be bound by Syncfusion's terms and conditions.

Customers who do not qualify for the community license can contact sales@syncfusion.com for commercial licensing options.

You may not use this product without first purchasing a Community License or a Commercial License, as well as agreeing to and complying with Syncfusion's license terms and conditions.

The Syncfusion® license that contains the terms and conditions can be found at
[https://www.syncfusion.com/content/downloads/syncfusion_license.pdf](https://www.syncfusion.com/content/downloads/syncfusion_license.pdf)

## Support and feedback  

* For any other queries, reach the [Syncfusion® support team](https://support.syncfusion.com/) or post the queries through the [community forums](https://www.syncfusion.com/forums?utm_source=github&utm_medium=listing&utm_campaign=blazor-samples).

* To renew the subscription, click [here](https://www.syncfusion.com/sales/products?utm_source=github&utm_medium=listing&utm_campaign=blazor-samples) or contact our sales team at <salessupport@syncfusion.com>.

* Don't see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/blazor-components).

## See also

* [Blazor Documentation](https://blazor.syncfusion.com/documentation/introduction)
* [Blazor Components](https://www.syncfusion.com/blazor-components)
* [Blazor Live Demos - Server](https://blazor.syncfusion.com/demos/)
* [Blazor Live Demos - WebAssembly](https://blazor.syncfusion.com/wasm/demos/)
* [Blazor Playground](https://blazorplayground.syncfusion.com/)
* [Blazor Smart/AI Samples](https://github.com/syncfusion/smart-ai-samples)  
