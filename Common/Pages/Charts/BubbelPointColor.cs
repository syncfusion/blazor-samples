#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
namespace PointRender
{
    internal class BubblePointColor
    {
        internal static List<string> MaterialColors { get; set; } = new List<string>()
        { "rgba(0, 189, 174, 0.5)", "rgba(64, 64, 65, 0.5)", "rgba(53, 124, 210, 0.5)", "rgba(229, 101, 144, 0.5)", "rgba(248, 184, 131, 0.5)", "rgba(112, 173, 71, 0.5)", "rgba(221, 138, 189, 0.5)",
          "rgba(127, 132, 232, 0.5)", "rgba(123, 180, 235, 0.5)", "rgba(234, 122, 87, 0.5)", "rgba(64, 64, 65, 0.5)", "rgba(0, 189, 174, 0.5)"};
        internal static List<string> MaterialDarkColors { get; set; } = new List<string>()
        { "rgba(158, 203, 8, 0.5)", "rgba(86, 174, 255, 0.5)", "rgba(197, 122, 255, 0.5)", "rgba(97, 234, 169, 0.5)", "rgba(235, 187, 62, 0.5)", "rgba(244, 92, 92, 0.5)", "rgba(138, 119, 255, 0.5)",
          "rgba(99, 199, 255, 0.5)", "rgba(255, 132, 176, 0.5)", "rgba(247, 201, 40, 0.5)"};
        internal static List<string> FabricColors { get; set; } = new List<string>()
        { "rgba(68, 114, 196, 0.5)", "rgba(237, 125, 49, 0.5)", "rgba(255, 192, 0, 0.5)", "rgba(112, 173, 71, 0.5)", "rgba(91, 155, 213, 0.5)", "rgba(193, 193, 193, 0.5)", "rgba(111, 111, 226, 0.5)",
          "rgba(226, 105, 174, 0.5)", "rgba(158, 72, 14, 0.5)", "rgba(153, 115, 0, 0.5)", "rgba(68, 114, 196, 0.5)", "rgba(112, 173, 71, 0.5)", "rgba(255, 192, 0, 0.5)", "rgba(237, 125, 49, 0.5)"};
        internal static List<string> BootstrapColors { get; set; } = new List<string>()
        { "rgba(161, 110, 229, 0.5)", "rgba(247, 206, 105, 0.5)", "rgba(85, 165, 194, 0.5)", "rgba(125, 223, 30, 0.5)", "rgba(255, 110, 166, 0.5)", "rgba(121, 83, 172, 0.5)",
           "rgba(185, 155, 79, 0.5)", "rgba(64, 124, 146, 0.5)", "rgba(94, 167, 22, 0.5)", "rgba(185, 28, 82, 0.5)"};
        internal static List<string> HighContrastColors { get; set; } = new List<string>()
        { "rgba(121, 236, 228, 0.5)", "rgba(233, 130, 114, 0.5)", "rgba(223, 230, 182, 0.5)", "rgba(198, 231, 115, 0.5)", "rgba(186, 152, 255, 0.5)", "rgba(250, 131, 195, 0.5)", "rgba(0, 194, 122, 0.5)",
          "rgba(67, 172, 239, 0.5)", "rgba(214, 129, 239, 0.5)", "rgba(216, 188, 110, 0.5)"};
        internal static List<string> Bootstrap5Colors { get; set; } = new List<string>()
        { "rgba(38, 46, 11, 0.5)", "rgba(102, 142, 31, 0.5)", "rgba(175, 110, 16, 0.5)", "rgba(134, 44, 11, 0.5)", "rgba(31, 45, 80, 0.5)", "rgba(100, 104, 11, 0.5)", "rgba(49, 21, 8, 0.5)",
          "rgba(76, 76, 129, 0.5)", "rgba(12, 125, 160, 0.5)", "rgba(134, 44, 11, 0.5)"};
        internal static List<string> Bootstrap5DarkColors { get; set; } = new List<string>()
        { "rgba(94, 203, 155, 0.5)", "rgba(168, 96, 241, 0.5)", "rgba(235, 168, 68, 0.5)", "rgba(85, 126, 247, 0.5)", "rgba(233, 89, 155, 0.5)", "rgba(191, 197, 41, 0.5)", "rgba(59, 198, 207, 0.5)",
          "rgba(122, 104, 236, 0.5)", "rgba(116, 183, 6, 0.5)", "rgba(234, 98, 102, 0.5)"};
		internal static List<string> FluentColors { get; set; } = new List<string>()
        { "rgba(97, 69, 112, 0.5)", "rgba(76, 111, 177, 0.5)", "rgba(204, 105, 82, 0.5)", "rgba(63, 87, 154, 0.5)", "rgba(78, 160, 155, 0.5)", "rgba(110, 122, 137, 0.5)", "rgba(212, 81, 92, 0.5)",
		"rgba(230, 175, 93, 0.5)", "rgba(99, 151, 81, 0.5)", "rgba(157, 77, 105, 0.5)"};
        internal static List<string> FluentDarkColors { get; set; } = new List<string>()
        { "rgba(138, 177, 19, 0.5)", "rgba(42, 114, 213, 0.5)", "rgba(67, 183, 134, 0.5)", "rgba(88, 78, 198, 0.5)", "rgba(232, 95, 156, 0.5)", "rgba(110, 122, 137, 0.5)", "rgba(234, 98, 102, 0.5)",
		"rgba(235, 168, 68, 0.5)", "rgba(38, 188, 122, 0.5)", "rgba(188, 72, 112, 0.5)"};
        internal static List<string> TailwindColors { get; set; } = new List<string>()
        { "rgba(90, 97, 246, 0.5)", "rgba(101, 163, 13, 0.5)", "rgba(51, 65, 85, 0.5)", "rgba(20, 184, 166, 0.5)", "rgba(139, 92, 246, 0.5)", "rgba(3, 105, 161, 0.5)", "rgba(249, 115, 22, 0.5)",
          "rgba(147, 51, 234, 0.5)", "rgba(245, 158, 11, 0.5)", "rgba(21, 128, 61, 0.5)"};
        internal static List<string> TailwindDarkColors { get; set; } = new List<string>()
        { "rgba(139, 92, 246, 0.5)", "rgba(34, 211, 238, 0.5)", "rgba(248, 113, 113, 0.5)", "rgba(74, 222, 128, 0.5)", "rgba(232, 121, 249, 0.5)", "rgba(252, 211, 77, 0.5)", "rgba(249, 115, 22, 0.5)",
          "rgba(45, 212, 191, 0.5)", "rgba(244, 114, 182, 0.5)", "rgba(16, 185, 129, 0.5)"};
    };
}
