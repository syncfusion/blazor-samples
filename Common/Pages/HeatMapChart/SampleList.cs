#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
        public List<Sample> HeatMapChart { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Heatmap Chart",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            }, 
            new Sample
            {
                Name = "Calendar Heatmap",
                Category = "Heatmap Chart",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/calendar-heatmap",
                FileName = "CalendarHeatmap.razor"
            },
            new Sample
            {
                Name = "Bubble Types",
                Category = "Bubble Heatmap",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/bubble-types",
                FileName = "BubbleTypes.razor"
            },
            new Sample
            {
                Name = "Color and Size Attributes",
                Category = "Bubble Heatmap",
                Directory = "HeatMapChart/HeatMapChart",
                Type = SampleType.New,
                Url = "heatmap-chart/color-and-size-attributes",
                FileName = "ColorAndSizeAttributes.razor",
                NotificationDescription = new string[]{ @"The sample has been added to demonstrate the bubble feature based on color and size fields from the Blazor HeatMap component's data source." },
            },
            new Sample
            {
                Name = "Row",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/row",
                FileName = "Row.razor"
            },
            new Sample
            {
                Name = "Cell",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/cell",
                FileName = "Cell.razor"
            },
            new Sample
            {
                Name = "Json Row",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/json-row",
                FileName = "JsonRow.razor"
            },
            new Sample
            {
                Name = "Json Cell",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/json-cell",
                FileName = "JsonCell.razor"
            },
            new Sample
            {
                Name = "Empty Points",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/empty-points",
                FileName = "Emptypoints.razor"
            },
            new Sample 
            {
                Name = "Inversed Axis",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/inversed-axis",
                FileName = "InversedAxis.razor"
            },
            new Sample
            {
                Name = "Opposed Axis",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/opposed-axis",
                FileName = "OpposedAxis.razor"
            },
             new Sample
            {
                Name = "Multi Level Labels",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Type = SampleType.New,
                Url = "heatmap-chart/multi-level-labels",
                FileName = "MultiLevelLabels.razor",
                NotificationDescription = new string[]{ @"The sample has been added to demonstrate the multi-level label feature of the Blazor HeatMap component." },
            },
            new Sample
            {
                Name = "Legend Placement",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/legend-placement",
                FileName = "LegendPlacement.razor"
            },
            new Sample
            {
                Name = "Palette Mode",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/palette-mode",
                FileName = "PaletteMode.razor"
            },
            new Sample
            {
                Name = "Color Range",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/color-range",
                Type = SampleType.None,
                FileName = "ColorRange.razor"
            },
            new Sample
            {
                Name = "Tooltip Template",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Type = SampleType.Updated,
                Url = "heatmap-chart/tooltip-template",
                FileName = "TooltipTemplate.razor"
            }
        };    
    }
}
