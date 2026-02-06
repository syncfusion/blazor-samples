#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Diagram;
using System;
using System.Threading.Tasks;

namespace TextToSequenceDiagram
{
    public partial class SequenceDiagramToolbar
    {
#pragma warning disable CS8618
        public TextToSequence Parent;
        public string ZoomItemDropdownContent = "100%";
        [Inject]
        protected IJSRuntime jsRuntime { get; set; }
#pragma warning restore CS8618
        private async Task ToolbarEditorClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
        {
            var value = args.Item.TooltipText;
            switch (value)
            {
                case "New Diagram":
                    Parent.Diagram!.Clear();
                    SetElements();
                    break;
                case "Open Diagram":
                    await LoadDiagram();
                    break;
                case "Save Diagram":
                    string fileName = "Sequence Diagram";
                    await Download(fileName);
                    break;
                case "Print Diagram":
                    DiagramPrintSettings print = new DiagramPrintSettings();
                    await Parent.Diagram!.PrintAsync(print);
                    break;
                case "Pan":
                    Parent.DiagramTool = DiagramInteractions.ZoomPan;
                    break;
                case "Select":
                    Parent.DiagramTool = DiagramInteractions.SingleSelect | DiagramInteractions.MultipleSelect;
                    break;
            }
            Parent.StateChanged();
        }

        private async void SelectedItem(Syncfusion.Blazor.SplitButtons.MenuEventArgs args)
        {
            var value = args.Item.Text;
            switch (value)
            {
                case "JPG":
                case "PNG":
                case "SVG":
                    await Export(value);
                    break;
            }
        }

        private void SelectedZoomItem(Syncfusion.Blazor.SplitButtons.MenuEventArgs args)
        {
            var value = args.Item.Text;
            var currentZoom = Parent.Diagram!.ScrollSettings!.CurrentZoom;
            switch (value)
            {
                case "Zoom In":
                case "Zoom Out":
                    var ZoomFactor = 0.2;
                    ZoomFactor = value == "Zoom Out" ? 1 / (1 + ZoomFactor) : (1 + ZoomFactor);
                    Parent.Diagram.Zoom(ZoomFactor, null);
                    break;
                case "Zoom to Fit":
                    FitOptions fitoption = new FitOptions()
                    {
                        Mode = FitMode.Both,
                        Region = DiagramRegion.Content,
                    };
                    Parent.Diagram.FitToPage(fitoption);
                    break;
                case "Zoom to 50%":
                    ZoomFactor = 0.5 / currentZoom;
                    Parent.Diagram.Zoom(ZoomFactor, null);
                    break;
                case "Zoom to 100%":
                    ZoomFactor = 1 / currentZoom;
                    Parent.Diagram.Zoom(ZoomFactor, null);
                    break;
                case "Zoom to 200%":
                    ZoomFactor = 2 / currentZoom;
                    Parent.Diagram.Zoom(ZoomFactor, null);
                    break;
            }
            ZoomItemDropdownContent = FormattableString.Invariant($"{Math.Round(Parent.Diagram.ScrollSettings.CurrentZoom * 100)}") + "%";
        }

        public void RefreshToolbar()
        {
            StateHasChanged();
        }
        public void SetElements()
        {
            Parent.Diagram!.ClearHistory();
            Parent.Diagram.ResetZoom();
            StateHasChanged();
        }

        public async Task LoadDiagram()
        {
            Parent.Diagram!.BeginUpdate();
            Parent.ExtensionType = ".json";
            await FileUtil.Click(jsRuntime);
            await Parent.Diagram.EndUpdateAsync();
        }

        public async Task Download(string fileName)
        {
            string data = Parent.Diagram!.SaveDiagram();
            await FileUtil.SaveAs(jsRuntime, data, fileName);
        }

        private async Task Export(string value)
        {
            DiagramExportSettings export = new DiagramExportSettings();
            export.FitToPage = true;
            if (value == "JPG")
                await Parent.Diagram!.ExportAsync("Diagram", DiagramExportFormat.JPEG, export);
            else if (value == "PNG")
                await Parent.Diagram!.ExportAsync("Diagram", DiagramExportFormat.PNG, export);
            else if (value == "SVG")
                await Parent.Diagram!.ExportAsync("Diagram", DiagramExportFormat.SVG, export);
        }
    }
}
