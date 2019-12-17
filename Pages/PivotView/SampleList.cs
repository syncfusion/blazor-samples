using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> PivotTable { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "PivotTable",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Default Functionalities . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component shows the basic rendering of the pivot table with minimum configuration.",
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

        In this demo, the pivot table is populated with its minimum default settings.</p>"
                }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/RemoteData",
                FileName = "RemoteData.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Remote Data . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component demonstrate the basic rendering of the pivot table with remote data or service data.",
                ActionDescription = new string[] {
                  @"<p>This sample demonstrates basic rendering of the pivot table bound to JSON data pulled from a remote server.</p>"
                },
                Description = new string[] {
                  @"<p>The pivot table supports JSON data source. The
        <code>DataSource</code> property in <code>PivotViewDataSourceSettings</code> can be assigned with the result of DataManager to bind remote data.</p>
    The
    <code>EjsDataManager</code>, which will act as an interface between the service endpoint and the pivot table, will require the below minimal
    information to interact with service endpoint properly.
    <ul>
        <li>
            <code>EjsDataManager->Url</code> - Defines the service endpoint to fetch data.</li>
        <li>
            <code>EjsDataManager->Adaptor</code> - Defines the adaptor option. Here,
            <code>WebApiAdaptor</code> is used for remote binding.</li>
    </ul>
    In this demo, remote data is bound by assigning service data as an instance of
    <code>DataManager</code> to the
    <code>DataSource</code> property in <code>PivotViewDataSourceSettings</code>."
                }
            },
            new Sample
            {
                Name = "OLAP",
                Category = "Data Binding",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/OLAP",
                FileName = "OLAP.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . OLAP . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component demonstrate the basic rendering of the pivot table with olap datasource.",
                ActionDescription = new string[] {
                 @"<p>
    This sample demonstrates the rendering of a pivot table bound to an online SSAS OLAP cube as its data source.
        OLAP cube elements like dimension, hierarchy, measure, and others can be arranged in row, column, value, and
        slicer axes to create desired views at runtime.
</p>"
                },
                Description = new string[] {
               @"      <p>
        In this example, users can explore all of an OLAP cube and its elements and view the resultant report in a pivot
        table or pivot chart at runtime. Grouping bar and field list options are included for exploring the data. Along
        with these, toolbar options are included for switching to the pivot chart and more:
    </p>
    <table>
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
            </td>me
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
"
                }
            },
            new Sample
            {
                Name = "Pivot Chart",
                Category = "Integration",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/Chart",
                FileName = "Chart.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Pivot Chart . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component demonstrate the basic rendering of the pivot table data into a simple pivot chart.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates rendering a pivot chart using pivot data. User can explore the data through drill-up
                            and drill-down operations by clicking the grouping labels. The field list can also be used to change the report
                            at runtime.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                            In this sample, the Pivot Table component plots a chart based on the pivot report bound to it. This can be
                            achieved by setting the property <code>View</code> to <code>Chart</code> in <code>PivotViewDisplayOption</code>. The
                            built-in options are:</br></br>

                            <code>Table</code> - Renders pivot table only, which is the default type.</br>
                            <code>Chart</code> - Renders pivot chart only.</br>
                            <code>Both</code> - Renders both pivot table and pivot chart.</br>
                        </p>
                        <p>
                            The chart types can be set using the <code>Type</code> property in <code>PivotChartSeries</code> class. The built-in chart
                            types
                            are:</br>

                            <code>Column</code>, <code>Line</code>, <code>Spline</code>, <code>Bar</code>, <code>Area</code>, <code>StepArea</code>, 
                            <code>SplineArea</code>, <code>StackingColumn</code>, <code>StackingArea</code>, <code>StackingBar</code>, <code>StepLine</code></br>
                            <code>Pareto</code>, <code>Bubble</code>, <code>Scatter</code>, <code>StackingColumn100</code>, <code>StackingBar100</code>, <code>StackingArea100</code>, <code>Polar</code> and 
                            <code>Radar</code>.</br></br>


                            In the sample, the field list option is enabled, through which you can see the result in the chart by altering
                            the report dynamically.
                            </br>
                        </p>"
                    }
            },
            new Sample
            {
                Name = "FieldList",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/FieldList",
                FileName = "FieldList.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . FieldList . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component demonstrate the field list feature of the pivot table.",
                ActionDescription = new string[] {
                  @"<p>
    This sample demonstrates the grouping bar and field list feature of the pivot table. In the sample, fields are automatically populated
    from the bound data source, and it can be used to create a pivot table at runtime.
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
        <code>PivotFieldList</code> and assign data source to its
        <code>DataSourceSettings->DataSource</code> property. Simultaneously pivotgrid will be populated by passing its instance in
        the UpdateView method, inside the
        <code>EnginePopulated</code> event of field list.
        <br />
        <br />
        Additionally, user interface for calculated field, label filter, and value filter features have been enabled in
        this demo by setting the properties
        <code>AllowCalculatedField</code>,
        <code>DataSourceSettings->AllowLabelFilter</code> and <code>DataSourceSettings->AllowValueFilter</code> to true.
    </p>"
}
            },
            new Sample
            {
                Name = "Grouping Bar",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/GroupingBar",
                FileName = "GroupingBar.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Grouping Bar . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component demonstrate the grouping bar feature of the pivot table.",
                ActionDescription = new string[] {
                   @"<p>
    This sample demonstrates grouping feature of the pivot table. The grouping bar is automatically populated from the bound report, and fields can be dragged and dropped to alter the report at runtime. The fields can be sorted, filtered, and removed dynamically as well.
</p>"

                },
                Description = new string[] {
                 @"<p>The grouping bar option automatically populates fields from the bound report and allows end
        users
        to drag fields between different axes such as columns, rows, values, and filters, and create pivot table at
        runtime.
        To enable grouping bar, set the
        <code>ShowGroupingBar</code> property in <code>EjsPivotView</code> to <b>true</b>.</p>
    <p>
        Filter and sort icons allow displaying selective records and ordering them in ascending or descending order. The
        value type icon
        allows to display values based on selected aggregate type. The remove icon
        allows the user to remove the field from the report.
    </p>

    <p>

    We can also hide the sort, filter, remove and value type icon in the <code>PivotViewGroupingBarSettings</code> by setting <code>ShowSortIcon</code>, <code>ShowFilterIcon</code>, <code>ShowRemoveIcon</code> and <code>ShowValueTypeIcon</code> properties to <b>false</b>.</p>"}
            },
            new Sample
            {
                Name = "Conditional Formatting",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/ConditionalFormatting",
                FileName = "ConditionalFormatting.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Conditional Formatting . Syncfusion Blazor Components",
                MetaDescription = "This demo for Pivot Table component demonstrate formatting the appearance of the pivot table cells with values based on the applied conditions.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates formatting the appearance of pivot table cells with user-defined styles based on applied
                            conditions.
                    </p>"
                    },
                Description = new string[] {
                    @"<p>Conditional formatting works only for cells with values,
                        allowing the users to change its appearance such as background color, font color, font family, and font size
                        based on specific conditions.
                        Conditional formatting can be applied either through code behind or UI. To enable this option in code behind, set
                        <code>AllowConditionalFormatting</code> in <code>EjsPivotView</code> to <b>true</b>.
                        Use the <code>PivotViewConditionalFormatSetting</code> class in the pivot table along with the following properties.
                    </p>
                    <table>
                        <tr>
                            <td style='vertical-align: top;padding: 4px 0;'>
                                <code>Measure :</code>
                            </td>
                            <td>Specifies the value field name for which style will be applied.</td>
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
                            <td>Specifies the start value.</td>
                        </tr>
                        <tr>
                            <td style='vertical-align: top;padding: 4px 0;'>
                                <code>Value2 :</code>
                            </td>
                            <td>Specifies the end value.</td>
                        </tr>
                        <tr>
                            <td style='vertical-align: top;padding: 4px 0;'>
                                <code>Style</code>
                            </td>
                            <td>Specifies the style for the cell.</td>
                        </tr>
                    </table>

                    <p>
                    Also, we have applied conditional formatting for the fields <b>Sold Amount</b> and <b>Units Sold</b> in code behind</p>"
                }
            },
            new Sample
            {
                Name = "Selection",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/Selection",
                FileName = "Selection.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Selection . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component demonstrate the cell selection feature of the pivot table.",
                ActionDescription = new string[] {
                    @" <p>This sample demonstrates different types of grid cell selection options and an event for getting complete
        information about the selection. The selection of headers, value cells, and summary cells can be done through
        mouse and keyboard actions.
    </p>"       },
                Description = new string[] {
                    @"<p>
        This feature provides interactive support to highlight rows, columns, values, and summary cells that you select.
        Selection can be done through either mouse or keyboard interaction.
        To enable selection, set <code>AllowSelection</code>property in <code>PivotViewGridSettings</code> as true.
    </p>
    <p>The pivot table supports two types of selection which can be set using
        <code>PivotViewSelectionSettings -> Type</code> property in  <code>PivotViewGridSettings</code>. They are:</p>
    <ul>
        <li><code>Single</code> - Enabled by default. Allows the user to select single row or column or cell at a time.
        </li>
        <li><code>Multiple</code> - Allows the user to select more than one row or column or cell at the same time.</li>
    </ul>
    <p>Also, there are three modes of selection which can be set using
        <code>PivotViewSelectionSettings -> Mode</code> property in  <code>PivotViewGridSettings</code>Mode. They are:
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
        The selected cell information can be seen in the Event Trace part with the help of the <code>CellSelected</code>
        event.
    </p>"
                }
            },
            new Sample
            {
                Name = "Show/Hide Totals",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/SummaryCustomization",
                FileName = "SummaryCustomization.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Show/Hide Totals . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component demonstrate the summary customization feature of the pivot table.",
                ActionDescription = new string[] {
                 @"<p>
    This sample demonstrates showing and hiding grand totals and subtotals in rows, columns, or both at runtime.
        Also, end users can specify and hide subtotals of specific fields.
</p>"
                },
                Description = new string[] {
                 @"<p>
        You can hide grand totals in row, column, or both, To hide grand totals in both row and column, set the property
        <code>ShowGrandTotals</code> in <code>PivotViewDataSourceSettings</code> to <b>false</b>. To hide the row and column grand totals separately,
        set the property <code>ShowRowGrandTotals</code> and <code>ShowColumnGrandTotals</code> in <code>PivotViewDataSourceSettings</code> to <b>false</b>.
    </p>

    <p>

        You can hide subtotals for specific fields too. To hide subtotals for a specific field, set the
        <code>ShowSubTotals</code> property to <b>false</b> inside the field definition.
    </p>
    <p>In this sample, we can also enable or disable grand total and subtotal via toolbar by defining toolbar option(s) and setting the <code>ShowToolbar</code> property in <code>EjsPivotView</code> to <b>true</b>.</p>"                }
            },
            new Sample
            {
                Name = "Grouping",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/Grouping",
                FileName = "Grouping.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Grouping . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component demonstrate the grouping feature for date and number fields.",
                ActionDescription = new string[] {
                    @"<p>
    This sample demonstrates grouping dates in year, quarter, month, etc., and number types in ranges like 1-4, 5-8,
        etc. in row and column headers of the pivot table.
</p>"
                },
                Description = new string[] {
     @"<p>In this sample, the date type can be separated and showcased individually as year, quarter, month, or day by
        setting the appropriate option in the code.
</p>
<p>
        Grouping can be applied through code-behind using the <code>PivotViewGroupSetting</code> in the pivot table
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
    </table>"
           }
            },
            new Sample
            {
                Name = "Toolbar",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/Toolbar",
                FileName = "Toolbar.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Toolbar . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component demonstrate the toolbar feature with pivot table and pivot chart.",
                ActionDescription = new string[] {
                    @"<p>
     This sample demonstrates the toolbar options of the pivot table. The options include show or hide subtotals and grand totals, conditional formatting, and
        exporting in the pivot table.
</p>"

                },
                Description = new string[] {
                 @"<p>
    Users can change to either pivot table or pivot chart using the toolbar options. To enable toolbar set the <code>ShowToolbar</code> property in <code>EjsPivotView</code> to <b>true</b>, The toolbar options that are available are:
</p>
 <table>
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
                <code>Field List:</code>
            </td>
            <td>Provides option to alter the report dynamically through UI.</td>
        </tr>
    </table>
    <p>To define toolbar options, create a list with necessary <code>ToolbarItems</code> enumeration values and add it to the <code>Toolbar</code> property in <code>EjsPivotView</code>.</p>
"
                }
            },
            new Sample
            {
                Name = "Calculated Field",
                Category = "Formula",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/CalculatedField",
                FileName = "CalculatedField.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Calculated Field . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component shows calculated field, and it allows users to add calculated items.",
                ActionDescription = new string[] {
                    @"<p>In this sample, <b>Total Amount</b> acts as the calculated field. Users can insert a new basic arithmetic
                            expression
                            based on the existing measure items either through a dialog at runtime or through code behind.</p>"
                    },
                Description = new string[] {
                    @"<p>The calculated field feature allows users to create custom fields which are not present in the actual data source. Users
                            can
                            create these fields using basic mathematical expression collaborating with existing fields. Calculated fields
                            can
                            be created through UI dialog as well as code behind and it can be enabled by setting
                            <code>AllowCalculatedField</code> in <code>EjsPivotView</code> to <b>true</b>. Use the
                            <code>PivotViewCalculatedFieldSetting</code> property to configure the calculated field in code behind along with the following properties.
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
                        "
                    }
            },
            new Sample
            {
                Name = "Aggregation",
                Category = "Formula",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/Aggregation",
                FileName = "Aggregation.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Aggregation . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component shows different types of aggregation for value fields.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the aggregate types like sum, average, min, max, count, distinct count, and more in the
                            pivot table for quick business analysis. End users can also change the aggregation type of each field bound to
                            the value axis in the field list at runtime.
                    </p>"
                    },
                Description = new string[] {
                    @" <p>
                            The
                            aggregate type can be set using the <code>Type</code> property in <code>PivotViewValue</code>. The built-in aggregates are:
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

                         In this sample, you can also change the aggregate type for value fields at runtime using the dropdown icon via field list UI. Here we have set the aggregation type for the field <b>Sold Amount</b> to <b>Average</b> in the code behind.</p>"
                    }
            },
            new Sample
            {
                Name = "Default Sorting",
                Category = "Sorting",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/DefaultSorting",
                FileName = "DefaultSorting.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Default Sorting . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component shows ordering(sorting) of fields either in ascending or descending order.",
                ActionDescription = new string[] {
                    @"<p>
                       This sample demonstrates ordering fields in row and column axes either in ascending or descending order.
                    </p>"
                    },
                Description = new string[] {
                    @"<p>
                        Sorting can be applied either through code-behind or UI. Sort icons in fieldlist and groupingbar allow ordering the records in ascending or descending order.To achieve this in code-behind, use the
                                <code>PivotViewSortSettings</code> object in the pivot table along with the following properties.
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

                        <p>

                        In this sample we have changed the sort order of the <b>Country</b> to <b>Descending</b> and <b>Year</b> to <b>None</b> in the code behind</p>

                         <p>To achieve the same through UI, either enable grouping bar or field list or both to perform the sorting operation.</p>"
                    }
            },
            new Sample
            {
                Name = "Value Sorting",
                Category = "Sorting",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/ValueSorting",
                FileName = "ValueSorting.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Value Sorting . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component shows sorting values on column or row wise in ascending or descending order.",
                ActionDescription = new string[] {
                    @" <p>
This sample demonstrates ordering of values in ascending or descending order. Here, the
        <b>FY 2015 -> Sold Amount</b> column header text is ordered by defining sort-related settings in code behind.
                    </p>"
                },
                Description = new string[] {
                   @" <p>You can sort column values by clicking the column header. Clicking the same header once again will reverse the sorting
        direction. It can be enabled by setting the
        <code>EnableValueSorting</code> property in <code>EjsPivotView</code> to <b>true</b>.
    </p>
    <p>Value sort-related settings can be defined in code behind, too. To do so, headers of the column to be sorted are given
        in the
        <code>HeaderText</code> property under
        <code>PivotViewValueSortSettings</code>, separated by a delimiter string. The purpose of providing complete header text here is to indicate exactly which
        value column needs to be sorted. The string which is used to separate the headers is given in the property
        <code>HeaderDelimiters</code>. The sorting direction is performed by the
        <code>SortOrder</code> property.</p>"

                }
            },
            new Sample
            {
                Name = "Default Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/MemberFiltering",
                FileName = "MemberFiltering.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Default Filtering . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component demonstrate member filtering of field headers either by including or excluding them.",
                ActionDescription = new string[] {
                    @"<p>
    This sample demonstrates filtering row and column headers either by including or excluding them from the pivot table.
</p>"
                },
                Description = new string[] {
                    @"<p>
    Member filtering can be applied either through code-behind or UI. To achieve this in code-behind, use the
            <code>PivotViewFilterSetting</code> in the pivot table along with the following properties.
        </p>

    <table>
        <tr>
            <td style='vertical-align: top;padding: 10px 0;width:100px'>
                <code>Name :</code>
            </td>
            <td>Specifies the normal field.</td>
        </tr>
        <tr>l
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Type :</code>
            </td>
            <td>Specifies the filter type and it should be 'Include' or 'Exclude' in this scenario.</td>
        </tr>
        <tr>
            <td style='vertical-align: top;padding: 4px 0;'>
                <code>Items :</code>
            </td>
            <td>Specifies the fields to be include or excluded.</td>
        </tr>
    </table>
    </br>
    <p>

    In this sample, we have applied member filter for the field <b>Year</b> by excluding <b>FY 2015</b> in code behind.</p>

    <p>To achieve the same through UI, either enable grouping bar or field list or both to perform the filtering operation.</p>"
                }
            },
            new Sample
            {
                Name = "Label Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/LabelFiltering",
                FileName = "LabelFiltering.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Label Filtering . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component demonstrate label filtering of field headers either by including or excluding them.",
                ActionDescription = new string[] {
                    @"<p>
    This sample demonstrates filtering row and column headers based on their text. The different conditions that can
        be applied to the text are equals, begins with, ends with, contains, etc.
</p>"

                },
                Description = new string[] {
                   @"<p>
    Label filtering can be applied either through code-behind or UI. To achieve this in code-behind, set the <code>AllowLabelFilter</code> property in <code>PivotViewDataSourceSettings</code> to <b>true</b> and use the
            <code>PivotViewFilterSetting</code> in the pivot table along with the following properties.
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
            <td>For conditions like 'between' and 'not between', this option will be enabled. Enter both start and end value to view the filter result.</td>
        </tr>
    </table>
    </br>
    <p>

    In this sample, we have applied the label filter for the field <b>Year</b> by showing the fields that are not equal to <b>FY 2017</b> in code behind.</p>

     <p>To achieve the same through UI, either enable grouping bar or field list or both to perform the filtering operation.</p>"

                }
            },
            new Sample
            {
                Name = "Value Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/ValueFiltering",
                FileName = "ValueFiltering.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Value Filtering . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component demonstrate the filtering of field headers based on the grand total (value based).",
                ActionDescription = new string[] {
               @"<p>
    This sample demonstrates filtering row and column headers based on a specific measure and the grand total. The
        different conditions that can be applied to the grand total are equals, less than, greater than, between, etc.
</p>"
                },
                Description = new string[] {
                 @"<p>
    Value filtering can be applied either through code-behind or UI. To achieve this in code-behind, set the <code>AllowValueFilter</code> property in <code>PivotViewDataSourceSettings</code> to <b>true</b> and use the
        <code>PivotViewFilterSetting</code> in the pivot table along with the following properties.
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
            <td>For conditions like 'between' and 'not between', this option will be enabled. Enter both start and end value to view the filter result.</td>
        </tr>
    </table>
    </br>
    <p>

    In this sample, we have applied value filtering for the measure <b>Units Sold</b> GreaterThan 20000 in <b>Year</b>.</p>
    
    <p>To achieve the same through UI, either enable grouping bar or field list or both to perform the filtering operation.</p>"

                }
            },
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Scrolling",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/VirtualScrolling",
                FileName = "VirtualScrolling.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Virtual Scrolling . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component shows virtual scrolling option available vertically and horizontally to load large records with ease.",
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
        To enable virtual scrolling, set <code>EnableVirtualization</code> property to true.
                    </p>
                    <br>"
                }
            },
            new Sample
            {
                Name = "Cell Template",
                Category = "Customization",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/PivotCellTemplate",
                FileName = "PivotCellTemplate.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Cell Template . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component demonstrate cell template option on cells of the pivot table.",
                ActionDescription = new string[] {
                    @"<p>
                        In this sample, we demonstrate on how to provide templates for each pivot table value cell based on user requirement.
                    </p>"
                    },
                Description = new string[] {
                    @"  <p>
                            The Pivot Table provides a custom layout for each cell's display using the cell template feature.
                            The <code>CellTemplate</code> in <code>PivotViewTemplate</code> property accepts either an HTML string or the element's ID, which can be used to
                            append additional HTML elements in order to showcase each cell with a template.
                            Using cell templates in this sample, we are representing the revenue cost for each year with trend icons.
                        </p>"
                    }
            },
            new Sample
            {
                Name = "Editing",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/Editing",
                FileName = "Editing.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Editing . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component allows to edit, add and delete the value cells in pivot table.",
                ActionDescription = new string[] {
                    @"<p>
    This sample demonstrates CRUD operations performed over the raw items of any value cell in a pivot table.
        Different types of cell editing options are provided to make editing simpler.
</p>"
                },
                Description = new string[] {
@"<p>In the sample, the raw items of any value cell can be viewed in a drill-through dialog by double-clicking the
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
    <p>This CRUD operations can be configured in a pivot table using <code>PivotViewCellEditSettings</code> in code behind. There are
        also
        different modes to manipulate the data source.</p>
    <p>The available modes are:</p>
    <ul>
        <li><code>Normal</code> - Editing by row.</li>
        <li><code>Batch</code> - Editing individual cells and bulk updating.</li>
        <li><code>Dialog</code> - Editing by row with a dialog option. </li>
        <li><code>Command Columns</code> - An additional column appends to the data grid with icons to perform CRUD
            operations. Editing using cell double-click is restricted here.</li>
    </ul>"

                }
            },
            new Sample
            {
                Name = "Drill Through",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/DrillThrough",
                FileName = "DrillThrough.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Drill Through . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component shows the raw items of any value cells in pivot table.",
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
        details using the <code>column chooser</code> option in the dialog.
    </p>
    <p>This feature can be enabled by setting the <code>AllowDrillThrough</code> property in <code>EjsPivotView</code> to <b>true</b>.</p>"

                }
            },
            new Sample
            {
                Name = "HyperLink",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/HyperLink",
                FileName = "HyperLink.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . HyperLink . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component shows hyperlink options in row headers, column headers, value cells, and summary cells in the pivot table.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates showing hyperlink options in row headers, column headers, value cells, and summary cells
        in the pivot table. Also, hyperlink options can be enabled for specific headers and value cells based on the
        applied condition.</p>"
                },
                Description = new string[] {
                    @"<p>
    In this sample, hyperlinks are enabled in cells based on the options selected from the <code>PivotViewHyperlinkSettings</code>
<p>The available modes are:</p>

    <table>
        <tr>
            <td style='vertical-align: top;padding: 10px 0;width:200px'>
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
    </br>
</p>

<p>

In this sample, we have enabled hyperlink for row and column headers in the code behind. We have used the <code>HyperLinkCellClicked</code> event in <code>PivotViewEvents</code>.</p>"
                }
            },
            new Sample
            {
                Name = "DeferUpdate",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/DeferUpdate",
                FileName = "DeferUpdate.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Defer Update . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component demonstrate defer layout update feature of the pivot table.",
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
        In general, this feature can be enabled by setting  <code>AllowDeferLayoutUpdate</code> as true.
    </p>"
                }
            },
            new Sample
            {
                Name = "Export",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "PivotTable/Export",
                FileName = "Exporting.razor",
                Type = SampleType.New,
                TitleTag = "PivotTable . Export . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Pivot Table component demonstrate client-side exporting of the pivot table to Excel, CSV and PDF formats.",
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
    <p>Exporting can be enabled by setting <code>AllowPdfExport</code> and <code>AllowExcelExport</code> in <code>EjsPivotView</code> to <b>true</b> for PDF, Excel and CSV exporting. </p>"
   }
            }
        };
    }
}