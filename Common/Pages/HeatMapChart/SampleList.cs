using System.Collections.Generic;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> HeatMapChart { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Heatmap Chart",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/default-functionalities",
                MetaTitle = "Blazor HeatMapChart - Default | HeatMapChart Demos | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Default Functionalities visualizes data intensity with color gradients and axis mapping to quickly identify trends and patterns.",
                FileName = "DefaultFunctionalities.razor",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-heatmap-chart",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "DefaultFunctionalities.razor", Id = "DefaultFunctionalities" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            }, 
            new Sample
            {
                Name = "Calendar Heatmap",
                Category = "Heatmap Chart",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/calendar-heatmap",
                FileName = "CalendarHeatmap.razor",
                MetaTitle = "Blazor HeatMapChart Demos - Calendar Heatmap Examples | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Calendar Visualization",
                MetaDescription = "See how the Syncfusion Blazor HeatMap displays calendar-based patterns with time scaling and color mapping to track activity trends clearly over time.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "CalendarHeatmap.razor", Id = "CalendarHeatmap" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            },
            new Sample
            {
                Name = "Bubble Types",
                Category = "Bubble Heatmap",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/bubble-types",
                FileName = "BubbleTypes.razor",
                MetaTitle = "Blazor HeatMapChart - Bubble Types | HeatMapChart Demos | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Bubble Type Visualization",
                MetaDescription = "See how the Syncfusion Blazor HeatMap uses bubble types with color and size variations and configurable options to visualize multi-dimensional data clearly.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "BubbleTypes.razor", Id = "BubbleTypes" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            },
            new Sample
            {
                Name = "Color and Size Attributes",
                Category = "Bubble Heatmap",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/color-and-size-attributes",
                MetaTitle = "Blazor HeatMapChart Demos - Color and Size Attributes | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Color and Size Attributes",
                MetaDescription = "See how the Syncfusion Blazor HeatMap maps data using color scales and bubble sizes to represent multiple dimensions and provide deeper insights visually.",
                FileName = "ColorAndSizeAttributes.razor",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "ColorAndSizeAttributes.razor", Id = "ColorAndSizeAttributes" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            },
            new Sample
            {
                Name = "Row",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/row",
                FileName = "Row.razor",
                MetaTitle = "Blazor HeatMapChart Examples - Row | HeatMapChart Demos | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Row Data Binding",
                MetaDescription = "See how the Syncfusion Blazor Row binds structured data row-wise with mapping and rendering features to create organized and readable heatmap visualizations.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "Row.razor", Id = "Row" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            },
            new Sample
            {
                Name = "Cell",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/cell",
                FileName = "Cell.razor",
                MetaTitle = "Blazor HeatMapChart Examples - Cell | HeatMapChart Demos | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Cell Data Binding",
                MetaDescription = "See how the Syncfusion Blazor Cell maps individual values to heatmap cells with precise data binding and rendering control for accurate and detailed insights.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "Cell.razor", Id = "Cell" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            },
            new Sample
            {
                Name = "JSON Row",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/json-row",
                FileName = "JsonRow.razor",
                MetaTitle = "Blazor HeatMapChart - JSON Row | HeatMapChart Demos | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - JSON Row Data Binding",
                MetaDescription = "See how the Syncfusion Blazor JSON Row HeatMap binds JSON row data with dynamic mapping and integration support to easily visualize API-driven datasets.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "JsonRow.razor", Id = "JsonRow" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            },
            new Sample
            {
                Name = "JSON Cell",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/json-cell",
                FileName = "JsonCell.razor",
                MetaTitle = "Blazor HeatMapChart - JSON Cell | HeatMapChart Demos | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - JSON Cell Data Binding",
                MetaDescription = "See how the Syncfusion Blazor JSON Cell maps cell-specific JSON values with flexible binding and rendering to support dynamic data visualization scenarios.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "JsonCell.razor", Id = "JsonCell" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            },
            new Sample
            {
                Name = "Empty Points",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/empty-points",
                FileName = "Emptypoints.razor",
                MetaTitle = "Blazor HeatMapChart - Empty Points | HeatMapChart Demos | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Empty Points Handling",
                MetaDescription = "See how the Syncfusion Blazor HeatMap handles missing data points with placeholders and styling to maintain clarity and consistency in incomplete datasets.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "Emptypoints.razor", Id = "Emptypoints" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            },
            new Sample 
            {
                Name = "Inversed Axis",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/inversed-axis",
                FileName = "InversedAxis.razor",
                MetaTitle = "Blazor HeatMapChart - Inversed Axis | HeatMapChart Demos | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Inversed Axis Configuration",
                MetaDescription = "See how the Syncfusion Blazor Inversed Axis reverses axis directions with configurable orientation and scaling to support specialized analytical visualizations.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "InversedAxis.razor", Id = "InversedAxis" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            },
            new Sample
            {
                Name = "Opposed Axis",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/opposed-axis",
                FileName = "OpposedAxis.razor",
                MetaTitle = "Blazor HeatMapChart - Opposed Axis | HeatMapChart Demos | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Opposed Axis Placement",
                MetaDescription = "See how the Syncfusion Blazor Opposed Axis positions axes on opposite sides with layout control and alignment options to enhance comparison and readability.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "OpposedAxis.razor", Id = "OpposedAxis" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            },
            new Sample
            {
                Name = "Label Template",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/label-template",
                FileName = "LabelTemplate.razor",
                MetaTitle = "Blazor HeatMapChart Demos - Label Template Examples | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Label Template Customization",
                MetaDescription = "See how the Syncfusion Blazor Label Template customizes labels with HTML content and conditional styling to create rich and interactive visual representations.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "LabelTemplate.razor", Id = "LabelTemplate" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            }, 
             new Sample
            {
                Name = "Multi Level Labels",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/multi-level-labels",
                FileName = "MultiLevelLabels.razor",
                MetaTitle = "Blazor HeatMapChart Demos - Multi Level Labels Examples | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Multi-Level Label Visualization",
                MetaDescription = "See how the Syncfusion Blazor HeatMap displays multi level labels with grouped categories and structured axes to improve readability and interpretation.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "MultiLevelLabels.razor", Id = "MultiLevelLabels" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            },
             new Sample
            {
                Name = "Selection",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/cell-selection",
                FileName = "Selection.razor",
                MetaTitle = "Blazor HeatMapChart - Selection | HeatMapChart Demos | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Cell Selection Capability",
                MetaDescription = "See how the Syncfusion Blazor Selection enables cell selection with interaction events and highlighting to support detailed analysis and user-driven actions.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "Selection.razor", Id = "Selection" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            },
            new Sample
            {
                Name = "Legend Placement",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/legend-placement",
                FileName = "LegendPlacement.razor",
                MetaTitle = "Blazor HeatMapChart Demos - Legend Placement Examples | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Legend Placement Customization",
                MetaDescription = "See how the Syncfusion Blazor Legend Placement positions color scales with flexible layout options to improve readability and adapt to different screen sizes.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "LegendPlacement.razor", Id = "LegendPlacement" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            },
            new Sample
            {
                Name = "Palette Mode",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/palette-mode",
                FileName = "PaletteMode.razor",
                MetaTitle = "Blazor HeatMapChart - Palette Mode | HeatMapChart Demos | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Color Palette Options",
                MetaDescription = "See how the Syncfusion Blazor HeatMap applies palette modes with gradient and fixed colors to represent data distribution clearly and improve interpretation.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "PaletteMode.razor", Id = "PaletteMode" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            },
            new Sample
            {
                Name = "Color Range",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/color-range",
                Type = SampleType.None,
                FileName = "ColorRange.razor",
                MetaTitle = "Blazor HeatMapChart - Color Range | HeatMapChart Demos | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Custom Color Range Definition",
                MetaDescription = "See how the Syncfusion Blazor Color Range defines custom value ranges with segmented coloring and thresholds to improve data clarity and interpretation.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "ColorRange.razor", Id = "ColorRange" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            },
            new Sample
            {
                Name = "Tooltip Template",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/tooltip-template",
                FileName = "TooltipTemplate.razor",
                MetaTitle = "Blazor HeatMapChart Demos - Tooltip Template Examples | Syncfusion",
                HeaderText = "Blazor HeatMap Chart Example - Custom Tooltip Templates",
                MetaDescription = "See how the Syncfusion Blazor Tooltip Template shows rich hover details with formatting and contextual data to enhance user understanding and interaction.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection { FileName = "TooltipTemplate.razor", Id = "TooltipTemplate" },
                    new SourceCollection { FileName = "HeatMapData.cs", Id = "HeatMapData" }
                }
            }
        };    
    }
}
