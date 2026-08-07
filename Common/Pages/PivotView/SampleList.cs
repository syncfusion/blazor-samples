using System.Collections.Generic;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        private static readonly string[] NotificationAggregation = new string[] { @"This sample now includes the newly added % of running total aggregation, which calculates values as a percentage of the cumulative total, providing enhanced insights into progressive data trends and comparisons." };

        public List<Sample> PivotTable { get; set; } = new List<Sample>{
             new Sample
            {
                Name = "Overview",
                Category = "Pivot Table",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor Pivot Table Examples - Overview | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Overview",
                MetaDescription = "See how the Syncfusion Blazor PivotTable enables pivot analysis with drag and drop fields, filtering, and aggregation tools to create interactive insights.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-pivot-table"
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Pivot Table",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Pivot Table Examples - Default | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Default Functionalities renders pivot tables with basic setup, field configuration, and summaries to quickly analyze data sets.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-pivot-table"
            },
            new Sample
            {
                Name = "Classic Layout",
                Category = "Pivot Table",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/classic-layout",
                FileName = "ClassicLayout.razor",
                MetaTitle = "Blazor Pivot Table Classic Layout | Tabular View Demo | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Classic Layout displays pivot data in tabular format with ordered fields, subtotals, and totals for structured analysis.",
                HeaderText = "Blazor Pivot Table Example - Classic Layout",
                Type = SampleType.None
            },


            new Sample
            {
                Name = "Live Data",
                Category = "Pivot Table",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/live-data",
                FileName = "LiveData.razor",
                MetaTitle = "Blazor Pivot Table - Live Data | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Live Data",
                MetaDescription = "See how the Syncfusion Blazor Live Data updates pivot results in real time with dynamic aggregation and filtering to support up to date data analysis.",
                Type = SampleType.None
            },
            #if SERVER
            new Sample
            {
                Name = "Smart Pivot Table",
                Category = "Smart AI Solutions",
                Directory = "AISamples/PivotTable",
                Url = "pivot-table/ai-smart-pivot",
                FileName = "SmartPivot.razor",
                MetaTitle = "Blazor Pivot Table - Smart Pivot Table | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table - AI Powered Pivot Table Example",
                MetaDescription = "See how the Syncfusion Blazor PivotTable uses AI insights, predictive modeling, and adaptive filtering to enhance advanced business data analysis workflows.",
                Type = SampleType.AI
            },
#endif
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/local-data",
                FileName = "LocalData.razor",
                MetaTitle = "Blazor Pivot Table - Local Data | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Local Data",
                MetaDescription = "See how the Syncfusion Blazor PivotTable binds local datasets with rows, columns, and values configuration for efficient data visualization and analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/remote-data",
                FileName = "RemoteData.razor",
                MetaTitle = "Blazor Pivot Table - Remote Data | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Remote Data",
                MetaDescription = "See how the Syncfusion Blazor PivotTable connects to APIs with dynamic binding and live updates to analyze external datasets in real time efficiently.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Server-side Aggregation",
                Category = "Data Binding",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/server-side-aggregation",
                FileName = "ServerSideAggregation.razor",
                MetaTitle = "Blazor Pivot Table - Server-side Aggregation Examples | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Server-side Aggregation",
                MetaDescription = "See how the Syncfusion Blazor PivotTable performs server-side aggregation of large datasets using backend processing to improve performance and data analysis.",
                Type = SampleType.None
            },

#if !(WASM)
            new Sample
            {
                Name = "OLAP",
                Category = "Data Binding",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/olap",
                FileName = "OLAP.razor",
                MetaTitle = "Blazor Pivot Table Examples - OLAP | Pivot Table Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - OLAP",
                MetaDescription = "See how the Syncfusion Blazor PivotTable analyzes multidimensional data with OLAP cube integration and advanced querying for enterprise level reporting.",
                Type = SampleType.None
            },
#endif

#if !(WASM)
            new Sample
            {
                Name = "Performance",
                Category = "Benchmark",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/performance",
                FileName = "Performance.razor",
                MetaTitle = "Blazor Pivot Table - Performance | Pivot Table Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Performance",
                MetaDescription = "See how the Syncfusion Blazor Performance handles large datasets with optimized rendering and aggregation to ensure fast and efficient pivot operations.",
                Type = SampleType.None
            },
#else
             new Sample
            {
                Name = "Performance",
                Category = "Benchmark",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/performance-wasm",
                FileName = "Performance-WASM.razor",
                MetaTitle = "Blazor Pivot Table - Performance | Pivot Table Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Performance",
                MetaDescription = "See how the Syncfusion Blazor Performance handles large datasets with optimized rendering and aggregation to ensure fast and efficient pivot operations.",
                Type = SampleType.None

            },
#endif
             new Sample
            {
                Name = "Pivot Chart",
                Category = "Integration",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/pivot-chart",
                FileName = "Chart.razor",
                MetaTitle = "Blazor Pivot Table - Pivot Chart | Pivot Table Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Pivot Chart",
                MetaDescription = "See how the Syncfusion Blazor PivotTable visualizes pivot data with interactive charts and synchronized analysis to identify trends and patterns clearly.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pivot Chart with Field List",
                Category = "Integration",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/pivotchart-staticfieldList",
                FileName = "Chart-StaticFieldList.razor",
                MetaTitle = "Blazor Pivot Table Demos - Pivot Chart with Field List | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Pivot Chart with Field List",
                MetaDescription = "See how the Syncfusion Blazor PivotTable integrates chart visualization with field list controls to dynamically adjust and analyze pivot data effectively.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "External Binding",
                Category = "Integration",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/external-binding",
                FileName = "ExternalBinding.razor",
                MetaTitle = "Blazor Pivot Table - External Binding | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - External Binding",
                MetaDescription = "See how the Syncfusion Blazor PivotTable integrates with external components and dashboards to provide seamless and unified analytics solutions effectively.",
                Type = SampleType.None
            },
              new Sample
            {
                Name = "HeatMap",
                Category = "Integration",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/heatmap",
                FileName = "HeatMap.razor",
                MetaTitle = "Blazor Pivot Table - HeatMap | Pivot Table Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - HeatMap",
                MetaDescription = "See how the Syncfusion Blazor HeatMap displays pivot values using color coded cells and gradients to highlight trends and improve pattern recognition.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Sparkline Chart",
                Category = "Integration",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/sparkline-chart",
                FileName = "SparkLineChart.razor",
                MetaTitle = "Blazor Pivot Table - Sparkline Chart | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Sparkline Chart",
                MetaDescription = "See how the Syncfusion Blazor PivotTable displays sparkline charts within cells to highlight trends and visualize data changes clearly and effectively.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Field List",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/field-list",
                FileName = "FieldList.razor",
                MetaTitle = "Blazor Pivot Table - Field List | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Field List",
                MetaDescription = "See how the Syncfusion Blazor PivotTable provides a field list with drag and drop configuration and filtering to customize pivot structure dynamically.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Grouping Bar",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/grouping-bar",
                FileName = "GroupingBar.razor",
                MetaTitle = "Blazor Pivot Table - Grouping Bar | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Grouping Bar",
                MetaDescription = "See how the Syncfusion Blazor PivotTable provides a grouping bar with drag and drop options to simplify field arrangement and enhance data analysis workflows.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Conditional Formatting",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/conditional-formatting",
                FileName = "ConditionalFormatting.razor",
                MetaTitle = "Blazor Pivot Table - Conditional Formatting Examples | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Conditional Formatting",
                MetaDescription = "See how the Syncfusion Blazor PivotTable applies conditional formatting rules with color mapping to highlight key values and patterns in pivot data clearly.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Selection",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/selection",
                FileName = "Selection.razor",
                MetaTitle = "Blazor Pivot Table - Selection | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Selection",
                MetaDescription = "See how the Syncfusion Blazor PivotTable supports cell and range selection with interaction tools to enable precise data exploration and analysis workflows.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Drill Down",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/drill-down",
                FileName = "DrillDown.razor",
                MetaTitle = "Blazor Pivot Table - Drill Down | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Drill Down",
                MetaDescription = "See how the Syncfusion Blazor PivotTable expands hierarchical data through drill down actions to reveal detailed records and deeper analytical insights.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Show/Hide Totals",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/show-hide-totals",
                FileName = "SummaryCustomization.razor",
                MetaTitle = "Blazor Pivot Table - Show/Hide Totals | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Show/Hide Totals",
                MetaDescription = "See how the Syncfusion Blazor PivotTable toggles grand totals and subtotals with controls to customize summary views and improve data analysis clarity.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Grouping",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/grouping",
                FileName = "Grouping.razor",
                MetaTitle = "Blazor Pivot Table Examples - Grouping | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Grouping",
                MetaDescription = "See how the Syncfusion Blazor PivotTable supports grouping of data into custom categories with rules and aggregation to enhance structured data analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Toolbar",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/toolbar",
                FileName = "Toolbar.razor",
                MetaTitle = "Blazor Pivot Table Demos - Toolbar Examples | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Toolbar",
                MetaDescription = "See how the Syncfusion Blazor PivotTable provides toolbar actions with buttons and shortcuts to manage pivot operations and improve user productivity.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name="Keyboard Navigation",
                Category="Keyboard Navigation",
                Directory = "PivotView/PivotTable",
                Url="pivot-table/keyboard-navigation",
                FileName="PivotKeyboard.razor",
                MetaTitle = "Blazor Pivot Table Demos - Keyboard Navigation Examples | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor PivotTable enables keyboard navigation with shortcuts to improve accessibility and ensure efficient interaction workflows.",
                Type=SampleType.None
            },
            new Sample
            {
                Name = "Calculated Field",
                Category = "Formula",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/calculated-field",
                FileName = "CalculatedField.razor",
                MetaTitle = "Blazor Pivot Table - Calculated Field | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Calculated Field",
                MetaDescription = "See how the Syncfusion Blazor PivotTable creates calculated fields using custom formulas to support advanced business calculations and insights effectively.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Aggregation",
                Category = "Formula",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/aggregation",
                FileName = "Aggregation.razor",
                MetaTitle = "Blazor Pivot Table - Aggregation | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Aggregation",
                MetaDescription = "See how the Syncfusion Blazor PivotTable performs aggregation operations like sum, average, and count to provide meaningful and actionable data insights.",
                Type = SampleType.Updated,
                NotificationDescription = NotificationAggregation
            },
            new Sample
            {
                Name = "Default Sorting",
                Category = "Sorting",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/default-sorting",
                FileName = "DefaultSorting.razor",
                MetaTitle = "Blazor Pivot Table - Default Sorting | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Default Sorting",
                MetaDescription = "See how the Syncfusion Blazor PivotTable sorts data with ascending and descending order to improve readability and enhance analytical data exploration."
            },
            new Sample
            {
                Name = "Value Sorting",
                Category = "Sorting",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/value-sorting",
                FileName = "ValueSorting.razor",
                MetaTitle = "Blazor Pivot Table - Value Sorting | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Value Sorting",
                MetaDescription = "See how the Syncfusion Blazor PivotTable sorts data based on aggregated values to rank items efficiently and support accurate analytical decision making.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Default Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/default-filtering",
                FileName = "MemberFiltering.razor",
                MetaTitle = "Blazor Pivot Table - Default Filtering | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Default Filtering",
                MetaDescription = "See how the Syncfusion Blazor PivotTable applies member filtering with selection controls to refine and analyze pivot data accurately and efficiently.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Label Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/label-filtering",
                FileName = "LabelFiltering.razor",
                MetaTitle = "Blazor Pivot Table - Label Filtering | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Label Filtering",
                MetaDescription = "See how the Syncfusion Blazor PivotTable filters data using label conditions and operators to refine and analyze pivot data accurately and efficiently.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Value Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/value-filtering",
                FileName = "ValueFiltering.razor",
                MetaTitle = "Blazor Pivot Table - Value Filtering | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Value Filtering",
                MetaDescription = "See how the Syncfusion Blazor PivotTable applies value filtering using numeric conditions and ranges to isolate data for focused and effective analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "External Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/external-date-filtering",
                FileName = "ExternalDateFiltering.razor",
                MetaTitle = "Blazor Pivot Table Demos - External Filtering | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - External Filtering",
                MetaDescription = "See how the Syncfusion Blazor PivotTable supports external filtering using inputs and date ranges to improve data control and performance for analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Scrolling",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/virtual-scrolling",
                FileName = "VirtualScrolling.razor",
                MetaTitle = "Blazor Pivot Table - Virtual Scrolling | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Virtual Scrolling",
                MetaDescription = "See how the Syncfusion Blazor PivotTable supports virtual scrolling to handle large datasets with smooth navigation and improved rendering performance.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Paging",
                Category = "Paging",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/paging",
                FileName = "Paging.razor",
                MetaTitle = "Blazor Pivot Table Examples - Paging | Pivot Table Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Paging",
                MetaDescription = "See how the Syncfusion Blazor PivotTable supports paging to navigate large datasets using page controls and optimized rendering for better performance.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Cell Template",
                Category = "Customization",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/cell-template",
                FileName = "PivotCellTemplate.razor",
                MetaTitle = "Blazor Pivot Table - Cell Template | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Cell Template",
                MetaDescription = "See how the Syncfusion Blazor PivotTable uses cell templates with HTML and styling to customize data presentation and improve clarity and visualization.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Drill Through",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/drill-through",
                FileName = "DrillThrough.razor",
                MetaTitle = "Blazor Pivot Table - Drill Through | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Drill Through",
                MetaDescription = "See how the Syncfusion Blazor PivotTable enables drill through to view detailed records in popup views for deeper analysis and better data understanding.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Editing",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/editing",
                FileName = "Editing.razor",
                MetaTitle = "Blazor Pivot Table Demos - Editing Examples | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Editing",
                MetaDescription = "See how the Syncfusion Blazor PivotTable enables inline editing with validation tools to update pivot data dynamically and improve data management efficiency.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Hyperlink",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/hyperlink",
                FileName = "HyperLink.razor",
                MetaTitle = "Blazor Pivot Table - Hyperlink | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Hyperlink",
                MetaDescription = "See how the Syncfusion Blazor PivotTable adds hyperlinks within cells to navigate to detailed views or external resources for improved data exploration.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Defer Layout Update",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/defer-layout-update",
                FileName = "DeferUpdate.razor",
                MetaTitle = "Blazor Pivot Table Demos - Defer Layout Update Examples | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Defer Layout Update",
                MetaDescription = "See how the Syncfusion Blazor PivotTable defers layout updates to batch field changes and improve performance during pivot configuration workflows efficiently.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Default Export",
                Category = "Exporting",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/export",
                FileName = "Exporting.razor",
                MetaTitle = "Blazor Pivot Table - Default Export | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Export",
                MetaDescription = "See how the Syncfusion Blazor PivotTable exports data to Excel and PDF with formatting preserved to support efficient reporting and data sharing workflows."
            },
            new Sample
            {
                Name = "Export as Pivot",
                Category = "Exporting",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/export-as-pivot",
                FileName = "ExportAsPivot.razor",
                MetaTitle = "Blazor Pivot Table - Export as Pivot | PivotView Demos | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Export As Pivot",
                MetaDescription = "See how the Syncfusion Blazor PivotTable exports structured pivot data to Excel while preserving layout and formatting for reporting and sharing workflows.",
                Type = SampleType.None
            }
        };
    }
}