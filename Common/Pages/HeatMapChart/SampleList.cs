#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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
                Url = "heatmap-chart/color-and-size-attributes",
                FileName = "ColorAndSizeAttributes.razor",
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
                Name = "JSON Row",
                Category = "Data Binding",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/json-row",
                FileName = "JsonRow.razor"
            },
            new Sample
            {
                Name = "JSON Cell",
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
                Name = "Label Template",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/label-template",
                FileName = "LabelTemplate.razor",
                NotificationDescription = new string[]{ @"Added a demo to demonstrate label template support, which is to add any HTML elements into the HeatMap cells, such as images, text, and so on." }
            }, 
             new Sample
            {
                Name = "Multi Level Labels",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/multi-level-labels",
                FileName = "MultiLevelLabels.razor",
            },
             new Sample
            {
                Name = "Selection",
                Category = "Features",
                Directory = "HeatMapChart/HeatMapChart",
                Url = "heatmap-chart/cell-selection",
                FileName = "Selection.razor",
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
                Url = "heatmap-chart/tooltip-template",
                FileName = "TooltipTemplate.razor"
            }
        };    
    }
}
