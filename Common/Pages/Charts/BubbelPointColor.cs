#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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
        { "rgba( 99, 85, 199, 0.5)", "rgba(255, 180, 0, 0.5)", "rgba(33, 150, 245, 0.5)", "rgba(247, 82, 63, 0.5)", "rgba(150, 60, 112, 0.5)", "rgba(75, 224, 188, 0.5)", "rgba(253, 116, 0, 0.5)",
          "rgba(201, 228, 34, 0.5)", "rgba(222, 61, 138, 0.5)", "rgba(22, 47, 136, 0.5)"};
        internal static List<string> Bootstrap5DarkColors { get; set; } = new List<string>()
        { "rgba(143, 128, 244, 0.5)", "rgba(255, 212, 109, 0.5)", "rgba(108, 189, 255, 0.5)", "rgba(255, 127, 113, 0.5)", "rgba(255, 109, 179, 0.5)", "rgba(99, 245, 210, 0.5)", "rgba(252, 170, 101, 0.5)",
          "rgba(236, 255, 119, 0.5)", "rgba(239, 142, 255, 0.5)", "rgba(95, 130, 253, 0.5)"};
		internal static List<string> FluentColors { get; set; } = new List<string>()
        { "rgba(26, 201, 230, 0.5)", "rgba(218, 76, 178, 0.5)", "rgba(237, 187, 64, 0.5)", "rgba(175, 75, 207, 0.5)", "rgba(255, 114, 102, 0.5)", "rgba(27, 213, 101, 0.5)", "rgba(238, 153, 61, 0.5)",
        "rgba(88, 135, 255, 0.5)", "rgba(236, 84, 141, 0.5)", "rgba(125, 57, 192, 0.5)"};
        internal static List<string> FluentDarkColors { get; set; } = new List<string>()
        { "rgba(26, 201, 230, 0.5)", "rgba(218, 76, 178, 0.5)", "rgba(237, 187, 64, 0.5)", "rgba(175, 75, 207, 0.5)", "rgba(255, 114, 102, 0.5)", "rgba(27, 213, 101, 0.5)", "rgba(238, 153, 61, 0.5)",
        "rgba(88, 135, 255, 0.5)", "rgba(236, 84, 141, 0.5)", "rgba(125, 57, 192, 0.5)"};
        internal static List<string> TailwindColors { get; set; } = new List<string>()
        { "rgba(90, 97, 246, 0.5)", "rgba(101, 163, 13, 0.5)", "rgba(51, 65, 85, 0.5)", "rgba(20, 184, 166, 0.5)", "rgba(139, 92, 246, 0.5)", "rgba(3, 105, 161, 0.5)", "rgba(249, 115, 22, 0.5)",
          "rgba(147, 51, 234, 0.5)", "rgba(245, 158, 11, 0.5)", "rgba(21, 128, 61, 0.5)"};
        internal static List<string> TailwindDarkColors { get; set; } = new List<string>()
        { "rgba(139, 92, 246, 0.5)", "rgba(34, 211, 238, 0.5)", "rgba(248, 113, 113, 0.5)", "rgba(74, 222, 128, 0.5)", "rgba(232, 121, 249, 0.5)", "rgba(252, 211, 77, 0.5)", "rgba(249, 115, 22, 0.5)",
          "rgba(45, 212, 191, 0.5)", "rgba(244, 114, 182, 0.5)", "rgba(16, 185, 129, 0.5)"};
        internal static List<string> Material3Colors { get; set; } = new List<string>()
        { "rgba(99, 85, 199, 0.5)", "rgba(0, 174, 224, 0.5)", "rgba(255, 180, 0, 0.5)", "rgba(247, 82, 63, 0.5)", "rgba(150, 60, 112, 0.5)", "rgba(253, 116, 0, 0.5)", "rgba(75, 224, 188, 0.5)",
          "rgba(33, 150, 245, 0.5)", "rgba(222, 61, 138, 0.5)", "rgba(22, 47, 136, 0.5)"};
        internal static List<string> Material3DarkColors { get; set; } = new List<string>()
        { "rgba(78, 170, 255, 0.5)", "rgba(250, 78, 171, 0.5)", "rgba(255, 245, 0, 0.5)", "rgba(23, 234, 88, 0.5)", "rgba(56, 255, 231, 0.5)", "rgba(255, 158, 69, 0.5)", "rgba(179, 243, 47, 0.5)",
          "rgba(185, 60, 228, 0.5)", "rgba(252, 86, 100, 0.5)", "rgba(155, 85, 255, 0.5)" };
        internal static List<string> Fluent2Colors { get; set; } = new List<string>()
        { "rgba(98, 0, 238, 0.5)", "rgba(9, 175, 116, 0.5)", "rgba(0, 118, 229, 0.5)", "rgba(203, 53, 135, 0.5)", "rgba(231, 145, 15, 0.5)", "rgba(3, 100, 222, 0.5)", "rgba(102, 205, 21, 0.5)",
        "rgba(243, 169, 60, 0.5)", "rgba(16, 124, 16, 0.5)", "rgba(193, 156, 0, 0.5)"};
        internal static List<string> Fluent2DarkColors { get; set; } = new List<string>()
        { "rgba(155, 180, 73, 0.5)", "rgba(42, 114, 213, 0.5)", "rgba(67, 183, 134, 0.5)", "rgba(63, 87, 154, 0.5)", "rgba(88, 78, 198, 0.5)", "rgba(232, 95, 156, 0.5)", "rgba(110, 122, 137, 0.5)",
        "rgba(234, 98, 102, 0.5)", "rgba(11, 106, 11, 0.5)", "rgba(193, 156, 0, 0.5)"};
        //internal static List<string> Fluent2HighContrastColors { get; set; } = new List<string>()
        //{ "rgba(155, 180, 73, 0.5)", "rgba(42, 114, 213, 0.5)", "rgba(67, 183, 134, 0.5)", "rgba(63, 87, 154, 0.5)", "rgba(88, 78, 198, 0.5)", "rgba(232, 95, 156, 0.5)", "rgba(110, 122, 137, 0.5)",
        //"rgba(234, 98, 102, 0.5)", "rgba(11, 106, 11, 0.5)", "rgba(193, 156, 0, 0.5)"};
    };
}
