#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Blazor.Inputs;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.Diagram;
using Syncfusion.PdfExport;
using System.Collections.ObjectModel;
using Syncfusion.Blazor.SplitButtons;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System;
using BlazorDemos.Model;
using System.Linq;

namespace TextToMindMapDiagram
{
    public partial class DiagramMenuBar
    {
#pragma warning disable CS8618
        /// <summary>
        /// Object reference for  diagram print dialog box.
        /// </summary>
        DiagramPrintDialog PrintDialogBox;
        /// <summary>
        /// Object reference for  diagram export dialog box.
        /// </summary>
        DiagramExportDialog ExportDialogBox;
        /// <summary>
        /// Object reference for  diagram save dialog box.
        /// </summary>
        DiagramSaveDialog SaveDialogBox;
        /// <summary>
        /// Object reference for file option in menu bar.
        /// </summary>
        SfDropDownButton FileButton;
        /// <summary>
        /// Object reference for window option in menu bar.
        /// </summary>
        SfDropDownButton WindowButton;
        /// <summary>
        /// Object reference for view option in menu bar.
        /// </summary>
        SfDropDownButton ViewButton;
        /// <summary>
        /// Object reference for Edit option in menu bar.
        /// </summary>
        SfDropDownButton EditButton;
        /// <summary>
        /// The SfUploader instance for uploading files.
        /// </summary>
        Syncfusion.Blazor.Inputs.SfUploader UploadFiles;
        /// <summary>
        /// The default extension type for the diagram.
        /// </summary>
        string ExtensionType = ".json";
        /// <summary>
        /// Object reference for context menu items in menu bar.
        /// </summary>
        SfContextMenu<ContextMenuItemModel> ContextMenu;
        /// <summary>
        /// A collection of strings used to disable certain functionalities.
        /// </summary
        private List<string> disableCollection;
        /// <summary>
        /// A boolean value indicating whether the 'Paste' button is enabled.
        /// </summary>
        public bool enablePasteButten = false;
        /// <summary>
        /// A boolean value indicating whether the 'New option in menubar item' is clicked or not.
        /// </summary>
        public bool IsNewClick = false;
        /// <summary>
        /// The CSS class for the menu bar.
        /// </summary>
        private string menuClass { get; set; } = "db-diagram-name-container";
        /// <summary>
        /// Gets or sets the name of the diagram.
        /// </summary>
        private string diagramName { get; set; } = "Text to Diagram";
        /// <summary>
        /// Object reference for DiagramMain class.
        /// </summary>
        internal TextToMindMap Parent;
        public bool IsDuplicate = false;
        public bool IsJsonLoading = false;
#pragma warning restore CS8618
        /// <summary>
        /// Represents a context menu item for a menu bar option.
        /// </summary>
        public class ContextMenuItemModel
        {
            public List<ContextMenuItemModel> Items { get; set; }
            public string Text { get; set; }
            public string Id { get; set; }
            public string IconCss { get; set; }
            public Boolean Separator { get; set; }
            public Boolean Disabled { get; set; }
        }


        private void DropDownButtonOpen()
        {
            this.ItemSelection();
            for (int i = 0; i < FileMenuItems.Count; i++)
            {
                if (disableCollection.IndexOf(FileMenuItems[i].Text) > -1)
                {
                    FileMenuItems[i].Disabled = true;
                }
                else
                {

                    FileMenuItems[i].Disabled = false;
                }
            }
        }
        /// <summary>
        /// This method is invoked when click the menu bar items.
        /// </summary>
        public void OnMenuCreated()
        {
            ContextMenu.OpenAsync();
        }
        /// <summary>
        /// This method is invoked when click the Edit menu items in the Menu bar.
        /// </summary>
        private void DropDownfileOpenButtonOpen()
        {
            this.ItemSelection();
            for (int i = 0; i < EditMenuItems.Count; i++)
            {
                if (disableCollection.IndexOf(EditMenuItems[i].Text) > -1)
                {
                    EditMenuItems[i].Disabled = true;
                }
                else
                {

                    EditMenuItems[i].Disabled = false;
                }
            }

        }
        /// <summary>
        /// This method is invoked when click the View menu items in the Menu bar.
        /// </summary>
        private void DropDownViewButtonOpen()
        {
            this.ItemSelection();
            for (int i = 0; i < ViewMenuItems.Count; i++)
            {
                if (disableCollection.IndexOf(ViewMenuItems[i].Text) > -1)
                {
                    ViewMenuItems[i].Disabled = true;
                }
                else
                {
                    ViewMenuItems[i].Disabled = false;
                }
            }
        }
        /// <summary>
        /// This method is invoked when click the Window menu items in the Menu bar.
        /// </summary>
        private void DropDownWindowButtonOpen()
        {
            this.ItemSelection();
        }
        /// <summary>
        /// Gets the list of Edit menu items within the menu bar.
        /// </summary>
        internal List<ContextMenuItemModel> EditMenuItems = new List<ContextMenuItemModel>
    {
        new   ContextMenuItemModel {Id ="EditMenuItemsUndo", Text= "Undo", IconCss="sf-icon-Undo" },
        new   ContextMenuItemModel { Id ="EditMenuItemsRedo",Text= "Redo", IconCss="sf-icon-Redo" },
        new   ContextMenuItemModel { Separator= true },
        new   ContextMenuItemModel { Id ="EditMenuItemsCut",Text= "Cut", IconCss="sf-icon-Cut" },
        new   ContextMenuItemModel { Id ="EditMenuItemsCopy",Text= "Copy", IconCss="sf-icon-Copy" },
        new   ContextMenuItemModel {Id ="EditMenuItemsPaste", Text= "Paste", IconCss="sf-icon-Paste" },
        new   ContextMenuItemModel {Id ="EditMenuItemsDelete", Text= "Delete", IconCss="sf-icon-Delete" },
        new   ContextMenuItemModel { Separator= true },
        new   ContextMenuItemModel {Id ="EditMenuItemsDuplicate", Text= "Duplicate", IconCss = "sf-icon-blank" },
    };
        /// <summary>
        /// Gets the list of File menu items within the menu bar.
        /// </summary>
        internal List<ContextMenuItemModel> FileMenuItems = new List<ContextMenuItemModel>
    {
        new   ContextMenuItemModel {Id ="FileMenuItemsNew", Text = "New", IconCss = "sf-icon-New" },
        new   ContextMenuItemModel {Id ="FileMenuItemsOpen", Text = "Open", IconCss = "sf-icon-Open" },
        new   ContextMenuItemModel { Separator = true },
        new   ContextMenuItemModel { Id ="FileMenuItemsSave",Text = "Save", IconCss="sf-icon-Save" },
        new   ContextMenuItemModel { Id ="FileMenuItemsSaveAs",Text = "Save As", IconCss = "sf-icon-SaveAs" },
        new   ContextMenuItemModel {Id ="FileMenuItemsExport", Text = "Export", IconCss="sf-icon-Export" },
        new   ContextMenuItemModel { Separator = true},
        new   ContextMenuItemModel { Id ="FileMenuItemsPrint",Text = "Print",  IconCss="sf-icon-Print" }

    };
        /// <summary>
        /// Gets the list of view menu items within the menu bar.
        /// </summary>
        public List<ContextMenuItemModel> ViewMenuItems = new List<ContextMenuItemModel>
    {
        new ContextMenuItemModel { Id ="ViewMenuItemsZoomIn",Text="Zoom In", IconCss="sf-icon-ZoomIn" },
        new ContextMenuItemModel { Id ="ViewMenuItemsZoomOut",Text="Zoom Out", IconCss="sf-icon-ZoomOut" },
        new ContextMenuItemModel { Separator= true },
        new ContextMenuItemModel { Text ="Fit To Screen", IconCss = "sf-icon-blank" },
        new ContextMenuItemModel { Separator= true },
        new ContextMenuItemModel { Text="Show Grid" ,IconCss="sf-icon-Selection"},
    };
        /// <summary>
        /// Gets the list of Window menu items within the menu bar.
        /// </summary>
        internal List<ContextMenuItemModel> WindowMenuItems = new List<ContextMenuItemModel>
    {
        new   ContextMenuItemModel { Text="Show Toolbar",IconCss="sf-icon-Selection" },
        new   ContextMenuItemModel { Text="Show Shortcuts",IconCss="sf-icon-blank"},
    };
        /// <summary>
        /// Method invoked after each time the component has been rendered.
        /// </summary>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender)
            {
                if (SaveDialogBox != null)
                    SaveDialogBox.Parent = this;
                if (ExportDialogBox != null)
                    ExportDialogBox.Parent = this;
                if (PrintDialogBox != null)
                    PrintDialogBox.Parent = this;
            }
        }
        /// <summary>
        ///  This method is triggered when click any menu bar item.
        /// </summary>
        private async Task MenuClick(Syncfusion.Blazor.Navigations.MenuEventArgs<ContextMenuItemModel> args)
        {
            bool Edit = false;
            bool File = false;
            bool Window = false;
            bool view = false;
            Syncfusion.Blazor.Diagram.SfDiagramComponent diagram = Parent.Diagram;
            string commandType = args.Item.Text.Replace(" ", "");
            switch (commandType.ToLower())
            {
                case "new":
                    File = true;
                    diagram.Clear();
                    enablePasteButten = false;
                    diagram.BeginUpdate();
                    WindowMenuItems[1].IconCss = "sf-icon-Selection";
                    Parent.DiagramShortCutKeyRef.ShowShortCutKey = "block";
                    Parent.UpdatePointerTool();
                    Parent.Toolbar.PointerItemCssClass = "tb-item-middle tb-item-selected tb-item-pointer";
                    Parent.Toolbar.PanItemCssClass = "tb-item-start tb-item-pan";
                    await Parent.Toolbar.HideElements("hide-toolbar", true);
                    WindowMenuItems[0].IconCss = "sf-icon-Selection";
                    Parent.Toolbar.StateChanged();
                    Parent.DiagramShortCutKeyRef.RefreshShortcutKeyPanel();
                    this.ItemSelection();
                    StateHasChanged();
                    break;
                case "open":
                    File = true; IsJsonLoading = true;
                    await OpenUploadBox(true, ".json");
                    IsJsonLoading = false;
                    break;
                case "undo":
                    Edit = true;
                    if (diagram.SelectionSettings.Nodes.Count > 1 || diagram.SelectionSettings.Connectors.Count > 1)
                    {
                        diagram.StartGroupAction();
                    }
                    diagram.Undo();
                    if (diagram.SelectionSettings.Nodes.Count > 1 || diagram.SelectionSettings.Connectors.Count > 1)
                    {
                        diagram.EndGroupAction();
                    }
                    break;
                case "redo":
                    Edit = true;
                    if (diagram.SelectionSettings.Nodes.Count > 1 || diagram.SelectionSettings.Connectors.Count > 1)
                    {
                        diagram.StartGroupAction();
                    }
                    diagram.Redo();
                    if (diagram.SelectionSettings.Nodes.Count > 1 || diagram.SelectionSettings.Connectors.Count > 1)
                    {
                        diagram.EndGroupAction();
                    }
                    break;
                case "cut":
                    Edit = true;
                    diagram.Cut();
                    enablePasteButten = true;
                    break;
                case "copy":
                    Edit = true;
                    enablePasteButten = true;
                    diagram.Copy();
                    break;
                case "paste":
                    Edit = true;
                    diagram.Paste();
                    break;
                case "delete":
                    Edit = true;
                    bool GroupAction = false;
                    diagram.BeginUpdate();
                    if (diagram.SelectionSettings.Nodes.Count > 1 || diagram.SelectionSettings.Connectors.Count > 1 || ((diagram.SelectionSettings.Nodes.Count + diagram.SelectionSettings.Connectors.Count) > 1))
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

                            diagram.Nodes.Remove(item);
                        }
                    }
                    if (diagram.SelectionSettings.Connectors.Count != 0)
                    {
                        for (var i = diagram.SelectionSettings.Connectors.Count - 1; i >= 0; i--)
                        {
                            var item1 = diagram.SelectionSettings.Connectors[i];

                            diagram.Connectors.Remove(item1);
                        }
                    }
                    if (GroupAction)
                    {
                        diagram.EndGroupAction();
                    }
                    await diagram.EndUpdate();
                    break;
                case "duplicate":
                    Edit = true; IsDuplicate = true;
                    diagram.Copy();
                    diagram.Paste(); IsDuplicate = false;
                    break;
                case "save":
                    File = true;
                    string fileName = diagramName;
                    await Download(fileName);
                    break;
                case "saveas":
                    File = true;
                    SaveDialogBox.diagramfileName = diagramName;
                    await SaveDialogBox.SaveDialog.ShowAsync();
                    break;
                case "print":
                    File = true;
                    await PrintDialogBox.PrintDialog.ShowAsync();
                    break;
                case "export":
                    File = true;
                    await ExportDialogBox.ExportDialog.ShowAsync();
                    break;
                case "showtoolbar":
                    Window = true;
                    WindowMenuItems[0].IconCss = WindowMenuItems[0].IconCss == "sf-icon-Selection" ? "sf-icon-Remove" : "sf-icon-Selection";
                    await Parent.Toolbar.HideElements("hide-toolbar");
                    StateHasChanged();
                    break;
                case "showshortcuts":
                    Window = true;
                    Parent.ShowHideShortcutKey();
                    break;
                case "showgrid":
                    view = true;
                    diagram.BeginUpdate();
                    Parent.SnapConstraint = Parent.SnapConstraint ^ SnapConstraints.ShowLines;
                    await diagram.EndUpdate();
                    ViewMenuItems[5].IconCss = ViewMenuItems[5].IconCss == "sf-icon-blank" ? "sf-icon-Selection" : "sf-icon-blank";
                    break;
                case "fittoscreen":
                    view = true;
                    FitOptions fitoption = new FitOptions()
                    {
                        Mode = FitMode.Both,
                        Region = DiagramRegion.Content,
                    };
                    Parent.Diagram.FitToPage(fitoption);
                    break;
                case "zoomin":
                    view = true;
                    Parent.ZoomTo(new TextToMindMap.ZoomOptions() { Type = "ZoomIn", ZoomFactor = 0.2 });
                    Parent.Toolbar.DiagramZoomValueChange();
                    break;
                case "zoomout":
                    view = true;
                    Parent.ZoomTo(new TextToMindMap.ZoomOptions() { Type = "ZoomOut", ZoomFactor = 0.2 });
                    Parent.Toolbar.DiagramZoomValueChange();
                    break;
            }
            if (Edit)
                EditButton.Toggle();
            if (File)
                FileButton.Toggle();
            if (Window)
                WindowButton.Toggle();
            if (view)
                ViewButton.Toggle();
        }
        /// <summary>
        /// This method is used to opens the upload box to select files for uploading.
        /// </summary>
        public async Task OpenUploadBox(bool isOpen, string extensionType)
        {
            ExtensionType = extensionType;
            await FileUtil.Click(jsRuntime);
            StateHasChanged();
        }
        /// <summary>
        /// This method is used to show the menubar items.
        /// </summary>
        public void ItemSelection()
        {
            List<string> DisableCollection = new List<string>();
            double DiagramCount = Parent.Diagram.Nodes.Count + Parent.Diagram.Connectors.Count;
            ObservableCollection<object> collection = new ObservableCollection<object>();
            var nodes = Parent.Diagram.SelectionSettings.Nodes;
            var connectors = Parent.Diagram.SelectionSettings.Connectors;

            foreach (Node node in nodes)
            {
                collection.Add(node);
            }
            foreach (Connector connector in connectors)
            {
                collection.Add(connector);
            }
            Node node1 = new Node();
            Node node2 = new Node();
            Connector connector1 = new Connector();
            if (collection != null)
            {
                node1 = collection.Count > 0 ? collection[0] as Node : null;
                node2 = collection.Count > 0 ? collection[0] as NodeGroup : null;
                connector1 = collection.Count > 0 ? collection[0] as Connector : null;
            }

            bool isLock = ((node1 != null && node1.Constraints.HasFlag(NodeConstraints.Drag)) || (connector1 != null && connector1.Constraints.HasFlag(ConnectorConstraints.Drag))) ? false : true;
            Dictionary<string, bool> Select = new Dictionary<string, bool>();
            if (collection != null)
            {
                Select = new Dictionary<string, bool>()
{
            {"Undo",!Parent.IsUndo},
            {"Redo",!Parent.IsRedo},
            {"Cut",collection.Count == 0?true:false},
            {"Copy",collection.Count == 0?true:false},
            {"Paste",!enablePasteButten},
            {"Delete",collection.Count == 0?true:false},
            {"Duplicate",collection.Count == 0?true:false},
            {"Select All",DiagramCount == 0?true:false},
        };
            }
            foreach (var Text in Select)
            {
                if (Text.Value)
                {
                    DisableCollection.Add(Text.Key);
                }
            }
            this.disableCollection = DisableCollection;

            ViewMenuItems[5].IconCss = Parent.SnapConstraint.HasFlag(SnapConstraints.ShowLines) ? "sf-icon-Selection" : "sf-icon-blank";
        }
        /// <summary>
        /// This method is used to saves the diagram elements to a file.
        /// </summary>
        public async Task Download(string fileName)
        {
            string data = Parent.Diagram.SaveDiagram();
            await FileUtil.SaveAs(jsRuntime, data, fileName);
        }

        private void OnUploadSuccess(SuccessEventArgs args)
        {
            if (args.Operation != "remove")
            {
                var file1 = args.File;
                var file = file1.RawFile;
                var fileType = file1.Type.ToString();
            }
        }
        /// <summary>
        /// Occurs when an uploaded file is selected and ready for further processing.
        /// </summary>
        private async Task OnUploadFileSelected(Syncfusion.Blazor.Inputs.UploadingEventArgs args)
        {
            SfDiagramComponent Diagram = Parent.Diagram;
            if (args.FileData.Type == "json")
            {
                IsJsonLoading = true;
                await Task.Delay(100);
                string json = await FileUtil.LoadFile(jsRuntime, args.FileData);
                json = json.Replace(System.Environment.NewLine, string.Empty);
                await Parent.Diagram.LoadDiagram(json.ToString());
                IsJsonLoading = false;
            }
            else
            {

                Node Node = Diagram.SelectionSettings.Nodes[0];
                Diagram.BeginUpdate();
                Node.Shape = new ImageShape() { Type = NodeShapes.Image, Source = args.FileData.RawFile.ToString() };
                await Diagram.EndUpdate();
            }
        }
        /// <summary>
        /// Exports the diagram to an PNG/SVG/PDF/JPEG/ file.
        /// </summary>
        public async Task ExportDiagram(Syncfusion.Blazor.Diagram.DiagramExportSettings exportOptions, string exportType, string fileName)
        {
            var diagram = Parent.Diagram;
            DiagramExportFormat exportFormat = DiagramExportFormat.JPEG;
            var images = await diagram.ExportAsync(exportFormat, exportOptions);
            var Orientation = PdfPageOrientation.Landscape;
            if (exportType.ToString() == "PDF")
            {
                await ExportToPdf(fileName, Orientation, true, images);
            }
            else
            {
                exportFormat = (DiagramExportFormat)(Enum.Parse(typeof(DiagramExportFormat), exportType.ToString(), true));
                await diagram.ExportAsync(fileName, exportFormat, exportOptions);
            }
        }
        /// <summary>
        /// This method is used to exports the diagram to an PDF file.
        /// </summary>
        private async Task<string> ExportToPdf(string fileName, PdfPageOrientation orientation, bool allowDownload, string[] images)
        {
            PdfDocument document = new PdfDocument();
            document.PageSettings.Orientation = orientation;
            document.PageSettings.Margins = new PdfMargins() { Left = 0, Right = 0, Top = 0, Bottom = 0 };
            string base64String = "";
            var dict = images;
            for (int i = 0; i < dict.Count(); i++)
            {
                base64String = dict[i];
                using (MemoryStream initialStream = new MemoryStream(Convert.FromBase64String(base64String.Split("base64,")[1])))
                {
                    Stream stream = initialStream as Stream;
                    PdfPage page = document.Pages.Add();
                    PdfGraphics graphics = page.Graphics;
#pragma warning disable CA2000
                    PdfBitmap image = new PdfBitmap(stream);
#pragma warning restore CA2000
                    graphics.DrawImage(image, 0, 0);

                }
            }
            using (MemoryStream memoryStream = new MemoryStream())
            {
                document.Save(memoryStream);
                memoryStream.Position = 0;
                base64String = Convert.ToBase64String(memoryStream.ToArray());
                if (allowDownload)
                {
                    await JSRuntimeExtensions.InvokeAsync<string>(jsRuntime, "downloadPdf", new object[] { base64String, fileName });
                    base64String = string.Empty;
                }
                else
                {
                    base64String = "data:application/pdf;base64," + base64String;
                }

                document.Dispose();
            }

            return base64String;
        }
        /// <summary>
        /// Prints the diagram pages based on <see cref="DiagramPrintSettings"/>.
        /// </summary>
        /// <param name="printOptions">Specifies the configuration settings to print the diagram. </param>
        ///<returns> The <see cref="Task"/> that completes when the diagram is sent to browser print preview window for printing.</returns>
        public async Task PrintDiagram(Syncfusion.Blazor.Diagram.DiagramPrintSettings printOptions)
        {
            var diagram = Parent.Diagram;

            await diagram.PrintAsync(printOptions);
        }
        /// <summary>
        /// This method is used to enable the diagram menu items.
        /// </summary>
        public bool EnableMenuItems(string itemText, ObservableCollection<object> collection)
        {

            if (itemText != "")
            {
                var commandType = itemText.Replace(" ", "");
                if (collection.Count == 0)
                {
                    switch (commandType.ToLower())
                    {
                        case "cut":
                            return true;
                        case "copy":
                            return true;
                        case "delete":
                            return true;
                        case "duplicate":
                            return true;
                    }
                }
                if (!enablePasteButten && itemText == "Paste")
                {
                    return true;
                }
                if (itemText == "Undo")
                {

                    return !this.Parent.IsUndo;
                }
                if (itemText == "Redo")
                {
                    return !this.Parent.IsRedo;
                }
                if (itemText == "Select All")
                {
                    if (collection.Count == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// This method is used to refresh the menu bar items.
        /// </summary>
        public void StateChanged()
        {
            StateHasChanged();
        }
    }
}
