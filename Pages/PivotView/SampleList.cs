using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> PivotTable { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Pivot Table",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                  @"<p> This sample demonstrates basic rendering of the pivot table with drill-up and drill-down functionality bound to a
        relational report.</p>"
                },
                Description = new string[] {
                  @"<p>The pivot table is an easily configurable, presentation-quality business control used for visualizing relational
        data
        sources in cross-tabular format. It is displayed with drill-up and drill-down capabilities and allows users to
        easily
        aggregate data. Sorting, filtering, and grouping data are also supported.
    </p>
    <p>

        In this demo, the pivot table is populated with its minimum default settings.</p>
<p>More information on the Blazor Pivot Table can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/getting-started/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/remote-data",
                FileName = "RemoteData.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                  @"<p>This sample demonstrates basic rendering of the pivot table bound to JSON data pulled from a remote server.</p>"
                },
                Description = new string[] {
                  @"<p>The pivot table supports JSON data source. The
                        <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewDataSourceSettings%601~DataSource.html'>DataSource</a></code> property in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewDataSourceSettings%601_members.html'>PivotViewDataSourceSettings</a></code> class can be assigned with the result of <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.BaseComponent~DataManager.html'>DataManager</a></code> to bind remote data.</p>
                    The
                    <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.BaseComponent~DataManager.html'>SfDataManager</a></code>, which will act as an interface between the service endpoint and the pivot table, will require the below minimal
                    information to interact with service endpoint to retrieve the required data properly.
                    <ul>
                        <li>
                            <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.BaseComponent~DataManager.html'>SfDataManager->Url</a></code> - Defines the service endpoint to fetch data.</li>
                        <li>
                            <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.BaseComponent~DataManager.html'>SfDataManager->Adaptor</a></code> - Defines the adaptor option. Here,
                            <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Adaptors.html'>WebApiAdaptor</a></code> is used for remote binding.</li>
                    </ul>
                    <p>Adaptor is responsible for processing the response and request from/to the service endpoint. The predefined adaptors are,</p>
                    <ul>
                        <li><code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Adaptors.html'>UrlAdaptor</a></code> - Use this to interact with any remote service. This is the base adaptor for all remote based adaptors.</li>
                        <li><code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Adaptors.html'>ODataAdaptor</a></code>- Use this to interact with OData endpoints.</li>
                        <li><code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Adaptors.html'>ODataV4Adaptor</a></code> - Use this to interact with OData V4 endpoints.</li>
                        <li><code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Adaptors.html'>WebApiAdaptor</a></code> - Use this to interact with Web API created under OData standards.</li>                    
                    </ul>
                    In this demo, remote data is bound by assigning service data as an instance of
                    <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.BaseComponent~DataManager.html'>DataManager</a></code> to the
                    <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewDataSourceSettings%601~DataSource.html'>DataSource</a></code> property in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewDataSourceSettings%601_members.html'>PivotViewDataSourceSettings</a></code> class.
<p>More information on the remote data binding can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/data-binding/#remote-data'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "OLAP",
                Category = "Data Binding",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/olap",
                FileName = "OLAP.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                 @"<p>
    This sample demonstrates the rendering of a pivot table bound to an online SSAS OLAP cube as its data source.
        OLAP cube elements like dimensions, hierarchies, measures, and others can be arranged in row, column, value, and
        slicer axes to create desired views at runtime.
</p>"
                },
                Description = new string[] {
               @"      <p>
        In this example, users can explore all of an OLAP cube and its elements and view the resultant report in a pivot
        table or pivot chart at runtime. Grouping bar and field list options are included for exploring the data. Along
        with these, toolbar options are included for switching to the pivot chart, performing report manipulation and more:
    </p>
    <table>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Create new report:</code>
            </td>
            <td>Allows user to create new reports at runtime.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Rename report:</code>
            </td>
            <td>Allows user to change current report name dynamically through UI.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Remove report:</code>
            </td>
            <td>Allows user to remove current report from the report collection at runtime.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Save as option:</code>
            </td>
            <td>Allows user to save report locally in browser memory.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Report list:</code>
            </td>
            <td>Allows user to swap between the reports within the report collection.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Pivot Table:</code>
            </td>
            <td>Allows user to view data in cross-tabulation format.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Pivot Chart and its types:</code>
            </td>
            <td>Allows user to view data in graphical format. The chart types include column, bar, line, area, etc.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Show MDX query:</code>
            </td>
            <td>View the MDX query of the current pivot table that is used to fetch the data from the cube.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Export:</code>
            </td>
            <td>Provides options to save data in PDF, Excel, and CSV document types.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Hide subtotals and grand totals:</code>
            </td>
            <td>Hide grand totals and subtotals based on hierarchies in rows and columns.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Conditional formatting:</code>
            </td>
            <td>Allows user to customize cells base on certain conditions.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Field List:</code>
            </td>
            <td>Provides option to alter the report dynamically through UI.</td>
        </tr>
    </table>
<p>More information on the OLAP data binding can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/olap/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Pivot Chart",
                Category = "Integration",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/pivot-chart",
                FileName = "Chart.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates rendering a pivot chart using pivot data. User can explore the data through drill-up
                            and drill-down operations by clicking the grouping labels. The field list can also be used to change the report
                            at runtime.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                            In this sample, the Pivot component plots a chart based on the pivot report bound to it. This can be
                            achieved by setting the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewDisplayOption~View.html'>View</a></code> property to <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewDisplayOption~View.html'>View.Chart</a></code> in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewDisplayOption_members.html'>PivotViewDisplayOption</a></code> class. The
                            built-in options are:</br>
                            <ul>
                                <li><code>Table</code> - Renders pivot table only, which is the default type.</li>
                                <li><code>Chart</code> - Renders pivot chart only.</li>
                                <li><code>Both</code> - Renders both pivot table and pivot chart.</li>
                            </ul>
                        </p>
                        <p>
                            You can change the chart types using the <b>Chart Types</b> dropdown list separately.
                            The chart types can be set using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotChartSeries~Type.html'>Type</a></code> property in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotChartSeries_members.html'>PivotChartSeries</a></code> class. The built-in chart
                            types
                            are:</br>
                            <code>Column</code>, <code>Line</code>, <code>Spline</code>, <code>Bar</code>, <code>Area</code>, <code>StepArea</code>,
                            <code>SplineArea</code>, <code>StackingColumn</code>, <code>StackingArea</code>, <code>StackingBar</code>, <code>StepLine</code></br>
                            <code>Pareto</code>, <code>Bubble</code>, <code>Scatter</code>, <code>StackingColumn100</code>, <code>StackingBar100</code>, <code>StackingArea100</code>, <code>Polar</code> and
                            <code>Radar</code>.</br></br>
                            In the sample, the field list option is also enabled, through which you can see the result in the chart by altering
                            the report dynamically.
                            </br>
                        </p>
<p>More information on the pivot chart can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/pivot-chart/'>documentation section</a>.</p>"
                    }
            },
            new Sample
            {
                Name = "Field List",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/field-list",
                FileName = "FieldList.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                  @"<p>
                    This sample demonstrates the Excel-like field list feature of the pivot table. 
                The pivot fields are automatically populated from the bound data source, and they can be dragged and dropped to create, view and alter the report at runtime.
                </p>"

                },
                Description = new string[] {
                    @"<p>The pivot table provides a built-in field list very similar to Microsoft Excel. The top section of the
        field list
        allows the user to add and remove fields. The bottom section of the field list allows the user to rearrange the
        fields
        between different axes, including column, row, value, and filter along with filter and sort options.
        <br>
        <br> To show the field list independently, create as separate component namely
        <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.SfPivotFieldList%601_members.html'>SfPivotFieldList</a></code> and assign data source to
        <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotFieldListDataSourceSettings%601~DataSource.html'>DataSource</a></code> property in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotFieldListDataSourceSettings%601_members.html'>PivotFieldListDataSourceSettings</a></code> class. Simultaneously pivot table will be populated by passing its instance in
        the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.SfPivotFieldList%601~UpdateView.html'>UpdateView</a></code> method, inside the
        <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotFieldListEvents%601~EnginePopulated.html'>EnginePopulated</a></code> event of field list.
        <br />
        <br />
        Additionally, user interface for calculated field, label filter, and value filter features have been enabled in
        this demo by setting the properties
        <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotFieldListModel%601~AllowCalculatedField.html'>PivotFieldList->AllowCalculatedField</a></code>,
        <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotFieldListDataSourceSettings%601~AllowLabelFilter.html'>PivotFieldListDataSourceSettings->AllowLabelFilter</a></code> and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotFieldListDataSourceSettings%601~AllowValueFilter.html'>PivotFieldListDataSourceSettings->AllowValueFilter</a></code> to <b>true</b>.
    </p>
<p>More information on the field list can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/field-list/'>documentation section</a>.</p>"
}
            },
            new Sample
            {
                Name = "Grouping Bar",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/grouping-bar",
                FileName = "GroupingBar.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                   @"<p>
    This sample demonstrates grouping feature of the pivot table. The grouping bar is automatically populated from the bound report, and fields can be dragged and dropped to alter the report at runtime. The fields can be sorted, filtered, and removed dynamically as well.
</p>"

                },
                Description = new string[] {
                 @"<p>The pivot table grouping bar option automatically populates fields from the bound data source and allows end
        users
        to drag fields between different axes such as columns, rows, values, and filters, and create pivot table at
        runtime.
        To enable grouping bar, set the
        <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.SfPivotView%601~ShowGroupingBar.html'>ShowGroupingBar</a></code> property in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.SfPivotView%601_members.html'>SfPivotView</a></code> to class <b>true</b>.</p>
    <p>
        Filter and sort icons allow displaying selective records and ordering them in ascending or descending order. The
        value type icon
        allows to display values based on selected aggregate type. The remove icon
        allows the user to remove the field from the report.
    </p>

    <p>

    We can also hide the sort, filter, remove and value type icon in the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewGroupingBarSettings_members.html'>PivotViewGroupingBarSettings</a></code> class by setting <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewGroupingBarSettings~ShowSortIcon.html'>ShowSortIcon</a></code>, <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewGroupingBarSettings~ShowFilterIcon.html'>ShowFilterIcon</a></code>, <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewGroupingBarSettings~ShowRemoveIcon.html'>ShowRemoveIcon</a></code> and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewGroupingBarSettings~ShowValueTypeIcon.html'>ShowValueTypeIcon</a></code> properties to <b>false</b>.</p>
<p>More information on the grouping bar feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/grouping-bar/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Conditional Formatting",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/conditional-formatting",
                FileName = "ConditionalFormatting.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates formatting the appearance of pivot table cells with user-defined styles based on applied conditions. 
                        The <b>conditional formatting</b> dialog is invoked to add conditions and styles for the conditions. The formatting can be added, removed, and reset dynamically as well.
                    </p>"
                    },
                Description = new string[] {
                    @"<p>Conditional formatting works only for cells with values,
                        allowing the users to change its appearance such as background color, font color, font family, and font size
                        based on specific conditions. Conditional formatting can be applied either through UI or code behind. To enable this in UI, set <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.SfPivotView%601~AllowConditionalFormatting.html'>AllowConditionalFormatting</a></code> property to <b>true</b> and invoke <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.SfPivotView%601~ShowConditionalFormattingDialog.html'>ShowConditionalFormattingDialog</a></code> method to view in UI.
                        To achieve this option in code behind, set <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.SfPivotView%601~AllowConditionalFormatting.html'>AllowConditionalFormatting</a></code> property to <b>true</b> and use the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewConditionalFormatSetting_members.html'>PivotViewConditionalFormatSetting</a></code> class in the pivot table along with the following properties. Both options are enabled in this sample.
                    </p>
                    <table>
                        <tr>
                            <td style='vertical-align: top;padding: 4px 0;'>
                                <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewConditionalFormatSetting~Measure.html'>Measure</a> :</code>
                            </td>
                            <td>Specifies the value field name for which style will be applied.</td>
                        </tr>
                        <tr>
                            <td style='vertical-align: top;padding: 4px 0;'>
                                <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewConditionalFormatSetting~Condition.html'>Condition</a> :</code>
                            </td>
                            <td>Specifies the operator type like equals, greater than, less than, etc.</td>
                        </tr>
                        <tr>
                            <td style='vertical-align: top;padding: 4px 0;'>
                                <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewConditionalFormatSetting~Value1.html'>Value1</a> :</code>
                            </td>
                            <td>Specifies the start value.</td>
                        </tr>
                        <tr>
                            <td style='vertical-align: top;padding: 4px 0;'>
                                <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewConditionalFormatSetting~Value2.html'>Value2</a> :</code>
                            </td>
                            <td>Specifies the end value.</td>
                        </tr>
                        <tr>
                            <td style='vertical-align: top;padding: 4px 0;'>
                                <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/cref_files/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewConditionalFormatSetting~Style.html'>Style</a></code>
                            </td>
                            <td>Specifies the style for the cell.</td>
                        </tr>
                    </table>

                    <p>
                    <br />
                    <p>We have applied conditional formatting for the fields <b>In Stock</b> and <b>Sold Amount</b> in code behind. Also, user can clear the entire style applied for the value cell using <b>Reset All</b> option.</p>
<p>More information on the conditional formatting feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/conditional-formatting/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Selection",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/selection",
                FileName = "Selection.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>This sample demonstrates different types of grid cell selection options and an event for getting complete
        information about the selection. The selection of headers, value cells, and summary cells can be done through
        mouse and keyboard actions.
    </p>"       },
                Description = new string[] {
                    @"<p>
        This feature provides interactive support to highlight rows, columns, values, and summary cells that you select.
        Selection can be done through either mouse or keyboard interaction.
        To enable selection, set <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewGridSettings~AllowSelection.html'>AllowSelection</a></code>property in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewGridSettings_members.html'>PivotViewGridSettings</a></code> class to <b>true</b>.
    </p>
    <p>The pivot table supports two types of selection which can be set using
        <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewSelectionSettings~Type.html'>PivotViewSelectionSettings -> Type</a></code> property in  <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewGridSettings_members.html'>PivotViewGridSettings</a></code> class. They are:</p>
    <ul>
        <li><code>Single</code> - Enabled by default. Allows the user to select single row or column or cell at a time.
        </li>
        <li><code>Multiple</code> - Allows the user to select more than one row or column or cell at the same time.</li>
    </ul>
    <p>Also, there are three modes of selection which can be set using
        <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewSelectionSettings~Mode.html'>PivotViewSelectionSettings -> Mode</a></code> property in  <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewGridSettings_members.html'>PivotViewGridSettings</a></code> class. They are:
    </p>
    <ul>
        <li><code>Row</code> - Enabled by default. Enables the complete row selection in a pivot table.</li>
        <li><code>Column</code> - Enables the complete column selection in a pivot table.</li>
        <li><code>Cell</code> - Enables the cell selection in pivot table.</li>
        <li><code>Both</code> - Enables both the row and column selection in pivot table.</li>
    </ul>
    <p>To perform the multiselection, hold <strong>CTRL</strong> key and click the desired cells.
        To select range of cells, hold <strong>SHIFT</strong> key and click the cells.</p>
    <p>While using the pivot table in a touch device environment, tap over a row, column, or other cells.
        This results in a pop-up with a multiselect icon. Now tap the icon to proceed with multiselection.
    </p>
    <p>In this demo, pick the selection type and selection mode from the properties panel in order to perform the
        desired selection process.
        The selected cell information can be seen in the Event Trace part with the help of the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewEvents%601~CellSelected.html'>CellSelected</a></code>
        event.
    </p>
<p>More information on the selection feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/row-and-column/#selection'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Show/Hide Totals",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/show-hide-totals",
                FileName = "SummaryCustomization.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                 @"<p>
    This sample demonstrates showing and hiding grand totals and subtotals in rows, columns, or both at runtime.
        Also, end users can specify and hide subtotals of specific fields.
</p>"
                },
                Description = new string[] {
                 @"<p>
        In this sample, you can hide grand totals in row, column, or both using radio buttons available under the
        <b>Hide grand totals</b> category. To hide grand totals in both row and column, set the
        <code>ShowGrandTotals</code> property in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewDataSourceSettings%601_members.html'>PivotViewDataSourceSettings</a></code> class to <b>false</b>. To hide the row and column grand totals separately,
        set the <code>ShowRowGrandTotals</code> and <code>ShowColumnGrandTotals</code> properties in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewDataSourceSettings%601_members.html'>PivotViewDataSourceSettings</a></code> class to <b>false</b>.
    </p>

    <p>
        Also, in this sample, you can hide subtotals for specific fields too. It can be achieved by selecting
        appropriate fields from the drop-down available under the <b>Hide sub-totals</b> category.
        To hide subtotals for a specific field, set the <code>ShowSubTotals</code> property to <b>false</b> inside the field definition.
    </p>
<p>For more information <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/show-hide-totals/'>refer</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Grouping",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/grouping",
                FileName = "Grouping.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
    This sample demonstrates grouping dates in year, quarter, month, etc., and number types in ranges like 1-4, 5-8,
        etc. in row and column headers of the pivot table.
</p>"
                },
                Description = new string[] {
     @"<p>In this sample, the date type can be separated and showcased individually as year, quarter, month, or day by
        selecting the appropriate option from the <b>Group Date by</b> drop-down list. Also, numbers can be grouped by
        entering the appropriate value in the <b>Group Product ID by</b> giving a range number in the the numeric text
        box.
    </p>
<p>
        Grouping can be applied through code-behind using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewGroupSetting_members.html'>PivotViewGroupSetting</a></code> class in the pivot table
        along with the following properties:
    </p>
    <table>
        <tr>
            <td style='vertical-align: top;padding: 10px 0; width: 130px'>
                <code>Name :</code>
            </td>
            <td>Specifies the normal field.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Type :</code>
            </td>
            <td>Specifies the field type for applying the group settings. For example, date formatted fields should be
                in Date type and number formatted fields should be in Number type.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>GroupInterval :</code>
            </td>
            <td>Specifies the interval for date fields in years, quarters, months, etc.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>RangeInterval :</code>
            </td>
            <td>Specifies the interval value to group the number field.</td>
        </tr>
    </table>
<p>More information on the grouping feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/grouping/'>documentation section</a>.</p>"
           }
            },
            new Sample
            {
                Name = "Toolbar",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/toolbar",
                FileName = "Toolbar.razor",
                Type = SampleType.Updated,
                ActionDescription = new string[] {
                    @"<p>
     This sample demonstrates the toolbar options of the pivot table. The options include report manipulations like create, save, save as, rename and delete, show or hide subtotals and grand totals, conditional formatting, number formatting and exporting in the pivot table and pivot chart.
</p>"

                },
                Description = new string[] {
                 @"<p>In this example, users can generate a report at runtime, as well as save and load them. Save and load operations
        are performed in local variable using the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewEvents%601~SaveReport.html'>SaveReport</a></code> and <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewEvents%601~LoadReport.html'>LoadReport</a></code> events.
    Users can change to either pivot table or pivot chart using the toolbar options. To enable toolbar set the <code>ShowToolbar</code> property in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.SfPivotView%601_members.html'>SfPivotView</a></code> class to <b>true</b>, The toolbar options that are available are:
</p>
 <table>
        <tr>
            <td style='vertical-align: top;padding: 10px 0;width:230px'>
                <code>Create new report:</code>
            </td>
            <td>Allows user to create new reports at runtime.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Rename report:</code>
            </td>
            <td>Allows user to change current report name dynamically through UI.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Remove report:</code>
            </td>
            <td>Allows user to remove current report from the report collection at runtime.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Save as option:</code>
            </td>
            <td>Allows user to save report locally in browser memory.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Report list:</code>
            </td>
            <td>Allows user to swap between the reports within the report collection.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Pivot Table:</code>
            </td>
            <td>Allows user to view data in cross-tabulation format.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Pivot Chart and its types:</code>
            </td>
            <td>Allows user to view data in graphical format. The chart types include column, bar, line, area, etc.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Export:</code>
            </td>
            <td>Provides options to save data in PDF, Excel, and CSV document types.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Hide subtotals and grand totals:</code>
            </td>
            <td>Allows user to hide grand totals and subtotals (based on fields) in row and column.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Conditional formatting:</code>
            </td>
            <td>Allows user to customize cells base on certain conditions.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Number formatting:</code>
            </td>
            <td>Allows user to dynamically apply number formatting to value fields.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Field List:</code>
            </td>
            <td>Provides option to alter the report dynamically through UI.</td>
        </tr>
    </table>
    <p>To define toolbar options, create a list with necessary <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewModel%601~Toolbar.html'>ToolbarItems</a></code> enumeration values and add it to the <code>Toolbar</code> property in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.SfPivotView%601_members.html'>SfPivotView</a></code> class.</p>
<p>More information on the toolbar feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/tool-bar/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Calculated Field",
                Category = "Formula",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/calculated-field",
                FileName = "CalculatedField.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>In this sample, <b>Total Units</b> acts as the calculated field. Users can insert a new basic arithmetic
                            expression
                            based on the existing measure items either through a dialog at runtime or through code behind.</p>"
                    },
                Description = new string[] {
                    @"<p>The calculated field feature allows users to create custom fields which are not present in the actual data source. Users
                            can
                            create these fields using basic mathematical expression collaborating with existing fields. Calculated fields
                            can
                            be created through UI dialog as well as code behind and it can be enabled by setting
                            <code>AllowCalculatedField</code> property in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.SfPivotView%601_members.html'>SfPivotView</a></code> class to <b>true</b>. Use the
                            <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewCalculatedFieldSetting_members.html'>PivotViewCalculatedFieldSetting</a></code> class to configure the calculated field in code behind along with the following properties.
                            <br>
                        </p>
                        <table>
                            <tr>
                                <td style='vertical-align: top;padding: 4px 0;'>
                                    <code>Name :</code>
                                </td>
                                <td>Specifies the given calculated field with unique name..</td>
                            </tr>
                            <tr>
                                <td style='vertical-align: top;padding: 4px 0;'>
                                    <code>Formula :</code>
                                </td>
                                <td>Specifies to set the formula based on the given data source.</td>
                            </tr>
                        </table>
                        <p>More information on the calculated field feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/calculated-field/'>documentation section</a>.</p>"
                    }
            },
            new Sample
            {
                Name = "Aggregation",
                Category = "Formula",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/aggregation",
                FileName = "Aggregation.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the aggregate types like sum, average, min, max, count, distinct count, and more in the
                            pivot table for quick business analysis. End users can also change the aggregation type of each field bound to
                            the value axis in the field list at runtime.
                    </p>"
                    },
                Description = new string[] {
                    @" <p>
                            In this sample, you can change the aggregate types for value fields using the dropdown list separately. The
                            aggregate type can be set using the <code>Type</code> property in <code>PivotViewValue</code> class. The built-in aggregates are:
                        </p>
                        <p>
                            <code>Sum</code>, <code>Average</code>, <code>Min</code>, <code>Max</code>, <code>Count</code>,
                            <code>Distinct Count</code>, <code>Product</code>,
                            <code>Index</code>, <code>Population StDev</code>, <code>Sample StDev</code>, <code>Population Var</code>,
                            <code>Sample Var</code>, <code>Running Totals</code>,
                            <code>Difference From</code>, <code>% of Difference From</code>, <code>% of Grand Total</code>,
                            <code>% of Column Total</code>, <code>% of Row Total</code>,
                            <code>% of Parent Total</code>, <code>% of Parent Column Total</code>, <code>% of Parent Row Total.</code>
                        </p> 

                        <p>

                         In this sample, you can also change the aggregate type for value fields at runtime using the dropdown icon via field list UI.</p>
<p>More information on the aggregation feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/aggregation/'>documentation section</a>.</p>"
                    }
            },
            new Sample
            {
                Name = "Default Sorting",
                Category = "Sorting",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/default-sorting",
                FileName = "DefaultSorting.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                       This sample demonstrates ordering fields in row and column axes either in ascending or descending order.
                    </p>"
                    },
                Description = new string[] {
                    @"<p>In this sample, any field can be selected from the <b>Fields</b> dropdown list and its order can be changed to display headers either in ascending or descending order.
                        It can be applied either through code-behind or UI. To achieve this in code-behind, set <code>EnableSorting</code> property in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewDataSourceSettings%601_members.html'>PivotViewDataSourceSettings</a></code> class to <b>true</b>. Also, set the
                                <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewSortSettings_members.html'>PivotViewSortSettings</a></code> class in the pivot table along with the following properties:
                            </p>

                        <table>
                            <tr>
                                <td style='vertical-align: top;padding: 10px 0;width:100px'>
                                    <code>Name :</code>
                                </td>
                                <td>Specifies the normal field.</td>
                            </tr>
                            <tr>
                                <td style='vertical-align: top;padding: 4px 0;'>
                                    <code>Order :</code>
                                </td>
                                <td>Specifies the sort order and it should be 'Ascending' or 'Descending' in this scenario.</td>
                            </tr>
                        </table>
                        </br>
                         <p>To achieve the same through UI, either enable grouping bar or field list or both to perform the sorting operation.</p>
<p>More information on the label sorting feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/sorting/'>documentation section</a>.</p>"
                    }
            },
            new Sample
            {
                Name = "Value Sorting",
                Category = "Sorting",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/value-sorting",
                FileName = "ValueSorting.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
This sample demonstrates ordering of values in ascending or descending order. Here, the
        <b>FY 2015 -> In Stock</b> column header text is ordered by defining sort-related settings in code behind.
                    </p>"
                },
                Description = new string[] {
                   @" <p>You can sort column values by clicking the column header. Clicking the same header once again will reverse the sorting
        direction. It can be enabled by setting the
        <code>EnableValueSorting</code> property in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.SfPivotView%601_members.html'>SfPivotView</a></code> class to <b>true</b>.
    </p>
    <p>Value sort-related settings can be defined in code behind, too. To do so, headers of the column to be sorted are given
        in the
        <code>HeaderText</code> property under
        <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewValueSortSettings_members.html'>PivotViewValueSortSettings</a></code> class, separated by a delimiter string. The purpose of providing complete header text here is to indicate exactly which
        value column needs to be sorted. The string which is used to separate the headers is given in the
        <code>HeaderDelimiters</code> property. The sorting direction is performed by the
        <code>SortOrder</code> property.</p>
<p>More information on the value sorting feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/sorting/#value-sorting'>documentation section</a>.</p>"

                }
            },
            new Sample
            {
                Name = "Default Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/default-filtering",
                FileName = "MemberFiltering.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates filtering row and column headers either by including or excluding them from the pivot table.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
    Member filtering can be applied either through code-behind or UI. To achieve this in code-behind, use the
            <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewFilterSetting_members.html'>PivotViewFilterSetting</a></code> class in the pivot table along with the following properties.
        </p>
        <table>
        <tr>
            <td style='vertical-align: top;padding: 10px 0;width:100px'>
                <code>Name :</code>
            </td>
            <td>Specifies the exact field choosen for filtering.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Type :</code>
            </td>
            <td>Specifies the filter type and it should be either 'Include' or 'Exclude' in this scenario.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Items :</code>
            </td>
            <td>Specifies the fields to be include or excluded.</td>
        </tr>
    </table>
    </br>
    <p>In this sample, we have applied member filter for the field <b>Country</b> by excluding <b>Canada</b> and <b>France</b> in code behind.</p>
    <p>To achieve the same through UI, either enable grouping bar or field list or both to perform the filtering operation.</p>
<p>More information on the member filtering feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/filtering/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Label Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/label-filtering",
                FileName = "LabelFiltering.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
    This sample demonstrates filtering row and column headers based on their text. The different conditions that can
        be applied to the text are equals, begins with, ends with, contains, etc.
</p>"

                },
                Description = new string[] {
                   @"<p>
    Label filtering can be applied either through code-behind or UI. To achieve this in code-behind, set the <code>AllowLabelFilter</code> property in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewDataSourceSettings%601_members.html'>PivotViewDataSourceSettings</a></code> class to <b>true</b> and use the
            <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewFilterSetting_members.html'>PivotViewFilterSetting</a></code> class in the pivot table along with the following properties.
        </p>

    <table>
        <tr>
            <td style='vertical-align: top;padding: 10px 0;width:100px'>
                <code>Name :</code>
            </td>
            <td>Specifies the normal field.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Type :</code>
            </td>
            <td>Specifies the filter type and it should be 'Label' in this scenario.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Condition :</code>
            </td>
            <td>Specifies the operator type like equals, greater than, less than, etc.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Value1 :</code>
            </td>
            <td>Gets the value to view the filter result.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Value2 :</code>
            </td>
            <td>For conditions like &#34;between&#34; and &#34;not between&#34;, this option will be enabled. Enter both start and end value to view the filter result.</td>
        </tr>
    </table>
    </br>
    <p>

    In this sample, we have applied the label filter for the field <b>Country</b> by showing the fields that are not equal to <b>Canada</b> in code behind.</p>

     <p>To achieve the same through UI, either enable grouping bar or field list or both to perform the filtering operation.</p>
<p>More information on the label filtering feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/filtering/#label-filtering'>documentation section</a>.</p>"

                }
            },
            new Sample
            {
                Name = "Value Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/value-filtering",
                FileName = "ValueFiltering.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
               @"<p>
    This sample demonstrates filtering row and column headers based on a specific measure and the grand total. The
        different conditions that can be applied to the grand total are equals, less than, greater than, between, etc.
</p>"
                },
                Description = new string[] {
                 @"<p>
    Value filtering can be applied either through code-behind or UI. To achieve this in code-behind, set the <code>AllowValueFilter</code> property in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewDataSourceSettings%601_members.html'>PivotViewDataSourceSettings</a></code> class to <b>true</b> and use the
        <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewFilterSetting_members.html'>PivotViewFilterSetting</a></code> class in the pivot table along with the following properties.
</p>
<table>
        <tr>
            <td style='vertical-align: top;padding: 10px 0;width:100px'>
                <code>Name :</code>
            </td>
            <td>Specifies the normal field.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Type :</code>
            </td>
            <td>Specifies the filter type. For label filtering, it should be 'Label' type and for value filtering, it should be 'Value' type.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Measure :</code>
            </td>
            <td>Specifies the value based field.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Condition :</code>
            </td>
            <td>Specifies the operator type like equals, greater than, less than, etc.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Value1 :</code>
            </td>
            <td>Gets the value to view the filter result.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Value2 :</code>
            </td>
            <td>For conditions like &#34;between&#34; and &#34;not between&#34;, this option will be enabled. Enter both start and end value to view the filter result.</td>
        </tr>
    </table>
    </br>
    <p>

    In this sample, we have applied value filtering for the measure <b>Units Sold</b> GreaterThan 20000 in <b>Year</b>.</p>
    
    <p>To achieve the same through UI, either enable grouping bar or field list or both to perform the filtering operation.</p>
<p>More information on the value filtering feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/filtering/#value-filtering'>documentation section</a>.</p>"

                }
            },
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Scrolling",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/virtual-scrolling",
                FileName = "VirtualScrolling.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @" <p>
This sample demonstrates the virtual scrolling option available for vertically and horizontally loading records
        and showing a large number of records with ease.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
The pivot table provides an optimized way to render rows and columns inside the view-port alone without
        calculating the value of the entire pivot.
        To enable virtual scrolling, set <code>EnableVirtualization</code> property in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.SfPivotView%601_members.html'>SfPivotView</a></code> class to <b>true</b>.
                    </p>
                    <br>
<p>More information on the Blazor Pivot Table can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/virtual-scrolling/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Cell Template",
                Category = "Customization",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/cell-template",
                FileName = "PivotCellTemplate.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
                        In this sample, we demonstrate on how to provide templates for each pivot table value cell based on user requirement.
                    </p>"
                    },
                Description = new string[] {
                    @"  <p>
                            The Pivot Table provides a custom layout for each cell's display using the cell template feature.
                            The <code>CellTemplate</code> in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewTemplates_members.html'>PivotViewTemplates</a></code> class accepts either an HTML string or the element's ID, which can be used to
                            append additional HTML elements in order to showcase each cell with a template.
                            To calculate the trend, we have applied conditions for each cell using 
                            <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewTemplates_members.html'>PivotViewTemplates</a></code> class. Based on the applied condition, we are showing the appropriate indicators.
                        </p>
<p>More information on the virtual scrolling feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/row-and-column/#cell-template'>documentation section</a>.</p>"
                    }
            },
            new Sample
            {
                Name = "Drill Through",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/drill-through",
                FileName = "DrillThrough.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
    This sample demonstrates how to obtain a list of raw items for a particular cell using the drill-through option
        on double-clicking.
</p>"

                },
                Description = new string[] {
                   @"<p>In this sample, you can view the raw items of any pivot table cell by double-clicking the cell. The
        drill-through dialog holds the row headers, column headers, and values information of the clicked cell.
        Initially drill-through information is displayed for bound fields and you can include the remaining raw items
        details using the <b>column chooser</b> option in the dialog.
    </p>
    <p>This feature can be enabled by setting the <code>AllowDrillThrough</code> property in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.SfPivotView%601_members.html'>SfPivotView</a></code> class to <b>true</b>.</p>
<p>More information on the drill-through feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/drill-through/'>documentation section</a>.</p>"

                }
            },
            new Sample
            {
                Name = "Editing",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/editing",
                FileName = "Editing.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
    This sample demonstrates CRUD operations performed over the raw items of any value cell in a pivot table.
        Different types of cell editing options are provided to make editing simpler.
</p>"
                },
                Description = new string[] {
@"<p>In this sample, the raw items of any value cell can be viewed in a drill-through dialog by double-clicking the
        cell. CRUD operations can be performed by double-clicking the cells or using toolbar options. The following
        CRUD operations can be performed through toolbar operations,
    </p>
    <ul>
        <li><code>Add</code> - To add new record, click <code>Add</code> in the toolbar.</li>
        <li><code>Edit</code> - To edit record, double click a cell.</li>
        <li><code>Delete</code> - To delete a record, click <code>Delete</code> in the toolbar after selected a row.
        </li>
        <li><code>Update</code>,<code>Cancel</code> - You can save or discard changes by clicking <code>Update</code>
            or <code>Cancel</code> in
            the toolbar, respectively.</li>
    </ul>
    <p>The above CRUD operations can be configured in a pivot table using <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewCellEditSettings_members.html'>PivotViewCellEditSettings</a></code> class in code behind. There are
        also
        different modes to manipulate the data source. The available modes are:</p>
    <ul>
        <li><code>Normal</code> - Editing by row.</li>
        <li><code>Batch</code> - Editing individual cells and bulk updating.</li>
        <li><code>Dialog</code> - Editing by row with a dialog option. </li>
        <li><code>Command Columns</code> - An additional column appends to the data grid with icons to perform CRUD
            operations. Editing using cell double-click is restricted here.</li>
    </ul>
<p>More information on the editing feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/editing/'>documentation section</a>.</p>"

                }
            },
            new Sample
            {
                Name = "Hyperlink",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/hyperlink",
                FileName = "HyperLink.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates showing hyperlink options in row headers, column headers, value cells, and summary cells
        in the pivot table. Also, hyperlink options can be enabled for specific headers and value cells based on the
        applied condition.</p>"
                },
                Description = new string[] {
                    @"<p>In this sample, hyperlinks are enabled in cells based on the options selected from the <b>Show Hyperlink</b>
        drop-down list.
<p>The following options are available for setting the hyperlinks:</p>

    <table>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;width:200px'>
                <code>ShowHyperlink :</code>
            </td>
            <td>Allows to set the visibility of hyperlink to all cells..</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>ShowColumnHeaderHyperlink :</code>
            </td>
            <td>Allows to set the visibility of hyperlink to column headers.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>ShowRowHeaderHyperlink :</code>
            </td>
            <td>Allows to set the visibility of hyperlink to row headers.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>ShowSummaryCellHyperlink :</code>
            </td>
            <td>Allows to set the visibility of hyperlink to summary cells.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>ShowValueCellHyperlink :</code>
            </td>
            <td>Allows to set the visibility of hyperlink to value cells.</td>
        </tr>
    </table>
</p>
<p>
In this sample, we have used the <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.PivotViewEvents%601~HyperlinkCellClicked.html'>HyperlinkCellClicked</a></code> event for further processing during cell click.</p>
<p>More information on the hyperlink feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/hyper-link/'>documentation section</a>.</p>"
                }
            },
            new Sample
            {
                Name = "Defer Layout Update",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/defer-layout-update",
                FileName = "DeferUpdate.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                    @"<p>
    This sample demonstrates the defer layout update feature of the pivot table. The defer layout update allows users
        to refresh the pivot table on-demand instead of during every UI interaction.
</p>"
                },
                Description = new string[] {
                  @"<p>
        Deferring a layout update can be useful when you need to remove or add multiple fields in a report and you don't want to
        update the pivot table after each change. Now, you can update a pivot table after performing all changes at the report level
        in the field list resulting in better performance.
    </p>
    <p>
        In this sample, the <b>Defer Layout Update</b> option can be enabled or disabled via field list UI.
    </p>
    <p>
        In general, this feature can be enabled by setting the <code>AllowDeferLayoutUpdate</code> property in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.SfPivotView%601_members.html'>SfPivotView</a></code> class to <b>true</b>.
    </p>
<p>More information on the defer update feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/defer-layout-update/'>documentation section</a>.</p>"
                }
            },


            new Sample
            {
                Name = "Export",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/export",
                FileName = "Exporting.razor",
                Type = SampleType.None,
                ActionDescription = new string[] {
                  @"<p> This sample demonstrates client-side exporting of the pivot table to Excel, CSV and PDF formats.</p>
                " },
                Description = new string[] {
                 @"<p>The pivot table supports client-side exporting and exports its data to the Excel, CSV and PDF formats data using
        the
        <code>ExcelExport</code>,
        <code>CsvExport</code> and
        <code>PdfExport</code> methods.
    </p>
    <p>
        Choose the export document type in the dropdown list available inside the property panel and click the export button to export
        the pivot table to the selected document format.
    </p>
    <p>Exporting can be enabled by setting <code>AllowPdfExport</code> and <code>AllowExcelExport</code> (for both Excel and CSV) properties in <code><a target='_blank' class='code' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.PivotView.SfPivotView%601_members.html'>SfPivotView</a></code> class to <b>true</b> for PDF, Excel and CSV exporting. </p>
<p>More information on the exporting feature can be found in this <a target='_blank' href='https://blazor.syncfusion.com/documentation/pivot-table/pdf-export/'>documentation section</a>.</p>"
   }
            }
        };
    }
}