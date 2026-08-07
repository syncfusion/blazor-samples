using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Diagram;
using Syncfusion.Blazor.Inputs;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.SplitButtons;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace TextToMindMapDiagram
{
#pragma warning disable BL0005
    public partial class DiagramToolBar
    {
        /// <summary>
        /// Gets or sets the JavaScript runtime instance used for interop between C# and JavaScript in Blazor.
        /// </summary>
        /// <remarks>
        /// The JavaScript runtime is responsible for executing JavaScript code from C# and handling JavaScript interop calls.
        /// In a Blazor application, this property should be set to an instance of the IJSRuntime interface provided by the framework.
        /// </remarks>
        [Inject]
        protected IJSRuntime? jsRuntime { get; set; } = null!;
#pragma warning disable CS8618
        /// <summary>
        /// Indicates whether the toolbar is currently visible.
        /// </summary>
        internal bool ToolbarVisible { get; set; } = true;
        /// <summary>
        /// Represents the DiagramMain instance that serves as the parent.
        /// </summary>
        internal TextToMindMap Parent;
        /// <summary>
        /// The SfToolbar instance for the toolbar.
        /// </summary>
        SfToolbar Toolbar;
        /// <summary>
        /// The CSS class name for the toolbar container.
        /// </summary>
        string toolbarClassName { get; set; } = "db-toolbar-container";
        /// <summary>
        /// The CSS class name for adding a sibling tool bar item.
        /// </summary>
        string addSiblingCssName { get; set; } = "tb-item-start tb-item-sibling";
        /// <summary>
        /// The CSS class for the menu hide icon.
        /// </summary>
        private string MenuHideIconCss { get; set; } = "sf-icon-Collapse tb-icons";
        /// <summary>
        /// Represents a toolbar item for zoom functionality.
        /// </summary>
        ToolbarItem ZoomItem;
        /// <summary>
        /// The SfDropDownButton instance for the zoom item dropdown.
        /// </summary>
        SfDropDownButton ZoomItemDropdown;

        /// <summary>
        /// Represents a toolbar item for pan functionality.
        /// </summary>
        ToolbarItem PanItem;
        /// <summary>
        /// Represents a toolbar item for pan functionality.
        /// </summary>
        ToolbarItem AddChid;
        /// <summary>
        /// Represents a toolbar item for adding a sibling.
        /// </summary>
        ToolbarItem AddSibling;
        /// <summary>
        /// Represents a toolbar item for pointer functionality.
        /// </summary>
        ToolbarItem PointerItem;
        /// <summary>
        /// The CSS class for the pan item.
        /// </summary>
        public string PanItemCssClass { get; set; } = "tb-item-start tb-item-pan";
        /// <summary>
        /// The CSS class for the pointer item.
        /// </summary>
        public string PointerItemCssClass { get; set; } = "tb-item-middle tb-item-selected tb-item-pointer";
        /// <summary>
        /// Specifies whether the check box option is checked.
        /// </summary>
        public string stringChecked { get; set; } = "diagramView";
        /// <summary>
        /// The visibility setting for the mind map toolbar.
        /// </summary>
        public string MindmapToolbarVisibility { get; set; } = "block";
        /// <summary>
        /// The SfDropDownButton instance for the dropdown button.
        /// </summary>
        private SfDropDownButton dropdownBtn = null!;
        /// <summary>
        /// The SfDropDownButton instance for the another dropdown button.
        /// </summary>
        private SfDropDownButton dropdownBtn1 = null!;
        /// <summary>
        /// The content of the ZoomItemDropdown.
        /// </summary>
        public string ZoomItemDropdownContent = "100%";
#pragma warning restore CS8618
        /// <summary>
        /// Method invoked after each time the component has been rendered.
        /// </summary>
        protected override void OnAfterRender(bool firstRender)
        {
            ZoomItemDropdownContent = FormattableString.Invariant($"{Math.Round(Parent.CurrentZoom * 100)}") + "%";
            base.OnAfterRender(firstRender);
        }

        /// <summary>
        /// Opens/closes a DropDownButton popup based on current state of the DropDownButton.
        /// </summary>
        private void ClickHandler(BeforeOpenCloseEventArgs e)
        {
            dropdownBtn.Toggle();
        }
        /// <summary>
        /// Opens/closes a DropDownButton popup based on current state of the DropDownButton.
        /// </summary>
        private void ClickHandler1(BeforeOpenCloseEventArgs e)
        {
            dropdownBtn1.Toggle();
        }
        /// <summary>
        /// This method is used to update refresh the toolbar items.
        /// </summary>
        public void StateChanged()
        {
            InvokeAsync(StateHasChanged);
        }
        #region events
        /// <summary>
        /// This is used to update the zoom in/ zoom out the diagram
        /// </summary>
        private void DrawZoomChange(Syncfusion.Blazor.SplitButtons.MenuEventArgs args)
        {
            var diagram = Parent.Diagram;
            double currentZoom = Parent.CurrentZoom;
            switch (args.Item.Text)
            {
                case "Zoom In":
                    Parent.ZoomTo(new TextToMindMap.ZoomOptions() { Type = "ZoomIn", ZoomFactor = 0.2 });
                    break;
                case "Zoom Out":
                    Parent.ZoomTo(new TextToMindMap.ZoomOptions() { Type = "ZoomOut", ZoomFactor = 0.2 });
                    break;
                case "Zoom to Fit":
                    FitOptions fitoption = new FitOptions()
                    {
                        Mode = FitMode.Both,
                        Region = DiagramRegion.Content,
                    };
                    diagram!.FitToPage(fitoption);
                    break;
                case "Zoom to 50%":
                    Parent.ZoomTo(new TextToMindMap.ZoomOptions() { ZoomFactor = ((0.5 / currentZoom) - 1) });
                    break;
                case "Zoom to 100%":
                    Parent.ZoomTo(new TextToMindMap.ZoomOptions() { ZoomFactor = ((1 / currentZoom) - 1) });
                    break;
                case "Zoom to 200%":
                    Parent.ZoomTo(new TextToMindMap.ZoomOptions() { ZoomFactor = ((2 / currentZoom) - 1) });
                    break;
            }
            ZoomItemDropdownContent = FormattableString.Invariant($"{Math.Round(Parent.CurrentZoom * 100)}") + "%";
        }
        /// <summary>
        /// This is used to update the toolbar functionality
        /// </summary>
        private async Task ToolbarEditorClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
        {
            var diagram = Parent.Diagram;
            var commandType = args.Item.TooltipText.ToLower(new CultureInfo("en-US"));
            switch (commandType)
            {
                case "pan tool":
                    Parent.UpdateTool();
                    diagram!.ClearSelection();

                    break;
                case "pointer":
                    Parent.UpdatePointerTool();
                    break;
                case "delete":
                    DeleteData();
                    toolbarClassName = "db-toolbar-container db-undo";
                    break;
                case "add child":
                    if (diagram!.SelectionSettings != null && diagram.SelectionSettings.Nodes!.Count > 0)
                    {
                        diagram.StartGroupAction();
                        BranchType type = (BranchType)diagram.SelectionSettings.Nodes[0].AdditionalInfo!["Orientation"];
                        if (type == BranchType.SubRight || type == BranchType.Right)
                        {
                            await TextToMindMap.AddLeftChild(Parent.Diagram!).ConfigureAwait(false);
                        }
                        else if (type == BranchType.SubLeft || type == BranchType.Left || type == BranchType.Root)
                        {
                            await TextToMindMap.AddRightChild(Parent.Diagram!).ConfigureAwait(false);
                        }
                        diagram.ClearSelection();
                        diagram.Select(new ObservableCollection<IDiagramObject>() { diagram.Nodes![diagram.Nodes.Count - 1] });
                        diagram.EndGroupAction();
                    }
                    break;
                case "add sibling":
                    if (diagram!.SelectionSettings != null && diagram.SelectionSettings.Nodes!.Count > 0)
                    {
                        string nodeParent = diagram.SelectionSettings.Nodes[0].AdditionalInfo!["ParentId"]?.ToString() ?? string.Empty;
                        string parentID = nodeParent;
                        Node? parentNode = diagram.GetObject(parentID) as Node;
                        if (parentNode != null)
                        {
                            diagram.StartGroupAction();
                            BranchType branch = (BranchType)parentNode?.AdditionalInfo!["Orientation"]!;
                            BranchType nodeBranch = (BranchType)diagram.SelectionSettings.Nodes[0].AdditionalInfo!["Orientation"];
                            if (branch == BranchType.SubRight || branch == BranchType.Right || (branch == BranchType.Root && nodeBranch == BranchType.Right))
                            {
                                await TextToMindMap.AddLeftChild(Parent.Diagram!, true).ConfigureAwait(false);
                            }
                            else
                            {
                                await TextToMindMap.AddRightChild(Parent.Diagram!, true).ConfigureAwait(false);
                            }
                            diagram.ClearSelection();
                            diagram.Select(new ObservableCollection<IDiagramObject>() { diagram.Nodes![diagram.Nodes.Count - 1] });
                            diagram.EndGroupAction();
                        }
                    }
                    break;
            }
            if (commandType == "pan tool" || commandType == "pointer" || commandType == "text tool")
            {
                if (!args.Item.CssClass.Contains("tb-item-selected", StringComparison.Ordinal))
                {
                    if (commandType == "pan tool")
                        PanItemCssClass += " tb-item-selected";
                    if (commandType == "pointer")
                        PointerItemCssClass += " tb-item-selected";
                    await RemoveSelectedToolbarItem(commandType).ConfigureAwait(false);
                }
            }

            //Parent.DiagramContent.StateChanged();
        }
        /// <summary>
        /// This is used to delete the selected items.
        /// </summary>
        public void DeleteData()
        {
            bool GroupAction = false;
            SfDiagramComponent diagram = Parent.Diagram!;
            if ((diagram.SelectionSettings!.Nodes!.Count > 1 || diagram.SelectionSettings.Connectors!.Count > 1 || ((diagram.SelectionSettings.Nodes.Count + diagram.SelectionSettings.Connectors.Count) > 1)))
            {
                GroupAction = true;
            }
            if (GroupAction)
            {
                diagram.StartGroupAction();
            }
            if (diagram.SelectionSettings.Nodes.Count != 0)
            {
                for (var i = diagram.SelectionSettings.Nodes.Count - 1; i >= 0; i--)
                {
                    var item = diagram.SelectionSettings.Nodes[i];

                    diagram.Nodes!.Remove(item);
                }
            }
            if (diagram.SelectionSettings.Connectors!.Count != 0)
            {
                for (var i = diagram.SelectionSettings.Connectors.Count - 1; i >= 0; i--)
                {
                    var item1 = diagram.SelectionSettings.Connectors[i];

                    diagram.Connectors!.Remove(item1);
                }
            }
            if (GroupAction)
                diagram.EndGroupAction();
        }
        /// <summary>
        /// This is used to remove the selected toolbar item.
        /// </summary>
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        private async Task RemoveSelectedToolbarItem(string tool)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            if (tool != "pan tool" && PanItemCssClass.Contains("tb-item-selected", StringComparison.Ordinal))
            {
                PanItemCssClass = PanItemCssClass.Replace(" tb-item-selected", "", StringComparison.Ordinal);
            }
            if (tool != "pointer" && PointerItemCssClass.Contains("tb-item-selected", StringComparison.Ordinal))
            {
                PointerItemCssClass = PointerItemCssClass.Replace(" tb-item-selected", "", StringComparison.Ordinal);
            }

            StateHasChanged();
        }
        #endregion
        /// <summary>
        /// This is used to remove the selected toolbar items.
        /// </summary>

        public void SingleSelectionToolbarItems()
        {
            //bool diagram = Parent.DiagramContent.diagramSelected;
            StateHasChanged();
        }
        public void MutipleSelectionToolbarItems()
        {
            //bool diagram = Parent.DiagramContent.diagramSelected;
            SingleSelectionToolbarItems();

            StateHasChanged();
        }
        public void DiagramSelectionToolbarItems()
        {
            SingleSelectionToolbarItems();
        }
        /// <summary>
        /// This is used to update the zoom value.
        /// </summary>
        public void DiagramZoomValueChange()
        {
            ZoomItemDropdownContent = FormattableString.Invariant($"{Math.Round(Parent.CurrentZoom * 100)}") + "%";
            StateHasChanged();
        }

        #region public methods
        /// <summary>
        /// This is used to enable the toolbar items.
        /// </summary>
        public void EnableToolbarItems<T>(T obj, string eventname)
        {

            SfDiagramComponent diagram = Parent.Diagram!;
            ObservableCollection<NodeBase> collection = new ObservableCollection<NodeBase>();
            if (eventname == "selectionchange")
            {
                ObservableCollection<IDiagramObject>? list = obj as ObservableCollection<IDiagramObject>;
                if (list != null && list.Count > 0)
                {
                    for (int i = 0; i < (list?.Count ?? 0); i++)
                    {
                        NodeBase node = (NodeBase)list![i];
                        collection.Add(node);
                    }
                }
                UtilityMethods_enableToolbarItems(collection);
            }

            if (eventname == "historychange")
            {
                RemoveUndo();
                RemoveRedo();
                if (diagram.HistoryManager!.CanUndo)
                {
                    this.Parent.IsUndo = diagram.HistoryManager.CanUndo;
                    this.Parent.IsRedo = diagram.HistoryManager.CanRedo;
                    toolbarClassName += " db-undo";
                }
                if (diagram.HistoryManager.CanRedo)
                {
                    this.Parent.IsRedo = diagram.HistoryManager.CanRedo;
                    this.Parent.IsUndo = diagram.HistoryManager.CanUndo;
                    toolbarClassName += " db-redo";
                }
                StateHasChanged();
            }
        }
        /// <summary>
        /// This is used to remove the undo selection.
        /// </summary>
        public void RemoveUndo()
        {
            string undo = "undo";
            if (toolbarClassName.Contains(undo, StringComparison.Ordinal))
            {
                int first = toolbarClassName.IndexOf(undo, StringComparison.Ordinal);
                toolbarClassName = toolbarClassName.Remove(first - 4, 8);
            }
        }
        /// <summary>
        /// This is used to remove the redo selection.
        /// </summary>
        public void RemoveRedo()
        {
            string redo = "redo";
            if (toolbarClassName.Contains(redo, StringComparison.Ordinal))
            {
                int first = toolbarClassName.IndexOf(redo, StringComparison.Ordinal);
                toolbarClassName = toolbarClassName.Remove(first - 4, 8);
            }
        }
        /// <summary>
        /// This is used to enable the toolbar items.
        /// </summary>
        public void UtilityMethods_enableToolbarItems(ObservableCollection<NodeBase> SelectedObjects)
        {
            ArgumentNullException.ThrowIfNull(SelectedObjects);
            SfDiagramComponent diagram = Parent.Diagram!;
            removeClassElement();
            if (this.Parent.IsUndo)
            {
                toolbarClassName += " db-undo";
            }
            if (this.Parent.IsRedo)
            {
                toolbarClassName += " db-redo";
            }
            if (SelectedObjects.Count > 0)
            {
                Node rootNode = diagram.Nodes!.Where(node => node.InEdges!.Count == 0).ToList()[0];
                toolbarClassName = toolbarClassName + " db-child-sibling";
                addSiblingCssName = SelectedObjects[0].ID == rootNode.ID ? "tb-item-start tb-item-sibling" : "tb-item-start tb-item-child";
            }
            StateHasChanged();
        }
        /// <summary>
        /// This is used to remove the toolbar items class name.
        /// </summary>
        public void removeClassElement()
        {
            string space = " ";
            if (toolbarClassName.Contains(space, StringComparison.Ordinal))
            {
                int first = toolbarClassName.IndexOf(space, StringComparison.Ordinal);
                if (first != 0)
                {
                    toolbarClassName = toolbarClassName.Remove(20);
                }
            }

        }
        /// <summary>
        /// This is used to remove the toolbar items.
        /// </summary>
        private async Task HideToolBar()
        {
#pragma warning disable CA1307 // Specify StringComparison
            if (MenuHideIconCss.Contains("sf-icon-Collapse"))
#pragma warning restore CA1307 // Specify StringComparison
            {
                MenuHideIconCss = "sf-icon-DownArrow tb-icons";
            }
            else
            {
                MenuHideIconCss = "sf-icon-Collapse tb-icons";
            }
            if (jsRuntime != null)
                await jsRuntime.InvokeAsync<object>("hideMenubar").ConfigureAwait(true);
        }

        /// <summary>
        /// This is used to remove the toolbar items.
        /// </summary>
        public async Task HideElements(string eventname, bool isNewClick = false)
        {
            if (jsRuntime != null)
            {
                int adjustableHeight = Parent.MenubarRef!.WindowMenuItems[0].IconCss == "sf-icon-Selection" ? 0 : 40;
                Parent.height = (await jsRuntime.InvokeAsync<int>("UtilityMethods_hideElements", eventname, isNewClick).ConfigureAwait(true) + adjustableHeight).ToString(System.Globalization.CultureInfo.InvariantCulture) + "px";
                Parent.StateChanged();
            }
        }
        #endregion
    }
#pragma warning restore BL0005
}
