using System.Collections.Generic;
namespace PointRender
{
    internal class PointColor
    {
        internal static List<string> MaterialColors { get; set; } = new List<string>()
        { "#00bdae", "#404041", "#357cd2", "#e56590", "#f8b883", "#70ad47", "#dd8abd", "#7f84e8", "#7bb4eb",
          "#ea7a57", "#404041", "#00bdae"};
        internal static List<string> MaterialDarkColors { get; set; } = new List<string>()
        { "#9ECB08", "#56AEFF", "#C57AFF", "#61EAA9", "#EBBB3E", "#F45C5C", "#8A77FF", "#63C7FF", "#FF84B0",
          "#F7C928"};
        internal static List<string> FabricColors { get; set; } = new List<string>()
        { "#4472c4", "#ed7d31", "#ffc000", "#70ad47", "#5b9bd5", "#c1c1c1", "#6f6fe2", "#e269ae", "#9e480e",
          "#997300", "#4472c4", "#70ad47", "#ffc000", "#ed7d31"};
        internal static List<string> BootstrapColors { get; set; } = new List<string>()
        { "#a16ee5", "#f7ce69", "#55a5c2", "#7ddf1e", "#ff6ea6", "#7953ac", "#b99b4f", "#407c92", "#5ea716",
          "#b91c52"};
        internal static List<string> HighContrastColors { get; set; } = new List<string>()
        { "#79ECE4", "#E98272", "#DFE6B6", "#C6E773", "#BA98FF", "#FA83C3", "#00C27A", "#43ACEF", "#D681EF",
          "#D8BC6E"};
        internal static List<string> Bootstrap5Colors { get; set; } = new List<string>()
        { "#262E0B", "#668E1F", "#AF6E10", "#862C0B", "#1F2D50", "#64680B", "#311508", "#4C4C81", "#0C7DA0", 
          "#862C0B"};
        internal static List<string> Bootstrap5DarkColors { get; set; } = new List<string>()
        { "#5ECB9B", "#A860F1", "#EBA844", "#557EF7", "#E9599B", "#BFC529", "#3BC6CF", "#7A68EC", "#74B706",
          "#EA6266"};
        internal static List<string> TailwindColors { get; set; } = new List<string>()
        { "#5A61F6", "#65A30D", "#334155", "#14B8A6", "#8B5CF6", "#0369A1", "#F97316", "#9333EA", "#F59E0B",
          "#15803D"};
        internal static List<string> TailwindDarkColors { get; set; } = new List<string>()
        { "#8B5CF6", "#22D3EE", "#F87171", "#4ADE80", "#E879F9", "#FCD34D", "#F97316", "#2DD4BF", "#F472B6",
          "#10B981"};
    };
}
