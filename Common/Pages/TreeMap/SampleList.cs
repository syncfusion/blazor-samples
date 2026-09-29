using System.Collections.Generic;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> TreeMap { get; set; } = new List<Sample>{
           new Sample {
                Name = "Default Functionalities",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor TreeMap Examples - Default | TreeMap Demos | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor TreeMap visualizes hierarchical data using rectangles, sizing, and coloring to represent values clearly and effectively.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-treemap"
            },
            new Sample {
                Name = "Layout",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/layout",
                FileName = "Layout.razor",
                MetaTitle = "Blazor TreeMap Examples - Layout | TreeMap Demos | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Layout Types",
                MetaDescription = "See how the Syncfusion Blazor Layout arranges hierarchical data using slice dice and squarified algorithms to optimize readability and layout efficiency.",
                Type = SampleType.None
            },
            new Sample {
                Name = "Drilldown",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/drill-down",
                FileName = "Drilldown.razor",
                MetaTitle = "Blazor TreeMap Examples - Drilldown | TreeMap Demos | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Drill Down Functionality",
                MetaDescription = "See how the Syncfusion Blazor TreeMap enables drilldown navigation through hierarchy with interactive tiles and actions to explore deeper levels of data.",
                Type = SampleType.None
            },
            new Sample {
                Name = "Color Mapping",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/color-mapping",
                FileName = "ColorMapping.razor",
                MetaTitle = "Blazor TreeMap Examples - Color Mapping | TreeMap Demos | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Color Mapping",
                MetaDescription = "See how the Syncfusion Blazor TreeMap applies color mapping techniques like range, equal, and desaturation to visually differentiate data values clearly.",
                Type = SampleType.None
            },
            new Sample {
                Name = "Selection & Highlight",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/selection-highlight",
                FileName = "Selection.razor",
                MetaTitle = "Blazor TreeMap - Selection & Highlight | TreeMap Demos | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Selection and Highlighting",
                MetaDescription = "See how the Syncfusion Blazor Selection and Highlight enables interaction with hover effects and selection states to improve user engagement and insights.",
                Type = SampleType.None
            },
             new Sample {
                Name = "Label",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/label",
                FileName = "TreeMapLabel.razor",
                MetaTitle = "Blazor TreeMap Examples - Label | TreeMap Demos | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Label Customization",
                MetaDescription = "See how the Syncfusion Blazor TreeMap customizes labels with alignment, overflow handling, formatting, and styling to improve readability and data clarity.",
                Type = SampleType.None
            },
             new Sample {
                Name = "Legend",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/legend",
                FileName = "Legend.razor",
                MetaTitle = "Blazor TreeMap Examples - Legend | TreeMap Demos | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Legend Configuration",
                MetaDescription = "See how the Syncfusion Blazor TreeMap provides legends with positioning, customization, and interaction to help users interpret hierarchical data clearly.",
                Type = SampleType.None
            },
            new Sample {
                Name = "Template",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/customization",
                FileName = "Customization.razor",
                MetaTitle = "Blazor TreeMap Examples - Template | TreeMap Demos | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Custom Templates",
                MetaDescription = "See how the Syncfusion Blazor TreeMap uses templates with HTML content and layouts to create rich and customizable hierarchical data visualizations effectively.",
                Type = SampleType.None
            },
              new Sample {
                Name = "Tooltip",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/tooltip",
                FileName = "Tooltip.razor",
                MetaTitle = "Blazor TreeMap Examples - Tooltip | TreeMap Demos | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Tooltip Configuration",
                MetaDescription = "See how the Syncfusion Blazor TreeMap displays tooltips with templates and formatting on hover to provide additional context and deeper insights into data.",
                Type = SampleType.None
            },
            new Sample {
                Name = "Print & Export",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/print",
                FileName = "Print.razor",
                MetaTitle = "Blazor TreeMap Examples - Print & Export | TreeMap Demos | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Print and Export Functionality",
                MetaDescription = "See how the Syncfusion Blazor TreeMap supports printing and exporting visuals to PDF, SVG, and images for reporting, sharing, and presentation workflows.",
                Type = SampleType.None
            },
                new Sample
            {
                Name = "RTL",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/rtl",
                FileName = "Rtl.razor",
                MetaTitle = "Blazor TreeMap Demos - RTL Examples | TreeMap Demos | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Right-to-Left (RTL) Mode",
                MetaDescription = "See how the Syncfusion Blazor TreeMap supports right to left layouts with mirrored alignment and localization setting for accurate region specific data display.",
                Type = SampleType.None
            }
        };
    }
}
