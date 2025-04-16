#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace TextToMindMapDiagram
{
    public partial class DiagramShortCutKey
    {
#pragma warning disable CS8618
        public string ShowShortCutKey = "none";
        public TextToMindMap Parent;
#pragma warning restore CS8618
        public void ShowHideShortcutKey()
        {
            ShowShortCutKey = "none";
            int shortcutIndex = Parent.MenubarRef.WindowMenuItems.FindIndex(item => item.Text == "Show Shortcuts");
            Parent.MenubarRef.WindowMenuItems[shortcutIndex].IconCss = Parent.MenubarRef.WindowMenuItems[shortcutIndex].IconCss == "sf-icon-blank" ? "sf-icon-Selection" : "sf-icon-blank";
            Parent.MenubarRef.StateChanged();
        }

        public void RefreshShortcutKeyPanel()
        {
            StateHasChanged();
        }
    }
}
