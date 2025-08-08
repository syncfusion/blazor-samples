#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> PivotTable { get; set; } = new List<Sample>{
             new Sample
            {
                Name = "Overview",
                Category = "Pivot Table",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor Pivot Table Example | Overview | Syncfusion Demos",
                HeaderText = "Blazor Pivot Table Example - Overview",
                MetaDescription = "This Blazor Pivot Table overview demonstrates comprehensive data analysis with drag-drop fields, interactive filtering, and dynamic pivot operations for business intelligence.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Pivot Table",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Pivot Table Default Functionalities - Syncfusion Demos",
                HeaderText = "Blazor Pivot Table Example - Default Functionalities",
                MetaDescription = "This Blazor Pivot Table example shows default rendering of the component with minimal configuration. Explore further for details and customization options.",
                Type = SampleType.None
            },
           

            new Sample
            {
                Name = "Live Data",
                Category = "Pivot Table",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/live-data",
                FileName = "LiveData.razor",
                MetaTitle = "Blazor Pivot Table Live Data | Real-Time Analysis | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Live Data",
                MetaDescription = "This Blazor Pivot Table Live Data demonstrates real-time data analysis with automatic updates and dynamic pivot operations for live business intelligence.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/local-data",
                FileName = "LocalData.razor",
                MetaTitle = "Blazor Pivot Table Example | Local Data | Syncfusion Demos",
                HeaderText = "Blazor Pivot Table Example - Local Data",
                MetaDescription = "This Blazor Pivot Table example shows default rendering of the component with minimal configuration. Explore further for details and customization options.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/remote-data",
                FileName = "RemoteData.razor",
                MetaTitle = "Blazor Pivot Table Remote Data | API Integration | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Remote Data",
                MetaDescription = "This Blazor Pivot Table Remote Data demonstrates API integration and remote data binding for dynamic pivot analysis with external data sources.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Server-side Aggregation",
                Category = "Data Binding",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/server-side-aggregation",
                FileName = "ServerSideAggregation.razor",
                MetaTitle = "Blazor Pivot Server Aggregation | Performance | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Server-side Aggregation",
                MetaDescription = "This Blazor Pivot Table Server-side Aggregation demonstrates high-performance data processing with server-side calculations for large datasets.",
                Type = SampleType.Updated
            },

#if !(WASM)
            new Sample
            {
                Name = "OLAP",
                Category = "Data Binding",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/olap",
                FileName = "OLAP.razor",
                MetaTitle = "Blazor Pivot Table OLAP | Cube Analysis | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - OLAP",
                MetaDescription = "This Blazor Pivot Table OLAP demonstrates multidimensional data analysis with OLAP cube integration for advanced business intelligence and reporting.",
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
                MetaTitle = "Blazor Pivot Table Performance | Large Data | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Performance",
                MetaDescription = "This Blazor Pivot Table Performance demonstrates high-performance data processing and rendering capabilities for large datasets and complex pivot operations.",
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
                MetaTitle = "Blazor Pivot Table WASM Performance | WebAssembly | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Performance",
                MetaDescription = "This Blazor Pivot Table WASM Performance demonstrates optimized WebAssembly performance for large datasets and complex pivot operations in browser.",
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
                MetaTitle = "Blazor Pivot Chart Integration | Data Visualization | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Pivot Chart",
                MetaDescription = "This Blazor Pivot Chart Integration demonstrates visual data representation with interactive charts synchronized with pivot table analysis for enhanced insights.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "External Binding",
                Category = "Integration",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/external-binding",
                FileName = "ExternalBinding.razor",
                MetaTitle = "Blazor Pivot External Binding | Component Sync | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - External Binding",
                MetaDescription = "This Blazor Pivot Table External Binding demonstrates synchronization with external components for integrated dashboard and reporting solutions.",
                Type = SampleType.None
            },
              new Sample
            {
                Name = "HeatMap",
                Category = "Integration",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/heatmap",
                FileName = "HeatMap.razor",
                MetaTitle = "Blazor Pivot HeatMap Integration | Visual Analysis | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - HeatMap",
                MetaDescription = "This Blazor Pivot Table HeatMap Integration demonstrates color-coded data visualization with heatmap cells for enhanced pattern recognition and analysis.",
                Type = SampleType.None,
                NotificationDescription = new string[] { @"Added a demo to show the pivot table value cells as heatmap cells based on their range." }
            },
            new Sample
            {
                Name = "Field List",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/field-list",
                FileName = "FieldList.razor",
                MetaTitle = "Blazor Pivot Field List | Drag Drop Fields | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Field List",
                MetaDescription = "This Blazor Pivot Table Field List demonstrates interactive field management with drag-and-drop functionality for dynamic pivot table configuration.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Grouping Bar",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/grouping-bar",
                FileName = "GroupingBar.razor",
                MetaTitle = "Blazor Pivot Grouping Bar | Field Organization | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Grouping Bar",
                MetaDescription = "This Blazor Pivot Table Grouping Bar demonstrates field organization interface with drag-drop capabilities for intuitive pivot table structure management.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Conditional Formatting",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/conditional-formatting",
                FileName = "ConditionalFormatting.razor",
                MetaTitle = "Blazor Pivot Conditional Format | Visual Styling | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Conditional Formatting",
                MetaDescription = "This Blazor Pivot Table Conditional Formatting demonstrates dynamic cell styling based on data values for enhanced data visualization and pattern recognition.",
                Type = SampleType.None,
                NotificationDescription = new string[] { @"The custom toolbar demo has been updated with a new UI option ""Apply to Grand Total"" added in the conditional formatting dialog UI, that allows the conditional formatting to be applied to row and column grand totals." }
            },
            new Sample
            {
                Name = "Selection",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/selection",
                FileName = "Selection.razor",
                MetaTitle = "Blazor Pivot Table Selection | Data Selection | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Selection",
                MetaDescription = "This Blazor Pivot Table Selection demonstrates cell and range selection capabilities for detailed data analysis and interactive data exploration.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Drill Down",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/drill-down",
                FileName = "DrillDown.razor",
                MetaTitle = "Blazor Pivot Drill Down | Data Exploration | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Drill Down",
                MetaDescription = "This Blazor Pivot Table Drill Down demonstrates hierarchical data exploration with expandable rows for detailed analysis and data discovery.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Show/Hide Totals",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/show-hide-totals",
                FileName = "SummaryCustomization.razor",
                MetaTitle = "Blazor Pivot Show Hide Totals | Summary Control | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Show/Hide Totals",
                MetaDescription = "This Blazor Pivot Table Show/Hide Totals demonstrates summary customization with toggle controls for grand totals and subtotals visibility management.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Grouping",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/grouping",
                FileName = "Grouping.razor",
                MetaTitle = "Blazor Pivot Table Grouping | Data Organization | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Grouping",
                MetaDescription = "This Blazor Pivot Table Grouping demonstrates data organization with custom grouping options for enhanced data categorization and analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Toolbar",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/toolbar",
                FileName = "Toolbar.razor",
                MetaTitle = "Blazor Pivot Table Toolbar | Action Controls | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Toolbar",
                MetaDescription = "This Blazor Pivot Table Toolbar demonstrates action controls and quick access tools for efficient pivot table operations and data manipulation.",
                Type = SampleType.None,
            },            
            new Sample
            {
                Name="Keyboard Navigation",
                Category="Keyboard Navigation",
                Directory = "PivotView/PivotTable",
                Url="pivot-table/keyboard-navigation",
                FileName="PivotKeyboard.razor",
                MetaTitle = "Blazor Pivot Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Keyboard Navigation",
                MetaDescription = "This Blazor Pivot Table Keyboard Navigation demonstrates accessibility features with keyboard shortcuts for inclusive data analysis and interaction.",
                Type=SampleType.None
            },
            new Sample
            {
                Name = "Calculated Field",
                Category = "Formula",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/calculated-field",
                FileName = "CalculatedField.razor",
                MetaTitle = "Blazor Pivot Calculated Field | Custom Formulas | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Calculated Field",
                MetaDescription = "This Blazor Pivot Table Calculated Field demonstrates custom formula creation and computed fields for advanced data analysis and business calculations.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Aggregation",
                Category = "Formula",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/aggregation",
                FileName = "Aggregation.razor",
                MetaTitle = "Blazor Pivot Table Aggregation | Data Summary | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Aggregation",
                MetaDescription = "This Blazor Pivot Table Aggregation demonstrates various summary functions including sum, average, count, and custom aggregations for data analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Default Sorting",
                Category = "Sorting",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/default-sorting",
                FileName = "DefaultSorting.razor",
                MetaTitle = "Blazor Pivot Default Sorting | Data Organization | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Default Sorting",
                MetaDescription = "This Blazor Pivot Table Default Sorting demonstrates automatic data organization with ascending and descending sort options for improved data readability."
            },
            new Sample
            {
                Name = "Value Sorting",
                Category = "Sorting",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/value-sorting",
                FileName = "ValueSorting.razor",
                MetaTitle = "Blazor Pivot Value Sorting | Custom Sort Order | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Value Sorting",
                MetaDescription = "This Blazor Pivot Table Value Sorting demonstrates custom sorting based on aggregated values for advanced data organization and ranking analysis.",
                Type = SampleType.Updated
            },
            new Sample
            {
                Name = "Default Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/default-filtering",
                FileName = "MemberFiltering.razor",
                MetaTitle = "Blazor Pivot Default Filtering | Data Filter | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Default Filtering",
                MetaDescription = "This Blazor Pivot Table Default Filtering demonstrates member-based filtering with checkbox selection for focused data analysis and exploration.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Label Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/label-filtering",
                FileName = "LabelFiltering.razor",
                MetaTitle = "Blazor Pivot Label Filtering | Text Filter | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Label Filtering",
                MetaDescription = "This Blazor Pivot Table Label Filtering demonstrates text-based filtering with condition operators for precise data selection and analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Value Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/value-filtering",
                FileName = "ValueFiltering.razor",
                MetaTitle = "Blazor Pivot Value Filtering | Numeric Filter | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Value Filtering",
                MetaDescription = "This Blazor Pivot Table Value Filtering demonstrates numeric filtering with range conditions for targeted data analysis and threshold-based insights.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Scrolling",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/virtual-scrolling",
                FileName = "VirtualScrolling.razor",
                MetaTitle = "Blazor Pivot Virtual Scrolling | Performance | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Virtual Scrolling",
                MetaDescription = "This Blazor Pivot Table Virtual Scrolling demonstrates high-performance rendering for large datasets with optimized memory usage and smooth scrolling.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Paging",
                Category = "Paging",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/paging",
                FileName = "Paging.razor",
                MetaTitle = "Blazor Pivot Table Paging | Data Navigation | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Paging",
                MetaDescription = "This Blazor Pivot Table Paging demonstrates page-based data navigation for managing large datasets with customizable page sizes and navigation controls.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Cell Template",
                Category = "Customization",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/cell-template",
                FileName = "PivotCellTemplate.razor",
                MetaTitle = "Blazor Pivot Cell Template | Custom Rendering | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Cell Template",
                MetaDescription = "This Blazor Pivot Table Cell Template demonstrates custom cell rendering with HTML templates for enhanced data visualization and formatting.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Drill Through",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/drill-through",
                FileName = "DrillThrough.razor",
                MetaTitle = "Blazor Pivot Drill Through | Detailed View | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Drill Through",
                MetaDescription = "This Blazor Pivot Table Drill Through demonstrates detailed data exploration with popup views showing underlying raw data for comprehensive analysis.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Editing",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/editing",
                FileName = "Editing.razor",
                MetaTitle = "Blazor Pivot Table Editing | Data Modification | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Editing",
                MetaDescription = "This Blazor Pivot Table Editing demonstrates inline data modification capabilities with validation and update operations for interactive data management.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Hyperlink",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/hyperlink",
                FileName = "HyperLink.razor",
                MetaTitle = "Blazor Pivot Table Hyperlink | Navigation Links | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Hyperlink",
                MetaDescription = "This Blazor Pivot Table Hyperlink demonstrates clickable cell links for navigation to detailed views and external resources for enhanced user interaction.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Defer Layout Update",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/defer-layout-update",
                FileName = "DeferUpdate.razor",
                MetaTitle = "Blazor Pivot Defer Layout | Performance Optimization | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Defer Layout Update",
                MetaDescription = "This Blazor Pivot Table Defer Layout Update demonstrates performance optimization with batch updates for improved user experience during field operations.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Export",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/export",
                FileName = "Exporting.razor",
                MetaTitle = "Blazor Pivot Table Export | Data Export | Syncfusion",
                HeaderText = "Blazor Pivot Table Example - Export",
                MetaDescription = "This Blazor Pivot Table Export demonstrates data export capabilities to Excel and PDF formats for reporting and data sharing with formatting preservation."
            }            
        };
    }
}