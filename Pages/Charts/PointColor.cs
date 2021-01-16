using System.Collections.Generic;
namespace PointRender
{
    internal class PointColor
    {
        internal static List<string> MaterialColors { get; set; } = new List<string>()
        { "#00bdae", "#404041", "#357cd2", "#e56590", "#f8b883", "#70ad47", "#dd8abd", "#7f84e8", "#7bb4eb",
        "#ea7a57", "#404041", "#00bdae"};
        internal static List<string> FabricColors { get; set; } = new List<string>()
        { "#4472c4", "#ed7d31", "#ffc000", "#70ad47", "#5b9bd5",
    "#c1c1c1", "#6f6fe2", "#e269ae", "#9e480e", "#997300", "#4472c4", "#70ad47", "#ffc000", "#ed7d31"};
        internal static List<string> BootstrapColors { get; set; } = new List<string>()
        { "#a16ee5", "#f7ce69", "#55a5c2", "#7ddf1e", "#ff6ea6",
    "#7953ac", "#b99b4f", "#407c92", "#5ea716", "#b91c52"};
        internal static List<string> HighContrastColors { get; set; } = new List<string>()
        { "#79ECE4", "#E98272", "#DFE6B6", "#C6E773", "#BA98FF",
    "#FA83C3", "#00C27A", "#43ACEF", "#D681EF", "#D8BC6E"};
    };
}
